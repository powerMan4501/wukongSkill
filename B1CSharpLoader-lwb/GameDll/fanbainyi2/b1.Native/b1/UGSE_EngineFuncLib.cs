using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.MediaAssets;
using UnrealEngine.Plugins.BinkMediaPlayer;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_EngineFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WasActorRecentlyRendered_IsValid;

	private static IntPtr WasActorRecentlyRendered_FunctionAddress;

	private static int WasActorRecentlyRendered_ParamsSize;

	private static bool WasActorRecentlyRendered_InActor_IsValid;

	private static FFieldAddress WasActorRecentlyRendered_InActor_PropertyAddress;

	private static int WasActorRecentlyRendered_InActor_Offset;

	private static bool WasActorRecentlyRendered_InTolerence_IsValid;

	private static FFieldAddress WasActorRecentlyRendered_InTolerence_PropertyAddress;

	private static int WasActorRecentlyRendered_InTolerence_Offset;

	private static bool WasActorRecentlyRendered_ReturnValue_IsValid;

	private static FFieldAddress WasActorRecentlyRendered_ReturnValue_PropertyAddress;

	private static int WasActorRecentlyRendered_ReturnValue_Offset;

	private static bool VLogWLevel_IsValid;

	private static IntPtr VLogWLevel_FunctionAddress;

	private static int VLogWLevel_ParamsSize;

	private static bool VLogWLevel_WorldContext_IsValid;

	private static FFieldAddress VLogWLevel_WorldContext_PropertyAddress;

	private static int VLogWLevel_WorldContext_Offset;

	private static bool VLogWLevel_InLogLevel_IsValid;

	private static FFieldAddress VLogWLevel_InLogLevel_PropertyAddress;

	private static int VLogWLevel_InLogLevel_Offset;

	private static bool VLogWLevel_Catogary_IsValid;

	private static FFieldAddress VLogWLevel_Catogary_PropertyAddress;

	private static int VLogWLevel_Catogary_Offset;

	private static bool VLogWLevel_Text_IsValid;

	private static FFieldAddress VLogWLevel_Text_PropertyAddress;

	private static int VLogWLevel_Text_Offset;

	private static bool VLogWarning_IsValid;

	private static IntPtr VLogWarning_FunctionAddress;

	private static int VLogWarning_ParamsSize;

	private static bool VLogWarning_WorldContext_IsValid;

	private static FFieldAddress VLogWarning_WorldContext_PropertyAddress;

	private static int VLogWarning_WorldContext_Offset;

	private static bool VLogWarning_Catogary_IsValid;

	private static FFieldAddress VLogWarning_Catogary_PropertyAddress;

	private static int VLogWarning_Catogary_Offset;

	private static bool VLogWarning_Text_IsValid;

	private static FFieldAddress VLogWarning_Text_PropertyAddress;

	private static int VLogWarning_Text_Offset;

	private static bool VLogSegmentWarning_IsValid;

	private static IntPtr VLogSegmentWarning_FunctionAddress;

	private static int VLogSegmentWarning_ParamsSize;

	private static bool VLogSegmentWarning_WorldContext_IsValid;

	private static FFieldAddress VLogSegmentWarning_WorldContext_PropertyAddress;

	private static int VLogSegmentWarning_WorldContext_Offset;

	private static bool VLogSegmentWarning_Catogary_IsValid;

	private static FFieldAddress VLogSegmentWarning_Catogary_PropertyAddress;

	private static int VLogSegmentWarning_Catogary_Offset;

	private static bool VLogSegmentWarning_SegmentStart_IsValid;

	private static FFieldAddress VLogSegmentWarning_SegmentStart_PropertyAddress;

	private static int VLogSegmentWarning_SegmentStart_Offset;

	private static bool VLogSegmentWarning_SegmentEnd_IsValid;

	private static FFieldAddress VLogSegmentWarning_SegmentEnd_PropertyAddress;

	private static int VLogSegmentWarning_SegmentEnd_Offset;

	private static bool VLogSegmentWarning_Color_IsValid;

	private static FFieldAddress VLogSegmentWarning_Color_PropertyAddress;

	private static int VLogSegmentWarning_Color_Offset;

	private static bool VLogSegmentWarning_Thickness_IsValid;

	private static FFieldAddress VLogSegmentWarning_Thickness_PropertyAddress;

	private static int VLogSegmentWarning_Thickness_Offset;

	private static bool VLogSegmentWarning_Text_IsValid;

	private static FFieldAddress VLogSegmentWarning_Text_PropertyAddress;

	private static int VLogSegmentWarning_Text_Offset;

	private static bool VLogSegmentInfo_IsValid;

	private static IntPtr VLogSegmentInfo_FunctionAddress;

	private static int VLogSegmentInfo_ParamsSize;

	private static bool VLogSegmentInfo_WorldContext_IsValid;

	private static FFieldAddress VLogSegmentInfo_WorldContext_PropertyAddress;

	private static int VLogSegmentInfo_WorldContext_Offset;

	private static bool VLogSegmentInfo_Catogary_IsValid;

	private static FFieldAddress VLogSegmentInfo_Catogary_PropertyAddress;

	private static int VLogSegmentInfo_Catogary_Offset;

	private static bool VLogSegmentInfo_SegmentStart_IsValid;

	private static FFieldAddress VLogSegmentInfo_SegmentStart_PropertyAddress;

	private static int VLogSegmentInfo_SegmentStart_Offset;

	private static bool VLogSegmentInfo_SegmentEnd_IsValid;

	private static FFieldAddress VLogSegmentInfo_SegmentEnd_PropertyAddress;

	private static int VLogSegmentInfo_SegmentEnd_Offset;

	private static bool VLogSegmentInfo_Color_IsValid;

	private static FFieldAddress VLogSegmentInfo_Color_PropertyAddress;

	private static int VLogSegmentInfo_Color_Offset;

	private static bool VLogSegmentInfo_Thickness_IsValid;

	private static FFieldAddress VLogSegmentInfo_Thickness_PropertyAddress;

	private static int VLogSegmentInfo_Thickness_Offset;

	private static bool VLogSegmentInfo_Text_IsValid;

	private static FFieldAddress VLogSegmentInfo_Text_PropertyAddress;

	private static int VLogSegmentInfo_Text_Offset;

	private static bool VLogSegmentError_IsValid;

	private static IntPtr VLogSegmentError_FunctionAddress;

	private static int VLogSegmentError_ParamsSize;

	private static bool VLogSegmentError_WorldContext_IsValid;

	private static FFieldAddress VLogSegmentError_WorldContext_PropertyAddress;

	private static int VLogSegmentError_WorldContext_Offset;

	private static bool VLogSegmentError_Catogary_IsValid;

	private static FFieldAddress VLogSegmentError_Catogary_PropertyAddress;

	private static int VLogSegmentError_Catogary_Offset;

	private static bool VLogSegmentError_SegmentStart_IsValid;

	private static FFieldAddress VLogSegmentError_SegmentStart_PropertyAddress;

	private static int VLogSegmentError_SegmentStart_Offset;

	private static bool VLogSegmentError_SegmentEnd_IsValid;

	private static FFieldAddress VLogSegmentError_SegmentEnd_PropertyAddress;

	private static int VLogSegmentError_SegmentEnd_Offset;

	private static bool VLogSegmentError_Color_IsValid;

	private static FFieldAddress VLogSegmentError_Color_PropertyAddress;

	private static int VLogSegmentError_Color_Offset;

	private static bool VLogSegmentError_Thickness_IsValid;

	private static FFieldAddress VLogSegmentError_Thickness_PropertyAddress;

	private static int VLogSegmentError_Thickness_Offset;

	private static bool VLogSegmentError_Text_IsValid;

	private static FFieldAddress VLogSegmentError_Text_PropertyAddress;

	private static int VLogSegmentError_Text_Offset;

	private static bool VLogLocationWarning_IsValid;

	private static IntPtr VLogLocationWarning_FunctionAddress;

	private static int VLogLocationWarning_ParamsSize;

	private static bool VLogLocationWarning_WorldContext_IsValid;

	private static FFieldAddress VLogLocationWarning_WorldContext_PropertyAddress;

	private static int VLogLocationWarning_WorldContext_Offset;

	private static bool VLogLocationWarning_Catogary_IsValid;

	private static FFieldAddress VLogLocationWarning_Catogary_PropertyAddress;

	private static int VLogLocationWarning_Catogary_Offset;

	private static bool VLogLocationWarning_Location_IsValid;

	private static FFieldAddress VLogLocationWarning_Location_PropertyAddress;

	private static int VLogLocationWarning_Location_Offset;

	private static bool VLogLocationWarning_Radius_IsValid;

	private static FFieldAddress VLogLocationWarning_Radius_PropertyAddress;

	private static int VLogLocationWarning_Radius_Offset;

	private static bool VLogLocationWarning_Color_IsValid;

	private static FFieldAddress VLogLocationWarning_Color_PropertyAddress;

	private static int VLogLocationWarning_Color_Offset;

	private static bool VLogLocationWarning_Text_IsValid;

	private static FFieldAddress VLogLocationWarning_Text_PropertyAddress;

	private static int VLogLocationWarning_Text_Offset;

	private static bool VLogLocationInfo_IsValid;

	private static IntPtr VLogLocationInfo_FunctionAddress;

	private static int VLogLocationInfo_ParamsSize;

	private static bool VLogLocationInfo_WorldContext_IsValid;

	private static FFieldAddress VLogLocationInfo_WorldContext_PropertyAddress;

	private static int VLogLocationInfo_WorldContext_Offset;

	private static bool VLogLocationInfo_Catogary_IsValid;

	private static FFieldAddress VLogLocationInfo_Catogary_PropertyAddress;

	private static int VLogLocationInfo_Catogary_Offset;

	private static bool VLogLocationInfo_Location_IsValid;

	private static FFieldAddress VLogLocationInfo_Location_PropertyAddress;

	private static int VLogLocationInfo_Location_Offset;

	private static bool VLogLocationInfo_Radius_IsValid;

	private static FFieldAddress VLogLocationInfo_Radius_PropertyAddress;

	private static int VLogLocationInfo_Radius_Offset;

	private static bool VLogLocationInfo_Color_IsValid;

	private static FFieldAddress VLogLocationInfo_Color_PropertyAddress;

	private static int VLogLocationInfo_Color_Offset;

	private static bool VLogLocationInfo_Text_IsValid;

	private static FFieldAddress VLogLocationInfo_Text_PropertyAddress;

	private static int VLogLocationInfo_Text_Offset;

	private static bool VLogLocationError_IsValid;

	private static IntPtr VLogLocationError_FunctionAddress;

	private static int VLogLocationError_ParamsSize;

	private static bool VLogLocationError_WorldContext_IsValid;

	private static FFieldAddress VLogLocationError_WorldContext_PropertyAddress;

	private static int VLogLocationError_WorldContext_Offset;

	private static bool VLogLocationError_Catogary_IsValid;

	private static FFieldAddress VLogLocationError_Catogary_PropertyAddress;

	private static int VLogLocationError_Catogary_Offset;

	private static bool VLogLocationError_Location_IsValid;

	private static FFieldAddress VLogLocationError_Location_PropertyAddress;

	private static int VLogLocationError_Location_Offset;

	private static bool VLogLocationError_Radius_IsValid;

	private static FFieldAddress VLogLocationError_Radius_PropertyAddress;

	private static int VLogLocationError_Radius_Offset;

	private static bool VLogLocationError_Color_IsValid;

	private static FFieldAddress VLogLocationError_Color_PropertyAddress;

	private static int VLogLocationError_Color_Offset;

	private static bool VLogLocationError_Text_IsValid;

	private static FFieldAddress VLogLocationError_Text_PropertyAddress;

	private static int VLogLocationError_Text_Offset;

	private static bool VLogInfo_IsValid;

	private static IntPtr VLogInfo_FunctionAddress;

	private static int VLogInfo_ParamsSize;

	private static bool VLogInfo_WorldContext_IsValid;

	private static FFieldAddress VLogInfo_WorldContext_PropertyAddress;

	private static int VLogInfo_WorldContext_Offset;

	private static bool VLogInfo_Catogary_IsValid;

	private static FFieldAddress VLogInfo_Catogary_PropertyAddress;

	private static int VLogInfo_Catogary_Offset;

	private static bool VLogInfo_Text_IsValid;

	private static FFieldAddress VLogInfo_Text_PropertyAddress;

	private static int VLogInfo_Text_Offset;

	private static bool VLogError_IsValid;

	private static IntPtr VLogError_FunctionAddress;

	private static int VLogError_ParamsSize;

	private static bool VLogError_WorldContext_IsValid;

	private static FFieldAddress VLogError_WorldContext_PropertyAddress;

	private static int VLogError_WorldContext_Offset;

	private static bool VLogError_Catogary_IsValid;

	private static FFieldAddress VLogError_Catogary_PropertyAddress;

	private static int VLogError_Catogary_Offset;

	private static bool VLogError_Text_IsValid;

	private static FFieldAddress VLogError_Text_PropertyAddress;

	private static int VLogError_Text_Offset;

	private static bool VLogBoxWarning_IsValid;

	private static IntPtr VLogBoxWarning_FunctionAddress;

	private static int VLogBoxWarning_ParamsSize;

	private static bool VLogBoxWarning_WorldContext_IsValid;

	private static FFieldAddress VLogBoxWarning_WorldContext_PropertyAddress;

	private static int VLogBoxWarning_WorldContext_Offset;

	private static bool VLogBoxWarning_Catogary_IsValid;

	private static FFieldAddress VLogBoxWarning_Catogary_PropertyAddress;

	private static int VLogBoxWarning_Catogary_Offset;

	private static bool VLogBoxWarning_Box_IsValid;

	private static FFieldAddress VLogBoxWarning_Box_PropertyAddress;

	private static int VLogBoxWarning_Box_Offset;

	private static bool VLogBoxWarning_Color_IsValid;

	private static FFieldAddress VLogBoxWarning_Color_PropertyAddress;

	private static int VLogBoxWarning_Color_Offset;

	private static bool VLogBoxWarning_Text_IsValid;

	private static FFieldAddress VLogBoxWarning_Text_PropertyAddress;

	private static int VLogBoxWarning_Text_Offset;

	private static bool VLogBoxInfo_IsValid;

	private static IntPtr VLogBoxInfo_FunctionAddress;

	private static int VLogBoxInfo_ParamsSize;

	private static bool VLogBoxInfo_WorldContext_IsValid;

	private static FFieldAddress VLogBoxInfo_WorldContext_PropertyAddress;

	private static int VLogBoxInfo_WorldContext_Offset;

	private static bool VLogBoxInfo_Catogary_IsValid;

	private static FFieldAddress VLogBoxInfo_Catogary_PropertyAddress;

	private static int VLogBoxInfo_Catogary_Offset;

	private static bool VLogBoxInfo_Box_IsValid;

	private static FFieldAddress VLogBoxInfo_Box_PropertyAddress;

	private static int VLogBoxInfo_Box_Offset;

	private static bool VLogBoxInfo_Color_IsValid;

	private static FFieldAddress VLogBoxInfo_Color_PropertyAddress;

	private static int VLogBoxInfo_Color_Offset;

	private static bool VLogBoxInfo_Text_IsValid;

	private static FFieldAddress VLogBoxInfo_Text_PropertyAddress;

	private static int VLogBoxInfo_Text_Offset;

	private static bool VLogBoxError_IsValid;

	private static IntPtr VLogBoxError_FunctionAddress;

	private static int VLogBoxError_ParamsSize;

	private static bool VLogBoxError_WorldContext_IsValid;

	private static FFieldAddress VLogBoxError_WorldContext_PropertyAddress;

	private static int VLogBoxError_WorldContext_Offset;

	private static bool VLogBoxError_Catogary_IsValid;

	private static FFieldAddress VLogBoxError_Catogary_PropertyAddress;

	private static int VLogBoxError_Catogary_Offset;

	private static bool VLogBoxError_Box_IsValid;

	private static FFieldAddress VLogBoxError_Box_PropertyAddress;

	private static int VLogBoxError_Box_Offset;

	private static bool VLogBoxError_Color_IsValid;

	private static FFieldAddress VLogBoxError_Color_PropertyAddress;

	private static int VLogBoxError_Color_Offset;

	private static bool VLogBoxError_Text_IsValid;

	private static FFieldAddress VLogBoxError_Text_PropertyAddress;

	private static int VLogBoxError_Text_Offset;

	private static bool UseStatsMacro_IsValid;

	private static IntPtr UseStatsMacro_FunctionAddress;

	private static int UseStatsMacro_ParamsSize;

	private static bool UseStatsMacro_ReturnValue_IsValid;

	private static FFieldAddress UseStatsMacro_ReturnValue_PropertyAddress;

	private static int UseStatsMacro_ReturnValue_Offset;

	private static bool UploadPSOHttpRequest_IsValid;

	private static IntPtr UploadPSOHttpRequest_FunctionAddress;

	private static int UploadPSOHttpRequest_ParamsSize;

	private static bool UploadPSOHttpRequest_Num_IsValid;

	private static FFieldAddress UploadPSOHttpRequest_Num_PropertyAddress;

	private static int UploadPSOHttpRequest_Num_Offset;

	private static bool UpdateAudioUtilAnalyzer_IsValid;

	private static IntPtr UpdateAudioUtilAnalyzer_FunctionAddress;

	private static int UpdateAudioUtilAnalyzer_ParamsSize;

	private static bool UpdateAudioUtilAnalyzer_AudioUtilActor_IsValid;

	private static FFieldAddress UpdateAudioUtilAnalyzer_AudioUtilActor_PropertyAddress;

	private static int UpdateAudioUtilAnalyzer_AudioUtilActor_Offset;

	private static bool UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_IsValid;

	private static FFieldAddress UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_PropertyAddress;

	private static int UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_Offset;

	private static bool UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_IsValid;

	private static FFieldAddress UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_PropertyAddress;

	private static int UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_Offset;

	private static bool ToMilliseconds_IsValid;

	private static IntPtr ToMilliseconds_FunctionAddress;

	private static int ToMilliseconds_ParamsSize;

	private static bool ToMilliseconds_Cycles_IsValid;

	private static FFieldAddress ToMilliseconds_Cycles_PropertyAddress;

	private static int ToMilliseconds_Cycles_Offset;

	private static bool ToMilliseconds_ReturnValue_IsValid;

	private static FFieldAddress ToMilliseconds_ReturnValue_PropertyAddress;

	private static int ToMilliseconds_ReturnValue_Offset;

	private static bool TestPathSync_IsValid;

	private static IntPtr TestPathSync_FunctionAddress;

	private static int TestPathSync_ParamsSize;

	private static bool TestPathSync_Controller_IsValid;

	private static FFieldAddress TestPathSync_Controller_PropertyAddress;

	private static int TestPathSync_Controller_Offset;

	private static bool TestPathSync_TargetLocation_IsValid;

	private static FFieldAddress TestPathSync_TargetLocation_PropertyAddress;

	private static int TestPathSync_TargetLocation_Offset;

	private static bool TestPathSync_ReturnValue_IsValid;

	private static FFieldAddress TestPathSync_ReturnValue_PropertyAddress;

	private static int TestPathSync_ReturnValue_Offset;

	private static bool StopAudio_IsValid;

	private static IntPtr StopAudio_FunctionAddress;

	private static int StopAudio_ParamsSize;

	private static bool StopAudio_AudioUtilActor_IsValid;

	private static FFieldAddress StopAudio_AudioUtilActor_PropertyAddress;

	private static int StopAudio_AudioUtilActor_Offset;

	private static bool SetPSOCacheUsageMask_IsValid;

	private static IntPtr SetPSOCacheUsageMask_FunctionAddress;

	private static int SetPSOCacheUsageMask_ParamsSize;

	private static bool SetPSOCacheUsageMask_MapIndex_IsValid;

	private static FFieldAddress SetPSOCacheUsageMask_MapIndex_PropertyAddress;

	private static int SetPSOCacheUsageMask_MapIndex_Offset;

	private static bool SetPSOCacheUsageMask_MaterialQualityLevel_IsValid;

	private static FFieldAddress SetPSOCacheUsageMask_MaterialQualityLevel_PropertyAddress;

	private static int SetPSOCacheUsageMask_MaterialQualityLevel_Offset;

	private static bool SetPSOCacheUsageMask_NiagaraQualityLevel_IsValid;

	private static FFieldAddress SetPSOCacheUsageMask_NiagaraQualityLevel_PropertyAddress;

	private static int SetPSOCacheUsageMask_NiagaraQualityLevel_Offset;

	private static bool SetPSOCacheUsageMask_ShadowQualityLevel_IsValid;

	private static FFieldAddress SetPSOCacheUsageMask_ShadowQualityLevel_PropertyAddress;

	private static int SetPSOCacheUsageMask_ShadowQualityLevel_Offset;

	private static bool SetMouseCursorWidgetVisible_IsValid;

	private static IntPtr SetMouseCursorWidgetVisible_FunctionAddress;

	private static int SetMouseCursorWidgetVisible_ParamsSize;

	private static bool SetMouseCursorWidgetVisible_PlayerController_IsValid;

	private static FFieldAddress SetMouseCursorWidgetVisible_PlayerController_PropertyAddress;

	private static int SetMouseCursorWidgetVisible_PlayerController_Offset;

	private static bool SetMouseCursorWidgetVisible_bVisible_IsValid;

	private static FFieldAddress SetMouseCursorWidgetVisible_bVisible_PropertyAddress;

	private static int SetMouseCursorWidgetVisible_bVisible_Offset;

	private static bool SetLogEnable_IsValid;

	private static IntPtr SetLogEnable_FunctionAddress;

	private static int SetLogEnable_ParamsSize;

	private static bool SetLogEnable_bEnableDbg_IsValid;

	private static FFieldAddress SetLogEnable_bEnableDbg_PropertyAddress;

	private static int SetLogEnable_bEnableDbg_Offset;

	private static bool SetLogEnable_bEnableDbgDisplay_IsValid;

	private static FFieldAddress SetLogEnable_bEnableDbgDisplay_PropertyAddress;

	private static int SetLogEnable_bEnableDbgDisplay_Offset;

	private static bool SetLogEnable_bEnableInfo_IsValid;

	private static FFieldAddress SetLogEnable_bEnableInfo_PropertyAddress;

	private static int SetLogEnable_bEnableInfo_Offset;

	private static bool SetLevelRequestSuspend_IsValid;

	private static IntPtr SetLevelRequestSuspend_FunctionAddress;

	private static int SetLevelRequestSuspend_ParamsSize;

	private static bool SetLevelRequestSuspend_ShouldSuspend_IsValid;

	private static FFieldAddress SetLevelRequestSuspend_ShouldSuspend_PropertyAddress;

	private static int SetLevelRequestSuspend_ShouldSuspend_Offset;

	private static bool SetInputModeUIOnly_IsValid;

	private static IntPtr SetInputModeUIOnly_FunctionAddress;

	private static int SetInputModeUIOnly_ParamsSize;

	private static bool SetInputModeUIOnly_Target_IsValid;

	private static FFieldAddress SetInputModeUIOnly_Target_PropertyAddress;

	private static int SetInputModeUIOnly_Target_Offset;

	private static bool SetInputModeUIOnly_InWidgetToFocus_IsValid;

	private static FFieldAddress SetInputModeUIOnly_InWidgetToFocus_PropertyAddress;

	private static int SetInputModeUIOnly_InWidgetToFocus_Offset;

	private static bool SetInputModeUIOnly_InMouseLockMode_IsValid;

	private static FFieldAddress SetInputModeUIOnly_InMouseLockMode_PropertyAddress;

	private static int SetInputModeUIOnly_InMouseLockMode_Offset;

	private static bool SetInputModeGameOnly_IsValid;

	private static IntPtr SetInputModeGameOnly_FunctionAddress;

	private static int SetInputModeGameOnly_ParamsSize;

	private static bool SetInputModeGameOnly_PlayerController_IsValid;

	private static FFieldAddress SetInputModeGameOnly_PlayerController_PropertyAddress;

	private static int SetInputModeGameOnly_PlayerController_Offset;

	private static bool SetInputDeadZone_IsValid;

	private static IntPtr SetInputDeadZone_FunctionAddress;

	private static int SetInputDeadZone_ParamsSize;

	private static bool SetInputDeadZone_PlayerController_IsValid;

	private static FFieldAddress SetInputDeadZone_PlayerController_PropertyAddress;

	private static int SetInputDeadZone_PlayerController_Offset;

	private static bool SetInputDeadZone_AxisName_IsValid;

	private static FFieldAddress SetInputDeadZone_AxisName_PropertyAddress;

	private static int SetInputDeadZone_AxisName_Offset;

	private static bool SetInputDeadZone_DeadZone_IsValid;

	private static FFieldAddress SetInputDeadZone_DeadZone_PropertyAddress;

	private static int SetInputDeadZone_DeadZone_Offset;

	private static bool SetDisplayGamma_IsValid;

	private static IntPtr SetDisplayGamma_FunctionAddress;

	private static int SetDisplayGamma_ParamsSize;

	private static bool SetDisplayGamma_WorldCtx_IsValid;

	private static FFieldAddress SetDisplayGamma_WorldCtx_PropertyAddress;

	private static int SetDisplayGamma_WorldCtx_Offset;

	private static bool SetDisplayGamma_Gamma_IsValid;

	private static FFieldAddress SetDisplayGamma_Gamma_PropertyAddress;

	private static int SetDisplayGamma_Gamma_Offset;

	private static bool SetDesiredQualityLevel_IsValid;

	private static IntPtr SetDesiredQualityLevel_FunctionAddress;

	private static int SetDesiredQualityLevel_ParamsSize;

	private static bool SetDesiredQualityLevel_TargetGSQualityLevel_IsValid;

	private static FFieldAddress SetDesiredQualityLevel_TargetGSQualityLevel_PropertyAddress;

	private static int SetDesiredQualityLevel_TargetGSQualityLevel_Offset;

	private static bool SetCanEverTick_IsValid;

	private static IntPtr SetCanEverTick_FunctionAddress;

	private static int SetCanEverTick_ParamsSize;

	private static bool SetCanEverTick_Obj_IsValid;

	private static FFieldAddress SetCanEverTick_Obj_PropertyAddress;

	private static int SetCanEverTick_Obj_Offset;

	private static bool SetCanEverTick_bEnable_IsValid;

	private static FFieldAddress SetCanEverTick_bEnable_PropertyAddress;

	private static int SetCanEverTick_bEnable_Offset;

	private static bool SetCanEverTick_ReturnValue_IsValid;

	private static FFieldAddress SetCanEverTick_ReturnValue_PropertyAddress;

	private static int SetCanEverTick_ReturnValue_Offset;

	private static bool SetAudioBoxFreqNum_IsValid;

	private static IntPtr SetAudioBoxFreqNum_FunctionAddress;

	private static int SetAudioBoxFreqNum_ParamsSize;

	private static bool SetAudioBoxFreqNum_AudioBox_IsValid;

	private static FFieldAddress SetAudioBoxFreqNum_AudioBox_PropertyAddress;

	private static int SetAudioBoxFreqNum_AudioBox_Offset;

	private static bool SetAudioBoxFreqNum_InFreqNum_IsValid;

	private static FFieldAddress SetAudioBoxFreqNum_InFreqNum_PropertyAddress;

	private static int SetAudioBoxFreqNum_InFreqNum_Offset;

	private static bool SetActorComponentMobilityMovable_IsValid;

	private static IntPtr SetActorComponentMobilityMovable_FunctionAddress;

	private static int SetActorComponentMobilityMovable_ParamsSize;

	private static bool SetActorComponentMobilityMovable_Actor_IsValid;

	private static FFieldAddress SetActorComponentMobilityMovable_Actor_PropertyAddress;

	private static int SetActorComponentMobilityMovable_Actor_Offset;

	private static bool SetActorComponentMobilityMovable_IsMovable_IsValid;

	private static FFieldAddress SetActorComponentMobilityMovable_IsMovable_PropertyAddress;

	private static int SetActorComponentMobilityMovable_IsMovable_Offset;

	private static bool ServerSeamlessTravel_IsValid;

	private static IntPtr ServerSeamlessTravel_FunctionAddress;

	private static int ServerSeamlessTravel_ParamsSize;

	private static bool ServerSeamlessTravel_World_IsValid;

	private static FFieldAddress ServerSeamlessTravel_World_PropertyAddress;

	private static int ServerSeamlessTravel_World_Offset;

	private static bool ServerSeamlessTravel_Url_IsValid;

	private static FFieldAddress ServerSeamlessTravel_Url_PropertyAddress;

	private static int ServerSeamlessTravel_Url_Offset;

	private static bool SaveStringToFile_IsValid;

	private static IntPtr SaveStringToFile_FunctionAddress;

	private static int SaveStringToFile_ParamsSize;

	private static bool SaveStringToFile_Path_IsValid;

	private static FFieldAddress SaveStringToFile_Path_PropertyAddress;

	private static int SaveStringToFile_Path_Offset;

	private static bool SaveStringToFile_Data_IsValid;

	private static FFieldAddress SaveStringToFile_Data_PropertyAddress;

	private static int SaveStringToFile_Data_Offset;

	private static bool SavePSOCacheFile_IsValid;

	private static IntPtr SavePSOCacheFile_FunctionAddress;

	private static int SavePSOCacheFile_ParamsSize;

	private static bool RunProcessWithCheck_IsValid;

	private static IntPtr RunProcessWithCheck_FunctionAddress;

	private static int RunProcessWithCheck_ParamsSize;

	private static bool RunProcessWithCheck_InProcessPath_IsValid;

	private static FFieldAddress RunProcessWithCheck_InProcessPath_PropertyAddress;

	private static int RunProcessWithCheck_InProcessPath_Offset;

	private static bool RunProcess_IsValid;

	private static IntPtr RunProcess_FunctionAddress;

	private static int RunProcess_ParamsSize;

	private static bool RunProcess_InProcessPath_IsValid;

	private static FFieldAddress RunProcess_InProcessPath_PropertyAddress;

	private static int RunProcess_InProcessPath_Offset;

	private static bool ResumePsoBatching_IsValid;

	private static IntPtr ResumePsoBatching_FunctionAddress;

	private static int ResumePsoBatching_ParamsSize;

	private static bool RestartGame_IsValid;

	private static IntPtr RestartGame_FunctionAddress;

	private static int RestartGame_ParamsSize;

	private static bool RestartGame_GameMode_IsValid;

	private static FFieldAddress RestartGame_GameMode_PropertyAddress;

	private static int RestartGame_GameMode_Offset;

	private static bool RestartApplication_IsValid;

	private static IntPtr RestartApplication_FunctionAddress;

	private static int RestartApplication_ParamsSize;

	private static bool ResetAudioVisualizing_IsValid;

	private static IntPtr ResetAudioVisualizing_FunctionAddress;

	private static int ResetAudioVisualizing_ParamsSize;

	private static bool ResetAudioVisualizing_AudioBox_IsValid;

	private static FFieldAddress ResetAudioVisualizing_AudioBox_PropertyAddress;

	private static int ResetAudioVisualizing_AudioBox_Offset;

	private static bool RequestQuit_IsValid;

	private static IntPtr RequestQuit_FunctionAddress;

	private static int RequestQuit_ParamsSize;

	private static bool RequestQuit_Desc_IsValid;

	private static FFieldAddress RequestQuit_Desc_PropertyAddress;

	private static int RequestQuit_Desc_Offset;

	private static bool RequestExit_IsValid;

	private static IntPtr RequestExit_FunctionAddress;

	private static int RequestExit_ParamsSize;

	private static bool RequestExit_Force_IsValid;

	private static FFieldAddress RequestExit_Force_PropertyAddress;

	private static int RequestExit_Force_Offset;

	private static bool ReplaceInputAxisList_IsValid;

	private static IntPtr ReplaceInputAxisList_FunctionAddress;

	private static int ReplaceInputAxisList_ParamsSize;

	private static bool ReplaceInputAxisList_PlayerController_IsValid;

	private static FFieldAddress ReplaceInputAxisList_PlayerController_PropertyAddress;

	private static int ReplaceInputAxisList_PlayerController_Offset;

	private static bool ReplaceInputAxisList_AxisMappings_IsValid;

	private static FFieldAddress ReplaceInputAxisList_AxisMappings_PropertyAddress;

	private static int ReplaceInputAxisList_AxisMappings_Offset;

	private static bool ReplaceInputActionList_IsValid;

	private static IntPtr ReplaceInputActionList_FunctionAddress;

	private static int ReplaceInputActionList_ParamsSize;

	private static bool ReplaceInputActionList_PlayerController_IsValid;

	private static FFieldAddress ReplaceInputActionList_PlayerController_PropertyAddress;

	private static int ReplaceInputActionList_PlayerController_Offset;

	private static bool ReplaceInputActionList_ActionMappings_IsValid;

	private static FFieldAddress ReplaceInputActionList_ActionMappings_PropertyAddress;

	private static int ReplaceInputActionList_ActionMappings_Offset;

	private static bool RegisterComponent_IsValid;

	private static IntPtr RegisterComponent_FunctionAddress;

	private static int RegisterComponent_ParamsSize;

	private static bool RegisterComponent_ActorComponent_IsValid;

	private static FFieldAddress RegisterComponent_ActorComponent_PropertyAddress;

	private static int RegisterComponent_ActorComponent_Offset;

	private static bool RegisteConsoleKey_IsValid;

	private static IntPtr RegisteConsoleKey_FunctionAddress;

	private static int RegisteConsoleKey_ParamsSize;

	private static bool RegisteConsoleKey_Keys_IsValid;

	private static FFieldAddress RegisteConsoleKey_Keys_PropertyAddress;

	private static int RegisteConsoleKey_Keys_Offset;

	private static bool QuitGame_IsValid;

	private static IntPtr QuitGame_FunctionAddress;

	private static int QuitGame_ParamsSize;

	private static bool QuitGame_WorldCtx_IsValid;

	private static FFieldAddress QuitGame_WorldCtx_PropertyAddress;

	private static int QuitGame_WorldCtx_Offset;

	private static bool QuitEditor_IsValid;

	private static IntPtr QuitEditor_FunctionAddress;

	private static int QuitEditor_ParamsSize;

	private static bool QAIsCompiling_IsValid;

	private static IntPtr QAIsCompiling_FunctionAddress;

	private static int QAIsCompiling_ParamsSize;

	private static bool QAIsCompiling_ReturnValue_IsValid;

	private static FFieldAddress QAIsCompiling_ReturnValue_PropertyAddress;

	private static int QAIsCompiling_ReturnValue_Offset;

	private static bool QAHasReached_IsValid;

	private static IntPtr QAHasReached_FunctionAddress;

	private static int QAHasReached_ParamsSize;

	private static bool QAHasReached_AgentActor_IsValid;

	private static FFieldAddress QAHasReached_AgentActor_PropertyAddress;

	private static int QAHasReached_AgentActor_Offset;

	private static bool QAHasReached_GoalActor_IsValid;

	private static FFieldAddress QAHasReached_GoalActor_PropertyAddress;

	private static int QAHasReached_GoalActor_Offset;

	private static bool QAHasReached_ReturnValue_IsValid;

	private static FFieldAddress QAHasReached_ReturnValue_PropertyAddress;

	private static int QAHasReached_ReturnValue_Offset;

	private static bool QAGetSimpleCollisionCylinder_IsValid;

	private static IntPtr QAGetSimpleCollisionCylinder_FunctionAddress;

	private static int QAGetSimpleCollisionCylinder_ParamsSize;

	private static bool QAGetSimpleCollisionCylinder_AgentActor_IsValid;

	private static FFieldAddress QAGetSimpleCollisionCylinder_AgentActor_PropertyAddress;

	private static int QAGetSimpleCollisionCylinder_AgentActor_Offset;

	private static bool QAGetSimpleCollisionCylinder_CollisionRadius_IsValid;

	private static FFieldAddress QAGetSimpleCollisionCylinder_CollisionRadius_PropertyAddress;

	private static int QAGetSimpleCollisionCylinder_CollisionRadius_Offset;

	private static bool QAGetSimpleCollisionCylinder_CollisionHalfHeight_IsValid;

	private static FFieldAddress QAGetSimpleCollisionCylinder_CollisionHalfHeight_PropertyAddress;

	private static int QAGetSimpleCollisionCylinder_CollisionHalfHeight_Offset;

	private static bool QAGenCrash_IsValid;

	private static IntPtr QAGenCrash_FunctionAddress;

	private static int QAGenCrash_ParamsSize;

	private static bool PSOFullCompilation_IsValid;

	private static IntPtr PSOFullCompilation_FunctionAddress;

	private static int PSOFullCompilation_ParamsSize;

	private static bool PrepareLevelsNeedToBeUnloaded_IsValid;

	private static IntPtr PrepareLevelsNeedToBeUnloaded_FunctionAddress;

	private static int PrepareLevelsNeedToBeUnloaded_ParamsSize;

	private static bool PrepareLevelsNeedToBeUnloaded_WorldContextObject_IsValid;

	private static FFieldAddress PrepareLevelsNeedToBeUnloaded_WorldContextObject_PropertyAddress;

	private static int PrepareLevelsNeedToBeUnloaded_WorldContextObject_Offset;

	private static bool PlayAudio_IsValid;

	private static IntPtr PlayAudio_FunctionAddress;

	private static int PlayAudio_ParamsSize;

	private static bool PlayAudio_AudioUtilActor_IsValid;

	private static FFieldAddress PlayAudio_AudioUtilActor_PropertyAddress;

	private static int PlayAudio_AudioUtilActor_Offset;

	private static bool PlayAudio_VisualOnly_IsValid;

	private static FFieldAddress PlayAudio_VisualOnly_PropertyAddress;

	private static int PlayAudio_VisualOnly_Offset;

	private static bool PerfTest_IsValid;

	private static IntPtr PerfTest_FunctionAddress;

	private static int PerfTest_ParamsSize;

	private static bool PerfTest_CaseID_IsValid;

	private static FFieldAddress PerfTest_CaseID_PropertyAddress;

	private static int PerfTest_CaseID_Offset;

	private static bool PerfTest_Count_IsValid;

	private static FFieldAddress PerfTest_Count_PropertyAddress;

	private static int PerfTest_Count_Offset;

	private static bool PausePsoBatching_IsValid;

	private static IntPtr PausePsoBatching_FunctionAddress;

	private static int PausePsoBatching_ParamsSize;

	private static bool PauseAudio_IsValid;

	private static IntPtr PauseAudio_FunctionAddress;

	private static int PauseAudio_ParamsSize;

	private static bool PauseAudio_AudioUtilActor_IsValid;

	private static FFieldAddress PauseAudio_AudioUtilActor_PropertyAddress;

	private static int PauseAudio_AudioUtilActor_Offset;

	private static bool MultipleColorLerp_IsValid;

	private static IntPtr MultipleColorLerp_FunctionAddress;

	private static int MultipleColorLerp_ParamsSize;

	private static bool MultipleColorLerp_V1_IsValid;

	private static FFieldAddress MultipleColorLerp_V1_PropertyAddress;

	private static int MultipleColorLerp_V1_Offset;

	private static bool MultipleColorLerp_V2_IsValid;

	private static FFieldAddress MultipleColorLerp_V2_PropertyAddress;

	private static int MultipleColorLerp_V2_Offset;

	private static bool MultipleColorLerp_V3_IsValid;

	private static FFieldAddress MultipleColorLerp_V3_PropertyAddress;

	private static int MultipleColorLerp_V3_Offset;

	private static bool MultipleColorLerp_V4_IsValid;

	private static FFieldAddress MultipleColorLerp_V4_PropertyAddress;

	private static int MultipleColorLerp_V4_Offset;

	private static bool MultipleColorLerp_LerpAlpha_IsValid;

	private static FFieldAddress MultipleColorLerp_LerpAlpha_PropertyAddress;

	private static int MultipleColorLerp_LerpAlpha_Offset;

	private static bool MultipleColorLerp_ReturnValue_IsValid;

	private static FFieldAddress MultipleColorLerp_ReturnValue_PropertyAddress;

	private static int MultipleColorLerp_ReturnValue_Offset;

	private static bool MediaPlayerTimeSeek_IsValid;

	private static IntPtr MediaPlayerTimeSeek_FunctionAddress;

	private static int MediaPlayerTimeSeek_ParamsSize;

	private static bool MediaPlayerTimeSeek_MediaPlayer_IsValid;

	private static FFieldAddress MediaPlayerTimeSeek_MediaPlayer_PropertyAddress;

	private static int MediaPlayerTimeSeek_MediaPlayer_Offset;

	private static bool MediaPlayerTimeSeek_Time_IsValid;

	private static FFieldAddress MediaPlayerTimeSeek_Time_PropertyAddress;

	private static int MediaPlayerTimeSeek_Time_Offset;

	private static bool MathEaseV_IsValid;

	private static IntPtr MathEaseV_FunctionAddress;

	private static int MathEaseV_ParamsSize;

	private static bool MathEaseV_A_IsValid;

	private static FFieldAddress MathEaseV_A_PropertyAddress;

	private static int MathEaseV_A_Offset;

	private static bool MathEaseV_B_IsValid;

	private static FFieldAddress MathEaseV_B_PropertyAddress;

	private static int MathEaseV_B_Offset;

	private static bool MathEaseV_Alpha_IsValid;

	private static FFieldAddress MathEaseV_Alpha_PropertyAddress;

	private static int MathEaseV_Alpha_Offset;

	private static bool MathEaseV_EasingFunc_IsValid;

	private static FFieldAddress MathEaseV_EasingFunc_PropertyAddress;

	private static int MathEaseV_EasingFunc_Offset;

	private static bool MathEaseV_BlendExp_IsValid;

	private static FFieldAddress MathEaseV_BlendExp_PropertyAddress;

	private static int MathEaseV_BlendExp_Offset;

	private static bool MathEaseV_Steps_IsValid;

	private static FFieldAddress MathEaseV_Steps_PropertyAddress;

	private static int MathEaseV_Steps_Offset;

	private static bool MathEaseV_ReturnValue_IsValid;

	private static FFieldAddress MathEaseV_ReturnValue_PropertyAddress;

	private static int MathEaseV_ReturnValue_Offset;

	private static bool MathEaseR_IsValid;

	private static IntPtr MathEaseR_FunctionAddress;

	private static int MathEaseR_ParamsSize;

	private static bool MathEaseR_A_IsValid;

	private static FFieldAddress MathEaseR_A_PropertyAddress;

	private static int MathEaseR_A_Offset;

	private static bool MathEaseR_B_IsValid;

	private static FFieldAddress MathEaseR_B_PropertyAddress;

	private static int MathEaseR_B_Offset;

	private static bool MathEaseR_Alpha_IsValid;

	private static FFieldAddress MathEaseR_Alpha_PropertyAddress;

	private static int MathEaseR_Alpha_Offset;

	private static bool MathEaseR_bShortestPath_IsValid;

	private static FFieldAddress MathEaseR_bShortestPath_PropertyAddress;

	private static int MathEaseR_bShortestPath_Offset;

	private static bool MathEaseR_EasingFunc_IsValid;

	private static FFieldAddress MathEaseR_EasingFunc_PropertyAddress;

	private static int MathEaseR_EasingFunc_Offset;

	private static bool MathEaseR_BlendExp_IsValid;

	private static FFieldAddress MathEaseR_BlendExp_PropertyAddress;

	private static int MathEaseR_BlendExp_Offset;

	private static bool MathEaseR_Steps_IsValid;

	private static FFieldAddress MathEaseR_Steps_PropertyAddress;

	private static int MathEaseR_Steps_Offset;

	private static bool MathEaseR_ReturnValue_IsValid;

	private static FFieldAddress MathEaseR_ReturnValue_PropertyAddress;

	private static int MathEaseR_ReturnValue_Offset;

	private static bool MathEaseLinearColor_IsValid;

	private static IntPtr MathEaseLinearColor_FunctionAddress;

	private static int MathEaseLinearColor_ParamsSize;

	private static bool MathEaseLinearColor_A_IsValid;

	private static FFieldAddress MathEaseLinearColor_A_PropertyAddress;

	private static int MathEaseLinearColor_A_Offset;

	private static bool MathEaseLinearColor_B_IsValid;

	private static FFieldAddress MathEaseLinearColor_B_PropertyAddress;

	private static int MathEaseLinearColor_B_Offset;

	private static bool MathEaseLinearColor_Alpha_IsValid;

	private static FFieldAddress MathEaseLinearColor_Alpha_PropertyAddress;

	private static int MathEaseLinearColor_Alpha_Offset;

	private static bool MathEaseLinearColor_EasingFunc_IsValid;

	private static FFieldAddress MathEaseLinearColor_EasingFunc_PropertyAddress;

	private static int MathEaseLinearColor_EasingFunc_Offset;

	private static bool MathEaseLinearColor_BlendExp_IsValid;

	private static FFieldAddress MathEaseLinearColor_BlendExp_PropertyAddress;

	private static int MathEaseLinearColor_BlendExp_Offset;

	private static bool MathEaseLinearColor_Steps_IsValid;

	private static FFieldAddress MathEaseLinearColor_Steps_PropertyAddress;

	private static int MathEaseLinearColor_Steps_Offset;

	private static bool MathEaseLinearColor_ReturnValue_IsValid;

	private static FFieldAddress MathEaseLinearColor_ReturnValue_PropertyAddress;

	private static int MathEaseLinearColor_ReturnValue_Offset;

	private static bool MathEase2D_IsValid;

	private static IntPtr MathEase2D_FunctionAddress;

	private static int MathEase2D_ParamsSize;

	private static bool MathEase2D_A_IsValid;

	private static FFieldAddress MathEase2D_A_PropertyAddress;

	private static int MathEase2D_A_Offset;

	private static bool MathEase2D_B_IsValid;

	private static FFieldAddress MathEase2D_B_PropertyAddress;

	private static int MathEase2D_B_Offset;

	private static bool MathEase2D_Alpha_IsValid;

	private static FFieldAddress MathEase2D_Alpha_PropertyAddress;

	private static int MathEase2D_Alpha_Offset;

	private static bool MathEase2D_EasingFunc_IsValid;

	private static FFieldAddress MathEase2D_EasingFunc_PropertyAddress;

	private static int MathEase2D_EasingFunc_Offset;

	private static bool MathEase2D_BlendExp_IsValid;

	private static FFieldAddress MathEase2D_BlendExp_PropertyAddress;

	private static int MathEase2D_BlendExp_Offset;

	private static bool MathEase2D_Steps_IsValid;

	private static FFieldAddress MathEase2D_Steps_PropertyAddress;

	private static int MathEase2D_Steps_Offset;

	private static bool MathEase2D_ReturnValue_IsValid;

	private static FFieldAddress MathEase2D_ReturnValue_PropertyAddress;

	private static int MathEase2D_ReturnValue_Offset;

	private static bool MathEase_IsValid;

	private static IntPtr MathEase_FunctionAddress;

	private static int MathEase_ParamsSize;

	private static bool MathEase_A_IsValid;

	private static FFieldAddress MathEase_A_PropertyAddress;

	private static int MathEase_A_Offset;

	private static bool MathEase_B_IsValid;

	private static FFieldAddress MathEase_B_PropertyAddress;

	private static int MathEase_B_Offset;

	private static bool MathEase_Alpha_IsValid;

	private static FFieldAddress MathEase_Alpha_PropertyAddress;

	private static int MathEase_Alpha_Offset;

	private static bool MathEase_EasingFunc_IsValid;

	private static FFieldAddress MathEase_EasingFunc_PropertyAddress;

	private static int MathEase_EasingFunc_Offset;

	private static bool MathEase_BlendExp_IsValid;

	private static FFieldAddress MathEase_BlendExp_PropertyAddress;

	private static int MathEase_BlendExp_Offset;

	private static bool MathEase_Steps_IsValid;

	private static FFieldAddress MathEase_Steps_PropertyAddress;

	private static int MathEase_Steps_Offset;

	private static bool MathEase_ReturnValue_IsValid;

	private static FFieldAddress MathEase_ReturnValue_PropertyAddress;

	private static int MathEase_ReturnValue_Offset;

	private static bool MarkUnloadPsoState_IsValid;

	private static IntPtr MarkUnloadPsoState_FunctionAddress;

	private static int MarkUnloadPsoState_ParamsSize;

	private static bool LogWLevel_IsValid;

	private static IntPtr LogWLevel_FunctionAddress;

	private static int LogWLevel_ParamsSize;

	private static bool LogWLevel_Str_IsValid;

	private static FFieldAddress LogWLevel_Str_PropertyAddress;

	private static int LogWLevel_Str_Offset;

	private static bool LogWLevel_InLogLevel_IsValid;

	private static FFieldAddress LogWLevel_InLogLevel_PropertyAddress;

	private static int LogWLevel_InLogLevel_Offset;

	private static bool LogWarning_IsValid;

	private static IntPtr LogWarning_FunctionAddress;

	private static int LogWarning_ParamsSize;

	private static bool LogWarning_Str_IsValid;

	private static FFieldAddress LogWarning_Str_PropertyAddress;

	private static int LogWarning_Str_Offset;

	private static bool LogShippingError_IsValid;

	private static IntPtr LogShippingError_FunctionAddress;

	private static int LogShippingError_ParamsSize;

	private static bool LogShippingError_Str_IsValid;

	private static FFieldAddress LogShippingError_Str_PropertyAddress;

	private static int LogShippingError_Str_Offset;

	private static bool LogShipping_IsValid;

	private static IntPtr LogShipping_FunctionAddress;

	private static int LogShipping_ParamsSize;

	private static bool LogShipping_Str_IsValid;

	private static FFieldAddress LogShipping_Str_PropertyAddress;

	private static int LogShipping_Str_Offset;

	private static bool LogInfo_IsValid;

	private static IntPtr LogInfo_FunctionAddress;

	private static int LogInfo_ParamsSize;

	private static bool LogInfo_Str_IsValid;

	private static FFieldAddress LogInfo_Str_PropertyAddress;

	private static int LogInfo_Str_Offset;

	private static bool LogError_IsValid;

	private static IntPtr LogError_FunctionAddress;

	private static int LogError_ParamsSize;

	private static bool LogError_Str_IsValid;

	private static FFieldAddress LogError_Str_PropertyAddress;

	private static int LogError_Str_Offset;

	private static bool LogDbgWithColor_IsValid;

	private static IntPtr LogDbgWithColor_FunctionAddress;

	private static int LogDbgWithColor_ParamsSize;

	private static bool LogDbgWithColor_Str_IsValid;

	private static FFieldAddress LogDbgWithColor_Str_PropertyAddress;

	private static int LogDbgWithColor_Str_Offset;

	private static bool LogDbgWithColor_bPrintScreen_IsValid;

	private static FFieldAddress LogDbgWithColor_bPrintScreen_PropertyAddress;

	private static int LogDbgWithColor_bPrintScreen_Offset;

	private static bool LogDbgWithColor_TimeToDisplay_IsValid;

	private static FFieldAddress LogDbgWithColor_TimeToDisplay_PropertyAddress;

	private static int LogDbgWithColor_TimeToDisplay_Offset;

	private static bool LogDbgWithColor_Color_IsValid;

	private static FFieldAddress LogDbgWithColor_Color_PropertyAddress;

	private static int LogDbgWithColor_Color_Offset;

	private static bool LogDbgWithColor_key_IsValid;

	private static FFieldAddress LogDbgWithColor_key_PropertyAddress;

	private static int LogDbgWithColor_key_Offset;

	private static bool LogDbg_IsValid;

	private static IntPtr LogDbg_FunctionAddress;

	private static int LogDbg_ParamsSize;

	private static bool LogDbg_Str_IsValid;

	private static FFieldAddress LogDbg_Str_PropertyAddress;

	private static int LogDbg_Str_Offset;

	private static bool LogDbg_bPrintScreen_IsValid;

	private static FFieldAddress LogDbg_bPrintScreen_PropertyAddress;

	private static int LogDbg_bPrintScreen_Offset;

	private static bool LogDbg_TimeToDisplay_IsValid;

	private static FFieldAddress LogDbg_TimeToDisplay_PropertyAddress;

	private static int LogDbg_TimeToDisplay_Offset;

	private static bool LoadFileToString_IsValid;

	private static IntPtr LoadFileToString_FunctionAddress;

	private static int LoadFileToString_ParamsSize;

	private static bool LoadFileToString_Path_IsValid;

	private static FFieldAddress LoadFileToString_Path_PropertyAddress;

	private static int LoadFileToString_Path_Offset;

	private static bool LoadFileToString_ReturnValue_IsValid;

	private static FFieldAddress LoadFileToString_ReturnValue_PropertyAddress;

	private static int LoadFileToString_ReturnValue_Offset;

	private static bool IsUnloadPSOFinished_IsValid;

	private static IntPtr IsUnloadPSOFinished_FunctionAddress;

	private static int IsUnloadPSOFinished_ParamsSize;

	private static bool IsUnloadPSOFinished_ReturnValue_IsValid;

	private static FFieldAddress IsUnloadPSOFinished_ReturnValue_PropertyAddress;

	private static int IsUnloadPSOFinished_ReturnValue_Offset;

	private static bool IsTestBuild_IsValid;

	private static IntPtr IsTestBuild_FunctionAddress;

	private static int IsTestBuild_ParamsSize;

	private static bool IsTestBuild_ReturnValue_IsValid;

	private static FFieldAddress IsTestBuild_ReturnValue_PropertyAddress;

	private static int IsTestBuild_ReturnValue_Offset;

	private static bool IsStandaloneGame_IsValid;

	private static IntPtr IsStandaloneGame_FunctionAddress;

	private static int IsStandaloneGame_ParamsSize;

	private static bool IsStandaloneGame_ReturnValue_IsValid;

	private static FFieldAddress IsStandaloneGame_ReturnValue_PropertyAddress;

	private static int IsStandaloneGame_ReturnValue_Offset;

	private static bool IsStandAlone_IsValid;

	private static IntPtr IsStandAlone_FunctionAddress;

	private static int IsStandAlone_ParamsSize;

	private static bool IsStandAlone_World_IsValid;

	private static FFieldAddress IsStandAlone_World_PropertyAddress;

	private static int IsStandAlone_World_Offset;

	private static bool IsStandAlone_ReturnValue_IsValid;

	private static FFieldAddress IsStandAlone_ReturnValue_PropertyAddress;

	private static int IsStandAlone_ReturnValue_Offset;

	private static bool IsShippingBuild_IsValid;

	private static IntPtr IsShippingBuild_FunctionAddress;

	private static int IsShippingBuild_ParamsSize;

	private static bool IsShippingBuild_ReturnValue_IsValid;

	private static FFieldAddress IsShippingBuild_ReturnValue_PropertyAddress;

	private static int IsShippingBuild_ReturnValue_Offset;

	private static bool IsSavePSOCacheInErrorState_IsValid;

	private static IntPtr IsSavePSOCacheInErrorState_FunctionAddress;

	private static int IsSavePSOCacheInErrorState_ParamsSize;

	private static bool IsSavePSOCacheInErrorState_ReturnValue_IsValid;

	private static FFieldAddress IsSavePSOCacheInErrorState_ReturnValue_PropertyAddress;

	private static int IsSavePSOCacheInErrorState_ReturnValue_Offset;

	private static bool IsRegexMatched_IsValid;

	private static IntPtr IsRegexMatched_FunctionAddress;

	private static int IsRegexMatched_ParamsSize;

	private static bool IsRegexMatched_InStr_IsValid;

	private static FFieldAddress IsRegexMatched_InStr_PropertyAddress;

	private static int IsRegexMatched_InStr_Offset;

	private static bool IsRegexMatched_RegexExpression_IsValid;

	private static FFieldAddress IsRegexMatched_RegexExpression_PropertyAddress;

	private static int IsRegexMatched_RegexExpression_Offset;

	private static bool IsRegexMatched_ReturnValue_IsValid;

	private static FFieldAddress IsRegexMatched_ReturnValue_PropertyAddress;

	private static int IsRegexMatched_ReturnValue_Offset;

	private static bool IsPSOBatchingPaused_IsValid;

	private static IntPtr IsPSOBatchingPaused_FunctionAddress;

	private static int IsPSOBatchingPaused_ParamsSize;

	private static bool IsPSOBatchingPaused_ReturnValue_IsValid;

	private static FFieldAddress IsPSOBatchingPaused_ReturnValue_PropertyAddress;

	private static int IsPSOBatchingPaused_ReturnValue_Offset;

	private static bool IsListenServer_IsValid;

	private static IntPtr IsListenServer_FunctionAddress;

	private static int IsListenServer_ParamsSize;

	private static bool IsListenServer_World_IsValid;

	private static FFieldAddress IsListenServer_World_PropertyAddress;

	private static int IsListenServer_World_Offset;

	private static bool IsListenServer_ReturnValue_IsValid;

	private static FFieldAddress IsListenServer_ReturnValue_PropertyAddress;

	private static int IsListenServer_ReturnValue_Offset;

	private static bool IsEditor_IsValid;

	private static IntPtr IsEditor_FunctionAddress;

	private static int IsEditor_ParamsSize;

	private static bool IsEditor_ReturnValue_IsValid;

	private static FFieldAddress IsEditor_ReturnValue_PropertyAddress;

	private static int IsEditor_ReturnValue_Offset;

	private static bool IsDriverVersionMismatch_IsValid;

	private static IntPtr IsDriverVersionMismatch_FunctionAddress;

	private static int IsDriverVersionMismatch_ParamsSize;

	private static bool IsDriverVersionMismatch_ReturnValue_IsValid;

	private static FFieldAddress IsDriverVersionMismatch_ReturnValue_PropertyAddress;

	private static int IsDriverVersionMismatch_ReturnValue_Offset;

	private static bool IsDevelopmentBuild_IsValid;

	private static IntPtr IsDevelopmentBuild_FunctionAddress;

	private static int IsDevelopmentBuild_ParamsSize;

	private static bool IsDevelopmentBuild_ReturnValue_IsValid;

	private static FFieldAddress IsDevelopmentBuild_ReturnValue_PropertyAddress;

	private static int IsDevelopmentBuild_ReturnValue_Offset;

	private static bool IsDedicateServer_IsValid;

	private static IntPtr IsDedicateServer_FunctionAddress;

	private static int IsDedicateServer_ParamsSize;

	private static bool IsDedicateServer_World_IsValid;

	private static FFieldAddress IsDedicateServer_World_PropertyAddress;

	private static int IsDedicateServer_World_Offset;

	private static bool IsDedicateServer_ReturnValue_IsValid;

	private static FFieldAddress IsDedicateServer_ReturnValue_PropertyAddress;

	private static int IsDedicateServer_ReturnValue_Offset;

	private static bool IsControllerInPlayState_IsValid;

	private static IntPtr IsControllerInPlayState_FunctionAddress;

	private static int IsControllerInPlayState_ParamsSize;

	private static bool IsControllerInPlayState_Controller_IsValid;

	private static FFieldAddress IsControllerInPlayState_Controller_PropertyAddress;

	private static int IsControllerInPlayState_Controller_Offset;

	private static bool IsControllerInPlayState_ReturnValue_IsValid;

	private static FFieldAddress IsControllerInPlayState_ReturnValue_PropertyAddress;

	private static int IsControllerInPlayState_ReturnValue_Offset;

	private static bool IsCommandLineHasParam_IsValid;

	private static IntPtr IsCommandLineHasParam_FunctionAddress;

	private static int IsCommandLineHasParam_ParamsSize;

	private static bool IsCommandLineHasParam_QueryParam_IsValid;

	private static FFieldAddress IsCommandLineHasParam_QueryParam_PropertyAddress;

	private static int IsCommandLineHasParam_QueryParam_Offset;

	private static bool IsCommandLineHasParam_ReturnValue_IsValid;

	private static FFieldAddress IsCommandLineHasParam_ReturnValue_PropertyAddress;

	private static int IsCommandLineHasParam_ReturnValue_Offset;

	private static bool IsClient_IsValid;

	private static IntPtr IsClient_FunctionAddress;

	private static int IsClient_ParamsSize;

	private static bool IsClient_World_IsValid;

	private static FFieldAddress IsClient_World_PropertyAddress;

	private static int IsClient_World_Offset;

	private static bool IsClient_ReturnValue_IsValid;

	private static FFieldAddress IsClient_ReturnValue_PropertyAddress;

	private static int IsClient_ReturnValue_Offset;

	private static bool HasValidCaptureData_IsValid;

	private static IntPtr HasValidCaptureData_FunctionAddress;

	private static int HasValidCaptureData_ParamsSize;

	private static bool HasValidCaptureData_Component_IsValid;

	private static FFieldAddress HasValidCaptureData_Component_PropertyAddress;

	private static int HasValidCaptureData_Component_Offset;

	private static bool HasValidCaptureData_ReturnValue_IsValid;

	private static FFieldAddress HasValidCaptureData_ReturnValue_PropertyAddress;

	private static int HasValidCaptureData_ReturnValue_Offset;

	private static bool HasLaunchOption_IsValid;

	private static IntPtr HasLaunchOption_FunctionAddress;

	private static int HasLaunchOption_ParamsSize;

	private static bool HasLaunchOption_Option_IsValid;

	private static FFieldAddress HasLaunchOption_Option_PropertyAddress;

	private static int HasLaunchOption_Option_Offset;

	private static bool HasLaunchOption_ReturnValue_IsValid;

	private static FFieldAddress HasLaunchOption_ReturnValue_PropertyAddress;

	private static int HasLaunchOption_ReturnValue_Offset;

	private static bool GSSaveConfig_IsValid;

	private static IntPtr GSSaveConfig_FunctionAddress;

	private static int GSSaveConfig_ParamsSize;

	private static bool GSSaveConfig_WorldContext_IsValid;

	private static FFieldAddress GSSaveConfig_WorldContext_PropertyAddress;

	private static int GSSaveConfig_WorldContext_Offset;

	private static bool GetWorldMainAudioDeviceID_IsValid;

	private static IntPtr GetWorldMainAudioDeviceID_FunctionAddress;

	private static int GetWorldMainAudioDeviceID_ParamsSize;

	private static bool GetWorldMainAudioDeviceID_WorldContextObject_IsValid;

	private static FFieldAddress GetWorldMainAudioDeviceID_WorldContextObject_PropertyAddress;

	private static int GetWorldMainAudioDeviceID_WorldContextObject_Offset;

	private static bool GetWorldMainAudioDeviceID_ReturnValue_IsValid;

	private static FFieldAddress GetWorldMainAudioDeviceID_ReturnValue_PropertyAddress;

	private static int GetWorldMainAudioDeviceID_ReturnValue_Offset;

	private static bool GetWorldFromObj_IsValid;

	private static IntPtr GetWorldFromObj_FunctionAddress;

	private static int GetWorldFromObj_ParamsSize;

	private static bool GetWorldFromObj_Context_IsValid;

	private static FFieldAddress GetWorldFromObj_Context_PropertyAddress;

	private static int GetWorldFromObj_Context_Offset;

	private static bool GetWorldFromObj_ReturnValue_IsValid;

	private static FFieldAddress GetWorldFromObj_ReturnValue_PropertyAddress;

	private static int GetWorldFromObj_ReturnValue_Offset;

	private static bool GetWindowScreenResolution_IsValid;

	private static IntPtr GetWindowScreenResolution_FunctionAddress;

	private static int GetWindowScreenResolution_ParamsSize;

	private static bool GetWindowScreenResolution_ReturnValue_IsValid;

	private static FFieldAddress GetWindowScreenResolution_ReturnValue_PropertyAddress;

	private static int GetWindowScreenResolution_ReturnValue_Offset;

	private static bool GetWarningUITexList_IsValid;

	private static IntPtr GetWarningUITexList_FunctionAddress;

	private static int GetWarningUITexList_ParamsSize;

	private static bool GetWarningUITexList_WorldContext_IsValid;

	private static FFieldAddress GetWarningUITexList_WorldContext_PropertyAddress;

	private static int GetWarningUITexList_WorldContext_Offset;

	private static bool GetWarningUITexList_TraverseRootPath_IsValid;

	private static FFieldAddress GetWarningUITexList_TraverseRootPath_PropertyAddress;

	private static int GetWarningUITexList_TraverseRootPath_Offset;

	private static bool GetWarningUITexList_SourceFileCommPath_IsValid;

	private static FFieldAddress GetWarningUITexList_SourceFileCommPath_PropertyAddress;

	private static int GetWarningUITexList_SourceFileCommPath_Offset;

	private static bool GetWarningUITexList_ExcludedPathList_IsValid;

	private static FFieldAddress GetWarningUITexList_ExcludedPathList_PropertyAddress;

	private static int GetWarningUITexList_ExcludedPathList_Offset;

	private static bool GetWarningUITexList_ReturnValue_IsValid;

	private static FFieldAddress GetWarningUITexList_ReturnValue_PropertyAddress;

	private static int GetWarningUITexList_ReturnValue_Offset;

	private static bool GetWarningPhysicsAssetList_IsValid;

	private static IntPtr GetWarningPhysicsAssetList_FunctionAddress;

	private static int GetWarningPhysicsAssetList_ParamsSize;

	private static bool GetWarningPhysicsAssetList_WorldContext_IsValid;

	private static FFieldAddress GetWarningPhysicsAssetList_WorldContext_PropertyAddress;

	private static int GetWarningPhysicsAssetList_WorldContext_Offset;

	private static bool GetWarningPhysicsAssetList_TraverseRootPath_IsValid;

	private static FFieldAddress GetWarningPhysicsAssetList_TraverseRootPath_PropertyAddress;

	private static int GetWarningPhysicsAssetList_TraverseRootPath_Offset;

	private static bool GetWarningPhysicsAssetList_ReturnValue_IsValid;

	private static FFieldAddress GetWarningPhysicsAssetList_ReturnValue_PropertyAddress;

	private static int GetWarningPhysicsAssetList_ReturnValue_Offset;

	private static bool GetTransientPackage_IsValid;

	private static IntPtr GetTransientPackage_FunctionAddress;

	private static int GetTransientPackage_ParamsSize;

	private static bool GetTransientPackage_ReturnValue_IsValid;

	private static FFieldAddress GetTransientPackage_ReturnValue_PropertyAddress;

	private static int GetTransientPackage_ReturnValue_Offset;

	private static bool GetTotalPsoPrecompileNum_IsValid;

	private static IntPtr GetTotalPsoPrecompileNum_FunctionAddress;

	private static int GetTotalPsoPrecompileNum_ParamsSize;

	private static bool GetTotalPsoPrecompileNum_ReturnValue_IsValid;

	private static FFieldAddress GetTotalPsoPrecompileNum_ReturnValue_PropertyAddress;

	private static int GetTotalPsoPrecompileNum_ReturnValue_Offset;

	private static bool GetTimeSpanFromSeconds_IsValid;

	private static IntPtr GetTimeSpanFromSeconds_FunctionAddress;

	private static int GetTimeSpanFromSeconds_ParamsSize;

	private static bool GetTimeSpanFromSeconds_Seconds_IsValid;

	private static FFieldAddress GetTimeSpanFromSeconds_Seconds_PropertyAddress;

	private static int GetTimeSpanFromSeconds_Seconds_Offset;

	private static bool GetTimeSpanFromSeconds_ReturnValue_IsValid;

	private static FFieldAddress GetTimeSpanFromSeconds_ReturnValue_PropertyAddress;

	private static int GetTimeSpanFromSeconds_ReturnValue_Offset;

	private static bool GetShadowQualityLevel_IsValid;

	private static IntPtr GetShadowQualityLevel_FunctionAddress;

	private static int GetShadowQualityLevel_ParamsSize;

	private static bool GetShadowQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetShadowQualityLevel_ReturnValue_PropertyAddress;

	private static int GetShadowQualityLevel_ReturnValue_Offset;

	private static bool GetRemainingPsoPrecompileNum_IsValid;

	private static IntPtr GetRemainingPsoPrecompileNum_FunctionAddress;

	private static int GetRemainingPsoPrecompileNum_ParamsSize;

	private static bool GetRemainingPsoPrecompileNum_ReturnValue_IsValid;

	private static FFieldAddress GetRemainingPsoPrecompileNum_ReturnValue_PropertyAddress;

	private static int GetRemainingPsoPrecompileNum_ReturnValue_Offset;

	private static bool GetRegexMatchInfo_IsValid;

	private static IntPtr GetRegexMatchInfo_FunctionAddress;

	private static int GetRegexMatchInfo_ParamsSize;

	private static bool GetRegexMatchInfo_InStr_IsValid;

	private static FFieldAddress GetRegexMatchInfo_InStr_PropertyAddress;

	private static int GetRegexMatchInfo_InStr_Offset;

	private static bool GetRegexMatchInfo_RegexExpression_IsValid;

	private static FFieldAddress GetRegexMatchInfo_RegexExpression_PropertyAddress;

	private static int GetRegexMatchInfo_RegexExpression_Offset;

	private static bool GetRegexMatchInfo_ExtractedInfo_IsValid;

	private static FFieldAddress GetRegexMatchInfo_ExtractedInfo_PropertyAddress;

	private static int GetRegexMatchInfo_ExtractedInfo_Offset;

	private static bool GetRecommendedQualityLevel_IsValid;

	private static IntPtr GetRecommendedQualityLevel_FunctionAddress;

	private static int GetRecommendedQualityLevel_ParamsSize;

	private static bool GetRecommendedQualityLevel_bLogInfo_IsValid;

	private static FFieldAddress GetRecommendedQualityLevel_bLogInfo_PropertyAddress;

	private static int GetRecommendedQualityLevel_bLogInfo_Offset;

	private static bool GetRecommendedQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetRecommendedQualityLevel_ReturnValue_PropertyAddress;

	private static int GetRecommendedQualityLevel_ReturnValue_Offset;

	private static bool GetProjectSettingDefaultGameMode_IsValid;

	private static IntPtr GetProjectSettingDefaultGameMode_FunctionAddress;

	private static int GetProjectSettingDefaultGameMode_ParamsSize;

	private static bool GetProjectSettingDefaultGameMode_ReturnValue_IsValid;

	private static FFieldAddress GetProjectSettingDefaultGameMode_ReturnValue_PropertyAddress;

	private static int GetProjectSettingDefaultGameMode_ReturnValue_Offset;

	private static bool GetProjectDir_IsValid;

	private static IntPtr GetProjectDir_FunctionAddress;

	private static int GetProjectDir_ParamsSize;

	private static bool GetProjectDir_ReturnValue_IsValid;

	private static FFieldAddress GetProjectDir_ReturnValue_PropertyAddress;

	private static int GetProjectDir_ReturnValue_Offset;

	private static bool GetPlayerViewRectMatrixInfo_IsValid;

	private static IntPtr GetPlayerViewRectMatrixInfo_FunctionAddress;

	private static int GetPlayerViewRectMatrixInfo_ParamsSize;

	private static bool GetPlayerViewRectMatrixInfo_Player_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_Player_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_Player_Offset;

	private static bool GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_Offset;

	private static bool GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_Offset;

	private static bool GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_Offset;

	private static bool GetPlayerViewRectMatrixInfo_OutViewRectMin_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_OutViewRectMin_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_OutViewRectMin_Offset;

	private static bool GetPlayerViewRectMatrixInfo_OutViewRectMax_IsValid;

	private static FFieldAddress GetPlayerViewRectMatrixInfo_OutViewRectMax_PropertyAddress;

	private static int GetPlayerViewRectMatrixInfo_OutViewRectMax_Offset;

	private static bool GetPlayerViewRect_IsValid;

	private static IntPtr GetPlayerViewRect_FunctionAddress;

	private static int GetPlayerViewRect_ParamsSize;

	private static bool GetPlayerViewRect_Player_IsValid;

	private static FFieldAddress GetPlayerViewRect_Player_PropertyAddress;

	private static int GetPlayerViewRect_Player_Offset;

	private static bool GetPlayerViewRect_OutConstrainedViewRectMin_IsValid;

	private static FFieldAddress GetPlayerViewRect_OutConstrainedViewRectMin_PropertyAddress;

	private static int GetPlayerViewRect_OutConstrainedViewRectMin_Offset;

	private static bool GetPlayerViewRect_OutConstrainedViewRectMax_IsValid;

	private static FFieldAddress GetPlayerViewRect_OutConstrainedViewRectMax_PropertyAddress;

	private static int GetPlayerViewRect_OutConstrainedViewRectMax_Offset;

	private static bool GetPlayerViewRect_OutViewRectMin_IsValid;

	private static FFieldAddress GetPlayerViewRect_OutViewRectMin_PropertyAddress;

	private static int GetPlayerViewRect_OutViewRectMin_Offset;

	private static bool GetPlayerViewRect_OutViewRectMax_IsValid;

	private static FFieldAddress GetPlayerViewRect_OutViewRectMax_PropertyAddress;

	private static int GetPlayerViewRect_OutViewRectMax_Offset;

	private static bool GetPlayerViewProjectionMatrixInv_IsValid;

	private static IntPtr GetPlayerViewProjectionMatrixInv_FunctionAddress;

	private static int GetPlayerViewProjectionMatrixInv_ParamsSize;

	private static bool GetPlayerViewProjectionMatrixInv_Player_IsValid;

	private static FFieldAddress GetPlayerViewProjectionMatrixInv_Player_PropertyAddress;

	private static int GetPlayerViewProjectionMatrixInv_Player_Offset;

	private static bool GetPlayerViewProjectionMatrixInv_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerViewProjectionMatrixInv_ReturnValue_PropertyAddress;

	private static int GetPlayerViewProjectionMatrixInv_ReturnValue_Offset;

	private static bool GetPlayerViewProjectionMatrix_IsValid;

	private static IntPtr GetPlayerViewProjectionMatrix_FunctionAddress;

	private static int GetPlayerViewProjectionMatrix_ParamsSize;

	private static bool GetPlayerViewProjectionMatrix_Player_IsValid;

	private static FFieldAddress GetPlayerViewProjectionMatrix_Player_PropertyAddress;

	private static int GetPlayerViewProjectionMatrix_Player_Offset;

	private static bool GetPlayerViewProjectionMatrix_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerViewProjectionMatrix_ReturnValue_PropertyAddress;

	private static int GetPlayerViewProjectionMatrix_ReturnValue_Offset;

	private static bool GetPlatformTime_IsValid;

	private static IntPtr GetPlatformTime_FunctionAddress;

	private static int GetPlatformTime_ParamsSize;

	private static bool GetPlatformTime_ReturnValue_IsValid;

	private static FFieldAddress GetPlatformTime_ReturnValue_PropertyAddress;

	private static int GetPlatformTime_ReturnValue_Offset;

	private static bool GetPawnAutoPossessConfig_IsValid;

	private static IntPtr GetPawnAutoPossessConfig_FunctionAddress;

	private static int GetPawnAutoPossessConfig_ParamsSize;

	private static bool GetPawnAutoPossessConfig_PC_IsValid;

	private static FFieldAddress GetPawnAutoPossessConfig_PC_PropertyAddress;

	private static int GetPawnAutoPossessConfig_PC_Offset;

	private static bool GetPawnAutoPossessConfig_ReturnValue_IsValid;

	private static FFieldAddress GetPawnAutoPossessConfig_ReturnValue_PropertyAddress;

	private static int GetPawnAutoPossessConfig_ReturnValue_Offset;

	private static bool GetMediaPlayerTime_IsValid;

	private static IntPtr GetMediaPlayerTime_FunctionAddress;

	private static int GetMediaPlayerTime_ParamsSize;

	private static bool GetMediaPlayerTime_MediaPlayer_IsValid;

	private static FFieldAddress GetMediaPlayerTime_MediaPlayer_PropertyAddress;

	private static int GetMediaPlayerTime_MediaPlayer_Offset;

	private static bool GetMediaPlayerTime_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayerTime_ReturnValue_PropertyAddress;

	private static int GetMediaPlayerTime_ReturnValue_Offset;

	private static bool GetMediaPlayerDuartion_IsValid;

	private static IntPtr GetMediaPlayerDuartion_FunctionAddress;

	private static int GetMediaPlayerDuartion_ParamsSize;

	private static bool GetMediaPlayerDuartion_MediaPlayer_IsValid;

	private static FFieldAddress GetMediaPlayerDuartion_MediaPlayer_PropertyAddress;

	private static int GetMediaPlayerDuartion_MediaPlayer_Offset;

	private static bool GetMediaPlayerDuartion_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayerDuartion_ReturnValue_PropertyAddress;

	private static int GetMediaPlayerDuartion_ReturnValue_Offset;

	private static bool GetMacAddress_IsValid;

	private static IntPtr GetMacAddress_FunctionAddress;

	private static int GetMacAddress_ParamsSize;

	private static bool GetMacAddress_ReturnValue_IsValid;

	private static FFieldAddress GetMacAddress_ReturnValue_PropertyAddress;

	private static int GetMacAddress_ReturnValue_Offset;

	private static bool GetLoginId_IsValid;

	private static IntPtr GetLoginId_FunctionAddress;

	private static int GetLoginId_ParamsSize;

	private static bool GetLoginId_ReturnValue_IsValid;

	private static FFieldAddress GetLoginId_ReturnValue_PropertyAddress;

	private static int GetLoginId_ReturnValue_Offset;

	private static bool GetLocalPlayerCameraManager_IsValid;

	private static IntPtr GetLocalPlayerCameraManager_FunctionAddress;

	private static int GetLocalPlayerCameraManager_ParamsSize;

	private static bool GetLocalPlayerCameraManager_WorldCtx_IsValid;

	private static FFieldAddress GetLocalPlayerCameraManager_WorldCtx_PropertyAddress;

	private static int GetLocalPlayerCameraManager_WorldCtx_Offset;

	private static bool GetLocalPlayerCameraManager_ReturnValue_IsValid;

	private static FFieldAddress GetLocalPlayerCameraManager_ReturnValue_PropertyAddress;

	private static int GetLocalPlayerCameraManager_ReturnValue_Offset;

	private static bool GetLaunchValue_IsValid;

	private static IntPtr GetLaunchValue_FunctionAddress;

	private static int GetLaunchValue_ParamsSize;

	private static bool GetLaunchValue_Option_IsValid;

	private static FFieldAddress GetLaunchValue_Option_PropertyAddress;

	private static int GetLaunchValue_Option_Offset;

	private static bool GetLaunchValue_ReturnValue_IsValid;

	private static FFieldAddress GetLaunchValue_ReturnValue_PropertyAddress;

	private static int GetLaunchValue_ReturnValue_Offset;

	private static bool GetInputKey_IsValid;

	private static IntPtr GetInputKey_FunctionAddress;

	private static int GetInputKey_ParamsSize;

	private static bool GetInputKey_KeyEvent_IsValid;

	private static FFieldAddress GetInputKey_KeyEvent_PropertyAddress;

	private static int GetInputKey_KeyEvent_Offset;

	private static bool GetInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetInputKey_ReturnValue_PropertyAddress;

	private static int GetInputKey_ReturnValue_Offset;

	private static bool GetInputDeadZone_IsValid;

	private static IntPtr GetInputDeadZone_FunctionAddress;

	private static int GetInputDeadZone_ParamsSize;

	private static bool GetInputDeadZone_PlayerController_IsValid;

	private static FFieldAddress GetInputDeadZone_PlayerController_PropertyAddress;

	private static int GetInputDeadZone_PlayerController_Offset;

	private static bool GetInputDeadZone_AxisName_IsValid;

	private static FFieldAddress GetInputDeadZone_AxisName_PropertyAddress;

	private static int GetInputDeadZone_AxisName_Offset;

	private static bool GetInputDeadZone_ReturnValue_IsValid;

	private static FFieldAddress GetInputDeadZone_ReturnValue_PropertyAddress;

	private static int GetInputDeadZone_ReturnValue_Offset;

	private static bool GetGFrameCounter_IsValid;

	private static IntPtr GetGFrameCounter_FunctionAddress;

	private static int GetGFrameCounter_ParamsSize;

	private static bool GetGFrameCounter_ReturnValue_IsValid;

	private static FFieldAddress GetGFrameCounter_ReturnValue_PropertyAddress;

	private static int GetGFrameCounter_ReturnValue_Offset;

	private static bool GetFirstLocalPlayerController_IsValid;

	private static IntPtr GetFirstLocalPlayerController_FunctionAddress;

	private static int GetFirstLocalPlayerController_ParamsSize;

	private static bool GetFirstLocalPlayerController_WorldCtx_IsValid;

	private static FFieldAddress GetFirstLocalPlayerController_WorldCtx_PropertyAddress;

	private static int GetFirstLocalPlayerController_WorldCtx_Offset;

	private static bool GetFirstLocalPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetFirstLocalPlayerController_ReturnValue_PropertyAddress;

	private static int GetFirstLocalPlayerController_ReturnValue_Offset;

	private static bool GetEngineMinorVersion_IsValid;

	private static IntPtr GetEngineMinorVersion_FunctionAddress;

	private static int GetEngineMinorVersion_ParamsSize;

	private static bool GetEngineMinorVersion_ReturnValue_IsValid;

	private static FFieldAddress GetEngineMinorVersion_ReturnValue_PropertyAddress;

	private static int GetEngineMinorVersion_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_Object_IsValid;

	private static FFieldAddress GetDisplayName_Object_PropertyAddress;

	private static int GetDisplayName_Object_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	private static bool GetDisplayGamma_IsValid;

	private static IntPtr GetDisplayGamma_FunctionAddress;

	private static int GetDisplayGamma_ParamsSize;

	private static bool GetDisplayGamma_WorldCtx_IsValid;

	private static FFieldAddress GetDisplayGamma_WorldCtx_PropertyAddress;

	private static int GetDisplayGamma_WorldCtx_Offset;

	private static bool GetDisplayGamma_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayGamma_ReturnValue_PropertyAddress;

	private static int GetDisplayGamma_ReturnValue_Offset;

	private static bool GetDeviceInfo_IsValid;

	private static IntPtr GetDeviceInfo_FunctionAddress;

	private static int GetDeviceInfo_ParamsSize;

	private static bool GetDeviceInfo_Cpu_IsValid;

	private static FFieldAddress GetDeviceInfo_Cpu_PropertyAddress;

	private static int GetDeviceInfo_Cpu_Offset;

	private static bool GetDeviceInfo_Gpu_IsValid;

	private static FFieldAddress GetDeviceInfo_Gpu_PropertyAddress;

	private static int GetDeviceInfo_Gpu_Offset;

	private static bool GetDeviceInfo_MemSize_IsValid;

	private static FFieldAddress GetDeviceInfo_MemSize_PropertyAddress;

	private static int GetDeviceInfo_MemSize_Offset;

	private static bool GetDeviceId_IsValid;

	private static IntPtr GetDeviceId_FunctionAddress;

	private static int GetDeviceId_ParamsSize;

	private static bool GetDeviceId_ReturnValue_IsValid;

	private static FFieldAddress GetDeviceId_ReturnValue_PropertyAddress;

	private static int GetDeviceId_ReturnValue_Offset;

	private static bool GetDefaultLanguageCS_IsValid;

	private static IntPtr GetDefaultLanguageCS_FunctionAddress;

	private static int GetDefaultLanguageCS_ParamsSize;

	private static bool GetDefaultLanguageCS_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultLanguageCS_ReturnValue_PropertyAddress;

	private static int GetDefaultLanguageCS_ReturnValue_Offset;

	private static bool GetCurrentRhiName_IsValid;

	private static IntPtr GetCurrentRhiName_FunctionAddress;

	private static int GetCurrentRhiName_ParamsSize;

	private static bool GetCurrentRhiName_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentRhiName_ReturnValue_PropertyAddress;

	private static int GetCurrentRhiName_ReturnValue_Offset;

	private static bool GetChildActors_IsValid;

	private static IntPtr GetChildActors_FunctionAddress;

	private static int GetChildActors_ParamsSize;

	private static bool GetChildActors_Actor_IsValid;

	private static FFieldAddress GetChildActors_Actor_PropertyAddress;

	private static int GetChildActors_Actor_Offset;

	private static bool GetChildActors_ReturnValue_IsValid;

	private static FFieldAddress GetChildActors_ReturnValue_PropertyAddress;

	private static int GetChildActors_ReturnValue_Offset;

	private static bool GetBinkMediaPlayerTotalFrames_IsValid;

	private static IntPtr GetBinkMediaPlayerTotalFrames_FunctionAddress;

	private static int GetBinkMediaPlayerTotalFrames_ParamsSize;

	private static bool GetBinkMediaPlayerTotalFrames_MediaPlayer_IsValid;

	private static FFieldAddress GetBinkMediaPlayerTotalFrames_MediaPlayer_PropertyAddress;

	private static int GetBinkMediaPlayerTotalFrames_MediaPlayer_Offset;

	private static bool GetBinkMediaPlayerTotalFrames_ReturnValue_IsValid;

	private static FFieldAddress GetBinkMediaPlayerTotalFrames_ReturnValue_PropertyAddress;

	private static int GetBinkMediaPlayerTotalFrames_ReturnValue_Offset;

	private static bool GetBinkMediaPlayerTime_IsValid;

	private static IntPtr GetBinkMediaPlayerTime_FunctionAddress;

	private static int GetBinkMediaPlayerTime_ParamsSize;

	private static bool GetBinkMediaPlayerTime_MediaPlayer_IsValid;

	private static FFieldAddress GetBinkMediaPlayerTime_MediaPlayer_PropertyAddress;

	private static int GetBinkMediaPlayerTime_MediaPlayer_Offset;

	private static bool GetBinkMediaPlayerTime_ReturnValue_IsValid;

	private static FFieldAddress GetBinkMediaPlayerTime_ReturnValue_PropertyAddress;

	private static int GetBinkMediaPlayerTime_ReturnValue_Offset;

	private static bool GetBinkMediaPlayerFrameRate_IsValid;

	private static IntPtr GetBinkMediaPlayerFrameRate_FunctionAddress;

	private static int GetBinkMediaPlayerFrameRate_ParamsSize;

	private static bool GetBinkMediaPlayerFrameRate_MediaPlayer_IsValid;

	private static FFieldAddress GetBinkMediaPlayerFrameRate_MediaPlayer_PropertyAddress;

	private static int GetBinkMediaPlayerFrameRate_MediaPlayer_Offset;

	private static bool GetBinkMediaPlayerFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetBinkMediaPlayerFrameRate_ReturnValue_PropertyAddress;

	private static int GetBinkMediaPlayerFrameRate_ReturnValue_Offset;

	private static bool GetBinkMediaPlayerDuartion_IsValid;

	private static IntPtr GetBinkMediaPlayerDuartion_FunctionAddress;

	private static int GetBinkMediaPlayerDuartion_ParamsSize;

	private static bool GetBinkMediaPlayerDuartion_MediaPlayer_IsValid;

	private static FFieldAddress GetBinkMediaPlayerDuartion_MediaPlayer_PropertyAddress;

	private static int GetBinkMediaPlayerDuartion_MediaPlayer_Offset;

	private static bool GetBinkMediaPlayerDuartion_ReturnValue_IsValid;

	private static FFieldAddress GetBinkMediaPlayerDuartion_ReturnValue_PropertyAddress;

	private static int GetBinkMediaPlayerDuartion_ReturnValue_Offset;

	private static bool GetBinkMediaPlayerCurFrame_IsValid;

	private static IntPtr GetBinkMediaPlayerCurFrame_FunctionAddress;

	private static int GetBinkMediaPlayerCurFrame_ParamsSize;

	private static bool GetBinkMediaPlayerCurFrame_MediaPlayer_IsValid;

	private static FFieldAddress GetBinkMediaPlayerCurFrame_MediaPlayer_PropertyAddress;

	private static int GetBinkMediaPlayerCurFrame_MediaPlayer_Offset;

	private static bool GetBinkMediaPlayerCurFrame_ReturnValue_IsValid;

	private static FFieldAddress GetBinkMediaPlayerCurFrame_ReturnValue_PropertyAddress;

	private static int GetBinkMediaPlayerCurFrame_ReturnValue_Offset;

	private static bool GetAxisMappings_IsValid;

	private static IntPtr GetAxisMappings_FunctionAddress;

	private static int GetAxisMappings_ParamsSize;

	private static bool GetAxisMappings_PlayerController_IsValid;

	private static FFieldAddress GetAxisMappings_PlayerController_PropertyAddress;

	private static int GetAxisMappings_PlayerController_Offset;

	private static bool GetAxisMappings_ReturnValue_IsValid;

	private static FFieldAddress GetAxisMappings_ReturnValue_PropertyAddress;

	private static int GetAxisMappings_ReturnValue_Offset;

	private static bool GetAvailablePhysical_IsValid;

	private static IntPtr GetAvailablePhysical_FunctionAddress;

	private static int GetAvailablePhysical_ParamsSize;

	private static bool GetAvailablePhysical_ReturnValue_IsValid;

	private static FFieldAddress GetAvailablePhysical_ReturnValue_PropertyAddress;

	private static int GetAvailablePhysical_ReturnValue_Offset;

	private static bool GetAudioInfoOfAudioVisualize_IsValid;

	private static IntPtr GetAudioInfoOfAudioVisualize_FunctionAddress;

	private static int GetAudioInfoOfAudioVisualize_ParamsSize;

	private static bool GetAudioInfoOfAudioVisualize_AudioUtilActor_IsValid;

	private static FFieldAddress GetAudioInfoOfAudioVisualize_AudioUtilActor_PropertyAddress;

	private static int GetAudioInfoOfAudioVisualize_AudioUtilActor_Offset;

	private static bool GetAudioInfoOfAudioVisualize_AudioDuration_IsValid;

	private static FFieldAddress GetAudioInfoOfAudioVisualize_AudioDuration_PropertyAddress;

	private static int GetAudioInfoOfAudioVisualize_AudioDuration_Offset;

	private static bool GetAudioInfoOfAudioVisualize_ReturnValue_IsValid;

	private static FFieldAddress GetAudioInfoOfAudioVisualize_ReturnValue_PropertyAddress;

	private static int GetAudioInfoOfAudioVisualize_ReturnValue_Offset;

	private static bool GetAsyncLoadPercentage_IsValid;

	private static IntPtr GetAsyncLoadPercentage_FunctionAddress;

	private static int GetAsyncLoadPercentage_ParamsSize;

	private static bool GetAsyncLoadPercentage_PackageName_IsValid;

	private static FFieldAddress GetAsyncLoadPercentage_PackageName_PropertyAddress;

	private static int GetAsyncLoadPercentage_PackageName_Offset;

	private static bool GetAsyncLoadPercentage_ReturnValue_IsValid;

	private static FFieldAddress GetAsyncLoadPercentage_ReturnValue_PropertyAddress;

	private static int GetAsyncLoadPercentage_ReturnValue_Offset;

	private static bool GetAnalogValue_IsValid;

	private static IntPtr GetAnalogValue_FunctionAddress;

	private static int GetAnalogValue_ParamsSize;

	private static bool GetAnalogValue_AnalogInputEvent_IsValid;

	private static FFieldAddress GetAnalogValue_AnalogInputEvent_PropertyAddress;

	private static int GetAnalogValue_AnalogInputEvent_Offset;

	private static bool GetAnalogValue_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogValue_ReturnValue_PropertyAddress;

	private static int GetAnalogValue_ReturnValue_Offset;

	private static bool GetAnalogInputKey_IsValid;

	private static IntPtr GetAnalogInputKey_FunctionAddress;

	private static int GetAnalogInputKey_ParamsSize;

	private static bool GetAnalogInputKey_AnalogInputEvent_IsValid;

	private static FFieldAddress GetAnalogInputKey_AnalogInputEvent_PropertyAddress;

	private static int GetAnalogInputKey_AnalogInputEvent_Offset;

	private static bool GetAnalogInputKey_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogInputKey_ReturnValue_PropertyAddress;

	private static int GetAnalogInputKey_ReturnValue_Offset;

	private static bool GetActualQualityLevel_IsValid;

	private static IntPtr GetActualQualityLevel_FunctionAddress;

	private static int GetActualQualityLevel_ParamsSize;

	private static bool GetActualQualityLevel_bLogInfo_IsValid;

	private static FFieldAddress GetActualQualityLevel_bLogInfo_PropertyAddress;

	private static int GetActualQualityLevel_bLogInfo_Offset;

	private static bool GetActualQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetActualQualityLevel_ReturnValue_PropertyAddress;

	private static int GetActualQualityLevel_ReturnValue_Offset;

	private static bool GetActionMappings_IsValid;

	private static IntPtr GetActionMappings_FunctionAddress;

	private static int GetActionMappings_ParamsSize;

	private static bool GetActionMappings_PlayerController_IsValid;

	private static FFieldAddress GetActionMappings_PlayerController_PropertyAddress;

	private static int GetActionMappings_PlayerController_Offset;

	private static bool GetActionMappings_ReturnValue_IsValid;

	private static FFieldAddress GetActionMappings_ReturnValue_PropertyAddress;

	private static int GetActionMappings_ReturnValue_Offset;

	private static bool GameInstanceIsDedicatedServer_IsValid;

	private static IntPtr GameInstanceIsDedicatedServer_FunctionAddress;

	private static int GameInstanceIsDedicatedServer_ParamsSize;

	private static bool GameInstanceIsDedicatedServer_GameInst_IsValid;

	private static FFieldAddress GameInstanceIsDedicatedServer_GameInst_PropertyAddress;

	private static int GameInstanceIsDedicatedServer_GameInst_Offset;

	private static bool GameInstanceIsDedicatedServer_ReturnValue_IsValid;

	private static FFieldAddress GameInstanceIsDedicatedServer_ReturnValue_PropertyAddress;

	private static int GameInstanceIsDedicatedServer_ReturnValue_Offset;

	private static bool FlushMainAudioDevice_IsValid;

	private static IntPtr FlushMainAudioDevice_FunctionAddress;

	private static int FlushMainAudioDevice_ParamsSize;

	private static bool FlushMainAudioDevice_DeviceID_IsValid;

	private static FFieldAddress FlushMainAudioDevice_DeviceID_PropertyAddress;

	private static int FlushMainAudioDevice_DeviceID_Offset;

	private static bool FindPathSync_IsValid;

	private static IntPtr FindPathSync_FunctionAddress;

	private static int FindPathSync_ParamsSize;

	private static bool FindPathSync_Controller_IsValid;

	private static FFieldAddress FindPathSync_Controller_PropertyAddress;

	private static int FindPathSync_Controller_Offset;

	private static bool FindPathSync_TargetLocation_IsValid;

	private static FFieldAddress FindPathSync_TargetLocation_PropertyAddress;

	private static int FindPathSync_TargetLocation_Offset;

	private static bool FindPathSync_ReturnValue_IsValid;

	private static FFieldAddress FindPathSync_ReturnValue_PropertyAddress;

	private static int FindPathSync_ReturnValue_Offset;

	private static bool FindNamedNetDriver_IsValid;

	private static IntPtr FindNamedNetDriver_FunctionAddress;

	private static int FindNamedNetDriver_ParamsSize;

	private static bool FindNamedNetDriver_InWorld_IsValid;

	private static FFieldAddress FindNamedNetDriver_InWorld_PropertyAddress;

	private static int FindNamedNetDriver_InWorld_Offset;

	private static bool FindNamedNetDriver_NetDriverName_IsValid;

	private static FFieldAddress FindNamedNetDriver_NetDriverName_PropertyAddress;

	private static int FindNamedNetDriver_NetDriverName_Offset;

	private static bool FindNamedNetDriver_ReturnValue_IsValid;

	private static FFieldAddress FindNamedNetDriver_ReturnValue_PropertyAddress;

	private static int FindNamedNetDriver_ReturnValue_Offset;

	private static bool FindAndPrintStaleRefsByObjectPath_IsValid;

	private static IntPtr FindAndPrintStaleRefsByObjectPath_FunctionAddress;

	private static int FindAndPrintStaleRefsByObjectPath_ParamsSize;

	private static bool FindAndPrintStaleRefsByObjectPath_InObjectPath_IsValid;

	private static FFieldAddress FindAndPrintStaleRefsByObjectPath_InObjectPath_PropertyAddress;

	private static int FindAndPrintStaleRefsByObjectPath_InObjectPath_Offset;

	private static bool FindAndPrintStaleRefsByObjectPath_ReturnValue_IsValid;

	private static FFieldAddress FindAndPrintStaleRefsByObjectPath_ReturnValue_PropertyAddress;

	private static int FindAndPrintStaleRefsByObjectPath_ReturnValue_Offset;

	private static bool FindAndPrintStaleReferencesToObject_IsValid;

	private static IntPtr FindAndPrintStaleReferencesToObject_FunctionAddress;

	private static int FindAndPrintStaleReferencesToObject_ParamsSize;

	private static bool FindAndPrintStaleReferencesToObject_Obj_IsValid;

	private static FFieldAddress FindAndPrintStaleReferencesToObject_Obj_PropertyAddress;

	private static int FindAndPrintStaleReferencesToObject_Obj_Offset;

	private static bool FindAndPrintStaleReferencesToObject_ReturnValue_IsValid;

	private static FFieldAddress FindAndPrintStaleReferencesToObject_ReturnValue_PropertyAddress;

	private static int FindAndPrintStaleReferencesToObject_ReturnValue_Offset;

	private static bool ExecCmdOutGLog_IsValid;

	private static IntPtr ExecCmdOutGLog_FunctionAddress;

	private static int ExecCmdOutGLog_ParamsSize;

	private static bool ExecCmdOutGLog_Cmd_IsValid;

	private static FFieldAddress ExecCmdOutGLog_Cmd_PropertyAddress;

	private static int ExecCmdOutGLog_Cmd_Offset;

	private static bool ExecCmdOutGLog_WorldCtx_IsValid;

	private static FFieldAddress ExecCmdOutGLog_WorldCtx_PropertyAddress;

	private static int ExecCmdOutGLog_WorldCtx_Offset;

	private static bool EngineGC_IsValid;

	private static IntPtr EngineGC_FunctionAddress;

	private static int EngineGC_ParamsSize;

	private static bool EngineGC_bFullPurge_IsValid;

	private static FFieldAddress EngineGC_bFullPurge_PropertyAddress;

	private static int EngineGC_bFullPurge_Offset;

	private static bool EnableForceStreamdOutLevelGCCheck_IsValid;

	private static IntPtr EnableForceStreamdOutLevelGCCheck_FunctionAddress;

	private static int EnableForceStreamdOutLevelGCCheck_ParamsSize;

	private static bool EnableForceStreamdOutLevelGCCheck_Enable_IsValid;

	private static FFieldAddress EnableForceStreamdOutLevelGCCheck_Enable_PropertyAddress;

	private static int EnableForceStreamdOutLevelGCCheck_Enable_Offset;

	private static bool EnableForceStreamdOutLevelGCCheck_IgnoreEditor_IsValid;

	private static FFieldAddress EnableForceStreamdOutLevelGCCheck_IgnoreEditor_PropertyAddress;

	private static int EnableForceStreamdOutLevelGCCheck_IgnoreEditor_Offset;

	private static bool DuplicateAsset_IsValid;

	private static IntPtr DuplicateAsset_FunctionAddress;

	private static int DuplicateAsset_ParamsSize;

	private static bool DuplicateAsset_AssetName_IsValid;

	private static FFieldAddress DuplicateAsset_AssetName_PropertyAddress;

	private static int DuplicateAsset_AssetName_Offset;

	private static bool DuplicateAsset_PackagePath_IsValid;

	private static FFieldAddress DuplicateAsset_PackagePath_PropertyAddress;

	private static int DuplicateAsset_PackagePath_Offset;

	private static bool DuplicateAsset_OriginalObject_IsValid;

	private static FFieldAddress DuplicateAsset_OriginalObject_PropertyAddress;

	private static int DuplicateAsset_OriginalObject_Offset;

	private static bool DuplicateAsset_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAsset_ReturnValue_PropertyAddress;

	private static int DuplicateAsset_ReturnValue_Offset;

	private static bool DrawDebugCircleArc_IsValid;

	private static IntPtr DrawDebugCircleArc_FunctionAddress;

	private static int DrawDebugCircleArc_ParamsSize;

	private static bool DrawDebugCircleArc_WorldContextObject_IsValid;

	private static FFieldAddress DrawDebugCircleArc_WorldContextObject_PropertyAddress;

	private static int DrawDebugCircleArc_WorldContextObject_Offset;

	private static bool DrawDebugCircleArc_Center_IsValid;

	private static FFieldAddress DrawDebugCircleArc_Center_PropertyAddress;

	private static int DrawDebugCircleArc_Center_Offset;

	private static bool DrawDebugCircleArc_Radius_IsValid;

	private static FFieldAddress DrawDebugCircleArc_Radius_PropertyAddress;

	private static int DrawDebugCircleArc_Radius_Offset;

	private static bool DrawDebugCircleArc_Direction_IsValid;

	private static FFieldAddress DrawDebugCircleArc_Direction_PropertyAddress;

	private static int DrawDebugCircleArc_Direction_Offset;

	private static bool DrawDebugCircleArc_AngleWidth_IsValid;

	private static FFieldAddress DrawDebugCircleArc_AngleWidth_PropertyAddress;

	private static int DrawDebugCircleArc_AngleWidth_Offset;

	private static bool DrawDebugCircleArc_NumSegments_IsValid;

	private static FFieldAddress DrawDebugCircleArc_NumSegments_PropertyAddress;

	private static int DrawDebugCircleArc_NumSegments_Offset;

	private static bool DrawDebugCircleArc_LineColor_IsValid;

	private static FFieldAddress DrawDebugCircleArc_LineColor_PropertyAddress;

	private static int DrawDebugCircleArc_LineColor_Offset;

	private static bool DrawDebugCircleArc_Duration_IsValid;

	private static FFieldAddress DrawDebugCircleArc_Duration_PropertyAddress;

	private static int DrawDebugCircleArc_Duration_Offset;

	private static bool DrawDebugCircleArc_Thickness_IsValid;

	private static FFieldAddress DrawDebugCircleArc_Thickness_PropertyAddress;

	private static int DrawDebugCircleArc_Thickness_Offset;

	private static bool DisableDebugExecBindings_IsValid;

	private static IntPtr DisableDebugExecBindings_FunctionAddress;

	private static int DisableDebugExecBindings_ParamsSize;

	private static bool DisableDebugExecBindings_WorldCtx_IsValid;

	private static FFieldAddress DisableDebugExecBindings_WorldCtx_PropertyAddress;

	private static int DisableDebugExecBindings_WorldCtx_Offset;

	private static bool DisableDebugExecBindings_IsDisable_IsValid;

	private static FFieldAddress DisableDebugExecBindings_IsDisable_PropertyAddress;

	private static int DisableDebugExecBindings_IsDisable_Offset;

	private static bool DetectDragIfPressed_IsValid;

	private static IntPtr DetectDragIfPressed_FunctionAddress;

	private static int DetectDragIfPressed_ParamsSize;

	private static bool DetectDragIfPressed_PointerEvent_IsValid;

	private static FFieldAddress DetectDragIfPressed_PointerEvent_PropertyAddress;

	private static int DetectDragIfPressed_PointerEvent_Offset;

	private static bool DetectDragIfPressed_WidgetDetectingDrag_IsValid;

	private static FFieldAddress DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress;

	private static int DetectDragIfPressed_WidgetDetectingDrag_Offset;

	private static bool DetectDragIfPressed_KeyName_IsValid;

	private static FFieldAddress DetectDragIfPressed_KeyName_PropertyAddress;

	private static int DetectDragIfPressed_KeyName_Offset;

	private static bool DetectDragIfPressed_ReturnValue_IsValid;

	private static FFieldAddress DetectDragIfPressed_ReturnValue_PropertyAddress;

	private static int DetectDragIfPressed_ReturnValue_Offset;

	private static bool DestroyActorsWithSpecifiedKeyword_IsValid;

	private static IntPtr DestroyActorsWithSpecifiedKeyword_FunctionAddress;

	private static int DestroyActorsWithSpecifiedKeyword_ParamsSize;

	private static bool DestroyActorsWithSpecifiedKeyword_InWorldContext_IsValid;

	private static FFieldAddress DestroyActorsWithSpecifiedKeyword_InWorldContext_PropertyAddress;

	private static int DestroyActorsWithSpecifiedKeyword_InWorldContext_Offset;

	private static bool DestroyActorsWithSpecifiedKeyword_InKeyword_IsValid;

	private static FFieldAddress DestroyActorsWithSpecifiedKeyword_InKeyword_PropertyAddress;

	private static int DestroyActorsWithSpecifiedKeyword_InKeyword_Offset;

	private static bool DestroyActor_IsValid;

	private static IntPtr DestroyActor_FunctionAddress;

	private static int DestroyActor_ParamsSize;

	private static bool DestroyActor_Actor_IsValid;

	private static FFieldAddress DestroyActor_Actor_PropertyAddress;

	private static int DestroyActor_Actor_Offset;

	private static bool DelayGC_IsValid;

	private static IntPtr DelayGC_FunctionAddress;

	private static int DelayGC_ParamsSize;

	private static bool CreateReplicationDriver_IsValid;

	private static IntPtr CreateReplicationDriver_FunctionAddress;

	private static int CreateReplicationDriver_ParamsSize;

	private static bool CreateReplicationDriver_NetDriver_IsValid;

	private static FFieldAddress CreateReplicationDriver_NetDriver_PropertyAddress;

	private static int CreateReplicationDriver_NetDriver_Offset;

	private static bool CreateReplicationDriver_World_IsValid;

	private static FFieldAddress CreateReplicationDriver_World_PropertyAddress;

	private static int CreateReplicationDriver_World_Offset;

	private static bool CreateReplicationDriver_ReturnValue_IsValid;

	private static FFieldAddress CreateReplicationDriver_ReturnValue_PropertyAddress;

	private static int CreateReplicationDriver_ReturnValue_Offset;

	private static bool CreateNamedNetDriver_IsValid;

	private static IntPtr CreateNamedNetDriver_FunctionAddress;

	private static int CreateNamedNetDriver_ParamsSize;

	private static bool CreateNamedNetDriver_InWorld_IsValid;

	private static FFieldAddress CreateNamedNetDriver_InWorld_PropertyAddress;

	private static int CreateNamedNetDriver_InWorld_Offset;

	private static bool CreateNamedNetDriver_NetDriverName_IsValid;

	private static FFieldAddress CreateNamedNetDriver_NetDriverName_PropertyAddress;

	private static int CreateNamedNetDriver_NetDriverName_Offset;

	private static bool CreateNamedNetDriver_NetDriverDefinition_IsValid;

	private static FFieldAddress CreateNamedNetDriver_NetDriverDefinition_PropertyAddress;

	private static int CreateNamedNetDriver_NetDriverDefinition_Offset;

	private static bool CreateDragDropOperation_IsValid;

	private static IntPtr CreateDragDropOperation_FunctionAddress;

	private static int CreateDragDropOperation_ParamsSize;

	private static bool CreateDragDropOperation_OperationClass_IsValid;

	private static FFieldAddress CreateDragDropOperation_OperationClass_PropertyAddress;

	private static int CreateDragDropOperation_OperationClass_Offset;

	private static bool CreateDragDropOperation_ReturnValue_IsValid;

	private static FFieldAddress CreateDragDropOperation_ReturnValue_PropertyAddress;

	private static int CreateDragDropOperation_ReturnValue_Offset;

	private static bool CreateAsset_IsValid;

	private static IntPtr CreateAsset_FunctionAddress;

	private static int CreateAsset_ParamsSize;

	private static bool CreateAsset_Path_IsValid;

	private static FFieldAddress CreateAsset_Path_PropertyAddress;

	private static int CreateAsset_Path_Offset;

	private static bool CreateAsset_Name_IsValid;

	private static FFieldAddress CreateAsset_Name_PropertyAddress;

	private static int CreateAsset_Name_Offset;

	private static bool CreateAsset_CreatedClass_IsValid;

	private static FFieldAddress CreateAsset_CreatedClass_PropertyAddress;

	private static int CreateAsset_CreatedClass_Offset;

	private static bool CreateAsset_ReturnValue_IsValid;

	private static FFieldAddress CreateAsset_ReturnValue_PropertyAddress;

	private static int CreateAsset_ReturnValue_Offset;

	private static bool CopyToClipBoard_IsValid;

	private static IntPtr CopyToClipBoard_FunctionAddress;

	private static int CopyToClipBoard_ParamsSize;

	private static bool CopyToClipBoard_InStr_IsValid;

	private static FFieldAddress CopyToClipBoard_InStr_PropertyAddress;

	private static int CopyToClipBoard_InStr_Offset;

	private static bool ConsoleVariableSetMouseCursor_IsValid;

	private static IntPtr ConsoleVariableSetMouseCursor_FunctionAddress;

	private static int ConsoleVariableSetMouseCursor_ParamsSize;

	private static bool ConsoleVariableSetMouseCursor_MouseCursor_IsValid;

	private static FFieldAddress ConsoleVariableSetMouseCursor_MouseCursor_PropertyAddress;

	private static int ConsoleVariableSetMouseCursor_MouseCursor_Offset;

	private static bool ConsoleVarGetInt_IsValid;

	private static IntPtr ConsoleVarGetInt_FunctionAddress;

	private static int ConsoleVarGetInt_ParamsSize;

	private static bool ConsoleVarGetInt_Name_IsValid;

	private static FFieldAddress ConsoleVarGetInt_Name_PropertyAddress;

	private static int ConsoleVarGetInt_Name_Offset;

	private static bool ConsoleVarGetInt_ReturnValue_IsValid;

	private static FFieldAddress ConsoleVarGetInt_ReturnValue_PropertyAddress;

	private static int ConsoleVarGetInt_ReturnValue_Offset;

	private static bool CloseNetConnection_IsValid;

	private static IntPtr CloseNetConnection_FunctionAddress;

	private static int CloseNetConnection_ParamsSize;

	private static bool CloseNetConnection_WorldContext_IsValid;

	private static FFieldAddress CloseNetConnection_WorldContext_PropertyAddress;

	private static int CloseNetConnection_WorldContext_Offset;

	private static bool ClientSeamlessTravel_IsValid;

	private static IntPtr ClientSeamlessTravel_FunctionAddress;

	private static int ClientSeamlessTravel_ParamsSize;

	private static bool ClientSeamlessTravel_PC_IsValid;

	private static FFieldAddress ClientSeamlessTravel_PC_PropertyAddress;

	private static int ClientSeamlessTravel_PC_Offset;

	private static bool ClientSeamlessTravel_Url_IsValid;

	private static FFieldAddress ClientSeamlessTravel_Url_PropertyAddress;

	private static int ClientSeamlessTravel_Url_Offset;

	private static bool CaptureCurrentViewport_IsValid;

	private static IntPtr CaptureCurrentViewport_FunctionAddress;

	private static int CaptureCurrentViewport_ParamsSize;

	private static bool CaptureCurrentViewport_bCapture_IsValid;

	private static FFieldAddress CaptureCurrentViewport_bCapture_PropertyAddress;

	private static int CaptureCurrentViewport_bCapture_Offset;

	private static bool BlockTillSuspendedLevelsCompleted_IsValid;

	private static IntPtr BlockTillSuspendedLevelsCompleted_FunctionAddress;

	private static int BlockTillSuspendedLevelsCompleted_ParamsSize;

	private static bool BlockTillSuspendedLevelsCompleted_WorldContextObject_IsValid;

	private static FFieldAddress BlockTillSuspendedLevelsCompleted_WorldContextObject_PropertyAddress;

	private static int BlockTillSuspendedLevelsCompleted_WorldContextObject_Offset;

	private static bool BlockTillLevelStreamingCompleted_IsValid;

	private static IntPtr BlockTillLevelStreamingCompleted_FunctionAddress;

	private static int BlockTillLevelStreamingCompleted_ParamsSize;

	private static bool BlockTillLevelStreamingCompleted_WorldContextObject_IsValid;

	private static FFieldAddress BlockTillLevelStreamingCompleted_WorldContextObject_PropertyAddress;

	private static int BlockTillLevelStreamingCompleted_WorldContextObject_Offset;

	private static bool BinkMediaPlayerTimeSeek_IsValid;

	private static IntPtr BinkMediaPlayerTimeSeek_FunctionAddress;

	private static int BinkMediaPlayerTimeSeek_ParamsSize;

	private static bool BinkMediaPlayerTimeSeek_MediaPlayer_IsValid;

	private static FFieldAddress BinkMediaPlayerTimeSeek_MediaPlayer_PropertyAddress;

	private static int BinkMediaPlayerTimeSeek_MediaPlayer_Offset;

	private static bool BinkMediaPlayerTimeSeek_Time_IsValid;

	private static FFieldAddress BinkMediaPlayerTimeSeek_Time_PropertyAddress;

	private static int BinkMediaPlayerTimeSeek_Time_Offset;

	private static bool BinkMediaPlayerGoToWithProcMs_IsValid;

	private static IntPtr BinkMediaPlayerGoToWithProcMs_FunctionAddress;

	private static int BinkMediaPlayerGoToWithProcMs_ParamsSize;

	private static bool BinkMediaPlayerGoToWithProcMs_MediaPlayer_IsValid;

	private static FFieldAddress BinkMediaPlayerGoToWithProcMs_MediaPlayer_PropertyAddress;

	private static int BinkMediaPlayerGoToWithProcMs_MediaPlayer_Offset;

	private static bool BinkMediaPlayerGoToWithProcMs_TargetFrame_IsValid;

	private static FFieldAddress BinkMediaPlayerGoToWithProcMs_TargetFrame_PropertyAddress;

	private static int BinkMediaPlayerGoToWithProcMs_TargetFrame_Offset;

	private static bool BinkMediaPlayerGoToWithProcMs_ProcMS_IsValid;

	private static FFieldAddress BinkMediaPlayerGoToWithProcMs_ProcMS_PropertyAddress;

	private static int BinkMediaPlayerGoToWithProcMs_ProcMS_Offset;

	private static bool BinkMediaPlayerGoToWithProcMs_ReturnValue_IsValid;

	private static FFieldAddress BinkMediaPlayerGoToWithProcMs_ReturnValue_PropertyAddress;

	private static int BinkMediaPlayerGoToWithProcMs_ReturnValue_Offset;

	private static bool BinkMediaPlayerGoTo_IsValid;

	private static IntPtr BinkMediaPlayerGoTo_FunctionAddress;

	private static int BinkMediaPlayerGoTo_ParamsSize;

	private static bool BinkMediaPlayerGoTo_MediaPlayer_IsValid;

	private static FFieldAddress BinkMediaPlayerGoTo_MediaPlayer_PropertyAddress;

	private static int BinkMediaPlayerGoTo_MediaPlayer_Offset;

	private static bool BinkMediaPlayerGoTo_TargetFrame_IsValid;

	private static FFieldAddress BinkMediaPlayerGoTo_TargetFrame_PropertyAddress;

	private static int BinkMediaPlayerGoTo_TargetFrame_Offset;

	private static bool BinkMediaPlayerGoTo_ReturnValue_IsValid;

	private static FFieldAddress BinkMediaPlayerGoTo_ReturnValue_PropertyAddress;

	private static int BinkMediaPlayerGoTo_ReturnValue_Offset;

	private static bool BindAudioUtilAndBox_IsValid;

	private static IntPtr BindAudioUtilAndBox_FunctionAddress;

	private static int BindAudioUtilAndBox_ParamsSize;

	private static bool BindAudioUtilAndBox_AudioUtilActor_IsValid;

	private static FFieldAddress BindAudioUtilAndBox_AudioUtilActor_PropertyAddress;

	private static int BindAudioUtilAndBox_AudioUtilActor_Offset;

	private static bool BindAudioUtilAndBox_AudioBox_IsValid;

	private static FFieldAddress BindAudioUtilAndBox_AudioBox_PropertyAddress;

	private static int BindAudioUtilAndBox_AudioBox_Offset;

	private static bool BindAudioUtilAndBox_ReturnValue_IsValid;

	private static FFieldAddress BindAudioUtilAndBox_ReturnValue_PropertyAddress;

	private static int BindAudioUtilAndBox_ReturnValue_Offset;

	private static bool AsyncDownloadImage_IsValid;

	private static IntPtr AsyncDownloadImage_FunctionAddress;

	private static int AsyncDownloadImage_ParamsSize;

	private static bool AsyncDownloadImage_Url_IsValid;

	private static FFieldAddress AsyncDownloadImage_Url_PropertyAddress;

	private static int AsyncDownloadImage_Url_Offset;

	private static bool AsyncDownloadImage_ReturnValue_IsValid;

	private static FFieldAddress AsyncDownloadImage_ReturnValue_PropertyAddress;

	private static int AsyncDownloadImage_ReturnValue_Offset;

	private static bool AdjustPSOPrecompileBatch_IsValid;

	private static IntPtr AdjustPSOPrecompileBatch_FunctionAddress;

	private static int AdjustPSOPrecompileBatch_ParamsSize;

	private static bool AdjustPSOPrecompileBatch_BatchSize_IsValid;

	private static FFieldAddress AdjustPSOPrecompileBatch_BatchSize_PropertyAddress;

	private static int AdjustPSOPrecompileBatch_BatchSize_Offset;

	private static bool AdjustPSOPrecompileBatch_BatchTime_IsValid;

	private static FFieldAddress AdjustPSOPrecompileBatch_BatchTime_PropertyAddress;

	private static int AdjustPSOPrecompileBatch_BatchTime_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:WasActorRecentlyRendered")]
	public unsafe static bool WasActorRecentlyRendered(AActor InActor, float InTolerence = 0.2f)
	{
		if (!WasActorRecentlyRendered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:WasActorRecentlyRendered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasActorRecentlyRendered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasActorRecentlyRendered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, WasActorRecentlyRendered_InActor_Offset), 0, WasActorRecentlyRendered_InActor_PropertyAddress.Address, InActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, WasActorRecentlyRendered_InTolerence_Offset), 0, WasActorRecentlyRendered_InTolerence_PropertyAddress.Address, InTolerence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WasActorRecentlyRendered_FunctionAddress, intPtr, WasActorRecentlyRendered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasActorRecentlyRendered_ReturnValue_Offset), 0, WasActorRecentlyRendered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWLevel")]
	public unsafe static void VLogWLevel(UObject WorldContext, int InLogLevel, FName Catogary, string Text)
	{
		if (!VLogWLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogWLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogWLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogWLevel_WorldContext_Offset), 0, VLogWLevel_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, VLogWLevel_InLogLevel_Offset), 0, VLogWLevel_InLogLevel_PropertyAddress.Address, InLogLevel);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogWLevel_Catogary_Offset), 0, VLogWLevel_Catogary_PropertyAddress.Address, Catogary);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogWLevel_Text_Offset), 0, VLogWLevel_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogWLevel_FunctionAddress, intPtr, VLogWLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogWLevel_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWarning")]
	public unsafe static void VLogWarning(UObject WorldContext, FName Catogary, string Text)
	{
		if (!VLogWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogWarning_WorldContext_Offset), 0, VLogWarning_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogWarning_Catogary_Offset), 0, VLogWarning_Catogary_PropertyAddress.Address, Catogary);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogWarning_Text_Offset), 0, VLogWarning_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogWarning_FunctionAddress, intPtr, VLogWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogWarning_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentWarning")]
	public unsafe static void VLogSegmentWarning(UObject WorldContext, FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness, string Text)
	{
		if (!VLogSegmentWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogSegmentWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogSegmentWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_WorldContext_Offset), 0, VLogSegmentWarning_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_Catogary_Offset), 0, VLogSegmentWarning_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_SegmentStart_Offset), 0, VLogSegmentWarning_SegmentStart_PropertyAddress.Address, SegmentStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_SegmentEnd_Offset), 0, VLogSegmentWarning_SegmentEnd_PropertyAddress.Address, SegmentEnd);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_Color_Offset), 0, VLogSegmentWarning_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_Thickness_Offset), 0, VLogSegmentWarning_Thickness_PropertyAddress.Address, Thickness);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogSegmentWarning_Text_Offset), 0, VLogSegmentWarning_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogSegmentWarning_FunctionAddress, intPtr, VLogSegmentWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogSegmentWarning_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentInfo")]
	public unsafe static void VLogSegmentInfo(UObject WorldContext, FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness, string Text)
	{
		if (!VLogSegmentInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogSegmentInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogSegmentInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_WorldContext_Offset), 0, VLogSegmentInfo_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_Catogary_Offset), 0, VLogSegmentInfo_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_SegmentStart_Offset), 0, VLogSegmentInfo_SegmentStart_PropertyAddress.Address, SegmentStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_SegmentEnd_Offset), 0, VLogSegmentInfo_SegmentEnd_PropertyAddress.Address, SegmentEnd);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_Color_Offset), 0, VLogSegmentInfo_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_Thickness_Offset), 0, VLogSegmentInfo_Thickness_PropertyAddress.Address, Thickness);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogSegmentInfo_Text_Offset), 0, VLogSegmentInfo_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogSegmentInfo_FunctionAddress, intPtr, VLogSegmentInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogSegmentInfo_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentError")]
	public unsafe static void VLogSegmentError(UObject WorldContext, FName Catogary, FVector SegmentStart, FVector SegmentEnd, FColor Color, float Thickness, string Text)
	{
		if (!VLogSegmentError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogSegmentError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogSegmentError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_WorldContext_Offset), 0, VLogSegmentError_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_Catogary_Offset), 0, VLogSegmentError_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_SegmentStart_Offset), 0, VLogSegmentError_SegmentStart_PropertyAddress.Address, SegmentStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_SegmentEnd_Offset), 0, VLogSegmentError_SegmentEnd_PropertyAddress.Address, SegmentEnd);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_Color_Offset), 0, VLogSegmentError_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogSegmentError_Thickness_Offset), 0, VLogSegmentError_Thickness_PropertyAddress.Address, Thickness);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogSegmentError_Text_Offset), 0, VLogSegmentError_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogSegmentError_FunctionAddress, intPtr, VLogSegmentError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogSegmentError_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationWarning")]
	public unsafe static void VLogLocationWarning(UObject WorldContext, FName Catogary, FVector Location, float Radius, FColor Color, string Text)
	{
		if (!VLogLocationWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogLocationWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogLocationWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_WorldContext_Offset), 0, VLogLocationWarning_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_Catogary_Offset), 0, VLogLocationWarning_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_Location_Offset), 0, VLogLocationWarning_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_Radius_Offset), 0, VLogLocationWarning_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_Color_Offset), 0, VLogLocationWarning_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogLocationWarning_Text_Offset), 0, VLogLocationWarning_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogLocationWarning_FunctionAddress, intPtr, VLogLocationWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogLocationWarning_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationInfo")]
	public unsafe static void VLogLocationInfo(UObject WorldContext, FName Catogary, FVector Location, float Radius, FColor Color, string Text)
	{
		if (!VLogLocationInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogLocationInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogLocationInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_WorldContext_Offset), 0, VLogLocationInfo_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_Catogary_Offset), 0, VLogLocationInfo_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_Location_Offset), 0, VLogLocationInfo_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_Radius_Offset), 0, VLogLocationInfo_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_Color_Offset), 0, VLogLocationInfo_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogLocationInfo_Text_Offset), 0, VLogLocationInfo_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogLocationInfo_FunctionAddress, intPtr, VLogLocationInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogLocationInfo_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationError")]
	public unsafe static void VLogLocationError(UObject WorldContext, FName Catogary, FVector Location, float Radius, FColor Color, string Text)
	{
		if (!VLogLocationError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogLocationError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogLocationError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogLocationError_WorldContext_Offset), 0, VLogLocationError_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogLocationError_Catogary_Offset), 0, VLogLocationError_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VLogLocationError_Location_Offset), 0, VLogLocationError_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VLogLocationError_Radius_Offset), 0, VLogLocationError_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogLocationError_Color_Offset), 0, VLogLocationError_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogLocationError_Text_Offset), 0, VLogLocationError_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogLocationError_FunctionAddress, intPtr, VLogLocationError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogLocationError_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogInfo")]
	public unsafe static void VLogInfo(UObject WorldContext, FName Catogary, string Text)
	{
		if (!VLogInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogInfo_WorldContext_Offset), 0, VLogInfo_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogInfo_Catogary_Offset), 0, VLogInfo_Catogary_PropertyAddress.Address, Catogary);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogInfo_Text_Offset), 0, VLogInfo_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogInfo_FunctionAddress, intPtr, VLogInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogInfo_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogError")]
	public unsafe static void VLogError(UObject WorldContext, FName Catogary, string Text)
	{
		if (!VLogError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogError_WorldContext_Offset), 0, VLogError_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogError_Catogary_Offset), 0, VLogError_Catogary_PropertyAddress.Address, Catogary);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogError_Text_Offset), 0, VLogError_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogError_FunctionAddress, intPtr, VLogError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogError_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxWarning")]
	public unsafe static void VLogBoxWarning(UObject WorldContext, FName Catogary, FBox Box, FColor Color, string Text)
	{
		if (!VLogBoxWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogBoxWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogBoxWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogBoxWarning_WorldContext_Offset), 0, VLogBoxWarning_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogBoxWarning_Catogary_Offset), 0, VLogBoxWarning_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, VLogBoxWarning_Box_Offset), 0, VLogBoxWarning_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogBoxWarning_Color_Offset), 0, VLogBoxWarning_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogBoxWarning_Text_Offset), 0, VLogBoxWarning_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogBoxWarning_FunctionAddress, intPtr, VLogBoxWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogBoxWarning_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxInfo")]
	public unsafe static void VLogBoxInfo(UObject WorldContext, FName Catogary, FBox Box, FColor Color, string Text)
	{
		if (!VLogBoxInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogBoxInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogBoxInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogBoxInfo_WorldContext_Offset), 0, VLogBoxInfo_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogBoxInfo_Catogary_Offset), 0, VLogBoxInfo_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, VLogBoxInfo_Box_Offset), 0, VLogBoxInfo_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogBoxInfo_Color_Offset), 0, VLogBoxInfo_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogBoxInfo_Text_Offset), 0, VLogBoxInfo_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogBoxInfo_FunctionAddress, intPtr, VLogBoxInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogBoxInfo_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxError")]
	public unsafe static void VLogBoxError(UObject WorldContext, FName Catogary, FBox Box, FColor Color, string Text)
	{
		if (!VLogBoxError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VLogBoxError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VLogBoxError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, VLogBoxError_WorldContext_Offset), 0, VLogBoxError_WorldContext_PropertyAddress.Address, WorldContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, VLogBoxError_Catogary_Offset), 0, VLogBoxError_Catogary_PropertyAddress.Address, Catogary);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, VLogBoxError_Box_Offset), 0, VLogBoxError_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VLogBoxError_Color_Offset), 0, VLogBoxError_Color_PropertyAddress.Address, Color);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, VLogBoxError_Text_Offset), 0, VLogBoxError_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VLogBoxError_FunctionAddress, intPtr, VLogBoxError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VLogBoxError_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:UseStatsMacro")]
	public unsafe static bool UseStatsMacro()
	{
		if (!UseStatsMacro_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:UseStatsMacro");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UseStatsMacro_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UseStatsMacro_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UseStatsMacro_FunctionAddress, intPtr, UseStatsMacro_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UseStatsMacro_ReturnValue_Offset), 0, UseStatsMacro_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:UploadPSOHttpRequest")]
	public unsafe static void UploadPSOHttpRequest(int Num)
	{
		if (!UploadPSOHttpRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:UploadPSOHttpRequest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UploadPSOHttpRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UploadPSOHttpRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UploadPSOHttpRequest_Num_Offset), 0, UploadPSOHttpRequest_Num_PropertyAddress.Address, Num);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UploadPSOHttpRequest_FunctionAddress, intPtr, UploadPSOHttpRequest_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:UpdateAudioUtilAnalyzer")]
	public unsafe static void UpdateAudioUtilAnalyzer(AActor AudioUtilActor, string LoudnessAnalyzerAssetPath, string ConstantAnalyzerAssetPath)
	{
		if (!UpdateAudioUtilAnalyzer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:UpdateAudioUtilAnalyzer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAudioUtilAnalyzer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAudioUtilAnalyzer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UpdateAudioUtilAnalyzer_AudioUtilActor_Offset), 0, UpdateAudioUtilAnalyzer_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_Offset), 0, UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_PropertyAddress.Address, LoudnessAnalyzerAssetPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_Offset), 0, UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_PropertyAddress.Address, ConstantAnalyzerAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateAudioUtilAnalyzer_FunctionAddress, intPtr, UpdateAudioUtilAnalyzer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ToMilliseconds")]
	public unsafe static float ToMilliseconds(long Cycles)
	{
		if (!ToMilliseconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ToMilliseconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToMilliseconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToMilliseconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, ToMilliseconds_Cycles_Offset), 0, ToMilliseconds_Cycles_PropertyAddress.Address, Cycles);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToMilliseconds_FunctionAddress, intPtr, ToMilliseconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, ToMilliseconds_ReturnValue_Offset), 0, ToMilliseconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:TestPathSync")]
	public unsafe static bool TestPathSync(AController Controller, FVector TargetLocation)
	{
		if (!TestPathSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:TestPathSync");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestPathSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestPathSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, TestPathSync_Controller_Offset), 0, TestPathSync_Controller_PropertyAddress.Address, Controller);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TestPathSync_TargetLocation_Offset), 0, TestPathSync_TargetLocation_PropertyAddress.Address, TargetLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TestPathSync_FunctionAddress, intPtr, TestPathSync_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TestPathSync_ReturnValue_Offset), 0, TestPathSync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:StopAudio")]
	public unsafe static void StopAudio(AActor AudioUtilActor)
	{
		if (!StopAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:StopAudio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAudio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, StopAudio_AudioUtilActor_Offset), 0, StopAudio_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopAudio_FunctionAddress, intPtr, StopAudio_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetPSOCacheUsageMask")]
	public unsafe static void SetPSOCacheUsageMask(int MapIndex, int MaterialQualityLevel, int NiagaraQualityLevel, int ShadowQualityLevel)
	{
		if (!SetPSOCacheUsageMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetPSOCacheUsageMask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPSOCacheUsageMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPSOCacheUsageMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPSOCacheUsageMask_MapIndex_Offset), 0, SetPSOCacheUsageMask_MapIndex_PropertyAddress.Address, MapIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPSOCacheUsageMask_MaterialQualityLevel_Offset), 0, SetPSOCacheUsageMask_MaterialQualityLevel_PropertyAddress.Address, MaterialQualityLevel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPSOCacheUsageMask_NiagaraQualityLevel_Offset), 0, SetPSOCacheUsageMask_NiagaraQualityLevel_PropertyAddress.Address, NiagaraQualityLevel);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPSOCacheUsageMask_ShadowQualityLevel_Offset), 0, SetPSOCacheUsageMask_ShadowQualityLevel_PropertyAddress.Address, ShadowQualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPSOCacheUsageMask_FunctionAddress, intPtr, SetPSOCacheUsageMask_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetMouseCursorWidgetVisible")]
	public unsafe static void SetMouseCursorWidgetVisible(APlayerController PlayerController, bool bVisible)
	{
		if (!SetMouseCursorWidgetVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetMouseCursorWidgetVisible");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMouseCursorWidgetVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMouseCursorWidgetVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetMouseCursorWidgetVisible_PlayerController_Offset), 0, SetMouseCursorWidgetVisible_PlayerController_PropertyAddress.Address, PlayerController);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMouseCursorWidgetVisible_bVisible_Offset), 0, SetMouseCursorWidgetVisible_bVisible_PropertyAddress.Address, bVisible);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMouseCursorWidgetVisible_FunctionAddress, intPtr, SetMouseCursorWidgetVisible_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetLogEnable")]
	public unsafe static void SetLogEnable(bool bEnableDbg, bool bEnableDbgDisplay, bool bEnableInfo)
	{
		if (!SetLogEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetLogEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLogEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLogEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLogEnable_bEnableDbg_Offset), 0, SetLogEnable_bEnableDbg_PropertyAddress.Address, bEnableDbg);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLogEnable_bEnableDbgDisplay_Offset), 0, SetLogEnable_bEnableDbgDisplay_PropertyAddress.Address, bEnableDbgDisplay);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLogEnable_bEnableInfo_Offset), 0, SetLogEnable_bEnableInfo_PropertyAddress.Address, bEnableInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLogEnable_FunctionAddress, intPtr, SetLogEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetLevelRequestSuspend")]
	public unsafe static void SetLevelRequestSuspend(bool ShouldSuspend)
	{
		if (!SetLevelRequestSuspend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetLevelRequestSuspend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelRequestSuspend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelRequestSuspend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelRequestSuspend_ShouldSuspend_Offset), 0, SetLevelRequestSuspend_ShouldSuspend_PropertyAddress.Address, ShouldSuspend);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLevelRequestSuspend_FunctionAddress, intPtr, SetLevelRequestSuspend_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeUIOnly")]
	public unsafe static void SetInputModeUIOnly(APlayerController Target, UWidget InWidgetToFocus, EMouseLockMode InMouseLockMode = EMouseLockMode.DoNotLock)
	{
		if (!SetInputModeUIOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeUIOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputModeUIOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputModeUIOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputModeUIOnly_Target_Offset), 0, SetInputModeUIOnly_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetInputModeUIOnly_InWidgetToFocus_Offset), 0, SetInputModeUIOnly_InWidgetToFocus_PropertyAddress.Address, InWidgetToFocus);
		EnumMarshaler<EMouseLockMode>.ToNative(IntPtr.Add(intPtr, SetInputModeUIOnly_InMouseLockMode_Offset), 0, SetInputModeUIOnly_InMouseLockMode_PropertyAddress.Address, InMouseLockMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputModeUIOnly_FunctionAddress, intPtr, SetInputModeUIOnly_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeGameOnly")]
	public unsafe static void SetInputModeGameOnly(APlayerController PlayerController)
	{
		if (!SetInputModeGameOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeGameOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputModeGameOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputModeGameOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputModeGameOnly_PlayerController_Offset), 0, SetInputModeGameOnly_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputModeGameOnly_FunctionAddress, intPtr, SetInputModeGameOnly_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputDeadZone")]
	public unsafe static void SetInputDeadZone(APlayerController PlayerController, FName AxisName, float DeadZone)
	{
		if (!SetInputDeadZone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputDeadZone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputDeadZone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputDeadZone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputDeadZone_PlayerController_Offset), 0, SetInputDeadZone_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetInputDeadZone_AxisName_Offset), 0, SetInputDeadZone_AxisName_PropertyAddress.Address, AxisName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInputDeadZone_DeadZone_Offset), 0, SetInputDeadZone_DeadZone_PropertyAddress.Address, DeadZone);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputDeadZone_FunctionAddress, intPtr, SetInputDeadZone_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetDisplayGamma")]
	public unsafe static void SetDisplayGamma(UObject WorldCtx, float Gamma)
	{
		if (!SetDisplayGamma_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetDisplayGamma");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayGamma_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayGamma_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetDisplayGamma_WorldCtx_Offset), 0, SetDisplayGamma_WorldCtx_PropertyAddress.Address, WorldCtx);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDisplayGamma_Gamma_Offset), 0, SetDisplayGamma_Gamma_PropertyAddress.Address, Gamma);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDisplayGamma_FunctionAddress, intPtr, SetDisplayGamma_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetDesiredQualityLevel")]
	public unsafe static void SetDesiredQualityLevel(EGSQualityLevel TargetGSQualityLevel)
	{
		if (!SetDesiredQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetDesiredQualityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSQualityLevel>.ToNative(IntPtr.Add(intPtr, SetDesiredQualityLevel_TargetGSQualityLevel_Offset), 0, SetDesiredQualityLevel_TargetGSQualityLevel_PropertyAddress.Address, TargetGSQualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDesiredQualityLevel_FunctionAddress, intPtr, SetDesiredQualityLevel_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetCanEverTick")]
	public unsafe static bool SetCanEverTick(UObject Obj, bool bEnable)
	{
		if (!SetCanEverTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetCanEverTick");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCanEverTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCanEverTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetCanEverTick_Obj_Offset), 0, SetCanEverTick_Obj_PropertyAddress.Address, Obj);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanEverTick_bEnable_Offset), 0, SetCanEverTick_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCanEverTick_FunctionAddress, intPtr, SetCanEverTick_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCanEverTick_ReturnValue_Offset), 0, SetCanEverTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetAudioBoxFreqNum")]
	public unsafe static void SetAudioBoxFreqNum(UUserWidget AudioBox, int InFreqNum)
	{
		if (!SetAudioBoxFreqNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetAudioBoxFreqNum");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioBoxFreqNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioBoxFreqNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetAudioBoxFreqNum_AudioBox_Offset), 0, SetAudioBoxFreqNum_AudioBox_PropertyAddress.Address, AudioBox);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAudioBoxFreqNum_InFreqNum_Offset), 0, SetAudioBoxFreqNum_InFreqNum_PropertyAddress.Address, InFreqNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAudioBoxFreqNum_FunctionAddress, intPtr, SetAudioBoxFreqNum_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SetActorComponentMobilityMovable")]
	public unsafe static void SetActorComponentMobilityMovable(AActor Actor, bool IsMovable)
	{
		if (!SetActorComponentMobilityMovable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SetActorComponentMobilityMovable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorComponentMobilityMovable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorComponentMobilityMovable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorComponentMobilityMovable_Actor_Offset), 0, SetActorComponentMobilityMovable_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorComponentMobilityMovable_IsMovable_Offset), 0, SetActorComponentMobilityMovable_IsMovable_PropertyAddress.Address, IsMovable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorComponentMobilityMovable_FunctionAddress, intPtr, SetActorComponentMobilityMovable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ServerSeamlessTravel")]
	public unsafe static void ServerSeamlessTravel(UWorld World, string Url)
	{
		if (!ServerSeamlessTravel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ServerSeamlessTravel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ServerSeamlessTravel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ServerSeamlessTravel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ServerSeamlessTravel_World_Offset), 0, ServerSeamlessTravel_World_PropertyAddress.Address, World);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ServerSeamlessTravel_Url_Offset), 0, ServerSeamlessTravel_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ServerSeamlessTravel_FunctionAddress, intPtr, ServerSeamlessTravel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ServerSeamlessTravel_Url_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SaveStringToFile")]
	public unsafe static void SaveStringToFile(string Path, string Data)
	{
		if (!SaveStringToFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SaveStringToFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveStringToFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveStringToFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveStringToFile_Path_Offset), 0, SaveStringToFile_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveStringToFile_Data_Offset), 0, SaveStringToFile_Data_PropertyAddress.Address, Data);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveStringToFile_FunctionAddress, intPtr, SaveStringToFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveStringToFile_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveStringToFile_Data_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:SavePSOCacheFile")]
	public unsafe static void SavePSOCacheFile()
	{
		if (!SavePSOCacheFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:SavePSOCacheFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SavePSOCacheFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SavePSOCacheFile_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: SavePSOCacheFile_FunctionAddress, argsSize: SavePSOCacheFile_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcessWithCheck")]
	public unsafe static void RunProcessWithCheck(string InProcessPath)
	{
		if (!RunProcessWithCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcessWithCheck");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunProcessWithCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunProcessWithCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunProcessWithCheck_InProcessPath_Offset), 0, RunProcessWithCheck_InProcessPath_PropertyAddress.Address, InProcessPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunProcessWithCheck_FunctionAddress, intPtr, RunProcessWithCheck_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunProcessWithCheck_InProcessPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcess")]
	public unsafe static void RunProcess(string InProcessPath)
	{
		if (!RunProcess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunProcess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunProcess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunProcess_InProcessPath_Offset), 0, RunProcess_InProcessPath_PropertyAddress.Address, InProcessPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunProcess_FunctionAddress, intPtr, RunProcess_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunProcess_InProcessPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ResumePsoBatching")]
	public unsafe static void ResumePsoBatching()
	{
		if (!ResumePsoBatching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ResumePsoBatching");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumePsoBatching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumePsoBatching_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ResumePsoBatching_FunctionAddress, argsSize: ResumePsoBatching_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RestartGame")]
	public unsafe static void RestartGame(AGameMode GameMode)
	{
		if (!RestartGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RestartGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AGameMode>.ToNative(IntPtr.Add(intPtr, RestartGame_GameMode_Offset), 0, RestartGame_GameMode_PropertyAddress.Address, GameMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RestartGame_FunctionAddress, intPtr, RestartGame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RestartApplication")]
	public unsafe static void RestartApplication()
	{
		if (!RestartApplication_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RestartApplication");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestartApplication_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestartApplication_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RestartApplication_FunctionAddress, argsSize: RestartApplication_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ResetAudioVisualizing")]
	public unsafe static void ResetAudioVisualizing(UUserWidget AudioBox)
	{
		if (!ResetAudioVisualizing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ResetAudioVisualizing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetAudioVisualizing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetAudioVisualizing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, ResetAudioVisualizing_AudioBox_Offset), 0, ResetAudioVisualizing_AudioBox_PropertyAddress.Address, AudioBox);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetAudioVisualizing_FunctionAddress, intPtr, ResetAudioVisualizing_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RequestQuit")]
	public unsafe static void RequestQuit(string Desc)
	{
		if (!RequestQuit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RequestQuit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestQuit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestQuit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestQuit_Desc_Offset), 0, RequestQuit_Desc_PropertyAddress.Address, Desc);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestQuit_FunctionAddress, intPtr, RequestQuit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestQuit_Desc_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RequestExit")]
	public unsafe static void RequestExit(bool Force)
	{
		if (!RequestExit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RequestExit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestExit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestExit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestExit_Force_Offset), 0, RequestExit_Force_PropertyAddress.Address, Force);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestExit_FunctionAddress, intPtr, RequestExit_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputAxisList")]
	public unsafe static void ReplaceInputAxisList(APlayerController PlayerController, List<FGSInputAxisKeyMapping> AxisMappings)
	{
		if (!ReplaceInputAxisList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputAxisList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceInputAxisList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceInputAxisList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReplaceInputAxisList_PlayerController_Offset), 0, ReplaceInputAxisList_PlayerController_PropertyAddress.Address, PlayerController);
		new TArrayCopyMarshaler<FGSInputAxisKeyMapping>(1, ReplaceInputAxisList_AxisMappings_PropertyAddress, CachedMarshalingDelegates<FGSInputAxisKeyMapping, FGSInputAxisKeyMapping>.FromNative, CachedMarshalingDelegates<FGSInputAxisKeyMapping, FGSInputAxisKeyMapping>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceInputAxisList_AxisMappings_Offset), AxisMappings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceInputAxisList_FunctionAddress, intPtr, ReplaceInputAxisList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceInputAxisList_AxisMappings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputActionList")]
	public unsafe static void ReplaceInputActionList(APlayerController PlayerController, List<FGSInputActionKeyMapping> ActionMappings)
	{
		if (!ReplaceInputActionList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputActionList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceInputActionList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceInputActionList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ReplaceInputActionList_PlayerController_Offset), 0, ReplaceInputActionList_PlayerController_PropertyAddress.Address, PlayerController);
		new TArrayCopyMarshaler<FGSInputActionKeyMapping>(1, ReplaceInputActionList_ActionMappings_PropertyAddress, CachedMarshalingDelegates<FGSInputActionKeyMapping, FGSInputActionKeyMapping>.FromNative, CachedMarshalingDelegates<FGSInputActionKeyMapping, FGSInputActionKeyMapping>.ToNative).ToNative(IntPtr.Add(intPtr, ReplaceInputActionList_ActionMappings_Offset), ActionMappings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceInputActionList_FunctionAddress, intPtr, ReplaceInputActionList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceInputActionList_ActionMappings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RegisterComponent")]
	public unsafe static void RegisterComponent(UActorComponent ActorComponent)
	{
		if (!RegisterComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RegisterComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RegisterComponent_ActorComponent_Offset), 0, RegisterComponent_ActorComponent_PropertyAddress.Address, ActorComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterComponent_FunctionAddress, intPtr, RegisterComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:RegisteConsoleKey")]
	public unsafe static void RegisteConsoleKey(List<FName> Keys)
	{
		if (!RegisteConsoleKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:RegisteConsoleKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisteConsoleKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisteConsoleKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, RegisteConsoleKey_Keys_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, RegisteConsoleKey_Keys_Offset), Keys);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisteConsoleKey_FunctionAddress, intPtr, RegisteConsoleKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisteConsoleKey_Keys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QuitGame")]
	public unsafe static void QuitGame(UObject WorldCtx)
	{
		if (!QuitGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QuitGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QuitGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QuitGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, QuitGame_WorldCtx_Offset), 0, QuitGame_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QuitGame_FunctionAddress, intPtr, QuitGame_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QuitEditor")]
	public unsafe static void QuitEditor()
	{
		if (!QuitEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QuitEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QuitEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QuitEditor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: QuitEditor_FunctionAddress, argsSize: QuitEditor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QAIsCompiling")]
	public unsafe static bool QAIsCompiling()
	{
		if (!QAIsCompiling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QAIsCompiling");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAIsCompiling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAIsCompiling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAIsCompiling_FunctionAddress, intPtr, QAIsCompiling_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QAIsCompiling_ReturnValue_Offset), 0, QAIsCompiling_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QAHasReached")]
	public unsafe static bool QAHasReached(AActor AgentActor, AActor GoalActor)
	{
		if (!QAHasReached_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QAHasReached");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAHasReached_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAHasReached_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, QAHasReached_AgentActor_Offset), 0, QAHasReached_AgentActor_PropertyAddress.Address, AgentActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, QAHasReached_GoalActor_Offset), 0, QAHasReached_GoalActor_PropertyAddress.Address, GoalActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAHasReached_FunctionAddress, intPtr, QAHasReached_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QAHasReached_ReturnValue_Offset), 0, QAHasReached_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QAGetSimpleCollisionCylinder")]
	public unsafe static void QAGetSimpleCollisionCylinder(AActor AgentActor, out float CollisionRadius, out float CollisionHalfHeight)
	{
		if (!QAGetSimpleCollisionCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QAGetSimpleCollisionCylinder");
			CollisionRadius = 0f;
			CollisionHalfHeight = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAGetSimpleCollisionCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAGetSimpleCollisionCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, QAGetSimpleCollisionCylinder_AgentActor_Offset), 0, QAGetSimpleCollisionCylinder_AgentActor_PropertyAddress.Address, AgentActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAGetSimpleCollisionCylinder_FunctionAddress, intPtr, QAGetSimpleCollisionCylinder_ParamsSize);
		CollisionRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, QAGetSimpleCollisionCylinder_CollisionRadius_Offset), 0, QAGetSimpleCollisionCylinder_CollisionRadius_PropertyAddress.Address);
		CollisionHalfHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, QAGetSimpleCollisionCylinder_CollisionHalfHeight_Offset), 0, QAGetSimpleCollisionCylinder_CollisionHalfHeight_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:QAGenCrash")]
	public unsafe static void QAGenCrash()
	{
		if (!QAGenCrash_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:QAGenCrash");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAGenCrash_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAGenCrash_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: QAGenCrash_FunctionAddress, argsSize: QAGenCrash_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PSOFullCompilation")]
	public unsafe static void PSOFullCompilation()
	{
		if (!PSOFullCompilation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PSOFullCompilation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PSOFullCompilation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PSOFullCompilation_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PSOFullCompilation_FunctionAddress, argsSize: PSOFullCompilation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PrepareLevelsNeedToBeUnloaded")]
	public unsafe static void PrepareLevelsNeedToBeUnloaded(UObject WorldContextObject)
	{
		if (!PrepareLevelsNeedToBeUnloaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PrepareLevelsNeedToBeUnloaded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrepareLevelsNeedToBeUnloaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrepareLevelsNeedToBeUnloaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PrepareLevelsNeedToBeUnloaded_WorldContextObject_Offset), 0, PrepareLevelsNeedToBeUnloaded_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrepareLevelsNeedToBeUnloaded_FunctionAddress, intPtr, PrepareLevelsNeedToBeUnloaded_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PlayAudio")]
	public unsafe static void PlayAudio(AActor AudioUtilActor, bool VisualOnly = false)
	{
		if (!PlayAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PlayAudio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAudio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PlayAudio_AudioUtilActor_Offset), 0, PlayAudio_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAudio_VisualOnly_Offset), 0, PlayAudio_VisualOnly_PropertyAddress.Address, VisualOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PlayAudio_FunctionAddress, intPtr, PlayAudio_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PerfTest")]
	public unsafe static void PerfTest(int CaseID, int Count)
	{
		if (!PerfTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PerfTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerfTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerfTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PerfTest_CaseID_Offset), 0, PerfTest_CaseID_PropertyAddress.Address, CaseID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PerfTest_Count_Offset), 0, PerfTest_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PerfTest_FunctionAddress, intPtr, PerfTest_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PausePsoBatching")]
	public unsafe static void PausePsoBatching()
	{
		if (!PausePsoBatching_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PausePsoBatching");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PausePsoBatching_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PausePsoBatching_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PausePsoBatching_FunctionAddress, argsSize: PausePsoBatching_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:PauseAudio")]
	public unsafe static void PauseAudio(AActor AudioUtilActor)
	{
		if (!PauseAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:PauseAudio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseAudio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PauseAudio_AudioUtilActor_Offset), 0, PauseAudio_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PauseAudio_FunctionAddress, intPtr, PauseAudio_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MultipleColorLerp")]
	public unsafe static FLinearColor MultipleColorLerp(FLinearColor V1, FLinearColor V2, FLinearColor V3, FLinearColor V4, float LerpAlpha)
	{
		if (!MultipleColorLerp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MultipleColorLerp");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MultipleColorLerp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MultipleColorLerp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MultipleColorLerp_V1_Offset), 0, MultipleColorLerp_V1_PropertyAddress.Address, V1);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MultipleColorLerp_V2_Offset), 0, MultipleColorLerp_V2_PropertyAddress.Address, V2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MultipleColorLerp_V3_Offset), 0, MultipleColorLerp_V3_PropertyAddress.Address, V3);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MultipleColorLerp_V4_Offset), 0, MultipleColorLerp_V4_PropertyAddress.Address, V4);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MultipleColorLerp_LerpAlpha_Offset), 0, MultipleColorLerp_LerpAlpha_PropertyAddress.Address, LerpAlpha);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MultipleColorLerp_FunctionAddress, intPtr, MultipleColorLerp_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, MultipleColorLerp_ReturnValue_Offset), 0, MultipleColorLerp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MediaPlayerTimeSeek")]
	public unsafe static void MediaPlayerTimeSeek(UMediaPlayer MediaPlayer, double Time)
	{
		if (!MediaPlayerTimeSeek_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MediaPlayerTimeSeek");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MediaPlayerTimeSeek_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MediaPlayerTimeSeek_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, MediaPlayerTimeSeek_MediaPlayer_Offset), 0, MediaPlayerTimeSeek_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, MediaPlayerTimeSeek_Time_Offset), 0, MediaPlayerTimeSeek_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MediaPlayerTimeSeek_FunctionAddress, intPtr, MediaPlayerTimeSeek_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseV")]
	public unsafe static FVector MathEaseV(FVector A, FVector B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
	{
		if (!MathEaseV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseV");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MathEaseV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MathEaseV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MathEaseV_A_Offset), 0, MathEaseV_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MathEaseV_B_Offset), 0, MathEaseV_B_PropertyAddress.Address, B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseV_Alpha_Offset), 0, MathEaseV_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, MathEaseV_EasingFunc_Offset), 0, MathEaseV_EasingFunc_PropertyAddress.Address, EasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseV_BlendExp_Offset), 0, MathEaseV_BlendExp_PropertyAddress.Address, BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MathEaseV_Steps_Offset), 0, MathEaseV_Steps_PropertyAddress.Address, Steps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MathEaseV_FunctionAddress, intPtr, MathEaseV_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, MathEaseV_ReturnValue_Offset), 0, MathEaseV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseR")]
	public unsafe static FRotator MathEaseR(FRotator A, FRotator B, float Alpha, bool bShortestPath, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
	{
		if (!MathEaseR_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseR");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MathEaseR_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MathEaseR_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, MathEaseR_A_Offset), 0, MathEaseR_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, MathEaseR_B_Offset), 0, MathEaseR_B_PropertyAddress.Address, B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseR_Alpha_Offset), 0, MathEaseR_Alpha_PropertyAddress.Address, Alpha);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MathEaseR_bShortestPath_Offset), 0, MathEaseR_bShortestPath_PropertyAddress.Address, bShortestPath);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, MathEaseR_EasingFunc_Offset), 0, MathEaseR_EasingFunc_PropertyAddress.Address, EasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseR_BlendExp_Offset), 0, MathEaseR_BlendExp_PropertyAddress.Address, BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MathEaseR_Steps_Offset), 0, MathEaseR_Steps_PropertyAddress.Address, Steps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MathEaseR_FunctionAddress, intPtr, MathEaseR_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, MathEaseR_ReturnValue_Offset), 0, MathEaseR_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseLinearColor")]
	public unsafe static FLinearColor MathEaseLinearColor(FLinearColor A, FLinearColor B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
	{
		if (!MathEaseLinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseLinearColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MathEaseLinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MathEaseLinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_A_Offset), 0, MathEaseLinearColor_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_B_Offset), 0, MathEaseLinearColor_B_PropertyAddress.Address, B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_Alpha_Offset), 0, MathEaseLinearColor_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_EasingFunc_Offset), 0, MathEaseLinearColor_EasingFunc_PropertyAddress.Address, EasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_BlendExp_Offset), 0, MathEaseLinearColor_BlendExp_PropertyAddress.Address, BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MathEaseLinearColor_Steps_Offset), 0, MathEaseLinearColor_Steps_PropertyAddress.Address, Steps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MathEaseLinearColor_FunctionAddress, intPtr, MathEaseLinearColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, MathEaseLinearColor_ReturnValue_Offset), 0, MathEaseLinearColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase2D")]
	public unsafe static FVector2D MathEase2D(FVector2D A, FVector2D B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
	{
		if (!MathEase2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase2D");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MathEase2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MathEase2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MathEase2D_A_Offset), 0, MathEase2D_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MathEase2D_B_Offset), 0, MathEase2D_B_PropertyAddress.Address, B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase2D_Alpha_Offset), 0, MathEase2D_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, MathEase2D_EasingFunc_Offset), 0, MathEase2D_EasingFunc_PropertyAddress.Address, EasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase2D_BlendExp_Offset), 0, MathEase2D_BlendExp_PropertyAddress.Address, BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MathEase2D_Steps_Offset), 0, MathEase2D_Steps_PropertyAddress.Address, Steps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MathEase2D_FunctionAddress, intPtr, MathEase2D_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, MathEase2D_ReturnValue_Offset), 0, MathEase2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase")]
	public unsafe static float MathEase(float A, float B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
	{
		if (!MathEase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MathEase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MathEase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase_A_Offset), 0, MathEase_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase_B_Offset), 0, MathEase_B_PropertyAddress.Address, B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase_Alpha_Offset), 0, MathEase_Alpha_PropertyAddress.Address, Alpha);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(intPtr, MathEase_EasingFunc_Offset), 0, MathEase_EasingFunc_PropertyAddress.Address, EasingFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MathEase_BlendExp_Offset), 0, MathEase_BlendExp_PropertyAddress.Address, BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MathEase_Steps_Offset), 0, MathEase_Steps_PropertyAddress.Address, Steps);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MathEase_FunctionAddress, intPtr, MathEase_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, MathEase_ReturnValue_Offset), 0, MathEase_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:MarkUnloadPsoState")]
	public unsafe static void MarkUnloadPsoState()
	{
		if (!MarkUnloadPsoState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:MarkUnloadPsoState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkUnloadPsoState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkUnloadPsoState_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: MarkUnloadPsoState_FunctionAddress, argsSize: MarkUnloadPsoState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogWLevel")]
	public unsafe static void LogWLevel(string Str, int InLogLevel)
	{
		if (!LogWLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogWLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogWLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogWLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogWLevel_Str_Offset), 0, LogWLevel_Str_PropertyAddress.Address, Str);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LogWLevel_InLogLevel_Offset), 0, LogWLevel_InLogLevel_PropertyAddress.Address, InLogLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogWLevel_FunctionAddress, intPtr, LogWLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogWLevel_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogWarning")]
	public unsafe static void LogWarning(string Str)
	{
		if (!LogWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogWarning_Str_Offset), 0, LogWarning_Str_PropertyAddress.Address, Str);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogWarning_FunctionAddress, intPtr, LogWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogWarning_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogShippingError")]
	public unsafe static void LogShippingError(string Str)
	{
		if (!LogShippingError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogShippingError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogShippingError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogShippingError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogShippingError_Str_Offset), 0, LogShippingError_Str_PropertyAddress.Address, Str);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogShippingError_FunctionAddress, intPtr, LogShippingError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogShippingError_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogShipping")]
	public unsafe static void LogShipping(string Str)
	{
		if (!LogShipping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogShipping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogShipping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogShipping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogShipping_Str_Offset), 0, LogShipping_Str_PropertyAddress.Address, Str);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogShipping_FunctionAddress, intPtr, LogShipping_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogShipping_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogInfo")]
	public unsafe static void LogInfo(string Str)
	{
		if (!LogInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogInfo_Str_Offset), 0, LogInfo_Str_PropertyAddress.Address, Str);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogInfo_FunctionAddress, intPtr, LogInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogInfo_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogError")]
	public unsafe static void LogError(string Str)
	{
		if (!LogError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogError_Str_Offset), 0, LogError_Str_PropertyAddress.Address, Str);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogError_FunctionAddress, intPtr, LogError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogError_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbgWithColor")]
	public unsafe static void LogDbgWithColor(string Str, bool bPrintScreen, float TimeToDisplay, FColor Color, int key)
	{
		if (!LogDbgWithColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbgWithColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogDbgWithColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogDbgWithColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogDbgWithColor_Str_Offset), 0, LogDbgWithColor_Str_PropertyAddress.Address, Str);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogDbgWithColor_bPrintScreen_Offset), 0, LogDbgWithColor_bPrintScreen_PropertyAddress.Address, bPrintScreen);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LogDbgWithColor_TimeToDisplay_Offset), 0, LogDbgWithColor_TimeToDisplay_PropertyAddress.Address, TimeToDisplay);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, LogDbgWithColor_Color_Offset), 0, LogDbgWithColor_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, LogDbgWithColor_key_Offset), 0, LogDbgWithColor_key_PropertyAddress.Address, key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogDbgWithColor_FunctionAddress, intPtr, LogDbgWithColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogDbgWithColor_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbg")]
	public unsafe static void LogDbg(string Str, bool bPrintScreen, float TimeToDisplay = 2f)
	{
		if (!LogDbg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogDbg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogDbg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogDbg_Str_Offset), 0, LogDbg_Str_PropertyAddress.Address, Str);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LogDbg_bPrintScreen_Offset), 0, LogDbg_bPrintScreen_PropertyAddress.Address, bPrintScreen);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LogDbg_TimeToDisplay_Offset), 0, LogDbg_TimeToDisplay_PropertyAddress.Address, TimeToDisplay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LogDbg_FunctionAddress, intPtr, LogDbg_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogDbg_Str_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:LoadFileToString")]
	public unsafe static string LoadFileToString(string Path)
	{
		if (!LoadFileToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:LoadFileToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadFileToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadFileToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadFileToString_Path_Offset), 0, LoadFileToString_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadFileToString_FunctionAddress, intPtr, LoadFileToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadFileToString_Path_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LoadFileToString_ReturnValue_Offset), 0, LoadFileToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadFileToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsUnloadPSOFinished")]
	public unsafe static bool IsUnloadPSOFinished()
	{
		if (!IsUnloadPSOFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsUnloadPSOFinished");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUnloadPSOFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUnloadPSOFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsUnloadPSOFinished_FunctionAddress, intPtr, IsUnloadPSOFinished_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUnloadPSOFinished_ReturnValue_Offset), 0, IsUnloadPSOFinished_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsTestBuild")]
	public unsafe static bool IsTestBuild()
	{
		if (!IsTestBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsTestBuild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTestBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTestBuild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTestBuild_FunctionAddress, intPtr, IsTestBuild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTestBuild_ReturnValue_Offset), 0, IsTestBuild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandaloneGame")]
	public unsafe static bool IsStandaloneGame()
	{
		if (!IsStandaloneGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandaloneGame");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStandaloneGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStandaloneGame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStandaloneGame_FunctionAddress, intPtr, IsStandaloneGame_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStandaloneGame_ReturnValue_Offset), 0, IsStandaloneGame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandAlone")]
	public unsafe static bool IsStandAlone(UWorld World)
	{
		if (!IsStandAlone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandAlone");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStandAlone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStandAlone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsStandAlone_World_Offset), 0, IsStandAlone_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStandAlone_FunctionAddress, intPtr, IsStandAlone_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStandAlone_ReturnValue_Offset), 0, IsStandAlone_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsShippingBuild")]
	public unsafe static bool IsShippingBuild()
	{
		if (!IsShippingBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsShippingBuild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShippingBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShippingBuild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsShippingBuild_FunctionAddress, intPtr, IsShippingBuild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShippingBuild_ReturnValue_Offset), 0, IsShippingBuild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsSavePSOCacheInErrorState")]
	public unsafe static bool IsSavePSOCacheInErrorState()
	{
		if (!IsSavePSOCacheInErrorState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsSavePSOCacheInErrorState");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSavePSOCacheInErrorState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSavePSOCacheInErrorState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSavePSOCacheInErrorState_FunctionAddress, intPtr, IsSavePSOCacheInErrorState_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSavePSOCacheInErrorState_ReturnValue_Offset), 0, IsSavePSOCacheInErrorState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsRegexMatched")]
	public unsafe static bool IsRegexMatched(string InStr, string RegexExpression)
	{
		if (!IsRegexMatched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsRegexMatched");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRegexMatched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRegexMatched_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsRegexMatched_InStr_Offset), 0, IsRegexMatched_InStr_PropertyAddress.Address, InStr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsRegexMatched_RegexExpression_Offset), 0, IsRegexMatched_RegexExpression_PropertyAddress.Address, RegexExpression);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRegexMatched_FunctionAddress, intPtr, IsRegexMatched_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRegexMatched_InStr_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsRegexMatched_RegexExpression_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRegexMatched_ReturnValue_Offset), 0, IsRegexMatched_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsPSOBatchingPaused")]
	public unsafe static bool IsPSOBatchingPaused()
	{
		if (!IsPSOBatchingPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsPSOBatchingPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPSOBatchingPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPSOBatchingPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPSOBatchingPaused_FunctionAddress, intPtr, IsPSOBatchingPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPSOBatchingPaused_ReturnValue_Offset), 0, IsPSOBatchingPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsListenServer")]
	public unsafe static bool IsListenServer(UWorld World)
	{
		if (!IsListenServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsListenServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsListenServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsListenServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsListenServer_World_Offset), 0, IsListenServer_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsListenServer_FunctionAddress, intPtr, IsListenServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsListenServer_ReturnValue_Offset), 0, IsListenServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsEditor")]
	public unsafe static bool IsEditor()
	{
		if (!IsEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsEditor_FunctionAddress, intPtr, IsEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditor_ReturnValue_Offset), 0, IsEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsDriverVersionMismatch")]
	public unsafe static bool IsDriverVersionMismatch()
	{
		if (!IsDriverVersionMismatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsDriverVersionMismatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDriverVersionMismatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDriverVersionMismatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDriverVersionMismatch_FunctionAddress, intPtr, IsDriverVersionMismatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDriverVersionMismatch_ReturnValue_Offset), 0, IsDriverVersionMismatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsDevelopmentBuild")]
	public unsafe static bool IsDevelopmentBuild()
	{
		if (!IsDevelopmentBuild_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsDevelopmentBuild");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDevelopmentBuild_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDevelopmentBuild_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDevelopmentBuild_FunctionAddress, intPtr, IsDevelopmentBuild_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDevelopmentBuild_ReturnValue_Offset), 0, IsDevelopmentBuild_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsDedicateServer")]
	public unsafe static bool IsDedicateServer(UWorld World)
	{
		if (!IsDedicateServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsDedicateServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDedicateServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDedicateServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsDedicateServer_World_Offset), 0, IsDedicateServer_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDedicateServer_FunctionAddress, intPtr, IsDedicateServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDedicateServer_ReturnValue_Offset), 0, IsDedicateServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsControllerInPlayState")]
	public unsafe static bool IsControllerInPlayState(AController Controller)
	{
		if (!IsControllerInPlayState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsControllerInPlayState");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsControllerInPlayState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsControllerInPlayState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, IsControllerInPlayState_Controller_Offset), 0, IsControllerInPlayState_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsControllerInPlayState_FunctionAddress, intPtr, IsControllerInPlayState_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsControllerInPlayState_ReturnValue_Offset), 0, IsControllerInPlayState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsCommandLineHasParam")]
	public unsafe static bool IsCommandLineHasParam(string QueryParam)
	{
		if (!IsCommandLineHasParam_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsCommandLineHasParam");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCommandLineHasParam_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCommandLineHasParam_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsCommandLineHasParam_QueryParam_Offset), 0, IsCommandLineHasParam_QueryParam_PropertyAddress.Address, QueryParam);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCommandLineHasParam_FunctionAddress, intPtr, IsCommandLineHasParam_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsCommandLineHasParam_QueryParam_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCommandLineHasParam_ReturnValue_Offset), 0, IsCommandLineHasParam_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:IsClient")]
	public unsafe static bool IsClient(UWorld World)
	{
		if (!IsClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:IsClient");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsClient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsClient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsClient_World_Offset), 0, IsClient_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsClient_FunctionAddress, intPtr, IsClient_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsClient_ReturnValue_Offset), 0, IsClient_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:HasValidCaptureData")]
	public unsafe static bool HasValidCaptureData(UReflectionCaptureComponent Component)
	{
		if (!HasValidCaptureData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:HasValidCaptureData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasValidCaptureData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasValidCaptureData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UReflectionCaptureComponent>.ToNative(IntPtr.Add(intPtr, HasValidCaptureData_Component_Offset), 0, HasValidCaptureData_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasValidCaptureData_FunctionAddress, intPtr, HasValidCaptureData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasValidCaptureData_ReturnValue_Offset), 0, HasValidCaptureData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:HasLaunchOption")]
	public unsafe static bool HasLaunchOption(string Option)
	{
		if (!HasLaunchOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:HasLaunchOption");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasLaunchOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasLaunchOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HasLaunchOption_Option_Offset), 0, HasLaunchOption_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasLaunchOption_FunctionAddress, intPtr, HasLaunchOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasLaunchOption_Option_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasLaunchOption_ReturnValue_Offset), 0, HasLaunchOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GSSaveConfig")]
	public unsafe static void GSSaveConfig(UObject WorldContext)
	{
		if (!GSSaveConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GSSaveConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSaveConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSaveConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GSSaveConfig_WorldContext_Offset), 0, GSSaveConfig_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSSaveConfig_FunctionAddress, intPtr, GSSaveConfig_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldMainAudioDeviceID")]
	public unsafe static int GetWorldMainAudioDeviceID(UObject WorldContextObject)
	{
		if (!GetWorldMainAudioDeviceID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldMainAudioDeviceID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldMainAudioDeviceID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldMainAudioDeviceID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetWorldMainAudioDeviceID_WorldContextObject_Offset), 0, GetWorldMainAudioDeviceID_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldMainAudioDeviceID_FunctionAddress, intPtr, GetWorldMainAudioDeviceID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetWorldMainAudioDeviceID_ReturnValue_Offset), 0, GetWorldMainAudioDeviceID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldFromObj")]
	public unsafe static UWorld GetWorldFromObj(UObject Context)
	{
		if (!GetWorldFromObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldFromObj");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldFromObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldFromObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetWorldFromObj_Context_Offset), 0, GetWorldFromObj_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldFromObj_FunctionAddress, intPtr, GetWorldFromObj_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetWorldFromObj_ReturnValue_Offset), 0, GetWorldFromObj_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetWindowScreenResolution")]
	public unsafe static FVector2D GetWindowScreenResolution()
	{
		if (!GetWindowScreenResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetWindowScreenResolution");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWindowScreenResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWindowScreenResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWindowScreenResolution_FunctionAddress, intPtr, GetWindowScreenResolution_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWindowScreenResolution_ReturnValue_Offset), 0, GetWindowScreenResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningUITexList")]
	public unsafe static List<string> GetWarningUITexList(UObject WorldContext, string TraverseRootPath, string SourceFileCommPath, List<string> ExcludedPathList)
	{
		if (!GetWarningUITexList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningUITexList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWarningUITexList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWarningUITexList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetWarningUITexList_WorldContext_Offset), 0, GetWarningUITexList_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetWarningUITexList_TraverseRootPath_Offset), 0, GetWarningUITexList_TraverseRootPath_PropertyAddress.Address, TraverseRootPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetWarningUITexList_SourceFileCommPath_Offset), 0, GetWarningUITexList_SourceFileCommPath_PropertyAddress.Address, SourceFileCommPath);
		new TArrayCopyMarshaler<string>(1, GetWarningUITexList_ExcludedPathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetWarningUITexList_ExcludedPathList_Offset), ExcludedPathList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWarningUITexList_FunctionAddress, intPtr, GetWarningUITexList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetWarningUITexList_TraverseRootPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetWarningUITexList_SourceFileCommPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetWarningUITexList_ExcludedPathList_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetWarningUITexList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetWarningUITexList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetWarningUITexList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningPhysicsAssetList")]
	public unsafe static List<string> GetWarningPhysicsAssetList(UObject WorldContext, string TraverseRootPath)
	{
		if (!GetWarningPhysicsAssetList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningPhysicsAssetList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWarningPhysicsAssetList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWarningPhysicsAssetList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetWarningPhysicsAssetList_WorldContext_Offset), 0, GetWarningPhysicsAssetList_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetWarningPhysicsAssetList_TraverseRootPath_Offset), 0, GetWarningPhysicsAssetList_TraverseRootPath_PropertyAddress.Address, TraverseRootPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWarningPhysicsAssetList_FunctionAddress, intPtr, GetWarningPhysicsAssetList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetWarningPhysicsAssetList_TraverseRootPath_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetWarningPhysicsAssetList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetWarningPhysicsAssetList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetWarningPhysicsAssetList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetTransientPackage")]
	public new unsafe static UPackage GetTransientPackage()
	{
		if (!GetTransientPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetTransientPackage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransientPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransientPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransientPackage_FunctionAddress, intPtr, GetTransientPackage_ParamsSize);
		return UObjectMarshaler<UPackage>.FromNative(IntPtr.Add(intPtr, GetTransientPackage_ReturnValue_Offset), 0, GetTransientPackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetTotalPsoPrecompileNum")]
	public unsafe static int GetTotalPsoPrecompileNum()
	{
		if (!GetTotalPsoPrecompileNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetTotalPsoPrecompileNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalPsoPrecompileNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalPsoPrecompileNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTotalPsoPrecompileNum_FunctionAddress, intPtr, GetTotalPsoPrecompileNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTotalPsoPrecompileNum_ReturnValue_Offset), 0, GetTotalPsoPrecompileNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetTimeSpanFromSeconds")]
	public unsafe static FTimespan GetTimeSpanFromSeconds(double Seconds)
	{
		if (!GetTimeSpanFromSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetTimeSpanFromSeconds");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeSpanFromSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeSpanFromSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, GetTimeSpanFromSeconds_Seconds_Offset), 0, GetTimeSpanFromSeconds_Seconds_PropertyAddress.Address, Seconds);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTimeSpanFromSeconds_FunctionAddress, intPtr, GetTimeSpanFromSeconds_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetTimeSpanFromSeconds_ReturnValue_Offset), 0, GetTimeSpanFromSeconds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetShadowQualityLevel")]
	public unsafe static int GetShadowQualityLevel()
	{
		if (!GetShadowQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetShadowQualityLevel");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShadowQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShadowQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetShadowQualityLevel_FunctionAddress, intPtr, GetShadowQualityLevel_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetShadowQualityLevel_ReturnValue_Offset), 0, GetShadowQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetRemainingPsoPrecompileNum")]
	public unsafe static int GetRemainingPsoPrecompileNum()
	{
		if (!GetRemainingPsoPrecompileNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetRemainingPsoPrecompileNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRemainingPsoPrecompileNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRemainingPsoPrecompileNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRemainingPsoPrecompileNum_FunctionAddress, intPtr, GetRemainingPsoPrecompileNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRemainingPsoPrecompileNum_ReturnValue_Offset), 0, GetRemainingPsoPrecompileNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetRegexMatchInfo")]
	public unsafe static void GetRegexMatchInfo(string InStr, string RegexExpression, out List<string> ExtractedInfo)
	{
		if (!GetRegexMatchInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetRegexMatchInfo");
			ExtractedInfo = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRegexMatchInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRegexMatchInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetRegexMatchInfo_InStr_Offset), 0, GetRegexMatchInfo_InStr_PropertyAddress.Address, InStr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetRegexMatchInfo_RegexExpression_Offset), 0, GetRegexMatchInfo_RegexExpression_PropertyAddress.Address, RegexExpression);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRegexMatchInfo_FunctionAddress, intPtr, GetRegexMatchInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRegexMatchInfo_InStr_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetRegexMatchInfo_RegexExpression_PropertyAddress.Address, intPtr);
		ExtractedInfo = new TArrayCopyMarshaler<string>(1, GetRegexMatchInfo_ExtractedInfo_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetRegexMatchInfo_ExtractedInfo_Offset));
		NativeReflection.DestroyValue_InContainer(GetRegexMatchInfo_ExtractedInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetRecommendedQualityLevel")]
	public unsafe static EGSQualityLevel GetRecommendedQualityLevel(bool bLogInfo = false)
	{
		if (!GetRecommendedQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetRecommendedQualityLevel");
			return EGSQualityLevel.INVALID;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRecommendedQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRecommendedQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRecommendedQualityLevel_bLogInfo_Offset), 0, GetRecommendedQualityLevel_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRecommendedQualityLevel_FunctionAddress, intPtr, GetRecommendedQualityLevel_ParamsSize);
		return EnumMarshaler<EGSQualityLevel>.FromNative(IntPtr.Add(intPtr, GetRecommendedQualityLevel_ReturnValue_Offset), 0, GetRecommendedQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectSettingDefaultGameMode")]
	public unsafe static TSubclassOf<AGameModeBase> GetProjectSettingDefaultGameMode()
	{
		if (!GetProjectSettingDefaultGameMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectSettingDefaultGameMode");
			return default(TSubclassOf<AGameModeBase>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProjectSettingDefaultGameMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProjectSettingDefaultGameMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProjectSettingDefaultGameMode_FunctionAddress, intPtr, GetProjectSettingDefaultGameMode_ParamsSize);
		return TSubclassOfMarshaler<AGameModeBase>.FromNative(IntPtr.Add(intPtr, GetProjectSettingDefaultGameMode_ReturnValue_Offset), 0, GetProjectSettingDefaultGameMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectDir")]
	public unsafe static string GetProjectDir()
	{
		if (!GetProjectDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectDir");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProjectDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProjectDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProjectDir_FunctionAddress, intPtr, GetProjectDir_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetProjectDir_ReturnValue_Offset), 0, GetProjectDir_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetProjectDir_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRectMatrixInfo")]
	public unsafe static void GetPlayerViewRectMatrixInfo(APlayerController Player, out FMatrix ViewProjectionMatrixInv, out FVector2D OutConstrainedViewRectMin, out FVector2D OutConstrainedViewRectMax, out FVector2D OutViewRectMin, out FVector2D OutViewRectMax)
	{
		if (!GetPlayerViewRectMatrixInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRectMatrixInfo");
			ViewProjectionMatrixInv = default(FMatrix);
			OutConstrainedViewRectMin = default(FVector2D);
			OutConstrainedViewRectMax = default(FVector2D);
			OutViewRectMin = default(FVector2D);
			OutViewRectMax = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewRectMatrixInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewRectMatrixInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_Player_Offset), 0, GetPlayerViewRectMatrixInfo_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, intPtr, GetPlayerViewRectMatrixInfo_ParamsSize);
		ViewProjectionMatrixInv = BlittableTypeMarshaler<FMatrix>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_Offset), 0, GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_PropertyAddress.Address);
		OutConstrainedViewRectMin = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_Offset), 0, GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_PropertyAddress.Address);
		OutConstrainedViewRectMax = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_Offset), 0, GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_PropertyAddress.Address);
		OutViewRectMin = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_OutViewRectMin_Offset), 0, GetPlayerViewRectMatrixInfo_OutViewRectMin_PropertyAddress.Address);
		OutViewRectMax = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRectMatrixInfo_OutViewRectMax_Offset), 0, GetPlayerViewRectMatrixInfo_OutViewRectMax_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRect")]
	public unsafe static void GetPlayerViewRect(APlayerController Player, out FVector2D OutConstrainedViewRectMin, out FVector2D OutConstrainedViewRectMax, out FVector2D OutViewRectMin, out FVector2D OutViewRectMax)
	{
		if (!GetPlayerViewRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRect");
			OutConstrainedViewRectMin = default(FVector2D);
			OutConstrainedViewRectMax = default(FVector2D);
			OutViewRectMin = default(FVector2D);
			OutViewRectMax = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerViewRect_Player_Offset), 0, GetPlayerViewRect_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerViewRect_FunctionAddress, intPtr, GetPlayerViewRect_ParamsSize);
		OutConstrainedViewRectMin = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRect_OutConstrainedViewRectMin_Offset), 0, GetPlayerViewRect_OutConstrainedViewRectMin_PropertyAddress.Address);
		OutConstrainedViewRectMax = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRect_OutConstrainedViewRectMax_Offset), 0, GetPlayerViewRect_OutConstrainedViewRectMax_PropertyAddress.Address);
		OutViewRectMin = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRect_OutViewRectMin_Offset), 0, GetPlayerViewRect_OutViewRectMin_PropertyAddress.Address);
		OutViewRectMax = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPlayerViewRect_OutViewRectMax_Offset), 0, GetPlayerViewRect_OutViewRectMax_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrixInv")]
	public unsafe static FMatrix GetPlayerViewProjectionMatrixInv(APlayerController Player)
	{
		if (!GetPlayerViewProjectionMatrixInv_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrixInv");
			return default(FMatrix);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewProjectionMatrixInv_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewProjectionMatrixInv_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerViewProjectionMatrixInv_Player_Offset), 0, GetPlayerViewProjectionMatrixInv_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerViewProjectionMatrixInv_FunctionAddress, intPtr, GetPlayerViewProjectionMatrixInv_ParamsSize);
		return BlittableTypeMarshaler<FMatrix>.FromNative(IntPtr.Add(intPtr, GetPlayerViewProjectionMatrixInv_ReturnValue_Offset), 0, GetPlayerViewProjectionMatrixInv_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrix")]
	public unsafe static FMatrix GetPlayerViewProjectionMatrix(APlayerController Player)
	{
		if (!GetPlayerViewProjectionMatrix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrix");
			return default(FMatrix);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewProjectionMatrix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewProjectionMatrix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetPlayerViewProjectionMatrix_Player_Offset), 0, GetPlayerViewProjectionMatrix_Player_PropertyAddress.Address, Player);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerViewProjectionMatrix_FunctionAddress, intPtr, GetPlayerViewProjectionMatrix_ParamsSize);
		return BlittableTypeMarshaler<FMatrix>.FromNative(IntPtr.Add(intPtr, GetPlayerViewProjectionMatrix_ReturnValue_Offset), 0, GetPlayerViewProjectionMatrix_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlatformTime")]
	public unsafe static double GetPlatformTime()
	{
		if (!GetPlatformTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlatformTime");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlatformTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlatformTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlatformTime_FunctionAddress, intPtr, GetPlatformTime_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetPlatformTime_ReturnValue_Offset), 0, GetPlatformTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetPawnAutoPossessConfig")]
	public unsafe static int GetPawnAutoPossessConfig(APawn PC)
	{
		if (!GetPawnAutoPossessConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetPawnAutoPossessConfig");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPawnAutoPossessConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPawnAutoPossessConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, GetPawnAutoPossessConfig_PC_Offset), 0, GetPawnAutoPossessConfig_PC_PropertyAddress.Address, PC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPawnAutoPossessConfig_FunctionAddress, intPtr, GetPawnAutoPossessConfig_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPawnAutoPossessConfig_ReturnValue_Offset), 0, GetPawnAutoPossessConfig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerTime")]
	public unsafe static double GetMediaPlayerTime(UMediaPlayer MediaPlayer)
	{
		if (!GetMediaPlayerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerTime");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetMediaPlayerTime_MediaPlayer_Offset), 0, GetMediaPlayerTime_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMediaPlayerTime_FunctionAddress, intPtr, GetMediaPlayerTime_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetMediaPlayerTime_ReturnValue_Offset), 0, GetMediaPlayerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerDuartion")]
	public unsafe static double GetMediaPlayerDuartion(UMediaPlayer MediaPlayer)
	{
		if (!GetMediaPlayerDuartion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerDuartion");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayerDuartion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayerDuartion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetMediaPlayerDuartion_MediaPlayer_Offset), 0, GetMediaPlayerDuartion_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMediaPlayerDuartion_FunctionAddress, intPtr, GetMediaPlayerDuartion_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetMediaPlayerDuartion_ReturnValue_Offset), 0, GetMediaPlayerDuartion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetMacAddress")]
	public unsafe static List<byte> GetMacAddress()
	{
		if (!GetMacAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetMacAddress");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMacAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMacAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMacAddress_FunctionAddress, intPtr, GetMacAddress_ParamsSize);
		List<byte> result = new TArrayCopyMarshaler<byte>(1, GetMacAddress_ReturnValue_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMacAddress_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMacAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetLoginId")]
	public unsafe static string GetLoginId()
	{
		if (!GetLoginId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetLoginId");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoginId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoginId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLoginId_FunctionAddress, intPtr, GetLoginId_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLoginId_ReturnValue_Offset), 0, GetLoginId_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLoginId_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetLocalPlayerCameraManager")]
	public unsafe static APlayerCameraManager GetLocalPlayerCameraManager(UObject WorldCtx)
	{
		if (!GetLocalPlayerCameraManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetLocalPlayerCameraManager");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalPlayerCameraManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalPlayerCameraManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLocalPlayerCameraManager_WorldCtx_Offset), 0, GetLocalPlayerCameraManager_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalPlayerCameraManager_FunctionAddress, intPtr, GetLocalPlayerCameraManager_ParamsSize);
		return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(intPtr, GetLocalPlayerCameraManager_ReturnValue_Offset), 0, GetLocalPlayerCameraManager_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetLaunchValue")]
	public unsafe static string GetLaunchValue(string Option)
	{
		if (!GetLaunchValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetLaunchValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLaunchValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLaunchValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLaunchValue_Option_Offset), 0, GetLaunchValue_Option_PropertyAddress.Address, Option);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLaunchValue_FunctionAddress, intPtr, GetLaunchValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLaunchValue_Option_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLaunchValue_ReturnValue_Offset), 0, GetLaunchValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLaunchValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputKey")]
	public unsafe static FKey GetInputKey(FKeyEvent KeyEvent)
	{
		if (!GetInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputKey_KeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetInputKey_KeyEvent_Offset), 0, GetInputKey_KeyEvent_PropertyAddress.Address, KeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputKey_FunctionAddress, intPtr, GetInputKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputKey_KeyEvent_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetInputKey_ReturnValue_Offset), 0, GetInputKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputDeadZone")]
	public unsafe static float GetInputDeadZone(APlayerController PlayerController, FName AxisName)
	{
		if (!GetInputDeadZone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputDeadZone");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputDeadZone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputDeadZone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetInputDeadZone_PlayerController_Offset), 0, GetInputDeadZone_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInputDeadZone_AxisName_Offset), 0, GetInputDeadZone_AxisName_PropertyAddress.Address, AxisName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputDeadZone_FunctionAddress, intPtr, GetInputDeadZone_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputDeadZone_ReturnValue_Offset), 0, GetInputDeadZone_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetGFrameCounter")]
	public unsafe static long GetGFrameCounter()
	{
		if (!GetGFrameCounter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetGFrameCounter");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGFrameCounter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGFrameCounter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGFrameCounter_FunctionAddress, intPtr, GetGFrameCounter_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetGFrameCounter_ReturnValue_Offset), 0, GetGFrameCounter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetFirstLocalPlayerController")]
	public unsafe static APlayerController GetFirstLocalPlayerController(UObject WorldCtx)
	{
		if (!GetFirstLocalPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetFirstLocalPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstLocalPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstLocalPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetFirstLocalPlayerController_WorldCtx_Offset), 0, GetFirstLocalPlayerController_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFirstLocalPlayerController_FunctionAddress, intPtr, GetFirstLocalPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetFirstLocalPlayerController_ReturnValue_Offset), 0, GetFirstLocalPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetEngineMinorVersion")]
	public unsafe static int GetEngineMinorVersion()
	{
		if (!GetEngineMinorVersion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetEngineMinorVersion");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngineMinorVersion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngineMinorVersion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEngineMinorVersion_FunctionAddress, intPtr, GetEngineMinorVersion_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetEngineMinorVersion_ReturnValue_Offset), 0, GetEngineMinorVersion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayName")]
	public unsafe static string GetDisplayName(UObject Object)
	{
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDisplayName_Object_Offset), 0, GetDisplayName_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayGamma")]
	public unsafe static float GetDisplayGamma(UObject WorldCtx)
	{
		if (!GetDisplayGamma_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayGamma");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayGamma_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayGamma_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetDisplayGamma_WorldCtx_Offset), 0, GetDisplayGamma_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayGamma_FunctionAddress, intPtr, GetDisplayGamma_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDisplayGamma_ReturnValue_Offset), 0, GetDisplayGamma_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceInfo")]
	public unsafe static void GetDeviceInfo(out string Cpu, out string Gpu, out int MemSize)
	{
		if (!GetDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceInfo");
			Cpu = FStringMarshaler.DefaultString;
			Gpu = FStringMarshaler.DefaultString;
			MemSize = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeviceInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeviceInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDeviceInfo_FunctionAddress, intPtr, GetDeviceInfo_ParamsSize);
		Cpu = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDeviceInfo_Cpu_Offset), 0, GetDeviceInfo_Cpu_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDeviceInfo_Cpu_PropertyAddress.Address, intPtr);
		Gpu = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDeviceInfo_Gpu_Offset), 0, GetDeviceInfo_Gpu_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDeviceInfo_Gpu_PropertyAddress.Address, intPtr);
		MemSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDeviceInfo_MemSize_Offset), 0, GetDeviceInfo_MemSize_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceId")]
	public unsafe static string GetDeviceId()
	{
		if (!GetDeviceId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceId");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeviceId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeviceId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDeviceId_FunctionAddress, intPtr, GetDeviceId_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDeviceId_ReturnValue_Offset), 0, GetDeviceId_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDeviceId_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetDefaultLanguageCS")]
	public unsafe static string GetDefaultLanguageCS()
	{
		if (!GetDefaultLanguageCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetDefaultLanguageCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultLanguageCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultLanguageCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultLanguageCS_FunctionAddress, intPtr, GetDefaultLanguageCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDefaultLanguageCS_ReturnValue_Offset), 0, GetDefaultLanguageCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultLanguageCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetCurrentRhiName")]
	public unsafe static string GetCurrentRhiName()
	{
		if (!GetCurrentRhiName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetCurrentRhiName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentRhiName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentRhiName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentRhiName_FunctionAddress, intPtr, GetCurrentRhiName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentRhiName_ReturnValue_Offset), 0, GetCurrentRhiName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentRhiName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetChildActors")]
	public unsafe static List<AActor> GetChildActors(AActor Actor)
	{
		if (!GetChildActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetChildActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetChildActors_Actor_Offset), 0, GetChildActors_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildActors_FunctionAddress, intPtr, GetChildActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetChildActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTotalFrames")]
	public unsafe static int GetBinkMediaPlayerTotalFrames(UBinkMediaPlayer MediaPlayer)
	{
		if (!GetBinkMediaPlayerTotalFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTotalFrames");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBinkMediaPlayerTotalFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBinkMediaPlayerTotalFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetBinkMediaPlayerTotalFrames_MediaPlayer_Offset), 0, GetBinkMediaPlayerTotalFrames_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBinkMediaPlayerTotalFrames_FunctionAddress, intPtr, GetBinkMediaPlayerTotalFrames_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBinkMediaPlayerTotalFrames_ReturnValue_Offset), 0, GetBinkMediaPlayerTotalFrames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTime")]
	public unsafe static double GetBinkMediaPlayerTime(UBinkMediaPlayer MediaPlayer)
	{
		if (!GetBinkMediaPlayerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTime");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBinkMediaPlayerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBinkMediaPlayerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetBinkMediaPlayerTime_MediaPlayer_Offset), 0, GetBinkMediaPlayerTime_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBinkMediaPlayerTime_FunctionAddress, intPtr, GetBinkMediaPlayerTime_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetBinkMediaPlayerTime_ReturnValue_Offset), 0, GetBinkMediaPlayerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerFrameRate")]
	public unsafe static float GetBinkMediaPlayerFrameRate(UBinkMediaPlayer MediaPlayer)
	{
		if (!GetBinkMediaPlayerFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerFrameRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBinkMediaPlayerFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBinkMediaPlayerFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetBinkMediaPlayerFrameRate_MediaPlayer_Offset), 0, GetBinkMediaPlayerFrameRate_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBinkMediaPlayerFrameRate_FunctionAddress, intPtr, GetBinkMediaPlayerFrameRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBinkMediaPlayerFrameRate_ReturnValue_Offset), 0, GetBinkMediaPlayerFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerDuartion")]
	public unsafe static double GetBinkMediaPlayerDuartion(UBinkMediaPlayer MediaPlayer)
	{
		if (!GetBinkMediaPlayerDuartion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerDuartion");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBinkMediaPlayerDuartion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBinkMediaPlayerDuartion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetBinkMediaPlayerDuartion_MediaPlayer_Offset), 0, GetBinkMediaPlayerDuartion_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBinkMediaPlayerDuartion_FunctionAddress, intPtr, GetBinkMediaPlayerDuartion_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetBinkMediaPlayerDuartion_ReturnValue_Offset), 0, GetBinkMediaPlayerDuartion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerCurFrame")]
	public unsafe static int GetBinkMediaPlayerCurFrame(UBinkMediaPlayer MediaPlayer)
	{
		if (!GetBinkMediaPlayerCurFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerCurFrame");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBinkMediaPlayerCurFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBinkMediaPlayerCurFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetBinkMediaPlayerCurFrame_MediaPlayer_Offset), 0, GetBinkMediaPlayerCurFrame_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBinkMediaPlayerCurFrame_FunctionAddress, intPtr, GetBinkMediaPlayerCurFrame_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBinkMediaPlayerCurFrame_ReturnValue_Offset), 0, GetBinkMediaPlayerCurFrame_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAxisMappings")]
	public unsafe static List<FInputAxisKeyMapping> GetAxisMappings(APlayerController PlayerController)
	{
		if (!GetAxisMappings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAxisMappings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAxisMappings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAxisMappings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetAxisMappings_PlayerController_Offset), 0, GetAxisMappings_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAxisMappings_FunctionAddress, intPtr, GetAxisMappings_ParamsSize);
		List<FInputAxisKeyMapping> result = new TArrayCopyMarshaler<FInputAxisKeyMapping>(1, GetAxisMappings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FInputAxisKeyMapping, FInputAxisKeyMapping>.FromNative, CachedMarshalingDelegates<FInputAxisKeyMapping, FInputAxisKeyMapping>.ToNative).FromNative(IntPtr.Add(intPtr, GetAxisMappings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAxisMappings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAvailablePhysical")]
	public unsafe static float GetAvailablePhysical()
	{
		if (!GetAvailablePhysical_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAvailablePhysical");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailablePhysical_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailablePhysical_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailablePhysical_FunctionAddress, intPtr, GetAvailablePhysical_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAvailablePhysical_ReturnValue_Offset), 0, GetAvailablePhysical_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAudioInfoOfAudioVisualize")]
	public unsafe static UAudioComponent GetAudioInfoOfAudioVisualize(AActor AudioUtilActor, out float AudioDuration)
	{
		if (!GetAudioInfoOfAudioVisualize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAudioInfoOfAudioVisualize");
			AudioDuration = 0f;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioInfoOfAudioVisualize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioInfoOfAudioVisualize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAudioInfoOfAudioVisualize_AudioUtilActor_Offset), 0, GetAudioInfoOfAudioVisualize_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAudioInfoOfAudioVisualize_FunctionAddress, intPtr, GetAudioInfoOfAudioVisualize_ParamsSize);
		AudioDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAudioInfoOfAudioVisualize_AudioDuration_Offset), 0, GetAudioInfoOfAudioVisualize_AudioDuration_PropertyAddress.Address);
		return UObjectMarshaler<UAudioComponent>.FromNative(IntPtr.Add(intPtr, GetAudioInfoOfAudioVisualize_ReturnValue_Offset), 0, GetAudioInfoOfAudioVisualize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAsyncLoadPercentage")]
	public unsafe static float GetAsyncLoadPercentage(FName PackageName)
	{
		if (!GetAsyncLoadPercentage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAsyncLoadPercentage");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsyncLoadPercentage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsyncLoadPercentage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAsyncLoadPercentage_PackageName_Offset), 0, GetAsyncLoadPercentage_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAsyncLoadPercentage_FunctionAddress, intPtr, GetAsyncLoadPercentage_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAsyncLoadPercentage_ReturnValue_Offset), 0, GetAsyncLoadPercentage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogValue")]
	public unsafe static float GetAnalogValue(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetAnalogValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogValue_AnalogInputEvent_Offset), 0, GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogValue_FunctionAddress, intPtr, GetAnalogValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnalogValue_ReturnValue_Offset), 0, GetAnalogValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogInputKey")]
	public unsafe static FKey GetAnalogInputKey(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetAnalogInputKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogInputKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogInputKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogInputKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogInputKey_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogInputKey_AnalogInputEvent_Offset), 0, GetAnalogInputKey_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogInputKey_FunctionAddress, intPtr, GetAnalogInputKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogInputKey_AnalogInputEvent_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetAnalogInputKey_ReturnValue_Offset), 0, GetAnalogInputKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAnalogInputKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetActualQualityLevel")]
	public unsafe static EGSQualityLevel GetActualQualityLevel(bool bLogInfo = false)
	{
		if (!GetActualQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetActualQualityLevel");
			return EGSQualityLevel.INVALID;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActualQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActualQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActualQualityLevel_bLogInfo_Offset), 0, GetActualQualityLevel_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActualQualityLevel_FunctionAddress, intPtr, GetActualQualityLevel_ParamsSize);
		return EnumMarshaler<EGSQualityLevel>.FromNative(IntPtr.Add(intPtr, GetActualQualityLevel_ReturnValue_Offset), 0, GetActualQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GetActionMappings")]
	public unsafe static List<FInputActionKeyMapping> GetActionMappings(APlayerController PlayerController)
	{
		if (!GetActionMappings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GetActionMappings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActionMappings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActionMappings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetActionMappings_PlayerController_Offset), 0, GetActionMappings_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActionMappings_FunctionAddress, intPtr, GetActionMappings_ParamsSize);
		List<FInputActionKeyMapping> result = new TArrayCopyMarshaler<FInputActionKeyMapping>(1, GetActionMappings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FInputActionKeyMapping, FInputActionKeyMapping>.FromNative, CachedMarshalingDelegates<FInputActionKeyMapping, FInputActionKeyMapping>.ToNative).FromNative(IntPtr.Add(intPtr, GetActionMappings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActionMappings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:GameInstanceIsDedicatedServer")]
	public unsafe static bool GameInstanceIsDedicatedServer(UGameInstance GameInst)
	{
		if (!GameInstanceIsDedicatedServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:GameInstanceIsDedicatedServer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GameInstanceIsDedicatedServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GameInstanceIsDedicatedServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGameInstance>.ToNative(IntPtr.Add(intPtr, GameInstanceIsDedicatedServer_GameInst_Offset), 0, GameInstanceIsDedicatedServer_GameInst_PropertyAddress.Address, GameInst);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GameInstanceIsDedicatedServer_FunctionAddress, intPtr, GameInstanceIsDedicatedServer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GameInstanceIsDedicatedServer_ReturnValue_Offset), 0, GameInstanceIsDedicatedServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:FlushMainAudioDevice")]
	public unsafe static void FlushMainAudioDevice(int DeviceID)
	{
		if (!FlushMainAudioDevice_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:FlushMainAudioDevice");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushMainAudioDevice_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushMainAudioDevice_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FlushMainAudioDevice_DeviceID_Offset), 0, FlushMainAudioDevice_DeviceID_PropertyAddress.Address, DeviceID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FlushMainAudioDevice_FunctionAddress, intPtr, FlushMainAudioDevice_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:FindPathSync")]
	public unsafe static List<FVector> FindPathSync(AController Controller, FVector TargetLocation)
	{
		if (!FindPathSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:FindPathSync");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPathSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPathSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, FindPathSync_Controller_Offset), 0, FindPathSync_Controller_PropertyAddress.Address, Controller);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindPathSync_TargetLocation_Offset), 0, FindPathSync_TargetLocation_PropertyAddress.Address, TargetLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPathSync_FunctionAddress, intPtr, FindPathSync_ParamsSize);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, FindPathSync_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, FindPathSync_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindPathSync_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:FindNamedNetDriver")]
	public unsafe static UNetDriver FindNamedNetDriver(UWorld InWorld, FName NetDriverName)
	{
		if (!FindNamedNetDriver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:FindNamedNetDriver");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNamedNetDriver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNamedNetDriver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, FindNamedNetDriver_InWorld_Offset), 0, FindNamedNetDriver_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindNamedNetDriver_NetDriverName_Offset), 0, FindNamedNetDriver_NetDriverName_PropertyAddress.Address, NetDriverName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindNamedNetDriver_FunctionAddress, intPtr, FindNamedNetDriver_ParamsSize);
		return UObjectMarshaler<UNetDriver>.FromNative(IntPtr.Add(intPtr, FindNamedNetDriver_ReturnValue_Offset), 0, FindNamedNetDriver_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleRefsByObjectPath")]
	public unsafe static string FindAndPrintStaleRefsByObjectPath(string InObjectPath)
	{
		if (!FindAndPrintStaleRefsByObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleRefsByObjectPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAndPrintStaleRefsByObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAndPrintStaleRefsByObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindAndPrintStaleRefsByObjectPath_InObjectPath_Offset), 0, FindAndPrintStaleRefsByObjectPath_InObjectPath_PropertyAddress.Address, InObjectPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAndPrintStaleRefsByObjectPath_FunctionAddress, intPtr, FindAndPrintStaleRefsByObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindAndPrintStaleRefsByObjectPath_InObjectPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FindAndPrintStaleRefsByObjectPath_ReturnValue_Offset), 0, FindAndPrintStaleRefsByObjectPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindAndPrintStaleRefsByObjectPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleReferencesToObject")]
	public unsafe static string FindAndPrintStaleReferencesToObject(UObject Obj)
	{
		if (!FindAndPrintStaleReferencesToObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleReferencesToObject");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAndPrintStaleReferencesToObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAndPrintStaleReferencesToObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindAndPrintStaleReferencesToObject_Obj_Offset), 0, FindAndPrintStaleReferencesToObject_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAndPrintStaleReferencesToObject_FunctionAddress, intPtr, FindAndPrintStaleReferencesToObject_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FindAndPrintStaleReferencesToObject_ReturnValue_Offset), 0, FindAndPrintStaleReferencesToObject_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindAndPrintStaleReferencesToObject_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ExecCmdOutGLog")]
	public unsafe static void ExecCmdOutGLog(string Cmd, UObject WorldCtx)
	{
		if (!ExecCmdOutGLog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ExecCmdOutGLog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecCmdOutGLog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecCmdOutGLog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExecCmdOutGLog_Cmd_Offset), 0, ExecCmdOutGLog_Cmd_PropertyAddress.Address, Cmd);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ExecCmdOutGLog_WorldCtx_Offset), 0, ExecCmdOutGLog_WorldCtx_PropertyAddress.Address, WorldCtx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExecCmdOutGLog_FunctionAddress, intPtr, ExecCmdOutGLog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExecCmdOutGLog_Cmd_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:EngineGC")]
	public unsafe static void EngineGC(bool bFullPurge)
	{
		if (!EngineGC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:EngineGC");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineGC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineGC_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EngineGC_bFullPurge_Offset), 0, EngineGC_bFullPurge_PropertyAddress.Address, bFullPurge);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineGC_FunctionAddress, intPtr, EngineGC_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:EnableForceStreamdOutLevelGCCheck")]
	public unsafe static void EnableForceStreamdOutLevelGCCheck(bool Enable, bool IgnoreEditor = true)
	{
		if (!EnableForceStreamdOutLevelGCCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:EnableForceStreamdOutLevelGCCheck");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableForceStreamdOutLevelGCCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableForceStreamdOutLevelGCCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableForceStreamdOutLevelGCCheck_Enable_Offset), 0, EnableForceStreamdOutLevelGCCheck_Enable_PropertyAddress.Address, Enable);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableForceStreamdOutLevelGCCheck_IgnoreEditor_Offset), 0, EnableForceStreamdOutLevelGCCheck_IgnoreEditor_PropertyAddress.Address, IgnoreEditor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableForceStreamdOutLevelGCCheck_FunctionAddress, intPtr, EnableForceStreamdOutLevelGCCheck_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DuplicateAsset")]
	public unsafe static UObject DuplicateAsset(string AssetName, string PackagePath, UObject OriginalObject)
	{
		if (!DuplicateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DuplicateAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_AssetName_Offset), 0, DuplicateAsset_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_PackagePath_Offset), 0, DuplicateAsset_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAsset_OriginalObject_Offset), 0, DuplicateAsset_OriginalObject_PropertyAddress.Address, OriginalObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateAsset_FunctionAddress, intPtr, DuplicateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAsset_ReturnValue_Offset), 0, DuplicateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DrawDebugCircleArc")]
	public unsafe static void DrawDebugCircleArc(UObject WorldContextObject, FVector Center, float Radius, FVector Direction, float AngleWidth, int NumSegments, FLinearColor LineColor, float Duration, float Thickness)
	{
		if (!DrawDebugCircleArc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DrawDebugCircleArc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawDebugCircleArc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawDebugCircleArc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_WorldContextObject_Offset), 0, DrawDebugCircleArc_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_Center_Offset), 0, DrawDebugCircleArc_Center_PropertyAddress.Address, Center);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_Radius_Offset), 0, DrawDebugCircleArc_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_Direction_Offset), 0, DrawDebugCircleArc_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_AngleWidth_Offset), 0, DrawDebugCircleArc_AngleWidth_PropertyAddress.Address, AngleWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_NumSegments_Offset), 0, DrawDebugCircleArc_NumSegments_PropertyAddress.Address, NumSegments);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_LineColor_Offset), 0, DrawDebugCircleArc_LineColor_PropertyAddress.Address, LineColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_Duration_Offset), 0, DrawDebugCircleArc_Duration_PropertyAddress.Address, Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDebugCircleArc_Thickness_Offset), 0, DrawDebugCircleArc_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawDebugCircleArc_FunctionAddress, intPtr, DrawDebugCircleArc_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DisableDebugExecBindings")]
	public unsafe static void DisableDebugExecBindings(UObject WorldCtx, bool IsDisable)
	{
		if (!DisableDebugExecBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DisableDebugExecBindings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableDebugExecBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableDebugExecBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DisableDebugExecBindings_WorldCtx_Offset), 0, DisableDebugExecBindings_WorldCtx_PropertyAddress.Address, WorldCtx);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DisableDebugExecBindings_IsDisable_Offset), 0, DisableDebugExecBindings_IsDisable_PropertyAddress.Address, IsDisable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableDebugExecBindings_FunctionAddress, intPtr, DisableDebugExecBindings_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DetectDragIfPressed")]
	public unsafe static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent, UWidget WidgetDetectingDrag, FName KeyName)
	{
		if (!DetectDragIfPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DetectDragIfPressed");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetectDragIfPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetectDragIfPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DetectDragIfPressed_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_PointerEvent_Offset), 0, DetectDragIfPressed_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_WidgetDetectingDrag_Offset), 0, DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress.Address, WidgetDetectingDrag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_KeyName_Offset), 0, DetectDragIfPressed_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DetectDragIfPressed_FunctionAddress, intPtr, DetectDragIfPressed_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DetectDragIfPressed_PointerEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, DetectDragIfPressed_ReturnValue_Offset), 0, DetectDragIfPressed_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DetectDragIfPressed_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActorsWithSpecifiedKeyword")]
	public unsafe static void DestroyActorsWithSpecifiedKeyword(UObject InWorldContext, string InKeyword)
	{
		if (!DestroyActorsWithSpecifiedKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActorsWithSpecifiedKeyword");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyActorsWithSpecifiedKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyActorsWithSpecifiedKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DestroyActorsWithSpecifiedKeyword_InWorldContext_Offset), 0, DestroyActorsWithSpecifiedKeyword_InWorldContext_PropertyAddress.Address, InWorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DestroyActorsWithSpecifiedKeyword_InKeyword_Offset), 0, DestroyActorsWithSpecifiedKeyword_InKeyword_PropertyAddress.Address, InKeyword);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyActorsWithSpecifiedKeyword_FunctionAddress, intPtr, DestroyActorsWithSpecifiedKeyword_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DestroyActorsWithSpecifiedKeyword_InKeyword_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActor")]
	public unsafe static void DestroyActor(AActor Actor)
	{
		if (!DestroyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DestroyActor_Actor_Offset), 0, DestroyActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyActor_FunctionAddress, intPtr, DestroyActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:DelayGC")]
	public unsafe static void DelayGC()
	{
		if (!DelayGC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:DelayGC");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DelayGC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DelayGC_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: DelayGC_FunctionAddress, argsSize: DelayGC_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CreateReplicationDriver")]
	public unsafe static UReplicationDriver CreateReplicationDriver(UNetDriver NetDriver, UWorld World)
	{
		if (!CreateReplicationDriver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CreateReplicationDriver");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateReplicationDriver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateReplicationDriver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNetDriver>.ToNative(IntPtr.Add(intPtr, CreateReplicationDriver_NetDriver_Offset), 0, CreateReplicationDriver_NetDriver_PropertyAddress.Address, NetDriver);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateReplicationDriver_World_Offset), 0, CreateReplicationDriver_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateReplicationDriver_FunctionAddress, intPtr, CreateReplicationDriver_ParamsSize);
		return UObjectMarshaler<UReplicationDriver>.FromNative(IntPtr.Add(intPtr, CreateReplicationDriver_ReturnValue_Offset), 0, CreateReplicationDriver_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CreateNamedNetDriver")]
	public unsafe static void CreateNamedNetDriver(UWorld InWorld, FName NetDriverName, FName NetDriverDefinition)
	{
		if (!CreateNamedNetDriver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CreateNamedNetDriver");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNamedNetDriver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNamedNetDriver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateNamedNetDriver_InWorld_Offset), 0, CreateNamedNetDriver_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateNamedNetDriver_NetDriverName_Offset), 0, CreateNamedNetDriver_NetDriverName_PropertyAddress.Address, NetDriverName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateNamedNetDriver_NetDriverDefinition_Offset), 0, CreateNamedNetDriver_NetDriverDefinition_PropertyAddress.Address, NetDriverDefinition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNamedNetDriver_FunctionAddress, intPtr, CreateNamedNetDriver_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CreateDragDropOperation")]
	public unsafe static UDragDropOperation CreateDragDropOperation(TSubclassOf<UDragDropOperation> OperationClass)
	{
		if (!CreateDragDropOperation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CreateDragDropOperation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDragDropOperation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDragDropOperation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, CreateDragDropOperation_OperationClass_Offset), 0, CreateDragDropOperation_OperationClass_PropertyAddress.Address, OperationClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateDragDropOperation_FunctionAddress, intPtr, CreateDragDropOperation_ParamsSize);
		return UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(intPtr, CreateDragDropOperation_ReturnValue_Offset), 0, CreateDragDropOperation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CreateAsset")]
	public unsafe static UObject CreateAsset(string Path, string Name, TSubclassOf<UObject> CreatedClass)
	{
		if (!CreateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CreateAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAsset_Path_Offset), 0, CreateAsset_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAsset_Name_Offset), 0, CreateAsset_Name_PropertyAddress.Address, Name);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateAsset_CreatedClass_Offset), 0, CreateAsset_CreatedClass_PropertyAddress.Address, CreatedClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAsset_FunctionAddress, intPtr, CreateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAsset_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateAsset_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CreateAsset_ReturnValue_Offset), 0, CreateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CopyToClipBoard")]
	public unsafe static void CopyToClipBoard(string InStr)
	{
		if (!CopyToClipBoard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CopyToClipBoard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyToClipBoard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyToClipBoard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CopyToClipBoard_InStr_Offset), 0, CopyToClipBoard_InStr_PropertyAddress.Address, InStr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyToClipBoard_FunctionAddress, intPtr, CopyToClipBoard_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyToClipBoard_InStr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVariableSetMouseCursor")]
	public unsafe static void ConsoleVariableSetMouseCursor(bool MouseCursor)
	{
		if (!ConsoleVariableSetMouseCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVariableSetMouseCursor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsoleVariableSetMouseCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsoleVariableSetMouseCursor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ConsoleVariableSetMouseCursor_MouseCursor_Offset), 0, ConsoleVariableSetMouseCursor_MouseCursor_PropertyAddress.Address, MouseCursor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConsoleVariableSetMouseCursor_FunctionAddress, intPtr, ConsoleVariableSetMouseCursor_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVarGetInt")]
	public unsafe static int ConsoleVarGetInt(string Name)
	{
		if (!ConsoleVarGetInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVarGetInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsoleVarGetInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsoleVarGetInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConsoleVarGetInt_Name_Offset), 0, ConsoleVarGetInt_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConsoleVarGetInt_FunctionAddress, intPtr, ConsoleVarGetInt_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConsoleVarGetInt_Name_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ConsoleVarGetInt_ReturnValue_Offset), 0, ConsoleVarGetInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CloseNetConnection")]
	public unsafe static void CloseNetConnection(UObject WorldContext)
	{
		if (!CloseNetConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CloseNetConnection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseNetConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseNetConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CloseNetConnection_WorldContext_Offset), 0, CloseNetConnection_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloseNetConnection_FunctionAddress, intPtr, CloseNetConnection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:ClientSeamlessTravel")]
	public unsafe static void ClientSeamlessTravel(APlayerController PC, string Url)
	{
		if (!ClientSeamlessTravel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:ClientSeamlessTravel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientSeamlessTravel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientSeamlessTravel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ClientSeamlessTravel_PC_Offset), 0, ClientSeamlessTravel_PC_PropertyAddress.Address, PC);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ClientSeamlessTravel_Url_Offset), 0, ClientSeamlessTravel_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClientSeamlessTravel_FunctionAddress, intPtr, ClientSeamlessTravel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClientSeamlessTravel_Url_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:CaptureCurrentViewport")]
	public unsafe static void CaptureCurrentViewport(bool bCapture)
	{
		if (!CaptureCurrentViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:CaptureCurrentViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureCurrentViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureCurrentViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CaptureCurrentViewport_bCapture_Offset), 0, CaptureCurrentViewport_bCapture_PropertyAddress.Address, bCapture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CaptureCurrentViewport_FunctionAddress, intPtr, CaptureCurrentViewport_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillSuspendedLevelsCompleted")]
	public unsafe static void BlockTillSuspendedLevelsCompleted(UObject WorldContextObject)
	{
		if (!BlockTillSuspendedLevelsCompleted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillSuspendedLevelsCompleted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlockTillSuspendedLevelsCompleted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlockTillSuspendedLevelsCompleted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BlockTillSuspendedLevelsCompleted_WorldContextObject_Offset), 0, BlockTillSuspendedLevelsCompleted_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BlockTillSuspendedLevelsCompleted_FunctionAddress, intPtr, BlockTillSuspendedLevelsCompleted_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillLevelStreamingCompleted")]
	public unsafe static void BlockTillLevelStreamingCompleted(UObject WorldContextObject)
	{
		if (!BlockTillLevelStreamingCompleted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillLevelStreamingCompleted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlockTillLevelStreamingCompleted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlockTillLevelStreamingCompleted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BlockTillLevelStreamingCompleted_WorldContextObject_Offset), 0, BlockTillLevelStreamingCompleted_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BlockTillLevelStreamingCompleted_FunctionAddress, intPtr, BlockTillLevelStreamingCompleted_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerTimeSeek")]
	public unsafe static void BinkMediaPlayerTimeSeek(UBinkMediaPlayer MediaPlayer, double Time)
	{
		if (!BinkMediaPlayerTimeSeek_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerTimeSeek");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BinkMediaPlayerTimeSeek_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BinkMediaPlayerTimeSeek_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerTimeSeek_MediaPlayer_Offset), 0, BinkMediaPlayerTimeSeek_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerTimeSeek_Time_Offset), 0, BinkMediaPlayerTimeSeek_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BinkMediaPlayerTimeSeek_FunctionAddress, intPtr, BinkMediaPlayerTimeSeek_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoToWithProcMs")]
	public unsafe static bool BinkMediaPlayerGoToWithProcMs(UBinkMediaPlayer MediaPlayer, int TargetFrame, int ProcMS)
	{
		if (!BinkMediaPlayerGoToWithProcMs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoToWithProcMs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BinkMediaPlayerGoToWithProcMs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BinkMediaPlayerGoToWithProcMs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerGoToWithProcMs_MediaPlayer_Offset), 0, BinkMediaPlayerGoToWithProcMs_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerGoToWithProcMs_TargetFrame_Offset), 0, BinkMediaPlayerGoToWithProcMs_TargetFrame_PropertyAddress.Address, TargetFrame);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerGoToWithProcMs_ProcMS_Offset), 0, BinkMediaPlayerGoToWithProcMs_ProcMS_PropertyAddress.Address, ProcMS);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BinkMediaPlayerGoToWithProcMs_FunctionAddress, intPtr, BinkMediaPlayerGoToWithProcMs_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BinkMediaPlayerGoToWithProcMs_ReturnValue_Offset), 0, BinkMediaPlayerGoToWithProcMs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoTo")]
	public unsafe static bool BinkMediaPlayerGoTo(UBinkMediaPlayer MediaPlayer, int TargetFrame)
	{
		if (!BinkMediaPlayerGoTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BinkMediaPlayerGoTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BinkMediaPlayerGoTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerGoTo_MediaPlayer_Offset), 0, BinkMediaPlayerGoTo_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BinkMediaPlayerGoTo_TargetFrame_Offset), 0, BinkMediaPlayerGoTo_TargetFrame_PropertyAddress.Address, TargetFrame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BinkMediaPlayerGoTo_FunctionAddress, intPtr, BinkMediaPlayerGoTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BinkMediaPlayerGoTo_ReturnValue_Offset), 0, BinkMediaPlayerGoTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:BindAudioUtilAndBox")]
	public unsafe static bool BindAudioUtilAndBox(AActor AudioUtilActor, UUserWidget AudioBox)
	{
		if (!BindAudioUtilAndBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:BindAudioUtilAndBox");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindAudioUtilAndBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindAudioUtilAndBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BindAudioUtilAndBox_AudioUtilActor_Offset), 0, BindAudioUtilAndBox_AudioUtilActor_PropertyAddress.Address, AudioUtilActor);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, BindAudioUtilAndBox_AudioBox_Offset), 0, BindAudioUtilAndBox_AudioBox_PropertyAddress.Address, AudioBox);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BindAudioUtilAndBox_FunctionAddress, intPtr, BindAudioUtilAndBox_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BindAudioUtilAndBox_ReturnValue_Offset), 0, BindAudioUtilAndBox_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:AsyncDownloadImage")]
	public unsafe static UAsyncTaskDownloadImage AsyncDownloadImage(string Url)
	{
		if (!AsyncDownloadImage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:AsyncDownloadImage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsyncDownloadImage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsyncDownloadImage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AsyncDownloadImage_Url_Offset), 0, AsyncDownloadImage_Url_PropertyAddress.Address, Url);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AsyncDownloadImage_FunctionAddress, intPtr, AsyncDownloadImage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AsyncDownloadImage_Url_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAsyncTaskDownloadImage>.FromNative(IntPtr.Add(intPtr, AsyncDownloadImage_ReturnValue_Offset), 0, AsyncDownloadImage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EngineFuncLib:AdjustPSOPrecompileBatch")]
	public unsafe static void AdjustPSOPrecompileBatch(int BatchSize = 1, float BatchTime = 0f)
	{
		if (!AdjustPSOPrecompileBatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EngineFuncLib:AdjustPSOPrecompileBatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdjustPSOPrecompileBatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdjustPSOPrecompileBatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AdjustPSOPrecompileBatch_BatchSize_Offset), 0, AdjustPSOPrecompileBatch_BatchSize_PropertyAddress.Address, BatchSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdjustPSOPrecompileBatch_BatchTime_Offset), 0, AdjustPSOPrecompileBatch_BatchTime_PropertyAddress.Address, BatchTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AdjustPSOPrecompileBatch_FunctionAddress, intPtr, AdjustPSOPrecompileBatch_ParamsSize);
	}

	static UGSE_EngineFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_EngineFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_EngineFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_EngineFuncLib");
		WasActorRecentlyRendered_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WasActorRecentlyRendered");
		WasActorRecentlyRendered_ParamsSize = NativeReflection.GetFunctionParamsSize(WasActorRecentlyRendered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasActorRecentlyRendered_InActor_PropertyAddress, WasActorRecentlyRendered_FunctionAddress, "InActor");
		WasActorRecentlyRendered_InActor_Offset = NativeReflectionCached.GetPropertyOffset(WasActorRecentlyRendered_FunctionAddress, "InActor");
		WasActorRecentlyRendered_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(WasActorRecentlyRendered_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WasActorRecentlyRendered_InTolerence_PropertyAddress, WasActorRecentlyRendered_FunctionAddress, "InTolerence");
		WasActorRecentlyRendered_InTolerence_Offset = NativeReflectionCached.GetPropertyOffset(WasActorRecentlyRendered_FunctionAddress, "InTolerence");
		WasActorRecentlyRendered_InTolerence_IsValid = NativeReflectionCached.ValidatePropertyClass(WasActorRecentlyRendered_FunctionAddress, "InTolerence", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WasActorRecentlyRendered_ReturnValue_PropertyAddress, WasActorRecentlyRendered_FunctionAddress, "ReturnValue");
		WasActorRecentlyRendered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasActorRecentlyRendered_FunctionAddress, "ReturnValue");
		WasActorRecentlyRendered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasActorRecentlyRendered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasActorRecentlyRendered_IsValid = WasActorRecentlyRendered_FunctionAddress != IntPtr.Zero && WasActorRecentlyRendered_InActor_IsValid && WasActorRecentlyRendered_InTolerence_IsValid && WasActorRecentlyRendered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:WasActorRecentlyRendered", WasActorRecentlyRendered_IsValid);
		VLogWLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogWLevel");
		VLogWLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogWLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogWLevel_WorldContext_PropertyAddress, VLogWLevel_FunctionAddress, "WorldContext");
		VLogWLevel_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogWLevel_FunctionAddress, "WorldContext");
		VLogWLevel_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWLevel_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogWLevel_InLogLevel_PropertyAddress, VLogWLevel_FunctionAddress, "InLogLevel");
		VLogWLevel_InLogLevel_Offset = NativeReflectionCached.GetPropertyOffset(VLogWLevel_FunctionAddress, "InLogLevel");
		VLogWLevel_InLogLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWLevel_FunctionAddress, "InLogLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogWLevel_Catogary_PropertyAddress, VLogWLevel_FunctionAddress, "Catogary");
		VLogWLevel_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogWLevel_FunctionAddress, "Catogary");
		VLogWLevel_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWLevel_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogWLevel_Text_PropertyAddress, VLogWLevel_FunctionAddress, "Text");
		VLogWLevel_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogWLevel_FunctionAddress, "Text");
		VLogWLevel_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWLevel_FunctionAddress, "Text", Classes.FStrProperty);
		VLogWLevel_IsValid = VLogWLevel_FunctionAddress != IntPtr.Zero && VLogWLevel_WorldContext_IsValid && VLogWLevel_InLogLevel_IsValid && VLogWLevel_Catogary_IsValid && VLogWLevel_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWLevel", VLogWLevel_IsValid);
		VLogWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogWarning");
		VLogWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogWarning_WorldContext_PropertyAddress, VLogWarning_FunctionAddress, "WorldContext");
		VLogWarning_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogWarning_FunctionAddress, "WorldContext");
		VLogWarning_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWarning_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogWarning_Catogary_PropertyAddress, VLogWarning_FunctionAddress, "Catogary");
		VLogWarning_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogWarning_FunctionAddress, "Catogary");
		VLogWarning_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWarning_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogWarning_Text_PropertyAddress, VLogWarning_FunctionAddress, "Text");
		VLogWarning_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogWarning_FunctionAddress, "Text");
		VLogWarning_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogWarning_FunctionAddress, "Text", Classes.FStrProperty);
		VLogWarning_IsValid = VLogWarning_FunctionAddress != IntPtr.Zero && VLogWarning_WorldContext_IsValid && VLogWarning_Catogary_IsValid && VLogWarning_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogWarning", VLogWarning_IsValid);
		VLogSegmentWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogSegmentWarning");
		VLogSegmentWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogSegmentWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_WorldContext_PropertyAddress, VLogSegmentWarning_FunctionAddress, "WorldContext");
		VLogSegmentWarning_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "WorldContext");
		VLogSegmentWarning_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_Catogary_PropertyAddress, VLogSegmentWarning_FunctionAddress, "Catogary");
		VLogSegmentWarning_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "Catogary");
		VLogSegmentWarning_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_SegmentStart_PropertyAddress, VLogSegmentWarning_FunctionAddress, "SegmentStart");
		VLogSegmentWarning_SegmentStart_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "SegmentStart");
		VLogSegmentWarning_SegmentStart_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "SegmentStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_SegmentEnd_PropertyAddress, VLogSegmentWarning_FunctionAddress, "SegmentEnd");
		VLogSegmentWarning_SegmentEnd_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "SegmentEnd");
		VLogSegmentWarning_SegmentEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "SegmentEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_Color_PropertyAddress, VLogSegmentWarning_FunctionAddress, "Color");
		VLogSegmentWarning_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "Color");
		VLogSegmentWarning_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_Thickness_PropertyAddress, VLogSegmentWarning_FunctionAddress, "Thickness");
		VLogSegmentWarning_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "Thickness");
		VLogSegmentWarning_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentWarning_Text_PropertyAddress, VLogSegmentWarning_FunctionAddress, "Text");
		VLogSegmentWarning_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentWarning_FunctionAddress, "Text");
		VLogSegmentWarning_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentWarning_FunctionAddress, "Text", Classes.FStrProperty);
		VLogSegmentWarning_IsValid = VLogSegmentWarning_FunctionAddress != IntPtr.Zero && VLogSegmentWarning_WorldContext_IsValid && VLogSegmentWarning_Catogary_IsValid && VLogSegmentWarning_SegmentStart_IsValid && VLogSegmentWarning_SegmentEnd_IsValid && VLogSegmentWarning_Color_IsValid && VLogSegmentWarning_Thickness_IsValid && VLogSegmentWarning_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentWarning", VLogSegmentWarning_IsValid);
		VLogSegmentInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogSegmentInfo");
		VLogSegmentInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogSegmentInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_WorldContext_PropertyAddress, VLogSegmentInfo_FunctionAddress, "WorldContext");
		VLogSegmentInfo_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "WorldContext");
		VLogSegmentInfo_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_Catogary_PropertyAddress, VLogSegmentInfo_FunctionAddress, "Catogary");
		VLogSegmentInfo_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "Catogary");
		VLogSegmentInfo_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_SegmentStart_PropertyAddress, VLogSegmentInfo_FunctionAddress, "SegmentStart");
		VLogSegmentInfo_SegmentStart_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "SegmentStart");
		VLogSegmentInfo_SegmentStart_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "SegmentStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_SegmentEnd_PropertyAddress, VLogSegmentInfo_FunctionAddress, "SegmentEnd");
		VLogSegmentInfo_SegmentEnd_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "SegmentEnd");
		VLogSegmentInfo_SegmentEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "SegmentEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_Color_PropertyAddress, VLogSegmentInfo_FunctionAddress, "Color");
		VLogSegmentInfo_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "Color");
		VLogSegmentInfo_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_Thickness_PropertyAddress, VLogSegmentInfo_FunctionAddress, "Thickness");
		VLogSegmentInfo_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "Thickness");
		VLogSegmentInfo_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentInfo_Text_PropertyAddress, VLogSegmentInfo_FunctionAddress, "Text");
		VLogSegmentInfo_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentInfo_FunctionAddress, "Text");
		VLogSegmentInfo_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentInfo_FunctionAddress, "Text", Classes.FStrProperty);
		VLogSegmentInfo_IsValid = VLogSegmentInfo_FunctionAddress != IntPtr.Zero && VLogSegmentInfo_WorldContext_IsValid && VLogSegmentInfo_Catogary_IsValid && VLogSegmentInfo_SegmentStart_IsValid && VLogSegmentInfo_SegmentEnd_IsValid && VLogSegmentInfo_Color_IsValid && VLogSegmentInfo_Thickness_IsValid && VLogSegmentInfo_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentInfo", VLogSegmentInfo_IsValid);
		VLogSegmentError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogSegmentError");
		VLogSegmentError_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogSegmentError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_WorldContext_PropertyAddress, VLogSegmentError_FunctionAddress, "WorldContext");
		VLogSegmentError_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "WorldContext");
		VLogSegmentError_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_Catogary_PropertyAddress, VLogSegmentError_FunctionAddress, "Catogary");
		VLogSegmentError_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "Catogary");
		VLogSegmentError_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_SegmentStart_PropertyAddress, VLogSegmentError_FunctionAddress, "SegmentStart");
		VLogSegmentError_SegmentStart_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "SegmentStart");
		VLogSegmentError_SegmentStart_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "SegmentStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_SegmentEnd_PropertyAddress, VLogSegmentError_FunctionAddress, "SegmentEnd");
		VLogSegmentError_SegmentEnd_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "SegmentEnd");
		VLogSegmentError_SegmentEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "SegmentEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_Color_PropertyAddress, VLogSegmentError_FunctionAddress, "Color");
		VLogSegmentError_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "Color");
		VLogSegmentError_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_Thickness_PropertyAddress, VLogSegmentError_FunctionAddress, "Thickness");
		VLogSegmentError_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "Thickness");
		VLogSegmentError_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogSegmentError_Text_PropertyAddress, VLogSegmentError_FunctionAddress, "Text");
		VLogSegmentError_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogSegmentError_FunctionAddress, "Text");
		VLogSegmentError_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogSegmentError_FunctionAddress, "Text", Classes.FStrProperty);
		VLogSegmentError_IsValid = VLogSegmentError_FunctionAddress != IntPtr.Zero && VLogSegmentError_WorldContext_IsValid && VLogSegmentError_Catogary_IsValid && VLogSegmentError_SegmentStart_IsValid && VLogSegmentError_SegmentEnd_IsValid && VLogSegmentError_Color_IsValid && VLogSegmentError_Thickness_IsValid && VLogSegmentError_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogSegmentError", VLogSegmentError_IsValid);
		VLogLocationWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogLocationWarning");
		VLogLocationWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogLocationWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_WorldContext_PropertyAddress, VLogLocationWarning_FunctionAddress, "WorldContext");
		VLogLocationWarning_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "WorldContext");
		VLogLocationWarning_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_Catogary_PropertyAddress, VLogLocationWarning_FunctionAddress, "Catogary");
		VLogLocationWarning_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "Catogary");
		VLogLocationWarning_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_Location_PropertyAddress, VLogLocationWarning_FunctionAddress, "Location");
		VLogLocationWarning_Location_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "Location");
		VLogLocationWarning_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_Radius_PropertyAddress, VLogLocationWarning_FunctionAddress, "Radius");
		VLogLocationWarning_Radius_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "Radius");
		VLogLocationWarning_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_Color_PropertyAddress, VLogLocationWarning_FunctionAddress, "Color");
		VLogLocationWarning_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "Color");
		VLogLocationWarning_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationWarning_Text_PropertyAddress, VLogLocationWarning_FunctionAddress, "Text");
		VLogLocationWarning_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationWarning_FunctionAddress, "Text");
		VLogLocationWarning_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationWarning_FunctionAddress, "Text", Classes.FStrProperty);
		VLogLocationWarning_IsValid = VLogLocationWarning_FunctionAddress != IntPtr.Zero && VLogLocationWarning_WorldContext_IsValid && VLogLocationWarning_Catogary_IsValid && VLogLocationWarning_Location_IsValid && VLogLocationWarning_Radius_IsValid && VLogLocationWarning_Color_IsValid && VLogLocationWarning_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationWarning", VLogLocationWarning_IsValid);
		VLogLocationInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogLocationInfo");
		VLogLocationInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogLocationInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_WorldContext_PropertyAddress, VLogLocationInfo_FunctionAddress, "WorldContext");
		VLogLocationInfo_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "WorldContext");
		VLogLocationInfo_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_Catogary_PropertyAddress, VLogLocationInfo_FunctionAddress, "Catogary");
		VLogLocationInfo_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "Catogary");
		VLogLocationInfo_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_Location_PropertyAddress, VLogLocationInfo_FunctionAddress, "Location");
		VLogLocationInfo_Location_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "Location");
		VLogLocationInfo_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_Radius_PropertyAddress, VLogLocationInfo_FunctionAddress, "Radius");
		VLogLocationInfo_Radius_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "Radius");
		VLogLocationInfo_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_Color_PropertyAddress, VLogLocationInfo_FunctionAddress, "Color");
		VLogLocationInfo_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "Color");
		VLogLocationInfo_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationInfo_Text_PropertyAddress, VLogLocationInfo_FunctionAddress, "Text");
		VLogLocationInfo_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationInfo_FunctionAddress, "Text");
		VLogLocationInfo_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationInfo_FunctionAddress, "Text", Classes.FStrProperty);
		VLogLocationInfo_IsValid = VLogLocationInfo_FunctionAddress != IntPtr.Zero && VLogLocationInfo_WorldContext_IsValid && VLogLocationInfo_Catogary_IsValid && VLogLocationInfo_Location_IsValid && VLogLocationInfo_Radius_IsValid && VLogLocationInfo_Color_IsValid && VLogLocationInfo_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationInfo", VLogLocationInfo_IsValid);
		VLogLocationError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogLocationError");
		VLogLocationError_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogLocationError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_WorldContext_PropertyAddress, VLogLocationError_FunctionAddress, "WorldContext");
		VLogLocationError_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "WorldContext");
		VLogLocationError_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_Catogary_PropertyAddress, VLogLocationError_FunctionAddress, "Catogary");
		VLogLocationError_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "Catogary");
		VLogLocationError_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_Location_PropertyAddress, VLogLocationError_FunctionAddress, "Location");
		VLogLocationError_Location_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "Location");
		VLogLocationError_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_Radius_PropertyAddress, VLogLocationError_FunctionAddress, "Radius");
		VLogLocationError_Radius_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "Radius");
		VLogLocationError_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_Color_PropertyAddress, VLogLocationError_FunctionAddress, "Color");
		VLogLocationError_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "Color");
		VLogLocationError_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogLocationError_Text_PropertyAddress, VLogLocationError_FunctionAddress, "Text");
		VLogLocationError_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogLocationError_FunctionAddress, "Text");
		VLogLocationError_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogLocationError_FunctionAddress, "Text", Classes.FStrProperty);
		VLogLocationError_IsValid = VLogLocationError_FunctionAddress != IntPtr.Zero && VLogLocationError_WorldContext_IsValid && VLogLocationError_Catogary_IsValid && VLogLocationError_Location_IsValid && VLogLocationError_Radius_IsValid && VLogLocationError_Color_IsValid && VLogLocationError_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogLocationError", VLogLocationError_IsValid);
		VLogInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogInfo");
		VLogInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogInfo_WorldContext_PropertyAddress, VLogInfo_FunctionAddress, "WorldContext");
		VLogInfo_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogInfo_FunctionAddress, "WorldContext");
		VLogInfo_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogInfo_Catogary_PropertyAddress, VLogInfo_FunctionAddress, "Catogary");
		VLogInfo_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogInfo_FunctionAddress, "Catogary");
		VLogInfo_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogInfo_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogInfo_Text_PropertyAddress, VLogInfo_FunctionAddress, "Text");
		VLogInfo_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogInfo_FunctionAddress, "Text");
		VLogInfo_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogInfo_FunctionAddress, "Text", Classes.FStrProperty);
		VLogInfo_IsValid = VLogInfo_FunctionAddress != IntPtr.Zero && VLogInfo_WorldContext_IsValid && VLogInfo_Catogary_IsValid && VLogInfo_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogInfo", VLogInfo_IsValid);
		VLogError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogError");
		VLogError_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogError_WorldContext_PropertyAddress, VLogError_FunctionAddress, "WorldContext");
		VLogError_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogError_FunctionAddress, "WorldContext");
		VLogError_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogError_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogError_Catogary_PropertyAddress, VLogError_FunctionAddress, "Catogary");
		VLogError_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogError_FunctionAddress, "Catogary");
		VLogError_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogError_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogError_Text_PropertyAddress, VLogError_FunctionAddress, "Text");
		VLogError_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogError_FunctionAddress, "Text");
		VLogError_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogError_FunctionAddress, "Text", Classes.FStrProperty);
		VLogError_IsValid = VLogError_FunctionAddress != IntPtr.Zero && VLogError_WorldContext_IsValid && VLogError_Catogary_IsValid && VLogError_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogError", VLogError_IsValid);
		VLogBoxWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogBoxWarning");
		VLogBoxWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogBoxWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxWarning_WorldContext_PropertyAddress, VLogBoxWarning_FunctionAddress, "WorldContext");
		VLogBoxWarning_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxWarning_FunctionAddress, "WorldContext");
		VLogBoxWarning_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxWarning_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxWarning_Catogary_PropertyAddress, VLogBoxWarning_FunctionAddress, "Catogary");
		VLogBoxWarning_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxWarning_FunctionAddress, "Catogary");
		VLogBoxWarning_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxWarning_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxWarning_Box_PropertyAddress, VLogBoxWarning_FunctionAddress, "Box");
		VLogBoxWarning_Box_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxWarning_FunctionAddress, "Box");
		VLogBoxWarning_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxWarning_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxWarning_Color_PropertyAddress, VLogBoxWarning_FunctionAddress, "Color");
		VLogBoxWarning_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxWarning_FunctionAddress, "Color");
		VLogBoxWarning_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxWarning_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxWarning_Text_PropertyAddress, VLogBoxWarning_FunctionAddress, "Text");
		VLogBoxWarning_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxWarning_FunctionAddress, "Text");
		VLogBoxWarning_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxWarning_FunctionAddress, "Text", Classes.FStrProperty);
		VLogBoxWarning_IsValid = VLogBoxWarning_FunctionAddress != IntPtr.Zero && VLogBoxWarning_WorldContext_IsValid && VLogBoxWarning_Catogary_IsValid && VLogBoxWarning_Box_IsValid && VLogBoxWarning_Color_IsValid && VLogBoxWarning_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxWarning", VLogBoxWarning_IsValid);
		VLogBoxInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogBoxInfo");
		VLogBoxInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogBoxInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxInfo_WorldContext_PropertyAddress, VLogBoxInfo_FunctionAddress, "WorldContext");
		VLogBoxInfo_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxInfo_FunctionAddress, "WorldContext");
		VLogBoxInfo_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxInfo_Catogary_PropertyAddress, VLogBoxInfo_FunctionAddress, "Catogary");
		VLogBoxInfo_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxInfo_FunctionAddress, "Catogary");
		VLogBoxInfo_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxInfo_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxInfo_Box_PropertyAddress, VLogBoxInfo_FunctionAddress, "Box");
		VLogBoxInfo_Box_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxInfo_FunctionAddress, "Box");
		VLogBoxInfo_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxInfo_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxInfo_Color_PropertyAddress, VLogBoxInfo_FunctionAddress, "Color");
		VLogBoxInfo_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxInfo_FunctionAddress, "Color");
		VLogBoxInfo_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxInfo_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxInfo_Text_PropertyAddress, VLogBoxInfo_FunctionAddress, "Text");
		VLogBoxInfo_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxInfo_FunctionAddress, "Text");
		VLogBoxInfo_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxInfo_FunctionAddress, "Text", Classes.FStrProperty);
		VLogBoxInfo_IsValid = VLogBoxInfo_FunctionAddress != IntPtr.Zero && VLogBoxInfo_WorldContext_IsValid && VLogBoxInfo_Catogary_IsValid && VLogBoxInfo_Box_IsValid && VLogBoxInfo_Color_IsValid && VLogBoxInfo_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxInfo", VLogBoxInfo_IsValid);
		VLogBoxError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VLogBoxError");
		VLogBoxError_ParamsSize = NativeReflection.GetFunctionParamsSize(VLogBoxError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxError_WorldContext_PropertyAddress, VLogBoxError_FunctionAddress, "WorldContext");
		VLogBoxError_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxError_FunctionAddress, "WorldContext");
		VLogBoxError_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxError_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxError_Catogary_PropertyAddress, VLogBoxError_FunctionAddress, "Catogary");
		VLogBoxError_Catogary_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxError_FunctionAddress, "Catogary");
		VLogBoxError_Catogary_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxError_FunctionAddress, "Catogary", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxError_Box_PropertyAddress, VLogBoxError_FunctionAddress, "Box");
		VLogBoxError_Box_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxError_FunctionAddress, "Box");
		VLogBoxError_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxError_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxError_Color_PropertyAddress, VLogBoxError_FunctionAddress, "Color");
		VLogBoxError_Color_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxError_FunctionAddress, "Color");
		VLogBoxError_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxError_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VLogBoxError_Text_PropertyAddress, VLogBoxError_FunctionAddress, "Text");
		VLogBoxError_Text_Offset = NativeReflectionCached.GetPropertyOffset(VLogBoxError_FunctionAddress, "Text");
		VLogBoxError_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(VLogBoxError_FunctionAddress, "Text", Classes.FStrProperty);
		VLogBoxError_IsValid = VLogBoxError_FunctionAddress != IntPtr.Zero && VLogBoxError_WorldContext_IsValid && VLogBoxError_Catogary_IsValid && VLogBoxError_Box_IsValid && VLogBoxError_Color_IsValid && VLogBoxError_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:VLogBoxError", VLogBoxError_IsValid);
		UseStatsMacro_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UseStatsMacro");
		UseStatsMacro_ParamsSize = NativeReflection.GetFunctionParamsSize(UseStatsMacro_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UseStatsMacro_ReturnValue_PropertyAddress, UseStatsMacro_FunctionAddress, "ReturnValue");
		UseStatsMacro_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UseStatsMacro_FunctionAddress, "ReturnValue");
		UseStatsMacro_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UseStatsMacro_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UseStatsMacro_IsValid = UseStatsMacro_FunctionAddress != IntPtr.Zero && UseStatsMacro_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:UseStatsMacro", UseStatsMacro_IsValid);
		UploadPSOHttpRequest_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UploadPSOHttpRequest");
		UploadPSOHttpRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(UploadPSOHttpRequest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UploadPSOHttpRequest_Num_PropertyAddress, UploadPSOHttpRequest_FunctionAddress, "Num");
		UploadPSOHttpRequest_Num_Offset = NativeReflectionCached.GetPropertyOffset(UploadPSOHttpRequest_FunctionAddress, "Num");
		UploadPSOHttpRequest_Num_IsValid = NativeReflectionCached.ValidatePropertyClass(UploadPSOHttpRequest_FunctionAddress, "Num", Classes.FIntProperty);
		UploadPSOHttpRequest_IsValid = UploadPSOHttpRequest_FunctionAddress != IntPtr.Zero && UploadPSOHttpRequest_Num_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:UploadPSOHttpRequest", UploadPSOHttpRequest_IsValid);
		UpdateAudioUtilAnalyzer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateAudioUtilAnalyzer");
		UpdateAudioUtilAnalyzer_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAudioUtilAnalyzer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAudioUtilAnalyzer_AudioUtilActor_PropertyAddress, UpdateAudioUtilAnalyzer_FunctionAddress, "AudioUtilActor");
		UpdateAudioUtilAnalyzer_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAudioUtilAnalyzer_FunctionAddress, "AudioUtilActor");
		UpdateAudioUtilAnalyzer_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAudioUtilAnalyzer_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_PropertyAddress, UpdateAudioUtilAnalyzer_FunctionAddress, "LoudnessAnalyzerAssetPath");
		UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAudioUtilAnalyzer_FunctionAddress, "LoudnessAnalyzerAssetPath");
		UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAudioUtilAnalyzer_FunctionAddress, "LoudnessAnalyzerAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_PropertyAddress, UpdateAudioUtilAnalyzer_FunctionAddress, "ConstantAnalyzerAssetPath");
		UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAudioUtilAnalyzer_FunctionAddress, "ConstantAnalyzerAssetPath");
		UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAudioUtilAnalyzer_FunctionAddress, "ConstantAnalyzerAssetPath", Classes.FStrProperty);
		UpdateAudioUtilAnalyzer_IsValid = UpdateAudioUtilAnalyzer_FunctionAddress != IntPtr.Zero && UpdateAudioUtilAnalyzer_AudioUtilActor_IsValid && UpdateAudioUtilAnalyzer_LoudnessAnalyzerAssetPath_IsValid && UpdateAudioUtilAnalyzer_ConstantAnalyzerAssetPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:UpdateAudioUtilAnalyzer", UpdateAudioUtilAnalyzer_IsValid);
		ToMilliseconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToMilliseconds");
		ToMilliseconds_ParamsSize = NativeReflection.GetFunctionParamsSize(ToMilliseconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToMilliseconds_Cycles_PropertyAddress, ToMilliseconds_FunctionAddress, "Cycles");
		ToMilliseconds_Cycles_Offset = NativeReflectionCached.GetPropertyOffset(ToMilliseconds_FunctionAddress, "Cycles");
		ToMilliseconds_Cycles_IsValid = NativeReflectionCached.ValidatePropertyClass(ToMilliseconds_FunctionAddress, "Cycles", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref ToMilliseconds_ReturnValue_PropertyAddress, ToMilliseconds_FunctionAddress, "ReturnValue");
		ToMilliseconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToMilliseconds_FunctionAddress, "ReturnValue");
		ToMilliseconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToMilliseconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		ToMilliseconds_IsValid = ToMilliseconds_FunctionAddress != IntPtr.Zero && ToMilliseconds_Cycles_IsValid && ToMilliseconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ToMilliseconds", ToMilliseconds_IsValid);
		TestPathSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TestPathSync");
		TestPathSync_ParamsSize = NativeReflection.GetFunctionParamsSize(TestPathSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TestPathSync_Controller_PropertyAddress, TestPathSync_FunctionAddress, "Controller");
		TestPathSync_Controller_Offset = NativeReflectionCached.GetPropertyOffset(TestPathSync_FunctionAddress, "Controller");
		TestPathSync_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(TestPathSync_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TestPathSync_TargetLocation_PropertyAddress, TestPathSync_FunctionAddress, "TargetLocation");
		TestPathSync_TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(TestPathSync_FunctionAddress, "TargetLocation");
		TestPathSync_TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(TestPathSync_FunctionAddress, "TargetLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TestPathSync_ReturnValue_PropertyAddress, TestPathSync_FunctionAddress, "ReturnValue");
		TestPathSync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TestPathSync_FunctionAddress, "ReturnValue");
		TestPathSync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TestPathSync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TestPathSync_IsValid = TestPathSync_FunctionAddress != IntPtr.Zero && TestPathSync_Controller_IsValid && TestPathSync_TargetLocation_IsValid && TestPathSync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:TestPathSync", TestPathSync_IsValid);
		StopAudio_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAudio");
		StopAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAudio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAudio_AudioUtilActor_PropertyAddress, StopAudio_FunctionAddress, "AudioUtilActor");
		StopAudio_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(StopAudio_FunctionAddress, "AudioUtilActor");
		StopAudio_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAudio_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		StopAudio_IsValid = StopAudio_FunctionAddress != IntPtr.Zero && StopAudio_AudioUtilActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:StopAudio", StopAudio_IsValid);
		SetPSOCacheUsageMask_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPSOCacheUsageMask");
		SetPSOCacheUsageMask_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPSOCacheUsageMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPSOCacheUsageMask_MapIndex_PropertyAddress, SetPSOCacheUsageMask_FunctionAddress, "MapIndex");
		SetPSOCacheUsageMask_MapIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetPSOCacheUsageMask_FunctionAddress, "MapIndex");
		SetPSOCacheUsageMask_MapIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPSOCacheUsageMask_FunctionAddress, "MapIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPSOCacheUsageMask_MaterialQualityLevel_PropertyAddress, SetPSOCacheUsageMask_FunctionAddress, "MaterialQualityLevel");
		SetPSOCacheUsageMask_MaterialQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetPSOCacheUsageMask_FunctionAddress, "MaterialQualityLevel");
		SetPSOCacheUsageMask_MaterialQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPSOCacheUsageMask_FunctionAddress, "MaterialQualityLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPSOCacheUsageMask_NiagaraQualityLevel_PropertyAddress, SetPSOCacheUsageMask_FunctionAddress, "NiagaraQualityLevel");
		SetPSOCacheUsageMask_NiagaraQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetPSOCacheUsageMask_FunctionAddress, "NiagaraQualityLevel");
		SetPSOCacheUsageMask_NiagaraQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPSOCacheUsageMask_FunctionAddress, "NiagaraQualityLevel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPSOCacheUsageMask_ShadowQualityLevel_PropertyAddress, SetPSOCacheUsageMask_FunctionAddress, "ShadowQualityLevel");
		SetPSOCacheUsageMask_ShadowQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetPSOCacheUsageMask_FunctionAddress, "ShadowQualityLevel");
		SetPSOCacheUsageMask_ShadowQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPSOCacheUsageMask_FunctionAddress, "ShadowQualityLevel", Classes.FIntProperty);
		SetPSOCacheUsageMask_IsValid = SetPSOCacheUsageMask_FunctionAddress != IntPtr.Zero && SetPSOCacheUsageMask_MapIndex_IsValid && SetPSOCacheUsageMask_MaterialQualityLevel_IsValid && SetPSOCacheUsageMask_NiagaraQualityLevel_IsValid && SetPSOCacheUsageMask_ShadowQualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetPSOCacheUsageMask", SetPSOCacheUsageMask_IsValid);
		SetMouseCursorWidgetVisible_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMouseCursorWidgetVisible");
		SetMouseCursorWidgetVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMouseCursorWidgetVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMouseCursorWidgetVisible_PlayerController_PropertyAddress, SetMouseCursorWidgetVisible_FunctionAddress, "PlayerController");
		SetMouseCursorWidgetVisible_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseCursorWidgetVisible_FunctionAddress, "PlayerController");
		SetMouseCursorWidgetVisible_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseCursorWidgetVisible_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMouseCursorWidgetVisible_bVisible_PropertyAddress, SetMouseCursorWidgetVisible_FunctionAddress, "bVisible");
		SetMouseCursorWidgetVisible_bVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseCursorWidgetVisible_FunctionAddress, "bVisible");
		SetMouseCursorWidgetVisible_bVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseCursorWidgetVisible_FunctionAddress, "bVisible", Classes.FBoolProperty);
		SetMouseCursorWidgetVisible_IsValid = SetMouseCursorWidgetVisible_FunctionAddress != IntPtr.Zero && SetMouseCursorWidgetVisible_PlayerController_IsValid && SetMouseCursorWidgetVisible_bVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetMouseCursorWidgetVisible", SetMouseCursorWidgetVisible_IsValid);
		SetLogEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLogEnable");
		SetLogEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLogEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLogEnable_bEnableDbg_PropertyAddress, SetLogEnable_FunctionAddress, "bEnableDbg");
		SetLogEnable_bEnableDbg_Offset = NativeReflectionCached.GetPropertyOffset(SetLogEnable_FunctionAddress, "bEnableDbg");
		SetLogEnable_bEnableDbg_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLogEnable_FunctionAddress, "bEnableDbg", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLogEnable_bEnableDbgDisplay_PropertyAddress, SetLogEnable_FunctionAddress, "bEnableDbgDisplay");
		SetLogEnable_bEnableDbgDisplay_Offset = NativeReflectionCached.GetPropertyOffset(SetLogEnable_FunctionAddress, "bEnableDbgDisplay");
		SetLogEnable_bEnableDbgDisplay_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLogEnable_FunctionAddress, "bEnableDbgDisplay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLogEnable_bEnableInfo_PropertyAddress, SetLogEnable_FunctionAddress, "bEnableInfo");
		SetLogEnable_bEnableInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetLogEnable_FunctionAddress, "bEnableInfo");
		SetLogEnable_bEnableInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLogEnable_FunctionAddress, "bEnableInfo", Classes.FBoolProperty);
		SetLogEnable_IsValid = SetLogEnable_FunctionAddress != IntPtr.Zero && SetLogEnable_bEnableDbg_IsValid && SetLogEnable_bEnableDbgDisplay_IsValid && SetLogEnable_bEnableInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetLogEnable", SetLogEnable_IsValid);
		SetLevelRequestSuspend_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLevelRequestSuspend");
		SetLevelRequestSuspend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelRequestSuspend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelRequestSuspend_ShouldSuspend_PropertyAddress, SetLevelRequestSuspend_FunctionAddress, "ShouldSuspend");
		SetLevelRequestSuspend_ShouldSuspend_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelRequestSuspend_FunctionAddress, "ShouldSuspend");
		SetLevelRequestSuspend_ShouldSuspend_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelRequestSuspend_FunctionAddress, "ShouldSuspend", Classes.FBoolProperty);
		SetLevelRequestSuspend_IsValid = SetLevelRequestSuspend_FunctionAddress != IntPtr.Zero && SetLevelRequestSuspend_ShouldSuspend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetLevelRequestSuspend", SetLevelRequestSuspend_IsValid);
		SetInputModeUIOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputModeUIOnly");
		SetInputModeUIOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputModeUIOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputModeUIOnly_Target_PropertyAddress, SetInputModeUIOnly_FunctionAddress, "Target");
		SetInputModeUIOnly_Target_Offset = NativeReflectionCached.GetPropertyOffset(SetInputModeUIOnly_FunctionAddress, "Target");
		SetInputModeUIOnly_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputModeUIOnly_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputModeUIOnly_InWidgetToFocus_PropertyAddress, SetInputModeUIOnly_FunctionAddress, "InWidgetToFocus");
		SetInputModeUIOnly_InWidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetInputModeUIOnly_FunctionAddress, "InWidgetToFocus");
		SetInputModeUIOnly_InWidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputModeUIOnly_FunctionAddress, "InWidgetToFocus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputModeUIOnly_InMouseLockMode_PropertyAddress, SetInputModeUIOnly_FunctionAddress, "InMouseLockMode");
		SetInputModeUIOnly_InMouseLockMode_Offset = NativeReflectionCached.GetPropertyOffset(SetInputModeUIOnly_FunctionAddress, "InMouseLockMode");
		SetInputModeUIOnly_InMouseLockMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputModeUIOnly_FunctionAddress, "InMouseLockMode", Classes.FEnumProperty);
		SetInputModeUIOnly_IsValid = SetInputModeUIOnly_FunctionAddress != IntPtr.Zero && SetInputModeUIOnly_Target_IsValid && SetInputModeUIOnly_InWidgetToFocus_IsValid && SetInputModeUIOnly_InMouseLockMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeUIOnly", SetInputModeUIOnly_IsValid);
		SetInputModeGameOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputModeGameOnly");
		SetInputModeGameOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputModeGameOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputModeGameOnly_PlayerController_PropertyAddress, SetInputModeGameOnly_FunctionAddress, "PlayerController");
		SetInputModeGameOnly_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetInputModeGameOnly_FunctionAddress, "PlayerController");
		SetInputModeGameOnly_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputModeGameOnly_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		SetInputModeGameOnly_IsValid = SetInputModeGameOnly_FunctionAddress != IntPtr.Zero && SetInputModeGameOnly_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputModeGameOnly", SetInputModeGameOnly_IsValid);
		SetInputDeadZone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputDeadZone");
		SetInputDeadZone_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputDeadZone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputDeadZone_PlayerController_PropertyAddress, SetInputDeadZone_FunctionAddress, "PlayerController");
		SetInputDeadZone_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetInputDeadZone_FunctionAddress, "PlayerController");
		SetInputDeadZone_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputDeadZone_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputDeadZone_AxisName_PropertyAddress, SetInputDeadZone_FunctionAddress, "AxisName");
		SetInputDeadZone_AxisName_Offset = NativeReflectionCached.GetPropertyOffset(SetInputDeadZone_FunctionAddress, "AxisName");
		SetInputDeadZone_AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputDeadZone_FunctionAddress, "AxisName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputDeadZone_DeadZone_PropertyAddress, SetInputDeadZone_FunctionAddress, "DeadZone");
		SetInputDeadZone_DeadZone_Offset = NativeReflectionCached.GetPropertyOffset(SetInputDeadZone_FunctionAddress, "DeadZone");
		SetInputDeadZone_DeadZone_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputDeadZone_FunctionAddress, "DeadZone", Classes.FFloatProperty);
		SetInputDeadZone_IsValid = SetInputDeadZone_FunctionAddress != IntPtr.Zero && SetInputDeadZone_PlayerController_IsValid && SetInputDeadZone_AxisName_IsValid && SetInputDeadZone_DeadZone_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetInputDeadZone", SetInputDeadZone_IsValid);
		SetDisplayGamma_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDisplayGamma");
		SetDisplayGamma_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayGamma_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayGamma_WorldCtx_PropertyAddress, SetDisplayGamma_FunctionAddress, "WorldCtx");
		SetDisplayGamma_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayGamma_FunctionAddress, "WorldCtx");
		SetDisplayGamma_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayGamma_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayGamma_Gamma_PropertyAddress, SetDisplayGamma_FunctionAddress, "Gamma");
		SetDisplayGamma_Gamma_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayGamma_FunctionAddress, "Gamma");
		SetDisplayGamma_Gamma_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayGamma_FunctionAddress, "Gamma", Classes.FFloatProperty);
		SetDisplayGamma_IsValid = SetDisplayGamma_FunctionAddress != IntPtr.Zero && SetDisplayGamma_WorldCtx_IsValid && SetDisplayGamma_Gamma_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetDisplayGamma", SetDisplayGamma_IsValid);
		SetDesiredQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDesiredQualityLevel");
		SetDesiredQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredQualityLevel_TargetGSQualityLevel_PropertyAddress, SetDesiredQualityLevel_FunctionAddress, "TargetGSQualityLevel");
		SetDesiredQualityLevel_TargetGSQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredQualityLevel_FunctionAddress, "TargetGSQualityLevel");
		SetDesiredQualityLevel_TargetGSQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredQualityLevel_FunctionAddress, "TargetGSQualityLevel", Classes.FEnumProperty);
		SetDesiredQualityLevel_IsValid = SetDesiredQualityLevel_FunctionAddress != IntPtr.Zero && SetDesiredQualityLevel_TargetGSQualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetDesiredQualityLevel", SetDesiredQualityLevel_IsValid);
		SetCanEverTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCanEverTick");
		SetCanEverTick_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCanEverTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCanEverTick_Obj_PropertyAddress, SetCanEverTick_FunctionAddress, "Obj");
		SetCanEverTick_Obj_Offset = NativeReflectionCached.GetPropertyOffset(SetCanEverTick_FunctionAddress, "Obj");
		SetCanEverTick_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanEverTick_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCanEverTick_bEnable_PropertyAddress, SetCanEverTick_FunctionAddress, "bEnable");
		SetCanEverTick_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetCanEverTick_FunctionAddress, "bEnable");
		SetCanEverTick_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanEverTick_FunctionAddress, "bEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCanEverTick_ReturnValue_PropertyAddress, SetCanEverTick_FunctionAddress, "ReturnValue");
		SetCanEverTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCanEverTick_FunctionAddress, "ReturnValue");
		SetCanEverTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanEverTick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCanEverTick_IsValid = SetCanEverTick_FunctionAddress != IntPtr.Zero && SetCanEverTick_Obj_IsValid && SetCanEverTick_bEnable_IsValid && SetCanEverTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetCanEverTick", SetCanEverTick_IsValid);
		SetAudioBoxFreqNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAudioBoxFreqNum");
		SetAudioBoxFreqNum_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioBoxFreqNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBoxFreqNum_AudioBox_PropertyAddress, SetAudioBoxFreqNum_FunctionAddress, "AudioBox");
		SetAudioBoxFreqNum_AudioBox_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBoxFreqNum_FunctionAddress, "AudioBox");
		SetAudioBoxFreqNum_AudioBox_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBoxFreqNum_FunctionAddress, "AudioBox", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBoxFreqNum_InFreqNum_PropertyAddress, SetAudioBoxFreqNum_FunctionAddress, "InFreqNum");
		SetAudioBoxFreqNum_InFreqNum_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBoxFreqNum_FunctionAddress, "InFreqNum");
		SetAudioBoxFreqNum_InFreqNum_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBoxFreqNum_FunctionAddress, "InFreqNum", Classes.FIntProperty);
		SetAudioBoxFreqNum_IsValid = SetAudioBoxFreqNum_FunctionAddress != IntPtr.Zero && SetAudioBoxFreqNum_AudioBox_IsValid && SetAudioBoxFreqNum_InFreqNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetAudioBoxFreqNum", SetAudioBoxFreqNum_IsValid);
		SetActorComponentMobilityMovable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorComponentMobilityMovable");
		SetActorComponentMobilityMovable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorComponentMobilityMovable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentMobilityMovable_Actor_PropertyAddress, SetActorComponentMobilityMovable_FunctionAddress, "Actor");
		SetActorComponentMobilityMovable_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentMobilityMovable_FunctionAddress, "Actor");
		SetActorComponentMobilityMovable_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentMobilityMovable_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorComponentMobilityMovable_IsMovable_PropertyAddress, SetActorComponentMobilityMovable_FunctionAddress, "IsMovable");
		SetActorComponentMobilityMovable_IsMovable_Offset = NativeReflectionCached.GetPropertyOffset(SetActorComponentMobilityMovable_FunctionAddress, "IsMovable");
		SetActorComponentMobilityMovable_IsMovable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorComponentMobilityMovable_FunctionAddress, "IsMovable", Classes.FBoolProperty);
		SetActorComponentMobilityMovable_IsValid = SetActorComponentMobilityMovable_FunctionAddress != IntPtr.Zero && SetActorComponentMobilityMovable_Actor_IsValid && SetActorComponentMobilityMovable_IsMovable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SetActorComponentMobilityMovable", SetActorComponentMobilityMovable_IsValid);
		ServerSeamlessTravel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ServerSeamlessTravel");
		ServerSeamlessTravel_ParamsSize = NativeReflection.GetFunctionParamsSize(ServerSeamlessTravel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ServerSeamlessTravel_World_PropertyAddress, ServerSeamlessTravel_FunctionAddress, "World");
		ServerSeamlessTravel_World_Offset = NativeReflectionCached.GetPropertyOffset(ServerSeamlessTravel_FunctionAddress, "World");
		ServerSeamlessTravel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(ServerSeamlessTravel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ServerSeamlessTravel_Url_PropertyAddress, ServerSeamlessTravel_FunctionAddress, "Url");
		ServerSeamlessTravel_Url_Offset = NativeReflectionCached.GetPropertyOffset(ServerSeamlessTravel_FunctionAddress, "Url");
		ServerSeamlessTravel_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(ServerSeamlessTravel_FunctionAddress, "Url", Classes.FStrProperty);
		ServerSeamlessTravel_IsValid = ServerSeamlessTravel_FunctionAddress != IntPtr.Zero && ServerSeamlessTravel_World_IsValid && ServerSeamlessTravel_Url_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ServerSeamlessTravel", ServerSeamlessTravel_IsValid);
		SaveStringToFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveStringToFile");
		SaveStringToFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveStringToFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveStringToFile_Path_PropertyAddress, SaveStringToFile_FunctionAddress, "Path");
		SaveStringToFile_Path_Offset = NativeReflectionCached.GetPropertyOffset(SaveStringToFile_FunctionAddress, "Path");
		SaveStringToFile_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveStringToFile_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveStringToFile_Data_PropertyAddress, SaveStringToFile_FunctionAddress, "Data");
		SaveStringToFile_Data_Offset = NativeReflectionCached.GetPropertyOffset(SaveStringToFile_FunctionAddress, "Data");
		SaveStringToFile_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveStringToFile_FunctionAddress, "Data", Classes.FStrProperty);
		SaveStringToFile_IsValid = SaveStringToFile_FunctionAddress != IntPtr.Zero && SaveStringToFile_Path_IsValid && SaveStringToFile_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SaveStringToFile", SaveStringToFile_IsValid);
		SavePSOCacheFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SavePSOCacheFile");
		SavePSOCacheFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SavePSOCacheFile_FunctionAddress);
		SavePSOCacheFile_IsValid = SavePSOCacheFile_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:SavePSOCacheFile", SavePSOCacheFile_IsValid);
		RunProcessWithCheck_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunProcessWithCheck");
		RunProcessWithCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(RunProcessWithCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunProcessWithCheck_InProcessPath_PropertyAddress, RunProcessWithCheck_FunctionAddress, "InProcessPath");
		RunProcessWithCheck_InProcessPath_Offset = NativeReflectionCached.GetPropertyOffset(RunProcessWithCheck_FunctionAddress, "InProcessPath");
		RunProcessWithCheck_InProcessPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RunProcessWithCheck_FunctionAddress, "InProcessPath", Classes.FStrProperty);
		RunProcessWithCheck_IsValid = RunProcessWithCheck_FunctionAddress != IntPtr.Zero && RunProcessWithCheck_InProcessPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcessWithCheck", RunProcessWithCheck_IsValid);
		RunProcess_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunProcess");
		RunProcess_ParamsSize = NativeReflection.GetFunctionParamsSize(RunProcess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunProcess_InProcessPath_PropertyAddress, RunProcess_FunctionAddress, "InProcessPath");
		RunProcess_InProcessPath_Offset = NativeReflectionCached.GetPropertyOffset(RunProcess_FunctionAddress, "InProcessPath");
		RunProcess_InProcessPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RunProcess_FunctionAddress, "InProcessPath", Classes.FStrProperty);
		RunProcess_IsValid = RunProcess_FunctionAddress != IntPtr.Zero && RunProcess_InProcessPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RunProcess", RunProcess_IsValid);
		ResumePsoBatching_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResumePsoBatching");
		ResumePsoBatching_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumePsoBatching_FunctionAddress);
		ResumePsoBatching_IsValid = ResumePsoBatching_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ResumePsoBatching", ResumePsoBatching_IsValid);
		RestartGame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RestartGame");
		RestartGame_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestartGame_GameMode_PropertyAddress, RestartGame_FunctionAddress, "GameMode");
		RestartGame_GameMode_Offset = NativeReflectionCached.GetPropertyOffset(RestartGame_FunctionAddress, "GameMode");
		RestartGame_GameMode_IsValid = NativeReflectionCached.ValidatePropertyClass(RestartGame_FunctionAddress, "GameMode", Classes.FObjectProperty);
		RestartGame_IsValid = RestartGame_FunctionAddress != IntPtr.Zero && RestartGame_GameMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RestartGame", RestartGame_IsValid);
		RestartApplication_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RestartApplication");
		RestartApplication_ParamsSize = NativeReflection.GetFunctionParamsSize(RestartApplication_FunctionAddress);
		RestartApplication_IsValid = RestartApplication_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RestartApplication", RestartApplication_IsValid);
		ResetAudioVisualizing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetAudioVisualizing");
		ResetAudioVisualizing_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetAudioVisualizing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetAudioVisualizing_AudioBox_PropertyAddress, ResetAudioVisualizing_FunctionAddress, "AudioBox");
		ResetAudioVisualizing_AudioBox_Offset = NativeReflectionCached.GetPropertyOffset(ResetAudioVisualizing_FunctionAddress, "AudioBox");
		ResetAudioVisualizing_AudioBox_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetAudioVisualizing_FunctionAddress, "AudioBox", Classes.FObjectProperty);
		ResetAudioVisualizing_IsValid = ResetAudioVisualizing_FunctionAddress != IntPtr.Zero && ResetAudioVisualizing_AudioBox_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ResetAudioVisualizing", ResetAudioVisualizing_IsValid);
		RequestQuit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestQuit");
		RequestQuit_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestQuit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestQuit_Desc_PropertyAddress, RequestQuit_FunctionAddress, "Desc");
		RequestQuit_Desc_Offset = NativeReflectionCached.GetPropertyOffset(RequestQuit_FunctionAddress, "Desc");
		RequestQuit_Desc_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestQuit_FunctionAddress, "Desc", Classes.FStrProperty);
		RequestQuit_IsValid = RequestQuit_FunctionAddress != IntPtr.Zero && RequestQuit_Desc_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RequestQuit", RequestQuit_IsValid);
		RequestExit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestExit");
		RequestExit_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestExit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestExit_Force_PropertyAddress, RequestExit_FunctionAddress, "Force");
		RequestExit_Force_Offset = NativeReflectionCached.GetPropertyOffset(RequestExit_FunctionAddress, "Force");
		RequestExit_Force_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestExit_FunctionAddress, "Force", Classes.FBoolProperty);
		RequestExit_IsValid = RequestExit_FunctionAddress != IntPtr.Zero && RequestExit_Force_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RequestExit", RequestExit_IsValid);
		ReplaceInputAxisList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceInputAxisList");
		ReplaceInputAxisList_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceInputAxisList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInputAxisList_PlayerController_PropertyAddress, ReplaceInputAxisList_FunctionAddress, "PlayerController");
		ReplaceInputAxisList_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInputAxisList_FunctionAddress, "PlayerController");
		ReplaceInputAxisList_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInputAxisList_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInputAxisList_AxisMappings_PropertyAddress, ReplaceInputAxisList_FunctionAddress, "AxisMappings");
		ReplaceInputAxisList_AxisMappings_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInputAxisList_FunctionAddress, "AxisMappings");
		ReplaceInputAxisList_AxisMappings_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInputAxisList_FunctionAddress, "AxisMappings", Classes.FArrayProperty);
		ReplaceInputAxisList_IsValid = ReplaceInputAxisList_FunctionAddress != IntPtr.Zero && ReplaceInputAxisList_PlayerController_IsValid && ReplaceInputAxisList_AxisMappings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputAxisList", ReplaceInputAxisList_IsValid);
		ReplaceInputActionList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceInputActionList");
		ReplaceInputActionList_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceInputActionList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInputActionList_PlayerController_PropertyAddress, ReplaceInputActionList_FunctionAddress, "PlayerController");
		ReplaceInputActionList_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInputActionList_FunctionAddress, "PlayerController");
		ReplaceInputActionList_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInputActionList_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceInputActionList_ActionMappings_PropertyAddress, ReplaceInputActionList_FunctionAddress, "ActionMappings");
		ReplaceInputActionList_ActionMappings_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceInputActionList_FunctionAddress, "ActionMappings");
		ReplaceInputActionList_ActionMappings_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceInputActionList_FunctionAddress, "ActionMappings", Classes.FArrayProperty);
		ReplaceInputActionList_IsValid = ReplaceInputActionList_FunctionAddress != IntPtr.Zero && ReplaceInputActionList_PlayerController_IsValid && ReplaceInputActionList_ActionMappings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ReplaceInputActionList", ReplaceInputActionList_IsValid);
		RegisterComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterComponent");
		RegisterComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterComponent_ActorComponent_PropertyAddress, RegisterComponent_FunctionAddress, "ActorComponent");
		RegisterComponent_ActorComponent_Offset = NativeReflectionCached.GetPropertyOffset(RegisterComponent_FunctionAddress, "ActorComponent");
		RegisterComponent_ActorComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterComponent_FunctionAddress, "ActorComponent", Classes.FObjectProperty);
		RegisterComponent_IsValid = RegisterComponent_FunctionAddress != IntPtr.Zero && RegisterComponent_ActorComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RegisterComponent", RegisterComponent_IsValid);
		RegisteConsoleKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisteConsoleKey");
		RegisteConsoleKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisteConsoleKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisteConsoleKey_Keys_PropertyAddress, RegisteConsoleKey_FunctionAddress, "Keys");
		RegisteConsoleKey_Keys_Offset = NativeReflectionCached.GetPropertyOffset(RegisteConsoleKey_FunctionAddress, "Keys");
		RegisteConsoleKey_Keys_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisteConsoleKey_FunctionAddress, "Keys", Classes.FArrayProperty);
		RegisteConsoleKey_IsValid = RegisteConsoleKey_FunctionAddress != IntPtr.Zero && RegisteConsoleKey_Keys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:RegisteConsoleKey", RegisteConsoleKey_IsValid);
		QuitGame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QuitGame");
		QuitGame_ParamsSize = NativeReflection.GetFunctionParamsSize(QuitGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QuitGame_WorldCtx_PropertyAddress, QuitGame_FunctionAddress, "WorldCtx");
		QuitGame_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(QuitGame_FunctionAddress, "WorldCtx");
		QuitGame_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(QuitGame_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		QuitGame_IsValid = QuitGame_FunctionAddress != IntPtr.Zero && QuitGame_WorldCtx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QuitGame", QuitGame_IsValid);
		QuitEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QuitEditor");
		QuitEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(QuitEditor_FunctionAddress);
		QuitEditor_IsValid = QuitEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QuitEditor", QuitEditor_IsValid);
		QAIsCompiling_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAIsCompiling");
		QAIsCompiling_ParamsSize = NativeReflection.GetFunctionParamsSize(QAIsCompiling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAIsCompiling_ReturnValue_PropertyAddress, QAIsCompiling_FunctionAddress, "ReturnValue");
		QAIsCompiling_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QAIsCompiling_FunctionAddress, "ReturnValue");
		QAIsCompiling_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QAIsCompiling_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QAIsCompiling_IsValid = QAIsCompiling_FunctionAddress != IntPtr.Zero && QAIsCompiling_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QAIsCompiling", QAIsCompiling_IsValid);
		QAHasReached_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAHasReached");
		QAHasReached_ParamsSize = NativeReflection.GetFunctionParamsSize(QAHasReached_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAHasReached_AgentActor_PropertyAddress, QAHasReached_FunctionAddress, "AgentActor");
		QAHasReached_AgentActor_Offset = NativeReflectionCached.GetPropertyOffset(QAHasReached_FunctionAddress, "AgentActor");
		QAHasReached_AgentActor_IsValid = NativeReflectionCached.ValidatePropertyClass(QAHasReached_FunctionAddress, "AgentActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAHasReached_GoalActor_PropertyAddress, QAHasReached_FunctionAddress, "GoalActor");
		QAHasReached_GoalActor_Offset = NativeReflectionCached.GetPropertyOffset(QAHasReached_FunctionAddress, "GoalActor");
		QAHasReached_GoalActor_IsValid = NativeReflectionCached.ValidatePropertyClass(QAHasReached_FunctionAddress, "GoalActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAHasReached_ReturnValue_PropertyAddress, QAHasReached_FunctionAddress, "ReturnValue");
		QAHasReached_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QAHasReached_FunctionAddress, "ReturnValue");
		QAHasReached_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QAHasReached_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QAHasReached_IsValid = QAHasReached_FunctionAddress != IntPtr.Zero && QAHasReached_AgentActor_IsValid && QAHasReached_GoalActor_IsValid && QAHasReached_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QAHasReached", QAHasReached_IsValid);
		QAGetSimpleCollisionCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAGetSimpleCollisionCylinder");
		QAGetSimpleCollisionCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetSimpleCollisionCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAGetSimpleCollisionCylinder_AgentActor_PropertyAddress, QAGetSimpleCollisionCylinder_FunctionAddress, "AgentActor");
		QAGetSimpleCollisionCylinder_AgentActor_Offset = NativeReflectionCached.GetPropertyOffset(QAGetSimpleCollisionCylinder_FunctionAddress, "AgentActor");
		QAGetSimpleCollisionCylinder_AgentActor_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetSimpleCollisionCylinder_FunctionAddress, "AgentActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetSimpleCollisionCylinder_CollisionRadius_PropertyAddress, QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionRadius");
		QAGetSimpleCollisionCylinder_CollisionRadius_Offset = NativeReflectionCached.GetPropertyOffset(QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionRadius");
		QAGetSimpleCollisionCylinder_CollisionRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetSimpleCollisionCylinder_CollisionHalfHeight_PropertyAddress, QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionHalfHeight");
		QAGetSimpleCollisionCylinder_CollisionHalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionHalfHeight");
		QAGetSimpleCollisionCylinder_CollisionHalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetSimpleCollisionCylinder_FunctionAddress, "CollisionHalfHeight", Classes.FFloatProperty);
		QAGetSimpleCollisionCylinder_IsValid = QAGetSimpleCollisionCylinder_FunctionAddress != IntPtr.Zero && QAGetSimpleCollisionCylinder_AgentActor_IsValid && QAGetSimpleCollisionCylinder_CollisionRadius_IsValid && QAGetSimpleCollisionCylinder_CollisionHalfHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QAGetSimpleCollisionCylinder", QAGetSimpleCollisionCylinder_IsValid);
		QAGenCrash_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAGenCrash");
		QAGenCrash_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGenCrash_FunctionAddress);
		QAGenCrash_IsValid = QAGenCrash_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:QAGenCrash", QAGenCrash_IsValid);
		PSOFullCompilation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PSOFullCompilation");
		PSOFullCompilation_ParamsSize = NativeReflection.GetFunctionParamsSize(PSOFullCompilation_FunctionAddress);
		PSOFullCompilation_IsValid = PSOFullCompilation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PSOFullCompilation", PSOFullCompilation_IsValid);
		PrepareLevelsNeedToBeUnloaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrepareLevelsNeedToBeUnloaded");
		PrepareLevelsNeedToBeUnloaded_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareLevelsNeedToBeUnloaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrepareLevelsNeedToBeUnloaded_WorldContextObject_PropertyAddress, PrepareLevelsNeedToBeUnloaded_FunctionAddress, "WorldContextObject");
		PrepareLevelsNeedToBeUnloaded_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PrepareLevelsNeedToBeUnloaded_FunctionAddress, "WorldContextObject");
		PrepareLevelsNeedToBeUnloaded_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PrepareLevelsNeedToBeUnloaded_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		PrepareLevelsNeedToBeUnloaded_IsValid = PrepareLevelsNeedToBeUnloaded_FunctionAddress != IntPtr.Zero && PrepareLevelsNeedToBeUnloaded_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PrepareLevelsNeedToBeUnloaded", PrepareLevelsNeedToBeUnloaded_IsValid);
		PlayAudio_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayAudio");
		PlayAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAudio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAudio_AudioUtilActor_PropertyAddress, PlayAudio_FunctionAddress, "AudioUtilActor");
		PlayAudio_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(PlayAudio_FunctionAddress, "AudioUtilActor");
		PlayAudio_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAudio_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAudio_VisualOnly_PropertyAddress, PlayAudio_FunctionAddress, "VisualOnly");
		PlayAudio_VisualOnly_Offset = NativeReflectionCached.GetPropertyOffset(PlayAudio_FunctionAddress, "VisualOnly");
		PlayAudio_VisualOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAudio_FunctionAddress, "VisualOnly", Classes.FBoolProperty);
		PlayAudio_IsValid = PlayAudio_FunctionAddress != IntPtr.Zero && PlayAudio_AudioUtilActor_IsValid && PlayAudio_VisualOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PlayAudio", PlayAudio_IsValid);
		PerfTest_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PerfTest");
		PerfTest_ParamsSize = NativeReflection.GetFunctionParamsSize(PerfTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerfTest_CaseID_PropertyAddress, PerfTest_FunctionAddress, "CaseID");
		PerfTest_CaseID_Offset = NativeReflectionCached.GetPropertyOffset(PerfTest_FunctionAddress, "CaseID");
		PerfTest_CaseID_IsValid = NativeReflectionCached.ValidatePropertyClass(PerfTest_FunctionAddress, "CaseID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PerfTest_Count_PropertyAddress, PerfTest_FunctionAddress, "Count");
		PerfTest_Count_Offset = NativeReflectionCached.GetPropertyOffset(PerfTest_FunctionAddress, "Count");
		PerfTest_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(PerfTest_FunctionAddress, "Count", Classes.FIntProperty);
		PerfTest_IsValid = PerfTest_FunctionAddress != IntPtr.Zero && PerfTest_CaseID_IsValid && PerfTest_Count_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PerfTest", PerfTest_IsValid);
		PausePsoBatching_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PausePsoBatching");
		PausePsoBatching_ParamsSize = NativeReflection.GetFunctionParamsSize(PausePsoBatching_FunctionAddress);
		PausePsoBatching_IsValid = PausePsoBatching_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PausePsoBatching", PausePsoBatching_IsValid);
		PauseAudio_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PauseAudio");
		PauseAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseAudio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseAudio_AudioUtilActor_PropertyAddress, PauseAudio_FunctionAddress, "AudioUtilActor");
		PauseAudio_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(PauseAudio_FunctionAddress, "AudioUtilActor");
		PauseAudio_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseAudio_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		PauseAudio_IsValid = PauseAudio_FunctionAddress != IntPtr.Zero && PauseAudio_AudioUtilActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:PauseAudio", PauseAudio_IsValid);
		MultipleColorLerp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MultipleColorLerp");
		MultipleColorLerp_ParamsSize = NativeReflection.GetFunctionParamsSize(MultipleColorLerp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_V1_PropertyAddress, MultipleColorLerp_FunctionAddress, "V1");
		MultipleColorLerp_V1_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "V1");
		MultipleColorLerp_V1_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "V1", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_V2_PropertyAddress, MultipleColorLerp_FunctionAddress, "V2");
		MultipleColorLerp_V2_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "V2");
		MultipleColorLerp_V2_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "V2", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_V3_PropertyAddress, MultipleColorLerp_FunctionAddress, "V3");
		MultipleColorLerp_V3_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "V3");
		MultipleColorLerp_V3_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "V3", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_V4_PropertyAddress, MultipleColorLerp_FunctionAddress, "V4");
		MultipleColorLerp_V4_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "V4");
		MultipleColorLerp_V4_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "V4", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_LerpAlpha_PropertyAddress, MultipleColorLerp_FunctionAddress, "LerpAlpha");
		MultipleColorLerp_LerpAlpha_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "LerpAlpha");
		MultipleColorLerp_LerpAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "LerpAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MultipleColorLerp_ReturnValue_PropertyAddress, MultipleColorLerp_FunctionAddress, "ReturnValue");
		MultipleColorLerp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MultipleColorLerp_FunctionAddress, "ReturnValue");
		MultipleColorLerp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MultipleColorLerp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MultipleColorLerp_IsValid = MultipleColorLerp_FunctionAddress != IntPtr.Zero && MultipleColorLerp_V1_IsValid && MultipleColorLerp_V2_IsValid && MultipleColorLerp_V3_IsValid && MultipleColorLerp_V4_IsValid && MultipleColorLerp_LerpAlpha_IsValid && MultipleColorLerp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MultipleColorLerp", MultipleColorLerp_IsValid);
		MediaPlayerTimeSeek_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MediaPlayerTimeSeek");
		MediaPlayerTimeSeek_ParamsSize = NativeReflection.GetFunctionParamsSize(MediaPlayerTimeSeek_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MediaPlayerTimeSeek_MediaPlayer_PropertyAddress, MediaPlayerTimeSeek_FunctionAddress, "MediaPlayer");
		MediaPlayerTimeSeek_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(MediaPlayerTimeSeek_FunctionAddress, "MediaPlayer");
		MediaPlayerTimeSeek_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(MediaPlayerTimeSeek_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MediaPlayerTimeSeek_Time_PropertyAddress, MediaPlayerTimeSeek_FunctionAddress, "Time");
		MediaPlayerTimeSeek_Time_Offset = NativeReflectionCached.GetPropertyOffset(MediaPlayerTimeSeek_FunctionAddress, "Time");
		MediaPlayerTimeSeek_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(MediaPlayerTimeSeek_FunctionAddress, "Time", Classes.FDoubleProperty);
		MediaPlayerTimeSeek_IsValid = MediaPlayerTimeSeek_FunctionAddress != IntPtr.Zero && MediaPlayerTimeSeek_MediaPlayer_IsValid && MediaPlayerTimeSeek_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MediaPlayerTimeSeek", MediaPlayerTimeSeek_IsValid);
		MathEaseV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MathEaseV");
		MathEaseV_ParamsSize = NativeReflection.GetFunctionParamsSize(MathEaseV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_A_PropertyAddress, MathEaseV_FunctionAddress, "A");
		MathEaseV_A_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "A");
		MathEaseV_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_B_PropertyAddress, MathEaseV_FunctionAddress, "B");
		MathEaseV_B_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "B");
		MathEaseV_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_Alpha_PropertyAddress, MathEaseV_FunctionAddress, "Alpha");
		MathEaseV_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "Alpha");
		MathEaseV_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_EasingFunc_PropertyAddress, MathEaseV_FunctionAddress, "EasingFunc");
		MathEaseV_EasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "EasingFunc");
		MathEaseV_EasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "EasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_BlendExp_PropertyAddress, MathEaseV_FunctionAddress, "BlendExp");
		MathEaseV_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "BlendExp");
		MathEaseV_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_Steps_PropertyAddress, MathEaseV_FunctionAddress, "Steps");
		MathEaseV_Steps_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "Steps");
		MathEaseV_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseV_ReturnValue_PropertyAddress, MathEaseV_FunctionAddress, "ReturnValue");
		MathEaseV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseV_FunctionAddress, "ReturnValue");
		MathEaseV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseV_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MathEaseV_IsValid = MathEaseV_FunctionAddress != IntPtr.Zero && MathEaseV_A_IsValid && MathEaseV_B_IsValid && MathEaseV_Alpha_IsValid && MathEaseV_EasingFunc_IsValid && MathEaseV_BlendExp_IsValid && MathEaseV_Steps_IsValid && MathEaseV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseV", MathEaseV_IsValid);
		MathEaseR_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MathEaseR");
		MathEaseR_ParamsSize = NativeReflection.GetFunctionParamsSize(MathEaseR_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_A_PropertyAddress, MathEaseR_FunctionAddress, "A");
		MathEaseR_A_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "A");
		MathEaseR_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_B_PropertyAddress, MathEaseR_FunctionAddress, "B");
		MathEaseR_B_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "B");
		MathEaseR_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_Alpha_PropertyAddress, MathEaseR_FunctionAddress, "Alpha");
		MathEaseR_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "Alpha");
		MathEaseR_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_bShortestPath_PropertyAddress, MathEaseR_FunctionAddress, "bShortestPath");
		MathEaseR_bShortestPath_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "bShortestPath");
		MathEaseR_bShortestPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "bShortestPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_EasingFunc_PropertyAddress, MathEaseR_FunctionAddress, "EasingFunc");
		MathEaseR_EasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "EasingFunc");
		MathEaseR_EasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "EasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_BlendExp_PropertyAddress, MathEaseR_FunctionAddress, "BlendExp");
		MathEaseR_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "BlendExp");
		MathEaseR_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_Steps_PropertyAddress, MathEaseR_FunctionAddress, "Steps");
		MathEaseR_Steps_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "Steps");
		MathEaseR_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseR_ReturnValue_PropertyAddress, MathEaseR_FunctionAddress, "ReturnValue");
		MathEaseR_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseR_FunctionAddress, "ReturnValue");
		MathEaseR_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseR_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MathEaseR_IsValid = MathEaseR_FunctionAddress != IntPtr.Zero && MathEaseR_A_IsValid && MathEaseR_B_IsValid && MathEaseR_Alpha_IsValid && MathEaseR_bShortestPath_IsValid && MathEaseR_EasingFunc_IsValid && MathEaseR_BlendExp_IsValid && MathEaseR_Steps_IsValid && MathEaseR_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseR", MathEaseR_IsValid);
		MathEaseLinearColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MathEaseLinearColor");
		MathEaseLinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(MathEaseLinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_A_PropertyAddress, MathEaseLinearColor_FunctionAddress, "A");
		MathEaseLinearColor_A_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "A");
		MathEaseLinearColor_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_B_PropertyAddress, MathEaseLinearColor_FunctionAddress, "B");
		MathEaseLinearColor_B_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "B");
		MathEaseLinearColor_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_Alpha_PropertyAddress, MathEaseLinearColor_FunctionAddress, "Alpha");
		MathEaseLinearColor_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "Alpha");
		MathEaseLinearColor_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_EasingFunc_PropertyAddress, MathEaseLinearColor_FunctionAddress, "EasingFunc");
		MathEaseLinearColor_EasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "EasingFunc");
		MathEaseLinearColor_EasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "EasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_BlendExp_PropertyAddress, MathEaseLinearColor_FunctionAddress, "BlendExp");
		MathEaseLinearColor_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "BlendExp");
		MathEaseLinearColor_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_Steps_PropertyAddress, MathEaseLinearColor_FunctionAddress, "Steps");
		MathEaseLinearColor_Steps_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "Steps");
		MathEaseLinearColor_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEaseLinearColor_ReturnValue_PropertyAddress, MathEaseLinearColor_FunctionAddress, "ReturnValue");
		MathEaseLinearColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MathEaseLinearColor_FunctionAddress, "ReturnValue");
		MathEaseLinearColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEaseLinearColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MathEaseLinearColor_IsValid = MathEaseLinearColor_FunctionAddress != IntPtr.Zero && MathEaseLinearColor_A_IsValid && MathEaseLinearColor_B_IsValid && MathEaseLinearColor_Alpha_IsValid && MathEaseLinearColor_EasingFunc_IsValid && MathEaseLinearColor_BlendExp_IsValid && MathEaseLinearColor_Steps_IsValid && MathEaseLinearColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MathEaseLinearColor", MathEaseLinearColor_IsValid);
		MathEase2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MathEase2D");
		MathEase2D_ParamsSize = NativeReflection.GetFunctionParamsSize(MathEase2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_A_PropertyAddress, MathEase2D_FunctionAddress, "A");
		MathEase2D_A_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "A");
		MathEase2D_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_B_PropertyAddress, MathEase2D_FunctionAddress, "B");
		MathEase2D_B_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "B");
		MathEase2D_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_Alpha_PropertyAddress, MathEase2D_FunctionAddress, "Alpha");
		MathEase2D_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "Alpha");
		MathEase2D_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_EasingFunc_PropertyAddress, MathEase2D_FunctionAddress, "EasingFunc");
		MathEase2D_EasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "EasingFunc");
		MathEase2D_EasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "EasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_BlendExp_PropertyAddress, MathEase2D_FunctionAddress, "BlendExp");
		MathEase2D_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "BlendExp");
		MathEase2D_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_Steps_PropertyAddress, MathEase2D_FunctionAddress, "Steps");
		MathEase2D_Steps_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "Steps");
		MathEase2D_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase2D_ReturnValue_PropertyAddress, MathEase2D_FunctionAddress, "ReturnValue");
		MathEase2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MathEase2D_FunctionAddress, "ReturnValue");
		MathEase2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MathEase2D_IsValid = MathEase2D_FunctionAddress != IntPtr.Zero && MathEase2D_A_IsValid && MathEase2D_B_IsValid && MathEase2D_Alpha_IsValid && MathEase2D_EasingFunc_IsValid && MathEase2D_BlendExp_IsValid && MathEase2D_Steps_IsValid && MathEase2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase2D", MathEase2D_IsValid);
		MathEase_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MathEase");
		MathEase_ParamsSize = NativeReflection.GetFunctionParamsSize(MathEase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MathEase_A_PropertyAddress, MathEase_FunctionAddress, "A");
		MathEase_A_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "A");
		MathEase_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "A", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_B_PropertyAddress, MathEase_FunctionAddress, "B");
		MathEase_B_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "B");
		MathEase_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "B", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_Alpha_PropertyAddress, MathEase_FunctionAddress, "Alpha");
		MathEase_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "Alpha");
		MathEase_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_EasingFunc_PropertyAddress, MathEase_FunctionAddress, "EasingFunc");
		MathEase_EasingFunc_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "EasingFunc");
		MathEase_EasingFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "EasingFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_BlendExp_PropertyAddress, MathEase_FunctionAddress, "BlendExp");
		MathEase_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "BlendExp");
		MathEase_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_Steps_PropertyAddress, MathEase_FunctionAddress, "Steps");
		MathEase_Steps_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "Steps");
		MathEase_Steps_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "Steps", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MathEase_ReturnValue_PropertyAddress, MathEase_FunctionAddress, "ReturnValue");
		MathEase_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MathEase_FunctionAddress, "ReturnValue");
		MathEase_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MathEase_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		MathEase_IsValid = MathEase_FunctionAddress != IntPtr.Zero && MathEase_A_IsValid && MathEase_B_IsValid && MathEase_Alpha_IsValid && MathEase_EasingFunc_IsValid && MathEase_BlendExp_IsValid && MathEase_Steps_IsValid && MathEase_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MathEase", MathEase_IsValid);
		MarkUnloadPsoState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkUnloadPsoState");
		MarkUnloadPsoState_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkUnloadPsoState_FunctionAddress);
		MarkUnloadPsoState_IsValid = MarkUnloadPsoState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:MarkUnloadPsoState", MarkUnloadPsoState_IsValid);
		LogWLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogWLevel");
		LogWLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(LogWLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogWLevel_Str_PropertyAddress, LogWLevel_FunctionAddress, "Str");
		LogWLevel_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogWLevel_FunctionAddress, "Str");
		LogWLevel_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogWLevel_FunctionAddress, "Str", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogWLevel_InLogLevel_PropertyAddress, LogWLevel_FunctionAddress, "InLogLevel");
		LogWLevel_InLogLevel_Offset = NativeReflectionCached.GetPropertyOffset(LogWLevel_FunctionAddress, "InLogLevel");
		LogWLevel_InLogLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(LogWLevel_FunctionAddress, "InLogLevel", Classes.FIntProperty);
		LogWLevel_IsValid = LogWLevel_FunctionAddress != IntPtr.Zero && LogWLevel_Str_IsValid && LogWLevel_InLogLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogWLevel", LogWLevel_IsValid);
		LogWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogWarning");
		LogWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(LogWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogWarning_Str_PropertyAddress, LogWarning_FunctionAddress, "Str");
		LogWarning_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogWarning_FunctionAddress, "Str");
		LogWarning_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogWarning_FunctionAddress, "Str", Classes.FStrProperty);
		LogWarning_IsValid = LogWarning_FunctionAddress != IntPtr.Zero && LogWarning_Str_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogWarning", LogWarning_IsValid);
		LogShippingError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogShippingError");
		LogShippingError_ParamsSize = NativeReflection.GetFunctionParamsSize(LogShippingError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogShippingError_Str_PropertyAddress, LogShippingError_FunctionAddress, "Str");
		LogShippingError_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogShippingError_FunctionAddress, "Str");
		LogShippingError_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogShippingError_FunctionAddress, "Str", Classes.FStrProperty);
		LogShippingError_IsValid = LogShippingError_FunctionAddress != IntPtr.Zero && LogShippingError_Str_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogShippingError", LogShippingError_IsValid);
		LogShipping_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogShipping");
		LogShipping_ParamsSize = NativeReflection.GetFunctionParamsSize(LogShipping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogShipping_Str_PropertyAddress, LogShipping_FunctionAddress, "Str");
		LogShipping_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogShipping_FunctionAddress, "Str");
		LogShipping_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogShipping_FunctionAddress, "Str", Classes.FStrProperty);
		LogShipping_IsValid = LogShipping_FunctionAddress != IntPtr.Zero && LogShipping_Str_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogShipping", LogShipping_IsValid);
		LogInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogInfo");
		LogInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(LogInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogInfo_Str_PropertyAddress, LogInfo_FunctionAddress, "Str");
		LogInfo_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogInfo_FunctionAddress, "Str");
		LogInfo_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogInfo_FunctionAddress, "Str", Classes.FStrProperty);
		LogInfo_IsValid = LogInfo_FunctionAddress != IntPtr.Zero && LogInfo_Str_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogInfo", LogInfo_IsValid);
		LogError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogError");
		LogError_ParamsSize = NativeReflection.GetFunctionParamsSize(LogError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogError_Str_PropertyAddress, LogError_FunctionAddress, "Str");
		LogError_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogError_FunctionAddress, "Str");
		LogError_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogError_FunctionAddress, "Str", Classes.FStrProperty);
		LogError_IsValid = LogError_FunctionAddress != IntPtr.Zero && LogError_Str_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogError", LogError_IsValid);
		LogDbgWithColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogDbgWithColor");
		LogDbgWithColor_ParamsSize = NativeReflection.GetFunctionParamsSize(LogDbgWithColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogDbgWithColor_Str_PropertyAddress, LogDbgWithColor_FunctionAddress, "Str");
		LogDbgWithColor_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogDbgWithColor_FunctionAddress, "Str");
		LogDbgWithColor_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbgWithColor_FunctionAddress, "Str", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbgWithColor_bPrintScreen_PropertyAddress, LogDbgWithColor_FunctionAddress, "bPrintScreen");
		LogDbgWithColor_bPrintScreen_Offset = NativeReflectionCached.GetPropertyOffset(LogDbgWithColor_FunctionAddress, "bPrintScreen");
		LogDbgWithColor_bPrintScreen_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbgWithColor_FunctionAddress, "bPrintScreen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbgWithColor_TimeToDisplay_PropertyAddress, LogDbgWithColor_FunctionAddress, "TimeToDisplay");
		LogDbgWithColor_TimeToDisplay_Offset = NativeReflectionCached.GetPropertyOffset(LogDbgWithColor_FunctionAddress, "TimeToDisplay");
		LogDbgWithColor_TimeToDisplay_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbgWithColor_FunctionAddress, "TimeToDisplay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbgWithColor_Color_PropertyAddress, LogDbgWithColor_FunctionAddress, "Color");
		LogDbgWithColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(LogDbgWithColor_FunctionAddress, "Color");
		LogDbgWithColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbgWithColor_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbgWithColor_key_PropertyAddress, LogDbgWithColor_FunctionAddress, "key");
		LogDbgWithColor_key_Offset = NativeReflectionCached.GetPropertyOffset(LogDbgWithColor_FunctionAddress, "key");
		LogDbgWithColor_key_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbgWithColor_FunctionAddress, "key", Classes.FIntProperty);
		LogDbgWithColor_IsValid = LogDbgWithColor_FunctionAddress != IntPtr.Zero && LogDbgWithColor_Str_IsValid && LogDbgWithColor_bPrintScreen_IsValid && LogDbgWithColor_TimeToDisplay_IsValid && LogDbgWithColor_Color_IsValid && LogDbgWithColor_key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbgWithColor", LogDbgWithColor_IsValid);
		LogDbg_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogDbg");
		LogDbg_ParamsSize = NativeReflection.GetFunctionParamsSize(LogDbg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogDbg_Str_PropertyAddress, LogDbg_FunctionAddress, "Str");
		LogDbg_Str_Offset = NativeReflectionCached.GetPropertyOffset(LogDbg_FunctionAddress, "Str");
		LogDbg_Str_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbg_FunctionAddress, "Str", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbg_bPrintScreen_PropertyAddress, LogDbg_FunctionAddress, "bPrintScreen");
		LogDbg_bPrintScreen_Offset = NativeReflectionCached.GetPropertyOffset(LogDbg_FunctionAddress, "bPrintScreen");
		LogDbg_bPrintScreen_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbg_FunctionAddress, "bPrintScreen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LogDbg_TimeToDisplay_PropertyAddress, LogDbg_FunctionAddress, "TimeToDisplay");
		LogDbg_TimeToDisplay_Offset = NativeReflectionCached.GetPropertyOffset(LogDbg_FunctionAddress, "TimeToDisplay");
		LogDbg_TimeToDisplay_IsValid = NativeReflectionCached.ValidatePropertyClass(LogDbg_FunctionAddress, "TimeToDisplay", Classes.FFloatProperty);
		LogDbg_IsValid = LogDbg_FunctionAddress != IntPtr.Zero && LogDbg_Str_IsValid && LogDbg_bPrintScreen_IsValid && LogDbg_TimeToDisplay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LogDbg", LogDbg_IsValid);
		LoadFileToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadFileToString");
		LoadFileToString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadFileToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToString_Path_PropertyAddress, LoadFileToString_FunctionAddress, "Path");
		LoadFileToString_Path_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToString_FunctionAddress, "Path");
		LoadFileToString_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToString_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToString_ReturnValue_PropertyAddress, LoadFileToString_FunctionAddress, "ReturnValue");
		LoadFileToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToString_FunctionAddress, "ReturnValue");
		LoadFileToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		LoadFileToString_IsValid = LoadFileToString_FunctionAddress != IntPtr.Zero && LoadFileToString_Path_IsValid && LoadFileToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:LoadFileToString", LoadFileToString_IsValid);
		IsUnloadPSOFinished_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsUnloadPSOFinished");
		IsUnloadPSOFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUnloadPSOFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUnloadPSOFinished_ReturnValue_PropertyAddress, IsUnloadPSOFinished_FunctionAddress, "ReturnValue");
		IsUnloadPSOFinished_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUnloadPSOFinished_FunctionAddress, "ReturnValue");
		IsUnloadPSOFinished_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnloadPSOFinished_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUnloadPSOFinished_IsValid = IsUnloadPSOFinished_FunctionAddress != IntPtr.Zero && IsUnloadPSOFinished_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsUnloadPSOFinished", IsUnloadPSOFinished_IsValid);
		IsTestBuild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTestBuild");
		IsTestBuild_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTestBuild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTestBuild_ReturnValue_PropertyAddress, IsTestBuild_FunctionAddress, "ReturnValue");
		IsTestBuild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTestBuild_FunctionAddress, "ReturnValue");
		IsTestBuild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTestBuild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTestBuild_IsValid = IsTestBuild_FunctionAddress != IntPtr.Zero && IsTestBuild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsTestBuild", IsTestBuild_IsValid);
		IsStandaloneGame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStandaloneGame");
		IsStandaloneGame_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStandaloneGame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStandaloneGame_ReturnValue_PropertyAddress, IsStandaloneGame_FunctionAddress, "ReturnValue");
		IsStandaloneGame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStandaloneGame_FunctionAddress, "ReturnValue");
		IsStandaloneGame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStandaloneGame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStandaloneGame_IsValid = IsStandaloneGame_FunctionAddress != IntPtr.Zero && IsStandaloneGame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandaloneGame", IsStandaloneGame_IsValid);
		IsStandAlone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStandAlone");
		IsStandAlone_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStandAlone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStandAlone_World_PropertyAddress, IsStandAlone_FunctionAddress, "World");
		IsStandAlone_World_Offset = NativeReflectionCached.GetPropertyOffset(IsStandAlone_FunctionAddress, "World");
		IsStandAlone_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStandAlone_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStandAlone_ReturnValue_PropertyAddress, IsStandAlone_FunctionAddress, "ReturnValue");
		IsStandAlone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStandAlone_FunctionAddress, "ReturnValue");
		IsStandAlone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStandAlone_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStandAlone_IsValid = IsStandAlone_FunctionAddress != IntPtr.Zero && IsStandAlone_World_IsValid && IsStandAlone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsStandAlone", IsStandAlone_IsValid);
		IsShippingBuild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsShippingBuild");
		IsShippingBuild_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShippingBuild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShippingBuild_ReturnValue_PropertyAddress, IsShippingBuild_FunctionAddress, "ReturnValue");
		IsShippingBuild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShippingBuild_FunctionAddress, "ReturnValue");
		IsShippingBuild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShippingBuild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShippingBuild_IsValid = IsShippingBuild_FunctionAddress != IntPtr.Zero && IsShippingBuild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsShippingBuild", IsShippingBuild_IsValid);
		IsSavePSOCacheInErrorState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSavePSOCacheInErrorState");
		IsSavePSOCacheInErrorState_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSavePSOCacheInErrorState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSavePSOCacheInErrorState_ReturnValue_PropertyAddress, IsSavePSOCacheInErrorState_FunctionAddress, "ReturnValue");
		IsSavePSOCacheInErrorState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSavePSOCacheInErrorState_FunctionAddress, "ReturnValue");
		IsSavePSOCacheInErrorState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSavePSOCacheInErrorState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSavePSOCacheInErrorState_IsValid = IsSavePSOCacheInErrorState_FunctionAddress != IntPtr.Zero && IsSavePSOCacheInErrorState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsSavePSOCacheInErrorState", IsSavePSOCacheInErrorState_IsValid);
		IsRegexMatched_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRegexMatched");
		IsRegexMatched_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRegexMatched_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRegexMatched_InStr_PropertyAddress, IsRegexMatched_FunctionAddress, "InStr");
		IsRegexMatched_InStr_Offset = NativeReflectionCached.GetPropertyOffset(IsRegexMatched_FunctionAddress, "InStr");
		IsRegexMatched_InStr_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegexMatched_FunctionAddress, "InStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRegexMatched_RegexExpression_PropertyAddress, IsRegexMatched_FunctionAddress, "RegexExpression");
		IsRegexMatched_RegexExpression_Offset = NativeReflectionCached.GetPropertyOffset(IsRegexMatched_FunctionAddress, "RegexExpression");
		IsRegexMatched_RegexExpression_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegexMatched_FunctionAddress, "RegexExpression", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRegexMatched_ReturnValue_PropertyAddress, IsRegexMatched_FunctionAddress, "ReturnValue");
		IsRegexMatched_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRegexMatched_FunctionAddress, "ReturnValue");
		IsRegexMatched_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRegexMatched_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRegexMatched_IsValid = IsRegexMatched_FunctionAddress != IntPtr.Zero && IsRegexMatched_InStr_IsValid && IsRegexMatched_RegexExpression_IsValid && IsRegexMatched_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsRegexMatched", IsRegexMatched_IsValid);
		IsPSOBatchingPaused_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPSOBatchingPaused");
		IsPSOBatchingPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPSOBatchingPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPSOBatchingPaused_ReturnValue_PropertyAddress, IsPSOBatchingPaused_FunctionAddress, "ReturnValue");
		IsPSOBatchingPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPSOBatchingPaused_FunctionAddress, "ReturnValue");
		IsPSOBatchingPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPSOBatchingPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPSOBatchingPaused_IsValid = IsPSOBatchingPaused_FunctionAddress != IntPtr.Zero && IsPSOBatchingPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsPSOBatchingPaused", IsPSOBatchingPaused_IsValid);
		IsListenServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsListenServer");
		IsListenServer_ParamsSize = NativeReflection.GetFunctionParamsSize(IsListenServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsListenServer_World_PropertyAddress, IsListenServer_FunctionAddress, "World");
		IsListenServer_World_Offset = NativeReflectionCached.GetPropertyOffset(IsListenServer_FunctionAddress, "World");
		IsListenServer_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsListenServer_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsListenServer_ReturnValue_PropertyAddress, IsListenServer_FunctionAddress, "ReturnValue");
		IsListenServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsListenServer_FunctionAddress, "ReturnValue");
		IsListenServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsListenServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsListenServer_IsValid = IsListenServer_FunctionAddress != IntPtr.Zero && IsListenServer_World_IsValid && IsListenServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsListenServer", IsListenServer_IsValid);
		IsEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEditor");
		IsEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEditor_ReturnValue_PropertyAddress, IsEditor_FunctionAddress, "ReturnValue");
		IsEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEditor_FunctionAddress, "ReturnValue");
		IsEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditor_IsValid = IsEditor_FunctionAddress != IntPtr.Zero && IsEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsEditor", IsEditor_IsValid);
		IsDriverVersionMismatch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDriverVersionMismatch");
		IsDriverVersionMismatch_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDriverVersionMismatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDriverVersionMismatch_ReturnValue_PropertyAddress, IsDriverVersionMismatch_FunctionAddress, "ReturnValue");
		IsDriverVersionMismatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDriverVersionMismatch_FunctionAddress, "ReturnValue");
		IsDriverVersionMismatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDriverVersionMismatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDriverVersionMismatch_IsValid = IsDriverVersionMismatch_FunctionAddress != IntPtr.Zero && IsDriverVersionMismatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsDriverVersionMismatch", IsDriverVersionMismatch_IsValid);
		IsDevelopmentBuild_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDevelopmentBuild");
		IsDevelopmentBuild_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDevelopmentBuild_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDevelopmentBuild_ReturnValue_PropertyAddress, IsDevelopmentBuild_FunctionAddress, "ReturnValue");
		IsDevelopmentBuild_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDevelopmentBuild_FunctionAddress, "ReturnValue");
		IsDevelopmentBuild_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDevelopmentBuild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDevelopmentBuild_IsValid = IsDevelopmentBuild_FunctionAddress != IntPtr.Zero && IsDevelopmentBuild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsDevelopmentBuild", IsDevelopmentBuild_IsValid);
		IsDedicateServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDedicateServer");
		IsDedicateServer_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDedicateServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDedicateServer_World_PropertyAddress, IsDedicateServer_FunctionAddress, "World");
		IsDedicateServer_World_Offset = NativeReflectionCached.GetPropertyOffset(IsDedicateServer_FunctionAddress, "World");
		IsDedicateServer_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDedicateServer_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDedicateServer_ReturnValue_PropertyAddress, IsDedicateServer_FunctionAddress, "ReturnValue");
		IsDedicateServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDedicateServer_FunctionAddress, "ReturnValue");
		IsDedicateServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDedicateServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDedicateServer_IsValid = IsDedicateServer_FunctionAddress != IntPtr.Zero && IsDedicateServer_World_IsValid && IsDedicateServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsDedicateServer", IsDedicateServer_IsValid);
		IsControllerInPlayState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsControllerInPlayState");
		IsControllerInPlayState_ParamsSize = NativeReflection.GetFunctionParamsSize(IsControllerInPlayState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsControllerInPlayState_Controller_PropertyAddress, IsControllerInPlayState_FunctionAddress, "Controller");
		IsControllerInPlayState_Controller_Offset = NativeReflectionCached.GetPropertyOffset(IsControllerInPlayState_FunctionAddress, "Controller");
		IsControllerInPlayState_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControllerInPlayState_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsControllerInPlayState_ReturnValue_PropertyAddress, IsControllerInPlayState_FunctionAddress, "ReturnValue");
		IsControllerInPlayState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsControllerInPlayState_FunctionAddress, "ReturnValue");
		IsControllerInPlayState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControllerInPlayState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsControllerInPlayState_IsValid = IsControllerInPlayState_FunctionAddress != IntPtr.Zero && IsControllerInPlayState_Controller_IsValid && IsControllerInPlayState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsControllerInPlayState", IsControllerInPlayState_IsValid);
		IsCommandLineHasParam_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCommandLineHasParam");
		IsCommandLineHasParam_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCommandLineHasParam_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCommandLineHasParam_QueryParam_PropertyAddress, IsCommandLineHasParam_FunctionAddress, "QueryParam");
		IsCommandLineHasParam_QueryParam_Offset = NativeReflectionCached.GetPropertyOffset(IsCommandLineHasParam_FunctionAddress, "QueryParam");
		IsCommandLineHasParam_QueryParam_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCommandLineHasParam_FunctionAddress, "QueryParam", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCommandLineHasParam_ReturnValue_PropertyAddress, IsCommandLineHasParam_FunctionAddress, "ReturnValue");
		IsCommandLineHasParam_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCommandLineHasParam_FunctionAddress, "ReturnValue");
		IsCommandLineHasParam_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCommandLineHasParam_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCommandLineHasParam_IsValid = IsCommandLineHasParam_FunctionAddress != IntPtr.Zero && IsCommandLineHasParam_QueryParam_IsValid && IsCommandLineHasParam_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsCommandLineHasParam", IsCommandLineHasParam_IsValid);
		IsClient_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsClient");
		IsClient_ParamsSize = NativeReflection.GetFunctionParamsSize(IsClient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsClient_World_PropertyAddress, IsClient_FunctionAddress, "World");
		IsClient_World_Offset = NativeReflectionCached.GetPropertyOffset(IsClient_FunctionAddress, "World");
		IsClient_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClient_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsClient_ReturnValue_PropertyAddress, IsClient_FunctionAddress, "ReturnValue");
		IsClient_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsClient_FunctionAddress, "ReturnValue");
		IsClient_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClient_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsClient_IsValid = IsClient_FunctionAddress != IntPtr.Zero && IsClient_World_IsValid && IsClient_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:IsClient", IsClient_IsValid);
		HasValidCaptureData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasValidCaptureData");
		HasValidCaptureData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasValidCaptureData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasValidCaptureData_Component_PropertyAddress, HasValidCaptureData_FunctionAddress, "Component");
		HasValidCaptureData_Component_Offset = NativeReflectionCached.GetPropertyOffset(HasValidCaptureData_FunctionAddress, "Component");
		HasValidCaptureData_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(HasValidCaptureData_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasValidCaptureData_ReturnValue_PropertyAddress, HasValidCaptureData_FunctionAddress, "ReturnValue");
		HasValidCaptureData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasValidCaptureData_FunctionAddress, "ReturnValue");
		HasValidCaptureData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasValidCaptureData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasValidCaptureData_IsValid = HasValidCaptureData_FunctionAddress != IntPtr.Zero && HasValidCaptureData_Component_IsValid && HasValidCaptureData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:HasValidCaptureData", HasValidCaptureData_IsValid);
		HasLaunchOption_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasLaunchOption");
		HasLaunchOption_ParamsSize = NativeReflection.GetFunctionParamsSize(HasLaunchOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasLaunchOption_Option_PropertyAddress, HasLaunchOption_FunctionAddress, "Option");
		HasLaunchOption_Option_Offset = NativeReflectionCached.GetPropertyOffset(HasLaunchOption_FunctionAddress, "Option");
		HasLaunchOption_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLaunchOption_FunctionAddress, "Option", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HasLaunchOption_ReturnValue_PropertyAddress, HasLaunchOption_FunctionAddress, "ReturnValue");
		HasLaunchOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasLaunchOption_FunctionAddress, "ReturnValue");
		HasLaunchOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLaunchOption_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasLaunchOption_IsValid = HasLaunchOption_FunctionAddress != IntPtr.Zero && HasLaunchOption_Option_IsValid && HasLaunchOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:HasLaunchOption", HasLaunchOption_IsValid);
		GSSaveConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSSaveConfig");
		GSSaveConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSaveConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSaveConfig_WorldContext_PropertyAddress, GSSaveConfig_FunctionAddress, "WorldContext");
		GSSaveConfig_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GSSaveConfig_FunctionAddress, "WorldContext");
		GSSaveConfig_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSaveConfig_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		GSSaveConfig_IsValid = GSSaveConfig_FunctionAddress != IntPtr.Zero && GSSaveConfig_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GSSaveConfig", GSSaveConfig_IsValid);
		GetWorldMainAudioDeviceID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldMainAudioDeviceID");
		GetWorldMainAudioDeviceID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldMainAudioDeviceID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldMainAudioDeviceID_WorldContextObject_PropertyAddress, GetWorldMainAudioDeviceID_FunctionAddress, "WorldContextObject");
		GetWorldMainAudioDeviceID_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldMainAudioDeviceID_FunctionAddress, "WorldContextObject");
		GetWorldMainAudioDeviceID_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldMainAudioDeviceID_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldMainAudioDeviceID_ReturnValue_PropertyAddress, GetWorldMainAudioDeviceID_FunctionAddress, "ReturnValue");
		GetWorldMainAudioDeviceID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldMainAudioDeviceID_FunctionAddress, "ReturnValue");
		GetWorldMainAudioDeviceID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldMainAudioDeviceID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetWorldMainAudioDeviceID_IsValid = GetWorldMainAudioDeviceID_FunctionAddress != IntPtr.Zero && GetWorldMainAudioDeviceID_WorldContextObject_IsValid && GetWorldMainAudioDeviceID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldMainAudioDeviceID", GetWorldMainAudioDeviceID_IsValid);
		GetWorldFromObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldFromObj");
		GetWorldFromObj_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldFromObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldFromObj_Context_PropertyAddress, GetWorldFromObj_FunctionAddress, "Context");
		GetWorldFromObj_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldFromObj_FunctionAddress, "Context");
		GetWorldFromObj_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldFromObj_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldFromObj_ReturnValue_PropertyAddress, GetWorldFromObj_FunctionAddress, "ReturnValue");
		GetWorldFromObj_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldFromObj_FunctionAddress, "ReturnValue");
		GetWorldFromObj_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldFromObj_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldFromObj_IsValid = GetWorldFromObj_FunctionAddress != IntPtr.Zero && GetWorldFromObj_Context_IsValid && GetWorldFromObj_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetWorldFromObj", GetWorldFromObj_IsValid);
		GetWindowScreenResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWindowScreenResolution");
		GetWindowScreenResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWindowScreenResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWindowScreenResolution_ReturnValue_PropertyAddress, GetWindowScreenResolution_FunctionAddress, "ReturnValue");
		GetWindowScreenResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWindowScreenResolution_FunctionAddress, "ReturnValue");
		GetWindowScreenResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWindowScreenResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWindowScreenResolution_IsValid = GetWindowScreenResolution_FunctionAddress != IntPtr.Zero && GetWindowScreenResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetWindowScreenResolution", GetWindowScreenResolution_IsValid);
		GetWarningUITexList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWarningUITexList");
		GetWarningUITexList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWarningUITexList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWarningUITexList_WorldContext_PropertyAddress, GetWarningUITexList_FunctionAddress, "WorldContext");
		GetWarningUITexList_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningUITexList_FunctionAddress, "WorldContext");
		GetWarningUITexList_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningUITexList_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningUITexList_TraverseRootPath_PropertyAddress, GetWarningUITexList_FunctionAddress, "TraverseRootPath");
		GetWarningUITexList_TraverseRootPath_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningUITexList_FunctionAddress, "TraverseRootPath");
		GetWarningUITexList_TraverseRootPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningUITexList_FunctionAddress, "TraverseRootPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningUITexList_SourceFileCommPath_PropertyAddress, GetWarningUITexList_FunctionAddress, "SourceFileCommPath");
		GetWarningUITexList_SourceFileCommPath_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningUITexList_FunctionAddress, "SourceFileCommPath");
		GetWarningUITexList_SourceFileCommPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningUITexList_FunctionAddress, "SourceFileCommPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningUITexList_ExcludedPathList_PropertyAddress, GetWarningUITexList_FunctionAddress, "ExcludedPathList");
		GetWarningUITexList_ExcludedPathList_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningUITexList_FunctionAddress, "ExcludedPathList");
		GetWarningUITexList_ExcludedPathList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningUITexList_FunctionAddress, "ExcludedPathList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningUITexList_ReturnValue_PropertyAddress, GetWarningUITexList_FunctionAddress, "ReturnValue");
		GetWarningUITexList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningUITexList_FunctionAddress, "ReturnValue");
		GetWarningUITexList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningUITexList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetWarningUITexList_IsValid = GetWarningUITexList_FunctionAddress != IntPtr.Zero && GetWarningUITexList_WorldContext_IsValid && GetWarningUITexList_TraverseRootPath_IsValid && GetWarningUITexList_SourceFileCommPath_IsValid && GetWarningUITexList_ExcludedPathList_IsValid && GetWarningUITexList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningUITexList", GetWarningUITexList_IsValid);
		GetWarningPhysicsAssetList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWarningPhysicsAssetList");
		GetWarningPhysicsAssetList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWarningPhysicsAssetList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWarningPhysicsAssetList_WorldContext_PropertyAddress, GetWarningPhysicsAssetList_FunctionAddress, "WorldContext");
		GetWarningPhysicsAssetList_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningPhysicsAssetList_FunctionAddress, "WorldContext");
		GetWarningPhysicsAssetList_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningPhysicsAssetList_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningPhysicsAssetList_TraverseRootPath_PropertyAddress, GetWarningPhysicsAssetList_FunctionAddress, "TraverseRootPath");
		GetWarningPhysicsAssetList_TraverseRootPath_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningPhysicsAssetList_FunctionAddress, "TraverseRootPath");
		GetWarningPhysicsAssetList_TraverseRootPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningPhysicsAssetList_FunctionAddress, "TraverseRootPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWarningPhysicsAssetList_ReturnValue_PropertyAddress, GetWarningPhysicsAssetList_FunctionAddress, "ReturnValue");
		GetWarningPhysicsAssetList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWarningPhysicsAssetList_FunctionAddress, "ReturnValue");
		GetWarningPhysicsAssetList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWarningPhysicsAssetList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetWarningPhysicsAssetList_IsValid = GetWarningPhysicsAssetList_FunctionAddress != IntPtr.Zero && GetWarningPhysicsAssetList_WorldContext_IsValid && GetWarningPhysicsAssetList_TraverseRootPath_IsValid && GetWarningPhysicsAssetList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetWarningPhysicsAssetList", GetWarningPhysicsAssetList_IsValid);
		GetTransientPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransientPackage");
		GetTransientPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransientPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransientPackage_ReturnValue_PropertyAddress, GetTransientPackage_FunctionAddress, "ReturnValue");
		GetTransientPackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransientPackage_FunctionAddress, "ReturnValue");
		GetTransientPackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransientPackage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTransientPackage_IsValid = GetTransientPackage_FunctionAddress != IntPtr.Zero && GetTransientPackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetTransientPackage", GetTransientPackage_IsValid);
		GetTotalPsoPrecompileNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTotalPsoPrecompileNum");
		GetTotalPsoPrecompileNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalPsoPrecompileNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalPsoPrecompileNum_ReturnValue_PropertyAddress, GetTotalPsoPrecompileNum_FunctionAddress, "ReturnValue");
		GetTotalPsoPrecompileNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalPsoPrecompileNum_FunctionAddress, "ReturnValue");
		GetTotalPsoPrecompileNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalPsoPrecompileNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTotalPsoPrecompileNum_IsValid = GetTotalPsoPrecompileNum_FunctionAddress != IntPtr.Zero && GetTotalPsoPrecompileNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetTotalPsoPrecompileNum", GetTotalPsoPrecompileNum_IsValid);
		GetTimeSpanFromSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTimeSpanFromSeconds");
		GetTimeSpanFromSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeSpanFromSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeSpanFromSeconds_Seconds_PropertyAddress, GetTimeSpanFromSeconds_FunctionAddress, "Seconds");
		GetTimeSpanFromSeconds_Seconds_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeSpanFromSeconds_FunctionAddress, "Seconds");
		GetTimeSpanFromSeconds_Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeSpanFromSeconds_FunctionAddress, "Seconds", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTimeSpanFromSeconds_ReturnValue_PropertyAddress, GetTimeSpanFromSeconds_FunctionAddress, "ReturnValue");
		GetTimeSpanFromSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeSpanFromSeconds_FunctionAddress, "ReturnValue");
		GetTimeSpanFromSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeSpanFromSeconds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTimeSpanFromSeconds_IsValid = GetTimeSpanFromSeconds_FunctionAddress != IntPtr.Zero && GetTimeSpanFromSeconds_Seconds_IsValid && GetTimeSpanFromSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetTimeSpanFromSeconds", GetTimeSpanFromSeconds_IsValid);
		GetShadowQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShadowQualityLevel");
		GetShadowQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShadowQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShadowQualityLevel_ReturnValue_PropertyAddress, GetShadowQualityLevel_FunctionAddress, "ReturnValue");
		GetShadowQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShadowQualityLevel_FunctionAddress, "ReturnValue");
		GetShadowQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShadowQualityLevel_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetShadowQualityLevel_IsValid = GetShadowQualityLevel_FunctionAddress != IntPtr.Zero && GetShadowQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetShadowQualityLevel", GetShadowQualityLevel_IsValid);
		GetRemainingPsoPrecompileNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRemainingPsoPrecompileNum");
		GetRemainingPsoPrecompileNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRemainingPsoPrecompileNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRemainingPsoPrecompileNum_ReturnValue_PropertyAddress, GetRemainingPsoPrecompileNum_FunctionAddress, "ReturnValue");
		GetRemainingPsoPrecompileNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRemainingPsoPrecompileNum_FunctionAddress, "ReturnValue");
		GetRemainingPsoPrecompileNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRemainingPsoPrecompileNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRemainingPsoPrecompileNum_IsValid = GetRemainingPsoPrecompileNum_FunctionAddress != IntPtr.Zero && GetRemainingPsoPrecompileNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetRemainingPsoPrecompileNum", GetRemainingPsoPrecompileNum_IsValid);
		GetRegexMatchInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRegexMatchInfo");
		GetRegexMatchInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRegexMatchInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRegexMatchInfo_InStr_PropertyAddress, GetRegexMatchInfo_FunctionAddress, "InStr");
		GetRegexMatchInfo_InStr_Offset = NativeReflectionCached.GetPropertyOffset(GetRegexMatchInfo_FunctionAddress, "InStr");
		GetRegexMatchInfo_InStr_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegexMatchInfo_FunctionAddress, "InStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRegexMatchInfo_RegexExpression_PropertyAddress, GetRegexMatchInfo_FunctionAddress, "RegexExpression");
		GetRegexMatchInfo_RegexExpression_Offset = NativeReflectionCached.GetPropertyOffset(GetRegexMatchInfo_FunctionAddress, "RegexExpression");
		GetRegexMatchInfo_RegexExpression_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegexMatchInfo_FunctionAddress, "RegexExpression", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRegexMatchInfo_ExtractedInfo_PropertyAddress, GetRegexMatchInfo_FunctionAddress, "ExtractedInfo");
		GetRegexMatchInfo_ExtractedInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetRegexMatchInfo_FunctionAddress, "ExtractedInfo");
		GetRegexMatchInfo_ExtractedInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRegexMatchInfo_FunctionAddress, "ExtractedInfo", Classes.FArrayProperty);
		GetRegexMatchInfo_IsValid = GetRegexMatchInfo_FunctionAddress != IntPtr.Zero && GetRegexMatchInfo_InStr_IsValid && GetRegexMatchInfo_RegexExpression_IsValid && GetRegexMatchInfo_ExtractedInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetRegexMatchInfo", GetRegexMatchInfo_IsValid);
		GetRecommendedQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRecommendedQualityLevel");
		GetRecommendedQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRecommendedQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRecommendedQualityLevel_bLogInfo_PropertyAddress, GetRecommendedQualityLevel_FunctionAddress, "bLogInfo");
		GetRecommendedQualityLevel_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetRecommendedQualityLevel_FunctionAddress, "bLogInfo");
		GetRecommendedQualityLevel_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRecommendedQualityLevel_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRecommendedQualityLevel_ReturnValue_PropertyAddress, GetRecommendedQualityLevel_FunctionAddress, "ReturnValue");
		GetRecommendedQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRecommendedQualityLevel_FunctionAddress, "ReturnValue");
		GetRecommendedQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRecommendedQualityLevel_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetRecommendedQualityLevel_IsValid = GetRecommendedQualityLevel_FunctionAddress != IntPtr.Zero && GetRecommendedQualityLevel_bLogInfo_IsValid && GetRecommendedQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetRecommendedQualityLevel", GetRecommendedQualityLevel_IsValid);
		GetProjectSettingDefaultGameMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProjectSettingDefaultGameMode");
		GetProjectSettingDefaultGameMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectSettingDefaultGameMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProjectSettingDefaultGameMode_ReturnValue_PropertyAddress, GetProjectSettingDefaultGameMode_FunctionAddress, "ReturnValue");
		GetProjectSettingDefaultGameMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectSettingDefaultGameMode_FunctionAddress, "ReturnValue");
		GetProjectSettingDefaultGameMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectSettingDefaultGameMode_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetProjectSettingDefaultGameMode_IsValid = GetProjectSettingDefaultGameMode_FunctionAddress != IntPtr.Zero && GetProjectSettingDefaultGameMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectSettingDefaultGameMode", GetProjectSettingDefaultGameMode_IsValid);
		GetProjectDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProjectDir");
		GetProjectDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProjectDir_ReturnValue_PropertyAddress, GetProjectDir_FunctionAddress, "ReturnValue");
		GetProjectDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProjectDir_FunctionAddress, "ReturnValue");
		GetProjectDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProjectDir_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetProjectDir_IsValid = GetProjectDir_FunctionAddress != IntPtr.Zero && GetProjectDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetProjectDir", GetProjectDir_IsValid);
		GetPlayerViewRectMatrixInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerViewRectMatrixInfo");
		GetPlayerViewRectMatrixInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewRectMatrixInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_Player_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "Player");
		GetPlayerViewRectMatrixInfo_Player_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "Player");
		GetPlayerViewRectMatrixInfo_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "ViewProjectionMatrixInv");
		GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "ViewProjectionMatrixInv");
		GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "ViewProjectionMatrixInv", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMin");
		GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMin");
		GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMax");
		GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMax");
		GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutConstrainedViewRectMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_OutViewRectMin_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMin");
		GetPlayerViewRectMatrixInfo_OutViewRectMin_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMin");
		GetPlayerViewRectMatrixInfo_OutViewRectMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRectMatrixInfo_OutViewRectMax_PropertyAddress, GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMax");
		GetPlayerViewRectMatrixInfo_OutViewRectMax_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMax");
		GetPlayerViewRectMatrixInfo_OutViewRectMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRectMatrixInfo_FunctionAddress, "OutViewRectMax", Classes.FStructProperty);
		GetPlayerViewRectMatrixInfo_IsValid = GetPlayerViewRectMatrixInfo_FunctionAddress != IntPtr.Zero && GetPlayerViewRectMatrixInfo_Player_IsValid && GetPlayerViewRectMatrixInfo_ViewProjectionMatrixInv_IsValid && GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMin_IsValid && GetPlayerViewRectMatrixInfo_OutConstrainedViewRectMax_IsValid && GetPlayerViewRectMatrixInfo_OutViewRectMin_IsValid && GetPlayerViewRectMatrixInfo_OutViewRectMax_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRectMatrixInfo", GetPlayerViewRectMatrixInfo_IsValid);
		GetPlayerViewRect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerViewRect");
		GetPlayerViewRect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRect_Player_PropertyAddress, GetPlayerViewRect_FunctionAddress, "Player");
		GetPlayerViewRect_Player_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRect_FunctionAddress, "Player");
		GetPlayerViewRect_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRect_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRect_OutConstrainedViewRectMin_PropertyAddress, GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMin");
		GetPlayerViewRect_OutConstrainedViewRectMin_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMin");
		GetPlayerViewRect_OutConstrainedViewRectMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRect_OutConstrainedViewRectMax_PropertyAddress, GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMax");
		GetPlayerViewRect_OutConstrainedViewRectMax_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMax");
		GetPlayerViewRect_OutConstrainedViewRectMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRect_FunctionAddress, "OutConstrainedViewRectMax", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRect_OutViewRectMin_PropertyAddress, GetPlayerViewRect_FunctionAddress, "OutViewRectMin");
		GetPlayerViewRect_OutViewRectMin_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRect_FunctionAddress, "OutViewRectMin");
		GetPlayerViewRect_OutViewRectMin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRect_FunctionAddress, "OutViewRectMin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewRect_OutViewRectMax_PropertyAddress, GetPlayerViewRect_FunctionAddress, "OutViewRectMax");
		GetPlayerViewRect_OutViewRectMax_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewRect_FunctionAddress, "OutViewRectMax");
		GetPlayerViewRect_OutViewRectMax_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewRect_FunctionAddress, "OutViewRectMax", Classes.FStructProperty);
		GetPlayerViewRect_IsValid = GetPlayerViewRect_FunctionAddress != IntPtr.Zero && GetPlayerViewRect_Player_IsValid && GetPlayerViewRect_OutConstrainedViewRectMin_IsValid && GetPlayerViewRect_OutConstrainedViewRectMax_IsValid && GetPlayerViewRect_OutViewRectMin_IsValid && GetPlayerViewRect_OutViewRectMax_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewRect", GetPlayerViewRect_IsValid);
		GetPlayerViewProjectionMatrixInv_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerViewProjectionMatrixInv");
		GetPlayerViewProjectionMatrixInv_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewProjectionMatrixInv_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewProjectionMatrixInv_Player_PropertyAddress, GetPlayerViewProjectionMatrixInv_FunctionAddress, "Player");
		GetPlayerViewProjectionMatrixInv_Player_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewProjectionMatrixInv_FunctionAddress, "Player");
		GetPlayerViewProjectionMatrixInv_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewProjectionMatrixInv_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewProjectionMatrixInv_ReturnValue_PropertyAddress, GetPlayerViewProjectionMatrixInv_FunctionAddress, "ReturnValue");
		GetPlayerViewProjectionMatrixInv_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewProjectionMatrixInv_FunctionAddress, "ReturnValue");
		GetPlayerViewProjectionMatrixInv_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewProjectionMatrixInv_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlayerViewProjectionMatrixInv_IsValid = GetPlayerViewProjectionMatrixInv_FunctionAddress != IntPtr.Zero && GetPlayerViewProjectionMatrixInv_Player_IsValid && GetPlayerViewProjectionMatrixInv_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrixInv", GetPlayerViewProjectionMatrixInv_IsValid);
		GetPlayerViewProjectionMatrix_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerViewProjectionMatrix");
		GetPlayerViewProjectionMatrix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewProjectionMatrix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewProjectionMatrix_Player_PropertyAddress, GetPlayerViewProjectionMatrix_FunctionAddress, "Player");
		GetPlayerViewProjectionMatrix_Player_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewProjectionMatrix_FunctionAddress, "Player");
		GetPlayerViewProjectionMatrix_Player_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewProjectionMatrix_FunctionAddress, "Player", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewProjectionMatrix_ReturnValue_PropertyAddress, GetPlayerViewProjectionMatrix_FunctionAddress, "ReturnValue");
		GetPlayerViewProjectionMatrix_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewProjectionMatrix_FunctionAddress, "ReturnValue");
		GetPlayerViewProjectionMatrix_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewProjectionMatrix_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlayerViewProjectionMatrix_IsValid = GetPlayerViewProjectionMatrix_FunctionAddress != IntPtr.Zero && GetPlayerViewProjectionMatrix_Player_IsValid && GetPlayerViewProjectionMatrix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlayerViewProjectionMatrix", GetPlayerViewProjectionMatrix_IsValid);
		GetPlatformTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlatformTime");
		GetPlatformTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlatformTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlatformTime_ReturnValue_PropertyAddress, GetPlatformTime_FunctionAddress, "ReturnValue");
		GetPlatformTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlatformTime_FunctionAddress, "ReturnValue");
		GetPlatformTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlatformTime_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetPlatformTime_IsValid = GetPlatformTime_FunctionAddress != IntPtr.Zero && GetPlatformTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPlatformTime", GetPlatformTime_IsValid);
		GetPawnAutoPossessConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPawnAutoPossessConfig");
		GetPawnAutoPossessConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPawnAutoPossessConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPawnAutoPossessConfig_PC_PropertyAddress, GetPawnAutoPossessConfig_FunctionAddress, "PC");
		GetPawnAutoPossessConfig_PC_Offset = NativeReflectionCached.GetPropertyOffset(GetPawnAutoPossessConfig_FunctionAddress, "PC");
		GetPawnAutoPossessConfig_PC_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPawnAutoPossessConfig_FunctionAddress, "PC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPawnAutoPossessConfig_ReturnValue_PropertyAddress, GetPawnAutoPossessConfig_FunctionAddress, "ReturnValue");
		GetPawnAutoPossessConfig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPawnAutoPossessConfig_FunctionAddress, "ReturnValue");
		GetPawnAutoPossessConfig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPawnAutoPossessConfig_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPawnAutoPossessConfig_IsValid = GetPawnAutoPossessConfig_FunctionAddress != IntPtr.Zero && GetPawnAutoPossessConfig_PC_IsValid && GetPawnAutoPossessConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetPawnAutoPossessConfig", GetPawnAutoPossessConfig_IsValid);
		GetMediaPlayerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMediaPlayerTime");
		GetMediaPlayerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerTime_MediaPlayer_PropertyAddress, GetMediaPlayerTime_FunctionAddress, "MediaPlayer");
		GetMediaPlayerTime_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerTime_FunctionAddress, "MediaPlayer");
		GetMediaPlayerTime_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerTime_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerTime_ReturnValue_PropertyAddress, GetMediaPlayerTime_FunctionAddress, "ReturnValue");
		GetMediaPlayerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerTime_FunctionAddress, "ReturnValue");
		GetMediaPlayerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerTime_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetMediaPlayerTime_IsValid = GetMediaPlayerTime_FunctionAddress != IntPtr.Zero && GetMediaPlayerTime_MediaPlayer_IsValid && GetMediaPlayerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerTime", GetMediaPlayerTime_IsValid);
		GetMediaPlayerDuartion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMediaPlayerDuartion");
		GetMediaPlayerDuartion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayerDuartion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerDuartion_MediaPlayer_PropertyAddress, GetMediaPlayerDuartion_FunctionAddress, "MediaPlayer");
		GetMediaPlayerDuartion_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerDuartion_FunctionAddress, "MediaPlayer");
		GetMediaPlayerDuartion_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerDuartion_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerDuartion_ReturnValue_PropertyAddress, GetMediaPlayerDuartion_FunctionAddress, "ReturnValue");
		GetMediaPlayerDuartion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerDuartion_FunctionAddress, "ReturnValue");
		GetMediaPlayerDuartion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerDuartion_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetMediaPlayerDuartion_IsValid = GetMediaPlayerDuartion_FunctionAddress != IntPtr.Zero && GetMediaPlayerDuartion_MediaPlayer_IsValid && GetMediaPlayerDuartion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetMediaPlayerDuartion", GetMediaPlayerDuartion_IsValid);
		GetMacAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMacAddress");
		GetMacAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMacAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMacAddress_ReturnValue_PropertyAddress, GetMacAddress_FunctionAddress, "ReturnValue");
		GetMacAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMacAddress_FunctionAddress, "ReturnValue");
		GetMacAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMacAddress_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMacAddress_IsValid = GetMacAddress_FunctionAddress != IntPtr.Zero && GetMacAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetMacAddress", GetMacAddress_IsValid);
		GetLoginId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLoginId");
		GetLoginId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoginId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoginId_ReturnValue_PropertyAddress, GetLoginId_FunctionAddress, "ReturnValue");
		GetLoginId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLoginId_FunctionAddress, "ReturnValue");
		GetLoginId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoginId_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLoginId_IsValid = GetLoginId_FunctionAddress != IntPtr.Zero && GetLoginId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetLoginId", GetLoginId_IsValid);
		GetLocalPlayerCameraManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalPlayerCameraManager");
		GetLocalPlayerCameraManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalPlayerCameraManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerCameraManager_WorldCtx_PropertyAddress, GetLocalPlayerCameraManager_FunctionAddress, "WorldCtx");
		GetLocalPlayerCameraManager_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerCameraManager_FunctionAddress, "WorldCtx");
		GetLocalPlayerCameraManager_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerCameraManager_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerCameraManager_ReturnValue_PropertyAddress, GetLocalPlayerCameraManager_FunctionAddress, "ReturnValue");
		GetLocalPlayerCameraManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerCameraManager_FunctionAddress, "ReturnValue");
		GetLocalPlayerCameraManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerCameraManager_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalPlayerCameraManager_IsValid = GetLocalPlayerCameraManager_FunctionAddress != IntPtr.Zero && GetLocalPlayerCameraManager_WorldCtx_IsValid && GetLocalPlayerCameraManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetLocalPlayerCameraManager", GetLocalPlayerCameraManager_IsValid);
		GetLaunchValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLaunchValue");
		GetLaunchValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLaunchValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLaunchValue_Option_PropertyAddress, GetLaunchValue_FunctionAddress, "Option");
		GetLaunchValue_Option_Offset = NativeReflectionCached.GetPropertyOffset(GetLaunchValue_FunctionAddress, "Option");
		GetLaunchValue_Option_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaunchValue_FunctionAddress, "Option", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLaunchValue_ReturnValue_PropertyAddress, GetLaunchValue_FunctionAddress, "ReturnValue");
		GetLaunchValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLaunchValue_FunctionAddress, "ReturnValue");
		GetLaunchValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLaunchValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLaunchValue_IsValid = GetLaunchValue_FunctionAddress != IntPtr.Zero && GetLaunchValue_Option_IsValid && GetLaunchValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetLaunchValue", GetLaunchValue_IsValid);
		GetInputKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputKey");
		GetInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputKey_KeyEvent_PropertyAddress, GetInputKey_FunctionAddress, "KeyEvent");
		GetInputKey_KeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKey_FunctionAddress, "KeyEvent");
		GetInputKey_KeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKey_FunctionAddress, "KeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputKey_ReturnValue_PropertyAddress, GetInputKey_FunctionAddress, "ReturnValue");
		GetInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKey_FunctionAddress, "ReturnValue");
		GetInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputKey_IsValid = GetInputKey_FunctionAddress != IntPtr.Zero && GetInputKey_KeyEvent_IsValid && GetInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputKey", GetInputKey_IsValid);
		GetInputDeadZone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputDeadZone");
		GetInputDeadZone_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputDeadZone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputDeadZone_PlayerController_PropertyAddress, GetInputDeadZone_FunctionAddress, "PlayerController");
		GetInputDeadZone_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetInputDeadZone_FunctionAddress, "PlayerController");
		GetInputDeadZone_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputDeadZone_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputDeadZone_AxisName_PropertyAddress, GetInputDeadZone_FunctionAddress, "AxisName");
		GetInputDeadZone_AxisName_Offset = NativeReflectionCached.GetPropertyOffset(GetInputDeadZone_FunctionAddress, "AxisName");
		GetInputDeadZone_AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputDeadZone_FunctionAddress, "AxisName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputDeadZone_ReturnValue_PropertyAddress, GetInputDeadZone_FunctionAddress, "ReturnValue");
		GetInputDeadZone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputDeadZone_FunctionAddress, "ReturnValue");
		GetInputDeadZone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputDeadZone_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInputDeadZone_IsValid = GetInputDeadZone_FunctionAddress != IntPtr.Zero && GetInputDeadZone_PlayerController_IsValid && GetInputDeadZone_AxisName_IsValid && GetInputDeadZone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetInputDeadZone", GetInputDeadZone_IsValid);
		GetGFrameCounter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGFrameCounter");
		GetGFrameCounter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGFrameCounter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGFrameCounter_ReturnValue_PropertyAddress, GetGFrameCounter_FunctionAddress, "ReturnValue");
		GetGFrameCounter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGFrameCounter_FunctionAddress, "ReturnValue");
		GetGFrameCounter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGFrameCounter_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetGFrameCounter_IsValid = GetGFrameCounter_FunctionAddress != IntPtr.Zero && GetGFrameCounter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetGFrameCounter", GetGFrameCounter_IsValid);
		GetFirstLocalPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFirstLocalPlayerController");
		GetFirstLocalPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstLocalPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstLocalPlayerController_WorldCtx_PropertyAddress, GetFirstLocalPlayerController_FunctionAddress, "WorldCtx");
		GetFirstLocalPlayerController_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstLocalPlayerController_FunctionAddress, "WorldCtx");
		GetFirstLocalPlayerController_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstLocalPlayerController_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFirstLocalPlayerController_ReturnValue_PropertyAddress, GetFirstLocalPlayerController_FunctionAddress, "ReturnValue");
		GetFirstLocalPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstLocalPlayerController_FunctionAddress, "ReturnValue");
		GetFirstLocalPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstLocalPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFirstLocalPlayerController_IsValid = GetFirstLocalPlayerController_FunctionAddress != IntPtr.Zero && GetFirstLocalPlayerController_WorldCtx_IsValid && GetFirstLocalPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetFirstLocalPlayerController", GetFirstLocalPlayerController_IsValid);
		GetEngineMinorVersion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEngineMinorVersion");
		GetEngineMinorVersion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngineMinorVersion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngineMinorVersion_ReturnValue_PropertyAddress, GetEngineMinorVersion_FunctionAddress, "ReturnValue");
		GetEngineMinorVersion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineMinorVersion_FunctionAddress, "ReturnValue");
		GetEngineMinorVersion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineMinorVersion_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetEngineMinorVersion_IsValid = GetEngineMinorVersion_FunctionAddress != IntPtr.Zero && GetEngineMinorVersion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetEngineMinorVersion", GetEngineMinorVersion_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_Object_PropertyAddress, GetDisplayName_FunctionAddress, "Object");
		GetDisplayName_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "Object");
		GetDisplayName_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_Object_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayName", GetDisplayName_IsValid);
		GetDisplayGamma_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayGamma");
		GetDisplayGamma_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayGamma_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayGamma_WorldCtx_PropertyAddress, GetDisplayGamma_FunctionAddress, "WorldCtx");
		GetDisplayGamma_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayGamma_FunctionAddress, "WorldCtx");
		GetDisplayGamma_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayGamma_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayGamma_ReturnValue_PropertyAddress, GetDisplayGamma_FunctionAddress, "ReturnValue");
		GetDisplayGamma_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayGamma_FunctionAddress, "ReturnValue");
		GetDisplayGamma_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayGamma_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDisplayGamma_IsValid = GetDisplayGamma_FunctionAddress != IntPtr.Zero && GetDisplayGamma_WorldCtx_IsValid && GetDisplayGamma_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetDisplayGamma", GetDisplayGamma_IsValid);
		GetDeviceInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDeviceInfo");
		GetDeviceInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeviceInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeviceInfo_Cpu_PropertyAddress, GetDeviceInfo_FunctionAddress, "Cpu");
		GetDeviceInfo_Cpu_Offset = NativeReflectionCached.GetPropertyOffset(GetDeviceInfo_FunctionAddress, "Cpu");
		GetDeviceInfo_Cpu_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeviceInfo_FunctionAddress, "Cpu", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDeviceInfo_Gpu_PropertyAddress, GetDeviceInfo_FunctionAddress, "Gpu");
		GetDeviceInfo_Gpu_Offset = NativeReflectionCached.GetPropertyOffset(GetDeviceInfo_FunctionAddress, "Gpu");
		GetDeviceInfo_Gpu_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeviceInfo_FunctionAddress, "Gpu", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDeviceInfo_MemSize_PropertyAddress, GetDeviceInfo_FunctionAddress, "MemSize");
		GetDeviceInfo_MemSize_Offset = NativeReflectionCached.GetPropertyOffset(GetDeviceInfo_FunctionAddress, "MemSize");
		GetDeviceInfo_MemSize_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeviceInfo_FunctionAddress, "MemSize", Classes.FIntProperty);
		GetDeviceInfo_IsValid = GetDeviceInfo_FunctionAddress != IntPtr.Zero && GetDeviceInfo_Cpu_IsValid && GetDeviceInfo_Gpu_IsValid && GetDeviceInfo_MemSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceInfo", GetDeviceInfo_IsValid);
		GetDeviceId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDeviceId");
		GetDeviceId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeviceId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeviceId_ReturnValue_PropertyAddress, GetDeviceId_FunctionAddress, "ReturnValue");
		GetDeviceId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeviceId_FunctionAddress, "ReturnValue");
		GetDeviceId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeviceId_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDeviceId_IsValid = GetDeviceId_FunctionAddress != IntPtr.Zero && GetDeviceId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetDeviceId", GetDeviceId_IsValid);
		GetDefaultLanguageCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultLanguageCS");
		GetDefaultLanguageCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultLanguageCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultLanguageCS_ReturnValue_PropertyAddress, GetDefaultLanguageCS_FunctionAddress, "ReturnValue");
		GetDefaultLanguageCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultLanguageCS_FunctionAddress, "ReturnValue");
		GetDefaultLanguageCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultLanguageCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultLanguageCS_IsValid = GetDefaultLanguageCS_FunctionAddress != IntPtr.Zero && GetDefaultLanguageCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetDefaultLanguageCS", GetDefaultLanguageCS_IsValid);
		GetCurrentRhiName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentRhiName");
		GetCurrentRhiName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentRhiName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentRhiName_ReturnValue_PropertyAddress, GetCurrentRhiName_FunctionAddress, "ReturnValue");
		GetCurrentRhiName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentRhiName_FunctionAddress, "ReturnValue");
		GetCurrentRhiName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentRhiName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentRhiName_IsValid = GetCurrentRhiName_FunctionAddress != IntPtr.Zero && GetCurrentRhiName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetCurrentRhiName", GetCurrentRhiName_IsValid);
		GetChildActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildActors");
		GetChildActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildActors_Actor_PropertyAddress, GetChildActors_FunctionAddress, "Actor");
		GetChildActors_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetChildActors_FunctionAddress, "Actor");
		GetChildActors_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildActors_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildActors_ReturnValue_PropertyAddress, GetChildActors_FunctionAddress, "ReturnValue");
		GetChildActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildActors_FunctionAddress, "ReturnValue");
		GetChildActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildActors_IsValid = GetChildActors_FunctionAddress != IntPtr.Zero && GetChildActors_Actor_IsValid && GetChildActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetChildActors", GetChildActors_IsValid);
		GetBinkMediaPlayerTotalFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBinkMediaPlayerTotalFrames");
		GetBinkMediaPlayerTotalFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBinkMediaPlayerTotalFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerTotalFrames_MediaPlayer_PropertyAddress, GetBinkMediaPlayerTotalFrames_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerTotalFrames_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerTotalFrames_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerTotalFrames_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerTotalFrames_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerTotalFrames_ReturnValue_PropertyAddress, GetBinkMediaPlayerTotalFrames_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerTotalFrames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerTotalFrames_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerTotalFrames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerTotalFrames_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBinkMediaPlayerTotalFrames_IsValid = GetBinkMediaPlayerTotalFrames_FunctionAddress != IntPtr.Zero && GetBinkMediaPlayerTotalFrames_MediaPlayer_IsValid && GetBinkMediaPlayerTotalFrames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTotalFrames", GetBinkMediaPlayerTotalFrames_IsValid);
		GetBinkMediaPlayerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBinkMediaPlayerTime");
		GetBinkMediaPlayerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBinkMediaPlayerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerTime_MediaPlayer_PropertyAddress, GetBinkMediaPlayerTime_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerTime_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerTime_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerTime_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerTime_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerTime_ReturnValue_PropertyAddress, GetBinkMediaPlayerTime_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerTime_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerTime_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetBinkMediaPlayerTime_IsValid = GetBinkMediaPlayerTime_FunctionAddress != IntPtr.Zero && GetBinkMediaPlayerTime_MediaPlayer_IsValid && GetBinkMediaPlayerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerTime", GetBinkMediaPlayerTime_IsValid);
		GetBinkMediaPlayerFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBinkMediaPlayerFrameRate");
		GetBinkMediaPlayerFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBinkMediaPlayerFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerFrameRate_MediaPlayer_PropertyAddress, GetBinkMediaPlayerFrameRate_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerFrameRate_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerFrameRate_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerFrameRate_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerFrameRate_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerFrameRate_ReturnValue_PropertyAddress, GetBinkMediaPlayerFrameRate_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerFrameRate_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerFrameRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBinkMediaPlayerFrameRate_IsValid = GetBinkMediaPlayerFrameRate_FunctionAddress != IntPtr.Zero && GetBinkMediaPlayerFrameRate_MediaPlayer_IsValid && GetBinkMediaPlayerFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerFrameRate", GetBinkMediaPlayerFrameRate_IsValid);
		GetBinkMediaPlayerDuartion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBinkMediaPlayerDuartion");
		GetBinkMediaPlayerDuartion_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBinkMediaPlayerDuartion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerDuartion_MediaPlayer_PropertyAddress, GetBinkMediaPlayerDuartion_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerDuartion_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerDuartion_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerDuartion_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerDuartion_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerDuartion_ReturnValue_PropertyAddress, GetBinkMediaPlayerDuartion_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerDuartion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerDuartion_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerDuartion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerDuartion_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetBinkMediaPlayerDuartion_IsValid = GetBinkMediaPlayerDuartion_FunctionAddress != IntPtr.Zero && GetBinkMediaPlayerDuartion_MediaPlayer_IsValid && GetBinkMediaPlayerDuartion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerDuartion", GetBinkMediaPlayerDuartion_IsValid);
		GetBinkMediaPlayerCurFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBinkMediaPlayerCurFrame");
		GetBinkMediaPlayerCurFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBinkMediaPlayerCurFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerCurFrame_MediaPlayer_PropertyAddress, GetBinkMediaPlayerCurFrame_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerCurFrame_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerCurFrame_FunctionAddress, "MediaPlayer");
		GetBinkMediaPlayerCurFrame_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerCurFrame_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBinkMediaPlayerCurFrame_ReturnValue_PropertyAddress, GetBinkMediaPlayerCurFrame_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerCurFrame_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBinkMediaPlayerCurFrame_FunctionAddress, "ReturnValue");
		GetBinkMediaPlayerCurFrame_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBinkMediaPlayerCurFrame_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBinkMediaPlayerCurFrame_IsValid = GetBinkMediaPlayerCurFrame_FunctionAddress != IntPtr.Zero && GetBinkMediaPlayerCurFrame_MediaPlayer_IsValid && GetBinkMediaPlayerCurFrame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetBinkMediaPlayerCurFrame", GetBinkMediaPlayerCurFrame_IsValid);
		GetAxisMappings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAxisMappings");
		GetAxisMappings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAxisMappings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAxisMappings_PlayerController_PropertyAddress, GetAxisMappings_FunctionAddress, "PlayerController");
		GetAxisMappings_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetAxisMappings_FunctionAddress, "PlayerController");
		GetAxisMappings_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAxisMappings_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAxisMappings_ReturnValue_PropertyAddress, GetAxisMappings_FunctionAddress, "ReturnValue");
		GetAxisMappings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAxisMappings_FunctionAddress, "ReturnValue");
		GetAxisMappings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAxisMappings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAxisMappings_IsValid = GetAxisMappings_FunctionAddress != IntPtr.Zero && GetAxisMappings_PlayerController_IsValid && GetAxisMappings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAxisMappings", GetAxisMappings_IsValid);
		GetAvailablePhysical_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailablePhysical");
		GetAvailablePhysical_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailablePhysical_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailablePhysical_ReturnValue_PropertyAddress, GetAvailablePhysical_FunctionAddress, "ReturnValue");
		GetAvailablePhysical_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailablePhysical_FunctionAddress, "ReturnValue");
		GetAvailablePhysical_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailablePhysical_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAvailablePhysical_IsValid = GetAvailablePhysical_FunctionAddress != IntPtr.Zero && GetAvailablePhysical_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAvailablePhysical", GetAvailablePhysical_IsValid);
		GetAudioInfoOfAudioVisualize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAudioInfoOfAudioVisualize");
		GetAudioInfoOfAudioVisualize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioInfoOfAudioVisualize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioInfoOfAudioVisualize_AudioUtilActor_PropertyAddress, GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioUtilActor");
		GetAudioInfoOfAudioVisualize_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioUtilActor");
		GetAudioInfoOfAudioVisualize_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioInfoOfAudioVisualize_AudioDuration_PropertyAddress, GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioDuration");
		GetAudioInfoOfAudioVisualize_AudioDuration_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioDuration");
		GetAudioInfoOfAudioVisualize_AudioDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioInfoOfAudioVisualize_FunctionAddress, "AudioDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioInfoOfAudioVisualize_ReturnValue_PropertyAddress, GetAudioInfoOfAudioVisualize_FunctionAddress, "ReturnValue");
		GetAudioInfoOfAudioVisualize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioInfoOfAudioVisualize_FunctionAddress, "ReturnValue");
		GetAudioInfoOfAudioVisualize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioInfoOfAudioVisualize_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAudioInfoOfAudioVisualize_IsValid = GetAudioInfoOfAudioVisualize_FunctionAddress != IntPtr.Zero && GetAudioInfoOfAudioVisualize_AudioUtilActor_IsValid && GetAudioInfoOfAudioVisualize_AudioDuration_IsValid && GetAudioInfoOfAudioVisualize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAudioInfoOfAudioVisualize", GetAudioInfoOfAudioVisualize_IsValid);
		GetAsyncLoadPercentage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAsyncLoadPercentage");
		GetAsyncLoadPercentage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsyncLoadPercentage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsyncLoadPercentage_PackageName_PropertyAddress, GetAsyncLoadPercentage_FunctionAddress, "PackageName");
		GetAsyncLoadPercentage_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAsyncLoadPercentage_FunctionAddress, "PackageName");
		GetAsyncLoadPercentage_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsyncLoadPercentage_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAsyncLoadPercentage_ReturnValue_PropertyAddress, GetAsyncLoadPercentage_FunctionAddress, "ReturnValue");
		GetAsyncLoadPercentage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsyncLoadPercentage_FunctionAddress, "ReturnValue");
		GetAsyncLoadPercentage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsyncLoadPercentage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAsyncLoadPercentage_IsValid = GetAsyncLoadPercentage_FunctionAddress != IntPtr.Zero && GetAsyncLoadPercentage_PackageName_IsValid && GetAsyncLoadPercentage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAsyncLoadPercentage", GetAsyncLoadPercentage_IsValid);
		GetAnalogValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogValue");
		GetAnalogValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_AnalogInputEvent_PropertyAddress, GetAnalogValue_FunctionAddress, "AnalogInputEvent");
		GetAnalogValue_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "AnalogInputEvent");
		GetAnalogValue_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_ReturnValue_PropertyAddress, GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnalogValue_IsValid = GetAnalogValue_FunctionAddress != IntPtr.Zero && GetAnalogValue_AnalogInputEvent_IsValid && GetAnalogValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogValue", GetAnalogValue_IsValid);
		GetAnalogInputKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogInputKey");
		GetAnalogInputKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogInputKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogInputKey_AnalogInputEvent_PropertyAddress, GetAnalogInputKey_FunctionAddress, "AnalogInputEvent");
		GetAnalogInputKey_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogInputKey_FunctionAddress, "AnalogInputEvent");
		GetAnalogInputKey_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogInputKey_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogInputKey_ReturnValue_PropertyAddress, GetAnalogInputKey_FunctionAddress, "ReturnValue");
		GetAnalogInputKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogInputKey_FunctionAddress, "ReturnValue");
		GetAnalogInputKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogInputKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnalogInputKey_IsValid = GetAnalogInputKey_FunctionAddress != IntPtr.Zero && GetAnalogInputKey_AnalogInputEvent_IsValid && GetAnalogInputKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetAnalogInputKey", GetAnalogInputKey_IsValid);
		GetActualQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActualQualityLevel");
		GetActualQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActualQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActualQualityLevel_bLogInfo_PropertyAddress, GetActualQualityLevel_FunctionAddress, "bLogInfo");
		GetActualQualityLevel_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetActualQualityLevel_FunctionAddress, "bLogInfo");
		GetActualQualityLevel_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActualQualityLevel_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActualQualityLevel_ReturnValue_PropertyAddress, GetActualQualityLevel_FunctionAddress, "ReturnValue");
		GetActualQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActualQualityLevel_FunctionAddress, "ReturnValue");
		GetActualQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActualQualityLevel_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetActualQualityLevel_IsValid = GetActualQualityLevel_FunctionAddress != IntPtr.Zero && GetActualQualityLevel_bLogInfo_IsValid && GetActualQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetActualQualityLevel", GetActualQualityLevel_IsValid);
		GetActionMappings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActionMappings");
		GetActionMappings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActionMappings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActionMappings_PlayerController_PropertyAddress, GetActionMappings_FunctionAddress, "PlayerController");
		GetActionMappings_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetActionMappings_FunctionAddress, "PlayerController");
		GetActionMappings_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionMappings_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActionMappings_ReturnValue_PropertyAddress, GetActionMappings_FunctionAddress, "ReturnValue");
		GetActionMappings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActionMappings_FunctionAddress, "ReturnValue");
		GetActionMappings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionMappings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetActionMappings_IsValid = GetActionMappings_FunctionAddress != IntPtr.Zero && GetActionMappings_PlayerController_IsValid && GetActionMappings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GetActionMappings", GetActionMappings_IsValid);
		GameInstanceIsDedicatedServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GameInstanceIsDedicatedServer");
		GameInstanceIsDedicatedServer_ParamsSize = NativeReflection.GetFunctionParamsSize(GameInstanceIsDedicatedServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GameInstanceIsDedicatedServer_GameInst_PropertyAddress, GameInstanceIsDedicatedServer_FunctionAddress, "GameInst");
		GameInstanceIsDedicatedServer_GameInst_Offset = NativeReflectionCached.GetPropertyOffset(GameInstanceIsDedicatedServer_FunctionAddress, "GameInst");
		GameInstanceIsDedicatedServer_GameInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GameInstanceIsDedicatedServer_FunctionAddress, "GameInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GameInstanceIsDedicatedServer_ReturnValue_PropertyAddress, GameInstanceIsDedicatedServer_FunctionAddress, "ReturnValue");
		GameInstanceIsDedicatedServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GameInstanceIsDedicatedServer_FunctionAddress, "ReturnValue");
		GameInstanceIsDedicatedServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GameInstanceIsDedicatedServer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GameInstanceIsDedicatedServer_IsValid = GameInstanceIsDedicatedServer_FunctionAddress != IntPtr.Zero && GameInstanceIsDedicatedServer_GameInst_IsValid && GameInstanceIsDedicatedServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:GameInstanceIsDedicatedServer", GameInstanceIsDedicatedServer_IsValid);
		FlushMainAudioDevice_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlushMainAudioDevice");
		FlushMainAudioDevice_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushMainAudioDevice_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FlushMainAudioDevice_DeviceID_PropertyAddress, FlushMainAudioDevice_FunctionAddress, "DeviceID");
		FlushMainAudioDevice_DeviceID_Offset = NativeReflectionCached.GetPropertyOffset(FlushMainAudioDevice_FunctionAddress, "DeviceID");
		FlushMainAudioDevice_DeviceID_IsValid = NativeReflectionCached.ValidatePropertyClass(FlushMainAudioDevice_FunctionAddress, "DeviceID", Classes.FIntProperty);
		FlushMainAudioDevice_IsValid = FlushMainAudioDevice_FunctionAddress != IntPtr.Zero && FlushMainAudioDevice_DeviceID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:FlushMainAudioDevice", FlushMainAudioDevice_IsValid);
		FindPathSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPathSync");
		FindPathSync_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPathSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPathSync_Controller_PropertyAddress, FindPathSync_FunctionAddress, "Controller");
		FindPathSync_Controller_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSync_FunctionAddress, "Controller");
		FindPathSync_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSync_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSync_TargetLocation_PropertyAddress, FindPathSync_FunctionAddress, "TargetLocation");
		FindPathSync_TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSync_FunctionAddress, "TargetLocation");
		FindPathSync_TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSync_FunctionAddress, "TargetLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSync_ReturnValue_PropertyAddress, FindPathSync_FunctionAddress, "ReturnValue");
		FindPathSync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSync_FunctionAddress, "ReturnValue");
		FindPathSync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSync_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindPathSync_IsValid = FindPathSync_FunctionAddress != IntPtr.Zero && FindPathSync_Controller_IsValid && FindPathSync_TargetLocation_IsValid && FindPathSync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:FindPathSync", FindPathSync_IsValid);
		FindNamedNetDriver_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNamedNetDriver");
		FindNamedNetDriver_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNamedNetDriver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNamedNetDriver_InWorld_PropertyAddress, FindNamedNetDriver_FunctionAddress, "InWorld");
		FindNamedNetDriver_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedNetDriver_FunctionAddress, "InWorld");
		FindNamedNetDriver_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedNetDriver_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNamedNetDriver_NetDriverName_PropertyAddress, FindNamedNetDriver_FunctionAddress, "NetDriverName");
		FindNamedNetDriver_NetDriverName_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedNetDriver_FunctionAddress, "NetDriverName");
		FindNamedNetDriver_NetDriverName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedNetDriver_FunctionAddress, "NetDriverName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNamedNetDriver_ReturnValue_PropertyAddress, FindNamedNetDriver_FunctionAddress, "ReturnValue");
		FindNamedNetDriver_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNamedNetDriver_FunctionAddress, "ReturnValue");
		FindNamedNetDriver_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNamedNetDriver_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindNamedNetDriver_IsValid = FindNamedNetDriver_FunctionAddress != IntPtr.Zero && FindNamedNetDriver_InWorld_IsValid && FindNamedNetDriver_NetDriverName_IsValid && FindNamedNetDriver_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:FindNamedNetDriver", FindNamedNetDriver_IsValid);
		FindAndPrintStaleRefsByObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAndPrintStaleRefsByObjectPath");
		FindAndPrintStaleRefsByObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAndPrintStaleRefsByObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAndPrintStaleRefsByObjectPath_InObjectPath_PropertyAddress, FindAndPrintStaleRefsByObjectPath_FunctionAddress, "InObjectPath");
		FindAndPrintStaleRefsByObjectPath_InObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(FindAndPrintStaleRefsByObjectPath_FunctionAddress, "InObjectPath");
		FindAndPrintStaleRefsByObjectPath_InObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAndPrintStaleRefsByObjectPath_FunctionAddress, "InObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAndPrintStaleRefsByObjectPath_ReturnValue_PropertyAddress, FindAndPrintStaleRefsByObjectPath_FunctionAddress, "ReturnValue");
		FindAndPrintStaleRefsByObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAndPrintStaleRefsByObjectPath_FunctionAddress, "ReturnValue");
		FindAndPrintStaleRefsByObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAndPrintStaleRefsByObjectPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FindAndPrintStaleRefsByObjectPath_IsValid = FindAndPrintStaleRefsByObjectPath_FunctionAddress != IntPtr.Zero && FindAndPrintStaleRefsByObjectPath_InObjectPath_IsValid && FindAndPrintStaleRefsByObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleRefsByObjectPath", FindAndPrintStaleRefsByObjectPath_IsValid);
		FindAndPrintStaleReferencesToObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAndPrintStaleReferencesToObject");
		FindAndPrintStaleReferencesToObject_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAndPrintStaleReferencesToObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAndPrintStaleReferencesToObject_Obj_PropertyAddress, FindAndPrintStaleReferencesToObject_FunctionAddress, "Obj");
		FindAndPrintStaleReferencesToObject_Obj_Offset = NativeReflectionCached.GetPropertyOffset(FindAndPrintStaleReferencesToObject_FunctionAddress, "Obj");
		FindAndPrintStaleReferencesToObject_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAndPrintStaleReferencesToObject_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAndPrintStaleReferencesToObject_ReturnValue_PropertyAddress, FindAndPrintStaleReferencesToObject_FunctionAddress, "ReturnValue");
		FindAndPrintStaleReferencesToObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAndPrintStaleReferencesToObject_FunctionAddress, "ReturnValue");
		FindAndPrintStaleReferencesToObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAndPrintStaleReferencesToObject_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FindAndPrintStaleReferencesToObject_IsValid = FindAndPrintStaleReferencesToObject_FunctionAddress != IntPtr.Zero && FindAndPrintStaleReferencesToObject_Obj_IsValid && FindAndPrintStaleReferencesToObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:FindAndPrintStaleReferencesToObject", FindAndPrintStaleReferencesToObject_IsValid);
		ExecCmdOutGLog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExecCmdOutGLog");
		ExecCmdOutGLog_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecCmdOutGLog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecCmdOutGLog_Cmd_PropertyAddress, ExecCmdOutGLog_FunctionAddress, "Cmd");
		ExecCmdOutGLog_Cmd_Offset = NativeReflectionCached.GetPropertyOffset(ExecCmdOutGLog_FunctionAddress, "Cmd");
		ExecCmdOutGLog_Cmd_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecCmdOutGLog_FunctionAddress, "Cmd", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecCmdOutGLog_WorldCtx_PropertyAddress, ExecCmdOutGLog_FunctionAddress, "WorldCtx");
		ExecCmdOutGLog_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(ExecCmdOutGLog_FunctionAddress, "WorldCtx");
		ExecCmdOutGLog_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecCmdOutGLog_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		ExecCmdOutGLog_IsValid = ExecCmdOutGLog_FunctionAddress != IntPtr.Zero && ExecCmdOutGLog_Cmd_IsValid && ExecCmdOutGLog_WorldCtx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ExecCmdOutGLog", ExecCmdOutGLog_IsValid);
		EngineGC_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineGC");
		EngineGC_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineGC_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineGC_bFullPurge_PropertyAddress, EngineGC_FunctionAddress, "bFullPurge");
		EngineGC_bFullPurge_Offset = NativeReflectionCached.GetPropertyOffset(EngineGC_FunctionAddress, "bFullPurge");
		EngineGC_bFullPurge_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineGC_FunctionAddress, "bFullPurge", Classes.FBoolProperty);
		EngineGC_IsValid = EngineGC_FunctionAddress != IntPtr.Zero && EngineGC_bFullPurge_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:EngineGC", EngineGC_IsValid);
		EnableForceStreamdOutLevelGCCheck_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableForceStreamdOutLevelGCCheck");
		EnableForceStreamdOutLevelGCCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableForceStreamdOutLevelGCCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableForceStreamdOutLevelGCCheck_Enable_PropertyAddress, EnableForceStreamdOutLevelGCCheck_FunctionAddress, "Enable");
		EnableForceStreamdOutLevelGCCheck_Enable_Offset = NativeReflectionCached.GetPropertyOffset(EnableForceStreamdOutLevelGCCheck_FunctionAddress, "Enable");
		EnableForceStreamdOutLevelGCCheck_Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableForceStreamdOutLevelGCCheck_FunctionAddress, "Enable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableForceStreamdOutLevelGCCheck_IgnoreEditor_PropertyAddress, EnableForceStreamdOutLevelGCCheck_FunctionAddress, "IgnoreEditor");
		EnableForceStreamdOutLevelGCCheck_IgnoreEditor_Offset = NativeReflectionCached.GetPropertyOffset(EnableForceStreamdOutLevelGCCheck_FunctionAddress, "IgnoreEditor");
		EnableForceStreamdOutLevelGCCheck_IgnoreEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableForceStreamdOutLevelGCCheck_FunctionAddress, "IgnoreEditor", Classes.FBoolProperty);
		EnableForceStreamdOutLevelGCCheck_IsValid = EnableForceStreamdOutLevelGCCheck_FunctionAddress != IntPtr.Zero && EnableForceStreamdOutLevelGCCheck_Enable_IsValid && EnableForceStreamdOutLevelGCCheck_IgnoreEditor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:EnableForceStreamdOutLevelGCCheck", EnableForceStreamdOutLevelGCCheck_IsValid);
		DuplicateAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateAsset");
		DuplicateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_AssetName_PropertyAddress, DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_PackagePath_PropertyAddress, DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_OriginalObject_PropertyAddress, DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "OriginalObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_ReturnValue_PropertyAddress, DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAsset_IsValid = DuplicateAsset_FunctionAddress != IntPtr.Zero && DuplicateAsset_AssetName_IsValid && DuplicateAsset_PackagePath_IsValid && DuplicateAsset_OriginalObject_IsValid && DuplicateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DuplicateAsset", DuplicateAsset_IsValid);
		DrawDebugCircleArc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawDebugCircleArc");
		DrawDebugCircleArc_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawDebugCircleArc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_WorldContextObject_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "WorldContextObject");
		DrawDebugCircleArc_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "WorldContextObject");
		DrawDebugCircleArc_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_Center_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "Center");
		DrawDebugCircleArc_Center_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "Center");
		DrawDebugCircleArc_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_Radius_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "Radius");
		DrawDebugCircleArc_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "Radius");
		DrawDebugCircleArc_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_Direction_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "Direction");
		DrawDebugCircleArc_Direction_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "Direction");
		DrawDebugCircleArc_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_AngleWidth_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "AngleWidth");
		DrawDebugCircleArc_AngleWidth_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "AngleWidth");
		DrawDebugCircleArc_AngleWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "AngleWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_NumSegments_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "NumSegments");
		DrawDebugCircleArc_NumSegments_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "NumSegments");
		DrawDebugCircleArc_NumSegments_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "NumSegments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_LineColor_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "LineColor");
		DrawDebugCircleArc_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "LineColor");
		DrawDebugCircleArc_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "LineColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_Duration_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "Duration");
		DrawDebugCircleArc_Duration_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "Duration");
		DrawDebugCircleArc_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugCircleArc_Thickness_PropertyAddress, DrawDebugCircleArc_FunctionAddress, "Thickness");
		DrawDebugCircleArc_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugCircleArc_FunctionAddress, "Thickness");
		DrawDebugCircleArc_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugCircleArc_FunctionAddress, "Thickness", Classes.FFloatProperty);
		DrawDebugCircleArc_IsValid = DrawDebugCircleArc_FunctionAddress != IntPtr.Zero && DrawDebugCircleArc_WorldContextObject_IsValid && DrawDebugCircleArc_Center_IsValid && DrawDebugCircleArc_Radius_IsValid && DrawDebugCircleArc_Direction_IsValid && DrawDebugCircleArc_AngleWidth_IsValid && DrawDebugCircleArc_NumSegments_IsValid && DrawDebugCircleArc_LineColor_IsValid && DrawDebugCircleArc_Duration_IsValid && DrawDebugCircleArc_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DrawDebugCircleArc", DrawDebugCircleArc_IsValid);
		DisableDebugExecBindings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableDebugExecBindings");
		DisableDebugExecBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableDebugExecBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableDebugExecBindings_WorldCtx_PropertyAddress, DisableDebugExecBindings_FunctionAddress, "WorldCtx");
		DisableDebugExecBindings_WorldCtx_Offset = NativeReflectionCached.GetPropertyOffset(DisableDebugExecBindings_FunctionAddress, "WorldCtx");
		DisableDebugExecBindings_WorldCtx_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableDebugExecBindings_FunctionAddress, "WorldCtx", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableDebugExecBindings_IsDisable_PropertyAddress, DisableDebugExecBindings_FunctionAddress, "IsDisable");
		DisableDebugExecBindings_IsDisable_Offset = NativeReflectionCached.GetPropertyOffset(DisableDebugExecBindings_FunctionAddress, "IsDisable");
		DisableDebugExecBindings_IsDisable_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableDebugExecBindings_FunctionAddress, "IsDisable", Classes.FBoolProperty);
		DisableDebugExecBindings_IsValid = DisableDebugExecBindings_FunctionAddress != IntPtr.Zero && DisableDebugExecBindings_WorldCtx_IsValid && DisableDebugExecBindings_IsDisable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DisableDebugExecBindings", DisableDebugExecBindings_IsValid);
		DetectDragIfPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetectDragIfPressed");
		DetectDragIfPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(DetectDragIfPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_PointerEvent_PropertyAddress, DetectDragIfPressed_FunctionAddress, "PointerEvent");
		DetectDragIfPressed_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "PointerEvent");
		DetectDragIfPressed_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress, DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag");
		DetectDragIfPressed_WidgetDetectingDrag_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag");
		DetectDragIfPressed_WidgetDetectingDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_KeyName_PropertyAddress, DetectDragIfPressed_FunctionAddress, "KeyName");
		DetectDragIfPressed_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "KeyName");
		DetectDragIfPressed_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_ReturnValue_PropertyAddress, DetectDragIfPressed_FunctionAddress, "ReturnValue");
		DetectDragIfPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "ReturnValue");
		DetectDragIfPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DetectDragIfPressed_IsValid = DetectDragIfPressed_FunctionAddress != IntPtr.Zero && DetectDragIfPressed_PointerEvent_IsValid && DetectDragIfPressed_WidgetDetectingDrag_IsValid && DetectDragIfPressed_KeyName_IsValid && DetectDragIfPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DetectDragIfPressed", DetectDragIfPressed_IsValid);
		DestroyActorsWithSpecifiedKeyword_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyActorsWithSpecifiedKeyword");
		DestroyActorsWithSpecifiedKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyActorsWithSpecifiedKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyActorsWithSpecifiedKeyword_InWorldContext_PropertyAddress, DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InWorldContext");
		DestroyActorsWithSpecifiedKeyword_InWorldContext_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InWorldContext");
		DestroyActorsWithSpecifiedKeyword_InWorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DestroyActorsWithSpecifiedKeyword_InKeyword_PropertyAddress, DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InKeyword");
		DestroyActorsWithSpecifiedKeyword_InKeyword_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InKeyword");
		DestroyActorsWithSpecifiedKeyword_InKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActorsWithSpecifiedKeyword_FunctionAddress, "InKeyword", Classes.FStrProperty);
		DestroyActorsWithSpecifiedKeyword_IsValid = DestroyActorsWithSpecifiedKeyword_FunctionAddress != IntPtr.Zero && DestroyActorsWithSpecifiedKeyword_InWorldContext_IsValid && DestroyActorsWithSpecifiedKeyword_InKeyword_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActorsWithSpecifiedKeyword", DestroyActorsWithSpecifiedKeyword_IsValid);
		DestroyActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyActor");
		DestroyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyActor_Actor_PropertyAddress, DestroyActor_FunctionAddress, "Actor");
		DestroyActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(DestroyActor_FunctionAddress, "Actor");
		DestroyActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		DestroyActor_IsValid = DestroyActor_FunctionAddress != IntPtr.Zero && DestroyActor_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DestroyActor", DestroyActor_IsValid);
		DelayGC_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DelayGC");
		DelayGC_ParamsSize = NativeReflection.GetFunctionParamsSize(DelayGC_FunctionAddress);
		DelayGC_IsValid = DelayGC_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:DelayGC", DelayGC_IsValid);
		CreateReplicationDriver_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateReplicationDriver");
		CreateReplicationDriver_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateReplicationDriver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateReplicationDriver_NetDriver_PropertyAddress, CreateReplicationDriver_FunctionAddress, "NetDriver");
		CreateReplicationDriver_NetDriver_Offset = NativeReflectionCached.GetPropertyOffset(CreateReplicationDriver_FunctionAddress, "NetDriver");
		CreateReplicationDriver_NetDriver_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateReplicationDriver_FunctionAddress, "NetDriver", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateReplicationDriver_World_PropertyAddress, CreateReplicationDriver_FunctionAddress, "World");
		CreateReplicationDriver_World_Offset = NativeReflectionCached.GetPropertyOffset(CreateReplicationDriver_FunctionAddress, "World");
		CreateReplicationDriver_World_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateReplicationDriver_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateReplicationDriver_ReturnValue_PropertyAddress, CreateReplicationDriver_FunctionAddress, "ReturnValue");
		CreateReplicationDriver_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateReplicationDriver_FunctionAddress, "ReturnValue");
		CreateReplicationDriver_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateReplicationDriver_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateReplicationDriver_IsValid = CreateReplicationDriver_FunctionAddress != IntPtr.Zero && CreateReplicationDriver_NetDriver_IsValid && CreateReplicationDriver_World_IsValid && CreateReplicationDriver_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CreateReplicationDriver", CreateReplicationDriver_IsValid);
		CreateNamedNetDriver_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNamedNetDriver");
		CreateNamedNetDriver_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNamedNetDriver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedNetDriver_InWorld_PropertyAddress, CreateNamedNetDriver_FunctionAddress, "InWorld");
		CreateNamedNetDriver_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedNetDriver_FunctionAddress, "InWorld");
		CreateNamedNetDriver_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedNetDriver_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedNetDriver_NetDriverName_PropertyAddress, CreateNamedNetDriver_FunctionAddress, "NetDriverName");
		CreateNamedNetDriver_NetDriverName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedNetDriver_FunctionAddress, "NetDriverName");
		CreateNamedNetDriver_NetDriverName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedNetDriver_FunctionAddress, "NetDriverName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNamedNetDriver_NetDriverDefinition_PropertyAddress, CreateNamedNetDriver_FunctionAddress, "NetDriverDefinition");
		CreateNamedNetDriver_NetDriverDefinition_Offset = NativeReflectionCached.GetPropertyOffset(CreateNamedNetDriver_FunctionAddress, "NetDriverDefinition");
		CreateNamedNetDriver_NetDriverDefinition_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNamedNetDriver_FunctionAddress, "NetDriverDefinition", Classes.FNameProperty);
		CreateNamedNetDriver_IsValid = CreateNamedNetDriver_FunctionAddress != IntPtr.Zero && CreateNamedNetDriver_InWorld_IsValid && CreateNamedNetDriver_NetDriverName_IsValid && CreateNamedNetDriver_NetDriverDefinition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CreateNamedNetDriver", CreateNamedNetDriver_IsValid);
		CreateDragDropOperation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateDragDropOperation");
		CreateDragDropOperation_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDragDropOperation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDragDropOperation_OperationClass_PropertyAddress, CreateDragDropOperation_FunctionAddress, "OperationClass");
		CreateDragDropOperation_OperationClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateDragDropOperation_FunctionAddress, "OperationClass");
		CreateDragDropOperation_OperationClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDragDropOperation_FunctionAddress, "OperationClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDragDropOperation_ReturnValue_PropertyAddress, CreateDragDropOperation_FunctionAddress, "ReturnValue");
		CreateDragDropOperation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDragDropOperation_FunctionAddress, "ReturnValue");
		CreateDragDropOperation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDragDropOperation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateDragDropOperation_IsValid = CreateDragDropOperation_FunctionAddress != IntPtr.Zero && CreateDragDropOperation_OperationClass_IsValid && CreateDragDropOperation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CreateDragDropOperation", CreateDragDropOperation_IsValid);
		CreateAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAsset");
		CreateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_Path_PropertyAddress, CreateAsset_FunctionAddress, "Path");
		CreateAsset_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "Path");
		CreateAsset_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_Name_PropertyAddress, CreateAsset_FunctionAddress, "Name");
		CreateAsset_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "Name");
		CreateAsset_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_CreatedClass_PropertyAddress, CreateAsset_FunctionAddress, "CreatedClass");
		CreateAsset_CreatedClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "CreatedClass");
		CreateAsset_CreatedClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "CreatedClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_ReturnValue_PropertyAddress, CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAsset_IsValid = CreateAsset_FunctionAddress != IntPtr.Zero && CreateAsset_Path_IsValid && CreateAsset_Name_IsValid && CreateAsset_CreatedClass_IsValid && CreateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CreateAsset", CreateAsset_IsValid);
		CopyToClipBoard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyToClipBoard");
		CopyToClipBoard_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyToClipBoard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyToClipBoard_InStr_PropertyAddress, CopyToClipBoard_FunctionAddress, "InStr");
		CopyToClipBoard_InStr_Offset = NativeReflectionCached.GetPropertyOffset(CopyToClipBoard_FunctionAddress, "InStr");
		CopyToClipBoard_InStr_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyToClipBoard_FunctionAddress, "InStr", Classes.FStrProperty);
		CopyToClipBoard_IsValid = CopyToClipBoard_FunctionAddress != IntPtr.Zero && CopyToClipBoard_InStr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CopyToClipBoard", CopyToClipBoard_IsValid);
		ConsoleVariableSetMouseCursor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsoleVariableSetMouseCursor");
		ConsoleVariableSetMouseCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsoleVariableSetMouseCursor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsoleVariableSetMouseCursor_MouseCursor_PropertyAddress, ConsoleVariableSetMouseCursor_FunctionAddress, "MouseCursor");
		ConsoleVariableSetMouseCursor_MouseCursor_Offset = NativeReflectionCached.GetPropertyOffset(ConsoleVariableSetMouseCursor_FunctionAddress, "MouseCursor");
		ConsoleVariableSetMouseCursor_MouseCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsoleVariableSetMouseCursor_FunctionAddress, "MouseCursor", Classes.FBoolProperty);
		ConsoleVariableSetMouseCursor_IsValid = ConsoleVariableSetMouseCursor_FunctionAddress != IntPtr.Zero && ConsoleVariableSetMouseCursor_MouseCursor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVariableSetMouseCursor", ConsoleVariableSetMouseCursor_IsValid);
		ConsoleVarGetInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsoleVarGetInt");
		ConsoleVarGetInt_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsoleVarGetInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsoleVarGetInt_Name_PropertyAddress, ConsoleVarGetInt_FunctionAddress, "Name");
		ConsoleVarGetInt_Name_Offset = NativeReflectionCached.GetPropertyOffset(ConsoleVarGetInt_FunctionAddress, "Name");
		ConsoleVarGetInt_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsoleVarGetInt_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsoleVarGetInt_ReturnValue_PropertyAddress, ConsoleVarGetInt_FunctionAddress, "ReturnValue");
		ConsoleVarGetInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConsoleVarGetInt_FunctionAddress, "ReturnValue");
		ConsoleVarGetInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsoleVarGetInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ConsoleVarGetInt_IsValid = ConsoleVarGetInt_FunctionAddress != IntPtr.Zero && ConsoleVarGetInt_Name_IsValid && ConsoleVarGetInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ConsoleVarGetInt", ConsoleVarGetInt_IsValid);
		CloseNetConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseNetConnection");
		CloseNetConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseNetConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseNetConnection_WorldContext_PropertyAddress, CloseNetConnection_FunctionAddress, "WorldContext");
		CloseNetConnection_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CloseNetConnection_FunctionAddress, "WorldContext");
		CloseNetConnection_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseNetConnection_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		CloseNetConnection_IsValid = CloseNetConnection_FunctionAddress != IntPtr.Zero && CloseNetConnection_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CloseNetConnection", CloseNetConnection_IsValid);
		ClientSeamlessTravel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClientSeamlessTravel");
		ClientSeamlessTravel_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientSeamlessTravel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientSeamlessTravel_PC_PropertyAddress, ClientSeamlessTravel_FunctionAddress, "PC");
		ClientSeamlessTravel_PC_Offset = NativeReflectionCached.GetPropertyOffset(ClientSeamlessTravel_FunctionAddress, "PC");
		ClientSeamlessTravel_PC_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientSeamlessTravel_FunctionAddress, "PC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientSeamlessTravel_Url_PropertyAddress, ClientSeamlessTravel_FunctionAddress, "Url");
		ClientSeamlessTravel_Url_Offset = NativeReflectionCached.GetPropertyOffset(ClientSeamlessTravel_FunctionAddress, "Url");
		ClientSeamlessTravel_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientSeamlessTravel_FunctionAddress, "Url", Classes.FStrProperty);
		ClientSeamlessTravel_IsValid = ClientSeamlessTravel_FunctionAddress != IntPtr.Zero && ClientSeamlessTravel_PC_IsValid && ClientSeamlessTravel_Url_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:ClientSeamlessTravel", ClientSeamlessTravel_IsValid);
		CaptureCurrentViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureCurrentViewport");
		CaptureCurrentViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureCurrentViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CaptureCurrentViewport_bCapture_PropertyAddress, CaptureCurrentViewport_FunctionAddress, "bCapture");
		CaptureCurrentViewport_bCapture_Offset = NativeReflectionCached.GetPropertyOffset(CaptureCurrentViewport_FunctionAddress, "bCapture");
		CaptureCurrentViewport_bCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureCurrentViewport_FunctionAddress, "bCapture", Classes.FBoolProperty);
		CaptureCurrentViewport_IsValid = CaptureCurrentViewport_FunctionAddress != IntPtr.Zero && CaptureCurrentViewport_bCapture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:CaptureCurrentViewport", CaptureCurrentViewport_IsValid);
		BlockTillSuspendedLevelsCompleted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlockTillSuspendedLevelsCompleted");
		BlockTillSuspendedLevelsCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(BlockTillSuspendedLevelsCompleted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlockTillSuspendedLevelsCompleted_WorldContextObject_PropertyAddress, BlockTillSuspendedLevelsCompleted_FunctionAddress, "WorldContextObject");
		BlockTillSuspendedLevelsCompleted_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BlockTillSuspendedLevelsCompleted_FunctionAddress, "WorldContextObject");
		BlockTillSuspendedLevelsCompleted_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BlockTillSuspendedLevelsCompleted_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BlockTillSuspendedLevelsCompleted_IsValid = BlockTillSuspendedLevelsCompleted_FunctionAddress != IntPtr.Zero && BlockTillSuspendedLevelsCompleted_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillSuspendedLevelsCompleted", BlockTillSuspendedLevelsCompleted_IsValid);
		BlockTillLevelStreamingCompleted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlockTillLevelStreamingCompleted");
		BlockTillLevelStreamingCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(BlockTillLevelStreamingCompleted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlockTillLevelStreamingCompleted_WorldContextObject_PropertyAddress, BlockTillLevelStreamingCompleted_FunctionAddress, "WorldContextObject");
		BlockTillLevelStreamingCompleted_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BlockTillLevelStreamingCompleted_FunctionAddress, "WorldContextObject");
		BlockTillLevelStreamingCompleted_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BlockTillLevelStreamingCompleted_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BlockTillLevelStreamingCompleted_IsValid = BlockTillLevelStreamingCompleted_FunctionAddress != IntPtr.Zero && BlockTillLevelStreamingCompleted_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BlockTillLevelStreamingCompleted", BlockTillLevelStreamingCompleted_IsValid);
		BinkMediaPlayerTimeSeek_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BinkMediaPlayerTimeSeek");
		BinkMediaPlayerTimeSeek_ParamsSize = NativeReflection.GetFunctionParamsSize(BinkMediaPlayerTimeSeek_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerTimeSeek_MediaPlayer_PropertyAddress, BinkMediaPlayerTimeSeek_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerTimeSeek_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerTimeSeek_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerTimeSeek_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerTimeSeek_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerTimeSeek_Time_PropertyAddress, BinkMediaPlayerTimeSeek_FunctionAddress, "Time");
		BinkMediaPlayerTimeSeek_Time_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerTimeSeek_FunctionAddress, "Time");
		BinkMediaPlayerTimeSeek_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerTimeSeek_FunctionAddress, "Time", Classes.FDoubleProperty);
		BinkMediaPlayerTimeSeek_IsValid = BinkMediaPlayerTimeSeek_FunctionAddress != IntPtr.Zero && BinkMediaPlayerTimeSeek_MediaPlayer_IsValid && BinkMediaPlayerTimeSeek_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerTimeSeek", BinkMediaPlayerTimeSeek_IsValid);
		BinkMediaPlayerGoToWithProcMs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BinkMediaPlayerGoToWithProcMs");
		BinkMediaPlayerGoToWithProcMs_ParamsSize = NativeReflection.GetFunctionParamsSize(BinkMediaPlayerGoToWithProcMs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoToWithProcMs_MediaPlayer_PropertyAddress, BinkMediaPlayerGoToWithProcMs_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerGoToWithProcMs_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerGoToWithProcMs_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoToWithProcMs_TargetFrame_PropertyAddress, BinkMediaPlayerGoToWithProcMs_FunctionAddress, "TargetFrame");
		BinkMediaPlayerGoToWithProcMs_TargetFrame_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "TargetFrame");
		BinkMediaPlayerGoToWithProcMs_TargetFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "TargetFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoToWithProcMs_ProcMS_PropertyAddress, BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ProcMS");
		BinkMediaPlayerGoToWithProcMs_ProcMS_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ProcMS");
		BinkMediaPlayerGoToWithProcMs_ProcMS_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ProcMS", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoToWithProcMs_ReturnValue_PropertyAddress, BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ReturnValue");
		BinkMediaPlayerGoToWithProcMs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ReturnValue");
		BinkMediaPlayerGoToWithProcMs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoToWithProcMs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BinkMediaPlayerGoToWithProcMs_IsValid = BinkMediaPlayerGoToWithProcMs_FunctionAddress != IntPtr.Zero && BinkMediaPlayerGoToWithProcMs_MediaPlayer_IsValid && BinkMediaPlayerGoToWithProcMs_TargetFrame_IsValid && BinkMediaPlayerGoToWithProcMs_ProcMS_IsValid && BinkMediaPlayerGoToWithProcMs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoToWithProcMs", BinkMediaPlayerGoToWithProcMs_IsValid);
		BinkMediaPlayerGoTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BinkMediaPlayerGoTo");
		BinkMediaPlayerGoTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BinkMediaPlayerGoTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoTo_MediaPlayer_PropertyAddress, BinkMediaPlayerGoTo_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerGoTo_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoTo_FunctionAddress, "MediaPlayer");
		BinkMediaPlayerGoTo_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoTo_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoTo_TargetFrame_PropertyAddress, BinkMediaPlayerGoTo_FunctionAddress, "TargetFrame");
		BinkMediaPlayerGoTo_TargetFrame_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoTo_FunctionAddress, "TargetFrame");
		BinkMediaPlayerGoTo_TargetFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoTo_FunctionAddress, "TargetFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkMediaPlayerGoTo_ReturnValue_PropertyAddress, BinkMediaPlayerGoTo_FunctionAddress, "ReturnValue");
		BinkMediaPlayerGoTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BinkMediaPlayerGoTo_FunctionAddress, "ReturnValue");
		BinkMediaPlayerGoTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BinkMediaPlayerGoTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BinkMediaPlayerGoTo_IsValid = BinkMediaPlayerGoTo_FunctionAddress != IntPtr.Zero && BinkMediaPlayerGoTo_MediaPlayer_IsValid && BinkMediaPlayerGoTo_TargetFrame_IsValid && BinkMediaPlayerGoTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BinkMediaPlayerGoTo", BinkMediaPlayerGoTo_IsValid);
		BindAudioUtilAndBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BindAudioUtilAndBox");
		BindAudioUtilAndBox_ParamsSize = NativeReflection.GetFunctionParamsSize(BindAudioUtilAndBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindAudioUtilAndBox_AudioUtilActor_PropertyAddress, BindAudioUtilAndBox_FunctionAddress, "AudioUtilActor");
		BindAudioUtilAndBox_AudioUtilActor_Offset = NativeReflectionCached.GetPropertyOffset(BindAudioUtilAndBox_FunctionAddress, "AudioUtilActor");
		BindAudioUtilAndBox_AudioUtilActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAudioUtilAndBox_FunctionAddress, "AudioUtilActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindAudioUtilAndBox_AudioBox_PropertyAddress, BindAudioUtilAndBox_FunctionAddress, "AudioBox");
		BindAudioUtilAndBox_AudioBox_Offset = NativeReflectionCached.GetPropertyOffset(BindAudioUtilAndBox_FunctionAddress, "AudioBox");
		BindAudioUtilAndBox_AudioBox_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAudioUtilAndBox_FunctionAddress, "AudioBox", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindAudioUtilAndBox_ReturnValue_PropertyAddress, BindAudioUtilAndBox_FunctionAddress, "ReturnValue");
		BindAudioUtilAndBox_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BindAudioUtilAndBox_FunctionAddress, "ReturnValue");
		BindAudioUtilAndBox_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAudioUtilAndBox_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BindAudioUtilAndBox_IsValid = BindAudioUtilAndBox_FunctionAddress != IntPtr.Zero && BindAudioUtilAndBox_AudioUtilActor_IsValid && BindAudioUtilAndBox_AudioBox_IsValid && BindAudioUtilAndBox_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:BindAudioUtilAndBox", BindAudioUtilAndBox_IsValid);
		AsyncDownloadImage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AsyncDownloadImage");
		AsyncDownloadImage_ParamsSize = NativeReflection.GetFunctionParamsSize(AsyncDownloadImage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsyncDownloadImage_Url_PropertyAddress, AsyncDownloadImage_FunctionAddress, "Url");
		AsyncDownloadImage_Url_Offset = NativeReflectionCached.GetPropertyOffset(AsyncDownloadImage_FunctionAddress, "Url");
		AsyncDownloadImage_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncDownloadImage_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AsyncDownloadImage_ReturnValue_PropertyAddress, AsyncDownloadImage_FunctionAddress, "ReturnValue");
		AsyncDownloadImage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsyncDownloadImage_FunctionAddress, "ReturnValue");
		AsyncDownloadImage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsyncDownloadImage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AsyncDownloadImage_IsValid = AsyncDownloadImage_FunctionAddress != IntPtr.Zero && AsyncDownloadImage_Url_IsValid && AsyncDownloadImage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:AsyncDownloadImage", AsyncDownloadImage_IsValid);
		AdjustPSOPrecompileBatch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AdjustPSOPrecompileBatch");
		AdjustPSOPrecompileBatch_ParamsSize = NativeReflection.GetFunctionParamsSize(AdjustPSOPrecompileBatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdjustPSOPrecompileBatch_BatchSize_PropertyAddress, AdjustPSOPrecompileBatch_FunctionAddress, "BatchSize");
		AdjustPSOPrecompileBatch_BatchSize_Offset = NativeReflectionCached.GetPropertyOffset(AdjustPSOPrecompileBatch_FunctionAddress, "BatchSize");
		AdjustPSOPrecompileBatch_BatchSize_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustPSOPrecompileBatch_FunctionAddress, "BatchSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AdjustPSOPrecompileBatch_BatchTime_PropertyAddress, AdjustPSOPrecompileBatch_FunctionAddress, "BatchTime");
		AdjustPSOPrecompileBatch_BatchTime_Offset = NativeReflectionCached.GetPropertyOffset(AdjustPSOPrecompileBatch_FunctionAddress, "BatchTime");
		AdjustPSOPrecompileBatch_BatchTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustPSOPrecompileBatch_FunctionAddress, "BatchTime", Classes.FFloatProperty);
		AdjustPSOPrecompileBatch_IsValid = AdjustPSOPrecompileBatch_FunctionAddress != IntPtr.Zero && AdjustPSOPrecompileBatch_BatchSize_IsValid && AdjustPSOPrecompileBatch_BatchTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EngineFuncLib:AdjustPSOPrecompileBatch", AdjustPSOPrecompileBatch_IsValid);
	}
}
