using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EBlueprintBreakpointReloadMethod", "UnrealEd", UnrealModuleType.Engine)]
public enum EBlueprintBreakpointReloadMethod
{
	RestoreAll,
	RestoreAllAndDisable,
	DiscardAll
}
