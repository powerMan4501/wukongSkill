using System.Collections.Generic;

namespace b1;

public class FBuffTriggerConfig
{
	public List<int> AddBuffIDList;

	public EBuffControlCondition AddBuffCondition;

	public EBuffTarget AddBuffTarget;

	public List<int> RemoveBuffIDList;

	public EBuffControlCondition RemoveBuffCondition;

	public EBuffTarget RemoveBuffTarget;

	public List<string> AddSceneUnitGuidList { get; } = new List<string>();

	public List<string> RemoveSceneUnitGuidList { get; } = new List<string>();

	public FBuffTriggerConfig(FGSBuffTriggerConfig BuffTriggerConfig)
	{
		AddBuffIDList = BuffTriggerConfig.AddBuffIDList;
		AddBuffCondition = BuffTriggerConfig.AddBuffCondition;
		AddBuffTarget = BuffTriggerConfig.AddBuffTarget;
		foreach (FGsActorGuidReference item in BuffTriggerConfig.AddSceneTamerRef)
		{
			AddSceneUnitGuidList.Add(item.ActorGuid);
		}
		RemoveBuffIDList = BuffTriggerConfig.RemoveBuffIDList;
		RemoveBuffCondition = BuffTriggerConfig.RemoveBuffCondition;
		RemoveBuffTarget = BuffTriggerConfig.RemoveBuffTarget;
		foreach (FGsActorGuidReference item2 in BuffTriggerConfig.RemoveSceneTamerRef)
		{
			RemoveSceneUnitGuidList.Add(item2.ActorGuid);
		}
	}
}
