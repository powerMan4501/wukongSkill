using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TransMusicConfig")]
public enum ETransMusicConfig : byte
{
	[DisplayName("按单位品质")]
	ByQuality,
	[DisplayName("允许触发变身音乐")]
	Enable,
	[DisplayName("禁止触发变身音乐")]
	Disable
}
