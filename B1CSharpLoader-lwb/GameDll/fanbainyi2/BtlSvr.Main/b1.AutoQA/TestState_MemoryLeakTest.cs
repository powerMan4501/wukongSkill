using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MemoryLeakTest : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Delay,
		StartMemoryCompare,
		MemoryLeakTest,
		End,
		Error
	}

	private InnerState CurrentState;

	private float DelayTime;

	private float CheckStandardDeviation;

	private bool HasLeak;

	private static List<long> LastMemorySize = new List<long>();

	public TestState_MemoryLeakTest(UObject WorldContext, float InCheckStandardDeviation = 0f)
	{
		base.WorldContext = WorldContext;
		HasLeak = false;
		CheckStandardDeviation = InCheckStandardDeviation;
		DelayTime = 1.8f;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.Delay:
			if (DelayTime > 0f)
			{
				Description = $"延迟{DelayTime}秒";
				DelayTime -= UGameplayStatics.GetWorldDeltaSeconds(WorldContext);
			}
			else if (CheckStandardDeviation > 0f)
			{
				Description = "比较内存开始";
				TransferState(InnerState.StartMemoryCompare);
			}
			else
			{
				Description = "内存泄漏测试开始";
				TransferState(InnerState.MemoryLeakTest);
			}
			break;
		case InnerState.StartMemoryCompare:
		{
			if (BGU_LeakLogUtil.GetUsagedMemory(out var PrivateMemorySize, out var _))
			{
				AddMemorySize(PrivateMemorySize);
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("｛");
				for (int i = 0; i < LastMemorySize.Count; i++)
				{
					stringBuilder.Append($"{LastMemorySize[i]}、");
				}
				stringBuilder.Append("｝");
				double num = StandardDeviationCheck();
				if (num > (double)CheckStandardDeviation)
				{
					Description = $"内存泄露测试失败，当前内存使用量:{PrivateMemorySize}, 上次内存使用量:{stringBuilder}，标准差:{num}";
					TransferState(InnerState.Error);
				}
				else
				{
					Description = $"内存泄露测试成功，当前内存使用量:{PrivateMemorySize}, 上次内存使用量:{stringBuilder}，标准差:{num}";
					TransferState(InnerState.MemoryLeakTest);
				}
			}
			else
			{
				Description = "未成功计算内存，进入下一步";
				TransferState(InnerState.MemoryLeakTest);
			}
			break;
		}
		case InnerState.MemoryLeakTest:
		{
			Description = "内存泄漏测试执行";
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
			HasLeak = bGW_EventCollection.Evt_LeakLogTest();
			TransferState(InnerState.End);
			break;
		}
		case InnerState.End:
			Description = "执行结束";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "执行错误";
			return AutoTestNodeLib.NodeState.Failed;
		}
		return AutoTestNodeLib.NodeState.Running;
	}

	private void AddMemorySize(long MemorySize)
	{
		LastMemorySize.Add(MemorySize);
	}

	private double StandardDeviationCheck()
	{
		if (LastMemorySize.Count > 1)
		{
			double num = 0.0;
			double num2 = LastMemorySize.Average();
			foreach (long item in LastMemorySize)
			{
				num += Math.Pow((double)item - num2, 2.0);
			}
			num /= (double)LastMemorySize.Count;
			return Math.Sqrt(num);
		}
		return 0.0;
	}

	public bool GetHasLeak()
	{
		return HasLeak;
	}
}
