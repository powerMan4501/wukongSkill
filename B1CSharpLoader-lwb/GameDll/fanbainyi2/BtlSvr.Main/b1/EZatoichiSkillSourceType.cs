using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ZatoichiSkillSourceType")]
public enum EZatoichiSkillSourceType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("使用面板填写技能")]
	UseWithSkillCategory,
	[DisplayName("用作群体AI")]
	[Tooltip("选取后，释放技能由外部提供")]
	UseWithGroupAI,
	[DisplayName("用作见面礼")]
	[Tooltip("选取后，释放技能由外部提供")]
	UseWithSurpriseSkilll,
	[DisplayName("用作技能脱困")]
	UseWithAvoidObstacle,
	[DisplayName("用作僵持技能")]
	[Tooltip("选取后，释放技能由外部提供")]
	UseWithStalemateSkill
}
