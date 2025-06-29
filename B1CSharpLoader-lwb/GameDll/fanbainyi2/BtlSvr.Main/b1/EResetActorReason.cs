using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ResetActorReason")]
public enum EResetActorReason : byte
{
	None,
	Rebirth,
	InteractRebirthPoint,
	NewSpawn,
	LevelStreaming,
	MaxHeightOffset,
	ReturnHome,
	GameLevelPass
}
