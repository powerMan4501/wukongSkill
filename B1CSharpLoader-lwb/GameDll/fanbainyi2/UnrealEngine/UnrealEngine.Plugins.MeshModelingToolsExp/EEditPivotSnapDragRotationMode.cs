using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EEditPivotSnapDragRotationMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EEditPivotSnapDragRotationMode
{
	Ignore,
	Align,
	AlignFlipped,
	LastValue
}
