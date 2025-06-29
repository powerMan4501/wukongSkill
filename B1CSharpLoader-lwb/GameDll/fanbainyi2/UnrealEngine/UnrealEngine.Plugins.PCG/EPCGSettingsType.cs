using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSettingsType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSettingsType
{
	InputOutput,
	Spatial,
	Density,
	Blueprint,
	Metadata,
	Filter,
	Sampler,
	Spawner,
	Subgraph,
	Debug,
	Generic,
	Param,
	HierarchicalGeneration,
	ControlFlow
}
