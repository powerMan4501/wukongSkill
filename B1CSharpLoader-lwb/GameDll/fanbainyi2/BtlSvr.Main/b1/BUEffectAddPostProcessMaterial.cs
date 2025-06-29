using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "添加后处理材质" })]
public class BUEffectAddPostProcessMaterial : BUEffectTemplate
{
	public BUEffectAddPostProcessMaterial()
	{
		EffectType = EBuffAndSkillEffectType.AddPostProcessMaterial;
	}

	[ParamInfoS(0, "DAPath")]
	[TemplateFunNote("添加后处理材质")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target) || !(Target is APawn aPawn) || !aPawn.IsLocallyControlled())
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() <= EffectIdx || buffDescRuntime.GetStringEffectParamCount(EffectIdx) < 1)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		if (!string.IsNullOrEmpty(stringEffectParam))
		{
			BGWDataAsset_PostProcessMatSetting bGWDataAsset_PostProcessMatSetting = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_PostProcessMatSetting>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
			if (bGWDataAsset_PostProcessMatSetting != null)
			{
				BPS_EventCollectionCS.GetLocal(aPawn)?.Evt_AddPostProcessMat.Invoke(EPostProcessSource.Buff, BuffInst.BuffID, Target, bGWDataAsset_PostProcessMatSetting);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (Target is APawn aPawn && (!aPawn.IsPawnControlled() || aPawn.IsLocallyControlled()))
		{
			BPS_EventCollectionCS.GetLocal(aPawn)?.Evt_RemovePostProcessMat.Invoke(EPostProcessSource.Buff, BuffInst.BuffID);
		}
	}
}
