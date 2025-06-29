using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectTemplate
{
	protected EBuffAndSkillEffectType EffectType;

	public void ApplyBySkill(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (CheckIsAllowedTarget(Target, EffectID))
		{
			ApplyBySkill_Implement(EffectID, Caster, Target, in EffectInstReq);
		}
	}

	protected virtual void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
	}

	public void ApplyByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (CheckIsAllowedTarget(Target, EffectIdx))
		{
			ApplyByBuff_Implement(BuffInst, Target, EffectIdx, in EffectInstReq, bIsPeriodical);
		}
	}

	protected virtual void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
	}

	public virtual void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}

	private EBuffAndSkillEffectCategory GetSkillEffectCategory(int EffectID)
	{
		if (BGW_GameDB.GetAllSkillEffectDesc().TryGetValue(EffectID, out var value))
		{
			return value.EffectCategory;
		}
		return EBuffAndSkillEffectCategory.Neutral;
	}

	protected virtual bool CheckIsAllowedTarget(AActor Target, int EffectID)
	{
		if (b1.BUS_BuffComp.BuffEffectCategoryImmuneSimpleStateDict.TryGetValue(GetSkillEffectCategory(EffectID), out var value))
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Target);
			if (readOnlyData == null)
			{
				return true;
			}
			return !readOnlyData.HasSimpleState(value);
		}
		return true;
	}

	public void ApplyBySkillPredict(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (CheckIsAllowedTarget(Target, EffectID))
		{
			ApplyBySkillPredict_Implement(EffectID, Caster, Target, in EffectInstReq);
		}
	}

	protected virtual void ApplyBySkillPredict_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
	}

	public void ApplyByBuffPredict(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq)
	{
		if (CheckIsAllowedTarget(Target, EffectIdx))
		{
			ApplyByBuffPredict_Implement(BuffInst, Target, EffectIdx, in EffectInstReq);
		}
	}

	protected virtual void ApplyByBuffPredict_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq)
	{
	}

	public virtual void RemoveByBuffPredict(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}

	public void ApplyBySkillRollBack(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (CheckIsAllowedTarget(Target, EffectID))
		{
			ApplyBySkillRollBack_Implement(EffectID, Caster, Target, in EffectInstReq);
		}
	}

	protected virtual void ApplyBySkillRollBack_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
	}

	public void ApplyByBuffRollBack(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq)
	{
		if (CheckIsAllowedTarget(Target, EffectIdx))
		{
			ApplyByBuffRollBack_Implement(BuffInst, Target, EffectIdx, in EffectInstReq);
		}
	}

	protected virtual void ApplyByBuffRollBack_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq)
	{
	}

	public virtual void RemoveByBuffRollBack(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}
}
