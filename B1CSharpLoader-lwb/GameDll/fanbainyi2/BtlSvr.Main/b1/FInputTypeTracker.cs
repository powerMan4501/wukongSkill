using System;
using b1.EventDelDefine;
using b1.Plugins.GSInput;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1;

public class FInputTypeTracker : FInputTrackerBase
{
	private enum EUpdateSyntheticCursorMoveReason
	{
		InputType,
		InputMode,
		ApplicationActivationChanged,
		AnyKeyTrigger
	}

	public static EGSInputType CurInputType { get; private set; }

	private FInputModeTracker InputModeTracker { get; }

	private IConsoleVariable EnableSyntheticCursorMovesVar { get; }

	private bool HaveAnyKeyTriggered { get; set; }

	public FInputTypeTracker(BGW_EnhancedInputMgrV2 InOwner, FInputModeTracker InInputModeTracker)
	{
		base.Owner = InOwner;
		switch (FPlatformProperties.GetPlatform())
		{
		case EPlatform.PS5:
		case EPlatform.XSX:
			CurInputType = EGSInputType.Gamepad;
			break;
		case EPlatform.Windows:
			CurInputType = EGSInputType.KeyboardMouse;
			break;
		default:
			CurInputType = EGSInputType.None;
			break;
		}
		InputModeTracker = InInputModeTracker;
		FInputModeTracker inputModeTracker = InputModeTracker;
		inputModeTracker.InputModeChangeHandle = (FInputDelegate.InputModeChange)Delegate.Combine(inputModeTracker.InputModeChangeHandle, new FInputDelegate.InputModeChange(InputModeChange));
		HaveAnyKeyTriggered = false;
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_OnAnyKeyTrigger = (Del_Void_FKey)Delegate.Combine(bGW_EventCollection.Evt_OnAnyKeyTrigger, new Del_Void_FKey(OnAnyKeyTrigger));
		EnableSyntheticCursorMovesVar = IConsoleManager.Get().FindConsoleVariable("Slate.EnableSyntheticCursorMoves");
	}

	private void OnAnyKeyTrigger(FKey Key)
	{
		if (!HaveAnyKeyTriggered)
		{
			HaveAnyKeyTriggered = true;
			UpdateSlateEnableSyntheticCursorMoves(EUpdateSyntheticCursorMoveReason.AnyKeyTrigger);
		}
	}

	public void OnPostApplicationActivationChanged(bool IsActive)
	{
		HaveAnyKeyTriggered = false;
		if (!IsActive)
		{
			SetSyntheticCursorMovesVar(IsEnable: true);
		}
		else
		{
			UpdateSlateEnableSyntheticCursorMoves(EUpdateSyntheticCursorMoveReason.ApplicationActivationChanged);
		}
	}

	public void OnInputTrigger(EGSInputType NewInputType)
	{
		if (CurInputType != NewInputType)
		{
			CurInputType = NewInputType;
			InputModeTracker.UpdateByInputType(CurInputType);
			UpdateSlateEnableSyntheticCursorMoves(EUpdateSyntheticCursorMoveReason.InputType);
		}
	}

	private void UpdateSlateEnableSyntheticCursorMoves(EUpdateSyntheticCursorMoveReason Reason)
	{
		if (HaveAnyKeyTriggered)
		{
			SetSyntheticCursorMovesVar(CurInputType == EGSInputType.KeyboardMouse && InputModeTracker.InputMode == EGSInputMode.UIOnly);
			if (Reason != EUpdateSyntheticCursorMoveReason.InputMode)
			{
				UpdateMouseCursor();
			}
		}
	}

	private void SetSyntheticCursorMovesVar(bool IsEnable)
	{
		int value = (IsEnable ? 1 : 0);
		EnableSyntheticCursorMovesVar?.Set(value, EConsoleVariableFlags.SetByGameOverride);
	}

	private void UpdateMouseCursor()
	{
		switch (InputModeTracker.InputMode)
		{
		case EGSInputMode.UIOnly:
			UGSE_InputFuncLib.SetUIOnly(base.LocalPlayerController, CurInputType == EGSInputType.KeyboardMouse);
			InputModeTracker.UpdateMouseCursorByInputTracker(CurInputType == EGSInputType.KeyboardMouse);
			break;
		case EGSInputMode.GameOnly:
			UGSE_InputFuncLib.SetGameOnly(base.LocalPlayerController);
			InputModeTracker.UpdateMouseCursorByInputTracker(bShow: false);
			break;
		case EGSInputMode.UIAndGame:
		case EGSInputMode.GM:
		case EGSInputMode.Replay:
			UGSE_InputFuncLib.SetUIOnly(base.LocalPlayerController);
			InputModeTracker.UpdateMouseCursorByInputTracker(bShow: true);
			break;
		}
	}

	private void InputModeChange(EGSInputMode OldInputMode, EGSInputMode NewInputMode)
	{
		UpdateSlateEnableSyntheticCursorMoves(EUpdateSyntheticCursorMoveReason.InputMode);
		UpdateMouseCursor();
	}
}
