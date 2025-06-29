using System;
using b1.ECS;
using b1.EventDelDefine;
using b1.UI.Comm;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.MediaAssets;
using UnrealEngine.Plugins.Paper2D;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_UIEventCollection")]
public class BGW_UIEventCollection : GameInstanceSystemBaseUObj
{
	public delegate void Del_UI_Void();

	public delegate void Del_UI_Void_Bool(bool B1);

	public delegate void Del_UI_Int(int P1);

	public delegate void Del_UI_Float(float P1);

	public delegate void Del_UI_Void_Chr(BGUCharacterCS Actor);

	public delegate void Del_UI_Void_IntFloat(int P1, float P2);

	public delegate void Del_UI_AsyncLoadTexCallBack(UTexture LoadeTex);

	public delegate void Del_UI_AsyncLoadSpriteCallBack(UPaperSprite Sprite);

	public delegate void Del_UI_AsyncLoadMatCallBack(UMaterialInstance Mat);

	public delegate void Del_UI_AsyncLoadMediaSourceCallBack(UFileMediaSource MediaSource);

	public delegate void Del_UI_AsyncLoadDACallBack(UDataAsset DataAsset);

	public delegate void Del_UI_Srt(Srt Srt);

	public delegate void Del_UI_SettingValue(int OldValue, int NewValue, UISettingConfigType SettingType);

	public delegate void Del_UI_ActiveCricketName(bool B1, int P1, string S1, float F1);

	public delegate void Del_UI_IntBoolAction(int I1, bool B1, Action A1);

	public delegate void Del_UI_Void_Int(int p1);

	public delegate void Del_SkillWheelDragged(AActor SkillOwner, FVector2D WheelSize, FVector2D Vec2D1, FVector2D Vec2D2);

	public delegate void Del_SkillTouch(AActor SkillOwner, int P1, int P2, FVector2D VTouchPos);

	public delegate void Del_UI_Void_ActorInt(AActor P1, int P2);

	public delegate void Del_UI_X2ToggleStealthPanel(bool bShow);

	public delegate void Del_UI_X2ToggleEnableSwitchHero(bool bEnable);

	public delegate void Del_UI_BossBornOrDead(AActor BossActor, bool IsBorn);

	public delegate void Del_UI_ReactiveBattleUI(bool Visable, bool IsChangeBossBlood);

	public delegate void Del_UI_AddTeamPlayer(AActor Player);

	public delegate void Del_UI_RemoveTeamPlayer(AActor Player);

	public delegate void Del_UI_ScreenDebugDraw(FVector2D Point, FLinearColor Color, float Size, string InName = "");

	public delegate void Del_UI_String(string InName = "");

	public delegate void Del_UI_ShowMapTips(bool IsUIWord, int Id);

	public delegate void Del_UI_ChangeUnitBlood(EBGUBloodBarType BloodBarType, BGUCharacterCS Unit);

	public delegate BUI_MBarBase Del_UI_GetBloodBarPoolWidget(BGUCharacterCS OwnerUnit, EBGUBloodBarType BloodBarType, bool IsSelfTeam, bool IsPlayer);

	public delegate BUI_MPlayerInfo Del_UI_GetPlayerInfoPoolWidget(BGUCharacterCS OwnerUnit);

	public delegate BUI_MInteractIcon Del_UI_GetInteractIconPoolWidget(AActor BindActor, EInteractType InteractType, bool IsNeedUpdatePos = true);

	public delegate void Del_UI_ShowHPChangeNum(DamageNumParam Param);

	public delegate void Del_UI_SetPageActive(EUIPageID PageId, bool IsActive);

	public delegate void Del_UI_SwitchPageActive(EUIPageID PageId);

	public delegate void Del_UI_SetEnabled(bool IsEnabled);

	public delegate void Del_UI_InitTopBarUI(Entity InEntity);

	public delegate void Del_UI_ClearBindTopBar(Entity InEntity);

	public delegate void Del_UI_ReleaseBloodBar(Entity InEntity);

	public delegate void Del_UI_ChangeBar(Entity InEntity, ShowBarType ShowType);

	public delegate void Del_UI_SetAlwaysShowSetting(Entity InEntity, AlwaysShowSetting State, bool Value);

	public delegate void Del_UI_SetAlwaysHideSetting(Entity InEntity, AlwaysHideSetting State, bool Value);

	public delegate void Del_UI_SetHPBarPercent(Entity InEntity, float Percent, bool IsChangeShow = false);

	public delegate void Del_UI_SetShieldBarActive(Entity InEntity, bool IsActive);

