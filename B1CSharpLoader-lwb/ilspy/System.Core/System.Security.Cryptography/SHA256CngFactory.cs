namespace System.Security.Cryptography;

internal static class SHA256CngFactory
{
	internal static SHA256Cng CreateNew()
	{
		return new SHA256Cng();
	}
}
