namespace STUN.Enums;

public enum AttributeType : ushort
{
	Useless = 0,
	MappedAddress = 1,
	ResponseAddress = 2,
	ChangeRequest = 3,
	SourceAddress = 4,
	ChangedAddress = 5,
	Username = 6,
	Password = 7,
	MessageIntegrity = 8,
	ErrorCode = 9,
	UnknownAttribute = 10,
	ReflectedFrom = 11,
	Realm = 20,
	Nonce = 21,
	MessageIntegritySha256 = 28,
	PasswordAlgorithm = 29,
	UserHash = 30,
	XorMappedAddress = 32,
	Padding = 38,
	ResponsePort = 39,
	PasswordAlgorithms = 32770,
	AlternateDomain = 32771,
	Software = 32802,
	AlternateServer = 32803,
	CacheTimeout = 32807,
	Fingerprint = 32808,
	ResponseOrigin = 32811,
	OtherAddress = 32812
}
