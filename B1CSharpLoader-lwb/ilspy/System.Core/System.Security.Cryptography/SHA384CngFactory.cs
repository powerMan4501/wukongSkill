namespace System.Security.Cryptography;

internal static class SHA384CngFactory
{
	internal static SHA384Cng CreateNew()
	{
		return new SHA384Cng();
	}
}
