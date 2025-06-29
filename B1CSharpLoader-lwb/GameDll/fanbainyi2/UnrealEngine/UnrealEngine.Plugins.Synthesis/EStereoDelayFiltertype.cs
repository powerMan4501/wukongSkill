using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EStereoDelayFiltertype", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EStereoDelayFiltertype : byte
{
	Lowpass,
	Highpass,
	Bandpass,
	Notch,
	Count
}
