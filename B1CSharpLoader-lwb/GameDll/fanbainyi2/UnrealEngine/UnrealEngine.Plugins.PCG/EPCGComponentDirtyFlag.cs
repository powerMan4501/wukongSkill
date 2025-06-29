using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGComponentDirtyFlag", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGComponentDirtyFlag
{
	None = 0,
	Actor = 1,
	Landscape = 2,
	Input = 4,
	Data = 8,
	All = 15
}
