using UnrealEngine.Runtime;

namespace b1;

public struct InputAxisPeriodData
{
	public float DeltaTime;

	public FVector2D InputAxis;

	public InputAxisPeriodData(float InDeltaTime, FVector2D InInputAxis)
	{
		DeltaTime = InDeltaTime;
		InputAxis = InInputAxis;
	}
}
