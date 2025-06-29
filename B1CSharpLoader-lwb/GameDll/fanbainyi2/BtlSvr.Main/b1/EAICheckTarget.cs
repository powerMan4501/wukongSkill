using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EAICheckTarget")]
public enum EAICheckTarget : byte
{
	[DisplayName("缓存场景物件")]
	CachedScencItem,
	[DisplayName("当前锁定目标")]
	CurLockTarget,
	[DisplayName("【单机用】本地玩家")]
	FirstLocalPlayer,
	[DisplayName("EQSTarget")]
	EQSTarget
}
