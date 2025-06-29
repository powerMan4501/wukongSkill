using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENoiseFunction", "Engine", UnrealModuleType.Engine)]
public enum ENoiseFunction
{
	NOISEFUNCTION_SimplexTex,
	NOISEFUNCTION_GradientTex,
	NOISEFUNCTION_GradientTex3D,
	NOISEFUNCTION_GradientALU,
	NOISEFUNCTION_ValueALU,
	NOISEFUNCTION_VoronoiALU
}
