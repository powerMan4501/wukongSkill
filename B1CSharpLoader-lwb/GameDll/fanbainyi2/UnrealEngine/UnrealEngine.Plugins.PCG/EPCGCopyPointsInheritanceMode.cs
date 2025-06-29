using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGCopyPointsInheritanceMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGCopyPointsInheritanceMode
{
	Relative,
	Source,
	Target
}
