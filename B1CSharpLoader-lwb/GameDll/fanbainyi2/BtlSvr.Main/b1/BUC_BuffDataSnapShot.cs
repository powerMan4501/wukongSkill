using System.Collections.Generic;

namespace b1;

public class BUC_BuffDataSnapShot
{
	public Dictionary<int, BuffInstDataSnapShot> BuffInstsDict = new Dictionary<int, BuffInstDataSnapShot>();

	public bool bShouldUpdateBuffTime;
}
