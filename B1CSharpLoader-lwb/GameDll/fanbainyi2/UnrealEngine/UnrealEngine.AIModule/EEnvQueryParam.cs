using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvQueryParam", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryParam
{
	Float,
	Int,
	Bool
}
