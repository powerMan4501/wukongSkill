using System.Collections.Generic;

namespace b1;

public static class FSummonProcessorFactory
{
	public static Dictionary<ESummonProcessorTag, FSummonProcessorBase> InstanceMapping { get; }

	static FSummonProcessorFactory()
	{
		InstanceMapping = new Dictionary<ESummonProcessorTag, FSummonProcessorBase>();
		InstanceMapping[ESummonProcessorTag.Start] = new FSummonProcessor_Default();
		InstanceMapping[ESummonProcessorTag.SelectPoints] = new FSummonProcessor_SelectPoints();
		InstanceMapping[ESummonProcessorTag.AdjustPointTransform] = new FSummonProcessor_AdjustPointTransform();
		InstanceMapping[ESummonProcessorTag.GenerateSpawnInfo] = new FSummonProcessor_GenerateSpawnInfo();
		InstanceMapping[ESummonProcessorTag.Spawn] = new FSummonProcessor_Spawn();
		InstanceMapping[ESummonProcessorTag.Exception] = new FSummonProcessor_Exception();
		InstanceMapping[ESummonProcessorTag.Finished] = new FSummonProcessor_Finished();
	}

	public static FSummonProcessorBase GetInstance(ESummonProcessorTag InInstanceKey)
	{
		if (InstanceMapping.TryGetValue(InInstanceKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetAllInstances(out IReadOnlyDictionary<ESummonProcessorTag, FSummonProcessorBase> OutAllInstances)
	{
		OutAllInstances = InstanceMapping;
		return OutAllInstances.Count;
	}
}
