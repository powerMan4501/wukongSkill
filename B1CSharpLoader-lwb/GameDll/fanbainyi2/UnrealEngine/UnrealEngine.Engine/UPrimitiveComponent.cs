using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PrimitiveComponent", "Engine", UnrealModuleType.Engine)]
public class UPrimitiveComponent : USceneComponent, INavRelevantInterface, IInterface, IInterface_AsyncCompilation
{
	private static bool MinDrawDistance_IsValid;

	private static int MinDrawDistance_Offset;

	private static bool LDMaxDrawDistance_IsValid;

	private static int LDMaxDrawDistance_Offset;

	private static bool CachedMaxDrawDistance_IsValid;

	private static int CachedMaxDrawDistance_Offset;

	private static bool IndirectLightingCacheQuality_IsValid;

	private static FFieldAddress IndirectLightingCacheQuality_PropertyAddress;

	private static int IndirectLightingCacheQuality_Offset;

	private static bool LightmapType_IsValid;

	private static FFieldAddress LightmapType_PropertyAddress;

	private static int LightmapType_Offset;

	private static bool EnableAutoLODGeneration_IsValid;

	private static FFieldAddress EnableAutoLODGeneration_PropertyAddress;

	private static int EnableAutoLODGeneration_Offset;

	private static bool ExcludeForSpecificHLODLevels_IsValid;

	private static FFieldAddress ExcludeForSpecificHLODLevels_PropertyAddress;

	private static int ExcludeForSpecificHLODLevels_Offset;

	private TArrayReadWriteMarshaler<int> ExcludeForSpecificHLODLevels_MarshalerCached;

	private static bool HLODBatchingPolicy_IsValid;

	private static FFieldAddress HLODBatchingPolicy_PropertyAddress;

	private static int HLODBatchingPolicy_Offset;

	private static bool NeverDistanceCull_IsValid;

	private static FFieldAddress NeverDistanceCull_PropertyAddress;

	private static int NeverDistanceCull_Offset;

	private static bool AlwaysCreatePhysicsState_IsValid;

	private static FFieldAddress AlwaysCreatePhysicsState_PropertyAddress;

	private static int AlwaysCreatePhysicsState_Offset;

	private static bool MultiBodyOverlap_IsValid;

	private static FFieldAddress MultiBodyOverlap_PropertyAddress;

	private static int MultiBodyOverlap_Offset;

	private static bool TraceComplexOnMove_IsValid;

	private static FFieldAddress TraceComplexOnMove_PropertyAddress;

	private static int TraceComplexOnMove_Offset;

	private static bool ReturnMaterialOnMove_IsValid;

	private static FFieldAddress ReturnMaterialOnMove_PropertyAddress;

	private static int ReturnMaterialOnMove_Offset;

	private static bool AllowCullDistanceVolume_IsValid;

	private static FFieldAddress AllowCullDistanceVolume_PropertyAddress;

	private static int AllowCullDistanceVolume_Offset;

	private static bool VisibleInReflectionCaptures_IsValid;

	private static FFieldAddress VisibleInReflectionCaptures_PropertyAddress;

	private static int VisibleInReflectionCaptures_Offset;

	private static bool VisibleInRealTimeSkyCaptures_IsValid;

	private static FFieldAddress VisibleInRealTimeSkyCaptures_PropertyAddress;

	private static int VisibleInRealTimeSkyCaptures_Offset;

	private static bool VisibleInRayTracing_IsValid;

	private static FFieldAddress VisibleInRayTracing_PropertyAddress;

	private static int VisibleInRayTracing_Offset;

	private static bool CastHybridRayTracingShadow_IsValid;

	private static FFieldAddress CastHybridRayTracingShadow_PropertyAddress;

	private static int CastHybridRayTracingShadow_Offset;

	private static bool SkeletalMeshOutputRTDepthMaskInDepthPass_IsValid;

	private static FFieldAddress SkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress;

	private static int SkeletalMeshOutputRTDepthMaskInDepthPass_Offset;

	private static bool RenderInMainPass_IsValid;

	private static FFieldAddress RenderInMainPass_PropertyAddress;

	private static int RenderInMainPass_Offset;

	private static bool RenderInMBOIT_IsValid;

	private static FFieldAddress RenderInMBOIT_PropertyAddress;

	private static int RenderInMBOIT_Offset;

	private static bool RenderTranslucentDepth_IsValid;

	private static FFieldAddress RenderTranslucentDepth_PropertyAddress;

	private static int RenderTranslucentDepth_Offset;

	private static bool TranslucentDepthOpacityMask_IsValid;

	private static int TranslucentDepthOpacityMask_Offset;

	private static bool PerObjectShadowResScale_IsValid;

	private static int PerObjectShadowResScale_Offset;

	private static bool RenderInDepthPass_IsValid;

	private static FFieldAddress RenderInDepthPass_PropertyAddress;

	private static int RenderInDepthPass_Offset;

	private static bool ReceivesDecals_IsValid;

	private static FFieldAddress ReceivesDecals_PropertyAddress;

	private static int ReceivesDecals_Offset;

	private static bool OwnerNoSee_IsValid;

	private static FFieldAddress OwnerNoSee_PropertyAddress;

	private static int OwnerNoSee_Offset;

	private static bool OnlyOwnerSee_IsValid;

	private static FFieldAddress OnlyOwnerSee_PropertyAddress;

	private static int OnlyOwnerSee_Offset;

	private static bool TreatAsBackgroundForOcclusion_IsValid;

	private static FFieldAddress TreatAsBackgroundForOcclusion_PropertyAddress;

	private static int TreatAsBackgroundForOcclusion_Offset;

	private static bool UseAsOccluder_IsValid;

	private static FFieldAddress UseAsOccluder_PropertyAddress;

	private static int UseAsOccluder_Offset;

	private static bool ForceMipStreaming_IsValid;

	private static FFieldAddress ForceMipStreaming_PropertyAddress;

	private static int ForceMipStreaming_Offset;

	private static bool CastShadow_IsValid;

	private static FFieldAddress CastShadow_PropertyAddress;

	private static int CastShadow_Offset;

	private static bool EmissiveLightSource_IsValid;

	private static FFieldAddress EmissiveLightSource_PropertyAddress;

	private static int EmissiveLightSource_Offset;

	private static bool AffectDynamicIndirectLighting_IsValid;

	private static FFieldAddress AffectDynamicIndirectLighting_PropertyAddress;

	private static int AffectDynamicIndirectLighting_Offset;

	private static bool AffectDistanceFieldLighting_IsValid;

	private static FFieldAddress AffectDistanceFieldLighting_PropertyAddress;

	private static int AffectDistanceFieldLighting_Offset;

	private static bool CastDynamicShadow_IsValid;

	private static FFieldAddress CastDynamicShadow_PropertyAddress;

	private static int CastDynamicShadow_Offset;

	private static bool CastStaticShadow_IsValid;

	private static FFieldAddress CastStaticShadow_PropertyAddress;

	private static int CastStaticShadow_Offset;

	private static bool WPOEvaluateDistanceScale_IsValid;

	private static int WPOEvaluateDistanceScale_Offset;

	private static bool CastVolumetricTranslucentShadow_IsValid;

	private static FFieldAddress CastVolumetricTranslucentShadow_PropertyAddress;

	private static int CastVolumetricTranslucentShadow_Offset;

	private static bool CastContactShadow_IsValid;

	private static FFieldAddress CastContactShadow_PropertyAddress;

	private static int CastContactShadow_Offset;

	private static bool SelfShadowOnly_IsValid;

	private static FFieldAddress SelfShadowOnly_PropertyAddress;

	private static int SelfShadowOnly_Offset;

	private static bool CastFarShadow_IsValid;

	private static FFieldAddress CastFarShadow_PropertyAddress;

	private static int CastFarShadow_Offset;

	private static bool CastInsetShadow_IsValid;

	private static FFieldAddress CastInsetShadow_PropertyAddress;

	private static int CastInsetShadow_Offset;

	private static bool CastCinematicShadow_IsValid;

	private static FFieldAddress CastCinematicShadow_PropertyAddress;

	private static int CastCinematicShadow_Offset;

	private static bool CastHiddenShadow_IsValid;

	private static FFieldAddress CastHiddenShadow_PropertyAddress;

	private static int CastHiddenShadow_Offset;

	private static bool CastShadowAsTwoSided_IsValid;

	private static FFieldAddress CastShadowAsTwoSided_PropertyAddress;

	private static int CastShadowAsTwoSided_Offset;

	private static bool LightAttachmentsAsGroup_IsValid;

	private static FFieldAddress LightAttachmentsAsGroup_PropertyAddress;

	private static int LightAttachmentsAsGroup_Offset;

	private static bool ExcludeFromLightAttachmentGroup_IsValid;

	private static FFieldAddress ExcludeFromLightAttachmentGroup_PropertyAddress;

	private static int ExcludeFromLightAttachmentGroup_Offset;

	private static bool ReceiveMobileCSMShadows_IsValid;

	private static FFieldAddress ReceiveMobileCSMShadows_PropertyAddress;

	private static int ReceiveMobileCSMShadows_Offset;

	private static bool SingleSampleShadowFromStationaryLights_IsValid;

	private static FFieldAddress SingleSampleShadowFromStationaryLights_PropertyAddress;

	private static int SingleSampleShadowFromStationaryLights_Offset;

	private static bool IgnoreRadialImpulse_IsValid;

	private static FFieldAddress IgnoreRadialImpulse_PropertyAddress;

	private static int IgnoreRadialImpulse_Offset;

	private static bool IgnoreRadialForce_IsValid;

	private static FFieldAddress IgnoreRadialForce_PropertyAddress;

	private static int IgnoreRadialForce_Offset;

	private static bool ApplyImpulseOnDamage_IsValid;

	private static FFieldAddress ApplyImpulseOnDamage_PropertyAddress;

	private static int ApplyImpulseOnDamage_Offset;

	private static bool ReplicatePhysicsToAutonomousProxy_IsValid;

	private static FFieldAddress ReplicatePhysicsToAutonomousProxy_PropertyAddress;

	private static int ReplicatePhysicsToAutonomousProxy_Offset;

	private static bool RenderCustomDepth_IsValid;

	private static FFieldAddress RenderCustomDepth_PropertyAddress;

	private static int RenderCustomDepth_Offset;

	private static bool VisibleInSceneCaptureOnly_IsValid;

	private static FFieldAddress VisibleInSceneCaptureOnly_PropertyAddress;

	private static int VisibleInSceneCaptureOnly_Offset;

	private static bool HiddenInSceneCapture_IsValid;

	private static FFieldAddress HiddenInSceneCapture_PropertyAddress;

	private static int HiddenInSceneCapture_Offset;

	private static bool RenderGSVoxelization_IsValid;

	private static FFieldAddress RenderGSVoxelization_PropertyAddress;

	private static int RenderGSVoxelization_Offset;

	private static bool EvaluateRayTracingWaterCaustics_IsValid;

	private static FFieldAddress EvaluateRayTracingWaterCaustics_PropertyAddress;

	private static int EvaluateRayTracingWaterCaustics_Offset;

	private static bool ForceRenderInLumenScene_IsValid;

	private static FFieldAddress ForceRenderInLumenScene_PropertyAddress;

	private static int ForceRenderInLumenScene_Offset;

	private static bool CanCharacterStepUpOn_IsValid;

	private static FFieldAddress CanCharacterStepUpOn_PropertyAddress;

	private static int CanCharacterStepUpOn_Offset;

	private static bool LightingChannels_IsValid;

	private static int LightingChannels_Offset;

	private static bool RayTracingGroupId_IsValid;

	private static int RayTracingGroupId_Offset;

	private static bool CustomDepthStencilValue_IsValid;

	private static int CustomDepthStencilValue_Offset;

	private static bool TranslucencySortPriority_IsValid;

	private static int TranslucencySortPriority_Offset;

	private static bool TranslucencySortDistanceOffset_IsValid;

	private static int TranslucencySortDistanceOffset_Offset;

	private static bool RuntimeVirtualTextures_IsValid;

	private static FFieldAddress RuntimeVirtualTextures_PropertyAddress;

	private static int RuntimeVirtualTextures_Offset;

	private TArrayReadWriteMarshaler<URuntimeVirtualTexture> RuntimeVirtualTextures_MarshalerCached;

	private static bool VirtualTextureRenderPassType_IsValid;

	private static FFieldAddress VirtualTextureRenderPassType_PropertyAddress;

	private static int VirtualTextureRenderPassType_Offset;

	private static bool BodyInstance_IsValid;

	private static int BodyInstance_Offset;

	private static bool OnComponentHit_IsValid;

	private static int OnComponentHit_Offset;

	private FComponentHitSignature OnComponentHit_DelegateCached;

	private static bool OnComponentBeginOverlap_IsValid;

	private static int OnComponentBeginOverlap_Offset;

	private FComponentBeginOverlapSignature OnComponentBeginOverlap_DelegateCached;

	private static bool OnComponentEndOverlap_IsValid;

	private static int OnComponentEndOverlap_Offset;

	private FComponentEndOverlapSignature OnComponentEndOverlap_DelegateCached;

	private static bool OnComponentWake_IsValid;

	private static int OnComponentWake_Offset;

	private FComponentWakeSignature OnComponentWake_DelegateCached;

	private static bool OnComponentSleep_IsValid;

	private static int OnComponentSleep_Offset;

	private FComponentSleepSignature OnComponentSleep_DelegateCached;

	private static bool OnBeginCursorOver_IsValid;

	private static int OnBeginCursorOver_Offset;

	private FComponentBeginCursorOverSignature OnBeginCursorOver_DelegateCached;

	private static bool OnEndCursorOver_IsValid;

	private static int OnEndCursorOver_Offset;

	private FComponentEndCursorOverSignature OnEndCursorOver_DelegateCached;

	private static bool OnClicked_IsValid;

	private static int OnClicked_Offset;

	private FComponentOnClickedSignature OnClicked_DelegateCached;

	private static bool OnReleased_IsValid;

	private static int OnReleased_Offset;

	private FComponentOnReleasedSignature OnReleased_DelegateCached;

	private static bool OnInputTouchBegin_IsValid;

	private static int OnInputTouchBegin_Offset;

	private FComponentOnInputTouchBeginSignature OnInputTouchBegin_DelegateCached;

	private static bool OnInputTouchEnd_IsValid;

	private static int OnInputTouchEnd_Offset;

	private FComponentOnInputTouchEndSignature OnInputTouchEnd_DelegateCached;

	private static bool OnInputTouchEnter_IsValid;

	private static int OnInputTouchEnter_Offset;

	private FComponentBeginTouchOverSignature OnInputTouchEnter_DelegateCached;

	private static bool OnInputTouchLeave_IsValid;

	private static int OnInputTouchLeave_Offset;

	private FComponentEndTouchOverSignature OnInputTouchLeave_DelegateCached;

	private static bool RayTracingGroupCullingPriority_IsValid;

	private static FFieldAddress RayTracingGroupCullingPriority_PropertyAddress;

	private static int RayTracingGroupCullingPriority_Offset;

	private static bool CustomDepthStencilWriteMask_IsValid;

	private static FFieldAddress CustomDepthStencilWriteMask_PropertyAddress;

	private static int CustomDepthStencilWriteMask_Offset;

	private static bool WasRecentlyRendered_IsValid;

	private static IntPtr WasRecentlyRendered_FunctionAddress;

	private static int WasRecentlyRendered_ParamsSize;

	private static bool WasRecentlyRendered_Tolerance_IsValid;

	private static FFieldAddress WasRecentlyRendered_Tolerance_PropertyAddress;

	private static int WasRecentlyRendered_Tolerance_Offset;

	private static bool WasRecentlyRendered_ReturnValue_IsValid;

	private static FFieldAddress WasRecentlyRendered_ReturnValue_PropertyAddress;

	private static int WasRecentlyRendered_ReturnValue_Offset;

	private static bool WakeRigidBody_IsValid;

	private static IntPtr WakeRigidBody_FunctionAddress;

	private static int WakeRigidBody_ParamsSize;

	private static bool WakeRigidBody_BoneName_IsValid;

	private static FFieldAddress WakeRigidBody_BoneName_PropertyAddress;

	private static int WakeRigidBody_BoneName_Offset;

	private static bool WakeAllRigidBodies_IsValid;

	private static IntPtr WakeAllRigidBodies_FunctionAddress;

	private static int WakeAllRigidBodies_ParamsSize;

	private static bool SetWalkableSlopeOverride_IsValid;

	private static IntPtr SetWalkableSlopeOverride_FunctionAddress;

	private static int SetWalkableSlopeOverride_ParamsSize;

	private static bool SetWalkableSlopeOverride_NewOverride_IsValid;

	private static FFieldAddress SetWalkableSlopeOverride_NewOverride_PropertyAddress;

	private static int SetWalkableSlopeOverride_NewOverride_Offset;

	private static bool SetVisibleInSceneCaptureOnly_IsValid;

	private static IntPtr SetVisibleInSceneCaptureOnly_FunctionAddress;

	private static int SetVisibleInSceneCaptureOnly_ParamsSize;

	private static bool SetVisibleInSceneCaptureOnly_bValue_IsValid;

	private static FFieldAddress SetVisibleInSceneCaptureOnly_bValue_PropertyAddress;

	private static int SetVisibleInSceneCaptureOnly_bValue_Offset;

	private static bool SetVisibleInRayTracing_IsValid;

	private static IntPtr SetVisibleInRayTracing_FunctionAddress;

	private static int SetVisibleInRayTracing_ParamsSize;

	private static bool SetVisibleInRayTracing_bNewVisibleInRayTracing_IsValid;

	private static FFieldAddress SetVisibleInRayTracing_bNewVisibleInRayTracing_PropertyAddress;

	private static int SetVisibleInRayTracing_bNewVisibleInRayTracing_Offset;

	private static bool SetVectorParameterForDefaultCustomPrimitiveData_IsValid;

	private static IntPtr SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress;

	private static int SetVectorParameterForDefaultCustomPrimitiveData_ParamsSize;

	private static bool SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress;

	private static int SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_Offset;

	private static bool SetVectorParameterForDefaultCustomPrimitiveData_Value_IsValid;

	private static FFieldAddress SetVectorParameterForDefaultCustomPrimitiveData_Value_PropertyAddress;

	private static int SetVectorParameterForDefaultCustomPrimitiveData_Value_Offset;

	private static bool SetVectorParameterForCustomPrimitiveData_IsValid;

	private static IntPtr SetVectorParameterForCustomPrimitiveData_FunctionAddress;

	private static int SetVectorParameterForCustomPrimitiveData_ParamsSize;

	private static bool SetVectorParameterForCustomPrimitiveData_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameterForCustomPrimitiveData_ParameterName_PropertyAddress;

	private static int SetVectorParameterForCustomPrimitiveData_ParameterName_Offset;

	private static bool SetVectorParameterForCustomPrimitiveData_Value_IsValid;

	private static FFieldAddress SetVectorParameterForCustomPrimitiveData_Value_PropertyAddress;

	private static int SetVectorParameterForCustomPrimitiveData_Value_Offset;

	private static bool SetUseCCD_IsValid;

	private static IntPtr SetUseCCD_FunctionAddress;

	private static int SetUseCCD_ParamsSize;

	private static bool SetUseCCD_InUseCCD_IsValid;

	private static FFieldAddress SetUseCCD_InUseCCD_PropertyAddress;

	private static int SetUseCCD_InUseCCD_Offset;

	private static bool SetUseCCD_BoneName_IsValid;

	private static FFieldAddress SetUseCCD_BoneName_PropertyAddress;

	private static int SetUseCCD_BoneName_Offset;

	private static bool SetTranslucentSortPriority_IsValid;

	private static IntPtr SetTranslucentSortPriority_FunctionAddress;

	private static int SetTranslucentSortPriority_ParamsSize;

	private static bool SetTranslucentSortPriority_NewTranslucentSortPriority_IsValid;

	private static FFieldAddress SetTranslucentSortPriority_NewTranslucentSortPriority_PropertyAddress;

	private static int SetTranslucentSortPriority_NewTranslucentSortPriority_Offset;

	private static bool SetTranslucencySortDistanceOffset_IsValid;

	private static IntPtr SetTranslucencySortDistanceOffset_FunctionAddress;

	private static int SetTranslucencySortDistanceOffset_ParamsSize;

	private static bool SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_IsValid;

	private static FFieldAddress SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_PropertyAddress;

	private static int SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_Offset;

	private static bool SetSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid;

	private static IntPtr SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress;

	private static int SetSkeletalMeshOutputRTDepthMaskInDepthPass_ParamsSize;

	private static bool SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid;

	private static FFieldAddress SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress;

	private static int SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_Offset;

	private static bool SetSingleSampleShadowFromStationaryLights_IsValid;

	private static IntPtr SetSingleSampleShadowFromStationaryLights_FunctionAddress;

	private static int SetSingleSampleShadowFromStationaryLights_ParamsSize;

	private static bool SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_IsValid;

	private static FFieldAddress SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_PropertyAddress;

	private static int SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_Offset;

	private static bool SetSimulatePhysics_IsValid;

	private static IntPtr SetSimulatePhysics_FunctionAddress;

	private static int SetSimulatePhysics_ParamsSize;

	private static bool SetSimulatePhysics_bSimulate_IsValid;

	private static FFieldAddress SetSimulatePhysics_bSimulate_PropertyAddress;

	private static int SetSimulatePhysics_bSimulate_Offset;

	private static bool SetScalarParameterForDefaultCustomPrimitiveData_IsValid;

	private static IntPtr SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress;

	private static int SetScalarParameterForDefaultCustomPrimitiveData_ParamsSize;

	private static bool SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_IsValid;

	private static FFieldAddress SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress;

	private static int SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_Offset;

	private static bool SetScalarParameterForDefaultCustomPrimitiveData_Value_IsValid;

	private static FFieldAddress SetScalarParameterForDefaultCustomPrimitiveData_Value_PropertyAddress;

	private static int SetScalarParameterForDefaultCustomPrimitiveData_Value_Offset;

	private static bool SetScalarParameterForCustomPrimitiveData_IsValid;

	private static IntPtr SetScalarParameterForCustomPrimitiveData_FunctionAddress;

	private static int SetScalarParameterForCustomPrimitiveData_ParamsSize;

	private static bool SetScalarParameterForCustomPrimitiveData_ParameterName_IsValid;

	private static FFieldAddress SetScalarParameterForCustomPrimitiveData_ParameterName_PropertyAddress;

	private static int SetScalarParameterForCustomPrimitiveData_ParameterName_Offset;

	private static bool SetScalarParameterForCustomPrimitiveData_Value_IsValid;

	private static FFieldAddress SetScalarParameterForCustomPrimitiveData_Value_PropertyAddress;

	private static int SetScalarParameterForCustomPrimitiveData_Value_Offset;

	private static bool SetRenderInMainPass_IsValid;

	private static IntPtr SetRenderInMainPass_FunctionAddress;

	private static int SetRenderInMainPass_ParamsSize;

	private static bool SetRenderInMainPass_bValue_IsValid;

	private static FFieldAddress SetRenderInMainPass_bValue_PropertyAddress;

	private static int SetRenderInMainPass_bValue_Offset;

	private static bool SetRenderInDepthPass_IsValid;

	private static IntPtr SetRenderInDepthPass_FunctionAddress;

	private static int SetRenderInDepthPass_ParamsSize;

	private static bool SetRenderInDepthPass_bValue_IsValid;

	private static FFieldAddress SetRenderInDepthPass_bValue_PropertyAddress;

	private static int SetRenderInDepthPass_bValue_Offset;

	private static bool SetRenderGSVoxelizationPass_IsValid;

	private static IntPtr SetRenderGSVoxelizationPass_FunctionAddress;

	private static int SetRenderGSVoxelizationPass_ParamsSize;

	private static bool SetRenderGSVoxelizationPass_bValue_IsValid;

	private static FFieldAddress SetRenderGSVoxelizationPass_bValue_PropertyAddress;

	private static int SetRenderGSVoxelizationPass_bValue_Offset;

	private static bool SetRenderCustomDepth_IsValid;

	private static IntPtr SetRenderCustomDepth_FunctionAddress;

	private static int SetRenderCustomDepth_ParamsSize;

	private static bool SetRenderCustomDepth_bValue_IsValid;

	private static FFieldAddress SetRenderCustomDepth_bValue_PropertyAddress;

	private static int SetRenderCustomDepth_bValue_Offset;

	private static bool SetReceivesDecals_IsValid;

	private static IntPtr SetReceivesDecals_FunctionAddress;

	private static int SetReceivesDecals_ParamsSize;

	private static bool SetReceivesDecals_bNewReceivesDecals_IsValid;

	private static FFieldAddress SetReceivesDecals_bNewReceivesDecals_PropertyAddress;

	private static int SetReceivesDecals_bNewReceivesDecals_Offset;

	private static bool SetPhysMaterialOverride_IsValid;

	private static IntPtr SetPhysMaterialOverride_FunctionAddress;

	private static int SetPhysMaterialOverride_ParamsSize;

	private static bool SetPhysMaterialOverride_NewPhysMaterial_IsValid;

	private static FFieldAddress SetPhysMaterialOverride_NewPhysMaterial_PropertyAddress;

	private static int SetPhysMaterialOverride_NewPhysMaterial_Offset;

	private static bool SetPhysicsMaxAngularVelocityInRadians_IsValid;

	private static IntPtr SetPhysicsMaxAngularVelocityInRadians_FunctionAddress;

	private static int SetPhysicsMaxAngularVelocityInRadians_ParamsSize;

	private static bool SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_Offset;

	private static bool SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_Offset;

	private static bool SetPhysicsMaxAngularVelocityInRadians_BoneName_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInRadians_BoneName_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInRadians_BoneName_Offset;

	private static bool SetPhysicsMaxAngularVelocityInDegrees_IsValid;

	private static IntPtr SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress;

	private static int SetPhysicsMaxAngularVelocityInDegrees_ParamsSize;

	private static bool SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_Offset;

	private static bool SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_Offset;

	private static bool SetPhysicsMaxAngularVelocityInDegrees_BoneName_IsValid;

	private static FFieldAddress SetPhysicsMaxAngularVelocityInDegrees_BoneName_PropertyAddress;

	private static int SetPhysicsMaxAngularVelocityInDegrees_BoneName_Offset;

	private static bool SetPhysicsLinearVelocity_IsValid;

	private static IntPtr SetPhysicsLinearVelocity_FunctionAddress;

	private static int SetPhysicsLinearVelocity_ParamsSize;

	private static bool SetPhysicsLinearVelocity_NewVel_IsValid;

	private static FFieldAddress SetPhysicsLinearVelocity_NewVel_PropertyAddress;

	private static int SetPhysicsLinearVelocity_NewVel_Offset;

	private static bool SetPhysicsLinearVelocity_bAddToCurrent_IsValid;

	private static FFieldAddress SetPhysicsLinearVelocity_bAddToCurrent_PropertyAddress;

	private static int SetPhysicsLinearVelocity_bAddToCurrent_Offset;

	private static bool SetPhysicsLinearVelocity_BoneName_IsValid;

	private static FFieldAddress SetPhysicsLinearVelocity_BoneName_PropertyAddress;

	private static int SetPhysicsLinearVelocity_BoneName_Offset;

	private static bool SetPhysicsAngularVelocityInRadians_IsValid;

	private static IntPtr SetPhysicsAngularVelocityInRadians_FunctionAddress;

	private static int SetPhysicsAngularVelocityInRadians_ParamsSize;

	private static bool SetPhysicsAngularVelocityInRadians_NewAngVel_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress;

	private static int SetPhysicsAngularVelocityInRadians_NewAngVel_Offset;

	private static bool SetPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress;

	private static int SetPhysicsAngularVelocityInRadians_bAddToCurrent_Offset;

	private static bool SetPhysicsAngularVelocityInRadians_BoneName_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress;

	private static int SetPhysicsAngularVelocityInRadians_BoneName_Offset;

	private static bool SetPhysicsAngularVelocityInDegrees_IsValid;

	private static IntPtr SetPhysicsAngularVelocityInDegrees_FunctionAddress;

	private static int SetPhysicsAngularVelocityInDegrees_ParamsSize;

	private static bool SetPhysicsAngularVelocityInDegrees_NewAngVel_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress;

	private static int SetPhysicsAngularVelocityInDegrees_NewAngVel_Offset;

	private static bool SetPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress;

	private static int SetPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset;

	private static bool SetPhysicsAngularVelocityInDegrees_BoneName_IsValid;

	private static FFieldAddress SetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress;

	private static int SetPhysicsAngularVelocityInDegrees_BoneName_Offset;

	private static bool SetOwnerNoSee_IsValid;

	private static IntPtr SetOwnerNoSee_FunctionAddress;

	private static int SetOwnerNoSee_ParamsSize;

	private static bool SetOwnerNoSee_bNewOwnerNoSee_IsValid;

	private static FFieldAddress SetOwnerNoSee_bNewOwnerNoSee_PropertyAddress;

	private static int SetOwnerNoSee_bNewOwnerNoSee_Offset;

	private static bool SetOnlyOwnerSee_IsValid;

	private static IntPtr SetOnlyOwnerSee_FunctionAddress;

	private static int SetOnlyOwnerSee_ParamsSize;

	private static bool SetOnlyOwnerSee_bNewOnlyOwnerSee_IsValid;

	private static FFieldAddress SetOnlyOwnerSee_bNewOnlyOwnerSee_PropertyAddress;

	private static int SetOnlyOwnerSee_bNewOnlyOwnerSee_Offset;

	private static bool SetNotifyRigidBodyCollision_IsValid;

	private static IntPtr SetNotifyRigidBodyCollision_FunctionAddress;

	private static int SetNotifyRigidBodyCollision_ParamsSize;

	private static bool SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_IsValid;

	private static FFieldAddress SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_PropertyAddress;

	private static int SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_Offset;

	private static bool SetMaterialByName_IsValid;

	private static IntPtr SetMaterialByName_FunctionAddress;

	private static int SetMaterialByName_ParamsSize;

	private static bool SetMaterialByName_MaterialSlotName_IsValid;

	private static FFieldAddress SetMaterialByName_MaterialSlotName_PropertyAddress;

	private static int SetMaterialByName_MaterialSlotName_Offset;

	private static bool SetMaterialByName_Material_IsValid;

	private static FFieldAddress SetMaterialByName_Material_PropertyAddress;

	private static int SetMaterialByName_Material_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_ElementIndex_IsValid;

	private static FFieldAddress SetMaterial_ElementIndex_PropertyAddress;

	private static int SetMaterial_ElementIndex_Offset;

	private static bool SetMaterial_Material_IsValid;

	private static FFieldAddress SetMaterial_Material_PropertyAddress;

	private static int SetMaterial_Material_Offset;

	private static bool SetMassScale_IsValid;

	private static IntPtr SetMassScale_FunctionAddress;

	private static int SetMassScale_ParamsSize;

	private static bool SetMassScale_BoneName_IsValid;

	private static FFieldAddress SetMassScale_BoneName_PropertyAddress;

	private static int SetMassScale_BoneName_Offset;

	private static bool SetMassScale_InMassScale_IsValid;

	private static FFieldAddress SetMassScale_InMassScale_PropertyAddress;

	private static int SetMassScale_InMassScale_Offset;

	private static bool SetMassOverrideInKg_IsValid;

	private static IntPtr SetMassOverrideInKg_FunctionAddress;

	private static int SetMassOverrideInKg_ParamsSize;

	private static bool SetMassOverrideInKg_BoneName_IsValid;

	private static FFieldAddress SetMassOverrideInKg_BoneName_PropertyAddress;

	private static int SetMassOverrideInKg_BoneName_Offset;

	private static bool SetMassOverrideInKg_MassInKg_IsValid;

	private static FFieldAddress SetMassOverrideInKg_MassInKg_PropertyAddress;

	private static int SetMassOverrideInKg_MassInKg_Offset;

	private static bool SetMassOverrideInKg_bOverrideMass_IsValid;

	private static FFieldAddress SetMassOverrideInKg_bOverrideMass_PropertyAddress;

	private static int SetMassOverrideInKg_bOverrideMass_Offset;

	private static bool SetLinearDamping_IsValid;

	private static IntPtr SetLinearDamping_FunctionAddress;

	private static int SetLinearDamping_ParamsSize;

	private static bool SetLinearDamping_InDamping_IsValid;

	private static FFieldAddress SetLinearDamping_InDamping_PropertyAddress;

	private static int SetLinearDamping_InDamping_Offset;

	private static bool SetLightingChannels_IsValid;

	private static IntPtr SetLightingChannels_FunctionAddress;

	private static int SetLightingChannels_ParamsSize;

	private static bool SetLightingChannels_bChannel0_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel0_PropertyAddress;

	private static int SetLightingChannels_bChannel0_Offset;

	private static bool SetLightingChannels_bChannel1_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel1_PropertyAddress;

	private static int SetLightingChannels_bChannel1_Offset;

	private static bool SetLightingChannels_bChannel2_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel2_PropertyAddress;

	private static int SetLightingChannels_bChannel2_Offset;

	private static bool SetLightAttachmentsAsGroup_IsValid;

	private static IntPtr SetLightAttachmentsAsGroup_FunctionAddress;

	private static int SetLightAttachmentsAsGroup_ParamsSize;

	private static bool SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_IsValid;

	private static FFieldAddress SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_PropertyAddress;

	private static int SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_Offset;

	private static bool SetHiddenInSceneCapture_IsValid;

	private static IntPtr SetHiddenInSceneCapture_FunctionAddress;

	private static int SetHiddenInSceneCapture_ParamsSize;

	private static bool SetHiddenInSceneCapture_bValue_IsValid;

	private static FFieldAddress SetHiddenInSceneCapture_bValue_PropertyAddress;

	private static int SetHiddenInSceneCapture_bValue_Offset;

	private static bool SetGenerateOverlapEvents_IsValid;

	private static IntPtr SetGenerateOverlapEvents_FunctionAddress;

	private static int SetGenerateOverlapEvents_ParamsSize;

	private static bool SetGenerateOverlapEvents_bInGenerateOverlapEvents_IsValid;

	private static FFieldAddress SetGenerateOverlapEvents_bInGenerateOverlapEvents_PropertyAddress;

	private static int SetGenerateOverlapEvents_bInGenerateOverlapEvents_Offset;

	private static bool SetExcludeFromLightAttachmentGroup_IsValid;

	private static IntPtr SetExcludeFromLightAttachmentGroup_FunctionAddress;

	private static int SetExcludeFromLightAttachmentGroup_ParamsSize;

	private static bool SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_IsValid;

	private static FFieldAddress SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_PropertyAddress;

	private static int SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_Offset;

	private static bool SetEnableGravity_IsValid;

	private static IntPtr SetEnableGravity_FunctionAddress;

	private static int SetEnableGravity_ParamsSize;

	private static bool SetEnableGravity_bGravityEnabled_IsValid;

	private static FFieldAddress SetEnableGravity_bGravityEnabled_PropertyAddress;

	private static int SetEnableGravity_bGravityEnabled_Offset;

	private static bool SetEmissiveLightSource_IsValid;

	private static IntPtr SetEmissiveLightSource_FunctionAddress;

	private static int SetEmissiveLightSource_ParamsSize;

	private static bool SetEmissiveLightSource_NewEmissiveLightSource_IsValid;

	private static FFieldAddress SetEmissiveLightSource_NewEmissiveLightSource_PropertyAddress;

	private static int SetEmissiveLightSource_NewEmissiveLightSource_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector4_IsValid;

	private static IntPtr SetDefaultCustomPrimitiveDataVector4_FunctionAddress;

	private static int SetDefaultCustomPrimitiveDataVector4_ParamsSize;

	private static bool SetDefaultCustomPrimitiveDataVector4_DataIndex_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector4_DataIndex_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector4_DataIndex_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector4_Value_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector4_Value_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector4_Value_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector3_IsValid;

	private static IntPtr SetDefaultCustomPrimitiveDataVector3_FunctionAddress;

	private static int SetDefaultCustomPrimitiveDataVector3_ParamsSize;

	private static bool SetDefaultCustomPrimitiveDataVector3_DataIndex_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector3_DataIndex_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector3_DataIndex_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector3_Value_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector3_Value_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector3_Value_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector2_IsValid;

	private static IntPtr SetDefaultCustomPrimitiveDataVector2_FunctionAddress;

	private static int SetDefaultCustomPrimitiveDataVector2_ParamsSize;

	private static bool SetDefaultCustomPrimitiveDataVector2_DataIndex_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector2_DataIndex_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector2_DataIndex_Offset;

	private static bool SetDefaultCustomPrimitiveDataVector2_Value_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataVector2_Value_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataVector2_Value_Offset;

	private static bool SetDefaultCustomPrimitiveDataFloat_IsValid;

	private static IntPtr SetDefaultCustomPrimitiveDataFloat_FunctionAddress;

	private static int SetDefaultCustomPrimitiveDataFloat_ParamsSize;

	private static bool SetDefaultCustomPrimitiveDataFloat_DataIndex_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataFloat_DataIndex_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataFloat_DataIndex_Offset;

	private static bool SetDefaultCustomPrimitiveDataFloat_Value_IsValid;

	private static FFieldAddress SetDefaultCustomPrimitiveDataFloat_Value_PropertyAddress;

	private static int SetDefaultCustomPrimitiveDataFloat_Value_Offset;

	private static bool SetCustomPrimitiveDataVector4_IsValid;

	private static IntPtr SetCustomPrimitiveDataVector4_FunctionAddress;

	private static int SetCustomPrimitiveDataVector4_ParamsSize;

	private static bool SetCustomPrimitiveDataVector4_DataIndex_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector4_DataIndex_PropertyAddress;

	private static int SetCustomPrimitiveDataVector4_DataIndex_Offset;

	private static bool SetCustomPrimitiveDataVector4_Value_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector4_Value_PropertyAddress;

	private static int SetCustomPrimitiveDataVector4_Value_Offset;

	private static bool SetCustomPrimitiveDataVector3_IsValid;

	private static IntPtr SetCustomPrimitiveDataVector3_FunctionAddress;

	private static int SetCustomPrimitiveDataVector3_ParamsSize;

	private static bool SetCustomPrimitiveDataVector3_DataIndex_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector3_DataIndex_PropertyAddress;

	private static int SetCustomPrimitiveDataVector3_DataIndex_Offset;

	private static bool SetCustomPrimitiveDataVector3_Value_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector3_Value_PropertyAddress;

	private static int SetCustomPrimitiveDataVector3_Value_Offset;

	private static bool SetCustomPrimitiveDataVector2_IsValid;

	private static IntPtr SetCustomPrimitiveDataVector2_FunctionAddress;

	private static int SetCustomPrimitiveDataVector2_ParamsSize;

	private static bool SetCustomPrimitiveDataVector2_DataIndex_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector2_DataIndex_PropertyAddress;

	private static int SetCustomPrimitiveDataVector2_DataIndex_Offset;

	private static bool SetCustomPrimitiveDataVector2_Value_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataVector2_Value_PropertyAddress;

	private static int SetCustomPrimitiveDataVector2_Value_Offset;

	private static bool SetCustomPrimitiveDataFloat_IsValid;

	private static IntPtr SetCustomPrimitiveDataFloat_FunctionAddress;

	private static int SetCustomPrimitiveDataFloat_ParamsSize;

	private static bool SetCustomPrimitiveDataFloat_DataIndex_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataFloat_DataIndex_PropertyAddress;

	private static int SetCustomPrimitiveDataFloat_DataIndex_Offset;

	private static bool SetCustomPrimitiveDataFloat_Value_IsValid;

	private static FFieldAddress SetCustomPrimitiveDataFloat_Value_PropertyAddress;

	private static int SetCustomPrimitiveDataFloat_Value_Offset;

	private static bool SetCustomDepthStencilWriteMask_IsValid;

	private static IntPtr SetCustomDepthStencilWriteMask_FunctionAddress;

	private static int SetCustomDepthStencilWriteMask_ParamsSize;

	private static bool SetCustomDepthStencilWriteMask_WriteMaskBit_IsValid;

	private static FFieldAddress SetCustomDepthStencilWriteMask_WriteMaskBit_PropertyAddress;

	private static int SetCustomDepthStencilWriteMask_WriteMaskBit_Offset;

	private static bool SetCustomDepthStencilValue_IsValid;

	private static IntPtr SetCustomDepthStencilValue_FunctionAddress;

	private static int SetCustomDepthStencilValue_ParamsSize;

	private static bool SetCustomDepthStencilValue_Value_IsValid;

	private static FFieldAddress SetCustomDepthStencilValue_Value_PropertyAddress;

	private static int SetCustomDepthStencilValue_Value_Offset;

	private static bool SetCullDistance_IsValid;

	private static IntPtr SetCullDistance_FunctionAddress;

	private static int SetCullDistance_ParamsSize;

	private static bool SetCullDistance_NewCullDistance_IsValid;

	private static FFieldAddress SetCullDistance_NewCullDistance_PropertyAddress;

	private static int SetCullDistance_NewCullDistance_Offset;

	private static bool SetConstraintMode_IsValid;

	private static IntPtr SetConstraintMode_FunctionAddress;

	private static int SetConstraintMode_ParamsSize;

	private static bool SetConstraintMode_ConstraintMode_IsValid;

	private static FFieldAddress SetConstraintMode_ConstraintMode_PropertyAddress;

	private static int SetConstraintMode_ConstraintMode_Offset;

	private static bool SetCollisionResponseToChannel_IsValid;

	private static IntPtr SetCollisionResponseToChannel_FunctionAddress;

	private static int SetCollisionResponseToChannel_ParamsSize;

	private static bool SetCollisionResponseToChannel_Channel_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_Channel_PropertyAddress;

	private static int SetCollisionResponseToChannel_Channel_Offset;

	private static bool SetCollisionResponseToChannel_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToChannel_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToChannel_NewResponse_Offset;

	private static bool SetCollisionResponseToAllChannels_IsValid;

	private static IntPtr SetCollisionResponseToAllChannels_FunctionAddress;

	private static int SetCollisionResponseToAllChannels_ParamsSize;

	private static bool SetCollisionResponseToAllChannels_NewResponse_IsValid;

	private static FFieldAddress SetCollisionResponseToAllChannels_NewResponse_PropertyAddress;

	private static int SetCollisionResponseToAllChannels_NewResponse_Offset;

	private static bool SetCollisionProfileName_IsValid;

	private static IntPtr SetCollisionProfileName_FunctionAddress;

	private static int SetCollisionProfileName_ParamsSize;

	private static bool SetCollisionProfileName_InCollisionProfileName_IsValid;

	private static FFieldAddress SetCollisionProfileName_InCollisionProfileName_PropertyAddress;

	private static int SetCollisionProfileName_InCollisionProfileName_Offset;

	private static bool SetCollisionProfileName_bUpdateOverlaps_IsValid;

	private static FFieldAddress SetCollisionProfileName_bUpdateOverlaps_PropertyAddress;

	private static int SetCollisionProfileName_bUpdateOverlaps_Offset;

	private static bool SetCollisionObjectType_IsValid;

	private static IntPtr SetCollisionObjectType_FunctionAddress;

	private static int SetCollisionObjectType_ParamsSize;

	private static bool SetCollisionObjectType_Channel_IsValid;

	private static FFieldAddress SetCollisionObjectType_Channel_PropertyAddress;

	private static int SetCollisionObjectType_Channel_Offset;

	private static bool SetCollisionEnabled_IsValid;

	private static IntPtr SetCollisionEnabled_FunctionAddress;

	private static int SetCollisionEnabled_ParamsSize;

	private static bool SetCollisionEnabled_NewType_IsValid;

	private static FFieldAddress SetCollisionEnabled_NewType_PropertyAddress;

	private static int SetCollisionEnabled_NewType_Offset;

	private static bool SetCenterOfMass_IsValid;

	private static IntPtr SetCenterOfMass_FunctionAddress;

	private static int SetCenterOfMass_ParamsSize;

	private static bool SetCenterOfMass_CenterOfMassOffset_IsValid;

	private static FFieldAddress SetCenterOfMass_CenterOfMassOffset_PropertyAddress;

	private static int SetCenterOfMass_CenterOfMassOffset_Offset;

	private static bool SetCenterOfMass_BoneName_IsValid;

	private static FFieldAddress SetCenterOfMass_BoneName_PropertyAddress;

	private static int SetCenterOfMass_BoneName_Offset;

	private static bool SetCastShadow_IsValid;

	private static IntPtr SetCastShadow_FunctionAddress;

	private static int SetCastShadow_ParamsSize;

	private static bool SetCastShadow_NewCastShadow_IsValid;

	private static FFieldAddress SetCastShadow_NewCastShadow_PropertyAddress;

	private static int SetCastShadow_NewCastShadow_Offset;

	private static bool SetCastInsetShadow_IsValid;

	private static IntPtr SetCastInsetShadow_FunctionAddress;

	private static int SetCastInsetShadow_ParamsSize;

	private static bool SetCastInsetShadow_bInCastInsetShadow_IsValid;

	private static FFieldAddress SetCastInsetShadow_bInCastInsetShadow_PropertyAddress;

	private static int SetCastInsetShadow_bInCastInsetShadow_Offset;

	private static bool SetCastHybridRayTracingShadow_IsValid;

	private static IntPtr SetCastHybridRayTracingShadow_FunctionAddress;

	private static int SetCastHybridRayTracingShadow_ParamsSize;

	private static bool SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_IsValid;

	private static FFieldAddress SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_PropertyAddress;

	private static int SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_Offset;

	private static bool SetCastHiddenShadow_IsValid;

	private static IntPtr SetCastHiddenShadow_FunctionAddress;

	private static int SetCastHiddenShadow_ParamsSize;

	private static bool SetCastHiddenShadow_NewCastHiddenShadow_IsValid;

	private static FFieldAddress SetCastHiddenShadow_NewCastHiddenShadow_PropertyAddress;

	private static int SetCastHiddenShadow_NewCastHiddenShadow_Offset;

	private static bool SetCastContactShadow_IsValid;

	private static IntPtr SetCastContactShadow_FunctionAddress;

	private static int SetCastContactShadow_ParamsSize;

	private static bool SetCastContactShadow_bInCastContactShadow_IsValid;

	private static FFieldAddress SetCastContactShadow_bInCastContactShadow_PropertyAddress;

	private static int SetCastContactShadow_bInCastContactShadow_Offset;

	private static bool SetBoundsScale_IsValid;

	private static IntPtr SetBoundsScale_FunctionAddress;

	private static int SetBoundsScale_ParamsSize;

	private static bool SetBoundsScale_NewBoundsScale_IsValid;

	private static FFieldAddress SetBoundsScale_NewBoundsScale_PropertyAddress;

	private static int SetBoundsScale_NewBoundsScale_Offset;

	private static bool SetAngularDamping_IsValid;

	private static IntPtr SetAngularDamping_FunctionAddress;

	private static int SetAngularDamping_ParamsSize;

	private static bool SetAngularDamping_InDamping_IsValid;

	private static FFieldAddress SetAngularDamping_InDamping_PropertyAddress;

	private static int SetAngularDamping_InDamping_Offset;

	private static bool SetAllUseCCD_IsValid;

	private static IntPtr SetAllUseCCD_FunctionAddress;

	private static int SetAllUseCCD_ParamsSize;

	private static bool SetAllUseCCD_InUseCCD_IsValid;

	private static FFieldAddress SetAllUseCCD_InUseCCD_PropertyAddress;

	private static int SetAllUseCCD_InUseCCD_Offset;

	private static bool SetAllPhysicsLinearVelocity_IsValid;

	private static IntPtr SetAllPhysicsLinearVelocity_FunctionAddress;

	private static int SetAllPhysicsLinearVelocity_ParamsSize;

	private static bool SetAllPhysicsLinearVelocity_NewVel_IsValid;

	private static FFieldAddress SetAllPhysicsLinearVelocity_NewVel_PropertyAddress;

	private static int SetAllPhysicsLinearVelocity_NewVel_Offset;

	private static bool SetAllPhysicsLinearVelocity_bAddToCurrent_IsValid;

	private static FFieldAddress SetAllPhysicsLinearVelocity_bAddToCurrent_PropertyAddress;

	private static int SetAllPhysicsLinearVelocity_bAddToCurrent_Offset;

	private static bool SetAllPhysicsAngularVelocityInRadians_IsValid;

	private static IntPtr SetAllPhysicsAngularVelocityInRadians_FunctionAddress;

	private static int SetAllPhysicsAngularVelocityInRadians_ParamsSize;

	private static bool SetAllPhysicsAngularVelocityInRadians_NewAngVel_IsValid;

	private static FFieldAddress SetAllPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress;

	private static int SetAllPhysicsAngularVelocityInRadians_NewAngVel_Offset;

	private static bool SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid;

	private static FFieldAddress SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress;

	private static int SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_Offset;

	private static bool SetAllPhysicsAngularVelocityInDegrees_IsValid;

	private static IntPtr SetAllPhysicsAngularVelocityInDegrees_FunctionAddress;

	private static int SetAllPhysicsAngularVelocityInDegrees_ParamsSize;

	private static bool SetAllPhysicsAngularVelocityInDegrees_NewAngVel_IsValid;

	private static FFieldAddress SetAllPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress;

	private static int SetAllPhysicsAngularVelocityInDegrees_NewAngVel_Offset;

	private static bool SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid;

	private static FFieldAddress SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress;

	private static int SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset;

	private static bool SetAllMassScale_IsValid;

	private static IntPtr SetAllMassScale_FunctionAddress;

	private static int SetAllMassScale_ParamsSize;

	private static bool SetAllMassScale_InMassScale_IsValid;

	private static FFieldAddress SetAllMassScale_InMassScale_PropertyAddress;

	private static int SetAllMassScale_InMassScale_Offset;

	private static bool ScaleByMomentOfInertia_IsValid;

	private static IntPtr ScaleByMomentOfInertia_FunctionAddress;

	private static int ScaleByMomentOfInertia_ParamsSize;

	private static bool ScaleByMomentOfInertia_InputVector_IsValid;

	private static FFieldAddress ScaleByMomentOfInertia_InputVector_PropertyAddress;

	private static int ScaleByMomentOfInertia_InputVector_Offset;

	private static bool ScaleByMomentOfInertia_BoneName_IsValid;

	private static FFieldAddress ScaleByMomentOfInertia_BoneName_PropertyAddress;

	private static int ScaleByMomentOfInertia_BoneName_Offset;

	private static bool ScaleByMomentOfInertia_ReturnValue_IsValid;

	private static FFieldAddress ScaleByMomentOfInertia_ReturnValue_PropertyAddress;

	private static int ScaleByMomentOfInertia_ReturnValue_Offset;

	private static bool PutRigidBodyToSleep_IsValid;

	private static IntPtr PutRigidBodyToSleep_FunctionAddress;

	private static int PutRigidBodyToSleep_ParamsSize;

	private static bool PutRigidBodyToSleep_BoneName_IsValid;

	private static FFieldAddress PutRigidBodyToSleep_BoneName_PropertyAddress;

	private static int PutRigidBodyToSleep_BoneName_Offset;

	private static bool SphereTraceComponent_IsValid;

	private static IntPtr SphereTraceComponent_FunctionAddress;

	private static int SphereTraceComponent_ParamsSize;

	private static bool SphereTraceComponent_TraceStart_IsValid;

	private static FFieldAddress SphereTraceComponent_TraceStart_PropertyAddress;

	private static int SphereTraceComponent_TraceStart_Offset;

	private static bool SphereTraceComponent_TraceEnd_IsValid;

	private static FFieldAddress SphereTraceComponent_TraceEnd_PropertyAddress;

	private static int SphereTraceComponent_TraceEnd_Offset;

	private static bool SphereTraceComponent_SphereRadius_IsValid;

	private static FFieldAddress SphereTraceComponent_SphereRadius_PropertyAddress;

	private static int SphereTraceComponent_SphereRadius_Offset;

	private static bool SphereTraceComponent_bTraceComplex_IsValid;

	private static FFieldAddress SphereTraceComponent_bTraceComplex_PropertyAddress;

	private static int SphereTraceComponent_bTraceComplex_Offset;

	private static bool SphereTraceComponent_bShowTrace_IsValid;

	private static FFieldAddress SphereTraceComponent_bShowTrace_PropertyAddress;

	private static int SphereTraceComponent_bShowTrace_Offset;

	private static bool SphereTraceComponent_bPersistentShowTrace_IsValid;

	private static FFieldAddress SphereTraceComponent_bPersistentShowTrace_PropertyAddress;

	private static int SphereTraceComponent_bPersistentShowTrace_Offset;

	private static bool SphereTraceComponent_HitLocation_IsValid;

	private static FFieldAddress SphereTraceComponent_HitLocation_PropertyAddress;

	private static int SphereTraceComponent_HitLocation_Offset;

	private static bool SphereTraceComponent_HitNormal_IsValid;

	private static FFieldAddress SphereTraceComponent_HitNormal_PropertyAddress;

	private static int SphereTraceComponent_HitNormal_Offset;

	private static bool SphereTraceComponent_BoneName_IsValid;

	private static FFieldAddress SphereTraceComponent_BoneName_PropertyAddress;

	private static int SphereTraceComponent_BoneName_Offset;

	private static bool SphereTraceComponent_OutHit_IsValid;

	private static FFieldAddress SphereTraceComponent_OutHit_PropertyAddress;

	private static int SphereTraceComponent_OutHit_Offset;

	private static bool SphereTraceComponent_ReturnValue_IsValid;

	private static FFieldAddress SphereTraceComponent_ReturnValue_PropertyAddress;

	private static int SphereTraceComponent_ReturnValue_Offset;

	private static bool SphereOverlapComponent_IsValid;

	private static IntPtr SphereOverlapComponent_FunctionAddress;

	private static int SphereOverlapComponent_ParamsSize;

	private static bool SphereOverlapComponent_InSphereCentre_IsValid;

	private static FFieldAddress SphereOverlapComponent_InSphereCentre_PropertyAddress;

	private static int SphereOverlapComponent_InSphereCentre_Offset;

	private static bool SphereOverlapComponent_InSphereRadius_IsValid;

	private static FFieldAddress SphereOverlapComponent_InSphereRadius_PropertyAddress;

	private static int SphereOverlapComponent_InSphereRadius_Offset;

	private static bool SphereOverlapComponent_bTraceComplex_IsValid;

	private static FFieldAddress SphereOverlapComponent_bTraceComplex_PropertyAddress;

	private static int SphereOverlapComponent_bTraceComplex_Offset;

	private static bool SphereOverlapComponent_bShowTrace_IsValid;

	private static FFieldAddress SphereOverlapComponent_bShowTrace_PropertyAddress;

	private static int SphereOverlapComponent_bShowTrace_Offset;

	private static bool SphereOverlapComponent_bPersistentShowTrace_IsValid;

	private static FFieldAddress SphereOverlapComponent_bPersistentShowTrace_PropertyAddress;

	private static int SphereOverlapComponent_bPersistentShowTrace_Offset;

	private static bool SphereOverlapComponent_HitLocation_IsValid;

	private static FFieldAddress SphereOverlapComponent_HitLocation_PropertyAddress;

	private static int SphereOverlapComponent_HitLocation_Offset;

	private static bool SphereOverlapComponent_HitNormal_IsValid;

	private static FFieldAddress SphereOverlapComponent_HitNormal_PropertyAddress;

	private static int SphereOverlapComponent_HitNormal_Offset;

	private static bool SphereOverlapComponent_BoneName_IsValid;

	private static FFieldAddress SphereOverlapComponent_BoneName_PropertyAddress;

	private static int SphereOverlapComponent_BoneName_Offset;

	private static bool SphereOverlapComponent_OutHit_IsValid;

	private static FFieldAddress SphereOverlapComponent_OutHit_PropertyAddress;

	private static int SphereOverlapComponent_OutHit_Offset;

	private static bool SphereOverlapComponent_ReturnValue_IsValid;

	private static FFieldAddress SphereOverlapComponent_ReturnValue_PropertyAddress;

	private static int SphereOverlapComponent_ReturnValue_Offset;

	private static bool LineTraceComponent_IsValid;

	private static IntPtr LineTraceComponent_FunctionAddress;

	private static int LineTraceComponent_ParamsSize;

	private static bool LineTraceComponent_TraceStart_IsValid;

	private static FFieldAddress LineTraceComponent_TraceStart_PropertyAddress;

	private static int LineTraceComponent_TraceStart_Offset;

	private static bool LineTraceComponent_TraceEnd_IsValid;

	private static FFieldAddress LineTraceComponent_TraceEnd_PropertyAddress;

	private static int LineTraceComponent_TraceEnd_Offset;

	private static bool LineTraceComponent_bTraceComplex_IsValid;

	private static FFieldAddress LineTraceComponent_bTraceComplex_PropertyAddress;

	private static int LineTraceComponent_bTraceComplex_Offset;

	private static bool LineTraceComponent_bShowTrace_IsValid;

	private static FFieldAddress LineTraceComponent_bShowTrace_PropertyAddress;

	private static int LineTraceComponent_bShowTrace_Offset;

	private static bool LineTraceComponent_bPersistentShowTrace_IsValid;

	private static FFieldAddress LineTraceComponent_bPersistentShowTrace_PropertyAddress;

	private static int LineTraceComponent_bPersistentShowTrace_Offset;

	private static bool LineTraceComponent_HitLocation_IsValid;

	private static FFieldAddress LineTraceComponent_HitLocation_PropertyAddress;

	private static int LineTraceComponent_HitLocation_Offset;

	private static bool LineTraceComponent_HitNormal_IsValid;

	private static FFieldAddress LineTraceComponent_HitNormal_PropertyAddress;

	private static int LineTraceComponent_HitNormal_Offset;

	private static bool LineTraceComponent_BoneName_IsValid;

	private static FFieldAddress LineTraceComponent_BoneName_PropertyAddress;

	private static int LineTraceComponent_BoneName_Offset;

	private static bool LineTraceComponent_OutHit_IsValid;

	private static FFieldAddress LineTraceComponent_OutHit_PropertyAddress;

	private static int LineTraceComponent_OutHit_Offset;

	private static bool LineTraceComponent_ReturnValue_IsValid;

	private static FFieldAddress LineTraceComponent_ReturnValue_PropertyAddress;

	private static int LineTraceComponent_ReturnValue_Offset;

	private static bool IsQueryCollisionEnabled_IsValid;

	private static IntPtr IsQueryCollisionEnabled_FunctionAddress;

	private static int IsQueryCollisionEnabled_ParamsSize;

	private static bool IsQueryCollisionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsQueryCollisionEnabled_ReturnValue_PropertyAddress;

	private static int IsQueryCollisionEnabled_ReturnValue_Offset;

	private static bool IsPhysicsCollisionEnabled_IsValid;

	private static IntPtr IsPhysicsCollisionEnabled_FunctionAddress;

	private static int IsPhysicsCollisionEnabled_ParamsSize;

	private static bool IsPhysicsCollisionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsPhysicsCollisionEnabled_ReturnValue_PropertyAddress;

	private static int IsPhysicsCollisionEnabled_ReturnValue_Offset;

	private static bool IsCollisionEnabled_IsValid;

	private static IntPtr IsCollisionEnabled_FunctionAddress;

	private static int IsCollisionEnabled_ParamsSize;

	private static bool IsCollisionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsCollisionEnabled_ReturnValue_PropertyAddress;

	private static int IsCollisionEnabled_ReturnValue_Offset;

	private static bool BoxOverlapComponent_IsValid;

	private static IntPtr BoxOverlapComponent_FunctionAddress;

	private static int BoxOverlapComponent_ParamsSize;

	private static bool BoxOverlapComponent_InBoxCentre_IsValid;

	private static FFieldAddress BoxOverlapComponent_InBoxCentre_PropertyAddress;

	private static int BoxOverlapComponent_InBoxCentre_Offset;

	private static bool BoxOverlapComponent_InBox_IsValid;

	private static FFieldAddress BoxOverlapComponent_InBox_PropertyAddress;

	private static int BoxOverlapComponent_InBox_Offset;

	private static bool BoxOverlapComponent_bTraceComplex_IsValid;

	private static FFieldAddress BoxOverlapComponent_bTraceComplex_PropertyAddress;

	private static int BoxOverlapComponent_bTraceComplex_Offset;

	private static bool BoxOverlapComponent_bShowTrace_IsValid;

	private static FFieldAddress BoxOverlapComponent_bShowTrace_PropertyAddress;

	private static int BoxOverlapComponent_bShowTrace_Offset;

	private static bool BoxOverlapComponent_bPersistentShowTrace_IsValid;

	private static FFieldAddress BoxOverlapComponent_bPersistentShowTrace_PropertyAddress;

	private static int BoxOverlapComponent_bPersistentShowTrace_Offset;

	private static bool BoxOverlapComponent_HitLocation_IsValid;

	private static FFieldAddress BoxOverlapComponent_HitLocation_PropertyAddress;

	private static int BoxOverlapComponent_HitLocation_Offset;

	private static bool BoxOverlapComponent_HitNormal_IsValid;

	private static FFieldAddress BoxOverlapComponent_HitNormal_PropertyAddress;

	private static int BoxOverlapComponent_HitNormal_Offset;

	private static bool BoxOverlapComponent_BoneName_IsValid;

	private static FFieldAddress BoxOverlapComponent_BoneName_PropertyAddress;

	private static int BoxOverlapComponent_BoneName_Offset;

	private static bool BoxOverlapComponent_OutHit_IsValid;

	private static FFieldAddress BoxOverlapComponent_OutHit_PropertyAddress;

	private static int BoxOverlapComponent_OutHit_Offset;

	private static bool BoxOverlapComponent_ReturnValue_IsValid;

	private static FFieldAddress BoxOverlapComponent_ReturnValue_PropertyAddress;

	private static int BoxOverlapComponent_ReturnValue_Offset;

	private static bool IsOverlappingComponent_IsValid;

	private static IntPtr IsOverlappingComponent_FunctionAddress;

	private static int IsOverlappingComponent_ParamsSize;

	private static bool IsOverlappingComponent_OtherComp_IsValid;

	private static FFieldAddress IsOverlappingComponent_OtherComp_PropertyAddress;

	private static int IsOverlappingComponent_OtherComp_Offset;

	private static bool IsOverlappingComponent_ReturnValue_IsValid;

	private static FFieldAddress IsOverlappingComponent_ReturnValue_PropertyAddress;

	private static int IsOverlappingComponent_ReturnValue_Offset;

	private static bool IsOverlappingActor_IsValid;

	private static IntPtr IsOverlappingActor_FunctionAddress;

	private static int IsOverlappingActor_ParamsSize;

	private static bool IsOverlappingActor_Other_IsValid;

	private static FFieldAddress IsOverlappingActor_Other_PropertyAddress;

	private static int IsOverlappingActor_Other_Offset;

	private static bool IsOverlappingActor_ReturnValue_IsValid;

	private static FFieldAddress IsOverlappingActor_ReturnValue_PropertyAddress;

	private static int IsOverlappingActor_ReturnValue_Offset;

	private static bool IsGravityEnabled_IsValid;

	private static IntPtr IsGravityEnabled_FunctionAddress;

	private static int IsGravityEnabled_ParamsSize;

	private static bool IsGravityEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsGravityEnabled_ReturnValue_PropertyAddress;

	private static int IsGravityEnabled_ReturnValue_Offset;

	private static bool IsAnyRigidBodyAwake_IsValid;

	private static IntPtr IsAnyRigidBodyAwake_FunctionAddress;

	private static int IsAnyRigidBodyAwake_ParamsSize;

	private static bool IsAnyRigidBodyAwake_ReturnValue_IsValid;

	private static FFieldAddress IsAnyRigidBodyAwake_ReturnValue_PropertyAddress;

	private static int IsAnyRigidBodyAwake_ReturnValue_Offset;

	private static bool IgnoreComponentWhenMoving_IsValid;

	private static IntPtr IgnoreComponentWhenMoving_FunctionAddress;

	private static int IgnoreComponentWhenMoving_ParamsSize;

	private static bool IgnoreComponentWhenMoving_Component_IsValid;

	private static FFieldAddress IgnoreComponentWhenMoving_Component_PropertyAddress;

	private static int IgnoreComponentWhenMoving_Component_Offset;

	private static bool IgnoreComponentWhenMoving_bShouldIgnore_IsValid;

	private static FFieldAddress IgnoreComponentWhenMoving_bShouldIgnore_PropertyAddress;

	private static int IgnoreComponentWhenMoving_bShouldIgnore_Offset;

	private static bool IgnoreActorWhenMoving_IsValid;

	private static IntPtr IgnoreActorWhenMoving_FunctionAddress;

	private static int IgnoreActorWhenMoving_ParamsSize;

	private static bool IgnoreActorWhenMoving_Actor_IsValid;

	private static FFieldAddress IgnoreActorWhenMoving_Actor_PropertyAddress;

	private static int IgnoreActorWhenMoving_Actor_Offset;

	private static bool IgnoreActorWhenMoving_bShouldIgnore_IsValid;

	private static FFieldAddress IgnoreActorWhenMoving_bShouldIgnore_PropertyAddress;

	private static int IgnoreActorWhenMoving_bShouldIgnore_Offset;

	private static bool GetWalkableSlopeOverride_IsValid;

	private static IntPtr GetWalkableSlopeOverride_FunctionAddress;

	private static int GetWalkableSlopeOverride_ParamsSize;

	private static bool GetWalkableSlopeOverride_ReturnValue_IsValid;

	private static FFieldAddress GetWalkableSlopeOverride_ReturnValue_PropertyAddress;

	private static int GetWalkableSlopeOverride_ReturnValue_Offset;

	private static bool GetPhysicsLinearVelocityAtPoint_IsValid;

	private static IntPtr GetPhysicsLinearVelocityAtPoint_FunctionAddress;

	private static int GetPhysicsLinearVelocityAtPoint_ParamsSize;

	private static bool GetPhysicsLinearVelocityAtPoint_Point_IsValid;

	private static FFieldAddress GetPhysicsLinearVelocityAtPoint_Point_PropertyAddress;

	private static int GetPhysicsLinearVelocityAtPoint_Point_Offset;

	private static bool GetPhysicsLinearVelocityAtPoint_BoneName_IsValid;

	private static FFieldAddress GetPhysicsLinearVelocityAtPoint_BoneName_PropertyAddress;

	private static int GetPhysicsLinearVelocityAtPoint_BoneName_Offset;

	private static bool GetPhysicsLinearVelocityAtPoint_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsLinearVelocityAtPoint_ReturnValue_PropertyAddress;

	private static int GetPhysicsLinearVelocityAtPoint_ReturnValue_Offset;

	private static bool GetPhysicsLinearVelocity_IsValid;

	private static IntPtr GetPhysicsLinearVelocity_FunctionAddress;

	private static int GetPhysicsLinearVelocity_ParamsSize;

	private static bool GetPhysicsLinearVelocity_BoneName_IsValid;

	private static FFieldAddress GetPhysicsLinearVelocity_BoneName_PropertyAddress;

	private static int GetPhysicsLinearVelocity_BoneName_Offset;

	private static bool GetPhysicsLinearVelocity_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsLinearVelocity_ReturnValue_PropertyAddress;

	private static int GetPhysicsLinearVelocity_ReturnValue_Offset;

	private static bool GetPhysicsAngularVelocityInRadians_IsValid;

	private static IntPtr GetPhysicsAngularVelocityInRadians_FunctionAddress;

	private static int GetPhysicsAngularVelocityInRadians_ParamsSize;

	private static bool GetPhysicsAngularVelocityInRadians_BoneName_IsValid;

	private static FFieldAddress GetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress;

	private static int GetPhysicsAngularVelocityInRadians_BoneName_Offset;

	private static bool GetPhysicsAngularVelocityInRadians_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAngularVelocityInRadians_ReturnValue_PropertyAddress;

	private static int GetPhysicsAngularVelocityInRadians_ReturnValue_Offset;

	private static bool GetPhysicsAngularVelocityInDegrees_IsValid;

	private static IntPtr GetPhysicsAngularVelocityInDegrees_FunctionAddress;

	private static int GetPhysicsAngularVelocityInDegrees_ParamsSize;

	private static bool GetPhysicsAngularVelocityInDegrees_BoneName_IsValid;

	private static FFieldAddress GetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress;

	private static int GetPhysicsAngularVelocityInDegrees_BoneName_Offset;

	private static bool GetPhysicsAngularVelocityInDegrees_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsAngularVelocityInDegrees_ReturnValue_PropertyAddress;

	private static int GetPhysicsAngularVelocityInDegrees_ReturnValue_Offset;

	private static bool GetOverlappingComponents_IsValid;

	private static IntPtr GetOverlappingComponents_FunctionAddress;

	private static int GetOverlappingComponents_ParamsSize;

	private static bool GetOverlappingComponents_OutOverlappingComponents_IsValid;

	private static FFieldAddress GetOverlappingComponents_OutOverlappingComponents_PropertyAddress;

	private static int GetOverlappingComponents_OutOverlappingComponents_Offset;

	private static bool GetOverlappingActors_IsValid;

	private static IntPtr GetOverlappingActors_FunctionAddress;

	private static int GetOverlappingActors_ParamsSize;

	private static bool GetOverlappingActors_OverlappingActors_IsValid;

	private static FFieldAddress GetOverlappingActors_OverlappingActors_PropertyAddress;

	private static int GetOverlappingActors_OverlappingActors_Offset;

	private static bool GetOverlappingActors_ClassFilter_IsValid;

	private static FFieldAddress GetOverlappingActors_ClassFilter_PropertyAddress;

	private static int GetOverlappingActors_ClassFilter_Offset;

	private static bool GetNumMaterials_IsValid;

	private static IntPtr GetNumMaterials_FunctionAddress;

	private static int GetNumMaterials_ParamsSize;

	private static bool GetNumMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetNumMaterials_ReturnValue_PropertyAddress;

	private static int GetNumMaterials_ReturnValue_Offset;

	private static bool GetMaterialFromCollisionFaceIndex_IsValid;

	private static IntPtr GetMaterialFromCollisionFaceIndex_FunctionAddress;

	private static int GetMaterialFromCollisionFaceIndex_ParamsSize;

	private static bool GetMaterialFromCollisionFaceIndex_FaceIndex_IsValid;

	private static FFieldAddress GetMaterialFromCollisionFaceIndex_FaceIndex_PropertyAddress;

	private static int GetMaterialFromCollisionFaceIndex_FaceIndex_Offset;

	private static bool GetMaterialFromCollisionFaceIndex_SectionIndex_IsValid;

	private static FFieldAddress GetMaterialFromCollisionFaceIndex_SectionIndex_PropertyAddress;

	private static int GetMaterialFromCollisionFaceIndex_SectionIndex_Offset;

	private static bool GetMaterialFromCollisionFaceIndex_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialFromCollisionFaceIndex_ReturnValue_PropertyAddress;

	private static int GetMaterialFromCollisionFaceIndex_ReturnValue_Offset;

	private static bool GetMaterial_IsValid;

	private static IntPtr GetMaterial_FunctionAddress;

	private static int GetMaterial_ParamsSize;

	private static bool GetMaterial_ElementIndex_IsValid;

	private static FFieldAddress GetMaterial_ElementIndex_PropertyAddress;

	private static int GetMaterial_ElementIndex_Offset;

	private static bool GetMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetMaterial_ReturnValue_PropertyAddress;

	private static int GetMaterial_ReturnValue_Offset;

	private static bool GetMassScale_IsValid;

	private static IntPtr GetMassScale_FunctionAddress;

	private static int GetMassScale_ParamsSize;

	private static bool GetMassScale_BoneName_IsValid;

	private static FFieldAddress GetMassScale_BoneName_PropertyAddress;

	private static int GetMassScale_BoneName_Offset;

	private static bool GetMassScale_ReturnValue_IsValid;

	private static FFieldAddress GetMassScale_ReturnValue_PropertyAddress;

	private static int GetMassScale_ReturnValue_Offset;

	private static bool GetMass_IsValid;

	private static IntPtr GetMass_FunctionAddress;

	private static int GetMass_ParamsSize;

	private static bool GetMass_ReturnValue_IsValid;

	private static FFieldAddress GetMass_ReturnValue_PropertyAddress;

	private static int GetMass_ReturnValue_Offset;

	private static bool GetLinearDamping_IsValid;

	private static IntPtr GetLinearDamping_FunctionAddress;

	private static int GetLinearDamping_ParamsSize;

	private static bool GetLinearDamping_ReturnValue_IsValid;

	private static FFieldAddress GetLinearDamping_ReturnValue_PropertyAddress;

	private static int GetLinearDamping_ReturnValue_Offset;

	private static bool GetInertiaTensor_IsValid;

	private static IntPtr GetInertiaTensor_FunctionAddress;

	private static int GetInertiaTensor_ParamsSize;

	private static bool GetInertiaTensor_BoneName_IsValid;

	private static FFieldAddress GetInertiaTensor_BoneName_PropertyAddress;

	private static int GetInertiaTensor_BoneName_Offset;

	private static bool GetInertiaTensor_ReturnValue_IsValid;

	private static FFieldAddress GetInertiaTensor_ReturnValue_PropertyAddress;

	private static int GetInertiaTensor_ReturnValue_Offset;

	private static bool GetGenerateOverlapEvents_IsValid;

	private static IntPtr GetGenerateOverlapEvents_FunctionAddress;

	private static int GetGenerateOverlapEvents_ParamsSize;

	private static bool GetGenerateOverlapEvents_ReturnValue_IsValid;

	private static FFieldAddress GetGenerateOverlapEvents_ReturnValue_PropertyAddress;

	private static int GetGenerateOverlapEvents_ReturnValue_Offset;

	private static bool GetCustomPrimitiveDataIndexForVectorParameter_IsValid;

	private static IntPtr GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress;

	private static int GetCustomPrimitiveDataIndexForVectorParameter_ParamsSize;

	private static bool GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_IsValid;

	private static FFieldAddress GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_PropertyAddress;

	private static int GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_Offset;

	private static bool GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_IsValid;

	private static FFieldAddress GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_PropertyAddress;

	private static int GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_Offset;

	private static bool GetCustomPrimitiveDataIndexForScalarParameter_IsValid;

	private static IntPtr GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress;

	private static int GetCustomPrimitiveDataIndexForScalarParameter_ParamsSize;

	private static bool GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_IsValid;

	private static FFieldAddress GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_PropertyAddress;

	private static int GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_Offset;

	private static bool GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_IsValid;

	private static FFieldAddress GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_PropertyAddress;

	private static int GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_Offset;

	private static bool GetCollisionResponseToChannel_IsValid;

	private static IntPtr GetCollisionResponseToChannel_FunctionAddress;

	private static int GetCollisionResponseToChannel_ParamsSize;

	private static bool GetCollisionResponseToChannel_Channel_IsValid;

	private static FFieldAddress GetCollisionResponseToChannel_Channel_PropertyAddress;

	private static int GetCollisionResponseToChannel_Channel_Offset;

	private static bool GetCollisionResponseToChannel_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionResponseToChannel_ReturnValue_PropertyAddress;

	private static int GetCollisionResponseToChannel_ReturnValue_Offset;

	private static bool GetCollisionProfileName_IsValid;

	private static IntPtr GetCollisionProfileName_FunctionAddress;

	private static int GetCollisionProfileName_ParamsSize;

	private static bool GetCollisionProfileName_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionProfileName_ReturnValue_PropertyAddress;

	private static int GetCollisionProfileName_ReturnValue_Offset;

	private static bool GetCollisionObjectType_IsValid;

	private static IntPtr GetCollisionObjectType_FunctionAddress;

	private static int GetCollisionObjectType_ParamsSize;

	private static bool GetCollisionObjectType_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionObjectType_ReturnValue_PropertyAddress;

	private static int GetCollisionObjectType_ReturnValue_Offset;

	private static bool GetCollisionEnabled_IsValid;

	private static IntPtr GetCollisionEnabled_FunctionAddress;

	private static int GetCollisionEnabled_ParamsSize;

	private static bool GetCollisionEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionEnabled_ReturnValue_PropertyAddress;

	private static int GetCollisionEnabled_ReturnValue_Offset;

	private static bool GetClosestPointOnCollision_IsValid;

	private static IntPtr GetClosestPointOnCollision_FunctionAddress;

	private static int GetClosestPointOnCollision_ParamsSize;

	private static bool GetClosestPointOnCollision_Point_IsValid;

	private static FFieldAddress GetClosestPointOnCollision_Point_PropertyAddress;

	private static int GetClosestPointOnCollision_Point_Offset;

	private static bool GetClosestPointOnCollision_OutPointOnBody_IsValid;

	private static FFieldAddress GetClosestPointOnCollision_OutPointOnBody_PropertyAddress;

	private static int GetClosestPointOnCollision_OutPointOnBody_Offset;

	private static bool GetClosestPointOnCollision_BoneName_IsValid;

	private static FFieldAddress GetClosestPointOnCollision_BoneName_PropertyAddress;

	private static int GetClosestPointOnCollision_BoneName_Offset;

	private static bool GetClosestPointOnCollision_ReturnValue_IsValid;

	private static FFieldAddress GetClosestPointOnCollision_ReturnValue_PropertyAddress;

	private static int GetClosestPointOnCollision_ReturnValue_Offset;

	private static bool GetCenterOfMass_IsValid;

	private static IntPtr GetCenterOfMass_FunctionAddress;

	private static int GetCenterOfMass_ParamsSize;

	private static bool GetCenterOfMass_BoneName_IsValid;

	private static FFieldAddress GetCenterOfMass_BoneName_PropertyAddress;

	private static int GetCenterOfMass_BoneName_Offset;

	private static bool GetCenterOfMass_ReturnValue_IsValid;

	private static FFieldAddress GetCenterOfMass_ReturnValue_PropertyAddress;

	private static int GetCenterOfMass_ReturnValue_Offset;

	private static bool GetAngularDamping_IsValid;

	private static IntPtr GetAngularDamping_FunctionAddress;

	private static int GetAngularDamping_ParamsSize;

	private static bool GetAngularDamping_ReturnValue_IsValid;

	private static FFieldAddress GetAngularDamping_ReturnValue_PropertyAddress;

	private static int GetAngularDamping_ReturnValue_Offset;

	private static bool CreateDynamicMaterialInstance_IsValid;

	private static IntPtr CreateDynamicMaterialInstance_FunctionAddress;

	private static int CreateDynamicMaterialInstance_ParamsSize;

	private static bool CreateDynamicMaterialInstance_ElementIndex_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_ElementIndex_PropertyAddress;

	private static int CreateDynamicMaterialInstance_ElementIndex_Offset;

	private static bool CreateDynamicMaterialInstance_SourceMaterial_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_SourceMaterial_PropertyAddress;

	private static int CreateDynamicMaterialInstance_SourceMaterial_Offset;

	private static bool CreateDynamicMaterialInstance_OptionalName_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_OptionalName_PropertyAddress;

	private static int CreateDynamicMaterialInstance_OptionalName_Offset;

	private static bool CreateDynamicMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_ReturnValue_PropertyAddress;

	private static int CreateDynamicMaterialInstance_ReturnValue_Offset;

	private static bool CopyArrayOfMoveIgnoreComponents_IsValid;

	private static IntPtr CopyArrayOfMoveIgnoreComponents_FunctionAddress;

	private static int CopyArrayOfMoveIgnoreComponents_ParamsSize;

	private static bool CopyArrayOfMoveIgnoreComponents_ReturnValue_IsValid;

	private static FFieldAddress CopyArrayOfMoveIgnoreComponents_ReturnValue_PropertyAddress;

	private static int CopyArrayOfMoveIgnoreComponents_ReturnValue_Offset;

	private static bool CopyArrayOfMoveIgnoreActors_IsValid;

	private static IntPtr CopyArrayOfMoveIgnoreActors_FunctionAddress;

	private static int CopyArrayOfMoveIgnoreActors_ParamsSize;

	private static bool CopyArrayOfMoveIgnoreActors_ReturnValue_IsValid;

	private static FFieldAddress CopyArrayOfMoveIgnoreActors_ReturnValue_PropertyAddress;

	private static int CopyArrayOfMoveIgnoreActors_ReturnValue_Offset;

	private static bool ClearMoveIgnoreComponents_IsValid;

	private static IntPtr ClearMoveIgnoreComponents_FunctionAddress;

	private static int ClearMoveIgnoreComponents_ParamsSize;

	private static bool ClearMoveIgnoreActors_IsValid;

	private static IntPtr ClearMoveIgnoreActors_FunctionAddress;

	private static int ClearMoveIgnoreActors_ParamsSize;

	private static bool CanCharacterStepUp_IsValid;

	private static IntPtr CanCharacterStepUp_FunctionAddress;

	private static int CanCharacterStepUp_ParamsSize;

	private static bool CanCharacterStepUp_Pawn_IsValid;

	private static FFieldAddress CanCharacterStepUp_Pawn_PropertyAddress;

	private static int CanCharacterStepUp_Pawn_Offset;

	private static bool CanCharacterStepUp_ReturnValue_IsValid;

	private static FFieldAddress CanCharacterStepUp_ReturnValue_PropertyAddress;

	private static int CanCharacterStepUp_ReturnValue_Offset;

	private static bool AddVelocityChangeImpulseAtLocation_IsValid;

	private static IntPtr AddVelocityChangeImpulseAtLocation_FunctionAddress;

	private static int AddVelocityChangeImpulseAtLocation_ParamsSize;

	private static bool AddVelocityChangeImpulseAtLocation_Impulse_IsValid;

	private static FFieldAddress AddVelocityChangeImpulseAtLocation_Impulse_PropertyAddress;

	private static int AddVelocityChangeImpulseAtLocation_Impulse_Offset;

	private static bool AddVelocityChangeImpulseAtLocation_Location_IsValid;

	private static FFieldAddress AddVelocityChangeImpulseAtLocation_Location_PropertyAddress;

	private static int AddVelocityChangeImpulseAtLocation_Location_Offset;

	private static bool AddVelocityChangeImpulseAtLocation_BoneName_IsValid;

	private static FFieldAddress AddVelocityChangeImpulseAtLocation_BoneName_PropertyAddress;

	private static int AddVelocityChangeImpulseAtLocation_BoneName_Offset;

	private static bool AddTorqueInRadians_IsValid;

	private static IntPtr AddTorqueInRadians_FunctionAddress;

	private static int AddTorqueInRadians_ParamsSize;

	private static bool AddTorqueInRadians_Torque_IsValid;

	private static FFieldAddress AddTorqueInRadians_Torque_PropertyAddress;

	private static int AddTorqueInRadians_Torque_Offset;

	private static bool AddTorqueInRadians_BoneName_IsValid;

	private static FFieldAddress AddTorqueInRadians_BoneName_PropertyAddress;

	private static int AddTorqueInRadians_BoneName_Offset;

	private static bool AddTorqueInRadians_bAccelChange_IsValid;

	private static FFieldAddress AddTorqueInRadians_bAccelChange_PropertyAddress;

	private static int AddTorqueInRadians_bAccelChange_Offset;

	private static bool AddTorqueInDegrees_IsValid;

	private static IntPtr AddTorqueInDegrees_FunctionAddress;

	private static int AddTorqueInDegrees_ParamsSize;

	private static bool AddTorqueInDegrees_Torque_IsValid;

	private static FFieldAddress AddTorqueInDegrees_Torque_PropertyAddress;

	private static int AddTorqueInDegrees_Torque_Offset;

	private static bool AddTorqueInDegrees_BoneName_IsValid;

	private static FFieldAddress AddTorqueInDegrees_BoneName_PropertyAddress;

	private static int AddTorqueInDegrees_BoneName_Offset;

	private static bool AddTorqueInDegrees_bAccelChange_IsValid;

	private static FFieldAddress AddTorqueInDegrees_bAccelChange_PropertyAddress;

	private static int AddTorqueInDegrees_bAccelChange_Offset;

	private static bool AddRadialImpulse_IsValid;

	private static IntPtr AddRadialImpulse_FunctionAddress;

	private static int AddRadialImpulse_ParamsSize;

	private static bool AddRadialImpulse_Origin_IsValid;

	private static FFieldAddress AddRadialImpulse_Origin_PropertyAddress;

	private static int AddRadialImpulse_Origin_Offset;

	private static bool AddRadialImpulse_Radius_IsValid;

	private static FFieldAddress AddRadialImpulse_Radius_PropertyAddress;

	private static int AddRadialImpulse_Radius_Offset;

	private static bool AddRadialImpulse_Strength_IsValid;

	private static FFieldAddress AddRadialImpulse_Strength_PropertyAddress;

	private static int AddRadialImpulse_Strength_Offset;

	private static bool AddRadialImpulse_Falloff_IsValid;

	private static FFieldAddress AddRadialImpulse_Falloff_PropertyAddress;

	private static int AddRadialImpulse_Falloff_Offset;

	private static bool AddRadialImpulse_bVelChange_IsValid;

	private static FFieldAddress AddRadialImpulse_bVelChange_PropertyAddress;

	private static int AddRadialImpulse_bVelChange_Offset;

	private static bool AddRadialForce_IsValid;

	private static IntPtr AddRadialForce_FunctionAddress;

	private static int AddRadialForce_ParamsSize;

	private static bool AddRadialForce_Origin_IsValid;

	private static FFieldAddress AddRadialForce_Origin_PropertyAddress;

	private static int AddRadialForce_Origin_Offset;

	private static bool AddRadialForce_Radius_IsValid;

	private static FFieldAddress AddRadialForce_Radius_PropertyAddress;

	private static int AddRadialForce_Radius_Offset;

	private static bool AddRadialForce_Strength_IsValid;

	private static FFieldAddress AddRadialForce_Strength_PropertyAddress;

	private static int AddRadialForce_Strength_Offset;

	private static bool AddRadialForce_Falloff_IsValid;

	private static FFieldAddress AddRadialForce_Falloff_PropertyAddress;

	private static int AddRadialForce_Falloff_Offset;

	private static bool AddRadialForce_bAccelChange_IsValid;

	private static FFieldAddress AddRadialForce_bAccelChange_PropertyAddress;

	private static int AddRadialForce_bAccelChange_Offset;

	private static bool AddImpulseAtLocation_IsValid;

	private static IntPtr AddImpulseAtLocation_FunctionAddress;

	private static int AddImpulseAtLocation_ParamsSize;

	private static bool AddImpulseAtLocation_Impulse_IsValid;

	private static FFieldAddress AddImpulseAtLocation_Impulse_PropertyAddress;

	private static int AddImpulseAtLocation_Impulse_Offset;

	private static bool AddImpulseAtLocation_Location_IsValid;

	private static FFieldAddress AddImpulseAtLocation_Location_PropertyAddress;

	private static int AddImpulseAtLocation_Location_Offset;

	private static bool AddImpulseAtLocation_BoneName_IsValid;

	private static FFieldAddress AddImpulseAtLocation_BoneName_PropertyAddress;

	private static int AddImpulseAtLocation_BoneName_Offset;

	private static bool AddImpulse_IsValid;

	private static IntPtr AddImpulse_FunctionAddress;

	private static int AddImpulse_ParamsSize;

	private static bool AddImpulse_Impulse_IsValid;

	private static FFieldAddress AddImpulse_Impulse_PropertyAddress;

	private static int AddImpulse_Impulse_Offset;

	private static bool AddImpulse_BoneName_IsValid;

	private static FFieldAddress AddImpulse_BoneName_PropertyAddress;

	private static int AddImpulse_BoneName_Offset;

	private static bool AddImpulse_bVelChange_IsValid;

	private static FFieldAddress AddImpulse_bVelChange_PropertyAddress;

	private static int AddImpulse_bVelChange_Offset;

	private static bool AddForceAtLocationLocal_IsValid;

	private static IntPtr AddForceAtLocationLocal_FunctionAddress;

	private static int AddForceAtLocationLocal_ParamsSize;

	private static bool AddForceAtLocationLocal_Force_IsValid;

	private static FFieldAddress AddForceAtLocationLocal_Force_PropertyAddress;

	private static int AddForceAtLocationLocal_Force_Offset;

	private static bool AddForceAtLocationLocal_Location_IsValid;

	private static FFieldAddress AddForceAtLocationLocal_Location_PropertyAddress;

	private static int AddForceAtLocationLocal_Location_Offset;

	private static bool AddForceAtLocationLocal_BoneName_IsValid;

	private static FFieldAddress AddForceAtLocationLocal_BoneName_PropertyAddress;

	private static int AddForceAtLocationLocal_BoneName_Offset;

	private static bool AddForceAtLocation_IsValid;

	private static IntPtr AddForceAtLocation_FunctionAddress;

	private static int AddForceAtLocation_ParamsSize;

	private static bool AddForceAtLocation_Force_IsValid;

	private static FFieldAddress AddForceAtLocation_Force_PropertyAddress;

	private static int AddForceAtLocation_Force_Offset;

	private static bool AddForceAtLocation_Location_IsValid;

	private static FFieldAddress AddForceAtLocation_Location_PropertyAddress;

	private static int AddForceAtLocation_Location_Offset;

	private static bool AddForceAtLocation_BoneName_IsValid;

	private static FFieldAddress AddForceAtLocation_BoneName_PropertyAddress;

	private static int AddForceAtLocation_BoneName_Offset;

	private static bool AddForce_IsValid;

	private static IntPtr AddForce_FunctionAddress;

	private static int AddForce_ParamsSize;

	private static bool AddForce_Force_IsValid;

	private static FFieldAddress AddForce_Force_PropertyAddress;

	private static int AddForce_Force_Offset;

	private static bool AddForce_BoneName_IsValid;

	private static FFieldAddress AddForce_BoneName_PropertyAddress;

	private static int AddForce_BoneName_Offset;

	private static bool AddForce_bAccelChange_IsValid;

	private static FFieldAddress AddForce_bAccelChange_PropertyAddress;

	private static int AddForce_bAccelChange_Offset;

	private static bool AddAngularImpulseInRadians_IsValid;

	private static IntPtr AddAngularImpulseInRadians_FunctionAddress;

	private static int AddAngularImpulseInRadians_ParamsSize;

	private static bool AddAngularImpulseInRadians_Impulse_IsValid;

	private static FFieldAddress AddAngularImpulseInRadians_Impulse_PropertyAddress;

	private static int AddAngularImpulseInRadians_Impulse_Offset;

	private static bool AddAngularImpulseInRadians_BoneName_IsValid;

	private static FFieldAddress AddAngularImpulseInRadians_BoneName_PropertyAddress;

	private static int AddAngularImpulseInRadians_BoneName_Offset;

	private static bool AddAngularImpulseInRadians_bVelChange_IsValid;

	private static FFieldAddress AddAngularImpulseInRadians_bVelChange_PropertyAddress;

	private static int AddAngularImpulseInRadians_bVelChange_Offset;

	private static bool AddAngularImpulseInDegrees_IsValid;

	private static IntPtr AddAngularImpulseInDegrees_FunctionAddress;

	private static int AddAngularImpulseInDegrees_ParamsSize;

	private static bool AddAngularImpulseInDegrees_Impulse_IsValid;

	private static FFieldAddress AddAngularImpulseInDegrees_Impulse_PropertyAddress;

	private static int AddAngularImpulseInDegrees_Impulse_Offset;

	private static bool AddAngularImpulseInDegrees_BoneName_IsValid;

	private static FFieldAddress AddAngularImpulseInDegrees_BoneName_PropertyAddress;

	private static int AddAngularImpulseInDegrees_BoneName_Offset;

	private static bool AddAngularImpulseInDegrees_bVelChange_IsValid;

	private static FFieldAddress AddAngularImpulseInDegrees_bVelChange_PropertyAddress;

	private static int AddAngularImpulseInDegrees_bVelChange_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:MinDrawDistance")]
	public float MinDrawDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:MinDrawDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDrawDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:MinDrawDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDrawDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:LDMaxDrawDistance")]
	public float LDMaxDrawDistance
	{
		get
		{
			CheckDestroyed();
			if (!LDMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LDMaxDrawDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LDMaxDrawDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LDMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LDMaxDrawDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LDMaxDrawDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280917013uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CachedMaxDrawDistance")]
	public float CachedMaxDrawDistance
	{
		get
		{
			CheckDestroyed();
			if (!CachedMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CachedMaxDrawDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CachedMaxDrawDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CachedMaxDrawDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CachedMaxDrawDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CachedMaxDrawDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IndirectLightingCacheQuality")]
	public EIndirectLightingCacheQuality IndirectLightingCacheQuality
	{
		get
		{
			CheckDestroyed();
			if (!IndirectLightingCacheQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:IndirectLightingCacheQuality");
				return EIndirectLightingCacheQuality.ILCQ_Off;
			}
			return EnumMarshaler<EIndirectLightingCacheQuality>.FromNative(IntPtr.Add(base.Address, IndirectLightingCacheQuality_Offset), 0, IndirectLightingCacheQuality_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IndirectLightingCacheQuality_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:IndirectLightingCacheQuality");
			}
			else
			{
				EnumMarshaler<EIndirectLightingCacheQuality>.ToNative(IntPtr.Add(base.Address, IndirectLightingCacheQuality_Offset), 0, IndirectLightingCacheQuality_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:LightmapType")]
	public ELightmapType LightmapType
	{
		get
		{
			CheckDestroyed();
			if (!LightmapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LightmapType");
				return ELightmapType.Default;
			}
			return EnumMarshaler<ELightmapType>.FromNative(IntPtr.Add(base.Address, LightmapType_Offset), 0, LightmapType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LightmapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LightmapType");
			}
			else
			{
				EnumMarshaler<ELightmapType>.ToNative(IntPtr.Add(base.Address, LightmapType_Offset), 0, LightmapType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bEnableAutoLODGeneration")]
	public bool EnableAutoLODGeneration
	{
		get
		{
			CheckDestroyed();
			if (!EnableAutoLODGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEnableAutoLODGeneration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableAutoLODGeneration_Offset), 0, EnableAutoLODGeneration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableAutoLODGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEnableAutoLODGeneration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableAutoLODGeneration_Offset), 0, EnableAutoLODGeneration_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508032033620485uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:ExcludeForSpecificHLODLevels")]
	public TArrayReadWrite<int> ExcludeForSpecificHLODLevels
	{
		get
		{
			CheckDestroyed();
			if (!ExcludeForSpecificHLODLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:ExcludeForSpecificHLODLevels");
				return null;
			}
			if (ExcludeForSpecificHLODLevels_MarshalerCached == null)
			{
				ExcludeForSpecificHLODLevels_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, ExcludeForSpecificHLODLevels_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ExcludeForSpecificHLODLevels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExcludeForSpecificHLODLevels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524293uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:HLODBatchingPolicy")]
	public EHLODBatchingPolicy HLODBatchingPolicy
	{
		get
		{
			CheckDestroyed();
			if (!HLODBatchingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:HLODBatchingPolicy");
				return EHLODBatchingPolicy.None;
			}
			return EnumMarshaler<EHLODBatchingPolicy>.FromNative(IntPtr.Add(base.Address, HLODBatchingPolicy_Offset), 0, HLODBatchingPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HLODBatchingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:HLODBatchingPolicy");
			}
			else
			{
				EnumMarshaler<EHLODBatchingPolicy>.ToNative(IntPtr.Add(base.Address, HLODBatchingPolicy_Offset), 0, HLODBatchingPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bNeverDistanceCull")]
	public bool NeverDistanceCull
	{
		get
		{
			CheckDestroyed();
			if (!NeverDistanceCull_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bNeverDistanceCull");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeverDistanceCull_Offset), 0, NeverDistanceCull_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeverDistanceCull_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bNeverDistanceCull");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeverDistanceCull_Offset), 0, NeverDistanceCull_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bAlwaysCreatePhysicsState")]
	public bool AlwaysCreatePhysicsState
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysCreatePhysicsState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAlwaysCreatePhysicsState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysCreatePhysicsState_Offset), 0, AlwaysCreatePhysicsState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysCreatePhysicsState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAlwaysCreatePhysicsState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysCreatePhysicsState_Offset), 0, AlwaysCreatePhysicsState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bMultiBodyOverlap")]
	public bool MultiBodyOverlap
	{
		get
		{
			CheckDestroyed();
			if (!MultiBodyOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bMultiBodyOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiBodyOverlap_Offset), 0, MultiBodyOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiBodyOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bMultiBodyOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiBodyOverlap_Offset), 0, MultiBodyOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bTraceComplexOnMove")]
	public bool TraceComplexOnMove
	{
		get
		{
			CheckDestroyed();
			if (!TraceComplexOnMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bTraceComplexOnMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TraceComplexOnMove_Offset), 0, TraceComplexOnMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceComplexOnMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bTraceComplexOnMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TraceComplexOnMove_Offset), 0, TraceComplexOnMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bReturnMaterialOnMove")]
	public bool ReturnMaterialOnMove
	{
		get
		{
			CheckDestroyed();
			if (!ReturnMaterialOnMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReturnMaterialOnMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReturnMaterialOnMove_Offset), 0, ReturnMaterialOnMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReturnMaterialOnMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReturnMaterialOnMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReturnMaterialOnMove_Offset), 0, ReturnMaterialOnMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bAllowCullDistanceVolume")]
	public bool AllowCullDistanceVolume
	{
		get
		{
			CheckDestroyed();
			if (!AllowCullDistanceVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAllowCullDistanceVolume");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowCullDistanceVolume_Offset), 0, AllowCullDistanceVolume_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowCullDistanceVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAllowCullDistanceVolume");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowCullDistanceVolume_Offset), 0, AllowCullDistanceVolume_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bVisibleInReflectionCaptures")]
	public bool VisibleInReflectionCaptures
	{
		get
		{
			CheckDestroyed();
			if (!VisibleInReflectionCaptures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInReflectionCaptures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VisibleInReflectionCaptures_Offset), 0, VisibleInReflectionCaptures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibleInReflectionCaptures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInReflectionCaptures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VisibleInReflectionCaptures_Offset), 0, VisibleInReflectionCaptures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bVisibleInRealTimeSkyCaptures")]
	public bool VisibleInRealTimeSkyCaptures
	{
		get
		{
			CheckDestroyed();
			if (!VisibleInRealTimeSkyCaptures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInRealTimeSkyCaptures");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VisibleInRealTimeSkyCaptures_Offset), 0, VisibleInRealTimeSkyCaptures_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibleInRealTimeSkyCaptures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInRealTimeSkyCaptures");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VisibleInRealTimeSkyCaptures_Offset), 0, VisibleInRealTimeSkyCaptures_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bVisibleInRayTracing")]
	public bool VisibleInRayTracing
	{
		get
		{
			CheckDestroyed();
			if (!VisibleInRayTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInRayTracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VisibleInRayTracing_Offset), 0, VisibleInRayTracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibleInRayTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInRayTracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VisibleInRayTracing_Offset), 0, VisibleInRayTracing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastHybridRayTracingShadow")]
	public bool CastHybridRayTracingShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastHybridRayTracingShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastHybridRayTracingShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastHybridRayTracingShadow_Offset), 0, CastHybridRayTracingShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastHybridRayTracingShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastHybridRayTracingShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastHybridRayTracingShadow_Offset), 0, CastHybridRayTracingShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bSkeletalMeshOutputRTDepthMaskInDepthPass")]
	public bool SkeletalMeshOutputRTDepthMaskInDepthPass
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMeshOutputRTDepthMaskInDepthPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSkeletalMeshOutputRTDepthMaskInDepthPass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkeletalMeshOutputRTDepthMaskInDepthPass_Offset), 0, SkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMeshOutputRTDepthMaskInDepthPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSkeletalMeshOutputRTDepthMaskInDepthPass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkeletalMeshOutputRTDepthMaskInDepthPass_Offset), 0, SkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderInMainPass")]
	public bool RenderInMainPass
	{
		get
		{
			CheckDestroyed();
			if (!RenderInMainPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInMainPass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderInMainPass_Offset), 0, RenderInMainPass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderInMainPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInMainPass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderInMainPass_Offset), 0, RenderInMainPass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderInMBOIT")]
	public bool RenderInMBOIT
	{
		get
		{
			CheckDestroyed();
			if (!RenderInMBOIT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInMBOIT");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderInMBOIT_Offset), 0, RenderInMBOIT_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderInMBOIT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInMBOIT");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderInMBOIT_Offset), 0, RenderInMBOIT_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderTranslucentDepth")]
	public bool RenderTranslucentDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderTranslucentDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderTranslucentDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderTranslucentDepth_Offset), 0, RenderTranslucentDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderTranslucentDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderTranslucentDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderTranslucentDepth_Offset), 0, RenderTranslucentDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:TranslucentDepthOpacityMask")]
	public float TranslucentDepthOpacityMask
	{
		get
		{
			CheckDestroyed();
			if (!TranslucentDepthOpacityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucentDepthOpacityMask");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TranslucentDepthOpacityMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslucentDepthOpacityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucentDepthOpacityMask");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TranslucentDepthOpacityMask_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:PerObjectShadowResScale")]
	public float PerObjectShadowResScale
	{
		get
		{
			CheckDestroyed();
			if (!PerObjectShadowResScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:PerObjectShadowResScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PerObjectShadowResScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerObjectShadowResScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:PerObjectShadowResScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PerObjectShadowResScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderInDepthPass")]
	public bool RenderInDepthPass
	{
		get
		{
			CheckDestroyed();
			if (!RenderInDepthPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInDepthPass");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderInDepthPass_Offset), 0, RenderInDepthPass_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderInDepthPass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderInDepthPass");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderInDepthPass_Offset), 0, RenderInDepthPass_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bReceivesDecals")]
	public bool ReceivesDecals
	{
		get
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReceivesDecals");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReceivesDecals_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReceivesDecals");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReceivesDecals_Offset), 0, ReceivesDecals_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bOwnerNoSee")]
	public bool OwnerNoSee
	{
		get
		{
			CheckDestroyed();
			if (!OwnerNoSee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bOwnerNoSee");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OwnerNoSee_Offset), 0, OwnerNoSee_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OwnerNoSee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bOwnerNoSee");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OwnerNoSee_Offset), 0, OwnerNoSee_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bOnlyOwnerSee")]
	public bool OnlyOwnerSee
	{
		get
		{
			CheckDestroyed();
			if (!OnlyOwnerSee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bOnlyOwnerSee");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyOwnerSee_Offset), 0, OnlyOwnerSee_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyOwnerSee_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bOnlyOwnerSee");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyOwnerSee_Offset), 0, OnlyOwnerSee_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bTreatAsBackgroundForOcclusion")]
	public bool TreatAsBackgroundForOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!TreatAsBackgroundForOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bTreatAsBackgroundForOcclusion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TreatAsBackgroundForOcclusion_Offset), 0, TreatAsBackgroundForOcclusion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TreatAsBackgroundForOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bTreatAsBackgroundForOcclusion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TreatAsBackgroundForOcclusion_Offset), 0, TreatAsBackgroundForOcclusion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bUseAsOccluder")]
	public bool UseAsOccluder
	{
		get
		{
			CheckDestroyed();
			if (!UseAsOccluder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bUseAsOccluder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseAsOccluder_Offset), 0, UseAsOccluder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseAsOccluder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bUseAsOccluder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseAsOccluder_Offset), 0, UseAsOccluder_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bForceMipStreaming")]
	public bool ForceMipStreaming
	{
		get
		{
			CheckDestroyed();
			if (!ForceMipStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bForceMipStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceMipStreaming_Offset), 0, ForceMipStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceMipStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bForceMipStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceMipStreaming_Offset), 0, ForceMipStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CastShadow")]
	public bool CastShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CastShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CastShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadow_Offset), 0, CastShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bEmissiveLightSource")]
	public bool EmissiveLightSource
	{
		get
		{
			CheckDestroyed();
			if (!EmissiveLightSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEmissiveLightSource");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EmissiveLightSource_Offset), 0, EmissiveLightSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EmissiveLightSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEmissiveLightSource");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EmissiveLightSource_Offset), 0, EmissiveLightSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bAffectDynamicIndirectLighting")]
	public bool AffectDynamicIndirectLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAffectDynamicIndirectLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAffectDynamicIndirectLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bAffectDistanceFieldLighting")]
	public bool AffectDistanceFieldLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAffectDistanceFieldLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDistanceFieldLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bAffectDistanceFieldLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDistanceFieldLighting_Offset), 0, AffectDistanceFieldLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastDynamicShadow")]
	public bool CastDynamicShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastDynamicShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastDynamicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastDynamicShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastDynamicShadow_Offset), 0, CastDynamicShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastStaticShadow")]
	public bool CastStaticShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastStaticShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastStaticShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastStaticShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastStaticShadow_Offset), 0, CastStaticShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:WPOEvaluateDistanceScale")]
	public float WPOEvaluateDistanceScale
	{
		get
		{
			CheckDestroyed();
			if (!WPOEvaluateDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:WPOEvaluateDistanceScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WPOEvaluateDistanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WPOEvaluateDistanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:WPOEvaluateDistanceScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WPOEvaluateDistanceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastVolumetricTranslucentShadow")]
	public bool CastVolumetricTranslucentShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastVolumetricTranslucentShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastVolumetricTranslucentShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastVolumetricTranslucentShadow_Offset), 0, CastVolumetricTranslucentShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastVolumetricTranslucentShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastVolumetricTranslucentShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastVolumetricTranslucentShadow_Offset), 0, CastVolumetricTranslucentShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastContactShadow")]
	public bool CastContactShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastContactShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastContactShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastContactShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastContactShadow_Offset), 0, CastContactShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bSelfShadowOnly")]
	public bool SelfShadowOnly
	{
		get
		{
			CheckDestroyed();
			if (!SelfShadowOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSelfShadowOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SelfShadowOnly_Offset), 0, SelfShadowOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SelfShadowOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSelfShadowOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SelfShadowOnly_Offset), 0, SelfShadowOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastFarShadow")]
	public bool CastFarShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastFarShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastFarShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastFarShadow_Offset), 0, CastFarShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastFarShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastFarShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastFarShadow_Offset), 0, CastFarShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastInsetShadow")]
	public bool CastInsetShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastInsetShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastInsetShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastInsetShadow_Offset), 0, CastInsetShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastInsetShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastInsetShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastInsetShadow_Offset), 0, CastInsetShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastCinematicShadow")]
	public bool CastCinematicShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastCinematicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastCinematicShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastCinematicShadow_Offset), 0, CastCinematicShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastCinematicShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastCinematicShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastCinematicShadow_Offset), 0, CastCinematicShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastHiddenShadow")]
	public bool CastHiddenShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastHiddenShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastHiddenShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastHiddenShadow_Offset), 0, CastHiddenShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastHiddenShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastHiddenShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastHiddenShadow_Offset), 0, CastHiddenShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bCastShadowAsTwoSided")]
	public bool CastShadowAsTwoSided
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastShadowAsTwoSided");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowAsTwoSided_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bCastShadowAsTwoSided");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowAsTwoSided_Offset), 0, CastShadowAsTwoSided_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bLightAttachmentsAsGroup")]
	public bool LightAttachmentsAsGroup
	{
		get
		{
			CheckDestroyed();
			if (!LightAttachmentsAsGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bLightAttachmentsAsGroup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LightAttachmentsAsGroup_Offset), 0, LightAttachmentsAsGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LightAttachmentsAsGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bLightAttachmentsAsGroup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LightAttachmentsAsGroup_Offset), 0, LightAttachmentsAsGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bExcludeFromLightAttachmentGroup")]
	public bool ExcludeFromLightAttachmentGroup
	{
		get
		{
			CheckDestroyed();
			if (!ExcludeFromLightAttachmentGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bExcludeFromLightAttachmentGroup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExcludeFromLightAttachmentGroup_Offset), 0, ExcludeFromLightAttachmentGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExcludeFromLightAttachmentGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bExcludeFromLightAttachmentGroup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExcludeFromLightAttachmentGroup_Offset), 0, ExcludeFromLightAttachmentGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bReceiveMobileCSMShadows")]
	public bool ReceiveMobileCSMShadows
	{
		get
		{
			CheckDestroyed();
			if (!ReceiveMobileCSMShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReceiveMobileCSMShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReceiveMobileCSMShadows_Offset), 0, ReceiveMobileCSMShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReceiveMobileCSMShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReceiveMobileCSMShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReceiveMobileCSMShadows_Offset), 0, ReceiveMobileCSMShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bSingleSampleShadowFromStationaryLights")]
	public bool SingleSampleShadowFromStationaryLights
	{
		get
		{
			CheckDestroyed();
			if (!SingleSampleShadowFromStationaryLights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSingleSampleShadowFromStationaryLights");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SingleSampleShadowFromStationaryLights_Offset), 0, SingleSampleShadowFromStationaryLights_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SingleSampleShadowFromStationaryLights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bSingleSampleShadowFromStationaryLights");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SingleSampleShadowFromStationaryLights_Offset), 0, SingleSampleShadowFromStationaryLights_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bIgnoreRadialImpulse")]
	public bool IgnoreRadialImpulse
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreRadialImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bIgnoreRadialImpulse");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreRadialImpulse_Offset), 0, IgnoreRadialImpulse_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreRadialImpulse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bIgnoreRadialImpulse");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreRadialImpulse_Offset), 0, IgnoreRadialImpulse_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bIgnoreRadialForce")]
	public bool IgnoreRadialForce
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreRadialForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bIgnoreRadialForce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreRadialForce_Offset), 0, IgnoreRadialForce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreRadialForce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bIgnoreRadialForce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreRadialForce_Offset), 0, IgnoreRadialForce_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bApplyImpulseOnDamage")]
	public bool ApplyImpulseOnDamage
	{
		get
		{
			CheckDestroyed();
			if (!ApplyImpulseOnDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bApplyImpulseOnDamage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyImpulseOnDamage_Offset), 0, ApplyImpulseOnDamage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyImpulseOnDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bApplyImpulseOnDamage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyImpulseOnDamage_Offset), 0, ApplyImpulseOnDamage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bReplicatePhysicsToAutonomousProxy")]
	public bool ReplicatePhysicsToAutonomousProxy
	{
		get
		{
			CheckDestroyed();
			if (!ReplicatePhysicsToAutonomousProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReplicatePhysicsToAutonomousProxy");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ReplicatePhysicsToAutonomousProxy_Offset), 0, ReplicatePhysicsToAutonomousProxy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReplicatePhysicsToAutonomousProxy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bReplicatePhysicsToAutonomousProxy");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ReplicatePhysicsToAutonomousProxy_Offset), 0, ReplicatePhysicsToAutonomousProxy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderCustomDepth")]
	public bool RenderCustomDepth
	{
		get
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderCustomDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderCustomDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderCustomDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderCustomDepth_Offset), 0, RenderCustomDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bVisibleInSceneCaptureOnly")]
	public bool VisibleInSceneCaptureOnly
	{
		get
		{
			CheckDestroyed();
			if (!VisibleInSceneCaptureOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInSceneCaptureOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, VisibleInSceneCaptureOnly_Offset), 0, VisibleInSceneCaptureOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibleInSceneCaptureOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bVisibleInSceneCaptureOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, VisibleInSceneCaptureOnly_Offset), 0, VisibleInSceneCaptureOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bHiddenInSceneCapture")]
	public bool HiddenInSceneCapture
	{
		get
		{
			CheckDestroyed();
			if (!HiddenInSceneCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bHiddenInSceneCapture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HiddenInSceneCapture_Offset), 0, HiddenInSceneCapture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HiddenInSceneCapture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bHiddenInSceneCapture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HiddenInSceneCapture_Offset), 0, HiddenInSceneCapture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bRenderGSVoxelization")]
	public bool RenderGSVoxelization
	{
		get
		{
			CheckDestroyed();
			if (!RenderGSVoxelization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderGSVoxelization");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderGSVoxelization_Offset), 0, RenderGSVoxelization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderGSVoxelization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bRenderGSVoxelization");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderGSVoxelization_Offset), 0, RenderGSVoxelization_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bEvaluateRayTracingWaterCaustics")]
	public bool EvaluateRayTracingWaterCaustics
	{
		get
		{
			CheckDestroyed();
			if (!EvaluateRayTracingWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEvaluateRayTracingWaterCaustics");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EvaluateRayTracingWaterCaustics_Offset), 0, EvaluateRayTracingWaterCaustics_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EvaluateRayTracingWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bEvaluateRayTracingWaterCaustics");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EvaluateRayTracingWaterCaustics_Offset), 0, EvaluateRayTracingWaterCaustics_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:bForceRenderInLumenScene")]
	public bool ForceRenderInLumenScene
	{
		get
		{
			CheckDestroyed();
			if (!ForceRenderInLumenScene_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bForceRenderInLumenScene");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceRenderInLumenScene_Offset), 0, ForceRenderInLumenScene_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceRenderInLumenScene_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:bForceRenderInLumenScene");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceRenderInLumenScene_Offset), 0, ForceRenderInLumenScene_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CanCharacterStepUpOn")]
	public ECanBeCharacterBase CanCharacterStepUpOn
	{
		get
		{
			CheckDestroyed();
			if (!CanCharacterStepUpOn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CanCharacterStepUpOn");
				return ECanBeCharacterBase.ECB_No;
			}
			return EnumMarshaler<ECanBeCharacterBase>.FromNative(IntPtr.Add(base.Address, CanCharacterStepUpOn_Offset), 0, CanCharacterStepUpOn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanCharacterStepUpOn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CanCharacterStepUpOn");
			}
			else
			{
				EnumMarshaler<ECanBeCharacterBase>.ToNative(IntPtr.Add(base.Address, CanCharacterStepUpOn_Offset), 0, CanCharacterStepUpOn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:LightingChannels")]
	public FLightingChannels LightingChannels
	{
		get
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LightingChannels");
				return default(FLightingChannels);
			}
			return FLightingChannels.FromNative(IntPtr.Add(base.Address, LightingChannels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:LightingChannels");
			}
			else
			{
				FLightingChannels.ToNative(IntPtr.Add(base.Address, LightingChannels_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:RayTracingGroupId")]
	public int RayTracingGroupId
	{
		get
		{
			CheckDestroyed();
			if (!RayTracingGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:RayTracingGroupId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RayTracingGroupId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayTracingGroupId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:RayTracingGroupId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RayTracingGroupId_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CustomDepthStencilValue")]
	public int CustomDepthStencilValue
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CustomDepthStencilValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CustomDepthStencilValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:TranslucencySortPriority")]
	public int TranslucencySortPriority
	{
		get
		{
			CheckDestroyed();
			if (!TranslucencySortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucencySortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TranslucencySortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslucencySortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucencySortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TranslucencySortPriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:TranslucencySortDistanceOffset")]
	public float TranslucencySortDistanceOffset
	{
		get
		{
			CheckDestroyed();
			if (!TranslucencySortDistanceOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucencySortDistanceOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TranslucencySortDistanceOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslucencySortDistanceOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:TranslucencySortDistanceOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TranslucencySortDistanceOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:RuntimeVirtualTextures")]
	public TArrayReadWrite<URuntimeVirtualTexture> RuntimeVirtualTextures
	{
		get
		{
			CheckDestroyed();
			if (!RuntimeVirtualTextures_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:RuntimeVirtualTextures");
				return null;
			}
			if (RuntimeVirtualTextures_MarshalerCached == null)
			{
				RuntimeVirtualTextures_MarshalerCached = new TArrayReadWriteMarshaler<URuntimeVirtualTexture>(1, RuntimeVirtualTextures_PropertyAddress, CachedMarshalingDelegates<URuntimeVirtualTexture, UObjectMarshaler<URuntimeVirtualTexture>>.FromNative, CachedMarshalingDelegates<URuntimeVirtualTexture, UObjectMarshaler<URuntimeVirtualTexture>>.ToNative);
			}
			return RuntimeVirtualTextures_MarshalerCached.FromNative(IntPtr.Add(base.Address, RuntimeVirtualTextures_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:VirtualTextureRenderPassType")]
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType
	{
		get
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:VirtualTextureRenderPassType");
				return ERuntimeVirtualTextureMainPassType.Never;
			}
			return EnumMarshaler<ERuntimeVirtualTextureMainPassType>.FromNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VirtualTextureRenderPassType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:VirtualTextureRenderPassType");
			}
			else
			{
				EnumMarshaler<ERuntimeVirtualTextureMainPassType>.ToNative(IntPtr.Add(base.Address, VirtualTextureRenderPassType_Offset), 0, VirtualTextureRenderPassType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:BodyInstance")]
	public FBodyInstance BodyInstance
	{
		get
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:BodyInstance");
				return default(FBodyInstance);
			}
			return FBodyInstance.FromNative(IntPtr.Add(base.Address, BodyInstance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:BodyInstance");
			}
			else
			{
				FBodyInstance.ToNative(IntPtr.Add(base.Address, BodyInstance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnComponentHit")]
	public FComponentHitSignature OnComponentHit
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentHit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnComponentHit");
				return new FComponentHitSignature();
			}
			if (OnComponentHit_DelegateCached == null)
			{
				OnComponentHit_DelegateCached = new FComponentHitSignature();
				OnComponentHit_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentHit_Offset));
			}
			return OnComponentHit_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnComponentBeginOverlap")]
	public FComponentBeginOverlapSignature OnComponentBeginOverlap
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentBeginOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnComponentBeginOverlap");
				return new FComponentBeginOverlapSignature();
			}
			if (OnComponentBeginOverlap_DelegateCached == null)
			{
				OnComponentBeginOverlap_DelegateCached = new FComponentBeginOverlapSignature();
				OnComponentBeginOverlap_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentBeginOverlap_Offset));
			}
			return OnComponentBeginOverlap_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnComponentEndOverlap")]
	public FComponentEndOverlapSignature OnComponentEndOverlap
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentEndOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnComponentEndOverlap");
				return new FComponentEndOverlapSignature();
			}
			if (OnComponentEndOverlap_DelegateCached == null)
			{
				OnComponentEndOverlap_DelegateCached = new FComponentEndOverlapSignature();
				OnComponentEndOverlap_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentEndOverlap_Offset));
			}
			return OnComponentEndOverlap_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnComponentWake")]
	public FComponentWakeSignature OnComponentWake
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentWake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnComponentWake");
				return new FComponentWakeSignature();
			}
			if (OnComponentWake_DelegateCached == null)
			{
				OnComponentWake_DelegateCached = new FComponentWakeSignature();
				OnComponentWake_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentWake_Offset));
			}
			return OnComponentWake_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnComponentSleep")]
	public FComponentSleepSignature OnComponentSleep
	{
		get
		{
			CheckDestroyed();
			if (!OnComponentSleep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnComponentSleep");
				return new FComponentSleepSignature();
			}
			if (OnComponentSleep_DelegateCached == null)
			{
				OnComponentSleep_DelegateCached = new FComponentSleepSignature();
				OnComponentSleep_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnComponentSleep_Offset));
			}
			return OnComponentSleep_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnBeginCursorOver")]
	public FComponentBeginCursorOverSignature OnBeginCursorOver
	{
		get
		{
			CheckDestroyed();
			if (!OnBeginCursorOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnBeginCursorOver");
				return new FComponentBeginCursorOverSignature();
			}
			if (OnBeginCursorOver_DelegateCached == null)
			{
				OnBeginCursorOver_DelegateCached = new FComponentBeginCursorOverSignature();
				OnBeginCursorOver_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBeginCursorOver_Offset));
			}
			return OnBeginCursorOver_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnEndCursorOver")]
	public FComponentEndCursorOverSignature OnEndCursorOver
	{
		get
		{
			CheckDestroyed();
			if (!OnEndCursorOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnEndCursorOver");
				return new FComponentEndCursorOverSignature();
			}
			if (OnEndCursorOver_DelegateCached == null)
			{
				OnEndCursorOver_DelegateCached = new FComponentEndCursorOverSignature();
				OnEndCursorOver_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEndCursorOver_Offset));
			}
			return OnEndCursorOver_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnClicked")]
	public FComponentOnClickedSignature OnClicked
	{
		get
		{
			CheckDestroyed();
			if (!OnClicked_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnClicked");
				return new FComponentOnClickedSignature();
			}
			if (OnClicked_DelegateCached == null)
			{
				OnClicked_DelegateCached = new FComponentOnClickedSignature();
				OnClicked_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClicked_Offset));
			}
			return OnClicked_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnReleased")]
	public FComponentOnReleasedSignature OnReleased
	{
		get
		{
			CheckDestroyed();
			if (!OnReleased_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnReleased");
				return new FComponentOnReleasedSignature();
			}
			if (OnReleased_DelegateCached == null)
			{
				OnReleased_DelegateCached = new FComponentOnReleasedSignature();
				OnReleased_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnReleased_Offset));
			}
			return OnReleased_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnInputTouchBegin")]
	public FComponentOnInputTouchBeginSignature OnInputTouchBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnInputTouchBegin");
				return new FComponentOnInputTouchBeginSignature();
			}
			if (OnInputTouchBegin_DelegateCached == null)
			{
				OnInputTouchBegin_DelegateCached = new FComponentOnInputTouchBeginSignature();
				OnInputTouchBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchBegin_Offset));
			}
			return OnInputTouchBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnInputTouchEnd")]
	public FComponentOnInputTouchEndSignature OnInputTouchEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnInputTouchEnd");
				return new FComponentOnInputTouchEndSignature();
			}
			if (OnInputTouchEnd_DelegateCached == null)
			{
				OnInputTouchEnd_DelegateCached = new FComponentOnInputTouchEndSignature();
				OnInputTouchEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchEnd_Offset));
			}
			return OnInputTouchEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnInputTouchEnter")]
	public FComponentBeginTouchOverSignature OnInputTouchEnter
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchEnter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnInputTouchEnter");
				return new FComponentBeginTouchOverSignature();
			}
			if (OnInputTouchEnter_DelegateCached == null)
			{
				OnInputTouchEnter_DelegateCached = new FComponentBeginTouchOverSignature();
				OnInputTouchEnter_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchEnter_Offset));
			}
			return OnInputTouchEnter_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:OnInputTouchLeave")]
	public FComponentEndTouchOverSignature OnInputTouchLeave
	{
		get
		{
			CheckDestroyed();
			if (!OnInputTouchLeave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:OnInputTouchLeave");
				return new FComponentEndTouchOverSignature();
			}
			if (OnInputTouchLeave_DelegateCached == null)
			{
				OnInputTouchLeave_DelegateCached = new FComponentEndTouchOverSignature();
				OnInputTouchLeave_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputTouchLeave_Offset));
			}
			return OnInputTouchLeave_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:RayTracingGroupCullingPriority")]
	public ERayTracingGroupCullingPriority RayTracingGroupCullingPriority
	{
		get
		{
			CheckDestroyed();
			if (!RayTracingGroupCullingPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:RayTracingGroupCullingPriority");
				return ERayTracingGroupCullingPriority.CP_0_NEVER_CULL;
			}
			return EnumMarshaler<ERayTracingGroupCullingPriority>.FromNative(IntPtr.Add(base.Address, RayTracingGroupCullingPriority_Offset), 0, RayTracingGroupCullingPriority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RayTracingGroupCullingPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:RayTracingGroupCullingPriority");
			}
			else
			{
				EnumMarshaler<ERayTracingGroupCullingPriority>.ToNative(IntPtr.Add(base.Address, RayTracingGroupCullingPriority_Offset), 0, RayTracingGroupCullingPriority_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CustomDepthStencilWriteMask")]
	public ERendererStencilMask CustomDepthStencilWriteMask
	{
		get
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CustomDepthStencilWriteMask");
				return ERendererStencilMask.ERSM_Default;
			}
			return EnumMarshaler<ERendererStencilMask>.FromNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CustomDepthStencilWriteMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PrimitiveComponent:CustomDepthStencilWriteMask");
			}
			else
			{
				EnumMarshaler<ERendererStencilMask>.ToNative(IntPtr.Add(base.Address, CustomDepthStencilWriteMask_Offset), 0, CustomDepthStencilWriteMask_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:WasRecentlyRendered")]
	public unsafe bool WasRecentlyRendered(float Tolerance = 0.2f)
	{
		CheckDestroyed();
		if (!WasRecentlyRendered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:WasRecentlyRendered");
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
	[UMetaPath("/Script/Engine.PrimitiveComponent:WakeRigidBody")]
	public unsafe void WakeRigidBody(FName BoneName)
	{
		CheckDestroyed();
		if (!WakeRigidBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:WakeRigidBody");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WakeRigidBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WakeRigidBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, WakeRigidBody_BoneName_Offset), 0, WakeRigidBody_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, WakeRigidBody_FunctionAddress, intPtr, WakeRigidBody_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:WakeAllRigidBodies")]
	public unsafe void WakeAllRigidBodies()
	{
		CheckDestroyed();
		if (!WakeAllRigidBodies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:WakeAllRigidBodies");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WakeAllRigidBodies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WakeAllRigidBodies_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: WakeAllRigidBodies_FunctionAddress, argsSize: WakeAllRigidBodies_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetWalkableSlopeOverride")]
	public unsafe void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride)
	{
		CheckDestroyed();
		if (!SetWalkableSlopeOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetWalkableSlopeOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWalkableSlopeOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWalkableSlopeOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetWalkableSlopeOverride_NewOverride_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FWalkableSlopeOverride>.ToNative(IntPtr.Add(intPtr, SetWalkableSlopeOverride_NewOverride_Offset), 0, SetWalkableSlopeOverride_NewOverride_PropertyAddress.Address, NewOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWalkableSlopeOverride_FunctionAddress, intPtr, SetWalkableSlopeOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetVisibleInSceneCaptureOnly")]
	public unsafe void SetVisibleInSceneCaptureOnly(bool bValue)
	{
		CheckDestroyed();
		if (!SetVisibleInSceneCaptureOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetVisibleInSceneCaptureOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisibleInSceneCaptureOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisibleInSceneCaptureOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVisibleInSceneCaptureOnly_bValue_Offset), 0, SetVisibleInSceneCaptureOnly_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisibleInSceneCaptureOnly_FunctionAddress, intPtr, SetVisibleInSceneCaptureOnly_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetVisibleInRayTracing")]
	public unsafe void SetVisibleInRayTracing(bool bNewVisibleInRayTracing)
	{
		CheckDestroyed();
		if (!SetVisibleInRayTracing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetVisibleInRayTracing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisibleInRayTracing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisibleInRayTracing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVisibleInRayTracing_bNewVisibleInRayTracing_Offset), 0, SetVisibleInRayTracing_bNewVisibleInRayTracing_PropertyAddress.Address, bNewVisibleInRayTracing);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisibleInRayTracing_FunctionAddress, intPtr, SetVisibleInRayTracing_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetVectorParameterForDefaultCustomPrimitiveData")]
	public unsafe void SetVectorParameterForDefaultCustomPrimitiveData(FName ParameterName, FVector4 Value)
	{
		CheckDestroyed();
		if (!SetVectorParameterForDefaultCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetVectorParameterForDefaultCustomPrimitiveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterForDefaultCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterForDefaultCustomPrimitiveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_Offset), 0, SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVectorParameterForDefaultCustomPrimitiveData_Value_Offset), 0, SetVectorParameterForDefaultCustomPrimitiveData_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, intPtr, SetVectorParameterForDefaultCustomPrimitiveData_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetVectorParameterForCustomPrimitiveData")]
	public unsafe void SetVectorParameterForCustomPrimitiveData(FName ParameterName, FVector4 Value)
	{
		CheckDestroyed();
		if (!SetVectorParameterForCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetVectorParameterForCustomPrimitiveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterForCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterForCustomPrimitiveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameterForCustomPrimitiveData_ParameterName_Offset), 0, SetVectorParameterForCustomPrimitiveData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetVectorParameterForCustomPrimitiveData_Value_Offset), 0, SetVectorParameterForCustomPrimitiveData_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameterForCustomPrimitiveData_FunctionAddress, intPtr, SetVectorParameterForCustomPrimitiveData_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetUseCCD")]
	public unsafe void SetUseCCD(bool InUseCCD, FName BoneName)
	{
		CheckDestroyed();
		if (!SetUseCCD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetUseCCD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseCCD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseCCD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseCCD_InUseCCD_Offset), 0, SetUseCCD_InUseCCD_PropertyAddress.Address, InUseCCD);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetUseCCD_BoneName_Offset), 0, SetUseCCD_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseCCD_FunctionAddress, intPtr, SetUseCCD_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetTranslucentSortPriority")]
	public unsafe void SetTranslucentSortPriority(int NewTranslucentSortPriority)
	{
		CheckDestroyed();
		if (!SetTranslucentSortPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetTranslucentSortPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTranslucentSortPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTranslucentSortPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTranslucentSortPriority_NewTranslucentSortPriority_Offset), 0, SetTranslucentSortPriority_NewTranslucentSortPriority_PropertyAddress.Address, NewTranslucentSortPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTranslucentSortPriority_FunctionAddress, intPtr, SetTranslucentSortPriority_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetTranslucencySortDistanceOffset")]
	public unsafe void SetTranslucencySortDistanceOffset(float NewTranslucencySortDistanceOffset)
	{
		CheckDestroyed();
		if (!SetTranslucencySortDistanceOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetTranslucencySortDistanceOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTranslucencySortDistanceOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTranslucencySortDistanceOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_Offset), 0, SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_PropertyAddress.Address, NewTranslucencySortDistanceOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTranslucencySortDistanceOffset_FunctionAddress, intPtr, SetTranslucencySortDistanceOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetSkeletalMeshOutputRTDepthMaskInDepthPass")]
	public unsafe void SetSkeletalMeshOutputRTDepthMaskInDepthPass(bool bNewSkeletalMeshOutputRTDepthMaskInDepthPass)
	{
		CheckDestroyed();
		if (!SetSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetSkeletalMeshOutputRTDepthMaskInDepthPass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletalMeshOutputRTDepthMaskInDepthPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletalMeshOutputRTDepthMaskInDepthPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_Offset), 0, SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress.Address, bNewSkeletalMeshOutputRTDepthMaskInDepthPass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress, intPtr, SetSkeletalMeshOutputRTDepthMaskInDepthPass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetSingleSampleShadowFromStationaryLights")]
	public unsafe void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
	{
		CheckDestroyed();
		if (!SetSingleSampleShadowFromStationaryLights_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetSingleSampleShadowFromStationaryLights");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSingleSampleShadowFromStationaryLights_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSingleSampleShadowFromStationaryLights_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_Offset), 0, SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_PropertyAddress.Address, bNewSingleSampleShadowFromStationaryLights);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSingleSampleShadowFromStationaryLights_FunctionAddress, intPtr, SetSingleSampleShadowFromStationaryLights_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetSimulatePhysics")]
	public unsafe void SetSimulatePhysics(bool bSimulate)
	{
		CheckDestroyed();
		if (!SetSimulatePhysics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetSimulatePhysics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSimulatePhysics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSimulatePhysics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSimulatePhysics_bSimulate_Offset), 0, SetSimulatePhysics_bSimulate_PropertyAddress.Address, bSimulate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSimulatePhysics_FunctionAddress, intPtr, SetSimulatePhysics_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetScalarParameterForDefaultCustomPrimitiveData")]
	public unsafe void SetScalarParameterForDefaultCustomPrimitiveData(FName ParameterName, float Value)
	{
		CheckDestroyed();
		if (!SetScalarParameterForDefaultCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetScalarParameterForDefaultCustomPrimitiveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterForDefaultCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterForDefaultCustomPrimitiveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_Offset), 0, SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterForDefaultCustomPrimitiveData_Value_Offset), 0, SetScalarParameterForDefaultCustomPrimitiveData_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, intPtr, SetScalarParameterForDefaultCustomPrimitiveData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetScalarParameterForCustomPrimitiveData")]
	public unsafe void SetScalarParameterForCustomPrimitiveData(FName ParameterName, float Value)
	{
		CheckDestroyed();
		if (!SetScalarParameterForCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetScalarParameterForCustomPrimitiveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterForCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterForCustomPrimitiveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetScalarParameterForCustomPrimitiveData_ParameterName_Offset), 0, SetScalarParameterForCustomPrimitiveData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterForCustomPrimitiveData_Value_Offset), 0, SetScalarParameterForCustomPrimitiveData_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScalarParameterForCustomPrimitiveData_FunctionAddress, intPtr, SetScalarParameterForCustomPrimitiveData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetRenderInMainPass")]
	public unsafe void SetRenderInMainPass(bool bValue)
	{
		CheckDestroyed();
		if (!SetRenderInMainPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetRenderInMainPass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderInMainPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderInMainPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderInMainPass_bValue_Offset), 0, SetRenderInMainPass_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderInMainPass_FunctionAddress, intPtr, SetRenderInMainPass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetRenderInDepthPass")]
	public unsafe void SetRenderInDepthPass(bool bValue)
	{
		CheckDestroyed();
		if (!SetRenderInDepthPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetRenderInDepthPass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderInDepthPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderInDepthPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderInDepthPass_bValue_Offset), 0, SetRenderInDepthPass_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderInDepthPass_FunctionAddress, intPtr, SetRenderInDepthPass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetRenderGSVoxelizationPass")]
	public unsafe void SetRenderGSVoxelizationPass(bool bValue)
	{
		CheckDestroyed();
		if (!SetRenderGSVoxelizationPass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetRenderGSVoxelizationPass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderGSVoxelizationPass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderGSVoxelizationPass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderGSVoxelizationPass_bValue_Offset), 0, SetRenderGSVoxelizationPass_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderGSVoxelizationPass_FunctionAddress, intPtr, SetRenderGSVoxelizationPass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetRenderCustomDepth")]
	public unsafe void SetRenderCustomDepth(bool bValue)
	{
		CheckDestroyed();
		if (!SetRenderCustomDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetRenderCustomDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderCustomDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderCustomDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderCustomDepth_bValue_Offset), 0, SetRenderCustomDepth_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderCustomDepth_FunctionAddress, intPtr, SetRenderCustomDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetReceivesDecals")]
	public unsafe void SetReceivesDecals(bool bNewReceivesDecals)
	{
		CheckDestroyed();
		if (!SetReceivesDecals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetReceivesDecals");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReceivesDecals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReceivesDecals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetReceivesDecals_bNewReceivesDecals_Offset), 0, SetReceivesDecals_bNewReceivesDecals_PropertyAddress.Address, bNewReceivesDecals);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReceivesDecals_FunctionAddress, intPtr, SetReceivesDecals_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysMaterialOverride")]
	public unsafe void SetPhysMaterialOverride(UPhysicalMaterial NewPhysMaterial)
	{
		CheckDestroyed();
		if (!SetPhysMaterialOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysMaterialOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysMaterialOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysMaterialOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicalMaterial>.ToNative(IntPtr.Add(intPtr, SetPhysMaterialOverride_NewPhysMaterial_Offset), 0, SetPhysMaterialOverride_NewPhysMaterial_PropertyAddress.Address, NewPhysMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysMaterialOverride_FunctionAddress, intPtr, SetPhysMaterialOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInRadians")]
	public unsafe void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent, FName BoneName)
	{
		CheckDestroyed();
		if (!SetPhysicsMaxAngularVelocityInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInRadians");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsMaxAngularVelocityInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsMaxAngularVelocityInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_Offset), 0, SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_PropertyAddress.Address, NewMaxAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_Offset), 0, SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInRadians_BoneName_Offset), 0, SetPhysicsMaxAngularVelocityInRadians_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, intPtr, SetPhysicsMaxAngularVelocityInRadians_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInDegrees")]
	public unsafe void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent, FName BoneName)
	{
		CheckDestroyed();
		if (!SetPhysicsMaxAngularVelocityInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInDegrees");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsMaxAngularVelocityInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsMaxAngularVelocityInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_Offset), 0, SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_PropertyAddress.Address, NewMaxAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_Offset), 0, SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPhysicsMaxAngularVelocityInDegrees_BoneName_Offset), 0, SetPhysicsMaxAngularVelocityInDegrees_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, intPtr, SetPhysicsMaxAngularVelocityInDegrees_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysicsLinearVelocity")]
	public unsafe void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, FName BoneName)
	{
		CheckDestroyed();
		if (!SetPhysicsLinearVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysicsLinearVelocity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsLinearVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsLinearVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPhysicsLinearVelocity_NewVel_Offset), 0, SetPhysicsLinearVelocity_NewVel_PropertyAddress.Address, NewVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsLinearVelocity_bAddToCurrent_Offset), 0, SetPhysicsLinearVelocity_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPhysicsLinearVelocity_BoneName_Offset), 0, SetPhysicsLinearVelocity_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsLinearVelocity_FunctionAddress, intPtr, SetPhysicsLinearVelocity_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInRadians")]
	public unsafe void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, FName BoneName)
	{
		CheckDestroyed();
		if (!SetPhysicsAngularVelocityInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInRadians");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsAngularVelocityInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsAngularVelocityInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInRadians_NewAngVel_Offset), 0, SetPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress.Address, NewAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInRadians_bAddToCurrent_Offset), 0, SetPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInRadians_BoneName_Offset), 0, SetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsAngularVelocityInRadians_FunctionAddress, intPtr, SetPhysicsAngularVelocityInRadians_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInDegrees")]
	public unsafe void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent, FName BoneName)
	{
		CheckDestroyed();
		if (!SetPhysicsAngularVelocityInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInDegrees");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsAngularVelocityInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsAngularVelocityInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInDegrees_NewAngVel_Offset), 0, SetPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress.Address, NewAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset), 0, SetPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPhysicsAngularVelocityInDegrees_BoneName_Offset), 0, SetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsAngularVelocityInDegrees_FunctionAddress, intPtr, SetPhysicsAngularVelocityInDegrees_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetOwnerNoSee")]
	public unsafe void SetOwnerNoSee(bool bNewOwnerNoSee)
	{
		CheckDestroyed();
		if (!SetOwnerNoSee_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetOwnerNoSee");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOwnerNoSee_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOwnerNoSee_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOwnerNoSee_bNewOwnerNoSee_Offset), 0, SetOwnerNoSee_bNewOwnerNoSee_PropertyAddress.Address, bNewOwnerNoSee);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOwnerNoSee_FunctionAddress, intPtr, SetOwnerNoSee_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetOnlyOwnerSee")]
	public unsafe void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
	{
		CheckDestroyed();
		if (!SetOnlyOwnerSee_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetOnlyOwnerSee");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOnlyOwnerSee_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOnlyOwnerSee_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOnlyOwnerSee_bNewOnlyOwnerSee_Offset), 0, SetOnlyOwnerSee_bNewOnlyOwnerSee_PropertyAddress.Address, bNewOnlyOwnerSee);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOnlyOwnerSee_FunctionAddress, intPtr, SetOnlyOwnerSee_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetNotifyRigidBodyCollision")]
	public unsafe void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
	{
		CheckDestroyed();
		if (!SetNotifyRigidBodyCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetNotifyRigidBodyCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNotifyRigidBodyCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNotifyRigidBodyCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_Offset), 0, SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_PropertyAddress.Address, bNewNotifyRigidBodyCollision);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNotifyRigidBodyCollision_FunctionAddress, intPtr, SetNotifyRigidBodyCollision_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetMaterialByName")]
	public unsafe void SetMaterialByName(FName MaterialSlotName, UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetMaterialByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetMaterialByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterialByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterialByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMaterialByName_MaterialSlotName_Offset), 0, SetMaterialByName_MaterialSlotName_PropertyAddress.Address, MaterialSlotName);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterialByName_Material_Offset), 0, SetMaterialByName_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterialByName_FunctionAddress, intPtr, SetMaterialByName_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetMaterial")]
	public unsafe void SetMaterial(int ElementIndex, UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaterial_ElementIndex_Offset), 0, SetMaterial_ElementIndex_PropertyAddress.Address, ElementIndex);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_Material_Offset), 0, SetMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetMassScale")]
	public unsafe void SetMassScale(FName BoneName, float InMassScale)
	{
		CheckDestroyed();
		if (!SetMassScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetMassScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMassScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMassScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMassScale_BoneName_Offset), 0, SetMassScale_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMassScale_InMassScale_Offset), 0, SetMassScale_InMassScale_PropertyAddress.Address, InMassScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMassScale_FunctionAddress, intPtr, SetMassScale_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetMassOverrideInKg")]
	public unsafe void SetMassOverrideInKg(FName BoneName, float MassInKg, bool bOverrideMass)
	{
		CheckDestroyed();
		if (!SetMassOverrideInKg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetMassOverrideInKg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMassOverrideInKg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMassOverrideInKg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMassOverrideInKg_BoneName_Offset), 0, SetMassOverrideInKg_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMassOverrideInKg_MassInKg_Offset), 0, SetMassOverrideInKg_MassInKg_PropertyAddress.Address, MassInKg);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMassOverrideInKg_bOverrideMass_Offset), 0, SetMassOverrideInKg_bOverrideMass_PropertyAddress.Address, bOverrideMass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMassOverrideInKg_FunctionAddress, intPtr, SetMassOverrideInKg_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetLinearDamping")]
	public unsafe void SetLinearDamping(float InDamping)
	{
		CheckDestroyed();
		if (!SetLinearDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetLinearDamping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDamping_InDamping_Offset), 0, SetLinearDamping_InDamping_PropertyAddress.Address, InDamping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearDamping_FunctionAddress, intPtr, SetLinearDamping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetLightingChannels")]
	public unsafe void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
	{
		CheckDestroyed();
		if (!SetLightingChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetLightingChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightingChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightingChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel0_Offset), 0, SetLightingChannels_bChannel0_PropertyAddress.Address, bChannel0);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel1_Offset), 0, SetLightingChannels_bChannel1_PropertyAddress.Address, bChannel1);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel2_Offset), 0, SetLightingChannels_bChannel2_PropertyAddress.Address, bChannel2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightingChannels_FunctionAddress, intPtr, SetLightingChannels_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetLightAttachmentsAsGroup")]
	public unsafe void SetLightAttachmentsAsGroup(bool bInLightAttachmentsAsGroup)
	{
		CheckDestroyed();
		if (!SetLightAttachmentsAsGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetLightAttachmentsAsGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightAttachmentsAsGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightAttachmentsAsGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_Offset), 0, SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_PropertyAddress.Address, bInLightAttachmentsAsGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightAttachmentsAsGroup_FunctionAddress, intPtr, SetLightAttachmentsAsGroup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetHiddenInSceneCapture")]
	public unsafe void SetHiddenInSceneCapture(bool bValue)
	{
		CheckDestroyed();
		if (!SetHiddenInSceneCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetHiddenInSceneCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHiddenInSceneCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHiddenInSceneCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHiddenInSceneCapture_bValue_Offset), 0, SetHiddenInSceneCapture_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHiddenInSceneCapture_FunctionAddress, intPtr, SetHiddenInSceneCapture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetGenerateOverlapEvents")]
	public unsafe void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)
	{
		CheckDestroyed();
		if (!SetGenerateOverlapEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetGenerateOverlapEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGenerateOverlapEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGenerateOverlapEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGenerateOverlapEvents_bInGenerateOverlapEvents_Offset), 0, SetGenerateOverlapEvents_bInGenerateOverlapEvents_PropertyAddress.Address, bInGenerateOverlapEvents);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGenerateOverlapEvents_FunctionAddress, intPtr, SetGenerateOverlapEvents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetExcludeFromLightAttachmentGroup")]
	public unsafe void SetExcludeFromLightAttachmentGroup(bool bInExcludeFromLightAttachmentGroup)
	{
		CheckDestroyed();
		if (!SetExcludeFromLightAttachmentGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetExcludeFromLightAttachmentGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExcludeFromLightAttachmentGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExcludeFromLightAttachmentGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_Offset), 0, SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_PropertyAddress.Address, bInExcludeFromLightAttachmentGroup);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetExcludeFromLightAttachmentGroup_FunctionAddress, intPtr, SetExcludeFromLightAttachmentGroup_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetEnableGravity")]
	public unsafe void SetEnableGravity(bool bGravityEnabled)
	{
		CheckDestroyed();
		if (!SetEnableGravity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetEnableGravity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableGravity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableGravity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableGravity_bGravityEnabled_Offset), 0, SetEnableGravity_bGravityEnabled_PropertyAddress.Address, bGravityEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableGravity_FunctionAddress, intPtr, SetEnableGravity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetEmissiveLightSource")]
	public unsafe void SetEmissiveLightSource(bool NewEmissiveLightSource)
	{
		CheckDestroyed();
		if (!SetEmissiveLightSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetEmissiveLightSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEmissiveLightSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEmissiveLightSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEmissiveLightSource_NewEmissiveLightSource_Offset), 0, SetEmissiveLightSource_NewEmissiveLightSource_PropertyAddress.Address, NewEmissiveLightSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEmissiveLightSource_FunctionAddress, intPtr, SetEmissiveLightSource_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector4")]
	public unsafe void SetDefaultCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
	{
		CheckDestroyed();
		if (!SetDefaultCustomPrimitiveDataVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultCustomPrimitiveDataVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultCustomPrimitiveDataVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector4_DataIndex_Offset), 0, SetDefaultCustomPrimitiveDataVector4_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector4_Value_Offset), 0, SetDefaultCustomPrimitiveDataVector4_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultCustomPrimitiveDataVector4_FunctionAddress, intPtr, SetDefaultCustomPrimitiveDataVector4_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector3")]
	public unsafe void SetDefaultCustomPrimitiveDataVector3(int DataIndex, FVector Value)
	{
		CheckDestroyed();
		if (!SetDefaultCustomPrimitiveDataVector3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultCustomPrimitiveDataVector3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultCustomPrimitiveDataVector3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector3_DataIndex_Offset), 0, SetDefaultCustomPrimitiveDataVector3_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector3_Value_Offset), 0, SetDefaultCustomPrimitiveDataVector3_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultCustomPrimitiveDataVector3_FunctionAddress, intPtr, SetDefaultCustomPrimitiveDataVector3_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector2")]
	public unsafe void SetDefaultCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
	{
		CheckDestroyed();
		if (!SetDefaultCustomPrimitiveDataVector2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultCustomPrimitiveDataVector2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultCustomPrimitiveDataVector2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector2_DataIndex_Offset), 0, SetDefaultCustomPrimitiveDataVector2_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataVector2_Value_Offset), 0, SetDefaultCustomPrimitiveDataVector2_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultCustomPrimitiveDataVector2_FunctionAddress, intPtr, SetDefaultCustomPrimitiveDataVector2_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataFloat")]
	public unsafe void SetDefaultCustomPrimitiveDataFloat(int DataIndex, float Value)
	{
		CheckDestroyed();
		if (!SetDefaultCustomPrimitiveDataFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultCustomPrimitiveDataFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultCustomPrimitiveDataFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataFloat_DataIndex_Offset), 0, SetDefaultCustomPrimitiveDataFloat_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDefaultCustomPrimitiveDataFloat_Value_Offset), 0, SetDefaultCustomPrimitiveDataFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultCustomPrimitiveDataFloat_FunctionAddress, intPtr, SetDefaultCustomPrimitiveDataFloat_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector4")]
	public unsafe void SetCustomPrimitiveDataVector4(int DataIndex, FVector4 Value)
	{
		CheckDestroyed();
		if (!SetCustomPrimitiveDataVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPrimitiveDataVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPrimitiveDataVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector4_DataIndex_Offset), 0, SetCustomPrimitiveDataVector4_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector4_Value_Offset), 0, SetCustomPrimitiveDataVector4_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPrimitiveDataVector4_FunctionAddress, intPtr, SetCustomPrimitiveDataVector4_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector3")]
	public unsafe void SetCustomPrimitiveDataVector3(int DataIndex, FVector Value)
	{
		CheckDestroyed();
		if (!SetCustomPrimitiveDataVector3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector3");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPrimitiveDataVector3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPrimitiveDataVector3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector3_DataIndex_Offset), 0, SetCustomPrimitiveDataVector3_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector3_Value_Offset), 0, SetCustomPrimitiveDataVector3_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPrimitiveDataVector3_FunctionAddress, intPtr, SetCustomPrimitiveDataVector3_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector2")]
	public unsafe void SetCustomPrimitiveDataVector2(int DataIndex, FVector2D Value)
	{
		CheckDestroyed();
		if (!SetCustomPrimitiveDataVector2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPrimitiveDataVector2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPrimitiveDataVector2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector2_DataIndex_Offset), 0, SetCustomPrimitiveDataVector2_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataVector2_Value_Offset), 0, SetCustomPrimitiveDataVector2_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPrimitiveDataVector2_FunctionAddress, intPtr, SetCustomPrimitiveDataVector2_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataFloat")]
	public unsafe void SetCustomPrimitiveDataFloat(int DataIndex, float Value)
	{
		CheckDestroyed();
		if (!SetCustomPrimitiveDataFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPrimitiveDataFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPrimitiveDataFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataFloat_DataIndex_Offset), 0, SetCustomPrimitiveDataFloat_DataIndex_PropertyAddress.Address, DataIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomPrimitiveDataFloat_Value_Offset), 0, SetCustomPrimitiveDataFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPrimitiveDataFloat_FunctionAddress, intPtr, SetCustomPrimitiveDataFloat_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilWriteMask")]
	public unsafe void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
	{
		CheckDestroyed();
		if (!SetCustomDepthStencilWriteMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilWriteMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomDepthStencilWriteMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomDepthStencilWriteMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERendererStencilMask>.ToNative(IntPtr.Add(intPtr, SetCustomDepthStencilWriteMask_WriteMaskBit_Offset), 0, SetCustomDepthStencilWriteMask_WriteMaskBit_PropertyAddress.Address, WriteMaskBit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomDepthStencilWriteMask_FunctionAddress, intPtr, SetCustomDepthStencilWriteMask_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilValue")]
	public unsafe void SetCustomDepthStencilValue(int Value)
	{
		CheckDestroyed();
		if (!SetCustomDepthStencilValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomDepthStencilValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomDepthStencilValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCustomDepthStencilValue_Value_Offset), 0, SetCustomDepthStencilValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomDepthStencilValue_FunctionAddress, intPtr, SetCustomDepthStencilValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCullDistance")]
	public unsafe void SetCullDistance(float NewCullDistance)
	{
		CheckDestroyed();
		if (!SetCullDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCullDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCullDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCullDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCullDistance_NewCullDistance_Offset), 0, SetCullDistance_NewCullDistance_PropertyAddress.Address, NewCullDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCullDistance_FunctionAddress, intPtr, SetCullDistance_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetConstraintMode")]
	public unsafe void SetConstraintMode(EDOFMode ConstraintMode)
	{
		CheckDestroyed();
		if (!SetConstraintMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetConstraintMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EDOFMode>.ToNative(IntPtr.Add(intPtr, SetConstraintMode_ConstraintMode_Offset), 0, SetConstraintMode_ConstraintMode_PropertyAddress.Address, ConstraintMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintMode_FunctionAddress, intPtr, SetConstraintMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCollisionResponseToChannel")]
	public unsafe void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponseType NewResponse)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCollisionResponseToChannel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_Channel_Offset), 0, SetCollisionResponseToChannel_Channel_PropertyAddress.Address, Channel);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToChannel_NewResponse_Offset), 0, SetCollisionResponseToChannel_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToChannel_FunctionAddress, intPtr, SetCollisionResponseToChannel_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCollisionResponseToAllChannels")]
	public unsafe void SetCollisionResponseToAllChannels(ECollisionResponseType NewResponse)
	{
		CheckDestroyed();
		if (!SetCollisionResponseToAllChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCollisionResponseToAllChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionResponseToAllChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionResponseToAllChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetCollisionResponseToAllChannels_NewResponse_Offset), 0, SetCollisionResponseToAllChannels_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionResponseToAllChannels_FunctionAddress, intPtr, SetCollisionResponseToAllChannels_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCollisionProfileName")]
	public unsafe void SetCollisionProfileName(FName InCollisionProfileName, bool bUpdateOverlaps = true)
	{
		CheckDestroyed();
		if (!SetCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCollisionProfileName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCollisionProfileName_InCollisionProfileName_Offset), 0, SetCollisionProfileName_InCollisionProfileName_PropertyAddress.Address, InCollisionProfileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionProfileName_bUpdateOverlaps_Offset), 0, SetCollisionProfileName_bUpdateOverlaps_PropertyAddress.Address, bUpdateOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionProfileName_FunctionAddress, intPtr, SetCollisionProfileName_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCollisionObjectType")]
	public unsafe void SetCollisionObjectType(ECollisionChannel Channel)
	{
		CheckDestroyed();
		if (!SetCollisionObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCollisionObjectType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, SetCollisionObjectType_Channel_Offset), 0, SetCollisionObjectType_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionObjectType_FunctionAddress, intPtr, SetCollisionObjectType_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCollisionEnabled")]
	public unsafe void SetCollisionEnabled(ECollisionEnabled NewType)
	{
		CheckDestroyed();
		if (!SetCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCollisionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetCollisionEnabled_NewType_Offset), 0, SetCollisionEnabled_NewType_PropertyAddress.Address, NewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCollisionEnabled_FunctionAddress, intPtr, SetCollisionEnabled_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCenterOfMass")]
	public unsafe void SetCenterOfMass(FVector CenterOfMassOffset, FName BoneName)
	{
		CheckDestroyed();
		if (!SetCenterOfMass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCenterOfMass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCenterOfMass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCenterOfMass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetCenterOfMass_CenterOfMassOffset_Offset), 0, SetCenterOfMass_CenterOfMassOffset_PropertyAddress.Address, CenterOfMassOffset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCenterOfMass_BoneName_Offset), 0, SetCenterOfMass_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCenterOfMass_FunctionAddress, intPtr, SetCenterOfMass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCastShadow")]
	public unsafe void SetCastShadow(bool NewCastShadow)
	{
		CheckDestroyed();
		if (!SetCastShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCastShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastShadow_NewCastShadow_Offset), 0, SetCastShadow_NewCastShadow_PropertyAddress.Address, NewCastShadow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastShadow_FunctionAddress, intPtr, SetCastShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCastInsetShadow")]
	public unsafe void SetCastInsetShadow(bool bInCastInsetShadow)
	{
		CheckDestroyed();
		if (!SetCastInsetShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCastInsetShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastInsetShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastInsetShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastInsetShadow_bInCastInsetShadow_Offset), 0, SetCastInsetShadow_bInCastInsetShadow_PropertyAddress.Address, bInCastInsetShadow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastInsetShadow_FunctionAddress, intPtr, SetCastInsetShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCastHybridRayTracingShadow")]
	public unsafe void SetCastHybridRayTracingShadow(bool bNewHybridRayTracingShadow)
	{
		CheckDestroyed();
		if (!SetCastHybridRayTracingShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCastHybridRayTracingShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastHybridRayTracingShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastHybridRayTracingShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_Offset), 0, SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_PropertyAddress.Address, bNewHybridRayTracingShadow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastHybridRayTracingShadow_FunctionAddress, intPtr, SetCastHybridRayTracingShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCastHiddenShadow")]
	public unsafe void SetCastHiddenShadow(bool NewCastHiddenShadow)
	{
		CheckDestroyed();
		if (!SetCastHiddenShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCastHiddenShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastHiddenShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastHiddenShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastHiddenShadow_NewCastHiddenShadow_Offset), 0, SetCastHiddenShadow_NewCastHiddenShadow_PropertyAddress.Address, NewCastHiddenShadow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastHiddenShadow_FunctionAddress, intPtr, SetCastHiddenShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetCastContactShadow")]
	public unsafe void SetCastContactShadow(bool bInCastContactShadow)
	{
		CheckDestroyed();
		if (!SetCastContactShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetCastContactShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastContactShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastContactShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastContactShadow_bInCastContactShadow_Offset), 0, SetCastContactShadow_bInCastContactShadow_PropertyAddress.Address, bInCastContactShadow);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastContactShadow_FunctionAddress, intPtr, SetCastContactShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetBoundsScale")]
	public unsafe void SetBoundsScale(float NewBoundsScale = 1f)
	{
		CheckDestroyed();
		if (!SetBoundsScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetBoundsScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoundsScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoundsScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoundsScale_NewBoundsScale_Offset), 0, SetBoundsScale_NewBoundsScale_PropertyAddress.Address, NewBoundsScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoundsScale_FunctionAddress, intPtr, SetBoundsScale_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAngularDamping")]
	public unsafe void SetAngularDamping(float InDamping)
	{
		CheckDestroyed();
		if (!SetAngularDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAngularDamping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDamping_InDamping_Offset), 0, SetAngularDamping_InDamping_PropertyAddress.Address, InDamping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularDamping_FunctionAddress, intPtr, SetAngularDamping_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAllUseCCD")]
	public unsafe void SetAllUseCCD(bool InUseCCD)
	{
		CheckDestroyed();
		if (!SetAllUseCCD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAllUseCCD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllUseCCD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllUseCCD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllUseCCD_InUseCCD_Offset), 0, SetAllUseCCD_InUseCCD_PropertyAddress.Address, InUseCCD);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllUseCCD_FunctionAddress, intPtr, SetAllUseCCD_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAllPhysicsLinearVelocity")]
	public unsafe void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent = false)
	{
		CheckDestroyed();
		if (!SetAllPhysicsLinearVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAllPhysicsLinearVelocity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPhysicsLinearVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPhysicsLinearVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAllPhysicsLinearVelocity_NewVel_Offset), 0, SetAllPhysicsLinearVelocity_NewVel_PropertyAddress.Address, NewVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllPhysicsLinearVelocity_bAddToCurrent_Offset), 0, SetAllPhysicsLinearVelocity_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllPhysicsLinearVelocity_FunctionAddress, intPtr, SetAllPhysicsLinearVelocity_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInRadians")]
	public unsafe void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent = false)
	{
		CheckDestroyed();
		if (!SetAllPhysicsAngularVelocityInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInRadians");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPhysicsAngularVelocityInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPhysicsAngularVelocityInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAllPhysicsAngularVelocityInRadians_NewAngVel_Offset), 0, SetAllPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress.Address, NewAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_Offset), 0, SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllPhysicsAngularVelocityInRadians_FunctionAddress, intPtr, SetAllPhysicsAngularVelocityInRadians_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInDegrees")]
	public unsafe void SetAllPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false)
	{
		CheckDestroyed();
		if (!SetAllPhysicsAngularVelocityInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInDegrees");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPhysicsAngularVelocityInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPhysicsAngularVelocityInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAllPhysicsAngularVelocityInDegrees_NewAngVel_Offset), 0, SetAllPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress.Address, NewAngVel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset), 0, SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress.Address, bAddToCurrent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, intPtr, SetAllPhysicsAngularVelocityInDegrees_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:SetAllMassScale")]
	public unsafe void SetAllMassScale(float InMassScale = 1f)
	{
		CheckDestroyed();
		if (!SetAllMassScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:SetAllMassScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllMassScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllMassScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAllMassScale_InMassScale_Offset), 0, SetAllMassScale_InMassScale_PropertyAddress.Address, InMassScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllMassScale_FunctionAddress, intPtr, SetAllMassScale_ParamsSize);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:ScaleByMomentOfInertia")]
	public unsafe FVector ScaleByMomentOfInertia(FVector InputVector, FName BoneName)
	{
		CheckDestroyed();
		if (!ScaleByMomentOfInertia_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:ScaleByMomentOfInertia");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScaleByMomentOfInertia_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScaleByMomentOfInertia_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ScaleByMomentOfInertia_InputVector_Offset), 0, ScaleByMomentOfInertia_InputVector_PropertyAddress.Address, InputVector);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ScaleByMomentOfInertia_BoneName_Offset), 0, ScaleByMomentOfInertia_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScaleByMomentOfInertia_FunctionAddress, intPtr, ScaleByMomentOfInertia_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ScaleByMomentOfInertia_ReturnValue_Offset), 0, ScaleByMomentOfInertia_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:PutRigidBodyToSleep")]
	public unsafe void PutRigidBodyToSleep(FName BoneName)
	{
		CheckDestroyed();
		if (!PutRigidBodyToSleep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:PutRigidBodyToSleep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PutRigidBodyToSleep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PutRigidBodyToSleep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PutRigidBodyToSleep_BoneName_Offset), 0, PutRigidBodyToSleep_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PutRigidBodyToSleep_FunctionAddress, intPtr, PutRigidBodyToSleep_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SphereTraceComponent")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_SphereTraceComponent")]
	public unsafe bool SphereTraceComponent(FVector TraceStart, FVector TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, out FVector HitLocation, out FVector HitNormal, out FName BoneName, out FHitResult OutHit)
	{
		CheckDestroyed();
		if (!SphereTraceComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_SphereTraceComponent");
			HitLocation = default(FVector);
			HitNormal = default(FVector);
			BoneName = default(FName);
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SphereTraceComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SphereTraceComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_TraceStart_Offset), 0, SphereTraceComponent_TraceStart_PropertyAddress.Address, TraceStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_TraceEnd_Offset), 0, SphereTraceComponent_TraceEnd_PropertyAddress.Address, TraceEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_SphereRadius_Offset), 0, SphereTraceComponent_SphereRadius_PropertyAddress.Address, SphereRadius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_bTraceComplex_Offset), 0, SphereTraceComponent_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_bShowTrace_Offset), 0, SphereTraceComponent_bShowTrace_PropertyAddress.Address, bShowTrace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereTraceComponent_bPersistentShowTrace_Offset), 0, SphereTraceComponent_bPersistentShowTrace_PropertyAddress.Address, bPersistentShowTrace);
		NativeReflection.InitializeValue_InContainer(SphereTraceComponent_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SphereTraceComponent_FunctionAddress, intPtr, SphereTraceComponent_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, SphereTraceComponent_HitLocation_Offset), 0, SphereTraceComponent_HitLocation_PropertyAddress.Address);
		HitNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, SphereTraceComponent_HitNormal_Offset), 0, SphereTraceComponent_HitNormal_PropertyAddress.Address);
		BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, SphereTraceComponent_BoneName_Offset), 0, SphereTraceComponent_BoneName_PropertyAddress.Address);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, SphereTraceComponent_OutHit_Offset), 0, SphereTraceComponent_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SphereTraceComponent_ReturnValue_Offset), 0, SphereTraceComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_SphereOverlapComponent")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_SphereOverlapComponent")]
	public unsafe bool SphereOverlapComponent(FVector InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, out FVector HitLocation, out FVector HitNormal, out FName BoneName, out FHitResult OutHit)
	{
		CheckDestroyed();
		if (!SphereOverlapComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_SphereOverlapComponent");
			HitLocation = default(FVector);
			HitNormal = default(FVector);
			BoneName = default(FName);
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SphereOverlapComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SphereOverlapComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SphereOverlapComponent_InSphereCentre_Offset), 0, SphereOverlapComponent_InSphereCentre_PropertyAddress.Address, InSphereCentre);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SphereOverlapComponent_InSphereRadius_Offset), 0, SphereOverlapComponent_InSphereRadius_PropertyAddress.Address, InSphereRadius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereOverlapComponent_bTraceComplex_Offset), 0, SphereOverlapComponent_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereOverlapComponent_bShowTrace_Offset), 0, SphereOverlapComponent_bShowTrace_PropertyAddress.Address, bShowTrace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SphereOverlapComponent_bPersistentShowTrace_Offset), 0, SphereOverlapComponent_bPersistentShowTrace_PropertyAddress.Address, bPersistentShowTrace);
		NativeReflection.InitializeValue_InContainer(SphereOverlapComponent_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SphereOverlapComponent_FunctionAddress, intPtr, SphereOverlapComponent_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, SphereOverlapComponent_HitLocation_Offset), 0, SphereOverlapComponent_HitLocation_PropertyAddress.Address);
		HitNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, SphereOverlapComponent_HitNormal_Offset), 0, SphereOverlapComponent_HitNormal_PropertyAddress.Address);
		BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, SphereOverlapComponent_BoneName_Offset), 0, SphereOverlapComponent_BoneName_PropertyAddress.Address);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, SphereOverlapComponent_OutHit_Offset), 0, SphereOverlapComponent_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SphereOverlapComponent_ReturnValue_Offset), 0, SphereOverlapComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_LineTraceComponent")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_LineTraceComponent")]
	public unsafe bool LineTraceComponent(FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, out FVector HitLocation, out FVector HitNormal, out FName BoneName, out FHitResult OutHit)
	{
		CheckDestroyed();
		if (!LineTraceComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_LineTraceComponent");
			HitLocation = default(FVector);
			HitNormal = default(FVector);
			BoneName = default(FName);
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineTraceComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineTraceComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceComponent_TraceStart_Offset), 0, LineTraceComponent_TraceStart_PropertyAddress.Address, TraceStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineTraceComponent_TraceEnd_Offset), 0, LineTraceComponent_TraceEnd_PropertyAddress.Address, TraceEnd);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceComponent_bTraceComplex_Offset), 0, LineTraceComponent_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceComponent_bShowTrace_Offset), 0, LineTraceComponent_bShowTrace_PropertyAddress.Address, bShowTrace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineTraceComponent_bPersistentShowTrace_Offset), 0, LineTraceComponent_bPersistentShowTrace_PropertyAddress.Address, bPersistentShowTrace);
		NativeReflection.InitializeValue_InContainer(LineTraceComponent_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, LineTraceComponent_FunctionAddress, intPtr, LineTraceComponent_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, LineTraceComponent_HitLocation_Offset), 0, LineTraceComponent_HitLocation_PropertyAddress.Address);
		HitNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, LineTraceComponent_HitNormal_Offset), 0, LineTraceComponent_HitNormal_PropertyAddress.Address);
		BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, LineTraceComponent_BoneName_Offset), 0, LineTraceComponent_BoneName_PropertyAddress.Address);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, LineTraceComponent_OutHit_Offset), 0, LineTraceComponent_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LineTraceComponent_ReturnValue_Offset), 0, LineTraceComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_IsQueryCollisionEnabled")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_IsQueryCollisionEnabled")]
	public unsafe bool IsQueryCollisionEnabled()
	{
		CheckDestroyed();
		if (!IsQueryCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_IsQueryCollisionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsQueryCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsQueryCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsQueryCollisionEnabled_FunctionAddress, intPtr, IsQueryCollisionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsQueryCollisionEnabled_ReturnValue_Offset), 0, IsQueryCollisionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_IsPhysicsCollisionEnabled")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_IsPhysicsCollisionEnabled")]
	public unsafe bool IsPhysicsCollisionEnabled()
	{
		CheckDestroyed();
		if (!IsPhysicsCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_IsPhysicsCollisionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPhysicsCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPhysicsCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPhysicsCollisionEnabled_FunctionAddress, intPtr, IsPhysicsCollisionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPhysicsCollisionEnabled_ReturnValue_Offset), 0, IsPhysicsCollisionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_IsCollisionEnabled")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_IsCollisionEnabled")]
	public unsafe bool IsCollisionEnabled()
	{
		CheckDestroyed();
		if (!IsCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_IsCollisionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCollisionEnabled_FunctionAddress, intPtr, IsCollisionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCollisionEnabled_ReturnValue_Offset), 0, IsCollisionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_BoxOverlapComponent")]
	[UMetaPath("/Script/Engine.PrimitiveComponent:K2_BoxOverlapComponent")]
	public unsafe bool BoxOverlapComponent(FVector InBoxCentre, FBox InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, out FVector HitLocation, out FVector HitNormal, out FName BoneName, out FHitResult OutHit)
	{
		CheckDestroyed();
		if (!BoxOverlapComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:K2_BoxOverlapComponent");
			HitLocation = default(FVector);
			HitNormal = default(FVector);
			BoneName = default(FName);
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoxOverlapComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoxOverlapComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponent_InBoxCentre_Offset), 0, BoxOverlapComponent_InBoxCentre_PropertyAddress.Address, InBoxCentre);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponent_InBox_Offset), 0, BoxOverlapComponent_InBox_PropertyAddress.Address, InBox);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BoxOverlapComponent_bTraceComplex_Offset), 0, BoxOverlapComponent_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BoxOverlapComponent_bShowTrace_Offset), 0, BoxOverlapComponent_bShowTrace_PropertyAddress.Address, bShowTrace);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BoxOverlapComponent_bPersistentShowTrace_Offset), 0, BoxOverlapComponent_bPersistentShowTrace_PropertyAddress.Address, bPersistentShowTrace);
		NativeReflection.InitializeValue_InContainer(BoxOverlapComponent_OutHit_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BoxOverlapComponent_FunctionAddress, intPtr, BoxOverlapComponent_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BoxOverlapComponent_HitLocation_Offset), 0, BoxOverlapComponent_HitLocation_PropertyAddress.Address);
		HitNormal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BoxOverlapComponent_HitNormal_Offset), 0, BoxOverlapComponent_HitNormal_PropertyAddress.Address);
		BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, BoxOverlapComponent_BoneName_Offset), 0, BoxOverlapComponent_BoneName_PropertyAddress.Address);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, BoxOverlapComponent_OutHit_Offset), 0, BoxOverlapComponent_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoxOverlapComponent_ReturnValue_Offset), 0, BoxOverlapComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IsOverlappingComponent")]
	public unsafe bool IsOverlappingComponent(UPrimitiveComponent OtherComp)
	{
		CheckDestroyed();
		if (!IsOverlappingComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IsOverlappingComponent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOverlappingComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOverlappingComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, IsOverlappingComponent_OtherComp_Offset), 0, IsOverlappingComponent_OtherComp_PropertyAddress.Address, OtherComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOverlappingComponent_FunctionAddress, intPtr, IsOverlappingComponent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOverlappingComponent_ReturnValue_Offset), 0, IsOverlappingComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IsOverlappingActor")]
	public unsafe bool IsOverlappingActor(AActor Other)
	{
		CheckDestroyed();
		if (!IsOverlappingActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IsOverlappingActor");
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

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IsGravityEnabled")]
	public unsafe bool IsGravityEnabled()
	{
		CheckDestroyed();
		if (!IsGravityEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IsGravityEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGravityEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGravityEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsGravityEnabled_FunctionAddress, intPtr, IsGravityEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGravityEnabled_ReturnValue_Offset), 0, IsGravityEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676416u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IsAnyRigidBodyAwake")]
	public unsafe bool IsAnyRigidBodyAwake()
	{
		CheckDestroyed();
		if (!IsAnyRigidBodyAwake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IsAnyRigidBodyAwake");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnyRigidBodyAwake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnyRigidBodyAwake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnyRigidBodyAwake_FunctionAddress, intPtr, IsAnyRigidBodyAwake_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnyRigidBodyAwake_ReturnValue_Offset), 0, IsAnyRigidBodyAwake_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IgnoreComponentWhenMoving")]
	public unsafe void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
	{
		CheckDestroyed();
		if (!IgnoreComponentWhenMoving_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IgnoreComponentWhenMoving");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IgnoreComponentWhenMoving_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IgnoreComponentWhenMoving_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, IgnoreComponentWhenMoving_Component_Offset), 0, IgnoreComponentWhenMoving_Component_PropertyAddress.Address, Component);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IgnoreComponentWhenMoving_bShouldIgnore_Offset), 0, IgnoreComponentWhenMoving_bShouldIgnore_PropertyAddress.Address, bShouldIgnore);
		NativeReflection.InvokeFunctionOptimized(base.Address, IgnoreComponentWhenMoving_FunctionAddress, intPtr, IgnoreComponentWhenMoving_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:IgnoreActorWhenMoving")]
	public unsafe void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
	{
		CheckDestroyed();
		if (!IgnoreActorWhenMoving_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:IgnoreActorWhenMoving");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IgnoreActorWhenMoving_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IgnoreActorWhenMoving_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IgnoreActorWhenMoving_Actor_Offset), 0, IgnoreActorWhenMoving_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IgnoreActorWhenMoving_bShouldIgnore_Offset), 0, IgnoreActorWhenMoving_bShouldIgnore_PropertyAddress.Address, bShouldIgnore);
		NativeReflection.InvokeFunctionOptimized(base.Address, IgnoreActorWhenMoving_FunctionAddress, intPtr, IgnoreActorWhenMoving_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetWalkableSlopeOverride")]
	public unsafe FWalkableSlopeOverride GetWalkableSlopeOverride()
	{
		CheckDestroyed();
		if (!GetWalkableSlopeOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetWalkableSlopeOverride");
			return default(FWalkableSlopeOverride);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWalkableSlopeOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWalkableSlopeOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWalkableSlopeOverride_FunctionAddress, intPtr, GetWalkableSlopeOverride_ParamsSize);
		return BlittableTypeMarshaler<FWalkableSlopeOverride>.FromNative(IntPtr.Add(intPtr, GetWalkableSlopeOverride_ReturnValue_Offset), 0, GetWalkableSlopeOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocityAtPoint")]
	public unsafe FVector GetPhysicsLinearVelocityAtPoint(FVector Point, FName BoneName)
	{
		CheckDestroyed();
		if (!GetPhysicsLinearVelocityAtPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocityAtPoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsLinearVelocityAtPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsLinearVelocityAtPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetPhysicsLinearVelocityAtPoint_Point_Offset), 0, GetPhysicsLinearVelocityAtPoint_Point_PropertyAddress.Address, Point);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPhysicsLinearVelocityAtPoint_BoneName_Offset), 0, GetPhysicsLinearVelocityAtPoint_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsLinearVelocityAtPoint_FunctionAddress, intPtr, GetPhysicsLinearVelocityAtPoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPhysicsLinearVelocityAtPoint_ReturnValue_Offset), 0, GetPhysicsLinearVelocityAtPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocity")]
	public unsafe FVector GetPhysicsLinearVelocity(FName BoneName)
	{
		CheckDestroyed();
		if (!GetPhysicsLinearVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsLinearVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsLinearVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPhysicsLinearVelocity_BoneName_Offset), 0, GetPhysicsLinearVelocity_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsLinearVelocity_FunctionAddress, intPtr, GetPhysicsLinearVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPhysicsLinearVelocity_ReturnValue_Offset), 0, GetPhysicsLinearVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInRadians")]
	public unsafe FVector GetPhysicsAngularVelocityInRadians(FName BoneName)
	{
		CheckDestroyed();
		if (!GetPhysicsAngularVelocityInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInRadians");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAngularVelocityInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAngularVelocityInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPhysicsAngularVelocityInRadians_BoneName_Offset), 0, GetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsAngularVelocityInRadians_FunctionAddress, intPtr, GetPhysicsAngularVelocityInRadians_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPhysicsAngularVelocityInRadians_ReturnValue_Offset), 0, GetPhysicsAngularVelocityInRadians_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInDegrees")]
	public unsafe FVector GetPhysicsAngularVelocityInDegrees(FName BoneName)
	{
		CheckDestroyed();
		if (!GetPhysicsAngularVelocityInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInDegrees");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsAngularVelocityInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsAngularVelocityInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPhysicsAngularVelocityInDegrees_BoneName_Offset), 0, GetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsAngularVelocityInDegrees_FunctionAddress, intPtr, GetPhysicsAngularVelocityInDegrees_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPhysicsAngularVelocityInDegrees_ReturnValue_Offset), 0, GetPhysicsAngularVelocityInDegrees_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetOverlappingComponents")]
	public unsafe void GetOverlappingComponents(out List<UPrimitiveComponent> OutOverlappingComponents)
	{
		CheckDestroyed();
		if (!GetOverlappingComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetOverlappingComponents");
			OutOverlappingComponents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverlappingComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverlappingComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverlappingComponents_FunctionAddress, intPtr, GetOverlappingComponents_ParamsSize);
		OutOverlappingComponents = new TArrayCopyMarshaler<UPrimitiveComponent>(1, GetOverlappingComponents_OutOverlappingComponents_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOverlappingComponents_OutOverlappingComponents_Offset));
		NativeReflection.DestroyValue_InContainer(GetOverlappingComponents_OutOverlappingComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetOverlappingActors")]
	public unsafe void GetOverlappingActors(out List<AActor> OverlappingActors, TSubclassOf<AActor> ClassFilter)
	{
		CheckDestroyed();
		if (!GetOverlappingActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetOverlappingActors");
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

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetNumMaterials")]
	public unsafe int GetNumMaterials()
	{
		CheckDestroyed();
		if (!GetNumMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetNumMaterials");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumMaterials_FunctionAddress, intPtr, GetNumMaterials_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumMaterials_ReturnValue_Offset), 0, GetNumMaterials_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetMaterialFromCollisionFaceIndex")]
	public unsafe UMaterialInterface GetMaterialFromCollisionFaceIndex(int FaceIndex, out int SectionIndex)
	{
		CheckDestroyed();
		if (!GetMaterialFromCollisionFaceIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetMaterialFromCollisionFaceIndex");
			SectionIndex = 0;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialFromCollisionFaceIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialFromCollisionFaceIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterialFromCollisionFaceIndex_FaceIndex_Offset), 0, GetMaterialFromCollisionFaceIndex_FaceIndex_PropertyAddress.Address, FaceIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialFromCollisionFaceIndex_FunctionAddress, intPtr, GetMaterialFromCollisionFaceIndex_ParamsSize);
		SectionIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaterialFromCollisionFaceIndex_SectionIndex_Offset), 0, GetMaterialFromCollisionFaceIndex_SectionIndex_PropertyAddress.Address);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetMaterialFromCollisionFaceIndex_ReturnValue_Offset), 0, GetMaterialFromCollisionFaceIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetMaterial")]
	public unsafe UMaterialInterface GetMaterial(int ElementIndex)
	{
		CheckDestroyed();
		if (!GetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterial_ElementIndex_Offset), 0, GetMaterial_ElementIndex_PropertyAddress.Address, ElementIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterial_FunctionAddress, intPtr, GetMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetMaterial_ReturnValue_Offset), 0, GetMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetMassScale")]
	public unsafe float GetMassScale(FName BoneName)
	{
		CheckDestroyed();
		if (!GetMassScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetMassScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMassScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMassScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMassScale_BoneName_Offset), 0, GetMassScale_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMassScale_FunctionAddress, intPtr, GetMassScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMassScale_ReturnValue_Offset), 0, GetMassScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetMass")]
	public unsafe float GetMass()
	{
		CheckDestroyed();
		if (!GetMass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetMass");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMass_FunctionAddress, intPtr, GetMass_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMass_ReturnValue_Offset), 0, GetMass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetLinearDamping")]
	public unsafe float GetLinearDamping()
	{
		CheckDestroyed();
		if (!GetLinearDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetLinearDamping");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinearDamping_FunctionAddress, intPtr, GetLinearDamping_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetLinearDamping_ReturnValue_Offset), 0, GetLinearDamping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetInertiaTensor")]
	public unsafe FVector GetInertiaTensor(FName BoneName)
	{
		CheckDestroyed();
		if (!GetInertiaTensor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetInertiaTensor");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInertiaTensor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInertiaTensor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInertiaTensor_BoneName_Offset), 0, GetInertiaTensor_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInertiaTensor_FunctionAddress, intPtr, GetInertiaTensor_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInertiaTensor_ReturnValue_Offset), 0, GetInertiaTensor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetGenerateOverlapEvents")]
	public unsafe bool GetGenerateOverlapEvents()
	{
		CheckDestroyed();
		if (!GetGenerateOverlapEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetGenerateOverlapEvents");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGenerateOverlapEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGenerateOverlapEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGenerateOverlapEvents_FunctionAddress, intPtr, GetGenerateOverlapEvents_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGenerateOverlapEvents_ReturnValue_Offset), 0, GetGenerateOverlapEvents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForVectorParameter")]
	public unsafe int GetCustomPrimitiveDataIndexForVectorParameter(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetCustomPrimitiveDataIndexForVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForVectorParameter");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomPrimitiveDataIndexForVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomPrimitiveDataIndexForVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_Offset), 0, GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, intPtr, GetCustomPrimitiveDataIndexForVectorParameter_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_Offset), 0, GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForScalarParameter")]
	public unsafe int GetCustomPrimitiveDataIndexForScalarParameter(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetCustomPrimitiveDataIndexForScalarParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForScalarParameter");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomPrimitiveDataIndexForScalarParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomPrimitiveDataIndexForScalarParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_Offset), 0, GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, intPtr, GetCustomPrimitiveDataIndexForScalarParameter_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_Offset), 0, GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCollisionResponseToChannel")]
	public unsafe ECollisionResponseType GetCollisionResponseToChannel(ECollisionChannel Channel)
	{
		CheckDestroyed();
		if (!GetCollisionResponseToChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCollisionResponseToChannel");
			return ECollisionResponseType.ECR_Ignore;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionResponseToChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionResponseToChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, GetCollisionResponseToChannel_Channel_Offset), 0, GetCollisionResponseToChannel_Channel_PropertyAddress.Address, Channel);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionResponseToChannel_FunctionAddress, intPtr, GetCollisionResponseToChannel_ParamsSize);
		return EnumMarshaler<ECollisionResponseType>.FromNative(IntPtr.Add(intPtr, GetCollisionResponseToChannel_ReturnValue_Offset), 0, GetCollisionResponseToChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCollisionProfileName")]
	public unsafe FName GetCollisionProfileName()
	{
		CheckDestroyed();
		if (!GetCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCollisionProfileName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionProfileName_FunctionAddress, intPtr, GetCollisionProfileName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCollisionProfileName_ReturnValue_Offset), 0, GetCollisionProfileName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCollisionObjectType")]
	public unsafe ECollisionChannel GetCollisionObjectType()
	{
		CheckDestroyed();
		if (!GetCollisionObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCollisionObjectType");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionObjectType_FunctionAddress, intPtr, GetCollisionObjectType_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, GetCollisionObjectType_ReturnValue_Offset), 0, GetCollisionObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCollisionEnabled")]
	public unsafe ECollisionEnabled GetCollisionEnabled()
	{
		CheckDestroyed();
		if (!GetCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCollisionEnabled");
			return ECollisionEnabled.NoCollision;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCollisionEnabled_FunctionAddress, intPtr, GetCollisionEnabled_ParamsSize);
		return EnumMarshaler<ECollisionEnabled>.FromNative(IntPtr.Add(intPtr, GetCollisionEnabled_ReturnValue_Offset), 0, GetCollisionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetClosestPointOnCollision")]
	public unsafe float GetClosestPointOnCollision(FVector Point, out FVector OutPointOnBody, FName BoneName)
	{
		CheckDestroyed();
		if (!GetClosestPointOnCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetClosestPointOnCollision");
			OutPointOnBody = default(FVector);
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClosestPointOnCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClosestPointOnCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetClosestPointOnCollision_Point_Offset), 0, GetClosestPointOnCollision_Point_PropertyAddress.Address, Point);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetClosestPointOnCollision_BoneName_Offset), 0, GetClosestPointOnCollision_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetClosestPointOnCollision_FunctionAddress, intPtr, GetClosestPointOnCollision_ParamsSize);
		OutPointOnBody = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetClosestPointOnCollision_OutPointOnBody_Offset), 0, GetClosestPointOnCollision_OutPointOnBody_PropertyAddress.Address);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetClosestPointOnCollision_ReturnValue_Offset), 0, GetClosestPointOnCollision_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetCenterOfMass")]
	public unsafe FVector GetCenterOfMass(FName BoneName)
	{
		CheckDestroyed();
		if (!GetCenterOfMass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetCenterOfMass");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCenterOfMass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCenterOfMass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCenterOfMass_BoneName_Offset), 0, GetCenterOfMass_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCenterOfMass_FunctionAddress, intPtr, GetCenterOfMass_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCenterOfMass_ReturnValue_Offset), 0, GetCenterOfMass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:GetAngularDamping")]
	public unsafe float GetAngularDamping()
	{
		CheckDestroyed();
		if (!GetAngularDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:GetAngularDamping");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAngularDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAngularDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAngularDamping_FunctionAddress, intPtr, GetAngularDamping_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAngularDamping_ReturnValue_Offset), 0, GetAngularDamping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CreateDynamicMaterialInstance")]
	public unsafe UMaterialInstanceDynamic CreateDynamicMaterialInstance(int ElementIndex, UMaterialInterface SourceMaterial, FName OptionalName)
	{
		CheckDestroyed();
		if (!CreateDynamicMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:CreateDynamicMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDynamicMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDynamicMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_ElementIndex_Offset), 0, CreateDynamicMaterialInstance_ElementIndex_PropertyAddress.Address, ElementIndex);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_SourceMaterial_Offset), 0, CreateDynamicMaterialInstance_SourceMaterial_PropertyAddress.Address, SourceMaterial);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_OptionalName_Offset), 0, CreateDynamicMaterialInstance_OptionalName_PropertyAddress.Address, OptionalName);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateDynamicMaterialInstance_FunctionAddress, intPtr, CreateDynamicMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_ReturnValue_Offset), 0, CreateDynamicMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreComponents")]
	public unsafe List<UPrimitiveComponent> CopyArrayOfMoveIgnoreComponents()
	{
		CheckDestroyed();
		if (!CopyArrayOfMoveIgnoreComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyArrayOfMoveIgnoreComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyArrayOfMoveIgnoreComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyArrayOfMoveIgnoreComponents_FunctionAddress, intPtr, CopyArrayOfMoveIgnoreComponents_ParamsSize);
		List<UPrimitiveComponent> result = new TArrayCopyMarshaler<UPrimitiveComponent>(1, CopyArrayOfMoveIgnoreComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, CopyArrayOfMoveIgnoreComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CopyArrayOfMoveIgnoreComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreActors")]
	public unsafe List<AActor> CopyArrayOfMoveIgnoreActors()
	{
		CheckDestroyed();
		if (!CopyArrayOfMoveIgnoreActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyArrayOfMoveIgnoreActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyArrayOfMoveIgnoreActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyArrayOfMoveIgnoreActors_FunctionAddress, intPtr, CopyArrayOfMoveIgnoreActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, CopyArrayOfMoveIgnoreActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, CopyArrayOfMoveIgnoreActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CopyArrayOfMoveIgnoreActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreComponents")]
	public unsafe void ClearMoveIgnoreComponents()
	{
		CheckDestroyed();
		if (!ClearMoveIgnoreComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMoveIgnoreComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMoveIgnoreComponents_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMoveIgnoreComponents_FunctionAddress, argsSize: ClearMoveIgnoreComponents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreActors")]
	public unsafe void ClearMoveIgnoreActors()
	{
		CheckDestroyed();
		if (!ClearMoveIgnoreActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMoveIgnoreActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMoveIgnoreActors_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMoveIgnoreActors_FunctionAddress, argsSize: ClearMoveIgnoreActors_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:CanCharacterStepUp")]
	public unsafe bool CanCharacterStepUp(APawn Pawn)
	{
		CheckDestroyed();
		if (!CanCharacterStepUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:CanCharacterStepUp");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanCharacterStepUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanCharacterStepUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, CanCharacterStepUp_Pawn_Offset), 0, CanCharacterStepUp_Pawn_PropertyAddress.Address, Pawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanCharacterStepUp_FunctionAddress, intPtr, CanCharacterStepUp_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanCharacterStepUp_ReturnValue_Offset), 0, CanCharacterStepUp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddVelocityChangeImpulseAtLocation")]
	public unsafe void AddVelocityChangeImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
	{
		CheckDestroyed();
		if (!AddVelocityChangeImpulseAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddVelocityChangeImpulseAtLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVelocityChangeImpulseAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVelocityChangeImpulseAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVelocityChangeImpulseAtLocation_Impulse_Offset), 0, AddVelocityChangeImpulseAtLocation_Impulse_PropertyAddress.Address, Impulse);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVelocityChangeImpulseAtLocation_Location_Offset), 0, AddVelocityChangeImpulseAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVelocityChangeImpulseAtLocation_BoneName_Offset), 0, AddVelocityChangeImpulseAtLocation_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVelocityChangeImpulseAtLocation_FunctionAddress, intPtr, AddVelocityChangeImpulseAtLocation_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddTorqueInRadians")]
	public unsafe void AddTorqueInRadians(FVector Torque, FName BoneName, bool bAccelChange)
	{
		CheckDestroyed();
		if (!AddTorqueInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddTorqueInRadians");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTorqueInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTorqueInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddTorqueInRadians_Torque_Offset), 0, AddTorqueInRadians_Torque_PropertyAddress.Address, Torque);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTorqueInRadians_BoneName_Offset), 0, AddTorqueInRadians_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddTorqueInRadians_bAccelChange_Offset), 0, AddTorqueInRadians_bAccelChange_PropertyAddress.Address, bAccelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTorqueInRadians_FunctionAddress, intPtr, AddTorqueInRadians_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddTorqueInDegrees")]
	public unsafe void AddTorqueInDegrees(FVector Torque, FName BoneName, bool bAccelChange)
	{
		CheckDestroyed();
		if (!AddTorqueInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddTorqueInDegrees");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTorqueInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTorqueInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddTorqueInDegrees_Torque_Offset), 0, AddTorqueInDegrees_Torque_PropertyAddress.Address, Torque);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTorqueInDegrees_BoneName_Offset), 0, AddTorqueInDegrees_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddTorqueInDegrees_bAccelChange_Offset), 0, AddTorqueInDegrees_bAccelChange_PropertyAddress.Address, bAccelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTorqueInDegrees_FunctionAddress, intPtr, AddTorqueInDegrees_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddRadialImpulse")]
	public unsafe void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange = false)
	{
		CheckDestroyed();
		if (!AddRadialImpulse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddRadialImpulse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRadialImpulse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRadialImpulse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddRadialImpulse_Origin_Offset), 0, AddRadialImpulse_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddRadialImpulse_Radius_Offset), 0, AddRadialImpulse_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddRadialImpulse_Strength_Offset), 0, AddRadialImpulse_Strength_PropertyAddress.Address, Strength);
		EnumMarshaler<ERadialImpulseFalloff>.ToNative(IntPtr.Add(intPtr, AddRadialImpulse_Falloff_Offset), 0, AddRadialImpulse_Falloff_PropertyAddress.Address, Falloff);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRadialImpulse_bVelChange_Offset), 0, AddRadialImpulse_bVelChange_PropertyAddress.Address, bVelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRadialImpulse_FunctionAddress, intPtr, AddRadialImpulse_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddRadialForce")]
	public unsafe void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange = false)
	{
		CheckDestroyed();
		if (!AddRadialForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddRadialForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRadialForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRadialForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddRadialForce_Origin_Offset), 0, AddRadialForce_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddRadialForce_Radius_Offset), 0, AddRadialForce_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddRadialForce_Strength_Offset), 0, AddRadialForce_Strength_PropertyAddress.Address, Strength);
		EnumMarshaler<ERadialImpulseFalloff>.ToNative(IntPtr.Add(intPtr, AddRadialForce_Falloff_Offset), 0, AddRadialForce_Falloff_PropertyAddress.Address, Falloff);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRadialForce_bAccelChange_Offset), 0, AddRadialForce_bAccelChange_PropertyAddress.Address, bAccelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRadialForce_FunctionAddress, intPtr, AddRadialForce_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddImpulseAtLocation")]
	public unsafe void AddImpulseAtLocation(FVector Impulse, FVector Location, FName BoneName)
	{
		CheckDestroyed();
		if (!AddImpulseAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddImpulseAtLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddImpulseAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddImpulseAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddImpulseAtLocation_Impulse_Offset), 0, AddImpulseAtLocation_Impulse_PropertyAddress.Address, Impulse);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddImpulseAtLocation_Location_Offset), 0, AddImpulseAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddImpulseAtLocation_BoneName_Offset), 0, AddImpulseAtLocation_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddImpulseAtLocation_FunctionAddress, intPtr, AddImpulseAtLocation_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddImpulse")]
	public unsafe void AddImpulse(FVector Impulse, FName BoneName, bool bVelChange)
	{
		CheckDestroyed();
		if (!AddImpulse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddImpulse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddImpulse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddImpulse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddImpulse_Impulse_Offset), 0, AddImpulse_Impulse_PropertyAddress.Address, Impulse);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddImpulse_BoneName_Offset), 0, AddImpulse_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddImpulse_bVelChange_Offset), 0, AddImpulse_bVelChange_PropertyAddress.Address, bVelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddImpulse_FunctionAddress, intPtr, AddImpulse_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddForceAtLocationLocal")]
	public unsafe void AddForceAtLocationLocal(FVector Force, FVector Location, FName BoneName)
	{
		CheckDestroyed();
		if (!AddForceAtLocationLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddForceAtLocationLocal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddForceAtLocationLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddForceAtLocationLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForceAtLocationLocal_Force_Offset), 0, AddForceAtLocationLocal_Force_PropertyAddress.Address, Force);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForceAtLocationLocal_Location_Offset), 0, AddForceAtLocationLocal_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddForceAtLocationLocal_BoneName_Offset), 0, AddForceAtLocationLocal_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddForceAtLocationLocal_FunctionAddress, intPtr, AddForceAtLocationLocal_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddForceAtLocation")]
	public unsafe void AddForceAtLocation(FVector Force, FVector Location, FName BoneName)
	{
		CheckDestroyed();
		if (!AddForceAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddForceAtLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddForceAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddForceAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForceAtLocation_Force_Offset), 0, AddForceAtLocation_Force_PropertyAddress.Address, Force);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForceAtLocation_Location_Offset), 0, AddForceAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddForceAtLocation_BoneName_Offset), 0, AddForceAtLocation_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddForceAtLocation_FunctionAddress, intPtr, AddForceAtLocation_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddForce")]
	public unsafe void AddForce(FVector Force, FName BoneName, bool bAccelChange)
	{
		CheckDestroyed();
		if (!AddForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddForce_Force_Offset), 0, AddForce_Force_PropertyAddress.Address, Force);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddForce_BoneName_Offset), 0, AddForce_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddForce_bAccelChange_Offset), 0, AddForce_bAccelChange_PropertyAddress.Address, bAccelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddForce_FunctionAddress, intPtr, AddForce_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddAngularImpulseInRadians")]
	public unsafe void AddAngularImpulseInRadians(FVector Impulse, FName BoneName, bool bVelChange)
	{
		CheckDestroyed();
		if (!AddAngularImpulseInRadians_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddAngularImpulseInRadians");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAngularImpulseInRadians_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAngularImpulseInRadians_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInRadians_Impulse_Offset), 0, AddAngularImpulseInRadians_Impulse_PropertyAddress.Address, Impulse);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInRadians_BoneName_Offset), 0, AddAngularImpulseInRadians_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInRadians_bVelChange_Offset), 0, AddAngularImpulseInRadians_bVelChange_PropertyAddress.Address, bVelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAngularImpulseInRadians_FunctionAddress, intPtr, AddAngularImpulseInRadians_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PrimitiveComponent:AddAngularImpulseInDegrees")]
	public unsafe void AddAngularImpulseInDegrees(FVector Impulse, FName BoneName, bool bVelChange)
	{
		CheckDestroyed();
		if (!AddAngularImpulseInDegrees_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PrimitiveComponent:AddAngularImpulseInDegrees");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAngularImpulseInDegrees_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAngularImpulseInDegrees_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInDegrees_Impulse_Offset), 0, AddAngularImpulseInDegrees_Impulse_PropertyAddress.Address, Impulse);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInDegrees_BoneName_Offset), 0, AddAngularImpulseInDegrees_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddAngularImpulseInDegrees_bVelChange_Offset), 0, AddAngularImpulseInDegrees_bVelChange_PropertyAddress.Address, bVelChange);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAngularImpulseInDegrees_FunctionAddress, intPtr, AddAngularImpulseInDegrees_ParamsSize);
	}

	static UPrimitiveComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPrimitiveComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPrimitiveComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PrimitiveComponent");
		MinDrawDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDrawDistance");
		MinDrawDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDrawDistance", Classes.FFloatProperty);
		LDMaxDrawDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LDMaxDrawDistance");
		LDMaxDrawDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LDMaxDrawDistance", Classes.FFloatProperty);
		CachedMaxDrawDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedMaxDrawDistance");
		CachedMaxDrawDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedMaxDrawDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IndirectLightingCacheQuality_PropertyAddress, intPtr, "IndirectLightingCacheQuality");
		IndirectLightingCacheQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectLightingCacheQuality");
		IndirectLightingCacheQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectLightingCacheQuality", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LightmapType_PropertyAddress, intPtr, "LightmapType");
		LightmapType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightmapType");
		LightmapType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightmapType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAutoLODGeneration_PropertyAddress, intPtr, "bEnableAutoLODGeneration");
		EnableAutoLODGeneration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableAutoLODGeneration");
		EnableAutoLODGeneration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableAutoLODGeneration", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExcludeForSpecificHLODLevels_PropertyAddress, intPtr, "ExcludeForSpecificHLODLevels");
		ExcludeForSpecificHLODLevels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExcludeForSpecificHLODLevels");
		ExcludeForSpecificHLODLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExcludeForSpecificHLODLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HLODBatchingPolicy_PropertyAddress, intPtr, "HLODBatchingPolicy");
		HLODBatchingPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HLODBatchingPolicy");
		HLODBatchingPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HLODBatchingPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref NeverDistanceCull_PropertyAddress, intPtr, "bNeverDistanceCull");
		NeverDistanceCull_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNeverDistanceCull");
		NeverDistanceCull_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNeverDistanceCull", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysCreatePhysicsState_PropertyAddress, intPtr, "bAlwaysCreatePhysicsState");
		AlwaysCreatePhysicsState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysCreatePhysicsState");
		AlwaysCreatePhysicsState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysCreatePhysicsState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiBodyOverlap_PropertyAddress, intPtr, "bMultiBodyOverlap");
		MultiBodyOverlap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMultiBodyOverlap");
		MultiBodyOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMultiBodyOverlap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceComplexOnMove_PropertyAddress, intPtr, "bTraceComplexOnMove");
		TraceComplexOnMove_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTraceComplexOnMove");
		TraceComplexOnMove_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTraceComplexOnMove", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReturnMaterialOnMove_PropertyAddress, intPtr, "bReturnMaterialOnMove");
		ReturnMaterialOnMove_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReturnMaterialOnMove");
		ReturnMaterialOnMove_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReturnMaterialOnMove", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowCullDistanceVolume_PropertyAddress, intPtr, "bAllowCullDistanceVolume");
		AllowCullDistanceVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowCullDistanceVolume");
		AllowCullDistanceVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowCullDistanceVolume", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibleInReflectionCaptures_PropertyAddress, intPtr, "bVisibleInReflectionCaptures");
		VisibleInReflectionCaptures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisibleInReflectionCaptures");
		VisibleInReflectionCaptures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisibleInReflectionCaptures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibleInRealTimeSkyCaptures_PropertyAddress, intPtr, "bVisibleInRealTimeSkyCaptures");
		VisibleInRealTimeSkyCaptures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisibleInRealTimeSkyCaptures");
		VisibleInRealTimeSkyCaptures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisibleInRealTimeSkyCaptures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibleInRayTracing_PropertyAddress, intPtr, "bVisibleInRayTracing");
		VisibleInRayTracing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisibleInRayTracing");
		VisibleInRayTracing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisibleInRayTracing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastHybridRayTracingShadow_PropertyAddress, intPtr, "bCastHybridRayTracingShadow");
		CastHybridRayTracingShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastHybridRayTracingShadow");
		CastHybridRayTracingShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastHybridRayTracingShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress, intPtr, "bSkeletalMeshOutputRTDepthMaskInDepthPass");
		SkeletalMeshOutputRTDepthMaskInDepthPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkeletalMeshOutputRTDepthMaskInDepthPass");
		SkeletalMeshOutputRTDepthMaskInDepthPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkeletalMeshOutputRTDepthMaskInDepthPass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderInMainPass_PropertyAddress, intPtr, "bRenderInMainPass");
		RenderInMainPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderInMainPass");
		RenderInMainPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderInMainPass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderInMBOIT_PropertyAddress, intPtr, "bRenderInMBOIT");
		RenderInMBOIT_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderInMBOIT");
		RenderInMBOIT_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderInMBOIT", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderTranslucentDepth_PropertyAddress, intPtr, "bRenderTranslucentDepth");
		RenderTranslucentDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderTranslucentDepth");
		RenderTranslucentDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderTranslucentDepth", Classes.FBoolProperty);
		TranslucentDepthOpacityMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslucentDepthOpacityMask");
		TranslucentDepthOpacityMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslucentDepthOpacityMask", Classes.FFloatProperty);
		PerObjectShadowResScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerObjectShadowResScale");
		PerObjectShadowResScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerObjectShadowResScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderInDepthPass_PropertyAddress, intPtr, "bRenderInDepthPass");
		RenderInDepthPass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderInDepthPass");
		RenderInDepthPass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderInDepthPass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceivesDecals_PropertyAddress, intPtr, "bReceivesDecals");
		ReceivesDecals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReceivesDecals");
		ReceivesDecals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReceivesDecals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OwnerNoSee_PropertyAddress, intPtr, "bOwnerNoSee");
		OwnerNoSee_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOwnerNoSee");
		OwnerNoSee_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOwnerNoSee", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnlyOwnerSee_PropertyAddress, intPtr, "bOnlyOwnerSee");
		OnlyOwnerSee_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnlyOwnerSee");
		OnlyOwnerSee_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnlyOwnerSee", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TreatAsBackgroundForOcclusion_PropertyAddress, intPtr, "bTreatAsBackgroundForOcclusion");
		TreatAsBackgroundForOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTreatAsBackgroundForOcclusion");
		TreatAsBackgroundForOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTreatAsBackgroundForOcclusion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAsOccluder_PropertyAddress, intPtr, "bUseAsOccluder");
		UseAsOccluder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAsOccluder");
		UseAsOccluder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAsOccluder", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceMipStreaming_PropertyAddress, intPtr, "bForceMipStreaming");
		ForceMipStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceMipStreaming");
		ForceMipStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceMipStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadow_PropertyAddress, intPtr, "CastShadow");
		CastShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastShadow");
		CastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EmissiveLightSource_PropertyAddress, intPtr, "bEmissiveLightSource");
		EmissiveLightSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmissiveLightSource");
		EmissiveLightSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmissiveLightSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDynamicIndirectLighting_PropertyAddress, intPtr, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectDynamicIndirectLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDistanceFieldLighting_PropertyAddress, intPtr, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectDistanceFieldLighting");
		AffectDistanceFieldLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectDistanceFieldLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastDynamicShadow_PropertyAddress, intPtr, "bCastDynamicShadow");
		CastDynamicShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastDynamicShadow");
		CastDynamicShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastDynamicShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastStaticShadow_PropertyAddress, intPtr, "bCastStaticShadow");
		CastStaticShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastStaticShadow");
		CastStaticShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastStaticShadow", Classes.FBoolProperty);
		WPOEvaluateDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WPOEvaluateDistanceScale");
		WPOEvaluateDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WPOEvaluateDistanceScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CastVolumetricTranslucentShadow_PropertyAddress, intPtr, "bCastVolumetricTranslucentShadow");
		CastVolumetricTranslucentShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastVolumetricTranslucentShadow");
		CastVolumetricTranslucentShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastVolumetricTranslucentShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastContactShadow_PropertyAddress, intPtr, "bCastContactShadow");
		CastContactShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastContactShadow");
		CastContactShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastContactShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelfShadowOnly_PropertyAddress, intPtr, "bSelfShadowOnly");
		SelfShadowOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSelfShadowOnly");
		SelfShadowOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSelfShadowOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastFarShadow_PropertyAddress, intPtr, "bCastFarShadow");
		CastFarShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastFarShadow");
		CastFarShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastFarShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastInsetShadow_PropertyAddress, intPtr, "bCastInsetShadow");
		CastInsetShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastInsetShadow");
		CastInsetShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastInsetShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastCinematicShadow_PropertyAddress, intPtr, "bCastCinematicShadow");
		CastCinematicShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastCinematicShadow");
		CastCinematicShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastCinematicShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastHiddenShadow_PropertyAddress, intPtr, "bCastHiddenShadow");
		CastHiddenShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastHiddenShadow");
		CastHiddenShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastHiddenShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowAsTwoSided_PropertyAddress, intPtr, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadowAsTwoSided");
		CastShadowAsTwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadowAsTwoSided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LightAttachmentsAsGroup_PropertyAddress, intPtr, "bLightAttachmentsAsGroup");
		LightAttachmentsAsGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLightAttachmentsAsGroup");
		LightAttachmentsAsGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLightAttachmentsAsGroup", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExcludeFromLightAttachmentGroup_PropertyAddress, intPtr, "bExcludeFromLightAttachmentGroup");
		ExcludeFromLightAttachmentGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExcludeFromLightAttachmentGroup");
		ExcludeFromLightAttachmentGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExcludeFromLightAttachmentGroup", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveMobileCSMShadows_PropertyAddress, intPtr, "bReceiveMobileCSMShadows");
		ReceiveMobileCSMShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReceiveMobileCSMShadows");
		ReceiveMobileCSMShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReceiveMobileCSMShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SingleSampleShadowFromStationaryLights_PropertyAddress, intPtr, "bSingleSampleShadowFromStationaryLights");
		SingleSampleShadowFromStationaryLights_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSingleSampleShadowFromStationaryLights");
		SingleSampleShadowFromStationaryLights_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSingleSampleShadowFromStationaryLights", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreRadialImpulse_PropertyAddress, intPtr, "bIgnoreRadialImpulse");
		IgnoreRadialImpulse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreRadialImpulse");
		IgnoreRadialImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreRadialImpulse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreRadialForce_PropertyAddress, intPtr, "bIgnoreRadialForce");
		IgnoreRadialForce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreRadialForce");
		IgnoreRadialForce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreRadialForce", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyImpulseOnDamage_PropertyAddress, intPtr, "bApplyImpulseOnDamage");
		ApplyImpulseOnDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyImpulseOnDamage");
		ApplyImpulseOnDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyImpulseOnDamage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplicatePhysicsToAutonomousProxy_PropertyAddress, intPtr, "bReplicatePhysicsToAutonomousProxy");
		ReplicatePhysicsToAutonomousProxy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReplicatePhysicsToAutonomousProxy");
		ReplicatePhysicsToAutonomousProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReplicatePhysicsToAutonomousProxy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderCustomDepth_PropertyAddress, intPtr, "bRenderCustomDepth");
		RenderCustomDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderCustomDepth");
		RenderCustomDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderCustomDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibleInSceneCaptureOnly_PropertyAddress, intPtr, "bVisibleInSceneCaptureOnly");
		VisibleInSceneCaptureOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisibleInSceneCaptureOnly");
		VisibleInSceneCaptureOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisibleInSceneCaptureOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HiddenInSceneCapture_PropertyAddress, intPtr, "bHiddenInSceneCapture");
		HiddenInSceneCapture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHiddenInSceneCapture");
		HiddenInSceneCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHiddenInSceneCapture", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderGSVoxelization_PropertyAddress, intPtr, "bRenderGSVoxelization");
		RenderGSVoxelization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderGSVoxelization");
		RenderGSVoxelization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderGSVoxelization", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateRayTracingWaterCaustics_PropertyAddress, intPtr, "bEvaluateRayTracingWaterCaustics");
		EvaluateRayTracingWaterCaustics_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEvaluateRayTracingWaterCaustics");
		EvaluateRayTracingWaterCaustics_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEvaluateRayTracingWaterCaustics", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceRenderInLumenScene_PropertyAddress, intPtr, "bForceRenderInLumenScene");
		ForceRenderInLumenScene_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceRenderInLumenScene");
		ForceRenderInLumenScene_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceRenderInLumenScene", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCharacterStepUpOn_PropertyAddress, intPtr, "CanCharacterStepUpOn");
		CanCharacterStepUpOn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanCharacterStepUpOn");
		CanCharacterStepUpOn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanCharacterStepUpOn", Classes.FByteProperty);
		LightingChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightingChannels");
		LightingChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightingChannels", Classes.FStructProperty);
		RayTracingGroupId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayTracingGroupId");
		RayTracingGroupId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayTracingGroupId", Classes.FIntProperty);
		CustomDepthStencilValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDepthStencilValue");
		CustomDepthStencilValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDepthStencilValue", Classes.FIntProperty);
		TranslucencySortPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslucencySortPriority");
		TranslucencySortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslucencySortPriority", Classes.FIntProperty);
		TranslucencySortDistanceOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslucencySortDistanceOffset");
		TranslucencySortDistanceOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslucencySortDistanceOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RuntimeVirtualTextures_PropertyAddress, intPtr, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RuntimeVirtualTextures");
		RuntimeVirtualTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RuntimeVirtualTextures", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VirtualTextureRenderPassType_PropertyAddress, intPtr, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VirtualTextureRenderPassType");
		VirtualTextureRenderPassType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VirtualTextureRenderPassType", Classes.FEnumProperty);
		BodyInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BodyInstance");
		BodyInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BodyInstance", Classes.FStructProperty);
		OnComponentHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentHit");
		OnComponentHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentHit", Classes.FMulticastDelegateProperty);
		OnComponentBeginOverlap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentBeginOverlap");
		OnComponentBeginOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentBeginOverlap", Classes.FMulticastDelegateProperty);
		OnComponentEndOverlap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentEndOverlap");
		OnComponentEndOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentEndOverlap", Classes.FMulticastDelegateProperty);
		OnComponentWake_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentWake");
		OnComponentWake_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentWake", Classes.FMulticastDelegateProperty);
		OnComponentSleep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComponentSleep");
		OnComponentSleep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComponentSleep", Classes.FMulticastDelegateProperty);
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
		NativeReflectionCached.GetPropertyRef(ref RayTracingGroupCullingPriority_PropertyAddress, intPtr, "RayTracingGroupCullingPriority");
		RayTracingGroupCullingPriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayTracingGroupCullingPriority");
		RayTracingGroupCullingPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayTracingGroupCullingPriority", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomDepthStencilWriteMask_PropertyAddress, intPtr, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDepthStencilWriteMask");
		CustomDepthStencilWriteMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDepthStencilWriteMask", Classes.FEnumProperty);
		WasRecentlyRendered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WasRecentlyRendered");
		WasRecentlyRendered_ParamsSize = NativeReflection.GetFunctionParamsSize(WasRecentlyRendered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasRecentlyRendered_Tolerance_PropertyAddress, WasRecentlyRendered_FunctionAddress, "Tolerance");
		WasRecentlyRendered_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(WasRecentlyRendered_FunctionAddress, "Tolerance");
		WasRecentlyRendered_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(WasRecentlyRendered_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WasRecentlyRendered_ReturnValue_PropertyAddress, WasRecentlyRendered_FunctionAddress, "ReturnValue");
		WasRecentlyRendered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasRecentlyRendered_FunctionAddress, "ReturnValue");
		WasRecentlyRendered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasRecentlyRendered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasRecentlyRendered_IsValid = WasRecentlyRendered_FunctionAddress != IntPtr.Zero && WasRecentlyRendered_Tolerance_IsValid && WasRecentlyRendered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:WasRecentlyRendered", WasRecentlyRendered_IsValid);
		WakeRigidBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WakeRigidBody");
		WakeRigidBody_ParamsSize = NativeReflection.GetFunctionParamsSize(WakeRigidBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WakeRigidBody_BoneName_PropertyAddress, WakeRigidBody_FunctionAddress, "BoneName");
		WakeRigidBody_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(WakeRigidBody_FunctionAddress, "BoneName");
		WakeRigidBody_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(WakeRigidBody_FunctionAddress, "BoneName", Classes.FNameProperty);
		WakeRigidBody_IsValid = WakeRigidBody_FunctionAddress != IntPtr.Zero && WakeRigidBody_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:WakeRigidBody", WakeRigidBody_IsValid);
		WakeAllRigidBodies_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WakeAllRigidBodies");
		WakeAllRigidBodies_ParamsSize = NativeReflection.GetFunctionParamsSize(WakeAllRigidBodies_FunctionAddress);
		WakeAllRigidBodies_IsValid = WakeAllRigidBodies_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:WakeAllRigidBodies", WakeAllRigidBodies_IsValid);
		SetWalkableSlopeOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWalkableSlopeOverride");
		SetWalkableSlopeOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWalkableSlopeOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWalkableSlopeOverride_NewOverride_PropertyAddress, SetWalkableSlopeOverride_FunctionAddress, "NewOverride");
		SetWalkableSlopeOverride_NewOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetWalkableSlopeOverride_FunctionAddress, "NewOverride");
		SetWalkableSlopeOverride_NewOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWalkableSlopeOverride_FunctionAddress, "NewOverride", Classes.FStructProperty);
		SetWalkableSlopeOverride_IsValid = SetWalkableSlopeOverride_FunctionAddress != IntPtr.Zero && SetWalkableSlopeOverride_NewOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetWalkableSlopeOverride", SetWalkableSlopeOverride_IsValid);
		SetVisibleInSceneCaptureOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVisibleInSceneCaptureOnly");
		SetVisibleInSceneCaptureOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibleInSceneCaptureOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisibleInSceneCaptureOnly_bValue_PropertyAddress, SetVisibleInSceneCaptureOnly_FunctionAddress, "bValue");
		SetVisibleInSceneCaptureOnly_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibleInSceneCaptureOnly_FunctionAddress, "bValue");
		SetVisibleInSceneCaptureOnly_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibleInSceneCaptureOnly_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetVisibleInSceneCaptureOnly_IsValid = SetVisibleInSceneCaptureOnly_FunctionAddress != IntPtr.Zero && SetVisibleInSceneCaptureOnly_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetVisibleInSceneCaptureOnly", SetVisibleInSceneCaptureOnly_IsValid);
		SetVisibleInRayTracing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVisibleInRayTracing");
		SetVisibleInRayTracing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibleInRayTracing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisibleInRayTracing_bNewVisibleInRayTracing_PropertyAddress, SetVisibleInRayTracing_FunctionAddress, "bNewVisibleInRayTracing");
		SetVisibleInRayTracing_bNewVisibleInRayTracing_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibleInRayTracing_FunctionAddress, "bNewVisibleInRayTracing");
		SetVisibleInRayTracing_bNewVisibleInRayTracing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibleInRayTracing_FunctionAddress, "bNewVisibleInRayTracing", Classes.FBoolProperty);
		SetVisibleInRayTracing_IsValid = SetVisibleInRayTracing_FunctionAddress != IntPtr.Zero && SetVisibleInRayTracing_bNewVisibleInRayTracing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetVisibleInRayTracing", SetVisibleInRayTracing_IsValid);
		SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVectorParameterForDefaultCustomPrimitiveData");
		SetVectorParameterForDefaultCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress, SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterForDefaultCustomPrimitiveData_Value_PropertyAddress, SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value");
		SetVectorParameterForDefaultCustomPrimitiveData_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value");
		SetVectorParameterForDefaultCustomPrimitiveData_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorParameterForDefaultCustomPrimitiveData_IsValid = SetVectorParameterForDefaultCustomPrimitiveData_FunctionAddress != IntPtr.Zero && SetVectorParameterForDefaultCustomPrimitiveData_ParameterName_IsValid && SetVectorParameterForDefaultCustomPrimitiveData_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetVectorParameterForDefaultCustomPrimitiveData", SetVectorParameterForDefaultCustomPrimitiveData_IsValid);
		SetVectorParameterForCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVectorParameterForCustomPrimitiveData");
		SetVectorParameterForCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterForCustomPrimitiveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterForCustomPrimitiveData_ParameterName_PropertyAddress, SetVectorParameterForCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetVectorParameterForCustomPrimitiveData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterForCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetVectorParameterForCustomPrimitiveData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterForCustomPrimitiveData_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterForCustomPrimitiveData_Value_PropertyAddress, SetVectorParameterForCustomPrimitiveData_FunctionAddress, "Value");
		SetVectorParameterForCustomPrimitiveData_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterForCustomPrimitiveData_FunctionAddress, "Value");
		SetVectorParameterForCustomPrimitiveData_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterForCustomPrimitiveData_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorParameterForCustomPrimitiveData_IsValid = SetVectorParameterForCustomPrimitiveData_FunctionAddress != IntPtr.Zero && SetVectorParameterForCustomPrimitiveData_ParameterName_IsValid && SetVectorParameterForCustomPrimitiveData_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetVectorParameterForCustomPrimitiveData", SetVectorParameterForCustomPrimitiveData_IsValid);
		SetUseCCD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseCCD");
		SetUseCCD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseCCD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseCCD_InUseCCD_PropertyAddress, SetUseCCD_FunctionAddress, "InUseCCD");
		SetUseCCD_InUseCCD_Offset = NativeReflectionCached.GetPropertyOffset(SetUseCCD_FunctionAddress, "InUseCCD");
		SetUseCCD_InUseCCD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseCCD_FunctionAddress, "InUseCCD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUseCCD_BoneName_PropertyAddress, SetUseCCD_FunctionAddress, "BoneName");
		SetUseCCD_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetUseCCD_FunctionAddress, "BoneName");
		SetUseCCD_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseCCD_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetUseCCD_IsValid = SetUseCCD_FunctionAddress != IntPtr.Zero && SetUseCCD_InUseCCD_IsValid && SetUseCCD_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetUseCCD", SetUseCCD_IsValid);
		SetTranslucentSortPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTranslucentSortPriority");
		SetTranslucentSortPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTranslucentSortPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTranslucentSortPriority_NewTranslucentSortPriority_PropertyAddress, SetTranslucentSortPriority_FunctionAddress, "NewTranslucentSortPriority");
		SetTranslucentSortPriority_NewTranslucentSortPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetTranslucentSortPriority_FunctionAddress, "NewTranslucentSortPriority");
		SetTranslucentSortPriority_NewTranslucentSortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTranslucentSortPriority_FunctionAddress, "NewTranslucentSortPriority", Classes.FIntProperty);
		SetTranslucentSortPriority_IsValid = SetTranslucentSortPriority_FunctionAddress != IntPtr.Zero && SetTranslucentSortPriority_NewTranslucentSortPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetTranslucentSortPriority", SetTranslucentSortPriority_IsValid);
		SetTranslucencySortDistanceOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTranslucencySortDistanceOffset");
		SetTranslucencySortDistanceOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTranslucencySortDistanceOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_PropertyAddress, SetTranslucencySortDistanceOffset_FunctionAddress, "NewTranslucencySortDistanceOffset");
		SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetTranslucencySortDistanceOffset_FunctionAddress, "NewTranslucencySortDistanceOffset");
		SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTranslucencySortDistanceOffset_FunctionAddress, "NewTranslucencySortDistanceOffset", Classes.FFloatProperty);
		SetTranslucencySortDistanceOffset_IsValid = SetTranslucencySortDistanceOffset_FunctionAddress != IntPtr.Zero && SetTranslucencySortDistanceOffset_NewTranslucencySortDistanceOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetTranslucencySortDistanceOffset", SetTranslucencySortDistanceOffset_IsValid);
		SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkeletalMeshOutputRTDepthMaskInDepthPass");
		SetSkeletalMeshOutputRTDepthMaskInDepthPass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_PropertyAddress, SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress, "bNewSkeletalMeshOutputRTDepthMaskInDepthPass");
		SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress, "bNewSkeletalMeshOutputRTDepthMaskInDepthPass");
		SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress, "bNewSkeletalMeshOutputRTDepthMaskInDepthPass", Classes.FBoolProperty);
		SetSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid = SetSkeletalMeshOutputRTDepthMaskInDepthPass_FunctionAddress != IntPtr.Zero && SetSkeletalMeshOutputRTDepthMaskInDepthPass_bNewSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetSkeletalMeshOutputRTDepthMaskInDepthPass", SetSkeletalMeshOutputRTDepthMaskInDepthPass_IsValid);
		SetSingleSampleShadowFromStationaryLights_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSingleSampleShadowFromStationaryLights");
		SetSingleSampleShadowFromStationaryLights_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSingleSampleShadowFromStationaryLights_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_PropertyAddress, SetSingleSampleShadowFromStationaryLights_FunctionAddress, "bNewSingleSampleShadowFromStationaryLights");
		SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_Offset = NativeReflectionCached.GetPropertyOffset(SetSingleSampleShadowFromStationaryLights_FunctionAddress, "bNewSingleSampleShadowFromStationaryLights");
		SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSingleSampleShadowFromStationaryLights_FunctionAddress, "bNewSingleSampleShadowFromStationaryLights", Classes.FBoolProperty);
		SetSingleSampleShadowFromStationaryLights_IsValid = SetSingleSampleShadowFromStationaryLights_FunctionAddress != IntPtr.Zero && SetSingleSampleShadowFromStationaryLights_bNewSingleSampleShadowFromStationaryLights_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetSingleSampleShadowFromStationaryLights", SetSingleSampleShadowFromStationaryLights_IsValid);
		SetSimulatePhysics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSimulatePhysics");
		SetSimulatePhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSimulatePhysics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSimulatePhysics_bSimulate_PropertyAddress, SetSimulatePhysics_FunctionAddress, "bSimulate");
		SetSimulatePhysics_bSimulate_Offset = NativeReflectionCached.GetPropertyOffset(SetSimulatePhysics_FunctionAddress, "bSimulate");
		SetSimulatePhysics_bSimulate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSimulatePhysics_FunctionAddress, "bSimulate", Classes.FBoolProperty);
		SetSimulatePhysics_IsValid = SetSimulatePhysics_FunctionAddress != IntPtr.Zero && SetSimulatePhysics_bSimulate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetSimulatePhysics", SetSimulatePhysics_IsValid);
		SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScalarParameterForDefaultCustomPrimitiveData");
		SetScalarParameterForDefaultCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_PropertyAddress, SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterForDefaultCustomPrimitiveData_Value_PropertyAddress, SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value");
		SetScalarParameterForDefaultCustomPrimitiveData_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value");
		SetScalarParameterForDefaultCustomPrimitiveData_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress, "Value", Classes.FFloatProperty);
		SetScalarParameterForDefaultCustomPrimitiveData_IsValid = SetScalarParameterForDefaultCustomPrimitiveData_FunctionAddress != IntPtr.Zero && SetScalarParameterForDefaultCustomPrimitiveData_ParameterName_IsValid && SetScalarParameterForDefaultCustomPrimitiveData_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetScalarParameterForDefaultCustomPrimitiveData", SetScalarParameterForDefaultCustomPrimitiveData_IsValid);
		SetScalarParameterForCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScalarParameterForCustomPrimitiveData");
		SetScalarParameterForCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterForCustomPrimitiveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterForCustomPrimitiveData_ParameterName_PropertyAddress, SetScalarParameterForCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetScalarParameterForCustomPrimitiveData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterForCustomPrimitiveData_FunctionAddress, "ParameterName");
		SetScalarParameterForCustomPrimitiveData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterForCustomPrimitiveData_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterForCustomPrimitiveData_Value_PropertyAddress, SetScalarParameterForCustomPrimitiveData_FunctionAddress, "Value");
		SetScalarParameterForCustomPrimitiveData_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterForCustomPrimitiveData_FunctionAddress, "Value");
		SetScalarParameterForCustomPrimitiveData_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterForCustomPrimitiveData_FunctionAddress, "Value", Classes.FFloatProperty);
		SetScalarParameterForCustomPrimitiveData_IsValid = SetScalarParameterForCustomPrimitiveData_FunctionAddress != IntPtr.Zero && SetScalarParameterForCustomPrimitiveData_ParameterName_IsValid && SetScalarParameterForCustomPrimitiveData_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetScalarParameterForCustomPrimitiveData", SetScalarParameterForCustomPrimitiveData_IsValid);
		SetRenderInMainPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderInMainPass");
		SetRenderInMainPass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderInMainPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderInMainPass_bValue_PropertyAddress, SetRenderInMainPass_FunctionAddress, "bValue");
		SetRenderInMainPass_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderInMainPass_FunctionAddress, "bValue");
		SetRenderInMainPass_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderInMainPass_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetRenderInMainPass_IsValid = SetRenderInMainPass_FunctionAddress != IntPtr.Zero && SetRenderInMainPass_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetRenderInMainPass", SetRenderInMainPass_IsValid);
		SetRenderInDepthPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderInDepthPass");
		SetRenderInDepthPass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderInDepthPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderInDepthPass_bValue_PropertyAddress, SetRenderInDepthPass_FunctionAddress, "bValue");
		SetRenderInDepthPass_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderInDepthPass_FunctionAddress, "bValue");
		SetRenderInDepthPass_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderInDepthPass_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetRenderInDepthPass_IsValid = SetRenderInDepthPass_FunctionAddress != IntPtr.Zero && SetRenderInDepthPass_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetRenderInDepthPass", SetRenderInDepthPass_IsValid);
		SetRenderGSVoxelizationPass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderGSVoxelizationPass");
		SetRenderGSVoxelizationPass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderGSVoxelizationPass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderGSVoxelizationPass_bValue_PropertyAddress, SetRenderGSVoxelizationPass_FunctionAddress, "bValue");
		SetRenderGSVoxelizationPass_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderGSVoxelizationPass_FunctionAddress, "bValue");
		SetRenderGSVoxelizationPass_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderGSVoxelizationPass_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetRenderGSVoxelizationPass_IsValid = SetRenderGSVoxelizationPass_FunctionAddress != IntPtr.Zero && SetRenderGSVoxelizationPass_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetRenderGSVoxelizationPass", SetRenderGSVoxelizationPass_IsValid);
		SetRenderCustomDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderCustomDepth");
		SetRenderCustomDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderCustomDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderCustomDepth_bValue_PropertyAddress, SetRenderCustomDepth_FunctionAddress, "bValue");
		SetRenderCustomDepth_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderCustomDepth_FunctionAddress, "bValue");
		SetRenderCustomDepth_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderCustomDepth_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetRenderCustomDepth_IsValid = SetRenderCustomDepth_FunctionAddress != IntPtr.Zero && SetRenderCustomDepth_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetRenderCustomDepth", SetRenderCustomDepth_IsValid);
		SetReceivesDecals_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReceivesDecals");
		SetReceivesDecals_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReceivesDecals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReceivesDecals_bNewReceivesDecals_PropertyAddress, SetReceivesDecals_FunctionAddress, "bNewReceivesDecals");
		SetReceivesDecals_bNewReceivesDecals_Offset = NativeReflectionCached.GetPropertyOffset(SetReceivesDecals_FunctionAddress, "bNewReceivesDecals");
		SetReceivesDecals_bNewReceivesDecals_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReceivesDecals_FunctionAddress, "bNewReceivesDecals", Classes.FBoolProperty);
		SetReceivesDecals_IsValid = SetReceivesDecals_FunctionAddress != IntPtr.Zero && SetReceivesDecals_bNewReceivesDecals_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetReceivesDecals", SetReceivesDecals_IsValid);
		SetPhysMaterialOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysMaterialOverride");
		SetPhysMaterialOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysMaterialOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysMaterialOverride_NewPhysMaterial_PropertyAddress, SetPhysMaterialOverride_FunctionAddress, "NewPhysMaterial");
		SetPhysMaterialOverride_NewPhysMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysMaterialOverride_FunctionAddress, "NewPhysMaterial");
		SetPhysMaterialOverride_NewPhysMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysMaterialOverride_FunctionAddress, "NewPhysMaterial", Classes.FObjectProperty);
		SetPhysMaterialOverride_IsValid = SetPhysMaterialOverride_FunctionAddress != IntPtr.Zero && SetPhysMaterialOverride_NewPhysMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysMaterialOverride", SetPhysMaterialOverride_IsValid);
		SetPhysicsMaxAngularVelocityInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsMaxAngularVelocityInRadians");
		SetPhysicsMaxAngularVelocityInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_PropertyAddress, SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "NewMaxAngVel");
		SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "NewMaxAngVel");
		SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "NewMaxAngVel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_PropertyAddress, SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInRadians_BoneName_PropertyAddress, SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "BoneName");
		SetPhysicsMaxAngularVelocityInRadians_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "BoneName");
		SetPhysicsMaxAngularVelocityInRadians_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInRadians_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetPhysicsMaxAngularVelocityInRadians_IsValid = SetPhysicsMaxAngularVelocityInRadians_FunctionAddress != IntPtr.Zero && SetPhysicsMaxAngularVelocityInRadians_NewMaxAngVel_IsValid && SetPhysicsMaxAngularVelocityInRadians_bAddToCurrent_IsValid && SetPhysicsMaxAngularVelocityInRadians_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInRadians", SetPhysicsMaxAngularVelocityInRadians_IsValid);
		SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsMaxAngularVelocityInDegrees");
		SetPhysicsMaxAngularVelocityInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_PropertyAddress, SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "NewMaxAngVel");
		SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "NewMaxAngVel");
		SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "NewMaxAngVel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_PropertyAddress, SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsMaxAngularVelocityInDegrees_BoneName_PropertyAddress, SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "BoneName");
		SetPhysicsMaxAngularVelocityInDegrees_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "BoneName");
		SetPhysicsMaxAngularVelocityInDegrees_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetPhysicsMaxAngularVelocityInDegrees_IsValid = SetPhysicsMaxAngularVelocityInDegrees_FunctionAddress != IntPtr.Zero && SetPhysicsMaxAngularVelocityInDegrees_NewMaxAngVel_IsValid && SetPhysicsMaxAngularVelocityInDegrees_bAddToCurrent_IsValid && SetPhysicsMaxAngularVelocityInDegrees_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysicsMaxAngularVelocityInDegrees", SetPhysicsMaxAngularVelocityInDegrees_IsValid);
		SetPhysicsLinearVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsLinearVelocity");
		SetPhysicsLinearVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsLinearVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsLinearVelocity_NewVel_PropertyAddress, SetPhysicsLinearVelocity_FunctionAddress, "NewVel");
		SetPhysicsLinearVelocity_NewVel_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsLinearVelocity_FunctionAddress, "NewVel");
		SetPhysicsLinearVelocity_NewVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsLinearVelocity_FunctionAddress, "NewVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsLinearVelocity_bAddToCurrent_PropertyAddress, SetPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent");
		SetPhysicsLinearVelocity_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent");
		SetPhysicsLinearVelocity_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsLinearVelocity_BoneName_PropertyAddress, SetPhysicsLinearVelocity_FunctionAddress, "BoneName");
		SetPhysicsLinearVelocity_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsLinearVelocity_FunctionAddress, "BoneName");
		SetPhysicsLinearVelocity_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsLinearVelocity_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetPhysicsLinearVelocity_IsValid = SetPhysicsLinearVelocity_FunctionAddress != IntPtr.Zero && SetPhysicsLinearVelocity_NewVel_IsValid && SetPhysicsLinearVelocity_bAddToCurrent_IsValid && SetPhysicsLinearVelocity_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysicsLinearVelocity", SetPhysicsLinearVelocity_IsValid);
		SetPhysicsAngularVelocityInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsAngularVelocityInRadians");
		SetPhysicsAngularVelocityInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsAngularVelocityInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress, SetPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel");
		SetPhysicsAngularVelocityInRadians_NewAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel");
		SetPhysicsAngularVelocityInRadians_NewAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress, SetPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetPhysicsAngularVelocityInRadians_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress, SetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName");
		SetPhysicsAngularVelocityInRadians_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName");
		SetPhysicsAngularVelocityInRadians_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetPhysicsAngularVelocityInRadians_IsValid = SetPhysicsAngularVelocityInRadians_FunctionAddress != IntPtr.Zero && SetPhysicsAngularVelocityInRadians_NewAngVel_IsValid && SetPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid && SetPhysicsAngularVelocityInRadians_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInRadians", SetPhysicsAngularVelocityInRadians_IsValid);
		SetPhysicsAngularVelocityInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsAngularVelocityInDegrees");
		SetPhysicsAngularVelocityInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsAngularVelocityInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress, SetPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel");
		SetPhysicsAngularVelocityInDegrees_NewAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel");
		SetPhysicsAngularVelocityInDegrees_NewAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress, SetPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress, SetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName");
		SetPhysicsAngularVelocityInDegrees_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName");
		SetPhysicsAngularVelocityInDegrees_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetPhysicsAngularVelocityInDegrees_IsValid = SetPhysicsAngularVelocityInDegrees_FunctionAddress != IntPtr.Zero && SetPhysicsAngularVelocityInDegrees_NewAngVel_IsValid && SetPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid && SetPhysicsAngularVelocityInDegrees_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetPhysicsAngularVelocityInDegrees", SetPhysicsAngularVelocityInDegrees_IsValid);
		SetOwnerNoSee_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOwnerNoSee");
		SetOwnerNoSee_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOwnerNoSee_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOwnerNoSee_bNewOwnerNoSee_PropertyAddress, SetOwnerNoSee_FunctionAddress, "bNewOwnerNoSee");
		SetOwnerNoSee_bNewOwnerNoSee_Offset = NativeReflectionCached.GetPropertyOffset(SetOwnerNoSee_FunctionAddress, "bNewOwnerNoSee");
		SetOwnerNoSee_bNewOwnerNoSee_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOwnerNoSee_FunctionAddress, "bNewOwnerNoSee", Classes.FBoolProperty);
		SetOwnerNoSee_IsValid = SetOwnerNoSee_FunctionAddress != IntPtr.Zero && SetOwnerNoSee_bNewOwnerNoSee_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetOwnerNoSee", SetOwnerNoSee_IsValid);
		SetOnlyOwnerSee_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOnlyOwnerSee");
		SetOnlyOwnerSee_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOnlyOwnerSee_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOnlyOwnerSee_bNewOnlyOwnerSee_PropertyAddress, SetOnlyOwnerSee_FunctionAddress, "bNewOnlyOwnerSee");
		SetOnlyOwnerSee_bNewOnlyOwnerSee_Offset = NativeReflectionCached.GetPropertyOffset(SetOnlyOwnerSee_FunctionAddress, "bNewOnlyOwnerSee");
		SetOnlyOwnerSee_bNewOnlyOwnerSee_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOnlyOwnerSee_FunctionAddress, "bNewOnlyOwnerSee", Classes.FBoolProperty);
		SetOnlyOwnerSee_IsValid = SetOnlyOwnerSee_FunctionAddress != IntPtr.Zero && SetOnlyOwnerSee_bNewOnlyOwnerSee_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetOnlyOwnerSee", SetOnlyOwnerSee_IsValid);
		SetNotifyRigidBodyCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNotifyRigidBodyCollision");
		SetNotifyRigidBodyCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNotifyRigidBodyCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_PropertyAddress, SetNotifyRigidBodyCollision_FunctionAddress, "bNewNotifyRigidBodyCollision");
		SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetNotifyRigidBodyCollision_FunctionAddress, "bNewNotifyRigidBodyCollision");
		SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNotifyRigidBodyCollision_FunctionAddress, "bNewNotifyRigidBodyCollision", Classes.FBoolProperty);
		SetNotifyRigidBodyCollision_IsValid = SetNotifyRigidBodyCollision_FunctionAddress != IntPtr.Zero && SetNotifyRigidBodyCollision_bNewNotifyRigidBodyCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetNotifyRigidBodyCollision", SetNotifyRigidBodyCollision_IsValid);
		SetMaterialByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaterialByName");
		SetMaterialByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterialByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialByName_MaterialSlotName_PropertyAddress, SetMaterialByName_FunctionAddress, "MaterialSlotName");
		SetMaterialByName_MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialByName_FunctionAddress, "MaterialSlotName");
		SetMaterialByName_MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialByName_FunctionAddress, "MaterialSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterialByName_Material_PropertyAddress, SetMaterialByName_FunctionAddress, "Material");
		SetMaterialByName_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterialByName_FunctionAddress, "Material");
		SetMaterialByName_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterialByName_FunctionAddress, "Material", Classes.FObjectProperty);
		SetMaterialByName_IsValid = SetMaterialByName_FunctionAddress != IntPtr.Zero && SetMaterialByName_MaterialSlotName_IsValid && SetMaterialByName_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetMaterialByName", SetMaterialByName_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_ElementIndex_PropertyAddress, SetMaterial_FunctionAddress, "ElementIndex");
		SetMaterial_ElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "ElementIndex");
		SetMaterial_ElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "ElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Material_PropertyAddress, SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_ElementIndex_IsValid && SetMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetMaterial", SetMaterial_IsValid);
		SetMassScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMassScale");
		SetMassScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMassScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMassScale_BoneName_PropertyAddress, SetMassScale_FunctionAddress, "BoneName");
		SetMassScale_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetMassScale_FunctionAddress, "BoneName");
		SetMassScale_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMassScale_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMassScale_InMassScale_PropertyAddress, SetMassScale_FunctionAddress, "InMassScale");
		SetMassScale_InMassScale_Offset = NativeReflectionCached.GetPropertyOffset(SetMassScale_FunctionAddress, "InMassScale");
		SetMassScale_InMassScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMassScale_FunctionAddress, "InMassScale", Classes.FFloatProperty);
		SetMassScale_IsValid = SetMassScale_FunctionAddress != IntPtr.Zero && SetMassScale_BoneName_IsValid && SetMassScale_InMassScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetMassScale", SetMassScale_IsValid);
		SetMassOverrideInKg_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMassOverrideInKg");
		SetMassOverrideInKg_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMassOverrideInKg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMassOverrideInKg_BoneName_PropertyAddress, SetMassOverrideInKg_FunctionAddress, "BoneName");
		SetMassOverrideInKg_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetMassOverrideInKg_FunctionAddress, "BoneName");
		SetMassOverrideInKg_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMassOverrideInKg_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMassOverrideInKg_MassInKg_PropertyAddress, SetMassOverrideInKg_FunctionAddress, "MassInKg");
		SetMassOverrideInKg_MassInKg_Offset = NativeReflectionCached.GetPropertyOffset(SetMassOverrideInKg_FunctionAddress, "MassInKg");
		SetMassOverrideInKg_MassInKg_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMassOverrideInKg_FunctionAddress, "MassInKg", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMassOverrideInKg_bOverrideMass_PropertyAddress, SetMassOverrideInKg_FunctionAddress, "bOverrideMass");
		SetMassOverrideInKg_bOverrideMass_Offset = NativeReflectionCached.GetPropertyOffset(SetMassOverrideInKg_FunctionAddress, "bOverrideMass");
		SetMassOverrideInKg_bOverrideMass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMassOverrideInKg_FunctionAddress, "bOverrideMass", Classes.FBoolProperty);
		SetMassOverrideInKg_IsValid = SetMassOverrideInKg_FunctionAddress != IntPtr.Zero && SetMassOverrideInKg_BoneName_IsValid && SetMassOverrideInKg_MassInKg_IsValid && SetMassOverrideInKg_bOverrideMass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetMassOverrideInKg", SetMassOverrideInKg_IsValid);
		SetLinearDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearDamping");
		SetLinearDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDamping_InDamping_PropertyAddress, SetLinearDamping_FunctionAddress, "InDamping");
		SetLinearDamping_InDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDamping_FunctionAddress, "InDamping");
		SetLinearDamping_InDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDamping_FunctionAddress, "InDamping", Classes.FFloatProperty);
		SetLinearDamping_IsValid = SetLinearDamping_FunctionAddress != IntPtr.Zero && SetLinearDamping_InDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetLinearDamping", SetLinearDamping_IsValid);
		SetLightingChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightingChannels");
		SetLightingChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightingChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel0_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel0");
		SetLightingChannels_bChannel0_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel0");
		SetLightingChannels_bChannel0_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel0", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel1_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel1");
		SetLightingChannels_bChannel1_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel1");
		SetLightingChannels_bChannel1_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel1", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel2_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel2");
		SetLightingChannels_bChannel2_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel2");
		SetLightingChannels_bChannel2_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel2", Classes.FBoolProperty);
		SetLightingChannels_IsValid = SetLightingChannels_FunctionAddress != IntPtr.Zero && SetLightingChannels_bChannel0_IsValid && SetLightingChannels_bChannel1_IsValid && SetLightingChannels_bChannel2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetLightingChannels", SetLightingChannels_IsValid);
		SetLightAttachmentsAsGroup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightAttachmentsAsGroup");
		SetLightAttachmentsAsGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightAttachmentsAsGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_PropertyAddress, SetLightAttachmentsAsGroup_FunctionAddress, "bInLightAttachmentsAsGroup");
		SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetLightAttachmentsAsGroup_FunctionAddress, "bInLightAttachmentsAsGroup");
		SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightAttachmentsAsGroup_FunctionAddress, "bInLightAttachmentsAsGroup", Classes.FBoolProperty);
		SetLightAttachmentsAsGroup_IsValid = SetLightAttachmentsAsGroup_FunctionAddress != IntPtr.Zero && SetLightAttachmentsAsGroup_bInLightAttachmentsAsGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetLightAttachmentsAsGroup", SetLightAttachmentsAsGroup_IsValid);
		SetHiddenInSceneCapture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHiddenInSceneCapture");
		SetHiddenInSceneCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHiddenInSceneCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHiddenInSceneCapture_bValue_PropertyAddress, SetHiddenInSceneCapture_FunctionAddress, "bValue");
		SetHiddenInSceneCapture_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetHiddenInSceneCapture_FunctionAddress, "bValue");
		SetHiddenInSceneCapture_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHiddenInSceneCapture_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetHiddenInSceneCapture_IsValid = SetHiddenInSceneCapture_FunctionAddress != IntPtr.Zero && SetHiddenInSceneCapture_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetHiddenInSceneCapture", SetHiddenInSceneCapture_IsValid);
		SetGenerateOverlapEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGenerateOverlapEvents");
		SetGenerateOverlapEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGenerateOverlapEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGenerateOverlapEvents_bInGenerateOverlapEvents_PropertyAddress, SetGenerateOverlapEvents_FunctionAddress, "bInGenerateOverlapEvents");
		SetGenerateOverlapEvents_bInGenerateOverlapEvents_Offset = NativeReflectionCached.GetPropertyOffset(SetGenerateOverlapEvents_FunctionAddress, "bInGenerateOverlapEvents");
		SetGenerateOverlapEvents_bInGenerateOverlapEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGenerateOverlapEvents_FunctionAddress, "bInGenerateOverlapEvents", Classes.FBoolProperty);
		SetGenerateOverlapEvents_IsValid = SetGenerateOverlapEvents_FunctionAddress != IntPtr.Zero && SetGenerateOverlapEvents_bInGenerateOverlapEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetGenerateOverlapEvents", SetGenerateOverlapEvents_IsValid);
		SetExcludeFromLightAttachmentGroup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetExcludeFromLightAttachmentGroup");
		SetExcludeFromLightAttachmentGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExcludeFromLightAttachmentGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_PropertyAddress, SetExcludeFromLightAttachmentGroup_FunctionAddress, "bInExcludeFromLightAttachmentGroup");
		SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetExcludeFromLightAttachmentGroup_FunctionAddress, "bInExcludeFromLightAttachmentGroup");
		SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExcludeFromLightAttachmentGroup_FunctionAddress, "bInExcludeFromLightAttachmentGroup", Classes.FBoolProperty);
		SetExcludeFromLightAttachmentGroup_IsValid = SetExcludeFromLightAttachmentGroup_FunctionAddress != IntPtr.Zero && SetExcludeFromLightAttachmentGroup_bInExcludeFromLightAttachmentGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetExcludeFromLightAttachmentGroup", SetExcludeFromLightAttachmentGroup_IsValid);
		SetEnableGravity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableGravity");
		SetEnableGravity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableGravity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableGravity_bGravityEnabled_PropertyAddress, SetEnableGravity_FunctionAddress, "bGravityEnabled");
		SetEnableGravity_bGravityEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableGravity_FunctionAddress, "bGravityEnabled");
		SetEnableGravity_bGravityEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableGravity_FunctionAddress, "bGravityEnabled", Classes.FBoolProperty);
		SetEnableGravity_IsValid = SetEnableGravity_FunctionAddress != IntPtr.Zero && SetEnableGravity_bGravityEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetEnableGravity", SetEnableGravity_IsValid);
		SetEmissiveLightSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEmissiveLightSource");
		SetEmissiveLightSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEmissiveLightSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEmissiveLightSource_NewEmissiveLightSource_PropertyAddress, SetEmissiveLightSource_FunctionAddress, "NewEmissiveLightSource");
		SetEmissiveLightSource_NewEmissiveLightSource_Offset = NativeReflectionCached.GetPropertyOffset(SetEmissiveLightSource_FunctionAddress, "NewEmissiveLightSource");
		SetEmissiveLightSource_NewEmissiveLightSource_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEmissiveLightSource_FunctionAddress, "NewEmissiveLightSource", Classes.FBoolProperty);
		SetEmissiveLightSource_IsValid = SetEmissiveLightSource_FunctionAddress != IntPtr.Zero && SetEmissiveLightSource_NewEmissiveLightSource_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetEmissiveLightSource", SetEmissiveLightSource_IsValid);
		SetDefaultCustomPrimitiveDataVector4_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultCustomPrimitiveDataVector4");
		SetDefaultCustomPrimitiveDataVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultCustomPrimitiveDataVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector4_DataIndex_PropertyAddress, SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector4_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector4_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector4_Value_PropertyAddress, SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector4_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector4_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector4_FunctionAddress, "Value", Classes.FStructProperty);
		SetDefaultCustomPrimitiveDataVector4_IsValid = SetDefaultCustomPrimitiveDataVector4_FunctionAddress != IntPtr.Zero && SetDefaultCustomPrimitiveDataVector4_DataIndex_IsValid && SetDefaultCustomPrimitiveDataVector4_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector4", SetDefaultCustomPrimitiveDataVector4_IsValid);
		SetDefaultCustomPrimitiveDataVector3_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultCustomPrimitiveDataVector3");
		SetDefaultCustomPrimitiveDataVector3_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultCustomPrimitiveDataVector3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector3_DataIndex_PropertyAddress, SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector3_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector3_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector3_Value_PropertyAddress, SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector3_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector3_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector3_FunctionAddress, "Value", Classes.FStructProperty);
		SetDefaultCustomPrimitiveDataVector3_IsValid = SetDefaultCustomPrimitiveDataVector3_FunctionAddress != IntPtr.Zero && SetDefaultCustomPrimitiveDataVector3_DataIndex_IsValid && SetDefaultCustomPrimitiveDataVector3_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector3", SetDefaultCustomPrimitiveDataVector3_IsValid);
		SetDefaultCustomPrimitiveDataVector2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultCustomPrimitiveDataVector2");
		SetDefaultCustomPrimitiveDataVector2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultCustomPrimitiveDataVector2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector2_DataIndex_PropertyAddress, SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector2_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataVector2_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataVector2_Value_PropertyAddress, SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector2_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataVector2_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataVector2_FunctionAddress, "Value", Classes.FStructProperty);
		SetDefaultCustomPrimitiveDataVector2_IsValid = SetDefaultCustomPrimitiveDataVector2_FunctionAddress != IntPtr.Zero && SetDefaultCustomPrimitiveDataVector2_DataIndex_IsValid && SetDefaultCustomPrimitiveDataVector2_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataVector2", SetDefaultCustomPrimitiveDataVector2_IsValid);
		SetDefaultCustomPrimitiveDataFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultCustomPrimitiveDataFloat");
		SetDefaultCustomPrimitiveDataFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultCustomPrimitiveDataFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataFloat_DataIndex_PropertyAddress, SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataFloat_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "DataIndex");
		SetDefaultCustomPrimitiveDataFloat_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultCustomPrimitiveDataFloat_Value_PropertyAddress, SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "Value");
		SetDefaultCustomPrimitiveDataFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultCustomPrimitiveDataFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		SetDefaultCustomPrimitiveDataFloat_IsValid = SetDefaultCustomPrimitiveDataFloat_FunctionAddress != IntPtr.Zero && SetDefaultCustomPrimitiveDataFloat_DataIndex_IsValid && SetDefaultCustomPrimitiveDataFloat_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetDefaultCustomPrimitiveDataFloat", SetDefaultCustomPrimitiveDataFloat_IsValid);
		SetCustomPrimitiveDataVector4_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomPrimitiveDataVector4");
		SetCustomPrimitiveDataVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPrimitiveDataVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector4_DataIndex_PropertyAddress, SetCustomPrimitiveDataVector4_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector4_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector4_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector4_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector4_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector4_Value_PropertyAddress, SetCustomPrimitiveDataVector4_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector4_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector4_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector4_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector4_FunctionAddress, "Value", Classes.FStructProperty);
		SetCustomPrimitiveDataVector4_IsValid = SetCustomPrimitiveDataVector4_FunctionAddress != IntPtr.Zero && SetCustomPrimitiveDataVector4_DataIndex_IsValid && SetCustomPrimitiveDataVector4_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector4", SetCustomPrimitiveDataVector4_IsValid);
		SetCustomPrimitiveDataVector3_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomPrimitiveDataVector3");
		SetCustomPrimitiveDataVector3_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPrimitiveDataVector3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector3_DataIndex_PropertyAddress, SetCustomPrimitiveDataVector3_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector3_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector3_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector3_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector3_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector3_Value_PropertyAddress, SetCustomPrimitiveDataVector3_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector3_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector3_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector3_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector3_FunctionAddress, "Value", Classes.FStructProperty);
		SetCustomPrimitiveDataVector3_IsValid = SetCustomPrimitiveDataVector3_FunctionAddress != IntPtr.Zero && SetCustomPrimitiveDataVector3_DataIndex_IsValid && SetCustomPrimitiveDataVector3_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector3", SetCustomPrimitiveDataVector3_IsValid);
		SetCustomPrimitiveDataVector2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomPrimitiveDataVector2");
		SetCustomPrimitiveDataVector2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPrimitiveDataVector2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector2_DataIndex_PropertyAddress, SetCustomPrimitiveDataVector2_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector2_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector2_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataVector2_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector2_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataVector2_Value_PropertyAddress, SetCustomPrimitiveDataVector2_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector2_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataVector2_FunctionAddress, "Value");
		SetCustomPrimitiveDataVector2_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataVector2_FunctionAddress, "Value", Classes.FStructProperty);
		SetCustomPrimitiveDataVector2_IsValid = SetCustomPrimitiveDataVector2_FunctionAddress != IntPtr.Zero && SetCustomPrimitiveDataVector2_DataIndex_IsValid && SetCustomPrimitiveDataVector2_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataVector2", SetCustomPrimitiveDataVector2_IsValid);
		SetCustomPrimitiveDataFloat_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomPrimitiveDataFloat");
		SetCustomPrimitiveDataFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPrimitiveDataFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataFloat_DataIndex_PropertyAddress, SetCustomPrimitiveDataFloat_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataFloat_DataIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataFloat_FunctionAddress, "DataIndex");
		SetCustomPrimitiveDataFloat_DataIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataFloat_FunctionAddress, "DataIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPrimitiveDataFloat_Value_PropertyAddress, SetCustomPrimitiveDataFloat_FunctionAddress, "Value");
		SetCustomPrimitiveDataFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPrimitiveDataFloat_FunctionAddress, "Value");
		SetCustomPrimitiveDataFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPrimitiveDataFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		SetCustomPrimitiveDataFloat_IsValid = SetCustomPrimitiveDataFloat_FunctionAddress != IntPtr.Zero && SetCustomPrimitiveDataFloat_DataIndex_IsValid && SetCustomPrimitiveDataFloat_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomPrimitiveDataFloat", SetCustomPrimitiveDataFloat_IsValid);
		SetCustomDepthStencilWriteMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomDepthStencilWriteMask");
		SetCustomDepthStencilWriteMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomDepthStencilWriteMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDepthStencilWriteMask_WriteMaskBit_PropertyAddress, SetCustomDepthStencilWriteMask_FunctionAddress, "WriteMaskBit");
		SetCustomDepthStencilWriteMask_WriteMaskBit_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDepthStencilWriteMask_FunctionAddress, "WriteMaskBit");
		SetCustomDepthStencilWriteMask_WriteMaskBit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDepthStencilWriteMask_FunctionAddress, "WriteMaskBit", Classes.FEnumProperty);
		SetCustomDepthStencilWriteMask_IsValid = SetCustomDepthStencilWriteMask_FunctionAddress != IntPtr.Zero && SetCustomDepthStencilWriteMask_WriteMaskBit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilWriteMask", SetCustomDepthStencilWriteMask_IsValid);
		SetCustomDepthStencilValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomDepthStencilValue");
		SetCustomDepthStencilValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomDepthStencilValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomDepthStencilValue_Value_PropertyAddress, SetCustomDepthStencilValue_FunctionAddress, "Value");
		SetCustomDepthStencilValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomDepthStencilValue_FunctionAddress, "Value");
		SetCustomDepthStencilValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomDepthStencilValue_FunctionAddress, "Value", Classes.FIntProperty);
		SetCustomDepthStencilValue_IsValid = SetCustomDepthStencilValue_FunctionAddress != IntPtr.Zero && SetCustomDepthStencilValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCustomDepthStencilValue", SetCustomDepthStencilValue_IsValid);
		SetCullDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCullDistance");
		SetCullDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCullDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCullDistance_NewCullDistance_PropertyAddress, SetCullDistance_FunctionAddress, "NewCullDistance");
		SetCullDistance_NewCullDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetCullDistance_FunctionAddress, "NewCullDistance");
		SetCullDistance_NewCullDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCullDistance_FunctionAddress, "NewCullDistance", Classes.FFloatProperty);
		SetCullDistance_IsValid = SetCullDistance_FunctionAddress != IntPtr.Zero && SetCullDistance_NewCullDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCullDistance", SetCullDistance_IsValid);
		SetConstraintMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstraintMode");
		SetConstraintMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintMode_ConstraintMode_PropertyAddress, SetConstraintMode_FunctionAddress, "ConstraintMode");
		SetConstraintMode_ConstraintMode_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintMode_FunctionAddress, "ConstraintMode");
		SetConstraintMode_ConstraintMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintMode_FunctionAddress, "ConstraintMode", Classes.FByteProperty);
		SetConstraintMode_IsValid = SetConstraintMode_FunctionAddress != IntPtr.Zero && SetConstraintMode_ConstraintMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetConstraintMode", SetConstraintMode_IsValid);
		SetCollisionResponseToChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToChannel");
		SetCollisionResponseToChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_Channel_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "Channel");
		SetCollisionResponseToChannel_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "Channel");
		SetCollisionResponseToChannel_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToChannel_NewResponse_PropertyAddress, SetCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannel_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToChannel_FunctionAddress, "NewResponse");
		SetCollisionResponseToChannel_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToChannel_FunctionAddress, "NewResponse", Classes.FByteProperty);
		SetCollisionResponseToChannel_IsValid = SetCollisionResponseToChannel_FunctionAddress != IntPtr.Zero && SetCollisionResponseToChannel_Channel_IsValid && SetCollisionResponseToChannel_NewResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCollisionResponseToChannel", SetCollisionResponseToChannel_IsValid);
		SetCollisionResponseToAllChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionResponseToAllChannels");
		SetCollisionResponseToAllChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionResponseToAllChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionResponseToAllChannels_NewResponse_PropertyAddress, SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannels_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse");
		SetCollisionResponseToAllChannels_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionResponseToAllChannels_FunctionAddress, "NewResponse", Classes.FByteProperty);
		SetCollisionResponseToAllChannels_IsValid = SetCollisionResponseToAllChannels_FunctionAddress != IntPtr.Zero && SetCollisionResponseToAllChannels_NewResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCollisionResponseToAllChannels", SetCollisionResponseToAllChannels_IsValid);
		SetCollisionProfileName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionProfileName");
		SetCollisionProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionProfileName_InCollisionProfileName_PropertyAddress, SetCollisionProfileName_FunctionAddress, "InCollisionProfileName");
		SetCollisionProfileName_InCollisionProfileName_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionProfileName_FunctionAddress, "InCollisionProfileName");
		SetCollisionProfileName_InCollisionProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionProfileName_FunctionAddress, "InCollisionProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionProfileName_bUpdateOverlaps_PropertyAddress, SetCollisionProfileName_FunctionAddress, "bUpdateOverlaps");
		SetCollisionProfileName_bUpdateOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionProfileName_FunctionAddress, "bUpdateOverlaps");
		SetCollisionProfileName_bUpdateOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionProfileName_FunctionAddress, "bUpdateOverlaps", Classes.FBoolProperty);
		SetCollisionProfileName_IsValid = SetCollisionProfileName_FunctionAddress != IntPtr.Zero && SetCollisionProfileName_InCollisionProfileName_IsValid && SetCollisionProfileName_bUpdateOverlaps_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCollisionProfileName", SetCollisionProfileName_IsValid);
		SetCollisionObjectType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionObjectType");
		SetCollisionObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionObjectType_Channel_PropertyAddress, SetCollisionObjectType_FunctionAddress, "Channel");
		SetCollisionObjectType_Channel_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionObjectType_FunctionAddress, "Channel");
		SetCollisionObjectType_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionObjectType_FunctionAddress, "Channel", Classes.FByteProperty);
		SetCollisionObjectType_IsValid = SetCollisionObjectType_FunctionAddress != IntPtr.Zero && SetCollisionObjectType_Channel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCollisionObjectType", SetCollisionObjectType_IsValid);
		SetCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCollisionEnabled");
		SetCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnabled_NewType_PropertyAddress, SetCollisionEnabled_FunctionAddress, "NewType");
		SetCollisionEnabled_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnabled_FunctionAddress, "NewType");
		SetCollisionEnabled_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnabled_FunctionAddress, "NewType", Classes.FByteProperty);
		SetCollisionEnabled_IsValid = SetCollisionEnabled_FunctionAddress != IntPtr.Zero && SetCollisionEnabled_NewType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCollisionEnabled", SetCollisionEnabled_IsValid);
		SetCenterOfMass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCenterOfMass");
		SetCenterOfMass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCenterOfMass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCenterOfMass_CenterOfMassOffset_PropertyAddress, SetCenterOfMass_FunctionAddress, "CenterOfMassOffset");
		SetCenterOfMass_CenterOfMassOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetCenterOfMass_FunctionAddress, "CenterOfMassOffset");
		SetCenterOfMass_CenterOfMassOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCenterOfMass_FunctionAddress, "CenterOfMassOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCenterOfMass_BoneName_PropertyAddress, SetCenterOfMass_FunctionAddress, "BoneName");
		SetCenterOfMass_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetCenterOfMass_FunctionAddress, "BoneName");
		SetCenterOfMass_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCenterOfMass_FunctionAddress, "BoneName", Classes.FNameProperty);
		SetCenterOfMass_IsValid = SetCenterOfMass_FunctionAddress != IntPtr.Zero && SetCenterOfMass_CenterOfMassOffset_IsValid && SetCenterOfMass_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCenterOfMass", SetCenterOfMass_IsValid);
		SetCastShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastShadow");
		SetCastShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastShadow_NewCastShadow_PropertyAddress, SetCastShadow_FunctionAddress, "NewCastShadow");
		SetCastShadow_NewCastShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastShadow_FunctionAddress, "NewCastShadow");
		SetCastShadow_NewCastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastShadow_FunctionAddress, "NewCastShadow", Classes.FBoolProperty);
		SetCastShadow_IsValid = SetCastShadow_FunctionAddress != IntPtr.Zero && SetCastShadow_NewCastShadow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCastShadow", SetCastShadow_IsValid);
		SetCastInsetShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastInsetShadow");
		SetCastInsetShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastInsetShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastInsetShadow_bInCastInsetShadow_PropertyAddress, SetCastInsetShadow_FunctionAddress, "bInCastInsetShadow");
		SetCastInsetShadow_bInCastInsetShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastInsetShadow_FunctionAddress, "bInCastInsetShadow");
		SetCastInsetShadow_bInCastInsetShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastInsetShadow_FunctionAddress, "bInCastInsetShadow", Classes.FBoolProperty);
		SetCastInsetShadow_IsValid = SetCastInsetShadow_FunctionAddress != IntPtr.Zero && SetCastInsetShadow_bInCastInsetShadow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCastInsetShadow", SetCastInsetShadow_IsValid);
		SetCastHybridRayTracingShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastHybridRayTracingShadow");
		SetCastHybridRayTracingShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastHybridRayTracingShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_PropertyAddress, SetCastHybridRayTracingShadow_FunctionAddress, "bNewHybridRayTracingShadow");
		SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastHybridRayTracingShadow_FunctionAddress, "bNewHybridRayTracingShadow");
		SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastHybridRayTracingShadow_FunctionAddress, "bNewHybridRayTracingShadow", Classes.FBoolProperty);
		SetCastHybridRayTracingShadow_IsValid = SetCastHybridRayTracingShadow_FunctionAddress != IntPtr.Zero && SetCastHybridRayTracingShadow_bNewHybridRayTracingShadow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCastHybridRayTracingShadow", SetCastHybridRayTracingShadow_IsValid);
		SetCastHiddenShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastHiddenShadow");
		SetCastHiddenShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastHiddenShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastHiddenShadow_NewCastHiddenShadow_PropertyAddress, SetCastHiddenShadow_FunctionAddress, "NewCastHiddenShadow");
		SetCastHiddenShadow_NewCastHiddenShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastHiddenShadow_FunctionAddress, "NewCastHiddenShadow");
		SetCastHiddenShadow_NewCastHiddenShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastHiddenShadow_FunctionAddress, "NewCastHiddenShadow", Classes.FBoolProperty);
		SetCastHiddenShadow_IsValid = SetCastHiddenShadow_FunctionAddress != IntPtr.Zero && SetCastHiddenShadow_NewCastHiddenShadow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCastHiddenShadow", SetCastHiddenShadow_IsValid);
		SetCastContactShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastContactShadow");
		SetCastContactShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastContactShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastContactShadow_bInCastContactShadow_PropertyAddress, SetCastContactShadow_FunctionAddress, "bInCastContactShadow");
		SetCastContactShadow_bInCastContactShadow_Offset = NativeReflectionCached.GetPropertyOffset(SetCastContactShadow_FunctionAddress, "bInCastContactShadow");
		SetCastContactShadow_bInCastContactShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastContactShadow_FunctionAddress, "bInCastContactShadow", Classes.FBoolProperty);
		SetCastContactShadow_IsValid = SetCastContactShadow_FunctionAddress != IntPtr.Zero && SetCastContactShadow_bInCastContactShadow_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetCastContactShadow", SetCastContactShadow_IsValid);
		SetBoundsScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoundsScale");
		SetBoundsScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoundsScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoundsScale_NewBoundsScale_PropertyAddress, SetBoundsScale_FunctionAddress, "NewBoundsScale");
		SetBoundsScale_NewBoundsScale_Offset = NativeReflectionCached.GetPropertyOffset(SetBoundsScale_FunctionAddress, "NewBoundsScale");
		SetBoundsScale_NewBoundsScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoundsScale_FunctionAddress, "NewBoundsScale", Classes.FFloatProperty);
		SetBoundsScale_IsValid = SetBoundsScale_FunctionAddress != IntPtr.Zero && SetBoundsScale_NewBoundsScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetBoundsScale", SetBoundsScale_IsValid);
		SetAngularDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularDamping");
		SetAngularDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDamping_InDamping_PropertyAddress, SetAngularDamping_FunctionAddress, "InDamping");
		SetAngularDamping_InDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDamping_FunctionAddress, "InDamping");
		SetAngularDamping_InDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDamping_FunctionAddress, "InDamping", Classes.FFloatProperty);
		SetAngularDamping_IsValid = SetAngularDamping_FunctionAddress != IntPtr.Zero && SetAngularDamping_InDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAngularDamping", SetAngularDamping_IsValid);
		SetAllUseCCD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllUseCCD");
		SetAllUseCCD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllUseCCD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllUseCCD_InUseCCD_PropertyAddress, SetAllUseCCD_FunctionAddress, "InUseCCD");
		SetAllUseCCD_InUseCCD_Offset = NativeReflectionCached.GetPropertyOffset(SetAllUseCCD_FunctionAddress, "InUseCCD");
		SetAllUseCCD_InUseCCD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllUseCCD_FunctionAddress, "InUseCCD", Classes.FBoolProperty);
		SetAllUseCCD_IsValid = SetAllUseCCD_FunctionAddress != IntPtr.Zero && SetAllUseCCD_InUseCCD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAllUseCCD", SetAllUseCCD_IsValid);
		SetAllPhysicsLinearVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllPhysicsLinearVelocity");
		SetAllPhysicsLinearVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPhysicsLinearVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsLinearVelocity_NewVel_PropertyAddress, SetAllPhysicsLinearVelocity_FunctionAddress, "NewVel");
		SetAllPhysicsLinearVelocity_NewVel_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsLinearVelocity_FunctionAddress, "NewVel");
		SetAllPhysicsLinearVelocity_NewVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsLinearVelocity_FunctionAddress, "NewVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsLinearVelocity_bAddToCurrent_PropertyAddress, SetAllPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsLinearVelocity_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsLinearVelocity_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsLinearVelocity_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		SetAllPhysicsLinearVelocity_IsValid = SetAllPhysicsLinearVelocity_FunctionAddress != IntPtr.Zero && SetAllPhysicsLinearVelocity_NewVel_IsValid && SetAllPhysicsLinearVelocity_bAddToCurrent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAllPhysicsLinearVelocity", SetAllPhysicsLinearVelocity_IsValid);
		SetAllPhysicsAngularVelocityInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllPhysicsAngularVelocityInRadians");
		SetAllPhysicsAngularVelocityInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPhysicsAngularVelocityInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsAngularVelocityInRadians_NewAngVel_PropertyAddress, SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel");
		SetAllPhysicsAngularVelocityInRadians_NewAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel");
		SetAllPhysicsAngularVelocityInRadians_NewAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "NewAngVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_PropertyAddress, SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsAngularVelocityInRadians_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		SetAllPhysicsAngularVelocityInRadians_IsValid = SetAllPhysicsAngularVelocityInRadians_FunctionAddress != IntPtr.Zero && SetAllPhysicsAngularVelocityInRadians_NewAngVel_IsValid && SetAllPhysicsAngularVelocityInRadians_bAddToCurrent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInRadians", SetAllPhysicsAngularVelocityInRadians_IsValid);
		SetAllPhysicsAngularVelocityInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllPhysicsAngularVelocityInDegrees");
		SetAllPhysicsAngularVelocityInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPhysicsAngularVelocityInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsAngularVelocityInDegrees_NewAngVel_PropertyAddress, SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel");
		SetAllPhysicsAngularVelocityInDegrees_NewAngVel_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel");
		SetAllPhysicsAngularVelocityInDegrees_NewAngVel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "NewAngVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_PropertyAddress, SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent");
		SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPhysicsAngularVelocityInDegrees_FunctionAddress, "bAddToCurrent", Classes.FBoolProperty);
		SetAllPhysicsAngularVelocityInDegrees_IsValid = SetAllPhysicsAngularVelocityInDegrees_FunctionAddress != IntPtr.Zero && SetAllPhysicsAngularVelocityInDegrees_NewAngVel_IsValid && SetAllPhysicsAngularVelocityInDegrees_bAddToCurrent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAllPhysicsAngularVelocityInDegrees", SetAllPhysicsAngularVelocityInDegrees_IsValid);
		SetAllMassScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllMassScale");
		SetAllMassScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllMassScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllMassScale_InMassScale_PropertyAddress, SetAllMassScale_FunctionAddress, "InMassScale");
		SetAllMassScale_InMassScale_Offset = NativeReflectionCached.GetPropertyOffset(SetAllMassScale_FunctionAddress, "InMassScale");
		SetAllMassScale_InMassScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllMassScale_FunctionAddress, "InMassScale", Classes.FFloatProperty);
		SetAllMassScale_IsValid = SetAllMassScale_FunctionAddress != IntPtr.Zero && SetAllMassScale_InMassScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:SetAllMassScale", SetAllMassScale_IsValid);
		ScaleByMomentOfInertia_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScaleByMomentOfInertia");
		ScaleByMomentOfInertia_ParamsSize = NativeReflection.GetFunctionParamsSize(ScaleByMomentOfInertia_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScaleByMomentOfInertia_InputVector_PropertyAddress, ScaleByMomentOfInertia_FunctionAddress, "InputVector");
		ScaleByMomentOfInertia_InputVector_Offset = NativeReflectionCached.GetPropertyOffset(ScaleByMomentOfInertia_FunctionAddress, "InputVector");
		ScaleByMomentOfInertia_InputVector_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleByMomentOfInertia_FunctionAddress, "InputVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleByMomentOfInertia_BoneName_PropertyAddress, ScaleByMomentOfInertia_FunctionAddress, "BoneName");
		ScaleByMomentOfInertia_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(ScaleByMomentOfInertia_FunctionAddress, "BoneName");
		ScaleByMomentOfInertia_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleByMomentOfInertia_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleByMomentOfInertia_ReturnValue_PropertyAddress, ScaleByMomentOfInertia_FunctionAddress, "ReturnValue");
		ScaleByMomentOfInertia_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScaleByMomentOfInertia_FunctionAddress, "ReturnValue");
		ScaleByMomentOfInertia_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleByMomentOfInertia_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ScaleByMomentOfInertia_IsValid = ScaleByMomentOfInertia_FunctionAddress != IntPtr.Zero && ScaleByMomentOfInertia_InputVector_IsValid && ScaleByMomentOfInertia_BoneName_IsValid && ScaleByMomentOfInertia_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:ScaleByMomentOfInertia", ScaleByMomentOfInertia_IsValid);
		PutRigidBodyToSleep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PutRigidBodyToSleep");
		PutRigidBodyToSleep_ParamsSize = NativeReflection.GetFunctionParamsSize(PutRigidBodyToSleep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PutRigidBodyToSleep_BoneName_PropertyAddress, PutRigidBodyToSleep_FunctionAddress, "BoneName");
		PutRigidBodyToSleep_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(PutRigidBodyToSleep_FunctionAddress, "BoneName");
		PutRigidBodyToSleep_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(PutRigidBodyToSleep_FunctionAddress, "BoneName", Classes.FNameProperty);
		PutRigidBodyToSleep_IsValid = PutRigidBodyToSleep_FunctionAddress != IntPtr.Zero && PutRigidBodyToSleep_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:PutRigidBodyToSleep", PutRigidBodyToSleep_IsValid);
		SphereTraceComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SphereTraceComponent");
		SphereTraceComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SphereTraceComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_TraceStart_PropertyAddress, SphereTraceComponent_FunctionAddress, "TraceStart");
		SphereTraceComponent_TraceStart_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "TraceStart");
		SphereTraceComponent_TraceStart_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "TraceStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_TraceEnd_PropertyAddress, SphereTraceComponent_FunctionAddress, "TraceEnd");
		SphereTraceComponent_TraceEnd_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "TraceEnd");
		SphereTraceComponent_TraceEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "TraceEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_SphereRadius_PropertyAddress, SphereTraceComponent_FunctionAddress, "SphereRadius");
		SphereTraceComponent_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "SphereRadius");
		SphereTraceComponent_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_bTraceComplex_PropertyAddress, SphereTraceComponent_FunctionAddress, "bTraceComplex");
		SphereTraceComponent_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "bTraceComplex");
		SphereTraceComponent_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_bShowTrace_PropertyAddress, SphereTraceComponent_FunctionAddress, "bShowTrace");
		SphereTraceComponent_bShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "bShowTrace");
		SphereTraceComponent_bShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "bShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_bPersistentShowTrace_PropertyAddress, SphereTraceComponent_FunctionAddress, "bPersistentShowTrace");
		SphereTraceComponent_bPersistentShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "bPersistentShowTrace");
		SphereTraceComponent_bPersistentShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "bPersistentShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_HitLocation_PropertyAddress, SphereTraceComponent_FunctionAddress, "HitLocation");
		SphereTraceComponent_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "HitLocation");
		SphereTraceComponent_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_HitNormal_PropertyAddress, SphereTraceComponent_FunctionAddress, "HitNormal");
		SphereTraceComponent_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "HitNormal");
		SphereTraceComponent_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_BoneName_PropertyAddress, SphereTraceComponent_FunctionAddress, "BoneName");
		SphereTraceComponent_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "BoneName");
		SphereTraceComponent_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_OutHit_PropertyAddress, SphereTraceComponent_FunctionAddress, "OutHit");
		SphereTraceComponent_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "OutHit");
		SphereTraceComponent_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTraceComponent_ReturnValue_PropertyAddress, SphereTraceComponent_FunctionAddress, "ReturnValue");
		SphereTraceComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SphereTraceComponent_FunctionAddress, "ReturnValue");
		SphereTraceComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereTraceComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SphereTraceComponent_IsValid = SphereTraceComponent_FunctionAddress != IntPtr.Zero && SphereTraceComponent_TraceStart_IsValid && SphereTraceComponent_TraceEnd_IsValid && SphereTraceComponent_SphereRadius_IsValid && SphereTraceComponent_bTraceComplex_IsValid && SphereTraceComponent_bShowTrace_IsValid && SphereTraceComponent_bPersistentShowTrace_IsValid && SphereTraceComponent_HitLocation_IsValid && SphereTraceComponent_HitNormal_IsValid && SphereTraceComponent_BoneName_IsValid && SphereTraceComponent_OutHit_IsValid && SphereTraceComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_SphereTraceComponent", SphereTraceComponent_IsValid);
		SphereOverlapComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SphereOverlapComponent");
		SphereOverlapComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SphereOverlapComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_InSphereCentre_PropertyAddress, SphereOverlapComponent_FunctionAddress, "InSphereCentre");
		SphereOverlapComponent_InSphereCentre_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "InSphereCentre");
		SphereOverlapComponent_InSphereCentre_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "InSphereCentre", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_InSphereRadius_PropertyAddress, SphereOverlapComponent_FunctionAddress, "InSphereRadius");
		SphereOverlapComponent_InSphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "InSphereRadius");
		SphereOverlapComponent_InSphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "InSphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_bTraceComplex_PropertyAddress, SphereOverlapComponent_FunctionAddress, "bTraceComplex");
		SphereOverlapComponent_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "bTraceComplex");
		SphereOverlapComponent_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_bShowTrace_PropertyAddress, SphereOverlapComponent_FunctionAddress, "bShowTrace");
		SphereOverlapComponent_bShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "bShowTrace");
		SphereOverlapComponent_bShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "bShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_bPersistentShowTrace_PropertyAddress, SphereOverlapComponent_FunctionAddress, "bPersistentShowTrace");
		SphereOverlapComponent_bPersistentShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "bPersistentShowTrace");
		SphereOverlapComponent_bPersistentShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "bPersistentShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_HitLocation_PropertyAddress, SphereOverlapComponent_FunctionAddress, "HitLocation");
		SphereOverlapComponent_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "HitLocation");
		SphereOverlapComponent_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_HitNormal_PropertyAddress, SphereOverlapComponent_FunctionAddress, "HitNormal");
		SphereOverlapComponent_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "HitNormal");
		SphereOverlapComponent_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_BoneName_PropertyAddress, SphereOverlapComponent_FunctionAddress, "BoneName");
		SphereOverlapComponent_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "BoneName");
		SphereOverlapComponent_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_OutHit_PropertyAddress, SphereOverlapComponent_FunctionAddress, "OutHit");
		SphereOverlapComponent_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "OutHit");
		SphereOverlapComponent_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereOverlapComponent_ReturnValue_PropertyAddress, SphereOverlapComponent_FunctionAddress, "ReturnValue");
		SphereOverlapComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SphereOverlapComponent_FunctionAddress, "ReturnValue");
		SphereOverlapComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereOverlapComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SphereOverlapComponent_IsValid = SphereOverlapComponent_FunctionAddress != IntPtr.Zero && SphereOverlapComponent_InSphereCentre_IsValid && SphereOverlapComponent_InSphereRadius_IsValid && SphereOverlapComponent_bTraceComplex_IsValid && SphereOverlapComponent_bShowTrace_IsValid && SphereOverlapComponent_bPersistentShowTrace_IsValid && SphereOverlapComponent_HitLocation_IsValid && SphereOverlapComponent_HitNormal_IsValid && SphereOverlapComponent_BoneName_IsValid && SphereOverlapComponent_OutHit_IsValid && SphereOverlapComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_SphereOverlapComponent", SphereOverlapComponent_IsValid);
		LineTraceComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_LineTraceComponent");
		LineTraceComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(LineTraceComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_TraceStart_PropertyAddress, LineTraceComponent_FunctionAddress, "TraceStart");
		LineTraceComponent_TraceStart_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "TraceStart");
		LineTraceComponent_TraceStart_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "TraceStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_TraceEnd_PropertyAddress, LineTraceComponent_FunctionAddress, "TraceEnd");
		LineTraceComponent_TraceEnd_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "TraceEnd");
		LineTraceComponent_TraceEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "TraceEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_bTraceComplex_PropertyAddress, LineTraceComponent_FunctionAddress, "bTraceComplex");
		LineTraceComponent_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "bTraceComplex");
		LineTraceComponent_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_bShowTrace_PropertyAddress, LineTraceComponent_FunctionAddress, "bShowTrace");
		LineTraceComponent_bShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "bShowTrace");
		LineTraceComponent_bShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "bShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_bPersistentShowTrace_PropertyAddress, LineTraceComponent_FunctionAddress, "bPersistentShowTrace");
		LineTraceComponent_bPersistentShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "bPersistentShowTrace");
		LineTraceComponent_bPersistentShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "bPersistentShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_HitLocation_PropertyAddress, LineTraceComponent_FunctionAddress, "HitLocation");
		LineTraceComponent_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "HitLocation");
		LineTraceComponent_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_HitNormal_PropertyAddress, LineTraceComponent_FunctionAddress, "HitNormal");
		LineTraceComponent_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "HitNormal");
		LineTraceComponent_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_BoneName_PropertyAddress, LineTraceComponent_FunctionAddress, "BoneName");
		LineTraceComponent_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "BoneName");
		LineTraceComponent_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_OutHit_PropertyAddress, LineTraceComponent_FunctionAddress, "OutHit");
		LineTraceComponent_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "OutHit");
		LineTraceComponent_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineTraceComponent_ReturnValue_PropertyAddress, LineTraceComponent_FunctionAddress, "ReturnValue");
		LineTraceComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineTraceComponent_FunctionAddress, "ReturnValue");
		LineTraceComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineTraceComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LineTraceComponent_IsValid = LineTraceComponent_FunctionAddress != IntPtr.Zero && LineTraceComponent_TraceStart_IsValid && LineTraceComponent_TraceEnd_IsValid && LineTraceComponent_bTraceComplex_IsValid && LineTraceComponent_bShowTrace_IsValid && LineTraceComponent_bPersistentShowTrace_IsValid && LineTraceComponent_HitLocation_IsValid && LineTraceComponent_HitNormal_IsValid && LineTraceComponent_BoneName_IsValid && LineTraceComponent_OutHit_IsValid && LineTraceComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_LineTraceComponent", LineTraceComponent_IsValid);
		IsQueryCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_IsQueryCollisionEnabled");
		IsQueryCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsQueryCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsQueryCollisionEnabled_ReturnValue_PropertyAddress, IsQueryCollisionEnabled_FunctionAddress, "ReturnValue");
		IsQueryCollisionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsQueryCollisionEnabled_FunctionAddress, "ReturnValue");
		IsQueryCollisionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsQueryCollisionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsQueryCollisionEnabled_IsValid = IsQueryCollisionEnabled_FunctionAddress != IntPtr.Zero && IsQueryCollisionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_IsQueryCollisionEnabled", IsQueryCollisionEnabled_IsValid);
		IsPhysicsCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_IsPhysicsCollisionEnabled");
		IsPhysicsCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPhysicsCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPhysicsCollisionEnabled_ReturnValue_PropertyAddress, IsPhysicsCollisionEnabled_FunctionAddress, "ReturnValue");
		IsPhysicsCollisionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPhysicsCollisionEnabled_FunctionAddress, "ReturnValue");
		IsPhysicsCollisionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPhysicsCollisionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPhysicsCollisionEnabled_IsValid = IsPhysicsCollisionEnabled_FunctionAddress != IntPtr.Zero && IsPhysicsCollisionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_IsPhysicsCollisionEnabled", IsPhysicsCollisionEnabled_IsValid);
		IsCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_IsCollisionEnabled");
		IsCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCollisionEnabled_ReturnValue_PropertyAddress, IsCollisionEnabled_FunctionAddress, "ReturnValue");
		IsCollisionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCollisionEnabled_FunctionAddress, "ReturnValue");
		IsCollisionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCollisionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCollisionEnabled_IsValid = IsCollisionEnabled_FunctionAddress != IntPtr.Zero && IsCollisionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_IsCollisionEnabled", IsCollisionEnabled_IsValid);
		BoxOverlapComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_BoxOverlapComponent");
		BoxOverlapComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(BoxOverlapComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_InBoxCentre_PropertyAddress, BoxOverlapComponent_FunctionAddress, "InBoxCentre");
		BoxOverlapComponent_InBoxCentre_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "InBoxCentre");
		BoxOverlapComponent_InBoxCentre_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "InBoxCentre", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_InBox_PropertyAddress, BoxOverlapComponent_FunctionAddress, "InBox");
		BoxOverlapComponent_InBox_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "InBox");
		BoxOverlapComponent_InBox_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "InBox", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_bTraceComplex_PropertyAddress, BoxOverlapComponent_FunctionAddress, "bTraceComplex");
		BoxOverlapComponent_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "bTraceComplex");
		BoxOverlapComponent_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_bShowTrace_PropertyAddress, BoxOverlapComponent_FunctionAddress, "bShowTrace");
		BoxOverlapComponent_bShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "bShowTrace");
		BoxOverlapComponent_bShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "bShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_bPersistentShowTrace_PropertyAddress, BoxOverlapComponent_FunctionAddress, "bPersistentShowTrace");
		BoxOverlapComponent_bPersistentShowTrace_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "bPersistentShowTrace");
		BoxOverlapComponent_bPersistentShowTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "bPersistentShowTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_HitLocation_PropertyAddress, BoxOverlapComponent_FunctionAddress, "HitLocation");
		BoxOverlapComponent_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "HitLocation");
		BoxOverlapComponent_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_HitNormal_PropertyAddress, BoxOverlapComponent_FunctionAddress, "HitNormal");
		BoxOverlapComponent_HitNormal_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "HitNormal");
		BoxOverlapComponent_HitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "HitNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_BoneName_PropertyAddress, BoxOverlapComponent_FunctionAddress, "BoneName");
		BoxOverlapComponent_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "BoneName");
		BoxOverlapComponent_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_OutHit_PropertyAddress, BoxOverlapComponent_FunctionAddress, "OutHit");
		BoxOverlapComponent_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "OutHit");
		BoxOverlapComponent_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponent_ReturnValue_PropertyAddress, BoxOverlapComponent_FunctionAddress, "ReturnValue");
		BoxOverlapComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponent_FunctionAddress, "ReturnValue");
		BoxOverlapComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoxOverlapComponent_IsValid = BoxOverlapComponent_FunctionAddress != IntPtr.Zero && BoxOverlapComponent_InBoxCentre_IsValid && BoxOverlapComponent_InBox_IsValid && BoxOverlapComponent_bTraceComplex_IsValid && BoxOverlapComponent_bShowTrace_IsValid && BoxOverlapComponent_bPersistentShowTrace_IsValid && BoxOverlapComponent_HitLocation_IsValid && BoxOverlapComponent_HitNormal_IsValid && BoxOverlapComponent_BoneName_IsValid && BoxOverlapComponent_OutHit_IsValid && BoxOverlapComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:K2_BoxOverlapComponent", BoxOverlapComponent_IsValid);
		IsOverlappingComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverlappingComponent");
		IsOverlappingComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverlappingComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingComponent_OtherComp_PropertyAddress, IsOverlappingComponent_FunctionAddress, "OtherComp");
		IsOverlappingComponent_OtherComp_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingComponent_FunctionAddress, "OtherComp");
		IsOverlappingComponent_OtherComp_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingComponent_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingComponent_ReturnValue_PropertyAddress, IsOverlappingComponent_FunctionAddress, "ReturnValue");
		IsOverlappingComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingComponent_FunctionAddress, "ReturnValue");
		IsOverlappingComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverlappingComponent_IsValid = IsOverlappingComponent_FunctionAddress != IntPtr.Zero && IsOverlappingComponent_OtherComp_IsValid && IsOverlappingComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IsOverlappingComponent", IsOverlappingComponent_IsValid);
		IsOverlappingActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOverlappingActor");
		IsOverlappingActor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOverlappingActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingActor_Other_PropertyAddress, IsOverlappingActor_FunctionAddress, "Other");
		IsOverlappingActor_Other_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingActor_FunctionAddress, "Other");
		IsOverlappingActor_Other_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingActor_FunctionAddress, "Other", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOverlappingActor_ReturnValue_PropertyAddress, IsOverlappingActor_FunctionAddress, "ReturnValue");
		IsOverlappingActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOverlappingActor_FunctionAddress, "ReturnValue");
		IsOverlappingActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOverlappingActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOverlappingActor_IsValid = IsOverlappingActor_FunctionAddress != IntPtr.Zero && IsOverlappingActor_Other_IsValid && IsOverlappingActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IsOverlappingActor", IsOverlappingActor_IsValid);
		IsGravityEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsGravityEnabled");
		IsGravityEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGravityEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGravityEnabled_ReturnValue_PropertyAddress, IsGravityEnabled_FunctionAddress, "ReturnValue");
		IsGravityEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGravityEnabled_FunctionAddress, "ReturnValue");
		IsGravityEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGravityEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGravityEnabled_IsValid = IsGravityEnabled_FunctionAddress != IntPtr.Zero && IsGravityEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IsGravityEnabled", IsGravityEnabled_IsValid);
		IsAnyRigidBodyAwake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnyRigidBodyAwake");
		IsAnyRigidBodyAwake_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnyRigidBodyAwake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnyRigidBodyAwake_ReturnValue_PropertyAddress, IsAnyRigidBodyAwake_FunctionAddress, "ReturnValue");
		IsAnyRigidBodyAwake_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnyRigidBodyAwake_FunctionAddress, "ReturnValue");
		IsAnyRigidBodyAwake_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnyRigidBodyAwake_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnyRigidBodyAwake_IsValid = IsAnyRigidBodyAwake_FunctionAddress != IntPtr.Zero && IsAnyRigidBodyAwake_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IsAnyRigidBodyAwake", IsAnyRigidBodyAwake_IsValid);
		IgnoreComponentWhenMoving_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IgnoreComponentWhenMoving");
		IgnoreComponentWhenMoving_ParamsSize = NativeReflection.GetFunctionParamsSize(IgnoreComponentWhenMoving_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IgnoreComponentWhenMoving_Component_PropertyAddress, IgnoreComponentWhenMoving_FunctionAddress, "Component");
		IgnoreComponentWhenMoving_Component_Offset = NativeReflectionCached.GetPropertyOffset(IgnoreComponentWhenMoving_FunctionAddress, "Component");
		IgnoreComponentWhenMoving_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(IgnoreComponentWhenMoving_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreComponentWhenMoving_bShouldIgnore_PropertyAddress, IgnoreComponentWhenMoving_FunctionAddress, "bShouldIgnore");
		IgnoreComponentWhenMoving_bShouldIgnore_Offset = NativeReflectionCached.GetPropertyOffset(IgnoreComponentWhenMoving_FunctionAddress, "bShouldIgnore");
		IgnoreComponentWhenMoving_bShouldIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(IgnoreComponentWhenMoving_FunctionAddress, "bShouldIgnore", Classes.FBoolProperty);
		IgnoreComponentWhenMoving_IsValid = IgnoreComponentWhenMoving_FunctionAddress != IntPtr.Zero && IgnoreComponentWhenMoving_Component_IsValid && IgnoreComponentWhenMoving_bShouldIgnore_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IgnoreComponentWhenMoving", IgnoreComponentWhenMoving_IsValid);
		IgnoreActorWhenMoving_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IgnoreActorWhenMoving");
		IgnoreActorWhenMoving_ParamsSize = NativeReflection.GetFunctionParamsSize(IgnoreActorWhenMoving_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IgnoreActorWhenMoving_Actor_PropertyAddress, IgnoreActorWhenMoving_FunctionAddress, "Actor");
		IgnoreActorWhenMoving_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IgnoreActorWhenMoving_FunctionAddress, "Actor");
		IgnoreActorWhenMoving_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IgnoreActorWhenMoving_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreActorWhenMoving_bShouldIgnore_PropertyAddress, IgnoreActorWhenMoving_FunctionAddress, "bShouldIgnore");
		IgnoreActorWhenMoving_bShouldIgnore_Offset = NativeReflectionCached.GetPropertyOffset(IgnoreActorWhenMoving_FunctionAddress, "bShouldIgnore");
		IgnoreActorWhenMoving_bShouldIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(IgnoreActorWhenMoving_FunctionAddress, "bShouldIgnore", Classes.FBoolProperty);
		IgnoreActorWhenMoving_IsValid = IgnoreActorWhenMoving_FunctionAddress != IntPtr.Zero && IgnoreActorWhenMoving_Actor_IsValid && IgnoreActorWhenMoving_bShouldIgnore_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:IgnoreActorWhenMoving", IgnoreActorWhenMoving_IsValid);
		GetWalkableSlopeOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWalkableSlopeOverride");
		GetWalkableSlopeOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWalkableSlopeOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWalkableSlopeOverride_ReturnValue_PropertyAddress, GetWalkableSlopeOverride_FunctionAddress, "ReturnValue");
		GetWalkableSlopeOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWalkableSlopeOverride_FunctionAddress, "ReturnValue");
		GetWalkableSlopeOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWalkableSlopeOverride_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWalkableSlopeOverride_IsValid = GetWalkableSlopeOverride_FunctionAddress != IntPtr.Zero && GetWalkableSlopeOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetWalkableSlopeOverride", GetWalkableSlopeOverride_IsValid);
		GetPhysicsLinearVelocityAtPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsLinearVelocityAtPoint");
		GetPhysicsLinearVelocityAtPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsLinearVelocityAtPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsLinearVelocityAtPoint_Point_PropertyAddress, GetPhysicsLinearVelocityAtPoint_FunctionAddress, "Point");
		GetPhysicsLinearVelocityAtPoint_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "Point");
		GetPhysicsLinearVelocityAtPoint_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsLinearVelocityAtPoint_BoneName_PropertyAddress, GetPhysicsLinearVelocityAtPoint_FunctionAddress, "BoneName");
		GetPhysicsLinearVelocityAtPoint_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "BoneName");
		GetPhysicsLinearVelocityAtPoint_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsLinearVelocityAtPoint_ReturnValue_PropertyAddress, GetPhysicsLinearVelocityAtPoint_FunctionAddress, "ReturnValue");
		GetPhysicsLinearVelocityAtPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "ReturnValue");
		GetPhysicsLinearVelocityAtPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsLinearVelocityAtPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPhysicsLinearVelocityAtPoint_IsValid = GetPhysicsLinearVelocityAtPoint_FunctionAddress != IntPtr.Zero && GetPhysicsLinearVelocityAtPoint_Point_IsValid && GetPhysicsLinearVelocityAtPoint_BoneName_IsValid && GetPhysicsLinearVelocityAtPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocityAtPoint", GetPhysicsLinearVelocityAtPoint_IsValid);
		GetPhysicsLinearVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsLinearVelocity");
		GetPhysicsLinearVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsLinearVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsLinearVelocity_BoneName_PropertyAddress, GetPhysicsLinearVelocity_FunctionAddress, "BoneName");
		GetPhysicsLinearVelocity_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsLinearVelocity_FunctionAddress, "BoneName");
		GetPhysicsLinearVelocity_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsLinearVelocity_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsLinearVelocity_ReturnValue_PropertyAddress, GetPhysicsLinearVelocity_FunctionAddress, "ReturnValue");
		GetPhysicsLinearVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsLinearVelocity_FunctionAddress, "ReturnValue");
		GetPhysicsLinearVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsLinearVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPhysicsLinearVelocity_IsValid = GetPhysicsLinearVelocity_FunctionAddress != IntPtr.Zero && GetPhysicsLinearVelocity_BoneName_IsValid && GetPhysicsLinearVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetPhysicsLinearVelocity", GetPhysicsLinearVelocity_IsValid);
		GetPhysicsAngularVelocityInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsAngularVelocityInRadians");
		GetPhysicsAngularVelocityInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAngularVelocityInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAngularVelocityInRadians_BoneName_PropertyAddress, GetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName");
		GetPhysicsAngularVelocityInRadians_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName");
		GetPhysicsAngularVelocityInRadians_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAngularVelocityInRadians_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAngularVelocityInRadians_ReturnValue_PropertyAddress, GetPhysicsAngularVelocityInRadians_FunctionAddress, "ReturnValue");
		GetPhysicsAngularVelocityInRadians_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAngularVelocityInRadians_FunctionAddress, "ReturnValue");
		GetPhysicsAngularVelocityInRadians_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAngularVelocityInRadians_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPhysicsAngularVelocityInRadians_IsValid = GetPhysicsAngularVelocityInRadians_FunctionAddress != IntPtr.Zero && GetPhysicsAngularVelocityInRadians_BoneName_IsValid && GetPhysicsAngularVelocityInRadians_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInRadians", GetPhysicsAngularVelocityInRadians_IsValid);
		GetPhysicsAngularVelocityInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsAngularVelocityInDegrees");
		GetPhysicsAngularVelocityInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsAngularVelocityInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAngularVelocityInDegrees_BoneName_PropertyAddress, GetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName");
		GetPhysicsAngularVelocityInDegrees_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName");
		GetPhysicsAngularVelocityInDegrees_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAngularVelocityInDegrees_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsAngularVelocityInDegrees_ReturnValue_PropertyAddress, GetPhysicsAngularVelocityInDegrees_FunctionAddress, "ReturnValue");
		GetPhysicsAngularVelocityInDegrees_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsAngularVelocityInDegrees_FunctionAddress, "ReturnValue");
		GetPhysicsAngularVelocityInDegrees_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsAngularVelocityInDegrees_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPhysicsAngularVelocityInDegrees_IsValid = GetPhysicsAngularVelocityInDegrees_FunctionAddress != IntPtr.Zero && GetPhysicsAngularVelocityInDegrees_BoneName_IsValid && GetPhysicsAngularVelocityInDegrees_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetPhysicsAngularVelocityInDegrees", GetPhysicsAngularVelocityInDegrees_IsValid);
		GetOverlappingComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverlappingComponents");
		GetOverlappingComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverlappingComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingComponents_OutOverlappingComponents_PropertyAddress, GetOverlappingComponents_FunctionAddress, "OutOverlappingComponents");
		GetOverlappingComponents_OutOverlappingComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingComponents_FunctionAddress, "OutOverlappingComponents");
		GetOverlappingComponents_OutOverlappingComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingComponents_FunctionAddress, "OutOverlappingComponents", Classes.FArrayProperty);
		GetOverlappingComponents_IsValid = GetOverlappingComponents_FunctionAddress != IntPtr.Zero && GetOverlappingComponents_OutOverlappingComponents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetOverlappingComponents", GetOverlappingComponents_IsValid);
		GetOverlappingActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOverlappingActors");
		GetOverlappingActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverlappingActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingActors_OverlappingActors_PropertyAddress, GetOverlappingActors_FunctionAddress, "OverlappingActors");
		GetOverlappingActors_OverlappingActors_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingActors_FunctionAddress, "OverlappingActors");
		GetOverlappingActors_OverlappingActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingActors_FunctionAddress, "OverlappingActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOverlappingActors_ClassFilter_PropertyAddress, GetOverlappingActors_FunctionAddress, "ClassFilter");
		GetOverlappingActors_ClassFilter_Offset = NativeReflectionCached.GetPropertyOffset(GetOverlappingActors_FunctionAddress, "ClassFilter");
		GetOverlappingActors_ClassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverlappingActors_FunctionAddress, "ClassFilter", Classes.FClassProperty);
		GetOverlappingActors_IsValid = GetOverlappingActors_FunctionAddress != IntPtr.Zero && GetOverlappingActors_OverlappingActors_IsValid && GetOverlappingActors_ClassFilter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetOverlappingActors", GetOverlappingActors_IsValid);
		GetNumMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumMaterials");
		GetNumMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumMaterials_ReturnValue_PropertyAddress, GetNumMaterials_FunctionAddress, "ReturnValue");
		GetNumMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumMaterials_FunctionAddress, "ReturnValue");
		GetNumMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumMaterials_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumMaterials_IsValid = GetNumMaterials_FunctionAddress != IntPtr.Zero && GetNumMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetNumMaterials", GetNumMaterials_IsValid);
		GetMaterialFromCollisionFaceIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterialFromCollisionFaceIndex");
		GetMaterialFromCollisionFaceIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialFromCollisionFaceIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialFromCollisionFaceIndex_FaceIndex_PropertyAddress, GetMaterialFromCollisionFaceIndex_FunctionAddress, "FaceIndex");
		GetMaterialFromCollisionFaceIndex_FaceIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialFromCollisionFaceIndex_FunctionAddress, "FaceIndex");
		GetMaterialFromCollisionFaceIndex_FaceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialFromCollisionFaceIndex_FunctionAddress, "FaceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialFromCollisionFaceIndex_SectionIndex_PropertyAddress, GetMaterialFromCollisionFaceIndex_FunctionAddress, "SectionIndex");
		GetMaterialFromCollisionFaceIndex_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialFromCollisionFaceIndex_FunctionAddress, "SectionIndex");
		GetMaterialFromCollisionFaceIndex_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialFromCollisionFaceIndex_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialFromCollisionFaceIndex_ReturnValue_PropertyAddress, GetMaterialFromCollisionFaceIndex_FunctionAddress, "ReturnValue");
		GetMaterialFromCollisionFaceIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialFromCollisionFaceIndex_FunctionAddress, "ReturnValue");
		GetMaterialFromCollisionFaceIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialFromCollisionFaceIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMaterialFromCollisionFaceIndex_IsValid = GetMaterialFromCollisionFaceIndex_FunctionAddress != IntPtr.Zero && GetMaterialFromCollisionFaceIndex_FaceIndex_IsValid && GetMaterialFromCollisionFaceIndex_SectionIndex_IsValid && GetMaterialFromCollisionFaceIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetMaterialFromCollisionFaceIndex", GetMaterialFromCollisionFaceIndex_IsValid);
		GetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterial");
		GetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterial_ElementIndex_PropertyAddress, GetMaterial_FunctionAddress, "ElementIndex");
		GetMaterial_ElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterial_FunctionAddress, "ElementIndex");
		GetMaterial_ElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterial_FunctionAddress, "ElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterial_ReturnValue_PropertyAddress, GetMaterial_FunctionAddress, "ReturnValue");
		GetMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterial_FunctionAddress, "ReturnValue");
		GetMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMaterial_IsValid = GetMaterial_FunctionAddress != IntPtr.Zero && GetMaterial_ElementIndex_IsValid && GetMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetMaterial", GetMaterial_IsValid);
		GetMassScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMassScale");
		GetMassScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMassScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMassScale_BoneName_PropertyAddress, GetMassScale_FunctionAddress, "BoneName");
		GetMassScale_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetMassScale_FunctionAddress, "BoneName");
		GetMassScale_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMassScale_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMassScale_ReturnValue_PropertyAddress, GetMassScale_FunctionAddress, "ReturnValue");
		GetMassScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMassScale_FunctionAddress, "ReturnValue");
		GetMassScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMassScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMassScale_IsValid = GetMassScale_FunctionAddress != IntPtr.Zero && GetMassScale_BoneName_IsValid && GetMassScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetMassScale", GetMassScale_IsValid);
		GetMass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMass");
		GetMass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMass_ReturnValue_PropertyAddress, GetMass_FunctionAddress, "ReturnValue");
		GetMass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMass_FunctionAddress, "ReturnValue");
		GetMass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMass_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMass_IsValid = GetMass_FunctionAddress != IntPtr.Zero && GetMass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetMass", GetMass_IsValid);
		GetLinearDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLinearDamping");
		GetLinearDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearDamping_ReturnValue_PropertyAddress, GetLinearDamping_FunctionAddress, "ReturnValue");
		GetLinearDamping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearDamping_FunctionAddress, "ReturnValue");
		GetLinearDamping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearDamping_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetLinearDamping_IsValid = GetLinearDamping_FunctionAddress != IntPtr.Zero && GetLinearDamping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetLinearDamping", GetLinearDamping_IsValid);
		GetInertiaTensor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInertiaTensor");
		GetInertiaTensor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInertiaTensor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInertiaTensor_BoneName_PropertyAddress, GetInertiaTensor_FunctionAddress, "BoneName");
		GetInertiaTensor_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetInertiaTensor_FunctionAddress, "BoneName");
		GetInertiaTensor_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInertiaTensor_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInertiaTensor_ReturnValue_PropertyAddress, GetInertiaTensor_FunctionAddress, "ReturnValue");
		GetInertiaTensor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInertiaTensor_FunctionAddress, "ReturnValue");
		GetInertiaTensor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInertiaTensor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInertiaTensor_IsValid = GetInertiaTensor_FunctionAddress != IntPtr.Zero && GetInertiaTensor_BoneName_IsValid && GetInertiaTensor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetInertiaTensor", GetInertiaTensor_IsValid);
		GetGenerateOverlapEvents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGenerateOverlapEvents");
		GetGenerateOverlapEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGenerateOverlapEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGenerateOverlapEvents_ReturnValue_PropertyAddress, GetGenerateOverlapEvents_FunctionAddress, "ReturnValue");
		GetGenerateOverlapEvents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGenerateOverlapEvents_FunctionAddress, "ReturnValue");
		GetGenerateOverlapEvents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGenerateOverlapEvents_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGenerateOverlapEvents_IsValid = GetGenerateOverlapEvents_FunctionAddress != IntPtr.Zero && GetGenerateOverlapEvents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetGenerateOverlapEvents", GetGenerateOverlapEvents_IsValid);
		GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCustomPrimitiveDataIndexForVectorParameter");
		GetCustomPrimitiveDataIndexForVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_PropertyAddress, GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ParameterName");
		GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ParameterName");
		GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_PropertyAddress, GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomPrimitiveDataIndexForVectorParameter_IsValid = GetCustomPrimitiveDataIndexForVectorParameter_FunctionAddress != IntPtr.Zero && GetCustomPrimitiveDataIndexForVectorParameter_ParameterName_IsValid && GetCustomPrimitiveDataIndexForVectorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForVectorParameter", GetCustomPrimitiveDataIndexForVectorParameter_IsValid);
		GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCustomPrimitiveDataIndexForScalarParameter");
		GetCustomPrimitiveDataIndexForScalarParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_PropertyAddress, GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ParameterName");
		GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ParameterName");
		GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_PropertyAddress, GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCustomPrimitiveDataIndexForScalarParameter_IsValid = GetCustomPrimitiveDataIndexForScalarParameter_FunctionAddress != IntPtr.Zero && GetCustomPrimitiveDataIndexForScalarParameter_ParameterName_IsValid && GetCustomPrimitiveDataIndexForScalarParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCustomPrimitiveDataIndexForScalarParameter", GetCustomPrimitiveDataIndexForScalarParameter_IsValid);
		GetCollisionResponseToChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionResponseToChannel");
		GetCollisionResponseToChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionResponseToChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionResponseToChannel_Channel_PropertyAddress, GetCollisionResponseToChannel_FunctionAddress, "Channel");
		GetCollisionResponseToChannel_Channel_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionResponseToChannel_FunctionAddress, "Channel");
		GetCollisionResponseToChannel_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionResponseToChannel_FunctionAddress, "Channel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionResponseToChannel_ReturnValue_PropertyAddress, GetCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		GetCollisionResponseToChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionResponseToChannel_FunctionAddress, "ReturnValue");
		GetCollisionResponseToChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionResponseToChannel_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionResponseToChannel_IsValid = GetCollisionResponseToChannel_FunctionAddress != IntPtr.Zero && GetCollisionResponseToChannel_Channel_IsValid && GetCollisionResponseToChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCollisionResponseToChannel", GetCollisionResponseToChannel_IsValid);
		GetCollisionProfileName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionProfileName");
		GetCollisionProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileName_ReturnValue_PropertyAddress, GetCollisionProfileName_FunctionAddress, "ReturnValue");
		GetCollisionProfileName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileName_FunctionAddress, "ReturnValue");
		GetCollisionProfileName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetCollisionProfileName_IsValid = GetCollisionProfileName_FunctionAddress != IntPtr.Zero && GetCollisionProfileName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCollisionProfileName", GetCollisionProfileName_IsValid);
		GetCollisionObjectType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionObjectType");
		GetCollisionObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionObjectType_ReturnValue_PropertyAddress, GetCollisionObjectType_FunctionAddress, "ReturnValue");
		GetCollisionObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionObjectType_FunctionAddress, "ReturnValue");
		GetCollisionObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionObjectType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionObjectType_IsValid = GetCollisionObjectType_FunctionAddress != IntPtr.Zero && GetCollisionObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCollisionObjectType", GetCollisionObjectType_IsValid);
		GetCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCollisionEnabled");
		GetCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionEnabled_ReturnValue_PropertyAddress, GetCollisionEnabled_FunctionAddress, "ReturnValue");
		GetCollisionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionEnabled_FunctionAddress, "ReturnValue");
		GetCollisionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionEnabled_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionEnabled_IsValid = GetCollisionEnabled_FunctionAddress != IntPtr.Zero && GetCollisionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCollisionEnabled", GetCollisionEnabled_IsValid);
		GetClosestPointOnCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetClosestPointOnCollision");
		GetClosestPointOnCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClosestPointOnCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClosestPointOnCollision_Point_PropertyAddress, GetClosestPointOnCollision_FunctionAddress, "Point");
		GetClosestPointOnCollision_Point_Offset = NativeReflectionCached.GetPropertyOffset(GetClosestPointOnCollision_FunctionAddress, "Point");
		GetClosestPointOnCollision_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClosestPointOnCollision_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClosestPointOnCollision_OutPointOnBody_PropertyAddress, GetClosestPointOnCollision_FunctionAddress, "OutPointOnBody");
		GetClosestPointOnCollision_OutPointOnBody_Offset = NativeReflectionCached.GetPropertyOffset(GetClosestPointOnCollision_FunctionAddress, "OutPointOnBody");
		GetClosestPointOnCollision_OutPointOnBody_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClosestPointOnCollision_FunctionAddress, "OutPointOnBody", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClosestPointOnCollision_BoneName_PropertyAddress, GetClosestPointOnCollision_FunctionAddress, "BoneName");
		GetClosestPointOnCollision_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetClosestPointOnCollision_FunctionAddress, "BoneName");
		GetClosestPointOnCollision_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClosestPointOnCollision_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClosestPointOnCollision_ReturnValue_PropertyAddress, GetClosestPointOnCollision_FunctionAddress, "ReturnValue");
		GetClosestPointOnCollision_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClosestPointOnCollision_FunctionAddress, "ReturnValue");
		GetClosestPointOnCollision_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClosestPointOnCollision_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetClosestPointOnCollision_IsValid = GetClosestPointOnCollision_FunctionAddress != IntPtr.Zero && GetClosestPointOnCollision_Point_IsValid && GetClosestPointOnCollision_OutPointOnBody_IsValid && GetClosestPointOnCollision_BoneName_IsValid && GetClosestPointOnCollision_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetClosestPointOnCollision", GetClosestPointOnCollision_IsValid);
		GetCenterOfMass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCenterOfMass");
		GetCenterOfMass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCenterOfMass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCenterOfMass_BoneName_PropertyAddress, GetCenterOfMass_FunctionAddress, "BoneName");
		GetCenterOfMass_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetCenterOfMass_FunctionAddress, "BoneName");
		GetCenterOfMass_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCenterOfMass_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCenterOfMass_ReturnValue_PropertyAddress, GetCenterOfMass_FunctionAddress, "ReturnValue");
		GetCenterOfMass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCenterOfMass_FunctionAddress, "ReturnValue");
		GetCenterOfMass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCenterOfMass_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCenterOfMass_IsValid = GetCenterOfMass_FunctionAddress != IntPtr.Zero && GetCenterOfMass_BoneName_IsValid && GetCenterOfMass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetCenterOfMass", GetCenterOfMass_IsValid);
		GetAngularDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAngularDamping");
		GetAngularDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAngularDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAngularDamping_ReturnValue_PropertyAddress, GetAngularDamping_FunctionAddress, "ReturnValue");
		GetAngularDamping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAngularDamping_FunctionAddress, "ReturnValue");
		GetAngularDamping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAngularDamping_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAngularDamping_IsValid = GetAngularDamping_FunctionAddress != IntPtr.Zero && GetAngularDamping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:GetAngularDamping", GetAngularDamping_IsValid);
		CreateDynamicMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreateDynamicMaterialInstance");
		CreateDynamicMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDynamicMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_ElementIndex_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "ElementIndex");
		CreateDynamicMaterialInstance_ElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "ElementIndex");
		CreateDynamicMaterialInstance_ElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "ElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_SourceMaterial_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "SourceMaterial");
		CreateDynamicMaterialInstance_SourceMaterial_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "SourceMaterial");
		CreateDynamicMaterialInstance_SourceMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "SourceMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_OptionalName_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "OptionalName");
		CreateDynamicMaterialInstance_OptionalName_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "OptionalName");
		CreateDynamicMaterialInstance_OptionalName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "OptionalName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_ReturnValue_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateDynamicMaterialInstance_IsValid = CreateDynamicMaterialInstance_FunctionAddress != IntPtr.Zero && CreateDynamicMaterialInstance_ElementIndex_IsValid && CreateDynamicMaterialInstance_SourceMaterial_IsValid && CreateDynamicMaterialInstance_OptionalName_IsValid && CreateDynamicMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:CreateDynamicMaterialInstance", CreateDynamicMaterialInstance_IsValid);
		CopyArrayOfMoveIgnoreComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyArrayOfMoveIgnoreComponents");
		CopyArrayOfMoveIgnoreComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyArrayOfMoveIgnoreComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyArrayOfMoveIgnoreComponents_ReturnValue_PropertyAddress, CopyArrayOfMoveIgnoreComponents_FunctionAddress, "ReturnValue");
		CopyArrayOfMoveIgnoreComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyArrayOfMoveIgnoreComponents_FunctionAddress, "ReturnValue");
		CopyArrayOfMoveIgnoreComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyArrayOfMoveIgnoreComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CopyArrayOfMoveIgnoreComponents_IsValid = CopyArrayOfMoveIgnoreComponents_FunctionAddress != IntPtr.Zero && CopyArrayOfMoveIgnoreComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreComponents", CopyArrayOfMoveIgnoreComponents_IsValid);
		CopyArrayOfMoveIgnoreActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyArrayOfMoveIgnoreActors");
		CopyArrayOfMoveIgnoreActors_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyArrayOfMoveIgnoreActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyArrayOfMoveIgnoreActors_ReturnValue_PropertyAddress, CopyArrayOfMoveIgnoreActors_FunctionAddress, "ReturnValue");
		CopyArrayOfMoveIgnoreActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyArrayOfMoveIgnoreActors_FunctionAddress, "ReturnValue");
		CopyArrayOfMoveIgnoreActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyArrayOfMoveIgnoreActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CopyArrayOfMoveIgnoreActors_IsValid = CopyArrayOfMoveIgnoreActors_FunctionAddress != IntPtr.Zero && CopyArrayOfMoveIgnoreActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:CopyArrayOfMoveIgnoreActors", CopyArrayOfMoveIgnoreActors_IsValid);
		ClearMoveIgnoreComponents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMoveIgnoreComponents");
		ClearMoveIgnoreComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMoveIgnoreComponents_FunctionAddress);
		ClearMoveIgnoreComponents_IsValid = ClearMoveIgnoreComponents_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreComponents", ClearMoveIgnoreComponents_IsValid);
		ClearMoveIgnoreActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMoveIgnoreActors");
		ClearMoveIgnoreActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMoveIgnoreActors_FunctionAddress);
		ClearMoveIgnoreActors_IsValid = ClearMoveIgnoreActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:ClearMoveIgnoreActors", ClearMoveIgnoreActors_IsValid);
		CanCharacterStepUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanCharacterStepUp");
		CanCharacterStepUp_ParamsSize = NativeReflection.GetFunctionParamsSize(CanCharacterStepUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanCharacterStepUp_Pawn_PropertyAddress, CanCharacterStepUp_FunctionAddress, "Pawn");
		CanCharacterStepUp_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(CanCharacterStepUp_FunctionAddress, "Pawn");
		CanCharacterStepUp_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCharacterStepUp_FunctionAddress, "Pawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCharacterStepUp_ReturnValue_PropertyAddress, CanCharacterStepUp_FunctionAddress, "ReturnValue");
		CanCharacterStepUp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanCharacterStepUp_FunctionAddress, "ReturnValue");
		CanCharacterStepUp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCharacterStepUp_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanCharacterStepUp_IsValid = CanCharacterStepUp_FunctionAddress != IntPtr.Zero && CanCharacterStepUp_Pawn_IsValid && CanCharacterStepUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:CanCharacterStepUp", CanCharacterStepUp_IsValid);
		AddVelocityChangeImpulseAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddVelocityChangeImpulseAtLocation");
		AddVelocityChangeImpulseAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVelocityChangeImpulseAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVelocityChangeImpulseAtLocation_Impulse_PropertyAddress, AddVelocityChangeImpulseAtLocation_FunctionAddress, "Impulse");
		AddVelocityChangeImpulseAtLocation_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddVelocityChangeImpulseAtLocation_FunctionAddress, "Impulse");
		AddVelocityChangeImpulseAtLocation_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVelocityChangeImpulseAtLocation_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVelocityChangeImpulseAtLocation_Location_PropertyAddress, AddVelocityChangeImpulseAtLocation_FunctionAddress, "Location");
		AddVelocityChangeImpulseAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(AddVelocityChangeImpulseAtLocation_FunctionAddress, "Location");
		AddVelocityChangeImpulseAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVelocityChangeImpulseAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVelocityChangeImpulseAtLocation_BoneName_PropertyAddress, AddVelocityChangeImpulseAtLocation_FunctionAddress, "BoneName");
		AddVelocityChangeImpulseAtLocation_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVelocityChangeImpulseAtLocation_FunctionAddress, "BoneName");
		AddVelocityChangeImpulseAtLocation_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVelocityChangeImpulseAtLocation_FunctionAddress, "BoneName", Classes.FNameProperty);
		AddVelocityChangeImpulseAtLocation_IsValid = AddVelocityChangeImpulseAtLocation_FunctionAddress != IntPtr.Zero && AddVelocityChangeImpulseAtLocation_Impulse_IsValid && AddVelocityChangeImpulseAtLocation_Location_IsValid && AddVelocityChangeImpulseAtLocation_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddVelocityChangeImpulseAtLocation", AddVelocityChangeImpulseAtLocation_IsValid);
		AddTorqueInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTorqueInRadians");
		AddTorqueInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTorqueInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInRadians_Torque_PropertyAddress, AddTorqueInRadians_FunctionAddress, "Torque");
		AddTorqueInRadians_Torque_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInRadians_FunctionAddress, "Torque");
		AddTorqueInRadians_Torque_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInRadians_FunctionAddress, "Torque", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInRadians_BoneName_PropertyAddress, AddTorqueInRadians_FunctionAddress, "BoneName");
		AddTorqueInRadians_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInRadians_FunctionAddress, "BoneName");
		AddTorqueInRadians_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInRadians_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInRadians_bAccelChange_PropertyAddress, AddTorqueInRadians_FunctionAddress, "bAccelChange");
		AddTorqueInRadians_bAccelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInRadians_FunctionAddress, "bAccelChange");
		AddTorqueInRadians_bAccelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInRadians_FunctionAddress, "bAccelChange", Classes.FBoolProperty);
		AddTorqueInRadians_IsValid = AddTorqueInRadians_FunctionAddress != IntPtr.Zero && AddTorqueInRadians_Torque_IsValid && AddTorqueInRadians_BoneName_IsValid && AddTorqueInRadians_bAccelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddTorqueInRadians", AddTorqueInRadians_IsValid);
		AddTorqueInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTorqueInDegrees");
		AddTorqueInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTorqueInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInDegrees_Torque_PropertyAddress, AddTorqueInDegrees_FunctionAddress, "Torque");
		AddTorqueInDegrees_Torque_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInDegrees_FunctionAddress, "Torque");
		AddTorqueInDegrees_Torque_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInDegrees_FunctionAddress, "Torque", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInDegrees_BoneName_PropertyAddress, AddTorqueInDegrees_FunctionAddress, "BoneName");
		AddTorqueInDegrees_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInDegrees_FunctionAddress, "BoneName");
		AddTorqueInDegrees_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInDegrees_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTorqueInDegrees_bAccelChange_PropertyAddress, AddTorqueInDegrees_FunctionAddress, "bAccelChange");
		AddTorqueInDegrees_bAccelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddTorqueInDegrees_FunctionAddress, "bAccelChange");
		AddTorqueInDegrees_bAccelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTorqueInDegrees_FunctionAddress, "bAccelChange", Classes.FBoolProperty);
		AddTorqueInDegrees_IsValid = AddTorqueInDegrees_FunctionAddress != IntPtr.Zero && AddTorqueInDegrees_Torque_IsValid && AddTorqueInDegrees_BoneName_IsValid && AddTorqueInDegrees_bAccelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddTorqueInDegrees", AddTorqueInDegrees_IsValid);
		AddRadialImpulse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRadialImpulse");
		AddRadialImpulse_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRadialImpulse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRadialImpulse_Origin_PropertyAddress, AddRadialImpulse_FunctionAddress, "Origin");
		AddRadialImpulse_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialImpulse_FunctionAddress, "Origin");
		AddRadialImpulse_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialImpulse_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialImpulse_Radius_PropertyAddress, AddRadialImpulse_FunctionAddress, "Radius");
		AddRadialImpulse_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialImpulse_FunctionAddress, "Radius");
		AddRadialImpulse_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialImpulse_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialImpulse_Strength_PropertyAddress, AddRadialImpulse_FunctionAddress, "Strength");
		AddRadialImpulse_Strength_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialImpulse_FunctionAddress, "Strength");
		AddRadialImpulse_Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialImpulse_FunctionAddress, "Strength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialImpulse_Falloff_PropertyAddress, AddRadialImpulse_FunctionAddress, "Falloff");
		AddRadialImpulse_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialImpulse_FunctionAddress, "Falloff");
		AddRadialImpulse_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialImpulse_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialImpulse_bVelChange_PropertyAddress, AddRadialImpulse_FunctionAddress, "bVelChange");
		AddRadialImpulse_bVelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialImpulse_FunctionAddress, "bVelChange");
		AddRadialImpulse_bVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialImpulse_FunctionAddress, "bVelChange", Classes.FBoolProperty);
		AddRadialImpulse_IsValid = AddRadialImpulse_FunctionAddress != IntPtr.Zero && AddRadialImpulse_Origin_IsValid && AddRadialImpulse_Radius_IsValid && AddRadialImpulse_Strength_IsValid && AddRadialImpulse_Falloff_IsValid && AddRadialImpulse_bVelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddRadialImpulse", AddRadialImpulse_IsValid);
		AddRadialForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRadialForce");
		AddRadialForce_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRadialForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRadialForce_Origin_PropertyAddress, AddRadialForce_FunctionAddress, "Origin");
		AddRadialForce_Origin_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialForce_FunctionAddress, "Origin");
		AddRadialForce_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialForce_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialForce_Radius_PropertyAddress, AddRadialForce_FunctionAddress, "Radius");
		AddRadialForce_Radius_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialForce_FunctionAddress, "Radius");
		AddRadialForce_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialForce_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialForce_Strength_PropertyAddress, AddRadialForce_FunctionAddress, "Strength");
		AddRadialForce_Strength_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialForce_FunctionAddress, "Strength");
		AddRadialForce_Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialForce_FunctionAddress, "Strength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialForce_Falloff_PropertyAddress, AddRadialForce_FunctionAddress, "Falloff");
		AddRadialForce_Falloff_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialForce_FunctionAddress, "Falloff");
		AddRadialForce_Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialForce_FunctionAddress, "Falloff", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRadialForce_bAccelChange_PropertyAddress, AddRadialForce_FunctionAddress, "bAccelChange");
		AddRadialForce_bAccelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddRadialForce_FunctionAddress, "bAccelChange");
		AddRadialForce_bAccelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRadialForce_FunctionAddress, "bAccelChange", Classes.FBoolProperty);
		AddRadialForce_IsValid = AddRadialForce_FunctionAddress != IntPtr.Zero && AddRadialForce_Origin_IsValid && AddRadialForce_Radius_IsValid && AddRadialForce_Strength_IsValid && AddRadialForce_Falloff_IsValid && AddRadialForce_bAccelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddRadialForce", AddRadialForce_IsValid);
		AddImpulseAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddImpulseAtLocation");
		AddImpulseAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddImpulseAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddImpulseAtLocation_Impulse_PropertyAddress, AddImpulseAtLocation_FunctionAddress, "Impulse");
		AddImpulseAtLocation_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulseAtLocation_FunctionAddress, "Impulse");
		AddImpulseAtLocation_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulseAtLocation_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImpulseAtLocation_Location_PropertyAddress, AddImpulseAtLocation_FunctionAddress, "Location");
		AddImpulseAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulseAtLocation_FunctionAddress, "Location");
		AddImpulseAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulseAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImpulseAtLocation_BoneName_PropertyAddress, AddImpulseAtLocation_FunctionAddress, "BoneName");
		AddImpulseAtLocation_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulseAtLocation_FunctionAddress, "BoneName");
		AddImpulseAtLocation_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulseAtLocation_FunctionAddress, "BoneName", Classes.FNameProperty);
		AddImpulseAtLocation_IsValid = AddImpulseAtLocation_FunctionAddress != IntPtr.Zero && AddImpulseAtLocation_Impulse_IsValid && AddImpulseAtLocation_Location_IsValid && AddImpulseAtLocation_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddImpulseAtLocation", AddImpulseAtLocation_IsValid);
		AddImpulse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddImpulse");
		AddImpulse_ParamsSize = NativeReflection.GetFunctionParamsSize(AddImpulse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddImpulse_Impulse_PropertyAddress, AddImpulse_FunctionAddress, "Impulse");
		AddImpulse_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulse_FunctionAddress, "Impulse");
		AddImpulse_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulse_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImpulse_BoneName_PropertyAddress, AddImpulse_FunctionAddress, "BoneName");
		AddImpulse_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulse_FunctionAddress, "BoneName");
		AddImpulse_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulse_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddImpulse_bVelChange_PropertyAddress, AddImpulse_FunctionAddress, "bVelChange");
		AddImpulse_bVelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddImpulse_FunctionAddress, "bVelChange");
		AddImpulse_bVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddImpulse_FunctionAddress, "bVelChange", Classes.FBoolProperty);
		AddImpulse_IsValid = AddImpulse_FunctionAddress != IntPtr.Zero && AddImpulse_Impulse_IsValid && AddImpulse_BoneName_IsValid && AddImpulse_bVelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddImpulse", AddImpulse_IsValid);
		AddForceAtLocationLocal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddForceAtLocationLocal");
		AddForceAtLocationLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(AddForceAtLocationLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocationLocal_Force_PropertyAddress, AddForceAtLocationLocal_FunctionAddress, "Force");
		AddForceAtLocationLocal_Force_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocationLocal_FunctionAddress, "Force");
		AddForceAtLocationLocal_Force_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocationLocal_FunctionAddress, "Force", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocationLocal_Location_PropertyAddress, AddForceAtLocationLocal_FunctionAddress, "Location");
		AddForceAtLocationLocal_Location_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocationLocal_FunctionAddress, "Location");
		AddForceAtLocationLocal_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocationLocal_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocationLocal_BoneName_PropertyAddress, AddForceAtLocationLocal_FunctionAddress, "BoneName");
		AddForceAtLocationLocal_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocationLocal_FunctionAddress, "BoneName");
		AddForceAtLocationLocal_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocationLocal_FunctionAddress, "BoneName", Classes.FNameProperty);
		AddForceAtLocationLocal_IsValid = AddForceAtLocationLocal_FunctionAddress != IntPtr.Zero && AddForceAtLocationLocal_Force_IsValid && AddForceAtLocationLocal_Location_IsValid && AddForceAtLocationLocal_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddForceAtLocationLocal", AddForceAtLocationLocal_IsValid);
		AddForceAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddForceAtLocation");
		AddForceAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(AddForceAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocation_Force_PropertyAddress, AddForceAtLocation_FunctionAddress, "Force");
		AddForceAtLocation_Force_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocation_FunctionAddress, "Force");
		AddForceAtLocation_Force_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocation_FunctionAddress, "Force", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocation_Location_PropertyAddress, AddForceAtLocation_FunctionAddress, "Location");
		AddForceAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocation_FunctionAddress, "Location");
		AddForceAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForceAtLocation_BoneName_PropertyAddress, AddForceAtLocation_FunctionAddress, "BoneName");
		AddForceAtLocation_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddForceAtLocation_FunctionAddress, "BoneName");
		AddForceAtLocation_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForceAtLocation_FunctionAddress, "BoneName", Classes.FNameProperty);
		AddForceAtLocation_IsValid = AddForceAtLocation_FunctionAddress != IntPtr.Zero && AddForceAtLocation_Force_IsValid && AddForceAtLocation_Location_IsValid && AddForceAtLocation_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddForceAtLocation", AddForceAtLocation_IsValid);
		AddForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddForce");
		AddForce_ParamsSize = NativeReflection.GetFunctionParamsSize(AddForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddForce_Force_PropertyAddress, AddForce_FunctionAddress, "Force");
		AddForce_Force_Offset = NativeReflectionCached.GetPropertyOffset(AddForce_FunctionAddress, "Force");
		AddForce_Force_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForce_FunctionAddress, "Force", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForce_BoneName_PropertyAddress, AddForce_FunctionAddress, "BoneName");
		AddForce_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddForce_FunctionAddress, "BoneName");
		AddForce_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForce_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddForce_bAccelChange_PropertyAddress, AddForce_FunctionAddress, "bAccelChange");
		AddForce_bAccelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddForce_FunctionAddress, "bAccelChange");
		AddForce_bAccelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddForce_FunctionAddress, "bAccelChange", Classes.FBoolProperty);
		AddForce_IsValid = AddForce_FunctionAddress != IntPtr.Zero && AddForce_Force_IsValid && AddForce_BoneName_IsValid && AddForce_bAccelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddForce", AddForce_IsValid);
		AddAngularImpulseInRadians_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddAngularImpulseInRadians");
		AddAngularImpulseInRadians_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAngularImpulseInRadians_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInRadians_Impulse_PropertyAddress, AddAngularImpulseInRadians_FunctionAddress, "Impulse");
		AddAngularImpulseInRadians_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInRadians_FunctionAddress, "Impulse");
		AddAngularImpulseInRadians_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInRadians_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInRadians_BoneName_PropertyAddress, AddAngularImpulseInRadians_FunctionAddress, "BoneName");
		AddAngularImpulseInRadians_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInRadians_FunctionAddress, "BoneName");
		AddAngularImpulseInRadians_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInRadians_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInRadians_bVelChange_PropertyAddress, AddAngularImpulseInRadians_FunctionAddress, "bVelChange");
		AddAngularImpulseInRadians_bVelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInRadians_FunctionAddress, "bVelChange");
		AddAngularImpulseInRadians_bVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInRadians_FunctionAddress, "bVelChange", Classes.FBoolProperty);
		AddAngularImpulseInRadians_IsValid = AddAngularImpulseInRadians_FunctionAddress != IntPtr.Zero && AddAngularImpulseInRadians_Impulse_IsValid && AddAngularImpulseInRadians_BoneName_IsValid && AddAngularImpulseInRadians_bVelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddAngularImpulseInRadians", AddAngularImpulseInRadians_IsValid);
		AddAngularImpulseInDegrees_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddAngularImpulseInDegrees");
		AddAngularImpulseInDegrees_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAngularImpulseInDegrees_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInDegrees_Impulse_PropertyAddress, AddAngularImpulseInDegrees_FunctionAddress, "Impulse");
		AddAngularImpulseInDegrees_Impulse_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInDegrees_FunctionAddress, "Impulse");
		AddAngularImpulseInDegrees_Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInDegrees_FunctionAddress, "Impulse", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInDegrees_BoneName_PropertyAddress, AddAngularImpulseInDegrees_FunctionAddress, "BoneName");
		AddAngularImpulseInDegrees_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInDegrees_FunctionAddress, "BoneName");
		AddAngularImpulseInDegrees_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInDegrees_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAngularImpulseInDegrees_bVelChange_PropertyAddress, AddAngularImpulseInDegrees_FunctionAddress, "bVelChange");
		AddAngularImpulseInDegrees_bVelChange_Offset = NativeReflectionCached.GetPropertyOffset(AddAngularImpulseInDegrees_FunctionAddress, "bVelChange");
		AddAngularImpulseInDegrees_bVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAngularImpulseInDegrees_FunctionAddress, "bVelChange", Classes.FBoolProperty);
		AddAngularImpulseInDegrees_IsValid = AddAngularImpulseInDegrees_FunctionAddress != IntPtr.Zero && AddAngularImpulseInDegrees_Impulse_IsValid && AddAngularImpulseInDegrees_BoneName_IsValid && AddAngularImpulseInDegrees_bVelChange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PrimitiveComponent:AddAngularImpulseInDegrees", AddAngularImpulseInDegrees_IsValid);
	}
}
