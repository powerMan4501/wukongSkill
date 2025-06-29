using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AIConversationCompl : UActorCompBaseCS
{
	private BUC_AiConversationData AiConversationData;

	private BUC_AiConversationBlackboard AiConversationBlackboard;

	private IBUC_TickRateData TickRateData;

	private IBUC_UnitStateData UnitStateData;

	public override void OnAttach()
	{
		AiConversationData = RequireWritableData<BUC_AiConversationData>();
		AiConversationBlackboard = RequireWritableData<BUC_AiConversationBlackboard>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		foreach (int aIConversationEvntID in AiConversationData.AIConversationEvntIDList)
		{
			RegisterACEvent(aIConversationEvntID);
		}
		base.BUSEventCollection.Evt_HandleConversationByContentIDList += new Del_HandleConversationByContentIDList(HandleConversationByContentIDList);
		base.BUSEventCollection.Evt_ModifyAiConvBlackboardData += new Del_ModifyAiConvBlackboardData(ModifyBlackboardData);
		base.BUSEventCollection.Evt_ActiveAiConversationDistanceInterruptCheck += new Del_Void_BoolBoolFloat(ActiveDistanceCheck);
		base.BUSEventCollection.Evt_ActiveAiConversationListenerStateInterruptCheck += new Del_Void_BoolStringFloat(ActiveListenerStateCheck);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnBattleStateChange);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead_Interrupt);
		BindEvents();
	}

	public override void PreBeginPlay()
	{
		AiConversationData.OwnerGUID = BGU_DataUtil.GetActorGuid(Owner);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (base.BGSEventCollection != null && base.BGSEventCollection.HasBeginPlay)
		{
			base.BGSEventCollection?.Evt_BGS_UnregisterAiConversationProxy.Invoke(AiConversationData.OwnerGUID);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		PlayerDistanceCheck();
		ListenerStateCheck();
	}

	private void PlayerDistanceCheck()
	{
		if (AiConversationData.OverDistanceInterruption.bActive && TickRateData != null && TickRateData.GetDistanceToPlayer() >= AiConversationData.OverDistanceInterruption.OverDistance)
		{
			if (AiConversationData.OverDistanceInterruption.OverDistIntrruptAsComplete)
			{
				base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Complete, EACInterruptReason.OverDistance);
			}
			else
			{
				base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.OverDistance);
			}
			ActiveDistanceCheck(bActive: false);
		}
	}

	private void ActiveDistanceCheck(bool bActive, bool OverDistIntrruptAsComplete = false, float OverDistance = 0f)
	{
		AiConversationData.OverDistanceInterruption.bActive = bActive;
		AiConversationData.OverDistanceInterruption.OverDistance = OverDistance;
		AiConversationData.OverDistanceInterruption.OverDistIntrruptAsComplete = OverDistIntrruptAsComplete;
		if (DebugConfig.IsOpenBattleInfoTool && bActive)
		{
			string arg = "warning:Owner丢失 ";
			if (!Owner.IsNullOrDestroyed())
			{
				arg = Owner.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AiConversation, $"<character>{arg}</><action>激活超距离打断检测, 距离：</><effect>{OverDistance}</><action> 超距离打断视作事件结束:</><effect>{OverDistIntrruptAsComplete}</>");
		}
	}

	private void ListenerStateCheck()
	{
		if (AiConversationData.ListenerStateCheckData.bActive)
		{
			bool flag = false;
			EACInterruptReason interruptReason = EACInterruptReason.None;
			if (AiConversationData.ListenerStateCheckData.Listener.IsNullOrDestroyed())
			{
				interruptReason = EACInterruptReason.ListennerInvaild;
				flag = true;
			}
			else if (FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(AiConversationData.ListenerStateCheckData.Listener)) > AiConversationData.ListenerStateCheckData.OverDistance)
			{
				interruptReason = EACInterruptReason.ListennerOverDistance;
				flag = true;
			}
			else if (BGUFunctionLibraryCS.BGUIsUnitInBattle(AiConversationData.ListenerStateCheckData.Listener))
			{
				interruptReason = EACInterruptReason.ListennerIntoBattle;
				flag = true;
			}
			else if (BGUFunctionLibraryCS.BGUIsUnitDead(AiConversationData.ListenerStateCheckData.Listener))
			{
				interruptReason = EACInterruptReason.ListennerDead;
				flag = true;
			}
			if (flag)
			{
				base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, interruptReason);
				ActiveListenerStateCheck(bActive: false);
			}
		}
	}

	private void ActiveListenerStateCheck(bool bActive, string ListenerGuid = "", float Distance = 0f)
	{
		if (bActive)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, ListenerGuid);
			if (actorByGuid.IsNullOrDestroyed())
			{
				AiConversationData.ListenerStateCheckData.Disable();
			}
			else
			{
				AiConversationData.ListenerStateCheckData.bActive = true;
				AiConversationData.ListenerStateCheckData.ListenerGuid = ListenerGuid;
				AiConversationData.ListenerStateCheckData.OverDistance = Distance;
				AiConversationData.ListenerStateCheckData.Listener = actorByGuid;
			}
		}
		else
		{
			AiConversationData.ListenerStateCheckData.Disable();
		}
		if (DebugConfig.IsOpenBattleInfoTool && AiConversationData.ListenerStateCheckData.bActive)
		{
			string arg = "warning:Owner丢失 ";
			if (!Owner.IsNullOrDestroyed())
			{
				arg = Owner.GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AiConversation, $"<character>{arg}</><action>开始监听话搭子</><character>{ListenerGuid}</><action>的状态, 消失,死亡,进战或距离超过{Distance}时打断当前对话事件</>");
		}
	}

	private void ModifyBlackboardData(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		AiConversationBlackboard.ModifyData(KeyName, OperateType, ModifyContent);
	}

	private void RegisterACEvent(int EventID)
	{
		if (AiConversationData == null)
		{
			return;
		}
		FUStAiConversationEventDesc aiConversationEventDesc = BGW_GameDB.GetAiConversationEventDesc(EventID);
		if (aiConversationEventDesc == null || aiConversationEventDesc.ConversationIDs.Count < 1)
		{
			return;
		}
		EAiConversationEventType eventType = aiConversationEventDesc.EventType;
		List<int> value = new List<int>();
		if (!AiConversationData.AiConversationMap.ContainsKey(eventType))
		{
			AiConversationData.AiConversationMap.Add(eventType, value);
		}
		foreach (int conversationID in aiConversationEventDesc.ConversationIDs)
		{
			if (!AiConversationData.AiConversationMap[eventType].Contains(conversationID))
			{
				AiConversationData.AiConversationMap[eventType].Add(conversationID);
			}
		}
	}

	private void BindEvents()
	{
		if (AiConversationData == null)
		{
			return;
		}
		using Dictionary<EAiConversationEventType, List<int>>.KeyCollection.Enumerator enumerator = AiConversationData.AiConversationMap.Keys.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Current)
			{
			case EAiConversationEventType.OnPerceptionFindTarget:
				base.BUSEventCollection.Evt_PerceptionFindTarget += new Del_Void_Actor(Req_OnPerceptionFindTarget);
				break;
			case EAiConversationEventType.OnTriggerFightSkill:
				base.BUSEventCollection.Evt_CastOnFightSkillSuccess += new Del_Void_Int(Req_OnTriggerFightSkillSuccess);
				break;
			case EAiConversationEventType.OnWakeUp:
				base.BUSEventCollection.Evt_OnWakeUp += new Del_Void(Req_OnWakeUp);
				break;
			case EAiConversationEventType.OnDead:
				base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(Req_OnUnitTriggerDead);
				break;
			case EAiConversationEventType.OnKillPlayer:
				base.BUSEventCollection.Evt_OnKillVictim += new Del_Void_Actor(Req_OnKillPlayer);
				break;
			case EAiConversationEventType.OnPlayerApproached:
				base.BUSEventCollection.Evt_OnPlayerApproached += new Del_Void_Actor(Req_OnPlayerApproached);
				break;
			}
		}
	}

	private void Req_OnTriggerFightSkillSuccess(int SkillID)
	{
		PocessEventByType(EAiConversationEventType.OnTriggerFightSkill);
	}

	private void Req_OnPerceptionFindTarget(AActor Target)
	{
		PocessEventByType(EAiConversationEventType.OnPerceptionFindTarget);
	}

	private void Req_OnWakeUp()
	{
		PocessEventByType(EAiConversationEventType.OnWakeUp);
	}

	private void Req_OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (DeadReason == EDeadReason.SkillDamage)
		{
			PocessEventByType(EAiConversationEventType.OnDead);
		}
	}

	private void Req_OnKillPlayer(AActor KilledUnit)
	{
		if (BGU_DataUtil.GetActorType(KilledUnit) == BGU_ActorType.CharacterPlayer)
		{
			PocessEventByType(EAiConversationEventType.OnKillPlayer);
		}
	}

	private void Req_OnPlayerApproached(AActor PlayerActor)
	{
		if (BGU_DataUtil.GetActorType(PlayerActor) == BGU_ActorType.CharacterPlayer)
		{
			PocessEventByType(EAiConversationEventType.OnPlayerApproached);
		}
	}

	private void PocessEventByType(EAiConversationEventType EventType)
	{
		List<int> list = AiConversationData.AiConversationMap[EventType];
		if (list.Count >= 1 && (EventType == EAiConversationEventType.OnDead || UnitStateData == null || !UnitStateData.HasState(EBGUUnitState.Dead)))
		{
			string sourceLog = "配置在Tamer::ExtendConfigConfigComp中的Ai对话事件ID列表,类型为：" + EventType;
			base.BGSEventCollection?.Evt_PocessEventByContentIDList.Invoke(sourceLog, Owner, list);
		}
	}

	private void HandleConversationByContentIDList(string SourceLog, List<int> ContentIDList)
	{
		if (ContentIDList.Count >= 1)
		{
			base.BGSEventCollection?.Evt_PocessEventByContentIDList.Invoke(SourceLog, Owner, ContentIDList);
		}
	}

	private void OnResetActorStatusPre(EResetActorReason Reason)
	{
		base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.OnResetActorStatusPre);
	}

	private void OnBattleStateChange(bool bIsIntoBattle)
	{
		if (AiConversationData.InterruptAiConversationWhenIntoBattle && bIsIntoBattle)
		{
			base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.IntoBattle);
		}
	}

	private void OnUnitTriggerDead_Interrupt(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		base.BGSEventCollection.Evt_BGS_StopAiConversation.Invoke(Owner, EACInterruptType.Interrupt, EACInterruptReason.Dead);
	}
}
