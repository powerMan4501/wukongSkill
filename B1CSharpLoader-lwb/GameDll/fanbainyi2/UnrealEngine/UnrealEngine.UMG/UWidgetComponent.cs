using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.WidgetComponent", "UMG", UnrealModuleType.Engine)]
public class UWidgetComponent : UMeshComponent
{
	private static bool SetWindowVisibility_IsValid;

	private static IntPtr SetWindowVisibility_FunctionAddress;

	private static int SetWindowVisibility_ParamsSize;

	private static bool SetWindowVisibility_InVisibility_IsValid;

	private static FFieldAddress SetWindowVisibility_InVisibility_PropertyAddress;

	private static int SetWindowVisibility_InVisibility_Offset;

	private static bool SetWindowFocusable_IsValid;

	private static IntPtr SetWindowFocusable_FunctionAddress;

	private static int SetWindowFocusable_ParamsSize;

	private static bool SetWindowFocusable_bInWindowFocusable_IsValid;

	private static FFieldAddress SetWindowFocusable_bInWindowFocusable_PropertyAddress;

	private static int SetWindowFocusable_bInWindowFocusable_Offset;

	private static bool SetWidgetSpace_IsValid;

	private static IntPtr SetWidgetSpace_FunctionAddress;

	private static int SetWidgetSpace_ParamsSize;

	private static bool SetWidgetSpace_NewSpace_IsValid;

	private static FFieldAddress SetWidgetSpace_NewSpace_PropertyAddress;

	private static int SetWidgetSpace_NewSpace_Offset;

	private static bool SetWidget_IsValid;

	private static IntPtr SetWidget_FunctionAddress;

	private static int SetWidget_ParamsSize;

	private static bool SetWidget_Widget_IsValid;

	private static FFieldAddress SetWidget_Widget_PropertyAddress;

	private static int SetWidget_Widget_Offset;

	private static bool SetTwoSided_IsValid;

	private static IntPtr SetTwoSided_FunctionAddress;

	private static int SetTwoSided_ParamsSize;

	private static bool SetTwoSided_bWantTwoSided_IsValid;

	private static FFieldAddress SetTwoSided_bWantTwoSided_PropertyAddress;

	private static int SetTwoSided_bWantTwoSided_Offset;

	private static bool SetTintColorAndOpacity_IsValid;

	private static IntPtr SetTintColorAndOpacity_FunctionAddress;

	private static int SetTintColorAndOpacity_ParamsSize;

	private static bool SetTintColorAndOpacity_NewTintColorAndOpacity_IsValid;

	private static FFieldAddress SetTintColorAndOpacity_NewTintColorAndOpacity_PropertyAddress;

	private static int SetTintColorAndOpacity_NewTintColorAndOpacity_Offset;

	private static bool SetTickWhenOffscreen_IsValid;

	private static IntPtr SetTickWhenOffscreen_FunctionAddress;

	private static int SetTickWhenOffscreen_ParamsSize;

	private static bool SetTickWhenOffscreen_bWantTickWhenOffscreen_IsValid;

	private static FFieldAddress SetTickWhenOffscreen_bWantTickWhenOffscreen_PropertyAddress;

	private static int SetTickWhenOffscreen_bWantTickWhenOffscreen_Offset;

	private static bool SetTickMode_IsValid;

	private static IntPtr SetTickMode_FunctionAddress;

	private static int SetTickMode_ParamsSize;

	private static bool SetTickMode_InTickMode_IsValid;

	private static FFieldAddress SetTickMode_InTickMode_PropertyAddress;

	private static int SetTickMode_InTickMode_Offset;

	private static bool SetRedrawTime_IsValid;

	private static IntPtr SetRedrawTime_FunctionAddress;

	private static int SetRedrawTime_ParamsSize;

	private static bool SetRedrawTime_InRedrawTime_IsValid;

	private static FFieldAddress SetRedrawTime_InRedrawTime_PropertyAddress;

	private static int SetRedrawTime_InRedrawTime_Offset;

	private static bool SetPivot_IsValid;

	private static IntPtr SetPivot_FunctionAddress;

	private static int SetPivot_ParamsSize;

	private static bool SetPivot_InPivot_IsValid;

	private static FFieldAddress SetPivot_InPivot_PropertyAddress;

	private static int SetPivot_InPivot_Offset;

	private static bool SetOwnerPlayer_IsValid;

	private static IntPtr SetOwnerPlayer_FunctionAddress;

	private static int SetOwnerPlayer_ParamsSize;

	private static bool SetOwnerPlayer_LocalPlayer_IsValid;

	private static FFieldAddress SetOwnerPlayer_LocalPlayer_PropertyAddress;

	private static int SetOwnerPlayer_LocalPlayer_Offset;

	private static bool SetManuallyRedraw_IsValid;

	private static IntPtr SetManuallyRedraw_FunctionAddress;

	private static int SetManuallyRedraw_ParamsSize;

	private static bool SetManuallyRedraw_bUseManualRedraw_IsValid;

	private static FFieldAddress SetManuallyRedraw_bUseManualRedraw_PropertyAddress;

	private static int SetManuallyRedraw_bUseManualRedraw_Offset;

	private static bool SetGeometryMode_IsValid;

	private static IntPtr SetGeometryMode_FunctionAddress;

	private static int SetGeometryMode_ParamsSize;

	private static bool SetGeometryMode_InGeometryMode_IsValid;

	private static FFieldAddress SetGeometryMode_InGeometryMode_PropertyAddress;

	private static int SetGeometryMode_InGeometryMode_Offset;

	private static bool SetDrawSize_IsValid;

	private static IntPtr SetDrawSize_FunctionAddress;

	private static int SetDrawSize_ParamsSize;

	private static bool SetDrawSize_Size_IsValid;

	private static FFieldAddress SetDrawSize_Size_PropertyAddress;

	private static int SetDrawSize_Size_Offset;

	private static bool SetDrawAtDesiredSize_IsValid;

	private static IntPtr SetDrawAtDesiredSize_FunctionAddress;

	private static int SetDrawAtDesiredSize_ParamsSize;

	private static bool SetDrawAtDesiredSize_bInDrawAtDesiredSize_IsValid;

	private static FFieldAddress SetDrawAtDesiredSize_bInDrawAtDesiredSize_PropertyAddress;

	private static int SetDrawAtDesiredSize_bInDrawAtDesiredSize_Offset;

	private static bool SetCylinderArcAngle_IsValid;

	private static IntPtr SetCylinderArcAngle_FunctionAddress;

	private static int SetCylinderArcAngle_ParamsSize;

