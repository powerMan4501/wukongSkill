using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_GroupAIMgrData : IBGC_GroupAIMgrData, IPersistentECSData
{
	public bool CanTriggerGroupAI;

	public Dictionary<Entity, GroupAIPerformerInfo> GroupAIPerformerInfoDic = new Dictionary<Entity, GroupAIPerformerInfo>();

	public bool IsEnableGroupAI;

	public bool IsNoMoveAttack;

	public float UpdateTimer;

	public float UpdateDurationForAllocHotZonePoint;

	public int TotalMeleeAttackTokenNum;

	public int TotalRangeAttackTokenNum;

	public bool BeginRecover2DefaultConfig;

	public float BeginRecover2DefaultConfigTimer;

	public int CurrentUseGroupAIConfigAreaID;

	public bool NeedReDrawDebugPanel;

	private TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset> mGroupAIMgrConfigDataAsset = new TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset>();

	private TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset> mOriGroupAIMgrConfigDataAsset = new TStrongObjectPtr<BGWGroupAIMgrConfigDataAsset>();

	private TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset> mGroupAIBattleHotZoneConfigDataAsset = new TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset>();

	private TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset> mOriGroupAIBattleHotZoneConfigDataAsset = new TStrongObjectPtr<BGWGroupAIBattleHotZoneConfigDataAsset>();

	public Dictionary<EGroupAIHotZoneType, HotZonePointInfoWrap> HotZonePointInfoDict { get; set; } = new Dictionary<EGroupAIHotZoneType, HotZonePointInfoWrap>();

	public Dictionary<EGroupAIHotZoneType, float> HotZoneRadiusInfoDict { get; set; } = new Dictionary<EGroupAIHotZoneType, float>();

	public Dictionary<EGroupAIHotZoneType, List<HotZonePointInfo>> HotZoneWayPointInfoDict { get; set; } = new Dictionary<EGroupAIHotZoneType, List<HotZonePointInfo>>();

	public BGWGroupAIMgrConfigDataAsset GroupAIMgrConfigDataAsset
	{
		get
		{
			return mGroupAIMgrConfigDataAsset.Get();
		}
		private set
		{
			mGroupAIMgrConfigDataAsset.Set(value);
		}
	}

	public BGWGroupAIMgrConfigDataAsset OriGroupAIMgrConfigDataAsset
	{
		get
		{
			return mOriGroupAIMgrConfigDataAsset.Get();
		}
		private set
		{
			mOriGroupAIMgrConfigDataAsset.Set(value);
		}
	}

	public BGWGroupAIBattleHotZoneConfigDataAsset GroupAIBattleHotZoneConfigDataAsset
	{
		get
		{
			return mGroupAIBattleHotZoneConfigDataAsset.Get();
		}
		private set
		{
			mGroupAIBattleHotZoneConfigDataAsset.Set(value);
		}
	}

	public BGWGroupAIBattleHotZoneConfigDataAsset OriGroupAIBattleHotZoneConfigDataAsset
	{
		get
		{
			return mOriGroupAIBattleHotZoneConfigDataAsset.Get();
		}
		private set
		{
			mOriGroupAIBattleHotZoneConfigDataAsset.Set(value);
		}
	}

	public void SetGroupAIMgrConfigDataAsset(BGWGroupAIMgrConfigDataAsset Asset, bool bUpdateOri = false)
	{
		GroupAIMgrConfigDataAsset = Asset;
		if (bUpdateOri)
		{
			OriGroupAIMgrConfigDataAsset = Asset;
		}
	}

	public void SetGroupAIBattleHotZoneConfigDataAsset(BGWGroupAIBattleHotZoneConfigDataAsset Asset, bool bUpdateOri = false)
	{
		GroupAIBattleHotZoneConfigDataAsset = Asset;
		if (bUpdateOri)
		{
			OriGroupAIBattleHotZoneConfigDataAsset = Asset;
		}
	}

	public int GetPerformerNum(out bool OutIsEnableGroupAI)
	{
		OutIsEnableGroupAI = IsEnableGroupAI;
		return GroupAIPerformerInfoDic.Count;
	}
}
