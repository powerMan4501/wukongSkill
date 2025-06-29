using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;
using UnrealEngine.TypedElementRuntime;

namespace UnrealEngine.Engine;

public sealed class ITypedElementWorldInterfaceImpl : IInterfaceImpl, ITypedElementWorldInterface, IInterface
{
	private static bool SetWorldTransform_IsValid;

	private IntPtr SetWorldTransform_InstanceFunctionAddress;

	private static IntPtr SetWorldTransform_FunctionAddress;

	private static int SetWorldTransform_ParamsSize;

	private static bool SetWorldTransform_InElementHandle_IsValid;

	private static FFieldAddress SetWorldTransform_InElementHandle_PropertyAddress;

	private static int SetWorldTransform_InElementHandle_Offset;

	private static bool SetWorldTransform_InTransform_IsValid;

	private static FFieldAddress SetWorldTransform_InTransform_PropertyAddress;

	private static int SetWorldTransform_InTransform_Offset;

	private static bool SetWorldTransform_ReturnValue_IsValid;

	private static FFieldAddress SetWorldTransform_ReturnValue_PropertyAddress;

	private static int SetWorldTransform_ReturnValue_Offset;

	private static bool SetRelativeTransform_IsValid;

	private IntPtr SetRelativeTransform_InstanceFunctionAddress;

	private static IntPtr SetRelativeTransform_FunctionAddress;

	private static int SetRelativeTransform_ParamsSize;

	private static bool SetRelativeTransform_InElementHandle_IsValid;

	private static FFieldAddress SetRelativeTransform_InElementHandle_PropertyAddress;

	private static int SetRelativeTransform_InElementHandle_Offset;

	private static bool SetRelativeTransform_InTransform_IsValid;

	private static FFieldAddress SetRelativeTransform_InTransform_PropertyAddress;

	private static int SetRelativeTransform_InTransform_Offset;

	private static bool SetRelativeTransform_ReturnValue_IsValid;

	private static FFieldAddress SetRelativeTransform_ReturnValue_PropertyAddress;

	private static int SetRelativeTransform_ReturnValue_Offset;

	private static bool SetPivotOffset_IsValid;

	private IntPtr SetPivotOffset_InstanceFunctionAddress;

	private static IntPtr SetPivotOffset_FunctionAddress;

	private static int SetPivotOffset_ParamsSize;

	private static bool SetPivotOffset_InElementHandle_IsValid;

	private static FFieldAddress SetPivotOffset_InElementHandle_PropertyAddress;

	private static int SetPivotOffset_InElementHandle_Offset;

	private static bool SetPivotOffset_InPivotOffset_IsValid;

	private static FFieldAddress SetPivotOffset_InPivotOffset_PropertyAddress;

	private static int SetPivotOffset_InPivotOffset_Offset;

	private static bool SetPivotOffset_ReturnValue_IsValid;

	private static FFieldAddress SetPivotOffset_ReturnValue_PropertyAddress;

	private static int SetPivotOffset_ReturnValue_Offset;

	private static bool NotifyMovementStarted_IsValid;

	private IntPtr NotifyMovementStarted_InstanceFunctionAddress;

	private static IntPtr NotifyMovementStarted_FunctionAddress;

	private static int NotifyMovementStarted_ParamsSize;

	private static bool NotifyMovementStarted_InElementHandle_IsValid;

	private static FFieldAddress NotifyMovementStarted_InElementHandle_PropertyAddress;

	private static int NotifyMovementStarted_InElementHandle_Offset;

	private static bool NotifyMovementOngoing_IsValid;

	private IntPtr NotifyMovementOngoing_InstanceFunctionAddress;

	private static IntPtr NotifyMovementOngoing_FunctionAddress;

	private static int NotifyMovementOngoing_ParamsSize;

	private static bool NotifyMovementOngoing_InElementHandle_IsValid;

	private static FFieldAddress NotifyMovementOngoing_InElementHandle_PropertyAddress;

	private static int NotifyMovementOngoing_InElementHandle_Offset;

	private static bool NotifyMovementEnded_IsValid;

	private IntPtr NotifyMovementEnded_InstanceFunctionAddress;

	private static IntPtr NotifyMovementEnded_FunctionAddress;

	private static int NotifyMovementEnded_ParamsSize;

	private static bool NotifyMovementEnded_InElementHandle_IsValid;

	private static FFieldAddress NotifyMovementEnded_InElementHandle_PropertyAddress;

	private static int NotifyMovementEnded_InElementHandle_Offset;

	private static bool IsTemplateElement_IsValid;

	private IntPtr IsTemplateElement_InstanceFunctionAddress;

	private static IntPtr IsTemplateElement_FunctionAddress;

	private static int IsTemplateElement_ParamsSize;

	private static bool IsTemplateElement_InElementHandle_IsValid;

	private static FFieldAddress IsTemplateElement_InElementHandle_PropertyAddress;

	private static int IsTemplateElement_InElementHandle_Offset;

	private static bool IsTemplateElement_ReturnValue_IsValid;

	private static FFieldAddress IsTemplateElement_ReturnValue_PropertyAddress;

	private static int IsTemplateElement_ReturnValue_Offset;

	private static bool GetWorldTransform_IsValid;

	private IntPtr GetWorldTransform_InstanceFunctionAddress;

	private static IntPtr GetWorldTransform_FunctionAddress;

	private static int GetWorldTransform_ParamsSize;

	private static bool GetWorldTransform_InElementHandle_IsValid;

	private static FFieldAddress GetWorldTransform_InElementHandle_PropertyAddress;

	private static int GetWorldTransform_InElementHandle_Offset;

	private static bool GetWorldTransform_OutTransform_IsValid;

	private static FFieldAddress GetWorldTransform_OutTransform_PropertyAddress;

	private static int GetWorldTransform_OutTransform_Offset;

	private static bool GetWorldTransform_ReturnValue_IsValid;

	private static FFieldAddress GetWorldTransform_ReturnValue_PropertyAddress;

