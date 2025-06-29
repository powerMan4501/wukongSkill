using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ZhenFengMenJudgeSequence : AutoTestNodeLib.TestState_Node
{
	public TestState_ZhenFengMenJudgeSequence(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
		{
			if (AutoTestHelperLib.HasSpell(WorldContext, 5301))
			{
				StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext));
				Description = "虽然已经有身外身法了，但是还要看一下片子";
				return AutoTestNodeLib.NodeState.Pause;
			}
			StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext, 5301));
			Description = "先看一个播片, 来获得新法术, 身外身法";
			return AutoTestNodeLib.NodeState.Pause;
		}
		Description = "已经获得了身外身法，继续向下走";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
