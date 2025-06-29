using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSharedMemoryRegion
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetName(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetAddress(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetSize(IntPtr instance);

	public static Del_GetName GetName;

	public static Del_GetAddress GetAddress;

	public static Del_GetSize GetSize;
}
