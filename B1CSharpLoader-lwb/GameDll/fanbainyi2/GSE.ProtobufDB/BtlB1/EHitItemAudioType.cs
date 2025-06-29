using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitItemAudioType")]
public enum EHitItemAudioType : byte
{
	NormalBody,
	Metal,
	Wooden,
	Stone,
	Bone,
	MetalShield,
	WoodenShield,
	Frozen,
	SoftWooden,
	SoftInsect,
	HardInsect,
	EnumMax
}
