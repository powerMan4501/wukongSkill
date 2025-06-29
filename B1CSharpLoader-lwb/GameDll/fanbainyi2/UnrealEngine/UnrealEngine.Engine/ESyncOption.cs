using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESyncOption", "Engine", UnrealModuleType.Engine)]
public enum ESyncOption : byte
{
	Drive,
	Passive,
	Disabled
}
