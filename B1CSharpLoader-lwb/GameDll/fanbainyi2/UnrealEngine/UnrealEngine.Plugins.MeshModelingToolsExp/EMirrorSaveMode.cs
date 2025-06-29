using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMirrorSaveMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMirrorSaveMode
{
	UpdateAssets,
	CreateNewAssets
}
