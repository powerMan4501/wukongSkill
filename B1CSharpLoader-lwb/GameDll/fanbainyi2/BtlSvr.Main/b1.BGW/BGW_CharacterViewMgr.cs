using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using b1.Plugins.ConsoleVariableManager;
using b1.Util;
using B1UI.GSUI;
using BtlB1;
using CommB1;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1.BGW;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_CharacterViewMgr")]
public class BGW_CharacterViewMgr : GameInstanceSystemBaseUObj
{
	public static readonly FName CharacterViewLevelPath;

	public static readonly FName CharacterViewLevelName;

	private UObject WorldContext;

	private FName levelPackageName;

	private Dictionary<EquipPosition, FName> EquipCameraConfigDic;

	private b1.BGUEquipPreviewActorBase EquipPreviewPlayer;

	private Dictionary<ESoakingCamera, FName> SteepCameraConfigDic;

	private Dictionary<int, AActor> LegacyActorDic = new Dictionary<int, AActor>();

	private AActor LegacyPreviewCon;

	private AActor LegacyPreview;

	private Dictionary<int, AActor> TransPreviewActorConDic = new Dictionary<int, AActor>();

	private Dictionary<int, AActor> TransPreviewActorDic = new Dictionary<int, AActor>();

	private int CurTransActorIdx;

	private AActor CurTransPreviewActor;

	private AActor SoulPreviewCon;

	private int CurSoulActorID;

	private b1.BGUTransPreviewActorBase CurSoulPreviewActor;

	private AActor DefaultSoulPreviewActor;

	private UNiagaraComponent DefaultSoulPreviewFX;

	private UNiagaraComponent UpgradeSoulPreviewFX;

	private float LastSoulFXIndex = -1f;

	private bool FXOpacityStart;

	private float FXOpacityFrom;

	private float FXOpacity;

	private float FXOpacityTo;

	private float FXOpacityTimeCheck;

	private float FXOpacityTime = 0.4f;

	private ANiagaraActor MedicineFX;

	private int GamePlayDispReqID = -1;

	private int SoakingDispReqID = -1;

	private AActor AccessoryPreviewCon;

	private AActor AccessoryPreview;

	private AActor FabaoPreviewCon;

	private AActor FabaoPreview;

	private AActor ItemPreviewCon;

	private AActor ItemPreviewPointCon;

	private AActor ItemPreview;

	private AActor AntiquePreviewCon;

	private AActor AntiquePreview;

	private AActor MonsterPreviewCon;

	private AActor MonsterPreview;

	private UPrimitiveComponent MeshMonsterCharacter;

	private UMaterialInstanceDynamic MIMonsterCharacter;

	private UPrimitiveComponent MeshMonsterPiece;

	private UMaterialInstanceDynamic MIMonsterPiece;

	private int MonsterID;

	private bool IsMonsterFirst;

	private AActor BossIterationsScrollCon;

	private AActor BossIterationsScroll;

	public bool IsOpenCharacterView;

	private BGUSeqAKBActor BlendStateActor;

	private BGUSeqAKBActor LegacyBlendStateActor;

	private BGUSeqAKBActor ManualBlendStateActor;

	private Action EnterCallBack;

	private Action BackCallBack;

	private SteepActorsData SteepActors;

	private AActor MainPreviewCamera;

	private ULevelStreaming CharacterViewLevel;

	private AActor TempTarget;

	private int NeedResumeAllLevelDistanceStreamingDelay = -1;

	private static FVector PlayerLocationBefore;

	private int NeedBackCallBackNum;

	private int CheckExitLevelNum;

	private bool IsInLevel;

	private const string VirtualShadow_Cvar = "r.Shadow.Virtual.Enable";

	private const string PointLightShadow_Cvar = "r.AllowPointLightCubemapShadows";

	private const string TAA_Cvar = "r.DOF.DLSS.SceneColor.TAA";

	private const string RTGI_Cvar = "r.RayTracing.Globalillumination";

	private const string AOCompute_Cvar = "r.AmbientOcclusion.Compute";

	private const string OcclusionCull_Cvar = "r.InstanceCulling.OcclusionCull";

	private const string CameraCut_Cvar = "r.Test.CameraCut";

	private const string EyeAdaptationEnter_Cvar = "r.EyeAdaptation.EnterMenu";

	private const string EyeAdaptationExit_Cvar = "r.EyeAdaptation.ExitMenu";

	private const string ShadowCSMCache_Cvar = "r.Shadow.CacheWholeSceneShadows";

	private const string UpscalingForceOuputVelocity_Cvar = "r.BasePassUpscaleForceOutputsVelocity";

	private const string ShadowVSMCache_Cvar = "r.Shadow.Virtual.Cache";

	private const string MotionBlur_Cvar = "r.motionblur.amount";

	private const string NaniteCastLocal_Cvar = "r.Shadow.NaniteCastLocal";

	private const string NaniteShadowLodBias_Cvar = "r.Shadow.NaniteLODBias";

	private const string TSRDefectivePixelThreshold_Cvar = "r.TSR.DefectivePixel.Threshold";

	private const string FSRFIEnable_Cvar = "r.FidelityFX.FI.Enabled";

	private const string GrassTickInterval_Cvar = "grass.TickInterval";

	private Dictionary<int, UTexture> AsyncLoadTexDic = new Dictionary<int, UTexture>();

	private Action OnLevelLoadFinish;

	private static bool OnAKBStateEndFunc_IsValid;

	private static IntPtr OnAKBStateEndFunc_FunctionAddress;

	private static int OnAKBStateEndFunc_ParamsSize;

	private static bool OnAKBStateEndFunc_BeginStateName_IsValid;

	private static int OnAKBStateEndFunc_BeginStateName_Offset;

	private static bool OnAKBStateEndFunc_EndStateName_IsValid;

	private static int OnAKBStateEndFunc_EndStateName_Offset;

	private static bool OnAKBStateEndFunc_IsForceImSet_IsValid;

	private static int OnAKBStateEndFunc_IsForceImSet_Offset;

	private static FFieldAddress OnAKBStateEndFunc_IsForceImSet_PropertyAddress;

	public override bool bTickEnabled => true;

	public FVector CharacterViewLoc { get; private set; } = new FVector(600000.0, 400000.0, 40000.0);

	public bool IsSceneLoaded { get; private set; }

	public bool GMSetCVarIsIgnore(string CVarFullName, bool IsIgnore)
	{
		return CVarFuncLib.SetIsIgnored(CVarFullName, IsIgnore);
	}

