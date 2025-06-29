using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUDeadLogicType")]
public enum EBGUDeadLogicType : byte
{
	None,
	Normal,
	FlyByPhysical,
	AI,
	Sequence
}
