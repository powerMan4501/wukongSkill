using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_HandleDisConnect : FSMState_GI_Global_SubG_GI_Loading_Base
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_HandleDisConnect gI_Global_SubG_GI_Loading_HandleDisConnect = new GI_Global_SubG_GI_Loading_HandleDisConnect();
		gI_Global_SubG_GI_Loading_HandleDisConnect.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_HandleDisConnect.SubGraphAsset;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		return new FSMContext_GI_Loading(Context.OwnerUObj as BGWGameInstanceCS);
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_HandleDisConnect_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
