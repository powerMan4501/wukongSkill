using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineSession")]
public class BGW_OnlineSession : UBGWOnlineSession, IGameInstObj
{
	public delegate void Del_OnCreateSessionComplete(bool Success);

	public delegate void Del_OnSearchSessionsComplete(bool Success);

	public delegate void Del_OnFindSessionByIdComplete(bool Success);

	public delegate void Del_OnJoinSessionComplete(EBGWJoinSessionResult Result);

	public delegate void Del_OnDestroySessionComplete(bool bSuccess);

	public int _StatId = -1;

	private Del_OnCreateSessionComplete CreateCallBack;

	private Del_OnSearchSessionsComplete SearchSessionsCallBack;

	private Del_OnFindSessionByIdComplete FindSessionCallBack;

	private Del_OnJoinSessionComplete JoinCallBack;

	private Dictionary<EBGWOnlineSessionType, Del_OnDestroySessionComplete> DestroySessionCallBack = new Dictionary<EBGWOnlineSessionType, Del_OnDestroySessionComplete>();

	private static bool OnJoinSessionCompleteCS_IsValid;

	private static IntPtr OnJoinSessionCompleteCS_FunctionAddress;

	private static int OnJoinSessionCompleteCS_ParamsSize;

	private static bool OnJoinSessionCompleteCS_Result_IsValid;

	private static int OnJoinSessionCompleteCS_Result_Offset;

	private static FFieldAddress OnJoinSessionCompleteCS_Result_PropertyAddress;

	private static bool OnCreateSessionCompleteCS_IsValid;

	private static IntPtr OnCreateSessionCompleteCS_FunctionAddress;

	private static int OnCreateSessionCompleteCS_ParamsSize;

	private static bool OnCreateSessionCompleteCS_Success_IsValid;

	private static int OnCreateSessionCompleteCS_Success_Offset;

	private static FFieldAddress OnCreateSessionCompleteCS_Success_PropertyAddress;

	private static bool OnSessionInviteReceivedCS_IsValid;

	private static IntPtr OnSessionInviteReceivedCS_FunctionAddress;

	private static int OnSessionInviteReceivedCS_ParamsSize;

	private static bool OnSearchSessionsCompleteCS_IsValid;

	private static IntPtr OnSearchSessionsCompleteCS_FunctionAddress;

	private static int OnSearchSessionsCompleteCS_ParamsSize;

	private static bool OnSearchSessionsCompleteCS_Success_IsValid;

	private static int OnSearchSessionsCompleteCS_Success_Offset;

	private static FFieldAddress OnSearchSessionsCompleteCS_Success_PropertyAddress;

	private static bool OnDestroySessionCompleteCS_IsValid;

	private static IntPtr OnDestroySessionCompleteCS_FunctionAddress;

	private static int OnDestroySessionCompleteCS_ParamsSize;

	private static bool OnDestroySessionCompleteCS_SessionType_IsValid;

	private static int OnDestroySessionCompleteCS_SessionType_Offset;

	private static FFieldAddress OnDestroySessionCompleteCS_SessionType_PropertyAddress;

	private static bool OnDestroySessionCompleteCS_Success_IsValid;

	private static int OnDestroySessionCompleteCS_Success_Offset;

	private static FFieldAddress OnDestroySessionCompleteCS_Success_PropertyAddress;

	private static bool OnFindSessionByIdCompleteCS_IsValid;

	private static IntPtr OnFindSessionByIdCompleteCS_FunctionAddress;

	private static int OnFindSessionByIdCompleteCS_ParamsSize;

	private static bool OnFindSessionByIdCompleteCS_Success_IsValid;

	private static int OnFindSessionByIdCompleteCS_Success_Offset;

	private static FFieldAddress OnFindSessionByIdCompleteCS_Success_PropertyAddress;

	private static bool OnSessionUserInviteAcceptedCS_IsValid;

	private static IntPtr OnSessionUserInviteAcceptedCS_FunctionAddress;

	private static int OnSessionUserInviteAcceptedCS_ParamsSize;

	private static bool OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid;

	private static int OnSessionUserInviteAcceptedCS_bWasSuccess_Offset;

	private static FFieldAddress OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress;

