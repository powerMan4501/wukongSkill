using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_AiConversationMgr : GameStateSystemBase
{
	private BGC_AiConversationMgrData AiConversationMgrData { get; set; }

	private IBGC_MovieData MovieData { get; set; }

	private IBGC_TamerData TamerData { get; set; }

	private Dictionary<string, FAiConversationProxy> ACProxy_Dic { get; set; } = new Dictionary<string, FAiConversationProxy>();

	public override void OnAttach()
	{
		AiConversationMgrData = RequireWritableData<BGC_AiConversationMgrData>();
		MovieData = RequireReadOnlyData<IBGC_MovieData, BGC_MovieData>();
		TamerData = RequireReadOnlyData<IBGC_TamerData, BGC_TamerData>();
		FVector location = FVector.ZeroVector;
		FRotator rotation = FRotator.ZeroRotator;
		AiConversationMgrData.Narrator = Owner.World.SpawnActor<BGUNarrator>(ref location, ref rotation);
		AiConversationMgrData.DialogueProxyActor = Owner.World.SpawnActor<BGUDialogueProxyActor>(ref location, ref rotation);
		base.BGSEventCollection.Evt_OnAiConversationCastSuccess += new Del_OnAiConversationCastSuccess(OnAiConversationCastSuccess);
		base.BGSEventCollection.Evt_OnConversationChainEnd += new Del_Void_Uint(OnConversationChainEnd);
		base.BGSEventCollection.Evt_OnConversationChainInterrupt += new Del_Void_Uint(OnConversationChainInterrupt);
		base.BGSEventCollection.Evt_PocessEventByContentIDList += new Del_PocessEventByContentIDList(PocessEventByContentIDList);
		base.BGSEventCollection.Evt_PocessEventByContentIDList_ByGuid += new Del_PocessEventByContentIDList_ByGuid(PocessEventByContentIDList_GUID);
		base.BGSEventCollection.Evt_OnAiConversationEnded += new Del_OnAiConversationEnded(OnAiConversationEnded);
		base.BGSEventCollection.Evt_BGS_StopAiConversation += new Del_StopAiConversation(StopAiConversation);
		base.BGSEventCollection.Evt_BGS_StopAiConversation_ByGUID += new Del_StopAiConversation_ByGUID(StopAiConversation_ByGuid);
		base.BGSEventCollection.Evt_BGS_StopAllAiConversation += new Del_StopAllAiConversation(StopAllAiConversation);
		base.BGSEventCollection.Evt_BGS_JumpToNextSubtitleMarkerPos += new Del_Void_Actor(JumpToNextSubtitleMarkerPos);
		base.BGSEventCollection.Evt_BGS_UnregisterAiConversationProxy += new Del_Void_String(UnregistUnit);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnLoadingBeginFadeAway));
	}

	private uint RequestNewChainID()
	{
		if (AiConversationMgrData.UniqueChainID == uint.MaxValue)
		{
			AiConversationMgrData.UniqueChainID = 1u;
		}
		else
		{
			AiConversationMgrData.UniqueChainID++;
		}
		return AiConversationMgrData.UniqueChainID;
	}

	private uint RequestNewEventID()
	{
		if (AiConversationMgrData.UniqueEventID == uint.MaxValue)
		{
			AiConversationMgrData.UniqueEventID = 1u;
		}
		else
		{
			AiConversationMgrData.UniqueEventID++;
		}
		return AiConversationMgrData.UniqueEventID;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CDMapTick(DeltaTime);
		ProxyTick(DeltaTime);
	}

	private void CDMapTick(float DeltaTime)
	{
		if (AiConversationMgrData.CDMap.Count <= 0)
		{
			return;
		}
		int[] array = AiConversationMgrData.CDMap.Keys.ToArray();
		foreach (int key in array)
		{
			AiConversationMgrData.CDMap[key].UpdateData(DeltaTime);
			if (AiConversationMgrData.CDMap[key].IsEmpty())
			{
				AiConversationMgrData.CDMap.Remove(key);
			}
		}
	}

	private void ProxyTick(float DeltaTime)
	{
		if (ACProxy_Dic.Count <= 0)
		{
			return;
		}
		string[] array = ACProxy_Dic.Keys.ToArray();
		foreach (string key in array)
		{
			ACProxy_Dic[key].Update(DeltaTime);
			if (ACProxy_Dic[key].IsFinished())
			{
				ACProxy_Dic.Remove(key);
			}
		}
	}

	private bool IsInCD(string UnitGUID, int ConversationContentID)
	{
		if (!AiConversationMgrData.CDMap.ContainsKey(ConversationContentID))
		{
			return false;
		}
		return AiConversationMgrData.CDMap[ConversationContentID].IsInCD(UnitGUID);
	}

	private void OnAiConversationCastSuccess(string UnitGUID, int ConversationContentID, uint ConversationChainRootID, float CDTime, bool bIsGlobalCD = false)
	{
		AiConversationMgrData.CurSpeakerCount++;
		if (!(CDTime <= 0f))
		{
			if (!AiConversationMgrData.CDMap.ContainsKey(ConversationContentID))
			{
				AiConversationMgrData.CDMap.Add(ConversationContentID, new FAiConversationContentCDData());
			}
			AiConversationMgrData.CDMap[ConversationContentID].CastCD(UnitGUID, CDTime, bIsGlobalCD);
		}
	}

	public void OnAiConversationEnded(string SpeakGuid, uint ReqID, EAiConversationEventEndType EndType, EACInterruptReason InterruptReason)
	{
		AiConversationMgrData.CurSpeakerCount--;
	}

	private void PocessEventByContentIDList(string SourceLog, AActor Caster, List<int> ConversationContentIDList, uint ConversationChain_RootID = 0u)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "warning:Caster丢失 ";
			if (!Caster.IsNullOrDestroyed())
			{
				text = Caster.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<character>" + text + "</><action>发起AiConversation请求，请求源自于</><effect>" + SourceLog + "</>");
		}
		AiConversationMgrData.Last_bPocessSuccess = false;
		AiConversationMgrData.Last_ChainRootID = 0u;
		AiConversationMgrData.Last_AiConversationReqID = 0u;
		AiConversationMgrData.Last_AiConversationDescID = 0;
		if (ConversationContentIDList.Count < 1 || !CanTriggerAiConversation())
		{
			return;
		}
		List<int> list = BGUFuncLibAiConversation.AnalysisAiConversationIDList(ConversationContentIDList);
		if (list.Count < 1)
		{
			return;
		}
		List<BAC_Event> list2 = new List<BAC_Event>();
		if (ConversationChain_RootID == 0)
		{
			ConversationChain_RootID = RequestNewChainID();
		}
		foreach (int item2 in list)
		{
			FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(item2);
			if (aiConversationContentDesc == null)
			{
				continue;
			}
			AActor aActor = BGUFuncLibAiConversation.TargetFilter(Caster, Caster, aiConversationContentDesc.SpeakerType, aiConversationContentDesc.SpeakerFilterParam);
			if (aActor.IsNullOrDestroyed())
			{
				continue;
			}
			string actorGuid = BGU_DataUtil.GetActorGuid(aActor);
			if (IsInCD(actorGuid, item2))
			{
				continue;
			}
			int num = FMath.RandRange(0, 100);
			if (num > aiConversationContentDesc.Probability)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					string text2 = "warning:Speaker丢失 ";
					if (!aActor.IsNullOrDestroyed())
					{
						text2 = aActor.GetName();
					}
					BGUFunctionLibraryCS.LogBattleInfo(aActor, EBattleInfoType.AiConversation, $"<character>{text2}</><action>:AiConversation{item2}使用概率抽取值为{num}, 不在配置范围内：0~{aiConversationContentDesc.Probability}故不取用</>");
				}
			}
			else
			{
				BAC_Event item = new BAC_Event(aActor, actorGuid, Caster, item2, ConversationChain_RootID, AiConversationMgrData.DialogueProxyActor);
				list2.Add(item);
			}
		}
		uint num2 = RequestNewEventID();
		AiConversationMgrData.Last_ChainRootID = ConversationChain_RootID;
		AiConversationMgrData.CurPlayingChainList.Add(ConversationChain_RootID);
		AiConversationMgrData.Last_AiConversationReqID = num2;
		AiConversationMgrData.Last_AiConversationDescID = ((list2.Count > 0) ? list2[0].GetAiConversationContentDescID() : 0);
		AiConversationMgrData.Last_bPocessSuccess = PocessEventList(Caster, list, list2, num2);
	}

	private void PocessEventByContentIDList_GUID(string SourceLog, string UnitGuid, List<int> ConversationContentIDList, uint ConversationChain_RootID = 0u)
	{
		AActor aActor = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid);
		if (aActor == null)
		{
			TamerData.TryGetTamerEntityRef(UnitGuid, out var OutTamerRef);
			if (OutTamerRef != null && OutTamerRef.InstancePtr.Get() != null)
			{
				aActor = OutTamerRef.InstancePtr.Get();
			}
		}
		if (!(aActor == null))
		{
			PocessEventByContentIDList(SourceLog, aActor, ConversationContentIDList, ConversationChain_RootID);
		}
	}

	private bool PocessEventList(AActor Caster, List<int> EventIDList, List<BAC_Event> EventList, uint EventReqID)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = string.Empty;
			foreach (int EventID in EventIDList)
			{
				text = text + EventID + ",";
			}
			string text2 = "warning:Caster丢失 ";
			if (!Caster.IsNullOrDestroyed())
			{
				text2 = Caster.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<character>" + text2 + "</><action>发起对话，对话列表：</><effect>" + text + "</>");
		}
		List<BAC_Event> list = new List<BAC_Event>();
		foreach (BAC_Event Event in EventList)
		{
			if (Event.PocessConditions())
			{
				list.Add(Event);
			}
		}
		if (list.Count < 1)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text3 = "warning:Caster丢失 ";
				if (!Caster.IsNullOrDestroyed())
				{
					text3 = Caster.GetName();
				}
				BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<character>" + text3 + "</><action>发起对话，但条件都不满足，导致无话可说</>");
			}
			return false;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text4 = string.Empty;
			foreach (BAC_Event item in list)
			{
				text4 = text4 + item.GetAiConversationContentDescID() + ",";
			}
			string text5 = "warning:Caster丢失 ";
			if (!Caster.IsNullOrDestroyed())
			{
				text5 = Caster.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<character>" + text5 + "</><action>:可用内容列表:</><effect>" + text4 + "</>");
		}
		List<BAC_Event> list2 = new List<BAC_Event>();
		list2 = GetEventList_TopPorityByConditionNum(list);
		int randomIndexByWeight = GetRandomIndexByWeight(list2);
		BAC_Event bAC_Event = list2[randomIndexByWeight];
		bAC_Event.SetReqID(EventReqID);
		bool result = false;
		AActor speaker = bAC_Event.GetSpeaker();
		string actorGuid = BGU_DataUtil.GetActorGuid(speaker);
		if (string.IsNullOrEmpty(actorGuid))
		{
			return result;
		}
		result = HandleAiConversation(actorGuid, speaker, bAC_Event, EventReqID);
		if (result && DebugConfig.IsOpenBattleInfoTool)
		{
			string arg = "warning:Caster丢失 ";
			if (!Caster.IsNullOrDestroyed())
			{
				arg = Caster.GetName();
			}
			string text6 = "warning:FinalSpeaker丢失 ";
			if (!bAC_Event.GetSpeaker().IsNullOrDestroyed())
			{
				text6 = bAC_Event.GetSpeaker().GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, $"<character>{arg}</><action>最终选用的内容ID:</><effect>{bAC_Event.GetAiConversationContentDescID()}</>");
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<action>说话人是</><character>" + text6 + "</>");
			BGUFunctionLibraryCS.LogBattleInfo(Caster, EBattleInfoType.AiConversation, "<action>-----------------------------------------------------------------------</>");
		}
		return result;
	}

	private List<BAC_Event> GetEventList_TopPorityByConditionNum(List<BAC_Event> EventList)
	{
		List<BAC_Event> list = new List<BAC_Event>();
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		for (int i = 0; i < EventList.Count; i++)
		{
			int conditionNum = EventList[i].GetConditionNum();
			if (dictionary.ContainsKey(conditionNum))
			{
				dictionary[conditionNum].Add(i);
				continue;
			}
			dictionary.Add(conditionNum, new List<int>());
			dictionary[conditionNum].Add(i);
		}
		int num = 0;
		foreach (KeyValuePair<int, List<int>> item in dictionary)
		{
			if (item.Key > num)
			{
				num = item.Key;
			}
		}
		foreach (int item2 in dictionary[num])
		{
			list.Add(EventList[item2]);
		}
		return list;
	}

	private int GetRandomIndexByWeight(List<BAC_Event> EventList_Worthy)
	{
		if (EventList_Worthy.Count < 0)
		{
			return -1;
		}
		if (EventList_Worthy.Count <= 1)
		{
			return 0;
		}
		int num = 0;
		foreach (BAC_Event item in EventList_Worthy)
		{
			num += item.GetEventWeight();
		}
		int num2 = FMath.RandRange(0, num);
		for (int i = 0; i < EventList_Worthy.Count; i++)
		{
			if (num2 <= EventList_Worthy[i].GetEventWeight())
			{
				return i;
			}
			num2 -= EventList_Worthy[i].GetEventWeight();
		}
		return -1;
	}

	private void OnConversationChainEnd(uint ChainRootID)
	{
		AiConversationMgrData.ChainEndList.Add(ChainRootID);
		AiConversationMgrData.CurPlayingChainList.Remove(ChainRootID);
	}

	private void OnConversationChainInterrupt(uint ChainRootID)
	{
		AiConversationMgrData.ChainInterruptList.Add(ChainRootID);
		AiConversationMgrData.CurPlayingChainList.Remove(ChainRootID);
	}

	private bool CanTriggerAiConversation()
	{
		if (MovieData != null && MovieData.IsPlaying())
		{
			return false;
		}
		return true;
	}

	private bool HandleAiConversation(string GUID, AActor Unit, BAC_Event NewEvent, uint EventReqID)
	{
		if (Unit == null || NewEvent == null)
		{
			return false;
		}
		if (ACProxy_Dic.ContainsKey(GUID))
		{
			ACProxy_Dic[GUID].HandleConversation(Unit, NewEvent);
		}
		else
		{
			ACProxy_Dic.Add(GUID, new FAiConversationProxy(Unit, AiConversationMgrData.DialogueProxyActor));
			ACProxy_Dic[GUID].HandleConversation(Unit, NewEvent);
		}
		return EventReqID == ACProxy_Dic[GUID].GetReqID_CurPlayingEvent();
	}

	private void StopAiConversation(AActor Unit, EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		string actorGuid = BGU_DataUtil.GetActorGuid(Unit);
		StopAiConversation_ByGuid(actorGuid, InterruptType, InterruptReason);
	}

	private void StopAiConversation_ByGuid(string Unit_GUID, EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		if (ACProxy_Dic.TryGetValue(Unit_GUID, out var value))
		{
			value.StopAiConversation(InterruptType, InterruptReason);
		}
	}

	private void JumpToNextSubtitleMarkerPos(AActor Unit)
	{
		if (!Unit.IsNullOrDestroyed())
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(Unit);
			if (ACProxy_Dic.TryGetValue(actorGuid, out var value))
			{
				value.JumpToNextSubtitleMarkerPos();
			}
		}
	}

	private void StopAllAiConversation(EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		foreach (KeyValuePair<string, FAiConversationProxy> item in ACProxy_Dic)
		{
			item.Value?.StopAiConversation(InterruptType, InterruptReason);
		}
		ACProxy_Dic.Clear();
	}

	private void OnLoadingBeginFadeAway()
	{
		StopAllAiConversation(EACInterruptType.Interrupt, EACInterruptReason.LoadingBeginFadeAway);
	}

	private void UnregistUnit(string UnitGUID)
	{
		if (UnitGUID != null && ACProxy_Dic.ContainsKey(UnitGUID))
		{
			if (ACProxy_Dic[UnitGUID] != null)
			{
				ACProxy_Dic[UnitGUID].StopAiConversation(EACInterruptType.Interrupt, EACInterruptReason.EndPlay);
			}
			ACProxy_Dic.Remove(UnitGUID);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnLoadingBeginFadeAway));
		}
		StopAllAiConversation(EACInterruptType.Interrupt, EACInterruptReason.EndPlay);
	}
}
