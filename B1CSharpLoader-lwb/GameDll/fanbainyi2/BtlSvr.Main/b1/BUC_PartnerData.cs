using System.Collections.Generic;

namespace b1;

public class BUC_PartnerData
{
	public EntitySharedRef TeamMngEntityRef;

	public HashSet<int> TeamIDList;

	public BUC_PartnerData()
	{
		TeamMngEntityRef = null;
		TeamIDList = new HashSet<int>();
	}
}
