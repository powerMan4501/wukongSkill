using System.Collections.Generic;

namespace b1;

public class PreciseDodgeAwardsForData
{
	public List<GSBuffInfoForData> AddBuffList { get; } = new List<GSBuffInfoForData>();

	public List<int> RemoveBuffList { get; } = new List<int>();

	public List<int> SkillEffectIds { get; } = new List<int>();

	public int MaxAwardCount { get; set; }

	public PreciseDodgeAwardsForData(PreciseDodgeAwards PreciseDodgeAwards)
	{
		foreach (FGSBuffInfo addBuffId in PreciseDodgeAwards.AddBuffIds)
		{
			AddBuffList.Add(new GSBuffInfoForData(addBuffId.BuffID, addBuffId.BuffDuration));
		}
		RemoveBuffList.AddRange(PreciseDodgeAwards.RemoveBuffIds);
		SkillEffectIds.AddRange(PreciseDodgeAwards.SkillEffectIds);
		MaxAwardCount = PreciseDodgeAwards.MaxAwardCount;
	}
}
