using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_QuestCheckerData
{
	public List<AActor> CheckedActors { get; } = new List<AActor>();

	public bool bEnableCheck { get; set; }
}
