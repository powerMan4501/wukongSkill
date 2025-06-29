using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.OverlapState")]
public enum EOverlapState : byte
{
	[DisplayName("打开（可触发）")]
	Enabled,
	[DisplayName("关闭（不可触发）")]
	Disabled
}
