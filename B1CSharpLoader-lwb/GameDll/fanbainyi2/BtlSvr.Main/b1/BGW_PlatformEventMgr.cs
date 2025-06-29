using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr")]
internal class BGW_PlatformEventMgr : UBGWPlatformEventMgr, IGameInstObj
{
	public delegate void Del_OnApplicationLifeCycleChange();

	public delegate void Del_OnNetworkInitializedChange(bool bIsNetworkInitialized);

	public delegate void Del_OnUserLoginChange(bool bIsSignIn, int PlatformUserId, int UserIndex);

	public int _StatId = -1;

	public Del_OnApplicationLifeCycleChange OnApplicationInitHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationPreExitHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationExitHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationDeactivateHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationReactivatedHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationSuspendHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationResumeHandler;

	public Del_OnApplicationLifeCycleChange OnApplicationTerminateHandler;

	public Del_OnNetworkInitializedChange OnNetworkInitializedChangeHandler;

	public Del_OnUserLoginChange OnUserLoginChangeHandler;

	private static bool OnApplicationInitCS_IsValid;

	private static IntPtr OnApplicationInitCS_FunctionAddress;

	private static int OnApplicationInitCS_ParamsSize;

	private static bool OnApplicationExitCS_IsValid;

	private static IntPtr OnApplicationExitCS_FunctionAddress;

	private static int OnApplicationExitCS_ParamsSize;

	private static bool OnUserLoginChangeCS_IsValid;

	private static IntPtr OnUserLoginChangeCS_FunctionAddress;

	private static int OnUserLoginChangeCS_ParamsSize;

	private static bool OnUserLoginChangeCS_bIsSignIn_IsValid;

	private static int OnUserLoginChangeCS_bIsSignIn_Offset;

	private static FFieldAddress OnUserLoginChangeCS_bIsSignIn_PropertyAddress;

	private static bool OnUserLoginChangeCS_PlatformUserId_IsValid;

	private static int OnUserLoginChangeCS_PlatformUserId_Offset;

	private static bool OnUserLoginChangeCS_UserIndex_IsValid;

	private static int OnUserLoginChangeCS_UserIndex_Offset;

	private static bool OnApplicationResumeCS_IsValid;

	private static IntPtr OnApplicationResumeCS_FunctionAddress;

	private static int OnApplicationResumeCS_ParamsSize;

	private static bool OnApplicationPreExitCS_IsValid;

	private static IntPtr OnApplicationPreExitCS_FunctionAddress;

	private static int OnApplicationPreExitCS_ParamsSize;

	private static bool OnApplicationSuspendCS_IsValid;

	private static IntPtr OnApplicationSuspendCS_FunctionAddress;

	private static int OnApplicationSuspendCS_ParamsSize;

	private static bool OnApplicationTerminateCS_IsValid;

	private static IntPtr OnApplicationTerminateCS_FunctionAddress;

	private static int OnApplicationTerminateCS_ParamsSize;

	private static bool OnApplicationDeactivateCS_IsValid;

	private static IntPtr OnApplicationDeactivateCS_FunctionAddress;

	private static int OnApplicationDeactivateCS_ParamsSize;

	private static bool OnApplicationReactivatedCS_IsValid;

	private static IntPtr OnApplicationReactivatedCS_FunctionAddress;

	private static int OnApplicationReactivatedCS_ParamsSize;

	private static bool OnNetworkInitializedChangeCS_IsValid;

	private static IntPtr OnNetworkInitializedChangeCS_FunctionAddress;

	private static int OnNetworkInitializedChangeCS_ParamsSize;

	private static bool OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid;

	private static int OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset;

	private static FFieldAddress OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress;

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