	public override void OnInit()
	{
		EquipCameraConfigDic = new Dictionary<EquipPosition, FName>
		{
			{
				EquipPosition.Head,
				B1GlobalFNames.CPS_Head
			},
			{
				EquipPosition.Upwear,
				B1GlobalFNames.CPS_Upwear
			},
			{
				EquipPosition.Arm,
				B1GlobalFNames.CPS_Arm
			},
			{
				EquipPosition.Foot,
				B1GlobalFNames.CPS_Foot
			},
			{
				EquipPosition.Hulu,
				B1GlobalFNames.CPS_Hulu
			},
			{
				EquipPosition.Weapon,
				B1GlobalFNames.CPS_Weapon
			},
			{
				EquipPosition.Fabao,
				B1GlobalFNames.CPS_Fabao
			},
			{
				EquipPosition.Accessory,
				B1GlobalFNames.CPS_Accessory
			}
		};
		SteepCameraConfigDic = new Dictionary<ESoakingCamera, FName>
		{
			{
				ESoakingCamera.ObsMode,
				B1GlobalFNames.CPS_Steep_Ob
			},
			{
				ESoakingCamera.Main,
				B1GlobalFNames.CPS_Steep_Main
			},
			{
				ESoakingCamera.Liquor,
				B1GlobalFNames.CPS_Wine
			},
			{
				ESoakingCamera.Consume1,
				B1GlobalFNames.CPS_Steep_1
			},
			{
				ESoakingCamera.Consume2,
				B1GlobalFNames.CPS_Steep_2
			},
			{
				ESoakingCamera.Consume3,
				B1GlobalFNames.CPS_Steep_3
			},
			{
				ESoakingCamera.Consume4,
				B1GlobalFNames.CPS_Steep_4
			}
		};
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_leavingMap = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_leavingMap, new Del_Void(OnLeavingMap));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_UpdateCharacterViewEyeAdaptationEnter = (Action)Delegate.Combine(bGW_EventCollection2.Evt_UpdateCharacterViewEyeAdaptationEnter, new Action(UpdateCharacterViewEyeAdaptationEnter));
	}

	public void UpdateCharacterViewEyeAdaptationEnter()
	{
		SetCvar("r.EyeAdaptation.EnterMenu", 1, 1, 1, EConsoleVariablePriority.UI);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			BlendStateActor.DoTick(DeltaTime);
		}
		if (!LegacyBlendStateActor.IsNullOrDestroyed())
		{
			LegacyBlendStateActor.DoTick(DeltaTime);
		}
		if (!ManualBlendStateActor.IsNullOrDestroyed())
		{
			ManualBlendStateActor.DoTick(DeltaTime);
		}
		if (NeedResumeAllLevelDistanceStreamingDelay >= 0)
		{
			if (NeedResumeAllLevelDistanceStreamingDelay == 0)
			{
				ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this) as ABGPPlayerController;
				if (aBGPPlayerController != null && aBGPPlayerController.GetViewTarget() == aBGPPlayerController.GetControlledPawn() && aBGPPlayerController.GetPendingViewTarget() == null)
				{
					BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
					if (bGW_LevelStreamingManger != null)
					{
						bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
						NeedResumeAllLevelDistanceStreamingDelay--;
					}
				}
			}
			else
			{
				NeedResumeAllLevelDistanceStreamingDelay--;
			}
		}
		if (NeedBackCallBackNum > 0)
		{
			NeedBackCallBackNum--;
			if (NeedBackCallBackNum == 0)
			{
				BackCallBack?.Invoke();
				BackCallBack = null;
			}
		}
		if (CheckExitLevelNum > 0)
		{
			CheckExitLevelNum--;
			if (CheckExitLevelNum == 0)
			{
				UGSE_ActorFuncLib.SetActorComponentsTickEnable(EquipPreviewPlayer, bEnable: false);
				UGSE_ActorFuncLib.SetActorComponentsTickEnable(MainPreviewCamera, bEnable: false);
			}
		}
		OverrideExposureCompensation();
		TickMonsterIcon(DeltaTime);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_leavingMap = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_leavingMap, new Del_Void(OnLeavingMap));
	}

	public static BGW_CharacterViewMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_CharacterViewMgr>(Context);
	}

	private void OnLeavingMap()
	{
		NotifySoundEngineEnterEvent(isEnter: false);
	}

	private void NotifySoundEngineEnterEvent(bool isEnter)
	{
		if (GSGameplayCVar.CVar_TempRemoveMuteLogic.GetValueInGameThread() <= 0)
		{
			if (isEnter)
			{
				UAkGameplayStatics.PostEventAtLocation(null, FVector.ZeroVector, FRotator.ZeroRotator, "EVT_system_zhuangbei_in_mute", base.Owner);
			}
			else
			{
				UAkGameplayStatics.PostEventAtLocation(null, FVector.ZeroVector, FRotator.ZeroRotator, "EVT_system_zhuangbei_out_unmute", base.Owner);
			}
		}
	}

	private void SetAllPreviewActorsIsHiddenInGame(bool IsHidden)
	{
		IsInLevel = !IsHidden;
		UGameplayStatics.GetAllActorsWithTag(WorldContext, B1GlobalFNames.CharPreviewMap, out var OutActors);
		for (int i = 0; i < OutActors.Count; i++)
		{
			_ = DebugConfig.IsDebugWidgetMore;
			OutActors[i].SetActorHiddenInGame(IsHidden);
			ANiagaraActor aNiagaraActor = OutActors[i] as ANiagaraActor;
			if (aNiagaraActor != null)
			{
				aNiagaraActor.NiagaraComponent.SetPaused(IsHidden);
			}
		}
		if (IsHidden)
		{
			EquipPreviewResetMontage();
			CheckExitLevelNum = 3;
		}
		else
		{
			CheckExitLevelNum = 0;
			UGSE_ActorFuncLib.SetActorComponentsTickEnable(EquipPreviewPlayer, bEnable: true);
			UGSE_ActorFuncLib.SetActorComponentsTickEnable(MainPreviewCamera, bEnable: true);
		}
	}

	public void ToggleCharacterView(bool bSwitchOn, CharacterViewType ViewType = CharacterViewType.EQUIP, Action InEnterCallBack = null, Action InBackCallBack = null)
	{
		TryPlayAudio(ViewType, bSwitchOn);
		GSEPerfTimeUtil.Start("CharacterViewMgr.ToggleCharacterView", out var PERFID);
		BGW_GCMgr.ManualGC();
		if (IsSceneLoaded)
		{
			NotifySoundEngineEnterEvent(bSwitchOn);
			BGW_ChapterViewMgr.Get(WorldContext).SetMipMapLODBias(!bSwitchOn);
			IsOpenCharacterView = bSwitchOn;
			if (bSwitchOn)
			{
				GSEPerfTimeUtil.Doing(PERFID, "InitPreviewPlayerEquip");
				InitPreviewPlayerEquip();
				GSEPerfTimeUtil.Doing(PERFID, "PauseAllLevelDistanceStreaming");
				BGW_LevelStreamingManger.Get(WorldContext).PauseAllLevelDistanceStreaming();
				SetAllPreviewActorsIsHiddenInGame(IsHidden: false);
				GSEPerfTimeUtil.Doing(PERFID, "ToggleCharacterViewCamera");
				ToggleCharacterViewCamera(bSwitchOn: true, ViewType);
				SetCvar("r.Shadow.Virtual.Enable", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.AllowPointLightCubemapShadows", 1, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.DOF.DLSS.SceneColor.TAA", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.RayTracing.Globalillumination", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.AmbientOcclusion.Compute", 9, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.InstanceCulling.OcclusionCull", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.motionblur.amount", 0f, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.Shadow.NaniteCastLocal", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.Shadow.NaniteLODBias", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.TSR.DefectivePixel.Threshold", 10000, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.FidelityFX.FI.Enabled", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("grass.TickInterval", 2, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.Test.CameraCut", 1, 5, 2, EConsoleVariablePriority.UI);
				SetCvar("r.Shadow.CacheWholeSceneShadows", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.BasePassUpscaleForceOutputsVelocity", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.Shadow.Virtual.Cache", 0, 1, -1, EConsoleVariablePriority.UI);
				GSEPerfTimeUtil.Doing(PERFID, "SetViewTargetWithBlend");
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
				if (firstLocalPlayerController == null)
				{
					BGW_LogUtil.LogError("CharacterViewMgr PlayerController IsNull");
					return;
				}
				firstLocalPlayerController.SetViewTargetWithBlend(MainPreviewCamera);
				APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
				if (controlledPawn != null)
				{
					PlayerLocationBefore = controlledPawn.GetActorLocation();
					UBGUWCStreamingFuncLib.SetStreamingManagerViewSource(PlayerLocationBefore, float.MaxValue);
				}
				GSEPerfTimeUtil.Doing(PERFID, "InvokeCallBack");
				EnterCallBack = InEnterCallBack;
				EnterCallBack?.Invoke();
				EnterCallBack = null;
			}
			else
			{
				GSEPerfTimeUtil.Doing(PERFID, "ResetItemPreview");
				ResetItemPreview();
				ResetFabaoPreview();
				ResetAccessoryoPreview();
				ResetMonsterPreview();
				ResetMonsterCharacter();
				ResetTransPreview();
				ResetSoulPreview();
				ResetLegacyPreview();
				ResetBossIterationsScroll();
				GSEPerfTimeUtil.Doing(PERFID, "HideAllActors");
				SetAllPreviewActorsIsHiddenInGame(IsHidden: true);
				NeedResumeAllLevelDistanceStreamingDelay = 2;
				SetCvar("r.Test.CameraCut", 1, 5, 2, EConsoleVariablePriority.UI);
				SetCvar("r.EyeAdaptation.ExitMenu", 1, 5, 10, EConsoleVariablePriority.UI);
				ResetAllManagedCvarByType(1, 4);
				UBGUWCStreamingFuncLib.SetStreamingManagerViewSource(PlayerLocationBefore, -1f);
				GSEPerfTimeUtil.Doing(PERFID, "ToggleCharacterViewCamera");
				ToggleCharacterViewCamera(bSwitchOn: false);
				NeedBackCallBackNum = 2;
				BackCallBack = InBackCallBack;
			}
		}
		GSEPerfTimeUtil.End(PERFID);
	}

	public void TryPlayAudio(CharacterViewType ViewType, bool IsEnter)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		ACharacter actor = firstLocalPlayerController.GetControlledPawn() as ACharacter;
		if (ViewType == CharacterViewType.EQUIP)
		{
			if (IsEnter)
			{
				UAkGameplayStatics.PostEvent(null, actor, 0, null, bStopWhenAttachedToDestroyed: false, "EVT_ui_global_interface_show");
			}
			else
			{
				UAkGameplayStatics.PostEvent(null, actor, 0, null, bStopWhenAttachedToDestroyed: false, "EVT_ui_global_interface_disappear");
			}
		}
		else if (IsEnter)
		{
			UAkGameplayStatics.PostEvent(null, actor, 0, null, bStopWhenAttachedToDestroyed: false, "UI_Global_Show");
		}
		else
		{
			UAkGameplayStatics.PostEvent(null, actor, 0, null, bStopWhenAttachedToDestroyed: false, "UI_Global_Disappear");
		}
	}

	private void ResetAllObject()
	{
		if (!EquipPreviewPlayer.IsNullOrDestroyed())
		{
			BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(EquipPreviewPlayer);
			if (bUS_DispLibEventCollection != null)
			{
				if (GamePlayDispReqID > 0)
				{
					bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(GamePlayDispReqID);
				}
				bUS_DispLibEventCollection.Evt_DispLibPreDestroy();
			}
		}
		EquipPreviewPlayer = null;
		ResetFabaoPreview();
		ResetAccessoryoPreview();
		ResetTransPreview();
		TransPreviewActorConDic.Clear();
		ResetSoulPreview();
		ItemPreviewCon = null;
		ResetItemPreview();
		if (SteepActors != null)
		{
			SteepActors.ResetAllPreview();
		}
		MonsterPreviewCon = null;
		ResetMonsterPreview();
		ResetLegacyPreview();
		LegacyActorDic.Clear();
		AsyncLoadTexDic.Clear();
		BossIterationsScrollCon = null;
		ResetBossIterationsScroll();
	}

	public void ResetItemPreview()
	{
		if (!ItemPreviewPointCon.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(ItemPreviewPointCon);
		}
		ItemPreviewPointCon = null;
		if (!ItemPreview.IsNullOrDestroyed())
		{
			ItemPreview.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(ItemPreview);
		}
		ItemPreview = null;
		CheckNeedGC();
	}

	public void ResetMonsterPreview()
	{
		if (!MonsterPreview.IsNullOrDestroyed())
		{
			MonsterPreview.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(MonsterPreview);
		}
		MonsterPreview = null;
		MonsterID = -1;
		AsyncLoadTexDic.Clear();
	}

	private void ResetMonsterCharacter()
	{
		UpdateMonsterIcon(0);
	}

	public void ResetTransPreview()
	{
		foreach (KeyValuePair<int, AActor> item in TransPreviewActorDic)
		{
			BGU_UnrealWorldUtil.DestroyActor(item.Value);
		}
		TransPreviewActorDic.Clear();
		CurTransPreviewActor = null;
		CurTransActorIdx = 0;
		CheckNeedGC();
	}

	public override void OnPostLoadMap()
	{
		base.OnPostLoadMap();
		UnloadLevel();
		IsOpenCharacterView = false;
	}

	public void InitLoadLevel(Action OnLoadFinish = null)
	{
		WorldContext = UGameplayStatics.GetGameInstance(this);
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		UGameplayStatics.GetAllActorsWithTag(WorldContext, B1GlobalFNames.CharPreviewMapCon, out var OutActors);
		if (OutActors.Count > 0)
		{
			CharacterViewLoc = OutActors[0].GetActorLocation();
		}
		levelPackageName = bGW_LevelStreamingManger.AddLevelStreaming(CharacterViewLevelPath, CharacterViewLoc, new FRotator(0.0, 0.0, 0.0), bShouldBlockOnLoad: true);
		OnLevelLoadFinish = OnLoadFinish;
		bGW_LevelStreamingManger.LoadLevelStreaming(levelPackageName, OnLevelLoaded, bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true);
		UBGUFunctionLibrary.BGUUpdateLevelStreaming(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext));
		UBGUFunctionLibrary.BGUProcessLatentActions(WorldContext, bGW_LevelStreamingManger, 0f);
	}

	private void OnLevelLoaded(FName LevelName, int State)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<b1.BGUEquipPreviewActorBase>(), B1GlobalFNames.EquipPreviewPlayer, out var OutActors);
		foreach (AActor item in OutActors)
		{
			EquipPreviewPlayer = item.Cast<b1.BGUEquipPreviewActorBase>();
		}
		if (EquipPreviewPlayer != null)
		{
			EquipPreviewPlayer.GetComponentByClass<USkeletalMeshComponent>()?.SetHiddenInGame(NewHidden: true);
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.FabaoPreviewCon, out var OutActors2);
		foreach (AActor item2 in OutActors2)
		{
			FabaoPreviewCon = item2;
		}
		AccessoryPreviewCon = FabaoPreviewCon;
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.DefaultSoulActor, out var OutActors3);
		using (List<AActor>.Enumerator enumerator = OutActors3.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current3 = enumerator.Current;
				DefaultSoulPreviewActor = current3;
				foreach (UActorComponent item3 in DefaultSoulPreviewActor.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>()))
				{
					UNiagaraComponent uNiagaraComponent = item3 as UNiagaraComponent;
					if (!(uNiagaraComponent == null))
					{
						if (uNiagaraComponent.ComponentHasTag(B1GlobalFNames.DefaultSoulFX))
						{
							DefaultSoulPreviewFX = uNiagaraComponent;
						}
						if (uNiagaraComponent.ComponentHasTag(B1GlobalFNames.UpgradeSoulFX))
						{
							UpgradeSoulPreviewFX = uNiagaraComponent;
							UpgradeSoulPreviewFX.SetActive(bNewActive: false);
						}
					}
				}
			}
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.SoulPreviewCon, out var OutActors4);
		using (List<AActor>.Enumerator enumerator = OutActors4.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				AActor current4 = enumerator.Current;
				SoulPreviewCon = current4;
			}
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.ItemPreviewCon, out var OutActors5);
		foreach (AActor item4 in OutActors5)
		{
			ItemPreviewCon = item4;
		}
		SteepActors = new SteepActorsData();
		SteepActors.InitCon(WorldContext);
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.MonsterPreviewCon, out var OutActors6);
		foreach (AActor item5 in OutActors6)
		{
			MonsterPreviewCon = item5;
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.MonsterBook, out var OutActors7);
		if (OutActors7.Count > 0)
		{
			AActor aActor = OutActors7[0];
			List<UActorComponent> componentsByTag = aActor.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.MonsterBook);
			if (componentsByTag.Count > 0)
			{
				MeshMonsterCharacter = componentsByTag[0] as UPrimitiveComponent;
				MIMonsterCharacter = MeshMonsterCharacter.CreateDynamicMaterialInstance(0, MeshMonsterCharacter.GetMaterial(0), FName.None);
			}
			List<UActorComponent> componentsByTag2 = aActor.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.MonsterPiece);
			if (componentsByTag2.Count > 0)
			{
				MeshMonsterPiece = componentsByTag2[0] as UPrimitiveComponent;
				MIMonsterPiece = MeshMonsterPiece.CreateDynamicMaterialInstance(0, MeshMonsterPiece.GetMaterial(0), FName.None);
			}
			ResetMonsterCharacter();
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.LegacyPreviewCon, out var OutActors8);
		foreach (AActor item6 in OutActors8)
		{
			LegacyPreviewCon = item6;
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.LiandanBurstVFX, out var OutActors9);
		foreach (AActor item7 in OutActors9)
		{
			MedicineFX = item7 as ANiagaraActor;
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), B1GlobalFNames.BossIterationsScrollCon, out var OutActors10);
		foreach (AActor item8 in OutActors10)
		{
			BossIterationsScrollCon = item8;
		}
		MainPreviewCamera = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CharPreMainCamera);
		if (MainPreviewCamera == null)
		{
			BGW_LogUtil.LogError("CharacterViewMgr MainPreviewCamera IsNull");
		}
		CharacterViewLevel = UGameplayStatics.GetStreamingLevel(WorldContext, CharacterViewLevelName);
		SetAllPreviewActorsIsHiddenInGame(IsHidden: true);
		IsSceneLoaded = true;
		InitBlendStateActor();
		InitTransPreviewActorConDic();
		OnLevelLoadFinish?.Invoke();
		OnLevelLoadFinish = null;
	}

	private void UnloadLevel()
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(WorldContext);
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
			bGW_LevelStreamingManger.RemoveLevelStreaming(CharacterViewLevelPath);
			IsSceneLoaded = false;
			ResetAllObject();
		}
	}

	public void InitPreviewPlayerEquip()
	{
		if (EquipPreviewPlayer == null)
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (!(firstLocalPlayerController != null))
		{
			return;
		}
		foreach (ReadOnlyWearEquip equip in BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController).RoleData.RoleCs.Actor.Wear.EquipList)
		{
			ChangePlayerEquip(equip.Position, equip.Id, IsChange: false);
		}
	}

	public void InitTransPreviewActorConDic()
	{
		foreach (KeyValuePair<int, FUStPlayerTransAttrDesc> item in BGW_GameDB.GetAllPlayerTransAttrDesc())
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(WorldContext, UClass.GetClass<AActor>(), new FName($"UnitTransCon_{item.Value.ID}"), out var OutActors);
			foreach (AActor item2 in OutActors)
			{
				if (!TransPreviewActorConDic.TryGetValue(item.Key, out var _))
				{
					TransPreviewActorConDic.Add(item.Key, item2);
					break;
				}
			}
		}
	}

	private void ToggleCharacterViewCamera(bool bSwitchOn, CharacterViewType ViewType = CharacterViewType.EQUIP)
	{
		if (bSwitchOn)
		{
			switch (ViewType)
			{
			case CharacterViewType.EQUIP:
				SwitchEquipCamera(EquipPosition.EnumMax, IsForce: true);
				break;
			case CharacterViewType.SHOP:
				SwitchItemCamera(0f);
				break;
			default:
				SwitchBlackCamera(IsForce: true);
				break;
			}
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(firstLocalPlayerController == null))
		{
			ACharacter aCharacter = firstLocalPlayerController.GetControlledPawn() as ACharacter;
			if (!aCharacter.IsNullOrDestroyed())
			{
				firstLocalPlayerController.SetViewTargetWithBlend(aCharacter);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_CharacterViewMgr:OnAKBStateEndFunc")]
	public void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsForceImSet)
	{
	}

	private void InitBlendStateActor()
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CharPreAKBSeqActor);
		if (aActor == null)
		{
			return;
		}
		BlendStateActor = aActor.Cast<BGUSeqAKBActor>();
		if (BlendStateActor == null)
		{
			return;
		}
		BlendStateActor.GSInit();
		AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CharLegacyAKBSeqActor);
		if (aActor2 == null)
		{
			return;
		}
		LegacyBlendStateActor = aActor2.Cast<BGUSeqAKBActor>();
		if (LegacyBlendStateActor == null)
		{
			return;
		}
		LegacyBlendStateActor.GSInit();
		AActor aActor3 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CharManualAKBSeqActor);
		if (!(aActor3 == null))
		{
			ManualBlendStateActor = aActor3.Cast<BGUSeqAKBActor>();
			if (!(ManualBlendStateActor == null))
			{
				ManualBlendStateActor.GSInit();
				ManualBlendStateActor.BindDelegateToOnAKBStateEnd(OnAKBStateEndFunc);
				ManualBlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_ManualOff);
			}
		}
	}

	public float GetAKBToStateTime(FName StateName)
	{
		if (BlendStateActor == null)
		{
			return 0f;
		}
		BlendStateActor.GetPredicToStateCfgEasingTime(StateName, out var PredicCfgEasingTime, out var PredicCfgDelayEasingTime);
		return PredicCfgEasingTime + PredicCfgDelayEasingTime;
	}

	public void ChangeItemPreview(int ItemID)
	{
		ResetItemPreview();
		if (ItemID == 0)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetItemPreviewPath(ItemID), EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			ItemPreview = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (ItemPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeItemPreview]ItemPreview = null,ItemID = {ItemID}");
			}
			else if (!ItemPreviewCon.IsNullOrDestroyed())
			{
				ItemPreview.AttachToActor(ItemPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public void RotateItemPreview(FRotator Offset)
	{
		if (!ItemPreview.IsNullOrDestroyed())
		{
			ItemPreview.AddActorWorldRotation(Offset, bSweep: false, out var _, bTeleport: false);
		}
	}

	public AActor GetItemPreviewActor()
	{
		if (ItemPreview.IsNullOrDestroyed())
		{
			return null;
		}
		return ItemPreview;
	}

	public void SwitchItemCamera(float BlendTime = 0.5f)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Item);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_Item);
			}
		}
	}

	private void TickMonsterIcon(float DeltaTime)
	{
		if (AsyncLoadTexDic.Count == 0)
		{
			return;
		}
		foreach (UTexture value2 in AsyncLoadTexDic.Values)
		{
			if (value2 == null)
			{
				return;
			}
		}
		BGWMonsterManualConfigDataAsset monsterManualConfigDataAsset = BGW_PreloadAssetMgr.Get(WorldContext).MonsterManualConfigDataAsset;
		if (monsterManualConfigDataAsset.MonsterManualInfoMap.TryGetValue(MonsterID, out var value))
		{
			MIMonsterPiece.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_MainTex, AsyncLoadTexDic[0]);
			MIMonsterPiece.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_ProgressTex, AsyncLoadTexDic[1]);
			foreach (KeyValuePair<FName, float> item in value.ScalarParameterMap)
			{
				MIMonsterPiece.SetScalarParameterValue(item.Key, item.Value);
				MIMonsterPiece.SetScalarParameterValue(item.Key, item.Value);
			}
			foreach (KeyValuePair<FName, FLinearColor> item2 in value.VectorParameterMap)
			{
				MIMonsterPiece.SetVectorParameterValue(item2.Key, item2.Value);
				MIMonsterPiece.SetVectorParameterValue(item2.Key, item2.Value);
			}
			UMaterialLibrary.SetScalarParameterValue(WorldContext, monsterManualConfigDataAsset.MPCBook, B1GlobalFNames.GSMIParameter_isSpecialPic, 1f);
			MeshMonsterPiece.SetVisibility(bNewVisibility: true);
		}
		else
		{
			MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_MainTex, AsyncLoadTexDic[0]);
			MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_ProgressTex, AsyncLoadTexDic[1]);
			MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_StrokeEffectTex, AsyncLoadTexDic[2]);
			MeshMonsterPiece.SetVisibility(bNewVisibility: false);
			UMaterialLibrary.SetScalarParameterValue(WorldContext, monsterManualConfigDataAsset.MPCBook, B1GlobalFNames.GSMIParameter_isSpecialPic, 0f);
		}
		AsyncLoadTexDic.Clear();
	}

	public float GetManualAKBToStateTime(FName StateName)
	{
		if (ManualBlendStateActor == null)
		{
			return 0f;
		}
		ManualBlendStateActor.GetPredicToStateCfgEasingTime(StateName, out var PredicCfgEasingTime, out var PredicCfgDelayEasingTime);
		return PredicCfgEasingTime + PredicCfgDelayEasingTime;
	}

	public void SwitchManualCamera(FName TargetName, bool IsForce = false)
	{
		if (!ManualBlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				ManualBlendStateActor.ForceSetStateImmediately(TargetName);
			}
			else
			{
				ManualBlendStateActor.ToState(TargetName);
			}
		}
	}

	public void UpdateMonsterIcon(int MonsterID)
	{
		if (MIMonsterCharacter == null || MIMonsterPiece == null)
		{
			return;
		}
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookIconPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null)
			{
				UTexture uTexture = Obj as UTexture;
				if (uTexture != null)
				{
					MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_MainTex, uTexture);
					MIMonsterPiece.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_MainTex, uTexture);
				}
			}
		});
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookMaskPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null)
			{
				UTexture uTexture = Obj as UTexture;
				if (uTexture != null)
				{
					MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_ProgressTex, uTexture);
					MIMonsterPiece.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_ProgressTex, uTexture);
				}
			}
		});
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookStrokePath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null)
			{
				UTexture uTexture = Obj as UTexture;
				if (uTexture != null)
				{
					MIMonsterCharacter.SetTextureParameterValue(B1GlobalFNames.GSMIParameter_StrokeEffectTex, uTexture);
				}
			}
		});
	}

	public bool ChangeMonsterPreviewTrue(int ResID, FName TargetState, int ParamFirst, int ParamFull)
	{
		if (ResID == -1 || ResID == 0)
		{
			return false;
		}
		MonsterID = ResID;
		AsyncLoadTexDic.Clear();
		AsyncLoadTexDic.Add(0, null);
		AsyncLoadTexDic.Add(1, null);
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookIconPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null && ReqID == MonsterID)
			{
				AsyncLoadTexDic[0] = Obj as UTexture;
			}
		}, MonsterID);
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookMaskPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null && ReqID == MonsterID)
			{
				AsyncLoadTexDic[1] = Obj as UTexture;
			}
		}, MonsterID);
		if (BGW_PreloadAssetMgr.Get(WorldContext).MonsterManualConfigDataAsset.MonsterManualInfoMap.ContainsKey(MonsterID))
		{
			MIMonsterPiece.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsFirstTime, ParamFirst);
			MIMonsterPiece.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsFullUnlock, ParamFull);
		}
		else
		{
			AsyncLoadTexDic.Add(2, null);
			BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookStrokePath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
			{
				if (Obj != null && ReqID == MonsterID)
				{
					AsyncLoadTexDic[2] = Obj as UTexture;
				}
			}, MonsterID);
			MIMonsterCharacter.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsFirstTime, ParamFirst);
			MIMonsterCharacter.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_IsFullUnlock, ParamFull);
		}
		if (BlendStateActor.IsNullOrDestroyed())
		{
			return false;
		}
		SwitchManualCamera(TargetState);
		return true;
	}

	public bool GetMonsterPreviewChanging()
	{
		return AsyncLoadTexDic.Count != 0;
	}

	public int GetMonsterPreviewId()
	{
		return MonsterID;
	}

	public bool ChangeMonsterPreviewTrue(int ResID)
	{
		if (ResID == -1 || ResID == 0)
		{
			return false;
		}
		MonsterID = ResID;
		AsyncLoadTexDic.Clear();
		AsyncLoadTexDic.Add(0, null);
		AsyncLoadTexDic.Add(1, null);
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookIconPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null && ReqID == MonsterID)
			{
				AsyncLoadTexDic[0] = Obj as UTexture;
			}
		}, MonsterID);
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookMaskPath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj != null && ReqID == MonsterID)
			{
				AsyncLoadTexDic[1] = Obj as UTexture;
			}
		}, MonsterID);
		if (!BGW_PreloadAssetMgr.Get(WorldContext).MonsterManualConfigDataAsset.MonsterManualInfoMap.ContainsKey(MonsterID))
		{
			AsyncLoadTexDic.Add(2, null);
			BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UTexture>(GSUIResPathUtil.GetUnitBookStrokePath(MonsterID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
			{
				if (Obj != null && ReqID == MonsterID)
				{
					AsyncLoadTexDic[2] = Obj as UTexture;
				}
			}, MonsterID);
		}
		return true;
	}

	public void ResetMIMonsterCharacterProgress()
	{
		MIMonsterCharacter.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_ProgressRemapCurve, 1f);
	}

	public void SwitchMonsterCamera(float BlendTime = 0.5f)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Monster_Manual);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_Monster_Manual);
			}
		}
	}

	public void SwitchMonsterFocusCamera(float BlendTime = 0.5f)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Monster_Manual_Focus);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_Monster_Manual_Focus);
			}
		}
	}

	public string GetMonsterMarkerIconMaskPath(SignStyle TargetStyle)
	{
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/Marker/T_HBMarker_{(int)TargetStyle}_Mask.T_HBMarker_{(int)TargetStyle}_Mask'";
	}

	public string GetMonsterMarkerIconPath(SignStyle TargetStyle)
	{
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/Marker/T_HBMarker_{(int)TargetStyle}_t.T_HBMarker_{(int)TargetStyle}_t'";
	}

	public string GetMonsterPoemIconMaskPath(int ResID)
	{
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPoem_{ResID}_Mask.T_HBPoem_{ResID}_Mask'";
	}

	public string GetMonsterPoemIconPath(int ResID)
	{
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPoem_{ResID}_t.T_HBPoem_{ResID}_t'";
	}

	public string GetMonsterCharacterIconMaskPath(int ResID)
	{
		if (ResID == 0)
		{
			return "Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPic_None_Mask.T_HBPic_None_Mask'";
		}
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPic_{ResID}_Mask.T_HBPic_{ResID}_Mask'";
	}

	public string GetMonsterCharacterIconPath(int ResID)
	{
		if (ResID == 0)
		{
			return "Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPic_None.T_HBPic_None'";
		}
		return $"Texture2D'/Game/00Main/Design/Blueprints/Manual/T_HBPic_{ResID}_t.T_HBPic_{ResID}_t'";
	}

	public void SwitchLegacyCamera(float BlendTime = 0.5f)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_Legacy);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_Legacy);
			}
		}
	}

	public void SwitchLegacyViewCamera(float BlendTime = 0.5f)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_LegacyView);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_LegacyView);
			}
		}
	}

	public void ResetLegacyPreview()
	{
		if (!(LegacyPreview == null))
		{
			if (!LegacyPreview.IsNullOrDestroyed())
			{
				LegacyPreview.SetActorHiddenInGame(bNewHidden: true);
				BGU_UnrealWorldUtil.DestroyActor(LegacyPreview);
			}
			LegacyPreview = null;
			CheckNeedGC();
		}
	}

	public void ChangeLegacyPreview(int LegacyID)
	{
		if (LegacyID == -1)
		{
			return;
		}
		ResetLegacyPreview();
		if (LegacyID == 0)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		string path;
		switch (LegacyID)
		{
		default:
			return;
		case 1:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_1_Yan.Genqi_1_Yan_C";
			break;
		case 2:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_2_Er.Genqi_2_Er_C";
			break;
		case 3:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_3_Bi.Genqi_3_Bi_C";
			break;
		case 4:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_4_She.Genqi_4_She_C";
			break;
		case 5:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_5_Shen.Genqi_5_Shen_C";
			break;
		case 6:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_6_Yi.Genqi_6_Yi_C";
			break;
		case 7:
			path = "/Game/00Main/Design/Blueprints/Item/Genqi/GenqiV2/Genqi_7_Yi.Genqi_7_Yi_C";
			break;
		}
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(path, EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			LegacyPreview = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (LegacyPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeLegacyPreview] LegacyPreview = null, LegacyID = {LegacyID}");
			}
			else if (!LegacyPreviewCon.IsNullOrDestroyed())
			{
				LegacyPreview.AttachToActor(LegacyPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public AActor GetLegacyPreviewActor()
	{
		return LegacyPreview;
	}

	private void InitLegacyActorDic()
	{
		LegacyActorDic.Clear();
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.Legacy_Nose);
		if (aActor != null)
		{
			LegacyActorDic.Add(4093, aActor);
		}
		AActor aActor2 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.Legacy_Ear);
		if (aActor2 != null)
		{
			LegacyActorDic.Add(4092, aActor2);
		}
		AActor aActor3 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.Legacy_Tongue);
		if (aActor3 != null)
		{
			LegacyActorDic.Add(4094, aActor3);
		}
		AActor aActor4 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.Legacy_Body);
		if (aActor4 != null)
		{
			LegacyActorDic.Add(4095, aActor4);
		}
		AActor aActor5 = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.Legacy_Eye);
		if (aActor5 != null)
		{
			LegacyActorDic.Add(4091, aActor5);
		}
	}

	public void SwitchLegacyCamera(FName CPSName, bool IsForce = false)
	{
		SwitchTargetCamera(CPSName, IsForce);
	}

	public void UpdateLegacyActor(List<int> LegacyList)
	{
		foreach (KeyValuePair<int, AActor> item in LegacyActorDic)
		{
			if (LegacyList.Contains(item.Key))
			{
				item.Value.SetActorHiddenInGame(bNewHidden: false);
				UChildActorComponent componentByClass = item.Value.GetComponentByClass<UChildActorComponent>();
				if (componentByClass != null && componentByClass.ChildActorClass == null)
				{
					UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetItemPreviewPath(item.Key), EUIResourceLoadType.NoCache);
					componentByClass.SetChildActorClass(uClass);
				}
			}
			else
			{
				item.Value.SetActorHiddenInGame(bNewHidden: true);
			}
		}
	}

	public void FocusLegacy(int LegacyID, bool IsForce = false)
	{
		if (!LegacyBlendStateActor.IsNullOrDestroyed())
		{
			FName targetState = B1GlobalFNames.CPS_Legacy_None;
			switch (LegacyID)
			{
			case 4093:
				targetState = B1GlobalFNames.CPS_Legacy_Nose;
				break;
			case 4092:
				targetState = B1GlobalFNames.CPS_Legacy_Ear;
				break;
			case 4094:
				targetState = B1GlobalFNames.CPS_Legacy_Tongue;
				break;
			case 4095:
				targetState = B1GlobalFNames.CPS_Legacy_Body;
				break;
			case 4091:
				targetState = B1GlobalFNames.CPS_Legacy_Eye;
				break;
			}
			if (IsForce)
			{
				LegacyBlendStateActor.ForceSetStateImmediately(targetState);
			}
			else
			{
				LegacyBlendStateActor.ToState(targetState);
			}
		}
	}

	public void PlayLegacyActiveFX(int LegacyID)
	{
		if (EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		AActor legacyPreviewActor = GetLegacyPreviewActor();
		if (legacyPreviewActor.IsNullOrDestroyed())
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(legacyPreviewActor);
		if (bUS_DispLibEventCollection != null && BGW_PreloadAssetMgr.Get(this).EquipPreviewConfigDataAsset.LegacyActiveDBCDAMap.TryGetValue(LegacyID, out var value))
		{
			BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = value as BUC_DispLibDispBaseConfigDataAsset;
			if (bUC_DispLibDispBaseConfigDataAsset != null)
			{
				bUS_DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset?.Invoke(bUC_DispLibDispBaseConfigDataAsset, out var _, null, FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, GetUniqueID());
			}
		}
	}

	private void ChangeHuluPreview(int ItemID)
	{
		SteepActors.ChangeHuluPreview(WorldContext, ItemID);
	}

	private void ChangeLiquorPreview(int ItemID)
	{
		SteepActors.ChangeLiquorPreview(WorldContext, ItemID);
	}

	private void ChangeConsume1Preview(int ItemID)
	{
		SteepActors.ChangeConsume1Preview(WorldContext, ItemID);
	}

	private void ChangeConsume2Preview(int ItemID)
	{
		SteepActors.ChangeConsume2Preview(WorldContext, ItemID);
	}

	private void ChangeConsume3Preview(int ItemID)
	{
		SteepActors.ChangeConsume3Preview(WorldContext, ItemID);
	}

	private void ChangeConsume4Preview(int ItemID)
	{
		SteepActors.ChangeConsume4Preview(WorldContext, ItemID);
	}

	public void ChangeConsumePreview(ESoakingCamera SoakingCamera, int ItemId)
	{
		switch (SoakingCamera)
		{
		case ESoakingCamera.Liquor:
			ChangeLiquorPreview(ItemId);
			break;
		case ESoakingCamera.Consume1:
			ChangeConsume1Preview(ItemId);
			break;
		case ESoakingCamera.Consume2:
			ChangeConsume2Preview(ItemId);
			break;
		case ESoakingCamera.Consume3:
			ChangeConsume3Preview(ItemId);
			break;
		case ESoakingCamera.Consume4:
			ChangeConsume4Preview(ItemId);
			break;
		}
	}

	public AActor GetSoakingPreviewActor(ESoakingCamera SoakingCamera)
	{
		return SoakingCamera switch
		{
			ESoakingCamera.Liquor => SteepActors.GetLiquorPreview(), 
			ESoakingCamera.Consume1 => SteepActors.GetConsume1Preview(), 
			ESoakingCamera.Consume2 => SteepActors.GetConsume2Preview(), 
			ESoakingCamera.Consume3 => SteepActors.GetConsume3Preview(), 
			ESoakingCamera.Consume4 => SteepActors.GetConsume4Preview(), 
			_ => null, 
		};
	}

	public void ResetSteepPreview()
	{
		if (SteepActors != null)
		{
			SteepActors.ResetPreview();
		}
	}

	public void SwitchSteepCamera(ESoakingCamera SoakingCamera, float BlendTime = 0.5f)
	{
		if (!SteepCameraConfigDic.TryGetValue(SoakingCamera, out var value))
		{
			value = B1GlobalFNames.CPS_Steep_Main;
		}
		if (!BlendStateActor.IsNullOrDestroyed() && !(BlendStateActor.GetEndStateName() == value))
		{
			if (BlendTime == 0f)
			{
				BlendStateActor.ForceSetStateImmediately(value);
			}
			else
			{
				BlendStateActor.ToState(value);
			}
		}
	}

	public void PlaySoakingFX(ESoakingCamera SoakingCamera, EEquipFXType EquipFXType)
	{
		if (EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		AActor soakingPreviewActor = GetSoakingPreviewActor(SoakingCamera);
		if (soakingPreviewActor == null)
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(soakingPreviewActor);
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		UBGWDataAsset value;
		if (SoakingCamera == ESoakingCamera.Liquor)
		{
			if (!BGW_PreloadAssetMgr.Get(this).EquipPreviewConfigDataAsset.WineDBCDAMap.TryGetValue(EquipFXType, out value))
			{
				return;
			}
		}
		else if (!BGW_PreloadAssetMgr.Get(this).EquipPreviewConfigDataAsset.WinePartnerDBCDAMap.TryGetValue(EquipFXType, out value))
		{
			return;
		}
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = value as BUC_DispLibDispBaseConfigDataAsset;
		if (SoakingDispReqID > 0)
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(SoakingDispReqID);
		}
		if (bUC_DispLibDispBaseConfigDataAsset != null)
		{
			bUS_DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, out SoakingDispReqID, null, FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, GetUniqueID());
		}
	}

	public void SwitchEquipCamera(EquipPosition EquipPosition, bool IsForce = false)
	{
		FName value = B1GlobalFNames.CPS_Main;
		if (EquipPosition != EquipPosition.EnumMax)
		{
			EquipCameraConfigDic.TryGetValue(EquipPosition, out value);
		}
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			_ = value == B1GlobalFNames.CPS_Main;
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(value);
			}
			else
			{
				BlendStateActor.ToState(value);
			}
		}
	}

	public void ChangePlayerEquip(EquipPosition EquipPosition, int EquipID, bool IsChange)
	{
		if (EquipID < 0 || EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(EquipPreviewPlayer);
		if (!(bUS_GSEventCollection == null))
		{
			CheckNeedGC();
			bUS_GSEventCollection.Evt_ChangePreviewEquip.Invoke(EquipPosition, EquipID);
			if (IsChange)
			{
				PlayEquipFX(EquipPosition, EEquipFXType.Wear);
				PlayMontage(EquipPosition, 2);
			}
		}
	}

	public void PlayEquipFX(EquipPosition EquipPosition, EEquipFXType EquipFXType)
	{
		if (EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = ((EquipPosition != EquipPosition.Accessory) ? BUS_DispLibEventCollection.Get(EquipPreviewPlayer) : BUS_DispLibEventCollection.Get(AccessoryPreview));
		if (bUS_DispLibEventCollection != null && BGW_PreloadAssetMgr.Get(this).EquipPreviewConfigDataAsset.PositionConfigMap.TryGetValue(EquipPosition, out var value) && !value.Equals(null) && value.DBCDAMap.TryGetValue(EquipFXType, out var value2))
		{
			BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = value2 as BUC_DispLibDispBaseConfigDataAsset;
			if (GamePlayDispReqID > 0)
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(GamePlayDispReqID);
			}
			if (bUC_DispLibDispBaseConfigDataAsset != null)
			{
				bUS_DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, out GamePlayDispReqID, null, FVector.ZeroVector, DBCTransformParam.Default, DBCSetCallbackParams.Default, GetUniqueID());
			}
		}
	}

	public void PlayMontage(EquipPosition EquipPosition, int StateID)
	{
		if (!IsInLevel || EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		BGW_PreloadAssetMgr.Get(this).EquipPreviewConfigDataAsset.PositionConfigMap.TryGetValue(EquipPosition, out var value);
		if (value.Equals(null))
		{
			return;
		}
		UAnimMontage uAnimMontage = null;
		UAnimMontage uAnimMontage2 = null;
		switch (StateID)
		{
		case 1:
			uAnimMontage = value.AnimIn;
			uAnimMontage2 = value.HeadAnimIn;
			break;
		case 2:
			uAnimMontage = value.AnimOutSuccess;
			uAnimMontage2 = value.HeadAnimOutSuccess;
			break;
		case 3:
			uAnimMontage = value.AnimOutBack;
			uAnimMontage2 = value.HeadAnimOutBack;
			break;
		}
		if (uAnimMontage != null)
		{
			EquipPreviewPlayer.GetComponentByClass<USkeletalMeshComponent>().GetAnimInstance().Montage_Play(uAnimMontage);
		}
		foreach (UActorComponent item in EquipPreviewPlayer.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), new FName(GameDBRuntime.GetEquipPositionDescByEquipPosition(EquipPosition.Head).SkeletalMeshComponentTag)))
		{
			UAnimInstance postProcessInstance = (item as USkeletalMeshComponent).GetPostProcessInstance();
			if (uAnimMontage2 != null)
			{
				postProcessInstance?.Montage_Play(uAnimMontage2);
			}
			else
			{
				postProcessInstance?.Montage_Stop(0.5f, postProcessInstance.GetCurrentActiveMontage());
			}
		}
	}

	public void GetEquipPreviewPlayerCurrentActiveMontage()
	{
		USkeletalMeshComponent componentByClass = EquipPreviewPlayer.GetComponentByClass<USkeletalMeshComponent>();
		if (componentByClass == null)
		{
			BGW_LogUtil.LogError("[GetEquipPreviewPlayerCurrentActiveMontage]Comp is null");
			return;
		}
		UAnimInstance animInstance = componentByClass.GetAnimInstance();
		if (animInstance == null)
		{
			BGW_LogUtil.LogError("[GetEquipPreviewPlayerCurrentActiveMontage]Inst is null");
			return;
		}
		UAnimMontage currentActiveMontage = animInstance.GetCurrentActiveMontage();
		if (currentActiveMontage == null)
		{
			BGW_LogUtil.LogError("[GetEquipPreviewPlayerCurrentActiveMontage]Montage is null");
			return;
		}
		string name = currentActiveMontage.GetName();
		BGW_LogUtil.LogError("[BGW_CharacterViewMgr:EquipPreviewPlayer]CurrentActiveMontage = " + name);
	}

	public void EquipPreviewResetMontage()
	{
		if (EquipPreviewPlayer.IsNullOrDestroyed())
		{
			return;
		}
		UAnimInstance animInstance = EquipPreviewPlayer.GetComponentByClass<USkeletalMeshComponent>().GetAnimInstance();
		if (animInstance != null)
		{
			animInstance?.Montage_Stop(0f, animInstance.GetCurrentActiveMontage());
		}
		foreach (UActorComponent item in EquipPreviewPlayer.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), new FName(GameDBRuntime.GetEquipPositionDescByEquipPosition(EquipPosition.Head).SkeletalMeshComponentTag)))
		{
			UAnimInstance postProcessInstance = (item as USkeletalMeshComponent).GetPostProcessInstance();
			if (postProcessInstance != null)
			{
				postProcessInstance?.Montage_Stop(0f, postProcessInstance.GetCurrentActiveMontage());
			}
		}
	}

	public void ChangeFabaoPreview(int FabaoID)
	{
		ResetFabaoPreview();
		if (FabaoID == 0)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetItemPreviewPath(FabaoID), EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			FabaoPreview = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (FabaoPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeFabaoPreview]ChangeFabaoPreview = null,FabaoID = {FabaoID}");
			}
			else if (!FabaoPreviewCon.IsNullOrDestroyed())
			{
				FabaoPreview.AttachToActor(FabaoPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public void ResetFabaoPreview()
	{
		if (!FabaoPreview.IsNullOrDestroyed())
		{
			FabaoPreview.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(FabaoPreview);
		}
		FabaoPreview = null;
		CheckNeedGC();
	}

	public AActor GetFabaoPreviewActor()
	{
		return FabaoPreview;
	}

	public void ChangeAccessoryPreview(int AccessoryID)
	{
		ResetAccessoryoPreview();
		if (AccessoryID == 0)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetItemPreviewPath(AccessoryID), EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			AccessoryPreview = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (AccessoryPreview == null)
			{
				BGW_LogUtil.LogError($"[ChangeAccessoryPreview]ChangeAccessoryPreview = null,AccessoryID = {AccessoryID}");
			}
			else if (!AccessoryPreview.IsNullOrDestroyed())
			{
				AccessoryPreview.AttachToActor(FabaoPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public AActor GetAccessoryPreviewActor()
	{
		return AccessoryPreview;
	}

	public void ResetAccessoryoPreview()
	{
		if (!AccessoryPreview.IsNullOrDestroyed())
		{
			AccessoryPreview.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(AccessoryPreview);
		}
		AccessoryPreview = null;
		CheckNeedGC();
	}

	public void PlayMedicineFX()
	{
		if (!MedicineFX.IsNullOrDestroyed())
		{
			MedicineFX.NiagaraComponent.SetActive(bNewActive: true, bReset: true);
			MedicineFX.NiagaraComponent.ReinitializeSystem();
		}
	}

	public void SwitchTargetCamera(FName TargetCamera, bool IsForce = false)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(TargetCamera);
			}
			else
			{
				BlendStateActor.ToState(TargetCamera);
			}
		}
	}

	public void SwitchBlackCamera(bool IsForce = false)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			if (IsForce)
			{
				BlendStateActor.ForceSetStateImmediately(B1GlobalFNames.CPS_BlackView);
			}
			else
			{
				BlendStateActor.ToState(B1GlobalFNames.CPS_BlackView);
			}
		}
	}

	public void SaveCamera()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null)
		{
			TempTarget = firstLocalPlayerController.GetViewTarget();
		}
	}

	public void LoadCamera()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null && TempTarget != null)
		{
			firstLocalPlayerController.SetViewTargetWithBlend(TempTarget);
		}
	}

	public void SwitchPreviewActor(int UnitId)
	{
		if (CurTransActorIdx == UnitId)
		{
			if (!CurTransPreviewActor.IsNullOrDestroyed())
			{
				CurTransPreviewActor.SetActorHiddenInGame(bNewHidden: false);
			}
			TransPreviewBirthMontage();
			return;
		}
		CurTransActorIdx = UnitId;
		if (!CurTransPreviewActor.IsNullOrDestroyed())
		{
			CurTransPreviewActor.SetActorHiddenInGame(bNewHidden: true);
		}
		if (TransPreviewActorDic.TryGetValue(CurTransActorIdx, out CurTransPreviewActor))
		{
			CurTransPreviewActor.SetActorHiddenInGame(bNewHidden: false);
			TransPreviewBirthMontage();
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetUnitPreviewPath(UnitId), EUIResourceLoadType.NoCache);
		if (worldFromObj == null || uClass == null)
		{
			return;
		}
		CurTransPreviewActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
		if (CurTransPreviewActor == null)
		{
			BGW_LogUtil.LogError($"[SwitchPreviewActor]CurTransActor = null,Unit Id = {UnitId}");
			return;
		}
		TransPreviewActorDic.Add(CurTransActorIdx, CurTransPreviewActor);
		if (TransPreviewActorConDic.TryGetValue(CurTransActorIdx, out var value))
		{
			CurTransPreviewActor.AttachToActor(value, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			TransPreviewBirthMontage();
		}
	}

	private void TransPreviewBirthMontage()
	{
		if (!CurTransPreviewActor.IsNullOrDestroyed() && BGW_PreloadAssetMgr.Get(this).TransPreviewConfigDataAsset.AnimInConfigMap.TryGetValue(CurTransActorIdx, out var value) && value != null)
		{
			CurTransPreviewActor.GetComponentByClass<USkeletalMeshComponent>().GetAnimInstance().Montage_Play(value);
		}
	}

	public void SetEquipPreviewActorHidden(bool IsHidden)
	{
		if (!EquipPreviewPlayer.IsNullOrDestroyed())
		{
			EquipPreviewPlayer.SetActorHiddenInGame(IsHidden);
		}
	}

	public void SetCurTransPreviewActorHidden()
	{
		if (!CurTransPreviewActor.IsNullOrDestroyed())
		{
			CurTransPreviewActor.SetActorHiddenInGame(bNewHidden: true);
		}
	}

	private void OverrideExposureCompensation()
	{
	}

	public void SwitchSoulPreviewCamera(bool IsForce = false)
	{
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(CurSoulActorID);
		if (soulSkillDesc == null)
		{
			BGW_LogUtil.LogError($"[BGW_CharacterViewMgr:SwitchSoulPreviewCamera]SoulSkillDesc is null, SoulSkillId = {CurSoulActorID}");
		}
		else
		{
			SwitchTargetCamera(new FName(soulSkillDesc.CameraPreview), IsForce);
		}
	}

	public void SetCurSoulActorID(int ItemID, int ReuseModle)
	{
		if (ItemID != 0 && ItemID != -1)
		{
			CurSoulActorID = ReuseModle;
			UpdateDefaultSoulFXColor(ItemID);
		}
	}

	public void ChangeSoulPreview(int ItemID)
	{
		if (ItemID == 0 || ItemID == -1)
		{
			return;
		}
		ResetSoulPreview();
		CurSoulActorID = ItemID;
		BGW_PreloadAssetMgr.Get(WorldContext).RequestAsyncLoadForUIResource<UClass>(GSUIResPathUtil.GetUnitPreviewPath(ItemID), EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (CurSoulActorID == ReqID && !(Obj == null))
			{
				UClass uClass = Obj as UClass;
				UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
				if (!(worldFromObj == null) && !(uClass == null))
				{
					ResetSoulPreview(ResetID: false);
					CurSoulPreviewActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass) as b1.BGUTransPreviewActorBase;
					if (CurSoulPreviewActor == null)
					{
						BGW_LogUtil.LogError($"[SwitchPreviewActor]CurSoulActor = null,Unit Id = {ItemID}");
					}
					else if (SoulPreviewCon == null)
					{
						BGW_LogUtil.LogError($"[SwitchPreviewActor]SoulPreviewCon = null,Unit Id = {ItemID}");
					}
					else
					{
						CurSoulPreviewActor.AttachToActor(SoulPreviewCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
					}
				}
			}
		}, ItemID);
	}

	private void UpdateDefaultSoulFXColor(int ItemID)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
		if (itemDesc == null)
		{
			BGW_LogUtil.LogError($"[BGW_CharacterViewMgr:UpdateDefaultSoulFXColor] ItemDesc is null, ItemID = {ItemID}");
			return;
		}
		int num = 0;
		if (itemDesc.Quality == ItemQuality.Red)
		{
			num = 2;
		}
		else if (itemDesc.Quality == ItemQuality.Purple)
		{
			num = 1;
		}
		if (LastSoulFXIndex != (float)num)
		{
			LastSoulFXIndex = num;
			DefaultSoulPreviewFX.SetVariableFloat(B1GlobalFNames.User_FireColor_Index, num);
			DefaultSoulPreviewFX.SetActive(bNewActive: true, bReset: true);
			DefaultSoulPreviewFX.ReinitializeSystem();
			UpgradeSoulPreviewFX.SetVariableFloat(B1GlobalFNames.User_FireColor_Index, num);
		}
	}

	public void ActiveDefaultSoulPreview(bool IsActive)
	{
		if (!DefaultSoulPreviewActor.IsNullOrDestroyed() && !DefaultSoulPreviewFX.IsNullOrDestroyed())
		{
			FXOpacityFrom = 1f;
			FXOpacityStart = false;
			if (!IsActive)
			{
				ResetSoulPreview();
			}
			DefaultSoulPreviewFX.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, !IsActive);
			DefaultSoulPreviewFX.SetActive(IsActive, IsActive);
			DefaultSoulPreviewActor.SetActorHiddenInGame(!IsActive);
		}
	}

	public void ResetSoulPreviewFX()
	{
		if (!DefaultSoulPreviewFX.IsNullOrDestroyed())
		{
			DefaultSoulPreviewFX.SetActive(bNewActive: true, bReset: true);
			DefaultSoulPreviewFX.ReinitializeSystem();
		}
	}

	public void PlayUpgradeSoulFX(int ItemID)
	{
		UpdateDefaultSoulFXColor(ItemID);
		if (!UpgradeSoulPreviewFX.IsNullOrDestroyed())
		{
			UpgradeSoulPreviewFX.SetActive(bNewActive: true, bReset: true);
			UpgradeSoulPreviewFX.ReinitializeSystem();
		}
	}

	public AActor GetSoulPreviewActor()
	{
		return CurSoulPreviewActor;
	}

	public void SoulEnterObsModeChange(bool IsEnter)
	{
		if (!CurSoulPreviewActor.IsNullOrDestroyed())
		{
			CurSoulPreviewActor.UpdateLight(!IsEnter);
		}
		DefaultSoulPreviewFX.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, IsEnter);
		DefaultSoulPreviewFX.SetActive(!IsEnter, !IsEnter);
	}

	public void SetSoulPreviewActorHidden()
	{
		if (!DefaultSoulPreviewActor.IsNullOrDestroyed())
		{
			DefaultSoulPreviewActor.SetActorHiddenInGame(bNewHidden: true);
		}
		ResetSoulPreview();
	}

	public void ResetSoulPreview(bool ResetID = true)
	{
		if (!CurSoulPreviewActor.IsNullOrDestroyed())
		{
			CurSoulPreviewActor.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(CurSoulPreviewActor);
		}
		CurSoulPreviewActor = null;
		if (ResetID)
		{
			CurSoulActorID = 0;
		}
		CheckNeedGC();
	}

	private void TickSoulFXOpacityUPdate(float DeltaTime)
	{
		if (FXOpacityStart)
		{
			FXOpacityTimeCheck += DeltaTime;
			float x = FXOpacityTimeCheck / FXOpacityTime;
			x = MathLib.Clamp(x, 0f, 1f);
			FXOpacity = GSEaseFuncInUE.GSMathEase(FXOpacityFrom, FXOpacityTo, x, EEasingFunc.EaseOut);
			DefaultSoulPreviewFX.SetVariableFloat(B1GlobalFNames.User_Opacity, FXOpacity);
			if (FXOpacityTimeCheck >= FXOpacityTime)
			{
				FXOpacityStart = false;
				FXOpacityTimeCheck = 0f;
			}
		}
	}

	private void ResetBossIterationsScroll()
	{
		if (!BossIterationsScroll.IsNullOrDestroyed())
		{
			BossIterationsScroll.SetActorHiddenInGame(bNewHidden: true);
			BGU_UnrealWorldUtil.DestroyActor(BossIterationsScroll);
		}
		BossIterationsScroll = null;
		CheckNeedGC();
	}

	public void UpdateBossIterationsScroll(int GroupId)
	{
		if (GroupId <= 0)
		{
			return;
		}
		ResetBossIterationsScroll();
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>(GSUIResPathUtil.GetBossIterationsScrollPath(GroupId), EUIResourceLoadType.NoCache);
		if (!(worldFromObj == null) && !(uClass == null))
		{
			BossIterationsScroll = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(worldFromObj, uClass);
			if (BossIterationsScroll == null)
			{
				BGW_LogUtil.LogError($"[UpdateBossIterationsScroll]BossIterationsScroll = null,GroupId = {GroupId}");
			}
			else if (!BossIterationsScrollCon.IsNullOrDestroyed())
			{
				BossIterationsScroll.AttachToActor(BossIterationsScrollCon, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			}
		}
	}

	public void SwitchObserveMode(bool IsObserveMode)
	{
		if (!BlendStateActor.IsNullOrDestroyed())
		{
			FName endStateName = BlendStateActor.GetEndStateName();
			endStateName = ((!IsObserveMode) ? new FName(endStateName.ToString().Replace("_Ob", "")) : new FName(endStateName.ToString() + "_Ob"));
			BlendStateActor.ToState(endStateName);
		}
	}

	public AActor GetEquipPreviewActor()
	{
		return EquipPreviewPlayer;
	}

	private void CheckNeedGC()
	{
		BGW_MemoryMgr.Get(this).CheckNeedGC();
	}

	static BGW_CharacterViewMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_CharacterViewMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_CharacterViewMgr));
		CharacterViewLevelPath = new FName("/Game/00Main/Maps/CharacterView/CharacterViewInstance_08");
		CharacterViewLevelName = new FName("CharacterViewInstance_08");
		PlayerLocationBefore = default(FVector);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_CharacterViewMgr:OnAKBStateEndFunc")]
	private static void OnAKBStateEndFunc__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_CharacterViewMgr bGW_CharacterViewMgr = GCHelper.Find<BGW_CharacterViewMgr>(obj);
		FName beginStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_BeginStateName_Offset));
		FName endStateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_EndStateName_Offset));
		bool isForceImSet = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnAKBStateEndFunc_IsForceImSet_Offset), 0, OnAKBStateEndFunc_IsForceImSet_PropertyAddress.Address);
		bGW_CharacterViewMgr.OnAKBStateEndFunc(beginStateName, endStateName, isForceImSet);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_CharacterViewMgr");
		OnAKBStateEndFunc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAKBStateEndFunc");
		OnAKBStateEndFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAKBStateEndFunc_FunctionAddress);
		OnAKBStateEndFunc_BeginStateName_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "BeginStateName");
		OnAKBStateEndFunc_BeginStateName_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "BeginStateName", Classes.FNameProperty);
		OnAKBStateEndFunc_EndStateName_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "EndStateName");
		OnAKBStateEndFunc_EndStateName_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "EndStateName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OnAKBStateEndFunc_IsForceImSet_PropertyAddress, OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_Offset = NativeReflection.GetPropertyOffset(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet");
		OnAKBStateEndFunc_IsForceImSet_IsValid = NativeReflection.ValidatePropertyClass(OnAKBStateEndFunc_FunctionAddress, "IsForceImSet", Classes.FBoolProperty);
		OnAKBStateEndFunc_IsValid = OnAKBStateEndFunc_FunctionAddress != IntPtr.Zero && OnAKBStateEndFunc_BeginStateName_IsValid && OnAKBStateEndFunc_EndStateName_IsValid && OnAKBStateEndFunc_IsForceImSet_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_CharacterViewMgr:OnAKBStateEndFunc", OnAKBStateEndFunc_IsValid);
	}
}
