using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PlayerTransBeginType")]
public enum EPlayerTransBeginType : byte
{
	None,
	[DisplayName("释放变身法术")]
	CastSpell,
	[DisplayName("Buff")]
	AddBuff,
	[DisplayName("土地庙变蝉")]
	BianChan,
	[DisplayName("释放坐骑法术")]
	Ride,
	[DisplayName("读档恢复变身")]
	ReadArchive,
	[DisplayName("技能效果触发（可能是其他变身原因的后置效果）")]
	SkillEffect,
	[DisplayName("剧情进入变身")]
	Plot,
	[DisplayName("特殊土地庙传送后变身")]
	RebirthPoint,
	[DisplayName("CMG触发变身")]
	Sequence
}
