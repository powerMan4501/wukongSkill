namespace b1.AutoQA;

internal class CrossLevel_AutoTest_AllUI : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "遍历全部UI测试";

	public override float TimeLimit => 10800f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 100));
		StateStack.Push(new TestState_MemTestPrepare(base.WorldContext));
		StateStack.Push(new TestState_PreTraversalAllUI(base.WorldContext));
		StateStack.Push(new TestState_TraversalLegacyUI(base.WorldContext, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalTravelNotesUI(base.WorldContext, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalEquipmentUI(base.WorldContext, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalBagUI(base.WorldContext, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_PostTraversalAllUI(base.WorldContext));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreTraversalAllUI.memreport", "PostTraversalAllUI.memreport"));
	}
}
