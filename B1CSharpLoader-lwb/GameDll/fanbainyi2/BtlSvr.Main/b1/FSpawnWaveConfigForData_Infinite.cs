using System.Collections.Generic;

namespace b1;

public class FSpawnWaveConfigForData_Infinite
{
	public int CurTemplateIndex = -1;

	public FCompositeCondition_SpawnWaveStartForData NextWaveStartCondition { get; set; }

	public List<FSpawnWave_OneWaveTemplate> WaveTemplateArray { get; } = new List<FSpawnWave_OneWaveTemplate>();

	public FSpawnWaveConfigForData_Infinite(FSpawnWaveConfig_Infinite WaveConfig_Infinite)
	{
		NextWaveStartCondition = new FCompositeCondition_SpawnWaveStartForData(WaveConfig_Infinite.NextWaveStartCondition);
		WaveTemplateArray = new List<FSpawnWave_OneWaveTemplate>();
		foreach (FSpawnWaveConfig_Infinite_OneWaveWrap spawnWaveUnit in WaveConfig_Infinite.SpawnWaveUnits)
		{
			FSpawnWave_OneWaveTemplate fSpawnWave_OneWaveTemplate = new FSpawnWave_OneWaveTemplate();
			foreach (FSpawnWaveUnitConfig spawnWaveUnit2 in spawnWaveUnit.SpawnWaveUnits)
			{
				fSpawnWave_OneWaveTemplate.SpawnWaveUnits.Add(new FSpawnWaveUnitConfigForData(spawnWaveUnit2));
			}
			fSpawnWave_OneWaveTemplate.RemainUnitNumToTriggerFill = spawnWaveUnit.RemainUnitNumToTriggerFill;
			foreach (FSpawnWaveUnitConfig item in spawnWaveUnit.SpawnWaveUnits_Fill)
			{
				fSpawnWave_OneWaveTemplate.SpawnWaveUnits_Fill.Add(new FSpawnWaveUnitConfigForData(item));
			}
			fSpawnWave_OneWaveTemplate.SpawnIntervalRange = WaveConfig_Infinite.SpawnIntervalRnage;
			WaveTemplateArray.Add(fSpawnWave_OneWaveTemplate);
		}
	}

	public void StartNewWave()
	{
		if (WaveTemplateArray.Count < 1)
		{
			CurTemplateIndex = -1;
			return;
		}
		if (CurTemplateIndex == -1)
		{
			CurTemplateIndex = MathLib.RandomIntInRange(0, WaveTemplateArray.Count - 1);
			return;
		}
		if (WaveTemplateArray.Count == 1)
		{
			CurTemplateIndex = 0;
			return;
		}
		List<int> list = new List<int>();
		int num = 0;
		foreach (FSpawnWave_OneWaveTemplate item in WaveTemplateArray)
		{
			_ = item;
			if (num != CurTemplateIndex)
			{
				list.Add(num);
			}
			num++;
		}
		CurTemplateIndex = list[MathLib.RandomIntInRange(0, list.Count - 1)];
	}

	public FSpawnWave_OneWaveTemplate GetCurrentWave()
	{
		if (CurTemplateIndex == -1)
		{
			return null;
		}
		return WaveTemplateArray[CurTemplateIndex];
	}
}
