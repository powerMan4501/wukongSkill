namespace b1;

public class FSummonProcessor_Finished : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.Finished;

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		InSummonInstance.SummonProcessorData.bSummoning = false;
		return false;
	}
}
