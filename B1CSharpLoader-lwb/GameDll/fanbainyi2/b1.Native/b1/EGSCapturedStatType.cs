using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSCapturedStatType", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSCapturedStatType : byte
{
	NONE,
	CYCLE,
	MEMORY,
	NUM
}
