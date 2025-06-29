using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ManualSplineMoveData
{
	bool bManualSplineMoving { get; }

	bool bMoveForward { get; }

	float SplineMoveMaxSpeed { get; }

	float SplineMoveMaxAcceleration { get; }

	float LockDirectionDeltaAngle { get; }

	EManualSplineMoveDirectionType DirectionType { get; }

	EManualSplineMoveType CurrentManualSplineMoveType { get; }

	USplineComponent SplineComp { get; }

	float CurSplineInputKey { get; }

	FVector CurSplineMoveForwardDir { get; }

	bool IsManuaslSplineMovingWithSpecialAnimation();

	EManualSplineMoveCameraType GetCameraType();
}
