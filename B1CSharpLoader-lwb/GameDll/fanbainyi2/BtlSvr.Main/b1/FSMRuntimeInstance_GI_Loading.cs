using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class FSMRuntimeInstance_GI_Loading : FSMRuntimeInstanceBase
{
	public delegate FSMState_GI_LoadingBase Del_StateCreate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams);

	public delegate FSMConditionBase Del_ConditionCreate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams);

	private static Dictionary<string, Del_StateCreate> sStateCreateFuncs = new Dictionary<string, Del_StateCreate>();

	private static Dictionary<string, Del_ConditionCreate> sConditionCreateFuncs = new Dictionary<string, Del_ConditionCreate>();

	private static Dictionary<string, SGI_Loading> sEStateNameMap = new Dictionary<string, SGI_Loading>
	{
		{
			"FSM.BED_FSMNode_GI_Loading_GSGShowWXlogin",
			SGI_Loading.GSGShowWXlogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitMatchStart",
			SGI_Loading.WaitMatchStart
		},
		{
			"FSM.BED_FSMNode_GI_Loading_FillIsInToilet",
			SGI_Loading.FillIsInToilet
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadCharacterViewLevel",
			SGI_Loading.LoadCharacterViewLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadChapterViewLevel",
			SGI_Loading.LoadChapterViewLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_InitDispLibWorld",
			SGI_Loading.InitDispLibWorld
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ECSWorldBeginPlay",
			SGI_Loading.ECSWorldBeginPlay
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGBtlOnBattleStart",
			SGI_Loading.GSGBtlOnBattleStart
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CreateNewRoleData",
			SGI_Loading.CreateNewRoleData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGEnterBattleLevel",
			SGI_Loading.GSGEnterBattleLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ServerBattleReady",
			SGI_Loading.ServerBattleReady
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGShowBattleUI",
			SGI_Loading.GSGShowBattleUI
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGShowLoginUI",
			SGI_Loading.GSGShowLoginUI
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGRecoverMuseum",
			SGI_Loading.GSGRecoverMuseum
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadingUIFadeAway",
			SGI_Loading.LoadingUIFadeAway
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadingUIFadeIn",
			SGI_Loading.LoadingUIFadeIn
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitReplayPlayerSpawn",
			SGI_Loading.WaitReplayPlayerSpawn
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowReplayUI",
			SGI_Loading.ShowReplayUI
		},
		{
			"FSM.BED_FSMNode_GI_Loading_UnlockScopeReplayScrubComplete",
			SGI_Loading.UnlockScopeReplayScrubComplete
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitTick",
			SGI_Loading.WaitTick
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoginByRoleData",
			SGI_Loading.LoginByRoleData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitGSLoginSuccess",
			SGI_Loading.WaitGSLoginSuccess
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PlayerDataInitPreEnterLevel",
			SGI_Loading.PlayerDataInitPreEnterLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGEnterLevel",
			SGI_Loading.GSGEnterLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGExitLevel",
			SGI_Loading.GSGExitLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ECSWorldReset",
			SGI_Loading.ECSWorldReset
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PauseGame",
			SGI_Loading.PauseGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ResumeGame",
			SGI_Loading.ResumeGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_InitNewArchiveData",
			SGI_Loading.InitNewArchiveData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadingUIWaitUserInput",
			SGI_Loading.LoadingUIWaitUserInput
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadingUILinearTime",
			SGI_Loading.LoadingUILinearTime
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ReadLatestArchive",
			SGI_Loading.ReadLatestArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_FillLoginRoleData",
			SGI_Loading.FillLoginRoleData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_OpenLevelByName",
			SGI_Loading.OpenLevelByName
		},
		{
			"FSM.BED_FSMNode_GI_Loading_Reset820DemoGameData",
			SGI_Loading.Reset820DemoGameData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ResetGameInstanceData",
			SGI_Loading.ResetGameInstanceData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CacheArchiveDataForClient",
			SGI_Loading.CacheArchiveDataForClient
		},
		{
			"FSM.BED_FSMNode_GI_Loading_OpenLevelStartUp",
			SGI_Loading.OpenLevelStartUp
		},
		{
			"FSM.BED_FSMNode_GI_Loading_OpenLevelDefaultBattle",
			SGI_Loading.OpenLevelDefaultBattle
		},
		{
			"FSM.BED_FSMNode_GI_Loading_OpenLevelByIdInContext",
			SGI_Loading.OpenLevelByIdInContext
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGOnBattleStart",
			SGI_Loading.GSGOnBattleStart
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGOnBattleDestroy",
			SGI_Loading.GSGOnBattleDestroy
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GSGBtlOnBattleDestroy",
			SGI_Loading.GSGBtlOnBattleDestroy
		},
		{
			"FSM.BED_FSMNode_GI_Loading_MarkNewGameplusReady",
			SGI_Loading.MarkNewGameplusReady
		},
		{
			"FSM.BED_FSMNode_GI_Loading_StartNewGamePlus",
			SGI_Loading.StartNewGamePlus
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitPlayerCameraBlend",
			SGI_Loading.WaitPlayerCameraBlend
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitLevelStreamingLoad",
			SGI_Loading.WaitLevelStreamingLoad
		},
		{
			"FSM.BED_FSMNode_GI_Loading_UnrealTravelToServer",
			SGI_Loading.UnrealTravelToServer
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitLocalPlayerFillLoginOption",
			SGI_Loading.WaitLocalPlayerFillLoginOption
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitLocalPlayerStartPlay",
			SGI_Loading.WaitLocalPlayerStartPlay
		},
		{
			"FSM.BED_FSMNode_GI_Loading_InitLocalPlayerContainer",
			SGI_Loading.InitLocalPlayerContainer
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitPostLoadMap",
			SGI_Loading.WaitPostLoadMap
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitPostLoadMapClient",
			SGI_Loading.WaitPostLoadMapClient
		},
		{
			"FSM.BED_FSMNode_GI_Loading_FillLocalBPCRoleData",
			SGI_Loading.FillLocalBPCRoleData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitFirstPlayerLogin",
			SGI_Loading.WaitFirstPlayerLogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitAllAssetLoadFinsh",
			SGI_Loading.WaitAllAssetLoadFinsh
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitImportantAssetLoadFinsh",
			SGI_Loading.WaitImportantAssetLoadFinsh
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitCheck820DemoGameVersion",
			SGI_Loading.WaitCheck820DemoGameVersion
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ResetNewGameplusArchive",
			SGI_Loading.ResetNewGameplusArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitStartGamePsoPrecompileFinish",
			SGI_Loading.WaitStartGamePsoPrecompileFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_FirstStartGameSettings",
			SGI_Loading.FirstStartGameSettings
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowAgreementPolicyInStartGame",
			SGI_Loading.ShowAgreementPolicyInStartGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowLogoInStartGame",
			SGI_Loading.ShowLogoInStartGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowGameDisclaimerInStartGame",
			SGI_Loading.ShowGameDisclaimerInStartGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowArchiveMarkInStartGame",
			SGI_Loading.ShowArchiveMarkInStartGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_MarkFirstStartGameFlag",
			SGI_Loading.MarkFirstStartGameFlag
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CheckGSSdkServerConfig",
			SGI_Loading.CheckGSSdkServerConfig
		},
		{
			"FSM.BED_FSMNode_GI_Loading_MarkCanFinishLoopMovie",
			SGI_Loading.MarkCanFinishLoopMovie
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowHealthyGamingAdviceInStartGame",
			SGI_Loading.ShowHealthyGamingAdviceInStartGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_TeleportTemplateBegin",
			SGI_Loading.TeleportTemplateBegin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_TeleportTemplateEnd",
			SGI_Loading.TeleportTemplateEnd
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PlayerTeleportToTemplatetargetPos",
			SGI_Loading.PlayerTeleportToTemplatetargetPos
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadingUIBeginFadeAway",
			SGI_Loading.LoadingUIBeginFadeAway
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_BattleLevelTravel",
			SGI_Loading.SubG_GI_Loading_BattleLevelTravel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ClientEnvInit",
			SGI_Loading.SubG_GI_Loading_ClientEnvInit
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_HideLoadingUI",
			SGI_Loading.SubG_GI_Loading_HideLoadingUI
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_GSLogin",
			SGI_Loading.SubG_GI_Loading_GSLogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ReStartGSLogin",
			SGI_Loading.SubG_GI_Loading_ReStartGSLogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish",
			SGI_Loading.SubG_GI_Loading_SaveArchiveAndWaitFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplateTravelLevelBegin",
			SGI_Loading.RequestTemplateTravelLevelBegin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplateTravelLevelEnd",
			SGI_Loading.RequestTemplateTravelLevelEnd
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePreSaveArchive",
			SGI_Loading.RequestTemplatePreSaveArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePostSaveArchiveFinish",
			SGI_Loading.RequestTemplatePostSaveArchiveFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePreLeaveLevel",
			SGI_Loading.RequestTemplatePreLeaveLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_PostLeaveLevel",
			SGI_Loading.SubG_GI_Loading_PostLeaveLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplateOpenLevel",
			SGI_Loading.RequestTemplateOpenLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_PreEnterLevel",
			SGI_Loading.SubG_GI_Loading_PreEnterLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePostEnterLevelFinish",
			SGI_Loading.RequestTemplatePostEnterLevelFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePostGSLoginFinish",
			SGI_Loading.RequestTemplatePostGSLoginFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LockSaveArchiveByTravelLevel",
			SGI_Loading.LockSaveArchiveByTravelLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ReleaseSaveArchiveByTravelLevel",
			SGI_Loading.ReleaseSaveArchiveByTravelLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive",
			SGI_Loading.SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplateLoadArchiveData",
			SGI_Loading.RequestTemplateLoadArchiveData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplateCreateArchiveData",
			SGI_Loading.RequestTemplateCreateArchiveData
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestTemplatePerformActionsFromArchive",
			SGI_Loading.RequestTemplatePerformActionsFromArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel",
			SGI_Loading.SubG_GI_Loading_HandleArchiveInTravelLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CheckArchiveDataIsValid",
			SGI_Loading.CheckArchiveDataIsValid
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SaveArchiveInTravelLevel",
			SGI_Loading.SaveArchiveInTravelLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_OpenLoadingScreen",
			SGI_Loading.OpenLoadingScreen
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PrepareFadeAway",
			SGI_Loading.PrepareFadeAway
		},
		{
			"FSM.BED_FSMNode_GI_Loading_RequestFadeAway",
			SGI_Loading.RequestFadeAway
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CloseLoadingScreen",
			SGI_Loading.CloseLoadingScreen
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SpawnPlayerPawnWithOutECSBeginPlay",
			SGI_Loading.SpawnPlayerPawnWithOutECSBeginPlay
		},
		{
			"FSM.BED_FSMNode_GI_Loading_TriggerTeleportAndWaitFinish",
			SGI_Loading.TriggerTeleportAndWaitFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PausePsoCachePrecompile",
			SGI_Loading.PausePsoCachePrecompile
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ResumePsoCachePrecompile",
			SGI_Loading.ResumePsoCachePrecompile
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitPsoCachePrecompileFinish",
			SGI_Loading.WaitPsoCachePrecompileFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_AdjustPSOCachePrecompileBatch",
			SGI_Loading.AdjustPSOCachePrecompileBatch
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SetPSOCacheUsageMask",
			SGI_Loading.SetPSOCacheUsageMask
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PreLogin",
			SGI_Loading.PreLogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PostLogin",
			SGI_Loading.PostLogin
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitGamePlayerInit",
			SGI_Loading.WaitGamePlayerInit
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SpawnCharacterForClient",
			SGI_Loading.SpawnCharacterForClient
		},
		{
			"FSM.BED_FSMNode_GI_Loading_InitClientPlayerContainer",
			SGI_Loading.InitClientPlayerContainer
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ChangeGameDefaultMap",
			SGI_Loading.ChangeGameDefaultMap
		},
		{
			"FSM.BED_FSMNode_GI_Loading_CheckGSSdkUserConfig",
			SGI_Loading.CheckGSSdkUserConfig
		},
		{
			"FSM.BED_FSMNode_GI_Loading_EngineHandleDisconnect",
			SGI_Loading.EngineHandleDisconnect
		},
		{
			"FSM.BED_FSMNode_GI_Loading_ShowMessageBoxAndWaitConfirm",
			SGI_Loading.ShowMessageBoxAndWaitConfirm
		},
		{
			"FSM.BED_FSMNode_GI_Loading_TriggerBackToStandAlone",
			SGI_Loading.TriggerBackToStandAlone
		},
		{
			"FSM.BED_FSMNode_GI_Loading_NextChapterReqAndArchive",
			SGI_Loading.NextChapterReqAndArchive
		},
		{
			"FSM.BED_FSMNode_GI_Loading_GMRecordRebirthPos",
			SGI_Loading.GMRecordRebirthPos
		},
		{
			"FSM.BED_FSMNode_GI_Loading_NetConectionFailurePreprocess",
			SGI_Loading.NetConectionFailurePreprocess
		},
		{
			"FSM.BED_FSMNode_GI_Loading_InitCollectionSpawnActorState",
			SGI_Loading.InitCollectionSpawnActorState
		},
		{
			"FSM.BED_FSMNode_GI_Loading_SaveArchiveAndWaitFinish",
			SGI_Loading.SaveArchiveAndWaitFinish
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PostSeamlessLevelTravel",
			SGI_Loading.PostSeamlessLevelTravel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_LoadCommLevel",
			SGI_Loading.LoadCommLevel
		},
		{
			"FSM.BED_FSMNode_GI_Loading_QuitGame",
			SGI_Loading.QuitGame
		},
		{
			"FSM.BED_FSMNode_GI_Loading_WaitUntilGameStateInit",
			SGI_Loading.WaitUntilGameStateInit
		},
		{
			"FSM.BED_FSMNode_GI_Loading_PlayGoDownloadIncompleteImpl",
			SGI_Loading.PlayGoDownloadIncompleteImpl
		}
	};

	public FSMState_GI_LoadingBase ActiveState { get; private set; }

	public SGI_Loading ActiveEState => sEStateNameMap[ActiveNode.NodeClass];

	public FSMContext_GI_Loading Context { get; private set; }

	public static void RegisterStates(int EntityMgrIdx, string NodeClassName, Del_StateCreate CreateFunc)
	{
		sStateCreateFuncs[NodeClassName] = CreateFunc;
	}

	public static void RegisterConditions(int EntityMgrIdx, string NodeClassName, Del_ConditionCreate CreateFunc)
	{
		sConditionCreateFuncs[NodeClassName] = CreateFunc;
	}

	public FSMRuntimeInstance_GI_Loading(FCalliopeGraph CalliopeGraph, FSMContext_GI_Loading InContext, UCalliopeAsset CalliopeAsset)
		: base(CalliopeGraph, InContext, CalliopeAsset)
	{
		Context = InContext;
	}

	public override void Start(object InputParams, FSMContextBase Context)
	{
		base.Start(InputParams, Context);
		FreshActiveState(InputParams, FromAnyState: false);
	}

	public void ForceShutDown()
	{
		ActiveState = null;
		Finish();
	}

	protected void FreshActiveState(object InputParams, bool FromAnyState)
	{
		try
		{
			ActiveState?.OnExit();
			if (FromAnyState)
			{
				ActiveState?.OnAbort();
			}
			if (ActiveNode.NodeClass == "FSM.BED_FSMNode_End")
			{
				ActiveState = null;
				Finish();
			}
			else if (ActiveNode.NodeClass.StartsWith("FSM.BED_FSMNode_Condition_"))
			{
				FSMConditionBase fSMConditionBase = sConditionCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				if (TriggerEventByString(fSMConditionBase.GetResult(), Context, out var FromAnyState2))
				{
					FreshActiveState(fSMConditionBase.GetNextNodeInputParam(), FromAnyState2);
				}
			}
			else
			{
				ActiveState = sStateCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				ActiveState?.OnEnter();
			}
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
	}

	public override int OnTick(float Delta)
	{
		try
		{
			return ActiveState.OnTick(Delta);
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
		return 0;
	}

	public void TriggerEvent(EGI_Loading Event, object InputParams = null)
	{
		TriggerEvent(Event.ToString(), InputParams);
	}

	public void TriggerEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_BattleLevelTravel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_ClientEnvInit_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_HideLoadingUI_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_GSLogin_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_ReStartGSLogin_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_PostLeaveLevel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_PreEnterLevel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}
}
