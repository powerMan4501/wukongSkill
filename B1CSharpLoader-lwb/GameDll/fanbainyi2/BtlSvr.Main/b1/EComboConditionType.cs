using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ComboConditionType")]
public enum EComboConditionType : byte
{
	[UMeta(MD.Hidden)]
	None = 0,
	[DisplayName("单位属性值")]
	UnitAttr = 1,
	[DisplayName("SimpleState")]
	SimpleState = 2,
	[DisplayName("UnitState")]
	UnitState = 3,
	[DisplayName("Has Buff")]
	HasBuff = 4,
	[DisplayName("棍势等级")]
	PotentialEnergy = 5,
	[DisplayName("蓄力等级")]
	Charge = 6,
	[DisplayName("天花板高度")]
	CeilingHeight = 7,
	[DisplayName("Has Talent")]
	HasTalent = 8,
	[DisplayName("武器架势")]
	StanceType = 9,
	[DisplayName("IsFalling")]
	IsFalling = 11,
	[DisplayName("在跳跃上升阶段")]
	InJumpUpper = 12,
	[DisplayName("不在跨上状态")]
	NotInStrideUpJump = 13,
	[DisplayName("空中技能计数")]
	AirSkillCount = 14,
	[DisplayName("离地高度")]
	FlooDistance = 15,
	[DisplayName("MoveMode")]
	MoveMode = 16,
	[DisplayName("有移动输入")]
	HasMoveInput = 17,
	[DisplayName("在小猴子阶段")]
	InLittleMonkeyStage = 18,
	[DisplayName("在预备大圣阶段")]
	InPreDaShengStage = 19,
	[DisplayName("在大圣阶段")]
	InDaShengStage = 20,
	[DisplayName("在按下转棍状态")]
	InPressedSpinModeState = 21,
	[UMeta(MD.Hidden)]
	EnumMax = 22
}
