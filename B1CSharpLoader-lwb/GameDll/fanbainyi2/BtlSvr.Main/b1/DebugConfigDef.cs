using UnrealEngine.Runtime;

namespace b1;

internal static class DebugConfigDef
{
	[Category("DebugConfig")]
	[DisplayName("ArchiveRefactor")]
	[Tooltip("ArchiveRefactor")]
	public static bool ArchiveRefactor = false;

	[Tooltip("DebugWidget")]
	[DisplayName("DebugWidget")]
	[Category("DebugConfig")]
	public static bool DebugWidget = false;

	[DisplayName("ILRuntime")]
	[Tooltip("ILRuntime")]
	[Category("DebugConfig")]
	public static bool ILRuntime = true;

	[Tooltip("ILRuntime")]
	[DisplayName("ILRuntimeJITOnDemand")]
	[Category("DebugConfig")]
	public static bool ILRuntimeJITOnDemand = false;

	[Tooltip("Clrbinding")]
	[DisplayName("Clrbinding")]
	[Category("DebugConfig")]
	public static bool Clrbinding = false;

	[Category("DebugConfig")]
	[DisplayName("ILRuntimeDebugger")]
	[Tooltip("ILRuntimeDebugger")]
	public static bool ILRuntimeDebugger = false;

	[Category("DebugConfig")]
	[DisplayName("PlatformEventSendIntervalMilliSecond")]
	[Tooltip("PlatformEventSendIntervalMilliSecond")]
	public static int PlatformEventSendIntervalMilliSecond = 2000;

	[Tooltip("PlatformEventTimeoutMilliSecond")]
	[DisplayName("PlatformEventTimeoutMilliSecond")]
	[Category("DebugConfig")]
	public static int PlatformEventTimeoutMilliSecond = 60000;

	[Tooltip("允许开启光追")]
	[DisplayName("允许开启光追")]
	[Category("DebugConfig")]
	public static bool EnableRtx = false;

	[Tooltip("Report820Windows")]
	[DisplayName("Report820Windows")]
	[Category("DebugConfig")]
	public static bool Report820Windows = false;

	[Category("DebugConfig")]
	[Tooltip("ManualBuiGC")]
	[DisplayName("ManualBuiGC")]
	public static bool ManualBuiGC = false;

	[Tooltip("Report820PS5")]
	[DisplayName("Report820PS5")]
	[Category("DebugConfig")]
	public static bool Report820PS5 = false;

	[Tooltip("Report820XSX")]
	[DisplayName("Report820XSX")]
	[Category("DebugConfig")]
	public static bool Report820XSX = false;

	[Tooltip("Report820WindowsRealtime")]
	[DisplayName("Report820WindowsRealtime")]
	[Category("DebugConfig")]
	public static bool Report820WindowsRealtime = true;

	[Category("DebugConfig")]
	[DisplayName("ArchiveBackup")]
	[Tooltip("ArchiveBackup")]
	public static bool ArchiveBackup = true;

	[Tooltip("PlayerLogMaxSize")]
	[DisplayName("PlayerLogMaxSize")]
	[Category("DebugConfig")]
	public static int PlayerLogMaxSize = 50;

	[Tooltip("OverridePlayerLogMaxSize")]
	[DisplayName("OverridePlayerLogMaxSize")]
	[Category("DebugConfig")]
	public static bool OverridePlayerLogMaxSize = false;

	[Tooltip("ReportTimeout")]
	[DisplayName("ReportTimeout")]
	[Category("DebugConfig")]
	public static int ReportTimeout = 10;

	[Tooltip("DebugCFSMG")]
	[DisplayName("DebugCFSMG")]
	[Category("DebugConfig")]
	public static bool DebugCFSMG = false;

	[DisplayName("SimTimeMarkBase")]
	[Category("DebugConfig")]
	[Tooltip("SimTimeMarkBase")]
	public static bool SimTimeMarkBase = false;

	[Category("DebugConfig")]
	[DisplayName("SimTimeMarkStep")]
	[Tooltip("SimTimeMarkStep")]
	public static bool SimTimeMarkStep = false;

	[Category("DebugConfig")]
	[DisplayName("Navigation")]
	[Tooltip("展示引导功能的log信息")]
	public static bool Navigation = false;

	[Tooltip("Intimidation")]
	[DisplayName("Intimidation")]
	[Category("DebugConfig")]
	public static bool Intimidation = false;

	[DisplayName("分帧BeginPlay")]
	[Tooltip("分帧BeginPlay")]
	[Category("DebugConfig")]
	public static bool OpenSeparateFrameEntityBeginPlay = true;

	[Tooltip("InteractiveObj")]
	[Category("DebugConfig")]
	[DisplayName("InteractiveObj")]
	public static bool InteractiveObj = false;

	[DisplayName("DrawSimpleOverlapDebug")]
	[Category("DebugConfig")]
	[Tooltip("DrawSimpleOverlapDebug")]
	public static bool DrawSimpleOverlapDebug = false;

	[Category("DebugConfig")]
	[Tooltip("ProfilerSimpleOverlap")]
	[DisplayName("ProfilerSimpleOverlap")]
	public static bool ProfilerSimpleOverlap = false;

	[Tooltip("TopdownBattleMode")]
	[DisplayName("TopdownBattleMode")]
	[Category("DebugConfig")]
	public static bool TopdownBattleMode = false;

