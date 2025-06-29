using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectilePosOffsetSpace")]
public enum ProjectilePosOffsetSpace : byte
{
	[DisplayName("世界空间")]
	WorldSpace,
	[DisplayName("基准Actor本地空间")]
	BaseActorLocalSpace,
	[DisplayName("基准Actor插槽本地空间")]
	SocketLocalSpace
}
