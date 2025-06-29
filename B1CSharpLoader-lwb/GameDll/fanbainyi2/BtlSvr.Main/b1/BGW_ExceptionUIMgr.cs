using System;
using System.Linq;
using System.Threading;
using AOT;
using b1.EventDelDefine;
using b1.UI;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ExceptionUIMgr")]
public class BGW_ExceptionUIMgr : GameInstanceSystemBaseUObj
{
	private enum EUIType
	{
		None,
		Tips,
		Panel
	}

	private TStrongObjectPtr<BUI_CommErrorTips> CommErrorTipsPtr;

	private const string CommErrorTipsPathRef = "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_CommErrorTips.BP_UI_CommErrorTips_C'";

	private TStrongObjectPtr<BUI_ExceptionPanel> ExceptionPanelPtr;

	private const string ExceptionPanelPathRef = "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_ExceptionPanel.BP_UI_ExceptionPanel_C'";

	private TStrongObjectPtr<BUI_ConnectInfoPanel> ConnectInfoPanelPtr;

	private const string ConnectInfoPanelPathRef = "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_ConnectInfoPanel.BP_UI_ConnectInfoPanel_C'";

	private static int Priority;

	private static bool sHasGameViewportCreated;

	private static UGameViewportClientDelegates.OnViewportCreatedHandler.Signature sViewportCreatedAction;

	private EUIType CacheUIType;

	private Exception CacheException;

	private int CacheErrorCode;

	private ECommonErrorType CacheCommonErrorType;

	private string CacheExtraMsg;

	private EUIType CurUIType;

	private static bool Get_IsValid;

	private static IntPtr Get_FunctionAddress;

	private static int Get_ParamsSize;

	private static bool Get_WorldCtx_IsValid;

	private static int Get_WorldCtx_Offset;

	private static bool Get_ReturnValue_IsValid;

	private static int Get_ReturnValue_Offset;

	private static bool OnCloseExceptionUI_IsValid;

	private static IntPtr OnCloseExceptionUI_FunctionAddress;

	private static int OnCloseExceptionUI_ParamsSize;

	public override bool bTickEnabled => true;

	private bool IsProdEnv => B1Global.GIsGameReleased;

	private bool IsSupportClose => DebugConfig.ExceptionShowBtn;

