using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_UnitBeAttackedFequenceData : b1.IBUC_UnitBeAttackedFequenceData, IPersistentECSData
{
	public Dictionary<string, BGUBeAttackWarningFequeceInfo> LastBeAttackedDataNotifyStateIDMap { get; set; } = new Dictionary<string, BGUBeAttackWarningFequeceInfo>();

	public void UpdateCheckBeAttackedFequenceData(float DeltaTime)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, BGUBeAttackWarningFequeceInfo> item in LastBeAttackedDataNotifyStateIDMap)
		{
			string key = item.Key;
			if (item.Value.ResetTime >= 0f)
			{
				item.Value.ResetTime -= DeltaTime;
			}
			item.Value.MontageResetTime -= DeltaTime;
			if (item.Value.MontageResetTime < 0f)
			{
				list.Add(key);
			}
		}
		foreach (string item2 in list)
		{
			LastBeAttackedDataNotifyStateIDMap.Remove(item2);
		}
	}

	public bool CheckBeAttackedFequenceData(string SkillTaskUniqueID)
	{
		if (LastBeAttackedDataNotifyStateIDMap.TryGetValue(SkillTaskUniqueID, out var _))
		{
			return false;
		}
		return true;
	}

	public void MarkBeAttackedFequenceData(string SkillTaskUniqueID, int FromInstanceID, int GroupID, float ResetTime, float GroupTimer, bool IsTriggered)
	{
		if (LastBeAttackedDataNotifyStateIDMap.ContainsKey(SkillTaskUniqueID))
		{
			BGW_LogUtil.LogError("BUC_UnitBeAttackedFequenceData::MarkBeAttackedFequenceData同一个UniqueID重复执行，SweepCheck相关实现可能出错");
		}
		else
		{
			LastBeAttackedDataNotifyStateIDMap.Add(SkillTaskUniqueID, new BGUBeAttackWarningFequeceInfo(FromInstanceID, GroupID, ResetTime, GroupTimer, IsTriggered));
		}
	}

	public bool CheckBeAttackedGroupInfo(int GroupID, int FromInstanceID)
	{
		if (GroupID == -1)
		{
			return true;
		}
		foreach (KeyValuePair<string, BGUBeAttackWarningFequeceInfo> item in LastBeAttackedDataNotifyStateIDMap)
		{
			BGUBeAttackWarningFequeceInfo value = item.Value;
			if (value.FromInstanceID == FromInstanceID && value.GroupID == GroupID && value.IsTriggered)
			{
				return false;
			}
		}
		return true;
	}
}
