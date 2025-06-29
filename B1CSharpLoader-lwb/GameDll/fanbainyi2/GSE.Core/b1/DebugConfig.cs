using UnrealEngine.Runtime;

namespace b1;

public static class DebugConfig
{
	private static GsCvarData ArchiveRefactorCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ArchiveRefactor", 0, ""));

	private static GsCvarData DebugWidgetCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugWidget", 0, ""));

	private static GsCvarData ILRuntimeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ILRuntime", 1, ""));

	private static GsCvarData ILRuntimeJITOnDemandCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ILRuntimeJITOnDemand", 0, ""));

	private static GsCvarData ClrbindingCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Clrbinding", 0, ""));

	private static GsCvarData ILRuntimeDebuggerCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ILRuntimeDebugger", 0, ""));

	private static GsCvarData EnableRtxCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableRtx", 0, ""));

	private static GsCvarData Report820WindowsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Report820Windows", 0, ""));

	private static GsCvarData ManualBuiGCCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ManualBuiGC", 0, ""));

	private static GsCvarData Report820PS5CVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Report820PS5", 0, ""));

	private static GsCvarData Report820XSXCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Report820XSX", 0, ""));

	private static GsCvarData Report820WindowsRealtimeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Report820WindowsRealtime", 1, ""));

	private static GsCvarData ArchiveBackupCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ArchiveBackup", 1, ""));

	private static GsCvarData OverridePlayerLogMaxSizeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OverridePlayerLogMaxSize", 0, ""));

	private static GsCvarData DebugCFSMGCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugCFSMG", 0, ""));

	private static GsCvarData SimTimeMarkBaseCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SimTimeMarkBase", 0, ""));

	private static GsCvarData SimTimeMarkStepCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SimTimeMarkStep", 0, ""));

	private static GsCvarData NavigationCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Navigation", 0, ""));

	private static GsCvarData IntimidationCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Intimidation", 0, ""));

	private static GsCvarData OpenSeparateFrameEntityBeginPlayCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenSeparateFrameEntityBeginPlay", 1, ""));

	private static GsCvarData InteractiveObjCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.InteractiveObj", 0, ""));

	private static GsCvarData DrawSimpleOverlapDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DrawSimpleOverlapDebug", 0, ""));

	private static GsCvarData ProfilerSimpleOverlapCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ProfilerSimpleOverlap", 0, ""));

	private static GsCvarData TopdownBattleModeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.TopdownBattleMode", 0, ""));

	private static GsCvarData IsTmpTestFlagCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsTmpTestFlag", 0, ""));

	private static GsCvarData OpenNewChapterPlayerSafeLocationCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenNewChapterPlayerSafeLocation", 1, ""));

	private static GsCvarData IsLiteBuildCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsLiteBuild", 0, ""));

	private static GsCvarData OpenGSRepLogCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenGSRepLog", 0, ""));

	private static GsCvarData ClientResetCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ClientReset", 1, ""));

	private static GsCvarData ProfileEnableCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ProfileEnable", 0, ""));

	private static GsCvarData EnablepreloadCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Enablepreload", 0, ""));

	private static GsCvarData CantCloseNetConnectWithErrorCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CantCloseNetConnectWithError", 0, ""));

	private static GsCvarData SkipRoleDataCheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SkipRoleDataCheck", 0, ""));

	private static GsCvarData EnableMoveSpeedInfoDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableMoveSpeedInfoDebug", 0, ""));

	private static GsCvarData EnablePrintJXSQCheckerResultCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnablePrintJXSQCheckerResult", 0, ""));

	private static GsCvarData EnableChapterRoamV2CVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableChapterRoamV2", 0, ""));

	private static GsCvarData ChapterDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ChapterDebug", 0, ""));

	private static GsCvarData EnableShrineAllFuncCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableShrineAllFunc", 0, ""));

	private static GsCvarData EnableInteractAllFuncCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableInteractAllFunc", 0, ""));

	private static GsCvarData DisableSkipInteractFuncCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DisableSkipInteractFunc", 0, ""));

	private static GsCvarData DisableSkipMontageInteractFuncCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DisableSkipMontageInteractFunc", 0, ""));

	private static GsCvarData SpawnWaveDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SpawnWaveDebug", 0, ""));

	private static GsCvarData BPNeutralAnimalDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.BPNeutralAnimalDebug", 0, ""));

	private static GsCvarData PureVersionCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PureVersion", 0, ""));

	private static GsCvarData PreOrderAwardDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PreOrderAwardDebug", 0, ""));

	private static GsCvarData DeluxeAwardDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DeluxeAwardDebug", 0, ""));

	private static GsCvarData DisableRpcLogCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DisableRpcLog", 0, ""));

	private static GsCvarData ActiveAllUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ActiveAllUI", 1, ""));

	private static GsCvarData Open1080CheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Open1080Check", 1, ""));

	private static GsCvarData GSDisableLoadingScreenCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSDisableLoadingScreen", 0, ""));

	private static GsCvarData OnlyOpenPVUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OnlyOpenPVUI", 0, ""));

	private static GsCvarData AdvanceDropManualCloseCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.AdvanceDropManualClose", 0, ""));

	private static GsCvarData InputDebugInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.InputDebugInfo", 0, ""));

	private static GsCvarData InputDebug_WindowCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.InputDebug_Window", 0, ""));

	private static GsCvarData InputDebug_KeyCacheCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.InputDebug_KeyCache", 0, ""));

	private static GsCvarData GroupAICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GroupAI", 0, ""));

	private static GsCvarData AIInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.AIInfo", 0, ""));

	private static GsCvarData TeamInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.TeamInfo", 0, ""));

	private static GsCvarData FollowPartnerDispInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.FollowPartnerDispInfo", 0, ""));

	private static GsCvarData TargetInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.TargetInfo", 0, ""));

	private static GsCvarData HatredInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.HatredInfo", 0, ""));

	private static GsCvarData AINodeDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.AINodeDebug", 0, ""));

	private static GsCvarData ABPHelperInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ABPHelperInfo", 0, ""));

	private static GsCvarData OnlineAttrCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OnlineAttr", 0, ""));

	private static GsCvarData OnlineUnitStateCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OnlineUnitState", 0, ""));

	private static GsCvarData IsDebugDSCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugDS", 0, ""));

	private static GsCvarData ConnectionInfoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ConnectionInfo", 1, ""));

	private static GsCvarData PlayerDebugDrawCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PlayerDebugDraw", 0, ""));

	private static GsCvarData OpenNetConnectDebugUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenNetConnectDebugUI", 0, ""));

	private static GsCvarData DebugGSRepRoleCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugGSRepRole", 0, ""));

