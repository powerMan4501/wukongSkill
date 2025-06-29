using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWGameMode", "b1", UnrealModuleType.Game)]
public class ABGWGameMode : AGameMode
{
	private static bool StartPlayCS_IsValid;

	private IntPtr StartPlayCS_InstanceFunctionAddress;

	private static IntPtr StartPlayCS_FunctionAddress;

	private static int StartPlayCS_ParamsSize;

	private static bool RestartPlayerCS_IsValid;

	private IntPtr RestartPlayerCS_InstanceFunctionAddress;

	private static IntPtr RestartPlayerCS_FunctionAddress;

	private static int RestartPlayerCS_ParamsSize;

	private static bool RestartPlayerCS_NewPlayer_IsValid;

	private static FFieldAddress RestartPlayerCS_NewPlayer_PropertyAddress;

	private static int RestartPlayerCS_NewPlayer_Offset;

	private static bool RestartGameCS_IsValid;

	private IntPtr RestartGameCS_InstanceFunctionAddress;

	private static IntPtr RestartGameCS_FunctionAddress;

	private static int RestartGameCS_ParamsSize;

	private static bool PreLoginCS_IsValid;

	private IntPtr PreLoginCS_InstanceFunctionAddress;

	private static IntPtr PreLoginCS_FunctionAddress;

	private static int PreLoginCS_ParamsSize;

	private static bool PreLoginCS_Options_IsValid;

	private static FFieldAddress PreLoginCS_Options_PropertyAddress;

	private static int PreLoginCS_Options_Offset;

	private static bool PreLoginCS_LoginAddress_IsValid;

	private static FFieldAddress PreLoginCS_LoginAddress_PropertyAddress;

	private static int PreLoginCS_LoginAddress_Offset;

	private static bool PreLoginCS_UniqueId_IsValid;

	private static FFieldAddress PreLoginCS_UniqueId_PropertyAddress;

	private static int PreLoginCS_UniqueId_Offset;

	private static bool PreLoginCS_ErrorMessage_IsValid;

	private static FFieldAddress PreLoginCS_ErrorMessage_PropertyAddress;

	private static int PreLoginCS_ErrorMessage_Offset;

	private static bool PreInitializeComponentsCS_IsValid;

	private IntPtr PreInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PreInitializeComponentsCS_FunctionAddress;

	private static int PreInitializeComponentsCS_ParamsSize;

	private static bool PostSeamlessTravelCS_IsValid;

	private IntPtr PostSeamlessTravelCS_InstanceFunctionAddress;

	private static IntPtr PostSeamlessTravelCS_FunctionAddress;

	private static int PostSeamlessTravelCS_ParamsSize;

	private static bool PostLoginCS_IsValid;

	private IntPtr PostLoginCS_InstanceFunctionAddress;

	private static IntPtr PostLoginCS_FunctionAddress;

	private static int PostLoginCS_ParamsSize;

	private static bool PostLoginCS_NewPlayer_IsValid;

	private static FFieldAddress PostLoginCS_NewPlayer_PropertyAddress;

	private static int PostLoginCS_NewPlayer_Offset;

	private static bool PostInitPropertiesCS_IsValid;

	private IntPtr PostInitPropertiesCS_InstanceFunctionAddress;

	private static IntPtr PostInitPropertiesCS_FunctionAddress;

	private static int PostInitPropertiesCS_ParamsSize;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool LoginOutCS_IsValid;

	private IntPtr LoginOutCS_InstanceFunctionAddress;

	private static IntPtr LoginOutCS_FunctionAddress;

	private static int LoginOutCS_ParamsSize;

	private static bool LoginOutCS_Exiting_IsValid;

	private static FFieldAddress LoginOutCS_Exiting_PropertyAddress;

	private static int LoginOutCS_Exiting_Offset;

	private static bool IsMovieRendering_IsValid;

	private IntPtr IsMovieRendering_InstanceFunctionAddress;

	private static IntPtr IsMovieRendering_FunctionAddress;

	private static int IsMovieRendering_ParamsSize;

	private static bool IsMovieRendering_ReturnValue_IsValid;

	private static FFieldAddress IsMovieRendering_ReturnValue_PropertyAddress;

	private static int IsMovieRendering_ReturnValue_Offset;

