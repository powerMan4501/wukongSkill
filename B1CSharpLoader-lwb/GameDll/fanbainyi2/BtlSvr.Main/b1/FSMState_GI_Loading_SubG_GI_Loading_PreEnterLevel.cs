using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel : FSMState_GI_Loading_SubG_GI_Loading_Base
{
	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Loading_SubG_GI_Loading_PreEnterLevel gI_Loading_SubG_GI_Loading_PreEnterLevel = new GI_Loading_SubG_GI_Loading_PreEnterLevel();
		gI_Loading_SubG_GI_Loading_PreEnterLevel.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Loading_SubG_GI_Loading_PreEnterLevel.SubGraphAsset;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		return Context;
	}

	public override void OnSubGraphEnter()
	{
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Loading_SubG_GI_Loading_PreEnterLevel_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}
}
