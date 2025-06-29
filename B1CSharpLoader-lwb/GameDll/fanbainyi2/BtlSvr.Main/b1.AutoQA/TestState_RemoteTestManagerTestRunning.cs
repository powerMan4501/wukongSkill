using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_RemoteTestManagerTestRunning : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Running,
		Succeeded
	}

	private InnerState CurrentState;

	private int TickCounter;

	public TestState_RemoteTestManagerTestRunning(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
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
			if (TickCounter > 10)
			{
				TransferState(InnerState.Succeeded);
			}
			break;
		case InnerState.Succeeded:
			Description = "成功状态";
			if (TickCounter > 3)
			{
				Description = "运行结束";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