	private static int GetWorldTransform_ReturnValue_Offset;

	private static bool GetRelativeTransform_IsValid;

	private IntPtr GetRelativeTransform_InstanceFunctionAddress;

	private static IntPtr GetRelativeTransform_FunctionAddress;

	private static int GetRelativeTransform_ParamsSize;

	private static bool GetRelativeTransform_InElementHandle_IsValid;

	private static FFieldAddress GetRelativeTransform_InElementHandle_PropertyAddress;

	private static int GetRelativeTransform_InElementHandle_Offset;

	private static bool GetRelativeTransform_OutTransform_IsValid;

	private static FFieldAddress GetRelativeTransform_OutTransform_PropertyAddress;

	private static int GetRelativeTransform_OutTransform_Offset;

	private static bool GetRelativeTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRelativeTransform_ReturnValue_PropertyAddress;

	private static int GetRelativeTransform_ReturnValue_Offset;

	private static bool GetPivotOffset_IsValid;

	private IntPtr GetPivotOffset_InstanceFunctionAddress;

	private static IntPtr GetPivotOffset_FunctionAddress;

	private static int GetPivotOffset_ParamsSize;

	private static bool GetPivotOffset_InElementHandle_IsValid;

	private static FFieldAddress GetPivotOffset_InElementHandle_PropertyAddress;

	private static int GetPivotOffset_InElementHandle_Offset;

	private static bool GetPivotOffset_OutPivotOffset_IsValid;

	private static FFieldAddress GetPivotOffset_OutPivotOffset_PropertyAddress;

	private static int GetPivotOffset_OutPivotOffset_Offset;

	private static bool GetPivotOffset_ReturnValue_IsValid;

	private static FFieldAddress GetPivotOffset_ReturnValue_PropertyAddress;

	private static int GetPivotOffset_ReturnValue_Offset;

	private static bool GetOwnerWorld_IsValid;

	private IntPtr GetOwnerWorld_InstanceFunctionAddress;

	private static IntPtr GetOwnerWorld_FunctionAddress;

	private static int GetOwnerWorld_ParamsSize;

	private static bool GetOwnerWorld_InElementHandle_IsValid;

	private static FFieldAddress GetOwnerWorld_InElementHandle_PropertyAddress;

	private static int GetOwnerWorld_InElementHandle_Offset;

	private static bool GetOwnerWorld_ReturnValue_IsValid;

	private static FFieldAddress GetOwnerWorld_ReturnValue_PropertyAddress;

	private static int GetOwnerWorld_ReturnValue_Offset;

	private static bool GetOwnerLevel_IsValid;

	private IntPtr GetOwnerLevel_InstanceFunctionAddress;

	private static IntPtr GetOwnerLevel_FunctionAddress;

	private static int GetOwnerLevel_ParamsSize;

	private static bool GetOwnerLevel_InElementHandle_IsValid;

	private static FFieldAddress GetOwnerLevel_InElementHandle_PropertyAddress;

	private static int GetOwnerLevel_InElementHandle_Offset;

	private static bool GetOwnerLevel_ReturnValue_IsValid;

	private static FFieldAddress GetOwnerLevel_ReturnValue_PropertyAddress;

	private static int GetOwnerLevel_ReturnValue_Offset;

	private static bool GetBounds_IsValid;

	private IntPtr GetBounds_InstanceFunctionAddress;

	private static IntPtr GetBounds_FunctionAddress;

	private static int GetBounds_ParamsSize;

	private static bool GetBounds_InElementHandle_IsValid;

	private static FFieldAddress GetBounds_InElementHandle_PropertyAddress;

	private static int GetBounds_InElementHandle_Offset;

	private static bool GetBounds_OutBounds_IsValid;

	private static FFieldAddress GetBounds_OutBounds_PropertyAddress;

	private static int GetBounds_OutBounds_Offset;

	private static bool GetBounds_ReturnValue_IsValid;

	private static FFieldAddress GetBounds_ReturnValue_PropertyAddress;

	private static int GetBounds_ReturnValue_Offset;

	private static bool DuplicateElement_IsValid;

	private IntPtr DuplicateElement_InstanceFunctionAddress;

	private static IntPtr DuplicateElement_FunctionAddress;

	private static int DuplicateElement_ParamsSize;

	private static bool DuplicateElement_InElementHandle_IsValid;

	private static FFieldAddress DuplicateElement_InElementHandle_PropertyAddress;

	private static int DuplicateElement_InElementHandle_Offset;

	private static bool DuplicateElement_InWorld_IsValid;

	private static FFieldAddress DuplicateElement_InWorld_PropertyAddress;

	private static int DuplicateElement_InWorld_Offset;

	private static bool DuplicateElement_InLocationOffset_IsValid;

	private static FFieldAddress DuplicateElement_InLocationOffset_PropertyAddress;

	private static int DuplicateElement_InLocationOffset_Offset;

	private static bool DuplicateElement_ReturnValue_IsValid;

	private static FFieldAddress DuplicateElement_ReturnValue_PropertyAddress;

	private static int DuplicateElement_ReturnValue_Offset;

	private static bool DeleteElement_IsValid;

	private IntPtr DeleteElement_InstanceFunctionAddress;

	private static IntPtr DeleteElement_FunctionAddress;

	private static int DeleteElement_ParamsSize;

	private static bool DeleteElement_InElementHandle_IsValid;

	private static FFieldAddress DeleteElement_InElementHandle_PropertyAddress;

	private static int DeleteElement_InElementHandle_Offset;

	private static bool DeleteElement_InWorld_IsValid;

	private static FFieldAddress DeleteElement_InWorld_PropertyAddress;

	private static int DeleteElement_InWorld_Offset;

	private static bool DeleteElement_InSelectionSet_IsValid;

	private static FFieldAddress DeleteElement_InSelectionSet_PropertyAddress;

	private static int DeleteElement_InSelectionSet_Offset;

	private static bool DeleteElement_InDeletionOptions_IsValid;

