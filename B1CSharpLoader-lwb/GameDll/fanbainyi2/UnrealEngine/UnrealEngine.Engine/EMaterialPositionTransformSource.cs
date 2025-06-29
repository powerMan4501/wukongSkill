using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialPositionTransformSource", "Engine", UnrealModuleType.Engine)]
public enum EMaterialPositionTransformSource
{
	TRANSFORMPOSSOURCE_Local,
	TRANSFORMPOSSOURCE_World,
	TRANSFORMPOSSOURCE_TranslatedWorld,
	TRANSFORMPOSSOURCE_View,
	TRANSFORMPOSSOURCE_Camera,
	TRANSFORMPOSSOURCE_Particle,
	TRANSFORMPOSSOURCE_Instance
}
