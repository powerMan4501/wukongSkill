using UnrealEngine.Runtime;

namespace UnrealEngine.ChaosSolverEngine;

[UEnum]
[UMetaPath("/Script/ChaosSolverEngine.EClusterConnectionTypeEnum", "ChaosSolverEngine", UnrealModuleType.Engine)]
public enum EClusterConnectionTypeEnum
{
	Chaos_PointImplicit,
	Chaos_DelaunayTriangulation,
	Chaos_MinimalSpanningSubsetDelaunayTriangulation,
	Chaos_PointImplicitAugmentedWithMinimalDelaunay,
	Chaos_None,
	Chaos_EClsuterCreationParameters_Max
}
