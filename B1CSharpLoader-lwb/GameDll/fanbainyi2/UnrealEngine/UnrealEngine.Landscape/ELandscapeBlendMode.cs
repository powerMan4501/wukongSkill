using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeBlendMode", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeBlendMode
{
	LSBM_AdditiveBlend,
	LSBM_AlphaBlend
}
