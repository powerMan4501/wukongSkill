using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ApexDestruction;

[UEnum]
[UMetaPath("/Script/ApexDestruction.EImpactDamageOverride", "ApexDestruction", UnrealModuleType.EnginePlugin)]
public enum EImpactDamageOverride
{
	IDO_None,
	IDO_On,
	IDO_Off
}
