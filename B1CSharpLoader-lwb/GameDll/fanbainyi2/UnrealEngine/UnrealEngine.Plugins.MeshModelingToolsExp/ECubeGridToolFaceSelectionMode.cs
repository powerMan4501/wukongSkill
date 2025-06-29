using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ECubeGridToolFaceSelectionMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ECubeGridToolFaceSelectionMode
{
	OutsideBasedOnNormal,
	InsideBasedOnNormal,
	OutsideBasedOnViewRay,
	InsideBasedOnViewRay
}
