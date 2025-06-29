using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;

namespace b1;

internal class BGS_PigsyStorySystem : GameStateSystemBase
{
	private BGC_PigsyStoryData PigsyStoryData { get; set; }

	private IBGC_AiConversationMgrData AiConversationMgrData { get; set; }

	public override void OnAttach()
	{
		PigsyStoryData = RequireWritableData<BGC_PigsyStoryData>();
		AiConversationMgrData = RequireReadOnlyData<IBGC_AiConversationMgrData, BGC_AiConversationMgrData>();
		base.BGSEventCollection.Evt_OnConversationChainEnd += new Del_Void_Uint(OnCurStoryFinished);
		base.BGSEventCollection.Evt_OnAiConversationEnded += new Del_OnAiConversationEnded(OnAiConversationEnded);
		base.BGSEventCollection.Evt_OnAiConversationCastSuccess += new Del_OnAiConversationCastSuccess(OnAiConversationCastSuccess);
		base.BGSEventCollection.Evt_PlayPigsyStory += new Del_Void_String(PlayStory);
		base.BGSEventCollection.Evt_IntoSpecificStoryArea += new Del_IntoSpecificStoryArea(IntoSpecificStoryArea);
		base.BGSEventCollection.Evt_ExitSpecificStoryArea += new Del_Void_String(ExitSpecificStoryArea);
	}

	public override void OnBeginPlay()
	{
		InitLevelStory();
	}

	private void InitLevelStory()
	{
		PigsyStoryData.CurrentLevelID = BGUFuncLibMap.GetCurLevelId(Owner);
		foreach (KeyValuePair<int, FUStPigsyStoryLibraryDesc> item in BGW_GameDB.GetAllPigsyStoryLibraryDesc())
		{
			if (item.Value.LevelID == PigsyStoryData.CurrentLevelID)
			{
				int specificAreaID = item.Value.SpecificAreaID;
				PigsyStoryData.StoryLib.Add(specificAreaID, item.Value.StartAiConversationIDs.ToList());
			}
		}
	}

	private void PlayStory(string TalkerGUID)
	{
		if (PigsyStoryData.CurAiConversationEventReqID == 0)
		{
			PigsyStoryData.bSuccess_LastReqPlayStory = false;
			if (!PigsyStoryData.HasStoryCanTalk_CurArea())
			{
				OnCurLevelStoryAllFinished();
			}
			else if (TalkerGUID != null)
			{
				bool flag = false;
				flag = ((PigsyStoryData.LastAiConversationID > 0) ? PlayResumeDialogue(TalkerGUID) : PlayNewStory(TalkerGUID));
				PigsyStoryData.bSuccess_LastReqPlayStory = flag;
			}
		}
	}

	private bool PlayNewStory(string TalkerGUID)
	{
		bool flag = false;
		int key = PigsyStoryData.CurrentAreaID;
		if (!PigsyStoryData.StoryLib.ContainsKey(key))
		{
			key = 0;
		}
		if (!PigsyStoryData.StoryLib.ContainsKey(key))
		{
			return flag;
		}
		foreach (int item in PigsyStoryData.StoryLib[key])
		{
			if (!PigsyStoryData.IsFinished(item))
			{
				List<int> list = new List<int>();
				list.Add(item);
				flag = HandleAiConversation("八戒故事会::播放新故事", TalkerGUID, list, EStoryConversationType.Story);
				if (flag)
				{
					PigsyStoryData.AiConversationStartID = item;
					OnPlayStorySuccess(item);
				}
				break;
			}
		}
		return flag;
	}

	private void OnPlayStorySuccess(int AiConversationID)
	{
		PigsyStoryData.LastAiConversationID = AiConversationID;
		PigsyStoryData.CurAiConversationEventReqID = AiConversationMgrData.GetLast_AiConversationReqID();
		uint last_ChainRootID = AiConversationMgrData.GetLast_ChainRootID();
		PigsyStoryData.CurAiConversationChainID = last_ChainRootID;
	}

	private bool HandleAiConversation(string SourceLog, string UnitGUID, List<int> AiConversationIDs, EStoryConversationType StoryType)
	{
		PigsyStoryData.StoryConversationType = EStoryConversationType.None;
		base.BGSEventCollection?.Evt_PocessEventByContentIDList_ByGuid.Invoke(SourceLog, UnitGUID, AiConversationIDs);
		bool last_bPocessSuccess = AiConversationMgrData.GetLast_bPocessSuccess();
		if (last_bPocessSuccess)
		{
			PigsyStoryData.CurAiConversationEventReqID = AiConversationMgrData.GetLast_AiConversationReqID();
			PigsyStoryData.StoryConversationType = StoryType;
		}
		return last_bPocessSuccess;
	}

	private void InterruptCurStory(string SpeakerGUID, EPigsyStoryIAndRType IAndRType)
	{
		PigsyStoryData.CurAiConversationChainID = 0u;
		PigsyStoryData.StoryConversationType = EStoryConversationType.None;
		if (IAndRType != EPigsyStoryIAndRType.None)
		{
			List<int> pigsyStoryIAndRLibrary = BGW_GameDB.GetPigsyStoryIAndRLibrary(IAndRType);
			if (pigsyStoryIAndRLibrary != null && pigsyStoryIAndRLibrary.Count > 0)
			{
				HandleAiConversation("八戒故事会::触发打断的话术[" + IAndRType.ToString() + "]", SpeakerGUID, pigsyStoryIAndRLibrary, EStoryConversationType.Interrupt);
			}
		}
	}