	private static bool SetCylinderArcAngle_InCylinderArcAngle_IsValid;

	private static FFieldAddress SetCylinderArcAngle_InCylinderArcAngle_PropertyAddress;

	private static int SetCylinderArcAngle_InCylinderArcAngle_Offset;

	private static bool SetBackgroundColor_IsValid;

	private static IntPtr SetBackgroundColor_FunctionAddress;

	private static int SetBackgroundColor_ParamsSize;

	private static bool SetBackgroundColor_NewBackgroundColor_IsValid;

	private static FFieldAddress SetBackgroundColor_NewBackgroundColor_PropertyAddress;

	private static int SetBackgroundColor_NewBackgroundColor_Offset;

	private static bool RequestRenderUpdate_IsValid;

	private static IntPtr RequestRenderUpdate_FunctionAddress;

	private static int RequestRenderUpdate_ParamsSize;

	private static bool IsWidgetVisible_IsValid;

	private static IntPtr IsWidgetVisible_FunctionAddress;

	private static int IsWidgetVisible_ParamsSize;

	private static bool IsWidgetVisible_ReturnValue_IsValid;

	private static FFieldAddress IsWidgetVisible_ReturnValue_PropertyAddress;

	private static int IsWidgetVisible_ReturnValue_Offset;

	private static bool GetWindowVisiblility_IsValid;

	private static IntPtr GetWindowVisiblility_FunctionAddress;

	private static int GetWindowVisiblility_ParamsSize;

	private static bool GetWindowVisiblility_ReturnValue_IsValid;

	private static FFieldAddress GetWindowVisiblility_ReturnValue_PropertyAddress;

	private static int GetWindowVisiblility_ReturnValue_Offset;

	private static bool GetWindowFocusable_IsValid;

	private static IntPtr GetWindowFocusable_FunctionAddress;

	private static int GetWindowFocusable_ParamsSize;

	private static bool GetWindowFocusable_ReturnValue_IsValid;

	private static FFieldAddress GetWindowFocusable_ReturnValue_PropertyAddress;

	private static int GetWindowFocusable_ReturnValue_Offset;

	private static bool GetWidgetSpace_IsValid;

	private static IntPtr GetWidgetSpace_FunctionAddress;

	private static int GetWidgetSpace_ParamsSize;

	private static bool GetWidgetSpace_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetSpace_ReturnValue_PropertyAddress;

	private static int GetWidgetSpace_ReturnValue_Offset;

	private static bool GetWidget_IsValid;

	private static IntPtr GetWidget_FunctionAddress;

	private static int GetWidget_ParamsSize;

	private static bool GetWidget_ReturnValue_IsValid;

	private static FFieldAddress GetWidget_ReturnValue_PropertyAddress;

	private static int GetWidget_ReturnValue_Offset;

	private static bool GetUserWidgetObject_IsValid;

	private static IntPtr GetUserWidgetObject_FunctionAddress;

	private static int GetUserWidgetObject_ParamsSize;

	private static bool GetUserWidgetObject_ReturnValue_IsValid;

	private static FFieldAddress GetUserWidgetObject_ReturnValue_PropertyAddress;

	private static int GetUserWidgetObject_ReturnValue_Offset;

	private static bool GetTwoSided_IsValid;

	private static IntPtr GetTwoSided_FunctionAddress;

	private static int GetTwoSided_ParamsSize;

	private static bool GetTwoSided_ReturnValue_IsValid;

	private static FFieldAddress GetTwoSided_ReturnValue_PropertyAddress;

	private static int GetTwoSided_ReturnValue_Offset;

	private static bool GetTickWhenOffscreen_IsValid;

	private static IntPtr GetTickWhenOffscreen_FunctionAddress;

	private static int GetTickWhenOffscreen_ParamsSize;

	private static bool GetTickWhenOffscreen_ReturnValue_IsValid;

	private static FFieldAddress GetTickWhenOffscreen_ReturnValue_PropertyAddress;

	private static int GetTickWhenOffscreen_ReturnValue_Offset;

	private static bool GetRenderTarget_IsValid;

	private static IntPtr GetRenderTarget_FunctionAddress;

	private static int GetRenderTarget_ParamsSize;

	private static bool GetRenderTarget_ReturnValue_IsValid;

	private static FFieldAddress GetRenderTarget_ReturnValue_PropertyAddress;

	private static int GetRenderTarget_ReturnValue_Offset;

	private static bool GetRedrawTime_IsValid;

	private static IntPtr GetRedrawTime_FunctionAddress;

	private static int GetRedrawTime_ParamsSize;

	private static bool GetRedrawTime_ReturnValue_IsValid;

	private static FFieldAddress GetRedrawTime_ReturnValue_PropertyAddress;

	private static int GetRedrawTime_ReturnValue_Offset;

	private static bool GetPivot_IsValid;

	private static IntPtr GetPivot_FunctionAddress;

	private static int GetPivot_ParamsSize;

	private static bool GetPivot_ReturnValue_IsValid;

	private static FFieldAddress GetPivot_ReturnValue_PropertyAddress;

	private static int GetPivot_ReturnValue_Offset;

	private static bool GetOwnerPlayer_IsValid;

	private static IntPtr GetOwnerPlayer_FunctionAddress;

	private static int GetOwnerPlayer_ParamsSize;

	private static bool GetOwnerPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetOwnerPlayer_ReturnValue_PropertyAddress;

	private static int GetOwnerPlayer_ReturnValue_Offset;

	private static bool GetMaterialInstance_IsValid;

	private static IntPtr GetMaterialInstance_FunctionAddress;

	private static int GetMaterialInstance_ParamsSize;

	private static bool GetMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialInstance_ReturnValue_PropertyAddress;

	private static int GetMaterialInstance_ReturnValue_Offset;

	private static bool GetManuallyRedraw_IsValid;

	private static IntPtr GetManuallyRedraw_FunctionAddress;

	private static int GetManuallyRedraw_ParamsSize;

	private static bool GetManuallyRedraw_ReturnValue_IsValid;

	private static FFieldAddress GetManuallyRedraw_ReturnValue_PropertyAddress;

	private static int GetManuallyRedraw_ReturnValue_Offset;

	private static bool GetGeometryMode_IsValid;

	private static IntPtr GetGeometryMode_FunctionAddress;

	private static int GetGeometryMode_ParamsSize;

	private static bool GetGeometryMode_ReturnValue_IsValid;

	private static FFieldAddress GetGeometryMode_ReturnValue_PropertyAddress;

	private static int GetGeometryMode_ReturnValue_Offset;

