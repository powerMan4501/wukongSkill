using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938540uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PlayerCameraManager", "Engine", UnrealModuleType.Engine)]
public class APlayerCameraManager : AActor
{
	private static bool TransformComponent_IsValid;

	private static int TransformComponent_Offset;

	private static bool DefaultFOV_IsValid;

	private static int DefaultFOV_Offset;

	private static bool DefaultOrthoWidth_IsValid;

	private static int DefaultOrthoWidth_Offset;

	private static bool DefaultAspectRatio_IsValid;

	private static int DefaultAspectRatio_Offset;

	private static bool DefaultModifiers_IsValid;

	private static FFieldAddress DefaultModifiers_PropertyAddress;

	private static int DefaultModifiers_Offset;

	private TArrayReadOnlyMarshaler<TSubclassOf<UCameraModifier>> DefaultModifiers_MarshalerCached;

	private static bool FreeCamDistance_IsValid;

	private static int FreeCamDistance_Offset;

	private static bool FreeCamOffset_IsValid;

	private static int FreeCamOffset_Offset;

	private static bool ViewTargetOffset_IsValid;

	private static int ViewTargetOffset_Offset;

	private static bool OnAudioFadeChangeEvent_IsValid;

	private static int OnAudioFadeChangeEvent_Offset;

	private FOnAudioFadeChangeSignature OnAudioFadeChangeEvent_DelegateCached;

	private static bool IsOrthographic_IsValid;

	private static FFieldAddress IsOrthographic_PropertyAddress;

	private static int IsOrthographic_Offset;

	private static bool DefaultConstrainAspectRatio_IsValid;

	private static FFieldAddress DefaultConstrainAspectRatio_PropertyAddress;

	private static int DefaultConstrainAspectRatio_Offset;

	private static bool ClientSimulatingViewTarget_IsValid;

	private static FFieldAddress ClientSimulatingViewTarget_PropertyAddress;

	private static int ClientSimulatingViewTarget_Offset;

	private static bool UseClientSideCameraUpdates_IsValid;

	private static FFieldAddress UseClientSideCameraUpdates_PropertyAddress;

	private static int UseClientSideCameraUpdates_Offset;

	private static bool GameCameraCutThisFrame_IsValid;

	private static FFieldAddress GameCameraCutThisFrame_PropertyAddress;

	private static int GameCameraCutThisFrame_Offset;

	private static bool ViewPitchMin_IsValid;

	private static int ViewPitchMin_Offset;

	private static bool ViewPitchMax_IsValid;

	private static int ViewPitchMax_Offset;

	private static bool ViewYawMin_IsValid;

	private static int ViewYawMin_Offset;

	private static bool ViewYawMax_IsValid;

	private static int ViewYawMax_Offset;

	private static bool ViewRollMin_IsValid;

	private static int ViewRollMin_Offset;

	private static bool ViewRollMax_IsValid;

	private static int ViewRollMax_Offset;

	private static bool StopCameraShake_IsValid;

	private static IntPtr StopCameraShake_FunctionAddress;

	private static int StopCameraShake_ParamsSize;

	private static bool StopCameraShake_ShakeInstance_IsValid;

	private static FFieldAddress StopCameraShake_ShakeInstance_PropertyAddress;

	private static int StopCameraShake_ShakeInstance_Offset;

	private static bool StopCameraShake_bImmediately_IsValid;

	private static FFieldAddress StopCameraShake_bImmediately_PropertyAddress;

	private static int StopCameraShake_bImmediately_Offset;

	private static bool StopCameraFade_IsValid;

	private static IntPtr StopCameraFade_FunctionAddress;

	private static int StopCameraFade_ParamsSize;

	private static bool StopCameraAnimInst_IsValid;

	private static IntPtr StopCameraAnimInst_FunctionAddress;

	private static int StopCameraAnimInst_ParamsSize;

	private static bool StopCameraAnimInst_AnimInst_IsValid;

	private static FFieldAddress StopCameraAnimInst_AnimInst_PropertyAddress;

	private static int StopCameraAnimInst_AnimInst_Offset;

	private static bool StopCameraAnimInst_bImmediate_IsValid;

	private static FFieldAddress StopCameraAnimInst_bImmediate_PropertyAddress;

	private static int StopCameraAnimInst_bImmediate_Offset;

	private static bool StopAllInstancesOfCameraShakeFromSource_IsValid;

	private static IntPtr StopAllInstancesOfCameraShakeFromSource_FunctionAddress;

	private static int StopAllInstancesOfCameraShakeFromSource_ParamsSize;

	private static bool StopAllInstancesOfCameraShakeFromSource_Shake_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraShakeFromSource_Shake_PropertyAddress;

	private static int StopAllInstancesOfCameraShakeFromSource_Shake_Offset;

	private static bool StopAllInstancesOfCameraShakeFromSource_SourceComponent_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraShakeFromSource_SourceComponent_PropertyAddress;

	private static int StopAllInstancesOfCameraShakeFromSource_SourceComponent_Offset;

	private static bool StopAllInstancesOfCameraShakeFromSource_bImmediately_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraShakeFromSource_bImmediately_PropertyAddress;

	private static int StopAllInstancesOfCameraShakeFromSource_bImmediately_Offset;

	private static bool StopAllInstancesOfCameraShake_IsValid;

	private static IntPtr StopAllInstancesOfCameraShake_FunctionAddress;

	private static int StopAllInstancesOfCameraShake_ParamsSize;

	private static bool StopAllInstancesOfCameraShake_Shake_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraShake_Shake_PropertyAddress;

	private static int StopAllInstancesOfCameraShake_Shake_Offset;

	private static bool StopAllInstancesOfCameraShake_bImmediately_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraShake_bImmediately_PropertyAddress;

	private static int StopAllInstancesOfCameraShake_bImmediately_Offset;

	private static bool StopAllInstancesOfCameraAnim_IsValid;

	private static IntPtr StopAllInstancesOfCameraAnim_FunctionAddress;

	private static int StopAllInstancesOfCameraAnim_ParamsSize;

	private static bool StopAllInstancesOfCameraAnim_Anim_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraAnim_Anim_PropertyAddress;

	private static int StopAllInstancesOfCameraAnim_Anim_Offset;

	private static bool StopAllInstancesOfCameraAnim_bImmediate_IsValid;

	private static FFieldAddress StopAllInstancesOfCameraAnim_bImmediate_PropertyAddress;

	private static int StopAllInstancesOfCameraAnim_bImmediate_Offset;

	private static bool StopAllCameraShakesFromSource_IsValid;

	private static IntPtr StopAllCameraShakesFromSource_FunctionAddress;

	private static int StopAllCameraShakesFromSource_ParamsSize;

	private static bool StopAllCameraShakesFromSource_SourceComponent_IsValid;

	private static FFieldAddress StopAllCameraShakesFromSource_SourceComponent_PropertyAddress;

	private static int StopAllCameraShakesFromSource_SourceComponent_Offset;

	private static bool StopAllCameraShakesFromSource_bImmediately_IsValid;

	private static FFieldAddress StopAllCameraShakesFromSource_bImmediately_PropertyAddress;

	private static int StopAllCameraShakesFromSource_bImmediately_Offset;

	private static bool StopAllCameraShakes_IsValid;

	private static IntPtr StopAllCameraShakes_FunctionAddress;

	private static int StopAllCameraShakes_ParamsSize;

	private static bool StopAllCameraShakes_bImmediately_IsValid;

	private static FFieldAddress StopAllCameraShakes_bImmediately_PropertyAddress;

	private static int StopAllCameraShakes_bImmediately_Offset;

	private static bool StopAllCameraAnims_IsValid;

	private static IntPtr StopAllCameraAnims_FunctionAddress;

	private static int StopAllCameraAnims_ParamsSize;

	private static bool StopAllCameraAnims_bImmediate_IsValid;

	private static FFieldAddress StopAllCameraAnims_bImmediate_PropertyAddress;

	private static int StopAllCameraAnims_bImmediate_Offset;

	private static bool StartCameraShakeFromSource_IsValid;

	private static IntPtr StartCameraShakeFromSource_FunctionAddress;

	private static int StartCameraShakeFromSource_ParamsSize;

	private static bool StartCameraShakeFromSource_ShakeClass_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_ShakeClass_PropertyAddress;

	private static int StartCameraShakeFromSource_ShakeClass_Offset;

	private static bool StartCameraShakeFromSource_SourceComponent_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_SourceComponent_PropertyAddress;

	private static int StartCameraShakeFromSource_SourceComponent_Offset;

	private static bool StartCameraShakeFromSource_Scale_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_Scale_PropertyAddress;

	private static int StartCameraShakeFromSource_Scale_Offset;

	private static bool StartCameraShakeFromSource_PlaySpace_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_PlaySpace_PropertyAddress;

	private static int StartCameraShakeFromSource_PlaySpace_Offset;

	private static bool StartCameraShakeFromSource_UserPlaySpaceRot_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress;

	private static int StartCameraShakeFromSource_UserPlaySpaceRot_Offset;

	private static bool StartCameraShakeFromSource_ReturnValue_IsValid;

	private static FFieldAddress StartCameraShakeFromSource_ReturnValue_PropertyAddress;

	private static int StartCameraShakeFromSource_ReturnValue_Offset;

	private static bool StartCameraShake_IsValid;

	private static IntPtr StartCameraShake_FunctionAddress;

	private static int StartCameraShake_ParamsSize;

	private static bool StartCameraShake_ShakeClass_IsValid;

	private static FFieldAddress StartCameraShake_ShakeClass_PropertyAddress;

	private static int StartCameraShake_ShakeClass_Offset;

	private static bool StartCameraShake_Scale_IsValid;

	private static FFieldAddress StartCameraShake_Scale_PropertyAddress;

	private static int StartCameraShake_Scale_Offset;

	private static bool StartCameraShake_PlaySpace_IsValid;

	private static FFieldAddress StartCameraShake_PlaySpace_PropertyAddress;

	private static int StartCameraShake_PlaySpace_Offset;

	private static bool StartCameraShake_UserPlaySpaceRot_IsValid;

	private static FFieldAddress StartCameraShake_UserPlaySpaceRot_PropertyAddress;

	private static int StartCameraShake_UserPlaySpaceRot_Offset;

	private static bool StartCameraShake_ReturnValue_IsValid;

	private static FFieldAddress StartCameraShake_ReturnValue_PropertyAddress;

	private static int StartCameraShake_ReturnValue_Offset;

	private static bool StartCameraFade_IsValid;

	private static IntPtr StartCameraFade_FunctionAddress;

	private static int StartCameraFade_ParamsSize;

	private static bool StartCameraFade_FromAlpha_IsValid;

	private static FFieldAddress StartCameraFade_FromAlpha_PropertyAddress;

	private static int StartCameraFade_FromAlpha_Offset;

	private static bool StartCameraFade_ToAlpha_IsValid;

