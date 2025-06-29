using System.Collections.Generic;
using System.Linq;
using b1.CppExport;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

public class BUS_NeutralAnimalAreaLogicComp : UActorCompBaseCS
{
	private BUC_NeutralAnimalAreaLogicData AreaData;

	private IBUC_GuidData GuidData;

	protected IBGC_SummonData SummonManagerData;

	private IBGC_LocalPlayerSharedData LocalPlayerShareData;

	private IBGC_NeutralAnimalSpawnMgrData SpawnMgrData;

	private IBGC_MovieData MovieData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		AreaData = RequireWritableData<BUC_NeutralAnimalAreaLogicData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		SummonManagerData = RequireReadOnlyGameStateData<IBGC_SummonData, BGC_SummonData>();
		LocalPlayerShareData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		SpawnMgrData = RequireReadOnlyGameStateData<IBGC_NeutralAnimalSpawnMgrData, BGC_NeutralAnimalSpawnMgrData>();
		MovieData = RequireReadOnlyGameStateData<IBGC_MovieData, BGC_MovieData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
		base.BUSEventCollection.Evt_OnAreaAnimalAllDead += new Del_Void(OnAnimalsAllDead);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnBeginPlay()
	{
		AreaData.LastSpawnTime = 0f - AreaData.SpawnCD;
		AreaData.AnimalAllDeadTime = 0f - AreaData.DestroyProtectCD;
	}

	private void ValidateConfig()
	{
		BGUNeutralAnimalSpawnArea bGUNeutralAnimalSpawnArea = Owner as BGUNeutralAnimalSpawnArea;
		if (bGUNeutralAnimalSpawnArea == null || (AreaData.SpawnPosType == EAnimalSpawnPosType.EQS_Runtime && (AreaData.EQSTemplate == null || AreaData.AnimalTemplates.Count < 1)))
		{
			return;
		}
		if (AreaData.SpawnPosType == EAnimalSpawnPosType.PresetPointset)
		{
			if (bGUNeutralAnimalSpawnArea.TerritoryInfos.Count < 1)
			{
				return;
			}
			foreach (KeyValuePair<string, FNeutralAnimalTerritoryInfo> territoryInfo in bGUNeutralAnimalSpawnArea.TerritoryInfos)
			{
				if (territoryInfo.Value.AnimalTemplates.Count < 1)
				{
					return;
				}
			}
		}
		AreaData.ConfigError = false;
	}

