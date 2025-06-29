using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshLODSelectionType", "Engine", UnrealModuleType.Engine)]
public enum EMeshLODSelectionType
{
	AllLODs,
	SpecificLOD,
	CalculateLOD,
	LowestDetailLOD
}
