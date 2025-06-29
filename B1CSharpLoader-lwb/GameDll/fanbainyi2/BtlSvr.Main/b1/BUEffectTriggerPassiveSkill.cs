using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "触发被动技能", "除开主角单位（包括变身），其余单位需要在FUStUnitPassiveSkillInfoExtend【单位被动技能信息扩展】表下定义ResID", "触发效果是通过俩ID【被动技能ID】和【被动技能映射索引ID】来定位表格信息", "触发效果时需要传入RoleLevel，对于主角单位会直接读取RoleData，其余单位默认都是1" })]
public class BUEffectTriggerPassiveSkill : BUEffectTemplate
{
	public BUEffectTriggerPassiveSkill()
	{
		EffectType = EBuffAndSkillEffectType.TriggerPassiveSkill;
	}

	[TemplateFunNote("Buff效果触发时，激活被动技能")]
	[ParamInfoI(0, "被动技能ID（参考FUStPassiveSkill【被动技能】表）")]
	[ParamInfoI(1, "被动技能映射索引ID（参考FUStPassiveSkill【被动技能】表）")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int level = 1;
		APawn aPawn = Target as APawn;
		if (aPawn != null && aPawn.IsPlayerControlled())
		{
			IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aPawn.PlayerState);
			if (readOnlyData != null)
			{
				level = readOnlyData.RoleLevel;
			}
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
		BUS_EventCollectionCS.Get(Target)?.Evt_PassiveSkillModifyParam.Invoke(intEffectParam, intEffectParam2, bRecover: false, level);
	}

	[TemplateFunNote("移除Buff时，移除被动技能")]
	[ParamInfoI(0, "被动技能ID（参考FUStPassiveSkill【被动技能】表）")]
	[ParamInfoI(1, "被动技能映射索引ID（参考FUStPassiveSkill【被动技能】表）")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int level = 1;
		APawn aPawn = Target as APawn;
		if (aPawn != null && aPawn.IsPlayerControlled())
		{
			IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(aPawn.PlayerState);
			if (readOnlyData != null)
			{
				level = readOnlyData.RoleLevel;
			}
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
		BUS_EventCollectionCS.Get(Target)?.Evt_PassiveSkillModifyParam.Invoke(intEffectParam, intEffectParam2, bRecover: true, level);
	}
}
