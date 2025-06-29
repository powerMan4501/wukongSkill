using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_PartyRoomServer : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[FSMInputParam]
	private int NextLevelID { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_PartyRoomServer gI_Global_SubG_GI_Loading_PartyRoomServer = new GI_Global_SubG_GI_Loading_PartyRoomServer();
		gI_Global_SubG_GI_Loading_PartyRoomServer.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_PartyRoomServer.SubGraphAsset;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_PartyRoomServer fSMInputData_GI_Global_SubG_GI_Loading_PartyRoomServer)
		{
			NextLevelID = fSMInputData_GI_Global_SubG_GI_Loading_PartyRoomServer.NextLevelID;
		}
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		Context.OnlineLoadingContext.TargetLevelId = NextLevelID;
		return Context.OnlineLoadingContext;
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PartyRoomServer_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
