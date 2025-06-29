using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/UnrealExtent.EGSQualityLevel", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSQualityLevel
{
	INVALID,
	LOW,
	MEDIUM,
	HIGH,
	EPIC,
	CINE
}
