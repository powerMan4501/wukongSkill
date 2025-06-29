using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EVoronoiPattern", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EVoronoiPattern
{
	Centered,
	Uniform,
	Grid,
	MeshVertices,
	SelectedBones
}
