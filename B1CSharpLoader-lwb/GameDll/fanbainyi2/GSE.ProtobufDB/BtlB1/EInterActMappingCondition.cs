using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.InterActMappingCondition")]
public enum EInterActMappingCondition : byte
{
	Default,
	TaskGroup,
	Loop,
	DistanceToMachingPoint,
	FunctionEnable,
	MatchHeight,
	HasItem,
	SeedSubmitted,
	EnumMax
}
