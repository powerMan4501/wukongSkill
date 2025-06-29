using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EWeatherType", "b1", UnrealModuleType.Game)]
public enum EWeatherType : byte
{
	None,
	Snowy,
	Rainy
}
