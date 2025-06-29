using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel : FSMState_GI_Loading_SubG_GI_Loading_Base
{
	[EditableFSMParam]
	private bool NeedWaitCameraBlend { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_SubG_GI_Loading_BattleLevelTravel gI_Loading_SubG_GI_Loading_BattleLevelTravel = new GI_Loading_SubG_GI_Loading_BattleLevelTravel();
		gI_Loading_SubG_GI_Loading_BattleLevelTravel.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Loading_SubG_GI_Loading_BattleLevelTravel.SubGraphAsset;
		NeedWaitCameraBlend = gI_Loading_SubG_GI_Loading_BattleLevelTravel.NeedWaitCameraBlend;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		Context.BattleLevelTravelNeedWaitCameraBlend = NeedWaitCameraBlend;
		return Context;
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_BattleLevelTravel_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
