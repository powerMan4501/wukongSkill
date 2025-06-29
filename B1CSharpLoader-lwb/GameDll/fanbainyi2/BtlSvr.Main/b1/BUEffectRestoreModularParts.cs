using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectCaster]
public class BUEffectRestoreModularParts : BUEffectTemplate
{
	public BUEffectRestoreModularParts()
	{
		EffectType = EBuffAndSkillEffectType.RestoreModularParts;
	}

	[ParamInfoS(0, "需要恢复的骨骼名")]
	[ParamInfoS(1, "DA路径（BGWDataAsset_TigerWoodsConfig）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			string boneName = ((skillEffectDesc.EffectParamsStr.Count > 0) ? skillEffectDesc.EffectParamsStr[0] : "");
			string tigerWoodsDataAssetPath = ((skillEffectDesc.EffectParamsStr.Count > 1) ? skillEffectDesc.EffectParamsStr[1] : "");
			BUS_EventCollectionCS.Get(Caster).Evt_RestoreModularParts.Invoke(boneName, tigerWoodsDataAssetPath);
		}
	}
}
