using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.WindowTitleBarArea", "UMG", UnrealModuleType.Engine)]
public class UWindowTitleBarArea : UContentWidget
{
	private static bool WindowButtonsEnabled_IsValid;

	private static FFieldAddress WindowButtonsEnabled_PropertyAddress;

	private static int WindowButtonsEnabled_Offset;

	private static bool DoubleClickTogglesFullscreen_IsValid;

	private static FFieldAddress DoubleClickTogglesFullscreen_PropertyAddress;

	private static int DoubleClickTogglesFullscreen_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetPadding_IsValid;

	private static IntPtr SetPadding_FunctionAddress;

	private static int SetPadding_ParamsSize;

	private static bool SetPadding_InPadding_IsValid;

	private static FFieldAddress SetPadding_InPadding_PropertyAddress;

	private static int SetPadding_InPadding_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WindowTitleBarArea:bWindowButtonsEnabled")]
	public bool WindowButtonsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!WindowButtonsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WindowTitleBarArea:bWindowButtonsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WindowButtonsEnabled_Offset), 0, WindowButtonsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WindowButtonsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WindowTitleBarArea:bWindowButtonsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WindowButtonsEnabled_Offset), 0, WindowButtonsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WindowTitleBarArea:bDoubleClickTogglesFullscreen")]
	public bool DoubleClickTogglesFullscreen
	{
		get
		{
			CheckDestroyed();
			if (!DoubleClickTogglesFullscreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WindowTitleBarArea:bDoubleClickTogglesFullscreen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DoubleClickTogglesFullscreen_Offset), 0, DoubleClickTogglesFullscreen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DoubleClickTogglesFullscreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WindowTitleBarArea:bDoubleClickTogglesFullscreen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DoubleClickTogglesFullscreen_Offset), 0, DoubleClickTogglesFullscreen_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WindowTitleBarArea:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WindowTitleBarArea:SetVerticalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVerticalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVerticalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(intPtr, SetVerticalAlignment_InVerticalAlignment_Offset), 0, SetVerticalAlignment_InVerticalAlignment_PropertyAddress.Address, InVerticalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVerticalAlignment_FunctionAddress, intPtr, SetVerticalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WindowTitleBarArea:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WindowTitleBarArea:SetPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetPadding_InPadding_Offset), 0, SetPadding_InPadding_PropertyAddress.Address, InPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPadding_FunctionAddress, intPtr, SetPadding_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WindowTitleBarArea:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WindowTitleBarArea:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress.Address, InHorizontalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	static UWindowTitleBarArea()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWindowTitleBarArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWindowTitleBarArea));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.WindowTitleBarArea");
		NativeReflectionCached.GetPropertyRef(ref WindowButtonsEnabled_PropertyAddress, intPtr, "bWindowButtonsEnabled");
		WindowButtonsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWindowButtonsEnabled");
		WindowButtonsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWindowButtonsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DoubleClickTogglesFullscreen_PropertyAddress, intPtr, "bDoubleClickTogglesFullscreen");
		DoubleClickTogglesFullscreen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDoubleClickTogglesFullscreen");
		DoubleClickTogglesFullscreen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDoubleClickTogglesFullscreen", Classes.FBoolProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WindowTitleBarArea:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WindowTitleBarArea:SetPadding", SetPadding_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WindowTitleBarArea:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
	}
}
