using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BeginSyncAnimationOnGuest(UAnimMontage GuestMontage, bool bFoundHostSyncPointOnDummyMesh, FName SelfSyncPointOnHost, FName TargetSyncPointOnHost, FName SelfSyncPointOnGuest, bool bEnableDebugDraw, float NotifyBeginTime, float TotalDuration);
