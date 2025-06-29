using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeSelectAxis", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeSelectAxis
{
	X,
	Y,
	Z,
	W,
	CustomAxis
}
