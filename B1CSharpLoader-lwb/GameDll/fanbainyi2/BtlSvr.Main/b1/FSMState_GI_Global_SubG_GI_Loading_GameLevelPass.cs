using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_GameLevelPass : FSMState_GI_Global_SubG_GI_Loading_Base
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_GameLevelPass gI_Global_SubG_GI_Loading_GameLevelPass = new GI_Global_SubG_GI_Loading_GameLevelPass();
		gI_Global_SubG_GI_Loading_GameLevelPass.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_GameLevelPass.SubGraphAsset;
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
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_GameLevelPass_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
