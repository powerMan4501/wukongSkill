using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal interface IBUC_DestructibleDestroyEffectTriggerData
{
	FName DestructibleTag { get; }

	List<int> EffectIDs { get; }

	List<int> BuffIDs { get; }
}
