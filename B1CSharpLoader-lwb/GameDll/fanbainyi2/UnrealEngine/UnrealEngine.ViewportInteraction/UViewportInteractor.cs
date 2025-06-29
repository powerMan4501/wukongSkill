using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ViewportInteraction.ViewportInteractor", "ViewportInteraction", UnrealModuleType.Engine)]
public class UViewportInteractor : UObject
{
	private static bool Tick_IsValid;

	private IntPtr Tick_InstanceFunctionAddress;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_DeltaTime_IsValid;

	private static FFieldAddress Tick_DeltaTime_PropertyAddress;

	private static int Tick_DeltaTime_Offset;

	private static bool Shutdown_IsValid;

	private IntPtr Shutdown_InstanceFunctionAddress;

	private static IntPtr Shutdown_FunctionAddress;

	private static int Shutdown_ParamsSize;

	private static bool SetHitResultGizmoFilterMode_IsValid;

	private static IntPtr SetHitResultGizmoFilterMode_FunctionAddress;

	private static int SetHitResultGizmoFilterMode_ParamsSize;

	private static bool SetHitResultGizmoFilterMode_newFilter_IsValid;

	private static FFieldAddress SetHitResultGizmoFilterMode_newFilter_PropertyAddress;

	private static int SetHitResultGizmoFilterMode_newFilter_Offset;

	private static bool SetDraggingMode_IsValid;

	private static IntPtr SetDraggingMode_FunctionAddress;

	private static int SetDraggingMode_ParamsSize;

	private static bool SetDraggingMode_NewDraggingMode_IsValid;

	private static FFieldAddress SetDraggingMode_NewDraggingMode_PropertyAddress;

	private static int SetDraggingMode_NewDraggingMode_Offset;

	private static bool SetCanCarry_IsValid;

	private static IntPtr SetCanCarry_FunctionAddress;

	private static int SetCanCarry_ParamsSize;

	private static bool SetCanCarry_bInCanCarry_IsValid;

	private static FFieldAddress SetCanCarry_bInCanCarry_PropertyAddress;

	private static int SetCanCarry_bInCanCarry_Offset;

	private static bool IsHoveringOverGizmo_IsValid;

	private static IntPtr IsHoveringOverGizmo_FunctionAddress;

	private static int IsHoveringOverGizmo_ParamsSize;

	private static bool IsHoveringOverGizmo_ReturnValue_IsValid;

	private static FFieldAddress IsHoveringOverGizmo_ReturnValue_PropertyAddress;

	private static int IsHoveringOverGizmo_ReturnValue_Offset;

	private static bool HandleInputKey_BP_IsValid;

	private IntPtr HandleInputKey_BP_InstanceFunctionAddress;

	private static IntPtr HandleInputKey_BP_FunctionAddress;

	private static int HandleInputKey_BP_ParamsSize;

	private static bool HandleInputKey_BP_Action_IsValid;

	private static FFieldAddress HandleInputKey_BP_Action_PropertyAddress;

	private static int HandleInputKey_BP_Action_Offset;

	private static bool HandleInputKey_BP_Key_IsValid;

	private static FFieldAddress HandleInputKey_BP_Key_PropertyAddress;

	private static int HandleInputKey_BP_Key_Offset;

	private static bool HandleInputKey_BP_Event_IsValid;

	private static FFieldAddress HandleInputKey_BP_Event_PropertyAddress;

	private static int HandleInputKey_BP_Event_Offset;

	private static bool HandleInputKey_BP_bOutWasHandled_IsValid;

	private static FFieldAddress HandleInputKey_BP_bOutWasHandled_PropertyAddress;

	private static int HandleInputKey_BP_bOutWasHandled_Offset;

	private static bool HandleInputAxis_BP_IsValid;

	private IntPtr HandleInputAxis_BP_InstanceFunctionAddress;

	private static IntPtr HandleInputAxis_BP_FunctionAddress;

	private static int HandleInputAxis_BP_ParamsSize;

	private static bool HandleInputAxis_BP_Action_IsValid;

	private static FFieldAddress HandleInputAxis_BP_Action_PropertyAddress;

	private static int HandleInputAxis_BP_Action_Offset;

	private static bool HandleInputAxis_BP_Key_IsValid;

	private static FFieldAddress HandleInputAxis_BP_Key_PropertyAddress;

	private static int HandleInputAxis_BP_Key_Offset;

	private static bool HandleInputAxis_BP_Delta_IsValid;

	private static FFieldAddress HandleInputAxis_BP_Delta_PropertyAddress;

	private static int HandleInputAxis_BP_Delta_Offset;

	private static bool HandleInputAxis_BP_DeltaTime_IsValid;

	private static FFieldAddress HandleInputAxis_BP_DeltaTime_PropertyAddress;

	private static int HandleInputAxis_BP_DeltaTime_Offset;

	private static bool HandleInputAxis_BP_bOutWasHandled_IsValid;

	private static FFieldAddress HandleInputAxis_BP_bOutWasHandled_PropertyAddress;

	private static int HandleInputAxis_BP_bOutWasHandled_Offset;

	private static bool GetWorldInteraction_IsValid;

	private static IntPtr GetWorldInteraction_FunctionAddress;

	private static int GetWorldInteraction_ParamsSize;

	private static bool GetWorldInteraction_ReturnValue_IsValid;

