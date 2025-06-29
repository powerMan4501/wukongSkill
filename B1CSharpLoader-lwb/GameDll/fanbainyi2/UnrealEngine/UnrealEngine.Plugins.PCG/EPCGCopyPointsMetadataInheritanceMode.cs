using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGCopyPointsMetadataInheritanceMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGCopyPointsMetadataInheritanceMode
{
	SourceFirst,
	TargetFirst,
	SourceOnly,
	TargetOnly,
	None
}
