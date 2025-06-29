namespace b1;

public class AINodeAction_AdjustTransformBySplineParamInfo : IAINodeActionInfo
{
	public bool bShowDebug { get; set; }

	public string SplineGuid { get; set; }

	public float AdjustTime { get; set; }
}
