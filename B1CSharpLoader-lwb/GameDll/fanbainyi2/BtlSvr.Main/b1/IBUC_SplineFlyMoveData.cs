namespace b1;

public interface IBUC_SplineFlyMoveData
{
	float HorizontalMoveSpeed { get; }

	float VerticalMoveSpeed { get; }

	float MaxMoveDistance { get; }

	float CurFlySpeedRate { get; }

	float FlyDownwardJudgeAngle { get; }

	bool bSplineFlyMoving { get; }
}
