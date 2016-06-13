// Copyright (c) 2016 Jörg Wollenschläger
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Text;
using SharpDX.Windows;

namespace MiniTri
{
    using SharpVulkan;

    public unsafe class Sample : IDisposable
    {
        private readonly bool validate = false;

        private readonly Form form;

        private Instance instance;
        private PhysicalDevice physicalDevice;
        private Queue queue;
        private Device device;
        private DebugReportCallback debugReportCallback;
        private DebugReportCallbackDelegate debugReport;

        private Surface surface;
        private Swapchain swapchain;
        private Format backBufferFormat;
        private Image[] backBuffers;
        private ImageView[] backBufferViews;
        private uint currentBackBufferIndex;
        private Image depthStencilBuffer;
        private ImageView depthStencilView;

        private CommandPool commandPool;
        private CommandBuffer commandBuffer;
        private CommandBuffer setupCommanBuffer;

        private PipelineLayout pipelineLayout;
        private Pipeline pipeline;
        private RenderPass renderPass;
        private Framebuffer[] framebuffers;

        private DescriptorPool descriptorPool;
        private DescriptorSetLayout descriptorSetLayout;
        private Buffer uniformBuffer;

        private Buffer vertexBuffer;
        private DeviceMemory vertexBufferMemory;
        private VertexInputAttributeDescription[] vertexAttributes;
        private VertexInputBindingDescription[] vertexBindings;

        public Sample()
        {
            form = new RenderForm("SharpVulkan - Vulkan Sample");
        }

        public void Run()
        {
            //Debugger.Launch();
            Initialize();
            RenderLoop.Run(form, Draw);
        }

        protected virtual void Initialize()
        {
            CreateInstance();
            CreateSurface();
            CreateDevice();
            CreateCommandBuffer();

            CreateSwapchain();
            CreateBackBufferViews();

            CreateVertexBuffer();
            CreateRenderPass();
            CreatePipelineLayout();
            CreatePipeline();
            CreateFramebuffers();
        }

        protected virtual void CreateInstance()
        {
            var applicationInfo = new ApplicationInfo
            {
                StructureType = StructureType.ApplicationInfo,
                EngineVersion = 0,
                ApiVersion = Vulkan.ApiVersion
            };

            var enabledLayerNames = new []
            {
                Marshal.StringToHGlobalAnsi("VK_LAYER_LUNARG_standard_validation"),
            };

            var enabledExtensionNames = new []
            {
                Marshal.StringToHGlobalAnsi("VK_KHR_surface"),
                Marshal.StringToHGlobalAnsi("VK_KHR_win32_surface"),
                Marshal.StringToHGlobalAnsi("VK_EXT_debug_report"),
            };

            try
            {
                fixed (void* enabledLayerNamesPointer = &enabledLayerNames[0])
                fixed (void* enabledExtensionNamesPointer = &enabledExtensionNames[0])
                {
                    var instanceCreateInfo = new InstanceCreateInfo
                    {
                        StructureType = StructureType.InstanceCreateInfo,
                        ApplicationInfo = new IntPtr(&applicationInfo),
                        EnabledExtensionCount = (uint)enabledExtensionNames.Length,
                        EnabledExtensionNames = new IntPtr(enabledExtensionNamesPointer),
                    };

                    if (validate)
                    {
                        instanceCreateInfo.EnabledLayerCount = (uint)enabledLayerNames.Length;
                        instanceCreateInfo.EnabledLayerNames = new IntPtr(enabledLayerNamesPointer);
                    }

                    instance = Vulkan.CreateInstance(ref instanceCreateInfo);
                }

                if (validate)
                {
                    var createDebugReportCallbackName = Encoding.ASCII.GetBytes("vkCreateDebugReportCallbackEXT");
                    fixed (byte* createDebugReportCallbackNamePointer = &createDebugReportCallbackName[0])
                    {
                        var createDebugReportCallback = Marshal.GetDelegateForFunctionPointer<CreateDebugReportCallbackDelegate>(instance.GetProcAddress(createDebugReportCallbackNamePointer));

                        debugReport = DebugReport;
                        var createInfo = new DebugReportCallbackCreateInfo
                        {
                            StructureType = StructureType.DebugReportCallbackCreateInfo,
                            Flags = (uint)(DebugReportFlags.Error | DebugReportFlags.Warning | DebugReportFlags.PerformanceWarning),
                            Callback = Marshal.GetFunctionPointerForDelegate(debugReport)
                        };
                        createDebugReportCallback(instance, ref createInfo, null, out debugReportCallback);
                    }
                }
            }
            finally
            {
                foreach (var enabledExtensionName in enabledExtensionNames)
                    Marshal.FreeHGlobal(enabledExtensionName);

                foreach (var enabledLayerName in enabledLayerNames)
                    Marshal.FreeHGlobal(enabledLayerName);
            }

            physicalDevice = instance.PhysicalDevices[0];

            var props = physicalDevice.QueueFamilyProperties;
        }

