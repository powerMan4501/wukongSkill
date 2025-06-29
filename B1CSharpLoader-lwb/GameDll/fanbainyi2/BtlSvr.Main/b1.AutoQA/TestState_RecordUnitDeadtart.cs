using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_RecordUnitDeadtart : AutoTestNodeLib.TestState_Node
{
	public TestState_RecordUnitDeadtart(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		BIS_AutoTestManagerV2.Get(WorldContext).SomeStartTime = DateTime.Now;
		Description = "开启了帧率统计";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
