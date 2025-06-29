using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EUnitDisplay", "UnrealEd", UnrealModuleType.Engine)]
public enum EUnitDisplay
{
	None,
	Metric,
	Imperial,
	Invalid
}
