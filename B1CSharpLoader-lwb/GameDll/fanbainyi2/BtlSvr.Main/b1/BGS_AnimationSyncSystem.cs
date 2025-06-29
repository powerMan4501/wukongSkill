using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_AnimationSyncSystem : GameStateSystemBase
{
	private APlayerController PlayerController;

	private BGC_AnimationSyncData AnimationSyncData { get; set; }

	public override void OnAttach()
	{
		AnimationSyncData = RequireWritableData<BGC_AnimationSyncData>();
		base.BGSEventCollection.Evt_BGS_BeginAnimationSyncPreCheck += new Del_BGS_BeginAnimationSyncPreCheck(OnBeginAnimationSyncPreCheck);
		base.BGSEventCollection.Evt_BGS_EndAnimationSyncPreCheck += new Del_Void_Actor(OnEndAnimationSyncPreCheck);
		base.BGSEventCollection.Evt_BGS_BeginSyncAnimation += new Del_BGS_BeginSyncAnimation(OnBeginSyncAnimation);
		base.BGSEventCollection.Evt_BGS_EndSyncAnimation += new Del_BGS_EndSyncAnimation(OnEndSyncAnimation);
		base.BGSEventCollection.Evt_BGS_BeginInteractSyncAnimation += new Del_BGS_BeginInteractSyncAnimation(OnBeginInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation += new Del_Void_ActorBool(OnEndInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_NotifyHostToEndInteractSyncAnimation += new Del_Void_Actor(OnNotifyHostToEndInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_RemoveInteractParticipants += new Del_Void_Actor(OnRemoveInteractParticipants);
		base.BGSEventCollection.Evt_BGS_ProcessDeathInAnimationSync += new Del_BGS_ProcessDeathInAnimationSync(OnProcessDeathInAnimationSync);
		base.BGSEventCollection.Evt_BGS_SetMoveCameraSpringArmRotToNearestAfterAS += new Del_Void_Bool(OnSetMoveCameraSpringArmRotToNearestAfterAS);
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_BeginAnimationSyncPreCheck -= new Del_BGS_BeginAnimationSyncPreCheck(OnBeginAnimationSyncPreCheck);
		base.BGSEventCollection.Evt_BGS_EndAnimationSyncPreCheck -= new Del_Void_Actor(OnEndAnimationSyncPreCheck);
		base.BGSEventCollection.Evt_BGS_BeginSyncAnimation -= new Del_BGS_BeginSyncAnimation(OnBeginSyncAnimation);
		base.BGSEventCollection.Evt_BGS_EndSyncAnimation -= new Del_BGS_EndSyncAnimation(OnEndSyncAnimation);
		base.BGSEventCollection.Evt_BGS_BeginInteractSyncAnimation -= new Del_BGS_BeginInteractSyncAnimation(OnBeginInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation -= new Del_Void_ActorBool(OnEndInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_NotifyHostToEndInteractSyncAnimation -= new Del_Void_Actor(OnNotifyHostToEndInteractSyncAnimation);
		base.BGSEventCollection.Evt_BGS_RemoveInteractParticipants -= new Del_Void_Actor(OnRemoveInteractParticipants);
		base.BGSEventCollection.Evt_BGS_ProcessDeathInAnimationSync -= new Del_BGS_ProcessDeathInAnimationSync(OnProcessDeathInAnimationSync);
		base.BGSEventCollection.Evt_BGS_SetMoveCameraSpringArmRotToNearestAfterAS -= new Del_Void_Bool(OnSetMoveCameraSpringArmRotToNearestAfterAS);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		foreach (DetectionData pendingDetection in AnimationSyncData.PendingDetectionList)
		{
			if (!pendingDetection.bSuccess)
			{
				BeginDetection(pendingDetection);
			}
		}
	}

	private void OnBeginAnimationSyncPreCheck(AActor Host, bool bForceSuccess, Dictionary<FName, float> DetectionConfig, FName JumpToSectionName, bool bEnableDebugDraw, UAnimMontage AnimationSyncMontage)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Host, EBGUSimpleState.InAnimationSyncing))
		{
			return;
		}
		AActor aActor = null;
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetSkillBaseTargetInfo(Host);
		if (unitLockTargetInfo != null && unitLockTargetInfo.LockTargetActor != null)
		{
			aActor = unitLockTargetInfo.LockTargetActor;
		}
		if (aActor == null || BGUFunctionLibraryCS.BGUIsUnitDead(aActor))
		{
			OnAnimationSyncFailed(Host, JumpToSectionName);
			return;
		}
		if (bForceSuccess)
		{
			OnPreCheckSuccess(Host, aActor, AnimationSyncMontage);
			return;
		}
		AnimationSyncData.AddData(Host, aActor, DetectionConfig, JumpToSectionName, bEnableDebugDraw, AnimationSyncMontage);
		foreach (DetectionData pendingDetection in AnimationSyncData.PendingDetectionList)
		{
			BeginDetection(pendingDetection);
		}
	}

	private void OnEndAnimationSyncPreCheck(AActor Host)
	{
		for (int num = AnimationSyncData.PendingDetectionList.Count - 1; num >= 0; num--)
		{
			DetectionData detectionData = AnimationSyncData.PendingDetectionList[num];
			if (!(detectionData.Host != Host))
			{
				if (!detectionData.bSuccess)
				{
					BeginDetection(detectionData);
				}
				if (detectionData.bSuccess && BGUFunctionLibraryCS.IsClonedWukong(detectionData.GuestCandidate))
				{
					detectionData.bSuccess = false;
				}
				if (!detectionData.bSuccess)
				{
					OnAnimationSyncFailed(detectionData.Host, detectionData.JumpToSectionName);
				}
				AnimationSyncData.PendingDetectionList.RemoveAt(num);
			}
		}
	}

	private void OnBeginSyncAnimation(AActor Host, UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bForceSyncDummyMeshAnimation, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration, int AnimationSyncMontageInstanceID)
	{
		AActor guestByHost = AnimationSyncData.GetGuestByHost(Host);
		if (BGU_DataUtil.GetActorResID(Host) == 5005 && guestByHost == null)
		{
			BUS_EventCollectionCS.Get(Host)?.Evt_NotifyEndSyncAnimationOnHost.Invoke(AnimationSyncData.PreAnimationSyncStateHostBuffList, AnimationSyncData.AnimationSyncStateHostBuffList);
			AnimationSyncData.RemoveParticipants(Host);
		}
		else if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(guestByHost, EBGUSimpleState.InAnimationSyncing))
		{
			BUS_EventCollectionCS.Get(guestByHost)?.Evt_NotifyReactToAnimationSyncOnGuest.Invoke();
			BUS_EventCollectionCS.Get(guestByHost)?.Evt_NotifyBeginSyncAnimationOnGuest.Invoke(AnimationSyncData.PreAnimationSyncStateGuestBuffList, TotalDuration, Host, NotifyBeginTime);
			BUS_EventCollectionCS.Get(Host)?.Evt_NotifyBeginSyncAnimationOnHost.Invoke(AnimationSyncData.PreAnimationSyncStateHostBuffList, GuestMontage, bFoundHostSyncPointOnDummyMesh, SelfSyncPointOnHost, TargetSyncPointOnHost, SelfSyncPointOnGuest, bForceSyncDummyMeshAnimation, bEnableDebugDraw, NotifyBeginTime, TotalDuration, AnimationSyncMontageInstanceID);
		}
	}

	private void OnEndSyncAnimation(AActor Actor, bool bHostOrGuest)
	{
		AActor aActor = (bHostOrGuest ? Actor : AnimationSyncData.GetHostByGuest(Actor));
		BUS_EventCollectionCS.Get(bHostOrGuest ? AnimationSyncData.GetGuestByHost(Actor) : Actor)?.Evt_NotifyEndSyncAnimationOnGuest.Invoke(AnimationSyncData.PreAnimationSyncStateGuestBuffList, AnimationSyncData.AnimationSyncStateGuestBuffList);
		BUS_EventCollectionCS.Get(aActor)?.Evt_NotifyEndSyncAnimationOnHost.Invoke(AnimationSyncData.PreAnimationSyncStateHostBuffList, AnimationSyncData.AnimationSyncStateHostBuffList);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(PlayerController.GetControlledPawn());
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SetSyncCamera.Invoke(null, null, FName.None);
			if (AnimationSyncData.bMoveCameraSpringArmRotToNearestAfterAS)
			{
				bUS_GSEventCollection.Evt_MoveCameraSpringArmRot2Nearest.Invoke();
			}
		}
		if (aActor != null)
		{
			AnimationSyncData.RemoveParticipants(aActor);
		}
	}

	private void OnBeginInteractSyncAnimation(AActor Host, AActor Guest, in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		if (!Host.IsNullOrDestroyed() && !Guest.IsNullOrDestroyed() && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Guest, EBGUSimpleState.InInteractAnimationSyncing))
		{
			AnimationSyncData.AddInteractParticipants(Host, Guest);
			BUS_EventCollectionCS.Get(Guest)?.Evt_NotifyBeginInteractSyncAnimationOnGuest.Invoke(Host);
			BUS_EventCollectionCS.Get(Host)?.Evt_NotifyBeginInteractSyncAnimationOnHost.Invoke(Guest, AttachSocketOnHost, AttachSocketOnDummyMesh, DummyMeshAnimation);
		}
	}

	private void OnEndInteractSyncAnimation(AActor Host, bool bFindFloor)
	{
		AActor guestByHostForInteract = AnimationSyncData.GetGuestByHostForInteract(Host);
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(guestByHostForInteract, EBGUSimpleState.InInteractAnimationSyncing))
		{
			BUS_EventCollectionCS.Get(guestByHostForInteract)?.Evt_NotifyEndInteractSyncAnimationOnGuest.Invoke(bFindFloor);
		}
	}

	private void OnNotifyHostToEndInteractSyncAnimation(AActor Guest)
	{
		AActor hostByGuestForInteract = AnimationSyncData.GetHostByGuestForInteract(Guest);
		BUS_EventCollectionCS.Get(hostByGuestForInteract)?.Evt_NotifyEndInteractSyncAnimationOnHost.Invoke();
		OnRemoveInteractParticipants(hostByGuestForInteract);
	}

	private void OnRemoveInteractParticipants(AActor Host)
	{
		AnimationSyncData.RemoveInteractParticipants(Host);
	}

	private void OnProcessDeathInAnimationSync(AActor Host, Dictionary<int, UAnimMontage> DeathMontageList, float TotalDuration)
	{
		AActor guestByHost = AnimationSyncData.GetGuestByHost(Host);
		if (!(guestByHost == null))
		{
			int actorResID = BGU_DataUtil.GetActorResID(guestByHost);
			DeathMontageList.TryGetValue(actorResID, out var value);
			BUS_EventCollectionCS.Get(guestByHost)?.Evt_ProcessPendingDeathInASS.Invoke(value, TotalDuration);
		}
	}

	private void OnSetMoveCameraSpringArmRotToNearestAfterAS(bool bMoveCameraSpringArmRotToNearestAfterAS)
	{
		AnimationSyncData.bMoveCameraSpringArmRotToNearestAfterAS = bMoveCameraSpringArmRotToNearestAfterAS;
	}

	private void OnAnimationSyncFailed(AActor Host, FName JumpToSectionName)
	{
		if (JumpToSectionName != FName.None)
		{
			BUS_EventCollectionCS.Get(Host)?.Evt_MontageSetNextSection.Invoke(JumpToSectionName);
		}
	}

	private void BeginDetection(DetectionData Data)
	{
		if (!CheckTargetState(Data.Host, Data.GuestCandidate))
		{
			Data.bSuccess = false;
		}
		else
		{
			DoSphereOverlap(Data);
		}
	}

	private bool CheckTargetState(AActor Host, AActor GuestCandidate)
	{
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Host);
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(GuestCandidate);
		IBUC_UnitStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Host);
		IBUC_UnitStateData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(GuestCandidate);
		if (readOnlyData == null || readOnlyData2 == null || unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null)
		{
			return false;
		}
		if (readOnlyData.HasSimpleState(EBGUSimpleState.Immobilizing) || readOnlyData.HasSimpleState(EBGUSimpleState.Frozen) || unPersistentReadOnlyData.HasState(EBGUUnitState.Beatback) || unPersistentReadOnlyData.HasState(EBGUUnitState.Dead))
		{
			return false;
		}
		if (readOnlyData2.HasSimpleState(EBGUSimpleState.ImmueAnimationSyncing) || readOnlyData2.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || unPersistentReadOnlyData2.HasState(EBGUUnitState.Dead))
		{
			return false;
		}
		return true;
	}

	private void DoSphereOverlap(DetectionData Data)
	{
		foreach (KeyValuePair<FName, float> item in Data.DetectionConfig)
		{
			FName key = item.Key;
			float value = item.Value;
			BGUCharacterCS bGUCharacterCS = Data.Host as BGUCharacterCS;
			if (bGUCharacterCS == null || bGUCharacterCS.IsNullOrDestroyed())
			{
				continue;
			}
			FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(key);
			if (!Data.bSuccess)
			{
				List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery3 };
				List<AActor> actorsToIgnore = new List<AActor> { bGUCharacterCS };
				List<AActor> OutActors;
				bool num = USystemLibrary.SphereOverlapActors(bGUCharacterCS, socketLocation, value, objectTypes, UClass.GetClass<BGUCharacterCS>(), actorsToIgnore, out OutActors);
				AActor guestCandidate = Data.GuestCandidate;
				if (num && OutActors.Contains(guestCandidate))
				{
					Data.bSuccess = true;
					if (BGUFunctionLibraryCS.IsClonedWukong(guestCandidate))
					{
						if (Data.bEnableDebugDraw)
						{
							USystemLibrary.DrawDebugSphere(bGUCharacterCS, socketLocation, value, 32, FLinearColor.Red, 1f, 2f);
						}
						break;
					}
					OnPreCheckSuccess(bGUCharacterCS, guestCandidate, Data.AnimationSyncMontage);
					if (Data.bEnableDebugDraw)
					{
						USystemLibrary.DrawDebugSphere(bGUCharacterCS, socketLocation, value, 32, FLinearColor.Red, 1f, 2f);
					}
					break;
				}
			}
			if (Data.bEnableDebugDraw)
			{
				USystemLibrary.DrawDebugSphere(bGUCharacterCS, socketLocation, value, 32, FLinearColor.Yellow, 1f, 2f);
			}
		}
	}

	private void OnPreCheckSuccess(AActor Host, AActor GuestCandidate, UAnimMontage AnimationSyncMontage)
	{
		EAnimationSyncCombination combination = ((BGU_DataUtil.GetActorResID(GuestCandidate) != 10) ? EAnimationSyncCombination.Monster2Monster : EAnimationSyncCombination.Monster2Wukong);
		NotifyEnterPreAnimationSyncingState(Host, GuestCandidate, combination);
		NotifyEnterAnimationSyncingState(Host, GuestCandidate, combination, AnimationSyncMontage);
		AnimationSyncData.AddParticipants(Host, GuestCandidate);
	}

	private BGWDataAsset_AnimationSyncStateConfig GetAnimationSyncStateConfig(EAnimationSyncCombination Combination)
	{
		BGWDataAsset_AnimationSyncStateConfig result = null;
		switch (Combination)
		{
		case EAnimationSyncCombination.Monster2Wukong:
			result = BGW_PreloadAssetMgr.Get(Owner).AnimationSyncStateMonster2WukongConfig;
			break;
		case EAnimationSyncCombination.Monster2Monster:
			result = BGW_PreloadAssetMgr.Get(Owner).AnimationSyncStateMonster2MonsterConfig;
			break;
		}
		return result;
	}

	private void NotifyEnterPreAnimationSyncingState(AActor Host, AActor Guest, EAnimationSyncCombination Combination)
	{
		if (AnimationSyncData.PreAnimationSyncStateHostBuffList.Count == 0)
		{
			BGWDataAsset_AnimationSyncStateConfig animationSyncStateConfig = GetAnimationSyncStateConfig(Combination);
			if (animationSyncStateConfig == null)
			{
				return;
			}
			if (animationSyncStateConfig.PreState_bHostCantBeDead)
			{
				AnimationSyncData.PreAnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.CANT_BE_DEAD);
			}
		}
		if (AnimationSyncData.PreAnimationSyncStateGuestBuffList.Count == 0)
		{
			BGWDataAsset_AnimationSyncStateConfig animationSyncStateConfig2 = GetAnimationSyncStateConfig(Combination);
			if (animationSyncStateConfig2 == null)
			{
				return;
			}
			if (animationSyncStateConfig2.PreState_bGuestCantBeDead)
			{
				AnimationSyncData.PreAnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.CANT_BE_DEAD);
			}
			int actorResID = BGU_DataUtil.GetActorResID(Guest);
			if (animationSyncStateConfig2.PreState_bIgnoreAllInput || actorResID == 50)
			{
				AnimationSyncData.PreAnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IGNORE_ALL_INPUT);
			}
		}
		BUS_EventCollectionCS.Get(Host)?.Evt_NotifyEnterPreAnimationSyncingStateOnHost.Invoke(Guest, AnimationSyncData.PreAnimationSyncStateHostBuffList);
		BUS_EventCollectionCS.Get(Guest)?.Evt_NotifyEnterPreAnimationSyncingStateOnGuest.Invoke(Host, AnimationSyncData.PreAnimationSyncStateGuestBuffList);
	}

	private void NotifyEnterAnimationSyncingState(AActor Host, AActor Guest, EAnimationSyncCombination Combination, UAnimMontage AnimationSyncMontage)
	{
		if (AnimationSyncData.AnimationSyncStateHostBuffList.Count == 0)
		{
			BGWDataAsset_AnimationSyncStateConfig animationSyncStateConfig = GetAnimationSyncStateConfig(Combination);
			if (animationSyncStateConfig == null)
			{
				return;
			}
			if (animationSyncStateConfig.InState_bHostCantBeDead)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.CANT_BE_DEAD);
			}
			if (animationSyncStateConfig.InState_bBothImmuneStiff)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_STIFF);
			}
			if (animationSyncStateConfig.InState_bBothImmuneImmobilizing)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_IMMOBILIZING);
			}
			if (animationSyncStateConfig.InState_bHostImmuneFrozen)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_FROZEN);
			}
			if (animationSyncStateConfig.InState_bHostImmuneBurn)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_BURN);
			}
			if (animationSyncStateConfig.InState_bHostImmunePoison)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_POISON);
			}
			if (animationSyncStateConfig.InState_bHostImmuneThunder)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_THUNDER);
			}
			if (animationSyncStateConfig.InState_bHostImmuneDamage)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_DAMAGE);
			}
			if (animationSyncStateConfig.InState_bHostImmuneDmgExceptElementDmg)
			{
				AnimationSyncData.AnimationSyncStateHostBuffList.Add(AnimationSyncBuffDef.IMMUNE_DMG_EXCEPT_ELEMENT_DMG);
			}
		}
		if (AnimationSyncData.AnimationSyncStateGuestBuffList.Count == 0)
		{
			BGWDataAsset_AnimationSyncStateConfig animationSyncStateConfig2 = GetAnimationSyncStateConfig(Combination);
			if (animationSyncStateConfig2 == null)
			{
				return;
			}
			if (animationSyncStateConfig2.InState_bGuestCantBeDead)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.CANT_BE_DEAD);
			}
			if (animationSyncStateConfig2.InState_bBothImmuneStiff)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_STIFF);
			}
			if (animationSyncStateConfig2.InState_bBothImmuneImmobilizing)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_IMMOBILIZING);
			}
			if (animationSyncStateConfig2.InState_bGuestImmuneFrozen)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_FROZEN);
			}
			if (animationSyncStateConfig2.InState_bGuestImmuneBurn)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_BURN);
			}
			if (animationSyncStateConfig2.InState_bGuestImmunePoison)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_POISON);
			}
			if (animationSyncStateConfig2.InState_bGuestImmuneThunder)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IMMUNE_THUNDER);
			}
			int actorResID = BGU_DataUtil.GetActorResID(Guest);
			if (animationSyncStateConfig2.bIgnoreAllInput || actorResID == 50)
			{
				AnimationSyncData.AnimationSyncStateGuestBuffList.Add(AnimationSyncBuffDef.IGNORE_ALL_INPUT);
			}
		}
		BUS_EventCollectionCS.Get(Host)?.Evt_NotifyEnterAnimationSyncingStateOnHost.Invoke(AnimationSyncData.AnimationSyncStateHostBuffList, AnimationSyncMontage);
		BUS_EventCollectionCS.Get(Guest)?.Evt_NotifyEnterAnimationSyncingStateOnGuest.Invoke(AnimationSyncData.AnimationSyncStateGuestBuffList);
	}
}
