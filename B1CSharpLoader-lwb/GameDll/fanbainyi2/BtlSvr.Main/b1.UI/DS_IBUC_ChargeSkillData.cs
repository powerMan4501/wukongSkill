using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_ChargeSkillData : GSBattleDataDStore
{
	private IBUC_ChargeSkillData ReadData;

	private BUC_ChargeSkillData Data;

	public int CurrentBeginChargeSkillID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurrentBeginChargeSkillID;
		}
	}

	public int CurrentBeginChargeSkillOriginSkillID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurrentBeginChargeSkillOriginSkillID;
		}
	}

	public int CurrentChargeSkillID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurrentChargeSkillID;
		}
	}

	public float ChargeTimer
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.ChargeTimer;
		}
	}

	public int BeAttackedTriggerForceAttackCnt
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.BeAttackedTriggerForceAttackCnt;
		}
	}

	public EChargeSkillStage ChargeSkillStage
	{
		get
		{
			if (ReadData == null)
			{
				return EChargeSkillStage.None;
			}
			return ReadData.ChargeSkillStage;
		}
	}

	public bool IsCastingChargeSkill
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.IsCastingChargeSkill;
		}
	}

	public bool NeedTriggerNextStage
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.NeedTriggerNextStage;
		}
	}

	public bool NeedCancel
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.NeedCancel;
		}
	}

	public List<ChargeSkillBuffInfo> BuffInfoList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BuffInfoList;
		}
	}

	public ChargeSkillSuperArmorInfo SuperArmorInfo
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.SuperArmorInfo;
		}
	}

	public int CurChargeLevel
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurChargeLevel;
		}
	}

	public DS_IBUC_ChargeSkillData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ChargeSkillData>(actor);
		}
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ChargeSkillData>(actor);
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
