using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EVoxelBlendOperation", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EVoxelBlendOperation
{
	Union,
	Subtract
}