	public delegate void Del_UI_SetShieldBarPercent(Entity InEntity, float Percent, bool IsChangeShow = false);

	public delegate bool Del_UI_GetBloodIsShowing(Entity InEntity);

	public delegate void Del_UI_ShowDropMainSpacial(ItemOne ItemData);

	public delegate void Del_UI_ShowSaveArchiveUI();

	public delegate void Del_UI_HideSaveArchiveUI();

	public delegate void Del_UI_SetUIBlock(EBlockReason BlockReason, bool IsBlock);

	public delegate int Del_UI_DrawDebugData(DebugDataBase InData);

	public delegate void Del_UI_ResetDebugData(int ReqId, DebugDataBase InData);

	public delegate void Del_Bool_FKey(bool B1, FKey InKey);

	public delegate void Del_UI_IntInt(int P1, int P2);

	public delegate void Del_UI_IntBool(int P1, bool B1);

	public delegate void Del_UI_ActiveName(bool B1, int P1, float F1);

	public delegate void Del_Bool_FKey_Bool(bool B1, FKey InKey, bool IsCtrlUI);

	public delegate void Del_UI_StringFloat(string S1, float F1);

	public delegate void Del_UI_StrStrFloat(string S1, string S2, float F1, bool B1, bool B2);

	public delegate void Del_UI_ShowRebirthPointUI(int RebirthPointID);

	public delegate void Del_UI_ShowLoginNotice(Action InAction = null);

	public delegate void Del_RecvAntiAddictionActions(bool NeedHalt, string Title, string Content, int DisplayDurationSec);

	public delegate void Del_UI_CheckShowBarScaleAnim(EChangeReason Reason);

	public delegate void Del_UI_ActiveBlackOut(bool IsActive, Del_Void Callback = null, bool IsPauseWorld = true);

	public delegate void Del_UI_MultiKill(float P1, int P2, int P3, float P4);

	public delegate void Del_UI_TransStateChange(bool NewValue);

	public delegate void Del_UI_UIShowAnFinish(EUIPageType UIPageType);

	public Del_UI_Void_Chr Evt_UI_X2ReInitCtrlUI = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_X2ChangeUltimatePanel = delegate
	{
	};

	public Del_UI_X2ToggleStealthPanel Evt_UI_X2ToggleStealthPanel = delegate
	{
	};

	public Del_UI_X2ToggleEnableSwitchHero Evt_UI_X2ToggleEnableSwitchHero = delegate
	{
	};

	public Del_SkillTouch Evt_UI_SkillTouchPressed = delegate
	{
	};

	public Del_SkillTouch Evt_UI_SkillTouchRepeated = delegate
	{
	};

	public Del_SkillTouch Evt_UI_SkillTouchReleased = delegate
	{
	};

	public Del_SkillWheelDragged Evt_UI_SkillTouchDragged = delegate
	{
	};

	public Del_UI_Void Evt_SkillTouchForceCancelled = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_ResetSkillCooldown = delegate
	{
	};

	public Del_UI_Void_ActorInt Evt_UI_InputSkillManualSelect = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_X2ShowUI = delegate
	{
	};

	public Action<AActor, AActor, bool> Evt_SwitchHeroRefreshUI;

	public Action<bool> Evt_SwitchInputDevice;

	public Action<EKeys, bool> Evt_InputKey;

	public Action<int, ECanCastSkillResult> Evt_UnitCastSkillFail;

	public Del_UI_Void Evt_UI_X2Unparalleled = delegate
	{
	};

	public Del_UI_Void Evt_UI_X2UnparalleledEnd = delegate
	{
	};

	public Del_UI_Srt Evt_UI_PlaySrt = delegate
	{
	};

	public Del_UI_Srt Evt_UI_StopSrt = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowBenchMark = delegate
	{
	};

	public Del_UI_Void Evt_UI_X2InitUI = delegate
	{
	};

	public Del_UI_BossBornOrDead Evt_UI_BossBornOrDead = delegate
	{
	};

	public Del_UI_Void Evt_UI_ResetBGM = delegate
	{
	};

	public Del_UI_Void Evt_UI_ReleaseLastBullet = delegate
	{
	};

	public Del_UI_RemoveTeamPlayer Evt_UI_RemoveTeamPlayer = delegate
	{
	};

	public Del_UI_ScreenDebugDraw Evt_UI_ScreenDebugDraw = delegate
	{
	};

	public Del_UI_ScreenDebugDraw Evt_UI_ViewPortDebugDraw = delegate
	{
	};

	public Del_UI_String Evt_UI_RemoveDrawPointWithName = delegate
	{
	};

