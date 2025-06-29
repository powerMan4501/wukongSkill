using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioVolumeLocationState", "Engine", UnrealModuleType.Engine)]
public enum EAudioVolumeLocationState : byte
{
	InsideTheVolume,
	OutsideTheVolume
}
