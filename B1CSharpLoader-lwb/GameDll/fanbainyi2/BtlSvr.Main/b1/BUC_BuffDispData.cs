using System.Collections.Generic;

namespace b1;

public class BUC_BuffDispData
{
	public Dictionary<long, FBuffDispInstance> BuffDispInstances { get; } = new Dictionary<long, FBuffDispInstance>();

	public List<int> PendingBuffDispList { get; } = new List<int>();

	public MultiMap<int, int> Buff2DispGroupMultiMap { get; } = new MultiMap<int, int>();

	public Dictionary<int, long> DispGroupID2InstanceIDMap { get; } = new Dictionary<int, long>();

	public List<long> HiddenBuffDispInstances { get; } = new List<long>();

	public List<int> HiddenPendingBuffID { get; } = new List<int>();
}
