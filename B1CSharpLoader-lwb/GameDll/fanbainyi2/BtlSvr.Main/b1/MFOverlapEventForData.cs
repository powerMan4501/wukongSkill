using System.Collections.Generic;
using System.Linq;

namespace b1;

public class MFOverlapEventForData
{
	public MFOverlapEventType OverlapEventType { get; }

	public int TargetTeamFilter { get; }

	public int TargetTypeFilter { get; }

	public List<GSBuffInfoForData> BuffList { get; } = new List<GSBuffInfoForData>();

	public List<int> SkillEffectList { get; } = new List<int>();

	public string note { get; }

	public MFOverlapEventForData(in MFOverlapEvent MFOE)
	{
		OverlapEventType = MFOE.OverlapEventType;
		TargetTeamFilter = MFOE.TargetTeamFilter;
		TargetTypeFilter = MFOE.TargetTypeFilter;
		note = MFOE.note;
		BuffList.Clear();
		foreach (FGSBuffInfo item in MFOE.BuffList.ToList())
		{
			BuffList.Add(new GSBuffInfoForData(item.BuffID, item.BuffDuration));
		}
		SkillEffectList.Clear();
		foreach (int skillEffect in MFOE.SkillEffectList)
		{
			SkillEffectList.Add(skillEffect);
		}
	}
}
