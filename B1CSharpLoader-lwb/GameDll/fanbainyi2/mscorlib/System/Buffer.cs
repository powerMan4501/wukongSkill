using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System;

[ComVisible(true)]
[__DynamicallyInvokable]
public static class Buffer
{
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	private struct Block16
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 64)]
	private struct Block64
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern void InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount);

	[SecurityCritical]
	internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
	{
		byte* ptr;
		for (ptr = src + index; ((int)ptr & 3) != 0; ptr++)
		{
			if (count == 0)
			{
				return -1;
			}
			if (*ptr == value)
			{
				return (int)(ptr - src);
			}
			count--;
		}
		uint num = (uint)((value << 8) + value);
		num = (num << 16) + num;
		while (count > 3)
		{
			uint num2 = *(uint*)ptr;
			num2 ^= num;
			uint num3 = 2130640639 + num2;
			num2 ^= 0xFFFFFFFFu;
			num2 ^= num3;
			if ((num2 & 0x81010100u) != 0)
			{
				int num4 = (int)(ptr - src);
				if (*ptr == value)
				{
					return num4;
				}
				if (ptr[1] == value)
				{
					return num4 + 1;
				}
				if (ptr[2] == value)
				{
					return num4 + 2;
				}
				if (ptr[3] == value)
				{
					return num4 + 3;
				}
			}
			count -= 4;
			ptr += 4;
		}
		while (count > 0)
		{
			if (*ptr == value)
			{
				return (int)(ptr - src);
			}
			count--;
			ptr++;
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsPrimitiveTypeArray(Array array);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern byte _GetByte(Array array, int index);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static byte GetByte(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (!IsPrimitiveTypeArray(array))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBePrimArray"), "array");
		}
		if (index < 0 || index >= _ByteLength(array))
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return _GetByte(array, index);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _SetByte(Array array, int index, byte value);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static void SetByte(Array array, int index, byte value)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (!IsPrimitiveTypeArray(array))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBePrimArray"), "array");
		}
		if (index < 0 || index >= _ByteLength(array))
		{
			throw new ArgumentOutOfRangeException("index");
		}
		_SetByte(array, index, value);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int _ByteLength(Array array);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int ByteLength(Array array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (!IsPrimitiveTypeArray(array))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBePrimArray"), "array");
		}
		return _ByteLength(array);
	}

	[SecurityCritical]
	internal unsafe static void ZeroMemory(byte* src, long len)
	{
		while (len-- > 0)
		{
			src[len] = 0;
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len)
	{
		if (len != 0)
		{
			fixed (byte* ptr = dest)
			{
				Memcpy(ptr + destIndex, src + srcIndex, len);
			}
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len)
	{
		if (len != 0)
		{
			fixed (byte* ptr = src)
			{
				Memcpy(pDest + destIndex, ptr + srcIndex, len);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[FriendAccessAllowed]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void Memcpy(byte* dest, byte* src, int len)
	{
		Memmove(dest, src, (uint)len);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void Memmove(byte* dest, byte* src, uint len)
	{
		if ((uint)((int)dest - (int)src) >= len && (uint)((int)src - (int)dest) >= len)
		{
			byte* ptr = src + len;
			byte* ptr2 = dest + len;
			if (len > 16)
			{
				if (len > 64)
				{
					if (len > 2048)
					{
						goto IL_0112;
					}
					uint num = len >> 6;
					do
					{
						*(Block64*)dest = *(Block64*)src;
						dest += 64;
						src += 64;
						num--;
					}
					while (num != 0);
					len %= 64;
					if (len <= 16)
					{
						*(Block16*)(ptr2 - 16) = *(Block16*)(ptr - 16);
						return;
					}
				}
				*(Block16*)dest = *(Block16*)src;
				if (len > 32)
				{
					*(Block16*)(dest + 16) = *(Block16*)(src + 16);
					if (len > 48)
					{
						*(Block16*)(dest + 32) = *(Block16*)(src + 32);
					}
				}
				*(Block16*)(ptr2 - 16) = *(Block16*)(ptr - 16);
			}
			else if ((len & 0x18) != 0)
			{
				*(int*)dest = *(int*)src;
				((int*)dest)[1] = ((int*)src)[1];
				*((int*)ptr2 - 2) = *((int*)ptr - 2);
				*((int*)ptr2 - 1) = *((int*)ptr - 1);
			}
			else if ((len & 4) != 0)
			{
				*(int*)dest = *(int*)src;
				*((int*)ptr2 - 1) = *((int*)ptr - 1);
			}
			else if (len != 0)
			{
				*dest = *src;
				if ((len & 2) != 0)
				{
					*((short*)ptr2 - 1) = *((short*)ptr - 1);
				}
			}
			return;
		}
		goto IL_0112;
		IL_0112:
		_Memmove(dest, src, len);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static void _Memmove(byte* dest, byte* src, uint len)
	{
		__Memmove(dest, src, len);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private unsafe static extern void __Memmove(byte* dest, byte* src, uint len);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
	{
		if (sourceBytesToCopy > destinationSizeInBytes)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.sourceBytesToCopy);
		}
		Memmove((byte*)destination, (byte*)source, checked((uint)sourceBytesToCopy));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy)
	{
		if (sourceBytesToCopy > destinationSizeInBytes)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.sourceBytesToCopy);
		}
		Memmove((byte*)destination, (byte*)source, checked((uint)sourceBytesToCopy));
	}
}
