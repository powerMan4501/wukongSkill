namespace System.Security.Cryptography.X509Certificates;

internal static class CryptoPool
{
	public static byte[] Rent(int size)
	{
		return new byte[size];
	}

	public static void Return(byte[] array, int clearSize)
	{
		CryptographicOperations.ZeroMemory(new Span<byte>(array, 0, clearSize));
	}

	public static void Return(byte[] array)
	{
		CryptographicOperations.ZeroMemory(new Span<byte>(array));
	}

	public static void Return(ArraySegment<byte> segment, int clearSize)
	{
		CryptographicOperations.ZeroMemory(new Span<byte>(segment).Slice(0, clearSize));
	}

	public static void Return(ArraySegment<byte> segment)
	{
		CryptographicOperations.ZeroMemory(new Span<byte>(segment));
	}
}
