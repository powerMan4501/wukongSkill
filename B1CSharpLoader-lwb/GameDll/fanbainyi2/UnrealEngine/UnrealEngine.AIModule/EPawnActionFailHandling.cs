using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnActionFailHandling", "AIModule", UnrealModuleType.Engine)]
public enum EPawnActionFailHandling
{
	RequireSuccess,
	IgnoreFailure
}
