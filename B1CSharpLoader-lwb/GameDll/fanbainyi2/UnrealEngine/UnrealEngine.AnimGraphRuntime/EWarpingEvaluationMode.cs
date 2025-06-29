using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EWarpingEvaluationMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EWarpingEvaluationMode : byte
{
	Manual,
	Graph
}
