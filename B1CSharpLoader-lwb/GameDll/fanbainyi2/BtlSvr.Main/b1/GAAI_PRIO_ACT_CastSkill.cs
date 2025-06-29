using BtlB1;

namespace b1;

public class GAAI_PRIO_ACT_CastSkill : IGroupAIActionInfo
{
	public int SkillID;

	public GAAI_PRIO_ACT_CastSkill(int _SkillID)
	{
		SkillID = _SkillID;
	}

	public GAAI_PRIO_ACT_CastSkill(GAAI_PRIO_ACT_CastSkill Other)
	{
		SkillID = Other.SkillID;
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