	private bool PlayResumeDialogue(string SpeakerGUID)
	{
		bool flag = false;
		List<int> pigsyStoryIAndRLibrary = BGW_GameDB.GetPigsyStoryIAndRLibrary(EPigsyStoryIAndRType.ResumeDefault);
		if (pigsyStoryIAndRLibrary != null && pigsyStoryIAndRLibrary.Count > 0)
		{
			flag = HandleAiConversation("八戒故事会::播放用于接续的对话", SpeakerGUID, pigsyStoryIAndRLibrary, EStoryConversationType.Resume);
		}
		if (!flag)
		{
			flag = ResumeLastStory(SpeakerGUID);
		}
		return flag;
	}

	private bool ResumeLastStory(string SpeakerGUID)
	{
		List<int> aiConversationIDs = new List<int> { PigsyStoryData.LastAiConversationID };
		bool num = HandleAiConversation("八戒故事会::继续播上回没讲完的故事", SpeakerGUID, aiConversationIDs, EStoryConversationType.Story);
		if (num)
		{
			OnPlayStorySuccess(PigsyStoryData.LastAiConversationID);
		}
		return num;
	}

	private void OnAiConversationEnded(string SpeakerGUID, uint ReqID, EAiConversationEventEndType EndType, EACInterruptReason InterruptReason)
	{
		if (ReqID != PigsyStoryData.CurAiConversationEventReqID)
		{
			return;
		}
		if (ReqID == PigsyStoryData.CurAiConversationEventReqID)
		{
			PigsyStoryData.CurAiConversationEventReqID = 0u;
		}
		EStoryConversationType storyConversationType = PigsyStoryData.StoryConversationType;
		PigsyStoryData.StoryConversationType = EStoryConversationType.None;
		if (EndType == EAiConversationEventEndType.Interrupt && (storyConversationType == EStoryConversationType.Story || storyConversationType == EStoryConversationType.Resume))
		{
			EPigsyStoryIAndRType ePigsyStoryIAndRType = EPigsyStoryIAndRType.None;
			switch (InterruptReason)
			{
			case EACInterruptReason.IntoBattle:
				ePigsyStoryIAndRType = EPigsyStoryIAndRType.InterruptIntoBattle;
				break;
			case EACInterruptReason.PigsyStory_PlayerMoveOverDist:
				ePigsyStoryIAndRType = EPigsyStoryIAndRType.InterruptPlayerMoveOverDist;
				break;
			case EACInterruptReason.PigsyStory_BajieInteractWait:
				ePigsyStoryIAndRType = EPigsyStoryIAndRType.InterruptBajieInteractWait;
				break;
			}
			if (ePigsyStoryIAndRType != EPigsyStoryIAndRType.None)
			{
				InterruptCurStory(SpeakerGUID, ePigsyStoryIAndRType);
			}
		}
		else if (EndType == EAiConversationEventEndType.Complete && storyConversationType == EStoryConversationType.Resume)
		{
			ResumeLastStory(SpeakerGUID);
		}
	}

	private void OnCurStoryFinished(uint AiConversationChain_RootID)
	{
		if (PigsyStoryData.CurAiConversationChainID == AiConversationChain_RootID)
		{
			PigsyStoryData.CurAiConversationChainID = 0u;
			PigsyStoryData.LastAiConversationID = 0;
			PigsyStoryData.StoryConversationType = EStoryConversationType.None;
			PigsyStoryData.StoryComplete();
			base.BGSEventCollection.Evt_OnCurStoryFinished.Invoke();
			if (PigsyStoryData.Update_AllStoryFinished_CurLevel())
			{
				OnCurLevelStoryAllFinished();
			}
		}
	}

	private void OnCurLevelStoryAllFinished()
	{
	}

	private void OnAiConversationCastSuccess(string UnitGUID, int ConversationContentID, uint ConversationChainRootID, float CDTime, bool bIsGlobalCD = false)
	{
		if (ConversationChainRootID == PigsyStoryData.CurAiConversationChainID)
		{
			PigsyStoryData.LastAiConversationID = ConversationContentID;
			PigsyStoryData.CurAiConversationEventReqID = AiConversationMgrData.GetLast_AiConversationReqID();
			if (PigsyStoryData.StoryConversationType == EStoryConversationType.None)
			{
				PigsyStoryData.StoryConversationType = EStoryConversationType.Story;
			}
		}
	}

	private void IntoSpecificStoryArea(string StoryAreaGUID, int AreaPority, int AreaID)
	{
		if (StoryAreaGUID != null)
		{
			if (!PigsyStoryData.AreaDic.ContainsKey(StoryAreaGUID))
			{
				PigsyStoryData.AreaDic.Add(StoryAreaGUID, new FStoryAreaInfo(AreaPority, AreaID));
			}
			RefreshAreaID();
		}
	}

	private void ExitSpecificStoryArea(string StoryAreaGUID)
	{
		if (StoryAreaGUID != null)
		{
			if (PigsyStoryData.AreaDic.ContainsKey(StoryAreaGUID))
			{
				PigsyStoryData.AreaDic.Remove(StoryAreaGUID);
			}
			RefreshAreaID();
		}
	}

	private void RefreshAreaID()
	{
		if (PigsyStoryData.AreaDic == null || PigsyStoryData.AreaDic.Count < 1)
		{
			PigsyStoryData.CurrentAreaID = 0;
			return;
		}
		int num = 0;
		foreach (KeyValuePair<string, FStoryAreaInfo> item in PigsyStoryData.AreaDic)
		{
			if (item.Value.Pority >= num)
			{
				num = item.Value.Pority;
				PigsyStoryData.CurrentAreaID = item.Value.AreaID;
			}
		}
	}
}
