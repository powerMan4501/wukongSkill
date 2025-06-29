using System;
using System.Collections.Generic;
using System.Text;
using b1.BGW;
using b1.ECS;
using b1.GSMUI.GSWidget;
using b1.UI;
using b1.UI.Comm;
using b1.UI.GSPage;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BattleInfoCS")]
public class BUI_BattleInfoCS : BUI_Widget
{
	private enum BloodBarTypeEnum
	{
		NONE = 10,
		ENEMY
	}

	private Dictionary<DamageTypeEnum, BUI_MSimNum> CachedDmgNumRefWidgets = new Dictionary<DamageTypeEnum, BUI_MSimNum>();

	private Dictionary<BloodBarTypeEnum, BUI_MBarBase> CachedBloodBarRefWidgets = new Dictionary<BloodBarTypeEnum, BUI_MBarBase>();

	private Dictionary<AActor, DSBarInfoBind> BloodBarActorBindDict = new Dictionary<AActor, DSBarInfoBind>();

	private BUI_MPlayerInfo PlayerInfoRefWidget;

	private BUI_MInteractIcon InteractIconRefWidget;

	private Dictionary<int, Queue<IPoolWidget>> BattleWidgetPoolDic = new Dictionary<int, Queue<IPoolWidget>>();

	private Dictionary<BUI_ProjWidget, ProjWidgetInfo> ProjWidgetDic = new Dictionary<BUI_ProjWidget, ProjWidgetInfo>();

	private UWidget RootCanvas;

	private UCanvasPanel PlayerInfoCon;

	private UCanvasPanel InteractIconCon;

	private UCanvasPanel NumCon;

	private UCanvasPanel BarCon;

	private UGSRoundRectQuick PlayerInfoRoundRect;

	private UGSRoundRectQuick BarRoundRect;

	private UGSRoundRectQuick BarHideRoundRect;

	private readonly int InteractIconPoolSize = 20;

	private readonly int DmgNumPoolSize = 30;

	private int BloodBarPoolSize_Enemy = 15;

	private readonly string InteractIconPoolPrefix = "InteractIcon";

	private readonly string DmgNumPoolPrefix = "DmgNum";

	private readonly string BloodBarPoolPrefix = "BloodBar";

	private const int PlayerInfoPoolKey = 99;

	private const int InteractIconPoolKey = 98;

	private int TickStatID = -1;

	private readonly GSBindProp<bool> IsBattleInfoEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsDamageNumCanEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsBloodBarCanEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsPlayerInfoCanEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsInteractIconCanEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsDamageNumEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsBloodBarEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsPlayerInfoEnabled = new GSBindProp<bool>();

	private readonly GSBindProp<bool> IsInteractIconEnabled = new GSBindProp<bool>();

