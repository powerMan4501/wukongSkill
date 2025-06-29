using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MapSymbolActiveState")]
public enum EMapSymbolActiveState : byte
{
	Normal,
	Disable,
	VisableNotHit
}
