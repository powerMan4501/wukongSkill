using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitWeightGearType")]
public enum EHitWeightGearType : byte
{
	LowHitWeight,
	MediueHitWeight,
	HeightHitWeight,
	HugeHitWeight,
	MustDefeatHitWeight
}
