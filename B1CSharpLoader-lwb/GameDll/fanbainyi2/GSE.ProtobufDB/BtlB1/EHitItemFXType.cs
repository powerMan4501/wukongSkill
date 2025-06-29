using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitItemFXType")]
public enum EHitItemFXType : byte
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
