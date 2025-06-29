using b1.Plugins.GSInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputPreProcTracker : FInputTrackerBase
{
	public UGSInputPreProc InputPreProc { get; set; }

	public UInputPreProcEvent InputPreProcEvent { get; set; }

	public FInputPreProcTracker(BGW_EnhancedInputMgrV2 InOwner)
	{
		base.Owner = InOwner;
		UGSE_InputFuncLib.RegisterGSInputProc(base.Owner, EGSInputProcOrder.General);
		InputPreProc = UGSE_InputFuncLib.GetInputPreProc(base.Owner);
		InputPreProcEvent = UObject.NewObject<UInputPreProcEvent>(base.Owner);
		InputPreProcEvent.AddToRoot();
		InputPreProc.OnInputTrigger.Bind(InputPreProcEvent.OnInputTrigger);
		InputPreProc.OnInputTypeChangeTrigger.Bind(InputPreProcEvent.OnInputTypeChangeTrigger);
		InputPreProc.OnKeyDownEvent.Bind(InputPreProcEvent.OnKeyDownEvent);
		InputPreProc.OnKeyUpEvent.Bind(InputPreProcEvent.OnKeyUpEvent);
		InputPreProc.OnAnalogInputEvent.Bind(InputPreProcEvent.OnAnalogInputEvent);
		InputPreProc.OnMouseMoveEvent.Bind(InputPreProcEvent.OnMouseMoveEvent);
		InputPreProc.OnMouseButtonDownEvent.Bind(InputPreProcEvent.OnMouseButtonDownEvent);
		InputPreProc.OnMouseButtonUpEvent.Bind(InputPreProcEvent.OnMouseButtonUpEvent);
		InputPreProc.OnMouseButtonDoubleClickEvent.Bind(InputPreProcEvent.OnMouseButtonDoubleClickEvent);
		InputPreProc.OnMouseWheelEvent.Bind(InputPreProcEvent.OnMouseWheelEvent);
		InputPreProc.OnAnyKeyTriggerEvent.Bind(InputPreProcEvent.OnAnyKeyTriggerEvent);
	}

	public override void OnShutdown()
	{
		InputPreProc.OnInputTrigger.Unbind(InputPreProcEvent.OnInputTrigger);
		InputPreProc.OnInputTypeChangeTrigger.Unbind(InputPreProcEvent.OnInputTypeChangeTrigger);
		InputPreProc.OnKeyDownEvent.Unbind(InputPreProcEvent.OnKeyDownEvent);
		InputPreProc.OnKeyUpEvent.Unbind(InputPreProcEvent.OnKeyUpEvent);
		InputPreProc.OnAnalogInputEvent.Unbind(InputPreProcEvent.OnAnalogInputEvent);
		InputPreProc.OnMouseMoveEvent.Unbind(InputPreProcEvent.OnMouseMoveEvent);
		InputPreProc.OnMouseButtonDownEvent.Unbind(InputPreProcEvent.OnMouseButtonDownEvent);
		InputPreProc.OnMouseButtonUpEvent.Unbind(InputPreProcEvent.OnMouseButtonUpEvent);
		InputPreProc.OnMouseButtonDoubleClickEvent.Unbind(InputPreProcEvent.OnMouseButtonDoubleClickEvent);
		InputPreProc.OnMouseWheelEvent.Unbind(InputPreProcEvent.OnMouseWheelEvent);
		InputPreProc.OnAnyKeyTriggerEvent.Unbind(InputPreProcEvent.OnAnyKeyTriggerEvent);
		InputPreProcEvent.RemoveFromRoot();
		UGSE_InputFuncLib.UnRegisterGSInputProc(InputPreProc, EGSInputProcOrder.General);
	}
}