	public static BGW_OnlineSession Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_OnlineSession>(WorldContext);
	}

	public bool CanTick()
	{
		return false;
	}

	public int GetTickGroupMask()
	{
		return 0;
	}

	public void OnAfterInit()
	{
	}

	public void OnAttach()
	{
	}

	public void OnInit()
	{
		Init();
	}

	public void OnPostLoadMap()
	{
	}

	public void OnShutdown()
	{
		Destroy();
	}

	public void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationInitCS")]
	protected override void OnApplicationInitCS_Implementation()
	{
		OnApplicationInitHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationPreExitCS")]
	protected override void OnApplicationPreExitCS_Implementation()
	{
		OnApplicationPreExitHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationExitCS")]
	protected override void OnApplicationExitCS_Implementation()
	{
		OnApplicationExitHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationDeactivateCS")]
	protected override void OnApplicationDeactivateCS_Implementation()
	{
		OnApplicationDeactivateHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationReactivatedCS")]
	protected override void OnApplicationReactivatedCS_Implementation()
	{
		OnApplicationReactivatedHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationSuspendCS")]
	protected override void OnApplicationSuspendCS_Implementation()
	{
		OnApplicationSuspendHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationResumeCS")]
	protected override void OnApplicationResumeCS_Implementation()
	{
		OnApplicationResumeHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationTerminateCS")]
	protected override void OnApplicationTerminateCS_Implementation()
	{
		OnApplicationTerminateHandler?.Invoke();
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnNetworkInitializedChangeCS")]
	protected override void OnNetworkInitializedChangeCS_Implementation(bool bIsNetworkInitialized)
	{
		OnNetworkInitializedChangeHandler?.Invoke(bIsNetworkInitialized);
	}

	[USharpPath("/Script/b1-Managed.BGW_PlatformEventMgr:OnUserLoginChangeCS")]
	protected override void OnUserLoginChangeCS_Implementation(bool bIsSignIn, int PlatformUserId, int UserIndex)
	{
		OnUserLoginChangeHandler?.Invoke(bIsSignIn, PlatformUserId, UserIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationInitCS")]
	private static void OnApplicationInitCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationInitCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationExitCS")]
	private static void OnApplicationExitCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationExitCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnUserLoginChangeCS")]
	private static void OnUserLoginChangeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bool bIsSignIn = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnUserLoginChangeCS_bIsSignIn_Offset), 0, OnUserLoginChangeCS_bIsSignIn_PropertyAddress.Address);
		int platformUserId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnUserLoginChangeCS_PlatformUserId_Offset));
		int userIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnUserLoginChangeCS_UserIndex_Offset));
		bGW_PlatformEventMgr.OnUserLoginChangeCS_Implementation(bIsSignIn, platformUserId, userIndex);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationResumeCS")]
	private static void OnApplicationResumeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationResumeCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationPreExitCS")]
	private static void OnApplicationPreExitCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationPreExitCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationSuspendCS")]
	private static void OnApplicationSuspendCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationSuspendCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationTerminateCS")]
	private static void OnApplicationTerminateCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationTerminateCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationDeactivateCS")]
	private static void OnApplicationDeactivateCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationDeactivateCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationReactivatedCS")]
	private static void OnApplicationReactivatedCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bGW_PlatformEventMgr.OnApplicationReactivatedCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlatformEventMgr:OnNetworkInitializedChangeCS")]
	private static void OnNetworkInitializedChangeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlatformEventMgr bGW_PlatformEventMgr = GCHelper.Find<b1.BGW_PlatformEventMgr>(obj);
		bool bIsNetworkInitialized = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset), 0, OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress.Address);
		bGW_PlatformEventMgr.OnNetworkInitializedChangeCS_Implementation(bIsNetworkInitialized);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_PlatformEventMgr");
		OnApplicationInitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationInitCS");
		OnApplicationInitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationInitCS_FunctionAddress);
		OnApplicationInitCS_IsValid = OnApplicationInitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationInitCS", OnApplicationInitCS_IsValid);
		OnApplicationExitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationExitCS");
		OnApplicationExitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationExitCS_FunctionAddress);
		OnApplicationExitCS_IsValid = OnApplicationExitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationExitCS", OnApplicationExitCS_IsValid);
		OnUserLoginChangeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnUserLoginChangeCS");
		OnUserLoginChangeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserLoginChangeCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnUserLoginChangeCS_bIsSignIn_PropertyAddress, OnUserLoginChangeCS_FunctionAddress, "bIsSignIn");
		OnUserLoginChangeCS_bIsSignIn_Offset = NativeReflection.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "bIsSignIn");
		OnUserLoginChangeCS_bIsSignIn_IsValid = NativeReflection.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "bIsSignIn", Classes.FBoolProperty);
		OnUserLoginChangeCS_PlatformUserId_Offset = NativeReflection.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "PlatformUserId");
		OnUserLoginChangeCS_PlatformUserId_IsValid = NativeReflection.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "PlatformUserId", Classes.FIntProperty);
		OnUserLoginChangeCS_UserIndex_Offset = NativeReflection.GetPropertyOffset(OnUserLoginChangeCS_FunctionAddress, "UserIndex");
		OnUserLoginChangeCS_UserIndex_IsValid = NativeReflection.ValidatePropertyClass(OnUserLoginChangeCS_FunctionAddress, "UserIndex", Classes.FIntProperty);
		OnUserLoginChangeCS_IsValid = OnUserLoginChangeCS_FunctionAddress != IntPtr.Zero && OnUserLoginChangeCS_bIsSignIn_IsValid && OnUserLoginChangeCS_PlatformUserId_IsValid && OnUserLoginChangeCS_UserIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnUserLoginChangeCS", OnUserLoginChangeCS_IsValid);
		OnApplicationResumeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationResumeCS");
		OnApplicationResumeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationResumeCS_FunctionAddress);
		OnApplicationResumeCS_IsValid = OnApplicationResumeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationResumeCS", OnApplicationResumeCS_IsValid);
		OnApplicationPreExitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationPreExitCS");
		OnApplicationPreExitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationPreExitCS_FunctionAddress);
		OnApplicationPreExitCS_IsValid = OnApplicationPreExitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationPreExitCS", OnApplicationPreExitCS_IsValid);
		OnApplicationSuspendCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationSuspendCS");
		OnApplicationSuspendCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationSuspendCS_FunctionAddress);
		OnApplicationSuspendCS_IsValid = OnApplicationSuspendCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationSuspendCS", OnApplicationSuspendCS_IsValid);
		OnApplicationTerminateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationTerminateCS");
		OnApplicationTerminateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationTerminateCS_FunctionAddress);
		OnApplicationTerminateCS_IsValid = OnApplicationTerminateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationTerminateCS", OnApplicationTerminateCS_IsValid);
		OnApplicationDeactivateCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationDeactivateCS");
		OnApplicationDeactivateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationDeactivateCS_FunctionAddress);
		OnApplicationDeactivateCS_IsValid = OnApplicationDeactivateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationDeactivateCS", OnApplicationDeactivateCS_IsValid);
		OnApplicationReactivatedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApplicationReactivatedCS");
		OnApplicationReactivatedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplicationReactivatedCS_FunctionAddress);
		OnApplicationReactivatedCS_IsValid = OnApplicationReactivatedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnApplicationReactivatedCS", OnApplicationReactivatedCS_IsValid);
		OnNetworkInitializedChangeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNetworkInitializedChangeCS");
		OnNetworkInitializedChangeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNetworkInitializedChangeCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnNetworkInitializedChangeCS_bIsNetworkInitialized_PropertyAddress, OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized");
		OnNetworkInitializedChangeCS_bIsNetworkInitialized_Offset = NativeReflection.GetPropertyOffset(OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized");
		OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid = NativeReflection.ValidatePropertyClass(OnNetworkInitializedChangeCS_FunctionAddress, "bIsNetworkInitialized", Classes.FBoolProperty);
		OnNetworkInitializedChangeCS_IsValid = OnNetworkInitializedChangeCS_FunctionAddress != IntPtr.Zero && OnNetworkInitializedChangeCS_bIsNetworkInitialized_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlatformEventMgr:OnNetworkInitializedChangeCS", OnNetworkInitializedChangeCS_IsValid);
	}

	static BGW_PlatformEventMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW_PlatformEventMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW_PlatformEventMgr));
	}
}
