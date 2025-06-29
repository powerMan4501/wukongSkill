using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class TestState_QuickTest : AutoTestNodeLib.TestState_Node
{
	public TestState_QuickTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		AutoTestHelperLib.QALog(WorldContext, BIS_AutoTestManagerV2.Get(WorldContext).IsEndCredits.ToString());
		Description = null;
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
