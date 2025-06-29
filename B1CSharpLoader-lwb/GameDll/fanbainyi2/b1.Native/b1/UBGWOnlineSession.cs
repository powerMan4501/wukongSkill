using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGWOnlineSession", "b1", UnrealModuleType.Game)]
public class UBGWOnlineSession : UBGWOnlineInterface
{
	private static bool Context_IsValid;

	private static int Context_Offset;

	private static bool ShowInviteUI_IsValid;

	private static IntPtr ShowInviteUI_FunctionAddress;

	private static int ShowInviteUI_ParamsSize;

	private static bool ShowInviteUI_SessionType_IsValid;

	private static FFieldAddress ShowInviteUI_SessionType_PropertyAddress;

	private static int ShowInviteUI_SessionType_Offset;

	private static bool ShowFriendUI_IsValid;

	private static IntPtr ShowFriendUI_FunctionAddress;

	private static int ShowFriendUI_ParamsSize;

	private static bool SearchSessions_IsValid;

	private static IntPtr SearchSessions_FunctionAddress;

	private static int SearchSessions_ParamsSize;

	private static bool SearchSessions_SessionType_IsValid;

	private static FFieldAddress SearchSessions_SessionType_PropertyAddress;

	private static int SearchSessions_SessionType_Offset;

	private static bool SearchSessions_SearchFilters_IsValid;

	private static FFieldAddress SearchSessions_SearchFilters_PropertyAddress;

	private static int SearchSessions_SearchFilters_Offset;

	private static bool SearchSessions_bIsLANMatch_IsValid;

	private static FFieldAddress SearchSessions_bIsLANMatch_PropertyAddress;

	private static int SearchSessions_bIsLANMatch_Offset;

	private static bool OnSessionUserInviteAcceptedCS_IsValid;

	private IntPtr OnSessionUserInviteAcceptedCS_InstanceFunctionAddress;

	private static IntPtr OnSessionUserInviteAcceptedCS_FunctionAddress;

	private static int OnSessionUserInviteAcceptedCS_ParamsSize;

	private static bool OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid;

	private static FFieldAddress OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress;

	private static int OnSessionUserInviteAcceptedCS_bWasSuccess_Offset;

	private static bool OnSessionInviteReceivedCS_IsValid;

	private IntPtr OnSessionInviteReceivedCS_InstanceFunctionAddress;

	private static IntPtr OnSessionInviteReceivedCS_FunctionAddress;

	private static int OnSessionInviteReceivedCS_ParamsSize;

	private static bool OnSearchSessionsCompleteCS_IsValid;

	private IntPtr OnSearchSessionsCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnSearchSessionsCompleteCS_FunctionAddress;

	private static int OnSearchSessionsCompleteCS_ParamsSize;

	private static bool OnSearchSessionsCompleteCS_Success_IsValid;

	private static FFieldAddress OnSearchSessionsCompleteCS_Success_PropertyAddress;

	private static int OnSearchSessionsCompleteCS_Success_Offset;

	private static bool OnJoinSessionCompleteCS_IsValid;

	private IntPtr OnJoinSessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnJoinSessionCompleteCS_FunctionAddress;

	private static int OnJoinSessionCompleteCS_ParamsSize;

	private static bool OnJoinSessionCompleteCS_Result_IsValid;

	private static FFieldAddress OnJoinSessionCompleteCS_Result_PropertyAddress;

	private static int OnJoinSessionCompleteCS_Result_Offset;

	private static bool OnFindSessionByIdCompleteCS_IsValid;

	private IntPtr OnFindSessionByIdCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnFindSessionByIdCompleteCS_FunctionAddress;

	private static int OnFindSessionByIdCompleteCS_ParamsSize;

	private static bool OnFindSessionByIdCompleteCS_Success_IsValid;

	private static FFieldAddress OnFindSessionByIdCompleteCS_Success_PropertyAddress;

	private static int OnFindSessionByIdCompleteCS_Success_Offset;

	private static bool OnDestroySessionCompleteCS_IsValid;

	private IntPtr OnDestroySessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnDestroySessionCompleteCS_FunctionAddress;

	private static int OnDestroySessionCompleteCS_ParamsSize;

	private static bool OnDestroySessionCompleteCS_SessionType_IsValid;

	private static FFieldAddress OnDestroySessionCompleteCS_SessionType_PropertyAddress;

	private static int OnDestroySessionCompleteCS_SessionType_Offset;

	private static bool OnDestroySessionCompleteCS_Success_IsValid;

	private static FFieldAddress OnDestroySessionCompleteCS_Success_PropertyAddress;

	private static int OnDestroySessionCompleteCS_Success_Offset;

	private static bool OnCreateSessionCompleteCS_IsValid;

