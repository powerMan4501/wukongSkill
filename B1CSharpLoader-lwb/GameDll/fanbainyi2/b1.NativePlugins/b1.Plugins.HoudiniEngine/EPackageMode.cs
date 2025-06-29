using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EPackageMode", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EPackageMode
{
	CookToLevel_Invalid,
	CookToTemp,
	Bake
}
