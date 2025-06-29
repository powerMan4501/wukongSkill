using System;
using b1.GSMUI.GSWidget;
using b1.GSMUICore.Event;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MBarBase")]
public class BUI_MBarBase : BUI_ProjWidget
{
	protected EBGUBloodBarType BloodBarType;

	private float[] CurShowingLeftTimeData = new float[3];

	private float MaxConWidth;

	protected GSMUIEventBase BarTweenEvent;

	protected USizeBox HpSizeCon;

	protected IProcBar HPBar;

	protected UWidget ShieldCon;

	protected IProcBar ShieldBar;

	protected UCanvasPanelSlot UIFXHurtPointSlot;

	protected UWidgetAnimation AnimBeHit;

	private static bool ShowDurationTime_IsValid;

	private static int ShowDurationTime_Offset;

	private static bool MinScale_IsValid;

	private static int MinScale_Offset;

	private static bool MaxScale_IsValid;

	private static int MaxScale_Offset;

	private static bool XMinScale_IsValid;

	private static int XMinScale_Offset;

	private static bool XMaxScale_IsValid;

	private static int XMaxScale_Offset;

	private static bool YMinScale_IsValid;

	private static int YMinScale_Offset;

	private static bool YMaxScale_IsValid;

	private static int YMaxScale_Offset;

	private static bool ScaleRate_IsValid;

