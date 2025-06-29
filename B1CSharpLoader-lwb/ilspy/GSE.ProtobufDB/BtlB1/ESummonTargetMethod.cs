using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SummonTargetMethod")]
public enum ESummonTargetMethod : byte
{
	SyncFromMaster,
	AcquireFromPerception
}
