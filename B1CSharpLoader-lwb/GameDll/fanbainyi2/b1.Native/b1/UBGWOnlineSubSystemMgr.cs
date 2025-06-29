using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.NetCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr", "b1", UnrealModuleType.Game)]
public class UBGWOnlineSubSystemMgr : UObject
{
	private static bool WorldCtx_IsValid;

	private static int WorldCtx_Offset;

	private static bool OnLineGameMapName_IsValid;

	private static int OnLineGameMapName_Offset;

	private static bool MainMenuMapName_IsValid;

	private static int MainMenuMapName_Offset;

	private static bool searchResults_IsValid;

	private static FFieldAddress searchResults_PropertyAddress;

	private static int searchResults_Offset;

	private TArrayReadOnlyMarshaler<FBlueprintSearchResult> searchResults_MarshalerCached;

	private static bool QueryFlag_IsValid;

	private static FFieldAddress QueryFlag_PropertyAddress;

	private static int QueryFlag_Offset;

	private static bool OnUpdateSessionCompleteCS_IsValid;

	private IntPtr OnUpdateSessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnUpdateSessionCompleteCS_FunctionAddress;

	private static int OnUpdateSessionCompleteCS_ParamsSize;

	private static bool OnUpdateSessionCompleteCS_SessionName_IsValid;

	private static FFieldAddress OnUpdateSessionCompleteCS_SessionName_PropertyAddress;

	private static int OnUpdateSessionCompleteCS_SessionName_Offset;

	private static bool OnUpdateSessionCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnUpdateSessionCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnUpdateSessionCompleteCS_bWasSuccessful_Offset;

	private static bool OnStartOnlineGameCompleteCS_IsValid;

	private IntPtr OnStartOnlineGameCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnStartOnlineGameCompleteCS_FunctionAddress;

	private static int OnStartOnlineGameCompleteCS_ParamsSize;

	private static bool OnStartOnlineGameCompleteCS_SessionName_IsValid;

	private static FFieldAddress OnStartOnlineGameCompleteCS_SessionName_PropertyAddress;

	private static int OnStartOnlineGameCompleteCS_SessionName_Offset;

	private static bool OnStartOnlineGameCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnStartOnlineGameCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnStartOnlineGameCompleteCS_bWasSuccessful_Offset;

	private static bool OnJoinSessionCompleteCS_IsValid;

	private IntPtr OnJoinSessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnJoinSessionCompleteCS_FunctionAddress;

	private static int OnJoinSessionCompleteCS_ParamsSize;

	private static bool OnJoinSessionCompleteCS_SessionName_IsValid;

	private static FFieldAddress OnJoinSessionCompleteCS_SessionName_PropertyAddress;

	private static int OnJoinSessionCompleteCS_SessionName_Offset;

	private static bool OnJoinSessionCompleteCS_Result_IsValid;

	private static FFieldAddress OnJoinSessionCompleteCS_Result_PropertyAddress;

	private static int OnJoinSessionCompleteCS_Result_Offset;

	private static bool OnFindSessionsCompleteCS_IsValid;

	private IntPtr OnFindSessionsCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnFindSessionsCompleteCS_FunctionAddress;

	private static int OnFindSessionsCompleteCS_ParamsSize;

	private static bool OnFindSessionsCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnFindSessionsCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnFindSessionsCompleteCS_bWasSuccessful_Offset;

	private static bool OnDestroySessionCompleteCS_IsValid;

	private IntPtr OnDestroySessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnDestroySessionCompleteCS_FunctionAddress;

	private static int OnDestroySessionCompleteCS_ParamsSize;

	private static bool OnDestroySessionCompleteCS_SessionName_IsValid;

	private static FFieldAddress OnDestroySessionCompleteCS_SessionName_PropertyAddress;

	private static int OnDestroySessionCompleteCS_SessionName_Offset;

	private static bool OnDestroySessionCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnDestroySessionCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnDestroySessionCompleteCS_bWasSuccessful_Offset;

	private static bool OnCreateSessionCompleteCS_IsValid;

	private IntPtr OnCreateSessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnCreateSessionCompleteCS_FunctionAddress;

	private static int OnCreateSessionCompleteCS_ParamsSize;

	private static bool OnCreateSessionCompleteCS_SessionName_IsValid;

	private static FFieldAddress OnCreateSessionCompleteCS_SessionName_PropertyAddress;

