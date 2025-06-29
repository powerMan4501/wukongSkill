using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.ETextKeyOperation", "AIModule", UnrealModuleType.Engine)]
public enum ETextKeyOperation
{
	Equal,
	NotEqual,
	Contain,
	NotContain
}
