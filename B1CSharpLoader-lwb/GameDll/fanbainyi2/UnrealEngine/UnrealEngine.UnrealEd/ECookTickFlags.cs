using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ECookTickFlags", "UnrealEd", UnrealModuleType.Engine)]
public enum ECookTickFlags
{
	None,
	MarkupInUsePackages,
	HideProgressDisplay
}
