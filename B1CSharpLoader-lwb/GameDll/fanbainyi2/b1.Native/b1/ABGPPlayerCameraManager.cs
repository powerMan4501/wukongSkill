using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGPPlayerCameraManager", "b1", UnrealModuleType.Game)]
public class ABGPPlayerCameraManager : APlayerCameraManager
{
	private static bool UpdateCameraCS_IsValid;

	private IntPtr UpdateCameraCS_InstanceFunctionAddress;

	private static IntPtr UpdateCameraCS_FunctionAddress;

	private static int UpdateCameraCS_ParamsSize;

	private static bool UpdateCameraCS_DeltaTime_IsValid;

	private static FFieldAddress UpdateCameraCS_DeltaTime_PropertyAddress;

	private static int UpdateCameraCS_DeltaTime_Offset;

	private static bool SetViewTargetCS_IsValid;

	private IntPtr SetViewTargetCS_InstanceFunctionAddress;

	private static IntPtr SetViewTargetCS_FunctionAddress;

	private static int SetViewTargetCS_ParamsSize;

	private static bool SetViewTargetCS_NewViewTarget_IsValid;

	private static FFieldAddress SetViewTargetCS_NewViewTarget_PropertyAddress;

	private static int SetViewTargetCS_NewViewTarget_Offset;

	private static bool SetViewTargetCS_TransitionParams_IsValid;

	private static FFieldAddress SetViewTargetCS_TransitionParams_PropertyAddress;

	private static int SetViewTargetCS_TransitionParams_Offset;

	private static bool OnViewTargetChangedCS_IsValid;

	private IntPtr OnViewTargetChangedCS_InstanceFunctionAddress;

	private static IntPtr OnViewTargetChangedCS_FunctionAddress;

	private static int OnViewTargetChangedCS_ParamsSize;

	private static bool OnViewTargetChangedCS_PC_IsValid;

	private static FFieldAddress OnViewTargetChangedCS_PC_PropertyAddress;

	private static int OnViewTargetChangedCS_PC_Offset;

	private static bool OnViewTargetChangedCS_OldViewTarget_IsValid;

	private static FFieldAddress OnViewTargetChangedCS_OldViewTarget_PropertyAddress;

	private static int OnViewTargetChangedCS_OldViewTarget_Offset;

	private static bool OnViewTargetChangedCS_NewViewTarget_IsValid;

	private static FFieldAddress OnViewTargetChangedCS_NewViewTarget_PropertyAddress;

	private static int OnViewTargetChangedCS_NewViewTarget_Offset;

	private static bool OnBlendCompleteCS_IsValid;

	private IntPtr OnBlendCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnBlendCompleteCS_FunctionAddress;

	private static int OnBlendCompleteCS_ParamsSize;

	private static bool GetViewTargetCS_IsValid;

	private static IntPtr GetViewTargetCS_FunctionAddress;

	private static int GetViewTargetCS_ParamsSize;

	private static bool GetViewTargetCS_ReturnValue_IsValid;

	private static FFieldAddress GetViewTargetCS_ReturnValue_PropertyAddress;

	private static int GetViewTargetCS_ReturnValue_Offset;

	private static bool GetPendingViewTargetCS_IsValid;

	private static IntPtr GetPendingViewTargetCS_FunctionAddress;

	private static int GetPendingViewTargetCS_ParamsSize;

	private static bool GetPendingViewTargetCS_ReturnValue_IsValid;

	private static FFieldAddress GetPendingViewTargetCS_ReturnValue_PropertyAddress;

