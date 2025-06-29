namespace System.Security.Cryptography;

internal struct BCRYPT_DSA_KEY_BLOB_V2
{
	public BCryptNative.KeyBlobMagicNumber dwMagic;

	public int cbKey;

	public HASHALGORITHM_ENUM hashAlgorithm;

	public DSAFIPSVERSION_ENUM standardVersion;

	public int cbSeedLength;

	public int cbGroupSize;

	public byte Count3;

	public byte Count2;

	public byte Count1;

	public byte Count0;
}
