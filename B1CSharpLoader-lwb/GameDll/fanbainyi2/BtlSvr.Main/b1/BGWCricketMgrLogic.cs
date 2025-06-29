using System.Collections.Generic;
using b1.BGW;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

public static class BGWCricketMgrLogic
{
	public static bool CheckDPSAutoStr()
	{
		bool result = true;
		string[] array = BGW_CricketBattleMgr.DPSAutoStr.Split('\n');
		int num = 0;
		int num2 = 0;
		float num3 = 0f;
		float num4 = 0f;
		int num5 = 0;
		string[] array2 = array;
		foreach (string obj in array2)
		{
			if (obj.Contains("添加异常状态"))
			{
				num++;
			}
			if (obj.Contains("移除异常状态"))
			{
				num2++;
			}
			if (obj.Contains("开始时间"))
			{
				num3 = StringParseHelper.SafeFloatParse(array[num5 + 1]);
			}
			if (obj.Contains("结束时间"))
			{
				num4 = StringParseHelper.SafeFloatParse(array[num5 + 1]);
			}
			num5++;
		}
		if (num2 != num)
		{
			result = false;
		}
		if (num4 - num3 > 180f)
		{
			result = false;
		}
		return result;
	}

	public static void AddStartBattleStr(int TargetID, float TestTime, List<int> UnitList)
	{
		BGW_CricketBattleMgr.DPSAutoStr = $"开启战斗   开始时间：\n{TestTime}\n";
		if (UnitList != null && UnitList.Count > 0)
		{
			foreach (int Unit in UnitList)
			{
				BGW_CricketBattleMgr.DPSAutoStr += $"{Unit}";
			}
			return;
		}
		BGW_CricketBattleMgr.DPSAutoStr += $"{TargetID}";
	}

	public static void ExcpetionReportAndReStart(UObject WorldContext, string Ex)
	{
	}

	public static void AddSimpleStateSetStr(EBGUSimpleState SimpleState, bool IsRemove, AActor TargetActor, float CurTime)
	{
		if (SimpleState == EBGUSimpleState.ImmueDamage)
		{
			BGUCharacterCS bGUCharacterCS = TargetActor as BGUCharacterCS;
			string text = (IsRemove ? "移除" : "添加");
			BGW_CricketBattleMgr.DPSAutoStr += $"{text}异常状态：{SimpleState}\n{bGUCharacterCS.GetFinalBattleInfoExtendID()}\n{CurTime}\n";
		}
	}

	public static void AddEndBattleStr(float TestTime)
	{
		BGW_CricketBattleMgr.DPSAutoStr = $"结束战斗   结束时间：\n{TestTime}\n";
	}

	public static void ReClcCricketBattleUnitAttr(BUC_AttrContainer AttrContainer, AActor TargetActor)
	{
		CricketUnitAttrDesc cricketUnitAttrDescByExtendId = GameDBRuntime.GetCricketUnitAttrDescByExtendId((TargetActor as BGUCharacterCS).GetFinalBattleInfoExtendID());
		if (cricketUnitAttrDescByExtendId != null)
		{
			AttrContainer.SetFloatValue(EBGUAttrFloat.HpMaxBase, cricketUnitAttrDescByExtendId.HpBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.AtkBase, cricketUnitAttrDescByExtendId.AtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DefBase, cricketUnitAttrDescByExtendId.DefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritRateBase, cricketUnitAttrDescByExtendId.CritRateBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritMultiplierBase, cricketUnitAttrDescByExtendId.CritMultiplierBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritRateDefBase, cricketUnitAttrDescByExtendId.CritRateDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.CritDmgMulDefBase, cricketUnitAttrDescByExtendId.CritDmgMulDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DmgAdditionBase, cricketUnitAttrDescByExtendId.DmgAdditionBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DmgDefBase, cricketUnitAttrDescByExtendId.DmgDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeAtkBase, cricketUnitAttrDescByExtendId.FreezeAtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnAtkBase, cricketUnitAttrDescByExtendId.BurnAtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonAtkBase, cricketUnitAttrDescByExtendId.PoisonAtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderAtkBase, cricketUnitAttrDescByExtendId.ThunderAtkBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.FreezeDefBase, cricketUnitAttrDescByExtendId.FreezeDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.BurnDefBase, cricketUnitAttrDescByExtendId.BurnDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.PoisonDefBase, cricketUnitAttrDescByExtendId.PoisonDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.ThunderDefBase, cricketUnitAttrDescByExtendId.ThunderDefBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.TenacityBase, cricketUnitAttrDescByExtendId.TenacityBase);
			AttrContainer.SetFloatValue(EBGUAttrFloat.HpMaxMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.AtkMul, 0f);
			AttrContainer.SetFloatValue(EBGUAttrFloat.DefMul, 0f);
		}
	}

