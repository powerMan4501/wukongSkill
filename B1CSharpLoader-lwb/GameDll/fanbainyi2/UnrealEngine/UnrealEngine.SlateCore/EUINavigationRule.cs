using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EUINavigationRule", "SlateCore", UnrealModuleType.Engine)]
public enum EUINavigationRule : byte
{
	Escape,
	Explicit,
	Wrap,
	Stop,
	Custom,
	CustomBoundary,
	Invalid
}
