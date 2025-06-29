using System.Collections.Generic;

namespace b1;

public class AttackWindowInfo
{
	private ComboKeyCacheWindowInfo WindowInfo { get; set; }

	public int MontageInstanceID => WindowInfo?.MontageInstanceID ?? 0;

	public uint NotifyUniqueID => WindowInfo?.NotifyUniqueID ?? 0;

	public float TotalTime => WindowInfo?.TotalTime ?? 0f;

	public List<int> BlackListComboSkillIDList { get; private set; }

	public List<int> WhiteListComboSkillIDList { get; private set; }

	public AttackWindowInfo(int MontageInstanceID, uint NotifyUniqueID, float TotalTime, List<int> _BlackListComboSkillIDList, List<int> _WhiteListComboSkillIDList)
	{
		WindowInfo = new ComboKeyCacheWindowInfo
		{
			MontageInstanceID = MontageInstanceID,
			NotifyUniqueID = NotifyUniqueID,
			TotalTime = TotalTime
		};
		BlackListComboSkillIDList = _BlackListComboSkillIDList;
		WhiteListComboSkillIDList = _WhiteListComboSkillIDList;
	}

	public void UpdateInfo(uint NotifyUniqueID, float TotalTime, List<int> _BlackListComboSkillIDList, List<int> _WhiteListComboSkillIDList)
	{
		if (WindowInfo != null)
		{
			WindowInfo.NotifyUniqueID = NotifyUniqueID;
			WindowInfo.TotalTime = TotalTime;
		}
		if (_BlackListComboSkillIDList != null)
		{
			if (BlackListComboSkillIDList == null)
			{
				BlackListComboSkillIDList = new List<int>();
			}
			BlackListComboSkillIDList.AddRange(_BlackListComboSkillIDList);
		}
		if (_WhiteListComboSkillIDList != null)
		{
			if (WhiteListComboSkillIDList == null)
			{
				WhiteListComboSkillIDList = new List<int>();
			}
			WhiteListComboSkillIDList.AddRange(_WhiteListComboSkillIDList);
		}
	}

	public void OverrideInfo(uint NotifyUniqueID, float TotalTime, List<int> _BlackListComboSkillIDList, List<int> _WhiteListComboSkillIDList)
	{
		if (WindowInfo != null)
		{
			WindowInfo.NotifyUniqueID = NotifyUniqueID;
			WindowInfo.TotalTime = TotalTime;
		}
		BlackListComboSkillIDList?.Clear();
		if (_BlackListComboSkillIDList != null)
		{
			BlackListComboSkillIDList = _BlackListComboSkillIDList;
		}
		WhiteListComboSkillIDList?.Clear();
		if (_WhiteListComboSkillIDList != null)
		{
			WhiteListComboSkillIDList = _WhiteListComboSkillIDList;
		}
	}

	public void UpdateWindowTime(float DeltaTime)
	{
		WindowInfo.TotalTime -= DeltaTime;
	}
}
