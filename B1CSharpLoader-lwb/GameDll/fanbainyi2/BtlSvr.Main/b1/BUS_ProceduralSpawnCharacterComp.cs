using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralSpawnCharacterComp : UActorCompBaseCS
{
	protected IBUC_ProceduralSpawnCharacterData ProceduralCharacterData;

	protected readonly float MIN_DELAY_SPAWN_TIME = 0.5f;

	protected readonly float MAX_DELAY_SPAWN_TIME = 2f;

	protected readonly float SPAWN_FX_AHEAD_TIME = 0.2f;

	protected Dictionary<int, List<BGUCharacterCS>> WaveAliveCharacterMap;

	protected Dictionary<int, int> WaveCharacterCountMap;

	protected Dictionary<int, FVector> WaveLastDeathLoc;

	protected List<DelaySpawnInfo> CurrentDelayedSpawnInfo;

	protected List<int> SpawnedWaveList;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_ProceduralSpawnWave += new Del_Void_Int(TrySpawnWave);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckWaveCharacterStatus();
		SpawnWaveCheck();
		CheckDelyedSpawnList(DeltaTime);
	}

	protected void CheckDelyedSpawnList(float DeltaTime)
	{
		for (int num = CurrentDelayedSpawnInfo.Count - 1; num >= 0; num--)
		{
			DelaySpawnInfo item = CurrentDelayedSpawnInfo[num];
			item.Timer -= DeltaTime;
			if (item.Timer <= SPAWN_FX_AHEAD_TIME && !item.HasPlayedSpawnEffect)
			{
				ProceduralSpawnWaveConfig proceduralSpawnWaveConfig = ProceduralCharacterData.GetSpawnWaveConfigs()[item.WaveIndex];
				FTransform inTansform = new FTransform(item.SpawnRot, item.SpawnLoc);
				base.BUSEventCollection?.Evt_AttemptApplyDAEffect.Invoke(proceduralSpawnWaveConfig.SpawnEffectDataAsset, inTansform);
				item.HasPlayedSpawnEffect = true;
			}
			if (item.Timer <= 0f)
			{
				FVector Location = CurrentDelayedSpawnInfo[num].SpawnLoc;
				FRotator Rotation = CurrentDelayedSpawnInfo[num].SpawnRot;
				int waveIndex = CurrentDelayedSpawnInfo[num].WaveIndex;
				BGUCharacterCS bGUCharacterCS = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(GetOwner().World, CurrentDelayedSpawnInfo[num].SpawnClass, in Location, in Rotation) as BGUCharacterCS;
				BGUProceduralMapGenerator bGUProceduralMapGenerator = UGameplayStatics.GetActorOfClass(GetOwner(), UClass.GetClass<BGUProceduralMapGenerator>()) as BGUProceduralMapGenerator;
				if (!bGUProceduralMapGenerator.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(bGUProceduralMapGenerator)?.Evt_QueryEliteConversion.Invoke(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()));
				}
				if (WaveAliveCharacterMap.TryGetValue(waveIndex, out var value))
				{
					value.Add(bGUCharacterCS);
				}
				else
				{
					List<BGUCharacterCS> list = new List<BGUCharacterCS>();
					list.Add(bGUCharacterCS);
					WaveAliveCharacterMap.Add(waveIndex, list);
				}
				if (WaveCharacterCountMap.ContainsKey(waveIndex))
				{
					WaveCharacterCountMap[waveIndex]++;
				}
				else
				{
					WaveCharacterCountMap[waveIndex] = 1;
				}
				CurrentDelayedSpawnInfo.RemoveAt(num);
			}
			else
			{
				CurrentDelayedSpawnInfo.RemoveAt(num);
				CurrentDelayedSpawnInfo.Insert(num, item);
			}
		}
	}

	protected void CheckWaveCharacterStatus()
	{
		foreach (KeyValuePair<int, List<BGUCharacterCS>> item in WaveAliveCharacterMap)
		{
			if (WaveAliveCharacterMap.Count == 0)
			{
				continue;
			}
			List<BGUCharacterCS> value = item.Value;
			int num = 0;
			for (int num2 = value.Count - 1; num2 >= 0; num2--)
			{
				BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(value[num2]);
				if (readOnlyData == null || (readOnlyData != null && readOnlyData.HasState(EBGUUnitState.Dead)))
				{
					num++;
					if (value[num2] != null)
					{
						WaveLastDeathLoc[item.Key] = BGUFuncLibActorTransformCS.BGUGetActorLocation(value[num2]);
					}
					item.Value.RemoveAt(num2);
				}
			}
		}
	}

	private void SpawnWaveCheck()
	{
		List<ProceduralSpawnWaveConfig> spawnWaveConfigs = ProceduralCharacterData.GetSpawnWaveConfigs();
		for (int i = 0; i < spawnWaveConfigs.Count; i++)
		{
			if (CanSpawnWave(i))
			{
				TrySpawnWave(i);
			}
		}
	}

	private void TrySpawnWave(int WaveIndex)
	{
		if (!IsSpawnWaveConfigValid(WaveIndex))
		{
			return;
		}
		float spawnRadius = ProceduralCharacterData.GetSpawnRadius();
		CalculateWaveSpawnClassNum(WaveIndex, out var SpawnClassToNum);
		if (SpawnClassToNum.Count == 0)
		{
			if (!SpawnedWaveList.Contains(WaveIndex))
			{
				SpawnedWaveList.Add(WaveIndex);
			}
			return;
		}
		CalculateMaxUnitRadiusAndHeight(in SpawnClassToNum, out var MaxRadius, out var MaxHeight);
		CalculatePossibleSpawnLocations(WaveIndex, MaxRadius, MaxHeight, spawnRadius, out var OutAvailableLocations);
		TrySpawnCharacter(WaveIndex, in SpawnClassToNum, OutAvailableLocations);
		if (OutAvailableLocations.Count > 0 && !SpawnedWaveList.Contains(WaveIndex))
		{
			SpawnedWaveList.Add(WaveIndex);
		}
	}

	protected void TrySpawnCharacter(int WaveIndex, in Dictionary<TSubclassOf<BGUCharacterCS>, int> SpawnClassToNum, List<FVector> AvailableLoations)
	{
		_ = GetOwner().World;
		FRotator spawnRot = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
		spawnRot.Roll = 0f;
		spawnRot.Pitch = 0f;
		if (AvailableLoations.Count == 0)
		{
			return;
		}
		new List<BGUCharacterCS>();
		_ = ProceduralCharacterData.GetSpawnWaveConfigs()[WaveIndex];
		foreach (KeyValuePair<TSubclassOf<BGUCharacterCS>, int> item2 in SpawnClassToNum)
		{
			UClass value = item2.Key.Value;
			int value2 = item2.Value;
			if (value.IsNullOrDestroyed())
			{
				continue;
			}
			for (int i = 0; i < value2; i++)
			{
				if (AvailableLoations.Count == 0)
				{
					break;
				}
				int index = FMath.RandRange(0, AvailableLoations.Count - 1);
				FVector spawnLoc = AvailableLoations[index];
				DelaySpawnInfo item = new DelaySpawnInfo
				{
					WaveIndex = WaveIndex,
					SpawnClass = value,
					SpawnLoc = spawnLoc,
					SpawnRot = spawnRot,
					HasPlayedSpawnEffect = false,
					Timer = MathLib.RandomFloatInRange(MIN_DELAY_SPAWN_TIME, MAX_DELAY_SPAWN_TIME)
				};
				CurrentDelayedSpawnInfo.Add(item);
				AvailableLoations.RemoveAt(index);
			}
		}
	}

	protected void CalculateWaveSpawnClassNum(int WaveIndex, out Dictionary<TSubclassOf<BGUCharacterCS>, int> SpawnClassToNum)
	{
		ProceduralSpawnWaveConfig proceduralSpawnWaveConfig = ProceduralCharacterData.GetSpawnWaveConfigs()[WaveIndex];
		SpawnClassToNum = new Dictionary<TSubclassOf<BGUCharacterCS>, int>();
		int MinNum = proceduralSpawnWaveConfig.CharacterAssetConfig.MinSpawnNum;
		int MaxNum = proceduralSpawnWaveConfig.CharacterAssetConfig.MaxSpawnNum;
		List<EMobAttackType> mobAttackTypeList = proceduralSpawnWaveConfig.CharacterAssetConfig.MobAttackTypeList;
		BGUProceduralMapGenerator bGUProceduralMapGenerator = UGameplayStatics.GetActorOfClass(GetOwner(), UClass.GetClass<BGUProceduralMapGenerator>()) as BGUProceduralMapGenerator;
		if (!bGUProceduralMapGenerator.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(bGUProceduralMapGenerator).Evt_QuerySpawnClass?.Invoke(mobAttackTypeList, in WaveIndex, in MinNum, in MaxNum, BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()), out SpawnClassToNum);
		}
	}

	protected void CalculateMaxUnitRadiusAndHeight(in Dictionary<TSubclassOf<BGUCharacterCS>, int> SpawnDict, out float MaxRadius, out float MaxHeight)
	{
		MaxRadius = 0f;
		MaxHeight = 0f;
		if (SpawnDict == null)
		{
			return;
		}
		foreach (TSubclassOf<BGUCharacterCS> key in SpawnDict.Keys)
		{
			UCapsuleComponent componentByClass = key.GetDefaultObject().GetComponentByClass<UCapsuleComponent>();
			if (!componentByClass.IsNullOrDestroyed())
			{
				if (componentByClass.GetScaledCapsuleRadius() > MaxRadius)
				{
					MaxRadius = componentByClass.GetScaledCapsuleRadius();
				}
				if (componentByClass.GetScaledCapsuleHalfHeight() > MaxHeight)
				{
					MaxHeight = componentByClass.GetScaledCapsuleHalfHeight();
				}
			}
		}
	}

	protected void CalculatePossibleSpawnLocations(int WaveIndex, float MaxRadius, float MaxHeight, float SpawnRadius, out List<FVector> OutAvailableLocations)
	{
		OutAvailableLocations = new List<FVector>();
		ProceduralSpawnWaveConfig proceduralSpawnWaveConfig = ProceduralCharacterData.GetSpawnWaveConfigs()[WaveIndex];
		if (MaxRadius == 0f || MaxHeight == 0f)
		{
			return;
		}
		float num = FMath.Max(MaxRadius * 1.5f, 48f);
		float num2 = FMath.Max(MaxHeight * 2f, 48f);
		int num3 = (int)FMath.Max(SpawnRadius / (num * 2f), 1f);
		int num4 = (int)(SpawnRadius / (num * 0.5f));
		float num5 = FMath.Max(360 / num4, 1);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
		switch (proceduralSpawnWaveConfig.SpawnBaseLoc)
		{
		case SPAWN_BASE_LOCATION.BASE_ON_DEFAULT:
			fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
			break;
		case SPAWN_BASE_LOCATION.BASE_ON_PLAYER:
		{
			BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player);
			if (!Player.IsNullOrDestroyed())
			{
				fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Player);
			}
			break;
		}
		case SPAWN_BASE_LOCATION.BASE_ON_SPECIFIC_WAVE_DEAD:
		{
			int key = FMath.Clamp(proceduralSpawnWaveConfig.SpawnWaveIndexParam, 0, WaveIndex - 1);
			if (WaveLastDeathLoc.TryGetValue(key, out var value))
			{
				fVector = value;
			}
			break;
		}
		}
		for (int i = 1; i <= num4; i++)
		{
			for (int j = 1; j <= num3 - 1; j++)
			{
				float value2 = FMath.DegreesToRadians(num5 * (float)i);
				FVector fVector2 = fVector;
				fVector2.X += FMath.Cos(value2) * (float)j * num * 2f;
				fVector2.Y += FMath.Sin(value2) * (float)j * num * 2f;
				fVector2.Z += num2 * 0.25f;
				if (UBGUSelectUtil.LineTraceSimple(GetOwner(), fVector2, fVector2 - FVector.UpVector * num2, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out var _, null) > 0)
				{
					OutAvailableLocations.Add(fVector2);
				}
			}
		}
	}

	protected bool IsSpawnWaveConfigValid(int WaveIndex)
	{
		if (ProceduralCharacterData == null)
		{
			return false;
		}
		List<ProceduralSpawnWaveConfig> spawnWaveConfigs = ProceduralCharacterData.GetSpawnWaveConfigs();
		if (spawnWaveConfigs == null || WaveIndex > spawnWaveConfigs.Count - 1)
		{
			return false;
		}
		return true;
	}

	protected bool CanSpawnWave(int WaveIndex)
	{
		bool result = false;
		if (HasWaveAlreadySpawned(WaveIndex))
		{
			return false;
		}
		if (!IsSpawnWaveConfigValid(WaveIndex))
		{
			return false;
		}
		ProceduralSpawnWaveConfig proceduralSpawnWaveConfig = ProceduralCharacterData.GetSpawnWaveConfigs()[WaveIndex];
		switch (proceduralSpawnWaveConfig.SpawnMethod)
		{
		case SPAWN_METHOD.SPAWN_ON_START:
			result = true;
			break;
		case SPAWN_METHOD.SPAWN_ON_WAVE:
		{
			int key = FMath.Clamp(proceduralSpawnWaveConfig.SpawnWaveIndexParam, 0, WaveIndex - 1);
			if (WaveAliveCharacterMap.ContainsKey(key) && WaveCharacterCountMap.ContainsKey(key))
			{
				float num = 1f;
				if (proceduralSpawnWaveConfig.SpawnCondition == SPAWN_CONDITION.SPAWN_ON_DEAD_PERCENTAGE)
				{
					num = proceduralSpawnWaveConfig.SpawnPercentageParam;
				}
				result = 1f - (float)WaveAliveCharacterMap[key].Count / (float)WaveCharacterCountMap[key] >= num;
			}
			break;
		}
		case SPAWN_METHOD.SPAWN_ON_TRIGGER_RANGE:
		{
			BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player);
			if (!Player.IsNullOrDestroyed())
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Player);
				FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
				v.Z = 0f;
				v2.Z = 0f;
				result = MathLib.Dist(v, v2) <= proceduralSpawnWaveConfig.SpawnTriggerDistanceParam;
			}
			break;
		}
		}
		return result;
	}

	protected bool HasWaveAlreadySpawned(int WaveIndex)
	{
		return SpawnedWaveList.Contains(WaveIndex);
	}

	public override void OnBeginPlay()
	{
		ProceduralCharacterData = RequireReadOnlyData<IBUC_ProceduralSpawnCharacterData, BUC_ProceduralSpawnCharacterData>();
		WaveAliveCharacterMap = new Dictionary<int, List<BGUCharacterCS>>();
		WaveLastDeathLoc = new Dictionary<int, FVector>();
		WaveCharacterCountMap = new Dictionary<int, int>();
		SpawnedWaveList = new List<int>();
		CurrentDelayedSpawnInfo = new List<DelaySpawnInfo>();
	}
}