	private static FFieldAddress GetWorldInteraction_ReturnValue_PropertyAddress;

	private static int GetWorldInteraction_ReturnValue_Offset;

	private static bool GetTransformAndForwardVector_IsValid;

	private static IntPtr GetTransformAndForwardVector_FunctionAddress;

	private static int GetTransformAndForwardVector_ParamsSize;

	private static bool GetTransformAndForwardVector_OutHandTransform_IsValid;

	private static FFieldAddress GetTransformAndForwardVector_OutHandTransform_PropertyAddress;

	private static int GetTransformAndForwardVector_OutHandTransform_Offset;

	private static bool GetTransformAndForwardVector_OutForwardVector_IsValid;

	private static FFieldAddress GetTransformAndForwardVector_OutForwardVector_PropertyAddress;

	private static int GetTransformAndForwardVector_OutForwardVector_Offset;

	private static bool GetTransformAndForwardVector_ReturnValue_IsValid;

	private static FFieldAddress GetTransformAndForwardVector_ReturnValue_PropertyAddress;

	private static int GetTransformAndForwardVector_ReturnValue_Offset;

	private static bool GetTransform_IsValid;

	private static IntPtr GetTransform_FunctionAddress;

	private static int GetTransform_ParamsSize;

	private static bool GetTransform_ReturnValue_IsValid;

	private static FFieldAddress GetTransform_ReturnValue_PropertyAddress;

	private static int GetTransform_ReturnValue_Offset;

	private static bool GetRoomSpaceTransform_IsValid;

	private static IntPtr GetRoomSpaceTransform_FunctionAddress;

	private static int GetRoomSpaceTransform_ParamsSize;

	private static bool GetRoomSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRoomSpaceTransform_ReturnValue_PropertyAddress;

	private static int GetRoomSpaceTransform_ReturnValue_Offset;

	private static bool GetOtherInteractor_IsValid;

	private static IntPtr GetOtherInteractor_FunctionAddress;

	private static int GetOtherInteractor_ParamsSize;

	private static bool GetOtherInteractor_ReturnValue_IsValid;

	private static FFieldAddress GetOtherInteractor_ReturnValue_PropertyAddress;

	private static int GetOtherInteractor_ReturnValue_Offset;

	private static bool GetLastTransform_IsValid;

	private static IntPtr GetLastTransform_FunctionAddress;

	private static int GetLastTransform_ParamsSize;

	private static bool GetLastTransform_ReturnValue_IsValid;

	private static FFieldAddress GetLastTransform_ReturnValue_PropertyAddress;

	private static int GetLastTransform_ReturnValue_Offset;

	private static bool GetLastRoomSpaceTransform_IsValid;

	private static IntPtr GetLastRoomSpaceTransform_FunctionAddress;

	private static int GetLastRoomSpaceTransform_ParamsSize;

	private static bool GetLastRoomSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress GetLastRoomSpaceTransform_ReturnValue_PropertyAddress;

	private static int GetLastRoomSpaceTransform_ReturnValue_Offset;

	private static bool GetLaserPointer_IsValid;

	private static IntPtr GetLaserPointer_FunctionAddress;

	private static int GetLaserPointer_ParamsSize;

	private static bool GetLaserPointer_LaserPointerStart_IsValid;

	private static FFieldAddress GetLaserPointer_LaserPointerStart_PropertyAddress;

	private static int GetLaserPointer_LaserPointerStart_Offset;

	private static bool GetLaserPointer_LaserPointerEnd_IsValid;

	private static FFieldAddress GetLaserPointer_LaserPointerEnd_PropertyAddress;

	private static int GetLaserPointer_LaserPointerEnd_Offset;

	private static bool GetLaserPointer_bEvenIfBlocked_IsValid;

	private static FFieldAddress GetLaserPointer_bEvenIfBlocked_PropertyAddress;

	private static int GetLaserPointer_bEvenIfBlocked_Offset;

	private static bool GetLaserPointer_LaserLengthOverride_IsValid;

	private static FFieldAddress GetLaserPointer_LaserLengthOverride_PropertyAddress;

	private static int GetLaserPointer_LaserLengthOverride_Offset;

	private static bool GetLaserPointer_ReturnValue_IsValid;

	private static FFieldAddress GetLaserPointer_ReturnValue_PropertyAddress;

	private static int GetLaserPointer_ReturnValue_Offset;

	private static bool GetHoverLocation_IsValid;

	private static IntPtr GetHoverLocation_FunctionAddress;

	private static int GetHoverLocation_ParamsSize;

	private static bool GetHoverLocation_ReturnValue_IsValid;

	private static FFieldAddress GetHoverLocation_ReturnValue_PropertyAddress;

	private static int GetHoverLocation_ReturnValue_Offset;

	private static bool GetHitResultGizmoFilterMode_IsValid;

	private static IntPtr GetHitResultGizmoFilterMode_FunctionAddress;

	private static int GetHitResultGizmoFilterMode_ParamsSize;

	private static bool GetHitResultGizmoFilterMode_ReturnValue_IsValid;

	private static FFieldAddress GetHitResultGizmoFilterMode_ReturnValue_PropertyAddress;

	private static int GetHitResultGizmoFilterMode_ReturnValue_Offset;

	private static bool GetDraggingMode_IsValid;

	private static IntPtr GetDraggingMode_FunctionAddress;

