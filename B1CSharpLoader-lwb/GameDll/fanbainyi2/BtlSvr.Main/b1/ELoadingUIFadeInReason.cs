using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.LoadingUIFadeInReason")]
public enum ELoadingUIFadeInReason : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("战斗内传送")]
	CombatTeleport,
	[DisplayName("非战斗内传送")]
	NonCombatTeleport,
	[DisplayName("联机掉线回到默认地图")]
	OnlineDisconnect
}
