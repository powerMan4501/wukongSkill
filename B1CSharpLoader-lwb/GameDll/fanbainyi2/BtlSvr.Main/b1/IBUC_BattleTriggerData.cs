using System.Collections.Generic;

namespace b1;

internal interface IBUC_BattleTriggerData
{
	bool bAutoEnableOverlap { get; }

	bool bIsEnabled { get; }

	Dictionary<string, FBattleTriggerUnitConfigInfo> BattleUnitConfigInfos { get; }

	Dictionary<string, List<string>> UnitBattleGroupInfo { get; }
}
