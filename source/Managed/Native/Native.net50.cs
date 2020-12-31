using System;
using System.Reflection;
using System.Runtime.InteropServices;

// See also https://developers.redhat.com/blog/2019/09/06/interacting-with-native-libraries-in-net-core-3-0/
// This type could be a non-static class with IDisposable to unload the native lib if needed.

namespace Managed
{
    internal static unsafe class Native
    {
        private static readonly IntPtr s_lib         = NativeLibrary.Load("Native", Assembly.GetExecutingAssembly(), null);
        private static readonly IntPtr s_add         = NativeLibrary.GetExport(s_lib, "add");
        private static readonly IntPtr s_sum         = NativeLibrary.GetExport(s_lib, "sum");
        private static readonly IntPtr s_getVersion  = NativeLibrary.GetExport(s_lib, "getVersion");
        private static readonly IntPtr s_buildConfig = NativeLibrary.GetExport(s_lib, "buildConfig");
        //---------------------------------------------------------------------
        public static int Add(int a, int b)      => ((delegate*<int, int, int>)s_add)(a, b);
        public static int Sum(int* arr, int len) => ((delegate*<int*, int, int>)s_sum)(arr, len);
        //---------------------------------------------------------------------
        public static string GetVersion()
        {
            IntPtr ptr = ((delegate*<IntPtr>)s_getVersion)();
            return GetString(ptr);
        }
        //---------------------------------------------------------------------
        public static string BuildConfig()
        {
            IntPtr ptr = ((delegate*<IntPtr>)s_buildConfig)();
            return GetString(ptr);
        }
        //---------------------------------------------------------------------
        private static string GetString(IntPtr ptr) => Marshal.PtrToStringAnsi(ptr);
    }
}
