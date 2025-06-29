using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TaskStageConditionType")]
public enum ETaskStageConditionType : byte
{
	[DisplayName("已激活，未完成")]
	Actived,
	[DisplayName("已完成")]
	Finsh
}
