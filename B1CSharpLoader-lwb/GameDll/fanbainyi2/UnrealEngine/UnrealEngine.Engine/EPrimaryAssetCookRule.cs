using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPrimaryAssetCookRule", "Engine", UnrealModuleType.Engine)]
public enum EPrimaryAssetCookRule
{
	Unknown,
	NeverCook,
	DevelopmentCook,
	DevelopmentAlwaysCook,
	AlwaysCook
}
