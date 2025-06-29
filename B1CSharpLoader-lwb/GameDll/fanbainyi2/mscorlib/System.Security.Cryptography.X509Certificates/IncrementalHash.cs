namespace System.Security.Cryptography.X509Certificates;

internal class IncrementalHash : IDisposable
{
	private readonly HashAlgorithm _algorithm;

	private static readonly byte[] s_Empty = new byte[0];

	private IncrementalHash(HashAlgorithm algorithm)
	{
		_algorithm = algorithm;
	}

	public static IncrementalHash CreateHash(HashAlgorithmName hashAlgorithm)
	{
		if (hashAlgorithm == HashAlgorithmName.MD5)
		{
			return new IncrementalHash(MD5.Create());
		}
		if (hashAlgorithm == HashAlgorithmName.SHA1)
		{
			return new IncrementalHash(SHA1.Create());
		}
		if (hashAlgorithm == HashAlgorithmName.SHA256)
		{
			return new IncrementalHash(SHA256.Create());
		}
		if (hashAlgorithm == HashAlgorithmName.SHA384)
		{
			return new IncrementalHash(SHA384.Create());
		}
		if (hashAlgorithm == HashAlgorithmName.SHA512)
		{
			return new IncrementalHash(SHA512.Create());
		}
		throw new CryptographicException();
	}

	public void AppendData(ReadOnlySpan<byte> data)
	{
		ArraySegment<byte> arraySegment = data.DangerousGetArraySegment();
		_algorithm.TransformBlock(arraySegment.Array, arraySegment.Offset, arraySegment.Count, null, 0);
	}

	public bool TryGetHashAndReset(Span<byte> destination, out int bytesWritten)
	{
		if (destination.Length < _algorithm.HashSize / 8)
		{
			bytesWritten = 0;
			return false;
		}
		_algorithm.TransformFinalBlock(s_Empty, 0, 0);
		byte[] hash = _algorithm.Hash;
		_algorithm.Initialize();
		new ReadOnlyMemory<byte>(hash).CopyTo(destination);
		bytesWritten = hash.Length;
		return true;
	}

	public void Dispose()
	{
		_algorithm.Clear();
	}
}
