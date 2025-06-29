using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EUserDefinedStructureStatus", "Engine", UnrealModuleType.Engine)]
public enum EUserDefinedStructureStatus
{
	UDSS_UpToDate,
	UDSS_Dirty,
	UDSS_Error,
	UDSS_Duplicate
}
