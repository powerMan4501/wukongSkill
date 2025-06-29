namespace b1;

public class QueryBestLocationCondition
{
	public float DistanceWeight { get; set; }

	public float AngleWeight { get; set; }

	public float LineTraceWeight { get; set; }

	public float DistanceCoefficient { get; set; }

	public float AngleCoefficient { get; set; }

	public float BestLandingDistance { get; set; }

	public bool EnableAngleScope { get; set; }

	public float MaxAngle { get; set; }

	public float MinAngle { get; set; }

	public bool bConsiderTargetAngle { get; set; }

	public bool EnableDistanceScope { get; set; }

	public float MinDistance { get; set; }

	public float MaxDistance { get; set; }

	public void Initialize()
	{
		DistanceWeight = 0f;
		AngleWeight = 0f;
		LineTraceWeight = 0f;
		DistanceCoefficient = -0.05f;
		AngleCoefficient = 100f;
		BestLandingDistance = 800f;
		EnableDistanceScope = false;
		MinDistance = 0f;
		MaxDistance = 0f;
		bConsiderTargetAngle = true;
		EnableAngleScope = false;
		MinAngle = 0f;
		MaxAngle = 0f;
	}
}
