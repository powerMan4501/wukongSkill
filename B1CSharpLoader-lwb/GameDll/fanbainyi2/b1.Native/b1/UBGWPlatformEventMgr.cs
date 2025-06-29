using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWPlatformEventMgr", "b1", UnrealModuleType.Game)]
public class UBGWPlatformEventMgr : UObject
{
	private static bool OnUserLoginChangeCS_IsValid;

	private IntPtr OnUserLoginChangeCS_InstanceFunctionAddress;

	private static IntPtr OnUserLoginChangeCS_FunctionAddress;

	private static int OnUserLoginChangeCS_ParamsSize;

	private static bool OnUserLoginChangeCS_bIsSignIn_IsValid;

	private static FFieldAddress OnUserLoginChangeCS_bIsSignIn_PropertyAddress;

	private static int OnUserLoginChangeCS_bIsSignIn_Offset;

	private static bool OnUserLoginChangeCS_PlatformUserId_IsValid;

	private static FFieldAddress OnUserLoginChangeCS_PlatformUserId_PropertyAddress;

	private static int OnUserLoginChangeCS_PlatformUserId_Offset;

	private static bool OnUserLoginChangeCS_UserIndex_IsValid;

	private static FFieldAddress OnUserLoginChangeCS_UserIndex_PropertyAddress;

	private static int OnUserLoginChangeCS_UserIndex_Offset;

	private static bool OnNetworkInitializedChangeCS_IsValid;

	private IntPtr OnNetworkInitializedChangeCS_InstanceFunctionAddress;

	private static IntPtr OnNetworkInitializedChangeCS_FunctionAddress;

	private static int OnNetworkInitializedChangeCS_ParamsSize;

	private static bool OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid;

	private static FFieldAddress OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress;

	private static int OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset;

	private static bool OnApplicationTerminateCS_IsValid;

	private IntPtr OnApplicationTerminateCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationTerminateCS_FunctionAddress;

	private static int OnApplicationTerminateCS_ParamsSize;

	private static bool OnApplicationSuspendCS_IsValid;

	private IntPtr OnApplicationSuspendCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationSuspendCS_FunctionAddress;

	private static int OnApplicationSuspendCS_ParamsSize;

	private static bool OnApplicationResumeCS_IsValid;

	private IntPtr OnApplicationResumeCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationResumeCS_FunctionAddress;

	private static int OnApplicationResumeCS_ParamsSize;

	private static bool OnApplicationReactivatedCS_IsValid;

	private IntPtr OnApplicationReactivatedCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationReactivatedCS_FunctionAddress;

	private static int OnApplicationReactivatedCS_ParamsSize;

	private static bool OnApplicationPreExitCS_IsValid;

	private IntPtr OnApplicationPreExitCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationPreExitCS_FunctionAddress;

	private static int OnApplicationPreExitCS_ParamsSize;

	private static bool OnApplicationInitCS_IsValid;

	private IntPtr OnApplicationInitCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationInitCS_FunctionAddress;

	private static int OnApplicationInitCS_ParamsSize;

	private static bool OnApplicationExitCS_IsValid;

	private IntPtr OnApplicationExitCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationExitCS_FunctionAddress;

	private static int OnApplicationExitCS_ParamsSize;

	private static bool OnApplicationDeactivateCS_IsValid;

	private IntPtr OnApplicationDeactivateCS_InstanceFunctionAddress;

	private static IntPtr OnApplicationDeactivateCS_FunctionAddress;

