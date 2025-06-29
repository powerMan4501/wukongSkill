using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGActorSelection", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGActorSelection
{
	ByTag,
	ByName,
	ByClass,
	Unknown
}
