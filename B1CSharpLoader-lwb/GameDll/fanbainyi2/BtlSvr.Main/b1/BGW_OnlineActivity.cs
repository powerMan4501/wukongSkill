using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_OnlineActivity")]
public class BGW_OnlineActivity : UBGWOnlineActivity, IGameInstObj
{
	public delegate void Del_OnStartActivityComplete(bool bWasSuccessful);

	public delegate void Del_OnGameActivityActivationComplete(string sActivityId, string sSessionStr);

	public delegate void Del_OnSetActivityAvailabilityComplete(bool bWasSuccessful);

	public delegate void Del_OnEndActivityComplete(bool bWasSuccessful);

	public delegate void Del_OnSetActivityPriorityComplete(bool bWasSuccessful);

	public delegate void Del_OnResumeActivityComplete(bool bWasSuccessful);

	public delegate void Del_OnResetAllActiveActivitiesComplete(bool bWasSuccessful);

	public int _StatId = -1;

	private FCachedActivityIntentReceivedParamCS CachedActivityIntentReceivedParamCS;

	private bool bStartedByGameIntent;

	private int CurActivity;

	private Del_OnStartActivityComplete StartActivityCallBack;

	private Del_OnGameActivityActivationComplete GameActivityActivationCompleteCallBack;

	private Del_OnSetActivityAvailabilityComplete SetActivityAvailabilityCallBack;

	private Del_OnEndActivityComplete EndActivityCallBack;

	private Del_OnSetActivityPriorityComplete SetActivityPriorityCallBack;

	private Del_OnResumeActivityComplete ResumeActivityCallBack;

	private Del_OnResetAllActiveActivitiesComplete ResetAllActiveActivitiesCallBack;

	private static bool OnEndActivityCompleteCS_IsValid;

	private static IntPtr OnEndActivityCompleteCS_FunctionAddress;

	private static int OnEndActivityCompleteCS_ParamsSize;

	private static bool OnEndActivityCompleteCS_bWasSuccessful_IsValid;

	private static int OnEndActivityCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnStartActivityCompleteCS_IsValid;

	private static IntPtr OnStartActivityCompleteCS_FunctionAddress;

	private static int OnStartActivityCompleteCS_ParamsSize;

	private static bool OnStartActivityCompleteCS_bWasSuccessful_IsValid;

	private static int OnStartActivityCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnResumeActivityCompleteCS_IsValid;

	private static IntPtr OnResumeActivityCompleteCS_FunctionAddress;

	private static int OnResumeActivityCompleteCS_ParamsSize;

	private static bool OnResumeActivityCompleteCS_bWasSuccessful_IsValid;

	private static int OnResumeActivityCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnSetActivityPriorityCompleteCS_IsValid;

	private static IntPtr OnSetActivityPriorityCompleteCS_FunctionAddress;

	private static int OnSetActivityPriorityCompleteCS_ParamsSize;

	private static bool OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid;

	private static int OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnGameActivityActivationCompleteCS_IsValid;

	private static IntPtr OnGameActivityActivationCompleteCS_FunctionAddress;

	private static int OnGameActivityActivationCompleteCS_ParamsSize;

	private static bool OnGameActivityActivationCompleteCS_sActivityId_IsValid;

	private static int OnGameActivityActivationCompleteCS_sActivityId_Offset;

	private static FFieldAddress OnGameActivityActivationCompleteCS_sActivityId_PropertyAddress;

	private static bool OnGameActivityActivationCompleteCS_sSessionStr_IsValid;

	private static int OnGameActivityActivationCompleteCS_sSessionStr_Offset;

	private static FFieldAddress OnGameActivityActivationCompleteCS_sSessionStr_PropertyAddress;

	private static bool OnSetActivityAvailabilityCompleteCS_IsValid;

	private static IntPtr OnSetActivityAvailabilityCompleteCS_FunctionAddress;

	private static int OnSetActivityAvailabilityCompleteCS_ParamsSize;

	private static bool OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid;

	private static int OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress;

	private static bool OnResetAllActiveActivitiesCompleteCS_IsValid;

	private static IntPtr OnResetAllActiveActivitiesCompleteCS_FunctionAddress;

