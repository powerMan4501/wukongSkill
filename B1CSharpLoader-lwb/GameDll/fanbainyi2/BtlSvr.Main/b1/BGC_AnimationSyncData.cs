using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_AnimationSyncData : IBGC_AnimationSyncData, IPersistentECSData
{
	public List<DetectionData> PendingDetectionList = new List<DetectionData>();

	public Dictionary<TWeakObject<AActor>, TWeakObject<AActor>> Participants = new Dictionary<TWeakObject<AActor>, TWeakObject<AActor>>();

	public Dictionary<TWeakObject<AActor>, TWeakObject<AActor>> InteractParticipants = new Dictionary<TWeakObject<AActor>, TWeakObject<AActor>>();

	public List<int> PreAnimationSyncStateHostBuffList = new List<int>();

	public List<int> PreAnimationSyncStateGuestBuffList = new List<int>();

	public List<int> AnimationSyncStateHostBuffList = new List<int>();

	public List<int> AnimationSyncStateGuestBuffList = new List<int>();

	public bool bMoveCameraSpringArmRotToNearestAfterAS;

	public bool IsAnyUnitInAnimationSyncing(bool bIncludeInteractAnimationSyncing = false)
	{
		if (bIncludeInteractAnimationSyncing)
		{
			if (Participants.Count <= 0)
			{
				return InteractParticipants.Count > 0;
			}
			return true;
		}
		return Participants.Count > 0;
	}

	public bool IsPlayerInAnimationSyncing(UObject Context)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context);
		if (firstLocalPlayerController == null)
		{
			return false;
		}
		return BGUFunctionLibraryCS.BGUHasUnitSimpleState(firstLocalPlayerController.GetControlledPawn(), EBGUSimpleState.InAnimationSyncing);
	}

	public bool IsActorInAnimationSyncing(AActor Actor)
	{
		return BGUFunctionLibraryCS.BGUHasUnitSimpleState(Actor, EBGUSimpleState.InAnimationSyncing);
	}

	public void AddData(AActor Host, AActor GuestCandidate, Dictionary<FName, float> DetectionConfig, FName JumpToSectionName, bool bEnableDebugDraw, UAnimMontage AnimationSyncMontage)
	{
		DetectionData item = new DetectionData
		{
			Host = Host,
			GuestCandidate = GuestCandidate,
			DetectionConfig = DetectionConfig,
			JumpToSectionName = JumpToSectionName,
			bEnableDebugDraw = bEnableDebugDraw,
			AnimationSyncMontage = AnimationSyncMontage
		};
		PendingDetectionList.Add(item);
	}

	public void AddParticipants(AActor Host, AActor Guest)
	{
		Participants[new TWeakObject<AActor>(Host)] = new TWeakObject<AActor>(Guest);
	}

	public void RemoveParticipants(AActor Host)
	{
		Participants.Remove(new TWeakObject<AActor>(Host));
	}

	public AActor GetGuestByHost(AActor Host)
	{
		if (Participants.TryGetValue(new TWeakObject<AActor>(Host), out var value) && value.IsValid())
		{
			return value.Value;
		}
		return null;
	}

	public AActor GetHostByGuest(AActor Guest)
	{
		foreach (KeyValuePair<TWeakObject<AActor>, TWeakObject<AActor>> participant in Participants)
		{
			if (participant.Value == new TWeakObject<AActor>(Guest))
			{
				return participant.Key.Value;
			}
		}
		return null;
	}

	public void AddInteractParticipants(AActor Host, AActor Guest)
	{
		InteractParticipants[new TWeakObject<AActor>(Host)] = new TWeakObject<AActor>(Guest);
	}

	public void RemoveInteractParticipants(AActor Host)
	{
		InteractParticipants.Remove(new TWeakObject<AActor>(Host));
	}

	public AActor GetGuestByHostForInteract(AActor Host)
	{
		if (InteractParticipants.TryGetValue(new TWeakObject<AActor>(Host), out var value) && value.IsValid())
		{
			return value.Value;
		}
		return null;
	}

	public AActor GetHostByGuestForInteract(AActor Guest)
	{
		foreach (KeyValuePair<TWeakObject<AActor>, TWeakObject<AActor>> interactParticipant in InteractParticipants)
		{
			if (interactParticipant.Value == new TWeakObject<AActor>(Guest))
			{
				return interactParticipant.Key.Value;
			}
		}
		return null;
	}
}
