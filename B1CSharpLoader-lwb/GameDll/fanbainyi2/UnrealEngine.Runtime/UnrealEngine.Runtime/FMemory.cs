using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FMemory
{
	public const uint DEFAULT_ALIGNMENT = 0u;

	public const uint MIN_ALIGNMENT = 8u;

	public static IntPtr Memmove(IntPtr dest, IntPtr src, int count)
	{
		return Native_FMemory.Memmove(dest, src, (ulong)count);
	}

	public static IntPtr Memmove(IntPtr dest, IntPtr src, uint count)
	{
		return Native_FMemory.Memmove(dest, src, count);
	}

	public static IntPtr Memmove(IntPtr dest, IntPtr src, ulong count)
	{
		return Native_FMemory.Memmove(dest, src, count);
	}

	public static int Memcmp(IntPtr dest, IntPtr src, int count)
	{
		return Native_FMemory.Memcmp(dest, src, (ulong)count);
	}

	public static int Memcmp(IntPtr dest, IntPtr src, uint count)
	{
		return Native_FMemory.Memcmp(dest, src, count);
	}

	public static int Memcmp(IntPtr dest, IntPtr src, ulong count)
	{
		return Native_FMemory.Memcmp(dest, src, count);
	}

	public static IntPtr Memset(IntPtr dest, byte value, int count)
	{
		return Native_FMemory.Memset(dest, value, (ulong)count);
	}

	public static IntPtr Memset(IntPtr dest, byte value, uint count)
	{
		return Native_FMemory.Memset(dest, value, count);
	}

	public static IntPtr Memset(IntPtr dest, byte value, ulong count)
	{
		return Native_FMemory.Memset(dest, value, count);
	}

	public static IntPtr Memzero(IntPtr dest, int count)
	{
		return Native_FMemory.Memzero(dest, (ulong)count);
	}

	public static IntPtr Memzero(IntPtr dest, uint count)
	{
		return Native_FMemory.Memzero(dest, count);
	}

	public static IntPtr Memzero(IntPtr dest, ulong count)
	{
		return Native_FMemory.Memzero(dest, count);
	}

	public static void Memzero<T>(ref T value) where T : struct
	{
		value = default(T);
	}

	public static IntPtr Memcpy(IntPtr dest, IntPtr src, int count)
	{
		return Native_FMemory.Memcpy(dest, src, (ulong)count);
	}

	public static IntPtr Memcpy(IntPtr dest, IntPtr src, uint count)
	{
		return Native_FMemory.Memcpy(dest, src, count);
	}

	public static IntPtr Memcpy(IntPtr dest, IntPtr src, ulong count)
	{
		return Native_FMemory.Memcpy(dest, src, count);
	}

	public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, int count)
	{
		return Native_FMemory.BigBlockMemcpy(dest, src, (ulong)count);
	}

	public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, uint count)
	{
		return Native_FMemory.BigBlockMemcpy(dest, src, count);
	}

	public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, ulong count)
	{
		return Native_FMemory.BigBlockMemcpy(dest, src, count);
	}

	public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, int count)
	{
		return Native_FMemory.StreamingMemcpy(dest, src, (ulong)count);
	}

	public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, uint count)
	{
		return Native_FMemory.StreamingMemcpy(dest, src, count);
	}

	public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, ulong count)
	{
		return Native_FMemory.StreamingMemcpy(dest, src, count);
	}

	public static void Memswap(IntPtr ptr1, IntPtr ptr2, int size)
	{
		Native_FMemory.Memswap(ptr1, ptr2, (ulong)size);
	}

	public static void Memswap(IntPtr ptr1, IntPtr ptr2, uint size)
	{
		Native_FMemory.Memswap(ptr1, ptr2, size);
	}

	public static void Memswap(IntPtr ptr1, IntPtr ptr2, ulong size)
	{
		Native_FMemory.Memswap(ptr1, ptr2, size);
	}

	public static IntPtr SystemMalloc(int size)
	{
		return Native_FMemory.SystemMalloc((ulong)size);
	}

	public static IntPtr SystemMalloc(uint size)
	{
		return Native_FMemory.SystemMalloc(size);
	}

	public static IntPtr SystemMalloc(ulong size)
	{
		return Native_FMemory.SystemMalloc(size);
	}

	public static void SystemFree(IntPtr ptr)
	{
		Native_FMemory.SystemFree(ptr);
	}

	public static IntPtr Malloc(int count, uint alignment = 0u)
	{
		return Native_FMemory.Malloc((ulong)count, alignment);
	}

	public static IntPtr Malloc(uint count, uint alignment = 0u)
	{
		return Native_FMemory.Malloc(count, alignment);
	}

	public static IntPtr Malloc(ulong count, uint alignment = 0u)
	{
		return Native_FMemory.Malloc(count, alignment);
	}

	public static IntPtr Realloc(IntPtr original, int count, uint alignment = 0u)
	{
		return Native_FMemory.Realloc(original, (ulong)count, alignment);
	}

	public static IntPtr Realloc(IntPtr original, uint count, uint alignment = 0u)
	{
		return Native_FMemory.Realloc(original, count, alignment);
	}

	public static IntPtr Realloc(IntPtr original, ulong count, uint alignment = 0u)
	{
		return Native_FMemory.Realloc(original, count, alignment);
	}

	public static void Free(IntPtr original)
	{
		Native_FMemory.Free(original);
	}

	public static ulong GetAllocSize(IntPtr original)
	{
		return Native_FMemory.GetAllocSize(original);
	}

	public static ulong QuantizeSize(int count, uint alignment = 0u)
	{
		return Native_FMemory.QuantizeSize((ulong)count, alignment);
	}

	public static ulong QuantizeSize(uint count, uint alignment = 0u)
	{
		return Native_FMemory.QuantizeSize(count, alignment);
	}

	public static ulong QuantizeSize(ulong count, uint alignment = 0u)
	{
		return Native_FMemory.QuantizeSize(count, alignment);
	}

	public static void Trim()
	{
		Native_FMemory.Trim();
	}

	public static void SetupTLSCachesOnCurrentThread()
	{
		Native_FMemory.SetupTLSCachesOnCurrentThread();
	}

	public static void ClearAndDisableTLSCachesOnCurrentThread()
	{
		Native_FMemory.ClearAndDisableTLSCachesOnCurrentThread();
	}

	public static void TestMemory()
	{
		Native_FMemory.TestMemory();
	}

	public static void EnablePurgatoryTests()
	{
		Native_FMemory.EnablePurgatoryTests();
	}

	public static bool PageProtect(IntPtr ptr, IntPtr size, bool canRead, bool canWrite)
	{
		return Native_FMemory.PageProtect(ptr, size, canRead, canWrite);
	}

	public static FSharedMemoryRegion MapNamedSharedMemoryRegion(string name, bool create, ESharedMemoryAccess accessMode, IntPtr size)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return new FSharedMemoryRegion(Native_FMemory.MapNamedSharedMemoryRegion(ref fStringUnsafe.Array, create, (uint)accessMode, size));
	}

	public static bool UnmapNamedSharedMemoryRegion(FSharedMemoryRegion memoryRegion)
	{
		return Native_FMemory.UnmapNamedSharedMemoryRegion(memoryRegion.Address);
	}

	public static IntPtr PageAlignPointer(IntPtr ptr)
	{
		return (IntPtr)(ptr.ToInt64() & ~(Environment.SystemPageSize - 1));
	}
}
