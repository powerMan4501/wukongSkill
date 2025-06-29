using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUInteractUnitState")]
public enum EBGUInteractUnitState : byte
{
	Default,
	BeforeInactive,
	BeforeActive,
	AfterInactive
}
