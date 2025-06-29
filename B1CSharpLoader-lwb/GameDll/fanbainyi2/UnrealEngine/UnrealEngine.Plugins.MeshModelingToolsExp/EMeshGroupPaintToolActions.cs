using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshGroupPaintToolActions", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshGroupPaintToolActions
{
	NoAction,
	ClearFrozen,
	FreezeCurrent,
	FreezeOthers,
	GrowCurrent,
	ShrinkCurrent,
	ClearCurrent,
	FloodFillCurrent,
	ClearAll
}