        private static RawBool DebugReport(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, string layerPrefix, string message, IntPtr userData)
        {
            Debug.WriteLine($"{flags}: {message} ([{messageCode}] {layerPrefix})");
            return true;
        }

        protected virtual void CreateDevice()
        {
            uint queuePriorities = 0;
            var queueCreateInfo = new DeviceQueueCreateInfo
            {
                StructureType = StructureType.DeviceQueueCreateInfo,
                QueueFamilyIndex = 0,
                QueueCount = 1,
                QueuePriorities = new IntPtr(&queuePriorities)
            };

            var enabledLayerNames = new[]
            {
                Marshal.StringToHGlobalAnsi("VK_LAYER_LUNARG_standard_validation"),
            };

            var enabledExtensionNames = new[]
            {
                Marshal.StringToHGlobalAnsi("VK_KHR_swapchain"),
            };

            try
            {
                fixed (void* enabledLayerNamesPointer = &enabledLayerNames[0])
                fixed (void* enabledExtensionNamesPointer = &enabledExtensionNames[0])
                {
                    var enabledFeatures = new PhysicalDeviceFeatures
                    {
                        ShaderClipDistance = true,
                    };

                    var deviceCreateInfo = new DeviceCreateInfo
                    {
                        StructureType = StructureType.DeviceCreateInfo,
                        QueueCreateInfoCount = 1,
                        QueueCreateInfos = new IntPtr(&queueCreateInfo),
                        EnabledExtensionCount = (uint)enabledExtensionNames.Length,
                        EnabledExtensionNames = new IntPtr(enabledExtensionNamesPointer),
                        EnabledFeatures = new IntPtr(&enabledFeatures)
                    };

                    if (validate)
                    {
                        deviceCreateInfo.EnabledLayerCount = (uint)enabledLayerNames.Length;
                        deviceCreateInfo.EnabledLayerNames = new IntPtr(enabledLayerNamesPointer);
                    }

                    device = physicalDevice.CreateDevice(ref deviceCreateInfo);
                }
            }
            finally
            {
                foreach (var enabledExtensionName in enabledExtensionNames)
                    Marshal.FreeHGlobal(enabledExtensionName);

                foreach (var enabledLayerName in enabledLayerNames)
                    Marshal.FreeHGlobal(enabledLayerName);
            }

            var queueNodeIndex = physicalDevice.QueueFamilyProperties.
                Where((properties, index) => (properties.QueueFlags & QueueFlags.Graphics) != 0 && physicalDevice.GetSurfaceSupport((uint)index, surface)).
                Select((properties, index) => index).First();

            queue = device.GetQueue(0, (uint)queueNodeIndex);
        }

        protected virtual void CreateSurface()
        {
            var surfaceCreateInfo = new Win32SurfaceCreateInfo
            {
                StructureType = StructureType.Win32SurfaceCreateInfo,
                InstanceHandle = Process.GetCurrentProcess().Handle,
                WindowHandle = form.Handle,
            };
            surface = instance.CreateWin32Surface(surfaceCreateInfo);
        }

        protected virtual void CreateSwapchain()
        {
            // surface format
            var surfaceFormats = physicalDevice.GetSurfaceFormats(surface);
            if (surfaceFormats.Length == 1 && surfaceFormats[0].Format == Format.Undefined)
            {
                backBufferFormat = Format.B8G8R8A8UNorm;
            }
            else
            {
                backBufferFormat = surfaceFormats[0].Format;
            }

            SurfaceCapabilities surfaceCapabilities;
            physicalDevice.GetSurfaceCapabilities(surface, out surfaceCapabilities);

            // Buffer count
            uint desiredImageCount = surfaceCapabilities.MinImageCount + 1;
            if (surfaceCapabilities.MaxImageCount > 0 && desiredImageCount > surfaceCapabilities.MaxImageCount)
            {
                desiredImageCount = surfaceCapabilities.MaxImageCount;
            }

            // Transform
            SurfaceTransformFlags preTransform;
            if ((surfaceCapabilities.SupportedTransforms & SurfaceTransformFlags.Identity) != 0)
            {
                preTransform = SurfaceTransformFlags.Identity;
            }
            else
            {
                preTransform = surfaceCapabilities.CurrentTransform;
            }

            // Present mode
            var presentModes = physicalDevice.GetSurfacePresentModes(surface);

            var swapChainPresentMode = PresentMode.Fifo;
            if (presentModes.Contains(PresentMode.Mailbox))
                swapChainPresentMode = PresentMode.Mailbox;
            else if (presentModes.Contains(PresentMode.Immediate))
                swapChainPresentMode = PresentMode.Immediate;

            // Create swapchain
            var swapchainCreateInfo = new SwapchainCreateInfo
            {
                StructureType = StructureType.SwapchainCreateInfo,
                Surface = surface,
                ImageSharingMode = SharingMode.Exclusive,
                ImageExtent = new Extent2D((uint)form.ClientSize.Width, (uint)form.ClientSize.Height),
                ImageArrayLayers = 1,
                ImageFormat = backBufferFormat,
                ImageColorSpace = ColorSpace.SRgbNonlinear,
                ImageUsage = ImageUsageFlags.ColorAttachment,
                PresentMode = swapChainPresentMode,
                CompositeAlpha = CompositeAlphaFlags.Opaque,
                MinImageCount = desiredImageCount,
                PreTransform = preTransform,
                Clipped = true
                // OldSwapchain =
            };
            swapchain = device.CreateSwapchain(ref swapchainCreateInfo);

            // Initialize swapchain image layout
            backBuffers = device.GetSwapchainImages(swapchain);
            foreach (var image in backBuffers)
            {
                SetImageLayout(image, ImageAspectFlags.Color, ImageLayout.Undefined, ImageLayout.PresentSource);
            }
            Flush();
        }

