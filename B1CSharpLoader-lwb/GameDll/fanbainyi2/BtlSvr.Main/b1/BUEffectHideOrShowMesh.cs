using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "隐藏或显示Mesh" })]
public class BUEffectHideOrShowMesh : BUEffectTemplate
{
	public BUEffectHideOrShowMesh()
	{
		EffectType = EBuffAndSkillEffectType.HideOrShowMesh;
	}

	[ParamInfoI(0, "为1时显示，否则隐藏")]
	[TemplateFunNote("添加Buff时隐藏或显示Mesh")]
	[ParamInfoS(0, "MeshComponent的名字")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			bool p = buffDescRuntime.GetIntEffectParam(EffectIdx, 0) == 1;
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BUS_EventCollectionCS.Get(Target).Evt_HideOrShowMesh.Invoke(p, stringEffectParam);
		}
	}

	[TemplateFunNote("移除Buff时重置隐藏或显示Mesh")]
	[ParamInfoS(0, "MeshComponent的名字")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_ResetHideOrShowMesh.Invoke(stringEffectParam);
			}
		}
	}
}
