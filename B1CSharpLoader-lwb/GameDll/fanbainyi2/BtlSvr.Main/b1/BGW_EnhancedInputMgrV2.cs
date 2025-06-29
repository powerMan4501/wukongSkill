using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.GSInput;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_EnhancedInputMgrV2")]
public class BGW_EnhancedInputMgrV2 : GameInstanceSystemBaseUObj
{
	private const string InputMappingContextConfigRef = "/Game/00Main/DataAsset/Input/InputMappingContext_V2/DA_InputMappingContextConfig.DA_InputMappingContextConfig";

	private const string CustomizedInputSettingRef = "/Game/00Main/Design/Config/DA_CustomizedInputSetting.DA_CustomizedInputSetting";

	private static bool InputMappingContextConfig_IsValid;

	private static int InputMappingContextConfig_Offset;

	private static bool CustomizedInputSetting_IsValid;

	private static int CustomizedInputSetting_Offset;

	private static bool Receiver_IsValid;

	private static int Receiver_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_EnhancedInputMgrV2:InputMappingContextConfig")]
	private BGWDataAsset_InputMappingContextConfigV2 InputMappingContextConfig
	{
		get
		{
			CheckDestroyed();
			if (!InputMappingContextConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:InputMappingContextConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_InputMappingContextConfigV2>.FromNative(IntPtr.Add(base.Address, InputMappingContextConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputMappingContextConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:InputMappingContextConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_InputMappingContextConfigV2>.ToNative(IntPtr.Add(base.Address, InputMappingContextConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_EnhancedInputMgrV2:CustomizedInputSetting")]
	private BGWDataAsset_CustomizedInputSetting CustomizedInputSetting
	{
		get
		{
			CheckDestroyed();
			if (!CustomizedInputSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:CustomizedInputSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_CustomizedInputSetting>.FromNative(IntPtr.Add(base.Address, CustomizedInputSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomizedInputSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:CustomizedInputSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_CustomizedInputSetting>.ToNative(IntPtr.Add(base.Address, CustomizedInputSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_EnhancedInputMgrV2:Receiver")]
	public UInputActionEventReceiver Receiver
	{
		get
		{
			CheckDestroyed();
			if (!Receiver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:Receiver");
				return null;
			}
			return UObjectMarshaler<UInputActionEventReceiver>.FromNative(IntPtr.Add(base.Address, Receiver_Offset));
		}
		private set
		{
			CheckDestroyed();
			if (!Receiver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_EnhancedInputMgrV2:Receiver");
			}
			else
			{
				UObjectMarshaler<UInputActionEventReceiver>.ToNative(IntPtr.Add(base.Address, Receiver_Offset), value);
			}
		}
	}

	public UGSInputComponent InputComp { get; private set; }

	public FInputChordProcessor InputChordProcessor { get; private set; }

	public FInputActionProcessor InputActionProcessor { get; private set; }

	public FInputMappingContextProcessor InputMappingContextProcessor { get; private set; }

	public FInputDebugTracker InputDebugTracker { get; private set; }

	public FInputWidgetTracker InputWidgetTracker { get; private set; }

	public FInputModeTracker InputModeTracker { get; private set; }

	public FInputPreProcTracker InputPreProcTracker { get; private set; }

	public FInputTypeTracker InputTypeTracker { get; private set; }

	public FInputSettingTracker InputSettingTracker { get; private set; }

	public FInputIconTracker InputIconTracker { get; private set; }

	public FInputDeviceTracker InputDeviceTracker { get; private set; }

	public static BGW_EnhancedInputMgrV2 Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BGW_EnhancedInputMgrV2>(WorldCtx);
	}

	public override void OnInit()
	{
		Receiver = UObject.NewObject<UInputActionEventReceiver>(this);
		UGSE_InputFuncLib.RegisterInputTargetBinding(Receiver);
		InputMappingContextConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_InputMappingContextConfigV2>("/Game/00Main/DataAsset/Input/InputMappingContext_V2/DA_InputMappingContextConfig.DA_InputMappingContextConfig", ELoadResourceType.SyncLoadAndCache);
		if (CheckLoadAssetInvalid(InputMappingContextConfig, "InputMappingContextConfig", "/Game/00Main/DataAsset/Input/InputMappingContext_V2/DA_InputMappingContextConfig.DA_InputMappingContextConfig"))
		{
			return;
		}
		CustomizedInputSetting = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_CustomizedInputSetting>("/Game/00Main/Design/Config/DA_CustomizedInputSetting.DA_CustomizedInputSetting", ELoadResourceType.SyncLoadAndCache);
		if (!CheckLoadAssetInvalid(CustomizedInputSetting, "CustomizedInputSetting", "/Game/00Main/Design/Config/DA_CustomizedInputSetting.DA_CustomizedInputSetting"))
		{
			InputDebugTracker = new FInputDebugTracker(this);
			InputPreProcTracker = new FInputPreProcTracker(this);
			InputWidgetTracker = new FInputWidgetTracker(this, InputPreProcTracker, InputMappingContextConfig.Configs);
			InputModeTracker = new FInputModeTracker(this, InputDebugTracker);
			InputTypeTracker = new FInputTypeTracker(this, InputModeTracker);
			InputSettingTracker = new FInputSettingTracker(this, CustomizedInputSetting, InputMappingContextConfig);
			InputDeviceTracker = new FInputDeviceTracker(this);
			InputIconTracker = new FInputIconTracker(this, InputSettingTracker);
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
			if (bGW_EventCollection != null)
			{
				bGW_EventCollection.Evt_PostInitPlayerInputFinish = (Del_Void_PlayerController)Delegate.Combine(bGW_EventCollection.Evt_PostInitPlayerInputFinish, new Del_Void_PlayerController(PostInitPlayerInputFinish));
				bGW_EventCollection.Evt_PostPlayerInputDispose = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostPlayerInputDispose, new Del_Void(PostPlayerInputDispose));
				bGW_EventCollection.Evt_SetInputMode = (Del_Void_EGSInputModeWithChangeReason)Delegate.Combine(bGW_EventCollection.Evt_SetInputMode, new Del_Void_EGSInputModeWithChangeReason(InputModeTracker.SetInputMode));
				bGW_EventCollection.Evt_SetSuperUserInputMode = (Del_SetSuperUserInputMode)Delegate.Combine(bGW_EventCollection.Evt_SetSuperUserInputMode, new Del_SetSuperUserInputMode(InputModeTracker.SetSuperUserInputMode));
				bGW_EventCollection.Evt_ResetInputMode = (Del_Void_EGSInputMode)Delegate.Combine(bGW_EventCollection.Evt_ResetInputMode, new Del_Void_EGSInputMode(InputModeTracker.ResetInputMode));
				bGW_EventCollection.Evt_ForceHideMouseCursor = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_ForceHideMouseCursor, new Del_Void_Bool(InputModeTracker.ForceHideMouseCursor));
				bGW_EventCollection.Evt_OnInputTrigger = (Del_InputTrigger)Delegate.Combine(bGW_EventCollection.Evt_OnInputTrigger, new Del_InputTrigger(InputTypeTracker.OnInputTrigger));
				bGW_EventCollection.Evt_SetPageToppingEvent = (Del_SetGSPageToppingEvent)Delegate.Combine(bGW_EventCollection.Evt_SetPageToppingEvent, new Del_SetGSPageToppingEvent(InputWidgetTracker.SetToppingPageInfo));
				bGW_EventCollection.Evt_RegisterInputWidget = (Del_Void_UGSInputWidgetCS)Delegate.Combine(bGW_EventCollection.Evt_RegisterInputWidget, new Del_Void_UGSInputWidgetCS(InputWidgetTracker.RegisterInputWidget));
				bGW_EventCollection.Evt_UnRegisterInputWidget = (Del_Void_UGSInputWidgetCS)Delegate.Combine(bGW_EventCollection.Evt_UnRegisterInputWidget, new Del_Void_UGSInputWidgetCS(InputWidgetTracker.UnRegisterInputWidget));
				bGW_EventCollection.Evt_RegisterGlobalRootWidget = (Del_Void_UGSInputWidgetCS)Delegate.Combine(bGW_EventCollection.Evt_RegisterGlobalRootWidget, new Del_Void_UGSInputWidgetCS(InputWidgetTracker.RegisterGlobalRootWidget));
				bGW_EventCollection.Evt_AddTriggerInputWidget = (Del_Void_UGSInputWidgetCSInt)Delegate.Combine(bGW_EventCollection.Evt_AddTriggerInputWidget, new Del_Void_UGSInputWidgetCSInt(InputWidgetTracker.AddTriggerInputWidget));
				bGW_EventCollection.Evt_RemoveTriggerInputWidget = (Del_Void_UGSInputWidgetCSInt)Delegate.Combine(bGW_EventCollection.Evt_RemoveTriggerInputWidget, new Del_Void_UGSInputWidgetCSInt(InputWidgetTracker.RemoveTriggerInputWidget));
				bGW_EventCollection.Evt_ClearTriggerInputWidget = (Del_Void_UGSInputWidgetCS)Delegate.Combine(bGW_EventCollection.Evt_ClearTriggerInputWidget, new Del_Void_UGSInputWidgetCS(InputWidgetTracker.ClearTriggerInputWidget));
				bGW_EventCollection.Evt_ClearAllInputDelegates = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ClearAllInputDelegates, new Del_Void(InputWidgetTracker.ClearAllWidgetActionBindEvent));
				bGW_EventCollection.Evt_BlockWidgetNavigation = (Del_BlockNavigation)Delegate.Combine(bGW_EventCollection.Evt_BlockWidgetNavigation, new Del_BlockNavigation(InputWidgetTracker.BlockWidgetNavigation));
				bGW_EventCollection.Evt_BindInputSettingsPreProcEvent = (Del_BindInputSettingsPreProcEvent)Delegate.Combine(bGW_EventCollection.Evt_BindInputSettingsPreProcEvent, new Del_BindInputSettingsPreProcEvent(InputSettingTracker.KeyboardSetting.PreProcEvent.BindAction));
				bGW_EventCollection.Evt_UnbindInputSettingsPreProcEvent = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_UnbindInputSettingsPreProcEvent, new Del_Void(InputSettingTracker.KeyboardSetting.PreProcEvent.UnbindAction));
				bGW_EventCollection.Evt_ResumeInputSettingsToDefault = InputSettingTracker.ResumeToDefault;
				bGW_EventCollection.Evt_ResumeKeyboardSettings = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ResumeKeyboardSettings, new Del_Void(InputSettingTracker.KeyboardSetting.ResumeToDefault));
				bGW_EventCollection.Evt_ResumeGamepadSettings = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ResumeGamepadSettings, new Del_Void(InputSettingTracker.GamepadSetting.ResumeToDefault));
				bGW_EventCollection.Evt_ResumeGamepadSettings = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ResumeGamepadSettings, new Del_Void(InputDeviceTracker.ResumeToDefault));
				bGW_EventCollection.Evt_OnInputTypeChangeTrigger = (Del_Void_EGSInputType)Delegate.Combine(bGW_EventCollection.Evt_OnInputTypeChangeTrigger, new Del_Void_EGSInputType(InputIconTracker.OnInputTypeChangeTrigger));
				bGW_EventCollection.Evt_SwitchPlatformIcon = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_SwitchPlatformIcon, new Del_Void(InputIconTracker.SwitchPlatformIcon));
				bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(InputIconTracker.PostLoadMapWithWorld));
				bGW_EventCollection.Evt_PostApplyInputSettingFinish = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostApplyInputSettingFinish, new Del_Void(InputIconTracker.RefreshInputActionIconCache));
				bGW_EventCollection.Evt_OpenInputLog = (Del_OpenInputLog)Delegate.Combine(bGW_EventCollection.Evt_OpenInputLog, new Del_OpenInputLog(InputDebugTracker.OpenInputLog));
			}
		}
	}

	private void BindToEventCollection(bool IsBind)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (!(bGW_EventCollection == null) && InputMappingContextProcessor != null && InputActionProcessor != null && InputChordProcessor != null)
		{
			if (IsBind)
			{
				bGW_EventCollection.Evt_BlockUIInput = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_BlockUIInput, new Del_Void_Bool(InputMappingContextProcessor.BlockUIInput));
				bGW_EventCollection.Evt_BlockBattleInput = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_BlockBattleInput, new Del_Void_Bool(InputMappingContextProcessor.BlockBattleInput));
				bGW_EventCollection.Evt_BlockAllInput = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_BlockAllInput, new Del_Void_Bool(InputMappingContextProcessor.BlockAllInput));
				bGW_EventCollection.Evt_BeginBlockCinematicInput = (Del_Void_BoolBoolBool)Delegate.Combine(bGW_EventCollection.Evt_BeginBlockCinematicInput, new Del_Void_BoolBoolBool(InputMappingContextProcessor.BeginBlockCinematicInput));
				bGW_EventCollection.Evt_EndBlockCinematicInput = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_EndBlockCinematicInput, new Del_Void(InputMappingContextProcessor.EndBlockCinematicInput));
				bGW_EventCollection.Evt_SetInputMappingContextEnable = (Del_Void_EInputMappingContextTagBool)Delegate.Combine(bGW_EventCollection.Evt_SetInputMappingContextEnable, new Del_Void_EInputMappingContextTagBool(InputMappingContextProcessor.SetEnable));
				bGW_EventCollection.Evt_PostApplyInputSettingFinish = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostApplyInputSettingFinish, new Del_Void(InputMappingContextProcessor.PostApplyInputSettingFinish));
				bGW_EventCollection.Evt_SetCloudInputEnable = (Del_Void_Bool)Delegate.Combine(bGW_EventCollection.Evt_SetCloudInputEnable, new Del_Void_Bool(InputMappingContextProcessor.SetCloudInputEnable));
				bGW_EventCollection.Evt_BlockInput = (BGW_EventCollection.Del_BlockInput)Delegate.Combine(bGW_EventCollection.Evt_BlockInput, new BGW_EventCollection.Del_BlockInput(InputMappingContextProcessor.BlockInput));
				bGW_EventCollection.Evt_InjectInputTriggerEvent = (Del_InjectInputTriggerEvent)Delegate.Combine(bGW_EventCollection.Evt_InjectInputTriggerEvent, new Del_InjectInputTriggerEvent(InputActionProcessor.InjectInputTriggerEvent));
				bGW_EventCollection.Evt_GetAxisInputAction = (Del_GetAxisInputAction)Delegate.Combine(bGW_EventCollection.Evt_GetAxisInputAction, new Del_GetAxisInputAction(InputActionProcessor.GetAxisInputAction));
				bGW_EventCollection.Evt_RegisterBattleCallback = (Del_RegisterBattleCallback)Delegate.Combine(bGW_EventCollection.Evt_RegisterBattleCallback, new Del_RegisterBattleCallback(InputChordProcessor.RegisterBattleCallback));
			}
			else
			{
				bGW_EventCollection.Evt_BlockUIInput = (Del_Void_Bool)Delegate.Remove(bGW_EventCollection.Evt_BlockUIInput, new Del_Void_Bool(InputMappingContextProcessor.BlockUIInput));
				bGW_EventCollection.Evt_BlockBattleInput = (Del_Void_Bool)Delegate.Remove(bGW_EventCollection.Evt_BlockBattleInput, new Del_Void_Bool(InputMappingContextProcessor.BlockBattleInput));
				bGW_EventCollection.Evt_BlockAllInput = (Del_Void_Bool)Delegate.Remove(bGW_EventCollection.Evt_BlockAllInput, new Del_Void_Bool(InputMappingContextProcessor.BlockAllInput));
				bGW_EventCollection.Evt_BeginBlockCinematicInput = (Del_Void_BoolBoolBool)Delegate.Remove(bGW_EventCollection.Evt_BeginBlockCinematicInput, new Del_Void_BoolBoolBool(InputMappingContextProcessor.BeginBlockCinematicInput));
				bGW_EventCollection.Evt_EndBlockCinematicInput = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_EndBlockCinematicInput, new Del_Void(InputMappingContextProcessor.EndBlockCinematicInput));
				bGW_EventCollection.Evt_SetInputMappingContextEnable = (Del_Void_EInputMappingContextTagBool)Delegate.Remove(bGW_EventCollection.Evt_SetInputMappingContextEnable, new Del_Void_EInputMappingContextTagBool(InputMappingContextProcessor.SetEnable));
				bGW_EventCollection.Evt_PostApplyInputSettingFinish = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostApplyInputSettingFinish, new Del_Void(InputMappingContextProcessor.PostApplyInputSettingFinish));
				bGW_EventCollection.Evt_SetCloudInputEnable = (Del_Void_Bool)Delegate.Remove(bGW_EventCollection.Evt_SetCloudInputEnable, new Del_Void_Bool(InputMappingContextProcessor.SetCloudInputEnable));
				bGW_EventCollection.Evt_BlockInput = (BGW_EventCollection.Del_BlockInput)Delegate.Remove(bGW_EventCollection.Evt_BlockInput, new BGW_EventCollection.Del_BlockInput(InputMappingContextProcessor.BlockInput));
				bGW_EventCollection.Evt_InjectInputTriggerEvent = (Del_InjectInputTriggerEvent)Delegate.Remove(bGW_EventCollection.Evt_InjectInputTriggerEvent, new Del_InjectInputTriggerEvent(InputActionProcessor.InjectInputTriggerEvent));
				bGW_EventCollection.Evt_GetAxisInputAction = (Del_GetAxisInputAction)Delegate.Remove(bGW_EventCollection.Evt_GetAxisInputAction, new Del_GetAxisInputAction(InputActionProcessor.GetAxisInputAction));
				bGW_EventCollection.Evt_RegisterBattleCallback = (Del_RegisterBattleCallback)Delegate.Remove(bGW_EventCollection.Evt_RegisterBattleCallback, new Del_RegisterBattleCallback(InputChordProcessor.RegisterBattleCallback));
			}
		}
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		UGSE_InputFuncLib.UnRegisterInputTargetBinding(Receiver);
		UGSE_InputFuncLib.SetCursorVisibility(bDrawCursor: true);
		InputWidgetTracker.OnShutdown();
		InputWidgetTracker = null;
		InputPreProcTracker.OnShutdown();
		InputPreProcTracker = null;
		InputSettingTracker.OnShutdown();
		InputSettingTracker = null;
		InputIconTracker.OnShutdown();
		InputIconTracker = null;
		InputDebugTracker.OnShutdown();
		InputDebugTracker = null;
		InputDeviceTracker.OnShutdown();
		InputDeviceTracker = null;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		InputWidgetTracker.OnTick(DeltaTime);
		InputDebugTracker.OnTick(DeltaTime);
		InputDeviceTracker.OnTick(DeltaTime);
		InputChordProcessor?.OnTick(DeltaTime);
	}

	private void PostPlayerInputDispose()
	{
		if (!(InputComp == null))
		{
			BindToEventCollection(IsBind: false);
			InputActionProcessor?.OnShutdown();
			InputActionProcessor = null;
			InputMappingContextProcessor?.OnShutdown();
			InputMappingContextProcessor = null;
			InputChordProcessor?.OnShutdown();
			InputChordProcessor = null;
			InputModeTracker?.OnPostPlayerInputOnShutdown();
			InputComp = null;
		}
	}

	private void PostInitPlayerInputFinish(APlayerController PlayerController)
	{
		if (PlayerController.InputComponent is UGSInputComponent uGSInputComponent)
		{
			InputComp = uGSInputComponent;
			InputChordProcessor = new FInputChordProcessor(PlayerController, InputDebugTracker);
			InputActionProcessor = new FInputActionProcessor(PlayerController, uGSInputComponent, InputWidgetTracker, InputDebugTracker);
			InputMappingContextProcessor = new FInputMappingContextProcessor(PlayerController, InputChordProcessor, InputActionProcessor, InputModeTracker, InputSettingTracker, InputMappingContextConfig, InputDebugTracker);
			BindToEventCollection(IsBind: true);
			InputModeTracker.UpdateInputComponent(InputComp);
			BindSpecialInput();
		}
	}

	private void BindSpecialInput()
	{
		BindGMAction("IA_GSGMDisplayInput", ETriggerEvent.Started, OnInputGMDisplayInput);
		BindGMAction("IA_GSGMDisplayInput_Chord", ETriggerEvent.Started, null);
		BindGMAction("IA_GSGMDisplayInput_Chord", ETriggerEvent.Completed, null);
	}

	private void OnInputGMDisplayInput(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason)
	{
		if (BGWConsoleCommands.HasGMFlag(16))
		{
			BGW_UIEventCollection.Get(base.Owner)?.Evt_UI_SwitchInputDisplay(B1: true);
		}
	}

	public static EGSInputType GetCurrentInputType()
	{
		return FInputTypeTracker.CurInputType;
	}

	public static EGSInputIconType GetCurrentGamepadType()
	{
		return FInputDeviceTracker.GamepadIconType;
	}

	public bool IsActionTrigger(GSBattleActionEn ActionEn)
	{
		if (InputActionProcessor == null)
		{
			return false;
		}
		string name = ActionNameFuncLib.GetName(ActionEn);
		return InputActionProcessor.IsActionTrigger(name);
	}

	public void BindBattleAction(string ActionName, EEnhancedTriggerEvent EnhancedTriggerEvent)
	{
		ETriggerEvent triggerEvent = (ETriggerEvent)EnhancedTriggerEvent;
		FBindInputActionParam param = new FBindInputActionParam
		{
			ActionName = ActionName,
			TriggerEvent = triggerEvent,
			Callback = InputChordProcessor.InputActionTrigger,
			InputActionType = EnhancedInputActionType.Battle,
			InputActionRefType = EnhancedInputActionType.Battle,
			InputMappingContextProcessor = InputMappingContextProcessor
		};
		InputActionProcessor.BindInputAction(param);
	}

	public void BindReplayAction(string ActionName, ETriggerEvent TriggerEvent, FInputDelegate.InputActionTrigger Callback)
	{
		FBindInputActionParam param = new FBindInputActionParam
		{
			ActionName = ActionName,
			TriggerEvent = TriggerEvent,
			Callback = Callback,
			InputActionType = EnhancedInputActionType.Replay,
			InputActionRefType = EnhancedInputActionType.Replay,
			InputMappingContextProcessor = InputMappingContextProcessor
		};
		InputActionProcessor.BindInputAction(param);
	}

	public void BindGMAction(string ActionName, ETriggerEvent TriggerEvent, FInputDelegate.InputActionTrigger Callback)
	{
		FBindInputActionParam param = new FBindInputActionParam
		{
			ActionName = ActionName,
			TriggerEvent = TriggerEvent,
			Callback = Callback,
			InputActionType = EnhancedInputActionType.GM,
			InputActionRefType = EnhancedInputActionType.GM,
			InputMappingContextProcessor = InputMappingContextProcessor
		};
		InputActionProcessor.BindInputAction(param);
	}

	private void BindUIAction(string ActionName, UGSInputWidgetCS Widget, FInputDelegate.UIInputActionTrigger UICallback, bool IsBattleAction, ETriggerEvent TriggerEvent, int PageId)
	{
		FBindInputActionParam param = new FBindInputActionParam
		{
			ActionName = ActionName,
			TriggerEvent = TriggerEvent,
			Callback = InputWidgetTracker.InputActionTrigger,
			InputActionType = EnhancedInputActionType.UI,
			InputActionRefType = ((!IsBattleAction) ? EnhancedInputActionType.UI : EnhancedInputActionType.Battle),
			InputMappingContextProcessor = InputMappingContextProcessor
		};
		InputActionProcessor.BindInputAction(param);
		FUpdateInputWidgetInfoParam param2 = new FUpdateInputWidgetInfoParam
		{
			ActionName = ActionName,
			TriggerEvent = TriggerEvent,
			Widget = Widget,
			Callback = UICallback,
			PageId = PageId
		};
		InputActionProcessor.UpdateInputWidgetInfo(param2);
	}

	public void UpdateWidgetCustomBlockConflictNavInfo(int PageId, List<EUINavigation> NewExcludeCustomBlockConflictNavigationList)
	{
		InputActionProcessor?.UpdateWidgetCustomBlockConflictNavInfo(PageId, NewExcludeCustomBlockConflictNavigationList);
	}

	public void BindUIAction(GSUIActionEn ActionEn, UGSInputWidgetCS Widget, FInputDelegate.UIInputActionTrigger UICallback, ETriggerEvent TriggerEvent = ETriggerEvent.Triggered, int PageId = -1)
	{
		string name = ActionNameFuncLib.GetName(ActionEn);
		BindUIAction(name, Widget, UICallback, IsBattleAction: false, TriggerEvent, PageId);
	}

	public void BindUIAction(GSBattleActionEn ActionEn, UGSInputWidgetCS Widget, FInputDelegate.UIInputActionTrigger UICallback, ETriggerEvent TriggerEvent = ETriggerEvent.Triggered, int PageId = -1)
	{
		string name = ActionNameFuncLib.GetName(ActionEn);
		BindUIAction(name, Widget, UICallback, IsBattleAction: true, TriggerEvent, PageId);
	}

	public void BindInputPreProcEvent<T>(T Event, UGSInputWidgetCS InputWidget) where T : Delegate
	{
		InputWidgetTracker.BindInputPreProcEvent(Event, InputWidget);
	}

	public void UnbindInputPreProcEvent(UGSInputWidgetCS InputWidget)
	{
		InputWidgetTracker.UnbindInputPreProcEvent(InputWidget);
	}

	public bool TryGetInputActionValue(GSBattleActionEn BattleActionEn, out FInputActionValue Value)
	{
		if (InputActionProcessor != null && InputActionProcessor.TryGetInputActionValue(ActionNameFuncLib.GetName(BattleActionEn), out Value))
		{
			return true;
		}
		Value = null;
		return false;
	}

	public static bool CheckLoadAssetInvalid(UObject Asset, string AssetName, string AssetPath)
	{
		if (Asset == null)
		{
			BGW_LogUtil.LogError("Enhanced Input: " + AssetName + "加载失败，相关路径：" + AssetPath);
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_EnhancedInputMgrV2");
		InputMappingContextConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputMappingContextConfig");
		InputMappingContextConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputMappingContextConfig", Classes.FObjectProperty);
		CustomizedInputSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CustomizedInputSetting");
		CustomizedInputSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CustomizedInputSetting", Classes.FObjectProperty);
		Receiver_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Receiver");
		Receiver_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Receiver", Classes.FObjectProperty);
	}

	static BGW_EnhancedInputMgrV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_EnhancedInputMgrV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_EnhancedInputMgrV2));
	}
}
