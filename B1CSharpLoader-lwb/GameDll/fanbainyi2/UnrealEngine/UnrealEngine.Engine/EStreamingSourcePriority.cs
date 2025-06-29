using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EStreamingSourcePriority", "Engine", UnrealModuleType.Engine)]
public enum EStreamingSourcePriority : byte
{
	Highest = 0,
	High = 64,
	Normal = 128,
	Low = 192,
	Lowest = byte.MaxValue,
	Default = 128
}
