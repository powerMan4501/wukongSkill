using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestScoreOperator", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestScoreOperator
{
	AverageScore,
	MinScore,
	MaxScore,
	Multiply
}
