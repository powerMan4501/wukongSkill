using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWPrivilegeResult", "b1", UnrealModuleType.Game)]
public enum EBGWPrivilegeResult : byte
{
	Unknown,
	Available,
	UserNotLoggedIn,
	LicenseInvalid,
	VersionOutdated,
	NetworkConnectionUnavailable,
	AgeRestricted,
	AccountTypeRestricted,
	AccountUseRestricted,
	PlatformFailure
}
