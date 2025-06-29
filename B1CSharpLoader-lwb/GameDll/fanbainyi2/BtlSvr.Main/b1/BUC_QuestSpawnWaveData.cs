using System.Collections.Generic;

namespace b1;

public class BUC_QuestSpawnWaveData
{
	public bool bRecoverToNoSpawn { get; set; }

	public ESpawnWaveType SpawnWaveType { get; set; }

	public int SpawnWaveGroupID { get; set; }

	public float SpawnWaveGlobleGroupCD { get; set; }

	public bool EnsureBornPosCanNavToPlayer { get; set; }

	public FCompositeCondition_SpawnWaveStartForData FirstWaveStartCondition { get; set; }

	public List<FSpawnWaveConfigForData> Waves { get; } = new List<FSpawnWaveConfigForData>();

	public int CurrentWaveIndex { get; set; }

	public FSpawnWaveConfigForData_Infinite SpawnWaveConfig_Infinite { get; set; }

	public EWaveStopActionType WaveStopActionType { get; set; }

	public bool bSpawnUnitAnyActive { get; set; }

	public HashSet<string> WatchActiveUnits { get; } = new HashSet<string>();

	public FSpawnWaveConfigForData GetCurrentWave()
	{
		if (CurrentWaveIndex >= 0 && Waves.Count > CurrentWaveIndex)
		{
			return Waves[CurrentWaveIndex];
		}
		return null;
	}

	public FSpawnWave_OneWaveTemplate GetCurWaveTemplate()
	{
		FSpawnWave_OneWaveTemplate result = null;
		switch (SpawnWaveType)
		{
		case ESpawnWaveType.SpawnSequence:
		{
			FSpawnWaveConfigForData currentWave = GetCurrentWave();
			if (currentWave != null)
			{
				result = currentWave.WaveTemplate;
			}
			break;
		}
		case ESpawnWaveType.SpawnInfinite:
			result = SpawnWaveConfig_Infinite.GetCurrentWave();
			break;
		}
		return result;
	}
}