        protected virtual void CreateBackBufferViews()
        {
            
            backBufferViews = new ImageView[backBuffers.Length];

            for (var i = 0; i < backBuffers.Length; i++)
            {
                var createInfo = new ImageViewCreateInfo
                {
                    StructureType = StructureType.ImageViewCreateInfo,
                    ViewType = ImageViewType.Image2D,
                    Format = backBufferFormat,
                    Image = backBuffers[i],
                    Components = ComponentMapping.Identity,
                    SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1)
                };

                backBufferViews[i] = device.CreateImageView(ref createInfo);
            }
        }

        protected virtual void CreateCommandBuffer()
        {
            // Command pool
            var commandPoolCreateInfo = new CommandPoolCreateInfo
            {
                StructureType = StructureType.CommandPoolCreateInfo,
                QueueFamilyIndex = 0,
                Flags = CommandPoolCreateFlags.ResetCommandBuffer
            };
            commandPool = device.CreateCommandPool(ref commandPoolCreateInfo);

            // Command buffer
            var commandBufferAllocationInfo = new CommandBufferAllocateInfo
            {
                StructureType = StructureType.CommandBufferAllocateInfo,
                Level = CommandBufferLevel.Primary,
                CommandPool = commandPool,
                CommandBufferCount = 1
            };
            CommandBuffer commandBuffer;
            device.AllocateCommandBuffers(ref commandBufferAllocationInfo, &commandBuffer);
            this.commandBuffer = commandBuffer;
        }

        private void CreateVertexBuffer()
        {
            var vertices = new[,]
            {
                {  0.0f, -0.5f,  0.5f, 1.0f, 0.0f, 0.0f },
                {  0.5f,  0.5f,  0.5f, 0.0f, 1.0f, 0.0f },
                { -0.5f,  0.5f,  0.5f, 0.0f, 0.0f, 1.0f },
            };

            var createInfo = new BufferCreateInfo
            {
                StructureType = StructureType.BufferCreateInfo,
                Usage = BufferUsageFlags.VertexBuffer,
                Size = (ulong)(sizeof(float) * vertices.Length)
            };
            vertexBuffer = device.CreateBuffer(ref createInfo);

            MemoryRequirements memoryRequirements;
            device.GetBufferMemoryRequirements(vertexBuffer, out memoryRequirements);

            if (memoryRequirements.Size == 0)
                return;

            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
                MemoryTypeIndex = MemoryTypeFromProperties(memoryRequirements.MemoryTypeBits, MemoryPropertyFlags.HostVisible)
            };
            vertexBufferMemory = device.AllocateMemory(ref allocateInfo);

            var mapped = device.MapMemory(vertexBufferMemory, 0, (ulong)createInfo.Size, MemoryMapFlags.None);
            fixed (float* source = &vertices[0, 0]) Utilities.CopyMemory(mapped, new IntPtr(source), (int)createInfo.Size);
            device.UnmapMemory(vertexBufferMemory);

            device.BindBufferMemory(vertexBuffer, vertexBufferMemory, 0);

            vertexAttributes = new []
            {
                new VertexInputAttributeDescription { Binding = 0, Location = 0, Format = Format.R32G32B32SFloat, Offset = 0 },
                new VertexInputAttributeDescription { Binding = 0, Location = 1, Format = Format.R32G32B32SFloat, Offset = sizeof(float) * 3 },
            };

