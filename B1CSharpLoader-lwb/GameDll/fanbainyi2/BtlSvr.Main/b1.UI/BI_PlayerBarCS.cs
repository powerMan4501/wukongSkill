using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_PlayerBarCS")]
public class BI_PlayerBarCS : BUI_Widget
{
	private DSPlayerBar DataStore;

	private BI_HpProgBarCS HpProgBar;

	private BI_ProgBarCS MpBar;

	private BI_ProgBarCS StBar;

	private BI_GourdCS Gourd;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		HpProgBar = FindChildWidget("HpBar") as BI_HpProgBarCS;
		DataStore = new DSPlayerBar(this, HpProgBar.UseAbnormalFx, HpProgBar.ZeroHide);
		HpProgBar.InitDataStore(DataStore.HpProgBar);
		MpBar = FindChildWidget("MpBar") as BI_ProgBarCS;
		MpBar.InitDataStore(DataStore.MpProgBar);
		StBar = FindChildWidget("StBar") as BI_ProgBarCS;
		StBar.InitDataStore(DataStore.StProgBar);
		Gourd = FindChildWidget("GourdBar") as BI_GourdCS;
		SetLowHpTips(BGW_SettingMgrV2.Get(this).GetCVValueleByType(UISettingConfigType.LowHpTips));
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		}
	}

	public void SetIsUseShortAnim(bool InIsUseShortAnim)
	{
		HpProgBar.SetIsUseShortAnim(InIsUseShortAnim);
		MpBar.SetIsUseShortAnim(InIsUseShortAnim);
		StBar.SetIsUseShortAnim(InIsUseShortAnim);
	}

	public void StopScaleAnim()
	{
		HpProgBar.StopScaleAnim();
		MpBar.StopScaleAnim();
		StBar.StopScaleAnim();
	}

	public void UpdateGourdConVisibility(ESlateVisibility SlateVisibility)
	{
		Gourd.UpdateGourdConVisibility(SlateVisibility);
	}

	public void UpdateGourdSlot(List<int> ItemIDs)
	{
		Gourd.UpdateGourdSlot(ItemIDs);
	}

	public void OnlyDisplayBar(EOnlyDisplayPlayerBarType TargetDisplayType)
	{
		switch (TargetDisplayType)
		{
		case EOnlyDisplayPlayerBarType.None:
			HpProgBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			MpBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			StBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			Gourd.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			break;
		case EOnlyDisplayPlayerBarType.Hp:
			HpProgBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			MpBar.SetVisibility(ESlateVisibility.Collapsed);
			StBar.SetVisibility(ESlateVisibility.Collapsed);
			Gourd.SetVisibility(ESlateVisibility.Collapsed);
			break;
		case EOnlyDisplayPlayerBarType.Mp:
			HpProgBar.SetVisibility(ESlateVisibility.Collapsed);
			MpBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			StBar.SetVisibility(ESlateVisibility.Collapsed);
			Gourd.SetVisibility(ESlateVisibility.Collapsed);
			break;
		case EOnlyDisplayPlayerBarType.St:
			HpProgBar.SetVisibility(ESlateVisibility.Collapsed);
			MpBar.SetVisibility(ESlateVisibility.Collapsed);
			StBar.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			Gourd.SetVisibility(ESlateVisibility.Collapsed);
			break;
		}
	}

	public float GetScaleAnimShowTime()
	{
		float num = 0f;
		if (HpProgBar.GetScaleAnimShowTime() > num)
		{
			num = HpProgBar.GetScaleAnimShowTime();
		}
		if (MpBar.GetScaleAnimShowTime() > num)
		{
			num = MpBar.GetScaleAnimShowTime();
		}
		if (StBar.GetScaleAnimShowTime() > num)
		{
			num = StBar.GetScaleAnimShowTime();
		}
		return num;
	}

	protected override void OnUIDestruct()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		}
		base.OnUIDestruct();
	}

	private void OnSettingValueChanged(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.LowHpTips)
		{
			SetLowHpTips(NewValue);
		}
	}

	private void SetLowHpTips(int TargetValue)
	{
		if (!(HpProgBar != null))
		{
			return;
		}
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
		if (bGW_PreloadAssetMgr != null)
		{
			BGWUIConfigDataAsset uIConfigDataAsset = bGW_PreloadAssetMgr.UIConfigDataAsset;
			if (uIConfigDataAsset != null && uIConfigDataAsset.SettingHpConfig != null && uIConfigDataAsset.SettingHpConfig.Count > TargetValue)
			{
				FSettingHpConfig fSettingHpConfig = uIConfigDataAsset.SettingHpConfig[TargetValue];
				HpProgBar.SetLowHpTips(fSettingHpConfig.HPLowPostProcessPercent, fSettingHpConfig.HPLimitPostProcessPercent);
				uIConfigDataAsset.HPLowPostProcessPercent = fSettingHpConfig.HPLowPostProcessPercent;
				uIConfigDataAsset.HPLimitPostProcessPercent = fSettingHpConfig.HPLimitPostProcessPercent;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_PlayerBarCS");
	}

	static BI_PlayerBarCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_PlayerBarCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_PlayerBarCS));
	}
}
