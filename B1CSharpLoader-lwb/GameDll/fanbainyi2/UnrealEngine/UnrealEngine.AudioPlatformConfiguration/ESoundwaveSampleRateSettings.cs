using UnrealEngine.Runtime;

namespace UnrealEngine.AudioPlatformConfiguration;

[UEnum]
[UMetaPath("/Script/AudioPlatformConfiguration.ESoundwaveSampleRateSettings", "AudioPlatformConfiguration", UnrealModuleType.Engine)]
public enum ESoundwaveSampleRateSettings
{
	Max,
	High,
	Medium,
	Low,
	Min,
	MatchDevice
}
