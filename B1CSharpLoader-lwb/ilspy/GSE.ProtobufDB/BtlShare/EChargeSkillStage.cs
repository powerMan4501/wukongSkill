using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ChargeSkillStage")]
public enum EChargeSkillStage : byte
{
	None = 0,
	Begin = 1,
	Loop = 2,
	End = 3,
	EnumMax = byte.MaxValue
}
