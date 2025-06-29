using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BattleAICooperativeCompl : UActorCompBaseCS
{
	private BUC_BattleAICooperativeData BattleAICooperativeData;

	private IBUC_PointSetsData PointSetData;

	private IBUC_FollowPartnerData FollowPartnerData;

	public override void OnAttach()
	{
		BattleAICooperativeData = RequireWritableData<BUC_BattleAICooperativeData>();
		PointSetData = RequireReadOnlyData<IBUC_PointSetsData, BUC_PointSetsData>();
		FollowPartnerData = RequireReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>();
		base.BUSEventCollection.Evt_RegisterBattleSC += new Del_Void_String(RegisterSC);
		base.BUSEventCollection.Evt_HandleBattleMessage += new Del_Void_FGameplayTag(HandleBattleMessage);
		base.BUSEventCollection.Evt_MulticastCachedPointSet += new Del_Void_Int(OnMulticastCachedPointSet);
		if (BattleAICooperativeData.SpecificEventListen.Contains(EBattleCoopReason.UnitDead))
		{
			base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		}
	}

	public override void OnBeginPlay()
	{
		RegisterSC(BattleAICooperativeData.BattleSC_GUID);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (!string.IsNullOrEmpty(BattleAICooperativeData.BattleSC_GUID))
		{
			base.BGSEventCollection?.Evt_BGS_UnRegistBattleSCMember.Invoke(Owner, BattleAICooperativeData.BattleSC_GUID);
		}
	}

	private void RegisterSC(string BattleSCGUID)
	{
		BattleAICooperativeData.BattleSC_GUID = BattleSCGUID;
		if (!string.IsNullOrEmpty(BattleAICooperativeData.BattleSC_GUID))
		{
			base.BGSEventCollection?.Evt_BGS_RegisterBattleSCMember.Invoke(Owner, BattleAICooperativeData.BattleSC_GUID);
		}
	}

	private void HandleBattleMessage(FGameplayTag Message)
	{
		if (!FollowPartnerData.IsFollowPartnerUnit && !FollowPartnerData.IsAssociationUnit)
		{
			base.BUSEventCollection?.Evt_TriggerFsmEvent.Invoke(Message);
		}
		if (!string.IsNullOrEmpty(BattleAICooperativeData.BattleSC_GUID))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.CSGDebug, "<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</><effect>【CSGDEBUG】</><action> 发送协同作战信息 </><effectnum>" + Message.TagName.PlainName + "</>");
			}
			base.BGSEventCollection?.Evt_BGS_BattleSCReceiveMessage.Invoke(BattleAICooperativeData.BattleSC_GUID, Owner, Message, EDistributionType.SenderToOtherMembers);
		}
	}

	private void OnMulticastCachedPointSet(int RequestID)
	{
		if (!string.IsNullOrEmpty(BattleAICooperativeData.BattleSC_GUID) && PointSetData.PointQueneMap.TryGetValue(RequestID, out var value))
		{
			base.BGSEventCollection?.Evt_BGS_BattleSCMulticastCachedPointSet.Invoke(BattleAICooperativeData.BattleSC_GUID, Owner, RequestID, new List<FVector>(value));
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		HandleBattleMessageByReason(EBattleCoopReason.UnitDead);
	}

	private void HandleBattleMessageByReason(EBattleCoopReason BattleCoopReason)
	{
		if (!string.IsNullOrEmpty(BattleAICooperativeData.BattleSC_GUID))
		{
			base.BGSEventCollection?.Evt_BGS_BattleSCReceiveMessageByReason.Invoke(BattleAICooperativeData.BattleSC_GUID, Owner, BattleCoopReason);
		}
	}
}
