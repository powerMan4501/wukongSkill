using System;
using System.Collections.Generic;
using b1.GSMUICore.Event;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BarMatBase")]
public class BUI_BarMatBase : BUI_Widget
{
	private UCanvasPanel RootCanvas;

	private UWidget RootCon;

	private UImage BarMainImg;

	private UImage BarProcImg;

	private UImage BarLockImg;

	private UImage BarEmptyImg;

	private UOverlay Debuff_ThunderOverlay;

	private UImage LineMarkImg;

	private UWidgetAnimation LineMarkLoopAnimation;

	private UWidgetAnimation WaveAnimationWhenValueChange;

	private UMaterialInstanceDynamic BarProcMat;

	protected UMaterialInstanceDynamic BarMainMat;

	private List<BarOffset> OffsetList = new List<BarOffset>();

	private int WorkingOffsetIndex;

	private GSMUIEventBase MainBarPreTweenEvent;

	private GSMUIEventBase ProcBarPreTweenEvent;

	private GSMUIEventBase LineMarkPreTweenEvent;

	private GSMUIEventBase RootWidgetFadeEvent;

	private GSMUIEventBase DebuffTweenEvent_Thunder;

	private UOverlay DangerCon;

	private UWidgetAnimation DangerLoopAnimation;

	private bool IsInDangerStat;

	private UWidgetAnimation ChangeFailedAnimation;

	private UWidgetAnimation AnimLoopDebuff_Thunder;

	private bool Debuff_ThunderActive;

	private static bool LineMarkScaleCurve_IsValid;

	private static int LineMarkScaleCurve_Offset;

	private static bool OffsetFadeDuration_IsValid;

	private static int OffsetFadeDuration_Offset;

	private static bool ProcBarTweenDelay_IsValid;

	private static int ProcBarTweenDelay_Offset;

	private static bool ProcBarTweenDuration_IsValid;

	private static int ProcBarTweenDuration_Offset;

	private static bool ProcBarTweenFuncType_IsValid;

	private static int ProcBarTweenFuncType_Offset;

	private static FFieldAddress ProcBarTweenFuncType_PropertyAddress;

	private static bool MainBarTweenDelay_IsValid;

	private static int MainBarTweenDelay_Offset;

	private static bool MainBarTweenDuration_IsValid;

	private static int MainBarTweenDuration_Offset;

	private static bool MainBarTweenFuncType_IsValid;

	private static int MainBarTweenFuncType_Offset;

	private static FFieldAddress MainBarTweenFuncType_PropertyAddress;

	private static bool MainBarIncTweenFuncType_IsValid;

	private static int MainBarIncTweenFuncType_Offset;

	private static FFieldAddress MainBarIncTweenFuncType_PropertyAddress;

	private static bool IsIgnoreIncExTweenAnim_IsValid;

	private static int IsIgnoreIncExTweenAnim_Offset;

	private static FFieldAddress IsIgnoreIncExTweenAnim_PropertyAddress;

	private static bool MainBarIncTweenLinearSpeed_IsValid;

	private static int MainBarIncTweenLinearSpeed_Offset;

	private static bool DebuffTweenDelay_IsValid;

	private static int DebuffTweenDelay_Offset;

	private static bool DebuffTweenDuration_IsValid;

	private static int DebuffTweenDuration_Offset;

	private static bool DebuffTweenFuncType_IsValid;

	private static int DebuffTweenFuncType_Offset;

	private static FFieldAddress DebuffTweenFuncType_PropertyAddress;

	public float CurValue { get; set; }

	public float PreValue { get; set; }

	public float CurMaxValue { get; set; }

	public float DesignMaxValue { get; set; }

	public float PreMaxValue { get; set; }

	private float CurLength { get; set; }

