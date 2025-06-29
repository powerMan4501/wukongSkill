using BtlB1;

namespace b1;

public class GAAI_FSM_2_Attack : IGroupAIActionInfo
{
	private EGroupAIAttackBias AIAttackBias;

	private int CostToken;

	public bool IsNoMoveAtk;

	public GAAI_FSM_2_Attack(EGroupAIAttackBias _AIAttackBias, int _CostToken, bool _IsNoMoveAtk)
	{
		AIAttackBias = _AIAttackBias;
		CostToken = _CostToken;
		IsNoMoveAtk = _IsNoMoveAtk;
	}

	public EGroupAIAttackBias GetActionAIAttackBias()
	{
		return AIAttackBias;
	}

	public int GetCostToken()
	{
		return CostToken;
	}
}
