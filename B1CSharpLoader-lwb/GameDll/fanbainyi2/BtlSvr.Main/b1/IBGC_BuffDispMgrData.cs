namespace b1;

public interface IBGC_BuffDispMgrData
{
	int MaxTriggerCountPerFrame { get; }

	bool CanTrigger();
}
