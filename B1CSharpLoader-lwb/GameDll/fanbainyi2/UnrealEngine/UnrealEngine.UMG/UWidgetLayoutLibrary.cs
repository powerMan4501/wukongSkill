using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UMG.WidgetLayoutLibrary", "UMG", UnrealModuleType.Engine)]
public class UWidgetLayoutLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SlotAsWrapBoxSlot_IsValid;

	private static IntPtr SlotAsWrapBoxSlot_FunctionAddress;

	private static int SlotAsWrapBoxSlot_ParamsSize;

	private static bool SlotAsWrapBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsWrapBoxSlot_Widget_PropertyAddress;

	private static int SlotAsWrapBoxSlot_Widget_Offset;

	private static bool SlotAsWrapBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsWrapBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsWrapBoxSlot_ReturnValue_Offset;

	private static bool SlotAsWidgetSwitcherSlot_IsValid;

	private static IntPtr SlotAsWidgetSwitcherSlot_FunctionAddress;

	private static int SlotAsWidgetSwitcherSlot_ParamsSize;

	private static bool SlotAsWidgetSwitcherSlot_Widget_IsValid;

	private static FFieldAddress SlotAsWidgetSwitcherSlot_Widget_PropertyAddress;

	private static int SlotAsWidgetSwitcherSlot_Widget_Offset;

	private static bool SlotAsWidgetSwitcherSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsWidgetSwitcherSlot_ReturnValue_PropertyAddress;

	private static int SlotAsWidgetSwitcherSlot_ReturnValue_Offset;

	private static bool SlotAsVerticalBoxSlot_IsValid;

	private static IntPtr SlotAsVerticalBoxSlot_FunctionAddress;

	private static int SlotAsVerticalBoxSlot_ParamsSize;

	private static bool SlotAsVerticalBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsVerticalBoxSlot_Widget_PropertyAddress;

	private static int SlotAsVerticalBoxSlot_Widget_Offset;

	private static bool SlotAsVerticalBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsVerticalBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsVerticalBoxSlot_ReturnValue_Offset;

	private static bool SlotAsUniformGridSlot_IsValid;

	private static IntPtr SlotAsUniformGridSlot_FunctionAddress;

	private static int SlotAsUniformGridSlot_ParamsSize;

	private static bool SlotAsUniformGridSlot_Widget_IsValid;

	private static FFieldAddress SlotAsUniformGridSlot_Widget_PropertyAddress;

	private static int SlotAsUniformGridSlot_Widget_Offset;

	private static bool SlotAsUniformGridSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsUniformGridSlot_ReturnValue_PropertyAddress;

	private static int SlotAsUniformGridSlot_ReturnValue_Offset;

	private static bool SlotAsSizeBoxSlot_IsValid;

	private static IntPtr SlotAsSizeBoxSlot_FunctionAddress;

	private static int SlotAsSizeBoxSlot_ParamsSize;

	private static bool SlotAsSizeBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsSizeBoxSlot_Widget_PropertyAddress;

	private static int SlotAsSizeBoxSlot_Widget_Offset;

	private static bool SlotAsSizeBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsSizeBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsSizeBoxSlot_ReturnValue_Offset;

	private static bool SlotAsScrollBoxSlot_IsValid;

	private static IntPtr SlotAsScrollBoxSlot_FunctionAddress;

	private static int SlotAsScrollBoxSlot_ParamsSize;

	private static bool SlotAsScrollBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsScrollBoxSlot_Widget_PropertyAddress;

	private static int SlotAsScrollBoxSlot_Widget_Offset;

	private static bool SlotAsScrollBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsScrollBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsScrollBoxSlot_ReturnValue_Offset;

	private static bool SlotAsScaleBoxSlot_IsValid;

	private static IntPtr SlotAsScaleBoxSlot_FunctionAddress;

	private static int SlotAsScaleBoxSlot_ParamsSize;

	private static bool SlotAsScaleBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsScaleBoxSlot_Widget_PropertyAddress;

	private static int SlotAsScaleBoxSlot_Widget_Offset;

	private static bool SlotAsScaleBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsScaleBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsScaleBoxSlot_ReturnValue_Offset;

	private static bool SlotAsSafeBoxSlot_IsValid;

	private static IntPtr SlotAsSafeBoxSlot_FunctionAddress;

	private static int SlotAsSafeBoxSlot_ParamsSize;

	private static bool SlotAsSafeBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsSafeBoxSlot_Widget_PropertyAddress;

	private static int SlotAsSafeBoxSlot_Widget_Offset;

	private static bool SlotAsSafeBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsSafeBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsSafeBoxSlot_ReturnValue_Offset;

	private static bool SlotAsOverlaySlot_IsValid;

	private static IntPtr SlotAsOverlaySlot_FunctionAddress;

	private static int SlotAsOverlaySlot_ParamsSize;

	private static bool SlotAsOverlaySlot_Widget_IsValid;

	private static FFieldAddress SlotAsOverlaySlot_Widget_PropertyAddress;

	private static int SlotAsOverlaySlot_Widget_Offset;

	private static bool SlotAsOverlaySlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsOverlaySlot_ReturnValue_PropertyAddress;

	private static int SlotAsOverlaySlot_ReturnValue_Offset;

	private static bool SlotAsHorizontalBoxSlot_IsValid;

	private static IntPtr SlotAsHorizontalBoxSlot_FunctionAddress;

	private static int SlotAsHorizontalBoxSlot_ParamsSize;

	private static bool SlotAsHorizontalBoxSlot_Widget_IsValid;

	private static FFieldAddress SlotAsHorizontalBoxSlot_Widget_PropertyAddress;

	private static int SlotAsHorizontalBoxSlot_Widget_Offset;

	private static bool SlotAsHorizontalBoxSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsHorizontalBoxSlot_ReturnValue_PropertyAddress;

	private static int SlotAsHorizontalBoxSlot_ReturnValue_Offset;

	private static bool SlotAsGridSlot_IsValid;

	private static IntPtr SlotAsGridSlot_FunctionAddress;

	private static int SlotAsGridSlot_ParamsSize;

	private static bool SlotAsGridSlot_Widget_IsValid;

	private static FFieldAddress SlotAsGridSlot_Widget_PropertyAddress;

	private static int SlotAsGridSlot_Widget_Offset;

	private static bool SlotAsGridSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsGridSlot_ReturnValue_PropertyAddress;

	private static int SlotAsGridSlot_ReturnValue_Offset;

	private static bool SlotAsCanvasSlot_IsValid;

	private static IntPtr SlotAsCanvasSlot_FunctionAddress;

	private static int SlotAsCanvasSlot_ParamsSize;

	private static bool SlotAsCanvasSlot_Widget_IsValid;

	private static FFieldAddress SlotAsCanvasSlot_Widget_PropertyAddress;

	private static int SlotAsCanvasSlot_Widget_Offset;

	private static bool SlotAsCanvasSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsCanvasSlot_ReturnValue_PropertyAddress;

	private static int SlotAsCanvasSlot_ReturnValue_Offset;

	private static bool SlotAsBorderSlot_IsValid;

	private static IntPtr SlotAsBorderSlot_FunctionAddress;

	private static int SlotAsBorderSlot_ParamsSize;

	private static bool SlotAsBorderSlot_Widget_IsValid;

	private static FFieldAddress SlotAsBorderSlot_Widget_PropertyAddress;

	private static int SlotAsBorderSlot_Widget_Offset;

	private static bool SlotAsBorderSlot_ReturnValue_IsValid;

	private static FFieldAddress SlotAsBorderSlot_ReturnValue_PropertyAddress;

	private static int SlotAsBorderSlot_ReturnValue_Offset;

	private static bool RemoveAllWidgets_IsValid;

	private static IntPtr RemoveAllWidgets_FunctionAddress;

	private static int RemoveAllWidgets_ParamsSize;

	private static bool RemoveAllWidgets_WorldContextObject_IsValid;

	private static FFieldAddress RemoveAllWidgets_WorldContextObject_PropertyAddress;

	private static int RemoveAllWidgets_WorldContextObject_Offset;

	private static bool ProjectWorldLocationToWidgetPosition_IsValid;

	private static IntPtr ProjectWorldLocationToWidgetPosition_FunctionAddress;

	private static int ProjectWorldLocationToWidgetPosition_ParamsSize;

	private static bool ProjectWorldLocationToWidgetPosition_PlayerController_IsValid;

	private static FFieldAddress ProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress;

	private static int ProjectWorldLocationToWidgetPosition_PlayerController_Offset;

	private static bool ProjectWorldLocationToWidgetPosition_WorldLocation_IsValid;

	private static FFieldAddress ProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress;

	private static int ProjectWorldLocationToWidgetPosition_WorldLocation_Offset;

	private static bool ProjectWorldLocationToWidgetPosition_ScreenPosition_IsValid;

	private static FFieldAddress ProjectWorldLocationToWidgetPosition_ScreenPosition_PropertyAddress;

	private static int ProjectWorldLocationToWidgetPosition_ScreenPosition_Offset;

	private static bool ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_IsValid;

	private static FFieldAddress ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_PropertyAddress;

	private static int ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_Offset;

	private static bool ProjectWorldLocationToWidgetPosition_ReturnValue_IsValid;

	private static FFieldAddress ProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress;

	private static int ProjectWorldLocationToWidgetPosition_ReturnValue_Offset;

	private static bool GetViewportWidgetGeometry_IsValid;

	private static IntPtr GetViewportWidgetGeometry_FunctionAddress;

	private static int GetViewportWidgetGeometry_ParamsSize;

	private static bool GetViewportWidgetGeometry_WorldContextObject_IsValid;

	private static FFieldAddress GetViewportWidgetGeometry_WorldContextObject_PropertyAddress;

	private static int GetViewportWidgetGeometry_WorldContextObject_Offset;

	private static bool GetViewportWidgetGeometry_ReturnValue_IsValid;

	private static FFieldAddress GetViewportWidgetGeometry_ReturnValue_PropertyAddress;

	private static int GetViewportWidgetGeometry_ReturnValue_Offset;

	private static bool GetViewportSize_IsValid;

	private static IntPtr GetViewportSize_FunctionAddress;

	private static int GetViewportSize_ParamsSize;

	private static bool GetViewportSize_WorldContextObject_IsValid;

	private static FFieldAddress GetViewportSize_WorldContextObject_PropertyAddress;

	private static int GetViewportSize_WorldContextObject_Offset;

	private static bool GetViewportSize_ReturnValue_IsValid;

	private static FFieldAddress GetViewportSize_ReturnValue_PropertyAddress;

	private static int GetViewportSize_ReturnValue_Offset;

	private static bool GetViewportScale_IsValid;

	private static IntPtr GetViewportScale_FunctionAddress;

	private static int GetViewportScale_ParamsSize;

	private static bool GetViewportScale_WorldContextObject_IsValid;

	private static FFieldAddress GetViewportScale_WorldContextObject_PropertyAddress;

	private static int GetViewportScale_WorldContextObject_Offset;

	private static bool GetViewportScale_ReturnValue_IsValid;

	private static FFieldAddress GetViewportScale_ReturnValue_PropertyAddress;

	private static int GetViewportScale_ReturnValue_Offset;

	private static bool GetPlayerScreenWidgetGeometry_IsValid;

	private static IntPtr GetPlayerScreenWidgetGeometry_FunctionAddress;

	private static int GetPlayerScreenWidgetGeometry_ParamsSize;

	private static bool GetPlayerScreenWidgetGeometry_PlayerController_IsValid;

	private static FFieldAddress GetPlayerScreenWidgetGeometry_PlayerController_PropertyAddress;

	private static int GetPlayerScreenWidgetGeometry_PlayerController_Offset;

	private static bool GetPlayerScreenWidgetGeometry_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerScreenWidgetGeometry_ReturnValue_PropertyAddress;

	private static int GetPlayerScreenWidgetGeometry_ReturnValue_Offset;

	private static bool GetMousePositionScaledByDPI_IsValid;

	private static IntPtr GetMousePositionScaledByDPI_FunctionAddress;

	private static int GetMousePositionScaledByDPI_ParamsSize;

	private static bool GetMousePositionScaledByDPI_Player_IsValid;

	private static FFieldAddress GetMousePositionScaledByDPI_Player_PropertyAddress;

	private static int GetMousePositionScaledByDPI_Player_Offset;

	private static bool GetMousePositionScaledByDPI_LocationX_IsValid;

	private static FFieldAddress GetMousePositionScaledByDPI_LocationX_PropertyAddress;

	private static int GetMousePositionScaledByDPI_LocationX_Offset;

	private static bool GetMousePositionScaledByDPI_LocationY_IsValid;

	private static FFieldAddress GetMousePositionScaledByDPI_LocationY_PropertyAddress;

	private static int GetMousePositionScaledByDPI_LocationY_Offset;

	private static bool GetMousePositionScaledByDPI_ReturnValue_IsValid;

	private static FFieldAddress GetMousePositionScaledByDPI_ReturnValue_PropertyAddress;

	private static int GetMousePositionScaledByDPI_ReturnValue_Offset;

	private static bool GetMousePositionOnViewport_IsValid;

	private static IntPtr GetMousePositionOnViewport_FunctionAddress;

	private static int GetMousePositionOnViewport_ParamsSize;

	private static bool GetMousePositionOnViewport_WorldContextObject_IsValid;

	private static FFieldAddress GetMousePositionOnViewport_WorldContextObject_PropertyAddress;

	private static int GetMousePositionOnViewport_WorldContextObject_Offset;

	private static bool GetMousePositionOnViewport_ReturnValue_IsValid;

	private static FFieldAddress GetMousePositionOnViewport_ReturnValue_PropertyAddress;

	private static int GetMousePositionOnViewport_ReturnValue_Offset;

	private static bool GetMousePositionOnPlatform_IsValid;

	private static IntPtr GetMousePositionOnPlatform_FunctionAddress;

	private static int GetMousePositionOnPlatform_ParamsSize;

	private static bool GetMousePositionOnPlatform_ReturnValue_IsValid;

	private static FFieldAddress GetMousePositionOnPlatform_ReturnValue_PropertyAddress;

	private static int GetMousePositionOnPlatform_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsWrapBoxSlot")]
	public unsafe static UWrapBoxSlot SlotAsWrapBoxSlot(UWidget Widget)
	{
		if (!SlotAsWrapBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsWrapBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsWrapBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsWrapBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsWrapBoxSlot_Widget_Offset), 0, SlotAsWrapBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsWrapBoxSlot_FunctionAddress, intPtr, SlotAsWrapBoxSlot_ParamsSize);
		return UObjectMarshaler<UWrapBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsWrapBoxSlot_ReturnValue_Offset), 0, SlotAsWrapBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsWidgetSwitcherSlot")]
	public unsafe static UWidgetSwitcherSlot SlotAsWidgetSwitcherSlot(UWidget Widget)
	{
		if (!SlotAsWidgetSwitcherSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsWidgetSwitcherSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsWidgetSwitcherSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsWidgetSwitcherSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsWidgetSwitcherSlot_Widget_Offset), 0, SlotAsWidgetSwitcherSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsWidgetSwitcherSlot_FunctionAddress, intPtr, SlotAsWidgetSwitcherSlot_ParamsSize);
		return UObjectMarshaler<UWidgetSwitcherSlot>.FromNative(IntPtr.Add(intPtr, SlotAsWidgetSwitcherSlot_ReturnValue_Offset), 0, SlotAsWidgetSwitcherSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsVerticalBoxSlot")]
	public unsafe static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget)
	{
		if (!SlotAsVerticalBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsVerticalBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsVerticalBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsVerticalBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsVerticalBoxSlot_Widget_Offset), 0, SlotAsVerticalBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsVerticalBoxSlot_FunctionAddress, intPtr, SlotAsVerticalBoxSlot_ParamsSize);
		return UObjectMarshaler<UVerticalBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsVerticalBoxSlot_ReturnValue_Offset), 0, SlotAsVerticalBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsUniformGridSlot")]
	public unsafe static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget)
	{
		if (!SlotAsUniformGridSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsUniformGridSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsUniformGridSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsUniformGridSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsUniformGridSlot_Widget_Offset), 0, SlotAsUniformGridSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsUniformGridSlot_FunctionAddress, intPtr, SlotAsUniformGridSlot_ParamsSize);
		return UObjectMarshaler<UUniformGridSlot>.FromNative(IntPtr.Add(intPtr, SlotAsUniformGridSlot_ReturnValue_Offset), 0, SlotAsUniformGridSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsSizeBoxSlot")]
	public unsafe static USizeBoxSlot SlotAsSizeBoxSlot(UWidget Widget)
	{
		if (!SlotAsSizeBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsSizeBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsSizeBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsSizeBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsSizeBoxSlot_Widget_Offset), 0, SlotAsSizeBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsSizeBoxSlot_FunctionAddress, intPtr, SlotAsSizeBoxSlot_ParamsSize);
		return UObjectMarshaler<USizeBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsSizeBoxSlot_ReturnValue_Offset), 0, SlotAsSizeBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsScrollBoxSlot")]
	public unsafe static UScrollBoxSlot SlotAsScrollBoxSlot(UWidget Widget)
	{
		if (!SlotAsScrollBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsScrollBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsScrollBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsScrollBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsScrollBoxSlot_Widget_Offset), 0, SlotAsScrollBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsScrollBoxSlot_FunctionAddress, intPtr, SlotAsScrollBoxSlot_ParamsSize);
		return UObjectMarshaler<UScrollBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsScrollBoxSlot_ReturnValue_Offset), 0, SlotAsScrollBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsScaleBoxSlot")]
	public unsafe static UScaleBoxSlot SlotAsScaleBoxSlot(UWidget Widget)
	{
		if (!SlotAsScaleBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsScaleBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsScaleBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsScaleBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsScaleBoxSlot_Widget_Offset), 0, SlotAsScaleBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsScaleBoxSlot_FunctionAddress, intPtr, SlotAsScaleBoxSlot_ParamsSize);
		return UObjectMarshaler<UScaleBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsScaleBoxSlot_ReturnValue_Offset), 0, SlotAsScaleBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsSafeBoxSlot")]
	public unsafe static USafeZoneSlot SlotAsSafeBoxSlot(UWidget Widget)
	{
		if (!SlotAsSafeBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsSafeBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsSafeBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsSafeBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsSafeBoxSlot_Widget_Offset), 0, SlotAsSafeBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsSafeBoxSlot_FunctionAddress, intPtr, SlotAsSafeBoxSlot_ParamsSize);
		return UObjectMarshaler<USafeZoneSlot>.FromNative(IntPtr.Add(intPtr, SlotAsSafeBoxSlot_ReturnValue_Offset), 0, SlotAsSafeBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsOverlaySlot")]
	public unsafe static UOverlaySlot SlotAsOverlaySlot(UWidget Widget)
	{
		if (!SlotAsOverlaySlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsOverlaySlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsOverlaySlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsOverlaySlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsOverlaySlot_Widget_Offset), 0, SlotAsOverlaySlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsOverlaySlot_FunctionAddress, intPtr, SlotAsOverlaySlot_ParamsSize);
		return UObjectMarshaler<UOverlaySlot>.FromNative(IntPtr.Add(intPtr, SlotAsOverlaySlot_ReturnValue_Offset), 0, SlotAsOverlaySlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsHorizontalBoxSlot")]
	public unsafe static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget)
	{
		if (!SlotAsHorizontalBoxSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsHorizontalBoxSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsHorizontalBoxSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsHorizontalBoxSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsHorizontalBoxSlot_Widget_Offset), 0, SlotAsHorizontalBoxSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsHorizontalBoxSlot_FunctionAddress, intPtr, SlotAsHorizontalBoxSlot_ParamsSize);
		return UObjectMarshaler<UHorizontalBoxSlot>.FromNative(IntPtr.Add(intPtr, SlotAsHorizontalBoxSlot_ReturnValue_Offset), 0, SlotAsHorizontalBoxSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsGridSlot")]
	public unsafe static UGridSlot SlotAsGridSlot(UWidget Widget)
	{
		if (!SlotAsGridSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsGridSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsGridSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsGridSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsGridSlot_Widget_Offset), 0, SlotAsGridSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsGridSlot_FunctionAddress, intPtr, SlotAsGridSlot_ParamsSize);
		return UObjectMarshaler<UGridSlot>.FromNative(IntPtr.Add(intPtr, SlotAsGridSlot_ReturnValue_Offset), 0, SlotAsGridSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsCanvasSlot")]
	public unsafe static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
	{
		if (!SlotAsCanvasSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsCanvasSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsCanvasSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsCanvasSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsCanvasSlot_Widget_Offset), 0, SlotAsCanvasSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsCanvasSlot_FunctionAddress, intPtr, SlotAsCanvasSlot_ParamsSize);
		return UObjectMarshaler<UCanvasPanelSlot>.FromNative(IntPtr.Add(intPtr, SlotAsCanvasSlot_ReturnValue_Offset), 0, SlotAsCanvasSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:SlotAsBorderSlot")]
	public unsafe static UBorderSlot SlotAsBorderSlot(UWidget Widget)
	{
		if (!SlotAsBorderSlot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:SlotAsBorderSlot");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlotAsBorderSlot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlotAsBorderSlot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SlotAsBorderSlot_Widget_Offset), 0, SlotAsBorderSlot_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlotAsBorderSlot_FunctionAddress, intPtr, SlotAsBorderSlot_ParamsSize);
		return UObjectMarshaler<UBorderSlot>.FromNative(IntPtr.Add(intPtr, SlotAsBorderSlot_ReturnValue_Offset), 0, SlotAsBorderSlot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:RemoveAllWidgets")]
	public unsafe static void RemoveAllWidgets(UObject WorldContextObject)
	{
		if (!RemoveAllWidgets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:RemoveAllWidgets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllWidgets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllWidgets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveAllWidgets_WorldContextObject_Offset), 0, RemoveAllWidgets_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllWidgets_FunctionAddress, intPtr, RemoveAllWidgets_ParamsSize);
	}

	[UFunction(Flags = 348267529u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:ProjectWorldLocationToWidgetPosition")]
	public unsafe static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController, FVector WorldLocation, out FVector2D ScreenPosition, bool bPlayerViewportRelative)
	{
		if (!ProjectWorldLocationToWidgetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:ProjectWorldLocationToWidgetPosition");
			ScreenPosition = default(FVector2D);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectWorldLocationToWidgetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectWorldLocationToWidgetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ProjectWorldLocationToWidgetPosition_PlayerController_Offset), 0, ProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProjectWorldLocationToWidgetPosition_WorldLocation_Offset), 0, ProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress.Address, WorldLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_Offset), 0, ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_PropertyAddress.Address, bPlayerViewportRelative);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, intPtr, ProjectWorldLocationToWidgetPosition_ParamsSize);
		ScreenPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ProjectWorldLocationToWidgetPosition_ScreenPosition_Offset), 0, ProjectWorldLocationToWidgetPosition_ScreenPosition_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProjectWorldLocationToWidgetPosition_ReturnValue_Offset), 0, ProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetViewportWidgetGeometry")]
	public unsafe static FGeometry GetViewportWidgetGeometry(UObject WorldContextObject)
	{
		if (!GetViewportWidgetGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetViewportWidgetGeometry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportWidgetGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportWidgetGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewportWidgetGeometry_WorldContextObject_Offset), 0, GetViewportWidgetGeometry_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportWidgetGeometry_FunctionAddress, intPtr, GetViewportWidgetGeometry_ParamsSize);
		return StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(intPtr, GetViewportWidgetGeometry_ReturnValue_Offset), 0, GetViewportWidgetGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073225u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetViewportSize")]
	public unsafe static FVector2D GetViewportSize(UObject WorldContextObject)
	{
		if (!GetViewportSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetViewportSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewportSize_WorldContextObject_Offset), 0, GetViewportSize_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportSize_FunctionAddress, intPtr, GetViewportSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewportSize_ReturnValue_Offset), 0, GetViewportSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684617u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetViewportScale")]
	public unsafe static float GetViewportScale(UObject WorldContextObject)
	{
		if (!GetViewportScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetViewportScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewportScale_WorldContextObject_Offset), 0, GetViewportScale_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportScale_FunctionAddress, intPtr, GetViewportScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewportScale_ReturnValue_Offset), 0, GetViewportScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetPlayerScreenWidgetGeometry")]
	public unsafe static FGeometry GetPlayerScreenWidgetGeometry(APlayerController PlayerController)
	{
		if (!GetPlayerScreenWidgetGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetPlayerScreenWidgetGeometry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerScreenWidgetGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerScreenWidgetGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerScreenWidgetGeometry_PlayerController_Offset), 0, GetPlayerScreenWidgetGeometry_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerScreenWidgetGeometry_FunctionAddress, intPtr, GetPlayerScreenWidgetGeometry_ParamsSize);
		return StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(intPtr, GetPlayerScreenWidgetGeometry_ReturnValue_Offset), 0, GetPlayerScreenWidgetGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878921u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetMousePositionScaledByDPI")]
	public unsafe static bool GetMousePositionScaledByDPI(APlayerController Player, out float LocationX, out float LocationY)
	{
		if (!GetMousePositionScaledByDPI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetMousePositionScaledByDPI");
			LocationX = 0f;
			LocationY = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMousePositionScaledByDPI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMousePositionScaledByDPI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetMousePositionScaledByDPI_Player_Offset), 0, GetMousePositionScaledByDPI_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMousePositionScaledByDPI_FunctionAddress, intPtr, GetMousePositionScaledByDPI_ParamsSize);
		LocationX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMousePositionScaledByDPI_LocationX_Offset), 0, GetMousePositionScaledByDPI_LocationX_PropertyAddress.Address);
		LocationY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMousePositionScaledByDPI_LocationY_Offset), 0, GetMousePositionScaledByDPI_LocationY_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMousePositionScaledByDPI_ReturnValue_Offset), 0, GetMousePositionScaledByDPI_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnViewport")]
	public unsafe static FVector2D GetMousePositionOnViewport(UObject WorldContextObject)
	{
		if (!GetMousePositionOnViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnViewport");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMousePositionOnViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMousePositionOnViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMousePositionOnViewport_WorldContextObject_Offset), 0, GetMousePositionOnViewport_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMousePositionOnViewport_FunctionAddress, intPtr, GetMousePositionOnViewport_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetMousePositionOnViewport_ReturnValue_Offset), 0, GetMousePositionOnViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnPlatform")]
	public unsafe static FVector2D GetMousePositionOnPlatform()
	{
		if (!GetMousePositionOnPlatform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnPlatform");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMousePositionOnPlatform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMousePositionOnPlatform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMousePositionOnPlatform_FunctionAddress, intPtr, GetMousePositionOnPlatform_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetMousePositionOnPlatform_ReturnValue_Offset), 0, GetMousePositionOnPlatform_ReturnValue_PropertyAddress.Address);
	}

	static UWidgetLayoutLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetLayoutLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetLayoutLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UMG.WidgetLayoutLibrary");
		SlotAsWrapBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsWrapBoxSlot");
		SlotAsWrapBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsWrapBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsWrapBoxSlot_Widget_PropertyAddress, SlotAsWrapBoxSlot_FunctionAddress, "Widget");
		SlotAsWrapBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsWrapBoxSlot_FunctionAddress, "Widget");
		SlotAsWrapBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsWrapBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsWrapBoxSlot_ReturnValue_PropertyAddress, SlotAsWrapBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsWrapBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsWrapBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsWrapBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsWrapBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsWrapBoxSlot_IsValid = SlotAsWrapBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsWrapBoxSlot_Widget_IsValid && SlotAsWrapBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsWrapBoxSlot", SlotAsWrapBoxSlot_IsValid);
		SlotAsWidgetSwitcherSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsWidgetSwitcherSlot");
		SlotAsWidgetSwitcherSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsWidgetSwitcherSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsWidgetSwitcherSlot_Widget_PropertyAddress, SlotAsWidgetSwitcherSlot_FunctionAddress, "Widget");
		SlotAsWidgetSwitcherSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsWidgetSwitcherSlot_FunctionAddress, "Widget");
		SlotAsWidgetSwitcherSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsWidgetSwitcherSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsWidgetSwitcherSlot_ReturnValue_PropertyAddress, SlotAsWidgetSwitcherSlot_FunctionAddress, "ReturnValue");
		SlotAsWidgetSwitcherSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsWidgetSwitcherSlot_FunctionAddress, "ReturnValue");
		SlotAsWidgetSwitcherSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsWidgetSwitcherSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsWidgetSwitcherSlot_IsValid = SlotAsWidgetSwitcherSlot_FunctionAddress != IntPtr.Zero && SlotAsWidgetSwitcherSlot_Widget_IsValid && SlotAsWidgetSwitcherSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsWidgetSwitcherSlot", SlotAsWidgetSwitcherSlot_IsValid);
		SlotAsVerticalBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsVerticalBoxSlot");
		SlotAsVerticalBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsVerticalBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsVerticalBoxSlot_Widget_PropertyAddress, SlotAsVerticalBoxSlot_FunctionAddress, "Widget");
		SlotAsVerticalBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsVerticalBoxSlot_FunctionAddress, "Widget");
		SlotAsVerticalBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsVerticalBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsVerticalBoxSlot_ReturnValue_PropertyAddress, SlotAsVerticalBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsVerticalBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsVerticalBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsVerticalBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsVerticalBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsVerticalBoxSlot_IsValid = SlotAsVerticalBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsVerticalBoxSlot_Widget_IsValid && SlotAsVerticalBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsVerticalBoxSlot", SlotAsVerticalBoxSlot_IsValid);
		SlotAsUniformGridSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsUniformGridSlot");
		SlotAsUniformGridSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsUniformGridSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsUniformGridSlot_Widget_PropertyAddress, SlotAsUniformGridSlot_FunctionAddress, "Widget");
		SlotAsUniformGridSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsUniformGridSlot_FunctionAddress, "Widget");
		SlotAsUniformGridSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsUniformGridSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsUniformGridSlot_ReturnValue_PropertyAddress, SlotAsUniformGridSlot_FunctionAddress, "ReturnValue");
		SlotAsUniformGridSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsUniformGridSlot_FunctionAddress, "ReturnValue");
		SlotAsUniformGridSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsUniformGridSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsUniformGridSlot_IsValid = SlotAsUniformGridSlot_FunctionAddress != IntPtr.Zero && SlotAsUniformGridSlot_Widget_IsValid && SlotAsUniformGridSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsUniformGridSlot", SlotAsUniformGridSlot_IsValid);
		SlotAsSizeBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsSizeBoxSlot");
		SlotAsSizeBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsSizeBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsSizeBoxSlot_Widget_PropertyAddress, SlotAsSizeBoxSlot_FunctionAddress, "Widget");
		SlotAsSizeBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsSizeBoxSlot_FunctionAddress, "Widget");
		SlotAsSizeBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsSizeBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsSizeBoxSlot_ReturnValue_PropertyAddress, SlotAsSizeBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsSizeBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsSizeBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsSizeBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsSizeBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsSizeBoxSlot_IsValid = SlotAsSizeBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsSizeBoxSlot_Widget_IsValid && SlotAsSizeBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsSizeBoxSlot", SlotAsSizeBoxSlot_IsValid);
		SlotAsScrollBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsScrollBoxSlot");
		SlotAsScrollBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsScrollBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsScrollBoxSlot_Widget_PropertyAddress, SlotAsScrollBoxSlot_FunctionAddress, "Widget");
		SlotAsScrollBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsScrollBoxSlot_FunctionAddress, "Widget");
		SlotAsScrollBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsScrollBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsScrollBoxSlot_ReturnValue_PropertyAddress, SlotAsScrollBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsScrollBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsScrollBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsScrollBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsScrollBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsScrollBoxSlot_IsValid = SlotAsScrollBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsScrollBoxSlot_Widget_IsValid && SlotAsScrollBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsScrollBoxSlot", SlotAsScrollBoxSlot_IsValid);
		SlotAsScaleBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsScaleBoxSlot");
		SlotAsScaleBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsScaleBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsScaleBoxSlot_Widget_PropertyAddress, SlotAsScaleBoxSlot_FunctionAddress, "Widget");
		SlotAsScaleBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsScaleBoxSlot_FunctionAddress, "Widget");
		SlotAsScaleBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsScaleBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsScaleBoxSlot_ReturnValue_PropertyAddress, SlotAsScaleBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsScaleBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsScaleBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsScaleBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsScaleBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsScaleBoxSlot_IsValid = SlotAsScaleBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsScaleBoxSlot_Widget_IsValid && SlotAsScaleBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsScaleBoxSlot", SlotAsScaleBoxSlot_IsValid);
		SlotAsSafeBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsSafeBoxSlot");
		SlotAsSafeBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsSafeBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsSafeBoxSlot_Widget_PropertyAddress, SlotAsSafeBoxSlot_FunctionAddress, "Widget");
		SlotAsSafeBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsSafeBoxSlot_FunctionAddress, "Widget");
		SlotAsSafeBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsSafeBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsSafeBoxSlot_ReturnValue_PropertyAddress, SlotAsSafeBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsSafeBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsSafeBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsSafeBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsSafeBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsSafeBoxSlot_IsValid = SlotAsSafeBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsSafeBoxSlot_Widget_IsValid && SlotAsSafeBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsSafeBoxSlot", SlotAsSafeBoxSlot_IsValid);
		SlotAsOverlaySlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsOverlaySlot");
		SlotAsOverlaySlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsOverlaySlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsOverlaySlot_Widget_PropertyAddress, SlotAsOverlaySlot_FunctionAddress, "Widget");
		SlotAsOverlaySlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsOverlaySlot_FunctionAddress, "Widget");
		SlotAsOverlaySlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsOverlaySlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsOverlaySlot_ReturnValue_PropertyAddress, SlotAsOverlaySlot_FunctionAddress, "ReturnValue");
		SlotAsOverlaySlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsOverlaySlot_FunctionAddress, "ReturnValue");
		SlotAsOverlaySlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsOverlaySlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsOverlaySlot_IsValid = SlotAsOverlaySlot_FunctionAddress != IntPtr.Zero && SlotAsOverlaySlot_Widget_IsValid && SlotAsOverlaySlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsOverlaySlot", SlotAsOverlaySlot_IsValid);
		SlotAsHorizontalBoxSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsHorizontalBoxSlot");
		SlotAsHorizontalBoxSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsHorizontalBoxSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsHorizontalBoxSlot_Widget_PropertyAddress, SlotAsHorizontalBoxSlot_FunctionAddress, "Widget");
		SlotAsHorizontalBoxSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsHorizontalBoxSlot_FunctionAddress, "Widget");
		SlotAsHorizontalBoxSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsHorizontalBoxSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsHorizontalBoxSlot_ReturnValue_PropertyAddress, SlotAsHorizontalBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsHorizontalBoxSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsHorizontalBoxSlot_FunctionAddress, "ReturnValue");
		SlotAsHorizontalBoxSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsHorizontalBoxSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsHorizontalBoxSlot_IsValid = SlotAsHorizontalBoxSlot_FunctionAddress != IntPtr.Zero && SlotAsHorizontalBoxSlot_Widget_IsValid && SlotAsHorizontalBoxSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsHorizontalBoxSlot", SlotAsHorizontalBoxSlot_IsValid);
		SlotAsGridSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsGridSlot");
		SlotAsGridSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsGridSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsGridSlot_Widget_PropertyAddress, SlotAsGridSlot_FunctionAddress, "Widget");
		SlotAsGridSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsGridSlot_FunctionAddress, "Widget");
		SlotAsGridSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsGridSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsGridSlot_ReturnValue_PropertyAddress, SlotAsGridSlot_FunctionAddress, "ReturnValue");
		SlotAsGridSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsGridSlot_FunctionAddress, "ReturnValue");
		SlotAsGridSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsGridSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsGridSlot_IsValid = SlotAsGridSlot_FunctionAddress != IntPtr.Zero && SlotAsGridSlot_Widget_IsValid && SlotAsGridSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsGridSlot", SlotAsGridSlot_IsValid);
		SlotAsCanvasSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsCanvasSlot");
		SlotAsCanvasSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsCanvasSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsCanvasSlot_Widget_PropertyAddress, SlotAsCanvasSlot_FunctionAddress, "Widget");
		SlotAsCanvasSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsCanvasSlot_FunctionAddress, "Widget");
		SlotAsCanvasSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsCanvasSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsCanvasSlot_ReturnValue_PropertyAddress, SlotAsCanvasSlot_FunctionAddress, "ReturnValue");
		SlotAsCanvasSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsCanvasSlot_FunctionAddress, "ReturnValue");
		SlotAsCanvasSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsCanvasSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsCanvasSlot_IsValid = SlotAsCanvasSlot_FunctionAddress != IntPtr.Zero && SlotAsCanvasSlot_Widget_IsValid && SlotAsCanvasSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsCanvasSlot", SlotAsCanvasSlot_IsValid);
		SlotAsBorderSlot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlotAsBorderSlot");
		SlotAsBorderSlot_ParamsSize = NativeReflection.GetFunctionParamsSize(SlotAsBorderSlot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlotAsBorderSlot_Widget_PropertyAddress, SlotAsBorderSlot_FunctionAddress, "Widget");
		SlotAsBorderSlot_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsBorderSlot_FunctionAddress, "Widget");
		SlotAsBorderSlot_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsBorderSlot_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SlotAsBorderSlot_ReturnValue_PropertyAddress, SlotAsBorderSlot_FunctionAddress, "ReturnValue");
		SlotAsBorderSlot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlotAsBorderSlot_FunctionAddress, "ReturnValue");
		SlotAsBorderSlot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlotAsBorderSlot_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SlotAsBorderSlot_IsValid = SlotAsBorderSlot_FunctionAddress != IntPtr.Zero && SlotAsBorderSlot_Widget_IsValid && SlotAsBorderSlot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:SlotAsBorderSlot", SlotAsBorderSlot_IsValid);
		RemoveAllWidgets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllWidgets");
		RemoveAllWidgets_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllWidgets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllWidgets_WorldContextObject_PropertyAddress, RemoveAllWidgets_FunctionAddress, "WorldContextObject");
		RemoveAllWidgets_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllWidgets_FunctionAddress, "WorldContextObject");
		RemoveAllWidgets_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllWidgets_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		RemoveAllWidgets_IsValid = RemoveAllWidgets_FunctionAddress != IntPtr.Zero && RemoveAllWidgets_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:RemoveAllWidgets", RemoveAllWidgets_IsValid);
		ProjectWorldLocationToWidgetPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProjectWorldLocationToWidgetPosition");
		ProjectWorldLocationToWidgetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectWorldLocationToWidgetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController");
		ProjectWorldLocationToWidgetPosition_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController");
		ProjectWorldLocationToWidgetPosition_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation");
		ProjectWorldLocationToWidgetPosition_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation");
		ProjectWorldLocationToWidgetPosition_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToWidgetPosition_ScreenPosition_PropertyAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, "ScreenPosition");
		ProjectWorldLocationToWidgetPosition_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToWidgetPosition_FunctionAddress, "ScreenPosition");
		ProjectWorldLocationToWidgetPosition_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToWidgetPosition_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_PropertyAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, "bPlayerViewportRelative");
		ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToWidgetPosition_FunctionAddress, "bPlayerViewportRelative");
		ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToWidgetPosition_FunctionAddress, "bPlayerViewportRelative", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress, ProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue");
		ProjectWorldLocationToWidgetPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue");
		ProjectWorldLocationToWidgetPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectWorldLocationToWidgetPosition_IsValid = ProjectWorldLocationToWidgetPosition_FunctionAddress != IntPtr.Zero && ProjectWorldLocationToWidgetPosition_PlayerController_IsValid && ProjectWorldLocationToWidgetPosition_WorldLocation_IsValid && ProjectWorldLocationToWidgetPosition_ScreenPosition_IsValid && ProjectWorldLocationToWidgetPosition_bPlayerViewportRelative_IsValid && ProjectWorldLocationToWidgetPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:ProjectWorldLocationToWidgetPosition", ProjectWorldLocationToWidgetPosition_IsValid);
		GetViewportWidgetGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportWidgetGeometry");
		GetViewportWidgetGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportWidgetGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportWidgetGeometry_WorldContextObject_PropertyAddress, GetViewportWidgetGeometry_FunctionAddress, "WorldContextObject");
		GetViewportWidgetGeometry_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportWidgetGeometry_FunctionAddress, "WorldContextObject");
		GetViewportWidgetGeometry_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportWidgetGeometry_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewportWidgetGeometry_ReturnValue_PropertyAddress, GetViewportWidgetGeometry_FunctionAddress, "ReturnValue");
		GetViewportWidgetGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportWidgetGeometry_FunctionAddress, "ReturnValue");
		GetViewportWidgetGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportWidgetGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportWidgetGeometry_IsValid = GetViewportWidgetGeometry_FunctionAddress != IntPtr.Zero && GetViewportWidgetGeometry_WorldContextObject_IsValid && GetViewportWidgetGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetViewportWidgetGeometry", GetViewportWidgetGeometry_IsValid);
		GetViewportSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportSize");
		GetViewportSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportSize_WorldContextObject_PropertyAddress, GetViewportSize_FunctionAddress, "WorldContextObject");
		GetViewportSize_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportSize_FunctionAddress, "WorldContextObject");
		GetViewportSize_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportSize_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewportSize_ReturnValue_PropertyAddress, GetViewportSize_FunctionAddress, "ReturnValue");
		GetViewportSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportSize_FunctionAddress, "ReturnValue");
		GetViewportSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportSize_IsValid = GetViewportSize_FunctionAddress != IntPtr.Zero && GetViewportSize_WorldContextObject_IsValid && GetViewportSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetViewportSize", GetViewportSize_IsValid);
		GetViewportScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportScale");
		GetViewportScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportScale_WorldContextObject_PropertyAddress, GetViewportScale_FunctionAddress, "WorldContextObject");
		GetViewportScale_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportScale_FunctionAddress, "WorldContextObject");
		GetViewportScale_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportScale_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewportScale_ReturnValue_PropertyAddress, GetViewportScale_FunctionAddress, "ReturnValue");
		GetViewportScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportScale_FunctionAddress, "ReturnValue");
		GetViewportScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewportScale_IsValid = GetViewportScale_FunctionAddress != IntPtr.Zero && GetViewportScale_WorldContextObject_IsValid && GetViewportScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetViewportScale", GetViewportScale_IsValid);
		GetPlayerScreenWidgetGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerScreenWidgetGeometry");
		GetPlayerScreenWidgetGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerScreenWidgetGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerScreenWidgetGeometry_PlayerController_PropertyAddress, GetPlayerScreenWidgetGeometry_FunctionAddress, "PlayerController");
		GetPlayerScreenWidgetGeometry_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerScreenWidgetGeometry_FunctionAddress, "PlayerController");
		GetPlayerScreenWidgetGeometry_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerScreenWidgetGeometry_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerScreenWidgetGeometry_ReturnValue_PropertyAddress, GetPlayerScreenWidgetGeometry_FunctionAddress, "ReturnValue");
		GetPlayerScreenWidgetGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerScreenWidgetGeometry_FunctionAddress, "ReturnValue");
		GetPlayerScreenWidgetGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerScreenWidgetGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlayerScreenWidgetGeometry_IsValid = GetPlayerScreenWidgetGeometry_FunctionAddress != IntPtr.Zero && GetPlayerScreenWidgetGeometry_PlayerController_IsValid && GetPlayerScreenWidgetGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetPlayerScreenWidgetGeometry", GetPlayerScreenWidgetGeometry_IsValid);
		GetMousePositionScaledByDPI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMousePositionScaledByDPI");
		GetMousePositionScaledByDPI_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMousePositionScaledByDPI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionScaledByDPI_Player_PropertyAddress, GetMousePositionScaledByDPI_FunctionAddress, "Player");
		GetMousePositionScaledByDPI_Player_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionScaledByDPI_FunctionAddress, "Player");
		GetMousePositionScaledByDPI_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionScaledByDPI_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionScaledByDPI_LocationX_PropertyAddress, GetMousePositionScaledByDPI_FunctionAddress, "LocationX");
		GetMousePositionScaledByDPI_LocationX_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionScaledByDPI_FunctionAddress, "LocationX");
		GetMousePositionScaledByDPI_LocationX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionScaledByDPI_FunctionAddress, "LocationX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionScaledByDPI_LocationY_PropertyAddress, GetMousePositionScaledByDPI_FunctionAddress, "LocationY");
		GetMousePositionScaledByDPI_LocationY_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionScaledByDPI_FunctionAddress, "LocationY");
		GetMousePositionScaledByDPI_LocationY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionScaledByDPI_FunctionAddress, "LocationY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionScaledByDPI_ReturnValue_PropertyAddress, GetMousePositionScaledByDPI_FunctionAddress, "ReturnValue");
		GetMousePositionScaledByDPI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionScaledByDPI_FunctionAddress, "ReturnValue");
		GetMousePositionScaledByDPI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionScaledByDPI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetMousePositionScaledByDPI_IsValid = GetMousePositionScaledByDPI_FunctionAddress != IntPtr.Zero && GetMousePositionScaledByDPI_Player_IsValid && GetMousePositionScaledByDPI_LocationX_IsValid && GetMousePositionScaledByDPI_LocationY_IsValid && GetMousePositionScaledByDPI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetMousePositionScaledByDPI", GetMousePositionScaledByDPI_IsValid);
		GetMousePositionOnViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMousePositionOnViewport");
		GetMousePositionOnViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMousePositionOnViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionOnViewport_WorldContextObject_PropertyAddress, GetMousePositionOnViewport_FunctionAddress, "WorldContextObject");
		GetMousePositionOnViewport_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionOnViewport_FunctionAddress, "WorldContextObject");
		GetMousePositionOnViewport_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionOnViewport_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionOnViewport_ReturnValue_PropertyAddress, GetMousePositionOnViewport_FunctionAddress, "ReturnValue");
		GetMousePositionOnViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionOnViewport_FunctionAddress, "ReturnValue");
		GetMousePositionOnViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionOnViewport_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMousePositionOnViewport_IsValid = GetMousePositionOnViewport_FunctionAddress != IntPtr.Zero && GetMousePositionOnViewport_WorldContextObject_IsValid && GetMousePositionOnViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnViewport", GetMousePositionOnViewport_IsValid);
		GetMousePositionOnPlatform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMousePositionOnPlatform");
		GetMousePositionOnPlatform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMousePositionOnPlatform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionOnPlatform_ReturnValue_PropertyAddress, GetMousePositionOnPlatform_FunctionAddress, "ReturnValue");
		GetMousePositionOnPlatform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionOnPlatform_FunctionAddress, "ReturnValue");
		GetMousePositionOnPlatform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionOnPlatform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMousePositionOnPlatform_IsValid = GetMousePositionOnPlatform_FunctionAddress != IntPtr.Zero && GetMousePositionOnPlatform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetLayoutLibrary:GetMousePositionOnPlatform", GetMousePositionOnPlatform_IsValid);
	}
}
