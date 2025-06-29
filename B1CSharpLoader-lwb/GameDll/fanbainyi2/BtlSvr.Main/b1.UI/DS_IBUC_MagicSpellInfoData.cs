using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_MagicSpellInfoData : GSBattleDataDStore
{
	private IBUC_MagicSpellInfoData ReadData;

	private BUC_MagicSpellInfoData Data;

	public DS_IBUC_MagicSpellInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicSpellInfoData, BUC_MagicSpellInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MagicSpellInfoData>(actor);
		}
	}

	public bool GetMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent)
	{
		IsLock = false;
		IsDisable = false;
		CDTimePercent = 0f;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetMagicSpellInfo(SpellID, out IsLock, out IsDisable, out CDTimePercent);
	}

	public bool GetAllMagicSpellInfo(int SpellID, out bool IsLock, out bool IsDisable, out float CDTimePercent)
	{
		IsLock = false;
		IsDisable = false;
		CDTimePercent = 0f;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetAllMagicSpellInfo(SpellID, out IsLock, out IsDisable, out CDTimePercent);
	}

	public bool GetAllMagicSpellCost(int SpellID, out EAttrCostType AttrCostType1, out float CostValue1, out EAttrCostType AttrCostType2, out float CostValue2)
	{
		AttrCostType1 = EAttrCostType.None;
		CostValue1 = 0f;
		AttrCostType2 = EAttrCostType.None;
		CostValue2 = 0f;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetAllMagicSpellCost(SpellID, out AttrCostType1, out CostValue1, out AttrCostType2, out CostValue2);
	}

	public override void ResetActor(AActor actor)
	{
		base.ResetActor(actor);
		if (ReadData != null && Data != null)
		{
			foreach (List<Action> value in NeedActionDic.Values)
			{
				value[1]?.Invoke();
			}
		}
		if (actor.IsNullOrDestroyed())
		{
			ReadData = null;
			Data = null;
			return;
		}
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicSpellInfoData, BUC_MagicSpellInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MagicSpellInfoData>(actor);
		if (ReadData == null || Data == null)
		{
			return;
		}
		foreach (List<Action> value2 in NeedActionDic.Values)
		{
			value2[0]?.Invoke();
		}
	}
}
