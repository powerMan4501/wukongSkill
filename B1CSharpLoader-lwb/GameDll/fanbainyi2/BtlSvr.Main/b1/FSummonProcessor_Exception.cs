namespace b1;

public class FSummonProcessor_Exception : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.Exception;

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		InSummonInstance.SummonProcessorData.bSummoning = false;
		InSummonInstance.ShutdownSummon();
		return false;
	}
}
