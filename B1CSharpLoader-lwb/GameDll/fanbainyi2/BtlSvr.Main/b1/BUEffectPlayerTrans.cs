using BtlShare;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "主角变身" })]
public class BUEffectPlayerTrans : BUEffectTemplate
{
	public BUEffectPlayerTrans()
	{
		EffectType = EBuffAndSkillEffectType.PlayerTrans;
	}

	[ParamInfoI(2, "是否镜头过渡到新单位 1为ture 其他false")]
	[TemplateFunNote("主角变身 通过skill")]
	[ParamInfoI(0, "变身ResId ResId为悟空则是变回悟空")]
	[ParamInfoI(1, "变身出生技能Id")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
		int skillEffectDescIntEffectParam2 = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 1);
		bool flag = true;
		bool flag2 = false;
		if (skillEffectDesc.EffectParamsInt.Count > 2)
		{
			flag = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 2) == 1;
		}
		if (skillEffectDesc.EffectParamsInt.Count > 3)
		{
			flag2 = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 3) == 1;
		}
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
		if (flag2)
		{
			PlayerTransParam playerTransParam = new PlayerTransParam
			{
				TargetResId = skillEffectDescIntEffectParam,
				SpawnSkillId = skillEffectDescIntEffectParam2,
				NeedBlend = flag
			};
			BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get((Target as BGUPlayerCharacterCS).PlayerState);
			if (bPS_GSEventCollection != null)
			{
				if (commLogicCfgValue == skillEffectDescIntEffectParam)
				{
					bPS_GSEventCollection.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.Plot, playerTransParam);
				}
				else
				{
					bPS_GSEventCollection.Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.Plot, playerTransParam);
				}
			}
		}
		else if (commLogicCfgValue == skillEffectDescIntEffectParam)
		{
			BUS_EventCollectionCS.Get(Target).Evt_TransBackSpawnNewOne.Invoke(skillEffectDescIntEffectParam, skillEffectDescIntEffectParam2, flag, EPlayerTransEndType.SkillEffect);
		}
		else
		{
			BUS_EventCollectionCS.Get(Target).Evt_TransBeginSpawnNewOne.Invoke(skillEffectDescIntEffectParam, skillEffectDescIntEffectParam2, flag, EPlayerTransBeginType.SkillEffect);
		}
	}

	[TemplateFunNote("主角变身 通过buff")]
	[ParamInfoI(0, "变身ResId ResId为悟空则是变回悟空")]
	[ParamInfoI(1, "变身出生技能Id")]
	[ParamInfoI(2, "是否镜头过渡到新单位 1为ture 其他false")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
			bool needBlend = true;
			bool flag = false;
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 2)
			{
				needBlend = buffDescRuntime.GetIntEffectParam(EffectIdx, 2) == 1;
			}
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 3)
			{
				flag = buffDescRuntime.GetIntEffectParam(EffectIdx, 3) == 1;
			}
			PlayerTransParam playerTransParam = new PlayerTransParam
			{
				TargetResId = intEffectParam,
				SpawnSkillId = intEffectParam2,
				NeedBlend = needBlend
			};
			APawn aPawn = Target as APawn;
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
			EPlayerTransEndType unitTransType = EPlayerTransEndType.Buff;
			EPlayerTransBeginType unitTransType2 = EPlayerTransBeginType.AddBuff;
			if (flag)
			{
				unitTransType = EPlayerTransEndType.Plot;
				unitTransType2 = EPlayerTransBeginType.Plot;
			}
			if (commLogicCfgValue == intEffectParam)
			{
				BPS_EventCollectionCS.Get(aPawn.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(unitTransType, playerTransParam);
				return;
			}
			_ = DebugConfig.DebugPlayerTransLog;
			BPS_EventCollectionCS.Get(aPawn.PlayerState)?.Evt_TriggerPlayerTransBegin.Invoke(unitTransType2, playerTransParam);
		}
	}
}
