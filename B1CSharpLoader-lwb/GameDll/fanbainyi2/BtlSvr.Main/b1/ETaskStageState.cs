using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TaskStageState")]
public enum ETaskStageState : byte
{
	Default,
	Activated,
	Finished
}
