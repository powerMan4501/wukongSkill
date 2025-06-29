using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AnimationSyncHostData : IBUC_AnimationSyncHostData
{
	public Dictionary<TWeakObject<USkeletalMeshComponent>, bool> DummyMeshMap = new Dictionary<TWeakObject<USkeletalMeshComponent>, bool>();

	public Dictionary<TWeakObject<USkeletalMeshComponent>, float> DummyMeshTickMap = new Dictionary<TWeakObject<USkeletalMeshComponent>, float>();

	public List<TWeakObject<USkeletalMeshComponent>> DummyMeshMapNeedRemoveElement = new List<TWeakObject<USkeletalMeshComponent>>();

	public float AnimationSyncTotalDuration = -1f;

	public int AnimationSyncMontageInstanceID = -1;

	public float SyncDummyMeshAnimationBeginTime = -1f;

	public USkeletalMeshComponent DummySK;

	public AActor Guest { get; set; }

	public Dictionary<uint, TStrongObjectPtr<AActor>> SpawnedSyncAnimActors { get; } = new Dictionary<uint, TStrongObjectPtr<AActor>>();

	public Dictionary<uint, float> SpawnedSyncAnimActorDestroyTimer { get; } = new Dictionary<uint, float>();

	public float LastAMSpeedRate { get; set; } = 1f;

	public bool bAMPaused { get; set; }

	public UAnimMontage CurrentMontage { get; set; }

	public AActor GetSpawnedSyncAnimActor(uint NotifyUniqueID)
	{
		if (!SpawnedSyncAnimActors.TryGetValue(NotifyUniqueID, out var value))
		{
			return null;
		}
		return value.Get();
	}
}
