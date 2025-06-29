using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_StartNewGame : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[FSMInputParam]
	private int NewGameLevelId { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_StartNewGame gI_Global_SubG_GI_Loading_StartNewGame = new GI_Global_SubG_GI_Loading_StartNewGame();
		gI_Global_SubG_GI_Loading_StartNewGame.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_StartNewGame.SubGraphAsset;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_StartNewGame fSMInputData_GI_Global_SubG_GI_Loading_StartNewGame)
		{
			NewGameLevelId = fSMInputData_GI_Global_SubG_GI_Loading_StartNewGame.NewGameLevelId;
		}
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		return new FSMContext_GI_Loading(Context.OwnerUObj as BGWGameInstanceCS)
		{
			TargetLevelId = NewGameLevelId
		};
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_StartNewGame_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
