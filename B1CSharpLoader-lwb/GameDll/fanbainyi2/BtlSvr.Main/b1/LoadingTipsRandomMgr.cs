using System;
using System.Collections.Generic;
using System.Linq;
using ResB1;

namespace b1;

public static class LoadingTipsRandomMgr
{
	public class TipsCategory
	{
		public LoadingTipsWeightDesc WeightDesc;

		public int _RandWeight;

		public List<LoadingTipsDesc> tipsList = new List<LoadingTipsDesc>();

		public int RandWeight
		{
			get
			{
				if (tipsList.Count > 0)
				{
					return _RandWeight;
				}
				return 0;
			}
		}

		public int TipsCount => tipsList.Count;

		public void AddWeight(int AddValue)
		{
			_RandWeight += AddValue;
		}

		public void AddLoadingTips(List<LoadingTipsDesc> addList, List<int> excludeList)
		{
			foreach (LoadingTipsDesc add in addList)
			{
				if (!excludeList.Contains(add.Id))
				{
					tipsList.Add(add);
				}
			}
		}
	}

	public class TipsRandPool
	{
		public List<TipsCategory> tipsCategories = new List<TipsCategory>();

		public int TotalWeight
		{
			get
			{
				int num = 0;
				foreach (TipsCategory tipsCategory in tipsCategories)
				{
					num += tipsCategory.RandWeight;
				}
				return num;
			}
		}

		private LoadingTipsDesc RandOneTips()
		{
			TipsCategory tipsCategory = RandomUtil.RangeOneByWeight(tipsCategories, (TipsCategory tipsCategory2) => tipsCategory2.RandWeight);
			if (tipsCategory != null && tipsCategory.tipsList.Count > 0)
			{
				int index = RandomUtil.RangeRand(0, tipsCategory.tipsList.Count - 1);
				LoadingTipsDesc result = tipsCategory.tipsList[index];
				tipsCategory.tipsList.RemoveAt(index);
				return result;
			}
			return null;
		}

		public List<LoadingTipsDesc> RandTips(int RandNum)
		{
			List<LoadingTipsDesc> list = new List<LoadingTipsDesc>();
			if (TotalWeight == 0)
			{
				return list;
			}
			while (RandNum > 0)
			{
				LoadingTipsDesc loadingTipsDesc = RandOneTips();
				if (loadingTipsDesc == null)
				{
					break;
				}
				list.Add(loadingTipsDesc);
				RandNum--;
			}
			return list;
		}
	}

	private enum TipsRealTriggerType
	{
		None,
		Death,
		Transfer,
		UnitKill
	}

	public static readonly int TipsMaxNum = 7;

	private static Dictionary<int, int> TipsCoolDownPool = new Dictionary<int, int>();

