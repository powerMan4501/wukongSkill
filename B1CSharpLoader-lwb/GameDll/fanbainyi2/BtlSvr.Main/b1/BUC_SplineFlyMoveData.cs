namespace b1;

internal class BUC_SplineFlyMoveData : IBUC_SplineFlyMoveData
{
	public float HorizontalMoveSpeed { get; set; }

	public float VerticalMoveSpeed { get; set; }

	public float MaxMoveDistance { get; set; }

	public float FlyDownwardSpeedRate { get; set; }

	public float CurFlySpeedRate { get; set; }

	public float FlyDownwardJudgeAngle { get; set; }

	public bool bSplineFlyMoving { get; set; }
}
