namespace System.Security.Cryptography.X509Certificates;

internal enum OidGroup
{
	AllGroups = 0,
	HashAlgorithm = 1,
	EncryptionAlgorithm = 2,
	PublicKeyAlgorithm = 3,
	SignatureAlgorithm = 4,
	Attribute = 5,
	ExtensionOrAttribute = 6,
	EnhancedKeyUsage = 7,
	Policy = 8,
	Template = 9,
	KeyDerivationFunction = 10,
	DisableSearchDS = int.MinValue
}
