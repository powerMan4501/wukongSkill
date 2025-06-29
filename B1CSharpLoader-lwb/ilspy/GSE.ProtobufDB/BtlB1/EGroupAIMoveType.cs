using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.GroupAIMoveType")]
public enum EGroupAIMoveType : byte
{
	UseDefault,
	RunWithKeepFacingTarget,
	SprintWithNone,
	SprintWithKeepFacingTarget
}
