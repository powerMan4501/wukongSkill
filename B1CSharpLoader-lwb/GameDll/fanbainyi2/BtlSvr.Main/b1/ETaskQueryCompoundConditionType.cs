using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.TaskQueryCompoundConditionType")]
public enum ETaskQueryCompoundConditionType : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("查询任务阶段状态")]
	QueryTaskStageState,
	[DisplayName("查询交互记录")]
	QueryInteractionRecord,
	[DisplayName("查询单位状态")]
	QueryActorState,
	[DisplayName("查询拥有物品")]
	QueryOwningItem
}
