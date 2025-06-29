using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPCommonLocomotionData
{
	float LeanAngle { get; }

	float SlopeRightAngle { get; }

	float SlopeForwardAngle { get; }

	float BSStartX { get; }

	float BSStartY { get; }

	float BSStopX { get; }

	float BSStopY { get; }

	float BSStopNoBreakX { get; }

	float BSStopNoBreakY { get; }

	FVector RelativeAcceleration { get; }

	EMoveDirectionFive MoveInputDirectionFive { get; }
}
