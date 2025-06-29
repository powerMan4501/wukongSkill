using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Global_BenchMark : FSMState_GI_Global_SubG_GI_Global_Base
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Global_BenchMark gI_Global_SubG_GI_Global_BenchMark = new GI_Global_SubG_GI_Global_BenchMark();
		gI_Global_SubG_GI_Global_BenchMark.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Global_BenchMark.SubGraphAsset;
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Global GenSubGraphContext()
	{
		return Context;
	}

	public override void OnSubGraphEnter()
	{
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Global_BenchMark_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}
}
