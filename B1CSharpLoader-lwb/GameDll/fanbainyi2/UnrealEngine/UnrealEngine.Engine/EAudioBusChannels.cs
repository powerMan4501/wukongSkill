using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioBusChannels", "Engine", UnrealModuleType.Engine)]
public enum EAudioBusChannels : byte
{
	Mono = 0,
	Stereo = 1,
	Quad = 3,
	FivePointOne = 5,
	SevenPointOne = 7
}
