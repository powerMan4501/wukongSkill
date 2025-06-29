using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "用于召唤单位" })]
public class BUEffectSummonUnit : BUEffectTemplate
{
	public BUEffectSummonUnit()
	{
		EffectType = EBuffAndSkillEffectType.SummonUnit;
	}

	[ParamInfoI(0, "召唤ID")]
	[ParamInfoI(1, "当生成点类型为使用手动生成点数据时，代表SummonSpawnPointList里的序号;当生成点类型为Eqs时，代表Summon数量")]
	[ParamInfoI(2, "是否传送自己，1传送，否则不传送")]
	[TemplateFunNote("通过技能效果召唤单位。使用Target进行EQS选点")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 1)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection == null))
		{
			BGW_LogUtil.LogIfNull(Target as BGUCharacterCS, "CurCharacter Is Not ABGUCharacter");
			bool teleportSelf = false;
			if (skillEffectDesc.EffectParamsInt.Count > 2 && skillEffectDesc.EffectParamsInt[2] == 1)
			{
				teleportSelf = true;
			}
			bUS_GSEventCollection.Evt_SummonSkillCast.Invoke(skillEffectDesc.EffectParamsInt[0], skillEffectDesc.EffectParamsInt[1], Caster, in EffectInstReq, teleportSelf);
		}
	}

	[ParamInfoI(2, "是否传送自己，1传送，否则不传送")]
	[ParamInfoI(1, "当生成点类型为使用手动生成点数据时，代表SummonSpawnPointList里的序号;当生成点类型为Eqs时，代表Summon数量")]
	[TemplateFunNote("添加Buff时召唤单位。若配置的int参数数量超过2个，则使用BuffOwner来进行EQS选点，否则使用Target")]
	[ParamInfoI(0, "召唤ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target) || Target as BGUCharacterCS == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (buffDescRuntime != null && intEffectParamCount >= 1 && !(BUS_EventCollectionCS.Get(Target) == null))
		{
			BGUCharacterCS obj = Target as BGUCharacterCS;
			BGW_LogUtil.LogIfNull(obj, "CurCharacter Is Not ABGUCharacter");
			bool teleportSelf = false;
			if (intEffectParamCount > 2 && buffDescRuntime.GetIntEffectParam(EffectIdx, 2) == 1)
			{
				teleportSelf = true;
			}
			AActor aActor = EntitySharedRefFuncLib.Actor(BuffInst.OwnerRef);
			bool flag = intEffectParamCount > 2;
			BUS_EventCollectionCS.Get(obj).Evt_SummonSkillCast.Invoke(buffDescRuntime.GetIntEffectParam(EffectIdx, 0), buffDescRuntime.GetIntEffectParam(EffectIdx, 1), EntitySharedRefFuncLib.Actor(BuffInst.CasterRef), in EffectInstReq, teleportSelf, flag ? aActor : null);
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		b1.EffectTemplateUtil.ReturnIfUnitDead(Target);
	}
}
