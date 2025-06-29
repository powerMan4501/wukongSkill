using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EGSForceFightUnitType")]
public enum EGSForceFightUnitType : byte
{
	[Tooltip("无")]
	[DisplayName("无")]
	None,
	[DisplayName("玩家")]
	[Tooltip("玩家")]
	Player,
	[Tooltip("玩家阵营单位")]
	[DisplayName("玩家阵营")]
	PlayerTeam
}
