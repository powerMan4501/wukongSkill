using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EAISenseNotifyType", "AIModule", UnrealModuleType.Engine)]
public enum EAISenseNotifyType
{
	OnEveryPerception,
	OnPerceptionChange
}
