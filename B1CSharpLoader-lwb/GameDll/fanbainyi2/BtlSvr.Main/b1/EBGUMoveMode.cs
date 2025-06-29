using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBGUMoveMode")]
public enum EBGUMoveMode : byte
{
	None,
	Normal,
	BeatBack,
	SideWalk,
	AttackRotate,
	TPSRotate,
	AIPathMove,
	AnimationMontage,
	CameraG4Move,
	AIWallAndCellMove,
	CurveSplineMove,
	JumpMove,
	StandRotate,
	CarMontage,
	FlyControl,
	PlayerAutoMove,
	GlideMove,
	ParkourMove,
	SplineFlyControl,
	RelativeFloatMove,
	AIFlyMove,
	RotateWithCam,
	PhysicsSimulation,
	ManualSplineMove,
	NpcGuideSplineMove,
	AISpiderMove,
	TurretRotate,
	CloudMove,
	EnumMax
}
