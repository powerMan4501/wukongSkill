using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public abstract class BUFixFunctionTemplate
{
	protected EFixFunctionType Type;

	protected BUFixFunctionTemplate()
	{
		Type = EFixFunctionType.None;
	}

	public static void RunBySkillApply(AActor Caster, AActor Target, int FixFunctionID, out float OutAbs, out float OutMul)
	{
		OutAbs = 0f;
		OutMul = 0f;
		FUStFixFunctionDesc fixFunctionDesc = BGW_GameDB.GetFixFunctionDesc(FixFunctionID);
		if (fixFunctionDesc == null)
		{
			BGW_LogUtil.LogError("Failed to find FixFunction with invalid ID: " + FixFunctionID);
		}
		else
		{
			BGW_EffectTemplateList.Get(Target).GetFixFunctionTemplate(fixFunctionDesc.FixFunctionType).ApplyBySkill(Caster, Target, fixFunctionDesc.Param1, fixFunctionDesc.Param2, fixFunctionDesc.Param3, fixFunctionDesc.Param4, fixFunctionDesc.Param5, fixFunctionDesc.Param6, out OutAbs, out OutMul);
		}
	}

	public static void RunByBuffApply(AActor Caster, AActor Target, int FixFunctionID, out float OutAbs, out float OutMul)
	{
		OutAbs = 0f;
		OutMul = 0f;
		FUStFixFunctionDesc fixFunctionDesc = BGW_GameDB.GetFixFunctionDesc(FixFunctionID);
		if (fixFunctionDesc == null)
		{
			BGW_LogUtil.LogError("Failed to find FixFunction with invalid ID: " + FixFunctionID);
		}
		else
		{
			BGW_EffectTemplateList.Get(Target).GetFixFunctionTemplate(fixFunctionDesc.FixFunctionType).ApplyByBuff(Caster, Target, fixFunctionDesc.Param1, fixFunctionDesc.Param2, fixFunctionDesc.Param3, fixFunctionDesc.Param4, fixFunctionDesc.Param5, fixFunctionDesc.Param6, out OutAbs, out OutMul);
		}
	}

	public virtual void ApplyBySkill(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		OutAbs = 0f;
		OutMul = 0f;
	}

	public virtual void ApplyByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		OutAbs = 0f;
		OutMul = 0f;
	}

	public virtual void RemoveByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		OutAbs = 0f;
		OutMul = 0f;
	}
}
