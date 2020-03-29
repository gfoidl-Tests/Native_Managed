using System;
using System.Runtime.InteropServices;

namespace Managed
{
    public static class Math
    {
        public static int Add(int a, int b) => Native.add(a, b);
        //---------------------------------------------------------------------
        public static unsafe int Sum(ReadOnlySpan<int> data)
        {
            if (data.IsEmpty) return 0;

            fixed (int* ptr = &MemoryMarshal.GetReference(data))
            {
                return Native.sum(ptr, data.Length);
            }
        }
        //---------------------------------------------------------------------
        public static string GetNativeVersion()     => GetString(Native.getVersion());
        public static string GetNativeBuildConfig() => GetString(Native.buildConfig());
        private static string GetString(IntPtr ptr) => Marshal.PtrToStringAnsi(ptr);
    }
}
