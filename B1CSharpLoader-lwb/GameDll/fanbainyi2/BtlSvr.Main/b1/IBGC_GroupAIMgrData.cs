using System.Collections.Generic;

namespace b1;

public interface IBGC_GroupAIMgrData
{
	BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDataAsset { get; }

	BGWGroupAIBattleHotZoneConfigDataAsset GroupAIBattleHotZoneConfigDataAsset { get; }

	Dictionary<EGroupAIHotZoneType, HotZonePointInfoWrap> HotZonePointInfoDict { get; }

	Dictionary<EGroupAIHotZoneType, List<HotZonePointInfo>> HotZoneWayPointInfoDict { get; }

	int GetPerformerNum(out bool OutIsEnableGroupAI);
}
