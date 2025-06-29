using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EMovementMode", "Engine", UnrealModuleType.Engine)]
public enum EMovementMode : byte
{
	MOVE_None,
	MOVE_Walking,
	MOVE_NavWalking,
	MOVE_Falling,
	MOVE_Swimming,
	MOVE_Flying,
	MOVE_Custom
}
