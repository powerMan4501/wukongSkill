using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ActionTagType")]
public enum EActionTagType : byte
{
	NormalMove,
	Damage,
	NormalSkillCast,
	RootMotion,
	DontUpdate,
	MovingSkill,
	KeepFacing,
	Aoe,
	SingleSkill,
	MeleeSkill,
	RangedSkill,
	NormalAttack,
	Skill,
	Control,
	Heal,
	Own,
	Other,
	RotationLock
}
