using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVectorNoiseFunction", "Engine", UnrealModuleType.Engine)]
public enum EVectorNoiseFunction
{
	VNF_CellnoiseALU,
	VNF_VectorALU,
	VNF_GradientALU,
	VNF_CurlALU,
	VNF_VoronoiALU
}
