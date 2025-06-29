using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSpawnActorOption", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSpawnActorOption
{
	CollapseActors,
	MergePCGOnly,
	NoMerging
}
