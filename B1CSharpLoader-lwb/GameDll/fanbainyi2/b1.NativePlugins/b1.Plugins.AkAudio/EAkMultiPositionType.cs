using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMultiPositionType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkMultiPositionType : byte
{
	SingleSource,
	MultiSources,
	MultiDirections
}