	private static int OnApplicationDeactivateCS_ParamsSize;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnUserLoginChangeCS")]
	protected unsafe void OnUserLoginChangeCS(bool bIsSignIn, int PlatformUserId, int UserIndex)
	{
		CheckDestroyed();
		if (!OnUserLoginChangeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnUserLoginChangeCS");
			return;
		}
		if (OnUserLoginChangeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnUserLoginChangeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnUserLoginChangeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUserLoginChangeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUserLoginChangeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_bIsSignIn_Offset), 0, OnUserLoginChangeCS_bIsSignIn_PropertyAddress.Address, bIsSignIn);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_PlatformUserId_Offset), 0, OnUserLoginChangeCS_PlatformUserId_PropertyAddress.Address, PlatformUserId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_UserIndex_Offset), 0, OnUserLoginChangeCS_UserIndex_PropertyAddress.Address, UserIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUserLoginChangeCS_InstanceFunctionAddress, intPtr, OnUserLoginChangeCS_ParamsSize);
	}

	protected unsafe virtual void OnUserLoginChangeCS_Implementation(bool bIsSignIn, int PlatformUserId, int UserIndex)
	{
		CheckDestroyed();
		if (!OnUserLoginChangeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnUserLoginChangeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUserLoginChangeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUserLoginChangeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_bIsSignIn_Offset), 0, OnUserLoginChangeCS_bIsSignIn_PropertyAddress.Address, bIsSignIn);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_PlatformUserId_Offset), 0, OnUserLoginChangeCS_PlatformUserId_PropertyAddress.Address, PlatformUserId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnUserLoginChangeCS_UserIndex_Offset), 0, OnUserLoginChangeCS_UserIndex_PropertyAddress.Address, UserIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUserLoginChangeCS_FunctionAddress, intPtr, OnUserLoginChangeCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnNetworkInitializedChangeCS")]
	protected unsafe void OnNetworkInitializedChangeCS(bool bIsNetworkInitialized)
	{
		CheckDestroyed();
		if (!OnNetworkInitializedChangeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnNetworkInitializedChangeCS");
			return;
		}
		if (OnNetworkInitializedChangeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNetworkInitializedChangeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNetworkInitializedChangeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNetworkInitializedChangeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNetworkInitializedChangeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset), 0, OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress.Address, bIsNetworkInitialized);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNetworkInitializedChangeCS_InstanceFunctionAddress, intPtr, OnNetworkInitializedChangeCS_ParamsSize);
	}

	protected unsafe virtual void OnNetworkInitializedChangeCS_Implementation(bool bIsNetworkInitialized)
	{
		CheckDestroyed();
		if (!OnNetworkInitializedChangeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnNetworkInitializedChangeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNetworkInitializedChangeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNetworkInitializedChangeCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset), 0, OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress.Address, bIsNetworkInitialized);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNetworkInitializedChangeCS_FunctionAddress, intPtr, OnNetworkInitializedChangeCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationTerminateCS")]
	protected unsafe void OnApplicationTerminateCS()
	{
		CheckDestroyed();
		if (!OnApplicationTerminateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationTerminateCS");
			return;
		}
		if (OnApplicationTerminateCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationTerminateCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationTerminateCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationTerminateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationTerminateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationTerminateCS_InstanceFunctionAddress, argsSize: OnApplicationTerminateCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationTerminateCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationTerminateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationTerminateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationTerminateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationTerminateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationTerminateCS_FunctionAddress, argsSize: OnApplicationTerminateCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationSuspendCS")]
	protected unsafe void OnApplicationSuspendCS()
	{
		CheckDestroyed();
		if (!OnApplicationSuspendCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationSuspendCS");
			return;
		}
		if (OnApplicationSuspendCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationSuspendCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationSuspendCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationSuspendCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationSuspendCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationSuspendCS_InstanceFunctionAddress, argsSize: OnApplicationSuspendCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationSuspendCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationSuspendCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationSuspendCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationSuspendCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationSuspendCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationSuspendCS_FunctionAddress, argsSize: OnApplicationSuspendCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationResumeCS")]
	protected unsafe void OnApplicationResumeCS()
	{
		CheckDestroyed();
		if (!OnApplicationResumeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationResumeCS");
			return;
		}
		if (OnApplicationResumeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationResumeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationResumeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationResumeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationResumeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationResumeCS_InstanceFunctionAddress, argsSize: OnApplicationResumeCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationResumeCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationResumeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationResumeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationResumeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationResumeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationResumeCS_FunctionAddress, argsSize: OnApplicationResumeCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationReactivatedCS")]
	protected unsafe void OnApplicationReactivatedCS()
	{
		CheckDestroyed();
		if (!OnApplicationReactivatedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationReactivatedCS");
			return;
		}
		if (OnApplicationReactivatedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationReactivatedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationReactivatedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationReactivatedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationReactivatedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationReactivatedCS_InstanceFunctionAddress, argsSize: OnApplicationReactivatedCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationReactivatedCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationReactivatedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationReactivatedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationReactivatedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationReactivatedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationReactivatedCS_FunctionAddress, argsSize: OnApplicationReactivatedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationPreExitCS")]
	protected unsafe void OnApplicationPreExitCS()
	{
		CheckDestroyed();
		if (!OnApplicationPreExitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationPreExitCS");
			return;
		}
		if (OnApplicationPreExitCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationPreExitCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationPreExitCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationPreExitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationPreExitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationPreExitCS_InstanceFunctionAddress, argsSize: OnApplicationPreExitCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationPreExitCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationPreExitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationPreExitCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationPreExitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationPreExitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationPreExitCS_FunctionAddress, argsSize: OnApplicationPreExitCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationInitCS")]
	protected unsafe void OnApplicationInitCS()
	{
		CheckDestroyed();
		if (!OnApplicationInitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationInitCS");
			return;
		}
		if (OnApplicationInitCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationInitCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationInitCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationInitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationInitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationInitCS_InstanceFunctionAddress, argsSize: OnApplicationInitCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationInitCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationInitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationInitCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationInitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationInitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationInitCS_FunctionAddress, argsSize: OnApplicationInitCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationExitCS")]
	protected unsafe void OnApplicationExitCS()
	{
		CheckDestroyed();
		if (!OnApplicationExitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationExitCS");
			return;
		}
		if (OnApplicationExitCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationExitCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationExitCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationExitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationExitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationExitCS_InstanceFunctionAddress, argsSize: OnApplicationExitCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationExitCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationExitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationExitCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationExitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationExitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationExitCS_FunctionAddress, argsSize: OnApplicationExitCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:OnApplicationDeactivateCS")]
	protected unsafe void OnApplicationDeactivateCS()
	{
		CheckDestroyed();
		if (!OnApplicationDeactivateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationDeactivateCS");
			return;
		}
		if (OnApplicationDeactivateCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplicationDeactivateCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplicationDeactivateCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationDeactivateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationDeactivateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationDeactivateCS_InstanceFunctionAddress, argsSize: OnApplicationDeactivateCS_ParamsSize);
	}

	protected unsafe virtual void OnApplicationDeactivateCS_Implementation()
	{
		CheckDestroyed();
		if (!OnApplicationDeactivateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:OnApplicationDeactivateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplicationDeactivateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplicationDeactivateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnApplicationDeactivateCS_FunctionAddress, argsSize: OnApplicationDeactivateCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:Init")]
	protected unsafe void Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:Init");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Init_FunctionAddress, argsSize: Init_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWPlatformEventMgr:Destroy")]
	protected unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlatformEventMgr:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	static UBGWPlatformEventMgr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWPlatformEventMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWPlatformEventMgr));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWPlatformEventMgr");
		OnUserLoginChangeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnUserLoginChangeCS");
		OnUserLoginChangeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserLoginChangeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUserLoginChangeCS_bIsSignIn_PropertyAddress, OnUserLoginChangeCS_FunctionAddress, "bIsSignIn");
		OnUserLoginChangeCS_bIsSignIn_Offset = NativeReflectionCached.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "bIsSignIn");
		OnUserLoginChangeCS_bIsSignIn_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "bIsSignIn", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUserLoginChangeCS_PlatformUserId_PropertyAddress, OnUserLoginChangeCS_FunctionAddress, "PlatformUserId");
		OnUserLoginChangeCS_PlatformUserId_Offset = NativeReflectionCached.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "PlatformUserId");
		OnUserLoginChangeCS_PlatformUserId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "PlatformUserId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUserLoginChangeCS_UserIndex_PropertyAddress, OnUserLoginChangeCS_FunctionAddress, "UserIndex");
		OnUserLoginChangeCS_UserIndex_Offset = NativeReflectionCached.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "UserIndex");
		OnUserLoginChangeCS_UserIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "UserIndex", Classes.FIntProperty);
		OnUserLoginChangeCS_IsValid = OnUserLoginChangeCS_FunctionAddress != IntPtr.Zero && OnUserLoginChangeCS_bIsSignIn_IsValid && OnUserLoginChangeCS_PlatformUserId_IsValid && OnUserLoginChangeCS_UserIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnUserLoginChangeCS", OnUserLoginChangeCS_IsValid);
		OnNetworkInitializedChangeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNetworkInitializedChangeCS");
		OnNetworkInitializedChangeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNetworkInitializedChangeCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress, OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized");
		OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset = NativeReflectionCached.GetPropertyOffset(OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized");
		OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized", Classes.FBoolProperty);
		OnNetworkInitializedChangeCS_IsValid = OnNetworkInitializedChangeCS_FunctionAddress != IntPtr.Zero && OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnNetworkInitializedChangeCS", OnNetworkInitializedChangeCS_IsValid);
		OnApplicationTerminateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationTerminateCS");
		OnApplicationTerminateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationTerminateCS_FunctionAddress);
		OnApplicationTerminateCS_IsValid = OnApplicationTerminateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationTerminateCS", OnApplicationTerminateCS_IsValid);
		OnApplicationSuspendCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationSuspendCS");
		OnApplicationSuspendCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationSuspendCS_FunctionAddress);
		OnApplicationSuspendCS_IsValid = OnApplicationSuspendCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationSuspendCS", OnApplicationSuspendCS_IsValid);
		OnApplicationResumeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationResumeCS");
		OnApplicationResumeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationResumeCS_FunctionAddress);
		OnApplicationResumeCS_IsValid = OnApplicationResumeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationResumeCS", OnApplicationResumeCS_IsValid);
		OnApplicationReactivatedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationReactivatedCS");
		OnApplicationReactivatedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationReactivatedCS_FunctionAddress);
		OnApplicationReactivatedCS_IsValid = OnApplicationReactivatedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationReactivatedCS", OnApplicationReactivatedCS_IsValid);
		OnApplicationPreExitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationPreExitCS");
		OnApplicationPreExitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationPreExitCS_FunctionAddress);
		OnApplicationPreExitCS_IsValid = OnApplicationPreExitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationPreExitCS", OnApplicationPreExitCS_IsValid);
		OnApplicationInitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationInitCS");
		OnApplicationInitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationInitCS_FunctionAddress);
		OnApplicationInitCS_IsValid = OnApplicationInitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationInitCS", OnApplicationInitCS_IsValid);
		OnApplicationExitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationExitCS");
		OnApplicationExitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationExitCS_FunctionAddress);
		OnApplicationExitCS_IsValid = OnApplicationExitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationExitCS", OnApplicationExitCS_IsValid);
		OnApplicationDeactivateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationDeactivateCS");
		OnApplicationDeactivateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationDeactivateCS_FunctionAddress);
		OnApplicationDeactivateCS_IsValid = OnApplicationDeactivateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:OnApplicationDeactivateCS", OnApplicationDeactivateCS_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:Init", Init_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlatformEventMgr:Destroy", Destroy_IsValid);
	}
}
