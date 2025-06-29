using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_IterateLoadingScreen : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Open,
		Next,
		Close
	}

	private int CurrentIndex = 1;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
	}

	public TestState_IterateLoadingScreen(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.Open:
			BGW_LoadingTipsMgr.Get(WorldContext).OpenLoadingScreenPreview();
			TransferState(InnerState.Next);
			Description = "打开了LoadingScreenPreview";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.Next:
			if (CurrentIndex < BGW_LoadingTipsMgr.Get(WorldContext).GetLoadingScreenPreviewTipsCount())
			{
				BGW_LoadingTipsMgr.Get(WorldContext).SwitchLoadingScreenPreview();
				CurrentIndex++;
			}
			else
			{
				TransferState(InnerState.Close);
			}
			Description = "观看LoadingScreenPreview中";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.Close:
			BGW_LoadingTipsMgr.Get(WorldContext).CloseLoadingScreenPreview();
			Description = "关闭了LoadingScreenPreview";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
