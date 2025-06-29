using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GameplayCounterType")]
public enum EGameplayCounterType : byte
{
	None,
	[UMeta(MD.DisplayName, "时间计数")]
	[UMeta(MD.ToolTip, "结束时间 - 开始时间")]
	Time,
	[UMeta(MD.DisplayName, "血量差值")]
	[UMeta(MD.ToolTip, "结束血量 - 开始血量")]
	HP,
	[UMeta(MD.ToolTip, "结束血量百分比 - 开始血量百分比")]
	[UMeta(MD.DisplayName, "血量差值百分比")]
	HPPercent
}
