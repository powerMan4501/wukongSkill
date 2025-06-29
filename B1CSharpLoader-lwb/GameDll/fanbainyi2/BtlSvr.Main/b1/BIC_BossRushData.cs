using System.Collections.Generic;
using ArchiveB1;
using ResB1;

namespace b1;

public class BIC_BossRushData : IBIC_BossRushData
{
	public float LimitTime;

	public float LastLimitTime;

	public bool BattleTimePaused;

	public bool IsInBattleState { get; set; }

	public BossRushBattleData BossRushBattleData { get; set; }

	public EBossRushType BossRushType { get; set; }

	public int TargetLevelId { get; set; }

	public int TargetId { get; set; }

	public int BossIterationsIndex { get; set; }

	public int BossIterationsGroupId { get; set; }

	public float BattleFinishDelayTime { get; set; }

	public bool WaitEndTransformingFlag { get; set; }

	public Dictionary<int, float> BossIterationsAttrCacheDict { get; set; }

	public BossRushRoleBase BossRushRoleBase { get; set; }

	public BossRushDamageInfo_PerRand BossRushDamageInfo_PerRand { get; set; }

	public BossRushBattleStyleInfo_PerRand BattleStyleInfo { get; set; }

	public List<ItemOne> CostItemList { get; set; }

	public bool? bAllowAssociationUnit { get; set; }

	public bool AllowAssociationUnit
	{
		get
		{
			if (!bAllowAssociationUnit.HasValue)
			{
				return false;
			}
			return bAllowAssociationUnit.Value;
		}
	}

	public List<float> BattleTimeList { get; set; } = new List<float>();

	public BIC_BossRushData()
	{
		BossRushDamageInfo_PerRand = new BossRushDamageInfo_PerRand();
		BossRushDamageInfo_PerRand.Clear();
		BattleStyleInfo = new BossRushBattleStyleInfo_PerRand();
		BattleStyleInfo.Clear();
		BossRushRoleBase = new BossRushRoleBase();
	}

	public void Reset()
	{
		IsInBattleState = false;
		BossRushBattleData = null;
		BossRushType = EBossRushType.None;
		TargetLevelId = 0;
		TargetId = 0;
		BossIterationsIndex = 0;
		BossIterationsGroupId = 0;
		BattleFinishDelayTime = 0f;
		WaitEndTransformingFlag = false;
		BossIterationsAttrCacheDict?.Clear();
		BossRushDamageInfo_PerRand?.Clear();
		BattleStyleInfo?.Clear();
		bAllowAssociationUnit = null;
		LimitTime = 0f;
		LastLimitTime = 0f;
		BattleTimePaused = false;
		CostItemList = null;
		BattleTimeList?.Clear();
	}

	public float GetRemainTime()
	{
		return LimitTime - BossRushBattleData.TotalTime + LastLimitTime;
	}

	public float GetLimitTime()
	{
		return LimitTime;
	}
}
