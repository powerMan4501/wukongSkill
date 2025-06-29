using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_NeutralAnimalSpawnMgr : GameStateSystemBase
{
	private static string SplineBirdSpawnConfigPath = "BGWDataAsset_SplineBirdSpawnConfig'/Game/00Main/DataAsset/SplineBird/DA_SplineBirdSpawnConfig.DA_SplineBirdSpawnConfig'";

	private BGC_NeutralAnimalSpawnMgrData SpawnMgrData { get; set; }

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData { get; set; }

	private IBGC_SummonData SummonManagerData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	public override void OnAttach()
	{
		SpawnMgrData = RequireWritableData<BGC_NeutralAnimalSpawnMgrData>();
		LocalPlayerSharedData = RequireReadOnlyData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		SummonManagerData = RequireReadOnlyData<IBGC_SummonData, BGC_SummonData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		base.BGSEventCollection.Evt_BGS_OnCloudMoveBegin += new Del_Void(OnCloudMoveBegin);
		base.BGSEventCollection.Evt_BGS_OnCloudMoveEnded += new Del_Void(OnCloudMoveEnded);
		base.BGSEventCollection.Evt_OnRegistTreeFXAnimalInfo += new Del_OnRegistTreeFXAnimalInfo(OnRegistTreeFXAnimalInfo);
		base.BGSEventCollection.Evt_BGS_OnFXAnimalDisappear += new Del_Void_Actor(OnFXAnimalDisappear);
		base.BGSEventCollection.Evt_BGS_ReqSpawnAnimals += new Del_Void_ReqSpawnAnimals(ReqSpawnAnimals);
		base.BGSEventCollection.Evt_NotifyMovieBegin += new Del_Void_IntInt(OnMovieBegin);
	}

	public override void OnBeginPlay()
	{
		ScanAllSplineActorWithTag();
		SpawnMgrData.InitBPAnimalOPTConfig();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		Tick_TreeSpawnFXAnimalLogic(DeltaTime);
		RefreshSpawnSplineBirdTick(DeltaTime);
		BPAnimalOverDistCheck(DeltaTime);
	}

	private void OnCloudMoveBegin()
	{
		SpawnMgrData.bCloudMoveFlag = true;
	}

	private void OnCloudMoveEnded()
	{
		SpawnMgrData.bCloudMoveFlag = false;
	}

	private void OnRegistTreeFXAnimalInfo(List<FTreeInfo> TreeArray, FTreeBirdSpawnConfig SpawnConfig)
	{
		SpawnMgrData.TreeBirdSpawnConfig = SpawnConfig;
		SpawnMgrData.TreeArray.Clear();
		SpawnMgrData.TreeArray.AddRange(TreeArray);
		SpawnMgrData.Timer_TreeBird = SpawnMgrData.TreeBirdSpawnConfig.SpawnCheckInterval;
	}

	private void Tick_TreeSpawnFXAnimalLogic(float DeltaTime)
	{
		if (!SpawnMgrData.bCloudMoveFlag || SpawnMgrData.TreeBirdSpawnConfig.SpawnTemplate == null || !(SpawnMgrData.Timer_TreeBird > 0f))
		{
			return;
		}
		SpawnMgrData.Timer_TreeBird -= DeltaTime;
		if (SpawnMgrData.Timer_TreeBird <= 0f)
		{
			if (FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, SpawnMgrData.LastRefreshTreePos) >= SpawnMgrData.TreeBirdSpawnConfig.RefreshDistance)
			{
				DoSpawnFXAnimalsOnTree();
			}
			SpawnMgrData.Timer_TreeBird = SpawnMgrData.TreeBirdSpawnConfig.SpawnCheckInterval;
			SpawnMgrData.LastRefreshTreePos = LocalPlayerSharedData.CachedLocalPlayerLocation;
		}
	}

	private void DoSpawnFXAnimalsOnTree()
	{
		UClass value = SpawnMgrData.TreeBirdSpawnConfig.SpawnTemplate.Value;
		DestroyOverDistTreeBirdSpawnners();
		List<FTreeInfo> list = SelectTreeByRule();
		int num = MathLib.RandomIntInRange(SpawnMgrData.TreeBirdSpawnConfig.SpawnNum.GetLowerBoundValue(), SpawnMgrData.TreeBirdSpawnConfig.SpawnNum.GetUpperBoundValue());
		num -= SpawnMgrData.TreeBirdSpawnnerList.Count;
		while (num > 0 && list.Count != 0)
		{
			int index = MathLib.RandomIntInRange(0, list.Count - 1);
			FTreeInfo fTreeInfo = list[index];
			AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Owner.World, value, in fTreeInfo.Pos, in fTreeInfo.Rot);
			BUS_EventCollectionCS.Get(aActor)?.Evt_NeutralFXAnimalSpawnAreaInitSize.Invoke(fTreeInfo.Bounds_WithScaled);
			SpawnMgrData.TreeBirdSpawnnerList.Add(aActor);
			list.RemoveAt(index);
			num--;
		}
	}

	private void DestroyOverDistTreeBirdSpawnners()
	{
		for (int i = 0; i < SpawnMgrData.TreeBirdSpawnnerList.Count; i++)
		{
			AActor aActor = SpawnMgrData.TreeBirdSpawnnerList[i];
			if (aActor.IsNullOrDestroyed())
			{
				SpawnMgrData.TreeBirdSpawnnerList.RemoveAt(i);
				i--;
				continue;
			}
			FVector actorLocation = aActor.GetActorLocation();
			if (FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, actorLocation) >= SpawnMgrData.TreeBirdSpawnConfig.DestroyDist)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_DestroyNeutralFXAnimalSpawnner.Invoke();
				SpawnMgrData.TreeBirdSpawnnerList.RemoveAt(i);
				i--;
			}
		}
	}

	private List<FTreeInfo> SelectTreeByRule()
	{
		List<FTreeInfo> list = new List<FTreeInfo>();
		FVector actorForwardVector = LocalPlayerSharedData.FirstLocalPlayerPawn.GetActorForwardVector();
		float num = LocalPlayerSharedData.FirstLocalPlayerPawn.GetVelocity().Size2D();
		foreach (FTreeInfo item in SpawnMgrData.TreeArray)
		{
			FVector bounds_WithScaled = item.Bounds_WithScaled;
			float x = bounds_WithScaled.X;
			bounds_WithScaled = item.Bounds_WithScaled;
			float num2 = FMath.Max(x, bounds_WithScaled.Y);
			float num3 = FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, item.Pos);
			if (!(num3 >= SpawnMgrData.TreeBirdSpawnConfig.InnerRadius + num2) || !(num3 <= SpawnMgrData.TreeBirdSpawnConfig.OutRadius - num2))
			{
				continue;
			}
			if (num >= SpawnMgrData.TreeBirdSpawnConfig.PlayerSpdControl)
			{
				FVector fVector = item.Pos - LocalPlayerSharedData.CachedLocalPlayerLocation;
				fVector.Z = 0f;
				if (FMath.Abs(UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D())) > SpawnMgrData.TreeBirdSpawnConfig.SprintSpawnAreaAngle / 2f)
				{
					continue;
				}
			}
			list.Add(item);
		}
		return list;
	}

	private void InitSplineBirdSpawnConfig()
	{
		SpawnMgrData.SplineBirdSpawnConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_SplineBirdSpawnConfig>(SplineBirdSpawnConfigPath, ELoadResourceType.SyncLoadAndCache);
		if (!(SpawnMgrData.SplineBirdSpawnConfig == null))
		{
			SpawnMgrData.IsSplineBirdSpawnConfigSetted = true;
			SpawnMgrData.SplineBirdRefreshCoolDown = SpawnMgrData.SplineBirdSpawnConfig.GlobalRefreshCoolDown;
		}
	}

	private void ScanAllSplineActorWithTag()
	{
		Owner.World.GetAllActorsOfClassWithTag(UClass.GetClass<BGUSimpleSplineActor>(), B1GlobalFNames.FlyBirdSpline, out var OutActors);
		foreach (AActor item2 in OutActors)
		{
			BGUSimpleSplineActor bGUSimpleSplineActor = item2 as BGUSimpleSplineActor;
			if (!bGUSimpleSplineActor.IsNullOrDestroyed())
			{
				FSplineInfo item = new FSplineInfo
				{
					SplineActor = bGUSimpleSplineActor
				};
				string actorGuid = BGU_DataUtil.GetActorGuid(bGUSimpleSplineActor);
				item.Guid = actorGuid;
				item.SplineStart = bGUSimpleSplineActor.SplineComp.GetLocationAtDistanceAlongSpline(0f, ESplineCoordinateSpace.World);
				SpawnMgrData.SplineArray.Add(item);
			}
		}
	}

	private void RefreshSpawnSplineBirdTick(float DeltaTime)
	{
		if (SpawnMgrData.SplineArray.Count < 1)
		{
			return;
		}
		if (!SpawnMgrData.IsSplineBirdSpawnConfigSetted)
		{
			InitSplineBirdSpawnConfig();
		}
		if (!SpawnMgrData.IsSplineBirdSpawnConfigSetted)
		{
			return;
		}
		SpawnMgrData.SplineBirdRefreshCoolDown -= DeltaTime;
		if (SpawnMgrData.SplineBirdRefreshCoolDown > 0f)
		{
			return;
		}
		SpawnMgrData.SplineBirdRefreshCoolDown = SpawnMgrData.SplineBirdSpawnConfig.GlobalRefreshCoolDown;
		if (SpawnMgrData.CurActiveSplineBirdArray.Count >= SpawnMgrData.SplineBirdSpawnConfig.MaxCoutInWorld)
		{
			return;
		}
		float gameTimeInSeconds = Owner.World.GetGameTimeInSeconds();
		float lowerBoundValue = SpawnMgrData.SplineBirdSpawnConfig.SplineFilterDist.GetLowerBoundValue();
		float upperBoundValue = SpawnMgrData.SplineBirdSpawnConfig.SplineFilterDist.GetUpperBoundValue();
		List<FSplineInfo> list = new List<FSplineInfo>();
		foreach (FSplineInfo item in SpawnMgrData.SplineArray)
		{
			if (SpawnMgrData.SplineTriggerTimeCached.ContainsKey(item.Guid))
			{
				float num = SpawnMgrData.SplineTriggerTimeCached[item.Guid];
				if (gameTimeInSeconds - num < SpawnMgrData.SplineBirdSpawnConfig.SplineUseProtectTime)
				{
					continue;
				}
			}
			float num2 = FVector.Dist2D(LocalPlayerSharedData.CachedLocalPlayerLocation, item.SplineStart);
			if (!(num2 < lowerBoundValue) && !(num2 > upperBoundValue))
			{
				list.Add(item);
			}
		}
		if (list.Count >= 1)
		{
			int index = MathLib.RandomIntInRange(0, list.Count - 1);
			FSplineInfo selectedSplineInfo = list[index];
			SpawnSplineBird(selectedSplineInfo);
			if (SpawnMgrData.SplineTriggerTimeCached.ContainsKey(selectedSplineInfo.Guid))
			{
				SpawnMgrData.SplineTriggerTimeCached[selectedSplineInfo.Guid] = gameTimeInSeconds;
			}
			else
			{
				SpawnMgrData.SplineTriggerTimeCached.Add(selectedSplineInfo.Guid, gameTimeInSeconds);
			}
		}
	}

	private void SpawnSplineBird(FSplineInfo SelectedSplineInfo)
	{
		if (SelectedSplineInfo.SplineActor == null)
		{
			return;
		}
		FName key = FName.None;
		if (SelectedSplineInfo.SplineActor.Tags.Count > 1)
		{
			key = SelectedSplineInfo.SplineActor.Tags[1];
		}
		if (SpawnMgrData.SplineBirdSpawnConfig.FXAnimalTemplateMap.TryGetValue(key, out var value))
		{
			if (value == null)
			{
				return;
			}
			FRotator Rotation = SelectedSplineInfo.SplineActor.GetActorRotation();
			AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Owner.World, value.Value, in SelectedSplineInfo.SplineStart, in Rotation);
			if (aActor != null)
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_FXAnimalBeginMoveWithSpline.Invoke(SelectedSplineInfo.SplineActor.SplineComp);
				SpawnMgrData.CurActiveSplineBirdArray.Add(aActor);
			}
		}
		_ = SpawnMgrData.SplineBirdSpawnConfig.FXAnimalTemplateList.Count;
		_ = 1;
	}

	private void OnFXAnimalDisappear(AActor DisappearActor)
	{
		SpawnMgrData.CurActiveSplineBirdArray.Remove(DisappearActor);
	}

	private void ReqSpawnAnimals(FNeutralAnimalSpawnReq SpawnReq)
	{
		SpawnMgrData.bLastBPAnimalSpawnReqSuccess = false;
		int num = FMath.Min3(SpawnReq.DesireSpawnCount, SpawnReq.SpawnPosList.Count, SpawnMgrData.GetBPRemainSpawnSize());
		if (num < 1)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, SpawnReq.AreaGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			bool flag = SpawnMgrData.AreaAnimalsMap.Count == 0;
			int i = 0;
			FCalliopeGuid summonGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
			for (; i < num; i++)
			{
				SpawnOneAnimal(actorByGuid, SpawnReq.AreaGuid, SpawnReq.TamerTemplate, SpawnReq.SpawnPosList[i], SpawnReq.ScaleRange, summonGuid);
			}
			if (SpawnReq.DestroyAllAnimalWhenPlaySeq && !SpawnMgrData.AreaGuidList_NeedDestroyIntoSeq.Contains(SpawnReq.AreaGuid))
			{
				SpawnMgrData.AreaGuidList_NeedDestroyIntoSeq.Add(SpawnReq.AreaGuid);
			}
			if (flag && SpawnMgrData.AreaAnimalsMap.Count > 0)
			{
				base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnAnimalDead);
			}
			SpawnMgrData.bLastBPAnimalSpawnReqSuccess = true;
		}
	}

	private void OnAnimalDead(string AnimalGUID, EDeadReason InDeadReason)
	{
		string text = string.Empty;
		foreach (KeyValuePair<string, List<string>> item in SpawnMgrData.AreaAnimalsMap)
		{
			if (item.Value.Contains(AnimalGUID))
			{
				text = item.Key;
				break;
			}
		}
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		SpawnMgrData.AreaAnimalsMap[text].Remove(AnimalGUID);
		if (SpawnMgrData.AreaAnimalsMap[text].Count == 0)
		{
			SpawnMgrData.AreaAnimalsMap.Remove(text);
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, text);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(actorByGuid)?.Evt_OnAreaAnimalAllDead.Invoke();
			}
		}
		if (SpawnMgrData.AreaAnimalsMap.Count == 0)
		{
			base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnAnimalDead);
		}
	}

	private void SpawnOneAnimal(AActor SpawnArea, string AreaGuid, TSubclassOf<BUTamerActor> AnimalTemplate, FVector InLocation, FFloatRange ScaleRange, FCalliopeGuid _SummonGuid)
	{
		FSummonSpawnConfigWrap spawnConfigWrap = new FSummonSpawnConfigWrap
		{
			SummonAliveTime = -1f,
			TamerTemplate = AnimalTemplate.Value,
			SummonUnitLocationType = ESummonUnitLocationType.UseEffectPos,
			SummonUnitRotationType = ESummonUnitRotationType.UseSpawnPointRot,
			SpawnScaleRange = ScaleRange
		};
		FRotator zeroRotator = FRotator.ZeroRotator;
		zeroRotator.Yaw = MathLib.RandomFloatInRange(0f, 360f);
		spawnConfigWrap.SearchTargetType = EServantSearchTargetType.ByPerception;
		spawnConfigWrap.SafeClampToLand = true;
		FSummonReq inSummonReq = new FSummonReq
		{
			SummonType = ESummonType.NeutralAnimSpawn,
			SpawnConfigWrap = spawnConfigWrap,
			Summoner = SpawnArea,
			SummonGuid = _SummonGuid,
			HitLocation = InLocation,
			SpawnPointRot = zeroRotator
		};
		BPS_EventCollectionCS.GetLocal(Owner).Evt_RequestSummon.Invoke(inSummonReq);
		string item = string.Empty;
		SummonManagerData.GetSummonInstancesBySummoner(AreaGuid, out var OutSummonInstances);
		if (OutSummonInstances.Count > 0)
		{
			int count = OutSummonInstances[OutSummonInstances.Count - 1].ServantReqList.Count;
			if (count > 0)
			{
				item = OutSummonInstances[OutSummonInstances.Count - 1].ServantReqList[count - 1].ServantTamerGuid;
			}
		}
		if (SpawnMgrData.AreaAnimalsMap.ContainsKey(AreaGuid))
		{
			SpawnMgrData.AreaAnimalsMap[AreaGuid].Add(item);
			return;
		}
		List<string> list = new List<string>();
		list.Add(item);
		SpawnMgrData.AreaAnimalsMap.Add(AreaGuid, list);
	}

	private void OnMovieBegin(int SeqID, int UniqueID)
	{
		List<string> list = new List<string>();
		foreach (string item in SpawnMgrData.AreaGuidList_NeedDestroyIntoSeq)
		{
			if (!SpawnMgrData.AreaAnimalsMap.TryGetValue(item, out var value))
			{
				continue;
			}
			foreach (string item2 in value)
			{
				list.Add(item2);
			}
		}
		foreach (string item3 in list)
		{
			BGU_UnrealWorldUtil.RequestDestroyUnit(Owner, item3);
		}
	}

	private void BPAnimalGlobleCountControl()
	{
	}

	private void BPAnimalOverDistCheck(float DeltaTime)
	{
		if (SpawnMgrData.AreaAnimalsMap == null || SpawnMgrData.AreaAnimalsMap.Count < 1)
		{
			return;
		}
		if (SpawnMgrData.DistCheck_Queue.Count > 0)
		{
			SpawnMgrData.DistCheck_IntervalTimer -= DeltaTime;
			while (SpawnMgrData.DistCheck_IntervalTimer < 0f && SpawnMgrData.DistCheck_Queue.Count != 0)
			{
				SpawnMgrData.DistCheck_IntervalTimer += SpawnMgrData.DISTCHECK_INTERVAL;
				string text = SpawnMgrData.DistCheck_Queue.Dequeue();
				if (GlobalActorData == null || !GlobalActorData.GetActorEntity(text, out var Entity))
				{
					continue;
				}
				AActor aActor = ECSUtil.ToActor(Entity);
				if (aActor.IsNullOrDestroyed() || !(FVector.Dist(aActor.GetActorLocation(), LocalPlayerSharedData.CachedLocalPlayerLocation) >= SpawnMgrData.DISTCHECK_DISTLIMIT))
				{
					continue;
				}
				string text2 = string.Empty;
				foreach (KeyValuePair<string, List<string>> item in SpawnMgrData.AreaAnimalsMap)
				{
					if (item.Value.Contains(text))
					{
						text2 = item.Key;
						break;
					}
				}
				if (string.IsNullOrEmpty(text2))
				{
					continue;
				}
				SummonManagerData.GetSummonInstancesBySummoner(text2, out var OutSummonInstances);
				foreach (FSummonInstance item2 in OutSummonInstances)
				{
					bool flag = false;
					foreach (FServantInstanceBase servantInstance in item2.ServantInstances)
					{
						TWeakObject<BGUCharacterCS> monsterInstancePtr = servantInstance.ServantTamerRef.MonsterInstancePtr;
						if (monsterInstancePtr.IsValid() && monsterInstancePtr.Get() == aActor)
						{
							servantInstance.Recall();
							flag = true;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
			return;
		}
		foreach (KeyValuePair<string, List<string>> item3 in SpawnMgrData.AreaAnimalsMap)
		{
			foreach (string item4 in item3.Value)
			{
				SpawnMgrData.DistCheck_Queue.Enqueue(item4);
			}
		}
	}
}
