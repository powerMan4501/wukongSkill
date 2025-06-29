using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_BattleFieldPerformanceOptData : IBGC_BattleFieldPerformanceOptData, IPersistentECSData
{
	public bool IsConfigSetted;

	public BGWDataAsset_BattleFieldPerformanceOptConfig OptConfig;

	public float TickIntervalTime;

	public Dictionary<string, BattleFieldMonitor_UnitInfo> BattleFieldMonitorDic;

	public HashSet<string> NeedOptUnitList;

	public bool bUnitNeedOpt(string UnitGuid)
	{
		return NeedOptUnitList.Contains(UnitGuid);
	}

	public BGC_BattleFieldPerformanceOptData()
	{
		BattleFieldMonitorDic = new Dictionary<string, BattleFieldMonitor_UnitInfo>();
		NeedOptUnitList = new HashSet<string>();
	}
}
