using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETrajectorySampleDomain", "Engine", UnrealModuleType.Engine)]
public enum ETrajectorySampleDomain : byte
{
	None,
	Time,
	Distance
}
