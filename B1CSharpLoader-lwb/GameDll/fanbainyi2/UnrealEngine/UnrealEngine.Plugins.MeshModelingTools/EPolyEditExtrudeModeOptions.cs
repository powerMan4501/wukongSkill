using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EPolyEditExtrudeModeOptions", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EPolyEditExtrudeModeOptions
{
	SingleDirection = 3,
	SelectedTriangleNormals = 0,
	SelectedTriangleNormalsEven = 1
}
