using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EPDGBakePackageReplaceModeOption", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EPDGBakePackageReplaceModeOption
{
	CreateNewAssets,
	ReplaceExistingAssets
}
