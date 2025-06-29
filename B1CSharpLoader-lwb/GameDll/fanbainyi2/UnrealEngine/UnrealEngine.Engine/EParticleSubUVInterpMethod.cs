using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSubUVInterpMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleSubUVInterpMethod
{
	PSUVIM_None,
	PSUVIM_Linear,
	PSUVIM_Linear_Blend,
	PSUVIM_Random,
	PSUVIM_Random_Blend
}
