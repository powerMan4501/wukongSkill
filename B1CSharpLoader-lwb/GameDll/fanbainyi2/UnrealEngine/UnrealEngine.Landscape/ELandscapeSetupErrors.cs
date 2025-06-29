using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeSetupErrors", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeSetupErrors
{
	LSE_None,
	LSE_NoLandscapeInfo,
	LSE_CollsionXY,
	LSE_NoLayerInfo
}
