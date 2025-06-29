using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ETransformMeshesSnapDragSource", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ETransformMeshesSnapDragSource
{
	ClickPoint,
	Pivot,
	LastValue
}