	private static GsCvarData OpenEventDebuggerCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenEventDebugger", 0, ""));

	private static GsCvarData IsDebugAKBCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugAKB", 0, ""));

	private static GsCvarData IsDebugUISysCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugUISys", 0, ""));

	private static GsCvarData IsDebugUIMoreCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugUIMore", 0, ""));

	private static GsCvarData IsDebugUIProcCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugUIProc", 0, ""));

	private static GsCvarData IsDebugWidgetMoreCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugWidgetMore", 0, ""));

	private static GsCvarData IsDebugButtonCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugButton", 0, ""));

	private static GsCvarData IsDebugAutoSizeScrollBoxCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugAutoSizeScrollBox", 0, ""));

	private static GsCvarData IsDebugWidgetProfileCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugWidgetProfile", 0, ""));

	private static GsCvarData IsDebugUITickCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsDebugUITick", 0, ""));

	private static GsCvarData IsOpenStatGSCustomCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsOpenStatGSCustom", 0, ""));

	private static GsCvarData IsShowDebugDrawUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsShowDebugDrawUI", 0, ""));

	private static GsCvarData DebugPhaseCSGCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugPhaseCSG", 0, ""));

	private static GsCvarData IsOpenBattleInfoToolCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsOpenBattleInfoTool", 0, ""));

	private static GsCvarData CancelSkillCDCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CancelSkillCD", 0, ""));

	private static GsCvarData DebugMapCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugMap", 0, ""));

	private static GsCvarData ShowChrEnvMaskValueCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ShowChrEnvMaskValue", 0, ""));

	private static GsCvarData IsOpenRemoteTestCheatCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsOpenRemoteTestCheat", 0, ""));

	private static GsCvarData IsIgnoreValidateDataCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsIgnoreValidateData", 0, ""));

	private static GsCvarData EventMemoryLeakTestCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EventMemoryLeakTest", 0, ""));

	private static GsCvarData TickEventMemoryLeakTestCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.TickEventMemoryLeakTest", 0, ""));

	private static GsCvarData ObjMemoryLeakTestCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ObjMemoryLeakTest", 0, ""));

	private static GsCvarData MemoryLeakTestCacheObjCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.MemoryLeakTestCacheObj", 0, ""));

	private static GsCvarData DebugStartWithOutArchiveCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugStartWithOutArchive", 0, ""));

	private static GsCvarData EnableSelectChapterCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableSelectChapter", 0, ""));

	private static GsCvarData CanOptimizeTickCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CanOptimizeTick", 1, ""));

	private static GsCvarData Debug820DemoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Debug820Demo", 0, ""));

	private static GsCvarData Demo820OverSeaVersionCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820OverSeaVersion", 0, ""));

	private static GsCvarData Demo820DebugTestCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820DebugTest", 0, ""));

	private static GsCvarData Demo820UseSettingCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820UseSetting", 0, ""));

	private static GsCvarData DebugFristStartGameSettingCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugFristStartGameSetting", 0, ""));

	private static GsCvarData OpenSeamlessLevelTravelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenSeamlessLevelTravel", 1, ""));

	private static GsCvarData Demo820ExceptionUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820ExceptionUI", 0, ""));

	private static GsCvarData Demo820IgnoreAllOverlapCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820IgnoreAllOverlap", 0, ""));

	private static GsCvarData DebugPlayerTransLogCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugPlayerTransLog", 1, ""));

	private static GsCvarData CricketBattleModeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CricketBattleMode", 0, ""));

	private static GsCvarData CricketReportServerCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CricketReportServer", 0, ""));

	private static GsCvarData DebugSettingLogCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugSettingLog", 0, ""));

	private static GsCvarData NeedGSSDKUserCheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.NeedGSSDKUserCheck", 1, ""));

	private static GsCvarData DebugTransGuideUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugTransGuideUI", 0, ""));

	private static GsCvarData LQALanguageCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.LQALanguage", 0, ""));

	private static GsCvarData GSIsGlobalColorDeficiencyCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSIsGlobalColorDeficiency", 1, ""));

	private static GsCvarData DebugGameIntentCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugGameIntent", 0, ""));

	private static GsCvarData ShowLoadingTimeTextCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ShowLoadingTimeText", 0, ""));

	private static GsCvarData IsNeedPsoPrecompileWhenStartGameCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsNeedPsoPrecompileWhenStartGame", 1, ""));

	private static GsCvarData IsNeedPreStartGameProcessCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsNeedPreStartGameProcess", 1, ""));

	private static GsCvarData DisableInputMessageCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DisableInputMessage", 0, ""));

	private static GsCvarData EnableUseNewTimelineForCPGCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableUseNewTimelineForCPG", 1, ""));

	private static GsCvarData DebugPlayGoCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugPlayGo", 0, ""));

	private static GsCvarData EnablePlaneMoveModeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnablePlaneMoveMode", 0, ""));

	private static GsCvarData DebugPlayerGuideCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugPlayerGuide", 0, ""));

	private static GsCvarData DebugNewGamePlusGuideCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugNewGamePlusGuide", 0, ""));

	private static GsCvarData DebugBossRushGuideCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugBossRushGuide", 0, ""));

	private static GsCvarData DebugMapGuideCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugMapGuide", 0, ""));

	private static GsCvarData DebugDonutAudioCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugDonutAudio", 0, ""));

	private static GsCvarData IsOverSeaChannelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.IsOverSeaChannel", 1, ""));

	private static GsCvarData EnableEncryptCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableEncrypt", 1, ""));

	private static GsCvarData SettingHostSimulationCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SettingHostSimulation", 0, ""));

	private static GsCvarData SettingEditorSimulationCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SettingEditorSimulation", 0, ""));

	private static GsCvarData DevArchiveSizeCheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DevArchiveSizeCheck", 1, ""));

	private static GsCvarData DisableDissolveDisplayCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DisableDissolveDisplay", 0, ""));

	private static GsCvarData ExceptionShowBtnCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ExceptionShowBtn", 1, ""));

	private static GsCvarData ThrowExceptionCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ThrowException", 0, ""));

	private static GsCvarData DebugSettingCvarCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugSettingCvar", 0, ""));

	private static GsCvarData DebugReInitRoleCheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugReInitRoleCheck", 1, ""));

	private static GsCvarData DebugCollectionCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugCollection", 0, ""));

	private static GsCvarData ButtonMatSyncCheckCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ButtonMatSyncCheck", 1, ""));

	private static GsCvarData OpenPastMemoryCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenPastMemory", 1, ""));

	private static GsCvarData OpenSimpleTipsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenSimpleTips", 0, ""));

