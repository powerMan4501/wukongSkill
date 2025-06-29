using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPinContainerType", "Engine", UnrealModuleType.Engine)]
public enum EPinContainerType
{
	None,
	Array,
	Set,
	Map
}
