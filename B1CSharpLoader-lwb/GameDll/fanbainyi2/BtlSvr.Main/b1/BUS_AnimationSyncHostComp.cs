using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AnimationSyncHostComp : UActorCompBaseCS
{
	private BUC_AnimationSyncHostData AnimationSyncHostData;

	private IBUC_MovementData MovementData;

	private IBUC_BuffData BuffData;

	public override void OnAttach()
	{
		AnimationSyncHostData = RequireWritableData<BUC_AnimationSyncHostData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		base.BUSEventCollection.Evt_NotifyEnterPreAnimationSyncingStateOnHost += new Del_NotifyEnterPreAnimationSyncingState(OnEnterPreAnimationSyncingStateOnHost);
		base.BUSEventCollection.Evt_NotifyEnterAnimationSyncingStateOnHost += new Del_NotifyEnterAnimationSyncingStateOnHost(OnEnterAnimationSyncingStateOnHost);
		base.BUSEventCollection.Evt_NotifyBeginSyncAnimationOnHost += new Del_NotifyBeginSyncAnimationOnHost(OnBeginSyncAnimationOnHost);
		base.BUSEventCollection.Evt_NotifyEndSyncAnimationOnHost += new Del_NotifyEndSyncAnimation(OnEndSyncAnimationOnHost);
		base.BUSEventCollection.Evt_NotifyBeginInteractSyncAnimationOnHost += new Del_NotifyBeginInteractSyncAnimationOnHost(OnBeginInteractSyncAnimationOnHost);
		base.BUSEventCollection.Evt_NotifyEndInteractSyncAnimationOnHost += new Del_Void(OnEndInteractSyncAnimationOnHost);
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetActorStatus);
		base.BUSEventCollection.Evt_UpdateDummyMeshInSyncAnimation += new Del_UpdateDummyMeshInSyncAnimation(OnUpdateDummyMeshInSyncAnimation);
		base.BUSEventCollection.Evt_RequestSpawnSyncAnimActor += new Del_RequestSpawnSyncAnimActor(OnRequestSpawnSyncAnimActor);
		base.BUSEventCollection.Evt_RemoveSpawnedSyncAnimActor += new Del_RemoveSpawnedSyncAnimActor(OnRemoveSpawnedSyncAnimActor);
		base.BUSEventCollection.Evt_OnDummyMeshSpeedRateChange += new Del_Void(OnDummyMeshSpeedRateChange);
		base.BUSEventCollection.Evt_OnDummyMeshChange += new Del_OnDummyMeshChange(OnDummyMeshChange);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
	}

	public override void OnBeginPlay()
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(GetOwner().World))
		{
			UGSE_AnimFuncLib.SetRootMotionFromEverythingSwitch(GetOwner() as ACharacter, IsOpen: false);
			if (OwnerAsCharacterCS != null)
			{
				OwnerAsCharacterCS.Mesh.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		foreach (KeyValuePair<uint, TStrongObjectPtr<AActor>> spawnedSyncAnimActor in AnimationSyncHostData.SpawnedSyncAnimActors)
		{
			if (spawnedSyncAnimActor.Value != null && spawnedSyncAnimActor.Value.IsValid())
			{
				BGU_UnrealWorldUtil.DestroyActor(spawnedSyncAnimActor.Value.Get());
			}
		}
		AnimationSyncHostData.SpawnedSyncAnimActors.Clear();
		base.BGSEventCollection.Evt_BGS_EndInteractSyncAnimation.Invoke(Owner, P1: true);
		OnEndInteractSyncAnimationOnHost();
		base.BGSEventCollection.Evt_BGS_RemoveInteractParticipants.Invoke(Owner);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickAttachedDummyMeshNeedDetach(DeltaTime);
		TickSpawnedSyncAnimActorDestroy(DeltaTime);
		TickSyncDummySKAnimation(DeltaTime);
		TickForRemoveStates(DeltaTime);
	}

	private void TickForRemoveStates(float DeltaTime)
	{
		if (AnimationSyncHostData.AnimationSyncMontageInstanceID != -1 && UGSE_AnimFuncLib.GetCurrentActiveMontageInstanceID(OwnerAsCharacterCS) != AnimationSyncHostData.AnimationSyncMontageInstanceID)
		{
			base.BGSEventCollection.Evt_BGS_EndSyncAnimation.Invoke(Owner);
			AnimationSyncHostData.AnimationSyncMontageInstanceID = -1;
		}
		if (AnimationSyncHostData.AnimationSyncTotalDuration > 0f)
		{
			AnimationSyncHostData.AnimationSyncTotalDuration -= DeltaTime;
			if (AnimationSyncHostData.AnimationSyncTotalDuration <= 0f)
			{
				base.BGSEventCollection.Evt_BGS_EndSyncAnimation.Invoke(Owner);
				AnimationSyncHostData.AnimationSyncTotalDuration = -1f;
			}
		}
	}

	private void TickSyncDummySKAnimation(float DeltaTime)
	{
		if (AnimationSyncHostData.SyncDummyMeshAnimationBeginTime > 0f)
		{
			float inPos = UBUS_UtilComm.GetCurActiveMontagePos(OwnerAsCharacterCS) - AnimationSyncHostData.SyncDummyMeshAnimationBeginTime - DeltaTime;
			AnimationSyncHostData.DummySK.SetPosition(inPos);
		}
	}

	private void TickSpawnedSyncAnimActorDestroy(float DeltaTime)
	{
		if (AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.Count == 0)
		{
			return;
		}
		foreach (uint item in AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.Keys.ToList())
		{
			float num = AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer[item] - DeltaTime;
			if (num <= 0f)
			{
				if (AnimationSyncHostData.SpawnedSyncAnimActors.TryGetValue(item, out var value))
				{
					BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(value.Get());
					BGU_UnrealWorldUtil.DestroyActor(value.Get());
				}
				AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.Remove(item);
				AnimationSyncHostData.SpawnedSyncAnimActors.Remove(item);
			}
			else
			{
				AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer[item] = num;
			}
		}
	}

	private void TickAttachedDummyMeshNeedDetach(float DeltaTime)
	{
		if (AnimationSyncHostData.bAMPaused)
		{
			return;
		}
		foreach (KeyValuePair<TWeakObject<USkeletalMeshComponent>, bool> item in AnimationSyncHostData.DummyMeshMap)
		{
			if (item.Key.IsValid())
			{
				AnimationSyncHostData.DummyMeshTickMap[item.Key] -= DeltaTime;
				if (AnimationSyncHostData.DummyMeshTickMap[item.Key] < 0f)
				{
					AnimationSyncHostData.DummyMeshMapNeedRemoveElement.Add(item.Key);
				}
			}
			else
			{
				AnimationSyncHostData.DummyMeshMapNeedRemoveElement.Add(item.Key);
			}
		}
		foreach (TWeakObject<USkeletalMeshComponent> item2 in AnimationSyncHostData.DummyMeshMapNeedRemoveElement)
		{
			if (item2.IsValid())
			{
				item2.Get().PauseAnims = false;
				item2.Get().SetPlayRate(1f);
			}
			if (AnimationSyncHostData.DummyMeshTickMap.ContainsKey(item2))
			{
				AnimationSyncHostData.DummyMeshTickMap.Remove(item2);
			}
			if (AnimationSyncHostData.DummyMeshMap.ContainsKey(item2))
			{
				AnimationSyncHostData.DummyMeshMap.Remove(item2);
			}
		}
		AnimationSyncHostData.DummyMeshMapNeedRemoveElement.Clear();
	}

	private void OnEnterPreAnimationSyncingStateOnHost(AActor Guest, List<int> PreAnimationSyncStateHostBuffList)
	{
		AnimationSyncHostData.Guest = Guest;
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.PreAnimationSyncing, IsRemove: false);
		foreach (int PreAnimationSyncStateHostBuff in PreAnimationSyncStateHostBuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(PreAnimationSyncStateHostBuff, Owner, Owner, -1f, EBuffSourceType.AnimationSync);
		}
	}

	private void ExitPreAnimationSyncingState(List<int> PreAnimationSyncStateHostBuffList)
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.PreAnimationSyncing, IsRemove: true);
		foreach (int PreAnimationSyncStateHostBuff in PreAnimationSyncStateHostBuffList)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(PreAnimationSyncStateHostBuff, EBuffEffectTriggerType.None, 1);
		}
	}

	private void OnEnterAnimationSyncingStateOnHost(List<int> AnimationSyncStateHostBuffList, UAnimMontage AnimationSyncMontage)
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.InAnimationSyncing, IsRemove: false);
		foreach (int AnimationSyncStateHostBuff in AnimationSyncStateHostBuffList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(AnimationSyncStateHostBuff, Owner, Owner, -1f, EBuffSourceType.AnimationSync);
		}
		if (OwnerAsCharacterCS != null)
		{
			AnimationSyncHostData.CurrentMontage = ((AnimationSyncMontage == null) ? OwnerAsCharacterCS.GetCurrentMontage() : AnimationSyncMontage);
		}
	}

	private void ExitAnimationSyncingState(List<int> AnimationSyncStateHostBuffList)
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(Owner, EBGUSimpleState.InAnimationSyncing, IsRemove: true);
		foreach (int AnimationSyncStateHostBuff in AnimationSyncStateHostBuffList)
		{
			if (this.BuffData.GetBuffInstData(AnimationSyncStateHostBuff, out var BuffData))
			{
				int layer = BuffData.Layer;
				for (int i = 0; i < layer; i++)
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(AnimationSyncStateHostBuff, EBuffEffectTriggerType.None, 1);
				}
			}
		}
	}

	private void OnBeginSyncAnimationOnHost(List<int> PreAnimationSyncStateHostBuffList, UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bForceSyncDummyMeshAnimation, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration, int AnimationSyncMontageInstanceID)
	{
		AnimationSyncHostData.AnimationSyncMontageInstanceID = AnimationSyncMontageInstanceID;
		AnimationSyncHostData.AnimationSyncTotalDuration = TotalDuration;
		ExitPreAnimationSyncingState(PreAnimationSyncStateHostBuffList);
		UBGUAnimationSyncComponent componentByClass = Owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (!(componentByClass == null))
		{
			if (bForceSyncDummyMeshAnimation)
			{
				AnimationSyncHostData.SyncDummyMeshAnimationBeginTime = NotifyBeginTime;
			}
			if (bFoundHostSyncPointOnDummyMesh)
			{
				AnimationSyncHostData.DummySK = UpdateDummyMeshInSyncAnimation(in SelfSyncPointOnHost, in TargetSyncPointOnHost, null);
			}
			float playRate = (MovementData.IsAMCalcSpeedRate ? MovementData.AMSpeedRate : 1f);
			componentByClass.OnBeginSyncAnimationOnGuest(GuestMontage, TargetSyncPointOnHost, SelfSyncPointOnGuest, bEnableDebugDraw, NotifyBeginTime, AnimationSyncHostData.DummySK, AnimationSyncHostData.Guest, 0.3f, playRate);
		}
	}

	private void OnEndSyncAnimationOnHost(List<int> PreAnimationSyncStateHostBuffList, List<int> AnimationSyncStateHostBuffList)
	{
		AnimationSyncHostData.AnimationSyncTotalDuration = -1f;
		AnimationSyncHostData.AnimationSyncMontageInstanceID = -1;
		AnimationSyncHostData.SyncDummyMeshAnimationBeginTime = -1f;
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PreAnimationSyncing))
		{
			ExitPreAnimationSyncingState(PreAnimationSyncStateHostBuffList);
		}
		ExitAnimationSyncingState(AnimationSyncStateHostBuffList);
		UBGUAnimationSyncComponent componentByClass = Owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (!(componentByClass == null))
		{
			componentByClass.OnEndSyncAnimationOnGuest();
			AnimationSyncHostData.Guest = null;
		}
	}

	private void OnBeginInteractSyncAnimationOnHost(AActor Guest, FName AttachSocketOnHost, FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		UBGUAnimationSyncComponent componentByClass = Owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (!(componentByClass == null))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InInteractAnimationSyncing);
			USkeletalMeshComponent dummyMesh = UpdateDummyMeshInSyncAnimation(in AttachSocketOnHost, in AttachSocketOnDummyMesh, DummyMeshAnimation);
			componentByClass.OnBeginSyncAnimationOnGuest(null, AttachSocketOnDummyMesh, B1GlobalFNames.root, bEnableDebugDraw: false, 0f, dummyMesh, Guest, 0.3f, 1f, bIgnoreSceneCollision: true);
			AnimationSyncHostData.Guest = Guest;
		}
	}

	private void OnEndInteractSyncAnimationOnHost()
	{
		UBGUAnimationSyncComponent componentByClass = Owner.GetComponentByClass<UBGUAnimationSyncComponent>();
		if (!(componentByClass == null))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InInteractAnimationSyncing, IsRemove: true);
			componentByClass.OnEndSyncAnimationOnGuest();
			AnimationSyncHostData.Guest = null;
		}
	}

	private void OnResetActorStatus(EResetActorReason Reason)
	{
		BGS_GSEventCollection.Get(Owner)?.Evt_BGS_EndSyncAnimation.Invoke(Owner);
	}

	private void OnUpdateDummyMeshInSyncAnimation(in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		UpdateDummyMeshInSyncAnimation(in AttachSocketOnHost, in AttachSocketOnDummyMesh, DummyMeshAnimation);
	}

	private USkeletalMeshComponent UpdateDummyMeshInSyncAnimation(in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation)
	{
		BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, Owner, AttachSocketOnDummyMesh, out var SocketOwnerComp);
		USkeletalMeshComponent uSkeletalMeshComponent = SocketOwnerComp as USkeletalMeshComponent;
		if (uSkeletalMeshComponent != null && uSkeletalMeshComponent.ComponentHasTag(B1GlobalFNames.DummySK))
		{
			uSkeletalMeshComponent.AttachToComponent(uSkeletalMeshComponent.GetAttachParent(), AttachSocketOnHost, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: true);
			if (DummyMeshAnimation != null)
			{
				uSkeletalMeshComponent.PlayAnimation(DummyMeshAnimation, bLooping: false);
				IBUC_MovementData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MovementData, BUC_MovementData>(Owner);
				if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsAMCalcSpeedRate)
				{
					uSkeletalMeshComponent.SetPlayRate(unPersistentReadOnlyData.AMSpeedRate);
					return uSkeletalMeshComponent;
				}
				uSkeletalMeshComponent.SetPlayRate(1f);
			}
		}
		return uSkeletalMeshComponent;
	}

	private void OnRequestSpawnSyncAnimActor(uint NotifyUniqueID, UClass SpawnActorTemplate)
	{
		if (SpawnActorTemplate == null || AnimationSyncHostData.SpawnedSyncAnimActors.ContainsKey(NotifyUniqueID))
		{
			return;
		}
		AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(GetOwner().World, SpawnActorTemplate);
		if (!(aActor == null))
		{
			BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
			if (bUS_DispLibEventCollection != null)
			{
				bUS_DispLibEventCollection?.Evt_AddChildActorMeshCompsToManager?.Invoke(aActor);
			}
			AnimationSyncHostData.SpawnedSyncAnimActors.Add(NotifyUniqueID, new TStrongObjectPtr<AActor>(aActor));
		}
	}

	private void OnRemoveSpawnedSyncAnimActor(uint NotifyUniqueID, bool bDestroy, float DestroyDelayTime)
	{
		if (!AnimationSyncHostData.SpawnedSyncAnimActors.TryGetValue(NotifyUniqueID, out var value))
		{
			return;
		}
		if (bDestroy)
		{
			if (DestroyDelayTime > 0f && !AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.ContainsKey(NotifyUniqueID))
			{
				AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.Add(NotifyUniqueID, DestroyDelayTime);
			}
			else
			{
				BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveChildActorMeshCompsFromManager?.Invoke(value.Get());
				BGU_UnrealWorldUtil.DestroyActor(value.Get());
			}
		}
		if (!AnimationSyncHostData.SpawnedSyncAnimActorDestroyTimer.ContainsKey(NotifyUniqueID))
		{
			AnimationSyncHostData.SpawnedSyncAnimActors.Remove(NotifyUniqueID);
		}
	}

	private void OnDummyMeshSpeedRateChange()
	{
		bool flag = !MovementData.IsAMCalcSpeedRate;
		AnimationSyncHostData.bAMPaused = MovementData.IsAMPause;
		bool bAMPaused = AnimationSyncHostData.bAMPaused;
		foreach (KeyValuePair<TWeakObject<USkeletalMeshComponent>, bool> item in AnimationSyncHostData.DummyMeshMap)
		{
			if (item.Key.IsValid())
			{
				item.Key.Get().PauseAnims = bAMPaused;
				if (!flag && AnimationSyncHostData.DummyMeshTickMap[item.Key] > 0f)
				{
					float num = AnimationSyncHostData.DummyMeshTickMap[item.Key];
					AnimationSyncHostData.DummyMeshTickMap[item.Key] = num * AnimationSyncHostData.LastAMSpeedRate / MovementData.AMSpeedRate;
					item.Key.Get().SetPlayRate(MovementData.AMSpeedRate);
				}
				else if (flag)
				{
					item.Key.Get().SetPlayRate(1f);
					AnimationSyncHostData.DummyMeshTickMap[item.Key] *= AnimationSyncHostData.LastAMSpeedRate;
				}
			}
			else
			{
				AnimationSyncHostData.DummyMeshMapNeedRemoveElement.Add(item.Key);
			}
		}
		foreach (TWeakObject<USkeletalMeshComponent> item2 in AnimationSyncHostData.DummyMeshMapNeedRemoveElement)
		{
			if (item2.IsValid())
			{
				item2.Get().SetPlayRate(1f);
			}
			if (AnimationSyncHostData.DummyMeshTickMap.ContainsKey(item2))
			{
				AnimationSyncHostData.DummyMeshTickMap.Remove(item2);
			}
			if (AnimationSyncHostData.DummyMeshMap.ContainsKey(item2))
			{
				AnimationSyncHostData.DummyMeshMap.Remove(item2);
			}
		}
		if (flag)
		{
			AnimationSyncHostData.LastAMSpeedRate = 1f;
		}
		else
		{
			AnimationSyncHostData.LastAMSpeedRate = MovementData.AMSpeedRate;
		}
		AnimationSyncHostData.DummyMeshMapNeedRemoveElement.Clear();
	}

	private void OnDummyMeshChange(USkeletalMeshComponent NewDummyMesh, bool bAdd, float Duration = -1f)
	{
		TWeakObject<USkeletalMeshComponent> key = new TWeakObject<USkeletalMeshComponent>(NewDummyMesh);
		if (bAdd)
		{
			if (NewDummyMesh.IsValidLowLevelFast())
			{
				if (!AnimationSyncHostData.DummyMeshTickMap.ContainsKey(key))
				{
					AnimationSyncHostData.DummyMeshTickMap.Add(key, 1f);
				}
				if (!AnimationSyncHostData.DummyMeshMap.ContainsKey(key))
				{
					AnimationSyncHostData.DummyMeshMap.Add(key, value: true);
				}
				AnimationSyncHostData.DummyMeshTickMap[key] = Duration;
				NewDummyMesh.PauseAnims = AnimationSyncHostData.bAMPaused;
				if (MovementData.IsAMCalcSpeedRate)
				{
					NewDummyMesh.SetPlayRate(AnimationSyncHostData.LastAMSpeedRate);
					AnimationSyncHostData.DummyMeshTickMap[key] = Duration / AnimationSyncHostData.LastAMSpeedRate;
				}
				else
				{
					NewDummyMesh.SetPlayRate(1f);
				}
			}
			return;
		}
		if (AnimationSyncHostData.DummyMeshMap.ContainsKey(key))
		{
			AnimationSyncHostData.DummyMeshMap.Remove(key);
		}
		if (AnimationSyncHostData.DummyMeshTickMap.ContainsKey(key))
		{
			AnimationSyncHostData.DummyMeshTickMap.Remove(key);
			if (key.IsValid())
			{
				key.Get().SetPlayRate(1f);
				key.Get().PauseAnims = false;
			}
		}
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (!(Montage != AnimationSyncHostData.CurrentMontage) && State == EMontageCallbackState.OnInterrupted)
		{
			base.BGSEventCollection.Evt_BGS_EndSyncAnimation.Invoke(Owner);
		}
	}
}
