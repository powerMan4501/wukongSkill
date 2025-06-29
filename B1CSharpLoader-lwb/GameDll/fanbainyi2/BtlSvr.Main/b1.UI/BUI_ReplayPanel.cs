using System;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ReplayPanel")]
public class BUI_ReplayPanel : BUI_Widget
{
	private UTextBlock CurTimeText;

	private UTextBlock TotalTimeText;

	private USlider SliderBar;

	private UProgressBar ProgressBar;

	private UTextBlock DemoPlayTimeDilationText;

	private UButton BackButton;

	private UButton ForwardButton;

	private UButton StopButton;

	private UButton PlayOrPauseButton;

	private UImage PlayOrPauseImage;

	private const string PauseTexturePath = "Texture2D'/Game/3rd/ShepherdTest/ReplayIcon/pause.pause'";

	private const string PlayTexturePath = "Texture2D'/Game/3rd/ShepherdTest/ReplayIcon/play.play'";

	private const int TimeStep = 5;

	private const float SpeedStep = 0.1f;

	private const float QucikSpeedStep = 0.5f;

	private const int DistanceSpeed = 200;

	private const float DefaultTimeDilation = 1f;

	private UTexture2D PauseTexture;

	private UTexture2D PlayTexture;

	private bool IsMouseCapture;

	private bool IsPause;

	private static bool OnMouseCaptureEnd_IsValid;

	private static IntPtr OnMouseCaptureEnd_FunctionAddress;

	private static int OnMouseCaptureEnd_ParamsSize;

	private static bool OnStopButtonClicked_IsValid;

	private static IntPtr OnStopButtonClicked_FunctionAddress;

	private static int OnStopButtonClicked_ParamsSize;

	private static bool OnBackButtonClicked_IsValid;

	private static IntPtr OnBackButtonClicked_FunctionAddress;

	private static int OnBackButtonClicked_ParamsSize;

	private static bool OnMouseCaptureBegin_IsValid;

	private static IntPtr OnMouseCaptureBegin_FunctionAddress;

	private static int OnMouseCaptureBegin_ParamsSize;

	private static bool OnSliderValueChanged_IsValid;

	private static IntPtr OnSliderValueChanged_FunctionAddress;

	private static int OnSliderValueChanged_ParamsSize;

	private static bool OnSliderValueChanged_Value_IsValid;

	private static int OnSliderValueChanged_Value_Offset;

	private static bool OnForwardButtonClicked_IsValid;

	private static IntPtr OnForwardButtonClicked_FunctionAddress;

	private static int OnForwardButtonClicked_ParamsSize;

	private static bool OnPlayOrPauseButtonClicked_IsValid;

	private static IntPtr OnPlayOrPauseButtonClicked_FunctionAddress;

	private static int OnPlayOrPauseButtonClicked_ParamsSize;

