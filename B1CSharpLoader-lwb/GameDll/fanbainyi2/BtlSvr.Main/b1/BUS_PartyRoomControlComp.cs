using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_PartyRoomControlComp : UActorCompBaseCS
{
	private BUC_PartyRoomControlData PartyRoomControlData;

	public override void OnAttach()
	{
		PartyRoomControlData = RequireWritableData<BUC_PartyRoomControlData>();
		base.BUSEventCollection.Evt_CreateNewPlayerForPartyRoom += new Del_Void_String(OnRoomMemberJoin);
		base.BUSEventCollection.Evt_InputMoveForward += new Del_InputMove(OnInputMove);
		base.BUSEventCollection.Evt_InputMoveRight += new Del_InputMove(OnInputMove);
		base.BUSEventCollection.Evt_BindMemberId += new Del_Void_String(OnBindMemberId);
		base.BUSEventCollection.Evt_ExitParty += new Del_Void(OnExitPartyRoom);
		base.BUSEventCollection.Evt_RoomMemberExit += new Del_Void_String(OnRoomMemberExit);
		GSGameplayCVar.CVar_UROEnable.SetInt(0);
	}

	private void OnRoomMemberJoin(string UniqueNetId)
	{
		UGameplayStatics.GetAllActorsOfClassWithTag(GetOwner(), UClass.GetClass<ABGUCharacter>(), B1GlobalFNames.LHCAITag, out var OutActors);
		if (OutActors.Count != 0)
		{
			AActor targetAIPlayer = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(GetOwner().World, OutActors[0].GetClass());
			AActor aActor = RecordPlayerAI(UniqueNetId, targetAIPlayer);
			BGP_AIPlayerControllerCS bGP_AIPlayerControllerCS = aActor.GetInstigatorController() as BGP_AIPlayerControllerCS;
			if (bGP_AIPlayerControllerCS != null)
			{
				bGP_AIPlayerControllerCS.SetUniqueNetIdStr(UniqueNetId);
			}
			BUS_EventCollectionCS.Get(aActor).Evt_PerceptionFindTarget.Invoke(null);
		}
	}

	private AActor RecordPlayerAI(string UniqueNetId, AActor TargetAIPlayer)
	{
		TargetAIPlayer.SetActorScale3D(FVector.OneVector);
		PartyRoomControlData.PlayerAIDict.Add(UniqueNetId, TargetAIPlayer);
		return TargetAIPlayer;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PartyRoomControlData.MsgDelay > 0f)
		{
			PartyRoomControlData.MsgDelay -= DeltaTime;
		}
	}

	private void OnInputMove(float Value)
	{
		if (Value != 0f && PartyRoomControlData.MsgDelay <= 0f)
		{
			PartyRoomControlData.MsgDelay = 0.3f;
			base.BUSEventCollection.Evt_RepPlayerLoc.Invoke(GetOwner().GetActorLocation(), PartyRoomControlData.SelfMemberId);
		}
	}

	private void OnRoomMemberExit(string UniqueNetId)
	{
		if (PartyRoomControlData.PlayerAIDict.TryGetValue(UniqueNetId, out var value))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(value);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitDead.Invoke(value, EDeadReason.OnlyDestroyUnit);
			}
			value?.SetActorScale3D(FVector.ZeroVector);
			PartyRoomControlData.PlayerAIDict.Remove(UniqueNetId);
		}
	}

	private void OnExitPartyRoom()
	{
		foreach (KeyValuePair<string, AActor> item in PartyRoomControlData.PlayerAIDict)
		{
			AActor value = item.Value;
			if (value != null)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(value);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_UnitDead.Invoke(value, EDeadReason.OnlyDestroyUnit);
				}
				value?.SetActorScale3D(FVector.ZeroVector);
			}
		}
		PartyRoomControlData.ReSet();
	}

	private void OnBindMemberId(string MemberId)
	{
		PartyRoomControlData.SelfMemberId = MemberId;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_CreateNewPlayerForPartyRoom -= new Del_Void_String(OnRoomMemberJoin);
			base.BUSEventCollection.Evt_InputMoveForward -= new Del_InputMove(OnInputMove);
			base.BUSEventCollection.Evt_InputMoveRight -= new Del_InputMove(OnInputMove);
			base.BUSEventCollection.Evt_BindMemberId -= new Del_Void_String(OnBindMemberId);
			base.BUSEventCollection.Evt_ExitParty -= new Del_Void(OnExitPartyRoom);
			base.BUSEventCollection.Evt_RoomMemberExit -= new Del_Void_String(OnRoomMemberExit);
		}
		GSGameplayCVar.CVar_UROEnable.SetInt(1);
	}
}
