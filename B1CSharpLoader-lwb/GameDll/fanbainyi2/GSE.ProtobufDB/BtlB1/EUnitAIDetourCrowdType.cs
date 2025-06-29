using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitAIDetourCrowdType")]
public enum EUnitAIDetourCrowdType : byte
{
	None = 0,
	Low100Detect = 1,
	Low500Detect = 2,
	Low = 3,
	Medium = 4,
	MediumDetectLightAvoidence = 5,
	FarDetect = 6,
	FarDetectLightAvoidence = 7,
	MediumDectectHeavyAvoidence = 8,
	MediumHighQuality = 9,
	EnumMax = byte.MaxValue
}
