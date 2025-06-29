using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataTransformOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataTransformOperation
{
	Compose,
	Invert,
	Lerp
}
