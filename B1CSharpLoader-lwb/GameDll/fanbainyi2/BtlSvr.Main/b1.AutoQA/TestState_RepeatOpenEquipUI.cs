using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_RepeatOpenEquipUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Normal,
		VerifyOpen,
		EquipUI,
		VerifyClose
	}

	private InnerState CurrentState;

	private int TickCounter;

	private int LoopNum;

	private int BreakTime;

	private int VerifyTime;

	private int CurLoopNum;

	public TestState_RepeatOpenEquipUI(UObject WorldContext, int LoopNum, int VerifyTime, int BreakTime)
	{
		base.WorldContext = WorldContext;
		this.LoopNum = LoopNum;
		this.BreakTime = BreakTime;
		this.VerifyTime = VerifyTime;
		CurLoopNum = 0;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
		if (NextState == InnerState.Normal)
		{
			CurLoopNum++;
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (LoopNum > 0 && LoopNum <= CurLoopNum)
		{
			Description = "执行完毕";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		TickCounter++;
		switch (CurrentState)
		{
		case InnerState.Normal:
			Description = "间隔中";
			if (TickCounter > BreakTime)
			{
				Description = "打开装备界面";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
				TransferState(InnerState.VerifyOpen);
			}
			break;
		case InnerState.VerifyOpen:
			Description = "准备验证打开状态";
			if (TickCounter > VerifyTime)
			{
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets2, "设置");
				if (FoundWidgets2.Count <= 0)
				{
					Description = "没有进入装备界面!";
					return AutoTestNodeLib.NodeState.Failed;
				}
				TransferState(InnerState.EquipUI);
				Description = "处于打开状态";
			}
			break;
		case InnerState.EquipUI:
			Description = "间隔中";
			if (TickCounter > BreakTime)
			{
				Description = "关闭装备界面";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
				TransferState(InnerState.VerifyClose);
			}
			break;
		case InnerState.VerifyClose:
			Description = "准备验证关闭状态";
			if (TickCounter > VerifyTime)
			{
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets, "设置");
				if (FoundWidgets.Count > 0)
				{
					Description = "没有退出装备界面!";
					return AutoTestNodeLib.NodeState.Failed;
				}
				TransferState(InnerState.Normal);
				Description = "处于关闭状态";
			}
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		return AutoTestNodeLib.NodeState.Running;
	}
}
