using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CGI_Loading")]
public enum CGI_Loading : byte
{
	HasArchive,
	IsInStartUpLevel,
	IsInBattleLevel,
	IsInDefaultBattleLevel,
	HasArchiveIdInContext,
	IsInServer,
	IsInDedicateServer,
	IsInListenServer,
	IsStandAlone,
	IsInNetClient,
	IsInPIEClient,
	TravelUrlIsListen,
	TravelUrlHasHost,
	IsEnableLoadingUserInput,
	[StatDll(Dll = "BtlSvr.Script")]
	HasPlayerLoginBtlSvr,
	IsInToilet,
	IsInContextLevel,
	TeleportNeedLevelTravel,
	SwitchTeleportType,
	IsReplayWorldLoadFinish,
	PlayerGameStateCheck,
	[StatDll(Dll = "B1UI.Script")]
	IsInPreviewSeqContext,
	NeedSwitchPlayerGameMode,
	MonsterTeleportArchiveExist,
	BattleLevelTravelNeedWaitCameraBlend,
	IsInMap,
	OpenSeamlessLevelTravel,
	[StatDll(Dll = "B1UI.Script")]
	IsNeedPostLeaveLevel,
	[StatDll(Dll = "B1UI.Script")]
	IsNeedPreEnterLevel,
	IsNeedResetGameInstanceData,
	CheckGlobalTravelMode,
	[StatDll(Dll = "B1UI.Script")]
	IsNeedOpenLoadingScreen,
	[StatDll(Dll = "B1UI.Script")]
	IsNeedCloseLoadingScreen,
	[StatDll(Dll = "B1UI.Script")]
	IsFirstStartGame,
	CheckGMFlagsSupportUnknownTravel,
	IsDriverVersionMismatch,
	IsPlayGoDownloadIncomplete,
	[StatDll(Dll = "B1UI.Script")]
	SwitchFillContextArchiveDataType,
	IsNeedPreStartGameProcess,
	[StatDll(Dll = "B1UI.Script")]
	SwitchSaveArchiveDegree,
	[StatDll(Dll = "B1UI.Script")]
	DetermineTravelLevelByHandlingArchive
}
