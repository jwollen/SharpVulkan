using System;
using System.Runtime.InteropServices;

namespace SharpVulkan
{
    public partial struct Instance
    {
        public readonly static Instance Null = new Instance();

        internal IntPtr NativeHandle;

        public static bool operator ==(Instance left, Instance right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Instance left, Instance right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct PhysicalDevice
    {
        public readonly static PhysicalDevice Null = new PhysicalDevice();

        internal IntPtr NativeHandle;

        public static bool operator ==(PhysicalDevice left, PhysicalDevice right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(PhysicalDevice left, PhysicalDevice right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Device
    {
        public readonly static Device Null = new Device();

        internal IntPtr NativeHandle;

        public static bool operator ==(Device left, Device right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Device left, Device right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Queue
    {
        public readonly static Queue Null = new Queue();

        internal IntPtr NativeHandle;

        public static bool operator ==(Queue left, Queue right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Queue left, Queue right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Semaphore
    {
        public readonly static Semaphore Null = new Semaphore();

        internal ulong NativeHandle;

        public static bool operator ==(Semaphore left, Semaphore right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Semaphore left, Semaphore right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct CommandBuffer
    {
        public readonly static CommandBuffer Null = new CommandBuffer();

        internal IntPtr NativeHandle;

        public static bool operator ==(CommandBuffer left, CommandBuffer right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(CommandBuffer left, CommandBuffer right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Fence
    {
        public readonly static Fence Null = new Fence();

        internal ulong NativeHandle;

        public static bool operator ==(Fence left, Fence right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Fence left, Fence right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DeviceMemory
    {
        public readonly static DeviceMemory Null = new DeviceMemory();

        internal ulong NativeHandle;

        public static bool operator ==(DeviceMemory left, DeviceMemory right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(DeviceMemory left, DeviceMemory right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Buffer
    {
        public readonly static Buffer Null = new Buffer();

        internal ulong NativeHandle;

        public static bool operator ==(Buffer left, Buffer right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Buffer left, Buffer right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Image
    {
        public readonly static Image Null = new Image();

        internal ulong NativeHandle;

        public static bool operator ==(Image left, Image right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Image left, Image right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Event
    {
        public readonly static Event Null = new Event();

        internal ulong NativeHandle;

        public static bool operator ==(Event left, Event right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Event left, Event right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct QueryPool
    {
        public readonly static QueryPool Null = new QueryPool();

        internal ulong NativeHandle;

        public static bool operator ==(QueryPool left, QueryPool right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(QueryPool left, QueryPool right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct BufferView
    {
        public readonly static BufferView Null = new BufferView();

        internal ulong NativeHandle;

        public static bool operator ==(BufferView left, BufferView right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(BufferView left, BufferView right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct ImageView
    {
        public readonly static ImageView Null = new ImageView();

        internal ulong NativeHandle;

        public static bool operator ==(ImageView left, ImageView right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(ImageView left, ImageView right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct ShaderModule
    {
        public readonly static ShaderModule Null = new ShaderModule();

        internal ulong NativeHandle;

        public static bool operator ==(ShaderModule left, ShaderModule right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(ShaderModule left, ShaderModule right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct PipelineCache
    {
        public readonly static PipelineCache Null = new PipelineCache();

        internal ulong NativeHandle;

        public static bool operator ==(PipelineCache left, PipelineCache right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(PipelineCache left, PipelineCache right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct PipelineLayout
    {
        public readonly static PipelineLayout Null = new PipelineLayout();

        internal ulong NativeHandle;

        public static bool operator ==(PipelineLayout left, PipelineLayout right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(PipelineLayout left, PipelineLayout right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct RenderPass
    {
        public readonly static RenderPass Null = new RenderPass();

        internal ulong NativeHandle;

        public static bool operator ==(RenderPass left, RenderPass right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(RenderPass left, RenderPass right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Pipeline
    {
        public readonly static Pipeline Null = new Pipeline();

        internal ulong NativeHandle;

        public static bool operator ==(Pipeline left, Pipeline right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Pipeline left, Pipeline right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DescriptorSetLayout
    {
        public readonly static DescriptorSetLayout Null = new DescriptorSetLayout();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorSetLayout left, DescriptorSetLayout right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(DescriptorSetLayout left, DescriptorSetLayout right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Sampler
    {
        public readonly static Sampler Null = new Sampler();

        internal ulong NativeHandle;

        public static bool operator ==(Sampler left, Sampler right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Sampler left, Sampler right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DescriptorPool
    {
        public readonly static DescriptorPool Null = new DescriptorPool();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorPool left, DescriptorPool right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(DescriptorPool left, DescriptorPool right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DescriptorSet
    {
        public readonly static DescriptorSet Null = new DescriptorSet();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorSet left, DescriptorSet right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(DescriptorSet left, DescriptorSet right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct Framebuffer
    {
        public readonly static Framebuffer Null = new Framebuffer();

        internal ulong NativeHandle;

        public static bool operator ==(Framebuffer left, Framebuffer right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Framebuffer left, Framebuffer right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct CommandPool
    {
        public readonly static CommandPool Null = new CommandPool();

        internal ulong NativeHandle;

        public static bool operator ==(CommandPool left, CommandPool right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(CommandPool left, CommandPool right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct ApplicationInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public IntPtr ApplicationName;

        public uint ApplicationVersion;

        public IntPtr EngineName;

        public uint EngineVersion;

        public uint ApiVersion;
    }

    public partial struct InstanceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public InstanceCreateFlags Flags;

        public IntPtr ApplicationInfo;

        public uint EnabledLayerCount;

        public IntPtr EnabledLayerNames;

        public uint EnabledExtensionCount;

        public IntPtr EnabledExtensionNames;
    }

    public partial struct AllocationCallbacks
    {
        public IntPtr UserData;

        public IntPtr Allocation;

        public IntPtr Reallocation;

        public IntPtr Free;

        public IntPtr InternalAllocation;

        public IntPtr InternalFree;
    }

    public partial struct PhysicalDeviceFeatures
    {
        public RawBool RobustBufferAccess;

        public RawBool FullDrawIndexUInt32;

        public RawBool ImageCubeArray;

        public RawBool IndependentBlend;

        public RawBool GeometryShader;

        public RawBool TessellationShader;

        public RawBool SampleRateShading;

        public RawBool DualSrcBlend;

        public RawBool LogicOperation;

        public RawBool MultiDrawIndirect;

        public RawBool DrawIndirectFirstInstance;

        public RawBool DepthClamp;

        public RawBool DepthBiasClamp;

        public RawBool FillModeNonSolid;

        public RawBool DepthBounds;

        public RawBool WideLines;

        public RawBool LargePoints;

        public RawBool AlphaToOne;

        public RawBool MultiViewport;

        public RawBool SamplerAnisotropy;

        public RawBool TextureCompressionEtc2;

        public RawBool TextureCompressionAstcLdr;

        public RawBool TextureCompressionBc;

        public RawBool OcclusionQueryPrecise;

        public RawBool PipelineStatisticsQuery;

        public RawBool VertexPipelineStoresAndAtomics;

        public RawBool FragmentStoresAndAtomics;

        public RawBool ShaderTessellationAndGeometryPointSize;

        public RawBool ShaderImageGatherExtended;

        public RawBool ShaderStorageImageExtendedFormats;

        public RawBool ShaderStorageImageMultisample;

        public RawBool ShaderStorageImageReadWithoutFormat;

        public RawBool ShaderStorageImageWriteWithoutFormat;

        public RawBool ShaderUniformBufferArrayDynamicIndexing;

        public RawBool ShaderSampledImageArrayDynamicIndexing;

        public RawBool ShaderStorageBufferArrayDynamicIndexing;

        public RawBool ShaderStorageImageArrayDynamicIndexing;

        public RawBool ShaderClipDistance;

        public RawBool ShaderCullDistance;

        public RawBool ShaderFloat64;

        public RawBool ShaderInt64;

        public RawBool ShaderInt16;

        public RawBool ShaderResourceResidency;

        public RawBool ShaderResourceMinLod;

        public RawBool SparseBinding;

        public RawBool SparseResidencyBuffer;

        public RawBool SparseResidencyImage2D;

        public RawBool SparseResidencyImage3D;

        public RawBool SparseResidency2Samples;

        public RawBool SparseResidency4Samples;

        public RawBool SparseResidency8Samples;

        public RawBool SparseResidency16Samples;

        public RawBool SparseResidencyAliased;

        public RawBool VariableMultisampleRate;

        public RawBool InheritedQueries;
    }

    public partial struct FormatProperties
    {
        public FormatFeatureFlags LinearTilingFeatures;

        public FormatFeatureFlags OptimalTilingFeatures;

        public FormatFeatureFlags BufferFeatures;
    }

    public partial struct Extent3D
    {
        public uint Width;

        public uint Height;

        public uint Depth;
    }

    public partial struct ImageFormatProperties
    {
        public Extent3D MaxExtent;

        public uint MaxMipLevels;

        public uint MaxArrayLayers;

        public SampleCountFlags SampleCounts;

        public ulong MaxResourceSize;
    }

    public unsafe partial struct PhysicalDeviceLimits
    {
        public uint MaxImageDimension1D;

        public uint MaxImageDimension2D;

        public uint MaxImageDimension3D;

        public uint MaxImageDimensionCube;

        public uint MaxImageArrayLayers;

        public uint MaxTexelBufferElements;

        public uint MaxUniformBufferRange;

        public uint MaxStorageBufferRange;

        public uint MaxPushConstantsSize;

        public uint MaxMemoryAllocationCount;

        public uint MaxSamplerAllocationCount;

        public ulong BufferImageGranularity;

        public ulong SparseAddressSpaceSize;

        public uint MaxBoundDescriptorSets;

        public uint MaxPerStageDescriptorSamplers;

        public uint MaxPerStageDescriptorUniformBuffers;

        public uint MaxPerStageDescriptorStorageBuffers;

        public uint MaxPerStageDescriptorSampledImages;

        public uint MaxPerStageDescriptorStorageImages;

        public uint MaxPerStageDescriptorInputAttachments;

        public uint MaxPerStageResources;

        public uint MaxDescriptorSetSamplers;

        public uint MaxDescriptorSetUniformBuffers;

        public uint MaxDescriptorSetUniformBuffersDynamic;

        public uint MaxDescriptorSetStorageBuffers;

        public uint MaxDescriptorSetStorageBuffersDynamic;

        public uint MaxDescriptorSetSampledImages;

        public uint MaxDescriptorSetStorageImages;

        public uint MaxDescriptorSetInputAttachments;

        public uint MaxVertexInputAttributes;

        public uint MaxVertexInputBindings;

        public uint MaxVertexInputAttributeOffset;

        public uint MaxVertexInputBindingStride;

        public uint MaxVertexOutputComponents;

        public uint MaxTessellationGenerationLevel;

        public uint MaxTessellationPatchSize;

        public uint MaxTessellationControlPerVertexInputComponents;

        public uint MaxTessellationControlPerVertexOutputComponents;

        public uint MaxTessellationControlPerPatchOutputComponents;

        public uint MaxTessellationControlTotalOutputComponents;

        public uint MaxTessellationEvaluationInputComponents;

        public uint MaxTessellationEvaluationOutputComponents;

        public uint MaxGeometryShaderInvocations;

        public uint MaxGeometryInputComponents;

        public uint MaxGeometryOutputComponents;

        public uint MaxGeometryOutputVertices;

        public uint MaxGeometryTotalOutputComponents;

        public uint MaxFragmentInputComponents;

        public uint MaxFragmentOutputAttachments;

        public uint MaxFragmentDualSrcAttachments;

        public uint MaxFragmentCombinedOutputResources;

        public uint MaxComputeSharedMemorySize;

        public fixed uint MaxComputeWorkGroupCount[3];

        public uint MaxComputeWorkGroupInvocations;

        public fixed uint MaxComputeWorkGroupSize[3];

        public uint SubPixelPrecisionBits;

        public uint SubTexelPrecisionBits;

        public uint MipmapPrecisionBits;

        public uint MaxDrawIndexedIndexValue;

        public uint MaxDrawIndirectCount;

        public float MaxSamplerLodBias;

        public float MaxSamplerAnisotropy;

        public uint MaxViewports;

        public fixed uint MaxViewportDimensions[2];

        public fixed float ViewportBoundsRange[2];

        public uint ViewportSubPixelBits;

        public PointerSize MinMemoryMapAlignment;

        public ulong MinTexelBufferOffsetAlignment;

        public ulong MinUniformBufferOffsetAlignment;

        public ulong MinStorageBufferOffsetAlignment;

        public int MinTexelOffset;

        public uint MaxTexelOffset;

        public int MinTexelGatherOffset;

        public uint MaxTexelGatherOffset;

        public float MinInterpolationOffset;

        public float MaxInterpolationOffset;

        public uint SubPixelInterpolationOffsetBits;

        public uint MaxFramebufferWidth;

        public uint MaxFramebufferHeight;

        public uint MaxFramebufferLayers;

        public SampleCountFlags FramebufferColorSampleCounts;

        public SampleCountFlags FramebufferDepthSampleCounts;

        public SampleCountFlags FramebufferStencilSampleCounts;

        public SampleCountFlags FramebufferNoAttachmentsSampleCounts;

        public uint MaxColorAttachments;

        public SampleCountFlags SampledImageColorSampleCounts;

        public SampleCountFlags SampledImageIntegerSampleCounts;

        public SampleCountFlags SampledImageDepthSampleCounts;

        public SampleCountFlags SampledImageStencilSampleCounts;

        public SampleCountFlags StorageImageSampleCounts;

        public uint MaxSampleMaskWords;

        public RawBool TimestampComputeAndGraphics;

        public float TimestampPeriod;

        public uint MaxClipDistances;

        public uint MaxCullDistances;

        public uint MaxCombinedClipAndCullDistances;

        public uint DiscreteQueuePriorities;

        public fixed float PointSizeRange[2];

        public fixed float LineWidthRange[2];

        public float PointSizeGranularity;

        public float LineWidthGranularity;

        public RawBool StrictLines;

        public RawBool StandardSampleLocations;

        public ulong OptimalBufferCopyOffsetAlignment;

        public ulong OptimalBufferCopyRowPitchAlignment;

        public ulong NonCoherentAtomSize;
    }

    public partial struct PhysicalDeviceSparseProperties
    {
        public RawBool ResidencyStandard2DBlockShape;

        public RawBool ResidencyStandard2DMultisampleBlockShape;

        public RawBool ResidencyStandard3DBlockShape;

        public RawBool ResidencyAlignedMipSize;

        public RawBool ResidencyNonResidentStrict;
    }

    public unsafe partial struct PhysicalDeviceProperties
    {
        public uint ApiVersion;

        public uint DriverVersion;

        public uint VendorId;

        public uint DeviceId;

        public PhysicalDeviceType DeviceType;

        public fixed byte DeviceName[256];

        public fixed byte PipelineCacheUuid[16];

        public PhysicalDeviceLimits Limits;

        public PhysicalDeviceSparseProperties SparseProperties;
    }

    public partial struct QueueFamilyProperties
    {
        public QueueFlags QueueFlags;

        public uint QueueCount;

        public uint TimestampValidBits;

        public Extent3D MinImageTransferGranularity;
    }

    public partial struct MemoryType
    {
        public MemoryPropertyFlags PropertyFlags;

        public uint HeapIndex;
    }

    public partial struct MemoryHeap
    {
        public ulong Size;

        public MemoryHeapFlags Flags;
    }

    public partial struct PhysicalDeviceMemoryProperties
    {
        public uint MemoryTypeCount;

        public struct MemoryTypesArray
        {
            public MemoryType Value0;

            public MemoryType Value1;

            public MemoryType Value2;

            public MemoryType Value3;

            public MemoryType Value4;

            public MemoryType Value5;

            public MemoryType Value6;

            public MemoryType Value7;

            public MemoryType Value8;

            public MemoryType Value9;

            public MemoryType Value10;

            public MemoryType Value11;

            public MemoryType Value12;

            public MemoryType Value13;

            public MemoryType Value14;

            public MemoryType Value15;

            public MemoryType Value16;

            public MemoryType Value17;

            public MemoryType Value18;

            public MemoryType Value19;

            public MemoryType Value20;

            public MemoryType Value21;

            public MemoryType Value22;

            public MemoryType Value23;

            public MemoryType Value24;

            public MemoryType Value25;

            public MemoryType Value26;

            public MemoryType Value27;

            public MemoryType Value28;

            public MemoryType Value29;

            public MemoryType Value30;

            public MemoryType Value31;
        }

        public MemoryTypesArray MemoryTypes;

        public uint MemoryHeapCount;

        public struct MemoryHeapsArray
        {
            public MemoryHeap Value0;

            public MemoryHeap Value1;

            public MemoryHeap Value2;

            public MemoryHeap Value3;

            public MemoryHeap Value4;

            public MemoryHeap Value5;

            public MemoryHeap Value6;

            public MemoryHeap Value7;

            public MemoryHeap Value8;

            public MemoryHeap Value9;

            public MemoryHeap Value10;

            public MemoryHeap Value11;

            public MemoryHeap Value12;

            public MemoryHeap Value13;

            public MemoryHeap Value14;

            public MemoryHeap Value15;
        }

        public MemoryHeapsArray MemoryHeaps;
    }

    public partial struct DeviceQueueCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DeviceQueueCreateFlags Flags;

        public uint QueueFamilyIndex;

        public uint QueueCount;

        public IntPtr QueuePriorities;
    }

    public partial struct DeviceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DeviceCreateFlags Flags;

        public uint QueueCreateInfoCount;

        public IntPtr QueueCreateInfos;

        public uint EnabledLayerCount;

        public IntPtr EnabledLayerNames;

        public uint EnabledExtensionCount;

        public IntPtr EnabledExtensionNames;

        public IntPtr EnabledFeatures;
    }

    public unsafe partial struct ExtensionProperties
    {
        public fixed byte ExtensionName[256];

        public uint SpecVersion;
    }

    public unsafe partial struct LayerProperties
    {
        public fixed byte LayerName[256];

        public uint SpecVersion;

        public uint ImplementationVersion;

        public fixed byte Description[256];
    }

    public partial struct SubmitInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint WaitSemaphoreCount;

        public IntPtr WaitSemaphores;

        public IntPtr WaitDstStageMask;

        public uint CommandBufferCount;

        public IntPtr CommandBuffers;

        public uint SignalSemaphoreCount;

        public IntPtr SignalSemaphores;
    }

    public partial struct MemoryAllocateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ulong AllocationSize;

        public uint MemoryTypeIndex;
    }

    public partial struct MappedMemoryRange
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DeviceMemory Memory;

        public ulong Offset;

        public ulong Size;
    }

    public partial struct MemoryRequirements
    {
        public ulong Size;

        public ulong Alignment;

        public uint MemoryTypeBits;
    }

    public partial struct SparseImageFormatProperties
    {
        public ImageAspectFlags AspectMask;

        public Extent3D ImageGranularity;

        public SparseImageFormatFlags Flags;
    }

    public partial struct SparseImageMemoryRequirements
    {
        public SparseImageFormatProperties FormatProperties;

        public uint ImageMipTailFirstLod;

        public ulong ImageMipTailSize;

        public ulong ImageMipTailOffset;

        public ulong ImageMipTailStride;
    }

    public partial struct SparseMemoryBind
    {
        public ulong ResourceOffset;

        public ulong Size;

        public DeviceMemory Memory;

        public ulong MemoryOffset;

        public SparseMemoryBindFlags Flags;
    }

    public partial struct SparseBufferMemoryBindInfo
    {
        public Buffer Buffer;

        public uint BindCount;

        public IntPtr Binds;
    }

    public partial struct SparseImageOpaqueMemoryBindInfo
    {
        public Image Image;

        public uint BindCount;

        public IntPtr Binds;
    }

    public partial struct ImageSubresource
    {
        public ImageAspectFlags AspectMask;

        public uint MipLevel;

        public uint ArrayLayer;
    }

    public partial struct Offset3D
    {
        public int X;

        public int Y;

        public int Z;
    }

    public partial struct SparseImageMemoryBind
    {
        public ImageSubresource Subresource;

        public Offset3D Offset;

        public Extent3D Extent;

        public DeviceMemory Memory;

        public ulong MemoryOffset;

        public SparseMemoryBindFlags Flags;
    }

    public partial struct SparseImageMemoryBindInfo
    {
        public Image Image;

        public uint BindCount;

        public IntPtr Binds;
    }

    public partial struct BindSparseInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint WaitSemaphoreCount;

        public IntPtr WaitSemaphores;

        public uint BufferBindCount;

        public IntPtr BufferBinds;

        public uint ImageOpaqueBindCount;

        public IntPtr ImageOpaqueBinds;

        public uint ImageBindCount;

        public IntPtr ImageBinds;

        public uint SignalSemaphoreCount;

        public IntPtr SignalSemaphores;
    }

    public partial struct FenceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public FenceCreateFlags Flags;
    }

    public partial struct SemaphoreCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public SemaphoreCreateFlags Flags;
    }

    public partial struct EventCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public EventCreateFlags Flags;
    }

    public partial struct QueryPoolCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public QueryPoolCreateFlags Flags;

        public QueryType QueryType;

        public uint QueryCount;

        public QueryPipelineStatisticFlags PipelineStatistics;
    }

    public partial struct BufferCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public BufferCreateFlags Flags;

        public ulong Size;

        public BufferUsageFlags Usage;

        public SharingMode SharingMode;

        public uint QueueFamilyIndexCount;

        public IntPtr QueueFamilyIndices;
    }

    public partial struct BufferViewCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public BufferViewCreateFlags Flags;

        public Buffer Buffer;

        public Format Format;

        public ulong Offset;

        public ulong Range;
    }

    public partial struct ImageCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ImageCreateFlags Flags;

        public ImageType ImageType;

        public Format Format;

        public Extent3D Extent;

        public uint MipLevels;

        public uint ArrayLayers;

        public SampleCountFlags Samples;

        public ImageTiling Tiling;

        public ImageUsageFlags Usage;

        public SharingMode SharingMode;

        public uint QueueFamilyIndexCount;

        public IntPtr QueueFamilyIndices;

        public ImageLayout InitialLayout;
    }

    public partial struct SubresourceLayout
    {
        public ulong Offset;

        public ulong Size;

        public ulong RowPitch;

        public ulong ArrayPitch;

        public ulong DepthPitch;
    }

    public partial struct ComponentMapping
    {
        public ComponentSwizzle R;

        public ComponentSwizzle G;

        public ComponentSwizzle B;

        public ComponentSwizzle A;
    }

    public partial struct ImageSubresourceRange
    {
        public ImageAspectFlags AspectMask;

        public uint BaseMipLevel;

        public uint LevelCount;

        public uint BaseArrayLayer;

        public uint LayerCount;
    }

    public partial struct ImageViewCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ImageViewCreateFlags Flags;

        public Image Image;

        public ImageViewType ViewType;

        public Format Format;

        public ComponentMapping Components;

        public ImageSubresourceRange SubresourceRange;
    }

    public partial struct ShaderModuleCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ShaderModuleCreateFlags Flags;

        public PointerSize CodeSize;

        public IntPtr Code;
    }

    public partial struct PipelineCacheCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineCacheCreateFlags Flags;

        public PointerSize InitialDataSize;

        public IntPtr InitialData;
    }

    public partial struct SpecializationMapEntry
    {
        public uint ConstantId;

        public uint Offset;

        public PointerSize Size;
    }

    public partial struct SpecializationInfo
    {
        public uint MapEntryCount;

        public IntPtr MapEntries;

        public PointerSize DataSize;

        public IntPtr Data;
    }

    public partial struct PipelineShaderStageCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineShaderStageCreateFlags Flags;

        public ShaderStageFlags Stage;

        public ShaderModule Module;

        public IntPtr Name;

        public IntPtr SpecializationInfo;
    }

    public partial struct VertexInputBindingDescription
    {
        public uint Binding;

        public uint Stride;

        public VertexInputRate InputRate;
    }

    public partial struct VertexInputAttributeDescription
    {
        public uint Location;

        public uint Binding;

        public Format Format;

        public uint Offset;
    }

    public partial struct PipelineVertexInputStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineVertexInputStateCreateFlags Flags;

        public uint VertexBindingDescriptionCount;

        public IntPtr VertexBindingDescriptions;

        public uint VertexAttributeDescriptionCount;

        public IntPtr VertexAttributeDescriptions;
    }

    public partial struct PipelineInputAssemblyStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineInputAssemblyStateCreateFlags Flags;

        public PrimitiveTopology Topology;

        public RawBool PrimitiveRestartEnable;
    }

    public partial struct PipelineTessellationStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineTessellationStateCreateFlags Flags;

        public uint PatchControlPoints;
    }

    public partial struct Viewport
    {
        public float X;

        public float Y;

        public float Width;

        public float Height;

        public float MinDepth;

        public float MaxDepth;
    }

    public partial struct Offset2D
    {
        public int X;

        public int Y;
    }

    public partial struct Extent2D
    {
        public uint Width;

        public uint Height;
    }

    public partial struct Rect2D
    {
        public Offset2D Offset;

        public Extent2D Extent;
    }

    public partial struct PipelineViewportStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineViewportStateCreateFlags Flags;

        public uint ViewportCount;

        public IntPtr Viewports;

        public uint ScissorCount;

        public IntPtr Scissors;
    }

    public partial struct PipelineRasterizationStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineRasterizationStateCreateFlags Flags;

        public RawBool DepthClampEnable;

        public RawBool RasterizerDiscardEnable;

        public PolygonMode PolygonMode;

        public CullModeFlags CullMode;

        public FrontFace FrontFace;

        public RawBool DepthBiasEnable;

        public float DepthBiasConstantFactor;

        public float DepthBiasClamp;

        public float DepthBiasSlopeFactor;

        public float LineWidth;
    }

    public partial struct PipelineMultisampleStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineMultisampleStateCreateFlags Flags;

        public SampleCountFlags RasterizationSamples;

        public RawBool SampleShadingEnable;

        public float MinSampleShading;

        public IntPtr SampleMask;

        public RawBool AlphaToCoverageEnable;

        public RawBool AlphaToOneEnable;
    }

    public partial struct StencilOperationState
    {
        public StencilOperation FailOperation;

        public StencilOperation PassOperation;

        public StencilOperation DepthFailOperation;

        public CompareOperation CompareOperation;

        public uint CompareMask;

        public uint WriteMask;

        public uint Reference;
    }

    public partial struct PipelineDepthStencilStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineDepthStencilStateCreateFlags Flags;

        public RawBool DepthTestEnable;

        public RawBool DepthWriteEnable;

        public CompareOperation DepthCompareOperation;

        public RawBool DepthBoundsTestEnable;

        public RawBool StencilTestEnable;

        public StencilOperationState Front;

        public StencilOperationState Back;

        public float MinDepthBounds;

        public float MaxDepthBounds;
    }

    public partial struct PipelineColorBlendAttachmentState
    {
        public RawBool BlendEnable;

        public BlendFactor SourceColorBlendFactor;

        public BlendFactor DestinationColorBlendFactor;

        public BlendOperation ColorBlendOperation;

        public BlendFactor SourceAlphaBlendFactor;

        public BlendFactor DestinationAlphaBlendFactor;

        public BlendOperation AlphaBlendOperation;

        public ColorComponentFlags ColorWriteMask;
    }

    public unsafe partial struct PipelineColorBlendStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineColorBlendStateCreateFlags Flags;

        public RawBool LogicOperationEnable;

        public LogicOperation LogicOperation;

        public uint AttachmentCount;

        public IntPtr Attachments;

        public fixed float BlendConstants[4];
    }

    public partial struct PipelineDynamicStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineDynamicStateCreateFlags Flags;

        public uint DynamicStateCount;

        public IntPtr DynamicStates;
    }

    public partial struct GraphicsPipelineCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineCreateFlags Flags;

        public uint StageCount;

        public IntPtr Stages;

        public IntPtr VertexInputState;

        public IntPtr InputAssemblyState;

        public IntPtr TessellationState;

        public IntPtr ViewportState;

        public IntPtr RasterizationState;

        public IntPtr MultisampleState;

        public IntPtr DepthStencilState;

        public IntPtr ColorBlendState;

        public IntPtr DynamicState;

        public PipelineLayout Layout;

        public RenderPass RenderPass;

        public uint Subpass;

        public Pipeline BasePipelineHandle;

        public int BasePipelineIndex;
    }

    public partial struct ComputePipelineCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineCreateFlags Flags;

        public PipelineShaderStageCreateInfo Stage;

        public PipelineLayout Layout;

        public Pipeline BasePipelineHandle;

        public int BasePipelineIndex;
    }

    public partial struct PushConstantRange
    {
        public ShaderStageFlags StageFlags;

        public uint Offset;

        public uint Size;
    }

    public partial struct PipelineLayoutCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineLayoutCreateFlags Flags;

        public uint SetLayoutCount;

        public IntPtr SetLayouts;

        public uint PushConstantRangeCount;

        public IntPtr PushConstantRanges;
    }

    public partial struct SamplerCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public SamplerCreateFlags Flags;

        public Filter MagFilter;

        public Filter MinFilter;

        public SamplerMipmapMode MipmapMode;

        public SamplerAddressMode AddressModeU;

        public SamplerAddressMode AddressModeV;

        public SamplerAddressMode AddressModeW;

        public float MipLodBias;

        public RawBool AnisotropyEnable;

        public float MaxAnisotropy;

        public RawBool CompareEnable;

        public CompareOperation CompareOperation;

        public float MinLod;

        public float MaxLod;

        public BorderColor BorderColor;

        public RawBool UnnormalizedCoordinates;
    }

    public partial struct DescriptorSetLayoutBinding
    {
        public uint Binding;

        public DescriptorType DescriptorType;

        public uint DescriptorCount;

        public ShaderStageFlags StageFlags;

        public IntPtr ImmutableSamplers;
    }

    public partial struct DescriptorSetLayoutCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DescriptorSetLayoutCreateFlags Flags;

        public uint BindingCount;

        public IntPtr Bindings;
    }

    public partial struct DescriptorPoolSize
    {
        public DescriptorType Type;

        public uint DescriptorCount;
    }

    public partial struct DescriptorPoolCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DescriptorPoolCreateFlags Flags;

        public uint MaxSets;

        public uint PoolSizeCount;

        public IntPtr PoolSizes;
    }

    public partial struct DescriptorSetAllocateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DescriptorPool DescriptorPool;

        public uint DescriptorSetCount;

        public IntPtr SetLayouts;
    }

    public partial struct DescriptorImageInfo
    {
        public Sampler Sampler;

        public ImageView ImageView;

        public ImageLayout ImageLayout;
    }

    public partial struct DescriptorBufferInfo
    {
        public Buffer Buffer;

        public ulong Offset;

        public ulong Range;
    }

    public partial struct WriteDescriptorSet
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DescriptorSet DestinationSet;

        public uint DestinationBinding;

        public uint DestinationArrayElement;

        public uint DescriptorCount;

        public DescriptorType DescriptorType;

        public IntPtr ImageInfo;

        public IntPtr BufferInfo;

        public IntPtr TexelBufferView;
    }

    public partial struct CopyDescriptorSet
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DescriptorSet SourceSet;

        public uint SourceBinding;

        public uint SourceArrayElement;

        public DescriptorSet DestinationSet;

        public uint DestinationBinding;

        public uint DestinationArrayElement;

        public uint DescriptorCount;
    }

    public partial struct FramebufferCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public FramebufferCreateFlags Flags;

        public RenderPass RenderPass;

        public uint AttachmentCount;

        public IntPtr Attachments;

        public uint Width;

        public uint Height;

        public uint Layers;
    }

    public partial struct AttachmentDescription
    {
        public AttachmentDescriptionFlags Flags;

        public Format Format;

        public SampleCountFlags Samples;

        public AttachmentLoadOperation LoadOperation;

        public AttachmentStoreOperation StoreOperation;

        public AttachmentLoadOperation StencilLoadOperation;

        public AttachmentStoreOperation StencilStoreOperation;

        public ImageLayout InitialLayout;

        public ImageLayout FinalLayout;
    }

    public partial struct AttachmentReference
    {
        public uint Attachment;

        public ImageLayout Layout;
    }

    public partial struct SubpassDescription
    {
        public SubpassDescriptionFlags Flags;

        public PipelineBindPoint PipelineBindPoint;

        public uint InputAttachmentCount;

        public IntPtr InputAttachments;

        public uint ColorAttachmentCount;

        public IntPtr ColorAttachments;

        public IntPtr ResolveAttachments;

        public IntPtr DepthStencilAttachment;

        public uint PreserveAttachmentCount;

        public IntPtr PreserveAttachments;
    }

    public partial struct SubpassDependency
    {
        public uint SourceSubpass;

        public uint DestinationSubpass;

        public PipelineStageFlags SourceStageMask;

        public PipelineStageFlags DestinationStageMask;

        public AccessFlags SourceAccessMask;

        public AccessFlags DestinationAccessMask;

        public DependencyFlags DependencyFlags;
    }

    public partial struct RenderPassCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RenderPassCreateFlags Flags;

        public uint AttachmentCount;

        public IntPtr Attachments;

        public uint SubpassCount;

        public IntPtr Subpasses;

        public uint DependencyCount;

        public IntPtr Dependencies;
    }

    public partial struct CommandPoolCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public CommandPoolCreateFlags Flags;

        public uint QueueFamilyIndex;
    }

    public partial struct CommandBufferAllocateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public CommandPool CommandPool;

        public CommandBufferLevel Level;

        public uint CommandBufferCount;
    }

    public partial struct CommandBufferInheritanceInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RenderPass RenderPass;

        public uint Subpass;

        public Framebuffer Framebuffer;

        public RawBool OcclusionQueryEnable;

        public QueryControlFlags QueryFlags;

        public QueryPipelineStatisticFlags PipelineStatistics;
    }

    public partial struct CommandBufferBeginInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public CommandBufferUsageFlags Flags;

        public IntPtr InheritanceInfo;
    }

    public partial struct BufferCopy
    {
        public ulong SourceOffset;

        public ulong DestinationOffset;

        public ulong Size;
    }

    public partial struct ImageSubresourceLayers
    {
        public ImageAspectFlags AspectMask;

        public uint MipLevel;

        public uint BaseArrayLayer;

        public uint LayerCount;
    }

    public partial struct ImageCopy
    {
        public ImageSubresourceLayers SourceSubresource;

        public Offset3D SourceOffset;

        public ImageSubresourceLayers DestinationSubresource;

        public Offset3D DestinationOffset;

        public Extent3D Extent;
    }

    public partial struct ImageBlit
    {
        public ImageSubresourceLayers SourceSubresource;

        public struct SourceOffsetsArray
        {
            public Offset3D Value0;

            public Offset3D Value1;
        }

        public SourceOffsetsArray SourceOffsets;

        public ImageSubresourceLayers DestinationSubresource;

        public struct DestinationOffsetsArray
        {
            public Offset3D Value0;

            public Offset3D Value1;
        }

        public DestinationOffsetsArray DestinationOffsets;
    }

    public partial struct BufferImageCopy
    {
        public ulong BufferOffset;

        public uint BufferRowLength;

        public uint BufferImageHeight;

        public ImageSubresourceLayers ImageSubresource;

        public Offset3D ImageOffset;

        public Extent3D ImageExtent;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct ClearColorValue
    {
        [FieldOffset(0)]
        public fixed float Float32[4];

        [FieldOffset(0)]
        public fixed int Int32[4];

        [FieldOffset(0)]
        public fixed uint Uint32[4];
    }

    public partial struct ClearDepthStencilValue
    {
        public float Depth;

        public uint Stencil;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct ClearValue
    {
        [FieldOffset(0)]
        public ClearColorValue Color;

        [FieldOffset(0)]
        public ClearDepthStencilValue DepthStencil;
    }

    public partial struct ClearAttachment
    {
        public ImageAspectFlags AspectMask;

        public uint ColorAttachment;

        public ClearValue ClearValue;
    }

    public partial struct ClearRect
    {
        public Rect2D Rect;

        public uint BaseArrayLayer;

        public uint LayerCount;
    }

    public partial struct ImageResolve
    {
        public ImageSubresourceLayers SourceSubresource;

        public Offset3D SourceOffset;

        public ImageSubresourceLayers DestinationSubresource;

        public Offset3D DestinationOffset;

        public Extent3D Extent;
    }

    public partial struct MemoryBarrier
    {
        public StructureType StructureType;

        public IntPtr Next;

        public AccessFlags SourceAccessMask;

        public AccessFlags DestinationAccessMask;
    }

    public partial struct BufferMemoryBarrier
    {
        public StructureType StructureType;

        public IntPtr Next;

        public AccessFlags SourceAccessMask;

        public AccessFlags DestinationAccessMask;

        public uint SourceQueueFamilyIndex;

        public uint DestinationQueueFamilyIndex;

        public Buffer Buffer;

        public ulong Offset;

        public ulong Size;
    }

    public partial struct ImageMemoryBarrier
    {
        public StructureType StructureType;

        public IntPtr Next;

        public AccessFlags SourceAccessMask;

        public AccessFlags DestinationAccessMask;

        public ImageLayout OldLayout;

        public ImageLayout NewLayout;

        public uint SourceQueueFamilyIndex;

        public uint DestinationQueueFamilyIndex;

        public Image Image;

        public ImageSubresourceRange SubresourceRange;
    }

    public partial struct RenderPassBeginInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RenderPass RenderPass;

        public Framebuffer Framebuffer;

        public Rect2D RenderArea;

        public uint ClearValueCount;

        public IntPtr ClearValues;
    }

    public partial struct DispatchIndirectCommand
    {
        public uint X;

        public uint Y;

        public uint Z;
    }

    public partial struct DrawIndexedIndirectCommand
    {
        public uint IndexCount;

        public uint InstanceCount;

        public uint FirstIndex;

        public int VertexOffset;

        public uint FirstInstance;
    }

    public partial struct DrawIndirectCommand
    {
        public uint VertexCount;

        public uint InstanceCount;

        public uint FirstVertex;

        public uint FirstInstance;
    }

    public partial struct Surface
    {
        public readonly static Surface Null = new Surface();

        internal ulong NativeHandle;

        public static bool operator ==(Surface left, Surface right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Surface left, Surface right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct SurfaceCapabilities
    {
        public uint MinImageCount;

        public uint MaxImageCount;

        public Extent2D CurrentExtent;

        public Extent2D MinImageExtent;

        public Extent2D MaxImageExtent;

        public uint MaxImageArrayLayers;

        public SurfaceTransformFlags SupportedTransforms;

        public SurfaceTransformFlags CurrentTransform;

        public CompositeAlphaFlags SupportedCompositeAlpha;

        public ImageUsageFlags SupportedUsageFlags;
    }

    public partial struct SurfaceFormat
    {
        public Format Format;

        public ColorSpace ColorSpace;
    }

    public partial struct Swapchain
    {
        public readonly static Swapchain Null = new Swapchain();

        internal ulong NativeHandle;

        public static bool operator ==(Swapchain left, Swapchain right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Swapchain left, Swapchain right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct SwapchainCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public SwapchainCreateFlags Flags;

        public Surface Surface;

        public uint MinImageCount;

        public Format ImageFormat;

        public ColorSpace ImageColorSpace;

        public Extent2D ImageExtent;

        public uint ImageArrayLayers;

        public ImageUsageFlags ImageUsage;

        public SharingMode ImageSharingMode;

        public uint QueueFamilyIndexCount;

        public IntPtr QueueFamilyIndices;

        public SurfaceTransformFlags PreTransform;

        public CompositeAlphaFlags CompositeAlpha;

        public PresentMode PresentMode;

        public RawBool Clipped;

        public Swapchain OldSwapchain;
    }

    public partial struct PresentInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint WaitSemaphoreCount;

        public IntPtr WaitSemaphores;

        public uint SwapchainCount;

        public IntPtr Swapchains;

        public IntPtr ImageIndices;

        public IntPtr Results;
    }

    public partial struct Display
    {
        public readonly static Display Null = new Display();

        internal ulong NativeHandle;

        public static bool operator ==(Display left, Display right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(Display left, Display right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DisplayMode
    {
        public readonly static DisplayMode Null = new DisplayMode();

        internal ulong NativeHandle;

        public static bool operator ==(DisplayMode left, DisplayMode right)
        {
            return left.NativeHandle == right.NativeHandle;
        }

        public static bool operator !=(DisplayMode left, DisplayMode right)
        {
            return left.NativeHandle != right.NativeHandle;
        }
    }

    public partial struct DisplayProperties
    {
        public Display Display;

        public IntPtr DisplayName;

        public Extent2D PhysicalDimensions;

        public Extent2D PhysicalResolution;

        public SurfaceTransformFlags SupportedTransforms;

        public RawBool PlaneReorderPossible;

        public RawBool PersistentContent;
    }

    public partial struct DisplayModeParameters
    {
        public Extent2D VisibleRegion;

        public uint RefreshRate;
    }

    public partial struct DisplayModeProperties
    {
        public DisplayMode DisplayMode;

        public DisplayModeParameters Parameters;
    }

    public partial struct DisplayModeCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DisplayModeCreateFlags Flags;

        public DisplayModeParameters Parameters;
    }

    public partial struct DisplayPlaneCapabilities
    {
        public DisplayPlaneAlphaFlags SupportedAlpha;

        public Offset2D MinSrcPosition;

        public Offset2D MaxSrcPosition;

        public Extent2D MinSrcExtent;

        public Extent2D MaxSrcExtent;

        public Offset2D MinDstPosition;

        public Offset2D MaxDstPosition;

        public Extent2D MinDstExtent;

        public Extent2D MaxDstExtent;
    }

    public partial struct DisplayPlaneProperties
    {
        public Display CurrentDisplay;

        public uint CurrentStackIndex;
    }

    public partial struct DisplaySurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DisplaySurfaceCreateFlags Flags;

        public DisplayMode DisplayMode;

        public uint PlaneIndex;

        public uint PlaneStackIndex;

        public SurfaceTransformFlags Transform;

        public float GlobalAlpha;

        public DisplayPlaneAlphaFlags AlphaMode;

        public Extent2D ImageExtent;
    }

    public partial struct DisplayPresentInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Rect2D SourceRect;

        public Rect2D DestinationRect;

        public RawBool Persistent;
    }

    public partial struct Win32SurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Win32SurfaceCreateFlags Flags;

        public IntPtr InstanceHandle;

        public IntPtr WindowHandle;
    }
}
