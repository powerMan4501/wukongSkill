using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UEnum]
[UMetaPath("/Script/GameplayTasks.EGameplayTaskRunResult", "GameplayTasks", UnrealModuleType.Engine)]
public enum EGameplayTaskRunResult
{
	Error,
	Failed,
	Success_Paused,
	Success_Active,
	Success_Finished
}
