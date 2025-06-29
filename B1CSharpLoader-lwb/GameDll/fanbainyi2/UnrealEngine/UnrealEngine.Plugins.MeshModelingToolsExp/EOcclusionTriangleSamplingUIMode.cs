using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EOcclusionTriangleSamplingUIMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EOcclusionTriangleSamplingUIMode
{
	Vertices,
	VerticesAndCentroids
}
