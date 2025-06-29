using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProcessUsage")]
public enum EProcessUsage : byte
{
	None,
	Custom,
	LevelTemplate,
	Npc
}
