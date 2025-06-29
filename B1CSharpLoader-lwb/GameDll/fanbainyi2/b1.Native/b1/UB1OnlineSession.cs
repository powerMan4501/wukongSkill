using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/b1.B1OnlineSession", "b1", UnrealModuleType.Game)]
public class UB1OnlineSession : UOnlineSession
{
	private static bool StartOnlineSessionCS_IsValid;

	private IntPtr StartOnlineSessionCS_InstanceFunctionAddress;

	private static IntPtr StartOnlineSessionCS_FunctionAddress;

	private static int StartOnlineSessionCS_ParamsSize;

	private static bool StartOnlineSessionCS_SessionName_IsValid;

	private static FFieldAddress StartOnlineSessionCS_SessionName_PropertyAddress;

	private static int StartOnlineSessionCS_SessionName_Offset;

	private static bool RegisterOnlineDelegatesCS_IsValid;

	private IntPtr RegisterOnlineDelegatesCS_InstanceFunctionAddress;

	private static IntPtr RegisterOnlineDelegatesCS_FunctionAddress;

	private static int RegisterOnlineDelegatesCS_ParamsSize;

	private static bool OnSessionUserInviteAcceptedCS_IsValid;

	private IntPtr OnSessionUserInviteAcceptedCS_InstanceFunctionAddress;

	private static IntPtr OnSessionUserInviteAcceptedCS_FunctionAddress;

	private static int OnSessionUserInviteAcceptedCS_ParamsSize;

	private static bool OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid;

	private static FFieldAddress OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress;

	private static int OnSessionUserInviteAcceptedCS_bWasSuccess_Offset;

	private static bool OnSessionUserInviteAcceptedCS_ControllerId_IsValid;

	private static FFieldAddress OnSessionUserInviteAcceptedCS_ControllerId_PropertyAddress;

	private static int OnSessionUserInviteAcceptedCS_ControllerId_Offset;

	private static bool HandleDisconnectCS_IsValid;

	private IntPtr HandleDisconnectCS_InstanceFunctionAddress;

	private static IntPtr HandleDisconnectCS_FunctionAddress;

	private static int HandleDisconnectCS_ParamsSize;

	private static bool HandleDisconnectCS_World_IsValid;

	private static FFieldAddress HandleDisconnectCS_World_PropertyAddress;

	private static int HandleDisconnectCS_World_Offset;

	private static bool HandleDisconnectCS_NetDriver_IsValid;

	private static FFieldAddress HandleDisconnectCS_NetDriver_PropertyAddress;

	private static int HandleDisconnectCS_NetDriver_Offset;

	private static bool EndOnlineSessionCS_IsValid;

	private IntPtr EndOnlineSessionCS_InstanceFunctionAddress;

	private static IntPtr EndOnlineSessionCS_FunctionAddress;

	private static int EndOnlineSessionCS_ParamsSize;

	private static bool EndOnlineSessionCS_SessionName_IsValid;

	private static FFieldAddress EndOnlineSessionCS_SessionName_PropertyAddress;

	private static int EndOnlineSessionCS_SessionName_Offset;

	private static bool ClearOnlineDelegatesCS_IsValid;

	private IntPtr ClearOnlineDelegatesCS_InstanceFunctionAddress;

	private static IntPtr ClearOnlineDelegatesCS_FunctionAddress;

	private static int ClearOnlineDelegatesCS_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:StartOnlineSessionCS")]
	public unsafe void StartOnlineSessionCS(FName SessionName)
	{
		CheckDestroyed();
		if (!StartOnlineSessionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:StartOnlineSessionCS");
			return;
		}
		if (StartOnlineSessionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			StartOnlineSessionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "StartOnlineSessionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartOnlineSessionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartOnlineSessionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StartOnlineSessionCS_SessionName_Offset), 0, StartOnlineSessionCS_SessionName_PropertyAddress.Address, SessionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartOnlineSessionCS_InstanceFunctionAddress, intPtr, StartOnlineSessionCS_ParamsSize);
	}

	protected unsafe virtual void StartOnlineSessionCS_Implementation(FName SessionName)
	{
		CheckDestroyed();
		if (!StartOnlineSessionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:StartOnlineSessionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartOnlineSessionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartOnlineSessionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StartOnlineSessionCS_SessionName_Offset), 0, StartOnlineSessionCS_SessionName_PropertyAddress.Address, SessionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartOnlineSessionCS_FunctionAddress, intPtr, StartOnlineSessionCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:RegisterOnlineDelegatesCS")]
	public unsafe void RegisterOnlineDelegatesCS()
	{
		CheckDestroyed();
		if (!RegisterOnlineDelegatesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:RegisterOnlineDelegatesCS");
			return;
		}
		if (RegisterOnlineDelegatesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			RegisterOnlineDelegatesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RegisterOnlineDelegatesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterOnlineDelegatesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterOnlineDelegatesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterOnlineDelegatesCS_InstanceFunctionAddress, argsSize: RegisterOnlineDelegatesCS_ParamsSize);
	}

	protected unsafe virtual void RegisterOnlineDelegatesCS_Implementation()
	{
		CheckDestroyed();
		if (!RegisterOnlineDelegatesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:RegisterOnlineDelegatesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterOnlineDelegatesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterOnlineDelegatesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterOnlineDelegatesCS_FunctionAddress, argsSize: RegisterOnlineDelegatesCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:OnSessionUserInviteAcceptedCS")]
	public unsafe void OnSessionUserInviteAcceptedCS(bool bWasSuccess, int ControllerId)
	{
		CheckDestroyed();
		if (!OnSessionUserInviteAcceptedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:OnSessionUserInviteAcceptedCS");
			return;
		}
		if (OnSessionUserInviteAcceptedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSessionUserInviteAcceptedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSessionUserInviteAcceptedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSessionUserInviteAcceptedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSessionUserInviteAcceptedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSessionUserInviteAcceptedCS_bWasSuccess_Offset), 0, OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress.Address, bWasSuccess);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnSessionUserInviteAcceptedCS_ControllerId_Offset), 0, OnSessionUserInviteAcceptedCS_ControllerId_PropertyAddress.Address, ControllerId);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSessionUserInviteAcceptedCS_InstanceFunctionAddress, intPtr, OnSessionUserInviteAcceptedCS_ParamsSize);
	}