	public static int GetExtendIdInComp(BGUCharacterCS Character)
	{
		BUTamerActor obj = Character.GetTamerOwner() as BUTamerActor;
		int resID = obj.ConfigInfoComp.UnitCDesc.ResID;
		int overrideID = obj.ConfigInfoComp.UnitCDesc.OverrideID;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
		if (overrideID <= 0)
		{
			return unitCommDesc.DefaultBattleInfoExtendID;
		}
		return overrideID;
	}

	public static void SwcitchCamereByUnitId(UObject WorldContext, int Index)
	{
		if (BGW_CricketBattleMgr.CricketBattleInfoDataList == null || Index - 1 > BGW_CricketBattleMgr.CricketBattleInfoDataList.Count)
		{
			return;
		}
		CricketBattleInfoData cricketBattleInfoData = BGW_CricketBattleMgr.CricketBattleInfoDataList[Index - 1];
		if (!(cricketBattleInfoData.BattleTamer != null))
		{
			return;
		}
		ABGUTamerBase aBGUTamerBase = cricketBattleInfoData.BattleTamer as ABGUTamerBase;
		if (aBGUTamerBase != null)
		{
			APlayerController playerController = UGameplayStatics.GetPlayerController(WorldContext, 0);
			AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.QuquCamera_0);
			AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(playerController.World, new FName("Battle_Scence_" + Index));
			FTransform actorTransform = aActor.GetActorTransform();
			actorTransform.SetLocation(aBGUTamerBase.GetActorLocation() + new FVector(-2000.0, -1000.0, 3200.0));
			if (aActor2 != null)
			{
				aActor2.SetActorTransform(actorTransform, bSweep: true, out var _, bTeleport: false);
				playerController.SetViewTargetWithBlend(aActor2, 1f, EViewTargetBlendFunction.VTBlend_Linear, 7.3f);
			}
		}
	}

	public static void PauseAllActorAI(UObject WorldContext, bool IsPauseAI)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<ABGUCharacter>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = allActorsOfClass[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_AIPauseBT.Invoke(IsPauseAI);
			}
		}
	}

	public static void PlayCricketSeq(UObject WorldContext, int SeqId)
	{
		AGameStateBase gameState = UGameplayStatics.GetGameState(WorldContext);
		FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
		{
			AutoPlay = true,
			PlayRate = 1f,
			StartTime = 0f,
			RandomStartTime = false,
			RestoreState = false,
			DisableMovementInput = true,
			DisableLookAtInput = true,
			HidePlayer = true,
			HideHud = true,
			DisableCameraCuts = false,
			PauseAtEnd = false
		};
		FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
		{
			AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
			OverrideAspectRatioAxisConstraint = false
		};
		FMovieGraphPlaySettings inPlaySettings = new FMovieGraphPlaySettings
		{
			PlaybackSettings = playbackSettings,
			CameraSettings = cameraSettings,
			bUsePlayerCamera = false
		};
		BGS_EventCollectionCS.Get(gameState).Evt_PlayMovieInstance.Invoke(SeqId, MovieInstance.Create(gameState, SeqId, inPlaySettings));
	}

	public static void SpawnCricketActor(UObject WorldContext, Dictionary<int, string> CurrentBattleUnitDict)
	{
		int num = 1;
		if (CurrentBattleUnitDict == null)
		{
			return;
		}
		foreach (KeyValuePair<int, string> item in CurrentBattleUnitDict)
		{
			UClass uClass = UObject.LoadClass<AActor>(null, item.Value);
			AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, new FName("Ququ_" + num));
			if (aActor != null)
			{
				BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(aActor.World, uClass, aActor.GetActorTransform(), ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
				if (bUTamerActor != null)
				{
					bUTamerActor.MarkAsSpawnedTamer(null);
					UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, ClcTamerSpawnFTransform(aActor, item.Key));
					CricketBattleInfoData cricketBattleInfoData = new CricketBattleInfoData();
					cricketBattleInfoData.ExtendId = item.Key;
					cricketBattleInfoData.BattleTamer = bUTamerActor;
					BGW_CricketBattleMgr.CricketBattleInfoDataList.Add(cricketBattleInfoData);
					num++;
				}
				else
				{
					BGW_LogUtil.LogError("未能成功出生新单位" + item.Value);
				}
			}
		}
	}

	public static FTransform ClcTamerSpawnFTransform(AActor TargetPlayerStart, int ExtendId)
	{
		FTransform actorTransform = TargetPlayerStart.GetActorTransform();
		FVector location = actorTransform.GetLocation();
		CricketBattleUnitDesc cricketBattleUnitDescByExtendId = GameDBRuntime.GetCricketBattleUnitDescByExtendId(ExtendId);
		if (cricketBattleUnitDescByExtendId != null)
		{
			if (cricketBattleUnitDescByExtendId.SpawnPosPixF != 0)
			{
				location += TargetPlayerStart.GetActorForwardVector() * cricketBattleUnitDescByExtendId.SpawnPosPixF;
			}
			if (cricketBattleUnitDescByExtendId.SpawnPosPixR != 0)
			{
				location += TargetPlayerStart.GetActorRightVector() * cricketBattleUnitDescByExtendId.SpawnPosPixR;
			}
			actorTransform.SetLocation(location);
		}
		return actorTransform;
	}

	public static void RandomKillOneTeam(UObject WorldContext)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<ABGUCharacter>());
		List<AActor> list = new List<AActor>();
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(bGUCharacterCS);
				if (readOnlyData != null && !readOnlyData.HasState(EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing))
				{
					list.Add(bGUCharacterCS);
				}
			}
		}
		if (list.Count > 0)
		{
			int index = FMath.RandRange(0, list.Count - 1);
			BUS_EventCollectionCS.Get(list[index])?.Evt_UnitDead.Invoke(list[index], EDeadReason.SkillDamage);
		}
		BGW_CricketBattleMgr.Get(WorldContext).RandomResultTime = BGW_PreloadAssetMgr.Get(WorldContext).CricketBattleDataAsset.BaodiKillTime;
	}

	public static void AddRandomBuff(UObject WorldContext)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGUCharacterCS>());
		int num = 0;
		int num2 = FMath.RandRange(0, 3);
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				if (BGW_CricketBattleMgr.CricketBattleMode == CricketBattleMode.Server && num == num2)
				{
					int buffId = BGW_PreloadAssetMgr.Get(WorldContext).CricketBattleDataAsset.BuffId;
					BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_BuffAdd.Invoke(buffId, bGUCharacterCS, bGUCharacterCS, -1f);
				}
				num++;
			}
		}
	}

	public static void SetTeamIndex(UObject WorldContext)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, UClass.GetClass<BGUCharacterCS>());
		int num = 0;
		AActor[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			BGUCharacterCS bGUCharacterCS = array[i] as BGUCharacterCS;
			if (!bGUCharacterCS.IsPlayerCharacterCS())
			{
				bGUCharacterCS.SetTeamIDInCS(10 + num);
				num++;
			}
		}
	}
}