	private static bool InitGameCS_IsValid;

	private IntPtr InitGameCS_InstanceFunctionAddress;

	private static IntPtr InitGameCS_FunctionAddress;

	private static int InitGameCS_ParamsSize;

	private static bool InitGameCS_MapName_IsValid;

	private static FFieldAddress InitGameCS_MapName_PropertyAddress;

	private static int InitGameCS_MapName_Offset;

	private static bool InitGameCS_Options_IsValid;

	private static FFieldAddress InitGameCS_Options_PropertyAddress;

	private static int InitGameCS_Options_Offset;

	private static bool InitGameCS_ErrorMessag_IsValid;

	private static FFieldAddress InitGameCS_ErrorMessag_PropertyAddress;

	private static int InitGameCS_ErrorMessag_Offset;

	private static bool HandleStartingNewPlayerCS_IsValid;

	private IntPtr HandleStartingNewPlayerCS_InstanceFunctionAddress;

	private static IntPtr HandleStartingNewPlayerCS_FunctionAddress;

	private static int HandleStartingNewPlayerCS_ParamsSize;

	private static bool HandleStartingNewPlayerCS_NewPlayer_IsValid;

	private static FFieldAddress HandleStartingNewPlayerCS_NewPlayer_PropertyAddress;

	private static int HandleStartingNewPlayerCS_NewPlayer_Offset;

	private static bool HandleMatchIsWaitingToStartCS_IsValid;

	private IntPtr HandleMatchIsWaitingToStartCS_InstanceFunctionAddress;

	private static IntPtr HandleMatchIsWaitingToStartCS_FunctionAddress;

	private static int HandleMatchIsWaitingToStartCS_ParamsSize;

	private static bool HandleMatchHasStartedCS_IsValid;

	private IntPtr HandleMatchHasStartedCS_InstanceFunctionAddress;

	private static IntPtr HandleMatchHasStartedCS_FunctionAddress;

	private static int HandleMatchHasStartedCS_ParamsSize;

	private static bool HandleLeavingMapCS_IsValid;

	private IntPtr HandleLeavingMapCS_InstanceFunctionAddress;

	private static IntPtr HandleLeavingMapCS_FunctionAddress;

	private static int HandleLeavingMapCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_IsValid;

	private IntPtr GetSeamlessTravelActorListCS_InstanceFunctionAddress;

	private static IntPtr GetSeamlessTravelActorListCS_FunctionAddress;

	private static int GetSeamlessTravelActorListCS_ParamsSize;

	private static bool GetSeamlessTravelActorListCS_bToTransition_IsValid;

	private static FFieldAddress GetSeamlessTravelActorListCS_bToTransition_PropertyAddress;

	private static int GetSeamlessTravelActorListCS_bToTransition_Offset;

	private static bool GetSeamlessTravelActorListCS_ActorList_IsValid;

	private static FFieldAddress GetSeamlessTravelActorListCS_ActorList_PropertyAddress;

	private static int GetSeamlessTravelActorListCS_ActorList_Offset;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	private static bool BeginEndPlayCS_IsValid;

	private IntPtr BeginEndPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginEndPlayCS_FunctionAddress;

	private static int BeginEndPlayCS_ParamsSize;

	private static bool BeginEndPlayCS_EndPlayReason_IsValid;

	private static FFieldAddress BeginEndPlayCS_EndPlayReason_PropertyAddress;

	private static int BeginEndPlayCS_EndPlayReason_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:StartPlayCS")]
	public unsafe void StartPlayCS()
	{
		CheckDestroyed();
		if (!StartPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:StartPlayCS");
			return;
		}
		if (StartPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			StartPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "StartPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPlayCS_InstanceFunctionAddress, argsSize: StartPlayCS_ParamsSize);
	}

	protected unsafe virtual void StartPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!StartPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:StartPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartPlayCS_FunctionAddress, argsSize: StartPlayCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:RestartPlayerCS")]
	public unsafe void RestartPlayerCS(AController NewPlayer)
	{
		CheckDestroyed();
		if (!RestartPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:RestartPlayerCS");
			return;
		}
		if (RestartPlayerCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RestartPlayerCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RestartPlayerCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, RestartPlayerCS_NewPlayer_Offset), 0, RestartPlayerCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartPlayerCS_InstanceFunctionAddress, intPtr, RestartPlayerCS_ParamsSize);
	}

