namespace System.Security.Cryptography.X509Certificates;

internal static class BinaryPrimitives
{
	public static bool TryReadUInt16BigEndian(ReadOnlySpan<byte> bytes, out ushort value)
	{
		if (bytes.Length < 2)
		{
			value = 0;
			return false;
		}
		value = (ushort)(bytes[1] | (bytes[0] << 8));
		return true;
	}

	public static short ReadInt16BigEndian(ReadOnlySpan<byte> bytes)
	{
		return (short)(bytes[1] | (bytes[0] << 8));
	}
}
