using BtlB1;

namespace b1;

public struct SkillBiasInfo
{
	public int SkillID;

	public EGroupAIAttackBias AttackBias;

	public SkillBiasInfo(int _SkillID, EGroupAIAttackBias _AttackBias)
	{
		SkillID = _SkillID;
		AttackBias = _AttackBias;
	}
}
