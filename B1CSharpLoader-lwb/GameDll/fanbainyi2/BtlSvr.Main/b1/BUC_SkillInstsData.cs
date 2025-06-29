using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SkillInstsData : IBUC_SkillInstsData, IPersistentECSData
{
	public AActor OwnerActor;

	private TStrongObjectPtr<UAnimMontage> mCurrentSkillMontage = new TStrongObjectPtr<UAnimMontage>();

	private TStrongObjectPtr<UAnimMontage> mPhaseTransitionSkillMontage = new TStrongObjectPtr<UAnimMontage>();

	private ECanCastSkillResult LastCanCastSkillResult = ECanCastSkillResult.CCSR_OK;

	private ECastSkillResult LastSkillCastResult;

	private Dictionary<int, float> LastSkillCastTimes = new Dictionary<int, float>();

	public Dictionary<int, float> SkillCanCastCooldownRemainingTime = new Dictionary<int, float>();

	public Dictionary<int, TStrongObjectPtr<UAnimMontage>> SweepCheckAtkReboundingAMMap = new Dictionary<int, TStrongObjectPtr<UAnimMontage>>();

	public Dictionary<int, TStrongObjectPtr<UAnimMontage>> SweepCheckLowAtkReboundingAMMap = new Dictionary<int, TStrongObjectPtr<UAnimMontage>>();

	private int[] CurrentTurnSkillIDs = new int[4];

	private int[] CurrentMoveSkillIDs = new int[4];

	public UAnimMontage CurrentSkillMontage
	{
		get
		{
			return mCurrentSkillMontage.Get();
		}
		private set
		{
			mCurrentSkillMontage.Set(value);
		}
	}

	public UAnimMontage PhaseTransitionSkillMontage
	{
		get
		{
			return mPhaseTransitionSkillMontage.Get();
		}
		set
		{
			mPhaseTransitionSkillMontage.Set(value);
		}
	}

	public int CurrentCastingSkillID { get; private set; }

	public bool IsHitUnitDuringCastingSkill { get; set; }

	public string LastSkillKeyActionMapping { get; set; } = "";

	public float BeginCalcSkillPreCDTime { get; set; }

	public List<int> MagicWindowSkillBlackList { get; set; } = new List<int>();

	public List<int> MagicWindowSkillWhiteList { get; set; } = new List<int>();

	public int CurSkillCostDmgCounter { get; set; }

	public BUC_SkillInstsData()
	{
		ResetCastingSkillInfo();
		BeginCalcSkillPreCDTime = -1f;
		CurSkillCostDmgCounter = 0;
	}

	public void SetCurrentCastingSkillInfo(int SkillID, UAnimMontage SkillAnimMontage)
	{
		if (SkillID >= 0)
		{
			CurrentCastingSkillID = SkillID;
			CurrentSkillMontage = SkillAnimMontage;
		}
	}

	public void SetLastSkillCastResult(ECastSkillResult CastSkillResult)
	{
		LastSkillCastResult = CastSkillResult;
	}

	public ECastSkillResult GetLastSkillCastResult()
	{
		return LastSkillCastResult;
	}

	public void SetLastCanCastSkillResult(ECanCastSkillResult CanCastSkillResult)
	{
		LastCanCastSkillResult = CanCastSkillResult;
	}

	public ECanCastSkillResult GetLastCanCastSkillResult()
	{
		return LastCanCastSkillResult;
	}

	public float GetLastSkillCastTime(int SkillID)
	{
		if (LastSkillCastTimes.TryGetValue(SkillID, out var value))
		{
			return value;
		}
		return -1f;
	}

	public void SetLastSkillCastTime(int SkillID, float CurrentTime)
	{
		LastSkillCastTimes[SkillID] = CurrentTime;
	}

	public void ResetCastingSkillInfo()
	{
		CurrentCastingSkillID = -1;
		IsHitUnitDuringCastingSkill = false;
	}

	public void ResetLastSkillCastTime()
	{
		foreach (KeyValuePair<int, float> item in LastSkillCastTimes.ToList())
		{
			LastSkillCastTimes[item.Key] = 0f;
		}
	}

	public void SetTurnSkillID(TurnSkillType Type, int NewTurnSkillID)
	{
		CurrentTurnSkillIDs[(uint)Type] = NewTurnSkillID;
	}

	public int GetTurnSkillID(TurnSkillType Type)
	{
		return CurrentTurnSkillIDs[(uint)Type];
	}

	public void SetMoveSkillID(TurnSkillType Type, int NewMoveSkillID)
	{
		CurrentMoveSkillIDs[(uint)Type] = NewMoveSkillID;
	}

	public int GetMoveSkillID(TurnSkillType Type)
	{
		return CurrentMoveSkillIDs[(uint)Type];
	}

	public UAnimMontage GetSweepCheckAtkReboundingAM(int ObjectID)
	{
		if (SweepCheckAtkReboundingAMMap.TryGetValue(ObjectID, out var value))
		{
			return value.Get();
		}
		return null;
	}

	public UAnimMontage GetSweepCheckLowAtkReboundingAM(int ObjectID)
	{
		if (SweepCheckLowAtkReboundingAMMap.TryGetValue(ObjectID, out var value))
		{
			return value.Get();
		}
		return null;
	}

	public bool GetSkillCooldownTime(int SkillID, out float RemainingCooldownTime, out float RemainingPreCooldownTime)
	{
		RemainingCooldownTime = -1f;
		RemainingPreCooldownTime = -1f;
		if (SkillCanCastCooldownRemainingTime.TryGetValue(SkillID, out var value))
		{
			RemainingCooldownTime = value;
		}
		if (BeginCalcSkillPreCDTime > 0f && OwnerActor != null)
		{
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, OwnerActor);
			if (skillSDesc != null && skillSDesc.PreCooldownTime > 0f)
			{
				float timeSeconds = OwnerActor.World.GetTimeSeconds();
				RemainingPreCooldownTime = BeginCalcSkillPreCDTime + skillSDesc.PreCooldownTime - timeSeconds;
			}
		}
		if (RemainingCooldownTime <= 0f)
		{
			return RemainingPreCooldownTime <= 0f;
		}
		return false;
	}

	public bool GetSkillCanCastByCDCondition(int SkillID)
	{
		float RemainingCooldownTime;
		float RemainingPreCooldownTime;
		return GetSkillCooldownTime(SkillID, out RemainingCooldownTime, out RemainingPreCooldownTime);
	}
}
