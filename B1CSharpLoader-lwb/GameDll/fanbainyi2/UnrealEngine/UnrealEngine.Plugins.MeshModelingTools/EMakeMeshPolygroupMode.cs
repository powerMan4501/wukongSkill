using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EMakeMeshPolygroupMode", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EMakeMeshPolygroupMode
{
	PerShape,
	PerFace,
	PerQuad
}
