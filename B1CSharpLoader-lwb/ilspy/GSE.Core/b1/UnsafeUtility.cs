using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

internal class UnsafeUtility
{
	private static class BlittableHelper<T>
	{
		public static readonly bool IsBlittable;

		static BlittableHelper()
		{
			try
			{
				if (default(T) != null)
				{
					GCHandle.Alloc(default(T), GCHandleType.Pinned).Free();
					IsBlittable = true;
				}
			}
			catch
			{
			}
		}
	}

	public unsafe static void* Malloc(int cb, int align)
	{
		return (void*)FMemory.Malloc(cb);
	}

	public unsafe static void Free(void* ptr)
	{
		FMemory.Free((IntPtr)ptr);
	}

	private unsafe static void CustomCopy(void* dest, void* src, int count)
	{
		int num = count >> 3;
		long* ptr = (long*)dest;
		long* ptr2 = (long*)src;
		for (int i = 0; i < num; i++)
		{
			*ptr = *ptr2;
			ptr++;
			ptr2++;
		}
		dest = ptr;
		src = ptr2;
		count -= num << 3;
		if (count > 0)
		{
			byte* ptr3 = (byte*)dest;
			byte* ptr4 = (byte*)src;
			for (int j = 0; j < count; j++)
			{
				*ptr3 = *ptr4;
				ptr3++;
				ptr4++;
			}
		}
	}

	public unsafe static void MemCpy(void* Src, void* Dst, int Size)
	{
		CustomCopy(Src, Dst, Size);
	}

	public static int SizeOf<T>() where T : struct
	{
		return Marshal.SizeOf<T>();
	}

	public unsafe static T ReadArrayElement<T>(void* source, int index)
	{
		return Marshal.PtrToStructure<T>(IntPtr.Add((IntPtr)source, Marshal.SizeOf<T>() * index));
	}

	public unsafe static void WriteArrayElement<T>(void* destination, int index, T value) where T : struct
	{
		IntPtr pointer = (IntPtr)destination;
		pointer = IntPtr.Add(pointer, Marshal.SizeOf<T>() * index);
		Marshal.StructureToPtr(value, pointer, fDeleteOld: false);
	}

	public static int AlignOf<T>() where T : struct
	{
		return 4;
	}

	public static bool IsBlittable<T>() where T : struct
	{
		return BlittableHelper<T>.IsBlittable;
	}

	public static void NativeHelperAssert(bool condition)
	{
	}
}
