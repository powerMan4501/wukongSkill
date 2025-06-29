using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TeleportPointType")]
public enum ETeleportPointType : byte
{
	[DisplayName("通过缓存好的交互物位置")]
	CachedInteractItem
}
