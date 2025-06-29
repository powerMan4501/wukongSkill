using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class GAAI_PRIO_ACT_MoveToPos : IGroupAIActionInfo
{
	public FVector GoalPos;

	public float WaitTime;

	public EAIMoveSpeedType SpeedType;

	public EBGUMoveAIType MoveAIType;

	public GAAI_PRIO_ACT_MoveToPos(FVector _GoalPos, float _WaitTime, EAIMoveSpeedType _SpeedType, EBGUMoveAIType _MoveAIType)
	{
		GoalPos = _GoalPos;
		WaitTime = _WaitTime;
		SpeedType = _SpeedType;
		MoveAIType = _MoveAIType;
	}

	public GAAI_PRIO_ACT_MoveToPos(GAAI_PRIO_ACT_MoveToPos Other)
	{
		GoalPos = Other.GoalPos;
		WaitTime = Other.WaitTime;
		SpeedType = Other.SpeedType;
		MoveAIType = Other.MoveAIType;
	}

	public EGroupAIAttackBias GetActionAIAttackBias()
	{
		return EGroupAIAttackBias.None;
	}

	public int GetCostToken()
	{
		return 0;
	}
}