	private static bool GetDrawSize_IsValid;

	private static IntPtr GetDrawSize_FunctionAddress;

	private static int GetDrawSize_ParamsSize;

	private static bool GetDrawSize_ReturnValue_IsValid;

	private static FFieldAddress GetDrawSize_ReturnValue_PropertyAddress;

	private static int GetDrawSize_ReturnValue_Offset;

	private static bool GetDrawAtDesiredSize_IsValid;

	private static IntPtr GetDrawAtDesiredSize_FunctionAddress;

	private static int GetDrawAtDesiredSize_ParamsSize;

	private static bool GetDrawAtDesiredSize_ReturnValue_IsValid;

	private static FFieldAddress GetDrawAtDesiredSize_ReturnValue_PropertyAddress;

	private static int GetDrawAtDesiredSize_ReturnValue_Offset;

	private static bool GetCylinderArcAngle_IsValid;

	private static IntPtr GetCylinderArcAngle_FunctionAddress;

	private static int GetCylinderArcAngle_ParamsSize;

	private static bool GetCylinderArcAngle_ReturnValue_IsValid;

	private static FFieldAddress GetCylinderArcAngle_ReturnValue_PropertyAddress;

	private static int GetCylinderArcAngle_ReturnValue_Offset;

	private static bool GetCurrentDrawSize_IsValid;

	private static IntPtr GetCurrentDrawSize_FunctionAddress;

	private static int GetCurrentDrawSize_ParamsSize;

	private static bool GetCurrentDrawSize_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentDrawSize_ReturnValue_PropertyAddress;

