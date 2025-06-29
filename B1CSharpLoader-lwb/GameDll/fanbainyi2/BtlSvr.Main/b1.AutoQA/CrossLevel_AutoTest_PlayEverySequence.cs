using System.Collections.Generic;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_PlayEverySequence : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "AutoTest_PlayEverySequence";

	public override float TimeLimit => 5400f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_Invincible(base.WorldContext));
		List<int> mapIDs = new List<int> { BGUFuncLibMap.GetCurLevelId(base.WorldContext) };
		StateStack.Push(new AutoTestNodeLib.TestState_PlayEverySequence(base.WorldContext, mapIDs));
	}
}
