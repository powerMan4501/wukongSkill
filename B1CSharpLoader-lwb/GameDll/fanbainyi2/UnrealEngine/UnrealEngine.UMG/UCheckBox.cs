using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.CheckBox", "UMG", UnrealModuleType.Engine)]
public class UCheckBox : UContentWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool ClickMethod_IsValid;

	private static FFieldAddress ClickMethod_PropertyAddress;

	private static int ClickMethod_Offset;

	private static bool TouchMethod_IsValid;

	private static FFieldAddress TouchMethod_PropertyAddress;

	private static int TouchMethod_Offset;

	private static bool PressMethod_IsValid;

	private static FFieldAddress PressMethod_PropertyAddress;

	private static int PressMethod_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool OnCheckStateChanged_IsValid;

	private static int OnCheckStateChanged_Offset;

	private FOnCheckBoxComponentStateChanged OnCheckStateChanged_DelegateCached;

	private static bool SetTouchMethod_IsValid;

	private static IntPtr SetTouchMethod_FunctionAddress;

	private static int SetTouchMethod_ParamsSize;

	private static bool SetTouchMethod_InTouchMethod_IsValid;

	private static FFieldAddress SetTouchMethod_InTouchMethod_PropertyAddress;

	private static int SetTouchMethod_InTouchMethod_Offset;

	private static bool SetPressMethod_IsValid;

	private static IntPtr SetPressMethod_FunctionAddress;

	private static int SetPressMethod_ParamsSize;

	private static bool SetPressMethod_InPressMethod_IsValid;

	private static FFieldAddress SetPressMethod_InPressMethod_PropertyAddress;

	private static int SetPressMethod_InPressMethod_Offset;

	private static bool SetIsChecked_IsValid;

	private static IntPtr SetIsChecked_FunctionAddress;

	private static int SetIsChecked_ParamsSize;

	private static bool SetIsChecked_InIsChecked_IsValid;

	private static FFieldAddress SetIsChecked_InIsChecked_PropertyAddress;

	private static int SetIsChecked_InIsChecked_Offset;

	private static bool SetClickMethod_IsValid;

	private static IntPtr SetClickMethod_FunctionAddress;

	private static int SetClickMethod_ParamsSize;

	private static bool SetClickMethod_InClickMethod_IsValid;

	private static FFieldAddress SetClickMethod_InClickMethod_PropertyAddress;

	private static int SetClickMethod_InClickMethod_Offset;

	private static bool SetCheckedState_IsValid;

	private static IntPtr SetCheckedState_FunctionAddress;

	private static int SetCheckedState_ParamsSize;

	private static bool SetCheckedState_InCheckedState_IsValid;

	private static FFieldAddress SetCheckedState_InCheckedState_PropertyAddress;

	private static int SetCheckedState_InCheckedState_Offset;

	private static bool IsPressed_IsValid;

	private static IntPtr IsPressed_FunctionAddress;

	private static int IsPressed_ParamsSize;

	private static bool IsPressed_ReturnValue_IsValid;

	private static FFieldAddress IsPressed_ReturnValue_PropertyAddress;

	private static int IsPressed_ReturnValue_Offset;

	private static bool IsChecked_IsValid;

	private static IntPtr IsChecked_FunctionAddress;

	private static int IsChecked_ParamsSize;

	private static bool IsChecked_ReturnValue_IsValid;

	private static FFieldAddress IsChecked_ReturnValue_PropertyAddress;

	private static int IsChecked_ReturnValue_Offset;

	private static bool GetCheckedState_IsValid;

	private static IntPtr GetCheckedState_FunctionAddress;

	private static int GetCheckedState_ParamsSize;

	private static bool GetCheckedState_ReturnValue_IsValid;

	private static FFieldAddress GetCheckedState_ReturnValue_PropertyAddress;

	private static int GetCheckedState_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.CheckBox:WidgetStyle")]
	public FCheckBoxStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:WidgetStyle");
				return default(FCheckBoxStyle);
			}
			return FCheckBoxStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:WidgetStyle");
			}
			else
			{
				FCheckBoxStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CheckBox:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.CheckBox:ClickMethod")]
	public EButtonClickMethod ClickMethod
	{
		get
		{
			CheckDestroyed();
			if (!ClickMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:ClickMethod");
				return EButtonClickMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonClickMethod>.FromNative(IntPtr.Add(base.Address, ClickMethod_Offset), 0, ClickMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClickMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:ClickMethod");
			}
			else
			{
				EnumMarshaler<EButtonClickMethod>.ToNative(IntPtr.Add(base.Address, ClickMethod_Offset), 0, ClickMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.CheckBox:TouchMethod")]
	public EButtonTouchMethod TouchMethod
	{
		get
		{
			CheckDestroyed();
			if (!TouchMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:TouchMethod");
				return EButtonTouchMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonTouchMethod>.FromNative(IntPtr.Add(base.Address, TouchMethod_Offset), 0, TouchMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:TouchMethod");
			}
			else
			{
				EnumMarshaler<EButtonTouchMethod>.ToNative(IntPtr.Add(base.Address, TouchMethod_Offset), 0, TouchMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.CheckBox:PressMethod")]
	public EButtonPressMethod PressMethod
	{
		get
		{
			CheckDestroyed();
			if (!PressMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:PressMethod");
				return EButtonPressMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonPressMethod>.FromNative(IntPtr.Add(base.Address, PressMethod_Offset), 0, PressMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PressMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:PressMethod");
			}
			else
			{
				EnumMarshaler<EButtonPressMethod>.ToNative(IntPtr.Add(base.Address, PressMethod_Offset), 0, PressMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CheckBox:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.CheckBox:OnCheckStateChanged")]
	public FOnCheckBoxComponentStateChanged OnCheckStateChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnCheckStateChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CheckBox:OnCheckStateChanged");
				return new FOnCheckBoxComponentStateChanged();
			}
			if (OnCheckStateChanged_DelegateCached == null)
			{
				OnCheckStateChanged_DelegateCached = new FOnCheckBoxComponentStateChanged();
				OnCheckStateChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCheckStateChanged_Offset));
			}
			return OnCheckStateChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CheckBox:SetTouchMethod")]
	public unsafe void SetTouchMethod(EButtonTouchMethod InTouchMethod)
	{
		CheckDestroyed();
		if (!SetTouchMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:SetTouchMethod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTouchMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTouchMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EButtonTouchMethod>.ToNative(IntPtr.Add(intPtr, SetTouchMethod_InTouchMethod_Offset), 0, SetTouchMethod_InTouchMethod_PropertyAddress.Address, InTouchMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTouchMethod_FunctionAddress, intPtr, SetTouchMethod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CheckBox:SetPressMethod")]
	public unsafe void SetPressMethod(EButtonPressMethod InPressMethod)
	{
		CheckDestroyed();
		if (!SetPressMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:SetPressMethod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPressMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPressMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EButtonPressMethod>.ToNative(IntPtr.Add(intPtr, SetPressMethod_InPressMethod_Offset), 0, SetPressMethod_InPressMethod_PropertyAddress.Address, InPressMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPressMethod_FunctionAddress, intPtr, SetPressMethod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CheckBox:SetIsChecked")]
	public unsafe void SetIsChecked(bool InIsChecked)
	{
		CheckDestroyed();
		if (!SetIsChecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:SetIsChecked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsChecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsChecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsChecked_InIsChecked_Offset), 0, SetIsChecked_InIsChecked_PropertyAddress.Address, InIsChecked);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsChecked_FunctionAddress, intPtr, SetIsChecked_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CheckBox:SetClickMethod")]
	public unsafe void SetClickMethod(EButtonClickMethod InClickMethod)
	{
		CheckDestroyed();
		if (!SetClickMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:SetClickMethod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClickMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClickMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EButtonClickMethod>.ToNative(IntPtr.Add(intPtr, SetClickMethod_InClickMethod_Offset), 0, SetClickMethod_InClickMethod_PropertyAddress.Address, InClickMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetClickMethod_FunctionAddress, intPtr, SetClickMethod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CheckBox:SetCheckedState")]
	public unsafe void SetCheckedState(ECheckBoxState InCheckedState)
	{
		CheckDestroyed();
		if (!SetCheckedState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:SetCheckedState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCheckedState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCheckedState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECheckBoxState>.ToNative(IntPtr.Add(intPtr, SetCheckedState_InCheckedState_Offset), 0, SetCheckedState_InCheckedState_PropertyAddress.Address, InCheckedState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCheckedState_FunctionAddress, intPtr, SetCheckedState_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CheckBox:IsPressed")]
	public unsafe bool IsPressed()
	{
		CheckDestroyed();
		if (!IsPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:IsPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPressed_FunctionAddress, intPtr, IsPressed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPressed_ReturnValue_Offset), 0, IsPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CheckBox:IsChecked")]
	public unsafe bool IsChecked()
	{
		CheckDestroyed();
		if (!IsChecked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:IsChecked");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsChecked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsChecked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsChecked_FunctionAddress, intPtr, IsChecked_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsChecked_ReturnValue_Offset), 0, IsChecked_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.CheckBox:GetCheckedState")]
	public unsafe ECheckBoxState GetCheckedState()
	{
		CheckDestroyed();
		if (!GetCheckedState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CheckBox:GetCheckedState");
			return ECheckBoxState.Unchecked;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCheckedState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckedState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCheckedState_FunctionAddress, intPtr, GetCheckedState_ParamsSize);
		return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, GetCheckedState_ReturnValue_Offset), 0, GetCheckedState_ReturnValue_PropertyAddress.Address);
	}

	static UCheckBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCheckBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCheckBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.CheckBox");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ClickMethod_PropertyAddress, intPtr, "ClickMethod");
		ClickMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClickMethod");
		ClickMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClickMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TouchMethod_PropertyAddress, intPtr, "TouchMethod");
		TouchMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TouchMethod");
		TouchMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TouchMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PressMethod_PropertyAddress, intPtr, "PressMethod");
		PressMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressMethod");
		PressMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "IsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsFocusable", Classes.FBoolProperty);
		OnCheckStateChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnCheckStateChanged");
		OnCheckStateChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnCheckStateChanged", Classes.FMulticastDelegateProperty);
		SetTouchMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTouchMethod");
		SetTouchMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTouchMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTouchMethod_InTouchMethod_PropertyAddress, SetTouchMethod_FunctionAddress, "InTouchMethod");
		SetTouchMethod_InTouchMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetTouchMethod_FunctionAddress, "InTouchMethod");
		SetTouchMethod_InTouchMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTouchMethod_FunctionAddress, "InTouchMethod", Classes.FByteProperty);
		SetTouchMethod_IsValid = SetTouchMethod_FunctionAddress != IntPtr.Zero && SetTouchMethod_InTouchMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:SetTouchMethod", SetTouchMethod_IsValid);
		SetPressMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPressMethod");
		SetPressMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPressMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPressMethod_InPressMethod_PropertyAddress, SetPressMethod_FunctionAddress, "InPressMethod");
		SetPressMethod_InPressMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetPressMethod_FunctionAddress, "InPressMethod");
		SetPressMethod_InPressMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPressMethod_FunctionAddress, "InPressMethod", Classes.FByteProperty);
		SetPressMethod_IsValid = SetPressMethod_FunctionAddress != IntPtr.Zero && SetPressMethod_InPressMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:SetPressMethod", SetPressMethod_IsValid);
		SetIsChecked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsChecked");
		SetIsChecked_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsChecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsChecked_InIsChecked_PropertyAddress, SetIsChecked_FunctionAddress, "InIsChecked");
		SetIsChecked_InIsChecked_Offset = NativeReflectionCached.GetPropertyOffset(SetIsChecked_FunctionAddress, "InIsChecked");
		SetIsChecked_InIsChecked_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsChecked_FunctionAddress, "InIsChecked", Classes.FBoolProperty);
		SetIsChecked_IsValid = SetIsChecked_FunctionAddress != IntPtr.Zero && SetIsChecked_InIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:SetIsChecked", SetIsChecked_IsValid);
		SetClickMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetClickMethod");
		SetClickMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClickMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClickMethod_InClickMethod_PropertyAddress, SetClickMethod_FunctionAddress, "InClickMethod");
		SetClickMethod_InClickMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetClickMethod_FunctionAddress, "InClickMethod");
		SetClickMethod_InClickMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClickMethod_FunctionAddress, "InClickMethod", Classes.FByteProperty);
		SetClickMethod_IsValid = SetClickMethod_FunctionAddress != IntPtr.Zero && SetClickMethod_InClickMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:SetClickMethod", SetClickMethod_IsValid);
		SetCheckedState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCheckedState");
		SetCheckedState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCheckedState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCheckedState_InCheckedState_PropertyAddress, SetCheckedState_FunctionAddress, "InCheckedState");
		SetCheckedState_InCheckedState_Offset = NativeReflectionCached.GetPropertyOffset(SetCheckedState_FunctionAddress, "InCheckedState");
		SetCheckedState_InCheckedState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCheckedState_FunctionAddress, "InCheckedState", Classes.FEnumProperty);
		SetCheckedState_IsValid = SetCheckedState_FunctionAddress != IntPtr.Zero && SetCheckedState_InCheckedState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:SetCheckedState", SetCheckedState_IsValid);
		IsPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPressed");
		IsPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPressed_ReturnValue_PropertyAddress, IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPressed_IsValid = IsPressed_FunctionAddress != IntPtr.Zero && IsPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:IsPressed", IsPressed_IsValid);
		IsChecked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsChecked");
		IsChecked_ParamsSize = NativeReflection.GetFunctionParamsSize(IsChecked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsChecked_ReturnValue_PropertyAddress, IsChecked_FunctionAddress, "ReturnValue");
		IsChecked_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsChecked_FunctionAddress, "ReturnValue");
		IsChecked_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChecked_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsChecked_IsValid = IsChecked_FunctionAddress != IntPtr.Zero && IsChecked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:IsChecked", IsChecked_IsValid);
		GetCheckedState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCheckedState");
		GetCheckedState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCheckedState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCheckedState_ReturnValue_PropertyAddress, GetCheckedState_FunctionAddress, "ReturnValue");
		GetCheckedState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckedState_FunctionAddress, "ReturnValue");
		GetCheckedState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckedState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCheckedState_IsValid = GetCheckedState_FunctionAddress != IntPtr.Zero && GetCheckedState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CheckBox:GetCheckedState", GetCheckedState_IsValid);
	}
}
