using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BGC_TaskCollectionMgrData : IBGC_TaskCollectionMgrData, IPersistentECSData
{
	public Dictionary<string, AActor> TaskCollectionDict { get; } = new Dictionary<string, AActor>();
}
