using System;
using System.Collections.Generic;
using AOT;
using b1.EventDelDefine;
using b1.Plugins.GSInput;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class FInputDeviceTracker : FInputTrackerBase
{
	public static EGSInputIconType GamepadIconType;

	public static List<CooperationDeviceType> CooperationDeviceList;

	private const float DisconnectedTipsTime = 5f;

	private float _showTipsTimer;

	private static readonly List<FInputDeviceTracker> StaticHolderList;

	private readonly BGW_SettingMgrV2 _settingMgr;

	public FInputDeviceTracker(BGW_EnhancedInputMgrV2 InOwner)
	{
		base.Owner = InOwner;
		_settingMgr = BGW_SettingMgrV2.Get(base.Owner);
		InitialGamepadIconType();
		_showTipsTimer = 0f;
		StaticHolderList.Add(this);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OnSettingValueChanged));
		UpdateIconTypes((EGSInputIconType)_settingMgr.GetCVValueleByType(UISettingConfigType.DeviceType));
		BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection2.Evt_OnInputTrigger = (Del_InputTrigger)Delegate.Combine(bGW_EventCollection2.Evt_OnInputTrigger, new Del_InputTrigger(OnInputTrigger));
	}

	static FInputDeviceTracker()
	{
		FCoreDelegates.OnControllerConnectionChange.Bind(StaticControllerConnectionChange);
		CooperationDeviceList = new List<CooperationDeviceType>();
		StaticHolderList = new List<FInputDeviceTracker>();
		UpdateCooperationDeviceList();
	}

	public static List<EGSInputIconType> GetSupportInputIconTypes()
	{
		return new List<EGSInputIconType>
		{
			EGSInputIconType.KeyboardMouse,
			GamepadIconType
		};
	}

	[MonoPInvokeCallback(typeof(FCoreDelegates.OnControllerConnectionChangeHandler.Signature))]
	private static void StaticControllerConnectionChange(csbool IsConnected, int UserId, int ControllerIndex)
	{
		StaticHolderList.ForEach(delegate(FInputDeviceTracker Tracker)
		{
			Tracker.OnControllerStateChanged(IsConnected.Value);
		});
	}

	public static void UpdateCooperationDeviceList()
	{
		List<string> productStringList = UGSE_InputFuncLib.GetProductStringList();
		CooperationDeviceList.Clear();
		CooperationDeviceList.AddRange(FCooperationDeviceInfo.GetCooperationDevices(productStringList));
	}

	private void OnControllerStateChanged(bool IsConnected)
	{
		if (FInputTypeTracker.CurInputType == EGSInputType.Gamepad)
		{
			_showTipsTimer = (IsConnected ? 0f : 5f);
		}
	}

	private void OnInputTrigger(EGSInputType InputType)
	{
		if (!(_showTipsTimer <= 0f))
		{
			_showTipsTimer = 0f;
		}
	}

	private void OnSettingValueChanged(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.DeviceType)
		{
			UpdateIconTypes((EGSInputIconType)NewValue);
		}
	}

	public static void ForceSetIconTypes(EGSInputIconType InputIconType)
	{
		StaticHolderList.ForEach(delegate(FInputDeviceTracker Tracker)
		{
			Tracker.UpdateIconTypes(InputIconType, IsChangeConsoleVariable: true);
		});
	}

	private void UpdateIconTypes(EGSInputIconType InputIconType, bool IsChangeConsoleVariable = false)
	{
		GamepadIconType = InputIconType;
		if (IsChangeConsoleVariable)
		{
			_settingMgr.SetConsoleVariableByType(UISettingConfigType.DeviceType, (int)GamepadIconType);
		}
		BGW_EventCollection.Get(base.Owner).Evt_SwitchPlatformIcon();
	}

	public void InitialGamepadIconType()
	{
		GamepadIconType = (EGSInputIconType)_settingMgr.GetCVValueleByType(UISettingConfigType.DeviceType);
		if (BGW_OnlineSubsystem.OnlineSubsystemType == EBGWSubsystemType.Steam)
		{
			List<EGSInputDeviceType> inputDeviceTypes = UGSE_InputFuncLib.GetInputDeviceTypes();
			if (inputDeviceTypes.Contains(EGSInputDeviceType.Microsoft))
			{
				GamepadIconType = EGSInputIconType.XSX;
			}
			else if (inputDeviceTypes.Contains(EGSInputDeviceType.Sony))
			{
				GamepadIconType = EGSInputIconType.PS5;
			}
			else
			{
				GamepadIconType = EGSInputIconType.XSX;
			}
		}
		else if (GamepadIconType != EGSInputIconType.XSX && GamepadIconType != EGSInputIconType.PS5)
		{
			GamepadIconType = EGSInputIconType.XSX;
		}
		_settingMgr.SetConsoleVariableByType(UISettingConfigType.DeviceType, (int)GamepadIconType);
	}

	public void ResumeToDefault()
	{
		GamepadIconType = EGSInputIconType.XSX;
		_settingMgr.SetConsoleVariableByType(UISettingConfigType.DeviceType, (int)GamepadIconType);
		BGW_EventCollection.Get(base.Owner).Evt_SwitchPlatformIcon();
	}

	public override void OnShutdown()
	{
		StaticHolderList.Remove(this);
	}

	public void OnTick(float DeltaTime)
	{
		if (!(_showTipsTimer <= 0f))
		{
			_showTipsTimer -= DeltaTime;
			if (_showTipsTimer <= 0f)
			{
				BGW_UIEventCollection.Get(base.Owner).Evt_UI_ShowDisconnectControllerTips();
			}
		}
	}
}
