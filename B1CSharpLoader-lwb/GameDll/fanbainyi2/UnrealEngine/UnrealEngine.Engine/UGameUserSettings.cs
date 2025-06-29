using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)1892679844uL, Config = "GameUserSettings")]
[UMetaPath("/Script/Engine.GameUserSettings", "Engine", UnrealModuleType.Engine)]
public class UGameUserSettings : UObject
{
	private static IntPtr classAddress;

	private static bool OnGameUserSettingsUINeedsUpdate_IsValid;

	private static int OnGameUserSettingsUINeedsUpdate_Offset;

	private FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate_DelegateCached;

	private static bool ValidateSettings_IsValid;

	private static IntPtr ValidateSettings_FunctionAddress;

	private static int ValidateSettings_ParamsSize;

	private static bool SupportsHDRDisplayOutput_IsValid;

	private static IntPtr SupportsHDRDisplayOutput_FunctionAddress;

	private static int SupportsHDRDisplayOutput_ParamsSize;

	private static bool SupportsHDRDisplayOutput_ReturnValue_IsValid;

	private static FFieldAddress SupportsHDRDisplayOutput_ReturnValue_PropertyAddress;

	private static int SupportsHDRDisplayOutput_ReturnValue_Offset;

	private static bool SetVSyncEnabled_IsValid;

	private static IntPtr SetVSyncEnabled_FunctionAddress;

	private static int SetVSyncEnabled_ParamsSize;

	private static bool SetVSyncEnabled_bEnable_IsValid;

	private static FFieldAddress SetVSyncEnabled_bEnable_PropertyAddress;

	private static int SetVSyncEnabled_bEnable_Offset;

	private static bool SetVisualEffectQuality_IsValid;

	private static IntPtr SetVisualEffectQuality_FunctionAddress;

	private static int SetVisualEffectQuality_ParamsSize;

	private static bool SetVisualEffectQuality_Value_IsValid;

	private static FFieldAddress SetVisualEffectQuality_Value_PropertyAddress;

	private static int SetVisualEffectQuality_Value_Offset;

	private static bool SetViewDistanceQuality_IsValid;

	private static IntPtr SetViewDistanceQuality_FunctionAddress;

	private static int SetViewDistanceQuality_ParamsSize;

	private static bool SetViewDistanceQuality_Value_IsValid;

	private static FFieldAddress SetViewDistanceQuality_Value_PropertyAddress;

	private static int SetViewDistanceQuality_Value_Offset;

	private static bool SetToDefaults_IsValid;

	private static IntPtr SetToDefaults_FunctionAddress;

	private static int SetToDefaults_ParamsSize;

	private static bool SetTextureQuality_IsValid;

	private static IntPtr SetTextureQuality_FunctionAddress;

	private static int SetTextureQuality_ParamsSize;

	private static bool SetTextureQuality_Value_IsValid;

	private static FFieldAddress SetTextureQuality_Value_PropertyAddress;

	private static int SetTextureQuality_Value_Offset;

	private static bool SetShadowQuality_IsValid;

	private static IntPtr SetShadowQuality_FunctionAddress;

	private static int SetShadowQuality_ParamsSize;

	private static bool SetShadowQuality_Value_IsValid;

	private static FFieldAddress SetShadowQuality_Value_PropertyAddress;

	private static int SetShadowQuality_Value_Offset;

	private static bool SetShadingQuality_IsValid;

	private static IntPtr SetShadingQuality_FunctionAddress;

	private static int SetShadingQuality_ParamsSize;

	private static bool SetShadingQuality_Value_IsValid;

	private static FFieldAddress SetShadingQuality_Value_PropertyAddress;

	private static int SetShadingQuality_Value_Offset;

	private static bool SetScreenResolution_IsValid;

	private static IntPtr SetScreenResolution_FunctionAddress;

	private static int SetScreenResolution_ParamsSize;

	private static bool SetScreenResolution_Resolution_IsValid;

	private static FFieldAddress SetScreenResolution_Resolution_PropertyAddress;

	private static int SetScreenResolution_Resolution_Offset;

	private static bool SetResolutionScaleValueEx_IsValid;

	private static IntPtr SetResolutionScaleValueEx_FunctionAddress;

	private static int SetResolutionScaleValueEx_ParamsSize;

	private static bool SetResolutionScaleValueEx_NewScaleValue_IsValid;

	private static FFieldAddress SetResolutionScaleValueEx_NewScaleValue_PropertyAddress;

	private static int SetResolutionScaleValueEx_NewScaleValue_Offset;

	private static bool SetResolutionScaleNormalized_IsValid;

	private static IntPtr SetResolutionScaleNormalized_FunctionAddress;

	private static int SetResolutionScaleNormalized_ParamsSize;

	private static bool SetResolutionScaleNormalized_NewScaleNormalized_IsValid;

	private static FFieldAddress SetResolutionScaleNormalized_NewScaleNormalized_PropertyAddress;

	private static int SetResolutionScaleNormalized_NewScaleNormalized_Offset;

	private static bool SetReflectionQuality_IsValid;

	private static IntPtr SetReflectionQuality_FunctionAddress;

	private static int SetReflectionQuality_ParamsSize;

	private static bool SetReflectionQuality_Value_IsValid;

	private static FFieldAddress SetReflectionQuality_Value_PropertyAddress;

	private static int SetReflectionQuality_Value_Offset;

	private static bool SetRayTracingQuality_IsValid;

	private static IntPtr SetRayTracingQuality_FunctionAddress;

	private static int SetRayTracingQuality_ParamsSize;

	private static bool SetRayTracingQuality_Value_IsValid;

	private static FFieldAddress SetRayTracingQuality_Value_PropertyAddress;

	private static int SetRayTracingQuality_Value_Offset;

	private static bool SetPostProcessingQuality_IsValid;

	private static IntPtr SetPostProcessingQuality_FunctionAddress;

	private static int SetPostProcessingQuality_ParamsSize;

	private static bool SetPostProcessingQuality_Value_IsValid;

	private static FFieldAddress SetPostProcessingQuality_Value_PropertyAddress;

	private static int SetPostProcessingQuality_Value_Offset;

	private static bool SetOverallScalabilityLevel_IsValid;

	private static IntPtr SetOverallScalabilityLevel_FunctionAddress;

	private static int SetOverallScalabilityLevel_ParamsSize;

	private static bool SetOverallScalabilityLevel_Value_IsValid;

	private static FFieldAddress SetOverallScalabilityLevel_Value_PropertyAddress;

	private static int SetOverallScalabilityLevel_Value_Offset;

	private static bool SetGlobalIlluminationQuality_IsValid;

	private static IntPtr SetGlobalIlluminationQuality_FunctionAddress;

	private static int SetGlobalIlluminationQuality_ParamsSize;

	private static bool SetGlobalIlluminationQuality_Value_IsValid;

	private static FFieldAddress SetGlobalIlluminationQuality_Value_PropertyAddress;

	private static int SetGlobalIlluminationQuality_Value_Offset;

	private static bool SetFullscreenMode_IsValid;

	private static IntPtr SetFullscreenMode_FunctionAddress;

	private static int SetFullscreenMode_ParamsSize;

	private static bool SetFullscreenMode_InFullscreenMode_IsValid;

	private static FFieldAddress SetFullscreenMode_InFullscreenMode_PropertyAddress;

	private static int SetFullscreenMode_InFullscreenMode_Offset;

	private static bool SetFrameRateLimit_IsValid;

	private static IntPtr SetFrameRateLimit_FunctionAddress;

	private static int SetFrameRateLimit_ParamsSize;

	private static bool SetFrameRateLimit_NewLimit_IsValid;

	private static FFieldAddress SetFrameRateLimit_NewLimit_PropertyAddress;

	private static int SetFrameRateLimit_NewLimit_Offset;

	private static bool SetFoliageQuality_IsValid;

	private static IntPtr SetFoliageQuality_FunctionAddress;

	private static int SetFoliageQuality_ParamsSize;

	private static bool SetFoliageQuality_Value_IsValid;

	private static FFieldAddress SetFoliageQuality_Value_PropertyAddress;

	private static int SetFoliageQuality_Value_Offset;

	private static bool SetDynamicResolutionEnabled_IsValid;

	private static IntPtr SetDynamicResolutionEnabled_FunctionAddress;

	private static int SetDynamicResolutionEnabled_ParamsSize;

	private static bool SetDynamicResolutionEnabled_bEnable_IsValid;

	private static FFieldAddress SetDynamicResolutionEnabled_bEnable_PropertyAddress;

	private static int SetDynamicResolutionEnabled_bEnable_Offset;

	private static bool SetBenchmarkFallbackValues_IsValid;

	private static IntPtr SetBenchmarkFallbackValues_FunctionAddress;

	private static int SetBenchmarkFallbackValues_ParamsSize;

	private static bool SetAudioQualityLevel_IsValid;

	private static IntPtr SetAudioQualityLevel_FunctionAddress;

	private static int SetAudioQualityLevel_ParamsSize;

	private static bool SetAudioQualityLevel_QualityLevel_IsValid;

	private static FFieldAddress SetAudioQualityLevel_QualityLevel_PropertyAddress;

	private static int SetAudioQualityLevel_QualityLevel_Offset;

	private static bool SetAntiAliasingQuality_IsValid;

	private static IntPtr SetAntiAliasingQuality_FunctionAddress;

	private static int SetAntiAliasingQuality_ParamsSize;

	private static bool SetAntiAliasingQuality_Value_IsValid;

	private static FFieldAddress SetAntiAliasingQuality_Value_PropertyAddress;

	private static int SetAntiAliasingQuality_Value_Offset;

	private static bool SaveSettings_IsValid;

	private static IntPtr SaveSettings_FunctionAddress;

	private static int SaveSettings_ParamsSize;

	private static bool RunHardwareBenchmark_IsValid;

	private static IntPtr RunHardwareBenchmark_FunctionAddress;

	private static int RunHardwareBenchmark_ParamsSize;

	private static bool RunHardwareBenchmark_WorkScale_IsValid;

	private static FFieldAddress RunHardwareBenchmark_WorkScale_PropertyAddress;

	private static int RunHardwareBenchmark_WorkScale_Offset;

	private static bool RunHardwareBenchmark_CPUMultiplier_IsValid;

	private static FFieldAddress RunHardwareBenchmark_CPUMultiplier_PropertyAddress;

	private static int RunHardwareBenchmark_CPUMultiplier_Offset;

	private static bool RunHardwareBenchmark_GPUMultiplier_IsValid;

	private static FFieldAddress RunHardwareBenchmark_GPUMultiplier_PropertyAddress;

	private static int RunHardwareBenchmark_GPUMultiplier_Offset;

	private static bool RevertVideoMode_IsValid;

	private static IntPtr RevertVideoMode_FunctionAddress;

	private static int RevertVideoMode_ParamsSize;

	private static bool ResetToCurrentSettings_IsValid;

	private static IntPtr ResetToCurrentSettings_FunctionAddress;

	private static int ResetToCurrentSettings_ParamsSize;

	private static bool LoadSettings_IsValid;

	private static IntPtr LoadSettings_FunctionAddress;

	private static int LoadSettings_ParamsSize;

	private static bool LoadSettings_bForceReload_IsValid;

	private static FFieldAddress LoadSettings_bForceReload_PropertyAddress;

	private static int LoadSettings_bForceReload_Offset;

	private static bool IsVSyncEnabled_IsValid;

	private static IntPtr IsVSyncEnabled_FunctionAddress;

	private static int IsVSyncEnabled_ParamsSize;

	private static bool IsVSyncEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsVSyncEnabled_ReturnValue_PropertyAddress;

	private static int IsVSyncEnabled_ReturnValue_Offset;

	private static bool IsVSyncDirty_IsValid;

	private static IntPtr IsVSyncDirty_FunctionAddress;

	private static int IsVSyncDirty_ParamsSize;

	private static bool IsVSyncDirty_ReturnValue_IsValid;

	private static FFieldAddress IsVSyncDirty_ReturnValue_PropertyAddress;

	private static int IsVSyncDirty_ReturnValue_Offset;

	private static bool IsScreenResolutionDirty_IsValid;

	private static IntPtr IsScreenResolutionDirty_FunctionAddress;

	private static int IsScreenResolutionDirty_ParamsSize;

	private static bool IsScreenResolutionDirty_ReturnValue_IsValid;

	private static FFieldAddress IsScreenResolutionDirty_ReturnValue_PropertyAddress;

	private static int IsScreenResolutionDirty_ReturnValue_Offset;

	private static bool IsHDREnabled_IsValid;

	private static IntPtr IsHDREnabled_FunctionAddress;

	private static int IsHDREnabled_ParamsSize;

	private static bool IsHDREnabled_ReturnValue_IsValid;

	private static FFieldAddress IsHDREnabled_ReturnValue_PropertyAddress;

	private static int IsHDREnabled_ReturnValue_Offset;

	private static bool IsFullscreenModeDirty_IsValid;

	private static IntPtr IsFullscreenModeDirty_FunctionAddress;

	private static int IsFullscreenModeDirty_ParamsSize;

	private static bool IsFullscreenModeDirty_ReturnValue_IsValid;

	private static FFieldAddress IsFullscreenModeDirty_ReturnValue_PropertyAddress;

	private static int IsFullscreenModeDirty_ReturnValue_Offset;

