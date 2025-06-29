using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_UnitDestructibleManagerData : IPersistentECSData
{
	public Dictionary<TSoftObject<UChildActorComponent>, TSubclassOf<AActor>> DestructibleTypeInfos;

	public BUC_UnitDestructibleManagerData()
	{
		DestructibleTypeInfos = new Dictionary<TSoftObject<UChildActorComponent>, TSubclassOf<AActor>>();
	}
}
