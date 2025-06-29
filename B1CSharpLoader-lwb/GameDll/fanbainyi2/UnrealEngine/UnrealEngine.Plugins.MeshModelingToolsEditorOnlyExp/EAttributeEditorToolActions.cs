using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EAttributeEditorToolActions", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EAttributeEditorToolActions
{
	NoAction,
	ClearNormals,
	ClearAllUVs,
	ClearSelectedUVs,
	AddUVSet,
	DeleteSelectedUVSet,
	DuplicateSelectedUVSet,
	AddAttribute,
	AddWeightMapLayer,
	AddPolyGroupLayer,
	DeleteAttribute,
	ClearAttribute,
	CopyAttributeFromTo,
	EnableLightmapUVs,
	DisableLightmapUVs,
	ResetLightmapUVChannels
}
