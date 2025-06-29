using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsEditorOnlyExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsEditorOnlyExp.EVoxelCSGOperation", "MeshModelingToolsEditorOnlyExp", UnrealModuleType.EnginePlugin)]
public enum EVoxelCSGOperation
{
	DifferenceAB,
	DifferenceBA,
	Intersect,
	Union
}
