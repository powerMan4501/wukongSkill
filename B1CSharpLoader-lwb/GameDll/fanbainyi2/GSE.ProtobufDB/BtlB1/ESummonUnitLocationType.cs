using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SummonUnitLocationType")]
public enum ESummonUnitLocationType : byte
{
	UsePointSetCached,
	UseManualSpawnPoint,
	UseEqsdata,
	UseEffectCasterPos,
	UseCasterPos,
	UseEffectPos,
	UseSceneItemPos
}
