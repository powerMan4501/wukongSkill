using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_StartMemoryLeakTest : AutoTestNodeLib.TestState_Node
{
	public TestState_StartMemoryLeakTest(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "开始内存泄露测试";
		DebugConfig.EventMemoryLeakTest = true;
		StrongPtrLeakDetection.SetEventMemoryLeakTest(DebugConfig.EventMemoryLeakTest);
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
