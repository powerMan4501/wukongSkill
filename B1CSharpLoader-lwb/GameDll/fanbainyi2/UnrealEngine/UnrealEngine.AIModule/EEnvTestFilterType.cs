using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestFilterType", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestFilterType
{
	Minimum,
	Maximum,
	Range,
	Match
}
