using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGActorFilter", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGActorFilter
{
	Self,
	Parent,
	Root,
	AllWorldActors,
	Original
}
