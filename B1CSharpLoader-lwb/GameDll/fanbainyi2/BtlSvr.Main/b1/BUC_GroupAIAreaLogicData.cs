using UnrealEngine.Runtime;

namespace b1;

internal class BUC_GroupAIAreaLogicData : b1.IBUC_GroupAIAreaLogicData
{
	private TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset> mGroupAIMgrConfigDA = new TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset>();

	private TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset> mGroupAIBattleHotZoneConfigDA = new TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset>();

	public BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDA
	{
		get
		{
			return mGroupAIMgrConfigDA.Get();
		}
		set
		{
			mGroupAIMgrConfigDA.Set(value);
		}
	}

	public BGWGroupAIBattleHotZoneConfigDataAsset GroupAIBattleHotZoneConfigDA
	{
		get
		{
			return mGroupAIBattleHotZoneConfigDA.Get();
		}
		set
		{
			mGroupAIBattleHotZoneConfigDA.Set(value);
		}
	}
}
