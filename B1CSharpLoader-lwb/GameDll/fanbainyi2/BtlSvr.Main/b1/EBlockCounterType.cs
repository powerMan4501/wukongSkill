using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BlockCounterType")]
public enum EBlockCounterType : byte
{
	[Tooltip("格挡弹开动画播放后才计数")]
	[DisplayName("攻击反弹后计数")]
	AddCountAfterBounced,
	[DisplayName("格挡动画播放后计数")]
	[Tooltip("格挡动画播放后才计数")]
	AddCountAfterBlock
}
