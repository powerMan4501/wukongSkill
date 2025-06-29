using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "应用环境遮罩（身上覆雪，血等）" })]
public class BUEffectApplyEnvironmentMask : BUEffectTemplate
{
	public BUEffectApplyEnvironmentMask()
	{
		EffectType = EBuffAndSkillEffectType.ApplyEnvironmentMask;
	}

	[TemplateFunNote("通过技能效果应用环境遮罩")]
	[ParamInfoS(0, "EnvironmentMaskConfig DA的路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc.EffectParamsStr.Count >= 1)
		{
			string path = skillEffectDesc.EffectParamsStr[0];
			BGWDataAsset_EnvironmentMaskConfig bGWDataAsset_EnvironmentMaskConfig = BGW_PreloadAssetMgr.Get(Caster).TryGetCachedResourceObj<BGWDataAsset_EnvironmentMaskConfig>(path, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_EnvironmentMaskConfig != null)
			{
				BUS_EventCollectionCS.Get(Target)?.Evt_ApplyEnvironmentMask.Invoke(bGWDataAsset_EnvironmentMaskConfig.EnvironmentMaskDataList.ToList());
			}
		}
	}

	[TemplateFunNote("通过Buff应用环境遮罩")]
	[ParamInfoS(0, "EnvironmentMaskConfig DA的路径")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetStringEffectParamCount(EffectIdx) >= 1)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BGWDataAsset_EnvironmentMaskConfig bGWDataAsset_EnvironmentMaskConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_EnvironmentMaskConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_EnvironmentMaskConfig != null)
			{
				BUS_EventCollectionCS.Get(Target)?.Evt_ApplyEnvironmentMask.Invoke(bGWDataAsset_EnvironmentMaskConfig.EnvironmentMaskDataList.ToList());
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}
}
