using System;
using AOT;
using b1.EventDelDefine;
using b1.GameMode;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GameLifeTimeMgr")]
public class BGW_GameLifeTimeMgr : GameInstanceSystemBaseUObj
{
	private bool InitLoadingCalled;

	private bool IsOpeningLevelValid;

	private EStartGameInstanceTypeForCS StartType;

	private FSMRuntimeInstance_GI_Global GlobalFSMInstance;

	private static FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature sActOnPostLoadMap;

	private static FCoreUObjectDelegates.PreLoadMapHandler.Signature sActOnPreLoadMap;

	private bool HasInited;

	public SGI_Global GlobalFSMInstanceCurState => GlobalFSMInstance.ActiveEState;

	public bool IsInFSMState(SGI_Global State)
	{
		if (GlobalFSMInstance.ActiveEState == State)
		{
			return true;
		}
		for (FSMState_GI_Global_SubG_GI_Global_Base fSMState_GI_Global_SubG_GI_Global_Base = GlobalFSMInstance.ActiveState as FSMState_GI_Global_SubG_GI_Global_Base; fSMState_GI_Global_SubG_GI_Global_Base != null; fSMState_GI_Global_SubG_GI_Global_Base = fSMState_GI_Global_SubG_GI_Global_Base.SubGraphRuntimeInstance.ActiveState as FSMState_GI_Global_SubG_GI_Global_Base)
		{
			if (State == fSMState_GI_Global_SubG_GI_Global_Base.SubGraphRuntimeInstance.ActiveEState)
			{
				return true;
			}
		}
		return false;
	}

	public bool IsInTravelLevel()
	{
		return GlobalFSMInstance.Context.TravelLevelContext != null;
	}

	public bool IsInTravelLevel(EGlobalTravelLevelType TravelLevelType)
	{
		if (GlobalFSMInstance?.Context?.TravelLevelContext?.TravelLevelTemplate == null)
		{
			return false;
		}
		return GlobalFSMInstance.Context.TravelLevelContext.TravelLevelTemplate.TravelLevelType == TravelLevelType;
	}

	public SGI_Global GetCurActiveState(bool IsNeedTraverse = false)
	{
		if (!IsNeedTraverse)
		{
			return GlobalFSMInstance.ActiveEState;
		}
		FSMState_GI_Global_SubG_GI_Global_Base fSMState_GI_Global_SubG_GI_Global_Base = GlobalFSMInstance.ActiveState as FSMState_GI_Global_SubG_GI_Global_Base;
		SGI_Global activeEState = GlobalFSMInstance.ActiveEState;
		while (fSMState_GI_Global_SubG_GI_Global_Base != null)
		{
			activeEState = fSMState_GI_Global_SubG_GI_Global_Base.SubGraphRuntimeInstance.ActiveEState;
			fSMState_GI_Global_SubG_GI_Global_Base = fSMState_GI_Global_SubG_GI_Global_Base.SubGraphRuntimeInstance.ActiveState as FSMState_GI_Global_SubG_GI_Global_Base;
		}
		return activeEState;
	}

