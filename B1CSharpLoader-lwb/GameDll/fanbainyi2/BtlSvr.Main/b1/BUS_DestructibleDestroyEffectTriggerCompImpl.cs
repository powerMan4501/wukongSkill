using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_DestructibleDestroyEffectTriggerCompImpl : UActorCompBaseCS
{
	private b1.IBUC_DestructibleDestroyEffectTriggerData DestroyEffectTriggerData;

	public override void OnAttach()
	{
		DestroyEffectTriggerData = RequireReadOnlyData<b1.IBUC_DestructibleDestroyEffectTriggerData, BUC_DestructibleDestroyEffectTriggerData>();
		if (DestroyEffectTriggerData.DestructibleTag == FName.None)
		{
			return;
		}
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UChildActorComponent>(), DestroyEffectTriggerData.DestructibleTag))
		{
			UChildActorComponent uChildActorComponent = item as UChildActorComponent;
			if (uChildActorComponent.ChildActor != null && uChildActorComponent.ChildActor is BGUFXActorBase)
			{
				BUS_EventCollectionCS.Get(uChildActorComponent.ChildActor).Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
			}
		}
	}

	public override void OnBeginPlay()
	{
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		if (Owner == null)
		{
			return;
		}
		FEffectInstReq fEffectInstReq = new FEffectInstReq(Owner);
		fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
		fEffectInstReq.HitActionDir = EHitActionDir.Default;
		FEffectInstReq effectInstReq = fEffectInstReq;
		foreach (int effectID in DestroyEffectTriggerData.EffectIDs)
		{
			base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(effectID, effectInstReq);
		}
		foreach (int buffID in DestroyEffectTriggerData.BuffIDs)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(buffID, Owner, Owner, 0f, EBuffSourceType.DestructibleBullet);
		}
	}
}
