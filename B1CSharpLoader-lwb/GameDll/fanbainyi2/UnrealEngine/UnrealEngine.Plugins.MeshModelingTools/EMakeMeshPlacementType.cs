using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EMakeMeshPlacementType", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EMakeMeshPlacementType
{
	GroundPlane,
	OnScene
}
