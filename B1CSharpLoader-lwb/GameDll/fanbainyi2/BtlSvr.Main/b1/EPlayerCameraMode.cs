using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PlayerCameraMode")]
public enum EPlayerCameraMode : byte
{
	AutoTrail,
	LockDarkSoul,
	LockDMC
}
