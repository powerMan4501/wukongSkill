namespace System.Security;

[Serializable]
internal enum PermissionType
{
	SecurityUnmngdCodeAccess = 0,
	SecuritySkipVerification = 1,
	ReflectionTypeInfo = 2,
	SecurityAssert = 3,
	ReflectionMemberAccess = 4,
	SecuritySerialization = 5,
	ReflectionRestrictedMemberAccess = 6,
	FullTrust = 7,
	SecurityBindingRedirects = 8,
	UIPermission = 9,
	EnvironmentPermission = 10,
	FileDialogPermission = 11,
	FileIOPermission = 12,
	ReflectionPermission = 13,
	SecurityPermission = 14,
	SecurityControlEvidence = 16,
	SecurityControlPrincipal = 17
}
