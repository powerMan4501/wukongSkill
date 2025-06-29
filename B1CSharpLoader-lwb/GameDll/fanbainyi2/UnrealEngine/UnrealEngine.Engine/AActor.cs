using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Actor", "Engine", UnrealModuleType.Engine)]
public class AActor : UObject
{
	private CachedUObject<UWorld> worldCached;

	private static int PrimaryActorTick_Offset;

	private static bool OnlyRelevantToOwner_IsValid;

	private static FFieldAddress OnlyRelevantToOwner_PropertyAddress;

	private static int OnlyRelevantToOwner_Offset;

	private static bool AlwaysRelevant_IsValid;

	private static FFieldAddress AlwaysRelevant_PropertyAddress;

	private static int AlwaysRelevant_Offset;

	private static bool Hidden_IsValid;

	private static FFieldAddress Hidden_PropertyAddress;

	private static int Hidden_Offset;

	private static bool NetUseOwnerRelevancy_IsValid;

	private static FFieldAddress NetUseOwnerRelevancy_PropertyAddress;

	private static int NetUseOwnerRelevancy_Offset;

	private static bool AllowTickBeforeBeginPlay_IsValid;

	private static FFieldAddress AllowTickBeforeBeginPlay_PropertyAddress;

	private static int AllowTickBeforeBeginPlay_Offset;

	private static bool CanBeDamaged_IsValid;

	private static FFieldAddress CanBeDamaged_PropertyAddress;

	private static int CanBeDamaged_Offset;

	private static bool FindCameraComponentWhenViewTarget_IsValid;

	private static FFieldAddress FindCameraComponentWhenViewTarget_PropertyAddress;

	private static int FindCameraComponentWhenViewTarget_Offset;

	private static bool GenerateOverlapEventsDuringLevelStreaming_IsValid;

	private static FFieldAddress GenerateOverlapEventsDuringLevelStreaming_PropertyAddress;

	private static int GenerateOverlapEventsDuringLevelStreaming_Offset;

	private static bool EnableAutoLODGeneration_IsValid;

	private static FFieldAddress EnableAutoLODGeneration_PropertyAddress;

	private static int EnableAutoLODGeneration_Offset;

	private static bool Replicates_IsValid;

	private static FFieldAddress Replicates_PropertyAddress;

	private static int Replicates_Offset;

	private static bool InitialLifeSpan_IsValid;

	private static int InitialLifeSpan_Offset;

	private static bool CustomTimeDilation_IsValid;

	private static int CustomTimeDilation_Offset;

	private static bool NetDormancy_IsValid;

	private static FFieldAddress NetDormancy_PropertyAddress;

	private static int NetDormancy_Offset;

	private static bool SpawnCollisionHandlingMethod_IsValid;

	private static FFieldAddress SpawnCollisionHandlingMethod_PropertyAddress;

	private static int SpawnCollisionHandlingMethod_Offset;

	private static bool InputComponent_IsValid;

	private static int InputComponent_Offset;

	private static bool NetCullDistanceSquared_IsValid;

	private static int NetCullDistanceSquared_Offset;

	private static bool NetUpdateFrequency_IsValid;

	private static int NetUpdateFrequency_Offset;

	private static bool MinNetUpdateFrequency_IsValid;

	private static int MinNetUpdateFrequency_Offset;

	private static bool NetPriority_IsValid;

	private static int NetPriority_Offset;

	private static bool Instigator_IsValid;

	private static int Instigator_Offset;

	private static bool RootComponent_IsValid;

	private static int RootComponent_Offset;

	private static bool PivotOffset_IsValid;

	private static int PivotOffset_Offset;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	private static bool SpriteScale_IsValid;

	private static int SpriteScale_Offset;

	private static bool Tags_IsValid;

	private static FFieldAddress Tags_PropertyAddress;

	private static int Tags_Offset;

	private TArrayReadWriteMarshaler<FName> Tags_MarshalerCached;

	private static bool OnTakeAnyDamage_IsValid;

	private static int OnTakeAnyDamage_Offset;

	private FTakeAnyDamageSignature OnTakeAnyDamage_DelegateCached;

	private static bool OnTakePointDamage_IsValid;

	private static int OnTakePointDamage_Offset;

	private FTakePointDamageSignature OnTakePointDamage_DelegateCached;

	private static bool OnTakeRadialDamage_IsValid;

	private static int OnTakeRadialDamage_Offset;

	private FTakeRadialDamageSignature OnTakeRadialDamage_DelegateCached;

	private static bool OnActorBeginOverlap_IsValid;

	private static int OnActorBeginOverlap_Offset;

	private FActorBeginOverlapSignature OnActorBeginOverlap_DelegateCached;

	private static bool OnActorEndOverlap_IsValid;

	private static int OnActorEndOverlap_Offset;

	private FActorEndOverlapSignature OnActorEndOverlap_DelegateCached;

	private static bool OnBeginCursorOver_IsValid;

	private static int OnBeginCursorOver_Offset;

	private FActorBeginCursorOverSignature OnBeginCursorOver_DelegateCached;

	private static bool OnEndCursorOver_IsValid;

	private static int OnEndCursorOver_Offset;

	private FActorEndCursorOverSignature OnEndCursorOver_DelegateCached;

	private static bool OnClicked_IsValid;

	private static int OnClicked_Offset;

	private FActorOnClickedSignature OnClicked_DelegateCached;

	private static bool OnReleased_IsValid;

	private static int OnReleased_Offset;

	private FActorOnReleasedSignature OnReleased_DelegateCached;

	private static bool OnInputTouchBegin_IsValid;

	private static int OnInputTouchBegin_Offset;

	private FActorOnInputTouchBeginSignature OnInputTouchBegin_DelegateCached;

	private static bool OnInputTouchEnd_IsValid;

	private static int OnInputTouchEnd_Offset;

	private FActorOnInputTouchEndSignature OnInputTouchEnd_DelegateCached;

	private static bool OnInputTouchEnter_IsValid;

	private static int OnInputTouchEnter_Offset;

	private FActorBeginTouchOverSignature OnInputTouchEnter_DelegateCached;

	private static bool OnInputTouchLeave_IsValid;

	private static int OnInputTouchLeave_Offset;

	private FActorEndTouchOverSignature OnInputTouchLeave_DelegateCached;

	private static bool OnActorHit_IsValid;

	private static int OnActorHit_Offset;

	private FActorHitSignature OnActorHit_DelegateCached;

	private static bool OnDestroyed_IsValid;

	private static int OnDestroyed_Offset;

	private FActorDestroyedSignature OnDestroyed_DelegateCached;

	private static bool OnEndPlay_IsValid;

	private static int OnEndPlay_Offset;

	private FActorEndPlaySignature OnEndPlay_DelegateCached;

	private static bool WasRecentlyRendered_IsValid;

	private static IntPtr WasRecentlyRendered_FunctionAddress;

	private static int WasRecentlyRendered_ParamsSize;

	private static bool WasRecentlyRendered_Tolerance_IsValid;

	private static FFieldAddress WasRecentlyRendered_Tolerance_PropertyAddress;

	private static int WasRecentlyRendered_Tolerance_Offset;

	private static bool WasRecentlyRendered_ReturnValue_IsValid;

	private static FFieldAddress WasRecentlyRendered_ReturnValue_PropertyAddress;

	private static int WasRecentlyRendered_ReturnValue_Offset;

	private static bool TearOff_IsValid;

	private static IntPtr TearOff_FunctionAddress;

	private static int TearOff_ParamsSize;

	private static bool SetTickGroup_IsValid;

	private static IntPtr SetTickGroup_FunctionAddress;

	private static int SetTickGroup_ParamsSize;

	private static bool SetTickGroup_NewTickGroup_IsValid;

	private static FFieldAddress SetTickGroup_NewTickGroup_PropertyAddress;

	private static int SetTickGroup_NewTickGroup_Offset;

	private static bool SetTickableWhenPaused_IsValid;

	private static IntPtr SetTickableWhenPaused_FunctionAddress;

	private static int SetTickableWhenPaused_ParamsSize;

	private static bool SetTickableWhenPaused_bTickableWhenPaused_IsValid;

	private static FFieldAddress SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress;

	private static int SetTickableWhenPaused_bTickableWhenPaused_Offset;

	private static bool SetReplicates_IsValid;

	private static IntPtr SetReplicates_FunctionAddress;

	private static int SetReplicates_ParamsSize;

	private static bool SetReplicates_bInReplicates_IsValid;

	private static FFieldAddress SetReplicates_bInReplicates_PropertyAddress;

	private static int SetReplicates_bInReplicates_Offset;

	private static bool SetReplicateMovement_IsValid;

	private static IntPtr SetReplicateMovement_FunctionAddress;

	private static int SetReplicateMovement_ParamsSize;

	private static bool SetReplicateMovement_bInReplicateMovement_IsValid;

	private static FFieldAddress SetReplicateMovement_bInReplicateMovement_PropertyAddress;

	private static int SetReplicateMovement_bInReplicateMovement_Offset;

	private static bool SetRayTracingGroupId_IsValid;

	private static IntPtr SetRayTracingGroupId_FunctionAddress;

	private static int SetRayTracingGroupId_ParamsSize;

	private static bool SetRayTracingGroupId_InRaytracingGroupId_IsValid;

	private static FFieldAddress SetRayTracingGroupId_InRaytracingGroupId_PropertyAddress;

	private static int SetRayTracingGroupId_InRaytracingGroupId_Offset;

	private static bool SetOwner_IsValid;

	private static IntPtr SetOwner_FunctionAddress;

	private static int SetOwner_ParamsSize;

	private static bool SetOwner_NewOwner_IsValid;

	private static FFieldAddress SetOwner_NewOwner_PropertyAddress;

	private static int SetOwner_NewOwner_Offset;

	private static bool SetNetDormancy_IsValid;

	private static IntPtr SetNetDormancy_FunctionAddress;

	private static int SetNetDormancy_ParamsSize;

	private static bool SetNetDormancy_NewDormancy_IsValid;

	private static FFieldAddress SetNetDormancy_NewDormancy_PropertyAddress;

	private static int SetNetDormancy_NewDormancy_Offset;

	private static bool SetLifeSpan_IsValid;

	private static IntPtr SetLifeSpan_FunctionAddress;

	private static int SetLifeSpan_ParamsSize;

	private static bool SetLifeSpan_InLifespan_IsValid;

	private static FFieldAddress SetLifeSpan_InLifespan_PropertyAddress;

	private static int SetLifeSpan_InLifespan_Offset;

	private static bool SetIsTemporarilyHiddenInEditor_IsValid;

	private static IntPtr SetIsTemporarilyHiddenInEditor_FunctionAddress;

	private static int SetIsTemporarilyHiddenInEditor_ParamsSize;

	private static bool SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid;

	private static FFieldAddress SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress;

	private static int SetIsTemporarilyHiddenInEditor_bIsHidden_Offset;

	private static bool SetFolderPath_IsValid;

	private static IntPtr SetFolderPath_FunctionAddress;

	private static int SetFolderPath_ParamsSize;

	private static bool SetFolderPath_NewFolderPath_IsValid;

	private static FFieldAddress SetFolderPath_NewFolderPath_PropertyAddress;

	private static int SetFolderPath_NewFolderPath_Offset;

	private static bool SetAutoDestroyWhenFinished_IsValid;

	private static IntPtr SetAutoDestroyWhenFinished_FunctionAddress;

	private static int SetAutoDestroyWhenFinished_ParamsSize;

	private static bool SetAutoDestroyWhenFinished_bVal_IsValid;

	private static FFieldAddress SetAutoDestroyWhenFinished_bVal_PropertyAddress;

	private static int SetAutoDestroyWhenFinished_bVal_Offset;

	private static bool SetActorTickInterval_IsValid;

	private static IntPtr SetActorTickInterval_FunctionAddress;

	private static int SetActorTickInterval_ParamsSize;

	private static bool SetActorTickInterval_TickInterval_IsValid;

	private static FFieldAddress SetActorTickInterval_TickInterval_PropertyAddress;

	private static int SetActorTickInterval_TickInterval_Offset;

	private static bool SetActorTickEnabled_IsValid;

	private static IntPtr SetActorTickEnabled_FunctionAddress;

	private static int SetActorTickEnabled_ParamsSize;

	private static bool SetActorTickEnabled_bEnabled_IsValid;

	private static FFieldAddress SetActorTickEnabled_bEnabled_PropertyAddress;

	private static int SetActorTickEnabled_bEnabled_Offset;

	private static bool SetActorScale3D_IsValid;

	private static IntPtr SetActorScale3D_FunctionAddress;

	private static int SetActorScale3D_ParamsSize;

	private static bool SetActorScale3D_NewScale3D_IsValid;

	private static FFieldAddress SetActorScale3D_NewScale3D_PropertyAddress;

	private static int SetActorScale3D_NewScale3D_Offset;

	private static bool SetActorRelativeScale3D_IsValid;

	private static IntPtr SetActorRelativeScale3D_FunctionAddress;

	private static int SetActorRelativeScale3D_ParamsSize;

	private static bool SetActorRelativeScale3D_NewRelativeScale_IsValid;

	private static FFieldAddress SetActorRelativeScale3D_NewRelativeScale_PropertyAddress;

	private static int SetActorRelativeScale3D_NewRelativeScale_Offset;

	private static bool SetActorLabel_IsValid;

	private static IntPtr SetActorLabel_FunctionAddress;

	private static int SetActorLabel_ParamsSize;

	private static bool SetActorLabel_NewActorLabel_IsValid;

	private static FFieldAddress SetActorLabel_NewActorLabel_PropertyAddress;

	private static int SetActorLabel_NewActorLabel_Offset;

	private static bool SetActorLabel_bMarkDirty_IsValid;

	private static FFieldAddress SetActorLabel_bMarkDirty_PropertyAddress;

	private static int SetActorLabel_bMarkDirty_Offset;

	private static bool SetActorHiddenInGame_IsValid;

	private static IntPtr SetActorHiddenInGame_FunctionAddress;

	private static int SetActorHiddenInGame_ParamsSize;

	private static bool SetActorHiddenInGame_bNewHidden_IsValid;

	private static FFieldAddress SetActorHiddenInGame_bNewHidden_PropertyAddress;

	private static int SetActorHiddenInGame_bNewHidden_Offset;

	private static bool SetActorEnableCollision_IsValid;

	private static IntPtr SetActorEnableCollision_FunctionAddress;

	private static int SetActorEnableCollision_ParamsSize;

	private static bool SetActorEnableCollision_bNewActorEnableCollision_IsValid;

	private static FFieldAddress SetActorEnableCollision_bNewActorEnableCollision_PropertyAddress;

	private static int SetActorEnableCollision_bNewActorEnableCollision_Offset;

	private static bool RemoveTickPrerequisiteComponent_IsValid;

	private static IntPtr RemoveTickPrerequisiteComponent_FunctionAddress;

	private static int RemoveTickPrerequisiteComponent_ParamsSize;

	private static bool RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid;

	private static FFieldAddress RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress;

	private static int RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset;

	private static bool RemoveTickPrerequisiteActor_IsValid;

	private static IntPtr RemoveTickPrerequisiteActor_FunctionAddress;

	private static int RemoveTickPrerequisiteActor_ParamsSize;

	private static bool RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid;

	private static FFieldAddress RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress;

	private static int RemoveTickPrerequisiteActor_PrerequisiteActor_Offset;

	private static bool ReceiveTick_IsValid;

	private IntPtr ReceiveTick_InstanceFunctionAddress;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTick_DeltaSeconds_PropertyAddress;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveRadialDamage_IsValid;

	private IntPtr ReceiveRadialDamage_InstanceFunctionAddress;

	private static IntPtr ReceiveRadialDamage_FunctionAddress;

	private static int ReceiveRadialDamage_ParamsSize;

	private static bool ReceiveRadialDamage_DamageReceived_IsValid;

	private static FFieldAddress ReceiveRadialDamage_DamageReceived_PropertyAddress;

	private static int ReceiveRadialDamage_DamageReceived_Offset;

	private static bool ReceiveRadialDamage_DamageType_IsValid;

	private static FFieldAddress ReceiveRadialDamage_DamageType_PropertyAddress;

	private static int ReceiveRadialDamage_DamageType_Offset;

	private static bool ReceiveRadialDamage_Origin_IsValid;

	private static FFieldAddress ReceiveRadialDamage_Origin_PropertyAddress;

	private static int ReceiveRadialDamage_Origin_Offset;

	private static bool ReceiveRadialDamage_HitInfo_IsValid;

	private static FFieldAddress ReceiveRadialDamage_HitInfo_PropertyAddress;

	private static int ReceiveRadialDamage_HitInfo_Offset;

	private static bool ReceiveRadialDamage_InstigatedBy_IsValid;

	private static FFieldAddress ReceiveRadialDamage_InstigatedBy_PropertyAddress;

	private static int ReceiveRadialDamage_InstigatedBy_Offset;

	private static bool ReceiveRadialDamage_DamageCauser_IsValid;

	private static FFieldAddress ReceiveRadialDamage_DamageCauser_PropertyAddress;

	private static int ReceiveRadialDamage_DamageCauser_Offset;

	private static bool ReceivePointDamage_IsValid;

	private IntPtr ReceivePointDamage_InstanceFunctionAddress;

	private static IntPtr ReceivePointDamage_FunctionAddress;

	private static int ReceivePointDamage_ParamsSize;

	private static bool ReceivePointDamage_Damage_IsValid;

	private static FFieldAddress ReceivePointDamage_Damage_PropertyAddress;

	private static int ReceivePointDamage_Damage_Offset;

	private static bool ReceivePointDamage_DamageType_IsValid;

	private static FFieldAddress ReceivePointDamage_DamageType_PropertyAddress;

	private static int ReceivePointDamage_DamageType_Offset;

	private static bool ReceivePointDamage_HitLocation_IsValid;

	private static FFieldAddress ReceivePointDamage_HitLocation_PropertyAddress;

	private static int ReceivePointDamage_HitLocation_Offset;

	private static bool ReceivePointDamage_HitNormal_IsValid;

	private static FFieldAddress ReceivePointDamage_HitNormal_PropertyAddress;

	private static int ReceivePointDamage_HitNormal_Offset;

	private static bool ReceivePointDamage_HitComponent_IsValid;

	private static FFieldAddress ReceivePointDamage_HitComponent_PropertyAddress;

	private static int ReceivePointDamage_HitComponent_Offset;

	private static bool ReceivePointDamage_BoneName_IsValid;

	private static FFieldAddress ReceivePointDamage_BoneName_PropertyAddress;

	private static int ReceivePointDamage_BoneName_Offset;

	private static bool ReceivePointDamage_ShotFromDirection_IsValid;

	private static FFieldAddress ReceivePointDamage_ShotFromDirection_PropertyAddress;

	private static int ReceivePointDamage_ShotFromDirection_Offset;

	private static bool ReceivePointDamage_InstigatedBy_IsValid;

	private static FFieldAddress ReceivePointDamage_InstigatedBy_PropertyAddress;

	private static int ReceivePointDamage_InstigatedBy_Offset;

	private static bool ReceivePointDamage_DamageCauser_IsValid;

	private static FFieldAddress ReceivePointDamage_DamageCauser_PropertyAddress;

	private static int ReceivePointDamage_DamageCauser_Offset;

	private static bool ReceivePointDamage_HitInfo_IsValid;

	private static FFieldAddress ReceivePointDamage_HitInfo_PropertyAddress;

	private static int ReceivePointDamage_HitInfo_Offset;

	private static bool ReceiveHit_IsValid;

	private IntPtr ReceiveHit_InstanceFunctionAddress;

	private static IntPtr ReceiveHit_FunctionAddress;

	private static int ReceiveHit_ParamsSize;

	private static bool ReceiveHit_MyComp_IsValid;

	private static FFieldAddress ReceiveHit_MyComp_PropertyAddress;

	private static int ReceiveHit_MyComp_Offset;

	private static bool ReceiveHit_Other_IsValid;

	private static FFieldAddress ReceiveHit_Other_PropertyAddress;

	private static int ReceiveHit_Other_Offset;

	private static bool ReceiveHit_OtherComp_IsValid;

	private static FFieldAddress ReceiveHit_OtherComp_PropertyAddress;

	private static int ReceiveHit_OtherComp_Offset;

	private static bool ReceiveHit_bSelfMoved_IsValid;

	private static FFieldAddress ReceiveHit_bSelfMoved_PropertyAddress;

	private static int ReceiveHit_bSelfMoved_Offset;

	private static bool ReceiveHit_HitLocation_IsValid;

	private static FFieldAddress ReceiveHit_HitLocation_PropertyAddress;

	private static int ReceiveHit_HitLocation_Offset;

	private static bool ReceiveHit_HitNormal_IsValid;

	private static FFieldAddress ReceiveHit_HitNormal_PropertyAddress;

	private static int ReceiveHit_HitNormal_Offset;

	private static bool ReceiveHit_NormalImpulse_IsValid;

	private static FFieldAddress ReceiveHit_NormalImpulse_PropertyAddress;

	private static int ReceiveHit_NormalImpulse_Offset;

	private static bool ReceiveHit_Hit_IsValid;

	private static FFieldAddress ReceiveHit_Hit_PropertyAddress;

	private static int ReceiveHit_Hit_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private IntPtr ReceiveEndPlay_InstanceFunctionAddress;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static bool ReceiveDestroyed_IsValid;

	private IntPtr ReceiveDestroyed_InstanceFunctionAddress;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private IntPtr ReceiveBeginPlay_InstanceFunctionAddress;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool ReceiveAnyDamage_IsValid;

	private IntPtr ReceiveAnyDamage_InstanceFunctionAddress;

	private static IntPtr ReceiveAnyDamage_FunctionAddress;

	private static int ReceiveAnyDamage_ParamsSize;

	private static bool ReceiveAnyDamage_Damage_IsValid;

	private static FFieldAddress ReceiveAnyDamage_Damage_PropertyAddress;

	private static int ReceiveAnyDamage_Damage_Offset;

	private static bool ReceiveAnyDamage_DamageType_IsValid;

	private static FFieldAddress ReceiveAnyDamage_DamageType_PropertyAddress;

	private static int ReceiveAnyDamage_DamageType_Offset;

	private static bool ReceiveAnyDamage_InstigatedBy_IsValid;

	private static FFieldAddress ReceiveAnyDamage_InstigatedBy_PropertyAddress;

	private static int ReceiveAnyDamage_InstigatedBy_Offset;

	private static bool ReceiveAnyDamage_DamageCauser_IsValid;

	private static FFieldAddress ReceiveAnyDamage_DamageCauser_PropertyAddress;

	private static int ReceiveAnyDamage_DamageCauser_Offset;

	private static bool ReceiveActorOnReleased_IsValid;

	private IntPtr ReceiveActorOnReleased_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnReleased_FunctionAddress;

	private static int ReceiveActorOnReleased_ParamsSize;

	private static bool ReceiveActorOnReleased_ButtonReleased_IsValid;

	private static FFieldAddress ReceiveActorOnReleased_ButtonReleased_PropertyAddress;

	private static int ReceiveActorOnReleased_ButtonReleased_Offset;

	private static bool ReceiveActorOnInputTouchLeave_IsValid;

	private IntPtr ReceiveActorOnInputTouchLeave_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnInputTouchLeave_FunctionAddress;

	private static int ReceiveActorOnInputTouchLeave_ParamsSize;

	private static bool ReceiveActorOnInputTouchLeave_FingerIndex_IsValid;

	private static FFieldAddress ReceiveActorOnInputTouchLeave_FingerIndex_PropertyAddress;

	private static int ReceiveActorOnInputTouchLeave_FingerIndex_Offset;

	private static bool ReceiveActorOnInputTouchEnter_IsValid;

	private IntPtr ReceiveActorOnInputTouchEnter_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnInputTouchEnter_FunctionAddress;

	private static int ReceiveActorOnInputTouchEnter_ParamsSize;

	private static bool ReceiveActorOnInputTouchEnter_FingerIndex_IsValid;

	private static FFieldAddress ReceiveActorOnInputTouchEnter_FingerIndex_PropertyAddress;

	private static int ReceiveActorOnInputTouchEnter_FingerIndex_Offset;

	private static bool ReceiveActorOnInputTouchEnd_IsValid;

	private IntPtr ReceiveActorOnInputTouchEnd_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnInputTouchEnd_FunctionAddress;

	private static int ReceiveActorOnInputTouchEnd_ParamsSize;

	private static bool ReceiveActorOnInputTouchEnd_FingerIndex_IsValid;

	private static FFieldAddress ReceiveActorOnInputTouchEnd_FingerIndex_PropertyAddress;

	private static int ReceiveActorOnInputTouchEnd_FingerIndex_Offset;

	private static bool ReceiveActorOnInputTouchBegin_IsValid;

	private IntPtr ReceiveActorOnInputTouchBegin_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnInputTouchBegin_FunctionAddress;

	private static int ReceiveActorOnInputTouchBegin_ParamsSize;

	private static bool ReceiveActorOnInputTouchBegin_FingerIndex_IsValid;

	private static FFieldAddress ReceiveActorOnInputTouchBegin_FingerIndex_PropertyAddress;

	private static int ReceiveActorOnInputTouchBegin_FingerIndex_Offset;

	private static bool ReceiveActorOnClicked_IsValid;

	private IntPtr ReceiveActorOnClicked_InstanceFunctionAddress;

	private static IntPtr ReceiveActorOnClicked_FunctionAddress;

	private static int ReceiveActorOnClicked_ParamsSize;

	private static bool ReceiveActorOnClicked_ButtonPressed_IsValid;

	private static FFieldAddress ReceiveActorOnClicked_ButtonPressed_PropertyAddress;

	private static int ReceiveActorOnClicked_ButtonPressed_Offset;

	private static bool ReceiveActorEndOverlap_IsValid;

	private IntPtr ReceiveActorEndOverlap_InstanceFunctionAddress;

	private static IntPtr ReceiveActorEndOverlap_FunctionAddress;

	private static int ReceiveActorEndOverlap_ParamsSize;

	private static bool ReceiveActorEndOverlap_OtherActor_IsValid;

	private static FFieldAddress ReceiveActorEndOverlap_OtherActor_PropertyAddress;

	private static int ReceiveActorEndOverlap_OtherActor_Offset;

	private static bool ReceiveActorEndCursorOver_IsValid;

	private IntPtr ReceiveActorEndCursorOver_InstanceFunctionAddress;

	private static IntPtr ReceiveActorEndCursorOver_FunctionAddress;

	private static int ReceiveActorEndCursorOver_ParamsSize;

	private static bool ReceiveActorBeginOverlap_IsValid;

	private IntPtr ReceiveActorBeginOverlap_InstanceFunctionAddress;

	private static IntPtr ReceiveActorBeginOverlap_FunctionAddress;

	private static int ReceiveActorBeginOverlap_ParamsSize;

	private static bool ReceiveActorBeginOverlap_OtherActor_IsValid;

	private static FFieldAddress ReceiveActorBeginOverlap_OtherActor_PropertyAddress;

	private static int ReceiveActorBeginOverlap_OtherActor_Offset;

	private static bool ReceiveActorBeginCursorOver_IsValid;

	private IntPtr ReceiveActorBeginCursorOver_InstanceFunctionAddress;

	private static IntPtr ReceiveActorBeginCursorOver_FunctionAddress;

	private static int ReceiveActorBeginCursorOver_ParamsSize;

	private static bool PrestreamTextures_IsValid;

	private static IntPtr PrestreamTextures_FunctionAddress;

	private static int PrestreamTextures_ParamsSize;

	private static bool PrestreamTextures_Seconds_IsValid;

	private static FFieldAddress PrestreamTextures_Seconds_PropertyAddress;

	private static int PrestreamTextures_Seconds_Offset;

	private static bool PrestreamTextures_bEnableStreaming_IsValid;

	private static FFieldAddress PrestreamTextures_bEnableStreaming_PropertyAddress;

	private static int PrestreamTextures_bEnableStreaming_Offset;

	private static bool PrestreamTextures_CinematicTextureGroups_IsValid;

	private static FFieldAddress PrestreamTextures_CinematicTextureGroups_PropertyAddress;

	private static int PrestreamTextures_CinematicTextureGroups_Offset;

	private static bool MakeNoise_IsValid;

	private static IntPtr MakeNoise_FunctionAddress;

	private static int MakeNoise_ParamsSize;

	private static bool MakeNoise_Loudness_IsValid;

	private static FFieldAddress MakeNoise_Loudness_PropertyAddress;

	private static int MakeNoise_Loudness_Offset;

	private static bool MakeNoise_NoiseInstigator_IsValid;

	private static FFieldAddress MakeNoise_NoiseInstigator_PropertyAddress;

	private static int MakeNoise_NoiseInstigator_Offset;

	private static bool MakeNoise_NoiseLocation_IsValid;

	private static FFieldAddress MakeNoise_NoiseLocation_PropertyAddress;

	private static int MakeNoise_NoiseLocation_Offset;

	private static bool MakeNoise_MaxRange_IsValid;

	private static FFieldAddress MakeNoise_MaxRange_PropertyAddress;

	private static int MakeNoise_MaxRange_Offset;

	private static bool MakeNoise_Tag_IsValid;

	private static FFieldAddress MakeNoise_Tag_PropertyAddress;

	private static int MakeNoise_Tag_Offset;

	private static bool Teleport_IsValid;

	private static IntPtr Teleport_FunctionAddress;

	private static int Teleport_ParamsSize;

	private static bool Teleport_DestLocation_IsValid;

	private static FFieldAddress Teleport_DestLocation_PropertyAddress;

	private static int Teleport_DestLocation_Offset;

	private static bool Teleport_DestRotation_IsValid;

	private static FFieldAddress Teleport_DestRotation_PropertyAddress;

	private static int Teleport_DestRotation_Offset;

	private static bool Teleport_ReturnValue_IsValid;

	private static FFieldAddress Teleport_ReturnValue_PropertyAddress;

	private static int Teleport_ReturnValue_Offset;

	private static bool SetActorTransform_IsValid;

	private static IntPtr SetActorTransform_FunctionAddress;

	private static int SetActorTransform_ParamsSize;

	private static bool SetActorTransform_NewTransform_IsValid;

	private static FFieldAddress SetActorTransform_NewTransform_PropertyAddress;

	private static int SetActorTransform_NewTransform_Offset;

	private static bool SetActorTransform_bSweep_IsValid;

	private static FFieldAddress SetActorTransform_bSweep_PropertyAddress;

	private static int SetActorTransform_bSweep_Offset;

	private static bool SetActorTransform_SweepHitResult_IsValid;

	private static FFieldAddress SetActorTransform_SweepHitResult_PropertyAddress;

	private static int SetActorTransform_SweepHitResult_Offset;

	private static bool SetActorTransform_bTeleport_IsValid;

	private static FFieldAddress SetActorTransform_bTeleport_PropertyAddress;

	private static int SetActorTransform_bTeleport_Offset;

	private static bool SetActorTransform_ReturnValue_IsValid;

	private static FFieldAddress SetActorTransform_ReturnValue_PropertyAddress;

	private static int SetActorTransform_ReturnValue_Offset;

	private static bool SetActorRotation_IsValid;

	private static IntPtr SetActorRotation_FunctionAddress;

	private static int SetActorRotation_ParamsSize;

	private static bool SetActorRotation_NewRotation_IsValid;

	private static FFieldAddress SetActorRotation_NewRotation_PropertyAddress;

	private static int SetActorRotation_NewRotation_Offset;

	private static bool SetActorRotation_bTeleportPhysics_IsValid;

	private static FFieldAddress SetActorRotation_bTeleportPhysics_PropertyAddress;

	private static int SetActorRotation_bTeleportPhysics_Offset;

	private static bool SetActorRotation_ReturnValue_IsValid;

	private static FFieldAddress SetActorRotation_ReturnValue_PropertyAddress;

	private static int SetActorRotation_ReturnValue_Offset;

	private static bool SetActorRelativeTransform_IsValid;

	private static IntPtr SetActorRelativeTransform_FunctionAddress;

	private static int SetActorRelativeTransform_ParamsSize;

	private static bool SetActorRelativeTransform_NewRelativeTransform_IsValid;

	private static FFieldAddress SetActorRelativeTransform_NewRelativeTransform_PropertyAddress;

	private static int SetActorRelativeTransform_NewRelativeTransform_Offset;

	private static bool SetActorRelativeTransform_bSweep_IsValid;

	private static FFieldAddress SetActorRelativeTransform_bSweep_PropertyAddress;

	private static int SetActorRelativeTransform_bSweep_Offset;

	private static bool SetActorRelativeTransform_SweepHitResult_IsValid;

	private static FFieldAddress SetActorRelativeTransform_SweepHitResult_PropertyAddress;

	private static int SetActorRelativeTransform_SweepHitResult_Offset;

	private static bool SetActorRelativeTransform_bTeleport_IsValid;

	private static FFieldAddress SetActorRelativeTransform_bTeleport_PropertyAddress;

	private static int SetActorRelativeTransform_bTeleport_Offset;

	private static bool SetActorRelativeRotation_IsValid;

	private static IntPtr SetActorRelativeRotation_FunctionAddress;

	private static int SetActorRelativeRotation_ParamsSize;

	private static bool SetActorRelativeRotation_NewRelativeRotation_IsValid;

	private static FFieldAddress SetActorRelativeRotation_NewRelativeRotation_PropertyAddress;

	private static int SetActorRelativeRotation_NewRelativeRotation_Offset;

	private static bool SetActorRelativeRotation_bSweep_IsValid;

	private static FFieldAddress SetActorRelativeRotation_bSweep_PropertyAddress;

	private static int SetActorRelativeRotation_bSweep_Offset;

	private static bool SetActorRelativeRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetActorRelativeRotation_SweepHitResult_PropertyAddress;

	private static int SetActorRelativeRotation_SweepHitResult_Offset;

	private static bool SetActorRelativeRotation_bTeleport_IsValid;

	private static FFieldAddress SetActorRelativeRotation_bTeleport_PropertyAddress;

	private static int SetActorRelativeRotation_bTeleport_Offset;

	private static bool SetActorRelativeLocation_IsValid;

	private static IntPtr SetActorRelativeLocation_FunctionAddress;

	private static int SetActorRelativeLocation_ParamsSize;

	private static bool SetActorRelativeLocation_NewRelativeLocation_IsValid;

	private static FFieldAddress SetActorRelativeLocation_NewRelativeLocation_PropertyAddress;

	private static int SetActorRelativeLocation_NewRelativeLocation_Offset;

	private static bool SetActorRelativeLocation_bSweep_IsValid;

	private static FFieldAddress SetActorRelativeLocation_bSweep_PropertyAddress;

	private static int SetActorRelativeLocation_bSweep_Offset;

	private static bool SetActorRelativeLocation_SweepHitResult_IsValid;

	private static FFieldAddress SetActorRelativeLocation_SweepHitResult_PropertyAddress;

	private static int SetActorRelativeLocation_SweepHitResult_Offset;

	private static bool SetActorRelativeLocation_bTeleport_IsValid;

	private static FFieldAddress SetActorRelativeLocation_bTeleport_PropertyAddress;

	private static int SetActorRelativeLocation_bTeleport_Offset;

	private static bool SetActorLocationAndRotation_IsValid;

	private static IntPtr SetActorLocationAndRotation_FunctionAddress;

	private static int SetActorLocationAndRotation_ParamsSize;

	private static bool SetActorLocationAndRotation_NewLocation_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_NewLocation_PropertyAddress;

	private static int SetActorLocationAndRotation_NewLocation_Offset;

	private static bool SetActorLocationAndRotation_NewRotation_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_NewRotation_PropertyAddress;

	private static int SetActorLocationAndRotation_NewRotation_Offset;

	private static bool SetActorLocationAndRotation_bSweep_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_bSweep_PropertyAddress;

	private static int SetActorLocationAndRotation_bSweep_Offset;