	private static FFieldAddress StartCameraFade_ToAlpha_PropertyAddress;

	private static int StartCameraFade_ToAlpha_Offset;

	private static bool StartCameraFade_Duration_IsValid;

	private static FFieldAddress StartCameraFade_Duration_PropertyAddress;

	private static int StartCameraFade_Duration_Offset;

	private static bool StartCameraFade_Color_IsValid;

	private static FFieldAddress StartCameraFade_Color_PropertyAddress;

	private static int StartCameraFade_Color_Offset;

	private static bool StartCameraFade_bShouldFadeAudio_IsValid;

	private static FFieldAddress StartCameraFade_bShouldFadeAudio_PropertyAddress;

	private static int StartCameraFade_bShouldFadeAudio_Offset;

	private static bool StartCameraFade_bHoldWhenFinished_IsValid;

	private static FFieldAddress StartCameraFade_bHoldWhenFinished_PropertyAddress;

	private static int StartCameraFade_bHoldWhenFinished_Offset;

	private static bool SetManualCameraFade_IsValid;

	private static IntPtr SetManualCameraFade_FunctionAddress;

	private static int SetManualCameraFade_ParamsSize;

	private static bool SetManualCameraFade_InFadeAmount_IsValid;

	private static FFieldAddress SetManualCameraFade_InFadeAmount_PropertyAddress;

	private static int SetManualCameraFade_InFadeAmount_Offset;

	private static bool SetManualCameraFade_Color_IsValid;

	private static FFieldAddress SetManualCameraFade_Color_PropertyAddress;

	private static int SetManualCameraFade_Color_Offset;

	private static bool SetManualCameraFade_bInFadeAudio_IsValid;

	private static FFieldAddress SetManualCameraFade_bInFadeAudio_PropertyAddress;

	private static int SetManualCameraFade_bInFadeAudio_Offset;

	private static bool SetGameCameraCutThisFrame_IsValid;

	private static IntPtr SetGameCameraCutThisFrame_FunctionAddress;

	private static int SetGameCameraCutThisFrame_ParamsSize;

	private static bool RemoveGenericCameraLensEffect_IsValid;

	private static IntPtr RemoveGenericCameraLensEffect_FunctionAddress;

	private static int RemoveGenericCameraLensEffect_ParamsSize;

	private static bool RemoveGenericCameraLensEffect_Emitter_IsValid;

	private static FFieldAddress RemoveGenericCameraLensEffect_Emitter_PropertyAddress;

	private static int RemoveGenericCameraLensEffect_Emitter_Offset;

	private static bool RemoveCameraModifier_IsValid;

	private static IntPtr RemoveCameraModifier_FunctionAddress;

	private static int RemoveCameraModifier_ParamsSize;

	private static bool RemoveCameraModifier_ModifierToRemove_IsValid;

	private static FFieldAddress RemoveCameraModifier_ModifierToRemove_PropertyAddress;

	private static int RemoveCameraModifier_ModifierToRemove_Offset;

	private static bool RemoveCameraModifier_ReturnValue_IsValid;

	private static FFieldAddress RemoveCameraModifier_ReturnValue_PropertyAddress;

	private static int RemoveCameraModifier_ReturnValue_Offset;

	private static bool PlayCameraAnim_IsValid;

	private static IntPtr PlayCameraAnim_FunctionAddress;

	private static int PlayCameraAnim_ParamsSize;

	private static bool PlayCameraAnim_Anim_IsValid;

	private static FFieldAddress PlayCameraAnim_Anim_PropertyAddress;

	private static int PlayCameraAnim_Anim_Offset;

	private static bool PlayCameraAnim_Rate_IsValid;

	private static FFieldAddress PlayCameraAnim_Rate_PropertyAddress;

	private static int PlayCameraAnim_Rate_Offset;

	private static bool PlayCameraAnim_Scale_IsValid;

	private static FFieldAddress PlayCameraAnim_Scale_PropertyAddress;

	private static int PlayCameraAnim_Scale_Offset;

	private static bool PlayCameraAnim_BlendInTime_IsValid;

	private static FFieldAddress PlayCameraAnim_BlendInTime_PropertyAddress;

	private static int PlayCameraAnim_BlendInTime_Offset;

	private static bool PlayCameraAnim_BlendOutTime_IsValid;

	private static FFieldAddress PlayCameraAnim_BlendOutTime_PropertyAddress;

	private static int PlayCameraAnim_BlendOutTime_Offset;

	private static bool PlayCameraAnim_bLoop_IsValid;

	private static FFieldAddress PlayCameraAnim_bLoop_PropertyAddress;

	private static int PlayCameraAnim_bLoop_Offset;

	private static bool PlayCameraAnim_bRandomStartTime_IsValid;

	private static FFieldAddress PlayCameraAnim_bRandomStartTime_PropertyAddress;

	private static int PlayCameraAnim_bRandomStartTime_Offset;

	private static bool PlayCameraAnim_Duration_IsValid;

	private static FFieldAddress PlayCameraAnim_Duration_PropertyAddress;

	private static int PlayCameraAnim_Duration_Offset;

	private static bool PlayCameraAnim_PlaySpace_IsValid;

	private static FFieldAddress PlayCameraAnim_PlaySpace_PropertyAddress;

	private static int PlayCameraAnim_PlaySpace_Offset;

	private static bool PlayCameraAnim_UserPlaySpaceRot_IsValid;

	private static FFieldAddress PlayCameraAnim_UserPlaySpaceRot_PropertyAddress;

	private static int PlayCameraAnim_UserPlaySpaceRot_Offset;

	private static bool PlayCameraAnim_ReturnValue_IsValid;

	private static FFieldAddress PlayCameraAnim_ReturnValue_PropertyAddress;

	private static int PlayCameraAnim_ReturnValue_Offset;

	private static bool PhotographyCameraModify_IsValid;

	private IntPtr PhotographyCameraModify_InstanceFunctionAddress;

	private static IntPtr PhotographyCameraModify_FunctionAddress;

	private static int PhotographyCameraModify_ParamsSize;

	private static bool PhotographyCameraModify_NewCameraLocation_IsValid;

	private static FFieldAddress PhotographyCameraModify_NewCameraLocation_PropertyAddress;

	private static int PhotographyCameraModify_NewCameraLocation_Offset;

	private static bool PhotographyCameraModify_PreviousCameraLocation_IsValid;

	private static FFieldAddress PhotographyCameraModify_PreviousCameraLocation_PropertyAddress;

	private static int PhotographyCameraModify_PreviousCameraLocation_Offset;

	private static bool PhotographyCameraModify_OriginalCameraLocation_IsValid;

	private static FFieldAddress PhotographyCameraModify_OriginalCameraLocation_PropertyAddress;

	private static int PhotographyCameraModify_OriginalCameraLocation_Offset;

	private static bool PhotographyCameraModify_ResultCameraLocation_IsValid;

	private static FFieldAddress PhotographyCameraModify_ResultCameraLocation_PropertyAddress;

	private static int PhotographyCameraModify_ResultCameraLocation_Offset;

	private static bool OnPhotographySessionStart_IsValid;

	private IntPtr OnPhotographySessionStart_InstanceFunctionAddress;

	private static IntPtr OnPhotographySessionStart_FunctionAddress;

	private static int OnPhotographySessionStart_ParamsSize;

	private static bool OnPhotographySessionEnd_IsValid;

	private IntPtr OnPhotographySessionEnd_InstanceFunctionAddress;

	private static IntPtr OnPhotographySessionEnd_FunctionAddress;

	private static int OnPhotographySessionEnd_ParamsSize;

	private static bool OnPhotographyMultiPartCaptureStart_IsValid;

	private IntPtr OnPhotographyMultiPartCaptureStart_InstanceFunctionAddress;

	private static IntPtr OnPhotographyMultiPartCaptureStart_FunctionAddress;

	private static int OnPhotographyMultiPartCaptureStart_ParamsSize;

	private static bool OnPhotographyMultiPartCaptureEnd_IsValid;

	private IntPtr OnPhotographyMultiPartCaptureEnd_InstanceFunctionAddress;

	private static IntPtr OnPhotographyMultiPartCaptureEnd_FunctionAddress;

	private static int OnPhotographyMultiPartCaptureEnd_ParamsSize;

	private static bool GetOwningPlayerController_IsValid;

	private static IntPtr GetOwningPlayerController_FunctionAddress;

	private static int GetOwningPlayerController_ParamsSize;

	private static bool GetOwningPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPlayerController_ReturnValue_PropertyAddress;

	private static int GetOwningPlayerController_ReturnValue_Offset;

	private static bool GetFOVAngle_IsValid;

	private static IntPtr GetFOVAngle_FunctionAddress;

	private static int GetFOVAngle_ParamsSize;

	private static bool GetFOVAngle_ReturnValue_IsValid;

	private static FFieldAddress GetFOVAngle_ReturnValue_PropertyAddress;

	private static int GetFOVAngle_ReturnValue_Offset;

	private static bool GetCameraRotation_IsValid;

	private static IntPtr GetCameraRotation_FunctionAddress;

	private static int GetCameraRotation_ParamsSize;

	private static bool GetCameraRotation_ReturnValue_IsValid;

	private static FFieldAddress GetCameraRotation_ReturnValue_PropertyAddress;

	private static int GetCameraRotation_ReturnValue_Offset;

	private static bool GetCameraLocation_IsValid;

	private static IntPtr GetCameraLocation_FunctionAddress;

	private static int GetCameraLocation_ParamsSize;

	private static bool GetCameraLocation_ReturnValue_IsValid;

	private static FFieldAddress GetCameraLocation_ReturnValue_PropertyAddress;

	private static int GetCameraLocation_ReturnValue_Offset;

	private static bool FindCameraModifierByClass_IsValid;

	private static IntPtr FindCameraModifierByClass_FunctionAddress;

	private static int FindCameraModifierByClass_ParamsSize;

	private static bool FindCameraModifierByClass_ModifierClass_IsValid;

	private static FFieldAddress FindCameraModifierByClass_ModifierClass_PropertyAddress;

	private static int FindCameraModifierByClass_ModifierClass_Offset;

	private static bool FindCameraModifierByClass_ReturnValue_IsValid;

	private static FFieldAddress FindCameraModifierByClass_ReturnValue_PropertyAddress;

	private static int FindCameraModifierByClass_ReturnValue_Offset;

	private static bool ClearCameraLensEffects_IsValid;

	private static IntPtr ClearCameraLensEffects_FunctionAddress;

	private static int ClearCameraLensEffects_ParamsSize;

	private static bool BlueprintUpdateCamera_IsValid;

	private IntPtr BlueprintUpdateCamera_InstanceFunctionAddress;

	private static IntPtr BlueprintUpdateCamera_FunctionAddress;

	private static int BlueprintUpdateCamera_ParamsSize;

	private static bool BlueprintUpdateCamera_CameraTarget_IsValid;

	private static FFieldAddress BlueprintUpdateCamera_CameraTarget_PropertyAddress;

