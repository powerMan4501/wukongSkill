using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EPolyEditOffsetModeOptions", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EPolyEditOffsetModeOptions
{
	VertexNormals = 2,
	SelectedTriangleNormals = 0,
	SelectedTriangleNormalsEven = 1
}
