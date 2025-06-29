using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_QuestPlayerCheckerData : IBUC_QuestPlayerCheckerData, IPersistentECSData
{
	public List<AActor> CheckedActors { get; } = new List<AActor>();

	public bool bEnableCheck { get; set; }

	public int GetCheckedActorsCount()
	{
		return CheckedActors.Count;
	}
}
