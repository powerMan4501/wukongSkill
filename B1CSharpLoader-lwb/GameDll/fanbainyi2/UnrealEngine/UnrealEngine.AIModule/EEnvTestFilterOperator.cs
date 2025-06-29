using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestFilterOperator", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestFilterOperator
{
	AllPass,
	AnyPass
}
