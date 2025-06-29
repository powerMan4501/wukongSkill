using UnrealEngine.Runtime;

namespace UnrealEngine.EngineSettings;

[UEnum]
[UMetaPath("/Script/EngineSettings.EFourPlayerSplitScreenType", "EngineSettings", UnrealModuleType.Engine)]
public enum EFourPlayerSplitScreenType
{
	Grid,
	Vertical,
	Horizontal
}
