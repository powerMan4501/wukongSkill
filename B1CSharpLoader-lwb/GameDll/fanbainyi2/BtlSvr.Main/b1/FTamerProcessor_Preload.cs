using b1.BGW;

namespace b1;

public class FTamerProcessor_Preload : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.Preload;

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		FTamerStrategyResult result = InContext.Result;
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		float num = currentProcessedTamer.LastCalcDistance.X;
		if (B1Global.GIsBossRushMode)
		{
			num = 0f;
		}
		EUnitPreloadLevel value = EUnitPreloadLevel.None;
		ETamerPreloadLevel value2 = ETamerPreloadLevel.None;
		switch (currentProcessedTamer.Phase)
		{
		case ETamerPhase.Loaded:
			if (num <= FTamerStrategyPreDefines.PreloadDistanceLoadMonsterClass)
			{
				value2 = ETamerPreloadLevel.LoadMonsterClass;
			}
			if (num >= FTamerStrategyPreDefines.PreloadDistanceUnLoadMonsterClass)
			{
				value2 = ETamerPreloadLevel.UnLoadMonsterClass;
			}
			if (num < FTamerStrategyPreDefines.PreloadDistanceFarthest)
			{
				value = EUnitPreloadLevel.Low;
				if (num < FTamerStrategyPreDefines.PreloadDistanceMedium)
				{
					value = EUnitPreloadLevel.High;
				}
			}
			break;
		case ETamerPhase.Visible:
		case ETamerPhase.PreBegunPlay:
		case ETamerPhase.Spawned:
			return;
		case ETamerPhase.UnLoaded:
		case ETamerPhase.Dead:
			value = EUnitPreloadLevel.None;
			value2 = ETamerPreloadLevel.UnLoadMonsterClass;
			break;
		}
		result.PreloadTamers.Add(currentProcessedTamer, value);
		result.PreloadTamersForMonsterClass.Add(currentProcessedTamer, value2);
	}
}