	private BGW_ReplaySystemMgr ReplaySystemMgr => BGW_ReplaySystemMgr.Get(this);

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		CurTimeText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CurTimeText")) as UTextBlock;
		TotalTimeText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TotalTimeText")) as UTextBlock;
		SliderBar = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SliderBar")) as USlider;
		ProgressBar = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ProgressBar")) as UProgressBar;
		DemoPlayTimeDilationText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DemoPlayTimeDilation")) as UTextBlock;
		BackButton = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BackButton")) as UButton;
		ForwardButton = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ForwardButton")) as UButton;
		StopButton = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("StopButton")) as UButton;
		PlayOrPauseButton = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PlayOrPauseButton")) as UButton;
		PlayOrPauseImage = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PlayOrPauseImage")) as UImage;
		SliderBar?.OnMouseCaptureBegin.Bind(this, new FName("OnMouseCaptureBegin"));
		SliderBar?.OnMouseCaptureEnd.Bind(this, new FName("OnMouseCaptureEnd"));
		SliderBar?.OnValueChanged.Bind(this, new FName("OnSliderValueChanged"));
		PlayOrPauseButton?.OnClicked.Bind(this, new FName("OnPlayOrPauseButtonClicked"));
		BackButton?.OnClicked.Bind(this, new FName("OnBackButtonClicked"));
		ForwardButton?.OnClicked.Bind(this, new FName("OnForwardButtonClicked"));
		StopButton?.OnClicked.Bind(this, new FName("OnStopButtonClicked"));
		PauseTexture = BGW_PreloadAssetMgr.Get(this).RequestSyncLoadForUIResource<UTexture2D>("Texture2D'/Game/3rd/ShepherdTest/ReplayIcon/pause.pause'");
		PlayTexture = BGW_PreloadAssetMgr.Get(this).RequestSyncLoadForUIResource<UTexture2D>("Texture2D'/Game/3rd/ShepherdTest/ReplayIcon/play.play'");
		IsMouseCapture = false;
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SwitchTargetFree", ETriggerEvent.Started, delegate
		{
			SetViewTargetPlayer(0);
		});
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SwitchTargetOne", ETriggerEvent.Started, delegate
		{
			SetViewTargetPlayer(1);
		});
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SwitchTargetTwo", ETriggerEvent.Started, delegate
		{
			SetViewTargetPlayer(2);
		});
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SwitchTargetThree", ETriggerEvent.Started, delegate
		{
			SetViewTargetPlayer(3);
		});
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SwitchTargetFour", ETriggerEvent.Started, delegate
		{
			SetViewTargetPlayer(4);
		});
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SpeedDown", ETriggerEvent.Started, OnInputSpeedDown);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SpeedUp", ETriggerEvent.Started, OnInputSpeedUp);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_QuickSpeedDown", ETriggerEvent.Started, OnInputQuickSpeedDown);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_QuickSpeedUp", ETriggerEvent.Started, OnInputQuickSpeedUp);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_SpeedReset", ETriggerEvent.Started, OnInputSpeedReset);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_Pause", ETriggerEvent.Started, OnInputPauseReplay);
		BGW_EnhancedInputMgrV2.Get(this).BindReplayAction("IA_MouseWheel", ETriggerEvent.Started, OnInputMouseWheel);
		BGW_EventCollection.Get(this).Evt_SetInputMode(EGSInputMode.Replay, EGSInputModeChangeReason.Replay);
		IsPause = true;
		SetViewTargetPlayer(1);
	}

	public void SetViewTargetPlayer(int Idx)
	{
		ReplaySystemMgr.SetViewTargetPlayer(Idx);
	}

	private void OnInputMouseWheel(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetCameraToPlayerDistance(ReplaySystemMgr.GetCameraToPlayerDistance() + Value.GetAxis1D() * 200f);
	}

	private void OnInputPauseReplay(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		SetReplayPause(!ReplaySystemMgr.IsReplayPause());
	}

	private void OnInputSpeedDown(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetDemoPlayTimeDilation(ReplaySystemMgr.GetDemoPlayTimeDilation() - 0.1f);
		UpdateSpeedText();
	}

	private void OnInputSpeedUp(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetDemoPlayTimeDilation(ReplaySystemMgr.GetDemoPlayTimeDilation() + 0.1f);
		UpdateSpeedText();
	}

	private void OnInputQuickSpeedDown(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetDemoPlayTimeDilation(ReplaySystemMgr.GetDemoPlayTimeDilation() - 0.5f);
		UpdateSpeedText();
	}

	private void OnInputQuickSpeedUp(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetDemoPlayTimeDilation(ReplaySystemMgr.GetDemoPlayTimeDilation() + 0.5f);
		UpdateSpeedText();
	}

	private void OnInputSpeedReset(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		ReplaySystemMgr.SetDemoPlayTimeDilation(1f);
		UpdateSpeedText();
	}

	private void UpdateSpeedText()
	{
		DemoPlayTimeDilationText.SetText(FText.FromString($"播放速度: {ReplaySystemMgr.GetDemoPlayTimeDilation():f2} 倍"));
		if (ReplaySystemMgr.GetDemoPlayTimeDilation() != 1f)
		{
			DemoPlayTimeDilationText.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			DemoPlayTimeDilationText.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureBegin")]
	private void OnMouseCaptureBegin()
	{
		IsMouseCapture = true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureEnd")]
	private void OnMouseCaptureEnd()
	{
		IsMouseCapture = false;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnSliderValueChanged")]
	private void OnSliderValueChanged(float Value)
	{
		if (IsMouseCapture)
		{
			float value = SliderBar.GetValue();
			if (ReplaySystemMgr.IsReplayPause())
			{
				BGW_ReplaySystemMgr.Get(this).PauseReplay(bPause: false);
				DelaySetIsPauseGame(bPause: true);
			}
			ReplaySystemMgr.SetDemoCurrentTime(value);
			BGW_LogUtil.LogError($"OnSliderValueChanged: {value}");
			ProgressBar.SetPercent(ReplaySystemMgr.GetDemoCurrentTime() / ReplaySystemMgr.GetDemoTotalTime() - 0.004f);
		}
	}

	private void DelaySetIsPauseGame(bool bPause)
	{
		SetReplayPause(bPause, Force: false);
	}

	private void SetReplayPause(bool bPause, bool Force = true)
	{
		if (IsPause != bPause)
		{
			IsPause = bPause;
			if (Force)
			{
				UpdatePause();
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnPlayOrPauseButtonClicked")]
	private void OnPlayOrPauseButtonClicked()
	{
		SetReplayPause(!ReplaySystemMgr.IsReplayPause());
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnBackButtonClicked")]
	private void OnBackButtonClicked()
	{
		ReplaySystemMgr.SetDemoCurrentTime(ReplaySystemMgr.GetDemoCurrentTime() - 5f);
		if (ReplaySystemMgr.IsReplayPause())
		{
			BGW_ReplaySystemMgr.Get(this).PauseReplay(bPause: false);
			DelaySetIsPauseGame(bPause: true);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnForwardButtonClicked")]
	private void OnForwardButtonClicked()
	{
		ReplaySystemMgr.SetDemoCurrentTime(ReplaySystemMgr.GetDemoCurrentTime() + 5f);
		if (ReplaySystemMgr.IsReplayPause())
		{
			BGW_ReplaySystemMgr.Get(this).PauseReplay(bPause: false);
			DelaySetIsPauseGame(bPause: true);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ReplayPanel:OnStopButtonClicked")]
	private void OnStopButtonClicked()
	{
		ReplaySystemMgr.SetDemoCurrentTime(0f);
		if (ReplaySystemMgr.IsReplayPause())
		{
			BGW_ReplaySystemMgr.Get(this).PauseReplay(bPause: false);
			DelaySetIsPauseGame(bPause: true);
		}
	}

	public string GetTimeStr(float Time)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds((int)Time);
		return $"{timeSpan:hh':'mm':'ss}";
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		UpdatePause();
		UpdateSlider();
	}

	private void UpdatePause()
	{
		if (BGW_ReplaySystemMgr.Get(this).IsReplayPause() != IsPause)
		{
			BGW_ReplaySystemMgr.Get(this).PauseReplay(IsPause);
			if (!ReplaySystemMgr.IsReplayPause())
			{
				ReplaySystemMgr.SetDemoCurrentTime(ReplaySystemMgr.GetDemoCurrentTime());
			}
			PlayOrPauseImage.SetBrushFromTexture(IsPause ? PlayTexture : PauseTexture);
			PlayOrPauseImage?.ForceLayoutPrepass();
		}
	}

	private void UpdateSlider()
	{
		float demoCurrentTime = ReplaySystemMgr.GetDemoCurrentTime();
		float demoTotalTime = ReplaySystemMgr.GetDemoTotalTime();
		float num = 0f;
		if (demoTotalTime > 0f)
		{
			num = demoCurrentTime / demoTotalTime;
		}
		SliderBar.SetValue(demoCurrentTime);
		SliderBar.SetMaxValue(demoTotalTime);
		ProgressBar.SetPercent(num - 0.004f);
		CurTimeText.SetText(FText.FromString(GetTimeStr(demoCurrentTime)));
		TotalTimeText.SetText(FText.FromString(GetTimeStr(demoTotalTime)));
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureEnd")]
	private static void OnMouseCaptureEnd__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnMouseCaptureEnd();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnStopButtonClicked")]
	private static void OnStopButtonClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnStopButtonClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnBackButtonClicked")]
	private static void OnBackButtonClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnBackButtonClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureBegin")]
	private static void OnMouseCaptureBegin__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnMouseCaptureBegin();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnSliderValueChanged")]
	private static void OnSliderValueChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		float value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnSliderValueChanged_Value_Offset));
		bUI_ReplayPanel.OnSliderValueChanged(value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnForwardButtonClicked")]
	private static void OnForwardButtonClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnForwardButtonClicked();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ReplayPanel:OnPlayOrPauseButtonClicked")]
	private static void OnPlayOrPauseButtonClicked__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ReplayPanel bUI_ReplayPanel = GCHelper.Find<BUI_ReplayPanel>(obj);
		bUI_ReplayPanel.OnPlayOrPauseButtonClicked();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_ReplayPanel");
		OnMouseCaptureEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseCaptureEnd");
		OnMouseCaptureEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureEnd_FunctionAddress);
		OnMouseCaptureEnd_IsValid = OnMouseCaptureEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureEnd", OnMouseCaptureEnd_IsValid);
		OnStopButtonClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStopButtonClicked");
		OnStopButtonClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStopButtonClicked_FunctionAddress);
		OnStopButtonClicked_IsValid = OnStopButtonClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnStopButtonClicked", OnStopButtonClicked_IsValid);
		OnBackButtonClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnBackButtonClicked");
		OnBackButtonClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBackButtonClicked_FunctionAddress);
		OnBackButtonClicked_IsValid = OnBackButtonClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnBackButtonClicked", OnBackButtonClicked_IsValid);
		OnMouseCaptureBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseCaptureBegin");
		OnMouseCaptureBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureBegin_FunctionAddress);
		OnMouseCaptureBegin_IsValid = OnMouseCaptureBegin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnMouseCaptureBegin", OnMouseCaptureBegin_IsValid);
		OnSliderValueChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSliderValueChanged");
		OnSliderValueChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSliderValueChanged_FunctionAddress);
		OnSliderValueChanged_Value_Offset = NativeReflection.GetPropertyOffset(OnSliderValueChanged_FunctionAddress, "Value");
		OnSliderValueChanged_Value_IsValid = NativeReflection.ValidatePropertyClass(OnSliderValueChanged_FunctionAddress, "Value", Classes.FFloatProperty);
		OnSliderValueChanged_IsValid = OnSliderValueChanged_FunctionAddress != IntPtr.Zero && OnSliderValueChanged_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnSliderValueChanged", OnSliderValueChanged_IsValid);
		OnForwardButtonClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnForwardButtonClicked");
		OnForwardButtonClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnForwardButtonClicked_FunctionAddress);
		OnForwardButtonClicked_IsValid = OnForwardButtonClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnForwardButtonClicked", OnForwardButtonClicked_IsValid);
		OnPlayOrPauseButtonClicked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPlayOrPauseButtonClicked");
		OnPlayOrPauseButtonClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPlayOrPauseButtonClicked_FunctionAddress);
		OnPlayOrPauseButtonClicked_IsValid = OnPlayOrPauseButtonClicked_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ReplayPanel:OnPlayOrPauseButtonClicked", OnPlayOrPauseButtonClicked_IsValid);
	}

	static BUI_ReplayPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ReplayPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ReplayPanel));
	}
}
