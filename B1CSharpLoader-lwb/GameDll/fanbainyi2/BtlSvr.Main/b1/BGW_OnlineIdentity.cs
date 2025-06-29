using System;
using System.Collections.Generic;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineIdentity")]
public class BGW_OnlineIdentity : UBGWOnlineIdentity, IGameInstObj
{
	private enum EActionType
	{
		kRailAntiAddictionActionShowTips = 1,
		kRailAntiAddictionActionHalt
	}

	private class AntiAddictionActionData
	{
		public ActionType type { get; set; }

		public string title { get; set; }

		public string content { get; set; }

		public int display_duration_seconds { get; set; }
	}

	private class AntiAddictionAction
	{
		public AntiAddictionActionData action { get; set; }
	}

	private class ActionType
	{
		public int id { get; set; }

		public string name { get; set; }
	}

	private class AntiAddictionActions
	{
		public List<AntiAddictionAction> actions { get; set; }
	}

	private class AntiAddictionResult
	{
		public bool NeedHalt;

		public string Title;

		public string Content;

		public int DisplayDurationSec;
	}

	public delegate void Del_OnGetUserPrivilege(EBGWUserPrivileges Privilege, EBGWPrivilegeResult PrivilegeResult);

	public int _StatId = -1;

	private bool _IsLoginComplete;

	private Del_OnGetUserPrivilege RequestCallBack;

	private static bool OnLoginCompletedCS_IsValid;

	private static IntPtr OnLoginCompletedCS_FunctionAddress;

	private static int OnLoginCompletedCS_ParamsSize;

	private static bool OnLoginCompletedCS_bSuccessful_IsValid;

	private static int OnLoginCompletedCS_bSuccessful_Offset;

	private static FFieldAddress OnLoginCompletedCS_bSuccessful_PropertyAddress;

	private static bool OnRecvAntiAddictionActionCS_IsValid;

	private static IntPtr OnRecvAntiAddictionActionCS_FunctionAddress;

	private static int OnRecvAntiAddictionActionCS_ParamsSize;

	private static bool OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid;

	private static int OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset;

	private static FFieldAddress OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress;

	private static bool OnGetUserPrivilegeCompleteCS_IsValid;

	private static IntPtr OnGetUserPrivilegeCompleteCS_FunctionAddress;

	private static int OnGetUserPrivilegeCompleteCS_ParamsSize;

	private static bool OnGetUserPrivilegeCompleteCS_Privilege_IsValid;

	private static int OnGetUserPrivilegeCompleteCS_Privilege_Offset;

	private static FFieldAddress OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress;

	private static bool OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid;

	private static int OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset;

	private static FFieldAddress OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress;

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

	public bool IsLoginComplete => _IsLoginComplete;

