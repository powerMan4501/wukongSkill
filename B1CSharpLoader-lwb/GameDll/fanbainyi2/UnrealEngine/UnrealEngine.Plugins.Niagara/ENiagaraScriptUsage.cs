using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptUsage", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptUsage
{
	Function,
	Module,
	DynamicInput,
	ParticleSpawnScript,
	ParticleSpawnScriptInterpolated,
	ParticleUpdateScript,
	ParticleEventScript,
	ParticleSimulationStageScript,
	ParticleGPUComputeScript,
	EmitterSpawnScript,
	EmitterUpdateScript,
	SystemSpawnScript,
	SystemUpdateScript
}
