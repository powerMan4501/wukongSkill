using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.EMeterPeakType", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public enum EMeterPeakType : byte
{
	MeanSquared,
	RootMeanSquared,
	Peak,
	Count
}
