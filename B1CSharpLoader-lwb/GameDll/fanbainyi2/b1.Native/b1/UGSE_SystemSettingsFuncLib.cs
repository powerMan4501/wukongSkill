using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SystemSettingsFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVSyncEnabled_IsValid;

	private static IntPtr SetVSyncEnabled_FunctionAddress;

	private static int SetVSyncEnabled_ParamsSize;

	private static bool SetVSyncEnabled_bEnableVSync_IsValid;

	private static FFieldAddress SetVSyncEnabled_bEnableVSync_PropertyAddress;

	private static int SetVSyncEnabled_bEnableVSync_Offset;

	private static bool SetViewDistanceQuality_IsValid;

	private static IntPtr SetViewDistanceQuality_FunctionAddress;

	private static int SetViewDistanceQuality_ParamsSize;

	private static bool SetViewDistanceQuality_InViewDistanceQuality_IsValid;

	private static FFieldAddress SetViewDistanceQuality_InViewDistanceQuality_PropertyAddress;

	private static int SetViewDistanceQuality_InViewDistanceQuality_Offset;

	private static bool SetTextureQuality_IsValid;

	private static IntPtr SetTextureQuality_FunctionAddress;

	private static int SetTextureQuality_ParamsSize;

	private static bool SetTextureQuality_InTextureQuality_IsValid;

	private static FFieldAddress SetTextureQuality_InTextureQuality_PropertyAddress;

	private static int SetTextureQuality_InTextureQuality_Offset;

	private static bool SetTargetScreenModeV2_IsValid;

	private static IntPtr SetTargetScreenModeV2_FunctionAddress;

	private static int SetTargetScreenModeV2_ParamsSize;

	private static bool SetTargetScreenModeV2_TargetWindowMode_IsValid;

	private static FFieldAddress SetTargetScreenModeV2_TargetWindowMode_PropertyAddress;

	private static int SetTargetScreenModeV2_TargetWindowMode_Offset;

	private static bool SetTargetScreenMode_IsValid;

	private static IntPtr SetTargetScreenMode_FunctionAddress;

	private static int SetTargetScreenMode_ParamsSize;

	private static bool SetTargetScreenMode_TargetScreenMode_IsValid;

	private static FFieldAddress SetTargetScreenMode_TargetScreenMode_PropertyAddress;

	private static int SetTargetScreenMode_TargetScreenMode_Offset;

	private static bool SetTargetResolution_IsValid;

	private static IntPtr SetTargetResolution_FunctionAddress;

	private static int SetTargetResolution_ParamsSize;

	private static bool SetTargetResolution_TargetResolution_IsValid;

	private static FFieldAddress SetTargetResolution_TargetResolution_PropertyAddress;

	private static int SetTargetResolution_TargetResolution_Offset;

	private static bool SetTargetResolution_NeedFresh_IsValid;

	private static FFieldAddress SetTargetResolution_NeedFresh_PropertyAddress;

	private static int SetTargetResolution_NeedFresh_Offset;

	private static bool SetShadowQuality_IsValid;

	private static IntPtr SetShadowQuality_FunctionAddress;

	private static int SetShadowQuality_ParamsSize;

	private static bool SetShadowQuality_InShadowQuality_IsValid;

	private static FFieldAddress SetShadowQuality_InShadowQuality_PropertyAddress;

	private static int SetShadowQuality_InShadowQuality_Offset;

	private static bool SetShadingQuality_IsValid;

	private static IntPtr SetShadingQuality_FunctionAddress;

	private static int SetShadingQuality_ParamsSize;

	private static bool SetShadingQuality_InShadingQuality_IsValid;

	private static FFieldAddress SetShadingQuality_InShadingQuality_PropertyAddress;

	private static int SetShadingQuality_InShadingQuality_Offset;

	private static bool SetScreenPos_IsValid;

	private static IntPtr SetScreenPos_FunctionAddress;

	private static int SetScreenPos_ParamsSize;

	private static bool SetScreenPos_Position_IsValid;

	private static FFieldAddress SetScreenPos_Position_PropertyAddress;

	private static int SetScreenPos_Position_Offset;

	private static bool SetScalabilityQuality_IsValid;

	private static IntPtr SetScalabilityQuality_FunctionAddress;

	private static int SetScalabilityQuality_ParamsSize;

	private static bool SetScalabilityQuality_TargetGSQualityLevel_IsValid;

	private static FFieldAddress SetScalabilityQuality_TargetGSQualityLevel_PropertyAddress;

	private static int SetScalabilityQuality_TargetGSQualityLevel_Offset;

	private static bool SetScalabilityQualities_IsValid;

	private static IntPtr SetScalabilityQualities_FunctionAddress;

	private static int SetScalabilityQualities_ParamsSize;

	private static bool SetScalabilityQualities_Qualities_IsValid;

	private static FFieldAddress SetScalabilityQualities_Qualities_PropertyAddress;

	private static int SetScalabilityQualities_Qualities_Offset;

	private static bool SetResolutionQualityScale_IsValid;

	private static IntPtr SetResolutionQualityScale_FunctionAddress;

	private static int SetResolutionQualityScale_ParamsSize;

	private static bool SetResolutionQualityScale_InResolutionQualityScale_IsValid;

	private static FFieldAddress SetResolutionQualityScale_InResolutionQualityScale_PropertyAddress;

	private static int SetResolutionQualityScale_InResolutionQualityScale_Offset;

	private static bool SetResolutionQualityLevel_IsValid;

	private static IntPtr SetResolutionQualityLevel_FunctionAddress;

	private static int SetResolutionQualityLevel_ParamsSize;

	private static bool SetResolutionQualityLevel_InResolutionQualityLevel_IsValid;

	private static FFieldAddress SetResolutionQualityLevel_InResolutionQualityLevel_PropertyAddress;

	private static int SetResolutionQualityLevel_InResolutionQualityLevel_Offset;

	private static bool SetReflectionQuality_IsValid;

	private static IntPtr SetReflectionQuality_FunctionAddress;

	private static int SetReflectionQuality_ParamsSize;

	private static bool SetReflectionQuality_InReflectionQuality_IsValid;

	private static FFieldAddress SetReflectionQuality_InReflectionQuality_PropertyAddress;

	private static int SetReflectionQuality_InReflectionQuality_Offset;

	private static bool SetPriorityMode_IsValid;

	private static IntPtr SetPriorityMode_FunctionAddress;

	private static int SetPriorityMode_ParamsSize;

	private static bool SetPriorityMode_InPriorityMode_IsValid;

	private static FFieldAddress SetPriorityMode_InPriorityMode_PropertyAddress;

	private static int SetPriorityMode_InPriorityMode_Offset;

	private static bool SetPostProcessQuality_IsValid;

	private static IntPtr SetPostProcessQuality_FunctionAddress;

	private static int SetPostProcessQuality_ParamsSize;

	private static bool SetPostProcessQuality_InPostProcessQuality_IsValid;

	private static FFieldAddress SetPostProcessQuality_InPostProcessQuality_PropertyAddress;

	private static int SetPostProcessQuality_InPostProcessQuality_Offset;

	private static bool SetMonitorAsPrimaryV2_IsValid;

	private static IntPtr SetMonitorAsPrimaryV2_FunctionAddress;

	private static int SetMonitorAsPrimaryV2_ParamsSize;

	private static bool SetMonitorAsPrimaryV2_InMonitorID_IsValid;

	private static FFieldAddress SetMonitorAsPrimaryV2_InMonitorID_PropertyAddress;

	private static int SetMonitorAsPrimaryV2_InMonitorID_Offset;

	private static bool SetMonitorAsPrimary_IsValid;

	private static IntPtr SetMonitorAsPrimary_FunctionAddress;

	private static int SetMonitorAsPrimary_ParamsSize;

	private static bool SetMonitorAsPrimary_MonitorID_IsValid;

	private static FFieldAddress SetMonitorAsPrimary_MonitorID_PropertyAddress;

	private static int SetMonitorAsPrimary_MonitorID_Offset;

	private static bool SetGlobalIlluminationQuality_IsValid;

	private static IntPtr SetGlobalIlluminationQuality_FunctionAddress;

	private static int SetGlobalIlluminationQuality_ParamsSize;

	private static bool SetGlobalIlluminationQuality_InGIQuality_IsValid;

	private static FFieldAddress SetGlobalIlluminationQuality_InGIQuality_PropertyAddress;

	private static int SetGlobalIlluminationQuality_InGIQuality_Offset;

	private static bool SetFrameRateLimit_IsValid;

	private static IntPtr SetFrameRateLimit_FunctionAddress;

	private static int SetFrameRateLimit_ParamsSize;

	private static bool SetFrameRateLimit_InFrameRateLimit_IsValid;

	private static FFieldAddress SetFrameRateLimit_InFrameRateLimit_PropertyAddress;

	private static int SetFrameRateLimit_InFrameRateLimit_Offset;

	private static bool SetFoliageQuality_IsValid;

	private static IntPtr SetFoliageQuality_FunctionAddress;

	private static int SetFoliageQuality_ParamsSize;

	private static bool SetFoliageQuality_InFoliageQuality_IsValid;

	private static FFieldAddress SetFoliageQuality_InFoliageQuality_PropertyAddress;

	private static int SetFoliageQuality_InFoliageQuality_Offset;

	private static bool SetEffectsQuality_IsValid;

	private static IntPtr SetEffectsQuality_FunctionAddress;

	private static int SetEffectsQuality_ParamsSize;

	private static bool SetEffectsQuality_InEffectQuality_IsValid;

	private static FFieldAddress SetEffectsQuality_InEffectQuality_PropertyAddress;

	private static int SetEffectsQuality_InEffectQuality_Offset;

	private static bool SetAntiAliasingQuality_IsValid;

	private static IntPtr SetAntiAliasingQuality_FunctionAddress;

	private static int SetAntiAliasingQuality_ParamsSize;

	private static bool SetAntiAliasingQuality_InAntiAliasingQuality_IsValid;

	private static FFieldAddress SetAntiAliasingQuality_InAntiAliasingQuality_PropertyAddress;

	private static int SetAntiAliasingQuality_InAntiAliasingQuality_Offset;

	private static bool RefreshBenchmarkMonitor_IsValid;

	private static IntPtr RefreshBenchmarkMonitor_FunctionAddress;

	private static int RefreshBenchmarkMonitor_ParamsSize;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool GMChangeMonitorAsPrimary_IsValid;

	private static IntPtr GMChangeMonitorAsPrimary_FunctionAddress;

	private static int GMChangeMonitorAsPrimary_ParamsSize;

	private static bool GMChangeMonitorAsPrimary_MonitorIdx_IsValid;

	private static FFieldAddress GMChangeMonitorAsPrimary_MonitorIdx_PropertyAddress;

	private static int GMChangeMonitorAsPrimary_MonitorIdx_Offset;

	private static bool GetVSyncEnabled_IsValid;

	private static IntPtr GetVSyncEnabled_FunctionAddress;

	private static int GetVSyncEnabled_ParamsSize;

	private static bool GetVSyncEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetVSyncEnabled_ReturnValue_PropertyAddress;

	private static int GetVSyncEnabled_ReturnValue_Offset;

	private static bool GetUsedGraphicsMemory_IsValid;

	private static IntPtr GetUsedGraphicsMemory_FunctionAddress;

	private static int GetUsedGraphicsMemory_ParamsSize;

	private static bool GetUsedGraphicsMemory_InQueryType_IsValid;

	private static FFieldAddress GetUsedGraphicsMemory_InQueryType_PropertyAddress;

	private static int GetUsedGraphicsMemory_InQueryType_Offset;

	private static bool GetUsedGraphicsMemory_ReturnValue_IsValid;

	private static FFieldAddress GetUsedGraphicsMemory_ReturnValue_PropertyAddress;

	private static int GetUsedGraphicsMemory_ReturnValue_Offset;

	private static bool GetScreenSize_IsValid;

	private static IntPtr GetScreenSize_FunctionAddress;

	private static int GetScreenSize_ParamsSize;

	private static bool GetScreenSize_ReturnValue_IsValid;

	private static FFieldAddress GetScreenSize_ReturnValue_PropertyAddress;

	private static int GetScreenSize_ReturnValue_Offset;

	private static bool GetResolutionScaleFromQualityLevel_IsValid;

	private static IntPtr GetResolutionScaleFromQualityLevel_FunctionAddress;

	private static int GetResolutionScaleFromQualityLevel_ParamsSize;

	private static bool GetResolutionScaleFromQualityLevel_InQualityLevel_IsValid;

	private static FFieldAddress GetResolutionScaleFromQualityLevel_InQualityLevel_PropertyAddress;

	private static int GetResolutionScaleFromQualityLevel_InQualityLevel_Offset;

	private static bool GetResolutionScaleFromQualityLevel_ReturnValue_IsValid;

	private static FFieldAddress GetResolutionScaleFromQualityLevel_ReturnValue_PropertyAddress;

	private static int GetResolutionScaleFromQualityLevel_ReturnValue_Offset;

	private static bool GetRecommendedScalabilityQuality_IsValid;

	private static IntPtr GetRecommendedScalabilityQuality_FunctionAddress;

	private static int GetRecommendedScalabilityQuality_ParamsSize;

	private static bool GetRecommendedScalabilityQuality_bLogInfo_IsValid;

	private static FFieldAddress GetRecommendedScalabilityQuality_bLogInfo_PropertyAddress;

	private static int GetRecommendedScalabilityQuality_bLogInfo_Offset;

	private static bool GetRecommendedScalabilityQuality_ReturnValue_IsValid;

	private static FFieldAddress GetRecommendedScalabilityQuality_ReturnValue_PropertyAddress;

	private static int GetRecommendedScalabilityQuality_ReturnValue_Offset;

	private static bool GetProportionalResolutions_IsValid;

	private static IntPtr GetProportionalResolutions_FunctionAddress;

	private static int GetProportionalResolutions_ParamsSize;

	private static bool GetProportionalResolutions_AspectRatio_IsValid;

	private static FFieldAddress GetProportionalResolutions_AspectRatio_PropertyAddress;

	private static int GetProportionalResolutions_AspectRatio_Offset;

	private static bool GetProportionalResolutions_ReturnValue_IsValid;

	private static FFieldAddress GetProportionalResolutions_ReturnValue_PropertyAddress;

	private static int GetProportionalResolutions_ReturnValue_Offset;

	private static bool GetMaxRefreshRate_IsValid;

	private static IntPtr GetMaxRefreshRate_FunctionAddress;

	private static int GetMaxRefreshRate_ParamsSize;

	private static bool GetMaxRefreshRate_ReturnValue_IsValid;

	private static FFieldAddress GetMaxRefreshRate_ReturnValue_PropertyAddress;

	private static int GetMaxRefreshRate_ReturnValue_Offset;

	private static bool GetGSystemResolution_IsValid;

	private static IntPtr GetGSystemResolution_FunctionAddress;

	private static int GetGSystemResolution_ParamsSize;

	private static bool GetGSystemResolution_ReturnValue_IsValid;

	private static FFieldAddress GetGSystemResolution_ReturnValue_PropertyAddress;

	private static int GetGSystemResolution_ReturnValue_Offset;

	private static bool GetGraphicsMemoryInfo_IsValid;

	private static IntPtr GetGraphicsMemoryInfo_FunctionAddress;

	private static int GetGraphicsMemoryInfo_ParamsSize;

	private static bool GetGraphicsMemoryInfo_InGraphicsMemoryMode_IsValid;

	private static FFieldAddress GetGraphicsMemoryInfo_InGraphicsMemoryMode_PropertyAddress;

	private static int GetGraphicsMemoryInfo_InGraphicsMemoryMode_Offset;

	private static bool GetGraphicsMemoryInfo_ReturnValue_IsValid;

	private static FFieldAddress GetGraphicsMemoryInfo_ReturnValue_PropertyAddress;

	private static int GetGraphicsMemoryInfo_ReturnValue_Offset;

	private static bool GetGPUUsedTime_IsValid;

	private static IntPtr GetGPUUsedTime_FunctionAddress;

	private static int GetGPUUsedTime_ParamsSize;

	private static bool GetGPUUsedTime_ReturnValue_IsValid;

	private static FFieldAddress GetGPUUsedTime_ReturnValue_PropertyAddress;

	private static int GetGPUUsedTime_ReturnValue_Offset;

	private static bool GetGPUUsedPercentage_IsValid;

	private static IntPtr GetGPUUsedPercentage_FunctionAddress;

	private static int GetGPUUsedPercentage_ParamsSize;

	private static bool GetGPUUsedPercentage_ReturnValue_IsValid;

	private static FFieldAddress GetGPUUsedPercentage_ReturnValue_PropertyAddress;

	private static int GetGPUUsedPercentage_ReturnValue_Offset;

	private static bool GetFrameRateLimit_IsValid;

	private static IntPtr GetFrameRateLimit_FunctionAddress;

	private static int GetFrameRateLimit_ParamsSize;

	private static bool GetFrameRateLimit_ReturnValue_IsValid;

	private static FFieldAddress GetFrameRateLimit_ReturnValue_PropertyAddress;

	private static int GetFrameRateLimit_ReturnValue_Offset;

	private static bool GetCurrentScreenModeV2_IsValid;

	private static IntPtr GetCurrentScreenModeV2_FunctionAddress;

	private static int GetCurrentScreenModeV2_ParamsSize;

	private static bool GetCurrentScreenModeV2_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentScreenModeV2_ReturnValue_PropertyAddress;

	private static int GetCurrentScreenModeV2_ReturnValue_Offset;

	private static bool GetCurrentScreenMode_IsValid;

	private static IntPtr GetCurrentScreenMode_FunctionAddress;

	private static int GetCurrentScreenMode_ParamsSize;

	private static bool GetCurrentScreenMode_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentScreenMode_ReturnValue_PropertyAddress;

	private static int GetCurrentScreenMode_ReturnValue_Offset;

	private static bool GetCurrentScalabilityQuality_IsValid;

	private static IntPtr GetCurrentScalabilityQuality_FunctionAddress;

	private static int GetCurrentScalabilityQuality_ParamsSize;

	private static bool GetCurrentScalabilityQuality_bLogInfo_IsValid;

	private static FFieldAddress GetCurrentScalabilityQuality_bLogInfo_PropertyAddress;

	private static int GetCurrentScalabilityQuality_bLogInfo_Offset;

	private static bool GetCurrentScalabilityQuality_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentScalabilityQuality_ReturnValue_PropertyAddress;

	private static int GetCurrentScalabilityQuality_ReturnValue_Offset;

	private static bool GetCurrentScalabilityQualities_IsValid;

	private static IntPtr GetCurrentScalabilityQualities_FunctionAddress;

	private static int GetCurrentScalabilityQualities_ParamsSize;

	private static bool GetCurrentScalabilityQualities_bLogInfo_IsValid;

	private static FFieldAddress GetCurrentScalabilityQualities_bLogInfo_PropertyAddress;

	private static int GetCurrentScalabilityQualities_bLogInfo_Offset;

	private static bool GetCurrentScalabilityQualities_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentScalabilityQualities_ReturnValue_PropertyAddress;

	private static int GetCurrentScalabilityQualities_ReturnValue_Offset;

	private static bool GetCurrentResolution_IsValid;

	private static IntPtr GetCurrentResolution_FunctionAddress;

	private static int GetCurrentResolution_ParamsSize;

	private static bool GetCurrentResolution_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentResolution_ReturnValue_PropertyAddress;

	private static int GetCurrentResolution_ReturnValue_Offset;

	private static bool GetCurrentFPS_IsValid;

	private static IntPtr GetCurrentFPS_FunctionAddress;

	private static int GetCurrentFPS_ParamsSize;

	private static bool GetCurrentFPS_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFPS_ReturnValue_PropertyAddress;

	private static int GetCurrentFPS_ReturnValue_Offset;

	private static bool GetCPUUsedTime_IsValid;

	private static IntPtr GetCPUUsedTime_FunctionAddress;

	private static int GetCPUUsedTime_ParamsSize;

	private static bool GetCPUUsedTime_ReturnValue_IsValid;

	private static FFieldAddress GetCPUUsedTime_ReturnValue_PropertyAddress;

	private static int GetCPUUsedTime_ReturnValue_Offset;

	private static bool GetCPUUsedPercentage_IsValid;

	private static IntPtr GetCPUUsedPercentage_FunctionAddress;

	private static int GetCPUUsedPercentage_ParamsSize;

	private static bool GetCPUUsedPercentage_ReturnValue_IsValid;

	private static FFieldAddress GetCPUUsedPercentage_ReturnValue_PropertyAddress;

	private static int GetCPUUsedPercentage_ReturnValue_Offset;

	private static bool GetAvailableResolutionsByMonitorID_IsValid;

	private static IntPtr GetAvailableResolutionsByMonitorID_FunctionAddress;

	private static int GetAvailableResolutionsByMonitorID_ParamsSize;

	private static bool GetAvailableResolutionsByMonitorID_InMonitorID_IsValid;

	private static FFieldAddress GetAvailableResolutionsByMonitorID_InMonitorID_PropertyAddress;

	private static int GetAvailableResolutionsByMonitorID_InMonitorID_Offset;

	private static bool GetAvailableResolutionsByMonitorID_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableResolutionsByMonitorID_ReturnValue_PropertyAddress;

	private static int GetAvailableResolutionsByMonitorID_ReturnValue_Offset;

	private static bool GetAvailableResolutions_IsValid;

	private static IntPtr GetAvailableResolutions_FunctionAddress;

	private static int GetAvailableResolutions_ParamsSize;

	private static bool GetAvailableResolutions_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableResolutions_ReturnValue_PropertyAddress;

	private static int GetAvailableResolutions_ReturnValue_Offset;

	private static bool GetAvailableGraphicsMemory_IsValid;

	private static IntPtr GetAvailableGraphicsMemory_FunctionAddress;

	private static int GetAvailableGraphicsMemory_ParamsSize;

	private static bool GetAvailableGraphicsMemory_InQueryType_IsValid;

	private static FFieldAddress GetAvailableGraphicsMemory_InQueryType_PropertyAddress;

	private static int GetAvailableGraphicsMemory_InQueryType_Offset;

	private static bool GetAvailableGraphicsMemory_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableGraphicsMemory_ReturnValue_PropertyAddress;

	private static int GetAvailableGraphicsMemory_ReturnValue_Offset;

	private static bool GetAllMonitorInfo_IsValid;

	private static IntPtr GetAllMonitorInfo_FunctionAddress;

	private static int GetAllMonitorInfo_ParamsSize;

	private static bool GetAllMonitorInfo_ReturnValue_IsValid;

	private static FFieldAddress GetAllMonitorInfo_ReturnValue_PropertyAddress;

	private static int GetAllMonitorInfo_ReturnValue_Offset;

	private static bool EngineSettingGetString_IsValid;

	private static IntPtr EngineSettingGetString_FunctionAddress;

	private static int EngineSettingGetString_ParamsSize;

	private static bool EngineSettingGetString_Section_IsValid;

	private static FFieldAddress EngineSettingGetString_Section_PropertyAddress;

	private static int EngineSettingGetString_Section_Offset;

	private static bool EngineSettingGetString_Key_IsValid;

	private static FFieldAddress EngineSettingGetString_Key_PropertyAddress;

	private static int EngineSettingGetString_Key_Offset;

	private static bool EngineSettingGetString_ReturnValue_IsValid;

	private static FFieldAddress EngineSettingGetString_ReturnValue_PropertyAddress;

	private static int EngineSettingGetString_ReturnValue_Offset;

	private static bool BGUUnBindOnViewportResizedEvent_IsValid;

	private static IntPtr BGUUnBindOnViewportResizedEvent_FunctionAddress;

	private static int BGUUnBindOnViewportResizedEvent_ParamsSize;

	private static bool BGUUnBindOnViewportResizedEvent_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnViewportResizedEvent_Obj_PropertyAddress;

	private static int BGUUnBindOnViewportResizedEvent_Obj_Offset;

	private static bool BGUUnBindOnViewportResizedEvent_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnViewportResizedEvent_FuncName_PropertyAddress;

	private static int BGUUnBindOnViewportResizedEvent_FuncName_Offset;

	private static bool BGUUnBindOnMonitorAsPrimaryChange_IsValid;

	private static IntPtr BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress;

	private static int BGUUnBindOnMonitorAsPrimaryChange_ParamsSize;

	private static bool BGUUnBindOnMonitorAsPrimaryChange_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnMonitorAsPrimaryChange_Obj_PropertyAddress;

	private static int BGUUnBindOnMonitorAsPrimaryChange_Obj_Offset;

	private static bool BGUUnBindOnMonitorAsPrimaryChange_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress;

	private static int BGUUnBindOnMonitorAsPrimaryChange_FuncName_Offset;

	private static bool BGUUnBindOnCultureChangedEvent_IsValid;

	private static IntPtr BGUUnBindOnCultureChangedEvent_FunctionAddress;

	private static int BGUUnBindOnCultureChangedEvent_ParamsSize;

	private static bool BGUUnBindOnCultureChangedEvent_Obj_IsValid;

	private static FFieldAddress BGUUnBindOnCultureChangedEvent_Obj_PropertyAddress;

	private static int BGUUnBindOnCultureChangedEvent_Obj_Offset;

	private static bool BGUUnBindOnCultureChangedEvent_FuncName_IsValid;

	private static FFieldAddress BGUUnBindOnCultureChangedEvent_FuncName_PropertyAddress;

	private static int BGUUnBindOnCultureChangedEvent_FuncName_Offset;

	private static bool BGUBindOnViewportResizedEvent_IsValid;

	private static IntPtr BGUBindOnViewportResizedEvent_FunctionAddress;

	private static int BGUBindOnViewportResizedEvent_ParamsSize;

	private static bool BGUBindOnViewportResizedEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnViewportResizedEvent_Obj_PropertyAddress;

	private static int BGUBindOnViewportResizedEvent_Obj_Offset;

	private static bool BGUBindOnViewportResizedEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnViewportResizedEvent_FuncName_PropertyAddress;

	private static int BGUBindOnViewportResizedEvent_FuncName_Offset;

	private static bool BGUBindOnMonitorAsPrimaryChange_IsValid;

	private static IntPtr BGUBindOnMonitorAsPrimaryChange_FunctionAddress;

	private static int BGUBindOnMonitorAsPrimaryChange_ParamsSize;

	private static bool BGUBindOnMonitorAsPrimaryChange_Obj_IsValid;

	private static FFieldAddress BGUBindOnMonitorAsPrimaryChange_Obj_PropertyAddress;

	private static int BGUBindOnMonitorAsPrimaryChange_Obj_Offset;

	private static bool BGUBindOnMonitorAsPrimaryChange_FuncName_IsValid;

	private static FFieldAddress BGUBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress;

	private static int BGUBindOnMonitorAsPrimaryChange_FuncName_Offset;

	private static bool BGUBindOnCultureChangedEvent_IsValid;

	private static IntPtr BGUBindOnCultureChangedEvent_FunctionAddress;

	private static int BGUBindOnCultureChangedEvent_ParamsSize;

	private static bool BGUBindOnCultureChangedEvent_Obj_IsValid;

	private static FFieldAddress BGUBindOnCultureChangedEvent_Obj_PropertyAddress;

	private static int BGUBindOnCultureChangedEvent_Obj_Offset;

	private static bool BGUBindOnCultureChangedEvent_FuncName_IsValid;

	private static FFieldAddress BGUBindOnCultureChangedEvent_FuncName_PropertyAddress;

	private static int BGUBindOnCultureChangedEvent_FuncName_Offset;

	private static bool ApplySystemSettings_IsValid;

	private static IntPtr ApplySystemSettings_FunctionAddress;

	private static int ApplySystemSettings_ParamsSize;

	private static bool ApplySystemSettings_bSaveSettings_IsValid;

	private static FFieldAddress ApplySystemSettings_bSaveSettings_PropertyAddress;

	private static int ApplySystemSettings_bSaveSettings_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetVSyncEnabled")]
	public unsafe static void SetVSyncEnabled(bool bEnableVSync)
	{
		if (!SetVSyncEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetVSyncEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVSyncEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVSyncEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVSyncEnabled_bEnableVSync_Offset), 0, SetVSyncEnabled_bEnableVSync_PropertyAddress.Address, bEnableVSync);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVSyncEnabled_FunctionAddress, intPtr, SetVSyncEnabled_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetViewDistanceQuality")]
	public unsafe static void SetViewDistanceQuality(EScalabilityQuality InViewDistanceQuality)
	{
		if (!SetViewDistanceQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetViewDistanceQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewDistanceQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewDistanceQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetViewDistanceQuality_InViewDistanceQuality_Offset), 0, SetViewDistanceQuality_InViewDistanceQuality_PropertyAddress.Address, InViewDistanceQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewDistanceQuality_FunctionAddress, intPtr, SetViewDistanceQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTextureQuality")]
	public unsafe static void SetTextureQuality(EScalabilityQuality InTextureQuality)
	{
		if (!SetTextureQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTextureQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetTextureQuality_InTextureQuality_Offset), 0, SetTextureQuality_InTextureQuality_PropertyAddress.Address, InTextureQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTextureQuality_FunctionAddress, intPtr, SetTextureQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenModeV2")]
	public unsafe static void SetTargetScreenModeV2(EWindowMode TargetWindowMode)
	{
		if (!SetTargetScreenModeV2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenModeV2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetScreenModeV2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetScreenModeV2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWindowMode>.ToNative(IntPtr.Add(intPtr, SetTargetScreenModeV2_TargetWindowMode_Offset), 0, SetTargetScreenModeV2_TargetWindowMode_PropertyAddress.Address, TargetWindowMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTargetScreenModeV2_FunctionAddress, intPtr, SetTargetScreenModeV2_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenMode")]
	public unsafe static void SetTargetScreenMode(EGSScreenMode TargetScreenMode)
	{
		if (!SetTargetScreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetScreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetScreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSScreenMode>.ToNative(IntPtr.Add(intPtr, SetTargetScreenMode_TargetScreenMode_Offset), 0, SetTargetScreenMode_TargetScreenMode_PropertyAddress.Address, TargetScreenMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTargetScreenMode_FunctionAddress, intPtr, SetTargetScreenMode_ParamsSize);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetResolution")]
	public unsafe static void SetTargetResolution(FIntPoint TargetResolution, bool NeedFresh = true)
	{
		if (!SetTargetResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetResolution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, SetTargetResolution_TargetResolution_Offset), 0, SetTargetResolution_TargetResolution_PropertyAddress.Address, TargetResolution);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTargetResolution_NeedFresh_Offset), 0, SetTargetResolution_NeedFresh_PropertyAddress.Address, NeedFresh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTargetResolution_FunctionAddress, intPtr, SetTargetResolution_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadowQuality")]
	public unsafe static void SetShadowQuality(EScalabilityQuality InShadowQuality)
	{
		if (!SetShadowQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadowQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetShadowQuality_InShadowQuality_Offset), 0, SetShadowQuality_InShadowQuality_PropertyAddress.Address, InShadowQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetShadowQuality_FunctionAddress, intPtr, SetShadowQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadingQuality")]
	public unsafe static void SetShadingQuality(EScalabilityQuality InShadingQuality)
	{
		if (!SetShadingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetShadingQuality_InShadingQuality_Offset), 0, SetShadingQuality_InShadingQuality_PropertyAddress.Address, InShadingQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetShadingQuality_FunctionAddress, intPtr, SetShadingQuality_ParamsSize);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScreenPos")]
	public unsafe static void SetScreenPos(FVector2D Position)
	{
		if (!SetScreenPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScreenPos");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScreenPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScreenPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetScreenPos_Position_Offset), 0, SetScreenPos_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScreenPos_FunctionAddress, intPtr, SetScreenPos_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQuality")]
	public unsafe static void SetScalabilityQuality(EScalabilityQuality TargetGSQualityLevel)
	{
		if (!SetScalabilityQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalabilityQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalabilityQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetScalabilityQuality_TargetGSQualityLevel_Offset), 0, SetScalabilityQuality_TargetGSQualityLevel_PropertyAddress.Address, TargetGSQualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalabilityQuality_FunctionAddress, intPtr, SetScalabilityQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQualities")]
	public unsafe static void SetScalabilityQualities(FGSScalabilityQualities Qualities)
	{
		if (!SetScalabilityQualities_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQualities");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalabilityQualities_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalabilityQualities_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FGSScalabilityQualities>.ToNative(IntPtr.Add(intPtr, SetScalabilityQualities_Qualities_Offset), 0, SetScalabilityQualities_Qualities_PropertyAddress.Address, Qualities);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalabilityQualities_FunctionAddress, intPtr, SetScalabilityQualities_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityScale")]
	public unsafe static void SetResolutionQualityScale(float InResolutionQualityScale)
	{
		if (!SetResolutionQualityScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetResolutionQualityScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetResolutionQualityScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetResolutionQualityScale_InResolutionQualityScale_Offset), 0, SetResolutionQualityScale_InResolutionQualityScale_PropertyAddress.Address, InResolutionQualityScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetResolutionQualityScale_FunctionAddress, intPtr, SetResolutionQualityScale_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityLevel")]
	public unsafe static void SetResolutionQualityLevel(EScalabilityQuality InResolutionQualityLevel)
	{
		if (!SetResolutionQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetResolutionQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetResolutionQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetResolutionQualityLevel_InResolutionQualityLevel_Offset), 0, SetResolutionQualityLevel_InResolutionQualityLevel_PropertyAddress.Address, InResolutionQualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetResolutionQualityLevel_FunctionAddress, intPtr, SetResolutionQualityLevel_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetReflectionQuality")]
	public unsafe static void SetReflectionQuality(EScalabilityQuality InReflectionQuality)
	{
		if (!SetReflectionQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetReflectionQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReflectionQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReflectionQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetReflectionQuality_InReflectionQuality_Offset), 0, SetReflectionQuality_InReflectionQuality_PropertyAddress.Address, InReflectionQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetReflectionQuality_FunctionAddress, intPtr, SetReflectionQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPriorityMode")]
	public unsafe static void SetPriorityMode(EGSPriorityMode InPriorityMode)
	{
		if (!SetPriorityMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPriorityMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPriorityMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPriorityMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSPriorityMode>.ToNative(IntPtr.Add(intPtr, SetPriorityMode_InPriorityMode_Offset), 0, SetPriorityMode_InPriorityMode_PropertyAddress.Address, InPriorityMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPriorityMode_FunctionAddress, intPtr, SetPriorityMode_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPostProcessQuality")]
	public unsafe static void SetPostProcessQuality(EScalabilityQuality InPostProcessQuality)
	{
		if (!SetPostProcessQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPostProcessQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostProcessQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostProcessQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetPostProcessQuality_InPostProcessQuality_Offset), 0, SetPostProcessQuality_InPostProcessQuality_PropertyAddress.Address, InPostProcessQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPostProcessQuality_FunctionAddress, intPtr, SetPostProcessQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimaryV2")]
	public unsafe static void SetMonitorAsPrimaryV2(string InMonitorID)
	{
		if (!SetMonitorAsPrimaryV2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimaryV2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMonitorAsPrimaryV2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMonitorAsPrimaryV2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMonitorAsPrimaryV2_InMonitorID_Offset), 0, SetMonitorAsPrimaryV2_InMonitorID_PropertyAddress.Address, InMonitorID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMonitorAsPrimaryV2_FunctionAddress, intPtr, SetMonitorAsPrimaryV2_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMonitorAsPrimaryV2_InMonitorID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimary")]
	public unsafe static void SetMonitorAsPrimary(string MonitorID)
	{
		if (!SetMonitorAsPrimary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimary");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMonitorAsPrimary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMonitorAsPrimary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMonitorAsPrimary_MonitorID_Offset), 0, SetMonitorAsPrimary_MonitorID_PropertyAddress.Address, MonitorID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMonitorAsPrimary_FunctionAddress, intPtr, SetMonitorAsPrimary_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMonitorAsPrimary_MonitorID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetGlobalIlluminationQuality")]
	public unsafe static void SetGlobalIlluminationQuality(EScalabilityQuality InGIQuality)
	{
		if (!SetGlobalIlluminationQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetGlobalIlluminationQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalIlluminationQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalIlluminationQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetGlobalIlluminationQuality_InGIQuality_Offset), 0, SetGlobalIlluminationQuality_InGIQuality_PropertyAddress.Address, InGIQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGlobalIlluminationQuality_FunctionAddress, intPtr, SetGlobalIlluminationQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFrameRateLimit")]
	public unsafe static void SetFrameRateLimit(float InFrameRateLimit)
	{
		if (!SetFrameRateLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFrameRateLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRateLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRateLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrameRateLimit_InFrameRateLimit_Offset), 0, SetFrameRateLimit_InFrameRateLimit_PropertyAddress.Address, InFrameRateLimit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFrameRateLimit_FunctionAddress, intPtr, SetFrameRateLimit_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFoliageQuality")]
	public unsafe static void SetFoliageQuality(EScalabilityQuality InFoliageQuality)
	{
		if (!SetFoliageQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFoliageQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFoliageQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFoliageQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetFoliageQuality_InFoliageQuality_Offset), 0, SetFoliageQuality_InFoliageQuality_PropertyAddress.Address, InFoliageQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFoliageQuality_FunctionAddress, intPtr, SetFoliageQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetEffectsQuality")]
	public unsafe static void SetEffectsQuality(EScalabilityQuality InEffectQuality)
	{
		if (!SetEffectsQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetEffectsQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEffectsQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEffectsQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetEffectsQuality_InEffectQuality_Offset), 0, SetEffectsQuality_InEffectQuality_PropertyAddress.Address, InEffectQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEffectsQuality_FunctionAddress, intPtr, SetEffectsQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetAntiAliasingQuality")]
	public unsafe static void SetAntiAliasingQuality(EScalabilityQuality InAntiAliasingQuality)
	{
		if (!SetAntiAliasingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetAntiAliasingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAntiAliasingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAntiAliasingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, SetAntiAliasingQuality_InAntiAliasingQuality_Offset), 0, SetAntiAliasingQuality_InAntiAliasingQuality_PropertyAddress.Address, InAntiAliasingQuality);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAntiAliasingQuality_FunctionAddress, intPtr, SetAntiAliasingQuality_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:RefreshBenchmarkMonitor")]
	public unsafe static void RefreshBenchmarkMonitor()
	{
		if (!RefreshBenchmarkMonitor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:RefreshBenchmarkMonitor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshBenchmarkMonitor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshBenchmarkMonitor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RefreshBenchmarkMonitor_FunctionAddress, argsSize: RefreshBenchmarkMonitor_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:Init")]
	public unsafe static void Init()
	{
		if (!Init_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:Init");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Init_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Init_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: Init_FunctionAddress, argsSize: Init_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GMChangeMonitorAsPrimary")]
	public unsafe static void GMChangeMonitorAsPrimary(int MonitorIdx)
	{
		if (!GMChangeMonitorAsPrimary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GMChangeMonitorAsPrimary");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GMChangeMonitorAsPrimary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GMChangeMonitorAsPrimary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GMChangeMonitorAsPrimary_MonitorIdx_Offset), 0, GMChangeMonitorAsPrimary_MonitorIdx_PropertyAddress.Address, MonitorIdx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GMChangeMonitorAsPrimary_FunctionAddress, intPtr, GMChangeMonitorAsPrimary_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetVSyncEnabled")]
	public unsafe static bool GetVSyncEnabled()
	{
		if (!GetVSyncEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetVSyncEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVSyncEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVSyncEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVSyncEnabled_FunctionAddress, intPtr, GetVSyncEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVSyncEnabled_ReturnValue_Offset), 0, GetVSyncEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetUsedGraphicsMemory")]
	public unsafe static float GetUsedGraphicsMemory(EGSGraphicsMemoryMode InQueryType = EGSGraphicsMemoryMode.DEDICATED)
	{
		if (!GetUsedGraphicsMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetUsedGraphicsMemory");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUsedGraphicsMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUsedGraphicsMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSGraphicsMemoryMode>.ToNative(IntPtr.Add(intPtr, GetUsedGraphicsMemory_InQueryType_Offset), 0, GetUsedGraphicsMemory_InQueryType_PropertyAddress.Address, InQueryType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUsedGraphicsMemory_FunctionAddress, intPtr, GetUsedGraphicsMemory_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUsedGraphicsMemory_ReturnValue_Offset), 0, GetUsedGraphicsMemory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetScreenSize")]
	public unsafe static FVector2D GetScreenSize()
	{
		if (!GetScreenSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetScreenSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScreenSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScreenSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetScreenSize_FunctionAddress, intPtr, GetScreenSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetScreenSize_ReturnValue_Offset), 0, GetScreenSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetResolutionScaleFromQualityLevel")]
	public unsafe static float GetResolutionScaleFromQualityLevel(EScalabilityQuality InQualityLevel)
	{
		if (!GetResolutionScaleFromQualityLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetResolutionScaleFromQualityLevel");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetResolutionScaleFromQualityLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetResolutionScaleFromQualityLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EScalabilityQuality>.ToNative(IntPtr.Add(intPtr, GetResolutionScaleFromQualityLevel_InQualityLevel_Offset), 0, GetResolutionScaleFromQualityLevel_InQualityLevel_PropertyAddress.Address, InQualityLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetResolutionScaleFromQualityLevel_FunctionAddress, intPtr, GetResolutionScaleFromQualityLevel_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetResolutionScaleFromQualityLevel_ReturnValue_Offset), 0, GetResolutionScaleFromQualityLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetRecommendedScalabilityQuality")]
	public unsafe static FGSScalabilityQualities GetRecommendedScalabilityQuality(bool bLogInfo = true)
	{
		if (!GetRecommendedScalabilityQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetRecommendedScalabilityQuality");
			return default(FGSScalabilityQualities);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRecommendedScalabilityQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRecommendedScalabilityQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRecommendedScalabilityQuality_bLogInfo_Offset), 0, GetRecommendedScalabilityQuality_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRecommendedScalabilityQuality_FunctionAddress, intPtr, GetRecommendedScalabilityQuality_ParamsSize);
		return BlittableTypeMarshaler<FGSScalabilityQualities>.FromNative(IntPtr.Add(intPtr, GetRecommendedScalabilityQuality_ReturnValue_Offset), 0, GetRecommendedScalabilityQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetProportionalResolutions")]
	public unsafe static List<FIntPoint> GetProportionalResolutions(FIntPoint AspectRatio)
	{
		if (!GetProportionalResolutions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetProportionalResolutions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProportionalResolutions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProportionalResolutions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, GetProportionalResolutions_AspectRatio_Offset), 0, GetProportionalResolutions_AspectRatio_PropertyAddress.Address, AspectRatio);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProportionalResolutions_FunctionAddress, intPtr, GetProportionalResolutions_ParamsSize);
		List<FIntPoint> result = new TArrayCopyMarshaler<FIntPoint>(1, GetProportionalResolutions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.FromNative, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.ToNative).FromNative(IntPtr.Add(intPtr, GetProportionalResolutions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetProportionalResolutions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetMaxRefreshRate")]
	public unsafe static int GetMaxRefreshRate()
	{
		if (!GetMaxRefreshRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetMaxRefreshRate");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxRefreshRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxRefreshRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMaxRefreshRate_FunctionAddress, intPtr, GetMaxRefreshRate_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaxRefreshRate_ReturnValue_Offset), 0, GetMaxRefreshRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGSystemResolution")]
	public unsafe static FIntPoint GetGSystemResolution()
	{
		if (!GetGSystemResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGSystemResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSystemResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSystemResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGSystemResolution_FunctionAddress, intPtr, GetGSystemResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetGSystemResolution_ReturnValue_Offset), 0, GetGSystemResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGraphicsMemoryInfo")]
	public unsafe static int GetGraphicsMemoryInfo(EGSGraphicsMemoryMode InGraphicsMemoryMode)
	{
		if (!GetGraphicsMemoryInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGraphicsMemoryInfo");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphicsMemoryInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphicsMemoryInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSGraphicsMemoryMode>.ToNative(IntPtr.Add(intPtr, GetGraphicsMemoryInfo_InGraphicsMemoryMode_Offset), 0, GetGraphicsMemoryInfo_InGraphicsMemoryMode_PropertyAddress.Address, InGraphicsMemoryMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGraphicsMemoryInfo_FunctionAddress, intPtr, GetGraphicsMemoryInfo_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetGraphicsMemoryInfo_ReturnValue_Offset), 0, GetGraphicsMemoryInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedTime")]
	public unsafe static float GetGPUUsedTime()
	{
		if (!GetGPUUsedTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGPUUsedTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGPUUsedTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGPUUsedTime_FunctionAddress, intPtr, GetGPUUsedTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGPUUsedTime_ReturnValue_Offset), 0, GetGPUUsedTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedPercentage")]
	public unsafe static int GetGPUUsedPercentage()
	{
		if (!GetGPUUsedPercentage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedPercentage");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGPUUsedPercentage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGPUUsedPercentage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGPUUsedPercentage_FunctionAddress, intPtr, GetGPUUsedPercentage_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetGPUUsedPercentage_ReturnValue_Offset), 0, GetGPUUsedPercentage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetFrameRateLimit")]
	public unsafe static float GetFrameRateLimit()
	{
		if (!GetFrameRateLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetFrameRateLimit");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameRateLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameRateLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFrameRateLimit_FunctionAddress, intPtr, GetFrameRateLimit_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFrameRateLimit_ReturnValue_Offset), 0, GetFrameRateLimit_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenModeV2")]
	public unsafe static EWindowMode GetCurrentScreenModeV2()
	{
		if (!GetCurrentScreenModeV2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenModeV2");
			return EWindowMode.Fullscreen;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentScreenModeV2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentScreenModeV2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentScreenModeV2_FunctionAddress, intPtr, GetCurrentScreenModeV2_ParamsSize);
		return EnumMarshaler<EWindowMode>.FromNative(IntPtr.Add(intPtr, GetCurrentScreenModeV2_ReturnValue_Offset), 0, GetCurrentScreenModeV2_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenMode")]
	public unsafe static EGSScreenMode GetCurrentScreenMode()
	{
		if (!GetCurrentScreenMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenMode");
			return EGSScreenMode.FULL_SCREEN;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentScreenMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentScreenMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentScreenMode_FunctionAddress, intPtr, GetCurrentScreenMode_ParamsSize);
		return EnumMarshaler<EGSScreenMode>.FromNative(IntPtr.Add(intPtr, GetCurrentScreenMode_ReturnValue_Offset), 0, GetCurrentScreenMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQuality")]
	public unsafe static FGSScalabilityQualities GetCurrentScalabilityQuality(bool bLogInfo = false)
	{
		if (!GetCurrentScalabilityQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQuality");
			return default(FGSScalabilityQualities);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentScalabilityQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentScalabilityQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetCurrentScalabilityQuality_bLogInfo_Offset), 0, GetCurrentScalabilityQuality_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentScalabilityQuality_FunctionAddress, intPtr, GetCurrentScalabilityQuality_ParamsSize);
		return BlittableTypeMarshaler<FGSScalabilityQualities>.FromNative(IntPtr.Add(intPtr, GetCurrentScalabilityQuality_ReturnValue_Offset), 0, GetCurrentScalabilityQuality_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQualities")]
	public unsafe static FGSScalabilityQualities GetCurrentScalabilityQualities(bool bLogInfo = false)
	{
		if (!GetCurrentScalabilityQualities_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQualities");
			return default(FGSScalabilityQualities);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentScalabilityQualities_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentScalabilityQualities_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetCurrentScalabilityQualities_bLogInfo_Offset), 0, GetCurrentScalabilityQualities_bLogInfo_PropertyAddress.Address, bLogInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentScalabilityQualities_FunctionAddress, intPtr, GetCurrentScalabilityQualities_ParamsSize);
		return BlittableTypeMarshaler<FGSScalabilityQualities>.FromNative(IntPtr.Add(intPtr, GetCurrentScalabilityQualities_ReturnValue_Offset), 0, GetCurrentScalabilityQualities_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75768833u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentResolution")]
	public unsafe static FIntPoint GetCurrentResolution()
	{
		if (!GetCurrentResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentResolution");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentResolution_FunctionAddress, intPtr, GetCurrentResolution_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetCurrentResolution_ReturnValue_Offset), 0, GetCurrentResolution_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentFPS")]
	public unsafe static float GetCurrentFPS()
	{
		if (!GetCurrentFPS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentFPS");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFPS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFPS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentFPS_FunctionAddress, intPtr, GetCurrentFPS_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentFPS_ReturnValue_Offset), 0, GetCurrentFPS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedTime")]
	public unsafe static float GetCPUUsedTime()
	{
		if (!GetCPUUsedTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCPUUsedTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCPUUsedTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCPUUsedTime_FunctionAddress, intPtr, GetCPUUsedTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCPUUsedTime_ReturnValue_Offset), 0, GetCPUUsedTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedPercentage")]
	public unsafe static int GetCPUUsedPercentage()
	{
		if (!GetCPUUsedPercentage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedPercentage");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCPUUsedPercentage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCPUUsedPercentage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCPUUsedPercentage_FunctionAddress, intPtr, GetCPUUsedPercentage_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCPUUsedPercentage_ReturnValue_Offset), 0, GetCPUUsedPercentage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutionsByMonitorID")]
	public unsafe static List<FIntPoint> GetAvailableResolutionsByMonitorID(int InMonitorID)
	{
		if (!GetAvailableResolutionsByMonitorID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutionsByMonitorID");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableResolutionsByMonitorID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableResolutionsByMonitorID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAvailableResolutionsByMonitorID_InMonitorID_Offset), 0, GetAvailableResolutionsByMonitorID_InMonitorID_PropertyAddress.Address, InMonitorID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableResolutionsByMonitorID_FunctionAddress, intPtr, GetAvailableResolutionsByMonitorID_ParamsSize);
		List<FIntPoint> result = new TArrayCopyMarshaler<FIntPoint>(1, GetAvailableResolutionsByMonitorID_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.FromNative, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAvailableResolutionsByMonitorID_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAvailableResolutionsByMonitorID_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutions")]
	public unsafe static List<FIntPoint> GetAvailableResolutions()
	{
		if (!GetAvailableResolutions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableResolutions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableResolutions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableResolutions_FunctionAddress, intPtr, GetAvailableResolutions_ParamsSize);
		List<FIntPoint> result = new TArrayCopyMarshaler<FIntPoint>(1, GetAvailableResolutions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.FromNative, CachedMarshalingDelegates<FIntPoint, BlittableTypeMarshaler<FIntPoint>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAvailableResolutions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAvailableResolutions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableGraphicsMemory")]
	public unsafe static float GetAvailableGraphicsMemory(EGSGraphicsMemoryMode InQueryType = EGSGraphicsMemoryMode.DEDICATED)
	{
		if (!GetAvailableGraphicsMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableGraphicsMemory");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableGraphicsMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableGraphicsMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSGraphicsMemoryMode>.ToNative(IntPtr.Add(intPtr, GetAvailableGraphicsMemory_InQueryType_Offset), 0, GetAvailableGraphicsMemory_InQueryType_PropertyAddress.Address, InQueryType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableGraphicsMemory_FunctionAddress, intPtr, GetAvailableGraphicsMemory_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAvailableGraphicsMemory_ReturnValue_Offset), 0, GetAvailableGraphicsMemory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAllMonitorInfo")]
	public unsafe static List<FGSMonitorInfo> GetAllMonitorInfo()
	{
		if (!GetAllMonitorInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAllMonitorInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllMonitorInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllMonitorInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllMonitorInfo_FunctionAddress, intPtr, GetAllMonitorInfo_ParamsSize);
		List<FGSMonitorInfo> result = new TArrayCopyMarshaler<FGSMonitorInfo>(1, GetAllMonitorInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSMonitorInfo, FGSMonitorInfo>.FromNative, CachedMarshalingDelegates<FGSMonitorInfo, FGSMonitorInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllMonitorInfo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllMonitorInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:EngineSettingGetString")]
	public unsafe static string EngineSettingGetString(string Section, string Key)
	{
		if (!EngineSettingGetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:EngineSettingGetString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EngineSettingGetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EngineSettingGetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EngineSettingGetString_Section_Offset), 0, EngineSettingGetString_Section_PropertyAddress.Address, Section);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EngineSettingGetString_Key_Offset), 0, EngineSettingGetString_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EngineSettingGetString_FunctionAddress, intPtr, EngineSettingGetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EngineSettingGetString_Section_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EngineSettingGetString_Key_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, EngineSettingGetString_ReturnValue_Offset), 0, EngineSettingGetString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EngineSettingGetString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnViewportResizedEvent")]
	public unsafe static void BGUUnBindOnViewportResizedEvent(UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnViewportResizedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnViewportResizedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnViewportResizedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnViewportResizedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnViewportResizedEvent_Obj_Offset), 0, BGUUnBindOnViewportResizedEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnViewportResizedEvent_FuncName_Offset), 0, BGUUnBindOnViewportResizedEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnViewportResizedEvent_FunctionAddress, intPtr, BGUUnBindOnViewportResizedEvent_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnMonitorAsPrimaryChange")]
	public unsafe static void BGUUnBindOnMonitorAsPrimaryChange(UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnMonitorAsPrimaryChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnMonitorAsPrimaryChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnMonitorAsPrimaryChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnMonitorAsPrimaryChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnMonitorAsPrimaryChange_Obj_Offset), 0, BGUUnBindOnMonitorAsPrimaryChange_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnMonitorAsPrimaryChange_FuncName_Offset), 0, BGUUnBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, intPtr, BGUUnBindOnMonitorAsPrimaryChange_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnCultureChangedEvent")]
	public unsafe static void BGUUnBindOnCultureChangedEvent(UObject Obj, FName FuncName)
	{
		if (!BGUUnBindOnCultureChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnCultureChangedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnBindOnCultureChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnBindOnCultureChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnCultureChangedEvent_Obj_Offset), 0, BGUUnBindOnCultureChangedEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnBindOnCultureChangedEvent_FuncName_Offset), 0, BGUUnBindOnCultureChangedEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnBindOnCultureChangedEvent_FunctionAddress, intPtr, BGUUnBindOnCultureChangedEvent_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnViewportResizedEvent")]
	public unsafe static void BGUBindOnViewportResizedEvent(UObject Obj, FName FuncName)
	{
		if (!BGUBindOnViewportResizedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnViewportResizedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnViewportResizedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnViewportResizedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnViewportResizedEvent_Obj_Offset), 0, BGUBindOnViewportResizedEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnViewportResizedEvent_FuncName_Offset), 0, BGUBindOnViewportResizedEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnViewportResizedEvent_FunctionAddress, intPtr, BGUBindOnViewportResizedEvent_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnMonitorAsPrimaryChange")]
	public unsafe static void BGUBindOnMonitorAsPrimaryChange(UObject Obj, FName FuncName)
	{
		if (!BGUBindOnMonitorAsPrimaryChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnMonitorAsPrimaryChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnMonitorAsPrimaryChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnMonitorAsPrimaryChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnMonitorAsPrimaryChange_Obj_Offset), 0, BGUBindOnMonitorAsPrimaryChange_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnMonitorAsPrimaryChange_FuncName_Offset), 0, BGUBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnMonitorAsPrimaryChange_FunctionAddress, intPtr, BGUBindOnMonitorAsPrimaryChange_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnCultureChangedEvent")]
	public unsafe static void BGUBindOnCultureChangedEvent(UObject Obj, FName FuncName)
	{
		if (!BGUBindOnCultureChangedEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnCultureChangedEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBindOnCultureChangedEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBindOnCultureChangedEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBindOnCultureChangedEvent_Obj_Offset), 0, BGUBindOnCultureChangedEvent_Obj_PropertyAddress.Address, Obj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBindOnCultureChangedEvent_FuncName_Offset), 0, BGUBindOnCultureChangedEvent_FuncName_PropertyAddress.Address, FuncName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBindOnCultureChangedEvent_FunctionAddress, intPtr, BGUBindOnCultureChangedEvent_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:ApplySystemSettings")]
	public unsafe static void ApplySystemSettings(bool bSaveSettings)
	{
		if (!ApplySystemSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:ApplySystemSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplySystemSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplySystemSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplySystemSettings_bSaveSettings_Offset), 0, ApplySystemSettings_bSaveSettings_PropertyAddress.Address, bSaveSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplySystemSettings_FunctionAddress, intPtr, ApplySystemSettings_ParamsSize);
	}

	static UGSE_SystemSettingsFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SystemSettingsFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SystemSettingsFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SystemSettingsFuncLib");
		SetVSyncEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVSyncEnabled");
		SetVSyncEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVSyncEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVSyncEnabled_bEnableVSync_PropertyAddress, SetVSyncEnabled_FunctionAddress, "bEnableVSync");
		SetVSyncEnabled_bEnableVSync_Offset = NativeReflectionCached.GetPropertyOffset(SetVSyncEnabled_FunctionAddress, "bEnableVSync");
		SetVSyncEnabled_bEnableVSync_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVSyncEnabled_FunctionAddress, "bEnableVSync", Classes.FBoolProperty);
		SetVSyncEnabled_IsValid = SetVSyncEnabled_FunctionAddress != IntPtr.Zero && SetVSyncEnabled_bEnableVSync_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetVSyncEnabled", SetVSyncEnabled_IsValid);
		SetViewDistanceQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewDistanceQuality");
		SetViewDistanceQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewDistanceQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewDistanceQuality_InViewDistanceQuality_PropertyAddress, SetViewDistanceQuality_FunctionAddress, "InViewDistanceQuality");
		SetViewDistanceQuality_InViewDistanceQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetViewDistanceQuality_FunctionAddress, "InViewDistanceQuality");
		SetViewDistanceQuality_InViewDistanceQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewDistanceQuality_FunctionAddress, "InViewDistanceQuality", Classes.FEnumProperty);
		SetViewDistanceQuality_IsValid = SetViewDistanceQuality_FunctionAddress != IntPtr.Zero && SetViewDistanceQuality_InViewDistanceQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetViewDistanceQuality", SetViewDistanceQuality_IsValid);
		SetTextureQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextureQuality");
		SetTextureQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureQuality_InTextureQuality_PropertyAddress, SetTextureQuality_FunctionAddress, "InTextureQuality");
		SetTextureQuality_InTextureQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureQuality_FunctionAddress, "InTextureQuality");
		SetTextureQuality_InTextureQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureQuality_FunctionAddress, "InTextureQuality", Classes.FEnumProperty);
		SetTextureQuality_IsValid = SetTextureQuality_FunctionAddress != IntPtr.Zero && SetTextureQuality_InTextureQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTextureQuality", SetTextureQuality_IsValid);
		SetTargetScreenModeV2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTargetScreenModeV2");
		SetTargetScreenModeV2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetScreenModeV2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetScreenModeV2_TargetWindowMode_PropertyAddress, SetTargetScreenModeV2_FunctionAddress, "TargetWindowMode");
		SetTargetScreenModeV2_TargetWindowMode_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetScreenModeV2_FunctionAddress, "TargetWindowMode");
		SetTargetScreenModeV2_TargetWindowMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetScreenModeV2_FunctionAddress, "TargetWindowMode", Classes.FByteProperty);
		SetTargetScreenModeV2_IsValid = SetTargetScreenModeV2_FunctionAddress != IntPtr.Zero && SetTargetScreenModeV2_TargetWindowMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenModeV2", SetTargetScreenModeV2_IsValid);
		SetTargetScreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTargetScreenMode");
		SetTargetScreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetScreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetScreenMode_TargetScreenMode_PropertyAddress, SetTargetScreenMode_FunctionAddress, "TargetScreenMode");
		SetTargetScreenMode_TargetScreenMode_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetScreenMode_FunctionAddress, "TargetScreenMode");
		SetTargetScreenMode_TargetScreenMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetScreenMode_FunctionAddress, "TargetScreenMode", Classes.FEnumProperty);
		SetTargetScreenMode_IsValid = SetTargetScreenMode_FunctionAddress != IntPtr.Zero && SetTargetScreenMode_TargetScreenMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetScreenMode", SetTargetScreenMode_IsValid);
		SetTargetResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTargetResolution");
		SetTargetResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetResolution_TargetResolution_PropertyAddress, SetTargetResolution_FunctionAddress, "TargetResolution");
		SetTargetResolution_TargetResolution_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetResolution_FunctionAddress, "TargetResolution");
		SetTargetResolution_TargetResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetResolution_FunctionAddress, "TargetResolution", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetResolution_NeedFresh_PropertyAddress, SetTargetResolution_FunctionAddress, "NeedFresh");
		SetTargetResolution_NeedFresh_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetResolution_FunctionAddress, "NeedFresh");
		SetTargetResolution_NeedFresh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetResolution_FunctionAddress, "NeedFresh", Classes.FBoolProperty);
		SetTargetResolution_IsValid = SetTargetResolution_FunctionAddress != IntPtr.Zero && SetTargetResolution_TargetResolution_IsValid && SetTargetResolution_NeedFresh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetTargetResolution", SetTargetResolution_IsValid);
		SetShadowQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetShadowQuality");
		SetShadowQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowQuality_InShadowQuality_PropertyAddress, SetShadowQuality_FunctionAddress, "InShadowQuality");
		SetShadowQuality_InShadowQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowQuality_FunctionAddress, "InShadowQuality");
		SetShadowQuality_InShadowQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowQuality_FunctionAddress, "InShadowQuality", Classes.FEnumProperty);
		SetShadowQuality_IsValid = SetShadowQuality_FunctionAddress != IntPtr.Zero && SetShadowQuality_InShadowQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadowQuality", SetShadowQuality_IsValid);
		SetShadingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetShadingQuality");
		SetShadingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadingQuality_InShadingQuality_PropertyAddress, SetShadingQuality_FunctionAddress, "InShadingQuality");
		SetShadingQuality_InShadingQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetShadingQuality_FunctionAddress, "InShadingQuality");
		SetShadingQuality_InShadingQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadingQuality_FunctionAddress, "InShadingQuality", Classes.FEnumProperty);
		SetShadingQuality_IsValid = SetShadingQuality_FunctionAddress != IntPtr.Zero && SetShadingQuality_InShadingQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetShadingQuality", SetShadingQuality_IsValid);
		SetScreenPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScreenPos");
		SetScreenPos_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScreenPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScreenPos_Position_PropertyAddress, SetScreenPos_FunctionAddress, "Position");
		SetScreenPos_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetScreenPos_FunctionAddress, "Position");
		SetScreenPos_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScreenPos_FunctionAddress, "Position", Classes.FStructProperty);
		SetScreenPos_IsValid = SetScreenPos_FunctionAddress != IntPtr.Zero && SetScreenPos_Position_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScreenPos", SetScreenPos_IsValid);
		SetScalabilityQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalabilityQuality");
		SetScalabilityQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalabilityQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQuality_TargetGSQualityLevel_PropertyAddress, SetScalabilityQuality_FunctionAddress, "TargetGSQualityLevel");
		SetScalabilityQuality_TargetGSQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQuality_FunctionAddress, "TargetGSQualityLevel");
		SetScalabilityQuality_TargetGSQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQuality_FunctionAddress, "TargetGSQualityLevel", Classes.FEnumProperty);
		SetScalabilityQuality_IsValid = SetScalabilityQuality_FunctionAddress != IntPtr.Zero && SetScalabilityQuality_TargetGSQualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQuality", SetScalabilityQuality_IsValid);
		SetScalabilityQualities_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalabilityQualities");
		SetScalabilityQualities_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalabilityQualities_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalabilityQualities_Qualities_PropertyAddress, SetScalabilityQualities_FunctionAddress, "Qualities");
		SetScalabilityQualities_Qualities_Offset = NativeReflectionCached.GetPropertyOffset(SetScalabilityQualities_FunctionAddress, "Qualities");
		SetScalabilityQualities_Qualities_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalabilityQualities_FunctionAddress, "Qualities", Classes.FStructProperty);
		SetScalabilityQualities_IsValid = SetScalabilityQualities_FunctionAddress != IntPtr.Zero && SetScalabilityQualities_Qualities_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetScalabilityQualities", SetScalabilityQualities_IsValid);
		SetResolutionQualityScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetResolutionQualityScale");
		SetResolutionQualityScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetResolutionQualityScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetResolutionQualityScale_InResolutionQualityScale_PropertyAddress, SetResolutionQualityScale_FunctionAddress, "InResolutionQualityScale");
		SetResolutionQualityScale_InResolutionQualityScale_Offset = NativeReflectionCached.GetPropertyOffset(SetResolutionQualityScale_FunctionAddress, "InResolutionQualityScale");
		SetResolutionQualityScale_InResolutionQualityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetResolutionQualityScale_FunctionAddress, "InResolutionQualityScale", Classes.FFloatProperty);
		SetResolutionQualityScale_IsValid = SetResolutionQualityScale_FunctionAddress != IntPtr.Zero && SetResolutionQualityScale_InResolutionQualityScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityScale", SetResolutionQualityScale_IsValid);
		SetResolutionQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetResolutionQualityLevel");
		SetResolutionQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetResolutionQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetResolutionQualityLevel_InResolutionQualityLevel_PropertyAddress, SetResolutionQualityLevel_FunctionAddress, "InResolutionQualityLevel");
		SetResolutionQualityLevel_InResolutionQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetResolutionQualityLevel_FunctionAddress, "InResolutionQualityLevel");
		SetResolutionQualityLevel_InResolutionQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetResolutionQualityLevel_FunctionAddress, "InResolutionQualityLevel", Classes.FEnumProperty);
		SetResolutionQualityLevel_IsValid = SetResolutionQualityLevel_FunctionAddress != IntPtr.Zero && SetResolutionQualityLevel_InResolutionQualityLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetResolutionQualityLevel", SetResolutionQualityLevel_IsValid);
		SetReflectionQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetReflectionQuality");
		SetReflectionQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReflectionQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReflectionQuality_InReflectionQuality_PropertyAddress, SetReflectionQuality_FunctionAddress, "InReflectionQuality");
		SetReflectionQuality_InReflectionQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetReflectionQuality_FunctionAddress, "InReflectionQuality");
		SetReflectionQuality_InReflectionQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReflectionQuality_FunctionAddress, "InReflectionQuality", Classes.FEnumProperty);
		SetReflectionQuality_IsValid = SetReflectionQuality_FunctionAddress != IntPtr.Zero && SetReflectionQuality_InReflectionQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetReflectionQuality", SetReflectionQuality_IsValid);
		SetPriorityMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPriorityMode");
		SetPriorityMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPriorityMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPriorityMode_InPriorityMode_PropertyAddress, SetPriorityMode_FunctionAddress, "InPriorityMode");
		SetPriorityMode_InPriorityMode_Offset = NativeReflectionCached.GetPropertyOffset(SetPriorityMode_FunctionAddress, "InPriorityMode");
		SetPriorityMode_InPriorityMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPriorityMode_FunctionAddress, "InPriorityMode", Classes.FEnumProperty);
		SetPriorityMode_IsValid = SetPriorityMode_FunctionAddress != IntPtr.Zero && SetPriorityMode_InPriorityMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPriorityMode", SetPriorityMode_IsValid);
		SetPostProcessQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPostProcessQuality");
		SetPostProcessQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostProcessQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostProcessQuality_InPostProcessQuality_PropertyAddress, SetPostProcessQuality_FunctionAddress, "InPostProcessQuality");
		SetPostProcessQuality_InPostProcessQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetPostProcessQuality_FunctionAddress, "InPostProcessQuality");
		SetPostProcessQuality_InPostProcessQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostProcessQuality_FunctionAddress, "InPostProcessQuality", Classes.FEnumProperty);
		SetPostProcessQuality_IsValid = SetPostProcessQuality_FunctionAddress != IntPtr.Zero && SetPostProcessQuality_InPostProcessQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetPostProcessQuality", SetPostProcessQuality_IsValid);
		SetMonitorAsPrimaryV2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMonitorAsPrimaryV2");
		SetMonitorAsPrimaryV2_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMonitorAsPrimaryV2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMonitorAsPrimaryV2_InMonitorID_PropertyAddress, SetMonitorAsPrimaryV2_FunctionAddress, "InMonitorID");
		SetMonitorAsPrimaryV2_InMonitorID_Offset = NativeReflectionCached.GetPropertyOffset(SetMonitorAsPrimaryV2_FunctionAddress, "InMonitorID");
		SetMonitorAsPrimaryV2_InMonitorID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMonitorAsPrimaryV2_FunctionAddress, "InMonitorID", Classes.FStrProperty);
		SetMonitorAsPrimaryV2_IsValid = SetMonitorAsPrimaryV2_FunctionAddress != IntPtr.Zero && SetMonitorAsPrimaryV2_InMonitorID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimaryV2", SetMonitorAsPrimaryV2_IsValid);
		SetMonitorAsPrimary_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMonitorAsPrimary");
		SetMonitorAsPrimary_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMonitorAsPrimary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMonitorAsPrimary_MonitorID_PropertyAddress, SetMonitorAsPrimary_FunctionAddress, "MonitorID");
		SetMonitorAsPrimary_MonitorID_Offset = NativeReflectionCached.GetPropertyOffset(SetMonitorAsPrimary_FunctionAddress, "MonitorID");
		SetMonitorAsPrimary_MonitorID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMonitorAsPrimary_FunctionAddress, "MonitorID", Classes.FStrProperty);
		SetMonitorAsPrimary_IsValid = SetMonitorAsPrimary_FunctionAddress != IntPtr.Zero && SetMonitorAsPrimary_MonitorID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetMonitorAsPrimary", SetMonitorAsPrimary_IsValid);
		SetGlobalIlluminationQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGlobalIlluminationQuality");
		SetGlobalIlluminationQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalIlluminationQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalIlluminationQuality_InGIQuality_PropertyAddress, SetGlobalIlluminationQuality_FunctionAddress, "InGIQuality");
		SetGlobalIlluminationQuality_InGIQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalIlluminationQuality_FunctionAddress, "InGIQuality");
		SetGlobalIlluminationQuality_InGIQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalIlluminationQuality_FunctionAddress, "InGIQuality", Classes.FEnumProperty);
		SetGlobalIlluminationQuality_IsValid = SetGlobalIlluminationQuality_FunctionAddress != IntPtr.Zero && SetGlobalIlluminationQuality_InGIQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetGlobalIlluminationQuality", SetGlobalIlluminationQuality_IsValid);
		SetFrameRateLimit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFrameRateLimit");
		SetFrameRateLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRateLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRateLimit_InFrameRateLimit_PropertyAddress, SetFrameRateLimit_FunctionAddress, "InFrameRateLimit");
		SetFrameRateLimit_InFrameRateLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRateLimit_FunctionAddress, "InFrameRateLimit");
		SetFrameRateLimit_InFrameRateLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRateLimit_FunctionAddress, "InFrameRateLimit", Classes.FFloatProperty);
		SetFrameRateLimit_IsValid = SetFrameRateLimit_FunctionAddress != IntPtr.Zero && SetFrameRateLimit_InFrameRateLimit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFrameRateLimit", SetFrameRateLimit_IsValid);
		SetFoliageQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFoliageQuality");
		SetFoliageQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFoliageQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFoliageQuality_InFoliageQuality_PropertyAddress, SetFoliageQuality_FunctionAddress, "InFoliageQuality");
		SetFoliageQuality_InFoliageQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetFoliageQuality_FunctionAddress, "InFoliageQuality");
		SetFoliageQuality_InFoliageQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFoliageQuality_FunctionAddress, "InFoliageQuality", Classes.FEnumProperty);
		SetFoliageQuality_IsValid = SetFoliageQuality_FunctionAddress != IntPtr.Zero && SetFoliageQuality_InFoliageQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetFoliageQuality", SetFoliageQuality_IsValid);
		SetEffectsQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEffectsQuality");
		SetEffectsQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEffectsQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEffectsQuality_InEffectQuality_PropertyAddress, SetEffectsQuality_FunctionAddress, "InEffectQuality");
		SetEffectsQuality_InEffectQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetEffectsQuality_FunctionAddress, "InEffectQuality");
		SetEffectsQuality_InEffectQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEffectsQuality_FunctionAddress, "InEffectQuality", Classes.FEnumProperty);
		SetEffectsQuality_IsValid = SetEffectsQuality_FunctionAddress != IntPtr.Zero && SetEffectsQuality_InEffectQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetEffectsQuality", SetEffectsQuality_IsValid);
		SetAntiAliasingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAntiAliasingQuality");
		SetAntiAliasingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAntiAliasingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAntiAliasingQuality_InAntiAliasingQuality_PropertyAddress, SetAntiAliasingQuality_FunctionAddress, "InAntiAliasingQuality");
		SetAntiAliasingQuality_InAntiAliasingQuality_Offset = NativeReflectionCached.GetPropertyOffset(SetAntiAliasingQuality_FunctionAddress, "InAntiAliasingQuality");
		SetAntiAliasingQuality_InAntiAliasingQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAntiAliasingQuality_FunctionAddress, "InAntiAliasingQuality", Classes.FEnumProperty);
		SetAntiAliasingQuality_IsValid = SetAntiAliasingQuality_FunctionAddress != IntPtr.Zero && SetAntiAliasingQuality_InAntiAliasingQuality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:SetAntiAliasingQuality", SetAntiAliasingQuality_IsValid);
		RefreshBenchmarkMonitor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshBenchmarkMonitor");
		RefreshBenchmarkMonitor_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshBenchmarkMonitor_FunctionAddress);
		RefreshBenchmarkMonitor_IsValid = RefreshBenchmarkMonitor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:RefreshBenchmarkMonitor", RefreshBenchmarkMonitor_IsValid);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:Init", Init_IsValid);
		GMChangeMonitorAsPrimary_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GMChangeMonitorAsPrimary");
		GMChangeMonitorAsPrimary_ParamsSize = NativeReflection.GetFunctionParamsSize(GMChangeMonitorAsPrimary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GMChangeMonitorAsPrimary_MonitorIdx_PropertyAddress, GMChangeMonitorAsPrimary_FunctionAddress, "MonitorIdx");
		GMChangeMonitorAsPrimary_MonitorIdx_Offset = NativeReflectionCached.GetPropertyOffset(GMChangeMonitorAsPrimary_FunctionAddress, "MonitorIdx");
		GMChangeMonitorAsPrimary_MonitorIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(GMChangeMonitorAsPrimary_FunctionAddress, "MonitorIdx", Classes.FIntProperty);
		GMChangeMonitorAsPrimary_IsValid = GMChangeMonitorAsPrimary_FunctionAddress != IntPtr.Zero && GMChangeMonitorAsPrimary_MonitorIdx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GMChangeMonitorAsPrimary", GMChangeMonitorAsPrimary_IsValid);
		GetVSyncEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVSyncEnabled");
		GetVSyncEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVSyncEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVSyncEnabled_ReturnValue_PropertyAddress, GetVSyncEnabled_FunctionAddress, "ReturnValue");
		GetVSyncEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVSyncEnabled_FunctionAddress, "ReturnValue");
		GetVSyncEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVSyncEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetVSyncEnabled_IsValid = GetVSyncEnabled_FunctionAddress != IntPtr.Zero && GetVSyncEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetVSyncEnabled", GetVSyncEnabled_IsValid);
		GetUsedGraphicsMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUsedGraphicsMemory");
		GetUsedGraphicsMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUsedGraphicsMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUsedGraphicsMemory_InQueryType_PropertyAddress, GetUsedGraphicsMemory_FunctionAddress, "InQueryType");
		GetUsedGraphicsMemory_InQueryType_Offset = NativeReflectionCached.GetPropertyOffset(GetUsedGraphicsMemory_FunctionAddress, "InQueryType");
		GetUsedGraphicsMemory_InQueryType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUsedGraphicsMemory_FunctionAddress, "InQueryType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUsedGraphicsMemory_ReturnValue_PropertyAddress, GetUsedGraphicsMemory_FunctionAddress, "ReturnValue");
		GetUsedGraphicsMemory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUsedGraphicsMemory_FunctionAddress, "ReturnValue");
		GetUsedGraphicsMemory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUsedGraphicsMemory_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetUsedGraphicsMemory_IsValid = GetUsedGraphicsMemory_FunctionAddress != IntPtr.Zero && GetUsedGraphicsMemory_InQueryType_IsValid && GetUsedGraphicsMemory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetUsedGraphicsMemory", GetUsedGraphicsMemory_IsValid);
		GetScreenSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScreenSize");
		GetScreenSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScreenSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScreenSize_ReturnValue_PropertyAddress, GetScreenSize_FunctionAddress, "ReturnValue");
		GetScreenSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScreenSize_FunctionAddress, "ReturnValue");
		GetScreenSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScreenSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetScreenSize_IsValid = GetScreenSize_FunctionAddress != IntPtr.Zero && GetScreenSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetScreenSize", GetScreenSize_IsValid);
		GetResolutionScaleFromQualityLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetResolutionScaleFromQualityLevel");
		GetResolutionScaleFromQualityLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetResolutionScaleFromQualityLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleFromQualityLevel_InQualityLevel_PropertyAddress, GetResolutionScaleFromQualityLevel_FunctionAddress, "InQualityLevel");
		GetResolutionScaleFromQualityLevel_InQualityLevel_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleFromQualityLevel_FunctionAddress, "InQualityLevel");
		GetResolutionScaleFromQualityLevel_InQualityLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleFromQualityLevel_FunctionAddress, "InQualityLevel", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetResolutionScaleFromQualityLevel_ReturnValue_PropertyAddress, GetResolutionScaleFromQualityLevel_FunctionAddress, "ReturnValue");
		GetResolutionScaleFromQualityLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetResolutionScaleFromQualityLevel_FunctionAddress, "ReturnValue");
		GetResolutionScaleFromQualityLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetResolutionScaleFromQualityLevel_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetResolutionScaleFromQualityLevel_IsValid = GetResolutionScaleFromQualityLevel_FunctionAddress != IntPtr.Zero && GetResolutionScaleFromQualityLevel_InQualityLevel_IsValid && GetResolutionScaleFromQualityLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetResolutionScaleFromQualityLevel", GetResolutionScaleFromQualityLevel_IsValid);
		GetRecommendedScalabilityQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRecommendedScalabilityQuality");
		GetRecommendedScalabilityQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRecommendedScalabilityQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRecommendedScalabilityQuality_bLogInfo_PropertyAddress, GetRecommendedScalabilityQuality_FunctionAddress, "bLogInfo");
		GetRecommendedScalabilityQuality_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetRecommendedScalabilityQuality_FunctionAddress, "bLogInfo");
		GetRecommendedScalabilityQuality_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRecommendedScalabilityQuality_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRecommendedScalabilityQuality_ReturnValue_PropertyAddress, GetRecommendedScalabilityQuality_FunctionAddress, "ReturnValue");
		GetRecommendedScalabilityQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRecommendedScalabilityQuality_FunctionAddress, "ReturnValue");
		GetRecommendedScalabilityQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRecommendedScalabilityQuality_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRecommendedScalabilityQuality_IsValid = GetRecommendedScalabilityQuality_FunctionAddress != IntPtr.Zero && GetRecommendedScalabilityQuality_bLogInfo_IsValid && GetRecommendedScalabilityQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetRecommendedScalabilityQuality", GetRecommendedScalabilityQuality_IsValid);
		GetProportionalResolutions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProportionalResolutions");
		GetProportionalResolutions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProportionalResolutions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProportionalResolutions_AspectRatio_PropertyAddress, GetProportionalResolutions_FunctionAddress, "AspectRatio");
		GetProportionalResolutions_AspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(GetProportionalResolutions_FunctionAddress, "AspectRatio");
		GetProportionalResolutions_AspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProportionalResolutions_FunctionAddress, "AspectRatio", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProportionalResolutions_ReturnValue_PropertyAddress, GetProportionalResolutions_FunctionAddress, "ReturnValue");
		GetProportionalResolutions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProportionalResolutions_FunctionAddress, "ReturnValue");
		GetProportionalResolutions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProportionalResolutions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetProportionalResolutions_IsValid = GetProportionalResolutions_FunctionAddress != IntPtr.Zero && GetProportionalResolutions_AspectRatio_IsValid && GetProportionalResolutions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetProportionalResolutions", GetProportionalResolutions_IsValid);
		GetMaxRefreshRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMaxRefreshRate");
		GetMaxRefreshRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxRefreshRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxRefreshRate_ReturnValue_PropertyAddress, GetMaxRefreshRate_FunctionAddress, "ReturnValue");
		GetMaxRefreshRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxRefreshRate_FunctionAddress, "ReturnValue");
		GetMaxRefreshRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxRefreshRate_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaxRefreshRate_IsValid = GetMaxRefreshRate_FunctionAddress != IntPtr.Zero && GetMaxRefreshRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetMaxRefreshRate", GetMaxRefreshRate_IsValid);
		GetGSystemResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGSystemResolution");
		GetGSystemResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSystemResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSystemResolution_ReturnValue_PropertyAddress, GetGSystemResolution_FunctionAddress, "ReturnValue");
		GetGSystemResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSystemResolution_FunctionAddress, "ReturnValue");
		GetGSystemResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSystemResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGSystemResolution_IsValid = GetGSystemResolution_FunctionAddress != IntPtr.Zero && GetGSystemResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGSystemResolution", GetGSystemResolution_IsValid);
		GetGraphicsMemoryInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGraphicsMemoryInfo");
		GetGraphicsMemoryInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphicsMemoryInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphicsMemoryInfo_InGraphicsMemoryMode_PropertyAddress, GetGraphicsMemoryInfo_FunctionAddress, "InGraphicsMemoryMode");
		GetGraphicsMemoryInfo_InGraphicsMemoryMode_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphicsMemoryInfo_FunctionAddress, "InGraphicsMemoryMode");
		GetGraphicsMemoryInfo_InGraphicsMemoryMode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphicsMemoryInfo_FunctionAddress, "InGraphicsMemoryMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGraphicsMemoryInfo_ReturnValue_PropertyAddress, GetGraphicsMemoryInfo_FunctionAddress, "ReturnValue");
		GetGraphicsMemoryInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphicsMemoryInfo_FunctionAddress, "ReturnValue");
		GetGraphicsMemoryInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphicsMemoryInfo_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetGraphicsMemoryInfo_IsValid = GetGraphicsMemoryInfo_FunctionAddress != IntPtr.Zero && GetGraphicsMemoryInfo_InGraphicsMemoryMode_IsValid && GetGraphicsMemoryInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGraphicsMemoryInfo", GetGraphicsMemoryInfo_IsValid);
		GetGPUUsedTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGPUUsedTime");
		GetGPUUsedTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGPUUsedTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGPUUsedTime_ReturnValue_PropertyAddress, GetGPUUsedTime_FunctionAddress, "ReturnValue");
		GetGPUUsedTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGPUUsedTime_FunctionAddress, "ReturnValue");
		GetGPUUsedTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGPUUsedTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGPUUsedTime_IsValid = GetGPUUsedTime_FunctionAddress != IntPtr.Zero && GetGPUUsedTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedTime", GetGPUUsedTime_IsValid);
		GetGPUUsedPercentage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGPUUsedPercentage");
		GetGPUUsedPercentage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGPUUsedPercentage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGPUUsedPercentage_ReturnValue_PropertyAddress, GetGPUUsedPercentage_FunctionAddress, "ReturnValue");
		GetGPUUsedPercentage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGPUUsedPercentage_FunctionAddress, "ReturnValue");
		GetGPUUsedPercentage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGPUUsedPercentage_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetGPUUsedPercentage_IsValid = GetGPUUsedPercentage_FunctionAddress != IntPtr.Zero && GetGPUUsedPercentage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetGPUUsedPercentage", GetGPUUsedPercentage_IsValid);
		GetFrameRateLimit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFrameRateLimit");
		GetFrameRateLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameRateLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameRateLimit_ReturnValue_PropertyAddress, GetFrameRateLimit_FunctionAddress, "ReturnValue");
		GetFrameRateLimit_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameRateLimit_FunctionAddress, "ReturnValue");
		GetFrameRateLimit_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameRateLimit_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFrameRateLimit_IsValid = GetFrameRateLimit_FunctionAddress != IntPtr.Zero && GetFrameRateLimit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetFrameRateLimit", GetFrameRateLimit_IsValid);
		GetCurrentScreenModeV2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentScreenModeV2");
		GetCurrentScreenModeV2_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentScreenModeV2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScreenModeV2_ReturnValue_PropertyAddress, GetCurrentScreenModeV2_FunctionAddress, "ReturnValue");
		GetCurrentScreenModeV2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScreenModeV2_FunctionAddress, "ReturnValue");
		GetCurrentScreenModeV2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScreenModeV2_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCurrentScreenModeV2_IsValid = GetCurrentScreenModeV2_FunctionAddress != IntPtr.Zero && GetCurrentScreenModeV2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenModeV2", GetCurrentScreenModeV2_IsValid);
		GetCurrentScreenMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentScreenMode");
		GetCurrentScreenMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentScreenMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScreenMode_ReturnValue_PropertyAddress, GetCurrentScreenMode_FunctionAddress, "ReturnValue");
		GetCurrentScreenMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScreenMode_FunctionAddress, "ReturnValue");
		GetCurrentScreenMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScreenMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetCurrentScreenMode_IsValid = GetCurrentScreenMode_FunctionAddress != IntPtr.Zero && GetCurrentScreenMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScreenMode", GetCurrentScreenMode_IsValid);
		GetCurrentScalabilityQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentScalabilityQuality");
		GetCurrentScalabilityQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentScalabilityQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScalabilityQuality_bLogInfo_PropertyAddress, GetCurrentScalabilityQuality_FunctionAddress, "bLogInfo");
		GetCurrentScalabilityQuality_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScalabilityQuality_FunctionAddress, "bLogInfo");
		GetCurrentScalabilityQuality_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScalabilityQuality_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScalabilityQuality_ReturnValue_PropertyAddress, GetCurrentScalabilityQuality_FunctionAddress, "ReturnValue");
		GetCurrentScalabilityQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScalabilityQuality_FunctionAddress, "ReturnValue");
		GetCurrentScalabilityQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScalabilityQuality_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentScalabilityQuality_IsValid = GetCurrentScalabilityQuality_FunctionAddress != IntPtr.Zero && GetCurrentScalabilityQuality_bLogInfo_IsValid && GetCurrentScalabilityQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQuality", GetCurrentScalabilityQuality_IsValid);
		GetCurrentScalabilityQualities_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentScalabilityQualities");
		GetCurrentScalabilityQualities_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentScalabilityQualities_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScalabilityQualities_bLogInfo_PropertyAddress, GetCurrentScalabilityQualities_FunctionAddress, "bLogInfo");
		GetCurrentScalabilityQualities_bLogInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScalabilityQualities_FunctionAddress, "bLogInfo");
		GetCurrentScalabilityQualities_bLogInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScalabilityQualities_FunctionAddress, "bLogInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentScalabilityQualities_ReturnValue_PropertyAddress, GetCurrentScalabilityQualities_FunctionAddress, "ReturnValue");
		GetCurrentScalabilityQualities_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentScalabilityQualities_FunctionAddress, "ReturnValue");
		GetCurrentScalabilityQualities_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentScalabilityQualities_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentScalabilityQualities_IsValid = GetCurrentScalabilityQualities_FunctionAddress != IntPtr.Zero && GetCurrentScalabilityQualities_bLogInfo_IsValid && GetCurrentScalabilityQualities_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentScalabilityQualities", GetCurrentScalabilityQualities_IsValid);
		GetCurrentResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentResolution");
		GetCurrentResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentResolution_ReturnValue_PropertyAddress, GetCurrentResolution_FunctionAddress, "ReturnValue");
		GetCurrentResolution_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentResolution_FunctionAddress, "ReturnValue");
		GetCurrentResolution_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentResolution_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentResolution_IsValid = GetCurrentResolution_FunctionAddress != IntPtr.Zero && GetCurrentResolution_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentResolution", GetCurrentResolution_IsValid);
		GetCurrentFPS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentFPS");
		GetCurrentFPS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFPS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFPS_ReturnValue_PropertyAddress, GetCurrentFPS_FunctionAddress, "ReturnValue");
		GetCurrentFPS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFPS_FunctionAddress, "ReturnValue");
		GetCurrentFPS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFPS_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentFPS_IsValid = GetCurrentFPS_FunctionAddress != IntPtr.Zero && GetCurrentFPS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCurrentFPS", GetCurrentFPS_IsValid);
		GetCPUUsedTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCPUUsedTime");
		GetCPUUsedTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPUUsedTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPUUsedTime_ReturnValue_PropertyAddress, GetCPUUsedTime_FunctionAddress, "ReturnValue");
		GetCPUUsedTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPUUsedTime_FunctionAddress, "ReturnValue");
		GetCPUUsedTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPUUsedTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCPUUsedTime_IsValid = GetCPUUsedTime_FunctionAddress != IntPtr.Zero && GetCPUUsedTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedTime", GetCPUUsedTime_IsValid);
		GetCPUUsedPercentage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCPUUsedPercentage");
		GetCPUUsedPercentage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCPUUsedPercentage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCPUUsedPercentage_ReturnValue_PropertyAddress, GetCPUUsedPercentage_FunctionAddress, "ReturnValue");
		GetCPUUsedPercentage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCPUUsedPercentage_FunctionAddress, "ReturnValue");
		GetCPUUsedPercentage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCPUUsedPercentage_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCPUUsedPercentage_IsValid = GetCPUUsedPercentage_FunctionAddress != IntPtr.Zero && GetCPUUsedPercentage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetCPUUsedPercentage", GetCPUUsedPercentage_IsValid);
		GetAvailableResolutionsByMonitorID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableResolutionsByMonitorID");
		GetAvailableResolutionsByMonitorID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableResolutionsByMonitorID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableResolutionsByMonitorID_InMonitorID_PropertyAddress, GetAvailableResolutionsByMonitorID_FunctionAddress, "InMonitorID");
		GetAvailableResolutionsByMonitorID_InMonitorID_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableResolutionsByMonitorID_FunctionAddress, "InMonitorID");
		GetAvailableResolutionsByMonitorID_InMonitorID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableResolutionsByMonitorID_FunctionAddress, "InMonitorID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableResolutionsByMonitorID_ReturnValue_PropertyAddress, GetAvailableResolutionsByMonitorID_FunctionAddress, "ReturnValue");
		GetAvailableResolutionsByMonitorID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableResolutionsByMonitorID_FunctionAddress, "ReturnValue");
		GetAvailableResolutionsByMonitorID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableResolutionsByMonitorID_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAvailableResolutionsByMonitorID_IsValid = GetAvailableResolutionsByMonitorID_FunctionAddress != IntPtr.Zero && GetAvailableResolutionsByMonitorID_InMonitorID_IsValid && GetAvailableResolutionsByMonitorID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutionsByMonitorID", GetAvailableResolutionsByMonitorID_IsValid);
		GetAvailableResolutions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableResolutions");
		GetAvailableResolutions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableResolutions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableResolutions_ReturnValue_PropertyAddress, GetAvailableResolutions_FunctionAddress, "ReturnValue");
		GetAvailableResolutions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableResolutions_FunctionAddress, "ReturnValue");
		GetAvailableResolutions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableResolutions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAvailableResolutions_IsValid = GetAvailableResolutions_FunctionAddress != IntPtr.Zero && GetAvailableResolutions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableResolutions", GetAvailableResolutions_IsValid);
		GetAvailableGraphicsMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableGraphicsMemory");
		GetAvailableGraphicsMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableGraphicsMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableGraphicsMemory_InQueryType_PropertyAddress, GetAvailableGraphicsMemory_FunctionAddress, "InQueryType");
		GetAvailableGraphicsMemory_InQueryType_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableGraphicsMemory_FunctionAddress, "InQueryType");
		GetAvailableGraphicsMemory_InQueryType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableGraphicsMemory_FunctionAddress, "InQueryType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableGraphicsMemory_ReturnValue_PropertyAddress, GetAvailableGraphicsMemory_FunctionAddress, "ReturnValue");
		GetAvailableGraphicsMemory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableGraphicsMemory_FunctionAddress, "ReturnValue");
		GetAvailableGraphicsMemory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableGraphicsMemory_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAvailableGraphicsMemory_IsValid = GetAvailableGraphicsMemory_FunctionAddress != IntPtr.Zero && GetAvailableGraphicsMemory_InQueryType_IsValid && GetAvailableGraphicsMemory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAvailableGraphicsMemory", GetAvailableGraphicsMemory_IsValid);
		GetAllMonitorInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllMonitorInfo");
		GetAllMonitorInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllMonitorInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllMonitorInfo_ReturnValue_PropertyAddress, GetAllMonitorInfo_FunctionAddress, "ReturnValue");
		GetAllMonitorInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllMonitorInfo_FunctionAddress, "ReturnValue");
		GetAllMonitorInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllMonitorInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllMonitorInfo_IsValid = GetAllMonitorInfo_FunctionAddress != IntPtr.Zero && GetAllMonitorInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:GetAllMonitorInfo", GetAllMonitorInfo_IsValid);
		EngineSettingGetString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EngineSettingGetString");
		EngineSettingGetString_ParamsSize = NativeReflection.GetFunctionParamsSize(EngineSettingGetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EngineSettingGetString_Section_PropertyAddress, EngineSettingGetString_FunctionAddress, "Section");
		EngineSettingGetString_Section_Offset = NativeReflectionCached.GetPropertyOffset(EngineSettingGetString_FunctionAddress, "Section");
		EngineSettingGetString_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineSettingGetString_FunctionAddress, "Section", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EngineSettingGetString_Key_PropertyAddress, EngineSettingGetString_FunctionAddress, "Key");
		EngineSettingGetString_Key_Offset = NativeReflectionCached.GetPropertyOffset(EngineSettingGetString_FunctionAddress, "Key");
		EngineSettingGetString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineSettingGetString_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EngineSettingGetString_ReturnValue_PropertyAddress, EngineSettingGetString_FunctionAddress, "ReturnValue");
		EngineSettingGetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EngineSettingGetString_FunctionAddress, "ReturnValue");
		EngineSettingGetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EngineSettingGetString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		EngineSettingGetString_IsValid = EngineSettingGetString_FunctionAddress != IntPtr.Zero && EngineSettingGetString_Section_IsValid && EngineSettingGetString_Key_IsValid && EngineSettingGetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:EngineSettingGetString", EngineSettingGetString_IsValid);
		BGUUnBindOnViewportResizedEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnViewportResizedEvent");
		BGUUnBindOnViewportResizedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnViewportResizedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnViewportResizedEvent_Obj_PropertyAddress, BGUUnBindOnViewportResizedEvent_FunctionAddress, "Obj");
		BGUUnBindOnViewportResizedEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnViewportResizedEvent_FunctionAddress, "Obj");
		BGUUnBindOnViewportResizedEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnViewportResizedEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnViewportResizedEvent_FuncName_PropertyAddress, BGUUnBindOnViewportResizedEvent_FunctionAddress, "FuncName");
		BGUUnBindOnViewportResizedEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnViewportResizedEvent_FunctionAddress, "FuncName");
		BGUUnBindOnViewportResizedEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnViewportResizedEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnViewportResizedEvent_IsValid = BGUUnBindOnViewportResizedEvent_FunctionAddress != IntPtr.Zero && BGUUnBindOnViewportResizedEvent_Obj_IsValid && BGUUnBindOnViewportResizedEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnViewportResizedEvent", BGUUnBindOnViewportResizedEvent_IsValid);
		BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnMonitorAsPrimaryChange");
		BGUUnBindOnMonitorAsPrimaryChange_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnMonitorAsPrimaryChange_Obj_PropertyAddress, BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj");
		BGUUnBindOnMonitorAsPrimaryChange_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj");
		BGUUnBindOnMonitorAsPrimaryChange_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress, BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName");
		BGUUnBindOnMonitorAsPrimaryChange_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName");
		BGUUnBindOnMonitorAsPrimaryChange_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnMonitorAsPrimaryChange_IsValid = BGUUnBindOnMonitorAsPrimaryChange_FunctionAddress != IntPtr.Zero && BGUUnBindOnMonitorAsPrimaryChange_Obj_IsValid && BGUUnBindOnMonitorAsPrimaryChange_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnMonitorAsPrimaryChange", BGUUnBindOnMonitorAsPrimaryChange_IsValid);
		BGUUnBindOnCultureChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnBindOnCultureChangedEvent");
		BGUUnBindOnCultureChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnBindOnCultureChangedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnCultureChangedEvent_Obj_PropertyAddress, BGUUnBindOnCultureChangedEvent_FunctionAddress, "Obj");
		BGUUnBindOnCultureChangedEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnCultureChangedEvent_FunctionAddress, "Obj");
		BGUUnBindOnCultureChangedEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnCultureChangedEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnBindOnCultureChangedEvent_FuncName_PropertyAddress, BGUUnBindOnCultureChangedEvent_FunctionAddress, "FuncName");
		BGUUnBindOnCultureChangedEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnBindOnCultureChangedEvent_FunctionAddress, "FuncName");
		BGUUnBindOnCultureChangedEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnBindOnCultureChangedEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUUnBindOnCultureChangedEvent_IsValid = BGUUnBindOnCultureChangedEvent_FunctionAddress != IntPtr.Zero && BGUUnBindOnCultureChangedEvent_Obj_IsValid && BGUUnBindOnCultureChangedEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUUnBindOnCultureChangedEvent", BGUUnBindOnCultureChangedEvent_IsValid);
		BGUBindOnViewportResizedEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnViewportResizedEvent");
		BGUBindOnViewportResizedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnViewportResizedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnViewportResizedEvent_Obj_PropertyAddress, BGUBindOnViewportResizedEvent_FunctionAddress, "Obj");
		BGUBindOnViewportResizedEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnViewportResizedEvent_FunctionAddress, "Obj");
		BGUBindOnViewportResizedEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnViewportResizedEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnViewportResizedEvent_FuncName_PropertyAddress, BGUBindOnViewportResizedEvent_FunctionAddress, "FuncName");
		BGUBindOnViewportResizedEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnViewportResizedEvent_FunctionAddress, "FuncName");
		BGUBindOnViewportResizedEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnViewportResizedEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnViewportResizedEvent_IsValid = BGUBindOnViewportResizedEvent_FunctionAddress != IntPtr.Zero && BGUBindOnViewportResizedEvent_Obj_IsValid && BGUBindOnViewportResizedEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnViewportResizedEvent", BGUBindOnViewportResizedEvent_IsValid);
		BGUBindOnMonitorAsPrimaryChange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnMonitorAsPrimaryChange");
		BGUBindOnMonitorAsPrimaryChange_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnMonitorAsPrimaryChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnMonitorAsPrimaryChange_Obj_PropertyAddress, BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj");
		BGUBindOnMonitorAsPrimaryChange_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj");
		BGUBindOnMonitorAsPrimaryChange_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnMonitorAsPrimaryChange_FuncName_PropertyAddress, BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName");
		BGUBindOnMonitorAsPrimaryChange_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName");
		BGUBindOnMonitorAsPrimaryChange_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnMonitorAsPrimaryChange_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnMonitorAsPrimaryChange_IsValid = BGUBindOnMonitorAsPrimaryChange_FunctionAddress != IntPtr.Zero && BGUBindOnMonitorAsPrimaryChange_Obj_IsValid && BGUBindOnMonitorAsPrimaryChange_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnMonitorAsPrimaryChange", BGUBindOnMonitorAsPrimaryChange_IsValid);
		BGUBindOnCultureChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBindOnCultureChangedEvent");
		BGUBindOnCultureChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBindOnCultureChangedEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnCultureChangedEvent_Obj_PropertyAddress, BGUBindOnCultureChangedEvent_FunctionAddress, "Obj");
		BGUBindOnCultureChangedEvent_Obj_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnCultureChangedEvent_FunctionAddress, "Obj");
		BGUBindOnCultureChangedEvent_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnCultureChangedEvent_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBindOnCultureChangedEvent_FuncName_PropertyAddress, BGUBindOnCultureChangedEvent_FunctionAddress, "FuncName");
		BGUBindOnCultureChangedEvent_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBindOnCultureChangedEvent_FunctionAddress, "FuncName");
		BGUBindOnCultureChangedEvent_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBindOnCultureChangedEvent_FunctionAddress, "FuncName", Classes.FNameProperty);
		BGUBindOnCultureChangedEvent_IsValid = BGUBindOnCultureChangedEvent_FunctionAddress != IntPtr.Zero && BGUBindOnCultureChangedEvent_Obj_IsValid && BGUBindOnCultureChangedEvent_FuncName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:BGUBindOnCultureChangedEvent", BGUBindOnCultureChangedEvent_IsValid);
		ApplySystemSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplySystemSettings");
		ApplySystemSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplySystemSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplySystemSettings_bSaveSettings_PropertyAddress, ApplySystemSettings_FunctionAddress, "bSaveSettings");
		ApplySystemSettings_bSaveSettings_Offset = NativeReflectionCached.GetPropertyOffset(ApplySystemSettings_FunctionAddress, "bSaveSettings");
		ApplySystemSettings_bSaveSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplySystemSettings_FunctionAddress, "bSaveSettings", Classes.FBoolProperty);
		ApplySystemSettings_IsValid = ApplySystemSettings_FunctionAddress != IntPtr.Zero && ApplySystemSettings_bSaveSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SystemSettingsFuncLib:ApplySystemSettings", ApplySystemSettings_IsValid);
	}
}
