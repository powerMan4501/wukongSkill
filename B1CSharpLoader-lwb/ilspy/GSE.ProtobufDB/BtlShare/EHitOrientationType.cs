using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.HitOrientationType")]
public enum EHitOrientationType : byte
{
	None,
	TowardAttacker,
	TowardAttackDirection,
	BackToAttacker,
	BackToAttackDirection,
	BackToCaster,
	TowardCaster,
	LaserType,
	SameWithAttacker
}
