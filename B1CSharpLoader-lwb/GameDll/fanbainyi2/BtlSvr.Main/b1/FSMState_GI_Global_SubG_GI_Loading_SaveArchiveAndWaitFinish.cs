using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish : FSMState_GI_Global_SubG_GI_Loading_Base
{
	[EditableFSMParam(ParamType = FSMParamType.Enum)]
	private EArchiveSaveSource ArchiveSaveSource { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish gI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish = new GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish();
		gI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish.SubGraphAsset;
		ArchiveSaveSource = (EArchiveSaveSource)gI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish.ArchiveSaveSource;
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

	public override void OnSubGraphEnter()
	{
	}

	public override object GenSubGraphFirstNodeInputParam()
	{
		return new FSMInputData_GI_Loading_SaveArchiveAndWaitFinish
		{
			ArchiveSaveSource = ArchiveSaveSource
		};
	}

	public override void OnSubGraphFinish()
	{
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish_Return.Finish);
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}
}
