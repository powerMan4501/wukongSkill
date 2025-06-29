using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSystemUpdateMode", "Engine", UnrealModuleType.Engine)]
public enum EParticleSystemUpdateMode
{
	EPSUM_RealTime,
	EPSUM_FixedTime
}
