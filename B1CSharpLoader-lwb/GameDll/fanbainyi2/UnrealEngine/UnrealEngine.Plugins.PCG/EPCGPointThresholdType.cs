using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointThresholdType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointThresholdType
{
	Property,
	Metadata,
	Constant
}