	private static int OnCreateSessionCompleteCS_SessionName_Offset;

	private static bool OnCreateSessionCompleteCS_bWasSuccessful_IsValid;

	private static FFieldAddress OnCreateSessionCompleteCS_bWasSuccessful_PropertyAddress;

	private static int OnCreateSessionCompleteCS_bWasSuccessful_Offset;

	private static bool LeaveGame_IsValid;

	private static IntPtr LeaveGame_FunctionAddress;

	private static int LeaveGame_ParamsSize;

	private static bool JoinGame_IsValid;

	private static IntPtr JoinGame_FunctionAddress;

	private static int JoinGame_ParamsSize;

	private static bool JoinGame_result_IsValid;

	private static FFieldAddress JoinGame_result_PropertyAddress;

	private static int JoinGame_result_Offset;

	private static bool JoinGame_ReturnValue_IsValid;

	private static FFieldAddress JoinGame_ReturnValue_PropertyAddress;

	private static int JoinGame_ReturnValue_Offset;

	private static bool HostGame_IsValid;

	private static IntPtr HostGame_FunctionAddress;

	private static int HostGame_ParamsSize;

	private static bool HostGame_bIsLAN_IsValid;

	private static FFieldAddress HostGame_bIsLAN_PropertyAddress;

	private static int HostGame_bIsLAN_Offset;

	private static bool HostGame_MaxNumPlayers_IsValid;

	private static FFieldAddress HostGame_MaxNumPlayers_PropertyAddress;

	private static int HostGame_MaxNumPlayers_Offset;

	private static bool HostGame_CustumSettings_IsValid;

	private static FFieldAddress HostGame_CustumSettings_PropertyAddress;

	private static int HostGame_CustumSettings_Offset;

	private static bool HostGame_ReturnValue_IsValid;

	private static FFieldAddress HostGame_ReturnValue_PropertyAddress;

	private static int HostGame_ReturnValue_Offset;

	private static bool HandleNetworkErrorCS_IsValid;

	private IntPtr HandleNetworkErrorCS_InstanceFunctionAddress;

	private static IntPtr HandleNetworkErrorCS_FunctionAddress;

	private static int HandleNetworkErrorCS_ParamsSize;

	private static bool HandleNetworkErrorCS_World_IsValid;

	private static FFieldAddress HandleNetworkErrorCS_World_PropertyAddress;

	private static int HandleNetworkErrorCS_World_Offset;

	private static bool HandleNetworkErrorCS_FailureType_IsValid;

	private static FFieldAddress HandleNetworkErrorCS_FailureType_PropertyAddress;

	private static int HandleNetworkErrorCS_FailureType_Offset;

	private static bool HandleNetworkErrorCS_ErrorString_IsValid;

	private static FFieldAddress HandleNetworkErrorCS_ErrorString_PropertyAddress;

	private static int HandleNetworkErrorCS_ErrorString_Offset;

	private static bool FindGames_IsValid;

	private static IntPtr FindGames_FunctionAddress;

	private static int FindGames_ParamsSize;

	private static bool FindGames_bIsLAN_IsValid;

	private static FFieldAddress FindGames_bIsLAN_PropertyAddress;

