using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.MapSymbolType")]
public enum EMapSymbolType : byte
{
	Min,
	Stupa,
	GodTower,
	CaveEntrance,
	Challenge,
	StrongHold,
	Npc,
	MirageWorld,
	RebirthPoint
}
