namespace System.Security.Cryptography.X509Certificates;

[Flags]
internal enum OpenAlgorithmProviderFlags : uint
{
	NONE = 0u,
	BCRYPT_ALG_HANDLE_HMAC_FLAG = 8u
}
