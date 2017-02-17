using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpVulkan
{
    public partial struct Instance : IEquatable<Instance>
    {
        public readonly static Instance Null = new Instance();

        internal IntPtr NativeHandle;

        public static bool operator ==(Instance left, Instance right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Instance left, Instance right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Instance other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct PhysicalDevice : IEquatable<PhysicalDevice>
    {
        public readonly static PhysicalDevice Null = new PhysicalDevice();

        internal IntPtr NativeHandle;

        public static bool operator ==(PhysicalDevice left, PhysicalDevice right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PhysicalDevice left, PhysicalDevice right)
        {
            return !left.Equals(right);
        }

        public bool Equals(PhysicalDevice other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Device : IEquatable<Device>
    {
        public readonly static Device Null = new Device();

        internal IntPtr NativeHandle;

        public static bool operator ==(Device left, Device right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Device left, Device right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Device other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Queue : IEquatable<Queue>
    {
        public readonly static Queue Null = new Queue();

        internal IntPtr NativeHandle;

        public static bool operator ==(Queue left, Queue right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Queue left, Queue right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Queue other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Semaphore : IEquatable<Semaphore>
    {
        public readonly static Semaphore Null = new Semaphore();

        internal ulong NativeHandle;

        public static bool operator ==(Semaphore left, Semaphore right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Semaphore left, Semaphore right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Semaphore other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct CommandBuffer : IEquatable<CommandBuffer>
    {
        public readonly static CommandBuffer Null = new CommandBuffer();

        internal IntPtr NativeHandle;

        public static bool operator ==(CommandBuffer left, CommandBuffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CommandBuffer left, CommandBuffer right)
        {
            return !left.Equals(right);
        }

        public bool Equals(CommandBuffer other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Fence : IEquatable<Fence>
    {
        public readonly static Fence Null = new Fence();

        internal ulong NativeHandle;

        public static bool operator ==(Fence left, Fence right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Fence left, Fence right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Fence other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DeviceMemory : IEquatable<DeviceMemory>
    {
        public readonly static DeviceMemory Null = new DeviceMemory();

        internal ulong NativeHandle;

        public static bool operator ==(DeviceMemory left, DeviceMemory right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DeviceMemory left, DeviceMemory right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DeviceMemory other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Buffer : IEquatable<Buffer>
    {
        public readonly static Buffer Null = new Buffer();

        internal ulong NativeHandle;

        public static bool operator ==(Buffer left, Buffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Buffer left, Buffer right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Buffer other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Image : IEquatable<Image>
    {
        public readonly static Image Null = new Image();

        internal ulong NativeHandle;

        public static bool operator ==(Image left, Image right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Image left, Image right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Image other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Event : IEquatable<Event>
    {
        public readonly static Event Null = new Event();

        internal ulong NativeHandle;

        public static bool operator ==(Event left, Event right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Event left, Event right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Event other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct QueryPool : IEquatable<QueryPool>
    {
        public readonly static QueryPool Null = new QueryPool();

        internal ulong NativeHandle;

        public static bool operator ==(QueryPool left, QueryPool right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(QueryPool left, QueryPool right)
        {
            return !left.Equals(right);
        }

        public bool Equals(QueryPool other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct BufferView : IEquatable<BufferView>
    {
        public readonly static BufferView Null = new BufferView();

        internal ulong NativeHandle;

        public static bool operator ==(BufferView left, BufferView right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BufferView left, BufferView right)
        {
            return !left.Equals(right);
        }

        public bool Equals(BufferView other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct ImageView : IEquatable<ImageView>
    {
        public readonly static ImageView Null = new ImageView();

        internal ulong NativeHandle;

        public static bool operator ==(ImageView left, ImageView right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ImageView left, ImageView right)
        {
            return !left.Equals(right);
        }

        public bool Equals(ImageView other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct ShaderModule : IEquatable<ShaderModule>
    {
        public readonly static ShaderModule Null = new ShaderModule();

        internal ulong NativeHandle;

        public static bool operator ==(ShaderModule left, ShaderModule right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ShaderModule left, ShaderModule right)
        {
            return !left.Equals(right);
        }

        public bool Equals(ShaderModule other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct PipelineCache : IEquatable<PipelineCache>
    {
        public readonly static PipelineCache Null = new PipelineCache();

        internal ulong NativeHandle;

        public static bool operator ==(PipelineCache left, PipelineCache right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PipelineCache left, PipelineCache right)
        {
            return !left.Equals(right);
        }

        public bool Equals(PipelineCache other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct PipelineLayout : IEquatable<PipelineLayout>
    {
        public readonly static PipelineLayout Null = new PipelineLayout();

        internal ulong NativeHandle;

        public static bool operator ==(PipelineLayout left, PipelineLayout right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PipelineLayout left, PipelineLayout right)
        {
            return !left.Equals(right);
        }

        public bool Equals(PipelineLayout other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct RenderPass : IEquatable<RenderPass>
    {
        public readonly static RenderPass Null = new RenderPass();

        internal ulong NativeHandle;

        public static bool operator ==(RenderPass left, RenderPass right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(RenderPass left, RenderPass right)
        {
            return !left.Equals(right);
        }

        public bool Equals(RenderPass other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Pipeline : IEquatable<Pipeline>
    {
        public readonly static Pipeline Null = new Pipeline();

        internal ulong NativeHandle;

        public static bool operator ==(Pipeline left, Pipeline right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Pipeline left, Pipeline right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Pipeline other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DescriptorSetLayout : IEquatable<DescriptorSetLayout>
    {
        public readonly static DescriptorSetLayout Null = new DescriptorSetLayout();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorSetLayout left, DescriptorSetLayout right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DescriptorSetLayout left, DescriptorSetLayout right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DescriptorSetLayout other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Sampler : IEquatable<Sampler>
    {
        public readonly static Sampler Null = new Sampler();

        internal ulong NativeHandle;

        public static bool operator ==(Sampler left, Sampler right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Sampler left, Sampler right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Sampler other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DescriptorPool : IEquatable<DescriptorPool>
    {
        public readonly static DescriptorPool Null = new DescriptorPool();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorPool left, DescriptorPool right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DescriptorPool left, DescriptorPool right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DescriptorPool other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DescriptorSet : IEquatable<DescriptorSet>
    {
        public readonly static DescriptorSet Null = new DescriptorSet();

        internal ulong NativeHandle;

        public static bool operator ==(DescriptorSet left, DescriptorSet right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DescriptorSet left, DescriptorSet right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DescriptorSet other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct Framebuffer : IEquatable<Framebuffer>
    {
        public readonly static Framebuffer Null = new Framebuffer();

        internal ulong NativeHandle;

        public static bool operator ==(Framebuffer left, Framebuffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Framebuffer left, Framebuffer right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Framebuffer other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct CommandPool : IEquatable<CommandPool>
    {
        public readonly static CommandPool Null = new CommandPool();

        internal ulong NativeHandle;

        public static bool operator ==(CommandPool left, CommandPool right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CommandPool left, CommandPool right)
        {
            return !left.Equals(right);
        }

        public bool Equals(CommandPool other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
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

    public partial struct PhysicalDeviceLimits
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

        public struct MaxComputeWorkGroupCountArray
        {
            public uint Value0;

            public uint Value1;

            public uint Value2;
        }

        public MaxComputeWorkGroupCountArray MaxComputeWorkGroupCount;

        public uint MaxComputeWorkGroupInvocations;

        public struct MaxComputeWorkGroupSizeArray
        {
            public uint Value0;

            public uint Value1;

            public uint Value2;
        }

        public MaxComputeWorkGroupSizeArray MaxComputeWorkGroupSize;

        public uint SubPixelPrecisionBits;

        public uint SubTexelPrecisionBits;

        public uint MipmapPrecisionBits;

        public uint MaxDrawIndexedIndexValue;

        public uint MaxDrawIndirectCount;

        public float MaxSamplerLodBias;

        public float MaxSamplerAnisotropy;

        public uint MaxViewports;

        public struct MaxViewportDimensionsArray
        {
            public uint Value0;

            public uint Value1;
        }

        public MaxViewportDimensionsArray MaxViewportDimensions;

        public struct ViewportBoundsRangeArray
        {
            public float Value0;

            public float Value1;
        }

        public ViewportBoundsRangeArray ViewportBoundsRange;

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

        public struct PointSizeRangeArray
        {
            public float Value0;

            public float Value1;
        }

        public PointSizeRangeArray PointSizeRange;

        public struct LineWidthRangeArray
        {
            public float Value0;

            public float Value1;
        }

        public LineWidthRangeArray LineWidthRange;

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

    public partial struct PhysicalDeviceProperties
    {
        public uint ApiVersion;

        public uint DriverVersion;

        public uint VendorId;

        public uint DeviceId;

        public PhysicalDeviceType DeviceType;

        public struct DeviceNameArray
        {
            public byte Value0;

            public byte Value1;

            public byte Value2;

            public byte Value3;

            public byte Value4;

            public byte Value5;

            public byte Value6;

            public byte Value7;

            public byte Value8;

            public byte Value9;

            public byte Value10;

            public byte Value11;

            public byte Value12;

            public byte Value13;

            public byte Value14;

            public byte Value15;

            public byte Value16;

            public byte Value17;

            public byte Value18;

            public byte Value19;

            public byte Value20;

            public byte Value21;

            public byte Value22;

            public byte Value23;

            public byte Value24;

            public byte Value25;

            public byte Value26;

            public byte Value27;

            public byte Value28;

            public byte Value29;

            public byte Value30;

            public byte Value31;

            public byte Value32;

            public byte Value33;

            public byte Value34;

            public byte Value35;

            public byte Value36;

            public byte Value37;

            public byte Value38;

            public byte Value39;

            public byte Value40;

            public byte Value41;

            public byte Value42;

            public byte Value43;

            public byte Value44;

            public byte Value45;

            public byte Value46;

            public byte Value47;

            public byte Value48;

            public byte Value49;

            public byte Value50;

            public byte Value51;

            public byte Value52;

            public byte Value53;

            public byte Value54;

            public byte Value55;

            public byte Value56;

            public byte Value57;

            public byte Value58;

            public byte Value59;

            public byte Value60;

            public byte Value61;

            public byte Value62;

            public byte Value63;

            public byte Value64;

            public byte Value65;

            public byte Value66;

            public byte Value67;

            public byte Value68;

            public byte Value69;

            public byte Value70;

            public byte Value71;

            public byte Value72;

            public byte Value73;

            public byte Value74;

            public byte Value75;

            public byte Value76;

            public byte Value77;

            public byte Value78;

            public byte Value79;

            public byte Value80;

            public byte Value81;

            public byte Value82;

            public byte Value83;

            public byte Value84;

            public byte Value85;

            public byte Value86;

            public byte Value87;

            public byte Value88;

            public byte Value89;

            public byte Value90;

            public byte Value91;

            public byte Value92;

            public byte Value93;

            public byte Value94;

            public byte Value95;

            public byte Value96;

            public byte Value97;

            public byte Value98;

            public byte Value99;

            public byte Value100;

            public byte Value101;

            public byte Value102;

            public byte Value103;

            public byte Value104;

            public byte Value105;

            public byte Value106;

            public byte Value107;

            public byte Value108;

            public byte Value109;

            public byte Value110;

            public byte Value111;

            public byte Value112;

            public byte Value113;

            public byte Value114;

            public byte Value115;

            public byte Value116;

            public byte Value117;

            public byte Value118;

            public byte Value119;

            public byte Value120;

            public byte Value121;

            public byte Value122;

            public byte Value123;

            public byte Value124;

            public byte Value125;

            public byte Value126;

            public byte Value127;

            public byte Value128;

            public byte Value129;

            public byte Value130;

            public byte Value131;

            public byte Value132;

            public byte Value133;

            public byte Value134;

            public byte Value135;

            public byte Value136;

            public byte Value137;

            public byte Value138;

            public byte Value139;

            public byte Value140;

            public byte Value141;

            public byte Value142;

            public byte Value143;

            public byte Value144;

            public byte Value145;

            public byte Value146;

            public byte Value147;

            public byte Value148;

            public byte Value149;

            public byte Value150;

            public byte Value151;

            public byte Value152;

            public byte Value153;

            public byte Value154;

            public byte Value155;

            public byte Value156;

            public byte Value157;

            public byte Value158;

            public byte Value159;

            public byte Value160;

            public byte Value161;

            public byte Value162;

            public byte Value163;

            public byte Value164;

            public byte Value165;

            public byte Value166;

            public byte Value167;

            public byte Value168;

            public byte Value169;

            public byte Value170;

            public byte Value171;

            public byte Value172;

            public byte Value173;

            public byte Value174;

            public byte Value175;

            public byte Value176;

            public byte Value177;

            public byte Value178;

            public byte Value179;

            public byte Value180;

            public byte Value181;

            public byte Value182;

            public byte Value183;

            public byte Value184;

            public byte Value185;

            public byte Value186;

            public byte Value187;

            public byte Value188;

            public byte Value189;

            public byte Value190;

            public byte Value191;

            public byte Value192;

            public byte Value193;

            public byte Value194;

            public byte Value195;

            public byte Value196;

            public byte Value197;

            public byte Value198;

            public byte Value199;

            public byte Value200;

            public byte Value201;

            public byte Value202;

            public byte Value203;

            public byte Value204;

            public byte Value205;

            public byte Value206;

            public byte Value207;

            public byte Value208;

            public byte Value209;

            public byte Value210;

            public byte Value211;

            public byte Value212;

            public byte Value213;

            public byte Value214;

            public byte Value215;

            public byte Value216;

            public byte Value217;

            public byte Value218;

            public byte Value219;

            public byte Value220;

            public byte Value221;

            public byte Value222;

            public byte Value223;

            public byte Value224;

            public byte Value225;

            public byte Value226;

            public byte Value227;

            public byte Value228;

            public byte Value229;

            public byte Value230;

            public byte Value231;

            public byte Value232;

            public byte Value233;

            public byte Value234;

            public byte Value235;

            public byte Value236;

            public byte Value237;

            public byte Value238;

            public byte Value239;

            public byte Value240;

            public byte Value241;

            public byte Value242;

            public byte Value243;

            public byte Value244;

            public byte Value245;

            public byte Value246;

            public byte Value247;

            public byte Value248;

            public byte Value249;

            public byte Value250;

            public byte Value251;

            public byte Value252;

            public byte Value253;

            public byte Value254;

            public byte Value255;
        }

        public DeviceNameArray DeviceName;

        public struct PipelineCacheUuidArray
        {
            public byte Value0;

            public byte Value1;

            public byte Value2;

            public byte Value3;

            public byte Value4;

            public byte Value5;

            public byte Value6;

            public byte Value7;

            public byte Value8;

            public byte Value9;

            public byte Value10;

            public byte Value11;

            public byte Value12;

            public byte Value13;

            public byte Value14;

            public byte Value15;
        }

        public PipelineCacheUuidArray PipelineCacheUuid;

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

    public partial struct ExtensionProperties
    {
        public struct ExtensionNameArray
        {
            public byte Value0;

            public byte Value1;

            public byte Value2;

            public byte Value3;

            public byte Value4;

            public byte Value5;

            public byte Value6;

            public byte Value7;

            public byte Value8;

            public byte Value9;

            public byte Value10;

            public byte Value11;

            public byte Value12;

            public byte Value13;

            public byte Value14;

            public byte Value15;

            public byte Value16;

            public byte Value17;

            public byte Value18;

            public byte Value19;

            public byte Value20;

            public byte Value21;

            public byte Value22;

            public byte Value23;

            public byte Value24;

            public byte Value25;

            public byte Value26;

            public byte Value27;

            public byte Value28;

            public byte Value29;

            public byte Value30;

            public byte Value31;

            public byte Value32;

            public byte Value33;

            public byte Value34;

            public byte Value35;

            public byte Value36;

            public byte Value37;

            public byte Value38;

            public byte Value39;

            public byte Value40;

            public byte Value41;

            public byte Value42;

            public byte Value43;

            public byte Value44;

            public byte Value45;

            public byte Value46;

            public byte Value47;

            public byte Value48;

            public byte Value49;

            public byte Value50;

            public byte Value51;

            public byte Value52;

            public byte Value53;

            public byte Value54;

            public byte Value55;

            public byte Value56;

            public byte Value57;

            public byte Value58;

            public byte Value59;

            public byte Value60;

            public byte Value61;

            public byte Value62;

            public byte Value63;

            public byte Value64;

            public byte Value65;

            public byte Value66;

            public byte Value67;

            public byte Value68;

            public byte Value69;

            public byte Value70;

            public byte Value71;

            public byte Value72;

            public byte Value73;

            public byte Value74;

            public byte Value75;

            public byte Value76;

            public byte Value77;

            public byte Value78;

            public byte Value79;

            public byte Value80;

            public byte Value81;

            public byte Value82;

            public byte Value83;

            public byte Value84;

            public byte Value85;

            public byte Value86;

            public byte Value87;

            public byte Value88;

            public byte Value89;

            public byte Value90;

            public byte Value91;

            public byte Value92;

            public byte Value93;

            public byte Value94;

            public byte Value95;

            public byte Value96;

            public byte Value97;

            public byte Value98;

            public byte Value99;

            public byte Value100;

            public byte Value101;

            public byte Value102;

            public byte Value103;

            public byte Value104;

            public byte Value105;

            public byte Value106;

            public byte Value107;

            public byte Value108;

            public byte Value109;

            public byte Value110;

            public byte Value111;

            public byte Value112;

            public byte Value113;

            public byte Value114;

            public byte Value115;

            public byte Value116;

            public byte Value117;

            public byte Value118;

            public byte Value119;

            public byte Value120;

            public byte Value121;

            public byte Value122;

            public byte Value123;

            public byte Value124;

            public byte Value125;

            public byte Value126;

            public byte Value127;

            public byte Value128;

            public byte Value129;

            public byte Value130;

            public byte Value131;

            public byte Value132;

            public byte Value133;

            public byte Value134;

            public byte Value135;

            public byte Value136;

            public byte Value137;

            public byte Value138;

            public byte Value139;

            public byte Value140;

            public byte Value141;

            public byte Value142;

            public byte Value143;

            public byte Value144;

            public byte Value145;

            public byte Value146;

            public byte Value147;

            public byte Value148;

            public byte Value149;

            public byte Value150;

            public byte Value151;

            public byte Value152;

            public byte Value153;

            public byte Value154;

            public byte Value155;

            public byte Value156;

            public byte Value157;

            public byte Value158;

            public byte Value159;

            public byte Value160;

            public byte Value161;

            public byte Value162;

            public byte Value163;

            public byte Value164;

            public byte Value165;

            public byte Value166;

            public byte Value167;

            public byte Value168;

            public byte Value169;

            public byte Value170;

            public byte Value171;

            public byte Value172;

            public byte Value173;

            public byte Value174;

            public byte Value175;

            public byte Value176;

            public byte Value177;

            public byte Value178;

            public byte Value179;

            public byte Value180;

            public byte Value181;

            public byte Value182;

            public byte Value183;

            public byte Value184;

            public byte Value185;

            public byte Value186;

            public byte Value187;

            public byte Value188;

            public byte Value189;

            public byte Value190;

            public byte Value191;

            public byte Value192;

            public byte Value193;

            public byte Value194;

            public byte Value195;

            public byte Value196;

            public byte Value197;

            public byte Value198;

            public byte Value199;

            public byte Value200;

            public byte Value201;

            public byte Value202;

            public byte Value203;

            public byte Value204;

            public byte Value205;

            public byte Value206;

            public byte Value207;

            public byte Value208;

            public byte Value209;

            public byte Value210;

            public byte Value211;

            public byte Value212;

            public byte Value213;

            public byte Value214;

            public byte Value215;

            public byte Value216;

            public byte Value217;

            public byte Value218;

            public byte Value219;

            public byte Value220;

            public byte Value221;

            public byte Value222;

            public byte Value223;

            public byte Value224;

            public byte Value225;

            public byte Value226;

            public byte Value227;

            public byte Value228;

            public byte Value229;

            public byte Value230;

            public byte Value231;

            public byte Value232;

            public byte Value233;

            public byte Value234;

            public byte Value235;

            public byte Value236;

            public byte Value237;

            public byte Value238;

            public byte Value239;

            public byte Value240;

            public byte Value241;

            public byte Value242;

            public byte Value243;

            public byte Value244;

            public byte Value245;

            public byte Value246;

            public byte Value247;

            public byte Value248;

            public byte Value249;

            public byte Value250;

            public byte Value251;

            public byte Value252;

            public byte Value253;

            public byte Value254;

            public byte Value255;
        }

        public ExtensionNameArray ExtensionName;

        public uint SpecVersion;
    }

    public partial struct LayerProperties
    {
        public struct LayerNameArray
        {
            public byte Value0;

            public byte Value1;

            public byte Value2;

            public byte Value3;

            public byte Value4;

            public byte Value5;

            public byte Value6;

            public byte Value7;

            public byte Value8;

            public byte Value9;

            public byte Value10;

            public byte Value11;

            public byte Value12;

            public byte Value13;

            public byte Value14;

            public byte Value15;

            public byte Value16;

            public byte Value17;

            public byte Value18;

            public byte Value19;

            public byte Value20;

            public byte Value21;

            public byte Value22;

            public byte Value23;

            public byte Value24;

            public byte Value25;

            public byte Value26;

            public byte Value27;

            public byte Value28;

            public byte Value29;

            public byte Value30;

            public byte Value31;

            public byte Value32;

            public byte Value33;

            public byte Value34;

            public byte Value35;

            public byte Value36;

            public byte Value37;

            public byte Value38;

            public byte Value39;

            public byte Value40;

            public byte Value41;

            public byte Value42;

            public byte Value43;

            public byte Value44;

            public byte Value45;

            public byte Value46;

            public byte Value47;

            public byte Value48;

            public byte Value49;

            public byte Value50;

            public byte Value51;

            public byte Value52;

            public byte Value53;

            public byte Value54;

            public byte Value55;

            public byte Value56;

            public byte Value57;

            public byte Value58;

            public byte Value59;

            public byte Value60;

            public byte Value61;

            public byte Value62;

            public byte Value63;

            public byte Value64;

            public byte Value65;

            public byte Value66;

            public byte Value67;

            public byte Value68;

            public byte Value69;

            public byte Value70;

            public byte Value71;

            public byte Value72;

            public byte Value73;

            public byte Value74;

            public byte Value75;

            public byte Value76;

            public byte Value77;

            public byte Value78;

            public byte Value79;

            public byte Value80;

            public byte Value81;

            public byte Value82;

            public byte Value83;

            public byte Value84;

            public byte Value85;

            public byte Value86;

            public byte Value87;

            public byte Value88;

            public byte Value89;

            public byte Value90;

            public byte Value91;

            public byte Value92;

            public byte Value93;

            public byte Value94;

            public byte Value95;

            public byte Value96;

            public byte Value97;

            public byte Value98;

            public byte Value99;

            public byte Value100;

            public byte Value101;

            public byte Value102;

            public byte Value103;

            public byte Value104;

            public byte Value105;

            public byte Value106;

            public byte Value107;

            public byte Value108;

            public byte Value109;

            public byte Value110;

            public byte Value111;

            public byte Value112;

            public byte Value113;

            public byte Value114;

            public byte Value115;

            public byte Value116;

            public byte Value117;

            public byte Value118;

            public byte Value119;

            public byte Value120;

            public byte Value121;

            public byte Value122;

            public byte Value123;

            public byte Value124;

            public byte Value125;

            public byte Value126;

            public byte Value127;

            public byte Value128;

            public byte Value129;

            public byte Value130;

            public byte Value131;

            public byte Value132;

            public byte Value133;

            public byte Value134;

            public byte Value135;

            public byte Value136;

            public byte Value137;

            public byte Value138;

            public byte Value139;

            public byte Value140;

            public byte Value141;

            public byte Value142;

            public byte Value143;

            public byte Value144;

            public byte Value145;

            public byte Value146;

            public byte Value147;

            public byte Value148;

            public byte Value149;

            public byte Value150;

            public byte Value151;

            public byte Value152;

            public byte Value153;

            public byte Value154;

            public byte Value155;

            public byte Value156;

            public byte Value157;

            public byte Value158;

            public byte Value159;

            public byte Value160;

            public byte Value161;

            public byte Value162;

            public byte Value163;

            public byte Value164;

            public byte Value165;

            public byte Value166;

            public byte Value167;

            public byte Value168;

            public byte Value169;

            public byte Value170;

            public byte Value171;

            public byte Value172;

            public byte Value173;

            public byte Value174;

            public byte Value175;

            public byte Value176;

            public byte Value177;

            public byte Value178;

            public byte Value179;

            public byte Value180;

            public byte Value181;

            public byte Value182;

            public byte Value183;

            public byte Value184;

            public byte Value185;

            public byte Value186;

            public byte Value187;

            public byte Value188;

            public byte Value189;

            public byte Value190;

            public byte Value191;

            public byte Value192;

            public byte Value193;

            public byte Value194;

            public byte Value195;

            public byte Value196;

            public byte Value197;

            public byte Value198;

            public byte Value199;

            public byte Value200;

            public byte Value201;

            public byte Value202;

            public byte Value203;

            public byte Value204;

            public byte Value205;

            public byte Value206;

            public byte Value207;

            public byte Value208;

            public byte Value209;

            public byte Value210;

            public byte Value211;

            public byte Value212;

            public byte Value213;

            public byte Value214;

            public byte Value215;

            public byte Value216;

            public byte Value217;

            public byte Value218;

            public byte Value219;

            public byte Value220;

            public byte Value221;

            public byte Value222;

            public byte Value223;

            public byte Value224;

            public byte Value225;

            public byte Value226;

            public byte Value227;

            public byte Value228;

            public byte Value229;

            public byte Value230;

            public byte Value231;

            public byte Value232;

            public byte Value233;

            public byte Value234;

            public byte Value235;

            public byte Value236;

            public byte Value237;

            public byte Value238;

            public byte Value239;

            public byte Value240;

            public byte Value241;

            public byte Value242;

            public byte Value243;

            public byte Value244;

            public byte Value245;

            public byte Value246;

            public byte Value247;

            public byte Value248;

            public byte Value249;

            public byte Value250;

            public byte Value251;

            public byte Value252;

            public byte Value253;

            public byte Value254;

            public byte Value255;
        }

        public LayerNameArray LayerName;

        public uint SpecVersion;

        public uint ImplementationVersion;

        public struct DescriptionArray
        {
            public byte Value0;

            public byte Value1;

            public byte Value2;

            public byte Value3;

            public byte Value4;

            public byte Value5;

            public byte Value6;

            public byte Value7;

            public byte Value8;

            public byte Value9;

            public byte Value10;

            public byte Value11;

            public byte Value12;

            public byte Value13;

            public byte Value14;

            public byte Value15;

            public byte Value16;

            public byte Value17;

            public byte Value18;

            public byte Value19;

            public byte Value20;

            public byte Value21;

            public byte Value22;

            public byte Value23;

            public byte Value24;

            public byte Value25;

            public byte Value26;

            public byte Value27;

            public byte Value28;

            public byte Value29;

            public byte Value30;

            public byte Value31;

            public byte Value32;

            public byte Value33;

            public byte Value34;

            public byte Value35;

            public byte Value36;

            public byte Value37;

            public byte Value38;

            public byte Value39;

            public byte Value40;

            public byte Value41;

            public byte Value42;

            public byte Value43;

            public byte Value44;

            public byte Value45;

            public byte Value46;

            public byte Value47;

            public byte Value48;

            public byte Value49;

            public byte Value50;

            public byte Value51;

            public byte Value52;

            public byte Value53;

            public byte Value54;

            public byte Value55;

            public byte Value56;

            public byte Value57;

            public byte Value58;

            public byte Value59;

            public byte Value60;

            public byte Value61;

            public byte Value62;

            public byte Value63;

            public byte Value64;

            public byte Value65;

            public byte Value66;

            public byte Value67;

            public byte Value68;

            public byte Value69;

            public byte Value70;

            public byte Value71;

            public byte Value72;

            public byte Value73;

            public byte Value74;

            public byte Value75;

            public byte Value76;

            public byte Value77;

            public byte Value78;

            public byte Value79;

            public byte Value80;

            public byte Value81;

            public byte Value82;

            public byte Value83;

            public byte Value84;

            public byte Value85;

            public byte Value86;

            public byte Value87;

            public byte Value88;

            public byte Value89;

            public byte Value90;

            public byte Value91;

            public byte Value92;

            public byte Value93;

            public byte Value94;

            public byte Value95;

            public byte Value96;

            public byte Value97;

            public byte Value98;

            public byte Value99;

            public byte Value100;

            public byte Value101;

            public byte Value102;

            public byte Value103;

            public byte Value104;

            public byte Value105;

            public byte Value106;

            public byte Value107;

            public byte Value108;

            public byte Value109;

            public byte Value110;

            public byte Value111;

            public byte Value112;

            public byte Value113;

            public byte Value114;

            public byte Value115;

            public byte Value116;

            public byte Value117;

            public byte Value118;

            public byte Value119;

            public byte Value120;

            public byte Value121;

            public byte Value122;

            public byte Value123;

            public byte Value124;

            public byte Value125;

            public byte Value126;

            public byte Value127;

            public byte Value128;

            public byte Value129;

            public byte Value130;

            public byte Value131;

            public byte Value132;

            public byte Value133;

            public byte Value134;

            public byte Value135;

            public byte Value136;

            public byte Value137;

            public byte Value138;

            public byte Value139;

            public byte Value140;

            public byte Value141;

            public byte Value142;

            public byte Value143;

            public byte Value144;

            public byte Value145;

            public byte Value146;

            public byte Value147;

            public byte Value148;

            public byte Value149;

            public byte Value150;

            public byte Value151;

            public byte Value152;

            public byte Value153;

            public byte Value154;

            public byte Value155;

            public byte Value156;

            public byte Value157;

            public byte Value158;

            public byte Value159;

            public byte Value160;

            public byte Value161;

            public byte Value162;

            public byte Value163;

            public byte Value164;

            public byte Value165;

            public byte Value166;

            public byte Value167;

            public byte Value168;

            public byte Value169;

            public byte Value170;

            public byte Value171;

            public byte Value172;

            public byte Value173;

            public byte Value174;

            public byte Value175;

            public byte Value176;

            public byte Value177;

            public byte Value178;

            public byte Value179;

            public byte Value180;

            public byte Value181;

            public byte Value182;

            public byte Value183;

            public byte Value184;

            public byte Value185;

            public byte Value186;

            public byte Value187;

            public byte Value188;

            public byte Value189;

            public byte Value190;

            public byte Value191;

            public byte Value192;

            public byte Value193;

            public byte Value194;

            public byte Value195;

            public byte Value196;

            public byte Value197;

            public byte Value198;

            public byte Value199;

            public byte Value200;

            public byte Value201;

            public byte Value202;

            public byte Value203;

            public byte Value204;

            public byte Value205;

            public byte Value206;

            public byte Value207;

            public byte Value208;

            public byte Value209;

            public byte Value210;

            public byte Value211;

            public byte Value212;

            public byte Value213;

            public byte Value214;

            public byte Value215;

            public byte Value216;

            public byte Value217;

            public byte Value218;

            public byte Value219;

            public byte Value220;

            public byte Value221;

            public byte Value222;

            public byte Value223;

            public byte Value224;

            public byte Value225;

            public byte Value226;

            public byte Value227;

            public byte Value228;

            public byte Value229;

            public byte Value230;

            public byte Value231;

            public byte Value232;

            public byte Value233;

            public byte Value234;

            public byte Value235;

            public byte Value236;

            public byte Value237;

            public byte Value238;

            public byte Value239;

            public byte Value240;

            public byte Value241;

            public byte Value242;

            public byte Value243;

            public byte Value244;

            public byte Value245;

            public byte Value246;

            public byte Value247;

            public byte Value248;

            public byte Value249;

            public byte Value250;

            public byte Value251;

            public byte Value252;

            public byte Value253;

            public byte Value254;

            public byte Value255;
        }

        public DescriptionArray Description;
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

    public partial struct PipelineColorBlendStateCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineColorBlendStateCreateFlags Flags;

        public RawBool LogicOperationEnable;

        public LogicOperation LogicOperation;

        public uint AttachmentCount;

        public IntPtr Attachments;

        public struct BlendConstantsArray
        {
            public float Value0;

            public float Value1;

            public float Value2;

            public float Value3;
        }

        public BlendConstantsArray BlendConstants;
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
    public partial struct ClearColorValue
    {
        public struct Float32Array
        {
            public float Value0;

            public float Value1;

            public float Value2;

            public float Value3;
        }

        [FieldOffset(0)]
        public Float32Array Float32;

        public struct Int32Array
        {
            public int Value0;

            public int Value1;

            public int Value2;

            public int Value3;
        }

        [FieldOffset(0)]
        public Int32Array Int32;

        public struct Uint32Array
        {
            public uint Value0;

            public uint Value1;

            public uint Value2;

            public uint Value3;
        }

        [FieldOffset(0)]
        public Uint32Array Uint32;
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

    public partial struct Surface : IEquatable<Surface>
    {
        public readonly static Surface Null = new Surface();

        internal ulong NativeHandle;

        public static bool operator ==(Surface left, Surface right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Surface left, Surface right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Surface other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
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

    public partial struct Swapchain : IEquatable<Swapchain>
    {
        public readonly static Swapchain Null = new Swapchain();

        internal ulong NativeHandle;

        public static bool operator ==(Swapchain left, Swapchain right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Swapchain left, Swapchain right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Swapchain other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
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

    public partial struct Display : IEquatable<Display>
    {
        public readonly static Display Null = new Display();

        internal ulong NativeHandle;

        public static bool operator ==(Display left, Display right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Display left, Display right)
        {
            return !left.Equals(right);
        }

        public bool Equals(Display other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DisplayMode : IEquatable<DisplayMode>
    {
        public readonly static DisplayMode Null = new DisplayMode();

        internal ulong NativeHandle;

        public static bool operator ==(DisplayMode left, DisplayMode right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DisplayMode left, DisplayMode right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DisplayMode other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
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

    public partial struct XlibSurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public XlibSurfaceCreateFlags Flags;

        public IntPtr Dpy;

        public uint Window;
    }

    public partial struct XcbSurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public XcbSurfaceCreateFlags Flags;

        public IntPtr Connection;

        public uint Window;
    }

    public partial struct AndroidSurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public AndroidSurfaceCreateFlags Flags;

        public IntPtr Window;
    }

    public partial struct Win32SurfaceCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Win32SurfaceCreateFlags Flags;

        public IntPtr InstanceHandle;

        public IntPtr WindowHandle;
    }

    public partial struct PhysicalDeviceFeatures2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PhysicalDeviceFeatures Features;
    }

    public partial struct PhysicalDeviceProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PhysicalDeviceProperties Properties;
    }

    public partial struct FormatProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public FormatProperties FormatProperties;
    }

    public partial struct ImageFormatProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ImageFormatProperties ImageFormatProperties;
    }

    public partial struct PhysicalDeviceImageFormatInfo2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Format Format;

        public ImageType Type;

        public ImageTiling Tiling;

        public ImageUsageFlags Usage;

        public ImageCreateFlags Flags;
    }

    public partial struct QueueFamilyProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public QueueFamilyProperties QueueFamilyProperties;
    }

    public partial struct PhysicalDeviceMemoryProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PhysicalDeviceMemoryProperties MemoryProperties;
    }

    public partial struct SparseImageFormatProperties2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public SparseImageFormatProperties Properties;
    }

    public partial struct PhysicalDeviceSparseImageFormatInfo2
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Format Format;

        public ImageType Type;

        public SampleCountFlags Samples;

        public ImageUsageFlags Usage;

        public ImageTiling Tiling;
    }

    public partial struct DebugReportCallback : IEquatable<DebugReportCallback>
    {
        public readonly static DebugReportCallback Null = new DebugReportCallback();

        internal ulong NativeHandle;

        public static bool operator ==(DebugReportCallback left, DebugReportCallback right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DebugReportCallback left, DebugReportCallback right)
        {
            return !left.Equals(right);
        }

        public bool Equals(DebugReportCallback other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DebugReportCallbackCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint Flags;

        public IntPtr Callback;

        public IntPtr UserData;
    }

    public partial struct PipelineRasterizationStateRasterizationOrder
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RasterizationOrder RasterizationOrder;
    }

    public partial struct DebugMarkerObjectNameInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DebugReportObjectType ObjectType;

        public ulong Object;

        public IntPtr ObjectName;
    }

    public partial struct DebugMarkerObjectTagInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DebugReportObjectType ObjectType;

        public ulong Object;

        public ulong TagName;

        public PointerSize TagSize;

        public IntPtr Tag;
    }

    public partial struct DebugMarkerMarkerInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public IntPtr MarkerName;

        public struct ColorArray
        {
            public float Value0;

            public float Value1;

            public float Value2;

            public float Value3;
        }

        public ColorArray Color;
    }

    public partial struct DedicatedAllocationImageCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RawBool DedicatedAllocation;
    }

    public partial struct DedicatedAllocationBufferCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RawBool DedicatedAllocation;
    }

    public partial struct DedicatedAllocationMemoryAllocateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public Image Image;

        public Buffer Buffer;
    }

    public partial struct ExternalImageFormatProperties
    {
        public ImageFormatProperties ImageFormatProperties;

        public uint ExternalMemoryFeatures;

        public uint ExportFromImportedHandleTypes;

        public uint CompatibleHandleTypes;
    }

    public partial struct ExternalMemoryImageCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint HandleTypes;
    }

    public partial struct ExportMemoryAllocateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint HandleTypes;
    }

    public partial struct ImportMemoryWin32HandleInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint HandleType;

        public int Handle;
    }

    public partial struct ExportMemoryWin32HandleInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public IntPtr Attributes;

        public int DwAccess;
    }

    public partial struct Win32KeyedMutexAcquireReleaseInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint AcquireCount;

        public IntPtr AcquireSyncs;

        public IntPtr AcquireKeys;

        public IntPtr AcquireTimeoutMilliseconds;

        public uint ReleaseCount;

        public IntPtr ReleaseSyncs;

        public IntPtr ReleaseKeys;
    }

    public partial struct ValidationFlags
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint DisabledValidationCheckCount;

        public IntPtr DisabledValidationChecks;
    }

    public partial struct ObjectTable : IEquatable<ObjectTable>
    {
        public readonly static ObjectTable Null = new ObjectTable();

        internal IntPtr NativeHandle;

        public static bool operator ==(ObjectTable left, ObjectTable right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ObjectTable left, ObjectTable right)
        {
            return !left.Equals(right);
        }

        public bool Equals(ObjectTable other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct IndirectCommandsLayout : IEquatable<IndirectCommandsLayout>
    {
        public readonly static IndirectCommandsLayout Null = new IndirectCommandsLayout();

        internal IntPtr NativeHandle;

        public static bool operator ==(IndirectCommandsLayout left, IndirectCommandsLayout right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IndirectCommandsLayout left, IndirectCommandsLayout right)
        {
            return !left.Equals(right);
        }

        public bool Equals(IndirectCommandsLayout other)
        {
            return NativeHandle == other.NativeHandle;
        }

        public override int GetHashCode()
        {
            return NativeHandle.GetHashCode();
        }

        public override string ToString()
        {
            return NativeHandle.ToString();
        }
    }

    public partial struct DeviceGeneratedCommandsFeatures
    {
        public StructureType StructureType;

        public IntPtr Next;

        public RawBool ComputeBindingPointSupport;
    }

    public partial struct DeviceGeneratedCommandsLimits
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint MaxIndirectCommandsLayoutTokenCount;

        public uint MaxObjectEntryCounts;

        public uint MinSequenceCountBufferOffsetAlignment;

        public uint MinSequenceIndexBufferOffsetAlignment;

        public uint MinCommandsTokenBufferOffsetAlignment;
    }

    public partial struct IndirectCommandsToken
    {
        public IndirectCommandsTokenType TokenType;

        public Buffer Buffer;

        public ulong Offset;
    }

    public partial struct IndirectCommandsLayoutToken
    {
        public IndirectCommandsTokenType TokenType;

        public uint BindingUnit;

        public uint DynamicCount;

        public uint Divisor;
    }

    public partial struct IndirectCommandsLayoutCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public PipelineBindPoint PipelineBindPoint;

        public uint Flags;

        public uint TokenCount;

        public IntPtr Tokens;
    }

    public partial struct CommandProcessCommandsInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ObjectTable ObjectTable;

        public IndirectCommandsLayout IndirectCommandsLayout;

        public uint IndirectCommandsTokenCount;

        public IntPtr IndirectCommandsTokens;

        public uint MaxSequencesCount;

        public CommandBuffer TargetCommandBuffer;

        public Buffer SequencesCountBuffer;

        public ulong SequencesCountOffset;

        public Buffer SequencesIndexBuffer;

        public ulong SequencesIndexOffset;
    }

    public partial struct CommandReserveSpaceForCommandsInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public ObjectTable ObjectTable;

        public IndirectCommandsLayout IndirectCommandsLayout;

        public uint MaxSequencesCount;
    }

    public partial struct ObjectTableCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint ObjectCount;

        public IntPtr ObjectEntryTypes;

        public IntPtr ObjectEntryCounts;

        public IntPtr ObjectEntryUsageFlags;

        public uint MaxUniformBuffersPerDescriptor;

        public uint MaxStorageBuffersPerDescriptor;

        public uint MaxStorageImagesPerDescriptor;

        public uint MaxSampledImagesPerDescriptor;

        public uint MaxPipelineLayouts;
    }

    public partial struct ObjectTableEntry
    {
        public ObjectEntryType Type;

        public uint Flags;
    }

    public partial struct ObjectTablePipelineEntry
    {
        public ObjectEntryType Type;

        public uint Flags;

        public Pipeline Pipeline;
    }

    public partial struct ObjectTableDescriptorSetEntry
    {
        public ObjectEntryType Type;

        public uint Flags;

        public PipelineLayout PipelineLayout;

        public DescriptorSet DescriptorSet;
    }

    public partial struct ObjectTableVertexBufferEntry
    {
        public ObjectEntryType Type;

        public uint Flags;

        public Buffer Buffer;
    }

    public partial struct ObjectTableIndexBufferEntry
    {
        public ObjectEntryType Type;

        public uint Flags;

        public Buffer Buffer;

        public IndexType IndexType;
    }

    public partial struct ObjectTablePushConstantEntry
    {
        public ObjectEntryType Type;

        public uint Flags;

        public PipelineLayout PipelineLayout;

        public ShaderStageFlags StageFlags;
    }

    public partial struct SurfaceCapabilities2
    {
        public StructureType StructureType;

        public IntPtr Next;

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

        public uint SupportedSurfaceCounters;
    }

    public partial struct DisplayPowerInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DisplayPowerState PowerState;
    }

    public partial struct DeviceEventInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DeviceEventType DeviceEvent;
    }

    public partial struct DisplayEventInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public DisplayEventType DisplayEvent;
    }

    public partial struct SwapchainCounterCreateInfo
    {
        public StructureType StructureType;

        public IntPtr Next;

        public uint SurfaceCounters;
    }
}
