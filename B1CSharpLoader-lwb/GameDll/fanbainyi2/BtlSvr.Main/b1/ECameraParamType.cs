using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.CameraParamType")]
public enum ECameraParamType : byte
{
	ArmLocationX,
	ArmLocationY,
	ArmLocationZ,
	ArmSocketOffsetX,
	ArmSocketOffsetY,
	ArmSocketOffsetZ,
	ArmLength,
	ControllerPitch,
	ControllerRoll,
	ControllerYaw,
	DmcActorLocationX,
	DmcActorLocationY,
	DmcActorLocationZ,
	DmcActorPitch,
	DmcActorRoll,
	DmcActorYaw,
	DmcArmLength,
	PlayerPosition2D,
	PlayerPositionZ,
	TargetPosition2D,
	TargetPositionZ,
	[UMeta(MD.Hidden)]
	EnumMax
}
