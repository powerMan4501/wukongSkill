using System.Collections.Generic;
using BtlShare;

namespace b1;

public static class BulletRPCEffect
{
	public static List<EBuffAndSkillEffectType> BulletRPCEffectList = new List<EBuffAndSkillEffectType>
	{
		EBuffAndSkillEffectType.SkillDamage,
		EBuffAndSkillEffectType.RecoverAttr,
		EBuffAndSkillEffectType.AccumulateAbnormalValue,
		EBuffAndSkillEffectType.AddBuff,
		EBuffAndSkillEffectType.SummonUnit
	};
}
