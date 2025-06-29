using System.Collections.Generic;

namespace b1;

public class BUC_DecalMgrData : b1.IBUC_DecalMgrData
{
	public Dictionary<int, FTireMarkUnit> TireMarks { get; set; }

	public BUC_DecalMgrData()
	{
		TireMarks = new Dictionary<int, FTireMarkUnit>();
	}
}
