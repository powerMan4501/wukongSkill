using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SceneComponent", "Engine", UnrealModuleType.Engine)]
public class USceneComponent : UActorComponent
{
	private static bool RelativeLocation_IsValid;

	private static int RelativeLocation_Offset;

	private static bool RelativeRotation_IsValid;

	private static int RelativeRotation_Offset;

	private static bool RelativeScale3D_IsValid;

	private static int RelativeScale3D_Offset;

	private static bool AbsoluteLocation_IsValid;

	private static FFieldAddress AbsoluteLocation_PropertyAddress;

	private static int AbsoluteLocation_Offset;

	private static bool AbsoluteRotation_IsValid;

	private static FFieldAddress AbsoluteRotation_PropertyAddress;

	private static int AbsoluteRotation_Offset;

	private static bool AbsoluteScale_IsValid;

	private static FFieldAddress AbsoluteScale_PropertyAddress;

	private static int AbsoluteScale_Offset;

	private static bool Visible_IsValid;

	private static FFieldAddress Visible_PropertyAddress;

	private static int Visible_Offset;

	private static bool HiddenInGame_IsValid;

	private static FFieldAddress HiddenInGame_PropertyAddress;

	private static int HiddenInGame_Offset;

	private static bool UseAttachParentBound_IsValid;

	private static FFieldAddress UseAttachParentBound_PropertyAddress;

	private static int UseAttachParentBound_Offset;

	private static bool Mobility_IsValid;

	private static FFieldAddress Mobility_PropertyAddress;

	private static int Mobility_Offset;

	private static bool DetailMode_IsValid;

	private static FFieldAddress DetailMode_PropertyAddress;

	private static int DetailMode_Offset;

	private static bool PhysicsVolumeChangedDelegate_IsValid;

	private static int PhysicsVolumeChangedDelegate_Offset;

	private FPhysicsVolumeChanged PhysicsVolumeChangedDelegate_DelegateCached;

	private static bool ToggleVisibility_IsValid;

	private static IntPtr ToggleVisibility_FunctionAddress;

	private static int ToggleVisibility_ParamsSize;

	private static bool ToggleVisibility_bPropagateToChildren_IsValid;

	private static FFieldAddress ToggleVisibility_bPropagateToChildren_PropertyAddress;

	private static int ToggleVisibility_bPropagateToChildren_Offset;

	private static bool SetWorldScale3D_IsValid;

	private static IntPtr SetWorldScale3D_FunctionAddress;

	private static int SetWorldScale3D_ParamsSize;

	private static bool SetWorldScale3D_NewScale_IsValid;

	private static FFieldAddress SetWorldScale3D_NewScale_PropertyAddress;

	private static int SetWorldScale3D_NewScale_Offset;

	private static bool SetVisibility_IsValid;

	private static IntPtr SetVisibility_FunctionAddress;

	private static int SetVisibility_ParamsSize;

	private static bool SetVisibility_bNewVisibility_IsValid;

	private static FFieldAddress SetVisibility_bNewVisibility_PropertyAddress;

	private static int SetVisibility_bNewVisibility_Offset;

	private static bool SetVisibility_bPropagateToChildren_IsValid;

	private static FFieldAddress SetVisibility_bPropagateToChildren_PropertyAddress;

	private static int SetVisibility_bPropagateToChildren_Offset;

	private static bool SetShouldUpdatePhysicsVolume_IsValid;

	private static IntPtr SetShouldUpdatePhysicsVolume_FunctionAddress;

	private static int SetShouldUpdatePhysicsVolume_ParamsSize;

	private static bool SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_IsValid;

	private static FFieldAddress SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_PropertyAddress;

	private static int SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_Offset;

	private static bool SetRelativeScale3D_IsValid;

	private static IntPtr SetRelativeScale3D_FunctionAddress;

	private static int SetRelativeScale3D_ParamsSize;

	private static bool SetRelativeScale3D_NewScale3D_IsValid;

	private static FFieldAddress SetRelativeScale3D_NewScale3D_PropertyAddress;

	private static int SetRelativeScale3D_NewScale3D_Offset;

	private static bool SetMobility_IsValid;

	private static IntPtr SetMobility_FunctionAddress;

	private static int SetMobility_ParamsSize;

	private static bool SetMobility_NewMobility_IsValid;

	private static FFieldAddress SetMobility_NewMobility_PropertyAddress;

	private static int SetMobility_NewMobility_Offset;

	private static bool SetHiddenInGame_IsValid;

	private static IntPtr SetHiddenInGame_FunctionAddress;

	private static int SetHiddenInGame_ParamsSize;

	private static bool SetHiddenInGame_NewHidden_IsValid;

	private static FFieldAddress SetHiddenInGame_NewHidden_PropertyAddress;

	private static int SetHiddenInGame_NewHidden_Offset;

	private static bool SetHiddenInGame_bPropagateToChildren_IsValid;

	private static FFieldAddress SetHiddenInGame_bPropagateToChildren_PropertyAddress;

	private static int SetHiddenInGame_bPropagateToChildren_Offset;

	private static bool SetAbsolute_IsValid;

	private static IntPtr SetAbsolute_FunctionAddress;

	private static int SetAbsolute_ParamsSize;

	private static bool SetAbsolute_bNewAbsoluteLocation_IsValid;

	private static FFieldAddress SetAbsolute_bNewAbsoluteLocation_PropertyAddress;

	private static int SetAbsolute_bNewAbsoluteLocation_Offset;

	private static bool SetAbsolute_bNewAbsoluteRotation_IsValid;

	private static FFieldAddress SetAbsolute_bNewAbsoluteRotation_PropertyAddress;

	private static int SetAbsolute_bNewAbsoluteRotation_Offset;

	private static bool SetAbsolute_bNewAbsoluteScale_IsValid;

	private static FFieldAddress SetAbsolute_bNewAbsoluteScale_PropertyAddress;

	private static int SetAbsolute_bNewAbsoluteScale_Offset;

	private static bool ResetRelativeTransform_IsValid;

	private static IntPtr ResetRelativeTransform_FunctionAddress;

	private static int ResetRelativeTransform_ParamsSize;

	private static bool SetWorldTransform_IsValid;

	private static IntPtr SetWorldTransform_FunctionAddress;

	private static int SetWorldTransform_ParamsSize;

	private static bool SetWorldTransform_NewTransform_IsValid;

	private static FFieldAddress SetWorldTransform_NewTransform_PropertyAddress;

	private static int SetWorldTransform_NewTransform_Offset;

	private static bool SetWorldTransform_bSweep_IsValid;

	private static FFieldAddress SetWorldTransform_bSweep_PropertyAddress;

	private static int SetWorldTransform_bSweep_Offset;

	private static bool SetWorldTransform_SweepHitResult_IsValid;

	private static FFieldAddress SetWorldTransform_SweepHitResult_PropertyAddress;

	private static int SetWorldTransform_SweepHitResult_Offset;

	private static bool SetWorldTransform_bTeleport_IsValid;

	private static FFieldAddress SetWorldTransform_bTeleport_PropertyAddress;

	private static int SetWorldTransform_bTeleport_Offset;

	private static bool SetWorldRotation_IsValid;

	private static IntPtr SetWorldRotation_FunctionAddress;

	private static int SetWorldRotation_ParamsSize;

	private static bool SetWorldRotation_NewRotation_IsValid;

	private static FFieldAddress SetWorldRotation_NewRotation_PropertyAddress;

	private static int SetWorldRotation_NewRotation_Offset;

	private static bool SetWorldRotation_bSweep_IsValid;

	private static FFieldAddress SetWorldRotation_bSweep_PropertyAddress;

	private static int SetWorldRotation_bSweep_Offset;

	private static bool SetWorldRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetWorldRotation_SweepHitResult_PropertyAddress;

	private static int SetWorldRotation_SweepHitResult_Offset;

	private static bool SetWorldRotation_bTeleport_IsValid;

	private static FFieldAddress SetWorldRotation_bTeleport_PropertyAddress;

	private static int SetWorldRotation_bTeleport_Offset;

	private static bool SetWorldLocationAndRotation_IsValid;

	private static IntPtr SetWorldLocationAndRotation_FunctionAddress;

	private static int SetWorldLocationAndRotation_ParamsSize;

	private static bool SetWorldLocationAndRotation_NewLocation_IsValid;

	private static FFieldAddress SetWorldLocationAndRotation_NewLocation_PropertyAddress;

	private static int SetWorldLocationAndRotation_NewLocation_Offset;

	private static bool SetWorldLocationAndRotation_NewRotation_IsValid;

	private static FFieldAddress SetWorldLocationAndRotation_NewRotation_PropertyAddress;

	private static int SetWorldLocationAndRotation_NewRotation_Offset;

	private static bool SetWorldLocationAndRotation_bSweep_IsValid;

	private static FFieldAddress SetWorldLocationAndRotation_bSweep_PropertyAddress;

	private static int SetWorldLocationAndRotation_bSweep_Offset;

	private static bool SetWorldLocationAndRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetWorldLocationAndRotation_SweepHitResult_PropertyAddress;

	private static int SetWorldLocationAndRotation_SweepHitResult_Offset;

	private static bool SetWorldLocationAndRotation_bTeleport_IsValid;

	private static FFieldAddress SetWorldLocationAndRotation_bTeleport_PropertyAddress;

	private static int SetWorldLocationAndRotation_bTeleport_Offset;

	private static bool SetWorldLocation_IsValid;

	private static IntPtr SetWorldLocation_FunctionAddress;

	private static int SetWorldLocation_ParamsSize;

	private static bool SetWorldLocation_NewLocation_IsValid;

	private static FFieldAddress SetWorldLocation_NewLocation_PropertyAddress;

	private static int SetWorldLocation_NewLocation_Offset;

	private static bool SetWorldLocation_bSweep_IsValid;

	private static FFieldAddress SetWorldLocation_bSweep_PropertyAddress;

	private static int SetWorldLocation_bSweep_Offset;

	private static bool SetWorldLocation_SweepHitResult_IsValid;

	private static FFieldAddress SetWorldLocation_SweepHitResult_PropertyAddress;

	private static int SetWorldLocation_SweepHitResult_Offset;

	private static bool SetWorldLocation_bTeleport_IsValid;

	private static FFieldAddress SetWorldLocation_bTeleport_PropertyAddress;

	private static int SetWorldLocation_bTeleport_Offset;

	private static bool SetRelativeTransform_IsValid;

	private static IntPtr SetRelativeTransform_FunctionAddress;

	private static int SetRelativeTransform_ParamsSize;

	private static bool SetRelativeTransform_NewTransform_IsValid;

	private static FFieldAddress SetRelativeTransform_NewTransform_PropertyAddress;

	private static int SetRelativeTransform_NewTransform_Offset;

	private static bool SetRelativeTransform_bSweep_IsValid;

	private static FFieldAddress SetRelativeTransform_bSweep_PropertyAddress;

	private static int SetRelativeTransform_bSweep_Offset;

	private static bool SetRelativeTransform_SweepHitResult_IsValid;

	private static FFieldAddress SetRelativeTransform_SweepHitResult_PropertyAddress;

	private static int SetRelativeTransform_SweepHitResult_Offset;

	private static bool SetRelativeTransform_bTeleport_IsValid;

	private static FFieldAddress SetRelativeTransform_bTeleport_PropertyAddress;

	private static int SetRelativeTransform_bTeleport_Offset;

	private static bool SetRelativeRotation_IsValid;

	private static IntPtr SetRelativeRotation_FunctionAddress;

	private static int SetRelativeRotation_ParamsSize;

	private static bool SetRelativeRotation_NewRotation_IsValid;

	private static FFieldAddress SetRelativeRotation_NewRotation_PropertyAddress;

	private static int SetRelativeRotation_NewRotation_Offset;

	private static bool SetRelativeRotation_bSweep_IsValid;

	private static FFieldAddress SetRelativeRotation_bSweep_PropertyAddress;

	private static int SetRelativeRotation_bSweep_Offset;

	private static bool SetRelativeRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetRelativeRotation_SweepHitResult_PropertyAddress;

	private static int SetRelativeRotation_SweepHitResult_Offset;

	private static bool SetRelativeRotation_bTeleport_IsValid;

	private static FFieldAddress SetRelativeRotation_bTeleport_PropertyAddress;

	private static int SetRelativeRotation_bTeleport_Offset;

	private static bool SetRelativeLocationAndRotation_IsValid;

	private static IntPtr SetRelativeLocationAndRotation_FunctionAddress;

	private static int SetRelativeLocationAndRotation_ParamsSize;

	private static bool SetRelativeLocationAndRotation_NewLocation_IsValid;

	private static FFieldAddress SetRelativeLocationAndRotation_NewLocation_PropertyAddress;

	private static int SetRelativeLocationAndRotation_NewLocation_Offset;

	private static bool SetRelativeLocationAndRotation_NewRotation_IsValid;

	private static FFieldAddress SetRelativeLocationAndRotation_NewRotation_PropertyAddress;

	private static int SetRelativeLocationAndRotation_NewRotation_Offset;

	private static bool SetRelativeLocationAndRotation_bSweep_IsValid;

	private static FFieldAddress SetRelativeLocationAndRotation_bSweep_PropertyAddress;

	private static int SetRelativeLocationAndRotation_bSweep_Offset;

	private static bool SetRelativeLocationAndRotation_SweepHitResult_IsValid;

	private static FFieldAddress SetRelativeLocationAndRotation_SweepHitResult_PropertyAddress;

	private static int SetRelativeLocationAndRotation_SweepHitResult_Offset;

	private static bool SetRelativeLocationAndRotation_bTeleport_IsValid;

	private static FFieldAddress SetRelativeLocationAndRotation_bTeleport_PropertyAddress;

	private static int SetRelativeLocationAndRotation_bTeleport_Offset;

	private static bool SetRelativeLocation_IsValid;

	private static IntPtr SetRelativeLocation_FunctionAddress;

	private static int SetRelativeLocation_ParamsSize;

	private static bool SetRelativeLocation_NewLocation_IsValid;

	private static FFieldAddress SetRelativeLocation_NewLocation_PropertyAddress;

	private static int SetRelativeLocation_NewLocation_Offset;

	private static bool SetRelativeLocation_bSweep_IsValid;

	private static FFieldAddress SetRelativeLocation_bSweep_PropertyAddress;

	private static int SetRelativeLocation_bSweep_Offset;

	private static bool SetRelativeLocation_SweepHitResult_IsValid;

	private static FFieldAddress SetRelativeLocation_SweepHitResult_PropertyAddress;

	private static int SetRelativeLocation_SweepHitResult_Offset;

	private static bool SetRelativeLocation_bTeleport_IsValid;

	private static FFieldAddress SetRelativeLocation_bTeleport_PropertyAddress;

	private static int SetRelativeLocation_bTeleport_Offset;

	private static bool GetWorldTransform_IsValid;

	private static IntPtr GetWorldTransform_FunctionAddress;

	private static int GetWorldTransform_ParamsSize;

	private static bool GetWorldTransform_ReturnValue_IsValid;

	private static FFieldAddress GetWorldTransform_ReturnValue_PropertyAddress;

	private static int GetWorldTransform_ReturnValue_Offset;

	private static bool GetWorldScale_IsValid;

	private static IntPtr GetWorldScale_FunctionAddress;

	private static int GetWorldScale_ParamsSize;

