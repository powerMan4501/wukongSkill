using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EAIBasicActionType")]
public enum EAIBasicActionType : byte
{
	DirectionMove,
	DirectionDamage,
	RootMotionMove,
	TraceMove,
	MoveSkill
}
