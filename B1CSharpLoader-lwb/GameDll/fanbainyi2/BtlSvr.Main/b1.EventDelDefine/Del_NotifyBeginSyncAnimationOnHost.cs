using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_NotifyBeginSyncAnimationOnHost(List<int> PreAnimationSyncStateHostBuffList, UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bForceSyncDummyMeshAnimation, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration, int AnimationSyncMontageInstanceID);