	[Category("DebugConfig")]
	[DisplayName("IsTmpTestFlag")]
	[Tooltip("IsTmpTestFlag")]
	public static bool IsTmpTestFlag = false;

	[Tooltip("开启章节中转时把玩家设置到安全位置")]
	[Category("DebugConfig")]
	[DisplayName("OpenNewChapterPlayerSafeLocation")]
	public static bool OpenNewChapterPlayerSafeLocation = true;

	[DisplayName("IsLiteBuild")]
	[Tooltip("IsLiteBuild")]
	[Category("DebugConfig")]
	public static bool IsLiteBuild = false;

	[Category("DebugConfig")]
	[DisplayName("OpenGSRepLog")]
	[Tooltip("OpenGSRepLog")]
	public static bool OpenGSRepLog = false;

	[Category("DebugConfig")]
	[DisplayName("ClientReset")]
	[Tooltip("ClientReset")]
	public static bool ClientReset = true;

	[Category("DebugConfig")]
	[Tooltip("")]
	[DisplayName("EnableAllGMCMDAndDebug")]
	public static string EnableAllGMCMDAndDebug = "b.WTF";

	[Category("DebugConfig")]
	[Tooltip("CESetRealBranchName")]
	[DisplayName("CESetRealBranchName")]
	public static string CESetRealBranchName = "";

	[Category("DebugConfig")]
	[DisplayName("ProfileEnable")]
	[Tooltip("ProfileEnable")]
	public static bool ProfileEnable = false;

	[Category("DebugConfig")]
	[DisplayName("Enablepreload")]
	[Tooltip("开启预加载")]
	public static bool Enablepreload = false;

	[Category("DebugConfig")]
	[DisplayName("UseDebugTamerConfig")]
	[Tooltip("UseDebugTamerConfig")]
	public static int UseDebugTamerConfig = 0;

	[Category("DebugConfig")]
	[DisplayName("CantCloseNetConnectWithError")]
	[Tooltip("联机下主机报错客户端不弹回浮屠塔")]
	public static bool CantCloseNetConnectWithError = false;

	[Tooltip("跳过角色数据检查")]
	[Category("DebugConfig")]
	[DisplayName("SkipRoleDataCheck")]
	public static bool SkipRoleDataCheck = false;

	[Category("DebugConfig")]
	[Tooltip("移动速度信息Debug")]
	[DisplayName("EnableMoveSpeedInfoDebug")]
	public static bool EnableMoveSpeedInfoDebug = false;

	[Tooltip("打印JXSQ释放信息Log")]
	[DisplayName("EnablePrintJXSQCheckerResult")]
	[Category("DebugConfig")]
	public static bool EnablePrintJXSQCheckerResult = false;

	[Tooltip("章节漫游第二套方案")]
	[DisplayName("EnableChapterRoamV2")]
	[Category("DebugConfig")]
	public static bool EnableChapterRoamV2 = false;

	[Tooltip("章节中转Debug")]
	[DisplayName("ChapterDebug")]
	[Category("DebugConfig")]
	public static bool ChapterDebug = false;

	[Tooltip("开启土地庙所有功能")]
	[DisplayName("EnableShrineAllFunc")]
	[Category("DebugConfig")]
	public static bool EnableShrineAllFunc = false;

	[Category("DebugConfig")]
	[DisplayName("EnableInteractAllFunc")]
	[Tooltip("开启NPC交互所有功能")]
	public static bool EnableInteractAllFunc = false;

	[Tooltip("关闭跳过交互功能")]
	[DisplayName("DisableSkipInteractFunc")]
	[Category("DebugConfig")]
	public static bool DisableSkipInteractFunc = false;

	[Tooltip("关闭动画交互短句跳过功能")]
	[DisplayName("DisableSkipMontageInteractFunc")]
	[Category("DebugConfig")]
	public static bool DisableSkipMontageInteractFunc = false;

	[Tooltip("SpawnWave_Debug")]
	[DisplayName("SpawnWave_Debug")]
	[Category("DebugConfig")]
	public static bool SpawnWaveDebug = false;

	[Tooltip("蓝图中立生物生成器Debug")]
	[DisplayName("蓝图中立生物生成器Debug")]
	[Category("DebugConfig")]
	public static bool BPNeutralAnimalDebug = false;

	[DisplayName("PureVersion")]
	[Tooltip("是否纯净版本")]
	[Category("DebugConfig")]
	public static bool PureVersion = false;

	[DisplayName("开启预购版奖励")]
	[Tooltip("开启预购版奖励")]
	[Category("DebugConfig")]
	public static bool PreOrderAwardDebug = false;

	[Tooltip("开启豪华版奖励")]
	[DisplayName("开启豪华版奖励")]
	[Category("DebugConfig")]
	public static bool DeluxeAwardDebug = false;

	[Tooltip("关闭RPC日志")]
	[DisplayName("关闭RPC日志")]
	[Category("DebugConfig")]
	public static bool DisableRpcLog = false;

	[Category("UIConfig")]
	[DisplayName("ActiveAllUI")]
	[Tooltip("为false隐藏所有UI")]
	public static bool ActiveAllUI = true;

	[Tooltip("隐藏白点")]
	[DisplayName("HideLockTarget")]
	[Category("UIConfig")]
	public static int HideLockTarget = 1;

	[DisplayName("Open1080Check")]
	[Tooltip("开启1080P检查")]
	[Category("UIConfig")]
	public static bool Open1080Check = true;

