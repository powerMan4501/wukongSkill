using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSStatType", "b1", UnrealModuleType.Game)]
public enum EGSStatType : byte
{
	NONE,
	CYCLE,
	MEMORY,
	NUM
}
