using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_GroupAIAreaData : b1.IBUC_GroupAIAreaData
{
	private TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset> mGroupAIMgrConfigDA = new TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset>();

	private TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset> mGroupAIBattleHotZoneConfigDA = new TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset>();

	private TStrongObjectPtr<UPrimitiveComponent> mOverlapComp = new TStrongObjectPtr<UPrimitiveComponent>();

	public bool HasTriggerBegin;

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

	public UPrimitiveComponent OverlapComp
	{
		get
		{
			return mOverlapComp.Get();
		}
		set
		{
			mOverlapComp.Set(value);
		}
	}
}