	[DisplayName("GSDisableLoadingScreen")]
	[Category("UIConfig")]
	[Tooltip("不显示loading界面")]
	public static bool GSDisableLoadingScreen = false;

	[DisplayName("OnlyOpenPVUI")]
	[Category("UIConfig")]
	[Tooltip("仅打开PV相关UI")]
	public static bool OnlyOpenPVUI = false;

	[Category("UIConfig")]
	[DisplayName("高级掉落手动关闭")]
	[Tooltip("高级掉落手动关闭")]
	public static bool AdvanceDropManualClose = false;

	[DisplayName("InputDebugInfo")]
	[Category("Input")]
	[Tooltip("显示主角按键Debug信息")]
	public static bool InputDebugInfo = false;

	[DisplayName("InputDebug_Window")]
	[Tooltip("显示主角按键窗口信息")]
	[Category("Input")]
	public static bool InputDebug_Window = false;

	[DisplayName("InputDebug_KeyCache")]
	[Tooltip("显示主角按键缓存信息")]
	[Category("Input")]
	public static bool InputDebug_KeyCache = false;

	[Tooltip("GroupAI")]
	[DisplayName("GroupAI")]
	[Category("AI")]
	public static bool GroupAI = false;

	[Tooltip("AIInfo")]
	[DisplayName("AIInfo")]
	[Category("AI")]
	public static bool AIInfo = false;

	[Tooltip("TeamInfo")]
	[DisplayName("TeamInfo")]
	[Category("AI")]
	public static bool TeamInfo = false;

	[Tooltip("FollowPartnerDispInfo")]
	[DisplayName("FollowPartnerDispInfo")]
	[Category("AI")]
	public static bool FollowPartnerDispInfo = false;

	[Category("AI")]
	[Tooltip("查看目标信息")]
	[DisplayName("TargetInfo")]
	public static bool TargetInfo = false;

	[Tooltip("查看仇恨信息")]
	[DisplayName("HatredInfo")]
	[Category("AI")]
	public static bool HatredInfo = false;

	[Tooltip("查看AINode节点信息")]
	[DisplayName("AINodeDebug")]
	[Category("AI")]
	public static bool AINodeDebug = false;

	[DisplayName("ABPHelperInfo")]
	[Category("Anim")]
	[Tooltip("ABPHelperInfo")]
	public static bool ABPHelperInfo = false;

	[Category("OnlineDebug")]
	[DisplayName("OnlineAttr")]
	[Tooltip("看联机单位属性")]
	public static bool OnlineAttr = false;

	[Tooltip("看联机单位状态")]
	[DisplayName("OnlineUnitState")]
	[Category("OnlineDebug")]
	public static bool OnlineUnitState = false;

	[Tooltip("独立服务器调试")]
	[DisplayName("IsDebugDS")]
	[Category("OnlineDebug")]
	public static bool IsDebugDS = false;

	[Tooltip("查看网络情况")]
	[DisplayName("ConnectionInfo")]
	[Category("OnlineDebug")]
	public static bool ConnectionInfo = true;

	[DisplayName("PlayerDebugDraw")]
	[Tooltip("画出玩家位置")]
	[Category("OnlineDebug")]
	public static bool PlayerDebugDraw = false;

	[Tooltip("查看网络情况")]
	[Category("OnlineDebug")]
	[DisplayName("OpenNetConnectDebugUI")]
	public static bool OpenNetConnectDebugUI = false;

	[Tooltip("DebugGSRepRole")]
	[DisplayName("DebugGSRepRole")]
	[Category("OnlineDebug")]
	public static bool DebugGSRepRole = false;

	[Category("OnlineDebug")]
	[Tooltip("OpenEventDebugger")]
	[DisplayName("OpenEventDebugger")]
	public static bool OpenEventDebugger = false;

	[Tooltip("EventWarningLevel")]
	[DisplayName("EventWarningLevel")]
	[Category("OnlineDebug")]
	public static int EventWarningLevel = 0;

	[Tooltip("覆盖默认的房间服务地址")]
	[DisplayName("RoomServerConnectAddr")]
	[Category("OnlineDebug")]
	public static string RoomServerConnectAddr = "";

	[Tooltip("调试用联机关卡ID：3620")]
	[Category("OnlineDebug")]
	[DisplayName("DebugOnlineLevelId")]
	public static int DebugOnlineLevelId = 0;

	[Category("DebugUI")]
	[DisplayName("IsDebugAKB")]
	[Tooltip("IsDebugAKB")]
	public static bool IsDebugAKB = false;

	[DisplayName("IsDebugUISys")]
	[Category("DebugUI")]
	[Tooltip("IsDebugUISys")]
	public static bool IsDebugUISys = false;

	[Category("DebugUI")]
	[DisplayName("IsDebugUIMore")]
	[Tooltip("IsDebugUIMore")]
	public static bool IsDebugUIMore = false;

	[Category("DebugUI")]
	[DisplayName("IsDebugUIProc")]
	[Tooltip("IsDebugUIProc")]
	public static bool IsDebugUIProc = false;

	[DisplayName("IsDebugWidgetMore")]
	[Tooltip("IsDebugWidgetMore")]
	[Category("DebugUI")]
	public static bool IsDebugWidgetMore = false;