	private static GsCvarData OpenLocalizationInEditorCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.OpenLocalizationInEditor", 0, ""));

	private static GsCvarData EnableEnhancedInputDelayCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableEnhancedInputDelay", 1, ""));

	private static GsCvarData EndingCreditsUseJsonCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EndingCreditsUseJson", 0, ""));

	private static GsCvarData HideMiniGMSequenceTabCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.HideMiniGMSequenceTab", 1, ""));

	private static GsCvarData GSWithBinkCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSWithBink", 1, ""));

	private static GsCvarData BenckMarkOnlyCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.BenckMarkOnly", 0, ""));

	private static GsCvarData BenckMarkLoopCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.BenckMarkLoop", 0, ""));

	private static GsCvarData DamageLogicCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DamageLogic", 0, ""));

	private static GsCvarData DropItemCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DropItem", 0, ""));

	private static GsCvarData SecretCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Secret", 1, ""));

	private static GsCvarData EntitySharedRefLeakDetectCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EntitySharedRefLeakDetect", 0, ""));

	private static GsCvarData TaskGroupCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.TaskGroup", 0, ""));

	private static GsCvarData NPCCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.NPC", 0, ""));

	private static GsCvarData ActiveManageUICVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ActiveManageUI", 1, ""));

	private static GsCvarData GymModeInWindowsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GymModeInWindows", 0, ""));

	private static GsCvarData GSSdkEnableCETestingCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkEnableCETesting", 0, ""));

	private static GsCvarData KAServerUseTcpCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.KAServerUseTcp", 1, ""));

	private static GsCvarData NeedLauncherCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.NeedLauncher", 0, ""));

	private static GsCvarData HideCrashReportClientUiCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.HideCrashReportClientUi", 1, ""));

	private static GsCvarData GSSdkReportUseCSharpHttpCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportUseCSharpHttp", 0, ""));

	private static GsCvarData GSSdkReportUseAsyncHttpCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportUseAsyncHttp", 0, ""));

	private static GsCvarData GSSdkReportEnableCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportEnable", 1, ""));

	private static GsCvarData GSSdkReportDisableHttpRequestCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportDisableHttpRequest", 0, ""));

	private static GsCvarData GSSdkEnableSensDataCleanCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkEnableSensDataClean", 0, ""));

	private static GsCvarData GSSdkEnableMonitorCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkEnableMonitor", 1, ""));

	private static GsCvarData GSSdkEnablePerfCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkEnablePerf", 1, ""));

	private static GsCvarData SentryDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryDebug", 0, ""));

	private static GsCvarData SentryEnableCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryEnable", 1, ""));

	private static GsCvarData SentryEnableTracingCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryEnableTracing", 0, ""));

	private static GsCvarData SentryCaptureFailRequestsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryCaptureFailRequests", 0, ""));

	private static GsCvarData SentryUseLocalCacheFileCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryUseLocalCacheFile", 0, ""));

	private static GsCvarData PlatformEventSendIntervalMilliSecondCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PlatformEventSendIntervalMilliSecond", 2000, ""));

	private static GsCvarData PlatformEventTimeoutMilliSecondCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PlatformEventTimeoutMilliSecond", 60000, ""));

	private static GsCvarData PlayerLogMaxSizeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.PlayerLogMaxSize", 50, ""));

	private static GsCvarData ReportTimeoutCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ReportTimeout", 10, ""));

	private static GsCvarData UseDebugTamerConfigCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.UseDebugTamerConfig", 0, ""));

	private static GsCvarData HideLockTargetCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.HideLockTarget", 1, ""));

	private static GsCvarData EventWarningLevelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EventWarningLevel", 0, ""));

	private static GsCvarData DebugOnlineLevelIdCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugOnlineLevelId", 0, ""));

	private static GsCvarData UITickProfileLevelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.UITickProfileLevel", 0, ""));

	private static GsCvarData CollectionForceTypeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CollectionForceType", 0, ""));

	private static GsCvarData LockDesiredPlayerHPCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.LockDesiredPlayerHP", 0, ""));

	private static GsCvarData FSRCrashOptionsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.FSRCrashOptions", 2, ""));

	private static GsCvarData Demo820PlayCountMaxCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Demo820PlayCountMax", 0, ""));

	private static GsCvarData CricketBattleModeTypeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CricketBattleModeType", 2, ""));

	private static GsCvarData LoadingMaxTimeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.LoadingMaxTime", 300, ""));

	private static GsCvarData LoadingMaxTimeShowTipsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.LoadingMaxTimeShowTips", 180, ""));

	private static GsCvarData EnsureReportIntervalCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnsureReportInterval", 60, ""));

	private static GsCvarData DevArchiveSizeMaxCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DevArchiveSizeMax", 5242880, ""));

	private static GsCvarData DebugOverSeaTypeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugOverSeaType", 0, ""));

	private static GsCvarData WaitMSToThrowExceptionCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.WaitMSToThrowException", 10000, ""));

	private static GsCvarData UpdateUserConfigIntervalCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.UpdateUserConfigInterval", 5, ""));

	private static GsCvarData DebugGameCountCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugGameCount", 0, ""));

	private static GsCvarData WeaponBuildModeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.WeaponBuildMode", 1, ""));

	private static GsCvarData EnhancedInputDelayTimeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnhancedInputDelayTime", 30, ""));

	private static GsCvarData EnhancedInputSpecialDelayTimeCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnhancedInputSpecialDelayTime", 50, ""));

	private static GsCvarData MediaPlayerSyncToleranceMSCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.MediaPlayerSyncToleranceMS", 500, ""));

	private static GsCvarData MediaPlayerSyncCDMSCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.MediaPlayerSyncCDMS", 3000, ""));

	private static GsCvarData BenckMarkGPULowCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.BenckMarkGPULow", 40, ""));

	private static GsCvarData ForceEnableDebugGMFlagsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.ForceEnableDebugGMFlags", 0, ""));

	private static GsCvarData KAServerPortCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.KAServerPort", 12800, ""));

	private static GsCvarData GSSdkReportMergeBatchEventNumCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportMergeBatchEventNum", 300, ""));

	private static GsCvarData GSSdkReportMergeBatchIntervalSecondsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkReportMergeBatchIntervalSeconds", 60, ""));

	private static GsCvarData EnableAllGMCMDAndDebugCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.EnableAllGMCMDAndDebug", "b.WTF", ""));

	private static GsCvarData CESetRealBranchNameCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.CESetRealBranchName", "", ""));

	private static GsCvarData RoomServerConnectAddrCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.RoomServerConnectAddr", "", ""));

	private static GsCvarData DebugDrawTagCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugDrawTag", "Seq,", ""));

	private static GsCvarData B1DeluxeAddOnIdCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.B1DeluxeAddOnId", "", ""));

