using System.Collections.Generic;

namespace b1;

public static class FTamerProcessorFactory
{
	public static Dictionary<EProcessorSequence, FTamerProcessorBase> InstanceMapping { get; }

	static FTamerProcessorFactory()
	{
		InstanceMapping = new Dictionary<EProcessorSequence, FTamerProcessorBase>();
		InstanceMapping[EProcessorSequence.Head] = new FTamerProcessor_Head();
		InstanceMapping[EProcessorSequence.DistanceSpawn] = new FTamerProcessor_DistanceSpawn();
		InstanceMapping[EProcessorSequence.CalcDistance] = new FTamerProcessor_CalcDistance();
		InstanceMapping[EProcessorSequence.FilterRule] = new FTamerProcessor_FilterRule();
		InstanceMapping[EProcessorSequence.AsyncLineTrace] = new FTamerProcessor_AsyncLineTrace();
		InstanceMapping[EProcessorSequence.AsyncTraceSpawn] = new FTamerProcessor_AsyncTraceSpawn();
		InstanceMapping[EProcessorSequence.LevelOfDetail] = new FTamerProcessor_LevelOfDetail();
		InstanceMapping[EProcessorSequence.Preload] = new FTamerProcessor_Preload();
	}

	public static FTamerProcessorBase GetInstance(EProcessorSequence InInstanceKey)
	{
		if (InstanceMapping.TryGetValue(InInstanceKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetAllInstances(out IReadOnlyDictionary<EProcessorSequence, FTamerProcessorBase> OutAllInstances)
	{
		OutAllInstances = InstanceMapping;
		return OutAllInstances.Count;
	}
}
