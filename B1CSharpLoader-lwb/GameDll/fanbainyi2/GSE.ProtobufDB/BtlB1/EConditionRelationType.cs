using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ConditionRelationType")]
public enum EConditionRelationType : byte
{
	LogicRelationAnd,
	LogicRelationOr
}
