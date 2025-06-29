using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPCharacterData
{
	FVector Velocity { get; }

	FVector LastVelocity { get; }

	FVector RealWorldVelocity { get; set; }

	FVector RealAcceleration { get; }

	FVector MoveAcceleration { get; }

	FVector LastMoveAccelerationNotZero { get; }

	float MaxSpeed { get; }

	float MaxAcceleration { get; }

	float GroundFriction { get; }

	float BrakingFriction { get; }

	float BrakingFrictionFactor { get; }

	float BrakingDecelerationWalking { get; }

	bool bUseSeparateBrakingFriction { get; }

	FVector ActorLocation { get; }

	FVector LastActorLocation { get; }

	FRotator ActorRotation { get; }

	FRotator ControlRotation { get; }

	FVector ForwardVector { get; }

	FVector RightVector { get; }

	FVector UpVector { get; }

	FVector ActorScale3D { get; }

	float ScaledCapsuleHalfHeight { get; }

	float ScaledCapsuleRadius { get; }

	FName AimOffsetEyeSocketName { get; set; }

	FName AimOffsetBeWatchedSocketName { get; set; }

	FVector AimOffsetEyeSocketPos { get; set; }

	FVector AimOffsetBeWatchedSocketPos { get; set; }

	bool IsFlying { get; }

	bool IsFalling { get; }

	bool IsLastFrameFalling { get; }

	bool IsLandingMove { get; }

	bool IsFarButInSight { get; }

	bool IsLocking { get; }

	bool IsMontage { get; }

	bool IsMontageRealTime { get; set; }

	UCharacterMovementComponent MovementComp { get; }

	bool IsLeftFootFront();

	bool IsLeftFootMoveForward();

	bool IsRightFootMoveForward();

	bool IsNextLeftFootStep();
}
