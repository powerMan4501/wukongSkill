using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECustomTimeStepSynchronizationState", "Engine", UnrealModuleType.Engine)]
public enum ECustomTimeStepSynchronizationState
{
	Closed,
	Error,
	Synchronized,
	Synchronizing
}
