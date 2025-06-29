using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EEditPivotToolActions", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EEditPivotToolActions
{
	NoAction,
	Center,
	Bottom,
	Top,
	Left,
	Right,
	Front,
	Back,
	WorldOrigin
}
