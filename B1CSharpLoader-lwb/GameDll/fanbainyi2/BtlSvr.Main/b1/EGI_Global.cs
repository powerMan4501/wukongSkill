using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGI_Global")]
public enum EGI_Global : byte
{
	WXLogin,
	ToiletStandAlone,
	StartUp,
	LoadArchive,
	StartNewGame,
	GameLevelPassFinal,
	GameLevelPass,
	ToiletListenServer,
	ToiletDedicateServer,
	ToiletClient,
	UnKnowLevelTravel,
	BackToMainMenu,
	WXLoginSuccess,
	ReplayBattle,
	TravelToNextChapter,
	PreviewSeq,
	PartyRoomServer,
	PartyRoomClient,
	ClientDisconnect,
	BackToStandAlone,
	QuickMonsterTeleport,
	StartNewGamePlus,
	Demo820ReSetData,
	BackToMainMenuByPlayGo,
	ReadArchiveFailed,
	BenchMark,
	GMLevelTravel,
	EnterBossRush,
	LeaveBossRush
}
