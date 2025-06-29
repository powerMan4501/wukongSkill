using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BAC_Event
{
	private FAiConversationProxy ParentProxy;

	private uint AiConversationChain_RootID;

	private uint AiConversationEvent_ReqID;

	private uint CurSubtitleReqID;

	private string Speaker_GUID;

	private TStrongObjectPtr<AActor> mSpeaker = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mEventCaster = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mAkPlayer = new TStrongObjectPtr<AActor>();

	private int AiConversationContentDescID;

	private int ContentPriority = -1;

	private int CurAkPlayingId;

	private UAkComponent LastAkComp;

	private string AkEventName = "";

	private UAnimMontage CurPlayingMontage;

	private bool StopMontageWhenEnd = true;

	private EAiConversationEndType EndType;

	private string NextConversationIDList;

	private int WeightIntheSameLevel;

	private float WaitTimer = -1f;

	private float DurationTimer_Manual = -1f;

	private List<FAiConversationConditionInstData> ConditionInstDataList;

	private const float INV1000 = 1000f;

	public Queue<SubtitleInfo> SubtileQueue;

	private float SubtileRemaining = -1f;

	private FName SpeakSocket = B1GlobalFNames.head;

	private const char SUBTITLE_SPLIT_TAG = '$';

	private AActor Speaker
	{
		get
		{
			return mSpeaker.Get();
		}
		set
		{
			mSpeaker.Set(value);
		}
	}

	private AActor EventCaster
	{
		get
		{
			return mEventCaster.Get();
		}
		set
		{
			mEventCaster.Set(value);
		}
	}

	private AActor AkPlayer
	{
		get
		{
			return mAkPlayer.Get();
		}
		set
		{
			mAkPlayer.Set(value);
		}
	}

	public BAC_Event(AActor _Speaker, string _SpeakerGUID, AActor _EventCaster, int ContentDescID, uint _AiConversationChain_RootID, BGUDialogueProxyActor DialogueProxy)
	{
		Speaker = _Speaker;
		Speaker_GUID = _SpeakerGUID;
		EventCaster = _EventCaster;
		if (_Speaker is ABGUTamerBase || _Speaker is BGUSceneItemBase)
		{
			AkPlayer = DialogueProxy;
			BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(DialogueProxy, BGUFuncLibActorTransformCS.BGUGetActorLocation(Speaker), BGUFuncLibActorTransformCS.BGUGetActorRotation(Speaker), bSweep: false, bTeleport: false);
		}
		else
		{
			AkPlayer = _Speaker;
		}
		AiConversationChain_RootID = _AiConversationChain_RootID;
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(ContentDescID);
		if (aiConversationContentDesc == null)
		{
			return;
		}
		AiConversationContentDescID = ContentDescID;
		ContentPriority = aiConversationContentDesc.ContentPriority;
		NextConversationIDList = aiConversationContentDesc.NextConversationIDList;
		WeightIntheSameLevel = FMath.Max(1, aiConversationContentDesc.WeightInSameLevel);
		ConditionInstDataList = new List<FAiConversationConditionInstData>();
		foreach (FAiConversationCondition condition in aiConversationContentDesc.Conditions)
		{
			AActor target = BGUFuncLibAiConversation.TargetFilter(_Speaker, _EventCaster, condition.ConditionTargetType, condition.TargetTypeParam);
			FAiConversationConditionInstData item = new FAiConversationConditionInstData(condition.ConditionTargetType, condition.TargetTypeParam, target, condition.ConditionType, condition.ConditionValue);
			ConditionInstDataList.Add(item);
		}
	}

	public void SetReqID(uint _AiConversationEvent_ReqID)
	{
		AiConversationEvent_ReqID = _AiConversationEvent_ReqID;
	}

	public uint GetEventReqID()
	{
		return AiConversationEvent_ReqID;
	}

	public bool InWaiting()
	{
		return WaitTimer > 0f;
	}

	public AActor GetSpeaker()
	{
		return Speaker;
	}

	public int GetAiConversationContentDescID()
	{
		return AiConversationContentDescID;
	}

	public int GetEventWeight()
	{
		return WeightIntheSameLevel;
	}

	public void Update(float DeltaTime)
	{
		if (WaitTimer > 0f)
		{
			WaitTimer -= DeltaTime;
			if (WaitTimer < 0f)
			{
				WaitTimer = -1f;
				HandleConversation_Implement();
			}
		}
		else if (EndType == EAiConversationEndType.Manual && DurationTimer_Manual > 0f)
		{
			DurationTimer_Manual -= DeltaTime;
			if (DurationTimer_Manual < 0f)
			{
				DurationTimer_Manual = -1f;
				CompleteEvent();
			}
		}
		if (SubtileRemaining >= 0f)
		{
			SubtileRemaining -= DeltaTime;
			if (SubtileRemaining < 0f)
			{
				PlaySubtile();
			}
		}
	}

	public void PendingHandleConversation(FAiConversationProxy _ParentProxy)
	{
		if (_ParentProxy == null)
		{
			return;
		}
		ParentProxy = _ParentProxy;
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(AiConversationContentDescID);
		if (aiConversationContentDesc != null)
		{
			if (aiConversationContentDesc.WaitTimeMs > 0)
			{
				WaitTimer = (float)aiConversationContentDesc.WaitTimeMs / 1000f;
			}
			else
			{
				WaitTimer = -1f;
				HandleConversation_Implement();
			}
			if (!Speaker.IsNullOrDestroyed())
			{
				BGS_EventCollectionCS.Get(Speaker)?.Evt_OnAiConversationCastSuccess.Invoke(Speaker_GUID, AiConversationContentDescID, AiConversationChain_RootID, (float)aiConversationContentDesc.CDTimeMs / 1000f, aiConversationContentDesc.IsGlobalCD == EGSYesNo.Yes);
			}
		}
	}

	private void HandleConversation_Implement()
	{
		if (Speaker == null || AkPlayer == null)
		{
			return;
		}
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(AiConversationContentDescID);
		if (aiConversationContentDesc == null)
		{
			return;
		}
		bool flag = false;
		EndType = aiConversationContentDesc.EndType;
		USceneComponent sceneComp = AkPlayer.RootComponent;
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		if (AkPlayer is ACharacter aCharacter)
		{
			sceneComp = (uSkeletalMeshComponent = aCharacter.Mesh);
		}
		else if (AkPlayer is BGUPerformerActorCS bGUPerformerActorCS)
		{
			sceneComp = (uSkeletalMeshComponent = bGUPerformerActorCS.Mesh);
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Speaker);
		if (!string.IsNullOrEmpty(aiConversationContentDesc.AkEventPath))
		{
			UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(Speaker).TryGetCachedResourceObj<UAkAudioEvent>(aiConversationContentDesc.AkEventPath, ELoadResourceType.SyncLoadAndCache, EAssetPriority.High);
			if (!(uAkAudioEvent != null))
			{
				AkEventPlayFailed(aiConversationContentDesc.AkEventPath, "Audio资源加载失败");
				return;
			}
			BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(AkPlayer);
			if (bUS_GSEventCollection2 != null)
			{
				bUS_GSEventCollection2?.Evt_PostAkEvent_Follow.Invoke(sceneComp, SpeakSocket, uAkAudioEvent, bPlaySubtitle: true, bNeedRecordSubtitleStamp: true);
				b1.IBUC_AkMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_AkMgrData, BUC_AKMgrData>(AkPlayer);
				if (readOnlyData != null)
				{
					CurAkPlayingId = readOnlyData.LastPlayingID;
					LastAkComp = readOnlyData.LastFollowAkComp;
					AkEventName = uAkAudioEvent.GetFName().ToString();
				}
				if (CurAkPlayingId <= 0)
				{
					AkEventPlayFailed(aiConversationContentDesc.AkEventPath, "Audio资源加载出来，但播放失败了");
					return;
				}
				if (EndType == EAiConversationEndType.AkEnded)
				{
					bUS_GSEventCollection2.Evt_OnAkEventEnded += new Del_Void_Int(OnCurConversationEnd_AkCallBack);
					flag = true;
				}
			}
		}
		bool flag2 = aiConversationContentDesc.InterruptionDistance > 0f;
		if (flag2)
		{
			bool p = aiConversationContentDesc.OverDistIntrruptAsComplete == EGSYesNo.Yes;
			bUS_GSEventCollection?.Evt_ActiveAiConversationDistanceInterruptCheck.Invoke(flag2, p, aiConversationContentDesc.InterruptionDistance);
		}
		if (!string.IsNullOrEmpty(aiConversationContentDesc.ForceListenerGuid) && aiConversationContentDesc.ForceListenerDistance > 0f)
		{
			bUS_GSEventCollection?.Evt_ActiveAiConversationListenerStateInterruptCheck.Invoke(P1: true, aiConversationContentDesc.ForceListenerGuid, aiConversationContentDesc.ForceListenerDistance);
		}
		if (uSkeletalMeshComponent != null)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(uSkeletalMeshComponent).TryGetCachedResourceObj<UAnimMontage>(aiConversationContentDesc.AMPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
			if (uAnimMontage != null)
			{
				ACharacter aCharacter2 = Speaker as ACharacter;
				if (aCharacter2 != null)
				{
					aCharacter2.StopAnimMontage(null);
				}
				float num = BGUFuncLibAnim.BGUActorTryPlayMontage(Speaker, uAnimMontage, FName.None);
				if (num > 0f)
				{
					CurPlayingMontage = uAnimMontage;
					StopMontageWhenEnd = aiConversationContentDesc.NotStopMontageWhenEnd == EGSYesNo.No;
					if (EndType == EAiConversationEndType.AmEnded)
					{
						DurationTimer_Manual = num;
						flag = true;
					}
				}
			}
		}
		if (!flag || EndType == EAiConversationEndType.None || EndType == EAiConversationEndType.Manual)
		{
			DurationTimer_Manual = (float)aiConversationContentDesc.ContentDurTimeMs / 1000f;
			flag = true;
			EndType = EAiConversationEndType.Manual;
		}
		SubtitleInit();
	}

	private void AkEventPlayFailed(string AkEventPath, string FailedLog)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "warning:Speaker丢失 ";
			if (!Speaker.IsNullOrDestroyed())
			{
				text = Speaker.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Speaker, EBattleInfoType.AiConversation, "<character>" + text + "</><Effect>【Error】：</><action>" + FailedLog + "</><assetpath>" + AkEventPath + "</>");
		}
		ParentProxy.OnEventEnded();
	}

	private void SubtitleInit()
	{
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(AiConversationContentDescID);
		if (aiConversationContentDesc == null)
		{
			return;
		}
		SubtileQueue = new Queue<SubtitleInfo>();
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<bool> list3 = new List<bool>();
		if (!string.IsNullOrEmpty(aiConversationContentDesc.DialogueIDs))
		{
			foreach (int item in BGUFuncLibAiConversation.AnalysisStrParam_To_IntValueList(aiConversationContentDesc.DialogueIDs, '$'))
			{
				FUStDialogueDesc dialogueDesc = BGW_GameDB.GetDialogueDesc(item);
				if (dialogueDesc != null)
				{
					list.Add(dialogueDesc.Name);
					list2.Add(dialogueDesc.Content);
					list3.Add(dialogueDesc.IsSupportSoundDirection == EGSYesNo.Yes);
				}
			}
		}
		else
		{
			list2 = BGUFuncLibAiConversation.AnalysisStrParam_To_StrValueList(aiConversationContentDesc.Subtitle);
			foreach (string item2 in list2)
			{
				_ = item2;
				list.Add("");
				list3.Add(item: false);
			}
		}
		List<int> list4 = BGUFuncLibAiConversation.AnalysisStrParam_To_IntValueList(aiConversationContentDesc.SubtitleDurTimeMs);
		for (int i = 0; i < list2.Count; i++)
		{
			if (!string.IsNullOrEmpty(list2[i]) && list4.Count > i && list4[i] > 0)
			{
				int num = ((list4.Count > i) ? list4[i] : 0);
				float duration = (((float)num <= 0f) ? 2f : ((float)num / 1000f));
				SubtileQueue.Enqueue(new SubtitleInfo(list[i], list2[i], duration, list3[i]));
			}
		}
		if (SubtileQueue.Count > 0)
		{
			PlaySubtile();
		}
	}

	private void PlaySubtile()
	{
		if (SubtileQueue.Count < 1)
		{
			SubtileRemaining = -1f;
		}
		else
		{
			if (Speaker.IsNullOrDestroyed())
			{
				return;
			}
			SubtitleInfo subtitleInfo = SubtileQueue.Dequeue();
			SubtileRemaining = subtitleInfo.duration;
			if (!(BUS_EventCollectionCS.Get(AkPlayer) != null))
			{
				return;
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = "warning:Speaker丢失 ";
				if (!Speaker.IsNullOrDestroyed())
				{
					text = Speaker.GetName();
				}
				BGUFunctionLibraryCS.LogBattleInfo(Speaker, EBattleInfoType.AiConversation, "<character>" + text + "</><action>:字幕:</><assetpath>" + subtitleInfo.content.ToFText().ToString() + "</>");
				BGUFunctionLibraryCS.LogBattleInfo(Speaker, EBattleInfoType.AiConversation, $"<character>{text}</><action>:字幕时间:{subtitleInfo.duration}秒</>");
			}
			BGW_UIMgr bGW_UIMgr = BGW_UIMgr.Get(AkPlayer);
			if (bGW_UIMgr != null)
			{
				CurSubtitleReqID = bGW_UIMgr.PlaySubtitle(subtitleInfo.name.ToFText().ToString(), subtitleInfo.content.ToFText().ToString(), subtitleInfo.duration, subtitleInfo.IsSupportSoundDirection, AkPlayer);
			}
		}
	}

	public void OnCurConversationEnd_AkCallBack(int Ended_PlayingId)
	{
		if (Ended_PlayingId == CurAkPlayingId)
		{
			OnEventComplete(bNeedStopAkEvent: false);
		}
	}

	public void CompleteEvent()
	{
		OnEventComplete();
	}

	public void CompleteEvent_WithoutTriggerNextAiConversation(EACInterruptReason Reason)
	{
		OnEventComplete(bNeedStopAkEvent: true, bNeedTriggerNextAiConversation: false, Reason);
	}

	public void JumpToNextSubtitleMarkerPos()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(AkPlayer);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_JumpToNextSubtitleMarkerPos.Invoke(AkEventName, LastAkComp, CurAkPlayingId);
		}
	}

	private void OnEventComplete(bool bNeedStopAkEvent = true, bool bNeedTriggerNextAiConversation = true, EACInterruptReason Reason = EACInterruptReason.None)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = ":当前事件结束" + AiConversationContentDescID;
			switch (EndType)
			{
			case EAiConversationEndType.Manual:
				text += "(配表时间结束)";
				break;
			case EAiConversationEndType.AmEnded:
				text += "(AM结束)";
				break;
			case EAiConversationEndType.AkEnded:
				text += "(AKEvent结束)";
				break;
			case EAiConversationEndType.None:
				text += Reason;
				break;
			}
			if (NextConversationIDList.Length > 0)
			{
				text += ",下个列表：";
				text += NextConversationIDList;
				if (!bNeedTriggerNextAiConversation)
				{
					text += "但不需要触发（可能的原因有：1、交互跳过）";
				}
			}
			else
			{
				text += ",没有下文了";
			}
			string text2 = "warning:Speaker丢失 ";
			if (!Speaker.IsNullOrDestroyed())
			{
				text2 = Speaker.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Speaker, EBattleInfoType.AiConversation, "<character>" + text2 + "</><action>:" + text + "</>");
			BGUFunctionLibraryCS.LogBattleInfo(Speaker, EBattleInfoType.AiConversation, "<action>-----------------------------------------------------------------------</>");
		}
		EndAkEvent(bNeedStopAkEvent);
		EndAnimMontage();
		EndSubtitleTest();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Speaker);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(Speaker);
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(AiConversationContentDescID);
		if (aiConversationContentDesc != null && aiConversationContentDesc.ModifyFacts.Count > 0)
		{
			foreach (FACModifyFactData modifyFact in aiConversationContentDesc.ModifyFacts)
			{
				bUS_GSEventCollection?.Evt_ModifyAiConvBlackboardData.Invoke(modifyFact.KeyName, modifyFact.OperateType, modifyFact.ModifyValue);
			}
		}
		ParentProxy.OnEventEnded();
		bGS_GSEventCollection?.Evt_OnAiConversationEnded.Invoke(Speaker_GUID, AiConversationEvent_ReqID, EAiConversationEventEndType.Complete, EACInterruptReason.None);
		bool flag = true;
		if (bNeedTriggerNextAiConversation && !string.IsNullOrEmpty(NextConversationIDList))
		{
			List<int> list = BGUFuncLibAiConversation.AnalysisStrParam_To_IntValueList(NextConversationIDList);
			if (list.Count > 0)
			{
				if (EventCaster.IsNullOrDestroyed())
				{
					EventCaster = Speaker;
				}
				bGS_GSEventCollection?.Evt_PocessEventByContentIDList.Invoke("触发下一条对话", EventCaster, list, AiConversationChain_RootID);
				bool flag2 = false;
				IBGC_AiConversationMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_AiConversationMgrData>(Speaker);
				if (gameStateReadonlyData != null)
				{
					flag2 = gameStateReadonlyData.GetLast_bPocessSuccess();
				}
				if (flag2)
				{
					flag = false;
				}
			}
		}
		if (flag)
		{
			bUS_GSEventCollection?.Evt_OnAiConversationListEnded.Invoke();
			bGS_GSEventCollection?.Evt_OnConversationChainEnd.Invoke(AiConversationChain_RootID);
		}
	}

	public void InterruptEvent(EACInterruptReason Reason)
	{
		OnEventInterrupted(Reason);
	}

	private void OnEventInterrupted(EACInterruptReason Reason)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Speaker);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(Speaker);
		bUS_GSEventCollection?.Evt_OnAiConversationListInteraputed?.Invoke();
		ParentProxy.OnEventEnded();
		bGS_GSEventCollection?.Evt_OnAiConversationEnded.Invoke(Speaker_GUID, AiConversationEvent_ReqID, EAiConversationEventEndType.Interrupt, Reason);
		bGS_GSEventCollection?.Evt_OnConversationChainInterrupt.Invoke(AiConversationChain_RootID);
		EndAkEvent();
		EndAnimMontage();
		EndSubtitleTest();
	}

	private void EndAkEvent(bool bNeedStopAkEvent = true)
	{
		if (CurAkPlayingId == -1)
		{
			return;
		}
		if (EndType == EAiConversationEndType.AkEnded)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(AkPlayer);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnAkEventEnded -= new Del_Void_Int(OnCurConversationEnd_AkCallBack);
			}
		}
		if (bNeedStopAkEvent)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(CurAkPlayingId, 0, 4);
		}
		CurAkPlayingId = -1;
	}

	private void EndAnimMontage()
	{
		if (CurPlayingMontage != null && StopMontageWhenEnd)
		{
			ACharacter aCharacter = Speaker as ACharacter;
			if (aCharacter != null)
			{
				aCharacter.StopAnimMontage(null);
			}
			CurPlayingMontage = null;
		}
	}

	private void EndSubtitleTest()
	{
		if (CurSubtitleReqID != 0)
		{
			BGW_UIMgr bGW_UIMgr = BGW_UIMgr.Get(AkPlayer);
			if (bGW_UIMgr != null)
			{
				bGW_UIMgr?.StopSubtitle(CurSubtitleReqID);
			}
			CurSubtitleReqID = 0u;
		}
	}

	public bool PocessConditions()
	{
		bool flag = true;
		foreach (FAiConversationConditionInstData conditionInstData in ConditionInstDataList)
		{
			BACC_Base conditionTemplate = BGW_BACCTemplateList.Get(Speaker).GetConditionTemplate(conditionInstData.ConditionType);
			flag = conditionTemplate != null && (flag & conditionTemplate.PocessCondition(Speaker, conditionInstData));
			if (!flag)
			{
				break;
			}
		}
		return flag;
	}

	public int GetConditionNum()
	{
		return ConditionInstDataList.Count;
	}

	public int GetPlayingId()
	{
		return CurAkPlayingId;
	}

	public int GetContentPriority()
	{
		return ContentPriority;
	}
}
