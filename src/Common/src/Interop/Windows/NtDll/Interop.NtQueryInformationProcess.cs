// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class NtDll
    {
        [DllImport(Libraries.NtDll)]
        internal static extern int NtQueryInformationProcess(SafeProcessHandle processHandle, int query, out NtProcessBasicInfo info, int size, int[] returnedSize);

        [StructLayout(LayoutKind.Sequential)]
        internal struct NtProcessBasicInfo
        {
            internal int ExitStatus;
            internal IntPtr PebBaseAddress;
            internal IntPtr AffinityMask;
            internal int BasePriority;
            internal IntPtr UniqueProcessId;
            internal IntPtr InheritedFromUniqueProcessId;
        }

        internal const int NtQueryProcessBasicInfo = 0;
    }
}
