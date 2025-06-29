namespace b1;

public class FSummonProcessor_Default : FSummonProcessorBase
{
	public override ESummonProcessorTag Tag => ESummonProcessorTag.Start;

	protected override bool RunProcessor(FSummonInstance InSummonInstance)
	{
		InSummonInstance.SummonProcessorData.bSummoning = true;
		return true;
	}

	protected override ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		return ESummonProcessorTag.SelectPoints;
	}
}
