using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.InputActionType")]
public enum EInputActionType : byte
{
	None = 0,
	LightAttack = 1,
	HeavyAttack = 2,
	Interact = 3,
	CastItemSkill = 4,
	CameraLock = 5,
	SpinMode = 7,
	CameraLockPointHide = 8,
	CameraModeSwitch = 10,
	CameraG4SpotTurn = 11,
	SwitchMoveSpeedState = 12,
	Move = 14,
	ViewportRotate = 15,
	Dodge = 18,
	Jump = 19,
	PhantomRush = 23,
	AxisCameraLockSwitchTarget = 24,
	UseShortcutItem = 25,
	SwitchDefaultSpell = 28,
	UseSkillByType = 29,
	CastFaBaoSkill = 30,
	MoveFinish = 33,
	SwitchWeaponPoseHeavy = 34,
	SwitchWeaponPoseProp = 35,
	SwitchWeaponPosePoke = 36,
	Unfreeze = 37,
	UseVigorSkill = 38,
	CloudLift = 39,
	CloudFreeLook = 40,
	ToggleCloudMove = 41,
	SpinModeMoveForward = 42,
	OpenMap = 43
}
