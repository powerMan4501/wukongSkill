using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnSubActionTriggeringPolicy", "AIModule", UnrealModuleType.Engine)]
public enum EPawnSubActionTriggeringPolicy
{
	CopyBeforeTriggering,
	ReuseInstances
}
