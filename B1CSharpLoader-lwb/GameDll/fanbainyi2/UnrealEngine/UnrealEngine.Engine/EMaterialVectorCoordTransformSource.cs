using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialVectorCoordTransformSource", "Engine", UnrealModuleType.Engine)]
public enum EMaterialVectorCoordTransformSource
{
	TRANSFORMSOURCE_Tangent,
	TRANSFORMSOURCE_Local,
	TRANSFORMSOURCE_World,
	TRANSFORMSOURCE_View,
	TRANSFORMSOURCE_Camera,
	TRANSFORMSOURCE_ParticleWorld,
	TRANSFORMSOURCE_Instance
}