	private IntPtr OnCreateSessionCompleteCS_InstanceFunctionAddress;

	private static IntPtr OnCreateSessionCompleteCS_FunctionAddress;

	private static int OnCreateSessionCompleteCS_ParamsSize;

	private static bool OnCreateSessionCompleteCS_Success_IsValid;

	private static FFieldAddress OnCreateSessionCompleteCS_Success_PropertyAddress;

	private static int OnCreateSessionCompleteCS_Success_Offset;

	private static bool JoinSession_IsValid;

	private static IntPtr JoinSession_FunctionAddress;

	private static int JoinSession_ParamsSize;

	private static bool JoinSession_SessionType_IsValid;

	private static FFieldAddress JoinSession_SessionType_PropertyAddress;

	private static int JoinSession_SessionType_Offset;

	private static bool JoinSession_SessionId_IsValid;

	private static FFieldAddress JoinSession_SessionId_PropertyAddress;

	private static int JoinSession_SessionId_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_ReturnValue_IsValid;

	private static FFieldAddress Init_ReturnValue_PropertyAddress;

	private static int Init_ReturnValue_Offset;

	private static bool GetTravelUrl_IsValid;

	private static IntPtr GetTravelUrl_FunctionAddress;

	private static int GetTravelUrl_ParamsSize;

	private static bool GetTravelUrl_SessionType_IsValid;

	private static FFieldAddress GetTravelUrl_SessionType_PropertyAddress;

	private static int GetTravelUrl_SessionType_Offset;

	private static bool GetTravelUrl_ReturnValue_IsValid;

	private static FFieldAddress GetTravelUrl_ReturnValue_PropertyAddress;

	private static int GetTravelUrl_ReturnValue_Offset;

	private static bool GetSessionState_IsValid;

	private static IntPtr GetSessionState_FunctionAddress;

	private static int GetSessionState_ParamsSize;

	private static bool GetSessionState_SessionType_IsValid;

	private static FFieldAddress GetSessionState_SessionType_PropertyAddress;

	private static int GetSessionState_SessionType_Offset;

	private static bool GetSessionState_ReturnValue_IsValid;

	private static FFieldAddress GetSessionState_ReturnValue_PropertyAddress;

	private static int GetSessionState_ReturnValue_Offset;

	private static bool GetSessionIdStr_IsValid;

	private static IntPtr GetSessionIdStr_FunctionAddress;

	private static int GetSessionIdStr_ParamsSize;

	private static bool GetSessionIdStr_SessionType_IsValid;

	private static FFieldAddress GetSessionIdStr_SessionType_PropertyAddress;

	private static int GetSessionIdStr_SessionType_Offset;

	private static bool GetSessionIdStr_ReturnValue_IsValid;

	private static FFieldAddress GetSessionIdStr_ReturnValue_PropertyAddress;

	private static int GetSessionIdStr_ReturnValue_Offset;

	private static bool FindSessionById_IsValid;

	private static IntPtr FindSessionById_FunctionAddress;

	private static int FindSessionById_ParamsSize;

	private static bool FindSessionById_SessionId_IsValid;

	private static FFieldAddress FindSessionById_SessionId_PropertyAddress;

	private static int FindSessionById_SessionId_Offset;

	private static bool FindSessionById_IsGameSession_IsValid;

	private static FFieldAddress FindSessionById_IsGameSession_PropertyAddress;

	private static int FindSessionById_IsGameSession_Offset;

	private static bool DestroySession_IsValid;

	private static IntPtr DestroySession_FunctionAddress;

	private static int DestroySession_ParamsSize;

	private static bool DestroySession_SessionType_IsValid;

	private static FFieldAddress DestroySession_SessionType_PropertyAddress;

	private static int DestroySession_SessionType_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	private static bool CreateSession_IsValid;

	private static IntPtr CreateSession_FunctionAddress;

	private static int CreateSession_ParamsSize;

	private static bool CreateSession_SessionType_IsValid;

	private static FFieldAddress CreateSession_SessionType_PropertyAddress;

	private static int CreateSession_SessionType_Offset;

	private static bool CreateSession_MaxNumPlayers_IsValid;

	private static FFieldAddress CreateSession_MaxNumPlayers_PropertyAddress;

	private static int CreateSession_MaxNumPlayers_Offset;

	private static bool CreateSession_CustumSettings_IsValid;

	private static FFieldAddress CreateSession_CustumSettings_PropertyAddress;

	private static int CreateSession_CustumSettings_Offset;

	private static bool CreateSession_bIsLANMatch_IsValid;

	private static FFieldAddress CreateSession_bIsLANMatch_PropertyAddress;

	private static int CreateSession_bIsLANMatch_Offset;

