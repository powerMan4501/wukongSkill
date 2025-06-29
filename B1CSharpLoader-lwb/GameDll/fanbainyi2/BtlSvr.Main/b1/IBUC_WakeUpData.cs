using System.Collections.Generic;

namespace b1;

public interface IBUC_WakeUpData
{
	List<int> SurpriseSkillID { get; }

	bool WakeUpLinkEnable { get; }

	bool CanTriggerWakeUpLinkWhenDead { get; }

	bool HasTriggerWakeUp { get; }

	bool UseManualSelect { get; }

	bool UseRangeSelect { get; }

	List<string> ManualTargetGuidList { get; }

	bool bSelectUnitHasTarget { get; }

	bool bSelectPassiveUnit { get; }

	List<int> ResIDList { get; }

	float RangeParam_1 { get; }

	float RangeParam_2 { get; }

	float RangeParam_3 { get; }
}
