using BtlB1;

namespace b1;

public class GAAI_EnableGroupAI : IGroupAIActionInfo
{
	public bool IsEnable;

	public EGroupAIAttackBias GetActionAIAttackBias()
	{
		return EGroupAIAttackBias.None;
	}

	public int GetCostToken()
	{
		return 0;
	}
}