	[Category("DebugUI")]
	[DisplayName("IsDebugButton")]
	[Tooltip("IsDebugButton")]
	public static bool IsDebugButton = false;

	[DisplayName("IsDebugAutoSizeScrollBox")]
	[Tooltip("IsDebugAutoSizeScrollBox")]
	[Category("DebugUI")]
	public static bool IsDebugAutoSizeScrollBox = false;

	[Category("DebugUI")]
	[DisplayName("IsDebugWidgetProfile")]
	[Tooltip("IsDebugWidgetProfile")]
	public static bool IsDebugWidgetProfile = false;

	[DisplayName("IsDebugUITick")]
	[Category("DebugUI")]
	[Tooltip("IsDebugUITick")]
	public static bool IsDebugUITick = false;

	[Tooltip("IsOpenStatGSCustom")]
	[DisplayName("IsOpenStatGSCustom")]
	[Category("DebugUI")]
	public static bool IsOpenStatGSCustom = false;

	[Category("DebugUI")]
	[DisplayName("UITickProfileLevel")]
	[Tooltip("")]
	public static int UITickProfileLevel = 0;

	[Category("DebugDrawUI")]
	[DisplayName("IsShowDebugDrawUI")]
	[Tooltip("IsShowDebugDrawUI")]
	public static bool IsShowDebugDrawUI = false;

	[Tooltip("DebugDrawTag(Seq、)")]
	[Category("DebugDrawUI")]
	[DisplayName("DebugDrawTag")]
	public static string DebugDrawTag = "Seq,";

	[DisplayName("DebugPhaseCSG")]
	[Tooltip("DebugPhaseCSG")]
	[Category("DebugBattle")]
	public static bool DebugPhaseCSG = false;

	[Category("DebugBattle")]
	[Tooltip("IsOpenBattleInfoTool")]
	[DisplayName("IsOpenBattleInfoTool")]
	public static bool IsOpenBattleInfoTool = false;

	[Tooltip("取消怪物技能cd")]
	[Category("DebugBattle")]
	[DisplayName("CancelSkillCD")]
	public static bool CancelSkillCD = false;

	[DisplayName("CollectionForceType")]
	[Category("DebugBattle")]
	[Tooltip("采集怪强制出生")]
	public static int CollectionForceType = 0;

	[Category("DebugMap")]
	[DisplayName("测试地图")]
	[Tooltip("地图区域测试开关")]
	public static bool DebugMap = false;

	[DisplayName("LockDesiredPlayerHP")]
	[Tooltip("锁定血量期望")]
	[Category("DebugBattle")]
	public static int LockDesiredPlayerHP = 0;

	[Tooltip("角色环境遮罩Debug")]
	[DisplayName("ShowChrEnvMaskValue")]
	[Category("DebugEnv")]
	public static bool ShowChrEnvMaskValue = false;

	[Tooltip("IsOpenRemoteTestCheat")]
	[DisplayName("IsOpenRemoteTestCheat")]
	[Category("CheckTools")]
	public static bool IsOpenRemoteTestCheat = false;

	[DisplayName("IsIgnoreValidateData")]
	[Category("CheckTools")]
	[Tooltip("表格校验开关")]
	public static bool IsIgnoreValidateData = false;

	[Category("CheckTools")]
	[Tooltip("开启内存泄露检查")]
	[DisplayName("内存泄漏检查")]
	public static bool EventMemoryLeakTest = false;

	[Category("CheckTools")]
	[DisplayName("定时内存泄漏检查")]
	[Tooltip("开启定时内存泄露检查")]
	public static bool TickEventMemoryLeakTest = false;

	[Tooltip("开启Obj内存泄露检查")]
	[DisplayName("Obj内存泄漏检查")]
	[Category("CheckTools")]
	public static bool ObjMemoryLeakTest = false;

	[Category("CheckTools")]
	[DisplayName("内存泄漏检查缓存引用")]
	[Tooltip("开启缓存引用方便在DotMemory中查看引用链")]
	public static bool MemoryLeakTestCacheObj = false;

	[DisplayName("DebugStartWithOutArchive")]
	[Category("Loading")]
	[Tooltip("开启选关卡界面")]
	public static bool DebugStartWithOutArchive = false;

	[Category("Loading")]
	[DisplayName("EnableSelectChapter")]
	[Tooltip("允许新游戏选关")]
	public static bool EnableSelectChapter = false;

	[Category("Function")]
	[DisplayName("FSRCrashOptions")]
	[Tooltip("FSR防崩开关")]
	public static int FSRCrashOptions = 2;

	[Category("Function")]
	[DisplayName("CanOptimizeTick")]
	[Tooltip("性能优化开关")]
	public static bool CanOptimizeTick = true;

	[Category("Function")]
	[DisplayName("Debug820Demo")]
	[Tooltip("Debug820Demo")]
	public static bool Debug820Demo = false;

	[Category("Function")]
	[Tooltip("Demo820OverSeaVersion")]
	[DisplayName("Demo820OverSeaVersion")]
	public static bool Demo820OverSeaVersion = false;

	[Tooltip("Demo820DebugTest")]
	[DisplayName("Demo820DebugTest")]
	[Category("Function")]
	public static bool Demo820DebugTest = false;

	[Category("Function")]
	[DisplayName("Demo820UseSetting")]
	[Tooltip("Demo820UseSetting")]
	public static bool Demo820UseSetting = false;

