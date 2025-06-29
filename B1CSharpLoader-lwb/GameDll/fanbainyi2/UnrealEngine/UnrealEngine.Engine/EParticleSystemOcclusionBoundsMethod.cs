using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSystemOcclusionBoundsMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleSystemOcclusionBoundsMethod
{
	EPSOBM_None,
	EPSOBM_ParticleBounds,
	EPSOBM_CustomBounds
}
