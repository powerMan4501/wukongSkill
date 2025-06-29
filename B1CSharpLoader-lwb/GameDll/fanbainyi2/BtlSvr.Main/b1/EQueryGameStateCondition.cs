using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.QueryGameStateCondition")]
public enum EQueryGameStateCondition : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("已有存档")]
	HasArchive,
	[DisplayName("调试模式")]
	IsDebug,
	[DisplayName("没有存档")]
	NoArchive,
	[DisplayName("非调试模式")]
	NotInDebug,
	[DisplayName("无缝新游戏")]
	SeamlessStartNewGame,
	[DisplayName("正常新游戏")]
	GenericStartNewGame
}
