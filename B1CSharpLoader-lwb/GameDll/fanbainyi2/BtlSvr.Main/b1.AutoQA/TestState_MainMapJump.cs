using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MainMapJump : AutoTestNodeLib.TestState_Node
{
	private int[,] MainMapTable = new int[3, 3];

	public List<int> CreateMapSeq()
	{
		List<int> list = new List<int>();
		int num = 0;
		list.Add(num);
		while (true)
		{
			bool flag = false;
			for (int i = 0; i < 3; i++)
			{
				if (num != i && MainMapTable[num, i] == 0)
				{
					list.Add(i);
					MainMapTable[num, i] = 1;
					num = i;
					flag = true;
					break;
				}
			}
			if (flag)
			{
				continue;
			}
			bool flag2 = false;
			for (int j = 0; j < 3; j++)
			{
				if (flag2)
				{
					break;
				}
				for (int k = 0; k < 3; k++)
				{
					if (j != k && MainMapTable[j, k] == 0)
					{
						list.Add(j);
						num = j;
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				break;
			}
		}
		return list;
	}

	private void AddTestNodebyIndex(int Index, ref Stack<AutoTestNodeLib.TestState_Node> TargetStack)
	{
		switch (Index)
		{
		case 0:
			TargetStack.Push(new AutoTestNodeLib.TestState_TestBegin(WorldContext, 2003, "RebirthPoint_HFM_Default_C_1", 20101101));
			break;
		case 1:
			TargetStack.Push(new AutoTestNodeLib.TestState_TestBegin(WorldContext, 1008, "RebirthPoint_HFS_C_4", 10101102));
			break;
		case 2:
			TargetStack.Push(new AutoTestNodeLib.TestState_TestBegin(WorldContext, 5002, "RebirthPoint_HYS_Default_C_1", 50101101));
			break;
		}
	}

	public TestState_MainMapJump(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public void AddJumpMapStack(ref Stack<AutoTestNodeLib.TestState_Node> TargetStack)
	{
		List<int> list = CreateMapSeq();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			AddTestNodebyIndex(list[num], ref TargetStack);
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> TargetStack, float DeltaTime)
	{
		Description = "不需要执行，使用AddJumpMapStack函数添加指令";
		return AutoTestNodeLib.NodeState.Failed;
	}
}