	public Del_UI_Void Evt_UI_ResetScreenDebugDraw = delegate
	{
	};

	public Del_UI_ShowMapTips Evt_UI_ShowMapTips = delegate
	{
	};

	public Del_UI_Void Evt_UI_ClearAllProjWidget = delegate
	{
	};

	public Del_UI_GetBloodBarPoolWidget Evt_UI_GetBloodBarPoolWidget = (BGUCharacterCS _003Cp0_003E, EBGUBloodBarType _003Cp1_003E, bool _003Cp2_003E, bool _003Cp3_003E) => (BUI_MBarBase)null;

	public Del_UI_GetPlayerInfoPoolWidget Evt_UI_GetPlayerInfoPoolWidget = (BGUCharacterCS _003Cp0_003E) => (BUI_MPlayerInfo)null;

	public Del_UI_GetInteractIconPoolWidget Evt_UI_GetInteractIconPoolWidget = (AActor _003Cp0_003E, EInteractType _003Cp1_003E, bool _003Cp2_003E) => (BUI_MInteractIcon)null;

	public Del_UI_ShowHPChangeNum Evt_UI_ShowHPChangeNum = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetBattleInfoEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetDamageNumCanEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetBloodBarCanEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetPlayerInfoCanEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetInteractIconCanEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetDamageNumEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetBloodBarEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetPlayerInfoEnabled = delegate
	{
	};

	public Del_UI_SetEnabled Evt_UI_SetInteractIconEnabled = delegate
	{
	};

	public Del_UI_ChangeUnitBlood Evt_UI_AddUnitBlood = delegate
	{
	};

	public Del_UI_ChangeUnitBlood Evt_UI_RemoveUnitBlood = delegate
	{
	};

	public Del_UI_SetPageActive Evt_UI_SetPageActive = delegate
	{
	};

	public Del_UI_SwitchPageActive Evt_UI_SwitchPageActive = delegate
	{
	};

	public Del_UI_SetPageActive Evt_UI_SetPageActiveTemp = delegate
	{
	};

	public Del_UI_Void Evt_UI_SwitchMiniGm = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_PauseShowBarScaleAnim = delegate
	{
	};

	public Del_UI_CheckShowBarScaleAnim Evt_UI_CheckShowBarScaleAnim = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_820LevelPass = delegate
	{
	};

	public Del_UI_Void Evt_UI_820TimeOut = delegate
	{
	};

	public Del_UI_Void Evt_UI_820TimeOutWarn = delegate
	{
	};

	public Del_UI_Void Evt_UI_820TimeWarn = delegate
	{
	};

	public Del_UI_Void Evt_UI_820HideInitTips = delegate
	{
	};

	public Del_UI_SetUIBlock Evt_UI_SetUIBlock = delegate
	{
	};

	public Del_UI_InitTopBarUI Evt_UI_InitTopBarUI = delegate
	{
	};

	public Del_UI_ClearBindTopBar Evt_UI_ClearBindTopBar = delegate
	{
	};

	public Del_UI_ReleaseBloodBar Evt_UI_ReleaseBloodBar = delegate
	{
	};

	public Del_UI_ChangeBar Evt_UI_ShowBar = delegate
	{
	};

	public Del_UI_ChangeBar Evt_UI_HideBar = delegate
	{
	};

	public Del_UI_SetAlwaysShowSetting Evt_UI_SetAlwaysShowSetting = delegate
	{
	};

	public Del_UI_SetAlwaysHideSetting Evt_UI_SetAlwaysHideSetting = delegate
	{
	};

	public Del_UI_SetHPBarPercent Evt_UI_SetHPBarPercent = delegate
	{
	};

	public Del_UI_SetShieldBarActive Evt_UI_SetShieldBarActive = delegate
	{
	};

	public Del_UI_SetShieldBarPercent Evt_UI_SetShieldBarPercent = delegate
	{
	};

	public Del_UI_GetBloodIsShowing Evt_UI_GetBloodIsShowing = (Entity _003Cp0_003E) => false;

	public Del_UI_ShowDropMainSpacial Evt_UI_ShowDropMainSpacial = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_SwitchInputDisplay = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowEndingCredits = delegate
	{
	};

	public Del_UI_Void Evt_UI_OpenEndingCreditsBackground = delegate
	{
	};

	public Del_UI_ShowSaveArchiveUI Evt_ShowSaveArchiveUI = delegate
	{
	};

	public Del_UI_HideSaveArchiveUI Evt_HideSaveArchiveUI = delegate
	{
	};

