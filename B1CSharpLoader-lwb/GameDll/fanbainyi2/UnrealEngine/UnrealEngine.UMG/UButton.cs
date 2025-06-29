using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Button", "UMG", UnrealModuleType.Engine)]
public class UButton : UContentWidget
{
	private static bool WidgetStyle_IsValid;

	private static int WidgetStyle_Offset;

	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	private static bool BackgroundColor_IsValid;

	private static int BackgroundColor_Offset;

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

	private static bool OnClicked_IsValid;

	private static int OnClicked_Offset;

	private FOnButtonClickedEvent OnClicked_DelegateCached;

	private static bool OnPressed_IsValid;

	private static int OnPressed_Offset;

	private FOnButtonPressedEvent OnPressed_DelegateCached;

	private static bool OnReleased_IsValid;

	private static int OnReleased_Offset;

	private FOnButtonReleasedEvent OnReleased_DelegateCached;

	private static bool OnHovered_IsValid;

	private static int OnHovered_Offset;

	private FOnButtonHoverEvent OnHovered_DelegateCached;

	private static bool OnUnhovered_IsValid;

	private static int OnUnhovered_Offset;

	private FOnButtonHoverEvent OnUnhovered_DelegateCached;

	private static bool SetTouchMethod_IsValid;

	private static IntPtr SetTouchMethod_FunctionAddress;

	private static int SetTouchMethod_ParamsSize;

	private static bool SetTouchMethod_InTouchMethod_IsValid;

	private static FFieldAddress SetTouchMethod_InTouchMethod_PropertyAddress;

	private static int SetTouchMethod_InTouchMethod_Offset;

	private static bool SetStyle_IsValid;

	private static IntPtr SetStyle_FunctionAddress;

	private static int SetStyle_ParamsSize;

	private static bool SetStyle_InStyle_IsValid;

	private static FFieldAddress SetStyle_InStyle_PropertyAddress;

	private static int SetStyle_InStyle_Offset;

	private static bool SetPressMethod_IsValid;

	private static IntPtr SetPressMethod_FunctionAddress;

	private static int SetPressMethod_ParamsSize;

	private static bool SetPressMethod_InPressMethod_IsValid;

	private static FFieldAddress SetPressMethod_InPressMethod_PropertyAddress;

	private static int SetPressMethod_InPressMethod_Offset;

	private static bool SetColorAndOpacity_IsValid;

	private static IntPtr SetColorAndOpacity_FunctionAddress;

	private static int SetColorAndOpacity_ParamsSize;

	private static bool SetColorAndOpacity_InColorAndOpacity_IsValid;

	private static FFieldAddress SetColorAndOpacity_InColorAndOpacity_PropertyAddress;

	private static int SetColorAndOpacity_InColorAndOpacity_Offset;

	private static bool SetClickMethod_IsValid;

	private static IntPtr SetClickMethod_FunctionAddress;

	private static int SetClickMethod_ParamsSize;

	private static bool SetClickMethod_InClickMethod_IsValid;

	private static FFieldAddress SetClickMethod_InClickMethod_PropertyAddress;

	private static int SetClickMethod_InClickMethod_Offset;

	private static bool SetBackgroundColor_IsValid;

	private static IntPtr SetBackgroundColor_FunctionAddress;

	private static int SetBackgroundColor_ParamsSize;

	private static bool SetBackgroundColor_InBackgroundColor_IsValid;

	private static FFieldAddress SetBackgroundColor_InBackgroundColor_PropertyAddress;

	private static int SetBackgroundColor_InBackgroundColor_Offset;

	private static bool IsPressed_IsValid;

	private static IntPtr IsPressed_FunctionAddress;

	private static int IsPressed_ParamsSize;

	private static bool IsPressed_ReturnValue_IsValid;

	private static FFieldAddress IsPressed_ReturnValue_PropertyAddress;

