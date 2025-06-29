using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UEnum]
[UMetaPath("/Script/Water.EBuoyancyEvent", "Water", UnrealModuleType.EnginePlugin)]
public enum EBuoyancyEvent
{
	EnteredWaterBody,
	ExitedWaterBody
}
