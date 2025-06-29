using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestPurpose", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestPurpose
{
	Filter,
	Score,
	FilterAndScore
}
