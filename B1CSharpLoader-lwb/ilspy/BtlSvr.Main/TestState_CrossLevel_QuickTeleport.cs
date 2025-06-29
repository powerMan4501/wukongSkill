using System.Collections.Generic;
using b1;
using b1.AutoQA;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

public class TestState_CrossLevel_QuickTeleport : AutoTestNodeLib.TestState_Node
{
	public TestState_CrossLevel_QuickTeleport(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		if (BGW_GameLifeTimeMgr.Get(WorldContext).IsInFSMState(SGI_Global.InBattleStandAlone))
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.QuickTeleport", null);
			AutoTestLoggerLib.QALogInfo(WorldContext, "控制台指令：b.QuickTeleport");
			Description = "执行完成";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		Description = "还不能执行QuickTeleport  需要等待上一次传送结束";
		return AutoTestNodeLib.NodeState.Running;
	}
}
