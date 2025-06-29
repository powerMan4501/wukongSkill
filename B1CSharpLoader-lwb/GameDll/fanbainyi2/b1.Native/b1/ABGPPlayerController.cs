using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGPPlayerController", "b1", UnrealModuleType.Game)]
public class ABGPPlayerController : APlayerController
{
	private static IntPtr classAddress;

	private static bool IsInTeleport_IsValid;

	private static FFieldAddress IsInTeleport_PropertyAddress;

	private static int IsInTeleport_Offset;

	private static bool SetSpawnLocationCS_IsValid;

	private static IntPtr SetSpawnLocationCS_FunctionAddress;

	private static int SetSpawnLocationCS_ParamsSize;

	private static bool SetSpawnLocationCS_NewLocation_IsValid;

	private static FFieldAddress SetSpawnLocationCS_NewLocation_PropertyAddress;

	private static int SetSpawnLocationCS_NewLocation_Offset;

	private static bool SetIsShouldPerformFullTickWhenPaused_IsValid;

	private static IntPtr SetIsShouldPerformFullTickWhenPaused_FunctionAddress;

	private static int SetIsShouldPerformFullTickWhenPaused_ParamsSize;

	private static bool SetIsShouldPerformFullTickWhenPaused_IsShould_IsValid;

	private static FFieldAddress SetIsShouldPerformFullTickWhenPaused_IsShould_PropertyAddress;

	private static int SetIsShouldPerformFullTickWhenPaused_IsShould_Offset;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool OnRep_PlayerStateCS_IsValid;

	private IntPtr OnRep_PlayerStateCS_InstanceFunctionAddress;

	private static IntPtr OnRep_PlayerStateCS_FunctionAddress;

	private static int OnRep_PlayerStateCS_ParamsSize;

	private static bool OnRep_PawnCS_IsValid;

	private IntPtr OnRep_PawnCS_InstanceFunctionAddress;

	private static IntPtr OnRep_PawnCS_FunctionAddress;

	private static int OnRep_PawnCS_ParamsSize;

	private static bool OnPossessWithViewTargetBlend_IsValid;

	private static IntPtr OnPossessWithViewTargetBlend_FunctionAddress;

	private static int OnPossessWithViewTargetBlend_ParamsSize;

	private static bool OnPossessWithViewTargetBlend_InPawn_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_InPawn_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_InPawn_Offset;

	private static bool OnPossessWithViewTargetBlend_BlendTime_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_BlendTime_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_BlendTime_Offset;

	private static bool OnPossessWithViewTargetBlend_BlendFunc_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_BlendFunc_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_BlendFunc_Offset;

	private static bool OnPossessWithViewTargetBlend_BlendExp_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_BlendExp_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_BlendExp_Offset;

	private static bool OnPossessWithViewTargetBlend_bLockOutgoing_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_bLockOutgoing_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_bLockOutgoing_Offset;

	private static bool OnPossessWithViewTargetBlend_EnableBlendViewTarget_IsValid;

	private static FFieldAddress OnPossessWithViewTargetBlend_EnableBlendViewTarget_PropertyAddress;

	private static int OnPossessWithViewTargetBlend_EnableBlendViewTarget_Offset;

	private static bool InitInputSystemCS_IsValid;

	private IntPtr InitInputSystemCS_InstanceFunctionAddress;

	private static IntPtr InitInputSystemCS_FunctionAddress;

	private static int InitInputSystemCS_ParamsSize;

	private static bool GetSpawnLocationCS_IsValid;

	private static IntPtr GetSpawnLocationCS_FunctionAddress;

	private static int GetSpawnLocationCS_ParamsSize;

	private static bool GetSpawnLocationCS_ReturnValue_IsValid;

	private static FFieldAddress GetSpawnLocationCS_ReturnValue_PropertyAddress;

	private static int GetSpawnLocationCS_ReturnValue_Offset;

	private static bool GetSeamlessTravelActorListCS_IsValid;

	private IntPtr GetSeamlessTravelActorListCS_InstanceFunctionAddress;

	private static IntPtr GetSeamlessTravelActorListCS_FunctionAddress;

	private static int GetSeamlessTravelActorListCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_bToEntry_IsValid;

	private static FFieldAddress GetSeamlessTravelActorListCS_bToEntry_PropertyAddress;

	private static int GetSeamlessTravelActorListCS_bToEntry_Offset;

	private static bool GetSeamlessTravelActorListCS_ActorList_IsValid;

	private static FFieldAddress GetSeamlessTravelActorListCS_ActorList_PropertyAddress;

	private static int GetSeamlessTravelActorListCS_ActorList_Offset;

	private static bool GetPlayerViewPointCS_IsValid;

	private IntPtr GetPlayerViewPointCS_InstanceFunctionAddress;

	private static IntPtr GetPlayerViewPointCS_FunctionAddress;

	private static int GetPlayerViewPointCS_ParamsSize;

	private static bool GetPlayerViewPointCS_out_Location_IsValid;

