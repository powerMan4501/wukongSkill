using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EAIRequestPriority", "AIModule", UnrealModuleType.Engine)]
public enum EAIRequestPriority
{
	SoftScript,
	Logic,
	HardScript,
	Reaction,
	Ultimate
}
