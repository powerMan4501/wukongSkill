using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlueprintStatus", "Engine", UnrealModuleType.Engine)]
public enum EBlueprintStatus
{
	BS_Unknown,
	BS_Dirty,
	BS_Error,
	BS_UpToDate,
	BS_BeingCreated,
	BS_UpToDateWithWarnings
}
