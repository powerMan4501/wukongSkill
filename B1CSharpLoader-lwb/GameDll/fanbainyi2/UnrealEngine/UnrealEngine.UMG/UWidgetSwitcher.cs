using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.WidgetSwitcher", "UMG", UnrealModuleType.Engine)]
public class UWidgetSwitcher : UPanelWidget
{
	private static bool ActiveWidgetIndex_IsValid;

	private static int ActiveWidgetIndex_Offset;

	private static bool SetActiveWidgetIndex_IsValid;

	private static IntPtr SetActiveWidgetIndex_FunctionAddress;

	private static int SetActiveWidgetIndex_ParamsSize;

	private static bool SetActiveWidgetIndex_Index_IsValid;

	private static FFieldAddress SetActiveWidgetIndex_Index_PropertyAddress;

	private static int SetActiveWidgetIndex_Index_Offset;

	private static bool SetActiveWidget_IsValid;

	private static IntPtr SetActiveWidget_FunctionAddress;

	private static int SetActiveWidget_ParamsSize;

	private static bool SetActiveWidget_Widget_IsValid;

	private static FFieldAddress SetActiveWidget_Widget_PropertyAddress;

	private static int SetActiveWidget_Widget_Offset;

	private static bool GetWidgetAtIndex_IsValid;

	private static IntPtr GetWidgetAtIndex_FunctionAddress;

	private static int GetWidgetAtIndex_ParamsSize;

	private static bool GetWidgetAtIndex_Index_IsValid;

	private static FFieldAddress GetWidgetAtIndex_Index_PropertyAddress;

	private static int GetWidgetAtIndex_Index_Offset;

	private static bool GetWidgetAtIndex_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAtIndex_ReturnValue_PropertyAddress;

	private static int GetWidgetAtIndex_ReturnValue_Offset;

	private static bool GetNumWidgets_IsValid;

	private static IntPtr GetNumWidgets_FunctionAddress;

	private static int GetNumWidgets_ParamsSize;

	private static bool GetNumWidgets_ReturnValue_IsValid;

	private static FFieldAddress GetNumWidgets_ReturnValue_PropertyAddress;

	private static int GetNumWidgets_ReturnValue_Offset;

	private static bool GetActiveWidgetIndex_IsValid;

	private static IntPtr GetActiveWidgetIndex_FunctionAddress;

	private static int GetActiveWidgetIndex_ParamsSize;

	private static bool GetActiveWidgetIndex_ReturnValue_IsValid;

	private static FFieldAddress GetActiveWidgetIndex_ReturnValue_PropertyAddress;

	private static int GetActiveWidgetIndex_ReturnValue_Offset;

	private static bool GetActiveWidget_IsValid;

	private static IntPtr GetActiveWidget_FunctionAddress;

	private static int GetActiveWidget_ParamsSize;

	private static bool GetActiveWidget_ReturnValue_IsValid;

	private static FFieldAddress GetActiveWidget_ReturnValue_PropertyAddress;

