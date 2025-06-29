using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.DeadReason")]
public enum EDeadReason : byte
{
	None = 0,
	SummonDead = 1,
	SkillDamage = 2,
	OnlyDestroyUnit = 3,
	Fracture = 4,
	FlyHit = 5,
	Cut = 6,
	DeadZone = 7,
	Suicide = 8,
	FrozenFracture = 9,
	PlayerTrans = 10,
	FallDead = 11,
	EnumMax = byte.MaxValue
}
