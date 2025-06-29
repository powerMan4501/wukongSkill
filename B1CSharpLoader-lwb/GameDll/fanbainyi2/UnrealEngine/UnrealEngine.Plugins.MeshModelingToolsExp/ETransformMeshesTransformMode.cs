using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ETransformMeshesTransformMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ETransformMeshesTransformMode
{
	SharedGizmo,
	SharedGizmoLocal,
	PerObjectGizmo,
	LastValue
}