	[Category("Function")]
	[DisplayName("DebugFristStartGame")]
	[Tooltip("测试第一次启动游戏的设置项")]
	public static bool DebugFristStartGameSetting = false;

	[Tooltip("使用SeamlessLevelTravel")]
	[Category("LevelTravel")]
	[DisplayName("使用SeamlessLevelTravel")]
	public static bool OpenSeamlessLevelTravel = true;

	[Category("Function")]
	[DisplayName("Demo820ExceptionUI")]
	[Tooltip("显示820特殊ExceptionUI")]
	public static bool Demo820ExceptionUI = false;

	[Category("Function")]
	[DisplayName("Demo820IgnoreAllOverlap")]
	[Tooltip("超时不播seq开关")]
	public static bool Demo820IgnoreAllOverlap = false;

	[Category("Function")]
	[DisplayName("Demo820QuitGameCountMax")]
	[Tooltip("最大游玩次数")]
	public static int Demo820PlayCountMax = 0;

	[DisplayName("PrintTransLog")]
	[Tooltip("输出变身日志")]
	[Category("Function")]
	public static bool DebugPlayerTransLog = true;

	[Category("Function")]
	[DisplayName("OpenCricketBattle")]
	[Tooltip("开启蛐蛐战")]
	public static bool CricketBattleMode = false;

	[Category("Function")]
	[DisplayName("CricketBattleModeType")]
	[Tooltip("蛐蛐模式类型")]
	public static int CricketBattleModeType = 2;

	[Category("Function")]
	[DisplayName("CricketReportServer")]
	[Tooltip("蛐蛐模式开启上报")]
	public static bool CricketReportServer = false;

	[Tooltip("设置调试查Bug用Log")]
	[Category("Function")]
	[DisplayName("DebugSettingLog")]
	public static bool DebugSettingLog = false;

	[Tooltip("允许开启用户开关")]
	[DisplayName("NeedGSSDKUserCheck")]
	[Category("Function")]
	public static bool NeedGSSDKUserCheck = true;

	[Category("Function")]
	[DisplayName("DebugTransGuideUI")]
	[Tooltip("测试变身引导UI")]
	public static bool DebugTransGuideUI = false;

	[DisplayName("LQA Language")]
	[Category("Function")]
	[Tooltip("云游戏语言开关")]
	public static bool LQALanguage = false;

	[DisplayName("GSIsGlobalColorDeficiency")]
	[Tooltip("色盲颜色辅助是否对全局颜色生效")]
	[Category("Function")]
	public static bool GSIsGlobalColorDeficiency = true;

	[Category("Loading")]
	[DisplayName("Game Intent")]
	[Tooltip("测试PS5的Game Intent逻辑")]
	public static bool DebugGameIntent = false;

	[Category("Loading")]
	[DisplayName("LoadingUI ShowTime")]
	[Tooltip("LoadingUI显示时长")]
	public static bool ShowLoadingTimeText = false;

	[DisplayName("是否需要在启动游戏时编译PSO")]
	[Category("Loading")]
	[Tooltip("是否需要在启动游戏时编译PSO")]
	public static bool IsNeedPsoPrecompileWhenStartGame = true;

	[Tooltip("八字真言、健康游戏声明等")]
	[DisplayName("是否需要开始游戏前的流程")]
	[Category("Loading")]
	public static bool IsNeedPreStartGameProcess = true;

	[Category("Input")]
	[DisplayName("Disable Input Message")]
	[Tooltip("屏蔽输入消息")]
	public static bool DisableInputMessage = false;

	[Category("Loading")]
	[DisplayName("Use new timeline for cpg")]
	[Tooltip("是否使用新的时序去创建CPG")]
	public static bool EnableUseNewTimelineForCPG = true;

	[DisplayName("Debug Play Go")]
	[Tooltip("调试PlayGo")]
	[Category("Loading")]
	public static bool DebugPlayGo = false;

	[Tooltip("loading超过这个时间上报")]
	[DisplayName("Loading Max Time")]
	[Category("Loading")]
	public static int LoadingMaxTime = 300;

	[Category("Loading")]
	[DisplayName("Loading Max Time")]
	[Tooltip("loading超过这个事件弹出Tips")]
	public static int LoadingMaxTimeShowTips = 180;

	[Category("Sentry")]
	[DisplayName("Ensure Report Interval")]
	[Tooltip("Sentry Ensure 的上报间隔")]
	public static int EnsureReportInterval = 60;

	[Tooltip("是否开启PlaneMove模式")]
	[Category("Autotest")]
	[DisplayName("Enable PlaneMove Mode")]
	public static bool EnablePlaneMoveMode = false;

	[Tooltip("B1豪华版AddOnId")]
	[DisplayName("B1豪华版AddOnId")]
	[Category("AdditionalContent")]
	public static string B1DeluxeAddOnId = "";

	[Category("AdditionalContent")]
	[DisplayName("B1预购AddOnId")]
	[Tooltip("B1预购AddOnId")]
	public static string B1PrePurchaseAddOnId = "";

	[DisplayName("打开新手指引信息")]
	[Category("Player Guide")]
	[Tooltip("测试新手指引信息")]
	public static bool DebugPlayerGuide = false;

	[Category("Player Guide")]
	[DisplayName("打开新周目新手教学")]
	[Tooltip("打开新周目新手教学")]
	public static bool DebugNewGamePlusGuide = false;

