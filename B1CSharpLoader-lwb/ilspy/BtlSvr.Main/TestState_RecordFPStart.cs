using System;
using System.Collections.Generic;
using b1;
using b1.AutoQA;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

public class TestState_RecordFPStart : AutoTestNodeLib.TestState_Node
{
	public TestState_RecordFPStart(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.QAStartRecordFPS", null);
		BIS_AutoTestManagerV2.Get(WorldContext).SomeStartTime = DateTime.Now;
		Description = "开启了帧率统计";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