	private static GsCvarData B1PrePurchaseAddOnIdCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.B1PrePurchaseAddOnId", "", ""));

	private static GsCvarData FileIOStrategyCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.FileIOStrategy", "UGSFileHelper", ""));

	private static GsCvarData DebugRtxEnableLevelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DebugRtxEnableLevel", "", ""));

	private static GsCvarData FAQWebsiteLinkCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.FAQWebsiteLink", "https://www.heishenhua.com/support", ""));

	private static GsCvarData FileMd5CheckIgnorePathPatternCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.FileMd5CheckIgnorePathPattern", "/Saved/,/Logs/,b1/Tools/", ""));

	private static GsCvarData KAServerHostCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.KAServerHost", "gshb.b1.gamesci.com.cn", ""));

	private static GsCvarData KAExtraIdCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.KAExtraId", "", ""));

	private static GsCvarData DevGamesciLoginServerUrlCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.DevGamesciLoginServerUrl", "http://gslogin.b1.gamesci.com.cn:19912", ""));

	private static GsCvarData EnvironmentCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.Environment", "dev", ""));

	private static GsCvarData GSSdkCDNRootUrlListCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkCDNRootUrlList", "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1pbtable_cdn", ""));

	private static GsCvarData GSSdkEnvServerUrlListCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkEnvServerUrlList", "http://gssdk.b1.gamesci.com.cn:9812", ""));

	private static GsCvarData GSSdkAppChannelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkAppChannel", "gamesci", ""));

	private static GsCvarData GSSdkLoginChannelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkLoginChannel", "gamesci", ""));

	private static GsCvarData GSSdkLoginSubChannelCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkLoginSubChannel", "", ""));

	private static GsCvarData GSSdkPackageTagsCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.GSSdkPackageTags", "", ""));

	private static GsCvarData SentryDSNCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryDSN", "http://bdca0e842c6806e70e718e79641b3fbf@sentry.gs.com/6", ""));

	private static GsCvarData SentryHostBackupCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentryHostBackup", "heishenhua.com:gamesci.com.cn", ""));

	private static GsCvarData SentrySampleRateCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.SentrySampleRate", "1.0", ""));

	private static GsCvarData MagicCheckOverlayCVData = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DebugConfig.MagicCheckOverlay", "", ""));

