using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.RoleDataType")]
public enum ERoleDataType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("消耗物品")]
	ConsumedItem,
	[DisplayName("拥有物品")]
	OwningItem,
	[DisplayName("交互记录")]
	InteractionRecord,
	[DisplayName("任务阶段")]
	TaskStage,
	[DisplayName("拥有葫芦")]
	OwningHulu,
	[DisplayName("解锁全图鉴")]
	Collection
}