	private static bool SetActorLocationAndRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_SweepHitResult_PropertyAddress;

	private static int SetActorLocationAndRotation_SweepHitResult_Offset;

	private static bool SetActorLocationAndRotation_bTeleport_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_bTeleport_PropertyAddress;

	private static int SetActorLocationAndRotation_bTeleport_Offset;

	private static bool SetActorLocationAndRotation_ReturnValue_IsValid;

	private static FFieldAddress SetActorLocationAndRotation_ReturnValue_PropertyAddress;

	private static int SetActorLocationAndRotation_ReturnValue_Offset;

	private static bool SetActorLocation_IsValid;

	private static IntPtr SetActorLocation_FunctionAddress;

	private static int SetActorLocation_ParamsSize;

	private static bool SetActorLocation_NewLocation_IsValid;

	private static FFieldAddress SetActorLocation_NewLocation_PropertyAddress;

	private static int SetActorLocation_NewLocation_Offset;

	private static bool SetActorLocation_bSweep_IsValid;

	private static FFieldAddress SetActorLocation_bSweep_PropertyAddress;

	private static int SetActorLocation_bSweep_Offset;

	private static bool SetActorLocation_SweepHitResult_IsValid;

	private static FFieldAddress SetActorLocation_SweepHitResult_PropertyAddress;

	private static int SetActorLocation_SweepHitResult_Offset;

	private static bool SetActorLocation_bTeleport_IsValid;

	private static FFieldAddress SetActorLocation_bTeleport_PropertyAddress;

	private static int SetActorLocation_bTeleport_Offset;

	private static bool SetActorLocation_ReturnValue_IsValid;

	private static FFieldAddress SetActorLocation_ReturnValue_PropertyAddress;

	private static int SetActorLocation_ReturnValue_Offset;

	private static bool OnReset_IsValid;

	private IntPtr OnReset_InstanceFunctionAddress;

	private static IntPtr OnReset_FunctionAddress;

	private static int OnReset_ParamsSize;

	private static bool OnEndViewTarget_IsValid;

	private IntPtr OnEndViewTarget_InstanceFunctionAddress;

	private static IntPtr OnEndViewTarget_FunctionAddress;

	private static int OnEndViewTarget_ParamsSize;

	private static bool OnEndViewTarget_PC_IsValid;

	private static FFieldAddress OnEndViewTarget_PC_PropertyAddress;

	private static int OnEndViewTarget_PC_Offset;

	private static bool OnBecomeViewTarget_IsValid;

	private IntPtr OnBecomeViewTarget_InstanceFunctionAddress;

	private static IntPtr OnBecomeViewTarget_FunctionAddress;

	private static int OnBecomeViewTarget_ParamsSize;

	private static bool OnBecomeViewTarget_PC_IsValid;

	private static FFieldAddress OnBecomeViewTarget_PC_PropertyAddress;

	private static int OnBecomeViewTarget_PC_Offset;

	private static bool GetRootComponent_IsValid;

	private static IntPtr GetRootComponent_FunctionAddress;

	private static int GetRootComponent_ParamsSize;

	private static bool GetRootComponent_ReturnValue_IsValid;

	private static FFieldAddress GetRootComponent_ReturnValue_PropertyAddress;

	private static int GetRootComponent_ReturnValue_Offset;

	private static bool GetComponentsByClass_IsValid;

	private static IntPtr GetComponentsByClass_FunctionAddress;

	private static int GetComponentsByClass_ParamsSize;

	private static bool GetComponentsByClass_ComponentClass_IsValid;

	private static FFieldAddress GetComponentsByClass_ComponentClass_PropertyAddress;

	private static int GetComponentsByClass_ComponentClass_Offset;

	private static bool GetComponentsByClass_ReturnValue_IsValid;

	private static FFieldAddress GetComponentsByClass_ReturnValue_PropertyAddress;

	private static int GetComponentsByClass_ReturnValue_Offset;

	private static bool GetActorRotation_IsValid;

	private static IntPtr GetActorRotation_FunctionAddress;

	private static int GetActorRotation_ParamsSize;

	private static bool GetActorRotation_ReturnValue_IsValid;

	private static FFieldAddress GetActorRotation_ReturnValue_PropertyAddress;

	private static int GetActorRotation_ReturnValue_Offset;

	private static bool GetActorLocation_IsValid;

	private static IntPtr GetActorLocation_FunctionAddress;

	private static int GetActorLocation_ParamsSize;

	private static bool GetActorLocation_ReturnValue_IsValid;

	private static FFieldAddress GetActorLocation_ReturnValue_PropertyAddress;

	private static int GetActorLocation_ReturnValue_Offset;

	private static bool DetachFromActor_IsValid;

	private static IntPtr DetachFromActor_FunctionAddress;

	private static int DetachFromActor_ParamsSize;

	private static bool DetachFromActor_LocationRule_IsValid;

	private static FFieldAddress DetachFromActor_LocationRule_PropertyAddress;

	private static int DetachFromActor_LocationRule_Offset;

	private static bool DetachFromActor_RotationRule_IsValid;

	private static FFieldAddress DetachFromActor_RotationRule_PropertyAddress;

	private static int DetachFromActor_RotationRule_Offset;

	private static bool DetachFromActor_ScaleRule_IsValid;

	private static FFieldAddress DetachFromActor_ScaleRule_PropertyAddress;

	private static int DetachFromActor_ScaleRule_Offset;

	private static bool DestroyActor_IsValid;

	private static IntPtr DestroyActor_FunctionAddress;

	private static int DestroyActor_ParamsSize;

	private static bool AttachToComponent_IsValid;

	private static IntPtr AttachToComponent_FunctionAddress;

	private static int AttachToComponent_ParamsSize;

	private static bool AttachToComponent_Parent_IsValid;

	private static FFieldAddress AttachToComponent_Parent_PropertyAddress;

	private static int AttachToComponent_Parent_Offset;

	private static bool AttachToComponent_SocketName_IsValid;

	private static FFieldAddress AttachToComponent_SocketName_PropertyAddress;

	private static int AttachToComponent_SocketName_Offset;

	private static bool AttachToComponent_LocationRule_IsValid;

	private static FFieldAddress AttachToComponent_LocationRule_PropertyAddress;

	private static int AttachToComponent_LocationRule_Offset;

	private static bool AttachToComponent_RotationRule_IsValid;

	private static FFieldAddress AttachToComponent_RotationRule_PropertyAddress;

	private static int AttachToComponent_RotationRule_Offset;

	private static bool AttachToComponent_ScaleRule_IsValid;

	private static FFieldAddress AttachToComponent_ScaleRule_PropertyAddress;

	private static int AttachToComponent_ScaleRule_Offset;

	private static bool AttachToComponent_bWeldSimulatedBodies_IsValid;

	private static FFieldAddress AttachToComponent_bWeldSimulatedBodies_PropertyAddress;

	private static int AttachToComponent_bWeldSimulatedBodies_Offset;

	private static bool AttachToActor_IsValid;

	private static IntPtr AttachToActor_FunctionAddress;

	private static int AttachToActor_ParamsSize;

	private static bool AttachToActor_ParentActor_IsValid;

	private static FFieldAddress AttachToActor_ParentActor_PropertyAddress;

	private static int AttachToActor_ParentActor_Offset;

	private static bool AttachToActor_SocketName_IsValid;

	private static FFieldAddress AttachToActor_SocketName_PropertyAddress;

	private static int AttachToActor_SocketName_Offset;

	private static bool AttachToActor_LocationRule_IsValid;

	private static FFieldAddress AttachToActor_LocationRule_PropertyAddress;

	private static int AttachToActor_LocationRule_Offset;

	private static bool AttachToActor_RotationRule_IsValid;

	private static FFieldAddress AttachToActor_RotationRule_PropertyAddress;

	private static int AttachToActor_RotationRule_Offset;

	private static bool AttachToActor_ScaleRule_IsValid;

	private static FFieldAddress AttachToActor_ScaleRule_PropertyAddress;

	private static int AttachToActor_ScaleRule_Offset;

	private static bool AttachToActor_bWeldSimulatedBodies_IsValid;

	private static FFieldAddress AttachToActor_bWeldSimulatedBodies_PropertyAddress;

	private static int AttachToActor_bWeldSimulatedBodies_Offset;

	private static bool AttachRootComponentToActor_IsValid;

	private static IntPtr AttachRootComponentToActor_FunctionAddress;

	private static int AttachRootComponentToActor_ParamsSize;

	private static bool AttachRootComponentToActor_InParentActor_IsValid;

	private static FFieldAddress AttachRootComponentToActor_InParentActor_PropertyAddress;

	private static int AttachRootComponentToActor_InParentActor_Offset;

	private static bool AttachRootComponentToActor_InSocketName_IsValid;

	private static FFieldAddress AttachRootComponentToActor_InSocketName_PropertyAddress;

	private static int AttachRootComponentToActor_InSocketName_Offset;

	private static bool AttachRootComponentToActor_AttachLocationType_IsValid;

	private static FFieldAddress AttachRootComponentToActor_AttachLocationType_PropertyAddress;

	private static int AttachRootComponentToActor_AttachLocationType_Offset;

	private static bool AttachRootComponentToActor_bWeldSimulatedBodies_IsValid;

	private static FFieldAddress AttachRootComponentToActor_bWeldSimulatedBodies_PropertyAddress;

	private static int AttachRootComponentToActor_bWeldSimulatedBodies_Offset;

	private static bool AttachRootComponentTo_IsValid;

	private static IntPtr AttachRootComponentTo_FunctionAddress;

	private static int AttachRootComponentTo_ParamsSize;

	private static bool AttachRootComponentTo_InParent_IsValid;

	private static FFieldAddress AttachRootComponentTo_InParent_PropertyAddress;

	private static int AttachRootComponentTo_InParent_Offset;

	private static bool AttachRootComponentTo_InSocketName_IsValid;

	private static FFieldAddress AttachRootComponentTo_InSocketName_PropertyAddress;

	private static int AttachRootComponentTo_InSocketName_Offset;

	private static bool AttachRootComponentTo_AttachLocationType_IsValid;

	private static FFieldAddress AttachRootComponentTo_AttachLocationType_PropertyAddress;

	private static int AttachRootComponentTo_AttachLocationType_Offset;

	private static bool AttachRootComponentTo_bWeldSimulatedBodies_IsValid;

	private static FFieldAddress AttachRootComponentTo_bWeldSimulatedBodies_PropertyAddress;

	private static int AttachRootComponentTo_bWeldSimulatedBodies_Offset;

	private static bool AddActorWorldTransformKeepScale_IsValid;

	private static IntPtr AddActorWorldTransformKeepScale_FunctionAddress;

	private static int AddActorWorldTransformKeepScale_ParamsSize;

	private static bool AddActorWorldTransformKeepScale_DeltaTransform_IsValid;

	private static FFieldAddress AddActorWorldTransformKeepScale_DeltaTransform_PropertyAddress;

	private static int AddActorWorldTransformKeepScale_DeltaTransform_Offset;

	private static bool AddActorWorldTransformKeepScale_bSweep_IsValid;

	private static FFieldAddress AddActorWorldTransformKeepScale_bSweep_PropertyAddress;

	private static int AddActorWorldTransformKeepScale_bSweep_Offset;

	private static bool AddActorWorldTransformKeepScale_SweepHitResult_IsValid;

	private static FFieldAddress AddActorWorldTransformKeepScale_SweepHitResult_PropertyAddress;

	private static int AddActorWorldTransformKeepScale_SweepHitResult_Offset;

	private static bool AddActorWorldTransformKeepScale_bTeleport_IsValid;

	private static FFieldAddress AddActorWorldTransformKeepScale_bTeleport_PropertyAddress;

	private static int AddActorWorldTransformKeepScale_bTeleport_Offset;

	private static bool AddActorWorldTransform_IsValid;

	private static IntPtr AddActorWorldTransform_FunctionAddress;

	private static int AddActorWorldTransform_ParamsSize;

	private static bool AddActorWorldTransform_DeltaTransform_IsValid;

	private static FFieldAddress AddActorWorldTransform_DeltaTransform_PropertyAddress;

	private static int AddActorWorldTransform_DeltaTransform_Offset;

	private static bool AddActorWorldTransform_bSweep_IsValid;

	private static FFieldAddress AddActorWorldTransform_bSweep_PropertyAddress;

	private static int AddActorWorldTransform_bSweep_Offset;

	private static bool AddActorWorldTransform_SweepHitResult_IsValid;

	private static FFieldAddress AddActorWorldTransform_SweepHitResult_PropertyAddress;

	private static int AddActorWorldTransform_SweepHitResult_Offset;

	private static bool AddActorWorldTransform_bTeleport_IsValid;

	private static FFieldAddress AddActorWorldTransform_bTeleport_PropertyAddress;

	private static int AddActorWorldTransform_bTeleport_Offset;

	private static bool AddActorWorldRotation_IsValid;

	private static IntPtr AddActorWorldRotation_FunctionAddress;

	private static int AddActorWorldRotation_ParamsSize;

	private static bool AddActorWorldRotation_DeltaRotation_IsValid;

	private static FFieldAddress AddActorWorldRotation_DeltaRotation_PropertyAddress;

	private static int AddActorWorldRotation_DeltaRotation_Offset;

	private static bool AddActorWorldRotation_bSweep_IsValid;

	private static FFieldAddress AddActorWorldRotation_bSweep_PropertyAddress;

	private static int AddActorWorldRotation_bSweep_Offset;

	private static bool AddActorWorldRotation_SweepHitResult_IsValid;

	private static FFieldAddress AddActorWorldRotation_SweepHitResult_PropertyAddress;

	private static int AddActorWorldRotation_SweepHitResult_Offset;

	private static bool AddActorWorldRotation_bTeleport_IsValid;

	private static FFieldAddress AddActorWorldRotation_bTeleport_PropertyAddress;

	private static int AddActorWorldRotation_bTeleport_Offset;

	private static bool AddActorWorldOffset_IsValid;

	private static IntPtr AddActorWorldOffset_FunctionAddress;

	private static int AddActorWorldOffset_ParamsSize;

	private static bool AddActorWorldOffset_DeltaLocation_IsValid;

	private static FFieldAddress AddActorWorldOffset_DeltaLocation_PropertyAddress;

	private static int AddActorWorldOffset_DeltaLocation_Offset;

	private static bool AddActorWorldOffset_bSweep_IsValid;

	private static FFieldAddress AddActorWorldOffset_bSweep_PropertyAddress;

	private static int AddActorWorldOffset_bSweep_Offset;

	private static bool AddActorWorldOffset_SweepHitResult_IsValid;

	private static FFieldAddress AddActorWorldOffset_SweepHitResult_PropertyAddress;

	private static int AddActorWorldOffset_SweepHitResult_Offset;

	private static bool AddActorWorldOffset_bTeleport_IsValid;

	private static FFieldAddress AddActorWorldOffset_bTeleport_PropertyAddress;

	private static int AddActorWorldOffset_bTeleport_Offset;

	private static bool AddActorLocalTransform_IsValid;

	private static IntPtr AddActorLocalTransform_FunctionAddress;

	private static int AddActorLocalTransform_ParamsSize;

	private static bool AddActorLocalTransform_NewTransform_IsValid;

	private static FFieldAddress AddActorLocalTransform_NewTransform_PropertyAddress;

	private static int AddActorLocalTransform_NewTransform_Offset;

	private static bool AddActorLocalTransform_bSweep_IsValid;

	private static FFieldAddress AddActorLocalTransform_bSweep_PropertyAddress;

	private static int AddActorLocalTransform_bSweep_Offset;

	private static bool AddActorLocalTransform_SweepHitResult_IsValid;

	private static FFieldAddress AddActorLocalTransform_SweepHitResult_PropertyAddress;

	private static int AddActorLocalTransform_SweepHitResult_Offset;

	private static bool AddActorLocalTransform_bTeleport_IsValid;

	private static FFieldAddress AddActorLocalTransform_bTeleport_PropertyAddress;

	private static int AddActorLocalTransform_bTeleport_Offset;

	private static bool AddActorLocalRotation_IsValid;

	private static IntPtr AddActorLocalRotation_FunctionAddress;

	private static int AddActorLocalRotation_ParamsSize;

	private static bool AddActorLocalRotation_DeltaRotation_IsValid;

	private static FFieldAddress AddActorLocalRotation_DeltaRotation_PropertyAddress;

	private static int AddActorLocalRotation_DeltaRotation_Offset;

	private static bool AddActorLocalRotation_bSweep_IsValid;

	private static FFieldAddress AddActorLocalRotation_bSweep_PropertyAddress;

	private static int AddActorLocalRotation_bSweep_Offset;

	private static bool AddActorLocalRotation_SweepHitResult_IsValid;

	private static FFieldAddress AddActorLocalRotation_SweepHitResult_PropertyAddress;

	private static int AddActorLocalRotation_SweepHitResult_Offset;

	private static bool AddActorLocalRotation_bTeleport_IsValid;

	private static FFieldAddress AddActorLocalRotation_bTeleport_PropertyAddress;

	private static int AddActorLocalRotation_bTeleport_Offset;

	private static bool AddActorLocalOffset_IsValid;

	private static IntPtr AddActorLocalOffset_FunctionAddress;

	private static int AddActorLocalOffset_ParamsSize;

	private static bool AddActorLocalOffset_DeltaLocation_IsValid;

	private static FFieldAddress AddActorLocalOffset_DeltaLocation_PropertyAddress;

	private static int AddActorLocalOffset_DeltaLocation_Offset;

	private static bool AddActorLocalOffset_bSweep_IsValid;

	private static FFieldAddress AddActorLocalOffset_bSweep_PropertyAddress;

	private static int AddActorLocalOffset_bSweep_Offset;

	private static bool AddActorLocalOffset_SweepHitResult_IsValid;

	private static FFieldAddress AddActorLocalOffset_SweepHitResult_PropertyAddress;

	private static int AddActorLocalOffset_SweepHitResult_Offset;

	private static bool AddActorLocalOffset_bTeleport_IsValid;

	private static FFieldAddress AddActorLocalOffset_bTeleport_PropertyAddress;

	private static int AddActorLocalOffset_bTeleport_Offset;

	private static bool IsTemporarilyHiddenInEditor_IsValid;

	private static IntPtr IsTemporarilyHiddenInEditor_FunctionAddress;

	private static int IsTemporarilyHiddenInEditor_ParamsSize;

	private static bool IsTemporarilyHiddenInEditor_bIncludeParent_IsValid;

	private static FFieldAddress IsTemporarilyHiddenInEditor_bIncludeParent_PropertyAddress;

	private static int IsTemporarilyHiddenInEditor_bIncludeParent_Offset;

	private static bool IsTemporarilyHiddenInEditor_ReturnValue_IsValid;

	private static FFieldAddress IsTemporarilyHiddenInEditor_ReturnValue_PropertyAddress;

	private static int IsTemporarilyHiddenInEditor_ReturnValue_Offset;

	private static bool IsSelectable_IsValid;

	private static IntPtr IsSelectable_FunctionAddress;

	private static int IsSelectable_ParamsSize;

	private static bool IsSelectable_ReturnValue_IsValid;

	private static FFieldAddress IsSelectable_ReturnValue_PropertyAddress;

	private static int IsSelectable_ReturnValue_Offset;

	private static bool IsOverlappingActor_IsValid;

	private static IntPtr IsOverlappingActor_FunctionAddress;

	private static int IsOverlappingActor_ParamsSize;

	private static bool IsOverlappingActor_Other_IsValid;

	private static FFieldAddress IsOverlappingActor_Other_PropertyAddress;

	private static int IsOverlappingActor_Other_Offset;

	private static bool IsOverlappingActor_ReturnValue_IsValid;

	private static FFieldAddress IsOverlappingActor_ReturnValue_PropertyAddress;

	private static int IsOverlappingActor_ReturnValue_Offset;

	private static bool IsHiddenEdAtStartup_IsValid;

	private static IntPtr IsHiddenEdAtStartup_FunctionAddress;

	private static int IsHiddenEdAtStartup_ParamsSize;

	private static bool IsHiddenEdAtStartup_ReturnValue_IsValid;

	private static FFieldAddress IsHiddenEdAtStartup_ReturnValue_PropertyAddress;

	private static int IsHiddenEdAtStartup_ReturnValue_Offset;

	private static bool IsHiddenEd_IsValid;

	private static IntPtr IsHiddenEd_FunctionAddress;

	private static int IsHiddenEd_ParamsSize;

	private static bool IsHiddenEd_ReturnValue_IsValid;

	private static FFieldAddress IsHiddenEd_ReturnValue_PropertyAddress;

	private static int IsHiddenEd_ReturnValue_Offset;

	private static bool IsEditable_IsValid;

	private static IntPtr IsEditable_FunctionAddress;

	private static int IsEditable_ParamsSize;

	private static bool IsEditable_ReturnValue_IsValid;

	private static FFieldAddress IsEditable_ReturnValue_PropertyAddress;

	private static int IsEditable_ReturnValue_Offset;

	private static bool IsChildActor_IsValid;

	private static IntPtr IsChildActor_FunctionAddress;

	private static int IsChildActor_ParamsSize;

	private static bool IsChildActor_ReturnValue_IsValid;

	private static FFieldAddress IsChildActor_ReturnValue_PropertyAddress;

	private static int IsChildActor_ReturnValue_Offset;

	private static bool IsActorTickEnabled_IsValid;

	private static IntPtr IsActorTickEnabled_FunctionAddress;

	private static int IsActorTickEnabled_ParamsSize;

	private static bool IsActorTickEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsActorTickEnabled_ReturnValue_PropertyAddress;

	private static int IsActorTickEnabled_ReturnValue_Offset;

	private static bool IsActorBeingDestroyed_IsValid;

	private static IntPtr IsActorBeingDestroyed_FunctionAddress;

	private static int IsActorBeingDestroyed_ParamsSize;

	private static bool IsActorBeingDestroyed_ReturnValue_IsValid;

	private static FFieldAddress IsActorBeingDestroyed_ReturnValue_PropertyAddress;

	private static int IsActorBeingDestroyed_ReturnValue_Offset;

	private static bool HasAuthority_IsValid;

	private static IntPtr HasAuthority_FunctionAddress;

	private static int HasAuthority_ParamsSize;

	private static bool HasAuthority_ReturnValue_IsValid;

	private static FFieldAddress HasAuthority_ReturnValue_PropertyAddress;

	private static int HasAuthority_ReturnValue_Offset;

	private static bool GetVerticalDistanceTo_IsValid;

	private static IntPtr GetVerticalDistanceTo_FunctionAddress;

	private static int GetVerticalDistanceTo_ParamsSize;

	private static bool GetVerticalDistanceTo_OtherActor_IsValid;

	private static FFieldAddress GetVerticalDistanceTo_OtherActor_PropertyAddress;

	private static int GetVerticalDistanceTo_OtherActor_Offset;

	private static bool GetVerticalDistanceTo_ReturnValue_IsValid;

	private static FFieldAddress GetVerticalDistanceTo_ReturnValue_PropertyAddress;

	private static int GetVerticalDistanceTo_ReturnValue_Offset;

	private static bool GetVelocity_IsValid;

	private static IntPtr GetVelocity_FunctionAddress;

	private static int GetVelocity_ParamsSize;

	private static bool GetVelocity_ReturnValue_IsValid;

	private static FFieldAddress GetVelocity_ReturnValue_PropertyAddress;

	private static int GetVelocity_ReturnValue_Offset;

	private static bool GetActorTransform_IsValid;

	private static IntPtr GetActorTransform_FunctionAddress;

	private static int GetActorTransform_ParamsSize;

	private static bool GetActorTransform_ReturnValue_IsValid;

	private static FFieldAddress GetActorTransform_ReturnValue_PropertyAddress;

	private static int GetActorTransform_ReturnValue_Offset;

	private static bool GetTickableWhenPaused_IsValid;

	private static IntPtr GetTickableWhenPaused_FunctionAddress;

	private static int GetTickableWhenPaused_ParamsSize;

	private static bool GetTickableWhenPaused_ReturnValue_IsValid;

	private static FFieldAddress GetTickableWhenPaused_ReturnValue_PropertyAddress;

	private static int GetTickableWhenPaused_ReturnValue_Offset;

	private static bool GetSquaredHorizontalDistanceTo_IsValid;

	private static IntPtr GetSquaredHorizontalDistanceTo_FunctionAddress;

	private static int GetSquaredHorizontalDistanceTo_ParamsSize;

	private static bool GetSquaredHorizontalDistanceTo_OtherActor_IsValid;

	private static FFieldAddress GetSquaredHorizontalDistanceTo_OtherActor_PropertyAddress;

	private static int GetSquaredHorizontalDistanceTo_OtherActor_Offset;

	private static bool GetSquaredHorizontalDistanceTo_ReturnValue_IsValid;

	private static FFieldAddress GetSquaredHorizontalDistanceTo_ReturnValue_PropertyAddress;

	private static int GetSquaredHorizontalDistanceTo_ReturnValue_Offset;

	private static bool GetSquaredDistanceTo_IsValid;

	private static IntPtr GetSquaredDistanceTo_FunctionAddress;

	private static int GetSquaredDistanceTo_ParamsSize;

	private static bool GetSquaredDistanceTo_OtherActor_IsValid;

	private static FFieldAddress GetSquaredDistanceTo_OtherActor_PropertyAddress;

	private static int GetSquaredDistanceTo_OtherActor_Offset;

	private static bool GetSquaredDistanceTo_ReturnValue_IsValid;

	private static FFieldAddress GetSquaredDistanceTo_ReturnValue_PropertyAddress;

	private static int GetSquaredDistanceTo_ReturnValue_Offset;

	private static bool GetRemoteRole_IsValid;

	private static IntPtr GetRemoteRole_FunctionAddress;

	private static int GetRemoteRole_ParamsSize;

	private static bool GetRemoteRole_ReturnValue_IsValid;

	private static FFieldAddress GetRemoteRole_ReturnValue_PropertyAddress;

	private static int GetRemoteRole_ReturnValue_Offset;

	private static bool GetRayTracingGroupId_IsValid;

	private static IntPtr GetRayTracingGroupId_FunctionAddress;

	private static int GetRayTracingGroupId_ParamsSize;

	private static bool GetRayTracingGroupId_ReturnValue_IsValid;

	private static FFieldAddress GetRayTracingGroupId_ReturnValue_PropertyAddress;

	private static int GetRayTracingGroupId_ReturnValue_Offset;

	private static bool GetParentComponent_IsValid;

	private static IntPtr GetParentComponent_FunctionAddress;

	private static int GetParentComponent_ParamsSize;

	private static bool GetParentComponent_ReturnValue_IsValid;

	private static FFieldAddress GetParentComponent_ReturnValue_PropertyAddress;

	private static int GetParentComponent_ReturnValue_Offset;

	private static bool GetParentActor_IsValid;

	private static IntPtr GetParentActor_FunctionAddress;

	private static int GetParentActor_ParamsSize;

	private static bool GetParentActor_ReturnValue_IsValid;

	private static FFieldAddress GetParentActor_ReturnValue_PropertyAddress;

	private static int GetParentActor_ReturnValue_Offset;

	private static bool GetOwner_IsValid;

	private static IntPtr GetOwner_FunctionAddress;

	private static int GetOwner_ParamsSize;

	private static bool GetOwner_ReturnValue_IsValid;

	private static FFieldAddress GetOwner_ReturnValue_PropertyAddress;

	private static int GetOwner_ReturnValue_Offset;

	private static bool GetOverlappingComponents_IsValid;

	private static IntPtr GetOverlappingComponents_FunctionAddress;

	private static int GetOverlappingComponents_ParamsSize;

	private static bool GetOverlappingComponents_OverlappingComponents_IsValid;

	private static FFieldAddress GetOverlappingComponents_OverlappingComponents_PropertyAddress;

	private static int GetOverlappingComponents_OverlappingComponents_Offset;

	private static bool GetOverlappingActors_IsValid;

	private static IntPtr GetOverlappingActors_FunctionAddress;

	private static int GetOverlappingActors_ParamsSize;

	private static bool GetOverlappingActors_OverlappingActors_IsValid;

	private static FFieldAddress GetOverlappingActors_OverlappingActors_PropertyAddress;

	private static int GetOverlappingActors_OverlappingActors_Offset;

	private static bool GetOverlappingActors_ClassFilter_IsValid;

	private static FFieldAddress GetOverlappingActors_ClassFilter_PropertyAddress;

	private static int GetOverlappingActors_ClassFilter_Offset;

	private static bool GetLocalRole_IsValid;

	private static IntPtr GetLocalRole_FunctionAddress;

	private static int GetLocalRole_ParamsSize;

	private static bool GetLocalRole_ReturnValue_IsValid;

	private static FFieldAddress GetLocalRole_ReturnValue_PropertyAddress;

	private static int GetLocalRole_ReturnValue_Offset;

	private static bool GetLifeSpan_IsValid;

	private static IntPtr GetLifeSpan_FunctionAddress;

	private static int GetLifeSpan_ParamsSize;

	private static bool GetLifeSpan_ReturnValue_IsValid;

	private static FFieldAddress GetLifeSpan_ReturnValue_PropertyAddress;

	private static int GetLifeSpan_ReturnValue_Offset;

	private static bool GetLevelTransform_IsValid;

	private static IntPtr GetLevelTransform_FunctionAddress;

	private static int GetLevelTransform_ParamsSize;

	private static bool GetLevelTransform_ReturnValue_IsValid;

	private static FFieldAddress GetLevelTransform_ReturnValue_PropertyAddress;

	private static int GetLevelTransform_ReturnValue_Offset;

	private static bool GetLevel_IsValid;

	private static IntPtr GetLevel_FunctionAddress;

	private static int GetLevel_ParamsSize;

	private static bool GetLevel_ReturnValue_IsValid;

	private static FFieldAddress GetLevel_ReturnValue_PropertyAddress;

	private static int GetLevel_ReturnValue_Offset;

	private static bool GetInstigatorController_IsValid;

	private static IntPtr GetInstigatorController_FunctionAddress;

	private static int GetInstigatorController_ParamsSize;

	private static bool GetInstigatorController_ReturnValue_IsValid;

	private static FFieldAddress GetInstigatorController_ReturnValue_PropertyAddress;

	private static int GetInstigatorController_ReturnValue_Offset;

	private static bool GetInstigator_IsValid;

	private static IntPtr GetInstigator_FunctionAddress;

	private static int GetInstigator_ParamsSize;

	private static bool GetInstigator_ReturnValue_IsValid;

	private static FFieldAddress GetInstigator_ReturnValue_PropertyAddress;

	private static int GetInstigator_ReturnValue_Offset;

	private static bool GetHorizontalDotProductTo_IsValid;

	private static IntPtr GetHorizontalDotProductTo_FunctionAddress;

	private static int GetHorizontalDotProductTo_ParamsSize;

	private static bool GetHorizontalDotProductTo_OtherActor_IsValid;

	private static FFieldAddress GetHorizontalDotProductTo_OtherActor_PropertyAddress;

	private static int GetHorizontalDotProductTo_OtherActor_Offset;

	private static bool GetHorizontalDotProductTo_ReturnValue_IsValid;

	private static FFieldAddress GetHorizontalDotProductTo_ReturnValue_PropertyAddress;

	private static int GetHorizontalDotProductTo_ReturnValue_Offset;

	private static bool GetHorizontalDistanceTo_IsValid;

	private static IntPtr GetHorizontalDistanceTo_FunctionAddress;

	private static int GetHorizontalDistanceTo_ParamsSize;

	private static bool GetHorizontalDistanceTo_OtherActor_IsValid;

	private static FFieldAddress GetHorizontalDistanceTo_OtherActor_PropertyAddress;

	private static int GetHorizontalDistanceTo_OtherActor_Offset;

	private static bool GetHorizontalDistanceTo_ReturnValue_IsValid;

	private static FFieldAddress GetHorizontalDistanceTo_ReturnValue_PropertyAddress;

	private static int GetHorizontalDistanceTo_ReturnValue_Offset;

	private static bool GetGameTimeSinceCreation_IsValid;

	private static IntPtr GetGameTimeSinceCreation_FunctionAddress;

	private static int GetGameTimeSinceCreation_ParamsSize;

	private static bool GetGameTimeSinceCreation_ReturnValue_IsValid;

	private static FFieldAddress GetGameTimeSinceCreation_ReturnValue_PropertyAddress;

	private static int GetGameTimeSinceCreation_ReturnValue_Offset;

	private static bool GetFolderPath_IsValid;

	private static IntPtr GetFolderPath_FunctionAddress;

	private static int GetFolderPath_ParamsSize;

	private static bool GetFolderPath_ReturnValue_IsValid;

	private static FFieldAddress GetFolderPath_ReturnValue_PropertyAddress;

	private static int GetFolderPath_ReturnValue_Offset;

	private static bool GetDotProductTo_IsValid;

	private static IntPtr GetDotProductTo_FunctionAddress;

	private static int GetDotProductTo_ParamsSize;

	private static bool GetDotProductTo_OtherActor_IsValid;

	private static FFieldAddress GetDotProductTo_OtherActor_PropertyAddress;

	private static int GetDotProductTo_OtherActor_Offset;

	private static bool GetDotProductTo_ReturnValue_IsValid;

	private static FFieldAddress GetDotProductTo_ReturnValue_PropertyAddress;

	private static int GetDotProductTo_ReturnValue_Offset;

	private static bool GetDistanceTo_IsValid;

	private static IntPtr GetDistanceTo_FunctionAddress;

	private static int GetDistanceTo_ParamsSize;

	private static bool GetDistanceTo_OtherActor_IsValid;

	private static FFieldAddress GetDistanceTo_OtherActor_PropertyAddress;

	private static int GetDistanceTo_OtherActor_Offset;

	private static bool GetDistanceTo_ReturnValue_IsValid;

	private static FFieldAddress GetDistanceTo_ReturnValue_PropertyAddress;

	private static int GetDistanceTo_ReturnValue_Offset;

	private static bool GetDefaultActorLabel_IsValid;

	private static IntPtr GetDefaultActorLabel_FunctionAddress;

	private static int GetDefaultActorLabel_ParamsSize;

	private static bool GetDefaultActorLabel_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultActorLabel_ReturnValue_PropertyAddress;

	private static int GetDefaultActorLabel_ReturnValue_Offset;

	private static bool GetComponentsByTag_IsValid;

	private static IntPtr GetComponentsByTag_FunctionAddress;

	private static int GetComponentsByTag_ParamsSize;

	private static bool GetComponentsByTag_ComponentClass_IsValid;

	private static FFieldAddress GetComponentsByTag_ComponentClass_PropertyAddress;

	private static int GetComponentsByTag_ComponentClass_Offset;

	private static bool GetComponentsByTag_Tag_IsValid;

	private static FFieldAddress GetComponentsByTag_Tag_PropertyAddress;

	private static int GetComponentsByTag_Tag_Offset;

	private static bool GetComponentsByTag_ReturnValue_IsValid;

	private static FFieldAddress GetComponentsByTag_ReturnValue_PropertyAddress;

	private static int GetComponentsByTag_ReturnValue_Offset;

	private static bool GetComponentsByInterface_IsValid;

	private static IntPtr GetComponentsByInterface_FunctionAddress;

	private static int GetComponentsByInterface_ParamsSize;

	private static bool GetComponentsByInterface_Interface_IsValid;

	private static FFieldAddress GetComponentsByInterface_Interface_PropertyAddress;

	private static int GetComponentsByInterface_Interface_Offset;

	private static bool GetComponentsByInterface_ReturnValue_IsValid;

	private static FFieldAddress GetComponentsByInterface_ReturnValue_PropertyAddress;

	private static int GetComponentsByInterface_ReturnValue_Offset;

	private static bool GetComponentByClass_IsValid;

	private static IntPtr GetComponentByClass_FunctionAddress;

	private static int GetComponentByClass_ParamsSize;

	private static bool GetComponentByClass_ComponentClass_IsValid;

