using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PlayerTransEndType")]
public enum EPlayerTransEndType : byte
{
	None,
	[DisplayName("法术退出变身")]
	CastSpell,
	[DisplayName("主动退出坐骑")]
	ManualEndRide,
	[DisplayName("被打回原形")]
	BeatBack,
	[DisplayName("能量耗尽变回原形")]
	EnergyEmpty,
	[DisplayName("复活时清除变身状态")]
	RebirthTransBack,
	[DisplayName("姿态回归(不播退出动画)")]
	CPGTransBack,
	[DisplayName("血量归零")]
	HpTransBack,
	[DisplayName("禁止变身简单状态")]
	Simplestate,
	[DisplayName("进入禁止坐骑区域")]
	CantRide,
	[DisplayName("简单状态禁止变身")]
	CantTrans,
	[DisplayName("Buff退出变身")]
	Buff,
	[DisplayName("触发盒子禁止变身")]
	TriggerBoxForceTransBack,
	[DisplayName("技能效果触发(可能是其他退出变身原因的后置效果)")]
	SkillEffect,
	[DisplayName("姿态回归(需要播退出动画)")]
	CMGTransBack,
	[DisplayName("设置退出变身")]
	SettingransBack,
	[DisplayName("剧情退出变身")]
	Plot
}