	public Del_UI_DrawDebugData Evt_UI_DrawDebugData = (DebugDataBase _003Cp0_003E) => -1;

	public Del_UI_ResetDebugData Evt_UI_ResetDebugData = delegate
	{
	};

	public Del_UI_Void Evt_UI_TryInitDrawDebugUI = delegate
	{
	};

	public Del_UI_Int Evt_UI_StopDrawDebugData = delegate
	{
	};

	public Del_UI_Void Evt_UI_UITrackerClearData = delegate
	{
	};

	public Del_UI_Void Evt_UI_UITrackerCheckReport = delegate
	{
	};

	public Del_UI_MultiKill Evt_UI_X2MultiKill = delegate
	{
	};

	public Del_UI_Void Evt_UI_ForceClearBindUnitList = delegate
	{
	};

	public Del_UI_Void_Chr Evt_UI_RegTopBarUI = delegate
	{
	};

	public Del_UI_Void_Chr Evt_UI_UnRegTopBarUI = delegate
	{
	};

	public Del_UI_Void Evt_UI_TransStateChange = delegate
	{
	};

	public Del_UI_SettingValue Evt_SettingValueChanged = delegate
	{
	};

	public Del_UI_Void Evt_CricketBattleStart = delegate
	{
	};

	public Del_UI_Void Evt_ShowCricketBattleUI = delegate
	{
	};

	public Del_UI_Void Evt_UpdateCricketBattleUI = delegate
	{
	};

	public Del_UI_Void Evt_CricketBattleEnd = delegate
	{
	};

	public Del_UI_Void Evt_UI_DPSTestReportAndReStart = delegate
	{
	};

	public Del_UI_ActiveCricketName Evt_UI_ActiveCricketName = delegate
	{
	};

	public Del_UI_Void Evt_UI_PlayStartSeq = delegate
	{
	};

	public Del_UI_Void Evt_UI_BlackActiveState = delegate
	{
	};

	public Del_UI_Void_Int Evt_UIShowAnFinishGSE = delegate
	{
	};

	public Del_UI_UIShowAnFinish Evt_UIShowAnFinishScript = delegate
	{
	};

	public Del_UI_Void_Bool Evt_ShowTransGuideUI = delegate
	{
	};

	public Del_UI_Void Evt_UpdateTransGuideUI = delegate
	{
	};

	public Del_UI_Void Evt_ShowShortItemTips = delegate
	{
	};

	public Del_UI_Void Evt_ShowItemAreaTips = delegate
	{
	};

	public Del_UI_Void Evt_BossRushItemTips = delegate
	{
	};

	public Del_UI_IntBool Evt_UI_EnterHintInteractiveArea = delegate
	{
	};

	public Del_UI_IntBool Evt_UI_EnterInteractiveArea = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_PressKeyInteract = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_ReleaseKeyInteract = delegate
	{
	};

	public Del_Bool_FKey_Bool Evt_AnyKeyInput = delegate
	{
	};

	public Del_UI_IntInt Evt_UI_CastSkillSuccess = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_TaskFlagTrigger = delegate
	{
	};

	public Del_UI_Void Evt_UI_ActiveAllUITrigger = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowGMUITrigger = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_CallGMMenu = delegate
	{
	};

	public Del_UI_ReactiveBattleUI Evt_UI_ReactiveBattleUI = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_ChangeBGM = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_PressKeyDispaly = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_ReleaseKeyDisplay = delegate
	{
	};

	public Del_UI_StrStrFloat Evt_UI_PlayStory = delegate
	{
	};

	public Del_UI_StrStrFloat Evt_UI_PlayStory_StartPage = delegate
	{
	};

	public Del_UI_Void Evt_UI_SkipStory = delegate
	{
	};

	public Del_UI_ShowRebirthPointUI Evt_UI_ShowRebirthPointUI = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_ActiveDeathUI = delegate
	{
	};

	public Del_UI_ActiveName Evt_UI_ActiveName = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_ShowChapterMovie = delegate
	{
	};

	public Del_UI_Void_Int Evt_UI_SeqMediaPlayer_Cache = delegate
	{
	};

	public Del_UI_Void Evt_UI_SeqMediaPlayer_Play = delegate
	{
	};

	public Del_UI_ActiveBlackOut Evt_UI_ActiveBlackOut = delegate
	{
	};

	public Del_UI_Void Evt_UI_ClearDamageNumUI = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_ActiveNoSeqUI = delegate
	{
	};

	public Del_UI_Void Evt_UI_CloudMoveInBattle = delegate
	{
	};

	public Del_UI_ShowLoginNotice Evt_UI_ShowLoginNotice = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowAreaId = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowDisconnectControllerTips = delegate
	{
	};

