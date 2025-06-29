using b1.ECS;

namespace b1;

public class BPC_PlayerPerformData : IPersistentECSData, IBPC_PlayerPerformData
{
	public const int InValidPerformID = -1;

	public int CurrentPerformConfigID { get; set; } = -1;

	public FWeakPerformConfig CurrentPerformConfig { get; } = new FWeakPerformConfig();

	public float CurrentWaitTime { get; set; } = -1f;

	public EWeakPerformPhase CurrentPerformPhase { get; set; }

	public void ResetPerformConfigID()
	{
		CurrentPerformConfigID = -1;
	}

	public bool IsInPerformState()
	{
		return CurrentPerformConfigID != -1;
	}

	public string GetWeakPerformDebugString()
	{
		return $"{CurrentPerformConfigID}[{CurrentPerformPhase}]\nTime:{CurrentWaitTime}";
	}
}
