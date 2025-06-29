using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_GroupAIAreaData
{
	BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDA { get; }

	BGWGroupAIBattleHotZoneConfigDataAsset GroupAIBattleHotZoneConfigDA { get; }

	UPrimitiveComponent OverlapComp { get; }
}
