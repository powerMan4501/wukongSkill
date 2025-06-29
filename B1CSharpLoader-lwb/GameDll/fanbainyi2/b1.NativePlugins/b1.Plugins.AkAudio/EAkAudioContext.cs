using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.EAkAudioContext", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkAudioContext : byte
{
	Foreign,
	GameplayAudio,
	EditorAudio,
	AlwaysActive
}