	private static int OnResetAllActiveActivitiesCompleteCS_ParamsSize;

	private static bool OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid;

	private static int OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset;

	private static FFieldAddress OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress;

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

	public bool IsDoingActivity => CurActivity != 0;

	public int CurActivityId => CurActivity;

	public bool IsStartedByGameIntent => bStartedByGameIntent;

	public void OnAttach()
	{
	}

	public void SetCurActivityId(int ActivityId, string Reason)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"SetCurActivityId:{ActivityId} Reason:{Reason}");
		CurActivity = ActivityId;
	}

	public void OnInit()
	{
		Init();
		FCachedActivityIntentReceivedParamCS OutParamCS;
		bool cachedActivityIntentReceivedParam = UGSE_GameIntentFuncLib.GetCachedActivityIntentReceivedParam(out OutParamCS);
		if (cachedActivityIntentReceivedParam)
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("OutParamCS UserId:" + OutParamCS.UserId + " ActivityId:" + OutParamCS.ActivityId + " SessionId:" + OutParamCS.SessionId);
			CachedActivityIntentReceivedParamCS = OutParamCS;
			bStartedByGameIntent = true;
		}
		else
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"GetCachedActivityIntentReceivedParam Res:{cachedActivityIntentReceivedParam}");
		}
		GameActivityActivationCompleteCallBack = OnGameActivityActivationComplete;
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
		if (IsDoingActivity)
		{
			SysLogUtil.ONLINE_SUBSYSTEM.LogInfo($"OnShutdown And IsDoingActivity SetActivityAvailability {CurActivity} false");
			SetActivityAvailability(CurActivity.ToString(), bEnable: false);
		}
		GameActivityActivationCompleteCallBack = null;
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

	public static BGW_OnlineActivity Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineActivity>(WorldContext);
	}

	public bool GetCachedActivityIntentReceivedParamCS(out FCachedActivityIntentReceivedParamCS OutParam)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			OutParam = default(FCachedActivityIntentReceivedParamCS);
			return false;
		}
		OutParam = (bStartedByGameIntent ? CachedActivityIntentReceivedParamCS : default(FCachedActivityIntentReceivedParamCS));
		return bStartedByGameIntent;
	}

	public void StartActivity(string ActivityId, Del_OnStartActivityComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		StartActivityCallBack = CallBack;
		StartActivity(ActivityId);
	}

	public void EndActivity(string ActivityId, EOnlineActivityOutcomeType OutCome, Del_OnEndActivityComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		EndActivityCallBack = CallBack;
		EndActivity(ActivityId, OutCome);
	}

	public void SetActivityAvailability(string ActivityId, bool bEnable, Del_OnSetActivityAvailabilityComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		SetActivityAvailabilityCallBack = CallBack;
		SetActivityAvailability(ActivityId, bEnable);
	}

	public void SetActivityPriority(Dictionary<string, int> PriorityMap, Del_OnSetActivityPriorityComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		SetActivityPriorityCallBack = CallBack;
		SetActivityPriority(PriorityMap);
	}

	public void ResumeActivity(string ActivityId, List<string> InProgressTasks, List<string> CompletedTasks, Del_OnResumeActivityComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		ResumeActivityCallBack = CallBack;
		ResumeActivity(ActivityId, CompletedTasks, InProgressTasks);
	}

	public void ResetAllActiveActivities(Del_OnResetAllActiveActivitiesComplete CallBack)
	{
		if (BGW_OnlineSubsystem.OnlineSubsystemType != EBGWSubsystemType.PS5)
		{
			CallBack(bWasSuccessful: false);
			return;
		}
		ResetAllActiveActivitiesCallBack = CallBack;
		ResetAllActiveActivities();
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnStartActivityCompleteCS")]
	protected override void OnStartActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		StartActivityCallBack?.Invoke(bWasSuccessful);
		StartActivityCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnEndActivityCompleteCS")]
	protected override void OnEndActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		EndActivityCallBack?.Invoke(bWasSuccessful);
		EndActivityCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnGameActivityActivationCompleteCS")]
	protected override void OnGameActivityActivationCompleteCS_Implementation(string sActivityId, string sSessionStr)
	{
		GameActivityActivationCompleteCallBack?.Invoke(sActivityId, sSessionStr);
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityAvailabilityCompleteCS")]
	protected override void OnSetActivityAvailabilityCompleteCS_Implementation(bool bWasSuccessful)
	{
		SetActivityAvailabilityCallBack?.Invoke(bWasSuccessful);
		SetActivityAvailabilityCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityPriorityCompleteCS")]
	protected override void OnSetActivityPriorityCompleteCS_Implementation(bool bWasSuccessful)
	{
		SetActivityPriorityCallBack?.Invoke(bWasSuccessful);
		SetActivityPriorityCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnResumeActivityCompleteCS")]
	protected override void OnResumeActivityCompleteCS_Implementation(bool bWasSuccessful)
	{
		ResumeActivityCallBack?.Invoke(bWasSuccessful);
		ResumeActivityCallBack = null;
	}

	[USharpPath("/Script/b1-Managed.BGW_OnlineActivity:OnResetAllActiveActivitiesCompleteCS")]
	protected override void OnResetAllActiveActivitiesCompleteCS_Implementation(bool bWasSuccessful)
	{
		ResetAllActiveActivitiesCallBack?.Invoke(bWasSuccessful);
		ResetAllActiveActivitiesCallBack = null;
	}

	private bool IsSessionValid(string sSessionStr)
	{
		return sSessionStr != "InvalidSession";
	}

	private void OnGameActivityActivationComplete(string sActivityId, string sSessionStr)
	{
		SysLogUtil.ONLINE_SUBSYSTEM.LogInfo("OnGameActivityActivationComplete sActivityId : " + sActivityId + " sSessionStr : " + sSessionStr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnEndActivityCompleteCS")]
	private static void OnEndActivityCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnEndActivityCompleteCS_bWasSuccessful_Offset), 0, OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnEndActivityCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnStartActivityCompleteCS")]
	private static void OnStartActivityCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnStartActivityCompleteCS_bWasSuccessful_Offset), 0, OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnStartActivityCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnResumeActivityCompleteCS")]
	private static void OnResumeActivityCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnResumeActivityCompleteCS_bWasSuccessful_Offset), 0, OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnResumeActivityCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityPriorityCompleteCS")]
	private static void OnSetActivityPriorityCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnSetActivityPriorityCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnGameActivityActivationCompleteCS")]
	private static void OnGameActivityActivationCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		string sActivityId = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnGameActivityActivationCompleteCS_sActivityId_Offset));
		string sSessionStr = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnGameActivityActivationCompleteCS_sSessionStr_Offset));
		bGW_OnlineActivity.OnGameActivityActivationCompleteCS_Implementation(sActivityId, sSessionStr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityAvailabilityCompleteCS")]
	private static void OnSetActivityAvailabilityCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset), 0, OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnSetActivityAvailabilityCompleteCS_Implementation(bWasSuccessful);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_OnlineActivity:OnResetAllActiveActivitiesCompleteCS")]
	private static void OnResetAllActiveActivitiesCompleteCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_OnlineActivity bGW_OnlineActivity = GCHelper.Find<BGW_OnlineActivity>(obj);
		bool bWasSuccessful = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset), 0, OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress.Address);
		bGW_OnlineActivity.OnResetAllActiveActivitiesCompleteCS_Implementation(bWasSuccessful);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_OnlineActivity");
		OnEndActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEndActivityCompleteCS");
		OnEndActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndActivityCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnEndActivityCompleteCS_bWasSuccessful_PropertyAddress, OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEndActivityCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnEndActivityCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnEndActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnEndActivityCompleteCS_IsValid = OnEndActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnEndActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnEndActivityCompleteCS", OnEndActivityCompleteCS_IsValid);
		OnStartActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStartActivityCompleteCS");
		OnStartActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStartActivityCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnStartActivityCompleteCS_bWasSuccessful_PropertyAddress, OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartActivityCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnStartActivityCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnStartActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnStartActivityCompleteCS_IsValid = OnStartActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnStartActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnStartActivityCompleteCS", OnStartActivityCompleteCS_IsValid);
		OnResumeActivityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResumeActivityCompleteCS");
		OnResumeActivityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResumeActivityCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnResumeActivityCompleteCS_bWasSuccessful_PropertyAddress, OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResumeActivityCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResumeActivityCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnResumeActivityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnResumeActivityCompleteCS_IsValid = OnResumeActivityCompleteCS_FunctionAddress != IntPtr.Zero && OnResumeActivityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnResumeActivityCompleteCS", OnResumeActivityCompleteCS_IsValid);
		OnSetActivityPriorityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetActivityPriorityCompleteCS");
		OnSetActivityPriorityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetActivityPriorityCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetActivityPriorityCompleteCS_bWasSuccessful_PropertyAddress, OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityPriorityCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnSetActivityPriorityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetActivityPriorityCompleteCS_IsValid = OnSetActivityPriorityCompleteCS_FunctionAddress != IntPtr.Zero && OnSetActivityPriorityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityPriorityCompleteCS", OnSetActivityPriorityCompleteCS_IsValid);
		OnGameActivityActivationCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnGameActivityActivationCompleteCS");
		OnGameActivityActivationCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameActivityActivationCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnGameActivityActivationCompleteCS_sActivityId_PropertyAddress, OnGameActivityActivationCompleteCS_FunctionAddress, "sActivityId");
		OnGameActivityActivationCompleteCS_sActivityId_Offset = NativeReflection.GetPropertyOffset(OnGameActivityActivationCompleteCS_FunctionAddress, "sActivityId");
		OnGameActivityActivationCompleteCS_sActivityId_IsValid = NativeReflection.ValidatePropertyClass(OnGameActivityActivationCompleteCS_FunctionAddress, "sActivityId", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnGameActivityActivationCompleteCS_sSessionStr_PropertyAddress, OnGameActivityActivationCompleteCS_FunctionAddress, "sSessionStr");
		OnGameActivityActivationCompleteCS_sSessionStr_Offset = NativeReflection.GetPropertyOffset(OnGameActivityActivationCompleteCS_FunctionAddress, "sSessionStr");
		OnGameActivityActivationCompleteCS_sSessionStr_IsValid = NativeReflection.ValidatePropertyClass(OnGameActivityActivationCompleteCS_FunctionAddress, "sSessionStr", Classes.FStrProperty);
		OnGameActivityActivationCompleteCS_IsValid = OnGameActivityActivationCompleteCS_FunctionAddress != IntPtr.Zero && OnGameActivityActivationCompleteCS_sActivityId_IsValid && OnGameActivityActivationCompleteCS_sSessionStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnGameActivityActivationCompleteCS", OnGameActivityActivationCompleteCS_IsValid);
		OnSetActivityAvailabilityCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSetActivityAvailabilityCompleteCS");
		OnSetActivityAvailabilityCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetActivityAvailabilityCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSetActivityAvailabilityCompleteCS_bWasSuccessful_PropertyAddress, OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityAvailabilityCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful");
		OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnSetActivityAvailabilityCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnSetActivityAvailabilityCompleteCS_IsValid = OnSetActivityAvailabilityCompleteCS_FunctionAddress != IntPtr.Zero && OnSetActivityAvailabilityCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnSetActivityAvailabilityCompleteCS", OnSetActivityAvailabilityCompleteCS_IsValid);
		OnResetAllActiveActivitiesCompleteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnResetAllActiveActivitiesCompleteCS");
		OnResetAllActiveActivitiesCompleteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnResetAllActiveActivitiesCompleteCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_PropertyAddress, OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_Offset = NativeReflection.GetPropertyOffset(OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful");
		OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid = NativeReflection.ValidatePropertyClass(OnResetAllActiveActivitiesCompleteCS_FunctionAddress, "bWasSuccessful", Classes.FBoolProperty);
		OnResetAllActiveActivitiesCompleteCS_IsValid = OnResetAllActiveActivitiesCompleteCS_FunctionAddress != IntPtr.Zero && OnResetAllActiveActivitiesCompleteCS_bWasSuccessful_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_OnlineActivity:OnResetAllActiveActivitiesCompleteCS", OnResetAllActiveActivitiesCompleteCS_IsValid);
	}

	static BGW_OnlineActivity()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_OnlineActivity)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_OnlineActivity));
	}
}
