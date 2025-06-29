using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureSamplerFilter", "Engine", UnrealModuleType.Engine)]
public enum ETextureSamplerFilter
{
	Point,
	Bilinear,
	Trilinear,
	AnisotropicPoint,
	AnisotropicLinear
}
