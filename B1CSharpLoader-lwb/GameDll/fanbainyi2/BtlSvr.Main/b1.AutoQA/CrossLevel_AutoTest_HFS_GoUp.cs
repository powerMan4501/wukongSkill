namespace b1.AutoQA;

internal class CrossLevel_AutoTest_HFS_GoUp : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "HFS_7_1_见谛峰火起";

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 1012, "RebirthPoint_HFS_C_11", 10101102));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "TAMER_hfm_niu_01_C_0", "HFS01_Monster_Mountaintop", "山腰青牛精"));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFS_C_4", "见谛峰"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFS_C_4", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}
}
