using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.PlayType")]
public enum EPlayType : byte
{
	None,
	Once,
	Loop
}
