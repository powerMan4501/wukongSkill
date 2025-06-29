using System;
using BtlShare;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BIS_GymTrainManager : GameInstanceSystemBase
{
	private bool IsWorking;

	private PyXGameMMap MyMMap;

	private EGymGameStat WorkingStat;

	private long GameStartFrame;

	private int GameTrainStartTime;

	private int GameStartTime;

	private int PyStartTime;

	private int GameRunIndex;

	private int PyRunIndex;

	private int PyRunTime;

	private AActor PlayerWuKong;

	private ABGUCharacter EnemyMonster;

	private int NeedWaitFrame;

	private JsonData LastFromPyData;

	public override bool bTickEnabled => true;

	private void RunConsoleCMD(string InCMDStr)
	{
		USystemLibrary.ExecuteConsoleCommand(base.Owner, InCMDStr, null);
	}

	private int GetCurTimeInMS()
	{
		UGameplayStatics.GetAccurateRealTime(out var Seconds, out var PartialSeconds);
		return (int)(((long)Seconds * 1000L + (int)(PartialSeconds * 1000f)) % 10000000000L);
	}

	private void OnInitTeleportFinished()
	{
		RunConsoleCMD("b.sys GMSpawnMonster 3");
		SetWorkingStat_i(EGymGameStat.ResetFin);
		DoSendSimRespMsgToPy_i(EGymGameStat.ResetFin.ToString());
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnInitTeleportFinished));
	}

	public override void OnAttach()
	{
	}

	private void DoInit_i()
	{
		GameRunIndex = 0;
		GameStartTime = GetCurTimeInMS();
		GameStartFrame = UGSE_EngineFuncLib.GetGFrameCounter();
		EnemyMonster = null;
		SetWorkingStat_i(EGymGameStat.Init);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnInitTeleportFinished));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection2.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Combine(bGW_EventCollection2.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnInitTeleportFinished));
	}

	public void StartInit()
	{
		MyMMap = new PyXGameMMap();
		IsWorking = true;
		DoInit_i();
	}

	private void DoRunCmdList_i(JsonData FromPyData)
	{
		if (!FromPyData.Keys.Contains("RunCmdList"))
		{
			return;
		}
		for (int i = 0; i < FromPyData["RunCmdList"].Count; i++)
		{
			string text = FromPyData["RunCmdList"][i].ToString();
			if (text != "")
			{
				RunConsoleCMD(text ?? "");
			}
		}
	}

	private void DoOneAction(JsonData OneAction)
	{
		string text = OneAction["Name"].ToString();
		float num = StringParseHelper.SafeFloatParse(OneAction["Value"].ToString());
		if (text == "Gamepad_LeftX" || text == "Gamepad_LeftY")
		{
			RunConsoleCMD($"Input.+key {text} {num}");
			return;
		}
		if ((double)num == 1.0)
		{
			BGW_EventCollection.Get(base.Owner).Evt_InjectInputTriggerEvent("IA_B1" + text, ETriggerEvent.Started, FInputActionValue.True);
			return;
		}
		_ = (double)num;
		_ = 0.0;
	}

	private void DoSendSimRespMsgToPy_i(string MsgProtoType)
	{
		JsonData jsonData = new JsonData();
		jsonData["ProcType"] = MsgProtoType;
		jsonData["GameRunIndex"] = GameRunIndex;
		jsonData["GameRunTime"] = GetCurTimeInMS();
		jsonData["GameRunFrame"] = UGSE_EngineFuncLib.GetGFrameCounter();
		jsonData["GameTrainStartTime"] = GameTrainStartTime;
		jsonData["GameStartTime"] = GameStartTime;
		jsonData["GameStartFrame"] = GameStartFrame;
		MyMMap.SendMsgStrToPy(JsonMapper.ToJson(jsonData));
	}

	private void DoSendRespMsgToPy_i(JsonData FromPyData, JsonData FrameData = null)
	{
		JsonData jsonData = new JsonData();
		jsonData["ProcType"] = FromPyData["ProcType"];
		jsonData["GameRunIndex"] = GameRunIndex;
		jsonData["GameRunTime"] = GetCurTimeInMS();
		jsonData["GameRunFrame"] = UGSE_EngineFuncLib.GetGFrameCounter();
		jsonData["GameTrainStartTime"] = GameTrainStartTime;
		jsonData["GameStartTime"] = GameStartTime;
		jsonData["GameStartFrame"] = GameStartFrame;
		if (FromPyData.Keys.Contains("RunCmdList"))
		{
			jsonData["RunCmdList"] = FromPyData["RunCmdList"];
		}
		if (FromPyData.Keys.Contains("ActionList"))
		{
			jsonData["ActionList"] = FromPyData["ActionList"];
		}
		if (FrameData != null)
		{
			jsonData["FrameData"] = FrameData;
		}
		MyMMap.SendMsgStrToPy(JsonMapper.ToJson(jsonData));
	}

	private void DoSendForceFinMsgToPy_i()
	{
		JsonData jsonData = new JsonData();
		jsonData["ProcType"] = EGymGameStat.ForceEnd.ToString();
		MyMMap.SendMsgStrToPy(JsonMapper.ToJson(jsonData));
	}

	private void SetWorkingStat_i(EGymGameStat InTargetStat)
	{
		WorkingStat = InTargetStat;
	}

	public bool TryDoForceToInit(JsonData FromPyData)
	{
		if (FromPyData["ProcType"].ToString() != "ForceToInit")
		{
			return false;
		}
		DoRunCmdList_i(FromPyData);
		DoInit_i();
		DoSendRespMsgToPy_i(FromPyData);
		return true;
	}

	public int DoMsgInInit(JsonData FromPyData)
	{
		if (FromPyData["ProcType"].ToString() != "InitToReset")
		{
			BGW_LogUtil.LogError(string.Format("BIS_GymTrainManager WaitForMsgInInit Error, Invalid MsgProcType:{0} Msg:{1}", FromPyData["ProcType"].ToString(), FromPyData));
			return -1;
		}
		DoRunCmdList_i(FromPyData);
		SetWorkingStat_i(EGymGameStat.Reseting);
		PyStartTime = int.Parse(FromPyData["PyStartTime"].ToString());
		PyRunIndex = int.Parse(FromPyData["PyRunIndex"].ToString());
		PyRunTime = int.Parse(FromPyData["PyRunTime"].ToString());
		GameRunIndex++;
		DoSendRespMsgToPy_i(FromPyData);
		return 0;
	}

	private ABGUCharacter FindEnemyMonster()
	{
		ABGUCharacter[] allActorsOfClass = UGameplayStatics.GetPlayerCharacter(base.Owner, 0).World.GetAllActorsOfClass<ABGUCharacter>();
		ABGUCharacter[] array = allActorsOfClass;
		for (int i = 0; i < array.Length; i++)
		{
			_ = array[i];
		}
		array = allActorsOfClass;
		foreach (ABGUCharacter aBGUCharacter in array)
		{
			if (aBGUCharacter != PlayerWuKong)
			{
				return aBGUCharacter;
			}
		}
		return null;
	}

	public int DoMsgInResetFin(JsonData FromPyData)
	{
		if (FromPyData["ProcType"].ToString() != "ResetFinToTraining")
		{
			BGW_LogUtil.LogError(string.Format("BIS_GymTrainManager DoMsgInResetFin Error, Invalid MsgProcType:{0} Msg:{1}", FromPyData["ProcType"].ToString(), FromPyData));
			return -1;
		}
		GameTrainStartTime = GetCurTimeInMS();
		PyRunIndex = int.Parse(FromPyData["PyRunIndex"].ToString());
		PyRunTime = int.Parse(FromPyData["PyRunTime"].ToString());
		DoRunCmdList_i(FromPyData);
		SetWorkingStat_i(EGymGameStat.WaitForReady);
		NeedWaitFrame = 2;
		GameRunIndex++;
		JsonData frameData = MakeFrameData();
		DoSendRespMsgToPy_i(FromPyData, frameData);
		return 0;
	}

	private JsonData MakeLocRot(FVector Location, FRotator Rotation)
	{
		return new JsonData
		{
			["Location"] = new JsonData
			{
				["X"] = Location.X,
				["Y"] = Location.Y,
				["Z"] = Location.Z
			},
			["Rotation"] = new JsonData
			{
				["R"] = Rotation.Roll,
				["Y"] = Rotation.Yaw,
				["P"] = Rotation.Pitch
			}
		};
	}

	private JsonData MakeUnitData(AActor InUnit)
	{
		JsonData jsonData = new JsonData();
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(InUnit);
		if (readOnlyData != null)
		{
			jsonData["HP"] = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp);
			jsonData["SP"] = readOnlyData.GetFloatValue(EBGUAttrFloat.Stamina);
		}
		FVector actorLocation = InUnit.GetActorLocation();
		FRotator actorRotation = InUnit.GetActorRotation();
		jsonData["BaseLocRot"] = MakeLocRot(actorLocation, actorRotation);
		return jsonData;
	}

	private JsonData MakeOneSkeltalBoneData(USkeletalMeshComponent TargetSkeletalComp, string InBoneName)
	{
		FName inSocketName = new FName(InBoneName);
		FVector socketLocation = TargetSkeletalComp.GetSocketLocation(inSocketName);
		FRotator socketRotation = TargetSkeletalComp.GetSocketRotation(inSocketName);
		return MakeLocRot(socketLocation, socketRotation);
	}

	private JsonData MakeUnitSkeletalData(AActor InUnit)
	{
		JsonData jsonData = new JsonData();
		USkeletalMeshComponent mesh = (InUnit as BGUCharacterCS).Mesh;
		if (mesh == null)
		{
			return null;
		}
		jsonData["root"] = MakeOneSkeltalBoneData(mesh, "root");
		jsonData["pelvis"] = MakeOneSkeltalBoneData(mesh, "pelvis");
		jsonData["head"] = MakeOneSkeltalBoneData(mesh, "head");
		jsonData["hand_l"] = MakeOneSkeltalBoneData(mesh, "hand_l");
		jsonData["hand_r"] = MakeOneSkeltalBoneData(mesh, "hand_r");
		jsonData["foot_l"] = MakeOneSkeltalBoneData(mesh, "foot_l");
		jsonData["foot_r"] = MakeOneSkeltalBoneData(mesh, "foot_r");
		jsonData["weapon_r"] = MakeOneSkeltalBoneData(mesh, "weapon_r");
		return jsonData;
	}

	private bool IsPlayerLockedTarget()
	{
		if (UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner) == null)
		{
			BGW_LogUtil.LogError("BIS_GymTrainManager GetFirstLocalPlayerController is null");
			return false;
		}
		BUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(PlayerWuKong);
		if (readOnlyData != null && readOnlyData.GetTargetInfo().LockTargetActor != null)
		{
			return true;
		}
		return false;
	}

	private JsonData MakeFrameData()
	{
		bool flag = false;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (firstLocalPlayerController == null)
		{
			BGW_LogUtil.LogError("BIS_GymTrainManager GetFirstLocalPlayerController is null");
			return null;
		}
		PlayerWuKong = firstLocalPlayerController.GetControlledPawn();
		EnemyMonster = FindEnemyMonster();
		BUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(PlayerWuKong);
		if (readOnlyData != null && readOnlyData.GetTargetInfo().LockTargetActor != null)
		{
			flag = true;
		}
		return new JsonData
		{
			["PlayerIsLockedTarget"] = flag,
			["PlayerData"] = MakeUnitData(PlayerWuKong),
			["EnemyData"] = MakeUnitData(EnemyMonster),
			["PlayerSkel"] = MakeUnitSkeletalData(PlayerWuKong),
			["EnemySkel"] = MakeUnitSkeletalData(EnemyMonster)
		};
	}

	private int DoMsgInTraining(JsonData FromPyData)
	{
		if (FromPyData["ProcType"].ToString() != "Training")
		{
			BGW_LogUtil.LogError(string.Format("BIS_GymTrainManager DoMsgInTraining Error, Invalid MsgProcType:{0} Msg:{1}", FromPyData["ProcType"].ToString(), FromPyData));
			return -1;
		}
		if (EnemyMonster == null || !EnemyMonster.IsValidLowLevelFast())
		{
			DoSendForceFinMsgToPy_i();
			return 0;
		}
		PyRunIndex = int.Parse(FromPyData["PyRunIndex"].ToString());
		PyRunTime = int.Parse(FromPyData["PyRunTime"].ToString());
		DoRunCmdList_i(FromPyData);
		SetWorkingStat_i(EGymGameStat.Training);
		for (int i = 0; i < FromPyData["ActionList"].Count; i++)
		{
			JsonData oneAction = FromPyData["ActionList"][i];
			DoOneAction(oneAction);
		}
		GameRunIndex++;
		JsonData frameData = MakeFrameData();
		if (!IsPlayerLockedTarget())
		{
			BGUFuncLibInput.BGUInputCameraLockTarget(PlayerWuKong);
		}
		DoSendRespMsgToPy_i(FromPyData, frameData);
		return 0;
	}

	private int DoLogicInWaitForReady()
	{
		GameRunIndex++;
		NeedWaitFrame--;
		if (NeedWaitFrame <= 0)
		{
			JsonData frameData = MakeFrameData();
			LastFromPyData["ProcType"] = EGymGameStat.WaitForReady.ToString();
			DoSendRespMsgToPy_i(LastFromPyData, frameData);
			SetWorkingStat_i(EGymGameStat.Training);
		}
		return 0;
	}

	private int DoTickServerLogic(float DeltaTime)
	{
		if (MyMMap == null)
		{
			return 1;
		}
		if (WorkingStat == EGymGameStat.WaitForReady)
		{
			return DoLogicInWaitForReady();
		}
		string text = MyMMap.RecvMsgStrFromPy();
		if (text != null)
		{
			JsonData fromPyData = (LastFromPyData = JsonMapper.ToObject(text));
			if (TryDoForceToInit(fromPyData))
			{
				return 0;
			}
			switch (WorkingStat)
			{
			case EGymGameStat.Init:
				return DoMsgInInit(fromPyData);
			case EGymGameStat.ResetFin:
				return DoMsgInResetFin(fromPyData);
			case EGymGameStat.Training:
				return DoMsgInTraining(fromPyData);
			}
		}
		return 0;
	}

	public override int GetTickGroupMask()
	{
		return 64;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DebugConfig.GymModeInWindows)
		{
			if (!IsWorking)
			{
				StartInit();
			}
			if (TickGroup == 64)
			{
				DoTickServerLogic(DeltaTime);
			}
		}
	}

	public override void OnShutdown()
	{
	}
}
