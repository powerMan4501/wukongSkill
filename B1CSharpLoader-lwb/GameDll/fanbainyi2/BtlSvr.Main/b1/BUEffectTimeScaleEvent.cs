using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "生效时，根据DA（BGWDataAsset_ScaleTimeSetting）配置的内容，设置时间膨胀系数", "Buff触发时与Buff持续时间无关，以DA中填写的TotalTime为准" })]
public class BUEffectTimeScaleEvent : BUEffectTemplate
{
	public BUEffectTimeScaleEvent()
	{
		EffectType = EBuffAndSkillEffectType.TimeScale;
	}

	[TemplateFunNote("通过技能触发时间膨胀")]
	[ParamInfoS(0, "ScaleTimeSetting DA路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count >= 1)
		{
			string path = skillEffectDesc.EffectParamsStr[0];
			BGWDataAsset_ScaleTimeSetting bGWDataAsset_ScaleTimeSetting = BGW_PreloadAssetMgr.Get(Caster).TryGetCachedResourceObj<BGWDataAsset_ScaleTimeSetting>(path, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_ScaleTimeSetting != null)
			{
				FGSTimeScaleSetting timeScaleSetting = new FGSTimeScaleSetting
				{
					TimeScale = bGWDataAsset_ScaleTimeSetting.TimeScale,
					BlendInRealTime = bGWDataAsset_ScaleTimeSetting.BlendInRealTime,
					BlendInType = bGWDataAsset_ScaleTimeSetting.BlendInType,
					BlendInExp = bGWDataAsset_ScaleTimeSetting.BlendInExp,
					BlendOutRealTime = bGWDataAsset_ScaleTimeSetting.BlendOutRealTime,
					BlendOutType = bGWDataAsset_ScaleTimeSetting.BlendOutType,
					BlendOutExp = bGWDataAsset_ScaleTimeSetting.BlendOutExp
				};
				BUS_EventCollectionCS.Get(Target).Evt_TriggerScaleTime.Invoke(timeScaleSetting, bGWDataAsset_ScaleTimeSetting.TotalTime);
			}
		}
	}

	[ParamInfoS(1, "铜头铁臂打破 ScaleTimeSetting DA路径")]
	[ParamInfoS(0, "ScaleTimeSetting DA路径")]
	[TemplateFunNote("通过Buff触发时间膨胀")]
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
			if (BGU_DataUtil.GetReadOnlyData<BUC_IronBodyData>(Target).IsDefeat)
			{
				stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
			}
			BGWDataAsset_ScaleTimeSetting bGWDataAsset_ScaleTimeSetting = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_ScaleTimeSetting>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_ScaleTimeSetting != null)
			{
				FGSTimeScaleSetting timeScaleSetting = new FGSTimeScaleSetting
				{
					TimeScale = bGWDataAsset_ScaleTimeSetting.TimeScale,
					BlendInRealTime = bGWDataAsset_ScaleTimeSetting.BlendInRealTime,
					BlendInType = bGWDataAsset_ScaleTimeSetting.BlendInType,
					BlendInExp = bGWDataAsset_ScaleTimeSetting.BlendInExp,
					BlendOutRealTime = bGWDataAsset_ScaleTimeSetting.BlendOutRealTime,
					BlendOutType = bGWDataAsset_ScaleTimeSetting.BlendOutType,
					BlendOutExp = bGWDataAsset_ScaleTimeSetting.BlendOutExp
				};
				BUS_EventCollectionCS.Get(Target).Evt_TriggerScaleTime.Invoke(timeScaleSetting, bGWDataAsset_ScaleTimeSetting.TotalTime);
			}
		}
	}
}
