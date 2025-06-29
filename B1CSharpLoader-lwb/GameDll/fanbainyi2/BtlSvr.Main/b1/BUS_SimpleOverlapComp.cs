using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_SimpleOverlapComp : UActorCompBaseCS
{
	private IBUC_ActorTransformInfoData ActorTransformInfoData;

	private BPS_GSEventCollection BPSEventCollection;

	public override void OnAttach()
	{
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		base.BUSEventCollection.Evt_OnBulletSpawnFinished += new Del_OnBulletSpawnFinished(OnBulletSpawnFinished);
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BPSEventCollection = BPS_GSEventCollection.Get(bGUCharacterCS.GetController()?.PlayerState);
			if (BPSEventCollection != null)
			{
				BPSEventCollection.Evt_BPS_SwitchPlayerTransState += new Del_SwitchPlayerTransState(RemoveGridInfo);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_DeregisterBGUEntityInfo.Invoke(GetOwnerEntity());
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_BPS_SwitchPlayerTransState -= new Del_SwitchPlayerTransState(RemoveGridInfo);
		}
	}

	public override void LateBeginPlay()
	{
		if (Owner as BGUMagicFieldBaseCS == null)
		{
			base.BGSEventCollection.Evt_BGS_RegisterBGUEntityInfo.Invoke(Owner, ActorTransformInfoData);
		}
	}

	public void OnBulletSpawnFinished(FProjectileSpawnEventInfo ProjectileSpawnEventInfo)
	{
		if (Owner as BGUMagicFieldBaseCS != null)
		{
			base.BGSEventCollection.Evt_BGS_RegisterBGUEntityInfo.Invoke(Owner, ActorTransformInfoData);
		}
	}

	private void RemoveGridInfo(AActor OldActor, int NewActorResId)
	{
		base.BGSEventCollection.Evt_BGS_RemoveGridInfo.Invoke(OldActor);
	}
}
