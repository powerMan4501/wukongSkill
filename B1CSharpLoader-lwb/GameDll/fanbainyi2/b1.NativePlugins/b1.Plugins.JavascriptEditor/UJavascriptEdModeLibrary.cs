using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEdModeLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StartTracking_IsValid;

	private static IntPtr StartTracking_FunctionAddress;

	private static int StartTracking_ParamsSize;

	private static bool StartTracking_Tools_IsValid;

	private static FFieldAddress StartTracking_Tools_PropertyAddress;

	private static int StartTracking_Tools_Offset;

	private static bool StartTracking_Viewport_IsValid;

	private static FFieldAddress StartTracking_Viewport_PropertyAddress;

	private static int StartTracking_Viewport_Offset;

	private static bool StartTracking_ReturnValue_IsValid;

	private static FFieldAddress StartTracking_ReturnValue_PropertyAddress;

	private static int StartTracking_ReturnValue_Offset;

	private static bool SetDefaultMode_IsValid;

	private static IntPtr SetDefaultMode_FunctionAddress;

	private static int SetDefaultMode_ParamsSize;

	private static bool SetDefaultMode_Tools_IsValid;

	private static FFieldAddress SetDefaultMode_Tools_PropertyAddress;

	private static int SetDefaultMode_Tools_Offset;

	private static bool SetDefaultMode_DefaultID_IsValid;

	private static FFieldAddress SetDefaultMode_DefaultID_PropertyAddress;

	private static int SetDefaultMode_DefaultID_Offset;

	private static bool SetCurrentWidgetAxis_IsValid;

	private static IntPtr SetCurrentWidgetAxis_FunctionAddress;

	private static int SetCurrentWidgetAxis_ParamsSize;

	private static bool SetCurrentWidgetAxis_Mode_IsValid;

	private static FFieldAddress SetCurrentWidgetAxis_Mode_PropertyAddress;

	private static int SetCurrentWidgetAxis_Mode_Offset;

	private static bool SetCurrentWidgetAxis_InAxis_IsValid;

	private static FFieldAddress SetCurrentWidgetAxis_InAxis_PropertyAddress;

	private static int SetCurrentWidgetAxis_InAxis_Offset;

	private static bool SelectNone_IsValid;

	private static IntPtr SelectNone_FunctionAddress;

	private static int SelectNone_ParamsSize;

	private static bool SelectNone_Mode_IsValid;

	private static FFieldAddress SelectNone_Mode_PropertyAddress;

	private static int SelectNone_Mode_Offset;

	private static bool MirrorSelectGroupActorOnAxis_IsValid;

	private static IntPtr MirrorSelectGroupActorOnAxis_FunctionAddress;

	private static int MirrorSelectGroupActorOnAxis_ParamsSize;

	private static bool MirrorSelectGroupActorOnAxis_InMirrorScale_IsValid;

	private static FFieldAddress MirrorSelectGroupActorOnAxis_InMirrorScale_PropertyAddress;

	private static int MirrorSelectGroupActorOnAxis_InMirrorScale_Offset;

	private static bool IsTracking_IsValid;

	private static IntPtr IsTracking_FunctionAddress;

	private static int IsTracking_ParamsSize;

	private static bool IsTracking_Tools_IsValid;

	private static FFieldAddress IsTracking_Tools_PropertyAddress;

	private static int IsTracking_Tools_Offset;

	private static bool IsTracking_ReturnValue_IsValid;

	private static FFieldAddress IsTracking_ReturnValue_PropertyAddress;

	private static int IsTracking_ReturnValue_Offset;

	private static bool IsModeActive_IsValid;

	private static IntPtr IsModeActive_FunctionAddress;

	private static int IsModeActive_ParamsSize;

	private static bool IsModeActive_Tools_IsValid;

	private static FFieldAddress IsModeActive_Tools_PropertyAddress;

	private static int IsModeActive_Tools_Offset;

	private static bool IsModeActive_InID_IsValid;

	private static FFieldAddress IsModeActive_InID_PropertyAddress;

	private static int IsModeActive_InID_Offset;

	private static bool IsModeActive_ReturnValue_IsValid;

	private static FFieldAddress IsModeActive_ReturnValue_PropertyAddress;

	private static int IsModeActive_ReturnValue_Offset;

	private static bool IsDefaultModeActive_IsValid;

	private static IntPtr IsDefaultModeActive_FunctionAddress;

	private static int IsDefaultModeActive_ParamsSize;

	private static bool IsDefaultModeActive_Tools_IsValid;

	private static FFieldAddress IsDefaultModeActive_Tools_PropertyAddress;

	private static int IsDefaultModeActive_Tools_Offset;

	private static bool IsDefaultModeActive_ReturnValue_IsValid;

	private static FFieldAddress IsDefaultModeActive_ReturnValue_PropertyAddress;

	private static int IsDefaultModeActive_ReturnValue_Offset;

	private static bool GetModeManager_IsValid;

	private static IntPtr GetModeManager_FunctionAddress;

	private static int GetModeManager_ParamsSize;

	private static bool GetModeManager_Mode_IsValid;

	private static FFieldAddress GetModeManager_Mode_PropertyAddress;

	private static int GetModeManager_Mode_Offset;

	private static bool GetModeManager_ReturnValue_IsValid;

	private static FFieldAddress GetModeManager_ReturnValue_PropertyAddress;

	private static int GetModeManager_ReturnValue_Offset;

	private static bool GetLevelEditorViewportRotGridEnabledSetting_IsValid;

	private static IntPtr GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress;

	private static int GetLevelEditorViewportRotGridEnabledSetting_ParamsSize;

	private static bool GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_IsValid;

	private static FFieldAddress GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_PropertyAddress;

	private static int GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_Offset;

	private static bool GetLevelEditorModeTools_IsValid;

	private static IntPtr GetLevelEditorModeTools_FunctionAddress;

	private static int GetLevelEditorModeTools_ParamsSize;

	private static bool GetLevelEditorModeTools_ReturnValue_IsValid;

	private static FFieldAddress GetLevelEditorModeTools_ReturnValue_PropertyAddress;

	private static int GetLevelEditorModeTools_ReturnValue_Offset;

	private static bool GetHitProxy_IsValid;

	private static IntPtr GetHitProxy_FunctionAddress;

	private static int GetHitProxy_ParamsSize;

	private static bool GetHitProxy_Viewport_IsValid;

	private static FFieldAddress GetHitProxy_Viewport_PropertyAddress;

	private static int GetHitProxy_Viewport_Offset;

	private static bool GetHitProxy_ReturnValue_IsValid;

	private static FFieldAddress GetHitProxy_ReturnValue_PropertyAddress;

	private static int GetHitProxy_ReturnValue_Offset;

	private static bool GetCurrentWidgetAxis_IsValid;

	private static IntPtr GetCurrentWidgetAxis_FunctionAddress;

	private static int GetCurrentWidgetAxis_ParamsSize;

	private static bool GetCurrentWidgetAxis_Mode_IsValid;

	private static FFieldAddress GetCurrentWidgetAxis_Mode_PropertyAddress;

	private static int GetCurrentWidgetAxis_Mode_Offset;

	private static bool GetCurrentWidgetAxis_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentWidgetAxis_ReturnValue_PropertyAddress;

	private static int GetCurrentWidgetAxis_ReturnValue_Offset;

	private static bool EnsureNotInMode_IsValid;

	private static IntPtr EnsureNotInMode_FunctionAddress;

	private static int EnsureNotInMode_ParamsSize;

	private static bool EnsureNotInMode_Tools_IsValid;

	private static FFieldAddress EnsureNotInMode_Tools_PropertyAddress;

	private static int EnsureNotInMode_Tools_Offset;

	private static bool EnsureNotInMode_ModeID_IsValid;

	private static FFieldAddress EnsureNotInMode_ModeID_PropertyAddress;

	private static int EnsureNotInMode_ModeID_Offset;

	private static bool EnsureNotInMode_ErrorMsg_IsValid;

	private static FFieldAddress EnsureNotInMode_ErrorMsg_PropertyAddress;

	private static int EnsureNotInMode_ErrorMsg_Offset;

	private static bool EnsureNotInMode_bNotifyUser_IsValid;

	private static FFieldAddress EnsureNotInMode_bNotifyUser_PropertyAddress;

	private static int EnsureNotInMode_bNotifyUser_Offset;

	private static bool EnsureNotInMode_ReturnValue_IsValid;

	private static FFieldAddress EnsureNotInMode_ReturnValue_PropertyAddress;

	private static int EnsureNotInMode_ReturnValue_Offset;

	private static bool EndTracking_IsValid;

	private static IntPtr EndTracking_FunctionAddress;

	private static int EndTracking_ParamsSize;

	private static bool EndTracking_Tools_IsValid;

	private static FFieldAddress EndTracking_Tools_PropertyAddress;

	private static int EndTracking_Tools_Offset;

	private static bool EndTracking_Viewport_IsValid;

	private static FFieldAddress EndTracking_Viewport_PropertyAddress;

	private static int EndTracking_Viewport_Offset;

	private static bool EndTracking_ReturnValue_IsValid;

	private static FFieldAddress EndTracking_ReturnValue_PropertyAddress;

	private static int EndTracking_ReturnValue_Offset;

	private static bool DestroyMode_IsValid;

	private static IntPtr DestroyMode_FunctionAddress;

	private static int DestroyMode_ParamsSize;

	private static bool DestroyMode_Tools_IsValid;

	private static FFieldAddress DestroyMode_Tools_PropertyAddress;

	private static int DestroyMode_Tools_Offset;

	private static bool DestroyMode_InID_IsValid;

	private static FFieldAddress DestroyMode_InID_PropertyAddress;

	private static int DestroyMode_InID_Offset;

	private static bool DeactivateMode_IsValid;

	private static IntPtr DeactivateMode_FunctionAddress;

	private static int DeactivateMode_ParamsSize;

	private static bool DeactivateMode_Tools_IsValid;

	private static FFieldAddress DeactivateMode_Tools_PropertyAddress;

	private static int DeactivateMode_Tools_Offset;

	private static bool DeactivateMode_InID_IsValid;

	private static FFieldAddress DeactivateMode_InID_PropertyAddress;

	private static int DeactivateMode_InID_Offset;

	private static bool DeactivateAllModes_IsValid;

	private static IntPtr DeactivateAllModes_FunctionAddress;

	private static int DeactivateAllModes_ParamsSize;

	private static bool DeactivateAllModes_Tools_IsValid;

	private static FFieldAddress DeactivateAllModes_Tools_PropertyAddress;

	private static int DeactivateAllModes_Tools_Offset;

	private static bool CustomInputWidgetDeltaForScaleTool_IsValid;

	private static IntPtr CustomInputWidgetDeltaForScaleTool_FunctionAddress;

	private static int CustomInputWidgetDeltaForScaleTool_ParamsSize;

	private static bool CustomInputWidgetDeltaForScaleTool_InViewport_IsValid;

	private static FFieldAddress CustomInputWidgetDeltaForScaleTool_InViewport_PropertyAddress;

	private static int CustomInputWidgetDeltaForScaleTool_InViewport_Offset;

	private static bool CustomInputWidgetDeltaForScaleTool_Drag_IsValid;

	private static FFieldAddress CustomInputWidgetDeltaForScaleTool_Drag_PropertyAddress;

	private static int CustomInputWidgetDeltaForScaleTool_Drag_Offset;

	private static bool CustomInputWidgetDeltaForScaleTool_Rot_IsValid;

	private static FFieldAddress CustomInputWidgetDeltaForScaleTool_Rot_PropertyAddress;

	private static int CustomInputWidgetDeltaForScaleTool_Rot_Offset;

	private static bool CustomInputWidgetDeltaForScaleTool_Scale_IsValid;

	private static FFieldAddress CustomInputWidgetDeltaForScaleTool_Scale_PropertyAddress;

	private static int CustomInputWidgetDeltaForScaleTool_Scale_Offset;

	private static bool CustomInputWidgetDeltaForScaleTool_ReturnValue_IsValid;

	private static FFieldAddress CustomInputWidgetDeltaForScaleTool_ReturnValue_PropertyAddress;

	private static int CustomInputWidgetDeltaForScaleTool_ReturnValue_Offset;

	private static bool ActivateMode_IsValid;

	private static IntPtr ActivateMode_FunctionAddress;

	private static int ActivateMode_ParamsSize;

	private static bool ActivateMode_Tools_IsValid;

	private static FFieldAddress ActivateMode_Tools_PropertyAddress;

	private static int ActivateMode_Tools_Offset;

	private static bool ActivateMode_InID_IsValid;

	private static FFieldAddress ActivateMode_InID_PropertyAddress;

	private static int ActivateMode_InID_Offset;

	private static bool ActivateMode_bToggle_IsValid;

	private static FFieldAddress ActivateMode_bToggle_PropertyAddress;

	private static int ActivateMode_bToggle_Offset;

	private static bool ActivateDefaultMode_IsValid;

	private static IntPtr ActivateDefaultMode_FunctionAddress;

	private static int ActivateDefaultMode_ParamsSize;

	private static bool ActivateDefaultMode_Tools_IsValid;

	private static FFieldAddress ActivateDefaultMode_Tools_PropertyAddress;

	private static int ActivateDefaultMode_Tools_Offset;

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:StartTracking")]
	public unsafe static bool StartTracking(FJavascriptEditorModeTools Tools, FJavascriptEdViewport Viewport)
	{
		if (!StartTracking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:StartTracking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartTracking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartTracking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StartTracking_Tools_PropertyAddress.Address, intPtr);
		FJavascriptEditorModeTools.ToNative(IntPtr.Add(intPtr, StartTracking_Tools_Offset), 0, StartTracking_Tools_PropertyAddress.Address, Tools);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, StartTracking_Viewport_Offset), 0, StartTracking_Viewport_PropertyAddress.Address, Viewport);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartTracking_FunctionAddress, intPtr, StartTracking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartTracking_ReturnValue_Offset), 0, StartTracking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetDefaultMode")]
	public unsafe static void SetDefaultMode(out FJavascriptEditorModeTools Tools, FName DefaultID)
	{
		if (!SetDefaultMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetDefaultMode");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDefaultMode_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDefaultMode_DefaultID_Offset), 0, SetDefaultMode_DefaultID_PropertyAddress.Address, DefaultID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDefaultMode_FunctionAddress, intPtr, SetDefaultMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, SetDefaultMode_Tools_Offset), 0, SetDefaultMode_Tools_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetCurrentWidgetAxis")]
	public unsafe static void SetCurrentWidgetAxis(FJavascriptEditorMode Mode, int InAxis)
	{
		if (!SetCurrentWidgetAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetCurrentWidgetAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentWidgetAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentWidgetAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurrentWidgetAxis_Mode_PropertyAddress.Address, intPtr);
		FJavascriptEditorMode.ToNative(IntPtr.Add(intPtr, SetCurrentWidgetAxis_Mode_Offset), 0, SetCurrentWidgetAxis_Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurrentWidgetAxis_InAxis_Offset), 0, SetCurrentWidgetAxis_InAxis_PropertyAddress.Address, InAxis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentWidgetAxis_FunctionAddress, intPtr, SetCurrentWidgetAxis_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:SelectNone")]
	public unsafe static void SelectNone(FJavascriptEditorMode Mode)
	{
		if (!SelectNone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:SelectNone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SelectNone_Mode_PropertyAddress.Address, intPtr);
		FJavascriptEditorMode.ToNative(IntPtr.Add(intPtr, SelectNone_Mode_Offset), 0, SelectNone_Mode_PropertyAddress.Address, Mode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectNone_FunctionAddress, intPtr, SelectNone_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:MirrorSelectGroupActorOnAxis")]
	public unsafe static void MirrorSelectGroupActorOnAxis(FVector InMirrorScale)
	{
		if (!MirrorSelectGroupActorOnAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:MirrorSelectGroupActorOnAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MirrorSelectGroupActorOnAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MirrorSelectGroupActorOnAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MirrorSelectGroupActorOnAxis_InMirrorScale_Offset), 0, MirrorSelectGroupActorOnAxis_InMirrorScale_PropertyAddress.Address, InMirrorScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MirrorSelectGroupActorOnAxis_FunctionAddress, intPtr, MirrorSelectGroupActorOnAxis_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsTracking")]
	public unsafe static bool IsTracking(FJavascriptEditorModeTools Tools)
	{
		if (!IsTracking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsTracking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTracking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTracking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTracking_Tools_PropertyAddress.Address, intPtr);
		FJavascriptEditorModeTools.ToNative(IntPtr.Add(intPtr, IsTracking_Tools_Offset), 0, IsTracking_Tools_PropertyAddress.Address, Tools);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTracking_FunctionAddress, intPtr, IsTracking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTracking_ReturnValue_Offset), 0, IsTracking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsModeActive")]
	public unsafe static bool IsModeActive(out FJavascriptEditorModeTools Tools, FName InID)
	{
		if (!IsModeActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsModeActive");
			Tools = default(FJavascriptEditorModeTools);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsModeActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsModeActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsModeActive_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsModeActive_InID_Offset), 0, IsModeActive_InID_PropertyAddress.Address, InID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsModeActive_FunctionAddress, intPtr, IsModeActive_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, IsModeActive_Tools_Offset), 0, IsModeActive_Tools_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsModeActive_ReturnValue_Offset), 0, IsModeActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsDefaultModeActive")]
	public unsafe static bool IsDefaultModeActive(out FJavascriptEditorModeTools Tools)
	{
		if (!IsDefaultModeActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsDefaultModeActive");
			Tools = default(FJavascriptEditorModeTools);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDefaultModeActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDefaultModeActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsDefaultModeActive_Tools_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDefaultModeActive_FunctionAddress, intPtr, IsDefaultModeActive_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, IsDefaultModeActive_Tools_Offset), 0, IsDefaultModeActive_Tools_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDefaultModeActive_ReturnValue_Offset), 0, IsDefaultModeActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetModeManager")]
	public unsafe static FJavascriptEditorModeTools GetModeManager(FJavascriptEditorMode Mode)
	{
		if (!GetModeManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetModeManager");
			return default(FJavascriptEditorModeTools);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModeManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModeManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetModeManager_Mode_PropertyAddress.Address, intPtr);
		FJavascriptEditorMode.ToNative(IntPtr.Add(intPtr, GetModeManager_Mode_Offset), 0, GetModeManager_Mode_PropertyAddress.Address, Mode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetModeManager_FunctionAddress, intPtr, GetModeManager_ParamsSize);
		return FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, GetModeManager_ReturnValue_Offset), 0, GetModeManager_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorViewportRotGridEnabledSetting")]
	public unsafe static bool GetLevelEditorViewportRotGridEnabledSetting()
	{
		if (!GetLevelEditorViewportRotGridEnabledSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorViewportRotGridEnabledSetting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelEditorViewportRotGridEnabledSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelEditorViewportRotGridEnabledSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress, intPtr, GetLevelEditorViewportRotGridEnabledSetting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_Offset), 0, GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorModeTools")]
	public unsafe static FJavascriptEditorModeTools GetLevelEditorModeTools()
	{
		if (!GetLevelEditorModeTools_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorModeTools");
			return default(FJavascriptEditorModeTools);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelEditorModeTools_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelEditorModeTools_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelEditorModeTools_FunctionAddress, intPtr, GetLevelEditorModeTools_ParamsSize);
		return FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, GetLevelEditorModeTools_ReturnValue_Offset), 0, GetLevelEditorModeTools_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetHitProxy")]
	public unsafe static FJavascriptHitProxy GetHitProxy(FJavascriptEdViewport Viewport)
	{
		if (!GetHitProxy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetHitProxy");
			return default(FJavascriptHitProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitProxy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitProxy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, GetHitProxy_Viewport_Offset), 0, GetHitProxy_Viewport_PropertyAddress.Address, Viewport);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHitProxy_FunctionAddress, intPtr, GetHitProxy_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptHitProxy>.FromNative(IntPtr.Add(intPtr, GetHitProxy_ReturnValue_Offset), 0, GetHitProxy_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetCurrentWidgetAxis")]
	public unsafe static int GetCurrentWidgetAxis(FJavascriptEditorMode Mode)
	{
		if (!GetCurrentWidgetAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetCurrentWidgetAxis");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentWidgetAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentWidgetAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCurrentWidgetAxis_Mode_PropertyAddress.Address, intPtr);
		FJavascriptEditorMode.ToNative(IntPtr.Add(intPtr, GetCurrentWidgetAxis_Mode_Offset), 0, GetCurrentWidgetAxis_Mode_PropertyAddress.Address, Mode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentWidgetAxis_FunctionAddress, intPtr, GetCurrentWidgetAxis_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentWidgetAxis_ReturnValue_Offset), 0, GetCurrentWidgetAxis_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:EnsureNotInMode")]
	public unsafe static bool EnsureNotInMode(out FJavascriptEditorModeTools Tools, FName ModeID, FText ErrorMsg, bool bNotifyUser)
	{
		if (!EnsureNotInMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:EnsureNotInMode");
			Tools = default(FJavascriptEditorModeTools);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnsureNotInMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnsureNotInMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EnsureNotInMode_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EnsureNotInMode_ModeID_Offset), 0, EnsureNotInMode_ModeID_PropertyAddress.Address, ModeID);
		NativeReflection.InitializeValue_InContainer(EnsureNotInMode_ErrorMsg_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, EnsureNotInMode_ErrorMsg_Offset), 0, EnsureNotInMode_ErrorMsg_PropertyAddress.Address, ErrorMsg);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnsureNotInMode_bNotifyUser_Offset), 0, EnsureNotInMode_bNotifyUser_PropertyAddress.Address, bNotifyUser);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnsureNotInMode_FunctionAddress, intPtr, EnsureNotInMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, EnsureNotInMode_Tools_Offset), 0, EnsureNotInMode_Tools_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EnsureNotInMode_ErrorMsg_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EnsureNotInMode_ReturnValue_Offset), 0, EnsureNotInMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:EndTracking")]
	public unsafe static bool EndTracking(FJavascriptEditorModeTools Tools, FJavascriptEdViewport Viewport)
	{
		if (!EndTracking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:EndTracking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndTracking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndTracking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EndTracking_Tools_PropertyAddress.Address, intPtr);
		FJavascriptEditorModeTools.ToNative(IntPtr.Add(intPtr, EndTracking_Tools_Offset), 0, EndTracking_Tools_PropertyAddress.Address, Tools);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, EndTracking_Viewport_Offset), 0, EndTracking_Viewport_PropertyAddress.Address, Viewport);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndTracking_FunctionAddress, intPtr, EndTracking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EndTracking_ReturnValue_Offset), 0, EndTracking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:DestroyMode")]
	public unsafe static void DestroyMode(out FJavascriptEditorModeTools Tools, FName InID)
	{
		if (!DestroyMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:DestroyMode");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DestroyMode_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DestroyMode_InID_Offset), 0, DestroyMode_InID_PropertyAddress.Address, InID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyMode_FunctionAddress, intPtr, DestroyMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, DestroyMode_Tools_Offset), 0, DestroyMode_Tools_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateMode")]
	public unsafe static void DeactivateMode(out FJavascriptEditorModeTools Tools, FName InID)
	{
		if (!DeactivateMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateMode");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeactivateMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeactivateMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeactivateMode_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DeactivateMode_InID_Offset), 0, DeactivateMode_InID_PropertyAddress.Address, InID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeactivateMode_FunctionAddress, intPtr, DeactivateMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, DeactivateMode_Tools_Offset), 0, DeactivateMode_Tools_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateAllModes")]
	public unsafe static void DeactivateAllModes(out FJavascriptEditorModeTools Tools)
	{
		if (!DeactivateAllModes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateAllModes");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeactivateAllModes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeactivateAllModes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeactivateAllModes_Tools_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeactivateAllModes_FunctionAddress, intPtr, DeactivateAllModes_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, DeactivateAllModes_Tools_Offset), 0, DeactivateAllModes_Tools_PropertyAddress.Address);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:CustomInputWidgetDeltaForScaleTool")]
	public unsafe static bool CustomInputWidgetDeltaForScaleTool(FJavascriptEdViewport InViewport, FVector Drag, FRotator Rot, FVector Scale)
	{
		if (!CustomInputWidgetDeltaForScaleTool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:CustomInputWidgetDeltaForScaleTool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomInputWidgetDeltaForScaleTool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomInputWidgetDeltaForScaleTool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, CustomInputWidgetDeltaForScaleTool_InViewport_Offset), 0, CustomInputWidgetDeltaForScaleTool_InViewport_PropertyAddress.Address, InViewport);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CustomInputWidgetDeltaForScaleTool_Drag_Offset), 0, CustomInputWidgetDeltaForScaleTool_Drag_PropertyAddress.Address, Drag);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CustomInputWidgetDeltaForScaleTool_Rot_Offset), 0, CustomInputWidgetDeltaForScaleTool_Rot_PropertyAddress.Address, Rot);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CustomInputWidgetDeltaForScaleTool_Scale_Offset), 0, CustomInputWidgetDeltaForScaleTool_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, intPtr, CustomInputWidgetDeltaForScaleTool_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CustomInputWidgetDeltaForScaleTool_ReturnValue_Offset), 0, CustomInputWidgetDeltaForScaleTool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateMode")]
	public unsafe static void ActivateMode(out FJavascriptEditorModeTools Tools, FName InID, bool bToggle)
	{
		if (!ActivateMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateMode");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActivateMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActivateMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ActivateMode_Tools_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ActivateMode_InID_Offset), 0, ActivateMode_InID_PropertyAddress.Address, InID);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActivateMode_bToggle_Offset), 0, ActivateMode_bToggle_PropertyAddress.Address, bToggle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActivateMode_FunctionAddress, intPtr, ActivateMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, ActivateMode_Tools_Offset), 0, ActivateMode_Tools_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateDefaultMode")]
	public unsafe static void ActivateDefaultMode(out FJavascriptEditorModeTools Tools)
	{
		if (!ActivateDefaultMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateDefaultMode");
			Tools = default(FJavascriptEditorModeTools);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActivateDefaultMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActivateDefaultMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ActivateDefaultMode_Tools_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActivateDefaultMode_FunctionAddress, intPtr, ActivateDefaultMode_ParamsSize);
		Tools = FJavascriptEditorModeTools.FromNative(IntPtr.Add(intPtr, ActivateDefaultMode_Tools_Offset), 0, ActivateDefaultMode_Tools_PropertyAddress.Address);
	}

	static UJavascriptEdModeLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEdModeLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEdModeLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEdModeLibrary");
		StartTracking_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartTracking");
		StartTracking_ParamsSize = NativeReflection.GetFunctionParamsSize(StartTracking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartTracking_Tools_PropertyAddress, StartTracking_FunctionAddress, "Tools");
		StartTracking_Tools_Offset = NativeReflectionCached.GetPropertyOffset(StartTracking_FunctionAddress, "Tools");
		StartTracking_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(StartTracking_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartTracking_Viewport_PropertyAddress, StartTracking_FunctionAddress, "Viewport");
		StartTracking_Viewport_Offset = NativeReflectionCached.GetPropertyOffset(StartTracking_FunctionAddress, "Viewport");
		StartTracking_Viewport_IsValid = NativeReflectionCached.ValidatePropertyClass(StartTracking_FunctionAddress, "Viewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartTracking_ReturnValue_PropertyAddress, StartTracking_FunctionAddress, "ReturnValue");
		StartTracking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartTracking_FunctionAddress, "ReturnValue");
		StartTracking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartTracking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartTracking_IsValid = StartTracking_FunctionAddress != IntPtr.Zero && StartTracking_Tools_IsValid && StartTracking_Viewport_IsValid && StartTracking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:StartTracking", StartTracking_IsValid);
		SetDefaultMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDefaultMode");
		SetDefaultMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultMode_Tools_PropertyAddress, SetDefaultMode_FunctionAddress, "Tools");
		SetDefaultMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultMode_FunctionAddress, "Tools");
		SetDefaultMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultMode_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultMode_DefaultID_PropertyAddress, SetDefaultMode_FunctionAddress, "DefaultID");
		SetDefaultMode_DefaultID_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultMode_FunctionAddress, "DefaultID");
		SetDefaultMode_DefaultID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultMode_FunctionAddress, "DefaultID", Classes.FNameProperty);
		SetDefaultMode_IsValid = SetDefaultMode_FunctionAddress != IntPtr.Zero && SetDefaultMode_Tools_IsValid && SetDefaultMode_DefaultID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetDefaultMode", SetDefaultMode_IsValid);
		SetCurrentWidgetAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentWidgetAxis");
		SetCurrentWidgetAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentWidgetAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentWidgetAxis_Mode_PropertyAddress, SetCurrentWidgetAxis_FunctionAddress, "Mode");
		SetCurrentWidgetAxis_Mode_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentWidgetAxis_FunctionAddress, "Mode");
		SetCurrentWidgetAxis_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentWidgetAxis_FunctionAddress, "Mode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentWidgetAxis_InAxis_PropertyAddress, SetCurrentWidgetAxis_FunctionAddress, "InAxis");
		SetCurrentWidgetAxis_InAxis_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentWidgetAxis_FunctionAddress, "InAxis");
		SetCurrentWidgetAxis_InAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentWidgetAxis_FunctionAddress, "InAxis", Classes.FIntProperty);
		SetCurrentWidgetAxis_IsValid = SetCurrentWidgetAxis_FunctionAddress != IntPtr.Zero && SetCurrentWidgetAxis_Mode_IsValid && SetCurrentWidgetAxis_InAxis_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:SetCurrentWidgetAxis", SetCurrentWidgetAxis_IsValid);
		SelectNone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectNone");
		SelectNone_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectNone_Mode_PropertyAddress, SelectNone_FunctionAddress, "Mode");
		SelectNone_Mode_Offset = NativeReflectionCached.GetPropertyOffset(SelectNone_FunctionAddress, "Mode");
		SelectNone_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNone_FunctionAddress, "Mode", Classes.FStructProperty);
		SelectNone_IsValid = SelectNone_FunctionAddress != IntPtr.Zero && SelectNone_Mode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:SelectNone", SelectNone_IsValid);
		MirrorSelectGroupActorOnAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MirrorSelectGroupActorOnAxis");
		MirrorSelectGroupActorOnAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(MirrorSelectGroupActorOnAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MirrorSelectGroupActorOnAxis_InMirrorScale_PropertyAddress, MirrorSelectGroupActorOnAxis_FunctionAddress, "InMirrorScale");
		MirrorSelectGroupActorOnAxis_InMirrorScale_Offset = NativeReflectionCached.GetPropertyOffset(MirrorSelectGroupActorOnAxis_FunctionAddress, "InMirrorScale");
		MirrorSelectGroupActorOnAxis_InMirrorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(MirrorSelectGroupActorOnAxis_FunctionAddress, "InMirrorScale", Classes.FStructProperty);
		MirrorSelectGroupActorOnAxis_IsValid = MirrorSelectGroupActorOnAxis_FunctionAddress != IntPtr.Zero && MirrorSelectGroupActorOnAxis_InMirrorScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:MirrorSelectGroupActorOnAxis", MirrorSelectGroupActorOnAxis_IsValid);
		IsTracking_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTracking");
		IsTracking_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTracking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTracking_Tools_PropertyAddress, IsTracking_FunctionAddress, "Tools");
		IsTracking_Tools_Offset = NativeReflectionCached.GetPropertyOffset(IsTracking_FunctionAddress, "Tools");
		IsTracking_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTracking_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTracking_ReturnValue_PropertyAddress, IsTracking_FunctionAddress, "ReturnValue");
		IsTracking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTracking_FunctionAddress, "ReturnValue");
		IsTracking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTracking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTracking_IsValid = IsTracking_FunctionAddress != IntPtr.Zero && IsTracking_Tools_IsValid && IsTracking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsTracking", IsTracking_IsValid);
		IsModeActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsModeActive");
		IsModeActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsModeActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsModeActive_Tools_PropertyAddress, IsModeActive_FunctionAddress, "Tools");
		IsModeActive_Tools_Offset = NativeReflectionCached.GetPropertyOffset(IsModeActive_FunctionAddress, "Tools");
		IsModeActive_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(IsModeActive_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsModeActive_InID_PropertyAddress, IsModeActive_FunctionAddress, "InID");
		IsModeActive_InID_Offset = NativeReflectionCached.GetPropertyOffset(IsModeActive_FunctionAddress, "InID");
		IsModeActive_InID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsModeActive_FunctionAddress, "InID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsModeActive_ReturnValue_PropertyAddress, IsModeActive_FunctionAddress, "ReturnValue");
		IsModeActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsModeActive_FunctionAddress, "ReturnValue");
		IsModeActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsModeActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsModeActive_IsValid = IsModeActive_FunctionAddress != IntPtr.Zero && IsModeActive_Tools_IsValid && IsModeActive_InID_IsValid && IsModeActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsModeActive", IsModeActive_IsValid);
		IsDefaultModeActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDefaultModeActive");
		IsDefaultModeActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDefaultModeActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDefaultModeActive_Tools_PropertyAddress, IsDefaultModeActive_FunctionAddress, "Tools");
		IsDefaultModeActive_Tools_Offset = NativeReflectionCached.GetPropertyOffset(IsDefaultModeActive_FunctionAddress, "Tools");
		IsDefaultModeActive_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefaultModeActive_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDefaultModeActive_ReturnValue_PropertyAddress, IsDefaultModeActive_FunctionAddress, "ReturnValue");
		IsDefaultModeActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDefaultModeActive_FunctionAddress, "ReturnValue");
		IsDefaultModeActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefaultModeActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDefaultModeActive_IsValid = IsDefaultModeActive_FunctionAddress != IntPtr.Zero && IsDefaultModeActive_Tools_IsValid && IsDefaultModeActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:IsDefaultModeActive", IsDefaultModeActive_IsValid);
		GetModeManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetModeManager");
		GetModeManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModeManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetModeManager_Mode_PropertyAddress, GetModeManager_FunctionAddress, "Mode");
		GetModeManager_Mode_Offset = NativeReflectionCached.GetPropertyOffset(GetModeManager_FunctionAddress, "Mode");
		GetModeManager_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModeManager_FunctionAddress, "Mode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetModeManager_ReturnValue_PropertyAddress, GetModeManager_FunctionAddress, "ReturnValue");
		GetModeManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetModeManager_FunctionAddress, "ReturnValue");
		GetModeManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModeManager_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetModeManager_IsValid = GetModeManager_FunctionAddress != IntPtr.Zero && GetModeManager_Mode_IsValid && GetModeManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetModeManager", GetModeManager_IsValid);
		GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelEditorViewportRotGridEnabledSetting");
		GetLevelEditorViewportRotGridEnabledSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_PropertyAddress, GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress, "ReturnValue");
		GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress, "ReturnValue");
		GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLevelEditorViewportRotGridEnabledSetting_IsValid = GetLevelEditorViewportRotGridEnabledSetting_FunctionAddress != IntPtr.Zero && GetLevelEditorViewportRotGridEnabledSetting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorViewportRotGridEnabledSetting", GetLevelEditorViewportRotGridEnabledSetting_IsValid);
		GetLevelEditorModeTools_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelEditorModeTools");
		GetLevelEditorModeTools_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelEditorModeTools_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelEditorModeTools_ReturnValue_PropertyAddress, GetLevelEditorModeTools_FunctionAddress, "ReturnValue");
		GetLevelEditorModeTools_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelEditorModeTools_FunctionAddress, "ReturnValue");
		GetLevelEditorModeTools_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelEditorModeTools_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelEditorModeTools_IsValid = GetLevelEditorModeTools_FunctionAddress != IntPtr.Zero && GetLevelEditorModeTools_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetLevelEditorModeTools", GetLevelEditorModeTools_IsValid);
		GetHitProxy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHitProxy");
		GetHitProxy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitProxy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitProxy_Viewport_PropertyAddress, GetHitProxy_FunctionAddress, "Viewport");
		GetHitProxy_Viewport_Offset = NativeReflectionCached.GetPropertyOffset(GetHitProxy_FunctionAddress, "Viewport");
		GetHitProxy_Viewport_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitProxy_FunctionAddress, "Viewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitProxy_ReturnValue_PropertyAddress, GetHitProxy_FunctionAddress, "ReturnValue");
		GetHitProxy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitProxy_FunctionAddress, "ReturnValue");
		GetHitProxy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitProxy_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetHitProxy_IsValid = GetHitProxy_FunctionAddress != IntPtr.Zero && GetHitProxy_Viewport_IsValid && GetHitProxy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetHitProxy", GetHitProxy_IsValid);
		GetCurrentWidgetAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentWidgetAxis");
		GetCurrentWidgetAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentWidgetAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentWidgetAxis_Mode_PropertyAddress, GetCurrentWidgetAxis_FunctionAddress, "Mode");
		GetCurrentWidgetAxis_Mode_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentWidgetAxis_FunctionAddress, "Mode");
		GetCurrentWidgetAxis_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentWidgetAxis_FunctionAddress, "Mode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentWidgetAxis_ReturnValue_PropertyAddress, GetCurrentWidgetAxis_FunctionAddress, "ReturnValue");
		GetCurrentWidgetAxis_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentWidgetAxis_FunctionAddress, "ReturnValue");
		GetCurrentWidgetAxis_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentWidgetAxis_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentWidgetAxis_IsValid = GetCurrentWidgetAxis_FunctionAddress != IntPtr.Zero && GetCurrentWidgetAxis_Mode_IsValid && GetCurrentWidgetAxis_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:GetCurrentWidgetAxis", GetCurrentWidgetAxis_IsValid);
		EnsureNotInMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnsureNotInMode");
		EnsureNotInMode_ParamsSize = NativeReflection.GetFunctionParamsSize(EnsureNotInMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnsureNotInMode_Tools_PropertyAddress, EnsureNotInMode_FunctionAddress, "Tools");
		EnsureNotInMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(EnsureNotInMode_FunctionAddress, "Tools");
		EnsureNotInMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureNotInMode_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EnsureNotInMode_ModeID_PropertyAddress, EnsureNotInMode_FunctionAddress, "ModeID");
		EnsureNotInMode_ModeID_Offset = NativeReflectionCached.GetPropertyOffset(EnsureNotInMode_FunctionAddress, "ModeID");
		EnsureNotInMode_ModeID_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureNotInMode_FunctionAddress, "ModeID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EnsureNotInMode_ErrorMsg_PropertyAddress, EnsureNotInMode_FunctionAddress, "ErrorMsg");
		EnsureNotInMode_ErrorMsg_Offset = NativeReflectionCached.GetPropertyOffset(EnsureNotInMode_FunctionAddress, "ErrorMsg");
		EnsureNotInMode_ErrorMsg_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureNotInMode_FunctionAddress, "ErrorMsg", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref EnsureNotInMode_bNotifyUser_PropertyAddress, EnsureNotInMode_FunctionAddress, "bNotifyUser");
		EnsureNotInMode_bNotifyUser_Offset = NativeReflectionCached.GetPropertyOffset(EnsureNotInMode_FunctionAddress, "bNotifyUser");
		EnsureNotInMode_bNotifyUser_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureNotInMode_FunctionAddress, "bNotifyUser", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnsureNotInMode_ReturnValue_PropertyAddress, EnsureNotInMode_FunctionAddress, "ReturnValue");
		EnsureNotInMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EnsureNotInMode_FunctionAddress, "ReturnValue");
		EnsureNotInMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EnsureNotInMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EnsureNotInMode_IsValid = EnsureNotInMode_FunctionAddress != IntPtr.Zero && EnsureNotInMode_Tools_IsValid && EnsureNotInMode_ModeID_IsValid && EnsureNotInMode_ErrorMsg_IsValid && EnsureNotInMode_bNotifyUser_IsValid && EnsureNotInMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:EnsureNotInMode", EnsureNotInMode_IsValid);
		EndTracking_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndTracking");
		EndTracking_ParamsSize = NativeReflection.GetFunctionParamsSize(EndTracking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndTracking_Tools_PropertyAddress, EndTracking_FunctionAddress, "Tools");
		EndTracking_Tools_Offset = NativeReflectionCached.GetPropertyOffset(EndTracking_FunctionAddress, "Tools");
		EndTracking_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(EndTracking_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EndTracking_Viewport_PropertyAddress, EndTracking_FunctionAddress, "Viewport");
		EndTracking_Viewport_Offset = NativeReflectionCached.GetPropertyOffset(EndTracking_FunctionAddress, "Viewport");
		EndTracking_Viewport_IsValid = NativeReflectionCached.ValidatePropertyClass(EndTracking_FunctionAddress, "Viewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EndTracking_ReturnValue_PropertyAddress, EndTracking_FunctionAddress, "ReturnValue");
		EndTracking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EndTracking_FunctionAddress, "ReturnValue");
		EndTracking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EndTracking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EndTracking_IsValid = EndTracking_FunctionAddress != IntPtr.Zero && EndTracking_Tools_IsValid && EndTracking_Viewport_IsValid && EndTracking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:EndTracking", EndTracking_IsValid);
		DestroyMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyMode");
		DestroyMode_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyMode_Tools_PropertyAddress, DestroyMode_FunctionAddress, "Tools");
		DestroyMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(DestroyMode_FunctionAddress, "Tools");
		DestroyMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyMode_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DestroyMode_InID_PropertyAddress, DestroyMode_FunctionAddress, "InID");
		DestroyMode_InID_Offset = NativeReflectionCached.GetPropertyOffset(DestroyMode_FunctionAddress, "InID");
		DestroyMode_InID_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyMode_FunctionAddress, "InID", Classes.FNameProperty);
		DestroyMode_IsValid = DestroyMode_FunctionAddress != IntPtr.Zero && DestroyMode_Tools_IsValid && DestroyMode_InID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:DestroyMode", DestroyMode_IsValid);
		DeactivateMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeactivateMode");
		DeactivateMode_ParamsSize = NativeReflection.GetFunctionParamsSize(DeactivateMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeactivateMode_Tools_PropertyAddress, DeactivateMode_FunctionAddress, "Tools");
		DeactivateMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(DeactivateMode_FunctionAddress, "Tools");
		DeactivateMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(DeactivateMode_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeactivateMode_InID_PropertyAddress, DeactivateMode_FunctionAddress, "InID");
		DeactivateMode_InID_Offset = NativeReflectionCached.GetPropertyOffset(DeactivateMode_FunctionAddress, "InID");
		DeactivateMode_InID_IsValid = NativeReflectionCached.ValidatePropertyClass(DeactivateMode_FunctionAddress, "InID", Classes.FNameProperty);
		DeactivateMode_IsValid = DeactivateMode_FunctionAddress != IntPtr.Zero && DeactivateMode_Tools_IsValid && DeactivateMode_InID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateMode", DeactivateMode_IsValid);
		DeactivateAllModes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeactivateAllModes");
		DeactivateAllModes_ParamsSize = NativeReflection.GetFunctionParamsSize(DeactivateAllModes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeactivateAllModes_Tools_PropertyAddress, DeactivateAllModes_FunctionAddress, "Tools");
		DeactivateAllModes_Tools_Offset = NativeReflectionCached.GetPropertyOffset(DeactivateAllModes_FunctionAddress, "Tools");
		DeactivateAllModes_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(DeactivateAllModes_FunctionAddress, "Tools", Classes.FStructProperty);
		DeactivateAllModes_IsValid = DeactivateAllModes_FunctionAddress != IntPtr.Zero && DeactivateAllModes_Tools_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:DeactivateAllModes", DeactivateAllModes_IsValid);
		CustomInputWidgetDeltaForScaleTool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CustomInputWidgetDeltaForScaleTool");
		CustomInputWidgetDeltaForScaleTool_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomInputWidgetDeltaForScaleTool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomInputWidgetDeltaForScaleTool_InViewport_PropertyAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, "InViewport");
		CustomInputWidgetDeltaForScaleTool_InViewport_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "InViewport");
		CustomInputWidgetDeltaForScaleTool_InViewport_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "InViewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomInputWidgetDeltaForScaleTool_Drag_PropertyAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Drag");
		CustomInputWidgetDeltaForScaleTool_Drag_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Drag");
		CustomInputWidgetDeltaForScaleTool_Drag_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Drag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomInputWidgetDeltaForScaleTool_Rot_PropertyAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Rot");
		CustomInputWidgetDeltaForScaleTool_Rot_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Rot");
		CustomInputWidgetDeltaForScaleTool_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Rot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomInputWidgetDeltaForScaleTool_Scale_PropertyAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Scale");
		CustomInputWidgetDeltaForScaleTool_Scale_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Scale");
		CustomInputWidgetDeltaForScaleTool_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomInputWidgetDeltaForScaleTool_ReturnValue_PropertyAddress, CustomInputWidgetDeltaForScaleTool_FunctionAddress, "ReturnValue");
		CustomInputWidgetDeltaForScaleTool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "ReturnValue");
		CustomInputWidgetDeltaForScaleTool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputWidgetDeltaForScaleTool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CustomInputWidgetDeltaForScaleTool_IsValid = CustomInputWidgetDeltaForScaleTool_FunctionAddress != IntPtr.Zero && CustomInputWidgetDeltaForScaleTool_InViewport_IsValid && CustomInputWidgetDeltaForScaleTool_Drag_IsValid && CustomInputWidgetDeltaForScaleTool_Rot_IsValid && CustomInputWidgetDeltaForScaleTool_Scale_IsValid && CustomInputWidgetDeltaForScaleTool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:CustomInputWidgetDeltaForScaleTool", CustomInputWidgetDeltaForScaleTool_IsValid);
		ActivateMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActivateMode");
		ActivateMode_ParamsSize = NativeReflection.GetFunctionParamsSize(ActivateMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActivateMode_Tools_PropertyAddress, ActivateMode_FunctionAddress, "Tools");
		ActivateMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(ActivateMode_FunctionAddress, "Tools");
		ActivateMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateMode_FunctionAddress, "Tools", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ActivateMode_InID_PropertyAddress, ActivateMode_FunctionAddress, "InID");
		ActivateMode_InID_Offset = NativeReflectionCached.GetPropertyOffset(ActivateMode_FunctionAddress, "InID");
		ActivateMode_InID_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateMode_FunctionAddress, "InID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ActivateMode_bToggle_PropertyAddress, ActivateMode_FunctionAddress, "bToggle");
		ActivateMode_bToggle_Offset = NativeReflectionCached.GetPropertyOffset(ActivateMode_FunctionAddress, "bToggle");
		ActivateMode_bToggle_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateMode_FunctionAddress, "bToggle", Classes.FBoolProperty);
		ActivateMode_IsValid = ActivateMode_FunctionAddress != IntPtr.Zero && ActivateMode_Tools_IsValid && ActivateMode_InID_IsValid && ActivateMode_bToggle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateMode", ActivateMode_IsValid);
		ActivateDefaultMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActivateDefaultMode");
		ActivateDefaultMode_ParamsSize = NativeReflection.GetFunctionParamsSize(ActivateDefaultMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActivateDefaultMode_Tools_PropertyAddress, ActivateDefaultMode_FunctionAddress, "Tools");
		ActivateDefaultMode_Tools_Offset = NativeReflectionCached.GetPropertyOffset(ActivateDefaultMode_FunctionAddress, "Tools");
		ActivateDefaultMode_Tools_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateDefaultMode_FunctionAddress, "Tools", Classes.FStructProperty);
		ActivateDefaultMode_IsValid = ActivateDefaultMode_FunctionAddress != IntPtr.Zero && ActivateDefaultMode_Tools_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEdModeLibrary:ActivateDefaultMode", ActivateDefaultMode_IsValid);
	}
}
