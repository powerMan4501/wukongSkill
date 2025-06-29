using UnrealEngine.Runtime;

namespace UnrealEngine.HardwareTargeting;

[UEnum]
[UMetaPath("/Script/HardwareTargeting.EGraphicsPreset", "HardwareTargeting", UnrealModuleType.Engine)]
public enum EGraphicsPreset
{
	Unspecified,
	Maximum,
	Scalable
}
