using System.Collections.Generic;

namespace b1;

public class FLoadingTipsRuntimeParam
{
	public List<int> LastUsedLoadingTips;

	public FLoadingTipsRuntimeParam()
	{
		LastUsedLoadingTips = new List<int>();
	}

	public override string ToString()
	{
		return "LastUsedLoadingTips: " + string.Join(", ", LastUsedLoadingTips);
	}
}
