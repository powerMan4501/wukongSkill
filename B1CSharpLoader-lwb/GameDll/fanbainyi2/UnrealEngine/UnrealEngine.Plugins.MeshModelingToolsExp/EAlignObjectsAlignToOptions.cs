using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EAlignObjectsAlignToOptions", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EAlignObjectsAlignToOptions
{
	FirstSelected,
	LastSelected,
	Combined
}
