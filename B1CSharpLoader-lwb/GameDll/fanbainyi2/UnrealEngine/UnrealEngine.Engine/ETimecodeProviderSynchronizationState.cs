using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETimecodeProviderSynchronizationState", "Engine", UnrealModuleType.Engine)]
public enum ETimecodeProviderSynchronizationState
{
	Closed,
	Error,
	Synchronized,
	Synchronizing
}
