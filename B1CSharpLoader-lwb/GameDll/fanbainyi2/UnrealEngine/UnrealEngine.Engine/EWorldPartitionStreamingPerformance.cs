using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EWorldPartitionStreamingPerformance", "Engine", UnrealModuleType.Engine)]
public enum EWorldPartitionStreamingPerformance
{
	Good,
	Slow,
	Critical
}
