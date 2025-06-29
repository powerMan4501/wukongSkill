using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.GlobalTravelLevelType")]
public enum EGlobalTravelLevelType : byte
{
	[UMeta(MD.Hidden)]
	None,
	Unknown,
	[DisplayName("通用传送")]
	Generic,
	[DisplayName("开始新游戏")]
	StartNewGame,
	[DisplayName("开始新周目")]
	StartNewGamePlus,
	[DisplayName("回主界面")]
	BackToMainMenu,
	[DisplayName("读存档")]
	ReadArchive,
	[DisplayName("GM带档跳转")]
	GMTravel,
	[DisplayName("进入联机关卡")]
	Online,
	[DisplayName("通关")]
	GameLevelPass,
	[DisplayName("游戏邀请")]
	GameIntent,
	[DisplayName("WXLogin登录完成")]
	WXLoginFinish,
	[DisplayName("玩家初次进入游戏设置完成")]
	SetConfigFinish,
	[DisplayName("通过Play Go返回主菜单")]
	BackToMainMenuByPlayGo,
	[DisplayName("年会")]
	Nianhui,
	BenchMark,
	[DisplayName("无感开启新游戏")]
	SeamlessStartNewGame,
	[DisplayName("回主界面(黑屏)")]
	BackToMainMenuFullBlack,
	[DisplayName("进入BossRush模式")]
	EnterBossRush,
	[DisplayName("退出BossRush模式")]
	LeaveBossRush,
	[DisplayName("BossRush返回主界面")]
	BackToMainMenuBossRush
}