	private static int IsPressed_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMG.Button:WidgetStyle")]
	public FButtonStyle WidgetStyle
	{
		get
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:WidgetStyle");
				return default(FButtonStyle);
			}
			return FButtonStyle.FromNative(IntPtr.Add(base.Address, WidgetStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidgetStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:WidgetStyle");
			}
			else
			{
				FButtonStyle.ToNative(IntPtr.Add(base.Address, WidgetStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Button:ColorAndOpacity")]
	public FLinearColor ColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:ColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:ColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Button:BackgroundColor")]
	public FLinearColor BackgroundColor
	{
		get
		{
			CheckDestroyed();
			if (!BackgroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:BackgroundColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, BackgroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackgroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:BackgroundColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, BackgroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Button:ClickMethod")]
	public EButtonClickMethod ClickMethod
	{
		get
		{
			CheckDestroyed();
			if (!ClickMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:ClickMethod");
				return EButtonClickMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonClickMethod>.FromNative(IntPtr.Add(base.Address, ClickMethod_Offset), 0, ClickMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClickMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:ClickMethod");
			}
			else
			{
				EnumMarshaler<EButtonClickMethod>.ToNative(IntPtr.Add(base.Address, ClickMethod_Offset), 0, ClickMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Button:TouchMethod")]
	public EButtonTouchMethod TouchMethod
	{
		get
		{
			CheckDestroyed();
			if (!TouchMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:TouchMethod");
				return EButtonTouchMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonTouchMethod>.FromNative(IntPtr.Add(base.Address, TouchMethod_Offset), 0, TouchMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TouchMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:TouchMethod");
			}
			else
			{
				EnumMarshaler<EButtonTouchMethod>.ToNative(IntPtr.Add(base.Address, TouchMethod_Offset), 0, TouchMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Button:PressMethod")]
	public EButtonPressMethod PressMethod
	{
		get
		{
			CheckDestroyed();
			if (!PressMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:PressMethod");
				return EButtonPressMethod.DownAndUp;
			}
			return EnumMarshaler<EButtonPressMethod>.FromNative(IntPtr.Add(base.Address, PressMethod_Offset), 0, PressMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PressMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:PressMethod");
			}
			else
			{
				EnumMarshaler<EButtonPressMethod>.ToNative(IntPtr.Add(base.Address, PressMethod_Offset), 0, PressMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Button:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Button:OnClicked")]
	public FOnButtonClickedEvent OnClicked
	{
		get
		{
			CheckDestroyed();
			if (!OnClicked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:OnClicked");
				return new FOnButtonClickedEvent();
			}
			if (OnClicked_DelegateCached == null)
			{
				OnClicked_DelegateCached = new FOnButtonClickedEvent();
				OnClicked_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClicked_Offset));
			}
			return OnClicked_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Button:OnPressed")]
	public FOnButtonPressedEvent OnPressed
	{
		get
		{
			CheckDestroyed();
			if (!OnPressed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:OnPressed");
				return new FOnButtonPressedEvent();
			}
			if (OnPressed_DelegateCached == null)
			{
				OnPressed_DelegateCached = new FOnButtonPressedEvent();
				OnPressed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPressed_Offset));
			}
			return OnPressed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Button:OnReleased")]
	public FOnButtonReleasedEvent OnReleased
	{
		get
		{
			CheckDestroyed();
			if (!OnReleased_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:OnReleased");
				return new FOnButtonReleasedEvent();
			}
			if (OnReleased_DelegateCached == null)
			{
				OnReleased_DelegateCached = new FOnButtonReleasedEvent();
				OnReleased_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnReleased_Offset));
			}
			return OnReleased_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Button:OnHovered")]
	public FOnButtonHoverEvent OnHovered
	{
		get
		{
			CheckDestroyed();
			if (!OnHovered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:OnHovered");
				return new FOnButtonHoverEvent();
			}
			if (OnHovered_DelegateCached == null)
			{
				OnHovered_DelegateCached = new FOnButtonHoverEvent();
				OnHovered_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnHovered_Offset));
			}
			return OnHovered_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.Button:OnUnhovered")]
	public FOnButtonHoverEvent OnUnhovered
	{
		get
		{
			CheckDestroyed();
			if (!OnUnhovered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Button:OnUnhovered");
				return new FOnButtonHoverEvent();
			}
			if (OnUnhovered_DelegateCached == null)
			{
				OnUnhovered_DelegateCached = new FOnButtonHoverEvent();
				OnUnhovered_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnUnhovered_Offset));
			}
			return OnUnhovered_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Button:SetTouchMethod")]
	public unsafe void SetTouchMethod(EButtonTouchMethod InTouchMethod)
	{
		CheckDestroyed();
		if (!SetTouchMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetTouchMethod");
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

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.Button:SetStyle")]
	public unsafe void SetStyle(FButtonStyle InStyle)
	{
		CheckDestroyed();
		if (!SetStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStyle_InStyle_PropertyAddress.Address, intPtr);
		FButtonStyle.ToNative(IntPtr.Add(intPtr, SetStyle_InStyle_Offset), 0, SetStyle_InStyle_PropertyAddress.Address, InStyle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStyle_FunctionAddress, intPtr, SetStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStyle_InStyle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Button:SetPressMethod")]
	public unsafe void SetPressMethod(EButtonPressMethod InPressMethod)
	{
		CheckDestroyed();
		if (!SetPressMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetPressMethod");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Button:SetColorAndOpacity")]
	public unsafe void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorAndOpacity_InColorAndOpacity_Offset), 0, SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorAndOpacity_FunctionAddress, intPtr, SetColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Button:SetClickMethod")]
	public unsafe void SetClickMethod(EButtonClickMethod InClickMethod)
	{
		CheckDestroyed();
		if (!SetClickMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetClickMethod");
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

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Button:SetBackgroundColor")]
	public unsafe void SetBackgroundColor(FLinearColor InBackgroundColor)
	{
		CheckDestroyed();
		if (!SetBackgroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:SetBackgroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBackgroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBackgroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetBackgroundColor_InBackgroundColor_Offset), 0, SetBackgroundColor_InBackgroundColor_PropertyAddress.Address, InBackgroundColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBackgroundColor_FunctionAddress, intPtr, SetBackgroundColor_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Button:IsPressed")]
	public unsafe bool IsPressed()
	{
		CheckDestroyed();
		if (!IsPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Button:IsPressed");
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

	static UButton()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UButton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UButton));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Button");
		WidgetStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetStyle");
		WidgetStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetStyle", Classes.FStructProperty);
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		BackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundColor");
		BackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundColor", Classes.FStructProperty);
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
		OnClicked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnClicked");
		OnClicked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnClicked", Classes.FMulticastDelegateProperty);
		OnPressed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPressed");
		OnPressed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPressed", Classes.FMulticastDelegateProperty);
		OnReleased_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnReleased");
		OnReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnReleased", Classes.FMulticastDelegateProperty);
		OnHovered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnHovered");
		OnHovered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnHovered", Classes.FMulticastDelegateProperty);
		OnUnhovered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnUnhovered");
		OnUnhovered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnUnhovered", Classes.FMulticastDelegateProperty);
		SetTouchMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTouchMethod");
		SetTouchMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTouchMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTouchMethod_InTouchMethod_PropertyAddress, SetTouchMethod_FunctionAddress, "InTouchMethod");
		SetTouchMethod_InTouchMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetTouchMethod_FunctionAddress, "InTouchMethod");
		SetTouchMethod_InTouchMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTouchMethod_FunctionAddress, "InTouchMethod", Classes.FByteProperty);
		SetTouchMethod_IsValid = SetTouchMethod_FunctionAddress != IntPtr.Zero && SetTouchMethod_InTouchMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetTouchMethod", SetTouchMethod_IsValid);
		SetStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStyle");
		SetStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStyle_InStyle_PropertyAddress, SetStyle_FunctionAddress, "InStyle");
		SetStyle_InStyle_Offset = NativeReflectionCached.GetPropertyOffset(SetStyle_FunctionAddress, "InStyle");
		SetStyle_InStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStyle_FunctionAddress, "InStyle", Classes.FStructProperty);
		SetStyle_IsValid = SetStyle_FunctionAddress != IntPtr.Zero && SetStyle_InStyle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetStyle", SetStyle_IsValid);
		SetPressMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPressMethod");
		SetPressMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPressMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPressMethod_InPressMethod_PropertyAddress, SetPressMethod_FunctionAddress, "InPressMethod");
		SetPressMethod_InPressMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetPressMethod_FunctionAddress, "InPressMethod");
		SetPressMethod_InPressMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPressMethod_FunctionAddress, "InPressMethod", Classes.FByteProperty);
		SetPressMethod_IsValid = SetPressMethod_FunctionAddress != IntPtr.Zero && SetPressMethod_InPressMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetPressMethod", SetPressMethod_IsValid);
		SetColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColorAndOpacity");
		SetColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorAndOpacity_InColorAndOpacity_PropertyAddress, SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		SetColorAndOpacity_IsValid = SetColorAndOpacity_FunctionAddress != IntPtr.Zero && SetColorAndOpacity_InColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetColorAndOpacity", SetColorAndOpacity_IsValid);
		SetClickMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetClickMethod");
		SetClickMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClickMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClickMethod_InClickMethod_PropertyAddress, SetClickMethod_FunctionAddress, "InClickMethod");
		SetClickMethod_InClickMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetClickMethod_FunctionAddress, "InClickMethod");
		SetClickMethod_InClickMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClickMethod_FunctionAddress, "InClickMethod", Classes.FByteProperty);
		SetClickMethod_IsValid = SetClickMethod_FunctionAddress != IntPtr.Zero && SetClickMethod_InClickMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetClickMethod", SetClickMethod_IsValid);
		SetBackgroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBackgroundColor");
		SetBackgroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBackgroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBackgroundColor_InBackgroundColor_PropertyAddress, SetBackgroundColor_FunctionAddress, "InBackgroundColor");
		SetBackgroundColor_InBackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(SetBackgroundColor_FunctionAddress, "InBackgroundColor");
		SetBackgroundColor_InBackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBackgroundColor_FunctionAddress, "InBackgroundColor", Classes.FStructProperty);
		SetBackgroundColor_IsValid = SetBackgroundColor_FunctionAddress != IntPtr.Zero && SetBackgroundColor_InBackgroundColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:SetBackgroundColor", SetBackgroundColor_IsValid);
		IsPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPressed");
		IsPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPressed_ReturnValue_PropertyAddress, IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPressed_FunctionAddress, "ReturnValue");
		IsPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPressed_IsValid = IsPressed_FunctionAddress != IntPtr.Zero && IsPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Button:IsPressed", IsPressed_IsValid);
	}
}
