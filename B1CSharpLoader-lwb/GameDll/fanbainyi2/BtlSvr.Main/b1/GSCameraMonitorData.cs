namespace b1;

public class GSCameraMonitorData
{
	public GSLocation StraightPlayerRefPos { get; } = new GSLocation();

	public GSLocation StraightTargetRefPos { get; } = new GSLocation();

	public GSLocation StraightCameraRefPos { get; } = new GSLocation();

	public GSRotation StraightOriginControllerRotation { get; } = new GSRotation();

	public float StraightHeightDistance { get; set; }

	public float StraightP2TDistance { get; set; }

	public GSLocation StraightOffsetCurveValue { get; } = new GSLocation();

	public GSLocation GiantPlayerRefPos { get; } = new GSLocation();

	public GSLocation GiantTargetRefPos { get; set; } = new GSLocation();

	public GSLocation GiantCameraRefPos { get; set; } = new GSLocation();

	public GSRotation GiantOriginControllerRotation { get; } = new GSRotation();

	public float GiantHeightDistance { get; set; }

	public float GiantP2TDistance { get; set; }

	public FStraightParams StraightParams { get; } = new FStraightParams();
}