	private float BarMaxLength { get; set; }

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSConfig")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:LineMarkScaleCurve")]
	public UCurveVector LineMarkScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!LineMarkScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:LineMarkScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, LineMarkScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineMarkScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:LineMarkScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, LineMarkScaleCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSDecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:OffsetFadeDuration")]
	public float OffsetFadeDuration
	{
		get
		{
			CheckDestroyed();
			if (!OffsetFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:OffsetFadeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OffsetFadeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:OffsetFadeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OffsetFadeDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSDecreaseTween")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDelay")]
	public float ProcBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset), value);
			}
		}
	}

	[Category("GSDecreaseTween")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDuration")]
	public float ProcBarTweenDuration
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDuration_Offset), value);
			}
		}
	}

	[Category("GSDecreaseTween")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenFuncType")]
	public EEasingFunc ProcBarTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, ProcBarTweenFuncType_Offset), 0, ProcBarTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:ProcBarTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, ProcBarTweenFuncType_Offset), 0, ProcBarTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSDecreaseTween")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDelay")]
	public float MainBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("GSDecreaseTween")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDuration")]
	public float MainBarTweenDuration
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDuration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSDecreaseTween")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenFuncType")]
	public EEasingFunc MainBarTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MainBarTweenFuncType_Offset), 0, MainBarTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MainBarTweenFuncType_Offset), 0, MainBarTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSIncreaseTween")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenFuncType")]
	public EEasingFunc MainBarIncTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!MainBarIncTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MainBarIncTweenFuncType_Offset), 0, MainBarIncTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MainBarIncTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MainBarIncTweenFuncType_Offset), 0, MainBarIncTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSIncreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:IsIgnoreIncExTweenAnim")]
	public bool IsIgnoreIncExTweenAnim
	{
		get
		{
			CheckDestroyed();
			if (!IsIgnoreIncExTweenAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:IsIgnoreIncExTweenAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsIgnoreIncExTweenAnim_Offset), 0, IsIgnoreIncExTweenAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsIgnoreIncExTweenAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:IsIgnoreIncExTweenAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsIgnoreIncExTweenAnim_Offset), 0, IsIgnoreIncExTweenAnim_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("GSIncreaseTween")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenLinearSpeed")]
	public float MainBarIncTweenLinearSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MainBarIncTweenLinearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenLinearSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarIncTweenLinearSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarIncTweenLinearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:MainBarIncTweenLinearSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarIncTweenLinearSpeed_Offset), value);
			}
		}
	}

	[EditDefaultsOnly]
	[Category("GSDebuffConfig")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDelay")]
	public float DebuffTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!DebuffTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebuffTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebuffTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebuffTweenDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("GSDebuffConfig")]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDuration")]
	public float DebuffTweenDuration
	{
		get
		{
			CheckDestroyed();
			if (!DebuffTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebuffTweenDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebuffTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebuffTweenDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[Category("GSDebuffConfig")]
	[USharpPath("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenFuncType")]
	public EEasingFunc DebuffTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!DebuffTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, DebuffTweenFuncType_Offset), 0, DebuffTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebuffTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarMatBase:DebuffTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, DebuffTweenFuncType_Offset), 0, DebuffTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	private string GetDebugInfo()
	{
		return $"Cur:{CurValue} CurMax:{CurMaxValue} DesignMax:{DesignMaxValue} CurLength:{CurLength} BarMaxLength:{BarMaxLength}";
	}

	public void PlayShowIn()
	{
		if (RootWidgetFadeEvent != null)
		{
			RootWidgetFadeEvent.Stop();
		}
		RootWidgetFadeEvent = AppendGSMUIEvent(new GSMUITweenFade(this, -1f, 1f, 0.2f, 0f, EEasingFunc.EaseIn));
	}

	public void PlayShowOut()
	{
		if (RootWidgetFadeEvent != null)
		{
			RootWidgetFadeEvent.Stop();
		}
		RootWidgetFadeEvent = AppendGSMUIEvent(new GSMUITweenFade(this, -1f, 0f, 0.2f, 0f, EEasingFunc.EaseIn));
	}

	private void SetBarLineMark(float NewPercent)
	{
		if (NewPercent < 1f)
		{
			LineMarkImg.SetVisibility(ESlateVisibility.Visible);
		}
		else
		{
			LineMarkImg.SetVisibility(ESlateVisibility.Hidden);
		}
		UCanvasPanelSlot obj = LineMarkImg.Slot as UCanvasPanelSlot;
		float num = MathLib.FFloor(BarMaxLength * NewPercent);
		obj.SetPosition(new FVector2D(num, -7.5));
		float y = LineMarkScaleCurve.GetVectorValue(NewPercent).Y;
		LineMarkImg.SetRenderScale(new FVector2D(1.0, y));
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		OffsetFadeDuration = 0.2f;
		ProcBarTweenDelay = 0.1f;
		ProcBarTweenDuration = 0.2f;
		ProcBarTweenFuncType = EEasingFunc.EaseOut;
		MainBarTweenDelay = 0f;
		MainBarTweenDuration = 0.2f;
		MainBarTweenFuncType = EEasingFunc.EaseOut;
		MainBarIncTweenFuncType = EEasingFunc.Linear;
		IsIgnoreIncExTweenAnim = true;
		MainBarIncTweenLinearSpeed = 0.2f;
	}

	private BarOffset AllocatedOneOffset()
	{
		BarOffset result = null;
		if (WorkingOffsetIndex >= 0 && WorkingOffsetIndex < OffsetList.Count)
		{
			result = OffsetList[WorkingOffsetIndex];
		}
		if (OffsetList.Count > 0)
		{
			WorkingOffsetIndex = (WorkingOffsetIndex + 1) % OffsetList.Count;
		}
		else
		{
			WorkingOffsetIndex = 0;
		}
		return result;
	}

	protected override void OnUIInitialized()
	{
		RootCon = FindChildWidget("RootCon");
		BarMainImg = FindChildWidget("BarMainImg") as UImage;
		BarProcImg = FindChildWidget("BarProcImg") as UImage;
		BarLockImg = FindChildWidget("BarLockImg") as UImage;
		BarEmptyImg = FindChildWidget("BarEmptyImg") as UImage;
		Debuff_ThunderOverlay = FindChildWidget("Debuff_ThunderOverlay") as UOverlay;
		LineMarkLoopAnimation = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "LineMarkLoop");
		LineMarkImg = FindChildWidget("LineMark") as UImage;
		LineMarkImg?.SetVisibility(ESlateVisibility.Hidden);
		WaveAnimationWhenValueChange = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "AnimWave");
		BarMainMat = BarMainImg?.GetDynamicMaterial();
		BarProcMat = BarProcImg?.GetDynamicMaterial();
		BarLockImg?.SetRenderOpacity(0f);
		DangerLoopAnimation = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "InDanger");
		DangerCon = FindChildWidget("DangerCon") as UOverlay;
		DangerCon?.SetRenderOpacity(0f);
		ChangeFailedAnimation = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "AnimChangeFailed");
		AnimLoopDebuff_Thunder = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "AnimLoopDebuff_Thunder");
		for (int i = 0; i <= 10; i++)
		{
			UImage uImage = FindChildWidget($"Offset{i}") as UImage;
			if (uImage == null)
			{
				break;
			}
			uImage.SetRenderOpacity(0f);
			UMaterialInstanceDynamic dynamicMaterial = uImage.GetDynamicMaterial();
			if (!(dynamicMaterial == null))
			{
				OffsetList.Add(new BarOffset
				{
					OffsetImage = uImage,
					OffsetMat = dynamicMaterial
				});
			}
		}
		if (LineMarkLoopAnimation != null && LineMarkImg != null)
		{
			PlayAnimation(LineMarkLoopAnimation, 0f, 0);
		}
	}

	public virtual void GSInit(AActor OwnerActor)
	{
	}

	public void SetBarStatLocked()
	{
		BarProcImg?.SetRenderOpacity(0f);
		BarMainImg?.SetRenderOpacity(0f);
		BarLockImg?.SetRenderOpacity(1f);
	}

	public void SetBarStatUnlocked()
	{
		BarProcImg?.SetRenderOpacity(1f);
		BarMainImg?.SetRenderOpacity(1f);
		BarLockImg?.SetRenderOpacity(0f);
	}

	protected override void OnUIPreConstruct()
	{
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	private void UpdateInDangerStat(bool IsInDanger)
	{
		if (IsInDangerStat == IsInDanger)
		{
			return;
		}
		if (IsInDanger)
		{
			DangerCon?.SetRenderOpacity(1f);
			if (DangerLoopAnimation != null)
			{
				PlayAnimation(DangerLoopAnimation, 0f, 0);
			}
		}
		else
		{
			DangerCon?.SetRenderOpacity(0f);
			if (DangerLoopAnimation != null)
			{
				StopAnimation(DangerLoopAnimation);
			}
		}
		IsInDangerStat = IsInDanger;
	}

	private void TickUpdateInDangerStat(float DeltaTime)
	{
		if (CurMaxValue != 0f)
		{
			if ((double)(CurValue / CurMaxValue) <= 0.15 && CurValue >= 0f)
			{
				UpdateInDangerStat(IsInDanger: true);
			}
			else
			{
				UpdateInDangerStat(IsInDanger: false);
			}
		}
	}

	private void TickUpdateEmptyStat()
	{
		if (CurValue <= 0f)
		{
			BarEmptyImg?.SetRenderOpacity(1f);
		}
		else
		{
			BarEmptyImg?.SetRenderOpacity(0f);
		}
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		if (BarMaxLength == 0f)
		{
			BarMaxLength = GetWidgetLocalWidth(RootCon);
			UpdateBarLength(IsForce: true);
			UpdateBarMaxLength(IsForce: true);
		}
		TickUpdateInDangerStat(InDeltaTime);
		TickUpdateEmptyStat();
	}

	private float CalcBarLength(float Value)
	{
		return MathLib.Clamp(Value / DesignMaxValue * BarMaxLength, 0f, BarMaxLength);
	}

	private void UpdateBarMaxLength(bool IsForce = false)
	{
	}

	private void SetBarPercent(UMaterialInstanceDynamic BarMatInst, float NewPercent)
	{
		BarMatInst?.SetScalarParameterValue(B1Names.GSMaskMatPercent, NewPercent);
	}

	private float GetBatMatCurPercent(UMaterialInstanceDynamic BarMatInst)
	{
		if (BarMatInst.IsNullOrDestroyed())
		{
			return 0f;
		}
		return BarMatInst.GetScalarParameterValue(B1Names.GSMaskMatPercent);
	}

	private void HandleBarTween(float NewLength, float NewPercent, bool IsIncrease)
	{
		if (MainBarPreTweenEvent != null)
		{
			MainBarPreTweenEvent.Stop();
		}
		if (ProcBarPreTweenEvent != null)
		{
			ProcBarPreTweenEvent.Stop();
		}
		if (LineMarkPreTweenEvent != null)
		{
			LineMarkPreTweenEvent.Stop();
		}
		if (BarMaxLength == 0f)
		{
			return;
		}
		if (IsIncrease)
		{
			if (IsIgnoreIncExTweenAnim)
			{
				float batMatCurPercent = GetBatMatCurPercent(BarMainMat);
				float duration = (NewPercent - batMatCurPercent) / MainBarIncTweenLinearSpeed;
				MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatPercent(BarMainMat, -1f, NewPercent, duration, 0f, MainBarIncTweenFuncType));
			}
			else
			{
				float duration2 = 0.2f;
				float delay = 0.1f;
				MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatPercent(BarMainMat, -1f, NewPercent, duration2, delay, MainBarIncTweenFuncType));
				if (LineMarkImg != null && LineMarkScaleCurve != null)
				{
					LineMarkPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatLineMarkScale(LineMarkImg, LineMarkScaleCurve, BarMaxLength, GetBatMatCurPercent(BarMainMat), NewPercent, duration2, delay, MainBarTweenFuncType));
				}
			}
			SetBarPercent(BarProcMat, NewPercent);
		}
		else
		{
			BarOffset barOffset = AllocatedOneOffset();
			if (barOffset != null)
			{
				float value = CalcBarLength(PreValue) / BarMaxLength;
				barOffset.OffsetMat.SetScalarParameterValue(B1Names.GSMaskMatPercentStart, NewPercent);
				barOffset.OffsetMat.SetScalarParameterValue(B1Names.GSMaskMatPercentEnd, value);
				AppendGSMUIEvent(new GSMUITweenFade(barOffset.OffsetImage, 1f, 0f, 0.3f, 0f, EEasingFunc.EaseIn));
			}
			if (LineMarkImg != null && LineMarkScaleCurve != null)
			{
				SetBarLineMark(NewPercent);
			}
			MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatPercent(BarMainMat, -1f, NewPercent, MainBarTweenDuration, MainBarTweenDelay, MainBarTweenFuncType));
			ProcBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarMatPercent(BarProcMat, -1f, NewPercent, ProcBarTweenDuration, ProcBarTweenDelay, ProcBarTweenFuncType));
		}
		if (WaveAnimationWhenValueChange != null)
		{
			PlayAnimation(WaveAnimationWhenValueChange);
		}
	}

	private void UpdateBarLength(bool IsForce = false)
	{
		float num = CalcBarLength(CurValue);
		float newPercent = 1f;
		if (BarMaxLength != 0f)
		{
			newPercent = num / BarMaxLength;
		}
		bool isIncrease = CurValue > PreValue;
		if (PreValue != CurValue || IsForce)
		{
			if (IsForce)
			{
				SetBarPercent(BarMainMat, newPercent);
				SetBarPercent(BarProcMat, newPercent);
			}
			else
			{
				HandleBarTween(num, newPercent, isIncrease);
			}
			CurLength = num;
			PreValue = CurValue;
		}
	}

	public void InitValue(float CurValue, float CurMaxValue, float DesignMaxValue = 0f)
	{
		this.CurValue = CurValue;
		this.CurMaxValue = CurMaxValue;
		if (DesignMaxValue == 0f)
		{
			this.DesignMaxValue = CurMaxValue;
		}
		else
		{
			this.DesignMaxValue = DesignMaxValue;
		}
		UpdateBarLength(IsForce: true);
		UpdateBarMaxLength();
	}

	public void UpdateMaxValue(float CurValue, float NewMaxValue, bool IsForce = false)
	{
		if (IsForce)
		{
			CurMaxValue = NewMaxValue;
			PreMaxValue = NewMaxValue;
			UpdateBarLength(IsForce: true);
		}
	}

	public void OnChangeFailed()
	{
		if (ChangeFailedAnimation != null)
		{
			PlayAnimation(ChangeFailedAnimation);
		}
	}

	public void ChangeValue(float ChangeValue)
	{
		if (ChangeValue < 0f)
		{
			DecreaseValue(0f - ChangeValue);
		}
		else
		{
			IncreaseValue(ChangeValue);
		}
	}

	private void IncreaseValue(float IncreaseValue)
	{
		_ = CurValue;
		CurValue = MathLib.Clamp(CurValue + IncreaseValue, 0f, CurMaxValue);
		UpdateBarLength();
	}

	private void DecreaseValue(float DecreaseValue)
	{
		float x = CurValue - DecreaseValue;
		CurValue = MathLib.Clamp(x, 0f, CurMaxValue);
		UpdateBarLength();
	}

	public void OnEnterDebuff_Thunder()
	{
		if (!(Debuff_ThunderOverlay == null) && !Debuff_ThunderActive)
		{
			Debuff_ThunderActive = true;
			ProcBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenWidgetRenderOpacity(Debuff_ThunderOverlay, -1f, 1f, DebuffTweenDuration, DebuffTweenDelay, DebuffTweenFuncType));
			PlayAnimation(AnimLoopDebuff_Thunder, 0f, 0);
		}
	}

	public void OnExitDebuff_Thunder()
	{
		if (!(Debuff_ThunderOverlay == null) && Debuff_ThunderActive)
		{
			Debuff_ThunderActive = false;
			ProcBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenWidgetRenderOpacity(Debuff_ThunderOverlay, -1f, 0f, DebuffTweenDuration, DebuffTweenDelay, DebuffTweenFuncType));
			StopAnimation(AnimLoopDebuff_Thunder);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_BarMatBase");
		LineMarkScaleCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LineMarkScaleCurve");
		LineMarkScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LineMarkScaleCurve", Classes.FObjectProperty);
		OffsetFadeDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OffsetFadeDuration");
		OffsetFadeDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OffsetFadeDuration", Classes.FFloatProperty);
		ProcBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProcBarTweenDelay");
		ProcBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProcBarTweenDelay", Classes.FFloatProperty);
		ProcBarTweenDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProcBarTweenDuration");
		ProcBarTweenDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProcBarTweenDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ProcBarTweenFuncType_PropertyAddress, unrealStruct, "ProcBarTweenFuncType");
		ProcBarTweenFuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProcBarTweenFuncType");
		ProcBarTweenFuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProcBarTweenFuncType", Classes.FEnumProperty);
		MainBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainBarTweenDelay");
		MainBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainBarTweenDelay", Classes.FFloatProperty);
		MainBarTweenDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainBarTweenDuration");
		MainBarTweenDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainBarTweenDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MainBarTweenFuncType_PropertyAddress, unrealStruct, "MainBarTweenFuncType");
		MainBarTweenFuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainBarTweenFuncType");
		MainBarTweenFuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainBarTweenFuncType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MainBarIncTweenFuncType_PropertyAddress, unrealStruct, "MainBarIncTweenFuncType");
		MainBarIncTweenFuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainBarIncTweenFuncType");
		MainBarIncTweenFuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainBarIncTweenFuncType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsIgnoreIncExTweenAnim_PropertyAddress, unrealStruct, "IsIgnoreIncExTweenAnim");
		IsIgnoreIncExTweenAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsIgnoreIncExTweenAnim");
		IsIgnoreIncExTweenAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsIgnoreIncExTweenAnim", Classes.FBoolProperty);
		MainBarIncTweenLinearSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainBarIncTweenLinearSpeed");
		MainBarIncTweenLinearSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainBarIncTweenLinearSpeed", Classes.FFloatProperty);
		DebuffTweenDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebuffTweenDelay");
		DebuffTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebuffTweenDelay", Classes.FFloatProperty);
		DebuffTweenDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebuffTweenDuration");
		DebuffTweenDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebuffTweenDuration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DebuffTweenFuncType_PropertyAddress, unrealStruct, "DebuffTweenFuncType");
		DebuffTweenFuncType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebuffTweenFuncType");
		DebuffTweenFuncType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebuffTweenFuncType", Classes.FEnumProperty);
	}

	static BUI_BarMatBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BarMatBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BarMatBase));
	}
}
