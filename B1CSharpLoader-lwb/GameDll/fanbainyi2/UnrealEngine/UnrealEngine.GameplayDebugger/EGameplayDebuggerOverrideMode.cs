using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayDebugger;

[UEnum]
[UMetaPath("/Script/GameplayDebugger.EGameplayDebuggerOverrideMode", "GameplayDebugger", UnrealModuleType.Engine)]
public enum EGameplayDebuggerOverrideMode
{
	Enable,
	Disable,
	UseDefault
}