	[Tooltip("打开BossRush新手教学")]
	[Category("Player Guide")]
	[DisplayName("打开BossRush教学")]
	public static bool DebugBossRushGuide = false;

	[Category("Player Guide")]
	[DisplayName("打开Map教学")]
	[Tooltip("打开Map新手教学")]
	public static bool DebugMapGuide = false;

	[Category("Audio")]
	[DisplayName("启用环形子弹Debug")]
	[Tooltip("启用环形子弹Debug")]
	public static bool DebugDonutAudio = false;

	[Category("DebugConfig")]
	[DisplayName("FileIOStrategy")]
	[Tooltip("IOStrategy")]
	public static string FileIOStrategy = "UGSFileHelper";

	[Tooltip("OverSeaChannel")]
	[Category("DebugConfig")]
	[DisplayName("OverSeaChannel")]
	public static bool IsOverSeaChannel = true;

	[Category("DebugConfig")]
	[DisplayName("EnableEncrypt")]
	[Tooltip("EnableEncrypt")]
	public static bool EnableEncrypt = true;

	[Category("DebugConfig")]
	[DisplayName("SettingHostSimulation")]
	[Tooltip("模拟设置在主机上的表现")]
	public static bool SettingHostSimulation = false;

	[Tooltip("Editor模拟设置在Build的表现")]
	[DisplayName("SettingEditorSimulation")]
	[Category("DebugConfig")]
	public static bool SettingEditorSimulation = false;

	[Category("DebugConfig")]
	[DisplayName("DevArchiveSizeCheck")]
	[Tooltip("存档大小检查开关")]
	public static bool DevArchiveSizeCheck = true;

	[Category("DebugConfig")]
	[DisplayName("DevArchiveSizeMax")]
	[Tooltip("Dev存档大小最大值")]
	public static int DevArchiveSizeMax = 5242880;

	[DisplayName("DisableDissolveDisplay")]
	[Tooltip("关闭死亡消散效果")]
	[Category("DebugConfig")]
	public static bool DisableDissolveDisplay = false;

	[Category("DebugConfig")]
	[DisplayName("DebugOverSeaType")]
	[Tooltip("调试用国内外开关")]
	public static int DebugOverSeaType = 0;

	[Category("DebugConfig")]
	[DisplayName("ExceptionShowBtn")]
	[Tooltip("报错UI是否显示 Btn")]
	public static bool ExceptionShowBtn = true;

	[DisplayName("WaitMSToThrowException")]
	[Category("DebugConfig")]
	[Tooltip("等待多少毫秒抛出异常")]
	public static int WaitMSToThrowException = 10000;

	[DisplayName("ThrowException")]
	[Tooltip("Cache Exception 后抛出异常")]
	[Category("DebugConfig")]
	public static bool ThrowException = false;

	[Tooltip("SettingCvar开关")]
	[Category("DebugConfig")]
	[DisplayName("DebugSettingCvar")]
	public static bool DebugSettingCvar = false;

	[Tooltip("初始化配置警告开关")]
	[Category("DebugConfig")]
	[DisplayName("DebugSettingCvar")]
	public static bool DebugReInitRoleCheck = true;

	[Category("DebugConfig")]
	[DisplayName("上报Sentry UserConfig频率")]
	[Tooltip("上报Sentry UserConfig频率")]
	public static int UpdateUserConfigInterval = 5;

	[Category("DebugConfig")]
	[DisplayName("采集物测试GM")]
	[Tooltip("采集物测试GM")]
	public static bool DebugCollection = false;

	[DisplayName("多周目测试")]
	[Tooltip("多周目测试")]
	[Category("DebugConfig")]
	public static int DebugGameCount = 0;

	[Category("DebugConfig")]
	[DisplayName("Button参数同步配置")]
	[Tooltip("Button参数同步配置")]
	public static bool ButtonMatSyncCheck = true;

	[Tooltip("0:AutoSizeScrollBox 1:TileView")]
	[Category("DebugConfig")]
	[DisplayName("武器锻造列表模式")]
	public static int WeaponBuildMode = 1;

	[DisplayName("是否开启前尘影视")]
	[Tooltip("是否开启前尘影视")]
	[Category("DebugConfig")]
	public static bool OpenPastMemory = true;

	[Category("DebugConfig")]
	[DisplayName("是否开启查看材料")]
	[Tooltip("是否开启查看材料")]
	public static bool OpenSimpleTips = false;

	[DisplayName("Editor下开启本地化")]
	[Category("Localization")]
	[Tooltip("Editor下开启本地化")]
	public static bool OpenLocalizationInEditor = false;

	[DisplayName("是否开启 Enhanced Input 输入延时")]
	[Tooltip("是否开启 Enhanced Input 输入延时")]
	[Category("Input")]
	public static bool EnableEnhancedInputDelay = true;

	[Category("Input")]
	[DisplayName("输入延时（ms）")]
	[Tooltip("输入延时（ms）")]
	public static int EnhancedInputDelayTime = 30;

	[Category("Input")]
	[DisplayName("特殊输入延时（ms）")]
	[Tooltip("特殊输入延时（ms）")]
	public static int EnhancedInputSpecialDelayTime = 50;

	[Category("DebugConfig")]
	[Tooltip("光追测试关卡")]
	[DisplayName("DebugRtxEnableLevel")]
	public static string DebugRtxEnableLevel = "";

