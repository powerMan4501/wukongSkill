using System;
using b1.GSMUICore.Event;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.GSBackGround")]
public class GSBackGround : BUI_Widget
{
	private UBackgroundBlur BGBlur;

	private UImage BGMask;

	private UButton BGButton;

	private float OrgBlurStrength;

	private static bool IsBlockTouch_IsValid;

	private static int IsBlockTouch_Offset;

	private static FFieldAddress IsBlockTouch_PropertyAddress;

	private static bool IsWithBlur_IsValid;

	private static int IsWithBlur_Offset;

	private static FFieldAddress IsWithBlur_PropertyAddress;

	private static bool IsWithMask_IsValid;

	private static int IsWithMask_Offset;

	private static FFieldAddress IsWithMask_PropertyAddress;

	private static bool MaskColor_IsValid;

	private static int MaskColor_Offset;

	private static bool TweenInTime_IsValid;

	private static int TweenInTime_Offset;

	private static bool TweenFunc_IsValid;

	private static int TweenFunc_Offset;

	private static FFieldAddress TweenFunc_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[Tooltip("背景是否挡住所有点击")]
	[USharpPath("/Script/b1-Managed.GSBackGround:IsBlockTouch")]
	public bool IsBlockTouch
	{
		get
		{
			CheckDestroyed();
			if (!IsBlockTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsBlockTouch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsBlockTouch_Offset), 0, IsBlockTouch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsBlockTouch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsBlockTouch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsBlockTouch_Offset), 0, IsBlockTouch_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty")]
	[Tooltip("是否启用Blur背景板")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSBackGround:IsWithBlur")]
	public bool IsWithBlur
	{
		get
		{
			CheckDestroyed();
			if (!IsWithBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsWithBlur");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsWithBlur_Offset), 0, IsWithBlur_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsWithBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsWithBlur");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsWithBlur_Offset), 0, IsWithBlur_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("是否启用纯色背景板")]
	[Category("GSProperty")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSBackGround:IsWithMask")]
	public bool IsWithMask
	{
		get
		{
			CheckDestroyed();
			if (!IsWithMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsWithMask");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsWithMask_Offset), 0, IsWithMask_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsWithMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:IsWithMask");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsWithMask_Offset), 0, IsWithMask_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("纯色背景板的颜色")]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.GSBackGround:MaskColor")]
	public FLinearColor MaskColor
	{
		get
		{
			CheckDestroyed();
			if (!MaskColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:MaskColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, MaskColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaskColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:MaskColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, MaskColor_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[EditAnywhere]
	[Tooltip("纯色背景板和Blur背景板渐入的时间")]
	[USharpPath("/Script/b1-Managed.GSBackGround:TweenInTime")]
	public float TweenInTime
	{
		get
		{
			CheckDestroyed();
			if (!TweenInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:TweenInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TweenInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TweenInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:TweenInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TweenInTime_Offset), value);
			}
		}
	}

	[Tooltip("纯色背景板和Blur背景板渐入的Easing方式")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSBackGround:TweenFunc")]
	public EEasingFunc TweenFunc
	{
		get
		{
			CheckDestroyed();
			if (!TweenFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:TweenFunc");
				return EEasingFunc.Linear;
			}
			return EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(base.Address, TweenFunc_Offset), 0, TweenFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TweenFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSBackGround:TweenFunc");
			}
			else
			{
				EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(base.Address, TweenFunc_Offset), 0, TweenFunc_PropertyAddress.Address, value);
			}
		}
	}

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		MaskColor = new FLinearColor(0f, 0f, 0f, 0.4f);
		IsBlockTouch = true;
		IsWithBlur = true;
		IsWithMask = false;
		TweenInTime = 0.3f;
		TweenFunc = EEasingFunc.EaseOut;
	}

	private void Init()
	{
		BGMask = FindChildWidget("BGMask") as UImage;
		BGBlur = FindChildWidget("BGBlur") as UBackgroundBlur;
		BGButton = FindChildWidget("BGButton") as UButton;
		OrgBlurStrength = BGBlur.BlurStrength;
	}

	public float GetOrgBlurStrength()
	{
		return OrgBlurStrength;
	}

	protected override void OnUIInitialized()
	{
	}

	protected override void OnUIPreConstruct()
	{
		Init();
		BGMask.SetColorAndOpacity(MaskColor);
		if (!IsWithMask)
		{
			BGMask.SetVisibility(ESlateVisibility.Collapsed);
		}
		if (!IsWithBlur)
		{
			BGBlur.SetVisibility(ESlateVisibility.Collapsed);
		}
		if (!IsBlockTouch)
		{
			BGButton.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
	}

	public float GetCurBlurStrength()
	{
		return BGBlur.BlurStrength;
	}

	public void SetCurBlurStrength(float Strength)
	{
		BGBlur.SetBlurStrength(Strength);
	}

	public float GetCurBGMaskOpactiy()
	{
		return BGMask.GetRenderOpacity();
	}

	public void SetCurBGMaskOpacity(float Opacity)
	{
		BGMask.SetRenderOpacity(Opacity);
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		if (IsWithBlur && TweenInTime > 0f)
		{
			AppendGSMUIEvent(AppendGSMUIEvent(new GSMUITweenFloat(GetCurBlurStrength, SetCurBlurStrength, 0f, OrgBlurStrength, TweenInTime, 0f, TweenFunc)));
		}
		if (IsWithMask && TweenInTime > 0f)
		{
			AppendGSMUIEvent(AppendGSMUIEvent(new GSMUITweenFloat(GetCurBGMaskOpactiy, base.SetRenderOpacity, 0f, 1f, TweenInTime, 0f, TweenFunc)));
		}
	}

	[UFunction]
	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSBackGround");
		NativeReflection.GetPropertyRef(ref IsBlockTouch_PropertyAddress, unrealStruct, "IsBlockTouch");
		IsBlockTouch_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsBlockTouch");
		IsBlockTouch_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsBlockTouch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsWithBlur_PropertyAddress, unrealStruct, "IsWithBlur");
		IsWithBlur_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsWithBlur");
		IsWithBlur_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsWithBlur", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsWithMask_PropertyAddress, unrealStruct, "IsWithMask");
		IsWithMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsWithMask");
		IsWithMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsWithMask", Classes.FBoolProperty);
		MaskColor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaskColor");
		MaskColor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaskColor", Classes.FStructProperty);
		TweenInTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TweenInTime");
		TweenInTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TweenInTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TweenFunc_PropertyAddress, unrealStruct, "TweenFunc");
		TweenFunc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TweenFunc");
		TweenFunc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TweenFunc", Classes.FEnumProperty);
	}

	static GSBackGround()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSBackGround)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSBackGround));
	}
}