	private bool IsInitDebugMgrDone => BGWGameInstanceCS.Get(this).InitDebugMgrDone;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGW_ExceptionUIMgr:Get")]
	public static BGW_ExceptionUIMgr Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_ExceptionUIMgr>(WorldCtx);
	}

	public override void OnInit()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		bGW_EventCollection.Evt_ShowExceptionUI = (BGW_EventCollection.Del_Void_Exception)Delegate.Combine(bGW_EventCollection.Evt_ShowExceptionUI, new BGW_EventCollection.Del_Void_Exception(OnShowExceptionUI));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
		bGW_EventCollection2.Evt_CloseExceptionUI = (b1.EventDelDefine.Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_CloseExceptionUI, new b1.EventDelDefine.Del_Void(OnCloseExceptionUI));
		sHasGameViewportCreated = false;
		CacheUIType = EUIType.None;
		CurUIType = EUIType.None;
		UGameViewportClientDelegates.OnViewportCreated.Bind(sOnViewportCreated);
		sViewportCreatedAction = (UGameViewportClientDelegates.OnViewportCreatedHandler.Signature)Delegate.Combine(sViewportCreatedAction, new UGameViewportClientDelegates.OnViewportCreatedHandler.Signature(OnViewportCreated));
		BUI_CommErrorTips bUI_CommErrorTips = UGSE_UMGFuncLib.CreateUserWidget(this, "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_CommErrorTips.BP_UI_CommErrorTips_C'") as BUI_CommErrorTips;
		if (bUI_CommErrorTips != null)
		{
			CommErrorTipsPtr = new TStrongObjectPtr<BUI_CommErrorTips>(bUI_CommErrorTips);
			BUI_ExceptionPanel bUI_ExceptionPanel = UGSE_UMGFuncLib.CreateUserWidget(this, "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_ExceptionPanel.BP_UI_ExceptionPanel_C'") as BUI_ExceptionPanel;
			if (bUI_ExceptionPanel != null)
			{
				ExceptionPanelPtr = new TStrongObjectPtr<BUI_ExceptionPanel>(bUI_ExceptionPanel);
				if (DebugConfig.OpenNetConnectDebugUI)
				{
					BUI_ConnectInfoPanel bUI_ConnectInfoPanel = UGSE_UMGFuncLib.CreateUserWidget(this, "WidgetBlueprint'/Game/00Main/UI/BluePrints/Debug/BP_UI_ConnectInfoPanel.BP_UI_ConnectInfoPanel_C'") as BUI_ConnectInfoPanel;
					if (bUI_ConnectInfoPanel != null)
					{
						ConnectInfoPanelPtr = new TStrongObjectPtr<BUI_ConnectInfoPanel>(bUI_ConnectInfoPanel);
						UGSE_UMGFuncLib.AddUserWidgetAsSlateToViewport(bUI_ConnectInfoPanel);
					}
				}
				CacheException = null;
				InitUSharpExceptionHandler();
				return;
			}
			throw new Exception("Create ExceptionPanel fail!!!");
		}
		throw new Exception("Create CommErrorTips fail!!!");
	}

	private void InitUSharpExceptionHandler()
	{
		foreach (EUSharpExceptionType item in Enum.GetValues(typeof(EUSharpExceptionType)).Cast<EUSharpExceptionType>())
		{
			USharpExceptionHandler.AddHandleFunc(HandleUSharpInvokeFunctionExcpetion, item, IsMustInGameThread: true);
		}
	}

	private void UnInitUSharpExceptionHandler()
	{
		foreach (EUSharpExceptionType item in Enum.GetValues(typeof(EUSharpExceptionType)).Cast<EUSharpExceptionType>())
		{
			USharpExceptionHandler.RemoveHandleFunc(HandleUSharpInvokeFunctionExcpetion, item);
		}
	}

	private void HandleUSharpInvokeFunctionExcpetion(Exception e)
	{
		BGWGameInstanceCS.Get(this).CloseLoadingScreen();
		if (DebugConfig.ThrowException)
		{
			Thread.Sleep(DebugConfig.WaitMSToThrowException);
			throw e;
		}
		BGW_EventCollection.Get(this).Evt_ShowExceptionUI(e);
	}

	private void OnViewportCreated()
	{
		if (CanShowCacheException())
		{
			ShowCacheException();
		}
	}

	private void ShowCacheException()
	{
		CurUIType = CacheUIType;
		CacheUIType = EUIType.None;
		if (CacheException != null)
		{
			ShowExceptionUIInternal(CacheException);
		}
		else
		{
			ForceShowCommonErrorTips(CacheErrorCode, CacheCommonErrorType, CacheExtraMsg);
		}
		CacheException = null;
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void sOnViewportCreated()
	{
		sHasGameViewportCreated = true;
		sViewportCreatedAction();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ExceptionUIMgr:OnCloseExceptionUI")]
	public void OnCloseExceptionUI()
	{
		switch (CurUIType)
		{
		case EUIType.Tips:
			UGSE_UMGFuncLib.RemoveUserWidgetAsSlateFromViewport(CommErrorTipsPtr.Get());
			BGW_EventCollection.Get(this).Evt_BlockWidgetNavigation(bBlock: false, EBlockNavReason.CommonErrorTips);
			BGW_EventCollection.Get(this).Evt_BlockAllInput(P1: false);
			CurUIType = EUIType.None;
			break;
		case EUIType.Panel:
			if (IsSupportClose)
			{
				HandleFatalExceptionUIClose();
				UGSE_UMGFuncLib.RemoveUserWidgetAsSlateFromViewport(ExceptionPanelPtr.Get());
				BGW_EventCollection.Get(this).Evt_SetSuperUserInputMode(IsRequest: false, EGSInputModeChangeReason.ExceptionPanel);
				BGW_EventCollection.Get(this).Evt_BlockWidgetNavigation(bBlock: false, EBlockNavReason.CommonErrorTips);
				BGW_EventCollection.Get(this).Evt_BlockAllInput(P1: false);
			}
			break;
		case EUIType.None:
			break;
		}
	}

	private bool CanShowExceptionUI()
	{
		if (!FThreading.IsInGameThread())
		{
			return false;
		}
		if (sHasGameViewportCreated && CurUIType == EUIType.None && CacheUIType == EUIType.None)
		{
			return IsInitDebugMgrDone;
		}
		return false;
	}

	private bool CanCacheException()
	{
		if ((!sHasGameViewportCreated || !FThreading.IsInGameThread()) && CurUIType == EUIType.None && CacheUIType == EUIType.None)
		{
			return IsInitDebugMgrDone;
		}
		return false;
	}

	private bool CanShowCacheException()
	{
		if (!FThreading.IsInGameThread())
		{
			return false;
		}
		if (sHasGameViewportCreated && CurUIType == EUIType.None && CacheUIType != EUIType.None)
		{
			return IsInitDebugMgrDone;
		}
		return false;
	}

	public void OnShowExceptionUI(Exception Ex)
	{
		try
		{
			if (!IsInitDebugMgrDone)
			{
				_ = $"{Ex.GetType().Name}: {Ex}\n\n{Ex.StackTrace}";
				if (IsProdEnv)
				{
				}
			}
			else if (CanShowExceptionUI())
			{
				DetermineUIType(ref CurUIType, Ex);
				ShowExceptionUIInternal(Ex);
			}
			else if (CanCacheException())
			{
				DetermineUIType(ref CacheUIType, Ex);
				CacheException = Ex;
			}
		}
		catch (Exception)
		{
			if (IsProdEnv)
			{
				throw Ex;
			}
		}
	}

	public void ForceShowCommonErrorTips(int ErrorCode, ECommonErrorType CommonErrorType, string ExtraMsg)
	{
		if (CanShowExceptionUI())
		{
			CurUIType = EUIType.Tips;
			UGSE_UMGFuncLib.AddUserWidgetAsSlateToViewport(CommErrorTipsPtr.Get(), 1000);
			BGW_EventCollection.Get(this).Evt_BlockWidgetNavigation(bBlock: true, EBlockNavReason.CommonErrorTips);
			BGW_EventCollection.Get(this).Evt_BlockAllInput(P1: true);
			CommErrorTipsPtr.Get().SetErrorTipsText(ErrorCode, CommonErrorType, ExtraMsg);
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			bGW_EventCollection.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Combine(bGW_EventCollection.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDownEvent));
		}
		else if (CanCacheException())
		{
			CacheUIType = EUIType.Tips;
			CacheErrorCode = ErrorCode;
			CacheCommonErrorType = CommonErrorType;
			CacheExtraMsg = ExtraMsg;
		}
	}

	private void DetermineUIType(ref EUIType UIType, Exception Ex)
	{
		if (Ex is FSMException ex)
		{
			switch (ex.Level)
			{
			case ELoadingExceptionLevel.Normal:
				UIType = EUIType.Tips;
				break;
			case ELoadingExceptionLevel.Fatal:
				UIType = EUIType.Panel;
				break;
			case ELoadingExceptionLevel.Ignorable:
				UIType = EUIType.None;
				break;
			}
		}
		else
		{
			UIType = EUIType.Panel;
		}
	}

	private void ShowExceptionUIInternal(Exception Ex)
	{
		if (sHasGameViewportCreated && Ex != null)
		{
			switch (CurUIType)
			{
			case EUIType.None:
				BGW_LogUtil.LogError(Ex.ToString());
				break;
			case EUIType.Tips:
			{
				UGSE_UMGFuncLib.AddUserWidgetAsSlateToViewport(CommErrorTipsPtr.Get(), Priority);
				CommErrorTipsPtr.Get().SetErrorTipsText(Ex as FSMException);
				BGW_EventCollection.Get(this).Evt_BlockWidgetNavigation(bBlock: true, EBlockNavReason.CommonErrorTips);
				BGW_EventCollection.Get(this).Evt_BlockAllInput(P1: true);
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(this);
				bGW_EventCollection2.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Combine(bGW_EventCollection2.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDownEvent));
				break;
			}
			case EUIType.Panel:
			{
				HandleFatalExceptionUIOpen();
				UGSE_UMGFuncLib.AddUserWidgetAsSlateToViewport(ExceptionPanelPtr.Get(), Priority);
				ExceptionPanelPtr.Get().SetExceptionText(Ex.ToString());
				BGW_EventCollection.Get(this).Evt_SetSuperUserInputMode(IsRequest: true, EGSInputModeChangeReason.ExceptionPanel);
				BGW_EventCollection.Get(this).Evt_BlockWidgetNavigation(bBlock: true, EBlockNavReason.CommonErrorTips);
				BGW_EventCollection.Get(this).Evt_BlockAllInput(P1: true);
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
				bGW_EventCollection.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Combine(bGW_EventCollection.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDownEvent));
				break;
			}
			}
		}
	}

	private void HandleFatalExceptionUIOpen()
	{
		if (!UGSE_EngineFuncLib.HasLaunchOption("AutoTest"))
		{
			BGW_EventCollection.Get(this)?.Evt_SetGameAllPause(P1: true);
		}
	}

	private void HandleFatalExceptionUIClose()
	{
		if (!UGSE_EngineFuncLib.HasLaunchOption("AutoTest") && IsProdEnv)
		{
			UGSE_EngineFuncLib.RequestExit(Force: true);
		}
	}

	private void OnKeyDownEvent(FKeyEvent KeyEvent)
	{
		FKey inputKey = UGSE_EngineFuncLib.GetInputKey(KeyEvent);
		if (inputKey.Equals(EKeys.Gamepad_FaceButton_Bottom) || inputKey.Equals(EKeys.E))
		{
			if (CurUIType == EUIType.Tips)
			{
				OnCloseExceptionUI();
			}
			if (CurUIType == EUIType.Panel && IsProdEnv)
			{
				OnCloseExceptionUI();
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ConnectInfoPanelPtr != null && ConnectInfoPanelPtr.IsValid())
		{
			ConnectInfoPanelPtr.Get().Tick(DeltaTime);
		}
		if (CacheException != null && CanShowCacheException())
		{
			ShowCacheException();
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		UnInitUSharpExceptionHandler();
		sViewportCreatedAction = (UGameViewportClientDelegates.OnViewportCreatedHandler.Signature)Delegate.Remove(sViewportCreatedAction, new UGameViewportClientDelegates.OnViewportCreatedHandler.Signature(OnViewportCreated));
		UGameViewportClientDelegates.OnViewportCreated.Unbind(sOnViewportCreated);
		sHasGameViewportCreated = false;
		if (CurUIType != EUIType.None)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			bGW_EventCollection.Evt_OnKeyDownEvent = (Del_Void_FKeyEvent)Delegate.Remove(bGW_EventCollection.Evt_OnKeyDownEvent, new Del_Void_FKeyEvent(OnKeyDownEvent));
		}
	}

	static BGW_ExceptionUIMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ExceptionUIMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ExceptionUIMgr));
		Priority = 100;
		sViewportCreatedAction = delegate
		{
		};
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ExceptionUIMgr:Get")]
	private static void Get__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldCtx = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, Get_WorldCtx_Offset));
		BGW_ExceptionUIMgr value = Get(worldCtx);
		UObjectMarshaler<BGW_ExceptionUIMgr>.ToNative(IntPtr.Add(buffer, Get_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ExceptionUIMgr:OnCloseExceptionUI")]
	private static void OnCloseExceptionUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGW_ExceptionUIMgr bGW_ExceptionUIMgr = GCHelper.Find<BGW_ExceptionUIMgr>(obj);
		bGW_ExceptionUIMgr.OnCloseExceptionUI();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ExceptionUIMgr");
		Get_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Get");
		Get_ParamsSize = NativeReflection.GetFunctionParamsSize(Get_FunctionAddress);
		Get_WorldCtx_Offset = NativeReflection.GetPropertyOffset(Get_FunctionAddress, "WorldCtx");
		Get_WorldCtx_IsValid = NativeReflection.ValidatePropertyClass(Get_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		Get_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Get_FunctionAddress, "ReturnValue");
		Get_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Get_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Get_IsValid = Get_FunctionAddress != IntPtr.Zero && Get_WorldCtx_IsValid && Get_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ExceptionUIMgr:Get", Get_IsValid);
		OnCloseExceptionUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCloseExceptionUI");
		OnCloseExceptionUI_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCloseExceptionUI_FunctionAddress);
		OnCloseExceptionUI_IsValid = OnCloseExceptionUI_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ExceptionUIMgr:OnCloseExceptionUI", OnCloseExceptionUI_IsValid);
	}
}
