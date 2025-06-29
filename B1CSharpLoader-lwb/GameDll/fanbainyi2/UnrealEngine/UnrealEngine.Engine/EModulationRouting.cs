using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EModulationRouting", "Engine", UnrealModuleType.Engine)]
public enum EModulationRouting : byte
{
	Disable,
	Inherit,
	Override
}