	private static int GetCurrentDrawSize_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetWindowVisibility")]
	public unsafe void SetWindowVisibility(EWindowVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetWindowVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetWindowVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindowVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindowVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWindowVisibility>.ToNative(IntPtr.Add(intPtr, SetWindowVisibility_InVisibility_Offset), 0, SetWindowVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWindowVisibility_FunctionAddress, intPtr, SetWindowVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetWindowFocusable")]
	public unsafe void SetWindowFocusable(bool bInWindowFocusable)
	{
		CheckDestroyed();
		if (!SetWindowFocusable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetWindowFocusable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindowFocusable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindowFocusable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWindowFocusable_bInWindowFocusable_Offset), 0, SetWindowFocusable_bInWindowFocusable_PropertyAddress.Address, bInWindowFocusable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWindowFocusable_FunctionAddress, intPtr, SetWindowFocusable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetWidgetSpace")]
	public unsafe void SetWidgetSpace(EWidgetSpace NewSpace)
	{
		CheckDestroyed();
		if (!SetWidgetSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetWidgetSpace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidgetSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidgetSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWidgetSpace>.ToNative(IntPtr.Add(intPtr, SetWidgetSpace_NewSpace_Offset), 0, SetWidgetSpace_NewSpace_PropertyAddress.Address, NewSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWidgetSpace_FunctionAddress, intPtr, SetWidgetSpace_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetWidget")]
	public unsafe void SetWidget(UUserWidget Widget)
	{
		CheckDestroyed();
		if (!SetWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetWidget_Widget_Offset), 0, SetWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWidget_FunctionAddress, intPtr, SetWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetTwoSided")]
	public unsafe void SetTwoSided(bool bWantTwoSided)
	{
		CheckDestroyed();
		if (!SetTwoSided_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetTwoSided");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTwoSided_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTwoSided_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTwoSided_bWantTwoSided_Offset), 0, SetTwoSided_bWantTwoSided_PropertyAddress.Address, bWantTwoSided);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTwoSided_FunctionAddress, intPtr, SetTwoSided_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetTintColorAndOpacity")]
	public unsafe void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetTintColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetTintColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTintColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTintColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTintColorAndOpacity_NewTintColorAndOpacity_Offset), 0, SetTintColorAndOpacity_NewTintColorAndOpacity_PropertyAddress.Address, NewTintColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTintColorAndOpacity_FunctionAddress, intPtr, SetTintColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetTickWhenOffscreen")]
	public unsafe void SetTickWhenOffscreen(bool bWantTickWhenOffscreen)
	{
		CheckDestroyed();
		if (!SetTickWhenOffscreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetTickWhenOffscreen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickWhenOffscreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickWhenOffscreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTickWhenOffscreen_bWantTickWhenOffscreen_Offset), 0, SetTickWhenOffscreen_bWantTickWhenOffscreen_PropertyAddress.Address, bWantTickWhenOffscreen);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickWhenOffscreen_FunctionAddress, intPtr, SetTickWhenOffscreen_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetTickMode")]
	public unsafe void SetTickMode(ETickMode InTickMode)
	{
		CheckDestroyed();
		if (!SetTickMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetTickMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETickMode>.ToNative(IntPtr.Add(intPtr, SetTickMode_InTickMode_Offset), 0, SetTickMode_InTickMode_PropertyAddress.Address, InTickMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickMode_FunctionAddress, intPtr, SetTickMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetRedrawTime")]
	public unsafe void SetRedrawTime(float InRedrawTime)
	{
		CheckDestroyed();
		if (!SetRedrawTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetRedrawTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRedrawTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRedrawTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRedrawTime_InRedrawTime_Offset), 0, SetRedrawTime_InRedrawTime_PropertyAddress.Address, InRedrawTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRedrawTime_FunctionAddress, intPtr, SetRedrawTime_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetPivot")]
	public unsafe void SetPivot(FVector2D InPivot)
	{
		CheckDestroyed();
		if (!SetPivot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetPivot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPivot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPivot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetPivot_InPivot_Offset), 0, SetPivot_InPivot_PropertyAddress.Address, InPivot);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPivot_FunctionAddress, intPtr, SetPivot_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetOwnerPlayer")]
	public unsafe void SetOwnerPlayer(ULocalPlayer LocalPlayer)
	{
		CheckDestroyed();
		if (!SetOwnerPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetOwnerPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOwnerPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOwnerPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULocalPlayer>.ToNative(IntPtr.Add(intPtr, SetOwnerPlayer_LocalPlayer_Offset), 0, SetOwnerPlayer_LocalPlayer_PropertyAddress.Address, LocalPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOwnerPlayer_FunctionAddress, intPtr, SetOwnerPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetManuallyRedraw")]
	public unsafe void SetManuallyRedraw(bool bUseManualRedraw)
	{
		CheckDestroyed();
		if (!SetManuallyRedraw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetManuallyRedraw");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetManuallyRedraw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetManuallyRedraw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetManuallyRedraw_bUseManualRedraw_Offset), 0, SetManuallyRedraw_bUseManualRedraw_PropertyAddress.Address, bUseManualRedraw);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetManuallyRedraw_FunctionAddress, intPtr, SetManuallyRedraw_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetGeometryMode")]
	public unsafe void SetGeometryMode(EWidgetGeometryMode InGeometryMode)
	{
		CheckDestroyed();
		if (!SetGeometryMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetGeometryMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGeometryMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGeometryMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWidgetGeometryMode>.ToNative(IntPtr.Add(intPtr, SetGeometryMode_InGeometryMode_Offset), 0, SetGeometryMode_InGeometryMode_PropertyAddress.Address, InGeometryMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGeometryMode_FunctionAddress, intPtr, SetGeometryMode_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetDrawSize")]
	public unsafe void SetDrawSize(FVector2D Size)
	{
		CheckDestroyed();
		if (!SetDrawSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetDrawSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDrawSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDrawSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDrawSize_Size_Offset), 0, SetDrawSize_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDrawSize_FunctionAddress, intPtr, SetDrawSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetDrawAtDesiredSize")]
	public unsafe void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize)
	{
		CheckDestroyed();
		if (!SetDrawAtDesiredSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetDrawAtDesiredSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDrawAtDesiredSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDrawAtDesiredSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDrawAtDesiredSize_bInDrawAtDesiredSize_Offset), 0, SetDrawAtDesiredSize_bInDrawAtDesiredSize_PropertyAddress.Address, bInDrawAtDesiredSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDrawAtDesiredSize_FunctionAddress, intPtr, SetDrawAtDesiredSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetCylinderArcAngle")]
	public unsafe void SetCylinderArcAngle(float InCylinderArcAngle)
	{
		CheckDestroyed();
		if (!SetCylinderArcAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetCylinderArcAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCylinderArcAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCylinderArcAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCylinderArcAngle_InCylinderArcAngle_Offset), 0, SetCylinderArcAngle_InCylinderArcAngle_PropertyAddress.Address, InCylinderArcAngle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCylinderArcAngle_FunctionAddress, intPtr, SetCylinderArcAngle_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.WidgetComponent:SetBackgroundColor")]
	public unsafe void SetBackgroundColor(FLinearColor NewBackgroundColor)
	{
		CheckDestroyed();
		if (!SetBackgroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:SetBackgroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBackgroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBackgroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetBackgroundColor_NewBackgroundColor_Offset), 0, SetBackgroundColor_NewBackgroundColor_PropertyAddress.Address, NewBackgroundColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBackgroundColor_FunctionAddress, intPtr, SetBackgroundColor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.WidgetComponent:RequestRenderUpdate")]
	public unsafe void RequestRenderUpdate()
	{
		CheckDestroyed();
		if (!RequestRenderUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:RequestRenderUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRenderUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRenderUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestRenderUpdate_FunctionAddress, argsSize: RequestRenderUpdate_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:IsWidgetVisible")]
	public unsafe bool IsWidgetVisible()
	{
		CheckDestroyed();
		if (!IsWidgetVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:IsWidgetVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWidgetVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWidgetVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWidgetVisible_FunctionAddress, intPtr, IsWidgetVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWidgetVisible_ReturnValue_Offset), 0, IsWidgetVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetWindowVisiblility")]
	public unsafe EWindowVisibility GetWindowVisiblility()
	{
		CheckDestroyed();
		if (!GetWindowVisiblility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetWindowVisiblility");
			return EWindowVisibility.Visible;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWindowVisiblility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWindowVisiblility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWindowVisiblility_FunctionAddress, intPtr, GetWindowVisiblility_ParamsSize);
		return EnumMarshaler<EWindowVisibility>.FromNative(IntPtr.Add(intPtr, GetWindowVisiblility_ReturnValue_Offset), 0, GetWindowVisiblility_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetWindowFocusable")]
	public unsafe bool GetWindowFocusable()
	{
		CheckDestroyed();
		if (!GetWindowFocusable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetWindowFocusable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWindowFocusable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWindowFocusable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWindowFocusable_FunctionAddress, intPtr, GetWindowFocusable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetWindowFocusable_ReturnValue_Offset), 0, GetWindowFocusable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetWidgetSpace")]
	public unsafe EWidgetSpace GetWidgetSpace()
	{
		CheckDestroyed();
		if (!GetWidgetSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetWidgetSpace");
			return EWidgetSpace.World;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWidgetSpace_FunctionAddress, intPtr, GetWidgetSpace_ParamsSize);
		return EnumMarshaler<EWidgetSpace>.FromNative(IntPtr.Add(intPtr, GetWidgetSpace_ReturnValue_Offset), 0, GetWidgetSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetWidget")]
	public unsafe UUserWidget GetWidget()
	{
		CheckDestroyed();
		if (!GetWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWidget_FunctionAddress, intPtr, GetWidget_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, GetWidget_ReturnValue_Offset), 0, GetWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetUserWidgetObject")]
	public unsafe UUserWidget GetUserWidgetObject()
	{
		CheckDestroyed();
		if (!GetUserWidgetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetUserWidgetObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserWidgetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserWidgetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUserWidgetObject_FunctionAddress, intPtr, GetUserWidgetObject_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, GetUserWidgetObject_ReturnValue_Offset), 0, GetUserWidgetObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetTwoSided")]
	public unsafe bool GetTwoSided()
	{
		CheckDestroyed();
		if (!GetTwoSided_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetTwoSided");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTwoSided_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTwoSided_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTwoSided_FunctionAddress, intPtr, GetTwoSided_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTwoSided_ReturnValue_Offset), 0, GetTwoSided_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetTickWhenOffscreen")]
	public unsafe bool GetTickWhenOffscreen()
	{
		CheckDestroyed();
		if (!GetTickWhenOffscreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetTickWhenOffscreen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTickWhenOffscreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTickWhenOffscreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTickWhenOffscreen_FunctionAddress, intPtr, GetTickWhenOffscreen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTickWhenOffscreen_ReturnValue_Offset), 0, GetTickWhenOffscreen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetRenderTarget")]
	public unsafe UTextureRenderTarget2D GetRenderTarget()
	{
		CheckDestroyed();
		if (!GetRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetRenderTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRenderTarget_FunctionAddress, intPtr, GetRenderTarget_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, GetRenderTarget_ReturnValue_Offset), 0, GetRenderTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetRedrawTime")]
	public unsafe float GetRedrawTime()
	{
		CheckDestroyed();
		if (!GetRedrawTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetRedrawTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRedrawTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRedrawTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRedrawTime_FunctionAddress, intPtr, GetRedrawTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRedrawTime_ReturnValue_Offset), 0, GetRedrawTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetPivot")]
	public unsafe FVector2D GetPivot()
	{
		CheckDestroyed();
		if (!GetPivot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetPivot");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPivot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPivot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPivot_FunctionAddress, intPtr, GetPivot_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPivot_ReturnValue_Offset), 0, GetPivot_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetOwnerPlayer")]
	public unsafe ULocalPlayer GetOwnerPlayer()
	{
		CheckDestroyed();
		if (!GetOwnerPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetOwnerPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnerPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnerPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwnerPlayer_FunctionAddress, intPtr, GetOwnerPlayer_ParamsSize);
		return UObjectMarshaler<ULocalPlayer>.FromNative(IntPtr.Add(intPtr, GetOwnerPlayer_ReturnValue_Offset), 0, GetOwnerPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetMaterialInstance")]
	public unsafe UMaterialInstanceDynamic GetMaterialInstance()
	{
		CheckDestroyed();
		if (!GetMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialInstance_FunctionAddress, intPtr, GetMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetMaterialInstance_ReturnValue_Offset), 0, GetMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetManuallyRedraw")]
	public unsafe bool GetManuallyRedraw()
	{
		CheckDestroyed();
		if (!GetManuallyRedraw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetManuallyRedraw");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetManuallyRedraw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetManuallyRedraw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetManuallyRedraw_FunctionAddress, intPtr, GetManuallyRedraw_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetManuallyRedraw_ReturnValue_Offset), 0, GetManuallyRedraw_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetGeometryMode")]
	public unsafe EWidgetGeometryMode GetGeometryMode()
	{
		CheckDestroyed();
		if (!GetGeometryMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetGeometryMode");
			return EWidgetGeometryMode.Plane;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGeometryMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGeometryMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGeometryMode_FunctionAddress, intPtr, GetGeometryMode_ParamsSize);
		return EnumMarshaler<EWidgetGeometryMode>.FromNative(IntPtr.Add(intPtr, GetGeometryMode_ReturnValue_Offset), 0, GetGeometryMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetDrawSize")]
	public unsafe FVector2D GetDrawSize()
	{
		CheckDestroyed();
		if (!GetDrawSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetDrawSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDrawSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDrawSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDrawSize_FunctionAddress, intPtr, GetDrawSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetDrawSize_ReturnValue_Offset), 0, GetDrawSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetDrawAtDesiredSize")]
	public unsafe bool GetDrawAtDesiredSize()
	{
		CheckDestroyed();
		if (!GetDrawAtDesiredSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetDrawAtDesiredSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDrawAtDesiredSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDrawAtDesiredSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDrawAtDesiredSize_FunctionAddress, intPtr, GetDrawAtDesiredSize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDrawAtDesiredSize_ReturnValue_Offset), 0, GetDrawAtDesiredSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetCylinderArcAngle")]
	public unsafe float GetCylinderArcAngle()
	{
		CheckDestroyed();
		if (!GetCylinderArcAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetCylinderArcAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCylinderArcAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCylinderArcAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCylinderArcAngle_FunctionAddress, intPtr, GetCylinderArcAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCylinderArcAngle_ReturnValue_Offset), 0, GetCylinderArcAngle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.WidgetComponent:GetCurrentDrawSize")]
	public unsafe FVector2D GetCurrentDrawSize()
	{
		CheckDestroyed();
		if (!GetCurrentDrawSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetComponent:GetCurrentDrawSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentDrawSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentDrawSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentDrawSize_FunctionAddress, intPtr, GetCurrentDrawSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetCurrentDrawSize_ReturnValue_Offset), 0, GetCurrentDrawSize_ReturnValue_PropertyAddress.Address);
	}

	static UWidgetComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.WidgetComponent");
		SetWindowVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWindowVisibility");
		SetWindowVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindowVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindowVisibility_InVisibility_PropertyAddress, SetWindowVisibility_FunctionAddress, "InVisibility");
		SetWindowVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowVisibility_FunctionAddress, "InVisibility");
		SetWindowVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetWindowVisibility_IsValid = SetWindowVisibility_FunctionAddress != IntPtr.Zero && SetWindowVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetWindowVisibility", SetWindowVisibility_IsValid);
		SetWindowFocusable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWindowFocusable");
		SetWindowFocusable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindowFocusable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindowFocusable_bInWindowFocusable_PropertyAddress, SetWindowFocusable_FunctionAddress, "bInWindowFocusable");
		SetWindowFocusable_bInWindowFocusable_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowFocusable_FunctionAddress, "bInWindowFocusable");
		SetWindowFocusable_bInWindowFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowFocusable_FunctionAddress, "bInWindowFocusable", Classes.FBoolProperty);
		SetWindowFocusable_IsValid = SetWindowFocusable_FunctionAddress != IntPtr.Zero && SetWindowFocusable_bInWindowFocusable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetWindowFocusable", SetWindowFocusable_IsValid);
		SetWidgetSpace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWidgetSpace");
		SetWidgetSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidgetSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidgetSpace_NewSpace_PropertyAddress, SetWidgetSpace_FunctionAddress, "NewSpace");
		SetWidgetSpace_NewSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetWidgetSpace_FunctionAddress, "NewSpace");
		SetWidgetSpace_NewSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidgetSpace_FunctionAddress, "NewSpace", Classes.FEnumProperty);
		SetWidgetSpace_IsValid = SetWidgetSpace_FunctionAddress != IntPtr.Zero && SetWidgetSpace_NewSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetWidgetSpace", SetWidgetSpace_IsValid);
		SetWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWidget");
		SetWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidget_Widget_PropertyAddress, SetWidget_FunctionAddress, "Widget");
		SetWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetWidget_FunctionAddress, "Widget");
		SetWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		SetWidget_IsValid = SetWidget_FunctionAddress != IntPtr.Zero && SetWidget_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetWidget", SetWidget_IsValid);
		SetTwoSided_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTwoSided");
		SetTwoSided_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTwoSided_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTwoSided_bWantTwoSided_PropertyAddress, SetTwoSided_FunctionAddress, "bWantTwoSided");
		SetTwoSided_bWantTwoSided_Offset = NativeReflectionCached.GetPropertyOffset(SetTwoSided_FunctionAddress, "bWantTwoSided");
		SetTwoSided_bWantTwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTwoSided_FunctionAddress, "bWantTwoSided", Classes.FBoolProperty);
		SetTwoSided_IsValid = SetTwoSided_FunctionAddress != IntPtr.Zero && SetTwoSided_bWantTwoSided_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetTwoSided", SetTwoSided_IsValid);
		SetTintColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTintColorAndOpacity");
		SetTintColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTintColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTintColorAndOpacity_NewTintColorAndOpacity_PropertyAddress, SetTintColorAndOpacity_FunctionAddress, "NewTintColorAndOpacity");
		SetTintColorAndOpacity_NewTintColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetTintColorAndOpacity_FunctionAddress, "NewTintColorAndOpacity");
		SetTintColorAndOpacity_NewTintColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTintColorAndOpacity_FunctionAddress, "NewTintColorAndOpacity", Classes.FStructProperty);
		SetTintColorAndOpacity_IsValid = SetTintColorAndOpacity_FunctionAddress != IntPtr.Zero && SetTintColorAndOpacity_NewTintColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetTintColorAndOpacity", SetTintColorAndOpacity_IsValid);
		SetTickWhenOffscreen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTickWhenOffscreen");
		SetTickWhenOffscreen_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickWhenOffscreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickWhenOffscreen_bWantTickWhenOffscreen_PropertyAddress, SetTickWhenOffscreen_FunctionAddress, "bWantTickWhenOffscreen");
		SetTickWhenOffscreen_bWantTickWhenOffscreen_Offset = NativeReflectionCached.GetPropertyOffset(SetTickWhenOffscreen_FunctionAddress, "bWantTickWhenOffscreen");
		SetTickWhenOffscreen_bWantTickWhenOffscreen_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickWhenOffscreen_FunctionAddress, "bWantTickWhenOffscreen", Classes.FBoolProperty);
		SetTickWhenOffscreen_IsValid = SetTickWhenOffscreen_FunctionAddress != IntPtr.Zero && SetTickWhenOffscreen_bWantTickWhenOffscreen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetTickWhenOffscreen", SetTickWhenOffscreen_IsValid);
		SetTickMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTickMode");
		SetTickMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickMode_InTickMode_PropertyAddress, SetTickMode_FunctionAddress, "InTickMode");
		SetTickMode_InTickMode_Offset = NativeReflectionCached.GetPropertyOffset(SetTickMode_FunctionAddress, "InTickMode");
		SetTickMode_InTickMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickMode_FunctionAddress, "InTickMode", Classes.FEnumProperty);
		SetTickMode_IsValid = SetTickMode_FunctionAddress != IntPtr.Zero && SetTickMode_InTickMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetTickMode", SetTickMode_IsValid);
		SetRedrawTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRedrawTime");
		SetRedrawTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRedrawTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRedrawTime_InRedrawTime_PropertyAddress, SetRedrawTime_FunctionAddress, "InRedrawTime");
		SetRedrawTime_InRedrawTime_Offset = NativeReflectionCached.GetPropertyOffset(SetRedrawTime_FunctionAddress, "InRedrawTime");
		SetRedrawTime_InRedrawTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRedrawTime_FunctionAddress, "InRedrawTime", Classes.FFloatProperty);
		SetRedrawTime_IsValid = SetRedrawTime_FunctionAddress != IntPtr.Zero && SetRedrawTime_InRedrawTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetRedrawTime", SetRedrawTime_IsValid);
		SetPivot_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPivot");
		SetPivot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPivot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPivot_InPivot_PropertyAddress, SetPivot_FunctionAddress, "InPivot");
		SetPivot_InPivot_Offset = NativeReflectionCached.GetPropertyOffset(SetPivot_FunctionAddress, "InPivot");
		SetPivot_InPivot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPivot_FunctionAddress, "InPivot", Classes.FStructProperty);
		SetPivot_IsValid = SetPivot_FunctionAddress != IntPtr.Zero && SetPivot_InPivot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetPivot", SetPivot_IsValid);
		SetOwnerPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetOwnerPlayer");
		SetOwnerPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOwnerPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOwnerPlayer_LocalPlayer_PropertyAddress, SetOwnerPlayer_FunctionAddress, "LocalPlayer");
		SetOwnerPlayer_LocalPlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetOwnerPlayer_FunctionAddress, "LocalPlayer");
		SetOwnerPlayer_LocalPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOwnerPlayer_FunctionAddress, "LocalPlayer", Classes.FObjectProperty);
		SetOwnerPlayer_IsValid = SetOwnerPlayer_FunctionAddress != IntPtr.Zero && SetOwnerPlayer_LocalPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetOwnerPlayer", SetOwnerPlayer_IsValid);
		SetManuallyRedraw_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetManuallyRedraw");
		SetManuallyRedraw_ParamsSize = NativeReflection.GetFunctionParamsSize(SetManuallyRedraw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetManuallyRedraw_bUseManualRedraw_PropertyAddress, SetManuallyRedraw_FunctionAddress, "bUseManualRedraw");
		SetManuallyRedraw_bUseManualRedraw_Offset = NativeReflectionCached.GetPropertyOffset(SetManuallyRedraw_FunctionAddress, "bUseManualRedraw");
		SetManuallyRedraw_bUseManualRedraw_IsValid = NativeReflectionCached.ValidatePropertyClass(SetManuallyRedraw_FunctionAddress, "bUseManualRedraw", Classes.FBoolProperty);
		SetManuallyRedraw_IsValid = SetManuallyRedraw_FunctionAddress != IntPtr.Zero && SetManuallyRedraw_bUseManualRedraw_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetManuallyRedraw", SetManuallyRedraw_IsValid);
		SetGeometryMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGeometryMode");
		SetGeometryMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGeometryMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGeometryMode_InGeometryMode_PropertyAddress, SetGeometryMode_FunctionAddress, "InGeometryMode");
		SetGeometryMode_InGeometryMode_Offset = NativeReflectionCached.GetPropertyOffset(SetGeometryMode_FunctionAddress, "InGeometryMode");
		SetGeometryMode_InGeometryMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGeometryMode_FunctionAddress, "InGeometryMode", Classes.FEnumProperty);
		SetGeometryMode_IsValid = SetGeometryMode_FunctionAddress != IntPtr.Zero && SetGeometryMode_InGeometryMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetGeometryMode", SetGeometryMode_IsValid);
		SetDrawSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDrawSize");
		SetDrawSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDrawSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDrawSize_Size_PropertyAddress, SetDrawSize_FunctionAddress, "Size");
		SetDrawSize_Size_Offset = NativeReflectionCached.GetPropertyOffset(SetDrawSize_FunctionAddress, "Size");
		SetDrawSize_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDrawSize_FunctionAddress, "Size", Classes.FStructProperty);
		SetDrawSize_IsValid = SetDrawSize_FunctionAddress != IntPtr.Zero && SetDrawSize_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetDrawSize", SetDrawSize_IsValid);
		SetDrawAtDesiredSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDrawAtDesiredSize");
		SetDrawAtDesiredSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDrawAtDesiredSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDrawAtDesiredSize_bInDrawAtDesiredSize_PropertyAddress, SetDrawAtDesiredSize_FunctionAddress, "bInDrawAtDesiredSize");
		SetDrawAtDesiredSize_bInDrawAtDesiredSize_Offset = NativeReflectionCached.GetPropertyOffset(SetDrawAtDesiredSize_FunctionAddress, "bInDrawAtDesiredSize");
		SetDrawAtDesiredSize_bInDrawAtDesiredSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDrawAtDesiredSize_FunctionAddress, "bInDrawAtDesiredSize", Classes.FBoolProperty);
		SetDrawAtDesiredSize_IsValid = SetDrawAtDesiredSize_FunctionAddress != IntPtr.Zero && SetDrawAtDesiredSize_bInDrawAtDesiredSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetDrawAtDesiredSize", SetDrawAtDesiredSize_IsValid);
		SetCylinderArcAngle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCylinderArcAngle");
		SetCylinderArcAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCylinderArcAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCylinderArcAngle_InCylinderArcAngle_PropertyAddress, SetCylinderArcAngle_FunctionAddress, "InCylinderArcAngle");
		SetCylinderArcAngle_InCylinderArcAngle_Offset = NativeReflectionCached.GetPropertyOffset(SetCylinderArcAngle_FunctionAddress, "InCylinderArcAngle");
		SetCylinderArcAngle_InCylinderArcAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCylinderArcAngle_FunctionAddress, "InCylinderArcAngle", Classes.FFloatProperty);
		SetCylinderArcAngle_IsValid = SetCylinderArcAngle_FunctionAddress != IntPtr.Zero && SetCylinderArcAngle_InCylinderArcAngle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetCylinderArcAngle", SetCylinderArcAngle_IsValid);
		SetBackgroundColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBackgroundColor");
		SetBackgroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBackgroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBackgroundColor_NewBackgroundColor_PropertyAddress, SetBackgroundColor_FunctionAddress, "NewBackgroundColor");
		SetBackgroundColor_NewBackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(SetBackgroundColor_FunctionAddress, "NewBackgroundColor");
		SetBackgroundColor_NewBackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBackgroundColor_FunctionAddress, "NewBackgroundColor", Classes.FStructProperty);
		SetBackgroundColor_IsValid = SetBackgroundColor_FunctionAddress != IntPtr.Zero && SetBackgroundColor_NewBackgroundColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:SetBackgroundColor", SetBackgroundColor_IsValid);
		RequestRenderUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RequestRenderUpdate");
		RequestRenderUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRenderUpdate_FunctionAddress);
		RequestRenderUpdate_IsValid = RequestRenderUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:RequestRenderUpdate", RequestRenderUpdate_IsValid);
		IsWidgetVisible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsWidgetVisible");
		IsWidgetVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWidgetVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWidgetVisible_ReturnValue_PropertyAddress, IsWidgetVisible_FunctionAddress, "ReturnValue");
		IsWidgetVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWidgetVisible_FunctionAddress, "ReturnValue");
		IsWidgetVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWidgetVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWidgetVisible_IsValid = IsWidgetVisible_FunctionAddress != IntPtr.Zero && IsWidgetVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:IsWidgetVisible", IsWidgetVisible_IsValid);
		GetWindowVisiblility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWindowVisiblility");
		GetWindowVisiblility_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWindowVisiblility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWindowVisiblility_ReturnValue_PropertyAddress, GetWindowVisiblility_FunctionAddress, "ReturnValue");
		GetWindowVisiblility_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWindowVisiblility_FunctionAddress, "ReturnValue");
		GetWindowVisiblility_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWindowVisiblility_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetWindowVisiblility_IsValid = GetWindowVisiblility_FunctionAddress != IntPtr.Zero && GetWindowVisiblility_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetWindowVisiblility", GetWindowVisiblility_IsValid);
		GetWindowFocusable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWindowFocusable");
		GetWindowFocusable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWindowFocusable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWindowFocusable_ReturnValue_PropertyAddress, GetWindowFocusable_FunctionAddress, "ReturnValue");
		GetWindowFocusable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWindowFocusable_FunctionAddress, "ReturnValue");
		GetWindowFocusable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWindowFocusable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetWindowFocusable_IsValid = GetWindowFocusable_FunctionAddress != IntPtr.Zero && GetWindowFocusable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetWindowFocusable", GetWindowFocusable_IsValid);
		GetWidgetSpace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWidgetSpace");
		GetWidgetSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetSpace_ReturnValue_PropertyAddress, GetWidgetSpace_FunctionAddress, "ReturnValue");
		GetWidgetSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetSpace_FunctionAddress, "ReturnValue");
		GetWidgetSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetSpace_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetWidgetSpace_IsValid = GetWidgetSpace_FunctionAddress != IntPtr.Zero && GetWidgetSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetWidgetSpace", GetWidgetSpace_IsValid);
		GetWidget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWidget");
		GetWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidget_ReturnValue_PropertyAddress, GetWidget_FunctionAddress, "ReturnValue");
		GetWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidget_FunctionAddress, "ReturnValue");
		GetWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWidget_IsValid = GetWidget_FunctionAddress != IntPtr.Zero && GetWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetWidget", GetWidget_IsValid);
		GetUserWidgetObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUserWidgetObject");
		GetUserWidgetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserWidgetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserWidgetObject_ReturnValue_PropertyAddress, GetUserWidgetObject_FunctionAddress, "ReturnValue");
		GetUserWidgetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserWidgetObject_FunctionAddress, "ReturnValue");
		GetUserWidgetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserWidgetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetUserWidgetObject_IsValid = GetUserWidgetObject_FunctionAddress != IntPtr.Zero && GetUserWidgetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetUserWidgetObject", GetUserWidgetObject_IsValid);
		GetTwoSided_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTwoSided");
		GetTwoSided_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTwoSided_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTwoSided_ReturnValue_PropertyAddress, GetTwoSided_FunctionAddress, "ReturnValue");
		GetTwoSided_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTwoSided_FunctionAddress, "ReturnValue");
		GetTwoSided_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTwoSided_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTwoSided_IsValid = GetTwoSided_FunctionAddress != IntPtr.Zero && GetTwoSided_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetTwoSided", GetTwoSided_IsValid);
		GetTickWhenOffscreen_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTickWhenOffscreen");
		GetTickWhenOffscreen_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTickWhenOffscreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTickWhenOffscreen_ReturnValue_PropertyAddress, GetTickWhenOffscreen_FunctionAddress, "ReturnValue");
		GetTickWhenOffscreen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTickWhenOffscreen_FunctionAddress, "ReturnValue");
		GetTickWhenOffscreen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickWhenOffscreen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTickWhenOffscreen_IsValid = GetTickWhenOffscreen_FunctionAddress != IntPtr.Zero && GetTickWhenOffscreen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetTickWhenOffscreen", GetTickWhenOffscreen_IsValid);
		GetRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRenderTarget");
		GetRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderTarget_ReturnValue_PropertyAddress, GetRenderTarget_FunctionAddress, "ReturnValue");
		GetRenderTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderTarget_FunctionAddress, "ReturnValue");
		GetRenderTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRenderTarget_IsValid = GetRenderTarget_FunctionAddress != IntPtr.Zero && GetRenderTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetRenderTarget", GetRenderTarget_IsValid);
		GetRedrawTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRedrawTime");
		GetRedrawTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRedrawTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRedrawTime_ReturnValue_PropertyAddress, GetRedrawTime_FunctionAddress, "ReturnValue");
		GetRedrawTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRedrawTime_FunctionAddress, "ReturnValue");
		GetRedrawTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRedrawTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRedrawTime_IsValid = GetRedrawTime_FunctionAddress != IntPtr.Zero && GetRedrawTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetRedrawTime", GetRedrawTime_IsValid);
		GetPivot_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPivot");
		GetPivot_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPivot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPivot_ReturnValue_PropertyAddress, GetPivot_FunctionAddress, "ReturnValue");
		GetPivot_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPivot_FunctionAddress, "ReturnValue");
		GetPivot_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPivot_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPivot_IsValid = GetPivot_FunctionAddress != IntPtr.Zero && GetPivot_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetPivot", GetPivot_IsValid);
		GetOwnerPlayer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOwnerPlayer");
		GetOwnerPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnerPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerPlayer_ReturnValue_PropertyAddress, GetOwnerPlayer_FunctionAddress, "ReturnValue");
		GetOwnerPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerPlayer_FunctionAddress, "ReturnValue");
		GetOwnerPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwnerPlayer_IsValid = GetOwnerPlayer_FunctionAddress != IntPtr.Zero && GetOwnerPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetOwnerPlayer", GetOwnerPlayer_IsValid);
		GetMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialInstance");
		GetMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialInstance_ReturnValue_PropertyAddress, GetMaterialInstance_FunctionAddress, "ReturnValue");
		GetMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialInstance_FunctionAddress, "ReturnValue");
		GetMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMaterialInstance_IsValid = GetMaterialInstance_FunctionAddress != IntPtr.Zero && GetMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetMaterialInstance", GetMaterialInstance_IsValid);
		GetManuallyRedraw_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetManuallyRedraw");
		GetManuallyRedraw_ParamsSize = NativeReflection.GetFunctionParamsSize(GetManuallyRedraw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetManuallyRedraw_ReturnValue_PropertyAddress, GetManuallyRedraw_FunctionAddress, "ReturnValue");
		GetManuallyRedraw_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetManuallyRedraw_FunctionAddress, "ReturnValue");
		GetManuallyRedraw_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetManuallyRedraw_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetManuallyRedraw_IsValid = GetManuallyRedraw_FunctionAddress != IntPtr.Zero && GetManuallyRedraw_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetManuallyRedraw", GetManuallyRedraw_IsValid);
		GetGeometryMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGeometryMode");
		GetGeometryMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGeometryMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGeometryMode_ReturnValue_PropertyAddress, GetGeometryMode_FunctionAddress, "ReturnValue");
		GetGeometryMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGeometryMode_FunctionAddress, "ReturnValue");
		GetGeometryMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGeometryMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetGeometryMode_IsValid = GetGeometryMode_FunctionAddress != IntPtr.Zero && GetGeometryMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetGeometryMode", GetGeometryMode_IsValid);
		GetDrawSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDrawSize");
		GetDrawSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDrawSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDrawSize_ReturnValue_PropertyAddress, GetDrawSize_FunctionAddress, "ReturnValue");
		GetDrawSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDrawSize_FunctionAddress, "ReturnValue");
		GetDrawSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDrawSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDrawSize_IsValid = GetDrawSize_FunctionAddress != IntPtr.Zero && GetDrawSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetDrawSize", GetDrawSize_IsValid);
		GetDrawAtDesiredSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDrawAtDesiredSize");
		GetDrawAtDesiredSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDrawAtDesiredSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDrawAtDesiredSize_ReturnValue_PropertyAddress, GetDrawAtDesiredSize_FunctionAddress, "ReturnValue");
		GetDrawAtDesiredSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDrawAtDesiredSize_FunctionAddress, "ReturnValue");
		GetDrawAtDesiredSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDrawAtDesiredSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDrawAtDesiredSize_IsValid = GetDrawAtDesiredSize_FunctionAddress != IntPtr.Zero && GetDrawAtDesiredSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetDrawAtDesiredSize", GetDrawAtDesiredSize_IsValid);
		GetCylinderArcAngle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCylinderArcAngle");
		GetCylinderArcAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCylinderArcAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCylinderArcAngle_ReturnValue_PropertyAddress, GetCylinderArcAngle_FunctionAddress, "ReturnValue");
		GetCylinderArcAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCylinderArcAngle_FunctionAddress, "ReturnValue");
		GetCylinderArcAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCylinderArcAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCylinderArcAngle_IsValid = GetCylinderArcAngle_FunctionAddress != IntPtr.Zero && GetCylinderArcAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetCylinderArcAngle", GetCylinderArcAngle_IsValid);
		GetCurrentDrawSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurrentDrawSize");
		GetCurrentDrawSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentDrawSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentDrawSize_ReturnValue_PropertyAddress, GetCurrentDrawSize_FunctionAddress, "ReturnValue");
		GetCurrentDrawSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentDrawSize_FunctionAddress, "ReturnValue");
		GetCurrentDrawSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentDrawSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentDrawSize_IsValid = GetCurrentDrawSize_FunctionAddress != IntPtr.Zero && GetCurrentDrawSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetComponent:GetCurrentDrawSize", GetCurrentDrawSize_IsValid);
	}
}
