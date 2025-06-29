using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.FNavigationSystemRunMode", "Engine", UnrealModuleType.Engine)]
public enum EFNavigationSystemRunMode
{
	InvalidMode,
	GameMode,
	EditorMode,
	SimulationMode,
	PIEMode,
	InferFromWorldMode
}
