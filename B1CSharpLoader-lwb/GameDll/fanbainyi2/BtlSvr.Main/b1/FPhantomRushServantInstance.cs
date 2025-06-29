namespace b1;

public class FPhantomRushServantInstance : FCloneServantInstance
{
	public FPhantomRushServantInstance(FServantReq InReq)
		: base(InReq)
	{
		base.bCanCastCopySkill = false;
	}

	protected override void AfterUnitBeginPlay()
	{
		base.AfterUnitBeginPlay();
		BGUCharacterCS bGUCharacterCS = ServantReq.MasterActor as BGUCharacterCS;
		base.ServantEventCollection.Evt_PhantomRushSummonBehavior.Invoke(ServantReq.CBI);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(base.Owner);
		BGUCharacterCS bGUCharacterCS2 = base.ServantUnitPtr.Get();
		BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetPhantomRushImperceptible.Invoke(P1: true);
		bGS_GSEventCollection.Evt_BGS_NotifySwitchTarget.Invoke(bGUCharacterCS, bGUCharacterCS2, TriggerTaunt: true, ETargetSourceType.SwitchTarget_PhantomRush);
		bGS_GSEventCollection.Evt_BGS_NotifyCopyHatredInfo.Invoke(bGUCharacterCS, bGUCharacterCS2, bRemoveOriginHatredInfo: false);
	}
}
