using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换阵营的同时会尝试范围搜索目标", "移除Buff时会根据UnitComm表和NPC数据，回到原有的阵营" })]
[AffectTarget]
public class BUEffectSwitchTeamID : BUEffectTemplate
{
	public BUEffectSwitchTeamID()
	{
		EffectType = EBuffAndSkillEffectType.SwitchTeamId;
	}

	[ParamInfoI(0, "阵营ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
				bGUCharacterCS.SetTeamIDInCS(buffDescRuntime.GetIntEffectParam(EffectIdx, 0));
				BGUFuncLibAICS.SearchTargetSP(bGUCharacterCS);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetTeamID.Invoke();
			BGUFuncLibAICS.SearchTargetSP(Target);
		}
	}
}
