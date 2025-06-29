using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectPlayCameraShake : BUEffectTemplate
{
	public BUEffectPlayCameraShake()
	{
		EffectType = EBuffAndSkillEffectType.PlayCameraShake;
	}

	[ParamInfoS(0, "CameraShakeDA路径（BGWDataAsset_CameraShakeWithControl）")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc.EffectParamsStr.Count >= 1)
		{
			BGUFunctionLibraryCS.PlayCamShakeWithControl(skillEffectDesc.EffectParamsStr[0], Target);
		}
	}

	[ParamInfoS(0, "CameraShakeDA路径（BGWDataAsset_CameraShakeWithControl）")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && EffectIdx <= buffDescRuntime.GetEffectsCount() - 1 && buffDescRuntime.GetStringEffectParamCount(EffectIdx) >= 1)
			{
				BGUFunctionLibraryCS.PlayCamShakeWithControl(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), Target);
			}
		}
	}
}
