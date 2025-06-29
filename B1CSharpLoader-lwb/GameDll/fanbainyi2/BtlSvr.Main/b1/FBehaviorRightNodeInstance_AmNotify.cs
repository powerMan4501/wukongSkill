using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_AmNotify : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_AMNotify CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.AMNotify;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_AMNotify();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_AMNotifyBehaviorGraph = (Del_Void_ActorString)Delegate.Combine(bGWEventCollection.Evt_BGW_AMNotifyBehaviorGraph, new Del_Void_ActorString(OnAMNotifyBehaviorGraph));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_AMNotifyBehaviorGraph = (Del_Void_ActorString)Delegate.Remove(bGWEventCollection.Evt_BGW_AMNotifyBehaviorGraph, new Del_Void_ActorString(OnAMNotifyBehaviorGraph));
	}

	private void OnAMNotifyBehaviorGraph(AActor Unit, string NotifyTag)
	{
		if (BGUFunctionLibraryCS.GetUnitFlagId(Unit) == base.ListenerFlagID && NotifyTag == CustomData.NotifyTag)
		{
			NotifyTriggerInput();
		}
	}
}
