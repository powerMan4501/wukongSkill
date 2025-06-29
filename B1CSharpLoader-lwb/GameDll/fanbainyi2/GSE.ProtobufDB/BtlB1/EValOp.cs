using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ValOp")]
public enum EValOp : byte
{
	Add,
	Mul,
	OverrideBase
}
