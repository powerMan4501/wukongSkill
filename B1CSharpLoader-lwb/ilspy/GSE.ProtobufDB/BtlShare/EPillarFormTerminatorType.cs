using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.PillarFormTerminatorType")]
public enum EPillarFormTerminatorType : byte
{
	None,
	ClearStamina,
	BreakPillarForm
}
