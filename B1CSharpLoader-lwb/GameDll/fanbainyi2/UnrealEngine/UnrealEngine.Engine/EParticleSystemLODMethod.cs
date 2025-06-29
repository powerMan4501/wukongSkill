using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ParticleSystemLODMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleSystemLODMethod
{
	PARTICLESYSTEMLODMETHOD_Automatic,
	PARTICLESYSTEMLODMETHOD_DirectSet,
	PARTICLESYSTEMLODMETHOD_ActivateAutomatic
}
