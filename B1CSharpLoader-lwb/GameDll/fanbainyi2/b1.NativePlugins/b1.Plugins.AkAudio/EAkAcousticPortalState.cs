using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkAcousticPortalState", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAcousticPortalState : byte
{
	Closed,
	Open
}
