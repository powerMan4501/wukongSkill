using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ContinueExecKeyInputList : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		ExecKeyInput,
		KeyInputInterval,
		BreakState
	}

	private InnerState CurrentState;

	private int TickCounter;

	private List<QASimulateWindowsOperations.KeyCode> KeyInputList;

	private List<int> InputIntervalList;

	private int LoopNum;

	private int BreakTime;

	private int CurExecKeyIndex;

	private int CurExecLoopNum;

	public TestState_ContinueExecKeyInputList(UObject WorldContext, List<QASimulateWindowsOperations.KeyCode> KeyInputList, List<int> InputIntervalList, int LoopNum, int BreakTime)
	{
		base.WorldContext = WorldContext;
		this.KeyInputList = KeyInputList;
		this.InputIntervalList = InputIntervalList;
		this.LoopNum = LoopNum;
		this.BreakTime = BreakTime;
		CurExecKeyIndex = 0;
		CurExecLoopNum = 0;
	}

	public TestState_ContinueExecKeyInputList(UObject WorldContext, List<string> KeyInputList, List<int> InputIntervalList, int LoopNum, int BreakTime)
	{
		base.WorldContext = WorldContext;
		List<QASimulateWindowsOperations.KeyCode> list = new List<QASimulateWindowsOperations.KeyCode>();
		foreach (string KeyInput in KeyInputList)
		{
			if (Enum.TryParse<QASimulateWindowsOperations.KeyCode>(KeyInput, out var result))
			{
				list.Add(result);
			}
		}
		this.KeyInputList = list;
		this.InputIntervalList = InputIntervalList;
		this.LoopNum = LoopNum;
		this.BreakTime = BreakTime;
		CurExecKeyIndex = 0;
		CurExecLoopNum = 0;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	private void MoveToNextKeyIndex()
	{
		TransferState(InnerState.ExecKeyInput);
		CurExecKeyIndex++;
		if (CurExecKeyIndex >= KeyInputList.Count)
		{
			CurExecLoopNum++;
			if (BreakTime <= 0)
			{
				TransferState(InnerState.ExecKeyInput);
			}
			else
			{
				TransferState(InnerState.BreakState);
			}
			CurExecKeyIndex = 0;
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (LoopNum > 0 && LoopNum <= CurExecLoopNum)
		{
			Description = "所有输入执行完毕";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		switch (CurrentState)
		{
		case InnerState.ExecKeyInput:
			Description = $"模拟输入按键：{KeyInputList[CurExecKeyIndex]}";
			QASimulateWindowsOperations.KeyPress(KeyInputList[CurExecKeyIndex]);
			if (InputIntervalList[CurExecKeyIndex] <= 0)
			{
				MoveToNextKeyIndex();
			}
			else
			{
				TransferState(InnerState.KeyInputInterval);
			}
			break;
		case InnerState.KeyInputInterval:
			Description = "输入间隔中";
			if (TickCounter >= InputIntervalList[CurExecKeyIndex])
			{
				MoveToNextKeyIndex();
			}
			break;
		case InnerState.BreakState:
			Description = "输入循环休息中";
			if (TickCounter >= BreakTime)
			{
				TransferState(InnerState.ExecKeyInput);
			}
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
