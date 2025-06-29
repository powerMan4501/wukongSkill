using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "设置单位战斗BGM" })]
public class BUEffectSetBattleBGM : BUEffectTemplate
{
	public BUEffectSetBattleBGM()
	{
		EffectType = EBuffAndSkillEffectType.SetUnitBattleBgm;
	}

	[TemplateFunNote("使用技能设置单位战斗BGM")]
	[ParamInfoS(0, "BGWDataAsset_SetUnitBattleBGM路径")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		if (bUS_GSEventCollection != null)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count > 0)
			{
				BGWDataAsset_SetUnitBattleBGM bGWDataAsset_SetUnitBattleBGM = BGW_PreloadAssetMgr.Get(Caster).TryGetCachedResourceObj<BGWDataAsset_SetUnitBattleBGM>(skillEffectDesc.EffectParamsStr[0], ELoadResourceType.SyncLoadAndCache);
				bUS_GSEventCollection.Evt_SetUnitBattleBGM.Invoke(bGWDataAsset_SetUnitBattleBGM.AkEventBegin, bGWDataAsset_SetUnitBattleBGM.AkEventStop, bGWDataAsset_SetUnitBattleBGM.BGMEventStopTimer, BGUFunctionLibraryCS.GetConditionStopEvents(bGWDataAsset_SetUnitBattleBGM.StopEventConditionConfig));
			}
		}
	}

	[ParamInfoS(0, "BGWDataAsset_SetUnitBattleBGM路径")]
	[AffectTarget]
	[TemplateFunNote("使用Buff设置单位战斗BGM")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 0)
			{
				BGWDataAsset_SetUnitBattleBGM bGWDataAsset_SetUnitBattleBGM = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_SetUnitBattleBGM>(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), ELoadResourceType.SyncLoadAndCache);
				bUS_GSEventCollection.Evt_SetUnitBattleBGM.Invoke(bGWDataAsset_SetUnitBattleBGM.AkEventBegin, bGWDataAsset_SetUnitBattleBGM.AkEventStop, bGWDataAsset_SetUnitBattleBGM.BGMEventStopTimer, BGUFunctionLibraryCS.GetConditionStopEvents(bGWDataAsset_SetUnitBattleBGM.StopEventConditionConfig));
			}
		}
	}
}