	private static FFieldAddress DeleteElement_InDeletionOptions_PropertyAddress;

	private static int DeleteElement_InDeletionOptions_Offset;

	private static bool DeleteElement_ReturnValue_IsValid;

	private static FFieldAddress DeleteElement_ReturnValue_PropertyAddress;

	private static int DeleteElement_ReturnValue_Offset;

	private static bool CanMoveElement_IsValid;

	private IntPtr CanMoveElement_InstanceFunctionAddress;

	private static IntPtr CanMoveElement_FunctionAddress;

	private static int CanMoveElement_ParamsSize;

	private static bool CanMoveElement_InElementHandle_IsValid;

	private static FFieldAddress CanMoveElement_InElementHandle_PropertyAddress;

	private static int CanMoveElement_InElementHandle_Offset;

	private static bool CanMoveElement_InWorldType_IsValid;

	private static FFieldAddress CanMoveElement_InWorldType_PropertyAddress;

	private static int CanMoveElement_InWorldType_Offset;

	private static bool CanMoveElement_ReturnValue_IsValid;

	private static FFieldAddress CanMoveElement_ReturnValue_PropertyAddress;

	private static int CanMoveElement_ReturnValue_Offset;

	private static bool CanEditElement_IsValid;

	private IntPtr CanEditElement_InstanceFunctionAddress;

	private static IntPtr CanEditElement_FunctionAddress;

	private static int CanEditElement_ParamsSize;

	private static bool CanEditElement_InElementHandle_IsValid;

	private static FFieldAddress CanEditElement_InElementHandle_PropertyAddress;

	private static int CanEditElement_InElementHandle_Offset;

	private static bool CanEditElement_ReturnValue_IsValid;

	private static FFieldAddress CanEditElement_ReturnValue_PropertyAddress;

	private static int CanEditElement_ReturnValue_Offset;

	private static bool CanDuplicateElement_IsValid;

	private IntPtr CanDuplicateElement_InstanceFunctionAddress;

	private static IntPtr CanDuplicateElement_FunctionAddress;

	private static int CanDuplicateElement_ParamsSize;

	private static bool CanDuplicateElement_InElementHandle_IsValid;

	private static FFieldAddress CanDuplicateElement_InElementHandle_PropertyAddress;

	private static int CanDuplicateElement_InElementHandle_Offset;

	private static bool CanDuplicateElement_ReturnValue_IsValid;

	private static FFieldAddress CanDuplicateElement_ReturnValue_PropertyAddress;

	private static int CanDuplicateElement_ReturnValue_Offset;

	private static bool CanDeleteElement_IsValid;

	private IntPtr CanDeleteElement_InstanceFunctionAddress;

	private static IntPtr CanDeleteElement_FunctionAddress;

	private static int CanDeleteElement_ParamsSize;

	private static bool CanDeleteElement_InElementHandle_IsValid;

	private static FFieldAddress CanDeleteElement_InElementHandle_PropertyAddress;

	private static int CanDeleteElement_InElementHandle_Offset;

	private static bool CanDeleteElement_ReturnValue_IsValid;

	private static FFieldAddress CanDeleteElement_ReturnValue_PropertyAddress;

