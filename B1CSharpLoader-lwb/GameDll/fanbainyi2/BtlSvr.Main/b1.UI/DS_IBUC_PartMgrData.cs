using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_PartMgrData : GSBattleDataDStore
{
	private IBUC_PartMgrData ReadData;

	private BUC_PartMgrData Data;

	public int PartRuleID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.PartRuleID;
		}
	}

	public int DefaultPartRuleID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.DefaultPartRuleID;
		}
	}

	public int ShowUIPartID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.ShowUIPartID;
		}
	}

	public DS_IBUC_PartMgrData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PartMgrData>(actor);
		}
	}

	public bool GetPartInfo(int PartID, out PartInfoData PartInfoOut)
	{
		PartInfoOut = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetPartInfo(PartID, out PartInfoOut);
	}

	public bool GetAllPartInfo(out Dictionary<int, PartInfoData> PartInfoDataDic)
	{
		PartInfoDataDic = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetAllPartInfo(out PartInfoDataDic);
	}

	public bool IsPartBreakInCurrentStage(int PartID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsPartBreakInCurrentStage(PartID);
	}

	public bool IsPartCompletelyBreak(int PartID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsPartCompletelyBreak(PartID);
	}

	public bool IsPartActive(int PartID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsPartActive(PartID);
	}

	public int GetPartCurrentStage(int PartID)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetPartCurrentStage(PartID);
	}

	public bool GetValidLastBreakOrDamagedPartInfo(out int BreakOrDamagedPartID, out bool IsTriggerBreak, out string BreakerGUID)
	{
		BreakOrDamagedPartID = 0;
		IsTriggerBreak = false;
		BreakerGUID = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetValidLastBreakOrDamagedPartInfo(out BreakOrDamagedPartID, out IsTriggerBreak, out BreakerGUID);
	}

	public bool CanInterruptLastPartBreak(int PartID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.CanInterruptLastPartBreak(PartID);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PartMgrData>(actor);
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
