using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PlayerInteractCricketComp : UActorCompBaseCS
{
	private b1.BUC_PlayerInteractCricketData PlayerInteractCricketData;

	private IBUC_GuidData GuidData;

	private IBUC_UnitStateData UnitStateData;

	public override void OnAttach()
	{
		PlayerInteractCricketData = RequireWritableData<b1.BUC_PlayerInteractCricketData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		base.BUSEventCollection.Evt_TriggerInteractCricket += new Del_Void_Actor(OnTriggerInteractCricket);
		base.BUSEventCollection.Evt_BreakInteractCricket += new Del_Void(OnBreakInteractCricket);
		base.BUSEventCollection.Evt_FinishInteractCricket += new Del_Void(OnFinishInteractCricket);
		base.BUSEventCollection.Evt_OnCricketStartWeakIdle += new Del_Void_AnimMontage(OnCricketStartWeakIdle);
		base.BUSEventCollection.Evt_OnCricketPrepareInteractFinish += new Del_Void_AnimMontage(OnCricketPrepareInteractFinish);
		base.BUSEventCollection.Evt_OnInteractCricketSuccess += new Del_Void(OnInteractCricketSuccess);
		base.BUSEventCollection.Evt_OnStaminaDepleted += new Del_Void(OnStaminaDepleted);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
	}

	public override void PreBeginPlay()
	{
		PlayerInteractCricketData.CricketGuid = "";
		PlayerInteractCricketData.bWaitFinishInteract = false;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PlayerInteractCricketData.bWaitFinishInteract && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			PlayerInteractCricketData.bWaitFinishInteract = false;
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PlayerInteractCricketData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(actorByGuid)?.Evt_FinishInteractCricketDisplay.Invoke();
				Reset();
			}
		}
	}

	private void OnTriggerInteractCricket(AActor Cricket)
	{
		if (!Cricket.IsNullOrDestroyed())
		{
			PlayerInteractCricketData.CricketGuid = BGU_DataUtil.GetActorGuid(Cricket);
			BUS_EventCollectionCS.Get(Cricket)?.Evt_CricketTriggerInteract.Invoke(GuidData.GetFinalGuid());
			BUS_EventCollectionCS.Get(Owner)?.Evt_HoldingQTEInteract?.Invoke(P1: true);
		}
	}

	private void OnBreakInteractCricket()
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_HoldingQTEInteract?.Invoke(P1: false);
		BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: false, 0);
		if (!UnitStateData.HasState(EBGUUnitState.Dead))
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PlayerInteractCricketData.CricketGuid);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(actorByGuid)?.Evt_CricketBreakInteract.Invoke(GuidData.GetFinalGuid());
				Reset();
			}
		}
	}

	private void OnFinishInteractCricket()
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_HoldingQTEInteract?.Invoke(P1: false);
		BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: false, 0);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PlayerInteractCricketData.CricketGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_CricketFinishInteract.Invoke(GuidData.GetFinalGuid());
		}
	}

	private void Reset()
	{
		PlayerInteractCricketData.CricketGuid = "";
		PlayerInteractCricketData.bWaitFinishInteract = false;
	}

	private void OnCricketStartWeakIdle(UAnimMontage AMFinishInteract)
	{
		BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, AMFinishInteract, FName.None);
		PlayerInteractCricketData.bWaitFinishInteract = true;
	}

	private void OnCricketPrepareInteractFinish(UAnimMontage AMPrepareInteractBreak)
	{
		if (AMPrepareInteractBreak != null)
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, AMPrepareInteractBreak, FName.None);
		}
		Reset();
	}

	private void OnInteractCricketSuccess()
	{
		Reset();
	}

	private void OnStaminaDepleted()
	{
		if (!PlayerInteractCricketData.CricketGuid.Equals(""))
		{
			BPS_EventCollectionCS.Get(Owner.GetInstigatorController() as APlayerController)?.Evt_BPS_BreakInteract.Invoke();
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		BUS_EventCollectionCS.Get(Owner)?.Evt_HoldingQTEInteract?.Invoke(P1: false);
		BGW_EventCollection.Get(Owner)?.Evt_ActiveQTEInteractUI?.Invoke(P1: false, 0);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, PlayerInteractCricketData.CricketGuid);
		if (!actorByGuid.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(actorByGuid)?.Evt_OnInteractActorDead.Invoke();
			Reset();
		}
	}
}
