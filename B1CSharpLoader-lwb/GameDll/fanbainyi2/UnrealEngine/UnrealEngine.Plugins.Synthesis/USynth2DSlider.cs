using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Synthesis.Synth2DSlider", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynth2DSlider : UWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool SliderHandleColor_IsValid;

	private static int SliderHandleColor_Offset;

	private static bool IndentHandle_IsValid;

	private static FFieldAddress IndentHandle_PropertyAddress;

	private static int IndentHandle_Offset;

	private static bool Locked_IsValid;

	private static FFieldAddress Locked_PropertyAddress;

	private static int Locked_Offset;

	private static bool StepSize_IsValid;

	private static int StepSize_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnMouseCaptureBegin_IsValid;

	private static int OnMouseCaptureBegin_Offset;

	private FOnMouseCaptureBeginEventSynth2D OnMouseCaptureBegin_DelegateCached;

	private static bool OnMouseCaptureEnd_IsValid;

	private static int OnMouseCaptureEnd_Offset;

	private FOnMouseCaptureEndEventSynth2D OnMouseCaptureEnd_DelegateCached;

	private static bool OnControllerCaptureBegin_IsValid;

	private static int OnControllerCaptureBegin_Offset;

	private FOnControllerCaptureBeginEventSynth2D OnControllerCaptureBegin_DelegateCached;

	private static bool OnControllerCaptureEnd_IsValid;

	private static int OnControllerCaptureEnd_Offset;

	private FOnControllerCaptureEndEventSynth2D OnControllerCaptureEnd_DelegateCached;

	private static bool OnValueChangedX_IsValid;

	private static int OnValueChangedX_Offset;

	private FOnFloatValueChangedEventSynth2D OnValueChangedX_DelegateCached;

	private static bool OnValueChangedY_IsValid;

	private static int OnValueChangedY_Offset;

	private FOnFloatValueChangedEventSynth2D OnValueChangedY_DelegateCached;

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

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:WidgetStyle")]
	public FSynth2DSliderStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:WidgetStyle");
				return default(FSynth2DSliderStyle);
			}
			return FSynth2DSliderStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:WidgetStyle");
			}
			else
			{
				FSynth2DSliderStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SliderHandleColor")]
	public FLinearColor SliderHandleColor
	{
		get
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:SliderHandleColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SliderHandleColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderHandleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:SliderHandleColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SliderHandleColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:IndentHandle")]
	public bool IndentHandle
	{
		get
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:IndentHandle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IndentHandle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:IndentHandle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IndentHandle_Offset), 0, IndentHandle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:Locked")]
	public bool Locked
	{
		get
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:Locked");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:Locked");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:StepSize")]
	public float StepSize
	{
		get
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:StepSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StepSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:StepSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StepSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnMouseCaptureBegin")]
	public FOnMouseCaptureBeginEventSynth2D OnMouseCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnMouseCaptureBegin");
				return new FOnMouseCaptureBeginEventSynth2D();
			}
			if (OnMouseCaptureBegin_DelegateCached == null)
			{
				OnMouseCaptureBegin_DelegateCached = new FOnMouseCaptureBeginEventSynth2D();
				OnMouseCaptureBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseCaptureBegin_Offset));
			}
			return OnMouseCaptureBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnMouseCaptureEnd")]
	public FOnMouseCaptureEndEventSynth2D OnMouseCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnMouseCaptureEnd");
				return new FOnMouseCaptureEndEventSynth2D();
			}
			if (OnMouseCaptureEnd_DelegateCached == null)
			{
				OnMouseCaptureEnd_DelegateCached = new FOnMouseCaptureEndEventSynth2D();
				OnMouseCaptureEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseCaptureEnd_Offset));
			}
			return OnMouseCaptureEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnControllerCaptureBegin")]
	public FOnControllerCaptureBeginEventSynth2D OnControllerCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnControllerCaptureBegin");
				return new FOnControllerCaptureBeginEventSynth2D();
			}
			if (OnControllerCaptureBegin_DelegateCached == null)
			{
				OnControllerCaptureBegin_DelegateCached = new FOnControllerCaptureBeginEventSynth2D();
				OnControllerCaptureBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnControllerCaptureBegin_Offset));
			}
			return OnControllerCaptureBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnControllerCaptureEnd")]
	public FOnControllerCaptureEndEventSynth2D OnControllerCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnControllerCaptureEnd");
				return new FOnControllerCaptureEndEventSynth2D();
			}
			if (OnControllerCaptureEnd_DelegateCached == null)
			{
				OnControllerCaptureEnd_DelegateCached = new FOnControllerCaptureEndEventSynth2D();
				OnControllerCaptureEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnControllerCaptureEnd_Offset));
			}
			return OnControllerCaptureEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnValueChangedX")]
	public FOnFloatValueChangedEventSynth2D OnValueChangedX
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChangedX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnValueChangedX");
				return new FOnFloatValueChangedEventSynth2D();
			}
			if (OnValueChangedX_DelegateCached == null)
			{
				OnValueChangedX_DelegateCached = new FOnFloatValueChangedEventSynth2D();
				OnValueChangedX_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueChangedX_Offset));
			}
			return OnValueChangedX_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:OnValueChangedY")]
	public FOnFloatValueChangedEventSynth2D OnValueChangedY
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChangedY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.Synth2DSlider:OnValueChangedY");
				return new FOnFloatValueChangedEventSynth2D();
			}
			if (OnValueChangedY_DelegateCached == null)
			{
				OnValueChangedY_DelegateCached = new FOnFloatValueChangedEventSynth2D();
				OnValueChangedY_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnValueChangedY_Offset));
			}
			return OnValueChangedY_DelegateCached;
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SetValue")]
	public unsafe void SetValue(FVector2D InValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:SetValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetValue_InValue_Offset), 0, SetValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetValue_FunctionAddress, intPtr, SetValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SetStepSize")]
	public unsafe void SetStepSize(float InValue)
	{
		CheckDestroyed();
		if (!SetStepSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:SetStepSize");
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
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SetSliderHandleColor")]
	public unsafe void SetSliderHandleColor(FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetSliderHandleColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:SetSliderHandleColor");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SetLocked")]
	public unsafe void SetLocked(bool InValue)
	{
		CheckDestroyed();
		if (!SetLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:SetLocked");
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
	[UMetaPath("/Script/Synthesis.Synth2DSlider:SetIndentHandle")]
	public unsafe void SetIndentHandle(bool InValue)
	{
		CheckDestroyed();
		if (!SetIndentHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:SetIndentHandle");
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

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Synthesis.Synth2DSlider:GetValue")]
	public unsafe FVector2D GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.Synth2DSlider:GetValue");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValue_FunctionAddress, intPtr, GetValue_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetValue_ReturnValue_Offset), 0, GetValue_ReturnValue_PropertyAddress.Address);
	}

	static USynth2DSlider()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynth2DSlider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynth2DSlider));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.Synth2DSlider");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		SliderHandleColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SliderHandleColor");
		SliderHandleColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SliderHandleColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IndentHandle_PropertyAddress, intPtr, "IndentHandle");
		IndentHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndentHandle");
		IndentHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndentHandle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Locked_PropertyAddress, intPtr, "Locked");
		Locked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Locked");
		Locked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Locked", Classes.FBoolProperty);
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
		OnValueChangedX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueChangedX");
		OnValueChangedX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueChangedX", Classes.FMulticastDelegateProperty);
		OnValueChangedY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnValueChangedY");
		OnValueChangedY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnValueChangedY", Classes.FMulticastDelegateProperty);
		SetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetValue");
		SetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetValue_InValue_PropertyAddress, SetValue_FunctionAddress, "InValue");
		SetValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetValue_FunctionAddress, "InValue");
		SetValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetValue_FunctionAddress, "InValue", Classes.FStructProperty);
		SetValue_IsValid = SetValue_FunctionAddress != IntPtr.Zero && SetValue_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:SetValue", SetValue_IsValid);
		SetStepSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStepSize");
		SetStepSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStepSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStepSize_InValue_PropertyAddress, SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStepSize_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetStepSize_IsValid = SetStepSize_FunctionAddress != IntPtr.Zero && SetStepSize_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:SetStepSize", SetStepSize_IsValid);
		SetSliderHandleColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSliderHandleColor");
		SetSliderHandleColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSliderHandleColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSliderHandleColor_InValue_PropertyAddress, SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSliderHandleColor_FunctionAddress, "InValue");
		SetSliderHandleColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSliderHandleColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetSliderHandleColor_IsValid = SetSliderHandleColor_FunctionAddress != IntPtr.Zero && SetSliderHandleColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:SetSliderHandleColor", SetSliderHandleColor_IsValid);
		SetLocked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocked");
		SetLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocked_InValue_PropertyAddress, SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocked_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetLocked_IsValid = SetLocked_FunctionAddress != IntPtr.Zero && SetLocked_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:SetLocked", SetLocked_IsValid);
		SetIndentHandle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIndentHandle");
		SetIndentHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIndentHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIndentHandle_InValue_PropertyAddress, SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIndentHandle_FunctionAddress, "InValue");
		SetIndentHandle_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIndentHandle_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetIndentHandle_IsValid = SetIndentHandle_FunctionAddress != IntPtr.Zero && SetIndentHandle_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:SetIndentHandle", SetIndentHandle_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.Synth2DSlider:GetValue", GetValue_IsValid);
	}
}
