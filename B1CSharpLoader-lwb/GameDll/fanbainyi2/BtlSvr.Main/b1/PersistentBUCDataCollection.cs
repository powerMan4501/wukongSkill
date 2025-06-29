using System.Collections.Generic;
using GurGsPersistent;

namespace b1;

public class PersistentBUCDataCollection
{
	public PersistentBUCDataWithLevel PersistentBUCDataWithLevel;

	public Dictionary<string, PersistentBUCData> BUCDatasMap = new Dictionary<string, PersistentBUCData>();
}
