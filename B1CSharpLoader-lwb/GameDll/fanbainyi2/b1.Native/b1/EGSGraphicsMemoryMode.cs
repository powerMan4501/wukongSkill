using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EGSGraphicsMemoryMode", "UnrealExtent", UnrealModuleType.Game)]
public enum EGSGraphicsMemoryMode : byte
{
	DEDICATED,
	SHARED,
	TOTAL
}
