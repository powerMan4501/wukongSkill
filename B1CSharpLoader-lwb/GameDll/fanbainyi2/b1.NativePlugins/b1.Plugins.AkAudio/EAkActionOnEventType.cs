using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkActionOnEventType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkActionOnEventType : byte
{
	Stop,
	Pause,
	Resume,
	Break,
	ReleaseEnvelope
}