	private static int CanDeleteElement_ReturnValue_Offset;

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetWorldTransform")]
	public unsafe bool SetWorldTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform)
	{
		CheckDestroyed();
		if (!SetWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:SetWorldTransform");
			return false;
		}
		if (SetWorldTransform_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetWorldTransform_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetWorldTransform");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetWorldTransform_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SetWorldTransform_InElementHandle_Offset), 0, SetWorldTransform_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(SetWorldTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetWorldTransform_InTransform_Offset), 0, SetWorldTransform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldTransform_InstanceFunctionAddress, intPtr, SetWorldTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetWorldTransform_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetWorldTransform_ReturnValue_Offset), 0, SetWorldTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetRelativeTransform")]
	public unsafe bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform)
	{
		CheckDestroyed();
		if (!SetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:SetRelativeTransform");
			return false;
		}
		if (SetRelativeTransform_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetRelativeTransform_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetRelativeTransform");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRelativeTransform_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SetRelativeTransform_InElementHandle_Offset), 0, SetRelativeTransform_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(SetRelativeTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetRelativeTransform_InTransform_Offset), 0, SetRelativeTransform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeTransform_InstanceFunctionAddress, intPtr, SetRelativeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRelativeTransform_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRelativeTransform_ReturnValue_Offset), 0, SetRelativeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetPivotOffset")]
	public unsafe bool SetPivotOffset(FScriptTypedElementHandle InElementHandle, FVector InPivotOffset)
	{
		CheckDestroyed();
		if (!SetPivotOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:SetPivotOffset");
			return false;
		}
		if (SetPivotOffset_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetPivotOffset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetPivotOffset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPivotOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPivotOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPivotOffset_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, SetPivotOffset_InElementHandle_Offset), 0, SetPivotOffset_InElementHandle_PropertyAddress.Address, InElementHandle);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPivotOffset_InPivotOffset_Offset), 0, SetPivotOffset_InPivotOffset_PropertyAddress.Address, InPivotOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPivotOffset_InstanceFunctionAddress, intPtr, SetPivotOffset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPivotOffset_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPivotOffset_ReturnValue_Offset), 0, SetPivotOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementStarted")]
	public unsafe void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!NotifyMovementStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:NotifyMovementStarted");
			return;
		}
		if (NotifyMovementStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyMovementStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyMovementStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyMovementStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyMovementStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotifyMovementStarted_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, NotifyMovementStarted_InElementHandle_Offset), 0, NotifyMovementStarted_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyMovementStarted_InstanceFunctionAddress, intPtr, NotifyMovementStarted_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotifyMovementStarted_InElementHandle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementOngoing")]
	public unsafe void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!NotifyMovementOngoing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:NotifyMovementOngoing");
			return;
		}
		if (NotifyMovementOngoing_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyMovementOngoing_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyMovementOngoing");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyMovementOngoing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyMovementOngoing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotifyMovementOngoing_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, NotifyMovementOngoing_InElementHandle_Offset), 0, NotifyMovementOngoing_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyMovementOngoing_InstanceFunctionAddress, intPtr, NotifyMovementOngoing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotifyMovementOngoing_InElementHandle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementEnded")]
	public unsafe void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!NotifyMovementEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:NotifyMovementEnded");
			return;
		}
		if (NotifyMovementEnded_InstanceFunctionAddress == IntPtr.Zero)
		{
			NotifyMovementEnded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NotifyMovementEnded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotifyMovementEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotifyMovementEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotifyMovementEnded_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, NotifyMovementEnded_InElementHandle_Offset), 0, NotifyMovementEnded_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, NotifyMovementEnded_InstanceFunctionAddress, intPtr, NotifyMovementEnded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotifyMovementEnded_InElementHandle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:IsTemplateElement")]
	public unsafe bool IsTemplateElement(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!IsTemplateElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:IsTemplateElement");
			return false;
		}
		if (IsTemplateElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsTemplateElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsTemplateElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTemplateElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTemplateElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTemplateElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, IsTemplateElement_InElementHandle_Offset), 0, IsTemplateElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTemplateElement_InstanceFunctionAddress, intPtr, IsTemplateElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTemplateElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTemplateElement_ReturnValue_Offset), 0, IsTemplateElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetWorldTransform")]
	public unsafe bool GetWorldTransform(FScriptTypedElementHandle InElementHandle, out FTransform OutTransform)
	{
		CheckDestroyed();
		if (!GetWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetWorldTransform");
			OutTransform = default(FTransform);
			return false;
		}
		if (GetWorldTransform_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetWorldTransform_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetWorldTransform");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetWorldTransform_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetWorldTransform_InElementHandle_Offset), 0, GetWorldTransform_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(GetWorldTransform_OutTransform_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldTransform_InstanceFunctionAddress, intPtr, GetWorldTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetWorldTransform_InElementHandle_PropertyAddress.Address, intPtr);
		OutTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetWorldTransform_OutTransform_Offset), 0, GetWorldTransform_OutTransform_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetWorldTransform_ReturnValue_Offset), 0, GetWorldTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetRelativeTransform")]
	public unsafe bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle, out FTransform OutTransform)
	{
		CheckDestroyed();
		if (!GetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetRelativeTransform");
			OutTransform = default(FTransform);
			return false;
		}
		if (GetRelativeTransform_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRelativeTransform_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRelativeTransform");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRelativeTransform_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetRelativeTransform_InElementHandle_Offset), 0, GetRelativeTransform_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InitializeValue_InContainer(GetRelativeTransform_OutTransform_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRelativeTransform_InstanceFunctionAddress, intPtr, GetRelativeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRelativeTransform_InElementHandle_PropertyAddress.Address, intPtr);
		OutTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRelativeTransform_OutTransform_Offset), 0, GetRelativeTransform_OutTransform_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetRelativeTransform_ReturnValue_Offset), 0, GetRelativeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetPivotOffset")]
	public unsafe bool GetPivotOffset(FScriptTypedElementHandle InElementHandle, out FVector OutPivotOffset)
	{
		CheckDestroyed();
		if (!GetPivotOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetPivotOffset");
			OutPivotOffset = default(FVector);
			return false;
		}
		if (GetPivotOffset_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetPivotOffset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetPivotOffset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPivotOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPivotOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPivotOffset_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetPivotOffset_InElementHandle_Offset), 0, GetPivotOffset_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPivotOffset_InstanceFunctionAddress, intPtr, GetPivotOffset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPivotOffset_InElementHandle_PropertyAddress.Address, intPtr);
		OutPivotOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPivotOffset_OutPivotOffset_Offset), 0, GetPivotOffset_OutPivotOffset_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPivotOffset_ReturnValue_Offset), 0, GetPivotOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetOwnerWorld")]
	public unsafe UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetOwnerWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetOwnerWorld");
			return null;
		}
		if (GetOwnerWorld_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetOwnerWorld_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetOwnerWorld");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnerWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnerWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOwnerWorld_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetOwnerWorld_InElementHandle_Offset), 0, GetOwnerWorld_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwnerWorld_InstanceFunctionAddress, intPtr, GetOwnerWorld_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOwnerWorld_InElementHandle_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetOwnerWorld_ReturnValue_Offset), 0, GetOwnerWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetOwnerLevel")]
	public unsafe ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!GetOwnerLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetOwnerLevel");
			return null;
		}
		if (GetOwnerLevel_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetOwnerLevel_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetOwnerLevel");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnerLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnerLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOwnerLevel_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetOwnerLevel_InElementHandle_Offset), 0, GetOwnerLevel_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwnerLevel_InstanceFunctionAddress, intPtr, GetOwnerLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOwnerLevel_InElementHandle_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetOwnerLevel_ReturnValue_Offset), 0, GetOwnerLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetBounds")]
	public unsafe bool GetBounds(FScriptTypedElementHandle InElementHandle, out FBoxSphereBounds OutBounds)
	{
		CheckDestroyed();
		if (!GetBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:GetBounds");
			OutBounds = default(FBoxSphereBounds);
			return false;
		}
		if (GetBounds_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetBounds_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetBounds");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBounds_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, GetBounds_InElementHandle_Offset), 0, GetBounds_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBounds_InstanceFunctionAddress, intPtr, GetBounds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBounds_InElementHandle_PropertyAddress.Address, intPtr);
		OutBounds = BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(intPtr, GetBounds_OutBounds_Offset), 0, GetBounds_OutBounds_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBounds_ReturnValue_Offset), 0, GetBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:DuplicateElement")]
	public unsafe FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, FVector InLocationOffset)
	{
		CheckDestroyed();
		if (!DuplicateElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:DuplicateElement");
			return default(FScriptTypedElementHandle);
		}
		if (DuplicateElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			DuplicateElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DuplicateElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DuplicateElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, DuplicateElement_InElementHandle_Offset), 0, DuplicateElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DuplicateElement_InWorld_Offset), 0, DuplicateElement_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DuplicateElement_InLocationOffset_Offset), 0, DuplicateElement_InLocationOffset_PropertyAddress.Address, InLocationOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateElement_InstanceFunctionAddress, intPtr, DuplicateElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, DuplicateElement_ReturnValue_Offset), 0, DuplicateElement_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DuplicateElement_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:DeleteElement")]
	public unsafe bool DeleteElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, UTypedElementSelectionSet InSelectionSet, FTypedElementDeletionOptions InDeletionOptions)
	{
		CheckDestroyed();
		if (!DeleteElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:DeleteElement");
			return false;
		}
		if (DeleteElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			DeleteElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DeleteElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeleteElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, DeleteElement_InElementHandle_Offset), 0, DeleteElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DeleteElement_InWorld_Offset), 0, DeleteElement_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<UTypedElementSelectionSet>.ToNative(IntPtr.Add(intPtr, DeleteElement_InSelectionSet_Offset), 0, DeleteElement_InSelectionSet_PropertyAddress.Address, InSelectionSet);
		NativeReflection.InitializeValue_InContainer(DeleteElement_InDeletionOptions_PropertyAddress.Address, intPtr);
		FTypedElementDeletionOptions.ToNative(IntPtr.Add(intPtr, DeleteElement_InDeletionOptions_Offset), 0, DeleteElement_InDeletionOptions_PropertyAddress.Address, InDeletionOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteElement_InstanceFunctionAddress, intPtr, DeleteElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteElement_ReturnValue_Offset), 0, DeleteElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanMoveElement")]
	public unsafe bool CanMoveElement(FScriptTypedElementHandle InElementHandle, ETypedElementWorldType InWorldType)
	{
		CheckDestroyed();
		if (!CanMoveElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:CanMoveElement");
			return false;
		}
		if (CanMoveElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanMoveElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanMoveElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanMoveElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanMoveElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanMoveElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanMoveElement_InElementHandle_Offset), 0, CanMoveElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		EnumMarshaler<ETypedElementWorldType>.ToNative(IntPtr.Add(intPtr, CanMoveElement_InWorldType_Offset), 0, CanMoveElement_InWorldType_PropertyAddress.Address, InWorldType);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanMoveElement_InstanceFunctionAddress, intPtr, CanMoveElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanMoveElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanMoveElement_ReturnValue_Offset), 0, CanMoveElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanEditElement")]
	public unsafe bool CanEditElement(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!CanEditElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:CanEditElement");
			return false;
		}
		if (CanEditElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanEditElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanEditElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanEditElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanEditElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanEditElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanEditElement_InElementHandle_Offset), 0, CanEditElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanEditElement_InstanceFunctionAddress, intPtr, CanEditElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanEditElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanEditElement_ReturnValue_Offset), 0, CanEditElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanDuplicateElement")]
	public unsafe bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!CanDuplicateElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:CanDuplicateElement");
			return false;
		}
		if (CanDuplicateElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanDuplicateElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanDuplicateElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDuplicateElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDuplicateElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanDuplicateElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanDuplicateElement_InElementHandle_Offset), 0, CanDuplicateElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanDuplicateElement_InstanceFunctionAddress, intPtr, CanDuplicateElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDuplicateElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDuplicateElement_ReturnValue_Offset), 0, CanDuplicateElement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanDeleteElement")]
	public unsafe bool CanDeleteElement(FScriptTypedElementHandle InElementHandle)
	{
		CheckDestroyed();
		if (!CanDeleteElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TypedElementWorldInterface:CanDeleteElement");
			return false;
		}
		if (CanDeleteElement_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanDeleteElement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanDeleteElement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDeleteElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDeleteElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CanDeleteElement_InElementHandle_PropertyAddress.Address, intPtr);
		FScriptTypedElementHandle.ToNative(IntPtr.Add(intPtr, CanDeleteElement_InElementHandle_Offset), 0, CanDeleteElement_InElementHandle_PropertyAddress.Address, InElementHandle);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanDeleteElement_InstanceFunctionAddress, intPtr, CanDeleteElement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanDeleteElement_InElementHandle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDeleteElement_ReturnValue_Offset), 0, CanDeleteElement_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		SetWorldTransform_InstanceFunctionAddress = IntPtr.Zero;
		SetRelativeTransform_InstanceFunctionAddress = IntPtr.Zero;
		SetPivotOffset_InstanceFunctionAddress = IntPtr.Zero;
		NotifyMovementStarted_InstanceFunctionAddress = IntPtr.Zero;
		NotifyMovementOngoing_InstanceFunctionAddress = IntPtr.Zero;
		NotifyMovementEnded_InstanceFunctionAddress = IntPtr.Zero;
		IsTemplateElement_InstanceFunctionAddress = IntPtr.Zero;
		GetWorldTransform_InstanceFunctionAddress = IntPtr.Zero;
		GetRelativeTransform_InstanceFunctionAddress = IntPtr.Zero;
		GetPivotOffset_InstanceFunctionAddress = IntPtr.Zero;
		GetOwnerWorld_InstanceFunctionAddress = IntPtr.Zero;
		GetOwnerLevel_InstanceFunctionAddress = IntPtr.Zero;
		GetBounds_InstanceFunctionAddress = IntPtr.Zero;
		DuplicateElement_InstanceFunctionAddress = IntPtr.Zero;
		DeleteElement_InstanceFunctionAddress = IntPtr.Zero;
		CanMoveElement_InstanceFunctionAddress = IntPtr.Zero;
		CanEditElement_InstanceFunctionAddress = IntPtr.Zero;
		CanDuplicateElement_InstanceFunctionAddress = IntPtr.Zero;
		CanDeleteElement_InstanceFunctionAddress = IntPtr.Zero;
	}

	static ITypedElementWorldInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ITypedElementWorldInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ITypedElementWorldInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.TypedElementWorldInterface");
		SetWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWorldTransform");
		SetWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_InElementHandle_PropertyAddress, SetWorldTransform_FunctionAddress, "InElementHandle");
		SetWorldTransform_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "InElementHandle");
		SetWorldTransform_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_InTransform_PropertyAddress, SetWorldTransform_FunctionAddress, "InTransform");
		SetWorldTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "InTransform");
		SetWorldTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_ReturnValue_PropertyAddress, SetWorldTransform_FunctionAddress, "ReturnValue");
		SetWorldTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "ReturnValue");
		SetWorldTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetWorldTransform_IsValid = SetWorldTransform_FunctionAddress != IntPtr.Zero && SetWorldTransform_InElementHandle_IsValid && SetWorldTransform_InTransform_IsValid && SetWorldTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:SetWorldTransform", SetWorldTransform_IsValid);
		SetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRelativeTransform");
		SetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_InElementHandle_PropertyAddress, SetRelativeTransform_FunctionAddress, "InElementHandle");
		SetRelativeTransform_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "InElementHandle");
		SetRelativeTransform_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_InTransform_PropertyAddress, SetRelativeTransform_FunctionAddress, "InTransform");
		SetRelativeTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "InTransform");
		SetRelativeTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_ReturnValue_PropertyAddress, SetRelativeTransform_FunctionAddress, "ReturnValue");
		SetRelativeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "ReturnValue");
		SetRelativeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRelativeTransform_IsValid = SetRelativeTransform_FunctionAddress != IntPtr.Zero && SetRelativeTransform_InElementHandle_IsValid && SetRelativeTransform_InTransform_IsValid && SetRelativeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:SetRelativeTransform", SetRelativeTransform_IsValid);
		SetPivotOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPivotOffset");
		SetPivotOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPivotOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPivotOffset_InElementHandle_PropertyAddress, SetPivotOffset_FunctionAddress, "InElementHandle");
		SetPivotOffset_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(SetPivotOffset_FunctionAddress, "InElementHandle");
		SetPivotOffset_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPivotOffset_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPivotOffset_InPivotOffset_PropertyAddress, SetPivotOffset_FunctionAddress, "InPivotOffset");
		SetPivotOffset_InPivotOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetPivotOffset_FunctionAddress, "InPivotOffset");
		SetPivotOffset_InPivotOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPivotOffset_FunctionAddress, "InPivotOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPivotOffset_ReturnValue_PropertyAddress, SetPivotOffset_FunctionAddress, "ReturnValue");
		SetPivotOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPivotOffset_FunctionAddress, "ReturnValue");
		SetPivotOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPivotOffset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetPivotOffset_IsValid = SetPivotOffset_FunctionAddress != IntPtr.Zero && SetPivotOffset_InElementHandle_IsValid && SetPivotOffset_InPivotOffset_IsValid && SetPivotOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:SetPivotOffset", SetPivotOffset_IsValid);
		NotifyMovementStarted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyMovementStarted");
		NotifyMovementStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyMovementStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyMovementStarted_InElementHandle_PropertyAddress, NotifyMovementStarted_FunctionAddress, "InElementHandle");
		NotifyMovementStarted_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(NotifyMovementStarted_FunctionAddress, "InElementHandle");
		NotifyMovementStarted_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyMovementStarted_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NotifyMovementStarted_IsValid = NotifyMovementStarted_FunctionAddress != IntPtr.Zero && NotifyMovementStarted_InElementHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:NotifyMovementStarted", NotifyMovementStarted_IsValid);
		NotifyMovementOngoing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyMovementOngoing");
		NotifyMovementOngoing_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyMovementOngoing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyMovementOngoing_InElementHandle_PropertyAddress, NotifyMovementOngoing_FunctionAddress, "InElementHandle");
		NotifyMovementOngoing_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(NotifyMovementOngoing_FunctionAddress, "InElementHandle");
		NotifyMovementOngoing_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyMovementOngoing_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NotifyMovementOngoing_IsValid = NotifyMovementOngoing_FunctionAddress != IntPtr.Zero && NotifyMovementOngoing_InElementHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:NotifyMovementOngoing", NotifyMovementOngoing_IsValid);
		NotifyMovementEnded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NotifyMovementEnded");
		NotifyMovementEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyMovementEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotifyMovementEnded_InElementHandle_PropertyAddress, NotifyMovementEnded_FunctionAddress, "InElementHandle");
		NotifyMovementEnded_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(NotifyMovementEnded_FunctionAddress, "InElementHandle");
		NotifyMovementEnded_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(NotifyMovementEnded_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NotifyMovementEnded_IsValid = NotifyMovementEnded_FunctionAddress != IntPtr.Zero && NotifyMovementEnded_InElementHandle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:NotifyMovementEnded", NotifyMovementEnded_IsValid);
		IsTemplateElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsTemplateElement");
		IsTemplateElement_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTemplateElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTemplateElement_InElementHandle_PropertyAddress, IsTemplateElement_FunctionAddress, "InElementHandle");
		IsTemplateElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(IsTemplateElement_FunctionAddress, "InElementHandle");
		IsTemplateElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTemplateElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTemplateElement_ReturnValue_PropertyAddress, IsTemplateElement_FunctionAddress, "ReturnValue");
		IsTemplateElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTemplateElement_FunctionAddress, "ReturnValue");
		IsTemplateElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTemplateElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTemplateElement_IsValid = IsTemplateElement_FunctionAddress != IntPtr.Zero && IsTemplateElement_InElementHandle_IsValid && IsTemplateElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:IsTemplateElement", IsTemplateElement_IsValid);
		GetWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldTransform");
		GetWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransform_InElementHandle_PropertyAddress, GetWorldTransform_FunctionAddress, "InElementHandle");
		GetWorldTransform_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransform_FunctionAddress, "InElementHandle");
		GetWorldTransform_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransform_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransform_OutTransform_PropertyAddress, GetWorldTransform_FunctionAddress, "OutTransform");
		GetWorldTransform_OutTransform_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransform_FunctionAddress, "OutTransform");
		GetWorldTransform_OutTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransform_FunctionAddress, "OutTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransform_ReturnValue_PropertyAddress, GetWorldTransform_FunctionAddress, "ReturnValue");
		GetWorldTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransform_FunctionAddress, "ReturnValue");
		GetWorldTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetWorldTransform_IsValid = GetWorldTransform_FunctionAddress != IntPtr.Zero && GetWorldTransform_InElementHandle_IsValid && GetWorldTransform_OutTransform_IsValid && GetWorldTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetWorldTransform", GetWorldTransform_IsValid);
		GetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRelativeTransform");
		GetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_InElementHandle_PropertyAddress, GetRelativeTransform_FunctionAddress, "InElementHandle");
		GetRelativeTransform_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "InElementHandle");
		GetRelativeTransform_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_OutTransform_PropertyAddress, GetRelativeTransform_FunctionAddress, "OutTransform");
		GetRelativeTransform_OutTransform_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "OutTransform");
		GetRelativeTransform_OutTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "OutTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_ReturnValue_PropertyAddress, GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetRelativeTransform_IsValid = GetRelativeTransform_FunctionAddress != IntPtr.Zero && GetRelativeTransform_InElementHandle_IsValid && GetRelativeTransform_OutTransform_IsValid && GetRelativeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetRelativeTransform", GetRelativeTransform_IsValid);
		GetPivotOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPivotOffset");
		GetPivotOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPivotOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPivotOffset_InElementHandle_PropertyAddress, GetPivotOffset_FunctionAddress, "InElementHandle");
		GetPivotOffset_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetPivotOffset_FunctionAddress, "InElementHandle");
		GetPivotOffset_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPivotOffset_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPivotOffset_OutPivotOffset_PropertyAddress, GetPivotOffset_FunctionAddress, "OutPivotOffset");
		GetPivotOffset_OutPivotOffset_Offset = NativeReflectionCached.GetPropertyOffset(GetPivotOffset_FunctionAddress, "OutPivotOffset");
		GetPivotOffset_OutPivotOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPivotOffset_FunctionAddress, "OutPivotOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPivotOffset_ReturnValue_PropertyAddress, GetPivotOffset_FunctionAddress, "ReturnValue");
		GetPivotOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPivotOffset_FunctionAddress, "ReturnValue");
		GetPivotOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPivotOffset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPivotOffset_IsValid = GetPivotOffset_FunctionAddress != IntPtr.Zero && GetPivotOffset_InElementHandle_IsValid && GetPivotOffset_OutPivotOffset_IsValid && GetPivotOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetPivotOffset", GetPivotOffset_IsValid);
		GetOwnerWorld_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOwnerWorld");
		GetOwnerWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnerWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerWorld_InElementHandle_PropertyAddress, GetOwnerWorld_FunctionAddress, "InElementHandle");
		GetOwnerWorld_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerWorld_FunctionAddress, "InElementHandle");
		GetOwnerWorld_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerWorld_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerWorld_ReturnValue_PropertyAddress, GetOwnerWorld_FunctionAddress, "ReturnValue");
		GetOwnerWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerWorld_FunctionAddress, "ReturnValue");
		GetOwnerWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwnerWorld_IsValid = GetOwnerWorld_FunctionAddress != IntPtr.Zero && GetOwnerWorld_InElementHandle_IsValid && GetOwnerWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetOwnerWorld", GetOwnerWorld_IsValid);
		GetOwnerLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOwnerLevel");
		GetOwnerLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnerLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerLevel_InElementHandle_PropertyAddress, GetOwnerLevel_FunctionAddress, "InElementHandle");
		GetOwnerLevel_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerLevel_FunctionAddress, "InElementHandle");
		GetOwnerLevel_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerLevel_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerLevel_ReturnValue_PropertyAddress, GetOwnerLevel_FunctionAddress, "ReturnValue");
		GetOwnerLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerLevel_FunctionAddress, "ReturnValue");
		GetOwnerLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwnerLevel_IsValid = GetOwnerLevel_FunctionAddress != IntPtr.Zero && GetOwnerLevel_InElementHandle_IsValid && GetOwnerLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetOwnerLevel", GetOwnerLevel_IsValid);
		GetBounds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBounds");
		GetBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_InElementHandle_PropertyAddress, GetBounds_FunctionAddress, "InElementHandle");
		GetBounds_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "InElementHandle");
		GetBounds_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_OutBounds_PropertyAddress, GetBounds_FunctionAddress, "OutBounds");
		GetBounds_OutBounds_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "OutBounds");
		GetBounds_OutBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "OutBounds", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_ReturnValue_PropertyAddress, GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBounds_IsValid = GetBounds_FunctionAddress != IntPtr.Zero && GetBounds_InElementHandle_IsValid && GetBounds_OutBounds_IsValid && GetBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:GetBounds", GetBounds_IsValid);
		DuplicateElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateElement");
		DuplicateElement_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElement_InElementHandle_PropertyAddress, DuplicateElement_FunctionAddress, "InElementHandle");
		DuplicateElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElement_FunctionAddress, "InElementHandle");
		DuplicateElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElement_InWorld_PropertyAddress, DuplicateElement_FunctionAddress, "InWorld");
		DuplicateElement_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElement_FunctionAddress, "InWorld");
		DuplicateElement_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElement_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElement_InLocationOffset_PropertyAddress, DuplicateElement_FunctionAddress, "InLocationOffset");
		DuplicateElement_InLocationOffset_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElement_FunctionAddress, "InLocationOffset");
		DuplicateElement_InLocationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElement_FunctionAddress, "InLocationOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateElement_ReturnValue_PropertyAddress, DuplicateElement_FunctionAddress, "ReturnValue");
		DuplicateElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateElement_FunctionAddress, "ReturnValue");
		DuplicateElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateElement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DuplicateElement_IsValid = DuplicateElement_FunctionAddress != IntPtr.Zero && DuplicateElement_InElementHandle_IsValid && DuplicateElement_InWorld_IsValid && DuplicateElement_InLocationOffset_IsValid && DuplicateElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:DuplicateElement", DuplicateElement_IsValid);
		DeleteElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteElement");
		DeleteElement_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteElement_InElementHandle_PropertyAddress, DeleteElement_FunctionAddress, "InElementHandle");
		DeleteElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(DeleteElement_FunctionAddress, "InElementHandle");
		DeleteElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteElement_InWorld_PropertyAddress, DeleteElement_FunctionAddress, "InWorld");
		DeleteElement_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DeleteElement_FunctionAddress, "InWorld");
		DeleteElement_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteElement_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteElement_InSelectionSet_PropertyAddress, DeleteElement_FunctionAddress, "InSelectionSet");
		DeleteElement_InSelectionSet_Offset = NativeReflectionCached.GetPropertyOffset(DeleteElement_FunctionAddress, "InSelectionSet");
		DeleteElement_InSelectionSet_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteElement_FunctionAddress, "InSelectionSet", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteElement_InDeletionOptions_PropertyAddress, DeleteElement_FunctionAddress, "InDeletionOptions");
		DeleteElement_InDeletionOptions_Offset = NativeReflectionCached.GetPropertyOffset(DeleteElement_FunctionAddress, "InDeletionOptions");
		DeleteElement_InDeletionOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteElement_FunctionAddress, "InDeletionOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteElement_ReturnValue_PropertyAddress, DeleteElement_FunctionAddress, "ReturnValue");
		DeleteElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteElement_FunctionAddress, "ReturnValue");
		DeleteElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteElement_IsValid = DeleteElement_FunctionAddress != IntPtr.Zero && DeleteElement_InElementHandle_IsValid && DeleteElement_InWorld_IsValid && DeleteElement_InSelectionSet_IsValid && DeleteElement_InDeletionOptions_IsValid && DeleteElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:DeleteElement", DeleteElement_IsValid);
		CanMoveElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanMoveElement");
		CanMoveElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanMoveElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanMoveElement_InElementHandle_PropertyAddress, CanMoveElement_FunctionAddress, "InElementHandle");
		CanMoveElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanMoveElement_FunctionAddress, "InElementHandle");
		CanMoveElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanMoveElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanMoveElement_InWorldType_PropertyAddress, CanMoveElement_FunctionAddress, "InWorldType");
		CanMoveElement_InWorldType_Offset = NativeReflectionCached.GetPropertyOffset(CanMoveElement_FunctionAddress, "InWorldType");
		CanMoveElement_InWorldType_IsValid = NativeReflectionCached.ValidatePropertyClass(CanMoveElement_FunctionAddress, "InWorldType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CanMoveElement_ReturnValue_PropertyAddress, CanMoveElement_FunctionAddress, "ReturnValue");
		CanMoveElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanMoveElement_FunctionAddress, "ReturnValue");
		CanMoveElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanMoveElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanMoveElement_IsValid = CanMoveElement_FunctionAddress != IntPtr.Zero && CanMoveElement_InElementHandle_IsValid && CanMoveElement_InWorldType_IsValid && CanMoveElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:CanMoveElement", CanMoveElement_IsValid);
		CanEditElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanEditElement");
		CanEditElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanEditElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanEditElement_InElementHandle_PropertyAddress, CanEditElement_FunctionAddress, "InElementHandle");
		CanEditElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanEditElement_FunctionAddress, "InElementHandle");
		CanEditElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanEditElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanEditElement_ReturnValue_PropertyAddress, CanEditElement_FunctionAddress, "ReturnValue");
		CanEditElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanEditElement_FunctionAddress, "ReturnValue");
		CanEditElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanEditElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanEditElement_IsValid = CanEditElement_FunctionAddress != IntPtr.Zero && CanEditElement_InElementHandle_IsValid && CanEditElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:CanEditElement", CanEditElement_IsValid);
		CanDuplicateElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanDuplicateElement");
		CanDuplicateElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDuplicateElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicateElement_InElementHandle_PropertyAddress, CanDuplicateElement_FunctionAddress, "InElementHandle");
		CanDuplicateElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicateElement_FunctionAddress, "InElementHandle");
		CanDuplicateElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicateElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicateElement_ReturnValue_PropertyAddress, CanDuplicateElement_FunctionAddress, "ReturnValue");
		CanDuplicateElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicateElement_FunctionAddress, "ReturnValue");
		CanDuplicateElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicateElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDuplicateElement_IsValid = CanDuplicateElement_FunctionAddress != IntPtr.Zero && CanDuplicateElement_InElementHandle_IsValid && CanDuplicateElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:CanDuplicateElement", CanDuplicateElement_IsValid);
		CanDeleteElement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanDeleteElement");
		CanDeleteElement_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDeleteElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDeleteElement_InElementHandle_PropertyAddress, CanDeleteElement_FunctionAddress, "InElementHandle");
		CanDeleteElement_InElementHandle_Offset = NativeReflectionCached.GetPropertyOffset(CanDeleteElement_FunctionAddress, "InElementHandle");
		CanDeleteElement_InElementHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDeleteElement_FunctionAddress, "InElementHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDeleteElement_ReturnValue_PropertyAddress, CanDeleteElement_FunctionAddress, "ReturnValue");
		CanDeleteElement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDeleteElement_FunctionAddress, "ReturnValue");
		CanDeleteElement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDeleteElement_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDeleteElement_IsValid = CanDeleteElement_FunctionAddress != IntPtr.Zero && CanDeleteElement_InElementHandle_IsValid && CanDeleteElement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TypedElementWorldInterface:CanDeleteElement", CanDeleteElement_IsValid);
	}
}
