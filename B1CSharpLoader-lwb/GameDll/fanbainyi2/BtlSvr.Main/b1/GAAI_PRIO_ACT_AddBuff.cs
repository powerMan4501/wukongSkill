using System.Collections.Generic;
using BtlB1;

namespace b1;

public class GAAI_PRIO_ACT_AddBuff : IGroupAIActionInfo
{
	public List<int> BuffIDList;

	public GAAI_PRIO_ACT_AddBuff(List<int> _BuffIDList)
	{
		BuffIDList = _BuffIDList;
	}

	public GAAI_PRIO_ACT_AddBuff(GAAI_PRIO_ACT_AddBuff Other)
	{
		BuffIDList = Other.BuffIDList;
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
