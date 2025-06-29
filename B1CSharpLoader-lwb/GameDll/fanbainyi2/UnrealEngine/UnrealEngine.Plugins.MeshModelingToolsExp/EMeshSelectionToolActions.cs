using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshSelectionToolActions", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshSelectionToolActions
{
	NoAction,
	SelectAll,
	ClearSelection,
	InvertSelection,
	GrowSelection,
	ShrinkSelection,
	ExpandToConnected,
	SelectLargestComponentByTriCount,
	SelectLargestComponentByArea,
	OptimizeSelection,
	DeleteSelected,
	DisconnectSelected,
	SeparateSelected,
	DuplicateSelected,
	FlipSelected,
	CreateGroup,
	CycleSelectionMode,
	CycleViewMode
}