            vertexBindings = new []
            {
                new VertexInputBindingDescription { Binding = 0, InputRate = VertexInputRate.Vertex, Stride = (uint)(sizeof(float) * vertices.GetLength(1)) }
            };
        }

        private void CreateRenderPass()
        {
            var colorAttachmentReference = new AttachmentReference { Attachment = 0, Layout = ImageLayout.ColorAttachmentOptimal };
            var depthStencilAttachmentReference = new AttachmentReference { Attachment = 1, Layout = ImageLayout.DepthStencilAttachmentOptimal };

            var subpass = new SubpassDescription
            {
                PipelineBindPoint = PipelineBindPoint.Graphics,
                ColorAttachmentCount = 1,
                ColorAttachments = new IntPtr(&colorAttachmentReference),
            };

            var attachments = new[]
            {
                new AttachmentDescription
                {
                    Format = backBufferFormat,
                    Samples = SampleCountFlags.Sample1,
                    LoadOperation = AttachmentLoadOperation.Load,
                    StoreOperation = AttachmentStoreOperation.Store,
                    StencilLoadOperation = AttachmentLoadOperation.DontCare,
                    StencilStoreOperation = AttachmentStoreOperation.DontCare,
                    InitialLayout = ImageLayout.ColorAttachmentOptimal,
                    FinalLayout = ImageLayout.ColorAttachmentOptimal
                },
            };

            fixed (AttachmentDescription* attachmentsPointer = &attachments[0])
            {
                var createInfo = new RenderPassCreateInfo
                {
                    StructureType = StructureType.RenderPassCreateInfo,
                    AttachmentCount = (uint)attachments.Length,
                    Attachments = new IntPtr(attachmentsPointer),
                    SubpassCount = 1,
                    Subpasses = new IntPtr(&subpass)
                };

                renderPass = device.CreateRenderPass(ref createInfo);
            }
        }

        private void CreateFramebuffers()
        {
            framebuffers = new Framebuffer[backBuffers.Length];
            for (int i = 0; i < backBuffers.Length; i++)
            {
                var attachment = backBufferViews[i];
                var createInfo = new FramebufferCreateInfo
                {
                    StructureType = StructureType.FramebufferCreateInfo,
                    RenderPass = renderPass,
                    AttachmentCount = 1,
                    Attachments = new IntPtr(&attachment),
                    Width = (uint)form.ClientSize.Width,
                    Height = (uint)form.ClientSize.Height,
                    Layers = 1
                };
                framebuffers[i] = device.CreateFramebuffer(ref createInfo);
            }
        }

        private unsafe void CreatePipelineLayout()
        {
            var binding = new DescriptorSetLayoutBinding
            {
                Binding = 0,
                DescriptorCount = 1,
                DescriptorType = DescriptorType.UniformBuffer,
                StageFlags = ShaderStageFlags.Vertex
            };

            var descriptorSetLayoutCreateInfo = new DescriptorSetLayoutCreateInfo
            {
                StructureType = StructureType.DescriptorSetLayoutCreateInfo,
                BindingCount = 1,
                Bindings = new IntPtr(&binding)
            };
            descriptorSetLayout = device.CreateDescriptorSetLayout(ref descriptorSetLayoutCreateInfo);

            var localDescriptorSetLayout = descriptorSetLayout;
            var createInfo = new PipelineLayoutCreateInfo
            {
                StructureType = StructureType.PipelineLayoutCreateInfo,
                SetLayoutCount = 1,
                SetLayouts = new IntPtr(&localDescriptorSetLayout)
            };
            pipelineLayout = device.CreatePipelineLayout(ref createInfo);

            var poolSize = new DescriptorPoolSize { DescriptorCount = 2, Type = DescriptorType.UniformBuffer };
            var descriptorPoolCreateinfo = new DescriptorPoolCreateInfo
            {
                StructureType = StructureType.DescriptorPoolCreateInfo,
                PoolSizeCount = 1,
                PoolSizes = new IntPtr(&poolSize),
                MaxSets = 2
            };
            descriptorPool = device.CreateDescriptorPool(ref descriptorPoolCreateinfo);

            var bufferCreateInfo = new BufferCreateInfo
            {
                StructureType = StructureType.BufferCreateInfo,
                Usage = BufferUsageFlags.UniformBuffer,
                Size = 64,
            };
            uniformBuffer = device.CreateBuffer(ref bufferCreateInfo);

            MemoryRequirements memoryRequirements;
            device.GetBufferMemoryRequirements(uniformBuffer, out memoryRequirements);
            var memory = AllocateMemory(MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent, memoryRequirements);

            device.BindBufferMemory(uniformBuffer, memory, 0);

            var mappedMemory = device.MapMemory(memory, 0, 64, MemoryMapFlags.None);
            var data = new[]
            {
                1.0f, 0.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 0.0f, 1.0f,
            };
            Utilities.Write(mappedMemory, data, 0, data.Length);
            device.UnmapMemory(memory);
        }

        protected unsafe DeviceMemory AllocateMemory(MemoryPropertyFlags memoryProperties, MemoryRequirements memoryRequirements)
        {
            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
            };

            PhysicalDeviceMemoryProperties physicalDeviceMemoryProperties;
            physicalDevice.GetMemoryProperties(out physicalDeviceMemoryProperties);

            var typeBits = memoryRequirements.MemoryTypeBits;
            for (uint i = 0; i < physicalDeviceMemoryProperties.MemoryTypeCount; i++)
            {
                if ((typeBits & 1) == 1)
                {
                    // Type is available, does it match user properties?
                    var memoryType = *((MemoryType*)&physicalDeviceMemoryProperties.MemoryTypes + i);
                    if ((memoryType.PropertyFlags & memoryProperties) == memoryProperties)
                    {
                        allocateInfo.MemoryTypeIndex = i;
                        break;
                    }
                }
                typeBits >>= 1;
            }

            return device.AllocateMemory(ref allocateInfo);
        }

        private void CreatePipeline()
        {
            var dynamicStates = new [] { DynamicState.Viewport, DynamicState.Scissor };

            var entryPointName = System.Text.Encoding.UTF8.GetBytes("main\0");

            fixed (byte* entryPointNamePointer = &entryPointName[0])
            fixed (DynamicState* dynamicStatesPointer = &dynamicStates[0])
            fixed (VertexInputAttributeDescription* vertexAttibutesPointer = &vertexAttributes[0])
            fixed (VertexInputBindingDescription* vertexBindingsPointer = &vertexBindings[0])
            {
                var dynamicState = new PipelineDynamicStateCreateInfo
                {
                    StructureType = StructureType.PipelineDynamicStateCreateInfo,
                    DynamicStateCount = (uint)dynamicStates.Length,
                    DynamicStates = new IntPtr(dynamicStatesPointer)
                };

                var viewportState = new PipelineViewportStateCreateInfo
                {
                    StructureType = StructureType.PipelineViewportStateCreateInfo,
                    ScissorCount = 1,
                    ViewportCount = 1,
                };

                var vertexInputState = new PipelineVertexInputStateCreateInfo
                {
                    StructureType = StructureType.PipelineVertexInputStateCreateInfo,
                    VertexAttributeDescriptionCount = (uint)vertexAttributes.Length,
                    VertexAttributeDescriptions = new IntPtr(vertexAttibutesPointer),
                    VertexBindingDescriptionCount = (uint)vertexBindings.Length,
                    VertexBindingDescriptions = new IntPtr(vertexBindingsPointer),
                };

                var inputAssemblyState = new PipelineInputAssemblyStateCreateInfo
                {
                    StructureType = StructureType.PipelineInputAssemblyStateCreateInfo,
                    Topology = PrimitiveTopology.TriangleList
                };

                var rasterizerState = new PipelineRasterizationStateCreateInfo
                {
                    StructureType = StructureType.PipelineRasterizationStateCreateInfo,
                    PolygonMode = PolygonMode.Fill,
                    CullMode = CullModeFlags.None,
                    FrontFace = FrontFace.Clockwise,
                    LineWidth = 1.0f,
                };

                var colorBlendAttachment = new PipelineColorBlendAttachmentState { ColorWriteMask = ColorComponentFlags.R | ColorComponentFlags.G | ColorComponentFlags.B | ColorComponentFlags.A };
                var blendState = new PipelineColorBlendStateCreateInfo
                {
                    StructureType = StructureType.PipelineColorBlendStateCreateInfo,
                    AttachmentCount = 1,
                    Attachments = new IntPtr(&colorBlendAttachment)
                };

                var depthStencilState = new PipelineDepthStencilStateCreateInfo
                {
                    StructureType = StructureType.PipelineDepthStencilStateCreateInfo,
                    DepthTestEnable = false,
                    DepthWriteEnable = true,
                    DepthCompareOperation = CompareOperation.LessOrEqual,
                    Back = new StencilOperationState { CompareOperation = CompareOperation.Always },
                    Front = new StencilOperationState { CompareOperation = CompareOperation.Always }
                };

                var multisampleState = new PipelineMultisampleStateCreateInfo
                {
                    StructureType = StructureType.PipelineMultisampleStateCreateInfo,
                    RasterizationSamples = SampleCountFlags.Sample1,
                };

                var shaderStages = new[]
                {
                    new PipelineShaderStageCreateInfo
                    {
                        StructureType = StructureType.PipelineShaderStageCreateInfo,
                        Name = new IntPtr(entryPointNamePointer),
                        Stage = ShaderStageFlags.Vertex,
                        Module = CreateVertexShader()
                    },
                    new PipelineShaderStageCreateInfo
                    {
                        StructureType = StructureType.PipelineShaderStageCreateInfo,
                        Name = new IntPtr(entryPointNamePointer),
                        Stage = ShaderStageFlags.Fragment,
                        Module = CreateFragmentShader()
                    }
                };

                fixed (PipelineShaderStageCreateInfo* shaderStagesPointer = &shaderStages[0])
                {
                    var createInfo = new GraphicsPipelineCreateInfo
                    {
                        StructureType = StructureType.GraphicsPipelineCreateInfo,
                        Layout = pipelineLayout,
                        DynamicState = new IntPtr(&dynamicState),
                        ViewportState = new IntPtr(&viewportState),
                        VertexInputState = new IntPtr(&vertexInputState),
                        InputAssemblyState = new IntPtr(&inputAssemblyState),
                        RasterizationState = new IntPtr(&rasterizerState),
                        ColorBlendState = new IntPtr(&blendState),
                        DepthStencilState = new IntPtr(&depthStencilState),
                        MultisampleState = new IntPtr(&multisampleState),
                        StageCount = (uint)shaderStages.Length,
                        Stages = new IntPtr(shaderStagesPointer),
                        RenderPass = renderPass
                    };
                    pipeline = device.CreateGraphicsPipelines(PipelineCache.Null, 1, &createInfo);
                }

                foreach (var shaderStage in shaderStages)
                {
                    device.DestroyShaderModule(shaderStage.Module);
                }
            }
        }

        private ShaderModule CreateVertexShader()
        {
            var bytes = File.ReadAllBytes("vert.spv");
            return CreateShaderModule(bytes);
        }

        private ShaderModule CreateFragmentShader()
        {
            var bytes = File.ReadAllBytes("frag.spv");
            return CreateShaderModule(bytes);
        }

        private ShaderModule CreateShaderModule(byte[] shaderCode)
        {
            fixed (byte* codePointer = &shaderCode[0])
            {
                var createInfo = new ShaderModuleCreateInfo
                {
                    StructureType = StructureType.ShaderModuleCreateInfo,
                    CodeSize = shaderCode.Length,
                    Code = new IntPtr(codePointer)
                };
                return device.CreateShaderModule(ref createInfo);
            }
        }

        private uint MemoryTypeFromProperties(uint typeBits, MemoryPropertyFlags memoryProperties)
        {
            PhysicalDeviceMemoryProperties physicalDeviceMemoryProperties;
            physicalDevice.GetMemoryProperties(out physicalDeviceMemoryProperties);
            for (uint i = 0; i < physicalDeviceMemoryProperties.MemoryTypeCount; i++)
            {
                if ((typeBits & 1) == 1)
                {
                    // Type is available, does it match user properties?
                    var memoryType = *((MemoryType*)&physicalDeviceMemoryProperties.MemoryTypes + i);
                    if ((memoryType.PropertyFlags & memoryProperties) == memoryProperties)
                    {
                        return i;
                    }
                }
                typeBits >>= 1;
            }

            throw new InvalidOperationException();
        }

        protected virtual unsafe void Draw()
        {
            var semaphoreCreateInfo = new SemaphoreCreateInfo { StructureType = StructureType.SemaphoreCreateInfo };
            var presentCompleteSemaphore = device.CreateSemaphore(ref semaphoreCreateInfo);

            try
            {
                // Get the index of the next available swapchain image
                currentBackBufferIndex = device.AcquireNextImage(this.swapchain, ulong.MaxValue, presentCompleteSemaphore, Fence.Null);
            }
            catch (SharpVulkanException e) when (e.Result == Result.ErrorOutOfDate)
            {
                // TODO: Handle resize and retry draw
                throw new NotImplementedException();
            }

            // Record drawing command buffer
            var beginInfo = new CommandBufferBeginInfo { StructureType = StructureType.CommandBufferBeginInfo };
            commandBuffer.Begin(ref beginInfo);
            DrawInternal();
            commandBuffer.End();

            // Submit
            var drawCommandBuffer = commandBuffer;
            var pipelineStageFlags = PipelineStageFlags.BottomOfPipe;
            var submitInfo = new SubmitInfo
            {
                StructureType = StructureType.SubmitInfo,
                WaitSemaphoreCount = 1,
                WaitSemaphores = new IntPtr(&presentCompleteSemaphore),
                WaitDstStageMask = new IntPtr(&pipelineStageFlags),
                CommandBufferCount = 1,
                CommandBuffers = new IntPtr(&drawCommandBuffer),
            };
            queue.Submit(1, &submitInfo, Fence.Null);

            // Present
            var swapchain = this.swapchain;
            var currentBackBufferIndexCopy = currentBackBufferIndex;
            var presentInfo = new PresentInfo
            {
                StructureType = StructureType.PresentInfo,
                SwapchainCount = 1,
                Swapchains = new IntPtr(&swapchain),
                ImageIndices = new IntPtr(&currentBackBufferIndexCopy)
            };
            queue.Present(ref presentInfo);

            // Wait
            queue.WaitIdle();

            device.ResetDescriptorPool(descriptorPool, DescriptorPoolResetFlags.None);

            // Cleanup
            device.DestroySemaphore(presentCompleteSemaphore);
        }

        private void DrawInternal()
        {
            // Update descriptors
            var descriptorSets = stackalloc DescriptorSet[2];
            var setLayouts = stackalloc DescriptorSetLayout[2];
            setLayouts[0] = setLayouts[1] = descriptorSetLayout;

            var allocateInfo = new DescriptorSetAllocateInfo
            {
                StructureType = StructureType.DescriptorSetAllocateInfo,
                DescriptorPool = descriptorPool,
                DescriptorSetCount = 2,
                SetLayouts = new IntPtr(setLayouts),
            };
            device.AllocateDescriptorSets(ref allocateInfo, descriptorSets);

            var bufferInfo = new DescriptorBufferInfo
            {
                Buffer = uniformBuffer,
                Range = Vulkan.WholeSize
            };

            var write = new WriteDescriptorSet
            {
                StructureType = StructureType.WriteDescriptorSet,
                DescriptorCount = 1,
                DestinationSet = descriptorSets[0],
                DestinationBinding = 0,
                DescriptorType = DescriptorType.UniformBuffer,
                BufferInfo = new IntPtr(&bufferInfo)
            };

            var copy = new CopyDescriptorSet
            {
                StructureType = StructureType.CopyDescriptorSet,
                DescriptorCount = 1,
                SourceBinding = 0,
                DestinationBinding = 0,
                SourceSet = descriptorSets[0],
                DestinationSet = descriptorSets[1]
            };

            device.UpdateDescriptorSets(1, &write, 0, null);
            device.UpdateDescriptorSets(0, null, 1, &copy);

            // Post-present transition
            var memoryBarrier = new ImageMemoryBarrier
            {
                StructureType = StructureType.ImageMemoryBarrier,
                Image = backBuffers[currentBackBufferIndex],
                SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1),
                OldLayout = ImageLayout.PresentSource,
                NewLayout = ImageLayout.ColorAttachmentOptimal,
                SourceAccessMask = AccessFlags.MemoryRead,
                DestinationAccessMask = AccessFlags.ColorAttachmentWrite
            };
            commandBuffer.PipelineBarrier(PipelineStageFlags.TopOfPipe, PipelineStageFlags.TopOfPipe, DependencyFlags.None, 0, null, 0, null, 1, &memoryBarrier);

            // Clear render target
            var clearRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1);
            commandBuffer.ClearColorImage(backBuffers[currentBackBufferIndex], ImageLayout.TransferDestinationOptimal, new RawColor4(0, 0, 0, 1), 1, &clearRange);

            // Begin render pass
            var renderPassBeginInfo = new RenderPassBeginInfo
            {
                StructureType = StructureType.RenderPassBeginInfo,
                RenderPass = renderPass,
                Framebuffer = framebuffers[currentBackBufferIndex],
                RenderArea = new Rect2D(0, 0, (uint)form.ClientSize.Width, (uint)form.ClientSize.Height),
            };
            commandBuffer.BeginRenderPass(ref renderPassBeginInfo, SubpassContents.Inline);

            // Bind pipeline
            commandBuffer.BindPipeline(PipelineBindPoint.Graphics, pipeline);

            // Bind descriptor sets
            commandBuffer.BindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, descriptorSets + 1, 0, null);

            // Set viewport and scissor
            var viewport = new Viewport(0, 0, form.ClientSize.Width, form.ClientSize.Height);
            commandBuffer.SetViewport(0, 1, &viewport);

            var scissor = new Rect2D(0, 0, (uint)form.ClientSize.Width, (uint)form.ClientSize.Height);
            commandBuffer.SetScissor(0, 1, &scissor);

            // Bind vertex buffer
            var vertexBufferCopy = vertexBuffer;
            ulong offset = 0;
            commandBuffer.BindVertexBuffers(0, 1, &vertexBufferCopy, &offset);

            // Draw vertices
            commandBuffer.Draw(3, 1, 0, 0);

            // End render pass
            commandBuffer.EndRenderPass();

            // Pre-present transition
            memoryBarrier = new ImageMemoryBarrier
            {
                StructureType = StructureType.ImageMemoryBarrier,
                Image = backBuffers[currentBackBufferIndex],
                SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1),
                OldLayout = ImageLayout.ColorAttachmentOptimal,
                NewLayout = ImageLayout.PresentSource,
                SourceAccessMask = AccessFlags.ColorAttachmentWrite,
                DestinationAccessMask = AccessFlags.MemoryRead
            };
            commandBuffer.PipelineBarrier(PipelineStageFlags.AllCommands, PipelineStageFlags.BottomOfPipe, DependencyFlags.None, 0, null, 0, null, 1, &memoryBarrier);
        }

        private void SetImageLayout(Image image, ImageAspectFlags imageAspect, ImageLayout oldLayout, ImageLayout newLayout)
        {
            if (setupCommanBuffer == CommandBuffer.Null)
            {
                // Create command buffer
                CommandBuffer setupCommandBuffer;
                var allocateInfo = new CommandBufferAllocateInfo
                {
                    StructureType = StructureType.CommandBufferAllocateInfo,
                    CommandPool = commandPool,
                    Level = CommandBufferLevel.Primary,
                    CommandBufferCount = 1,
                };
                device.AllocateCommandBuffers(ref allocateInfo, &setupCommandBuffer);
                setupCommanBuffer = setupCommandBuffer;

                // Begin command buffer
                var inheritanceInfo = new CommandBufferInheritanceInfo { StructureType = StructureType.CommandBufferInheritanceInfo };
                var beginInfo = new CommandBufferBeginInfo
                {
                    StructureType = StructureType.CommandBufferBeginInfo,
                    InheritanceInfo = new IntPtr(&inheritanceInfo)
                };
                setupCommanBuffer.Begin(ref beginInfo);
            }

            var imageMemoryBarrier = new ImageMemoryBarrier
            {
                StructureType = StructureType.ImageMemoryBarrier,
                OldLayout = oldLayout,
                NewLayout = newLayout,
                Image = image,
                SubresourceRange = new ImageSubresourceRange(imageAspect, 0, 1, 0, 1)
            };

            switch (newLayout)
            {
                case ImageLayout.TransferDestinationOptimal:
                    imageMemoryBarrier.DestinationAccessMask = AccessFlags.TransferRead;
                    break;
                case ImageLayout.ColorAttachmentOptimal:
                    imageMemoryBarrier.DestinationAccessMask = AccessFlags.ColorAttachmentWrite;
                    break;
                case ImageLayout.DepthStencilAttachmentOptimal:
                    imageMemoryBarrier.DestinationAccessMask = AccessFlags.DepthStencilAttachmentWrite;
                    break;
                case ImageLayout.ShaderReadOnlyOptimal:
                    imageMemoryBarrier.DestinationAccessMask = AccessFlags.ShaderRead | AccessFlags.InputAttachmentRead;
                    break;
            }

            var sourceStages = PipelineStageFlags.TopOfPipe;
            var destinationStages = PipelineStageFlags.TopOfPipe;

            setupCommanBuffer.PipelineBarrier(sourceStages, destinationStages, DependencyFlags.None, 0, null, 0, null, 1, &imageMemoryBarrier);
        }

        public void Flush()
        {
            if (this.setupCommanBuffer == CommandBuffer.Null)
                return;

            var setupCommanBuffer = this.setupCommanBuffer;

            this.setupCommanBuffer.End();

            var submitInfo = new SubmitInfo
            {
                StructureType = StructureType.SubmitInfo,
                CommandBufferCount = 1,
                CommandBuffers = new IntPtr(&setupCommanBuffer)
            };

            queue.Submit(1, &submitInfo, Fence.Null);

            queue.WaitIdle();

            device.FreeCommandBuffers(commandPool, 1, &setupCommanBuffer);

            this.setupCommanBuffer = CommandBuffer.Null;  
        }

        public void Dispose()
        {
            device.WaitIdle();

            device.FreeMemory(vertexBufferMemory);
            device.DestroyBuffer(vertexBuffer);

            foreach (var framebuffer in framebuffers)
                device.DestroyFramebuffer(framebuffer);

            device.DestroyRenderPass(renderPass);
            device.DestroyPipeline(pipeline);
            device.DestroyPipelineLayout(pipelineLayout);

            var commandBufferCopy = commandBuffer;
            device.FreeCommandBuffers(commandPool, 1, &commandBufferCopy);
            device.DestroyCommandPool(commandPool);

            foreach (var backBufferView in backBufferViews)
                device.DestroyImageView(backBufferView);

            device.DestroySwapchain(swapchain);
            instance.DestroySurface(surface);

            device.Destroy();

            if (debugReportCallback != DebugReportCallback.Null)
            {
                var destroyDebugReportCallbackName = Encoding.ASCII.GetBytes("vkDestroyDebugReportCallbackEXT");
                fixed (byte* destroyDebugReportCallbackNamePointer = &destroyDebugReportCallbackName[0])
                {
                    var destroyDebugReportCallback = Marshal.GetDelegateForFunctionPointer<DestroyDebugReportCallbackDelegate>(instance.GetProcAddress(destroyDebugReportCallbackNamePointer));
                    destroyDebugReportCallback(instance, debugReportCallback, null);
                }
            }
            instance.Destroy();
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private unsafe delegate RawBool DebugReportCallbackDelegate(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, string layerPrefix, string message, IntPtr userData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate Result CreateDebugReportCallbackDelegate(Instance instance, ref DebugReportCallbackCreateInfo createInfo, AllocationCallbacks* allocator, out DebugReportCallback callback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate Result DestroyDebugReportCallbackDelegate(Instance instance, DebugReportCallback debugReportCallback, AllocationCallbacks* allocator);

    }
}