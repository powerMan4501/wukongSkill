using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Slider", "UMG", UnrealModuleType.Engine)]
public class USlider : UWidget
{
	private static bool MinValue_IsValid;

	private static int MinValue_Offset;

	private static bool MaxValue_IsValid;

	private static int MaxValue_Offset;

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool Orientation_IsValid;

	private static FFieldAddress Orientation_PropertyAddress;

	private static int Orientation_Offset;

	private static bool SliderBarColor_IsValid;

	private static int SliderBarColor_Offset;

	private static bool SliderHandleColor_IsValid;

	private static int SliderHandleColor_Offset;

	private static bool IndentHandle_IsValid;

	private static FFieldAddress IndentHandle_PropertyAddress;

	private static int IndentHandle_Offset;

	private static bool Locked_IsValid;

	private static FFieldAddress Locked_PropertyAddress;

	private static int Locked_Offset;

	private static bool MouseUsesStep_IsValid;

	private static FFieldAddress MouseUsesStep_PropertyAddress;

	private static int MouseUsesStep_Offset;

	private static bool RequiresControllerLock_IsValid;

	private static FFieldAddress RequiresControllerLock_PropertyAddress;

	private static int RequiresControllerLock_Offset;

	private static bool StepSize_IsValid;

	private static int StepSize_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnMouseCaptureBegin_IsValid;

	private static int OnMouseCaptureBegin_Offset;

	private FOnMouseCaptureBeginEvent OnMouseCaptureBegin_DelegateCached;

	private static bool OnMouseCaptureEnd_IsValid;

	private static int OnMouseCaptureEnd_Offset;

	private FOnMouseCaptureEndEvent OnMouseCaptureEnd_DelegateCached;

	private static bool OnControllerCaptureBegin_IsValid;

	private static int OnControllerCaptureBegin_Offset;

	private FOnControllerCaptureBeginEvent OnControllerCaptureBegin_DelegateCached;

	private static bool OnControllerCaptureEnd_IsValid;

	private static int OnControllerCaptureEnd_Offset;

	private FOnControllerCaptureEndEvent OnControllerCaptureEnd_DelegateCached;

	private static bool OnValueChanged_IsValid;

	private static int OnValueChanged_Offset;

	private FOnFloatValueChangedEvent OnValueChanged_DelegateCached;

	private static bool SetValue_IsValid;

	private static IntPtr SetValue_FunctionAddress;

	private static int SetValue_ParamsSize;

	private static bool SetValue_InValue_IsValid;

	private static FFieldAddress SetValue_InValue_PropertyAddress;

	private static int SetValue_InValue_Offset;

	private static bool SetStepSize_IsValid;

	private static IntPtr SetStepSize_FunctionAddress;

	private static int SetStepSize_ParamsSize;

	private static bool SetStepSize_InValue_IsValid;

	private static FFieldAddress SetStepSize_InValue_PropertyAddress;

	private static int SetStepSize_InValue_Offset;

	private static bool SetSliderHandleColor_IsValid;

	private static IntPtr SetSliderHandleColor_FunctionAddress;

	private static int SetSliderHandleColor_ParamsSize;

	private static bool SetSliderHandleColor_InValue_IsValid;

	private static FFieldAddress SetSliderHandleColor_InValue_PropertyAddress;

	private static int SetSliderHandleColor_InValue_Offset;

	private static bool SetSliderBarColor_IsValid;

	private static IntPtr SetSliderBarColor_FunctionAddress;

	private static int SetSliderBarColor_ParamsSize;

	private static bool SetSliderBarColor_InValue_IsValid;

	private static FFieldAddress SetSliderBarColor_InValue_PropertyAddress;

	private static int SetSliderBarColor_InValue_Offset;

	private static bool SetMinValue_IsValid;

	private static IntPtr SetMinValue_FunctionAddress;

	private static int SetMinValue_ParamsSize;

	private static bool SetMinValue_InValue_IsValid;

	private static FFieldAddress SetMinValue_InValue_PropertyAddress;

	private static int SetMinValue_InValue_Offset;

	private static bool SetMaxValue_IsValid;

	private static IntPtr SetMaxValue_FunctionAddress;

	private static int SetMaxValue_ParamsSize;

	private static bool SetMaxValue_InValue_IsValid;

	private static FFieldAddress SetMaxValue_InValue_PropertyAddress;

	private static int SetMaxValue_InValue_Offset;

	private static bool SetLocked_IsValid;

	private static IntPtr SetLocked_FunctionAddress;

	private static int SetLocked_ParamsSize;

	private static bool SetLocked_InValue_IsValid;

