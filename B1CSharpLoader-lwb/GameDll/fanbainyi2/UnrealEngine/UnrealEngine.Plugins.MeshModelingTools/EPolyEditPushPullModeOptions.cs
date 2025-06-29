using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EPolyEditPushPullModeOptions", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EPolyEditPushPullModeOptions
{
	SelectedTriangleNormals = 0,
	SelectedTriangleNormalsEven = 1,
	SingleDirection = 3,
	VertexNormals = 2
}
