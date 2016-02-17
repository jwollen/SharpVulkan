using System;
using System.Runtime.InteropServices;

namespace SharpVulkan
{
    public static partial class Vulkan
    {
        public static unsafe Instance CreateInstance(ref InstanceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Instance instance;
            fixed (InstanceCreateInfo* __createInfo__ = &createInfo)
            {
                CreateInstance_(__createInfo__, allocator, &instance).CheckError();
            }
            return instance;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateInstance", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateInstance_(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);

        internal static unsafe void EnumerateInstanceExtensionProperties(byte* layerName, ref uint propertyCount, ExtensionProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                EnumerateInstanceExtensionProperties_(layerName, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEnumerateInstanceExtensionProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EnumerateInstanceExtensionProperties_(byte* layerName, uint* propertyCount, ExtensionProperties* properties);

        internal static unsafe void EnumerateInstanceLayerProperties(ref uint propertyCount, LayerProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                EnumerateInstanceLayerProperties_(__propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEnumerateInstanceLayerProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EnumerateInstanceLayerProperties_(uint* propertyCount, LayerProperties* properties);
    }

    public partial struct Instance
    {
        public unsafe void Destroy(AllocationCallbacks* allocator = null)
        {
            DestroyInstance_(this, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyInstance", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyInstance_(Instance instance, AllocationCallbacks* allocator);

        internal unsafe void EnumeratePhysicalDevices(ref uint physicalDeviceCount, PhysicalDevice* physicalDevices)
        {
            fixed (uint* __physicalDeviceCount__ = &physicalDeviceCount)
            {
                EnumeratePhysicalDevices_(this, __physicalDeviceCount__, physicalDevices).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEnumeratePhysicalDevices", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EnumeratePhysicalDevices_(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);

        public unsafe IntPtr GetProcAddress(byte* name)
        {
            IntPtr __result__;
            __result__ = GetInstanceProcAddress_(this, name);
            return __result__;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetInstanceProcAddr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe IntPtr GetInstanceProcAddress_(Instance instance, byte* name);

        public unsafe void DestroySurface(Surface surface, AllocationCallbacks* allocator = null)
        {
            DestroySurface_(this, surface, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroySurfaceKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroySurface_(Instance instance, Surface surface, AllocationCallbacks* allocator);

        public unsafe Surface CreateDisplayPlaneSurface(ref DisplaySurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            fixed (DisplaySurfaceCreateInfo* __createInfo__ = &createInfo)
            {
                CreateDisplayPlaneSurface_(this, __createInfo__, allocator, &surface).CheckError();
            }
            return surface;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateDisplayPlaneSurfaceKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateDisplayPlaneSurface_(Instance instance, DisplaySurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe Surface CreateWin32Surface(Win32SurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            CreateWin32Surface_(this, &createInfo, allocator, &surface).CheckError();
            return surface;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateWin32SurfaceKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateWin32Surface_(Instance instance, Win32SurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);
    }

    public partial struct PhysicalDevice
    {
        public unsafe void GetFeatures(out PhysicalDeviceFeatures features)
        {
            fixed (PhysicalDeviceFeatures* __features__ = &features)
            {
                GetPhysicalDeviceFeatures_(this, __features__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceFeatures", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceFeatures_(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);

        public unsafe void GetFormatProperties(Format format, FormatProperties formatProperties)
        {
            GetPhysicalDeviceFormatProperties_(this, format, &formatProperties);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceFormatProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceFormatProperties_(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);

        public unsafe void GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, out ImageFormatProperties imageFormatProperties)
        {
            fixed (ImageFormatProperties* __imageFormatProperties__ = &imageFormatProperties)
            {
                GetPhysicalDeviceImageFormatProperties_(this, format, type, tiling, usage, flags, __imageFormatProperties__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceImageFormatProperties_(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);

        public unsafe void GetProperties(out PhysicalDeviceProperties properties)
        {
            fixed (PhysicalDeviceProperties* __properties__ = &properties)
            {
                GetPhysicalDeviceProperties_(this, __properties__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceProperties_(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);

        internal unsafe void GetQueueFamilyProperties(ref uint queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties)
        {
            fixed (uint* __queueFamilyPropertyCount__ = &queueFamilyPropertyCount)
            {
                GetPhysicalDeviceQueueFamilyProperties_(this, __queueFamilyPropertyCount__, queueFamilyProperties);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceQueueFamilyProperties_(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);

        public unsafe void GetMemoryProperties(out PhysicalDeviceMemoryProperties memoryProperties)
        {
            fixed (PhysicalDeviceMemoryProperties* __memoryProperties__ = &memoryProperties)
            {
                GetPhysicalDeviceMemoryProperties_(this, __memoryProperties__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceMemoryProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceMemoryProperties_(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);

        public unsafe Device CreateDevice(ref DeviceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Device device;
            fixed (DeviceCreateInfo* __createInfo__ = &createInfo)
            {
                CreateDevice_(this, __createInfo__, allocator, &device).CheckError();
            }
            return device;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateDevice", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateDevice_(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);

        internal unsafe void EnumerateDeviceExtensionProperties(byte* layerName, ref uint propertyCount, ExtensionProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                EnumerateDeviceExtensionProperties_(this, layerName, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEnumerateDeviceExtensionProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EnumerateDeviceExtensionProperties_(PhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, ExtensionProperties* properties);

        internal unsafe void EnumerateDeviceLayerProperties(ref uint propertyCount, LayerProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                EnumerateDeviceLayerProperties_(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEnumerateDeviceLayerProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EnumerateDeviceLayerProperties_(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);

        internal unsafe void GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, ref uint propertyCount, SparseImageFormatProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                GetPhysicalDeviceSparseImageFormatProperties_(this, format, type, samples, usage, tiling, __propertyCount__, properties);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetPhysicalDeviceSparseImageFormatProperties_(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);

        public unsafe RawBool GetSurfaceSupport(uint queueFamilyIndex, Surface surface)
        {
            RawBool supported;
            GetPhysicalDeviceSurfaceSupport_(this, queueFamilyIndex, surface, &supported).CheckError();
            return supported;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceSurfaceSupport_(PhysicalDevice physicalDevice, uint queueFamilyIndex, Surface surface, RawBool* supported);

        public unsafe void GetSurfaceCapabilities(Surface surface, out SurfaceCapabilities surfaceCapabilities)
        {
            fixed (SurfaceCapabilities* __surfaceCapabilities__ = &surfaceCapabilities)
            {
                GetPhysicalDeviceSurfaceCapabilities_(this, surface, __surfaceCapabilities__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceSurfaceCapabilities_(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities* surfaceCapabilities);

        internal unsafe void GetSurfaceFormats(Surface surface, ref uint surfaceFormatCount, SurfaceFormat* surfaceFormats)
        {
            fixed (uint* __surfaceFormatCount__ = &surfaceFormatCount)
            {
                GetPhysicalDeviceSurfaceFormats_(this, surface, __surfaceFormatCount__, surfaceFormats).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceSurfaceFormats_(PhysicalDevice physicalDevice, Surface surface, uint* surfaceFormatCount, SurfaceFormat* surfaceFormats);

        internal unsafe void GetSurfacePresentModes(Surface surface, ref uint presentModeCount, PresentMode* presentModes)
        {
            fixed (uint* __presentModeCount__ = &presentModeCount)
            {
                GetPhysicalDeviceSurfacePresentModes_(this, surface, __presentModeCount__, presentModes).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceSurfacePresentModes_(PhysicalDevice physicalDevice, Surface surface, uint* presentModeCount, PresentMode* presentModes);

        internal unsafe void GetDisplayProperties(ref uint propertyCount, DisplayProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                GetPhysicalDeviceDisplayProperties_(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceDisplayProperties_(PhysicalDevice physicalDevice, uint* propertyCount, DisplayProperties* properties);

        internal unsafe void GetDisplayPlaneProperties(ref uint propertyCount, DisplayPlaneProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                GetPhysicalDeviceDisplayPlaneProperties_(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPhysicalDeviceDisplayPlaneProperties_(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPlaneProperties* properties);

        internal unsafe void GetDisplayPlaneSupportedDisplays(uint planeIndex, ref uint displayCount, Display* displays)
        {
            fixed (uint* __displayCount__ = &displayCount)
            {
                GetDisplayPlaneSupportedDisplays_(this, planeIndex, __displayCount__, displays).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetDisplayPlaneSupportedDisplays_(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, Display* displays);

        internal unsafe void GetDisplayModeProperties(Display display, ref uint propertyCount, DisplayModeProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                GetDisplayModeProperties_(this, display, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDisplayModePropertiesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetDisplayModeProperties_(PhysicalDevice physicalDevice, Display display, uint* propertyCount, DisplayModeProperties* properties);

        public unsafe DisplayMode CreateDisplayMode(Display display, ref DisplayModeCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DisplayMode mode;
            fixed (DisplayModeCreateInfo* __createInfo__ = &createInfo)
            {
                CreateDisplayMode_(this, display, __createInfo__, allocator, &mode).CheckError();
            }
            return mode;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateDisplayModeKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateDisplayMode_(PhysicalDevice physicalDevice, Display display, DisplayModeCreateInfo* createInfo, AllocationCallbacks* allocator, DisplayMode* mode);

        public unsafe void GetDisplayPlaneCapabilities(DisplayMode mode, uint planeIndex, out DisplayPlaneCapabilities capabilities)
        {
            fixed (DisplayPlaneCapabilities* __capabilities__ = &capabilities)
            {
                GetDisplayPlaneCapabilities_(this, mode, planeIndex, __capabilities__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetDisplayPlaneCapabilities_(PhysicalDevice physicalDevice, DisplayMode mode, uint planeIndex, DisplayPlaneCapabilities* capabilities);

        public unsafe RawBool GetWin32PresentationSupport(uint queueFamilyIndex)
        {
            RawBool __result__;
            __result__ = GetPhysicalDeviceWin32PresentationSupport_(this, queueFamilyIndex);
            return __result__;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPhysicalDeviceWin32PresentationSupportKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe RawBool GetPhysicalDeviceWin32PresentationSupport_(PhysicalDevice physicalDevice, uint queueFamilyIndex);
    }

    public partial struct Device
    {
        public unsafe IntPtr GetProcAddress(byte* name)
        {
            IntPtr __result__;
            __result__ = GetDeviceProcAddress_(this, name);
            return __result__;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDeviceProcAddr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe IntPtr GetDeviceProcAddress_(Device device, byte* name);

        public unsafe void Destroy(AllocationCallbacks* allocator = null)
        {
            DestroyDevice_(this, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyDevice", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyDevice_(Device device, AllocationCallbacks* allocator);

        public unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            Queue queue;
            GetDeviceQueue_(this, queueFamilyIndex, queueIndex, &queue);
            return queue;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDeviceQueue", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetDeviceQueue_(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);

        public unsafe void WaitIdle()
        {
            DeviceWaitIdle_(this).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDeviceWaitIdle", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result DeviceWaitIdle_(Device device);

        public unsafe DeviceMemory AllocateMemory(ref MemoryAllocateInfo allocateInfo, AllocationCallbacks* allocator = null)
        {
            DeviceMemory memory;
            fixed (MemoryAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                AllocateMemory_(this, __allocateInfo__, allocator, &memory).CheckError();
            }
            return memory;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkAllocateMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result AllocateMemory_(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);

        public unsafe void FreeMemory(DeviceMemory memory, AllocationCallbacks* allocator = null)
        {
            FreeMemory_(this, memory, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkFreeMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void FreeMemory_(Device device, DeviceMemory memory, AllocationCallbacks* allocator);

        public unsafe IntPtr MapMemory(DeviceMemory memory, ulong offset, ulong size, MemoryMapFlags flags)
        {
            IntPtr data;
            MapMemory_(this, memory, offset, size, flags, &data).CheckError();
            return data;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkMapMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result MapMemory_(Device device, DeviceMemory memory, ulong offset, ulong size, MemoryMapFlags flags, IntPtr* data);

        public unsafe void UnmapMemory(DeviceMemory memory)
        {
            UnmapMemory_(this, memory);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkUnmapMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void UnmapMemory_(Device device, DeviceMemory memory);

        public unsafe void FlushMappedMemoryRanges(uint memoryRangeCount, ref MappedMemoryRange memoryRanges)
        {
            fixed (MappedMemoryRange* __memoryRanges__ = &memoryRanges)
            {
                FlushMappedMemoryRanges_(this, memoryRangeCount, __memoryRanges__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkFlushMappedMemoryRanges", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result FlushMappedMemoryRanges_(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe void InvalidateMappedMemoryRanges(uint memoryRangeCount, ref MappedMemoryRange memoryRanges)
        {
            fixed (MappedMemoryRange* __memoryRanges__ = &memoryRanges)
            {
                InvalidateMappedMemoryRanges_(this, memoryRangeCount, __memoryRanges__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkInvalidateMappedMemoryRanges", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result InvalidateMappedMemoryRanges_(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe ulong GetMemoryCommitment(DeviceMemory memory)
        {
            ulong committedMemoryInBytes;
            GetDeviceMemoryCommitment_(this, memory, &committedMemoryInBytes);
            return committedMemoryInBytes;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetDeviceMemoryCommitment", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetDeviceMemoryCommitment_(Device device, DeviceMemory memory, ulong* committedMemoryInBytes);

        public unsafe void BindBufferMemory(Buffer buffer, DeviceMemory memory, ulong memoryOffset)
        {
            BindBufferMemory_(this, buffer, memory, memoryOffset).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkBindBufferMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result BindBufferMemory_(Device device, Buffer buffer, DeviceMemory memory, ulong memoryOffset);

        public unsafe void BindImageMemory(Image image, DeviceMemory memory, ulong memoryOffset)
        {
            BindImageMemory_(this, image, memory, memoryOffset).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkBindImageMemory", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result BindImageMemory_(Device device, Image image, DeviceMemory memory, ulong memoryOffset);

        public unsafe void GetBufferMemoryRequirements(Buffer buffer, out MemoryRequirements memoryRequirements)
        {
            fixed (MemoryRequirements* __memoryRequirements__ = &memoryRequirements)
            {
                GetBufferMemoryRequirements_(this, buffer, __memoryRequirements__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetBufferMemoryRequirements", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetBufferMemoryRequirements_(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);

        public unsafe void GetImageMemoryRequirements(Image image, out MemoryRequirements memoryRequirements)
        {
            fixed (MemoryRequirements* __memoryRequirements__ = &memoryRequirements)
            {
                GetImageMemoryRequirements_(this, image, __memoryRequirements__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetImageMemoryRequirements", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetImageMemoryRequirements_(Device device, Image image, MemoryRequirements* memoryRequirements);

        internal unsafe void GetImageSparseMemoryRequirements(Image image, ref uint sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements)
        {
            fixed (uint* __sparseMemoryRequirementCount__ = &sparseMemoryRequirementCount)
            {
                GetImageSparseMemoryRequirements_(this, image, __sparseMemoryRequirementCount__, sparseMemoryRequirements);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetImageSparseMemoryRequirements", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetImageSparseMemoryRequirements_(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);

        public unsafe Fence CreateFence(ref FenceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Fence fence;
            fixed (FenceCreateInfo* __createInfo__ = &createInfo)
            {
                CreateFence_(this, __createInfo__, allocator, &fence).CheckError();
            }
            return fence;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateFence", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateFence_(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);

        public unsafe void DestroyFence(Fence fence, AllocationCallbacks* allocator = null)
        {
            DestroyFence_(this, fence, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyFence", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyFence_(Device device, Fence fence, AllocationCallbacks* allocator);

        public unsafe void ResetFences(uint fenceCount, Fence fences)
        {
            ResetFences_(this, fenceCount, &fences).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkResetFences", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result ResetFences_(Device device, uint fenceCount, Fence* fences);

        public unsafe void GetFenceStatus(Fence fence)
        {
            GetFenceStatus_(this, fence).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetFenceStatus", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetFenceStatus_(Device device, Fence fence);

        public unsafe void WaitForFences(uint fenceCount, Fence fences, RawBool waitAll, ulong timeout)
        {
            WaitForFences_(this, fenceCount, &fences, waitAll, timeout).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkWaitForFences", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result WaitForFences_(Device device, uint fenceCount, Fence* fences, RawBool waitAll, ulong timeout);

        public unsafe Semaphore CreateSemaphore(ref SemaphoreCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Semaphore semaphore;
            fixed (SemaphoreCreateInfo* __createInfo__ = &createInfo)
            {
                CreateSemaphore_(this, __createInfo__, allocator, &semaphore).CheckError();
            }
            return semaphore;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateSemaphore", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateSemaphore_(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);

        public unsafe void DestroySemaphore(Semaphore semaphore, AllocationCallbacks* allocator = null)
        {
            DestroySemaphore_(this, semaphore, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroySemaphore", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroySemaphore_(Device device, Semaphore semaphore, AllocationCallbacks* allocator);

        public unsafe Event CreateEvent(ref EventCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Event @event;
            fixed (EventCreateInfo* __createInfo__ = &createInfo)
            {
                CreateEvent_(this, __createInfo__, allocator, &@event).CheckError();
            }
            return @event;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateEvent_(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);

        public unsafe void DestroyEvent(Event @event, AllocationCallbacks* allocator = null)
        {
            DestroyEvent_(this, @event, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyEvent_(Device device, Event @event, AllocationCallbacks* allocator);

        public unsafe void GetEventStatus(Event @event)
        {
            GetEventStatus_(this, @event).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetEventStatus", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetEventStatus_(Device device, Event @event);

        public unsafe void SetEvent(Event @event)
        {
            SetEvent_(this, @event).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkSetEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result SetEvent_(Device device, Event @event);

        public unsafe void ResetEvent(Event @event)
        {
            ResetEvent_(this, @event).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkResetEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result ResetEvent_(Device device, Event @event);

        public unsafe QueryPool CreateQueryPool(ref QueryPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            QueryPool queryPool;
            fixed (QueryPoolCreateInfo* __createInfo__ = &createInfo)
            {
                CreateQueryPool_(this, __createInfo__, allocator, &queryPool).CheckError();
            }
            return queryPool;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateQueryPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateQueryPool_(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);

        public unsafe void DestroyQueryPool(QueryPool queryPool, AllocationCallbacks* allocator = null)
        {
            DestroyQueryPool_(this, queryPool, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyQueryPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyQueryPool_(Device device, QueryPool queryPool, AllocationCallbacks* allocator);

        public unsafe void GetQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, PointerSize dataSize, IntPtr data, ulong stride, QueryResultFlags flags)
        {
            GetQueryPoolResults_(this, queryPool, firstQuery, queryCount, dataSize, data, stride, flags).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetQueryPoolResults", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetQueryPoolResults_(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, PointerSize dataSize, IntPtr data, ulong stride, QueryResultFlags flags);

        public unsafe Buffer CreateBuffer(ref BufferCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Buffer buffer;
            fixed (BufferCreateInfo* __createInfo__ = &createInfo)
            {
                CreateBuffer_(this, __createInfo__, allocator, &buffer).CheckError();
            }
            return buffer;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateBuffer_(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);

        public unsafe void DestroyBuffer(Buffer buffer, AllocationCallbacks* allocator = null)
        {
            DestroyBuffer_(this, buffer, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyBuffer_(Device device, Buffer buffer, AllocationCallbacks* allocator);

        public unsafe BufferView CreateBufferView(ref BufferViewCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            BufferView view;
            fixed (BufferViewCreateInfo* __createInfo__ = &createInfo)
            {
                CreateBufferView_(this, __createInfo__, allocator, &view).CheckError();
            }
            return view;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateBufferView", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateBufferView_(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);

        public unsafe void DestroyBufferView(BufferView bufferView, AllocationCallbacks* allocator = null)
        {
            DestroyBufferView_(this, bufferView, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyBufferView", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyBufferView_(Device device, BufferView bufferView, AllocationCallbacks* allocator);

        public unsafe Image CreateImage(ref ImageCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Image image;
            fixed (ImageCreateInfo* __createInfo__ = &createInfo)
            {
                CreateImage_(this, __createInfo__, allocator, &image).CheckError();
            }
            return image;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateImage_(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);

        public unsafe void DestroyImage(Image image, AllocationCallbacks* allocator = null)
        {
            DestroyImage_(this, image, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyImage_(Device device, Image image, AllocationCallbacks* allocator);

        public unsafe void GetImageSubresourceLayout(Image image, ImageSubresource subresource, out SubresourceLayout layout)
        {
            fixed (SubresourceLayout* __layout__ = &layout)
            {
                GetImageSubresourceLayout_(this, image, &subresource, __layout__);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetImageSubresourceLayout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetImageSubresourceLayout_(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);

        public unsafe ImageView CreateImageView(ref ImageViewCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            ImageView view;
            fixed (ImageViewCreateInfo* __createInfo__ = &createInfo)
            {
                CreateImageView_(this, __createInfo__, allocator, &view).CheckError();
            }
            return view;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateImageView", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateImageView_(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);

        public unsafe void DestroyImageView(ImageView imageView, AllocationCallbacks* allocator = null)
        {
            DestroyImageView_(this, imageView, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyImageView", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyImageView_(Device device, ImageView imageView, AllocationCallbacks* allocator);

        public unsafe ShaderModule CreateShaderModule(ref ShaderModuleCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            ShaderModule shaderModule;
            fixed (ShaderModuleCreateInfo* __createInfo__ = &createInfo)
            {
                CreateShaderModule_(this, __createInfo__, allocator, &shaderModule).CheckError();
            }
            return shaderModule;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateShaderModule", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateShaderModule_(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);

        public unsafe void DestroyShaderModule(ShaderModule shaderModule, AllocationCallbacks* allocator = null)
        {
            DestroyShaderModule_(this, shaderModule, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyShaderModule", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyShaderModule_(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);

        public unsafe PipelineCache CreatePipelineCache(ref PipelineCacheCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            PipelineCache pipelineCache;
            fixed (PipelineCacheCreateInfo* __createInfo__ = &createInfo)
            {
                CreatePipelineCache_(this, __createInfo__, allocator, &pipelineCache).CheckError();
            }
            return pipelineCache;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreatePipelineCache", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreatePipelineCache_(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);

        public unsafe void DestroyPipelineCache(PipelineCache pipelineCache, AllocationCallbacks* allocator = null)
        {
            DestroyPipelineCache_(this, pipelineCache, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyPipelineCache", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyPipelineCache_(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);

        public unsafe void GetPipelineCacheData(PipelineCache pipelineCache, ref PointerSize dataSize, IntPtr data)
        {
            fixed (PointerSize* __dataSize__ = &dataSize)
            {
                GetPipelineCacheData_(this, pipelineCache, __dataSize__, data).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetPipelineCacheData", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetPipelineCacheData_(Device device, PipelineCache pipelineCache, PointerSize* dataSize, IntPtr data);

        public unsafe void MergePipelineCaches(PipelineCache destinationCache, uint sourceCacheCount, PipelineCache srcCaches)
        {
            MergePipelineCaches_(this, destinationCache, sourceCacheCount, &srcCaches).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkMergePipelineCaches", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result MergePipelineCaches_(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* srcCaches);

        public unsafe Pipeline CreateGraphicsPipelines(PipelineCache pipelineCache, uint createInfoCount, ref GraphicsPipelineCreateInfo createInfos, AllocationCallbacks* allocator = null)
        {
            Pipeline pipelines;
            fixed (GraphicsPipelineCreateInfo* __createInfos__ = &createInfos)
            {
                CreateGraphicsPipelines_(this, pipelineCache, createInfoCount, __createInfos__, allocator, &pipelines).CheckError();
            }
            return pipelines;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateGraphicsPipelines", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateGraphicsPipelines_(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

        public unsafe Pipeline CreateComputePipelines(PipelineCache pipelineCache, uint createInfoCount, ref ComputePipelineCreateInfo createInfos, AllocationCallbacks* allocator = null)
        {
            Pipeline pipelines;
            fixed (ComputePipelineCreateInfo* __createInfos__ = &createInfos)
            {
                CreateComputePipelines_(this, pipelineCache, createInfoCount, __createInfos__, allocator, &pipelines).CheckError();
            }
            return pipelines;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateComputePipelines", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateComputePipelines_(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

        public unsafe void DestroyPipeline(Pipeline pipeline, AllocationCallbacks* allocator = null)
        {
            DestroyPipeline_(this, pipeline, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyPipeline", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyPipeline_(Device device, Pipeline pipeline, AllocationCallbacks* allocator);

        public unsafe PipelineLayout CreatePipelineLayout(ref PipelineLayoutCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            PipelineLayout pipelineLayout;
            fixed (PipelineLayoutCreateInfo* __createInfo__ = &createInfo)
            {
                CreatePipelineLayout_(this, __createInfo__, allocator, &pipelineLayout).CheckError();
            }
            return pipelineLayout;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreatePipelineLayout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreatePipelineLayout_(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);

        public unsafe void DestroyPipelineLayout(PipelineLayout pipelineLayout, AllocationCallbacks* allocator = null)
        {
            DestroyPipelineLayout_(this, pipelineLayout, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyPipelineLayout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyPipelineLayout_(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);

        public unsafe Sampler CreateSampler(ref SamplerCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Sampler sampler;
            fixed (SamplerCreateInfo* __createInfo__ = &createInfo)
            {
                CreateSampler_(this, __createInfo__, allocator, &sampler).CheckError();
            }
            return sampler;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateSampler", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateSampler_(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);

        public unsafe void DestroySampler(Sampler sampler, AllocationCallbacks* allocator = null)
        {
            DestroySampler_(this, sampler, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroySampler", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroySampler_(Device device, Sampler sampler, AllocationCallbacks* allocator);

        public unsafe DescriptorSetLayout CreateDescriptorSetLayout(ref DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DescriptorSetLayout setLayout;
            fixed (DescriptorSetLayoutCreateInfo* __createInfo__ = &createInfo)
            {
                CreateDescriptorSetLayout_(this, __createInfo__, allocator, &setLayout).CheckError();
            }
            return setLayout;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateDescriptorSetLayout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateDescriptorSetLayout_(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);

        public unsafe void DestroyDescriptorSetLayout(DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator = null)
        {
            DestroyDescriptorSetLayout_(this, descriptorSetLayout, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyDescriptorSetLayout", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyDescriptorSetLayout_(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);

        public unsafe DescriptorPool CreateDescriptorPool(ref DescriptorPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DescriptorPool descriptorPool;
            fixed (DescriptorPoolCreateInfo* __createInfo__ = &createInfo)
            {
                CreateDescriptorPool_(this, __createInfo__, allocator, &descriptorPool).CheckError();
            }
            return descriptorPool;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateDescriptorPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateDescriptorPool_(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);

        public unsafe void DestroyDescriptorPool(DescriptorPool descriptorPool, AllocationCallbacks* allocator = null)
        {
            DestroyDescriptorPool_(this, descriptorPool, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyDescriptorPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyDescriptorPool_(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);

        public unsafe void ResetDescriptorPool(DescriptorPool descriptorPool, DescriptorPoolResetFlags flags)
        {
            ResetDescriptorPool_(this, descriptorPool, flags).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkResetDescriptorPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result ResetDescriptorPool_(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);

        public unsafe DescriptorSet AllocateDescriptorSets(ref DescriptorSetAllocateInfo allocateInfo)
        {
            DescriptorSet descriptorSets;
            fixed (DescriptorSetAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                AllocateDescriptorSets_(this, __allocateInfo__, &descriptorSets).CheckError();
            }
            return descriptorSets;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkAllocateDescriptorSets", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result AllocateDescriptorSets_(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);

        public unsafe void FreeDescriptorSets(DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet descriptorSets)
        {
            FreeDescriptorSets_(this, descriptorPool, descriptorSetCount, &descriptorSets).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkFreeDescriptorSets", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result FreeDescriptorSets_(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);

        public unsafe void UpdateDescriptorSets(uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies)
        {
            UpdateDescriptorSets_(this, descriptorWriteCount, descriptorWrites, descriptorCopyCount, descriptorCopies);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkUpdateDescriptorSets", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void UpdateDescriptorSets_(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);

        public unsafe Framebuffer CreateFramebuffer(ref FramebufferCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Framebuffer framebuffer;
            fixed (FramebufferCreateInfo* __createInfo__ = &createInfo)
            {
                CreateFramebuffer_(this, __createInfo__, allocator, &framebuffer).CheckError();
            }
            return framebuffer;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateFramebuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateFramebuffer_(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);

        public unsafe void DestroyFramebuffer(Framebuffer framebuffer, AllocationCallbacks* allocator = null)
        {
            DestroyFramebuffer_(this, framebuffer, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyFramebuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyFramebuffer_(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);

        public unsafe RenderPass CreateRenderPass(ref RenderPassCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            RenderPass renderPass;
            fixed (RenderPassCreateInfo* __createInfo__ = &createInfo)
            {
                CreateRenderPass_(this, __createInfo__, allocator, &renderPass).CheckError();
            }
            return renderPass;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateRenderPass", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateRenderPass_(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);

        public unsafe void DestroyRenderPass(RenderPass renderPass, AllocationCallbacks* allocator = null)
        {
            DestroyRenderPass_(this, renderPass, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyRenderPass", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyRenderPass_(Device device, RenderPass renderPass, AllocationCallbacks* allocator);

        public unsafe Extent2D GetRenderAreaGranularity(RenderPass renderPass)
        {
            Extent2D granularity;
            GetRenderAreaGranularity_(this, renderPass, &granularity);
            return granularity;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetRenderAreaGranularity", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void GetRenderAreaGranularity_(Device device, RenderPass renderPass, Extent2D* granularity);

        public unsafe CommandPool CreateCommandPool(ref CommandPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            CommandPool commandPool;
            fixed (CommandPoolCreateInfo* __createInfo__ = &createInfo)
            {
                CreateCommandPool_(this, __createInfo__, allocator, &commandPool).CheckError();
            }
            return commandPool;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateCommandPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateCommandPool_(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);

        public unsafe void DestroyCommandPool(CommandPool commandPool, AllocationCallbacks* allocator = null)
        {
            DestroyCommandPool_(this, commandPool, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroyCommandPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroyCommandPool_(Device device, CommandPool commandPool, AllocationCallbacks* allocator);

        public unsafe void ResetCommandPool(CommandPool commandPool, CommandPoolResetFlags flags)
        {
            ResetCommandPool_(this, commandPool, flags).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkResetCommandPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result ResetCommandPool_(Device device, CommandPool commandPool, CommandPoolResetFlags flags);

        public unsafe void AllocateCommandBuffers(ref CommandBufferAllocateInfo allocateInfo, CommandBuffer* commandBuffers)
        {
            fixed (CommandBufferAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                AllocateCommandBuffers_(this, __allocateInfo__, commandBuffers).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkAllocateCommandBuffers", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result AllocateCommandBuffers_(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);

        public unsafe void FreeCommandBuffers(CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers)
        {
            FreeCommandBuffers_(this, commandPool, commandBufferCount, commandBuffers);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkFreeCommandBuffers", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void FreeCommandBuffers_(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);

        public unsafe Swapchain CreateSwapchain(ref SwapchainCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Swapchain swapchain;
            fixed (SwapchainCreateInfo* __createInfo__ = &createInfo)
            {
                CreateSwapchain_(this, __createInfo__, allocator, &swapchain).CheckError();
            }
            return swapchain;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateSwapchainKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateSwapchain_(Device device, SwapchainCreateInfo* createInfo, AllocationCallbacks* allocator, Swapchain* swapchain);

        public unsafe void DestroySwapchain(Swapchain swapchain, AllocationCallbacks* allocator = null)
        {
            DestroySwapchain_(this, swapchain, allocator);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkDestroySwapchainKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void DestroySwapchain_(Device device, Swapchain swapchain, AllocationCallbacks* allocator);

        internal unsafe void GetSwapchainImages(Swapchain swapchain, ref uint swapchainImageCount, Image* swapchainImages)
        {
            fixed (uint* __swapchainImageCount__ = &swapchainImageCount)
            {
                GetSwapchainImages_(this, swapchain, __swapchainImageCount__, swapchainImages).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkGetSwapchainImagesKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result GetSwapchainImages_(Device device, Swapchain swapchain, uint* swapchainImageCount, Image* swapchainImages);

        public unsafe uint AcquireNextImage(Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence)
        {
            uint imageIndex;
            AcquireNextImage_(this, swapchain, timeout, semaphore, fence, &imageIndex).CheckError();
            return imageIndex;
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkAcquireNextImageKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result AcquireNextImage_(Device device, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);

        [DllImport("vulkan-1.dll", EntryPoint = "vkCreateSharedSwapchainsKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result CreateSharedSwapchains_(Device device, uint swapchainCount, SwapchainCreateInfo* createInfos, AllocationCallbacks* allocator, Swapchain* swapchains);
    }

    public partial struct Queue
    {
        public unsafe void Submit(uint submitCount, SubmitInfo* submits, Fence fence)
        {
            QueueSubmit_(this, submitCount, submits, fence).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkQueueSubmit", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result QueueSubmit_(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);

        public unsafe void WaitIdle()
        {
            QueueWaitIdle_(this).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkQueueWaitIdle", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result QueueWaitIdle_(Queue queue);

        public unsafe void BindSparse(uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence)
        {
            QueueBindSparse_(this, bindInfoCount, bindInfo, fence).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkQueueBindSparse", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result QueueBindSparse_(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);

        public unsafe void Present(ref PresentInfo presentInfo)
        {
            fixed (PresentInfo* __presentInfo__ = &presentInfo)
            {
                QueuePresent_(this, __presentInfo__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkQueuePresentKHR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result QueuePresent_(Queue queue, PresentInfo* presentInfo);
    }

    public partial struct CommandBuffer
    {
        public unsafe void Begin(ref CommandBufferBeginInfo beginInfo)
        {
            fixed (CommandBufferBeginInfo* __beginInfo__ = &beginInfo)
            {
                BeginCommandBuffer_(this, __beginInfo__).CheckError();
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkBeginCommandBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result BeginCommandBuffer_(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);

        public unsafe void End()
        {
            EndCommandBuffer_(this).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkEndCommandBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result EndCommandBuffer_(CommandBuffer commandBuffer);

        public unsafe void Reset(CommandBufferResetFlags flags)
        {
            ResetCommandBuffer_(this, flags).CheckError();
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkResetCommandBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe Result ResetCommandBuffer_(CommandBuffer commandBuffer, CommandBufferResetFlags flags);

        public unsafe void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            CommandBindPipeline_(this, pipelineBindPoint, pipeline);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBindPipeline", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBindPipeline_(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);

        public unsafe void SetViewport(uint firstViewport, uint viewportCount, Viewport* viewports)
        {
            CommandSetViewport_(this, firstViewport, viewportCount, viewports);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetViewport", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetViewport_(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);

        public unsafe void SetScissor(uint firstScissor, uint scissorCount, Rect2D* scissors)
        {
            CommandSetScissor_(this, firstScissor, scissorCount, scissors);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetScissor", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetScissor_(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);

        public unsafe void SetLineWidth(float lineWidth)
        {
            CommandSetLineWidth_(this, lineWidth);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetLineWidth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetLineWidth_(CommandBuffer commandBuffer, float lineWidth);

        public unsafe void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            CommandSetDepthBias_(this, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetDepthBias", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetDepthBias_(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        public unsafe void SetBlendConstants(float blendConstants)
        {
            CommandSetBlendConstants_(this, blendConstants);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetBlendConstants", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetBlendConstants_(CommandBuffer commandBuffer, float blendConstants);

        public unsafe void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            CommandSetDepthBounds_(this, minDepthBounds, maxDepthBounds);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetDepthBounds", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetDepthBounds_(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

        public unsafe void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            CommandSetStencilCompareMask_(this, faceMask, compareMask);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetStencilCompareMask", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetStencilCompareMask_(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);

        public unsafe void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            CommandSetStencilWriteMask_(this, faceMask, writeMask);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetStencilWriteMask", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetStencilWriteMask_(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);

        public unsafe void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            CommandSetStencilReference_(this, faceMask, reference);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetStencilReference", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetStencilReference_(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);

        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            CommandBindDescriptorSets_(this, pipelineBindPoint, layout, firstSet, descriptorSetCount, &descriptorSets, dynamicOffsetCount, dynamicOffsets);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBindDescriptorSets", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBindDescriptorSets_(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);

        public unsafe void BindIndexBuffer(Buffer buffer, ulong offset, IndexType indexType)
        {
            CommandBindIndexBuffer_(this, buffer, offset, indexType);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBindIndexBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBindIndexBuffer_(CommandBuffer commandBuffer, Buffer buffer, ulong offset, IndexType indexType);

        public unsafe void BindVertexBuffers(uint firstBinding, uint bindingCount, Buffer buffers, ulong* offsets)
        {
            CommandBindVertexBuffers_(this, firstBinding, bindingCount, &buffers, offsets);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBindVertexBuffers", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBindVertexBuffers_(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, ulong* offsets);

        public unsafe void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            CommandDraw_(this, vertexCount, instanceCount, firstVertex, firstInstance);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDraw", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDraw_(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        public unsafe void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            CommandDrawIndexed_(this, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDrawIndexed", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDrawIndexed_(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);

        public unsafe void DrawIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            CommandDrawIndirect_(this, buffer, offset, drawCount, stride);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDrawIndirect", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDrawIndirect_(CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);

        public unsafe void DrawIndexedIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            CommandDrawIndexedIndirect_(this, buffer, offset, drawCount, stride);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDrawIndexedIndirect", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDrawIndexedIndirect_(CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);

        public unsafe void Dispatch(uint x, uint y, uint z)
        {
            CommandDispatch_(this, x, y, z);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDispatch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDispatch_(CommandBuffer commandBuffer, uint x, uint y, uint z);

        public unsafe void DispatchIndirect(Buffer buffer, ulong offset)
        {
            CommandDispatchIndirect_(this, buffer, offset);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdDispatchIndirect", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandDispatchIndirect_(CommandBuffer commandBuffer, Buffer buffer, ulong offset);

        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions)
        {
            CommandCopyBuffer_(this, sourceBuffer, destinationBuffer, regionCount, regions);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdCopyBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandCopyBuffer_(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);

        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions)
        {
            CommandCopyImage_(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdCopyImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandCopyImage_(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);

        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter)
        {
            CommandBlitImage_(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions, filter);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBlitImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBlitImage_(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);

        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions)
        {
            CommandCopyBufferToImage_(this, sourceBuffer, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdCopyBufferToImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandCopyBufferToImage_(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);

        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions)
        {
            CommandCopyImageToBuffer_(this, sourceImage, sourceImageLayout, destinationBuffer, regionCount, regions);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdCopyImageToBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandCopyImageToBuffer_(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);

        public unsafe void UpdateBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong dataSize, uint* data)
        {
            CommandUpdateBuffer_(this, destinationBuffer, destinationOffset, dataSize, data);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdUpdateBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandUpdateBuffer_(CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong dataSize, uint* data);

        public unsafe void FillBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data)
        {
            CommandFillBuffer_(this, destinationBuffer, destinationOffset, size, data);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdFillBuffer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandFillBuffer_(CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data);

        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, uint rangeCount, ImageSubresourceRange* ranges)
        {
            CommandClearColorImage_(this, image, imageLayout, &color, rangeCount, ranges);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdClearColorImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandClearColorImage_(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, uint rangeCount, ImageSubresourceRange* ranges)
        {
            CommandClearDepthStencilImage_(this, image, imageLayout, &depthStencil, rangeCount, ranges);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdClearDepthStencilImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandClearDepthStencilImage_(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe void ClearAttachments(uint attachmentCount, ref ClearAttachment attachments, uint rectCount, ClearRect* rects)
        {
            fixed (ClearAttachment* __attachments__ = &attachments)
            {
                CommandClearAttachments_(this, attachmentCount, __attachments__, rectCount, rects);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdClearAttachments", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandClearAttachments_(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);

        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions)
        {
            CommandResolveImage_(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdResolveImage", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandResolveImage_(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);

        public unsafe void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            CommandSetEvent_(this, @event, stageMask);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdSetEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandSetEvent_(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            CommandResetEvent_(this, @event, stageMask);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdResetEvent", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandResetEvent_(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe void WaitEvents(uint eventCount, Event events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, ref MemoryBarrier memoryBarriers, uint bufferMemoryBarrierCount, ref BufferMemoryBarrier bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers)
        {
            fixed (BufferMemoryBarrier* __bufferMemoryBarriers__ = &bufferMemoryBarriers)
            fixed (MemoryBarrier* __memoryBarriers__ = &memoryBarriers)
            {
                CommandWaitEvents_(this, eventCount, &events, sourceStageMask, destinationStageMask, memoryBarrierCount, __memoryBarriers__, bufferMemoryBarrierCount, __bufferMemoryBarriers__, imageMemoryBarrierCount, imageMemoryBarriers);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdWaitEvents", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandWaitEvents_(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, ref MemoryBarrier memoryBarriers, uint bufferMemoryBarrierCount, ref BufferMemoryBarrier bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers)
        {
            fixed (BufferMemoryBarrier* __bufferMemoryBarriers__ = &bufferMemoryBarriers)
            fixed (MemoryBarrier* __memoryBarriers__ = &memoryBarriers)
            {
                CommandPipelineBarrier_(this, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, __memoryBarriers__, bufferMemoryBarrierCount, __bufferMemoryBarriers__, imageMemoryBarrierCount, imageMemoryBarriers);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdPipelineBarrier", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandPipelineBarrier_(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
            CommandBeginQuery_(this, queryPool, query, flags);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBeginQuery", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBeginQuery_(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);

        public unsafe void EndQuery(QueryPool queryPool, uint query)
        {
            CommandEndQuery_(this, queryPool, query);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdEndQuery", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandEndQuery_(CommandBuffer commandBuffer, QueryPool queryPool, uint query);

        public unsafe void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            CommandResetQueryPool_(this, queryPool, firstQuery, queryCount);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdResetQueryPool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandResetQueryPool_(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);

        public unsafe void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            CommandWriteTimestamp_(this, pipelineStage, queryPool, query);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdWriteTimestamp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandWriteTimestamp_(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);

        public unsafe void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags flags)
        {
            CommandCopyQueryPoolResults_(this, queryPool, firstQuery, queryCount, destinationBuffer, destinationOffset, stride, flags);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdCopyQueryPoolResults", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandCopyQueryPoolResults_(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags flags);

        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, IntPtr values)
        {
            CommandPushConstants_(this, layout, stageFlags, offset, size, values);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdPushConstants", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandPushConstants_(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, IntPtr values);

        public unsafe void BeginRenderPass(ref RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
            fixed (RenderPassBeginInfo* __renderPassBegin__ = &renderPassBegin)
            {
                CommandBeginRenderPass_(this, __renderPassBegin__, contents);
            }
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdBeginRenderPass", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandBeginRenderPass_(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);

        public unsafe void NextSubpass(SubpassContents contents)
        {
            CommandNextSubpass_(this, contents);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdNextSubpass", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandNextSubpass_(CommandBuffer commandBuffer, SubpassContents contents);

        public unsafe void EndRenderPass()
        {
            CommandEndRenderPass_(this);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdEndRenderPass", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandEndRenderPass_(CommandBuffer commandBuffer);

        public unsafe void ExecuteCommands(uint commandBufferCount, CommandBuffer* commandBuffers)
        {
            CommandExecuteCommands_(this, commandBufferCount, commandBuffers);
        }

        [DllImport("vulkan-1.dll", EntryPoint = "vkCmdExecuteCommands", CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe void CommandExecuteCommands_(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);
    }
}
