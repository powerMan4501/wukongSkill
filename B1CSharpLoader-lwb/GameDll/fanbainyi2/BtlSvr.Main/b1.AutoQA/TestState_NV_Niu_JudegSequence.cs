using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_NV_Niu_JudegSequence : AutoTestNodeLib.TestState_Node
{
	private int TickCounter;

	public TestState_NV_Niu_JudegSequence(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		TickCounter++;
		if (TickCounter < 10)
		{
			Description = "等待青牛精上挑中";
			return AutoTestNodeLib.NodeState.Running;
		}
		if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
		{
			if (AutoTestHelperLib.HasSpell(WorldContext, 5101))
			{
				StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext));
				Description = "虽然已经有定身术了，但是还要看一下片子";
				return AutoTestNodeLib.NodeState.Pause;
			}
			StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext, 5101));
			Description = "先看一个播片, 来获得新法术, 定身术";
			return AutoTestNodeLib.NodeState.Pause;
		}
		Description = "已经获得了定身术，继续向下走";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
