using b1.Plugins.Calliope;
using BtlShare;

namespace b1;

public class FTamerProcessor_LevelOfDetail : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.LevelOfDetail;

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		FTamerStrategyResult result = InContext.Result;
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		if (!currentProcessedTamer.bHasLODConfig)
		{
			return;
		}
		bool flag = false;
		ETamerPhase phase = currentProcessedTamer.Phase;
		if ((uint)phase <= 1u || (uint)(phase - 7) <= 1u)
		{
			flag = true;
		}
		if (!flag)
		{
			flag = currentProcessedTamer.GetActualResetType() == EBGUResetType.Destroy || currentProcessedTamer.NPCShowState == EGsNPCShowState.Hide || currentProcessedTamer.SpawnRuleFlags != ETamerSpawnRule.Normal || InContext.bUseOnlyList;
		}
		float x = currentProcessedTamer.LastCalcDistance.X;
		if (currentProcessedTamer.bShowingLOD)
		{
			if (flag || x > (float)currentProcessedTamer.LODMaxDistance)
			{
				result.ChangeLODDictionary[currentProcessedTamer] = false;
			}
		}
		else if (!flag && x <= (float)currentProcessedTamer.LODMaxDistance)
		{
			result.ChangeLODDictionary[currentProcessedTamer] = true;
		}
	}
}
