using System.Collections.Generic;

namespace b1;

public class MFEffectForData
{
	public MFOverlapEventType OverlapEventType { get; }

	public List<GSBuffInfoForData> BuffList { get; } = new List<GSBuffInfoForData>();

	public List<int> SkillEffectList { get; } = new List<int>();

	public int SpecificFlags { get; }

	public MFEffectForData(in MFEffect InEffect)
	{
		OverlapEventType = InEffect.OverlapEventType;
		foreach (FGSBuffInfo buff in InEffect.BuffList)
		{
			BuffList.Add(new GSBuffInfoForData(buff.BuffID, buff.BuffDuration));
		}
		SkillEffectList.AddRange(InEffect.SkillEffectList);
		SpecificFlags = InEffect.SpecificFlags;
	}
}
