namespace b1;

public class FSpawnWaveConfigForData
{
	public FCompositeCondition_SpawnWaveStartForData NextWaveStartCondition { get; set; }

	public FSpawnWave_OneWaveTemplate WaveTemplate { get; set; }

	public FSpawnWaveConfigForData(FSpawnWaveConfig WaveConfig)
	{
		NextWaveStartCondition = new FCompositeCondition_SpawnWaveStartForData(WaveConfig.NextWaveStartCondition);
		WaveTemplate = new FSpawnWave_OneWaveTemplate();
		foreach (FSpawnWaveUnitConfig spawnWaveUnit in WaveConfig.SpawnWaveUnits)
		{
			WaveTemplate.SpawnWaveUnits.Add(new FSpawnWaveUnitConfigForData(spawnWaveUnit));
		}
		WaveTemplate.SpawnIntervalRange = WaveConfig.SpawnIntervalRnage;
	}
}
