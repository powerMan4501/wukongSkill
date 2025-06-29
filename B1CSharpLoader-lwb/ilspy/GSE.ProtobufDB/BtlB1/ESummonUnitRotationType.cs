using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SummonUnitRotationType")]
public enum ESummonUnitRotationType : byte
{
	None,
	FacingCurTarget,
	UseEffectCasterRot,
	UseManualSpawnPoint,
	UseSpawnPointRot,
	FacingLocalPlayer
}
