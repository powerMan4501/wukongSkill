using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.SlateCore;

namespace b1;

public static class FInputDelegate
{
	public delegate void InputActionTrigger(string ActionName, ETriggerEvent TriggerEvent, FInputActionValue Value, EInputActionTriggerReason Reason);

	public delegate bool UIInputActionTrigger(FInputActionValue Value);

	public delegate void OpenInputLog();

	public delegate void UpdateDebugInfo(ref Dictionary<string, int> TickPressedKeyCount, ref Dictionary<string, int> TickReleasedKeyCount);

	public delegate void AppendBlockInformation(ref List<FDisplayLine> DisplayLines);

	public delegate void InputModeChange(EGSInputMode OldInputMode, EGSInputMode NewInputMode);

	public delegate void InputTypeChange(EGSInputType OldInputType, EGSInputType NewInputType);

	public delegate void PostInputActionTrigger(string InputActionName, bool IsTrigger);

	public delegate void PostInputMappingContextTrigger(string ContextName, bool IsTrigger);

	public delegate void AnalogEvent(FAnalogInputEvent AnalogInputEvent);

	public delegate void KeyDown(FKeyEvent KeyEvent);

	public delegate void KeyUp(FKeyEvent KeyEvent);

	public delegate void MouseButtonDown(FPointerEvent PointerEvent);

	public delegate void MouseButtonUp(FPointerEvent PointerEvent);

	public delegate void MouseWheelEvent(FPointerEvent InWheelEvent);
}
