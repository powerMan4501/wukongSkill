using System;
using System.Collections.Generic;
using b1.GSMUI.GSWidget;
using b1.Plugins.NiagaraUIRenderer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ProgBarCS")]
public class BI_ProgBarCS : BUI_Widget
{
	protected BGW_UIMgr UIMgr;

	protected MDSBattleMain BattleMain;

	protected DSProgBarInfo DataStore;

	protected IProcBar ProgBar;

	protected UImage BarProcWarning;

	protected UMaterialInstanceDynamic WarningMat;

	protected UNiagaraSystemWidget UINSSuckIn;

	protected UNiagaraSystemWidget UINSSpark;

	private UWidgetAnimation AnimPercentRevert;

	protected UWidgetAnimation AnimMaxInc;

	protected UWidgetAnimation AnimWarnOnceSafe;

	protected UWidgetAnimation AnimWarnOnceDanger;

	protected UWidgetAnimation AnimMaxIncShort;

	private bool IsUseShortAnim;

	protected bool BlockPrecentChange;

	protected UWidgetAnimation AnimMaxIncImpl
	{
		get
		{
			if (!IsUseShortAnim)
			{
				return AnimMaxInc;
			}
			return AnimMaxIncShort;
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InitConstruct();
	}

	protected virtual void InitConstruct()
	{
		UIMgr = BGW_UIMgr.Get(this);
		BattleMain = UIMgr.GetMDSBattleMain();
		ProgBar = FindAndConstructIProcBar("ProgBar");
		BarProcWarning = FindChildWidget("BarProcWarning") as UImage;
		WarningMat = BarProcWarning?.GetDynamicMaterial();
		UINSSuckIn = FindChildWidget("UINS_SuckIn") as UNiagaraSystemWidget;
		UINSSpark = FindChildWidget("UINS_Spark") as UNiagaraSystemWidget;
		AnimPercentRevert = FindWidgetAnimation("AnimPercentRevert");
		AnimMaxInc = FindWidgetAnimation("AnimMaxInc");
		AnimWarnOnceSafe = FindWidgetAnimation("AnimWarnOnceSafe");
		AnimWarnOnceDanger = FindWidgetAnimation("AnimWarnOnceDanger");
		AnimMaxIncShort = FindWidgetAnimation("AnimMaxIncShort");
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_PauseShowBarScaleAnim = (BGW_UIEventCollection.Del_UI_Void_Bool)Delegate.Combine(bGW_UIEventCollection.Evt_UI_PauseShowBarScaleAnim, new BGW_UIEventCollection.Del_UI_Void_Bool(OnPauseShowBarScaleAnim));
			bGW_UIEventCollection.Evt_UI_CheckShowBarScaleAnim = (BGW_UIEventCollection.Del_UI_CheckShowBarScaleAnim)Delegate.Combine(bGW_UIEventCollection.Evt_UI_CheckShowBarScaleAnim, new BGW_UIEventCollection.Del_UI_CheckShowBarScaleAnim(OnCheckShowBarScaleAnim));
		}
		SetVisibility(ESlateVisibility.Collapsed);
	}

	public virtual void InitDataStore(DSProgBarInfo InDataStore)
	{
		if (DataStore != InDataStore)
		{
			ReleaseBindAction();
			DataStore = InDataStore;
			if (DataStore != null)
			{
				BindEvent();
			}
			else
			{
				Reset();
			}
		}
	}

	public DSProgBarInfo GetDataStore()
	{
		return DataStore;
	}

	public virtual void BindEvent()
	{
		BindValueToCustom(DataStore.IsShow, OnChangeIsShow);
		BindValueToCustom(DataStore.Percent, OnChangePercent);
		BindValueToCustom(DataStore.PlayScaleAnimAction, OnChangePlayScaleAnim);
		BindValueToCustom(DataStore.BarData, OnChangeBarData);
		BindValueToCustom(DataStore.BindResId, OnChangeBindResId);
	}

	public virtual void Reset()
	{
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (DataStore != null && DataStore.ScaleAnimShowTime.Value > 0f)
		{
			DataStore.SetScaleAnimShowTime(DataStore.ScaleAnimShowTime.Value - InDeltaTime);
			BattleMain.UpdateShowAreaList(new List<EnMainAreaType> { EnMainAreaType.PlayerBar });
			BattleMain.TriggerShowState(EnMainShowState.SHOWAREA);
		}
	}

