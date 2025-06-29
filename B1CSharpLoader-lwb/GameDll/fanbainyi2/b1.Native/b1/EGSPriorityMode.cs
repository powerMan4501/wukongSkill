using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSPriorityMode", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSPriorityMode : byte
{
	QUALITY_PRIOR,
	PERF_PRIOR
}
