using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_BattleSupercomputingCenterSystem : GameStateSystemBase
{
	private BGC_MessageDistributionCenterData MDCData;

	public override void OnAttach()
	{
		base.OnAttach();
		MDCData = RequireWritableData<BGC_MessageDistributionCenterData>();
		base.BGSEventCollection.Evt_BGS_RegisterBattleSCMember += new Del_Void_ActorString(RegistNewMember);
		base.BGSEventCollection.Evt_BGS_UnRegistBattleSCMember += new Del_Void_ActorString(UnRegistMember);
		base.BGSEventCollection.Evt_BGS_BattleSCReceiveMessage += new Del_BattleSCReceiveMessage(ReceiveMessage);
		base.BGSEventCollection.Evt_BGS_BattleSCReceiveMessageByReason += new Del_BattleSCReceiveMessageByReason(ReceiveMessageByReason);
		base.BGSEventCollection.Evt_BGS_BattleSCMulticastCachedPointSet += new Del_BattleSCMulticastCachedPointSet(OnMulticastCachedPointSet);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BGWDataAsset_BattleSCConfig battleSCConfigDataAsset = BGW_PreloadAssetMgr.Get(this).BattleSCConfigDataAsset;
		if (!(battleSCConfigDataAsset != null) || battleSCConfigDataAsset.BattleSCConfigMap == null || battleSCConfigDataAsset.BattleSCConfigMap.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<FGameplayTag, FBattleSCInfo> item in battleSCConfigDataAsset.BattleSCConfigMap)
		{
			string plainName = item.Key.TagName.PlainName;
			Dictionary<FGameplayTag, FGameplayTag> battleEventMap = item.Value.BattleEventMap;
			if (MDCData.BattleSCInfoDict.TryGetValue(plainName, out var value))
			{
				continue;
			}
			value = new BattleSCInfo();
			foreach (KeyValuePair<FGameplayTag, FGameplayTag> item2 in battleEventMap)
			{
				value.BattleEventMap.Add(item2.Key, item2.Value);
			}
			MDCData.BattleSCInfoDict.Add(plainName, value);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_RegisterBattleSCMember -= new Del_Void_ActorString(RegistNewMember);
		base.BGSEventCollection.Evt_BGS_UnRegistBattleSCMember -= new Del_Void_ActorString(UnRegistMember);
		base.BGSEventCollection.Evt_BGS_BattleSCReceiveMessage -= new Del_BattleSCReceiveMessage(ReceiveMessage);
		base.BGSEventCollection.Evt_BGS_BattleSCReceiveMessageByReason -= new Del_BattleSCReceiveMessageByReason(ReceiveMessageByReason);
		base.BGSEventCollection.Evt_BGS_BattleSCMulticastCachedPointSet -= new Del_BattleSCMulticastCachedPointSet(OnMulticastCachedPointSet);
	}

	private void ReceiveMessage(string BattleSC_GUID, AActor Sender, FGameplayTag Message, EDistributionType DistributionType)
	{
		if (!MDCData.BattleSCInfoDict.TryGetValue(BattleSC_GUID, out var value))
		{
			return;
		}
		if (value.BattleEventMap.TryGetValue(Message, out var value2))
		{
			Message = value2;
		}
		foreach (AActor member in value.MemberList)
		{
			if (!member.IsNullOrDestroyed() && (DistributionType != EDistributionType.SenderToOtherMembers || !(member == Sender)) && !BGUFunctionLibraryCS.BGUHasUnitState(member, EBGUUnitState.Dead))
			{
				BUS_EventCollectionCS.Get(member)?.Evt_TriggerFsmEvent.Invoke(Message);
			}
		}
	}

	private void ReceiveMessageByReason(string BattleSC_GUID, AActor Sender, EBattleCoopReason BattleCoopReason)
	{
		if (!MDCData.BattleSCInfoDict.TryGetValue(BattleSC_GUID, out var value) || BattleCoopReason != EBattleCoopReason.UnitDead)
		{
			return;
		}
		FGameplayTag partnerDead = BGW_FlowUtils.FsmEventTag_Coop.PartnerDead;
		foreach (AActor member in value.MemberList)
		{
			if (!(member == Sender) && !BGUFunctionLibraryCS.BGUHasUnitState(member, EBGUUnitState.Dead))
			{
				BUS_EventCollectionCS.Get(member)?.Evt_TriggerFsmEvent.Invoke(partnerDead);
			}
		}
	}

	private void RegistNewMember(AActor NewMember, string BattleSC_GUID)
	{
		if (!NewMember.IsNullOrDestroyed() && !string.IsNullOrEmpty(BattleSC_GUID))
		{
			if (!MDCData.BattleSCInfoDict.TryGetValue(BattleSC_GUID, out var value))
			{
				MDCData.BattleSCInfoDict.Add(BattleSC_GUID, new BattleSCInfo());
				MDCData.BattleSCInfoDict[BattleSC_GUID].MemberList.Add(NewMember);
			}
			else if (!value.MemberList.Contains(NewMember))
			{
				value.MemberList.Add(NewMember);
			}
		}
	}

	private void UnRegistMember(AActor Member, string BattleSC_GUID)
	{
		if (!Member.IsNullOrDestroyed() && !string.IsNullOrEmpty(BattleSC_GUID) && MDCData.BattleSCInfoDict.TryGetValue(BattleSC_GUID, out var value) && value.MemberList.Contains(Member))
		{
			value.MemberList.Remove(Member);
		}
	}

	private void OnMulticastCachedPointSet(string BattleSC_GUID, AActor Sender, int RequestID, List<FVector> PointSet)
	{
		if (!MDCData.BattleSCInfoDict.TryGetValue(BattleSC_GUID, out var value))
		{
			return;
		}
		foreach (AActor member in value.MemberList)
		{
			BUS_EventCollectionCS.Get(member)?.Evt_AddPointsToQuene.Invoke(RequestID, PointSet, bClearTheReqQuene: true);
		}
	}
}
