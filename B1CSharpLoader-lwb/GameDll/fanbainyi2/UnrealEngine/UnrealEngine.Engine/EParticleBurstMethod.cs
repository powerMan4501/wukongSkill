using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleBurstMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleBurstMethod
{
	EPBM_Instant,
	EPBM_Interpolated
}
