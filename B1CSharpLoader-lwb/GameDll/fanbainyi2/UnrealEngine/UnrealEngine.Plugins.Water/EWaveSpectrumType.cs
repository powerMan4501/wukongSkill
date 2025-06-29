using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UEnum]
[UMetaPath("/Script/Water.EWaveSpectrumType", "Water", UnrealModuleType.EnginePlugin)]
public enum EWaveSpectrumType
{
	Phillips,
	PiersonMoskowitz,
	JONSWAP
}
