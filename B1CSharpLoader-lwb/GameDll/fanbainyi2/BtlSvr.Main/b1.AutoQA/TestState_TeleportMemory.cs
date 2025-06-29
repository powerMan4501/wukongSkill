using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TeleportMemory : AutoTestNodeLib.TestState_Node
{
	public TestState_TeleportMemory(UObject WorldContext, Stack<AutoTestNodeLib.TestState_Node> StateStack, bool IsReverse = false)
	{
		base.WorldContext = WorldContext;
		if (!IsReverse)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 100));
			StateStack.Push(new TestState_MemTestPrepare(WorldContext));
			StateStack.Push(new TestState_PreTeleportMemory(WorldContext));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 10));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 20));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 30));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 40));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 50));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 70));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 80));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 11));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 13));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 25));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 61));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 62));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 92));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 98));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 31, IsUseTeleportToLevelPosition: true));
			StateStack.Push(new TestState_PostTeleportMemory(WorldContext));
			StateStack.Push(new TestState_MemReportAnalysis(WorldContext, "PreTeleportMemory.memreport", "PostTeleportMemory.memreport"));
		}
		else
		{
			StateStack.Push(new TestState_MemReportAnalysis(WorldContext, "PreTeleportMemory.memreport", "PostTeleportMemory.memreport"));
			StateStack.Push(new TestState_PostTeleportMemory(WorldContext));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 31, IsUseTeleportToLevelPosition: true));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 20));
			StateStack.Push(new TestState_PreTeleportMemory(WorldContext));
			StateStack.Push(new TestState_LevelSmoke(WorldContext, 31, IsUseTeleportToLevelPosition: true));
		}
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "跨地图传送内存测试";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
