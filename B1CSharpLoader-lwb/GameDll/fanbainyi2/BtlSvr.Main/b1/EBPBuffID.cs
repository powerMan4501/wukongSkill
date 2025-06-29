using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBPBuffID")]
public enum EBPBuffID : byte
{
	NoneBuff = 0,
	SmallStunBuff = 200,
	BigStunBuff = 201,
	SkillCastingBuff = 202,
	ShieldDefenceBuff = 203,
	SpawnDoingBuff = 206,
	TianjiangEnterAIStage2 = 208,
	FightBackBuff = 209,
	ImmueStiffBuff = 210,
	SuperImmueStiffBuff = 211,
	InvincibleBuff = 212,
	ImmueDamage = 213,
	DemoChangeCharacter = 216,
	DemoFTXDInvincibleBuff = 218,
	DemoTianJiangInterQTEBuff = 219,
	EnumMax = byte.MaxValue
}
