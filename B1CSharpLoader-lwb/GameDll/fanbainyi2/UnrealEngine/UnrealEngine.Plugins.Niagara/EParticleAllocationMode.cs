using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.EParticleAllocationMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum EParticleAllocationMode
{
	AutomaticEstimate,
	ManualEstimate,
	FixedCount
}
