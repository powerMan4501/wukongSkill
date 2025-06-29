using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGChangeType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGChangeType
{
	None = 0,
	Cosmetic = 1,
	Settings = 2,
	Input = 4,
	Edge = 8,
	Node = 0x10,
	Structural = 0x20
}
