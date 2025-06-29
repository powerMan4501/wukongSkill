namespace b1.AutoQA;

internal class CrossLevel_AutoTest_TeleportMemory : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "跨地图传送内存测试";

	public override float TimeLimit => 7200f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_TeleportMemory(base.WorldContext, StateStack));
	}
}
