using System;
using b1.EventDelDefine;
using b1.GSMUI.GSWidget;
using b1.UI.GSPage;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ProjWidget")]
public abstract class BUI_ProjWidget : BUI_Widget, IPoolWidget
{
	public Action<BUI_ProjWidget> OnProjWidgetResetEvent;

	private FVector2D CachedScrPos;

	private float CachedRectAngle;

	protected IProjInfo ProjData;

	private bool[] IsAlwaysShow;

	private bool[] IsAlwaysHide;

	protected readonly GSBindProp<EProjShowType> ShowType = new GSBindProp<EProjShowType>();

	protected readonly GSBindProp<bool> IsShowing = new GSBindProp<bool>();

	public override string ToString()
	{
		string arg = "Empty";
		if (ProjData is HPProjInfo hPProjInfo)
		{
			arg = ((!hPProjInfo.BindedUnit.IsNullOrDestroyed()) ? hPProjInfo.BindedUnit.GetFullName() : "Null");
		}
		string text = $"WidgetName : {GetFullName()}\nBindActorName : {arg}\nIsShowing : {IsShowing.Value}";
		text += "\nAlwaysShowStat : ";
		for (int i = 0; i < IsAlwaysShow.Length; i++)
		{
			if (IsAlwaysShow[i])
			{
				text += $"{(AlwaysShowSetting)i}、";
			}
		}
		text += "\nAlwaysHideStat : ";
		for (int j = 0; j < IsAlwaysHide.Length; j++)
		{
			if (IsAlwaysHide[j])
			{
				text += $"{(AlwaysHideSetting)j}、";
			}
		}
		return text + "\n";
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InitShowEvent();
		if (BGW_SettingFuncUtil.GetSuperResolutionsamplingNeedForceVolatile())
		{
			ForceVolatile(bForce: true);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		}
	}

	private void OnSettingValueChanged(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.SuperResolutionSampling)
		{
			ForceVolatile(BGW_SettingFuncUtil.GetSuperResolutionsamplingNeedForceVolatile());
		}
	}

	public virtual void InitSet(IProjInfo InProjData)
	{
		ProjData = InProjData;
	}

	public virtual FVector GetWorldPos()
	{
		if (ProjData != null)
		{
			return ProjData.GetLocation();
		}
		return FVector.ZeroVector;
	}

	public virtual void OnEndPlay()
	{
		Reset();
	}

	public virtual void DestroyPoolWidget()
	{
		RemoveFromParent();
		DestroyUI();
	}

	public virtual void Reset()
	{
		StopAllAnimations();
		IsAlwaysShow = new bool[3];
		IsAlwaysHide = new bool[5];
		ShowType.SetValue(EChangeReason.ManualSet, EProjShowType.Change);
		IsShowing.SetValue(EChangeReason.ManualSet, value: false);
		OnProjWidgetResetEvent?.Invoke(this);
		OnProjWidgetResetEvent = null;
		ProjData = null;
		SetVisibility(ESlateVisibility.Hidden);
	}

	public virtual void SwitchUIStat(EIndicatorType Type)
	{
	}

	public virtual void SwitchUIInRound(bool IsInRound)
	{
	}

	public void OnUpdateScrPosition(FVector2D ScrPos, float RectAngle)
	{
		if (!CachedScrPos.Equals(ScrPos) || !CachedRectAngle.Equals(RectAngle))
		{
			UpdateScrPosAngle(ScrPos, RectAngle);
			CachedScrPos = ScrPos;
			CachedRectAngle = RectAngle;
		}
	}

	protected virtual void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
	}

	public virtual bool GetIsUseRound()
	{
		return false;
	}

	public virtual bool GetIsUseHideRound()
	{
		return false;
	}

	private void InitShowEvent()
	{
		IsAlwaysShow = new bool[3];
		IsAlwaysHide = new bool[5];
		GSBindProp<EProjShowType> showType = ShowType;
		showType.OnValueChanged = (GSBindProp<EProjShowType>.ValueChangedHandler)Delegate.Combine(showType.OnValueChanged, new GSBindProp<EProjShowType>.ValueChangedHandler(OnChangeShowType));
		GSBindProp<bool> isShowing = IsShowing;
		isShowing.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isShowing.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnChangeIsShowing));
	}

	protected virtual void OnChangeShowType(EChangeReason Reason, EProjShowType OldValue, EProjShowType NewValue)
	{
		switch (NewValue)
		{
		case EProjShowType.Always:
			Play();
			break;
		case EProjShowType.Hide:
			Stop();
			break;
		case EProjShowType.Change:
			if (!IsShowing.Value)
			{
				Reset();
			}
			break;
		}
	}

	protected virtual void OnChangeIsShowing(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			PlayFadeIn();
		}
		else
		{
			PlayFadeOut(Reason == EChangeReason.InputSet);
		}
	}

	public virtual void SetAlwaysShowSetting(AlwaysShowSetting ShowSetting, bool Value, float Time = -1f)
	{
		SetBarShowType(ShowSetting, Value);
	}

	public virtual void SetAlwaysHideSetting(AlwaysHideSetting HideSetting, bool Value, float Time = -1f)
	{
		SetBarHideType(HideSetting, Value);
	}

	private void SetBarShowType(AlwaysShowSetting Type, bool Value)
	{
		if (IsAlwaysShow[(int)Type] != Value)
		{
			IsAlwaysShow[(int)Type] = Value;
			UpdateShowType();
		}
	}

	private void SetBarHideType(AlwaysHideSetting Type, bool Value)
	{
		if (IsAlwaysHide[(int)Type] != Value)
		{
			IsAlwaysHide[(int)Type] = Value;
			UpdateShowType();
		}
	}

	private void UpdateShowType()
	{
		if (CheckAlwaysHide())
		{
			ShowType.SetValue(EChangeReason.ManualSet, EProjShowType.Hide);
		}
		else if (CheckAlwaysShow())
		{
			ShowType.SetValue(EChangeReason.ManualSet, EProjShowType.Always);
		}
		else
		{
			ShowType.SetValue(EChangeReason.ManualSet, EProjShowType.Change);
		}
	}

	private bool CheckAlwaysHide()
	{
		bool flag = false;
		for (int i = 0; i < IsAlwaysHide.Length; i++)
		{
			flag |= IsAlwaysHide[i];
		}
		return flag;
	}

	private bool CheckAlwaysShow()
	{
		bool flag = false;
		for (int i = 0; i < IsAlwaysShow.Length; i++)
		{
			flag |= IsAlwaysShow[i];
		}
		return flag;
	}

	protected virtual void PlayFadeOut(bool ForceReset = false)
	{
		SetVisibility(ESlateVisibility.Collapsed);
		if (ForceReset)
		{
			Reset();
		}
	}

	protected virtual void PlayFadeIn()
	{
		SetVisibility(ESlateVisibility.HitTestInvisible);
	}

	public void Play()
	{
		IsShowing.SetValue(EChangeReason.ManualSet, value: true);
	}

	public void Stop(bool ForceReset = false)
	{
		IsShowing.SetValue((!ForceReset) ? EChangeReason.ManualSet : EChangeReason.InputSet, value: false, ForceReset);
	}

	public bool GetIsShowing()
	{
		return IsShowing.Value;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_ProjWidget");
	}

	static BUI_ProjWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ProjWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ProjWidget));
	}
}
