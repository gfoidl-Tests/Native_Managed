using System;
using System.Runtime.InteropServices;

namespace Managed
{
    internal static class Native
    {
        private const string LibName = "Native";
        //---------------------------------------------------------------------
        [DllImport(LibName, EntryPoint = "add")]
        public static extern int Add(int a, int b);
        //---------------------------------------------------------------------
        [DllImport(LibName, EntryPoint = "sum")]
        public static extern unsafe int Sum(int* arr, int len);
        //---------------------------------------------------------------------
        [DllImport(LibName, EntryPoint = "getVersion")]
        private static extern IntPtr GetVersionCore();

        public static string GetVersion() => GetString(GetVersionCore());
        //---------------------------------------------------------------------
        [DllImport(LibName, EntryPoint = "buildConfig")]
        private static extern IntPtr BuildConfigCore();

        public static string BuildConfig() => GetString(BuildConfigCore());
        //---------------------------------------------------------------------
        private static string GetString(IntPtr ptr) => Marshal.PtrToStringAnsi(ptr);
    }
}
