using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MoveSpeedType")]
public enum EMoveSpeedType : byte
{
	Walk,
	Run,
	Sprint
}