	private static FFieldAddress GetPlayerViewPointCS_out_Location_PropertyAddress;

	private static int GetPlayerViewPointCS_out_Location_Offset;

	private static bool GetPlayerViewPointCS_out_Rotation_IsValid;

	private static FFieldAddress GetPlayerViewPointCS_out_Rotation_PropertyAddress;

	private static int GetPlayerViewPointCS_out_Rotation_Offset;

	private static bool GetPlayerViewPointCS_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerViewPointCS_ReturnValue_PropertyAddress;

	private static int GetPlayerViewPointCS_ReturnValue_Offset;

	private static bool GetPendingViewTarget_IsValid;

	private static IntPtr GetPendingViewTarget_FunctionAddress;

	private static int GetPendingViewTarget_ParamsSize;

	private static bool GetPendingViewTarget_ReturnValue_IsValid;

	private static FFieldAddress GetPendingViewTarget_ReturnValue_PropertyAddress;

	private static int GetPendingViewTarget_ReturnValue_Offset;

	private static bool GetNetConnectionCS_IsValid;

	private static IntPtr GetNetConnectionCS_FunctionAddress;

	private static int GetNetConnectionCS_ParamsSize;

	private static bool GetNetConnectionCS_ReturnValue_IsValid;

	private static FFieldAddress GetNetConnectionCS_ReturnValue_PropertyAddress;

	private static int GetNetConnectionCS_ReturnValue_Offset;

	private static bool GetIsShouldPerformFullTickWhenPaused_IsValid;

	private static IntPtr GetIsShouldPerformFullTickWhenPaused_FunctionAddress;

	private static int GetIsShouldPerformFullTickWhenPaused_ParamsSize;

	private static bool GetIsShouldPerformFullTickWhenPaused_ReturnValue_IsValid;

	private static FFieldAddress GetIsShouldPerformFullTickWhenPaused_ReturnValue_PropertyAddress;

	private static int GetIsShouldPerformFullTickWhenPaused_ReturnValue_Offset;

	private static bool GetCameraBlendTimeToGo_IsValid;

	private static IntPtr GetCameraBlendTimeToGo_FunctionAddress;

	private static int GetCameraBlendTimeToGo_ParamsSize;

	private static bool GetCameraBlendTimeToGo_ReturnValue_IsValid;

	private static FFieldAddress GetCameraBlendTimeToGo_ReturnValue_PropertyAddress;

	private static int GetCameraBlendTimeToGo_ReturnValue_Offset;

	private static bool GetCachedConsoleWorldContext_IsValid;

	private static IntPtr GetCachedConsoleWorldContext_FunctionAddress;

	private static int GetCachedConsoleWorldContext_ParamsSize;

	private static bool GetCachedConsoleWorldContext_ReturnValue_IsValid;

	private static FFieldAddress GetCachedConsoleWorldContext_ReturnValue_PropertyAddress;

	private static int GetCachedConsoleWorldContext_ReturnValue_Offset;

	private static bool GetCachedConsoleCommandCS_IsValid;

	private static IntPtr GetCachedConsoleCommandCS_FunctionAddress;

	private static int GetCachedConsoleCommandCS_ParamsSize;

	private static bool GetCachedConsoleCommandCS_ReturnValue_IsValid;

	private static FFieldAddress GetCachedConsoleCommandCS_ReturnValue_PropertyAddress;

	private static int GetCachedConsoleCommandCS_ReturnValue_Offset;

	private static bool GetAudioListenerRotationCS_IsValid;

	private static IntPtr GetAudioListenerRotationCS_FunctionAddress;

	private static int GetAudioListenerRotationCS_ParamsSize;

	private static bool GetAudioListenerRotationCS_OutRotation_IsValid;

	private static FFieldAddress GetAudioListenerRotationCS_OutRotation_PropertyAddress;

	private static int GetAudioListenerRotationCS_OutRotation_Offset;

	private static bool GetAudioListenerPositionCS_IsValid;

	private static IntPtr GetAudioListenerPositionCS_FunctionAddress;

	private static int GetAudioListenerPositionCS_ParamsSize;

	private static bool GetAudioListenerPositionCS_OutLocation_IsValid;

	private static FFieldAddress GetAudioListenerPositionCS_OutLocation_PropertyAddress;

	private static int GetAudioListenerPositionCS_OutLocation_Offset;

	private static bool GetAudioListenerPositionCS_OutFrontDir_IsValid;

	private static FFieldAddress GetAudioListenerPositionCS_OutFrontDir_PropertyAddress;

	private static int GetAudioListenerPositionCS_OutFrontDir_Offset;

	private static bool GetAudioListenerPositionCS_OutRightDir_IsValid;

	private static FFieldAddress GetAudioListenerPositionCS_OutRightDir_PropertyAddress;

	private static int GetAudioListenerPositionCS_OutRightDir_Offset;

	private static bool ConsoleCommandCS_IsValid;

	private IntPtr ConsoleCommandCS_InstanceFunctionAddress;

