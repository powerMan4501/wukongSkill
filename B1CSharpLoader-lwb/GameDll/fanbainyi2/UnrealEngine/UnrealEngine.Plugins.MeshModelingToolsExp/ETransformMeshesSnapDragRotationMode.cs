using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ETransformMeshesSnapDragRotationMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ETransformMeshesSnapDragRotationMode
{
	Ignore,
	Align,
	AlignFlipped,
	LastValue
}
