using System;
using System.Runtime.InteropServices;

namespace Managed
{
#pragma warning disable IDE1006 // Naming Styles
    internal static class Native
    {
        private const string LibName = "Native";
        //---------------------------------------------------------------------
        [DllImport(LibName)]
        public static extern int add(int a, int b);
        //---------------------------------------------------------------------
        [DllImport(LibName)]
        public static extern unsafe int sum(int* arr, int len);
        //---------------------------------------------------------------------
        [DllImport(LibName)]
        public static extern IntPtr getVersion();
        //---------------------------------------------------------------------
        [DllImport(LibName)]
        public static extern IntPtr buildConfig();
    }
#pragma warning restore IDE1006 // Naming Styles
}
