using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_AutoEnterMainMap : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Begin,
		WXLogin,
		PreStartProcess,
		EnterMap,
		Finish
	}

	private InnerState CurrentState;

	private int TickCounter;

	private string Username;

	private string Password;

	private string TargetMapName;

	private bool BUI_StartGame_Appeared;

	private bool bLoadMapCompleted;

	public const int LevelId_SHLG = 2;

	public const int LevelId_HFS = 10;

	public const int LevelId_WDL = 12;

	public const int LevelId_HFM = 20;

	public const int LevelId_PSD = 40;

	public const int LevelId_HYS = 50;

	public const int LevelId_DebugRoom = 103;

	private BGW_GameLifeTimeMgr GameLifeTimeMgr;

	private bool IsClickGame;

	private bool Roll;

	public TestState_AutoEnterMainMap(UObject WorldContext, string Username, string Password, string TargetMapName)
	{
		base.WorldContext = WorldContext;
		this.Username = Username;
		this.Password = Password;
		this.TargetMapName = TargetMapName;
		GameLifeTimeMgr = null;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private string GetCurLevelName()
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		if (worldFromObj != null)
		{
			return worldFromObj.GetName();
		}
		return "";
	}

	private void OnPostLoadMapWithWorld()
	{
		bLoadMapCompleted = true;
	}

	public bool GetTargetLevelId(out int TargetLevelId)
	{
		TargetLevelId = -1;
		switch (TargetMapName)
		{
		case "HFS01_PersistentLevel":
			TargetLevelId = 10;
			break;
		case "HFM02_PersistentLevel":
			TargetLevelId = 20;
			break;
		case "HFM_DuJiaoXian_Persist":
			TargetLevelId = 2;
			break;
		case "HYS_PersistentLevel":
			TargetLevelId = 50;
			break;
		case "HFS_WoodDragon_01":
			TargetLevelId = 12;
			break;
		case "PSD_PersistentLevel":
			TargetLevelId = 40;
			break;
		case "DebugRoom_Persistent":
			TargetLevelId = 103;
			break;
		default:
			return false;
		}
		return true;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.Begin:
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			DebugConfig.DebugStartWithOutArchive = true;
			Description = "游戏开始，先等10s，等界面载入完成";
			TransferState(InnerState.WXLogin);
			break;
		case InnerState.WXLogin:
			if (TickCounter < 10)
			{
				break;
			}
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			if (GetCurLevelName() == "WXLogin_P")
			{
				string text = BGW_GSAutoTestUtil.GSAutoTestLogin(WorldContext, Username, Password);
				if (!string.IsNullOrEmpty(text))
				{
					Description = "[TestState_AutoEnterMainMap] Login Failed, ErrorMsg: " + text;
					return AutoTestNodeLib.NodeState.Failed;
				}
				Description = "自动登录成功";
				TransferState(InnerState.PreStartProcess);
			}
			else if (GetCurLevelName() == "Startup_V2_P")
			{
				TransferState(InnerState.EnterMap);
			}
			break;
		case InnerState.PreStartProcess:
		{
			if (GetCurLevelName() == "Startup_V2_P")
			{
				TransferState(InnerState.EnterMap);
				break;
			}
			UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, UClass.GetClass<GSScrollBox>());
			if (FoundWidgets2 != null && FoundWidgets2.Count > 0)
			{
				foreach (GSScrollBox item in FoundWidgets2)
				{
					if (!(item == null))
					{
						item.SetScrollOffset(item.GetScrollOffsetOfEnd());
					}
				}
			}
			Roll = !Roll;
			if (Roll)
			{
				BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent("IA_GSUIConfirm", ETriggerEvent.Started, FInputActionValue.True);
			}
			else
			{
				BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent("IA_GSUIConfirm", ETriggerEvent.Completed, FInputActionValue.False);
			}
			break;
		}
		case InnerState.EnterMap:
			if (GameLifeTimeMgr == null)
			{
				GameLifeTimeMgr = BGW_GameLifeTimeMgr.Get(WorldContext);
			}
			if (GameLifeTimeMgr == null)
			{
				Description = "[TestState_AutoEnterMainMap] GameLifeTimeMgr == null";
				return AutoTestNodeLib.NodeState.Failed;
			}
			if (!BUI_StartGame_Appeared && GameLifeTimeMgr.IsInFSMState(SGI_Global.MainMenu))
			{
				UClass uClass = null;
				uClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/StartGame/BUI_StartGame.BUI_StartGame_C'", ELoadResourceType.SyncLoadAndCache);
				if (uClass == null)
				{
					break;
				}
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, uClass, TopLevelOnly: false);
				if (FoundWidgets.Count > 0 && !BUI_StartGame_Appeared)
				{
					BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					BUI_StartGame_Appeared = true;
					int TargetLevelId;
					if (TargetMapName == "ContinueGame")
					{
						ArchiveSummaryData latestArchive = BGW_GameArchiveMgr.Get(WorldContext).GetLatestArchive();
						if (latestArchive != null)
						{
							BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.LoadArchive, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
							{
								ArchiveId = latestArchive.ArchiveId
							});
						}
					}
					else if (GetTargetLevelId(out TargetLevelId))
					{
						BGW_EventCollection.Get(WorldContext).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.StartNewGame, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
						{
							TargetId = TargetLevelId
						});
					}
					else
					{
						USystemLibrary.ExecuteConsoleCommand(WorldContext, "travel " + TargetMapName, null);
					}
				}
			}
			if (BUI_StartGame_Appeared)
			{
				if (bLoadMapCompleted)
				{
					Description = "自动进图成功";
					BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
					TransferState(InnerState.Finish);
				}
				else
				{
					Description = "仍在进图中";
				}
			}
			break;
		case InnerState.Finish:
			Description = "自动进图成功";
			if (TickCounter >= 5)
			{
				Description = "自动进图完成";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		}
		TickCounter++;
		Description = "执行中";
		return AutoTestNodeLib.NodeState.Running;
	}
}
