using System;
using System.Collections.Generic;
using BtlShare;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PotentialEnergyData : IBUC_PotentialEnergyData
{
	private float __PELimit_Normal_Raw;

	public float CurPEDurationRemaining;

	public float CurPETotalDuration;

	public float DecreasePerSecond;

	public float ProtectTime;

	public float DecreaseProtecTimer;

	public List<int> LastLevelBuffID;

	public int CurPELevel { get; set; }

	public Dictionary<int, PotentialEnergyLevelDetail> LevelMap { get; set; }

	public BGWDataAsset_PELevelConfig Default_Config { get; set; }

	[NeedToUI]
	public float PELimit_Normal
	{
		get
		{
			return __PELimit_Normal_Raw;
		}
		set
		{
			float _PELimit_Normal_Raw = __PELimit_Normal_Raw;
			__PELimit_Normal_Raw = value;
			OnPELimit_NormalChg_Invoke(_PELimit_Normal_Raw, value);
		}
	}

	public float PELimit_ByChargeSkill { get; set; }

	public event Action<float, float> OnPELimit_NormalChg;

	private void OnPELimit_NormalChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPELimit_NormalChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_PotentialEnergyData()
	{
		LevelMap = new Dictionary<int, PotentialEnergyLevelDetail>();
		PELimit_Normal = 0f;
		PELimit_ByChargeSkill = 0f;
		DecreasePerSecond = 0f;
		ProtectTime = -1f;
		DecreaseProtecTimer = -1f;
		LastLevelBuffID = new List<int>();
	}

	public int GetCurPELevel(AActor Owner)
	{
		float floatValue = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Owner).GetFloatValue(EBGUAttrFloat.Pevalue);
		int num = 0;
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in LevelMap)
		{
			if (item.Key > num && floatValue - item.Value.LeveConfig.LevelValue > -0.0001f)
			{
				num = item.Key;
			}
		}
		return num;
	}
}
