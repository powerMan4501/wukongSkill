namespace b1.AutoQA;

internal class CrossLevel_AutoTest_LevelSmokeTest : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public override string TestLabel => "AutoTest_CrossLevels";

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 10));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 11));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 20));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 25));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 30));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 31));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 92));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 40));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 80));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 50));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 70));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 98));
		StateStack.Push(new TestState_LevelSmoke(base.WorldContext, 62));
	}
}
