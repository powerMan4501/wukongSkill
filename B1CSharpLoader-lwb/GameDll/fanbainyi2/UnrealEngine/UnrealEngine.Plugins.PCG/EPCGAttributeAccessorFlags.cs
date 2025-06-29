using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttributeAccessorFlags", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttributeAccessorFlags
{
	StrictType = 1,
	AllowBroadcast = 2,
	AllowConstructible = 4,
	AllowSetDefaultValue = 8
}
