using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MapSymbolState")]
public enum EMapSymbolState : byte
{
	Hidden,
	Incompelte,
	Compelte,
	Unexplored
}
