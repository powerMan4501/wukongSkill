using b1.BGU.BUAnim;

namespace b1;

public interface IBUC_ABPJogData
{
	bool MoveIsAccelerate { get; }

	ECardinalDir LocomotionCardinalDirection { get; }

	float LocomotionOrientationAngle { get; }

	bool MoveIsDeccelerate { get; }

	bool MoveIsPivot { get; }

	float InputAndVelocityAngleDelta { get; }
}
