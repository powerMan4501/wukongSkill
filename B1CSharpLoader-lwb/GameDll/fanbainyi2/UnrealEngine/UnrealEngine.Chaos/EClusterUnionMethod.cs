using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EClusterUnionMethod", "Chaos", UnrealModuleType.Engine)]
public enum EClusterUnionMethod
{
	PointImplicit,
	DelaunayTriangulation,
	MinimalSpanningSubsetDelaunayTriangulation,
	PointImplicitAugmentedWithMinimalDelaunay,
	None
}