	private static bool IsDynamicResolutionEnabled_IsValid;

	private static IntPtr IsDynamicResolutionEnabled_FunctionAddress;

	private static int IsDynamicResolutionEnabled_ParamsSize;

	private static bool IsDynamicResolutionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsDynamicResolutionEnabled_ReturnValue_PropertyAddress;

	private static int IsDynamicResolutionEnabled_ReturnValue_Offset;

	private static bool IsDynamicResolutionDirty_IsValid;

	private static IntPtr IsDynamicResolutionDirty_FunctionAddress;

	private static int IsDynamicResolutionDirty_ParamsSize;

	private static bool IsDynamicResolutionDirty_ReturnValue_IsValid;

	private static FFieldAddress IsDynamicResolutionDirty_ReturnValue_PropertyAddress;

	private static int IsDynamicResolutionDirty_ReturnValue_Offset;

	private static bool IsDirty_IsValid;

	private static IntPtr IsDirty_FunctionAddress;

	private static int IsDirty_ParamsSize;

	private static bool IsDirty_ReturnValue_IsValid;

	private static FFieldAddress IsDirty_ReturnValue_PropertyAddress;

	private static int IsDirty_ReturnValue_Offset;

	private static bool GetVisualEffectQuality_IsValid;

	private static IntPtr GetVisualEffectQuality_FunctionAddress;

	private static int GetVisualEffectQuality_ParamsSize;

	private static bool GetVisualEffectQuality_ReturnValue_IsValid;

	private static FFieldAddress GetVisualEffectQuality_ReturnValue_PropertyAddress;

	private static int GetVisualEffectQuality_ReturnValue_Offset;

	private static bool GetViewDistanceQuality_IsValid;

	private static IntPtr GetViewDistanceQuality_FunctionAddress;

	private static int GetViewDistanceQuality_ParamsSize;

	private static bool GetViewDistanceQuality_ReturnValue_IsValid;

	private static FFieldAddress GetViewDistanceQuality_ReturnValue_PropertyAddress;

	private static int GetViewDistanceQuality_ReturnValue_Offset;

	private static bool GetTextureQuality_IsValid;

	private static IntPtr GetTextureQuality_FunctionAddress;

	private static int GetTextureQuality_ParamsSize;

	private static bool GetTextureQuality_ReturnValue_IsValid;

	private static FFieldAddress GetTextureQuality_ReturnValue_PropertyAddress;

	private static int GetTextureQuality_ReturnValue_Offset;

	private static bool GetSyncInterval_IsValid;

	private static IntPtr GetSyncInterval_FunctionAddress;

	private static int GetSyncInterval_ParamsSize;

	private static bool GetSyncInterval_ReturnValue_IsValid;

	private static FFieldAddress GetSyncInterval_ReturnValue_PropertyAddress;

	private static int GetSyncInterval_ReturnValue_Offset;

	private static bool GetShadowQuality_IsValid;

	private static IntPtr GetShadowQuality_FunctionAddress;

	private static int GetShadowQuality_ParamsSize;

	private static bool GetShadowQuality_ReturnValue_IsValid;

	private static FFieldAddress GetShadowQuality_ReturnValue_PropertyAddress;

	private static int GetShadowQuality_ReturnValue_Offset;

	private static bool GetShadingQuality_IsValid;

	private static IntPtr GetShadingQuality_FunctionAddress;

	private static int GetShadingQuality_ParamsSize;

	private static bool GetShadingQuality_ReturnValue_IsValid;

	private static FFieldAddress GetShadingQuality_ReturnValue_PropertyAddress;

	private static int GetShadingQuality_ReturnValue_Offset;

	private static bool GetScreenResolution_IsValid;

	private static IntPtr GetScreenResolution_FunctionAddress;

	private static int GetScreenResolution_ParamsSize;

	private static bool GetScreenResolution_ReturnValue_IsValid;

	private static FFieldAddress GetScreenResolution_ReturnValue_PropertyAddress;

	private static int GetScreenResolution_ReturnValue_Offset;

	private static bool GetResolutionScaleNormalized_IsValid;

	private static IntPtr GetResolutionScaleNormalized_FunctionAddress;

	private static int GetResolutionScaleNormalized_ParamsSize;

	private static bool GetResolutionScaleNormalized_ReturnValue_IsValid;

	private static FFieldAddress GetResolutionScaleNormalized_ReturnValue_PropertyAddress;

	private static int GetResolutionScaleNormalized_ReturnValue_Offset;

	private static bool GetResolutionScaleInformationEx_IsValid;

	private static IntPtr GetResolutionScaleInformationEx_FunctionAddress;

	private static int GetResolutionScaleInformationEx_ParamsSize;

	private static bool GetResolutionScaleInformationEx_CurrentScaleNormalized_IsValid;

	private static FFieldAddress GetResolutionScaleInformationEx_CurrentScaleNormalized_PropertyAddress;

	private static int GetResolutionScaleInformationEx_CurrentScaleNormalized_Offset;

	private static bool GetResolutionScaleInformationEx_CurrentScaleValue_IsValid;

	private static FFieldAddress GetResolutionScaleInformationEx_CurrentScaleValue_PropertyAddress;

	private static int GetResolutionScaleInformationEx_CurrentScaleValue_Offset;

	private static bool GetResolutionScaleInformationEx_MinScaleValue_IsValid;

	private static FFieldAddress GetResolutionScaleInformationEx_MinScaleValue_PropertyAddress;

	private static int GetResolutionScaleInformationEx_MinScaleValue_Offset;

	private static bool GetResolutionScaleInformationEx_MaxScaleValue_IsValid;

	private static FFieldAddress GetResolutionScaleInformationEx_MaxScaleValue_PropertyAddress;

	private static int GetResolutionScaleInformationEx_MaxScaleValue_Offset;

	private static bool GetReflectionQuality_IsValid;

	private static IntPtr GetReflectionQuality_FunctionAddress;

	private static int GetReflectionQuality_ParamsSize;

	private static bool GetReflectionQuality_ReturnValue_IsValid;

	private static FFieldAddress GetReflectionQuality_ReturnValue_PropertyAddress;

	private static int GetReflectionQuality_ReturnValue_Offset;

	private static bool GetRecommendedResolutionScale_IsValid;

	private static IntPtr GetRecommendedResolutionScale_FunctionAddress;

	private static int GetRecommendedResolutionScale_ParamsSize;

	private static bool GetRecommendedResolutionScale_ReturnValue_IsValid;

	private static FFieldAddress GetRecommendedResolutionScale_ReturnValue_PropertyAddress;

	private static int GetRecommendedResolutionScale_ReturnValue_Offset;

	private static bool GetRayTracingQuality_IsValid;

	private static IntPtr GetRayTracingQuality_FunctionAddress;

	private static int GetRayTracingQuality_ParamsSize;

	private static bool GetRayTracingQuality_ReturnValue_IsValid;

	private static FFieldAddress GetRayTracingQuality_ReturnValue_PropertyAddress;

	private static int GetRayTracingQuality_ReturnValue_Offset;

	private static bool GetPreferredFullscreenMode_IsValid;

	private static IntPtr GetPreferredFullscreenMode_FunctionAddress;

	private static int GetPreferredFullscreenMode_ParamsSize;

	private static bool GetPreferredFullscreenMode_ReturnValue_IsValid;

	private static FFieldAddress GetPreferredFullscreenMode_ReturnValue_PropertyAddress;

	private static int GetPreferredFullscreenMode_ReturnValue_Offset;

	private static bool GetPostProcessingQuality_IsValid;

	private static IntPtr GetPostProcessingQuality_FunctionAddress;

	private static int GetPostProcessingQuality_ParamsSize;

	private static bool GetPostProcessingQuality_ReturnValue_IsValid;

	private static FFieldAddress GetPostProcessingQuality_ReturnValue_PropertyAddress;

	private static int GetPostProcessingQuality_ReturnValue_Offset;

	private static bool GetOverallScalabilityLevel_IsValid;

	private static IntPtr GetOverallScalabilityLevel_FunctionAddress;

	private static int GetOverallScalabilityLevel_ParamsSize;

	private static bool GetOverallScalabilityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetOverallScalabilityLevel_ReturnValue_PropertyAddress;

	private static int GetOverallScalabilityLevel_ReturnValue_Offset;

	private static bool GetLastConfirmedScreenResolution_IsValid;

	private static IntPtr GetLastConfirmedScreenResolution_FunctionAddress;

	private static int GetLastConfirmedScreenResolution_ParamsSize;

	private static bool GetLastConfirmedScreenResolution_ReturnValue_IsValid;

	private static FFieldAddress GetLastConfirmedScreenResolution_ReturnValue_PropertyAddress;

	private static int GetLastConfirmedScreenResolution_ReturnValue_Offset;

	private static bool GetLastConfirmedFullscreenMode_IsValid;

	private static IntPtr GetLastConfirmedFullscreenMode_FunctionAddress;

	private static int GetLastConfirmedFullscreenMode_ParamsSize;

	private static bool GetLastConfirmedFullscreenMode_ReturnValue_IsValid;

	private static FFieldAddress GetLastConfirmedFullscreenMode_ReturnValue_PropertyAddress;

	private static int GetLastConfirmedFullscreenMode_ReturnValue_Offset;

	private static bool GetGlobalIlluminationQuality_IsValid;

	private static IntPtr GetGlobalIlluminationQuality_FunctionAddress;

	private static int GetGlobalIlluminationQuality_ParamsSize;

	private static bool GetGlobalIlluminationQuality_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalIlluminationQuality_ReturnValue_PropertyAddress;

	private static int GetGlobalIlluminationQuality_ReturnValue_Offset;

	private static bool GetGameUserSettings_IsValid;

	private static IntPtr GetGameUserSettings_FunctionAddress;

	private static int GetGameUserSettings_ParamsSize;

	private static bool GetGameUserSettings_ReturnValue_IsValid;

	private static FFieldAddress GetGameUserSettings_ReturnValue_PropertyAddress;

	private static int GetGameUserSettings_ReturnValue_Offset;

	private static bool GetFullscreenMode_IsValid;

	private static IntPtr GetFullscreenMode_FunctionAddress;

	private static int GetFullscreenMode_ParamsSize;

	private static bool GetFullscreenMode_ReturnValue_IsValid;

	private static FFieldAddress GetFullscreenMode_ReturnValue_PropertyAddress;

	private static int GetFullscreenMode_ReturnValue_Offset;

	private static bool GetFrameRateLimit_IsValid;

	private static IntPtr GetFrameRateLimit_FunctionAddress;

	private static int GetFrameRateLimit_ParamsSize;

	private static bool GetFrameRateLimit_ReturnValue_IsValid;

	private static FFieldAddress GetFrameRateLimit_ReturnValue_PropertyAddress;

	private static int GetFrameRateLimit_ReturnValue_Offset;

	private static bool GetFramePace_IsValid;

	private static IntPtr GetFramePace_FunctionAddress;

	private static int GetFramePace_ParamsSize;

	private static bool GetFramePace_ReturnValue_IsValid;

	private static FFieldAddress GetFramePace_ReturnValue_PropertyAddress;

	private static int GetFramePace_ReturnValue_Offset;

	private static bool GetFoliageQuality_IsValid;

	private static IntPtr GetFoliageQuality_FunctionAddress;

	private static int GetFoliageQuality_ParamsSize;

	private static bool GetFoliageQuality_ReturnValue_IsValid;

	private static FFieldAddress GetFoliageQuality_ReturnValue_PropertyAddress;

	private static int GetFoliageQuality_ReturnValue_Offset;

	private static bool GetDesktopResolution_IsValid;

	private static IntPtr GetDesktopResolution_FunctionAddress;

	private static int GetDesktopResolution_ParamsSize;

	private static bool GetDesktopResolution_ReturnValue_IsValid;

	private static FFieldAddress GetDesktopResolution_ReturnValue_PropertyAddress;

	private static int GetDesktopResolution_ReturnValue_Offset;

	private static bool GetDefaultWindowPosition_IsValid;

	private static IntPtr GetDefaultWindowPosition_FunctionAddress;

	private static int GetDefaultWindowPosition_ParamsSize;

	private static bool GetDefaultWindowPosition_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultWindowPosition_ReturnValue_PropertyAddress;

	private static int GetDefaultWindowPosition_ReturnValue_Offset;

	private static bool GetDefaultWindowMode_IsValid;

	private static IntPtr GetDefaultWindowMode_FunctionAddress;

	private static int GetDefaultWindowMode_ParamsSize;

	private static bool GetDefaultWindowMode_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultWindowMode_ReturnValue_PropertyAddress;

	private static int GetDefaultWindowMode_ReturnValue_Offset;

	private static bool GetDefaultResolutionScale_IsValid;

	private static IntPtr GetDefaultResolutionScale_FunctionAddress;

	private static int GetDefaultResolutionScale_ParamsSize;

	private static bool GetDefaultResolutionScale_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultResolutionScale_ReturnValue_PropertyAddress;

	private static int GetDefaultResolutionScale_ReturnValue_Offset;

	private static bool GetDefaultResolution_IsValid;

	private static IntPtr GetDefaultResolution_FunctionAddress;

	private static int GetDefaultResolution_ParamsSize;

	private static bool GetDefaultResolution_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultResolution_ReturnValue_PropertyAddress;

