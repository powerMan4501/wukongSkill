using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.TaskStageState")]
public enum ETaskStageState : byte
{
	Default,
	Activated,
	Finished
}
