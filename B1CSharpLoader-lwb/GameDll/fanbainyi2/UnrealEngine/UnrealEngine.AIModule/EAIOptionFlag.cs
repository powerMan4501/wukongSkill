using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EAIOptionFlag", "AIModule", UnrealModuleType.Engine)]
public enum EAIOptionFlag
{
	Default,
	Enable,
	Disable
}
