using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMirrorOperationMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMirrorOperationMode
{
	MirrorAndAppend,
	MirrorExisting
}
