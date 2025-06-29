using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EClothLODBiasMode", "Engine", UnrealModuleType.Engine)]
public enum EClothLODBiasMode
{
	MappingsToSameLOD,
	MappingsToMinLOD,
	MappingsToAnyLOD
}