	private static bool GetWorldScale_ReturnValue_IsValid;

	private static FFieldAddress GetWorldScale_ReturnValue_PropertyAddress;

	private static int GetWorldScale_ReturnValue_Offset;

	private static bool GetWorldRotation_IsValid;

	private static IntPtr GetWorldRotation_FunctionAddress;

	private static int GetWorldRotation_ParamsSize;

	private static bool GetWorldRotation_ReturnValue_IsValid;

	private static FFieldAddress GetWorldRotation_ReturnValue_PropertyAddress;

	private static int GetWorldRotation_ReturnValue_Offset;

	private static bool GetWorldLocation_IsValid;

	private static IntPtr GetWorldLocation_FunctionAddress;

	private static int GetWorldLocation_ParamsSize;

	private static bool GetWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress GetWorldLocation_ReturnValue_PropertyAddress;

	private static int GetWorldLocation_ReturnValue_Offset;

	private static bool DetachFromComponent_IsValid;

	private static IntPtr DetachFromComponent_FunctionAddress;

	private static int DetachFromComponent_ParamsSize;

	private static bool DetachFromComponent_LocationRule_IsValid;

	private static FFieldAddress DetachFromComponent_LocationRule_PropertyAddress;

	private static int DetachFromComponent_LocationRule_Offset;

	private static bool DetachFromComponent_RotationRule_IsValid;

	private static FFieldAddress DetachFromComponent_RotationRule_PropertyAddress;

	private static int DetachFromComponent_RotationRule_Offset;

	private static bool DetachFromComponent_ScaleRule_IsValid;

	private static FFieldAddress DetachFromComponent_ScaleRule_PropertyAddress;

	private static int DetachFromComponent_ScaleRule_Offset;

	private static bool DetachFromComponent_bCallModify_IsValid;

	private static FFieldAddress DetachFromComponent_bCallModify_PropertyAddress;

	private static int DetachFromComponent_bCallModify_Offset;

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

	private static bool AttachToComponent_ReturnValue_IsValid;

	private static FFieldAddress AttachToComponent_ReturnValue_PropertyAddress;

	private static int AttachToComponent_ReturnValue_Offset;

	private static bool AttachTo_IsValid;

	private static IntPtr AttachTo_FunctionAddress;

	private static int AttachTo_ParamsSize;

	private static bool AttachTo_InParent_IsValid;

	private static FFieldAddress AttachTo_InParent_PropertyAddress;

	private static int AttachTo_InParent_Offset;

	private static bool AttachTo_InSocketName_IsValid;

	private static FFieldAddress AttachTo_InSocketName_PropertyAddress;

	private static int AttachTo_InSocketName_Offset;

	private static bool AttachTo_AttachType_IsValid;

	private static FFieldAddress AttachTo_AttachType_PropertyAddress;

	private static int AttachTo_AttachType_Offset;

	private static bool AttachTo_bWeldSimulatedBodies_IsValid;

	private static FFieldAddress AttachTo_bWeldSimulatedBodies_PropertyAddress;

	private static int AttachTo_bWeldSimulatedBodies_Offset;

	private static bool AttachTo_ReturnValue_IsValid;

	private static FFieldAddress AttachTo_ReturnValue_PropertyAddress;

	private static int AttachTo_ReturnValue_Offset;

	private static bool AddWorldTransformKeepScale_IsValid;

	private static IntPtr AddWorldTransformKeepScale_FunctionAddress;

	private static int AddWorldTransformKeepScale_ParamsSize;

	private static bool AddWorldTransformKeepScale_DeltaTransform_IsValid;

	private static FFieldAddress AddWorldTransformKeepScale_DeltaTransform_PropertyAddress;

	private static int AddWorldTransformKeepScale_DeltaTransform_Offset;

	private static bool AddWorldTransformKeepScale_bSweep_IsValid;

	private static FFieldAddress AddWorldTransformKeepScale_bSweep_PropertyAddress;

	private static int AddWorldTransformKeepScale_bSweep_Offset;

	private static bool AddWorldTransformKeepScale_SweepHitResult_IsValid;

	private static FFieldAddress AddWorldTransformKeepScale_SweepHitResult_PropertyAddress;

	private static int AddWorldTransformKeepScale_SweepHitResult_Offset;

	private static bool AddWorldTransformKeepScale_bTeleport_IsValid;

	private static FFieldAddress AddWorldTransformKeepScale_bTeleport_PropertyAddress;

	private static int AddWorldTransformKeepScale_bTeleport_Offset;

	private static bool AddWorldTransform_IsValid;

	private static IntPtr AddWorldTransform_FunctionAddress;

	private static int AddWorldTransform_ParamsSize;

	private static bool AddWorldTransform_DeltaTransform_IsValid;

	private static FFieldAddress AddWorldTransform_DeltaTransform_PropertyAddress;

	private static int AddWorldTransform_DeltaTransform_Offset;

	private static bool AddWorldTransform_bSweep_IsValid;

	private static FFieldAddress AddWorldTransform_bSweep_PropertyAddress;

	private static int AddWorldTransform_bSweep_Offset;

	private static bool AddWorldTransform_SweepHitResult_IsValid;

	private static FFieldAddress AddWorldTransform_SweepHitResult_PropertyAddress;

	private static int AddWorldTransform_SweepHitResult_Offset;

	private static bool AddWorldTransform_bTeleport_IsValid;

	private static FFieldAddress AddWorldTransform_bTeleport_PropertyAddress;

	private static int AddWorldTransform_bTeleport_Offset;

	private static bool AddWorldRotation_IsValid;

	private static IntPtr AddWorldRotation_FunctionAddress;

	private static int AddWorldRotation_ParamsSize;

	private static bool AddWorldRotation_DeltaRotation_IsValid;

	private static FFieldAddress AddWorldRotation_DeltaRotation_PropertyAddress;

	private static int AddWorldRotation_DeltaRotation_Offset;

	private static bool AddWorldRotation_bSweep_IsValid;

	private static FFieldAddress AddWorldRotation_bSweep_PropertyAddress;

	private static int AddWorldRotation_bSweep_Offset;

	private static bool AddWorldRotation_SweepHitResult_IsValid;

	private static FFieldAddress AddWorldRotation_SweepHitResult_PropertyAddress;

	private static int AddWorldRotation_SweepHitResult_Offset;

	private static bool AddWorldRotation_bTeleport_IsValid;

	private static FFieldAddress AddWorldRotation_bTeleport_PropertyAddress;

	private static int AddWorldRotation_bTeleport_Offset;

	private static bool AddWorldOffset_IsValid;

	private static IntPtr AddWorldOffset_FunctionAddress;

	private static int AddWorldOffset_ParamsSize;

	private static bool AddWorldOffset_DeltaLocation_IsValid;

	private static FFieldAddress AddWorldOffset_DeltaLocation_PropertyAddress;

	private static int AddWorldOffset_DeltaLocation_Offset;

	private static bool AddWorldOffset_bSweep_IsValid;

	private static FFieldAddress AddWorldOffset_bSweep_PropertyAddress;

	private static int AddWorldOffset_bSweep_Offset;

	private static bool AddWorldOffset_SweepHitResult_IsValid;

	private static FFieldAddress AddWorldOffset_SweepHitResult_PropertyAddress;

	private static int AddWorldOffset_SweepHitResult_Offset;

	private static bool AddWorldOffset_bTeleport_IsValid;

	private static FFieldAddress AddWorldOffset_bTeleport_PropertyAddress;

	private static int AddWorldOffset_bTeleport_Offset;

	private static bool AddRelativeRotation_IsValid;

	private static IntPtr AddRelativeRotation_FunctionAddress;

	private static int AddRelativeRotation_ParamsSize;

	private static bool AddRelativeRotation_DeltaRotation_IsValid;

	private static FFieldAddress AddRelativeRotation_DeltaRotation_PropertyAddress;

	private static int AddRelativeRotation_DeltaRotation_Offset;

	private static bool AddRelativeRotation_bSweep_IsValid;

	private static FFieldAddress AddRelativeRotation_bSweep_PropertyAddress;

	private static int AddRelativeRotation_bSweep_Offset;

	private static bool AddRelativeRotation_SweepHitResult_IsValid;

	private static FFieldAddress AddRelativeRotation_SweepHitResult_PropertyAddress;

	private static int AddRelativeRotation_SweepHitResult_Offset;

	private static bool AddRelativeRotation_bTeleport_IsValid;

	private static FFieldAddress AddRelativeRotation_bTeleport_PropertyAddress;

	private static int AddRelativeRotation_bTeleport_Offset;

	private static bool AddRelativeLocation_IsValid;

	private static IntPtr AddRelativeLocation_FunctionAddress;

	private static int AddRelativeLocation_ParamsSize;

	private static bool AddRelativeLocation_DeltaLocation_IsValid;

	private static FFieldAddress AddRelativeLocation_DeltaLocation_PropertyAddress;

	private static int AddRelativeLocation_DeltaLocation_Offset;

	private static bool AddRelativeLocation_bSweep_IsValid;

	private static FFieldAddress AddRelativeLocation_bSweep_PropertyAddress;

	private static int AddRelativeLocation_bSweep_Offset;

	private static bool AddRelativeLocation_SweepHitResult_IsValid;

	private static FFieldAddress AddRelativeLocation_SweepHitResult_PropertyAddress;

	private static int AddRelativeLocation_SweepHitResult_Offset;

	private static bool AddRelativeLocation_bTeleport_IsValid;

	private static FFieldAddress AddRelativeLocation_bTeleport_PropertyAddress;

	private static int AddRelativeLocation_bTeleport_Offset;

	private static bool AddLocalTransform_IsValid;

	private static IntPtr AddLocalTransform_FunctionAddress;

	private static int AddLocalTransform_ParamsSize;

	private static bool AddLocalTransform_DeltaTransform_IsValid;

	private static FFieldAddress AddLocalTransform_DeltaTransform_PropertyAddress;

	private static int AddLocalTransform_DeltaTransform_Offset;

	private static bool AddLocalTransform_bSweep_IsValid;

	private static FFieldAddress AddLocalTransform_bSweep_PropertyAddress;

	private static int AddLocalTransform_bSweep_Offset;

	private static bool AddLocalTransform_SweepHitResult_IsValid;

	private static FFieldAddress AddLocalTransform_SweepHitResult_PropertyAddress;

	private static int AddLocalTransform_SweepHitResult_Offset;

	private static bool AddLocalTransform_bTeleport_IsValid;

	private static FFieldAddress AddLocalTransform_bTeleport_PropertyAddress;

	private static int AddLocalTransform_bTeleport_Offset;

	private static bool AddLocalRotation_IsValid;

	private static IntPtr AddLocalRotation_FunctionAddress;

	private static int AddLocalRotation_ParamsSize;

	private static bool AddLocalRotation_DeltaRotation_IsValid;

	private static FFieldAddress AddLocalRotation_DeltaRotation_PropertyAddress;

	private static int AddLocalRotation_DeltaRotation_Offset;

	private static bool AddLocalRotation_bSweep_IsValid;

	private static FFieldAddress AddLocalRotation_bSweep_PropertyAddress;

	private static int AddLocalRotation_bSweep_Offset;

	private static bool AddLocalRotation_SweepHitResult_IsValid;

	private static FFieldAddress AddLocalRotation_SweepHitResult_PropertyAddress;

	private static int AddLocalRotation_SweepHitResult_Offset;

	private static bool AddLocalRotation_bTeleport_IsValid;

	private static FFieldAddress AddLocalRotation_bTeleport_PropertyAddress;

	private static int AddLocalRotation_bTeleport_Offset;

	private static bool AddLocalOffset_IsValid;

	private static IntPtr AddLocalOffset_FunctionAddress;

	private static int AddLocalOffset_ParamsSize;

	private static bool AddLocalOffset_DeltaLocation_IsValid;

	private static FFieldAddress AddLocalOffset_DeltaLocation_PropertyAddress;

	private static int AddLocalOffset_DeltaLocation_Offset;

	private static bool AddLocalOffset_bSweep_IsValid;

	private static FFieldAddress AddLocalOffset_bSweep_PropertyAddress;

	private static int AddLocalOffset_bSweep_Offset;

	private static bool AddLocalOffset_SweepHitResult_IsValid;

	private static FFieldAddress AddLocalOffset_SweepHitResult_PropertyAddress;

	private static int AddLocalOffset_SweepHitResult_Offset;

	private static bool AddLocalOffset_bTeleport_IsValid;

	private static FFieldAddress AddLocalOffset_bTeleport_PropertyAddress;

	private static int AddLocalOffset_bTeleport_Offset;

	private static bool IsVisible_IsValid;

	private static IntPtr IsVisible_FunctionAddress;

	private static int IsVisible_ParamsSize;

	private static bool IsVisible_ReturnValue_IsValid;

	private static FFieldAddress IsVisible_ReturnValue_PropertyAddress;

	private static int IsVisible_ReturnValue_Offset;

	private static bool IsSimulatingPhysics_IsValid;

	private static IntPtr IsSimulatingPhysics_FunctionAddress;

	private static int IsSimulatingPhysics_ParamsSize;

	private static bool IsSimulatingPhysics_BoneName_IsValid;

	private static FFieldAddress IsSimulatingPhysics_BoneName_PropertyAddress;

	private static int IsSimulatingPhysics_BoneName_Offset;

	private static bool IsSimulatingPhysics_ReturnValue_IsValid;

	private static FFieldAddress IsSimulatingPhysics_ReturnValue_PropertyAddress;

	private static int IsSimulatingPhysics_ReturnValue_Offset;

	private static bool IsAnySimulatingPhysics_IsValid;

	private static IntPtr IsAnySimulatingPhysics_FunctionAddress;

	private static int IsAnySimulatingPhysics_ParamsSize;

	private static bool IsAnySimulatingPhysics_ReturnValue_IsValid;

	private static FFieldAddress IsAnySimulatingPhysics_ReturnValue_PropertyAddress;

	private static int IsAnySimulatingPhysics_ReturnValue_Offset;

	private static bool GetUpVector_IsValid;

	private static IntPtr GetUpVector_FunctionAddress;

	private static int GetUpVector_ParamsSize;

	private static bool GetUpVector_ReturnValue_IsValid;

	private static FFieldAddress GetUpVector_ReturnValue_PropertyAddress;

	private static int GetUpVector_ReturnValue_Offset;

	private static bool GetSocketTransform_IsValid;

	private static IntPtr GetSocketTransform_FunctionAddress;

	private static int GetSocketTransform_ParamsSize;

	private static bool GetSocketTransform_InSocketName_IsValid;

	private static FFieldAddress GetSocketTransform_InSocketName_PropertyAddress;

	private static int GetSocketTransform_InSocketName_Offset;

	private static bool GetSocketTransform_TransformSpace_IsValid;

	private static FFieldAddress GetSocketTransform_TransformSpace_PropertyAddress;

	private static int GetSocketTransform_TransformSpace_Offset;

	private static bool GetSocketTransform_ReturnValue_IsValid;

	private static FFieldAddress GetSocketTransform_ReturnValue_PropertyAddress;

	private static int GetSocketTransform_ReturnValue_Offset;

	private static bool GetSocketRotation_IsValid;

	private static IntPtr GetSocketRotation_FunctionAddress;

	private static int GetSocketRotation_ParamsSize;

	private static bool GetSocketRotation_InSocketName_IsValid;

