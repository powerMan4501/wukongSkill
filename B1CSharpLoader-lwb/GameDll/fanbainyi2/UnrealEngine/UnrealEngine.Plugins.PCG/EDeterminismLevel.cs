using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EDeterminismLevel", "PCG", UnrealModuleType.EnginePlugin)]
public enum EDeterminismLevel
{
	None = 0,
	NoDeterminism = 0,
	Basic = 1,
	OrderOrthogonal = 2,
	OrderConsistent = 3,
	OrderIndependent = 4,
	Deterministic = 4
}
