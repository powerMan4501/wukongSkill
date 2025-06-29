using System.Collections.Generic;
using UnrealEngine.AIModule;

namespace b1;

internal class BUC_SummonBehaviorData : b1.IBUC_SummonBehaviorData
{
	public bool FinishSummonInit;

	public bool bNeedUpdateForSetBTActive;

	public bool bNeedUpdateForContinueBehavior;

	public FContinueBehaviorInfo CBI;

	public FServantInstanceBase ServantInstance { get; set; }

	public ESummonBehaviorState BehaviorState { get; set; }

	public Dictionary<ESummonBehaviorState, UBehaviorTree> MapStateBehaviorTree { get; set; }

	public Queue<int> QueueSkillID { get; set; }

	public bool bSummonBehaviorUsingSkill { get; set; }

	public float SummonAliveTimer { get; set; }

	public b1.ESpecialSummonBehaviorType SpecialSummonBehaviorType { get; set; }

	public bool GetSummonDisappearInfo(out List<string> MontagePathList, out float DestroyDelayTime)
	{
		if (ServantInstance != null)
		{
			ServantInstance.GetSummonDisappearInfo(out MontagePathList, out DestroyDelayTime);
			return true;
		}
		MontagePathList = new List<string>();
		DestroyDelayTime = 0f;
		return false;
	}

	public bool IsServant()
	{
		return ServantInstance != null;
	}

	public void InitSummonBehaviorData()
	{
		FinishSummonInit = false;
		BehaviorState = ESummonBehaviorState.Default;
		bNeedUpdateForSetBTActive = false;
		bNeedUpdateForContinueBehavior = false;
		CBI = default(FContinueBehaviorInfo);
		SpecialSummonBehaviorType = b1.ESpecialSummonBehaviorType.None;
		MapStateBehaviorTree = new Dictionary<ESummonBehaviorState, UBehaviorTree>();
		QueueSkillID = new Queue<int>();
		for (int i = 0; i < 3; i++)
		{
			MapStateBehaviorTree.Add((ESummonBehaviorState)i, null);
		}
	}
}
