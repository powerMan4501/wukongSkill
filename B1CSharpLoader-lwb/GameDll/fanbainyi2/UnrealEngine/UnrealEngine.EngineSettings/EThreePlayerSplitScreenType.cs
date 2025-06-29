using UnrealEngine.Runtime;

namespace UnrealEngine.EngineSettings;

[UEnum]
[UMetaPath("/Script/EngineSettings.EThreePlayerSplitScreenType", "EngineSettings", UnrealModuleType.Engine)]
public enum EThreePlayerSplitScreenType
{
	FavorTop,
	FavorBottom,
	Vertical,
	Horizontal
}
