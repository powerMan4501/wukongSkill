using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPBasicData
{
	float VerticleSpeed { get; }

	float HorizontalSpeed { get; }

	float Speed { get; }

	float SprintSpeed { get; }

	float RunSpeed { get; }

	float SpeedWarpAmount { get; }

	float JogBaseSpeed { get; }

	bool IsStandRotate { get; }

	bool IsStandRotateStart { get; }

	float StandRotateAngle { get; }

	EStandRotateType StandRotateType { get; }

	EMoveSpeedLevel MoveSpeedLevel { get; }

	EMoveSpeedLevel MoveSpeedState { get; }

	FVector AccelerationVec { get; }

	bool bHasMoveInput { get; }

	bool bHasPlayerInput { get; }

	bool bHasRun { get; }

	float GetMappedSpeed();

	float GetMappedSpeed3D();

	FRotator GetStandRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPHelperData HelperData, float DeltaTime);
}
