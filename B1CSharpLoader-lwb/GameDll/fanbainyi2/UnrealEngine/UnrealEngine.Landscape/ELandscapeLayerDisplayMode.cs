using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeLayerDisplayMode", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeLayerDisplayMode
{
	Default,
	Alphabetical,
	UserSpecific
}