	private static FFieldAddress SetLocked_InValue_PropertyAddress;

	private static int SetLocked_InValue_Offset;

	private static bool SetIndentHandle_IsValid;

	private static IntPtr SetIndentHandle_FunctionAddress;

	private static int SetIndentHandle_ParamsSize;

	private static bool SetIndentHandle_InValue_IsValid;

	private static FFieldAddress SetIndentHandle_InValue_PropertyAddress;

	private static int SetIndentHandle_InValue_Offset;

	private static bool GetValue_IsValid;

	private static IntPtr GetValue_FunctionAddress;

	private static int GetValue_ParamsSize;

	private static bool GetValue_ReturnValue_IsValid;

	private static FFieldAddress GetValue_ReturnValue_PropertyAddress;

	private static int GetValue_ReturnValue_Offset;

	private static bool GetNormalizedValue_IsValid;

	private static IntPtr GetNormalizedValue_FunctionAddress;

	private static int GetNormalizedValue_ParamsSize;

	private static bool GetNormalizedValue_ReturnValue_IsValid;

	private static FFieldAddress GetNormalizedValue_ReturnValue_PropertyAddress;

	private static int GetNormalizedValue_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:MinValue")]
	public float MinValue
	{
		get
		{
			CheckDestroyed();
			if (!MinValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MinValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MinValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:MaxValue")]
	public float MaxValue
	{
		get
		{
			CheckDestroyed();
			if (!MaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MaxValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MaxValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.Slider:WidgetStyle")]
	public FSliderStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:WidgetStyle");
				return default(FSliderStyle);
			}
			return FSliderStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:WidgetStyle");
			}
			else
			{
				FSliderStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:Orientation")]
	public EOrientation Orientation
	{
		get
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:Orientation");
				return EOrientation.Orient_Horizontal;
			}
			return EnumMarshaler<EOrientation>.FromNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Orientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:Orientation");
			}
			else
			{
				EnumMarshaler<EOrientation>.ToNative(IntPtr.Add(base.Address, Orientation_Offset), 0, Orientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:SliderBarColor")]
	public FLinearColor SliderBarColor
	{
		get
		{
			CheckDestroyed();
			if (!SliderBarColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:SliderBarColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SliderBarColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderBarColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:SliderBarColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SliderBarColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:SliderHandleColor")]
	public FLinearColor SliderHandleColor
	{
		get
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:SliderHandleColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SliderHandleColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:SliderHandleColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SliderHandleColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Slider:IndentHandle")]
	public bool IndentHandle
	{
		get
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:IndentHandle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:IndentHandle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Slider:Locked")]
	public bool Locked
	{
		get
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:Locked");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:Locked");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Slider:MouseUsesStep")]
	public bool MouseUsesStep
	{
		get
		{
			CheckDestroyed();
			if (!MouseUsesStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MouseUsesStep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MouseUsesStep_Offset), 0, MouseUsesStep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MouseUsesStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:MouseUsesStep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MouseUsesStep_Offset), 0, MouseUsesStep_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Slider:RequiresControllerLock")]
	public bool RequiresControllerLock
	{
		get
		{
			CheckDestroyed();
			if (!RequiresControllerLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:RequiresControllerLock");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RequiresControllerLock_Offset), 0, RequiresControllerLock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RequiresControllerLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:RequiresControllerLock");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RequiresControllerLock_Offset), 0, RequiresControllerLock_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:StepSize")]
	public float StepSize
	{
		get
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:StepSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StepSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:StepSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StepSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Slider:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Slider:OnMouseCaptureBegin")]
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:OnMouseCaptureBegin");
				return new FOnMouseCaptureBeginEvent();
			}
			if (OnMouseCaptureBegin_DelegateCached == null)
			{
				OnMouseCaptureBegin_DelegateCached = new FOnMouseCaptureBeginEvent();
				OnMouseCaptureBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseCaptureBegin_Offset));
			}
			return OnMouseCaptureBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Slider:OnMouseCaptureEnd")]
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:OnMouseCaptureEnd");
				return new FOnMouseCaptureEndEvent();
			}
			if (OnMouseCaptureEnd_DelegateCached == null)
			{
				OnMouseCaptureEnd_DelegateCached = new FOnMouseCaptureEndEvent();
				OnMouseCaptureEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseCaptureEnd_Offset));
			}
			return OnMouseCaptureEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Slider:OnControllerCaptureBegin")]
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:OnControllerCaptureBegin");
				return new FOnControllerCaptureBeginEvent();
			}
			if (OnControllerCaptureBegin_DelegateCached == null)
			{
				OnControllerCaptureBegin_DelegateCached = new FOnControllerCaptureBeginEvent();
				OnControllerCaptureBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnControllerCaptureBegin_Offset));
			}
			return OnControllerCaptureBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Slider:OnControllerCaptureEnd")]
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:OnControllerCaptureEnd");
				return new FOnControllerCaptureEndEvent();
			}
			if (OnControllerCaptureEnd_DelegateCached == null)
			{
				OnControllerCaptureEnd_DelegateCached = new FOnControllerCaptureEndEvent();
				OnControllerCaptureEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnControllerCaptureEnd_Offset));
			}
			return OnControllerCaptureEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Slider:OnValueChanged")]
	public FOnFloatValueChangedEvent OnValueChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Slider:OnValueChanged");
				return new FOnFloatValueChangedEvent();
			}
			if (OnValueChanged_DelegateCached == null)
			{
				OnValueChanged_DelegateCached = new FOnFloatValueChangedEvent();
				OnValueChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueChanged_Offset));
			}
			return OnValueChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetValue")]
	public unsafe void SetValue(float InValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetValue_InValue_Offset), 0, SetValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetStepSize")]
	public unsafe void SetStepSize(float InValue)
	{
		CheckDestroyed();
		if (!SetStepSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetStepSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStepSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStepSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStepSize_InValue_Offset), 0, SetStepSize_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStepSize_FunctionAddress, intPtr, SetStepSize_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Slider:SetSliderHandleColor")]
	public unsafe void SetSliderHandleColor(FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetSliderHandleColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetSliderHandleColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSliderHandleColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSliderHandleColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSliderHandleColor_InValue_Offset), 0, SetSliderHandleColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSliderHandleColor_FunctionAddress, intPtr, SetSliderHandleColor_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Slider:SetSliderBarColor")]
	public unsafe void SetSliderBarColor(FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetSliderBarColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetSliderBarColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSliderBarColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSliderBarColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSliderBarColor_InValue_Offset), 0, SetSliderBarColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSliderBarColor_FunctionAddress, intPtr, SetSliderBarColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetMinValue")]
	public unsafe void SetMinValue(float InValue)
	{
		CheckDestroyed();
		if (!SetMinValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetMinValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinValue_InValue_Offset), 0, SetMinValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinValue_FunctionAddress, intPtr, SetMinValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetMaxValue")]
	public unsafe void SetMaxValue(float InValue)
	{
		CheckDestroyed();
		if (!SetMaxValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetMaxValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaxValue_InValue_Offset), 0, SetMaxValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxValue_FunctionAddress, intPtr, SetMaxValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetLocked")]
	public unsafe void SetLocked(bool InValue)
	{
		CheckDestroyed();
		if (!SetLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetLocked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocked_InValue_Offset), 0, SetLocked_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocked_FunctionAddress, intPtr, SetLocked_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Slider:SetIndentHandle")]
	public unsafe void SetIndentHandle(bool InValue)
	{
		CheckDestroyed();
		if (!SetIndentHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:SetIndentHandle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIndentHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIndentHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIndentHandle_InValue_Offset), 0, SetIndentHandle_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIndentHandle_FunctionAddress, intPtr, SetIndentHandle_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Slider:GetValue")]
	public unsafe float GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:GetValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Slider:GetNormalizedValue")]
	public unsafe float GetNormalizedValue()
	{
		CheckDestroyed();
		if (!GetNormalizedValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Slider:GetNormalizedValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedValue_FunctionAddress, intPtr, GetNormalizedValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNormalizedValue_ReturnValue_Offset), 0, GetNormalizedValue_ReturnValue_PropertyAddress.Address);
	}

	static USlider()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USlider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USlider));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Slider");
		MinValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinValue");
		MinValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinValue", Classes.FFloatProperty);
		MaxValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxValue");
		MaxValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxValue", Classes.FFloatProperty);
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Orientation_PropertyAddress, intPtr, "Orientation");
		Orientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Orientation");
		Orientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Orientation", Classes.FByteProperty);
		SliderBarColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderBarColor");
		SliderBarColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderBarColor", Classes.FStructProperty);
		SliderHandleColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderHandleColor");
		SliderHandleColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderHandleColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IndentHandle_PropertyAddress, intPtr, "IndentHandle");
		IndentHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndentHandle");
		IndentHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndentHandle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Locked_PropertyAddress, intPtr, "Locked");
		Locked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Locked");
		Locked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Locked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MouseUsesStep_PropertyAddress, intPtr, "MouseUsesStep");
		MouseUsesStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MouseUsesStep");
		MouseUsesStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MouseUsesStep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequiresControllerLock_PropertyAddress, intPtr, "RequiresControllerLock");
		RequiresControllerLock_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequiresControllerLock");
		RequiresControllerLock_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequiresControllerLock", Classes.FBoolProperty);
		StepSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StepSize");
		StepSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StepSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "IsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsFocusable", Classes.FBoolProperty);
		OnMouseCaptureBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseCaptureBegin");
		OnMouseCaptureBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseCaptureBegin", Classes.FMulticastDelegateProperty);
		OnMouseCaptureEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseCaptureEnd");
		OnMouseCaptureEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseCaptureEnd", Classes.FMulticastDelegateProperty);
		OnControllerCaptureBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnControllerCaptureBegin");
		OnControllerCaptureBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnControllerCaptureBegin", Classes.FMulticastDelegateProperty);
		OnControllerCaptureEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnControllerCaptureEnd");
		OnControllerCaptureEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnControllerCaptureEnd", Classes.FMulticastDelegateProperty);
		OnValueChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueChanged");
		OnValueChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueChanged", Classes.FMulticastDelegateProperty);
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_InValue_PropertyAddress, SetValue_FunctionAddress, "InValue");
		SetValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "InValue");
		SetValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetValue", SetValue_IsValid);
		SetStepSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStepSize");
		SetStepSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStepSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStepSize_InValue_PropertyAddress, SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStepSize_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetStepSize_IsValid = SetStepSize_FunctionAddress != IntPtr.Zero && SetStepSize_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetStepSize", SetStepSize_IsValid);
		SetSliderHandleColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSliderHandleColor");
		SetSliderHandleColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSliderHandleColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSliderHandleColor_InValue_PropertyAddress, SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSliderHandleColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetSliderHandleColor_IsValid = SetSliderHandleColor_FunctionAddress != IntPtr.Zero && SetSliderHandleColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetSliderHandleColor", SetSliderHandleColor_IsValid);
		SetSliderBarColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSliderBarColor");
		SetSliderBarColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSliderBarColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSliderBarColor_InValue_PropertyAddress, SetSliderBarColor_FunctionAddress, "InValue");
		SetSliderBarColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSliderBarColor_FunctionAddress, "InValue");
		SetSliderBarColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSliderBarColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetSliderBarColor_IsValid = SetSliderBarColor_FunctionAddress != IntPtr.Zero && SetSliderBarColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetSliderBarColor", SetSliderBarColor_IsValid);
		SetMinValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinValue");
		SetMinValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinValue_InValue_PropertyAddress, SetMinValue_FunctionAddress, "InValue");
		SetMinValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMinValue_FunctionAddress, "InValue");
		SetMinValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetMinValue_IsValid = SetMinValue_FunctionAddress != IntPtr.Zero && SetMinValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetMinValue", SetMinValue_IsValid);
		SetMaxValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxValue");
		SetMaxValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxValue_InValue_PropertyAddress, SetMaxValue_FunctionAddress, "InValue");
		SetMaxValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxValue_FunctionAddress, "InValue");
		SetMaxValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetMaxValue_IsValid = SetMaxValue_FunctionAddress != IntPtr.Zero && SetMaxValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetMaxValue", SetMaxValue_IsValid);
		SetLocked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocked");
		SetLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocked_InValue_PropertyAddress, SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocked_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetLocked_IsValid = SetLocked_FunctionAddress != IntPtr.Zero && SetLocked_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetLocked", SetLocked_IsValid);
		SetIndentHandle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIndentHandle");
		SetIndentHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIndentHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIndentHandle_InValue_PropertyAddress, SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIndentHandle_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetIndentHandle_IsValid = SetIndentHandle_FunctionAddress != IntPtr.Zero && SetIndentHandle_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:SetIndentHandle", SetIndentHandle_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:GetValue", GetValue_IsValid);
		GetNormalizedValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedValue");
		GetNormalizedValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedValue_ReturnValue_PropertyAddress, GetNormalizedValue_FunctionAddress, "ReturnValue");
		GetNormalizedValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedValue_FunctionAddress, "ReturnValue");
		GetNormalizedValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNormalizedValue_IsValid = GetNormalizedValue_FunctionAddress != IntPtr.Zero && GetNormalizedValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Slider:GetNormalizedValue", GetNormalizedValue_IsValid);
	}
}
