using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_QuitEditor : AutoTestNodeLib.TestState_Node
{
	public TestState_QuitEditor(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		UGSE_EngineFuncLib.QuitEditor();
		Description = "关闭 Editor";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