	private static bool IsSatisfyConfition(FLoadingTipsBattleParam BattleParam, FLoadingTipsRoleDataParam RoleDataParam, TipsCondition condition)
	{
		bool result = true;
		switch (condition.TipConditionType)
		{
		case TipsConditionType.Level:
			if (BattleParam.LevelId != condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.Murderer:
			if (BattleParam.CastPlayerDeadUnitResId == 0 || BattleParam.CastPlayerDeadUnitResId != condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.DeadSkill:
			if (BattleParam.CastPlayerDeadSkillId == 0 || BattleParam.CastPlayerDeadSkillId != condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.AbnormalStatus:
			if (!BattleParam.AbnormalStates.Contains(condition.Param1))
			{
				result = false;
			}
			break;
		case TipsConditionType.Falling:
			if (!BattleParam.IsFallOrDeadZoneDead)
			{
				result = false;
			}
			break;
		case TipsConditionType.Becalm:
			if (BattleParam.AttackerRemainedHp >= condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.UseSkillPlease:
			if (BattleParam.PlayerRemainedMp <= condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.TooMuchDaoHang:
			if (RoleDataParam.TalentPointNum <= condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.TooMuchMoney:
			if (RoleDataParam.SpiritNum <= condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.TooMuchEnemies:
			if (BattleParam.AttackerNumWithinRadius < condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.MissionComplete:
			if (condition.Param1 == 0)
			{
				if (RoleDataParam.CompletedTaskList.Contains(condition.Param2))
				{
					result = false;
				}
			}
			else if (!RoleDataParam.CompletedTaskList.Contains(condition.Param1) || RoleDataParam.CompletedTaskList.Contains(condition.Param2))
			{
				result = false;
			}
			break;
		case TipsConditionType.Teleport:
			if (BattleParam.RebirthPointId != condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.EquipQuality:
			if (RoleDataParam.EquipQuality >= condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.SuperArmor:
			if (!BattleParam.IsInSuperArmorState)
			{
				result = false;
			}
			break;
		case TipsConditionType.NoSoakingItem:
			if (RoleDataParam.IsConfigureWinePartner)
			{
				result = false;
			}
			break;
		case TipsConditionType.NoQuickItem:
			if (RoleDataParam.IsAllShortcutConfigureItem)
			{
				result = false;
			}
			break;
		case TipsConditionType.WithItem:
			if (!RoleDataParam.PlayerItemList.Contains(condition.Param1))
			{
				result = false;
			}
			break;
		case TipsConditionType.WithoutItem:
			if (RoleDataParam.PlayerItemList.Contains(condition.Param1))
			{
				result = false;
			}
			break;
		case TipsConditionType.DeadBuff:
			if (BattleParam.CastPlayerDeadBuffId == 0 || BattleParam.CastPlayerDeadBuffId != condition.Param1)
			{
				result = false;
			}
			break;
		case TipsConditionType.TalentExist:
			if (!RoleDataParam.TalentList.Contains(condition.Param1))
			{
				result = false;
			}
			break;
		case TipsConditionType.FuncIdExist:
			if (!RoleDataParam.FuncIdList.Contains(condition.Param1))
			{
				result = false;
			}
			break;
		}
		return result;
	}

	public static bool LoadingTipsFilter(FLoadingTipsBattleParam BattleParam, FLoadingTipsRoleDataParam RoleDataParam, LoadingTipsDesc LoadingTipsDesc)
	{
		if (LoadingTipsDesc.TipsTriggerType != TipsTriggerType.All && BattleParam.TriggerType != LoadingTipsDesc.TipsTriggerType)
		{
			return false;
		}
		bool flag = true;
		if (LoadingTipsDesc.RelationType == TipsConditionRelationtype.And)
		{
			foreach (TipsCondition item in LoadingTipsDesc.Condition)
			{
				flag = IsSatisfyConfition(BattleParam, RoleDataParam, item);
				if (!flag)
				{
					break;
				}
			}
		}
		else
		{
			foreach (TipsCondition item2 in LoadingTipsDesc.Condition)
			{
				flag = IsSatisfyConfition(BattleParam, RoleDataParam, item2);
				if (flag)
				{
					break;
				}
			}
		}
		return flag;
	}

	private static void ResetLoadingTipsCDByTipsList(List<LoadingTipsDesc> TargetTips)
	{
		foreach (LoadingTipsDesc TargetTip in TargetTips)
		{
			if (TargetTip.CoolDownCount > 0)
			{
				TipsCoolDownPool[TargetTip.Id] = TargetTip.CoolDownCount;
			}
		}
	}

	private static void ResetLoadingTipsCDByTipsIdList(List<int> TargetTips)
	{
		foreach (int TargetTip in TargetTips)
		{
			LoadingTipsDesc loadingTipsDesc = GameDBRuntime.GetLoadingTipsDesc(TargetTip);
			if (loadingTipsDesc.CoolDownCount > 0)
			{
				TipsCoolDownPool[TargetTip] = loadingTipsDesc.CoolDownCount;
			}
		}
	}

	private static void RandomTheListSplitByPriority(List<LoadingTipsDesc> ret)
	{
		List<LoadingTipsDesc> list = new List<LoadingTipsDesc>();
		int num;
		for (num = 0; num < ret.Count; num++)
		{
			int priority = ret[num].Priority;
			int i;
			for (i = num; i < ret.Count && ret[i].Priority == priority; i++)
			{
				list.Add(ret[i]);
			}
			list = list.OrderBy((LoadingTipsDesc a) => Guid.NewGuid()).ToList();
			for (int num2 = num; num2 < i; num2++)
			{
				ret[num2] = list[num2 - num];
			}
			list.Clear();
			num = i - 1;
		}
	}

	private static void CoolDownTipsPool()
	{
		foreach (int item in TipsCoolDownPool.Keys.ToList())
		{
			TipsCoolDownPool[item]--;
			if (TipsCoolDownPool[item] == 0)
			{
				TipsCoolDownPool.Remove(item);
			}
		}
	}

	public static List<LoadingTipsDesc> FetchLoadingTipsV2(FLoadingTipsBattleParam BattleParam, FLoadingTipsRoleDataParam RoleDataParam, FLoadingTipsRuntimeParam RuntimeParam)
	{
		List<LoadingTipsDesc> list = new List<LoadingTipsDesc>();
		TBLoadingTipsDesc tBLoadingTipsDesc = GameDBRuntime.GetTBLoadingTipsDesc();
		CoolDownTipsPool();
		ResetLoadingTipsCDByTipsIdList(RuntimeParam.LastUsedLoadingTips);
		foreach (LoadingTipsDesc item in tBLoadingTipsDesc.List)
		{
			if (!TipsCoolDownPool.ContainsKey(item.Id) && LoadingTipsFilter(BattleParam, RoleDataParam, item))
			{
				list.Add(item);
			}
		}
		if (list.Count < TipsMaxNum)
		{
			List<LoadingTipsDesc> loadingTipsToFillRet = GameDBRuntime.GetLoadingTipsToFillRet(TipsMaxNum - list.Count);
			list.AddRange(loadingTipsToFillRet);
		}
		list.Sort((LoadingTipsDesc left, LoadingTipsDesc right) => right.Priority.CompareTo(left.Priority));
		RandomTheListSplitByPriority(list);
		foreach (LoadingTipsDesc item2 in list)
		{
			_ = item2;
		}
		if (list.Count > TipsMaxNum)
		{
			list.RemoveRange(TipsMaxNum, list.Count - TipsMaxNum);
		}
		return list;
	}

	public static List<LoadingTipsDesc> FetchLoadingTips(int MapId, TipsTriggerType inputTriggerType, int UnitId, List<int> lastUseTips)
	{
		int randNum = 10;
		TipsRandPool tipsRandPool = new TipsRandPool();
		if (lastUseTips == null)
		{
			lastUseTips = new List<int>();
		}
		TipsRealTriggerType tipsRealTriggerType = TipsRealTriggerType.None;
		switch (inputTriggerType)
		{
		case TipsTriggerType.Teleport:
			tipsRealTriggerType = TipsRealTriggerType.Transfer;
			break;
		case TipsTriggerType.Death:
			tipsRealTriggerType = TipsRealTriggerType.Death;
			break;
		}
		List<LoadingTipsDesc> addList = null;
		if (inputTriggerType == TipsTriggerType.Death && UnitId >= 0)
		{
			List<LoadingTipsDesc> loadingTipsByDeathUnitId = GameDBRuntime.GetLoadingTipsByDeathUnitId(UnitId, MapId);
			if (loadingTipsByDeathUnitId.Count > 0)
			{
				addList = loadingTipsByDeathUnitId;
				tipsRealTriggerType = TipsRealTriggerType.UnitKill;
			}
		}
		foreach (LoadingTipsWeightDesc item in GameDBRuntime.GetTBLoadingTipsWeightDesc().List)
		{
			TipsCategory tipsCategory = new TipsCategory
			{
				WeightDesc = item,
				_RandWeight = item.BaseWeight
			};
			if (tipsCategory.WeightDesc.TipsType == LoadingTipsType.UnitKill && tipsRealTriggerType == TipsRealTriggerType.UnitKill)
			{
				tipsCategory.AddLoadingTips(addList, lastUseTips);
				tipsCategory.AddWeight(tipsCategory.WeightDesc.UnitKillAddWeight);
			}
			else
			{
				List<LoadingTipsDesc> loadingTipsByType = GameDBRuntime.GetLoadingTipsByType(item.TipsType, 0);
				if (loadingTipsByType != null)
				{
					tipsCategory.AddLoadingTips(loadingTipsByType, lastUseTips);
				}
				List<LoadingTipsDesc> loadingTipsByType2 = GameDBRuntime.GetLoadingTipsByType(item.TipsType, MapId);
				if (loadingTipsByType2 != null)
				{
					tipsCategory.AddLoadingTips(loadingTipsByType2, lastUseTips);
				}
				switch (tipsRealTriggerType)
				{
				case TipsRealTriggerType.Transfer:
					tipsCategory.AddWeight(tipsCategory.WeightDesc.TransferAddWeight);
					break;
				case TipsRealTriggerType.Death:
					tipsCategory.AddWeight(tipsCategory.WeightDesc.DeathAddWeight);
					break;
				}
			}
			tipsRandPool.tipsCategories.Add(tipsCategory);
		}
		return tipsRandPool.RandTips(randNum);
	}
}