	private Dictionary<Entity, BUI_ProjWidget> EntityDic = new Dictionary<Entity, BUI_ProjWidget>();

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		RootCanvas = FindChildWidget("RootCanvas");
		NumCon = FindChildWidget("NumCon") as UCanvasPanel;
		BarCon = FindChildWidget("BarCon") as UCanvasPanel;
		PlayerInfoCon = FindChildWidget("PlayerInfoCon") as UCanvasPanel;
		PlayerInfoRoundRect = FindChildWidget("PlayerInfoRoundRect") as UGSRoundRectQuick;
		InteractIconCon = FindChildWidget("InteractIconCon") as UCanvasPanel;
		BarRoundRect = FindChildWidget("BarRoundRect") as UGSRoundRectQuick;
		BarHideRoundRect = FindChildWidget("BarHideRoundRect") as UGSRoundRectQuick;
		ReferencingDmgWidgets();
		ReferencingBloodBarWidgets();
		ReferencingPlayerInfoWidgets();
		ReferencingInteractIconWidgets();
		CreateDmgNumPools();
		CreateBloodBarPools();
		CreatePlayerInfoPools();
		CreateInteractIconPools();
		BUI_ProjWidget bUI_ProjWidget = FindChildWidget("BI_LockEnemy") as BUI_ProjWidget;
		CacheProjWidgetScrPosUpdating(bUI_ProjWidget, new ProjWidgetInfo(bUI_ProjWidget), NeedRemove: false);
		GSBindProp<bool> isBattleInfoEnabled = IsBattleInfoEnabled;
		isBattleInfoEnabled.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isBattleInfoEnabled.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeBattleInfoEnabled));
		GSBindProp<bool> isDamageNumEnabled = IsDamageNumEnabled;
		isDamageNumEnabled.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isDamageNumEnabled.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeDamageNumEnabled));
		GSBindProp<bool> isBloodBarEnabled = IsBloodBarEnabled;
		isBloodBarEnabled.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isBloodBarEnabled.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeBloodBarEnabled));
		GSBindProp<bool> isPlayerInfoEnabled = IsPlayerInfoEnabled;
		isPlayerInfoEnabled.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isPlayerInfoEnabled.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangePlayerInfoEnabled));
		GSBindProp<bool> isInteractIconEnabled = IsInteractIconEnabled;
		isInteractIconEnabled.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isInteractIconEnabled.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeInteractIconEnabled));
		IsBattleInfoEnabled.SetValue(EChangeReason.Init, value: true);
		IsDamageNumCanEnabled.SetValue(EChangeReason.Init, value: true);
		IsBloodBarCanEnabled.SetValue(EChangeReason.Init, value: true);
		IsPlayerInfoCanEnabled.SetValue(EChangeReason.Init, value: true);
		IsInteractIconCanEnabled.SetValue(EChangeReason.Init, value: true);
		IsDamageNumEnabled.SetValue(EChangeReason.Init, value: true);
		IsBloodBarEnabled.SetValue(EChangeReason.Init, value: true);
		IsPlayerInfoEnabled.SetValue(EChangeReason.Init, value: true);
		IsInteractIconEnabled.SetValue(EChangeReason.Init, value: true);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_SetBattleInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetBattleInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBattleInfoEnabled));
			bGW_UIEventCollection.Evt_UI_SetDamageNumCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetDamageNumCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetDamageNumCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetBloodBarCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetBloodBarCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBloodBarCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetPlayerInfoCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetPlayerInfoCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetInteractIconCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetInteractIconCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetInteractIconCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetDamageNumEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetDamageNumEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetDamageNumEnabled));
			bGW_UIEventCollection.Evt_UI_SetBloodBarEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetBloodBarEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBloodBarEnabled));
			bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoEnabled));
			bGW_UIEventCollection.Evt_UI_SetInteractIconEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetInteractIconEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetInteractIconEnabled));
			bGW_UIEventCollection.Evt_UI_GetBloodBarPoolWidget = (BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget)Delegate.Combine(bGW_UIEventCollection.Evt_UI_GetBloodBarPoolWidget, new BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget(GetBloodBarPoolWidget));
			bGW_UIEventCollection.Evt_UI_GetPlayerInfoPoolWidget = (BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget)Delegate.Combine(bGW_UIEventCollection.Evt_UI_GetPlayerInfoPoolWidget, new BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget(GetPlayerInfoPoolWidget));
			bGW_UIEventCollection.Evt_UI_GetInteractIconPoolWidget = (BGW_UIEventCollection.Del_UI_GetInteractIconPoolWidget)Delegate.Combine(bGW_UIEventCollection.Evt_UI_GetInteractIconPoolWidget, new BGW_UIEventCollection.Del_UI_GetInteractIconPoolWidget(GetInteractIconPoolWidget));
			bGW_UIEventCollection.Evt_UI_ShowHPChangeNum = (BGW_UIEventCollection.Del_UI_ShowHPChangeNum)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ShowHPChangeNum, new BGW_UIEventCollection.Del_UI_ShowHPChangeNum(ShowHPChangeNum));
			bGW_UIEventCollection.Evt_UI_ClearAllProjWidget = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ClearAllProjWidget, new BGW_UIEventCollection.Del_UI_Void(ReuseBattleUI));
			bGW_UIEventCollection.Evt_UI_ClearDamageNumUI = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ClearDamageNumUI, new BGW_UIEventCollection.Del_UI_Void(ClearDamageNumUI));
			bGW_UIEventCollection.Evt_UI_ClearBindTopBar = (BGW_UIEventCollection.Del_UI_ClearBindTopBar)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ClearBindTopBar, new BGW_UIEventCollection.Del_UI_ClearBindTopBar(OnClearBindTopBar));
			bGW_UIEventCollection.Evt_UI_ShowBar = (BGW_UIEventCollection.Del_UI_ChangeBar)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ShowBar, new BGW_UIEventCollection.Del_UI_ChangeBar(OnShowBar));
			bGW_UIEventCollection.Evt_UI_HideBar = (BGW_UIEventCollection.Del_UI_ChangeBar)Delegate.Combine(bGW_UIEventCollection.Evt_UI_HideBar, new BGW_UIEventCollection.Del_UI_ChangeBar(OnHideBar));
			bGW_UIEventCollection.Evt_UI_SetAlwaysShowSetting = (BGW_UIEventCollection.Del_UI_SetAlwaysShowSetting)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetAlwaysShowSetting, new BGW_UIEventCollection.Del_UI_SetAlwaysShowSetting(SetAlwaysShowSetting));
			bGW_UIEventCollection.Evt_UI_SetAlwaysHideSetting = (BGW_UIEventCollection.Del_UI_SetAlwaysHideSetting)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetAlwaysHideSetting, new BGW_UIEventCollection.Del_UI_SetAlwaysHideSetting(SetAlwaysHideSetting));
			bGW_UIEventCollection.Evt_UI_SetHPBarPercent = (BGW_UIEventCollection.Del_UI_SetHPBarPercent)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetHPBarPercent, new BGW_UIEventCollection.Del_UI_SetHPBarPercent(SetHPBarPercent));
			bGW_UIEventCollection.Evt_UI_SetShieldBarActive = (BGW_UIEventCollection.Del_UI_SetShieldBarActive)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetShieldBarActive, new BGW_UIEventCollection.Del_UI_SetShieldBarActive(SetShieldBarActive));
			bGW_UIEventCollection.Evt_UI_SetShieldBarPercent = (BGW_UIEventCollection.Del_UI_SetShieldBarPercent)Delegate.Combine(bGW_UIEventCollection.Evt_UI_SetShieldBarPercent, new BGW_UIEventCollection.Del_UI_SetShieldBarPercent(SetShieldBarPercent));
			bGW_UIEventCollection.Evt_UI_GetBloodIsShowing = (BGW_UIEventCollection.Del_UI_GetBloodIsShowing)Delegate.Combine(bGW_UIEventCollection.Evt_UI_GetBloodIsShowing, new BGW_UIEventCollection.Del_UI_GetBloodIsShowing(GetBloodIsShowing));
			bGW_UIEventCollection.Evt_UI_InitTopBarUI = (BGW_UIEventCollection.Del_UI_InitTopBarUI)Delegate.Combine(bGW_UIEventCollection.Evt_UI_InitTopBarUI, new BGW_UIEventCollection.Del_UI_InitTopBarUI(InitTopBarUI));
			bGW_UIEventCollection.Evt_UI_RegTopBarUI = (BGW_UIEventCollection.Del_UI_Void_Chr)Delegate.Combine(bGW_UIEventCollection.Evt_UI_RegTopBarUI, new BGW_UIEventCollection.Del_UI_Void_Chr(RegTopBarUI));
			bGW_UIEventCollection.Evt_UI_UnRegTopBarUI = (BGW_UIEventCollection.Del_UI_Void_Chr)Delegate.Combine(bGW_UIEventCollection.Evt_UI_UnRegTopBarUI, new BGW_UIEventCollection.Del_UI_Void_Chr(UnRegTopBarUI));
		}
		InitSettingConfig();
		TickStatID = ProfilerFuncLib.CreateStatIDInGSCustomGroup("GS_CS_GSProjectWidgetList");
	}

	private void InitSettingConfig()
	{
		BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(this);
		if (bGW_SettingMgrV != null)
		{
			SetDamageNumCanEnabled(bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.DmgNumShow));
			SetBloodBarEnabled(bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.EnemyTopBar));
			SetInteractIconEnabled(bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.InteractionTips));
		}
	}

	private void OnChangeBattleInfoEnabled(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		RootCanvas.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		if (NewValue)
		{
			SetGSTickTypeFromPageUI(EGSTickType.AutoGSTick);
		}
		else
		{
			SetGSTickTypeFromPageUI(EGSTickType.NeverGSTick);
		}
	}

	private void OnChangeDamageNumEnabled(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		NumCon?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeBloodBarEnabled(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (!(BGW_SettingFuncUtil.GetSettingIntValueByType(this, UISettingConfigType.EnemyTopBar) == 0 && NewValue))
		{
			BarCon?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		}
	}

	private void OnChangePlayerInfoEnabled(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		PlayerInfoCon?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeInteractIconEnabled(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (!(BGW_SettingFuncUtil.GetSettingIntValueByType(this, UISettingConfigType.InteractionTips) == 0 && NewValue))
		{
			InteractIconCon?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_SetBattleInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetBattleInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBattleInfoEnabled));
			bGW_UIEventCollection.Evt_UI_SetDamageNumCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetDamageNumCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetDamageNumCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetBloodBarCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetBloodBarCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBloodBarCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetPlayerInfoCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetPlayerInfoCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetInteractIconCanEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetInteractIconCanEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetInteractIconCanEnabled));
			bGW_UIEventCollection.Evt_UI_SetDamageNumEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetDamageNumEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetDamageNumEnabled));
			bGW_UIEventCollection.Evt_UI_SetBloodBarEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetBloodBarEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetBloodBarEnabled));
			bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetPlayerInfoEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetPlayerInfoEnabled));
			bGW_UIEventCollection.Evt_UI_SetInteractIconEnabled = (BGW_UIEventCollection.Del_UI_SetEnabled)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetInteractIconEnabled, new BGW_UIEventCollection.Del_UI_SetEnabled(SetInteractIconEnabled));
			bGW_UIEventCollection.Evt_UI_GetBloodBarPoolWidget = (BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget)Delegate.Remove(bGW_UIEventCollection.Evt_UI_GetBloodBarPoolWidget, new BGW_UIEventCollection.Del_UI_GetBloodBarPoolWidget(GetBloodBarPoolWidget));
			bGW_UIEventCollection.Evt_UI_GetPlayerInfoPoolWidget = (BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget)Delegate.Remove(bGW_UIEventCollection.Evt_UI_GetPlayerInfoPoolWidget, new BGW_UIEventCollection.Del_UI_GetPlayerInfoPoolWidget(GetPlayerInfoPoolWidget));
			bGW_UIEventCollection.Evt_UI_GetInteractIconPoolWidget = (BGW_UIEventCollection.Del_UI_GetInteractIconPoolWidget)Delegate.Remove(bGW_UIEventCollection.Evt_UI_GetInteractIconPoolWidget, new BGW_UIEventCollection.Del_UI_GetInteractIconPoolWidget(GetInteractIconPoolWidget));
			bGW_UIEventCollection.Evt_UI_ShowHPChangeNum = (BGW_UIEventCollection.Del_UI_ShowHPChangeNum)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ShowHPChangeNum, new BGW_UIEventCollection.Del_UI_ShowHPChangeNum(ShowHPChangeNum));
			bGW_UIEventCollection.Evt_UI_ClearAllProjWidget = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ClearAllProjWidget, new BGW_UIEventCollection.Del_UI_Void(ReuseBattleUI));
			bGW_UIEventCollection.Evt_UI_ClearDamageNumUI = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ClearDamageNumUI, new BGW_UIEventCollection.Del_UI_Void(ClearDamageNumUI));
			bGW_UIEventCollection.Evt_UI_ClearBindTopBar = (BGW_UIEventCollection.Del_UI_ClearBindTopBar)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ClearBindTopBar, new BGW_UIEventCollection.Del_UI_ClearBindTopBar(OnClearBindTopBar));
			bGW_UIEventCollection.Evt_UI_ReleaseBloodBar = (BGW_UIEventCollection.Del_UI_ReleaseBloodBar)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ReleaseBloodBar, new BGW_UIEventCollection.Del_UI_ReleaseBloodBar(OnReleaseBloodBar));
			bGW_UIEventCollection.Evt_UI_ShowBar = (BGW_UIEventCollection.Del_UI_ChangeBar)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ShowBar, new BGW_UIEventCollection.Del_UI_ChangeBar(OnShowBar));
			bGW_UIEventCollection.Evt_UI_HideBar = (BGW_UIEventCollection.Del_UI_ChangeBar)Delegate.Remove(bGW_UIEventCollection.Evt_UI_HideBar, new BGW_UIEventCollection.Del_UI_ChangeBar(OnHideBar));
			bGW_UIEventCollection.Evt_UI_SetAlwaysShowSetting = (BGW_UIEventCollection.Del_UI_SetAlwaysShowSetting)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetAlwaysShowSetting, new BGW_UIEventCollection.Del_UI_SetAlwaysShowSetting(SetAlwaysShowSetting));
			bGW_UIEventCollection.Evt_UI_SetAlwaysHideSetting = (BGW_UIEventCollection.Del_UI_SetAlwaysHideSetting)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetAlwaysHideSetting, new BGW_UIEventCollection.Del_UI_SetAlwaysHideSetting(SetAlwaysHideSetting));
			bGW_UIEventCollection.Evt_UI_SetHPBarPercent = (BGW_UIEventCollection.Del_UI_SetHPBarPercent)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetHPBarPercent, new BGW_UIEventCollection.Del_UI_SetHPBarPercent(SetHPBarPercent));
			bGW_UIEventCollection.Evt_UI_SetShieldBarActive = (BGW_UIEventCollection.Del_UI_SetShieldBarActive)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetShieldBarActive, new BGW_UIEventCollection.Del_UI_SetShieldBarActive(SetShieldBarActive));
			bGW_UIEventCollection.Evt_UI_SetShieldBarPercent = (BGW_UIEventCollection.Del_UI_SetShieldBarPercent)Delegate.Remove(bGW_UIEventCollection.Evt_UI_SetShieldBarPercent, new BGW_UIEventCollection.Del_UI_SetShieldBarPercent(SetShieldBarPercent));
			bGW_UIEventCollection.Evt_UI_GetBloodIsShowing = (BGW_UIEventCollection.Del_UI_GetBloodIsShowing)Delegate.Remove(bGW_UIEventCollection.Evt_UI_GetBloodIsShowing, new BGW_UIEventCollection.Del_UI_GetBloodIsShowing(GetBloodIsShowing));
			bGW_UIEventCollection.Evt_UI_InitTopBarUI = (BGW_UIEventCollection.Del_UI_InitTopBarUI)Delegate.Remove(bGW_UIEventCollection.Evt_UI_InitTopBarUI, new BGW_UIEventCollection.Del_UI_InitTopBarUI(InitTopBarUI));
			bGW_UIEventCollection.Evt_UI_RegTopBarUI = (BGW_UIEventCollection.Del_UI_Void_Chr)Delegate.Remove(bGW_UIEventCollection.Evt_UI_RegTopBarUI, new BGW_UIEventCollection.Del_UI_Void_Chr(RegTopBarUI));
			bGW_UIEventCollection.Evt_UI_UnRegTopBarUI = (BGW_UIEventCollection.Del_UI_Void_Chr)Delegate.Remove(bGW_UIEventCollection.Evt_UI_UnRegTopBarUI, new BGW_UIEventCollection.Del_UI_Void_Chr(UnRegTopBarUI));
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null || firstLocalPlayerController is ADebugCameraController || firstLocalPlayerController.GetControlledPawn() == null)
		{
			return;
		}
		base.OnUIGSInnerTickImpl(InDeltaTime);
		List<FProjWidgetInfo> list = new List<FProjWidgetInfo>();
		FProjWidgetInfo item = default(FProjWidgetInfo);
		foreach (BUI_ProjWidget key in ProjWidgetDic.Keys)
		{
			ProjWidgetInfo projWidgetInfo = ProjWidgetDic[key];
			BUI_ProjWidget projWidget = projWidgetInfo.ProjWidget;
			if (projWidget == null)
			{
				return;
			}
			item.Widget = projWidget;
			item.WorldPos = projWidget.GetWorldPos();
			item.UseDistanceZoom = projWidgetInfo.UseDistanceZoom;
			item.RoundRect = projWidgetInfo.RoundRect;
			item.UseRoundRectCalSize = projWidgetInfo.UseRoundRectCalSize;
			item.RoundRectCalSize = projWidgetInfo.RoundRectCalSize;
			if (key.GetIsUseHideRound())
			{
				item.HideRoundRect = projWidgetInfo.HideRoundRect;
			}
			else
			{
				item.HideRoundRect = null;
			}
			item.NeedCheckProjView = projWidgetInfo.NeedCheckProjView;
			item.ShowDistanceMax = projWidgetInfo.ShowDistanceMax;
			item.MinScale = projWidgetInfo.MinScale;
			item.MaxScale = projWidgetInfo.MaxScale;
			item.ScaleRate = projWidgetInfo.ScaleRate;
			item.XMinScale = projWidgetInfo.XMinScale;
			item.XMaxScale = projWidgetInfo.XMaxScale;
			item.YMinScale = projWidgetInfo.YMinScale;
			item.YMaxScale = projWidgetInfo.YMaxScale;
			list.Add(item);
		}
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.BeginSampleWithStatID(TickStatID);
		}
		UGSE_UMGFuncLib.GSProjectWidgetList(firstLocalPlayerController, this, list, out var Results);
		if (DebugConfig.IsOpenStatGSCustom)
		{
			ProfilerFuncLib.EndSample();
		}
		if (list.Count != Results.Count)
		{
			BGW_LogUtil.LogError("BattleInfo UpdateProjWidget ProjResult Not Match Data");
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			FProjWidgetInfo fProjWidgetInfo = list[i];
			BUI_ProjWidget bUI_ProjWidget = fProjWidgetInfo.Widget as BUI_ProjWidget;
			if (bUI_ProjWidget == null)
			{
				BGW_LogUtil.LogError($"BattleInfo UpdateProjWidget Pos Fail, ProjWidget Is Null, idx = {i}");
				continue;
			}
			FProjResult fProjResult = Results[i];
			if (i >= Results.Count)
			{
				BGW_LogUtil.LogError("BattleInfo UpdateProjWidget ProjResult Not Match Data");
				break;
			}
			if (fProjResult.IsInSight)
			{
				bUI_ProjWidget.SetAlwaysHideSetting(AlwaysHideSetting.OutOfSight, Value: false);
			}
			else
			{
				bUI_ProjWidget.SetAlwaysHideSetting(AlwaysHideSetting.OutOfSight, Value: true);
			}
			if (fProjResult.IndicatorType >= 0)
			{
				bUI_ProjWidget.SwitchUIStat((EIndicatorType)fProjResult.IndicatorType);
			}
			bUI_ProjWidget.SwitchUIInRound(fProjResult.IsInRound);
			bUI_ProjWidget.OnUpdateScrPosition(fProjResult.ScrPos, fProjResult.RectAngle);
			BUI_MBarBase bUI_MBarBase = bUI_ProjWidget as BUI_MBarBase;
			if (bUI_MBarBase != null && fProjWidgetInfo.UseDistanceZoom)
			{
				bUI_MBarBase.UpdateDistanceZoom(fProjResult.Scale, fProjResult.SizeScale);
			}
		}
	}

	private DamageNumShowParam GetDmgShowParam(DamageNumParam Param)
	{
		DamageTypeEnum inDamageType = DamageTypeEnum.NONE;
		int damageNum = Param.DamageNum;
		switch (Param.AttackerTeamType)
		{
		case EDmgNumUITeamType.Hero:
			if (Param.DamageNum < 0)
			{
				if (Param.DamageType == EDamageNumberType.Critical)
				{
					inDamageType = DamageTypeEnum.ENEMY_DMG_CRIT;
				}
				else if (Param.DamageType == EDamageNumberType.Normal)
				{
					inDamageType = DamageTypeEnum.ENEMY_DMG;
				}
			}
			break;
		case EDmgNumUITeamType.Enemy:
			if (Param.DamageNum < 0)
			{
				if (Param.DamageType == EDamageNumberType.Critical)
				{
					inDamageType = DamageTypeEnum.PLAYER_DMG_CRIT;
				}
				else if (Param.DamageType == EDamageNumberType.Normal)
				{
					inDamageType = DamageTypeEnum.PLAYER_DMG;
				}
			}
			break;
		}
		return new DamageNumShowParam(inDamageType, damageNum);
	}

	private BUI_MSimNum GetDmgNumRefWidget(DamageTypeEnum DmgType)
	{
		if (CachedDmgNumRefWidgets.ContainsKey(DmgType))
		{
			return CachedDmgNumRefWidgets[DmgType];
		}
		return null;
	}

	public BUI_ProjWidget GetTopBarPoolWidget(BGUCharacterCS OwnerUnit, bool IsBloodBar)
	{
		if (IsBloodBar && !IsBloodBarEnabled.Value)
		{
			return null;
		}
		int poolKey = (IsBloodBar ? 11 : 99);
		BUI_ProjWidget bUI_ProjWidget = ReuseWidget(poolKey) as BUI_ProjWidget;
		if (bUI_ProjWidget != null)
		{
			bUI_ProjWidget.Reset();
			bUI_ProjWidget.InitSet(new HPProjInfo(OwnerUnit));
			CacheProjWidgetScrPosUpdating(bUI_ProjWidget, CreateTopBarInfo(bUI_ProjWidget));
			return bUI_ProjWidget;
		}
		return null;
	}

	public ProjWidgetInfo CreateTopBarInfo(BUI_ProjWidget TopBarWidget)
	{
		BUI_MPlayerInfo bUI_MPlayerInfo = TopBarWidget as BUI_MPlayerInfo;
		UGSRoundRectQuick inRoundRect = ((!TopBarWidget.GetIsUseRound()) ? null : ((bUI_MPlayerInfo != null) ? PlayerInfoRoundRect : BarRoundRect));
		FVector2D inRoundRectCalSize = FVector2D.ZeroVector;
		if (bUI_MPlayerInfo != null)
		{
			inRoundRectCalSize = bUI_MPlayerInfo.GetCalInfoSize();
		}
		return new ProjWidgetInfo(TopBarWidget, inRoundRect, bUI_MPlayerInfo != null, inRoundRectCalSize, BarHideRoundRect, InUseDistanceZoom: true);
	}

	public BUI_MInteractIcon GetInteractIconPoolWidget(AActor InBindActor, EInteractType InInteractType, bool IsNeedUpdatePos = true)
	{
		if (!IsInteractIconEnabled.Value)
		{
			return null;
		}
		BUI_MInteractIcon bUI_MInteractIcon = ReuseWidget(98) as BUI_MInteractIcon;
		if (bUI_MInteractIcon != null)
		{
			bUI_MInteractIcon.Reset();
			MDSInteractIcon mDSInteractIcon = new MDSInteractIcon(InBindActor, InInteractType);
			mDSInteractIcon.SetIsSpecial(InIsSpecial: false);
			bUI_MInteractIcon.InitSet(mDSInteractIcon);
			bUI_MInteractIcon.Play();
			if (IsNeedUpdatePos)
			{
				CacheProjWidgetScrPosUpdating(bUI_MInteractIcon, new ProjWidgetInfo(bUI_MInteractIcon, null, InUseRoundRectCalSize: false, default(FVector2D), null, InUseDistanceZoom: false, InNeedCheckProjView: true));
			}
			return bUI_MInteractIcon;
		}
		return null;
	}

	private void CreateDmgNumPools()
	{
		CreatePool(17, DmgNumPoolSize, DmgNumPoolPrefix + "_All");
	}

	private void ReferencingDmgWidgets()
	{
		CachedDmgNumRefWidgets = new Dictionary<DamageTypeEnum, BUI_MSimNum>();
		BUI_MSimNum bUI_MSimNum = FindChildWidget("BI_AllDmg") as BUI_MSimNum;
		if (bUI_MSimNum != null)
		{
			CachedDmgNumRefWidgets.Add(DamageTypeEnum.All, bUI_MSimNum);
		}
		foreach (BUI_MSimNum value in CachedDmgNumRefWidgets.Values)
		{
			value?.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	private void ReferencingBloodBarWidgets()
	{
		CachedBloodBarRefWidgets = new Dictionary<BloodBarTypeEnum, BUI_MBarBase>();
		BUI_MBarBase bUI_MBarBase = FindChildWidget("BI_EnemyBar") as BUI_MBarBase;
		if (bUI_MBarBase != null)
		{
			CachedBloodBarRefWidgets.Add(BloodBarTypeEnum.ENEMY, bUI_MBarBase);
		}
		foreach (BUI_MBarBase value in CachedBloodBarRefWidgets.Values)
		{
			value?.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	private void CreateBloodBarPools()
	{
		if (DebugConfig.IsTmpTestFlag)
		{
			BloodBarPoolSize_Enemy = 20;
		}
		CreatePool(11, BloodBarPoolSize_Enemy, BloodBarPoolPrefix + "_Enemy");
	}

	private BUI_MBarBase GetBloodBarRefWidget(BloodBarTypeEnum BloodBarType)
	{
		if (CachedBloodBarRefWidgets.ContainsKey(BloodBarType))
		{
			return CachedBloodBarRefWidgets[BloodBarType];
		}
		return null;
	}

	private void ReferencingPlayerInfoWidgets()
	{
		PlayerInfoRefWidget = FindChildWidget("BI_PlayerInfo") as BUI_MPlayerInfo;
		PlayerInfoRefWidget?.SetVisibility(ESlateVisibility.Collapsed);
	}

	private void CreatePlayerInfoPools()
	{
		UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(this));
	}

	private void ReferencingInteractIconWidgets()
	{
		InteractIconRefWidget = FindChildWidget("BI_InteractIcon") as BUI_MInteractIcon;
		InteractIconRefWidget?.SetVisibility(ESlateVisibility.Collapsed);
	}

	private void CreateInteractIconPools()
	{
		CreatePool(98, InteractIconPoolSize, InteractIconPoolPrefix ?? "");
	}

	public void CreatePool(int PoolKey, int PoolSize, string PoolName)
	{
		if (BattleWidgetPoolDic.ContainsKey(PoolKey))
		{
			return;
		}
		BattleWidgetPoolDic.Add(PoolKey, new Queue<IPoolWidget>());
		if (PoolName.StartsWith(DmgNumPoolPrefix))
		{
			BUI_MSimNum dmgNumRefWidget = GetDmgNumRefWidget((DamageTypeEnum)PoolKey);
			if (dmgNumRefWidget != null)
			{
				CreatePoolWidgets(dmgNumRefWidget, PoolKey, PoolName, PoolSize, NumCon);
			}
		}
		else if (PoolName.StartsWith(BloodBarPoolPrefix))
		{
			BUI_MBarBase bloodBarRefWidget = GetBloodBarRefWidget((BloodBarTypeEnum)PoolKey);
			if (bloodBarRefWidget != null)
			{
				CreatePoolWidgets(bloodBarRefWidget, PoolKey, PoolName, PoolSize, BarRoundRect);
			}
		}
		else if (PoolName.StartsWith(InteractIconPoolPrefix) && InteractIconRefWidget != null)
		{
			CreatePoolWidgets(InteractIconRefWidget, PoolKey, PoolName, PoolSize, InteractIconCon);
		}
	}

	private void CreatePoolWidgets(BUI_Widget RefWidget, int PoolKey, string PoolName, int PoolSize, UPanelWidget ParentPanel)
	{
		for (int i = 0; i < PoolSize; i++)
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CloneUserWidget(RefWidget, new FName($"{PoolName}_{PoolKey}_{i}"));
			if (uUserWidget != null)
			{
				uUserWidget.SetVisibility(ESlateVisibility.Collapsed);
				if (ParentPanel != null)
				{
					ParentPanel.AddChild(uUserWidget);
				}
				GSUIPanelSlotHelper.WidgetSlotCopy(RefWidget, uUserWidget);
				BattleWidgetPoolDic[PoolKey].Enqueue(uUserWidget as IPoolWidget);
			}
		}
	}

	public IPoolWidget ReuseWidget(int PoolKey)
	{
		if (!BattleWidgetPoolDic.ContainsKey(PoolKey) || BattleWidgetPoolDic[PoolKey].Count == 0)
		{
			return null;
		}
		IPoolWidget poolWidget = BattleWidgetPoolDic[PoolKey].Dequeue();
		if (poolWidget != null)
		{
			BattleWidgetPoolDic[PoolKey].Enqueue(poolWidget);
			return poolWidget;
		}
		return null;
	}

	public void ReuseAllPool()
	{
		foreach (KeyValuePair<int, Queue<IPoolWidget>> item in BattleWidgetPoolDic)
		{
			foreach (IPoolWidget item2 in item.Value)
			{
				item2?.Reset();
			}
		}
		ClearBindProjWidget();
	}

	private void OnProjWidgetResetEvent(BUI_ProjWidget Key)
	{
		if (!(Key == null))
		{
			ProjWidgetDic.Remove(Key);
		}
	}

	private void CacheProjWidgetScrPosUpdating(BUI_ProjWidget TopBarWidget, ProjWidgetInfo ProjWidgetData, bool NeedRemove = true)
	{
		if (!ProjWidgetDic.ContainsKey(TopBarWidget))
		{
			ProjWidgetDic.Add(TopBarWidget, ProjWidgetData);
		}
		else
		{
			ProjWidgetDic[TopBarWidget] = ProjWidgetData;
		}
		if (NeedRemove && TopBarWidget.OnProjWidgetResetEvent == null)
		{
			TopBarWidget.OnProjWidgetResetEvent = OnProjWidgetResetEvent;
		}
	}

	private void SetBattleInfoEnabled(bool InIsBattleInfoEnabled)
	{
		IsBattleInfoEnabled.SetValue(EChangeReason.ManualSet, InIsBattleInfoEnabled);
	}

	private void SetDamageNumEnabled(bool InIsDamageNumEnabled)
	{
		if (IsDamageNumCanEnabled.Value && InIsDamageNumEnabled)
		{
			IsDamageNumEnabled.SetValue(EChangeReason.ManualSet, value: true);
		}
		else
		{
			IsDamageNumEnabled.SetValue(EChangeReason.ManualSet, value: false);
		}
	}

	private void SetBloodBarEnabled(bool InIsBloodBarEnabled)
	{
		if (IsBloodBarCanEnabled.Value && InIsBloodBarEnabled)
		{
			IsBloodBarEnabled.SetValue(EChangeReason.ManualSet, value: true);
		}
		else
		{
			IsBloodBarEnabled.SetValue(EChangeReason.ManualSet, value: false);
		}
	}

	private void SetPlayerInfoEnabled(bool InIsPlayerInfoEnabled)
	{
		if (IsPlayerInfoCanEnabled.Value && InIsPlayerInfoEnabled)
		{
			IsPlayerInfoEnabled.SetValue(EChangeReason.ManualSet, value: true);
		}
		else
		{
			IsPlayerInfoEnabled.SetValue(EChangeReason.ManualSet, value: false);
		}
	}

	private void SetInteractIconEnabled(bool InIsInteractIconEnabled)
	{
		if (IsInteractIconCanEnabled.Value && InIsInteractIconEnabled)
		{
			IsInteractIconEnabled.SetValue(EChangeReason.ManualSet, value: true);
		}
		else
		{
			IsInteractIconEnabled.SetValue(EChangeReason.ManualSet, value: false);
		}
	}

	private void SetDamageNumCanEnabled(bool InIsDamageNumCanEnabled)
	{
		IsDamageNumCanEnabled.SetValue(EChangeReason.ManualSet, InIsDamageNumCanEnabled);
		SetDamageNumEnabled(IsDamageNumEnabled.Value);
	}

	private void SetBloodBarCanEnabled(bool InIsBloodBarCanEnabled)
	{
		IsBloodBarCanEnabled.SetValue(EChangeReason.ManualSet, InIsBloodBarCanEnabled);
		SetBloodBarEnabled(IsBloodBarEnabled.Value);
	}

	private void SetPlayerInfoCanEnabled(bool InIsPlayerInfoCanEnabled)
	{
		IsPlayerInfoCanEnabled.SetValue(EChangeReason.ManualSet, InIsPlayerInfoCanEnabled);
		SetPlayerInfoEnabled(IsPlayerInfoEnabled.Value);
	}

	private void SetInteractIconCanEnabled(bool InIsInteractIconCanEnabled)
	{
		IsInteractIconCanEnabled.SetValue(EChangeReason.ManualSet, InIsInteractIconCanEnabled);
		SetInteractIconEnabled(IsInteractIconEnabled.Value);
	}

	private void ShowHPChangeNum(DamageNumParam Param)
	{
		if (IsDamageNumEnabled.Value)
		{
			ShowDamageNum(Param);
		}
	}

	private void ShowDamageNum(DamageNumParam Param)
	{
		DamageNumShowParam dmgShowParam = GetDmgShowParam(Param);
		if (dmgShowParam.DamageType == DamageTypeEnum.NONE)
		{
			return;
		}
		BUI_MSimNum bUI_MSimNum = ReuseWidget(17) as BUI_MSimNum;
		if (bUI_MSimNum != null)
		{
			bUI_MSimNum.Reset();
			if (!(BGW_PreloadAssetMgr.Get(this).DamageNumConfig == null))
			{
				bUI_MSimNum.SetDamageNumParam(dmgShowParam, Param, BGW_PreloadAssetMgr.Get(this).DamageNumConfig);
				CacheProjWidgetScrPosUpdating(bUI_MSimNum, CreateDamageProjInfo(bUI_MSimNum));
				bUI_MSimNum.Play();
			}
		}
	}

	private static ProjWidgetInfo CreateDamageProjInfo(BUI_MSimNum TheReusedWidget)
	{
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.MsimNumDistanceMax);
		float inShowDistanceMax = commLogicCfgValue;
		return new ProjWidgetInfo(TheReusedWidget, null, InUseRoundRectCalSize: false, default(FVector2D), null, InUseDistanceZoom: false, InNeedCheckProjView: true, inShowDistanceMax);
	}

	private BUI_MBarBase GetBloodBarPoolWidget(BGUCharacterCS OwnerUnit, EBGUBloodBarType BloodBarType, bool IsSelfTeam, bool IsPlayer)
	{
		if (OwnerUnit == null)
		{
			return null;
		}
		return GetTopBarPoolWidget(OwnerUnit, IsBloodBar: true) as BUI_MBarBase;
	}

	private BUI_MPlayerInfo GetPlayerInfoPoolWidget(BGUCharacterCS OwnerUnit)
	{
		if (OwnerUnit == null)
		{
			return null;
		}
		return GetTopBarPoolWidget(OwnerUnit, IsBloodBar: false) as BUI_MPlayerInfo;
	}

	public void ReuseBattleUI()
	{
		ReuseAllPool();
	}

	private void ClearDamageNumUI()
	{
		foreach (KeyValuePair<int, Queue<IPoolWidget>> item in BattleWidgetPoolDic)
		{
			foreach (IPoolWidget item2 in item.Value)
			{
				if (item2 != null && item2 is BUI_MSimNum)
				{
					item2.Reset();
				}
			}
		}
	}

	private bool IsBindProjWidget(Entity Entity)
	{
		return EntityDic.ContainsKey(Entity);
	}

	private void BindProjWidget(Entity Entity, BUI_ProjWidget Widget)
	{
		if (!Entity.IsNull() && !(Widget == null) && !EntityDic.ContainsKey(Entity))
		{
			EntityDic.Add(Entity, Widget);
		}
	}

	private void UnbindProjWidget(Entity Entity)
	{
		if (!Entity.IsNull() && EntityDic.TryGetValue(Entity, out var _))
		{
			EntityDic.Remove(Entity);
		}
	}

	private void ClearBindProjWidget()
	{
		EntityDic.Clear();
	}

	private BUI_ProjWidget GetBindProjWidget(Entity Entity)
	{
		if (Entity.IsNull())
		{
			return null;
		}
		if (EntityDic.TryGetValue(Entity, out var value))
		{
			return value;
		}
		return null;
	}

	private static void GetIsLocalPlayer(Entity Entity, out bool IsPlayer, out bool IsLocal)
	{
		IsPlayer = false;
		IsLocal = false;
		BGUPlayerCharacterCS bGUPlayerCharacterCS = ECSExtension.ToActor(Entity) as BGUPlayerCharacterCS;
		if (!bGUPlayerCharacterCS.IsNullOrDestroyed())
		{
			IsPlayer = bGUPlayerCharacterCS.IsPlayerControlled();
			IsLocal = bGUPlayerCharacterCS.IsLocallyControlled();
		}
	}

	private void InitTopBarUI(Entity Entity)
	{
		GetIsLocalPlayer(Entity, out var IsPlayer, out var IsLocal);
		if (!IsPlayer)
		{
			InitBloodBarUI(Entity);
		}
		else if (!IsLocal)
		{
			InitPlayerInfoUI(Entity);
		}
	}

	private void RegTopBarUI(BGUCharacterCS Character)
	{
		if (!BloodBarActorBindDict.ContainsKey(Character))
		{
			DSBarInfoBind value = default(DSBarInfoBind);
			UnitTopBarOneBind unitTopBarOneBind = new UnitTopBarOneBind(Character, this);
			value.UnitBarInfoData = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBUC_UnitBarInfoData>(Character);
			value.UnitTopBarOneBind = unitTopBarOneBind;
			value.BloodBarActivedBindIdx = value.UnitBarInfoData.BindBloodBarActivedChange(unitTopBarOneBind.BloodShowStateChange);
			value.BindBloodBarPercentIdx = value.UnitBarInfoData.BindBloodBarPercentChange(unitTopBarOneBind.BloodPercentChange);
			value.ShieldActivedBindIdx = value.UnitBarInfoData.BindShieldBarActivedChange(unitTopBarOneBind.ShieldShowStateChange);
			value.BindShieldBarPercentIdx = value.UnitBarInfoData.BindShieldBarPercentChange(unitTopBarOneBind.ShieldPercentChange);
			BloodBarActorBindDict.Add(Character, value);
		}
	}

	private void UnRegTopBarUI(BGUCharacterCS Character)
	{
		if (BloodBarActorBindDict.TryGetValue(Character, out var value))
		{
			value.UnitBarInfoData.UnBindBloodBarActivedChange(value.BloodBarActivedBindIdx, value.UnitTopBarOneBind.BloodShowStateChange);
			value.UnitBarInfoData.UnBindBloodBarPercentChange(value.BindBloodBarPercentIdx, value.UnitTopBarOneBind.BloodPercentChange);
			value.UnitBarInfoData.UnBindShieldBarActivedChange(value.ShieldActivedBindIdx, value.UnitTopBarOneBind.ShieldShowStateChange);
			value.UnitBarInfoData.UnBindShieldBarPercentChange(value.BindShieldBarPercentIdx, value.UnitTopBarOneBind.ShieldPercentChange);
			BloodBarActorBindDict.Remove(Character);
			value.UnitTopBarOneBind.BattleInfoCS.OnReleaseBloodBar(ECSExtension.ToEntity(Character));
		}
	}

	public void BloodShowStateChange(Entity Entity, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetAlwaysShowSetting(AlwaysShowSetting.Always, Value: true);
		}
		else
		{
			GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetAlwaysShowSetting(AlwaysShowSetting.Always, Value: false);
		}
	}

	private void InitPlayerInfoUI(Entity Entity)
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(this)) && !IsBindProjWidget(Entity))
		{
			BGUCharacterCS bGUCharacterCS = ECSExtension.ToActor(Entity) as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUI_MPlayerInfo playerInfoPoolWidget = GetPlayerInfoPoolWidget(bGUCharacterCS);
				playerInfoPoolWidget?.SetAlwaysShowSetting(AlwaysShowSetting.Always, Value: true);
				BindProjWidget(Entity, playerInfoPoolWidget);
			}
		}
	}

	private void InitBloodBarUI(Entity Entity)
	{
		if (IsBindProjWidget(Entity))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(Entity);
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
		if (unitCommDesc == null)
		{
			return;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null)
		{
			return;
		}
		EBGUBloodBarShowType eBGUBloodBarShowType = EBGUBloodBarShowType.Change;
		bool isInPlayerTeam = BGU_DataUtil.GetIsInPlayerTeam(aActor);
		if (unitBattleInfoExtendDesc.BloodBarType != EBGUBloodBarType.None && eBGUBloodBarShowType != EBGUBloodBarShowType.Hide && !isInPlayerTeam)
		{
			GetIsLocalPlayer(Entity, out var IsPlayer, out var _);
			BUI_MBarBase bloodBarPoolWidget = GetBloodBarPoolWidget(bGUCharacterCS, unitBattleInfoExtendDesc.BloodBarType, isInPlayerTeam, IsPlayer);
			bloodBarPoolWidget?.InitBloodBar(unitBattleInfoExtendDesc.BloodBarType, unitCommDesc.HPBarHeightOffset);
			switch (eBGUBloodBarShowType)
			{
			case EBGUBloodBarShowType.Always:
				bloodBarPoolWidget?.SetAlwaysShowSetting(AlwaysShowSetting.Always, Value: true);
				break;
			case EBGUBloodBarShowType.Hide:
				bloodBarPoolWidget?.SetAlwaysHideSetting(AlwaysHideSetting.Always, Value: true);
				break;
			}
			BindProjWidget(Entity, bloodBarPoolWidget);
			if (IsBindProjWidget(Entity) && BloodBarActorBindDict.TryGetValue(aActor, out var value))
			{
				value.ReInit();
			}
		}
	}

	public T GetCheckInitTopBar<T>(Entity Entity) where T : BUI_ProjWidget
	{
		if (!IsBindProjWidget(Entity))
		{
			InitTopBarUI(Entity);
		}
		return GetBindProjWidget(Entity) as T;
	}

	private bool GetBloodIsShowing(Entity Entity)
	{
		BUI_ProjWidget bindProjWidget = GetBindProjWidget(Entity);
		if (bindProjWidget != null)
		{
			return bindProjWidget.GetIsShowing();
		}
		return false;
	}

	private void OnShowBar(Entity Entity, ShowBarType ShowType)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.ShowBar(ShowType);
	}

	private void OnHideBar(Entity Entity, ShowBarType ShowType)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.HideBar(ShowType);
	}

	private void SetAlwaysShowSetting(Entity Entity, AlwaysShowSetting State, bool Value)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetAlwaysShowSetting(State, Value);
	}

	private void SetAlwaysHideSetting(Entity Entity, AlwaysHideSetting State, bool Value)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetAlwaysHideSetting(State, Value);
	}

	public void InitHPBarPercent(Entity Entity, float HPPercent)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetHPBarPercent(HPPercent, IsNow: true);
	}

	public void SetHPBarPercent(Entity Entity, float HPPercent, bool IsChangeShow = false)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetHPBarPercent(HPPercent, IsNow: false, IsChangeShow);
	}

	public void SetShieldBarActive(Entity Entity, bool IsActive)
	{
		(GetBindProjWidget(Entity) as BUI_MBarBase)?.SetShieldBarActive(IsActive);
	}

	public void InitShieldBarPercent(Entity Entity, float Percent)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetShieldBarPercent(Percent);
	}

	public void SetShieldBarPercent(Entity Entity, float Percent, bool IsChangeShow = false)
	{
		GetCheckInitTopBar<BUI_MBarBase>(Entity)?.SetShieldBarPercent(Percent, IsNow: false, IsChangeShow);
	}

	private void OnClearBindTopBar(Entity Entity)
	{
		UnbindProjWidget(Entity);
	}

	private void OnReleaseBloodBar(Entity Entity)
	{
		GetBindProjWidget(Entity)?.Stop(ForceReset: true);
		UnbindProjWidget(Entity);
	}

	public string LogProjStat()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("LogBattleInfo:");
		foreach (KeyValuePair<BUI_ProjWidget, ProjWidgetInfo> item in ProjWidgetDic)
		{
			stringBuilder.AppendLine($"{item.Key.GetFullName()}|{item.Key}");
		}
		return stringBuilder.ToString();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BattleInfoCS");
	}

	static BUI_BattleInfoCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BattleInfoCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BattleInfoCS));
	}
}
