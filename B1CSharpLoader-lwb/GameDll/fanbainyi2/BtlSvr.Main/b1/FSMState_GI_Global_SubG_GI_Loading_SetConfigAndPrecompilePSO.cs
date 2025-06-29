using CommB1;
using Google.Protobuf;
using GurCalliopeFsm;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO : FSMState_GI_Global_SubG_GI_Loading_Base
{
	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO gI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO = new GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO();
		gI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO.SubGraphAsset;
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

	public override void OnSubGraphFinish()
	{
		BGW_GameArchiveMgr bGW_GameArchiveMgr = BGW_GameArchiveMgr.Get(Context.OwnerUObj);
		ArchiveSummaryData latestArchive = bGW_GameArchiveMgr.GetLatestArchive();
		bool flag = BGW_PlayGoMgr.Get(Context.OwnerUObj).IsDownloadIncomplete();
		bool flag2 = latestArchive != null && bGW_GameArchiveMgr.IsArchiveOutOfPlayGoPackage(latestArchive);
		bool flag3 = bGW_GameArchiveMgr.HasArchiveFile() || DebugConfig.DebugStartWithOutArchive;
		if (false)
		{
			if (flag3)
			{
				if (flag && !flag2)
				{
					base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return.GameIntent);
				}
				else
				{
					base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return.MainMenu);
				}
			}
			else
			{
				base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return.PrologueChapter);
			}
		}
		else if (flag3)
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return.MainMenu);
		}
		else
		{
			base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return.PrologueChapter);
		}
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}
}
