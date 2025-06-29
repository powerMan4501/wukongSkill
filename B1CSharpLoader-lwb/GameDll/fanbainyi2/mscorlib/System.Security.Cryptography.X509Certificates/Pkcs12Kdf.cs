using System.Globalization;
using System.Text;

namespace System.Security.Cryptography.X509Certificates;

internal static class Pkcs12Kdf
{
	private const byte CipherKeyId = 1;

	private const byte IvId = 2;

	private const byte MacKeyId = 3;

	private static readonly Triple<HashAlgorithmName, int, int>[] s_uvLookup = new Triple<HashAlgorithmName, int, int>[5]
	{
		new Triple<HashAlgorithmName, int, int>(HashAlgorithmName.MD5, 128, 512),
		new Triple<HashAlgorithmName, int, int>(HashAlgorithmName.SHA1, 160, 512),
		new Triple<HashAlgorithmName, int, int>(HashAlgorithmName.SHA256, 256, 512),
		new Triple<HashAlgorithmName, int, int>(HashAlgorithmName.SHA384, 384, 1024),
		new Triple<HashAlgorithmName, int, int>(HashAlgorithmName.SHA512, 512, 1024)
	};

	internal static void DeriveCipherKey(ReadOnlySpan<char> password, HashAlgorithmName hashAlgorithm, int iterationCount, ReadOnlySpan<byte> salt, Span<byte> destination)
	{
		Derive(password, hashAlgorithm, iterationCount, 1, salt, destination);
	}

	internal static void DeriveIV(ReadOnlySpan<char> password, HashAlgorithmName hashAlgorithm, int iterationCount, ReadOnlySpan<byte> salt, Span<byte> destination)
	{
		Derive(password, hashAlgorithm, iterationCount, 2, salt, destination);
	}

	internal static void DeriveMacKey(ReadOnlySpan<char> password, HashAlgorithmName hashAlgorithm, int iterationCount, ReadOnlySpan<byte> salt, Span<byte> destination)
	{
		Derive(password, hashAlgorithm, iterationCount, 3, salt, destination);
	}

	private static void Derive(ReadOnlySpan<char> password, HashAlgorithmName hashAlgorithm, int iterationCount, byte id, ReadOnlySpan<byte> salt, Span<byte> destination)
	{
		int num = -1;
		int num2 = -1;
		Triple<HashAlgorithmName, int, int>[] array = s_uvLookup;
		for (int i = 0; i < array.Length; i++)
		{
			Triple<HashAlgorithmName, int, int> triple = array[i];
			if (triple.Item1 == hashAlgorithm)
			{
				num = triple.Item2;
				num2 = triple.Item3;
				break;
			}
		}
		if (num == -1)
		{
			throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a known hash algorithm.", hashAlgorithm.Name));
		}
		int num3 = num2 >> 3;
		Span<byte> span = new byte[num3];
		span.Fill(id);
		int num4 = (salt.Length - 1 + num3) / num3 * num3;
		byte[] array2;
		Span<byte> span2;
		IncrementalHash incrementalHash;
		checked
		{
			int num5 = (password.Length + 1) * 2;
			if (password.IsNull)
			{
				num5 = 0;
			}
			int num6 = unchecked(checked(num5 - 1 + num3) / num3) * num3;
			int num7 = num4 + num6;
			array2 = CryptoPool.Rent(num7);
			span2 = new Span<byte>(array2, 0, num7);
			KdfWorkLimiter.RecordIterations(iterationCount);
			incrementalHash = IncrementalHash.CreateHash(hashAlgorithm);
		}
		try
		{
			CircularCopy(salt, span2.Slice(0, num4));
			CircularCopyUtf16BE(password, span2.Slice(num4));
			int num8 = num >> 3;
			Span<byte> span3 = new byte[num8];
			Span<byte> span4 = new byte[num3];
			while (true)
			{
				incrementalHash.AppendData(span);
				incrementalHash.AppendData(span2);
				for (int num9 = iterationCount; num9 > 0; num9--)
				{
					if (!incrementalHash.TryGetHashAndReset(span3, out var bytesWritten) || bytesWritten != span3.Length)
					{
						throw new CryptographicException();
					}
					if (num9 != 1)
					{
						incrementalHash.AppendData(span3);
					}
				}
				if (span3.Length >= destination.Length)
				{
					break;
				}
				span3.CopyTo(destination);
				destination = destination.Slice(span3.Length);
				CircularCopy(span3, span4);
				for (int num10 = span2.Length / num3 - 1; num10 >= 0; num10--)
				{
					Span<byte> span5 = span2.Slice(num10 * num3, num3);
					AddPlusOne(span5, span4);
				}
			}
			span3.Slice(0, destination.Length).CopyTo(destination);
		}
		finally
		{
			CryptographicOperations.ZeroMemory(span2);
			if (array2 != null)
			{
				CryptoPool.Return(array2, 0);
			}
			incrementalHash.Dispose();
		}
	}

	private static void AddPlusOne(Span<byte> into, Span<byte> addend)
	{
		int num = 1;
		for (int num2 = into.Length - 1; num2 >= 0; num2--)
		{
			int num3 = num + into[num2] + addend[num2];
			into[num2] = (byte)num3;
			num = num3 >> 8;
		}
	}

	private static void CircularCopy(ReadOnlySpan<byte> bytes, Span<byte> destination)
	{
		while (destination.Length > 0)
		{
			if (destination.Length >= bytes.Length)
			{
				bytes.CopyTo(destination);
				destination = destination.Slice(bytes.Length);
				continue;
			}
			bytes.Slice(0, destination.Length).CopyTo(destination);
			break;
		}
	}

	private static void CircularCopyUtf16BE(ReadOnlySpan<char> password, Span<byte> destination)
	{
		int num = password.Length * 2;
		Encoding bigEndianUnicode = Encoding.BigEndianUnicode;
		while (destination.Length > 0)
		{
			if (destination.Length >= num)
			{
				int num2 = Utility.EncodingGetBytes(bigEndianUnicode, password, destination);
				if (num2 != num)
				{
					throw new CryptographicException();
				}
				destination = destination.Slice(num2);
				Span<byte> span = destination.Slice(0, Math.Min(2, destination.Length));
				span.Clear();
				destination = destination.Slice(span.Length);
				continue;
			}
			ReadOnlySpan<char> input = password.Slice(0, destination.Length / 2);
			int num3 = Utility.EncodingGetBytes(bigEndianUnicode, input, destination);
			if (num3 != destination.Length)
			{
				throw new CryptographicException();
			}
			break;
		}
	}
}
