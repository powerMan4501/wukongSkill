using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_HairMgrData
{
	public Dictionary<int, SetCurveValueToHairUnitInfo> SetCurveValueToHairDic;

	public Dictionary<int, Dictionary<FName, int>> MatParameterLayerIndexCache;

	public BUC_HairMgrData()
	{
		SetCurveValueToHairDic = new Dictionary<int, SetCurveValueToHairUnitInfo>();
		MatParameterLayerIndexCache = new Dictionary<int, Dictionary<FName, int>>();
	}
}