	private static int BlueprintUpdateCamera_CameraTarget_Offset;

	private static bool BlueprintUpdateCamera_NewCameraLocation_IsValid;

	private static FFieldAddress BlueprintUpdateCamera_NewCameraLocation_PropertyAddress;

	private static int BlueprintUpdateCamera_NewCameraLocation_Offset;

	private static bool BlueprintUpdateCamera_NewCameraRotation_IsValid;

	private static FFieldAddress BlueprintUpdateCamera_NewCameraRotation_PropertyAddress;

	private static int BlueprintUpdateCamera_NewCameraRotation_Offset;

	private static bool BlueprintUpdateCamera_NewCameraFOV_IsValid;

	private static FFieldAddress BlueprintUpdateCamera_NewCameraFOV_PropertyAddress;

	private static int BlueprintUpdateCamera_NewCameraFOV_Offset;

	private static bool BlueprintUpdateCamera_ReturnValue_IsValid;

	private static FFieldAddress BlueprintUpdateCamera_ReturnValue_PropertyAddress;

	private static int BlueprintUpdateCamera_ReturnValue_Offset;

	private static bool AddNewCameraModifier_IsValid;

	private static IntPtr AddNewCameraModifier_FunctionAddress;

	private static int AddNewCameraModifier_ParamsSize;

	private static bool AddNewCameraModifier_ModifierClass_IsValid;

	private static FFieldAddress AddNewCameraModifier_ModifierClass_PropertyAddress;

	private static int AddNewCameraModifier_ModifierClass_Offset;

	private static bool AddNewCameraModifier_ReturnValue_IsValid;

	private static FFieldAddress AddNewCameraModifier_ReturnValue_PropertyAddress;

	private static int AddNewCameraModifier_ReturnValue_Offset;

	private static bool AddGenericCameraLensEffect_IsValid;

	private static IntPtr AddGenericCameraLensEffect_FunctionAddress;

	private static int AddGenericCameraLensEffect_ParamsSize;

	private static bool AddGenericCameraLensEffect_LensEffectEmitterClass_IsValid;

	private static FFieldAddress AddGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress;

	private static int AddGenericCameraLensEffect_LensEffectEmitterClass_Offset;

	private static bool AddGenericCameraLensEffect_ReturnValue_IsValid;

	private static FFieldAddress AddGenericCameraLensEffect_ReturnValue_PropertyAddress;

