using UnrealEngine.Runtime;

namespace b1;

public class BossRushDamageInfo_PerRand
{
	public float TotalDmg;

	public float CritDmg;

	public float HightestDmg;

	public float ElemDotDmg;

	public float BeHurtedDmg;

	public void Clear()
	{
		TotalDmg = 0f;
		CritDmg = 0f;
		HightestDmg = 0f;
		ElemDotDmg = 0f;
		BeHurtedDmg = 0f;
	}

	public void OnMonsterBeHurted(float Dmg, bool bIsCrit, bool bIsElemDotDmg)
	{
		if (!(Dmg <= 0f))
		{
			TotalDmg += Dmg;
			if (bIsCrit)
			{
				CritDmg += Dmg;
			}
			if (bIsElemDotDmg)
			{
				ElemDotDmg += Dmg;
			}
			HightestDmg = FMath.Max(HightestDmg, Dmg);
		}
	}

	public void OnPlayerBeHurted(float Dmg)
	{
		BeHurtedDmg += Dmg;
	}
}
