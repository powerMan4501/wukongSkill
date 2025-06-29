using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESourceBusChannels", "Engine", UnrealModuleType.Engine)]
public enum ESourceBusChannels : byte
{
	Mono,
	Stereo
}
