using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/b1.EVolumeStreamingMethod", "b1", UnrealModuleType.Game)]
public enum EVolumeStreamingMethod
{
	StreamingLevel,
	WorldCompositionGroup,
	WorldPartition
}
