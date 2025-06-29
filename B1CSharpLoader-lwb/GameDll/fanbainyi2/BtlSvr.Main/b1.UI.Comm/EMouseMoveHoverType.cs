using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MouseMoveHoverType")]
public enum EMouseMoveHoverType : byte
{
	[DisplayName("进入Widget立即Hover")]
	Default,
	[DisplayName("移动时Hover")]
	MoveHover,
	[DisplayName("不运动时不触发Hover，直到重新进入UI")]
	StopUnhover
}
