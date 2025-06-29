using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.EWaterReflectionMode", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public enum EWaterReflectionMode : byte
{
	None = 0,
	Lumen = 1,
	ReflectionSphere = 3
}
