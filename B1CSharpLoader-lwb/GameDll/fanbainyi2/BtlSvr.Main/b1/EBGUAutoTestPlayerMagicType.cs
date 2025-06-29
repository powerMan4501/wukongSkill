using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUAutoTestPlayerMagicType")]
public enum EBGUAutoTestPlayerMagicType : byte
{
	None,
	[DisplayName("身法")]
	ShenFa,
	[DisplayName("毫毛")]
	HaoMao,
	[DisplayName("奇术 ")]
	QiShu,
	[DisplayName("变身 ")]
	BianShen
}
