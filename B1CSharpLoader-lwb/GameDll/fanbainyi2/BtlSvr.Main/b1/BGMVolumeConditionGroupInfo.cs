using System.Collections.Generic;

namespace b1;

internal class BGMVolumeConditionGroupInfo
{
	public List<b1.BGMVolumeConditionInfo> Conditions;

	public BGMVolumeConditionGroupInfo(FBGMVolumeConditionGroup ConditionGroup)
	{
		Conditions = new List<b1.BGMVolumeConditionInfo>();
		foreach (FBGMVolumeCondition condition in ConditionGroup.Conditions)
		{
			Conditions.Add(new b1.BGMVolumeConditionInfo(condition));
		}
	}
}
