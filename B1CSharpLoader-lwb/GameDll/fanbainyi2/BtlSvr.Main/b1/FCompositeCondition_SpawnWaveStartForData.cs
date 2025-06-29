using System.Collections.Generic;

namespace b1;

public class FCompositeCondition_SpawnWaveStartForData
{
	public FSpawnWaveStartConditionForData Single { get; set; }

	public bool bUseCompositeCondition { get; set; }

	public List<FSpawnWaveStartConditionForData> Conditions { get; } = new List<FSpawnWaveStartConditionForData>();

	public EConditionalRelation ConditionalRelation { get; set; }

	public bool bReverseCondition { get; set; }

	public FCompositeCondition_SpawnWaveStartForData(FCompositeCondition_SpawnWaveStart WaveStartCompositeCondition)
	{
		bUseCompositeCondition = WaveStartCompositeCondition.bUseCompositeCondition;
		Single = new FSpawnWaveStartConditionForData(WaveStartCompositeCondition.Single);
		bReverseCondition = WaveStartCompositeCondition.bReverseCondition;
		ConditionalRelation = WaveStartCompositeCondition.ConditionalRelation;
		foreach (FSpawnWaveStartCondition condition in WaveStartCompositeCondition.Conditions)
		{
			Conditions.Add(new FSpawnWaveStartConditionForData(condition));
		}
	}

	public void OnWaveStarted()
	{
		Single.bConditionSuccess = false;
		foreach (FSpawnWaveStartConditionForData condition in Conditions)
		{
			condition.bConditionSuccess = false;
		}
	}
}
