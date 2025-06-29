using ArchiveB1;
using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_PreviewSequence : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[FSMInputParam]
	private int SeqID { get; set; }

	[FSMInputParam]
	private PastMemoriesOne MemoriesOne { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_PreviewSequence gI_Global_SubG_GI_Loading_PreviewSequence = new GI_Global_SubG_GI_Loading_PreviewSequence();
		gI_Global_SubG_GI_Loading_PreviewSequence.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_PreviewSequence.SubGraphAsset;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_PreviewSequence fSMInputData_GI_Global_SubG_GI_Loading_PreviewSequence)
		{
			SeqID = fSMInputData_GI_Global_SubG_GI_Loading_PreviewSequence.SeqID;
			MemoriesOne = fSMInputData_GI_Global_SubG_GI_Loading_PreviewSequence.MemoriesOne;
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
			SeqID = SeqID,
			Memories = MemoriesOne
		};
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PreviewSequence_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	public override void OnSubGraphEnter()
	{
	}
}
