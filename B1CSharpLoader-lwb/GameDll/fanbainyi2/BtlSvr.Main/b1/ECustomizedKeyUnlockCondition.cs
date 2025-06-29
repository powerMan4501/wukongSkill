using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CustomizedKeyUnlockCondition")]
public enum ECustomizedKeyUnlockCondition : byte
{
	[DisplayName("永远显示名字")]
	AlwaysShow,
	[DisplayName("法宝")]
	MagicArtifact,
	[DisplayName("精魄")]
	VigorSkill,
	[DisplayName("筋斗云")]
	Cloud,
	[DisplayName("撑棍")]
	PropStance,
	[DisplayName("戳棍")]
	PokeStance
}
