using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/TressFX.ETressFXSimulationQuality", "TressFX", UnrealModuleType.GamePlugin)]
public enum ETressFXSimulationQuality : byte
{
	TFXSim_Disable,
	TFXSim_Full
}
