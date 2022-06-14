// (c) gfoidl, all rights reserved

using System;
using System.Runtime.InteropServices;

namespace Managed;

internal static partial class Native
{
    private const string LibName = "Native";
    //-------------------------------------------------------------------------
    [LibraryImport(LibName, EntryPoint = "add")]
    public static partial int Add(int a, int b);
    //-------------------------------------------------------------------------
    [LibraryImport(LibName, EntryPoint = "sum")]
    public static unsafe partial int Sum(int* arr, int len);
    //-------------------------------------------------------------------------
    [LibraryImport(LibName, EntryPoint = "getVersion")]
    private static partial IntPtr GetVersionCore();

    public static string GetVersion() => GetString(GetVersionCore());
    //-------------------------------------------------------------------------
    [LibraryImport(LibName, EntryPoint = "buildConfig")]
    private static partial IntPtr BuildConfigCore();

    public static string BuildConfig() => GetString(BuildConfigCore());
    //-------------------------------------------------------------------------
    private static string GetString(IntPtr ptr) => Marshal.PtrToStringAnsi(ptr);
}
