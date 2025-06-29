using b1.ECS;

namespace b1;

public class BGC_BuffDispMgrData : IBGC_BuffDispMgrData, IPersistentECSData
{
	public int GlobalMaxTriggerCountPerFrame;

	public int GlobalTriggerCounterPerFrame;

	public int MaxTriggerCountPerFrame { get; set; }

	public bool CanTrigger()
	{
		return GlobalTriggerCounterPerFrame < GlobalMaxTriggerCountPerFrame;
	}
}
