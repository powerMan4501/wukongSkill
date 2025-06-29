using UnrealEngine.Runtime;

namespace UnrealEngine.Localization;

[UEnum]
[UMetaPath("/Script/Localization.ELocalizationTargetLoadingPolicy", "Localization", UnrealModuleType.Engine)]
public enum ELocalizationTargetLoadingPolicy
{
	Never,
	Always,
	Editor,
	Game,
	PropertyNames,
	ToolTips
}
