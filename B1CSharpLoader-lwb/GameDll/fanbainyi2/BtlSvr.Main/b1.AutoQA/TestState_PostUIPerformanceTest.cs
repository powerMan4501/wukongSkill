using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_PostUIPerformanceTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ResetConfig,
		PostLogic
	}

	private int TickCounter;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_PostUIPerformanceTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		switch (CurrentState)
		{
		case InnerState.ResetConfig:
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "DebugConfig.IsShowDebugDrawUI 0", null);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "Trace.Stop", null);
			TransferState(InnerState.PostLogic);
			TickCounter++;
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.PostLogic:
			BGW_UIEventCollection.Get(WorldContext)?.Evt_UI_UITrackerCheckReport();
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
