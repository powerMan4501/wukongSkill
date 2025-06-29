using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralMapGlobalSpawnerMgrComp : UActorCompBaseCS
{
	private BUC_ProceduralMapGeneratorData ProceduralMapData;

	private int CurrentEliteNum;

	private int CurrentSpecialNum;

	private List<int> VisitedIndex = new List<int>();

	private List<float> PhaseList = new List<float>();

	private Dictionary<int, int> IndexEliteNumMap = new Dictionary<int, int>();

	private Dictionary<int, int> IndexSpecialNumMap = new Dictionary<int, int>();

	protected List<TSubclassOf<BGUCharacterCS>> AvailableRangedClass;

	protected List<TSubclassOf<BGUCharacterCS>> AvailableMeleeClass;

	protected List<TSubclassOf<BGUCharacterCS>> AvailableSpecialClass;

	protected List<TSubclassOf<BGUCharacterCS>> AvailableWeakClass;

	protected List<TSubclassOf<BGUCharacterCS>> AvailableModerateClass;

	protected List<TSubclassOf<BGUCharacterCS>> AvailableStrongClass;

	protected List<TSubclassOf<BGUCharacterCS>> CanBeEliteClass;

	protected Dictionary<EMobStrengthLevel, List<TSubclassOf<BGUCharacterCS>>> StrengthClassMap;

	protected Dictionary<EMobAttackType, List<TSubclassOf<BGUCharacterCS>>> AttackTypeClassMap;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_QuerySpawnClass += new Del_QuerySpawnClass(QuerySpawnClass);
		base.BUSEventCollection.Evt_QueryEliteConversion += new Del_Void_ActorVector(QueryEliteConversion);
	}

	protected void QuerySpawnClass(List<EMobAttackType> AttackTypes, in int WaveIndex, in int MinNum, in int MaxNum, FVector SpawnerLoc, out Dictionary<TSubclassOf<BGUCharacterCS>, int> OutSpawnClassNum)
	{
		OutSpawnClassNum = new Dictionary<TSubclassOf<BGUCharacterCS>, int>();
		if (ProceduralMapData == null)
		{
			return;
		}
		FUStMapMobConfigDesc mapMobConfigDesc = BGW_GameDB.GetMapMobConfigDesc(ProceduralMapData.MapInfo.MapMobConfigID);
		if (mapMobConfigDesc == null)
		{
			return;
		}
		UpdateMapProgress(SpawnerLoc, out var SpawnerBlockIndex, out var SpawnerMapProgress);
		int num = 0;
		for (int i = 0; i < PhaseList.Count; i++)
		{
			if (SpawnerMapProgress > PhaseList[i])
			{
				num = i;
			}
		}
		if (mapMobConfigDesc.PhaseConfig.Count > 0 && num < mapMobConfigDesc.PhaseConfig.Count && WaveIndex >= 1 && MathLib.RandomFloatInRange(0f, 1f) > mapMobConfigDesc.PhaseConfig[num].SecondWaveChance)
		{
			return;
		}
		int num2 = FMath.CeilToInt(SpawnerMapProgress * (float)ProceduralMapData.MapInfo.ValidBlockNum);
		if ((!IndexSpecialNumMap.ContainsKey(SpawnerBlockIndex) || IndexSpecialNumMap[SpawnerBlockIndex] < mapMobConfigDesc.MaxSpecialNumPerPoint) && num >= mapMobConfigDesc.SpecialStartPhase && AvailableSpecialClass.Count > 0 && CurrentSpecialNum < mapMobConfigDesc.MaxSpecialNum)
		{
			float num3 = mapMobConfigDesc.BaseSpecialChance + (float)num2 * mapMobConfigDesc.SpecialChanceIncrement;
			num3 = MathLib.Clamp(num3, num3, mapMobConfigDesc.MarginSpecialChance);
			if (MathLib.RandomFloatInRange(0f, 1f) <= num3)
			{
				CurrentSpecialNum++;
				TSubclassOf<BGUCharacterCS> key = AvailableSpecialClass[MathLib.RandomIntInRange(0, AvailableSpecialClass.Count - 1)];
				if (OutSpawnClassNum.ContainsKey(key))
				{
					OutSpawnClassNum[key]++;
				}
				else
				{
					OutSpawnClassNum[key] = 1;
				}
				if (IndexSpecialNumMap.ContainsKey(SpawnerBlockIndex))
				{
					IndexSpecialNumMap[SpawnerBlockIndex]++;
				}
				else
				{
					IndexSpecialNumMap[SpawnerBlockIndex] = 1;
				}
			}
		}
		int num4 = MathLib.RandomIntInRange(MinNum, MaxNum);
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		foreach (FUStPhaseMobConfig item in mapMobConfigDesc.GeneralMobConfig)
		{
			float num8 = 0f;
			if (num < item.StartPhase)
			{
				num8 = 0f;
			}
			else
			{
				num8 = item.BaseChance + (float)num2 * item.ChanceIncrement;
				num8 = ((!(item.MarginChance >= item.BaseChance)) ? MathLib.Clamp(num8, 0f, item.BaseChance) : MathLib.Clamp(num8, item.BaseChance, item.MarginChance));
			}
			switch (item.StrengthTag)
			{
			case EMobStrengthLevel.LevelWeak:
				num5 = num8;
				break;
			case EMobStrengthLevel.LevelModerate:
				num6 = num8;
				break;
			case EMobStrengthLevel.LevelStrong:
				num7 = num8;
				break;
			}
		}
		float num9 = num5 + num6 + num7;
		num9 = ((num9 == 0f) ? 1f : num9);
		num5 /= num9;
		num6 /= num9;
		num7 /= num9;
		if (num < 1)
		{
			while (AttackTypes.Count > 1)
			{
				AttackTypes.RemoveAt(MathLib.RandomIntInRange(0, AttackTypes.Count - 1));
			}
		}
		for (int j = 0; j < num4; j++)
		{
			float num10 = MathLib.RandomFloatInRange(0f, 1f);
			EMobStrengthLevel eMobStrengthLevel = EMobStrengthLevel.LevelWeak;
			eMobStrengthLevel = ((!(num10 < num5)) ? ((num10 >= num5 && num10 < num6 + num5) ? EMobStrengthLevel.LevelModerate : EMobStrengthLevel.LevelStrong) : EMobStrengthLevel.LevelWeak);
			EMobAttackType key2 = AttackTypes[MathLib.RandomIntInRange(0, AttackTypes.Count - 1)];
			List<TSubclassOf<BGUCharacterCS>> list = new List<TSubclassOf<BGUCharacterCS>>();
			foreach (TSubclassOf<BGUCharacterCS> item2 in StrengthClassMap[eMobStrengthLevel])
			{
				if (AttackTypeClassMap[key2].Contains(item2))
				{
					list.Add(item2);
				}
			}
			if (list.Count >= 1)
			{
				TSubclassOf<BGUCharacterCS> key3 = list[MathLib.RandomIntInRange(0, list.Count - 1)];
				if (OutSpawnClassNum.ContainsKey(key3))
				{
					OutSpawnClassNum[key3]++;
				}
				else
				{
					OutSpawnClassNum[key3] = 1;
				}
			}
		}
	}

	public void QueryEliteConversion(AActor Actor, FVector SpawnerLoc)
	{
		if (ProceduralMapData == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		TSubclassOf<BGUCharacterCS> item = bGUCharacterCS.GetClass();
		if (!CanBeEliteClass.Contains(item))
		{
			return;
		}
		FUStMapMobConfigDesc mapMobConfigDesc = BGW_GameDB.GetMapMobConfigDesc(ProceduralMapData.MapInfo.MapMobConfigID);
		if (mapMobConfigDesc == null)
		{
			return;
		}
		UpdateMapProgress(SpawnerLoc, out var _, out var SpawnerMapProgress);
		int num = 0;
		for (int i = 0; i < PhaseList.Count; i++)
		{
			if (SpawnerMapProgress > PhaseList[i])
			{
				num = i;
			}
		}
		if (num < mapMobConfigDesc.EliteStartPhase)
		{
			return;
		}
		FUStEliteBuffConfigDesc eliteBuffConfigDesc = BGW_GameDB.GetEliteBuffConfigDesc(mapMobConfigDesc.BuffConfigID);
		if (CurrentEliteNum >= mapMobConfigDesc.MaxEliteNum)
		{
			return;
		}
		float x = mapMobConfigDesc.BaseEliteChance + (float)VisitedIndex.Count * mapMobConfigDesc.EliteChanceIncrement;
		x = MathLib.Clamp(x, 0f, mapMobConfigDesc.MarginEliteChance);
		float num2 = MathLib.RandomFloatInRange(0f, 1f);
		int key = QueryBlockIndex(SpawnerLoc);
		if (num2 < x && CurrentEliteNum < mapMobConfigDesc.MaxEliteNum && (!IndexEliteNumMap.ContainsKey(key) || IndexEliteNumMap[key] < mapMobConfigDesc.MaxEliteNumPerPoint))
		{
			int index = MathLib.RandomIntInRange(0, eliteBuffConfigDesc.BuffID.Count - 1);
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BuffAdd?.Invoke(eliteBuffConfigDesc.BuffID[index], bGUCharacterCS, bGUCharacterCS, -1f);
			if (IndexEliteNumMap.ContainsKey(key))
			{
				IndexEliteNumMap[key]++;
			}
			else
			{
				IndexEliteNumMap[key] = 1;
			}
			CurrentEliteNum++;
		}
	}

	protected int QueryBlockIndex(FVector TargetLocation)
	{
		if (ProceduralMapData == null)
		{
			return -1;
		}
		MapProceduralInfo mapInfo = ProceduralMapData.GetMapInfo();
		TargetLocation.Z = 0f;
		int num = MathLib.FFloor((TargetLocation.X + (float)(mapInfo.MapWidth / 2 * mapInfo.BlockWidth)) / (float)mapInfo.BlockWidth);
		int num2 = MathLib.FFloor((TargetLocation.Y + (float)(mapInfo.MapHeight / 2 * mapInfo.BlockHeight)) / (float)mapInfo.BlockHeight);
		return num + num2 * mapInfo.MapWidth;
	}

	protected void UpdateMapProgress(FVector SpawnerLoc, out int SpawnerBlockIndex, out float SpawnerMapProgress)
	{
		SpawnerMapProgress = -1f;
		SpawnerBlockIndex = -1;
		if (ProceduralMapData == null || !BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player))
		{
			return;
		}
		SpawnerBlockIndex = QueryBlockIndex(SpawnerLoc);
		int num = QueryBlockIndex(BGUFuncLibActorTransformCS.BGUGetActorLocation(Player));
		if (!VisitedIndex.Contains(num) && num != -1)
		{
			VisitedIndex.Add(num);
		}
		MapProceduralInfo mapInfo = ProceduralMapData.MapInfo;
		if (mapInfo.ValidBlockNum == 0)
		{
			return;
		}
		if (SpawnerBlockIndex != -1)
		{
			if (num == SpawnerBlockIndex)
			{
				SpawnerMapProgress = (float)VisitedIndex.Count / (float)mapInfo.ValidBlockNum;
			}
			else
			{
				SpawnerMapProgress = (float)(VisitedIndex.Count + 1) / (float)mapInfo.ValidBlockNum;
			}
		}
		else
		{
			SpawnerMapProgress = (float)VisitedIndex.Count / (float)mapInfo.ValidBlockNum;
		}
	}

	public override void OnBeginPlay()
	{
		ProceduralMapData = RequireWritableData<BUC_ProceduralMapGeneratorData>();
		InitSmartSpawnClassProcess();
	}

	protected void InitSmartSpawnClassProcess()
	{
		AvailableRangedClass = new List<TSubclassOf<BGUCharacterCS>>();
		AvailableMeleeClass = new List<TSubclassOf<BGUCharacterCS>>();
		AvailableSpecialClass = new List<TSubclassOf<BGUCharacterCS>>();
		AvailableWeakClass = new List<TSubclassOf<BGUCharacterCS>>();
		AvailableModerateClass = new List<TSubclassOf<BGUCharacterCS>>();
		AvailableStrongClass = new List<TSubclassOf<BGUCharacterCS>>();
		CanBeEliteClass = new List<TSubclassOf<BGUCharacterCS>>();
		StrengthClassMap = new Dictionary<EMobStrengthLevel, List<TSubclassOf<BGUCharacterCS>>>();
		AttackTypeClassMap = new Dictionary<EMobAttackType, List<TSubclassOf<BGUCharacterCS>>>();
		Dictionary<int, FUStMobLevelMappingDesc> allMobLevelMappingDesc = BGW_GameDB.GetAllMobLevelMappingDesc();
		FUStMapMobConfigDesc mapMobConfigDesc = BGW_GameDB.GetMapMobConfigDesc(ProceduralMapData.MapInfo.MapMobConfigID);
		if (allMobLevelMappingDesc == null)
		{
			USystemLibrary.PrintString(null, "无法读怪物库配置！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
			return;
		}
		if (mapMobConfigDesc == null)
		{
			USystemLibrary.PrintString(null, "无法读取地图怪物配置！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
			return;
		}
		for (int i = 0; i < mapMobConfigDesc.PhaseConfig.Count; i++)
		{
			PhaseList.Add(mapMobConfigDesc.PhaseConfig[i].Thresholds);
		}
		foreach (FUStMobLevelMappingDesc value in allMobLevelMappingDesc.Values)
		{
			foreach (string item in value.MobLibAssetPath)
			{
				BGWProceduralSpawnCharacterLibDataAsset bGWProceduralSpawnCharacterLibDataAsset = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWProceduralSpawnCharacterLibDataAsset>(item, ELoadResourceType.SyncLoadAndCache);
				if (bGWProceduralSpawnCharacterLibDataAsset.IsNullOrDestroyed())
				{
					continue;
				}
				foreach (CharacterSpawnerLibInfo characterInfo in bGWProceduralSpawnCharacterLibDataAsset.CharacterInfoList)
				{
					switch (value.AttackType)
					{
					case EMobAttackType.MeleeAttack:
						AvailableMeleeClass.Add(characterInfo.SpawnClass);
						break;
					case EMobAttackType.RangedAttack:
						AvailableRangedClass.Add(characterInfo.SpawnClass);
						break;
					}
					switch (value.StrengthLevel)
					{
					case EMobStrengthLevel.LevelWeak:
						AvailableWeakClass.Add(characterInfo.SpawnClass);
						break;
					case EMobStrengthLevel.LevelModerate:
						AvailableModerateClass.Add(characterInfo.SpawnClass);
						break;
					case EMobStrengthLevel.LevelStrong:
						AvailableStrongClass.Add(characterInfo.SpawnClass);
						break;
					case EMobStrengthLevel.LevelSpecial:
						AvailableSpecialClass.Add(characterInfo.SpawnClass);
						break;
					}
					if (characterInfo.CanBeElite)
					{
						CanBeEliteClass.Add(characterInfo.SpawnClass);
					}
				}
			}
		}
		StrengthClassMap.Add(EMobStrengthLevel.LevelWeak, AvailableWeakClass);
		StrengthClassMap.Add(EMobStrengthLevel.LevelModerate, AvailableModerateClass);
		StrengthClassMap.Add(EMobStrengthLevel.LevelStrong, AvailableStrongClass);
		StrengthClassMap.Add(EMobStrengthLevel.LevelSpecial, AvailableSpecialClass);
		AttackTypeClassMap.Add(EMobAttackType.MeleeAttack, AvailableMeleeClass);
		AttackTypeClassMap.Add(EMobAttackType.RangedAttack, AvailableRangedClass);
	}
}
