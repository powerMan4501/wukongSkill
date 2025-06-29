using System.Diagnostics;

namespace System.Security.Cryptography.X509Certificates;

internal static class Helpers
{
	internal static bool SequenceEqual(byte[] left, byte[] right)
	{
		if (left.Length != right.Length)
		{
			return false;
		}
		for (int i = 0; i < left.Length; i++)
		{
			if (left[i] != right[i])
			{
				return false;
			}
		}
		return true;
	}

	internal static ReadOnlyMemory<byte> DecodeOctetStringAsMemory(ReadOnlyMemory<byte> encodedOctetString)
	{
		try
		{
			ReadOnlySpan<byte> span = encodedOctetString.Span;
			if (AsnDecoder.TryReadPrimitiveOctetString(span, AsnEncodingRules.BER, out var value, out var bytesConsumed, null))
			{
				if (bytesConsumed != span.Length)
				{
					throw new CryptographicException("ASN1 corrupted data.");
				}
				if (span.Overlaps(value, out var elementOffset))
				{
					return encodedOctetString.Slice(elementOffset, value.Length);
				}
				Assert.Fail("input.Overlaps(primitive)", "input.Overlaps(primitive) failed after TryReadPrimitiveOctetString succeeded");
			}
			byte[] array = AsnDecoder.ReadOctetString(span, AsnEncodingRules.BER, out bytesConsumed, null);
			if (bytesConsumed != span.Length)
			{
				throw new CryptographicException("ASN1 corrupted data.");
			}
			return array;
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}
}
