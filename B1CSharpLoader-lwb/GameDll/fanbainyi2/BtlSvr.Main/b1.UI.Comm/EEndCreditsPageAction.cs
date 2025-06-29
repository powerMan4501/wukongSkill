using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[USharpPath("/Script/b1-Managed.EndCreditsPageAction")]
public enum EEndCreditsPageAction : byte
{
	[DisplayName("动画入场，结束切换")]
	Anim,
	[DisplayName("动画入场，结束开始滚动，滚动结束切换")]
	AnimAndScroll,
	[DisplayName("直接开始滚动，滚动结束切换")]
	Scroll,
	[DisplayName("切换速度并开始滚动，滚动结束切换")]
	SwitchSpeedScroll,
	[DisplayName("滚动到中间，播放动画结束")]
	ScrollAnimEnd
}
