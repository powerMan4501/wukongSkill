using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENDIExport_GPUAllocationMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENDIExport_GPUAllocationMode
{
	FixedSize,
	PerParticle
}
