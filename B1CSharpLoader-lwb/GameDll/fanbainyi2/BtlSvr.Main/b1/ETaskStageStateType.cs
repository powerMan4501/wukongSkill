using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.TaskStageStateType")]
public enum ETaskStageStateType : byte
{
	[DisplayName("未激活")]
	NoActive,
	[DisplayName("已激活，未完成")]
	Actived,
	[DisplayName("已完成")]
	Finsh
}
