using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGW_DispLibEnvWeather", "b1", UnrealModuleType.Game)]
public enum EBGW_DispLibEnvWeather : byte
{
	Sunny,
	Mist,
	Rain,
	Fog,
	Snow,
	SandStorm,
	Narrative,
	Night
}
