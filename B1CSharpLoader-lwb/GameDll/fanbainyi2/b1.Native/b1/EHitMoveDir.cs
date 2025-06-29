using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EHitMoveDir", "b1", UnrealModuleType.Game)]
public enum EHitMoveDir : byte
{
	Default,
	XAxisHitMove,
	YAxisHitMove
}
