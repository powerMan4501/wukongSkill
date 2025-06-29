using System;
using UnrealEngine.DeveloperSettings;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Config = "GSGameCoustomConfig", Flags = (ClassFlags)542113952uL, InvalidTarget = false)]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSGameCoustomConfig")]
public class GSGameCoustomConfig : UDeveloperSettings
{
	private const PropFlags GSPropFlag = (PropFlags)6755399441072641uL;

	private static bool ArchiveRefactor_IsValid;

	private static int ArchiveRefactor_Offset;

	private static FFieldAddress ArchiveRefactor_PropertyAddress;

	private static bool DebugWidget_IsValid;

	private static int DebugWidget_Offset;

	private static FFieldAddress DebugWidget_PropertyAddress;

	private static bool ILRuntime_IsValid;

	private static int ILRuntime_Offset;

	private static FFieldAddress ILRuntime_PropertyAddress;

	private static bool ILRuntimeJITOnDemand_IsValid;

	private static int ILRuntimeJITOnDemand_Offset;

	private static FFieldAddress ILRuntimeJITOnDemand_PropertyAddress;

	private static bool Clrbinding_IsValid;

	private static int Clrbinding_Offset;

	private static FFieldAddress Clrbinding_PropertyAddress;

	private static bool ILRuntimeDebugger_IsValid;

	private static int ILRuntimeDebugger_Offset;

	private static FFieldAddress ILRuntimeDebugger_PropertyAddress;

	private static bool EnableRtx_IsValid;

	private static int EnableRtx_Offset;

	private static FFieldAddress EnableRtx_PropertyAddress;

	private static bool Report820Windows_IsValid;

	private static int Report820Windows_Offset;

	private static FFieldAddress Report820Windows_PropertyAddress;

	private static bool ManualBuiGC_IsValid;

	private static int ManualBuiGC_Offset;

	private static FFieldAddress ManualBuiGC_PropertyAddress;

	private static bool Report820PS5_IsValid;

	private static int Report820PS5_Offset;

	private static FFieldAddress Report820PS5_PropertyAddress;

	private static bool Report820XSX_IsValid;

	private static int Report820XSX_Offset;

	private static FFieldAddress Report820XSX_PropertyAddress;

	private static bool Report820WindowsRealtime_IsValid;

	private static int Report820WindowsRealtime_Offset;

	private static FFieldAddress Report820WindowsRealtime_PropertyAddress;

	private static bool ArchiveBackup_IsValid;

	private static int ArchiveBackup_Offset;

	private static FFieldAddress ArchiveBackup_PropertyAddress;

	private static bool OverridePlayerLogMaxSize_IsValid;

	private static int OverridePlayerLogMaxSize_Offset;

	private static FFieldAddress OverridePlayerLogMaxSize_PropertyAddress;

	private static bool DebugCFSMG_IsValid;

	private static int DebugCFSMG_Offset;

	private static FFieldAddress DebugCFSMG_PropertyAddress;

	private static bool SimTimeMarkBase_IsValid;

	private static int SimTimeMarkBase_Offset;

	private static FFieldAddress SimTimeMarkBase_PropertyAddress;

	private static bool SimTimeMarkStep_IsValid;

	private static int SimTimeMarkStep_Offset;

	private static FFieldAddress SimTimeMarkStep_PropertyAddress;

	private static bool Navigation_IsValid;

	private static int Navigation_Offset;

	private static FFieldAddress Navigation_PropertyAddress;

	private static bool Intimidation_IsValid;

	private static int Intimidation_Offset;

	private static FFieldAddress Intimidation_PropertyAddress;

	private static bool OpenSeparateFrameEntityBeginPlay_IsValid;

	private static int OpenSeparateFrameEntityBeginPlay_Offset;

	private static FFieldAddress OpenSeparateFrameEntityBeginPlay_PropertyAddress;

	private static bool InteractiveObj_IsValid;

	private static int InteractiveObj_Offset;

	private static FFieldAddress InteractiveObj_PropertyAddress;

	private static bool DrawSimpleOverlapDebug_IsValid;

	private static int DrawSimpleOverlapDebug_Offset;

	private static FFieldAddress DrawSimpleOverlapDebug_PropertyAddress;

	private static bool ProfilerSimpleOverlap_IsValid;

	private static int ProfilerSimpleOverlap_Offset;

	private static FFieldAddress ProfilerSimpleOverlap_PropertyAddress;

	private static bool TopdownBattleMode_IsValid;

	private static int TopdownBattleMode_Offset;

	private static FFieldAddress TopdownBattleMode_PropertyAddress;

	private static bool IsTmpTestFlag_IsValid;

	private static int IsTmpTestFlag_Offset;

	private static FFieldAddress IsTmpTestFlag_PropertyAddress;

	private static bool OpenNewChapterPlayerSafeLocation_IsValid;

	private static int OpenNewChapterPlayerSafeLocation_Offset;

	private static FFieldAddress OpenNewChapterPlayerSafeLocation_PropertyAddress;

	private static bool IsLiteBuild_IsValid;

	private static int IsLiteBuild_Offset;

	private static FFieldAddress IsLiteBuild_PropertyAddress;

	private static bool OpenGSRepLog_IsValid;

	private static int OpenGSRepLog_Offset;

	private static FFieldAddress OpenGSRepLog_PropertyAddress;

	private static bool ClientReset_IsValid;

	private static int ClientReset_Offset;

	private static FFieldAddress ClientReset_PropertyAddress;

	private static bool ProfileEnable_IsValid;

	private static int ProfileEnable_Offset;

	private static FFieldAddress ProfileEnable_PropertyAddress;

	private static bool Enablepreload_IsValid;

	private static int Enablepreload_Offset;

	private static FFieldAddress Enablepreload_PropertyAddress;

	private static bool CantCloseNetConnectWithError_IsValid;

	private static int CantCloseNetConnectWithError_Offset;

	private static FFieldAddress CantCloseNetConnectWithError_PropertyAddress;

	private static bool SkipRoleDataCheck_IsValid;

	private static int SkipRoleDataCheck_Offset;

	private static FFieldAddress SkipRoleDataCheck_PropertyAddress;

	private static bool EnableMoveSpeedInfoDebug_IsValid;

	private static int EnableMoveSpeedInfoDebug_Offset;

	private static FFieldAddress EnableMoveSpeedInfoDebug_PropertyAddress;

	private static bool EnablePrintJXSQCheckerResult_IsValid;

	private static int EnablePrintJXSQCheckerResult_Offset;

	private static FFieldAddress EnablePrintJXSQCheckerResult_PropertyAddress;

	private static bool EnableChapterRoamV2_IsValid;

	private static int EnableChapterRoamV2_Offset;

	private static FFieldAddress EnableChapterRoamV2_PropertyAddress;

	private static bool ChapterDebug_IsValid;

	private static int ChapterDebug_Offset;

	private static FFieldAddress ChapterDebug_PropertyAddress;

	private static bool EnableShrineAllFunc_IsValid;

	private static int EnableShrineAllFunc_Offset;

	private static FFieldAddress EnableShrineAllFunc_PropertyAddress;

	private static bool EnableInteractAllFunc_IsValid;

	private static int EnableInteractAllFunc_Offset;

	private static FFieldAddress EnableInteractAllFunc_PropertyAddress;

	private static bool DisableSkipInteractFunc_IsValid;

	private static int DisableSkipInteractFunc_Offset;

	private static FFieldAddress DisableSkipInteractFunc_PropertyAddress;

	private static bool DisableSkipMontageInteractFunc_IsValid;

	private static int DisableSkipMontageInteractFunc_Offset;

	private static FFieldAddress DisableSkipMontageInteractFunc_PropertyAddress;

	private static bool SpawnWaveDebug_IsValid;

	private static int SpawnWaveDebug_Offset;

	private static FFieldAddress SpawnWaveDebug_PropertyAddress;

	private static bool BPNeutralAnimalDebug_IsValid;

	private static int BPNeutralAnimalDebug_Offset;

	private static FFieldAddress BPNeutralAnimalDebug_PropertyAddress;

	private static bool PureVersion_IsValid;

	private static int PureVersion_Offset;

	private static FFieldAddress PureVersion_PropertyAddress;

	private static bool PreOrderAwardDebug_IsValid;

	private static int PreOrderAwardDebug_Offset;

	private static FFieldAddress PreOrderAwardDebug_PropertyAddress;

	private static bool DeluxeAwardDebug_IsValid;

	private static int DeluxeAwardDebug_Offset;

	private static FFieldAddress DeluxeAwardDebug_PropertyAddress;

	private static bool DisableRpcLog_IsValid;

	private static int DisableRpcLog_Offset;

	private static FFieldAddress DisableRpcLog_PropertyAddress;

	private static bool ActiveAllUI_IsValid;

	private static int ActiveAllUI_Offset;

	private static FFieldAddress ActiveAllUI_PropertyAddress;

	private static bool Open1080Check_IsValid;

	private static int Open1080Check_Offset;

	private static FFieldAddress Open1080Check_PropertyAddress;

	private static bool GSDisableLoadingScreen_IsValid;

	private static int GSDisableLoadingScreen_Offset;

	private static FFieldAddress GSDisableLoadingScreen_PropertyAddress;

	private static bool OnlyOpenPVUI_IsValid;

	private static int OnlyOpenPVUI_Offset;

	private static FFieldAddress OnlyOpenPVUI_PropertyAddress;

	private static bool AdvanceDropManualClose_IsValid;

	private static int AdvanceDropManualClose_Offset;

	private static FFieldAddress AdvanceDropManualClose_PropertyAddress;

	private static bool InputDebugInfo_IsValid;

	private static int InputDebugInfo_Offset;

	private static FFieldAddress InputDebugInfo_PropertyAddress;

	private static bool InputDebug_Window_IsValid;

	private static int InputDebug_Window_Offset;

	private static FFieldAddress InputDebug_Window_PropertyAddress;

	private static bool InputDebug_KeyCache_IsValid;

	private static int InputDebug_KeyCache_Offset;

	private static FFieldAddress InputDebug_KeyCache_PropertyAddress;

	private static bool GroupAI_IsValid;

	private static int GroupAI_Offset;

	private static FFieldAddress GroupAI_PropertyAddress;

	private static bool AIInfo_IsValid;

	private static int AIInfo_Offset;

	private static FFieldAddress AIInfo_PropertyAddress;

	private static bool TeamInfo_IsValid;

	private static int TeamInfo_Offset;

	private static FFieldAddress TeamInfo_PropertyAddress;

	private static bool FollowPartnerDispInfo_IsValid;

	private static int FollowPartnerDispInfo_Offset;

	private static FFieldAddress FollowPartnerDispInfo_PropertyAddress;

	private static bool TargetInfo_IsValid;

	private static int TargetInfo_Offset;

	private static FFieldAddress TargetInfo_PropertyAddress;

	private static bool HatredInfo_IsValid;

	private static int HatredInfo_Offset;

	private static FFieldAddress HatredInfo_PropertyAddress;

	private static bool AINodeDebug_IsValid;

	private static int AINodeDebug_Offset;

	private static FFieldAddress AINodeDebug_PropertyAddress;

	private static bool ABPHelperInfo_IsValid;

	private static int ABPHelperInfo_Offset;

	private static FFieldAddress ABPHelperInfo_PropertyAddress;

	private static bool OnlineAttr_IsValid;

	private static int OnlineAttr_Offset;

	private static FFieldAddress OnlineAttr_PropertyAddress;

	private static bool OnlineUnitState_IsValid;

	private static int OnlineUnitState_Offset;

	private static FFieldAddress OnlineUnitState_PropertyAddress;

	private static bool IsDebugDS_IsValid;

	private static int IsDebugDS_Offset;

	private static FFieldAddress IsDebugDS_PropertyAddress;

	private static bool ConnectionInfo_IsValid;

	private static int ConnectionInfo_Offset;

	private static FFieldAddress ConnectionInfo_PropertyAddress;

	private static bool PlayerDebugDraw_IsValid;

	private static int PlayerDebugDraw_Offset;

	private static FFieldAddress PlayerDebugDraw_PropertyAddress;

	private static bool OpenNetConnectDebugUI_IsValid;

	private static int OpenNetConnectDebugUI_Offset;

	private static FFieldAddress OpenNetConnectDebugUI_PropertyAddress;

	private static bool DebugGSRepRole_IsValid;

	private static int DebugGSRepRole_Offset;

	private static FFieldAddress DebugGSRepRole_PropertyAddress;

	private static bool OpenEventDebugger_IsValid;

	private static int OpenEventDebugger_Offset;

	private static FFieldAddress OpenEventDebugger_PropertyAddress;

	private static bool IsDebugAKB_IsValid;

	private static int IsDebugAKB_Offset;

	private static FFieldAddress IsDebugAKB_PropertyAddress;

	private static bool IsDebugUISys_IsValid;

	private static int IsDebugUISys_Offset;

	private static FFieldAddress IsDebugUISys_PropertyAddress;

	private static bool IsDebugUIMore_IsValid;

	private static int IsDebugUIMore_Offset;

	private static FFieldAddress IsDebugUIMore_PropertyAddress;

	private static bool IsDebugUIProc_IsValid;

	private static int IsDebugUIProc_Offset;

	private static FFieldAddress IsDebugUIProc_PropertyAddress;

	private static bool IsDebugWidgetMore_IsValid;

	private static int IsDebugWidgetMore_Offset;

	private static FFieldAddress IsDebugWidgetMore_PropertyAddress;

	private static bool IsDebugButton_IsValid;

	private static int IsDebugButton_Offset;

	private static FFieldAddress IsDebugButton_PropertyAddress;

	private static bool IsDebugAutoSizeScrollBox_IsValid;

	private static int IsDebugAutoSizeScrollBox_Offset;

	private static FFieldAddress IsDebugAutoSizeScrollBox_PropertyAddress;

	private static bool IsDebugWidgetProfile_IsValid;

	private static int IsDebugWidgetProfile_Offset;

	private static FFieldAddress IsDebugWidgetProfile_PropertyAddress;

	private static bool IsDebugUITick_IsValid;

	private static int IsDebugUITick_Offset;

	private static FFieldAddress IsDebugUITick_PropertyAddress;

	private static bool IsOpenStatGSCustom_IsValid;

	private static int IsOpenStatGSCustom_Offset;

	private static FFieldAddress IsOpenStatGSCustom_PropertyAddress;

	private static bool IsShowDebugDrawUI_IsValid;

	private static int IsShowDebugDrawUI_Offset;

	private static FFieldAddress IsShowDebugDrawUI_PropertyAddress;

	private static bool DebugPhaseCSG_IsValid;

	private static int DebugPhaseCSG_Offset;

	private static FFieldAddress DebugPhaseCSG_PropertyAddress;

	private static bool IsOpenBattleInfoTool_IsValid;

	private static int IsOpenBattleInfoTool_Offset;

	private static FFieldAddress IsOpenBattleInfoTool_PropertyAddress;

	private static bool CancelSkillCD_IsValid;

	private static int CancelSkillCD_Offset;

	private static FFieldAddress CancelSkillCD_PropertyAddress;

	private static bool DebugMap_IsValid;

	private static int DebugMap_Offset;

	private static FFieldAddress DebugMap_PropertyAddress;

	private static bool ShowChrEnvMaskValue_IsValid;

	private static int ShowChrEnvMaskValue_Offset;

	private static FFieldAddress ShowChrEnvMaskValue_PropertyAddress;

	private static bool IsOpenRemoteTestCheat_IsValid;

	private static int IsOpenRemoteTestCheat_Offset;

	private static FFieldAddress IsOpenRemoteTestCheat_PropertyAddress;

	private static bool IsIgnoreValidateData_IsValid;

	private static int IsIgnoreValidateData_Offset;

	private static FFieldAddress IsIgnoreValidateData_PropertyAddress;

	private static bool EventMemoryLeakTest_IsValid;

	private static int EventMemoryLeakTest_Offset;

	private static FFieldAddress EventMemoryLeakTest_PropertyAddress;

	private static bool TickEventMemoryLeakTest_IsValid;

	private static int TickEventMemoryLeakTest_Offset;

	private static FFieldAddress TickEventMemoryLeakTest_PropertyAddress;

	private static bool ObjMemoryLeakTest_IsValid;

	private static int ObjMemoryLeakTest_Offset;

	private static FFieldAddress ObjMemoryLeakTest_PropertyAddress;

	private static bool MemoryLeakTestCacheObj_IsValid;

	private static int MemoryLeakTestCacheObj_Offset;

	private static FFieldAddress MemoryLeakTestCacheObj_PropertyAddress;

	private static bool DebugStartWithOutArchive_IsValid;

	private static int DebugStartWithOutArchive_Offset;

	private static FFieldAddress DebugStartWithOutArchive_PropertyAddress;

	private static bool EnableSelectChapter_IsValid;

	private static int EnableSelectChapter_Offset;

	private static FFieldAddress EnableSelectChapter_PropertyAddress;

	private static bool CanOptimizeTick_IsValid;

	private static int CanOptimizeTick_Offset;

	private static FFieldAddress CanOptimizeTick_PropertyAddress;

	private static bool Debug820Demo_IsValid;

	private static int Debug820Demo_Offset;

	private static FFieldAddress Debug820Demo_PropertyAddress;

	private static bool Demo820OverSeaVersion_IsValid;

	private static int Demo820OverSeaVersion_Offset;

	private static FFieldAddress Demo820OverSeaVersion_PropertyAddress;

	private static bool Demo820DebugTest_IsValid;

	private static int Demo820DebugTest_Offset;

	private static FFieldAddress Demo820DebugTest_PropertyAddress;

	private static bool Demo820UseSetting_IsValid;

	private static int Demo820UseSetting_Offset;

	private static FFieldAddress Demo820UseSetting_PropertyAddress;

	private static bool DebugFristStartGameSetting_IsValid;

	private static int DebugFristStartGameSetting_Offset;

	private static FFieldAddress DebugFristStartGameSetting_PropertyAddress;

	private static bool OpenSeamlessLevelTravel_IsValid;

	private static int OpenSeamlessLevelTravel_Offset;

	private static FFieldAddress OpenSeamlessLevelTravel_PropertyAddress;

	private static bool Demo820ExceptionUI_IsValid;

	private static int Demo820ExceptionUI_Offset;

	private static FFieldAddress Demo820ExceptionUI_PropertyAddress;

	private static bool Demo820IgnoreAllOverlap_IsValid;

	private static int Demo820IgnoreAllOverlap_Offset;

	private static FFieldAddress Demo820IgnoreAllOverlap_PropertyAddress;

	private static bool DebugPlayerTransLog_IsValid;

	private static int DebugPlayerTransLog_Offset;

	private static FFieldAddress DebugPlayerTransLog_PropertyAddress;

	private static bool CricketBattleMode_IsValid;

	private static int CricketBattleMode_Offset;

	private static FFieldAddress CricketBattleMode_PropertyAddress;

	private static bool CricketReportServer_IsValid;

	private static int CricketReportServer_Offset;

	private static FFieldAddress CricketReportServer_PropertyAddress;

	private static bool DebugSettingLog_IsValid;

	private static int DebugSettingLog_Offset;

	private static FFieldAddress DebugSettingLog_PropertyAddress;

	private static bool NeedGSSDKUserCheck_IsValid;

	private static int NeedGSSDKUserCheck_Offset;

	private static FFieldAddress NeedGSSDKUserCheck_PropertyAddress;

	private static bool DebugTransGuideUI_IsValid;

	private static int DebugTransGuideUI_Offset;

	private static FFieldAddress DebugTransGuideUI_PropertyAddress;

	private static bool LQALanguage_IsValid;

	private static int LQALanguage_Offset;

	private static FFieldAddress LQALanguage_PropertyAddress;

	private static bool GSIsGlobalColorDeficiency_IsValid;

	private static int GSIsGlobalColorDeficiency_Offset;

	private static FFieldAddress GSIsGlobalColorDeficiency_PropertyAddress;

	private static bool DebugGameIntent_IsValid;

	private static int DebugGameIntent_Offset;

	private static FFieldAddress DebugGameIntent_PropertyAddress;

	private static bool ShowLoadingTimeText_IsValid;

	private static int ShowLoadingTimeText_Offset;

	private static FFieldAddress ShowLoadingTimeText_PropertyAddress;

	private static bool IsNeedPsoPrecompileWhenStartGame_IsValid;

	private static int IsNeedPsoPrecompileWhenStartGame_Offset;

	private static FFieldAddress IsNeedPsoPrecompileWhenStartGame_PropertyAddress;

	private static bool IsNeedPreStartGameProcess_IsValid;

	private static int IsNeedPreStartGameProcess_Offset;

	private static FFieldAddress IsNeedPreStartGameProcess_PropertyAddress;

	private static bool DisableInputMessage_IsValid;

	private static int DisableInputMessage_Offset;

	private static FFieldAddress DisableInputMessage_PropertyAddress;

	private static bool EnableUseNewTimelineForCPG_IsValid;

	private static int EnableUseNewTimelineForCPG_Offset;

	private static FFieldAddress EnableUseNewTimelineForCPG_PropertyAddress;

	private static bool DebugPlayGo_IsValid;

	private static int DebugPlayGo_Offset;

	private static FFieldAddress DebugPlayGo_PropertyAddress;

	private static bool EnablePlaneMoveMode_IsValid;

	private static int EnablePlaneMoveMode_Offset;

	private static FFieldAddress EnablePlaneMoveMode_PropertyAddress;

	private static bool DebugPlayerGuide_IsValid;

	private static int DebugPlayerGuide_Offset;

	private static FFieldAddress DebugPlayerGuide_PropertyAddress;

	private static bool DebugNewGamePlusGuide_IsValid;

	private static int DebugNewGamePlusGuide_Offset;

	private static FFieldAddress DebugNewGamePlusGuide_PropertyAddress;

	private static bool DebugBossRushGuide_IsValid;

	private static int DebugBossRushGuide_Offset;

	private static FFieldAddress DebugBossRushGuide_PropertyAddress;

	private static bool DebugMapGuide_IsValid;

	private static int DebugMapGuide_Offset;

	private static FFieldAddress DebugMapGuide_PropertyAddress;

	private static bool DebugDonutAudio_IsValid;

	private static int DebugDonutAudio_Offset;

	private static FFieldAddress DebugDonutAudio_PropertyAddress;

	private static bool IsOverSeaChannel_IsValid;

	private static int IsOverSeaChannel_Offset;

	private static FFieldAddress IsOverSeaChannel_PropertyAddress;

	private static bool EnableEncrypt_IsValid;

	private static int EnableEncrypt_Offset;

	private static FFieldAddress EnableEncrypt_PropertyAddress;

	private static bool SettingHostSimulation_IsValid;

	private static int SettingHostSimulation_Offset;

	private static FFieldAddress SettingHostSimulation_PropertyAddress;

	private static bool SettingEditorSimulation_IsValid;

	private static int SettingEditorSimulation_Offset;

	private static FFieldAddress SettingEditorSimulation_PropertyAddress;

	private static bool DevArchiveSizeCheck_IsValid;

	private static int DevArchiveSizeCheck_Offset;

	private static FFieldAddress DevArchiveSizeCheck_PropertyAddress;

	private static bool DisableDissolveDisplay_IsValid;

	private static int DisableDissolveDisplay_Offset;

	private static FFieldAddress DisableDissolveDisplay_PropertyAddress;

	private static bool ExceptionShowBtn_IsValid;

	private static int ExceptionShowBtn_Offset;

	private static FFieldAddress ExceptionShowBtn_PropertyAddress;

	private static bool ThrowException_IsValid;

	private static int ThrowException_Offset;

	private static FFieldAddress ThrowException_PropertyAddress;

	private static bool DebugSettingCvar_IsValid;

	private static int DebugSettingCvar_Offset;

	private static FFieldAddress DebugSettingCvar_PropertyAddress;

	private static bool DebugReInitRoleCheck_IsValid;

	private static int DebugReInitRoleCheck_Offset;