	public Del_UI_String Evt_UI_ShowTransitionPhaseTips = delegate
	{
	};

	public Del_UI_String Evt_UI_ShowGMTips = delegate
	{
	};

	public Del_UI_StringFloat Evt_UI_ShowTeamInfoMessage = delegate
	{
	};

	public Del_UI_Void Evt_UI_ResetToppingFocus = delegate
	{
	};

	public Del_UI_Int Evt_UI_DropUIConfirm = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowLoadingExceedTimeTips = delegate
	{
	};

	public Del_UI_IntBoolAction Evt_UI_PlayLoadingAdaptor = delegate
	{
	};

	public Del_UI_Void_Bool Evt_UI_OpenTagUIColorAlpha = delegate
	{
	};

	public Del_UI_Void Evt_UI_ShowShaderCompiling = delegate
	{
	};

	public Del_RecvAntiAddictionActions Evt_UI_ShowComfirm = delegate
	{
	};

	private static bool Evt_RootPanelAddUI_IsValid;

	private static int Evt_RootPanelAddUI_Offset;

	private UIEvt_VoidWidget Evt_RootPanelAddUI_DelegateCached;

	private static bool Evt_RootPanelAddUIWithLayer_IsValid;

	private static int Evt_RootPanelAddUIWithLayer_Offset;

	private UIEvt_VoidWidgetInt Evt_RootPanelAddUIWithLayer_DelegateCached;

	private static bool Evt_RootPanelRemoveUI_IsValid;

	private static int Evt_RootPanelRemoveUI_Offset;

	private UIEvt_VoidWidget Evt_RootPanelRemoveUI_DelegateCached;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelAddUI")]
	public UIEvt_VoidWidget Evt_RootPanelAddUI
	{
		get
		{
			CheckDestroyed();
			if (!Evt_RootPanelAddUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelAddUI");
				return null;
			}
			if (Evt_RootPanelAddUI_DelegateCached == null)
			{
				Evt_RootPanelAddUI_DelegateCached = new UIEvt_VoidWidget();
				Evt_RootPanelAddUI_DelegateCached.SetAddress(IntPtr.Add(base.Address, Evt_RootPanelAddUI_Offset));
			}
			return Evt_RootPanelAddUI_DelegateCached;
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelAddUIWithLayer")]
	public UIEvt_VoidWidgetInt Evt_RootPanelAddUIWithLayer
	{
		get
		{
			CheckDestroyed();
			if (!Evt_RootPanelAddUIWithLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelAddUIWithLayer");
				return null;
			}
			if (Evt_RootPanelAddUIWithLayer_DelegateCached == null)
			{
				Evt_RootPanelAddUIWithLayer_DelegateCached = new UIEvt_VoidWidgetInt();
				Evt_RootPanelAddUIWithLayer_DelegateCached.SetAddress(IntPtr.Add(base.Address, Evt_RootPanelAddUIWithLayer_Offset));
			}
			return Evt_RootPanelAddUIWithLayer_DelegateCached;
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelRemoveUI")]
	public UIEvt_VoidWidget Evt_RootPanelRemoveUI
	{
		get
		{
			CheckDestroyed();
			if (!Evt_RootPanelRemoveUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_UIEventCollection:Evt_RootPanelRemoveUI");
				return null;
			}
			if (Evt_RootPanelRemoveUI_DelegateCached == null)
			{
				Evt_RootPanelRemoveUI_DelegateCached = new UIEvt_VoidWidget();
				Evt_RootPanelRemoveUI_DelegateCached.SetAddress(IntPtr.Add(base.Address, Evt_RootPanelRemoveUI_Offset));
			}
			return Evt_RootPanelRemoveUI_DelegateCached;
		}
	}

	public static BGW_UIEventCollection Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_UIEventCollection>(WorldCtx);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_UIEventCollection");
		Evt_RootPanelAddUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Evt_RootPanelAddUI");
		Evt_RootPanelAddUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Evt_RootPanelAddUI", Classes.FDelegateProperty);
		Evt_RootPanelAddUIWithLayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Evt_RootPanelAddUIWithLayer");
		Evt_RootPanelAddUIWithLayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Evt_RootPanelAddUIWithLayer", Classes.FDelegateProperty);
		Evt_RootPanelRemoveUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Evt_RootPanelRemoveUI");
		Evt_RootPanelRemoveUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Evt_RootPanelRemoveUI", Classes.FDelegateProperty);
	}

	static BGW_UIEventCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_UIEventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_UIEventCollection));
	}
}
