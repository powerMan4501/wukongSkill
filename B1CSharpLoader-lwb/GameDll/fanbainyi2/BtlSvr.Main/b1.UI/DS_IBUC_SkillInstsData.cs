using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_SkillInstsData : GSBattleDataDStore
{
	private IBUC_SkillInstsData ReadData;

	private BUC_SkillInstsData Data;

	public UAnimMontage CurrentSkillMontage
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CurrentSkillMontage;
		}
	}

	public int CurrentCastingSkillID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurrentCastingSkillID;
		}
	}

	public bool IsHitUnitDuringCastingSkill
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.IsHitUnitDuringCastingSkill;
		}
	}

	public string LastSkillKeyActionMapping
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.LastSkillKeyActionMapping;
		}
	}

	public List<int> MagicWindowSkillBlackList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.MagicWindowSkillBlackList;
		}
	}

	public List<int> MagicWindowSkillWhiteList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.MagicWindowSkillWhiteList;
		}
	}

	public int CurSkillCostDmgCounter
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurSkillCostDmgCounter;
		}
	}

	public DS_IBUC_SkillInstsData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SkillInstsData>(actor);
		}
	}

	public ECastSkillResult GetLastSkillCastResult()
	{
		if (ReadData == null)
		{
			return ECastSkillResult.CSR_OK;
		}
		return ReadData.GetLastSkillCastResult();
	}

	public ECanCastSkillResult GetLastCanCastSkillResult()
	{
		if (ReadData == null)
		{
			return (ECanCastSkillResult)0L;
		}
		return ReadData.GetLastCanCastSkillResult();
	}

	public int GetTurnSkillID(TurnSkillType Type)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetTurnSkillID(Type);
	}

	public int GetMoveSkillID(TurnSkillType Type)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetMoveSkillID(Type);
	}

	public UAnimMontage GetSweepCheckAtkReboundingAM(int ObjectID)
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetSweepCheckAtkReboundingAM(ObjectID);
	}

	public UAnimMontage GetSweepCheckLowAtkReboundingAM(int ObjectID)
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetSweepCheckLowAtkReboundingAM(ObjectID);
	}

	public float GetLastSkillCastTime(int SkillID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetLastSkillCastTime(SkillID);
	}

	public bool GetSkillCooldownTime(int SkillID, out float RemainingCooldownTime, out float RemainingPreCooldownTime)
	{
		RemainingCooldownTime = 0f;
		RemainingPreCooldownTime = 0f;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetSkillCooldownTime(SkillID, out RemainingCooldownTime, out RemainingPreCooldownTime);
	}

	public bool GetSkillCanCastByCDCondition(int SkillID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetSkillCanCastByCDCondition(SkillID);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SkillInstsData>(actor);
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
