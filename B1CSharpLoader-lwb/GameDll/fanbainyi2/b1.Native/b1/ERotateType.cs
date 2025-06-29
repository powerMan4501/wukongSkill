using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ERotateType", "UnrealExtent", UnrealModuleType.Game)]
public enum ERotateType : byte
{
	PITCH,
	YAW,
	ROLL
}
