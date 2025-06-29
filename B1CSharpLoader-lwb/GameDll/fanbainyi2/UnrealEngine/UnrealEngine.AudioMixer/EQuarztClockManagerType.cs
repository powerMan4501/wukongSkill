using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.EQuarztClockManagerType", "AudioMixer", UnrealModuleType.Engine)]
public enum EQuarztClockManagerType : byte
{
	AudioEngine,
	QuartzSubsystem,
	Count
}
