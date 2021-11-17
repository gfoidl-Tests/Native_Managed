// (c) gfoidl, all rights reserved

using System;
using System.Runtime.InteropServices;

namespace Managed;

public static class Math
{
    public static int Add(int a, int b) => Native.Add(a, b);
    //---------------------------------------------------------------------------------------------
    public static unsafe int Sum(ReadOnlySpan<int> data)
    {
        if (data.IsEmpty)
        {
            return 0;
        }

        fixed (int* ptr = &MemoryMarshal.GetReference(data))
        {
            return Native.Sum(ptr, data.Length);
        }
    }
    //---------------------------------------------------------------------------------------------
    public static string GetNativeVersion()     => Native.GetVersion();
    public static string GetNativeBuildConfig() => Native.BuildConfig();
}
