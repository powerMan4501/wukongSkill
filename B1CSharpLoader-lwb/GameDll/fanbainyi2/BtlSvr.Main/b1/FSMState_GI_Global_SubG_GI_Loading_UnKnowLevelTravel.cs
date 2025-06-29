using System;
using Google.Protobuf;
using GurCalliopeFsm;
using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel : FSMState_GI_Global_SubG_GI_Loading_Base
{
	public static FTransform OverrideUnKnowLevelTravelPlayerStart;

	public static bool UnKnowLevelTravelUseDefaultPlayerStart = true;

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_UnKnowLevelTravel gI_Global_SubG_GI_Loading_UnKnowLevelTravel = new GI_Global_SubG_GI_Loading_UnKnowLevelTravel();
		gI_Global_SubG_GI_Loading_UnKnowLevelTravel.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_UnKnowLevelTravel.SubGraphAsset;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.OwningInstance.OwnerUObj);
		bGW_EventCollection.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Combine(bGW_EventCollection.Evt_ChoosePlayerStart, new BGW_EventCollection.Del_ChoosePlayerStart(ChoosePlayerStart));
		return new FSMContext_GI_Loading(Context.OwnerUObj as BGWGameInstanceCS);
	}

	protected FChoosePlayerStartInfo ChoosePlayerStart()
	{
		FChoosePlayerStartInfo result = default(FChoosePlayerStartInfo);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.OwningInstance.OwnerUObj);
		bGW_EventCollection.Evt_ChoosePlayerStart = (BGW_EventCollection.Del_ChoosePlayerStart)Delegate.Remove(bGW_EventCollection.Evt_ChoosePlayerStart, new BGW_EventCollection.Del_ChoosePlayerStart(ChoosePlayerStart));
		result.PlayerTransform = OverrideUnKnowLevelTravelPlayerStart;
		result.UseDefaultPos = true;
		return result;
	}

	public override void OnSubGraphFinish()
	{
		if (SubGraphContext.GameInst.TravelURLHasOption("listen"))
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return.FinishInLS);
		}
		else if (SubGraphContext.GameInst.TravelURLHasHost())
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return.FinishInClient);
		}
		else if (SubGraphContext.GameInst.GetTravelURLForCS().Contains("Startup"))
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return.FinishInStartUp);
		}
		else if (SubGraphContext.GameInst.GetTravelURLForCS().Contains("WXLogin_P"))
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return.FinishInWXLogin);
		}
		else
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return.FinishInStandAlone);
		}
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
