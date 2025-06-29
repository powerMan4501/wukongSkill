using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGWLoginStatus", "b1", UnrealModuleType.Game)]
public enum EBGWLoginStatus : byte
{
	NotLoggedIn,
	UsingLocalProfile,
	LoggedIn
}