	private static FFieldAddress GetComponentByClass_ComponentClass_PropertyAddress;

	private static int GetComponentByClass_ComponentClass_Offset;

	private static bool GetComponentByClass_ReturnValue_IsValid;

	private static FFieldAddress GetComponentByClass_ReturnValue_PropertyAddress;

	private static int GetComponentByClass_ReturnValue_Offset;

	private static bool GetAttachParentSocketName_IsValid;

	private static IntPtr GetAttachParentSocketName_FunctionAddress;

	private static int GetAttachParentSocketName_ParamsSize;

	private static bool GetAttachParentSocketName_ReturnValue_IsValid;

	private static FFieldAddress GetAttachParentSocketName_ReturnValue_PropertyAddress;

	private static int GetAttachParentSocketName_ReturnValue_Offset;

	private static bool GetAttachParentActor_IsValid;

	private static IntPtr GetAttachParentActor_FunctionAddress;

	private static int GetAttachParentActor_ParamsSize;

	private static bool GetAttachParentActor_ReturnValue_IsValid;

	private static FFieldAddress GetAttachParentActor_ReturnValue_PropertyAddress;

	private static int GetAttachParentActor_ReturnValue_Offset;

	private static bool GetAttachedActors_IsValid;

	private static IntPtr GetAttachedActors_FunctionAddress;

	private static int GetAttachedActors_ParamsSize;

	private static bool GetAttachedActors_OutActors_IsValid;

	private static FFieldAddress GetAttachedActors_OutActors_PropertyAddress;

	private static int GetAttachedActors_OutActors_Offset;

	private static bool GetAttachedActors_bResetArray_IsValid;

	private static FFieldAddress GetAttachedActors_bResetArray_PropertyAddress;

	private static int GetAttachedActors_bResetArray_Offset;

	private static bool GetAttachedActors_bRecursivelyIncludeAttachedActors_IsValid;

	private static FFieldAddress GetAttachedActors_bRecursivelyIncludeAttachedActors_PropertyAddress;

	private static int GetAttachedActors_bRecursivelyIncludeAttachedActors_Offset;

	private static bool GetAllChildActors_IsValid;

	private static IntPtr GetAllChildActors_FunctionAddress;

	private static int GetAllChildActors_ParamsSize;

	private static bool GetAllChildActors_ChildActors_IsValid;

	private static FFieldAddress GetAllChildActors_ChildActors_PropertyAddress;

	private static int GetAllChildActors_ChildActors_Offset;

	private static bool GetAllChildActors_bIncludeDescendants_IsValid;

	private static FFieldAddress GetAllChildActors_bIncludeDescendants_PropertyAddress;

	private static int GetAllChildActors_bIncludeDescendants_Offset;

	private static bool GetActorUpVector_IsValid;

	private static IntPtr GetActorUpVector_FunctionAddress;

	private static int GetActorUpVector_ParamsSize;

	private static bool GetActorUpVector_ReturnValue_IsValid;

	private static FFieldAddress GetActorUpVector_ReturnValue_PropertyAddress;

	private static int GetActorUpVector_ReturnValue_Offset;

	private static bool GetActorTimeDilation_IsValid;

	private static IntPtr GetActorTimeDilation_FunctionAddress;

	private static int GetActorTimeDilation_ParamsSize;

	private static bool GetActorTimeDilation_ReturnValue_IsValid;

	private static FFieldAddress GetActorTimeDilation_ReturnValue_PropertyAddress;

	private static int GetActorTimeDilation_ReturnValue_Offset;

	private static bool GetActorTickInterval_IsValid;

	private static IntPtr GetActorTickInterval_FunctionAddress;

	private static int GetActorTickInterval_ParamsSize;

	private static bool GetActorTickInterval_ReturnValue_IsValid;

	private static FFieldAddress GetActorTickInterval_ReturnValue_PropertyAddress;

	private static int GetActorTickInterval_ReturnValue_Offset;

	private static bool GetActorScale3D_IsValid;

	private static IntPtr GetActorScale3D_FunctionAddress;

	private static int GetActorScale3D_ParamsSize;

	private static bool GetActorScale3D_ReturnValue_IsValid;

	private static FFieldAddress GetActorScale3D_ReturnValue_PropertyAddress;

	private static int GetActorScale3D_ReturnValue_Offset;

	private static bool GetActorRightVector_IsValid;

	private static IntPtr GetActorRightVector_FunctionAddress;

	private static int GetActorRightVector_ParamsSize;

	private static bool GetActorRightVector_ReturnValue_IsValid;

	private static FFieldAddress GetActorRightVector_ReturnValue_PropertyAddress;

	private static int GetActorRightVector_ReturnValue_Offset;

	private static bool GetActorRelativeScale3D_IsValid;

	private static IntPtr GetActorRelativeScale3D_FunctionAddress;

	private static int GetActorRelativeScale3D_ParamsSize;

	private static bool GetActorRelativeScale3D_ReturnValue_IsValid;

	private static FFieldAddress GetActorRelativeScale3D_ReturnValue_PropertyAddress;

	private static int GetActorRelativeScale3D_ReturnValue_Offset;

	private static bool GetActorLabel_IsValid;

	private static IntPtr GetActorLabel_FunctionAddress;

	private static int GetActorLabel_ParamsSize;

	private static bool GetActorLabel_bCreateIfNone_IsValid;

	private static FFieldAddress GetActorLabel_bCreateIfNone_PropertyAddress;

	private static int GetActorLabel_bCreateIfNone_Offset;

	private static bool GetActorLabel_ReturnValue_IsValid;

	private static FFieldAddress GetActorLabel_ReturnValue_PropertyAddress;

	private static int GetActorLabel_ReturnValue_Offset;

	private static bool GetActorForwardVector_IsValid;

	private static IntPtr GetActorForwardVector_FunctionAddress;

	private static int GetActorForwardVector_ParamsSize;

	private static bool GetActorForwardVector_ReturnValue_IsValid;

	private static FFieldAddress GetActorForwardVector_ReturnValue_PropertyAddress;

	private static int GetActorForwardVector_ReturnValue_Offset;

	private static bool GetActorEyesViewPoint_IsValid;

	private static IntPtr GetActorEyesViewPoint_FunctionAddress;

	private static int GetActorEyesViewPoint_ParamsSize;

	private static bool GetActorEyesViewPoint_OutLocation_IsValid;

	private static FFieldAddress GetActorEyesViewPoint_OutLocation_PropertyAddress;

	private static int GetActorEyesViewPoint_OutLocation_Offset;

	private static bool GetActorEyesViewPoint_OutRotation_IsValid;

	private static FFieldAddress GetActorEyesViewPoint_OutRotation_PropertyAddress;

	private static int GetActorEyesViewPoint_OutRotation_Offset;

	private static bool GetActorEnableCollision_IsValid;

	private static IntPtr GetActorEnableCollision_FunctionAddress;

	private static int GetActorEnableCollision_ParamsSize;

	private static bool GetActorEnableCollision_ReturnValue_IsValid;

	private static FFieldAddress GetActorEnableCollision_ReturnValue_PropertyAddress;

	private static int GetActorEnableCollision_ReturnValue_Offset;

	private static bool GetActorBounds_IsValid;

	private static IntPtr GetActorBounds_FunctionAddress;

	private static int GetActorBounds_ParamsSize;

	private static bool GetActorBounds_bOnlyCollidingComponents_IsValid;

	private static FFieldAddress GetActorBounds_bOnlyCollidingComponents_PropertyAddress;

	private static int GetActorBounds_bOnlyCollidingComponents_Offset;

	private static bool GetActorBounds_Origin_IsValid;

	private static FFieldAddress GetActorBounds_Origin_PropertyAddress;

	private static int GetActorBounds_Origin_Offset;

	private static bool GetActorBounds_BoxExtent_IsValid;

	private static FFieldAddress GetActorBounds_BoxExtent_PropertyAddress;

	private static int GetActorBounds_BoxExtent_Offset;

	private static bool GetActorBounds_bIncludeFromChildActors_IsValid;

	private static FFieldAddress GetActorBounds_bIncludeFromChildActors_PropertyAddress;

	private static int GetActorBounds_bIncludeFromChildActors_Offset;

	private static bool ForceNetUpdate_IsValid;

	private static IntPtr ForceNetUpdate_FunctionAddress;

	private static int ForceNetUpdate_ParamsSize;

	private static bool FlushNetDormancy_IsValid;

	private static IntPtr FlushNetDormancy_FunctionAddress;

	private static int FlushNetDormancy_ParamsSize;

	private static bool EnableInput_IsValid;

	private static IntPtr EnableInput_FunctionAddress;

	private static int EnableInput_ParamsSize;

	private static bool EnableInput_PlayerController_IsValid;

	private static FFieldAddress EnableInput_PlayerController_PropertyAddress;

	private static int EnableInput_PlayerController_Offset;

	private static bool DisableInput_IsValid;

	private static IntPtr DisableInput_FunctionAddress;

	private static int DisableInput_ParamsSize;

	private static bool DisableInput_PlayerController_IsValid;

	private static FFieldAddress DisableInput_PlayerController_PropertyAddress;

	private static int DisableInput_PlayerController_Offset;

	private static bool DetachRootComponentFromParent_IsValid;

	private static IntPtr DetachRootComponentFromParent_FunctionAddress;

	private static int DetachRootComponentFromParent_ParamsSize;

	private static bool DetachRootComponentFromParent_bMaintainWorldPosition_IsValid;

	private static FFieldAddress DetachRootComponentFromParent_bMaintainWorldPosition_PropertyAddress;

	private static int DetachRootComponentFromParent_bMaintainWorldPosition_Offset;

	private static bool AddTickPrerequisiteComponent_IsValid;

	private static IntPtr AddTickPrerequisiteComponent_FunctionAddress;

	private static int AddTickPrerequisiteComponent_ParamsSize;

	private static bool AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid;

	private static FFieldAddress AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress;

	private static int AddTickPrerequisiteComponent_PrerequisiteComponent_Offset;

	private static bool AddTickPrerequisiteActor_IsValid;

	private static IntPtr AddTickPrerequisiteActor_FunctionAddress;

	private static int AddTickPrerequisiteActor_ParamsSize;

	private static bool AddTickPrerequisiteActor_PrerequisiteActor_IsValid;

	private static FFieldAddress AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress;

	private static int AddTickPrerequisiteActor_PrerequisiteActor_Offset;

	private static bool ActorHasTag_IsValid;

	private static IntPtr ActorHasTag_FunctionAddress;

	private static int ActorHasTag_ParamsSize;

	private static bool ActorHasTag_Tag_IsValid;

	private static FFieldAddress ActorHasTag_Tag_PropertyAddress;

	private static int ActorHasTag_Tag_Offset;

	private static bool ActorHasTag_ReturnValue_IsValid;

	private static FFieldAddress ActorHasTag_ReturnValue_PropertyAddress;

	private static int ActorHasTag_ReturnValue_Offset;

	public UWorld World => worldCached.Update(Native_AActor.GetWorld(base.Address));

