using System.Collections.Generic;

namespace b1;

public class BUC_AnimNotifyAndStateData : b1.IBUC_AnimNotifyAndStateData
{
	private readonly int GS_INVALID_ID = -1;

	private readonly int GS_MAX_AM_SKILL_BINDING_NUM = 5;

	private List<FOneSkillMontageBindingInfo> MongtageSkillBindingList = new List<FOneSkillMontageBindingInfo>();

	public int FindBindingSkillID(int MontageInstanceID = -1)
	{
		int count = MongtageSkillBindingList.Count;
		if (MontageInstanceID == GS_INVALID_ID)
		{
			if (count > 0)
			{
				return MongtageSkillBindingList[0].SkillID;
			}
			return GS_INVALID_ID;
		}
		for (int i = 0; i < count; i++)
		{
			if (MongtageSkillBindingList[i].MontageInstanceID == MontageInstanceID)
			{
				return MongtageSkillBindingList[i].SkillID;
			}
		}
		return GS_INVALID_ID;
	}

	public void RebindSkillID(int SkillID, int MontageInstanceID)
	{
		if (MongtageSkillBindingList.Count >= GS_MAX_AM_SKILL_BINDING_NUM)
		{
			MongtageSkillBindingList.RemoveAt(0);
		}
		MongtageSkillBindingList.Add(new FOneSkillMontageBindingInfo(MontageInstanceID, SkillID));
	}
}
