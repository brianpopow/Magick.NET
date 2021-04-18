// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public static partial class OpenCL
    {
        [SuppressUnmanagedCodeSecurity]
        private static class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            public static class X64
            {
                #if PLATFORM_AnyCPU
                static X64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCL_GetDevices(out UIntPtr length);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCL_GetDevice(IntPtr list, UIntPtr index);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool OpenCL_GetEnabled();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool OpenCL_SetEnabled([MarshalAs(UnmanagedType.Bool)] bool value);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCL_GetDevices(out UIntPtr length);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr OpenCL_GetDevice(IntPtr list, UIntPtr index);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool OpenCL_GetEnabled();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.Bool)]
                public static extern bool OpenCL_SetEnabled([MarshalAs(UnmanagedType.Bool)] bool value);
            }
            #endif
        }
        private static class NativeOpenCL
        {
            static NativeOpenCL() { Environment.Initialize(); }
            public static IntPtr GetDevices(out UIntPtr length)
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                return NativeMethods.X64.OpenCL_GetDevices(out length);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                return NativeMethods.X86.OpenCL_GetDevices(out length);
                #endif
            }
            public static IntPtr GetDevice(IntPtr list, int index)
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                return NativeMethods.X64.OpenCL_GetDevice(list, (UIntPtr)index);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                return NativeMethods.X86.OpenCL_GetDevice(list, (UIntPtr)index);
                #endif
            }
            public static bool GetEnabled()
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                return NativeMethods.X64.OpenCL_GetEnabled();
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                return NativeMethods.X86.OpenCL_GetEnabled();
                #endif
            }
            public static bool SetEnabled(bool value)
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                return NativeMethods.X64.OpenCL_SetEnabled(value);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                return NativeMethods.X86.OpenCL_SetEnabled(value);
                #endif
            }
        }
    }
}