	private static int AddGenericCameraLensEffect_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:TransformComponent")]
	public USceneComponent TransformComponent
	{
		get
		{
			CheckDestroyed();
			if (!TransformComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:TransformComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, TransformComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransformComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:TransformComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, TransformComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:DefaultFOV")]
	public float DefaultFOV
	{
		get
		{
			CheckDestroyed();
			if (!DefaultFOV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultFOV");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultFOV_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultFOV_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultFOV");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultFOV_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:DefaultOrthoWidth")]
	public float DefaultOrthoWidth
	{
		get
		{
			CheckDestroyed();
			if (!DefaultOrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultOrthoWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultOrthoWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultOrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultOrthoWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultOrthoWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:DefaultAspectRatio")]
	public float DefaultAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!DefaultAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534279189uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:DefaultModifiers")]
	protected TArrayReadOnly<TSubclassOf<UCameraModifier>> DefaultModifiers
	{
		get
		{
			CheckDestroyed();
			if (!DefaultModifiers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:DefaultModifiers");
				return null;
			}
			if (DefaultModifiers_MarshalerCached == null)
			{
				DefaultModifiers_MarshalerCached = new TArrayReadOnlyMarshaler<TSubclassOf<UCameraModifier>>(1, DefaultModifiers_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UCameraModifier>, TSubclassOfMarshaler<UCameraModifier>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UCameraModifier>, TSubclassOfMarshaler<UCameraModifier>>.ToNative);
			}
			return DefaultModifiers_MarshalerCached.FromNative(IntPtr.Add(base.Address, DefaultModifiers_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:FreeCamDistance")]
	public float FreeCamDistance
	{
		get
		{
			CheckDestroyed();
			if (!FreeCamDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:FreeCamDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FreeCamDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeCamDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:FreeCamDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FreeCamDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:FreeCamOffset")]
	public FVector FreeCamOffset
	{
		get
		{
			CheckDestroyed();
			if (!FreeCamOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:FreeCamOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, FreeCamOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FreeCamOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:FreeCamOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, FreeCamOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewTargetOffset")]
	public FVector ViewTargetOffset
	{
		get
		{
			CheckDestroyed();
			if (!ViewTargetOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewTargetOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ViewTargetOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewTargetOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewTargetOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ViewTargetOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896338944uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:OnAudioFadeChangeEvent")]
	public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioFadeChangeEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:OnAudioFadeChangeEvent");
				return new FOnAudioFadeChangeSignature();
			}
			if (OnAudioFadeChangeEvent_DelegateCached == null)
			{
				OnAudioFadeChangeEvent_DelegateCached = new FOnAudioFadeChangeSignature();
				OnAudioFadeChangeEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioFadeChangeEvent_Offset));
			}
			return OnAudioFadeChangeEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:bIsOrthographic")]
	public bool IsOrthographic
	{
		get
		{
			CheckDestroyed();
			if (!IsOrthographic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bIsOrthographic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOrthographic_Offset), 0, IsOrthographic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOrthographic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bIsOrthographic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOrthographic_Offset), 0, IsOrthographic_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:bDefaultConstrainAspectRatio")]
	public bool DefaultConstrainAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!DefaultConstrainAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bDefaultConstrainAspectRatio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DefaultConstrainAspectRatio_Offset), 0, DefaultConstrainAspectRatio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultConstrainAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bDefaultConstrainAspectRatio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DefaultConstrainAspectRatio_Offset), 0, DefaultConstrainAspectRatio_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:bClientSimulatingViewTarget")]
	public bool ClientSimulatingViewTarget
	{
		get
		{
			CheckDestroyed();
			if (!ClientSimulatingViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bClientSimulatingViewTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClientSimulatingViewTarget_Offset), 0, ClientSimulatingViewTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClientSimulatingViewTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bClientSimulatingViewTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClientSimulatingViewTarget_Offset), 0, ClientSimulatingViewTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:bUseClientSideCameraUpdates")]
	public bool UseClientSideCameraUpdates
	{
		get
		{
			CheckDestroyed();
			if (!UseClientSideCameraUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bUseClientSideCameraUpdates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseClientSideCameraUpdates_Offset), 0, UseClientSideCameraUpdates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseClientSideCameraUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bUseClientSideCameraUpdates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseClientSideCameraUpdates_Offset), 0, UseClientSideCameraUpdates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160540692uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:bGameCameraCutThisFrame")]
	public bool GameCameraCutThisFrame
	{
		get
		{
			CheckDestroyed();
			if (!GameCameraCutThisFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bGameCameraCutThisFrame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GameCameraCutThisFrame_Offset), 0, GameCameraCutThisFrame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GameCameraCutThisFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:bGameCameraCutThisFrame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GameCameraCutThisFrame_Offset), 0, GameCameraCutThisFrame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewPitchMin")]
	public float ViewPitchMin
	{
		get
		{
			CheckDestroyed();
			if (!ViewPitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewPitchMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewPitchMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewPitchMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewPitchMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewPitchMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewPitchMax")]
	public float ViewPitchMax
	{
		get
		{
			CheckDestroyed();
			if (!ViewPitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewPitchMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewPitchMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewPitchMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewPitchMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewPitchMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewYawMin")]
	public float ViewYawMin
	{
		get
		{
			CheckDestroyed();
			if (!ViewYawMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewYawMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewYawMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewYawMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewYawMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewYawMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewYawMax")]
	public float ViewYawMax
	{
		get
		{
			CheckDestroyed();
			if (!ViewYawMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewYawMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewYawMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewYawMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewYawMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewYawMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewRollMin")]
	public float ViewRollMin
	{
		get
		{
			CheckDestroyed();
			if (!ViewRollMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewRollMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewRollMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewRollMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewRollMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewRollMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ViewRollMax")]
	public float ViewRollMax
	{
		get
		{
			CheckDestroyed();
			if (!ViewRollMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewRollMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewRollMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewRollMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerCameraManager:ViewRollMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewRollMax_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopCameraShake")]
	public unsafe void StopCameraShake(UCameraShakeBase ShakeInstance, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StopCameraShake_ShakeInstance_Offset), 0, StopCameraShake_ShakeInstance_PropertyAddress.Address, ShakeInstance);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopCameraShake_bImmediately_Offset), 0, StopCameraShake_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopCameraShake_FunctionAddress, intPtr, StopCameraShake_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopCameraFade")]
	public unsafe void StopCameraFade()
	{
		CheckDestroyed();
		if (!StopCameraFade_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopCameraFade");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCameraFade_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCameraFade_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopCameraFade_FunctionAddress, argsSize: StopCameraFade_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopCameraAnimInst")]
	public unsafe void StopCameraAnimInst(UCameraAnimInst AnimInst, bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopCameraAnimInst_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopCameraAnimInst");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCameraAnimInst_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCameraAnimInst_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnimInst>.ToNative(IntPtr.Add(intPtr, StopCameraAnimInst_AnimInst_Offset), 0, StopCameraAnimInst_AnimInst_PropertyAddress.Address, AnimInst);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopCameraAnimInst_bImmediate_Offset), 0, StopCameraAnimInst_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopCameraAnimInst_FunctionAddress, intPtr, StopCameraAnimInst_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShakeFromSource")]
	public unsafe void StopAllInstancesOfCameraShakeFromSource(TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllInstancesOfCameraShakeFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShakeFromSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllInstancesOfCameraShakeFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllInstancesOfCameraShakeFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraShakeFromSource_Shake_Offset), 0, StopAllInstancesOfCameraShakeFromSource_Shake_PropertyAddress.Address, Shake);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraShakeFromSource_SourceComponent_Offset), 0, StopAllInstancesOfCameraShakeFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraShakeFromSource_bImmediately_Offset), 0, StopAllInstancesOfCameraShakeFromSource_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllInstancesOfCameraShakeFromSource_FunctionAddress, intPtr, StopAllInstancesOfCameraShakeFromSource_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShake")]
	public unsafe void StopAllInstancesOfCameraShake(TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllInstancesOfCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllInstancesOfCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllInstancesOfCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraShake_Shake_Offset), 0, StopAllInstancesOfCameraShake_Shake_PropertyAddress.Address, Shake);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraShake_bImmediately_Offset), 0, StopAllInstancesOfCameraShake_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllInstancesOfCameraShake_FunctionAddress, intPtr, StopAllInstancesOfCameraShake_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraAnim")]
	public unsafe void StopAllInstancesOfCameraAnim(UCameraAnim Anim, bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopAllInstancesOfCameraAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllInstancesOfCameraAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllInstancesOfCameraAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnim>.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraAnim_Anim_Offset), 0, StopAllInstancesOfCameraAnim_Anim_PropertyAddress.Address, Anim);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllInstancesOfCameraAnim_bImmediate_Offset), 0, StopAllInstancesOfCameraAnim_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllInstancesOfCameraAnim_FunctionAddress, intPtr, StopAllInstancesOfCameraAnim_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllCameraShakesFromSource")]
	public unsafe void StopAllCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllCameraShakesFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllCameraShakesFromSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraShakesFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraShakesFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, StopAllCameraShakesFromSource_SourceComponent_Offset), 0, StopAllCameraShakesFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraShakesFromSource_bImmediately_Offset), 0, StopAllCameraShakesFromSource_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraShakesFromSource_FunctionAddress, intPtr, StopAllCameraShakesFromSource_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllCameraShakes")]
	public unsafe void StopAllCameraShakes(bool bImmediately = true)
	{
		CheckDestroyed();
		if (!StopAllCameraShakes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllCameraShakes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraShakes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraShakes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraShakes_bImmediately_Offset), 0, StopAllCameraShakes_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraShakes_FunctionAddress, intPtr, StopAllCameraShakes_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StopAllCameraAnims")]
	public unsafe void StopAllCameraAnims(bool bImmediate = false)
	{
		CheckDestroyed();
		if (!StopAllCameraAnims_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StopAllCameraAnims");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllCameraAnims_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllCameraAnims_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StopAllCameraAnims_bImmediate_Offset), 0, StopAllCameraAnims_bImmediate_PropertyAddress.Address, bImmediate);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAllCameraAnims_FunctionAddress, intPtr, StopAllCameraAnims_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StartCameraShakeFromSource")]
	public unsafe UCameraShakeBase StartCameraShakeFromSource(TSubclassOf<UCameraShakeBase> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		CheckDestroyed();
		if (!StartCameraShakeFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StartCameraShakeFromSource");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCameraShakeFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCameraShakeFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_ShakeClass_Offset), 0, StartCameraShakeFromSource_ShakeClass_PropertyAddress.Address, ShakeClass);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_SourceComponent_Offset), 0, StartCameraShakeFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_Scale_Offset), 0, StartCameraShakeFromSource_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_PlaySpace_Offset), 0, StartCameraShakeFromSource_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_UserPlaySpaceRot_Offset), 0, StartCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartCameraShakeFromSource_FunctionAddress, intPtr, StartCameraShakeFromSource_ParamsSize);
		return UObjectMarshaler<UCameraShakeBase>.FromNative(IntPtr.Add(intPtr, StartCameraShakeFromSource_ReturnValue_Offset), 0, StartCameraShakeFromSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StartCameraShake")]
	public unsafe UCameraShakeBase StartCameraShake(TSubclassOf<UCameraShakeBase> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		CheckDestroyed();
		if (!StartCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StartCameraShake");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, StartCameraShake_ShakeClass_Offset), 0, StartCameraShake_ShakeClass_PropertyAddress.Address, ShakeClass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraShake_Scale_Offset), 0, StartCameraShake_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, StartCameraShake_PlaySpace_Offset), 0, StartCameraShake_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, StartCameraShake_UserPlaySpaceRot_Offset), 0, StartCameraShake_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartCameraShake_FunctionAddress, intPtr, StartCameraShake_ParamsSize);
		return UObjectMarshaler<UCameraShakeBase>.FromNative(IntPtr.Add(intPtr, StartCameraShake_ReturnValue_Offset), 0, StartCameraShake_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:StartCameraFade")]
	public unsafe void StartCameraFade(float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio = false, bool bHoldWhenFinished = false)
	{
		CheckDestroyed();
		if (!StartCameraFade_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:StartCameraFade");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCameraFade_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCameraFade_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraFade_FromAlpha_Offset), 0, StartCameraFade_FromAlpha_PropertyAddress.Address, FromAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraFade_ToAlpha_Offset), 0, StartCameraFade_ToAlpha_PropertyAddress.Address, ToAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartCameraFade_Duration_Offset), 0, StartCameraFade_Duration_PropertyAddress.Address, Duration);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, StartCameraFade_Color_Offset), 0, StartCameraFade_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StartCameraFade_bShouldFadeAudio_Offset), 0, StartCameraFade_bShouldFadeAudio_PropertyAddress.Address, bShouldFadeAudio);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, StartCameraFade_bHoldWhenFinished_Offset), 0, StartCameraFade_bHoldWhenFinished_PropertyAddress.Address, bHoldWhenFinished);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartCameraFade_FunctionAddress, intPtr, StartCameraFade_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:SetManualCameraFade")]
	public unsafe void SetManualCameraFade(float InFadeAmount, FLinearColor Color, bool bInFadeAudio)
	{
		CheckDestroyed();
		if (!SetManualCameraFade_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:SetManualCameraFade");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetManualCameraFade_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetManualCameraFade_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetManualCameraFade_InFadeAmount_Offset), 0, SetManualCameraFade_InFadeAmount_PropertyAddress.Address, InFadeAmount);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetManualCameraFade_Color_Offset), 0, SetManualCameraFade_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetManualCameraFade_bInFadeAudio_Offset), 0, SetManualCameraFade_bInFadeAudio_PropertyAddress.Address, bInFadeAudio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetManualCameraFade_FunctionAddress, intPtr, SetManualCameraFade_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:SetGameCameraCutThisFrame")]
	public unsafe void SetGameCameraCutThisFrame()
	{
		CheckDestroyed();
		if (!SetGameCameraCutThisFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:SetGameCameraCutThisFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGameCameraCutThisFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGameCameraCutThisFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetGameCameraCutThisFrame_FunctionAddress, argsSize: SetGameCameraCutThisFrame_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:RemoveGenericCameraLensEffect")]
	public unsafe void RemoveGenericCameraLensEffect(ICameraLensEffectInterface Emitter)
	{
		CheckDestroyed();
		if (!RemoveGenericCameraLensEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:RemoveGenericCameraLensEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGenericCameraLensEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGenericCameraLensEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<ICameraLensEffectInterface>.ToNative(IntPtr.Add(intPtr, RemoveGenericCameraLensEffect_Emitter_Offset), 0, RemoveGenericCameraLensEffect_Emitter_PropertyAddress.Address, Emitter);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveGenericCameraLensEffect_FunctionAddress, intPtr, RemoveGenericCameraLensEffect_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:RemoveCameraModifier")]
	public unsafe bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
	{
		CheckDestroyed();
		if (!RemoveCameraModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:RemoveCameraModifier");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCameraModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCameraModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraModifier>.ToNative(IntPtr.Add(intPtr, RemoveCameraModifier_ModifierToRemove_Offset), 0, RemoveCameraModifier_ModifierToRemove_PropertyAddress.Address, ModifierToRemove);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCameraModifier_FunctionAddress, intPtr, RemoveCameraModifier_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCameraModifier_ReturnValue_Offset), 0, RemoveCameraModifier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:PlayCameraAnim")]
	public unsafe UCameraAnimInst PlayCameraAnim(UCameraAnim Anim, float Rate = 1f, float Scale = 1f, float BlendInTime = 0f, float BlendOutTime = 0f, bool bLoop = false, bool bRandomStartTime = false, float Duration = 0f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		CheckDestroyed();
		if (!PlayCameraAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:PlayCameraAnim");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayCameraAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayCameraAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnim>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_Anim_Offset), 0, PlayCameraAnim_Anim_PropertyAddress.Address, Anim);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_Rate_Offset), 0, PlayCameraAnim_Rate_PropertyAddress.Address, Rate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_Scale_Offset), 0, PlayCameraAnim_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_BlendInTime_Offset), 0, PlayCameraAnim_BlendInTime_PropertyAddress.Address, BlendInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_BlendOutTime_Offset), 0, PlayCameraAnim_BlendOutTime_PropertyAddress.Address, BlendOutTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_bLoop_Offset), 0, PlayCameraAnim_bLoop_PropertyAddress.Address, bLoop);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_bRandomStartTime_Offset), 0, PlayCameraAnim_bRandomStartTime_PropertyAddress.Address, bRandomStartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_Duration_Offset), 0, PlayCameraAnim_Duration_PropertyAddress.Address, Duration);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_PlaySpace_Offset), 0, PlayCameraAnim_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, PlayCameraAnim_UserPlaySpaceRot_Offset), 0, PlayCameraAnim_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayCameraAnim_FunctionAddress, intPtr, PlayCameraAnim_ParamsSize);
		return UObjectMarshaler<UCameraAnimInst>.FromNative(IntPtr.Add(intPtr, PlayCameraAnim_ReturnValue_Offset), 0, PlayCameraAnim_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 146934792u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:PhotographyCameraModify")]
	public unsafe void PhotographyCameraModify(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, out FVector ResultCameraLocation)
	{
		CheckDestroyed();
		if (!PhotographyCameraModify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:PhotographyCameraModify");
			ResultCameraLocation = default(FVector);
			return;
		}
		if (PhotographyCameraModify_InstanceFunctionAddress == IntPtr.Zero)
		{
			PhotographyCameraModify_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PhotographyCameraModify");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PhotographyCameraModify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PhotographyCameraModify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_NewCameraLocation_Offset), 0, PhotographyCameraModify_NewCameraLocation_PropertyAddress.Address, NewCameraLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_PreviousCameraLocation_Offset), 0, PhotographyCameraModify_PreviousCameraLocation_PropertyAddress.Address, PreviousCameraLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_OriginalCameraLocation_Offset), 0, PhotographyCameraModify_OriginalCameraLocation_PropertyAddress.Address, OriginalCameraLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, PhotographyCameraModify_InstanceFunctionAddress, intPtr, PhotographyCameraModify_ParamsSize);
		ResultCameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, PhotographyCameraModify_ResultCameraLocation_Offset), 0, PhotographyCameraModify_ResultCameraLocation_PropertyAddress.Address);
	}

	protected unsafe virtual void PhotographyCameraModify_Implementation(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, out FVector ResultCameraLocation)
	{
		CheckDestroyed();
		if (!PhotographyCameraModify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:PhotographyCameraModify");
			ResultCameraLocation = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PhotographyCameraModify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PhotographyCameraModify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_NewCameraLocation_Offset), 0, PhotographyCameraModify_NewCameraLocation_PropertyAddress.Address, NewCameraLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_PreviousCameraLocation_Offset), 0, PhotographyCameraModify_PreviousCameraLocation_PropertyAddress.Address, PreviousCameraLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PhotographyCameraModify_OriginalCameraLocation_Offset), 0, PhotographyCameraModify_OriginalCameraLocation_PropertyAddress.Address, OriginalCameraLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, PhotographyCameraModify_FunctionAddress, intPtr, PhotographyCameraModify_ParamsSize);
		ResultCameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, PhotographyCameraModify_ResultCameraLocation_Offset), 0, PhotographyCameraModify_ResultCameraLocation_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:OnPhotographySessionStart")]
	public unsafe void OnPhotographySessionStart()
	{
		CheckDestroyed();
		if (!OnPhotographySessionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographySessionStart");
			return;
		}
		if (OnPhotographySessionStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPhotographySessionStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPhotographySessionStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographySessionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographySessionStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographySessionStart_InstanceFunctionAddress, argsSize: OnPhotographySessionStart_ParamsSize);
	}

	protected unsafe virtual void OnPhotographySessionStart_Implementation()
	{
		CheckDestroyed();
		if (!OnPhotographySessionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographySessionStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographySessionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographySessionStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographySessionStart_FunctionAddress, argsSize: OnPhotographySessionStart_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:OnPhotographySessionEnd")]
	public unsafe void OnPhotographySessionEnd()
	{
		CheckDestroyed();
		if (!OnPhotographySessionEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographySessionEnd");
			return;
		}
		if (OnPhotographySessionEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPhotographySessionEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPhotographySessionEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographySessionEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographySessionEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographySessionEnd_InstanceFunctionAddress, argsSize: OnPhotographySessionEnd_ParamsSize);
	}

	protected unsafe virtual void OnPhotographySessionEnd_Implementation()
	{
		CheckDestroyed();
		if (!OnPhotographySessionEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographySessionEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographySessionEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographySessionEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographySessionEnd_FunctionAddress, argsSize: OnPhotographySessionEnd_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureStart")]
	public unsafe void OnPhotographyMultiPartCaptureStart()
	{
		CheckDestroyed();
		if (!OnPhotographyMultiPartCaptureStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureStart");
			return;
		}
		if (OnPhotographyMultiPartCaptureStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPhotographyMultiPartCaptureStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPhotographyMultiPartCaptureStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographyMultiPartCaptureStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographyMultiPartCaptureStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographyMultiPartCaptureStart_InstanceFunctionAddress, argsSize: OnPhotographyMultiPartCaptureStart_ParamsSize);
	}

	protected unsafe virtual void OnPhotographyMultiPartCaptureStart_Implementation()
	{
		CheckDestroyed();
		if (!OnPhotographyMultiPartCaptureStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographyMultiPartCaptureStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographyMultiPartCaptureStart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographyMultiPartCaptureStart_FunctionAddress, argsSize: OnPhotographyMultiPartCaptureStart_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureEnd")]
	public unsafe void OnPhotographyMultiPartCaptureEnd()
	{
		CheckDestroyed();
		if (!OnPhotographyMultiPartCaptureEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureEnd");
			return;
		}
		if (OnPhotographyMultiPartCaptureEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPhotographyMultiPartCaptureEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPhotographyMultiPartCaptureEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographyMultiPartCaptureEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographyMultiPartCaptureEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographyMultiPartCaptureEnd_InstanceFunctionAddress, argsSize: OnPhotographyMultiPartCaptureEnd_ParamsSize);
	}

	protected unsafe virtual void OnPhotographyMultiPartCaptureEnd_Implementation()
	{
		CheckDestroyed();
		if (!OnPhotographyMultiPartCaptureEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPhotographyMultiPartCaptureEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPhotographyMultiPartCaptureEnd_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPhotographyMultiPartCaptureEnd_FunctionAddress, argsSize: OnPhotographyMultiPartCaptureEnd_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:GetOwningPlayerController")]
	public unsafe APlayerController GetOwningPlayerController()
	{
		CheckDestroyed();
		if (!GetOwningPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:GetOwningPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPlayerController_FunctionAddress, intPtr, GetOwningPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetOwningPlayerController_ReturnValue_Offset), 0, GetOwningPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:GetFOVAngle")]
	public unsafe float GetFOVAngle()
	{
		CheckDestroyed();
		if (!GetFOVAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:GetFOVAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFOVAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFOVAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFOVAngle_FunctionAddress, intPtr, GetFOVAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFOVAngle_ReturnValue_Offset), 0, GetFOVAngle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:GetCameraRotation")]
	public unsafe FRotator GetCameraRotation()
	{
		CheckDestroyed();
		if (!GetCameraRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:GetCameraRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraRotation_FunctionAddress, intPtr, GetCameraRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetCameraRotation_ReturnValue_Offset), 0, GetCameraRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:GetCameraLocation")]
	public unsafe FVector GetCameraLocation()
	{
		CheckDestroyed();
		if (!GetCameraLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:GetCameraLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraLocation_FunctionAddress, intPtr, GetCameraLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetCameraLocation_ReturnValue_Offset), 0, GetCameraLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:FindCameraModifierByClass")]
	public unsafe UCameraModifier FindCameraModifierByClass(TSubclassOf<UCameraModifier> ModifierClass)
	{
		CheckDestroyed();
		if (!FindCameraModifierByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:FindCameraModifierByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindCameraModifierByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindCameraModifierByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraModifier>.ToNative(IntPtr.Add(intPtr, FindCameraModifierByClass_ModifierClass_Offset), 0, FindCameraModifierByClass_ModifierClass_PropertyAddress.Address, ModifierClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindCameraModifierByClass_FunctionAddress, intPtr, FindCameraModifierByClass_ParamsSize);
		return UObjectMarshaler<UCameraModifier>.FromNative(IntPtr.Add(intPtr, FindCameraModifierByClass_ReturnValue_Offset), 0, FindCameraModifierByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:ClearCameraLensEffects")]
	public unsafe void ClearCameraLensEffects()
	{
		CheckDestroyed();
		if (!ClearCameraLensEffects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:ClearCameraLensEffects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearCameraLensEffects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearCameraLensEffects_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearCameraLensEffects_FunctionAddress, argsSize: ClearCameraLensEffects_ParamsSize);
	}

	[UFunction(Flags = 146933768u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:BlueprintUpdateCamera")]
	public unsafe bool BlueprintUpdateCamera(AActor CameraTarget, out FVector NewCameraLocation, out FRotator NewCameraRotation, out float NewCameraFOV)
	{
		CheckDestroyed();
		if (!BlueprintUpdateCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:BlueprintUpdateCamera");
			NewCameraLocation = default(FVector);
			NewCameraRotation = default(FRotator);
			NewCameraFOV = 0f;
			return false;
		}
		if (BlueprintUpdateCamera_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintUpdateCamera_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintUpdateCamera");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintUpdateCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintUpdateCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_CameraTarget_Offset), 0, BlueprintUpdateCamera_CameraTarget_PropertyAddress.Address, CameraTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintUpdateCamera_InstanceFunctionAddress, intPtr, BlueprintUpdateCamera_ParamsSize);
		NewCameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraLocation_Offset), 0, BlueprintUpdateCamera_NewCameraLocation_PropertyAddress.Address);
		NewCameraRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraRotation_Offset), 0, BlueprintUpdateCamera_NewCameraRotation_PropertyAddress.Address);
		NewCameraFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraFOV_Offset), 0, BlueprintUpdateCamera_NewCameraFOV_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_ReturnValue_Offset), 0, BlueprintUpdateCamera_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool BlueprintUpdateCamera_Implementation(AActor CameraTarget, out FVector NewCameraLocation, out FRotator NewCameraRotation, out float NewCameraFOV)
	{
		CheckDestroyed();
		if (!BlueprintUpdateCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:BlueprintUpdateCamera");
			NewCameraLocation = default(FVector);
			NewCameraRotation = default(FRotator);
			NewCameraFOV = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintUpdateCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintUpdateCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_CameraTarget_Offset), 0, BlueprintUpdateCamera_CameraTarget_PropertyAddress.Address, CameraTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintUpdateCamera_FunctionAddress, intPtr, BlueprintUpdateCamera_ParamsSize);
		NewCameraLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraLocation_Offset), 0, BlueprintUpdateCamera_NewCameraLocation_PropertyAddress.Address);
		NewCameraRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraRotation_Offset), 0, BlueprintUpdateCamera_NewCameraRotation_PropertyAddress.Address);
		NewCameraFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_NewCameraFOV_Offset), 0, BlueprintUpdateCamera_NewCameraFOV_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BlueprintUpdateCamera_ReturnValue_Offset), 0, BlueprintUpdateCamera_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:AddNewCameraModifier")]
	public unsafe UCameraModifier AddNewCameraModifier(TSubclassOf<UCameraModifier> ModifierClass)
	{
		CheckDestroyed();
		if (!AddNewCameraModifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:AddNewCameraModifier");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewCameraModifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewCameraModifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraModifier>.ToNative(IntPtr.Add(intPtr, AddNewCameraModifier_ModifierClass_Offset), 0, AddNewCameraModifier_ModifierClass_PropertyAddress.Address, ModifierClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNewCameraModifier_FunctionAddress, intPtr, AddNewCameraModifier_ParamsSize);
		return UObjectMarshaler<UCameraModifier>.FromNative(IntPtr.Add(intPtr, AddNewCameraModifier_ReturnValue_Offset), 0, AddNewCameraModifier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerCameraManager:AddGenericCameraLensEffect")]
	public unsafe ICameraLensEffectInterface AddGenericCameraLensEffect(TSubclassOf<AActor> LensEffectEmitterClass)
	{
		CheckDestroyed();
		if (!AddGenericCameraLensEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerCameraManager:AddGenericCameraLensEffect");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGenericCameraLensEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGenericCameraLensEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddGenericCameraLensEffect_LensEffectEmitterClass_Offset), 0, AddGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress.Address, LensEffectEmitterClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGenericCameraLensEffect_FunctionAddress, intPtr, AddGenericCameraLensEffect_ParamsSize);
		return InterfaceMarshaler<ICameraLensEffectInterface>.FromNative(IntPtr.Add(intPtr, AddGenericCameraLensEffect_ReturnValue_Offset), 0, AddGenericCameraLensEffect_ReturnValue_PropertyAddress.Address);
	}

	static APlayerCameraManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APlayerCameraManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APlayerCameraManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PlayerCameraManager");
		TransformComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformComponent");
		TransformComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformComponent", Classes.FObjectProperty);
		DefaultFOV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultFOV");
		DefaultFOV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultFOV", Classes.FFloatProperty);
		DefaultOrthoWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultOrthoWidth");
		DefaultOrthoWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultOrthoWidth", Classes.FFloatProperty);
		DefaultAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultAspectRatio");
		DefaultAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultAspectRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultModifiers_PropertyAddress, intPtr, "DefaultModifiers");
		DefaultModifiers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultModifiers");
		DefaultModifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultModifiers", Classes.FArrayProperty);
		FreeCamDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreeCamDistance");
		FreeCamDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreeCamDistance", Classes.FFloatProperty);
		FreeCamOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FreeCamOffset");
		FreeCamOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FreeCamOffset", Classes.FStructProperty);
		ViewTargetOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewTargetOffset");
		ViewTargetOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewTargetOffset", Classes.FStructProperty);
		OnAudioFadeChangeEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioFadeChangeEvent");
		OnAudioFadeChangeEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioFadeChangeEvent", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOrthographic_PropertyAddress, intPtr, "bIsOrthographic");
		IsOrthographic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsOrthographic");
		IsOrthographic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsOrthographic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultConstrainAspectRatio_PropertyAddress, intPtr, "bDefaultConstrainAspectRatio");
		DefaultConstrainAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDefaultConstrainAspectRatio");
		DefaultConstrainAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDefaultConstrainAspectRatio", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientSimulatingViewTarget_PropertyAddress, intPtr, "bClientSimulatingViewTarget");
		ClientSimulatingViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClientSimulatingViewTarget");
		ClientSimulatingViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClientSimulatingViewTarget", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseClientSideCameraUpdates_PropertyAddress, intPtr, "bUseClientSideCameraUpdates");
		UseClientSideCameraUpdates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseClientSideCameraUpdates");
		UseClientSideCameraUpdates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseClientSideCameraUpdates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GameCameraCutThisFrame_PropertyAddress, intPtr, "bGameCameraCutThisFrame");
		GameCameraCutThisFrame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGameCameraCutThisFrame");
		GameCameraCutThisFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGameCameraCutThisFrame", Classes.FBoolProperty);
		ViewPitchMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewPitchMin");
		ViewPitchMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewPitchMin", Classes.FFloatProperty);
		ViewPitchMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewPitchMax");
		ViewPitchMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewPitchMax", Classes.FFloatProperty);
		ViewYawMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewYawMin");
		ViewYawMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewYawMin", Classes.FFloatProperty);
		ViewYawMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewYawMax");
		ViewYawMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewYawMax", Classes.FFloatProperty);
		ViewRollMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewRollMin");
		ViewRollMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewRollMin", Classes.FFloatProperty);
		ViewRollMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewRollMax");
		ViewRollMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewRollMax", Classes.FFloatProperty);
		StopCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopCameraShake");
		StopCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopCameraShake_ShakeInstance_PropertyAddress, StopCameraShake_FunctionAddress, "ShakeInstance");
		StopCameraShake_ShakeInstance_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraShake_FunctionAddress, "ShakeInstance");
		StopCameraShake_ShakeInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraShake_FunctionAddress, "ShakeInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopCameraShake_bImmediately_PropertyAddress, StopCameraShake_FunctionAddress, "bImmediately");
		StopCameraShake_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraShake_FunctionAddress, "bImmediately");
		StopCameraShake_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraShake_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopCameraShake_IsValid = StopCameraShake_FunctionAddress != IntPtr.Zero && StopCameraShake_ShakeInstance_IsValid && StopCameraShake_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopCameraShake", StopCameraShake_IsValid);
		StopCameraFade_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopCameraFade");
		StopCameraFade_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCameraFade_FunctionAddress);
		StopCameraFade_IsValid = StopCameraFade_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopCameraFade", StopCameraFade_IsValid);
		StopCameraAnimInst_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopCameraAnimInst");
		StopCameraAnimInst_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCameraAnimInst_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopCameraAnimInst_AnimInst_PropertyAddress, StopCameraAnimInst_FunctionAddress, "AnimInst");
		StopCameraAnimInst_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraAnimInst_FunctionAddress, "AnimInst");
		StopCameraAnimInst_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraAnimInst_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopCameraAnimInst_bImmediate_PropertyAddress, StopCameraAnimInst_FunctionAddress, "bImmediate");
		StopCameraAnimInst_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopCameraAnimInst_FunctionAddress, "bImmediate");
		StopCameraAnimInst_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopCameraAnimInst_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopCameraAnimInst_IsValid = StopCameraAnimInst_FunctionAddress != IntPtr.Zero && StopCameraAnimInst_AnimInst_IsValid && StopCameraAnimInst_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopCameraAnimInst", StopCameraAnimInst_IsValid);
		StopAllInstancesOfCameraShakeFromSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllInstancesOfCameraShakeFromSource");
		StopAllInstancesOfCameraShakeFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllInstancesOfCameraShakeFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraShakeFromSource_Shake_PropertyAddress, StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "Shake");
		StopAllInstancesOfCameraShakeFromSource_Shake_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "Shake");
		StopAllInstancesOfCameraShakeFromSource_Shake_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "Shake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraShakeFromSource_SourceComponent_PropertyAddress, StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StopAllInstancesOfCameraShakeFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StopAllInstancesOfCameraShakeFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraShakeFromSource_bImmediately_PropertyAddress, StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "bImmediately");
		StopAllInstancesOfCameraShakeFromSource_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "bImmediately");
		StopAllInstancesOfCameraShakeFromSource_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraShakeFromSource_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllInstancesOfCameraShakeFromSource_IsValid = StopAllInstancesOfCameraShakeFromSource_FunctionAddress != IntPtr.Zero && StopAllInstancesOfCameraShakeFromSource_Shake_IsValid && StopAllInstancesOfCameraShakeFromSource_SourceComponent_IsValid && StopAllInstancesOfCameraShakeFromSource_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShakeFromSource", StopAllInstancesOfCameraShakeFromSource_IsValid);
		StopAllInstancesOfCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllInstancesOfCameraShake");
		StopAllInstancesOfCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllInstancesOfCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraShake_Shake_PropertyAddress, StopAllInstancesOfCameraShake_FunctionAddress, "Shake");
		StopAllInstancesOfCameraShake_Shake_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraShake_FunctionAddress, "Shake");
		StopAllInstancesOfCameraShake_Shake_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraShake_FunctionAddress, "Shake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraShake_bImmediately_PropertyAddress, StopAllInstancesOfCameraShake_FunctionAddress, "bImmediately");
		StopAllInstancesOfCameraShake_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraShake_FunctionAddress, "bImmediately");
		StopAllInstancesOfCameraShake_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraShake_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllInstancesOfCameraShake_IsValid = StopAllInstancesOfCameraShake_FunctionAddress != IntPtr.Zero && StopAllInstancesOfCameraShake_Shake_IsValid && StopAllInstancesOfCameraShake_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraShake", StopAllInstancesOfCameraShake_IsValid);
		StopAllInstancesOfCameraAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllInstancesOfCameraAnim");
		StopAllInstancesOfCameraAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllInstancesOfCameraAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraAnim_Anim_PropertyAddress, StopAllInstancesOfCameraAnim_FunctionAddress, "Anim");
		StopAllInstancesOfCameraAnim_Anim_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraAnim_FunctionAddress, "Anim");
		StopAllInstancesOfCameraAnim_Anim_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraAnim_FunctionAddress, "Anim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllInstancesOfCameraAnim_bImmediate_PropertyAddress, StopAllInstancesOfCameraAnim_FunctionAddress, "bImmediate");
		StopAllInstancesOfCameraAnim_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopAllInstancesOfCameraAnim_FunctionAddress, "bImmediate");
		StopAllInstancesOfCameraAnim_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllInstancesOfCameraAnim_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopAllInstancesOfCameraAnim_IsValid = StopAllInstancesOfCameraAnim_FunctionAddress != IntPtr.Zero && StopAllInstancesOfCameraAnim_Anim_IsValid && StopAllInstancesOfCameraAnim_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllInstancesOfCameraAnim", StopAllInstancesOfCameraAnim_IsValid);
		StopAllCameraShakesFromSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllCameraShakesFromSource");
		StopAllCameraShakesFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraShakesFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakesFromSource_SourceComponent_PropertyAddress, StopAllCameraShakesFromSource_FunctionAddress, "SourceComponent");
		StopAllCameraShakesFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakesFromSource_FunctionAddress, "SourceComponent");
		StopAllCameraShakesFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakesFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakesFromSource_bImmediately_PropertyAddress, StopAllCameraShakesFromSource_FunctionAddress, "bImmediately");
		StopAllCameraShakesFromSource_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakesFromSource_FunctionAddress, "bImmediately");
		StopAllCameraShakesFromSource_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakesFromSource_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllCameraShakesFromSource_IsValid = StopAllCameraShakesFromSource_FunctionAddress != IntPtr.Zero && StopAllCameraShakesFromSource_SourceComponent_IsValid && StopAllCameraShakesFromSource_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllCameraShakesFromSource", StopAllCameraShakesFromSource_IsValid);
		StopAllCameraShakes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllCameraShakes");
		StopAllCameraShakes_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraShakes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraShakes_bImmediately_PropertyAddress, StopAllCameraShakes_FunctionAddress, "bImmediately");
		StopAllCameraShakes_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraShakes_FunctionAddress, "bImmediately");
		StopAllCameraShakes_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraShakes_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		StopAllCameraShakes_IsValid = StopAllCameraShakes_FunctionAddress != IntPtr.Zero && StopAllCameraShakes_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllCameraShakes", StopAllCameraShakes_IsValid);
		StopAllCameraAnims_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllCameraAnims");
		StopAllCameraAnims_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllCameraAnims_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllCameraAnims_bImmediate_PropertyAddress, StopAllCameraAnims_FunctionAddress, "bImmediate");
		StopAllCameraAnims_bImmediate_Offset = NativeReflectionCached.GetPropertyOffset(StopAllCameraAnims_FunctionAddress, "bImmediate");
		StopAllCameraAnims_bImmediate_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllCameraAnims_FunctionAddress, "bImmediate", Classes.FBoolProperty);
		StopAllCameraAnims_IsValid = StopAllCameraAnims_FunctionAddress != IntPtr.Zero && StopAllCameraAnims_bImmediate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StopAllCameraAnims", StopAllCameraAnims_IsValid);
		StartCameraShakeFromSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartCameraShakeFromSource");
		StartCameraShakeFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCameraShakeFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_ShakeClass_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "ShakeClass");
		StartCameraShakeFromSource_ShakeClass_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "ShakeClass");
		StartCameraShakeFromSource_ShakeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "ShakeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_SourceComponent_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StartCameraShakeFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "SourceComponent");
		StartCameraShakeFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_Scale_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "Scale");
		StartCameraShakeFromSource_Scale_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "Scale");
		StartCameraShakeFromSource_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_PlaySpace_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "PlaySpace");
		StartCameraShakeFromSource_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "PlaySpace");
		StartCameraShakeFromSource_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_UserPlaySpaceRot_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShakeFromSource_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShakeFromSource_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShakeFromSource_ReturnValue_PropertyAddress, StartCameraShakeFromSource_FunctionAddress, "ReturnValue");
		StartCameraShakeFromSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShakeFromSource_FunctionAddress, "ReturnValue");
		StartCameraShakeFromSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShakeFromSource_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		StartCameraShakeFromSource_IsValid = StartCameraShakeFromSource_FunctionAddress != IntPtr.Zero && StartCameraShakeFromSource_ShakeClass_IsValid && StartCameraShakeFromSource_SourceComponent_IsValid && StartCameraShakeFromSource_Scale_IsValid && StartCameraShakeFromSource_PlaySpace_IsValid && StartCameraShakeFromSource_UserPlaySpaceRot_IsValid && StartCameraShakeFromSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StartCameraShakeFromSource", StartCameraShakeFromSource_IsValid);
		StartCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartCameraShake");
		StartCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_ShakeClass_PropertyAddress, StartCameraShake_FunctionAddress, "ShakeClass");
		StartCameraShake_ShakeClass_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "ShakeClass");
		StartCameraShake_ShakeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "ShakeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_Scale_PropertyAddress, StartCameraShake_FunctionAddress, "Scale");
		StartCameraShake_Scale_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "Scale");
		StartCameraShake_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_PlaySpace_PropertyAddress, StartCameraShake_FunctionAddress, "PlaySpace");
		StartCameraShake_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "PlaySpace");
		StartCameraShake_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_UserPlaySpaceRot_PropertyAddress, StartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShake_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		StartCameraShake_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraShake_ReturnValue_PropertyAddress, StartCameraShake_FunctionAddress, "ReturnValue");
		StartCameraShake_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraShake_FunctionAddress, "ReturnValue");
		StartCameraShake_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraShake_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		StartCameraShake_IsValid = StartCameraShake_FunctionAddress != IntPtr.Zero && StartCameraShake_ShakeClass_IsValid && StartCameraShake_Scale_IsValid && StartCameraShake_PlaySpace_IsValid && StartCameraShake_UserPlaySpaceRot_IsValid && StartCameraShake_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StartCameraShake", StartCameraShake_IsValid);
		StartCameraFade_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartCameraFade");
		StartCameraFade_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCameraFade_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_FromAlpha_PropertyAddress, StartCameraFade_FunctionAddress, "FromAlpha");
		StartCameraFade_FromAlpha_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "FromAlpha");
		StartCameraFade_FromAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "FromAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_ToAlpha_PropertyAddress, StartCameraFade_FunctionAddress, "ToAlpha");
		StartCameraFade_ToAlpha_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "ToAlpha");
		StartCameraFade_ToAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "ToAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_Duration_PropertyAddress, StartCameraFade_FunctionAddress, "Duration");
		StartCameraFade_Duration_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "Duration");
		StartCameraFade_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_Color_PropertyAddress, StartCameraFade_FunctionAddress, "Color");
		StartCameraFade_Color_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "Color");
		StartCameraFade_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_bShouldFadeAudio_PropertyAddress, StartCameraFade_FunctionAddress, "bShouldFadeAudio");
		StartCameraFade_bShouldFadeAudio_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "bShouldFadeAudio");
		StartCameraFade_bShouldFadeAudio_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "bShouldFadeAudio", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartCameraFade_bHoldWhenFinished_PropertyAddress, StartCameraFade_FunctionAddress, "bHoldWhenFinished");
		StartCameraFade_bHoldWhenFinished_Offset = NativeReflectionCached.GetPropertyOffset(StartCameraFade_FunctionAddress, "bHoldWhenFinished");
		StartCameraFade_bHoldWhenFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCameraFade_FunctionAddress, "bHoldWhenFinished", Classes.FBoolProperty);
		StartCameraFade_IsValid = StartCameraFade_FunctionAddress != IntPtr.Zero && StartCameraFade_FromAlpha_IsValid && StartCameraFade_ToAlpha_IsValid && StartCameraFade_Duration_IsValid && StartCameraFade_Color_IsValid && StartCameraFade_bShouldFadeAudio_IsValid && StartCameraFade_bHoldWhenFinished_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:StartCameraFade", StartCameraFade_IsValid);
		SetManualCameraFade_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetManualCameraFade");
		SetManualCameraFade_ParamsSize = NativeReflection.GetFunctionParamsSize(SetManualCameraFade_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetManualCameraFade_InFadeAmount_PropertyAddress, SetManualCameraFade_FunctionAddress, "InFadeAmount");
		SetManualCameraFade_InFadeAmount_Offset = NativeReflectionCached.GetPropertyOffset(SetManualCameraFade_FunctionAddress, "InFadeAmount");
		SetManualCameraFade_InFadeAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetManualCameraFade_FunctionAddress, "InFadeAmount", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetManualCameraFade_Color_PropertyAddress, SetManualCameraFade_FunctionAddress, "Color");
		SetManualCameraFade_Color_Offset = NativeReflectionCached.GetPropertyOffset(SetManualCameraFade_FunctionAddress, "Color");
		SetManualCameraFade_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetManualCameraFade_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetManualCameraFade_bInFadeAudio_PropertyAddress, SetManualCameraFade_FunctionAddress, "bInFadeAudio");
		SetManualCameraFade_bInFadeAudio_Offset = NativeReflectionCached.GetPropertyOffset(SetManualCameraFade_FunctionAddress, "bInFadeAudio");
		SetManualCameraFade_bInFadeAudio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetManualCameraFade_FunctionAddress, "bInFadeAudio", Classes.FBoolProperty);
		SetManualCameraFade_IsValid = SetManualCameraFade_FunctionAddress != IntPtr.Zero && SetManualCameraFade_InFadeAmount_IsValid && SetManualCameraFade_Color_IsValid && SetManualCameraFade_bInFadeAudio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:SetManualCameraFade", SetManualCameraFade_IsValid);
		SetGameCameraCutThisFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGameCameraCutThisFrame");
		SetGameCameraCutThisFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGameCameraCutThisFrame_FunctionAddress);
		SetGameCameraCutThisFrame_IsValid = SetGameCameraCutThisFrame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:SetGameCameraCutThisFrame", SetGameCameraCutThisFrame_IsValid);
		RemoveGenericCameraLensEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveGenericCameraLensEffect");
		RemoveGenericCameraLensEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGenericCameraLensEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveGenericCameraLensEffect_Emitter_PropertyAddress, RemoveGenericCameraLensEffect_FunctionAddress, "Emitter");
		RemoveGenericCameraLensEffect_Emitter_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGenericCameraLensEffect_FunctionAddress, "Emitter");
		RemoveGenericCameraLensEffect_Emitter_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGenericCameraLensEffect_FunctionAddress, "Emitter", Classes.FInterfaceProperty);
		RemoveGenericCameraLensEffect_IsValid = RemoveGenericCameraLensEffect_FunctionAddress != IntPtr.Zero && RemoveGenericCameraLensEffect_Emitter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:RemoveGenericCameraLensEffect", RemoveGenericCameraLensEffect_IsValid);
		RemoveCameraModifier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveCameraModifier");
		RemoveCameraModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCameraModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCameraModifier_ModifierToRemove_PropertyAddress, RemoveCameraModifier_FunctionAddress, "ModifierToRemove");
		RemoveCameraModifier_ModifierToRemove_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCameraModifier_FunctionAddress, "ModifierToRemove");
		RemoveCameraModifier_ModifierToRemove_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCameraModifier_FunctionAddress, "ModifierToRemove", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCameraModifier_ReturnValue_PropertyAddress, RemoveCameraModifier_FunctionAddress, "ReturnValue");
		RemoveCameraModifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCameraModifier_FunctionAddress, "ReturnValue");
		RemoveCameraModifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCameraModifier_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCameraModifier_IsValid = RemoveCameraModifier_FunctionAddress != IntPtr.Zero && RemoveCameraModifier_ModifierToRemove_IsValid && RemoveCameraModifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:RemoveCameraModifier", RemoveCameraModifier_IsValid);
		PlayCameraAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayCameraAnim");
		PlayCameraAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayCameraAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_Anim_PropertyAddress, PlayCameraAnim_FunctionAddress, "Anim");
		PlayCameraAnim_Anim_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "Anim");
		PlayCameraAnim_Anim_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "Anim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_Rate_PropertyAddress, PlayCameraAnim_FunctionAddress, "Rate");
		PlayCameraAnim_Rate_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "Rate");
		PlayCameraAnim_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_Scale_PropertyAddress, PlayCameraAnim_FunctionAddress, "Scale");
		PlayCameraAnim_Scale_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "Scale");
		PlayCameraAnim_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_BlendInTime_PropertyAddress, PlayCameraAnim_FunctionAddress, "BlendInTime");
		PlayCameraAnim_BlendInTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "BlendInTime");
		PlayCameraAnim_BlendInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "BlendInTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_BlendOutTime_PropertyAddress, PlayCameraAnim_FunctionAddress, "BlendOutTime");
		PlayCameraAnim_BlendOutTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "BlendOutTime");
		PlayCameraAnim_BlendOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "BlendOutTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_bLoop_PropertyAddress, PlayCameraAnim_FunctionAddress, "bLoop");
		PlayCameraAnim_bLoop_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "bLoop");
		PlayCameraAnim_bLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "bLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_bRandomStartTime_PropertyAddress, PlayCameraAnim_FunctionAddress, "bRandomStartTime");
		PlayCameraAnim_bRandomStartTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "bRandomStartTime");
		PlayCameraAnim_bRandomStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "bRandomStartTime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_Duration_PropertyAddress, PlayCameraAnim_FunctionAddress, "Duration");
		PlayCameraAnim_Duration_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "Duration");
		PlayCameraAnim_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_PlaySpace_PropertyAddress, PlayCameraAnim_FunctionAddress, "PlaySpace");
		PlayCameraAnim_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "PlaySpace");
		PlayCameraAnim_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_UserPlaySpaceRot_PropertyAddress, PlayCameraAnim_FunctionAddress, "UserPlaySpaceRot");
		PlayCameraAnim_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "UserPlaySpaceRot");
		PlayCameraAnim_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayCameraAnim_ReturnValue_PropertyAddress, PlayCameraAnim_FunctionAddress, "ReturnValue");
		PlayCameraAnim_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayCameraAnim_FunctionAddress, "ReturnValue");
		PlayCameraAnim_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayCameraAnim_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayCameraAnim_IsValid = PlayCameraAnim_FunctionAddress != IntPtr.Zero && PlayCameraAnim_Anim_IsValid && PlayCameraAnim_Rate_IsValid && PlayCameraAnim_Scale_IsValid && PlayCameraAnim_BlendInTime_IsValid && PlayCameraAnim_BlendOutTime_IsValid && PlayCameraAnim_bLoop_IsValid && PlayCameraAnim_bRandomStartTime_IsValid && PlayCameraAnim_Duration_IsValid && PlayCameraAnim_PlaySpace_IsValid && PlayCameraAnim_UserPlaySpaceRot_IsValid && PlayCameraAnim_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:PlayCameraAnim", PlayCameraAnim_IsValid);
		PhotographyCameraModify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PhotographyCameraModify");
		PhotographyCameraModify_ParamsSize = NativeReflection.GetFunctionParamsSize(PhotographyCameraModify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PhotographyCameraModify_NewCameraLocation_PropertyAddress, PhotographyCameraModify_FunctionAddress, "NewCameraLocation");
		PhotographyCameraModify_NewCameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(PhotographyCameraModify_FunctionAddress, "NewCameraLocation");
		PhotographyCameraModify_NewCameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PhotographyCameraModify_FunctionAddress, "NewCameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PhotographyCameraModify_PreviousCameraLocation_PropertyAddress, PhotographyCameraModify_FunctionAddress, "PreviousCameraLocation");
		PhotographyCameraModify_PreviousCameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(PhotographyCameraModify_FunctionAddress, "PreviousCameraLocation");
		PhotographyCameraModify_PreviousCameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PhotographyCameraModify_FunctionAddress, "PreviousCameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PhotographyCameraModify_OriginalCameraLocation_PropertyAddress, PhotographyCameraModify_FunctionAddress, "OriginalCameraLocation");
		PhotographyCameraModify_OriginalCameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(PhotographyCameraModify_FunctionAddress, "OriginalCameraLocation");
		PhotographyCameraModify_OriginalCameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PhotographyCameraModify_FunctionAddress, "OriginalCameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PhotographyCameraModify_ResultCameraLocation_PropertyAddress, PhotographyCameraModify_FunctionAddress, "ResultCameraLocation");
		PhotographyCameraModify_ResultCameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(PhotographyCameraModify_FunctionAddress, "ResultCameraLocation");
		PhotographyCameraModify_ResultCameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PhotographyCameraModify_FunctionAddress, "ResultCameraLocation", Classes.FStructProperty);
		PhotographyCameraModify_IsValid = PhotographyCameraModify_FunctionAddress != IntPtr.Zero && PhotographyCameraModify_NewCameraLocation_IsValid && PhotographyCameraModify_PreviousCameraLocation_IsValid && PhotographyCameraModify_OriginalCameraLocation_IsValid && PhotographyCameraModify_ResultCameraLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:PhotographyCameraModify", PhotographyCameraModify_IsValid);
		OnPhotographySessionStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPhotographySessionStart");
		OnPhotographySessionStart_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPhotographySessionStart_FunctionAddress);
		OnPhotographySessionStart_IsValid = OnPhotographySessionStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:OnPhotographySessionStart", OnPhotographySessionStart_IsValid);
		OnPhotographySessionEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPhotographySessionEnd");
		OnPhotographySessionEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPhotographySessionEnd_FunctionAddress);
		OnPhotographySessionEnd_IsValid = OnPhotographySessionEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:OnPhotographySessionEnd", OnPhotographySessionEnd_IsValid);
		OnPhotographyMultiPartCaptureStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPhotographyMultiPartCaptureStart");
		OnPhotographyMultiPartCaptureStart_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPhotographyMultiPartCaptureStart_FunctionAddress);
		OnPhotographyMultiPartCaptureStart_IsValid = OnPhotographyMultiPartCaptureStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureStart", OnPhotographyMultiPartCaptureStart_IsValid);
		OnPhotographyMultiPartCaptureEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPhotographyMultiPartCaptureEnd");
		OnPhotographyMultiPartCaptureEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPhotographyMultiPartCaptureEnd_FunctionAddress);
		OnPhotographyMultiPartCaptureEnd_IsValid = OnPhotographyMultiPartCaptureEnd_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:OnPhotographyMultiPartCaptureEnd", OnPhotographyMultiPartCaptureEnd_IsValid);
		GetOwningPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPlayerController");
		GetOwningPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPlayerController_ReturnValue_PropertyAddress, GetOwningPlayerController_FunctionAddress, "ReturnValue");
		GetOwningPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPlayerController_FunctionAddress, "ReturnValue");
		GetOwningPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPlayerController_IsValid = GetOwningPlayerController_FunctionAddress != IntPtr.Zero && GetOwningPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:GetOwningPlayerController", GetOwningPlayerController_IsValid);
		GetFOVAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFOVAngle");
		GetFOVAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFOVAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFOVAngle_ReturnValue_PropertyAddress, GetFOVAngle_FunctionAddress, "ReturnValue");
		GetFOVAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFOVAngle_FunctionAddress, "ReturnValue");
		GetFOVAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFOVAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFOVAngle_IsValid = GetFOVAngle_FunctionAddress != IntPtr.Zero && GetFOVAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:GetFOVAngle", GetFOVAngle_IsValid);
		GetCameraRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCameraRotation");
		GetCameraRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraRotation_ReturnValue_PropertyAddress, GetCameraRotation_FunctionAddress, "ReturnValue");
		GetCameraRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraRotation_FunctionAddress, "ReturnValue");
		GetCameraRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCameraRotation_IsValid = GetCameraRotation_FunctionAddress != IntPtr.Zero && GetCameraRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:GetCameraRotation", GetCameraRotation_IsValid);
		GetCameraLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCameraLocation");
		GetCameraLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraLocation_ReturnValue_PropertyAddress, GetCameraLocation_FunctionAddress, "ReturnValue");
		GetCameraLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraLocation_FunctionAddress, "ReturnValue");
		GetCameraLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCameraLocation_IsValid = GetCameraLocation_FunctionAddress != IntPtr.Zero && GetCameraLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:GetCameraLocation", GetCameraLocation_IsValid);
		FindCameraModifierByClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindCameraModifierByClass");
		FindCameraModifierByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindCameraModifierByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindCameraModifierByClass_ModifierClass_PropertyAddress, FindCameraModifierByClass_FunctionAddress, "ModifierClass");
		FindCameraModifierByClass_ModifierClass_Offset = NativeReflectionCached.GetPropertyOffset(FindCameraModifierByClass_FunctionAddress, "ModifierClass");
		FindCameraModifierByClass_ModifierClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCameraModifierByClass_FunctionAddress, "ModifierClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindCameraModifierByClass_ReturnValue_PropertyAddress, FindCameraModifierByClass_FunctionAddress, "ReturnValue");
		FindCameraModifierByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindCameraModifierByClass_FunctionAddress, "ReturnValue");
		FindCameraModifierByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCameraModifierByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindCameraModifierByClass_IsValid = FindCameraModifierByClass_FunctionAddress != IntPtr.Zero && FindCameraModifierByClass_ModifierClass_IsValid && FindCameraModifierByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:FindCameraModifierByClass", FindCameraModifierByClass_IsValid);
		ClearCameraLensEffects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearCameraLensEffects");
		ClearCameraLensEffects_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearCameraLensEffects_FunctionAddress);
		ClearCameraLensEffects_IsValid = ClearCameraLensEffects_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:ClearCameraLensEffects", ClearCameraLensEffects_IsValid);
		BlueprintUpdateCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateCamera");
		BlueprintUpdateCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCamera_CameraTarget_PropertyAddress, BlueprintUpdateCamera_FunctionAddress, "CameraTarget");
		BlueprintUpdateCamera_CameraTarget_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCamera_FunctionAddress, "CameraTarget");
		BlueprintUpdateCamera_CameraTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCamera_FunctionAddress, "CameraTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCamera_NewCameraLocation_PropertyAddress, BlueprintUpdateCamera_FunctionAddress, "NewCameraLocation");
		BlueprintUpdateCamera_NewCameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCamera_FunctionAddress, "NewCameraLocation");
		BlueprintUpdateCamera_NewCameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCamera_FunctionAddress, "NewCameraLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCamera_NewCameraRotation_PropertyAddress, BlueprintUpdateCamera_FunctionAddress, "NewCameraRotation");
		BlueprintUpdateCamera_NewCameraRotation_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCamera_FunctionAddress, "NewCameraRotation");
		BlueprintUpdateCamera_NewCameraRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCamera_FunctionAddress, "NewCameraRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCamera_NewCameraFOV_PropertyAddress, BlueprintUpdateCamera_FunctionAddress, "NewCameraFOV");
		BlueprintUpdateCamera_NewCameraFOV_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCamera_FunctionAddress, "NewCameraFOV");
		BlueprintUpdateCamera_NewCameraFOV_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCamera_FunctionAddress, "NewCameraFOV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintUpdateCamera_ReturnValue_PropertyAddress, BlueprintUpdateCamera_FunctionAddress, "ReturnValue");
		BlueprintUpdateCamera_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintUpdateCamera_FunctionAddress, "ReturnValue");
		BlueprintUpdateCamera_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintUpdateCamera_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BlueprintUpdateCamera_IsValid = BlueprintUpdateCamera_FunctionAddress != IntPtr.Zero && BlueprintUpdateCamera_CameraTarget_IsValid && BlueprintUpdateCamera_NewCameraLocation_IsValid && BlueprintUpdateCamera_NewCameraRotation_IsValid && BlueprintUpdateCamera_NewCameraFOV_IsValid && BlueprintUpdateCamera_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:BlueprintUpdateCamera", BlueprintUpdateCamera_IsValid);
		AddNewCameraModifier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddNewCameraModifier");
		AddNewCameraModifier_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewCameraModifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewCameraModifier_ModifierClass_PropertyAddress, AddNewCameraModifier_FunctionAddress, "ModifierClass");
		AddNewCameraModifier_ModifierClass_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCameraModifier_FunctionAddress, "ModifierClass");
		AddNewCameraModifier_ModifierClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCameraModifier_FunctionAddress, "ModifierClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCameraModifier_ReturnValue_PropertyAddress, AddNewCameraModifier_FunctionAddress, "ReturnValue");
		AddNewCameraModifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCameraModifier_FunctionAddress, "ReturnValue");
		AddNewCameraModifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCameraModifier_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNewCameraModifier_IsValid = AddNewCameraModifier_FunctionAddress != IntPtr.Zero && AddNewCameraModifier_ModifierClass_IsValid && AddNewCameraModifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:AddNewCameraModifier", AddNewCameraModifier_IsValid);
		AddGenericCameraLensEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddGenericCameraLensEffect");
		AddGenericCameraLensEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGenericCameraLensEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress, AddGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass");
		AddGenericCameraLensEffect_LensEffectEmitterClass_Offset = NativeReflectionCached.GetPropertyOffset(AddGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass");
		AddGenericCameraLensEffect_LensEffectEmitterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGenericCameraLensEffect_ReturnValue_PropertyAddress, AddGenericCameraLensEffect_FunctionAddress, "ReturnValue");
		AddGenericCameraLensEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddGenericCameraLensEffect_FunctionAddress, "ReturnValue");
		AddGenericCameraLensEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGenericCameraLensEffect_FunctionAddress, "ReturnValue", Classes.FInterfaceProperty);
		AddGenericCameraLensEffect_IsValid = AddGenericCameraLensEffect_FunctionAddress != IntPtr.Zero && AddGenericCameraLensEffect_LensEffectEmitterClass_IsValid && AddGenericCameraLensEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerCameraManager:AddGenericCameraLensEffect", AddGenericCameraLensEffect_IsValid);
	}
}