	private static IntPtr ConsoleCommandCS_FunctionAddress;

	private static int ConsoleCommandCS_ParamsSize;

	private static bool ConsoleCommandCS_Command_IsValid;

	private static FFieldAddress ConsoleCommandCS_Command_PropertyAddress;

	private static int ConsoleCommandCS_Command_Offset;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.BGPPlayerController:bIsInTeleport")]
	public bool IsInTeleport
	{
		get
		{
			CheckDestroyed();
			if (!IsInTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGPPlayerController:bIsInTeleport");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsInTeleport_Offset), 0, IsInTeleport_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsInTeleport_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGPPlayerController:bIsInTeleport");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsInTeleport_Offset), 0, IsInTeleport_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGPPlayerController:SetSpawnLocationCS")]
	public unsafe void SetSpawnLocationCS(FVector NewLocation)
	{
		CheckDestroyed();
		if (!SetSpawnLocationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:SetSpawnLocationCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpawnLocationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpawnLocationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetSpawnLocationCS_NewLocation_Offset), 0, SetSpawnLocationCS_NewLocation_PropertyAddress.Address, NewLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpawnLocationCS_FunctionAddress, intPtr, SetSpawnLocationCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:SetIsShouldPerformFullTickWhenPaused")]
	public unsafe void SetIsShouldPerformFullTickWhenPaused(bool IsShould)
	{
		CheckDestroyed();
		if (!SetIsShouldPerformFullTickWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:SetIsShouldPerformFullTickWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsShouldPerformFullTickWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsShouldPerformFullTickWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsShouldPerformFullTickWhenPaused_IsShould_Offset), 0, SetIsShouldPerformFullTickWhenPaused_IsShould_PropertyAddress.Address, IsShould);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsShouldPerformFullTickWhenPaused_FunctionAddress, intPtr, SetIsShouldPerformFullTickWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:PostInitializeComponentsCS")]
	public unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:PostInitializeComponentsCS");
			return;
		}
		if (PostInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_InstanceFunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:OnRep_PlayerStateCS")]
	public unsafe void OnRep_PlayerStateCS()
	{
		CheckDestroyed();
		if (!OnRep_PlayerStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:OnRep_PlayerStateCS");
			return;
		}
		if (OnRep_PlayerStateCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRep_PlayerStateCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRep_PlayerStateCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PlayerStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PlayerStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PlayerStateCS_InstanceFunctionAddress, argsSize: OnRep_PlayerStateCS_ParamsSize);
	}

	protected unsafe virtual void OnRep_PlayerStateCS_Implementation()
	{
		CheckDestroyed();
		if (!OnRep_PlayerStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:OnRep_PlayerStateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PlayerStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PlayerStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PlayerStateCS_FunctionAddress, argsSize: OnRep_PlayerStateCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:OnRep_PawnCS")]
	public unsafe void OnRep_PawnCS()
	{
		CheckDestroyed();
		if (!OnRep_PawnCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:OnRep_PawnCS");
			return;
		}
		if (OnRep_PawnCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRep_PawnCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRep_PawnCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PawnCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PawnCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PawnCS_InstanceFunctionAddress, argsSize: OnRep_PawnCS_ParamsSize);
	}

	protected unsafe virtual void OnRep_PawnCS_Implementation()
	{
		CheckDestroyed();
		if (!OnRep_PawnCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:OnRep_PawnCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PawnCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PawnCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PawnCS_FunctionAddress, argsSize: OnRep_PawnCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:OnPossessWithViewTargetBlend")]
	public unsafe void OnPossessWithViewTargetBlend(APawn InPawn, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false, bool EnableBlendViewTarget = true)
	{
		CheckDestroyed();
		if (!OnPossessWithViewTargetBlend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:OnPossessWithViewTargetBlend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPossessWithViewTargetBlend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPossessWithViewTargetBlend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_InPawn_Offset), 0, OnPossessWithViewTargetBlend_InPawn_PropertyAddress.Address, InPawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_BlendTime_Offset), 0, OnPossessWithViewTargetBlend_BlendTime_PropertyAddress.Address, BlendTime);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_BlendFunc_Offset), 0, OnPossessWithViewTargetBlend_BlendFunc_PropertyAddress.Address, BlendFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_BlendExp_Offset), 0, OnPossessWithViewTargetBlend_BlendExp_PropertyAddress.Address, BlendExp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_bLockOutgoing_Offset), 0, OnPossessWithViewTargetBlend_bLockOutgoing_PropertyAddress.Address, bLockOutgoing);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnPossessWithViewTargetBlend_EnableBlendViewTarget_Offset), 0, OnPossessWithViewTargetBlend_EnableBlendViewTarget_PropertyAddress.Address, EnableBlendViewTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPossessWithViewTargetBlend_FunctionAddress, intPtr, OnPossessWithViewTargetBlend_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:InitInputSystemCS")]
	public unsafe void InitInputSystemCS()
	{
		CheckDestroyed();
		if (!InitInputSystemCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:InitInputSystemCS");
			return;
		}
		if (InitInputSystemCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitInputSystemCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitInputSystemCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitInputSystemCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitInputSystemCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitInputSystemCS_InstanceFunctionAddress, argsSize: InitInputSystemCS_ParamsSize);
	}

