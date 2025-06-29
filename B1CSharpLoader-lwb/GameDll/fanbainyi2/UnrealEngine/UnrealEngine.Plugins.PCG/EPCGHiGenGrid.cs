using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGHiGenGrid", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGHiGenGrid
{
	Uninitialized = 0,
	Grid32 = 32,
	Grid64 = 64,
	Grid128 = 128,
	Grid256 = 256,
	Grid512 = 512,
	Grid1024 = 1024,
	Grid2048 = 2048,
	GridMin = 32,
	GridMax = 2048,
	Unbounded = 4096,
	GenerationDefault = 8192
}
