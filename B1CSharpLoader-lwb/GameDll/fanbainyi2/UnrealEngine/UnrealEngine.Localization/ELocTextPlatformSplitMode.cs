using UnrealEngine.Runtime;

namespace UnrealEngine.Localization;

[UEnum]
[UMetaPath("/Script/Localization.ELocTextPlatformSplitMode", "Localization", UnrealModuleType.Engine)]
public enum ELocTextPlatformSplitMode
{
	None,
	Confidential,
	All
}
