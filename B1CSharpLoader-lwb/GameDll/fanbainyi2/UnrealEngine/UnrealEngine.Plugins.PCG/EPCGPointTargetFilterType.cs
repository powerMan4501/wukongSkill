using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointTargetFilterType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointTargetFilterType
{
	Property,
	Metadata
}