	private static int ScaleRate_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("展示持续时间")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:ShowDurationTime")]
	public float ShowDurationTime
	{
		get
		{
			CheckDestroyed();
			if (!ShowDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:ShowDurationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShowDurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShowDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:ShowDurationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShowDurationTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("整体最大缩放倍率，此补正值，仅作用于根节点下名为'ScaleBoxCon'的ScaleBox类型节点")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:MinScale")]
	public float MinScale
	{
		get
		{
			CheckDestroyed();
			if (!MinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:MinScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:MinScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinScale_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("整体最小缩放倍率，此补正值，仅作用于根节点下名为'ScaleBoxCon'的ScaleBox类型节点")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:MaxScale")]
	public float MaxScale
	{
		get
		{
			CheckDestroyed();
			if (!MaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:MaxScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:MaxScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxScale_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("X轴最大缩放倍率，此补正值，仅作用于根节点下名为'HpSizeCon'的SizeBox类型节点")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:XMinScale")]
	public float XMinScale
	{
		get
		{
			CheckDestroyed();
			if (!XMinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:XMinScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XMinScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XMinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:XMinScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XMinScale_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("X轴最大缩放倍率，此补正值，仅作用于根节点下名为'HpSizeCon'的SizeBox类型节点")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:XMaxScale")]
	public float XMaxScale
	{
		get
		{
			CheckDestroyed();
			if (!XMaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:XMaxScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XMaxScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XMaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:XMaxScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XMaxScale_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[Tooltip("Y轴最大缩放倍率，此补正值，仅作用于根节点下名为'HpSizeCon'的SizeBox类型节点")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:YMinScale")]
	public float YMinScale
	{
		get
		{
			CheckDestroyed();
			if (!YMinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:YMinScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, YMinScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YMinScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:YMinScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, YMinScale_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("Y轴最大缩放倍率，此补正值，仅作用于根节点下名为'HpSizeCon'的SizeBox类型节点")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:YMaxScale")]
	public float YMaxScale
	{
		get
		{
			CheckDestroyed();
			if (!YMaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:YMaxScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, YMaxScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YMaxScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:YMaxScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, YMaxScale_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("缩放系数")]
	[USharpPath("/Script/b1-Managed.BUI_MBarBase:ScaleRate")]
	public float ScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!ScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:ScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MBarBase:ScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScaleRate_Offset), value);
			}
		}
	}

	public override string ToString()
	{
		string text = base.ToString() + "ShowType : ";
		for (int i = 0; i < CurShowingLeftTimeData.Length; i++)
		{
			text += $"{{{(ShowBarType)i},{CurShowingLeftTimeData[i]}}}";
		}
		return text + "\n";
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		ScaleRate = 100f;
		MinScale = 1f;
		MaxScale = 1f;
		XMinScale = 1f;
		XMaxScale = 1f;
		YMinScale = 1f;
		YMaxScale = 1f;
		ShowDurationTime = 8f;
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		HpSizeCon = FindChildWidget("HpSizeCon") as USizeBox;
		HPBar = InitBar("HpBar");
		ShieldCon = FindChildWidget("ShieldCon");
		ShieldBar = InitBar("ShieldBar");
		UCanvasPanel uCanvasPanel = FindChildWidget("HurtPointCon") as UCanvasPanel;
		if (uCanvasPanel != null)
		{
			UCanvasPanelSlot uCanvasPanelSlot = uCanvasPanel.Slot as UCanvasPanelSlot;
			MaxConWidth = uCanvasPanelSlot.GetSize().X;
		}
		UIFXHurtPointSlot = FindChildWidget("UIFXHurtPoint")?.Slot as UCanvasPanelSlot;
		AnimBeHit = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "AnimBeHit");
	}

	protected IProcBar InitBar(string ConName)
	{
		if (UGSE_UMGFuncLib.GetWidgetFromName(this, new FName(ConName)) is IProcBar procBar)
		{
			BindMUITickMgr(procBar);
			procBar.GSOnConstruct();
			procBar.SetValue(1f);
			return procBar;
		}
		return null;
	}

	public virtual void InitBloodBar(EBGUBloodBarType BloodBarType, float HeightOffset)
	{
		this.BloodBarType = BloodBarType;
		if (ProjData is HPProjInfo hPProjInfo)
		{
			hPProjInfo.PosOffset = FVector.UpVector * HeightOffset;
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		UpdateBloodBar(InDeltaTime);
	}

	protected override void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
		base.UpdateScrPosAngle(ScrPos, RectAngle);
		SetRenderTranslation(ScrPos);
	}

	public override bool GetIsUseRound()
	{
		return true;
	}

	public override bool GetIsUseHideRound()
	{
		if (ProjData is HPProjInfo hPProjInfo && hPProjInfo.GetIsLock())
		{
			return false;
		}
		return true;
	}

	public override void Reset()
	{
		if (ProjData is HPProjInfo hPProjInfo && hPProjInfo.BindedUnit != null)
		{
			BGW_UIEventCollection.Get(this).Evt_UI_ClearBindTopBar(hPProjInfo.BindedUnit.ECSEntity);
		}
		base.Reset();
		SetHPBarPercent(1f, IsNow: true);
		SetShieldBarPercent(1f, IsNow: true);
		BarTweenEvent?.Stop();
		SetRenderOpacity(0f);
		CurShowingLeftTimeData = new float[3];
		SetShieldBarActive(IsActive: false);
		SetVisibility(ESlateVisibility.Hidden);
	}

	protected override void OnChangeShowType(EChangeReason Reason, EProjShowType OldValue, EProjShowType NewValue)
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
			if (GetCurShowingLeftTime() <= 0f)
			{
				if (!IsShowing.Value)
				{
					Reset();
				}
				else
				{
					Stop();
				}
			}
			else if (!IsShowing.Value)
			{
				Play();
			}
			break;
		}
	}

	protected override void OnChangeIsShowing(EChangeReason Reason, bool OldValue, bool NewValue)
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

	public virtual void UpdateDistanceZoom(float Scale, FVector2D SizeScale)
	{
		SetRenderScale(Scale * FVector2D.UnitVector);
		HpSizeCon?.SetRenderScale(SizeScale);
	}

	public virtual void SetHPBarPercent(float Percent, bool IsNow = false, bool IsChangeShow = false)
	{
		float realValue = HPBar.GetRealValue();
		HPBar?.SetValue(Percent, IsNow);
		if (!IsNow && Percent < realValue)
		{
			float num = MaxConWidth * Percent;
			UIFXHurtPointSlot?.SetPosition(new FVector2D(num, UIFXHurtPointSlot.GetPosition().Y));
			if (IsAnimationPlaying(AnimBeHit))
			{
				StopAnimation(AnimBeHit);
			}
			PlayAnimation(AnimBeHit);
		}
		if (Percent <= 0f)
		{
			CurShowingLeftTimeData = new float[3];
		}
		else if (IsChangeShow)
		{
			ShowBar(ShowBarType.BeHit);
		}
	}

	public virtual void SetShieldBarPercent(float ShieldPercent, bool IsNow = false, bool IsChangeShow = false)
	{
		ShieldBar?.SetValue(ShieldPercent, IsNow);
		if (IsChangeShow)
		{
			ShowBar(ShowBarType.BeHit);
		}
	}

	public void SetShieldBarActive(bool IsActive)
	{
		ShieldCon?.SetVisibility((!IsActive) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void ShowBar(ShowBarType ShowType)
	{
		SetShowBarTime(ShowType, ShowDurationTime);
		SetVisibility(ESlateVisibility.HitTestInvisible);
	}

	public void HideBar(ShowBarType ShowType)
	{
		SetShowBarTime(ShowType, 0f);
	}

	private void SetShowBarTime(ShowBarType ShowType, float Time)
	{
		CurShowingLeftTimeData[(int)ShowType] = Time;
	}

	private float GetCurShowingLeftTime()
	{
		float num = 0f;
		float[] curShowingLeftTimeData = CurShowingLeftTimeData;
		foreach (float val in curShowingLeftTimeData)
		{
			num = FMath.Max(num, val);
		}
		return num;
	}

	private void UpdateCurShowingLeftTime(float InDeltaTime)
	{
		for (int i = 0; i < CurShowingLeftTimeData.Length; i++)
		{
			CurShowingLeftTimeData[i] -= InDeltaTime;
		}
	}

	private void UpdateBloodBar(float InDeltaTime)
	{
		UpdateCurShowingLeftTime(InDeltaTime);
		if (ShowType.Value != EProjShowType.Always && ShowType.Value != EProjShowType.Hide)
		{
			if (GetCurShowingLeftTime() > 0f)
			{
				Play();
			}
			else
			{
				Stop();
			}
		}
	}

	protected override void PlayFadeOut(bool ForceReset = false)
	{
		if (ForceReset)
		{
			Reset();
			return;
		}
		BarTweenEvent?.Stop();
		BarTweenEvent = AppendGSMUIEvent(new GSMUITweenFade(this, 1f, 0f, 0.2f, 0.2f, EEasingFunc.EaseIn, FadeOutCallBack));
	}

	protected override void PlayFadeIn()
	{
		SetVisibility(ESlateVisibility.HitTestInvisible);
		BarTweenEvent?.Stop();
		BarTweenEvent = AppendGSMUIEvent(new GSMUITweenFade(this, 0f, 1f, 0.2f, 0f, EEasingFunc.EaseIn, FadeInCallBack));
	}

	private void FadeOutCallBack()
	{
		if (ShowType.Value == EProjShowType.Change)
		{
			Reset();
		}
	}

	private void FadeInCallBack()
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_MBarBase");
		ShowDurationTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowDurationTime");
		ShowDurationTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowDurationTime", Classes.FFloatProperty);
		MinScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinScale");
		MinScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinScale", Classes.FFloatProperty);
		MaxScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxScale");
		MaxScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxScale", Classes.FFloatProperty);
		XMinScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "XMinScale");
		XMinScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "XMinScale", Classes.FFloatProperty);
		XMaxScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "XMaxScale");
		XMaxScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "XMaxScale", Classes.FFloatProperty);
		YMinScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "YMinScale");
		YMinScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "YMinScale", Classes.FFloatProperty);
		YMaxScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "YMaxScale");
		YMaxScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "YMaxScale", Classes.FFloatProperty);
		ScaleRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleRate");
		ScaleRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleRate", Classes.FFloatProperty);
	}

	static BUI_MBarBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MBarBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MBarBase));
	}
}