	protected void OnPauseShowBarScaleAnim(bool InPauseScaleAnim)
	{
		if (DataStore != null)
		{
			DataStore.SetPauseScaleAnim(InPauseScaleAnim);
		}
	}

	protected void OnCheckShowBarScaleAnim(EChangeReason Reason)
	{
		if (DataStore != null)
		{
			DataStore.ForceUpdate();
			DataStore.PlayScaleAnim(Reason);
		}
	}

	protected void OnChangePlayScaleAnim(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (Reason == EChangeReason.Init)
		{
			return;
		}
		float scaleAnimShowTime = 0f;
		StopAnimation(AnimMaxIncImpl);
		UINSSuckIn?.GSStopFX();
		UINSSpark?.GSStopFX();
		if (ProgBar.GetInScaleAnim())
		{
			switch (Reason)
			{
			case EChangeReason.ManualSet:
				UIMgr.PlayUISound("EVT_ui_hud_player_shangxianzengzhang");
				PlayWidgetAnimation(AnimMaxIncImpl);
				if (AnimMaxIncImpl != null)
				{
					scaleAnimShowTime = AnimMaxIncImpl.GetEndTime();
				}
				break;
			case EChangeReason.InnerOp:
			{
				ProgBar?.PlayScaleAnim();
				GSProcBar gSProcBar = ProgBar as GSProcBar;
				if (gSProcBar != null)
				{
					scaleAnimShowTime = gSProcBar.MaxIncNormalTime;
				}
				break;
			}
			}
		}
		DataStore.SetScaleAnimShowTime(scaleAnimShowTime);
	}

	protected virtual void OnChangePercent(EChangeReason Reason, float OldValue, float NewValue)
	{
		WarningMat?.SetScalarParameterValue(B1GlobalFNames.GSScalarParameter_Percent, NewValue);
	}

	protected virtual void OnChangeBarData(EChangeReason Reason, FBarData OldValue, FBarData NewValue)
	{
		GSProcBar gSProcBar = ProgBar as GSProcBar;
		ProgBar?.SetMaxValue(NewValue.MaxValue, Reason == EChangeReason.Init);
		ProgBar?.SetValue(NewValue.Value, Reason == EChangeReason.Init);
		if (Reason != EChangeReason.Init && !DataStore.PauseScaleAnim.Value)
		{
			DataStore.PlayScaleAnim(EChangeReason.InnerOp);
		}
		if ((OldValue.MaxValue == 0f && OldValue.Value == 0f && OldValue.Percent == 0f) || Reason == EChangeReason.Init || gSProcBar == null || gSProcBar.GetBlockOnce())
		{
			return;
		}
		bool flag = IsAnimationPlaying(AnimWarnOnceDanger);
		bool flag2 = IsAnimationPlaying(AnimWarnOnceSafe);
		bool flag3 = false;
		bool flag4 = false;
		if ((NewValue.MaxValue - OldValue.MaxValue) * (NewValue.Value - OldValue.Value) >= 0f)
		{
			if (NewValue.MaxValue != OldValue.MaxValue)
			{
				if (NewValue.MaxValue > OldValue.MaxValue)
				{
					flag4 = true;
				}
				else
				{
					flag3 = true;
				}
			}
			if (!flag4 && !flag3 && NewValue.Value != OldValue.Value)
			{
				if (NewValue.Percent >= 1f)
				{
					flag4 = true;
				}
				else if (NewValue.Percent <= 0f)
				{
					flag3 = true;
				}
			}
			if (!flag4 && !flag3 && NewValue.Percent != OldValue.Percent)
			{
				float num = NewValue.Percent - OldValue.Percent;
				if (gSProcBar.OnceWarnPercent > 0f && FMath.Abs(num) > gSProcBar.OnceWarnPercent)
				{
					if (num > 0f)
					{
						flag4 = true;
					}
					else
					{
						flag3 = true;
					}
				}
			}
		}
		if (flag3 || flag4 || (flag && NewValue.Value > OldValue.Value) || (flag2 && NewValue.Value < OldValue.Value))
		{
			StopAnimation(AnimWarnOnceSafe);
			StopAnimation(AnimWarnOnceDanger);
		}
		if (flag3)
		{
			PlayWidgetAnimation(AnimWarnOnceDanger);
		}
		else if (flag4)
		{
			PlayWidgetAnimation(AnimWarnOnceSafe);
		}
	}

