// Copyright (c) 2016 Jg Wollenschl臠er
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
        private readonly bool validate = true;

        private readonly Form form;

        private Instance instance;
        private PhysicalDevice physicalDevice;
        private PhysicalDeviceProperties physicalDeviceProperties;
        private PhysicalDeviceFeatures physicalDeviceFeatures;
        private PhysicalDeviceMemoryProperties physicalDeviceMemoryProperties;
        private QueueFamilyProperties[] queueFamilyeProperties;

        private Queue queue;
        private Device device;
        private DebugReportCallback debugReportCallback;
        private DebugReportCallbackDelegate debugReport;

        private Surface surface;
        private Swapchain swapchain;
        private uint graphicsQueueFamilyIndex;
        private Format backBufferFormat;
        private ColorSpace colorSpace;
        private Image[] swapchainImages;
        private CommandPool commandPool;
        private uint width;
        private uint height;
        private Image depthbuffer;
        private ImageView depthbufferView;
        private Format depthFormat;
        private DeviceMemory depthbufferMemory;
        private CommandBuffer setupCommandBuffer;
        private Buffer uniformBuffer;

        private float[] uniformData = new float[4 * 4];
        private DescriptorSetLayout descriptorSetLayout;
        private PipelineLayout pipelineLayout;
        private RenderPass renderPass;
        private Pipeline pipeline;
        private DescriptorPool descriptorPool;
        private ImageView[] swapchainImageViews;
        private Framebuffer[] framebuffers;
        private uint currentBufferIndex;
        private CommandBuffer drawCommandBuffer;
        private DescriptorSet descriptorSet;
        private Sampler textureSampler;
        private ImageView textureView;
        private Image texture;
        private Buffer vertexBuffer;
        private DeviceMemory vertexBufferMemory;
        private float[,] vertices;

        public Sample()
        {
            form = new RenderForm("SharpVulkan - Vulkan Sample");
        }

        public void Run()
        {
            width = (uint)form.ClientSize.Width;
            height = (uint)form.ClientSize.Height;

            Initialize();

            RenderLoop.Run(form, Draw);
        }

        protected virtual void Initialize()
        {
            CreateInstance();
            CreateSurface();
            CreateDevice();
            CreateCommandPool();

            CreateSwapchain();
            CreateBackBufferViews();
            CreateDepthBuffer();

            CreateTexture();
            CreateUniformBuffer();
            CreateVertexBuffer();

            CreateDescriptorLayout();
            CreateRenderPass();
            CreatePipeline();

            CreateDescriptorPool();
            CreateFramebuffer();

            FlushInitCommand();
        }

        private void CreateCommandPool()
        {
            var createInfo = new CommandPoolCreateInfo
            {
                StructureType = StructureType.CommandPoolCreateInfo,
                QueueFamilyIndex = graphicsQueueFamilyIndex,
            };
            commandPool = device.CreateCommandPool(ref createInfo);
        }

        private void CreateVertexBuffer()
        {
            vertices = new[,]
            {
                {  -1.0f, -1.0f,  -1.0f, 1.0f, 0.0f, 0.0f },
                {   1.0f, -1.0f,  -1.0f, 1.0f, 1.0f, 0.0f },
                {   1.0f,  1.0f,  -1.0f, 1.0f, 1.0f, 1.0f },

                {   1.0f,  1.0f,  -1.0f, 1.0f, 1.0f, 1.0f },
                {  -1.0f,  1.0f,  -1.0f, 1.0f, 0.0f, 0.0f },
                {  -1.0f, -1.0f,  -1.0f, 1.0f, 0.0f, 0.0f },
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

            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
                MemoryTypeIndex = GetMemoryTypeFromProperties(memoryRequirements.MemoryTypeBits, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent)
            };
            vertexBufferMemory = device.AllocateMemory(ref allocateInfo);

            var mapped = device.MapMemory(vertexBufferMemory, 0, (ulong)createInfo.Size, MemoryMapFlags.None);
            fixed (float* source = &vertices[0, 0]) Utilities.CopyMemory(mapped, new IntPtr(source), (int)createInfo.Size);
            device.UnmapMemory(vertexBufferMemory);

            device.BindBufferMemory(vertexBuffer, vertexBufferMemory, 0);
        }

        private void CreateDevice()
        {
            float priority = 0.0f;

            var queueCreateInfo = new DeviceQueueCreateInfo
            {
                StructureType = StructureType.DeviceQueueCreateInfo,
                QueueFamilyIndex = graphicsQueueFamilyIndex,
                QueueCount = 1,
                QueuePriorities = new IntPtr(&priority)
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

            // Select queue family
            var supportsPresent = queueFamilyeProperties.Select((x, i) => physicalDevice.GetSurfaceSupport((uint)i, surface)).ToArray();

            graphicsQueueFamilyIndex = uint.MaxValue;
            uint presentQueueNodeIndex = uint.MaxValue;
            for (uint i = 0; i < queueFamilyeProperties.Length; i++)
            {
                if ((queueFamilyeProperties[i].QueueFlags & QueueFlags.Graphics) != 0)
                {
                    if (graphicsQueueFamilyIndex == uint.MaxValue)
                    {
                        graphicsQueueFamilyIndex = i;
                    }

                    if (supportsPresent[i])
                    {
                        graphicsQueueFamilyIndex = i;
                        presentQueueNodeIndex = i;
                        break;
                    }
                }
            }
            if (presentQueueNodeIndex == uint.MaxValue)
            {
                for (uint i = 0; i < queueFamilyeProperties.Length; ++i)
                {
                    if (supportsPresent[i])
                    {
                        presentQueueNodeIndex = i;
                        break;
                    }
                }
            }

            if (graphicsQueueFamilyIndex == uint.MaxValue || presentQueueNodeIndex == uint.MaxValue)
            {
                throw new NotImplementedException();
            }

            if (graphicsQueueFamilyIndex != presentQueueNodeIndex)
            {
                throw new NotImplementedException();
            }

            // Get queue
            queue = device.GetQueue(graphicsQueueFamilyIndex, 0);
        }

        private void CreateSurface()
        {
            var surfaceCreateInfo = new Win32SurfaceCreateInfo
            {
                StructureType = StructureType.Win32SurfaceCreateInfo,
                InstanceHandle = Process.GetCurrentProcess().Handle,
                WindowHandle = form.Handle,
            };
            surface = instance.CreateWin32Surface(surfaceCreateInfo);
        }

        private void FlushInitCommand()
        {
            if (setupCommandBuffer == CommandBuffer.Null)
                return;

            setupCommandBuffer.End();

            var commandBuffer = setupCommandBuffer;
            var submitInfo = new SubmitInfo
            {
                StructureType = StructureType.SubmitInfo,
                CommandBufferCount = 1,
                CommandBuffers = new IntPtr(&commandBuffer)
            };

            queue.Submit(1, &submitInfo, Fence.Null);

            queue.WaitIdle();

            device.FreeCommandBuffers(commandPool, 1, &commandBuffer);
            setupCommandBuffer = CommandBuffer.Null;
        }

        private void CreateFramebuffer()
        {
            var attachments = stackalloc ImageView[2];
            attachments[1] = depthbufferView;

            var createInfo = new FramebufferCreateInfo
            {
                StructureType = StructureType.FramebufferCreateInfo,
                RenderPass = renderPass,
                AttachmentCount = 2,
                Attachments = new IntPtr(attachments),
                Width = width,
                Height = height,
                Layers = 1
            };

            framebuffers = new Framebuffer[swapchainImages.Length];
            for (int i = 0; i < swapchainImages.Length; i++)
            {
                attachments[0] = swapchainImageViews[i];
                framebuffers[i] = device.CreateFramebuffer(ref createInfo);
            }
        }

        private void CreateDescriptorPool()
        {
            var typeCounts = stackalloc DescriptorPoolSize[2];
            typeCounts[0] = new DescriptorPoolSize { Type = DescriptorType.UniformBuffer, DescriptorCount = 2 };
            typeCounts[1] = new DescriptorPoolSize { Type = DescriptorType.CombinedImageSampler, DescriptorCount = 2 };

            var createInfo = new DescriptorPoolCreateInfo
            {
                StructureType = StructureType.DescriptorPoolCreateInfo,
                MaxSets = 2,
                PoolSizeCount = 2,
                PoolSizes = new IntPtr(typeCounts)
            };

            descriptorPool = device.CreateDescriptorPool(ref createInfo);
        }

        private void CreatePipeline()
        {
            var dynamicStates = stackalloc DynamicState[2];
            dynamicStates[0] = DynamicState.Viewport;
            dynamicStates[1] = DynamicState.Scissor;

            var dynamicStateCreateInfo = new PipelineDynamicStateCreateInfo
            {
                StructureType = StructureType.PipelineDynamicStateCreateInfo,
                DynamicStateCount = 2,
                DynamicStates = new IntPtr(dynamicStates)
            };

            var vertexBinding = new VertexInputBindingDescription { Binding = 0, InputRate = VertexInputRate.Vertex, Stride = (uint)(sizeof(float) * vertices.GetLength(1)) };
            var vertexAttributes = stackalloc VertexInputAttributeDescription[2];
            vertexAttributes[0] = new VertexInputAttributeDescription { Binding = 0, Location = 0, Format = Format.R32G32B32SFloat, Offset = 0 };
            vertexAttributes[1] = new VertexInputAttributeDescription { Binding = 0, Location = 1, Format = Format.R32G32B32SFloat, Offset = sizeof(float) * 3 };

            var vertexInputStateCreateInfo = new PipelineVertexInputStateCreateInfo
            {
                StructureType = StructureType.PipelineVertexInputStateCreateInfo,
                VertexAttributeDescriptionCount = 2,
                VertexAttributeDescriptions = new IntPtr(vertexAttributes),
                VertexBindingDescriptionCount = 1,
                VertexBindingDescriptions = new IntPtr(&vertexBinding)
            };

            var inputAssemblyStateCreateInfo = new PipelineInputAssemblyStateCreateInfo
            {
                StructureType = StructureType.PipelineInputAssemblyStateCreateInfo,
                Topology = PrimitiveTopology.TriangleList
            };

            var rasterizerStateCreateInfo = new PipelineRasterizationStateCreateInfo
            {
                StructureType = StructureType.PipelineRasterizationStateCreateInfo,
                PolygonMode = PolygonMode.Fill,
                CullMode = CullModeFlags.Back,
                FrontFace = FrontFace.CounterClockwise,
                LineWidth = 1.0f
            };

            var colorBlendAttachment = new PipelineColorBlendAttachmentState
            {
                ColorWriteMask = (ColorComponentFlags)0xF
            };
            var colorBlendStateCreateInfo = new PipelineColorBlendStateCreateInfo
            {
                StructureType = StructureType.PipelineColorBlendStateCreateInfo,
                AttachmentCount = 1,
                Attachments = new IntPtr(&colorBlendAttachment)
            };

            var viewportStateCreateInfo = new PipelineViewportStateCreateInfo()
            {
                StructureType = StructureType.PipelineViewportStateCreateInfo,
                ViewportCount = 1,
                ScissorCount = 1
            };

            var depthStencilStateCreateInfo = new PipelineDepthStencilStateCreateInfo
            {
                StructureType = StructureType.PipelineDepthStencilStateCreateInfo,
                DepthTestEnable = true,
                DepthWriteEnable = true,
                DepthCompareOperation = CompareOperation.LessOrEqual,
                Back = new StencilOperationState
                {
                    FailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Keep,
                    CompareOperation = CompareOperation.Always
                },
                Front = new StencilOperationState
                {
                    FailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Keep,
                    CompareOperation = CompareOperation.Always
                }
            };

            var multisampleStateCreateInfo = new PipelineMultisampleStateCreateInfo
            {
                StructureType = StructureType.PipelineMultisampleStateCreateInfo,
                RasterizationSamples = SampleCountFlags.Sample1
            };

            var entryPointName = System.Text.Encoding.UTF8.GetBytes("main\0");
            fixed (byte* entryPointNamePointer = &entryPointName[0])
            {
                var shaderStages = stackalloc PipelineShaderStageCreateInfo[2];
                shaderStages[0] = new PipelineShaderStageCreateInfo
                {
                    StructureType = StructureType.PipelineShaderStageCreateInfo,
                    Stage = ShaderStageFlags.Vertex,
                    Name = new IntPtr(entryPointNamePointer),
                    Module = PrepareVertexShader()
                };

                shaderStages[1] = new PipelineShaderStageCreateInfo
                {
                    StructureType = StructureType.PipelineShaderStageCreateInfo,
                    Stage = ShaderStageFlags.Fragment,
                    Name = new IntPtr(entryPointNamePointer),
                    Module = PrepareFragmentShader()
                };

                var pipelineCreateInfo = new GraphicsPipelineCreateInfo
                {
                    StructureType = StructureType.GraphicsPipelineCreateInfo,
                    Layout = pipelineLayout,

                    VertexInputState = new IntPtr(&vertexInputStateCreateInfo),
                    InputAssemblyState = new IntPtr(&inputAssemblyStateCreateInfo),
                    RasterizationState = new IntPtr(&rasterizerStateCreateInfo),
                    ColorBlendState = new IntPtr(&colorBlendStateCreateInfo),
                    MultisampleState = new IntPtr(&multisampleStateCreateInfo),
                    ViewportState = new IntPtr(&viewportStateCreateInfo),
                    DepthStencilState = new IntPtr(&depthStencilStateCreateInfo),
                    StageCount = 2,
                    Stages = new IntPtr(shaderStages),
                    DynamicState = new IntPtr(&dynamicStateCreateInfo),
                    RenderPass = renderPass,
                };

                pipeline = device.CreateGraphicsPipelines(PipelineCache.Null, 1, &pipelineCreateInfo);
            }
        }

        private ShaderModule PrepareFragmentShader()
        {
            var bytes = File.ReadAllBytes("frag.spv");
            return CreateShaderModule(bytes);
        }

        private ShaderModule PrepareVertexShader()
        {
            var bytes = File.ReadAllBytes("vert.spv");
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

        private void CreateRenderPass()
        {
            var attachments = stackalloc AttachmentDescription[2];
            attachments[0] = new AttachmentDescription
            {
                Format = backBufferFormat,
                Samples = SampleCountFlags.Sample1,
                LoadOperation = AttachmentLoadOperation.Clear,
                StoreOperation = AttachmentStoreOperation.Store,
                StencilLoadOperation = AttachmentLoadOperation.DontCare,
                StencilStoreOperation = AttachmentStoreOperation.DontCare,
                InitialLayout = ImageLayout.ColorAttachmentOptimal,
                FinalLayout = ImageLayout.ColorAttachmentOptimal
            };

            attachments[1] = new AttachmentDescription
            {
                Format = depthFormat,
                Samples = SampleCountFlags.Sample1,
                LoadOperation = AttachmentLoadOperation.Clear,
                StoreOperation = AttachmentStoreOperation.DontCare,
                StencilLoadOperation = AttachmentLoadOperation.DontCare,
                StencilStoreOperation = AttachmentStoreOperation.DontCare,
                InitialLayout = ImageLayout.DepthStencilAttachmentOptimal,
                FinalLayout = ImageLayout.DepthStencilAttachmentOptimal
            };

            var colorReference = new AttachmentReference { Attachment = 0, Layout = ImageLayout.ColorAttachmentOptimal };
            var depthReference = new AttachmentReference { Attachment = 1, Layout = ImageLayout.DepthStencilAttachmentOptimal };

            var subpass = new SubpassDescription
            {
                PipelineBindPoint = PipelineBindPoint.Graphics,
                ColorAttachmentCount = 1,
                ColorAttachments = new IntPtr(&colorReference),
                DepthStencilAttachment = new IntPtr(&depthReference),
            };

            var renderPassCreateInfo = new RenderPassCreateInfo
            {
                StructureType = StructureType.RenderPassCreateInfo,
                AttachmentCount = 2,
                Attachments = new IntPtr(attachments),
                SubpassCount = 1,
                Subpasses = new IntPtr(&subpass)
            };

            renderPass = device.CreateRenderPass(ref renderPassCreateInfo);
        }

        private void CreateDescriptorLayout()
        {
            var layoutBindings = stackalloc DescriptorSetLayoutBinding[2];
            layoutBindings[0] = new DescriptorSetLayoutBinding { Binding = 0, DescriptorType = DescriptorType.UniformBuffer, DescriptorCount = 1, StageFlags = ShaderStageFlags.Vertex };
            layoutBindings[1] = new DescriptorSetLayoutBinding { Binding = 1, DescriptorType = DescriptorType.CombinedImageSampler, DescriptorCount = 1, StageFlags = ShaderStageFlags.Fragment };

            var setLayoutCreateInfo = new DescriptorSetLayoutCreateInfo
            {
                StructureType = StructureType.DescriptorSetLayoutCreateInfo,
                BindingCount = 2,
                Bindings = new IntPtr(layoutBindings)
            };

            var descriptorSetLayoutCopy = descriptorSetLayout = device.CreateDescriptorSetLayout(ref setLayoutCreateInfo);

            var pipelineLayoutCreateInfo = new PipelineLayoutCreateInfo
            {
                StructureType = StructureType.PipelineLayoutCreateInfo,
                SetLayoutCount = 1,
                SetLayouts = new IntPtr(&descriptorSetLayoutCopy)
            };

            pipelineLayout = device.CreatePipelineLayout(ref pipelineLayoutCreateInfo);
        }

        private void CreateUniformBuffer()
        {
            var bufferCreateInfo = new BufferCreateInfo
            {
                StructureType = StructureType.BufferCreateInfo,
                Usage = BufferUsageFlags.UniformBuffer,
                Size = (ulong)(sizeof(float) * uniformData.Length)
            };

            uniformData[0] = uniformData[5] = uniformData[10] = 0.5f;
            uniformData[15] = 1.0f;
            uniformData[14] = 0.25f;

            uniformBuffer = device.CreateBuffer(ref bufferCreateInfo);

            MemoryRequirements memoryRequirements;
            device.GetBufferMemoryRequirements(uniformBuffer, out memoryRequirements);

            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
                MemoryTypeIndex = GetMemoryTypeFromProperties(memoryRequirements.MemoryTypeBits, MemoryPropertyFlags.HostVisible | MemoryPropertyFlags.HostCoherent)
            };

            var memory = device.AllocateMemory(ref allocateInfo);

            var mapped = device.MapMemory(memory, 0, allocateInfo.AllocationSize, MemoryMapFlags.None);
            Utilities.Write(mapped, uniformData, 0, uniformData.Length);
            device.UnmapMemory(memory);

            device.BindBufferMemory(uniformBuffer, memory, 0);
        }

        private void CreateTexture()
        {
            var textureFormat = Format.R8G8B8A8UNorm;

            FormatProperties formatProperties;
            physicalDevice.GetFormatProperties(textureFormat, out formatProperties);

            var imageCreateInfo = new ImageCreateInfo
            {
                StructureType = StructureType.ImageCreateInfo,
                ImageType = ImageType.Image2D,
                Format = textureFormat,
                Extent = new Extent3D(100, 100, 1),
                MipLevels = 1,
                ArrayLayers = 1,
                Samples = SampleCountFlags.Sample1,
                Tiling = ImageTiling.Optimal,
                Usage = ImageUsageFlags.Sampled | ImageUsageFlags.TransferDestination,
                InitialLayout = ImageLayout.Undefined
            };
            texture = device.CreateImage(ref imageCreateInfo);

            MemoryRequirements memoryRequirements;
            device.GetImageMemoryRequirements(texture, out memoryRequirements);

            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
                MemoryTypeIndex = GetMemoryTypeFromProperties(memoryRequirements.MemoryTypeBits, MemoryPropertyFlags.DeviceLocal)
            };
            var memory = device.AllocateMemory(ref allocateInfo);
            
            device.BindImageMemory(texture, memory, 0);

            var clearValue = new ClearColorValue()
            {
                Float32 =
                {
                    Value0 = 1.0f,
                    Value1 = 1.0f,
                    Value2 = 1.0f,
                    Value3 = 1.0f,
                }
            };
            var clearRange = new ImageSubresourceRange(ImageAspectFlags.Color);

            SetImageLayout(texture, ImageAspectFlags.Color, ImageLayout.Undefined, ImageLayout.TransferDestinationOptimal, AccessFlags.None);
            setupCommandBuffer.ClearColorImage(texture, ImageLayout.TransferDestinationOptimal, clearValue, 1, &clearRange);
            SetImageLayout(texture, ImageAspectFlags.Color, ImageLayout.TransferDestinationOptimal, ImageLayout.ShaderReadOnlyOptimal, AccessFlags.TransferWrite);

            var imageCreateView = new ImageViewCreateInfo
            {
                StructureType = StructureType.ImageViewCreateInfo,
                Image = texture,
                ViewType = ImageViewType.Image2D,
                Format = textureFormat,
                Components = ComponentMapping.Identity,
                SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1)
            };
            textureView = device.CreateImageView(ref imageCreateView);

            var samplerCreateInfo = new SamplerCreateInfo
            {
                StructureType = StructureType.SamplerCreateInfo,
                MagFilter = Filter.Nearest,
                MinFilter = Filter.Nearest,
                MipmapMode = SamplerMipmapMode.Nearest,
                AddressModeU = SamplerAddressMode.MirrorClampToEdge,
                AddressModeV = SamplerAddressMode.MirrorClampToEdge,
                AddressModeW = SamplerAddressMode.MirrorClampToEdge,
                MaxAnisotropy = 1,
                CompareOperation = CompareOperation.Never,
                BorderColor = BorderColor.FloatOpaqueWhite,
            };
            textureSampler = device.CreateSampler(ref samplerCreateInfo);
        }

        private void CreateDepthBuffer()
        {
            depthFormat = Format.D16UNorm;

            var imageCreateInfo = new ImageCreateInfo
            {
                StructureType = StructureType.ImageCreateInfo,
                ImageType = ImageType.Image2D,
                Format = depthFormat,
                Extent = new Extent3D(width, height, 1),
                MipLevels = 1,
                ArrayLayers = 1,
                Samples = SampleCountFlags.Sample1,
                Tiling = ImageTiling.Optimal,
                Usage = ImageUsageFlags.DepthStencilAttachment
            };
            depthbuffer = device.CreateImage(ref imageCreateInfo);

            MemoryRequirements memoryRequirements;
            device.GetImageMemoryRequirements(depthbuffer, out memoryRequirements);

            var allocateInfo = new MemoryAllocateInfo
            {
                StructureType = StructureType.MemoryAllocateInfo,
                AllocationSize = memoryRequirements.Size,
                MemoryTypeIndex = GetMemoryTypeFromProperties(memoryRequirements.MemoryTypeBits, MemoryPropertyFlags.None)
            };
            depthbufferMemory = device.AllocateMemory(ref allocateInfo);

            device.BindImageMemory(depthbuffer, depthbufferMemory, 0);

            SetImageLayout(depthbuffer, ImageAspectFlags.Depth, ImageLayout.Undefined, ImageLayout.DepthStencilAttachmentOptimal, 0);

            var viewCreateInfo = new ImageViewCreateInfo
            {
                StructureType = StructureType.ImageViewCreateInfo,
                Image = depthbuffer,
                Format = depthFormat,
                SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Depth, 0, 1, 0, 1),
                ViewType = ImageViewType.Image2D
            };
            depthbufferView = device.CreateImageView(ref viewCreateInfo);
        }

        private void SetImageLayout(Image image, ImageAspectFlags imageAspect, ImageLayout oldLayout, ImageLayout newLayout, AccessFlags sourceAccessMask)
        {
            if (setupCommandBuffer == CommandBuffer.Null)
            {
                var allocateInfo = new CommandBufferAllocateInfo
                {
                    StructureType = StructureType.CommandBufferAllocateInfo,
                    CommandPool = commandPool,
                    CommandBufferCount = 1,
                    Level = CommandBufferLevel.Primary
                };

                CommandBuffer commandBuffer;
                device.AllocateCommandBuffers(ref allocateInfo, &commandBuffer);
                setupCommandBuffer = commandBuffer;

                var inheritanceInfo = new CommandBufferInheritanceInfo
                {
                    StructureType = StructureType.CommandBufferInheritanceInfo,
                };

                var beginInfo = new CommandBufferBeginInfo
                {
                    StructureType = StructureType.CommandBufferBeginInfo,
                    InheritanceInfo = new IntPtr(&inheritanceInfo)
                };
                commandBuffer.Begin(ref beginInfo);
            }

            var destinationAccessMask = AccessFlags.None;
            if (newLayout == ImageLayout.TransferDestinationOptimal)
            {
                destinationAccessMask = AccessFlags.TransferWrite;
            }

            if (newLayout == ImageLayout.ColorAttachmentOptimal)
            {
                destinationAccessMask = AccessFlags.ColorAttachmentWrite;
            }

            if (newLayout == ImageLayout.DepthStencilAttachmentOptimal)
            {
                destinationAccessMask = AccessFlags.DepthStencilAttachmentWrite;
            }

            if (newLayout == ImageLayout.ShaderReadOnlyOptimal)
            {
                destinationAccessMask = AccessFlags.ShaderRead | AccessFlags.InputAttachmentRead;
            }

            var imageMemoryBarrier = new ImageMemoryBarrier(image, oldLayout, newLayout, sourceAccessMask, destinationAccessMask, new ImageSubresourceRange(imageAspect));

            setupCommandBuffer.PipelineBarrier(PipelineStageFlags.TopOfPipe, PipelineStageFlags.TopOfPipe, 0, 0, null, 0, null, 1, &imageMemoryBarrier);
        }

        private uint GetMemoryTypeFromProperties(uint typeBits, MemoryPropertyFlags requiredMemoryTypeMask)
        {
            fixed (MemoryType* memoryTypes = &physicalDeviceMemoryProperties.MemoryTypes.Value0)
            {
                for (uint i = 0; i < 32; i++)
                {
                    if ((typeBits & 1) == 1)
                    {
                        var memoryType = memoryTypes + i;
                        if ((memoryType->PropertyFlags & requiredMemoryTypeMask) == requiredMemoryTypeMask)
                        {
                            return i;
                        }
                    }
                    typeBits >>= 1;
                }
            }

            throw new NotSupportedException();
        }

        private void CreateSwapchain()
        {
            var surfaceFormats = physicalDevice.GetSurfaceFormats(surface);

            if (surfaceFormats.Length == 1 && surfaceFormats[0].Format == Format.Undefined)
            {
                backBufferFormat = Format.R8G8B8A8UNorm;
            }
            else
            {
                backBufferFormat = surfaceFormats[0].Format;
            }
            colorSpace = surfaceFormats[0].ColorSpace;

            var oldSwapchain = swapchain;

            SurfaceCapabilities surfaceCapabilities;
            physicalDevice.GetSurfaceCapabilities(surface, out surfaceCapabilities);

            var presentModes = physicalDevice.GetSurfacePresentModes(surface);

            Extent2D swapchainExtent;
            if (surfaceCapabilities.CurrentExtent.Width == unchecked((uint)-1))
            {
                swapchainExtent.Width = width;
                swapchainExtent.Height = height;
            }
            else
            {
                swapchainExtent = surfaceCapabilities.CurrentExtent;
                width = swapchainExtent.Width;
                height = swapchainExtent.Height;
            }

            var swapchainPresentMode = PresentMode.Fifo;
            for (uint i = 0; i < presentModes.Length; i++)
            {
                if (presentModes[i] == PresentMode.Mailbox)
                {
                    swapchainPresentMode = PresentMode.Mailbox;
                    break;
                }
                if ((swapchainPresentMode != PresentMode.Mailbox) &&
                    (presentModes[i] == PresentMode.Immediate))
                {
                    swapchainPresentMode = PresentMode.Immediate;
                }
            }

            var desiredBufferCount = surfaceCapabilities.MinImageCount + 1;
            if ((surfaceCapabilities.MaxImageCount > 0) && (desiredBufferCount > surfaceCapabilities.MaxImageCount))
            {
                // Application must settle for fewer images than desired:
                desiredBufferCount = surfaceCapabilities.MaxImageCount;
            }

            SurfaceTransformFlags preTransform;
            if ((surfaceCapabilities.SupportedTransforms & SurfaceTransformFlags.Identity) != 0)
            {
                preTransform = SurfaceTransformFlags.Identity;
            }
            else
            {
                preTransform = surfaceCapabilities.CurrentTransform;
            }

            var swapchainCreateInfo = new SwapchainCreateInfo
            {
                StructureType = StructureType.SwapchainCreateInfo,
                Surface = surface,
                MinImageCount = desiredBufferCount,
                ImageFormat = backBufferFormat,
                ImageColorSpace = colorSpace,
                ImageExtent = swapchainExtent,
                ImageUsage = ImageUsageFlags.ColorAttachment,
                PreTransform = preTransform,
                CompositeAlpha = CompositeAlphaFlags.Opaque,
                ImageArrayLayers = 1,
                ImageSharingMode = SharingMode.Exclusive,
                PresentMode = swapchainPresentMode,
                OldSwapchain = oldSwapchain,
                Clipped = true
            };

            swapchain = device.CreateSwapchain(ref swapchainCreateInfo);

            swapchainImages = device.GetSwapchainImages(swapchain);
            swapchainImageViews = new ImageView[swapchainImages.Length];
        }

        private void CreateBackBufferViews()
        {
            for (int i = 0; i < swapchainImages.Length; i++)
            {
                var viewCreateInfo = new ImageViewCreateInfo
                {
                    StructureType = StructureType.ImageViewCreateInfo,
                    Image = swapchainImages[i],
                    Format = backBufferFormat,
                    Components = ComponentMapping.Identity,
                    SubresourceRange = new ImageSubresourceRange(ImageAspectFlags.Color, 0, 1, 0, 1),
                    ViewType = ImageViewType.Image2D
                };

                swapchainImageViews[i] = device.CreateImageView(ref viewCreateInfo);
            }
        }

        protected virtual void CreateInstance()
        {
            var applicationInfo = new ApplicationInfo
            {
                StructureType = StructureType.ApplicationInfo,
                EngineVersion = 0,
                ApiVersion = new Version(1, 0, 0)
            };

            var enabledLayerNames = new[]
            {
                Marshal.StringToHGlobalAnsi("VK_LAYER_LUNARG_standard_validation"),
            };

            var enabledExtensionNames = new[]
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
                            Flags = (uint)(DebugReportFlags.Error | DebugReportFlags.Warning /* | DebugReportFlags.PerformanceWarning*/),
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

            physicalDevice.GetProperties(out physicalDeviceProperties);

            queueFamilyeProperties = physicalDevice.QueueFamilyProperties;
            if (!queueFamilyeProperties.Any(x => (x.QueueFlags & QueueFlags.Graphics) != 0))
            {
                throw new NotSupportedException();
            }

            physicalDevice.GetFeatures(out physicalDeviceFeatures);

            physicalDevice.GetMemoryProperties(out physicalDeviceMemoryProperties);
        }

        private static RawBool DebugReport(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, string layerPrefix, string message, IntPtr userData)
        {
            Debug.WriteLine($"{flags}: {message} ([{messageCode}] {layerPrefix})");
            return true;
        }

        private void Draw()
        {
            var presentCompleteSemaphoreCreateInfo = new SemaphoreCreateInfo
            {
                StructureType = StructureType.SemaphoreCreateInfo
            };

            var presentCompleteSemaphore = device.CreateSemaphore(ref presentCompleteSemaphoreCreateInfo);

            try
            {
                currentBufferIndex = device.AcquireNextImage(swapchain, ulong.MaxValue, presentCompleteSemaphore, Fence.Null);
            }
            catch (SharpVulkanException e) when (e.Result == Result.ErrorOutOfDate)
            {
                throw new NotImplementedException();
            }
            
            FlushInitCommand();

            PrepareDescriptorSet();

            RecordDrawCommand();

            var commandBuffer = drawCommandBuffer;
            var waitStageFlags = PipelineStageFlags.BottomOfPipe;
            var submitInfo = new SubmitInfo
            {
                StructureType = StructureType.SubmitInfo,
                WaitSemaphoreCount = 1,
                WaitSemaphores = new IntPtr(&presentCompleteSemaphore),
                WaitDstStageMask = new IntPtr(&waitStageFlags),
                CommandBufferCount = 1,
                CommandBuffers = new IntPtr(&commandBuffer)
            };
            queue.Submit(1, &submitInfo, Fence.Null);

            var swapchainCopy = swapchain;
            var currentBufferIndexCopy = currentBufferIndex;
            var presentInfo = new PresentInfo
            {
                StructureType = StructureType.PresentInfo,
                SwapchainCount = 1,
                Swapchains = new IntPtr(&swapchainCopy),
                ImageIndices = new IntPtr(&currentBufferIndexCopy)
            };

            try
            {
                queue.Present(ref presentInfo);
            }
            catch (SharpVulkanException e) when (e.Result == Result.ErrorOutOfDate)
            {
                throw new NotImplementedException();
            }

            queue.WaitIdle();

            device.DestroySemaphore(presentCompleteSemaphore);

            device.ResetCommandPool(commandPool, CommandPoolResetFlags.None);

            device.ResetDescriptorPool(descriptorPool, DescriptorPoolResetFlags.None);
        }

        private void RecordDrawCommand()
        {
            var allocateInfo = new CommandBufferAllocateInfo
            {
                StructureType = StructureType.CommandBufferAllocateInfo,
                CommandPool = commandPool,
                Level = CommandBufferLevel.Primary,
                CommandBufferCount = 1
            };

            CommandBuffer commandBuffer;
            device.AllocateCommandBuffers(ref allocateInfo, &commandBuffer);
            drawCommandBuffer = commandBuffer;

            var inheritanceInfo = new CommandBufferInheritanceInfo { StructureType = StructureType.CommandBufferInheritanceInfo };

            var beginInfo = new CommandBufferBeginInfo
            {
                StructureType = StructureType.CommandBufferBeginInfo,
                InheritanceInfo = new IntPtr(&inheritanceInfo)
            };

            commandBuffer.Begin(ref beginInfo);

            var imageMemoryBarrier = new ImageMemoryBarrier(swapchainImages[currentBufferIndex], ImageLayout.Undefined, ImageLayout.ColorAttachmentOptimal, AccessFlags.None, AccessFlags.ColorAttachmentWrite, new ImageSubresourceRange(ImageAspectFlags.Color));
            commandBuffer.PipelineBarrier(PipelineStageFlags.AllCommands, PipelineStageFlags.BottomOfPipe, 0, 0, null, 0, null, 1, &imageMemoryBarrier);

            var clearValues = stackalloc ClearValue[2];
            clearValues[0] = new ClearValue();
            clearValues[1] = new ClearValue { DepthStencil = new ClearDepthStencilValue(1.0f, 0) };

            var renderPassBeginInfo = new RenderPassBeginInfo
            {
                StructureType = StructureType.RenderPassBeginInfo,
                RenderPass = renderPass,
                RenderArea = new Rect2D(0, 0, width, height),
                ClearValueCount = 2,
                ClearValues = new IntPtr(clearValues),
                Framebuffer = framebuffers[currentBufferIndex]
            };
            commandBuffer.BeginRenderPass(ref renderPassBeginInfo, SubpassContents.Inline);

            commandBuffer.BindPipeline(PipelineBindPoint.Graphics, pipeline);

            var descriptorSetCopy = descriptorSet;
            commandBuffer.BindDescriptorSets(PipelineBindPoint.Graphics, pipelineLayout, 0, 1, &descriptorSetCopy, 0, null);

            var vertexBufferCopy = vertexBuffer;
            ulong offset = 0;
            commandBuffer.BindVertexBuffers(0, 1, &vertexBufferCopy, &offset);

            var viewport = new Viewport(0, 0, width, height);
            commandBuffer.SetViewport(0, 1, &viewport);

            var scissor = new Rect2D(0, 0, width, height);
            commandBuffer.SetScissor(0, 1, &scissor);

            //commandBuffer.Draw(12 * 3, 1, 0, 0);
            commandBuffer.Draw(6, 1, 0, 0);

            commandBuffer.EndRenderPass();

            imageMemoryBarrier = new ImageMemoryBarrier(swapchainImages[currentBufferIndex], ImageLayout.ColorAttachmentOptimal, ImageLayout.PresentSource, AccessFlags.ColorAttachmentWrite, AccessFlags.MemoryRead, new ImageSubresourceRange(ImageAspectFlags.Color));
            commandBuffer.PipelineBarrier(PipelineStageFlags.AllCommands, PipelineStageFlags.BottomOfPipe, 0, 0, null, 0, null, 1, &imageMemoryBarrier);

            commandBuffer.End();
        }

        private void PrepareDescriptorSet()
        {
            var layout = descriptorSetLayout;
            var allocateInfo = new DescriptorSetAllocateInfo
            {
                StructureType = StructureType.DescriptorSetAllocateInfo,
                DescriptorPool = descriptorPool,
                DescriptorSetCount = 1,
                SetLayouts = new IntPtr(&layout)
            };

            DescriptorSet descriptorSetCopy;
            device.AllocateDescriptorSets(ref allocateInfo, &descriptorSetCopy);
            descriptorSet = descriptorSetCopy;

            var bufferInfo = new DescriptorBufferInfo
            {
                Buffer = uniformBuffer,
                Range = (uint)(sizeof(float) * uniformData.Length)
            };

            var imageInfo = new DescriptorImageInfo
            {
                ImageView = textureView,
                ImageLayout = ImageLayout.General,
                Sampler = textureSampler,
            };

            var writes = stackalloc WriteDescriptorSet[2];
            writes[0] = new WriteDescriptorSet
            {
                StructureType = StructureType.WriteDescriptorSet,
                DestinationSet = descriptorSet,
                DescriptorCount = 1,
                DescriptorType = DescriptorType.UniformBuffer,
                BufferInfo = new IntPtr(&bufferInfo)
            };
            writes[1] = new WriteDescriptorSet
            {
                StructureType = StructureType.WriteDescriptorSet,
                DestinationSet = descriptorSet,
                DestinationBinding = 1,
                DescriptorCount = 1,
                DescriptorType = DescriptorType.CombinedImageSampler,
                ImageInfo = new IntPtr(&imageInfo)
            };

            device.UpdateDescriptorSets(2, writes, 0, null);

            DescriptorSet descriptorSetCopy2;
            device.AllocateDescriptorSets(ref allocateInfo, &descriptorSetCopy2);
            descriptorSet = descriptorSetCopy2;

            var copies = stackalloc CopyDescriptorSet[2];
            copies[0] = new CopyDescriptorSet
            {
                StructureType = StructureType.CopyDescriptorSet,
                DescriptorCount = 1,
                SourceSet = descriptorSetCopy,
                DestinationSet = descriptorSetCopy2
            };
            copies[1] = new CopyDescriptorSet
            {
                StructureType = StructureType.CopyDescriptorSet,
                SourceBinding = 1,
                DestinationBinding = 1,
                DescriptorCount = 1,
                SourceSet = descriptorSetCopy,
                DestinationSet = descriptorSetCopy2
            };

            device.UpdateDescriptorSets(0, null, 2, copies);
        }

        public void Dispose()
        {
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private unsafe delegate RawBool DebugReportCallbackDelegate(DebugReportFlags flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, string layerPrefix, string message, IntPtr userData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate Result CreateDebugReportCallbackDelegate(Instance instance, ref DebugReportCallbackCreateInfo createInfo, AllocationCallbacks* allocator, out DebugReportCallback callback);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate Result DestroyDebugReportCallbackDelegate(Instance instance, DebugReportCallback debugReportCallback, AllocationCallbacks* allocator);
    }
}