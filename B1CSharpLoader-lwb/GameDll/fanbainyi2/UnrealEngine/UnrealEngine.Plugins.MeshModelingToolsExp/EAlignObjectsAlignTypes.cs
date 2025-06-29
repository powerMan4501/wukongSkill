using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EAlignObjectsAlignTypes", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EAlignObjectsAlignTypes
{
	Pivots,
	BoundingBoxes
}
