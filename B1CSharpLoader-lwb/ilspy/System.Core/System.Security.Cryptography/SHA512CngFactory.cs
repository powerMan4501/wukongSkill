namespace System.Security.Cryptography;

internal static class SHA512CngFactory
{
	internal static SHA512Cng CreateNew()
	{
		return new SHA512Cng();
	}
}
