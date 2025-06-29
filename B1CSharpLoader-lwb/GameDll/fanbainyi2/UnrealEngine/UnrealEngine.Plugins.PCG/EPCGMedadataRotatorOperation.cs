using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMedadataRotatorOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMedadataRotatorOperation
{
	RotatorOp = 0,
	Combine = 1,
	Invert = 2,
	Lerp = 3,
	Normalize = 4,
	TransformOp = 100,
	TransformRotation = 101,
	InverseTransformRotation = 102
}
