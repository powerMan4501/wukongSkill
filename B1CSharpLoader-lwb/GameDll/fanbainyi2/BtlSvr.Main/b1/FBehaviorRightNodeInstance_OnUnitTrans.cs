using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_OnUnitTrans : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_OnUnitTrans CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.OnUnitTrans;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_OnUnitTrans();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_UnitTrans = (Del_UnitTrans_NotifyWorld)Delegate.Combine(bGWEventCollection.Evt_BGW_UnitTrans, new Del_UnitTrans_NotifyWorld(OnUnitTrans));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_UnitTrans = (Del_UnitTrans_NotifyWorld)Delegate.Remove(bGWEventCollection.Evt_BGW_UnitTrans, new Del_UnitTrans_NotifyWorld(OnUnitTrans));
	}

	private void OnUnitTrans(AActor Unit, EPlayerTransEndType UnitTransType)
	{
		if (BGUFunctionLibraryCS.GetUnitFlagId(Unit) == base.ListenerFlagID && (uint)UnitTransType == (byte)CustomData.TransType)
		{
			NotifyTriggerInput();
		}
	}
}