	[Category("DebugConfig")]
	[DisplayName("EndingCreditsUseJson")]
	[Tooltip("EndingCredits数据使用Json")]
	public static bool EndingCreditsUseJson = false;

	[Category("DebugConfig")]
	[DisplayName("MediaPlayerSyncToleranceMS")]
	[Tooltip("媒体播放器系统时钟同步容差(ms)")]
	public static int MediaPlayerSyncToleranceMS = 500;

	[Tooltip("媒体播放器系统时钟同步CD(ms)")]
	[Category("DebugConfig")]
	[DisplayName("MediaPlayerSyncCDMS")]
	public static int MediaPlayerSyncCDMS = 3000;

	[Category("DebugConfig")]
	[DisplayName("隐藏MiniGM剧情页签")]
	[Tooltip("隐藏MiniGM剧情页签")]
	public static bool HideMiniGMSequenceTab = true;

	[Category("DebugConfig")]
	[DisplayName("是否启用BinkMediaPlayer")]
	[Tooltip("是否启用BinkMediaPlayer")]
	public static bool GSWithBink = true;

	[Category("DebugConfig")]
	[DisplayName("常见问题与解答网站")]
	[Tooltip("faq网站链接")]
	public static string FAQWebsiteLink = "https://www.heishenhua.com/support";

	[DisplayName("BenchMark包标记(待替换)")]
	[Tooltip("")]
	[Category("DebugConfig")]
	public static bool BenckMarkOnly = false;

	[Category("DebugConfig")]
	[DisplayName("BenchMark循环播放")]
	[Tooltip("")]
	public static bool BenckMarkLoop = false;

	[Category("DebugConfig")]
	[DisplayName("BenchMark低GPU占用(百分比)")]
	[Tooltip("")]
	public static int BenckMarkGPULow = 40;

	[DisplayName("DamageLogic")]
	[Tooltip("没找到地方调用")]
	[Category("Abandon?")]
	public static bool DamageLogic = false;

	[Tooltip("没找到地方调用")]
	[DisplayName("DropItem")]
	[Category("Abandon?")]
	public static bool DropItem = false;

	[Category("Abandon?")]
	[DisplayName("Secret")]
	[Tooltip("没找到地方调用")]
	public static bool Secret = true;

	[Category("Abandon?")]
	[DisplayName("EntitySharedRefLeakDetect")]
	[Tooltip("没找到地方调用")]
	public static bool EntitySharedRefLeakDetect = false;

	[Tooltip("TaskGroup")]
	[DisplayName("TaskGroup")]
	[Category("Abandon?")]
	public static bool TaskGroup = false;

	[Tooltip("NPC")]
	[Category("Abandon?")]
	[DisplayName("NPC")]
	public static bool NPC = false;

	[DisplayName("ActiveManageUI")]
	[Category("Abandon?")]
	[Tooltip("ActiveManageUI")]
	public static bool ActiveManageUI = true;

	[Tooltip("GymModeInWindows")]
	[DisplayName("GymModeInWindows")]
	[Category("LocalDev")]
	public static bool GymModeInWindows = false;

	[DisplayName("FileMd5Check Ignore Path")]
	[Category("LocalDev")]
	[Tooltip("FileMd5Check")]
	public static string FileMd5CheckIgnorePathPattern = "/Saved/,/Logs/,b1/Tools/";

	[DisplayName("GSSdk Enable CETesting")]
	[Category("LocalDev")]
	[Tooltip("开启CETesting")]
	public static bool GSSdkEnableCETesting = false;

	[Category("LocalDev")]
	[DisplayName("ForceEnableDebugGMFlags")]
	[Tooltip("强制开启DebugGM的标志位;可参考:GMFlag")]
	public static int ForceEnableDebugGMFlags = 0;

	[DisplayName("Security KAServerHost")]
	[Tooltip("开发相关的安全主机")]
	[Category("DevSecurity")]
	public static string KAServerHost = "gshb.b1.gamesci.com.cn";

	[Tooltip("开发相关的安全端口")]
	[DisplayName("Security KAServerPort List")]
	[Category("DevSecurity")]
	public static int KAServerPort = 12800;

	[Tooltip("开发相关的安全协议")]
	[Category("DevSecurity")]
	[DisplayName("Security KAUseTcp")]
	public static bool KAServerUseTcp = true;

	[Category("DevSecurity")]
	[DisplayName("Security KAExtraId")]
	[Tooltip("开发相关的安全标识")]
	public static string KAExtraId = "";

	[Tooltip("是否必须使用Gamesci 登陆器登录")]
	[DisplayName("NeedLauncher")]
	[Category("GamesciLogin")]
	public static bool NeedLauncher = false;

	[Tooltip("GSSdk Gamesci 登陆服务器的地址")]
	[Category("GamesciLogin")]
	[DisplayName("GSSdk Gamesci LoginServerUrl")]
	public static string DevGamesciLoginServerUrl = "http://gslogin.b1.gamesci.com.cn:19912";

	[Category("Production")]
	[Tooltip("版本运行的环境配置(全小写),主要是:dev(表示开发环境),prod(表示生产环境,要发布的)")]
	[DisplayName("Environment")]
	public static string Environment = "dev";

	[Tooltip("隐藏CRC UI")]
	[Category("Production")]
	[DisplayName("HideCrashReportClientUi")]
	public static bool HideCrashReportClientUi = true;

