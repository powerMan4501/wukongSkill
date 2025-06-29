using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DestructibleDestroyEffectTriggerData : b1.IBUC_DestructibleDestroyEffectTriggerData, IPersistentECSData
{
	public FName DestructibleTag { get; set; }

	public List<int> EffectIDs { get; set; }

	public List<int> BuffIDs { get; set; }
}
