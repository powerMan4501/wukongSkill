using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvTestScoreEquation", "AIModule", UnrealModuleType.Engine)]
public enum EEnvTestScoreEquation
{
	Linear,
	Square,
	InverseLinear,
	SquareRoot,
	Constant
}
