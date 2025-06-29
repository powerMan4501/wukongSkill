using System.Collections.Generic;
using BtlB1;

namespace b1;

public class FPartHitExpandInfo
{
	public List<FPartHitAttrRecoverConfig> PartHitAttrConfigList;

	public FPartHitExpandInfo()
	{
		PartHitAttrConfigList = new List<FPartHitAttrRecoverConfig>();
	}

	public FPartHitExpandInfo(FUStPartHitExpandDesc PartHitExpandDesc)
	{
		PartHitAttrConfigList = new List<FPartHitAttrRecoverConfig>();
		if (PartHitExpandDesc == null)
		{
			return;
		}
		foreach (FUStPartHitAttrRecoverConfig partHitAttrRecover in PartHitExpandDesc.PartHitAttrRecoverList)
		{
			PartHitAttrConfigList.Add(new FPartHitAttrRecoverConfig(partHitAttrRecover));
		}
	}
}
