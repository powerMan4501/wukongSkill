using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SpawnMultiPointCompImpl : BUS_TriggerBaseComp
{
	[UClass]
	[USharpPath("/Script/b1-Managed.SpawnMultiPointCompFunctionBinder")]
	protected class USpawnMultiPointCompFunctionBinder : UObject
	{
		private b1.BUS_SpawnMultiPointCompImpl OwnerComp;

		private static bool OnReplenish_IsValid;

		private static IntPtr OnReplenish_FunctionAddress;

		private static int OnReplenish_ParamsSize;

		public void Init(b1.BUS_SpawnMultiPointCompImpl Component)
		{
			OwnerComp = Component;
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.SpawnMultiPointCompFunctionBinder:OnReplenish")]
		public void OnReplenish()
		{
			if (OwnerComp != null)
			{
				OwnerComp.OnReplenish();
			}
		}

		[UFunctionInvoker("/Script/b1-Managed.SpawnMultiPointCompFunctionBinder:OnReplenish")]
		private static void OnReplenish__Invoker(IntPtr buffer, IntPtr obj)
		{
			USpawnMultiPointCompFunctionBinder uSpawnMultiPointCompFunctionBinder = GCHelper.Find<USpawnMultiPointCompFunctionBinder>(obj);
			uSpawnMultiPointCompFunctionBinder.OnReplenish();
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.SpawnMultiPointCompFunctionBinder");
			OnReplenish_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnReplenish");
			OnReplenish_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReplenish_FunctionAddress);
			OnReplenish_IsValid = OnReplenish_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.SpawnMultiPointCompFunctionBinder:OnReplenish", OnReplenish_IsValid);
		}

		static USpawnMultiPointCompFunctionBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(USpawnMultiPointCompFunctionBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(USpawnMultiPointCompFunctionBinder));
		}
	}

	private IBGC_LevelBattleData LevelBattleData;

	private IBGC_SummonData SummonManagerData;

	private TStrongObjectPtr<USpawnMultiPointCompFunctionBinder> mFunctionBinder = new TStrongObjectPtr<USpawnMultiPointCompFunctionBinder>();

	protected BUC_SpawnMultiPointData SpawnMultiPointData { get; set; }

	protected USpawnMultiPointCompFunctionBinder FunctionBinder
	{
		get
		{
			return mFunctionBinder.Get();
		}
		set
		{
			mFunctionBinder.Set(value);
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		SpawnMultiPointData = RequireWritableData<BUC_SpawnMultiPointData>();
		LevelBattleData = RequireReadOnlyGameStateData<IBGC_LevelBattleData, BGC_LevelBattleData>();
		SummonManagerData = RequireReadOnlyGameStateData<IBGC_SummonData, BGC_SummonData>();
		base.InitialState = (SpawnMultiPointData.bDefaultStartSpawn ? base.State_Triggered : base.State_UnTriggered);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		base.BUSEventCollection.Evt_OnWeaponSceneItemBeAttached += new Del_Void_Actor(OnWeaponSceneItemBeAttached);
		FunctionBinder = UObject.NewObject<USpawnMultiPointCompFunctionBinder>(base.Owner);
		FunctionBinder.Init(this);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		for (int i = 0; i < SpawnMultiPointData.PointNum; i++)
		{
			SpawnMultiPointData.UnSpawnedIndexes.Add(i);
		}
		for (int j = 0; j < SpawnMultiPointData.SpawnActorList.Count; j++)
		{
			SpawnMultiPointData.SpawnedPool.Add(j, 0);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
		FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
		if (fTimerManager != null)
		{
			if (SpawnMultiPointData.ReSpawnTestTimer.IsValid)
			{
				fTimerManager.ClearTimer(ref SpawnMultiPointData.ReSpawnTestTimer);
				SpawnMultiPointData.ReSpawnTestTimer.Invalidate();
			}
			base.OnEndPlay(EndPlayReason);
		}
	}

	private void OnWeaponSceneItemBeAttached(AActor Actor)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Actor);
		FSpawnActorInfo fSpawnActorInfo = ExtendDic.FindByActorGuid(SpawnMultiPointData.SpawnActorInfos, actorGuid);
		if (fSpawnActorInfo != null)
		{
			int pointsIndex = fSpawnActorInfo.PointsIndex;
			SpawnMultiPointData.UnSpawnedIndexes.Add(pointsIndex);
			SpawnMultiPointData.SpawnedIndexes.Remove(pointsIndex);
			SpawnMultiPointData.SpawnActorInfos.Remove(fSpawnActorInfo);
			SpawnMultiPointData.CurrentUnitNum--;
			SpawnMultiPointData.SpawnedPool[fSpawnActorInfo.ActorsIndex]--;
		}
		BGU_UnrealWorldUtil.DestroyActor(Actor);
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		FSpawnActorInfo fSpawnActorInfo = ExtendDic.FindByActorGuid(SpawnMultiPointData.SpawnActorInfos, InUnitGuid);
		if (fSpawnActorInfo != null)
		{
			int pointsIndex = fSpawnActorInfo.PointsIndex;
			SpawnMultiPointData.UnSpawnedIndexes.Add(pointsIndex);
			SpawnMultiPointData.SpawnedIndexes.Remove(pointsIndex);
			SpawnMultiPointData.SpawnActorInfos.Remove(fSpawnActorInfo);
			SpawnMultiPointData.CurrentUnitNum--;
			SpawnMultiPointData.SpawnedPool[fSpawnActorInfo.ActorsIndex]--;
		}
	}

	private void RefreshOnlineData()
	{
		if (LevelBattleData != null)
		{
			if (LevelBattleData.GetGamePlayerNum() > 1)
			{
				SpawnMultiPointData.SpawnMaxNum = SpawnMultiPointData.SpawnMaxNumOnline;
				SpawnMultiPointData.LowerLimitNum = SpawnMultiPointData.LowerLimitNumOnline;
				SpawnMultiPointData.ReSpawnLimit = SpawnMultiPointData.ReSpawnLimitOnline;
			}
			else
			{
				SpawnMultiPointData.SpawnMaxNum = SpawnMultiPointData.SpawnMaxNumAlone;
				SpawnMultiPointData.LowerLimitNum = SpawnMultiPointData.LowerLimitNumAlone;
				SpawnMultiPointData.ReSpawnLimit = SpawnMultiPointData.ReSpawnLimitAlone;
			}
		}
	}

	protected void SpawnUnits(int SpawnNum)
	{
		if (SpawnNum <= 0)
		{
			return;
		}
		int num = SpawnMultiPointData.SpawnPoints.Length;
		if (SpawnNum == num)
		{
			for (int i = 0; i < SpawnMultiPointData.PointNum; i++)
			{
				SpawnUnitInIndexOfSpawnPoint(i);
			}
		}
		else if (SpawnNum < num)
		{
			int count = SpawnMultiPointData.UnSpawnedIndexes.Count;
			if (SpawnNum == count)
			{
				foreach (int unSpawnedIndex in SpawnMultiPointData.UnSpawnedIndexes)
				{
					SpawnUnitInIndexOfSpawnPoint(unSpawnedIndex);
					SpawnMultiPointData.SpawnedIndexes.Add(unSpawnedIndex);
				}
				SpawnMultiPointData.UnSpawnedIndexes.Clear();
			}
			else if (SpawnNum < count)
			{
				for (int num2 = SpawnNum; num2 > 0; num2--)
				{
					int index = -1;
					if (SpawnMultiPointData.IsLRU)
					{
						index = 0;
					}
					if (SpawnMultiPointData.IsNotSpawnedInPlayerSight && FindRightIndex(out var RightIndex))
					{
						index = RightIndex;
					}
					else if (!SpawnMultiPointData.IsLRU && !SpawnMultiPointData.IsNotSpawnedInPlayerSight)
					{
						index = UB1Util.GetRandomNumberInt(0, SpawnMultiPointData.UnSpawnedIndexes.Count - 1);
					}
					_ = SpawnMultiPointData.UnSpawnedIndexes.Count;
					int num3 = SpawnMultiPointData.UnSpawnedIndexes[index];
					SpawnUnitInIndexOfSpawnPoint(num3);
					SpawnMultiPointData.UnSpawnedIndexes.Remove(num3);
					SpawnMultiPointData.SpawnedIndexes.Add(num3);
				}
			}
			else if (count > 0)
			{
				SpawnUnits(count);
				SpawnUnits(SpawnNum - count);
			}
		}
		else
		{
			while (SpawnNum > num)
			{
				SpawnUnits(num);
				SpawnNum -= num;
			}
		}
	}

	protected bool FindRightIndex(out int RightIndex)
	{
		RightIndex = 0;
		if (SpawnMultiPointData.UnSpawnedIndexes.Count == 0)
		{
			return false;
		}
		while (RightIndex != SpawnMultiPointData.UnSpawnedIndexes.Count)
		{
			if (UGSE_CameraUtilFuncLib.IsPositionInScreenViewport(base.Owner, SpawnMultiPointData.SpawnPoints[SpawnMultiPointData.UnSpawnedIndexes[RightIndex]]))
			{
				RightIndex++;
				continue;
			}
			return true;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn());
		float num = float.MinValue;
		for (int i = 0; i != SpawnMultiPointData.UnSpawnedIndexes.Count; i++)
		{
			FVector v2 = SpawnMultiPointData.SpawnPoints[SpawnMultiPointData.UnSpawnedIndexes[i]];
			float num2 = FVector.Distance(v, v2);
			if (num2 > num)
			{
				num = num2;
				RightIndex = i;
			}
		}
		return true;
	}

	protected void SpawnUnitInIndexOfSpawnPoint(int Index)
	{
		if (SpawnMultiPointData.SpawnActorList == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner).GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		FVector fVector = SpawnMultiPointData.SpawnPoints[Index] + FVector.UpVector * SpawnMultiPointData.SpawnHeight;
		if (UBGUFunctionLibrary.BGUNavigationRaycast(base.Owner, fVector, fVector + FVector.UpVector * 10000.0, out var HitLocation, null, bGUCharacterCS.GetController()))
		{
			fVector = HitLocation;
		}
		string text = null;
		int rightActorIndex = GetRightActorIndex();
		if (rightActorIndex < SpawnMultiPointData.SpawnActorList.Count && !(SpawnMultiPointData.SpawnActorList[rightActorIndex] == null))
		{
			FRotator bornRotator = FRotator.ZeroRotator;
			if (SpawnMultiPointData.UseSpawnPointsRot)
			{
				bornRotator = SpawnMultiPointData.SpawnPointsRot[Index];
			}
			switch (SpawnMultiPointData.SpawnType)
			{
			case ESpawnType.Character:
				text = SpawnUnit(rightActorIndex, bGUCharacterCS, fVector, bornRotator);
				break;
			case ESpawnType.Weapon:
				text = SpawnWeaponAndECSBeginPlay(rightActorIndex, bGUCharacterCS, fVector, bornRotator);
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				SpawnMultiPointData.SpawnActorInfos.Add(new FSpawnActorInfo(text, Index, rightActorIndex));
				SpawnMultiPointData.SpawnedPool[rightActorIndex]++;
				SpawnMultiPointData.CurrentUnitNum++;
			}
		}
	}

	private int GetRightActorIndex()
	{
		SpawnMultiPointData.SpawnedPool = SpawnMultiPointData.SpawnedPool.OrderBy((KeyValuePair<int, int> o) => o.Value).ToDictionary((KeyValuePair<int, int> o) => o.Key, (KeyValuePair<int, int> p) => p.Value);
		switch (SpawnMultiPointData.SpawnRule)
		{
		case ESpawnRule.Random:
			return UB1Util.GetRandomNumberInt(0, SpawnMultiPointData.SpawnedPool.Count - 1);
		case ESpawnRule.RandomLeast:
		{
			int count = SpawnMultiPointData.SpawnedPool.Count;
			int num = 0;
			for (List<int> list = SpawnMultiPointData.SpawnedPool.Values.ToList(); num < count - 1 && list[num] == list[num + 1]; num++)
			{
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, num);
			return SpawnMultiPointData.SpawnedPool.Keys.ToList()[randomNumberInt];
		}
		case ESpawnRule.First:
			return 0;
		default:
			return -1;
		}
	}

	private string SpawnWeaponAndECSBeginPlay(int Index, BGUCharacterCS Player, FVector BornLocation, FRotator BornRotator)
	{
		if (SpawnMultiPointData.SpawnActorList == null || Index >= SpawnMultiPointData.SpawnActorList.Count || SpawnMultiPointData.SpawnActorList[Index] == null)
		{
			return null;
		}
		BGUWeaponBase bGUWeaponBase = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Player.World, SpawnMultiPointData.SpawnActorList[Index].Value, in BornLocation, in FRotator.ZeroRotator) as BGUWeaponBase;
		if (bGUWeaponBase == null)
		{
			return null;
		}
		BGUSceneItemBase bGUSceneItemBase = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<BGUSceneItemBase>(Player.World);
		BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUSceneItemBase, BornLocation, bSweep: true, bTeleport: false);
		BGUFuncLibActorTransformCS.BGUSetActorRotation(bGUSceneItemBase, FRotator.ZeroRotator, bTeleportPhysics: false);
		bGUSceneItemBase.Tags.Add(SpawnMultiPointData.SpawnedTag);
		bGUWeaponBase.AttachToActor(bGUSceneItemBase, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
		base.BGSEventCollection.Evt_RegisterSceneItem.Invoke(bGUSceneItemBase);
		BUC_SceneItemCommData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(bGUSceneItemBase);
		readOnlyData.CopyBPDataToData(readOnlyData.TeleportTransform, BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUSceneItemBase), 0, _NeedClosePhysicWhenReset: false);
		return BGU_DataUtil.GetActorGuid(bGUWeaponBase);
	}

	private string SpawnUnitAndECSBeginPlay(int Index, BGUCharacterCS Player, FVector BornLocation, FRotator BornRotator)
	{
		if (SpawnMultiPointData.SpawnActorList == null || Index >= SpawnMultiPointData.SpawnActorList.Count || SpawnMultiPointData.SpawnActorList[Index] == null)
		{
			return null;
		}
		FTransform InTransform = new FTransform(BornRotator, BornLocation);
		return BGU_UnrealWorldUtil.RequestSpawnUnit(Player.World, SpawnMultiPointData.SpawnActorList[Index].Value, in InTransform, GetOwner(), SpawnMultiPointData.UnitSpawnInfoList[Index]);
	}

	private string SpawnUnit(int Index, BGUCharacterCS Player, FVector BornLocation, FRotator BornRotator)
	{
		if (SpawnMultiPointData.SpawnActorList == null || Index >= SpawnMultiPointData.SpawnActorList.Count || SpawnMultiPointData.SpawnActorList[Index] == null)
		{
			return null;
		}
		FUnitSpawnInfo fUnitSpawnInfo = SpawnMultiPointData.UnitSpawnInfoList[Index];
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, fUnitSpawnInfo.SpawnMasterGuid);
		FCalliopeGuid fCalliopeGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
		FSummonSpawnConfigWrap spawnConfigWrap = default(FSummonSpawnConfigWrap);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			spawnConfigWrap.IsSummonerAsMaster = true;
		}
		spawnConfigWrap.SummonAliveTime = -1f;
		spawnConfigWrap.TamerTemplate = SpawnMultiPointData.SpawnActorList[Index].Value;
		spawnConfigWrap.SummonUnitLocationType = ESummonUnitLocationType.UseEffectPos;
		spawnConfigWrap.SummonUnitRotationType = ESummonUnitRotationType.UseSpawnPointRot;
		spawnConfigWrap.SafeClampToLand = true;
		spawnConfigWrap.SearchTargetType = EServantSearchTargetType.ByPerception;
		if (fUnitSpawnInfo.bCatchPlayer)
		{
			spawnConfigWrap.SearchTargetType = EServantSearchTargetType.CatchPlayer;
		}
		else if (fUnitSpawnInfo.bSyncMasterTarget && actorByGuid != null)
		{
			spawnConfigWrap.SearchTargetType = EServantSearchTargetType.SyncMaster;
		}
		spawnConfigWrap.BornMontages = new List<UAnimMontage>();
		if (fUnitSpawnInfo.SpawnMontage != null)
		{
			spawnConfigWrap.BornMontages.Add(fUnitSpawnInfo.SpawnMontage);
		}
		spawnConfigWrap.SpawnBirthBuff = new List<int>();
		if (fUnitSpawnInfo.BirthBuff != null && fUnitSpawnInfo.BirthBuff.Count > 0)
		{
			spawnConfigWrap.SpawnBirthBuff.AddRange(fUnitSpawnInfo.BirthBuff);
		}
		string summonerGuid = ((actorByGuid == null) ? base.GuidData.GetFinalGuid() : fUnitSpawnInfo.SpawnMasterGuid);
		FSummonReq inSummonReq = new FSummonReq
		{
			SummonType = ESummonType.MonsterSpawn,
			SummonGuid = fCalliopeGuid,
			SpawnConfigWrap = spawnConfigWrap,
			Summoner = ((actorByGuid == null) ? base.Owner : actorByGuid),
			HitLocation = BornLocation,
			SpawnPointRot = BornRotator
		};
		BPS_EventCollectionCS.GetLocal(base.Owner).Evt_RequestSummon.Invoke(inSummonReq);
		SummonManagerData.GetSummonInstancesBySummoner(summonerGuid, out var OutSummonInstances);
		foreach (FSummonInstance item in OutSummonInstances)
		{
			if (item.SummonInstanceID.Equals(fCalliopeGuid))
			{
				return item.ServantReqList[0].ServantTamerGuid;
			}
		}
		return null;
	}

	public override void OnEnter_TriggeredEvent()
	{
		FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
		if (fTimerManager != null && !SpawnMultiPointData.ReSpawnTestTimer.IsValid)
		{
			SpawnMultiPointData.ReSpawnTestTimer = fTimerManager.SetTimer(FunctionBinder, "OnReplenish", SpawnMultiPointData.ReSpawnTestInterval, looping: true);
		}
	}

	public override void OnRecover_TriggeredEvent()
	{
		OnResetSpawnMultiPointData();
	}

	public override void OnInitial_TriggeredEvent()
	{
		OnResetSpawnMultiPointData();
	}

	public void OnResetSpawnMultiPointData()
	{
		SpawnMultiPointData.HasSpawn = false;
		SpawnMultiPointData.CurrentUnitNum = 0;
		SpawnMultiPointData.SpawnedIndexes.Clear();
		SpawnMultiPointData.UnSpawnedIndexes.Clear();
		for (int i = 0; i < SpawnMultiPointData.PointNum; i++)
		{
			SpawnMultiPointData.UnSpawnedIndexes.Add(i);
		}
		for (int j = 0; j < SpawnMultiPointData.SpawnActorList.Count; j++)
		{
			if (SpawnMultiPointData.SpawnedPool.ContainsKey(j))
			{
				SpawnMultiPointData.SpawnedPool[j] = 0;
			}
		}
	}

	public void OnReplenish()
	{
		if (IsOnline())
		{
			RefreshOnlineData();
		}
		if (SpawnMultiPointData.SpawnActorList.Count > 0)
		{
			if (SpawnMultiPointData.CurrentUnitNum < SpawnMultiPointData.ReSpawnThreshold)
			{
				SpawnMultiPointData.bReplenish = true;
			}
			if (SpawnMultiPointData.bReplenish)
			{
				int val = SpawnMultiPointData.SpawnMaxNum - SpawnMultiPointData.CurrentUnitNum;
				SpawnUnits(FMath.Min(val, SpawnMultiPointData.ReSpawnLimit));
			}
			if (SpawnMultiPointData.CurrentUnitNum >= SpawnMultiPointData.SpawnMaxNum)
			{
				SpawnMultiPointData.bReplenish = false;
			}
		}
	}

	public override void OnEnter_UnTriggeredEvent()
	{
		(FTimerManager.PIEWorld ?? FTimerManager.GameInstance)?.ClearTimer(ref SpawnMultiPointData.ReSpawnTestTimer);
	}

	public override bool CanReTrigger()
	{
		return true;
	}
}
