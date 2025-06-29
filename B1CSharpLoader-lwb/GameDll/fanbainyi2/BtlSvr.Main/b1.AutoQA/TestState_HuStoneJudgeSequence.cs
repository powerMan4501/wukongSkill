using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_HuStoneJudgeSequence : AutoTestNodeLib.TestState_Node
{
	public TestState_HuStoneJudgeSequence(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
		{
			if (AutoTestHelperLib.HasSpell(WorldContext, 5202))
			{
				StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext));
				Description = "虽然已经有铜头铁臂了，但是还要看一下片子";
				return AutoTestNodeLib.NodeState.Pause;
			}
			StateStack.Push(new AutoTestNodeLib.TestState_GetNewItem(WorldContext, 5202));
			StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(WorldContext, 5202));
			Description = "先看一个播片, 来获得新法术, 铜头铁臂";
			return AutoTestNodeLib.NodeState.Pause;
		}
		Description = "已经获得了铜头铁臂，继续向下走";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
