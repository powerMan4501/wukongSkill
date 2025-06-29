using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGFilterByTagOperation", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGFilterByTagOperation
{
	KeepTagged,
	RemoveTagged
}
