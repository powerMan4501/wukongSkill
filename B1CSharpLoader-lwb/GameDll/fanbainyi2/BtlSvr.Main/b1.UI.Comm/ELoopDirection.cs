using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.LoopDirection")]
public enum ELoopDirection : byte
{
	[DisplayName("从左到右")]
	LeftToRight,
	[DisplayName("从右到左")]
	RightToLeft
}
