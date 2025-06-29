using System.Collections.Generic;

namespace b1;

internal class BUC_BattleTriggerData : b1.IBUC_BattleTriggerData
{
	public bool bAutoEnableOverlap { get; set; }

	public bool bIsEnabled { get; set; }

	public bool bIsAlwaysSpawnUnit { get; set; }

	public int EnteredPlayerCount { get; set; }

	public Dictionary<string, FBattleTriggerUnitConfigInfo> BattleUnitConfigInfos { get; set; }

	public Dictionary<string, List<string>> UnitBattleGroupInfo { get; set; }

	public List<List<string>> BattleGroups { get; set; }

	public BUC_BattleTriggerData()
	{
		bIsEnabled = (bIsAlwaysSpawnUnit = false);
		EnteredPlayerCount = 0;
		BattleUnitConfigInfos = new Dictionary<string, FBattleTriggerUnitConfigInfo>();
		UnitBattleGroupInfo = new Dictionary<string, List<string>>();
		BattleGroups = new List<List<string>>();
	}
}
