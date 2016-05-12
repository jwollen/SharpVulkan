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

namespace SharpVulkan
{
    public partial struct Device
    {
        public unsafe SparseImageMemoryRequirements[] GetSparseMemoryRequirements(Image image)
        {
            uint count = 0;
            GetImageSparseMemoryRequirements(image, ref count, null);

            var result = new SparseImageMemoryRequirements[count];
            if (count > 0)
            {
                fixed (SparseImageMemoryRequirements* resultPointer = &result[0])
                    GetImageSparseMemoryRequirements(image, ref count, resultPointer);
            }

            return result;
        }

        public unsafe byte[] GetPipelineCacheData(PipelineCache pipelineCache)
        {
            PointerSize count = 0;
            GetPipelineCacheData(pipelineCache, ref count, IntPtr.Zero);

            var result = new byte[count];
            if (count > 0)
            {
                fixed (byte* resultPtr = &result[0])
                    GetPipelineCacheData(pipelineCache, ref count, new IntPtr(resultPtr));
            }

            return result;
        }

        public unsafe Image[] GetSwapchainImages(Swapchain swapchain)
        {
            uint count = 0;
            GetSwapchainImages(swapchain, ref count, null);

            var result = new Image[count];
            if (count > 0)
            {
                fixed (Image* resultPtr = &result[0])
                    GetSwapchainImages(swapchain, ref count, resultPtr);
            }

            return result;
        }

        public unsafe Swapchain[] CreateSharedSwapchains(SwapchainCreateInfo[] createInfos, AllocationCallbacks allocator)
        {
            var swapchains = new Swapchain[createInfos.Length];
            fixed (SwapchainCreateInfo* __createInfos__ = &createInfos[0])
            fixed (Swapchain* __swapchains__ = &swapchains[0])
            {
                vkCreateSharedSwapchainsKHR(this, (uint)createInfos.Length, __createInfos__, &allocator, __swapchains__).CheckError();
            }
            return swapchains;
        }
    }
}