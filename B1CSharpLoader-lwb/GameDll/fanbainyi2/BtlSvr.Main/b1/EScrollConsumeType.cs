using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ScrollConsumeType")]
public enum EScrollConsumeType : byte
{
	[DisplayName("默认消耗")]
	Normal,
	[DisplayName("不消耗")]
	NotConsumed,
	[DisplayName("可滚动时消耗")]
	CanScroll
}
