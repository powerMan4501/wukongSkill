using GurGsPersistent;

namespace b1;

public interface IBIC_PersistentECSData
{
	bool FindOrAllocBUCDataByGuid(string Guid, out PersistentBUCData Ret);
}
