using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PartMgrData : IBUC_PartMgrData, IPersistentECSData
{
	private static float INV10000 = 0.0001f;

	public float RemoveBreakPartWeakStateTimer;

	public bool HasAlreadyRemoveForcePerformanceState;

	public float PartDamageBaseValue;

	public int LastBreakOrDamagedPartID;

	public string LastBreakerGUID;

	public bool LastIsTriggerBreak;

	public bool CanGetValidLastBreakOrDamagedInfo;

	[GSGameDataSnapShot]
	public Dictionary<int, PartInfoData> PartInfoDataDic { get; set; }

	public int PartRuleID { get; set; }

	public int DefaultPartRuleID { get; set; }

	public int ShowUIPartID { get; set; }

	public BUC_PartMgrData()
	{
		PartRuleID = 0;
		DefaultPartRuleID = 0;
		PartDamageBaseValue = 0f;
		PartInfoDataDic = new Dictionary<int, PartInfoData>();
		ShowUIPartID = -1;
		ResetLastBreakOrDamagedInfo();
	}

	public void ResetLastBreakOrDamagedInfo()
	{
		LastBreakOrDamagedPartID = -1;
		LastBreakerGUID = "";
		LastIsTriggerBreak = false;
		CanGetValidLastBreakOrDamagedInfo = false;
	}

	public void ReducePartHP(int PartID, float ReduceValue, int StiffLevel)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value) && value.IsActive && !value.IsPartHPLocked && !value.IsBreak && (value.CurrentPartDamagedValue -= ReduceValue) < 1f && StiffLevel < value.PartDamagedStiffLevel)
		{
			value.CurrentPartDamagedValue = 1f;
		}
	}

	public void SetLockPartHP(int PartID, bool IsLocked)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			value.IsPartHPLocked = IsLocked;
		}
	}

	public void SetLockAllPartHP(bool IsLocked)
	{
		if (PartInfoDataDic == null)
		{
			return;
		}
		foreach (KeyValuePair<int, PartInfoData> item in PartInfoDataDic)
		{
			item.Value.IsPartHPLocked = true;
		}
	}

	public void SetPartActive(int PartID, bool bIsActive)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			value.IsActive = bIsActive;
		}
	}

	public void ClearPartInfo()
	{
		if (PartInfoDataDic != null)
		{
			PartInfoDataDic.Clear();
		}
	}

	public void RecoveryPartDamageValue(int PartID, AActor Owner)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(value.DescID, Owner);
			if (partRuleInfoDesc != null)
			{
				int index = ((partRuleInfoDesc.PartDamagedInfoList.Count >= value.CurrentDamagedStage) ? (value.CurrentDamagedStage - 1) : (partRuleInfoDesc.PartDamagedInfoList.Count - 1));
				value.CurrentPartDamagedValue = partRuleInfoDesc.PartDamagedInfoList[index].DamagedValueRatio * INV10000 * value.PartDamagedBaseValue;
				value.IsBreak = false;
			}
		}
	}

	public bool GetPartInfo(int PartID, out PartInfoData PartInfoOut)
	{
		PartInfoOut = new PartInfoData();
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			PartInfoOut = value;
			return true;
		}
		return false;
	}

	public bool GetAllPartInfo(out Dictionary<int, PartInfoData> OutPartInfoDataDic)
	{
		OutPartInfoDataDic = new Dictionary<int, PartInfoData>();
		if (PartInfoDataDic != null)
		{
			foreach (KeyValuePair<int, PartInfoData> item in PartInfoDataDic)
			{
				OutPartInfoDataDic.Add(item.Key, item.Value);
			}
			return true;
		}
		return false;
	}

	public bool IsPartBreakInCurrentStage(int PartID)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			return value.CurrentPartDamagedValue <= 0f;
		}
		return false;
	}

	public bool IsPartCompletelyBreak(int PartID)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			return value.IsBreak;
		}
		return false;
	}

	public bool IsPartActive(int PartID)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			return value.IsActive;
		}
		return false;
	}

	public int GetPartCurrentStage(int PartID)
	{
		if (PartInfoDataDic != null && PartInfoDataDic.TryGetValue(PartID, out var value))
		{
			return value.CurrentDamagedStage;
		}
		return -1;
	}

	public bool GetValidLastBreakOrDamagedPartInfo(out int BreakOrDamagedPartID, out bool IsTriggerBreak, out string BreakerGUID)
	{
		BreakOrDamagedPartID = LastBreakOrDamagedPartID;
		IsTriggerBreak = LastIsTriggerBreak;
		BreakerGUID = LastBreakerGUID;
		return CanGetValidLastBreakOrDamagedInfo;
	}

	public bool CanInterruptLastPartBreak(int PartID)
	{
		if (GetPartInfo(PartID, out var PartInfoOut))
		{
			return PartInfoOut.CanInterruptPartIDList.Contains(LastBreakOrDamagedPartID);
		}
		return false;
	}
}
