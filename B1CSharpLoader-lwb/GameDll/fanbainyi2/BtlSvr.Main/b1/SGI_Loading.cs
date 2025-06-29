using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SGI_Loading")]
public enum SGI_Loading : byte
{
	[StatDll(Dll = "B1UI.Script")]
	GSGShowWXlogin,
	[StatDll(Dll = "B1UI.Script")]
	WaitMatchStart,
	[StatDll(Dll = "B1UI.Script")]
	FillIsInToilet,
	[StatDll(Dll = "B1UI.Script")]
	LoadCharacterViewLevel,
	[StatDll(Dll = "B1UI.Script")]
	LoadChapterViewLevel,
	[StatDll(Dll = "B1UI.Script")]
	InitDispLibWorld,
	[StatDll(Dll = "BtlSvr.Main")]
	ECSWorldBeginPlay,
	[StatDll(Dll = "BtlSvr.Script")]
	GSGBtlOnBattleStart,
	[StatDll(Dll = "B1UI.Script")]
	CreateNewRoleData,
	[StatDll(Dll = "B1UI.Script")]
	GSGEnterBattleLevel,
	[StatDll(Dll = "B1UI.Script")]
	ServerBattleReady,
	[StatDll(Dll = "B1UI.Script")]
	GSGShowBattleUI,
	[StatDll(Dll = "B1UI.Script")]
	GSGShowLoginUI,
	[StatDll(Dll = "B1UI.Script")]
	GSGRecoverMuseum,
	[StatDll(Dll = "B1UI.Script")]
	LoadingUIFadeAway,
	[StatDll(Dll = "B1UI.Script")]
	LoadingUIFadeIn,
	[StatDll(Dll = "B1UI.Script")]
	WaitReplayPlayerSpawn,
	[StatDll(Dll = "B1UI.Script")]
	ShowReplayUI,
	[StatDll(Dll = "B1UI.Script")]
	UnlockScopeReplayScrubComplete,
	[StatDll(Dll = "BtlSvr.Main")]
	WaitTick,
	[StatDll(Dll = "B1UI.Script")]
	LoginByRoleData,
	[StatDll(Dll = "B1UI.Script")]
	WaitGSLoginSuccess,
	[StatDll(Dll = "B1UI.Script")]
	PlayerDataInitPreEnterLevel,
	[StatDll(Dll = "B1UI.Script")]
	GSGEnterLevel,
	[StatDll(Dll = "B1UI.Script")]
	GSGExitLevel,
	[StatDll(Dll = "BtlSvr.Main")]
	ECSWorldReset,
	[StatDll(Dll = "BtlSvr.Main")]
	PauseGame,
	[StatDll(Dll = "BtlSvr.Main")]
	ResumeGame,
	[StatDll(Dll = "B1UI.Script")]
	InitNewArchiveData,
	[StatDll(Dll = "B1UI.Script")]
	LoadingUIWaitUserInput,
	[StatDll(Dll = "B1UI.Script")]
	LoadingUILinearTime,
	[StatDll(Dll = "B1UI.Script")]
	ReadLatestArchive,
	[StatDll(Dll = "B1UI.Script")]
	FillLoginRoleData,
	[StatDll(Dll = "BtlSvr.Main")]
	OpenLevelByName,
	[StatDll(Dll = "B1UI.Script")]
	Reset820DemoGameData,
	[StatDll(Dll = "B1UI.Script")]
	ResetGameInstanceData,
	[StatDll(Dll = "B1UI.Script")]
	CacheArchiveDataForClient,
	[StatDll(Dll = "B1UI.Script")]
	OpenLevelStartUp,
	[StatDll(Dll = "B1UI.Script")]
	OpenLevelDefaultBattle,
	[StatDll(Dll = "BtlSvr.Main")]
	OpenLevelByIdInContext,
	[StatDll(Dll = "B1UI.Script")]
	GSGOnBattleStart,
	[StatDll(Dll = "B1UI.Script")]
	GSGOnBattleDestroy,
	[StatDll(Dll = "BtlSvr.Script")]
	GSGBtlOnBattleDestroy,
	[StatDll(Dll = "B1UI.Script")]
	MarkNewGameplusReady,
	[StatDll(Dll = "B1UI.Script")]
	StartNewGamePlus,
	[StatDll(Dll = "B1UI.Script")]
	WaitPlayerCameraBlend,
	[StatDll(Dll = "B1UI.Script")]
	WaitLevelStreamingLoad,
	[StatDll(Dll = "B1UI.Script")]
	UnrealTravelToServer,
	[StatDll(Dll = "B1UI.Script")]
	WaitLocalPlayerFillLoginOption,
	[StatDll(Dll = "B1UI.Script")]
	WaitLocalPlayerStartPlay,
	[StatDll(Dll = "B1UI.Script")]
	InitLocalPlayerContainer,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitPostLoadMap,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitPostLoadMapClient,
	[StatDll(Dll = "B1UI.Script")]
	FillLocalBPCRoleData,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitFirstPlayerLogin,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitAllAssetLoadFinsh,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitImportantAssetLoadFinsh,
	[StatDll(Dll = "B1UI.Script")]
	WaitCheck820DemoGameVersion,
	[StatDll(Dll = "B1UI.Script")]
	ResetNewGameplusArchive,
	[StatDll(Dll = "B1UI.Script")]
	WaitStartGamePsoPrecompileFinish,
	[StatDll(Dll = "B1UI.Script")]
	FirstStartGameSettings,
	[StatDll(Dll = "B1UI.Script")]
	ShowAgreementPolicyInStartGame,
	[StatDll(Dll = "B1UI.Script")]
	ShowLogoInStartGame,
	[StatDll(Dll = "B1UI.Script")]
	ShowGameDisclaimerInStartGame,
	[StatDll(Dll = "B1UI.Script")]
	ShowArchiveMarkInStartGame,
	[StatDll(Dll = "B1UI.Script")]
	MarkFirstStartGameFlag,
	[StatDll(Dll = "B1UI.Script")]
	CheckGSSdkServerConfig,
	MarkCanFinishLoopMovie,
	[StatDll(Dll = "B1UI.Script")]
	ShowHealthyGamingAdviceInStartGame,
	TeleportTemplateBegin,
	TeleportTemplateEnd,
	PlayerTeleportToTemplatetargetPos,
	LoadingUIBeginFadeAway,
	SubG_GI_Loading_BattleLevelTravel,
	SubG_GI_Loading_ClientEnvInit,
	SubG_GI_Loading_HideLoadingUI,
	SubG_GI_Loading_GSLogin,
	SubG_GI_Loading_ReStartGSLogin,
	SubG_GI_Loading_SaveArchiveAndWaitFinish,
	RequestTemplateTravelLevelBegin,
	RequestTemplateTravelLevelEnd,
	[StatDll(Dll = "B1UI.Script")]
	RequestTemplatePreSaveArchive,
	[StatDll(Dll = "B1UI.Script")]
	RequestTemplatePostSaveArchiveFinish,
	RequestTemplatePreLeaveLevel,
	SubG_GI_Loading_PostLeaveLevel,
	RequestTemplateOpenLevel,
	SubG_GI_Loading_PreEnterLevel,
	RequestTemplatePostEnterLevelFinish,
	RequestTemplatePostGSLoginFinish,
	LockSaveArchiveByTravelLevel,
	ReleaseSaveArchiveByTravelLevel,
	SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive,
	[StatDll(Dll = "B1UI.Script")]
	RequestTemplateLoadArchiveData,
	[StatDll(Dll = "B1UI.Script")]
	RequestTemplateCreateArchiveData,
	[StatDll(Dll = "B1UI.Script")]
	RequestTemplatePerformActionsFromArchive,
	SubG_GI_Loading_HandleArchiveInTravelLevel,
	[StatDll(Dll = "B1UI.Script")]
	CheckArchiveDataIsValid,
	[StatDll(Dll = "B1UI.Script")]
	SaveArchiveInTravelLevel,
	OpenLoadingScreen,
	PrepareFadeAway,
	RequestFadeAway,
	CloseLoadingScreen,
	[StatDll(Dll = "B1UI.Script")]
	SpawnPlayerPawnWithOutECSBeginPlay,
	[StatDll(Dll = "B1UI.Script")]
	TriggerTeleportAndWaitFinish,
	[StatDll(Dll = "B1UI.Script")]
	PausePsoCachePrecompile,
	[StatDll(Dll = "B1UI.Script")]
	ResumePsoCachePrecompile,
	[StatDll(Dll = "B1UI.Script")]
	WaitPsoCachePrecompileFinish,
	[StatDll(Dll = "B1UI.Script")]
	AdjustPSOCachePrecompileBatch,
	[StatDll(Dll = "B1UI.Script")]
	SetPSOCacheUsageMask,
	[StatDll(Dll = "BtlSvr.Script")]
	PreLogin,
	[StatDll(Dll = "BtlSvr.Script")]
	PostLogin,
	[StatDll(Dll = "BtlSvr.Script")]
	WaitGamePlayerInit,
	[StatDll(Dll = "BtlSvr.Script")]
	SpawnCharacterForClient,
	[StatDll(Dll = "BtlSvr.Script")]
	InitClientPlayerContainer,
	[StatDll(Dll = "B1UI.Script")]
	ChangeGameDefaultMap,
	[StatDll(Dll = "B1UI.Script")]
	CheckGSSdkUserConfig,
	EngineHandleDisconnect,
	[StatDll(Dll = "B1UI.Script")]
	ShowMessageBoxAndWaitConfirm,
	[StatDll(Dll = "B1UI.Script")]
	TriggerBackToStandAlone,
	[StatDll(Dll = "BtlSvr.Main")]
	NextChapterReqAndArchive,
	GMRecordRebirthPos,
	[StatDll(Dll = "BtlSvr.Main")]
	NetConectionFailurePreprocess,
	[StatDll(Dll = "BtlSvr.Main")]
	InitCollectionSpawnActorState,
	[StatDll(Dll = "B1UI.Script")]
	SaveArchiveAndWaitFinish,
	PostSeamlessLevelTravel,
	[StatDll(Dll = "B1UI.Script")]
	LoadCommLevel,
	QuitGame,
	WaitUntilGameStateInit,
	[StatDll(Dll = "B1UI.Script")]
	PlayGoDownloadIncompleteImpl
}
