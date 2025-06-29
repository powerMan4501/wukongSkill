using System.Collections.Generic;

namespace b1;

public class BUC_TalentData : IBUC_TalentData
{
	public Dictionary<int, int> ActivatingTalentDic;

	public BUC_TalentData()
	{
		ActivatingTalentDic = new Dictionary<int, int>();
	}

	public bool HasTalent(int TalentID)
	{
		if (ActivatingTalentDic != null && ActivatingTalentDic.TryGetValue(TalentID, out var _))
		{
			return true;
		}
		return false;
	}

	public int GetTalentLevel(int TalentID)
	{
		if (ActivatingTalentDic.TryGetValue(TalentID, out var value))
		{
			return value;
		}
		return 0;
	}
}
