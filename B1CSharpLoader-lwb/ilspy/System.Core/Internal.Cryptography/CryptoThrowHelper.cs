using System.Security.Cryptography;

namespace Internal.Cryptography;

internal static class CryptoThrowHelper
{
	public static CryptographicException ToCryptographicException(this int hr)
	{
		throw new CryptographicException(hr);
	}
}
