using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_InjectInputTriggerEvent : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Running,
		Succeeded
	}

	private InnerState CurrentState;

	private int TickCounter;

	private string TarInputActionName = "";

	private string TarTriggerEvent = "";

	private string TarInputActionValue = "";

	public TestState_InjectInputTriggerEvent(UObject WorldContext, string InputActionName, string InputTriggerEvent, string InputActionValue)
	{
		base.WorldContext = WorldContext;
		TarInputActionName = InputActionName;
		TarTriggerEvent = InputTriggerEvent;
		TarInputActionValue = InputActionValue;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "运行中……";
		switch (CurrentState)
		{
		case InnerState.Running:
			if (Enum.IsDefined(typeof(ETriggerEvent), TarTriggerEvent))
			{
				ETriggerEvent triggerEvent = (ETriggerEvent)Enum.Parse(typeof(ETriggerEvent), TarTriggerEvent);
				if (IsInputActionValueEnum())
				{
					FInputActionValue inputActionValueEnum = GetInputActionValueEnum();
					Description = "执行输入事件：" + TarInputActionName + " " + TarTriggerEvent + " " + TarInputActionValue;
					BGW_EventCollection.Get(WorldContext).Evt_InjectInputTriggerEvent(TarInputActionName, triggerEvent, inputActionValueEnum);
					TransferState(InnerState.Succeeded);
					break;
				}
				Description = "TarInputActionValue错误";
				return AutoTestNodeLib.NodeState.Failed;
			}
			Description = "TarTriggerEvent错误";
			return AutoTestNodeLib.NodeState.Failed;
		case InnerState.Succeeded:
			Description = "执行结束";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}

	private bool IsInputActionValueEnum()
	{
		switch (TarInputActionValue)
		{
		case "Left":
		case "True":
		case "False":
		case "Right":
		case "CompletedValue":
		case "TriggeredValue":
		case "Forward":
		case "Backward":
			return true;
		default:
			return false;
		}
	}

	private FInputActionValue GetInputActionValueEnum()
	{
		return TarInputActionValue switch
		{
			"True" => FInputActionValue.True, 
			"False" => FInputActionValue.False, 
			"Forward" => FInputActionValue.Forward, 
			"Backward" => FInputActionValue.Backward, 
			"Right" => FInputActionValue.Right, 
			"Left" => FInputActionValue.Left, 
			"TriggeredValue" => FInputActionValue.TriggeredValue, 
			"CompletedValue" => FInputActionValue.CompletedValue, 
			_ => FInputActionValue.False, 
		};
	}
}