	private AntiAddictionActions ParseRecvActionsFromJson(string JsonStr)
	{
		try
		{
			return JsonMapper.ToObject<AntiAddictionActions>(JsonStr);
		}
		catch (Exception ex)
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogError("JsonStr:" + JsonStr);
			SysLogUtil.ONLINE_SUBSYSTEM.LogError(ex.Message ?? "");
			return null;
		}
	}

	private AntiAddictionResult GetAntiAddictionResult(AntiAddictionActions RecvActions)
	{
		AntiAddictionResult antiAddictionResult = new AntiAddictionResult();
		foreach (AntiAddictionAction action in RecvActions.actions)
		{
			if ((long)action.action.type.id == 1 && action.action.type.name == EActionType.kRailAntiAddictionActionShowTips.ToString())
			{
				antiAddictionResult.Title = action.action.title;
				antiAddictionResult.Content = action.action.content;
				antiAddictionResult.DisplayDurationSec = action.action.display_duration_seconds;
			}
			if ((long)action.action.type.id == 2 && action.action.type.name == EActionType.kRailAntiAddictionActionHalt.ToString())
			{
				antiAddictionResult.NeedHalt = true;
			}
		}
		return antiAddictionResult;
	}

	public void OnAttach()
	{
	}

	public void OnInit()
	{
		Init();
		Login();
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

	public int GetTickGroupMask()
	{
		return 0;
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public static BGW_OnlineIdentity Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineIdentity>(WorldContext);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineIdentity:OnGetUserPrivilegeCompleteCS")]
	protected override void OnGetUserPrivilegeCompleteCS_Implementation(EBGWUserPrivileges Privilege, EBGWPrivilegeResult PrivilegeResult)
	{
		RequestCallBack?.Invoke(Privilege, PrivilegeResult);
		RequestCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineIdentity:OnRecvAntiAddictionActionCS")]
	protected override void OnRecvAntiAddictionActionCS_Implementation(string RecvActionsJsonStr)
	{
		AntiAddictionActions antiAddictionActions = ParseRecvActionsFromJson(RecvActionsJsonStr);
		if (antiAddictionActions != null)
		{
			AntiAddictionResult antiAddictionResult = GetAntiAddictionResult(antiAddictionActions);
			BGW_UIEventCollection.Get(this).Evt_UI_ShowComfirm(antiAddictionResult.NeedHalt, antiAddictionResult.Title, antiAddictionResult.Content, antiAddictionResult.DisplayDurationSec);
		}
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineIdentity:OnLoginCompletedCS")]
	protected override void OnLoginCompletedCS_Implementation(bool bSuccessful)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo(string.Format("{0}OnLoginCompletedCS Successful:{1}", "BGW_OnlineIdentity", bSuccessful));
		_IsLoginComplete = true;
	}

	public bool IsLogin()
	{
		return GetLoginStatus() == EBGWLoginStatus.LoggedIn;
	}

	public void GetUserPrivilege(EBGWUserPrivileges Privilege, Del_OnGetUserPrivilege CallBack)
	{
		RequestCallBack = CallBack;
		GetUserPrivilege(Privilege);
	}

	public string SafeGetUniquePlayerId()
	{
		return GetUniquePlayerId();
	}

	public string SafeGetPlayerNickname()
	{
		return GetPlayerNickname();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineIdentity:OnLoginCompletedCS")]
	private static void OnLoginCompletedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineIdentity bGW_OnlineIdentity = GCHelper.Find<BGW_OnlineIdentity>(obj);
		bool bSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnLoginCompletedCS_bSuccessful_Offset), 0, OnLoginCompletedCS_bSuccessful_PropertyAddress.Address);
		bGW_OnlineIdentity.OnLoginCompletedCS_Implementation(bSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineIdentity:OnRecvAntiAddictionActionCS")]
	private static void OnRecvAntiAddictionActionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineIdentity bGW_OnlineIdentity = GCHelper.Find<BGW_OnlineIdentity>(obj);
		string recvActionsJsonStr = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset));
		bGW_OnlineIdentity.OnRecvAntiAddictionActionCS_Implementation(recvActionsJsonStr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineIdentity:OnGetUserPrivilegeCompleteCS")]
	private static void OnGetUserPrivilegeCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineIdentity bGW_OnlineIdentity = GCHelper.Find<BGW_OnlineIdentity>(obj);
		EBGWUserPrivileges privilege = EnumMarshaler<EBGWUserPrivileges>.FromNative(IntPtr.Add(buffer, OnGetUserPrivilegeCompleteCS_Privilege_Offset), 0, OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress.Address);
		EBGWPrivilegeResult privilegeResult = EnumMarshaler<EBGWPrivilegeResult>.FromNative(IntPtr.Add(buffer, OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset), 0, OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress.Address);
		bGW_OnlineIdentity.OnGetUserPrivilegeCompleteCS_Implementation(privilege, privilegeResult);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineIdentity");
		OnLoginCompletedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLoginCompletedCS");
		OnLoginCompletedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLoginCompletedCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnLoginCompletedCS_bSuccessful_PropertyAddress, OnLoginCompletedCS_FunctionAddress, "bSuccessful");
		OnLoginCompletedCS_bSuccessful_Offset = NativeReflection.GetPropertyOffset(OnLoginCompletedCS_FunctionAddress, "bSuccessful");
		OnLoginCompletedCS_bSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnLoginCompletedCS_FunctionAddress, "bSuccessful", Classes.FBoolProperty);
		OnLoginCompletedCS_IsValid = OnLoginCompletedCS_FunctionAddress != IntPtr.Zero && OnLoginCompletedCS_bSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineIdentity:OnLoginCompletedCS", OnLoginCompletedCS_IsValid);
		OnRecvAntiAddictionActionCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRecvAntiAddictionActionCS");
		OnRecvAntiAddictionActionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRecvAntiAddictionActionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnRecvAntiAddictionActionCS_RecvActionsJsonStr_PropertyAddress, OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr");
		OnRecvAntiAddictionActionCS_RecvActionsJsonStr_Offset = NativeReflection.GetPropertyOffset(OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr");
		OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid = NativeReflection.ValidatePropertyClass(OnRecvAntiAddictionActionCS_FunctionAddress, "RecvActionsJsonStr", Classes.FStrProperty);
		OnRecvAntiAddictionActionCS_IsValid = OnRecvAntiAddictionActionCS_FunctionAddress != IntPtr.Zero && OnRecvAntiAddictionActionCS_RecvActionsJsonStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineIdentity:OnRecvAntiAddictionActionCS", OnRecvAntiAddictionActionCS_IsValid);
		OnGetUserPrivilegeCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGetUserPrivilegeCompleteCS");
		OnGetUserPrivilegeCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetUserPrivilegeCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnGetUserPrivilegeCompleteCS_Privilege_PropertyAddress, OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege");
		OnGetUserPrivilegeCompleteCS_Privilege_Offset = NativeReflection.GetPropertyOffset(OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege");
		OnGetUserPrivilegeCompleteCS_Privilege_IsValid = NativeReflection.ValidatePropertyClass(OnGetUserPrivilegeCompleteCS_FunctionAddress, "Privilege", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref OnGetUserPrivilegeCompleteCS_PrivilegeResult_PropertyAddress, OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult");
		OnGetUserPrivilegeCompleteCS_PrivilegeResult_Offset = NativeReflection.GetPropertyOffset(OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult");
		OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid = NativeReflection.ValidatePropertyClass(OnGetUserPrivilegeCompleteCS_FunctionAddress, "PrivilegeResult", Classes.FEnumProperty);
		OnGetUserPrivilegeCompleteCS_IsValid = OnGetUserPrivilegeCompleteCS_FunctionAddress != IntPtr.Zero && OnGetUserPrivilegeCompleteCS_Privilege_IsValid && OnGetUserPrivilegeCompleteCS_PrivilegeResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineIdentity:OnGetUserPrivilegeCompleteCS", OnGetUserPrivilegeCompleteCS_IsValid);
	}

	static BGW_OnlineIdentity()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineIdentity)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineIdentity));
	}
}