	private static FFieldAddress DebugReInitRoleCheck_PropertyAddress;

	private static bool DebugCollection_IsValid;

	private static int DebugCollection_Offset;

	private static FFieldAddress DebugCollection_PropertyAddress;

	private static bool ButtonMatSyncCheck_IsValid;

	private static int ButtonMatSyncCheck_Offset;

	private static FFieldAddress ButtonMatSyncCheck_PropertyAddress;

	private static bool OpenPastMemory_IsValid;

	private static int OpenPastMemory_Offset;

	private static FFieldAddress OpenPastMemory_PropertyAddress;

	private static bool OpenSimpleTips_IsValid;

	private static int OpenSimpleTips_Offset;

	private static FFieldAddress OpenSimpleTips_PropertyAddress;

	private static bool OpenLocalizationInEditor_IsValid;

	private static int OpenLocalizationInEditor_Offset;

	private static FFieldAddress OpenLocalizationInEditor_PropertyAddress;

	private static bool EnableEnhancedInputDelay_IsValid;

	private static int EnableEnhancedInputDelay_Offset;

	private static FFieldAddress EnableEnhancedInputDelay_PropertyAddress;

	private static bool EndingCreditsUseJson_IsValid;

	private static int EndingCreditsUseJson_Offset;

	private static FFieldAddress EndingCreditsUseJson_PropertyAddress;

	private static bool HideMiniGMSequenceTab_IsValid;

	private static int HideMiniGMSequenceTab_Offset;

	private static FFieldAddress HideMiniGMSequenceTab_PropertyAddress;

	private static bool GSWithBink_IsValid;

	private static int GSWithBink_Offset;

	private static FFieldAddress GSWithBink_PropertyAddress;

	private static bool BenckMarkOnly_IsValid;

	private static int BenckMarkOnly_Offset;

	private static FFieldAddress BenckMarkOnly_PropertyAddress;

	private static bool BenckMarkLoop_IsValid;

	private static int BenckMarkLoop_Offset;

	private static FFieldAddress BenckMarkLoop_PropertyAddress;

	private static bool DamageLogic_IsValid;

	private static int DamageLogic_Offset;

	private static FFieldAddress DamageLogic_PropertyAddress;

	private static bool DropItem_IsValid;

	private static int DropItem_Offset;

	private static FFieldAddress DropItem_PropertyAddress;

	private static bool Secret_IsValid;

	private static int Secret_Offset;

	private static FFieldAddress Secret_PropertyAddress;

	private static bool EntitySharedRefLeakDetect_IsValid;

	private static int EntitySharedRefLeakDetect_Offset;

	private static FFieldAddress EntitySharedRefLeakDetect_PropertyAddress;

	private static bool TaskGroup_IsValid;

	private static int TaskGroup_Offset;

	private static FFieldAddress TaskGroup_PropertyAddress;

	private static bool NPC_IsValid;

	private static int NPC_Offset;

	private static FFieldAddress NPC_PropertyAddress;

	private static bool ActiveManageUI_IsValid;

	private static int ActiveManageUI_Offset;

	private static FFieldAddress ActiveManageUI_PropertyAddress;

	private static bool GymModeInWindows_IsValid;

	private static int GymModeInWindows_Offset;

	private static FFieldAddress GymModeInWindows_PropertyAddress;

	private static bool GSSdkEnableCETesting_IsValid;

	private static int GSSdkEnableCETesting_Offset;

	private static FFieldAddress GSSdkEnableCETesting_PropertyAddress;

	private static bool KAServerUseTcp_IsValid;

	private static int KAServerUseTcp_Offset;

	private static FFieldAddress KAServerUseTcp_PropertyAddress;

	private static bool NeedLauncher_IsValid;

	private static int NeedLauncher_Offset;

	private static FFieldAddress NeedLauncher_PropertyAddress;

	private static bool HideCrashReportClientUi_IsValid;

	private static int HideCrashReportClientUi_Offset;

	private static FFieldAddress HideCrashReportClientUi_PropertyAddress;

	private static bool GSSdkReportUseCSharpHttp_IsValid;

	private static int GSSdkReportUseCSharpHttp_Offset;

	private static FFieldAddress GSSdkReportUseCSharpHttp_PropertyAddress;

	private static bool GSSdkReportUseAsyncHttp_IsValid;

	private static int GSSdkReportUseAsyncHttp_Offset;

	private static FFieldAddress GSSdkReportUseAsyncHttp_PropertyAddress;

	private static bool GSSdkReportEnable_IsValid;

	private static int GSSdkReportEnable_Offset;

	private static FFieldAddress GSSdkReportEnable_PropertyAddress;

	private static bool GSSdkReportDisableHttpRequest_IsValid;

	private static int GSSdkReportDisableHttpRequest_Offset;

	private static FFieldAddress GSSdkReportDisableHttpRequest_PropertyAddress;

	private static bool GSSdkEnableSensDataClean_IsValid;

	private static int GSSdkEnableSensDataClean_Offset;

	private static FFieldAddress GSSdkEnableSensDataClean_PropertyAddress;

	private static bool GSSdkEnableMonitor_IsValid;

	private static int GSSdkEnableMonitor_Offset;

	private static FFieldAddress GSSdkEnableMonitor_PropertyAddress;

	private static bool GSSdkEnablePerf_IsValid;

	private static int GSSdkEnablePerf_Offset;

	private static FFieldAddress GSSdkEnablePerf_PropertyAddress;

	private static bool SentryDebug_IsValid;

	private static int SentryDebug_Offset;

	private static FFieldAddress SentryDebug_PropertyAddress;

	private static bool SentryEnable_IsValid;

	private static int SentryEnable_Offset;

	private static FFieldAddress SentryEnable_PropertyAddress;

	private static bool SentryEnableTracing_IsValid;

	private static int SentryEnableTracing_Offset;

	private static FFieldAddress SentryEnableTracing_PropertyAddress;

	private static bool SentryCaptureFailRequests_IsValid;

	private static int SentryCaptureFailRequests_Offset;

	private static FFieldAddress SentryCaptureFailRequests_PropertyAddress;

	private static bool SentryUseLocalCacheFile_IsValid;

	private static int SentryUseLocalCacheFile_Offset;

	private static FFieldAddress SentryUseLocalCacheFile_PropertyAddress;

	private static bool PlatformEventSendIntervalMilliSecond_IsValid;

	private static int PlatformEventSendIntervalMilliSecond_Offset;

	private static bool PlatformEventTimeoutMilliSecond_IsValid;

	private static int PlatformEventTimeoutMilliSecond_Offset;

	private static bool PlayerLogMaxSize_IsValid;

	private static int PlayerLogMaxSize_Offset;

	private static bool ReportTimeout_IsValid;

	private static int ReportTimeout_Offset;

	private static bool UseDebugTamerConfig_IsValid;

	private static int UseDebugTamerConfig_Offset;

	private static bool HideLockTarget_IsValid;

	private static int HideLockTarget_Offset;

	private static bool EventWarningLevel_IsValid;

	private static int EventWarningLevel_Offset;

	private static bool DebugOnlineLevelId_IsValid;

	private static int DebugOnlineLevelId_Offset;

	private static bool UITickProfileLevel_IsValid;

	private static int UITickProfileLevel_Offset;

	private static bool CollectionForceType_IsValid;

	private static int CollectionForceType_Offset;

	private static bool LockDesiredPlayerHP_IsValid;

	private static int LockDesiredPlayerHP_Offset;

	private static bool FSRCrashOptions_IsValid;

	private static int FSRCrashOptions_Offset;

	private static bool Demo820PlayCountMax_IsValid;

	private static int Demo820PlayCountMax_Offset;

	private static bool CricketBattleModeType_IsValid;

	private static int CricketBattleModeType_Offset;

	private static bool LoadingMaxTime_IsValid;

	private static int LoadingMaxTime_Offset;

	private static bool LoadingMaxTimeShowTips_IsValid;

	private static int LoadingMaxTimeShowTips_Offset;

	private static bool EnsureReportInterval_IsValid;

	private static int EnsureReportInterval_Offset;

	private static bool DevArchiveSizeMax_IsValid;

	private static int DevArchiveSizeMax_Offset;

	private static bool DebugOverSeaType_IsValid;

	private static int DebugOverSeaType_Offset;

	private static bool WaitMSToThrowException_IsValid;

	private static int WaitMSToThrowException_Offset;

	private static bool UpdateUserConfigInterval_IsValid;

	private static int UpdateUserConfigInterval_Offset;

	private static bool DebugGameCount_IsValid;

	private static int DebugGameCount_Offset;

	private static bool WeaponBuildMode_IsValid;

	private static int WeaponBuildMode_Offset;

	private static bool EnhancedInputDelayTime_IsValid;

	private static int EnhancedInputDelayTime_Offset;

	private static bool EnhancedInputSpecialDelayTime_IsValid;

	private static int EnhancedInputSpecialDelayTime_Offset;

	private static bool MediaPlayerSyncToleranceMS_IsValid;

	private static int MediaPlayerSyncToleranceMS_Offset;

	private static bool MediaPlayerSyncCDMS_IsValid;

	private static int MediaPlayerSyncCDMS_Offset;

	private static bool BenckMarkGPULow_IsValid;

	private static int BenckMarkGPULow_Offset;

	private static bool ForceEnableDebugGMFlags_IsValid;

	private static int ForceEnableDebugGMFlags_Offset;

	private static bool KAServerPort_IsValid;

	private static int KAServerPort_Offset;

	private static bool GSSdkReportMergeBatchEventNum_IsValid;

	private static int GSSdkReportMergeBatchEventNum_Offset;

	private static bool GSSdkReportMergeBatchIntervalSeconds_IsValid;

	private static int GSSdkReportMergeBatchIntervalSeconds_Offset;

	private static bool EnableAllGMCMDAndDebug_IsValid;

	private static int EnableAllGMCMDAndDebug_Offset;

	private static bool CESetRealBranchName_IsValid;

	private static int CESetRealBranchName_Offset;

	private static bool RoomServerConnectAddr_IsValid;

	private static int RoomServerConnectAddr_Offset;

	private static bool DebugDrawTag_IsValid;

	private static int DebugDrawTag_Offset;

	private static bool B1DeluxeAddOnId_IsValid;

	private static int B1DeluxeAddOnId_Offset;

	private static bool B1PrePurchaseAddOnId_IsValid;

	private static int B1PrePurchaseAddOnId_Offset;

	private static bool FileIOStrategy_IsValid;

	private static int FileIOStrategy_Offset;

	private static bool DebugRtxEnableLevel_IsValid;

	private static int DebugRtxEnableLevel_Offset;

	private static bool FAQWebsiteLink_IsValid;

	private static int FAQWebsiteLink_Offset;

	private static bool FileMd5CheckIgnorePathPattern_IsValid;

	private static int FileMd5CheckIgnorePathPattern_Offset;

	private static bool KAServerHost_IsValid;

	private static int KAServerHost_Offset;

	private static bool KAExtraId_IsValid;

	private static int KAExtraId_Offset;

	private static bool DevGamesciLoginServerUrl_IsValid;

	private static int DevGamesciLoginServerUrl_Offset;

	private static bool Environment_IsValid;

	private static int Environment_Offset;

	private static bool GSSdkCDNRootUrlList_IsValid;

	private static int GSSdkCDNRootUrlList_Offset;

	private static bool GSSdkEnvServerUrlList_IsValid;

	private static int GSSdkEnvServerUrlList_Offset;

	private static bool GSSdkAppChannel_IsValid;

	private static int GSSdkAppChannel_Offset;

	private static bool GSSdkLoginChannel_IsValid;

	private static int GSSdkLoginChannel_Offset;

	private static bool GSSdkLoginSubChannel_IsValid;

	private static int GSSdkLoginSubChannel_Offset;

	private static bool GSSdkPackageTags_IsValid;

	private static int GSSdkPackageTags_Offset;

	private static bool SentryDSN_IsValid;

	private static int SentryDSN_Offset;

	private static bool SentryHostBackup_IsValid;

	private static int SentryHostBackup_Offset;

	private static bool SentrySampleRate_IsValid;

	private static int SentrySampleRate_Offset;

	private static bool MagicCheckOverlay_IsValid;

	private static int MagicCheckOverlay_Offset;

