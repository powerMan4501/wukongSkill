using System;
using System.Collections.Generic;
using b1.GSMUICore.Event;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BarBase")]
public class BUI_BarBase : BUI_Widget
{
	private UCanvasPanel RootCanvas;

	private UOverlay RootCon;

	private UBorder FrameBG;

	private UBorder BarProc;

	private UBorder BarMain;

	private List<UImage> OffsetList = new List<UImage>();

	private int WorkingOffsetIndex;

	private FVector2D OffsetImageSize;

	private GSMUIEventBase MainBarPreTweenEvent;

	private GSMUIEventBase ProcBarPreTweenEvent;

	private FMargin FrameBGDesignPadding;

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

	public float CurValue { get; set; }

	public float PreValue { get; set; }

	public float CurMaxValue { get; set; }

	public float DesignMaxValue { get; set; }

	public float PreMaxValue { get; set; }

	private float CurLength { get; set; }

	private float BarMaxLength { get; set; }

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("DecreaseTween")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:OffsetFadeDuration")]
	public float OffsetFadeDuration
	{
		get
		{
			CheckDestroyed();
			if (!OffsetFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:OffsetFadeDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OffsetFadeDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OffsetFadeDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:OffsetFadeDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OffsetFadeDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDelay")]
	public float ProcBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDuration")]
	public float ProcBarTweenDuration
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDuration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:ProcBarTweenFuncType")]
	public EEasingFunc ProcBarTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, ProcBarTweenFuncType_Offset), 0, ProcBarTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:ProcBarTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, ProcBarTweenFuncType_Offset), 0, ProcBarTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("DecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:MainBarTweenDelay")]
	public float MainBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("DecreaseTween")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:MainBarTweenDuration")]
	public float MainBarTweenDuration
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDuration_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("DecreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:MainBarTweenFuncType")]
	public EEasingFunc MainBarTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MainBarTweenFuncType_Offset), 0, MainBarTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarTweenFuncType");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, MainBarTweenFuncType_Offset), 0, MainBarTweenFuncType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("IncreaseTween")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenFuncType")]
	public EEasingFunc MainBarIncTweenFuncType
	{
		get
		{
			CheckDestroyed();
			if (!MainBarIncTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenFuncType");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, MainBarIncTweenFuncType_Offset), 0, MainBarIncTweenFuncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MainBarIncTweenFuncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenFuncType");
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
	[Category("IncreaseTween")]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:IsIgnoreIncExTweenAnim")]
	public bool IsIgnoreIncExTweenAnim
	{
		get
		{
			CheckDestroyed();
			if (!IsIgnoreIncExTweenAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:IsIgnoreIncExTweenAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsIgnoreIncExTweenAnim_Offset), 0, IsIgnoreIncExTweenAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsIgnoreIncExTweenAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:IsIgnoreIncExTweenAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsIgnoreIncExTweenAnim_Offset), 0, IsIgnoreIncExTweenAnim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("IncreaseTween")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenLinearSpeed")]
	public float MainBarIncTweenLinearSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MainBarIncTweenLinearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenLinearSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarIncTweenLinearSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarIncTweenLinearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarBase:MainBarIncTweenLinearSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarIncTweenLinearSpeed_Offset), value);
			}
		}
	}

	private string GetDebugInfo()
	{
		return $"Cur:{CurValue} CurMax:{CurMaxValue} DesignMax:{DesignMaxValue} CurLength:{CurLength} BarMaxLength:{BarMaxLength}";
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

	private UImage AllocatedOneOffsetImgage()
	{
		UImage result = null;
		if (WorkingOffsetIndex >= 0 && WorkingOffsetIndex < OffsetList.Count)
		{
			result = OffsetList[WorkingOffsetIndex];
		}
		WorkingOffsetIndex = (WorkingOffsetIndex + 1) % OffsetList.Count;
		return result;
	}

	protected override void OnUIInitialized()
	{
		RootCon = FindChildWidget("RootCon") as UOverlay;
		FrameBG = FindChildWidget("FrameBG") as UBorder;
		BarProc = FindChildWidget("BarProc") as UBorder;
		BarMain = FindChildWidget("BarMain") as UBorder;
		for (int i = 0; i <= 10; i++)
		{
			UImage uImage = FindChildWidget($"Offset{i}") as UImage;
			if (uImage != null)
			{
				OffsetImageSize = uImage.Brush.ImageSize;
				uImage.SetRenderOpacity(0f);
				OffsetList.Add(uImage);
				continue;
			}
			break;
		}
	}

	protected override void OnUIPreConstruct()
	{
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UOverlaySlot uOverlaySlot = FrameBG.Slot as UOverlaySlot;
		FrameBGDesignPadding = uOverlaySlot.Padding;
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
	}

	private float CalcBarLength(float Value)
	{
		return MathLib.Clamp(Value / DesignMaxValue * BarMaxLength, 0f, BarMaxLength);
	}

	private void SetOverlaySlotLength(UWidget TargetWidget, float NewLength, float Offset = 0f)
	{
		UOverlaySlot obj = TargetWidget.Slot as UOverlaySlot;
		FMargin padding = obj.Padding;
		padding.Right = BarMaxLength - NewLength + Offset;
		obj.SetPadding(padding);
	}

	private void UpdateBarMaxLength(bool IsForce = false)
	{
		if (PreMaxValue != CurMaxValue || IsForce)
		{
			float newLength = CalcBarLength(CurMaxValue);
			SetOverlaySlotLength(FrameBG, newLength, FrameBGDesignPadding.Right);
			PreMaxValue = CurMaxValue;
		}
	}

	private void HandleBarTween(float NewLength, bool IsIncrease)
	{
		if (MainBarPreTweenEvent != null)
		{
			MainBarPreTweenEvent.Stop();
		}
		if (ProcBarPreTweenEvent != null)
		{
			ProcBarPreTweenEvent.Stop();
		}
		if (IsIncrease)
		{
			if (IsIgnoreIncExTweenAnim)
			{
				float duration = (NewLength - GetWidgetLocalWidth(BarMain)) / BarMaxLength / MainBarIncTweenLinearSpeed;
				MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarLength(BarMain, BarMaxLength, -1f, NewLength, duration, 0f, MainBarIncTweenFuncType));
				SetOverlaySlotLength(BarProc, 0f);
			}
			else
			{
				MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarLength(BarMain, BarMaxLength, -1f, NewLength, 0.1f, 0.1f, MainBarIncTweenFuncType));
				SetOverlaySlotLength(BarProc, NewLength);
			}
			return;
		}
		UImage uImage = AllocatedOneOffsetImgage();
		if (uImage != null)
		{
			OffsetImageSize.X = CurLength - NewLength;
			uImage.SetDesiredSizeOverride(OffsetImageSize);
			UOverlaySlot obj = uImage.Slot as UOverlaySlot;
			FMargin padding = obj.Padding;
			padding.Left = NewLength;
			obj.SetPadding(padding);
			AppendGSMUIEvent(new GSMUITweenFade(uImage, 1f, 0f, 0.3f, 0f, EEasingFunc.EaseIn));
		}
		MainBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarLength(BarMain, BarMaxLength, -1f, NewLength, MainBarTweenDuration, MainBarTweenDelay, MainBarTweenFuncType));
		ProcBarPreTweenEvent = AppendGSMUIEvent(new GSMUITweenBarLength(BarProc, BarMaxLength, -1f, NewLength, ProcBarTweenDuration, ProcBarTweenDelay, ProcBarTweenFuncType));
	}

	private void UpdateBarLength(bool IsForce = false)
	{
		float num = CalcBarLength(CurValue);
		bool isIncrease = CurValue > PreValue;
		if (PreValue != CurValue || IsForce)
		{
			if (IsForce)
			{
				SetOverlaySlotLength(BarMain, num);
				SetOverlaySlotLength(BarProc, num);
			}
			else
			{
				HandleBarTween(num, isIncrease);
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
		UpdateBarLength();
		UpdateBarMaxLength();
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

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_BarBase");
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
	}

	static BUI_BarBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BarBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BarBase));
	}
}
