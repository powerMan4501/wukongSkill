using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleScreenAlignment", "Engine", UnrealModuleType.Engine)]
public enum EParticleScreenAlignment
{
	PSA_FacingCameraPosition,
	PSA_Square,
	PSA_Rectangle,
	PSA_Velocity,
	PSA_AwayFromCenter,
	PSA_TypeSpecific,
	PSA_FacingCameraDistanceBlend
}
