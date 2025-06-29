using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStereoLayerShape", "Engine", UnrealModuleType.Engine)]
public enum EStereoLayerShape
{
	SLSH_QuadLayer,
	SLSH_CylinderLayer,
	SLSH_CubemapLayer,
	SLSH_EquirectLayer
}
