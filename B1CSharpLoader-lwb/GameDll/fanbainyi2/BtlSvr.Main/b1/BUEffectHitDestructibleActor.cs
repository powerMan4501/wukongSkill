using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "打击破碎物" })]
public class BUEffectHitDestructibleActor : BUEffectTemplate
{
	public BUEffectHitDestructibleActor()
	{
		EffectType = EBuffAndSkillEffectType.HitDestructibleActor;
	}

	[TemplateFuncTips("Target为破碎物或带有破碎物ChildActor的单位")]
	[ParamInfoI(0, "打击方向类型（0 破碎物朝向，1 Buff施加者速度方向，2 Buff施加者与破碎物连线方向）")]
	[AffectTarget]
	[TemplateFunNote("通过Buff打击破碎物")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (Target == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		AActor caster = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		if (Target == null)
		{
			return;
		}
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(Target) != null)
		{
			DestroyDestructible(caster, Target, intEffectParam);
			return;
		}
		foreach (UActorComponent item in Target.GetComponentsByClass(UClass.GetClass<UChildActorComponent>()))
		{
			AActor aActor = (item as UChildActorComponent)?.ChildActor;
			if (!(aActor == null) && BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(aActor) != null)
			{
				DestroyDestructible(caster, aActor, intEffectParam);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}

	[TemplateFunNote("通过技能击碎自身身上的破碎物")]
	[ParamInfoI(0, "打击方向类型（0 破碎物朝向，1 Buff施加者速度方向，2 Buff施加者与破碎物连线方向）")]
	[AffectCaster]
	[TemplateFuncTips("Caster为破碎物或带有破碎物ChildActor的单位")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 1)
		{
			return;
		}
		int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(Target) != null)
		{
			DestroyDestructible(Caster, Target, skillEffectDescIntEffectParam);
			return;
		}
		foreach (UActorComponent item in Target.GetComponentsByClass(UClass.GetClass<UChildActorComponent>()))
		{
			AActor aActor = (item as UChildActorComponent)?.ChildActor;
			if (!(aActor == null) && BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(aActor) != null)
			{
				DestroyDestructible(Caster, aActor, skillEffectDescIntEffectParam);
			}
		}
	}

	private void DestroyDestructible(AActor Caster, AActor Destructible, int HitDirType)
	{
		FVector impulseDir = FVector.ZeroVector;
		if (HitDirType == 0)
		{
			impulseDir = Destructible.GetActorForwardVector();
		}
		if (HitDirType == 1)
		{
			impulseDir = Caster.GetVelocity().GetSafeNormal();
		}
		if (HitDirType == 2)
		{
			impulseDir = (BGUFuncLibActorTransformCS.BGUGetActorLocation(Destructible) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster)).GetSafeNormal();
		}
		BGUFunctionLibraryCS.BGUDestroyDestructible(Destructible, BGUFuncLibActorTransformCS.BGUGetActorLocation(Destructible), impulseDir);
	}
}
