using System.Collections.Generic;

namespace b1;

public static class FServantPhaseProcessorFactory
{
	public static Dictionary<EServantPhase, FServantInstanceBase.FServantPhaseProcessorBase> InstanceMapping { get; }

	static FServantPhaseProcessorFactory()
	{
		InstanceMapping = new Dictionary<EServantPhase, FServantInstanceBase.FServantPhaseProcessorBase>();
		InstanceMapping[EServantPhase.Tamer] = new FServantInstanceBase.FServantPhaseProcessor_Tamer();
		InstanceMapping[EServantPhase.BeginSpawnActor] = new FServantInstanceBase.FServantPhaseProcessor_BeginSpawnActor();
		InstanceMapping[EServantPhase.ECSPreBeginPlayFinished] = new FServantInstanceBase.FServantPhaseProcessor_ECSPreBeginPlayFinished();
		InstanceMapping[EServantPhase.Unit] = new FServantInstanceBase.FServantPhaseProcessor_Unit();
		InstanceMapping[EServantPhase.LifeOver] = new FServantInstanceBase.FServantPhaseProcessor_LifeOver();
		InstanceMapping[EServantPhase.Dead] = new FServantInstanceBase.FServantPhaseProcessor_Dead();
		InstanceMapping[EServantPhase.Destroyed] = new FServantInstanceBase.FServantPhaseProcessor_Destroyed();
	}

	public static FServantInstanceBase.FServantPhaseProcessorBase GetInstance(EServantPhase InInstanceKey)
	{
		if (InstanceMapping.TryGetValue(InInstanceKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetAllInstances(out IReadOnlyDictionary<EServantPhase, FServantInstanceBase.FServantPhaseProcessorBase> OutAllInstances)
	{
		OutAllInstances = InstanceMapping;
		return OutAllInstances.Count;
	}
}
