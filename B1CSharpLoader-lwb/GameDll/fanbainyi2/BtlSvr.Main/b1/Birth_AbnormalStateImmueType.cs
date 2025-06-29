using UnrealEngine.Runtime;

namespace b1;

[DisplayName("出生免疫类型")]
[UEnum]
[USharpPath("/Script/b1-Managed.Birth_AbnormalStateImmueType")]
public enum Birth_AbnormalStateImmueType : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("冰冻免疫")]
	FreezeImmue,
	[DisplayName("灼烧免疫")]
	BurnImmue,
	[DisplayName("中毒免疫")]
	PoisonImmue,
	[DisplayName("雷易伤免疫")]
	ThunderImmue
}
