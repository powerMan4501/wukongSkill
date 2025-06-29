using UnrealEngine.Runtime;

namespace UnrealEngine.Localization;

[UEnum]
[UMetaPath("/Script/Localization.ELocalizationTargetConflictStatus", "Localization", UnrealModuleType.Engine)]
public enum ELocalizationTargetConflictStatus
{
	Unknown,
	ConflictsPresent,
	Clear
}