	private static int GetDefaultResolution_ReturnValue_Offset;

	private static bool GetCurrentHDRDisplayNits_IsValid;

	private static IntPtr GetCurrentHDRDisplayNits_FunctionAddress;

	private static int GetCurrentHDRDisplayNits_ParamsSize;

	private static bool GetCurrentHDRDisplayNits_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentHDRDisplayNits_ReturnValue_PropertyAddress;

	private static int GetCurrentHDRDisplayNits_ReturnValue_Offset;

	private static bool GetAudioQualityLevel_IsValid;

	private static IntPtr GetAudioQualityLevel_FunctionAddress;

	private static int GetAudioQualityLevel_ParamsSize;

	private static bool GetAudioQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetAudioQualityLevel_ReturnValue_PropertyAddress;

	private static int GetAudioQualityLevel_ReturnValue_Offset;

	private static bool GetAntiAliasingQuality_IsValid;

	private static IntPtr GetAntiAliasingQuality_FunctionAddress;

	private static int GetAntiAliasingQuality_ParamsSize;

	private static bool GetAntiAliasingQuality_ReturnValue_IsValid;

	private static FFieldAddress GetAntiAliasingQuality_ReturnValue_PropertyAddress;

	private static int GetAntiAliasingQuality_ReturnValue_Offset;

	private static bool EnableHDRDisplayOutput_IsValid;

	private static IntPtr EnableHDRDisplayOutput_FunctionAddress;

	private static int EnableHDRDisplayOutput_ParamsSize;

	private static bool EnableHDRDisplayOutput_bEnable_IsValid;

	private static FFieldAddress EnableHDRDisplayOutput_bEnable_PropertyAddress;

	private static int EnableHDRDisplayOutput_bEnable_Offset;

	private static bool EnableHDRDisplayOutput_DisplayNits_IsValid;

	private static FFieldAddress EnableHDRDisplayOutput_DisplayNits_PropertyAddress;

	private static int EnableHDRDisplayOutput_DisplayNits_Offset;

	private static bool ConfirmVideoMode_IsValid;

	private static IntPtr ConfirmVideoMode_FunctionAddress;

	private static int ConfirmVideoMode_ParamsSize;

	private static bool ApplySettings_IsValid;

	private static IntPtr ApplySettings_FunctionAddress;

	private static int ApplySettings_ParamsSize;

	private static bool ApplySettings_bCheckForCommandLineOverrides_IsValid;

	private static FFieldAddress ApplySettings_bCheckForCommandLineOverrides_PropertyAddress;

	private static int ApplySettings_bCheckForCommandLineOverrides_Offset;

	private static bool ApplyResolutionSettings_IsValid;

	private static IntPtr ApplyResolutionSettings_FunctionAddress;

	private static int ApplyResolutionSettings_ParamsSize;

	private static bool ApplyResolutionSettings_bCheckForCommandLineOverrides_IsValid;

	private static FFieldAddress ApplyResolutionSettings_bCheckForCommandLineOverrides_PropertyAddress;

	private static int ApplyResolutionSettings_bCheckForCommandLineOverrides_Offset;

	private static bool ApplyNonResolutionSettings_IsValid;

	private static IntPtr ApplyNonResolutionSettings_FunctionAddress;

	private static int ApplyNonResolutionSettings_ParamsSize;

	private static bool ApplyHardwareBenchmarkResults_IsValid;

	private static IntPtr ApplyHardwareBenchmarkResults_FunctionAddress;

	private static int ApplyHardwareBenchmarkResults_ParamsSize;

