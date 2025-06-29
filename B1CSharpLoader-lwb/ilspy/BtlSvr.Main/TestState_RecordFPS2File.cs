using System.Collections.Generic;
using b1.AutoQA;
using UnrealEngine.Runtime;

public class TestState_RecordFPS2File : AutoTestNodeLib.TestState_Node
{
	private readonly string RecordFilePath;

	private readonly string TamerBP;

	public TestState_RecordFPS2File(UObject WorldContext, string RecordFilePath, string TamerBP)
	{
		base.WorldContext = WorldContext;
		this.RecordFilePath = RecordFilePath;
		this.TamerBP = TamerBP;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
