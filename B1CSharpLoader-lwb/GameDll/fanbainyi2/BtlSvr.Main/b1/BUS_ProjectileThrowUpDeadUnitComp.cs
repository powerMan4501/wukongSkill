using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_ProjectileThrowUpDeadUnitComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnProjectileCustomSweepHitNormalUnit += new Del_OnProjectileCustomSweepHitNormalUnit(OnHitUnit);
	}

	private void OnHitUnit(FUStGSHitResult GSHitResult)
	{
		AActor actor = GSHitResult.Actor;
		if (!(actor == null) && b1.EffectTemplateUtil.ReturnIfUnitDead(actor))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ThrowUpDeadUnit.Invoke();
			}
		}
	}
}
