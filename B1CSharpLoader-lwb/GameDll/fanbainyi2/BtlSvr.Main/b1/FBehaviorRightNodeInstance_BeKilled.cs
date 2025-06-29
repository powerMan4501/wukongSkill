using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_BeKilled : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_BeKilled CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.BeKilled;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_BeKilled();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.VictimUnitType, CustomData.VictimSmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeKilled = (Del_Void_ActorActor)Delegate.Combine(bGWEventCollection.Evt_BGW_BeKilled, new Del_Void_ActorActor(BeKilled));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeKilled = (Del_Void_ActorActor)Delegate.Remove(bGWEventCollection.Evt_BGW_BeKilled, new Del_Void_ActorActor(BeKilled));
	}

	private void BeKilled(AActor Victim, AActor Attacker)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(Victim) == base.ListenerFlagID))
		{
			return;
		}
		AActor detectUnitActor = BGUFunctionLibraryCS.GetDetectUnitActor(base.Owner, (EDetectedUnitType)CustomData.AttackerUnitType, CustomData.AttackerSmartUnitGuid);
		if (!(detectUnitActor == null) && !(Attacker == null))
		{
			BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				bGUCharacterCS = ((IBUC_MasterData)BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker)).GetMasterActor() as BGUCharacterCS;
			}
			if (detectUnitActor == bGUCharacterCS)
			{
				NotifyTriggerInput();
			}
		}
	}
}
