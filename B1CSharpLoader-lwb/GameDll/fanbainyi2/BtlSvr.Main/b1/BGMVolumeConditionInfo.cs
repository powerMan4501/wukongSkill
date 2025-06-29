using System.Collections.Generic;

namespace b1;

internal class BGMVolumeConditionInfo
{
	public EBGMVolumeConditionType Condition;

	public bool InverseCondition;

	public List<FGsActorGuidReference> Actors;

	public EBGMVolumeConditionSusCountType ConditionSusCountType;

	public BGMVolumeConditionInfo(FBGMVolumeCondition VolumeCondition)
	{
		Condition = VolumeCondition.Condition;
		InverseCondition = VolumeCondition.InverseCondition;
		Actors = new List<FGsActorGuidReference>(VolumeCondition.Actors);
		ConditionSusCountType = VolumeCondition.ConditionSusCountType;
	}
}
