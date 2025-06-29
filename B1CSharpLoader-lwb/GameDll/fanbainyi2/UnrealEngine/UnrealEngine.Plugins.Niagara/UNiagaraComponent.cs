using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Niagara.NiagaraComponent", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraComponent : UFXSystemComponent
{
	private static bool AutoManageAttachment_IsValid;

	private static FFieldAddress AutoManageAttachment_PropertyAddress;

	private static int AutoManageAttachment_Offset;

	private static bool AutoAttachWeldSimulatedBodies_IsValid;

	private static FFieldAddress AutoAttachWeldSimulatedBodies_PropertyAddress;

	private static int AutoAttachWeldSimulatedBodies_Offset;

	private static bool OnSystemFinished_IsValid;

	private static int OnSystemFinished_Offset;

	private FOnNiagaraSystemFinished OnSystemFinished_DelegateCached;

	private static bool AutoAttachParent_IsValid;

	private static int AutoAttachParent_Offset;

	private static bool AutoAttachSocketName_IsValid;

	private static int AutoAttachSocketName_Offset;

	private static bool AutoAttachLocationRule_IsValid;

	private static FFieldAddress AutoAttachLocationRule_PropertyAddress;

	private static int AutoAttachLocationRule_Offset;

	private static bool AutoAttachRotationRule_IsValid;

	private static FFieldAddress AutoAttachRotationRule_PropertyAddress;

	private static int AutoAttachRotationRule_Offset;

	private static bool AutoAttachScaleRule_IsValid;

	private static FFieldAddress AutoAttachScaleRule_PropertyAddress;

	private static int AutoAttachScaleRule_Offset;

	private static bool RenderInTranslucencyUpscaledRTPass_IsValid;

	private static FFieldAddress RenderInTranslucencyUpscaledRTPass_PropertyAddress;

	private static int RenderInTranslucencyUpscaledRTPass_Offset;

	private static bool SetVariableVec4_IsValid;

	private static IntPtr SetVariableVec4_FunctionAddress;

	private static int SetVariableVec4_ParamsSize;

	private static bool SetVariableVec4_InVariableName_IsValid;

	private static FFieldAddress SetVariableVec4_InVariableName_PropertyAddress;

	private static int SetVariableVec4_InVariableName_Offset;

	private static bool SetVariableVec4_InValue_IsValid;

	private static FFieldAddress SetVariableVec4_InValue_PropertyAddress;

	private static int SetVariableVec4_InValue_Offset;

	private static bool SetVariableVec3_IsValid;

	private static IntPtr SetVariableVec3_FunctionAddress;

	private static int SetVariableVec3_ParamsSize;

	private static bool SetVariableVec3_InVariableName_IsValid;

	private static FFieldAddress SetVariableVec3_InVariableName_PropertyAddress;

	private static int SetVariableVec3_InVariableName_Offset;

	private static bool SetVariableVec3_InValue_IsValid;

	private static FFieldAddress SetVariableVec3_InValue_PropertyAddress;

	private static int SetVariableVec3_InValue_Offset;

	private static bool SetVariableVec2_IsValid;

	private static IntPtr SetVariableVec2_FunctionAddress;

	private static int SetVariableVec2_ParamsSize;

	private static bool SetVariableVec2_InVariableName_IsValid;

	private static FFieldAddress SetVariableVec2_InVariableName_PropertyAddress;

	private static int SetVariableVec2_InVariableName_Offset;

	private static bool SetVariableVec2_InValue_IsValid;

	private static FFieldAddress SetVariableVec2_InValue_PropertyAddress;

	private static int SetVariableVec2_InValue_Offset;

	private static bool SetVariableTextureRenderTarget_IsValid;

	private static IntPtr SetVariableTextureRenderTarget_FunctionAddress;

	private static int SetVariableTextureRenderTarget_ParamsSize;

	private static bool SetVariableTextureRenderTarget_InVariableName_IsValid;

	private static FFieldAddress SetVariableTextureRenderTarget_InVariableName_PropertyAddress;

	private static int SetVariableTextureRenderTarget_InVariableName_Offset;

	private static bool SetVariableTextureRenderTarget_TextureRenderTarget_IsValid;

	private static FFieldAddress SetVariableTextureRenderTarget_TextureRenderTarget_PropertyAddress;

	private static int SetVariableTextureRenderTarget_TextureRenderTarget_Offset;

	private static bool SetVariableTexture_IsValid;

	private static IntPtr SetVariableTexture_FunctionAddress;

	private static int SetVariableTexture_ParamsSize;

	private static bool SetVariableTexture_InVariableName_IsValid;

	private static FFieldAddress SetVariableTexture_InVariableName_PropertyAddress;

	private static int SetVariableTexture_InVariableName_Offset;

	private static bool SetVariableTexture_Texture_IsValid;

	private static FFieldAddress SetVariableTexture_Texture_PropertyAddress;

	private static int SetVariableTexture_Texture_Offset;

	private static bool SetVariableStaticMesh_IsValid;

	private static IntPtr SetVariableStaticMesh_FunctionAddress;

	private static int SetVariableStaticMesh_ParamsSize;

	private static bool SetVariableStaticMesh_InVariableName_IsValid;

	private static FFieldAddress SetVariableStaticMesh_InVariableName_PropertyAddress;

	private static int SetVariableStaticMesh_InVariableName_Offset;

	private static bool SetVariableStaticMesh_InValue_IsValid;

	private static FFieldAddress SetVariableStaticMesh_InValue_PropertyAddress;

	private static int SetVariableStaticMesh_InValue_Offset;

	private static bool SetVariableQuat_IsValid;

	private static IntPtr SetVariableQuat_FunctionAddress;

	private static int SetVariableQuat_ParamsSize;

	private static bool SetVariableQuat_InVariableName_IsValid;

	private static FFieldAddress SetVariableQuat_InVariableName_PropertyAddress;

	private static int SetVariableQuat_InVariableName_Offset;

	private static bool SetVariableQuat_InValue_IsValid;

	private static FFieldAddress SetVariableQuat_InValue_PropertyAddress;

	private static int SetVariableQuat_InValue_Offset;

	private static bool SetVariablePosition_IsValid;

	private static IntPtr SetVariablePosition_FunctionAddress;

	private static int SetVariablePosition_ParamsSize;

	private static bool SetVariablePosition_InVariableName_IsValid;

	private static FFieldAddress SetVariablePosition_InVariableName_PropertyAddress;

	private static int SetVariablePosition_InVariableName_Offset;

	private static bool SetVariablePosition_InValue_IsValid;

	private static FFieldAddress SetVariablePosition_InValue_PropertyAddress;

	private static int SetVariablePosition_InValue_Offset;

	private static bool SetVariableObject_IsValid;

	private static IntPtr SetVariableObject_FunctionAddress;

	private static int SetVariableObject_ParamsSize;

	private static bool SetVariableObject_InVariableName_IsValid;

	private static FFieldAddress SetVariableObject_InVariableName_PropertyAddress;

	private static int SetVariableObject_InVariableName_Offset;

	private static bool SetVariableObject_Object_IsValid;

	private static FFieldAddress SetVariableObject_Object_PropertyAddress;

	private static int SetVariableObject_Object_Offset;

	private static bool SetVariableMaterial_IsValid;

	private static IntPtr SetVariableMaterial_FunctionAddress;

	private static int SetVariableMaterial_ParamsSize;

	private static bool SetVariableMaterial_InVariableName_IsValid;

	private static FFieldAddress SetVariableMaterial_InVariableName_PropertyAddress;

	private static int SetVariableMaterial_InVariableName_Offset;

	private static bool SetVariableMaterial_Object_IsValid;

	private static FFieldAddress SetVariableMaterial_Object_PropertyAddress;

	private static int SetVariableMaterial_Object_Offset;

	private static bool SetVariableLinearColor_IsValid;

	private static IntPtr SetVariableLinearColor_FunctionAddress;

	private static int SetVariableLinearColor_ParamsSize;

	private static bool SetVariableLinearColor_InVariableName_IsValid;

	private static FFieldAddress SetVariableLinearColor_InVariableName_PropertyAddress;

	private static int SetVariableLinearColor_InVariableName_Offset;

	private static bool SetVariableLinearColor_InValue_IsValid;

	private static FFieldAddress SetVariableLinearColor_InValue_PropertyAddress;

	private static int SetVariableLinearColor_InValue_Offset;

	private static bool SetVariableInt_IsValid;

	private static IntPtr SetVariableInt_FunctionAddress;

	private static int SetVariableInt_ParamsSize;

	private static bool SetVariableInt_InVariableName_IsValid;

	private static FFieldAddress SetVariableInt_InVariableName_PropertyAddress;

	private static int SetVariableInt_InVariableName_Offset;

	private static bool SetVariableInt_InValue_IsValid;

	private static FFieldAddress SetVariableInt_InValue_PropertyAddress;

	private static int SetVariableInt_InValue_Offset;

	private static bool SetVariableFloat_IsValid;

	private static IntPtr SetVariableFloat_FunctionAddress;

	private static int SetVariableFloat_ParamsSize;

	private static bool SetVariableFloat_InVariableName_IsValid;

	private static FFieldAddress SetVariableFloat_InVariableName_PropertyAddress;

	private static int SetVariableFloat_InVariableName_Offset;

	private static bool SetVariableFloat_InValue_IsValid;

	private static FFieldAddress SetVariableFloat_InValue_PropertyAddress;

	private static int SetVariableFloat_InValue_Offset;

	private static bool SetVariableBool_IsValid;

	private static IntPtr SetVariableBool_FunctionAddress;

	private static int SetVariableBool_ParamsSize;

	private static bool SetVariableBool_InVariableName_IsValid;

	private static FFieldAddress SetVariableBool_InVariableName_PropertyAddress;

	private static int SetVariableBool_InVariableName_Offset;

	private static bool SetVariableBool_InValue_IsValid;

	private static FFieldAddress SetVariableBool_InValue_PropertyAddress;

	private static int SetVariableBool_InValue_Offset;

	private static bool SetVariableActor_IsValid;

	private static IntPtr SetVariableActor_FunctionAddress;

	private static int SetVariableActor_ParamsSize;

	private static bool SetVariableActor_InVariableName_IsValid;

	private static FFieldAddress SetVariableActor_InVariableName_PropertyAddress;

	private static int SetVariableActor_InVariableName_Offset;

	private static bool SetVariableActor_Actor_IsValid;

	private static FFieldAddress SetVariableActor_Actor_PropertyAddress;

	private static int SetVariableActor_Actor_Offset;

	private static bool SetTickBehavior_IsValid;

	private static IntPtr SetTickBehavior_FunctionAddress;

	private static int SetTickBehavior_ParamsSize;

	private static bool SetTickBehavior_NewTickBehavior_IsValid;

	private static FFieldAddress SetTickBehavior_NewTickBehavior_PropertyAddress;

	private static int SetTickBehavior_NewTickBehavior_Offset;

	private static bool SetSystemFixedBounds_IsValid;

	private static IntPtr SetSystemFixedBounds_FunctionAddress;

	private static int SetSystemFixedBounds_ParamsSize;

	private static bool SetSystemFixedBounds_LocalBounds_IsValid;

	private static FFieldAddress SetSystemFixedBounds_LocalBounds_PropertyAddress;

	private static int SetSystemFixedBounds_LocalBounds_Offset;

	private static bool SetSeekDelta_IsValid;

	private static IntPtr SetSeekDelta_FunctionAddress;

	private static int SetSeekDelta_ParamsSize;

	private static bool SetSeekDelta_InSeekDelta_IsValid;

	private static FFieldAddress SetSeekDelta_InSeekDelta_PropertyAddress;

	private static int SetSeekDelta_InSeekDelta_Offset;

	private static bool SetRenderingEnabled_IsValid;

	private static IntPtr SetRenderingEnabled_FunctionAddress;

	private static int SetRenderingEnabled_ParamsSize;

	private static bool SetRenderingEnabled_bInRenderingEnabled_IsValid;

	private static FFieldAddress SetRenderingEnabled_bInRenderingEnabled_PropertyAddress;

	private static int SetRenderingEnabled_bInRenderingEnabled_Offset;

	private static bool SetRandomSeedOffset_IsValid;

	private static IntPtr SetRandomSeedOffset_FunctionAddress;

	private static int SetRandomSeedOffset_ParamsSize;

	private static bool SetRandomSeedOffset_NewRandomSeedOffset_IsValid;

	private static FFieldAddress SetRandomSeedOffset_NewRandomSeedOffset_PropertyAddress;

	private static int SetRandomSeedOffset_NewRandomSeedOffset_Offset;

	private static bool SetPreviewLODDistance_IsValid;

	private static IntPtr SetPreviewLODDistance_FunctionAddress;

	private static int SetPreviewLODDistance_ParamsSize;

	private static bool SetPreviewLODDistance_bEnablePreviewLODDistance_IsValid;

	private static FFieldAddress SetPreviewLODDistance_bEnablePreviewLODDistance_PropertyAddress;

	private static int SetPreviewLODDistance_bEnablePreviewLODDistance_Offset;

	private static bool SetPreviewLODDistance_PreviewLODDistance_IsValid;

	private static FFieldAddress SetPreviewLODDistance_PreviewLODDistance_PropertyAddress;

	private static int SetPreviewLODDistance_PreviewLODDistance_Offset;

	private static bool SetPreviewLODDistance_PreviewMaxDistance_IsValid;

	private static FFieldAddress SetPreviewLODDistance_PreviewMaxDistance_PropertyAddress;

	private static int SetPreviewLODDistance_PreviewMaxDistance_Offset;

	private static bool SetPaused_IsValid;

	private static IntPtr SetPaused_FunctionAddress;

	private static int SetPaused_ParamsSize;

	private static bool SetPaused_bInPaused_IsValid;

	private static FFieldAddress SetPaused_bInPaused_PropertyAddress;

	private static int SetPaused_bInPaused_Offset;

	private static bool SetNiagaraVariableVec4_IsValid;

	private static IntPtr SetNiagaraVariableVec4_FunctionAddress;

	private static int SetNiagaraVariableVec4_ParamsSize;

	private static bool SetNiagaraVariableVec4_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableVec4_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableVec4_InVariableName_Offset;

	private static bool SetNiagaraVariableVec4_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableVec4_InValue_PropertyAddress;

	private static int SetNiagaraVariableVec4_InValue_Offset;

	private static bool SetNiagaraVariableVec3_IsValid;

	private static IntPtr SetNiagaraVariableVec3_FunctionAddress;

	private static int SetNiagaraVariableVec3_ParamsSize;

	private static bool SetNiagaraVariableVec3_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableVec3_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableVec3_InVariableName_Offset;

	private static bool SetNiagaraVariableVec3_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableVec3_InValue_PropertyAddress;

	private static int SetNiagaraVariableVec3_InValue_Offset;

	private static bool SetNiagaraVariableVec2_IsValid;

	private static IntPtr SetNiagaraVariableVec2_FunctionAddress;

	private static int SetNiagaraVariableVec2_ParamsSize;

	private static bool SetNiagaraVariableVec2_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableVec2_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableVec2_InVariableName_Offset;

	private static bool SetNiagaraVariableVec2_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableVec2_InValue_PropertyAddress;

	private static int SetNiagaraVariableVec2_InValue_Offset;

	private static bool SetNiagaraVariableQuat_IsValid;

	private static IntPtr SetNiagaraVariableQuat_FunctionAddress;

	private static int SetNiagaraVariableQuat_ParamsSize;

	private static bool SetNiagaraVariableQuat_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableQuat_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableQuat_InVariableName_Offset;

	private static bool SetNiagaraVariableQuat_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableQuat_InValue_PropertyAddress;

	private static int SetNiagaraVariableQuat_InValue_Offset;

	private static bool SetNiagaraVariablePosition_IsValid;

	private static IntPtr SetNiagaraVariablePosition_FunctionAddress;

	private static int SetNiagaraVariablePosition_ParamsSize;

	private static bool SetNiagaraVariablePosition_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariablePosition_InVariableName_PropertyAddress;

	private static int SetNiagaraVariablePosition_InVariableName_Offset;

	private static bool SetNiagaraVariablePosition_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariablePosition_InValue_PropertyAddress;

	private static int SetNiagaraVariablePosition_InValue_Offset;

	private static bool SetNiagaraVariableObject_IsValid;

	private static IntPtr SetNiagaraVariableObject_FunctionAddress;

	private static int SetNiagaraVariableObject_ParamsSize;

	private static bool SetNiagaraVariableObject_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableObject_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableObject_InVariableName_Offset;

	private static bool SetNiagaraVariableObject_Object_IsValid;

	private static FFieldAddress SetNiagaraVariableObject_Object_PropertyAddress;

	private static int SetNiagaraVariableObject_Object_Offset;

	private static bool SetNiagaraVariableLinearColor_IsValid;

	private static IntPtr SetNiagaraVariableLinearColor_FunctionAddress;

	private static int SetNiagaraVariableLinearColor_ParamsSize;

	private static bool SetNiagaraVariableLinearColor_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableLinearColor_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableLinearColor_InVariableName_Offset;

	private static bool SetNiagaraVariableLinearColor_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableLinearColor_InValue_PropertyAddress;

	private static int SetNiagaraVariableLinearColor_InValue_Offset;

	private static bool SetNiagaraVariableInt_IsValid;

	private static IntPtr SetNiagaraVariableInt_FunctionAddress;

	private static int SetNiagaraVariableInt_ParamsSize;

	private static bool SetNiagaraVariableInt_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableInt_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableInt_InVariableName_Offset;

	private static bool SetNiagaraVariableInt_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableInt_InValue_PropertyAddress;

	private static int SetNiagaraVariableInt_InValue_Offset;

	private static bool SetNiagaraVariableFloat_IsValid;

	private static IntPtr SetNiagaraVariableFloat_FunctionAddress;

	private static int SetNiagaraVariableFloat_ParamsSize;

	private static bool SetNiagaraVariableFloat_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableFloat_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableFloat_InVariableName_Offset;

	private static bool SetNiagaraVariableFloat_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableFloat_InValue_PropertyAddress;

	private static int SetNiagaraVariableFloat_InValue_Offset;

	private static bool SetNiagaraVariableBool_IsValid;

	private static IntPtr SetNiagaraVariableBool_FunctionAddress;

	private static int SetNiagaraVariableBool_ParamsSize;

	private static bool SetNiagaraVariableBool_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableBool_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableBool_InVariableName_Offset;

	private static bool SetNiagaraVariableBool_InValue_IsValid;

	private static FFieldAddress SetNiagaraVariableBool_InValue_PropertyAddress;

	private static int SetNiagaraVariableBool_InValue_Offset;

	private static bool SetNiagaraVariableActor_IsValid;

	private static IntPtr SetNiagaraVariableActor_FunctionAddress;

	private static int SetNiagaraVariableActor_ParamsSize;

	private static bool SetNiagaraVariableActor_InVariableName_IsValid;

	private static FFieldAddress SetNiagaraVariableActor_InVariableName_PropertyAddress;

	private static int SetNiagaraVariableActor_InVariableName_Offset;

	private static bool SetNiagaraVariableActor_Actor_IsValid;

	private static FFieldAddress SetNiagaraVariableActor_Actor_PropertyAddress;

	private static int SetNiagaraVariableActor_Actor_Offset;

	private static bool SetMaxSimTime_IsValid;

	private static IntPtr SetMaxSimTime_FunctionAddress;

	private static int SetMaxSimTime_ParamsSize;

	private static bool SetMaxSimTime_InMaxTime_IsValid;

	private static FFieldAddress SetMaxSimTime_InMaxTime_PropertyAddress;

	private static int SetMaxSimTime_InMaxTime_Offset;

	private static bool SetLockDesiredAgeDeltaTimeToSeekDelta_IsValid;

	private static IntPtr SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress;

	private static int SetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize;

	private static bool SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_IsValid;

	private static FFieldAddress SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_PropertyAddress;

	private static int SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_Offset;

	private static bool SetGpuComputeDebug_IsValid;

	private static IntPtr SetGpuComputeDebug_FunctionAddress;

	private static int SetGpuComputeDebug_ParamsSize;

	private static bool SetGpuComputeDebug_bEnableDebug_IsValid;

	private static FFieldAddress SetGpuComputeDebug_bEnableDebug_PropertyAddress;

	private static int SetGpuComputeDebug_bEnableDebug_Offset;

	private static bool SetForceSolo_IsValid;

	private static IntPtr SetForceSolo_FunctionAddress;

	private static int SetForceSolo_ParamsSize;

	private static bool SetForceSolo_bInForceSolo_IsValid;

	private static FFieldAddress SetForceSolo_bInForceSolo_PropertyAddress;

	private static int SetForceSolo_bInForceSolo_Offset;

	private static bool SetForceLocalPlayerEffect_IsValid;

	private static IntPtr SetForceLocalPlayerEffect_FunctionAddress;

	private static int SetForceLocalPlayerEffect_ParamsSize;

	private static bool SetForceLocalPlayerEffect_bIsPlayerEffect_IsValid;

	private static FFieldAddress SetForceLocalPlayerEffect_bIsPlayerEffect_PropertyAddress;

	private static int SetForceLocalPlayerEffect_bIsPlayerEffect_Offset;

	private static bool SetEmitterFixedBounds_IsValid;

	private static IntPtr SetEmitterFixedBounds_FunctionAddress;

	private static int SetEmitterFixedBounds_ParamsSize;

	private static bool SetEmitterFixedBounds_EmitterName_IsValid;

	private static FFieldAddress SetEmitterFixedBounds_EmitterName_PropertyAddress;

	private static int SetEmitterFixedBounds_EmitterName_Offset;

	private static bool SetEmitterFixedBounds_LocalBounds_IsValid;

	private static FFieldAddress SetEmitterFixedBounds_LocalBounds_PropertyAddress;

	private static int SetEmitterFixedBounds_LocalBounds_Offset;

	private static bool SetDesiredAge_IsValid;

	private static IntPtr SetDesiredAge_FunctionAddress;

	private static int SetDesiredAge_ParamsSize;

	private static bool SetDesiredAge_InDesiredAge_IsValid;

	private static FFieldAddress SetDesiredAge_InDesiredAge_PropertyAddress;

	private static int SetDesiredAge_InDesiredAge_Offset;

	private static bool SetCustomTimeDilation_IsValid;

	private static IntPtr SetCustomTimeDilation_FunctionAddress;

	private static int SetCustomTimeDilation_ParamsSize;

	private static bool SetCustomTimeDilation_Dilation_IsValid;

	private static FFieldAddress SetCustomTimeDilation_Dilation_PropertyAddress;

	private static int SetCustomTimeDilation_Dilation_Offset;

	private static bool SetCanRenderWhileSeeking_IsValid;

	private static IntPtr SetCanRenderWhileSeeking_FunctionAddress;

	private static int SetCanRenderWhileSeeking_ParamsSize;

	private static bool SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_IsValid;

	private static FFieldAddress SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_PropertyAddress;

	private static int SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_Offset;

	private static bool SetAutoDestroy_IsValid;

	private static IntPtr SetAutoDestroy_FunctionAddress;

	private static int SetAutoDestroy_ParamsSize;

	private static bool SetAutoDestroy_bInAutoDestroy_IsValid;

	private static FFieldAddress SetAutoDestroy_bInAutoDestroy_PropertyAddress;

	private static int SetAutoDestroy_bInAutoDestroy_Offset;

	private static bool SetAsset_IsValid;

	private static IntPtr SetAsset_FunctionAddress;

	private static int SetAsset_ParamsSize;

	private static bool SetAsset_InAsset_IsValid;

	private static FFieldAddress SetAsset_InAsset_PropertyAddress;

	private static int SetAsset_InAsset_Offset;

	private static bool SetAsset_bResetExistingOverrideParameters_IsValid;

	private static FFieldAddress SetAsset_bResetExistingOverrideParameters_PropertyAddress;

	private static int SetAsset_bResetExistingOverrideParameters_Offset;

	private static bool SetAllowScalability_IsValid;

	private static IntPtr SetAllowScalability_FunctionAddress;

	private static int SetAllowScalability_ParamsSize;

	private static bool SetAllowScalability_bAllow_IsValid;

	private static FFieldAddress SetAllowScalability_bAllow_PropertyAddress;

	private static int SetAllowScalability_bAllow_Offset;

	private static bool SetAgeUpdateMode_IsValid;

	private static IntPtr SetAgeUpdateMode_FunctionAddress;

	private static int SetAgeUpdateMode_ParamsSize;

	private static bool SetAgeUpdateMode_InAgeUpdateMode_IsValid;

	private static FFieldAddress SetAgeUpdateMode_InAgeUpdateMode_PropertyAddress;

	private static int SetAgeUpdateMode_InAgeUpdateMode_Offset;

	private static bool SeekToDesiredAge_IsValid;

	private static IntPtr SeekToDesiredAge_FunctionAddress;

	private static int SeekToDesiredAge_ParamsSize;

	private static bool SeekToDesiredAge_InDesiredAge_IsValid;

	private static FFieldAddress SeekToDesiredAge_InDesiredAge_PropertyAddress;

	private static int SeekToDesiredAge_InDesiredAge_Offset;

	private static bool ResetSystem_IsValid;

	private static IntPtr ResetSystem_FunctionAddress;

	private static int ResetSystem_ParamsSize;

	private static bool ReinitializeSystem_IsValid;

	private static IntPtr ReinitializeSystem_FunctionAddress;

	private static int ReinitializeSystem_ParamsSize;

	private static bool IsPaused_IsValid;

	private static IntPtr IsPaused_FunctionAddress;

	private static int IsPaused_ParamsSize;

	private static bool IsPaused_ReturnValue_IsValid;

	private static FFieldAddress IsPaused_ReturnValue_PropertyAddress;

	private static int IsPaused_ReturnValue_Offset;

	private static bool InitForPerformanceBaseline_IsValid;

	private static IntPtr InitForPerformanceBaseline_FunctionAddress;

	private static int InitForPerformanceBaseline_ParamsSize;

	private static bool GetTickBehavior_IsValid;

	private static IntPtr GetTickBehavior_FunctionAddress;

	private static int GetTickBehavior_ParamsSize;

	private static bool GetTickBehavior_ReturnValue_IsValid;

	private static FFieldAddress GetTickBehavior_ReturnValue_PropertyAddress;

	private static int GetTickBehavior_ReturnValue_Offset;

	private static bool GetSystemFixedBounds_IsValid;

	private static IntPtr GetSystemFixedBounds_FunctionAddress;

	private static int GetSystemFixedBounds_ParamsSize;

	private static bool GetSystemFixedBounds_ReturnValue_IsValid;

	private static FFieldAddress GetSystemFixedBounds_ReturnValue_PropertyAddress;

	private static int GetSystemFixedBounds_ReturnValue_Offset;

	private static bool GetSeekDelta_IsValid;

	private static IntPtr GetSeekDelta_FunctionAddress;

	private static int GetSeekDelta_ParamsSize;

	private static bool GetSeekDelta_ReturnValue_IsValid;

	private static FFieldAddress GetSeekDelta_ReturnValue_PropertyAddress;

	private static int GetSeekDelta_ReturnValue_Offset;

	private static bool GetRandomSeedOffset_IsValid;

	private static IntPtr GetRandomSeedOffset_FunctionAddress;

	private static int GetRandomSeedOffset_ParamsSize;

	private static bool GetRandomSeedOffset_ReturnValue_IsValid;

	private static FFieldAddress GetRandomSeedOffset_ReturnValue_PropertyAddress;

	private static int GetRandomSeedOffset_ReturnValue_Offset;

	private static bool GetPreviewLODDistanceEnabled_IsValid;

	private static IntPtr GetPreviewLODDistanceEnabled_FunctionAddress;

	private static int GetPreviewLODDistanceEnabled_ParamsSize;

	private static bool GetPreviewLODDistanceEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewLODDistanceEnabled_ReturnValue_PropertyAddress;

	private static int GetPreviewLODDistanceEnabled_ReturnValue_Offset;

	private static bool GetPreviewLODDistance_IsValid;

	private static IntPtr GetPreviewLODDistance_FunctionAddress;

	private static int GetPreviewLODDistance_ParamsSize;

	private static bool GetPreviewLODDistance_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewLODDistance_ReturnValue_PropertyAddress;

	private static int GetPreviewLODDistance_ReturnValue_Offset;

	private static bool GetMaxSimTime_IsValid;

	private static IntPtr GetMaxSimTime_FunctionAddress;

	private static int GetMaxSimTime_ParamsSize;

	private static bool GetMaxSimTime_ReturnValue_IsValid;

	private static FFieldAddress GetMaxSimTime_ReturnValue_PropertyAddress;

	private static int GetMaxSimTime_ReturnValue_Offset;

	private static bool GetLockDesiredAgeDeltaTimeToSeekDelta_IsValid;

	private static IntPtr GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress;

	private static int GetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize;

	private static bool GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_IsValid;

	private static FFieldAddress GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_PropertyAddress;

	private static int GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_Offset;

	private static bool GetForceSolo_IsValid;

	private static IntPtr GetForceSolo_FunctionAddress;

	private static int GetForceSolo_ParamsSize;

	private static bool GetForceSolo_ReturnValue_IsValid;

	private static FFieldAddress GetForceSolo_ReturnValue_PropertyAddress;

	private static int GetForceSolo_ReturnValue_Offset;

	private static bool GetForceLocalPlayerEffect_IsValid;

	private static IntPtr GetForceLocalPlayerEffect_FunctionAddress;

	private static int GetForceLocalPlayerEffect_ParamsSize;

	private static bool GetForceLocalPlayerEffect_ReturnValue_IsValid;

	private static FFieldAddress GetForceLocalPlayerEffect_ReturnValue_PropertyAddress;

	private static int GetForceLocalPlayerEffect_ReturnValue_Offset;

	private static bool GetEmitterFixedBounds_IsValid;

	private static IntPtr GetEmitterFixedBounds_FunctionAddress;

	private static int GetEmitterFixedBounds_ParamsSize;

	private static bool GetEmitterFixedBounds_EmitterName_IsValid;

	private static FFieldAddress GetEmitterFixedBounds_EmitterName_PropertyAddress;

	private static int GetEmitterFixedBounds_EmitterName_Offset;

	private static bool GetEmitterFixedBounds_ReturnValue_IsValid;

	private static FFieldAddress GetEmitterFixedBounds_ReturnValue_PropertyAddress;

	private static int GetEmitterFixedBounds_ReturnValue_Offset;

	private static bool GetDesiredAge_IsValid;

	private static IntPtr GetDesiredAge_FunctionAddress;

	private static int GetDesiredAge_ParamsSize;

	private static bool GetDesiredAge_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredAge_ReturnValue_PropertyAddress;

	private static int GetDesiredAge_ReturnValue_Offset;

	private static bool GetDataInterface_IsValid;

	private static IntPtr GetDataInterface_FunctionAddress;

	private static int GetDataInterface_ParamsSize;

	private static bool GetDataInterface_Name_IsValid;

	private static FFieldAddress GetDataInterface_Name_PropertyAddress;

	private static int GetDataInterface_Name_Offset;

	private static bool GetDataInterface_ReturnValue_IsValid;

	private static FFieldAddress GetDataInterface_ReturnValue_PropertyAddress;

	private static int GetDataInterface_ReturnValue_Offset;

	private static bool GetCustomTimeDilation_IsValid;

	private static IntPtr GetCustomTimeDilation_FunctionAddress;

	private static int GetCustomTimeDilation_ParamsSize;

	private static bool GetCustomTimeDilation_ReturnValue_IsValid;

	private static FFieldAddress GetCustomTimeDilation_ReturnValue_PropertyAddress;

	private static int GetCustomTimeDilation_ReturnValue_Offset;

	private static bool GetAsset_IsValid;

	private static IntPtr GetAsset_FunctionAddress;

	private static int GetAsset_ParamsSize;

	private static bool GetAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAsset_ReturnValue_PropertyAddress;

	private static int GetAsset_ReturnValue_Offset;

	private static bool GetAllowScalability_IsValid;

	private static IntPtr GetAllowScalability_FunctionAddress;

	private static int GetAllowScalability_ParamsSize;

	private static bool GetAllowScalability_ReturnValue_IsValid;

	private static FFieldAddress GetAllowScalability_ReturnValue_PropertyAddress;

	private static int GetAllowScalability_ReturnValue_Offset;

	private static bool GetAgeUpdateMode_IsValid;

	private static IntPtr GetAgeUpdateMode_FunctionAddress;

	private static int GetAgeUpdateMode_ParamsSize;

	private static bool GetAgeUpdateMode_ReturnValue_IsValid;

	private static FFieldAddress GetAgeUpdateMode_ReturnValue_PropertyAddress;

	private static int GetAgeUpdateMode_ReturnValue_Offset;

	private static bool ClearSystemFixedBounds_IsValid;

	private static IntPtr ClearSystemFixedBounds_FunctionAddress;

	private static int ClearSystemFixedBounds_ParamsSize;

	private static bool ClearEmitterFixedBounds_IsValid;

	private static IntPtr ClearEmitterFixedBounds_FunctionAddress;

	private static int ClearEmitterFixedBounds_ParamsSize;

	private static bool ClearEmitterFixedBounds_EmitterName_IsValid;

	private static FFieldAddress ClearEmitterFixedBounds_EmitterName_PropertyAddress;

	private static int ClearEmitterFixedBounds_EmitterName_Offset;

	private static bool AdvanceSimulationByTime_IsValid;

	private static IntPtr AdvanceSimulationByTime_FunctionAddress;

	private static int AdvanceSimulationByTime_ParamsSize;

	private static bool AdvanceSimulationByTime_SimulateTime_IsValid;

	private static FFieldAddress AdvanceSimulationByTime_SimulateTime_PropertyAddress;

	private static int AdvanceSimulationByTime_SimulateTime_Offset;

	private static bool AdvanceSimulationByTime_TickDeltaSeconds_IsValid;

	private static FFieldAddress AdvanceSimulationByTime_TickDeltaSeconds_PropertyAddress;

	private static int AdvanceSimulationByTime_TickDeltaSeconds_Offset;

	private static bool AdvanceSimulation_IsValid;

	private static IntPtr AdvanceSimulation_FunctionAddress;

	private static int AdvanceSimulation_ParamsSize;

	private static bool AdvanceSimulation_TickCount_IsValid;

	private static FFieldAddress AdvanceSimulation_TickCount_PropertyAddress;

	private static int AdvanceSimulation_TickCount_Offset;

	private static bool AdvanceSimulation_TickDeltaSeconds_IsValid;

	private static FFieldAddress AdvanceSimulation_TickDeltaSeconds_PropertyAddress;

	private static int AdvanceSimulation_TickDeltaSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:bAutoManageAttachment")]
	public bool AutoManageAttachment
	{
		get
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bAutoManageAttachment");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bAutoManageAttachment");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:bAutoAttachWeldSimulatedBodies")]
	public bool AutoAttachWeldSimulatedBodies
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachWeldSimulatedBodies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bAutoAttachWeldSimulatedBodies");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoAttachWeldSimulatedBodies_Offset), 0, AutoAttachWeldSimulatedBodies_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachWeldSimulatedBodies_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bAutoAttachWeldSimulatedBodies");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoAttachWeldSimulatedBodies_Offset), 0, AutoAttachWeldSimulatedBodies_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:OnSystemFinished")]
	public FOnNiagaraSystemFinished OnSystemFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnSystemFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:OnSystemFinished");
				return new FOnNiagaraSystemFinished();
			}
			if (OnSystemFinished_DelegateCached == null)
			{
				OnSystemFinished_DelegateCached = new FOnNiagaraSystemFinished();
				OnSystemFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSystemFinished_Offset));
			}
			return OnSystemFinished_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)7881369141774861uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AutoAttachParent")]
	public TWeakObject<USceneComponent> AutoAttachParent
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachParent");
				return default(TWeakObject<USceneComponent>);
			}
			return TWeakObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, AutoAttachParent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachParent");
			}
			else
			{
				TWeakObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, AutoAttachParent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AutoAttachSocketName")]
	public FName AutoAttachSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AutoAttachLocationRule")]
	public EAttachmentRule AutoAttachLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AutoAttachRotationRule")]
	public EAttachmentRule AutoAttachRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AutoAttachScaleRule")]
	public EAttachmentRule AutoAttachScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:AutoAttachScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:bRenderInTranslucencyUpscaledRTPass")]
	public bool RenderInTranslucencyUpscaledRTPass
	{
		get
		{
			CheckDestroyed();
			if (!RenderInTranslucencyUpscaledRTPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bRenderInTranslucencyUpscaledRTPass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderInTranslucencyUpscaledRTPass_Offset), 0, RenderInTranslucencyUpscaledRTPass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderInTranslucencyUpscaledRTPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Niagara.NiagaraComponent:bRenderInTranslucencyUpscaledRTPass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderInTranslucencyUpscaledRTPass_Offset), 0, RenderInTranslucencyUpscaledRTPass_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableVec4")]
	public unsafe void SetVariableVec4(FName InVariableName, FVector4 InValue)
	{
		CheckDestroyed();
		if (!SetVariableVec4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableVec4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableVec4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableVec4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableVec4_InVariableName_Offset), 0, SetVariableVec4_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVariableVec4_InValue_Offset), 0, SetVariableVec4_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableVec4_FunctionAddress, intPtr, SetVariableVec4_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableVec3")]
	public unsafe void SetVariableVec3(FName InVariableName, FVector InValue)
	{
		CheckDestroyed();
		if (!SetVariableVec3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableVec3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableVec3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableVec3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableVec3_InVariableName_Offset), 0, SetVariableVec3_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVariableVec3_InValue_Offset), 0, SetVariableVec3_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableVec3_FunctionAddress, intPtr, SetVariableVec3_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableVec2")]
	public unsafe void SetVariableVec2(FName InVariableName, FVector2D InValue)
	{
		CheckDestroyed();
		if (!SetVariableVec2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableVec2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableVec2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableVec2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableVec2_InVariableName_Offset), 0, SetVariableVec2_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetVariableVec2_InValue_Offset), 0, SetVariableVec2_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableVec2_FunctionAddress, intPtr, SetVariableVec2_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableTextureRenderTarget")]
	public unsafe void SetVariableTextureRenderTarget(FName InVariableName, UTextureRenderTarget TextureRenderTarget)
	{
		CheckDestroyed();
		if (!SetVariableTextureRenderTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableTextureRenderTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableTextureRenderTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableTextureRenderTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableTextureRenderTarget_InVariableName_Offset), 0, SetVariableTextureRenderTarget_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UTextureRenderTarget>.ToNative(IntPtr.Add(intPtr, SetVariableTextureRenderTarget_TextureRenderTarget_Offset), 0, SetVariableTextureRenderTarget_TextureRenderTarget_PropertyAddress.Address, TextureRenderTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableTextureRenderTarget_FunctionAddress, intPtr, SetVariableTextureRenderTarget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableTexture")]
	public unsafe void SetVariableTexture(FName InVariableName, UTexture Texture)
	{
		CheckDestroyed();
		if (!SetVariableTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableTexture_InVariableName_Offset), 0, SetVariableTexture_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetVariableTexture_Texture_Offset), 0, SetVariableTexture_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableTexture_FunctionAddress, intPtr, SetVariableTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableStaticMesh")]
	public unsafe void SetVariableStaticMesh(FName InVariableName, UStaticMesh InValue)
	{
		CheckDestroyed();
		if (!SetVariableStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableStaticMesh_InVariableName_Offset), 0, SetVariableStaticMesh_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetVariableStaticMesh_InValue_Offset), 0, SetVariableStaticMesh_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableStaticMesh_FunctionAddress, intPtr, SetVariableStaticMesh_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableQuat")]
	public unsafe void SetVariableQuat(FName InVariableName, FQuat InValue)
	{
		CheckDestroyed();
		if (!SetVariableQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableQuat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableQuat_InVariableName_Offset), 0, SetVariableQuat_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InitializeValue_InContainer(SetVariableQuat_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetVariableQuat_InValue_Offset), 0, SetVariableQuat_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableQuat_FunctionAddress, intPtr, SetVariableQuat_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariablePosition")]
	public unsafe void SetVariablePosition(FName InVariableName, FVector InValue)
	{
		CheckDestroyed();
		if (!SetVariablePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariablePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariablePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariablePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariablePosition_InVariableName_Offset), 0, SetVariablePosition_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVariablePosition_InValue_Offset), 0, SetVariablePosition_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariablePosition_FunctionAddress, intPtr, SetVariablePosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableObject")]
	public unsafe void SetVariableObject(FName InVariableName, UObject Object)
	{
		CheckDestroyed();
		if (!SetVariableObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableObject_InVariableName_Offset), 0, SetVariableObject_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetVariableObject_Object_Offset), 0, SetVariableObject_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableObject_FunctionAddress, intPtr, SetVariableObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableMaterial")]
	public unsafe void SetVariableMaterial(FName InVariableName, UMaterialInterface Object)
	{
		CheckDestroyed();
		if (!SetVariableMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableMaterial_InVariableName_Offset), 0, SetVariableMaterial_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetVariableMaterial_Object_Offset), 0, SetVariableMaterial_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableMaterial_FunctionAddress, intPtr, SetVariableMaterial_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableLinearColor")]
	public unsafe void SetVariableLinearColor(FName InVariableName, FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetVariableLinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableLinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableLinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableLinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableLinearColor_InVariableName_Offset), 0, SetVariableLinearColor_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetVariableLinearColor_InValue_Offset), 0, SetVariableLinearColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableLinearColor_FunctionAddress, intPtr, SetVariableLinearColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableInt")]
	public unsafe void SetVariableInt(FName InVariableName, int InValue)
	{
		CheckDestroyed();
		if (!SetVariableInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableInt_InVariableName_Offset), 0, SetVariableInt_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVariableInt_InValue_Offset), 0, SetVariableInt_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableInt_FunctionAddress, intPtr, SetVariableInt_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableFloat")]
	public unsafe void SetVariableFloat(FName InVariableName, float InValue)
	{
		CheckDestroyed();
		if (!SetVariableFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableFloat_InVariableName_Offset), 0, SetVariableFloat_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVariableFloat_InValue_Offset), 0, SetVariableFloat_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableFloat_FunctionAddress, intPtr, SetVariableFloat_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableBool")]
	public unsafe void SetVariableBool(FName InVariableName, bool InValue)
	{
		CheckDestroyed();
		if (!SetVariableBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableBool_InVariableName_Offset), 0, SetVariableBool_InVariableName_PropertyAddress.Address, InVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVariableBool_InValue_Offset), 0, SetVariableBool_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableBool_FunctionAddress, intPtr, SetVariableBool_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetVariableActor")]
	public unsafe void SetVariableActor(FName InVariableName, AActor Actor)
	{
		CheckDestroyed();
		if (!SetVariableActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetVariableActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableActor_InVariableName_Offset), 0, SetVariableActor_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetVariableActor_Actor_Offset), 0, SetVariableActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableActor_FunctionAddress, intPtr, SetVariableActor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetTickBehavior")]
	public unsafe void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior)
	{
		CheckDestroyed();
		if (!SetTickBehavior_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetTickBehavior");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTickBehavior_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTickBehavior_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENiagaraTickBehavior>.ToNative(IntPtr.Add(intPtr, SetTickBehavior_NewTickBehavior_Offset), 0, SetTickBehavior_NewTickBehavior_PropertyAddress.Address, NewTickBehavior);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTickBehavior_FunctionAddress, intPtr, SetTickBehavior_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetSystemFixedBounds")]
	public unsafe void SetSystemFixedBounds(FBox LocalBounds)
	{
		CheckDestroyed();
		if (!SetSystemFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetSystemFixedBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSystemFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSystemFixedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, SetSystemFixedBounds_LocalBounds_Offset), 0, SetSystemFixedBounds_LocalBounds_PropertyAddress.Address, LocalBounds);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSystemFixedBounds_FunctionAddress, intPtr, SetSystemFixedBounds_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetSeekDelta")]
	public unsafe void SetSeekDelta(float InSeekDelta)
	{
		CheckDestroyed();
		if (!SetSeekDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetSeekDelta");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSeekDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSeekDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSeekDelta_InSeekDelta_Offset), 0, SetSeekDelta_InSeekDelta_PropertyAddress.Address, InSeekDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSeekDelta_FunctionAddress, intPtr, SetSeekDelta_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetRenderingEnabled")]
	public unsafe void SetRenderingEnabled(bool bInRenderingEnabled)
	{
		CheckDestroyed();
		if (!SetRenderingEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetRenderingEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderingEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderingEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderingEnabled_bInRenderingEnabled_Offset), 0, SetRenderingEnabled_bInRenderingEnabled_PropertyAddress.Address, bInRenderingEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderingEnabled_FunctionAddress, intPtr, SetRenderingEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetRandomSeedOffset")]
	public unsafe void SetRandomSeedOffset(int NewRandomSeedOffset)
	{
		CheckDestroyed();
		if (!SetRandomSeedOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetRandomSeedOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRandomSeedOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRandomSeedOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRandomSeedOffset_NewRandomSeedOffset_Offset), 0, SetRandomSeedOffset_NewRandomSeedOffset_PropertyAddress.Address, NewRandomSeedOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRandomSeedOffset_FunctionAddress, intPtr, SetRandomSeedOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetPreviewLODDistance")]
	public unsafe void SetPreviewLODDistance(bool bEnablePreviewLODDistance, float PreviewLODDistance, float PreviewMaxDistance)
	{
		CheckDestroyed();
		if (!SetPreviewLODDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetPreviewLODDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreviewLODDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreviewLODDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPreviewLODDistance_bEnablePreviewLODDistance_Offset), 0, SetPreviewLODDistance_bEnablePreviewLODDistance_PropertyAddress.Address, bEnablePreviewLODDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPreviewLODDistance_PreviewLODDistance_Offset), 0, SetPreviewLODDistance_PreviewLODDistance_PropertyAddress.Address, PreviewLODDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPreviewLODDistance_PreviewMaxDistance_Offset), 0, SetPreviewLODDistance_PreviewMaxDistance_PropertyAddress.Address, PreviewMaxDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreviewLODDistance_FunctionAddress, intPtr, SetPreviewLODDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetPaused")]
	public unsafe void SetPaused(bool bInPaused)
	{
		CheckDestroyed();
		if (!SetPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPaused_bInPaused_Offset), 0, SetPaused_bInPaused_PropertyAddress.Address, bInPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPaused_FunctionAddress, intPtr, SetPaused_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec4")]
	public unsafe void SetNiagaraVariableVec4(string InVariableName, FVector4 InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableVec4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableVec4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableVec4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec4_InVariableName_Offset), 0, SetNiagaraVariableVec4_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec4_InValue_Offset), 0, SetNiagaraVariableVec4_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableVec4_FunctionAddress, intPtr, SetNiagaraVariableVec4_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableVec4_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec3")]
	public unsafe void SetNiagaraVariableVec3(string InVariableName, FVector InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableVec3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableVec3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableVec3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec3_InVariableName_Offset), 0, SetNiagaraVariableVec3_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec3_InValue_Offset), 0, SetNiagaraVariableVec3_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableVec3_FunctionAddress, intPtr, SetNiagaraVariableVec3_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableVec3_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec2")]
	public unsafe void SetNiagaraVariableVec2(string InVariableName, FVector2D InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableVec2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableVec2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableVec2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec2_InVariableName_Offset), 0, SetNiagaraVariableVec2_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableVec2_InValue_Offset), 0, SetNiagaraVariableVec2_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableVec2_FunctionAddress, intPtr, SetNiagaraVariableVec2_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableVec2_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableQuat")]
	public unsafe void SetNiagaraVariableQuat(string InVariableName, FQuat InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableQuat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableQuat_InVariableName_Offset), 0, SetNiagaraVariableQuat_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InitializeValue_InContainer(SetNiagaraVariableQuat_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableQuat_InValue_Offset), 0, SetNiagaraVariableQuat_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableQuat_FunctionAddress, intPtr, SetNiagaraVariableQuat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableQuat_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariablePosition")]
	public unsafe void SetNiagaraVariablePosition(string InVariableName, FVector InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariablePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariablePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariablePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariablePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariablePosition_InVariableName_Offset), 0, SetNiagaraVariablePosition_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariablePosition_InValue_Offset), 0, SetNiagaraVariablePosition_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariablePosition_FunctionAddress, intPtr, SetNiagaraVariablePosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariablePosition_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableObject")]
	public unsafe void SetNiagaraVariableObject(string InVariableName, UObject Object)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableObject_InVariableName_Offset), 0, SetNiagaraVariableObject_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableObject_Object_Offset), 0, SetNiagaraVariableObject_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableObject_FunctionAddress, intPtr, SetNiagaraVariableObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableObject_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableLinearColor")]
	public unsafe void SetNiagaraVariableLinearColor(string InVariableName, FLinearColor InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableLinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableLinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableLinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableLinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableLinearColor_InVariableName_Offset), 0, SetNiagaraVariableLinearColor_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableLinearColor_InValue_Offset), 0, SetNiagaraVariableLinearColor_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableLinearColor_FunctionAddress, intPtr, SetNiagaraVariableLinearColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableLinearColor_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableInt")]
	public unsafe void SetNiagaraVariableInt(string InVariableName, int InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableInt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableInt_InVariableName_Offset), 0, SetNiagaraVariableInt_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableInt_InValue_Offset), 0, SetNiagaraVariableInt_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableInt_FunctionAddress, intPtr, SetNiagaraVariableInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableInt_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableFloat")]
	public unsafe void SetNiagaraVariableFloat(string InVariableName, float InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableFloat_InVariableName_Offset), 0, SetNiagaraVariableFloat_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableFloat_InValue_Offset), 0, SetNiagaraVariableFloat_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableFloat_FunctionAddress, intPtr, SetNiagaraVariableFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableFloat_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableBool")]
	public unsafe void SetNiagaraVariableBool(string InVariableName, bool InValue)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableBool_InVariableName_Offset), 0, SetNiagaraVariableBool_InVariableName_PropertyAddress.Address, InVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableBool_InValue_Offset), 0, SetNiagaraVariableBool_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableBool_FunctionAddress, intPtr, SetNiagaraVariableBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableBool_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetNiagaraVariableActor")]
	public unsafe void SetNiagaraVariableActor(string InVariableName, AActor Actor)
	{
		CheckDestroyed();
		if (!SetNiagaraVariableActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetNiagaraVariableActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraVariableActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraVariableActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableActor_InVariableName_Offset), 0, SetNiagaraVariableActor_InVariableName_PropertyAddress.Address, InVariableName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetNiagaraVariableActor_Actor_Offset), 0, SetNiagaraVariableActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNiagaraVariableActor_FunctionAddress, intPtr, SetNiagaraVariableActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraVariableActor_InVariableName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetMaxSimTime")]
	public unsafe void SetMaxSimTime(float InMaxTime)
	{
		CheckDestroyed();
		if (!SetMaxSimTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetMaxSimTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxSimTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxSimTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaxSimTime_InMaxTime_Offset), 0, SetMaxSimTime_InMaxTime_PropertyAddress.Address, InMaxTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxSimTime_FunctionAddress, intPtr, SetMaxSimTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetLockDesiredAgeDeltaTimeToSeekDelta")]
	public unsafe void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock)
	{
		CheckDestroyed();
		if (!SetLockDesiredAgeDeltaTimeToSeekDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetLockDesiredAgeDeltaTimeToSeekDelta");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_Offset), 0, SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_PropertyAddress.Address, bLock);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, intPtr, SetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetGpuComputeDebug")]
	public unsafe void SetGpuComputeDebug(bool bEnableDebug)
	{
		CheckDestroyed();
		if (!SetGpuComputeDebug_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetGpuComputeDebug");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGpuComputeDebug_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGpuComputeDebug_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGpuComputeDebug_bEnableDebug_Offset), 0, SetGpuComputeDebug_bEnableDebug_PropertyAddress.Address, bEnableDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGpuComputeDebug_FunctionAddress, intPtr, SetGpuComputeDebug_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetForceSolo")]
	public unsafe void SetForceSolo(bool bInForceSolo)
	{
		CheckDestroyed();
		if (!SetForceSolo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetForceSolo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceSolo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceSolo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceSolo_bInForceSolo_Offset), 0, SetForceSolo_bInForceSolo_PropertyAddress.Address, bInForceSolo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceSolo_FunctionAddress, intPtr, SetForceSolo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetForceLocalPlayerEffect")]
	public unsafe void SetForceLocalPlayerEffect(bool bIsPlayerEffect)
	{
		CheckDestroyed();
		if (!SetForceLocalPlayerEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetForceLocalPlayerEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceLocalPlayerEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceLocalPlayerEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceLocalPlayerEffect_bIsPlayerEffect_Offset), 0, SetForceLocalPlayerEffect_bIsPlayerEffect_PropertyAddress.Address, bIsPlayerEffect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceLocalPlayerEffect_FunctionAddress, intPtr, SetForceLocalPlayerEffect_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetEmitterFixedBounds")]
	public unsafe void SetEmitterFixedBounds(FName EmitterName, FBox LocalBounds)
	{
		CheckDestroyed();
		if (!SetEmitterFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetEmitterFixedBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEmitterFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEmitterFixedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetEmitterFixedBounds_EmitterName_Offset), 0, SetEmitterFixedBounds_EmitterName_PropertyAddress.Address, EmitterName);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, SetEmitterFixedBounds_LocalBounds_Offset), 0, SetEmitterFixedBounds_LocalBounds_PropertyAddress.Address, LocalBounds);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEmitterFixedBounds_FunctionAddress, intPtr, SetEmitterFixedBounds_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetDesiredAge")]
	public unsafe void SetDesiredAge(float InDesiredAge)
	{
		CheckDestroyed();
		if (!SetDesiredAge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetDesiredAge");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredAge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredAge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDesiredAge_InDesiredAge_Offset), 0, SetDesiredAge_InDesiredAge_PropertyAddress.Address, InDesiredAge);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredAge_FunctionAddress, intPtr, SetDesiredAge_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetCustomTimeDilation")]
	public unsafe void SetCustomTimeDilation(float Dilation = 1f)
	{
		CheckDestroyed();
		if (!SetCustomTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetCustomTimeDilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomTimeDilation_Dilation_Offset), 0, SetCustomTimeDilation_Dilation_PropertyAddress.Address, Dilation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomTimeDilation_FunctionAddress, intPtr, SetCustomTimeDilation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetCanRenderWhileSeeking")]
	public unsafe void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking)
	{
		CheckDestroyed();
		if (!SetCanRenderWhileSeeking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetCanRenderWhileSeeking");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCanRenderWhileSeeking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCanRenderWhileSeeking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_Offset), 0, SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_PropertyAddress.Address, bInCanRenderWhileSeeking);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCanRenderWhileSeeking_FunctionAddress, intPtr, SetCanRenderWhileSeeking_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetAutoDestroy")]
	public unsafe void SetAutoDestroy(bool bInAutoDestroy)
	{
		CheckDestroyed();
		if (!SetAutoDestroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetAutoDestroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAutoDestroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAutoDestroy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAutoDestroy_bInAutoDestroy_Offset), 0, SetAutoDestroy_bInAutoDestroy_PropertyAddress.Address, bInAutoDestroy);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAutoDestroy_FunctionAddress, intPtr, SetAutoDestroy_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetAsset")]
	public unsafe void SetAsset(UNiagaraSystem InAsset, bool bResetExistingOverrideParameters = true)
	{
		CheckDestroyed();
		if (!SetAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SetAsset_InAsset_Offset), 0, SetAsset_InAsset_PropertyAddress.Address, InAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAsset_bResetExistingOverrideParameters_Offset), 0, SetAsset_bResetExistingOverrideParameters_PropertyAddress.Address, bResetExistingOverrideParameters);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAsset_FunctionAddress, intPtr, SetAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetAllowScalability")]
	public unsafe void SetAllowScalability(bool bAllow)
	{
		CheckDestroyed();
		if (!SetAllowScalability_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetAllowScalability");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllowScalability_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllowScalability_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllowScalability_bAllow_Offset), 0, SetAllowScalability_bAllow_PropertyAddress.Address, bAllow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllowScalability_FunctionAddress, intPtr, SetAllowScalability_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SetAgeUpdateMode")]
	public unsafe void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode)
	{
		CheckDestroyed();
		if (!SetAgeUpdateMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SetAgeUpdateMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAgeUpdateMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAgeUpdateMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENiagaraAgeUpdateMode>.ToNative(IntPtr.Add(intPtr, SetAgeUpdateMode_InAgeUpdateMode_Offset), 0, SetAgeUpdateMode_InAgeUpdateMode_PropertyAddress.Address, InAgeUpdateMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAgeUpdateMode_FunctionAddress, intPtr, SetAgeUpdateMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:SeekToDesiredAge")]
	public unsafe void SeekToDesiredAge(float InDesiredAge)
	{
		CheckDestroyed();
		if (!SeekToDesiredAge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:SeekToDesiredAge");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SeekToDesiredAge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SeekToDesiredAge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SeekToDesiredAge_InDesiredAge_Offset), 0, SeekToDesiredAge_InDesiredAge_PropertyAddress.Address, InDesiredAge);
		NativeReflection.InvokeFunctionOptimized(base.Address, SeekToDesiredAge_FunctionAddress, intPtr, SeekToDesiredAge_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:ResetSystem")]
	public unsafe void ResetSystem()
	{
		CheckDestroyed();
		if (!ResetSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:ResetSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetSystem_FunctionAddress, argsSize: ResetSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:ReinitializeSystem")]
	public unsafe void ReinitializeSystem()
	{
		CheckDestroyed();
		if (!ReinitializeSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:ReinitializeSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReinitializeSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReinitializeSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReinitializeSystem_FunctionAddress, argsSize: ReinitializeSystem_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:IsPaused")]
	public unsafe bool IsPaused()
	{
		CheckDestroyed();
		if (!IsPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:IsPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPaused_FunctionAddress, intPtr, IsPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPaused_ReturnValue_Offset), 0, IsPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:InitForPerformanceBaseline")]
	public unsafe void InitForPerformanceBaseline()
	{
		CheckDestroyed();
		if (!InitForPerformanceBaseline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:InitForPerformanceBaseline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitForPerformanceBaseline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitForPerformanceBaseline_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitForPerformanceBaseline_FunctionAddress, argsSize: InitForPerformanceBaseline_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetTickBehavior")]
	public unsafe ENiagaraTickBehavior GetTickBehavior()
	{
		CheckDestroyed();
		if (!GetTickBehavior_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetTickBehavior");
			return ENiagaraTickBehavior.UsePrereqs;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTickBehavior_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTickBehavior_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTickBehavior_FunctionAddress, intPtr, GetTickBehavior_ParamsSize);
		return EnumMarshaler<ENiagaraTickBehavior>.FromNative(IntPtr.Add(intPtr, GetTickBehavior_ReturnValue_Offset), 0, GetTickBehavior_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetSystemFixedBounds")]
	public unsafe FBox GetSystemFixedBounds()
	{
		CheckDestroyed();
		if (!GetSystemFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetSystemFixedBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSystemFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSystemFixedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSystemFixedBounds_FunctionAddress, intPtr, GetSystemFixedBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetSystemFixedBounds_ReturnValue_Offset), 0, GetSystemFixedBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetSeekDelta")]
	public unsafe float GetSeekDelta()
	{
		CheckDestroyed();
		if (!GetSeekDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetSeekDelta");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSeekDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSeekDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeekDelta_FunctionAddress, intPtr, GetSeekDelta_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSeekDelta_ReturnValue_Offset), 0, GetSeekDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetRandomSeedOffset")]
	public unsafe int GetRandomSeedOffset()
	{
		CheckDestroyed();
		if (!GetRandomSeedOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetRandomSeedOffset");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomSeedOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomSeedOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRandomSeedOffset_FunctionAddress, intPtr, GetRandomSeedOffset_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRandomSeedOffset_ReturnValue_Offset), 0, GetRandomSeedOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetPreviewLODDistanceEnabled")]
	public unsafe bool GetPreviewLODDistanceEnabled()
	{
		CheckDestroyed();
		if (!GetPreviewLODDistanceEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetPreviewLODDistanceEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewLODDistanceEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewLODDistanceEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviewLODDistanceEnabled_FunctionAddress, intPtr, GetPreviewLODDistanceEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPreviewLODDistanceEnabled_ReturnValue_Offset), 0, GetPreviewLODDistanceEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetPreviewLODDistance")]
	public unsafe float GetPreviewLODDistance()
	{
		CheckDestroyed();
		if (!GetPreviewLODDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetPreviewLODDistance");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewLODDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewLODDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviewLODDistance_FunctionAddress, intPtr, GetPreviewLODDistance_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPreviewLODDistance_ReturnValue_Offset), 0, GetPreviewLODDistance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetMaxSimTime")]
	public unsafe float GetMaxSimTime()
	{
		CheckDestroyed();
		if (!GetMaxSimTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetMaxSimTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxSimTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxSimTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxSimTime_FunctionAddress, intPtr, GetMaxSimTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxSimTime_ReturnValue_Offset), 0, GetMaxSimTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetLockDesiredAgeDeltaTimeToSeekDelta")]
	public unsafe bool GetLockDesiredAgeDeltaTimeToSeekDelta()
	{
		CheckDestroyed();
		if (!GetLockDesiredAgeDeltaTimeToSeekDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetLockDesiredAgeDeltaTimeToSeekDelta");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, intPtr, GetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_Offset), 0, GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetForceSolo")]
	public unsafe bool GetForceSolo()
	{
		CheckDestroyed();
		if (!GetForceSolo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetForceSolo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForceSolo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForceSolo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetForceSolo_FunctionAddress, intPtr, GetForceSolo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetForceSolo_ReturnValue_Offset), 0, GetForceSolo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetForceLocalPlayerEffect")]
	public unsafe bool GetForceLocalPlayerEffect()
	{
		CheckDestroyed();
		if (!GetForceLocalPlayerEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetForceLocalPlayerEffect");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForceLocalPlayerEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForceLocalPlayerEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetForceLocalPlayerEffect_FunctionAddress, intPtr, GetForceLocalPlayerEffect_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetForceLocalPlayerEffect_ReturnValue_Offset), 0, GetForceLocalPlayerEffect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetEmitterFixedBounds")]
	public unsafe FBox GetEmitterFixedBounds(FName EmitterName)
	{
		CheckDestroyed();
		if (!GetEmitterFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetEmitterFixedBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEmitterFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEmitterFixedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetEmitterFixedBounds_EmitterName_Offset), 0, GetEmitterFixedBounds_EmitterName_PropertyAddress.Address, EmitterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEmitterFixedBounds_FunctionAddress, intPtr, GetEmitterFixedBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetEmitterFixedBounds_ReturnValue_Offset), 0, GetEmitterFixedBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetDesiredAge")]
	public unsafe float GetDesiredAge()
	{
		CheckDestroyed();
		if (!GetDesiredAge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetDesiredAge");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredAge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredAge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredAge_FunctionAddress, intPtr, GetDesiredAge_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDesiredAge_ReturnValue_Offset), 0, GetDesiredAge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetDataInterface")]
	public unsafe UNiagaraDataInterface GetDataInterface(string Name)
	{
		CheckDestroyed();
		if (!GetDataInterface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetDataInterface");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataInterface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataInterface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetDataInterface_Name_Offset), 0, GetDataInterface_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDataInterface_FunctionAddress, intPtr, GetDataInterface_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDataInterface_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UNiagaraDataInterface>.FromNative(IntPtr.Add(intPtr, GetDataInterface_ReturnValue_Offset), 0, GetDataInterface_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetCustomTimeDilation")]
	public unsafe float GetCustomTimeDilation()
	{
		CheckDestroyed();
		if (!GetCustomTimeDilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetCustomTimeDilation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomTimeDilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomTimeDilation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomTimeDilation_FunctionAddress, intPtr, GetCustomTimeDilation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCustomTimeDilation_ReturnValue_Offset), 0, GetCustomTimeDilation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetAsset")]
	public unsafe UNiagaraSystem GetAsset()
	{
		CheckDestroyed();
		if (!GetAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAsset_FunctionAddress, intPtr, GetAsset_ParamsSize);
		return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(intPtr, GetAsset_ReturnValue_Offset), 0, GetAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetAllowScalability")]
	public unsafe bool GetAllowScalability()
	{
		CheckDestroyed();
		if (!GetAllowScalability_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetAllowScalability");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllowScalability_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllowScalability_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllowScalability_FunctionAddress, intPtr, GetAllowScalability_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllowScalability_ReturnValue_Offset), 0, GetAllowScalability_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:GetAgeUpdateMode")]
	public unsafe ENiagaraAgeUpdateMode GetAgeUpdateMode()
	{
		CheckDestroyed();
		if (!GetAgeUpdateMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:GetAgeUpdateMode");
			return ENiagaraAgeUpdateMode.TickDeltaTime;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAgeUpdateMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAgeUpdateMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAgeUpdateMode_FunctionAddress, intPtr, GetAgeUpdateMode_ParamsSize);
		return EnumMarshaler<ENiagaraAgeUpdateMode>.FromNative(IntPtr.Add(intPtr, GetAgeUpdateMode_ReturnValue_Offset), 0, GetAgeUpdateMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:ClearSystemFixedBounds")]
	public unsafe void ClearSystemFixedBounds()
	{
		CheckDestroyed();
		if (!ClearSystemFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:ClearSystemFixedBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSystemFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSystemFixedBounds_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSystemFixedBounds_FunctionAddress, argsSize: ClearSystemFixedBounds_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:ClearEmitterFixedBounds")]
	public unsafe void ClearEmitterFixedBounds(FName EmitterName)
	{
		CheckDestroyed();
		if (!ClearEmitterFixedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:ClearEmitterFixedBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearEmitterFixedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearEmitterFixedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearEmitterFixedBounds_EmitterName_Offset), 0, ClearEmitterFixedBounds_EmitterName_PropertyAddress.Address, EmitterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearEmitterFixedBounds_FunctionAddress, intPtr, ClearEmitterFixedBounds_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AdvanceSimulationByTime")]
	public unsafe void AdvanceSimulationByTime(float SimulateTime, float TickDeltaSeconds)
	{
		CheckDestroyed();
		if (!AdvanceSimulationByTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:AdvanceSimulationByTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceSimulationByTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceSimulationByTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceSimulationByTime_SimulateTime_Offset), 0, AdvanceSimulationByTime_SimulateTime_PropertyAddress.Address, SimulateTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceSimulationByTime_TickDeltaSeconds_Offset), 0, AdvanceSimulationByTime_TickDeltaSeconds_PropertyAddress.Address, TickDeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, AdvanceSimulationByTime_FunctionAddress, intPtr, AdvanceSimulationByTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Niagara.NiagaraComponent:AdvanceSimulation")]
	public unsafe void AdvanceSimulation(int TickCount, float TickDeltaSeconds)
	{
		CheckDestroyed();
		if (!AdvanceSimulation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraComponent:AdvanceSimulation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceSimulation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceSimulation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AdvanceSimulation_TickCount_Offset), 0, AdvanceSimulation_TickCount_PropertyAddress.Address, TickCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceSimulation_TickDeltaSeconds_Offset), 0, AdvanceSimulation_TickDeltaSeconds_PropertyAddress.Address, TickDeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, AdvanceSimulation_FunctionAddress, intPtr, AdvanceSimulation_ParamsSize);
	}

	static UNiagaraComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Niagara.NiagaraComponent");
		NativeReflectionCached.GetPropertyRef(ref AutoManageAttachment_PropertyAddress, intPtr, "bAutoManageAttachment");
		AutoManageAttachment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoManageAttachment");
		AutoManageAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoManageAttachment", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachWeldSimulatedBodies_PropertyAddress, intPtr, "bAutoAttachWeldSimulatedBodies");
		AutoAttachWeldSimulatedBodies_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoAttachWeldSimulatedBodies");
		AutoAttachWeldSimulatedBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoAttachWeldSimulatedBodies", Classes.FBoolProperty);
		OnSystemFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSystemFinished");
		OnSystemFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSystemFinished", Classes.FMulticastDelegateProperty);
		AutoAttachParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachParent");
		AutoAttachParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachParent", Classes.FWeakObjectProperty);
		AutoAttachSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachSocketName");
		AutoAttachSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachLocationRule_PropertyAddress, intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachLocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachRotationRule_PropertyAddress, intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachRotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachScaleRule_PropertyAddress, intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachScaleRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderInTranslucencyUpscaledRTPass_PropertyAddress, intPtr, "bRenderInTranslucencyUpscaledRTPass");
		RenderInTranslucencyUpscaledRTPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderInTranslucencyUpscaledRTPass");
		RenderInTranslucencyUpscaledRTPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderInTranslucencyUpscaledRTPass", Classes.FBoolProperty);
		SetVariableVec4_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableVec4");
		SetVariableVec4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableVec4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec4_InVariableName_PropertyAddress, SetVariableVec4_FunctionAddress, "InVariableName");
		SetVariableVec4_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec4_FunctionAddress, "InVariableName");
		SetVariableVec4_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec4_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec4_InValue_PropertyAddress, SetVariableVec4_FunctionAddress, "InValue");
		SetVariableVec4_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec4_FunctionAddress, "InValue");
		SetVariableVec4_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec4_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariableVec4_IsValid = SetVariableVec4_FunctionAddress != IntPtr.Zero && SetVariableVec4_InVariableName_IsValid && SetVariableVec4_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableVec4", SetVariableVec4_IsValid);
		SetVariableVec3_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableVec3");
		SetVariableVec3_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableVec3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec3_InVariableName_PropertyAddress, SetVariableVec3_FunctionAddress, "InVariableName");
		SetVariableVec3_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec3_FunctionAddress, "InVariableName");
		SetVariableVec3_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec3_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec3_InValue_PropertyAddress, SetVariableVec3_FunctionAddress, "InValue");
		SetVariableVec3_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec3_FunctionAddress, "InValue");
		SetVariableVec3_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec3_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariableVec3_IsValid = SetVariableVec3_FunctionAddress != IntPtr.Zero && SetVariableVec3_InVariableName_IsValid && SetVariableVec3_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableVec3", SetVariableVec3_IsValid);
		SetVariableVec2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableVec2");
		SetVariableVec2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableVec2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec2_InVariableName_PropertyAddress, SetVariableVec2_FunctionAddress, "InVariableName");
		SetVariableVec2_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec2_FunctionAddress, "InVariableName");
		SetVariableVec2_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec2_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableVec2_InValue_PropertyAddress, SetVariableVec2_FunctionAddress, "InValue");
		SetVariableVec2_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableVec2_FunctionAddress, "InValue");
		SetVariableVec2_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableVec2_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariableVec2_IsValid = SetVariableVec2_FunctionAddress != IntPtr.Zero && SetVariableVec2_InVariableName_IsValid && SetVariableVec2_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableVec2", SetVariableVec2_IsValid);
		SetVariableTextureRenderTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableTextureRenderTarget");
		SetVariableTextureRenderTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableTextureRenderTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableTextureRenderTarget_InVariableName_PropertyAddress, SetVariableTextureRenderTarget_FunctionAddress, "InVariableName");
		SetVariableTextureRenderTarget_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableTextureRenderTarget_FunctionAddress, "InVariableName");
		SetVariableTextureRenderTarget_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableTextureRenderTarget_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableTextureRenderTarget_TextureRenderTarget_PropertyAddress, SetVariableTextureRenderTarget_FunctionAddress, "TextureRenderTarget");
		SetVariableTextureRenderTarget_TextureRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableTextureRenderTarget_FunctionAddress, "TextureRenderTarget");
		SetVariableTextureRenderTarget_TextureRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableTextureRenderTarget_FunctionAddress, "TextureRenderTarget", Classes.FObjectProperty);
		SetVariableTextureRenderTarget_IsValid = SetVariableTextureRenderTarget_FunctionAddress != IntPtr.Zero && SetVariableTextureRenderTarget_InVariableName_IsValid && SetVariableTextureRenderTarget_TextureRenderTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableTextureRenderTarget", SetVariableTextureRenderTarget_IsValid);
		SetVariableTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableTexture");
		SetVariableTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableTexture_InVariableName_PropertyAddress, SetVariableTexture_FunctionAddress, "InVariableName");
		SetVariableTexture_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableTexture_FunctionAddress, "InVariableName");
		SetVariableTexture_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableTexture_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableTexture_Texture_PropertyAddress, SetVariableTexture_FunctionAddress, "Texture");
		SetVariableTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableTexture_FunctionAddress, "Texture");
		SetVariableTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetVariableTexture_IsValid = SetVariableTexture_FunctionAddress != IntPtr.Zero && SetVariableTexture_InVariableName_IsValid && SetVariableTexture_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableTexture", SetVariableTexture_IsValid);
		SetVariableStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableStaticMesh");
		SetVariableStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableStaticMesh_InVariableName_PropertyAddress, SetVariableStaticMesh_FunctionAddress, "InVariableName");
		SetVariableStaticMesh_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableStaticMesh_FunctionAddress, "InVariableName");
		SetVariableStaticMesh_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableStaticMesh_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableStaticMesh_InValue_PropertyAddress, SetVariableStaticMesh_FunctionAddress, "InValue");
		SetVariableStaticMesh_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableStaticMesh_FunctionAddress, "InValue");
		SetVariableStaticMesh_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableStaticMesh_FunctionAddress, "InValue", Classes.FObjectProperty);
		SetVariableStaticMesh_IsValid = SetVariableStaticMesh_FunctionAddress != IntPtr.Zero && SetVariableStaticMesh_InVariableName_IsValid && SetVariableStaticMesh_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableStaticMesh", SetVariableStaticMesh_IsValid);
		SetVariableQuat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableQuat");
		SetVariableQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableQuat_InVariableName_PropertyAddress, SetVariableQuat_FunctionAddress, "InVariableName");
		SetVariableQuat_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableQuat_FunctionAddress, "InVariableName");
		SetVariableQuat_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableQuat_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableQuat_InValue_PropertyAddress, SetVariableQuat_FunctionAddress, "InValue");
		SetVariableQuat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableQuat_FunctionAddress, "InValue");
		SetVariableQuat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableQuat_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariableQuat_IsValid = SetVariableQuat_FunctionAddress != IntPtr.Zero && SetVariableQuat_InVariableName_IsValid && SetVariableQuat_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableQuat", SetVariableQuat_IsValid);
		SetVariablePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariablePosition");
		SetVariablePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariablePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariablePosition_InVariableName_PropertyAddress, SetVariablePosition_FunctionAddress, "InVariableName");
		SetVariablePosition_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariablePosition_FunctionAddress, "InVariableName");
		SetVariablePosition_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariablePosition_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariablePosition_InValue_PropertyAddress, SetVariablePosition_FunctionAddress, "InValue");
		SetVariablePosition_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariablePosition_FunctionAddress, "InValue");
		SetVariablePosition_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariablePosition_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariablePosition_IsValid = SetVariablePosition_FunctionAddress != IntPtr.Zero && SetVariablePosition_InVariableName_IsValid && SetVariablePosition_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariablePosition", SetVariablePosition_IsValid);
		SetVariableObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableObject");
		SetVariableObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableObject_InVariableName_PropertyAddress, SetVariableObject_FunctionAddress, "InVariableName");
		SetVariableObject_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableObject_FunctionAddress, "InVariableName");
		SetVariableObject_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableObject_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableObject_Object_PropertyAddress, SetVariableObject_FunctionAddress, "Object");
		SetVariableObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableObject_FunctionAddress, "Object");
		SetVariableObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableObject_FunctionAddress, "Object", Classes.FObjectProperty);
		SetVariableObject_IsValid = SetVariableObject_FunctionAddress != IntPtr.Zero && SetVariableObject_InVariableName_IsValid && SetVariableObject_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableObject", SetVariableObject_IsValid);
		SetVariableMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableMaterial");
		SetVariableMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableMaterial_InVariableName_PropertyAddress, SetVariableMaterial_FunctionAddress, "InVariableName");
		SetVariableMaterial_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableMaterial_FunctionAddress, "InVariableName");
		SetVariableMaterial_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableMaterial_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableMaterial_Object_PropertyAddress, SetVariableMaterial_FunctionAddress, "Object");
		SetVariableMaterial_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableMaterial_FunctionAddress, "Object");
		SetVariableMaterial_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableMaterial_FunctionAddress, "Object", Classes.FObjectProperty);
		SetVariableMaterial_IsValid = SetVariableMaterial_FunctionAddress != IntPtr.Zero && SetVariableMaterial_InVariableName_IsValid && SetVariableMaterial_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableMaterial", SetVariableMaterial_IsValid);
		SetVariableLinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableLinearColor");
		SetVariableLinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableLinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableLinearColor_InVariableName_PropertyAddress, SetVariableLinearColor_FunctionAddress, "InVariableName");
		SetVariableLinearColor_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableLinearColor_FunctionAddress, "InVariableName");
		SetVariableLinearColor_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableLinearColor_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableLinearColor_InValue_PropertyAddress, SetVariableLinearColor_FunctionAddress, "InValue");
		SetVariableLinearColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableLinearColor_FunctionAddress, "InValue");
		SetVariableLinearColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableLinearColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetVariableLinearColor_IsValid = SetVariableLinearColor_FunctionAddress != IntPtr.Zero && SetVariableLinearColor_InVariableName_IsValid && SetVariableLinearColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableLinearColor", SetVariableLinearColor_IsValid);
		SetVariableInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableInt");
		SetVariableInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableInt_InVariableName_PropertyAddress, SetVariableInt_FunctionAddress, "InVariableName");
		SetVariableInt_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableInt_FunctionAddress, "InVariableName");
		SetVariableInt_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableInt_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableInt_InValue_PropertyAddress, SetVariableInt_FunctionAddress, "InValue");
		SetVariableInt_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableInt_FunctionAddress, "InValue");
		SetVariableInt_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableInt_FunctionAddress, "InValue", Classes.FIntProperty);
		SetVariableInt_IsValid = SetVariableInt_FunctionAddress != IntPtr.Zero && SetVariableInt_InVariableName_IsValid && SetVariableInt_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableInt", SetVariableInt_IsValid);
		SetVariableFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableFloat");
		SetVariableFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableFloat_InVariableName_PropertyAddress, SetVariableFloat_FunctionAddress, "InVariableName");
		SetVariableFloat_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableFloat_FunctionAddress, "InVariableName");
		SetVariableFloat_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableFloat_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableFloat_InValue_PropertyAddress, SetVariableFloat_FunctionAddress, "InValue");
		SetVariableFloat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableFloat_FunctionAddress, "InValue");
		SetVariableFloat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableFloat_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetVariableFloat_IsValid = SetVariableFloat_FunctionAddress != IntPtr.Zero && SetVariableFloat_InVariableName_IsValid && SetVariableFloat_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableFloat", SetVariableFloat_IsValid);
		SetVariableBool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableBool");
		SetVariableBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableBool_InVariableName_PropertyAddress, SetVariableBool_FunctionAddress, "InVariableName");
		SetVariableBool_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableBool_FunctionAddress, "InVariableName");
		SetVariableBool_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableBool_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableBool_InValue_PropertyAddress, SetVariableBool_FunctionAddress, "InValue");
		SetVariableBool_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableBool_FunctionAddress, "InValue");
		SetVariableBool_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableBool_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetVariableBool_IsValid = SetVariableBool_FunctionAddress != IntPtr.Zero && SetVariableBool_InVariableName_IsValid && SetVariableBool_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableBool", SetVariableBool_IsValid);
		SetVariableActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVariableActor");
		SetVariableActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableActor_InVariableName_PropertyAddress, SetVariableActor_FunctionAddress, "InVariableName");
		SetVariableActor_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableActor_FunctionAddress, "InVariableName");
		SetVariableActor_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableActor_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableActor_Actor_PropertyAddress, SetVariableActor_FunctionAddress, "Actor");
		SetVariableActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableActor_FunctionAddress, "Actor");
		SetVariableActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetVariableActor_IsValid = SetVariableActor_FunctionAddress != IntPtr.Zero && SetVariableActor_InVariableName_IsValid && SetVariableActor_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetVariableActor", SetVariableActor_IsValid);
		SetTickBehavior_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTickBehavior");
		SetTickBehavior_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTickBehavior_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTickBehavior_NewTickBehavior_PropertyAddress, SetTickBehavior_FunctionAddress, "NewTickBehavior");
		SetTickBehavior_NewTickBehavior_Offset = NativeReflectionCached.GetPropertyOffset(SetTickBehavior_FunctionAddress, "NewTickBehavior");
		SetTickBehavior_NewTickBehavior_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTickBehavior_FunctionAddress, "NewTickBehavior", Classes.FEnumProperty);
		SetTickBehavior_IsValid = SetTickBehavior_FunctionAddress != IntPtr.Zero && SetTickBehavior_NewTickBehavior_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetTickBehavior", SetTickBehavior_IsValid);
		SetSystemFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSystemFixedBounds");
		SetSystemFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSystemFixedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSystemFixedBounds_LocalBounds_PropertyAddress, SetSystemFixedBounds_FunctionAddress, "LocalBounds");
		SetSystemFixedBounds_LocalBounds_Offset = NativeReflectionCached.GetPropertyOffset(SetSystemFixedBounds_FunctionAddress, "LocalBounds");
		SetSystemFixedBounds_LocalBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSystemFixedBounds_FunctionAddress, "LocalBounds", Classes.FStructProperty);
		SetSystemFixedBounds_IsValid = SetSystemFixedBounds_FunctionAddress != IntPtr.Zero && SetSystemFixedBounds_LocalBounds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetSystemFixedBounds", SetSystemFixedBounds_IsValid);
		SetSeekDelta_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSeekDelta");
		SetSeekDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSeekDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSeekDelta_InSeekDelta_PropertyAddress, SetSeekDelta_FunctionAddress, "InSeekDelta");
		SetSeekDelta_InSeekDelta_Offset = NativeReflectionCached.GetPropertyOffset(SetSeekDelta_FunctionAddress, "InSeekDelta");
		SetSeekDelta_InSeekDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSeekDelta_FunctionAddress, "InSeekDelta", Classes.FFloatProperty);
		SetSeekDelta_IsValid = SetSeekDelta_FunctionAddress != IntPtr.Zero && SetSeekDelta_InSeekDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetSeekDelta", SetSeekDelta_IsValid);
		SetRenderingEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderingEnabled");
		SetRenderingEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderingEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderingEnabled_bInRenderingEnabled_PropertyAddress, SetRenderingEnabled_FunctionAddress, "bInRenderingEnabled");
		SetRenderingEnabled_bInRenderingEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderingEnabled_FunctionAddress, "bInRenderingEnabled");
		SetRenderingEnabled_bInRenderingEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderingEnabled_FunctionAddress, "bInRenderingEnabled", Classes.FBoolProperty);
		SetRenderingEnabled_IsValid = SetRenderingEnabled_FunctionAddress != IntPtr.Zero && SetRenderingEnabled_bInRenderingEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetRenderingEnabled", SetRenderingEnabled_IsValid);
		SetRandomSeedOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRandomSeedOffset");
		SetRandomSeedOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRandomSeedOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRandomSeedOffset_NewRandomSeedOffset_PropertyAddress, SetRandomSeedOffset_FunctionAddress, "NewRandomSeedOffset");
		SetRandomSeedOffset_NewRandomSeedOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetRandomSeedOffset_FunctionAddress, "NewRandomSeedOffset");
		SetRandomSeedOffset_NewRandomSeedOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRandomSeedOffset_FunctionAddress, "NewRandomSeedOffset", Classes.FIntProperty);
		SetRandomSeedOffset_IsValid = SetRandomSeedOffset_FunctionAddress != IntPtr.Zero && SetRandomSeedOffset_NewRandomSeedOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetRandomSeedOffset", SetRandomSeedOffset_IsValid);
		SetPreviewLODDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPreviewLODDistance");
		SetPreviewLODDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreviewLODDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewLODDistance_bEnablePreviewLODDistance_PropertyAddress, SetPreviewLODDistance_FunctionAddress, "bEnablePreviewLODDistance");
		SetPreviewLODDistance_bEnablePreviewLODDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewLODDistance_FunctionAddress, "bEnablePreviewLODDistance");
		SetPreviewLODDistance_bEnablePreviewLODDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewLODDistance_FunctionAddress, "bEnablePreviewLODDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewLODDistance_PreviewLODDistance_PropertyAddress, SetPreviewLODDistance_FunctionAddress, "PreviewLODDistance");
		SetPreviewLODDistance_PreviewLODDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewLODDistance_FunctionAddress, "PreviewLODDistance");
		SetPreviewLODDistance_PreviewLODDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewLODDistance_FunctionAddress, "PreviewLODDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreviewLODDistance_PreviewMaxDistance_PropertyAddress, SetPreviewLODDistance_FunctionAddress, "PreviewMaxDistance");
		SetPreviewLODDistance_PreviewMaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetPreviewLODDistance_FunctionAddress, "PreviewMaxDistance");
		SetPreviewLODDistance_PreviewMaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreviewLODDistance_FunctionAddress, "PreviewMaxDistance", Classes.FFloatProperty);
		SetPreviewLODDistance_IsValid = SetPreviewLODDistance_FunctionAddress != IntPtr.Zero && SetPreviewLODDistance_bEnablePreviewLODDistance_IsValid && SetPreviewLODDistance_PreviewLODDistance_IsValid && SetPreviewLODDistance_PreviewMaxDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetPreviewLODDistance", SetPreviewLODDistance_IsValid);
		SetPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPaused");
		SetPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPaused_bInPaused_PropertyAddress, SetPaused_FunctionAddress, "bInPaused");
		SetPaused_bInPaused_Offset = NativeReflectionCached.GetPropertyOffset(SetPaused_FunctionAddress, "bInPaused");
		SetPaused_bInPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPaused_FunctionAddress, "bInPaused", Classes.FBoolProperty);
		SetPaused_IsValid = SetPaused_FunctionAddress != IntPtr.Zero && SetPaused_bInPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetPaused", SetPaused_IsValid);
		SetNiagaraVariableVec4_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableVec4");
		SetNiagaraVariableVec4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableVec4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec4_InVariableName_PropertyAddress, SetNiagaraVariableVec4_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec4_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec4_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec4_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec4_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec4_InValue_PropertyAddress, SetNiagaraVariableVec4_FunctionAddress, "InValue");
		SetNiagaraVariableVec4_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec4_FunctionAddress, "InValue");
		SetNiagaraVariableVec4_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec4_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariableVec4_IsValid = SetNiagaraVariableVec4_FunctionAddress != IntPtr.Zero && SetNiagaraVariableVec4_InVariableName_IsValid && SetNiagaraVariableVec4_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec4", SetNiagaraVariableVec4_IsValid);
		SetNiagaraVariableVec3_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableVec3");
		SetNiagaraVariableVec3_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableVec3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec3_InVariableName_PropertyAddress, SetNiagaraVariableVec3_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec3_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec3_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec3_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec3_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec3_InValue_PropertyAddress, SetNiagaraVariableVec3_FunctionAddress, "InValue");
		SetNiagaraVariableVec3_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec3_FunctionAddress, "InValue");
		SetNiagaraVariableVec3_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec3_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariableVec3_IsValid = SetNiagaraVariableVec3_FunctionAddress != IntPtr.Zero && SetNiagaraVariableVec3_InVariableName_IsValid && SetNiagaraVariableVec3_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec3", SetNiagaraVariableVec3_IsValid);
		SetNiagaraVariableVec2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableVec2");
		SetNiagaraVariableVec2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableVec2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec2_InVariableName_PropertyAddress, SetNiagaraVariableVec2_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec2_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec2_FunctionAddress, "InVariableName");
		SetNiagaraVariableVec2_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec2_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableVec2_InValue_PropertyAddress, SetNiagaraVariableVec2_FunctionAddress, "InValue");
		SetNiagaraVariableVec2_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableVec2_FunctionAddress, "InValue");
		SetNiagaraVariableVec2_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableVec2_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariableVec2_IsValid = SetNiagaraVariableVec2_FunctionAddress != IntPtr.Zero && SetNiagaraVariableVec2_InVariableName_IsValid && SetNiagaraVariableVec2_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableVec2", SetNiagaraVariableVec2_IsValid);
		SetNiagaraVariableQuat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableQuat");
		SetNiagaraVariableQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableQuat_InVariableName_PropertyAddress, SetNiagaraVariableQuat_FunctionAddress, "InVariableName");
		SetNiagaraVariableQuat_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableQuat_FunctionAddress, "InVariableName");
		SetNiagaraVariableQuat_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableQuat_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableQuat_InValue_PropertyAddress, SetNiagaraVariableQuat_FunctionAddress, "InValue");
		SetNiagaraVariableQuat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableQuat_FunctionAddress, "InValue");
		SetNiagaraVariableQuat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableQuat_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariableQuat_IsValid = SetNiagaraVariableQuat_FunctionAddress != IntPtr.Zero && SetNiagaraVariableQuat_InVariableName_IsValid && SetNiagaraVariableQuat_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableQuat", SetNiagaraVariableQuat_IsValid);
		SetNiagaraVariablePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariablePosition");
		SetNiagaraVariablePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariablePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariablePosition_InVariableName_PropertyAddress, SetNiagaraVariablePosition_FunctionAddress, "InVariableName");
		SetNiagaraVariablePosition_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariablePosition_FunctionAddress, "InVariableName");
		SetNiagaraVariablePosition_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariablePosition_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariablePosition_InValue_PropertyAddress, SetNiagaraVariablePosition_FunctionAddress, "InValue");
		SetNiagaraVariablePosition_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariablePosition_FunctionAddress, "InValue");
		SetNiagaraVariablePosition_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariablePosition_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariablePosition_IsValid = SetNiagaraVariablePosition_FunctionAddress != IntPtr.Zero && SetNiagaraVariablePosition_InVariableName_IsValid && SetNiagaraVariablePosition_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariablePosition", SetNiagaraVariablePosition_IsValid);
		SetNiagaraVariableObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableObject");
		SetNiagaraVariableObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableObject_InVariableName_PropertyAddress, SetNiagaraVariableObject_FunctionAddress, "InVariableName");
		SetNiagaraVariableObject_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableObject_FunctionAddress, "InVariableName");
		SetNiagaraVariableObject_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableObject_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableObject_Object_PropertyAddress, SetNiagaraVariableObject_FunctionAddress, "Object");
		SetNiagaraVariableObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableObject_FunctionAddress, "Object");
		SetNiagaraVariableObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableObject_FunctionAddress, "Object", Classes.FObjectProperty);
		SetNiagaraVariableObject_IsValid = SetNiagaraVariableObject_FunctionAddress != IntPtr.Zero && SetNiagaraVariableObject_InVariableName_IsValid && SetNiagaraVariableObject_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableObject", SetNiagaraVariableObject_IsValid);
		SetNiagaraVariableLinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableLinearColor");
		SetNiagaraVariableLinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableLinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableLinearColor_InVariableName_PropertyAddress, SetNiagaraVariableLinearColor_FunctionAddress, "InVariableName");
		SetNiagaraVariableLinearColor_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableLinearColor_FunctionAddress, "InVariableName");
		SetNiagaraVariableLinearColor_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableLinearColor_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableLinearColor_InValue_PropertyAddress, SetNiagaraVariableLinearColor_FunctionAddress, "InValue");
		SetNiagaraVariableLinearColor_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableLinearColor_FunctionAddress, "InValue");
		SetNiagaraVariableLinearColor_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableLinearColor_FunctionAddress, "InValue", Classes.FStructProperty);
		SetNiagaraVariableLinearColor_IsValid = SetNiagaraVariableLinearColor_FunctionAddress != IntPtr.Zero && SetNiagaraVariableLinearColor_InVariableName_IsValid && SetNiagaraVariableLinearColor_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableLinearColor", SetNiagaraVariableLinearColor_IsValid);
		SetNiagaraVariableInt_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableInt");
		SetNiagaraVariableInt_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableInt_InVariableName_PropertyAddress, SetNiagaraVariableInt_FunctionAddress, "InVariableName");
		SetNiagaraVariableInt_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableInt_FunctionAddress, "InVariableName");
		SetNiagaraVariableInt_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableInt_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableInt_InValue_PropertyAddress, SetNiagaraVariableInt_FunctionAddress, "InValue");
		SetNiagaraVariableInt_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableInt_FunctionAddress, "InValue");
		SetNiagaraVariableInt_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableInt_FunctionAddress, "InValue", Classes.FIntProperty);
		SetNiagaraVariableInt_IsValid = SetNiagaraVariableInt_FunctionAddress != IntPtr.Zero && SetNiagaraVariableInt_InVariableName_IsValid && SetNiagaraVariableInt_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableInt", SetNiagaraVariableInt_IsValid);
		SetNiagaraVariableFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableFloat");
		SetNiagaraVariableFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableFloat_InVariableName_PropertyAddress, SetNiagaraVariableFloat_FunctionAddress, "InVariableName");
		SetNiagaraVariableFloat_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableFloat_FunctionAddress, "InVariableName");
		SetNiagaraVariableFloat_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableFloat_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableFloat_InValue_PropertyAddress, SetNiagaraVariableFloat_FunctionAddress, "InValue");
		SetNiagaraVariableFloat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableFloat_FunctionAddress, "InValue");
		SetNiagaraVariableFloat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableFloat_FunctionAddress, "InValue", Classes.FFloatProperty);
		SetNiagaraVariableFloat_IsValid = SetNiagaraVariableFloat_FunctionAddress != IntPtr.Zero && SetNiagaraVariableFloat_InVariableName_IsValid && SetNiagaraVariableFloat_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableFloat", SetNiagaraVariableFloat_IsValid);
		SetNiagaraVariableBool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableBool");
		SetNiagaraVariableBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableBool_InVariableName_PropertyAddress, SetNiagaraVariableBool_FunctionAddress, "InVariableName");
		SetNiagaraVariableBool_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableBool_FunctionAddress, "InVariableName");
		SetNiagaraVariableBool_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableBool_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableBool_InValue_PropertyAddress, SetNiagaraVariableBool_FunctionAddress, "InValue");
		SetNiagaraVariableBool_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableBool_FunctionAddress, "InValue");
		SetNiagaraVariableBool_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableBool_FunctionAddress, "InValue", Classes.FBoolProperty);
		SetNiagaraVariableBool_IsValid = SetNiagaraVariableBool_FunctionAddress != IntPtr.Zero && SetNiagaraVariableBool_InVariableName_IsValid && SetNiagaraVariableBool_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableBool", SetNiagaraVariableBool_IsValid);
		SetNiagaraVariableActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNiagaraVariableActor");
		SetNiagaraVariableActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraVariableActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableActor_InVariableName_PropertyAddress, SetNiagaraVariableActor_FunctionAddress, "InVariableName");
		SetNiagaraVariableActor_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableActor_FunctionAddress, "InVariableName");
		SetNiagaraVariableActor_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableActor_FunctionAddress, "InVariableName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraVariableActor_Actor_PropertyAddress, SetNiagaraVariableActor_FunctionAddress, "Actor");
		SetNiagaraVariableActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraVariableActor_FunctionAddress, "Actor");
		SetNiagaraVariableActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraVariableActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetNiagaraVariableActor_IsValid = SetNiagaraVariableActor_FunctionAddress != IntPtr.Zero && SetNiagaraVariableActor_InVariableName_IsValid && SetNiagaraVariableActor_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetNiagaraVariableActor", SetNiagaraVariableActor_IsValid);
		SetMaxSimTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxSimTime");
		SetMaxSimTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxSimTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxSimTime_InMaxTime_PropertyAddress, SetMaxSimTime_FunctionAddress, "InMaxTime");
		SetMaxSimTime_InMaxTime_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxSimTime_FunctionAddress, "InMaxTime");
		SetMaxSimTime_InMaxTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxSimTime_FunctionAddress, "InMaxTime", Classes.FFloatProperty);
		SetMaxSimTime_IsValid = SetMaxSimTime_FunctionAddress != IntPtr.Zero && SetMaxSimTime_InMaxTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetMaxSimTime", SetMaxSimTime_IsValid);
		SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLockDesiredAgeDeltaTimeToSeekDelta");
		SetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_PropertyAddress, SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "bLock");
		SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_Offset = NativeReflectionCached.GetPropertyOffset(SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "bLock");
		SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "bLock", Classes.FBoolProperty);
		SetLockDesiredAgeDeltaTimeToSeekDelta_IsValid = SetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress != IntPtr.Zero && SetLockDesiredAgeDeltaTimeToSeekDelta_bLock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetLockDesiredAgeDeltaTimeToSeekDelta", SetLockDesiredAgeDeltaTimeToSeekDelta_IsValid);
		SetGpuComputeDebug_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGpuComputeDebug");
		SetGpuComputeDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGpuComputeDebug_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGpuComputeDebug_bEnableDebug_PropertyAddress, SetGpuComputeDebug_FunctionAddress, "bEnableDebug");
		SetGpuComputeDebug_bEnableDebug_Offset = NativeReflectionCached.GetPropertyOffset(SetGpuComputeDebug_FunctionAddress, "bEnableDebug");
		SetGpuComputeDebug_bEnableDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGpuComputeDebug_FunctionAddress, "bEnableDebug", Classes.FBoolProperty);
		SetGpuComputeDebug_IsValid = SetGpuComputeDebug_FunctionAddress != IntPtr.Zero && SetGpuComputeDebug_bEnableDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetGpuComputeDebug", SetGpuComputeDebug_IsValid);
		SetForceSolo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceSolo");
		SetForceSolo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceSolo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceSolo_bInForceSolo_PropertyAddress, SetForceSolo_FunctionAddress, "bInForceSolo");
		SetForceSolo_bInForceSolo_Offset = NativeReflectionCached.GetPropertyOffset(SetForceSolo_FunctionAddress, "bInForceSolo");
		SetForceSolo_bInForceSolo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceSolo_FunctionAddress, "bInForceSolo", Classes.FBoolProperty);
		SetForceSolo_IsValid = SetForceSolo_FunctionAddress != IntPtr.Zero && SetForceSolo_bInForceSolo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetForceSolo", SetForceSolo_IsValid);
		SetForceLocalPlayerEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceLocalPlayerEffect");
		SetForceLocalPlayerEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceLocalPlayerEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceLocalPlayerEffect_bIsPlayerEffect_PropertyAddress, SetForceLocalPlayerEffect_FunctionAddress, "bIsPlayerEffect");
		SetForceLocalPlayerEffect_bIsPlayerEffect_Offset = NativeReflectionCached.GetPropertyOffset(SetForceLocalPlayerEffect_FunctionAddress, "bIsPlayerEffect");
		SetForceLocalPlayerEffect_bIsPlayerEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceLocalPlayerEffect_FunctionAddress, "bIsPlayerEffect", Classes.FBoolProperty);
		SetForceLocalPlayerEffect_IsValid = SetForceLocalPlayerEffect_FunctionAddress != IntPtr.Zero && SetForceLocalPlayerEffect_bIsPlayerEffect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetForceLocalPlayerEffect", SetForceLocalPlayerEffect_IsValid);
		SetEmitterFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEmitterFixedBounds");
		SetEmitterFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEmitterFixedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEmitterFixedBounds_EmitterName_PropertyAddress, SetEmitterFixedBounds_FunctionAddress, "EmitterName");
		SetEmitterFixedBounds_EmitterName_Offset = NativeReflectionCached.GetPropertyOffset(SetEmitterFixedBounds_FunctionAddress, "EmitterName");
		SetEmitterFixedBounds_EmitterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEmitterFixedBounds_FunctionAddress, "EmitterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEmitterFixedBounds_LocalBounds_PropertyAddress, SetEmitterFixedBounds_FunctionAddress, "LocalBounds");
		SetEmitterFixedBounds_LocalBounds_Offset = NativeReflectionCached.GetPropertyOffset(SetEmitterFixedBounds_FunctionAddress, "LocalBounds");
		SetEmitterFixedBounds_LocalBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEmitterFixedBounds_FunctionAddress, "LocalBounds", Classes.FStructProperty);
		SetEmitterFixedBounds_IsValid = SetEmitterFixedBounds_FunctionAddress != IntPtr.Zero && SetEmitterFixedBounds_EmitterName_IsValid && SetEmitterFixedBounds_LocalBounds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetEmitterFixedBounds", SetEmitterFixedBounds_IsValid);
		SetDesiredAge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDesiredAge");
		SetDesiredAge_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredAge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredAge_InDesiredAge_PropertyAddress, SetDesiredAge_FunctionAddress, "InDesiredAge");
		SetDesiredAge_InDesiredAge_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredAge_FunctionAddress, "InDesiredAge");
		SetDesiredAge_InDesiredAge_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredAge_FunctionAddress, "InDesiredAge", Classes.FFloatProperty);
		SetDesiredAge_IsValid = SetDesiredAge_FunctionAddress != IntPtr.Zero && SetDesiredAge_InDesiredAge_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetDesiredAge", SetDesiredAge_IsValid);
		SetCustomTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomTimeDilation");
		SetCustomTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTimeDilation_Dilation_PropertyAddress, SetCustomTimeDilation_FunctionAddress, "Dilation");
		SetCustomTimeDilation_Dilation_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTimeDilation_FunctionAddress, "Dilation");
		SetCustomTimeDilation_Dilation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTimeDilation_FunctionAddress, "Dilation", Classes.FFloatProperty);
		SetCustomTimeDilation_IsValid = SetCustomTimeDilation_FunctionAddress != IntPtr.Zero && SetCustomTimeDilation_Dilation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetCustomTimeDilation", SetCustomTimeDilation_IsValid);
		SetCanRenderWhileSeeking_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCanRenderWhileSeeking");
		SetCanRenderWhileSeeking_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCanRenderWhileSeeking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_PropertyAddress, SetCanRenderWhileSeeking_FunctionAddress, "bInCanRenderWhileSeeking");
		SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_Offset = NativeReflectionCached.GetPropertyOffset(SetCanRenderWhileSeeking_FunctionAddress, "bInCanRenderWhileSeeking");
		SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanRenderWhileSeeking_FunctionAddress, "bInCanRenderWhileSeeking", Classes.FBoolProperty);
		SetCanRenderWhileSeeking_IsValid = SetCanRenderWhileSeeking_FunctionAddress != IntPtr.Zero && SetCanRenderWhileSeeking_bInCanRenderWhileSeeking_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetCanRenderWhileSeeking", SetCanRenderWhileSeeking_IsValid);
		SetAutoDestroy_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAutoDestroy");
		SetAutoDestroy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAutoDestroy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAutoDestroy_bInAutoDestroy_PropertyAddress, SetAutoDestroy_FunctionAddress, "bInAutoDestroy");
		SetAutoDestroy_bInAutoDestroy_Offset = NativeReflectionCached.GetPropertyOffset(SetAutoDestroy_FunctionAddress, "bInAutoDestroy");
		SetAutoDestroy_bInAutoDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAutoDestroy_FunctionAddress, "bInAutoDestroy", Classes.FBoolProperty);
		SetAutoDestroy_IsValid = SetAutoDestroy_FunctionAddress != IntPtr.Zero && SetAutoDestroy_bInAutoDestroy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetAutoDestroy", SetAutoDestroy_IsValid);
		SetAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAsset");
		SetAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAsset_InAsset_PropertyAddress, SetAsset_FunctionAddress, "InAsset");
		SetAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetAsset_FunctionAddress, "InAsset");
		SetAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAsset_bResetExistingOverrideParameters_PropertyAddress, SetAsset_FunctionAddress, "bResetExistingOverrideParameters");
		SetAsset_bResetExistingOverrideParameters_Offset = NativeReflectionCached.GetPropertyOffset(SetAsset_FunctionAddress, "bResetExistingOverrideParameters");
		SetAsset_bResetExistingOverrideParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAsset_FunctionAddress, "bResetExistingOverrideParameters", Classes.FBoolProperty);
		SetAsset_IsValid = SetAsset_FunctionAddress != IntPtr.Zero && SetAsset_InAsset_IsValid && SetAsset_bResetExistingOverrideParameters_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetAsset", SetAsset_IsValid);
		SetAllowScalability_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllowScalability");
		SetAllowScalability_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllowScalability_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllowScalability_bAllow_PropertyAddress, SetAllowScalability_FunctionAddress, "bAllow");
		SetAllowScalability_bAllow_Offset = NativeReflectionCached.GetPropertyOffset(SetAllowScalability_FunctionAddress, "bAllow");
		SetAllowScalability_bAllow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllowScalability_FunctionAddress, "bAllow", Classes.FBoolProperty);
		SetAllowScalability_IsValid = SetAllowScalability_FunctionAddress != IntPtr.Zero && SetAllowScalability_bAllow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetAllowScalability", SetAllowScalability_IsValid);
		SetAgeUpdateMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAgeUpdateMode");
		SetAgeUpdateMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAgeUpdateMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAgeUpdateMode_InAgeUpdateMode_PropertyAddress, SetAgeUpdateMode_FunctionAddress, "InAgeUpdateMode");
		SetAgeUpdateMode_InAgeUpdateMode_Offset = NativeReflectionCached.GetPropertyOffset(SetAgeUpdateMode_FunctionAddress, "InAgeUpdateMode");
		SetAgeUpdateMode_InAgeUpdateMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAgeUpdateMode_FunctionAddress, "InAgeUpdateMode", Classes.FEnumProperty);
		SetAgeUpdateMode_IsValid = SetAgeUpdateMode_FunctionAddress != IntPtr.Zero && SetAgeUpdateMode_InAgeUpdateMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SetAgeUpdateMode", SetAgeUpdateMode_IsValid);
		SeekToDesiredAge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SeekToDesiredAge");
		SeekToDesiredAge_ParamsSize = NativeReflection.GetFunctionParamsSize(SeekToDesiredAge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SeekToDesiredAge_InDesiredAge_PropertyAddress, SeekToDesiredAge_FunctionAddress, "InDesiredAge");
		SeekToDesiredAge_InDesiredAge_Offset = NativeReflectionCached.GetPropertyOffset(SeekToDesiredAge_FunctionAddress, "InDesiredAge");
		SeekToDesiredAge_InDesiredAge_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekToDesiredAge_FunctionAddress, "InDesiredAge", Classes.FFloatProperty);
		SeekToDesiredAge_IsValid = SeekToDesiredAge_FunctionAddress != IntPtr.Zero && SeekToDesiredAge_InDesiredAge_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:SeekToDesiredAge", SeekToDesiredAge_IsValid);
		ResetSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetSystem");
		ResetSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetSystem_FunctionAddress);
		ResetSystem_IsValid = ResetSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:ResetSystem", ResetSystem_IsValid);
		ReinitializeSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReinitializeSystem");
		ReinitializeSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ReinitializeSystem_FunctionAddress);
		ReinitializeSystem_IsValid = ReinitializeSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:ReinitializeSystem", ReinitializeSystem_IsValid);
		IsPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPaused");
		IsPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPaused_ReturnValue_PropertyAddress, IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPaused_IsValid = IsPaused_FunctionAddress != IntPtr.Zero && IsPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:IsPaused", IsPaused_IsValid);
		InitForPerformanceBaseline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitForPerformanceBaseline");
		InitForPerformanceBaseline_ParamsSize = NativeReflection.GetFunctionParamsSize(InitForPerformanceBaseline_FunctionAddress);
		InitForPerformanceBaseline_IsValid = InitForPerformanceBaseline_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:InitForPerformanceBaseline", InitForPerformanceBaseline_IsValid);
		GetTickBehavior_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTickBehavior");
		GetTickBehavior_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTickBehavior_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTickBehavior_ReturnValue_PropertyAddress, GetTickBehavior_FunctionAddress, "ReturnValue");
		GetTickBehavior_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTickBehavior_FunctionAddress, "ReturnValue");
		GetTickBehavior_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickBehavior_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetTickBehavior_IsValid = GetTickBehavior_FunctionAddress != IntPtr.Zero && GetTickBehavior_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetTickBehavior", GetTickBehavior_IsValid);
		GetSystemFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSystemFixedBounds");
		GetSystemFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSystemFixedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSystemFixedBounds_ReturnValue_PropertyAddress, GetSystemFixedBounds_FunctionAddress, "ReturnValue");
		GetSystemFixedBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSystemFixedBounds_FunctionAddress, "ReturnValue");
		GetSystemFixedBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSystemFixedBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSystemFixedBounds_IsValid = GetSystemFixedBounds_FunctionAddress != IntPtr.Zero && GetSystemFixedBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetSystemFixedBounds", GetSystemFixedBounds_IsValid);
		GetSeekDelta_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSeekDelta");
		GetSeekDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeekDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSeekDelta_ReturnValue_PropertyAddress, GetSeekDelta_FunctionAddress, "ReturnValue");
		GetSeekDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSeekDelta_FunctionAddress, "ReturnValue");
		GetSeekDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeekDelta_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSeekDelta_IsValid = GetSeekDelta_FunctionAddress != IntPtr.Zero && GetSeekDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetSeekDelta", GetSeekDelta_IsValid);
		GetRandomSeedOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomSeedOffset");
		GetRandomSeedOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomSeedOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomSeedOffset_ReturnValue_PropertyAddress, GetRandomSeedOffset_FunctionAddress, "ReturnValue");
		GetRandomSeedOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomSeedOffset_FunctionAddress, "ReturnValue");
		GetRandomSeedOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomSeedOffset_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRandomSeedOffset_IsValid = GetRandomSeedOffset_FunctionAddress != IntPtr.Zero && GetRandomSeedOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetRandomSeedOffset", GetRandomSeedOffset_IsValid);
		GetPreviewLODDistanceEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreviewLODDistanceEnabled");
		GetPreviewLODDistanceEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewLODDistanceEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewLODDistanceEnabled_ReturnValue_PropertyAddress, GetPreviewLODDistanceEnabled_FunctionAddress, "ReturnValue");
		GetPreviewLODDistanceEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewLODDistanceEnabled_FunctionAddress, "ReturnValue");
		GetPreviewLODDistanceEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewLODDistanceEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPreviewLODDistanceEnabled_IsValid = GetPreviewLODDistanceEnabled_FunctionAddress != IntPtr.Zero && GetPreviewLODDistanceEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetPreviewLODDistanceEnabled", GetPreviewLODDistanceEnabled_IsValid);
		GetPreviewLODDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreviewLODDistance");
		GetPreviewLODDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewLODDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewLODDistance_ReturnValue_PropertyAddress, GetPreviewLODDistance_FunctionAddress, "ReturnValue");
		GetPreviewLODDistance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewLODDistance_FunctionAddress, "ReturnValue");
		GetPreviewLODDistance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewLODDistance_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPreviewLODDistance_IsValid = GetPreviewLODDistance_FunctionAddress != IntPtr.Zero && GetPreviewLODDistance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetPreviewLODDistance", GetPreviewLODDistance_IsValid);
		GetMaxSimTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxSimTime");
		GetMaxSimTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxSimTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxSimTime_ReturnValue_PropertyAddress, GetMaxSimTime_FunctionAddress, "ReturnValue");
		GetMaxSimTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxSimTime_FunctionAddress, "ReturnValue");
		GetMaxSimTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxSimTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxSimTime_IsValid = GetMaxSimTime_FunctionAddress != IntPtr.Zero && GetMaxSimTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetMaxSimTime", GetMaxSimTime_IsValid);
		GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLockDesiredAgeDeltaTimeToSeekDelta");
		GetLockDesiredAgeDeltaTimeToSeekDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_PropertyAddress, GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "ReturnValue");
		GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "ReturnValue");
		GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLockDesiredAgeDeltaTimeToSeekDelta_IsValid = GetLockDesiredAgeDeltaTimeToSeekDelta_FunctionAddress != IntPtr.Zero && GetLockDesiredAgeDeltaTimeToSeekDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetLockDesiredAgeDeltaTimeToSeekDelta", GetLockDesiredAgeDeltaTimeToSeekDelta_IsValid);
		GetForceSolo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetForceSolo");
		GetForceSolo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForceSolo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForceSolo_ReturnValue_PropertyAddress, GetForceSolo_FunctionAddress, "ReturnValue");
		GetForceSolo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForceSolo_FunctionAddress, "ReturnValue");
		GetForceSolo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForceSolo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetForceSolo_IsValid = GetForceSolo_FunctionAddress != IntPtr.Zero && GetForceSolo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetForceSolo", GetForceSolo_IsValid);
		GetForceLocalPlayerEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetForceLocalPlayerEffect");
		GetForceLocalPlayerEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForceLocalPlayerEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForceLocalPlayerEffect_ReturnValue_PropertyAddress, GetForceLocalPlayerEffect_FunctionAddress, "ReturnValue");
		GetForceLocalPlayerEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForceLocalPlayerEffect_FunctionAddress, "ReturnValue");
		GetForceLocalPlayerEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForceLocalPlayerEffect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetForceLocalPlayerEffect_IsValid = GetForceLocalPlayerEffect_FunctionAddress != IntPtr.Zero && GetForceLocalPlayerEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetForceLocalPlayerEffect", GetForceLocalPlayerEffect_IsValid);
		GetEmitterFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEmitterFixedBounds");
		GetEmitterFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEmitterFixedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEmitterFixedBounds_EmitterName_PropertyAddress, GetEmitterFixedBounds_FunctionAddress, "EmitterName");
		GetEmitterFixedBounds_EmitterName_Offset = NativeReflectionCached.GetPropertyOffset(GetEmitterFixedBounds_FunctionAddress, "EmitterName");
		GetEmitterFixedBounds_EmitterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEmitterFixedBounds_FunctionAddress, "EmitterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEmitterFixedBounds_ReturnValue_PropertyAddress, GetEmitterFixedBounds_FunctionAddress, "ReturnValue");
		GetEmitterFixedBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEmitterFixedBounds_FunctionAddress, "ReturnValue");
		GetEmitterFixedBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEmitterFixedBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEmitterFixedBounds_IsValid = GetEmitterFixedBounds_FunctionAddress != IntPtr.Zero && GetEmitterFixedBounds_EmitterName_IsValid && GetEmitterFixedBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetEmitterFixedBounds", GetEmitterFixedBounds_IsValid);
		GetDesiredAge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredAge");
		GetDesiredAge_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredAge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredAge_ReturnValue_PropertyAddress, GetDesiredAge_FunctionAddress, "ReturnValue");
		GetDesiredAge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredAge_FunctionAddress, "ReturnValue");
		GetDesiredAge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredAge_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDesiredAge_IsValid = GetDesiredAge_FunctionAddress != IntPtr.Zero && GetDesiredAge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetDesiredAge", GetDesiredAge_IsValid);
		GetDataInterface_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDataInterface");
		GetDataInterface_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataInterface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataInterface_Name_PropertyAddress, GetDataInterface_FunctionAddress, "Name");
		GetDataInterface_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetDataInterface_FunctionAddress, "Name");
		GetDataInterface_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataInterface_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataInterface_ReturnValue_PropertyAddress, GetDataInterface_FunctionAddress, "ReturnValue");
		GetDataInterface_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDataInterface_FunctionAddress, "ReturnValue");
		GetDataInterface_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataInterface_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDataInterface_IsValid = GetDataInterface_FunctionAddress != IntPtr.Zero && GetDataInterface_Name_IsValid && GetDataInterface_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetDataInterface", GetDataInterface_IsValid);
		GetCustomTimeDilation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCustomTimeDilation");
		GetCustomTimeDilation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomTimeDilation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomTimeDilation_ReturnValue_PropertyAddress, GetCustomTimeDilation_FunctionAddress, "ReturnValue");
		GetCustomTimeDilation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomTimeDilation_FunctionAddress, "ReturnValue");
		GetCustomTimeDilation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomTimeDilation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCustomTimeDilation_IsValid = GetCustomTimeDilation_FunctionAddress != IntPtr.Zero && GetCustomTimeDilation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetCustomTimeDilation", GetCustomTimeDilation_IsValid);
		GetAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAsset");
		GetAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsset_ReturnValue_PropertyAddress, GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAsset_IsValid = GetAsset_FunctionAddress != IntPtr.Zero && GetAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetAsset", GetAsset_IsValid);
		GetAllowScalability_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllowScalability");
		GetAllowScalability_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllowScalability_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllowScalability_ReturnValue_PropertyAddress, GetAllowScalability_FunctionAddress, "ReturnValue");
		GetAllowScalability_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllowScalability_FunctionAddress, "ReturnValue");
		GetAllowScalability_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllowScalability_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllowScalability_IsValid = GetAllowScalability_FunctionAddress != IntPtr.Zero && GetAllowScalability_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetAllowScalability", GetAllowScalability_IsValid);
		GetAgeUpdateMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAgeUpdateMode");
		GetAgeUpdateMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAgeUpdateMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAgeUpdateMode_ReturnValue_PropertyAddress, GetAgeUpdateMode_FunctionAddress, "ReturnValue");
		GetAgeUpdateMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAgeUpdateMode_FunctionAddress, "ReturnValue");
		GetAgeUpdateMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAgeUpdateMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAgeUpdateMode_IsValid = GetAgeUpdateMode_FunctionAddress != IntPtr.Zero && GetAgeUpdateMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:GetAgeUpdateMode", GetAgeUpdateMode_IsValid);
		ClearSystemFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSystemFixedBounds");
		ClearSystemFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSystemFixedBounds_FunctionAddress);
		ClearSystemFixedBounds_IsValid = ClearSystemFixedBounds_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:ClearSystemFixedBounds", ClearSystemFixedBounds_IsValid);
		ClearEmitterFixedBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearEmitterFixedBounds");
		ClearEmitterFixedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearEmitterFixedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearEmitterFixedBounds_EmitterName_PropertyAddress, ClearEmitterFixedBounds_FunctionAddress, "EmitterName");
		ClearEmitterFixedBounds_EmitterName_Offset = NativeReflectionCached.GetPropertyOffset(ClearEmitterFixedBounds_FunctionAddress, "EmitterName");
		ClearEmitterFixedBounds_EmitterName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearEmitterFixedBounds_FunctionAddress, "EmitterName", Classes.FNameProperty);
		ClearEmitterFixedBounds_IsValid = ClearEmitterFixedBounds_FunctionAddress != IntPtr.Zero && ClearEmitterFixedBounds_EmitterName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:ClearEmitterFixedBounds", ClearEmitterFixedBounds_IsValid);
		AdvanceSimulationByTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AdvanceSimulationByTime");
		AdvanceSimulationByTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceSimulationByTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceSimulationByTime_SimulateTime_PropertyAddress, AdvanceSimulationByTime_FunctionAddress, "SimulateTime");
		AdvanceSimulationByTime_SimulateTime_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceSimulationByTime_FunctionAddress, "SimulateTime");
		AdvanceSimulationByTime_SimulateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceSimulationByTime_FunctionAddress, "SimulateTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceSimulationByTime_TickDeltaSeconds_PropertyAddress, AdvanceSimulationByTime_FunctionAddress, "TickDeltaSeconds");
		AdvanceSimulationByTime_TickDeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceSimulationByTime_FunctionAddress, "TickDeltaSeconds");
		AdvanceSimulationByTime_TickDeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceSimulationByTime_FunctionAddress, "TickDeltaSeconds", Classes.FFloatProperty);
		AdvanceSimulationByTime_IsValid = AdvanceSimulationByTime_FunctionAddress != IntPtr.Zero && AdvanceSimulationByTime_SimulateTime_IsValid && AdvanceSimulationByTime_TickDeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:AdvanceSimulationByTime", AdvanceSimulationByTime_IsValid);
		AdvanceSimulation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AdvanceSimulation");
		AdvanceSimulation_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceSimulation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceSimulation_TickCount_PropertyAddress, AdvanceSimulation_FunctionAddress, "TickCount");
		AdvanceSimulation_TickCount_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceSimulation_FunctionAddress, "TickCount");
		AdvanceSimulation_TickCount_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceSimulation_FunctionAddress, "TickCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceSimulation_TickDeltaSeconds_PropertyAddress, AdvanceSimulation_FunctionAddress, "TickDeltaSeconds");
		AdvanceSimulation_TickDeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceSimulation_FunctionAddress, "TickDeltaSeconds");
		AdvanceSimulation_TickDeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceSimulation_FunctionAddress, "TickDeltaSeconds", Classes.FFloatProperty);
		AdvanceSimulation_IsValid = AdvanceSimulation_FunctionAddress != IntPtr.Zero && AdvanceSimulation_TickCount_IsValid && AdvanceSimulation_TickDeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraComponent:AdvanceSimulation", AdvanceSimulation_IsValid);
	}
}
