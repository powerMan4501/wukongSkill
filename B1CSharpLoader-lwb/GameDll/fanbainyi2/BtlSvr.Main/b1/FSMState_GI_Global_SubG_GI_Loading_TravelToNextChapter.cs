using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[FSMInputParam]
	private int NextLevelID { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_TravelToNextChapter gI_Global_SubG_GI_Loading_TravelToNextChapter = new GI_Global_SubG_GI_Loading_TravelToNextChapter();
		gI_Global_SubG_GI_Loading_TravelToNextChapter.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_TravelToNextChapter.SubGraphAsset;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_TravelToNextChapter fSMInputData_GI_Global_SubG_GI_Loading_TravelToNextChapter)
		{
			NextLevelID = fSMInputData_GI_Global_SubG_GI_Loading_TravelToNextChapter.NextLevelID;
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
			TargetLevelId = NextLevelID
		};
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_TravelToNextChapter_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