	private static int GetPendingViewTargetCS_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:UpdateCameraCS")]
	public unsafe void UpdateCameraCS(float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateCameraCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:UpdateCameraCS");
			return;
		}
		if (UpdateCameraCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateCameraCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UpdateCameraCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCameraCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCameraCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateCameraCS_DeltaTime_Offset), 0, UpdateCameraCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCameraCS_InstanceFunctionAddress, intPtr, UpdateCameraCS_ParamsSize);
	}

	protected unsafe virtual void UpdateCameraCS_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateCameraCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:UpdateCameraCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCameraCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCameraCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateCameraCS_DeltaTime_Offset), 0, UpdateCameraCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCameraCS_FunctionAddress, intPtr, UpdateCameraCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:SetViewTargetCS")]
	public unsafe void SetViewTargetCS(AActor NewViewTarget, FViewTargetTransitionParams TransitionParams)
	{
		CheckDestroyed();
		if (!SetViewTargetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:SetViewTargetCS");
			return;
		}
		if (SetViewTargetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetViewTargetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetViewTargetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTargetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTargetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetViewTargetCS_NewViewTarget_Offset), 0, SetViewTargetCS_NewViewTarget_PropertyAddress.Address, NewViewTarget);
		NativeReflection.InitializeValue_InContainer(SetViewTargetCS_TransitionParams_PropertyAddress.Address, intPtr);
		FViewTargetTransitionParams.ToNative(IntPtr.Add(intPtr, SetViewTargetCS_TransitionParams_Offset), 0, SetViewTargetCS_TransitionParams_PropertyAddress.Address, TransitionParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewTargetCS_InstanceFunctionAddress, intPtr, SetViewTargetCS_ParamsSize);
	}

	protected unsafe virtual void SetViewTargetCS_Implementation(AActor NewViewTarget, FViewTargetTransitionParams TransitionParams)
	{
		CheckDestroyed();
		if (!SetViewTargetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:SetViewTargetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTargetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTargetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetViewTargetCS_NewViewTarget_Offset), 0, SetViewTargetCS_NewViewTarget_PropertyAddress.Address, NewViewTarget);
		NativeReflection.InitializeValue_InContainer(SetViewTargetCS_TransitionParams_PropertyAddress.Address, intPtr);
		FViewTargetTransitionParams.ToNative(IntPtr.Add(intPtr, SetViewTargetCS_TransitionParams_Offset), 0, SetViewTargetCS_TransitionParams_PropertyAddress.Address, TransitionParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewTargetCS_FunctionAddress, intPtr, SetViewTargetCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:OnViewTargetChangedCS")]
	public unsafe void OnViewTargetChangedCS(APlayerController PC, AActor OldViewTarget, AActor NewViewTarget)
	{
		CheckDestroyed();
		if (!OnViewTargetChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:OnViewTargetChangedCS");
			return;
		}
		if (OnViewTargetChangedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnViewTargetChangedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnViewTargetChangedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewTargetChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewTargetChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_PC_Offset), 0, OnViewTargetChangedCS_PC_PropertyAddress.Address, PC);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_OldViewTarget_Offset), 0, OnViewTargetChangedCS_OldViewTarget_PropertyAddress.Address, OldViewTarget);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_NewViewTarget_Offset), 0, OnViewTargetChangedCS_NewViewTarget_PropertyAddress.Address, NewViewTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewTargetChangedCS_InstanceFunctionAddress, intPtr, OnViewTargetChangedCS_ParamsSize);
	}

	protected unsafe virtual void OnViewTargetChangedCS_Implementation(APlayerController PC, AActor OldViewTarget, AActor NewViewTarget)
	{
		CheckDestroyed();
		if (!OnViewTargetChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:OnViewTargetChangedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnViewTargetChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewTargetChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_PC_Offset), 0, OnViewTargetChangedCS_PC_PropertyAddress.Address, PC);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_OldViewTarget_Offset), 0, OnViewTargetChangedCS_OldViewTarget_PropertyAddress.Address, OldViewTarget);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnViewTargetChangedCS_NewViewTarget_Offset), 0, OnViewTargetChangedCS_NewViewTarget_PropertyAddress.Address, NewViewTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnViewTargetChangedCS_FunctionAddress, intPtr, OnViewTargetChangedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:OnBlendCompleteCS")]
	public unsafe void OnBlendCompleteCS()
	{
		CheckDestroyed();
		if (!OnBlendCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:OnBlendCompleteCS");
			return;
		}
		if (OnBlendCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBlendCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnBlendCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBlendCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBlendCompleteCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBlendCompleteCS_InstanceFunctionAddress, argsSize: OnBlendCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnBlendCompleteCS_Implementation()
	{
		CheckDestroyed();
		if (!OnBlendCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:OnBlendCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBlendCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBlendCompleteCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBlendCompleteCS_FunctionAddress, argsSize: OnBlendCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:GetViewTargetCS")]
	public unsafe AActor GetViewTargetCS()
	{
		CheckDestroyed();
		if (!GetViewTargetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:GetViewTargetCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewTargetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewTargetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewTargetCS_FunctionAddress, intPtr, GetViewTargetCS_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetViewTargetCS_ReturnValue_Offset), 0, GetViewTargetCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGPPlayerCameraManager:GetPendingViewTargetCS")]
	public unsafe AActor GetPendingViewTargetCS()
	{
		CheckDestroyed();
		if (!GetPendingViewTargetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerCameraManager:GetPendingViewTargetCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPendingViewTargetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPendingViewTargetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPendingViewTargetCS_FunctionAddress, intPtr, GetPendingViewTargetCS_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetPendingViewTargetCS_ReturnValue_Offset), 0, GetPendingViewTargetCS_ReturnValue_PropertyAddress.Address);
	}

	static ABGPPlayerCameraManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGPPlayerCameraManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGPPlayerCameraManager));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGPPlayerCameraManager");
		UpdateCameraCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateCameraCS");
		UpdateCameraCS_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCameraCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateCameraCS_DeltaTime_PropertyAddress, UpdateCameraCS_FunctionAddress, "DeltaTime");
		UpdateCameraCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCameraCS_FunctionAddress, "DeltaTime");
		UpdateCameraCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCameraCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		UpdateCameraCS_IsValid = UpdateCameraCS_FunctionAddress != IntPtr.Zero && UpdateCameraCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:UpdateCameraCS", UpdateCameraCS_IsValid);
		SetViewTargetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetViewTargetCS");
		SetViewTargetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewTargetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetCS_NewViewTarget_PropertyAddress, SetViewTargetCS_FunctionAddress, "NewViewTarget");
		SetViewTargetCS_NewViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetCS_FunctionAddress, "NewViewTarget");
		SetViewTargetCS_NewViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetCS_FunctionAddress, "NewViewTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetCS_TransitionParams_PropertyAddress, SetViewTargetCS_FunctionAddress, "TransitionParams");
		SetViewTargetCS_TransitionParams_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetCS_FunctionAddress, "TransitionParams");
		SetViewTargetCS_TransitionParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetCS_FunctionAddress, "TransitionParams", Classes.FStructProperty);
		SetViewTargetCS_IsValid = SetViewTargetCS_FunctionAddress != IntPtr.Zero && SetViewTargetCS_NewViewTarget_IsValid && SetViewTargetCS_TransitionParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:SetViewTargetCS", SetViewTargetCS_IsValid);
		OnViewTargetChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnViewTargetChangedCS");
		OnViewTargetChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewTargetChangedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnViewTargetChangedCS_PC_PropertyAddress, OnViewTargetChangedCS_FunctionAddress, "PC");
		OnViewTargetChangedCS_PC_Offset = NativeReflectionCached.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "PC");
		OnViewTargetChangedCS_PC_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "PC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnViewTargetChangedCS_OldViewTarget_PropertyAddress, OnViewTargetChangedCS_FunctionAddress, "OldViewTarget");
		OnViewTargetChangedCS_OldViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "OldViewTarget");
		OnViewTargetChangedCS_OldViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "OldViewTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnViewTargetChangedCS_NewViewTarget_PropertyAddress, OnViewTargetChangedCS_FunctionAddress, "NewViewTarget");
		OnViewTargetChangedCS_NewViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(OnViewTargetChangedCS_FunctionAddress, "NewViewTarget");
		OnViewTargetChangedCS_NewViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewTargetChangedCS_FunctionAddress, "NewViewTarget", Classes.FObjectProperty);
		OnViewTargetChangedCS_IsValid = OnViewTargetChangedCS_FunctionAddress != IntPtr.Zero && OnViewTargetChangedCS_PC_IsValid && OnViewTargetChangedCS_OldViewTarget_IsValid && OnViewTargetChangedCS_NewViewTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:OnViewTargetChangedCS", OnViewTargetChangedCS_IsValid);
		OnBlendCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBlendCompleteCS");
		OnBlendCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBlendCompleteCS_FunctionAddress);
		OnBlendCompleteCS_IsValid = OnBlendCompleteCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:OnBlendCompleteCS", OnBlendCompleteCS_IsValid);
		GetViewTargetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewTargetCS");
		GetViewTargetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewTargetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewTargetCS_ReturnValue_PropertyAddress, GetViewTargetCS_FunctionAddress, "ReturnValue");
		GetViewTargetCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewTargetCS_FunctionAddress, "ReturnValue");
		GetViewTargetCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewTargetCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetViewTargetCS_IsValid = GetViewTargetCS_FunctionAddress != IntPtr.Zero && GetViewTargetCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:GetViewTargetCS", GetViewTargetCS_IsValid);
		GetPendingViewTargetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPendingViewTargetCS");
		GetPendingViewTargetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPendingViewTargetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPendingViewTargetCS_ReturnValue_PropertyAddress, GetPendingViewTargetCS_FunctionAddress, "ReturnValue");
		GetPendingViewTargetCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPendingViewTargetCS_FunctionAddress, "ReturnValue");
		GetPendingViewTargetCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPendingViewTargetCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPendingViewTargetCS_IsValid = GetPendingViewTargetCS_FunctionAddress != IntPtr.Zero && GetPendingViewTargetCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerCameraManager:GetPendingViewTargetCS", GetPendingViewTargetCS_IsValid);
	}
}
