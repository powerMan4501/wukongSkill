using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGUnionType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGUnionType
{
	LeftToRightPriority,
	RightToLeftPriority,
	KeepAll
}
