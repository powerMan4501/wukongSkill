using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FMemory
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Memmove(IntPtr dest, IntPtr src, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Memcmp(IntPtr dest, IntPtr src, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Memset(IntPtr dest, byte value, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Memzero(IntPtr dest, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Memcpy(IntPtr dest, IntPtr src, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_BigBlockMemcpy(IntPtr dest, IntPtr src, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StreamingMemcpy(IntPtr dest, IntPtr src, ulong count);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Memswap(IntPtr ptr1, IntPtr ptr2, ulong size);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_SystemMalloc(ulong size);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SystemFree(IntPtr ptr);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Malloc(ulong count, uint alignment);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Realloc(IntPtr original, ulong count, uint alignment);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Free(IntPtr original);

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_GetAllocSize(IntPtr original);

	[MonoNativeFunctionWrapper]
	public delegate ulong Del_QuantizeSize(ulong count, uint alignment);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Trim();

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetupTLSCachesOnCurrentThread();

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearAndDisableTLSCachesOnCurrentThread();

	[MonoNativeFunctionWrapper]
	public delegate void Del_TestMemory();

	[MonoNativeFunctionWrapper]
	public delegate void Del_EnablePurgatoryTests();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_PageProtect(IntPtr ptr, IntPtr size, csbool canRead, csbool canWrite);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_MapNamedSharedMemoryRegion(ref FScriptArray name, csbool create, uint accessMode, IntPtr size);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_UnmapNamedSharedMemoryRegion(IntPtr memoryRegion);

	public static Del_Memmove Memmove;

	public static Del_Memcmp Memcmp;

	public static Del_Memset Memset;

	public static Del_Memzero Memzero;

	public static Del_Memcpy Memcpy;

	public static Del_BigBlockMemcpy BigBlockMemcpy;

	public static Del_StreamingMemcpy StreamingMemcpy;

	public static Del_Memswap Memswap;

	public static Del_SystemMalloc SystemMalloc;

	public static Del_SystemFree SystemFree;

	public static Del_Malloc Malloc;

	public static Del_Realloc Realloc;

	public static Del_Free Free;

	public static Del_GetAllocSize GetAllocSize;

	public static Del_QuantizeSize QuantizeSize;

	public static Del_Trim Trim;

	public static Del_SetupTLSCachesOnCurrentThread SetupTLSCachesOnCurrentThread;

	public static Del_ClearAndDisableTLSCachesOnCurrentThread ClearAndDisableTLSCachesOnCurrentThread;

	public static Del_TestMemory TestMemory;

	public static Del_EnablePurgatoryTests EnablePurgatoryTests;

	public static Del_PageProtect PageProtect;

	public static Del_MapNamedSharedMemoryRegion MapNamedSharedMemoryRegion;

	public static Del_UnmapNamedSharedMemoryRegion UnmapNamedSharedMemoryRegion;
}