	[Category("GSSdk")]
	[DisplayName("GSSdk CDN Root Url list")]
	[Tooltip("GSSdk的默认下载根服务器服务器地址列表,使用逗号(,)分隔,一般不用配置,只是开发特殊使用")]
	public static string GSSdkCDNRootUrlList = "http://gsbasecdn.gs.com/gs_cdn/build/upload/b1pbtable_cdn";

	[Category("GSSdk")]
	[DisplayName("GSSdk EnvServerUrlList")]
	[Tooltip("GSSdk的环境主机的地址,使用逗号(,)分隔")]
	public static string GSSdkEnvServerUrlList = "http://gssdk.b1.gamesci.com.cn:9812";

	[DisplayName("GSSdk AppChannel")]
	[Tooltip("包所在的发行渠道,gamesci,steam,wegame,epic,ps5,xsx")]
	[Category("GSSdk")]
	public static string GSSdkAppChannel = "gamesci";

	[DisplayName("GSSdk LoginChannel")]
	[Tooltip("GSSdk使用的登录渠道,包括gamesci,steam,wegame,epic,psn,xbl")]
	[Category("GSSdk")]
	public static string GSSdkLoginChannel = "gamesci";

	[DisplayName("GSSdk LoginChannel")]
	[Category("GSSdk")]
	[Tooltip("GSSdk使用的登录子渠道,一般不用")]
	public static string GSSdkLoginSubChannel = "";

	[Category("GSSdk")]
	[DisplayName("GSSdk PackageTags")]
	[Tooltip("GSSdk 包的扩展标记,使用,分隔")]
	public static string GSSdkPackageTags = "";

	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Using Charp Http")]
	[Tooltip("GSSdk 的上报队列使用CSharp的HTTP(IL2CPP不支持HTTPS)")]
	public static bool GSSdkReportUseCSharpHttp = false;

	[Category("GSSdk")]
	[Tooltip("GSSdk 的上报队列使用UE HTTP 异步模式,不关心失败返回值,只上报不关心返回值")]
	[DisplayName("GSSdk ReportQueue Using Async Http Unsafe Mode")]
	public static bool GSSdkReportUseAsyncHttp = false;

	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Enable")]
	[Tooltip("GSSdk 的上报支持开关")]
	public static bool GSSdkReportEnable = true;

	[Tooltip("GSSdk 的上报合批数量")]
	[Category("GSSdk")]
	[DisplayName("GSSdk ReportQueue Merge Event Num")]
	public static int GSSdkReportMergeBatchEventNum = 300;

	[Tooltip("GSSdk MERGE BATCH TIME INTERVAL")]
	[DisplayName("GSSdk ReportQueue Merge Event Interval Seconds")]
	[Category("GSSdk")]
	public static int GSSdkReportMergeBatchIntervalSeconds = 60;

	[DisplayName("GSSdk Report Queue Disable HTTP")]
	[Category("GSSdk")]
	[Tooltip("GSSdk DISABLE HTTP REPORT")]
	public static bool GSSdkReportDisableHttpRequest = false;

	[Category("GSSdk")]
	[Tooltip("GSSdk Enable Data Clean")]
	[DisplayName("GSSdk Report Enable Data Clean")]
	public static bool GSSdkEnableSensDataClean = false;

	[Category("GSSdk")]
	[DisplayName("GSSdk Report Enable Monitor")]
	[Tooltip("GSSdk Enable 启用监控指标")]
	public static bool GSSdkEnableMonitor = true;

	[Category("GSSdk")]
	[DisplayName("GSSdk Report Enable Perf")]
	[Tooltip("GSSdk Enable 性能分析")]
	public static bool GSSdkEnablePerf = true;

	[Category("Sentry")]
	[DisplayName("Sentry DSN")]
	[Tooltip("Sentry 的上报DSN")]
	public static string SentryDSN = "http://bdca0e842c6806e70e718e79641b3fbf@sentry.gs.com/6";

	[Category("Sentry")]
	[DisplayName("Sentry 备用域名")]
	[Tooltip("Sentry 备用域名")]
	public static string SentryHostBackup = "heishenhua.com:gamesci.com.cn";

	[Category("Sentry")]
	[DisplayName("Sentry Prod DebugMode")]
	[Tooltip("Sentry DebugMode")]
	public static bool SentryDebug = false;

	[Category("Sentry")]
	[DisplayName("Sentry Prod Sample Rate")]
	[Tooltip("Sentry Sample Rate")]
	public static string SentrySampleRate = "1.0";

	[Category("Sentry")]
	[DisplayName("Sentry Bui Enable options")]
	[Tooltip("Sentry Bui Enable")]
	public static bool SentryEnable = true;

	[DisplayName("Sentry EnableTracing options")]
	[Tooltip("Sentry EnableTracing")]
	[Category("Sentry")]
	public static bool SentryEnableTracing = false;

	[Category("Sentry")]
	[DisplayName("Sentry CaptureFailRequests options")]
	[Tooltip("Sentry CaptureFailRequests")]
	public static bool SentryCaptureFailRequests = false;

	[Tooltip("Sentry Use LocalCacheFile")]
	[Category("Sentry")]
	[DisplayName("Sentry Use Local File Cache")]
	public static bool SentryUseLocalCacheFile = false;

	[Tooltip("Summer Magic check")]
	[DisplayName("Summery Magic check")]
	[Category("Summer")]
	public static string MagicCheckOverlay = "";
}
