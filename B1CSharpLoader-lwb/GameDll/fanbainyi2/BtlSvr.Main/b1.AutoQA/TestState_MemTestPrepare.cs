using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MemTestPrepare : AutoTestNodeLib.TestState_Node
{
	private int TickCounter;

	public TestState_MemTestPrepare(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		USystemLibrary.ExecuteConsoleCommand(WorldContext, "r.Streaming.PoolSize 10", null);
		Description = "准备完毕，继续向下";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
