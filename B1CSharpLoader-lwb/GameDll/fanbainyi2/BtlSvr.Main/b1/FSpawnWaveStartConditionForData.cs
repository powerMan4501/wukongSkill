namespace b1;

public class FSpawnWaveStartConditionForData
{
	public ESpawnWaveStartConditionType ConditionType { get; set; }

	public float Time { get; set; }

	public bool bConditionSuccess { get; set; }

	public FSpawnWaveStartConditionForData(FSpawnWaveStartCondition StartCondition)
	{
		ConditionType = StartCondition.ConditionType;
		Time = StartCondition.Time;
	}
}
