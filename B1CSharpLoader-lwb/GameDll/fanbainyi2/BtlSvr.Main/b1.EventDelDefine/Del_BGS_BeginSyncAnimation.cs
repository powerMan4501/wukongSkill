using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BGS_BeginSyncAnimation(AActor Host, UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bForceSyncDummyMeshAnimation, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration, int AnimationSyncMontageInstanceID);
