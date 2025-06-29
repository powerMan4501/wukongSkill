using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvQueryRunMode", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryRunMode
{
	SingleResult,
	RandomBest5Pct,
	RandomBest25Pct,
	AllMatching
}