	[UProperty(Flags = (PropFlags)18014398778442240uL)]
	[UMetaPath("/Script/Engine.GameUserSettings:OnGameUserSettingsUINeedsUpdate")]
	public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate
	{
		get
		{
			CheckDestroyed();
			if (!OnGameUserSettingsUINeedsUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameUserSettings:OnGameUserSettingsUINeedsUpdate");
				return new FOnGameUserSettingsUINeedsUpdate();
			}
			if (OnGameUserSettingsUINeedsUpdate_DelegateCached == null)
			{
				OnGameUserSettingsUINeedsUpdate_DelegateCached = new FOnGameUserSettingsUINeedsUpdate();
				OnGameUserSettingsUINeedsUpdate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGameUserSettingsUINeedsUpdate_Offset));
			}
			return OnGameUserSettingsUINeedsUpdate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ValidateSettings")]
	public unsafe void ValidateSettings()
	{
		CheckDestroyed();
		if (!ValidateSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ValidateSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidateSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidateSettings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ValidateSettings_FunctionAddress, argsSize: ValidateSettings_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SupportsHDRDisplayOutput")]
	public unsafe bool SupportsHDRDisplayOutput()
	{
		CheckDestroyed();
		if (!SupportsHDRDisplayOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SupportsHDRDisplayOutput");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsHDRDisplayOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsHDRDisplayOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsHDRDisplayOutput_FunctionAddress, intPtr, SupportsHDRDisplayOutput_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsHDRDisplayOutput_ReturnValue_Offset), 0, SupportsHDRDisplayOutput_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetVSyncEnabled")]
	public unsafe void SetVSyncEnabled(bool bEnable)
	{
		CheckDestroyed();
		if (!SetVSyncEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetVSyncEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVSyncEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVSyncEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVSyncEnabled_bEnable_Offset), 0, SetVSyncEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVSyncEnabled_FunctionAddress, intPtr, SetVSyncEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetVisualEffectQuality")]
	public unsafe void SetVisualEffectQuality(int Value)
	{
		CheckDestroyed();
		if (!SetVisualEffectQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetVisualEffectQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisualEffectQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisualEffectQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVisualEffectQuality_Value_Offset), 0, SetVisualEffectQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisualEffectQuality_FunctionAddress, intPtr, SetVisualEffectQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetViewDistanceQuality")]
	public unsafe void SetViewDistanceQuality(int Value)
	{
		CheckDestroyed();
		if (!SetViewDistanceQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetViewDistanceQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewDistanceQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewDistanceQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetViewDistanceQuality_Value_Offset), 0, SetViewDistanceQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewDistanceQuality_FunctionAddress, intPtr, SetViewDistanceQuality_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetToDefaults")]
	public unsafe void SetToDefaults()
	{
		CheckDestroyed();
		if (!SetToDefaults_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetToDefaults");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetToDefaults_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetToDefaults_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetToDefaults_FunctionAddress, argsSize: SetToDefaults_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetTextureQuality")]
	public unsafe void SetTextureQuality(int Value)
	{
		CheckDestroyed();
		if (!SetTextureQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetTextureQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTextureQuality_Value_Offset), 0, SetTextureQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextureQuality_FunctionAddress, intPtr, SetTextureQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetShadowQuality")]
	public unsafe void SetShadowQuality(int Value)
	{
		CheckDestroyed();
		if (!SetShadowQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetShadowQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetShadowQuality_Value_Offset), 0, SetShadowQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowQuality_FunctionAddress, intPtr, SetShadowQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetShadingQuality")]
	public unsafe void SetShadingQuality(int Value)
	{
		CheckDestroyed();
		if (!SetShadingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetShadingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetShadingQuality_Value_Offset), 0, SetShadingQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadingQuality_FunctionAddress, intPtr, SetShadingQuality_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetScreenResolution")]
	public unsafe void SetScreenResolution(FIntPoint Resolution)
	{
		CheckDestroyed();
		if (!SetScreenResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetScreenResolution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScreenResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScreenResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, SetScreenResolution_Resolution_Offset), 0, SetScreenResolution_Resolution_PropertyAddress.Address, Resolution);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScreenResolution_FunctionAddress, intPtr, SetScreenResolution_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetResolutionScaleValueEx")]
	public unsafe void SetResolutionScaleValueEx(float NewScaleValue)
	{
		CheckDestroyed();
		if (!SetResolutionScaleValueEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetResolutionScaleValueEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetResolutionScaleValueEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetResolutionScaleValueEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetResolutionScaleValueEx_NewScaleValue_Offset), 0, SetResolutionScaleValueEx_NewScaleValue_PropertyAddress.Address, NewScaleValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetResolutionScaleValueEx_FunctionAddress, intPtr, SetResolutionScaleValueEx_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetResolutionScaleNormalized")]
	public unsafe void SetResolutionScaleNormalized(float NewScaleNormalized)
	{
		CheckDestroyed();
		if (!SetResolutionScaleNormalized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetResolutionScaleNormalized");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetResolutionScaleNormalized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetResolutionScaleNormalized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetResolutionScaleNormalized_NewScaleNormalized_Offset), 0, SetResolutionScaleNormalized_NewScaleNormalized_PropertyAddress.Address, NewScaleNormalized);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetResolutionScaleNormalized_FunctionAddress, intPtr, SetResolutionScaleNormalized_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetReflectionQuality")]
	public unsafe void SetReflectionQuality(int Value)
	{
		CheckDestroyed();
		if (!SetReflectionQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetReflectionQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflectionQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflectionQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetReflectionQuality_Value_Offset), 0, SetReflectionQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReflectionQuality_FunctionAddress, intPtr, SetReflectionQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetRayTracingQuality")]
	public unsafe void SetRayTracingQuality(int Value)
	{
		CheckDestroyed();
		if (!SetRayTracingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetRayTracingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayTracingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayTracingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRayTracingQuality_Value_Offset), 0, SetRayTracingQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRayTracingQuality_FunctionAddress, intPtr, SetRayTracingQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetPostProcessingQuality")]
	public unsafe void SetPostProcessingQuality(int Value)
	{
		CheckDestroyed();
		if (!SetPostProcessingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetPostProcessingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostProcessingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostProcessingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPostProcessingQuality_Value_Offset), 0, SetPostProcessingQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPostProcessingQuality_FunctionAddress, intPtr, SetPostProcessingQuality_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetOverallScalabilityLevel")]
	public unsafe void SetOverallScalabilityLevel(int Value)
	{
		CheckDestroyed();
		if (!SetOverallScalabilityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetOverallScalabilityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOverallScalabilityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOverallScalabilityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOverallScalabilityLevel_Value_Offset), 0, SetOverallScalabilityLevel_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOverallScalabilityLevel_FunctionAddress, intPtr, SetOverallScalabilityLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetGlobalIlluminationQuality")]
	public unsafe void SetGlobalIlluminationQuality(int Value)
	{
		CheckDestroyed();
		if (!SetGlobalIlluminationQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetGlobalIlluminationQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalIlluminationQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalIlluminationQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetGlobalIlluminationQuality_Value_Offset), 0, SetGlobalIlluminationQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGlobalIlluminationQuality_FunctionAddress, intPtr, SetGlobalIlluminationQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetFullscreenMode")]
	public unsafe void SetFullscreenMode(EWindowMode InFullscreenMode)
	{
		CheckDestroyed();
		if (!SetFullscreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetFullscreenMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFullscreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFullscreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWindowMode>.ToNative(IntPtr.Add(intPtr, SetFullscreenMode_InFullscreenMode_Offset), 0, SetFullscreenMode_InFullscreenMode_PropertyAddress.Address, InFullscreenMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFullscreenMode_FunctionAddress, intPtr, SetFullscreenMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetFrameRateLimit")]
	public unsafe void SetFrameRateLimit(float NewLimit)
	{
		CheckDestroyed();
		if (!SetFrameRateLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetFrameRateLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRateLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRateLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrameRateLimit_NewLimit_Offset), 0, SetFrameRateLimit_NewLimit_PropertyAddress.Address, NewLimit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrameRateLimit_FunctionAddress, intPtr, SetFrameRateLimit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetFoliageQuality")]
	public unsafe void SetFoliageQuality(int Value)
	{
		CheckDestroyed();
		if (!SetFoliageQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetFoliageQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFoliageQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFoliageQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetFoliageQuality_Value_Offset), 0, SetFoliageQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFoliageQuality_FunctionAddress, intPtr, SetFoliageQuality_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetDynamicResolutionEnabled")]
	public unsafe void SetDynamicResolutionEnabled(bool bEnable)
	{
		CheckDestroyed();
		if (!SetDynamicResolutionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetDynamicResolutionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicResolutionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicResolutionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDynamicResolutionEnabled_bEnable_Offset), 0, SetDynamicResolutionEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicResolutionEnabled_FunctionAddress, intPtr, SetDynamicResolutionEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetBenchmarkFallbackValues")]
	public unsafe void SetBenchmarkFallbackValues()
	{
		CheckDestroyed();
		if (!SetBenchmarkFallbackValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetBenchmarkFallbackValues");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBenchmarkFallbackValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBenchmarkFallbackValues_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetBenchmarkFallbackValues_FunctionAddress, argsSize: SetBenchmarkFallbackValues_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetAudioQualityLevel")]
	public unsafe void SetAudioQualityLevel(int QualityLevel)
	{
		CheckDestroyed();
		if (!SetAudioQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetAudioQualityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAudioQualityLevel_QualityLevel_Offset), 0, SetAudioQualityLevel_QualityLevel_PropertyAddress.Address, QualityLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioQualityLevel_FunctionAddress, intPtr, SetAudioQualityLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SetAntiAliasingQuality")]
	public unsafe void SetAntiAliasingQuality(int Value)
	{
		CheckDestroyed();
		if (!SetAntiAliasingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SetAntiAliasingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAntiAliasingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAntiAliasingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAntiAliasingQuality_Value_Offset), 0, SetAntiAliasingQuality_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAntiAliasingQuality_FunctionAddress, intPtr, SetAntiAliasingQuality_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:SaveSettings")]
	public unsafe void SaveSettings()
	{
		CheckDestroyed();
		if (!SaveSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:SaveSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveSettings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SaveSettings_FunctionAddress, argsSize: SaveSettings_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:RunHardwareBenchmark")]
	public unsafe void RunHardwareBenchmark(int WorkScale = 10, float CPUMultiplier = 1f, float GPUMultiplier = 1f)
	{
		CheckDestroyed();
		if (!RunHardwareBenchmark_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:RunHardwareBenchmark");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunHardwareBenchmark_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunHardwareBenchmark_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RunHardwareBenchmark_WorkScale_Offset), 0, RunHardwareBenchmark_WorkScale_PropertyAddress.Address, WorkScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RunHardwareBenchmark_CPUMultiplier_Offset), 0, RunHardwareBenchmark_CPUMultiplier_PropertyAddress.Address, CPUMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RunHardwareBenchmark_GPUMultiplier_Offset), 0, RunHardwareBenchmark_GPUMultiplier_PropertyAddress.Address, GPUMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunHardwareBenchmark_FunctionAddress, intPtr, RunHardwareBenchmark_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:RevertVideoMode")]
	public unsafe void RevertVideoMode()
	{
		CheckDestroyed();
		if (!RevertVideoMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:RevertVideoMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RevertVideoMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RevertVideoMode_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RevertVideoMode_FunctionAddress, argsSize: RevertVideoMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ResetToCurrentSettings")]
	public unsafe void ResetToCurrentSettings()
	{
		CheckDestroyed();
		if (!ResetToCurrentSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ResetToCurrentSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetToCurrentSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetToCurrentSettings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetToCurrentSettings_FunctionAddress, argsSize: ResetToCurrentSettings_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:LoadSettings")]
	public unsafe void LoadSettings(bool bForceReload = false)
	{
		CheckDestroyed();
		if (!LoadSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:LoadSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LoadSettings_bForceReload_Offset), 0, LoadSettings_bForceReload_PropertyAddress.Address, bForceReload);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadSettings_FunctionAddress, intPtr, LoadSettings_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsVSyncEnabled")]
	public unsafe bool IsVSyncEnabled()
	{
		CheckDestroyed();
		if (!IsVSyncEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsVSyncEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVSyncEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVSyncEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVSyncEnabled_FunctionAddress, intPtr, IsVSyncEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVSyncEnabled_ReturnValue_Offset), 0, IsVSyncEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsVSyncDirty")]
	public unsafe bool IsVSyncDirty()
	{
		CheckDestroyed();
		if (!IsVSyncDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsVSyncDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVSyncDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVSyncDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVSyncDirty_FunctionAddress, intPtr, IsVSyncDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVSyncDirty_ReturnValue_Offset), 0, IsVSyncDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsScreenResolutionDirty")]
	public unsafe bool IsScreenResolutionDirty()
	{
		CheckDestroyed();
		if (!IsScreenResolutionDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsScreenResolutionDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsScreenResolutionDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsScreenResolutionDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsScreenResolutionDirty_FunctionAddress, intPtr, IsScreenResolutionDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsScreenResolutionDirty_ReturnValue_Offset), 0, IsScreenResolutionDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsHDREnabled")]
	public unsafe bool IsHDREnabled()
	{
		CheckDestroyed();
		if (!IsHDREnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsHDREnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHDREnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHDREnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHDREnabled_FunctionAddress, intPtr, IsHDREnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHDREnabled_ReturnValue_Offset), 0, IsHDREnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsFullscreenModeDirty")]
	public unsafe bool IsFullscreenModeDirty()
	{
		CheckDestroyed();
		if (!IsFullscreenModeDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsFullscreenModeDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFullscreenModeDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFullscreenModeDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsFullscreenModeDirty_FunctionAddress, intPtr, IsFullscreenModeDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsFullscreenModeDirty_ReturnValue_Offset), 0, IsFullscreenModeDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsDynamicResolutionEnabled")]
	public unsafe bool IsDynamicResolutionEnabled()
	{
		CheckDestroyed();
		if (!IsDynamicResolutionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsDynamicResolutionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDynamicResolutionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDynamicResolutionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDynamicResolutionEnabled_FunctionAddress, intPtr, IsDynamicResolutionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDynamicResolutionEnabled_ReturnValue_Offset), 0, IsDynamicResolutionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsDynamicResolutionDirty")]
	public unsafe bool IsDynamicResolutionDirty()
	{
		CheckDestroyed();
		if (!IsDynamicResolutionDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsDynamicResolutionDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDynamicResolutionDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDynamicResolutionDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDynamicResolutionDirty_FunctionAddress, intPtr, IsDynamicResolutionDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDynamicResolutionDirty_ReturnValue_Offset), 0, IsDynamicResolutionDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameUserSettings:IsDirty")]
	public unsafe bool IsDirty()
	{
		CheckDestroyed();
		if (!IsDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:IsDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDirty_FunctionAddress, intPtr, IsDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDirty_ReturnValue_Offset), 0, IsDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetVisualEffectQuality")]
	public unsafe int GetVisualEffectQuality()
	{
		CheckDestroyed();
		if (!GetVisualEffectQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetVisualEffectQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVisualEffectQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVisualEffectQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVisualEffectQuality_FunctionAddress, intPtr, GetVisualEffectQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVisualEffectQuality_ReturnValue_Offset), 0, GetVisualEffectQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetViewDistanceQuality")]
	public unsafe int GetViewDistanceQuality()
	{
		CheckDestroyed();
		if (!GetViewDistanceQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetViewDistanceQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewDistanceQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewDistanceQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewDistanceQuality_FunctionAddress, intPtr, GetViewDistanceQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetViewDistanceQuality_ReturnValue_Offset), 0, GetViewDistanceQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetTextureQuality")]
	public unsafe int GetTextureQuality()
	{
		CheckDestroyed();
		if (!GetTextureQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetTextureQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureQuality_FunctionAddress, intPtr, GetTextureQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureQuality_ReturnValue_Offset), 0, GetTextureQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetSyncInterval")]
	public unsafe static int GetSyncInterval()
	{
		if (!GetSyncInterval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetSyncInterval");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSyncInterval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSyncInterval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSyncInterval_FunctionAddress, intPtr, GetSyncInterval_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSyncInterval_ReturnValue_Offset), 0, GetSyncInterval_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetShadowQuality")]
	public unsafe int GetShadowQuality()
	{
		CheckDestroyed();
		if (!GetShadowQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetShadowQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShadowQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShadowQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShadowQuality_FunctionAddress, intPtr, GetShadowQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShadowQuality_ReturnValue_Offset), 0, GetShadowQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetShadingQuality")]
	public unsafe int GetShadingQuality()
	{
		CheckDestroyed();
		if (!GetShadingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetShadingQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShadingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShadingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetShadingQuality_FunctionAddress, intPtr, GetShadingQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShadingQuality_ReturnValue_Offset), 0, GetShadingQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetScreenResolution")]
	public unsafe FIntPoint GetScreenResolution()
	{
		CheckDestroyed();
		if (!GetScreenResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetScreenResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScreenResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScreenResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScreenResolution_FunctionAddress, intPtr, GetScreenResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetScreenResolution_ReturnValue_Offset), 0, GetScreenResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetResolutionScaleNormalized")]
	public unsafe float GetResolutionScaleNormalized()
	{
		CheckDestroyed();
		if (!GetResolutionScaleNormalized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetResolutionScaleNormalized");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetResolutionScaleNormalized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetResolutionScaleNormalized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetResolutionScaleNormalized_FunctionAddress, intPtr, GetResolutionScaleNormalized_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleNormalized_ReturnValue_Offset), 0, GetResolutionScaleNormalized_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetResolutionScaleInformationEx")]
	public unsafe void GetResolutionScaleInformationEx(out float CurrentScaleNormalized, out float CurrentScaleValue, out float MinScaleValue, out float MaxScaleValue)
	{
		CheckDestroyed();
		if (!GetResolutionScaleInformationEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetResolutionScaleInformationEx");
			CurrentScaleNormalized = 0f;
			CurrentScaleValue = 0f;
			MinScaleValue = 0f;
			MaxScaleValue = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetResolutionScaleInformationEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetResolutionScaleInformationEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetResolutionScaleInformationEx_FunctionAddress, intPtr, GetResolutionScaleInformationEx_ParamsSize);
		CurrentScaleNormalized = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleInformationEx_CurrentScaleNormalized_Offset), 0, GetResolutionScaleInformationEx_CurrentScaleNormalized_PropertyAddress.Address);
		CurrentScaleValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleInformationEx_CurrentScaleValue_Offset), 0, GetResolutionScaleInformationEx_CurrentScaleValue_PropertyAddress.Address);
		MinScaleValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleInformationEx_MinScaleValue_Offset), 0, GetResolutionScaleInformationEx_MinScaleValue_PropertyAddress.Address);
		MaxScaleValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleInformationEx_MaxScaleValue_Offset), 0, GetResolutionScaleInformationEx_MaxScaleValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetReflectionQuality")]
	public unsafe int GetReflectionQuality()
	{
		CheckDestroyed();
		if (!GetReflectionQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetReflectionQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReflectionQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReflectionQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReflectionQuality_FunctionAddress, intPtr, GetReflectionQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetReflectionQuality_ReturnValue_Offset), 0, GetReflectionQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetRecommendedResolutionScale")]
	public unsafe float GetRecommendedResolutionScale()
	{
		CheckDestroyed();
		if (!GetRecommendedResolutionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetRecommendedResolutionScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRecommendedResolutionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRecommendedResolutionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRecommendedResolutionScale_FunctionAddress, intPtr, GetRecommendedResolutionScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRecommendedResolutionScale_ReturnValue_Offset), 0, GetRecommendedResolutionScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetRayTracingQuality")]
	public unsafe int GetRayTracingQuality()
	{
		CheckDestroyed();
		if (!GetRayTracingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetRayTracingQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRayTracingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRayTracingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRayTracingQuality_FunctionAddress, intPtr, GetRayTracingQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRayTracingQuality_ReturnValue_Offset), 0, GetRayTracingQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetPreferredFullscreenMode")]
	public unsafe EWindowMode GetPreferredFullscreenMode()
	{
		CheckDestroyed();
		if (!GetPreferredFullscreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetPreferredFullscreenMode");
			return EWindowMode.Fullscreen;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreferredFullscreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreferredFullscreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreferredFullscreenMode_FunctionAddress, intPtr, GetPreferredFullscreenMode_ParamsSize);
		return EnumMarshaler<EWindowMode>.FromNative(IntPtr.Add(intPtr, GetPreferredFullscreenMode_ReturnValue_Offset), 0, GetPreferredFullscreenMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetPostProcessingQuality")]
	public unsafe int GetPostProcessingQuality()
	{
		CheckDestroyed();
		if (!GetPostProcessingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetPostProcessingQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPostProcessingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPostProcessingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPostProcessingQuality_FunctionAddress, intPtr, GetPostProcessingQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPostProcessingQuality_ReturnValue_Offset), 0, GetPostProcessingQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetOverallScalabilityLevel")]
	public unsafe int GetOverallScalabilityLevel()
	{
		CheckDestroyed();
		if (!GetOverallScalabilityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetOverallScalabilityLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOverallScalabilityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOverallScalabilityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOverallScalabilityLevel_FunctionAddress, intPtr, GetOverallScalabilityLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetOverallScalabilityLevel_ReturnValue_Offset), 0, GetOverallScalabilityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetLastConfirmedScreenResolution")]
	public unsafe FIntPoint GetLastConfirmedScreenResolution()
	{
		CheckDestroyed();
		if (!GetLastConfirmedScreenResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetLastConfirmedScreenResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastConfirmedScreenResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastConfirmedScreenResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastConfirmedScreenResolution_FunctionAddress, intPtr, GetLastConfirmedScreenResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetLastConfirmedScreenResolution_ReturnValue_Offset), 0, GetLastConfirmedScreenResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetLastConfirmedFullscreenMode")]
	public unsafe EWindowMode GetLastConfirmedFullscreenMode()
	{
		CheckDestroyed();
		if (!GetLastConfirmedFullscreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetLastConfirmedFullscreenMode");
			return EWindowMode.Fullscreen;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastConfirmedFullscreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastConfirmedFullscreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastConfirmedFullscreenMode_FunctionAddress, intPtr, GetLastConfirmedFullscreenMode_ParamsSize);
		return EnumMarshaler<EWindowMode>.FromNative(IntPtr.Add(intPtr, GetLastConfirmedFullscreenMode_ReturnValue_Offset), 0, GetLastConfirmedFullscreenMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetGlobalIlluminationQuality")]
	public unsafe int GetGlobalIlluminationQuality()
	{
		CheckDestroyed();
		if (!GetGlobalIlluminationQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetGlobalIlluminationQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalIlluminationQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalIlluminationQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalIlluminationQuality_FunctionAddress, intPtr, GetGlobalIlluminationQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetGlobalIlluminationQuality_ReturnValue_Offset), 0, GetGlobalIlluminationQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetGameUserSettings")]
	public unsafe static UGameUserSettings GetGameUserSettings()
	{
		if (!GetGameUserSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetGameUserSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameUserSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameUserSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameUserSettings_FunctionAddress, intPtr, GetGameUserSettings_ParamsSize);
		return UObjectMarshaler<UGameUserSettings>.FromNative(IntPtr.Add(intPtr, GetGameUserSettings_ReturnValue_Offset), 0, GetGameUserSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetFullscreenMode")]
	public unsafe EWindowMode GetFullscreenMode()
	{
		CheckDestroyed();
		if (!GetFullscreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetFullscreenMode");
			return EWindowMode.Fullscreen;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFullscreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFullscreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFullscreenMode_FunctionAddress, intPtr, GetFullscreenMode_ParamsSize);
		return EnumMarshaler<EWindowMode>.FromNative(IntPtr.Add(intPtr, GetFullscreenMode_ReturnValue_Offset), 0, GetFullscreenMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetFrameRateLimit")]
	public unsafe float GetFrameRateLimit()
	{
		CheckDestroyed();
		if (!GetFrameRateLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetFrameRateLimit");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameRateLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameRateLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameRateLimit_FunctionAddress, intPtr, GetFrameRateLimit_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFrameRateLimit_ReturnValue_Offset), 0, GetFrameRateLimit_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetFramePace")]
	public unsafe static int GetFramePace()
	{
		if (!GetFramePace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetFramePace");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFramePace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFramePace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFramePace_FunctionAddress, intPtr, GetFramePace_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFramePace_ReturnValue_Offset), 0, GetFramePace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetFoliageQuality")]
	public unsafe int GetFoliageQuality()
	{
		CheckDestroyed();
		if (!GetFoliageQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetFoliageQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFoliageQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFoliageQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFoliageQuality_FunctionAddress, intPtr, GetFoliageQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFoliageQuality_ReturnValue_Offset), 0, GetFoliageQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetDesktopResolution")]
	public unsafe FIntPoint GetDesktopResolution()
	{
		CheckDestroyed();
		if (!GetDesktopResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetDesktopResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesktopResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesktopResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesktopResolution_FunctionAddress, intPtr, GetDesktopResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetDesktopResolution_ReturnValue_Offset), 0, GetDesktopResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetDefaultWindowPosition")]
	public unsafe static FIntPoint GetDefaultWindowPosition()
	{
		if (!GetDefaultWindowPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetDefaultWindowPosition");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultWindowPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultWindowPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultWindowPosition_FunctionAddress, intPtr, GetDefaultWindowPosition_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetDefaultWindowPosition_ReturnValue_Offset), 0, GetDefaultWindowPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetDefaultWindowMode")]
	public unsafe static EWindowMode GetDefaultWindowMode()
	{
		if (!GetDefaultWindowMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetDefaultWindowMode");
			return EWindowMode.Fullscreen;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultWindowMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultWindowMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultWindowMode_FunctionAddress, intPtr, GetDefaultWindowMode_ParamsSize);
		return EnumMarshaler<EWindowMode>.FromNative(IntPtr.Add(intPtr, GetDefaultWindowMode_ReturnValue_Offset), 0, GetDefaultWindowMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetDefaultResolutionScale")]
	public unsafe float GetDefaultResolutionScale()
	{
		CheckDestroyed();
		if (!GetDefaultResolutionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetDefaultResolutionScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultResolutionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultResolutionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultResolutionScale_FunctionAddress, intPtr, GetDefaultResolutionScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultResolutionScale_ReturnValue_Offset), 0, GetDefaultResolutionScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetDefaultResolution")]
	public unsafe static FIntPoint GetDefaultResolution()
	{
		if (!GetDefaultResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetDefaultResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultResolution_FunctionAddress, intPtr, GetDefaultResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetDefaultResolution_ReturnValue_Offset), 0, GetDefaultResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetCurrentHDRDisplayNits")]
	public unsafe int GetCurrentHDRDisplayNits()
	{
		CheckDestroyed();
		if (!GetCurrentHDRDisplayNits_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetCurrentHDRDisplayNits");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentHDRDisplayNits_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentHDRDisplayNits_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentHDRDisplayNits_FunctionAddress, intPtr, GetCurrentHDRDisplayNits_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentHDRDisplayNits_ReturnValue_Offset), 0, GetCurrentHDRDisplayNits_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetAudioQualityLevel")]
	public unsafe int GetAudioQualityLevel()
	{
		CheckDestroyed();
		if (!GetAudioQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetAudioQualityLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioQualityLevel_FunctionAddress, intPtr, GetAudioQualityLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAudioQualityLevel_ReturnValue_Offset), 0, GetAudioQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.GameUserSettings:GetAntiAliasingQuality")]
	public unsafe int GetAntiAliasingQuality()
	{
		CheckDestroyed();
		if (!GetAntiAliasingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:GetAntiAliasingQuality");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAntiAliasingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAntiAliasingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAntiAliasingQuality_FunctionAddress, intPtr, GetAntiAliasingQuality_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAntiAliasingQuality_ReturnValue_Offset), 0, GetAntiAliasingQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:EnableHDRDisplayOutput")]
	public unsafe void EnableHDRDisplayOutput(bool bEnable, int DisplayNits = 1000)
	{
		CheckDestroyed();
		if (!EnableHDRDisplayOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:EnableHDRDisplayOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableHDRDisplayOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableHDRDisplayOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableHDRDisplayOutput_bEnable_Offset), 0, EnableHDRDisplayOutput_bEnable_PropertyAddress.Address, bEnable);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, EnableHDRDisplayOutput_DisplayNits_Offset), 0, EnableHDRDisplayOutput_DisplayNits_PropertyAddress.Address, DisplayNits);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableHDRDisplayOutput_FunctionAddress, intPtr, EnableHDRDisplayOutput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ConfirmVideoMode")]
	public unsafe void ConfirmVideoMode()
	{
		CheckDestroyed();
		if (!ConfirmVideoMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ConfirmVideoMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConfirmVideoMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConfirmVideoMode_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConfirmVideoMode_FunctionAddress, argsSize: ConfirmVideoMode_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ApplySettings")]
	public unsafe void ApplySettings(bool bCheckForCommandLineOverrides)
	{
		CheckDestroyed();
		if (!ApplySettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ApplySettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplySettings_bCheckForCommandLineOverrides_Offset), 0, ApplySettings_bCheckForCommandLineOverrides_PropertyAddress.Address, bCheckForCommandLineOverrides);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplySettings_FunctionAddress, intPtr, ApplySettings_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ApplyResolutionSettings")]
	public unsafe void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
	{
		CheckDestroyed();
		if (!ApplyResolutionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ApplyResolutionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyResolutionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyResolutionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyResolutionSettings_bCheckForCommandLineOverrides_Offset), 0, ApplyResolutionSettings_bCheckForCommandLineOverrides_PropertyAddress.Address, bCheckForCommandLineOverrides);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyResolutionSettings_FunctionAddress, intPtr, ApplyResolutionSettings_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ApplyNonResolutionSettings")]
	public unsafe void ApplyNonResolutionSettings()
	{
		CheckDestroyed();
		if (!ApplyNonResolutionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ApplyNonResolutionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyNonResolutionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyNonResolutionSettings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ApplyNonResolutionSettings_FunctionAddress, argsSize: ApplyNonResolutionSettings_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.GameUserSettings:ApplyHardwareBenchmarkResults")]
	public unsafe void ApplyHardwareBenchmarkResults()
	{
		CheckDestroyed();
		if (!ApplyHardwareBenchmarkResults_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameUserSettings:ApplyHardwareBenchmarkResults");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyHardwareBenchmarkResults_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyHardwareBenchmarkResults_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ApplyHardwareBenchmarkResults_FunctionAddress, argsSize: ApplyHardwareBenchmarkResults_ParamsSize);
	}

	static UGameUserSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameUserSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameUserSettings));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.GameUserSettings");
		OnGameUserSettingsUINeedsUpdate_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnGameUserSettingsUINeedsUpdate");
		OnGameUserSettingsUINeedsUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnGameUserSettingsUINeedsUpdate", Classes.FMulticastDelegateProperty);
		ValidateSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ValidateSettings");
		ValidateSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidateSettings_FunctionAddress);
		ValidateSettings_IsValid = ValidateSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ValidateSettings", ValidateSettings_IsValid);
		SupportsHDRDisplayOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SupportsHDRDisplayOutput");
		SupportsHDRDisplayOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsHDRDisplayOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsHDRDisplayOutput_ReturnValue_PropertyAddress, SupportsHDRDisplayOutput_FunctionAddress, "ReturnValue");
		SupportsHDRDisplayOutput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsHDRDisplayOutput_FunctionAddress, "ReturnValue");
		SupportsHDRDisplayOutput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsHDRDisplayOutput_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsHDRDisplayOutput_IsValid = SupportsHDRDisplayOutput_FunctionAddress != IntPtr.Zero && SupportsHDRDisplayOutput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SupportsHDRDisplayOutput", SupportsHDRDisplayOutput_IsValid);
		SetVSyncEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVSyncEnabled");
		SetVSyncEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVSyncEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVSyncEnabled_bEnable_PropertyAddress, SetVSyncEnabled_FunctionAddress, "bEnable");
		SetVSyncEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetVSyncEnabled_FunctionAddress, "bEnable");
		SetVSyncEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVSyncEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetVSyncEnabled_IsValid = SetVSyncEnabled_FunctionAddress != IntPtr.Zero && SetVSyncEnabled_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetVSyncEnabled", SetVSyncEnabled_IsValid);
		SetVisualEffectQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVisualEffectQuality");
		SetVisualEffectQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisualEffectQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisualEffectQuality_Value_PropertyAddress, SetVisualEffectQuality_FunctionAddress, "Value");
		SetVisualEffectQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVisualEffectQuality_FunctionAddress, "Value");
		SetVisualEffectQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisualEffectQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetVisualEffectQuality_IsValid = SetVisualEffectQuality_FunctionAddress != IntPtr.Zero && SetVisualEffectQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetVisualEffectQuality", SetVisualEffectQuality_IsValid);
		SetViewDistanceQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewDistanceQuality");
		SetViewDistanceQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewDistanceQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewDistanceQuality_Value_PropertyAddress, SetViewDistanceQuality_FunctionAddress, "Value");
		SetViewDistanceQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetViewDistanceQuality_FunctionAddress, "Value");
		SetViewDistanceQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewDistanceQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetViewDistanceQuality_IsValid = SetViewDistanceQuality_FunctionAddress != IntPtr.Zero && SetViewDistanceQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetViewDistanceQuality", SetViewDistanceQuality_IsValid);
		SetToDefaults_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetToDefaults");
		SetToDefaults_ParamsSize = NativeReflection.GetFunctionParamsSize(SetToDefaults_FunctionAddress);
		SetToDefaults_IsValid = SetToDefaults_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetToDefaults", SetToDefaults_IsValid);
		SetTextureQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextureQuality");
		SetTextureQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureQuality_Value_PropertyAddress, SetTextureQuality_FunctionAddress, "Value");
		SetTextureQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureQuality_FunctionAddress, "Value");
		SetTextureQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetTextureQuality_IsValid = SetTextureQuality_FunctionAddress != IntPtr.Zero && SetTextureQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetTextureQuality", SetTextureQuality_IsValid);
		SetShadowQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetShadowQuality");
		SetShadowQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowQuality_Value_PropertyAddress, SetShadowQuality_FunctionAddress, "Value");
		SetShadowQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowQuality_FunctionAddress, "Value");
		SetShadowQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetShadowQuality_IsValid = SetShadowQuality_FunctionAddress != IntPtr.Zero && SetShadowQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetShadowQuality", SetShadowQuality_IsValid);
		SetShadingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetShadingQuality");
		SetShadingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadingQuality_Value_PropertyAddress, SetShadingQuality_FunctionAddress, "Value");
		SetShadingQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetShadingQuality_FunctionAddress, "Value");
		SetShadingQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadingQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetShadingQuality_IsValid = SetShadingQuality_FunctionAddress != IntPtr.Zero && SetShadingQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetShadingQuality", SetShadingQuality_IsValid);
		SetScreenResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScreenResolution");
		SetScreenResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScreenResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScreenResolution_Resolution_PropertyAddress, SetScreenResolution_FunctionAddress, "Resolution");
		SetScreenResolution_Resolution_Offset = NativeReflectionCached.GetPropertyOffset(SetScreenResolution_FunctionAddress, "Resolution");
		SetScreenResolution_Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScreenResolution_FunctionAddress, "Resolution", Classes.FStructProperty);
		SetScreenResolution_IsValid = SetScreenResolution_FunctionAddress != IntPtr.Zero && SetScreenResolution_Resolution_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetScreenResolution", SetScreenResolution_IsValid);
		SetResolutionScaleValueEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetResolutionScaleValueEx");
		SetResolutionScaleValueEx_ParamsSize = NativeReflection.GetFunctionParamsSize(SetResolutionScaleValueEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetResolutionScaleValueEx_NewScaleValue_PropertyAddress, SetResolutionScaleValueEx_FunctionAddress, "NewScaleValue");
		SetResolutionScaleValueEx_NewScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(SetResolutionScaleValueEx_FunctionAddress, "NewScaleValue");
		SetResolutionScaleValueEx_NewScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetResolutionScaleValueEx_FunctionAddress, "NewScaleValue", Classes.FFloatProperty);
		SetResolutionScaleValueEx_IsValid = SetResolutionScaleValueEx_FunctionAddress != IntPtr.Zero && SetResolutionScaleValueEx_NewScaleValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetResolutionScaleValueEx", SetResolutionScaleValueEx_IsValid);
		SetResolutionScaleNormalized_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetResolutionScaleNormalized");
		SetResolutionScaleNormalized_ParamsSize = NativeReflection.GetFunctionParamsSize(SetResolutionScaleNormalized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetResolutionScaleNormalized_NewScaleNormalized_PropertyAddress, SetResolutionScaleNormalized_FunctionAddress, "NewScaleNormalized");
		SetResolutionScaleNormalized_NewScaleNormalized_Offset = NativeReflectionCached.GetPropertyOffset(SetResolutionScaleNormalized_FunctionAddress, "NewScaleNormalized");
		SetResolutionScaleNormalized_NewScaleNormalized_IsValid = NativeReflectionCached.ValidatePropertyClass(SetResolutionScaleNormalized_FunctionAddress, "NewScaleNormalized", Classes.FFloatProperty);
		SetResolutionScaleNormalized_IsValid = SetResolutionScaleNormalized_FunctionAddress != IntPtr.Zero && SetResolutionScaleNormalized_NewScaleNormalized_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetResolutionScaleNormalized", SetResolutionScaleNormalized_IsValid);
		SetReflectionQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetReflectionQuality");
		SetReflectionQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflectionQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionQuality_Value_PropertyAddress, SetReflectionQuality_FunctionAddress, "Value");
		SetReflectionQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionQuality_FunctionAddress, "Value");
		SetReflectionQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetReflectionQuality_IsValid = SetReflectionQuality_FunctionAddress != IntPtr.Zero && SetReflectionQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetReflectionQuality", SetReflectionQuality_IsValid);
		SetRayTracingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRayTracingQuality");
		SetRayTracingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayTracingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayTracingQuality_Value_PropertyAddress, SetRayTracingQuality_FunctionAddress, "Value");
		SetRayTracingQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRayTracingQuality_FunctionAddress, "Value");
		SetRayTracingQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayTracingQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetRayTracingQuality_IsValid = SetRayTracingQuality_FunctionAddress != IntPtr.Zero && SetRayTracingQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetRayTracingQuality", SetRayTracingQuality_IsValid);
		SetPostProcessingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPostProcessingQuality");
		SetPostProcessingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostProcessingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostProcessingQuality_Value_PropertyAddress, SetPostProcessingQuality_FunctionAddress, "Value");
		SetPostProcessingQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetPostProcessingQuality_FunctionAddress, "Value");
		SetPostProcessingQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostProcessingQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetPostProcessingQuality_IsValid = SetPostProcessingQuality_FunctionAddress != IntPtr.Zero && SetPostProcessingQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetPostProcessingQuality", SetPostProcessingQuality_IsValid);
		SetOverallScalabilityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOverallScalabilityLevel");
		SetOverallScalabilityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOverallScalabilityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOverallScalabilityLevel_Value_PropertyAddress, SetOverallScalabilityLevel_FunctionAddress, "Value");
		SetOverallScalabilityLevel_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetOverallScalabilityLevel_FunctionAddress, "Value");
		SetOverallScalabilityLevel_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOverallScalabilityLevel_FunctionAddress, "Value", Classes.FIntProperty);
		SetOverallScalabilityLevel_IsValid = SetOverallScalabilityLevel_FunctionAddress != IntPtr.Zero && SetOverallScalabilityLevel_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetOverallScalabilityLevel", SetOverallScalabilityLevel_IsValid);
		SetGlobalIlluminationQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGlobalIlluminationQuality");
		SetGlobalIlluminationQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalIlluminationQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalIlluminationQuality_Value_PropertyAddress, SetGlobalIlluminationQuality_FunctionAddress, "Value");
		SetGlobalIlluminationQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalIlluminationQuality_FunctionAddress, "Value");
		SetGlobalIlluminationQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalIlluminationQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetGlobalIlluminationQuality_IsValid = SetGlobalIlluminationQuality_FunctionAddress != IntPtr.Zero && SetGlobalIlluminationQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetGlobalIlluminationQuality", SetGlobalIlluminationQuality_IsValid);
		SetFullscreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFullscreenMode");
		SetFullscreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFullscreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFullscreenMode_InFullscreenMode_PropertyAddress, SetFullscreenMode_FunctionAddress, "InFullscreenMode");
		SetFullscreenMode_InFullscreenMode_Offset = NativeReflectionCached.GetPropertyOffset(SetFullscreenMode_FunctionAddress, "InFullscreenMode");
		SetFullscreenMode_InFullscreenMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFullscreenMode_FunctionAddress, "InFullscreenMode", Classes.FByteProperty);
		SetFullscreenMode_IsValid = SetFullscreenMode_FunctionAddress != IntPtr.Zero && SetFullscreenMode_InFullscreenMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetFullscreenMode", SetFullscreenMode_IsValid);
		SetFrameRateLimit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFrameRateLimit");
		SetFrameRateLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRateLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRateLimit_NewLimit_PropertyAddress, SetFrameRateLimit_FunctionAddress, "NewLimit");
		SetFrameRateLimit_NewLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRateLimit_FunctionAddress, "NewLimit");
		SetFrameRateLimit_NewLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRateLimit_FunctionAddress, "NewLimit", Classes.FFloatProperty);
		SetFrameRateLimit_IsValid = SetFrameRateLimit_FunctionAddress != IntPtr.Zero && SetFrameRateLimit_NewLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetFrameRateLimit", SetFrameRateLimit_IsValid);
		SetFoliageQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFoliageQuality");
		SetFoliageQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFoliageQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFoliageQuality_Value_PropertyAddress, SetFoliageQuality_FunctionAddress, "Value");
		SetFoliageQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFoliageQuality_FunctionAddress, "Value");
		SetFoliageQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFoliageQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetFoliageQuality_IsValid = SetFoliageQuality_FunctionAddress != IntPtr.Zero && SetFoliageQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetFoliageQuality", SetFoliageQuality_IsValid);
		SetDynamicResolutionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDynamicResolutionEnabled");
		SetDynamicResolutionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicResolutionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicResolutionEnabled_bEnable_PropertyAddress, SetDynamicResolutionEnabled_FunctionAddress, "bEnable");
		SetDynamicResolutionEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicResolutionEnabled_FunctionAddress, "bEnable");
		SetDynamicResolutionEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicResolutionEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetDynamicResolutionEnabled_IsValid = SetDynamicResolutionEnabled_FunctionAddress != IntPtr.Zero && SetDynamicResolutionEnabled_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetDynamicResolutionEnabled", SetDynamicResolutionEnabled_IsValid);
		SetBenchmarkFallbackValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBenchmarkFallbackValues");
		SetBenchmarkFallbackValues_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBenchmarkFallbackValues_FunctionAddress);
		SetBenchmarkFallbackValues_IsValid = SetBenchmarkFallbackValues_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetBenchmarkFallbackValues", SetBenchmarkFallbackValues_IsValid);
		SetAudioQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAudioQualityLevel");
		SetAudioQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioQualityLevel_QualityLevel_PropertyAddress, SetAudioQualityLevel_FunctionAddress, "QualityLevel");
		SetAudioQualityLevel_QualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioQualityLevel_FunctionAddress, "QualityLevel");
		SetAudioQualityLevel_QualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioQualityLevel_FunctionAddress, "QualityLevel", Classes.FIntProperty);
		SetAudioQualityLevel_IsValid = SetAudioQualityLevel_FunctionAddress != IntPtr.Zero && SetAudioQualityLevel_QualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetAudioQualityLevel", SetAudioQualityLevel_IsValid);
		SetAntiAliasingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAntiAliasingQuality");
		SetAntiAliasingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAntiAliasingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAntiAliasingQuality_Value_PropertyAddress, SetAntiAliasingQuality_FunctionAddress, "Value");
		SetAntiAliasingQuality_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetAntiAliasingQuality_FunctionAddress, "Value");
		SetAntiAliasingQuality_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAntiAliasingQuality_FunctionAddress, "Value", Classes.FIntProperty);
		SetAntiAliasingQuality_IsValid = SetAntiAliasingQuality_FunctionAddress != IntPtr.Zero && SetAntiAliasingQuality_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SetAntiAliasingQuality", SetAntiAliasingQuality_IsValid);
		SaveSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveSettings");
		SaveSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveSettings_FunctionAddress);
		SaveSettings_IsValid = SaveSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:SaveSettings", SaveSettings_IsValid);
		RunHardwareBenchmark_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunHardwareBenchmark");
		RunHardwareBenchmark_ParamsSize = NativeReflection.GetFunctionParamsSize(RunHardwareBenchmark_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunHardwareBenchmark_WorkScale_PropertyAddress, RunHardwareBenchmark_FunctionAddress, "WorkScale");
		RunHardwareBenchmark_WorkScale_Offset = NativeReflectionCached.GetPropertyOffset(RunHardwareBenchmark_FunctionAddress, "WorkScale");
		RunHardwareBenchmark_WorkScale_IsValid = NativeReflectionCached.ValidatePropertyClass(RunHardwareBenchmark_FunctionAddress, "WorkScale", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RunHardwareBenchmark_CPUMultiplier_PropertyAddress, RunHardwareBenchmark_FunctionAddress, "CPUMultiplier");
		RunHardwareBenchmark_CPUMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(RunHardwareBenchmark_FunctionAddress, "CPUMultiplier");
		RunHardwareBenchmark_CPUMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(RunHardwareBenchmark_FunctionAddress, "CPUMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RunHardwareBenchmark_GPUMultiplier_PropertyAddress, RunHardwareBenchmark_FunctionAddress, "GPUMultiplier");
		RunHardwareBenchmark_GPUMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(RunHardwareBenchmark_FunctionAddress, "GPUMultiplier");
		RunHardwareBenchmark_GPUMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(RunHardwareBenchmark_FunctionAddress, "GPUMultiplier", Classes.FFloatProperty);
		RunHardwareBenchmark_IsValid = RunHardwareBenchmark_FunctionAddress != IntPtr.Zero && RunHardwareBenchmark_WorkScale_IsValid && RunHardwareBenchmark_CPUMultiplier_IsValid && RunHardwareBenchmark_GPUMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:RunHardwareBenchmark", RunHardwareBenchmark_IsValid);
		RevertVideoMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RevertVideoMode");
		RevertVideoMode_ParamsSize = NativeReflection.GetFunctionParamsSize(RevertVideoMode_FunctionAddress);
		RevertVideoMode_IsValid = RevertVideoMode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:RevertVideoMode", RevertVideoMode_IsValid);
		ResetToCurrentSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetToCurrentSettings");
		ResetToCurrentSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetToCurrentSettings_FunctionAddress);
		ResetToCurrentSettings_IsValid = ResetToCurrentSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ResetToCurrentSettings", ResetToCurrentSettings_IsValid);
		LoadSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadSettings");
		LoadSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadSettings_bForceReload_PropertyAddress, LoadSettings_FunctionAddress, "bForceReload");
		LoadSettings_bForceReload_Offset = NativeReflectionCached.GetPropertyOffset(LoadSettings_FunctionAddress, "bForceReload");
		LoadSettings_bForceReload_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadSettings_FunctionAddress, "bForceReload", Classes.FBoolProperty);
		LoadSettings_IsValid = LoadSettings_FunctionAddress != IntPtr.Zero && LoadSettings_bForceReload_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:LoadSettings", LoadSettings_IsValid);
		IsVSyncEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsVSyncEnabled");
		IsVSyncEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVSyncEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVSyncEnabled_ReturnValue_PropertyAddress, IsVSyncEnabled_FunctionAddress, "ReturnValue");
		IsVSyncEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVSyncEnabled_FunctionAddress, "ReturnValue");
		IsVSyncEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVSyncEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVSyncEnabled_IsValid = IsVSyncEnabled_FunctionAddress != IntPtr.Zero && IsVSyncEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsVSyncEnabled", IsVSyncEnabled_IsValid);
		IsVSyncDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsVSyncDirty");
		IsVSyncDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVSyncDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVSyncDirty_ReturnValue_PropertyAddress, IsVSyncDirty_FunctionAddress, "ReturnValue");
		IsVSyncDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVSyncDirty_FunctionAddress, "ReturnValue");
		IsVSyncDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVSyncDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVSyncDirty_IsValid = IsVSyncDirty_FunctionAddress != IntPtr.Zero && IsVSyncDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsVSyncDirty", IsVSyncDirty_IsValid);
		IsScreenResolutionDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsScreenResolutionDirty");
		IsScreenResolutionDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsScreenResolutionDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsScreenResolutionDirty_ReturnValue_PropertyAddress, IsScreenResolutionDirty_FunctionAddress, "ReturnValue");
		IsScreenResolutionDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsScreenResolutionDirty_FunctionAddress, "ReturnValue");
		IsScreenResolutionDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsScreenResolutionDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsScreenResolutionDirty_IsValid = IsScreenResolutionDirty_FunctionAddress != IntPtr.Zero && IsScreenResolutionDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsScreenResolutionDirty", IsScreenResolutionDirty_IsValid);
		IsHDREnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsHDREnabled");
		IsHDREnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHDREnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHDREnabled_ReturnValue_PropertyAddress, IsHDREnabled_FunctionAddress, "ReturnValue");
		IsHDREnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHDREnabled_FunctionAddress, "ReturnValue");
		IsHDREnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHDREnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHDREnabled_IsValid = IsHDREnabled_FunctionAddress != IntPtr.Zero && IsHDREnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsHDREnabled", IsHDREnabled_IsValid);
		IsFullscreenModeDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsFullscreenModeDirty");
		IsFullscreenModeDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFullscreenModeDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFullscreenModeDirty_ReturnValue_PropertyAddress, IsFullscreenModeDirty_FunctionAddress, "ReturnValue");
		IsFullscreenModeDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFullscreenModeDirty_FunctionAddress, "ReturnValue");
		IsFullscreenModeDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFullscreenModeDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsFullscreenModeDirty_IsValid = IsFullscreenModeDirty_FunctionAddress != IntPtr.Zero && IsFullscreenModeDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsFullscreenModeDirty", IsFullscreenModeDirty_IsValid);
		IsDynamicResolutionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDynamicResolutionEnabled");
		IsDynamicResolutionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDynamicResolutionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDynamicResolutionEnabled_ReturnValue_PropertyAddress, IsDynamicResolutionEnabled_FunctionAddress, "ReturnValue");
		IsDynamicResolutionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDynamicResolutionEnabled_FunctionAddress, "ReturnValue");
		IsDynamicResolutionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDynamicResolutionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDynamicResolutionEnabled_IsValid = IsDynamicResolutionEnabled_FunctionAddress != IntPtr.Zero && IsDynamicResolutionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsDynamicResolutionEnabled", IsDynamicResolutionEnabled_IsValid);
		IsDynamicResolutionDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDynamicResolutionDirty");
		IsDynamicResolutionDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDynamicResolutionDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDynamicResolutionDirty_ReturnValue_PropertyAddress, IsDynamicResolutionDirty_FunctionAddress, "ReturnValue");
		IsDynamicResolutionDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDynamicResolutionDirty_FunctionAddress, "ReturnValue");
		IsDynamicResolutionDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDynamicResolutionDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDynamicResolutionDirty_IsValid = IsDynamicResolutionDirty_FunctionAddress != IntPtr.Zero && IsDynamicResolutionDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsDynamicResolutionDirty", IsDynamicResolutionDirty_IsValid);
		IsDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDirty");
		IsDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDirty_ReturnValue_PropertyAddress, IsDirty_FunctionAddress, "ReturnValue");
		IsDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDirty_FunctionAddress, "ReturnValue");
		IsDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDirty_IsValid = IsDirty_FunctionAddress != IntPtr.Zero && IsDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:IsDirty", IsDirty_IsValid);
		GetVisualEffectQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVisualEffectQuality");
		GetVisualEffectQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVisualEffectQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVisualEffectQuality_ReturnValue_PropertyAddress, GetVisualEffectQuality_FunctionAddress, "ReturnValue");
		GetVisualEffectQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisualEffectQuality_FunctionAddress, "ReturnValue");
		GetVisualEffectQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisualEffectQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVisualEffectQuality_IsValid = GetVisualEffectQuality_FunctionAddress != IntPtr.Zero && GetVisualEffectQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetVisualEffectQuality", GetVisualEffectQuality_IsValid);
		GetViewDistanceQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewDistanceQuality");
		GetViewDistanceQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewDistanceQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewDistanceQuality_ReturnValue_PropertyAddress, GetViewDistanceQuality_FunctionAddress, "ReturnValue");
		GetViewDistanceQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewDistanceQuality_FunctionAddress, "ReturnValue");
		GetViewDistanceQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewDistanceQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetViewDistanceQuality_IsValid = GetViewDistanceQuality_FunctionAddress != IntPtr.Zero && GetViewDistanceQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetViewDistanceQuality", GetViewDistanceQuality_IsValid);
		GetTextureQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTextureQuality");
		GetTextureQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureQuality_ReturnValue_PropertyAddress, GetTextureQuality_FunctionAddress, "ReturnValue");
		GetTextureQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureQuality_FunctionAddress, "ReturnValue");
		GetTextureQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextureQuality_IsValid = GetTextureQuality_FunctionAddress != IntPtr.Zero && GetTextureQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetTextureQuality", GetTextureQuality_IsValid);
		GetSyncInterval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSyncInterval");
		GetSyncInterval_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSyncInterval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSyncInterval_ReturnValue_PropertyAddress, GetSyncInterval_FunctionAddress, "ReturnValue");
		GetSyncInterval_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSyncInterval_FunctionAddress, "ReturnValue");
		GetSyncInterval_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSyncInterval_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSyncInterval_IsValid = GetSyncInterval_FunctionAddress != IntPtr.Zero && GetSyncInterval_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetSyncInterval", GetSyncInterval_IsValid);
		GetShadowQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShadowQuality");
		GetShadowQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShadowQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShadowQuality_ReturnValue_PropertyAddress, GetShadowQuality_FunctionAddress, "ReturnValue");
		GetShadowQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShadowQuality_FunctionAddress, "ReturnValue");
		GetShadowQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShadowQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShadowQuality_IsValid = GetShadowQuality_FunctionAddress != IntPtr.Zero && GetShadowQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetShadowQuality", GetShadowQuality_IsValid);
		GetShadingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShadingQuality");
		GetShadingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShadingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShadingQuality_ReturnValue_PropertyAddress, GetShadingQuality_FunctionAddress, "ReturnValue");
		GetShadingQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShadingQuality_FunctionAddress, "ReturnValue");
		GetShadingQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShadingQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShadingQuality_IsValid = GetShadingQuality_FunctionAddress != IntPtr.Zero && GetShadingQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetShadingQuality", GetShadingQuality_IsValid);
		GetScreenResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScreenResolution");
		GetScreenResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScreenResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScreenResolution_ReturnValue_PropertyAddress, GetScreenResolution_FunctionAddress, "ReturnValue");
		GetScreenResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScreenResolution_FunctionAddress, "ReturnValue");
		GetScreenResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScreenResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScreenResolution_IsValid = GetScreenResolution_FunctionAddress != IntPtr.Zero && GetScreenResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetScreenResolution", GetScreenResolution_IsValid);
		GetResolutionScaleNormalized_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetResolutionScaleNormalized");
		GetResolutionScaleNormalized_ParamsSize = NativeReflection.GetFunctionParamsSize(GetResolutionScaleNormalized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleNormalized_ReturnValue_PropertyAddress, GetResolutionScaleNormalized_FunctionAddress, "ReturnValue");
		GetResolutionScaleNormalized_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleNormalized_FunctionAddress, "ReturnValue");
		GetResolutionScaleNormalized_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleNormalized_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetResolutionScaleNormalized_IsValid = GetResolutionScaleNormalized_FunctionAddress != IntPtr.Zero && GetResolutionScaleNormalized_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetResolutionScaleNormalized", GetResolutionScaleNormalized_IsValid);
		GetResolutionScaleInformationEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetResolutionScaleInformationEx");
		GetResolutionScaleInformationEx_ParamsSize = NativeReflection.GetFunctionParamsSize(GetResolutionScaleInformationEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleInformationEx_CurrentScaleNormalized_PropertyAddress, GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleNormalized");
		GetResolutionScaleInformationEx_CurrentScaleNormalized_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleNormalized");
		GetResolutionScaleInformationEx_CurrentScaleNormalized_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleNormalized", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleInformationEx_CurrentScaleValue_PropertyAddress, GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleValue");
		GetResolutionScaleInformationEx_CurrentScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleValue");
		GetResolutionScaleInformationEx_CurrentScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleInformationEx_FunctionAddress, "CurrentScaleValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleInformationEx_MinScaleValue_PropertyAddress, GetResolutionScaleInformationEx_FunctionAddress, "MinScaleValue");
		GetResolutionScaleInformationEx_MinScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleInformationEx_FunctionAddress, "MinScaleValue");
		GetResolutionScaleInformationEx_MinScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleInformationEx_FunctionAddress, "MinScaleValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleInformationEx_MaxScaleValue_PropertyAddress, GetResolutionScaleInformationEx_FunctionAddress, "MaxScaleValue");
		GetResolutionScaleInformationEx_MaxScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleInformationEx_FunctionAddress, "MaxScaleValue");
		GetResolutionScaleInformationEx_MaxScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleInformationEx_FunctionAddress, "MaxScaleValue", Classes.FFloatProperty);
		GetResolutionScaleInformationEx_IsValid = GetResolutionScaleInformationEx_FunctionAddress != IntPtr.Zero && GetResolutionScaleInformationEx_CurrentScaleNormalized_IsValid && GetResolutionScaleInformationEx_CurrentScaleValue_IsValid && GetResolutionScaleInformationEx_MinScaleValue_IsValid && GetResolutionScaleInformationEx_MaxScaleValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetResolutionScaleInformationEx", GetResolutionScaleInformationEx_IsValid);
		GetReflectionQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReflectionQuality");
		GetReflectionQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReflectionQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReflectionQuality_ReturnValue_PropertyAddress, GetReflectionQuality_FunctionAddress, "ReturnValue");
		GetReflectionQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReflectionQuality_FunctionAddress, "ReturnValue");
		GetReflectionQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReflectionQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetReflectionQuality_IsValid = GetReflectionQuality_FunctionAddress != IntPtr.Zero && GetReflectionQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetReflectionQuality", GetReflectionQuality_IsValid);
		GetRecommendedResolutionScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRecommendedResolutionScale");
		GetRecommendedResolutionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRecommendedResolutionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRecommendedResolutionScale_ReturnValue_PropertyAddress, GetRecommendedResolutionScale_FunctionAddress, "ReturnValue");
		GetRecommendedResolutionScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRecommendedResolutionScale_FunctionAddress, "ReturnValue");
		GetRecommendedResolutionScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRecommendedResolutionScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRecommendedResolutionScale_IsValid = GetRecommendedResolutionScale_FunctionAddress != IntPtr.Zero && GetRecommendedResolutionScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetRecommendedResolutionScale", GetRecommendedResolutionScale_IsValid);
		GetRayTracingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRayTracingQuality");
		GetRayTracingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRayTracingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRayTracingQuality_ReturnValue_PropertyAddress, GetRayTracingQuality_FunctionAddress, "ReturnValue");
		GetRayTracingQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRayTracingQuality_FunctionAddress, "ReturnValue");
		GetRayTracingQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRayTracingQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRayTracingQuality_IsValid = GetRayTracingQuality_FunctionAddress != IntPtr.Zero && GetRayTracingQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetRayTracingQuality", GetRayTracingQuality_IsValid);
		GetPreferredFullscreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreferredFullscreenMode");
		GetPreferredFullscreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreferredFullscreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreferredFullscreenMode_ReturnValue_PropertyAddress, GetPreferredFullscreenMode_FunctionAddress, "ReturnValue");
		GetPreferredFullscreenMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreferredFullscreenMode_FunctionAddress, "ReturnValue");
		GetPreferredFullscreenMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreferredFullscreenMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPreferredFullscreenMode_IsValid = GetPreferredFullscreenMode_FunctionAddress != IntPtr.Zero && GetPreferredFullscreenMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetPreferredFullscreenMode", GetPreferredFullscreenMode_IsValid);
		GetPostProcessingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPostProcessingQuality");
		GetPostProcessingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPostProcessingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPostProcessingQuality_ReturnValue_PropertyAddress, GetPostProcessingQuality_FunctionAddress, "ReturnValue");
		GetPostProcessingQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPostProcessingQuality_FunctionAddress, "ReturnValue");
		GetPostProcessingQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPostProcessingQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPostProcessingQuality_IsValid = GetPostProcessingQuality_FunctionAddress != IntPtr.Zero && GetPostProcessingQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetPostProcessingQuality", GetPostProcessingQuality_IsValid);
		GetOverallScalabilityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOverallScalabilityLevel");
		GetOverallScalabilityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOverallScalabilityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOverallScalabilityLevel_ReturnValue_PropertyAddress, GetOverallScalabilityLevel_FunctionAddress, "ReturnValue");
		GetOverallScalabilityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOverallScalabilityLevel_FunctionAddress, "ReturnValue");
		GetOverallScalabilityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOverallScalabilityLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetOverallScalabilityLevel_IsValid = GetOverallScalabilityLevel_FunctionAddress != IntPtr.Zero && GetOverallScalabilityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetOverallScalabilityLevel", GetOverallScalabilityLevel_IsValid);
		GetLastConfirmedScreenResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastConfirmedScreenResolution");
		GetLastConfirmedScreenResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastConfirmedScreenResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastConfirmedScreenResolution_ReturnValue_PropertyAddress, GetLastConfirmedScreenResolution_FunctionAddress, "ReturnValue");
		GetLastConfirmedScreenResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastConfirmedScreenResolution_FunctionAddress, "ReturnValue");
		GetLastConfirmedScreenResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastConfirmedScreenResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastConfirmedScreenResolution_IsValid = GetLastConfirmedScreenResolution_FunctionAddress != IntPtr.Zero && GetLastConfirmedScreenResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetLastConfirmedScreenResolution", GetLastConfirmedScreenResolution_IsValid);
		GetLastConfirmedFullscreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastConfirmedFullscreenMode");
		GetLastConfirmedFullscreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastConfirmedFullscreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastConfirmedFullscreenMode_ReturnValue_PropertyAddress, GetLastConfirmedFullscreenMode_FunctionAddress, "ReturnValue");
		GetLastConfirmedFullscreenMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastConfirmedFullscreenMode_FunctionAddress, "ReturnValue");
		GetLastConfirmedFullscreenMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastConfirmedFullscreenMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetLastConfirmedFullscreenMode_IsValid = GetLastConfirmedFullscreenMode_FunctionAddress != IntPtr.Zero && GetLastConfirmedFullscreenMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetLastConfirmedFullscreenMode", GetLastConfirmedFullscreenMode_IsValid);
		GetGlobalIlluminationQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalIlluminationQuality");
		GetGlobalIlluminationQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalIlluminationQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalIlluminationQuality_ReturnValue_PropertyAddress, GetGlobalIlluminationQuality_FunctionAddress, "ReturnValue");
		GetGlobalIlluminationQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalIlluminationQuality_FunctionAddress, "ReturnValue");
		GetGlobalIlluminationQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalIlluminationQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetGlobalIlluminationQuality_IsValid = GetGlobalIlluminationQuality_FunctionAddress != IntPtr.Zero && GetGlobalIlluminationQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetGlobalIlluminationQuality", GetGlobalIlluminationQuality_IsValid);
		GetGameUserSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameUserSettings");
		GetGameUserSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameUserSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameUserSettings_ReturnValue_PropertyAddress, GetGameUserSettings_FunctionAddress, "ReturnValue");
		GetGameUserSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameUserSettings_FunctionAddress, "ReturnValue");
		GetGameUserSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameUserSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGameUserSettings_IsValid = GetGameUserSettings_FunctionAddress != IntPtr.Zero && GetGameUserSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetGameUserSettings", GetGameUserSettings_IsValid);
		GetFullscreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFullscreenMode");
		GetFullscreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFullscreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFullscreenMode_ReturnValue_PropertyAddress, GetFullscreenMode_FunctionAddress, "ReturnValue");
		GetFullscreenMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFullscreenMode_FunctionAddress, "ReturnValue");
		GetFullscreenMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFullscreenMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetFullscreenMode_IsValid = GetFullscreenMode_FunctionAddress != IntPtr.Zero && GetFullscreenMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetFullscreenMode", GetFullscreenMode_IsValid);
		GetFrameRateLimit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFrameRateLimit");
		GetFrameRateLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameRateLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameRateLimit_ReturnValue_PropertyAddress, GetFrameRateLimit_FunctionAddress, "ReturnValue");
		GetFrameRateLimit_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameRateLimit_FunctionAddress, "ReturnValue");
		GetFrameRateLimit_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameRateLimit_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFrameRateLimit_IsValid = GetFrameRateLimit_FunctionAddress != IntPtr.Zero && GetFrameRateLimit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetFrameRateLimit", GetFrameRateLimit_IsValid);
		GetFramePace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFramePace");
		GetFramePace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFramePace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFramePace_ReturnValue_PropertyAddress, GetFramePace_FunctionAddress, "ReturnValue");
		GetFramePace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFramePace_FunctionAddress, "ReturnValue");
		GetFramePace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFramePace_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFramePace_IsValid = GetFramePace_FunctionAddress != IntPtr.Zero && GetFramePace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetFramePace", GetFramePace_IsValid);
		GetFoliageQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFoliageQuality");
		GetFoliageQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFoliageQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageQuality_ReturnValue_PropertyAddress, GetFoliageQuality_FunctionAddress, "ReturnValue");
		GetFoliageQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageQuality_FunctionAddress, "ReturnValue");
		GetFoliageQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFoliageQuality_IsValid = GetFoliageQuality_FunctionAddress != IntPtr.Zero && GetFoliageQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetFoliageQuality", GetFoliageQuality_IsValid);
		GetDesktopResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDesktopResolution");
		GetDesktopResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesktopResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesktopResolution_ReturnValue_PropertyAddress, GetDesktopResolution_FunctionAddress, "ReturnValue");
		GetDesktopResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesktopResolution_FunctionAddress, "ReturnValue");
		GetDesktopResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesktopResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDesktopResolution_IsValid = GetDesktopResolution_FunctionAddress != IntPtr.Zero && GetDesktopResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetDesktopResolution", GetDesktopResolution_IsValid);
		GetDefaultWindowPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultWindowPosition");
		GetDefaultWindowPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultWindowPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultWindowPosition_ReturnValue_PropertyAddress, GetDefaultWindowPosition_FunctionAddress, "ReturnValue");
		GetDefaultWindowPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultWindowPosition_FunctionAddress, "ReturnValue");
		GetDefaultWindowPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultWindowPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultWindowPosition_IsValid = GetDefaultWindowPosition_FunctionAddress != IntPtr.Zero && GetDefaultWindowPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetDefaultWindowPosition", GetDefaultWindowPosition_IsValid);
		GetDefaultWindowMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultWindowMode");
		GetDefaultWindowMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultWindowMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultWindowMode_ReturnValue_PropertyAddress, GetDefaultWindowMode_FunctionAddress, "ReturnValue");
		GetDefaultWindowMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultWindowMode_FunctionAddress, "ReturnValue");
		GetDefaultWindowMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultWindowMode_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetDefaultWindowMode_IsValid = GetDefaultWindowMode_FunctionAddress != IntPtr.Zero && GetDefaultWindowMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetDefaultWindowMode", GetDefaultWindowMode_IsValid);
		GetDefaultResolutionScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultResolutionScale");
		GetDefaultResolutionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultResolutionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultResolutionScale_ReturnValue_PropertyAddress, GetDefaultResolutionScale_FunctionAddress, "ReturnValue");
		GetDefaultResolutionScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultResolutionScale_FunctionAddress, "ReturnValue");
		GetDefaultResolutionScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultResolutionScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultResolutionScale_IsValid = GetDefaultResolutionScale_FunctionAddress != IntPtr.Zero && GetDefaultResolutionScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetDefaultResolutionScale", GetDefaultResolutionScale_IsValid);
		GetDefaultResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultResolution");
		GetDefaultResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultResolution_ReturnValue_PropertyAddress, GetDefaultResolution_FunctionAddress, "ReturnValue");
		GetDefaultResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultResolution_FunctionAddress, "ReturnValue");
		GetDefaultResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultResolution_IsValid = GetDefaultResolution_FunctionAddress != IntPtr.Zero && GetDefaultResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetDefaultResolution", GetDefaultResolution_IsValid);
		GetCurrentHDRDisplayNits_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentHDRDisplayNits");
		GetCurrentHDRDisplayNits_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentHDRDisplayNits_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentHDRDisplayNits_ReturnValue_PropertyAddress, GetCurrentHDRDisplayNits_FunctionAddress, "ReturnValue");
		GetCurrentHDRDisplayNits_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentHDRDisplayNits_FunctionAddress, "ReturnValue");
		GetCurrentHDRDisplayNits_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentHDRDisplayNits_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentHDRDisplayNits_IsValid = GetCurrentHDRDisplayNits_FunctionAddress != IntPtr.Zero && GetCurrentHDRDisplayNits_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetCurrentHDRDisplayNits", GetCurrentHDRDisplayNits_IsValid);
		GetAudioQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAudioQualityLevel");
		GetAudioQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioQualityLevel_ReturnValue_PropertyAddress, GetAudioQualityLevel_FunctionAddress, "ReturnValue");
		GetAudioQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioQualityLevel_FunctionAddress, "ReturnValue");
		GetAudioQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioQualityLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAudioQualityLevel_IsValid = GetAudioQualityLevel_FunctionAddress != IntPtr.Zero && GetAudioQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetAudioQualityLevel", GetAudioQualityLevel_IsValid);
		GetAntiAliasingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAntiAliasingQuality");
		GetAntiAliasingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAntiAliasingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAntiAliasingQuality_ReturnValue_PropertyAddress, GetAntiAliasingQuality_FunctionAddress, "ReturnValue");
		GetAntiAliasingQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAntiAliasingQuality_FunctionAddress, "ReturnValue");
		GetAntiAliasingQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAntiAliasingQuality_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAntiAliasingQuality_IsValid = GetAntiAliasingQuality_FunctionAddress != IntPtr.Zero && GetAntiAliasingQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:GetAntiAliasingQuality", GetAntiAliasingQuality_IsValid);
		EnableHDRDisplayOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableHDRDisplayOutput");
		EnableHDRDisplayOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableHDRDisplayOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableHDRDisplayOutput_bEnable_PropertyAddress, EnableHDRDisplayOutput_FunctionAddress, "bEnable");
		EnableHDRDisplayOutput_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(EnableHDRDisplayOutput_FunctionAddress, "bEnable");
		EnableHDRDisplayOutput_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableHDRDisplayOutput_FunctionAddress, "bEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableHDRDisplayOutput_DisplayNits_PropertyAddress, EnableHDRDisplayOutput_FunctionAddress, "DisplayNits");
		EnableHDRDisplayOutput_DisplayNits_Offset = NativeReflectionCached.GetPropertyOffset(EnableHDRDisplayOutput_FunctionAddress, "DisplayNits");
		EnableHDRDisplayOutput_DisplayNits_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableHDRDisplayOutput_FunctionAddress, "DisplayNits", Classes.FIntProperty);
		EnableHDRDisplayOutput_IsValid = EnableHDRDisplayOutput_FunctionAddress != IntPtr.Zero && EnableHDRDisplayOutput_bEnable_IsValid && EnableHDRDisplayOutput_DisplayNits_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:EnableHDRDisplayOutput", EnableHDRDisplayOutput_IsValid);
		ConfirmVideoMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConfirmVideoMode");
		ConfirmVideoMode_ParamsSize = NativeReflection.GetFunctionParamsSize(ConfirmVideoMode_FunctionAddress);
		ConfirmVideoMode_IsValid = ConfirmVideoMode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ConfirmVideoMode", ConfirmVideoMode_IsValid);
		ApplySettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySettings");
		ApplySettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySettings_bCheckForCommandLineOverrides_PropertyAddress, ApplySettings_FunctionAddress, "bCheckForCommandLineOverrides");
		ApplySettings_bCheckForCommandLineOverrides_Offset = NativeReflectionCached.GetPropertyOffset(ApplySettings_FunctionAddress, "bCheckForCommandLineOverrides");
		ApplySettings_bCheckForCommandLineOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySettings_FunctionAddress, "bCheckForCommandLineOverrides", Classes.FBoolProperty);
		ApplySettings_IsValid = ApplySettings_FunctionAddress != IntPtr.Zero && ApplySettings_bCheckForCommandLineOverrides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ApplySettings", ApplySettings_IsValid);
		ApplyResolutionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyResolutionSettings");
		ApplyResolutionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyResolutionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyResolutionSettings_bCheckForCommandLineOverrides_PropertyAddress, ApplyResolutionSettings_FunctionAddress, "bCheckForCommandLineOverrides");
		ApplyResolutionSettings_bCheckForCommandLineOverrides_Offset = NativeReflectionCached.GetPropertyOffset(ApplyResolutionSettings_FunctionAddress, "bCheckForCommandLineOverrides");
		ApplyResolutionSettings_bCheckForCommandLineOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyResolutionSettings_FunctionAddress, "bCheckForCommandLineOverrides", Classes.FBoolProperty);
		ApplyResolutionSettings_IsValid = ApplyResolutionSettings_FunctionAddress != IntPtr.Zero && ApplyResolutionSettings_bCheckForCommandLineOverrides_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ApplyResolutionSettings", ApplyResolutionSettings_IsValid);
		ApplyNonResolutionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyNonResolutionSettings");
		ApplyNonResolutionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyNonResolutionSettings_FunctionAddress);
		ApplyNonResolutionSettings_IsValid = ApplyNonResolutionSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ApplyNonResolutionSettings", ApplyNonResolutionSettings_IsValid);
		ApplyHardwareBenchmarkResults_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyHardwareBenchmarkResults");
		ApplyHardwareBenchmarkResults_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyHardwareBenchmarkResults_FunctionAddress);
		ApplyHardwareBenchmarkResults_IsValid = ApplyHardwareBenchmarkResults_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameUserSettings:ApplyHardwareBenchmarkResults", ApplyHardwareBenchmarkResults_IsValid);
	}
}
