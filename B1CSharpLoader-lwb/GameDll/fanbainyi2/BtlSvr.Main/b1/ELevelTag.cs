using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.LevelTag")]
public enum ELevelTag : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("集会所")]
	Party,
	[DisplayName("支持坐骑")]
	SupportRide,
	[DisplayName("支持地图")]
	SupportOpenMap,
	[DisplayName("结局")]
	Ending
}
