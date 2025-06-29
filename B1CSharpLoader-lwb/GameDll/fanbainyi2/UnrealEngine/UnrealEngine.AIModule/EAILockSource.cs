using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EAILockSource", "AIModule", UnrealModuleType.Engine)]
public enum EAILockSource
{
	Animation,
	Logic,
	Script,
	Gameplay
}
