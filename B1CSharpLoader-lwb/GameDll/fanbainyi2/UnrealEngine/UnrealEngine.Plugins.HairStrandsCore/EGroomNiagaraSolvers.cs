using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomNiagaraSolvers", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomNiagaraSolvers : byte
{
	None = 0,
	CosseratRods = 2,
	AngularSprings = 4,
	CustomSolver = 8
}
