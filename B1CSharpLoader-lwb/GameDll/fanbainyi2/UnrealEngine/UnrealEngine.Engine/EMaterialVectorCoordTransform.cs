using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialVectorCoordTransform", "Engine", UnrealModuleType.Engine)]
public enum EMaterialVectorCoordTransform
{
	TRANSFORM_Tangent,
	TRANSFORM_Local,
	TRANSFORM_World,
	TRANSFORM_View,
	TRANSFORM_Camera,
	TRANSFORM_ParticleWorld,
	TRANSFORM_Instance
}
