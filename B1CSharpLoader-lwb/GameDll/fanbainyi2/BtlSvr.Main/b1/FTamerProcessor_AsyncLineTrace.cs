using System.Collections.Generic;

namespace b1;

public class FTamerProcessor_AsyncLineTrace : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.AsyncLineTrace;

	private BGW_EventCollection BGWEventCollection { get; set; }

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		if (B1Global.GIsBossRushMode)
		{
			return;
		}
		if (BGWEventCollection == null)
		{
			BGWEventCollection = BGW_EventCollection.Get(InContext.Owner);
		}
		if (BGWEventCollection == null)
		{
			return;
		}
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		if (!currentProcessedTamer.bPatrolUnit && currentProcessedTamer.LastCalcDistance.X <= FTamerStrategyPreDefines.AsyncTraceMaxEffectRange)
		{
			List<int> needLineTraceTamers = InContext.Result.NeedLineTraceTamers;
			int count = needLineTraceTamers.Count;
			int i;
			for (i = 0; i < count && needLineTraceTamers[i] < currentProcessedTamer.RefID; i++)
			{
			}
			needLineTraceTamers.Insert(i, currentProcessedTamer.RefID);
		}
	}
}
