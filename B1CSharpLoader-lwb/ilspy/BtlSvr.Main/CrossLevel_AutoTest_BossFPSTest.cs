using b1.AutoQA;
using b1.BGW;

internal class CrossLevel_AutoTest_BossFPSTest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "BossFPSTest";

	public override float TimeLimit => 600f;

	public override CaseType GetCaseType()
	{
		return CaseType.AutoReset;
	}

	protected override void RegisterTestState()
	{
		string text = "BGWDataAsset_TamerListConfig'/Game/3rd/QATest/DA_QABossList.DA_QABossList'";
		foreach (string command in BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(text, ELoadResourceType.SyncLoadAndCache).CommandList)
		{
			StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, command));
		}
		StateStack.Push(new TestState_ATPAllBossFPSTest(base.WorldContext, text, QuitBiuPerUnit: true));
	}
}
