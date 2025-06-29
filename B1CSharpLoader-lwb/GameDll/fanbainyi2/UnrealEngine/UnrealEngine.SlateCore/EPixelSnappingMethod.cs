using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EPixelSnappingMethod", "SlateCore", UnrealModuleType.Engine)]
public enum EPixelSnappingMethod
{
	Inherit,
	Disabled,
	SnapToPixel
}