	public static bool ArchiveRefactor
	{
		get
		{
			return ArchiveRefactorCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ArchiveRefactorCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugWidget
	{
		get
		{
			return DebugWidgetCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugWidgetCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ILRuntime
	{
		get
		{
			return ILRuntimeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ILRuntimeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ILRuntimeJITOnDemand
	{
		get
		{
			return ILRuntimeJITOnDemandCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ILRuntimeJITOnDemandCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Clrbinding
	{
		get
		{
			return ClrbindingCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ClrbindingCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ILRuntimeDebugger
	{
		get
		{
			return ILRuntimeDebuggerCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ILRuntimeDebuggerCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableRtx
	{
		get
		{
			return EnableRtxCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableRtxCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Report820Windows
	{
		get
		{
			return Report820WindowsCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Report820WindowsCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ManualBuiGC
	{
		get
		{
			return ManualBuiGCCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ManualBuiGCCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Report820PS5
	{
		get
		{
			return Report820PS5CVData.GetValueInGameThread() == 1;
		}
		set
		{
			Report820PS5CVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Report820XSX
	{
		get
		{
			return Report820XSXCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Report820XSXCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Report820WindowsRealtime
	{
		get
		{
			return Report820WindowsRealtimeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Report820WindowsRealtimeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ArchiveBackup
	{
		get
		{
			return ArchiveBackupCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ArchiveBackupCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OverridePlayerLogMaxSize
	{
		get
		{
			return OverridePlayerLogMaxSizeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OverridePlayerLogMaxSizeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugCFSMG
	{
		get
		{
			return DebugCFSMGCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugCFSMGCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SimTimeMarkBase
	{
		get
		{
			return SimTimeMarkBaseCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SimTimeMarkBaseCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SimTimeMarkStep
	{
		get
		{
			return SimTimeMarkStepCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SimTimeMarkStepCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Navigation
	{
		get
		{
			return NavigationCVData.GetValueInGameThread() == 1;
		}
		set
		{
			NavigationCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Intimidation
	{
		get
		{
			return IntimidationCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IntimidationCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenSeparateFrameEntityBeginPlay
	{
		get
		{
			return OpenSeparateFrameEntityBeginPlayCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenSeparateFrameEntityBeginPlayCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool InteractiveObj
	{
		get
		{
			return InteractiveObjCVData.GetValueInGameThread() == 1;
		}
		set
		{
			InteractiveObjCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DrawSimpleOverlapDebug
	{
		get
		{
			return DrawSimpleOverlapDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DrawSimpleOverlapDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ProfilerSimpleOverlap
	{
		get
		{
			return ProfilerSimpleOverlapCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ProfilerSimpleOverlapCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool TopdownBattleMode
	{
		get
		{
			return TopdownBattleModeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			TopdownBattleModeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsTmpTestFlag
	{
		get
		{
			return IsTmpTestFlagCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsTmpTestFlagCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenNewChapterPlayerSafeLocation
	{
		get
		{
			return OpenNewChapterPlayerSafeLocationCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenNewChapterPlayerSafeLocationCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsLiteBuild
	{
		get
		{
			return IsLiteBuildCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsLiteBuildCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenGSRepLog
	{
		get
		{
			return OpenGSRepLogCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenGSRepLogCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ClientReset
	{
		get
		{
			return ClientResetCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ClientResetCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ProfileEnable
	{
		get
		{
			return ProfileEnableCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ProfileEnableCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Enablepreload
	{
		get
		{
			return EnablepreloadCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnablepreloadCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool CantCloseNetConnectWithError
	{
		get
		{
			return CantCloseNetConnectWithErrorCVData.GetValueInGameThread() == 1;
		}
		set
		{
			CantCloseNetConnectWithErrorCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SkipRoleDataCheck
	{
		get
		{
			return SkipRoleDataCheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SkipRoleDataCheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableMoveSpeedInfoDebug
	{
		get
		{
			return EnableMoveSpeedInfoDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableMoveSpeedInfoDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnablePrintJXSQCheckerResult
	{
		get
		{
			return EnablePrintJXSQCheckerResultCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnablePrintJXSQCheckerResultCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableChapterRoamV2
	{
		get
		{
			return EnableChapterRoamV2CVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableChapterRoamV2CVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ChapterDebug
	{
		get
		{
			return ChapterDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ChapterDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableShrineAllFunc
	{
		get
		{
			return EnableShrineAllFuncCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableShrineAllFuncCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableInteractAllFunc
	{
		get
		{
			return EnableInteractAllFuncCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableInteractAllFuncCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DisableSkipInteractFunc
	{
		get
		{
			return DisableSkipInteractFuncCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DisableSkipInteractFuncCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DisableSkipMontageInteractFunc
	{
		get
		{
			return DisableSkipMontageInteractFuncCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DisableSkipMontageInteractFuncCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SpawnWaveDebug
	{
		get
		{
			return SpawnWaveDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SpawnWaveDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool BPNeutralAnimalDebug
	{
		get
		{
			return BPNeutralAnimalDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			BPNeutralAnimalDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool PureVersion
	{
		get
		{
			return PureVersionCVData.GetValueInGameThread() == 1;
		}
		set
		{
			PureVersionCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool PreOrderAwardDebug
	{
		get
		{
			return PreOrderAwardDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			PreOrderAwardDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DeluxeAwardDebug
	{
		get
		{
			return DeluxeAwardDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DeluxeAwardDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DisableRpcLog
	{
		get
		{
			return DisableRpcLogCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DisableRpcLogCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ActiveAllUI
	{
		get
		{
			return ActiveAllUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			ActiveAllUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Open1080Check
	{
		get
		{
			return Open1080CheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Open1080CheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSDisableLoadingScreen
	{
		get
		{
			return GSDisableLoadingScreenCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSDisableLoadingScreenCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OnlyOpenPVUI
	{
		get
		{
			return OnlyOpenPVUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			OnlyOpenPVUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool AdvanceDropManualClose
	{
		get
		{
			return AdvanceDropManualCloseCVData.GetValueInGameThread() == 1;
		}
		set
		{
			AdvanceDropManualCloseCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool InputDebugInfo
	{
		get
		{
			return InputDebugInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			InputDebugInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool InputDebug_Window
	{
		get
		{
			return InputDebug_WindowCVData.GetValueInGameThread() == 1;
		}
		set
		{
			InputDebug_WindowCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool InputDebug_KeyCache
	{
		get
		{
			return InputDebug_KeyCacheCVData.GetValueInGameThread() == 1;
		}
		set
		{
			InputDebug_KeyCacheCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GroupAI
	{
		get
		{
			return GroupAICVData.GetValueInGameThread() == 1;
		}
		set
		{
			GroupAICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool AIInfo
	{
		get
		{
			return AIInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			AIInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool TeamInfo
	{
		get
		{
			return TeamInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			TeamInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool FollowPartnerDispInfo
	{
		get
		{
			return FollowPartnerDispInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			FollowPartnerDispInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool TargetInfo
	{
		get
		{
			return TargetInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			TargetInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool HatredInfo
	{
		get
		{
			return HatredInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			HatredInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool AINodeDebug
	{
		get
		{
			return AINodeDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			AINodeDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ABPHelperInfo
	{
		get
		{
			return ABPHelperInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ABPHelperInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OnlineAttr
	{
		get
		{
			return OnlineAttrCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OnlineAttrCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OnlineUnitState
	{
		get
		{
			return OnlineUnitStateCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OnlineUnitStateCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugDS
	{
		get
		{
			return IsDebugDSCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugDSCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ConnectionInfo
	{
		get
		{
			return ConnectionInfoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ConnectionInfoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool PlayerDebugDraw
	{
		get
		{
			return PlayerDebugDrawCVData.GetValueInGameThread() == 1;
		}
		set
		{
			PlayerDebugDrawCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenNetConnectDebugUI
	{
		get
		{
			return OpenNetConnectDebugUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenNetConnectDebugUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugGSRepRole
	{
		get
		{
			return DebugGSRepRoleCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugGSRepRoleCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenEventDebugger
	{
		get
		{
			return OpenEventDebuggerCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenEventDebuggerCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugAKB
	{
		get
		{
			return IsDebugAKBCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugAKBCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugUISys
	{
		get
		{
			return IsDebugUISysCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugUISysCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugUIMore
	{
		get
		{
			return IsDebugUIMoreCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugUIMoreCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugUIProc
	{
		get
		{
			return IsDebugUIProcCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugUIProcCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugWidgetMore
	{
		get
		{
			return IsDebugWidgetMoreCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugWidgetMoreCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugButton
	{
		get
		{
			return IsDebugButtonCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugButtonCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugAutoSizeScrollBox
	{
		get
		{
			return IsDebugAutoSizeScrollBoxCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugAutoSizeScrollBoxCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugWidgetProfile
	{
		get
		{
			return IsDebugWidgetProfileCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugWidgetProfileCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsDebugUITick
	{
		get
		{
			return IsDebugUITickCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsDebugUITickCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsOpenStatGSCustom
	{
		get
		{
			return IsOpenStatGSCustomCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsOpenStatGSCustomCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsShowDebugDrawUI
	{
		get
		{
			return IsShowDebugDrawUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsShowDebugDrawUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugPhaseCSG
	{
		get
		{
			return DebugPhaseCSGCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugPhaseCSGCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsOpenBattleInfoTool
	{
		get
		{
			return IsOpenBattleInfoToolCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsOpenBattleInfoToolCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool CancelSkillCD
	{
		get
		{
			return CancelSkillCDCVData.GetValueInGameThread() == 1;
		}
		set
		{
			CancelSkillCDCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugMap
	{
		get
		{
			return DebugMapCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugMapCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ShowChrEnvMaskValue
	{
		get
		{
			return ShowChrEnvMaskValueCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ShowChrEnvMaskValueCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsOpenRemoteTestCheat
	{
		get
		{
			return IsOpenRemoteTestCheatCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsOpenRemoteTestCheatCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsIgnoreValidateData
	{
		get
		{
			return IsIgnoreValidateDataCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsIgnoreValidateDataCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EventMemoryLeakTest
	{
		get
		{
			return EventMemoryLeakTestCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EventMemoryLeakTestCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool TickEventMemoryLeakTest
	{
		get
		{
			return TickEventMemoryLeakTestCVData.GetValueInGameThread() == 1;
		}
		set
		{
			TickEventMemoryLeakTestCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ObjMemoryLeakTest
	{
		get
		{
			return ObjMemoryLeakTestCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ObjMemoryLeakTestCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool MemoryLeakTestCacheObj
	{
		get
		{
			return MemoryLeakTestCacheObjCVData.GetValueInGameThread() == 1;
		}
		set
		{
			MemoryLeakTestCacheObjCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugStartWithOutArchive
	{
		get
		{
			return DebugStartWithOutArchiveCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugStartWithOutArchiveCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableSelectChapter
	{
		get
		{
			return EnableSelectChapterCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableSelectChapterCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool CanOptimizeTick
	{
		get
		{
			return CanOptimizeTickCVData.GetValueInGameThread() == 1;
		}
		set
		{
			CanOptimizeTickCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Debug820Demo
	{
		get
		{
			return Debug820DemoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Debug820DemoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Demo820OverSeaVersion
	{
		get
		{
			return Demo820OverSeaVersionCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Demo820OverSeaVersionCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Demo820DebugTest
	{
		get
		{
			return Demo820DebugTestCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Demo820DebugTestCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Demo820UseSetting
	{
		get
		{
			return Demo820UseSettingCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Demo820UseSettingCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugFristStartGameSetting
	{
		get
		{
			return DebugFristStartGameSettingCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugFristStartGameSettingCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenSeamlessLevelTravel
	{
		get
		{
			return OpenSeamlessLevelTravelCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenSeamlessLevelTravelCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Demo820ExceptionUI
	{
		get
		{
			return Demo820ExceptionUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			Demo820ExceptionUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Demo820IgnoreAllOverlap
	{
		get
		{
			return Demo820IgnoreAllOverlapCVData.GetValueInGameThread() == 1;
		}
		set
		{
			Demo820IgnoreAllOverlapCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugPlayerTransLog
	{
		get
		{
			return DebugPlayerTransLogCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugPlayerTransLogCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool CricketBattleMode
	{
		get
		{
			return CricketBattleModeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			CricketBattleModeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool CricketReportServer
	{
		get
		{
			return CricketReportServerCVData.GetValueInGameThread() == 1;
		}
		set
		{
			CricketReportServerCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugSettingLog
	{
		get
		{
			return DebugSettingLogCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugSettingLogCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool NeedGSSDKUserCheck
	{
		get
		{
			return NeedGSSDKUserCheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			NeedGSSDKUserCheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugTransGuideUI
	{
		get
		{
			return DebugTransGuideUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugTransGuideUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool LQALanguage
	{
		get
		{
			return LQALanguageCVData.GetValueInGameThread() == 1;
		}
		set
		{
			LQALanguageCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSIsGlobalColorDeficiency
	{
		get
		{
			return GSIsGlobalColorDeficiencyCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSIsGlobalColorDeficiencyCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugGameIntent
	{
		get
		{
			return DebugGameIntentCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugGameIntentCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ShowLoadingTimeText
	{
		get
		{
			return ShowLoadingTimeTextCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ShowLoadingTimeTextCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsNeedPsoPrecompileWhenStartGame
	{
		get
		{
			return IsNeedPsoPrecompileWhenStartGameCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsNeedPsoPrecompileWhenStartGameCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsNeedPreStartGameProcess
	{
		get
		{
			return IsNeedPreStartGameProcessCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsNeedPreStartGameProcessCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DisableInputMessage
	{
		get
		{
			return DisableInputMessageCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DisableInputMessageCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableUseNewTimelineForCPG
	{
		get
		{
			return EnableUseNewTimelineForCPGCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableUseNewTimelineForCPGCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugPlayGo
	{
		get
		{
			return DebugPlayGoCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugPlayGoCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnablePlaneMoveMode
	{
		get
		{
			return EnablePlaneMoveModeCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnablePlaneMoveModeCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugPlayerGuide
	{
		get
		{
			return DebugPlayerGuideCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugPlayerGuideCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugNewGamePlusGuide
	{
		get
		{
			return DebugNewGamePlusGuideCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugNewGamePlusGuideCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugBossRushGuide
	{
		get
		{
			return DebugBossRushGuideCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugBossRushGuideCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugMapGuide
	{
		get
		{
			return DebugMapGuideCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugMapGuideCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugDonutAudio
	{
		get
		{
			return DebugDonutAudioCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugDonutAudioCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool IsOverSeaChannel
	{
		get
		{
			return IsOverSeaChannelCVData.GetValueInGameThread() == 1;
		}
		set
		{
			IsOverSeaChannelCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableEncrypt
	{
		get
		{
			return EnableEncryptCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableEncryptCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SettingHostSimulation
	{
		get
		{
			return SettingHostSimulationCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SettingHostSimulationCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SettingEditorSimulation
	{
		get
		{
			return SettingEditorSimulationCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SettingEditorSimulationCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DevArchiveSizeCheck
	{
		get
		{
			return DevArchiveSizeCheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DevArchiveSizeCheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DisableDissolveDisplay
	{
		get
		{
			return DisableDissolveDisplayCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DisableDissolveDisplayCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ExceptionShowBtn
	{
		get
		{
			return ExceptionShowBtnCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ExceptionShowBtnCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ThrowException
	{
		get
		{
			return ThrowExceptionCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ThrowExceptionCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugSettingCvar
	{
		get
		{
			return DebugSettingCvarCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugSettingCvarCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugReInitRoleCheck
	{
		get
		{
			return DebugReInitRoleCheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugReInitRoleCheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DebugCollection
	{
		get
		{
			return DebugCollectionCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DebugCollectionCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ButtonMatSyncCheck
	{
		get
		{
			return ButtonMatSyncCheckCVData.GetValueInGameThread() == 1;
		}
		set
		{
			ButtonMatSyncCheckCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenPastMemory
	{
		get
		{
			return OpenPastMemoryCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenPastMemoryCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenSimpleTips
	{
		get
		{
			return OpenSimpleTipsCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenSimpleTipsCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool OpenLocalizationInEditor
	{
		get
		{
			return OpenLocalizationInEditorCVData.GetValueInGameThread() == 1;
		}
		set
		{
			OpenLocalizationInEditorCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EnableEnhancedInputDelay
	{
		get
		{
			return EnableEnhancedInputDelayCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EnableEnhancedInputDelayCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EndingCreditsUseJson
	{
		get
		{
			return EndingCreditsUseJsonCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EndingCreditsUseJsonCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool HideMiniGMSequenceTab
	{
		get
		{
			return HideMiniGMSequenceTabCVData.GetValueInGameThread() == 1;
		}
		set
		{
			HideMiniGMSequenceTabCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSWithBink
	{
		get
		{
			return GSWithBinkCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSWithBinkCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool BenckMarkOnly
	{
		get
		{
			return BenckMarkOnlyCVData.GetValueInGameThread() == 1;
		}
		set
		{
			BenckMarkOnlyCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool BenckMarkLoop
	{
		get
		{
			return BenckMarkLoopCVData.GetValueInGameThread() == 1;
		}
		set
		{
			BenckMarkLoopCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DamageLogic
	{
		get
		{
			return DamageLogicCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DamageLogicCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool DropItem
	{
		get
		{
			return DropItemCVData.GetValueInGameThread() == 1;
		}
		set
		{
			DropItemCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool Secret
	{
		get
		{
			return SecretCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SecretCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool EntitySharedRefLeakDetect
	{
		get
		{
			return EntitySharedRefLeakDetectCVData.GetValueInGameThread() == 1;
		}
		set
		{
			EntitySharedRefLeakDetectCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool TaskGroup
	{
		get
		{
			return TaskGroupCVData.GetValueInGameThread() == 1;
		}
		set
		{
			TaskGroupCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool NPC
	{
		get
		{
			return NPCCVData.GetValueInGameThread() == 1;
		}
		set
		{
			NPCCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool ActiveManageUI
	{
		get
		{
			return ActiveManageUICVData.GetValueInGameThread() == 1;
		}
		set
		{
			ActiveManageUICVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GymModeInWindows
	{
		get
		{
			return GymModeInWindowsCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GymModeInWindowsCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkEnableCETesting
	{
		get
		{
			return GSSdkEnableCETestingCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkEnableCETestingCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool KAServerUseTcp
	{
		get
		{
			return KAServerUseTcpCVData.GetValueInGameThread() == 1;
		}
		set
		{
			KAServerUseTcpCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool NeedLauncher
	{
		get
		{
			return NeedLauncherCVData.GetValueInGameThread() == 1;
		}
		set
		{
			NeedLauncherCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool HideCrashReportClientUi
	{
		get
		{
			return HideCrashReportClientUiCVData.GetValueInGameThread() == 1;
		}
		set
		{
			HideCrashReportClientUiCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkReportUseCSharpHttp
	{
		get
		{
			return GSSdkReportUseCSharpHttpCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkReportUseCSharpHttpCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkReportUseAsyncHttp
	{
		get
		{
			return GSSdkReportUseAsyncHttpCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkReportUseAsyncHttpCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkReportEnable
	{
		get
		{
			return GSSdkReportEnableCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkReportEnableCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkReportDisableHttpRequest
	{
		get
		{
			return GSSdkReportDisableHttpRequestCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkReportDisableHttpRequestCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkEnableSensDataClean
	{
		get
		{
			return GSSdkEnableSensDataCleanCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkEnableSensDataCleanCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkEnableMonitor
	{
		get
		{
			return GSSdkEnableMonitorCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkEnableMonitorCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool GSSdkEnablePerf
	{
		get
		{
			return GSSdkEnablePerfCVData.GetValueInGameThread() == 1;
		}
		set
		{
			GSSdkEnablePerfCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SentryDebug
	{
		get
		{
			return SentryDebugCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SentryDebugCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SentryEnable
	{
		get
		{
			return SentryEnableCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SentryEnableCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SentryEnableTracing
	{
		get
		{
			return SentryEnableTracingCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SentryEnableTracingCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SentryCaptureFailRequests
	{
		get
		{
			return SentryCaptureFailRequestsCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SentryCaptureFailRequestsCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static bool SentryUseLocalCacheFile
	{
		get
		{
			return SentryUseLocalCacheFileCVData.GetValueInGameThread() == 1;
		}
		set
		{
			SentryUseLocalCacheFileCVData.SetInt(value ? 1 : 0, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int PlatformEventSendIntervalMilliSecond
	{
		get
		{
			return PlatformEventSendIntervalMilliSecondCVData.GetValueInGameThread();
		}
		set
		{
			PlatformEventSendIntervalMilliSecondCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int PlatformEventTimeoutMilliSecond
	{
		get
		{
			return PlatformEventTimeoutMilliSecondCVData.GetValueInGameThread();
		}
		set
		{
			PlatformEventTimeoutMilliSecondCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int PlayerLogMaxSize
	{
		get
		{
			return PlayerLogMaxSizeCVData.GetValueInGameThread();
		}
		set
		{
			PlayerLogMaxSizeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int ReportTimeout
	{
		get
		{
			return ReportTimeoutCVData.GetValueInGameThread();
		}
		set
		{
			ReportTimeoutCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int UseDebugTamerConfig
	{
		get
		{
			return UseDebugTamerConfigCVData.GetValueInGameThread();
		}
		set
		{
			UseDebugTamerConfigCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int HideLockTarget
	{
		get
		{
			return HideLockTargetCVData.GetValueInGameThread();
		}
		set
		{
			HideLockTargetCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int EventWarningLevel
	{
		get
		{
			return EventWarningLevelCVData.GetValueInGameThread();
		}
		set
		{
			EventWarningLevelCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int DebugOnlineLevelId
	{
		get
		{
			return DebugOnlineLevelIdCVData.GetValueInGameThread();
		}
		set
		{
			DebugOnlineLevelIdCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int UITickProfileLevel
	{
		get
		{
			return UITickProfileLevelCVData.GetValueInGameThread();
		}
		set
		{
			UITickProfileLevelCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int CollectionForceType
	{
		get
		{
			return CollectionForceTypeCVData.GetValueInGameThread();
		}
		set
		{
			CollectionForceTypeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int LockDesiredPlayerHP
	{
		get
		{
			return LockDesiredPlayerHPCVData.GetValueInGameThread();
		}
		set
		{
			LockDesiredPlayerHPCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int FSRCrashOptions
	{
		get
		{
			return FSRCrashOptionsCVData.GetValueInGameThread();
		}
		set
		{
			FSRCrashOptionsCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int Demo820PlayCountMax
	{
		get
		{
			return Demo820PlayCountMaxCVData.GetValueInGameThread();
		}
		set
		{
			Demo820PlayCountMaxCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int CricketBattleModeType
	{
		get
		{
			return CricketBattleModeTypeCVData.GetValueInGameThread();
		}
		set
		{
			CricketBattleModeTypeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int LoadingMaxTime
	{
		get
		{
			return LoadingMaxTimeCVData.GetValueInGameThread();
		}
		set
		{
			LoadingMaxTimeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int LoadingMaxTimeShowTips
	{
		get
		{
			return LoadingMaxTimeShowTipsCVData.GetValueInGameThread();
		}
		set
		{
			LoadingMaxTimeShowTipsCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int EnsureReportInterval
	{
		get
		{
			return EnsureReportIntervalCVData.GetValueInGameThread();
		}
		set
		{
			EnsureReportIntervalCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int DevArchiveSizeMax
	{
		get
		{
			return DevArchiveSizeMaxCVData.GetValueInGameThread();
		}
		set
		{
			DevArchiveSizeMaxCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int DebugOverSeaType
	{
		get
		{
			return DebugOverSeaTypeCVData.GetValueInGameThread();
		}
		set
		{
			DebugOverSeaTypeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int WaitMSToThrowException
	{
		get
		{
			return WaitMSToThrowExceptionCVData.GetValueInGameThread();
		}
		set
		{
			WaitMSToThrowExceptionCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int UpdateUserConfigInterval
	{
		get
		{
			return UpdateUserConfigIntervalCVData.GetValueInGameThread();
		}
		set
		{
			UpdateUserConfigIntervalCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int DebugGameCount
	{
		get
		{
			return DebugGameCountCVData.GetValueInGameThread();
		}
		set
		{
			DebugGameCountCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int WeaponBuildMode
	{
		get
		{
			return WeaponBuildModeCVData.GetValueInGameThread();
		}
		set
		{
			WeaponBuildModeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int EnhancedInputDelayTime
	{
		get
		{
			return EnhancedInputDelayTimeCVData.GetValueInGameThread();
		}
		set
		{
			EnhancedInputDelayTimeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int EnhancedInputSpecialDelayTime
	{
		get
		{
			return EnhancedInputSpecialDelayTimeCVData.GetValueInGameThread();
		}
		set
		{
			EnhancedInputSpecialDelayTimeCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int MediaPlayerSyncToleranceMS
	{
		get
		{
			return MediaPlayerSyncToleranceMSCVData.GetValueInGameThread();
		}
		set
		{
			MediaPlayerSyncToleranceMSCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int MediaPlayerSyncCDMS
	{
		get
		{
			return MediaPlayerSyncCDMSCVData.GetValueInGameThread();
		}
		set
		{
			MediaPlayerSyncCDMSCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int BenckMarkGPULow
	{
		get
		{
			return BenckMarkGPULowCVData.GetValueInGameThread();
		}
		set
		{
			BenckMarkGPULowCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int ForceEnableDebugGMFlags
	{
		get
		{
			return ForceEnableDebugGMFlagsCVData.GetValueInGameThread();
		}
		set
		{
			ForceEnableDebugGMFlagsCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int KAServerPort
	{
		get
		{
			return KAServerPortCVData.GetValueInGameThread();
		}
		set
		{
			KAServerPortCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int GSSdkReportMergeBatchEventNum
	{
		get
		{
			return GSSdkReportMergeBatchEventNumCVData.GetValueInGameThread();
		}
		set
		{
			GSSdkReportMergeBatchEventNumCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static int GSSdkReportMergeBatchIntervalSeconds
	{
		get
		{
			return GSSdkReportMergeBatchIntervalSecondsCVData.GetValueInGameThread();
		}
		set
		{
			GSSdkReportMergeBatchIntervalSecondsCVData.SetInt(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string EnableAllGMCMDAndDebug
	{
		get
		{
			return EnableAllGMCMDAndDebugCVData.GetString();
		}
		set
		{
			EnableAllGMCMDAndDebugCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string CESetRealBranchName
	{
		get
		{
			return CESetRealBranchNameCVData.GetString();
		}
		set
		{
			CESetRealBranchNameCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string RoomServerConnectAddr
	{
		get
		{
			return RoomServerConnectAddrCVData.GetString();
		}
		set
		{
			RoomServerConnectAddrCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string DebugDrawTag
	{
		get
		{
			return DebugDrawTagCVData.GetString();
		}
		set
		{
			DebugDrawTagCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string B1DeluxeAddOnId
	{
		get
		{
			return B1DeluxeAddOnIdCVData.GetString();
		}
		set
		{
			B1DeluxeAddOnIdCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string B1PrePurchaseAddOnId
	{
		get
		{
			return B1PrePurchaseAddOnIdCVData.GetString();
		}
		set
		{
			B1PrePurchaseAddOnIdCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string FileIOStrategy
	{
		get
		{
			return FileIOStrategyCVData.GetString();
		}
		set
		{
			FileIOStrategyCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string DebugRtxEnableLevel
	{
		get
		{
			return DebugRtxEnableLevelCVData.GetString();
		}
		set
		{
			DebugRtxEnableLevelCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string FAQWebsiteLink
	{
		get
		{
			return FAQWebsiteLinkCVData.GetString();
		}
		set
		{
			FAQWebsiteLinkCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string FileMd5CheckIgnorePathPattern
	{
		get
		{
			return FileMd5CheckIgnorePathPatternCVData.GetString();
		}
		set
		{
			FileMd5CheckIgnorePathPatternCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string KAServerHost
	{
		get
		{
			return KAServerHostCVData.GetString();
		}
		set
		{
			KAServerHostCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string KAExtraId
	{
		get
		{
			return KAExtraIdCVData.GetString();
		}
		set
		{
			KAExtraIdCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string DevGamesciLoginServerUrl
	{
		get
		{
			return DevGamesciLoginServerUrlCVData.GetString();
		}
		set
		{
			DevGamesciLoginServerUrlCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string Environment
	{
		get
		{
			return EnvironmentCVData.GetString();
		}
		set
		{
			EnvironmentCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkCDNRootUrlList
	{
		get
		{
			return GSSdkCDNRootUrlListCVData.GetString();
		}
		set
		{
			GSSdkCDNRootUrlListCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkEnvServerUrlList
	{
		get
		{
			return GSSdkEnvServerUrlListCVData.GetString();
		}
		set
		{
			GSSdkEnvServerUrlListCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkAppChannel
	{
		get
		{
			return GSSdkAppChannelCVData.GetString();
		}
		set
		{
			GSSdkAppChannelCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkLoginChannel
	{
		get
		{
			return GSSdkLoginChannelCVData.GetString();
		}
		set
		{
			GSSdkLoginChannelCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkLoginSubChannel
	{
		get
		{
			return GSSdkLoginSubChannelCVData.GetString();
		}
		set
		{
			GSSdkLoginSubChannelCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string GSSdkPackageTags
	{
		get
		{
			return GSSdkPackageTagsCVData.GetString();
		}
		set
		{
			GSSdkPackageTagsCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string SentryDSN
	{
		get
		{
			return SentryDSNCVData.GetString();
		}
		set
		{
			SentryDSNCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string SentryHostBackup
	{
		get
		{
			return SentryHostBackupCVData.GetString();
		}
		set
		{
			SentryHostBackupCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string SentrySampleRate
	{
		get
		{
			return SentrySampleRateCVData.GetString();
		}
		set
		{
			SentrySampleRateCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}

	public static string MagicCheckOverlay
	{
		get
		{
			return MagicCheckOverlayCVData.GetString();
		}
		set
		{
			MagicCheckOverlayCVData.SetString(value, EConsoleVariableFlags.SetByGameSetting);
		}
	}
}
