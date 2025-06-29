using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SGI_Global")]
public enum SGI_Global : byte
{
	WaitGameStart,
	MainMenu,
	InBattleWaitingStartNewGame,
	WXLogin,
	WaittingSelectLevel820Demo,
	InBattleStandAlone,
	InBattleParty,
	InBattleOnLineClient,
	InBattleOnLineLS,
	InBattleOnLineDS,
	OpenMainMenuLevel,
	SubG_GI_Loading_StartUp,
	SubG_GI_Loading_StartNewGame,
	SubG_GI_Loading_Teleport,
	SubG_GI_Loading_GameLevelPass,
	SubG_GI_Loading_ToiletStandAlone,
	SubG_GI_Loading_ToiletListenServer,
	SubG_GI_Loading_ToiletDedicateServer,
	SubG_GI_Loading_ToiletClient,
	SubG_GI_Loading_UnKnowLevelTravel,
	SubG_GI_Loading_BackToMainMenu,
	SubG_GI_Loading_InitWXLogin,
	SubG_GI_Loading_PostWXLoginFinish,
	SubG_GI_Loading_ReplayBattle,
	SubG_GI_Loading_HandleDisConnect,
	SubG_GI_Loading_BackToStandAlone,
	SubG_GI_Loading_StartNewGamePlus,
	SubG_GI_Loading_SaveArchiveAndWaitFinish,
	SubG_GI_Loading_820DemoStartUp,
	SubG_GI_Loading_820DemoReSetGameData,
	SubG_GI_Loading_PreEnterMainMenu,
	SubG_GI_Loading_TravelLevel,
	SubG_GI_Loading_SetConfigAndPrecompilePSO,
	SubG_GI_Loading_TravelToNextChapter,
	SubG_GI_Loading_PreviewSequence,
	SubG_GI_Loading_ServerLogin,
	SubG_GI_Loading_PartyRoomServer,
	SubG_GI_Loading_PartyRoomClient,
	AsClientInGame,
	AsListenServerInGame,
	SubG_GI_Global_WXLogin,
	SubG_GI_Global_BenchMark,
	InBenchMark,
	SubG_GI_Loading_CheckGSSdkServerConfig
}
