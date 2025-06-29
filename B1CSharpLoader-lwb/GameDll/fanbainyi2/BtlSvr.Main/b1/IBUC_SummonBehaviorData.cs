using System.Collections.Generic;
using UnrealEngine.AIModule;

namespace b1;

internal interface IBUC_SummonBehaviorData
{
	ESummonBehaviorState BehaviorState { get; }

	Dictionary<ESummonBehaviorState, UBehaviorTree> MapStateBehaviorTree { get; }

	Queue<int> QueueSkillID { get; }

	bool bSummonBehaviorUsingSkill { get; }

	float SummonAliveTimer { get; }

	b1.ESpecialSummonBehaviorType SpecialSummonBehaviorType { get; }

	bool GetSummonDisappearInfo(out List<string> MontagePathList, out float DestroyDelayTime);

	bool IsServant();
}
