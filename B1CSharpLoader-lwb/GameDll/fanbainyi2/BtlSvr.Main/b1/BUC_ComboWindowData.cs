using System.Collections.Generic;

namespace b1;

internal class BUC_ComboWindowData
{
	public Dictionary<int, AttackWindowInfo> AttackWindowInfoDict = new Dictionary<int, AttackWindowInfo>();

	public Dictionary<int, ComboKeyCacheWindowInfo> AttackKeyCacheWindowInfoDict = new Dictionary<int, ComboKeyCacheWindowInfo>();

	public List<int> ItemSkillWhiteList = new List<int>();

	private List<int> NeedRemoveGroupIDList = new List<int>();

	public bool CanSkillCombo(int SkillID, int GroupID)
	{
		if (AttackWindowInfoDict.TryGetValue(GroupID, out var value))
		{
			if (value.BlackListComboSkillIDList.Count > 0 && value.BlackListComboSkillIDList.Contains(SkillID))
			{
				return false;
			}
			if (value.WhiteListComboSkillIDList.Count > 0 && !value.WhiteListComboSkillIDList.Contains(SkillID))
			{
				return false;
			}
			return true;
		}
		return true;
	}

	public void SetAttackWindowInfo(int GroupID, int MontageInstanceID, uint NotifyUniqueID, float TotalDuration, List<int> BlackListComboSkillIDList, List<int> WhiteListComboSkillIDList)
	{
		if (AttackWindowInfoDict.TryGetValue(GroupID, out var value))
		{
			if (value.MontageInstanceID == MontageInstanceID)
			{
				value.UpdateInfo(NotifyUniqueID, TotalDuration, BlackListComboSkillIDList, WhiteListComboSkillIDList);
			}
			else
			{
				value.OverrideInfo(NotifyUniqueID, TotalDuration, BlackListComboSkillIDList, WhiteListComboSkillIDList);
			}
		}
		else
		{
			AttackWindowInfoDict[GroupID] = new AttackWindowInfo(MontageInstanceID, NotifyUniqueID, TotalDuration, BlackListComboSkillIDList, WhiteListComboSkillIDList);
		}
	}

	public void UpdateWindowInfo(float DeltaTime, bool bInComboWindow, bool bInItemSkillWindow)
	{
		if (AttackWindowInfoDict != null && AttackWindowInfoDict.Count > 0)
		{
			if (bInComboWindow)
			{
				NeedRemoveGroupIDList.Clear();
				foreach (KeyValuePair<int, AttackWindowInfo> item in AttackWindowInfoDict)
				{
					AttackWindowInfo value = item.Value;
					value.UpdateWindowTime(DeltaTime);
					if (value.TotalTime <= 0f)
					{
						NeedRemoveGroupIDList.Add(item.Key);
					}
				}
				foreach (int needRemoveGroupID in NeedRemoveGroupIDList)
				{
					AttackWindowInfoDict.Remove(needRemoveGroupID);
				}
			}
			else
			{
				AttackWindowInfoDict.Clear();
			}
		}
		if (AttackKeyCacheWindowInfoDict != null && AttackKeyCacheWindowInfoDict.Count > 0)
		{
			NeedRemoveGroupIDList.Clear();
			foreach (KeyValuePair<int, ComboKeyCacheWindowInfo> item2 in AttackKeyCacheWindowInfoDict)
			{
				ComboKeyCacheWindowInfo value2 = item2.Value;
				value2.TotalTime -= DeltaTime;
				if (value2.TotalTime <= 0f)
				{
					NeedRemoveGroupIDList.Add(item2.Key);
				}
			}
			foreach (int needRemoveGroupID2 in NeedRemoveGroupIDList)
			{
				AttackKeyCacheWindowInfoDict.Remove(needRemoveGroupID2);
			}
		}
		if (ItemSkillWhiteList != null && ItemSkillWhiteList.Count > 0 && !bInItemSkillWindow)
		{
			ItemSkillWhiteList.Clear();
		}
	}
}