	[DisplayName("ArchiveRefactor:")]
	[Category("DebugConfig")]
	[Tooltip("ArchiveRefactor")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ArchiveRefactor")]
	public bool ArchiveRefactor
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveRefactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ArchiveRefactor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ArchiveRefactor_Offset), 0, ArchiveRefactor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveRefactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ArchiveRefactor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ArchiveRefactor_Offset), 0, ArchiveRefactor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("DebugWidget:")]
	[Tooltip("DebugWidget")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugWidget")]
	public bool DebugWidget
	{
		get
		{
			CheckDestroyed();
			if (!DebugWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugWidget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugWidget_Offset), 0, DebugWidget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugWidget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugWidget_Offset), 0, DebugWidget_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("ILRuntime")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("ILRuntime:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ILRuntime")]
	public bool ILRuntime
	{
		get
		{
			CheckDestroyed();
			if (!ILRuntime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ILRuntime_Offset), 0, ILRuntime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ILRuntime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ILRuntime_Offset), 0, ILRuntime_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("ILRuntimeJITOnDemand:")]
	[Tooltip("ILRuntime")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeJITOnDemand")]
	public bool ILRuntimeJITOnDemand
	{
		get
		{
			CheckDestroyed();
			if (!ILRuntimeJITOnDemand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeJITOnDemand");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ILRuntimeJITOnDemand_Offset), 0, ILRuntimeJITOnDemand_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ILRuntimeJITOnDemand_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeJITOnDemand");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ILRuntimeJITOnDemand_Offset), 0, ILRuntimeJITOnDemand_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("Clrbinding")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("Clrbinding:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Clrbinding")]
	public bool Clrbinding
	{
		get
		{
			CheckDestroyed();
			if (!Clrbinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Clrbinding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Clrbinding_Offset), 0, Clrbinding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Clrbinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Clrbinding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Clrbinding_Offset), 0, Clrbinding_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("ILRuntimeDebugger:")]
	[Category("DebugConfig")]
	[Tooltip("ILRuntimeDebugger")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeDebugger")]
	public bool ILRuntimeDebugger
	{
		get
		{
			CheckDestroyed();
			if (!ILRuntimeDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeDebugger");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ILRuntimeDebugger_Offset), 0, ILRuntimeDebugger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ILRuntimeDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ILRuntimeDebugger");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ILRuntimeDebugger_Offset), 0, ILRuntimeDebugger_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("允许开启光追:")]
	[Tooltip("允许开启光追")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableRtx")]
	public bool EnableRtx
	{
		get
		{
			CheckDestroyed();
			if (!EnableRtx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableRtx");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRtx_Offset), 0, EnableRtx_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRtx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableRtx");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRtx_Offset), 0, EnableRtx_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Report820Windows:")]
	[Tooltip("Report820Windows")]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Report820Windows")]
	public bool Report820Windows
	{
		get
		{
			CheckDestroyed();
			if (!Report820Windows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820Windows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Report820Windows_Offset), 0, Report820Windows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Report820Windows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820Windows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Report820Windows_Offset), 0, Report820Windows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("ManualBuiGC:")]
	[Tooltip("ManualBuiGC")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ManualBuiGC")]
	public bool ManualBuiGC
	{
		get
		{
			CheckDestroyed();
			if (!ManualBuiGC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ManualBuiGC");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ManualBuiGC_Offset), 0, ManualBuiGC_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ManualBuiGC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ManualBuiGC");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ManualBuiGC_Offset), 0, ManualBuiGC_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("Report820PS5:")]
	[Tooltip("Report820PS5")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Report820PS5")]
	public bool Report820PS5
	{
		get
		{
			CheckDestroyed();
			if (!Report820PS5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820PS5");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Report820PS5_Offset), 0, Report820PS5_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Report820PS5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820PS5");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Report820PS5_Offset), 0, Report820PS5_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("Report820XSX")]
	[DisplayName("Report820XSX:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Report820XSX")]
	public bool Report820XSX
	{
		get
		{
			CheckDestroyed();
			if (!Report820XSX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820XSX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Report820XSX_Offset), 0, Report820XSX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Report820XSX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820XSX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Report820XSX_Offset), 0, Report820XSX_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("Report820WindowsRealtime:")]
	[Tooltip("Report820WindowsRealtime")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Report820WindowsRealtime")]
	public bool Report820WindowsRealtime
	{
		get
		{
			CheckDestroyed();
			if (!Report820WindowsRealtime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820WindowsRealtime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Report820WindowsRealtime_Offset), 0, Report820WindowsRealtime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Report820WindowsRealtime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Report820WindowsRealtime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Report820WindowsRealtime_Offset), 0, Report820WindowsRealtime_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[Tooltip("ArchiveBackup")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("ArchiveBackup:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ArchiveBackup")]
	public bool ArchiveBackup
	{
		get
		{
			CheckDestroyed();
			if (!ArchiveBackup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ArchiveBackup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ArchiveBackup_Offset), 0, ArchiveBackup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ArchiveBackup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ArchiveBackup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ArchiveBackup_Offset), 0, ArchiveBackup_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("OverridePlayerLogMaxSize")]
	[DisplayName("OverridePlayerLogMaxSize:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OverridePlayerLogMaxSize")]
	public bool OverridePlayerLogMaxSize
	{
		get
		{
			CheckDestroyed();
			if (!OverridePlayerLogMaxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OverridePlayerLogMaxSize");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverridePlayerLogMaxSize_Offset), 0, OverridePlayerLogMaxSize_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverridePlayerLogMaxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OverridePlayerLogMaxSize");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverridePlayerLogMaxSize_Offset), 0, OverridePlayerLogMaxSize_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("DebugCFSMG:")]
	[Tooltip("DebugCFSMG")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugCFSMG")]
	public bool DebugCFSMG
	{
		get
		{
			CheckDestroyed();
			if (!DebugCFSMG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugCFSMG");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugCFSMG_Offset), 0, DebugCFSMG_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugCFSMG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugCFSMG");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugCFSMG_Offset), 0, DebugCFSMG_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SimTimeMarkBase:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[Tooltip("SimTimeMarkBase")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkBase")]
	public bool SimTimeMarkBase
	{
		get
		{
			CheckDestroyed();
			if (!SimTimeMarkBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkBase");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimTimeMarkBase_Offset), 0, SimTimeMarkBase_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimTimeMarkBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkBase");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimTimeMarkBase_Offset), 0, SimTimeMarkBase_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("SimTimeMarkStep")]
	[DisplayName("SimTimeMarkStep:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkStep")]
	public bool SimTimeMarkStep
	{
		get
		{
			CheckDestroyed();
			if (!SimTimeMarkStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkStep");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimTimeMarkStep_Offset), 0, SimTimeMarkStep_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimTimeMarkStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SimTimeMarkStep");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimTimeMarkStep_Offset), 0, SimTimeMarkStep_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("展示引导功能的log信息")]
	[DisplayName("Navigation:")]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Navigation")]
	public bool Navigation
	{
		get
		{
			CheckDestroyed();
			if (!Navigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Navigation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Navigation_Offset), 0, Navigation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Navigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Navigation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Navigation_Offset), 0, Navigation_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Intimidation:")]
	[Tooltip("Intimidation")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Intimidation")]
	public bool Intimidation
	{
		get
		{
			CheckDestroyed();
			if (!Intimidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Intimidation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Intimidation_Offset), 0, Intimidation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Intimidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Intimidation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Intimidation_Offset), 0, Intimidation_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("分帧BeginPlay")]
	[DisplayName("分帧BeginPlay:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenSeparateFrameEntityBeginPlay")]
	public bool OpenSeparateFrameEntityBeginPlay
	{
		get
		{
			CheckDestroyed();
			if (!OpenSeparateFrameEntityBeginPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSeparateFrameEntityBeginPlay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenSeparateFrameEntityBeginPlay_Offset), 0, OpenSeparateFrameEntityBeginPlay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenSeparateFrameEntityBeginPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSeparateFrameEntityBeginPlay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenSeparateFrameEntityBeginPlay_Offset), 0, OpenSeparateFrameEntityBeginPlay_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("InteractiveObj:")]
	[Tooltip("InteractiveObj")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:InteractiveObj")]
	public bool InteractiveObj
	{
		get
		{
			CheckDestroyed();
			if (!InteractiveObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InteractiveObj");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InteractiveObj_Offset), 0, InteractiveObj_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InteractiveObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InteractiveObj");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InteractiveObj_Offset), 0, InteractiveObj_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("DrawSimpleOverlapDebug")]
	[DisplayName("DrawSimpleOverlapDebug:")]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DrawSimpleOverlapDebug")]
	public bool DrawSimpleOverlapDebug
	{
		get
		{
			CheckDestroyed();
			if (!DrawSimpleOverlapDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DrawSimpleOverlapDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawSimpleOverlapDebug_Offset), 0, DrawSimpleOverlapDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawSimpleOverlapDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DrawSimpleOverlapDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawSimpleOverlapDebug_Offset), 0, DrawSimpleOverlapDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("ProfilerSimpleOverlap:")]
	[Tooltip("ProfilerSimpleOverlap")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ProfilerSimpleOverlap")]
	public bool ProfilerSimpleOverlap
	{
		get
		{
			CheckDestroyed();
			if (!ProfilerSimpleOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ProfilerSimpleOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProfilerSimpleOverlap_Offset), 0, ProfilerSimpleOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProfilerSimpleOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ProfilerSimpleOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProfilerSimpleOverlap_Offset), 0, ProfilerSimpleOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("TopdownBattleMode:")]
	[Tooltip("TopdownBattleMode")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:TopdownBattleMode")]
	public bool TopdownBattleMode
	{
		get
		{
			CheckDestroyed();
			if (!TopdownBattleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TopdownBattleMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TopdownBattleMode_Offset), 0, TopdownBattleMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TopdownBattleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TopdownBattleMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TopdownBattleMode_Offset), 0, TopdownBattleMode_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("IsTmpTestFlag")]
	[DisplayName("IsTmpTestFlag:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsTmpTestFlag")]
	public bool IsTmpTestFlag
	{
		get
		{
			CheckDestroyed();
			if (!IsTmpTestFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsTmpTestFlag");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTmpTestFlag_Offset), 0, IsTmpTestFlag_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTmpTestFlag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsTmpTestFlag");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTmpTestFlag_Offset), 0, IsTmpTestFlag_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("OpenNewChapterPlayerSafeLocation:")]
	[Tooltip("开启章节中转时把玩家设置到安全位置")]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenNewChapterPlayerSafeLocation")]
	public bool OpenNewChapterPlayerSafeLocation
	{
		get
		{
			CheckDestroyed();
			if (!OpenNewChapterPlayerSafeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenNewChapterPlayerSafeLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenNewChapterPlayerSafeLocation_Offset), 0, OpenNewChapterPlayerSafeLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenNewChapterPlayerSafeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenNewChapterPlayerSafeLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenNewChapterPlayerSafeLocation_Offset), 0, OpenNewChapterPlayerSafeLocation_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("IsLiteBuild")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("IsLiteBuild:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsLiteBuild")]
	public bool IsLiteBuild
	{
		get
		{
			CheckDestroyed();
			if (!IsLiteBuild_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsLiteBuild");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsLiteBuild_Offset), 0, IsLiteBuild_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsLiteBuild_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsLiteBuild");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsLiteBuild_Offset), 0, IsLiteBuild_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("OpenGSRepLog:")]
	[Tooltip("OpenGSRepLog")]
	[EditAnywhere]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenGSRepLog")]
	public bool OpenGSRepLog
	{
		get
		{
			CheckDestroyed();
			if (!OpenGSRepLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenGSRepLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenGSRepLog_Offset), 0, OpenGSRepLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenGSRepLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenGSRepLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenGSRepLog_Offset), 0, OpenGSRepLog_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("ClientReset")]
	[DisplayName("ClientReset:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ClientReset")]
	public bool ClientReset
	{
		get
		{
			CheckDestroyed();
			if (!ClientReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ClientReset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClientReset_Offset), 0, ClientReset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClientReset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ClientReset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClientReset_Offset), 0, ClientReset_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("ProfileEnable:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("ProfileEnable")]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ProfileEnable")]
	public bool ProfileEnable
	{
		get
		{
			CheckDestroyed();
			if (!ProfileEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ProfileEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ProfileEnable_Offset), 0, ProfileEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProfileEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ProfileEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ProfileEnable_Offset), 0, ProfileEnable_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[DisplayName("Enablepreload:")]
	[Tooltip("开启预加载")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Enablepreload")]
	public bool Enablepreload
	{
		get
		{
			CheckDestroyed();
			if (!Enablepreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Enablepreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enablepreload_Offset), 0, Enablepreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enablepreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Enablepreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enablepreload_Offset), 0, Enablepreload_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("CantCloseNetConnectWithError:")]
	[Tooltip("联机下主机报错客户端不弹回浮屠塔")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CantCloseNetConnectWithError")]
	public bool CantCloseNetConnectWithError
	{
		get
		{
			CheckDestroyed();
			if (!CantCloseNetConnectWithError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CantCloseNetConnectWithError");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CantCloseNetConnectWithError_Offset), 0, CantCloseNetConnectWithError_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CantCloseNetConnectWithError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CantCloseNetConnectWithError");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CantCloseNetConnectWithError_Offset), 0, CantCloseNetConnectWithError_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[DisplayName("SkipRoleDataCheck:")]
	[Tooltip("跳过角色数据检查")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SkipRoleDataCheck")]
	public bool SkipRoleDataCheck
	{
		get
		{
			CheckDestroyed();
			if (!SkipRoleDataCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SkipRoleDataCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipRoleDataCheck_Offset), 0, SkipRoleDataCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipRoleDataCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SkipRoleDataCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipRoleDataCheck_Offset), 0, SkipRoleDataCheck_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[DisplayName("EnableMoveSpeedInfoDebug:")]
	[Tooltip("移动速度信息Debug")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableMoveSpeedInfoDebug")]
	public bool EnableMoveSpeedInfoDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableMoveSpeedInfoDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableMoveSpeedInfoDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableMoveSpeedInfoDebug_Offset), 0, EnableMoveSpeedInfoDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableMoveSpeedInfoDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableMoveSpeedInfoDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableMoveSpeedInfoDebug_Offset), 0, EnableMoveSpeedInfoDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("EnablePrintJXSQCheckerResult:")]
	[Tooltip("打印JXSQ释放信息Log")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnablePrintJXSQCheckerResult")]
	public bool EnablePrintJXSQCheckerResult
	{
		get
		{
			CheckDestroyed();
			if (!EnablePrintJXSQCheckerResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnablePrintJXSQCheckerResult");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePrintJXSQCheckerResult_Offset), 0, EnablePrintJXSQCheckerResult_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePrintJXSQCheckerResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnablePrintJXSQCheckerResult");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePrintJXSQCheckerResult_Offset), 0, EnablePrintJXSQCheckerResult_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("章节漫游第二套方案")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("EnableChapterRoamV2:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableChapterRoamV2")]
	public bool EnableChapterRoamV2
	{
		get
		{
			CheckDestroyed();
			if (!EnableChapterRoamV2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableChapterRoamV2");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableChapterRoamV2_Offset), 0, EnableChapterRoamV2_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableChapterRoamV2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableChapterRoamV2");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableChapterRoamV2_Offset), 0, EnableChapterRoamV2_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("ChapterDebug:")]
	[Tooltip("章节中转Debug")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ChapterDebug")]
	public bool ChapterDebug
	{
		get
		{
			CheckDestroyed();
			if (!ChapterDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ChapterDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ChapterDebug_Offset), 0, ChapterDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ChapterDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ChapterDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ChapterDebug_Offset), 0, ChapterDebug_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[Tooltip("开启土地庙所有功能")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("EnableShrineAllFunc:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableShrineAllFunc")]
	public bool EnableShrineAllFunc
	{
		get
		{
			CheckDestroyed();
			if (!EnableShrineAllFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableShrineAllFunc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableShrineAllFunc_Offset), 0, EnableShrineAllFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableShrineAllFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableShrineAllFunc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableShrineAllFunc_Offset), 0, EnableShrineAllFunc_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("EnableInteractAllFunc:")]
	[Tooltip("开启NPC交互所有功能")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableInteractAllFunc")]
	public bool EnableInteractAllFunc
	{
		get
		{
			CheckDestroyed();
			if (!EnableInteractAllFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableInteractAllFunc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableInteractAllFunc_Offset), 0, EnableInteractAllFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableInteractAllFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableInteractAllFunc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableInteractAllFunc_Offset), 0, EnableInteractAllFunc_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[Tooltip("关闭跳过交互功能")]
	[DisplayName("DisableSkipInteractFunc:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipInteractFunc")]
	public bool DisableSkipInteractFunc
	{
		get
		{
			CheckDestroyed();
			if (!DisableSkipInteractFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipInteractFunc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableSkipInteractFunc_Offset), 0, DisableSkipInteractFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableSkipInteractFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipInteractFunc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableSkipInteractFunc_Offset), 0, DisableSkipInteractFunc_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[DisplayName("DisableSkipMontageInteractFunc:")]
	[Tooltip("关闭动画交互短句跳过功能")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipMontageInteractFunc")]
	public bool DisableSkipMontageInteractFunc
	{
		get
		{
			CheckDestroyed();
			if (!DisableSkipMontageInteractFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipMontageInteractFunc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableSkipMontageInteractFunc_Offset), 0, DisableSkipMontageInteractFunc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableSkipMontageInteractFunc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableSkipMontageInteractFunc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableSkipMontageInteractFunc_Offset), 0, DisableSkipMontageInteractFunc_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("SpawnWave_Debug:")]
	[Tooltip("SpawnWave_Debug")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SpawnWaveDebug")]
	public bool SpawnWaveDebug
	{
		get
		{
			CheckDestroyed();
			if (!SpawnWaveDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SpawnWaveDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SpawnWaveDebug_Offset), 0, SpawnWaveDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnWaveDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SpawnWaveDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SpawnWaveDebug_Offset), 0, SpawnWaveDebug_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("蓝图中立生物生成器Debug:")]
	[Tooltip("蓝图中立生物生成器Debug")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:BPNeutralAnimalDebug")]
	public bool BPNeutralAnimalDebug
	{
		get
		{
			CheckDestroyed();
			if (!BPNeutralAnimalDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BPNeutralAnimalDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BPNeutralAnimalDebug_Offset), 0, BPNeutralAnimalDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BPNeutralAnimalDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BPNeutralAnimalDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BPNeutralAnimalDebug_Offset), 0, BPNeutralAnimalDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[Tooltip("是否纯净版本")]
	[DisplayName("PureVersion:")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PureVersion")]
	public bool PureVersion
	{
		get
		{
			CheckDestroyed();
			if (!PureVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PureVersion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PureVersion_Offset), 0, PureVersion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PureVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PureVersion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PureVersion_Offset), 0, PureVersion_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[DisplayName("开启预购版奖励:")]
	[Tooltip("开启预购版奖励")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PreOrderAwardDebug")]
	public bool PreOrderAwardDebug
	{
		get
		{
			CheckDestroyed();
			if (!PreOrderAwardDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PreOrderAwardDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreOrderAwardDebug_Offset), 0, PreOrderAwardDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreOrderAwardDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PreOrderAwardDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreOrderAwardDebug_Offset), 0, PreOrderAwardDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("开启豪华版奖励:")]
	[Tooltip("开启豪华版奖励")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DeluxeAwardDebug")]
	public bool DeluxeAwardDebug
	{
		get
		{
			CheckDestroyed();
			if (!DeluxeAwardDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DeluxeAwardDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DeluxeAwardDebug_Offset), 0, DeluxeAwardDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeluxeAwardDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DeluxeAwardDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DeluxeAwardDebug_Offset), 0, DeluxeAwardDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("关闭RPC日志:")]
	[Tooltip("关闭RPC日志")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DisableRpcLog")]
	public bool DisableRpcLog
	{
		get
		{
			CheckDestroyed();
			if (!DisableRpcLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableRpcLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableRpcLog_Offset), 0, DisableRpcLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableRpcLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableRpcLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableRpcLog_Offset), 0, DisableRpcLog_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("为false隐藏所有UI")]
	[DisplayName("ActiveAllUI:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("UIConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ActiveAllUI")]
	public bool ActiveAllUI
	{
		get
		{
			CheckDestroyed();
			if (!ActiveAllUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ActiveAllUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ActiveAllUI_Offset), 0, ActiveAllUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActiveAllUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ActiveAllUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ActiveAllUI_Offset), 0, ActiveAllUI_PropertyAddress.Address, value);
			}
		}
	}

	[Category("UIConfig")]
	[DisplayName("Open1080Check:")]
	[Tooltip("开启1080P检查")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Open1080Check")]
	public bool Open1080Check
	{
		get
		{
			CheckDestroyed();
			if (!Open1080Check_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Open1080Check");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Open1080Check_Offset), 0, Open1080Check_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Open1080Check_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Open1080Check");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Open1080Check_Offset), 0, Open1080Check_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("GSDisableLoadingScreen:")]
	[Tooltip("不显示loading界面")]
	[Category("UIConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSDisableLoadingScreen")]
	public bool GSDisableLoadingScreen
	{
		get
		{
			CheckDestroyed();
			if (!GSDisableLoadingScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSDisableLoadingScreen");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSDisableLoadingScreen_Offset), 0, GSDisableLoadingScreen_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSDisableLoadingScreen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSDisableLoadingScreen");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSDisableLoadingScreen_Offset), 0, GSDisableLoadingScreen_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("UIConfig")]
	[DisplayName("OnlyOpenPVUI:")]
	[Tooltip("仅打开PV相关UI")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OnlyOpenPVUI")]
	public bool OnlyOpenPVUI
	{
		get
		{
			CheckDestroyed();
			if (!OnlyOpenPVUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlyOpenPVUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyOpenPVUI_Offset), 0, OnlyOpenPVUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyOpenPVUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlyOpenPVUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyOpenPVUI_Offset), 0, OnlyOpenPVUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("高级掉落手动关闭")]
	[EditAnywhere]
	[Category("UIConfig")]
	[DisplayName("高级掉落手动关闭:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:AdvanceDropManualClose")]
	public bool AdvanceDropManualClose
	{
		get
		{
			CheckDestroyed();
			if (!AdvanceDropManualClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AdvanceDropManualClose");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AdvanceDropManualClose_Offset), 0, AdvanceDropManualClose_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AdvanceDropManualClose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AdvanceDropManualClose");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AdvanceDropManualClose_Offset), 0, AdvanceDropManualClose_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Input")]
	[DisplayName("InputDebugInfo:")]
	[Tooltip("显示主角按键Debug信息")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:InputDebugInfo")]
	public bool InputDebugInfo
	{
		get
		{
			CheckDestroyed();
			if (!InputDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebugInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InputDebugInfo_Offset), 0, InputDebugInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputDebugInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebugInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InputDebugInfo_Offset), 0, InputDebugInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Input")]
	[DisplayName("InputDebug_Window:")]
	[Tooltip("显示主角按键窗口信息")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_Window")]
	public bool InputDebug_Window
	{
		get
		{
			CheckDestroyed();
			if (!InputDebug_Window_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_Window");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InputDebug_Window_Offset), 0, InputDebug_Window_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputDebug_Window_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_Window");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InputDebug_Window_Offset), 0, InputDebug_Window_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Input")]
	[EditAnywhere]
	[DisplayName("InputDebug_KeyCache:")]
	[Tooltip("显示主角按键缓存信息")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_KeyCache")]
	public bool InputDebug_KeyCache
	{
		get
		{
			CheckDestroyed();
			if (!InputDebug_KeyCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_KeyCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InputDebug_KeyCache_Offset), 0, InputDebug_KeyCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputDebug_KeyCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:InputDebug_KeyCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InputDebug_KeyCache_Offset), 0, InputDebug_KeyCache_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("GroupAI:")]
	[Tooltip("GroupAI")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GroupAI")]
	public bool GroupAI
	{
		get
		{
			CheckDestroyed();
			if (!GroupAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GroupAI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GroupAI_Offset), 0, GroupAI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GroupAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GroupAI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GroupAI_Offset), 0, GroupAI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("AIInfo:")]
	[Tooltip("AIInfo")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:AIInfo")]
	public bool AIInfo
	{
		get
		{
			CheckDestroyed();
			if (!AIInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AIInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AIInfo_Offset), 0, AIInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AIInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AIInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AIInfo_Offset), 0, AIInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("TeamInfo:")]
	[Tooltip("TeamInfo")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:TeamInfo")]
	public bool TeamInfo
	{
		get
		{
			CheckDestroyed();
			if (!TeamInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TeamInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TeamInfo_Offset), 0, TeamInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TeamInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TeamInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TeamInfo_Offset), 0, TeamInfo_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("FollowPartnerDispInfo:")]
	[EditAnywhere]
	[Category("AI")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("FollowPartnerDispInfo")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:FollowPartnerDispInfo")]
	public bool FollowPartnerDispInfo
	{
		get
		{
			CheckDestroyed();
			if (!FollowPartnerDispInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FollowPartnerDispInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FollowPartnerDispInfo_Offset), 0, FollowPartnerDispInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FollowPartnerDispInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FollowPartnerDispInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FollowPartnerDispInfo_Offset), 0, FollowPartnerDispInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("TargetInfo:")]
	[Tooltip("查看目标信息")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:TargetInfo")]
	public bool TargetInfo
	{
		get
		{
			CheckDestroyed();
			if (!TargetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TargetInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TargetInfo_Offset), 0, TargetInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TargetInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TargetInfo_Offset), 0, TargetInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AI")]
	[DisplayName("HatredInfo:")]
	[Tooltip("查看仇恨信息")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:HatredInfo")]
	public bool HatredInfo
	{
		get
		{
			CheckDestroyed();
			if (!HatredInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HatredInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HatredInfo_Offset), 0, HatredInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HatredInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HatredInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HatredInfo_Offset), 0, HatredInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("AI")]
	[DisplayName("AINodeDebug:")]
	[Tooltip("查看AINode节点信息")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:AINodeDebug")]
	public bool AINodeDebug
	{
		get
		{
			CheckDestroyed();
			if (!AINodeDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AINodeDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AINodeDebug_Offset), 0, AINodeDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AINodeDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:AINodeDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AINodeDebug_Offset), 0, AINodeDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Anim")]
	[DisplayName("ABPHelperInfo:")]
	[Tooltip("ABPHelperInfo")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ABPHelperInfo")]
	public bool ABPHelperInfo
	{
		get
		{
			CheckDestroyed();
			if (!ABPHelperInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ABPHelperInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ABPHelperInfo_Offset), 0, ABPHelperInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ABPHelperInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ABPHelperInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ABPHelperInfo_Offset), 0, ABPHelperInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("OnlineAttr:")]
	[Tooltip("看联机单位属性")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OnlineAttr")]
	public bool OnlineAttr
	{
		get
		{
			CheckDestroyed();
			if (!OnlineAttr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlineAttr");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlineAttr_Offset), 0, OnlineAttr_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlineAttr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlineAttr");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlineAttr_Offset), 0, OnlineAttr_PropertyAddress.Address, value);
			}
		}
	}

	[Category("OnlineDebug")]
	[EditAnywhere]
	[Tooltip("看联机单位状态")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("OnlineUnitState:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OnlineUnitState")]
	public bool OnlineUnitState
	{
		get
		{
			CheckDestroyed();
			if (!OnlineUnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlineUnitState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlineUnitState_Offset), 0, OnlineUnitState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlineUnitState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OnlineUnitState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlineUnitState_Offset), 0, OnlineUnitState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("IsDebugDS:")]
	[Tooltip("独立服务器调试")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugDS")]
	public bool IsDebugDS
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugDS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugDS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugDS_Offset), 0, IsDebugDS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugDS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugDS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugDS_Offset), 0, IsDebugDS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("ConnectionInfo:")]
	[Tooltip("查看网络情况")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ConnectionInfo")]
	public bool ConnectionInfo
	{
		get
		{
			CheckDestroyed();
			if (!ConnectionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ConnectionInfo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConnectionInfo_Offset), 0, ConnectionInfo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConnectionInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ConnectionInfo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConnectionInfo_Offset), 0, ConnectionInfo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("PlayerDebugDraw:")]
	[Tooltip("画出玩家位置")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PlayerDebugDraw")]
	public bool PlayerDebugDraw
	{
		get
		{
			CheckDestroyed();
			if (!PlayerDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlayerDebugDraw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayerDebugDraw_Offset), 0, PlayerDebugDraw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayerDebugDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlayerDebugDraw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayerDebugDraw_Offset), 0, PlayerDebugDraw_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("OpenNetConnectDebugUI:")]
	[Tooltip("查看网络情况")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenNetConnectDebugUI")]
	public bool OpenNetConnectDebugUI
	{
		get
		{
			CheckDestroyed();
			if (!OpenNetConnectDebugUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenNetConnectDebugUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenNetConnectDebugUI_Offset), 0, OpenNetConnectDebugUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenNetConnectDebugUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenNetConnectDebugUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenNetConnectDebugUI_Offset), 0, OpenNetConnectDebugUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("OnlineDebug")]
	[DisplayName("DebugGSRepRole:")]
	[Tooltip("DebugGSRepRole")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugGSRepRole")]
	public bool DebugGSRepRole
	{
		get
		{
			CheckDestroyed();
			if (!DebugGSRepRole_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGSRepRole");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugGSRepRole_Offset), 0, DebugGSRepRole_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugGSRepRole_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGSRepRole");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugGSRepRole_Offset), 0, DebugGSRepRole_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("OpenEventDebugger")]
	[DisplayName("OpenEventDebugger:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("OnlineDebug")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenEventDebugger")]
	public bool OpenEventDebugger
	{
		get
		{
			CheckDestroyed();
			if (!OpenEventDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenEventDebugger");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenEventDebugger_Offset), 0, OpenEventDebugger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenEventDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenEventDebugger");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenEventDebugger_Offset), 0, OpenEventDebugger_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("IsDebugAKB")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugAKB:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAKB")]
	public bool IsDebugAKB
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugAKB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAKB");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugAKB_Offset), 0, IsDebugAKB_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugAKB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAKB");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugAKB_Offset), 0, IsDebugAKB_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("IsDebugUISys:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugUI")]
	[Tooltip("IsDebugUISys")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUISys")]
	public bool IsDebugUISys
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugUISys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUISys");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugUISys_Offset), 0, IsDebugUISys_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugUISys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUISys");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugUISys_Offset), 0, IsDebugUISys_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugUIMore:")]
	[Tooltip("IsDebugUIMore")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIMore")]
	public bool IsDebugUIMore
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugUIMore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIMore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugUIMore_Offset), 0, IsDebugUIMore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugUIMore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIMore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugUIMore_Offset), 0, IsDebugUIMore_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugUI")]
	[DisplayName("IsDebugUIProc:")]
	[Tooltip("IsDebugUIProc")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIProc")]
	public bool IsDebugUIProc
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugUIProc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIProc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugUIProc_Offset), 0, IsDebugUIProc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugUIProc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUIProc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugUIProc_Offset), 0, IsDebugUIProc_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("IsDebugWidgetMore")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugWidgetMore:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetMore")]
	public bool IsDebugWidgetMore
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugWidgetMore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetMore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugWidgetMore_Offset), 0, IsDebugWidgetMore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugWidgetMore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetMore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugWidgetMore_Offset), 0, IsDebugWidgetMore_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugButton:")]
	[Tooltip("IsDebugButton")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugButton")]
	public bool IsDebugButton
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugButton");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugButton_Offset), 0, IsDebugButton_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugButton");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugButton_Offset), 0, IsDebugButton_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugAutoSizeScrollBox:")]
	[Tooltip("IsDebugAutoSizeScrollBox")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAutoSizeScrollBox")]
	public bool IsDebugAutoSizeScrollBox
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugAutoSizeScrollBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAutoSizeScrollBox");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugAutoSizeScrollBox_Offset), 0, IsDebugAutoSizeScrollBox_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugAutoSizeScrollBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugAutoSizeScrollBox");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugAutoSizeScrollBox_Offset), 0, IsDebugAutoSizeScrollBox_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("IsDebugWidgetProfile")]
	[DisplayName("IsDebugWidgetProfile:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugUI")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetProfile")]
	public bool IsDebugWidgetProfile
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugWidgetProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetProfile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugWidgetProfile_Offset), 0, IsDebugWidgetProfile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugWidgetProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugWidgetProfile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugWidgetProfile_Offset), 0, IsDebugWidgetProfile_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("IsDebugUITick:")]
	[Tooltip("IsDebugUITick")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUITick")]
	public bool IsDebugUITick
	{
		get
		{
			CheckDestroyed();
			if (!IsDebugUITick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUITick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDebugUITick_Offset), 0, IsDebugUITick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDebugUITick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsDebugUITick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDebugUITick_Offset), 0, IsDebugUITick_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugUI")]
	[DisplayName("IsOpenStatGSCustom:")]
	[Tooltip("IsOpenStatGSCustom")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsOpenStatGSCustom")]
	public bool IsOpenStatGSCustom
	{
		get
		{
			CheckDestroyed();
			if (!IsOpenStatGSCustom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenStatGSCustom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOpenStatGSCustom_Offset), 0, IsOpenStatGSCustom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOpenStatGSCustom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenStatGSCustom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOpenStatGSCustom_Offset), 0, IsOpenStatGSCustom_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugDrawUI")]
	[DisplayName("IsShowDebugDrawUI:")]
	[Tooltip("IsShowDebugDrawUI")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsShowDebugDrawUI")]
	public bool IsShowDebugDrawUI
	{
		get
		{
			CheckDestroyed();
			if (!IsShowDebugDrawUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsShowDebugDrawUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShowDebugDrawUI_Offset), 0, IsShowDebugDrawUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShowDebugDrawUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsShowDebugDrawUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShowDebugDrawUI_Offset), 0, IsShowDebugDrawUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugBattle")]
	[Tooltip("DebugPhaseCSG")]
	[DisplayName("DebugPhaseCSG:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugPhaseCSG")]
	public bool DebugPhaseCSG
	{
		get
		{
			CheckDestroyed();
			if (!DebugPhaseCSG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPhaseCSG");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugPhaseCSG_Offset), 0, DebugPhaseCSG_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugPhaseCSG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPhaseCSG");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugPhaseCSG_Offset), 0, DebugPhaseCSG_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugBattle")]
	[DisplayName("IsOpenBattleInfoTool:")]
	[Tooltip("IsOpenBattleInfoTool")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsOpenBattleInfoTool")]
	public bool IsOpenBattleInfoTool
	{
		get
		{
			CheckDestroyed();
			if (!IsOpenBattleInfoTool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenBattleInfoTool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOpenBattleInfoTool_Offset), 0, IsOpenBattleInfoTool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOpenBattleInfoTool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenBattleInfoTool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOpenBattleInfoTool_Offset), 0, IsOpenBattleInfoTool_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugBattle")]
	[DisplayName("CancelSkillCD:")]
	[Tooltip("取消怪物技能cd")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CancelSkillCD")]
	public bool CancelSkillCD
	{
		get
		{
			CheckDestroyed();
			if (!CancelSkillCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CancelSkillCD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CancelSkillCD_Offset), 0, CancelSkillCD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CancelSkillCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CancelSkillCD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CancelSkillCD_Offset), 0, CancelSkillCD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugMap")]
	[DisplayName("测试地图:")]
	[Tooltip("地图区域测试开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugMap")]
	public bool DebugMap
	{
		get
		{
			CheckDestroyed();
			if (!DebugMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugMap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugMap_Offset), 0, DebugMap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugMap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugMap_Offset), 0, DebugMap_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("ShowChrEnvMaskValue:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("角色环境遮罩Debug")]
	[Category("DebugEnv")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ShowChrEnvMaskValue")]
	public bool ShowChrEnvMaskValue
	{
		get
		{
			CheckDestroyed();
			if (!ShowChrEnvMaskValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ShowChrEnvMaskValue");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowChrEnvMaskValue_Offset), 0, ShowChrEnvMaskValue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowChrEnvMaskValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ShowChrEnvMaskValue");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowChrEnvMaskValue_Offset), 0, ShowChrEnvMaskValue_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("CheckTools")]
	[DisplayName("IsOpenRemoteTestCheat:")]
	[Tooltip("IsOpenRemoteTestCheat")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsOpenRemoteTestCheat")]
	public bool IsOpenRemoteTestCheat
	{
		get
		{
			CheckDestroyed();
			if (!IsOpenRemoteTestCheat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenRemoteTestCheat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOpenRemoteTestCheat_Offset), 0, IsOpenRemoteTestCheat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOpenRemoteTestCheat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOpenRemoteTestCheat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOpenRemoteTestCheat_Offset), 0, IsOpenRemoteTestCheat_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("表格校验开关")]
	[Category("CheckTools")]
	[DisplayName("IsIgnoreValidateData:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsIgnoreValidateData")]
	public bool IsIgnoreValidateData
	{
		get
		{
			CheckDestroyed();
			if (!IsIgnoreValidateData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsIgnoreValidateData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsIgnoreValidateData_Offset), 0, IsIgnoreValidateData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsIgnoreValidateData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsIgnoreValidateData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsIgnoreValidateData_Offset), 0, IsIgnoreValidateData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("开启内存泄露检查")]
	[DisplayName("内存泄漏检查:")]
	[Category("CheckTools")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EventMemoryLeakTest")]
	public bool EventMemoryLeakTest
	{
		get
		{
			CheckDestroyed();
			if (!EventMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EventMemoryLeakTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EventMemoryLeakTest_Offset), 0, EventMemoryLeakTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EventMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EventMemoryLeakTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EventMemoryLeakTest_Offset), 0, EventMemoryLeakTest_PropertyAddress.Address, value);
			}
		}
	}

	[Category("CheckTools")]
	[Tooltip("开启定时内存泄露检查")]
	[DisplayName("定时内存泄漏检查:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:TickEventMemoryLeakTest")]
	public bool TickEventMemoryLeakTest
	{
		get
		{
			CheckDestroyed();
			if (!TickEventMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TickEventMemoryLeakTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TickEventMemoryLeakTest_Offset), 0, TickEventMemoryLeakTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickEventMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TickEventMemoryLeakTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TickEventMemoryLeakTest_Offset), 0, TickEventMemoryLeakTest_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Obj内存泄漏检查:")]
	[Category("CheckTools")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("开启Obj内存泄露检查")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ObjMemoryLeakTest")]
	public bool ObjMemoryLeakTest
	{
		get
		{
			CheckDestroyed();
			if (!ObjMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ObjMemoryLeakTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ObjMemoryLeakTest_Offset), 0, ObjMemoryLeakTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ObjMemoryLeakTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ObjMemoryLeakTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ObjMemoryLeakTest_Offset), 0, ObjMemoryLeakTest_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("开启缓存引用方便在DotMemory中查看引用链")]
	[Category("CheckTools")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("内存泄漏检查缓存引用:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:MemoryLeakTestCacheObj")]
	public bool MemoryLeakTestCacheObj
	{
		get
		{
			CheckDestroyed();
			if (!MemoryLeakTestCacheObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MemoryLeakTestCacheObj");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MemoryLeakTestCacheObj_Offset), 0, MemoryLeakTestCacheObj_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MemoryLeakTestCacheObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MemoryLeakTestCacheObj");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MemoryLeakTestCacheObj_Offset), 0, MemoryLeakTestCacheObj_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Loading")]
	[Tooltip("开启选关卡界面")]
	[DisplayName("DebugStartWithOutArchive:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugStartWithOutArchive")]
	public bool DebugStartWithOutArchive
	{
		get
		{
			CheckDestroyed();
			if (!DebugStartWithOutArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugStartWithOutArchive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugStartWithOutArchive_Offset), 0, DebugStartWithOutArchive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugStartWithOutArchive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugStartWithOutArchive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugStartWithOutArchive_Offset), 0, DebugStartWithOutArchive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Loading")]
	[DisplayName("EnableSelectChapter:")]
	[Tooltip("允许新游戏选关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableSelectChapter")]
	public bool EnableSelectChapter
	{
		get
		{
			CheckDestroyed();
			if (!EnableSelectChapter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableSelectChapter");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSelectChapter_Offset), 0, EnableSelectChapter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSelectChapter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableSelectChapter");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSelectChapter_Offset), 0, EnableSelectChapter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("CanOptimizeTick:")]
	[Tooltip("性能优化开关")]
	[Category("Function")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CanOptimizeTick")]
	public bool CanOptimizeTick
	{
		get
		{
			CheckDestroyed();
			if (!CanOptimizeTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CanOptimizeTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanOptimizeTick_Offset), 0, CanOptimizeTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanOptimizeTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CanOptimizeTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanOptimizeTick_Offset), 0, CanOptimizeTick_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("Debug820Demo")]
	[DisplayName("Debug820Demo:")]
	[EditAnywhere]
	[Category("Function")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Debug820Demo")]
	public bool Debug820Demo
	{
		get
		{
			CheckDestroyed();
			if (!Debug820Demo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Debug820Demo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Debug820Demo_Offset), 0, Debug820Demo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Debug820Demo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Debug820Demo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Debug820Demo_Offset), 0, Debug820Demo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Function")]
	[DisplayName("Demo820OverSeaVersion:")]
	[Tooltip("Demo820OverSeaVersion")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820OverSeaVersion")]
	public bool Demo820OverSeaVersion
	{
		get
		{
			CheckDestroyed();
			if (!Demo820OverSeaVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820OverSeaVersion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Demo820OverSeaVersion_Offset), 0, Demo820OverSeaVersion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Demo820OverSeaVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820OverSeaVersion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Demo820OverSeaVersion_Offset), 0, Demo820OverSeaVersion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Function")]
	[EditAnywhere]
	[Tooltip("Demo820DebugTest")]
	[DisplayName("Demo820DebugTest:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820DebugTest")]
	public bool Demo820DebugTest
	{
		get
		{
			CheckDestroyed();
			if (!Demo820DebugTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820DebugTest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Demo820DebugTest_Offset), 0, Demo820DebugTest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Demo820DebugTest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820DebugTest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Demo820DebugTest_Offset), 0, Demo820DebugTest_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Function")]
	[DisplayName("Demo820UseSetting:")]
	[Tooltip("Demo820UseSetting")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820UseSetting")]
	public bool Demo820UseSetting
	{
		get
		{
			CheckDestroyed();
			if (!Demo820UseSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820UseSetting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Demo820UseSetting_Offset), 0, Demo820UseSetting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Demo820UseSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820UseSetting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Demo820UseSetting_Offset), 0, Demo820UseSetting_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("测试第一次启动游戏的设置项")]
	[DisplayName("DebugFristStartGame:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Function")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugFristStartGameSetting")]
	public bool DebugFristStartGameSetting
	{
		get
		{
			CheckDestroyed();
			if (!DebugFristStartGameSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugFristStartGameSetting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugFristStartGameSetting_Offset), 0, DebugFristStartGameSetting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugFristStartGameSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugFristStartGameSetting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugFristStartGameSetting_Offset), 0, DebugFristStartGameSetting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("LevelTravel")]
	[DisplayName("使用SeamlessLevelTravel:")]
	[Tooltip("使用SeamlessLevelTravel")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenSeamlessLevelTravel")]
	public bool OpenSeamlessLevelTravel
	{
		get
		{
			CheckDestroyed();
			if (!OpenSeamlessLevelTravel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSeamlessLevelTravel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenSeamlessLevelTravel_Offset), 0, OpenSeamlessLevelTravel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenSeamlessLevelTravel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSeamlessLevelTravel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenSeamlessLevelTravel_Offset), 0, OpenSeamlessLevelTravel_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("显示820特殊ExceptionUI")]
	[Category("Function")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("Demo820ExceptionUI:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820ExceptionUI")]
	public bool Demo820ExceptionUI
	{
		get
		{
			CheckDestroyed();
			if (!Demo820ExceptionUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820ExceptionUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Demo820ExceptionUI_Offset), 0, Demo820ExceptionUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Demo820ExceptionUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820ExceptionUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Demo820ExceptionUI_Offset), 0, Demo820ExceptionUI_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Function")]
	[DisplayName("Demo820IgnoreAllOverlap:")]
	[Tooltip("超时不播seq开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820IgnoreAllOverlap")]
	public bool Demo820IgnoreAllOverlap
	{
		get
		{
			CheckDestroyed();
			if (!Demo820IgnoreAllOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820IgnoreAllOverlap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Demo820IgnoreAllOverlap_Offset), 0, Demo820IgnoreAllOverlap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Demo820IgnoreAllOverlap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820IgnoreAllOverlap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Demo820IgnoreAllOverlap_Offset), 0, Demo820IgnoreAllOverlap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Function")]
	[Tooltip("输出变身日志")]
	[DisplayName("PrintTransLog:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerTransLog")]
	public bool DebugPlayerTransLog
	{
		get
		{
			CheckDestroyed();
			if (!DebugPlayerTransLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerTransLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugPlayerTransLog_Offset), 0, DebugPlayerTransLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugPlayerTransLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerTransLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugPlayerTransLog_Offset), 0, DebugPlayerTransLog_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Function")]
	[DisplayName("OpenCricketBattle:")]
	[Tooltip("开启蛐蛐战")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleMode")]
	public bool CricketBattleMode
	{
		get
		{
			CheckDestroyed();
			if (!CricketBattleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CricketBattleMode_Offset), 0, CricketBattleMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CricketBattleMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CricketBattleMode_Offset), 0, CricketBattleMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Function")]
	[DisplayName("CricketReportServer:")]
	[Tooltip("蛐蛐模式开启上报")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CricketReportServer")]
	public bool CricketReportServer
	{
		get
		{
			CheckDestroyed();
			if (!CricketReportServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketReportServer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CricketReportServer_Offset), 0, CricketReportServer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CricketReportServer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketReportServer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CricketReportServer_Offset), 0, CricketReportServer_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("DebugSettingLog:")]
	[Tooltip("设置调试查Bug用Log")]
	[Category("Function")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingLog")]
	public bool DebugSettingLog
	{
		get
		{
			CheckDestroyed();
			if (!DebugSettingLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugSettingLog_Offset), 0, DebugSettingLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugSettingLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugSettingLog_Offset), 0, DebugSettingLog_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("允许开启用户开关")]
	[DisplayName("NeedGSSDKUserCheck:")]
	[Category("Function")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:NeedGSSDKUserCheck")]
	public bool NeedGSSDKUserCheck
	{
		get
		{
			CheckDestroyed();
			if (!NeedGSSDKUserCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NeedGSSDKUserCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedGSSDKUserCheck_Offset), 0, NeedGSSDKUserCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedGSSDKUserCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NeedGSSDKUserCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedGSSDKUserCheck_Offset), 0, NeedGSSDKUserCheck_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("测试变身引导UI")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("DebugTransGuideUI:")]
	[Category("Function")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugTransGuideUI")]
	public bool DebugTransGuideUI
	{
		get
		{
			CheckDestroyed();
			if (!DebugTransGuideUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugTransGuideUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugTransGuideUI_Offset), 0, DebugTransGuideUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugTransGuideUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugTransGuideUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugTransGuideUI_Offset), 0, DebugTransGuideUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Function")]
	[DisplayName("LQA Language:")]
	[Tooltip("云游戏语言开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:LQALanguage")]
	public bool LQALanguage
	{
		get
		{
			CheckDestroyed();
			if (!LQALanguage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LQALanguage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LQALanguage_Offset), 0, LQALanguage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LQALanguage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LQALanguage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LQALanguage_Offset), 0, LQALanguage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("GSIsGlobalColorDeficiency:")]
	[Tooltip("色盲颜色辅助是否对全局颜色生效")]
	[Category("Function")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSIsGlobalColorDeficiency")]
	public bool GSIsGlobalColorDeficiency
	{
		get
		{
			CheckDestroyed();
			if (!GSIsGlobalColorDeficiency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSIsGlobalColorDeficiency");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSIsGlobalColorDeficiency_Offset), 0, GSIsGlobalColorDeficiency_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSIsGlobalColorDeficiency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSIsGlobalColorDeficiency");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSIsGlobalColorDeficiency_Offset), 0, GSIsGlobalColorDeficiency_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Loading")]
	[DisplayName("Game Intent:")]
	[Tooltip("测试PS5的Game Intent逻辑")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugGameIntent")]
	public bool DebugGameIntent
	{
		get
		{
			CheckDestroyed();
			if (!DebugGameIntent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGameIntent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugGameIntent_Offset), 0, DebugGameIntent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugGameIntent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGameIntent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugGameIntent_Offset), 0, DebugGameIntent_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("LoadingUI显示时长")]
	[DisplayName("LoadingUI ShowTime:")]
	[Category("Loading")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ShowLoadingTimeText")]
	public bool ShowLoadingTimeText
	{
		get
		{
			CheckDestroyed();
			if (!ShowLoadingTimeText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ShowLoadingTimeText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowLoadingTimeText_Offset), 0, ShowLoadingTimeText_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowLoadingTimeText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ShowLoadingTimeText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowLoadingTimeText_Offset), 0, ShowLoadingTimeText_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否需要在启动游戏时编译PSO:")]
	[Tooltip("是否需要在启动游戏时编译PSO")]
	[Category("Loading")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPsoPrecompileWhenStartGame")]
	public bool IsNeedPsoPrecompileWhenStartGame
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedPsoPrecompileWhenStartGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPsoPrecompileWhenStartGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedPsoPrecompileWhenStartGame_Offset), 0, IsNeedPsoPrecompileWhenStartGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedPsoPrecompileWhenStartGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPsoPrecompileWhenStartGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedPsoPrecompileWhenStartGame_Offset), 0, IsNeedPsoPrecompileWhenStartGame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("八字真言、健康游戏声明等")]
	[DisplayName("是否需要开始游戏前的流程:")]
	[Category("Loading")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPreStartGameProcess")]
	public bool IsNeedPreStartGameProcess
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedPreStartGameProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPreStartGameProcess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedPreStartGameProcess_Offset), 0, IsNeedPreStartGameProcess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedPreStartGameProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsNeedPreStartGameProcess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedPreStartGameProcess_Offset), 0, IsNeedPreStartGameProcess_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Disable Input Message:")]
	[Tooltip("屏蔽输入消息")]
	[EditAnywhere]
	[Category("Input")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DisableInputMessage")]
	public bool DisableInputMessage
	{
		get
		{
			CheckDestroyed();
			if (!DisableInputMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableInputMessage");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableInputMessage_Offset), 0, DisableInputMessage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableInputMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableInputMessage");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableInputMessage_Offset), 0, DisableInputMessage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Loading")]
	[DisplayName("Use new timeline for cpg:")]
	[Tooltip("是否使用新的时序去创建CPG")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableUseNewTimelineForCPG")]
	public bool EnableUseNewTimelineForCPG
	{
		get
		{
			CheckDestroyed();
			if (!EnableUseNewTimelineForCPG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableUseNewTimelineForCPG");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableUseNewTimelineForCPG_Offset), 0, EnableUseNewTimelineForCPG_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableUseNewTimelineForCPG_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableUseNewTimelineForCPG");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableUseNewTimelineForCPG_Offset), 0, EnableUseNewTimelineForCPG_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Loading")]
	[DisplayName("Debug Play Go:")]
	[Tooltip("调试PlayGo")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayGo")]
	public bool DebugPlayGo
	{
		get
		{
			CheckDestroyed();
			if (!DebugPlayGo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayGo");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugPlayGo_Offset), 0, DebugPlayGo_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugPlayGo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayGo");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugPlayGo_Offset), 0, DebugPlayGo_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Autotest")]
	[DisplayName("Enable PlaneMove Mode:")]
	[Tooltip("是否开启PlaneMove模式")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnablePlaneMoveMode")]
	public bool EnablePlaneMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!EnablePlaneMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnablePlaneMoveMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePlaneMoveMode_Offset), 0, EnablePlaneMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePlaneMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnablePlaneMoveMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePlaneMoveMode_Offset), 0, EnablePlaneMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("测试新手指引信息")]
	[DisplayName("打开新手指引信息:")]
	[Category("Player Guide")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerGuide")]
	public bool DebugPlayerGuide
	{
		get
		{
			CheckDestroyed();
			if (!DebugPlayerGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerGuide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugPlayerGuide_Offset), 0, DebugPlayerGuide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugPlayerGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugPlayerGuide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugPlayerGuide_Offset), 0, DebugPlayerGuide_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("打开新周目新手教学:")]
	[Tooltip("打开新周目新手教学")]
	[Category("Player Guide")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugNewGamePlusGuide")]
	public bool DebugNewGamePlusGuide
	{
		get
		{
			CheckDestroyed();
			if (!DebugNewGamePlusGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugNewGamePlusGuide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugNewGamePlusGuide_Offset), 0, DebugNewGamePlusGuide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugNewGamePlusGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugNewGamePlusGuide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugNewGamePlusGuide_Offset), 0, DebugNewGamePlusGuide_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Player Guide")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("打开BossRush教学:")]
	[Tooltip("打开BossRush新手教学")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugBossRushGuide")]
	public bool DebugBossRushGuide
	{
		get
		{
			CheckDestroyed();
			if (!DebugBossRushGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugBossRushGuide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugBossRushGuide_Offset), 0, DebugBossRushGuide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugBossRushGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugBossRushGuide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugBossRushGuide_Offset), 0, DebugBossRushGuide_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("打开Map新手教学")]
	[DisplayName("打开Map教学:")]
	[Category("Player Guide")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugMapGuide")]
	public bool DebugMapGuide
	{
		get
		{
			CheckDestroyed();
			if (!DebugMapGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugMapGuide");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugMapGuide_Offset), 0, DebugMapGuide_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugMapGuide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugMapGuide");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugMapGuide_Offset), 0, DebugMapGuide_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Audio")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("启用环形子弹Debug")]
	[DisplayName("启用环形子弹Debug:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugDonutAudio")]
	public bool DebugDonutAudio
	{
		get
		{
			CheckDestroyed();
			if (!DebugDonutAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugDonutAudio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugDonutAudio_Offset), 0, DebugDonutAudio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugDonutAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugDonutAudio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugDonutAudio_Offset), 0, DebugDonutAudio_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("OverSeaChannel:")]
	[Category("DebugConfig")]
	[Tooltip("OverSeaChannel")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:IsOverSeaChannel")]
	public bool IsOverSeaChannel
	{
		get
		{
			CheckDestroyed();
			if (!IsOverSeaChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOverSeaChannel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsOverSeaChannel_Offset), 0, IsOverSeaChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsOverSeaChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:IsOverSeaChannel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsOverSeaChannel_Offset), 0, IsOverSeaChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("EnableEncrypt:")]
	[Tooltip("EnableEncrypt")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableEncrypt")]
	public bool EnableEncrypt
	{
		get
		{
			CheckDestroyed();
			if (!EnableEncrypt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableEncrypt");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableEncrypt_Offset), 0, EnableEncrypt_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableEncrypt_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableEncrypt");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableEncrypt_Offset), 0, EnableEncrypt_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("SettingHostSimulation:")]
	[Tooltip("模拟设置在主机上的表现")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SettingHostSimulation")]
	public bool SettingHostSimulation
	{
		get
		{
			CheckDestroyed();
			if (!SettingHostSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SettingHostSimulation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SettingHostSimulation_Offset), 0, SettingHostSimulation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SettingHostSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SettingHostSimulation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SettingHostSimulation_Offset), 0, SettingHostSimulation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("SettingEditorSimulation:")]
	[Tooltip("Editor模拟设置在Build的表现")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SettingEditorSimulation")]
	public bool SettingEditorSimulation
	{
		get
		{
			CheckDestroyed();
			if (!SettingEditorSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SettingEditorSimulation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SettingEditorSimulation_Offset), 0, SettingEditorSimulation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SettingEditorSimulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SettingEditorSimulation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SettingEditorSimulation_Offset), 0, SettingEditorSimulation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("DevArchiveSizeCheck:")]
	[Tooltip("存档大小检查开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeCheck")]
	public bool DevArchiveSizeCheck
	{
		get
		{
			CheckDestroyed();
			if (!DevArchiveSizeCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DevArchiveSizeCheck_Offset), 0, DevArchiveSizeCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DevArchiveSizeCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DevArchiveSizeCheck_Offset), 0, DevArchiveSizeCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("DisableDissolveDisplay:")]
	[Tooltip("关闭死亡消散效果")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DisableDissolveDisplay")]
	public bool DisableDissolveDisplay
	{
		get
		{
			CheckDestroyed();
			if (!DisableDissolveDisplay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableDissolveDisplay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableDissolveDisplay_Offset), 0, DisableDissolveDisplay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableDissolveDisplay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DisableDissolveDisplay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableDissolveDisplay_Offset), 0, DisableDissolveDisplay_PropertyAddress.Address, value);
			}
		}
	}

	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("ExceptionShowBtn:")]
	[Tooltip("报错UI是否显示 Btn")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ExceptionShowBtn")]
	public bool ExceptionShowBtn
	{
		get
		{
			CheckDestroyed();
			if (!ExceptionShowBtn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ExceptionShowBtn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExceptionShowBtn_Offset), 0, ExceptionShowBtn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExceptionShowBtn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ExceptionShowBtn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExceptionShowBtn_Offset), 0, ExceptionShowBtn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[DisplayName("ThrowException:")]
	[Tooltip("Cache Exception 后抛出异常")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ThrowException")]
	public bool ThrowException
	{
		get
		{
			CheckDestroyed();
			if (!ThrowException_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ThrowException");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ThrowException_Offset), 0, ThrowException_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ThrowException_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ThrowException");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ThrowException_Offset), 0, ThrowException_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("DebugSettingCvar:")]
	[Tooltip("SettingCvar开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingCvar")]
	public bool DebugSettingCvar
	{
		get
		{
			CheckDestroyed();
			if (!DebugSettingCvar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingCvar");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugSettingCvar_Offset), 0, DebugSettingCvar_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugSettingCvar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugSettingCvar");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugSettingCvar_Offset), 0, DebugSettingCvar_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("DebugSettingCvar:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[Tooltip("初始化配置警告开关")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugReInitRoleCheck")]
	public bool DebugReInitRoleCheck
	{
		get
		{
			CheckDestroyed();
			if (!DebugReInitRoleCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugReInitRoleCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugReInitRoleCheck_Offset), 0, DebugReInitRoleCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugReInitRoleCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugReInitRoleCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugReInitRoleCheck_Offset), 0, DebugReInitRoleCheck_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("采集物测试GM")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[DisplayName("采集物测试GM:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugCollection")]
	public bool DebugCollection
	{
		get
		{
			CheckDestroyed();
			if (!DebugCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugCollection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DebugCollection_Offset), 0, DebugCollection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DebugCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugCollection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DebugCollection_Offset), 0, DebugCollection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("Button参数同步配置:")]
	[Tooltip("Button参数同步配置")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ButtonMatSyncCheck")]
	public bool ButtonMatSyncCheck
	{
		get
		{
			CheckDestroyed();
			if (!ButtonMatSyncCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ButtonMatSyncCheck");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ButtonMatSyncCheck_Offset), 0, ButtonMatSyncCheck_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ButtonMatSyncCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ButtonMatSyncCheck");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ButtonMatSyncCheck_Offset), 0, ButtonMatSyncCheck_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[DisplayName("是否开启前尘影视:")]
	[Tooltip("是否开启前尘影视")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenPastMemory")]
	public bool OpenPastMemory
	{
		get
		{
			CheckDestroyed();
			if (!OpenPastMemory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenPastMemory");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenPastMemory_Offset), 0, OpenPastMemory_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenPastMemory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenPastMemory");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenPastMemory_Offset), 0, OpenPastMemory_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("是否开启查看材料:")]
	[Tooltip("是否开启查看材料")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenSimpleTips")]
	public bool OpenSimpleTips
	{
		get
		{
			CheckDestroyed();
			if (!OpenSimpleTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSimpleTips");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenSimpleTips_Offset), 0, OpenSimpleTips_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenSimpleTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenSimpleTips");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenSimpleTips_Offset), 0, OpenSimpleTips_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Editor下开启本地化:")]
	[Category("Localization")]
	[EditAnywhere]
	[Tooltip("Editor下开启本地化")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:OpenLocalizationInEditor")]
	public bool OpenLocalizationInEditor
	{
		get
		{
			CheckDestroyed();
			if (!OpenLocalizationInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenLocalizationInEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OpenLocalizationInEditor_Offset), 0, OpenLocalizationInEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OpenLocalizationInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:OpenLocalizationInEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OpenLocalizationInEditor_Offset), 0, OpenLocalizationInEditor_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Input")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("是否开启 Enhanced Input 输入延时:")]
	[Tooltip("是否开启 Enhanced Input 输入延时")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableEnhancedInputDelay")]
	public bool EnableEnhancedInputDelay
	{
		get
		{
			CheckDestroyed();
			if (!EnableEnhancedInputDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableEnhancedInputDelay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableEnhancedInputDelay_Offset), 0, EnableEnhancedInputDelay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableEnhancedInputDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableEnhancedInputDelay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableEnhancedInputDelay_Offset), 0, EnableEnhancedInputDelay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("EndingCreditsUseJson:")]
	[Tooltip("EndingCredits数据使用Json")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EndingCreditsUseJson")]
	public bool EndingCreditsUseJson
	{
		get
		{
			CheckDestroyed();
			if (!EndingCreditsUseJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EndingCreditsUseJson");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EndingCreditsUseJson_Offset), 0, EndingCreditsUseJson_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EndingCreditsUseJson_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EndingCreditsUseJson");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EndingCreditsUseJson_Offset), 0, EndingCreditsUseJson_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("隐藏MiniGM剧情页签")]
	[DisplayName("隐藏MiniGM剧情页签:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:HideMiniGMSequenceTab")]
	public bool HideMiniGMSequenceTab
	{
		get
		{
			CheckDestroyed();
			if (!HideMiniGMSequenceTab_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideMiniGMSequenceTab");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HideMiniGMSequenceTab_Offset), 0, HideMiniGMSequenceTab_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HideMiniGMSequenceTab_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideMiniGMSequenceTab");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HideMiniGMSequenceTab_Offset), 0, HideMiniGMSequenceTab_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("是否启用BinkMediaPlayer:")]
	[Tooltip("是否启用BinkMediaPlayer")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSWithBink")]
	public bool GSWithBink
	{
		get
		{
			CheckDestroyed();
			if (!GSWithBink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSWithBink");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSWithBink_Offset), 0, GSWithBink_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSWithBink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSWithBink");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSWithBink_Offset), 0, GSWithBink_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("BenchMark包标记(待替换):")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkOnly")]
	public bool BenckMarkOnly
	{
		get
		{
			CheckDestroyed();
			if (!BenckMarkOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BenckMarkOnly_Offset), 0, BenckMarkOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BenckMarkOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BenckMarkOnly_Offset), 0, BenckMarkOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("BenchMark循环播放:")]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkLoop")]
	public bool BenckMarkLoop
	{
		get
		{
			CheckDestroyed();
			if (!BenckMarkLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BenckMarkLoop_Offset), 0, BenckMarkLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BenckMarkLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BenckMarkLoop_Offset), 0, BenckMarkLoop_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("DamageLogic:")]
	[Category("Abandon?")]
	[EditAnywhere]
	[Tooltip("没找到地方调用")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DamageLogic")]
	public bool DamageLogic
	{
		get
		{
			CheckDestroyed();
			if (!DamageLogic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DamageLogic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DamageLogic_Offset), 0, DamageLogic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DamageLogic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DamageLogic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DamageLogic_Offset), 0, DamageLogic_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Abandon?")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("DropItem:")]
	[Tooltip("没找到地方调用")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DropItem")]
	public bool DropItem
	{
		get
		{
			CheckDestroyed();
			if (!DropItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DropItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DropItem_Offset), 0, DropItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DropItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DropItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DropItem_Offset), 0, DropItem_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("没找到地方调用")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Abandon?")]
	[DisplayName("Secret:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Secret")]
	public bool Secret
	{
		get
		{
			CheckDestroyed();
			if (!Secret_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Secret");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Secret_Offset), 0, Secret_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Secret_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Secret");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Secret_Offset), 0, Secret_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("没找到地方调用")]
	[DisplayName("EntitySharedRefLeakDetect:")]
	[Category("Abandon?")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EntitySharedRefLeakDetect")]
	public bool EntitySharedRefLeakDetect
	{
		get
		{
			CheckDestroyed();
			if (!EntitySharedRefLeakDetect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EntitySharedRefLeakDetect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EntitySharedRefLeakDetect_Offset), 0, EntitySharedRefLeakDetect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EntitySharedRefLeakDetect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EntitySharedRefLeakDetect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EntitySharedRefLeakDetect_Offset), 0, EntitySharedRefLeakDetect_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("TaskGroup")]
	[DisplayName("TaskGroup:")]
	[Category("Abandon?")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:TaskGroup")]
	public bool TaskGroup
	{
		get
		{
			CheckDestroyed();
			if (!TaskGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TaskGroup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TaskGroup_Offset), 0, TaskGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TaskGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:TaskGroup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TaskGroup_Offset), 0, TaskGroup_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("NPC")]
	[EditAnywhere]
	[Category("Abandon?")]
	[DisplayName("NPC:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:NPC")]
	public bool NPC
	{
		get
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NPC");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NPC_Offset), 0, NPC_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NPC");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NPC_Offset), 0, NPC_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("ActiveManageUI:")]
	[Category("Abandon?")]
	[EditAnywhere]
	[Tooltip("ActiveManageUI")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ActiveManageUI")]
	public bool ActiveManageUI
	{
		get
		{
			CheckDestroyed();
			if (!ActiveManageUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ActiveManageUI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ActiveManageUI_Offset), 0, ActiveManageUI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActiveManageUI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ActiveManageUI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ActiveManageUI_Offset), 0, ActiveManageUI_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("GymModeInWindows")]
	[Category("LocalDev")]
	[DisplayName("GymModeInWindows:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GymModeInWindows")]
	public bool GymModeInWindows
	{
		get
		{
			CheckDestroyed();
			if (!GymModeInWindows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GymModeInWindows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GymModeInWindows_Offset), 0, GymModeInWindows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GymModeInWindows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GymModeInWindows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GymModeInWindows_Offset), 0, GymModeInWindows_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("GSSdk Enable CETesting:")]
	[EditAnywhere]
	[Tooltip("开启CETesting")]
	[Category("LocalDev")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableCETesting")]
	public bool GSSdkEnableCETesting
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkEnableCETesting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableCETesting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkEnableCETesting_Offset), 0, GSSdkEnableCETesting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkEnableCETesting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableCETesting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkEnableCETesting_Offset), 0, GSSdkEnableCETesting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("Security KAUseTcp:")]
	[EditAnywhere]
	[Category("DevSecurity")]
	[Tooltip("开发相关的安全协议")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:KAServerUseTcp")]
	public bool KAServerUseTcp
	{
		get
		{
			CheckDestroyed();
			if (!KAServerUseTcp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerUseTcp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KAServerUseTcp_Offset), 0, KAServerUseTcp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KAServerUseTcp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerUseTcp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KAServerUseTcp_Offset), 0, KAServerUseTcp_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GamesciLogin")]
	[EditAnywhere]
	[DisplayName("NeedLauncher:")]
	[Tooltip("是否必须使用Gamesci 登陆器登录")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:NeedLauncher")]
	public bool NeedLauncher
	{
		get
		{
			CheckDestroyed();
			if (!NeedLauncher_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NeedLauncher");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedLauncher_Offset), 0, NeedLauncher_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedLauncher_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:NeedLauncher");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedLauncher_Offset), 0, NeedLauncher_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Production")]
	[DisplayName("HideCrashReportClientUi:")]
	[Tooltip("隐藏CRC UI")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:HideCrashReportClientUi")]
	public bool HideCrashReportClientUi
	{
		get
		{
			CheckDestroyed();
			if (!HideCrashReportClientUi_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideCrashReportClientUi");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HideCrashReportClientUi_Offset), 0, HideCrashReportClientUi_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HideCrashReportClientUi_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideCrashReportClientUi");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HideCrashReportClientUi_Offset), 0, HideCrashReportClientUi_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("GSSdk 的上报队列使用CSharp的HTTP(IL2CPP不支持HTTPS)")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("GSSdk ReportQueue Using Charp Http:")]
	[Category("GSSdk")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseCSharpHttp")]
	public bool GSSdkReportUseCSharpHttp
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportUseCSharpHttp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseCSharpHttp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkReportUseCSharpHttp_Offset), 0, GSSdkReportUseCSharpHttp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportUseCSharpHttp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseCSharpHttp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkReportUseCSharpHttp_Offset), 0, GSSdkReportUseCSharpHttp_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("GSSdk 的上报队列使用UE HTTP 异步模式,不关心失败返回值,只上报不关心返回值")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Using Async Http Unsafe Mode:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseAsyncHttp")]
	public bool GSSdkReportUseAsyncHttp
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportUseAsyncHttp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseAsyncHttp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkReportUseAsyncHttp_Offset), 0, GSSdkReportUseAsyncHttp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportUseAsyncHttp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportUseAsyncHttp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkReportUseAsyncHttp_Offset), 0, GSSdkReportUseAsyncHttp_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("GSSdk 的上报支持开关")]
	[DisplayName("GSSdk ReportQueue Enable:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("GSSdk")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportEnable")]
	public bool GSSdkReportEnable
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkReportEnable_Offset), 0, GSSdkReportEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkReportEnable_Offset), 0, GSSdkReportEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk Report Queue Disable HTTP:")]
	[Tooltip("GSSdk DISABLE HTTP REPORT")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportDisableHttpRequest")]
	public bool GSSdkReportDisableHttpRequest
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportDisableHttpRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportDisableHttpRequest");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkReportDisableHttpRequest_Offset), 0, GSSdkReportDisableHttpRequest_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportDisableHttpRequest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportDisableHttpRequest");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkReportDisableHttpRequest_Offset), 0, GSSdkReportDisableHttpRequest_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk Report Enable Data Clean:")]
	[Tooltip("GSSdk Enable Data Clean")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableSensDataClean")]
	public bool GSSdkEnableSensDataClean
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkEnableSensDataClean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableSensDataClean");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkEnableSensDataClean_Offset), 0, GSSdkEnableSensDataClean_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkEnableSensDataClean_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableSensDataClean");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkEnableSensDataClean_Offset), 0, GSSdkEnableSensDataClean_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("GSSdk Enable 启用监控指标")]
	[DisplayName("GSSdk Report Enable Monitor:")]
	[Category("GSSdk")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableMonitor")]
	public bool GSSdkEnableMonitor
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkEnableMonitor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableMonitor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkEnableMonitor_Offset), 0, GSSdkEnableMonitor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkEnableMonitor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnableMonitor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkEnableMonitor_Offset), 0, GSSdkEnableMonitor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("GSSdk Report Enable Perf:")]
	[Tooltip("GSSdk Enable 性能分析")]
	[Category("GSSdk")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnablePerf")]
	public bool GSSdkEnablePerf
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkEnablePerf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnablePerf");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkEnablePerf_Offset), 0, GSSdkEnablePerf_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkEnablePerf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnablePerf");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkEnablePerf_Offset), 0, GSSdkEnablePerf_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Sentry")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("Sentry DebugMode")]
	[DisplayName("Sentry Prod DebugMode:")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryDebug")]
	public bool SentryDebug
	{
		get
		{
			CheckDestroyed();
			if (!SentryDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SentryDebug_Offset), 0, SentryDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SentryDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SentryDebug_Offset), 0, SentryDebug_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("Sentry Bui Enable")]
	[DisplayName("Sentry Bui Enable options:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Sentry")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryEnable")]
	public bool SentryEnable
	{
		get
		{
			CheckDestroyed();
			if (!SentryEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SentryEnable_Offset), 0, SentryEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SentryEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SentryEnable_Offset), 0, SentryEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Sentry")]
	[DisplayName("Sentry EnableTracing options:")]
	[Tooltip("Sentry EnableTracing")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryEnableTracing")]
	public bool SentryEnableTracing
	{
		get
		{
			CheckDestroyed();
			if (!SentryEnableTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryEnableTracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SentryEnableTracing_Offset), 0, SentryEnableTracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SentryEnableTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryEnableTracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SentryEnableTracing_Offset), 0, SentryEnableTracing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Sentry")]
	[DisplayName("Sentry CaptureFailRequests options:")]
	[Tooltip("Sentry CaptureFailRequests")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryCaptureFailRequests")]
	public bool SentryCaptureFailRequests
	{
		get
		{
			CheckDestroyed();
			if (!SentryCaptureFailRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryCaptureFailRequests");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SentryCaptureFailRequests_Offset), 0, SentryCaptureFailRequests_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SentryCaptureFailRequests_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryCaptureFailRequests");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SentryCaptureFailRequests_Offset), 0, SentryCaptureFailRequests_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Sentry Use Local File Cache:")]
	[Tooltip("Sentry Use LocalCacheFile")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Sentry")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryUseLocalCacheFile")]
	public bool SentryUseLocalCacheFile
	{
		get
		{
			CheckDestroyed();
			if (!SentryUseLocalCacheFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryUseLocalCacheFile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SentryUseLocalCacheFile_Offset), 0, SentryUseLocalCacheFile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SentryUseLocalCacheFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryUseLocalCacheFile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SentryUseLocalCacheFile_Offset), 0, SentryUseLocalCacheFile_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("PlatformEventSendIntervalMilliSecond:")]
	[Tooltip("PlatformEventSendIntervalMilliSecond")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventSendIntervalMilliSecond")]
	public int PlatformEventSendIntervalMilliSecond
	{
		get
		{
			CheckDestroyed();
			if (!PlatformEventSendIntervalMilliSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventSendIntervalMilliSecond");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlatformEventSendIntervalMilliSecond_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlatformEventSendIntervalMilliSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventSendIntervalMilliSecond");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlatformEventSendIntervalMilliSecond_Offset), value);
			}
		}
	}

	[DisplayName("PlatformEventTimeoutMilliSecond:")]
	[Tooltip("PlatformEventTimeoutMilliSecond")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventTimeoutMilliSecond")]
	public int PlatformEventTimeoutMilliSecond
	{
		get
		{
			CheckDestroyed();
			if (!PlatformEventTimeoutMilliSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventTimeoutMilliSecond");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlatformEventTimeoutMilliSecond_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlatformEventTimeoutMilliSecond_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlatformEventTimeoutMilliSecond");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlatformEventTimeoutMilliSecond_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("PlayerLogMaxSize")]
	[DisplayName("PlayerLogMaxSize:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:PlayerLogMaxSize")]
	public int PlayerLogMaxSize
	{
		get
		{
			CheckDestroyed();
			if (!PlayerLogMaxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlayerLogMaxSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayerLogMaxSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerLogMaxSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:PlayerLogMaxSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayerLogMaxSize_Offset), value);
			}
		}
	}

	[DisplayName("ReportTimeout:")]
	[EditAnywhere]
	[Tooltip("ReportTimeout")]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ReportTimeout")]
	public int ReportTimeout
	{
		get
		{
			CheckDestroyed();
			if (!ReportTimeout_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ReportTimeout");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReportTimeout_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReportTimeout_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ReportTimeout");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReportTimeout_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("UseDebugTamerConfig")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[DisplayName("UseDebugTamerConfig:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:UseDebugTamerConfig")]
	public int UseDebugTamerConfig
	{
		get
		{
			CheckDestroyed();
			if (!UseDebugTamerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UseDebugTamerConfig");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UseDebugTamerConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseDebugTamerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UseDebugTamerConfig");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UseDebugTamerConfig_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("UIConfig")]
	[DisplayName("HideLockTarget:")]
	[Tooltip("隐藏白点")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:HideLockTarget")]
	public int HideLockTarget
	{
		get
		{
			CheckDestroyed();
			if (!HideLockTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideLockTarget");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HideLockTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HideLockTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:HideLockTarget");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HideLockTarget_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("EventWarningLevel")]
	[DisplayName("EventWarningLevel:")]
	[Category("OnlineDebug")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EventWarningLevel")]
	public int EventWarningLevel
	{
		get
		{
			CheckDestroyed();
			if (!EventWarningLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EventWarningLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventWarningLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventWarningLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EventWarningLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventWarningLevel_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("调试用联机关卡ID：3620")]
	[DisplayName("DebugOnlineLevelId:")]
	[Category("OnlineDebug")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugOnlineLevelId")]
	public int DebugOnlineLevelId
	{
		get
		{
			CheckDestroyed();
			if (!DebugOnlineLevelId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugOnlineLevelId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DebugOnlineLevelId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugOnlineLevelId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugOnlineLevelId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DebugOnlineLevelId_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("DebugUI")]
	[DisplayName("UITickProfileLevel:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:UITickProfileLevel")]
	public int UITickProfileLevel
	{
		get
		{
			CheckDestroyed();
			if (!UITickProfileLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UITickProfileLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UITickProfileLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UITickProfileLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UITickProfileLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UITickProfileLevel_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugBattle")]
	[DisplayName("CollectionForceType:")]
	[Tooltip("采集怪强制出生")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CollectionForceType")]
	public int CollectionForceType
	{
		get
		{
			CheckDestroyed();
			if (!CollectionForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CollectionForceType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CollectionForceType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollectionForceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CollectionForceType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CollectionForceType_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugBattle")]
	[DisplayName("LockDesiredPlayerHP:")]
	[Tooltip("锁定血量期望")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:LockDesiredPlayerHP")]
	public int LockDesiredPlayerHP
	{
		get
		{
			CheckDestroyed();
			if (!LockDesiredPlayerHP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LockDesiredPlayerHP");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LockDesiredPlayerHP_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockDesiredPlayerHP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LockDesiredPlayerHP");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LockDesiredPlayerHP_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Function")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("FSR防崩开关")]
	[DisplayName("FSRCrashOptions:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:FSRCrashOptions")]
	public int FSRCrashOptions
	{
		get
		{
			CheckDestroyed();
			if (!FSRCrashOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FSRCrashOptions");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FSRCrashOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FSRCrashOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FSRCrashOptions");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FSRCrashOptions_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("最大游玩次数")]
	[Category("Function")]
	[DisplayName("Demo820QuitGameCountMax:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Demo820PlayCountMax")]
	public int Demo820PlayCountMax
	{
		get
		{
			CheckDestroyed();
			if (!Demo820PlayCountMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820PlayCountMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Demo820PlayCountMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Demo820PlayCountMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Demo820PlayCountMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Demo820PlayCountMax_Offset), value);
			}
		}
	}

	[Tooltip("蛐蛐模式类型")]
	[DisplayName("CricketBattleModeType:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("Function")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleModeType")]
	public int CricketBattleModeType
	{
		get
		{
			CheckDestroyed();
			if (!CricketBattleModeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleModeType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CricketBattleModeType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CricketBattleModeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CricketBattleModeType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CricketBattleModeType_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("loading超过这个时间上报")]
	[DisplayName("Loading Max Time:")]
	[Category("Loading")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTime")]
	public int LoadingMaxTime
	{
		get
		{
			CheckDestroyed();
			if (!LoadingMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LoadingMaxTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoadingMaxTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LoadingMaxTime_Offset), value);
			}
		}
	}

	[Tooltip("loading超过这个事件弹出Tips")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("Loading Max Time:")]
	[EditAnywhere]
	[Category("Loading")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTimeShowTips")]
	public int LoadingMaxTimeShowTips
	{
		get
		{
			CheckDestroyed();
			if (!LoadingMaxTimeShowTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTimeShowTips");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LoadingMaxTimeShowTips_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoadingMaxTimeShowTips_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:LoadingMaxTimeShowTips");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LoadingMaxTimeShowTips_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Sentry")]
	[DisplayName("Ensure Report Interval:")]
	[Tooltip("Sentry Ensure 的上报间隔")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnsureReportInterval")]
	public int EnsureReportInterval
	{
		get
		{
			CheckDestroyed();
			if (!EnsureReportInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnsureReportInterval");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnsureReportInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnsureReportInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnsureReportInterval");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnsureReportInterval_Offset), value);
			}
		}
	}

	[DisplayName("DevArchiveSizeMax:")]
	[Tooltip("Dev存档大小最大值")]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeMax")]
	public int DevArchiveSizeMax
	{
		get
		{
			CheckDestroyed();
			if (!DevArchiveSizeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeMax");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DevArchiveSizeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DevArchiveSizeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevArchiveSizeMax");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DevArchiveSizeMax_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[Tooltip("调试用国内外开关")]
	[DisplayName("DebugOverSeaType:")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugOverSeaType")]
	public int DebugOverSeaType
	{
		get
		{
			CheckDestroyed();
			if (!DebugOverSeaType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugOverSeaType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DebugOverSeaType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugOverSeaType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugOverSeaType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DebugOverSeaType_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("WaitMSToThrowException:")]
	[Tooltip("等待多少毫秒抛出异常")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:WaitMSToThrowException")]
	public int WaitMSToThrowException
	{
		get
		{
			CheckDestroyed();
			if (!WaitMSToThrowException_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:WaitMSToThrowException");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WaitMSToThrowException_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaitMSToThrowException_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:WaitMSToThrowException");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WaitMSToThrowException_Offset), value);
			}
		}
	}

	[Tooltip("上报Sentry UserConfig频率")]
	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("上报Sentry UserConfig频率:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:UpdateUserConfigInterval")]
	public int UpdateUserConfigInterval
	{
		get
		{
			CheckDestroyed();
			if (!UpdateUserConfigInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UpdateUserConfigInterval");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UpdateUserConfigInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdateUserConfigInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:UpdateUserConfigInterval");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UpdateUserConfigInterval_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("多周目测试:")]
	[Tooltip("多周目测试")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugGameCount")]
	public int DebugGameCount
	{
		get
		{
			CheckDestroyed();
			if (!DebugGameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGameCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DebugGameCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugGameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugGameCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DebugGameCount_Offset), value);
			}
		}
	}

	[Tooltip("0:AutoSizeScrollBox 1:TileView")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("武器锻造列表模式:")]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:WeaponBuildMode")]
	public int WeaponBuildMode
	{
		get
		{
			CheckDestroyed();
			if (!WeaponBuildMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:WeaponBuildMode");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponBuildMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponBuildMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:WeaponBuildMode");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponBuildMode_Offset), value);
			}
		}
	}

	[Tooltip("输入延时（ms）")]
	[DisplayName("输入延时（ms）:")]
	[Category("Input")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputDelayTime")]
	public int EnhancedInputDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!EnhancedInputDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputDelayTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnhancedInputDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnhancedInputDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnhancedInputDelayTime_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Input")]
	[DisplayName("特殊输入延时（ms）:")]
	[Tooltip("特殊输入延时（ms）")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputSpecialDelayTime")]
	public int EnhancedInputSpecialDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!EnhancedInputSpecialDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputSpecialDelayTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnhancedInputSpecialDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnhancedInputSpecialDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnhancedInputSpecialDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnhancedInputSpecialDelayTime_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("MediaPlayerSyncToleranceMS:")]
	[Tooltip("媒体播放器系统时钟同步容差(ms)")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncToleranceMS")]
	public int MediaPlayerSyncToleranceMS
	{
		get
		{
			CheckDestroyed();
			if (!MediaPlayerSyncToleranceMS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncToleranceMS");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaPlayerSyncToleranceMS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaPlayerSyncToleranceMS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncToleranceMS");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaPlayerSyncToleranceMS_Offset), value);
			}
		}
	}

	[Category("DebugConfig")]
	[DisplayName("MediaPlayerSyncCDMS:")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Tooltip("媒体播放器系统时钟同步CD(ms)")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncCDMS")]
	public int MediaPlayerSyncCDMS
	{
		get
		{
			CheckDestroyed();
			if (!MediaPlayerSyncCDMS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncCDMS");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaPlayerSyncCDMS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaPlayerSyncCDMS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MediaPlayerSyncCDMS");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaPlayerSyncCDMS_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[DisplayName("BenchMark低GPU占用(百分比):")]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkGPULow")]
	public int BenckMarkGPULow
	{
		get
		{
			CheckDestroyed();
			if (!BenckMarkGPULow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkGPULow");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BenckMarkGPULow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BenckMarkGPULow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:BenckMarkGPULow");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BenckMarkGPULow_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("ForceEnableDebugGMFlags:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("LocalDev")]
	[Tooltip("强制开启DebugGM的标志位;可参考:GMFlag")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:ForceEnableDebugGMFlags")]
	public int ForceEnableDebugGMFlags
	{
		get
		{
			CheckDestroyed();
			if (!ForceEnableDebugGMFlags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ForceEnableDebugGMFlags");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForceEnableDebugGMFlags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceEnableDebugGMFlags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:ForceEnableDebugGMFlags");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForceEnableDebugGMFlags_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DevSecurity")]
	[DisplayName("Security KAServerPort List:")]
	[Tooltip("开发相关的安全端口")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:KAServerPort")]
	public int KAServerPort
	{
		get
		{
			CheckDestroyed();
			if (!KAServerPort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerPort");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, KAServerPort_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KAServerPort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerPort");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, KAServerPort_Offset), value);
			}
		}
	}

	[Tooltip("GSSdk 的上报合批数量")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Merge Event Num:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchEventNum")]
	public int GSSdkReportMergeBatchEventNum
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportMergeBatchEventNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchEventNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GSSdkReportMergeBatchEventNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportMergeBatchEventNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchEventNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GSSdkReportMergeBatchEventNum_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Merge Event Interval Seconds:")]
	[Tooltip("GSSdk MERGE BATCH TIME INTERVAL")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchIntervalSeconds")]
	public int GSSdkReportMergeBatchIntervalSeconds
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkReportMergeBatchIntervalSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchIntervalSeconds");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GSSdkReportMergeBatchIntervalSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkReportMergeBatchIntervalSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkReportMergeBatchIntervalSeconds");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GSSdkReportMergeBatchIntervalSeconds_Offset), value);
			}
		}
	}

	[DisplayName("EnableAllGMCMDAndDebug:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("")]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:EnableAllGMCMDAndDebug")]
	public string EnableAllGMCMDAndDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableAllGMCMDAndDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableAllGMCMDAndDebug");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EnableAllGMCMDAndDebug_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnableAllGMCMDAndDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:EnableAllGMCMDAndDebug");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EnableAllGMCMDAndDebug_Offset), value);
			}
		}
	}

	[Tooltip("CESetRealBranchName")]
	[DisplayName("CESetRealBranchName:")]
	[Category("DebugConfig")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:CESetRealBranchName")]
	public string CESetRealBranchName
	{
		get
		{
			CheckDestroyed();
			if (!CESetRealBranchName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CESetRealBranchName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CESetRealBranchName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CESetRealBranchName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:CESetRealBranchName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CESetRealBranchName_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[Category("OnlineDebug")]
	[DisplayName("RoomServerConnectAddr:")]
	[Tooltip("覆盖默认的房间服务地址")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:RoomServerConnectAddr")]
	public string RoomServerConnectAddr
	{
		get
		{
			CheckDestroyed();
			if (!RoomServerConnectAddr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:RoomServerConnectAddr");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, RoomServerConnectAddr_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoomServerConnectAddr_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:RoomServerConnectAddr");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, RoomServerConnectAddr_Offset), value);
			}
		}
	}

	[Tooltip("DebugDrawTag(Seq、)")]
	[DisplayName("DebugDrawTag:")]
	[Category("DebugDrawUI")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugDrawTag")]
	public string DebugDrawTag
	{
		get
		{
			CheckDestroyed();
			if (!DebugDrawTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugDrawTag");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DebugDrawTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDrawTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugDrawTag");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DebugDrawTag_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AdditionalContent")]
	[DisplayName("B1豪华版AddOnId:")]
	[Tooltip("B1豪华版AddOnId")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:B1DeluxeAddOnId")]
	public string B1DeluxeAddOnId
	{
		get
		{
			CheckDestroyed();
			if (!B1DeluxeAddOnId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:B1DeluxeAddOnId");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, B1DeluxeAddOnId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B1DeluxeAddOnId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:B1DeluxeAddOnId");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, B1DeluxeAddOnId_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("AdditionalContent")]
	[DisplayName("B1预购AddOnId:")]
	[Tooltip("B1预购AddOnId")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:B1PrePurchaseAddOnId")]
	public string B1PrePurchaseAddOnId
	{
		get
		{
			CheckDestroyed();
			if (!B1PrePurchaseAddOnId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:B1PrePurchaseAddOnId");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, B1PrePurchaseAddOnId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B1PrePurchaseAddOnId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:B1PrePurchaseAddOnId");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, B1PrePurchaseAddOnId_Offset), value);
			}
		}
	}

	[DisplayName("FileIOStrategy:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DebugConfig")]
	[Tooltip("IOStrategy")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:FileIOStrategy")]
	public string FileIOStrategy
	{
		get
		{
			CheckDestroyed();
			if (!FileIOStrategy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FileIOStrategy");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileIOStrategy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileIOStrategy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FileIOStrategy");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileIOStrategy_Offset), value);
			}
		}
	}

	[Category("DebugConfig")]
	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("DebugRtxEnableLevel:")]
	[Tooltip("光追测试关卡")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DebugRtxEnableLevel")]
	public string DebugRtxEnableLevel
	{
		get
		{
			CheckDestroyed();
			if (!DebugRtxEnableLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugRtxEnableLevel");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DebugRtxEnableLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugRtxEnableLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DebugRtxEnableLevel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DebugRtxEnableLevel_Offset), value);
			}
		}
	}

	[DisplayName("常见问题与解答网站:")]
	[Tooltip("faq网站链接")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("DebugConfig")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:FAQWebsiteLink")]
	public string FAQWebsiteLink
	{
		get
		{
			CheckDestroyed();
			if (!FAQWebsiteLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FAQWebsiteLink");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FAQWebsiteLink_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FAQWebsiteLink_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FAQWebsiteLink");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FAQWebsiteLink_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("LocalDev")]
	[DisplayName("FileMd5Check Ignore Path:")]
	[Tooltip("FileMd5Check")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:FileMd5CheckIgnorePathPattern")]
	public string FileMd5CheckIgnorePathPattern
	{
		get
		{
			CheckDestroyed();
			if (!FileMd5CheckIgnorePathPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FileMd5CheckIgnorePathPattern");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileMd5CheckIgnorePathPattern_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileMd5CheckIgnorePathPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:FileMd5CheckIgnorePathPattern");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileMd5CheckIgnorePathPattern_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("开发相关的安全主机")]
	[Category("DevSecurity")]
	[DisplayName("Security KAServerHost:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:KAServerHost")]
	public string KAServerHost
	{
		get
		{
			CheckDestroyed();
			if (!KAServerHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerHost");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, KAServerHost_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KAServerHost_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAServerHost");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, KAServerHost_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("DevSecurity")]
	[DisplayName("Security KAExtraId:")]
	[Tooltip("开发相关的安全标识")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:KAExtraId")]
	public string KAExtraId
	{
		get
		{
			CheckDestroyed();
			if (!KAExtraId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAExtraId");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, KAExtraId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!KAExtraId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:KAExtraId");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, KAExtraId_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[DisplayName("GSSdk Gamesci LoginServerUrl:")]
	[Tooltip("GSSdk Gamesci 登陆服务器的地址")]
	[EditAnywhere]
	[Category("GamesciLogin")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:DevGamesciLoginServerUrl")]
	public string DevGamesciLoginServerUrl
	{
		get
		{
			CheckDestroyed();
			if (!DevGamesciLoginServerUrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevGamesciLoginServerUrl");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, DevGamesciLoginServerUrl_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DevGamesciLoginServerUrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:DevGamesciLoginServerUrl");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, DevGamesciLoginServerUrl_Offset), value);
			}
		}
	}

	[Category("Production")]
	[DisplayName("Environment:")]
	[EditAnywhere]
	[Tooltip("版本运行的环境配置(全小写),主要是:dev(表示开发环境),prod(表示生产环境,要发布的)")]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:Environment")]
	public string Environment
	{
		get
		{
			CheckDestroyed();
			if (!Environment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Environment");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Environment_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Environment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:Environment");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Environment_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk CDN Root Url list:")]
	[Tooltip("GSSdk的默认下载根服务器服务器地址列表,使用逗号(,)分隔,一般不用配置,只是开发特殊使用")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkCDNRootUrlList")]
	public string GSSdkCDNRootUrlList
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkCDNRootUrlList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkCDNRootUrlList");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkCDNRootUrlList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkCDNRootUrlList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkCDNRootUrlList");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkCDNRootUrlList_Offset), value);
			}
		}
	}

	[Tooltip("GSSdk的环境主机的地址,使用逗号(,)分隔")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk EnvServerUrlList:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnvServerUrlList")]
	public string GSSdkEnvServerUrlList
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkEnvServerUrlList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnvServerUrlList");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkEnvServerUrlList_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkEnvServerUrlList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkEnvServerUrlList");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkEnvServerUrlList_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk AppChannel:")]
	[Tooltip("包所在的发行渠道,gamesci,steam,wegame,epic,ps5,xsx")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkAppChannel")]
	public string GSSdkAppChannel
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkAppChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkAppChannel");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkAppChannel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkAppChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkAppChannel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkAppChannel_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk LoginChannel:")]
	[Tooltip("GSSdk使用的登录渠道,包括gamesci,steam,wegame,epic,psn,xbl")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginChannel")]
	public string GSSdkLoginChannel
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkLoginChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginChannel");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkLoginChannel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkLoginChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginChannel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkLoginChannel_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[Category("GSSdk")]
	[Tooltip("GSSdk使用的登录子渠道,一般不用")]
	[DisplayName("GSSdk LoginChannel:")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginSubChannel")]
	public string GSSdkLoginSubChannel
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkLoginSubChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginSubChannel");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkLoginSubChannel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkLoginSubChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkLoginSubChannel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkLoginSubChannel_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("GSSdk")]
	[DisplayName("GSSdk PackageTags:")]
	[Tooltip("GSSdk 包的扩展标记,使用,分隔")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:GSSdkPackageTags")]
	public string GSSdkPackageTags
	{
		get
		{
			CheckDestroyed();
			if (!GSSdkPackageTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkPackageTags");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, GSSdkPackageTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSSdkPackageTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:GSSdkPackageTags");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, GSSdkPackageTags_Offset), value);
			}
		}
	}

	[DisplayName("Sentry DSN:")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Tooltip("Sentry 的上报DSN")]
	[Category("Sentry")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryDSN")]
	public string SentryDSN
	{
		get
		{
			CheckDestroyed();
			if (!SentryDSN_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryDSN");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SentryDSN_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SentryDSN_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryDSN");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SentryDSN_Offset), value);
			}
		}
	}

	[Tooltip("Sentry 备用域名")]
	[DisplayName("Sentry 备用域名:")]
	[Category("Sentry")]
	[EditAnywhere]
	[UProperty((PropFlags)6755399441072641uL)]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentryHostBackup")]
	public string SentryHostBackup
	{
		get
		{
			CheckDestroyed();
			if (!SentryHostBackup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryHostBackup");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SentryHostBackup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SentryHostBackup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentryHostBackup");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SentryHostBackup_Offset), value);
			}
		}
	}

	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[Category("Sentry")]
	[DisplayName("Sentry Prod Sample Rate:")]
	[Tooltip("Sentry Sample Rate")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:SentrySampleRate")]
	public string SentrySampleRate
	{
		get
		{
			CheckDestroyed();
			if (!SentrySampleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentrySampleRate");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SentrySampleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SentrySampleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:SentrySampleRate");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SentrySampleRate_Offset), value);
			}
		}
	}

	[Category("Summer")]
	[UProperty((PropFlags)6755399441072641uL)]
	[EditAnywhere]
	[DisplayName("Summery Magic check:")]
	[Tooltip("Summer Magic check")]
	[USharpPath("/Script/b1-Managed.GSGameCoustomConfig:MagicCheckOverlay")]
	public string MagicCheckOverlay
	{
		get
		{
			CheckDestroyed();
			if (!MagicCheckOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MagicCheckOverlay");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, MagicCheckOverlay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MagicCheckOverlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSGameCoustomConfig:MagicCheckOverlay");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, MagicCheckOverlay_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public static void ReInitBySaveConfigInI()
	{
	}

	public static void SetProjectSettingConfigDefaultValue(GSGameCoustomConfig ProjectSettingConfig)
	{
		ProjectSettingConfig.ArchiveRefactor = false;
		ProjectSettingConfig.DebugWidget = false;
		ProjectSettingConfig.ILRuntime = true;
		ProjectSettingConfig.ILRuntimeJITOnDemand = false;
		ProjectSettingConfig.Clrbinding = false;
		ProjectSettingConfig.ILRuntimeDebugger = false;
		ProjectSettingConfig.EnableRtx = false;
		ProjectSettingConfig.Report820Windows = false;
		ProjectSettingConfig.ManualBuiGC = false;
		ProjectSettingConfig.Report820PS5 = false;
		ProjectSettingConfig.Report820XSX = false;
		ProjectSettingConfig.Report820WindowsRealtime = true;
		ProjectSettingConfig.ArchiveBackup = true;
		ProjectSettingConfig.OverridePlayerLogMaxSize = false;
		ProjectSettingConfig.DebugCFSMG = false;
		ProjectSettingConfig.SimTimeMarkBase = false;
		ProjectSettingConfig.SimTimeMarkStep = false;
		ProjectSettingConfig.Navigation = false;
		ProjectSettingConfig.Intimidation = false;
		ProjectSettingConfig.OpenSeparateFrameEntityBeginPlay = true;
		ProjectSettingConfig.InteractiveObj = false;
		ProjectSettingConfig.DrawSimpleOverlapDebug = false;
		ProjectSettingConfig.ProfilerSimpleOverlap = false;
		ProjectSettingConfig.TopdownBattleMode = false;
		ProjectSettingConfig.IsTmpTestFlag = false;
		ProjectSettingConfig.OpenNewChapterPlayerSafeLocation = true;
		ProjectSettingConfig.IsLiteBuild = false;
		ProjectSettingConfig.OpenGSRepLog = false;
		ProjectSettingConfig.ClientReset = true;
		ProjectSettingConfig.ProfileEnable = false;
		ProjectSettingConfig.Enablepreload = false;
		ProjectSettingConfig.CantCloseNetConnectWithError = false;
		ProjectSettingConfig.SkipRoleDataCheck = false;
		ProjectSettingConfig.EnableMoveSpeedInfoDebug = false;
		ProjectSettingConfig.EnablePrintJXSQCheckerResult = false;
		ProjectSettingConfig.EnableChapterRoamV2 = false;
		ProjectSettingConfig.ChapterDebug = false;
		ProjectSettingConfig.EnableShrineAllFunc = false;
		ProjectSettingConfig.EnableInteractAllFunc = false;
		ProjectSettingConfig.DisableSkipInteractFunc = false;
		ProjectSettingConfig.DisableSkipMontageInteractFunc = false;
		ProjectSettingConfig.SpawnWaveDebug = false;
		ProjectSettingConfig.BPNeutralAnimalDebug = false;
		ProjectSettingConfig.PureVersion = false;
		ProjectSettingConfig.PreOrderAwardDebug = false;
		ProjectSettingConfig.DeluxeAwardDebug = false;
		ProjectSettingConfig.DisableRpcLog = false;
		ProjectSettingConfig.ActiveAllUI = true;
		ProjectSettingConfig.Open1080Check = true;
		ProjectSettingConfig.GSDisableLoadingScreen = false;
		ProjectSettingConfig.OnlyOpenPVUI = false;
		ProjectSettingConfig.AdvanceDropManualClose = false;
		ProjectSettingConfig.InputDebugInfo = false;
		ProjectSettingConfig.InputDebug_Window = false;
		ProjectSettingConfig.InputDebug_KeyCache = false;
		ProjectSettingConfig.GroupAI = false;
		ProjectSettingConfig.AIInfo = false;
		ProjectSettingConfig.TeamInfo = false;
		ProjectSettingConfig.FollowPartnerDispInfo = false;
		ProjectSettingConfig.TargetInfo = false;
		ProjectSettingConfig.HatredInfo = false;
		ProjectSettingConfig.AINodeDebug = false;
		ProjectSettingConfig.ABPHelperInfo = false;
		ProjectSettingConfig.OnlineAttr = false;
		ProjectSettingConfig.OnlineUnitState = false;
		ProjectSettingConfig.IsDebugDS = false;
		ProjectSettingConfig.ConnectionInfo = true;
		ProjectSettingConfig.PlayerDebugDraw = false;
		ProjectSettingConfig.OpenNetConnectDebugUI = false;
		ProjectSettingConfig.DebugGSRepRole = false;
		ProjectSettingConfig.OpenEventDebugger = false;
		ProjectSettingConfig.IsDebugAKB = false;
		ProjectSettingConfig.IsDebugUISys = false;
		ProjectSettingConfig.IsDebugUIMore = false;
		ProjectSettingConfig.IsDebugUIProc = false;
		ProjectSettingConfig.IsDebugWidgetMore = false;
		ProjectSettingConfig.IsDebugButton = false;
		ProjectSettingConfig.IsDebugAutoSizeScrollBox = false;
		ProjectSettingConfig.IsDebugWidgetProfile = false;
		ProjectSettingConfig.IsDebugUITick = false;
		ProjectSettingConfig.IsOpenStatGSCustom = false;
		ProjectSettingConfig.IsShowDebugDrawUI = false;
		ProjectSettingConfig.DebugPhaseCSG = false;
		ProjectSettingConfig.IsOpenBattleInfoTool = false;
		ProjectSettingConfig.CancelSkillCD = false;
		ProjectSettingConfig.DebugMap = false;
		ProjectSettingConfig.ShowChrEnvMaskValue = false;
		ProjectSettingConfig.IsOpenRemoteTestCheat = false;
		ProjectSettingConfig.IsIgnoreValidateData = false;
		ProjectSettingConfig.EventMemoryLeakTest = false;
		ProjectSettingConfig.TickEventMemoryLeakTest = false;
		ProjectSettingConfig.ObjMemoryLeakTest = false;
		ProjectSettingConfig.MemoryLeakTestCacheObj = false;
		ProjectSettingConfig.DebugStartWithOutArchive = false;
		ProjectSettingConfig.EnableSelectChapter = false;
		ProjectSettingConfig.CanOptimizeTick = true;
		ProjectSettingConfig.Debug820Demo = false;
		ProjectSettingConfig.Demo820OverSeaVersion = false;
		ProjectSettingConfig.Demo820DebugTest = false;
		ProjectSettingConfig.Demo820UseSetting = false;
		ProjectSettingConfig.DebugFristStartGameSetting = false;
		ProjectSettingConfig.OpenSeamlessLevelTravel = true;
		ProjectSettingConfig.Demo820ExceptionUI = false;
		ProjectSettingConfig.Demo820IgnoreAllOverlap = false;
		ProjectSettingConfig.DebugPlayerTransLog = true;
		ProjectSettingConfig.CricketBattleMode = false;
		ProjectSettingConfig.CricketReportServer = false;
		ProjectSettingConfig.DebugSettingLog = false;
		ProjectSettingConfig.NeedGSSDKUserCheck = true;
		ProjectSettingConfig.DebugTransGuideUI = false;
		ProjectSettingConfig.LQALanguage = false;
		ProjectSettingConfig.GSIsGlobalColorDeficiency = true;
		ProjectSettingConfig.DebugGameIntent = false;
		ProjectSettingConfig.ShowLoadingTimeText = false;
		ProjectSettingConfig.IsNeedPsoPrecompileWhenStartGame = true;
		ProjectSettingConfig.IsNeedPreStartGameProcess = true;
		ProjectSettingConfig.DisableInputMessage = false;
		ProjectSettingConfig.EnableUseNewTimelineForCPG = true;
		ProjectSettingConfig.DebugPlayGo = false;
		ProjectSettingConfig.EnablePlaneMoveMode = false;
		ProjectSettingConfig.DebugPlayerGuide = false;
		ProjectSettingConfig.DebugNewGamePlusGuide = false;
		ProjectSettingConfig.DebugBossRushGuide = false;
		ProjectSettingConfig.DebugMapGuide = false;
		ProjectSettingConfig.DebugDonutAudio = false;
		ProjectSettingConfig.IsOverSeaChannel = true;
		ProjectSettingConfig.EnableEncrypt = true;
		ProjectSettingConfig.SettingHostSimulation = false;
		ProjectSettingConfig.SettingEditorSimulation = false;
		ProjectSettingConfig.DevArchiveSizeCheck = true;
		ProjectSettingConfig.DisableDissolveDisplay = false;
		ProjectSettingConfig.ExceptionShowBtn = true;
		ProjectSettingConfig.ThrowException = false;
		ProjectSettingConfig.DebugSettingCvar = false;
		ProjectSettingConfig.DebugReInitRoleCheck = true;
		ProjectSettingConfig.DebugCollection = false;
		ProjectSettingConfig.ButtonMatSyncCheck = true;
		ProjectSettingConfig.OpenPastMemory = true;
		ProjectSettingConfig.OpenSimpleTips = false;
		ProjectSettingConfig.OpenLocalizationInEditor = false;
		ProjectSettingConfig.EnableEnhancedInputDelay = true;
		ProjectSettingConfig.EndingCreditsUseJson = false;
		ProjectSettingConfig.HideMiniGMSequenceTab = true;
		ProjectSettingConfig.GSWithBink = true;
		ProjectSettingConfig.BenckMarkOnly = false;
		ProjectSettingConfig.BenckMarkLoop = false;
		ProjectSettingConfig.DamageLogic = false;
		ProjectSettingConfig.DropItem = false;
		ProjectSettingConfig.Secret = true;
		ProjectSettingConfig.EntitySharedRefLeakDetect = false;
		ProjectSettingConfig.TaskGroup = false;
		ProjectSettingConfig.NPC = false;
		ProjectSettingConfig.ActiveManageUI = true;
		ProjectSettingConfig.GymModeInWindows = false;
		ProjectSettingConfig.GSSdkEnableCETesting = false;
		ProjectSettingConfig.KAServerUseTcp = true;
		ProjectSettingConfig.NeedLauncher = false;
		ProjectSettingConfig.HideCrashReportClientUi = true;
		ProjectSettingConfig.GSSdkReportUseCSharpHttp = false;
		ProjectSettingConfig.GSSdkReportUseAsyncHttp = false;
		ProjectSettingConfig.GSSdkReportEnable = true;
		ProjectSettingConfig.GSSdkReportDisableHttpRequest = false;
		ProjectSettingConfig.GSSdkEnableSensDataClean = false;
		ProjectSettingConfig.GSSdkEnableMonitor = true;
		ProjectSettingConfig.GSSdkEnablePerf = true;
		ProjectSettingConfig.SentryDebug = false;
		ProjectSettingConfig.SentryEnable = true;
		ProjectSettingConfig.SentryEnableTracing = false;
		ProjectSettingConfig.SentryCaptureFailRequests = false;
		ProjectSettingConfig.SentryUseLocalCacheFile = false;
		ProjectSettingConfig.PlatformEventSendIntervalMilliSecond = 2000;
		ProjectSettingConfig.PlatformEventTimeoutMilliSecond = 60000;
		ProjectSettingConfig.PlayerLogMaxSize = 50;
		ProjectSettingConfig.ReportTimeout = 10;
		ProjectSettingConfig.UseDebugTamerConfig = 0;
		ProjectSettingConfig.HideLockTarget = 1;
		ProjectSettingConfig.EventWarningLevel = 0;
		ProjectSettingConfig.DebugOnlineLevelId = 0;
		ProjectSettingConfig.UITickProfileLevel = 0;
		ProjectSettingConfig.CollectionForceType = 0;
		ProjectSettingConfig.LockDesiredPlayerHP = 0;
		ProjectSettingConfig.FSRCrashOptions = 2;
		ProjectSettingConfig.Demo820PlayCountMax = 0;
		ProjectSettingConfig.CricketBattleModeType = 2;
		ProjectSettingConfig.LoadingMaxTime = 300;
		ProjectSettingConfig.LoadingMaxTimeShowTips = 180;
		ProjectSettingConfig.EnsureReportInterval = 60;
		ProjectSettingConfig.DevArchiveSizeMax = 5242880;
		ProjectSettingConfig.DebugOverSeaType = 0;
		ProjectSettingConfig.WaitMSToThrowException = 10000;
		ProjectSettingConfig.UpdateUserConfigInterval = 5;
		ProjectSettingConfig.DebugGameCount = 0;
		ProjectSettingConfig.WeaponBuildMode = 1;
		ProjectSettingConfig.EnhancedInputDelayTime = 30;
		ProjectSettingConfig.EnhancedInputSpecialDelayTime = 50;
		ProjectSettingConfig.MediaPlayerSyncToleranceMS = 500;
		ProjectSettingConfig.MediaPlayerSyncCDMS = 3000;
		ProjectSettingConfig.BenckMarkGPULow = 40;
		ProjectSettingConfig.ForceEnableDebugGMFlags = 0;
		ProjectSettingConfig.KAServerPort = 12800;
		ProjectSettingConfig.GSSdkReportMergeBatchEventNum = 300;
		ProjectSettingConfig.GSSdkReportMergeBatchIntervalSeconds = 60;
		ProjectSettingConfig.EnableAllGMCMDAndDebug = "b.WTF";
		ProjectSettingConfig.CESetRealBranchName = "";
		ProjectSettingConfig.RoomServerConnectAddr = "";
		ProjectSettingConfig.DebugDrawTag = "Seq,";
		ProjectSettingConfig.B1DeluxeAddOnId = "";
		ProjectSettingConfig.B1PrePurchaseAddOnId = "";
		ProjectSettingConfig.FileIOStrategy = "UGSFileHelper";
		ProjectSettingConfig.DebugRtxEnableLevel = "";
		ProjectSettingConfig.FAQWebsiteLink = "https://www.heishenhua.com/support";
		ProjectSettingConfig.FileMd5CheckIgnorePathPattern = "/Saved/,/Logs/,b1/Tools/";
		ProjectSettingConfig.KAServerHost = "gshb.b1.gamesci.com.cn";
		ProjectSettingConfig.KAExtraId = "";
		ProjectSettingConfig.DevGamesciLoginServerUrl = "http://gslogin.b1.gamesci.com.cn:19912";
		ProjectSettingConfig.Environment = "dev";
		ProjectSettingConfig.GSSdkCDNRootUrlList = "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1pbtable_cdn";
		ProjectSettingConfig.GSSdkEnvServerUrlList = "http://gssdk.b1.gamesci.com.cn:9812";
		ProjectSettingConfig.GSSdkAppChannel = "gamesci";
		ProjectSettingConfig.GSSdkLoginChannel = "gamesci";
		ProjectSettingConfig.GSSdkLoginSubChannel = "";
		ProjectSettingConfig.GSSdkPackageTags = "";
		ProjectSettingConfig.SentryDSN = "http://bdca0e842c6806e70e718e79641b3fbf@sentry.gs.com/6";
		ProjectSettingConfig.SentryHostBackup = "heishenhua.com:gamesci.com.cn";
		ProjectSettingConfig.SentrySampleRate = "1.0";
		ProjectSettingConfig.MagicCheckOverlay = "";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSGameCoustomConfig");
		NativeReflection.GetPropertyRef(ref ArchiveRefactor_PropertyAddress, unrealStruct, "ArchiveRefactor");
		ArchiveRefactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ArchiveRefactor");
		ArchiveRefactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ArchiveRefactor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugWidget_PropertyAddress, unrealStruct, "DebugWidget");
		DebugWidget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugWidget");
		DebugWidget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugWidget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ILRuntime_PropertyAddress, unrealStruct, "ILRuntime");
		ILRuntime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ILRuntime");
		ILRuntime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ILRuntime", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ILRuntimeJITOnDemand_PropertyAddress, unrealStruct, "ILRuntimeJITOnDemand");
		ILRuntimeJITOnDemand_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ILRuntimeJITOnDemand");
		ILRuntimeJITOnDemand_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ILRuntimeJITOnDemand", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Clrbinding_PropertyAddress, unrealStruct, "Clrbinding");
		Clrbinding_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Clrbinding");
		Clrbinding_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Clrbinding", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ILRuntimeDebugger_PropertyAddress, unrealStruct, "ILRuntimeDebugger");
		ILRuntimeDebugger_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ILRuntimeDebugger");
		ILRuntimeDebugger_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ILRuntimeDebugger", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableRtx_PropertyAddress, unrealStruct, "EnableRtx");
		EnableRtx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableRtx");
		EnableRtx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableRtx", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Report820Windows_PropertyAddress, unrealStruct, "Report820Windows");
		Report820Windows_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Report820Windows");
		Report820Windows_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Report820Windows", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ManualBuiGC_PropertyAddress, unrealStruct, "ManualBuiGC");
		ManualBuiGC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ManualBuiGC");
		ManualBuiGC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ManualBuiGC", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Report820PS5_PropertyAddress, unrealStruct, "Report820PS5");
		Report820PS5_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Report820PS5");
		Report820PS5_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Report820PS5", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Report820XSX_PropertyAddress, unrealStruct, "Report820XSX");
		Report820XSX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Report820XSX");
		Report820XSX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Report820XSX", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Report820WindowsRealtime_PropertyAddress, unrealStruct, "Report820WindowsRealtime");
		Report820WindowsRealtime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Report820WindowsRealtime");
		Report820WindowsRealtime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Report820WindowsRealtime", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ArchiveBackup_PropertyAddress, unrealStruct, "ArchiveBackup");
		ArchiveBackup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ArchiveBackup");
		ArchiveBackup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ArchiveBackup", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OverridePlayerLogMaxSize_PropertyAddress, unrealStruct, "OverridePlayerLogMaxSize");
		OverridePlayerLogMaxSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverridePlayerLogMaxSize");
		OverridePlayerLogMaxSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverridePlayerLogMaxSize", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugCFSMG_PropertyAddress, unrealStruct, "DebugCFSMG");
		DebugCFSMG_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugCFSMG");
		DebugCFSMG_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugCFSMG", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SimTimeMarkBase_PropertyAddress, unrealStruct, "SimTimeMarkBase");
		SimTimeMarkBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimTimeMarkBase");
		SimTimeMarkBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimTimeMarkBase", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SimTimeMarkStep_PropertyAddress, unrealStruct, "SimTimeMarkStep");
		SimTimeMarkStep_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimTimeMarkStep");
		SimTimeMarkStep_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimTimeMarkStep", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Navigation_PropertyAddress, unrealStruct, "Navigation");
		Navigation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Navigation");
		Navigation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Navigation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Intimidation_PropertyAddress, unrealStruct, "Intimidation");
		Intimidation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Intimidation");
		Intimidation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Intimidation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenSeparateFrameEntityBeginPlay_PropertyAddress, unrealStruct, "OpenSeparateFrameEntityBeginPlay");
		OpenSeparateFrameEntityBeginPlay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenSeparateFrameEntityBeginPlay");
		OpenSeparateFrameEntityBeginPlay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenSeparateFrameEntityBeginPlay", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InteractiveObj_PropertyAddress, unrealStruct, "InteractiveObj");
		InteractiveObj_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractiveObj");
		InteractiveObj_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractiveObj", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DrawSimpleOverlapDebug_PropertyAddress, unrealStruct, "DrawSimpleOverlapDebug");
		DrawSimpleOverlapDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DrawSimpleOverlapDebug");
		DrawSimpleOverlapDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DrawSimpleOverlapDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ProfilerSimpleOverlap_PropertyAddress, unrealStruct, "ProfilerSimpleOverlap");
		ProfilerSimpleOverlap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProfilerSimpleOverlap");
		ProfilerSimpleOverlap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProfilerSimpleOverlap", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TopdownBattleMode_PropertyAddress, unrealStruct, "TopdownBattleMode");
		TopdownBattleMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TopdownBattleMode");
		TopdownBattleMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TopdownBattleMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsTmpTestFlag_PropertyAddress, unrealStruct, "IsTmpTestFlag");
		IsTmpTestFlag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsTmpTestFlag");
		IsTmpTestFlag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsTmpTestFlag", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenNewChapterPlayerSafeLocation_PropertyAddress, unrealStruct, "OpenNewChapterPlayerSafeLocation");
		OpenNewChapterPlayerSafeLocation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenNewChapterPlayerSafeLocation");
		OpenNewChapterPlayerSafeLocation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenNewChapterPlayerSafeLocation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsLiteBuild_PropertyAddress, unrealStruct, "IsLiteBuild");
		IsLiteBuild_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsLiteBuild");
		IsLiteBuild_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsLiteBuild", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenGSRepLog_PropertyAddress, unrealStruct, "OpenGSRepLog");
		OpenGSRepLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenGSRepLog");
		OpenGSRepLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenGSRepLog", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ClientReset_PropertyAddress, unrealStruct, "ClientReset");
		ClientReset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ClientReset");
		ClientReset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ClientReset", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ProfileEnable_PropertyAddress, unrealStruct, "ProfileEnable");
		ProfileEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProfileEnable");
		ProfileEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProfileEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Enablepreload_PropertyAddress, unrealStruct, "Enablepreload");
		Enablepreload_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Enablepreload");
		Enablepreload_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Enablepreload", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CantCloseNetConnectWithError_PropertyAddress, unrealStruct, "CantCloseNetConnectWithError");
		CantCloseNetConnectWithError_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CantCloseNetConnectWithError");
		CantCloseNetConnectWithError_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CantCloseNetConnectWithError", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SkipRoleDataCheck_PropertyAddress, unrealStruct, "SkipRoleDataCheck");
		SkipRoleDataCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkipRoleDataCheck");
		SkipRoleDataCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkipRoleDataCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableMoveSpeedInfoDebug_PropertyAddress, unrealStruct, "EnableMoveSpeedInfoDebug");
		EnableMoveSpeedInfoDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableMoveSpeedInfoDebug");
		EnableMoveSpeedInfoDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableMoveSpeedInfoDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnablePrintJXSQCheckerResult_PropertyAddress, unrealStruct, "EnablePrintJXSQCheckerResult");
		EnablePrintJXSQCheckerResult_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnablePrintJXSQCheckerResult");
		EnablePrintJXSQCheckerResult_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnablePrintJXSQCheckerResult", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableChapterRoamV2_PropertyAddress, unrealStruct, "EnableChapterRoamV2");
		EnableChapterRoamV2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableChapterRoamV2");
		EnableChapterRoamV2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableChapterRoamV2", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ChapterDebug_PropertyAddress, unrealStruct, "ChapterDebug");
		ChapterDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChapterDebug");
		ChapterDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChapterDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableShrineAllFunc_PropertyAddress, unrealStruct, "EnableShrineAllFunc");
		EnableShrineAllFunc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableShrineAllFunc");
		EnableShrineAllFunc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableShrineAllFunc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableInteractAllFunc_PropertyAddress, unrealStruct, "EnableInteractAllFunc");
		EnableInteractAllFunc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableInteractAllFunc");
		EnableInteractAllFunc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableInteractAllFunc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DisableSkipInteractFunc_PropertyAddress, unrealStruct, "DisableSkipInteractFunc");
		DisableSkipInteractFunc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableSkipInteractFunc");
		DisableSkipInteractFunc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableSkipInteractFunc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DisableSkipMontageInteractFunc_PropertyAddress, unrealStruct, "DisableSkipMontageInteractFunc");
		DisableSkipMontageInteractFunc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableSkipMontageInteractFunc");
		DisableSkipMontageInteractFunc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableSkipMontageInteractFunc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpawnWaveDebug_PropertyAddress, unrealStruct, "SpawnWaveDebug");
		SpawnWaveDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnWaveDebug");
		SpawnWaveDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnWaveDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BPNeutralAnimalDebug_PropertyAddress, unrealStruct, "BPNeutralAnimalDebug");
		BPNeutralAnimalDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BPNeutralAnimalDebug");
		BPNeutralAnimalDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BPNeutralAnimalDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PureVersion_PropertyAddress, unrealStruct, "PureVersion");
		PureVersion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PureVersion");
		PureVersion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PureVersion", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PreOrderAwardDebug_PropertyAddress, unrealStruct, "PreOrderAwardDebug");
		PreOrderAwardDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreOrderAwardDebug");
		PreOrderAwardDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreOrderAwardDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DeluxeAwardDebug_PropertyAddress, unrealStruct, "DeluxeAwardDebug");
		DeluxeAwardDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DeluxeAwardDebug");
		DeluxeAwardDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DeluxeAwardDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DisableRpcLog_PropertyAddress, unrealStruct, "DisableRpcLog");
		DisableRpcLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableRpcLog");
		DisableRpcLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableRpcLog", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ActiveAllUI_PropertyAddress, unrealStruct, "ActiveAllUI");
		ActiveAllUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActiveAllUI");
		ActiveAllUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActiveAllUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Open1080Check_PropertyAddress, unrealStruct, "Open1080Check");
		Open1080Check_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Open1080Check");
		Open1080Check_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Open1080Check", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSDisableLoadingScreen_PropertyAddress, unrealStruct, "GSDisableLoadingScreen");
		GSDisableLoadingScreen_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSDisableLoadingScreen");
		GSDisableLoadingScreen_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSDisableLoadingScreen", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnlyOpenPVUI_PropertyAddress, unrealStruct, "OnlyOpenPVUI");
		OnlyOpenPVUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnlyOpenPVUI");
		OnlyOpenPVUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnlyOpenPVUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AdvanceDropManualClose_PropertyAddress, unrealStruct, "AdvanceDropManualClose");
		AdvanceDropManualClose_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdvanceDropManualClose");
		AdvanceDropManualClose_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdvanceDropManualClose", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InputDebugInfo_PropertyAddress, unrealStruct, "InputDebugInfo");
		InputDebugInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputDebugInfo");
		InputDebugInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputDebugInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InputDebug_Window_PropertyAddress, unrealStruct, "InputDebug_Window");
		InputDebug_Window_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputDebug_Window");
		InputDebug_Window_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputDebug_Window", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InputDebug_KeyCache_PropertyAddress, unrealStruct, "InputDebug_KeyCache");
		InputDebug_KeyCache_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputDebug_KeyCache");
		InputDebug_KeyCache_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputDebug_KeyCache", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GroupAI_PropertyAddress, unrealStruct, "GroupAI");
		GroupAI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GroupAI");
		GroupAI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GroupAI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AIInfo_PropertyAddress, unrealStruct, "AIInfo");
		AIInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AIInfo");
		AIInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AIInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TeamInfo_PropertyAddress, unrealStruct, "TeamInfo");
		TeamInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TeamInfo");
		TeamInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TeamInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FollowPartnerDispInfo_PropertyAddress, unrealStruct, "FollowPartnerDispInfo");
		FollowPartnerDispInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FollowPartnerDispInfo");
		FollowPartnerDispInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FollowPartnerDispInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TargetInfo_PropertyAddress, unrealStruct, "TargetInfo");
		TargetInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetInfo");
		TargetInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HatredInfo_PropertyAddress, unrealStruct, "HatredInfo");
		HatredInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HatredInfo");
		HatredInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HatredInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AINodeDebug_PropertyAddress, unrealStruct, "AINodeDebug");
		AINodeDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AINodeDebug");
		AINodeDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AINodeDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ABPHelperInfo_PropertyAddress, unrealStruct, "ABPHelperInfo");
		ABPHelperInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ABPHelperInfo");
		ABPHelperInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ABPHelperInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnlineAttr_PropertyAddress, unrealStruct, "OnlineAttr");
		OnlineAttr_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnlineAttr");
		OnlineAttr_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnlineAttr", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OnlineUnitState_PropertyAddress, unrealStruct, "OnlineUnitState");
		OnlineUnitState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnlineUnitState");
		OnlineUnitState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnlineUnitState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugDS_PropertyAddress, unrealStruct, "IsDebugDS");
		IsDebugDS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugDS");
		IsDebugDS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugDS", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ConnectionInfo_PropertyAddress, unrealStruct, "ConnectionInfo");
		ConnectionInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConnectionInfo");
		ConnectionInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConnectionInfo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PlayerDebugDraw_PropertyAddress, unrealStruct, "PlayerDebugDraw");
		PlayerDebugDraw_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerDebugDraw");
		PlayerDebugDraw_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerDebugDraw", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenNetConnectDebugUI_PropertyAddress, unrealStruct, "OpenNetConnectDebugUI");
		OpenNetConnectDebugUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenNetConnectDebugUI");
		OpenNetConnectDebugUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenNetConnectDebugUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugGSRepRole_PropertyAddress, unrealStruct, "DebugGSRepRole");
		DebugGSRepRole_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugGSRepRole");
		DebugGSRepRole_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugGSRepRole", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenEventDebugger_PropertyAddress, unrealStruct, "OpenEventDebugger");
		OpenEventDebugger_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenEventDebugger");
		OpenEventDebugger_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenEventDebugger", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugAKB_PropertyAddress, unrealStruct, "IsDebugAKB");
		IsDebugAKB_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugAKB");
		IsDebugAKB_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugAKB", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugUISys_PropertyAddress, unrealStruct, "IsDebugUISys");
		IsDebugUISys_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugUISys");
		IsDebugUISys_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugUISys", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugUIMore_PropertyAddress, unrealStruct, "IsDebugUIMore");
		IsDebugUIMore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugUIMore");
		IsDebugUIMore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugUIMore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugUIProc_PropertyAddress, unrealStruct, "IsDebugUIProc");
		IsDebugUIProc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugUIProc");
		IsDebugUIProc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugUIProc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugWidgetMore_PropertyAddress, unrealStruct, "IsDebugWidgetMore");
		IsDebugWidgetMore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugWidgetMore");
		IsDebugWidgetMore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugWidgetMore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugButton_PropertyAddress, unrealStruct, "IsDebugButton");
		IsDebugButton_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugButton");
		IsDebugButton_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugButton", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugAutoSizeScrollBox_PropertyAddress, unrealStruct, "IsDebugAutoSizeScrollBox");
		IsDebugAutoSizeScrollBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugAutoSizeScrollBox");
		IsDebugAutoSizeScrollBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugAutoSizeScrollBox", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugWidgetProfile_PropertyAddress, unrealStruct, "IsDebugWidgetProfile");
		IsDebugWidgetProfile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugWidgetProfile");
		IsDebugWidgetProfile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugWidgetProfile", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDebugUITick_PropertyAddress, unrealStruct, "IsDebugUITick");
		IsDebugUITick_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsDebugUITick");
		IsDebugUITick_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsDebugUITick", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsOpenStatGSCustom_PropertyAddress, unrealStruct, "IsOpenStatGSCustom");
		IsOpenStatGSCustom_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsOpenStatGSCustom");
		IsOpenStatGSCustom_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsOpenStatGSCustom", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsShowDebugDrawUI_PropertyAddress, unrealStruct, "IsShowDebugDrawUI");
		IsShowDebugDrawUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShowDebugDrawUI");
		IsShowDebugDrawUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShowDebugDrawUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugPhaseCSG_PropertyAddress, unrealStruct, "DebugPhaseCSG");
		DebugPhaseCSG_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugPhaseCSG");
		DebugPhaseCSG_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugPhaseCSG", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsOpenBattleInfoTool_PropertyAddress, unrealStruct, "IsOpenBattleInfoTool");
		IsOpenBattleInfoTool_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsOpenBattleInfoTool");
		IsOpenBattleInfoTool_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsOpenBattleInfoTool", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CancelSkillCD_PropertyAddress, unrealStruct, "CancelSkillCD");
		CancelSkillCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CancelSkillCD");
		CancelSkillCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CancelSkillCD", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugMap_PropertyAddress, unrealStruct, "DebugMap");
		DebugMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugMap");
		DebugMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugMap", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ShowChrEnvMaskValue_PropertyAddress, unrealStruct, "ShowChrEnvMaskValue");
		ShowChrEnvMaskValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowChrEnvMaskValue");
		ShowChrEnvMaskValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowChrEnvMaskValue", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsOpenRemoteTestCheat_PropertyAddress, unrealStruct, "IsOpenRemoteTestCheat");
		IsOpenRemoteTestCheat_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsOpenRemoteTestCheat");
		IsOpenRemoteTestCheat_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsOpenRemoteTestCheat", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsIgnoreValidateData_PropertyAddress, unrealStruct, "IsIgnoreValidateData");
		IsIgnoreValidateData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsIgnoreValidateData");
		IsIgnoreValidateData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsIgnoreValidateData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EventMemoryLeakTest_PropertyAddress, unrealStruct, "EventMemoryLeakTest");
		EventMemoryLeakTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EventMemoryLeakTest");
		EventMemoryLeakTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EventMemoryLeakTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TickEventMemoryLeakTest_PropertyAddress, unrealStruct, "TickEventMemoryLeakTest");
		TickEventMemoryLeakTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TickEventMemoryLeakTest");
		TickEventMemoryLeakTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TickEventMemoryLeakTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ObjMemoryLeakTest_PropertyAddress, unrealStruct, "ObjMemoryLeakTest");
		ObjMemoryLeakTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObjMemoryLeakTest");
		ObjMemoryLeakTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObjMemoryLeakTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MemoryLeakTestCacheObj_PropertyAddress, unrealStruct, "MemoryLeakTestCacheObj");
		MemoryLeakTestCacheObj_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MemoryLeakTestCacheObj");
		MemoryLeakTestCacheObj_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MemoryLeakTestCacheObj", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugStartWithOutArchive_PropertyAddress, unrealStruct, "DebugStartWithOutArchive");
		DebugStartWithOutArchive_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugStartWithOutArchive");
		DebugStartWithOutArchive_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugStartWithOutArchive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableSelectChapter_PropertyAddress, unrealStruct, "EnableSelectChapter");
		EnableSelectChapter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableSelectChapter");
		EnableSelectChapter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableSelectChapter", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CanOptimizeTick_PropertyAddress, unrealStruct, "CanOptimizeTick");
		CanOptimizeTick_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CanOptimizeTick");
		CanOptimizeTick_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CanOptimizeTick", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Debug820Demo_PropertyAddress, unrealStruct, "Debug820Demo");
		Debug820Demo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Debug820Demo");
		Debug820Demo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Debug820Demo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Demo820OverSeaVersion_PropertyAddress, unrealStruct, "Demo820OverSeaVersion");
		Demo820OverSeaVersion_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820OverSeaVersion");
		Demo820OverSeaVersion_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820OverSeaVersion", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Demo820DebugTest_PropertyAddress, unrealStruct, "Demo820DebugTest");
		Demo820DebugTest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820DebugTest");
		Demo820DebugTest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820DebugTest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Demo820UseSetting_PropertyAddress, unrealStruct, "Demo820UseSetting");
		Demo820UseSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820UseSetting");
		Demo820UseSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820UseSetting", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugFristStartGameSetting_PropertyAddress, unrealStruct, "DebugFristStartGameSetting");
		DebugFristStartGameSetting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugFristStartGameSetting");
		DebugFristStartGameSetting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugFristStartGameSetting", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenSeamlessLevelTravel_PropertyAddress, unrealStruct, "OpenSeamlessLevelTravel");
		OpenSeamlessLevelTravel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenSeamlessLevelTravel");
		OpenSeamlessLevelTravel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenSeamlessLevelTravel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Demo820ExceptionUI_PropertyAddress, unrealStruct, "Demo820ExceptionUI");
		Demo820ExceptionUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820ExceptionUI");
		Demo820ExceptionUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820ExceptionUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Demo820IgnoreAllOverlap_PropertyAddress, unrealStruct, "Demo820IgnoreAllOverlap");
		Demo820IgnoreAllOverlap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820IgnoreAllOverlap");
		Demo820IgnoreAllOverlap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820IgnoreAllOverlap", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugPlayerTransLog_PropertyAddress, unrealStruct, "DebugPlayerTransLog");
		DebugPlayerTransLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugPlayerTransLog");
		DebugPlayerTransLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugPlayerTransLog", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CricketBattleMode_PropertyAddress, unrealStruct, "CricketBattleMode");
		CricketBattleMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketBattleMode");
		CricketBattleMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketBattleMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CricketReportServer_PropertyAddress, unrealStruct, "CricketReportServer");
		CricketReportServer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketReportServer");
		CricketReportServer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketReportServer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugSettingLog_PropertyAddress, unrealStruct, "DebugSettingLog");
		DebugSettingLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugSettingLog");
		DebugSettingLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugSettingLog", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedGSSDKUserCheck_PropertyAddress, unrealStruct, "NeedGSSDKUserCheck");
		NeedGSSDKUserCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedGSSDKUserCheck");
		NeedGSSDKUserCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedGSSDKUserCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugTransGuideUI_PropertyAddress, unrealStruct, "DebugTransGuideUI");
		DebugTransGuideUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugTransGuideUI");
		DebugTransGuideUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugTransGuideUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LQALanguage_PropertyAddress, unrealStruct, "LQALanguage");
		LQALanguage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LQALanguage");
		LQALanguage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LQALanguage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSIsGlobalColorDeficiency_PropertyAddress, unrealStruct, "GSIsGlobalColorDeficiency");
		GSIsGlobalColorDeficiency_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSIsGlobalColorDeficiency");
		GSIsGlobalColorDeficiency_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSIsGlobalColorDeficiency", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugGameIntent_PropertyAddress, unrealStruct, "DebugGameIntent");
		DebugGameIntent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugGameIntent");
		DebugGameIntent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugGameIntent", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ShowLoadingTimeText_PropertyAddress, unrealStruct, "ShowLoadingTimeText");
		ShowLoadingTimeText_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ShowLoadingTimeText");
		ShowLoadingTimeText_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ShowLoadingTimeText", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNeedPsoPrecompileWhenStartGame_PropertyAddress, unrealStruct, "IsNeedPsoPrecompileWhenStartGame");
		IsNeedPsoPrecompileWhenStartGame_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsNeedPsoPrecompileWhenStartGame");
		IsNeedPsoPrecompileWhenStartGame_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsNeedPsoPrecompileWhenStartGame", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNeedPreStartGameProcess_PropertyAddress, unrealStruct, "IsNeedPreStartGameProcess");
		IsNeedPreStartGameProcess_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsNeedPreStartGameProcess");
		IsNeedPreStartGameProcess_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsNeedPreStartGameProcess", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DisableInputMessage_PropertyAddress, unrealStruct, "DisableInputMessage");
		DisableInputMessage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableInputMessage");
		DisableInputMessage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableInputMessage", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableUseNewTimelineForCPG_PropertyAddress, unrealStruct, "EnableUseNewTimelineForCPG");
		EnableUseNewTimelineForCPG_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableUseNewTimelineForCPG");
		EnableUseNewTimelineForCPG_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableUseNewTimelineForCPG", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugPlayGo_PropertyAddress, unrealStruct, "DebugPlayGo");
		DebugPlayGo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugPlayGo");
		DebugPlayGo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugPlayGo", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnablePlaneMoveMode_PropertyAddress, unrealStruct, "EnablePlaneMoveMode");
		EnablePlaneMoveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnablePlaneMoveMode");
		EnablePlaneMoveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnablePlaneMoveMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugPlayerGuide_PropertyAddress, unrealStruct, "DebugPlayerGuide");
		DebugPlayerGuide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugPlayerGuide");
		DebugPlayerGuide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugPlayerGuide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugNewGamePlusGuide_PropertyAddress, unrealStruct, "DebugNewGamePlusGuide");
		DebugNewGamePlusGuide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugNewGamePlusGuide");
		DebugNewGamePlusGuide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugNewGamePlusGuide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugBossRushGuide_PropertyAddress, unrealStruct, "DebugBossRushGuide");
		DebugBossRushGuide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugBossRushGuide");
		DebugBossRushGuide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugBossRushGuide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugMapGuide_PropertyAddress, unrealStruct, "DebugMapGuide");
		DebugMapGuide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugMapGuide");
		DebugMapGuide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugMapGuide", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugDonutAudio_PropertyAddress, unrealStruct, "DebugDonutAudio");
		DebugDonutAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugDonutAudio");
		DebugDonutAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugDonutAudio", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsOverSeaChannel_PropertyAddress, unrealStruct, "IsOverSeaChannel");
		IsOverSeaChannel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsOverSeaChannel");
		IsOverSeaChannel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsOverSeaChannel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableEncrypt_PropertyAddress, unrealStruct, "EnableEncrypt");
		EnableEncrypt_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableEncrypt");
		EnableEncrypt_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableEncrypt", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SettingHostSimulation_PropertyAddress, unrealStruct, "SettingHostSimulation");
		SettingHostSimulation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SettingHostSimulation");
		SettingHostSimulation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SettingHostSimulation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SettingEditorSimulation_PropertyAddress, unrealStruct, "SettingEditorSimulation");
		SettingEditorSimulation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SettingEditorSimulation");
		SettingEditorSimulation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SettingEditorSimulation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DevArchiveSizeCheck_PropertyAddress, unrealStruct, "DevArchiveSizeCheck");
		DevArchiveSizeCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DevArchiveSizeCheck");
		DevArchiveSizeCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DevArchiveSizeCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DisableDissolveDisplay_PropertyAddress, unrealStruct, "DisableDissolveDisplay");
		DisableDissolveDisplay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableDissolveDisplay");
		DisableDissolveDisplay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableDissolveDisplay", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ExceptionShowBtn_PropertyAddress, unrealStruct, "ExceptionShowBtn");
		ExceptionShowBtn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExceptionShowBtn");
		ExceptionShowBtn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExceptionShowBtn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ThrowException_PropertyAddress, unrealStruct, "ThrowException");
		ThrowException_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ThrowException");
		ThrowException_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ThrowException", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugSettingCvar_PropertyAddress, unrealStruct, "DebugSettingCvar");
		DebugSettingCvar_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugSettingCvar");
		DebugSettingCvar_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugSettingCvar", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugReInitRoleCheck_PropertyAddress, unrealStruct, "DebugReInitRoleCheck");
		DebugReInitRoleCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugReInitRoleCheck");
		DebugReInitRoleCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugReInitRoleCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DebugCollection_PropertyAddress, unrealStruct, "DebugCollection");
		DebugCollection_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugCollection");
		DebugCollection_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugCollection", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ButtonMatSyncCheck_PropertyAddress, unrealStruct, "ButtonMatSyncCheck");
		ButtonMatSyncCheck_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ButtonMatSyncCheck");
		ButtonMatSyncCheck_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ButtonMatSyncCheck", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenPastMemory_PropertyAddress, unrealStruct, "OpenPastMemory");
		OpenPastMemory_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenPastMemory");
		OpenPastMemory_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenPastMemory", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenSimpleTips_PropertyAddress, unrealStruct, "OpenSimpleTips");
		OpenSimpleTips_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenSimpleTips");
		OpenSimpleTips_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenSimpleTips", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OpenLocalizationInEditor_PropertyAddress, unrealStruct, "OpenLocalizationInEditor");
		OpenLocalizationInEditor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpenLocalizationInEditor");
		OpenLocalizationInEditor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpenLocalizationInEditor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableEnhancedInputDelay_PropertyAddress, unrealStruct, "EnableEnhancedInputDelay");
		EnableEnhancedInputDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableEnhancedInputDelay");
		EnableEnhancedInputDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableEnhancedInputDelay", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EndingCreditsUseJson_PropertyAddress, unrealStruct, "EndingCreditsUseJson");
		EndingCreditsUseJson_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndingCreditsUseJson");
		EndingCreditsUseJson_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndingCreditsUseJson", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HideMiniGMSequenceTab_PropertyAddress, unrealStruct, "HideMiniGMSequenceTab");
		HideMiniGMSequenceTab_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HideMiniGMSequenceTab");
		HideMiniGMSequenceTab_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HideMiniGMSequenceTab", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSWithBink_PropertyAddress, unrealStruct, "GSWithBink");
		GSWithBink_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSWithBink");
		GSWithBink_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSWithBink", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BenckMarkOnly_PropertyAddress, unrealStruct, "BenckMarkOnly");
		BenckMarkOnly_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BenckMarkOnly");
		BenckMarkOnly_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BenckMarkOnly", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BenckMarkLoop_PropertyAddress, unrealStruct, "BenckMarkLoop");
		BenckMarkLoop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BenckMarkLoop");
		BenckMarkLoop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BenckMarkLoop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DamageLogic_PropertyAddress, unrealStruct, "DamageLogic");
		DamageLogic_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DamageLogic");
		DamageLogic_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DamageLogic", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DropItem_PropertyAddress, unrealStruct, "DropItem");
		DropItem_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropItem");
		DropItem_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropItem", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Secret_PropertyAddress, unrealStruct, "Secret");
		Secret_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Secret");
		Secret_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Secret", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EntitySharedRefLeakDetect_PropertyAddress, unrealStruct, "EntitySharedRefLeakDetect");
		EntitySharedRefLeakDetect_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EntitySharedRefLeakDetect");
		EntitySharedRefLeakDetect_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EntitySharedRefLeakDetect", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TaskGroup_PropertyAddress, unrealStruct, "TaskGroup");
		TaskGroup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TaskGroup");
		TaskGroup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TaskGroup", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NPC_PropertyAddress, unrealStruct, "NPC");
		NPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NPC");
		NPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NPC", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ActiveManageUI_PropertyAddress, unrealStruct, "ActiveManageUI");
		ActiveManageUI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActiveManageUI");
		ActiveManageUI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActiveManageUI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GymModeInWindows_PropertyAddress, unrealStruct, "GymModeInWindows");
		GymModeInWindows_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GymModeInWindows");
		GymModeInWindows_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GymModeInWindows", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkEnableCETesting_PropertyAddress, unrealStruct, "GSSdkEnableCETesting");
		GSSdkEnableCETesting_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkEnableCETesting");
		GSSdkEnableCETesting_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkEnableCETesting", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref KAServerUseTcp_PropertyAddress, unrealStruct, "KAServerUseTcp");
		KAServerUseTcp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KAServerUseTcp");
		KAServerUseTcp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KAServerUseTcp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedLauncher_PropertyAddress, unrealStruct, "NeedLauncher");
		NeedLauncher_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedLauncher");
		NeedLauncher_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedLauncher", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref HideCrashReportClientUi_PropertyAddress, unrealStruct, "HideCrashReportClientUi");
		HideCrashReportClientUi_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HideCrashReportClientUi");
		HideCrashReportClientUi_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HideCrashReportClientUi", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkReportUseCSharpHttp_PropertyAddress, unrealStruct, "GSSdkReportUseCSharpHttp");
		GSSdkReportUseCSharpHttp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportUseCSharpHttp");
		GSSdkReportUseCSharpHttp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportUseCSharpHttp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkReportUseAsyncHttp_PropertyAddress, unrealStruct, "GSSdkReportUseAsyncHttp");
		GSSdkReportUseAsyncHttp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportUseAsyncHttp");
		GSSdkReportUseAsyncHttp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportUseAsyncHttp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkReportEnable_PropertyAddress, unrealStruct, "GSSdkReportEnable");
		GSSdkReportEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportEnable");
		GSSdkReportEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkReportDisableHttpRequest_PropertyAddress, unrealStruct, "GSSdkReportDisableHttpRequest");
		GSSdkReportDisableHttpRequest_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportDisableHttpRequest");
		GSSdkReportDisableHttpRequest_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportDisableHttpRequest", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkEnableSensDataClean_PropertyAddress, unrealStruct, "GSSdkEnableSensDataClean");
		GSSdkEnableSensDataClean_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkEnableSensDataClean");
		GSSdkEnableSensDataClean_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkEnableSensDataClean", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkEnableMonitor_PropertyAddress, unrealStruct, "GSSdkEnableMonitor");
		GSSdkEnableMonitor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkEnableMonitor");
		GSSdkEnableMonitor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkEnableMonitor", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GSSdkEnablePerf_PropertyAddress, unrealStruct, "GSSdkEnablePerf");
		GSSdkEnablePerf_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkEnablePerf");
		GSSdkEnablePerf_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkEnablePerf", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SentryDebug_PropertyAddress, unrealStruct, "SentryDebug");
		SentryDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryDebug");
		SentryDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SentryEnable_PropertyAddress, unrealStruct, "SentryEnable");
		SentryEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryEnable");
		SentryEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SentryEnableTracing_PropertyAddress, unrealStruct, "SentryEnableTracing");
		SentryEnableTracing_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryEnableTracing");
		SentryEnableTracing_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryEnableTracing", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SentryCaptureFailRequests_PropertyAddress, unrealStruct, "SentryCaptureFailRequests");
		SentryCaptureFailRequests_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryCaptureFailRequests");
		SentryCaptureFailRequests_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryCaptureFailRequests", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SentryUseLocalCacheFile_PropertyAddress, unrealStruct, "SentryUseLocalCacheFile");
		SentryUseLocalCacheFile_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryUseLocalCacheFile");
		SentryUseLocalCacheFile_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryUseLocalCacheFile", Classes.FBoolProperty);
		PlatformEventSendIntervalMilliSecond_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlatformEventSendIntervalMilliSecond");
		PlatformEventSendIntervalMilliSecond_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlatformEventSendIntervalMilliSecond", Classes.FIntProperty);
		PlatformEventTimeoutMilliSecond_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlatformEventTimeoutMilliSecond");
		PlatformEventTimeoutMilliSecond_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlatformEventTimeoutMilliSecond", Classes.FIntProperty);
		PlayerLogMaxSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerLogMaxSize");
		PlayerLogMaxSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerLogMaxSize", Classes.FIntProperty);
		ReportTimeout_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReportTimeout");
		ReportTimeout_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReportTimeout", Classes.FIntProperty);
		UseDebugTamerConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseDebugTamerConfig");
		UseDebugTamerConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseDebugTamerConfig", Classes.FIntProperty);
		HideLockTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HideLockTarget");
		HideLockTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HideLockTarget", Classes.FIntProperty);
		EventWarningLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EventWarningLevel");
		EventWarningLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EventWarningLevel", Classes.FIntProperty);
		DebugOnlineLevelId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugOnlineLevelId");
		DebugOnlineLevelId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugOnlineLevelId", Classes.FIntProperty);
		UITickProfileLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UITickProfileLevel");
		UITickProfileLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UITickProfileLevel", Classes.FIntProperty);
		CollectionForceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CollectionForceType");
		CollectionForceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CollectionForceType", Classes.FIntProperty);
		LockDesiredPlayerHP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockDesiredPlayerHP");
		LockDesiredPlayerHP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockDesiredPlayerHP", Classes.FIntProperty);
		FSRCrashOptions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FSRCrashOptions");
		FSRCrashOptions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FSRCrashOptions", Classes.FIntProperty);
		Demo820PlayCountMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Demo820PlayCountMax");
		Demo820PlayCountMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Demo820PlayCountMax", Classes.FIntProperty);
		CricketBattleModeType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketBattleModeType");
		CricketBattleModeType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketBattleModeType", Classes.FIntProperty);
		LoadingMaxTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoadingMaxTime");
		LoadingMaxTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoadingMaxTime", Classes.FIntProperty);
		LoadingMaxTimeShowTips_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoadingMaxTimeShowTips");
		LoadingMaxTimeShowTips_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoadingMaxTimeShowTips", Classes.FIntProperty);
		EnsureReportInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnsureReportInterval");
		EnsureReportInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnsureReportInterval", Classes.FIntProperty);
		DevArchiveSizeMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DevArchiveSizeMax");
		DevArchiveSizeMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DevArchiveSizeMax", Classes.FIntProperty);
		DebugOverSeaType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugOverSeaType");
		DebugOverSeaType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugOverSeaType", Classes.FIntProperty);
		WaitMSToThrowException_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WaitMSToThrowException");
		WaitMSToThrowException_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WaitMSToThrowException", Classes.FIntProperty);
		UpdateUserConfigInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpdateUserConfigInterval");
		UpdateUserConfigInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpdateUserConfigInterval", Classes.FIntProperty);
		DebugGameCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugGameCount");
		DebugGameCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugGameCount", Classes.FIntProperty);
		WeaponBuildMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponBuildMode");
		WeaponBuildMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponBuildMode", Classes.FIntProperty);
		EnhancedInputDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnhancedInputDelayTime");
		EnhancedInputDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnhancedInputDelayTime", Classes.FIntProperty);
		EnhancedInputSpecialDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnhancedInputSpecialDelayTime");
		EnhancedInputSpecialDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnhancedInputSpecialDelayTime", Classes.FIntProperty);
		MediaPlayerSyncToleranceMS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MediaPlayerSyncToleranceMS");
		MediaPlayerSyncToleranceMS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MediaPlayerSyncToleranceMS", Classes.FIntProperty);
		MediaPlayerSyncCDMS_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MediaPlayerSyncCDMS");
		MediaPlayerSyncCDMS_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MediaPlayerSyncCDMS", Classes.FIntProperty);
		BenckMarkGPULow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BenckMarkGPULow");
		BenckMarkGPULow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BenckMarkGPULow", Classes.FIntProperty);
		ForceEnableDebugGMFlags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceEnableDebugGMFlags");
		ForceEnableDebugGMFlags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceEnableDebugGMFlags", Classes.FIntProperty);
		KAServerPort_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KAServerPort");
		KAServerPort_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KAServerPort", Classes.FIntProperty);
		GSSdkReportMergeBatchEventNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportMergeBatchEventNum");
		GSSdkReportMergeBatchEventNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportMergeBatchEventNum", Classes.FIntProperty);
		GSSdkReportMergeBatchIntervalSeconds_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkReportMergeBatchIntervalSeconds");
		GSSdkReportMergeBatchIntervalSeconds_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkReportMergeBatchIntervalSeconds", Classes.FIntProperty);
		EnableAllGMCMDAndDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableAllGMCMDAndDebug");
		EnableAllGMCMDAndDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableAllGMCMDAndDebug", Classes.FStrProperty);
		CESetRealBranchName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CESetRealBranchName");
		CESetRealBranchName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CESetRealBranchName", Classes.FStrProperty);
		RoomServerConnectAddr_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RoomServerConnectAddr");
		RoomServerConnectAddr_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RoomServerConnectAddr", Classes.FStrProperty);
		DebugDrawTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugDrawTag");
		DebugDrawTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugDrawTag", Classes.FStrProperty);
		B1DeluxeAddOnId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "B1DeluxeAddOnId");
		B1DeluxeAddOnId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "B1DeluxeAddOnId", Classes.FStrProperty);
		B1PrePurchaseAddOnId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "B1PrePurchaseAddOnId");
		B1PrePurchaseAddOnId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "B1PrePurchaseAddOnId", Classes.FStrProperty);
		FileIOStrategy_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FileIOStrategy");
		FileIOStrategy_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FileIOStrategy", Classes.FStrProperty);
		DebugRtxEnableLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugRtxEnableLevel");
		DebugRtxEnableLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugRtxEnableLevel", Classes.FStrProperty);
		FAQWebsiteLink_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FAQWebsiteLink");
		FAQWebsiteLink_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FAQWebsiteLink", Classes.FStrProperty);
		FileMd5CheckIgnorePathPattern_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FileMd5CheckIgnorePathPattern");
		FileMd5CheckIgnorePathPattern_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FileMd5CheckIgnorePathPattern", Classes.FStrProperty);
		KAServerHost_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KAServerHost");
		KAServerHost_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KAServerHost", Classes.FStrProperty);
		KAExtraId_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "KAExtraId");
		KAExtraId_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "KAExtraId", Classes.FStrProperty);
		DevGamesciLoginServerUrl_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DevGamesciLoginServerUrl");
		DevGamesciLoginServerUrl_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DevGamesciLoginServerUrl", Classes.FStrProperty);
		Environment_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Environment");
		Environment_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Environment", Classes.FStrProperty);
		GSSdkCDNRootUrlList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkCDNRootUrlList");
		GSSdkCDNRootUrlList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkCDNRootUrlList", Classes.FStrProperty);
		GSSdkEnvServerUrlList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkEnvServerUrlList");
		GSSdkEnvServerUrlList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkEnvServerUrlList", Classes.FStrProperty);
		GSSdkAppChannel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkAppChannel");
		GSSdkAppChannel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkAppChannel", Classes.FStrProperty);
		GSSdkLoginChannel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkLoginChannel");
		GSSdkLoginChannel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkLoginChannel", Classes.FStrProperty);
		GSSdkLoginSubChannel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkLoginSubChannel");
		GSSdkLoginSubChannel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkLoginSubChannel", Classes.FStrProperty);
		GSSdkPackageTags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSSdkPackageTags");
		GSSdkPackageTags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSSdkPackageTags", Classes.FStrProperty);
		SentryDSN_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryDSN");
		SentryDSN_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryDSN", Classes.FStrProperty);
		SentryHostBackup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentryHostBackup");
		SentryHostBackup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentryHostBackup", Classes.FStrProperty);
		SentrySampleRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SentrySampleRate");
		SentrySampleRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SentrySampleRate", Classes.FStrProperty);
		MagicCheckOverlay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MagicCheckOverlay");
		MagicCheckOverlay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MagicCheckOverlay", Classes.FStrProperty);
	}

	static GSGameCoustomConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSGameCoustomConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSGameCoustomConfig));
	}
}
