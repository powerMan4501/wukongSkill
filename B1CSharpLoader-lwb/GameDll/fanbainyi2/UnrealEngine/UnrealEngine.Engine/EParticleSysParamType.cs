using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EParticleSysParamType", "Engine", UnrealModuleType.Engine)]
public enum EParticleSysParamType : byte
{
	PSPT_None,
	PSPT_Scalar,
	PSPT_ScalarRand,
	PSPT_Vector,
	PSPT_VectorRand,
	PSPT_Color,
	PSPT_Actor,
	PSPT_Material,
	PSPT_VectorUnitRand
}
