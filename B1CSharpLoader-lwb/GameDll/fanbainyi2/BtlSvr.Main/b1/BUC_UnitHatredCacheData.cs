using BtlB1;
using BtlShare;

namespace b1;

public class BUC_UnitHatredCacheData : IBUC_UnitHatredCacheData
{
	public BGWHatredConfigDataAsset HatredConfigDataAsset;

	public FUStUnitAIDesc UnitAIDesc;

	public FUStUnitCommDesc UnitCommDesc;

	public FUStUnitBattleInfoExtendDesc UnitBattleInfoExtendDesc { get; set; }
}
