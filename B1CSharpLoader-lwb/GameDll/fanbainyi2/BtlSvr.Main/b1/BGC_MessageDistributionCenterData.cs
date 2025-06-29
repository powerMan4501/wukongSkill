using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_MessageDistributionCenterData : IPersistentECSData
{
	public Dictionary<string, BattleSCInfo> BattleSCInfoDict = new Dictionary<string, BattleSCInfo>();
}
