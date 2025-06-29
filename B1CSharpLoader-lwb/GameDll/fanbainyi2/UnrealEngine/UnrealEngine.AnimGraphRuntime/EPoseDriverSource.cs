using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EPoseDriverSource", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EPoseDriverSource : byte
{
	Rotation,
	Translation
}
