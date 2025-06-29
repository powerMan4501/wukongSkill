using System;
using b1.BGW;
using b1.GSMUICore.Event;
using b1.UI;
using b1.Util;
using GSDispLib;
using UnrealEngine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GameInstance_B1")]
public class BGW_GameInstance_B1 : BGWGameInstanceCS
{
	private static bool ReceiveInit_IsValid;

	private static IntPtr ReceiveInit_FunctionAddress;

	private static int ReceiveInit_ParamsSize;

	private static bool ProcessNianHuiLogic_IsValid;

	private static IntPtr ProcessNianHuiLogic_FunctionAddress;

	private static int ProcessNianHuiLogic_ParamsSize;

	static BGW_GameInstance_B1()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GameInstance_B1)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GameInstance_B1));
	}

	private void Logger(string msg)
	{
		UGSE_EngineFuncLib.LogError(msg);
	}

	[USharpPath("/Script/b1-Managed.BGW_GameInstance_B1:ReceiveInit")]
	protected override void ReceiveInit_Implementation()
	{
		if (IConsoleManager.Get().FindConsoleVariable("b.ForceMovieRenderMode").GetInt() != 0)
		{
			B1Global.GIsMovieRendering = true;
		}
		else
		{
			B1Global.GIsMovieRendering = false;
		}
		GSEPerfTimeUtil.Init();
		if (!UGSE_EngineFuncLib.IsEditor())
		{
			UGSE_EngineFuncLib.SetLogEnable(bEnableDbg: false, bEnableDbgDisplay: false, bEnableInfo: true);
		}
		else
		{
			UGSE_EngineFuncLib.SetLogEnable(bEnableDbg: true, bEnableDbgDisplay: true, bEnableInfo: true);
		}
		GSGameCoustomConfigInit();
		ReSetGameLogicConf.Reset();
		base.ReceiveInit_Implementation();
	}

	[USharpPath("/Script/b1-Managed.BGW_GameInstance_B1:ProcessNianHuiLogic")]
	protected override void ProcessNianHuiLogic_Implementation()
	{
		DebugConfig.CricketBattleMode = true;
		DebugConfig.CricketBattleModeType = 3;
		BGW_CricketBattleMgr.CmdStart = true;
	}

	public static void GSGameCoustomConfigInit()
	{
		GSDevelopConfigMgr.InitConfigAfterDeserialize();
	}

	public override void InitGameInstObj()
	{
		CreateUObj<BGW_EventCollection>();
		CreateUObj<BGW_DebugMgr>();
		CreateUObj<BGW_ExceptionUIMgr>();
		InitAllObjNotInited();
		base.InitDebugMgrDone = true;
		BGW_GSSdkMgr.InitGSSdkLogger();
		BGW_GameDB.Init(ProjNames.B1.ToString());
		CreateUObj<BGW_OnlineIdentity>();
		CreateUObj<BGW_GSSdkMgr>();
		CreateUObj<BGW_OnlineSubsystem>();
		CreateUObj<BGW_GameArchiveMgr>();
		CreateUObj<BGW_SettingMgrV2>();
		if (!UGSE_EngineFuncLib.IsDedicateServer(UGSE_EngineFuncLib.GetWorldFromObj(this)))
		{
			CreateUObj<BGW_UIMgr>();
			CreateUObj<BGW_CalliopeDebugManager>();
		}
		CreateUObjCS<BGW_GameDataMgr>();
		CreateClass<CSApiBattle>();
		CreateUObj<BGW_AsyncTaskMgr>();
		CreateUObj<BGW_PSOAdaptorMgr>();
		if (SharedRuntimeState.CurrentRuntime == EDotNetRuntime.IL2CPP)
		{
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("DebugConfig.ILRuntime");
			if (consoleVariable != null)
			{
				consoleVariable.Set(1);
			}
		}
		if (DebugConfig.ILRuntime)
		{
			CreateUObj<BGW_ILRuntimeMgr>();
		}
		else
		{
			CreateUObj<BGW_ManagedReflectMgr>();
		}
		if (!B1Global.GIsGameReleased)
		{
			CreateUObj<BGW_DevCheckGameMgr>();
			if (DebugConfig.Debug820Demo)
			{
				CreateUObj<BGW_820DemoPlayTimeMgr>();
			}
			if (DebugConfig.CricketBattleMode || BGW_CricketBattleMgr.CmdStart)
			{
				CreateUObj<BGW_CricketBattleMgr>();
			}
			CreateUObj<BGW_ComboDebugMgr>();
			CreateUObjCS<BGW_AssetCollectorUtilMgr>();
		}
		if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
		{
			CreateUObj<BGW_GSUploadFilesMgr>();
		}
		if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
		{
			CreateUObj<BGW_DevSecurityMgr>();
			CreateUObj<BGW_WXLoginMgr>();
			if (BGW_CETestGameMgr.EnableCETesting)
			{
				CreateUObj<BGW_CETestGameMgr>();
			}
		}
		else if (DebugConfig.LQALanguage)
		{
			CreateUObj<BGW_DevSecurityMgr>();
		}
		CreateUObjCS<BIS_LevelManager>();
		CreateUObj<b1.BGW_PlatformEventMgr>();
		CreateUObj<BGW_PreloadAssetMgr>();
		CreateUObj<BGW_UIEventCollection>();
		CreateUObj<BGW_ValiDateMgr>();
		CreateUObj<BGW_EnhancedInputMgrV2>();
		CreateUObj<BGW_LevelStreamingManger>();
		CreateUObjCS<BGWDreamTeleportPointsComp>();
		CreateClassCS<BIS_CalliopeAssetManager>();
		CreateClassCS<BIS_PersistentECSDataSystem>();
		CreateUObj<BGW_FSMInstanceMgr>();
		CreateUObj<BGW_GameLifeTimeMgr>();
		CreateUObj<BGWConsoleCommands>();
		CreateUObj<BGW_DynamicSDFMgr>();
		CreateUObjCS<BGW_MovieManager>();
		CreateUObjCS<BIS_TaskManager>();
		CreateClassCS<BIS_StateMachineManager>();
		CreateClassCS<b1.BIS_BossRushBattleManager>();
		CreateClassCS<BIS_BossRushMgr>();
		if (!B1Global.GIsGameReleased)
		{
			CreateClassCS<BIS_AutoTestManagerV2>();
		}
		CreateClassCS<BIS_InteractiveObjControlSystem>();
		CreateClassCS<BGW_GMMgr>();
		if (!B1Global.GIsGameReleasedReally_Just4DevSimulation)
		{
			CreateClassCS<BIS_CheatManager>();
		}
		CreateClassCS<BIS_GymTrainManager>();
		CreateUObj<BGW_OnlinePresence>();
		CreateUObj<BGW_PlatformEventExecMgr>();
		CreateUObj<BGW_CameraAdapterMgr>();
		CreateUObjCS<BGW_CharacterViewMgr>();
		CreateUObjCS<BGW_CommLevelMgr>();
		if (DebugConfig.Debug820Demo)
		{
			CreateUObjCS<BGW_ChapterView820Mgr>();
		}
		else if (DebugConfig.EnableChapterRoamV2)
		{
			CreateUObjCS<BGW_ChapterViewMgrV2>();
		}
		else
		{
			CreateUObjCS<BGW_ChapterViewMgr>();
		}
		CreateUObjCS<BGW_TakePhotoSystemMgr>();
		CreateClassCS<BIS_CollectionGroupSystem>();
		CreateClassCS<BIS_GlobalActorManager>();
		CreateClassCS<BIS_PlayerTeleportMgr>();
		CreateClassCS<BIS_ResetActorManager>();
		CreateClassCS<b1.BIS_DeathManager>();
		CreateUObjCS<BGW_LoadingTipsMgr>();
		CreateUObj<BGW_PlayGoMgr>();
		CreateUObj<BGW_AutoResetGISCVarMgr>();
		CreateUObj<BGW_OnlineAchievement>();
		CreateUObj<BGW_OnlineCloud>();
		CreateUObj<BGW_OnlineSession>();
		CreateUObj<BGW_OnlineFriend>();
		CreateUObj<BGW_ReplaySystemMgr>();
		CreateUObj<BGW_PauseGameMgr>();
		CreateUObj<BGW_OnlineActivity>();
		CreateUObj<BGW_GCMgr>();
		CreateClass<BGW_EffectTemplateList>();
		CreateClass<BGW_BACCTemplateList>();
		if (!B1Global.GIsMovieRendering)
		{
			CreateUObjCS<BGW_LevelStreamingStateMgr>();
		}
		BGW_DispLibGameDB.Init(ProjNames.B1, this);
		GSMMathUtil.Init();
		CreateClass<B1GSUIActorMgr>();
		CreateUObj<BGW_MemoryMgr>();
		base.InitGameInstObj();
		CreateUObj<BGW_PipelineStateMgr>();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_GameInstance_B1:ReceiveInit")]
	private static void ReceiveInit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_GameInstance_B1 bGW_GameInstance_B = GCHelper.Find<BGW_GameInstance_B1>(obj);
		bGW_GameInstance_B.ReceiveInit_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_GameInstance_B1:ProcessNianHuiLogic")]
	private static void ProcessNianHuiLogic__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_GameInstance_B1 bGW_GameInstance_B = GCHelper.Find<BGW_GameInstance_B1>(obj);
		bGW_GameInstance_B.ProcessNianHuiLogic_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_GameInstance_B1");
		ReceiveInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveInit");
		ReceiveInit_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveInit_FunctionAddress);
		ReceiveInit_IsValid = ReceiveInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_GameInstance_B1:ReceiveInit", ReceiveInit_IsValid);
		ProcessNianHuiLogic_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessNianHuiLogic");
		ProcessNianHuiLogic_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessNianHuiLogic_FunctionAddress);
		ProcessNianHuiLogic_IsValid = ProcessNianHuiLogic_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_GameInstance_B1:ProcessNianHuiLogic", ProcessNianHuiLogic_IsValid);
	}
}