	protected unsafe virtual void OnSessionUserInviteAcceptedCS_Implementation(bool bWasSuccess, int ControllerId)
	{
		CheckDestroyed();
		if (!OnSessionUserInviteAcceptedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:OnSessionUserInviteAcceptedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSessionUserInviteAcceptedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSessionUserInviteAcceptedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSessionUserInviteAcceptedCS_bWasSuccess_Offset), 0, OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress.Address, bWasSuccess);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnSessionUserInviteAcceptedCS_ControllerId_Offset), 0, OnSessionUserInviteAcceptedCS_ControllerId_PropertyAddress.Address, ControllerId);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSessionUserInviteAcceptedCS_FunctionAddress, intPtr, OnSessionUserInviteAcceptedCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:HandleDisconnectCS")]
	public unsafe void HandleDisconnectCS(UWorld World, UNetDriver NetDriver)
	{
		CheckDestroyed();
		if (!HandleDisconnectCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:HandleDisconnectCS");
			return;
		}
		if (HandleDisconnectCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleDisconnectCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleDisconnectCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleDisconnectCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleDisconnectCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, HandleDisconnectCS_World_Offset), 0, HandleDisconnectCS_World_PropertyAddress.Address, World);
		UObjectMarshaler<UNetDriver>.ToNative(IntPtr.Add(intPtr, HandleDisconnectCS_NetDriver_Offset), 0, HandleDisconnectCS_NetDriver_PropertyAddress.Address, NetDriver);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleDisconnectCS_InstanceFunctionAddress, intPtr, HandleDisconnectCS_ParamsSize);
	}

	protected unsafe virtual void HandleDisconnectCS_Implementation(UWorld World, UNetDriver NetDriver)
	{
		CheckDestroyed();
		if (!HandleDisconnectCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:HandleDisconnectCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleDisconnectCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleDisconnectCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, HandleDisconnectCS_World_Offset), 0, HandleDisconnectCS_World_PropertyAddress.Address, World);
		UObjectMarshaler<UNetDriver>.ToNative(IntPtr.Add(intPtr, HandleDisconnectCS_NetDriver_Offset), 0, HandleDisconnectCS_NetDriver_PropertyAddress.Address, NetDriver);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleDisconnectCS_FunctionAddress, intPtr, HandleDisconnectCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:EndOnlineSessionCS")]
	public unsafe void EndOnlineSessionCS(FName SessionName)
	{
		CheckDestroyed();
		if (!EndOnlineSessionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:EndOnlineSessionCS");
			return;
		}
		if (EndOnlineSessionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			EndOnlineSessionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "EndOnlineSessionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndOnlineSessionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndOnlineSessionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EndOnlineSessionCS_SessionName_Offset), 0, EndOnlineSessionCS_SessionName_PropertyAddress.Address, SessionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndOnlineSessionCS_InstanceFunctionAddress, intPtr, EndOnlineSessionCS_ParamsSize);
	}

	protected unsafe virtual void EndOnlineSessionCS_Implementation(FName SessionName)
	{
		CheckDestroyed();
		if (!EndOnlineSessionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:EndOnlineSessionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndOnlineSessionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndOnlineSessionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EndOnlineSessionCS_SessionName_Offset), 0, EndOnlineSessionCS_SessionName_PropertyAddress.Address, SessionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndOnlineSessionCS_FunctionAddress, intPtr, EndOnlineSessionCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.B1OnlineSession:ClearOnlineDelegatesCS")]
	public unsafe void ClearOnlineDelegatesCS()
	{
		CheckDestroyed();
		if (!ClearOnlineDelegatesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:ClearOnlineDelegatesCS");
			return;
		}
		if (ClearOnlineDelegatesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ClearOnlineDelegatesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ClearOnlineDelegatesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOnlineDelegatesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOnlineDelegatesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearOnlineDelegatesCS_InstanceFunctionAddress, argsSize: ClearOnlineDelegatesCS_ParamsSize);
	}

	protected unsafe virtual void ClearOnlineDelegatesCS_Implementation()
	{
		CheckDestroyed();
		if (!ClearOnlineDelegatesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1OnlineSession:ClearOnlineDelegatesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOnlineDelegatesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOnlineDelegatesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearOnlineDelegatesCS_FunctionAddress, argsSize: ClearOnlineDelegatesCS_ParamsSize);
	}

	static UB1OnlineSession()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UB1OnlineSession)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UB1OnlineSession));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.B1OnlineSession");
		StartOnlineSessionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartOnlineSessionCS");
		StartOnlineSessionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(StartOnlineSessionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartOnlineSessionCS_SessionName_PropertyAddress, StartOnlineSessionCS_FunctionAddress, "SessionName");
		StartOnlineSessionCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(StartOnlineSessionCS_FunctionAddress, "SessionName");
		StartOnlineSessionCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(StartOnlineSessionCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		StartOnlineSessionCS_IsValid = StartOnlineSessionCS_FunctionAddress != IntPtr.Zero && StartOnlineSessionCS_SessionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:StartOnlineSessionCS", StartOnlineSessionCS_IsValid);
		RegisterOnlineDelegatesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterOnlineDelegatesCS");
		RegisterOnlineDelegatesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterOnlineDelegatesCS_FunctionAddress);
		RegisterOnlineDelegatesCS_IsValid = RegisterOnlineDelegatesCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:RegisterOnlineDelegatesCS", RegisterOnlineDelegatesCS_IsValid);
		OnSessionUserInviteAcceptedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSessionUserInviteAcceptedCS");
		OnSessionUserInviteAcceptedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSessionUserInviteAcceptedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress, OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnSessionUserInviteAcceptedCS_ControllerId_PropertyAddress, OnSessionUserInviteAcceptedCS_FunctionAddress, "ControllerId");
		OnSessionUserInviteAcceptedCS_ControllerId_Offset = NativeReflectionCached.GetPropertyOffset(OnSessionUserInviteAcceptedCS_FunctionAddress, "ControllerId");
		OnSessionUserInviteAcceptedCS_ControllerId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSessionUserInviteAcceptedCS_FunctionAddress, "ControllerId", Classes.FIntProperty);
		OnSessionUserInviteAcceptedCS_IsValid = OnSessionUserInviteAcceptedCS_FunctionAddress != IntPtr.Zero && OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid && OnSessionUserInviteAcceptedCS_ControllerId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:OnSessionUserInviteAcceptedCS", OnSessionUserInviteAcceptedCS_IsValid);
		HandleDisconnectCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleDisconnectCS");
		HandleDisconnectCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleDisconnectCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleDisconnectCS_World_PropertyAddress, HandleDisconnectCS_FunctionAddress, "World");
		HandleDisconnectCS_World_Offset = NativeReflectionCached.GetPropertyOffset(HandleDisconnectCS_FunctionAddress, "World");
		HandleDisconnectCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleDisconnectCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleDisconnectCS_NetDriver_PropertyAddress, HandleDisconnectCS_FunctionAddress, "NetDriver");
		HandleDisconnectCS_NetDriver_Offset = NativeReflectionCached.GetPropertyOffset(HandleDisconnectCS_FunctionAddress, "NetDriver");
		HandleDisconnectCS_NetDriver_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleDisconnectCS_FunctionAddress, "NetDriver", Classes.FObjectProperty);
		HandleDisconnectCS_IsValid = HandleDisconnectCS_FunctionAddress != IntPtr.Zero && HandleDisconnectCS_World_IsValid && HandleDisconnectCS_NetDriver_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:HandleDisconnectCS", HandleDisconnectCS_IsValid);
		EndOnlineSessionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndOnlineSessionCS");
		EndOnlineSessionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndOnlineSessionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndOnlineSessionCS_SessionName_PropertyAddress, EndOnlineSessionCS_FunctionAddress, "SessionName");
		EndOnlineSessionCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(EndOnlineSessionCS_FunctionAddress, "SessionName");
		EndOnlineSessionCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(EndOnlineSessionCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		EndOnlineSessionCS_IsValid = EndOnlineSessionCS_FunctionAddress != IntPtr.Zero && EndOnlineSessionCS_SessionName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:EndOnlineSessionCS", EndOnlineSessionCS_IsValid);
		ClearOnlineDelegatesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearOnlineDelegatesCS");
		ClearOnlineDelegatesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearOnlineDelegatesCS_FunctionAddress);
		ClearOnlineDelegatesCS_IsValid = ClearOnlineDelegatesCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1OnlineSession:ClearOnlineDelegatesCS", ClearOnlineDelegatesCS_IsValid);
	}
}