	protected unsafe virtual void RestartPlayerCS_Implementation(AController NewPlayer)
	{
		CheckDestroyed();
		if (!RestartPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:RestartPlayerCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, RestartPlayerCS_NewPlayer_Offset), 0, RestartPlayerCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestartPlayerCS_FunctionAddress, intPtr, RestartPlayerCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:RestartGameCS")]
	public unsafe void RestartGameCS()
	{
		CheckDestroyed();
		if (!RestartGameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:RestartGameCS");
			return;
		}
		if (RestartGameCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RestartGameCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RestartGameCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartGameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartGameCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RestartGameCS_InstanceFunctionAddress, argsSize: RestartGameCS_ParamsSize);
	}

	protected unsafe virtual void RestartGameCS_Implementation()
	{
		CheckDestroyed();
		if (!RestartGameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:RestartGameCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartGameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartGameCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RestartGameCS_FunctionAddress, argsSize: RestartGameCS_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.BGWGameMode:PreLoginCS")]
	public unsafe void PreLoginCS(string Options, string LoginAddress, string UniqueId, out string ErrorMessage)
	{
		CheckDestroyed();
		if (!PreLoginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PreLoginCS");
			ErrorMessage = FStringMarshaler.DefaultString;
			return;
		}
		if (PreLoginCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreLoginCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreLoginCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreLoginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreLoginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_Options_Offset), 0, PreLoginCS_Options_PropertyAddress.Address, Options);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_LoginAddress_Offset), 0, PreLoginCS_LoginAddress_PropertyAddress.Address, LoginAddress);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_UniqueId_Offset), 0, PreLoginCS_UniqueId_PropertyAddress.Address, UniqueId);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreLoginCS_InstanceFunctionAddress, intPtr, PreLoginCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_Options_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_LoginAddress_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_UniqueId_PropertyAddress.Address, intPtr);
		ErrorMessage = FStringMarshaler.FromNative(IntPtr.Add(intPtr, PreLoginCS_ErrorMessage_Offset), 0, PreLoginCS_ErrorMessage_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_ErrorMessage_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void PreLoginCS_Implementation(string Options, string LoginAddress, string UniqueId, out string ErrorMessage)
	{
		CheckDestroyed();
		if (!PreLoginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PreLoginCS");
			ErrorMessage = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreLoginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreLoginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_Options_Offset), 0, PreLoginCS_Options_PropertyAddress.Address, Options);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_LoginAddress_Offset), 0, PreLoginCS_LoginAddress_PropertyAddress.Address, LoginAddress);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PreLoginCS_UniqueId_Offset), 0, PreLoginCS_UniqueId_PropertyAddress.Address, UniqueId);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreLoginCS_FunctionAddress, intPtr, PreLoginCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_Options_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_LoginAddress_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_UniqueId_PropertyAddress.Address, intPtr);
		ErrorMessage = FStringMarshaler.FromNative(IntPtr.Add(intPtr, PreLoginCS_ErrorMessage_Offset), 0, PreLoginCS_ErrorMessage_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PreLoginCS_ErrorMessage_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:PreInitializeComponentsCS")]
	public unsafe void PreInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PreInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PreInitializeComponentsCS");
			return;
		}
		if (PreInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreInitializeComponentsCS_InstanceFunctionAddress, argsSize: PreInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PreInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PreInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PreInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreInitializeComponentsCS_FunctionAddress, argsSize: PreInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:PostSeamlessTravelCS")]
	public unsafe void PostSeamlessTravelCS()
	{
		CheckDestroyed();
		if (!PostSeamlessTravelCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostSeamlessTravelCS");
			return;
		}
		if (PostSeamlessTravelCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostSeamlessTravelCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostSeamlessTravelCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostSeamlessTravelCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostSeamlessTravelCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostSeamlessTravelCS_InstanceFunctionAddress, argsSize: PostSeamlessTravelCS_ParamsSize);
	}

	protected unsafe virtual void PostSeamlessTravelCS_Implementation()
	{
		CheckDestroyed();
		if (!PostSeamlessTravelCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostSeamlessTravelCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostSeamlessTravelCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostSeamlessTravelCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostSeamlessTravelCS_FunctionAddress, argsSize: PostSeamlessTravelCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:PostLoginCS")]
	public unsafe void PostLoginCS(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!PostLoginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostLoginCS");
			return;
		}
		if (PostLoginCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostLoginCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostLoginCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostLoginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostLoginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, PostLoginCS_NewPlayer_Offset), 0, PostLoginCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostLoginCS_InstanceFunctionAddress, intPtr, PostLoginCS_ParamsSize);
	}

	protected unsafe virtual void PostLoginCS_Implementation(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!PostLoginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostLoginCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostLoginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostLoginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, PostLoginCS_NewPlayer_Offset), 0, PostLoginCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostLoginCS_FunctionAddress, intPtr, PostLoginCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:PostInitPropertiesCS")]
	public unsafe void PostInitPropertiesCS()
	{
		CheckDestroyed();
		if (!PostInitPropertiesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostInitPropertiesCS");
			return;
		}
		if (PostInitPropertiesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitPropertiesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitPropertiesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitPropertiesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitPropertiesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitPropertiesCS_InstanceFunctionAddress, argsSize: PostInitPropertiesCS_ParamsSize);
	}

	protected unsafe virtual void PostInitPropertiesCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitPropertiesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostInitPropertiesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitPropertiesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitPropertiesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitPropertiesCS_FunctionAddress, argsSize: PostInitPropertiesCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:PostInitializeComponentsCS")]
	public unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostInitializeComponentsCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:LoginOutCS")]
	public unsafe void LoginOutCS(AController Exiting)
	{
		CheckDestroyed();
		if (!LoginOutCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:LoginOutCS");
			return;
		}
		if (LoginOutCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			LoginOutCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "LoginOutCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoginOutCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoginOutCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, LoginOutCS_Exiting_Offset), 0, LoginOutCS_Exiting_PropertyAddress.Address, Exiting);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoginOutCS_InstanceFunctionAddress, intPtr, LoginOutCS_ParamsSize);
	}

	protected unsafe virtual void LoginOutCS_Implementation(AController Exiting)
	{
		CheckDestroyed();
		if (!LoginOutCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:LoginOutCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoginOutCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoginOutCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, LoginOutCS_Exiting_Offset), 0, LoginOutCS_Exiting_PropertyAddress.Address, Exiting);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoginOutCS_FunctionAddress, intPtr, LoginOutCS_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.BGWGameMode:IsMovieRendering")]
	public unsafe bool IsMovieRendering()
	{
		CheckDestroyed();
		if (!IsMovieRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:IsMovieRendering");
			return false;
		}
		if (IsMovieRendering_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsMovieRendering_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsMovieRendering");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMovieRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMovieRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMovieRendering_InstanceFunctionAddress, intPtr, IsMovieRendering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMovieRendering_ReturnValue_Offset), 0, IsMovieRendering_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsMovieRendering_Implementation()
	{
		CheckDestroyed();
		if (!IsMovieRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:IsMovieRendering");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMovieRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMovieRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMovieRendering_FunctionAddress, intPtr, IsMovieRendering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMovieRendering_ReturnValue_Offset), 0, IsMovieRendering_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.BGWGameMode:InitGameCS")]
	public unsafe void InitGameCS(string MapName, string Options, out string ErrorMessag)
	{
		CheckDestroyed();
		if (!InitGameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:InitGameCS");
			ErrorMessag = FStringMarshaler.DefaultString;
			return;
		}
		if (InitGameCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitGameCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitGameCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitGameCS_MapName_Offset), 0, InitGameCS_MapName_PropertyAddress.Address, MapName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitGameCS_Options_Offset), 0, InitGameCS_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitGameCS_InstanceFunctionAddress, intPtr, InitGameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitGameCS_MapName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitGameCS_Options_PropertyAddress.Address, intPtr);
		ErrorMessag = FStringMarshaler.FromNative(IntPtr.Add(intPtr, InitGameCS_ErrorMessag_Offset), 0, InitGameCS_ErrorMessag_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(InitGameCS_ErrorMessag_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void InitGameCS_Implementation(string MapName, string Options, out string ErrorMessag)
	{
		CheckDestroyed();
		if (!InitGameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:InitGameCS");
			ErrorMessag = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitGameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitGameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitGameCS_MapName_Offset), 0, InitGameCS_MapName_PropertyAddress.Address, MapName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitGameCS_Options_Offset), 0, InitGameCS_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitGameCS_FunctionAddress, intPtr, InitGameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitGameCS_MapName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitGameCS_Options_PropertyAddress.Address, intPtr);
		ErrorMessag = FStringMarshaler.FromNative(IntPtr.Add(intPtr, InitGameCS_ErrorMessag_Offset), 0, InitGameCS_ErrorMessag_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(InitGameCS_ErrorMessag_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:HandleStartingNewPlayerCS")]
	public unsafe void HandleStartingNewPlayerCS(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!HandleStartingNewPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleStartingNewPlayerCS");
			return;
		}
		if (HandleStartingNewPlayerCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleStartingNewPlayerCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleStartingNewPlayerCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleStartingNewPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleStartingNewPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HandleStartingNewPlayerCS_NewPlayer_Offset), 0, HandleStartingNewPlayerCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleStartingNewPlayerCS_InstanceFunctionAddress, intPtr, HandleStartingNewPlayerCS_ParamsSize);
	}

	protected unsafe virtual void HandleStartingNewPlayerCS_Implementation(APlayerController NewPlayer)
	{
		CheckDestroyed();
		if (!HandleStartingNewPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleStartingNewPlayerCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleStartingNewPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleStartingNewPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HandleStartingNewPlayerCS_NewPlayer_Offset), 0, HandleStartingNewPlayerCS_NewPlayer_PropertyAddress.Address, NewPlayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleStartingNewPlayerCS_FunctionAddress, intPtr, HandleStartingNewPlayerCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:HandleMatchIsWaitingToStartCS")]
	public unsafe void HandleMatchIsWaitingToStartCS()
	{
		CheckDestroyed();
		if (!HandleMatchIsWaitingToStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleMatchIsWaitingToStartCS");
			return;
		}
		if (HandleMatchIsWaitingToStartCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleMatchIsWaitingToStartCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleMatchIsWaitingToStartCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchIsWaitingToStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchIsWaitingToStartCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchIsWaitingToStartCS_InstanceFunctionAddress, argsSize: HandleMatchIsWaitingToStartCS_ParamsSize);
	}

	protected unsafe virtual void HandleMatchIsWaitingToStartCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleMatchIsWaitingToStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleMatchIsWaitingToStartCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchIsWaitingToStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchIsWaitingToStartCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchIsWaitingToStartCS_FunctionAddress, argsSize: HandleMatchIsWaitingToStartCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:HandleMatchHasStartedCS")]
	public unsafe void HandleMatchHasStartedCS()
	{
		CheckDestroyed();
		if (!HandleMatchHasStartedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleMatchHasStartedCS");
			return;
		}
		if (HandleMatchHasStartedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleMatchHasStartedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleMatchHasStartedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasStartedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasStartedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasStartedCS_InstanceFunctionAddress, argsSize: HandleMatchHasStartedCS_ParamsSize);
	}

	protected unsafe virtual void HandleMatchHasStartedCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleMatchHasStartedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleMatchHasStartedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasStartedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasStartedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasStartedCS_FunctionAddress, argsSize: HandleMatchHasStartedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:HandleLeavingMapCS")]
	public unsafe void HandleLeavingMapCS()
	{
		CheckDestroyed();
		if (!HandleLeavingMapCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleLeavingMapCS");
			return;
		}
		if (HandleLeavingMapCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleLeavingMapCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleLeavingMapCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleLeavingMapCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleLeavingMapCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleLeavingMapCS_InstanceFunctionAddress, argsSize: HandleLeavingMapCS_ParamsSize);
	}

	protected unsafe virtual void HandleLeavingMapCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleLeavingMapCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:HandleLeavingMapCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleLeavingMapCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleLeavingMapCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleLeavingMapCS_FunctionAddress, argsSize: HandleLeavingMapCS_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/b1.BGWGameMode:GetSeamlessTravelActorListCS")]
	public unsafe void GetSeamlessTravelActorListCS(bool bToTransition, out List<AActor> ActorList)
	{
		CheckDestroyed();
		if (!GetSeamlessTravelActorListCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:GetSeamlessTravelActorListCS");
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
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_bToTransition_Offset), 0, GetSeamlessTravelActorListCS_bToTransition_PropertyAddress.Address, bToTransition);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeamlessTravelActorListCS_InstanceFunctionAddress, intPtr, GetSeamlessTravelActorListCS_ParamsSize);
		ActorList = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_ActorList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSeamlessTravelActorListCS_ActorList_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GetSeamlessTravelActorListCS_Implementation(bool bToTransition, out List<AActor> ActorList)
	{
		CheckDestroyed();
		if (!GetSeamlessTravelActorListCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:GetSeamlessTravelActorListCS");
			ActorList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSeamlessTravelActorListCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSeamlessTravelActorListCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_bToTransition_Offset), 0, GetSeamlessTravelActorListCS_bToTransition_PropertyAddress.Address, bToTransition);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeamlessTravelActorListCS_FunctionAddress, intPtr, GetSeamlessTravelActorListCS_ParamsSize);
		ActorList = new TArrayCopyMarshaler<AActor>(1, GetSeamlessTravelActorListCS_ActorList_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSeamlessTravelActorListCS_ActorList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSeamlessTravelActorListCS_ActorList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:BeginPlayCS")]
	public unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:BeginPlayCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameMode:BeginEndPlayCS")]
	public unsafe void BeginEndPlayCS(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!BeginEndPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:BeginEndPlayCS");
			return;
		}
		if (BeginEndPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginEndPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginEndPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginEndPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginEndPlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, BeginEndPlayCS_EndPlayReason_Offset), 0, BeginEndPlayCS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginEndPlayCS_InstanceFunctionAddress, intPtr, BeginEndPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginEndPlayCS_Implementation(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!BeginEndPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameMode:BeginEndPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginEndPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginEndPlayCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, BeginEndPlayCS_EndPlayReason_Offset), 0, BeginEndPlayCS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, BeginEndPlayCS_FunctionAddress, intPtr, BeginEndPlayCS_ParamsSize);
	}

	static ABGWGameMode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWGameMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWGameMode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWGameMode");
		StartPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartPlayCS");
		StartPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(StartPlayCS_FunctionAddress);
		StartPlayCS_IsValid = StartPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:StartPlayCS", StartPlayCS_IsValid);
		RestartPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RestartPlayerCS");
		RestartPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartPlayerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartPlayerCS_NewPlayer_PropertyAddress, RestartPlayerCS_FunctionAddress, "NewPlayer");
		RestartPlayerCS_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(RestartPlayerCS_FunctionAddress, "NewPlayer");
		RestartPlayerCS_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartPlayerCS_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		RestartPlayerCS_IsValid = RestartPlayerCS_FunctionAddress != IntPtr.Zero && RestartPlayerCS_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:RestartPlayerCS", RestartPlayerCS_IsValid);
		RestartGameCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RestartGameCS");
		RestartGameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartGameCS_FunctionAddress);
		RestartGameCS_IsValid = RestartGameCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:RestartGameCS", RestartGameCS_IsValid);
		PreLoginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreLoginCS");
		PreLoginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreLoginCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PreLoginCS_Options_PropertyAddress, PreLoginCS_FunctionAddress, "Options");
		PreLoginCS_Options_Offset = NativeReflectionCached.GetPropertyOffset(PreLoginCS_FunctionAddress, "Options");
		PreLoginCS_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(PreLoginCS_FunctionAddress, "Options", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PreLoginCS_LoginAddress_PropertyAddress, PreLoginCS_FunctionAddress, "LoginAddress");
		PreLoginCS_LoginAddress_Offset = NativeReflectionCached.GetPropertyOffset(PreLoginCS_FunctionAddress, "LoginAddress");
		PreLoginCS_LoginAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(PreLoginCS_FunctionAddress, "LoginAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PreLoginCS_UniqueId_PropertyAddress, PreLoginCS_FunctionAddress, "UniqueId");
		PreLoginCS_UniqueId_Offset = NativeReflectionCached.GetPropertyOffset(PreLoginCS_FunctionAddress, "UniqueId");
		PreLoginCS_UniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(PreLoginCS_FunctionAddress, "UniqueId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PreLoginCS_ErrorMessage_PropertyAddress, PreLoginCS_FunctionAddress, "ErrorMessage");
		PreLoginCS_ErrorMessage_Offset = NativeReflectionCached.GetPropertyOffset(PreLoginCS_FunctionAddress, "ErrorMessage");
		PreLoginCS_ErrorMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(PreLoginCS_FunctionAddress, "ErrorMessage", Classes.FStrProperty);
		PreLoginCS_IsValid = PreLoginCS_FunctionAddress != IntPtr.Zero && PreLoginCS_Options_IsValid && PreLoginCS_LoginAddress_IsValid && PreLoginCS_UniqueId_IsValid && PreLoginCS_ErrorMessage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PreLoginCS", PreLoginCS_IsValid);
		PreInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreInitializeComponentsCS");
		PreInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreInitializeComponentsCS_FunctionAddress);
		PreInitializeComponentsCS_IsValid = PreInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PreInitializeComponentsCS", PreInitializeComponentsCS_IsValid);
		PostSeamlessTravelCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostSeamlessTravelCS");
		PostSeamlessTravelCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostSeamlessTravelCS_FunctionAddress);
		PostSeamlessTravelCS_IsValid = PostSeamlessTravelCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PostSeamlessTravelCS", PostSeamlessTravelCS_IsValid);
		PostLoginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostLoginCS");
		PostLoginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoginCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostLoginCS_NewPlayer_PropertyAddress, PostLoginCS_FunctionAddress, "NewPlayer");
		PostLoginCS_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(PostLoginCS_FunctionAddress, "NewPlayer");
		PostLoginCS_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(PostLoginCS_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		PostLoginCS_IsValid = PostLoginCS_FunctionAddress != IntPtr.Zero && PostLoginCS_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PostLoginCS", PostLoginCS_IsValid);
		PostInitPropertiesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostInitPropertiesCS");
		PostInitPropertiesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitPropertiesCS_FunctionAddress);
		PostInitPropertiesCS_IsValid = PostInitPropertiesCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PostInitPropertiesCS", PostInitPropertiesCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		LoginOutCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoginOutCS");
		LoginOutCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LoginOutCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoginOutCS_Exiting_PropertyAddress, LoginOutCS_FunctionAddress, "Exiting");
		LoginOutCS_Exiting_Offset = NativeReflectionCached.GetPropertyOffset(LoginOutCS_FunctionAddress, "Exiting");
		LoginOutCS_Exiting_IsValid = NativeReflectionCached.ValidatePropertyClass(LoginOutCS_FunctionAddress, "Exiting", Classes.FObjectProperty);
		LoginOutCS_IsValid = LoginOutCS_FunctionAddress != IntPtr.Zero && LoginOutCS_Exiting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:LoginOutCS", LoginOutCS_IsValid);
		IsMovieRendering_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsMovieRendering");
		IsMovieRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMovieRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMovieRendering_ReturnValue_PropertyAddress, IsMovieRendering_FunctionAddress, "ReturnValue");
		IsMovieRendering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMovieRendering_FunctionAddress, "ReturnValue");
		IsMovieRendering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMovieRendering_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMovieRendering_IsValid = IsMovieRendering_FunctionAddress != IntPtr.Zero && IsMovieRendering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:IsMovieRendering", IsMovieRendering_IsValid);
		InitGameCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitGameCS");
		InitGameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitGameCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitGameCS_MapName_PropertyAddress, InitGameCS_FunctionAddress, "MapName");
		InitGameCS_MapName_Offset = NativeReflectionCached.GetPropertyOffset(InitGameCS_FunctionAddress, "MapName");
		InitGameCS_MapName_IsValid = NativeReflectionCached.ValidatePropertyClass(InitGameCS_FunctionAddress, "MapName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitGameCS_Options_PropertyAddress, InitGameCS_FunctionAddress, "Options");
		InitGameCS_Options_Offset = NativeReflectionCached.GetPropertyOffset(InitGameCS_FunctionAddress, "Options");
		InitGameCS_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(InitGameCS_FunctionAddress, "Options", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitGameCS_ErrorMessag_PropertyAddress, InitGameCS_FunctionAddress, "ErrorMessag");
		InitGameCS_ErrorMessag_Offset = NativeReflectionCached.GetPropertyOffset(InitGameCS_FunctionAddress, "ErrorMessag");
		InitGameCS_ErrorMessag_IsValid = NativeReflectionCached.ValidatePropertyClass(InitGameCS_FunctionAddress, "ErrorMessag", Classes.FStrProperty);
		InitGameCS_IsValid = InitGameCS_FunctionAddress != IntPtr.Zero && InitGameCS_MapName_IsValid && InitGameCS_Options_IsValid && InitGameCS_ErrorMessag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:InitGameCS", InitGameCS_IsValid);
		HandleStartingNewPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleStartingNewPlayerCS");
		HandleStartingNewPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleStartingNewPlayerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleStartingNewPlayerCS_NewPlayer_PropertyAddress, HandleStartingNewPlayerCS_FunctionAddress, "NewPlayer");
		HandleStartingNewPlayerCS_NewPlayer_Offset = NativeReflectionCached.GetPropertyOffset(HandleStartingNewPlayerCS_FunctionAddress, "NewPlayer");
		HandleStartingNewPlayerCS_NewPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleStartingNewPlayerCS_FunctionAddress, "NewPlayer", Classes.FObjectProperty);
		HandleStartingNewPlayerCS_IsValid = HandleStartingNewPlayerCS_FunctionAddress != IntPtr.Zero && HandleStartingNewPlayerCS_NewPlayer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:HandleStartingNewPlayerCS", HandleStartingNewPlayerCS_IsValid);
		HandleMatchIsWaitingToStartCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleMatchIsWaitingToStartCS");
		HandleMatchIsWaitingToStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchIsWaitingToStartCS_FunctionAddress);
		HandleMatchIsWaitingToStartCS_IsValid = HandleMatchIsWaitingToStartCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:HandleMatchIsWaitingToStartCS", HandleMatchIsWaitingToStartCS_IsValid);
		HandleMatchHasStartedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleMatchHasStartedCS");
		HandleMatchHasStartedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchHasStartedCS_FunctionAddress);
		HandleMatchHasStartedCS_IsValid = HandleMatchHasStartedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:HandleMatchHasStartedCS", HandleMatchHasStartedCS_IsValid);
		HandleLeavingMapCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleLeavingMapCS");
		HandleLeavingMapCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleLeavingMapCS_FunctionAddress);
		HandleLeavingMapCS_IsValid = HandleLeavingMapCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:HandleLeavingMapCS", HandleLeavingMapCS_IsValid);
		GetSeamlessTravelActorListCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSeamlessTravelActorListCS");
		GetSeamlessTravelActorListCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeamlessTravelActorListCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSeamlessTravelActorListCS_bToTransition_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition");
		GetSeamlessTravelActorListCS_bToTransition_Offset = NativeReflectionCached.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition");
		GetSeamlessTravelActorListCS_bToTransition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "bToTransition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSeamlessTravelActorListCS_ActorList_PropertyAddress, GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_Offset = NativeReflectionCached.GetPropertyOffset(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList");
		GetSeamlessTravelActorListCS_ActorList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeamlessTravelActorListCS_FunctionAddress, "ActorList", Classes.FArrayProperty);
		GetSeamlessTravelActorListCS_IsValid = GetSeamlessTravelActorListCS_FunctionAddress != IntPtr.Zero && GetSeamlessTravelActorListCS_bToTransition_IsValid && GetSeamlessTravelActorListCS_ActorList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:GetSeamlessTravelActorListCS", GetSeamlessTravelActorListCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:BeginPlayCS", BeginPlayCS_IsValid);
		BeginEndPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginEndPlayCS");
		BeginEndPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginEndPlayCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginEndPlayCS_EndPlayReason_PropertyAddress, BeginEndPlayCS_FunctionAddress, "EndPlayReason");
		BeginEndPlayCS_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(BeginEndPlayCS_FunctionAddress, "EndPlayReason");
		BeginEndPlayCS_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginEndPlayCS_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		BeginEndPlayCS_IsValid = BeginEndPlayCS_FunctionAddress != IntPtr.Zero && BeginEndPlayCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameMode:BeginEndPlayCS", BeginEndPlayCS_IsValid);
	}
}
