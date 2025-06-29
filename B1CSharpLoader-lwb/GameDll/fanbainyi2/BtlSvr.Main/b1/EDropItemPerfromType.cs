using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.DropItemPerfromType")]
public enum EDropItemPerfromType : byte
{
	[DisplayName("直接飞向玩家")]
	WithOutPick,
	[DisplayName("标准掉落(微缩模型)")]
	Standard,
	[DisplayName("赤潮那式样儿的")]
	WithDropAnim,
	[DisplayName("固定点")]
	FixedPoint
}
