using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_QAQuitGame : AutoTestNodeLib.TestState_Node
{
	public TestState_QAQuitGame(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> _, float DeltaTime)
	{
		BIS_AutoTestManagerV2.Get(WorldContext).QAQuitGame();
		Description = "执行了退出，游戏逻辑可能有异常";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
