using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Synthesis.SynthKnob", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynthKnob : UWidget
{
	private static bool StepSize_IsValid;

	private static int StepSize_Offset;

	private static bool MouseSpeed_IsValid;

	private static int MouseSpeed_Offset;

	private static bool MouseFineTuneSpeed_IsValid;

	private static int MouseFineTuneSpeed_Offset;

	private static bool ShowTooltipInfo_IsValid;

	private static FFieldAddress ShowTooltipInfo_PropertyAddress;

	private static int ShowTooltipInfo_Offset;

	private static bool ParameterName_IsValid;

	private static int ParameterName_Offset;

	private FText ParameterName_TextCached;

	private static bool ParameterUnits_IsValid;

	private static int ParameterUnits_Offset;

	private FText ParameterUnits_TextCached;

	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool Locked_IsValid;

	private static FFieldAddress Locked_PropertyAddress;

	private static int Locked_Offset;

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

	private static bool SetLocked_IsValid;

	private static IntPtr SetLocked_FunctionAddress;

	private static int SetLocked_ParamsSize;

	private static bool SetLocked_InValue_IsValid;

	private static FFieldAddress SetLocked_InValue_PropertyAddress;

	private static int SetLocked_InValue_Offset;

	private static bool GetValue_IsValid;

	private static IntPtr GetValue_FunctionAddress;

	private static int GetValue_ParamsSize;

	private static bool GetValue_ReturnValue_IsValid;

	private static FFieldAddress GetValue_ReturnValue_PropertyAddress;

	private static int GetValue_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:StepSize")]
	public float StepSize
	{
		get
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:StepSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StepSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StepSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:StepSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StepSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:MouseSpeed")]
	public float MouseSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MouseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:MouseSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:MouseSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:MouseFineTuneSpeed")]
	public float MouseFineTuneSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MouseFineTuneSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:MouseFineTuneSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseFineTuneSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseFineTuneSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:MouseFineTuneSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseFineTuneSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:ShowTooltipInfo")]
	public bool ShowTooltipInfo
	{
		get
		{
			CheckDestroyed();
			if (!ShowTooltipInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ShowTooltipInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowTooltipInfo_Offset), 0, ShowTooltipInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowTooltipInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ShowTooltipInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowTooltipInfo_Offset), 0, ShowTooltipInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:ParameterName")]
	public FText ParameterName
	{
		get
		{
			CheckDestroyed();
			if (!ParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ParameterName");
				return null;
			}
			if (ParameterName_TextCached == null)
			{
				ParameterName_TextCached = new FText(IntPtr.Add(base.Address, ParameterName_Offset), createReference: false);
			}
			return ParameterName_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ParameterName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ParameterName");
				return;
			}
			if (ParameterName_TextCached == null)
			{
				ParameterName_TextCached = new FText(IntPtr.Add(base.Address, ParameterName_Offset), createReference: false);
			}
			ParameterName_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:ParameterUnits")]
	public FText ParameterUnits
	{
		get
		{
			CheckDestroyed();
			if (!ParameterUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ParameterUnits");
				return null;
			}
			if (ParameterUnits_TextCached == null)
			{
				ParameterUnits_TextCached = new FText(IntPtr.Add(base.Address, ParameterUnits_Offset), createReference: false);
			}
			return ParameterUnits_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ParameterUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:ParameterUnits");
				return;
			}
			if (ParameterUnits_TextCached == null)
			{
				ParameterUnits_TextCached = new FText(IntPtr.Add(base.Address, ParameterUnits_Offset), createReference: false);
			}
			ParameterUnits_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:WidgetStyle")]
	public FSynthKnobStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:WidgetStyle");
				return default(FSynthKnobStyle);
			}
			return FSynthKnobStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:WidgetStyle");
			}
			else
			{
				FSynthKnobStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:Locked")]
	public bool Locked
	{
		get
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:Locked");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Locked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:Locked");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Locked_Offset), 0, Locked_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.SynthKnob:OnMouseCaptureBegin")]
	public FOnMouseCaptureBeginEvent OnMouseCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:OnMouseCaptureBegin");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:OnMouseCaptureEnd")]
	public FOnMouseCaptureEndEvent OnMouseCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:OnMouseCaptureEnd");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:OnControllerCaptureBegin")]
	public FOnControllerCaptureBeginEvent OnControllerCaptureBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:OnControllerCaptureBegin");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:OnControllerCaptureEnd")]
	public FOnControllerCaptureEndEvent OnControllerCaptureEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnControllerCaptureEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:OnControllerCaptureEnd");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:OnValueChanged")]
	public FOnFloatValueChangedEvent OnValueChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnValueChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthKnob:OnValueChanged");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:SetValue")]
	public unsafe void SetValue(float InValue)
	{
		CheckDestroyed();
		if (!SetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthKnob:SetValue");
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
	[UMetaPath("/Script/Synthesis.SynthKnob:SetStepSize")]
	public unsafe void SetStepSize(float InValue)
	{
		CheckDestroyed();
		if (!SetStepSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthKnob:SetStepSize");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthKnob:SetLocked")]
	public unsafe void SetLocked(bool InValue)
	{
		CheckDestroyed();
		if (!SetLocked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthKnob:SetLocked");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SynthKnob:GetValue")]
	public unsafe float GetValue()
	{
		CheckDestroyed();
		if (!GetValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthKnob:GetValue");
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

	static USynthKnob()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthKnob)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthKnob));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SynthKnob");
		StepSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StepSize");
		StepSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StepSize", Classes.FFloatProperty);
		MouseSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MouseSpeed");
		MouseSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MouseSpeed", Classes.FFloatProperty);
		MouseFineTuneSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MouseFineTuneSpeed");
		MouseFineTuneSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MouseFineTuneSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowTooltipInfo_PropertyAddress, intPtr, "ShowTooltipInfo");
		ShowTooltipInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowTooltipInfo");
		ShowTooltipInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowTooltipInfo", Classes.FBoolProperty);
		ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterName");
		ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterName", Classes.FTextProperty);
		ParameterUnits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterUnits");
		ParameterUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterUnits", Classes.FTextProperty);
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Locked_PropertyAddress, intPtr, "Locked");
		Locked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Locked");
		Locked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Locked", Classes.FBoolProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthKnob:SetValue", SetValue_IsValid);
		SetStepSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStepSize");
		SetStepSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStepSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStepSize_InValue_PropertyAddress, SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetStepSize_FunctionAddress, "InValue");
		SetStepSize_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStepSize_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetStepSize_IsValid = SetStepSize_FunctionAddress != IntPtr.Zero && SetStepSize_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthKnob:SetStepSize", SetStepSize_IsValid);
		SetLocked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocked");
		SetLocked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocked_InValue_PropertyAddress, SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocked_FunctionAddress, "InValue");
		SetLocked_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocked_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetLocked_IsValid = SetLocked_FunctionAddress != IntPtr.Zero && SetLocked_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthKnob:SetLocked", SetLocked_IsValid);
		GetValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetValue");
		GetValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValue_ReturnValue_PropertyAddress, GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValue_FunctionAddress, "ReturnValue");
		GetValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetValue_IsValid = GetValue_FunctionAddress != IntPtr.Zero && GetValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthKnob:GetValue", GetValue_IsValid);
	}
}
