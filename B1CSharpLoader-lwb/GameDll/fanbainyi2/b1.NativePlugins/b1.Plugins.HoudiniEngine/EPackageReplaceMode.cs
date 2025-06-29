using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EPackageReplaceMode", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EPackageReplaceMode
{
	CreateNewAssets,
	ReplaceExistingAssets
}
