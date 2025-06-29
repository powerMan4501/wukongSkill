using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;

namespace b1;

public class FBehaviorRightNodeInstance_OnAllSummonBeKilled : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_OnAllSummonBeKilled CustomData { get; set; }

	private List<int> SucceededSummonIDs { get; } = new List<int>();

	public override string NodeName => B1CalliopeDef.BehaviorNode.OnAllSummonBeKilled;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_OnAllSummonBeKilled();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_OnSummonBeKilled = (Del_Void_SummonInstance)Delegate.Combine(bGWEventCollection.Evt_BGW_OnSummonBeKilled, new Del_Void_SummonInstance(OnSummonBeKilled));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_OnSummonBeKilled = (Del_Void_SummonInstance)Delegate.Remove(bGWEventCollection.Evt_BGW_OnSummonBeKilled, new Del_Void_SummonInstance(OnSummonBeKilled));
	}

	private void OnSummonBeKilled(FSummonInstance InSummonInstance)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(InSummonInstance.SummonReq.Summoner) == base.ListenerFlagID))
		{
			return;
		}
		List<int> list = CustomData.SummonIds.ToList();
		if (list.Contains(InSummonInstance.SummonReq.SummonID) && InSummonInstance.BeKilledCount == InSummonInstance.ServantReqList.Count)
		{
			SucceededSummonIDs.Add(InSummonInstance.SummonReq.SummonID);
			if (SucceededSummonIDs.Count >= list.Count)
			{
				NotifyTriggerInput();
			}
		}
	}
}
