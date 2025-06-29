using System.Collections.Generic;

namespace b1;

public class MFEventForData
{
	public int TargetTeamFilter { get; }

	public int TargetTypeFilter { get; }

	public bool bIgnoreFilter { get; }

	public List<MFEffectForData> MFEffectList { get; } = new List<MFEffectForData>();

	public MFEventForData(in MFEvent InEvent)
	{
		TargetTeamFilter = InEvent.TargetTeamFilter;
		TargetTypeFilter = InEvent.TargetTypeFilter;
		bIgnoreFilter = InEvent.bIgnoreTypeFilter;
		foreach (MFEffect mFEffect in InEvent.MFEffectList)
		{
			MFEffect InEffect = mFEffect;
			MFEffectList.Add(new MFEffectForData(in InEffect));
		}
	}
}
