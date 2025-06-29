using BtlB1;

namespace b1;

public class GAAI_FSM_2_Wander : IGroupAIActionInfo
{
	public float MaxWanderTime;

	public EGroupAIAttackBias GetActionAIAttackBias()
	{
		return EGroupAIAttackBias.None;
	}

	public int GetCostToken()
	{
		return 0;
	}
}
