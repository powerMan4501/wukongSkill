using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "对物理模拟单位施加冲量", "对目标施加，沿着与目标连线方向向量的冲量", "目前只能更改冲量的大小,方向是固定的" })]
public class BUEffectAddPhysicsImpulse : BUEffectTemplate
{
	public BUEffectAddPhysicsImpulse()
	{
		EffectType = EBuffAndSkillEffectType.AddPhysicsImpulse;
	}

	[ParamInfoF(0, "单位冲量Scale")]
	[TemplateFunNote("对物理模拟单位施加冲量")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc.EffectParamsFloat.Count >= 1)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				float skillEffectDescFloatEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescFloatEffectParam(skillEffectDesc, 0);
				FVector vec = (BGUFuncLibActorTransformCS.BGUGetActorLocation(Target) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster)).GetSafeNormal() * skillEffectDescFloatEffectParam;
				bUS_GSEventCollection.Evt_AddPhysicsImpulse.Invoke(vec, EffectInstReq.HitLocation);
			}
		}
	}
}