	private static int GetDraggingMode_ParamsSize;

	private static bool GetDraggingMode_ReturnValue_IsValid;

	private static FFieldAddress GetDraggingMode_ReturnValue_PropertyAddress;

	private static int GetDraggingMode_ReturnValue_Offset;

	private static bool CanCarry_IsValid;

	private static IntPtr CanCarry_FunctionAddress;

	private static int CanCarry_ParamsSize;

	private static bool CanCarry_ReturnValue_IsValid;

	private static FFieldAddress CanCarry_ReturnValue_PropertyAddress;

	private static int CanCarry_ReturnValue_Offset;

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:Tick")]
	public unsafe void Tick(float DeltaTime)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:Tick");
			return;
		}
		if (Tick_InstanceFunctionAddress == IntPtr.Zero)
		{
			Tick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Tick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_DeltaTime_Offset), 0, Tick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_InstanceFunctionAddress, intPtr, Tick_ParamsSize);
	}

	protected unsafe virtual void Tick_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:Tick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_DeltaTime_Offset), 0, Tick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_FunctionAddress, intPtr, Tick_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:Shutdown")]
	public unsafe void Shutdown()
	{
		CheckDestroyed();
		if (!Shutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:Shutdown");
			return;
		}
		if (Shutdown_InstanceFunctionAddress == IntPtr.Zero)
		{
			Shutdown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Shutdown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Shutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Shutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Shutdown_InstanceFunctionAddress, argsSize: Shutdown_ParamsSize);
	}

	protected unsafe virtual void Shutdown_Implementation()
	{
		CheckDestroyed();
		if (!Shutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:Shutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Shutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Shutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Shutdown_FunctionAddress, argsSize: Shutdown_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:SetHitResultGizmoFilterMode")]
	public unsafe void SetHitResultGizmoFilterMode(EHitResultGizmoFilterMode newFilter)
	{
		CheckDestroyed();
		if (!SetHitResultGizmoFilterMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:SetHitResultGizmoFilterMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHitResultGizmoFilterMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHitResultGizmoFilterMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHitResultGizmoFilterMode>.ToNative(IntPtr.Add(intPtr, SetHitResultGizmoFilterMode_newFilter_Offset), 0, SetHitResultGizmoFilterMode_newFilter_PropertyAddress.Address, newFilter);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHitResultGizmoFilterMode_FunctionAddress, intPtr, SetHitResultGizmoFilterMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:SetDraggingMode")]
	public unsafe void SetDraggingMode(EViewportInteractionDraggingMode NewDraggingMode)
	{
		CheckDestroyed();
		if (!SetDraggingMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:SetDraggingMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDraggingMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDraggingMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EViewportInteractionDraggingMode>.ToNative(IntPtr.Add(intPtr, SetDraggingMode_NewDraggingMode_Offset), 0, SetDraggingMode_NewDraggingMode_PropertyAddress.Address, NewDraggingMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDraggingMode_FunctionAddress, intPtr, SetDraggingMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:SetCanCarry")]
	public unsafe void SetCanCarry(bool bInCanCarry)
	{
		CheckDestroyed();
		if (!SetCanCarry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:SetCanCarry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCanCarry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCanCarry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanCarry_bInCanCarry_Offset), 0, SetCanCarry_bInCanCarry_PropertyAddress.Address, bInCanCarry);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCanCarry_FunctionAddress, intPtr, SetCanCarry_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:IsHoveringOverGizmo")]
	public unsafe bool IsHoveringOverGizmo()
	{
		CheckDestroyed();
		if (!IsHoveringOverGizmo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:IsHoveringOverGizmo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHoveringOverGizmo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHoveringOverGizmo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHoveringOverGizmo_FunctionAddress, intPtr, IsHoveringOverGizmo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHoveringOverGizmo_ReturnValue_Offset), 0, IsHoveringOverGizmo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138938368u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:HandleInputKey_BP")]
	protected unsafe void HandleInputKey_BP(FViewportActionKeyInput Action, FKey Key, EInputEventType Event, out bool bOutWasHandled)
	{
		CheckDestroyed();
		if (!HandleInputKey_BP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:HandleInputKey_BP");
			bOutWasHandled = false;
			return;
		}
		if (HandleInputKey_BP_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleInputKey_BP_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleInputKey_BP");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleInputKey_BP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleInputKey_BP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HandleInputKey_BP_Action_PropertyAddress.Address, intPtr);
		FViewportActionKeyInput.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Action_Offset), 0, HandleInputKey_BP_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(HandleInputKey_BP_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Key_Offset), 0, HandleInputKey_BP_Key_PropertyAddress.Address, Key);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Event_Offset), 0, HandleInputKey_BP_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleInputKey_BP_InstanceFunctionAddress, intPtr, HandleInputKey_BP_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleInputKey_BP_Key_PropertyAddress.Address, intPtr);
		bOutWasHandled = BoolMarshaler.FromNative(IntPtr.Add(intPtr, HandleInputKey_BP_bOutWasHandled_Offset), 0, HandleInputKey_BP_bOutWasHandled_PropertyAddress.Address);
	}

	protected unsafe virtual void HandleInputKey_BP_Implementation(FViewportActionKeyInput Action, FKey Key, EInputEventType Event, out bool bOutWasHandled)
	{
		CheckDestroyed();
		if (!HandleInputKey_BP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:HandleInputKey_BP");
			bOutWasHandled = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleInputKey_BP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleInputKey_BP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HandleInputKey_BP_Action_PropertyAddress.Address, intPtr);
		FViewportActionKeyInput.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Action_Offset), 0, HandleInputKey_BP_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(HandleInputKey_BP_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Key_Offset), 0, HandleInputKey_BP_Key_PropertyAddress.Address, Key);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, HandleInputKey_BP_Event_Offset), 0, HandleInputKey_BP_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleInputKey_BP_FunctionAddress, intPtr, HandleInputKey_BP_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleInputKey_BP_Key_PropertyAddress.Address, intPtr);
		bOutWasHandled = BoolMarshaler.FromNative(IntPtr.Add(intPtr, HandleInputKey_BP_bOutWasHandled_Offset), 0, HandleInputKey_BP_bOutWasHandled_PropertyAddress.Address);
	}

	[UFunction(Flags = 138938368u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:HandleInputAxis_BP")]
	protected unsafe void HandleInputAxis_BP(FViewportActionKeyInput Action, FKey Key, float Delta, float DeltaTime, out bool bOutWasHandled)
	{
		CheckDestroyed();
		if (!HandleInputAxis_BP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:HandleInputAxis_BP");
			bOutWasHandled = false;
			return;
		}
		if (HandleInputAxis_BP_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleInputAxis_BP_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleInputAxis_BP");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleInputAxis_BP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleInputAxis_BP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HandleInputAxis_BP_Action_PropertyAddress.Address, intPtr);
		FViewportActionKeyInput.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Action_Offset), 0, HandleInputAxis_BP_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(HandleInputAxis_BP_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Key_Offset), 0, HandleInputAxis_BP_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Delta_Offset), 0, HandleInputAxis_BP_Delta_PropertyAddress.Address, Delta);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_DeltaTime_Offset), 0, HandleInputAxis_BP_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleInputAxis_BP_InstanceFunctionAddress, intPtr, HandleInputAxis_BP_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleInputAxis_BP_Key_PropertyAddress.Address, intPtr);
		bOutWasHandled = BoolMarshaler.FromNative(IntPtr.Add(intPtr, HandleInputAxis_BP_bOutWasHandled_Offset), 0, HandleInputAxis_BP_bOutWasHandled_PropertyAddress.Address);
	}

	protected unsafe virtual void HandleInputAxis_BP_Implementation(FViewportActionKeyInput Action, FKey Key, float Delta, float DeltaTime, out bool bOutWasHandled)
	{
		CheckDestroyed();
		if (!HandleInputAxis_BP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:HandleInputAxis_BP");
			bOutWasHandled = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleInputAxis_BP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleInputAxis_BP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HandleInputAxis_BP_Action_PropertyAddress.Address, intPtr);
		FViewportActionKeyInput.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Action_Offset), 0, HandleInputAxis_BP_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(HandleInputAxis_BP_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Key_Offset), 0, HandleInputAxis_BP_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_Delta_Offset), 0, HandleInputAxis_BP_Delta_PropertyAddress.Address, Delta);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, HandleInputAxis_BP_DeltaTime_Offset), 0, HandleInputAxis_BP_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleInputAxis_BP_FunctionAddress, intPtr, HandleInputAxis_BP_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleInputAxis_BP_Key_PropertyAddress.Address, intPtr);
		bOutWasHandled = BoolMarshaler.FromNative(IntPtr.Add(intPtr, HandleInputAxis_BP_bOutWasHandled_Offset), 0, HandleInputAxis_BP_bOutWasHandled_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetWorldInteraction")]
	public unsafe UViewportWorldInteraction GetWorldInteraction()
	{
		CheckDestroyed();
		if (!GetWorldInteraction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetWorldInteraction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldInteraction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldInteraction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldInteraction_FunctionAddress, intPtr, GetWorldInteraction_ParamsSize);
		return UObjectMarshaler<UViewportWorldInteraction>.FromNative(IntPtr.Add(intPtr, GetWorldInteraction_ReturnValue_Offset), 0, GetWorldInteraction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetTransformAndForwardVector")]
	public unsafe bool GetTransformAndForwardVector(out FTransform OutHandTransform, out FVector OutForwardVector)
	{
		CheckDestroyed();
		if (!GetTransformAndForwardVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetTransformAndForwardVector");
			OutHandTransform = default(FTransform);
			OutForwardVector = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformAndForwardVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformAndForwardVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformAndForwardVector_OutHandTransform_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformAndForwardVector_FunctionAddress, intPtr, GetTransformAndForwardVector_ParamsSize);
		OutHandTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformAndForwardVector_OutHandTransform_Offset), 0, GetTransformAndForwardVector_OutHandTransform_PropertyAddress.Address);
		OutForwardVector = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTransformAndForwardVector_OutForwardVector_Offset), 0, GetTransformAndForwardVector_OutForwardVector_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTransformAndForwardVector_ReturnValue_Offset), 0, GetTransformAndForwardVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetTransform")]
	public unsafe FTransform GetTransform()
	{
		CheckDestroyed();
		if (!GetTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransform_FunctionAddress, intPtr, GetTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransform_ReturnValue_Offset), 0, GetTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetRoomSpaceTransform")]
	public unsafe FTransform GetRoomSpaceTransform()
	{
		CheckDestroyed();
		if (!GetRoomSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetRoomSpaceTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRoomSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRoomSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRoomSpaceTransform_FunctionAddress, intPtr, GetRoomSpaceTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRoomSpaceTransform_ReturnValue_Offset), 0, GetRoomSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetOtherInteractor")]
	public unsafe UViewportInteractor GetOtherInteractor()
	{
		CheckDestroyed();
		if (!GetOtherInteractor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetOtherInteractor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOtherInteractor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOtherInteractor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOtherInteractor_FunctionAddress, intPtr, GetOtherInteractor_ParamsSize);
		return UObjectMarshaler<UViewportInteractor>.FromNative(IntPtr.Add(intPtr, GetOtherInteractor_ReturnValue_Offset), 0, GetOtherInteractor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetLastTransform")]
	public unsafe FTransform GetLastTransform()
	{
		CheckDestroyed();
		if (!GetLastTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetLastTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastTransform_FunctionAddress, intPtr, GetLastTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLastTransform_ReturnValue_Offset), 0, GetLastTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetLastRoomSpaceTransform")]
	public unsafe FTransform GetLastRoomSpaceTransform()
	{
		CheckDestroyed();
		if (!GetLastRoomSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetLastRoomSpaceTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastRoomSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastRoomSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastRoomSpaceTransform_FunctionAddress, intPtr, GetLastRoomSpaceTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLastRoomSpaceTransform_ReturnValue_Offset), 0, GetLastRoomSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetLaserPointer")]
	public unsafe bool GetLaserPointer(out FVector LaserPointerStart, out FVector LaserPointerEnd, bool bEvenIfBlocked = false, float LaserLengthOverride = 0f)
	{
		CheckDestroyed();
		if (!GetLaserPointer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetLaserPointer");
			LaserPointerStart = default(FVector);
			LaserPointerEnd = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLaserPointer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLaserPointer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLaserPointer_bEvenIfBlocked_Offset), 0, GetLaserPointer_bEvenIfBlocked_PropertyAddress.Address, bEvenIfBlocked);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLaserPointer_LaserLengthOverride_Offset), 0, GetLaserPointer_LaserLengthOverride_PropertyAddress.Address, LaserLengthOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLaserPointer_FunctionAddress, intPtr, GetLaserPointer_ParamsSize);
		LaserPointerStart = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLaserPointer_LaserPointerStart_Offset), 0, GetLaserPointer_LaserPointerStart_PropertyAddress.Address);
		LaserPointerEnd = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLaserPointer_LaserPointerEnd_Offset), 0, GetLaserPointer_LaserPointerEnd_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLaserPointer_ReturnValue_Offset), 0, GetLaserPointer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetHoverLocation")]
	public unsafe FVector GetHoverLocation()
	{
		CheckDestroyed();
		if (!GetHoverLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetHoverLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHoverLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHoverLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHoverLocation_FunctionAddress, intPtr, GetHoverLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetHoverLocation_ReturnValue_Offset), 0, GetHoverLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetHitResultGizmoFilterMode")]
	public unsafe EHitResultGizmoFilterMode GetHitResultGizmoFilterMode()
	{
		CheckDestroyed();
		if (!GetHitResultGizmoFilterMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetHitResultGizmoFilterMode");
			return EHitResultGizmoFilterMode.All;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitResultGizmoFilterMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitResultGizmoFilterMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitResultGizmoFilterMode_FunctionAddress, intPtr, GetHitResultGizmoFilterMode_ParamsSize);
		return EnumMarshaler<EHitResultGizmoFilterMode>.FromNative(IntPtr.Add(intPtr, GetHitResultGizmoFilterMode_ReturnValue_Offset), 0, GetHitResultGizmoFilterMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:GetDraggingMode")]
	public unsafe EViewportInteractionDraggingMode GetDraggingMode()
	{
		CheckDestroyed();
		if (!GetDraggingMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:GetDraggingMode");
			return EViewportInteractionDraggingMode.Nothing;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDraggingMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDraggingMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDraggingMode_FunctionAddress, intPtr, GetDraggingMode_ParamsSize);
		return EnumMarshaler<EViewportInteractionDraggingMode>.FromNative(IntPtr.Add(intPtr, GetDraggingMode_ReturnValue_Offset), 0, GetDraggingMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportInteractor:CanCarry")]
	public unsafe bool CanCarry()
	{
		CheckDestroyed();
		if (!CanCarry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportInteractor:CanCarry");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanCarry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanCarry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanCarry_FunctionAddress, intPtr, CanCarry_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanCarry_ReturnValue_Offset), 0, CanCarry_ReturnValue_PropertyAddress.Address);
	}

	static UViewportInteractor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UViewportInteractor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UViewportInteractor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ViewportInteraction.ViewportInteractor");
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tick_DeltaTime_PropertyAddress, Tick_FunctionAddress, "DeltaTime");
		Tick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "DeltaTime");
		Tick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:Tick", Tick_IsValid);
		Shutdown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Shutdown");
		Shutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(Shutdown_FunctionAddress);
		Shutdown_IsValid = Shutdown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:Shutdown", Shutdown_IsValid);
		SetHitResultGizmoFilterMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetHitResultGizmoFilterMode");
		SetHitResultGizmoFilterMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHitResultGizmoFilterMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHitResultGizmoFilterMode_newFilter_PropertyAddress, SetHitResultGizmoFilterMode_FunctionAddress, "newFilter");
		SetHitResultGizmoFilterMode_newFilter_Offset = NativeReflectionCached.GetPropertyOffset(SetHitResultGizmoFilterMode_FunctionAddress, "newFilter");
		SetHitResultGizmoFilterMode_newFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitResultGizmoFilterMode_FunctionAddress, "newFilter", Classes.FEnumProperty);
		SetHitResultGizmoFilterMode_IsValid = SetHitResultGizmoFilterMode_FunctionAddress != IntPtr.Zero && SetHitResultGizmoFilterMode_newFilter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:SetHitResultGizmoFilterMode", SetHitResultGizmoFilterMode_IsValid);
		SetDraggingMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDraggingMode");
		SetDraggingMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDraggingMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDraggingMode_NewDraggingMode_PropertyAddress, SetDraggingMode_FunctionAddress, "NewDraggingMode");
		SetDraggingMode_NewDraggingMode_Offset = NativeReflectionCached.GetPropertyOffset(SetDraggingMode_FunctionAddress, "NewDraggingMode");
		SetDraggingMode_NewDraggingMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDraggingMode_FunctionAddress, "NewDraggingMode", Classes.FEnumProperty);
		SetDraggingMode_IsValid = SetDraggingMode_FunctionAddress != IntPtr.Zero && SetDraggingMode_NewDraggingMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:SetDraggingMode", SetDraggingMode_IsValid);
		SetCanCarry_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCanCarry");
		SetCanCarry_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCanCarry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCanCarry_bInCanCarry_PropertyAddress, SetCanCarry_FunctionAddress, "bInCanCarry");
		SetCanCarry_bInCanCarry_Offset = NativeReflectionCached.GetPropertyOffset(SetCanCarry_FunctionAddress, "bInCanCarry");
		SetCanCarry_bInCanCarry_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanCarry_FunctionAddress, "bInCanCarry", Classes.FBoolProperty);
		SetCanCarry_IsValid = SetCanCarry_FunctionAddress != IntPtr.Zero && SetCanCarry_bInCanCarry_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:SetCanCarry", SetCanCarry_IsValid);
		IsHoveringOverGizmo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsHoveringOverGizmo");
		IsHoveringOverGizmo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHoveringOverGizmo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHoveringOverGizmo_ReturnValue_PropertyAddress, IsHoveringOverGizmo_FunctionAddress, "ReturnValue");
		IsHoveringOverGizmo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHoveringOverGizmo_FunctionAddress, "ReturnValue");
		IsHoveringOverGizmo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHoveringOverGizmo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHoveringOverGizmo_IsValid = IsHoveringOverGizmo_FunctionAddress != IntPtr.Zero && IsHoveringOverGizmo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:IsHoveringOverGizmo", IsHoveringOverGizmo_IsValid);
		HandleInputKey_BP_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleInputKey_BP");
		HandleInputKey_BP_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleInputKey_BP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleInputKey_BP_Action_PropertyAddress, HandleInputKey_BP_FunctionAddress, "Action");
		HandleInputKey_BP_Action_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputKey_BP_FunctionAddress, "Action");
		HandleInputKey_BP_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputKey_BP_FunctionAddress, "Action", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputKey_BP_Key_PropertyAddress, HandleInputKey_BP_FunctionAddress, "Key");
		HandleInputKey_BP_Key_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputKey_BP_FunctionAddress, "Key");
		HandleInputKey_BP_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputKey_BP_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputKey_BP_Event_PropertyAddress, HandleInputKey_BP_FunctionAddress, "Event");
		HandleInputKey_BP_Event_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputKey_BP_FunctionAddress, "Event");
		HandleInputKey_BP_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputKey_BP_FunctionAddress, "Event", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputKey_BP_bOutWasHandled_PropertyAddress, HandleInputKey_BP_FunctionAddress, "bOutWasHandled");
		HandleInputKey_BP_bOutWasHandled_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputKey_BP_FunctionAddress, "bOutWasHandled");
		HandleInputKey_BP_bOutWasHandled_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputKey_BP_FunctionAddress, "bOutWasHandled", Classes.FBoolProperty);
		HandleInputKey_BP_IsValid = HandleInputKey_BP_FunctionAddress != IntPtr.Zero && HandleInputKey_BP_Action_IsValid && HandleInputKey_BP_Key_IsValid && HandleInputKey_BP_Event_IsValid && HandleInputKey_BP_bOutWasHandled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:HandleInputKey_BP", HandleInputKey_BP_IsValid);
		HandleInputAxis_BP_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleInputAxis_BP");
		HandleInputAxis_BP_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleInputAxis_BP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleInputAxis_BP_Action_PropertyAddress, HandleInputAxis_BP_FunctionAddress, "Action");
		HandleInputAxis_BP_Action_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputAxis_BP_FunctionAddress, "Action");
		HandleInputAxis_BP_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputAxis_BP_FunctionAddress, "Action", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputAxis_BP_Key_PropertyAddress, HandleInputAxis_BP_FunctionAddress, "Key");
		HandleInputAxis_BP_Key_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputAxis_BP_FunctionAddress, "Key");
		HandleInputAxis_BP_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputAxis_BP_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputAxis_BP_Delta_PropertyAddress, HandleInputAxis_BP_FunctionAddress, "Delta");
		HandleInputAxis_BP_Delta_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputAxis_BP_FunctionAddress, "Delta");
		HandleInputAxis_BP_Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputAxis_BP_FunctionAddress, "Delta", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputAxis_BP_DeltaTime_PropertyAddress, HandleInputAxis_BP_FunctionAddress, "DeltaTime");
		HandleInputAxis_BP_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputAxis_BP_FunctionAddress, "DeltaTime");
		HandleInputAxis_BP_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputAxis_BP_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleInputAxis_BP_bOutWasHandled_PropertyAddress, HandleInputAxis_BP_FunctionAddress, "bOutWasHandled");
		HandleInputAxis_BP_bOutWasHandled_Offset = NativeReflectionCached.GetPropertyOffset(HandleInputAxis_BP_FunctionAddress, "bOutWasHandled");
		HandleInputAxis_BP_bOutWasHandled_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleInputAxis_BP_FunctionAddress, "bOutWasHandled", Classes.FBoolProperty);
		HandleInputAxis_BP_IsValid = HandleInputAxis_BP_FunctionAddress != IntPtr.Zero && HandleInputAxis_BP_Action_IsValid && HandleInputAxis_BP_Key_IsValid && HandleInputAxis_BP_Delta_IsValid && HandleInputAxis_BP_DeltaTime_IsValid && HandleInputAxis_BP_bOutWasHandled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:HandleInputAxis_BP", HandleInputAxis_BP_IsValid);
		GetWorldInteraction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldInteraction");
		GetWorldInteraction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldInteraction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldInteraction_ReturnValue_PropertyAddress, GetWorldInteraction_FunctionAddress, "ReturnValue");
		GetWorldInteraction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldInteraction_FunctionAddress, "ReturnValue");
		GetWorldInteraction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldInteraction_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldInteraction_IsValid = GetWorldInteraction_FunctionAddress != IntPtr.Zero && GetWorldInteraction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetWorldInteraction", GetWorldInteraction_IsValid);
		GetTransformAndForwardVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTransformAndForwardVector");
		GetTransformAndForwardVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformAndForwardVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAndForwardVector_OutHandTransform_PropertyAddress, GetTransformAndForwardVector_FunctionAddress, "OutHandTransform");
		GetTransformAndForwardVector_OutHandTransform_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAndForwardVector_FunctionAddress, "OutHandTransform");
		GetTransformAndForwardVector_OutHandTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAndForwardVector_FunctionAddress, "OutHandTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAndForwardVector_OutForwardVector_PropertyAddress, GetTransformAndForwardVector_FunctionAddress, "OutForwardVector");
		GetTransformAndForwardVector_OutForwardVector_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAndForwardVector_FunctionAddress, "OutForwardVector");
		GetTransformAndForwardVector_OutForwardVector_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAndForwardVector_FunctionAddress, "OutForwardVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformAndForwardVector_ReturnValue_PropertyAddress, GetTransformAndForwardVector_FunctionAddress, "ReturnValue");
		GetTransformAndForwardVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformAndForwardVector_FunctionAddress, "ReturnValue");
		GetTransformAndForwardVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformAndForwardVector_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTransformAndForwardVector_IsValid = GetTransformAndForwardVector_FunctionAddress != IntPtr.Zero && GetTransformAndForwardVector_OutHandTransform_IsValid && GetTransformAndForwardVector_OutForwardVector_IsValid && GetTransformAndForwardVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetTransformAndForwardVector", GetTransformAndForwardVector_IsValid);
		GetTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTransform");
		GetTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransform_ReturnValue_PropertyAddress, GetTransform_FunctionAddress, "ReturnValue");
		GetTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransform_FunctionAddress, "ReturnValue");
		GetTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransform_IsValid = GetTransform_FunctionAddress != IntPtr.Zero && GetTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetTransform", GetTransform_IsValid);
		GetRoomSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRoomSpaceTransform");
		GetRoomSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRoomSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRoomSpaceTransform_ReturnValue_PropertyAddress, GetRoomSpaceTransform_FunctionAddress, "ReturnValue");
		GetRoomSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRoomSpaceTransform_FunctionAddress, "ReturnValue");
		GetRoomSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRoomSpaceTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRoomSpaceTransform_IsValid = GetRoomSpaceTransform_FunctionAddress != IntPtr.Zero && GetRoomSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetRoomSpaceTransform", GetRoomSpaceTransform_IsValid);
		GetOtherInteractor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOtherInteractor");
		GetOtherInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOtherInteractor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOtherInteractor_ReturnValue_PropertyAddress, GetOtherInteractor_FunctionAddress, "ReturnValue");
		GetOtherInteractor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOtherInteractor_FunctionAddress, "ReturnValue");
		GetOtherInteractor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOtherInteractor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOtherInteractor_IsValid = GetOtherInteractor_FunctionAddress != IntPtr.Zero && GetOtherInteractor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetOtherInteractor", GetOtherInteractor_IsValid);
		GetLastTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLastTransform");
		GetLastTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastTransform_ReturnValue_PropertyAddress, GetLastTransform_FunctionAddress, "ReturnValue");
		GetLastTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastTransform_FunctionAddress, "ReturnValue");
		GetLastTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastTransform_IsValid = GetLastTransform_FunctionAddress != IntPtr.Zero && GetLastTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetLastTransform", GetLastTransform_IsValid);
		GetLastRoomSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLastRoomSpaceTransform");
		GetLastRoomSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastRoomSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastRoomSpaceTransform_ReturnValue_PropertyAddress, GetLastRoomSpaceTransform_FunctionAddress, "ReturnValue");
		GetLastRoomSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastRoomSpaceTransform_FunctionAddress, "ReturnValue");
		GetLastRoomSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastRoomSpaceTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastRoomSpaceTransform_IsValid = GetLastRoomSpaceTransform_FunctionAddress != IntPtr.Zero && GetLastRoomSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetLastRoomSpaceTransform", GetLastRoomSpaceTransform_IsValid);
		GetLaserPointer_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLaserPointer");
		GetLaserPointer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLaserPointer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLaserPointer_LaserPointerStart_PropertyAddress, GetLaserPointer_FunctionAddress, "LaserPointerStart");
		GetLaserPointer_LaserPointerStart_Offset = NativeReflectionCached.GetPropertyOffset(GetLaserPointer_FunctionAddress, "LaserPointerStart");
		GetLaserPointer_LaserPointerStart_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaserPointer_FunctionAddress, "LaserPointerStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaserPointer_LaserPointerEnd_PropertyAddress, GetLaserPointer_FunctionAddress, "LaserPointerEnd");
		GetLaserPointer_LaserPointerEnd_Offset = NativeReflectionCached.GetPropertyOffset(GetLaserPointer_FunctionAddress, "LaserPointerEnd");
		GetLaserPointer_LaserPointerEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaserPointer_FunctionAddress, "LaserPointerEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaserPointer_bEvenIfBlocked_PropertyAddress, GetLaserPointer_FunctionAddress, "bEvenIfBlocked");
		GetLaserPointer_bEvenIfBlocked_Offset = NativeReflectionCached.GetPropertyOffset(GetLaserPointer_FunctionAddress, "bEvenIfBlocked");
		GetLaserPointer_bEvenIfBlocked_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaserPointer_FunctionAddress, "bEvenIfBlocked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaserPointer_LaserLengthOverride_PropertyAddress, GetLaserPointer_FunctionAddress, "LaserLengthOverride");
		GetLaserPointer_LaserLengthOverride_Offset = NativeReflectionCached.GetPropertyOffset(GetLaserPointer_FunctionAddress, "LaserLengthOverride");
		GetLaserPointer_LaserLengthOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaserPointer_FunctionAddress, "LaserLengthOverride", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaserPointer_ReturnValue_PropertyAddress, GetLaserPointer_FunctionAddress, "ReturnValue");
		GetLaserPointer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLaserPointer_FunctionAddress, "ReturnValue");
		GetLaserPointer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaserPointer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLaserPointer_IsValid = GetLaserPointer_FunctionAddress != IntPtr.Zero && GetLaserPointer_LaserPointerStart_IsValid && GetLaserPointer_LaserPointerEnd_IsValid && GetLaserPointer_bEvenIfBlocked_IsValid && GetLaserPointer_LaserLengthOverride_IsValid && GetLaserPointer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetLaserPointer", GetLaserPointer_IsValid);
		GetHoverLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHoverLocation");
		GetHoverLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHoverLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHoverLocation_ReturnValue_PropertyAddress, GetHoverLocation_FunctionAddress, "ReturnValue");
		GetHoverLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHoverLocation_FunctionAddress, "ReturnValue");
		GetHoverLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHoverLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetHoverLocation_IsValid = GetHoverLocation_FunctionAddress != IntPtr.Zero && GetHoverLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetHoverLocation", GetHoverLocation_IsValid);
		GetHitResultGizmoFilterMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHitResultGizmoFilterMode");
		GetHitResultGizmoFilterMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitResultGizmoFilterMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultGizmoFilterMode_ReturnValue_PropertyAddress, GetHitResultGizmoFilterMode_FunctionAddress, "ReturnValue");
		GetHitResultGizmoFilterMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultGizmoFilterMode_FunctionAddress, "ReturnValue");
		GetHitResultGizmoFilterMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultGizmoFilterMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetHitResultGizmoFilterMode_IsValid = GetHitResultGizmoFilterMode_FunctionAddress != IntPtr.Zero && GetHitResultGizmoFilterMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetHitResultGizmoFilterMode", GetHitResultGizmoFilterMode_IsValid);
		GetDraggingMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDraggingMode");
		GetDraggingMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDraggingMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDraggingMode_ReturnValue_PropertyAddress, GetDraggingMode_FunctionAddress, "ReturnValue");
		GetDraggingMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDraggingMode_FunctionAddress, "ReturnValue");
		GetDraggingMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDraggingMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDraggingMode_IsValid = GetDraggingMode_FunctionAddress != IntPtr.Zero && GetDraggingMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:GetDraggingMode", GetDraggingMode_IsValid);
		CanCarry_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanCarry");
		CanCarry_ParamsSize = NativeReflection.GetFunctionParamsSize(CanCarry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanCarry_ReturnValue_PropertyAddress, CanCarry_FunctionAddress, "ReturnValue");
		CanCarry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanCarry_FunctionAddress, "ReturnValue");
		CanCarry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCarry_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanCarry_IsValid = CanCarry_FunctionAddress != IntPtr.Zero && CanCarry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportInteractor:CanCarry", CanCarry_IsValid);
	}
}
