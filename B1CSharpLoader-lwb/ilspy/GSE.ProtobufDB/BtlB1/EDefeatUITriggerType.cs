using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.DefeatUITriggerType")]
public enum EDefeatUITriggerType : byte
{
	None,
	Dead,
	Seq,
	Cpg,
	BossRush
}