	private static FFieldAddress GetSocketRotation_InSocketName_PropertyAddress;

	private static int GetSocketRotation_InSocketName_Offset;

	private static bool GetSocketRotation_ReturnValue_IsValid;

	private static FFieldAddress GetSocketRotation_ReturnValue_PropertyAddress;

	private static int GetSocketRotation_ReturnValue_Offset;

	private static bool GetSocketLocation_IsValid;

	private static IntPtr GetSocketLocation_FunctionAddress;

	private static int GetSocketLocation_ParamsSize;

	private static bool GetSocketLocation_InSocketName_IsValid;

	private static FFieldAddress GetSocketLocation_InSocketName_PropertyAddress;

	private static int GetSocketLocation_InSocketName_Offset;

	private static bool GetSocketLocation_ReturnValue_IsValid;

	private static FFieldAddress GetSocketLocation_ReturnValue_PropertyAddress;

	private static int GetSocketLocation_ReturnValue_Offset;

	private static bool GetShouldUpdatePhysicsVolume_IsValid;

	private static IntPtr GetShouldUpdatePhysicsVolume_FunctionAddress;

	private static int GetShouldUpdatePhysicsVolume_ParamsSize;

	private static bool GetShouldUpdatePhysicsVolume_ReturnValue_IsValid;

	private static FFieldAddress GetShouldUpdatePhysicsVolume_ReturnValue_PropertyAddress;

	private static int GetShouldUpdatePhysicsVolume_ReturnValue_Offset;

	private static bool GetRightVector_IsValid;

	private static IntPtr GetRightVector_FunctionAddress;

	private static int GetRightVector_ParamsSize;

	private static bool GetRightVector_ReturnValue_IsValid;

	private static FFieldAddress GetRightVector_ReturnValue_PropertyAddress;

	private static int GetRightVector_ReturnValue_Offset;

	private static bool GetRelativeTransform_IsValid;

	private static IntPtr GetRelativeTransform_FunctionAddress;

	private static int GetRelativeTransform_ParamsSize;

	private static bool GetRelativeTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRelativeTransform_ReturnValue_PropertyAddress;

	private static int GetRelativeTransform_ReturnValue_Offset;

	private static bool GetPhysicsVolume_IsValid;

	private static IntPtr GetPhysicsVolume_FunctionAddress;

	private static int GetPhysicsVolume_ParamsSize;

	private static bool GetPhysicsVolume_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsVolume_ReturnValue_PropertyAddress;

	private static int GetPhysicsVolume_ReturnValue_Offset;

	private static bool GetParentComponents_IsValid;

	private static IntPtr GetParentComponents_FunctionAddress;

	private static int GetParentComponents_ParamsSize;

	private static bool GetParentComponents_Parents_IsValid;

	private static FFieldAddress GetParentComponents_Parents_PropertyAddress;

	private static int GetParentComponents_Parents_Offset;

	private static bool GetNumChildrenComponents_IsValid;

	private static IntPtr GetNumChildrenComponents_FunctionAddress;

	private static int GetNumChildrenComponents_ParamsSize;

	private static bool GetNumChildrenComponents_ReturnValue_IsValid;

	private static FFieldAddress GetNumChildrenComponents_ReturnValue_PropertyAddress;

	private static int GetNumChildrenComponents_ReturnValue_Offset;

	private static bool GetForwardVector_IsValid;

	private static IntPtr GetForwardVector_FunctionAddress;

	private static int GetForwardVector_ParamsSize;

	private static bool GetForwardVector_ReturnValue_IsValid;

	private static FFieldAddress GetForwardVector_ReturnValue_PropertyAddress;

	private static int GetForwardVector_ReturnValue_Offset;

	private static bool GetComponentVelocity_IsValid;

	private static IntPtr GetComponentVelocity_FunctionAddress;

	private static int GetComponentVelocity_ParamsSize;

	private static bool GetComponentVelocity_ReturnValue_IsValid;

	private static FFieldAddress GetComponentVelocity_ReturnValue_PropertyAddress;

	private static int GetComponentVelocity_ReturnValue_Offset;

	private static bool GetChildrenComponents_IsValid;

	private static IntPtr GetChildrenComponents_FunctionAddress;

	private static int GetChildrenComponents_ParamsSize;

	private static bool GetChildrenComponents_bIncludeAllDescendants_IsValid;

	private static FFieldAddress GetChildrenComponents_bIncludeAllDescendants_PropertyAddress;

	private static int GetChildrenComponents_bIncludeAllDescendants_Offset;

	private static bool GetChildrenComponents_Children_IsValid;

	private static FFieldAddress GetChildrenComponents_Children_PropertyAddress;

	private static int GetChildrenComponents_Children_Offset;

	private static bool GetChildComponent_IsValid;

	private static IntPtr GetChildComponent_FunctionAddress;

	private static int GetChildComponent_ParamsSize;

	private static bool GetChildComponent_ChildIndex_IsValid;

	private static FFieldAddress GetChildComponent_ChildIndex_PropertyAddress;

	private static int GetChildComponent_ChildIndex_Offset;

	private static bool GetChildComponent_ReturnValue_IsValid;

	private static FFieldAddress GetChildComponent_ReturnValue_PropertyAddress;

	private static int GetChildComponent_ReturnValue_Offset;

	private static bool GetAttachSocketName_IsValid;

	private static IntPtr GetAttachSocketName_FunctionAddress;

	private static int GetAttachSocketName_ParamsSize;

	private static bool GetAttachSocketName_ReturnValue_IsValid;

	private static FFieldAddress GetAttachSocketName_ReturnValue_PropertyAddress;

	private static int GetAttachSocketName_ReturnValue_Offset;

	private static bool GetAttachParent_IsValid;

	private static IntPtr GetAttachParent_FunctionAddress;

	private static int GetAttachParent_ParamsSize;

	private static bool GetAttachParent_ReturnValue_IsValid;

	private static FFieldAddress GetAttachParent_ReturnValue_PropertyAddress;

	private static int GetAttachParent_ReturnValue_Offset;

	private static bool GetAllSocketNames_IsValid;

	private static IntPtr GetAllSocketNames_FunctionAddress;

	private static int GetAllSocketNames_ParamsSize;

	private static bool GetAllSocketNames_ReturnValue_IsValid;

	private static FFieldAddress GetAllSocketNames_ReturnValue_PropertyAddress;

	private static int GetAllSocketNames_ReturnValue_Offset;

	private static bool DoesSocketExist_IsValid;

	private static IntPtr DoesSocketExist_FunctionAddress;

	private static int DoesSocketExist_ParamsSize;

	private static bool DoesSocketExist_InSocketName_IsValid;

	private static FFieldAddress DoesSocketExist_InSocketName_PropertyAddress;

	private static int DoesSocketExist_InSocketName_Offset;

	private static bool DoesSocketExist_ReturnValue_IsValid;

	private static FFieldAddress DoesSocketExist_ReturnValue_PropertyAddress;

	private static int DoesSocketExist_ReturnValue_Offset;

	private static bool DetachFromParent_IsValid;

	private static IntPtr DetachFromParent_FunctionAddress;

	private static int DetachFromParent_ParamsSize;

	private static bool DetachFromParent_bMaintainWorldPosition_IsValid;

	private static FFieldAddress DetachFromParent_bMaintainWorldPosition_PropertyAddress;

	private static int DetachFromParent_bMaintainWorldPosition_Offset;

	private static bool DetachFromParent_bCallModify_IsValid;

	private static FFieldAddress DetachFromParent_bCallModify_PropertyAddress;

	private static int DetachFromParent_bCallModify_Offset;

