using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "幻化变身" })]
public class BUEffectMagicallyChange : BUEffectTemplate
{
	public BUEffectMagicallyChange()
	{
		EffectType = EBuffAndSkillEffectType.MagicallyChange;
	}

	[TemplateFunNote("幻化变身 通过skill")]
	[ParamInfoS(0, "DAPath")]
	[ParamInfoI(0, "幻化变身技能Id")]
	[ParamInfoI(1, "幻化变身还原技能ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count > 0 && skillEffectDesc.EffectParamsInt.Count > 1)
		{
			string path = skillEffectDesc.EffectParamsStr[0];
			BGWDataAsset_MagicallyChangeConfig bGWDataAsset_MagicallyChangeConfig = new BGWDataAsset_MagicallyChangeConfig();
			bGWDataAsset_MagicallyChangeConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(path, ELoadResourceType.SyncLoadAndCache);
			if (!(bGWDataAsset_MagicallyChangeConfig == null))
			{
				int skillID = skillEffectDesc.EffectParamsInt[0];
				int recoverSkillID = skillEffectDesc.EffectParamsInt[1];
				BUS_EventCollectionCS.Get(Target).Evt_OnCastMagicallyChangeSkill.Invoke(bGWDataAsset_MagicallyChangeConfig, skillID, recoverSkillID);
			}
		}
	}

	[TemplateFunNote("幻化变身 通过buff")]
	[ParamInfoS(0, "DAPath")]
	[ParamInfoI(0, "幻化变身技能Id")]
	[ParamInfoI(1, "幻化变身还原技能ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BGWDataAsset_MagicallyChangeConfig bGWDataAsset_MagicallyChangeConfig = new BGWDataAsset_MagicallyChangeConfig();
			bGWDataAsset_MagicallyChangeConfig = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(stringEffectParam, ELoadResourceType.SyncLoadAndCache);
			if (!(bGWDataAsset_MagicallyChangeConfig == null))
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
				BUS_EventCollectionCS.Get(Target).Evt_OnCastMagicallyChangeSkill.Invoke(bGWDataAsset_MagicallyChangeConfig, intEffectParam, intEffectParam2);
			}
		}
	}
}
