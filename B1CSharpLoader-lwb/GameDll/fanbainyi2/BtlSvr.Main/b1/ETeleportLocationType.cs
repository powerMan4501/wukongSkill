using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TeleportLocationType")]
public enum ETeleportLocationType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("当前Boss踪迹中心点")]
	BossTraceCenter,
	[DisplayName("当前踪迹路点(随机)")]
	BossTracePointRandom,
	[UMeta(MD.Hidden)]
	EnumMax
}
