using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_AdjustRoleDataByID : AutoTestNodeLib.TestState_Node
{
	private readonly int GroupID;

	public TestState_AdjustRoleDataByID(UObject WorldContext, int ID)
	{
		base.WorldContext = WorldContext;
		GroupID = ID;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		DebugConfig.DebugReInitRoleCheck = false;
		BGUFunctionLibraryManaged.RunScriptGM($"ReInitRoleData {GroupID}", WorldContext);
		Description = $"读取了套装{GroupID}";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
