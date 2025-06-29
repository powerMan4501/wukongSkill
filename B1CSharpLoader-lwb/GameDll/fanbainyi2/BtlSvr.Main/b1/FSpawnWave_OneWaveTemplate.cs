using System;
using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public class FSpawnWave_OneWaveTemplate
{
	public FCalliopeGuid SummonGuid;

	public int CurSpawnIndex;

	public float UnitSpawnTimer;

	public float SpawnInterval;

	public bool bFlag_FillEventAlreadyTriggered;

	public List<FSpawnWaveUnitConfigForData> SpawnWaveUnits { get; } = new List<FSpawnWaveUnitConfigForData>();

	public FVector2D SpawnIntervalRange { get; set; }

	public int RemainUnitNumToTriggerFill { get; set; }

	public List<FSpawnWaveUnitConfigForData> SpawnWaveUnits_Fill { get; } = new List<FSpawnWaveUnitConfigForData>();

	public List<string> SpawnedUnits { get; } = new List<string>();

	public bool bUnitAllDead { get; set; }

	public float WaveTime { get; set; }

	public float TimerAfterPreviousClear { get; set; }

	public void OnWaveStarted()
	{
		SpawnedUnits.Clear();
		WaveTime = 0f;
		TimerAfterPreviousClear = 0f;
		bUnitAllDead = false;
		CurSpawnIndex = 0;
		UnitSpawnTimer = 0f;
		SpawnInterval = 0f;
		SummonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
		bFlag_FillEventAlreadyTriggered = false;
	}

	public bool bIsCurWaveFinished()
	{
		return CurSpawnIndex >= SpawnWaveUnits.Count;
	}

	public bool bIsInFillWaveSpawn()
	{
		return bFlag_FillEventAlreadyTriggered;
	}
}
