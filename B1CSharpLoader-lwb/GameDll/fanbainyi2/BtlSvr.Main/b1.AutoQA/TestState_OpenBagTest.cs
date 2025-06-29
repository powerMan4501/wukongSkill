using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class TestState_OpenBagTest : AutoTestNodeLib.TestState_Node
{
	private int TickCounter;

	public TestState_OpenBagTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (TickCounter == 0)
		{
			AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
		}
		else if (TickCounter == 15)
		{
			AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
		}
		else if (TickCounter == 20)
		{
			Description = "开包测试完成";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		TickCounter++;
		Description = "简易开包测试中";
		return AutoTestNodeLib.NodeState.Running;
	}
}
