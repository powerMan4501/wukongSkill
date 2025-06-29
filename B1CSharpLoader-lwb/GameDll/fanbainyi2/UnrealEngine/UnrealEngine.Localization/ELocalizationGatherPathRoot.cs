using UnrealEngine.Runtime;

namespace UnrealEngine.Localization;

[UEnum]
[UMetaPath("/Script/Localization.ELocalizationGatherPathRoot", "Localization", UnrealModuleType.Engine)]
public enum ELocalizationGatherPathRoot
{
	Auto,
	Engine,
	Project
}
