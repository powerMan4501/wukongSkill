using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

internal static class BlobUtilities
{
	public const int SizeOfGuid = 16;

	[SecuritySafeCritical]
	public unsafe static byte[] ReadBytes(byte* buffer, int byteCount)
	{
		if (byteCount == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[byteCount];
		Marshal.Copy((IntPtr)buffer, array, 0, byteCount);
		return array;
	}

	[SecuritySafeCritical]
	public unsafe static ImmutableArray<byte> ReadImmutableBytes(byte* buffer, int byteCount)
	{
		byte[] array = ReadBytes(buffer, byteCount);
		return new ImmutableArray<byte>(array);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void ValidateRange(int bufferLength, int start, int byteCount, string byteCountParameterName)
	{
		if (start < 0 || start > bufferLength)
		{
			Throw.ArgumentOutOfRange("start");
		}
		if (byteCount < 0 || byteCount > bufferLength - start)
		{
			Throw.ArgumentOutOfRange(byteCountParameterName);
		}
	}
}
