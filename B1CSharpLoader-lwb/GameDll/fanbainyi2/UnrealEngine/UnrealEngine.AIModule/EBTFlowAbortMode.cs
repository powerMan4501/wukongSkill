using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EBTFlowAbortMode", "AIModule", UnrealModuleType.Engine)]
public enum EBTFlowAbortMode
{
	None,
	LowerPriority,
	Self,
	Both
}