	private static bool CreateSession_OverrideSessionTemplate_IsValid;

	private static FFieldAddress CreateSession_OverrideSessionTemplate_PropertyAddress;

	private static int CreateSession_OverrideSessionTemplate_Offset;

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/b1.BGWOnlineSession:Context")]
	public FBGWOnlineSessionContext Context
	{
		get
		{
			CheckDestroyed();
			if (!Context_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSession:Context");
				return default(FBGWOnlineSessionContext);
			}
			return FBGWOnlineSessionContext.FromNative(IntPtr.Add(base.Address, Context_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Context_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWOnlineSession:Context");
			}
			else
			{
				FBGWOnlineSessionContext.ToNative(IntPtr.Add(base.Address, Context_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:ShowInviteUI")]
	public unsafe void ShowInviteUI(EBGWOnlineSessionType SessionType)
	{
		CheckDestroyed();
		if (!ShowInviteUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:ShowInviteUI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowInviteUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowInviteUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, ShowInviteUI_SessionType_Offset), 0, ShowInviteUI_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowInviteUI_FunctionAddress, intPtr, ShowInviteUI_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:ShowFriendUI")]
	public unsafe void ShowFriendUI()
	{
		CheckDestroyed();
		if (!ShowFriendUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:ShowFriendUI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowFriendUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowFriendUI_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ShowFriendUI_FunctionAddress, argsSize: ShowFriendUI_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:SearchSessions")]
	protected unsafe void SearchSessions(EBGWOnlineSessionType SessionType, Dictionary<FName, string> SearchFilters, bool bIsLANMatch)
	{
		CheckDestroyed();
		if (!SearchSessions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:SearchSessions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SearchSessions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SearchSessions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, SearchSessions_SessionType_Offset), 0, SearchSessions_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InitializeValue_InContainer(SearchSessions_SearchFilters_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, string>(1, SearchSessions_SearchFilters_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SearchSessions_SearchFilters_Offset), SearchFilters);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SearchSessions_bIsLANMatch_Offset), 0, SearchSessions_bIsLANMatch_PropertyAddress.Address, bIsLANMatch);
		NativeReflection.InvokeFunctionOptimized(base.Address, SearchSessions_FunctionAddress, intPtr, SearchSessions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SearchSessions_SearchFilters_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnSessionUserInviteAcceptedCS")]
	protected unsafe void OnSessionUserInviteAcceptedCS(bool bWasSuccess)
	{
		CheckDestroyed();
		if (!OnSessionUserInviteAcceptedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSessionUserInviteAcceptedCS");
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
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSessionUserInviteAcceptedCS_InstanceFunctionAddress, intPtr, OnSessionUserInviteAcceptedCS_ParamsSize);
	}

	protected unsafe virtual void OnSessionUserInviteAcceptedCS_Implementation(bool bWasSuccess)
	{
		CheckDestroyed();
		if (!OnSessionUserInviteAcceptedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSessionUserInviteAcceptedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSessionUserInviteAcceptedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSessionUserInviteAcceptedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSessionUserInviteAcceptedCS_bWasSuccess_Offset), 0, OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress.Address, bWasSuccess);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSessionUserInviteAcceptedCS_FunctionAddress, intPtr, OnSessionUserInviteAcceptedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnSessionInviteReceivedCS")]
	protected unsafe void OnSessionInviteReceivedCS()
	{
		CheckDestroyed();
		if (!OnSessionInviteReceivedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSessionInviteReceivedCS");
			return;
		}
		if (OnSessionInviteReceivedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSessionInviteReceivedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSessionInviteReceivedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSessionInviteReceivedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSessionInviteReceivedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnSessionInviteReceivedCS_InstanceFunctionAddress, argsSize: OnSessionInviteReceivedCS_ParamsSize);
	}

	protected unsafe virtual void OnSessionInviteReceivedCS_Implementation()
	{
		CheckDestroyed();
		if (!OnSessionInviteReceivedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSessionInviteReceivedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSessionInviteReceivedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSessionInviteReceivedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnSessionInviteReceivedCS_FunctionAddress, argsSize: OnSessionInviteReceivedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnSearchSessionsCompleteCS")]
	protected unsafe void OnSearchSessionsCompleteCS(bool Success)
	{
		CheckDestroyed();
		if (!OnSearchSessionsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSearchSessionsCompleteCS");
			return;
		}
		if (OnSearchSessionsCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSearchSessionsCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSearchSessionsCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSearchSessionsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSearchSessionsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSearchSessionsCompleteCS_Success_Offset), 0, OnSearchSessionsCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSearchSessionsCompleteCS_InstanceFunctionAddress, intPtr, OnSearchSessionsCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnSearchSessionsCompleteCS_Implementation(bool Success)
	{
		CheckDestroyed();
		if (!OnSearchSessionsCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnSearchSessionsCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSearchSessionsCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSearchSessionsCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSearchSessionsCompleteCS_Success_Offset), 0, OnSearchSessionsCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSearchSessionsCompleteCS_FunctionAddress, intPtr, OnSearchSessionsCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnJoinSessionCompleteCS")]
	protected unsafe void OnJoinSessionCompleteCS(EBGWJoinSessionResult Result)
	{
		CheckDestroyed();
		if (!OnJoinSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnJoinSessionCompleteCS");
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
		EnumMarshaler<EBGWJoinSessionResult>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_Result_Offset), 0, OnJoinSessionCompleteCS_Result_PropertyAddress.Address, Result);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnJoinSessionCompleteCS_InstanceFunctionAddress, intPtr, OnJoinSessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnJoinSessionCompleteCS_Implementation(EBGWJoinSessionResult Result)
	{
		CheckDestroyed();
		if (!OnJoinSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnJoinSessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnJoinSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnJoinSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWJoinSessionResult>.ToNative(IntPtr.Add(intPtr, OnJoinSessionCompleteCS_Result_Offset), 0, OnJoinSessionCompleteCS_Result_PropertyAddress.Address, Result);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnJoinSessionCompleteCS_FunctionAddress, intPtr, OnJoinSessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnFindSessionByIdCompleteCS")]
	protected unsafe void OnFindSessionByIdCompleteCS(bool Success)
	{
		CheckDestroyed();
		if (!OnFindSessionByIdCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnFindSessionByIdCompleteCS");
			return;
		}
		if (OnFindSessionByIdCompleteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFindSessionByIdCompleteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFindSessionByIdCompleteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFindSessionByIdCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFindSessionByIdCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnFindSessionByIdCompleteCS_Success_Offset), 0, OnFindSessionByIdCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFindSessionByIdCompleteCS_InstanceFunctionAddress, intPtr, OnFindSessionByIdCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnFindSessionByIdCompleteCS_Implementation(bool Success)
	{
		CheckDestroyed();
		if (!OnFindSessionByIdCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnFindSessionByIdCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFindSessionByIdCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFindSessionByIdCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnFindSessionByIdCompleteCS_Success_Offset), 0, OnFindSessionByIdCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFindSessionByIdCompleteCS_FunctionAddress, intPtr, OnFindSessionByIdCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnDestroySessionCompleteCS")]
	protected unsafe void OnDestroySessionCompleteCS(EBGWOnlineSessionType SessionType, bool Success)
	{
		CheckDestroyed();
		if (!OnDestroySessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnDestroySessionCompleteCS");
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
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_SessionType_Offset), 0, OnDestroySessionCompleteCS_SessionType_PropertyAddress.Address, SessionType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_Success_Offset), 0, OnDestroySessionCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroySessionCompleteCS_InstanceFunctionAddress, intPtr, OnDestroySessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnDestroySessionCompleteCS_Implementation(EBGWOnlineSessionType SessionType, bool Success)
	{
		CheckDestroyed();
		if (!OnDestroySessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnDestroySessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestroySessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestroySessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_SessionType_Offset), 0, OnDestroySessionCompleteCS_SessionType_PropertyAddress.Address, SessionType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnDestroySessionCompleteCS_Success_Offset), 0, OnDestroySessionCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDestroySessionCompleteCS_FunctionAddress, intPtr, OnDestroySessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:OnCreateSessionCompleteCS")]
	protected unsafe void OnCreateSessionCompleteCS(bool Success)
	{
		CheckDestroyed();
		if (!OnCreateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnCreateSessionCompleteCS");
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
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_Success_Offset), 0, OnCreateSessionCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCreateSessionCompleteCS_InstanceFunctionAddress, intPtr, OnCreateSessionCompleteCS_ParamsSize);
	}

	protected unsafe virtual void OnCreateSessionCompleteCS_Implementation(bool Success)
	{
		CheckDestroyed();
		if (!OnCreateSessionCompleteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:OnCreateSessionCompleteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreateSessionCompleteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreateSessionCompleteCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnCreateSessionCompleteCS_Success_Offset), 0, OnCreateSessionCompleteCS_Success_PropertyAddress.Address, Success);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCreateSessionCompleteCS_FunctionAddress, intPtr, OnCreateSessionCompleteCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:JoinSession")]
	protected unsafe void JoinSession(EBGWOnlineSessionType SessionType, string SessionId)
	{
		CheckDestroyed();
		if (!JoinSession_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:JoinSession");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JoinSession_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JoinSession_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, JoinSession_SessionType_Offset), 0, JoinSession_SessionType_PropertyAddress.Address, SessionType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, JoinSession_SessionId_Offset), 0, JoinSession_SessionId_PropertyAddress.Address, SessionId);
		NativeReflection.InvokeFunctionOptimized(base.Address, JoinSession_FunctionAddress, intPtr, JoinSession_ParamsSize);
		NativeReflection.DestroyValue_InContainer(JoinSession_SessionId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:Init")]
	protected unsafe int Init()
	{
		CheckDestroyed();
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:Init");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Init_FunctionAddress, intPtr, Init_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Init_ReturnValue_Offset), 0, Init_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:GetTravelUrl")]
	public unsafe string GetTravelUrl(EBGWOnlineSessionType SessionType)
	{
		CheckDestroyed();
		if (!GetTravelUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:GetTravelUrl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTravelUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTravelUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, GetTravelUrl_SessionType_Offset), 0, GetTravelUrl_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTravelUrl_FunctionAddress, intPtr, GetTravelUrl_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTravelUrl_ReturnValue_Offset), 0, GetTravelUrl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTravelUrl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:GetSessionState")]
	public unsafe EBGWOnlineSessionState GetSessionState(EBGWOnlineSessionType SessionType)
	{
		CheckDestroyed();
		if (!GetSessionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:GetSessionState");
			return EBGWOnlineSessionState.NoSession;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSessionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSessionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, GetSessionState_SessionType_Offset), 0, GetSessionState_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSessionState_FunctionAddress, intPtr, GetSessionState_ParamsSize);
		return EnumMarshaler<EBGWOnlineSessionState>.FromNative(IntPtr.Add(intPtr, GetSessionState_ReturnValue_Offset), 0, GetSessionState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:GetSessionIdStr")]
	public unsafe string GetSessionIdStr(EBGWOnlineSessionType SessionType)
	{
		CheckDestroyed();
		if (!GetSessionIdStr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:GetSessionIdStr");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSessionIdStr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSessionIdStr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, GetSessionIdStr_SessionType_Offset), 0, GetSessionIdStr_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSessionIdStr_FunctionAddress, intPtr, GetSessionIdStr_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSessionIdStr_ReturnValue_Offset), 0, GetSessionIdStr_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSessionIdStr_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:FindSessionById")]
	protected unsafe void FindSessionById(string SessionId, bool IsGameSession = false)
	{
		CheckDestroyed();
		if (!FindSessionById_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:FindSessionById");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSessionById_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSessionById_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindSessionById_SessionId_Offset), 0, FindSessionById_SessionId_PropertyAddress.Address, SessionId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindSessionById_IsGameSession_Offset), 0, FindSessionById_IsGameSession_PropertyAddress.Address, IsGameSession);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSessionById_FunctionAddress, intPtr, FindSessionById_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindSessionById_SessionId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:DestroySession")]
	protected unsafe void DestroySession(EBGWOnlineSessionType SessionType)
	{
		CheckDestroyed();
		if (!DestroySession_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:DestroySession");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroySession_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroySession_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, DestroySession_SessionType_Offset), 0, DestroySession_SessionType_PropertyAddress.Address, SessionType);
		NativeReflection.InvokeFunctionOptimized(base.Address, DestroySession_FunctionAddress, intPtr, DestroySession_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:Destroy")]
	protected unsafe void Destroy()
	{
		CheckDestroyed();
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:Destroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destroy_FunctionAddress, argsSize: Destroy_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGWOnlineSession:CreateSession")]
	protected unsafe void CreateSession(EBGWOnlineSessionType SessionType, int MaxNumPlayers, Dictionary<FName, string> CustumSettings, bool bIsLANMatch, string OverrideSessionTemplate)
	{
		CheckDestroyed();
		if (!CreateSession_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWOnlineSession:CreateSession");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateSession_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateSession_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGWOnlineSessionType>.ToNative(IntPtr.Add(intPtr, CreateSession_SessionType_Offset), 0, CreateSession_SessionType_PropertyAddress.Address, SessionType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateSession_MaxNumPlayers_Offset), 0, CreateSession_MaxNumPlayers_PropertyAddress.Address, MaxNumPlayers);
		NativeReflection.InitializeValue_InContainer(CreateSession_CustumSettings_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, string>(1, CreateSession_CustumSettings_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CreateSession_CustumSettings_Offset), CustumSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateSession_bIsLANMatch_Offset), 0, CreateSession_bIsLANMatch_PropertyAddress.Address, bIsLANMatch);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateSession_OverrideSessionTemplate_Offset), 0, CreateSession_OverrideSessionTemplate_PropertyAddress.Address, OverrideSessionTemplate);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateSession_FunctionAddress, intPtr, CreateSession_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateSession_CustumSettings_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateSession_OverrideSessionTemplate_PropertyAddress.Address, intPtr);
	}

	static UBGWOnlineSession()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWOnlineSession)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWOnlineSession));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWOnlineSession");
		Context_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Context");
		Context_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Context", Classes.FStructProperty);
		ShowInviteUI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowInviteUI");
		ShowInviteUI_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowInviteUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowInviteUI_SessionType_PropertyAddress, ShowInviteUI_FunctionAddress, "SessionType");
		ShowInviteUI_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(ShowInviteUI_FunctionAddress, "SessionType");
		ShowInviteUI_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowInviteUI_FunctionAddress, "SessionType", Classes.FByteProperty);
		ShowInviteUI_IsValid = ShowInviteUI_FunctionAddress != IntPtr.Zero && ShowInviteUI_SessionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:ShowInviteUI", ShowInviteUI_IsValid);
		ShowFriendUI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowFriendUI");
		ShowFriendUI_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowFriendUI_FunctionAddress);
		ShowFriendUI_IsValid = ShowFriendUI_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:ShowFriendUI", ShowFriendUI_IsValid);
		SearchSessions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SearchSessions");
		SearchSessions_ParamsSize = NativeReflection.GetFunctionParamsSize(SearchSessions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SearchSessions_SessionType_PropertyAddress, SearchSessions_FunctionAddress, "SessionType");
		SearchSessions_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(SearchSessions_FunctionAddress, "SessionType");
		SearchSessions_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchSessions_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SearchSessions_SearchFilters_PropertyAddress, SearchSessions_FunctionAddress, "SearchFilters");
		SearchSessions_SearchFilters_Offset = NativeReflectionCached.GetPropertyOffset(SearchSessions_FunctionAddress, "SearchFilters");
		SearchSessions_SearchFilters_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchSessions_FunctionAddress, "SearchFilters", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref SearchSessions_bIsLANMatch_PropertyAddress, SearchSessions_FunctionAddress, "bIsLANMatch");
		SearchSessions_bIsLANMatch_Offset = NativeReflectionCached.GetPropertyOffset(SearchSessions_FunctionAddress, "bIsLANMatch");
		SearchSessions_bIsLANMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchSessions_FunctionAddress, "bIsLANMatch", Classes.FBoolProperty);
		SearchSessions_IsValid = SearchSessions_FunctionAddress != IntPtr.Zero && SearchSessions_SessionType_IsValid && SearchSessions_SearchFilters_IsValid && SearchSessions_bIsLANMatch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:SearchSessions", SearchSessions_IsValid);
		OnSessionUserInviteAcceptedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSessionUserInviteAcceptedCS");
		OnSessionUserInviteAcceptedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSessionUserInviteAcceptedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress, OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess", Classes.FBoolProperty);
		OnSessionUserInviteAcceptedCS_IsValid = OnSessionUserInviteAcceptedCS_FunctionAddress != IntPtr.Zero && OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnSessionUserInviteAcceptedCS", OnSessionUserInviteAcceptedCS_IsValid);
		OnSessionInviteReceivedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSessionInviteReceivedCS");
		OnSessionInviteReceivedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSessionInviteReceivedCS_FunctionAddress);
		OnSessionInviteReceivedCS_IsValid = OnSessionInviteReceivedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnSessionInviteReceivedCS", OnSessionInviteReceivedCS_IsValid);
		OnSearchSessionsCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSearchSessionsCompleteCS");
		OnSearchSessionsCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSearchSessionsCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSearchSessionsCompleteCS_Success_PropertyAddress, OnSearchSessionsCompleteCS_FunctionAddress, "Success");
		OnSearchSessionsCompleteCS_Success_Offset = NativeReflectionCached.GetPropertyOffset(OnSearchSessionsCompleteCS_FunctionAddress, "Success");
		OnSearchSessionsCompleteCS_Success_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSearchSessionsCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnSearchSessionsCompleteCS_IsValid = OnSearchSessionsCompleteCS_FunctionAddress != IntPtr.Zero && OnSearchSessionsCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnSearchSessionsCompleteCS", OnSearchSessionsCompleteCS_IsValid);
		OnJoinSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnJoinSessionCompleteCS");
		OnJoinSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnJoinSessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnJoinSessionCompleteCS_Result_PropertyAddress, OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_Offset = NativeReflectionCached.GetPropertyOffset(OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(OnJoinSessionCompleteCS_FunctionAddress, "Result", Classes.FByteProperty);
		OnJoinSessionCompleteCS_IsValid = OnJoinSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnJoinSessionCompleteCS_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnJoinSessionCompleteCS", OnJoinSessionCompleteCS_IsValid);
		OnFindSessionByIdCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFindSessionByIdCompleteCS");
		OnFindSessionByIdCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFindSessionByIdCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFindSessionByIdCompleteCS_Success_PropertyAddress, OnFindSessionByIdCompleteCS_FunctionAddress, "Success");
		OnFindSessionByIdCompleteCS_Success_Offset = NativeReflectionCached.GetPropertyOffset(OnFindSessionByIdCompleteCS_FunctionAddress, "Success");
		OnFindSessionByIdCompleteCS_Success_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFindSessionByIdCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnFindSessionByIdCompleteCS_IsValid = OnFindSessionByIdCompleteCS_FunctionAddress != IntPtr.Zero && OnFindSessionByIdCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnFindSessionByIdCompleteCS", OnFindSessionByIdCompleteCS_IsValid);
		OnDestroySessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDestroySessionCompleteCS");
		OnDestroySessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroySessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDestroySessionCompleteCS_SessionType_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "SessionType");
		OnDestroySessionCompleteCS_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "SessionType");
		OnDestroySessionCompleteCS_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDestroySessionCompleteCS_Success_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "Success");
		OnDestroySessionCompleteCS_Success_Offset = NativeReflectionCached.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "Success");
		OnDestroySessionCompleteCS_Success_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnDestroySessionCompleteCS_IsValid = OnDestroySessionCompleteCS_FunctionAddress != IntPtr.Zero && OnDestroySessionCompleteCS_SessionType_IsValid && OnDestroySessionCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnDestroySessionCompleteCS", OnDestroySessionCompleteCS_IsValid);
		OnCreateSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreateSessionCompleteCS");
		OnCreateSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateSessionCompleteCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCreateSessionCompleteCS_Success_PropertyAddress, OnCreateSessionCompleteCS_FunctionAddress, "Success");
		OnCreateSessionCompleteCS_Success_Offset = NativeReflectionCached.GetPropertyOffset(OnCreateSessionCompleteCS_FunctionAddress, "Success");
		OnCreateSessionCompleteCS_Success_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCreateSessionCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnCreateSessionCompleteCS_IsValid = OnCreateSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnCreateSessionCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:OnCreateSessionCompleteCS", OnCreateSessionCompleteCS_IsValid);
		JoinSession_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "JoinSession");
		JoinSession_ParamsSize = NativeReflection.GetFunctionParamsSize(JoinSession_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref JoinSession_SessionType_PropertyAddress, JoinSession_FunctionAddress, "SessionType");
		JoinSession_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(JoinSession_FunctionAddress, "SessionType");
		JoinSession_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinSession_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref JoinSession_SessionId_PropertyAddress, JoinSession_FunctionAddress, "SessionId");
		JoinSession_SessionId_Offset = NativeReflectionCached.GetPropertyOffset(JoinSession_FunctionAddress, "SessionId");
		JoinSession_SessionId_IsValid = NativeReflectionCached.ValidatePropertyClass(JoinSession_FunctionAddress, "SessionId", Classes.FStrProperty);
		JoinSession_IsValid = JoinSession_FunctionAddress != IntPtr.Zero && JoinSession_SessionType_IsValid && JoinSession_SessionId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:JoinSession", JoinSession_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Init_ReturnValue_PropertyAddress, Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Init_FunctionAddress, "ReturnValue");
		Init_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Init_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:Init", Init_IsValid);
		GetTravelUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTravelUrl");
		GetTravelUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTravelUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTravelUrl_SessionType_PropertyAddress, GetTravelUrl_FunctionAddress, "SessionType");
		GetTravelUrl_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(GetTravelUrl_FunctionAddress, "SessionType");
		GetTravelUrl_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTravelUrl_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTravelUrl_ReturnValue_PropertyAddress, GetTravelUrl_FunctionAddress, "ReturnValue");
		GetTravelUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTravelUrl_FunctionAddress, "ReturnValue");
		GetTravelUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTravelUrl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTravelUrl_IsValid = GetTravelUrl_FunctionAddress != IntPtr.Zero && GetTravelUrl_SessionType_IsValid && GetTravelUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:GetTravelUrl", GetTravelUrl_IsValid);
		GetSessionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSessionState");
		GetSessionState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSessionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSessionState_SessionType_PropertyAddress, GetSessionState_FunctionAddress, "SessionType");
		GetSessionState_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(GetSessionState_FunctionAddress, "SessionType");
		GetSessionState_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSessionState_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSessionState_ReturnValue_PropertyAddress, GetSessionState_FunctionAddress, "ReturnValue");
		GetSessionState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSessionState_FunctionAddress, "ReturnValue");
		GetSessionState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSessionState_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetSessionState_IsValid = GetSessionState_FunctionAddress != IntPtr.Zero && GetSessionState_SessionType_IsValid && GetSessionState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:GetSessionState", GetSessionState_IsValid);
		GetSessionIdStr_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSessionIdStr");
		GetSessionIdStr_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSessionIdStr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSessionIdStr_SessionType_PropertyAddress, GetSessionIdStr_FunctionAddress, "SessionType");
		GetSessionIdStr_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(GetSessionIdStr_FunctionAddress, "SessionType");
		GetSessionIdStr_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSessionIdStr_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSessionIdStr_ReturnValue_PropertyAddress, GetSessionIdStr_FunctionAddress, "ReturnValue");
		GetSessionIdStr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSessionIdStr_FunctionAddress, "ReturnValue");
		GetSessionIdStr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSessionIdStr_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSessionIdStr_IsValid = GetSessionIdStr_FunctionAddress != IntPtr.Zero && GetSessionIdStr_SessionType_IsValid && GetSessionIdStr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:GetSessionIdStr", GetSessionIdStr_IsValid);
		FindSessionById_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindSessionById");
		FindSessionById_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSessionById_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSessionById_SessionId_PropertyAddress, FindSessionById_FunctionAddress, "SessionId");
		FindSessionById_SessionId_Offset = NativeReflectionCached.GetPropertyOffset(FindSessionById_FunctionAddress, "SessionId");
		FindSessionById_SessionId_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSessionById_FunctionAddress, "SessionId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSessionById_IsGameSession_PropertyAddress, FindSessionById_FunctionAddress, "IsGameSession");
		FindSessionById_IsGameSession_Offset = NativeReflectionCached.GetPropertyOffset(FindSessionById_FunctionAddress, "IsGameSession");
		FindSessionById_IsGameSession_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSessionById_FunctionAddress, "IsGameSession", Classes.FBoolProperty);
		FindSessionById_IsValid = FindSessionById_FunctionAddress != IntPtr.Zero && FindSessionById_SessionId_IsValid && FindSessionById_IsGameSession_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:FindSessionById", FindSessionById_IsValid);
		DestroySession_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DestroySession");
		DestroySession_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroySession_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroySession_SessionType_PropertyAddress, DestroySession_FunctionAddress, "SessionType");
		DestroySession_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(DestroySession_FunctionAddress, "SessionType");
		DestroySession_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroySession_FunctionAddress, "SessionType", Classes.FByteProperty);
		DestroySession_IsValid = DestroySession_FunctionAddress != IntPtr.Zero && DestroySession_SessionType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:DestroySession", DestroySession_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:Destroy", Destroy_IsValid);
		CreateSession_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateSession");
		CreateSession_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSession_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateSession_SessionType_PropertyAddress, CreateSession_FunctionAddress, "SessionType");
		CreateSession_SessionType_Offset = NativeReflectionCached.GetPropertyOffset(CreateSession_FunctionAddress, "SessionType");
		CreateSession_SessionType_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSession_FunctionAddress, "SessionType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSession_MaxNumPlayers_PropertyAddress, CreateSession_FunctionAddress, "MaxNumPlayers");
		CreateSession_MaxNumPlayers_Offset = NativeReflectionCached.GetPropertyOffset(CreateSession_FunctionAddress, "MaxNumPlayers");
		CreateSession_MaxNumPlayers_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSession_FunctionAddress, "MaxNumPlayers", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSession_CustumSettings_PropertyAddress, CreateSession_FunctionAddress, "CustumSettings");
		CreateSession_CustumSettings_Offset = NativeReflectionCached.GetPropertyOffset(CreateSession_FunctionAddress, "CustumSettings");
		CreateSession_CustumSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSession_FunctionAddress, "CustumSettings", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSession_bIsLANMatch_PropertyAddress, CreateSession_FunctionAddress, "bIsLANMatch");
		CreateSession_bIsLANMatch_Offset = NativeReflectionCached.GetPropertyOffset(CreateSession_FunctionAddress, "bIsLANMatch");
		CreateSession_bIsLANMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSession_FunctionAddress, "bIsLANMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateSession_OverrideSessionTemplate_PropertyAddress, CreateSession_FunctionAddress, "OverrideSessionTemplate");
		CreateSession_OverrideSessionTemplate_Offset = NativeReflectionCached.GetPropertyOffset(CreateSession_FunctionAddress, "OverrideSessionTemplate");
		CreateSession_OverrideSessionTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateSession_FunctionAddress, "OverrideSessionTemplate", Classes.FStrProperty);
		CreateSession_IsValid = CreateSession_FunctionAddress != IntPtr.Zero && CreateSession_SessionType_IsValid && CreateSession_MaxNumPlayers_IsValid && CreateSession_CustumSettings_IsValid && CreateSession_bIsLANMatch_IsValid && CreateSession_OverrideSessionTemplate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWOnlineSession:CreateSession", CreateSession_IsValid);
	}
}