	private static int FindGames_bIsLAN_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:WorldCtx")]
	public UObject WorldCtx
	{
		get
		{
			CheckDestroyed();
			if (!WorldCtx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:WorldCtx");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, WorldCtx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldCtx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:WorldCtx");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, WorldCtx_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnLineGameMapName")]
	public FName OnLineGameMapName
	{
		get
		{
			CheckDestroyed();
			if (!OnLineGameMapName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnLineGameMapName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OnLineGameMapName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnLineGameMapName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnLineGameMapName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OnLineGameMapName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:MainMenuMapName")]
	public FName MainMenuMapName
	{
		get
		{
			CheckDestroyed();
			if (!MainMenuMapName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:MainMenuMapName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MainMenuMapName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainMenuMapName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:MainMenuMapName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MainMenuMapName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:searchResults")]
	public TArrayReadOnly<FBlueprintSearchResult> searchResults
	{
		get
		{
			CheckDestroyed();
			if (!searchResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:searchResults");
				return null;
			}
			if (searchResults_MarshalerCached == null)
			{
				searchResults_MarshalerCached = new TArrayReadOnlyMarshaler<FBlueprintSearchResult>(1, searchResults_PropertyAddress, CachedMarshalingDelegates<FBlueprintSearchResult, FBlueprintSearchResult>.FromNative, CachedMarshalingDelegates<FBlueprintSearchResult, FBlueprintSearchResult>.ToNative);
			}
			return searchResults_MarshalerCached.FromNative(IntPtr.Add(base.Address, searchResults_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:QueryFlag")]
	public bool QueryFlag
	{
		get
		{
			CheckDestroyed();
			if (!QueryFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:QueryFlag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, QueryFlag_Offset), 0, QueryFlag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QueryFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSubSystemMgr:QueryFlag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, QueryFlag_Offset), 0, QueryFlag_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnUpdateSessionCompleteCS")]
	public unsafe void OnUpdateSessionCompleteCS(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnUpdateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnUpdateSessionCompleteCS");
			return;
		}
		if (OnUpdateSessionCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnUpdateSessionCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnUpdateSessionCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUpdateSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUpdateSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnUpdateSessionCompleteCS_SessionName_Offset), 0, OnUpdateSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnUpdateSessionCompleteCS_bWasSuccessful_Offset), 0, OnUpdateSessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUpdateSessionCompleteCS_InstanceFunctionAddress, intPtr, OnUpdateSessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnUpdateSessionCompleteCS_Implementation(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnUpdateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnUpdateSessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUpdateSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUpdateSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnUpdateSessionCompleteCS_SessionName_Offset), 0, OnUpdateSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnUpdateSessionCompleteCS_bWasSuccessful_Offset), 0, OnUpdateSessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUpdateSessionCompleteCS_FunctionAddress, intPtr, OnUpdateSessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnStartOnlineGameCompleteCS")]
	public unsafe void OnStartOnlineGameCompleteCS(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStartOnlineGameCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnStartOnlineGameCompleteCS");
			return;
		}
		if (OnStartOnlineGameCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnStartOnlineGameCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnStartOnlineGameCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartOnlineGameCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartOnlineGameCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnStartOnlineGameCompleteCS_SessionName_Offset), 0, OnStartOnlineGameCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStartOnlineGameCompleteCS_bWasSuccessful_Offset), 0, OnStartOnlineGameCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartOnlineGameCompleteCS_InstanceFunctionAddress, intPtr, OnStartOnlineGameCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnStartOnlineGameCompleteCS_Implementation(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnStartOnlineGameCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnStartOnlineGameCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartOnlineGameCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartOnlineGameCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnStartOnlineGameCompleteCS_SessionName_Offset), 0, OnStartOnlineGameCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnStartOnlineGameCompleteCS_bWasSuccessful_Offset), 0, OnStartOnlineGameCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartOnlineGameCompleteCS_FunctionAddress, intPtr, OnStartOnlineGameCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnJoinSessionCompleteCS")]
	public unsafe void OnJoinSessionCompleteCS(FName SessionName, int Result)
	{
		CheckDestroyed();
		if (!OnJoinSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnJoinSessionCompleteCS");
			return;
		}
		if (OnJoinSessionCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnJoinSessionCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnJoinSessionCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnJoinSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnJoinSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_SessionName_Offset), 0, OnJoinSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_Result_Offset), 0, OnJoinSessionCompleteCS_Result_PropertyAddress.Address, Result);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnJoinSessionCompleteCS_InstanceFunctionAddress, intPtr, OnJoinSessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnJoinSessionCompleteCS_Implementation(FName SessionName, int Result)
	{
		CheckDestroyed();
		if (!OnJoinSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnJoinSessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnJoinSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnJoinSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_SessionName_Offset), 0, OnJoinSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_Result_Offset), 0, OnJoinSessionCompleteCS_Result_PropertyAddress.Address, Result);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnJoinSessionCompleteCS_FunctionAddress, intPtr, OnJoinSessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnFindSessionsCompleteCS")]
	public unsafe void OnFindSessionsCompleteCS(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnFindSessionsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnFindSessionsCompleteCS");
			return;
		}
		if (OnFindSessionsCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFindSessionsCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFindSessionsCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFindSessionsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFindSessionsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnFindSessionsCompleteCS_bWasSuccessful_Offset), 0, OnFindSessionsCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFindSessionsCompleteCS_InstanceFunctionAddress, intPtr, OnFindSessionsCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnFindSessionsCompleteCS_Implementation(bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnFindSessionsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnFindSessionsCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFindSessionsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFindSessionsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnFindSessionsCompleteCS_bWasSuccessful_Offset), 0, OnFindSessionsCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFindSessionsCompleteCS_FunctionAddress, intPtr, OnFindSessionsCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnDestroySessionCompleteCS")]
	public unsafe void OnDestroySessionCompleteCS(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnDestroySessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnDestroySessionCompleteCS");
			return;
		}
		if (OnDestroySessionCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDestroySessionCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDestroySessionCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestroySessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestroySessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_SessionName_Offset), 0, OnDestroySessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_bWasSuccessful_Offset), 0, OnDestroySessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroySessionCompleteCS_InstanceFunctionAddress, intPtr, OnDestroySessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnDestroySessionCompleteCS_Implementation(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnDestroySessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnDestroySessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestroySessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestroySessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_SessionName_Offset), 0, OnDestroySessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_bWasSuccessful_Offset), 0, OnDestroySessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroySessionCompleteCS_FunctionAddress, intPtr, OnDestroySessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:OnCreateSessionCompleteCS")]
	public unsafe void OnCreateSessionCompleteCS(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnCreateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnCreateSessionCompleteCS");
			return;
		}
		if (OnCreateSessionCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnCreateSessionCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnCreateSessionCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreateSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreateSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_SessionName_Offset), 0, OnCreateSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_bWasSuccessful_Offset), 0, OnCreateSessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCreateSessionCompleteCS_InstanceFunctionAddress, intPtr, OnCreateSessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnCreateSessionCompleteCS_Implementation(FName SessionName, bool bWasSuccessful)
	{
		CheckDestroyed();
		if (!OnCreateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:OnCreateSessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreateSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreateSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_SessionName_Offset), 0, OnCreateSessionCompleteCS_SessionName_PropertyAddress.Address, SessionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_bWasSuccessful_Offset), 0, OnCreateSessionCompleteCS_bWasSuccessful_PropertyAddress.Address, bWasSuccessful);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCreateSessionCompleteCS_FunctionAddress, intPtr, OnCreateSessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:LeaveGame")]
	public unsafe void LeaveGame()
	{
		CheckDestroyed();
		if (!LeaveGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:LeaveGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LeaveGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LeaveGame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LeaveGame_FunctionAddress, argsSize: LeaveGame_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:JoinGame")]
	public unsafe bool JoinGame(FBlueprintSearchResult result)
	{
		CheckDestroyed();
		if (!JoinGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:JoinGame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JoinGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JoinGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(JoinGame_result_PropertyAddress.Address, intPtr);
		FBlueprintSearchResult.ToNative(IntPtr.Add(intPtr, JoinGame_result_Offset), 0, JoinGame_result_PropertyAddress.Address, result);
		NativeReflection.InvokeFunctionOptimized(base.Address, JoinGame_FunctionAddress, intPtr, JoinGame_ParamsSize);
		NativeReflection.DestroyValue_InContainer(JoinGame_result_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, JoinGame_ReturnValue_Offset), 0, JoinGame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:HostGame")]
	public unsafe bool HostGame(bool bIsLAN, int MaxNumPlayers, Dictionary<string, string> CustumSettings)
	{
		CheckDestroyed();
		if (!HostGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:HostGame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HostGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HostGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HostGame_bIsLAN_Offset), 0, HostGame_bIsLAN_PropertyAddress.Address, bIsLAN);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, HostGame_MaxNumPlayers_Offset), 0, HostGame_MaxNumPlayers_PropertyAddress.Address, MaxNumPlayers);
		NativeReflection.InitializeValue_InContainer(HostGame_CustumSettings_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, HostGame_CustumSettings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HostGame_CustumSettings_Offset), CustumSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, HostGame_FunctionAddress, intPtr, HostGame_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HostGame_CustumSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HostGame_ReturnValue_Offset), 0, HostGame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:HandleNetworkErrorCS")]
	public unsafe void HandleNetworkErrorCS(UWorld World, ENetworkFailure FailureType, string ErrorString)
	{
		CheckDestroyed();
		if (!HandleNetworkErrorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:HandleNetworkErrorCS");
			return;
		}
		if (HandleNetworkErrorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleNetworkErrorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleNetworkErrorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleNetworkErrorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleNetworkErrorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_World_Offset), 0, HandleNetworkErrorCS_World_PropertyAddress.Address, World);
		EnumMarshaler<ENetworkFailure>.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_FailureType_Offset), 0, HandleNetworkErrorCS_FailureType_PropertyAddress.Address, FailureType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_ErrorString_Offset), 0, HandleNetworkErrorCS_ErrorString_PropertyAddress.Address, ErrorString);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleNetworkErrorCS_InstanceFunctionAddress, intPtr, HandleNetworkErrorCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleNetworkErrorCS_ErrorString_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void HandleNetworkErrorCS_Implementation(UWorld World, ENetworkFailure FailureType, string ErrorString)
	{
		CheckDestroyed();
		if (!HandleNetworkErrorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:HandleNetworkErrorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleNetworkErrorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleNetworkErrorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_World_Offset), 0, HandleNetworkErrorCS_World_PropertyAddress.Address, World);
		EnumMarshaler<ENetworkFailure>.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_FailureType_Offset), 0, HandleNetworkErrorCS_FailureType_PropertyAddress.Address, FailureType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HandleNetworkErrorCS_ErrorString_Offset), 0, HandleNetworkErrorCS_ErrorString_PropertyAddress.Address, ErrorString);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleNetworkErrorCS_FunctionAddress, intPtr, HandleNetworkErrorCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HandleNetworkErrorCS_ErrorString_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSubSystemMgr:FindGames")]
	public unsafe void FindGames(bool bIsLAN)
	{
		CheckDestroyed();
		if (!FindGames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSubSystemMgr:FindGames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindGames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindGames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindGames_bIsLAN_Offset), 0, FindGames_bIsLAN_PropertyAddress.Address, bIsLAN);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindGames_FunctionAddress, intPtr, FindGames_ParamsSize);
	}

	static UBGWOnlineSubSystemMgr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineSubSystemMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineSubSystemMgr));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWOnlineSubSystemMgr");
		WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldCtx");
		WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldCtx", Classes.FObjectProperty);
		OnLineGameMapName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnLineGameMapName");
		OnLineGameMapName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnLineGameMapName", Classes.FNameProperty);
		MainMenuMapName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MainMenuMapName");
		MainMenuMapName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MainMenuMapName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref searchResults_PropertyAddress, intPtr, "searchResults");
		searchResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "searchResults");
		searchResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "searchResults", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryFlag_PropertyAddress, intPtr, "QueryFlag");
		QueryFlag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryFlag");
		QueryFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryFlag", Classes.FBoolProperty);
		OnUpdateSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnUpdateSessionCompleteCS");
		OnUpdateSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUpdateSessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUpdateSessionCompleteCS_SessionName_PropertyAddress, OnUpdateSessionCompleteCS_FunctionAddress, "SessionName");
		OnUpdateSessionCompleteCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdateSessionCompleteCS_FunctionAddress, "SessionName");
		OnUpdateSessionCompleteCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdateSessionCompleteCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUpdateSessionCompleteCS_bWasSuccessful_PropertyAddress, OnUpdateSessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnUpdateSessionCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdateSessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnUpdateSessionCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdateSessionCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnUpdateSessionCompleteCS_IsValid = OnUpdateSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnUpdateSessionCompleteCS_SessionName_IsValid && OnUpdateSessionCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnUpdateSessionCompleteCS", OnUpdateSessionCompleteCS_IsValid);
		OnStartOnlineGameCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnStartOnlineGameCompleteCS");
		OnStartOnlineGameCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStartOnlineGameCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnStartOnlineGameCompleteCS_SessionName_PropertyAddress, OnStartOnlineGameCompleteCS_FunctionAddress, "SessionName");
		OnStartOnlineGameCompleteCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnStartOnlineGameCompleteCS_FunctionAddress, "SessionName");
		OnStartOnlineGameCompleteCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStartOnlineGameCompleteCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnStartOnlineGameCompleteCS_bWasSuccessful_PropertyAddress, OnStartOnlineGameCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartOnlineGameCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnStartOnlineGameCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartOnlineGameCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStartOnlineGameCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnStartOnlineGameCompleteCS_IsValid = OnStartOnlineGameCompleteCS_FunctionAddress != IntPtr.Zero && OnStartOnlineGameCompleteCS_SessionName_IsValid && OnStartOnlineGameCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnStartOnlineGameCompleteCS", OnStartOnlineGameCompleteCS_IsValid);
		OnJoinSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnJoinSessionCompleteCS");
		OnJoinSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnJoinSessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnJoinSessionCompleteCS_SessionName_PropertyAddress, OnJoinSessionCompleteCS_FunctionAddress, "SessionName");
		OnJoinSessionCompleteCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnJoinSessionCompleteCS_FunctionAddress, "SessionName");
		OnJoinSessionCompleteCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnJoinSessionCompleteCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnJoinSessionCompleteCS_Result_PropertyAddress, OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_Offset = NativeReflectionCached.GetPropertyOffset(OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(OnJoinSessionCompleteCS_FunctionAddress, "Result", Classes.FIntProperty);
		OnJoinSessionCompleteCS_IsValid = OnJoinSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnJoinSessionCompleteCS_SessionName_IsValid && OnJoinSessionCompleteCS_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnJoinSessionCompleteCS", OnJoinSessionCompleteCS_IsValid);
		OnFindSessionsCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFindSessionsCompleteCS");
		OnFindSessionsCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFindSessionsCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFindSessionsCompleteCS_bWasSuccessful_PropertyAddress, OnFindSessionsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnFindSessionsCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnFindSessionsCompleteCS_FunctionAddress, "bWasSuccessful");
		OnFindSessionsCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFindSessionsCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnFindSessionsCompleteCS_IsValid = OnFindSessionsCompleteCS_FunctionAddress != IntPtr.Zero && OnFindSessionsCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnFindSessionsCompleteCS", OnFindSessionsCompleteCS_IsValid);
		OnDestroySessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDestroySessionCompleteCS");
		OnDestroySessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroySessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDestroySessionCompleteCS_SessionName_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "SessionName");
		OnDestroySessionCompleteCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "SessionName");
		OnDestroySessionCompleteCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDestroySessionCompleteCS_bWasSuccessful_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDestroySessionCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnDestroySessionCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnDestroySessionCompleteCS_IsValid = OnDestroySessionCompleteCS_FunctionAddress != IntPtr.Zero && OnDestroySessionCompleteCS_SessionName_IsValid && OnDestroySessionCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnDestroySessionCompleteCS", OnDestroySessionCompleteCS_IsValid);
		OnCreateSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreateSessionCompleteCS");
		OnCreateSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateSessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCreateSessionCompleteCS_SessionName_PropertyAddress, OnCreateSessionCompleteCS_FunctionAddress, "SessionName");
		OnCreateSessionCompleteCS_SessionName_Offset = NativeReflectionCached.GetPropertyOffset(OnCreateSessionCompleteCS_FunctionAddress, "SessionName");
		OnCreateSessionCompleteCS_SessionName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCreateSessionCompleteCS_FunctionAddress, "SessionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnCreateSessionCompleteCS_bWasSuccessful_PropertyAddress, OnCreateSessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnCreateSessionCompleteCS_bWasSuccessful_Offset = NativeReflectionCached.GetPropertyOffset(OnCreateSessionCompleteCS_FunctionAddress, "bWasSuccessful");
		OnCreateSessionCompleteCS_bWasSuccessful_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCreateSessionCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnCreateSessionCompleteCS_IsValid = OnCreateSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnCreateSessionCompleteCS_SessionName_IsValid && OnCreateSessionCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:OnCreateSessionCompleteCS", OnCreateSessionCompleteCS_IsValid);
		LeaveGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LeaveGame");
		LeaveGame_ParamsSize = NativeReflection.GetFunctionParamsSize(LeaveGame_FunctionAddress);
		LeaveGame_IsValid = LeaveGame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:LeaveGame", LeaveGame_IsValid);
		JoinGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "JoinGame");
		JoinGame_ParamsSize = NativeReflection.GetFunctionParamsSize(JoinGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JoinGame_result_PropertyAddress, JoinGame_FunctionAddress, "result");
		JoinGame_result_Offset = NativeReflectionCached.GetPropertyOffset(JoinGame_FunctionAddress, "result");
		JoinGame_result_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinGame_FunctionAddress, "result", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinGame_ReturnValue_PropertyAddress, JoinGame_FunctionAddress, "ReturnValue");
		JoinGame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(JoinGame_FunctionAddress, "ReturnValue");
		JoinGame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinGame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		JoinGame_IsValid = JoinGame_FunctionAddress != IntPtr.Zero && JoinGame_result_IsValid && JoinGame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:JoinGame", JoinGame_IsValid);
		HostGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HostGame");
		HostGame_ParamsSize = NativeReflection.GetFunctionParamsSize(HostGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HostGame_bIsLAN_PropertyAddress, HostGame_FunctionAddress, "bIsLAN");
		HostGame_bIsLAN_Offset = NativeReflectionCached.GetPropertyOffset(HostGame_FunctionAddress, "bIsLAN");
		HostGame_bIsLAN_IsValid = NativeReflectionCached.ValidatePropertyClass(HostGame_FunctionAddress, "bIsLAN", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HostGame_MaxNumPlayers_PropertyAddress, HostGame_FunctionAddress, "MaxNumPlayers");
		HostGame_MaxNumPlayers_Offset = NativeReflectionCached.GetPropertyOffset(HostGame_FunctionAddress, "MaxNumPlayers");
		HostGame_MaxNumPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(HostGame_FunctionAddress, "MaxNumPlayers", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HostGame_CustumSettings_PropertyAddress, HostGame_FunctionAddress, "CustumSettings");
		HostGame_CustumSettings_Offset = NativeReflectionCached.GetPropertyOffset(HostGame_FunctionAddress, "CustumSettings");
		HostGame_CustumSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(HostGame_FunctionAddress, "CustumSettings", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref HostGame_ReturnValue_PropertyAddress, HostGame_FunctionAddress, "ReturnValue");
		HostGame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HostGame_FunctionAddress, "ReturnValue");
		HostGame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HostGame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HostGame_IsValid = HostGame_FunctionAddress != IntPtr.Zero && HostGame_bIsLAN_IsValid && HostGame_MaxNumPlayers_IsValid && HostGame_CustumSettings_IsValid && HostGame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:HostGame", HostGame_IsValid);
		HandleNetworkErrorCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleNetworkErrorCS");
		HandleNetworkErrorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleNetworkErrorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleNetworkErrorCS_World_PropertyAddress, HandleNetworkErrorCS_FunctionAddress, "World");
		HandleNetworkErrorCS_World_Offset = NativeReflectionCached.GetPropertyOffset(HandleNetworkErrorCS_FunctionAddress, "World");
		HandleNetworkErrorCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleNetworkErrorCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleNetworkErrorCS_FailureType_PropertyAddress, HandleNetworkErrorCS_FunctionAddress, "FailureType");
		HandleNetworkErrorCS_FailureType_Offset = NativeReflectionCached.GetPropertyOffset(HandleNetworkErrorCS_FunctionAddress, "FailureType");
		HandleNetworkErrorCS_FailureType_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleNetworkErrorCS_FunctionAddress, "FailureType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleNetworkErrorCS_ErrorString_PropertyAddress, HandleNetworkErrorCS_FunctionAddress, "ErrorString");
		HandleNetworkErrorCS_ErrorString_Offset = NativeReflectionCached.GetPropertyOffset(HandleNetworkErrorCS_FunctionAddress, "ErrorString");
		HandleNetworkErrorCS_ErrorString_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleNetworkErrorCS_FunctionAddress, "ErrorString", Classes.FStrProperty);
		HandleNetworkErrorCS_IsValid = HandleNetworkErrorCS_FunctionAddress != IntPtr.Zero && HandleNetworkErrorCS_World_IsValid && HandleNetworkErrorCS_FailureType_IsValid && HandleNetworkErrorCS_ErrorString_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:HandleNetworkErrorCS", HandleNetworkErrorCS_IsValid);
		FindGames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindGames");
		FindGames_ParamsSize = NativeReflection.GetFunctionParamsSize(FindGames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindGames_bIsLAN_PropertyAddress, FindGames_FunctionAddress, "bIsLAN");
		FindGames_bIsLAN_Offset = NativeReflectionCached.GetPropertyOffset(FindGames_FunctionAddress, "bIsLAN");
		FindGames_bIsLAN_IsValid = NativeReflectionCached.ValidatePropertyClass(FindGames_FunctionAddress, "bIsLAN", Classes.FBoolProperty);
		FindGames_IsValid = FindGames_FunctionAddress != IntPtr.Zero && FindGames_bIsLAN_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSubSystemMgr:FindGames", FindGames_IsValid);
	}
}
