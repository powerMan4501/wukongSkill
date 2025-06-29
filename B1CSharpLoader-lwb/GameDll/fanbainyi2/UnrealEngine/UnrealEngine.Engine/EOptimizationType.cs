using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EOptimizationType", "Engine", UnrealModuleType.Engine)]
public enum EOptimizationType
{
	OT_NumOfTriangles,
	OT_MaxDeviation
}
