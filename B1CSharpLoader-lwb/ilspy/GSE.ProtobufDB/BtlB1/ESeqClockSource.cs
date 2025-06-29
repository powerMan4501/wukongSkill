using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SeqClockSource")]
public enum ESeqClockSource : byte
{
	Tick,
	Platform
}
