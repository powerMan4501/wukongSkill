using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EBspConversionToolAction", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EBspConversionToolAction
{
	NoAction,
	SelectAllValidBrushes,
	DeselectVolumes,
	DeselectNonValid
}