	[UProperty(Flags = (PropFlags)4503599627436033uL)]
	[UMetaPath("/Script/Engine.Actor:PrimaryActorTick")]
	public FTickFunction PrimaryActorTick
	{
		get
		{
			CheckDestroyed();
			return new FTickFunction(IntPtr.Add(base.Address, PrimaryActorTick_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598037uL)]
	[UMetaPath("/Script/Engine.Actor:bOnlyRelevantToOwner")]
	protected bool OnlyRelevantToOwner
	{
		get
		{
			CheckDestroyed();
			if (!OnlyRelevantToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bOnlyRelevantToOwner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyRelevantToOwner_Offset), 0, OnlyRelevantToOwner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyRelevantToOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bOnlyRelevantToOwner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyRelevantToOwner_Offset), 0, OnlyRelevantToOwner_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598021uL)]
	[UMetaPath("/Script/Engine.Actor:bAlwaysRelevant")]
	protected bool AlwaysRelevant
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysRelevant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bAlwaysRelevant");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysRelevant_Offset), 0, AlwaysRelevant_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysRelevant_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bAlwaysRelevant");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysRelevant_Offset), 0, AlwaysRelevant_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266275632578613uL)]
	[UMetaPath("/Script/Engine.Actor:bHidden")]
	public bool Hidden
	{
		get
		{
			CheckDestroyed();
			if (!Hidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bHidden");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Hidden_Offset), 0, Hidden_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Hidden_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bHidden");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Hidden_Offset), 0, Hidden_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598021uL)]
	[UMetaPath("/Script/Engine.Actor:bNetUseOwnerRelevancy")]
	protected bool NetUseOwnerRelevancy
	{
		get
		{
			CheckDestroyed();
			if (!NetUseOwnerRelevancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bNetUseOwnerRelevancy");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NetUseOwnerRelevancy_Offset), 0, NetUseOwnerRelevancy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NetUseOwnerRelevancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bNetUseOwnerRelevancy");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NetUseOwnerRelevancy_Offset), 0, NetUseOwnerRelevancy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598017uL)]
	[UMetaPath("/Script/Engine.Actor:bAllowTickBeforeBeginPlay")]
	public bool AllowTickBeforeBeginPlay
	{
		get
		{
			CheckDestroyed();
			if (!AllowTickBeforeBeginPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bAllowTickBeforeBeginPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowTickBeforeBeginPlay_Offset), 0, AllowTickBeforeBeginPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowTickBeforeBeginPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bAllowTickBeforeBeginPlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowTickBeforeBeginPlay_Offset), 0, AllowTickBeforeBeginPlay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266267059421221uL)]
	[UMetaPath("/Script/Engine.Actor:bCanBeDamaged")]
	public bool CanBeDamaged
	{
		get
		{
			CheckDestroyed();
			if (!CanBeDamaged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bCanBeDamaged");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanBeDamaged_Offset), 0, CanBeDamaged_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanBeDamaged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bCanBeDamaged");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanBeDamaged_Offset), 0, CanBeDamaged_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.Actor:bFindCameraComponentWhenViewTarget")]
	public bool FindCameraComponentWhenViewTarget
	{
		get
		{
			CheckDestroyed();
			if (!FindCameraComponentWhenViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bFindCameraComponentWhenViewTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FindCameraComponentWhenViewTarget_Offset), 0, FindCameraComponentWhenViewTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindCameraComponentWhenViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bFindCameraComponentWhenViewTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FindCameraComponentWhenViewTarget_Offset), 0, FindCameraComponentWhenViewTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Actor:bGenerateOverlapEventsDuringLevelStreaming")]
	public bool GenerateOverlapEventsDuringLevelStreaming
	{
		get
		{
			CheckDestroyed();
			if (!GenerateOverlapEventsDuringLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bGenerateOverlapEventsDuringLevelStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GenerateOverlapEventsDuringLevelStreaming_Offset), 0, GenerateOverlapEventsDuringLevelStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenerateOverlapEventsDuringLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bGenerateOverlapEventsDuringLevelStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GenerateOverlapEventsDuringLevelStreaming_Offset), 0, GenerateOverlapEventsDuringLevelStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Actor:bEnableAutoLODGeneration")]
	public bool EnableAutoLODGeneration
	{
		get
		{
			CheckDestroyed();
			if (!EnableAutoLODGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bEnableAutoLODGeneration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAutoLODGeneration_Offset), 0, EnableAutoLODGeneration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAutoLODGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bEnableAutoLODGeneration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAutoLODGeneration_Offset), 0, EnableAutoLODGeneration_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880990741uL)]
	[UMetaPath("/Script/Engine.Actor:bReplicates")]
	protected bool Replicates
	{
		get
		{
			CheckDestroyed();
			if (!Replicates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bReplicates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Replicates_Offset), 0, Replicates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Replicates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:bReplicates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Replicates_Offset), 0, Replicates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.Actor:InitialLifeSpan")]
	public float InitialLifeSpan
	{
		get
		{
			CheckDestroyed();
			if (!InitialLifeSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:InitialLifeSpan");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialLifeSpan_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialLifeSpan_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:InitialLifeSpan");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialLifeSpan_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785924uL)]
	[UMetaPath("/Script/Engine.Actor:CustomTimeDilation")]
	public float CustomTimeDilation
	{
		get
		{
			CheckDestroyed();
			if (!CustomTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:CustomTimeDilation");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CustomTimeDilation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomTimeDilation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:CustomTimeDilation");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CustomTimeDilation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.Actor:NetDormancy")]
	protected ENetDormancy NetDormancy
	{
		get
		{
			CheckDestroyed();
			if (!NetDormancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetDormancy");
				return ENetDormancy.DORM_Never;
			}
			return EnumMarshaler<ENetDormancy>.FromNative(IntPtr.Add(base.Address, NetDormancy_Offset), 0, NetDormancy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NetDormancy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetDormancy");
			}
			else
			{
				EnumMarshaler<ENetDormancy>.ToNative(IntPtr.Add(base.Address, NetDormancy_Offset), 0, NetDormancy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.Actor:SpawnCollisionHandlingMethod")]
	public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingMethod
	{
		get
		{
			CheckDestroyed();
			if (!SpawnCollisionHandlingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:SpawnCollisionHandlingMethod");
				return ESpawnActorCollisionHandlingMethod.Undefined;
			}
			return EnumMarshaler<ESpawnActorCollisionHandlingMethod>.FromNative(IntPtr.Add(base.Address, SpawnCollisionHandlingMethod_Offset), 0, SpawnCollisionHandlingMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnCollisionHandlingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:SpawnCollisionHandlingMethod");
			}
			else
			{
				EnumMarshaler<ESpawnActorCollisionHandlingMethod>.ToNative(IntPtr.Add(base.Address, SpawnCollisionHandlingMethod_Offset), 0, SpawnCollisionHandlingMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369143738888uL)]
	[UMetaPath("/Script/Engine.Actor:InputComponent")]
	public UInputComponent InputComponent
	{
		get
		{
			CheckDestroyed();
			if (!InputComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:InputComponent");
				return null;
			}
			return UObjectMarshaler<UInputComponent>.FromNative(IntPtr.Add(base.Address, InputComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:InputComponent");
			}
			else
			{
				UObjectMarshaler<UInputComponent>.ToNative(IntPtr.Add(base.Address, InputComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340373uL)]
	[UMetaPath("/Script/Engine.Actor:NetCullDistanceSquared")]
	protected float NetCullDistanceSquared
	{
		get
		{
			CheckDestroyed();
			if (!NetCullDistanceSquared_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetCullDistanceSquared");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NetCullDistanceSquared_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NetCullDistanceSquared_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetCullDistanceSquared");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NetCullDistanceSquared_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/Engine.Actor:NetUpdateFrequency")]
	protected float NetUpdateFrequency
	{
		get
		{
			CheckDestroyed();
			if (!NetUpdateFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetUpdateFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NetUpdateFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NetUpdateFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetUpdateFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NetUpdateFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/Engine.Actor:MinNetUpdateFrequency")]
	protected float MinNetUpdateFrequency
	{
		get
		{
			CheckDestroyed();
			if (!MinNetUpdateFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:MinNetUpdateFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinNetUpdateFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinNetUpdateFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:MinNetUpdateFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinNetUpdateFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/Engine.Actor:NetPriority")]
	protected float NetPriority
	{
		get
		{
			CheckDestroyed();
			if (!NetPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetPriority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NetPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NetPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:NetPriority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NetPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21673647294906916uL)]
	[UMetaPath("/Script/Engine.Actor:Instigator")]
	public APawn Instigator
	{
		get
		{
			CheckDestroyed();
			if (!Instigator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:Instigator");
				return null;
			}
			return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(base.Address, Instigator_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Instigator_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:Instigator");
			}
			else
			{
				UObjectMarshaler<APawn>.ToNative(IntPtr.Add(base.Address, Instigator_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862034460uL)]
	[UMetaPath("/Script/Engine.Actor:RootComponent")]
	public USceneComponent RootComponent
	{
		get
		{
			CheckDestroyed();
			if (!RootComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:RootComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, RootComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:RootComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, RootComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11272297360917013uL)]
	[UMetaPath("/Script/Engine.Actor:PivotOffset")]
	protected FVector PivotOffset
	{
		get
		{
			CheckDestroyed();
			if (!PivotOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:PivotOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PivotOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PivotOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:PivotOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PivotOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11483420773319188uL)]
	[UMetaPath("/Script/Engine.Actor:ActorGuid")]
	protected Guid ActorGuid
	{
		get
		{
			CheckDestroyed();
			if (!ActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:ActorGuid");
				return default(Guid);
			}
			return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(base.Address, ActorGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:ActorGuid");
			}
			else
			{
				BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(base.Address, ActorGuid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.Actor:SpriteScale")]
	public float SpriteScale
	{
		get
		{
			CheckDestroyed();
			if (!SpriteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:SpriteScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpriteScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpriteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:SpriteScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpriteScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4507997673882117uL)]
	[UMetaPath("/Script/Engine.Actor:Tags")]
	public TArrayReadWrite<FName> Tags
	{
		get
		{
			CheckDestroyed();
			if (!Tags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:Tags");
				return null;
			}
			if (Tags_MarshalerCached == null)
			{
				Tags_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, Tags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return Tags_MarshalerCached.FromNative(IntPtr.Add(base.Address, Tags_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnTakeAnyDamage")]
	public FTakeAnyDamageSignature OnTakeAnyDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnTakeAnyDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnTakeAnyDamage");
				return new FTakeAnyDamageSignature();
			}
			if (OnTakeAnyDamage_DelegateCached == null)
			{
				OnTakeAnyDamage_DelegateCached = new FTakeAnyDamageSignature();
				OnTakeAnyDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTakeAnyDamage_Offset));
			}
			return OnTakeAnyDamage_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnTakePointDamage")]
	public FTakePointDamageSignature OnTakePointDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnTakePointDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnTakePointDamage");
				return new FTakePointDamageSignature();
			}
			if (OnTakePointDamage_DelegateCached == null)
			{
				OnTakePointDamage_DelegateCached = new FTakePointDamageSignature();
				OnTakePointDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTakePointDamage_Offset));
			}
			return OnTakePointDamage_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnTakeRadialDamage")]
	public FTakeRadialDamageSignature OnTakeRadialDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnTakeRadialDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnTakeRadialDamage");
				return new FTakeRadialDamageSignature();
			}
			if (OnTakeRadialDamage_DelegateCached == null)
			{
				OnTakeRadialDamage_DelegateCached = new FTakeRadialDamageSignature();
				OnTakeRadialDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTakeRadialDamage_Offset));
			}
			return OnTakeRadialDamage_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnActorBeginOverlap")]
	public FActorBeginOverlapSignature OnActorBeginOverlap
	{
		get
		{
			CheckDestroyed();
			if (!OnActorBeginOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnActorBeginOverlap");
				return new FActorBeginOverlapSignature();
			}
			if (OnActorBeginOverlap_DelegateCached == null)
			{
				OnActorBeginOverlap_DelegateCached = new FActorBeginOverlapSignature();
				OnActorBeginOverlap_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnActorBeginOverlap_Offset));
			}
			return OnActorBeginOverlap_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnActorEndOverlap")]
	public FActorEndOverlapSignature OnActorEndOverlap
	{
		get
		{
			CheckDestroyed();
			if (!OnActorEndOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnActorEndOverlap");
				return new FActorEndOverlapSignature();
			}
			if (OnActorEndOverlap_DelegateCached == null)
			{
				OnActorEndOverlap_DelegateCached = new FActorEndOverlapSignature();
				OnActorEndOverlap_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnActorEndOverlap_Offset));
			}
			return OnActorEndOverlap_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnBeginCursorOver")]
	public FActorBeginCursorOverSignature OnBeginCursorOver
	{
		get
		{
			CheckDestroyed();
			if (!OnBeginCursorOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnBeginCursorOver");
				return new FActorBeginCursorOverSignature();
			}
			if (OnBeginCursorOver_DelegateCached == null)
			{
				OnBeginCursorOver_DelegateCached = new FActorBeginCursorOverSignature();
				OnBeginCursorOver_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBeginCursorOver_Offset));
			}
			return OnBeginCursorOver_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnEndCursorOver")]
	public FActorEndCursorOverSignature OnEndCursorOver
	{
		get
		{
			CheckDestroyed();
			if (!OnEndCursorOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnEndCursorOver");
				return new FActorEndCursorOverSignature();
			}
			if (OnEndCursorOver_DelegateCached == null)
			{
				OnEndCursorOver_DelegateCached = new FActorEndCursorOverSignature();
				OnEndCursorOver_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndCursorOver_Offset));
			}
			return OnEndCursorOver_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnClicked")]
	public FActorOnClickedSignature OnClicked
	{
		get
		{
			CheckDestroyed();
			if (!OnClicked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnClicked");
				return new FActorOnClickedSignature();
			}
			if (OnClicked_DelegateCached == null)
			{
				OnClicked_DelegateCached = new FActorOnClickedSignature();
				OnClicked_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClicked_Offset));
			}
			return OnClicked_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnReleased")]
	public FActorOnReleasedSignature OnReleased
	{
		get
		{
			CheckDestroyed();
			if (!OnReleased_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnReleased");
				return new FActorOnReleasedSignature();
			}
			if (OnReleased_DelegateCached == null)
			{
				OnReleased_DelegateCached = new FActorOnReleasedSignature();
				OnReleased_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnReleased_Offset));
			}
			return OnReleased_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnInputTouchBegin")]
	public FActorOnInputTouchBeginSignature OnInputTouchBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnInputTouchBegin");
				return new FActorOnInputTouchBeginSignature();
			}
			if (OnInputTouchBegin_DelegateCached == null)
			{
				OnInputTouchBegin_DelegateCached = new FActorOnInputTouchBeginSignature();
				OnInputTouchBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchBegin_Offset));
			}
			return OnInputTouchBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnInputTouchEnd")]
	public FActorOnInputTouchEndSignature OnInputTouchEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnInputTouchEnd");
				return new FActorOnInputTouchEndSignature();
			}
			if (OnInputTouchEnd_DelegateCached == null)
			{
				OnInputTouchEnd_DelegateCached = new FActorOnInputTouchEndSignature();
				OnInputTouchEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchEnd_Offset));
			}
			return OnInputTouchEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnInputTouchEnter")]
	public FActorBeginTouchOverSignature OnInputTouchEnter
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchEnter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnInputTouchEnter");
				return new FActorBeginTouchOverSignature();
			}
			if (OnInputTouchEnter_DelegateCached == null)
			{
				OnInputTouchEnter_DelegateCached = new FActorBeginTouchOverSignature();
				OnInputTouchEnter_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchEnter_Offset));
			}
			return OnInputTouchEnter_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnInputTouchLeave")]
	public FActorEndTouchOverSignature OnInputTouchLeave
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchLeave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnInputTouchLeave");
				return new FActorEndTouchOverSignature();
			}
			if (OnInputTouchLeave_DelegateCached == null)
			{
				OnInputTouchLeave_DelegateCached = new FActorEndTouchOverSignature();
				OnInputTouchLeave_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchLeave_Offset));
			}
			return OnInputTouchLeave_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnActorHit")]
	public FActorHitSignature OnActorHit
	{
		get
		{
			CheckDestroyed();
			if (!OnActorHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnActorHit");
				return new FActorHitSignature();
			}
			if (OnActorHit_DelegateCached == null)
			{
				OnActorHit_DelegateCached = new FActorHitSignature();
				OnActorHit_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnActorHit_Offset));
			}
			return OnActorHit_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnDestroyed")]
	public FActorDestroyedSignature OnDestroyed
	{
		get
		{
			CheckDestroyed();
			if (!OnDestroyed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnDestroyed");
				return new FActorDestroyedSignature();
			}
			if (OnDestroyed_DelegateCached == null)
			{
				OnDestroyed_DelegateCached = new FActorDestroyedSignature();
				OnDestroyed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDestroyed_Offset));
			}
			return OnDestroyed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Actor:OnEndPlay")]
	public FActorEndPlaySignature OnEndPlay
	{
		get
		{
			CheckDestroyed();
			if (!OnEndPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Actor:OnEndPlay");
				return new FActorEndPlaySignature();
			}
			if (OnEndPlay_DelegateCached == null)
			{
				OnEndPlay_DelegateCached = new FActorEndPlaySignature();
				OnEndPlay_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndPlay_Offset));
			}
			return OnEndPlay_DelegateCached;
		}
	}

	public void PrintString(string str, FLinearColor textColor, bool printToLog = false, float duration = 1f)
	{
		USystemLibrary.PrintString(this, str, bPrintToScreen: true, printToLog, textColor, duration, FName.None);
	}

	public T GetComponentByClass<T>() where T : UActorComponent
	{
		return (T)GetComponentByClass(new TSubclassOf<UActorComponent>(UClass.GetClass<T>()));
	}

	private static void LoadNativeTypeInjected(IntPtr classAddress)
	{
		PrimaryActorTick_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "PrimaryActorTick");
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:WasRecentlyRendered")]
	public unsafe bool WasRecentlyRendered(float Tolerance = 0.2f)
	{
		CheckDestroyed();
		if (!WasRecentlyRendered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:WasRecentlyRendered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasRecentlyRendered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasRecentlyRendered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, WasRecentlyRendered_Tolerance_Offset), 0, WasRecentlyRendered_Tolerance_PropertyAddress.Address, Tolerance);
		NativeReflection.InvokeFunctionOptimized(base.Address, WasRecentlyRendered_FunctionAddress, intPtr, WasRecentlyRendered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasRecentlyRendered_ReturnValue_Offset), 0, WasRecentlyRendered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:TearOff")]
	public unsafe void TearOff()
	{
		CheckDestroyed();
		if (!TearOff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:TearOff");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TearOff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TearOff_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: TearOff_FunctionAddress, argsSize: TearOff_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetTickGroup")]
	public unsafe void SetTickGroup(ETickingGroup NewTickGroup)
	{
		CheckDestroyed();
		if (!SetTickGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetTickGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETickingGroup>.ToNative(IntPtr.Add(intPtr, SetTickGroup_NewTickGroup_Offset), 0, SetTickGroup_NewTickGroup_PropertyAddress.Address, NewTickGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickGroup_FunctionAddress, intPtr, SetTickGroup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetTickableWhenPaused")]
	public unsafe void SetTickableWhenPaused(bool bTickableWhenPaused)
	{
		CheckDestroyed();
		if (!SetTickableWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetTickableWhenPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickableWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickableWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTickableWhenPaused_bTickableWhenPaused_Offset), 0, SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress.Address, bTickableWhenPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickableWhenPaused_FunctionAddress, intPtr, SetTickableWhenPaused_ParamsSize);
	}

	[UFunction(Flags = 67240965u)]
	[UMetaPath("/Script/Engine.Actor:SetReplicates")]
	public unsafe void SetReplicates(bool bInReplicates)
	{
		CheckDestroyed();
		if (!SetReplicates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetReplicates");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReplicates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReplicates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReplicates_bInReplicates_Offset), 0, SetReplicates_bInReplicates_PropertyAddress.Address, bInReplicates);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReplicates_FunctionAddress, intPtr, SetReplicates_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:SetReplicateMovement")]
	public unsafe void SetReplicateMovement(bool bInReplicateMovement)
	{
		CheckDestroyed();
		if (!SetReplicateMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetReplicateMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReplicateMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReplicateMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReplicateMovement_bInReplicateMovement_Offset), 0, SetReplicateMovement_bInReplicateMovement_PropertyAddress.Address, bInReplicateMovement);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReplicateMovement_FunctionAddress, intPtr, SetReplicateMovement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetRayTracingGroupId")]
	public unsafe void SetRayTracingGroupId(int InRaytracingGroupId)
	{
		CheckDestroyed();
		if (!SetRayTracingGroupId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetRayTracingGroupId");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayTracingGroupId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayTracingGroupId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRayTracingGroupId_InRaytracingGroupId_Offset), 0, SetRayTracingGroupId_InRaytracingGroupId_PropertyAddress.Address, InRaytracingGroupId);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRayTracingGroupId_FunctionAddress, intPtr, SetRayTracingGroupId_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:SetOwner")]
	public unsafe void SetOwner(AActor NewOwner)
	{
		CheckDestroyed();
		if (!SetOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetOwner");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetOwner_NewOwner_Offset), 0, SetOwner_NewOwner_PropertyAddress.Address, NewOwner);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOwner_FunctionAddress, intPtr, SetOwner_ParamsSize);
	}

	[UFunction(Flags = 67240965u)]
	[UMetaPath("/Script/Engine.Actor:SetNetDormancy")]
	public unsafe void SetNetDormancy(ENetDormancy NewDormancy)
	{
		CheckDestroyed();
		if (!SetNetDormancy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetNetDormancy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNetDormancy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNetDormancy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENetDormancy>.ToNative(IntPtr.Add(intPtr, SetNetDormancy_NewDormancy_Offset), 0, SetNetDormancy_NewDormancy_PropertyAddress.Address, NewDormancy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNetDormancy_FunctionAddress, intPtr, SetNetDormancy_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:SetLifeSpan")]
	public unsafe void SetLifeSpan(float InLifespan)
	{
		CheckDestroyed();
		if (!SetLifeSpan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetLifeSpan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLifeSpan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLifeSpan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLifeSpan_InLifespan_Offset), 0, SetLifeSpan_InLifespan_PropertyAddress.Address, InLifespan);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLifeSpan_FunctionAddress, intPtr, SetLifeSpan_ParamsSize);
	}

	[UFunction(Flags = 604111872u)]
	[UMetaPath("/Script/Engine.Actor:SetIsTemporarilyHiddenInEditor")]
	public unsafe void SetIsTemporarilyHiddenInEditor(bool bIsHidden)
	{
		CheckDestroyed();
		if (!SetIsTemporarilyHiddenInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetIsTemporarilyHiddenInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsTemporarilyHiddenInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsTemporarilyHiddenInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsTemporarilyHiddenInEditor_bIsHidden_Offset), 0, SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress.Address, bIsHidden);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsTemporarilyHiddenInEditor_FunctionAddress, intPtr, SetIsTemporarilyHiddenInEditor_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/Engine.Actor:SetFolderPath")]
	public unsafe void SetFolderPath(FName NewFolderPath)
	{
		CheckDestroyed();
		if (!SetFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetFolderPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFolderPath_NewFolderPath_Offset), 0, SetFolderPath_NewFolderPath_PropertyAddress.Address, NewFolderPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFolderPath_FunctionAddress, intPtr, SetFolderPath_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetAutoDestroyWhenFinished")]
	public unsafe void SetAutoDestroyWhenFinished(bool bVal)
	{
		CheckDestroyed();
		if (!SetAutoDestroyWhenFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetAutoDestroyWhenFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoDestroyWhenFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoDestroyWhenFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoDestroyWhenFinished_bVal_Offset), 0, SetAutoDestroyWhenFinished_bVal_PropertyAddress.Address, bVal);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoDestroyWhenFinished_FunctionAddress, intPtr, SetAutoDestroyWhenFinished_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetActorTickInterval")]
	public unsafe void SetActorTickInterval(float TickInterval)
	{
		CheckDestroyed();
		if (!SetActorTickInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorTickInterval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorTickInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorTickInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetActorTickInterval_TickInterval_Offset), 0, SetActorTickInterval_TickInterval_PropertyAddress.Address, TickInterval);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorTickInterval_FunctionAddress, intPtr, SetActorTickInterval_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetActorTickEnabled")]
	public unsafe void SetActorTickEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetActorTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorTickEnabled_bEnabled_Offset), 0, SetActorTickEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorTickEnabled_FunctionAddress, intPtr, SetActorTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.Actor:SetActorScale3D")]
	public unsafe void SetActorScale3D(FVector NewScale3D)
	{
		CheckDestroyed();
		if (!SetActorScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorScale3D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorScale3D_NewScale3D_Offset), 0, SetActorScale3D_NewScale3D_PropertyAddress.Address, NewScale3D);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorScale3D_FunctionAddress, intPtr, SetActorScale3D_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.Actor:SetActorRelativeScale3D")]
	public unsafe void SetActorRelativeScale3D(FVector NewRelativeScale)
	{
		CheckDestroyed();
		if (!SetActorRelativeScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorRelativeScale3D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRelativeScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRelativeScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorRelativeScale3D_NewRelativeScale_Offset), 0, SetActorRelativeScale3D_NewRelativeScale_PropertyAddress.Address, NewRelativeScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorRelativeScale3D_FunctionAddress, intPtr, SetActorRelativeScale3D_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Engine.Actor:SetActorLabel")]
	public unsafe void SetActorLabel(string NewActorLabel, bool bMarkDirty = true)
	{
		CheckDestroyed();
		if (!SetActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorLabel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabel_NewActorLabel_Offset), 0, SetActorLabel_NewActorLabel_PropertyAddress.Address, NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabel_bMarkDirty_Offset), 0, SetActorLabel_bMarkDirty_PropertyAddress.Address, bMarkDirty);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorLabel_FunctionAddress, intPtr, SetActorLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActorLabel_NewActorLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:SetActorHiddenInGame")]
	public unsafe void SetActorHiddenInGame(bool bNewHidden)
	{
		CheckDestroyed();
		if (!SetActorHiddenInGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorHiddenInGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorHiddenInGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorHiddenInGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorHiddenInGame_bNewHidden_Offset), 0, SetActorHiddenInGame_bNewHidden_PropertyAddress.Address, bNewHidden);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorHiddenInGame_FunctionAddress, intPtr, SetActorHiddenInGame_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:SetActorEnableCollision")]
	public unsafe void SetActorEnableCollision(bool bNewActorEnableCollision)
	{
		CheckDestroyed();
		if (!SetActorEnableCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:SetActorEnableCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorEnableCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorEnableCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorEnableCollision_bNewActorEnableCollision_Offset), 0, SetActorEnableCollision_bNewActorEnableCollision_PropertyAddress.Address, bNewActorEnableCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorEnableCollision_FunctionAddress, intPtr, SetActorEnableCollision_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:RemoveTickPrerequisiteComponent")]
	public unsafe void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckDestroyed();
		if (!RemoveTickPrerequisiteComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:RemoveTickPrerequisiteComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTickPrerequisiteComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTickPrerequisiteComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset), 0, RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress.Address, PrerequisiteComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTickPrerequisiteComponent_FunctionAddress, intPtr, RemoveTickPrerequisiteComponent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:RemoveTickPrerequisiteActor")]
	public unsafe void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckDestroyed();
		if (!RemoveTickPrerequisiteActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:RemoveTickPrerequisiteActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTickPrerequisiteActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTickPrerequisiteActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveTickPrerequisiteActor_PrerequisiteActor_Offset), 0, RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress.Address, PrerequisiteActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTickPrerequisiteActor_FunctionAddress, intPtr, RemoveTickPrerequisiteActor_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveTick")]
	public unsafe void ReceiveTick(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveTick");
			return;
		}
		if (ReceiveTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_InstanceFunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_FunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	[UFunction(Flags = 146933764u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveRadialDamage")]
	public unsafe void ReceiveRadialDamage(float DamageReceived, UDamageType DamageType, FVector Origin, FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveRadialDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveRadialDamage");
			return;
		}
		if (ReceiveRadialDamage_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveRadialDamage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveRadialDamage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveRadialDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveRadialDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageReceived_Offset), 0, ReceiveRadialDamage_DamageReceived_PropertyAddress.Address, DamageReceived);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageType_Offset), 0, ReceiveRadialDamage_DamageType_PropertyAddress.Address, DamageType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_Origin_Offset), 0, ReceiveRadialDamage_Origin_PropertyAddress.Address, Origin);
		NativeReflection.InitializeValue_InContainer(ReceiveRadialDamage_HitInfo_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_HitInfo_Offset), 0, ReceiveRadialDamage_HitInfo_PropertyAddress.Address, HitInfo);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_InstigatedBy_Offset), 0, ReceiveRadialDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageCauser_Offset), 0, ReceiveRadialDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveRadialDamage_InstanceFunctionAddress, intPtr, ReceiveRadialDamage_ParamsSize);
	}

	protected unsafe virtual void ReceiveRadialDamage_Implementation(float DamageReceived, UDamageType DamageType, FVector Origin, FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveRadialDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveRadialDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveRadialDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveRadialDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageReceived_Offset), 0, ReceiveRadialDamage_DamageReceived_PropertyAddress.Address, DamageReceived);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageType_Offset), 0, ReceiveRadialDamage_DamageType_PropertyAddress.Address, DamageType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_Origin_Offset), 0, ReceiveRadialDamage_Origin_PropertyAddress.Address, Origin);
		NativeReflection.InitializeValue_InContainer(ReceiveRadialDamage_HitInfo_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_HitInfo_Offset), 0, ReceiveRadialDamage_HitInfo_PropertyAddress.Address, HitInfo);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_InstigatedBy_Offset), 0, ReceiveRadialDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveRadialDamage_DamageCauser_Offset), 0, ReceiveRadialDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveRadialDamage_FunctionAddress, intPtr, ReceiveRadialDamage_ParamsSize);
	}

	[UFunction(Flags = 146933764u)]
	[UMetaPath("/Script/Engine.Actor:ReceivePointDamage")]
	public unsafe void ReceivePointDamage(float Damage, UDamageType DamageType, FVector HitLocation, FVector HitNormal, UPrimitiveComponent HitComponent, FName BoneName, FVector ShotFromDirection, AController InstigatedBy, AActor DamageCauser, FHitResult HitInfo)
	{
		CheckDestroyed();
		if (!ReceivePointDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceivePointDamage");
			return;
		}
		if (ReceivePointDamage_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePointDamage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePointDamage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePointDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePointDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_Damage_Offset), 0, ReceivePointDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_DamageType_Offset), 0, ReceivePointDamage_DamageType_PropertyAddress.Address, DamageType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitLocation_Offset), 0, ReceivePointDamage_HitLocation_PropertyAddress.Address, HitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitNormal_Offset), 0, ReceivePointDamage_HitNormal_PropertyAddress.Address, HitNormal);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitComponent_Offset), 0, ReceivePointDamage_HitComponent_PropertyAddress.Address, HitComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_BoneName_Offset), 0, ReceivePointDamage_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_ShotFromDirection_Offset), 0, ReceivePointDamage_ShotFromDirection_PropertyAddress.Address, ShotFromDirection);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_InstigatedBy_Offset), 0, ReceivePointDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_DamageCauser_Offset), 0, ReceivePointDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InitializeValue_InContainer(ReceivePointDamage_HitInfo_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitInfo_Offset), 0, ReceivePointDamage_HitInfo_PropertyAddress.Address, HitInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePointDamage_InstanceFunctionAddress, intPtr, ReceivePointDamage_ParamsSize);
	}

	protected unsafe virtual void ReceivePointDamage_Implementation(float Damage, UDamageType DamageType, FVector HitLocation, FVector HitNormal, UPrimitiveComponent HitComponent, FName BoneName, FVector ShotFromDirection, AController InstigatedBy, AActor DamageCauser, FHitResult HitInfo)
	{
		CheckDestroyed();
		if (!ReceivePointDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceivePointDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePointDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePointDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_Damage_Offset), 0, ReceivePointDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_DamageType_Offset), 0, ReceivePointDamage_DamageType_PropertyAddress.Address, DamageType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitLocation_Offset), 0, ReceivePointDamage_HitLocation_PropertyAddress.Address, HitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitNormal_Offset), 0, ReceivePointDamage_HitNormal_PropertyAddress.Address, HitNormal);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitComponent_Offset), 0, ReceivePointDamage_HitComponent_PropertyAddress.Address, HitComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_BoneName_Offset), 0, ReceivePointDamage_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_ShotFromDirection_Offset), 0, ReceivePointDamage_ShotFromDirection_PropertyAddress.Address, ShotFromDirection);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_InstigatedBy_Offset), 0, ReceivePointDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_DamageCauser_Offset), 0, ReceivePointDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InitializeValue_InContainer(ReceivePointDamage_HitInfo_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceivePointDamage_HitInfo_Offset), 0, ReceivePointDamage_HitInfo_PropertyAddress.Address, HitInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePointDamage_FunctionAddress, intPtr, ReceivePointDamage_ParamsSize);
	}

	[UFunction(Flags = 146933760u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveHit")]
	public unsafe void ReceiveHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
	{
		CheckDestroyed();
		if (!ReceiveHit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveHit");
			return;
		}
		if (ReceiveHit_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveHit_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveHit");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceiveHit_MyComp_Offset), 0, ReceiveHit_MyComp_PropertyAddress.Address, MyComp);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveHit_Other_Offset), 0, ReceiveHit_Other_PropertyAddress.Address, Other);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceiveHit_OtherComp_Offset), 0, ReceiveHit_OtherComp_PropertyAddress.Address, OtherComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReceiveHit_bSelfMoved_Offset), 0, ReceiveHit_bSelfMoved_PropertyAddress.Address, bSelfMoved);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_HitLocation_Offset), 0, ReceiveHit_HitLocation_PropertyAddress.Address, HitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_HitNormal_Offset), 0, ReceiveHit_HitNormal_PropertyAddress.Address, HitNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_NormalImpulse_Offset), 0, ReceiveHit_NormalImpulse_PropertyAddress.Address, NormalImpulse);
		NativeReflection.InitializeValue_InContainer(ReceiveHit_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveHit_Hit_Offset), 0, ReceiveHit_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHit_InstanceFunctionAddress, intPtr, ReceiveHit_ParamsSize);
	}

	protected unsafe virtual void ReceiveHit_Implementation(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
	{
		CheckDestroyed();
		if (!ReceiveHit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveHit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveHit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveHit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceiveHit_MyComp_Offset), 0, ReceiveHit_MyComp_PropertyAddress.Address, MyComp);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveHit_Other_Offset), 0, ReceiveHit_Other_PropertyAddress.Address, Other);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ReceiveHit_OtherComp_Offset), 0, ReceiveHit_OtherComp_PropertyAddress.Address, OtherComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReceiveHit_bSelfMoved_Offset), 0, ReceiveHit_bSelfMoved_PropertyAddress.Address, bSelfMoved);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_HitLocation_Offset), 0, ReceiveHit_HitLocation_PropertyAddress.Address, HitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_HitNormal_Offset), 0, ReceiveHit_HitNormal_PropertyAddress.Address, HitNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ReceiveHit_NormalImpulse_Offset), 0, ReceiveHit_NormalImpulse_PropertyAddress.Address, NormalImpulse);
		NativeReflection.InitializeValue_InContainer(ReceiveHit_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, ReceiveHit_Hit_Offset), 0, ReceiveHit_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveHit_FunctionAddress, intPtr, ReceiveHit_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveEndPlay")]
	protected unsafe void ReceiveEndPlay(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveEndPlay");
			return;
		}
		if (ReceiveEndPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveEndPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveEndPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveEndPlay_InstanceFunctionAddress, intPtr, ReceiveEndPlay_ParamsSize);
	}

	protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!ReceiveEndPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveEndPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveEndPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveEndPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveEndPlay_FunctionAddress, intPtr, ReceiveEndPlay_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveDestroyed")]
	public unsafe void ReceiveDestroyed()
	{
		CheckDestroyed();
		if (!ReceiveDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveDestroyed");
			return;
		}
		if (ReceiveDestroyed_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveDestroyed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveDestroyed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDestroyed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveDestroyed_InstanceFunctionAddress, argsSize: ReceiveDestroyed_ParamsSize);
	}

	protected unsafe virtual void ReceiveDestroyed_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveDestroyed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDestroyed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveDestroyed_FunctionAddress, argsSize: ReceiveDestroyed_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveBeginPlay")]
	protected unsafe void ReceiveBeginPlay()
	{
		CheckDestroyed();
		if (!ReceiveBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveBeginPlay");
			return;
		}
		if (ReceiveBeginPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveBeginPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveBeginPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginPlay_InstanceFunctionAddress, argsSize: ReceiveBeginPlay_ParamsSize);
	}

	protected unsafe virtual void ReceiveBeginPlay_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveBeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveBeginPlay_FunctionAddress, argsSize: ReceiveBeginPlay_ParamsSize);
	}

	[UFunction(Flags = 134350852u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveAnyDamage")]
	public unsafe void ReceiveAnyDamage(float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveAnyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveAnyDamage");
			return;
		}
		if (ReceiveAnyDamage_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveAnyDamage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveAnyDamage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAnyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAnyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_Damage_Offset), 0, ReceiveAnyDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_DamageType_Offset), 0, ReceiveAnyDamage_DamageType_PropertyAddress.Address, DamageType);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_InstigatedBy_Offset), 0, ReceiveAnyDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_DamageCauser_Offset), 0, ReceiveAnyDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAnyDamage_InstanceFunctionAddress, intPtr, ReceiveAnyDamage_ParamsSize);
	}

	protected unsafe virtual void ReceiveAnyDamage_Implementation(float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveAnyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveAnyDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAnyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAnyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_Damage_Offset), 0, ReceiveAnyDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_DamageType_Offset), 0, ReceiveAnyDamage_DamageType_PropertyAddress.Address, DamageType);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_InstigatedBy_Offset), 0, ReceiveAnyDamage_InstigatedBy_PropertyAddress.Address, InstigatedBy);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveAnyDamage_DamageCauser_Offset), 0, ReceiveAnyDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAnyDamage_FunctionAddress, intPtr, ReceiveAnyDamage_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnReleased")]
	public unsafe void ReceiveActorOnReleased(FKey ButtonReleased)
	{
		CheckDestroyed();
		if (!ReceiveActorOnReleased_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnReleased");
			return;
		}
		if (ReceiveActorOnReleased_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnReleased_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnReleased");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnReleased_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnReleased_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReceiveActorOnReleased_ButtonReleased_Offset), 0, ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, ButtonReleased);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnReleased_InstanceFunctionAddress, intPtr, ReceiveActorOnReleased_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ReceiveActorOnReleased_Implementation(FKey ButtonReleased)
	{
		CheckDestroyed();
		if (!ReceiveActorOnReleased_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnReleased");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnReleased_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnReleased_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReceiveActorOnReleased_ButtonReleased_Offset), 0, ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, ButtonReleased);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnReleased_FunctionAddress, intPtr, ReceiveActorOnReleased_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReceiveActorOnReleased_ButtonReleased_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnInputTouchLeave")]
	public unsafe void ReceiveActorOnInputTouchLeave(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchLeave");
			return;
		}
		if (ReceiveActorOnInputTouchLeave_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnInputTouchLeave_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnInputTouchLeave");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchLeave_FingerIndex_Offset), 0, ReceiveActorOnInputTouchLeave_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchLeave_InstanceFunctionAddress, intPtr, ReceiveActorOnInputTouchLeave_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorOnInputTouchLeave_Implementation(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchLeave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchLeave_FingerIndex_Offset), 0, ReceiveActorOnInputTouchLeave_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchLeave_FunctionAddress, intPtr, ReceiveActorOnInputTouchLeave_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnInputTouchEnter")]
	public unsafe void ReceiveActorOnInputTouchEnter(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchEnter");
			return;
		}
		if (ReceiveActorOnInputTouchEnter_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnInputTouchEnter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnInputTouchEnter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchEnter_FingerIndex_Offset), 0, ReceiveActorOnInputTouchEnter_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchEnter_InstanceFunctionAddress, intPtr, ReceiveActorOnInputTouchEnter_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorOnInputTouchEnter_Implementation(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchEnter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchEnter_FingerIndex_Offset), 0, ReceiveActorOnInputTouchEnter_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchEnter_FunctionAddress, intPtr, ReceiveActorOnInputTouchEnter_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnInputTouchEnd")]
	public unsafe void ReceiveActorOnInputTouchEnd(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchEnd");
			return;
		}
		if (ReceiveActorOnInputTouchEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnInputTouchEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnInputTouchEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchEnd_FingerIndex_Offset), 0, ReceiveActorOnInputTouchEnd_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchEnd_InstanceFunctionAddress, intPtr, ReceiveActorOnInputTouchEnd_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorOnInputTouchEnd_Implementation(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchEnd_FingerIndex_Offset), 0, ReceiveActorOnInputTouchEnd_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchEnd_FunctionAddress, intPtr, ReceiveActorOnInputTouchEnd_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnInputTouchBegin")]
	public unsafe void ReceiveActorOnInputTouchBegin(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchBegin");
			return;
		}
		if (ReceiveActorOnInputTouchBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnInputTouchBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnInputTouchBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchBegin_FingerIndex_Offset), 0, ReceiveActorOnInputTouchBegin_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchBegin_InstanceFunctionAddress, intPtr, ReceiveActorOnInputTouchBegin_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorOnInputTouchBegin_Implementation(ETouchIndex FingerIndex)
	{
		CheckDestroyed();
		if (!ReceiveActorOnInputTouchBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnInputTouchBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnInputTouchBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnInputTouchBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, ReceiveActorOnInputTouchBegin_FingerIndex_Offset), 0, ReceiveActorOnInputTouchBegin_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnInputTouchBegin_FunctionAddress, intPtr, ReceiveActorOnInputTouchBegin_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorOnClicked")]
	public unsafe void ReceiveActorOnClicked(FKey ButtonPressed)
	{
		CheckDestroyed();
		if (!ReceiveActorOnClicked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnClicked");
			return;
		}
		if (ReceiveActorOnClicked_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorOnClicked_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorOnClicked");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnClicked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnClicked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReceiveActorOnClicked_ButtonPressed_Offset), 0, ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, ButtonPressed);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnClicked_InstanceFunctionAddress, intPtr, ReceiveActorOnClicked_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ReceiveActorOnClicked_Implementation(FKey ButtonPressed)
	{
		CheckDestroyed();
		if (!ReceiveActorOnClicked_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorOnClicked");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorOnClicked_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorOnClicked_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, ReceiveActorOnClicked_ButtonPressed_Offset), 0, ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, ButtonPressed);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorOnClicked_FunctionAddress, intPtr, ReceiveActorOnClicked_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReceiveActorOnClicked_ButtonPressed_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorEndOverlap")]
	public unsafe void ReceiveActorEndOverlap(AActor OtherActor)
	{
		CheckDestroyed();
		if (!ReceiveActorEndOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorEndOverlap");
			return;
		}
		if (ReceiveActorEndOverlap_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorEndOverlap_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorEndOverlap");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorEndOverlap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorEndOverlap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActorEndOverlap_OtherActor_Offset), 0, ReceiveActorEndOverlap_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorEndOverlap_InstanceFunctionAddress, intPtr, ReceiveActorEndOverlap_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorEndOverlap_Implementation(AActor OtherActor)
	{
		CheckDestroyed();
		if (!ReceiveActorEndOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorEndOverlap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorEndOverlap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorEndOverlap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActorEndOverlap_OtherActor_Offset), 0, ReceiveActorEndOverlap_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorEndOverlap_FunctionAddress, intPtr, ReceiveActorEndOverlap_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorEndCursorOver")]
	public unsafe void ReceiveActorEndCursorOver()
	{
		CheckDestroyed();
		if (!ReceiveActorEndCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorEndCursorOver");
			return;
		}
		if (ReceiveActorEndCursorOver_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorEndCursorOver_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorEndCursorOver");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorEndCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorEndCursorOver_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveActorEndCursorOver_InstanceFunctionAddress, argsSize: ReceiveActorEndCursorOver_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorEndCursorOver_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveActorEndCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorEndCursorOver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorEndCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorEndCursorOver_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveActorEndCursorOver_FunctionAddress, argsSize: ReceiveActorEndCursorOver_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorBeginOverlap")]
	public unsafe void ReceiveActorBeginOverlap(AActor OtherActor)
	{
		CheckDestroyed();
		if (!ReceiveActorBeginOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorBeginOverlap");
			return;
		}
		if (ReceiveActorBeginOverlap_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorBeginOverlap_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorBeginOverlap");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorBeginOverlap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorBeginOverlap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActorBeginOverlap_OtherActor_Offset), 0, ReceiveActorBeginOverlap_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorBeginOverlap_InstanceFunctionAddress, intPtr, ReceiveActorBeginOverlap_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
	{
		CheckDestroyed();
		if (!ReceiveActorBeginOverlap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorBeginOverlap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorBeginOverlap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorBeginOverlap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActorBeginOverlap_OtherActor_Offset), 0, ReceiveActorBeginOverlap_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActorBeginOverlap_FunctionAddress, intPtr, ReceiveActorBeginOverlap_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Actor:ReceiveActorBeginCursorOver")]
	public unsafe void ReceiveActorBeginCursorOver()
	{
		CheckDestroyed();
		if (!ReceiveActorBeginCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorBeginCursorOver");
			return;
		}
		if (ReceiveActorBeginCursorOver_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActorBeginCursorOver_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActorBeginCursorOver");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorBeginCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorBeginCursorOver_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveActorBeginCursorOver_InstanceFunctionAddress, argsSize: ReceiveActorBeginCursorOver_ParamsSize);
	}

	protected unsafe virtual void ReceiveActorBeginCursorOver_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveActorBeginCursorOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ReceiveActorBeginCursorOver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActorBeginCursorOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActorBeginCursorOver_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveActorBeginCursorOver_FunctionAddress, argsSize: ReceiveActorBeginCursorOver_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:PrestreamTextures")]
	public unsafe void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups = 0)
	{
		CheckDestroyed();
		if (!PrestreamTextures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:PrestreamTextures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrestreamTextures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrestreamTextures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PrestreamTextures_Seconds_Offset), 0, PrestreamTextures_Seconds_PropertyAddress.Address, Seconds);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PrestreamTextures_bEnableStreaming_Offset), 0, PrestreamTextures_bEnableStreaming_PropertyAddress.Address, bEnableStreaming);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PrestreamTextures_CinematicTextureGroups_Offset), 0, PrestreamTextures_CinematicTextureGroups_PropertyAddress.Address, CinematicTextureGroups);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrestreamTextures_FunctionAddress, intPtr, PrestreamTextures_ParamsSize);
	}

	[UFunction(Flags = 75629573u)]
	[UMetaPath("/Script/Engine.Actor:MakeNoise")]
	public unsafe void MakeNoise(float Loudness, APawn NoiseInstigator, FVector NoiseLocation, float MaxRange, FName Tag)
	{
		CheckDestroyed();
		if (!MakeNoise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:MakeNoise");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeNoise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeNoise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeNoise_Loudness_Offset), 0, MakeNoise_Loudness_PropertyAddress.Address, Loudness);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, MakeNoise_NoiseInstigator_Offset), 0, MakeNoise_NoiseInstigator_PropertyAddress.Address, NoiseInstigator);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MakeNoise_NoiseLocation_Offset), 0, MakeNoise_NoiseLocation_PropertyAddress.Address, NoiseLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeNoise_MaxRange_Offset), 0, MakeNoise_MaxRange_PropertyAddress.Address, MaxRange);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MakeNoise_Tag_Offset), 0, MakeNoise_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeNoise_FunctionAddress, intPtr, MakeNoise_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_TeleportTo")]
	[UMetaPath("/Script/Engine.Actor:K2_TeleportTo")]
	public unsafe bool Teleport(FVector DestLocation, FRotator DestRotation)
	{
		CheckDestroyed();
		if (!Teleport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_TeleportTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Teleport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Teleport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Teleport_DestLocation_Offset), 0, Teleport_DestLocation_PropertyAddress.Address, DestLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, Teleport_DestRotation_Offset), 0, Teleport_DestRotation_PropertyAddress.Address, DestRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, Teleport_FunctionAddress, intPtr, Teleport_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Teleport_ReturnValue_Offset), 0, Teleport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorTransform")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorTransform")]
	public unsafe bool SetActorTransform(FTransform NewTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorTransform");
			SweepHitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetActorTransform_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetActorTransform_NewTransform_Offset), 0, SetActorTransform_NewTransform_PropertyAddress.Address, NewTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorTransform_bSweep_Offset), 0, SetActorTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorTransform_bTeleport_Offset), 0, SetActorTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorTransform_FunctionAddress, intPtr, SetActorTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorTransform_SweepHitResult_Offset), 0, SetActorTransform_SweepHitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorTransform_ReturnValue_Offset), 0, SetActorTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_SetActorRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorRotation")]
	public unsafe bool SetActorRotation(FRotator NewRotation, bool bTeleportPhysics)
	{
		CheckDestroyed();
		if (!SetActorRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorRotation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetActorRotation_NewRotation_Offset), 0, SetActorRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRotation_bTeleportPhysics_Offset), 0, SetActorRotation_bTeleportPhysics_PropertyAddress.Address, bTeleportPhysics);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorRotation_FunctionAddress, intPtr, SetActorRotation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorRotation_ReturnValue_Offset), 0, SetActorRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorRelativeTransform")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorRelativeTransform")]
	public unsafe void SetActorRelativeTransform(FTransform NewRelativeTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorRelativeTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetActorRelativeTransform_NewRelativeTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetActorRelativeTransform_NewRelativeTransform_Offset), 0, SetActorRelativeTransform_NewRelativeTransform_PropertyAddress.Address, NewRelativeTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeTransform_bSweep_Offset), 0, SetActorRelativeTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorRelativeTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeTransform_bTeleport_Offset), 0, SetActorRelativeTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorRelativeTransform_FunctionAddress, intPtr, SetActorRelativeTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorRelativeTransform_SweepHitResult_Offset), 0, SetActorRelativeTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorRelativeRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorRelativeRotation")]
	public unsafe void SetActorRelativeRotation(FRotator NewRelativeRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorRelativeRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorRelativeRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRelativeRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRelativeRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetActorRelativeRotation_NewRelativeRotation_Offset), 0, SetActorRelativeRotation_NewRelativeRotation_PropertyAddress.Address, NewRelativeRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeRotation_bSweep_Offset), 0, SetActorRelativeRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorRelativeRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeRotation_bTeleport_Offset), 0, SetActorRelativeRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorRelativeRotation_FunctionAddress, intPtr, SetActorRelativeRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorRelativeRotation_SweepHitResult_Offset), 0, SetActorRelativeRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorRelativeLocation")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorRelativeLocation")]
	public unsafe void SetActorRelativeLocation(FVector NewRelativeLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorRelativeLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorRelativeLocation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorRelativeLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorRelativeLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorRelativeLocation_NewRelativeLocation_Offset), 0, SetActorRelativeLocation_NewRelativeLocation_PropertyAddress.Address, NewRelativeLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeLocation_bSweep_Offset), 0, SetActorRelativeLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorRelativeLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorRelativeLocation_bTeleport_Offset), 0, SetActorRelativeLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorRelativeLocation_FunctionAddress, intPtr, SetActorRelativeLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorRelativeLocation_SweepHitResult_Offset), 0, SetActorRelativeLocation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorLocationAndRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorLocationAndRotation")]
	public unsafe bool SetActorLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorLocationAndRotation");
			SweepHitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_NewLocation_Offset), 0, SetActorLocationAndRotation_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_NewRotation_Offset), 0, SetActorLocationAndRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_bSweep_Offset), 0, SetActorLocationAndRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorLocationAndRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_bTeleport_Offset), 0, SetActorLocationAndRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorLocationAndRotation_FunctionAddress, intPtr, SetActorLocationAndRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_SweepHitResult_Offset), 0, SetActorLocationAndRotation_SweepHitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorLocationAndRotation_ReturnValue_Offset), 0, SetActorLocationAndRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetActorLocation")]
	[UMetaPath("/Script/Engine.Actor:K2_SetActorLocation")]
	public unsafe bool SetActorLocation(FVector NewLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetActorLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_SetActorLocation");
			SweepHitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorLocation_NewLocation_Offset), 0, SetActorLocation_NewLocation_PropertyAddress.Address, NewLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocation_bSweep_Offset), 0, SetActorLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocation_bTeleport_Offset), 0, SetActorLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorLocation_FunctionAddress, intPtr, SetActorLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorLocation_SweepHitResult_Offset), 0, SetActorLocation_SweepHitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorLocation_ReturnValue_Offset), 0, SetActorLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnReset")]
	[UMetaPath("/Script/Engine.Actor:K2_OnReset")]
	public unsafe void OnReset()
	{
		CheckDestroyed();
		if (!OnReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnReset");
			return;
		}
		if (OnReset_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnReset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnReset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnReset_InstanceFunctionAddress, argsSize: OnReset_ParamsSize);
	}

	protected unsafe virtual void OnReset_Implementation()
	{
		CheckDestroyed();
		if (!OnReset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnReset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnReset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnReset_FunctionAddress, argsSize: OnReset_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnEndViewTarget")]
	[UMetaPath("/Script/Engine.Actor:K2_OnEndViewTarget")]
	public unsafe void OnEndViewTarget(APlayerController PC)
	{
		CheckDestroyed();
		if (!OnEndViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnEndViewTarget");
			return;
		}
		if (OnEndViewTarget_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEndViewTarget_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnEndViewTarget");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnEndViewTarget_PC_Offset), 0, OnEndViewTarget_PC_PropertyAddress.Address, PC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndViewTarget_InstanceFunctionAddress, intPtr, OnEndViewTarget_ParamsSize);
	}

	protected unsafe virtual void OnEndViewTarget_Implementation(APlayerController PC)
	{
		CheckDestroyed();
		if (!OnEndViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnEndViewTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnEndViewTarget_PC_Offset), 0, OnEndViewTarget_PC_PropertyAddress.Address, PC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndViewTarget_FunctionAddress, intPtr, OnEndViewTarget_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnBecomeViewTarget")]
	[UMetaPath("/Script/Engine.Actor:K2_OnBecomeViewTarget")]
	public unsafe void OnBecomeViewTarget(APlayerController PC)
	{
		CheckDestroyed();
		if (!OnBecomeViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnBecomeViewTarget");
			return;
		}
		if (OnBecomeViewTarget_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBecomeViewTarget_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnBecomeViewTarget");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBecomeViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBecomeViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnBecomeViewTarget_PC_Offset), 0, OnBecomeViewTarget_PC_PropertyAddress.Address, PC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnBecomeViewTarget_InstanceFunctionAddress, intPtr, OnBecomeViewTarget_ParamsSize);
	}

	protected unsafe virtual void OnBecomeViewTarget_Implementation(APlayerController PC)
	{
		CheckDestroyed();
		if (!OnBecomeViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_OnBecomeViewTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBecomeViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBecomeViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, OnBecomeViewTarget_PC_Offset), 0, OnBecomeViewTarget_PC_PropertyAddress.Address, PC);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnBecomeViewTarget_FunctionAddress, intPtr, OnBecomeViewTarget_ParamsSize);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetRootComponent")]
	[UMetaPath("/Script/Engine.Actor:K2_GetRootComponent")]
	public unsafe USceneComponent GetRootComponent()
	{
		CheckDestroyed();
		if (!GetRootComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_GetRootComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRootComponent_FunctionAddress, intPtr, GetRootComponent_ParamsSize);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GetRootComponent_ReturnValue_Offset), 0, GetRootComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetComponentsByClass")]
	[UMetaPath("/Script/Engine.Actor:K2_GetComponentsByClass")]
	public unsafe List<UActorComponent> GetComponentsByClass(TSubclassOf<UActorComponent> ComponentClass)
	{
		CheckDestroyed();
		if (!GetComponentsByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_GetComponentsByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentsByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentsByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, GetComponentsByClass_ComponentClass_Offset), 0, GetComponentsByClass_ComponentClass_PropertyAddress.Address, ComponentClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentsByClass_FunctionAddress, intPtr, GetComponentsByClass_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetComponentsByClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetComponentsByClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetComponentsByClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetActorRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_GetActorRotation")]
	public unsafe FRotator GetActorRotation()
	{
		CheckDestroyed();
		if (!GetActorRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_GetActorRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorRotation_FunctionAddress, intPtr, GetActorRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetActorRotation_ReturnValue_Offset), 0, GetActorRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetActorLocation")]
	[UMetaPath("/Script/Engine.Actor:K2_GetActorLocation")]
	public unsafe FVector GetActorLocation()
	{
		CheckDestroyed();
		if (!GetActorLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_GetActorLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorLocation_FunctionAddress, intPtr, GetActorLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorLocation_ReturnValue_Offset), 0, GetActorLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_DetachFromActor")]
	[UMetaPath("/Script/Engine.Actor:K2_DetachFromActor")]
	public unsafe void DetachFromActor(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative)
	{
		CheckDestroyed();
		if (!DetachFromActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_DetachFromActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetachFromActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetachFromActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromActor_LocationRule_Offset), 0, DetachFromActor_LocationRule_PropertyAddress.Address, LocationRule);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromActor_RotationRule_Offset), 0, DetachFromActor_RotationRule_PropertyAddress.Address, RotationRule);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromActor_ScaleRule_Offset), 0, DetachFromActor_ScaleRule_PropertyAddress.Address, ScaleRule);
		NativeReflection.InvokeFunctionOptimized(base.Address, DetachFromActor_FunctionAddress, intPtr, DetachFromActor_ParamsSize);
	}

	[UFunction(Flags = 67240960u, OriginalName = "K2_DestroyActor")]
	[UMetaPath("/Script/Engine.Actor:K2_DestroyActor")]
	public unsafe void DestroyActor()
	{
		CheckDestroyed();
		if (!DestroyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_DestroyActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyActor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DestroyActor_FunctionAddress, argsSize: DestroyActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachToComponent")]
	[UMetaPath("/Script/Engine.Actor:K2_AttachToComponent")]
	public unsafe void AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachToComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AttachToComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachToComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachToComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, AttachToComponent_Parent_Offset), 0, AttachToComponent_Parent_PropertyAddress.Address, Parent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AttachToComponent_SocketName_Offset), 0, AttachToComponent_SocketName_PropertyAddress.Address, SocketName);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToComponent_LocationRule_Offset), 0, AttachToComponent_LocationRule_PropertyAddress.Address, LocationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToComponent_RotationRule_Offset), 0, AttachToComponent_RotationRule_PropertyAddress.Address, RotationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToComponent_ScaleRule_Offset), 0, AttachToComponent_ScaleRule_PropertyAddress.Address, ScaleRule);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AttachToComponent_bWeldSimulatedBodies_Offset), 0, AttachToComponent_bWeldSimulatedBodies_PropertyAddress.Address, bWeldSimulatedBodies);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachToComponent_FunctionAddress, intPtr, AttachToComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachToActor")]
	[UMetaPath("/Script/Engine.Actor:K2_AttachToActor")]
	public unsafe void AttachToActor(AActor ParentActor, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AttachToActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AttachToActor_ParentActor_Offset), 0, AttachToActor_ParentActor_PropertyAddress.Address, ParentActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AttachToActor_SocketName_Offset), 0, AttachToActor_SocketName_PropertyAddress.Address, SocketName);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToActor_LocationRule_Offset), 0, AttachToActor_LocationRule_PropertyAddress.Address, LocationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToActor_RotationRule_Offset), 0, AttachToActor_RotationRule_PropertyAddress.Address, RotationRule);
		EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(intPtr, AttachToActor_ScaleRule_Offset), 0, AttachToActor_ScaleRule_PropertyAddress.Address, ScaleRule);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AttachToActor_bWeldSimulatedBodies_Offset), 0, AttachToActor_bWeldSimulatedBodies_PropertyAddress.Address, bWeldSimulatedBodies);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachToActor_FunctionAddress, intPtr, AttachToActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachRootComponentToActor")]
	[UMetaPath("/Script/Engine.Actor:K2_AttachRootComponentToActor")]
	public unsafe void AttachRootComponentToActor(AActor InParentActor, FName InSocketName, EAttachLocation AttachLocationType, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachRootComponentToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AttachRootComponentToActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachRootComponentToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachRootComponentToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AttachRootComponentToActor_InParentActor_Offset), 0, AttachRootComponentToActor_InParentActor_PropertyAddress.Address, InParentActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AttachRootComponentToActor_InSocketName_Offset), 0, AttachRootComponentToActor_InSocketName_PropertyAddress.Address, InSocketName);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, AttachRootComponentToActor_AttachLocationType_Offset), 0, AttachRootComponentToActor_AttachLocationType_PropertyAddress.Address, AttachLocationType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AttachRootComponentToActor_bWeldSimulatedBodies_Offset), 0, AttachRootComponentToActor_bWeldSimulatedBodies_PropertyAddress.Address, bWeldSimulatedBodies);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachRootComponentToActor_FunctionAddress, intPtr, AttachRootComponentToActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachRootComponentTo")]
	[UMetaPath("/Script/Engine.Actor:K2_AttachRootComponentTo")]
	public unsafe void AttachRootComponentTo(USceneComponent InParent, FName InSocketName, EAttachLocation AttachLocationType, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachRootComponentTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AttachRootComponentTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachRootComponentTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachRootComponentTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, AttachRootComponentTo_InParent_Offset), 0, AttachRootComponentTo_InParent_PropertyAddress.Address, InParent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AttachRootComponentTo_InSocketName_Offset), 0, AttachRootComponentTo_InSocketName_PropertyAddress.Address, InSocketName);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, AttachRootComponentTo_AttachLocationType_Offset), 0, AttachRootComponentTo_AttachLocationType_PropertyAddress.Address, AttachLocationType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AttachRootComponentTo_bWeldSimulatedBodies_Offset), 0, AttachRootComponentTo_bWeldSimulatedBodies_PropertyAddress.Address, bWeldSimulatedBodies);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachRootComponentTo_FunctionAddress, intPtr, AttachRootComponentTo_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorWorldTransformKeepScale")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorWorldTransformKeepScale")]
	public unsafe void AddActorWorldTransformKeepScale(FTransform DeltaTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorWorldTransformKeepScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorWorldTransformKeepScale");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorWorldTransformKeepScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorWorldTransformKeepScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddActorWorldTransformKeepScale_DeltaTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddActorWorldTransformKeepScale_DeltaTransform_Offset), 0, AddActorWorldTransformKeepScale_DeltaTransform_PropertyAddress.Address, DeltaTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldTransformKeepScale_bSweep_Offset), 0, AddActorWorldTransformKeepScale_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorWorldTransformKeepScale_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldTransformKeepScale_bTeleport_Offset), 0, AddActorWorldTransformKeepScale_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorWorldTransformKeepScale_FunctionAddress, intPtr, AddActorWorldTransformKeepScale_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorWorldTransformKeepScale_SweepHitResult_Offset), 0, AddActorWorldTransformKeepScale_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorWorldTransform")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorWorldTransform")]
	public unsafe void AddActorWorldTransform(FTransform DeltaTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorWorldTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddActorWorldTransform_DeltaTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddActorWorldTransform_DeltaTransform_Offset), 0, AddActorWorldTransform_DeltaTransform_PropertyAddress.Address, DeltaTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldTransform_bSweep_Offset), 0, AddActorWorldTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorWorldTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldTransform_bTeleport_Offset), 0, AddActorWorldTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorWorldTransform_FunctionAddress, intPtr, AddActorWorldTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorWorldTransform_SweepHitResult_Offset), 0, AddActorWorldTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorWorldRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorWorldRotation")]
	public unsafe void AddActorWorldRotation(FRotator DeltaRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorWorldRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorWorldRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorWorldRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorWorldRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddActorWorldRotation_DeltaRotation_Offset), 0, AddActorWorldRotation_DeltaRotation_PropertyAddress.Address, DeltaRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldRotation_bSweep_Offset), 0, AddActorWorldRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorWorldRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldRotation_bTeleport_Offset), 0, AddActorWorldRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorWorldRotation_FunctionAddress, intPtr, AddActorWorldRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorWorldRotation_SweepHitResult_Offset), 0, AddActorWorldRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorWorldOffset")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorWorldOffset")]
	public unsafe void AddActorWorldOffset(FVector DeltaLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorWorldOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorWorldOffset");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorWorldOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorWorldOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddActorWorldOffset_DeltaLocation_Offset), 0, AddActorWorldOffset_DeltaLocation_PropertyAddress.Address, DeltaLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldOffset_bSweep_Offset), 0, AddActorWorldOffset_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorWorldOffset_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorWorldOffset_bTeleport_Offset), 0, AddActorWorldOffset_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorWorldOffset_FunctionAddress, intPtr, AddActorWorldOffset_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorWorldOffset_SweepHitResult_Offset), 0, AddActorWorldOffset_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorLocalTransform")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorLocalTransform")]
	public unsafe void AddActorLocalTransform(FTransform NewTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorLocalTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddActorLocalTransform_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddActorLocalTransform_NewTransform_Offset), 0, AddActorLocalTransform_NewTransform_PropertyAddress.Address, NewTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalTransform_bSweep_Offset), 0, AddActorLocalTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorLocalTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalTransform_bTeleport_Offset), 0, AddActorLocalTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorLocalTransform_FunctionAddress, intPtr, AddActorLocalTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorLocalTransform_SweepHitResult_Offset), 0, AddActorLocalTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorLocalRotation")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorLocalRotation")]
	public unsafe void AddActorLocalRotation(FRotator DeltaRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorLocalRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorLocalRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorLocalRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorLocalRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddActorLocalRotation_DeltaRotation_Offset), 0, AddActorLocalRotation_DeltaRotation_PropertyAddress.Address, DeltaRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalRotation_bSweep_Offset), 0, AddActorLocalRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorLocalRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalRotation_bTeleport_Offset), 0, AddActorLocalRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorLocalRotation_FunctionAddress, intPtr, AddActorLocalRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorLocalRotation_SweepHitResult_Offset), 0, AddActorLocalRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddActorLocalOffset")]
	[UMetaPath("/Script/Engine.Actor:K2_AddActorLocalOffset")]
	public unsafe void AddActorLocalOffset(FVector DeltaLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddActorLocalOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:K2_AddActorLocalOffset");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorLocalOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorLocalOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddActorLocalOffset_DeltaLocation_Offset), 0, AddActorLocalOffset_DeltaLocation_PropertyAddress.Address, DeltaLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalOffset_bSweep_Offset), 0, AddActorLocalOffset_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddActorLocalOffset_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddActorLocalOffset_bTeleport_Offset), 0, AddActorLocalOffset_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorLocalOffset_FunctionAddress, intPtr, AddActorLocalOffset_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddActorLocalOffset_SweepHitResult_Offset), 0, AddActorLocalOffset_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/Engine.Actor:IsTemporarilyHiddenInEditor")]
	public unsafe bool IsTemporarilyHiddenInEditor(bool bIncludeParent = false)
	{
		CheckDestroyed();
		if (!IsTemporarilyHiddenInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsTemporarilyHiddenInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTemporarilyHiddenInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTemporarilyHiddenInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsTemporarilyHiddenInEditor_bIncludeParent_Offset), 0, IsTemporarilyHiddenInEditor_bIncludeParent_PropertyAddress.Address, bIncludeParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTemporarilyHiddenInEditor_FunctionAddress, intPtr, IsTemporarilyHiddenInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTemporarilyHiddenInEditor_ReturnValue_Offset), 0, IsTemporarilyHiddenInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289152u)]
	[UMetaPath("/Script/Engine.Actor:IsSelectable")]
	public unsafe bool IsSelectable()
	{
		CheckDestroyed();
		if (!IsSelectable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsSelectable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSelectable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSelectable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSelectable_FunctionAddress, intPtr, IsSelectable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSelectable_ReturnValue_Offset), 0, IsSelectable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:IsOverlappingActor")]
	public unsafe bool IsOverlappingActor(AActor Other)
	{
		CheckDestroyed();
		if (!IsOverlappingActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsOverlappingActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverlappingActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverlappingActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsOverlappingActor_Other_Offset), 0, IsOverlappingActor_Other_PropertyAddress.Address, Other);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverlappingActor_FunctionAddress, intPtr, IsOverlappingActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverlappingActor_ReturnValue_Offset), 0, IsOverlappingActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/Engine.Actor:IsHiddenEdAtStartup")]
	public unsafe bool IsHiddenEdAtStartup()
	{
		CheckDestroyed();
		if (!IsHiddenEdAtStartup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsHiddenEdAtStartup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHiddenEdAtStartup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHiddenEdAtStartup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHiddenEdAtStartup_FunctionAddress, intPtr, IsHiddenEdAtStartup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHiddenEdAtStartup_ReturnValue_Offset), 0, IsHiddenEdAtStartup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289152u)]
	[UMetaPath("/Script/Engine.Actor:IsHiddenEd")]
	public unsafe bool IsHiddenEd()
	{
		CheckDestroyed();
		if (!IsHiddenEd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsHiddenEd");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHiddenEd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHiddenEd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHiddenEd_FunctionAddress, intPtr, IsHiddenEd_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHiddenEd_ReturnValue_Offset), 0, IsHiddenEd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/Engine.Actor:IsEditable")]
	public unsafe bool IsEditable()
	{
		CheckDestroyed();
		if (!IsEditable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsEditable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEditable_FunctionAddress, intPtr, IsEditable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditable_ReturnValue_Offset), 0, IsEditable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:IsChildActor")]
	public unsafe bool IsChildActor()
	{
		CheckDestroyed();
		if (!IsChildActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsChildActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsChildActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsChildActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsChildActor_FunctionAddress, intPtr, IsChildActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsChildActor_ReturnValue_Offset), 0, IsChildActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:IsActorTickEnabled")]
	public unsafe bool IsActorTickEnabled()
	{
		CheckDestroyed();
		if (!IsActorTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsActorTickEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActorTickEnabled_FunctionAddress, intPtr, IsActorTickEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorTickEnabled_ReturnValue_Offset), 0, IsActorTickEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:IsActorBeingDestroyed")]
	public unsafe bool IsActorBeingDestroyed()
	{
		CheckDestroyed();
		if (!IsActorBeingDestroyed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:IsActorBeingDestroyed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorBeingDestroyed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorBeingDestroyed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActorBeingDestroyed_FunctionAddress, intPtr, IsActorBeingDestroyed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorBeingDestroyed_ReturnValue_Offset), 0, IsActorBeingDestroyed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:HasAuthority")]
	public unsafe bool HasAuthority()
	{
		CheckDestroyed();
		if (!HasAuthority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:HasAuthority");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAuthority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAuthority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAuthority_FunctionAddress, intPtr, HasAuthority_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAuthority_ReturnValue_Offset), 0, HasAuthority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetVerticalDistanceTo")]
	public unsafe float GetVerticalDistanceTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetVerticalDistanceTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetVerticalDistanceTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVerticalDistanceTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVerticalDistanceTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetVerticalDistanceTo_OtherActor_Offset), 0, GetVerticalDistanceTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVerticalDistanceTo_FunctionAddress, intPtr, GetVerticalDistanceTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetVerticalDistanceTo_ReturnValue_Offset), 0, GetVerticalDistanceTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Actor:GetVelocity")]
	public unsafe FVector GetVelocity()
	{
		CheckDestroyed();
		if (!GetVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVelocity_FunctionAddress, intPtr, GetVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVelocity_ReturnValue_Offset), 0, GetVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "GetTransform")]
	[UMetaPath("/Script/Engine.Actor:GetTransform")]
	public unsafe FTransform GetActorTransform()
	{
		CheckDestroyed();
		if (!GetActorTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorTransform_FunctionAddress, intPtr, GetActorTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetActorTransform_ReturnValue_Offset), 0, GetActorTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:GetTickableWhenPaused")]
	public unsafe bool GetTickableWhenPaused()
	{
		CheckDestroyed();
		if (!GetTickableWhenPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetTickableWhenPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTickableWhenPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTickableWhenPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTickableWhenPaused_FunctionAddress, intPtr, GetTickableWhenPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTickableWhenPaused_ReturnValue_Offset), 0, GetTickableWhenPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetSquaredHorizontalDistanceTo")]
	public unsafe float GetSquaredHorizontalDistanceTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetSquaredHorizontalDistanceTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetSquaredHorizontalDistanceTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSquaredHorizontalDistanceTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSquaredHorizontalDistanceTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSquaredHorizontalDistanceTo_OtherActor_Offset), 0, GetSquaredHorizontalDistanceTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSquaredHorizontalDistanceTo_FunctionAddress, intPtr, GetSquaredHorizontalDistanceTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSquaredHorizontalDistanceTo_ReturnValue_Offset), 0, GetSquaredHorizontalDistanceTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetSquaredDistanceTo")]
	public unsafe float GetSquaredDistanceTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetSquaredDistanceTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetSquaredDistanceTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSquaredDistanceTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSquaredDistanceTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSquaredDistanceTo_OtherActor_Offset), 0, GetSquaredDistanceTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSquaredDistanceTo_FunctionAddress, intPtr, GetSquaredDistanceTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSquaredDistanceTo_ReturnValue_Offset), 0, GetSquaredDistanceTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetRemoteRole")]
	public unsafe ENetRole GetRemoteRole()
	{
		CheckDestroyed();
		if (!GetRemoteRole_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetRemoteRole");
			return ENetRole.ROLE_None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRemoteRole_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRemoteRole_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRemoteRole_FunctionAddress, intPtr, GetRemoteRole_ParamsSize);
		return EnumMarshaler<ENetRole>.FromNative(IntPtr.Add(intPtr, GetRemoteRole_ReturnValue_Offset), 0, GetRemoteRole_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetRayTracingGroupId")]
	public unsafe int GetRayTracingGroupId()
	{
		CheckDestroyed();
		if (!GetRayTracingGroupId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetRayTracingGroupId");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRayTracingGroupId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRayTracingGroupId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRayTracingGroupId_FunctionAddress, intPtr, GetRayTracingGroupId_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRayTracingGroupId_ReturnValue_Offset), 0, GetRayTracingGroupId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetParentComponent")]
	public unsafe UChildActorComponent GetParentComponent()
	{
		CheckDestroyed();
		if (!GetParentComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetParentComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentComponent_FunctionAddress, intPtr, GetParentComponent_ParamsSize);
		return UObjectMarshaler<UChildActorComponent>.FromNative(IntPtr.Add(intPtr, GetParentComponent_ReturnValue_Offset), 0, GetParentComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetParentActor")]
	public unsafe AActor GetParentActor()
	{
		CheckDestroyed();
		if (!GetParentActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetParentActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentActor_FunctionAddress, intPtr, GetParentActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetParentActor_ReturnValue_Offset), 0, GetParentActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetOwner")]
	public unsafe AActor GetOwner()
	{
		CheckDestroyed();
		if (!GetOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetOwner");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwner_FunctionAddress, intPtr, GetOwner_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetOwner_ReturnValue_Offset), 0, GetOwner_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.Actor:GetOverlappingComponents")]
	public unsafe void GetOverlappingComponents(out List<UPrimitiveComponent> OverlappingComponents)
	{
		CheckDestroyed();
		if (!GetOverlappingComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetOverlappingComponents");
			OverlappingComponents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverlappingComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverlappingComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverlappingComponents_FunctionAddress, intPtr, GetOverlappingComponents_ParamsSize);
		OverlappingComponents = new TArrayCopyMarshaler<UPrimitiveComponent>(1, GetOverlappingComponents_OverlappingComponents_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOverlappingComponents_OverlappingComponents_Offset));
		NativeReflection.DestroyValue_InContainer(GetOverlappingComponents_OverlappingComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.Actor:GetOverlappingActors")]
	public unsafe void GetOverlappingActors(out List<AActor> OverlappingActors, TSubclassOf<AActor> ClassFilter)
	{
		CheckDestroyed();
		if (!GetOverlappingActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetOverlappingActors");
			OverlappingActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverlappingActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverlappingActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetOverlappingActors_ClassFilter_Offset), 0, GetOverlappingActors_ClassFilter_PropertyAddress.Address, ClassFilter);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverlappingActors_FunctionAddress, intPtr, GetOverlappingActors_ParamsSize);
		OverlappingActors = new TArrayCopyMarshaler<AActor>(1, GetOverlappingActors_OverlappingActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOverlappingActors_OverlappingActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetOverlappingActors_OverlappingActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetLocalRole")]
	public unsafe ENetRole GetLocalRole()
	{
		CheckDestroyed();
		if (!GetLocalRole_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetLocalRole");
			return ENetRole.ROLE_None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalRole_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalRole_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalRole_FunctionAddress, intPtr, GetLocalRole_ParamsSize);
		return EnumMarshaler<ENetRole>.FromNative(IntPtr.Add(intPtr, GetLocalRole_ReturnValue_Offset), 0, GetLocalRole_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Actor:GetLifeSpan")]
	public unsafe float GetLifeSpan()
	{
		CheckDestroyed();
		if (!GetLifeSpan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetLifeSpan");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLifeSpan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLifeSpan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLifeSpan_FunctionAddress, intPtr, GetLifeSpan_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLifeSpan_ReturnValue_Offset), 0, GetLifeSpan_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetLevelTransform")]
	public unsafe FTransform GetLevelTransform()
	{
		CheckDestroyed();
		if (!GetLevelTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetLevelTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelTransform_FunctionAddress, intPtr, GetLevelTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLevelTransform_ReturnValue_Offset), 0, GetLevelTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetLevel")]
	public unsafe ULevel GetLevel()
	{
		CheckDestroyed();
		if (!GetLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevel_FunctionAddress, intPtr, GetLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetLevel_ReturnValue_Offset), 0, GetLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetInstigatorController")]
	public unsafe AController GetInstigatorController()
	{
		CheckDestroyed();
		if (!GetInstigatorController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetInstigatorController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstigatorController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstigatorController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstigatorController_FunctionAddress, intPtr, GetInstigatorController_ParamsSize);
		return UObjectMarshaler<AController>.FromNative(IntPtr.Add(intPtr, GetInstigatorController_ReturnValue_Offset), 0, GetInstigatorController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetInstigator")]
	public unsafe APawn GetInstigator()
	{
		CheckDestroyed();
		if (!GetInstigator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetInstigator");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstigator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstigator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstigator_FunctionAddress, intPtr, GetInstigator_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetInstigator_ReturnValue_Offset), 0, GetInstigator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetHorizontalDotProductTo")]
	public unsafe float GetHorizontalDotProductTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetHorizontalDotProductTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetHorizontalDotProductTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHorizontalDotProductTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHorizontalDotProductTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetHorizontalDotProductTo_OtherActor_Offset), 0, GetHorizontalDotProductTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHorizontalDotProductTo_FunctionAddress, intPtr, GetHorizontalDotProductTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetHorizontalDotProductTo_ReturnValue_Offset), 0, GetHorizontalDotProductTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetHorizontalDistanceTo")]
	public unsafe float GetHorizontalDistanceTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetHorizontalDistanceTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetHorizontalDistanceTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHorizontalDistanceTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHorizontalDistanceTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetHorizontalDistanceTo_OtherActor_Offset), 0, GetHorizontalDistanceTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHorizontalDistanceTo_FunctionAddress, intPtr, GetHorizontalDistanceTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetHorizontalDistanceTo_ReturnValue_Offset), 0, GetHorizontalDistanceTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetGameTimeSinceCreation")]
	public unsafe float GetGameTimeSinceCreation()
	{
		CheckDestroyed();
		if (!GetGameTimeSinceCreation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetGameTimeSinceCreation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameTimeSinceCreation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameTimeSinceCreation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGameTimeSinceCreation_FunctionAddress, intPtr, GetGameTimeSinceCreation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGameTimeSinceCreation_ReturnValue_Offset), 0, GetGameTimeSinceCreation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/Engine.Actor:GetFolderPath")]
	public unsafe FName GetFolderPath()
	{
		CheckDestroyed();
		if (!GetFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetFolderPath");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFolderPath_FunctionAddress, intPtr, GetFolderPath_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetFolderPath_ReturnValue_Offset), 0, GetFolderPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetDotProductTo")]
	public unsafe float GetDotProductTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetDotProductTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetDotProductTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDotProductTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDotProductTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetDotProductTo_OtherActor_Offset), 0, GetDotProductTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDotProductTo_FunctionAddress, intPtr, GetDotProductTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDotProductTo_ReturnValue_Offset), 0, GetDotProductTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetDistanceTo")]
	public unsafe float GetDistanceTo(AActor OtherActor)
	{
		CheckDestroyed();
		if (!GetDistanceTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetDistanceTo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDistanceTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDistanceTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetDistanceTo_OtherActor_Offset), 0, GetDistanceTo_OtherActor_PropertyAddress.Address, OtherActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDistanceTo_FunctionAddress, intPtr, GetDistanceTo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDistanceTo_ReturnValue_Offset), 0, GetDistanceTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289152u)]
	[UMetaPath("/Script/Engine.Actor:GetDefaultActorLabel")]
	public unsafe string GetDefaultActorLabel()
	{
		CheckDestroyed();
		if (!GetDefaultActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetDefaultActorLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultActorLabel_FunctionAddress, intPtr, GetDefaultActorLabel_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDefaultActorLabel_ReturnValue_Offset), 0, GetDefaultActorLabel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultActorLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetComponentsByTag")]
	public unsafe List<UActorComponent> GetComponentsByTag(TSubclassOf<UActorComponent> ComponentClass, FName Tag)
	{
		CheckDestroyed();
		if (!GetComponentsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetComponentsByTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, GetComponentsByTag_ComponentClass_Offset), 0, GetComponentsByTag_ComponentClass_PropertyAddress.Address, ComponentClass);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetComponentsByTag_Tag_Offset), 0, GetComponentsByTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentsByTag_FunctionAddress, intPtr, GetComponentsByTag_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetComponentsByTag_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetComponentsByTag_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetComponentsByTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetComponentsByInterface")]
	public unsafe List<UActorComponent> GetComponentsByInterface(TSubclassOfInterface<IInterface> Interface)
	{
		CheckDestroyed();
		if (!GetComponentsByInterface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetComponentsByInterface");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentsByInterface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentsByInterface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfInterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(intPtr, GetComponentsByInterface_Interface_Offset), 0, GetComponentsByInterface_Interface_PropertyAddress.Address, Interface);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentsByInterface_FunctionAddress, intPtr, GetComponentsByInterface_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetComponentsByInterface_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetComponentsByInterface_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetComponentsByInterface_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetComponentByClass")]
	public unsafe UActorComponent GetComponentByClass(TSubclassOf<UActorComponent> ComponentClass)
	{
		CheckDestroyed();
		if (!GetComponentByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetComponentByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, GetComponentByClass_ComponentClass_Offset), 0, GetComponentByClass_ComponentClass_PropertyAddress.Address, ComponentClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentByClass_FunctionAddress, intPtr, GetComponentByClass_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, GetComponentByClass_ReturnValue_Offset), 0, GetComponentByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetAttachParentSocketName")]
	public unsafe FName GetAttachParentSocketName()
	{
		CheckDestroyed();
		if (!GetAttachParentSocketName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetAttachParentSocketName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachParentSocketName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachParentSocketName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachParentSocketName_FunctionAddress, intPtr, GetAttachParentSocketName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAttachParentSocketName_ReturnValue_Offset), 0, GetAttachParentSocketName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetAttachParentActor")]
	public unsafe AActor GetAttachParentActor()
	{
		CheckDestroyed();
		if (!GetAttachParentActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetAttachParentActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachParentActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachParentActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachParentActor_FunctionAddress, intPtr, GetAttachParentActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetAttachParentActor_ReturnValue_Offset), 0, GetAttachParentActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.Actor:GetAttachedActors")]
	public unsafe void GetAttachedActors(out List<AActor> OutActors, bool bResetArray = true, bool bRecursivelyIncludeAttachedActors = false)
	{
		CheckDestroyed();
		if (!GetAttachedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetAttachedActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAttachedActors_bResetArray_Offset), 0, GetAttachedActors_bResetArray_PropertyAddress.Address, bResetArray);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAttachedActors_bRecursivelyIncludeAttachedActors_Offset), 0, GetAttachedActors_bRecursivelyIncludeAttachedActors_PropertyAddress.Address, bRecursivelyIncludeAttachedActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachedActors_FunctionAddress, intPtr, GetAttachedActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetAttachedActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAttachedActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetAttachedActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.Actor:GetAllChildActors")]
	public unsafe void GetAllChildActors(out List<AActor> ChildActors, bool bIncludeDescendants = true)
	{
		CheckDestroyed();
		if (!GetAllChildActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetAllChildActors");
			ChildActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllChildActors_bIncludeDescendants_Offset), 0, GetAllChildActors_bIncludeDescendants_PropertyAddress.Address, bIncludeDescendants);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllChildActors_FunctionAddress, intPtr, GetAllChildActors_ParamsSize);
		ChildActors = new TArrayCopyMarshaler<AActor>(1, GetAllChildActors_ChildActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildActors_ChildActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildActors_ChildActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetActorUpVector")]
	public unsafe FVector GetActorUpVector()
	{
		CheckDestroyed();
		if (!GetActorUpVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorUpVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorUpVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorUpVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorUpVector_FunctionAddress, intPtr, GetActorUpVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorUpVector_ReturnValue_Offset), 0, GetActorUpVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetActorTimeDilation")]
	public unsafe float GetActorTimeDilation()
	{
		CheckDestroyed();
		if (!GetActorTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorTimeDilation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorTimeDilation_FunctionAddress, intPtr, GetActorTimeDilation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetActorTimeDilation_ReturnValue_Offset), 0, GetActorTimeDilation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetActorTickInterval")]
	public unsafe float GetActorTickInterval()
	{
		CheckDestroyed();
		if (!GetActorTickInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorTickInterval");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorTickInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorTickInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorTickInterval_FunctionAddress, intPtr, GetActorTickInterval_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetActorTickInterval_ReturnValue_Offset), 0, GetActorTickInterval_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetActorScale3D")]
	public unsafe FVector GetActorScale3D()
	{
		CheckDestroyed();
		if (!GetActorScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorScale3D");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorScale3D_FunctionAddress, intPtr, GetActorScale3D_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorScale3D_ReturnValue_Offset), 0, GetActorScale3D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetActorRightVector")]
	public unsafe FVector GetActorRightVector()
	{
		CheckDestroyed();
		if (!GetActorRightVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorRightVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorRightVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorRightVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorRightVector_FunctionAddress, intPtr, GetActorRightVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorRightVector_ReturnValue_Offset), 0, GetActorRightVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetActorRelativeScale3D")]
	public unsafe FVector GetActorRelativeScale3D()
	{
		CheckDestroyed();
		if (!GetActorRelativeScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorRelativeScale3D");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorRelativeScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorRelativeScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorRelativeScale3D_FunctionAddress, intPtr, GetActorRelativeScale3D_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorRelativeScale3D_ReturnValue_Offset), 0, GetActorRelativeScale3D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1946289153u)]
	[UMetaPath("/Script/Engine.Actor:GetActorLabel")]
	public unsafe string GetActorLabel(bool bCreateIfNone = true)
	{
		CheckDestroyed();
		if (!GetActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorLabel_bCreateIfNone_Offset), 0, GetActorLabel_bCreateIfNone_PropertyAddress.Address, bCreateIfNone);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorLabel_FunctionAddress, intPtr, GetActorLabel_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorLabel_ReturnValue_Offset), 0, GetActorLabel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Actor:GetActorForwardVector")]
	public unsafe FVector GetActorForwardVector()
	{
		CheckDestroyed();
		if (!GetActorForwardVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorForwardVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorForwardVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorForwardVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorForwardVector_FunctionAddress, intPtr, GetActorForwardVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorForwardVector_ReturnValue_Offset), 0, GetActorForwardVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.Actor:GetActorEyesViewPoint")]
	public unsafe void GetActorEyesViewPoint(out FVector OutLocation, out FRotator OutRotation)
	{
		CheckDestroyed();
		if (!GetActorEyesViewPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorEyesViewPoint");
			OutLocation = default(FVector);
			OutRotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorEyesViewPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorEyesViewPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorEyesViewPoint_FunctionAddress, intPtr, GetActorEyesViewPoint_ParamsSize);
		OutLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorEyesViewPoint_OutLocation_Offset), 0, GetActorEyesViewPoint_OutLocation_PropertyAddress.Address);
		OutRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetActorEyesViewPoint_OutRotation_Offset), 0, GetActorEyesViewPoint_OutRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:GetActorEnableCollision")]
	public unsafe bool GetActorEnableCollision()
	{
		CheckDestroyed();
		if (!GetActorEnableCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorEnableCollision");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorEnableCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorEnableCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorEnableCollision_FunctionAddress, intPtr, GetActorEnableCollision_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorEnableCollision_ReturnValue_Offset), 0, GetActorEnableCollision_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.Actor:GetActorBounds")]
	public unsafe void GetActorBounds(bool bOnlyCollidingComponents, out FVector Origin, out FVector BoxExtent, bool bIncludeFromChildActors = false)
	{
		CheckDestroyed();
		if (!GetActorBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:GetActorBounds");
			Origin = default(FVector);
			BoxExtent = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorBounds_bOnlyCollidingComponents_Offset), 0, GetActorBounds_bOnlyCollidingComponents_PropertyAddress.Address, bOnlyCollidingComponents);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorBounds_bIncludeFromChildActors_Offset), 0, GetActorBounds_bIncludeFromChildActors_PropertyAddress.Address, bIncludeFromChildActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorBounds_FunctionAddress, intPtr, GetActorBounds_ParamsSize);
		Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorBounds_Origin_Offset), 0, GetActorBounds_Origin_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorBounds_BoxExtent_Offset), 0, GetActorBounds_BoxExtent_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:ForceNetUpdate")]
	public unsafe void ForceNetUpdate()
	{
		CheckDestroyed();
		if (!ForceNetUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ForceNetUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceNetUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceNetUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceNetUpdate_FunctionAddress, argsSize: ForceNetUpdate_ParamsSize);
	}

	[UFunction(Flags = 67240965u)]
	[UMetaPath("/Script/Engine.Actor:FlushNetDormancy")]
	public unsafe void FlushNetDormancy()
	{
		CheckDestroyed();
		if (!FlushNetDormancy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:FlushNetDormancy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushNetDormancy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushNetDormancy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FlushNetDormancy_FunctionAddress, argsSize: FlushNetDormancy_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:EnableInput")]
	public unsafe void EnableInput(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!EnableInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:EnableInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, EnableInput_PlayerController_Offset), 0, EnableInput_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableInput_FunctionAddress, intPtr, EnableInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:DisableInput")]
	public unsafe void DisableInput(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!DisableInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:DisableInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, DisableInput_PlayerController_Offset), 0, DisableInput_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, DisableInput_FunctionAddress, intPtr, DisableInput_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Actor:DetachRootComponentFromParent")]
	public unsafe void DetachRootComponentFromParent(bool bMaintainWorldPosition = true)
	{
		CheckDestroyed();
		if (!DetachRootComponentFromParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:DetachRootComponentFromParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetachRootComponentFromParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetachRootComponentFromParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DetachRootComponentFromParent_bMaintainWorldPosition_Offset), 0, DetachRootComponentFromParent_bMaintainWorldPosition_PropertyAddress.Address, bMaintainWorldPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, DetachRootComponentFromParent_FunctionAddress, intPtr, DetachRootComponentFromParent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:AddTickPrerequisiteComponent")]
	public unsafe void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
	{
		CheckDestroyed();
		if (!AddTickPrerequisiteComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:AddTickPrerequisiteComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTickPrerequisiteComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTickPrerequisiteComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AddTickPrerequisiteComponent_PrerequisiteComponent_Offset), 0, AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress.Address, PrerequisiteComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTickPrerequisiteComponent_FunctionAddress, intPtr, AddTickPrerequisiteComponent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Actor:AddTickPrerequisiteActor")]
	public unsafe void AddTickPrerequisiteActor(AActor PrerequisiteActor)
	{
		CheckDestroyed();
		if (!AddTickPrerequisiteActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:AddTickPrerequisiteActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTickPrerequisiteActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTickPrerequisiteActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddTickPrerequisiteActor_PrerequisiteActor_Offset), 0, AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress.Address, PrerequisiteActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTickPrerequisiteActor_FunctionAddress, intPtr, AddTickPrerequisiteActor_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Actor:ActorHasTag")]
	public unsafe bool ActorHasTag(FName Tag)
	{
		CheckDestroyed();
		if (!ActorHasTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Actor:ActorHasTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorHasTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorHasTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ActorHasTag_Tag_Offset), 0, ActorHasTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActorHasTag_FunctionAddress, intPtr, ActorHasTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ActorHasTag_ReturnValue_Offset), 0, ActorHasTag_ReturnValue_PropertyAddress.Address);
	}

	static AActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Actor");
		NativeReflectionCached.GetPropertyRef(ref OnlyRelevantToOwner_PropertyAddress, intPtr, "bOnlyRelevantToOwner");
		OnlyRelevantToOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnlyRelevantToOwner");
		OnlyRelevantToOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnlyRelevantToOwner", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysRelevant_PropertyAddress, intPtr, "bAlwaysRelevant");
		AlwaysRelevant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysRelevant");
		AlwaysRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysRelevant", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Hidden_PropertyAddress, intPtr, "bHidden");
		Hidden_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHidden");
		Hidden_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NetUseOwnerRelevancy_PropertyAddress, intPtr, "bNetUseOwnerRelevancy");
		NetUseOwnerRelevancy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNetUseOwnerRelevancy");
		NetUseOwnerRelevancy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNetUseOwnerRelevancy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTickBeforeBeginPlay_PropertyAddress, intPtr, "bAllowTickBeforeBeginPlay");
		AllowTickBeforeBeginPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowTickBeforeBeginPlay");
		AllowTickBeforeBeginPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowTickBeforeBeginPlay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanBeDamaged_PropertyAddress, intPtr, "bCanBeDamaged");
		CanBeDamaged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanBeDamaged");
		CanBeDamaged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanBeDamaged", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindCameraComponentWhenViewTarget_PropertyAddress, intPtr, "bFindCameraComponentWhenViewTarget");
		FindCameraComponentWhenViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFindCameraComponentWhenViewTarget");
		FindCameraComponentWhenViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFindCameraComponentWhenViewTarget", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateOverlapEventsDuringLevelStreaming_PropertyAddress, intPtr, "bGenerateOverlapEventsDuringLevelStreaming");
		GenerateOverlapEventsDuringLevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateOverlapEventsDuringLevelStreaming");
		GenerateOverlapEventsDuringLevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateOverlapEventsDuringLevelStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAutoLODGeneration_PropertyAddress, intPtr, "bEnableAutoLODGeneration");
		EnableAutoLODGeneration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableAutoLODGeneration");
		EnableAutoLODGeneration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableAutoLODGeneration", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Replicates_PropertyAddress, intPtr, "bReplicates");
		Replicates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplicates");
		Replicates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplicates", Classes.FBoolProperty);
		InitialLifeSpan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialLifeSpan");
		InitialLifeSpan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialLifeSpan", Classes.FFloatProperty);
		CustomTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomTimeDilation");
		CustomTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomTimeDilation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NetDormancy_PropertyAddress, intPtr, "NetDormancy");
		NetDormancy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetDormancy");
		NetDormancy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetDormancy", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnCollisionHandlingMethod_PropertyAddress, intPtr, "SpawnCollisionHandlingMethod");
		SpawnCollisionHandlingMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnCollisionHandlingMethod");
		SpawnCollisionHandlingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnCollisionHandlingMethod", Classes.FEnumProperty);
		InputComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputComponent");
		InputComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputComponent", Classes.FObjectProperty);
		NetCullDistanceSquared_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetCullDistanceSquared");
		NetCullDistanceSquared_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetCullDistanceSquared", Classes.FFloatProperty);
		NetUpdateFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetUpdateFrequency");
		NetUpdateFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetUpdateFrequency", Classes.FFloatProperty);
		MinNetUpdateFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinNetUpdateFrequency");
		MinNetUpdateFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinNetUpdateFrequency", Classes.FFloatProperty);
		NetPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NetPriority");
		NetPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NetPriority", Classes.FFloatProperty);
		Instigator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Instigator");
		Instigator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Instigator", Classes.FObjectProperty);
		RootComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootComponent");
		RootComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootComponent", Classes.FObjectProperty);
		PivotOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PivotOffset");
		PivotOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PivotOffset", Classes.FStructProperty);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStructProperty);
		SpriteScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpriteScale");
		SpriteScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpriteScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Tags_PropertyAddress, intPtr, "Tags");
		Tags_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tags");
		Tags_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tags", Classes.FArrayProperty);
		OnTakeAnyDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTakeAnyDamage");
		OnTakeAnyDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTakeAnyDamage", Classes.FMulticastDelegateProperty);
		OnTakePointDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTakePointDamage");
		OnTakePointDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTakePointDamage", Classes.FMulticastDelegateProperty);
		OnTakeRadialDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTakeRadialDamage");
		OnTakeRadialDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTakeRadialDamage", Classes.FMulticastDelegateProperty);
		OnActorBeginOverlap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnActorBeginOverlap");
		OnActorBeginOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnActorBeginOverlap", Classes.FMulticastDelegateProperty);
		OnActorEndOverlap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnActorEndOverlap");
		OnActorEndOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnActorEndOverlap", Classes.FMulticastDelegateProperty);
		OnBeginCursorOver_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBeginCursorOver");
		OnBeginCursorOver_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBeginCursorOver", Classes.FMulticastDelegateProperty);
		OnEndCursorOver_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEndCursorOver");
		OnEndCursorOver_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEndCursorOver", Classes.FMulticastDelegateProperty);
		OnClicked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnClicked");
		OnClicked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnClicked", Classes.FMulticastDelegateProperty);
		OnReleased_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnReleased");
		OnReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnReleased", Classes.FMulticastDelegateProperty);
		OnInputTouchBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputTouchBegin");
		OnInputTouchBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputTouchBegin", Classes.FMulticastDelegateProperty);
		OnInputTouchEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputTouchEnd");
		OnInputTouchEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputTouchEnd", Classes.FMulticastDelegateProperty);
		OnInputTouchEnter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputTouchEnter");
		OnInputTouchEnter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputTouchEnter", Classes.FMulticastDelegateProperty);
		OnInputTouchLeave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputTouchLeave");
		OnInputTouchLeave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputTouchLeave", Classes.FMulticastDelegateProperty);
		OnActorHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnActorHit");
		OnActorHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnActorHit", Classes.FMulticastDelegateProperty);
		OnDestroyed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDestroyed");
		OnDestroyed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDestroyed", Classes.FMulticastDelegateProperty);
		OnEndPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnEndPlay");
		OnEndPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnEndPlay", Classes.FMulticastDelegateProperty);
		WasRecentlyRendered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WasRecentlyRendered");
		WasRecentlyRendered_ParamsSize = NativeReflection.GetFunctionParamsSize(WasRecentlyRendered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasRecentlyRendered_Tolerance_PropertyAddress, WasRecentlyRendered_FunctionAddress, "Tolerance");
		WasRecentlyRendered_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(WasRecentlyRendered_FunctionAddress, "Tolerance");
		WasRecentlyRendered_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(WasRecentlyRendered_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WasRecentlyRendered_ReturnValue_PropertyAddress, WasRecentlyRendered_FunctionAddress, "ReturnValue");
		WasRecentlyRendered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasRecentlyRendered_FunctionAddress, "ReturnValue");
		WasRecentlyRendered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasRecentlyRendered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasRecentlyRendered_IsValid = WasRecentlyRendered_FunctionAddress != IntPtr.Zero && WasRecentlyRendered_Tolerance_IsValid && WasRecentlyRendered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:WasRecentlyRendered", WasRecentlyRendered_IsValid);
		TearOff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TearOff");
		TearOff_ParamsSize = NativeReflection.GetFunctionParamsSize(TearOff_FunctionAddress);
		TearOff_IsValid = TearOff_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:TearOff", TearOff_IsValid);
		SetTickGroup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickGroup");
		SetTickGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickGroup_NewTickGroup_PropertyAddress, SetTickGroup_FunctionAddress, "NewTickGroup");
		SetTickGroup_NewTickGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetTickGroup_FunctionAddress, "NewTickGroup");
		SetTickGroup_NewTickGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickGroup_FunctionAddress, "NewTickGroup", Classes.FByteProperty);
		SetTickGroup_IsValid = SetTickGroup_FunctionAddress != IntPtr.Zero && SetTickGroup_NewTickGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetTickGroup", SetTickGroup_IsValid);
		SetTickableWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickableWhenPaused");
		SetTickableWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickableWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickableWhenPaused_bTickableWhenPaused_PropertyAddress, SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused");
		SetTickableWhenPaused_bTickableWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused");
		SetTickableWhenPaused_bTickableWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickableWhenPaused_FunctionAddress, "bTickableWhenPaused", Classes.FBoolProperty);
		SetTickableWhenPaused_IsValid = SetTickableWhenPaused_FunctionAddress != IntPtr.Zero && SetTickableWhenPaused_bTickableWhenPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetTickableWhenPaused", SetTickableWhenPaused_IsValid);
		SetReplicates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReplicates");
		SetReplicates_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReplicates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReplicates_bInReplicates_PropertyAddress, SetReplicates_FunctionAddress, "bInReplicates");
		SetReplicates_bInReplicates_Offset = NativeReflectionCached.GetPropertyOffset(SetReplicates_FunctionAddress, "bInReplicates");
		SetReplicates_bInReplicates_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReplicates_FunctionAddress, "bInReplicates", Classes.FBoolProperty);
		SetReplicates_IsValid = SetReplicates_FunctionAddress != IntPtr.Zero && SetReplicates_bInReplicates_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetReplicates", SetReplicates_IsValid);
		SetReplicateMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReplicateMovement");
		SetReplicateMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReplicateMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReplicateMovement_bInReplicateMovement_PropertyAddress, SetReplicateMovement_FunctionAddress, "bInReplicateMovement");
		SetReplicateMovement_bInReplicateMovement_Offset = NativeReflectionCached.GetPropertyOffset(SetReplicateMovement_FunctionAddress, "bInReplicateMovement");
		SetReplicateMovement_bInReplicateMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReplicateMovement_FunctionAddress, "bInReplicateMovement", Classes.FBoolProperty);
		SetReplicateMovement_IsValid = SetReplicateMovement_FunctionAddress != IntPtr.Zero && SetReplicateMovement_bInReplicateMovement_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetReplicateMovement", SetReplicateMovement_IsValid);
		SetRayTracingGroupId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRayTracingGroupId");
		SetRayTracingGroupId_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayTracingGroupId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayTracingGroupId_InRaytracingGroupId_PropertyAddress, SetRayTracingGroupId_FunctionAddress, "InRaytracingGroupId");
		SetRayTracingGroupId_InRaytracingGroupId_Offset = NativeReflectionCached.GetPropertyOffset(SetRayTracingGroupId_FunctionAddress, "InRaytracingGroupId");
		SetRayTracingGroupId_InRaytracingGroupId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayTracingGroupId_FunctionAddress, "InRaytracingGroupId", Classes.FIntProperty);
		SetRayTracingGroupId_IsValid = SetRayTracingGroupId_FunctionAddress != IntPtr.Zero && SetRayTracingGroupId_InRaytracingGroupId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetRayTracingGroupId", SetRayTracingGroupId_IsValid);
		SetOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOwner");
		SetOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOwner_NewOwner_PropertyAddress, SetOwner_FunctionAddress, "NewOwner");
		SetOwner_NewOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetOwner_FunctionAddress, "NewOwner");
		SetOwner_NewOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOwner_FunctionAddress, "NewOwner", Classes.FObjectProperty);
		SetOwner_IsValid = SetOwner_FunctionAddress != IntPtr.Zero && SetOwner_NewOwner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetOwner", SetOwner_IsValid);
		SetNetDormancy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNetDormancy");
		SetNetDormancy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNetDormancy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNetDormancy_NewDormancy_PropertyAddress, SetNetDormancy_FunctionAddress, "NewDormancy");
		SetNetDormancy_NewDormancy_Offset = NativeReflectionCached.GetPropertyOffset(SetNetDormancy_FunctionAddress, "NewDormancy");
		SetNetDormancy_NewDormancy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNetDormancy_FunctionAddress, "NewDormancy", Classes.FByteProperty);
		SetNetDormancy_IsValid = SetNetDormancy_FunctionAddress != IntPtr.Zero && SetNetDormancy_NewDormancy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetNetDormancy", SetNetDormancy_IsValid);
		SetLifeSpan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLifeSpan");
		SetLifeSpan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLifeSpan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLifeSpan_InLifespan_PropertyAddress, SetLifeSpan_FunctionAddress, "InLifespan");
		SetLifeSpan_InLifespan_Offset = NativeReflectionCached.GetPropertyOffset(SetLifeSpan_FunctionAddress, "InLifespan");
		SetLifeSpan_InLifespan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLifeSpan_FunctionAddress, "InLifespan", Classes.FFloatProperty);
		SetLifeSpan_IsValid = SetLifeSpan_FunctionAddress != IntPtr.Zero && SetLifeSpan_InLifespan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetLifeSpan", SetLifeSpan_IsValid);
		SetIsTemporarilyHiddenInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsTemporarilyHiddenInEditor");
		SetIsTemporarilyHiddenInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsTemporarilyHiddenInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress, SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden");
		SetIsTemporarilyHiddenInEditor_bIsHidden_Offset = NativeReflectionCached.GetPropertyOffset(SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden");
		SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden", Classes.FBoolProperty);
		SetIsTemporarilyHiddenInEditor_IsValid = SetIsTemporarilyHiddenInEditor_FunctionAddress != IntPtr.Zero && SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetIsTemporarilyHiddenInEditor", SetIsTemporarilyHiddenInEditor_IsValid);
		SetFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFolderPath");
		SetFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFolderPath_NewFolderPath_PropertyAddress, SetFolderPath_FunctionAddress, "NewFolderPath");
		SetFolderPath_NewFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderPath_FunctionAddress, "NewFolderPath");
		SetFolderPath_NewFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderPath_FunctionAddress, "NewFolderPath", Classes.FNameProperty);
		SetFolderPath_IsValid = SetFolderPath_FunctionAddress != IntPtr.Zero && SetFolderPath_NewFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetFolderPath", SetFolderPath_IsValid);
		SetAutoDestroyWhenFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoDestroyWhenFinished");
		SetAutoDestroyWhenFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoDestroyWhenFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoDestroyWhenFinished_bVal_PropertyAddress, SetAutoDestroyWhenFinished_FunctionAddress, "bVal");
		SetAutoDestroyWhenFinished_bVal_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoDestroyWhenFinished_FunctionAddress, "bVal");
		SetAutoDestroyWhenFinished_bVal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoDestroyWhenFinished_FunctionAddress, "bVal", Classes.FBoolProperty);
		SetAutoDestroyWhenFinished_IsValid = SetAutoDestroyWhenFinished_FunctionAddress != IntPtr.Zero && SetAutoDestroyWhenFinished_bVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetAutoDestroyWhenFinished", SetAutoDestroyWhenFinished_IsValid);
		SetActorTickInterval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorTickInterval");
		SetActorTickInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorTickInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorTickInterval_TickInterval_PropertyAddress, SetActorTickInterval_FunctionAddress, "TickInterval");
		SetActorTickInterval_TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTickInterval_FunctionAddress, "TickInterval");
		SetActorTickInterval_TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTickInterval_FunctionAddress, "TickInterval", Classes.FFloatProperty);
		SetActorTickInterval_IsValid = SetActorTickInterval_FunctionAddress != IntPtr.Zero && SetActorTickInterval_TickInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorTickInterval", SetActorTickInterval_IsValid);
		SetActorTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorTickEnabled");
		SetActorTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorTickEnabled_bEnabled_PropertyAddress, SetActorTickEnabled_FunctionAddress, "bEnabled");
		SetActorTickEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTickEnabled_FunctionAddress, "bEnabled");
		SetActorTickEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTickEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetActorTickEnabled_IsValid = SetActorTickEnabled_FunctionAddress != IntPtr.Zero && SetActorTickEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorTickEnabled", SetActorTickEnabled_IsValid);
		SetActorScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorScale3D");
		SetActorScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorScale3D_NewScale3D_PropertyAddress, SetActorScale3D_FunctionAddress, "NewScale3D");
		SetActorScale3D_NewScale3D_Offset = NativeReflectionCached.GetPropertyOffset(SetActorScale3D_FunctionAddress, "NewScale3D");
		SetActorScale3D_NewScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorScale3D_FunctionAddress, "NewScale3D", Classes.FStructProperty);
		SetActorScale3D_IsValid = SetActorScale3D_FunctionAddress != IntPtr.Zero && SetActorScale3D_NewScale3D_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorScale3D", SetActorScale3D_IsValid);
		SetActorRelativeScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorRelativeScale3D");
		SetActorRelativeScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRelativeScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeScale3D_NewRelativeScale_PropertyAddress, SetActorRelativeScale3D_FunctionAddress, "NewRelativeScale");
		SetActorRelativeScale3D_NewRelativeScale_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeScale3D_FunctionAddress, "NewRelativeScale");
		SetActorRelativeScale3D_NewRelativeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeScale3D_FunctionAddress, "NewRelativeScale", Classes.FStructProperty);
		SetActorRelativeScale3D_IsValid = SetActorRelativeScale3D_FunctionAddress != IntPtr.Zero && SetActorRelativeScale3D_NewRelativeScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorRelativeScale3D", SetActorRelativeScale3D_IsValid);
		SetActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorLabel");
		SetActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_NewActorLabel_PropertyAddress, SetActorLabel_FunctionAddress, "NewActorLabel");
		SetActorLabel_NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "NewActorLabel");
		SetActorLabel_NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_bMarkDirty_PropertyAddress, SetActorLabel_FunctionAddress, "bMarkDirty");
		SetActorLabel_bMarkDirty_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "bMarkDirty");
		SetActorLabel_bMarkDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "bMarkDirty", Classes.FBoolProperty);
		SetActorLabel_IsValid = SetActorLabel_FunctionAddress != IntPtr.Zero && SetActorLabel_NewActorLabel_IsValid && SetActorLabel_bMarkDirty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorLabel", SetActorLabel_IsValid);
		SetActorHiddenInGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorHiddenInGame");
		SetActorHiddenInGame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorHiddenInGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorHiddenInGame_bNewHidden_PropertyAddress, SetActorHiddenInGame_FunctionAddress, "bNewHidden");
		SetActorHiddenInGame_bNewHidden_Offset = NativeReflectionCached.GetPropertyOffset(SetActorHiddenInGame_FunctionAddress, "bNewHidden");
		SetActorHiddenInGame_bNewHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorHiddenInGame_FunctionAddress, "bNewHidden", Classes.FBoolProperty);
		SetActorHiddenInGame_IsValid = SetActorHiddenInGame_FunctionAddress != IntPtr.Zero && SetActorHiddenInGame_bNewHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorHiddenInGame", SetActorHiddenInGame_IsValid);
		SetActorEnableCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetActorEnableCollision");
		SetActorEnableCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorEnableCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorEnableCollision_bNewActorEnableCollision_PropertyAddress, SetActorEnableCollision_FunctionAddress, "bNewActorEnableCollision");
		SetActorEnableCollision_bNewActorEnableCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetActorEnableCollision_FunctionAddress, "bNewActorEnableCollision");
		SetActorEnableCollision_bNewActorEnableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorEnableCollision_FunctionAddress, "bNewActorEnableCollision", Classes.FBoolProperty);
		SetActorEnableCollision_IsValid = SetActorEnableCollision_FunctionAddress != IntPtr.Zero && SetActorEnableCollision_bNewActorEnableCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:SetActorEnableCollision", SetActorEnableCollision_IsValid);
		RemoveTickPrerequisiteComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTickPrerequisiteComponent");
		RemoveTickPrerequisiteComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTickPrerequisiteComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress, RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		RemoveTickPrerequisiteComponent_PrerequisiteComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent", Classes.FObjectProperty);
		RemoveTickPrerequisiteComponent_IsValid = RemoveTickPrerequisiteComponent_FunctionAddress != IntPtr.Zero && RemoveTickPrerequisiteComponent_PrerequisiteComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:RemoveTickPrerequisiteComponent", RemoveTickPrerequisiteComponent_IsValid);
		RemoveTickPrerequisiteActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTickPrerequisiteActor");
		RemoveTickPrerequisiteActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTickPrerequisiteActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTickPrerequisiteActor_PrerequisiteActor_PropertyAddress, RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		RemoveTickPrerequisiteActor_PrerequisiteActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor", Classes.FObjectProperty);
		RemoveTickPrerequisiteActor_IsValid = RemoveTickPrerequisiteActor_FunctionAddress != IntPtr.Zero && RemoveTickPrerequisiteActor_PrerequisiteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:RemoveTickPrerequisiteActor", RemoveTickPrerequisiteActor_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveTick", ReceiveTick_IsValid);
		ReceiveRadialDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveRadialDamage");
		ReceiveRadialDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveRadialDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_DamageReceived_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "DamageReceived");
		ReceiveRadialDamage_DamageReceived_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "DamageReceived");
		ReceiveRadialDamage_DamageReceived_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "DamageReceived", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_DamageType_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "DamageType");
		ReceiveRadialDamage_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "DamageType");
		ReceiveRadialDamage_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_Origin_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "Origin");
		ReceiveRadialDamage_Origin_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "Origin");
		ReceiveRadialDamage_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_HitInfo_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "HitInfo");
		ReceiveRadialDamage_HitInfo_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "HitInfo");
		ReceiveRadialDamage_HitInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "HitInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_InstigatedBy_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "InstigatedBy");
		ReceiveRadialDamage_InstigatedBy_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "InstigatedBy");
		ReceiveRadialDamage_InstigatedBy_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "InstigatedBy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveRadialDamage_DamageCauser_PropertyAddress, ReceiveRadialDamage_FunctionAddress, "DamageCauser");
		ReceiveRadialDamage_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveRadialDamage_FunctionAddress, "DamageCauser");
		ReceiveRadialDamage_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveRadialDamage_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		ReceiveRadialDamage_IsValid = ReceiveRadialDamage_FunctionAddress != IntPtr.Zero && ReceiveRadialDamage_DamageReceived_IsValid && ReceiveRadialDamage_DamageType_IsValid && ReceiveRadialDamage_Origin_IsValid && ReceiveRadialDamage_HitInfo_IsValid && ReceiveRadialDamage_InstigatedBy_IsValid && ReceiveRadialDamage_DamageCauser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveRadialDamage", ReceiveRadialDamage_IsValid);
		ReceivePointDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceivePointDamage");
		ReceivePointDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePointDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_Damage_PropertyAddress, ReceivePointDamage_FunctionAddress, "Damage");
		ReceivePointDamage_Damage_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "Damage");
		ReceivePointDamage_Damage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "Damage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_DamageType_PropertyAddress, ReceivePointDamage_FunctionAddress, "DamageType");
		ReceivePointDamage_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "DamageType");
		ReceivePointDamage_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_HitLocation_PropertyAddress, ReceivePointDamage_FunctionAddress, "HitLocation");
		ReceivePointDamage_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "HitLocation");
		ReceivePointDamage_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_HitNormal_PropertyAddress, ReceivePointDamage_FunctionAddress, "HitNormal");
		ReceivePointDamage_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "HitNormal");
		ReceivePointDamage_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_HitComponent_PropertyAddress, ReceivePointDamage_FunctionAddress, "HitComponent");
		ReceivePointDamage_HitComponent_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "HitComponent");
		ReceivePointDamage_HitComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "HitComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_BoneName_PropertyAddress, ReceivePointDamage_FunctionAddress, "BoneName");
		ReceivePointDamage_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "BoneName");
		ReceivePointDamage_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_ShotFromDirection_PropertyAddress, ReceivePointDamage_FunctionAddress, "ShotFromDirection");
		ReceivePointDamage_ShotFromDirection_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "ShotFromDirection");
		ReceivePointDamage_ShotFromDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "ShotFromDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_InstigatedBy_PropertyAddress, ReceivePointDamage_FunctionAddress, "InstigatedBy");
		ReceivePointDamage_InstigatedBy_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "InstigatedBy");
		ReceivePointDamage_InstigatedBy_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "InstigatedBy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_DamageCauser_PropertyAddress, ReceivePointDamage_FunctionAddress, "DamageCauser");
		ReceivePointDamage_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "DamageCauser");
		ReceivePointDamage_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivePointDamage_HitInfo_PropertyAddress, ReceivePointDamage_FunctionAddress, "HitInfo");
		ReceivePointDamage_HitInfo_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePointDamage_FunctionAddress, "HitInfo");
		ReceivePointDamage_HitInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePointDamage_FunctionAddress, "HitInfo", Classes.FStructProperty);
		ReceivePointDamage_IsValid = ReceivePointDamage_FunctionAddress != IntPtr.Zero && ReceivePointDamage_Damage_IsValid && ReceivePointDamage_DamageType_IsValid && ReceivePointDamage_HitLocation_IsValid && ReceivePointDamage_HitNormal_IsValid && ReceivePointDamage_HitComponent_IsValid && ReceivePointDamage_BoneName_IsValid && ReceivePointDamage_ShotFromDirection_IsValid && ReceivePointDamage_InstigatedBy_IsValid && ReceivePointDamage_DamageCauser_IsValid && ReceivePointDamage_HitInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceivePointDamage", ReceivePointDamage_IsValid);
		ReceiveHit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveHit");
		ReceiveHit_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveHit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_MyComp_PropertyAddress, ReceiveHit_FunctionAddress, "MyComp");
		ReceiveHit_MyComp_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "MyComp");
		ReceiveHit_MyComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "MyComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_Other_PropertyAddress, ReceiveHit_FunctionAddress, "Other");
		ReceiveHit_Other_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "Other");
		ReceiveHit_Other_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "Other", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_OtherComp_PropertyAddress, ReceiveHit_FunctionAddress, "OtherComp");
		ReceiveHit_OtherComp_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "OtherComp");
		ReceiveHit_OtherComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_bSelfMoved_PropertyAddress, ReceiveHit_FunctionAddress, "bSelfMoved");
		ReceiveHit_bSelfMoved_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "bSelfMoved");
		ReceiveHit_bSelfMoved_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "bSelfMoved", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_HitLocation_PropertyAddress, ReceiveHit_FunctionAddress, "HitLocation");
		ReceiveHit_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "HitLocation");
		ReceiveHit_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_HitNormal_PropertyAddress, ReceiveHit_FunctionAddress, "HitNormal");
		ReceiveHit_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "HitNormal");
		ReceiveHit_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_NormalImpulse_PropertyAddress, ReceiveHit_FunctionAddress, "NormalImpulse");
		ReceiveHit_NormalImpulse_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "NormalImpulse");
		ReceiveHit_NormalImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "NormalImpulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveHit_Hit_PropertyAddress, ReceiveHit_FunctionAddress, "Hit");
		ReceiveHit_Hit_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveHit_FunctionAddress, "Hit");
		ReceiveHit_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveHit_FunctionAddress, "Hit", Classes.FStructProperty);
		ReceiveHit_IsValid = ReceiveHit_FunctionAddress != IntPtr.Zero && ReceiveHit_MyComp_IsValid && ReceiveHit_Other_IsValid && ReceiveHit_OtherComp_IsValid && ReceiveHit_bSelfMoved_IsValid && ReceiveHit_HitLocation_IsValid && ReceiveHit_HitNormal_IsValid && ReceiveHit_NormalImpulse_IsValid && ReceiveHit_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveHit", ReceiveHit_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		ReceiveAnyDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveAnyDamage");
		ReceiveAnyDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveAnyDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAnyDamage_Damage_PropertyAddress, ReceiveAnyDamage_FunctionAddress, "Damage");
		ReceiveAnyDamage_Damage_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAnyDamage_FunctionAddress, "Damage");
		ReceiveAnyDamage_Damage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAnyDamage_FunctionAddress, "Damage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAnyDamage_DamageType_PropertyAddress, ReceiveAnyDamage_FunctionAddress, "DamageType");
		ReceiveAnyDamage_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAnyDamage_FunctionAddress, "DamageType");
		ReceiveAnyDamage_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAnyDamage_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAnyDamage_InstigatedBy_PropertyAddress, ReceiveAnyDamage_FunctionAddress, "InstigatedBy");
		ReceiveAnyDamage_InstigatedBy_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAnyDamage_FunctionAddress, "InstigatedBy");
		ReceiveAnyDamage_InstigatedBy_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAnyDamage_FunctionAddress, "InstigatedBy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAnyDamage_DamageCauser_PropertyAddress, ReceiveAnyDamage_FunctionAddress, "DamageCauser");
		ReceiveAnyDamage_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAnyDamage_FunctionAddress, "DamageCauser");
		ReceiveAnyDamage_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAnyDamage_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		ReceiveAnyDamage_IsValid = ReceiveAnyDamage_FunctionAddress != IntPtr.Zero && ReceiveAnyDamage_Damage_IsValid && ReceiveAnyDamage_DamageType_IsValid && ReceiveAnyDamage_InstigatedBy_IsValid && ReceiveAnyDamage_DamageCauser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveAnyDamage", ReceiveAnyDamage_IsValid);
		ReceiveActorOnReleased_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnReleased");
		ReceiveActorOnReleased_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnReleased_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnReleased_ButtonReleased_PropertyAddress, ReceiveActorOnReleased_FunctionAddress, "ButtonReleased");
		ReceiveActorOnReleased_ButtonReleased_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnReleased_FunctionAddress, "ButtonReleased");
		ReceiveActorOnReleased_ButtonReleased_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnReleased_FunctionAddress, "ButtonReleased", Classes.FStructProperty);
		ReceiveActorOnReleased_IsValid = ReceiveActorOnReleased_FunctionAddress != IntPtr.Zero && ReceiveActorOnReleased_ButtonReleased_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnReleased", ReceiveActorOnReleased_IsValid);
		ReceiveActorOnInputTouchLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnInputTouchLeave");
		ReceiveActorOnInputTouchLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnInputTouchLeave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnInputTouchLeave_FingerIndex_PropertyAddress, ReceiveActorOnInputTouchLeave_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchLeave_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnInputTouchLeave_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchLeave_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnInputTouchLeave_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		ReceiveActorOnInputTouchLeave_IsValid = ReceiveActorOnInputTouchLeave_FunctionAddress != IntPtr.Zero && ReceiveActorOnInputTouchLeave_FingerIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnInputTouchLeave", ReceiveActorOnInputTouchLeave_IsValid);
		ReceiveActorOnInputTouchEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnInputTouchEnter");
		ReceiveActorOnInputTouchEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnInputTouchEnter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnInputTouchEnter_FingerIndex_PropertyAddress, ReceiveActorOnInputTouchEnter_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchEnter_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnInputTouchEnter_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchEnter_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnInputTouchEnter_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		ReceiveActorOnInputTouchEnter_IsValid = ReceiveActorOnInputTouchEnter_FunctionAddress != IntPtr.Zero && ReceiveActorOnInputTouchEnter_FingerIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnInputTouchEnter", ReceiveActorOnInputTouchEnter_IsValid);
		ReceiveActorOnInputTouchEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnInputTouchEnd");
		ReceiveActorOnInputTouchEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnInputTouchEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnInputTouchEnd_FingerIndex_PropertyAddress, ReceiveActorOnInputTouchEnd_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchEnd_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnInputTouchEnd_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchEnd_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnInputTouchEnd_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		ReceiveActorOnInputTouchEnd_IsValid = ReceiveActorOnInputTouchEnd_FunctionAddress != IntPtr.Zero && ReceiveActorOnInputTouchEnd_FingerIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnInputTouchEnd", ReceiveActorOnInputTouchEnd_IsValid);
		ReceiveActorOnInputTouchBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnInputTouchBegin");
		ReceiveActorOnInputTouchBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnInputTouchBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnInputTouchBegin_FingerIndex_PropertyAddress, ReceiveActorOnInputTouchBegin_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchBegin_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnInputTouchBegin_FunctionAddress, "FingerIndex");
		ReceiveActorOnInputTouchBegin_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnInputTouchBegin_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		ReceiveActorOnInputTouchBegin_IsValid = ReceiveActorOnInputTouchBegin_FunctionAddress != IntPtr.Zero && ReceiveActorOnInputTouchBegin_FingerIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnInputTouchBegin", ReceiveActorOnInputTouchBegin_IsValid);
		ReceiveActorOnClicked_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorOnClicked");
		ReceiveActorOnClicked_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorOnClicked_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorOnClicked_ButtonPressed_PropertyAddress, ReceiveActorOnClicked_FunctionAddress, "ButtonPressed");
		ReceiveActorOnClicked_ButtonPressed_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorOnClicked_FunctionAddress, "ButtonPressed");
		ReceiveActorOnClicked_ButtonPressed_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorOnClicked_FunctionAddress, "ButtonPressed", Classes.FStructProperty);
		ReceiveActorOnClicked_IsValid = ReceiveActorOnClicked_FunctionAddress != IntPtr.Zero && ReceiveActorOnClicked_ButtonPressed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorOnClicked", ReceiveActorOnClicked_IsValid);
		ReceiveActorEndOverlap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorEndOverlap");
		ReceiveActorEndOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorEndOverlap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorEndOverlap_OtherActor_PropertyAddress, ReceiveActorEndOverlap_FunctionAddress, "OtherActor");
		ReceiveActorEndOverlap_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorEndOverlap_FunctionAddress, "OtherActor");
		ReceiveActorEndOverlap_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorEndOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		ReceiveActorEndOverlap_IsValid = ReceiveActorEndOverlap_FunctionAddress != IntPtr.Zero && ReceiveActorEndOverlap_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorEndOverlap", ReceiveActorEndOverlap_IsValid);
		ReceiveActorEndCursorOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorEndCursorOver");
		ReceiveActorEndCursorOver_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorEndCursorOver_FunctionAddress);
		ReceiveActorEndCursorOver_IsValid = ReceiveActorEndCursorOver_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorEndCursorOver", ReceiveActorEndCursorOver_IsValid);
		ReceiveActorBeginOverlap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorBeginOverlap");
		ReceiveActorBeginOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorBeginOverlap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActorBeginOverlap_OtherActor_PropertyAddress, ReceiveActorBeginOverlap_FunctionAddress, "OtherActor");
		ReceiveActorBeginOverlap_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActorBeginOverlap_FunctionAddress, "OtherActor");
		ReceiveActorBeginOverlap_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActorBeginOverlap_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		ReceiveActorBeginOverlap_IsValid = ReceiveActorBeginOverlap_FunctionAddress != IntPtr.Zero && ReceiveActorBeginOverlap_OtherActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorBeginOverlap", ReceiveActorBeginOverlap_IsValid);
		ReceiveActorBeginCursorOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActorBeginCursorOver");
		ReceiveActorBeginCursorOver_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActorBeginCursorOver_FunctionAddress);
		ReceiveActorBeginCursorOver_IsValid = ReceiveActorBeginCursorOver_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ReceiveActorBeginCursorOver", ReceiveActorBeginCursorOver_IsValid);
		PrestreamTextures_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrestreamTextures");
		PrestreamTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(PrestreamTextures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_Seconds_PropertyAddress, PrestreamTextures_FunctionAddress, "Seconds");
		PrestreamTextures_Seconds_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "Seconds");
		PrestreamTextures_Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "Seconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_bEnableStreaming_PropertyAddress, PrestreamTextures_FunctionAddress, "bEnableStreaming");
		PrestreamTextures_bEnableStreaming_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "bEnableStreaming");
		PrestreamTextures_bEnableStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "bEnableStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_CinematicTextureGroups_PropertyAddress, PrestreamTextures_FunctionAddress, "CinematicTextureGroups");
		PrestreamTextures_CinematicTextureGroups_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "CinematicTextureGroups");
		PrestreamTextures_CinematicTextureGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "CinematicTextureGroups", Classes.FIntProperty);
		PrestreamTextures_IsValid = PrestreamTextures_FunctionAddress != IntPtr.Zero && PrestreamTextures_Seconds_IsValid && PrestreamTextures_bEnableStreaming_IsValid && PrestreamTextures_CinematicTextureGroups_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:PrestreamTextures", PrestreamTextures_IsValid);
		MakeNoise_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeNoise");
		MakeNoise_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeNoise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_Loudness_PropertyAddress, MakeNoise_FunctionAddress, "Loudness");
		MakeNoise_Loudness_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "Loudness");
		MakeNoise_Loudness_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "Loudness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_NoiseInstigator_PropertyAddress, MakeNoise_FunctionAddress, "NoiseInstigator");
		MakeNoise_NoiseInstigator_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "NoiseInstigator");
		MakeNoise_NoiseInstigator_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "NoiseInstigator", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_NoiseLocation_PropertyAddress, MakeNoise_FunctionAddress, "NoiseLocation");
		MakeNoise_NoiseLocation_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "NoiseLocation");
		MakeNoise_NoiseLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "NoiseLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_MaxRange_PropertyAddress, MakeNoise_FunctionAddress, "MaxRange");
		MakeNoise_MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "MaxRange");
		MakeNoise_MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "MaxRange", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeNoise_Tag_PropertyAddress, MakeNoise_FunctionAddress, "Tag");
		MakeNoise_Tag_Offset = NativeReflectionCached.GetPropertyOffset(MakeNoise_FunctionAddress, "Tag");
		MakeNoise_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeNoise_FunctionAddress, "Tag", Classes.FNameProperty);
		MakeNoise_IsValid = MakeNoise_FunctionAddress != IntPtr.Zero && MakeNoise_Loudness_IsValid && MakeNoise_NoiseInstigator_IsValid && MakeNoise_NoiseLocation_IsValid && MakeNoise_MaxRange_IsValid && MakeNoise_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:MakeNoise", MakeNoise_IsValid);
		Teleport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_TeleportTo");
		Teleport_ParamsSize = NativeReflection.GetFunctionParamsSize(Teleport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Teleport_DestLocation_PropertyAddress, Teleport_FunctionAddress, "DestLocation");
		Teleport_DestLocation_Offset = NativeReflectionCached.GetPropertyOffset(Teleport_FunctionAddress, "DestLocation");
		Teleport_DestLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(Teleport_FunctionAddress, "DestLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Teleport_DestRotation_PropertyAddress, Teleport_FunctionAddress, "DestRotation");
		Teleport_DestRotation_Offset = NativeReflectionCached.GetPropertyOffset(Teleport_FunctionAddress, "DestRotation");
		Teleport_DestRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(Teleport_FunctionAddress, "DestRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Teleport_ReturnValue_PropertyAddress, Teleport_FunctionAddress, "ReturnValue");
		Teleport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Teleport_FunctionAddress, "ReturnValue");
		Teleport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Teleport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Teleport_IsValid = Teleport_FunctionAddress != IntPtr.Zero && Teleport_DestLocation_IsValid && Teleport_DestRotation_IsValid && Teleport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_TeleportTo", Teleport_IsValid);
		SetActorTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorTransform");
		SetActorTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_NewTransform_PropertyAddress, SetActorTransform_FunctionAddress, "NewTransform");
		SetActorTransform_NewTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "NewTransform");
		SetActorTransform_NewTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "NewTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_bSweep_PropertyAddress, SetActorTransform_FunctionAddress, "bSweep");
		SetActorTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "bSweep");
		SetActorTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_SweepHitResult_PropertyAddress, SetActorTransform_FunctionAddress, "SweepHitResult");
		SetActorTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "SweepHitResult");
		SetActorTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_bTeleport_PropertyAddress, SetActorTransform_FunctionAddress, "bTeleport");
		SetActorTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "bTeleport");
		SetActorTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorTransform_ReturnValue_PropertyAddress, SetActorTransform_FunctionAddress, "ReturnValue");
		SetActorTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorTransform_FunctionAddress, "ReturnValue");
		SetActorTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorTransform_IsValid = SetActorTransform_FunctionAddress != IntPtr.Zero && SetActorTransform_NewTransform_IsValid && SetActorTransform_bSweep_IsValid && SetActorTransform_SweepHitResult_IsValid && SetActorTransform_bTeleport_IsValid && SetActorTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorTransform", SetActorTransform_IsValid);
		SetActorRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorRotation");
		SetActorRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotation_NewRotation_PropertyAddress, SetActorRotation_FunctionAddress, "NewRotation");
		SetActorRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotation_FunctionAddress, "NewRotation");
		SetActorRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotation_bTeleportPhysics_PropertyAddress, SetActorRotation_FunctionAddress, "bTeleportPhysics");
		SetActorRotation_bTeleportPhysics_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotation_FunctionAddress, "bTeleportPhysics");
		SetActorRotation_bTeleportPhysics_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotation_FunctionAddress, "bTeleportPhysics", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRotation_ReturnValue_PropertyAddress, SetActorRotation_FunctionAddress, "ReturnValue");
		SetActorRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRotation_FunctionAddress, "ReturnValue");
		SetActorRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRotation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorRotation_IsValid = SetActorRotation_FunctionAddress != IntPtr.Zero && SetActorRotation_NewRotation_IsValid && SetActorRotation_bTeleportPhysics_IsValid && SetActorRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorRotation", SetActorRotation_IsValid);
		SetActorRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorRelativeTransform");
		SetActorRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeTransform_NewRelativeTransform_PropertyAddress, SetActorRelativeTransform_FunctionAddress, "NewRelativeTransform");
		SetActorRelativeTransform_NewRelativeTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeTransform_FunctionAddress, "NewRelativeTransform");
		SetActorRelativeTransform_NewRelativeTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeTransform_FunctionAddress, "NewRelativeTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeTransform_bSweep_PropertyAddress, SetActorRelativeTransform_FunctionAddress, "bSweep");
		SetActorRelativeTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeTransform_FunctionAddress, "bSweep");
		SetActorRelativeTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeTransform_SweepHitResult_PropertyAddress, SetActorRelativeTransform_FunctionAddress, "SweepHitResult");
		SetActorRelativeTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeTransform_FunctionAddress, "SweepHitResult");
		SetActorRelativeTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeTransform_bTeleport_PropertyAddress, SetActorRelativeTransform_FunctionAddress, "bTeleport");
		SetActorRelativeTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeTransform_FunctionAddress, "bTeleport");
		SetActorRelativeTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetActorRelativeTransform_IsValid = SetActorRelativeTransform_FunctionAddress != IntPtr.Zero && SetActorRelativeTransform_NewRelativeTransform_IsValid && SetActorRelativeTransform_bSweep_IsValid && SetActorRelativeTransform_SweepHitResult_IsValid && SetActorRelativeTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorRelativeTransform", SetActorRelativeTransform_IsValid);
		SetActorRelativeRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorRelativeRotation");
		SetActorRelativeRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRelativeRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeRotation_NewRelativeRotation_PropertyAddress, SetActorRelativeRotation_FunctionAddress, "NewRelativeRotation");
		SetActorRelativeRotation_NewRelativeRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeRotation_FunctionAddress, "NewRelativeRotation");
		SetActorRelativeRotation_NewRelativeRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeRotation_FunctionAddress, "NewRelativeRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeRotation_bSweep_PropertyAddress, SetActorRelativeRotation_FunctionAddress, "bSweep");
		SetActorRelativeRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeRotation_FunctionAddress, "bSweep");
		SetActorRelativeRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeRotation_SweepHitResult_PropertyAddress, SetActorRelativeRotation_FunctionAddress, "SweepHitResult");
		SetActorRelativeRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeRotation_FunctionAddress, "SweepHitResult");
		SetActorRelativeRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeRotation_bTeleport_PropertyAddress, SetActorRelativeRotation_FunctionAddress, "bTeleport");
		SetActorRelativeRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeRotation_FunctionAddress, "bTeleport");
		SetActorRelativeRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetActorRelativeRotation_IsValid = SetActorRelativeRotation_FunctionAddress != IntPtr.Zero && SetActorRelativeRotation_NewRelativeRotation_IsValid && SetActorRelativeRotation_bSweep_IsValid && SetActorRelativeRotation_SweepHitResult_IsValid && SetActorRelativeRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorRelativeRotation", SetActorRelativeRotation_IsValid);
		SetActorRelativeLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorRelativeLocation");
		SetActorRelativeLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorRelativeLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeLocation_NewRelativeLocation_PropertyAddress, SetActorRelativeLocation_FunctionAddress, "NewRelativeLocation");
		SetActorRelativeLocation_NewRelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeLocation_FunctionAddress, "NewRelativeLocation");
		SetActorRelativeLocation_NewRelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeLocation_FunctionAddress, "NewRelativeLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeLocation_bSweep_PropertyAddress, SetActorRelativeLocation_FunctionAddress, "bSweep");
		SetActorRelativeLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeLocation_FunctionAddress, "bSweep");
		SetActorRelativeLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeLocation_SweepHitResult_PropertyAddress, SetActorRelativeLocation_FunctionAddress, "SweepHitResult");
		SetActorRelativeLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeLocation_FunctionAddress, "SweepHitResult");
		SetActorRelativeLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorRelativeLocation_bTeleport_PropertyAddress, SetActorRelativeLocation_FunctionAddress, "bTeleport");
		SetActorRelativeLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorRelativeLocation_FunctionAddress, "bTeleport");
		SetActorRelativeLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorRelativeLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetActorRelativeLocation_IsValid = SetActorRelativeLocation_FunctionAddress != IntPtr.Zero && SetActorRelativeLocation_NewRelativeLocation_IsValid && SetActorRelativeLocation_bSweep_IsValid && SetActorRelativeLocation_SweepHitResult_IsValid && SetActorRelativeLocation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorRelativeLocation", SetActorRelativeLocation_IsValid);
		SetActorLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorLocationAndRotation");
		SetActorLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_NewLocation_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "NewLocation");
		SetActorLocationAndRotation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "NewLocation");
		SetActorLocationAndRotation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_NewRotation_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "NewRotation");
		SetActorLocationAndRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "NewRotation");
		SetActorLocationAndRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_bSweep_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "bSweep");
		SetActorLocationAndRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "bSweep");
		SetActorLocationAndRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_SweepHitResult_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetActorLocationAndRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetActorLocationAndRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_bTeleport_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "bTeleport");
		SetActorLocationAndRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "bTeleport");
		SetActorLocationAndRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocationAndRotation_ReturnValue_PropertyAddress, SetActorLocationAndRotation_FunctionAddress, "ReturnValue");
		SetActorLocationAndRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocationAndRotation_FunctionAddress, "ReturnValue");
		SetActorLocationAndRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocationAndRotation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorLocationAndRotation_IsValid = SetActorLocationAndRotation_FunctionAddress != IntPtr.Zero && SetActorLocationAndRotation_NewLocation_IsValid && SetActorLocationAndRotation_NewRotation_IsValid && SetActorLocationAndRotation_bSweep_IsValid && SetActorLocationAndRotation_SweepHitResult_IsValid && SetActorLocationAndRotation_bTeleport_IsValid && SetActorLocationAndRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorLocationAndRotation", SetActorLocationAndRotation_IsValid);
		SetActorLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetActorLocation");
		SetActorLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_NewLocation_PropertyAddress, SetActorLocation_FunctionAddress, "NewLocation");
		SetActorLocation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "NewLocation");
		SetActorLocation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_bSweep_PropertyAddress, SetActorLocation_FunctionAddress, "bSweep");
		SetActorLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "bSweep");
		SetActorLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_SweepHitResult_PropertyAddress, SetActorLocation_FunctionAddress, "SweepHitResult");
		SetActorLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "SweepHitResult");
		SetActorLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_bTeleport_PropertyAddress, SetActorLocation_FunctionAddress, "bTeleport");
		SetActorLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "bTeleport");
		SetActorLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_ReturnValue_PropertyAddress, SetActorLocation_FunctionAddress, "ReturnValue");
		SetActorLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "ReturnValue");
		SetActorLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorLocation_IsValid = SetActorLocation_FunctionAddress != IntPtr.Zero && SetActorLocation_NewLocation_IsValid && SetActorLocation_bSweep_IsValid && SetActorLocation_SweepHitResult_IsValid && SetActorLocation_bTeleport_IsValid && SetActorLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_SetActorLocation", SetActorLocation_IsValid);
		OnReset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnReset");
		OnReset_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReset_FunctionAddress);
		OnReset_IsValid = OnReset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_OnReset", OnReset_IsValid);
		OnEndViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnEndViewTarget");
		OnEndViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEndViewTarget_PC_PropertyAddress, OnEndViewTarget_FunctionAddress, "PC");
		OnEndViewTarget_PC_Offset = NativeReflectionCached.GetPropertyOffset(OnEndViewTarget_FunctionAddress, "PC");
		OnEndViewTarget_PC_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndViewTarget_FunctionAddress, "PC", Classes.FObjectProperty);
		OnEndViewTarget_IsValid = OnEndViewTarget_FunctionAddress != IntPtr.Zero && OnEndViewTarget_PC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_OnEndViewTarget", OnEndViewTarget_IsValid);
		OnBecomeViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnBecomeViewTarget");
		OnBecomeViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBecomeViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnBecomeViewTarget_PC_PropertyAddress, OnBecomeViewTarget_FunctionAddress, "PC");
		OnBecomeViewTarget_PC_Offset = NativeReflectionCached.GetPropertyOffset(OnBecomeViewTarget_FunctionAddress, "PC");
		OnBecomeViewTarget_PC_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBecomeViewTarget_FunctionAddress, "PC", Classes.FObjectProperty);
		OnBecomeViewTarget_IsValid = OnBecomeViewTarget_FunctionAddress != IntPtr.Zero && OnBecomeViewTarget_PC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_OnBecomeViewTarget", OnBecomeViewTarget_IsValid);
		GetRootComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetRootComponent");
		GetRootComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootComponent_ReturnValue_PropertyAddress, GetRootComponent_FunctionAddress, "ReturnValue");
		GetRootComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootComponent_FunctionAddress, "ReturnValue");
		GetRootComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRootComponent_IsValid = GetRootComponent_FunctionAddress != IntPtr.Zero && GetRootComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_GetRootComponent", GetRootComponent_IsValid);
		GetComponentsByClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetComponentsByClass");
		GetComponentsByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentsByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByClass_ComponentClass_PropertyAddress, GetComponentsByClass_FunctionAddress, "ComponentClass");
		GetComponentsByClass_ComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByClass_FunctionAddress, "ComponentClass");
		GetComponentsByClass_ComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByClass_FunctionAddress, "ComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByClass_ReturnValue_PropertyAddress, GetComponentsByClass_FunctionAddress, "ReturnValue");
		GetComponentsByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByClass_FunctionAddress, "ReturnValue");
		GetComponentsByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetComponentsByClass_IsValid = GetComponentsByClass_FunctionAddress != IntPtr.Zero && GetComponentsByClass_ComponentClass_IsValid && GetComponentsByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_GetComponentsByClass", GetComponentsByClass_IsValid);
		GetActorRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetActorRotation");
		GetActorRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorRotation_ReturnValue_PropertyAddress, GetActorRotation_FunctionAddress, "ReturnValue");
		GetActorRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRotation_FunctionAddress, "ReturnValue");
		GetActorRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorRotation_IsValid = GetActorRotation_FunctionAddress != IntPtr.Zero && GetActorRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_GetActorRotation", GetActorRotation_IsValid);
		GetActorLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetActorLocation");
		GetActorLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocation_ReturnValue_PropertyAddress, GetActorLocation_FunctionAddress, "ReturnValue");
		GetActorLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocation_FunctionAddress, "ReturnValue");
		GetActorLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorLocation_IsValid = GetActorLocation_FunctionAddress != IntPtr.Zero && GetActorLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_GetActorLocation", GetActorLocation_IsValid);
		DetachFromActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_DetachFromActor");
		DetachFromActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DetachFromActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetachFromActor_LocationRule_PropertyAddress, DetachFromActor_FunctionAddress, "LocationRule");
		DetachFromActor_LocationRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromActor_FunctionAddress, "LocationRule");
		DetachFromActor_LocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromActor_FunctionAddress, "LocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromActor_RotationRule_PropertyAddress, DetachFromActor_FunctionAddress, "RotationRule");
		DetachFromActor_RotationRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromActor_FunctionAddress, "RotationRule");
		DetachFromActor_RotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromActor_FunctionAddress, "RotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromActor_ScaleRule_PropertyAddress, DetachFromActor_FunctionAddress, "ScaleRule");
		DetachFromActor_ScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromActor_FunctionAddress, "ScaleRule");
		DetachFromActor_ScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromActor_FunctionAddress, "ScaleRule", Classes.FEnumProperty);
		DetachFromActor_IsValid = DetachFromActor_FunctionAddress != IntPtr.Zero && DetachFromActor_LocationRule_IsValid && DetachFromActor_RotationRule_IsValid && DetachFromActor_ScaleRule_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_DetachFromActor", DetachFromActor_IsValid);
		DestroyActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_DestroyActor");
		DestroyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyActor_FunctionAddress);
		DestroyActor_IsValid = DestroyActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_DestroyActor", DestroyActor_IsValid);
		AttachToComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AttachToComponent");
		AttachToComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachToComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_Parent_PropertyAddress, AttachToComponent_FunctionAddress, "Parent");
		AttachToComponent_Parent_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "Parent");
		AttachToComponent_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "Parent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_SocketName_PropertyAddress, AttachToComponent_FunctionAddress, "SocketName");
		AttachToComponent_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "SocketName");
		AttachToComponent_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_LocationRule_PropertyAddress, AttachToComponent_FunctionAddress, "LocationRule");
		AttachToComponent_LocationRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "LocationRule");
		AttachToComponent_LocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "LocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_RotationRule_PropertyAddress, AttachToComponent_FunctionAddress, "RotationRule");
		AttachToComponent_RotationRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "RotationRule");
		AttachToComponent_RotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "RotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_ScaleRule_PropertyAddress, AttachToComponent_FunctionAddress, "ScaleRule");
		AttachToComponent_ScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "ScaleRule");
		AttachToComponent_ScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "ScaleRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_bWeldSimulatedBodies_PropertyAddress, AttachToComponent_FunctionAddress, "bWeldSimulatedBodies");
		AttachToComponent_bWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "bWeldSimulatedBodies");
		AttachToComponent_bWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "bWeldSimulatedBodies", Classes.FBoolProperty);
		AttachToComponent_IsValid = AttachToComponent_FunctionAddress != IntPtr.Zero && AttachToComponent_Parent_IsValid && AttachToComponent_SocketName_IsValid && AttachToComponent_LocationRule_IsValid && AttachToComponent_RotationRule_IsValid && AttachToComponent_ScaleRule_IsValid && AttachToComponent_bWeldSimulatedBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AttachToComponent", AttachToComponent_IsValid);
		AttachToActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AttachToActor");
		AttachToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_ParentActor_PropertyAddress, AttachToActor_FunctionAddress, "ParentActor");
		AttachToActor_ParentActor_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "ParentActor");
		AttachToActor_ParentActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "ParentActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_SocketName_PropertyAddress, AttachToActor_FunctionAddress, "SocketName");
		AttachToActor_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "SocketName");
		AttachToActor_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_LocationRule_PropertyAddress, AttachToActor_FunctionAddress, "LocationRule");
		AttachToActor_LocationRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "LocationRule");
		AttachToActor_LocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "LocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_RotationRule_PropertyAddress, AttachToActor_FunctionAddress, "RotationRule");
		AttachToActor_RotationRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "RotationRule");
		AttachToActor_RotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "RotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_ScaleRule_PropertyAddress, AttachToActor_FunctionAddress, "ScaleRule");
		AttachToActor_ScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "ScaleRule");
		AttachToActor_ScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "ScaleRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachToActor_bWeldSimulatedBodies_PropertyAddress, AttachToActor_FunctionAddress, "bWeldSimulatedBodies");
		AttachToActor_bWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(AttachToActor_FunctionAddress, "bWeldSimulatedBodies");
		AttachToActor_bWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToActor_FunctionAddress, "bWeldSimulatedBodies", Classes.FBoolProperty);
		AttachToActor_IsValid = AttachToActor_FunctionAddress != IntPtr.Zero && AttachToActor_ParentActor_IsValid && AttachToActor_SocketName_IsValid && AttachToActor_LocationRule_IsValid && AttachToActor_RotationRule_IsValid && AttachToActor_ScaleRule_IsValid && AttachToActor_bWeldSimulatedBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AttachToActor", AttachToActor_IsValid);
		AttachRootComponentToActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AttachRootComponentToActor");
		AttachRootComponentToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachRootComponentToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentToActor_InParentActor_PropertyAddress, AttachRootComponentToActor_FunctionAddress, "InParentActor");
		AttachRootComponentToActor_InParentActor_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentToActor_FunctionAddress, "InParentActor");
		AttachRootComponentToActor_InParentActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentToActor_FunctionAddress, "InParentActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentToActor_InSocketName_PropertyAddress, AttachRootComponentToActor_FunctionAddress, "InSocketName");
		AttachRootComponentToActor_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentToActor_FunctionAddress, "InSocketName");
		AttachRootComponentToActor_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentToActor_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentToActor_AttachLocationType_PropertyAddress, AttachRootComponentToActor_FunctionAddress, "AttachLocationType");
		AttachRootComponentToActor_AttachLocationType_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentToActor_FunctionAddress, "AttachLocationType");
		AttachRootComponentToActor_AttachLocationType_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentToActor_FunctionAddress, "AttachLocationType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentToActor_bWeldSimulatedBodies_PropertyAddress, AttachRootComponentToActor_FunctionAddress, "bWeldSimulatedBodies");
		AttachRootComponentToActor_bWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentToActor_FunctionAddress, "bWeldSimulatedBodies");
		AttachRootComponentToActor_bWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentToActor_FunctionAddress, "bWeldSimulatedBodies", Classes.FBoolProperty);
		AttachRootComponentToActor_IsValid = AttachRootComponentToActor_FunctionAddress != IntPtr.Zero && AttachRootComponentToActor_InParentActor_IsValid && AttachRootComponentToActor_InSocketName_IsValid && AttachRootComponentToActor_AttachLocationType_IsValid && AttachRootComponentToActor_bWeldSimulatedBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AttachRootComponentToActor", AttachRootComponentToActor_IsValid);
		AttachRootComponentTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AttachRootComponentTo");
		AttachRootComponentTo_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachRootComponentTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentTo_InParent_PropertyAddress, AttachRootComponentTo_FunctionAddress, "InParent");
		AttachRootComponentTo_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentTo_FunctionAddress, "InParent");
		AttachRootComponentTo_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentTo_FunctionAddress, "InParent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentTo_InSocketName_PropertyAddress, AttachRootComponentTo_FunctionAddress, "InSocketName");
		AttachRootComponentTo_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentTo_FunctionAddress, "InSocketName");
		AttachRootComponentTo_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentTo_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentTo_AttachLocationType_PropertyAddress, AttachRootComponentTo_FunctionAddress, "AttachLocationType");
		AttachRootComponentTo_AttachLocationType_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentTo_FunctionAddress, "AttachLocationType");
		AttachRootComponentTo_AttachLocationType_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentTo_FunctionAddress, "AttachLocationType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachRootComponentTo_bWeldSimulatedBodies_PropertyAddress, AttachRootComponentTo_FunctionAddress, "bWeldSimulatedBodies");
		AttachRootComponentTo_bWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(AttachRootComponentTo_FunctionAddress, "bWeldSimulatedBodies");
		AttachRootComponentTo_bWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachRootComponentTo_FunctionAddress, "bWeldSimulatedBodies", Classes.FBoolProperty);
		AttachRootComponentTo_IsValid = AttachRootComponentTo_FunctionAddress != IntPtr.Zero && AttachRootComponentTo_InParent_IsValid && AttachRootComponentTo_InSocketName_IsValid && AttachRootComponentTo_AttachLocationType_IsValid && AttachRootComponentTo_bWeldSimulatedBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AttachRootComponentTo", AttachRootComponentTo_IsValid);
		AddActorWorldTransformKeepScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorWorldTransformKeepScale");
		AddActorWorldTransformKeepScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorWorldTransformKeepScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransformKeepScale_DeltaTransform_PropertyAddress, AddActorWorldTransformKeepScale_FunctionAddress, "DeltaTransform");
		AddActorWorldTransformKeepScale_DeltaTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransformKeepScale_FunctionAddress, "DeltaTransform");
		AddActorWorldTransformKeepScale_DeltaTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransformKeepScale_FunctionAddress, "DeltaTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransformKeepScale_bSweep_PropertyAddress, AddActorWorldTransformKeepScale_FunctionAddress, "bSweep");
		AddActorWorldTransformKeepScale_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransformKeepScale_FunctionAddress, "bSweep");
		AddActorWorldTransformKeepScale_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransformKeepScale_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransformKeepScale_SweepHitResult_PropertyAddress, AddActorWorldTransformKeepScale_FunctionAddress, "SweepHitResult");
		AddActorWorldTransformKeepScale_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransformKeepScale_FunctionAddress, "SweepHitResult");
		AddActorWorldTransformKeepScale_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransformKeepScale_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransformKeepScale_bTeleport_PropertyAddress, AddActorWorldTransformKeepScale_FunctionAddress, "bTeleport");
		AddActorWorldTransformKeepScale_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransformKeepScale_FunctionAddress, "bTeleport");
		AddActorWorldTransformKeepScale_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransformKeepScale_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorWorldTransformKeepScale_IsValid = AddActorWorldTransformKeepScale_FunctionAddress != IntPtr.Zero && AddActorWorldTransformKeepScale_DeltaTransform_IsValid && AddActorWorldTransformKeepScale_bSweep_IsValid && AddActorWorldTransformKeepScale_SweepHitResult_IsValid && AddActorWorldTransformKeepScale_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorWorldTransformKeepScale", AddActorWorldTransformKeepScale_IsValid);
		AddActorWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorWorldTransform");
		AddActorWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransform_DeltaTransform_PropertyAddress, AddActorWorldTransform_FunctionAddress, "DeltaTransform");
		AddActorWorldTransform_DeltaTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransform_FunctionAddress, "DeltaTransform");
		AddActorWorldTransform_DeltaTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransform_FunctionAddress, "DeltaTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransform_bSweep_PropertyAddress, AddActorWorldTransform_FunctionAddress, "bSweep");
		AddActorWorldTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransform_FunctionAddress, "bSweep");
		AddActorWorldTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransform_SweepHitResult_PropertyAddress, AddActorWorldTransform_FunctionAddress, "SweepHitResult");
		AddActorWorldTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransform_FunctionAddress, "SweepHitResult");
		AddActorWorldTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldTransform_bTeleport_PropertyAddress, AddActorWorldTransform_FunctionAddress, "bTeleport");
		AddActorWorldTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldTransform_FunctionAddress, "bTeleport");
		AddActorWorldTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorWorldTransform_IsValid = AddActorWorldTransform_FunctionAddress != IntPtr.Zero && AddActorWorldTransform_DeltaTransform_IsValid && AddActorWorldTransform_bSweep_IsValid && AddActorWorldTransform_SweepHitResult_IsValid && AddActorWorldTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorWorldTransform", AddActorWorldTransform_IsValid);
		AddActorWorldRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorWorldRotation");
		AddActorWorldRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorWorldRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldRotation_DeltaRotation_PropertyAddress, AddActorWorldRotation_FunctionAddress, "DeltaRotation");
		AddActorWorldRotation_DeltaRotation_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldRotation_FunctionAddress, "DeltaRotation");
		AddActorWorldRotation_DeltaRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldRotation_FunctionAddress, "DeltaRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldRotation_bSweep_PropertyAddress, AddActorWorldRotation_FunctionAddress, "bSweep");
		AddActorWorldRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldRotation_FunctionAddress, "bSweep");
		AddActorWorldRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldRotation_SweepHitResult_PropertyAddress, AddActorWorldRotation_FunctionAddress, "SweepHitResult");
		AddActorWorldRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldRotation_FunctionAddress, "SweepHitResult");
		AddActorWorldRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldRotation_bTeleport_PropertyAddress, AddActorWorldRotation_FunctionAddress, "bTeleport");
		AddActorWorldRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldRotation_FunctionAddress, "bTeleport");
		AddActorWorldRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorWorldRotation_IsValid = AddActorWorldRotation_FunctionAddress != IntPtr.Zero && AddActorWorldRotation_DeltaRotation_IsValid && AddActorWorldRotation_bSweep_IsValid && AddActorWorldRotation_SweepHitResult_IsValid && AddActorWorldRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorWorldRotation", AddActorWorldRotation_IsValid);
		AddActorWorldOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorWorldOffset");
		AddActorWorldOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorWorldOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldOffset_DeltaLocation_PropertyAddress, AddActorWorldOffset_FunctionAddress, "DeltaLocation");
		AddActorWorldOffset_DeltaLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldOffset_FunctionAddress, "DeltaLocation");
		AddActorWorldOffset_DeltaLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldOffset_FunctionAddress, "DeltaLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldOffset_bSweep_PropertyAddress, AddActorWorldOffset_FunctionAddress, "bSweep");
		AddActorWorldOffset_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldOffset_FunctionAddress, "bSweep");
		AddActorWorldOffset_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldOffset_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldOffset_SweepHitResult_PropertyAddress, AddActorWorldOffset_FunctionAddress, "SweepHitResult");
		AddActorWorldOffset_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldOffset_FunctionAddress, "SweepHitResult");
		AddActorWorldOffset_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldOffset_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorWorldOffset_bTeleport_PropertyAddress, AddActorWorldOffset_FunctionAddress, "bTeleport");
		AddActorWorldOffset_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorWorldOffset_FunctionAddress, "bTeleport");
		AddActorWorldOffset_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorWorldOffset_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorWorldOffset_IsValid = AddActorWorldOffset_FunctionAddress != IntPtr.Zero && AddActorWorldOffset_DeltaLocation_IsValid && AddActorWorldOffset_bSweep_IsValid && AddActorWorldOffset_SweepHitResult_IsValid && AddActorWorldOffset_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorWorldOffset", AddActorWorldOffset_IsValid);
		AddActorLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorLocalTransform");
		AddActorLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalTransform_NewTransform_PropertyAddress, AddActorLocalTransform_FunctionAddress, "NewTransform");
		AddActorLocalTransform_NewTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalTransform_FunctionAddress, "NewTransform");
		AddActorLocalTransform_NewTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalTransform_FunctionAddress, "NewTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalTransform_bSweep_PropertyAddress, AddActorLocalTransform_FunctionAddress, "bSweep");
		AddActorLocalTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalTransform_FunctionAddress, "bSweep");
		AddActorLocalTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalTransform_SweepHitResult_PropertyAddress, AddActorLocalTransform_FunctionAddress, "SweepHitResult");
		AddActorLocalTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalTransform_FunctionAddress, "SweepHitResult");
		AddActorLocalTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalTransform_bTeleport_PropertyAddress, AddActorLocalTransform_FunctionAddress, "bTeleport");
		AddActorLocalTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalTransform_FunctionAddress, "bTeleport");
		AddActorLocalTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorLocalTransform_IsValid = AddActorLocalTransform_FunctionAddress != IntPtr.Zero && AddActorLocalTransform_NewTransform_IsValid && AddActorLocalTransform_bSweep_IsValid && AddActorLocalTransform_SweepHitResult_IsValid && AddActorLocalTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorLocalTransform", AddActorLocalTransform_IsValid);
		AddActorLocalRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorLocalRotation");
		AddActorLocalRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorLocalRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalRotation_DeltaRotation_PropertyAddress, AddActorLocalRotation_FunctionAddress, "DeltaRotation");
		AddActorLocalRotation_DeltaRotation_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalRotation_FunctionAddress, "DeltaRotation");
		AddActorLocalRotation_DeltaRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalRotation_FunctionAddress, "DeltaRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalRotation_bSweep_PropertyAddress, AddActorLocalRotation_FunctionAddress, "bSweep");
		AddActorLocalRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalRotation_FunctionAddress, "bSweep");
		AddActorLocalRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalRotation_SweepHitResult_PropertyAddress, AddActorLocalRotation_FunctionAddress, "SweepHitResult");
		AddActorLocalRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalRotation_FunctionAddress, "SweepHitResult");
		AddActorLocalRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalRotation_bTeleport_PropertyAddress, AddActorLocalRotation_FunctionAddress, "bTeleport");
		AddActorLocalRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalRotation_FunctionAddress, "bTeleport");
		AddActorLocalRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorLocalRotation_IsValid = AddActorLocalRotation_FunctionAddress != IntPtr.Zero && AddActorLocalRotation_DeltaRotation_IsValid && AddActorLocalRotation_bSweep_IsValid && AddActorLocalRotation_SweepHitResult_IsValid && AddActorLocalRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorLocalRotation", AddActorLocalRotation_IsValid);
		AddActorLocalOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddActorLocalOffset");
		AddActorLocalOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorLocalOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalOffset_DeltaLocation_PropertyAddress, AddActorLocalOffset_FunctionAddress, "DeltaLocation");
		AddActorLocalOffset_DeltaLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalOffset_FunctionAddress, "DeltaLocation");
		AddActorLocalOffset_DeltaLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalOffset_FunctionAddress, "DeltaLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalOffset_bSweep_PropertyAddress, AddActorLocalOffset_FunctionAddress, "bSweep");
		AddActorLocalOffset_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalOffset_FunctionAddress, "bSweep");
		AddActorLocalOffset_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalOffset_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalOffset_SweepHitResult_PropertyAddress, AddActorLocalOffset_FunctionAddress, "SweepHitResult");
		AddActorLocalOffset_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalOffset_FunctionAddress, "SweepHitResult");
		AddActorLocalOffset_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalOffset_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActorLocalOffset_bTeleport_PropertyAddress, AddActorLocalOffset_FunctionAddress, "bTeleport");
		AddActorLocalOffset_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddActorLocalOffset_FunctionAddress, "bTeleport");
		AddActorLocalOffset_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorLocalOffset_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddActorLocalOffset_IsValid = AddActorLocalOffset_FunctionAddress != IntPtr.Zero && AddActorLocalOffset_DeltaLocation_IsValid && AddActorLocalOffset_bSweep_IsValid && AddActorLocalOffset_SweepHitResult_IsValid && AddActorLocalOffset_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:K2_AddActorLocalOffset", AddActorLocalOffset_IsValid);
		IsTemporarilyHiddenInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsTemporarilyHiddenInEditor");
		IsTemporarilyHiddenInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTemporarilyHiddenInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTemporarilyHiddenInEditor_bIncludeParent_PropertyAddress, IsTemporarilyHiddenInEditor_FunctionAddress, "bIncludeParent");
		IsTemporarilyHiddenInEditor_bIncludeParent_Offset = NativeReflectionCached.GetPropertyOffset(IsTemporarilyHiddenInEditor_FunctionAddress, "bIncludeParent");
		IsTemporarilyHiddenInEditor_bIncludeParent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTemporarilyHiddenInEditor_FunctionAddress, "bIncludeParent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTemporarilyHiddenInEditor_ReturnValue_PropertyAddress, IsTemporarilyHiddenInEditor_FunctionAddress, "ReturnValue");
		IsTemporarilyHiddenInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTemporarilyHiddenInEditor_FunctionAddress, "ReturnValue");
		IsTemporarilyHiddenInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTemporarilyHiddenInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTemporarilyHiddenInEditor_IsValid = IsTemporarilyHiddenInEditor_FunctionAddress != IntPtr.Zero && IsTemporarilyHiddenInEditor_bIncludeParent_IsValid && IsTemporarilyHiddenInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsTemporarilyHiddenInEditor", IsTemporarilyHiddenInEditor_IsValid);
		IsSelectable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSelectable");
		IsSelectable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSelectable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSelectable_ReturnValue_PropertyAddress, IsSelectable_FunctionAddress, "ReturnValue");
		IsSelectable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSelectable_FunctionAddress, "ReturnValue");
		IsSelectable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelectable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSelectable_IsValid = IsSelectable_FunctionAddress != IntPtr.Zero && IsSelectable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsSelectable", IsSelectable_IsValid);
		IsOverlappingActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverlappingActor");
		IsOverlappingActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverlappingActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingActor_Other_PropertyAddress, IsOverlappingActor_FunctionAddress, "Other");
		IsOverlappingActor_Other_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingActor_FunctionAddress, "Other");
		IsOverlappingActor_Other_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingActor_FunctionAddress, "Other", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingActor_ReturnValue_PropertyAddress, IsOverlappingActor_FunctionAddress, "ReturnValue");
		IsOverlappingActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingActor_FunctionAddress, "ReturnValue");
		IsOverlappingActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverlappingActor_IsValid = IsOverlappingActor_FunctionAddress != IntPtr.Zero && IsOverlappingActor_Other_IsValid && IsOverlappingActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsOverlappingActor", IsOverlappingActor_IsValid);
		IsHiddenEdAtStartup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsHiddenEdAtStartup");
		IsHiddenEdAtStartup_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHiddenEdAtStartup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHiddenEdAtStartup_ReturnValue_PropertyAddress, IsHiddenEdAtStartup_FunctionAddress, "ReturnValue");
		IsHiddenEdAtStartup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHiddenEdAtStartup_FunctionAddress, "ReturnValue");
		IsHiddenEdAtStartup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHiddenEdAtStartup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHiddenEdAtStartup_IsValid = IsHiddenEdAtStartup_FunctionAddress != IntPtr.Zero && IsHiddenEdAtStartup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsHiddenEdAtStartup", IsHiddenEdAtStartup_IsValid);
		IsHiddenEd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsHiddenEd");
		IsHiddenEd_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHiddenEd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHiddenEd_ReturnValue_PropertyAddress, IsHiddenEd_FunctionAddress, "ReturnValue");
		IsHiddenEd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHiddenEd_FunctionAddress, "ReturnValue");
		IsHiddenEd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHiddenEd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHiddenEd_IsValid = IsHiddenEd_FunctionAddress != IntPtr.Zero && IsHiddenEd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsHiddenEd", IsHiddenEd_IsValid);
		IsEditable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEditable");
		IsEditable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEditable_ReturnValue_PropertyAddress, IsEditable_FunctionAddress, "ReturnValue");
		IsEditable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEditable_FunctionAddress, "ReturnValue");
		IsEditable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditable_IsValid = IsEditable_FunctionAddress != IntPtr.Zero && IsEditable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsEditable", IsEditable_IsValid);
		IsChildActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsChildActor");
		IsChildActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsChildActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsChildActor_ReturnValue_PropertyAddress, IsChildActor_FunctionAddress, "ReturnValue");
		IsChildActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsChildActor_FunctionAddress, "ReturnValue");
		IsChildActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsChildActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsChildActor_IsValid = IsChildActor_FunctionAddress != IntPtr.Zero && IsChildActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsChildActor", IsChildActor_IsValid);
		IsActorTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActorTickEnabled");
		IsActorTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorTickEnabled_ReturnValue_PropertyAddress, IsActorTickEnabled_FunctionAddress, "ReturnValue");
		IsActorTickEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorTickEnabled_FunctionAddress, "ReturnValue");
		IsActorTickEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorTickEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorTickEnabled_IsValid = IsActorTickEnabled_FunctionAddress != IntPtr.Zero && IsActorTickEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsActorTickEnabled", IsActorTickEnabled_IsValid);
		IsActorBeingDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsActorBeingDestroyed");
		IsActorBeingDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorBeingDestroyed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorBeingDestroyed_ReturnValue_PropertyAddress, IsActorBeingDestroyed_FunctionAddress, "ReturnValue");
		IsActorBeingDestroyed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorBeingDestroyed_FunctionAddress, "ReturnValue");
		IsActorBeingDestroyed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorBeingDestroyed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorBeingDestroyed_IsValid = IsActorBeingDestroyed_FunctionAddress != IntPtr.Zero && IsActorBeingDestroyed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:IsActorBeingDestroyed", IsActorBeingDestroyed_IsValid);
		HasAuthority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasAuthority");
		HasAuthority_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAuthority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAuthority_ReturnValue_PropertyAddress, HasAuthority_FunctionAddress, "ReturnValue");
		HasAuthority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAuthority_FunctionAddress, "ReturnValue");
		HasAuthority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAuthority_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAuthority_IsValid = HasAuthority_FunctionAddress != IntPtr.Zero && HasAuthority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:HasAuthority", HasAuthority_IsValid);
		GetVerticalDistanceTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVerticalDistanceTo");
		GetVerticalDistanceTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVerticalDistanceTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVerticalDistanceTo_OtherActor_PropertyAddress, GetVerticalDistanceTo_FunctionAddress, "OtherActor");
		GetVerticalDistanceTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetVerticalDistanceTo_FunctionAddress, "OtherActor");
		GetVerticalDistanceTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVerticalDistanceTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVerticalDistanceTo_ReturnValue_PropertyAddress, GetVerticalDistanceTo_FunctionAddress, "ReturnValue");
		GetVerticalDistanceTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVerticalDistanceTo_FunctionAddress, "ReturnValue");
		GetVerticalDistanceTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVerticalDistanceTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetVerticalDistanceTo_IsValid = GetVerticalDistanceTo_FunctionAddress != IntPtr.Zero && GetVerticalDistanceTo_OtherActor_IsValid && GetVerticalDistanceTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetVerticalDistanceTo", GetVerticalDistanceTo_IsValid);
		GetVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVelocity");
		GetVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVelocity_ReturnValue_PropertyAddress, GetVelocity_FunctionAddress, "ReturnValue");
		GetVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVelocity_FunctionAddress, "ReturnValue");
		GetVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVelocity_IsValid = GetVelocity_FunctionAddress != IntPtr.Zero && GetVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetVelocity", GetVelocity_IsValid);
		GetActorTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTransform");
		GetActorTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorTransform_ReturnValue_PropertyAddress, GetActorTransform_FunctionAddress, "ReturnValue");
		GetActorTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorTransform_FunctionAddress, "ReturnValue");
		GetActorTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorTransform_IsValid = GetActorTransform_FunctionAddress != IntPtr.Zero && GetActorTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetTransform", GetActorTransform_IsValid);
		GetTickableWhenPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTickableWhenPaused");
		GetTickableWhenPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTickableWhenPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTickableWhenPaused_ReturnValue_PropertyAddress, GetTickableWhenPaused_FunctionAddress, "ReturnValue");
		GetTickableWhenPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTickableWhenPaused_FunctionAddress, "ReturnValue");
		GetTickableWhenPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickableWhenPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTickableWhenPaused_IsValid = GetTickableWhenPaused_FunctionAddress != IntPtr.Zero && GetTickableWhenPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetTickableWhenPaused", GetTickableWhenPaused_IsValid);
		GetSquaredHorizontalDistanceTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSquaredHorizontalDistanceTo");
		GetSquaredHorizontalDistanceTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSquaredHorizontalDistanceTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSquaredHorizontalDistanceTo_OtherActor_PropertyAddress, GetSquaredHorizontalDistanceTo_FunctionAddress, "OtherActor");
		GetSquaredHorizontalDistanceTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetSquaredHorizontalDistanceTo_FunctionAddress, "OtherActor");
		GetSquaredHorizontalDistanceTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSquaredHorizontalDistanceTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSquaredHorizontalDistanceTo_ReturnValue_PropertyAddress, GetSquaredHorizontalDistanceTo_FunctionAddress, "ReturnValue");
		GetSquaredHorizontalDistanceTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSquaredHorizontalDistanceTo_FunctionAddress, "ReturnValue");
		GetSquaredHorizontalDistanceTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSquaredHorizontalDistanceTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSquaredHorizontalDistanceTo_IsValid = GetSquaredHorizontalDistanceTo_FunctionAddress != IntPtr.Zero && GetSquaredHorizontalDistanceTo_OtherActor_IsValid && GetSquaredHorizontalDistanceTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetSquaredHorizontalDistanceTo", GetSquaredHorizontalDistanceTo_IsValid);
		GetSquaredDistanceTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSquaredDistanceTo");
		GetSquaredDistanceTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSquaredDistanceTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSquaredDistanceTo_OtherActor_PropertyAddress, GetSquaredDistanceTo_FunctionAddress, "OtherActor");
		GetSquaredDistanceTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetSquaredDistanceTo_FunctionAddress, "OtherActor");
		GetSquaredDistanceTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSquaredDistanceTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSquaredDistanceTo_ReturnValue_PropertyAddress, GetSquaredDistanceTo_FunctionAddress, "ReturnValue");
		GetSquaredDistanceTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSquaredDistanceTo_FunctionAddress, "ReturnValue");
		GetSquaredDistanceTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSquaredDistanceTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSquaredDistanceTo_IsValid = GetSquaredDistanceTo_FunctionAddress != IntPtr.Zero && GetSquaredDistanceTo_OtherActor_IsValid && GetSquaredDistanceTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetSquaredDistanceTo", GetSquaredDistanceTo_IsValid);
		GetRemoteRole_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRemoteRole");
		GetRemoteRole_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRemoteRole_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRemoteRole_ReturnValue_PropertyAddress, GetRemoteRole_FunctionAddress, "ReturnValue");
		GetRemoteRole_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRemoteRole_FunctionAddress, "ReturnValue");
		GetRemoteRole_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRemoteRole_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetRemoteRole_IsValid = GetRemoteRole_FunctionAddress != IntPtr.Zero && GetRemoteRole_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetRemoteRole", GetRemoteRole_IsValid);
		GetRayTracingGroupId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRayTracingGroupId");
		GetRayTracingGroupId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRayTracingGroupId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRayTracingGroupId_ReturnValue_PropertyAddress, GetRayTracingGroupId_FunctionAddress, "ReturnValue");
		GetRayTracingGroupId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRayTracingGroupId_FunctionAddress, "ReturnValue");
		GetRayTracingGroupId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRayTracingGroupId_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRayTracingGroupId_IsValid = GetRayTracingGroupId_FunctionAddress != IntPtr.Zero && GetRayTracingGroupId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetRayTracingGroupId", GetRayTracingGroupId_IsValid);
		GetParentComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParentComponent");
		GetParentComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentComponent_ReturnValue_PropertyAddress, GetParentComponent_FunctionAddress, "ReturnValue");
		GetParentComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentComponent_FunctionAddress, "ReturnValue");
		GetParentComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParentComponent_IsValid = GetParentComponent_FunctionAddress != IntPtr.Zero && GetParentComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetParentComponent", GetParentComponent_IsValid);
		GetParentActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParentActor");
		GetParentActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentActor_ReturnValue_PropertyAddress, GetParentActor_FunctionAddress, "ReturnValue");
		GetParentActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentActor_FunctionAddress, "ReturnValue");
		GetParentActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParentActor_IsValid = GetParentActor_FunctionAddress != IntPtr.Zero && GetParentActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetParentActor", GetParentActor_IsValid);
		GetOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwner");
		GetOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwner_ReturnValue_PropertyAddress, GetOwner_FunctionAddress, "ReturnValue");
		GetOwner_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwner_FunctionAddress, "ReturnValue");
		GetOwner_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwner_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwner_IsValid = GetOwner_FunctionAddress != IntPtr.Zero && GetOwner_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetOwner", GetOwner_IsValid);
		GetOverlappingComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverlappingComponents");
		GetOverlappingComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverlappingComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingComponents_OverlappingComponents_PropertyAddress, GetOverlappingComponents_FunctionAddress, "OverlappingComponents");
		GetOverlappingComponents_OverlappingComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingComponents_FunctionAddress, "OverlappingComponents");
		GetOverlappingComponents_OverlappingComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingComponents_FunctionAddress, "OverlappingComponents", Classes.FArrayProperty);
		GetOverlappingComponents_IsValid = GetOverlappingComponents_FunctionAddress != IntPtr.Zero && GetOverlappingComponents_OverlappingComponents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetOverlappingComponents", GetOverlappingComponents_IsValid);
		GetOverlappingActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverlappingActors");
		GetOverlappingActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverlappingActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingActors_OverlappingActors_PropertyAddress, GetOverlappingActors_FunctionAddress, "OverlappingActors");
		GetOverlappingActors_OverlappingActors_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingActors_FunctionAddress, "OverlappingActors");
		GetOverlappingActors_OverlappingActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingActors_FunctionAddress, "OverlappingActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingActors_ClassFilter_PropertyAddress, GetOverlappingActors_FunctionAddress, "ClassFilter");
		GetOverlappingActors_ClassFilter_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingActors_FunctionAddress, "ClassFilter");
		GetOverlappingActors_ClassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingActors_FunctionAddress, "ClassFilter", Classes.FClassProperty);
		GetOverlappingActors_IsValid = GetOverlappingActors_FunctionAddress != IntPtr.Zero && GetOverlappingActors_OverlappingActors_IsValid && GetOverlappingActors_ClassFilter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetOverlappingActors", GetOverlappingActors_IsValid);
		GetLocalRole_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLocalRole");
		GetLocalRole_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalRole_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalRole_ReturnValue_PropertyAddress, GetLocalRole_FunctionAddress, "ReturnValue");
		GetLocalRole_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalRole_FunctionAddress, "ReturnValue");
		GetLocalRole_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalRole_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetLocalRole_IsValid = GetLocalRole_FunctionAddress != IntPtr.Zero && GetLocalRole_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetLocalRole", GetLocalRole_IsValid);
		GetLifeSpan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLifeSpan");
		GetLifeSpan_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLifeSpan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLifeSpan_ReturnValue_PropertyAddress, GetLifeSpan_FunctionAddress, "ReturnValue");
		GetLifeSpan_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLifeSpan_FunctionAddress, "ReturnValue");
		GetLifeSpan_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLifeSpan_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLifeSpan_IsValid = GetLifeSpan_FunctionAddress != IntPtr.Zero && GetLifeSpan_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetLifeSpan", GetLifeSpan_IsValid);
		GetLevelTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLevelTransform");
		GetLevelTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelTransform_ReturnValue_PropertyAddress, GetLevelTransform_FunctionAddress, "ReturnValue");
		GetLevelTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelTransform_FunctionAddress, "ReturnValue");
		GetLevelTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelTransform_IsValid = GetLevelTransform_FunctionAddress != IntPtr.Zero && GetLevelTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetLevelTransform", GetLevelTransform_IsValid);
		GetLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLevel");
		GetLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevel_ReturnValue_PropertyAddress, GetLevel_FunctionAddress, "ReturnValue");
		GetLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevel_FunctionAddress, "ReturnValue");
		GetLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLevel_IsValid = GetLevel_FunctionAddress != IntPtr.Zero && GetLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetLevel", GetLevel_IsValid);
		GetInstigatorController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstigatorController");
		GetInstigatorController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstigatorController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstigatorController_ReturnValue_PropertyAddress, GetInstigatorController_FunctionAddress, "ReturnValue");
		GetInstigatorController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstigatorController_FunctionAddress, "ReturnValue");
		GetInstigatorController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstigatorController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInstigatorController_IsValid = GetInstigatorController_FunctionAddress != IntPtr.Zero && GetInstigatorController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetInstigatorController", GetInstigatorController_IsValid);
		GetInstigator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInstigator");
		GetInstigator_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstigator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstigator_ReturnValue_PropertyAddress, GetInstigator_FunctionAddress, "ReturnValue");
		GetInstigator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstigator_FunctionAddress, "ReturnValue");
		GetInstigator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstigator_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInstigator_IsValid = GetInstigator_FunctionAddress != IntPtr.Zero && GetInstigator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetInstigator", GetInstigator_IsValid);
		GetHorizontalDotProductTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHorizontalDotProductTo");
		GetHorizontalDotProductTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHorizontalDotProductTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalDotProductTo_OtherActor_PropertyAddress, GetHorizontalDotProductTo_FunctionAddress, "OtherActor");
		GetHorizontalDotProductTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalDotProductTo_FunctionAddress, "OtherActor");
		GetHorizontalDotProductTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalDotProductTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalDotProductTo_ReturnValue_PropertyAddress, GetHorizontalDotProductTo_FunctionAddress, "ReturnValue");
		GetHorizontalDotProductTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalDotProductTo_FunctionAddress, "ReturnValue");
		GetHorizontalDotProductTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalDotProductTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetHorizontalDotProductTo_IsValid = GetHorizontalDotProductTo_FunctionAddress != IntPtr.Zero && GetHorizontalDotProductTo_OtherActor_IsValid && GetHorizontalDotProductTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetHorizontalDotProductTo", GetHorizontalDotProductTo_IsValid);
		GetHorizontalDistanceTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHorizontalDistanceTo");
		GetHorizontalDistanceTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHorizontalDistanceTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalDistanceTo_OtherActor_PropertyAddress, GetHorizontalDistanceTo_FunctionAddress, "OtherActor");
		GetHorizontalDistanceTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalDistanceTo_FunctionAddress, "OtherActor");
		GetHorizontalDistanceTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalDistanceTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHorizontalDistanceTo_ReturnValue_PropertyAddress, GetHorizontalDistanceTo_FunctionAddress, "ReturnValue");
		GetHorizontalDistanceTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHorizontalDistanceTo_FunctionAddress, "ReturnValue");
		GetHorizontalDistanceTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorizontalDistanceTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetHorizontalDistanceTo_IsValid = GetHorizontalDistanceTo_FunctionAddress != IntPtr.Zero && GetHorizontalDistanceTo_OtherActor_IsValid && GetHorizontalDistanceTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetHorizontalDistanceTo", GetHorizontalDistanceTo_IsValid);
		GetGameTimeSinceCreation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGameTimeSinceCreation");
		GetGameTimeSinceCreation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameTimeSinceCreation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameTimeSinceCreation_ReturnValue_PropertyAddress, GetGameTimeSinceCreation_FunctionAddress, "ReturnValue");
		GetGameTimeSinceCreation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameTimeSinceCreation_FunctionAddress, "ReturnValue");
		GetGameTimeSinceCreation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameTimeSinceCreation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGameTimeSinceCreation_IsValid = GetGameTimeSinceCreation_FunctionAddress != IntPtr.Zero && GetGameTimeSinceCreation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetGameTimeSinceCreation", GetGameTimeSinceCreation_IsValid);
		GetFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFolderPath");
		GetFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFolderPath_ReturnValue_PropertyAddress, GetFolderPath_FunctionAddress, "ReturnValue");
		GetFolderPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderPath_FunctionAddress, "ReturnValue");
		GetFolderPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderPath_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetFolderPath_IsValid = GetFolderPath_FunctionAddress != IntPtr.Zero && GetFolderPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetFolderPath", GetFolderPath_IsValid);
		GetDotProductTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDotProductTo");
		GetDotProductTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDotProductTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDotProductTo_OtherActor_PropertyAddress, GetDotProductTo_FunctionAddress, "OtherActor");
		GetDotProductTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetDotProductTo_FunctionAddress, "OtherActor");
		GetDotProductTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDotProductTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDotProductTo_ReturnValue_PropertyAddress, GetDotProductTo_FunctionAddress, "ReturnValue");
		GetDotProductTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDotProductTo_FunctionAddress, "ReturnValue");
		GetDotProductTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDotProductTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDotProductTo_IsValid = GetDotProductTo_FunctionAddress != IntPtr.Zero && GetDotProductTo_OtherActor_IsValid && GetDotProductTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetDotProductTo", GetDotProductTo_IsValid);
		GetDistanceTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDistanceTo");
		GetDistanceTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDistanceTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceTo_OtherActor_PropertyAddress, GetDistanceTo_FunctionAddress, "OtherActor");
		GetDistanceTo_OtherActor_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceTo_FunctionAddress, "OtherActor");
		GetDistanceTo_OtherActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceTo_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDistanceTo_ReturnValue_PropertyAddress, GetDistanceTo_FunctionAddress, "ReturnValue");
		GetDistanceTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDistanceTo_FunctionAddress, "ReturnValue");
		GetDistanceTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDistanceTo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDistanceTo_IsValid = GetDistanceTo_FunctionAddress != IntPtr.Zero && GetDistanceTo_OtherActor_IsValid && GetDistanceTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetDistanceTo", GetDistanceTo_IsValid);
		GetDefaultActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultActorLabel");
		GetDefaultActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultActorLabel_ReturnValue_PropertyAddress, GetDefaultActorLabel_FunctionAddress, "ReturnValue");
		GetDefaultActorLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultActorLabel_FunctionAddress, "ReturnValue");
		GetDefaultActorLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultActorLabel_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultActorLabel_IsValid = GetDefaultActorLabel_FunctionAddress != IntPtr.Zero && GetDefaultActorLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetDefaultActorLabel", GetDefaultActorLabel_IsValid);
		GetComponentsByTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComponentsByTag");
		GetComponentsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByTag_ComponentClass_PropertyAddress, GetComponentsByTag_FunctionAddress, "ComponentClass");
		GetComponentsByTag_ComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByTag_FunctionAddress, "ComponentClass");
		GetComponentsByTag_ComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByTag_FunctionAddress, "ComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByTag_Tag_PropertyAddress, GetComponentsByTag_FunctionAddress, "Tag");
		GetComponentsByTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByTag_FunctionAddress, "Tag");
		GetComponentsByTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByTag_ReturnValue_PropertyAddress, GetComponentsByTag_FunctionAddress, "ReturnValue");
		GetComponentsByTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByTag_FunctionAddress, "ReturnValue");
		GetComponentsByTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByTag_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetComponentsByTag_IsValid = GetComponentsByTag_FunctionAddress != IntPtr.Zero && GetComponentsByTag_ComponentClass_IsValid && GetComponentsByTag_Tag_IsValid && GetComponentsByTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetComponentsByTag", GetComponentsByTag_IsValid);
		GetComponentsByInterface_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComponentsByInterface");
		GetComponentsByInterface_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentsByInterface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByInterface_Interface_PropertyAddress, GetComponentsByInterface_FunctionAddress, "Interface");
		GetComponentsByInterface_Interface_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByInterface_FunctionAddress, "Interface");
		GetComponentsByInterface_Interface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByInterface_FunctionAddress, "Interface", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentsByInterface_ReturnValue_PropertyAddress, GetComponentsByInterface_FunctionAddress, "ReturnValue");
		GetComponentsByInterface_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentsByInterface_FunctionAddress, "ReturnValue");
		GetComponentsByInterface_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentsByInterface_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetComponentsByInterface_IsValid = GetComponentsByInterface_FunctionAddress != IntPtr.Zero && GetComponentsByInterface_Interface_IsValid && GetComponentsByInterface_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetComponentsByInterface", GetComponentsByInterface_IsValid);
		GetComponentByClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComponentByClass");
		GetComponentByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentByClass_ComponentClass_PropertyAddress, GetComponentByClass_FunctionAddress, "ComponentClass");
		GetComponentByClass_ComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentByClass_FunctionAddress, "ComponentClass");
		GetComponentByClass_ComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentByClass_FunctionAddress, "ComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponentByClass_ReturnValue_PropertyAddress, GetComponentByClass_FunctionAddress, "ReturnValue");
		GetComponentByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentByClass_FunctionAddress, "ReturnValue");
		GetComponentByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetComponentByClass_IsValid = GetComponentByClass_FunctionAddress != IntPtr.Zero && GetComponentByClass_ComponentClass_IsValid && GetComponentByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetComponentByClass", GetComponentByClass_IsValid);
		GetAttachParentSocketName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachParentSocketName");
		GetAttachParentSocketName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachParentSocketName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachParentSocketName_ReturnValue_PropertyAddress, GetAttachParentSocketName_FunctionAddress, "ReturnValue");
		GetAttachParentSocketName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachParentSocketName_FunctionAddress, "ReturnValue");
		GetAttachParentSocketName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachParentSocketName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetAttachParentSocketName_IsValid = GetAttachParentSocketName_FunctionAddress != IntPtr.Zero && GetAttachParentSocketName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetAttachParentSocketName", GetAttachParentSocketName_IsValid);
		GetAttachParentActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachParentActor");
		GetAttachParentActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachParentActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachParentActor_ReturnValue_PropertyAddress, GetAttachParentActor_FunctionAddress, "ReturnValue");
		GetAttachParentActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachParentActor_FunctionAddress, "ReturnValue");
		GetAttachParentActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachParentActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAttachParentActor_IsValid = GetAttachParentActor_FunctionAddress != IntPtr.Zero && GetAttachParentActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetAttachParentActor", GetAttachParentActor_IsValid);
		GetAttachedActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachedActors");
		GetAttachedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedActors_OutActors_PropertyAddress, GetAttachedActors_FunctionAddress, "OutActors");
		GetAttachedActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedActors_FunctionAddress, "OutActors");
		GetAttachedActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedActors_bResetArray_PropertyAddress, GetAttachedActors_FunctionAddress, "bResetArray");
		GetAttachedActors_bResetArray_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedActors_FunctionAddress, "bResetArray");
		GetAttachedActors_bResetArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedActors_FunctionAddress, "bResetArray", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttachedActors_bRecursivelyIncludeAttachedActors_PropertyAddress, GetAttachedActors_FunctionAddress, "bRecursivelyIncludeAttachedActors");
		GetAttachedActors_bRecursivelyIncludeAttachedActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachedActors_FunctionAddress, "bRecursivelyIncludeAttachedActors");
		GetAttachedActors_bRecursivelyIncludeAttachedActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachedActors_FunctionAddress, "bRecursivelyIncludeAttachedActors", Classes.FBoolProperty);
		GetAttachedActors_IsValid = GetAttachedActors_FunctionAddress != IntPtr.Zero && GetAttachedActors_OutActors_IsValid && GetAttachedActors_bResetArray_IsValid && GetAttachedActors_bRecursivelyIncludeAttachedActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetAttachedActors", GetAttachedActors_IsValid);
		GetAllChildActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllChildActors");
		GetAllChildActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildActors_ChildActors_PropertyAddress, GetAllChildActors_FunctionAddress, "ChildActors");
		GetAllChildActors_ChildActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildActors_FunctionAddress, "ChildActors");
		GetAllChildActors_ChildActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildActors_FunctionAddress, "ChildActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildActors_bIncludeDescendants_PropertyAddress, GetAllChildActors_FunctionAddress, "bIncludeDescendants");
		GetAllChildActors_bIncludeDescendants_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildActors_FunctionAddress, "bIncludeDescendants");
		GetAllChildActors_bIncludeDescendants_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildActors_FunctionAddress, "bIncludeDescendants", Classes.FBoolProperty);
		GetAllChildActors_IsValid = GetAllChildActors_FunctionAddress != IntPtr.Zero && GetAllChildActors_ChildActors_IsValid && GetAllChildActors_bIncludeDescendants_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetAllChildActors", GetAllChildActors_IsValid);
		GetActorUpVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorUpVector");
		GetActorUpVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorUpVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorUpVector_ReturnValue_PropertyAddress, GetActorUpVector_FunctionAddress, "ReturnValue");
		GetActorUpVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorUpVector_FunctionAddress, "ReturnValue");
		GetActorUpVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorUpVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorUpVector_IsValid = GetActorUpVector_FunctionAddress != IntPtr.Zero && GetActorUpVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorUpVector", GetActorUpVector_IsValid);
		GetActorTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorTimeDilation");
		GetActorTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorTimeDilation_ReturnValue_PropertyAddress, GetActorTimeDilation_FunctionAddress, "ReturnValue");
		GetActorTimeDilation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorTimeDilation_FunctionAddress, "ReturnValue");
		GetActorTimeDilation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorTimeDilation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetActorTimeDilation_IsValid = GetActorTimeDilation_FunctionAddress != IntPtr.Zero && GetActorTimeDilation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorTimeDilation", GetActorTimeDilation_IsValid);
		GetActorTickInterval_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorTickInterval");
		GetActorTickInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorTickInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorTickInterval_ReturnValue_PropertyAddress, GetActorTickInterval_FunctionAddress, "ReturnValue");
		GetActorTickInterval_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorTickInterval_FunctionAddress, "ReturnValue");
		GetActorTickInterval_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorTickInterval_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetActorTickInterval_IsValid = GetActorTickInterval_FunctionAddress != IntPtr.Zero && GetActorTickInterval_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorTickInterval", GetActorTickInterval_IsValid);
		GetActorScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorScale3D");
		GetActorScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorScale3D_ReturnValue_PropertyAddress, GetActorScale3D_FunctionAddress, "ReturnValue");
		GetActorScale3D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorScale3D_FunctionAddress, "ReturnValue");
		GetActorScale3D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorScale3D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorScale3D_IsValid = GetActorScale3D_FunctionAddress != IntPtr.Zero && GetActorScale3D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorScale3D", GetActorScale3D_IsValid);
		GetActorRightVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorRightVector");
		GetActorRightVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorRightVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorRightVector_ReturnValue_PropertyAddress, GetActorRightVector_FunctionAddress, "ReturnValue");
		GetActorRightVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRightVector_FunctionAddress, "ReturnValue");
		GetActorRightVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRightVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorRightVector_IsValid = GetActorRightVector_FunctionAddress != IntPtr.Zero && GetActorRightVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorRightVector", GetActorRightVector_IsValid);
		GetActorRelativeScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorRelativeScale3D");
		GetActorRelativeScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorRelativeScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorRelativeScale3D_ReturnValue_PropertyAddress, GetActorRelativeScale3D_FunctionAddress, "ReturnValue");
		GetActorRelativeScale3D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRelativeScale3D_FunctionAddress, "ReturnValue");
		GetActorRelativeScale3D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRelativeScale3D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorRelativeScale3D_IsValid = GetActorRelativeScale3D_FunctionAddress != IntPtr.Zero && GetActorRelativeScale3D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorRelativeScale3D", GetActorRelativeScale3D_IsValid);
		GetActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorLabel");
		GetActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLabel_bCreateIfNone_PropertyAddress, GetActorLabel_FunctionAddress, "bCreateIfNone");
		GetActorLabel_bCreateIfNone_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLabel_FunctionAddress, "bCreateIfNone");
		GetActorLabel_bCreateIfNone_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLabel_FunctionAddress, "bCreateIfNone", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLabel_ReturnValue_PropertyAddress, GetActorLabel_FunctionAddress, "ReturnValue");
		GetActorLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLabel_FunctionAddress, "ReturnValue");
		GetActorLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLabel_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetActorLabel_IsValid = GetActorLabel_FunctionAddress != IntPtr.Zero && GetActorLabel_bCreateIfNone_IsValid && GetActorLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorLabel", GetActorLabel_IsValid);
		GetActorForwardVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorForwardVector");
		GetActorForwardVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorForwardVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorForwardVector_ReturnValue_PropertyAddress, GetActorForwardVector_FunctionAddress, "ReturnValue");
		GetActorForwardVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorForwardVector_FunctionAddress, "ReturnValue");
		GetActorForwardVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorForwardVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorForwardVector_IsValid = GetActorForwardVector_FunctionAddress != IntPtr.Zero && GetActorForwardVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorForwardVector", GetActorForwardVector_IsValid);
		GetActorEyesViewPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorEyesViewPoint");
		GetActorEyesViewPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorEyesViewPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorEyesViewPoint_OutLocation_PropertyAddress, GetActorEyesViewPoint_FunctionAddress, "OutLocation");
		GetActorEyesViewPoint_OutLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetActorEyesViewPoint_FunctionAddress, "OutLocation");
		GetActorEyesViewPoint_OutLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorEyesViewPoint_FunctionAddress, "OutLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorEyesViewPoint_OutRotation_PropertyAddress, GetActorEyesViewPoint_FunctionAddress, "OutRotation");
		GetActorEyesViewPoint_OutRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetActorEyesViewPoint_FunctionAddress, "OutRotation");
		GetActorEyesViewPoint_OutRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorEyesViewPoint_FunctionAddress, "OutRotation", Classes.FStructProperty);
		GetActorEyesViewPoint_IsValid = GetActorEyesViewPoint_FunctionAddress != IntPtr.Zero && GetActorEyesViewPoint_OutLocation_IsValid && GetActorEyesViewPoint_OutRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorEyesViewPoint", GetActorEyesViewPoint_IsValid);
		GetActorEnableCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorEnableCollision");
		GetActorEnableCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorEnableCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorEnableCollision_ReturnValue_PropertyAddress, GetActorEnableCollision_FunctionAddress, "ReturnValue");
		GetActorEnableCollision_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorEnableCollision_FunctionAddress, "ReturnValue");
		GetActorEnableCollision_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorEnableCollision_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorEnableCollision_IsValid = GetActorEnableCollision_FunctionAddress != IntPtr.Zero && GetActorEnableCollision_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorEnableCollision", GetActorEnableCollision_IsValid);
		GetActorBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorBounds");
		GetActorBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorBounds_bOnlyCollidingComponents_PropertyAddress, GetActorBounds_FunctionAddress, "bOnlyCollidingComponents");
		GetActorBounds_bOnlyCollidingComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBounds_FunctionAddress, "bOnlyCollidingComponents");
		GetActorBounds_bOnlyCollidingComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBounds_FunctionAddress, "bOnlyCollidingComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBounds_Origin_PropertyAddress, GetActorBounds_FunctionAddress, "Origin");
		GetActorBounds_Origin_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBounds_FunctionAddress, "Origin");
		GetActorBounds_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBounds_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBounds_BoxExtent_PropertyAddress, GetActorBounds_FunctionAddress, "BoxExtent");
		GetActorBounds_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBounds_FunctionAddress, "BoxExtent");
		GetActorBounds_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBounds_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBounds_bIncludeFromChildActors_PropertyAddress, GetActorBounds_FunctionAddress, "bIncludeFromChildActors");
		GetActorBounds_bIncludeFromChildActors_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBounds_FunctionAddress, "bIncludeFromChildActors");
		GetActorBounds_bIncludeFromChildActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBounds_FunctionAddress, "bIncludeFromChildActors", Classes.FBoolProperty);
		GetActorBounds_IsValid = GetActorBounds_FunctionAddress != IntPtr.Zero && GetActorBounds_bOnlyCollidingComponents_IsValid && GetActorBounds_Origin_IsValid && GetActorBounds_BoxExtent_IsValid && GetActorBounds_bIncludeFromChildActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:GetActorBounds", GetActorBounds_IsValid);
		ForceNetUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceNetUpdate");
		ForceNetUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceNetUpdate_FunctionAddress);
		ForceNetUpdate_IsValid = ForceNetUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ForceNetUpdate", ForceNetUpdate_IsValid);
		FlushNetDormancy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FlushNetDormancy");
		FlushNetDormancy_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushNetDormancy_FunctionAddress);
		FlushNetDormancy_IsValid = FlushNetDormancy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:FlushNetDormancy", FlushNetDormancy_IsValid);
		EnableInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableInput");
		EnableInput_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableInput_PlayerController_PropertyAddress, EnableInput_FunctionAddress, "PlayerController");
		EnableInput_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(EnableInput_FunctionAddress, "PlayerController");
		EnableInput_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableInput_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		EnableInput_IsValid = EnableInput_FunctionAddress != IntPtr.Zero && EnableInput_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:EnableInput", EnableInput_IsValid);
		DisableInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableInput");
		DisableInput_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableInput_PlayerController_PropertyAddress, DisableInput_FunctionAddress, "PlayerController");
		DisableInput_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(DisableInput_FunctionAddress, "PlayerController");
		DisableInput_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableInput_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		DisableInput_IsValid = DisableInput_FunctionAddress != IntPtr.Zero && DisableInput_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:DisableInput", DisableInput_IsValid);
		DetachRootComponentFromParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DetachRootComponentFromParent");
		DetachRootComponentFromParent_ParamsSize = NativeReflection.GetFunctionParamsSize(DetachRootComponentFromParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetachRootComponentFromParent_bMaintainWorldPosition_PropertyAddress, DetachRootComponentFromParent_FunctionAddress, "bMaintainWorldPosition");
		DetachRootComponentFromParent_bMaintainWorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(DetachRootComponentFromParent_FunctionAddress, "bMaintainWorldPosition");
		DetachRootComponentFromParent_bMaintainWorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachRootComponentFromParent_FunctionAddress, "bMaintainWorldPosition", Classes.FBoolProperty);
		DetachRootComponentFromParent_IsValid = DetachRootComponentFromParent_FunctionAddress != IntPtr.Zero && DetachRootComponentFromParent_bMaintainWorldPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:DetachRootComponentFromParent", DetachRootComponentFromParent_IsValid);
		AddTickPrerequisiteComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTickPrerequisiteComponent");
		AddTickPrerequisiteComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTickPrerequisiteComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTickPrerequisiteComponent_PrerequisiteComponent_PropertyAddress, AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		AddTickPrerequisiteComponent_PrerequisiteComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent");
		AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTickPrerequisiteComponent_FunctionAddress, "PrerequisiteComponent", Classes.FObjectProperty);
		AddTickPrerequisiteComponent_IsValid = AddTickPrerequisiteComponent_FunctionAddress != IntPtr.Zero && AddTickPrerequisiteComponent_PrerequisiteComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:AddTickPrerequisiteComponent", AddTickPrerequisiteComponent_IsValid);
		AddTickPrerequisiteActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTickPrerequisiteActor");
		AddTickPrerequisiteActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTickPrerequisiteActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTickPrerequisiteActor_PrerequisiteActor_PropertyAddress, AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		AddTickPrerequisiteActor_PrerequisiteActor_Offset = NativeReflectionCached.GetPropertyOffset(AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor");
		AddTickPrerequisiteActor_PrerequisiteActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTickPrerequisiteActor_FunctionAddress, "PrerequisiteActor", Classes.FObjectProperty);
		AddTickPrerequisiteActor_IsValid = AddTickPrerequisiteActor_FunctionAddress != IntPtr.Zero && AddTickPrerequisiteActor_PrerequisiteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:AddTickPrerequisiteActor", AddTickPrerequisiteActor_IsValid);
		ActorHasTag_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ActorHasTag");
		ActorHasTag_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorHasTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorHasTag_Tag_PropertyAddress, ActorHasTag_FunctionAddress, "Tag");
		ActorHasTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(ActorHasTag_FunctionAddress, "Tag");
		ActorHasTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHasTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorHasTag_ReturnValue_PropertyAddress, ActorHasTag_FunctionAddress, "ReturnValue");
		ActorHasTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ActorHasTag_FunctionAddress, "ReturnValue");
		ActorHasTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorHasTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ActorHasTag_IsValid = ActorHasTag_FunctionAddress != IntPtr.Zero && ActorHasTag_Tag_IsValid && ActorHasTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Actor:ActorHasTag", ActorHasTag_IsValid);
		LoadNativeTypeInjected(intPtr);
	}
}
