using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.EScriptExecutionMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum EScriptExecutionMode
{
	EveryParticle,
	SpawnedParticles,
	SingleParticle
}
