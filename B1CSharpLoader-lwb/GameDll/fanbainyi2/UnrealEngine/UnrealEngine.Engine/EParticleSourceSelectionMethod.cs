using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSourceSelectionMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleSourceSelectionMethod
{
	EPSSM_Random,
	EPSSM_Sequential
}
