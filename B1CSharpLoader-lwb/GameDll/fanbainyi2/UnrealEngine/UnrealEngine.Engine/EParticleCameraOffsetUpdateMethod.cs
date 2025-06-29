using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleCameraOffsetUpdateMethod", "Engine", UnrealModuleType.Engine)]
public enum EParticleCameraOffsetUpdateMethod
{
	EPCOUM_DirectSet,
	EPCOUM_Additive,
	EPCOUM_Scalar
}
