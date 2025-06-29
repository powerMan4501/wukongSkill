namespace UnrealEngine.Runtime;

internal interface IComparableYieldInstructionCollection
{
	void Process(CoroutineGroup group);

	void OnGroupChanged(YieldInstruction instruction, CoroutineGroup oldGroup, CoroutineGroup newGroup);
}
