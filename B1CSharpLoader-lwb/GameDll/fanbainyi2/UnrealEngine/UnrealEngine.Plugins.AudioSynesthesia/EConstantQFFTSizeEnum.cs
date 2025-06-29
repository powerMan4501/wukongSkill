using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.EConstantQFFTSizeEnum", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public enum EConstantQFFTSizeEnum : byte
{
	Min,
	XXSmall,
	XSmall,
	Small,
	Medium,
	Large,
	XLarge,
	XXLarge,
	Max
}
