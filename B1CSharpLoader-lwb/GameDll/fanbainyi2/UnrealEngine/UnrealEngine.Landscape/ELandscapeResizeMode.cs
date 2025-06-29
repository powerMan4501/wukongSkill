using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeResizeMode", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeResizeMode
{
	Resample,
	Clip,
	Expand
}
