using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.ESwapAudioOutputDeviceResultState", "AudioMixer", UnrealModuleType.Engine)]
public enum ESwapAudioOutputDeviceResultState : byte
{
	Failure,
	Success,
	None
}
