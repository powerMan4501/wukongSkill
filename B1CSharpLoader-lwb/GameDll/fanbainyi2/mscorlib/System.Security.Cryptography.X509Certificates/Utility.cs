using System.Text;

namespace System.Security.Cryptography.X509Certificates;

internal static class Utility
{
	public static Span<T> GetSpanForArray<T>(T[] array, int offset)
	{
		return GetSpanForArray(array, offset, array.Length - offset);
	}

	public static Span<T> GetSpanForArray<T>(T[] array, int offset, int count)
	{
		return new Span<T>(array, offset, count);
	}

	public static int EncodingGetByteCount(Encoding encoding, ReadOnlySpan<char> input)
	{
		if (input.IsNull)
		{
			return encoding.GetByteCount(new char[0]);
		}
		ArraySegment<char> arraySegment = input.DangerousGetArraySegment();
		return encoding.GetByteCount(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
	}

	public static int EncodingGetBytes(Encoding encoding, char[] input, Span<byte> destination)
	{
		ArraySegment<byte> arraySegment = destination.DangerousGetArraySegment();
		return encoding.GetBytes(input, 0, input.Length, arraySegment.Array, arraySegment.Offset);
	}

	public static int EncodingGetBytes(Encoding encoding, ReadOnlySpan<char> input, Span<byte> destination)
	{
		ArraySegment<byte> arraySegment = destination.DangerousGetArraySegment();
		ArraySegment<char> arraySegment2 = input.DangerousGetArraySegment();
		return encoding.GetBytes(arraySegment2.Array, arraySegment2.Offset, arraySegment2.Count, arraySegment.Array, arraySegment.Offset);
	}
}
