using UnrealEngine.Runtime;

namespace UnrealEngine.HardwareTargeting;

[UEnum]
[UMetaPath("/Script/HardwareTargeting.EHardwareClass", "HardwareTargeting", UnrealModuleType.Engine)]
public enum EHardwareClass
{
	Unspecified,
	Desktop,
	Mobile
}
