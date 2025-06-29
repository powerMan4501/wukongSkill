using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSAngleCenterDirection", "b1", UnrealModuleType.Game)]
public enum EGSAngleCenterDirection : byte
{
	Forward,
	Back,
	Left,
	Right
}
