using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TraceSpawnType")]
public enum ETraceSpawnType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("根据传送点编号生成")]
	ByTeleportIndex,
	[UMeta(MD.Hidden)]
	EnumMax
}
