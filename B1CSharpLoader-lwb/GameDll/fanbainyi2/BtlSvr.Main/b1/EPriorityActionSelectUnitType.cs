using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PriorityActionSelectUnitType")]
public enum EPriorityActionSelectUnitType : byte
{
	[DisplayName("全部处于游走状态")]
	AllInWandering,
	[Tooltip("算分方式：距离分 + 屏幕内筛选（分界线，同样距离下，屏幕内单位更优先）；离玩家距离1cm = 1分")]
	[DisplayName("离玩家远且在屏幕内（排序）")]
	FarFromPlayerAndInScreenSort
}