	public static BGW_GameLifeTimeMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_GameLifeTimeMgr>(Context);
	}

	[MonoPInvokeCallback(typeof(FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature))]
	private static void sOnPostLoadMap(UObject LoadedWorld)
	{
		sActOnPostLoadMap(LoadedWorld);
	}

	[MonoPInvokeCallback(typeof(FCoreUObjectDelegates.PreLoadMapHandler.Signature))]
	private static void sOnPreLoadMap(string MapName)
	{
		sActOnPreLoadMap(MapName);
	}

	[MonoPInvokeCallback(typeof(FWorldDelegates.OnSeamlessTravelStartHandler.Signature))]
	private static void sOnSeamLessTravelStart(IntPtr OldWorld, string Level)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GCHelper.Find<UObject>(OldWorld));
		if (GSEUtil.Ensure(bGW_EventCollection != null))
		{
			bGW_EventCollection.Evt_OnSeamlessTravelStart(Level);
		}
	}

	[MonoPInvokeCallback(typeof(FWorldDelegates.OnSeamlessTravelTransitionHandler.Signature))]
	private static void sOnSeamlessTravelTransition(IntPtr NewWorld)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GCHelper.Find<UObject>(NewWorld));
		if (GSEUtil.Ensure(bGW_EventCollection != null))
		{
			bGW_EventCollection.Evt_OnSeamlessTravelTransition();
		}
	}

	static BGW_GameLifeTimeMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GameLifeTimeMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GameLifeTimeMgr));
		sActOnPostLoadMap = delegate
		{
		};
		sActOnPreLoadMap = delegate
		{
		};
		FCoreUObjectDelegates.PostLoadMapWithWorld.Bind(sOnPostLoadMap);
		FCoreUObjectDelegates.PreLoadMap.Bind(sOnPreLoadMap);
		FWorldDelegates.OnSeamlessTravelStart.Bind(sOnSeamLessTravelStart);
		FWorldDelegates.OnSeamlessTravelTransition.Bind(sOnSeamlessTravelTransition);
	}

	public void StartOpenLevel()
	{
		IsOpeningLevelValid = true;
	}

	public override void OnInit()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_BGW_GameInstanceStart = (BGW_EventCollection.Del_BGW_GameInstanceStart)Delegate.Combine(bGW_EventCollection.Evt_BGW_GameInstanceStart, new BGW_EventCollection.Del_BGW_GameInstanceStart(OnGameInstanceStart));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_BGW_TriggerGlobalFSMEvent = (BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent)Delegate.Combine(bGW_EventCollection2.Evt_BGW_TriggerGlobalFSMEvent, new BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent(OnTriggerGlobalFSMEvent));
		BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(this);
		bGW_EventCollection3.Evt_OnPlayerPostLogin = (b1.EventDelDefine.Del_Void)Delegate.Combine(bGW_EventCollection3.Evt_OnPlayerPostLogin, new b1.EventDelDefine.Del_Void(OnAnyPlayerPostLogin));
		BGW_EventCollection bGW_EventCollection4 = BGW_EventCollection.Get(this);
		bGW_EventCollection4.Evt_leavingMap = (b1.EventDelDefine.Del_Void)Delegate.Combine(bGW_EventCollection4.Evt_leavingMap, (b1.EventDelDefine.Del_Void)delegate
		{
			if (!IsOpeningLevelValid)
			{
				BGW_EventCollection.Get(this).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.UnKnowLevelTravel);
			}
		});
		sActOnPostLoadMap = (FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature)Delegate.Combine(sActOnPostLoadMap, new FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature(OnPostLoadMapWithWorld));
		sActOnPreLoadMap = (FCoreUObjectDelegates.PreLoadMapHandler.Signature)Delegate.Combine(sActOnPreLoadMap, new FCoreUObjectDelegates.PreLoadMapHandler.Signature(OnPreLoadMap));
	}

	private void OnPostLoadMapWithWorld(UObject loadedWorld)
	{
		if (!(loadedWorld == null) && !(BGWGameInstanceCS.Get(loadedWorld) != BGWGameInstanceCS.Get(this)))
		{
			IsOpeningLevelValid = false;
			BGW_EventCollection.Get(this).Evt_PostLoadMapWithWorld();
			BGWGameInstanceCS.Get(this)?.OnPostLoadMap();
			GSSkillCastChecker.Get()?.Clear();
			if (!HasInited)
			{
				InitOnStartUp();
			}
			GraphicDeviceCheckLogic(loadedWorld);
		}
	}

	private void OnPreLoadMap(string MapName)
	{
		BGW_EventCollection.Get(this)?.Evt_PreLoadMap(MapName);
		RTXCheckLogic(MapName);
	}

	private void RTXCheckLogic(string MapName)
	{
		if (!GSEUtil.Ensure(MapName != null))
		{
			return;
		}
		string text = MapName.Split('/')[^1];
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.RTX.NextMapEnableRTX");
		IConsoleVariable consoleVariable2 = IConsoleManager.Get().FindConsoleVariable("r.RayTracing.EnableInGame");
		int cVValueleByType = BGW_SettingMgrV2.Get(this).GetCVValueleByType(UISettingConfigType.RtxLevel);
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		if (consoleVariable2.GetInt() > 0)
		{
			LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(BGUFuncLibMap.GetLevelIdByName(text));
			if (levelDesc != null)
			{
				bool flag = false;
				if (DebugConfig.DebugRtxEnableLevel != "" && DebugConfig.DebugRtxEnableLevel.Contains(text))
				{
					flag = true;
				}
				if (levelDesc.RtxEnable > 0 || flag)
				{
					consoleVariable.Set(1);
					UGSE_GSGameSettingsFuncLib.SetRayTracingQuality(cVValueleByType);
				}
				else
				{
					consoleVariable.Set(0);
					UGSE_GSGameSettingsFuncLib.SetRayTracingQuality(0);
				}
				gameUserSettings.ApplyNonResolutionSettings();
			}
		}
		else
		{
			consoleVariable.Set(-1);
			UGSE_GSGameSettingsFuncLib.SetRayTracingQuality(0);
		}
	}

	private void GraphicDeviceCheckLogic(UObject loadedWorld)
	{
		int textureQuality = UGameUserSettings.GetGameUserSettings().GetTextureQuality();
		BGW_SettingFuncUtil.ProcessLowFeatureLevelGPULandscape(loadedWorld, textureQuality);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		sActOnPostLoadMap = (FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature)Delegate.Remove(sActOnPostLoadMap, new FCoreUObjectDelegates.PostLoadMapWithWorldHandler.Signature(OnPostLoadMapWithWorld));
		sActOnPreLoadMap = (FCoreUObjectDelegates.PreLoadMapHandler.Signature)Delegate.Remove(sActOnPreLoadMap, new FCoreUObjectDelegates.PreLoadMapHandler.Signature(OnPreLoadMap));
		GSSkillCastChecker.Get()?.Clear();
	}

	public void OnTriggerGlobalFSMEvent(EGI_Global Event, object InputParams)
	{
		GlobalFSMInstance.TriggerEvent(Event, InputParams);
	}

	protected bool StartUpGameModeIs<T>() where T : AGameMode
	{
		AWorldSettings worldSettings = BGWGameInstanceCS.Get(this).GetWorldForCS().GetWorldSettings();
		if (worldSettings == null)
		{
			return false;
		}
		TSubclassOf<AGameModeBase> tSubclassOf = ((worldSettings.DefaultGameMode != null) ? worldSettings.DefaultGameMode : UGSE_EngineFuncLib.GetProjectSettingDefaultGameMode());
		if (tSubclassOf == null)
		{
			return false;
		}
		return tSubclassOf.Value.ClassDefaultObject as T != null;
	}

	protected void InitOnStartUp()
	{
		if (HasInited)
		{
			return;
		}
		HasInited = true;
		if (UGSE_EngineFuncLib.IsDedicateServer(BGWGameInstanceCS.Get(this).GetWorldForCS()))
		{
			GlobalFSMInstance = BGW_EventCollection.Get(this).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Global/CFSMG_GI_Global_DS.CFSMG_GI_Global_DS", new FSMContext_GI_Global(), BGWGameInstanceCS.Get(this)) as FSMRuntimeInstance_GI_Global;
			return;
		}
		if (DebugConfig.Debug820Demo)
		{
			GlobalFSMInstance = BGW_EventCollection.Get(this).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Global/CFSMG_GI_Global_820Demo.CFSMG_GI_Global_820Demo", new FSMContext_GI_Global(), BGWGameInstanceCS.Get(this)) as FSMRuntimeInstance_GI_Global;
		}
		else if (DebugConfig.CricketBattleMode)
		{
			GlobalFSMInstance = BGW_EventCollection.Get(this).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Global/CFSMG_GI_Global_CricketBattle.CFSMG_GI_Global_CricketBattle", new FSMContext_GI_Global(), BGWGameInstanceCS.Get(this)) as FSMRuntimeInstance_GI_Global;
		}
		else
		{
			GlobalFSMInstance = BGW_EventCollection.Get(this).Evt_BGW_CFSMGStart("/Game/00Main/DataAsset/CFSMG/GI_Global/CFSMG_GI_Global_V2.CFSMG_GI_Global_V2", new FSMContext_GI_Global(), BGWGameInstanceCS.Get(this)) as FSMRuntimeInstance_GI_Global;
		}
		InitLoadingCalled = true;
		if ((StartType == EStartGameInstanceTypeForCS.StartCS_PIE_DedicateServer || StartType == EStartGameInstanceTypeForCS.StartCS_PIE_ListenServer) && !StartUpGameModeIs<BGG_GameModeB1>())
		{
			FMessage.OpenDialog("正在使用联机调试模式 GameMode配置有误 请使用BP_GameMode！");
		}
		switch (StartType)
		{
		case EStartGameInstanceTypeForCS.StartCS_DedicateServer:
		case EStartGameInstanceTypeForCS.StartCS_PIE_DedicateServer:
			GlobalFSMInstance.TriggerEvent(EGI_Global.ToiletDedicateServer);
			break;
		case EStartGameInstanceTypeForCS.StartCS_PIE_Client:
			GlobalFSMInstance.TriggerEvent(EGI_Global.ToiletClient);
			break;
		case EStartGameInstanceTypeForCS.StartCS_PIE_ListenServer:
			GlobalFSMInstance.TriggerEvent(EGI_Global.ToiletListenServer);
			break;
		case EStartGameInstanceTypeForCS.StartCS_StandAlone:
		case EStartGameInstanceTypeForCS.StartCS_PIE_Standalone:
			if (StartUpGameModeIs<BGG_GameModeB1>())
			{
				GlobalFSMInstance.TriggerEvent(EGI_Global.ToiletStandAlone);
			}
			else if (StartUpGameModeIs<BGG_GameModeStartUp>())
			{
				GlobalFSMInstance.TriggerEvent(EGI_Global.StartUp);
			}
			else if (BGUFuncLibMap.IsInWXLogin(this))
			{
				GlobalFSMInstance.TriggerEvent(EGI_Global.WXLogin);
			}
			break;
		}
	}

	public void OnGameInstanceStart(EStartGameInstanceTypeForCS StartType)
	{
		this.StartType = StartType;
		if (FGlobals.IsEditor || StartType != EStartGameInstanceTypeForCS.StartCS_StandAlone)
		{
			InitOnStartUp();
		}
	}

	public void OnAnyPlayerPostLogin()
	{
		InitOnStartUp();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_GameLifeTimeMgr");
	}
}
