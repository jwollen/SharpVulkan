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
using System.Runtime.InteropServices;

namespace SharpVulkan
{
    public partial struct PhysicalDevice
    {
        public unsafe LayerProperties[] DeviceLayerProperties
        {
            get
            {
                uint count = 0;
                EnumerateDeviceLayerProperties(ref count, null);

                var result = new LayerProperties[count];
                if (count > 0)
                {
                    fixed (LayerProperties* resultPointer = &result[0])
                        EnumerateDeviceLayerProperties(ref count, resultPointer);
                }

                return result;
            }
        }

        public unsafe ExtensionProperties[] GetDeviceExtensionProperties(string layerName = null)
        {
            var nativeString = layerName != null ? Marshal.StringToHGlobalAnsi(layerName) : IntPtr.Zero;
            try
            {
                uint count = 0;
                EnumerateDeviceExtensionProperties((byte*)nativeString, ref count, null);

                var result = new ExtensionProperties[count];
                if (count > 0)
                {
                    fixed (ExtensionProperties* resultPointer = &result[0])
                        EnumerateDeviceExtensionProperties((byte*)nativeString, ref count, resultPointer);
                }

                return result;
            }
            finally
            {
                Marshal.FreeHGlobal(nativeString);
            }
        }

        public unsafe QueueFamilyProperties[] QueueFamilyProperties
        {
            get
            {
                uint count = 0;
                GetQueueFamilyProperties(ref count, null);

                var result = new QueueFamilyProperties[count];
                if (count > 0)
                {
                    fixed (QueueFamilyProperties* resultPointer = &result[0])
                        GetQueueFamilyProperties(ref count, resultPointer);
                }

                return result;
            }
        }

        public unsafe DisplayPlaneProperties[] DisplayPlaneProperties
        {
            get
            {
                uint count = 0;
                GetDisplayPlaneProperties(ref count, null);

                var result = new DisplayPlaneProperties[count];
                if (count > 0)
                {
                    fixed (DisplayPlaneProperties* resultPointer = &result[0])
                        GetDisplayPlaneProperties(ref count, resultPointer);
                }

                return result;
            }
        }

        public unsafe DisplayProperties[] DisplayProperties
        {
            get
            {
                uint count = 0;
                GetDisplayProperties(ref count, null);

                var result = new DisplayProperties[count];
                if (count > 0)
                {
                    fixed (DisplayProperties* resultPointer = &result[0])
                        GetDisplayProperties(ref count, resultPointer);
                }

                return result;
            }
        }

        public unsafe SparseImageFormatProperties[] GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling)
        {
            uint count = 0;
            GetSparseImageFormatProperties(format, type, samples, usage, tiling, ref count, null);

            var result = new SparseImageFormatProperties[count];
            if (count > 0)
            {
                fixed (SparseImageFormatProperties* resultPointer = &result[0])
                    GetSparseImageFormatProperties(format, type, samples, usage, tiling, ref count, resultPointer);
            }

            return result;
        }

        public unsafe DisplayModeProperties[] GetDisplayModeProperties(Display display)
        {
            uint count = 0;
            GetDisplayModeProperties(display, ref count, null);

            var result = new DisplayModeProperties[count];
            if (count > 0)
            {
                fixed (DisplayModeProperties* resultPointer = &result[0])
                    GetDisplayModeProperties(display, ref count, resultPointer);
            }

            return result;
        }

        public unsafe Display[] GetDisplayPlaneSupportedDisplays(uint planeIndex)
        {
            uint count = 0;
            GetDisplayPlaneSupportedDisplays(planeIndex, ref count, null);

            var result = new Display[count];
            if (count > 0)
            {
                fixed (Display* resultPointer = &result[0])
                    GetDisplayPlaneSupportedDisplays(planeIndex, ref count, resultPointer);
            }

            return result;
        }

        public unsafe SurfaceFormat[] GetSurfaceFormats(Surface surface)
        {
            uint count = 0;
            GetSurfaceFormats(surface, ref count, null);

            var result = new SurfaceFormat[count];
            if (count > 0)
            {
                fixed (SurfaceFormat* resultPointer = &result[0])
                    GetSurfaceFormats(surface, ref count, resultPointer);
            }

            return result;
        }

        public unsafe PresentMode[] GetSurfacePresentModes(Surface surface)
        {
            uint count = 0;
            GetSurfacePresentModes(surface, ref count, null);

            var result = new PresentMode[count];
            if (count > 0)
            {
                fixed (PresentMode* resultPointer = &result[0])
                    GetSurfacePresentModes(surface, ref count, resultPointer);
            }

            return result;
        }
    }
}