	private static int GetActiveWidget_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:ActiveWidgetIndex")]
	public int ActiveWidgetIndex
	{
		get
		{
			CheckDestroyed();
			if (!ActiveWidgetIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetSwitcher:ActiveWidgetIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ActiveWidgetIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActiveWidgetIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.WidgetSwitcher:ActiveWidgetIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ActiveWidgetIndex_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:SetActiveWidgetIndex")]
	public unsafe void SetActiveWidgetIndex(int Index)
	{
		CheckDestroyed();
		if (!SetActiveWidgetIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:SetActiveWidgetIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActiveWidgetIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActiveWidgetIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActiveWidgetIndex_Index_Offset), 0, SetActiveWidgetIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActiveWidgetIndex_FunctionAddress, intPtr, SetActiveWidgetIndex_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:SetActiveWidget")]
	public unsafe void SetActiveWidget(UWidget Widget)
	{
		CheckDestroyed();
		if (!SetActiveWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:SetActiveWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActiveWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActiveWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetActiveWidget_Widget_Offset), 0, SetActiveWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActiveWidget_FunctionAddress, intPtr, SetActiveWidget_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:GetWidgetAtIndex")]
	public unsafe UWidget GetWidgetAtIndex(int Index)
	{
		CheckDestroyed();
		if (!GetWidgetAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:GetWidgetAtIndex");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetWidgetAtIndex_Index_Offset), 0, GetWidgetAtIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWidgetAtIndex_FunctionAddress, intPtr, GetWidgetAtIndex_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetWidgetAtIndex_ReturnValue_Offset), 0, GetWidgetAtIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:GetNumWidgets")]
	public unsafe int GetNumWidgets()
	{
		CheckDestroyed();
		if (!GetNumWidgets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:GetNumWidgets");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumWidgets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumWidgets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumWidgets_FunctionAddress, intPtr, GetNumWidgets_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumWidgets_ReturnValue_Offset), 0, GetNumWidgets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:GetActiveWidgetIndex")]
	public unsafe int GetActiveWidgetIndex()
	{
		CheckDestroyed();
		if (!GetActiveWidgetIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:GetActiveWidgetIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveWidgetIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveWidgetIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActiveWidgetIndex_FunctionAddress, intPtr, GetActiveWidgetIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActiveWidgetIndex_ReturnValue_Offset), 0, GetActiveWidgetIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetSwitcher:GetActiveWidget")]
	public unsafe UWidget GetActiveWidget()
	{
		CheckDestroyed();
		if (!GetActiveWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetSwitcher:GetActiveWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActiveWidget_FunctionAddress, intPtr, GetActiveWidget_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetActiveWidget_ReturnValue_Offset), 0, GetActiveWidget_ReturnValue_PropertyAddress.Address);
	}

	static UWidgetSwitcher()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetSwitcher)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetSwitcher));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.WidgetSwitcher");
		ActiveWidgetIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveWidgetIndex");
		ActiveWidgetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveWidgetIndex", Classes.FIntProperty);
		SetActiveWidgetIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActiveWidgetIndex");
		SetActiveWidgetIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActiveWidgetIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActiveWidgetIndex_Index_PropertyAddress, SetActiveWidgetIndex_FunctionAddress, "Index");
		SetActiveWidgetIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetActiveWidgetIndex_FunctionAddress, "Index");
		SetActiveWidgetIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActiveWidgetIndex_FunctionAddress, "Index", Classes.FIntProperty);
		SetActiveWidgetIndex_IsValid = SetActiveWidgetIndex_FunctionAddress != IntPtr.Zero && SetActiveWidgetIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:SetActiveWidgetIndex", SetActiveWidgetIndex_IsValid);
		SetActiveWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActiveWidget");
		SetActiveWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActiveWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActiveWidget_Widget_PropertyAddress, SetActiveWidget_FunctionAddress, "Widget");
		SetActiveWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetActiveWidget_FunctionAddress, "Widget");
		SetActiveWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActiveWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		SetActiveWidget_IsValid = SetActiveWidget_FunctionAddress != IntPtr.Zero && SetActiveWidget_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:SetActiveWidget", SetActiveWidget_IsValid);
		GetWidgetAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWidgetAtIndex");
		GetWidgetAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAtIndex_Index_PropertyAddress, GetWidgetAtIndex_FunctionAddress, "Index");
		GetWidgetAtIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAtIndex_FunctionAddress, "Index");
		GetWidgetAtIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAtIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAtIndex_ReturnValue_PropertyAddress, GetWidgetAtIndex_FunctionAddress, "ReturnValue");
		GetWidgetAtIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAtIndex_FunctionAddress, "ReturnValue");
		GetWidgetAtIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAtIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWidgetAtIndex_IsValid = GetWidgetAtIndex_FunctionAddress != IntPtr.Zero && GetWidgetAtIndex_Index_IsValid && GetWidgetAtIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:GetWidgetAtIndex", GetWidgetAtIndex_IsValid);
		GetNumWidgets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumWidgets");
		GetNumWidgets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumWidgets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumWidgets_ReturnValue_PropertyAddress, GetNumWidgets_FunctionAddress, "ReturnValue");
		GetNumWidgets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumWidgets_FunctionAddress, "ReturnValue");
		GetNumWidgets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumWidgets_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumWidgets_IsValid = GetNumWidgets_FunctionAddress != IntPtr.Zero && GetNumWidgets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:GetNumWidgets", GetNumWidgets_IsValid);
		GetActiveWidgetIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActiveWidgetIndex");
		GetActiveWidgetIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveWidgetIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveWidgetIndex_ReturnValue_PropertyAddress, GetActiveWidgetIndex_FunctionAddress, "ReturnValue");
		GetActiveWidgetIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveWidgetIndex_FunctionAddress, "ReturnValue");
		GetActiveWidgetIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveWidgetIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActiveWidgetIndex_IsValid = GetActiveWidgetIndex_FunctionAddress != IntPtr.Zero && GetActiveWidgetIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:GetActiveWidgetIndex", GetActiveWidgetIndex_IsValid);
		GetActiveWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActiveWidget");
		GetActiveWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveWidget_ReturnValue_PropertyAddress, GetActiveWidget_FunctionAddress, "ReturnValue");
		GetActiveWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveWidget_FunctionAddress, "ReturnValue");
		GetActiveWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActiveWidget_IsValid = GetActiveWidget_FunctionAddress != IntPtr.Zero && GetActiveWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetSwitcher:GetActiveWidget", GetActiveWidget_IsValid);
	}
}
