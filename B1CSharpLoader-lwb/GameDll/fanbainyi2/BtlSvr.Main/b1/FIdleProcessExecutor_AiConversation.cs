using System.Collections.Generic;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_AiConversation : FIdleProcessExecutorBase
{
	private class AiConversationTask
	{
		private uint AiConversationChainRootID;

		public AiConversationTask(uint _AiConversationChainRootID)
		{
			AiConversationChainRootID = _AiConversationChainRootID;
		}

		public bool CheckAiConversationChainFinished(UObject WorldContext)
		{
			return ((IBGC_AiConversationMgrData)BGU_DataUtil.GetGameStateReadonlyData<BGC_AiConversationMgrData>(WorldContext))?.bIsAiConversationChainEnd_CPG(AiConversationChainRootID) ?? false;
		}
	}

	public override EIdleProcessActionType ActionType => EIdleProcessActionType.AiConversation;

	private string UnitGuid { get; set; }

	private List<int> AiConversationContentIDList { get; set; }

	private List<AiConversationTask> AiConversationTasks { get; } = new List<AiConversationTask>();

	private PsmNodeInstance PsmNodeInstance { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		if (InPsmNodeInstance != null)
		{
			AiConversationContentIDList = InPsmNodeInstance.ParentInstance.ConvertParamID2ArrayIntParam(InIdleProcessAction.AiConversationContentIdList);
			UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2UnitGuid(InIdleProcessAction.UnitGuid);
			PsmNodeInstance = InPsmNodeInstance;
		}
	}

	public override void Run(UObject InWorldContext)
	{
		AiConversationTasks.Clear();
		if (AiConversationContentIDList == null)
		{
			return;
		}
		string text = "";
		if (PsmNodeInstance != null && PsmNodeInstance.ParentInstance != null && PsmNodeInstance.ParentInstance.TemplateAsset != null)
		{
			text = PsmNodeInstance.ParentInstance.TemplateAsset.AssetPath;
		}
		string sourceLog = "CPG:" + text;
		BGS_EventCollectionCS.Get(InWorldContext)?.Evt_PocessEventByContentIDList_ByGuid.Invoke(sourceLog, UnitGuid, AiConversationContentIDList);
		IBGC_AiConversationMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_AiConversationMgrData>(InWorldContext);
		if (gameStateReadonlyData != null)
		{
			uint last_ChainRootID = gameStateReadonlyData.GetLast_ChainRootID();
			if (gameStateReadonlyData.GetLast_bPocessSuccess())
			{
				AiConversationTasks.Add(new AiConversationTask(last_ChainRootID));
			}
		}
	}

	public override void OnTick(UObject InWorldContext, float InDeltaTime)
	{
		for (int num = AiConversationTasks.Count - 1; num >= 0; num--)
		{
			if (AiConversationTasks[num].CheckAiConversationChainFinished(InWorldContext))
			{
				AiConversationTasks.RemoveAt(num);
			}
		}
	}

	public override bool IsFinished()
	{
		return AiConversationTasks.Count == 0;
	}

	public override bool IsAiConversationChainEnd()
	{
		return AiConversationTasks.Count == 0;
	}

	public override void ResetRun(UObject InWorldContext)
	{
	}

	public override void RecoverRun(UObject InWorldContext)
	{
	}
}
