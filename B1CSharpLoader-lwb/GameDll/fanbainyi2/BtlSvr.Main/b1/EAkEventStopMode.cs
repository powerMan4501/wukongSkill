using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AkEventStopMode")]
public enum EAkEventStopMode : byte
{
	[UMeta(MD.DisplayName, "播放完毕自动停止")]
	Auto,
	[UMeta(MD.DisplayName, "角色死亡时停止")]
	WhenUnitDead,
	[UMeta(MD.DisplayName, "持续一段时间停止")]
	ByTime
}