	private void InitTerritoryLandInfo()
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UBoxComponent>(), B1GlobalFNames.TerritoryBox))
		{
			UBoxComponent uBoxComponent = item as UBoxComponent;
			if (!(uBoxComponent == null))
			{
				FTerritoryBoxInfo fTerritoryBoxInfo = new FTerritoryBoxInfo
				{
					CenterPos = uBoxComponent.GetWorldLocation(),
					BoxExtend = uBoxComponent.GetScaledBoxExtent()
				};
			}
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateSpawn();
		UpdateDebugInfo();
	}

	private void UpdateSpawn()
	{
		if (!SpawnMgrData.BPAnimalSpawnPause && !AreaData.HasAnimalSpawned && IsLocalPlayerInner() && !IsInPresetCD() && !IsInSpawnCD() && !IsInDestroyProtectCD() && CheckInSeqCondition() && CheckInCloudMoveCondition())
		{
			StartSpawnAnimals();
		}
	}

	private bool CheckInSeqCondition()
	{
		if (AreaData.DestroyAllAnimalWhenPlaySeq && MovieData != null && MovieData.IsPlaying())
		{
			return false;
		}
		return true;
	}

	private bool CheckInCloudMoveCondition()
	{
		if (AreaData.DontSpawnInCloudMove && BGUFunctionLibraryCS.BGUHasUnitSimpleState(LocalPlayerShareData.FirstLocalPlayerPawn, EBGUSimpleState.CloudMove))
		{
			return false;
		}
		return true;
	}

	private bool IsLocalPlayerInner()
	{
		return AreaData.LocalPlayerInner;
	}

	private bool IsInPresetCD()
	{
		return UnrealGameplayData.GetTimeSeconds() < AreaData.LastEnterTriggerAreaTime + AreaData.PresetCD;
	}

	private bool IsInSpawnCD()
	{
		float num = ((AreaData.SpawnCD > 0f) ? AreaData.SpawnCD : 10f);
		return UnrealGameplayData.GetTimeSeconds() < AreaData.LastSpawnTime + num;
	}

	private bool IsInDestroyProtectCD()
	{
		float num = ((AreaData.DestroyProtectCD > 0f) ? AreaData.DestroyProtectCD : 10f);
		return UnrealGameplayData.GetTimeSeconds() < AreaData.AnimalAllDeadTime + num;
	}

	private void StartSpawnAnimals()
	{
		bool bSpawnSuccessed = false;
		switch (AreaData.SpawnPosType)
		{
		case EAnimalSpawnPosType.EQS_Runtime:
			bSpawnSuccessed = SpawnAnimal_ByEQS();
			break;
		case EAnimalSpawnPosType.PresetPointset:
			bSpawnSuccessed = SpawnAnimal_ByPresetPointset();
			break;
		}
		OnSpawnReqFinished(bSpawnSuccessed);
	}

	private List<FVector> OrderSpawnPosList(List<FVector> Positions)
	{
		List<FVector> result = new List<FVector>();
		switch (AreaData.DistributionSpawnTendency)
		{
		case EAnimalDistributionSpawnTendency.Concentrated:
			result = ScorePositions_Concentrated(Positions);
			break;
		case EAnimalDistributionSpawnTendency.Random:
			result = ScorePositions_Random(Positions);
			break;
		}
		return result;
	}

	private void OnSpawnReqFinished(bool bSpawnSuccessed)
	{
		AreaData.HasAnimalSpawned = bSpawnSuccessed;
		AreaData.LastSpawnTime = UnrealGameplayData.GetTimeSeconds();
	}

	private bool SpawnAnimal_ByEQS()
	{
		List<FVector> Locations = new List<FVector>();
		if (AreaData.EQSTemplate != null)
		{
			base.BGSEventCollection.Evt_BGS_EQSObjRunInstant.Invoke(AreaData.EQSTemplate, Owner, out Locations, out var _);
		}
		ReqSpawnAnimal(Locations, AreaData.AnimalTemplates);
		return SpawnMgrData.bLastBPAnimalSpawnReqSuccess;
	}

	private bool SpawnAnimal_ByPresetPointset()
	{
		bool flag = false;
		BGUNeutralAnimalSpawnArea bGUNeutralAnimalSpawnArea = Owner as BGUNeutralAnimalSpawnArea;
		if (bGUNeutralAnimalSpawnArea != null)
		{
			foreach (KeyValuePair<string, FNeutralAnimalTerritoryInfo> territoryInfo in bGUNeutralAnimalSpawnArea.TerritoryInfos)
			{
				ReqSpawnAnimal(territoryInfo.Value.PresetSpawnPositions, territoryInfo.Value.AnimalTemplates);
				flag |= SpawnMgrData.bLastBPAnimalSpawnReqSuccess;
			}
		}
		return flag;
	}

	private void ReqSpawnAnimal(List<FVector> Positions, List<FAnimalSpawnTemplate> AnimalTemplates)
	{
		List<FVector> list = Positions;
		foreach (FAnimalSpawnTemplate AnimalTemplate in AnimalTemplates)
		{
			if (list.Count < 1)
			{
				break;
			}
			TSubclassOf<BUTamerActor> animalTamerClass = AnimalTemplate.AnimalTamerClass;
			GSE_NativeMathFuncs.Del_RandomIntInRange randomIntInRange = MathLib.RandomIntInRange;
			FInt32Range spawnCountRange = AnimalTemplate.SpawnCountRange;
			int lowerBoundValue = spawnCountRange.GetLowerBoundValue();
			spawnCountRange = AnimalTemplate.SpawnCountRange;
			int num = randomIntInRange(lowerBoundValue, spawnCountRange.GetUpperBoundValue());
			list = OrderSpawnPosList(list);
			List<FVector> list2 = new List<FVector>();
			int num2 = num;
			while (num2 > 0 && list.Count >= 1)
			{
				list2.Add(list[0]);
				list.RemoveAt(0);
				num2--;
			}
			FNeutralAnimalSpawnReq spawnReq = new FNeutralAnimalSpawnReq
			{
				AreaGuid = GuidData.GetFinalGuid(),
				SpawnPosList = list2,
				ScaleRange = AnimalTemplate.ScaleRange,
				TamerTemplate = animalTamerClass,
				DesireSpawnCount = num,
				DestroyAllAnimalWhenPlaySeq = AreaData.DestroyAllAnimalWhenPlaySeq
			};
			base.BGSEventCollection.Evt_BGS_ReqSpawnAnimals.Invoke(spawnReq);
		}
	}

	private List<FVector> ScorePositions_Concentrated(List<FVector> Positions)
	{
		if (Positions == null || Positions.Count == 0)
		{
			return new List<FVector>();
		}
		int index = MathLib.RandomIntInRange(0, Positions.Count - 1);
		FVector RandomPos = Positions[index];
		return Positions.OrderBy((FVector p) => FVector.Dist2D(p, RandomPos)).ToList();
	}

	private List<FVector> ScorePositions_Random(List<FVector> Positions)
	{
		if (Positions == null || Positions.Count == 0)
		{
			return new List<FVector>();
		}
		List<FVector> list = new List<FVector>();
		while (Positions.Count > 0)
		{
			int index = MathLib.RandomIntInRange(0, Positions.Count - 1);
			list.Add(Positions[index]);
			Positions.RemoveAt(index);
		}
		return list;
	}

	private void OnAnimalsAllDead()
	{
		AreaData.HasAnimalSpawned = false;
		AreaData.AnimalAllDeadTime = UnrealGameplayData.GetTimeSeconds();
	}

	private void DestroyAllAnimal()
	{
		SummonManagerData.GetSummonInstancesBySummoner(GuidData.GetFinalGuid(), out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			item.TriggerAllServantLifeOver();
		}
	}

	private void OnActorEnter(AActor OtherActor)
	{
		if (!(OtherActor != LocalPlayerShareData.FirstLocalPlayerPawn))
		{
			AreaData.LastEnterTriggerAreaTime = UnrealGameplayData.GetTimeSeconds();
			AreaData.LocalPlayerInner = true;
		}
	}

	private void OnActorLeave(AActor OtherActor)
	{
		if (!(OtherActor != LocalPlayerShareData.FirstLocalPlayerPawn))
		{
			AreaData.LocalPlayerInner = false;
		}
	}

	private void UpdateDebugInfo()
	{
		if (DebugConfig.BPNeutralAnimalDebug)
		{
			if (AreaData.HasAnimalSpawned)
			{
				FSlateColor green = B1GlobalFSlateColor.Green;
				base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("BPNeutralAnimalDebug", green);
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("BPNeutralAnimalDebug", "已生成");
				int curAreaBPAnimalNum = SpawnMgrData.GetCurAreaBPAnimalNum(GuidData.GetFinalGuid());
				base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "当前区域内生物数量", $"{curAreaBPAnimalNum}");
			}
			else
			{
				FSlateColor red = B1GlobalFSlateColor.Red;
				base.BUSEventCollection.Evt_UpdateDebugUILamp.Invoke("BPNeutralAnimalDebug", red);
				base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("BPNeutralAnimalDebug", "未生成");
				base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "当前区域内生物数量", "0");
			}
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "玩家在区域内", $"{AreaData.LocalPlayerInner}");
			float timeSeconds = UnrealGameplayData.GetTimeSeconds();
			float num = FMath.Max(AreaData.LastEnterTriggerAreaTime + AreaData.PresetCD - timeSeconds, 0f);
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "进入区域后预置CD", $"{num:F2}");
			float num2 = ((AreaData.SpawnCD > 0f) ? AreaData.SpawnCD : 10f);
			float num3 = FMath.Max(AreaData.LastSpawnTime + num2 - timeSeconds, 0f);
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "刷新CD", $"{num3:F2}");
			float num4 = ((AreaData.DestroyProtectCD > 0f) ? AreaData.DestroyProtectCD : 10f);
			float num5 = FMath.Max(AreaData.AnimalAllDeadTime + num4 - timeSeconds, 0f);
			base.BUSEventCollection.Evt_UpdateDebugUIKeyValuePair.Invoke("BPNeutralAnimalDebug", "单位全部死亡保护CD", $"{num5:F2}");
		}
	}
}