	[UProperty(Flags = (PropFlags)20266272411353653uL)]
	[UMetaPath("/Script/Engine.SceneComponent:RelativeLocation")]
	public FVector RelativeLocation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)18014472597668405uL)]
	[UMetaPath("/Script/Engine.SceneComponent:RelativeRotation")]
	public FRotator RelativeRotation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RelativeRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RelativeRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266281001288245uL)]
	[UMetaPath("/Script/Engine.SceneComponent:RelativeScale3D")]
	public FVector RelativeScale3D
	{
		get
		{
			CheckDestroyed();
			if (!RelativeScale3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeScale3D");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeScale3D_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeScale3D_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:RelativeScale3D");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeScale3D_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20270669384122405uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bAbsoluteLocation")]
	public bool AbsoluteLocation
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteLocation_Offset), 0, AbsoluteLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteLocation_Offset), 0, AbsoluteLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20270669384122405uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bAbsoluteRotation")]
	public bool AbsoluteRotation
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteRotation_Offset), 0, AbsoluteRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteRotation_Offset), 0, AbsoluteRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20270669384122405uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bAbsoluteScale")]
	public bool AbsoluteScale
	{
		get
		{
			CheckDestroyed();
			if (!AbsoluteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AbsoluteScale_Offset), 0, AbsoluteScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AbsoluteScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bAbsoluteScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AbsoluteScale_Offset), 0, AbsoluteScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266271337611317uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bVisible")]
	public bool Visible
	{
		get
		{
			CheckDestroyed();
			if (!Visible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bVisible");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Visible_Offset), 0, Visible_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Visible_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bVisible");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Visible_Offset), 0, Visible_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755476750467093uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bHiddenInGame")]
	public bool HiddenInGame
	{
		get
		{
			CheckDestroyed();
			if (!HiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bHiddenInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HiddenInGame_Offset), 0, HiddenInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bHiddenInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HiddenInGame_Offset), 0, HiddenInGame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SceneComponent:bUseAttachParentBound")]
	public bool UseAttachParentBound
	{
		get
		{
			CheckDestroyed();
			if (!UseAttachParentBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bUseAttachParentBound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAttachParentBound_Offset), 0, UseAttachParentBound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAttachParentBound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:bUseAttachParentBound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAttachParentBound_Offset), 0, UseAttachParentBound_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274869uL)]
	[UMetaPath("/Script/Engine.SceneComponent:Mobility")]
	public EComponentMobility Mobility
	{
		get
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:Mobility");
				return EComponentMobility.Static;
			}
			return EnumMarshaler<EComponentMobility>.FromNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:Mobility");
			}
			else
			{
				EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SceneComponent:DetailMode")]
	public EDetailMode DetailMode
	{
		get
		{
			CheckDestroyed();
			if (!DetailMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:DetailMode");
				return EDetailMode.DM_Low;
			}
			return EnumMarshaler<EDetailMode>.FromNative(IntPtr.Add(base.Address, DetailMode_Offset), 0, DetailMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetailMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:DetailMode");
			}
			else
			{
				EnumMarshaler<EDetailMode>.ToNative(IntPtr.Add(base.Address, DetailMode_Offset), 0, DetailMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.SceneComponent:PhysicsVolumeChangedDelegate")]
	public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsVolumeChangedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SceneComponent:PhysicsVolumeChangedDelegate");
				return new FPhysicsVolumeChanged();
			}
			if (PhysicsVolumeChangedDelegate_DelegateCached == null)
			{
				PhysicsVolumeChangedDelegate_DelegateCached = new FPhysicsVolumeChanged();
				PhysicsVolumeChangedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, PhysicsVolumeChangedDelegate_Offset));
			}
			return PhysicsVolumeChangedDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:ToggleVisibility")]
	public unsafe void ToggleVisibility(bool bPropagateToChildren = false)
	{
		CheckDestroyed();
		if (!ToggleVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:ToggleVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleVisibility_bPropagateToChildren_Offset), 0, ToggleVisibility_bPropagateToChildren_PropertyAddress.Address, bPropagateToChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, ToggleVisibility_FunctionAddress, intPtr, ToggleVisibility_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetWorldScale3D")]
	public unsafe void SetWorldScale3D(FVector NewScale)
	{
		CheckDestroyed();
		if (!SetWorldScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetWorldScale3D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWorldScale3D_NewScale_Offset), 0, SetWorldScale3D_NewScale_PropertyAddress.Address, NewScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldScale3D_FunctionAddress, intPtr, SetWorldScale3D_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetVisibility")]
	public unsafe void SetVisibility(bool bNewVisibility, bool bPropagateToChildren = false)
	{
		CheckDestroyed();
		if (!SetVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVisibility_bNewVisibility_Offset), 0, SetVisibility_bNewVisibility_PropertyAddress.Address, bNewVisibility);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVisibility_bPropagateToChildren_Offset), 0, SetVisibility_bPropagateToChildren_PropertyAddress.Address, bPropagateToChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisibility_FunctionAddress, intPtr, SetVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetShouldUpdatePhysicsVolume")]
	public unsafe void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume)
	{
		CheckDestroyed();
		if (!SetShouldUpdatePhysicsVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetShouldUpdatePhysicsVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShouldUpdatePhysicsVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShouldUpdatePhysicsVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_Offset), 0, SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_PropertyAddress.Address, bInShouldUpdatePhysicsVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShouldUpdatePhysicsVolume_FunctionAddress, intPtr, SetShouldUpdatePhysicsVolume_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetRelativeScale3D")]
	public unsafe void SetRelativeScale3D(FVector NewScale3D)
	{
		CheckDestroyed();
		if (!SetRelativeScale3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetRelativeScale3D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeScale3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeScale3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRelativeScale3D_NewScale3D_Offset), 0, SetRelativeScale3D_NewScale3D_PropertyAddress.Address, NewScale3D);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeScale3D_FunctionAddress, intPtr, SetRelativeScale3D_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetMobility")]
	public unsafe void SetMobility(EComponentMobility NewMobility)
	{
		CheckDestroyed();
		if (!SetMobility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetMobility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMobility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMobility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(intPtr, SetMobility_NewMobility_Offset), 0, SetMobility_NewMobility_PropertyAddress.Address, NewMobility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMobility_FunctionAddress, intPtr, SetMobility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetHiddenInGame")]
	public unsafe void SetHiddenInGame(bool NewHidden, bool bPropagateToChildren = false)
	{
		CheckDestroyed();
		if (!SetHiddenInGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetHiddenInGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHiddenInGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHiddenInGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHiddenInGame_NewHidden_Offset), 0, SetHiddenInGame_NewHidden_PropertyAddress.Address, NewHidden);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHiddenInGame_bPropagateToChildren_Offset), 0, SetHiddenInGame_bPropagateToChildren_PropertyAddress.Address, bPropagateToChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHiddenInGame_FunctionAddress, intPtr, SetHiddenInGame_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:SetAbsolute")]
	public unsafe void SetAbsolute(bool bNewAbsoluteLocation = false, bool bNewAbsoluteRotation = false, bool bNewAbsoluteScale = false)
	{
		CheckDestroyed();
		if (!SetAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:SetAbsolute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAbsolute_bNewAbsoluteLocation_Offset), 0, SetAbsolute_bNewAbsoluteLocation_PropertyAddress.Address, bNewAbsoluteLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAbsolute_bNewAbsoluteRotation_Offset), 0, SetAbsolute_bNewAbsoluteRotation_PropertyAddress.Address, bNewAbsoluteRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAbsolute_bNewAbsoluteScale_Offset), 0, SetAbsolute_bNewAbsoluteScale_PropertyAddress.Address, bNewAbsoluteScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAbsolute_FunctionAddress, intPtr, SetAbsolute_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SceneComponent:ResetRelativeTransform")]
	public unsafe void ResetRelativeTransform()
	{
		CheckDestroyed();
		if (!ResetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:ResetRelativeTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetRelativeTransform_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetRelativeTransform_FunctionAddress, argsSize: ResetRelativeTransform_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetWorldTransform")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetWorldTransform")]
	public unsafe void SetWorldTransform(FTransform NewTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetWorldTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetWorldTransform_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetWorldTransform_NewTransform_Offset), 0, SetWorldTransform_NewTransform_PropertyAddress.Address, NewTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldTransform_bSweep_Offset), 0, SetWorldTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetWorldTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldTransform_bTeleport_Offset), 0, SetWorldTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldTransform_FunctionAddress, intPtr, SetWorldTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetWorldTransform_SweepHitResult_Offset), 0, SetWorldTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetWorldRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetWorldRotation")]
	public unsafe void SetWorldRotation(FRotator NewRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetWorldRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetWorldRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetWorldRotation_NewRotation_Offset), 0, SetWorldRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldRotation_bSweep_Offset), 0, SetWorldRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetWorldRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldRotation_bTeleport_Offset), 0, SetWorldRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldRotation_FunctionAddress, intPtr, SetWorldRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetWorldRotation_SweepHitResult_Offset), 0, SetWorldRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetWorldLocationAndRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetWorldLocationAndRotation")]
	public unsafe void SetWorldLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetWorldLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetWorldLocationAndRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotation_NewLocation_Offset), 0, SetWorldLocationAndRotation_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotation_NewRotation_Offset), 0, SetWorldLocationAndRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotation_bSweep_Offset), 0, SetWorldLocationAndRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetWorldLocationAndRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotation_bTeleport_Offset), 0, SetWorldLocationAndRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldLocationAndRotation_FunctionAddress, intPtr, SetWorldLocationAndRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetWorldLocationAndRotation_SweepHitResult_Offset), 0, SetWorldLocationAndRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetWorldLocation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetWorldLocation")]
	public unsafe void SetWorldLocation(FVector NewLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetWorldLocation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWorldLocation_NewLocation_Offset), 0, SetWorldLocation_NewLocation_PropertyAddress.Address, NewLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldLocation_bSweep_Offset), 0, SetWorldLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetWorldLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldLocation_bTeleport_Offset), 0, SetWorldLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldLocation_FunctionAddress, intPtr, SetWorldLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetWorldLocation_SweepHitResult_Offset), 0, SetWorldLocation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetRelativeTransform")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetRelativeTransform")]
	public unsafe void SetRelativeTransform(FTransform NewTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetRelativeTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRelativeTransform_NewTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetRelativeTransform_NewTransform_Offset), 0, SetRelativeTransform_NewTransform_PropertyAddress.Address, NewTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeTransform_bSweep_Offset), 0, SetRelativeTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetRelativeTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeTransform_bTeleport_Offset), 0, SetRelativeTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeTransform_FunctionAddress, intPtr, SetRelativeTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetRelativeTransform_SweepHitResult_Offset), 0, SetRelativeTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetRelativeRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetRelativeRotation")]
	public unsafe void SetRelativeRotation(FRotator NewRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetRelativeRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetRelativeRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRelativeRotation_NewRotation_Offset), 0, SetRelativeRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeRotation_bSweep_Offset), 0, SetRelativeRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetRelativeRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeRotation_bTeleport_Offset), 0, SetRelativeRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeRotation_FunctionAddress, intPtr, SetRelativeRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetRelativeRotation_SweepHitResult_Offset), 0, SetRelativeRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetRelativeLocationAndRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetRelativeLocationAndRotation")]
	public unsafe void SetRelativeLocationAndRotation(FVector NewLocation, FRotator NewRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetRelativeLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetRelativeLocationAndRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRelativeLocationAndRotation_NewLocation_Offset), 0, SetRelativeLocationAndRotation_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetRelativeLocationAndRotation_NewRotation_Offset), 0, SetRelativeLocationAndRotation_NewRotation_PropertyAddress.Address, NewRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeLocationAndRotation_bSweep_Offset), 0, SetRelativeLocationAndRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetRelativeLocationAndRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeLocationAndRotation_bTeleport_Offset), 0, SetRelativeLocationAndRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeLocationAndRotation_FunctionAddress, intPtr, SetRelativeLocationAndRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetRelativeLocationAndRotation_SweepHitResult_Offset), 0, SetRelativeLocationAndRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SetRelativeLocation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_SetRelativeLocation")]
	public unsafe void SetRelativeLocation(FVector NewLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!SetRelativeLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_SetRelativeLocation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRelativeLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRelativeLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetRelativeLocation_NewLocation_Offset), 0, SetRelativeLocation_NewLocation_PropertyAddress.Address, NewLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeLocation_bSweep_Offset), 0, SetRelativeLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetRelativeLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRelativeLocation_bTeleport_Offset), 0, SetRelativeLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRelativeLocation_FunctionAddress, intPtr, SetRelativeLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetRelativeLocation_SweepHitResult_Offset), 0, SetRelativeLocation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetComponentToWorld")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_GetComponentToWorld")]
	public unsafe FTransform GetWorldTransform()
	{
		CheckDestroyed();
		if (!GetWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_GetComponentToWorld");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldTransform_FunctionAddress, intPtr, GetWorldTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetWorldTransform_ReturnValue_Offset), 0, GetWorldTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetComponentScale")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_GetComponentScale")]
	public unsafe FVector GetWorldScale()
	{
		CheckDestroyed();
		if (!GetWorldScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_GetComponentScale");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldScale_FunctionAddress, intPtr, GetWorldScale_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWorldScale_ReturnValue_Offset), 0, GetWorldScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetComponentRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_GetComponentRotation")]
	public unsafe FRotator GetWorldRotation()
	{
		CheckDestroyed();
		if (!GetWorldRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_GetComponentRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldRotation_FunctionAddress, intPtr, GetWorldRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetWorldRotation_ReturnValue_Offset), 0, GetWorldRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "K2_GetComponentLocation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_GetComponentLocation")]
	public unsafe FVector GetWorldLocation()
	{
		CheckDestroyed();
		if (!GetWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_GetComponentLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldLocation_FunctionAddress, intPtr, GetWorldLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetWorldLocation_ReturnValue_Offset), 0, GetWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_DetachFromComponent")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_DetachFromComponent")]
	public unsafe void DetachFromComponent(EDetachmentRule LocationRule = EDetachmentRule.KeepRelative, EDetachmentRule RotationRule = EDetachmentRule.KeepRelative, EDetachmentRule ScaleRule = EDetachmentRule.KeepRelative, bool bCallModify = true)
	{
		CheckDestroyed();
		if (!DetachFromComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_DetachFromComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetachFromComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetachFromComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromComponent_LocationRule_Offset), 0, DetachFromComponent_LocationRule_PropertyAddress.Address, LocationRule);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromComponent_RotationRule_Offset), 0, DetachFromComponent_RotationRule_PropertyAddress.Address, RotationRule);
		EnumMarshaler<EDetachmentRule>.ToNative(IntPtr.Add(intPtr, DetachFromComponent_ScaleRule_Offset), 0, DetachFromComponent_ScaleRule_PropertyAddress.Address, ScaleRule);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DetachFromComponent_bCallModify_Offset), 0, DetachFromComponent_bCallModify_PropertyAddress.Address, bCallModify);
		NativeReflection.InvokeFunctionOptimized(base.Address, DetachFromComponent_FunctionAddress, intPtr, DetachFromComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachToComponent")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AttachToComponent")]
	public unsafe bool AttachToComponent(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachToComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AttachToComponent");
			return false;
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
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AttachToComponent_ReturnValue_Offset), 0, AttachToComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_AttachTo")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AttachTo")]
	public unsafe bool AttachTo(USceneComponent InParent, FName InSocketName, EAttachLocation AttachType, bool bWeldSimulatedBodies)
	{
		CheckDestroyed();
		if (!AttachTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AttachTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, AttachTo_InParent_Offset), 0, AttachTo_InParent_PropertyAddress.Address, InParent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AttachTo_InSocketName_Offset), 0, AttachTo_InSocketName_PropertyAddress.Address, InSocketName);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, AttachTo_AttachType_Offset), 0, AttachTo_AttachType_PropertyAddress.Address, AttachType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AttachTo_bWeldSimulatedBodies_Offset), 0, AttachTo_bWeldSimulatedBodies_PropertyAddress.Address, bWeldSimulatedBodies);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachTo_FunctionAddress, intPtr, AttachTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AttachTo_ReturnValue_Offset), 0, AttachTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddWorldTransformKeepScale")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddWorldTransformKeepScale")]
	public unsafe void AddWorldTransformKeepScale(FTransform DeltaTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddWorldTransformKeepScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddWorldTransformKeepScale");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWorldTransformKeepScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWorldTransformKeepScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWorldTransformKeepScale_DeltaTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddWorldTransformKeepScale_DeltaTransform_Offset), 0, AddWorldTransformKeepScale_DeltaTransform_PropertyAddress.Address, DeltaTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldTransformKeepScale_bSweep_Offset), 0, AddWorldTransformKeepScale_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddWorldTransformKeepScale_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldTransformKeepScale_bTeleport_Offset), 0, AddWorldTransformKeepScale_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddWorldTransformKeepScale_FunctionAddress, intPtr, AddWorldTransformKeepScale_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddWorldTransformKeepScale_SweepHitResult_Offset), 0, AddWorldTransformKeepScale_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddWorldTransform")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddWorldTransform")]
	public unsafe void AddWorldTransform(FTransform DeltaTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddWorldTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWorldTransform_DeltaTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddWorldTransform_DeltaTransform_Offset), 0, AddWorldTransform_DeltaTransform_PropertyAddress.Address, DeltaTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldTransform_bSweep_Offset), 0, AddWorldTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddWorldTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldTransform_bTeleport_Offset), 0, AddWorldTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddWorldTransform_FunctionAddress, intPtr, AddWorldTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddWorldTransform_SweepHitResult_Offset), 0, AddWorldTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddWorldRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddWorldRotation")]
	public unsafe void AddWorldRotation(FRotator DeltaRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddWorldRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddWorldRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWorldRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWorldRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddWorldRotation_DeltaRotation_Offset), 0, AddWorldRotation_DeltaRotation_PropertyAddress.Address, DeltaRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldRotation_bSweep_Offset), 0, AddWorldRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddWorldRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldRotation_bTeleport_Offset), 0, AddWorldRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddWorldRotation_FunctionAddress, intPtr, AddWorldRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddWorldRotation_SweepHitResult_Offset), 0, AddWorldRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddWorldOffset")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddWorldOffset")]
	public unsafe void AddWorldOffset(FVector DeltaLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddWorldOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddWorldOffset");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWorldOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWorldOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddWorldOffset_DeltaLocation_Offset), 0, AddWorldOffset_DeltaLocation_PropertyAddress.Address, DeltaLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldOffset_bSweep_Offset), 0, AddWorldOffset_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddWorldOffset_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddWorldOffset_bTeleport_Offset), 0, AddWorldOffset_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddWorldOffset_FunctionAddress, intPtr, AddWorldOffset_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddWorldOffset_SweepHitResult_Offset), 0, AddWorldOffset_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddRelativeRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddRelativeRotation")]
	public unsafe void AddRelativeRotation(FRotator DeltaRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddRelativeRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddRelativeRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRelativeRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRelativeRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddRelativeRotation_DeltaRotation_Offset), 0, AddRelativeRotation_DeltaRotation_PropertyAddress.Address, DeltaRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRelativeRotation_bSweep_Offset), 0, AddRelativeRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddRelativeRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRelativeRotation_bTeleport_Offset), 0, AddRelativeRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRelativeRotation_FunctionAddress, intPtr, AddRelativeRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddRelativeRotation_SweepHitResult_Offset), 0, AddRelativeRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddRelativeLocation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddRelativeLocation")]
	public unsafe void AddRelativeLocation(FVector DeltaLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddRelativeLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddRelativeLocation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRelativeLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRelativeLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddRelativeLocation_DeltaLocation_Offset), 0, AddRelativeLocation_DeltaLocation_PropertyAddress.Address, DeltaLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRelativeLocation_bSweep_Offset), 0, AddRelativeLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddRelativeLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRelativeLocation_bTeleport_Offset), 0, AddRelativeLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRelativeLocation_FunctionAddress, intPtr, AddRelativeLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddRelativeLocation_SweepHitResult_Offset), 0, AddRelativeLocation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddLocalTransform")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddLocalTransform")]
	public unsafe void AddLocalTransform(FTransform DeltaTransform, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddLocalTransform");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddLocalTransform_DeltaTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddLocalTransform_DeltaTransform_Offset), 0, AddLocalTransform_DeltaTransform_PropertyAddress.Address, DeltaTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalTransform_bSweep_Offset), 0, AddLocalTransform_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddLocalTransform_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalTransform_bTeleport_Offset), 0, AddLocalTransform_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLocalTransform_FunctionAddress, intPtr, AddLocalTransform_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddLocalTransform_SweepHitResult_Offset), 0, AddLocalTransform_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddLocalRotation")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddLocalRotation")]
	public unsafe void AddLocalRotation(FRotator DeltaRotation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddLocalRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddLocalRotation");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocalRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocalRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddLocalRotation_DeltaRotation_Offset), 0, AddLocalRotation_DeltaRotation_PropertyAddress.Address, DeltaRotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalRotation_bSweep_Offset), 0, AddLocalRotation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddLocalRotation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalRotation_bTeleport_Offset), 0, AddLocalRotation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLocalRotation_FunctionAddress, intPtr, AddLocalRotation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddLocalRotation_SweepHitResult_Offset), 0, AddLocalRotation_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_AddLocalOffset")]
	[UMetaPath("/Script/Engine.SceneComponent:K2_AddLocalOffset")]
	public unsafe void AddLocalOffset(FVector DeltaLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		CheckDestroyed();
		if (!AddLocalOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:K2_AddLocalOffset");
			SweepHitResult = default(FHitResult);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocalOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocalOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddLocalOffset_DeltaLocation_Offset), 0, AddLocalOffset_DeltaLocation_PropertyAddress.Address, DeltaLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalOffset_bSweep_Offset), 0, AddLocalOffset_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(AddLocalOffset_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalOffset_bTeleport_Offset), 0, AddLocalOffset_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLocalOffset_FunctionAddress, intPtr, AddLocalOffset_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, AddLocalOffset_SweepHitResult_Offset), 0, AddLocalOffset_SweepHitResult_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SceneComponent:IsVisible")]
	public unsafe bool IsVisible()
	{
		CheckDestroyed();
		if (!IsVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:IsVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisible_FunctionAddress, intPtr, IsVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisible_ReturnValue_Offset), 0, IsVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SceneComponent:IsSimulatingPhysics")]
	public unsafe bool IsSimulatingPhysics(FName BoneName)
	{
		CheckDestroyed();
		if (!IsSimulatingPhysics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:IsSimulatingPhysics");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSimulatingPhysics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSimulatingPhysics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsSimulatingPhysics_BoneName_Offset), 0, IsSimulatingPhysics_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSimulatingPhysics_FunctionAddress, intPtr, IsSimulatingPhysics_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSimulatingPhysics_ReturnValue_Offset), 0, IsSimulatingPhysics_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SceneComponent:IsAnySimulatingPhysics")]
	public unsafe bool IsAnySimulatingPhysics()
	{
		CheckDestroyed();
		if (!IsAnySimulatingPhysics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:IsAnySimulatingPhysics");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnySimulatingPhysics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnySimulatingPhysics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnySimulatingPhysics_FunctionAddress, intPtr, IsAnySimulatingPhysics_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnySimulatingPhysics_ReturnValue_Offset), 0, IsAnySimulatingPhysics_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetUpVector")]
	public unsafe FVector GetUpVector()
	{
		CheckDestroyed();
		if (!GetUpVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetUpVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUpVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUpVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUpVector_FunctionAddress, intPtr, GetUpVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetUpVector_ReturnValue_Offset), 0, GetUpVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetSocketTransform")]
	public unsafe FTransform GetSocketTransform(FName InSocketName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
	{
		CheckDestroyed();
		if (!GetSocketTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetSocketTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketTransform_InSocketName_Offset), 0, GetSocketTransform_InSocketName_PropertyAddress.Address, InSocketName);
		EnumMarshaler<ERelativeTransformSpace>.ToNative(IntPtr.Add(intPtr, GetSocketTransform_TransformSpace_Offset), 0, GetSocketTransform_TransformSpace_PropertyAddress.Address, TransformSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketTransform_FunctionAddress, intPtr, GetSocketTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetSocketTransform_ReturnValue_Offset), 0, GetSocketTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetSocketRotation")]
	public unsafe FRotator GetSocketRotation(FName InSocketName)
	{
		CheckDestroyed();
		if (!GetSocketRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetSocketRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketRotation_InSocketName_Offset), 0, GetSocketRotation_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketRotation_FunctionAddress, intPtr, GetSocketRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetSocketRotation_ReturnValue_Offset), 0, GetSocketRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetSocketLocation")]
	public unsafe FVector GetSocketLocation(FName InSocketName)
	{
		CheckDestroyed();
		if (!GetSocketLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetSocketLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketLocation_InSocketName_Offset), 0, GetSocketLocation_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketLocation_FunctionAddress, intPtr, GetSocketLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSocketLocation_ReturnValue_Offset), 0, GetSocketLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetShouldUpdatePhysicsVolume")]
	public unsafe bool GetShouldUpdatePhysicsVolume()
	{
		CheckDestroyed();
		if (!GetShouldUpdatePhysicsVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetShouldUpdatePhysicsVolume");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShouldUpdatePhysicsVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShouldUpdatePhysicsVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShouldUpdatePhysicsVolume_FunctionAddress, intPtr, GetShouldUpdatePhysicsVolume_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetShouldUpdatePhysicsVolume_ReturnValue_Offset), 0, GetShouldUpdatePhysicsVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetRightVector")]
	public unsafe FVector GetRightVector()
	{
		CheckDestroyed();
		if (!GetRightVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetRightVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRightVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRightVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRightVector_FunctionAddress, intPtr, GetRightVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRightVector_ReturnValue_Offset), 0, GetRightVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetRelativeTransform")]
	public unsafe FTransform GetRelativeTransform()
	{
		CheckDestroyed();
		if (!GetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetRelativeTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRelativeTransform_FunctionAddress, intPtr, GetRelativeTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRelativeTransform_ReturnValue_Offset), 0, GetRelativeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetPhysicsVolume")]
	public unsafe APhysicsVolume GetPhysicsVolume()
	{
		CheckDestroyed();
		if (!GetPhysicsVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetPhysicsVolume");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsVolume_FunctionAddress, intPtr, GetPhysicsVolume_ParamsSize);
		return UObjectMarshaler<APhysicsVolume>.FromNative(IntPtr.Add(intPtr, GetPhysicsVolume_ReturnValue_Offset), 0, GetPhysicsVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetParentComponents")]
	public unsafe void GetParentComponents(out List<USceneComponent> Parents)
	{
		CheckDestroyed();
		if (!GetParentComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetParentComponents");
			Parents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentComponents_FunctionAddress, intPtr, GetParentComponents_ParamsSize);
		Parents = new TArrayCopyMarshaler<USceneComponent>(1, GetParentComponents_Parents_PropertyAddress, CachedMarshalingDelegates<USceneComponent, UObjectMarshaler<USceneComponent>>.FromNative, CachedMarshalingDelegates<USceneComponent, UObjectMarshaler<USceneComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetParentComponents_Parents_Offset));
		NativeReflection.DestroyValue_InContainer(GetParentComponents_Parents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetNumChildrenComponents")]
	public unsafe int GetNumChildrenComponents()
	{
		CheckDestroyed();
		if (!GetNumChildrenComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetNumChildrenComponents");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumChildrenComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumChildrenComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumChildrenComponents_FunctionAddress, intPtr, GetNumChildrenComponents_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumChildrenComponents_ReturnValue_Offset), 0, GetNumChildrenComponents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetForwardVector")]
	public unsafe FVector GetForwardVector()
	{
		CheckDestroyed();
		if (!GetForwardVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetForwardVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForwardVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForwardVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetForwardVector_FunctionAddress, intPtr, GetForwardVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetForwardVector_ReturnValue_Offset), 0, GetForwardVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetComponentVelocity")]
	public unsafe FVector GetComponentVelocity()
	{
		CheckDestroyed();
		if (!GetComponentVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetComponentVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponentVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponentVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetComponentVelocity_FunctionAddress, intPtr, GetComponentVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetComponentVelocity_ReturnValue_Offset), 0, GetComponentVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetChildrenComponents")]
	public unsafe void GetChildrenComponents(bool bIncludeAllDescendants, out List<USceneComponent> Children)
	{
		CheckDestroyed();
		if (!GetChildrenComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetChildrenComponents");
			Children = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildrenComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildrenComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetChildrenComponents_bIncludeAllDescendants_Offset), 0, GetChildrenComponents_bIncludeAllDescendants_PropertyAddress.Address, bIncludeAllDescendants);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildrenComponents_FunctionAddress, intPtr, GetChildrenComponents_ParamsSize);
		Children = new TArrayCopyMarshaler<USceneComponent>(1, GetChildrenComponents_Children_PropertyAddress, CachedMarshalingDelegates<USceneComponent, UObjectMarshaler<USceneComponent>>.FromNative, CachedMarshalingDelegates<USceneComponent, UObjectMarshaler<USceneComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildrenComponents_Children_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildrenComponents_Children_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetChildComponent")]
	public unsafe USceneComponent GetChildComponent(int ChildIndex)
	{
		CheckDestroyed();
		if (!GetChildComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetChildComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChildComponent_ChildIndex_Offset), 0, GetChildComponent_ChildIndex_PropertyAddress.Address, ChildIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildComponent_FunctionAddress, intPtr, GetChildComponent_ParamsSize);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GetChildComponent_ReturnValue_Offset), 0, GetChildComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetAttachSocketName")]
	public unsafe FName GetAttachSocketName()
	{
		CheckDestroyed();
		if (!GetAttachSocketName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetAttachSocketName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachSocketName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachSocketName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachSocketName_FunctionAddress, intPtr, GetAttachSocketName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAttachSocketName_ReturnValue_Offset), 0, GetAttachSocketName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetAttachParent")]
	public unsafe USceneComponent GetAttachParent()
	{
		CheckDestroyed();
		if (!GetAttachParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetAttachParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttachParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttachParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttachParent_FunctionAddress, intPtr, GetAttachParent_ParamsSize);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GetAttachParent_ReturnValue_Offset), 0, GetAttachParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SceneComponent:GetAllSocketNames")]
	public unsafe List<FName> GetAllSocketNames()
	{
		CheckDestroyed();
		if (!GetAllSocketNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:GetAllSocketNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSocketNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSocketNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllSocketNames_FunctionAddress, intPtr, GetAllSocketNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetAllSocketNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSocketNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSocketNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.SceneComponent:DoesSocketExist")]
	public unsafe bool DoesSocketExist(FName InSocketName)
	{
		CheckDestroyed();
		if (!DoesSocketExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:DoesSocketExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesSocketExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesSocketExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesSocketExist_InSocketName_Offset), 0, DoesSocketExist_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesSocketExist_FunctionAddress, intPtr, DoesSocketExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesSocketExist_ReturnValue_Offset), 0, DoesSocketExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.SceneComponent:DetachFromParent")]
	public unsafe void DetachFromParent(bool bMaintainWorldPosition = false, bool bCallModify = true)
	{
		CheckDestroyed();
		if (!DetachFromParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SceneComponent:DetachFromParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetachFromParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetachFromParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DetachFromParent_bMaintainWorldPosition_Offset), 0, DetachFromParent_bMaintainWorldPosition_PropertyAddress.Address, bMaintainWorldPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DetachFromParent_bCallModify_Offset), 0, DetachFromParent_bCallModify_PropertyAddress.Address, bCallModify);
		NativeReflection.InvokeFunctionOptimized(base.Address, DetachFromParent_FunctionAddress, intPtr, DetachFromParent_ParamsSize);
	}

	static USceneComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USceneComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USceneComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SceneComponent");
		RelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeLocation");
		RelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeLocation", Classes.FStructProperty);
		RelativeRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeRotation");
		RelativeRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeRotation", Classes.FStructProperty);
		RelativeScale3D_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeScale3D");
		RelativeScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeScale3D", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteLocation_PropertyAddress, intPtr, "bAbsoluteLocation");
		AbsoluteLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAbsoluteLocation");
		AbsoluteLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAbsoluteLocation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteRotation_PropertyAddress, intPtr, "bAbsoluteRotation");
		AbsoluteRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAbsoluteRotation");
		AbsoluteRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAbsoluteRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsoluteScale_PropertyAddress, intPtr, "bAbsoluteScale");
		AbsoluteScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAbsoluteScale");
		AbsoluteScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAbsoluteScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Visible_PropertyAddress, intPtr, "bVisible");
		Visible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisible");
		Visible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HiddenInGame_PropertyAddress, intPtr, "bHiddenInGame");
		HiddenInGame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHiddenInGame");
		HiddenInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHiddenInGame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAttachParentBound_PropertyAddress, intPtr, "bUseAttachParentBound");
		UseAttachParentBound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAttachParentBound");
		UseAttachParentBound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAttachParentBound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Mobility_PropertyAddress, intPtr, "Mobility");
		Mobility_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mobility");
		Mobility_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mobility", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DetailMode_PropertyAddress, intPtr, "DetailMode");
		DetailMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DetailMode");
		DetailMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DetailMode", Classes.FByteProperty);
		PhysicsVolumeChangedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicsVolumeChangedDelegate");
		PhysicsVolumeChangedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicsVolumeChangedDelegate", Classes.FMulticastDelegateProperty);
		ToggleVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToggleVisibility");
		ToggleVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleVisibility_bPropagateToChildren_PropertyAddress, ToggleVisibility_FunctionAddress, "bPropagateToChildren");
		ToggleVisibility_bPropagateToChildren_Offset = NativeReflectionCached.GetPropertyOffset(ToggleVisibility_FunctionAddress, "bPropagateToChildren");
		ToggleVisibility_bPropagateToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleVisibility_FunctionAddress, "bPropagateToChildren", Classes.FBoolProperty);
		ToggleVisibility_IsValid = ToggleVisibility_FunctionAddress != IntPtr.Zero && ToggleVisibility_bPropagateToChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:ToggleVisibility", ToggleVisibility_IsValid);
		SetWorldScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWorldScale3D");
		SetWorldScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldScale3D_NewScale_PropertyAddress, SetWorldScale3D_FunctionAddress, "NewScale");
		SetWorldScale3D_NewScale_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldScale3D_FunctionAddress, "NewScale");
		SetWorldScale3D_NewScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldScale3D_FunctionAddress, "NewScale", Classes.FStructProperty);
		SetWorldScale3D_IsValid = SetWorldScale3D_FunctionAddress != IntPtr.Zero && SetWorldScale3D_NewScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetWorldScale3D", SetWorldScale3D_IsValid);
		SetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVisibility");
		SetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisibility_bNewVisibility_PropertyAddress, SetVisibility_FunctionAddress, "bNewVisibility");
		SetVisibility_bNewVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibility_FunctionAddress, "bNewVisibility");
		SetVisibility_bNewVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibility_FunctionAddress, "bNewVisibility", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVisibility_bPropagateToChildren_PropertyAddress, SetVisibility_FunctionAddress, "bPropagateToChildren");
		SetVisibility_bPropagateToChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibility_FunctionAddress, "bPropagateToChildren");
		SetVisibility_bPropagateToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibility_FunctionAddress, "bPropagateToChildren", Classes.FBoolProperty);
		SetVisibility_IsValid = SetVisibility_FunctionAddress != IntPtr.Zero && SetVisibility_bNewVisibility_IsValid && SetVisibility_bPropagateToChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetVisibility", SetVisibility_IsValid);
		SetShouldUpdatePhysicsVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShouldUpdatePhysicsVolume");
		SetShouldUpdatePhysicsVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShouldUpdatePhysicsVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_PropertyAddress, SetShouldUpdatePhysicsVolume_FunctionAddress, "bInShouldUpdatePhysicsVolume");
		SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetShouldUpdatePhysicsVolume_FunctionAddress, "bInShouldUpdatePhysicsVolume");
		SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShouldUpdatePhysicsVolume_FunctionAddress, "bInShouldUpdatePhysicsVolume", Classes.FBoolProperty);
		SetShouldUpdatePhysicsVolume_IsValid = SetShouldUpdatePhysicsVolume_FunctionAddress != IntPtr.Zero && SetShouldUpdatePhysicsVolume_bInShouldUpdatePhysicsVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetShouldUpdatePhysicsVolume", SetShouldUpdatePhysicsVolume_IsValid);
		SetRelativeScale3D_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRelativeScale3D");
		SetRelativeScale3D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeScale3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeScale3D_NewScale3D_PropertyAddress, SetRelativeScale3D_FunctionAddress, "NewScale3D");
		SetRelativeScale3D_NewScale3D_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeScale3D_FunctionAddress, "NewScale3D");
		SetRelativeScale3D_NewScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeScale3D_FunctionAddress, "NewScale3D", Classes.FStructProperty);
		SetRelativeScale3D_IsValid = SetRelativeScale3D_FunctionAddress != IntPtr.Zero && SetRelativeScale3D_NewScale3D_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetRelativeScale3D", SetRelativeScale3D_IsValid);
		SetMobility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMobility");
		SetMobility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMobility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMobility_NewMobility_PropertyAddress, SetMobility_FunctionAddress, "NewMobility");
		SetMobility_NewMobility_Offset = NativeReflectionCached.GetPropertyOffset(SetMobility_FunctionAddress, "NewMobility");
		SetMobility_NewMobility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMobility_FunctionAddress, "NewMobility", Classes.FByteProperty);
		SetMobility_IsValid = SetMobility_FunctionAddress != IntPtr.Zero && SetMobility_NewMobility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetMobility", SetMobility_IsValid);
		SetHiddenInGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHiddenInGame");
		SetHiddenInGame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHiddenInGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHiddenInGame_NewHidden_PropertyAddress, SetHiddenInGame_FunctionAddress, "NewHidden");
		SetHiddenInGame_NewHidden_Offset = NativeReflectionCached.GetPropertyOffset(SetHiddenInGame_FunctionAddress, "NewHidden");
		SetHiddenInGame_NewHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHiddenInGame_FunctionAddress, "NewHidden", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHiddenInGame_bPropagateToChildren_PropertyAddress, SetHiddenInGame_FunctionAddress, "bPropagateToChildren");
		SetHiddenInGame_bPropagateToChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetHiddenInGame_FunctionAddress, "bPropagateToChildren");
		SetHiddenInGame_bPropagateToChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHiddenInGame_FunctionAddress, "bPropagateToChildren", Classes.FBoolProperty);
		SetHiddenInGame_IsValid = SetHiddenInGame_FunctionAddress != IntPtr.Zero && SetHiddenInGame_NewHidden_IsValid && SetHiddenInGame_bPropagateToChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetHiddenInGame", SetHiddenInGame_IsValid);
		SetAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAbsolute");
		SetAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAbsolute_bNewAbsoluteLocation_PropertyAddress, SetAbsolute_FunctionAddress, "bNewAbsoluteLocation");
		SetAbsolute_bNewAbsoluteLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsolute_FunctionAddress, "bNewAbsoluteLocation");
		SetAbsolute_bNewAbsoluteLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsolute_FunctionAddress, "bNewAbsoluteLocation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAbsolute_bNewAbsoluteRotation_PropertyAddress, SetAbsolute_FunctionAddress, "bNewAbsoluteRotation");
		SetAbsolute_bNewAbsoluteRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsolute_FunctionAddress, "bNewAbsoluteRotation");
		SetAbsolute_bNewAbsoluteRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsolute_FunctionAddress, "bNewAbsoluteRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAbsolute_bNewAbsoluteScale_PropertyAddress, SetAbsolute_FunctionAddress, "bNewAbsoluteScale");
		SetAbsolute_bNewAbsoluteScale_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsolute_FunctionAddress, "bNewAbsoluteScale");
		SetAbsolute_bNewAbsoluteScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsolute_FunctionAddress, "bNewAbsoluteScale", Classes.FBoolProperty);
		SetAbsolute_IsValid = SetAbsolute_FunctionAddress != IntPtr.Zero && SetAbsolute_bNewAbsoluteLocation_IsValid && SetAbsolute_bNewAbsoluteRotation_IsValid && SetAbsolute_bNewAbsoluteScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:SetAbsolute", SetAbsolute_IsValid);
		ResetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetRelativeTransform");
		ResetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetRelativeTransform_FunctionAddress);
		ResetRelativeTransform_IsValid = ResetRelativeTransform_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:ResetRelativeTransform", ResetRelativeTransform_IsValid);
		SetWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetWorldTransform");
		SetWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_NewTransform_PropertyAddress, SetWorldTransform_FunctionAddress, "NewTransform");
		SetWorldTransform_NewTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "NewTransform");
		SetWorldTransform_NewTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "NewTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_bSweep_PropertyAddress, SetWorldTransform_FunctionAddress, "bSweep");
		SetWorldTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "bSweep");
		SetWorldTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_SweepHitResult_PropertyAddress, SetWorldTransform_FunctionAddress, "SweepHitResult");
		SetWorldTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "SweepHitResult");
		SetWorldTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldTransform_bTeleport_PropertyAddress, SetWorldTransform_FunctionAddress, "bTeleport");
		SetWorldTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldTransform_FunctionAddress, "bTeleport");
		SetWorldTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetWorldTransform_IsValid = SetWorldTransform_FunctionAddress != IntPtr.Zero && SetWorldTransform_NewTransform_IsValid && SetWorldTransform_bSweep_IsValid && SetWorldTransform_SweepHitResult_IsValid && SetWorldTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetWorldTransform", SetWorldTransform_IsValid);
		SetWorldRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetWorldRotation");
		SetWorldRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldRotation_NewRotation_PropertyAddress, SetWorldRotation_FunctionAddress, "NewRotation");
		SetWorldRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldRotation_FunctionAddress, "NewRotation");
		SetWorldRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldRotation_bSweep_PropertyAddress, SetWorldRotation_FunctionAddress, "bSweep");
		SetWorldRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldRotation_FunctionAddress, "bSweep");
		SetWorldRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldRotation_SweepHitResult_PropertyAddress, SetWorldRotation_FunctionAddress, "SweepHitResult");
		SetWorldRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldRotation_FunctionAddress, "SweepHitResult");
		SetWorldRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldRotation_bTeleport_PropertyAddress, SetWorldRotation_FunctionAddress, "bTeleport");
		SetWorldRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldRotation_FunctionAddress, "bTeleport");
		SetWorldRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetWorldRotation_IsValid = SetWorldRotation_FunctionAddress != IntPtr.Zero && SetWorldRotation_NewRotation_IsValid && SetWorldRotation_bSweep_IsValid && SetWorldRotation_SweepHitResult_IsValid && SetWorldRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetWorldRotation", SetWorldRotation_IsValid);
		SetWorldLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetWorldLocationAndRotation");
		SetWorldLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotation_NewLocation_PropertyAddress, SetWorldLocationAndRotation_FunctionAddress, "NewLocation");
		SetWorldLocationAndRotation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotation_FunctionAddress, "NewLocation");
		SetWorldLocationAndRotation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotation_NewRotation_PropertyAddress, SetWorldLocationAndRotation_FunctionAddress, "NewRotation");
		SetWorldLocationAndRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotation_FunctionAddress, "NewRotation");
		SetWorldLocationAndRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotation_bSweep_PropertyAddress, SetWorldLocationAndRotation_FunctionAddress, "bSweep");
		SetWorldLocationAndRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotation_FunctionAddress, "bSweep");
		SetWorldLocationAndRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotation_SweepHitResult_PropertyAddress, SetWorldLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetWorldLocationAndRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetWorldLocationAndRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotation_bTeleport_PropertyAddress, SetWorldLocationAndRotation_FunctionAddress, "bTeleport");
		SetWorldLocationAndRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotation_FunctionAddress, "bTeleport");
		SetWorldLocationAndRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetWorldLocationAndRotation_IsValid = SetWorldLocationAndRotation_FunctionAddress != IntPtr.Zero && SetWorldLocationAndRotation_NewLocation_IsValid && SetWorldLocationAndRotation_NewRotation_IsValid && SetWorldLocationAndRotation_bSweep_IsValid && SetWorldLocationAndRotation_SweepHitResult_IsValid && SetWorldLocationAndRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetWorldLocationAndRotation", SetWorldLocationAndRotation_IsValid);
		SetWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetWorldLocation");
		SetWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocation_NewLocation_PropertyAddress, SetWorldLocation_FunctionAddress, "NewLocation");
		SetWorldLocation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocation_FunctionAddress, "NewLocation");
		SetWorldLocation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocation_bSweep_PropertyAddress, SetWorldLocation_FunctionAddress, "bSweep");
		SetWorldLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocation_FunctionAddress, "bSweep");
		SetWorldLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocation_SweepHitResult_PropertyAddress, SetWorldLocation_FunctionAddress, "SweepHitResult");
		SetWorldLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocation_FunctionAddress, "SweepHitResult");
		SetWorldLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocation_bTeleport_PropertyAddress, SetWorldLocation_FunctionAddress, "bTeleport");
		SetWorldLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocation_FunctionAddress, "bTeleport");
		SetWorldLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetWorldLocation_IsValid = SetWorldLocation_FunctionAddress != IntPtr.Zero && SetWorldLocation_NewLocation_IsValid && SetWorldLocation_bSweep_IsValid && SetWorldLocation_SweepHitResult_IsValid && SetWorldLocation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetWorldLocation", SetWorldLocation_IsValid);
		SetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetRelativeTransform");
		SetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_NewTransform_PropertyAddress, SetRelativeTransform_FunctionAddress, "NewTransform");
		SetRelativeTransform_NewTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "NewTransform");
		SetRelativeTransform_NewTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "NewTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_bSweep_PropertyAddress, SetRelativeTransform_FunctionAddress, "bSweep");
		SetRelativeTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "bSweep");
		SetRelativeTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_SweepHitResult_PropertyAddress, SetRelativeTransform_FunctionAddress, "SweepHitResult");
		SetRelativeTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "SweepHitResult");
		SetRelativeTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeTransform_bTeleport_PropertyAddress, SetRelativeTransform_FunctionAddress, "bTeleport");
		SetRelativeTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeTransform_FunctionAddress, "bTeleport");
		SetRelativeTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetRelativeTransform_IsValid = SetRelativeTransform_FunctionAddress != IntPtr.Zero && SetRelativeTransform_NewTransform_IsValid && SetRelativeTransform_bSweep_IsValid && SetRelativeTransform_SweepHitResult_IsValid && SetRelativeTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetRelativeTransform", SetRelativeTransform_IsValid);
		SetRelativeRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetRelativeRotation");
		SetRelativeRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeRotation_NewRotation_PropertyAddress, SetRelativeRotation_FunctionAddress, "NewRotation");
		SetRelativeRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeRotation_FunctionAddress, "NewRotation");
		SetRelativeRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeRotation_bSweep_PropertyAddress, SetRelativeRotation_FunctionAddress, "bSweep");
		SetRelativeRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeRotation_FunctionAddress, "bSweep");
		SetRelativeRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeRotation_SweepHitResult_PropertyAddress, SetRelativeRotation_FunctionAddress, "SweepHitResult");
		SetRelativeRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeRotation_FunctionAddress, "SweepHitResult");
		SetRelativeRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeRotation_bTeleport_PropertyAddress, SetRelativeRotation_FunctionAddress, "bTeleport");
		SetRelativeRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeRotation_FunctionAddress, "bTeleport");
		SetRelativeRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetRelativeRotation_IsValid = SetRelativeRotation_FunctionAddress != IntPtr.Zero && SetRelativeRotation_NewRotation_IsValid && SetRelativeRotation_bSweep_IsValid && SetRelativeRotation_SweepHitResult_IsValid && SetRelativeRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetRelativeRotation", SetRelativeRotation_IsValid);
		SetRelativeLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetRelativeLocationAndRotation");
		SetRelativeLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocationAndRotation_NewLocation_PropertyAddress, SetRelativeLocationAndRotation_FunctionAddress, "NewLocation");
		SetRelativeLocationAndRotation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocationAndRotation_FunctionAddress, "NewLocation");
		SetRelativeLocationAndRotation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocationAndRotation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocationAndRotation_NewRotation_PropertyAddress, SetRelativeLocationAndRotation_FunctionAddress, "NewRotation");
		SetRelativeLocationAndRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocationAndRotation_FunctionAddress, "NewRotation");
		SetRelativeLocationAndRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocationAndRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocationAndRotation_bSweep_PropertyAddress, SetRelativeLocationAndRotation_FunctionAddress, "bSweep");
		SetRelativeLocationAndRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocationAndRotation_FunctionAddress, "bSweep");
		SetRelativeLocationAndRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocationAndRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocationAndRotation_SweepHitResult_PropertyAddress, SetRelativeLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetRelativeLocationAndRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocationAndRotation_FunctionAddress, "SweepHitResult");
		SetRelativeLocationAndRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocationAndRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocationAndRotation_bTeleport_PropertyAddress, SetRelativeLocationAndRotation_FunctionAddress, "bTeleport");
		SetRelativeLocationAndRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocationAndRotation_FunctionAddress, "bTeleport");
		SetRelativeLocationAndRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocationAndRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetRelativeLocationAndRotation_IsValid = SetRelativeLocationAndRotation_FunctionAddress != IntPtr.Zero && SetRelativeLocationAndRotation_NewLocation_IsValid && SetRelativeLocationAndRotation_NewRotation_IsValid && SetRelativeLocationAndRotation_bSweep_IsValid && SetRelativeLocationAndRotation_SweepHitResult_IsValid && SetRelativeLocationAndRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetRelativeLocationAndRotation", SetRelativeLocationAndRotation_IsValid);
		SetRelativeLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetRelativeLocation");
		SetRelativeLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRelativeLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocation_NewLocation_PropertyAddress, SetRelativeLocation_FunctionAddress, "NewLocation");
		SetRelativeLocation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocation_FunctionAddress, "NewLocation");
		SetRelativeLocation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocation_bSweep_PropertyAddress, SetRelativeLocation_FunctionAddress, "bSweep");
		SetRelativeLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocation_FunctionAddress, "bSweep");
		SetRelativeLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocation_SweepHitResult_PropertyAddress, SetRelativeLocation_FunctionAddress, "SweepHitResult");
		SetRelativeLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocation_FunctionAddress, "SweepHitResult");
		SetRelativeLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRelativeLocation_bTeleport_PropertyAddress, SetRelativeLocation_FunctionAddress, "bTeleport");
		SetRelativeLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetRelativeLocation_FunctionAddress, "bTeleport");
		SetRelativeLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRelativeLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		SetRelativeLocation_IsValid = SetRelativeLocation_FunctionAddress != IntPtr.Zero && SetRelativeLocation_NewLocation_IsValid && SetRelativeLocation_bSweep_IsValid && SetRelativeLocation_SweepHitResult_IsValid && SetRelativeLocation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_SetRelativeLocation", SetRelativeLocation_IsValid);
		GetWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetComponentToWorld");
		GetWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldTransform_ReturnValue_PropertyAddress, GetWorldTransform_FunctionAddress, "ReturnValue");
		GetWorldTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldTransform_FunctionAddress, "ReturnValue");
		GetWorldTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWorldTransform_IsValid = GetWorldTransform_FunctionAddress != IntPtr.Zero && GetWorldTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_GetComponentToWorld", GetWorldTransform_IsValid);
		GetWorldScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetComponentScale");
		GetWorldScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldScale_ReturnValue_PropertyAddress, GetWorldScale_FunctionAddress, "ReturnValue");
		GetWorldScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldScale_FunctionAddress, "ReturnValue");
		GetWorldScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldScale_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWorldScale_IsValid = GetWorldScale_FunctionAddress != IntPtr.Zero && GetWorldScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_GetComponentScale", GetWorldScale_IsValid);
		GetWorldRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetComponentRotation");
		GetWorldRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldRotation_ReturnValue_PropertyAddress, GetWorldRotation_FunctionAddress, "ReturnValue");
		GetWorldRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldRotation_FunctionAddress, "ReturnValue");
		GetWorldRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWorldRotation_IsValid = GetWorldRotation_FunctionAddress != IntPtr.Zero && GetWorldRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_GetComponentRotation", GetWorldRotation_IsValid);
		GetWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetComponentLocation");
		GetWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldLocation_ReturnValue_PropertyAddress, GetWorldLocation_FunctionAddress, "ReturnValue");
		GetWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldLocation_FunctionAddress, "ReturnValue");
		GetWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWorldLocation_IsValid = GetWorldLocation_FunctionAddress != IntPtr.Zero && GetWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_GetComponentLocation", GetWorldLocation_IsValid);
		DetachFromComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_DetachFromComponent");
		DetachFromComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(DetachFromComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetachFromComponent_LocationRule_PropertyAddress, DetachFromComponent_FunctionAddress, "LocationRule");
		DetachFromComponent_LocationRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromComponent_FunctionAddress, "LocationRule");
		DetachFromComponent_LocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromComponent_FunctionAddress, "LocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromComponent_RotationRule_PropertyAddress, DetachFromComponent_FunctionAddress, "RotationRule");
		DetachFromComponent_RotationRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromComponent_FunctionAddress, "RotationRule");
		DetachFromComponent_RotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromComponent_FunctionAddress, "RotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromComponent_ScaleRule_PropertyAddress, DetachFromComponent_FunctionAddress, "ScaleRule");
		DetachFromComponent_ScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromComponent_FunctionAddress, "ScaleRule");
		DetachFromComponent_ScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromComponent_FunctionAddress, "ScaleRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromComponent_bCallModify_PropertyAddress, DetachFromComponent_FunctionAddress, "bCallModify");
		DetachFromComponent_bCallModify_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromComponent_FunctionAddress, "bCallModify");
		DetachFromComponent_bCallModify_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromComponent_FunctionAddress, "bCallModify", Classes.FBoolProperty);
		DetachFromComponent_IsValid = DetachFromComponent_FunctionAddress != IntPtr.Zero && DetachFromComponent_LocationRule_IsValid && DetachFromComponent_RotationRule_IsValid && DetachFromComponent_ScaleRule_IsValid && DetachFromComponent_bCallModify_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_DetachFromComponent", DetachFromComponent_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref AttachToComponent_ReturnValue_PropertyAddress, AttachToComponent_FunctionAddress, "ReturnValue");
		AttachToComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AttachToComponent_FunctionAddress, "ReturnValue");
		AttachToComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachToComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AttachToComponent_IsValid = AttachToComponent_FunctionAddress != IntPtr.Zero && AttachToComponent_Parent_IsValid && AttachToComponent_SocketName_IsValid && AttachToComponent_LocationRule_IsValid && AttachToComponent_RotationRule_IsValid && AttachToComponent_ScaleRule_IsValid && AttachToComponent_bWeldSimulatedBodies_IsValid && AttachToComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AttachToComponent", AttachToComponent_IsValid);
		AttachTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AttachTo");
		AttachTo_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachTo_InParent_PropertyAddress, AttachTo_FunctionAddress, "InParent");
		AttachTo_InParent_Offset = NativeReflectionCached.GetPropertyOffset(AttachTo_FunctionAddress, "InParent");
		AttachTo_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachTo_FunctionAddress, "InParent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachTo_InSocketName_PropertyAddress, AttachTo_FunctionAddress, "InSocketName");
		AttachTo_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(AttachTo_FunctionAddress, "InSocketName");
		AttachTo_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachTo_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachTo_AttachType_PropertyAddress, AttachTo_FunctionAddress, "AttachType");
		AttachTo_AttachType_Offset = NativeReflectionCached.GetPropertyOffset(AttachTo_FunctionAddress, "AttachType");
		AttachTo_AttachType_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachTo_FunctionAddress, "AttachType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachTo_bWeldSimulatedBodies_PropertyAddress, AttachTo_FunctionAddress, "bWeldSimulatedBodies");
		AttachTo_bWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(AttachTo_FunctionAddress, "bWeldSimulatedBodies");
		AttachTo_bWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachTo_FunctionAddress, "bWeldSimulatedBodies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AttachTo_ReturnValue_PropertyAddress, AttachTo_FunctionAddress, "ReturnValue");
		AttachTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AttachTo_FunctionAddress, "ReturnValue");
		AttachTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AttachTo_IsValid = AttachTo_FunctionAddress != IntPtr.Zero && AttachTo_InParent_IsValid && AttachTo_InSocketName_IsValid && AttachTo_AttachType_IsValid && AttachTo_bWeldSimulatedBodies_IsValid && AttachTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AttachTo", AttachTo_IsValid);
		AddWorldTransformKeepScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddWorldTransformKeepScale");
		AddWorldTransformKeepScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWorldTransformKeepScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransformKeepScale_DeltaTransform_PropertyAddress, AddWorldTransformKeepScale_FunctionAddress, "DeltaTransform");
		AddWorldTransformKeepScale_DeltaTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransformKeepScale_FunctionAddress, "DeltaTransform");
		AddWorldTransformKeepScale_DeltaTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransformKeepScale_FunctionAddress, "DeltaTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransformKeepScale_bSweep_PropertyAddress, AddWorldTransformKeepScale_FunctionAddress, "bSweep");
		AddWorldTransformKeepScale_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransformKeepScale_FunctionAddress, "bSweep");
		AddWorldTransformKeepScale_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransformKeepScale_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransformKeepScale_SweepHitResult_PropertyAddress, AddWorldTransformKeepScale_FunctionAddress, "SweepHitResult");
		AddWorldTransformKeepScale_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransformKeepScale_FunctionAddress, "SweepHitResult");
		AddWorldTransformKeepScale_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransformKeepScale_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransformKeepScale_bTeleport_PropertyAddress, AddWorldTransformKeepScale_FunctionAddress, "bTeleport");
		AddWorldTransformKeepScale_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransformKeepScale_FunctionAddress, "bTeleport");
		AddWorldTransformKeepScale_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransformKeepScale_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddWorldTransformKeepScale_IsValid = AddWorldTransformKeepScale_FunctionAddress != IntPtr.Zero && AddWorldTransformKeepScale_DeltaTransform_IsValid && AddWorldTransformKeepScale_bSweep_IsValid && AddWorldTransformKeepScale_SweepHitResult_IsValid && AddWorldTransformKeepScale_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddWorldTransformKeepScale", AddWorldTransformKeepScale_IsValid);
		AddWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddWorldTransform");
		AddWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransform_DeltaTransform_PropertyAddress, AddWorldTransform_FunctionAddress, "DeltaTransform");
		AddWorldTransform_DeltaTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransform_FunctionAddress, "DeltaTransform");
		AddWorldTransform_DeltaTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransform_FunctionAddress, "DeltaTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransform_bSweep_PropertyAddress, AddWorldTransform_FunctionAddress, "bSweep");
		AddWorldTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransform_FunctionAddress, "bSweep");
		AddWorldTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransform_SweepHitResult_PropertyAddress, AddWorldTransform_FunctionAddress, "SweepHitResult");
		AddWorldTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransform_FunctionAddress, "SweepHitResult");
		AddWorldTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldTransform_bTeleport_PropertyAddress, AddWorldTransform_FunctionAddress, "bTeleport");
		AddWorldTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldTransform_FunctionAddress, "bTeleport");
		AddWorldTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddWorldTransform_IsValid = AddWorldTransform_FunctionAddress != IntPtr.Zero && AddWorldTransform_DeltaTransform_IsValid && AddWorldTransform_bSweep_IsValid && AddWorldTransform_SweepHitResult_IsValid && AddWorldTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddWorldTransform", AddWorldTransform_IsValid);
		AddWorldRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddWorldRotation");
		AddWorldRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWorldRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWorldRotation_DeltaRotation_PropertyAddress, AddWorldRotation_FunctionAddress, "DeltaRotation");
		AddWorldRotation_DeltaRotation_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldRotation_FunctionAddress, "DeltaRotation");
		AddWorldRotation_DeltaRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldRotation_FunctionAddress, "DeltaRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldRotation_bSweep_PropertyAddress, AddWorldRotation_FunctionAddress, "bSweep");
		AddWorldRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldRotation_FunctionAddress, "bSweep");
		AddWorldRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldRotation_SweepHitResult_PropertyAddress, AddWorldRotation_FunctionAddress, "SweepHitResult");
		AddWorldRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldRotation_FunctionAddress, "SweepHitResult");
		AddWorldRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldRotation_bTeleport_PropertyAddress, AddWorldRotation_FunctionAddress, "bTeleport");
		AddWorldRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldRotation_FunctionAddress, "bTeleport");
		AddWorldRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddWorldRotation_IsValid = AddWorldRotation_FunctionAddress != IntPtr.Zero && AddWorldRotation_DeltaRotation_IsValid && AddWorldRotation_bSweep_IsValid && AddWorldRotation_SweepHitResult_IsValid && AddWorldRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddWorldRotation", AddWorldRotation_IsValid);
		AddWorldOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddWorldOffset");
		AddWorldOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWorldOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWorldOffset_DeltaLocation_PropertyAddress, AddWorldOffset_FunctionAddress, "DeltaLocation");
		AddWorldOffset_DeltaLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldOffset_FunctionAddress, "DeltaLocation");
		AddWorldOffset_DeltaLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldOffset_FunctionAddress, "DeltaLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldOffset_bSweep_PropertyAddress, AddWorldOffset_FunctionAddress, "bSweep");
		AddWorldOffset_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldOffset_FunctionAddress, "bSweep");
		AddWorldOffset_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldOffset_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldOffset_SweepHitResult_PropertyAddress, AddWorldOffset_FunctionAddress, "SweepHitResult");
		AddWorldOffset_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldOffset_FunctionAddress, "SweepHitResult");
		AddWorldOffset_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldOffset_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWorldOffset_bTeleport_PropertyAddress, AddWorldOffset_FunctionAddress, "bTeleport");
		AddWorldOffset_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddWorldOffset_FunctionAddress, "bTeleport");
		AddWorldOffset_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWorldOffset_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddWorldOffset_IsValid = AddWorldOffset_FunctionAddress != IntPtr.Zero && AddWorldOffset_DeltaLocation_IsValid && AddWorldOffset_bSweep_IsValid && AddWorldOffset_SweepHitResult_IsValid && AddWorldOffset_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddWorldOffset", AddWorldOffset_IsValid);
		AddRelativeRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddRelativeRotation");
		AddRelativeRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRelativeRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeRotation_DeltaRotation_PropertyAddress, AddRelativeRotation_FunctionAddress, "DeltaRotation");
		AddRelativeRotation_DeltaRotation_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeRotation_FunctionAddress, "DeltaRotation");
		AddRelativeRotation_DeltaRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeRotation_FunctionAddress, "DeltaRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeRotation_bSweep_PropertyAddress, AddRelativeRotation_FunctionAddress, "bSweep");
		AddRelativeRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeRotation_FunctionAddress, "bSweep");
		AddRelativeRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeRotation_SweepHitResult_PropertyAddress, AddRelativeRotation_FunctionAddress, "SweepHitResult");
		AddRelativeRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeRotation_FunctionAddress, "SweepHitResult");
		AddRelativeRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeRotation_bTeleport_PropertyAddress, AddRelativeRotation_FunctionAddress, "bTeleport");
		AddRelativeRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeRotation_FunctionAddress, "bTeleport");
		AddRelativeRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddRelativeRotation_IsValid = AddRelativeRotation_FunctionAddress != IntPtr.Zero && AddRelativeRotation_DeltaRotation_IsValid && AddRelativeRotation_bSweep_IsValid && AddRelativeRotation_SweepHitResult_IsValid && AddRelativeRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddRelativeRotation", AddRelativeRotation_IsValid);
		AddRelativeLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddRelativeLocation");
		AddRelativeLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRelativeLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeLocation_DeltaLocation_PropertyAddress, AddRelativeLocation_FunctionAddress, "DeltaLocation");
		AddRelativeLocation_DeltaLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeLocation_FunctionAddress, "DeltaLocation");
		AddRelativeLocation_DeltaLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeLocation_FunctionAddress, "DeltaLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeLocation_bSweep_PropertyAddress, AddRelativeLocation_FunctionAddress, "bSweep");
		AddRelativeLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeLocation_FunctionAddress, "bSweep");
		AddRelativeLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeLocation_SweepHitResult_PropertyAddress, AddRelativeLocation_FunctionAddress, "SweepHitResult");
		AddRelativeLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeLocation_FunctionAddress, "SweepHitResult");
		AddRelativeLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRelativeLocation_bTeleport_PropertyAddress, AddRelativeLocation_FunctionAddress, "bTeleport");
		AddRelativeLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddRelativeLocation_FunctionAddress, "bTeleport");
		AddRelativeLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRelativeLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddRelativeLocation_IsValid = AddRelativeLocation_FunctionAddress != IntPtr.Zero && AddRelativeLocation_DeltaLocation_IsValid && AddRelativeLocation_bSweep_IsValid && AddRelativeLocation_SweepHitResult_IsValid && AddRelativeLocation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddRelativeLocation", AddRelativeLocation_IsValid);
		AddLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddLocalTransform");
		AddLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocalTransform_DeltaTransform_PropertyAddress, AddLocalTransform_FunctionAddress, "DeltaTransform");
		AddLocalTransform_DeltaTransform_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalTransform_FunctionAddress, "DeltaTransform");
		AddLocalTransform_DeltaTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalTransform_FunctionAddress, "DeltaTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalTransform_bSweep_PropertyAddress, AddLocalTransform_FunctionAddress, "bSweep");
		AddLocalTransform_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalTransform_FunctionAddress, "bSweep");
		AddLocalTransform_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalTransform_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalTransform_SweepHitResult_PropertyAddress, AddLocalTransform_FunctionAddress, "SweepHitResult");
		AddLocalTransform_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalTransform_FunctionAddress, "SweepHitResult");
		AddLocalTransform_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalTransform_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalTransform_bTeleport_PropertyAddress, AddLocalTransform_FunctionAddress, "bTeleport");
		AddLocalTransform_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalTransform_FunctionAddress, "bTeleport");
		AddLocalTransform_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalTransform_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddLocalTransform_IsValid = AddLocalTransform_FunctionAddress != IntPtr.Zero && AddLocalTransform_DeltaTransform_IsValid && AddLocalTransform_bSweep_IsValid && AddLocalTransform_SweepHitResult_IsValid && AddLocalTransform_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddLocalTransform", AddLocalTransform_IsValid);
		AddLocalRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddLocalRotation");
		AddLocalRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocalRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocalRotation_DeltaRotation_PropertyAddress, AddLocalRotation_FunctionAddress, "DeltaRotation");
		AddLocalRotation_DeltaRotation_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalRotation_FunctionAddress, "DeltaRotation");
		AddLocalRotation_DeltaRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalRotation_FunctionAddress, "DeltaRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalRotation_bSweep_PropertyAddress, AddLocalRotation_FunctionAddress, "bSweep");
		AddLocalRotation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalRotation_FunctionAddress, "bSweep");
		AddLocalRotation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalRotation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalRotation_SweepHitResult_PropertyAddress, AddLocalRotation_FunctionAddress, "SweepHitResult");
		AddLocalRotation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalRotation_FunctionAddress, "SweepHitResult");
		AddLocalRotation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalRotation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalRotation_bTeleport_PropertyAddress, AddLocalRotation_FunctionAddress, "bTeleport");
		AddLocalRotation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalRotation_FunctionAddress, "bTeleport");
		AddLocalRotation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalRotation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddLocalRotation_IsValid = AddLocalRotation_FunctionAddress != IntPtr.Zero && AddLocalRotation_DeltaRotation_IsValid && AddLocalRotation_bSweep_IsValid && AddLocalRotation_SweepHitResult_IsValid && AddLocalRotation_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddLocalRotation", AddLocalRotation_IsValid);
		AddLocalOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_AddLocalOffset");
		AddLocalOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocalOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocalOffset_DeltaLocation_PropertyAddress, AddLocalOffset_FunctionAddress, "DeltaLocation");
		AddLocalOffset_DeltaLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalOffset_FunctionAddress, "DeltaLocation");
		AddLocalOffset_DeltaLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalOffset_FunctionAddress, "DeltaLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalOffset_bSweep_PropertyAddress, AddLocalOffset_FunctionAddress, "bSweep");
		AddLocalOffset_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalOffset_FunctionAddress, "bSweep");
		AddLocalOffset_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalOffset_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalOffset_SweepHitResult_PropertyAddress, AddLocalOffset_FunctionAddress, "SweepHitResult");
		AddLocalOffset_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalOffset_FunctionAddress, "SweepHitResult");
		AddLocalOffset_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalOffset_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalOffset_bTeleport_PropertyAddress, AddLocalOffset_FunctionAddress, "bTeleport");
		AddLocalOffset_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalOffset_FunctionAddress, "bTeleport");
		AddLocalOffset_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalOffset_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		AddLocalOffset_IsValid = AddLocalOffset_FunctionAddress != IntPtr.Zero && AddLocalOffset_DeltaLocation_IsValid && AddLocalOffset_bSweep_IsValid && AddLocalOffset_SweepHitResult_IsValid && AddLocalOffset_bTeleport_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:K2_AddLocalOffset", AddLocalOffset_IsValid);
		IsVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsVisible");
		IsVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVisible_ReturnValue_PropertyAddress, IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVisible_IsValid = IsVisible_FunctionAddress != IntPtr.Zero && IsVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:IsVisible", IsVisible_IsValid);
		IsSimulatingPhysics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSimulatingPhysics");
		IsSimulatingPhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSimulatingPhysics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSimulatingPhysics_BoneName_PropertyAddress, IsSimulatingPhysics_FunctionAddress, "BoneName");
		IsSimulatingPhysics_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(IsSimulatingPhysics_FunctionAddress, "BoneName");
		IsSimulatingPhysics_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSimulatingPhysics_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSimulatingPhysics_ReturnValue_PropertyAddress, IsSimulatingPhysics_FunctionAddress, "ReturnValue");
		IsSimulatingPhysics_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSimulatingPhysics_FunctionAddress, "ReturnValue");
		IsSimulatingPhysics_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSimulatingPhysics_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSimulatingPhysics_IsValid = IsSimulatingPhysics_FunctionAddress != IntPtr.Zero && IsSimulatingPhysics_BoneName_IsValid && IsSimulatingPhysics_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:IsSimulatingPhysics", IsSimulatingPhysics_IsValid);
		IsAnySimulatingPhysics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnySimulatingPhysics");
		IsAnySimulatingPhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnySimulatingPhysics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnySimulatingPhysics_ReturnValue_PropertyAddress, IsAnySimulatingPhysics_FunctionAddress, "ReturnValue");
		IsAnySimulatingPhysics_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnySimulatingPhysics_FunctionAddress, "ReturnValue");
		IsAnySimulatingPhysics_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnySimulatingPhysics_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnySimulatingPhysics_IsValid = IsAnySimulatingPhysics_FunctionAddress != IntPtr.Zero && IsAnySimulatingPhysics_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:IsAnySimulatingPhysics", IsAnySimulatingPhysics_IsValid);
		GetUpVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUpVector");
		GetUpVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUpVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUpVector_ReturnValue_PropertyAddress, GetUpVector_FunctionAddress, "ReturnValue");
		GetUpVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUpVector_FunctionAddress, "ReturnValue");
		GetUpVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUpVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUpVector_IsValid = GetUpVector_FunctionAddress != IntPtr.Zero && GetUpVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetUpVector", GetUpVector_IsValid);
		GetSocketTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketTransform");
		GetSocketTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_InSocketName_PropertyAddress, GetSocketTransform_FunctionAddress, "InSocketName");
		GetSocketTransform_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "InSocketName");
		GetSocketTransform_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_TransformSpace_PropertyAddress, GetSocketTransform_FunctionAddress, "TransformSpace");
		GetSocketTransform_TransformSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "TransformSpace");
		GetSocketTransform_TransformSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "TransformSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_ReturnValue_PropertyAddress, GetSocketTransform_FunctionAddress, "ReturnValue");
		GetSocketTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "ReturnValue");
		GetSocketTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketTransform_IsValid = GetSocketTransform_FunctionAddress != IntPtr.Zero && GetSocketTransform_InSocketName_IsValid && GetSocketTransform_TransformSpace_IsValid && GetSocketTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetSocketTransform", GetSocketTransform_IsValid);
		GetSocketRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketRotation");
		GetSocketRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketRotation_InSocketName_PropertyAddress, GetSocketRotation_FunctionAddress, "InSocketName");
		GetSocketRotation_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketRotation_FunctionAddress, "InSocketName");
		GetSocketRotation_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketRotation_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketRotation_ReturnValue_PropertyAddress, GetSocketRotation_FunctionAddress, "ReturnValue");
		GetSocketRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketRotation_FunctionAddress, "ReturnValue");
		GetSocketRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketRotation_IsValid = GetSocketRotation_FunctionAddress != IntPtr.Zero && GetSocketRotation_InSocketName_IsValid && GetSocketRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetSocketRotation", GetSocketRotation_IsValid);
		GetSocketLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketLocation");
		GetSocketLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_InSocketName_PropertyAddress, GetSocketLocation_FunctionAddress, "InSocketName");
		GetSocketLocation_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "InSocketName");
		GetSocketLocation_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_ReturnValue_PropertyAddress, GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketLocation_IsValid = GetSocketLocation_FunctionAddress != IntPtr.Zero && GetSocketLocation_InSocketName_IsValid && GetSocketLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetSocketLocation", GetSocketLocation_IsValid);
		GetShouldUpdatePhysicsVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetShouldUpdatePhysicsVolume");
		GetShouldUpdatePhysicsVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShouldUpdatePhysicsVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShouldUpdatePhysicsVolume_ReturnValue_PropertyAddress, GetShouldUpdatePhysicsVolume_FunctionAddress, "ReturnValue");
		GetShouldUpdatePhysicsVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShouldUpdatePhysicsVolume_FunctionAddress, "ReturnValue");
		GetShouldUpdatePhysicsVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShouldUpdatePhysicsVolume_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetShouldUpdatePhysicsVolume_IsValid = GetShouldUpdatePhysicsVolume_FunctionAddress != IntPtr.Zero && GetShouldUpdatePhysicsVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetShouldUpdatePhysicsVolume", GetShouldUpdatePhysicsVolume_IsValid);
		GetRightVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRightVector");
		GetRightVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRightVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRightVector_ReturnValue_PropertyAddress, GetRightVector_FunctionAddress, "ReturnValue");
		GetRightVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRightVector_FunctionAddress, "ReturnValue");
		GetRightVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRightVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRightVector_IsValid = GetRightVector_FunctionAddress != IntPtr.Zero && GetRightVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetRightVector", GetRightVector_IsValid);
		GetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRelativeTransform");
		GetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_ReturnValue_PropertyAddress, GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRelativeTransform_IsValid = GetRelativeTransform_FunctionAddress != IntPtr.Zero && GetRelativeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetRelativeTransform", GetRelativeTransform_IsValid);
		GetPhysicsVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsVolume");
		GetPhysicsVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsVolume_ReturnValue_PropertyAddress, GetPhysicsVolume_FunctionAddress, "ReturnValue");
		GetPhysicsVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsVolume_FunctionAddress, "ReturnValue");
		GetPhysicsVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsVolume_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicsVolume_IsValid = GetPhysicsVolume_FunctionAddress != IntPtr.Zero && GetPhysicsVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetPhysicsVolume", GetPhysicsVolume_IsValid);
		GetParentComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParentComponents");
		GetParentComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentComponents_Parents_PropertyAddress, GetParentComponents_FunctionAddress, "Parents");
		GetParentComponents_Parents_Offset = NativeReflectionCached.GetPropertyOffset(GetParentComponents_FunctionAddress, "Parents");
		GetParentComponents_Parents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentComponents_FunctionAddress, "Parents", Classes.FArrayProperty);
		GetParentComponents_IsValid = GetParentComponents_FunctionAddress != IntPtr.Zero && GetParentComponents_Parents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetParentComponents", GetParentComponents_IsValid);
		GetNumChildrenComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumChildrenComponents");
		GetNumChildrenComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumChildrenComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumChildrenComponents_ReturnValue_PropertyAddress, GetNumChildrenComponents_FunctionAddress, "ReturnValue");
		GetNumChildrenComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumChildrenComponents_FunctionAddress, "ReturnValue");
		GetNumChildrenComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumChildrenComponents_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumChildrenComponents_IsValid = GetNumChildrenComponents_FunctionAddress != IntPtr.Zero && GetNumChildrenComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetNumChildrenComponents", GetNumChildrenComponents_IsValid);
		GetForwardVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetForwardVector");
		GetForwardVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForwardVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForwardVector_ReturnValue_PropertyAddress, GetForwardVector_FunctionAddress, "ReturnValue");
		GetForwardVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForwardVector_FunctionAddress, "ReturnValue");
		GetForwardVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForwardVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetForwardVector_IsValid = GetForwardVector_FunctionAddress != IntPtr.Zero && GetForwardVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetForwardVector", GetForwardVector_IsValid);
		GetComponentVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetComponentVelocity");
		GetComponentVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponentVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponentVelocity_ReturnValue_PropertyAddress, GetComponentVelocity_FunctionAddress, "ReturnValue");
		GetComponentVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponentVelocity_FunctionAddress, "ReturnValue");
		GetComponentVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponentVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetComponentVelocity_IsValid = GetComponentVelocity_FunctionAddress != IntPtr.Zero && GetComponentVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetComponentVelocity", GetComponentVelocity_IsValid);
		GetChildrenComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetChildrenComponents");
		GetChildrenComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildrenComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildrenComponents_bIncludeAllDescendants_PropertyAddress, GetChildrenComponents_FunctionAddress, "bIncludeAllDescendants");
		GetChildrenComponents_bIncludeAllDescendants_Offset = NativeReflectionCached.GetPropertyOffset(GetChildrenComponents_FunctionAddress, "bIncludeAllDescendants");
		GetChildrenComponents_bIncludeAllDescendants_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildrenComponents_FunctionAddress, "bIncludeAllDescendants", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildrenComponents_Children_PropertyAddress, GetChildrenComponents_FunctionAddress, "Children");
		GetChildrenComponents_Children_Offset = NativeReflectionCached.GetPropertyOffset(GetChildrenComponents_FunctionAddress, "Children");
		GetChildrenComponents_Children_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildrenComponents_FunctionAddress, "Children", Classes.FArrayProperty);
		GetChildrenComponents_IsValid = GetChildrenComponents_FunctionAddress != IntPtr.Zero && GetChildrenComponents_bIncludeAllDescendants_IsValid && GetChildrenComponents_Children_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetChildrenComponents", GetChildrenComponents_IsValid);
		GetChildComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetChildComponent");
		GetChildComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildComponent_ChildIndex_PropertyAddress, GetChildComponent_FunctionAddress, "ChildIndex");
		GetChildComponent_ChildIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetChildComponent_FunctionAddress, "ChildIndex");
		GetChildComponent_ChildIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildComponent_FunctionAddress, "ChildIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildComponent_ReturnValue_PropertyAddress, GetChildComponent_FunctionAddress, "ReturnValue");
		GetChildComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildComponent_FunctionAddress, "ReturnValue");
		GetChildComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetChildComponent_IsValid = GetChildComponent_FunctionAddress != IntPtr.Zero && GetChildComponent_ChildIndex_IsValid && GetChildComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetChildComponent", GetChildComponent_IsValid);
		GetAttachSocketName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachSocketName");
		GetAttachSocketName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachSocketName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachSocketName_ReturnValue_PropertyAddress, GetAttachSocketName_FunctionAddress, "ReturnValue");
		GetAttachSocketName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachSocketName_FunctionAddress, "ReturnValue");
		GetAttachSocketName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachSocketName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetAttachSocketName_IsValid = GetAttachSocketName_FunctionAddress != IntPtr.Zero && GetAttachSocketName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetAttachSocketName", GetAttachSocketName_IsValid);
		GetAttachParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAttachParent");
		GetAttachParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttachParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttachParent_ReturnValue_PropertyAddress, GetAttachParent_FunctionAddress, "ReturnValue");
		GetAttachParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttachParent_FunctionAddress, "ReturnValue");
		GetAttachParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttachParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAttachParent_IsValid = GetAttachParent_FunctionAddress != IntPtr.Zero && GetAttachParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetAttachParent", GetAttachParent_IsValid);
		GetAllSocketNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllSocketNames");
		GetAllSocketNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSocketNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSocketNames_ReturnValue_PropertyAddress, GetAllSocketNames_FunctionAddress, "ReturnValue");
		GetAllSocketNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSocketNames_FunctionAddress, "ReturnValue");
		GetAllSocketNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSocketNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSocketNames_IsValid = GetAllSocketNames_FunctionAddress != IntPtr.Zero && GetAllSocketNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:GetAllSocketNames", GetAllSocketNames_IsValid);
		DoesSocketExist_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoesSocketExist");
		DoesSocketExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesSocketExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesSocketExist_InSocketName_PropertyAddress, DoesSocketExist_FunctionAddress, "InSocketName");
		DoesSocketExist_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(DoesSocketExist_FunctionAddress, "InSocketName");
		DoesSocketExist_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesSocketExist_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesSocketExist_ReturnValue_PropertyAddress, DoesSocketExist_FunctionAddress, "ReturnValue");
		DoesSocketExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesSocketExist_FunctionAddress, "ReturnValue");
		DoesSocketExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesSocketExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesSocketExist_IsValid = DoesSocketExist_FunctionAddress != IntPtr.Zero && DoesSocketExist_InSocketName_IsValid && DoesSocketExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:DoesSocketExist", DoesSocketExist_IsValid);
		DetachFromParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DetachFromParent");
		DetachFromParent_ParamsSize = NativeReflection.GetFunctionParamsSize(DetachFromParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetachFromParent_bMaintainWorldPosition_PropertyAddress, DetachFromParent_FunctionAddress, "bMaintainWorldPosition");
		DetachFromParent_bMaintainWorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromParent_FunctionAddress, "bMaintainWorldPosition");
		DetachFromParent_bMaintainWorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromParent_FunctionAddress, "bMaintainWorldPosition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DetachFromParent_bCallModify_PropertyAddress, DetachFromParent_FunctionAddress, "bCallModify");
		DetachFromParent_bCallModify_Offset = NativeReflectionCached.GetPropertyOffset(DetachFromParent_FunctionAddress, "bCallModify");
		DetachFromParent_bCallModify_IsValid = NativeReflectionCached.ValidatePropertyClass(DetachFromParent_FunctionAddress, "bCallModify", Classes.FBoolProperty);
		DetachFromParent_IsValid = DetachFromParent_FunctionAddress != IntPtr.Zero && DetachFromParent_bMaintainWorldPosition_IsValid && DetachFromParent_bCallModify_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SceneComponent:DetachFromParent", DetachFromParent_IsValid);
	}
}