	public int StatId
	{
		get
		{
			if (_StatId < 0)
			{
				_StatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":Tick");
			}
			return _StatId;
		}
	}

	public bool bTickEnabled => false;

	public void OnAttach()
	{
	}

	public void OnInit()
	{
		Init();
	}

	public void OnAfterInit()
	{
	}

	public bool CanTick()
	{
		return false;
	}

	public void OnShutdown()
	{
		Destroy();
	}

	public void OnPostLoadMap()
	{
	}

	public void OnTick(float DeltaTime)
	{
	}

	public int GetTickGroupMask()
	{
		return 0;
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public static BGW_OnlineSession Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineSession>(WorldContext);
	}

	public bool IsAvaiable()
	{
		if (!BGW_OnlineIdentity.Get(this).IsLogin())
		{
			return false;
		}
		return true;
	}

	public void CreateSession(EBGWOnlineSessionType SessionType, string SessionToken, Del_OnCreateSessionComplete CallBack)
	{
		CreateCallBack = CallBack;
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		dictionary.Add(new FName("SessionToken"), SessionToken);
		CreateSession(SessionType, 4, dictionary, bIsLANMatch: false, "");
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnCreateSessionCompleteCS")]
	protected override void OnCreateSessionCompleteCS_Implementation(bool Success)
	{
		CreateCallBack?.Invoke(Success);
		CreateCallBack = null;
	}

	public void SearchSessions(EBGWOnlineSessionType SessionType, string SessionToken, bool IsLanMatch, Del_OnSearchSessionsComplete CallBack)
	{
		SearchSessionsCallBack = CallBack;
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		dictionary.Add(new FName("SessionToken"), SessionToken);
		SearchSessions(SessionType, dictionary, IsLanMatch);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnSearchSessionsCompleteCS")]
	protected override void OnSearchSessionsCompleteCS_Implementation(bool Success)
	{
		SearchSessionsCallBack?.Invoke(Success);
		SearchSessionsCallBack = null;
	}

	public void FindSessionById(string SessionId, bool IsGameSession, Del_OnFindSessionByIdComplete CallBack)
	{
		FindSessionCallBack = CallBack;
		FindSessionById(SessionId, IsGameSession);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnFindSessionByIdCompleteCS")]
	protected override void OnFindSessionByIdCompleteCS_Implementation(bool Success)
	{
		FindSessionCallBack?.Invoke(Success);
		FindSessionCallBack = null;
	}

	public void JoinSession(EBGWOnlineSessionType SessionType, string SessionId, Del_OnJoinSessionComplete CallBack)
	{
		JoinCallBack = CallBack;
		JoinSession(SessionType, SessionId);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnJoinSessionCompleteCS")]
	protected override void OnJoinSessionCompleteCS_Implementation(EBGWJoinSessionResult Result)
	{
		JoinCallBack?.Invoke(Result);
		JoinCallBack = null;
	}

	private void AddSessionDestroyCallback(EBGWOnlineSessionType SessionType, Del_OnDestroySessionComplete OnDestroyComplete)
	{
		if (OnDestroyComplete != null)
		{
			if (DestroySessionCallBack.ContainsKey(SessionType))
			{
				Dictionary<EBGWOnlineSessionType, Del_OnDestroySessionComplete> destroySessionCallBack = DestroySessionCallBack;
				EBGWOnlineSessionType key = SessionType;
				destroySessionCallBack[key] = (Del_OnDestroySessionComplete)Delegate.Combine(destroySessionCallBack[key], OnDestroyComplete);
			}
			else
			{
				DestroySessionCallBack[SessionType] = OnDestroyComplete;
			}
		}
	}

	public void DestroySession(EBGWOnlineSessionType SessionType, Del_OnDestroySessionComplete OnDestroyComplete)
	{
		AddSessionDestroyCallback(SessionType, OnDestroyComplete);
		DestroySession(SessionType);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnDestroySessionCompleteCS")]
	protected override void OnDestroySessionCompleteCS_Implementation(EBGWOnlineSessionType SessionType, bool Success)
	{
		if (DestroySessionCallBack.ContainsKey(SessionType))
		{
			DestroySessionCallBack[SessionType](Success);
			DestroySessionCallBack.Remove(SessionType);
		}
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnSessionInviteReceivedCS")]
	protected override void OnSessionInviteReceivedCS_Implementation()
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("OnReceiveUserInvite");
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineSession:OnSessionUserInviteAcceptedCS")]
	protected override void OnSessionUserInviteAcceptedCS_Implementation(bool bWasSuccess)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"OnReceiveUserInvite, Accepted:{bWasSuccess}");
	}

	public string GetSessionTravelUrl(EBGWOnlineSessionType SessionType)
	{
		if (GetSessionState(SessionType) != EBGWOnlineSessionState.NoSession)
		{
			return GetTravelUrl(SessionType);
		}
		SysLogUtil.ONLINE_SUBSYSTEM.LogError("role not in session, can not get travel url!");
		return "";
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnJoinSessionCompleteCS")]
	private static void OnJoinSessionCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		EBGWJoinSessionResult result = EnumMarshaler<EBGWJoinSessionResult>.FromNative(IntPtr.Add(buffer, OnJoinSessionCompleteCS_Result_Offset), 0, OnJoinSessionCompleteCS_Result_PropertyAddress.Address);
		bGW_OnlineSession.OnJoinSessionCompleteCS_Implementation(result);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnCreateSessionCompleteCS")]
	private static void OnCreateSessionCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		bool success = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCreateSessionCompleteCS_Success_Offset), 0, OnCreateSessionCompleteCS_Success_PropertyAddress.Address);
		bGW_OnlineSession.OnCreateSessionCompleteCS_Implementation(success);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnSessionInviteReceivedCS")]
	private static void OnSessionInviteReceivedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		bGW_OnlineSession.OnSessionInviteReceivedCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnSearchSessionsCompleteCS")]
	private static void OnSearchSessionsCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		bool success = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSearchSessionsCompleteCS_Success_Offset), 0, OnSearchSessionsCompleteCS_Success_PropertyAddress.Address);
		bGW_OnlineSession.OnSearchSessionsCompleteCS_Implementation(success);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnDestroySessionCompleteCS")]
	private static void OnDestroySessionCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		EBGWOnlineSessionType sessionType = EnumMarshaler<EBGWOnlineSessionType>.FromNative(IntPtr.Add(buffer, OnDestroySessionCompleteCS_SessionType_Offset), 0, OnDestroySessionCompleteCS_SessionType_PropertyAddress.Address);
		bool success = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnDestroySessionCompleteCS_Success_Offset), 0, OnDestroySessionCompleteCS_Success_PropertyAddress.Address);
		bGW_OnlineSession.OnDestroySessionCompleteCS_Implementation(sessionType, success);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnFindSessionByIdCompleteCS")]
	private static void OnFindSessionByIdCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		bool success = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnFindSessionByIdCompleteCS_Success_Offset), 0, OnFindSessionByIdCompleteCS_Success_PropertyAddress.Address);
		bGW_OnlineSession.OnFindSessionByIdCompleteCS_Implementation(success);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineSession:OnSessionUserInviteAcceptedCS")]
	private static void OnSessionUserInviteAcceptedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineSession bGW_OnlineSession = GCHelper.Find<BGW_OnlineSession>(obj);
		bool bWasSuccess = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSessionUserInviteAcceptedCS_bWasSuccess_Offset), 0, OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress.Address);
		bGW_OnlineSession.OnSessionUserInviteAcceptedCS_Implementation(bWasSuccess);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineSession");
		OnJoinSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnJoinSessionCompleteCS");
		OnJoinSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnJoinSessionCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnJoinSessionCompleteCS_Result_PropertyAddress, OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_Offset = NativeReflection.GetPropertyOffset(OnJoinSessionCompleteCS_FunctionAddress, "Result");
		OnJoinSessionCompleteCS_Result_IsValid = NativeReflection.ValidatePropertyClass(OnJoinSessionCompleteCS_FunctionAddress, "Result", Classes.FEnumProperty);
		OnJoinSessionCompleteCS_IsValid = OnJoinSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnJoinSessionCompleteCS_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnJoinSessionCompleteCS", OnJoinSessionCompleteCS_IsValid);
		OnCreateSessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCreateSessionCompleteCS");
		OnCreateSessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateSessionCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCreateSessionCompleteCS_Success_PropertyAddress, OnCreateSessionCompleteCS_FunctionAddress, "Success");
		OnCreateSessionCompleteCS_Success_Offset = NativeReflection.GetPropertyOffset(OnCreateSessionCompleteCS_FunctionAddress, "Success");
		OnCreateSessionCompleteCS_Success_IsValid = NativeReflection.ValidatePropertyClass(OnCreateSessionCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnCreateSessionCompleteCS_IsValid = OnCreateSessionCompleteCS_FunctionAddress != IntPtr.Zero && OnCreateSessionCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnCreateSessionCompleteCS", OnCreateSessionCompleteCS_IsValid);
		OnSessionInviteReceivedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSessionInviteReceivedCS");
		OnSessionInviteReceivedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSessionInviteReceivedCS_FunctionAddress);
		OnSessionInviteReceivedCS_IsValid = OnSessionInviteReceivedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnSessionInviteReceivedCS", OnSessionInviteReceivedCS_IsValid);
		OnSearchSessionsCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSearchSessionsCompleteCS");
		OnSearchSessionsCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSearchSessionsCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSearchSessionsCompleteCS_Success_PropertyAddress, OnSearchSessionsCompleteCS_FunctionAddress, "Success");
		OnSearchSessionsCompleteCS_Success_Offset = NativeReflection.GetPropertyOffset(OnSearchSessionsCompleteCS_FunctionAddress, "Success");
		OnSearchSessionsCompleteCS_Success_IsValid = NativeReflection.ValidatePropertyClass(OnSearchSessionsCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnSearchSessionsCompleteCS_IsValid = OnSearchSessionsCompleteCS_FunctionAddress != IntPtr.Zero && OnSearchSessionsCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnSearchSessionsCompleteCS", OnSearchSessionsCompleteCS_IsValid);
		OnDestroySessionCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDestroySessionCompleteCS");
		OnDestroySessionCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestroySessionCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnDestroySessionCompleteCS_SessionType_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "SessionType");
		OnDestroySessionCompleteCS_SessionType_Offset = NativeReflection.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "SessionType");
		OnDestroySessionCompleteCS_SessionType_IsValid = NativeReflection.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "SessionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref OnDestroySessionCompleteCS_Success_PropertyAddress, OnDestroySessionCompleteCS_FunctionAddress, "Success");
		OnDestroySessionCompleteCS_Success_Offset = NativeReflection.GetPropertyOffset(OnDestroySessionCompleteCS_FunctionAddress, "Success");
		OnDestroySessionCompleteCS_Success_IsValid = NativeReflection.ValidatePropertyClass(OnDestroySessionCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnDestroySessionCompleteCS_IsValid = OnDestroySessionCompleteCS_FunctionAddress != IntPtr.Zero && OnDestroySessionCompleteCS_SessionType_IsValid && OnDestroySessionCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnDestroySessionCompleteCS", OnDestroySessionCompleteCS_IsValid);
		OnFindSessionByIdCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnFindSessionByIdCompleteCS");
		OnFindSessionByIdCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFindSessionByIdCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnFindSessionByIdCompleteCS_Success_PropertyAddress, OnFindSessionByIdCompleteCS_FunctionAddress, "Success");
		OnFindSessionByIdCompleteCS_Success_Offset = NativeReflection.GetPropertyOffset(OnFindSessionByIdCompleteCS_FunctionAddress, "Success");
		OnFindSessionByIdCompleteCS_Success_IsValid = NativeReflection.ValidatePropertyClass(OnFindSessionByIdCompleteCS_FunctionAddress, "Success", Classes.FBoolProperty);
		OnFindSessionByIdCompleteCS_IsValid = OnFindSessionByIdCompleteCS_FunctionAddress != IntPtr.Zero && OnFindSessionByIdCompleteCS_Success_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnFindSessionByIdCompleteCS", OnFindSessionByIdCompleteCS_IsValid);
		OnSessionUserInviteAcceptedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSessionUserInviteAcceptedCS");
		OnSessionUserInviteAcceptedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSessionUserInviteAcceptedCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSessionUserInviteAcceptedCS_bWasSuccess_PropertyAddress, OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_Offset = NativeReflection.GetPropertyOffset(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess");
		OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid = NativeReflection.ValidatePropertyClass(OnSessionUserInviteAcceptedCS_FunctionAddress, "bWasSuccess", Classes.FBoolProperty);
		OnSessionUserInviteAcceptedCS_IsValid = OnSessionUserInviteAcceptedCS_FunctionAddress != IntPtr.Zero && OnSessionUserInviteAcceptedCS_bWasSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineSession:OnSessionUserInviteAcceptedCS", OnSessionUserInviteAcceptedCS_IsValid);
	}

	static BGW_OnlineSession()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineSession)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineSession));
	}
}