	protected virtual void OnChangeIsShow(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	private void OnChangeBindResId(EChangeReason Reason, int OldValue, int NewValue)
	{
		SetBindResId(NewValue);
	}

	public void SetDefalutValueType(EDefaulValueType InDefalutValueType)
	{
		if (ProgBar is GSProcBar gSProcBar)
		{
			gSProcBar.SetDefalutValueType(InDefalutValueType);
		}
	}

	public void SetBindResId(int InBindResId)
	{
		if (ProgBar is GSProcBar gSProcBar)
		{
			gSProcBar.SetBindResId(InBindResId);
		}
	}

	public void SetBlockChange(bool IsBlock)
	{
		BlockPrecentChange = IsBlock;
	}

	public void SetProgress(float CurValue, float MaxValue, bool IsImmediately = false)
	{
		ProgBar.SetValue(CurValue, IsImmediately);
		ProgBar.SetMaxValue(MaxValue, IsImmediately);
	}

	public void PlayPercentRevert()
	{
		PlayWidgetAnimation(AnimPercentRevert);
	}

	public UMaterialInstanceDynamic GetMainMI()
	{
		return ProgBar.GetMainMat();
	}

	public float GetProgBarIncTime()
	{
		return (ProgBar as GSProcBarV4).IncBarIncTime;
	}

	public float GetScaleAnimShowTime()
	{
		return DataStore.ScaleAnimShowTime.Value;
	}

	public void SetIsUseShortAnim(bool InIsUseShortAnim)
	{
		IsUseShortAnim = InIsUseShortAnim;
	}

	public void StopScaleAnim()
	{
		if (ProgBar is GSProcBar gSProcBar)
		{
			DataStore.ForceUpdate();
			gSProcBar.StopScaleAnimAndCurLength();
		}
	}

	public void UpdateActiveState(bool Active)
	{
		if (Active)
		{
			GSAnimKeyToState("AKBBarState", "Act");
		}
		else
		{
			GSAnimKeyToState("AKBBarState", "Deact");
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_PauseShowBarScaleAnim = (BGW_UIEventCollection.Del_UI_Void_Bool)Delegate.Remove(bGW_UIEventCollection.Evt_UI_PauseShowBarScaleAnim, new BGW_UIEventCollection.Del_UI_Void_Bool(OnPauseShowBarScaleAnim));
			bGW_UIEventCollection.Evt_UI_CheckShowBarScaleAnim = (BGW_UIEventCollection.Del_UI_CheckShowBarScaleAnim)Delegate.Remove(bGW_UIEventCollection.Evt_UI_CheckShowBarScaleAnim, new BGW_UIEventCollection.Del_UI_CheckShowBarScaleAnim(OnCheckShowBarScaleAnim));
		}
	}

	public void SetLowHpTips(float TargetValue, float LimitValue)
	{
		GSProcBar gSProcBar = ProgBar as GSProcBar;
		if (!(gSProcBar != null))
		{
			return;
		}
		gSProcBar.DangerStatePercent = TargetValue;
		if (gSProcBar.SliderFreqConfig.Count == 2)
		{
			FFreqConfig value = gSProcBar.SliderFreqConfig[0];
			value.Percent = TargetValue;
			gSProcBar.SliderFreqConfig[0] = value;
			FFreqConfig fFreqConfig = gSProcBar.SliderFreqConfig[1];
			fFreqConfig.Percent = LimitValue;
			gSProcBar.SliderFreqConfig[1] = value;
			UMaterialInstanceDynamic dynamicMaterial = gSProcBar.GetDynamicMaterial();
			if (dynamicMaterial != null)
			{
				dynamicMaterial.SetScalarParameterValue(B1GlobalFNames.PercentLimit, LimitValue);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_ProgBarCS");
	}

	static BI_ProgBarCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ProgBarCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ProgBarCS));
	}
}
