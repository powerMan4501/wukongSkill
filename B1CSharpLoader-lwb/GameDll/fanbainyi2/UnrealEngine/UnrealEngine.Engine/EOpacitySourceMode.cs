using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EOpacitySourceMode", "Engine", UnrealModuleType.Engine)]
public enum EOpacitySourceMode
{
	OSM_Alpha,
	OSM_ColorBrightness,
	OSM_RedChannel,
	OSM_GreenChannel,
	OSM_BlueChannel
}
