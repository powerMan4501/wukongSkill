using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_BeHurt : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_BeHurt CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.BeHurt;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_BeHurt();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.VictimUnitType, CustomData.VictimSmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeHurt = (Del_Void_ActorActorFloat)Delegate.Combine(bGWEventCollection.Evt_BGW_BeHurt, new Del_Void_ActorActorFloat(BeHurt));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeHurt = (Del_Void_ActorActorFloat)Delegate.Remove(bGWEventCollection.Evt_BGW_BeHurt, new Del_Void_ActorActorFloat(BeHurt));
	}

	private void BeHurt(AActor Victim, AActor Attacker, float DmgValue)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(Victim) == base.ListenerFlagID))
		{
			return;
		}
		AActor detectUnitActor = BGUFunctionLibraryCS.GetDetectUnitActor(base.Owner, (EDetectedUnitType)CustomData.AttackerUnitType, CustomData.AttackerSmartUnitGuid);
		if (detectUnitActor != null)
		{
			if (Attacker == null)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				bGUCharacterCS = ((IBUC_MasterData)BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker)).GetMasterActor() as BGUCharacterCS;
			}
			if (detectUnitActor != bGUCharacterCS)
			{
				return;
			}
		}
		if (FBehaviorRightNodeInstance_ListenerTrigger.ValueOperation(DmgValue, CustomData.DmgValue, (EValueCompareOperationType)CustomData.CompareOperation))
		{
			NotifyTriggerInput();
		}
	}
}