	protected unsafe virtual void InitInputSystemCS_Implementation()
	{
		CheckDestroyed();
		if (!InitInputSystemCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:InitInputSystemCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitInputSystemCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitInputSystemCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitInputSystemCS_FunctionAddress, argsSize: InitInputSystemCS_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetSpawnLocationCS")]
	public unsafe FVector GetSpawnLocationCS()
	{
		CheckDestroyed();
		if (!GetSpawnLocationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetSpawnLocationCS");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpawnLocationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpawnLocationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpawnLocationCS_FunctionAddress, intPtr, GetSpawnLocationCS_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSpawnLocationCS_ReturnValue_Offset), 0, GetSpawnLocationCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetSeamlessTravelActorListCS")]
	public unsafe void GetSeamlessTravelActorListCS(bool bToEntry, out List<AActor> ActorList)
	{
		CheckDestroyed();
		if (!GetSeamlessTravelActorListCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetSeamlessTravelActorListCS");
			ActorList = null;
			return;
		}
		if (GetSeamlessTravelActorListCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSeamlessTravelActorListCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSeamlessTravelActorListCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSeamlessTravelActorListCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSeamlessTravelActorListCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_bToEntry_Offset), 0, GetSeamlessTravelActorListCS_bToEntry_PropertyAddress.Address, bToEntry);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeamlessTravelActorListCS_InstanceFunctionAddress, intPtr, GetSeamlessTravelActorListCS_ParamsSize);
		ActorList = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_ActorList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSeamlessTravelActorListCS_ActorList_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GetSeamlessTravelActorListCS_Implementation(bool bToEntry, out List<AActor> ActorList)
	{
		CheckDestroyed();
		if (!GetSeamlessTravelActorListCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetSeamlessTravelActorListCS");
			ActorList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSeamlessTravelActorListCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSeamlessTravelActorListCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_bToEntry_Offset), 0, GetSeamlessTravelActorListCS_bToEntry_PropertyAddress.Address, bToEntry);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeamlessTravelActorListCS_FunctionAddress, intPtr, GetSeamlessTravelActorListCS_ParamsSize);
		ActorList = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_ActorList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSeamlessTravelActorListCS_ActorList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1220675584u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetPlayerViewPointCS")]
	public unsafe bool GetPlayerViewPointCS(out FVector out_Location, out FRotator out_Rotation)
	{
		CheckDestroyed();
		if (!GetPlayerViewPointCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetPlayerViewPointCS");
			out_Location = default(FVector);
			out_Rotation = default(FRotator);
			return false;
		}
		if (GetPlayerViewPointCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetPlayerViewPointCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetPlayerViewPointCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewPointCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewPointCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerViewPointCS_InstanceFunctionAddress, intPtr, GetPlayerViewPointCS_ParamsSize);
		out_Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_out_Location_Offset), 0, GetPlayerViewPointCS_out_Location_PropertyAddress.Address);
		out_Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_out_Rotation_Offset), 0, GetPlayerViewPointCS_out_Rotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_ReturnValue_Offset), 0, GetPlayerViewPointCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetPlayerViewPointCS_Implementation(out FVector out_Location, out FRotator out_Rotation)
	{
		CheckDestroyed();
		if (!GetPlayerViewPointCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetPlayerViewPointCS");
			out_Location = default(FVector);
			out_Rotation = default(FRotator);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewPointCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewPointCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerViewPointCS_FunctionAddress, intPtr, GetPlayerViewPointCS_ParamsSize);
		out_Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_out_Location_Offset), 0, GetPlayerViewPointCS_out_Location_PropertyAddress.Address);
		out_Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_out_Rotation_Offset), 0, GetPlayerViewPointCS_out_Rotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPlayerViewPointCS_ReturnValue_Offset), 0, GetPlayerViewPointCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetPendingViewTarget")]
	public unsafe AActor GetPendingViewTarget()
	{
		CheckDestroyed();
		if (!GetPendingViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetPendingViewTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPendingViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPendingViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPendingViewTarget_FunctionAddress, intPtr, GetPendingViewTarget_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetPendingViewTarget_ReturnValue_Offset), 0, GetPendingViewTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetNetConnectionCS")]
	public unsafe UNetConnection GetNetConnectionCS()
	{
		CheckDestroyed();
		if (!GetNetConnectionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetNetConnectionCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNetConnectionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNetConnectionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNetConnectionCS_FunctionAddress, intPtr, GetNetConnectionCS_ParamsSize);
		return UObjectMarshaler<UNetConnection>.FromNative(IntPtr.Add(intPtr, GetNetConnectionCS_ReturnValue_Offset), 0, GetNetConnectionCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetIsShouldPerformFullTickWhenPaused")]
	public unsafe bool GetIsShouldPerformFullTickWhenPaused()
	{
		CheckDestroyed();
		if (!GetIsShouldPerformFullTickWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetIsShouldPerformFullTickWhenPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsShouldPerformFullTickWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsShouldPerformFullTickWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsShouldPerformFullTickWhenPaused_FunctionAddress, intPtr, GetIsShouldPerformFullTickWhenPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsShouldPerformFullTickWhenPaused_ReturnValue_Offset), 0, GetIsShouldPerformFullTickWhenPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetCameraBlendTimeToGo")]
	public unsafe float GetCameraBlendTimeToGo()
	{
		CheckDestroyed();
		if (!GetCameraBlendTimeToGo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetCameraBlendTimeToGo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraBlendTimeToGo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraBlendTimeToGo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraBlendTimeToGo_FunctionAddress, intPtr, GetCameraBlendTimeToGo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCameraBlendTimeToGo_ReturnValue_Offset), 0, GetCameraBlendTimeToGo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetCachedConsoleWorldContext")]
	public unsafe static UObject GetCachedConsoleWorldContext()
	{
		if (!GetCachedConsoleWorldContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetCachedConsoleWorldContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedConsoleWorldContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedConsoleWorldContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCachedConsoleWorldContext_FunctionAddress, intPtr, GetCachedConsoleWorldContext_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetCachedConsoleWorldContext_ReturnValue_Offset), 0, GetCachedConsoleWorldContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetCachedConsoleCommandCS")]
	public unsafe static string GetCachedConsoleCommandCS()
	{
		if (!GetCachedConsoleCommandCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetCachedConsoleCommandCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedConsoleCommandCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedConsoleCommandCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCachedConsoleCommandCS_FunctionAddress, intPtr, GetCachedConsoleCommandCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCachedConsoleCommandCS_ReturnValue_Offset), 0, GetCachedConsoleCommandCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCachedConsoleCommandCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetAudioListenerRotationCS")]
	public unsafe void GetAudioListenerRotationCS(out FRotator OutRotation)
	{
		CheckDestroyed();
		if (!GetAudioListenerRotationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetAudioListenerRotationCS");
			OutRotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioListenerRotationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioListenerRotationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioListenerRotationCS_FunctionAddress, intPtr, GetAudioListenerRotationCS_ParamsSize);
		OutRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetAudioListenerRotationCS_OutRotation_Offset), 0, GetAudioListenerRotationCS_OutRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/b1.BGPPlayerController:GetAudioListenerPositionCS")]
	public unsafe void GetAudioListenerPositionCS(out FVector OutLocation, out FVector OutFrontDir, out FVector OutRightDir)
	{
		CheckDestroyed();
		if (!GetAudioListenerPositionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:GetAudioListenerPositionCS");
			OutLocation = default(FVector);
			OutFrontDir = default(FVector);
			OutRightDir = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioListenerPositionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioListenerPositionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioListenerPositionCS_FunctionAddress, intPtr, GetAudioListenerPositionCS_ParamsSize);
		OutLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAudioListenerPositionCS_OutLocation_Offset), 0, GetAudioListenerPositionCS_OutLocation_PropertyAddress.Address);
		OutFrontDir = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAudioListenerPositionCS_OutFrontDir_Offset), 0, GetAudioListenerPositionCS_OutFrontDir_PropertyAddress.Address);
		OutRightDir = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAudioListenerPositionCS_OutRightDir_Offset), 0, GetAudioListenerPositionCS_OutRightDir_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:ConsoleCommandCS")]
	public unsafe void ConsoleCommandCS(string Command)
	{
		CheckDestroyed();
		if (!ConsoleCommandCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:ConsoleCommandCS");
			return;
		}
		if (ConsoleCommandCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ConsoleCommandCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ConsoleCommandCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsoleCommandCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsoleCommandCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConsoleCommandCS_Command_Offset), 0, ConsoleCommandCS_Command_PropertyAddress.Address, Command);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConsoleCommandCS_InstanceFunctionAddress, intPtr, ConsoleCommandCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConsoleCommandCS_Command_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ConsoleCommandCS_Implementation(string Command)
	{
		CheckDestroyed();
		if (!ConsoleCommandCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:ConsoleCommandCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsoleCommandCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsoleCommandCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConsoleCommandCS_Command_Offset), 0, ConsoleCommandCS_Command_PropertyAddress.Address, Command);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConsoleCommandCS_FunctionAddress, intPtr, ConsoleCommandCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConsoleCommandCS_Command_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGPPlayerController:BeginPlayCS")]
	public unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:BeginPlayCS");
			return;
		}
		if (BeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_InstanceFunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGPPlayerController:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	static ABGPPlayerController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGPPlayerController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGPPlayerController));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGPPlayerController");
		NativeReflectionCached.GetPropertyRef(ref IsInTeleport_PropertyAddress, classAddress, "bIsInTeleport");
		IsInTeleport_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bIsInTeleport");
		IsInTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bIsInTeleport", Classes.FBoolProperty);
		SetSpawnLocationCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSpawnLocationCS");
		SetSpawnLocationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpawnLocationCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpawnLocationCS_NewLocation_PropertyAddress, SetSpawnLocationCS_FunctionAddress, "NewLocation");
		SetSpawnLocationCS_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetSpawnLocationCS_FunctionAddress, "NewLocation");
		SetSpawnLocationCS_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpawnLocationCS_FunctionAddress, "NewLocation", Classes.FStructProperty);
		SetSpawnLocationCS_IsValid = SetSpawnLocationCS_FunctionAddress != IntPtr.Zero && SetSpawnLocationCS_NewLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:SetSpawnLocationCS", SetSpawnLocationCS_IsValid);
		SetIsShouldPerformFullTickWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIsShouldPerformFullTickWhenPaused");
		SetIsShouldPerformFullTickWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsShouldPerformFullTickWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsShouldPerformFullTickWhenPaused_IsShould_PropertyAddress, SetIsShouldPerformFullTickWhenPaused_FunctionAddress, "IsShould");
		SetIsShouldPerformFullTickWhenPaused_IsShould_Offset = NativeReflectionCached.GetPropertyOffset(SetIsShouldPerformFullTickWhenPaused_FunctionAddress, "IsShould");
		SetIsShouldPerformFullTickWhenPaused_IsShould_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsShouldPerformFullTickWhenPaused_FunctionAddress, "IsShould", Classes.FBoolProperty);
		SetIsShouldPerformFullTickWhenPaused_IsValid = SetIsShouldPerformFullTickWhenPaused_FunctionAddress != IntPtr.Zero && SetIsShouldPerformFullTickWhenPaused_IsShould_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:SetIsShouldPerformFullTickWhenPaused", SetIsShouldPerformFullTickWhenPaused_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		OnRep_PlayerStateCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnRep_PlayerStateCS");
		OnRep_PlayerStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PlayerStateCS_FunctionAddress);
		OnRep_PlayerStateCS_IsValid = OnRep_PlayerStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:OnRep_PlayerStateCS", OnRep_PlayerStateCS_IsValid);
		OnRep_PawnCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnRep_PawnCS");
		OnRep_PawnCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PawnCS_FunctionAddress);
		OnRep_PawnCS_IsValid = OnRep_PawnCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:OnRep_PawnCS", OnRep_PawnCS_IsValid);
		OnPossessWithViewTargetBlend_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnPossessWithViewTargetBlend");
		OnPossessWithViewTargetBlend_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPossessWithViewTargetBlend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_InPawn_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "InPawn");
		OnPossessWithViewTargetBlend_InPawn_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "InPawn");
		OnPossessWithViewTargetBlend_InPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "InPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_BlendTime_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "BlendTime");
		OnPossessWithViewTargetBlend_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "BlendTime");
		OnPossessWithViewTargetBlend_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_BlendFunc_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "BlendFunc");
		OnPossessWithViewTargetBlend_BlendFunc_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "BlendFunc");
		OnPossessWithViewTargetBlend_BlendFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "BlendFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_BlendExp_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "BlendExp");
		OnPossessWithViewTargetBlend_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "BlendExp");
		OnPossessWithViewTargetBlend_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_bLockOutgoing_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "bLockOutgoing");
		OnPossessWithViewTargetBlend_bLockOutgoing_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "bLockOutgoing");
		OnPossessWithViewTargetBlend_bLockOutgoing_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "bLockOutgoing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPossessWithViewTargetBlend_EnableBlendViewTarget_PropertyAddress, OnPossessWithViewTargetBlend_FunctionAddress, "EnableBlendViewTarget");
		OnPossessWithViewTargetBlend_EnableBlendViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessWithViewTargetBlend_FunctionAddress, "EnableBlendViewTarget");
		OnPossessWithViewTargetBlend_EnableBlendViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessWithViewTargetBlend_FunctionAddress, "EnableBlendViewTarget", Classes.FBoolProperty);
		OnPossessWithViewTargetBlend_IsValid = OnPossessWithViewTargetBlend_FunctionAddress != IntPtr.Zero && OnPossessWithViewTargetBlend_InPawn_IsValid && OnPossessWithViewTargetBlend_BlendTime_IsValid && OnPossessWithViewTargetBlend_BlendFunc_IsValid && OnPossessWithViewTargetBlend_BlendExp_IsValid && OnPossessWithViewTargetBlend_bLockOutgoing_IsValid && OnPossessWithViewTargetBlend_EnableBlendViewTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:OnPossessWithViewTargetBlend", OnPossessWithViewTargetBlend_IsValid);
		InitInputSystemCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitInputSystemCS");
		InitInputSystemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitInputSystemCS_FunctionAddress);
		InitInputSystemCS_IsValid = InitInputSystemCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:InitInputSystemCS", InitInputSystemCS_IsValid);
		GetSpawnLocationCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSpawnLocationCS");
		GetSpawnLocationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpawnLocationCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpawnLocationCS_ReturnValue_PropertyAddress, GetSpawnLocationCS_FunctionAddress, "ReturnValue");
		GetSpawnLocationCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpawnLocationCS_FunctionAddress, "ReturnValue");
		GetSpawnLocationCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpawnLocationCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpawnLocationCS_IsValid = GetSpawnLocationCS_FunctionAddress != IntPtr.Zero && GetSpawnLocationCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetSpawnLocationCS", GetSpawnLocationCS_IsValid);
		GetSeamlessTravelActorListCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSeamlessTravelActorListCS");
		GetSeamlessTravelActorListCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeamlessTravelActorListCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSeamlessTravelActorListCS_bToEntry_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry");
		GetSeamlessTravelActorListCS_bToEntry_Offset = NativeReflectionCached.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry");
		GetSeamlessTravelActorListCS_bToEntry_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "bToEntry", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSeamlessTravelActorListCS_ActorList_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_Offset = NativeReflectionCached.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList", Classes.FArrayProperty);
		GetSeamlessTravelActorListCS_IsValid = GetSeamlessTravelActorListCS_FunctionAddress != IntPtr.Zero && GetSeamlessTravelActorListCS_bToEntry_IsValid && GetSeamlessTravelActorListCS_ActorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetSeamlessTravelActorListCS", GetSeamlessTravelActorListCS_IsValid);
		GetPlayerViewPointCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerViewPointCS");
		GetPlayerViewPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewPointCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewPointCS_out_Location_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "out_Location");
		GetPlayerViewPointCS_out_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "out_Location");
		GetPlayerViewPointCS_out_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "out_Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewPointCS_out_Rotation_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "out_Rotation");
		GetPlayerViewPointCS_out_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "out_Rotation");
		GetPlayerViewPointCS_out_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "out_Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewPointCS_ReturnValue_PropertyAddress, GetPlayerViewPointCS_FunctionAddress, "ReturnValue");
		GetPlayerViewPointCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewPointCS_FunctionAddress, "ReturnValue");
		GetPlayerViewPointCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPlayerViewPointCS_IsValid = GetPlayerViewPointCS_FunctionAddress != IntPtr.Zero && GetPlayerViewPointCS_out_Location_IsValid && GetPlayerViewPointCS_out_Rotation_IsValid && GetPlayerViewPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetPlayerViewPointCS", GetPlayerViewPointCS_IsValid);
		GetPendingViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPendingViewTarget");
		GetPendingViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPendingViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPendingViewTarget_ReturnValue_PropertyAddress, GetPendingViewTarget_FunctionAddress, "ReturnValue");
		GetPendingViewTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPendingViewTarget_FunctionAddress, "ReturnValue");
		GetPendingViewTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPendingViewTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPendingViewTarget_IsValid = GetPendingViewTarget_FunctionAddress != IntPtr.Zero && GetPendingViewTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetPendingViewTarget", GetPendingViewTarget_IsValid);
		GetNetConnectionCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNetConnectionCS");
		GetNetConnectionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNetConnectionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNetConnectionCS_ReturnValue_PropertyAddress, GetNetConnectionCS_FunctionAddress, "ReturnValue");
		GetNetConnectionCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNetConnectionCS_FunctionAddress, "ReturnValue");
		GetNetConnectionCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNetConnectionCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNetConnectionCS_IsValid = GetNetConnectionCS_FunctionAddress != IntPtr.Zero && GetNetConnectionCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetNetConnectionCS", GetNetConnectionCS_IsValid);
		GetIsShouldPerformFullTickWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsShouldPerformFullTickWhenPaused");
		GetIsShouldPerformFullTickWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsShouldPerformFullTickWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsShouldPerformFullTickWhenPaused_ReturnValue_PropertyAddress, GetIsShouldPerformFullTickWhenPaused_FunctionAddress, "ReturnValue");
		GetIsShouldPerformFullTickWhenPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsShouldPerformFullTickWhenPaused_FunctionAddress, "ReturnValue");
		GetIsShouldPerformFullTickWhenPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsShouldPerformFullTickWhenPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsShouldPerformFullTickWhenPaused_IsValid = GetIsShouldPerformFullTickWhenPaused_FunctionAddress != IntPtr.Zero && GetIsShouldPerformFullTickWhenPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetIsShouldPerformFullTickWhenPaused", GetIsShouldPerformFullTickWhenPaused_IsValid);
		GetCameraBlendTimeToGo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCameraBlendTimeToGo");
		GetCameraBlendTimeToGo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraBlendTimeToGo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraBlendTimeToGo_ReturnValue_PropertyAddress, GetCameraBlendTimeToGo_FunctionAddress, "ReturnValue");
		GetCameraBlendTimeToGo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraBlendTimeToGo_FunctionAddress, "ReturnValue");
		GetCameraBlendTimeToGo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraBlendTimeToGo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCameraBlendTimeToGo_IsValid = GetCameraBlendTimeToGo_FunctionAddress != IntPtr.Zero && GetCameraBlendTimeToGo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetCameraBlendTimeToGo", GetCameraBlendTimeToGo_IsValid);
		GetCachedConsoleWorldContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCachedConsoleWorldContext");
		GetCachedConsoleWorldContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedConsoleWorldContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedConsoleWorldContext_ReturnValue_PropertyAddress, GetCachedConsoleWorldContext_FunctionAddress, "ReturnValue");
		GetCachedConsoleWorldContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedConsoleWorldContext_FunctionAddress, "ReturnValue");
		GetCachedConsoleWorldContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedConsoleWorldContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCachedConsoleWorldContext_IsValid = GetCachedConsoleWorldContext_FunctionAddress != IntPtr.Zero && GetCachedConsoleWorldContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetCachedConsoleWorldContext", GetCachedConsoleWorldContext_IsValid);
		GetCachedConsoleCommandCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCachedConsoleCommandCS");
		GetCachedConsoleCommandCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedConsoleCommandCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedConsoleCommandCS_ReturnValue_PropertyAddress, GetCachedConsoleCommandCS_FunctionAddress, "ReturnValue");
		GetCachedConsoleCommandCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedConsoleCommandCS_FunctionAddress, "ReturnValue");
		GetCachedConsoleCommandCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedConsoleCommandCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCachedConsoleCommandCS_IsValid = GetCachedConsoleCommandCS_FunctionAddress != IntPtr.Zero && GetCachedConsoleCommandCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetCachedConsoleCommandCS", GetCachedConsoleCommandCS_IsValid);
		GetAudioListenerRotationCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAudioListenerRotationCS");
		GetAudioListenerRotationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioListenerRotationCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioListenerRotationCS_OutRotation_PropertyAddress, GetAudioListenerRotationCS_FunctionAddress, "OutRotation");
		GetAudioListenerRotationCS_OutRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioListenerRotationCS_FunctionAddress, "OutRotation");
		GetAudioListenerRotationCS_OutRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioListenerRotationCS_FunctionAddress, "OutRotation", Classes.FStructProperty);
		GetAudioListenerRotationCS_IsValid = GetAudioListenerRotationCS_FunctionAddress != IntPtr.Zero && GetAudioListenerRotationCS_OutRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetAudioListenerRotationCS", GetAudioListenerRotationCS_IsValid);
		GetAudioListenerPositionCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAudioListenerPositionCS");
		GetAudioListenerPositionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioListenerPositionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioListenerPositionCS_OutLocation_PropertyAddress, GetAudioListenerPositionCS_FunctionAddress, "OutLocation");
		GetAudioListenerPositionCS_OutLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioListenerPositionCS_FunctionAddress, "OutLocation");
		GetAudioListenerPositionCS_OutLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioListenerPositionCS_FunctionAddress, "OutLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioListenerPositionCS_OutFrontDir_PropertyAddress, GetAudioListenerPositionCS_FunctionAddress, "OutFrontDir");
		GetAudioListenerPositionCS_OutFrontDir_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioListenerPositionCS_FunctionAddress, "OutFrontDir");
		GetAudioListenerPositionCS_OutFrontDir_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioListenerPositionCS_FunctionAddress, "OutFrontDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioListenerPositionCS_OutRightDir_PropertyAddress, GetAudioListenerPositionCS_FunctionAddress, "OutRightDir");
		GetAudioListenerPositionCS_OutRightDir_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioListenerPositionCS_FunctionAddress, "OutRightDir");
		GetAudioListenerPositionCS_OutRightDir_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioListenerPositionCS_FunctionAddress, "OutRightDir", Classes.FStructProperty);
		GetAudioListenerPositionCS_IsValid = GetAudioListenerPositionCS_FunctionAddress != IntPtr.Zero && GetAudioListenerPositionCS_OutLocation_IsValid && GetAudioListenerPositionCS_OutFrontDir_IsValid && GetAudioListenerPositionCS_OutRightDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:GetAudioListenerPositionCS", GetAudioListenerPositionCS_IsValid);
		ConsoleCommandCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsoleCommandCS");
		ConsoleCommandCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsoleCommandCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsoleCommandCS_Command_PropertyAddress, ConsoleCommandCS_FunctionAddress, "Command");
		ConsoleCommandCS_Command_Offset = NativeReflectionCached.GetPropertyOffset(ConsoleCommandCS_FunctionAddress, "Command");
		ConsoleCommandCS_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsoleCommandCS_FunctionAddress, "Command", Classes.FStrProperty);
		ConsoleCommandCS_IsValid = ConsoleCommandCS_FunctionAddress != IntPtr.Zero && ConsoleCommandCS_Command_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:ConsoleCommandCS", ConsoleCommandCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGPPlayerController:BeginPlayCS", BeginPlayCS_IsValid);
	}
}
