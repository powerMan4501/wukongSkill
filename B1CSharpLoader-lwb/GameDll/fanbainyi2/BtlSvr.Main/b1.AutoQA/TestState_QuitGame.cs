using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_QuitGame : AutoTestNodeLib.TestState_Node
{
	public TestState_QuitGame(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "退出游戏";
		UGSE_EngineFuncLib.QuitGame(WorldContext);
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
