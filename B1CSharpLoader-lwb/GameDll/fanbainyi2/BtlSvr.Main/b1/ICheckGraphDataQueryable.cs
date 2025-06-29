using System.Collections.Generic;

namespace b1;

public interface ICheckGraphDataQueryable
{
	void CheckGraphDataQueryable(out Dictionary<string, List<string>> UnsafeNodeInfoDic);
}
