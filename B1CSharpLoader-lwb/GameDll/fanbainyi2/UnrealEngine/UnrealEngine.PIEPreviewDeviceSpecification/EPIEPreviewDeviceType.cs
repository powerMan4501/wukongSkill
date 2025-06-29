using UnrealEngine.Runtime;

namespace UnrealEngine.PIEPreviewDeviceSpecification;

[UEnum]
[UMetaPath("/Script/PIEPreviewDeviceSpecification.EPIEPreviewDeviceType", "PIEPreviewDeviceSpecification", UnrealModuleType.Engine)]
public enum EPIEPreviewDeviceType
{
	Unset,
	Android,
	IOS,
	TVOS,
	Switch
}
