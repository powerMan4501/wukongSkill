using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGAttachOptions", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGAttachOptions
{
	NotAttached,
	Attached,
	InFolder
}
