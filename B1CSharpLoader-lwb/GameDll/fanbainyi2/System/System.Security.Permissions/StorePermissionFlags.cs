namespace System.Security.Permissions;

[Serializable]
[Flags]
public enum StorePermissionFlags
{
	NoFlags = 0,
	CreateStore = 1,
	DeleteStore = 2,
	EnumerateStores = 4,
	OpenStore = 0x10,
	AddToStore = 0x20,
	RemoveFromStore = 0x40,
	EnumerateCertificates = 0x80,
	AllFlags = 0xF7
}
