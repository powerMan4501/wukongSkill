using System.Collections.Generic;
using BtlB1;

namespace b1;

public class FCloneServantInstance : FNormalServantInstance
{
	protected override void AfterUnitBeginPlay()
	{
		base.AfterUnitBeginPlay();
		if (ServantReq.MapEquip == null)
		{
			return;
		}
		foreach (KeyValuePair<EquipPosition, int> item in ServantReq.MapEquip)
		{
			base.ServantEventCollection.Evt_BattleLogicChangeEquip.Invoke(item.Key, item.Value);
		}
	}

	public FCloneServantInstance(FServantReq InReq)
		: base(InReq)
	{
		base.bCanCastCopySkill = true;
	}
}
