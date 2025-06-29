using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.ERTPCValueType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum ERTPCValueType : byte
{
	Default,
	Global,
	GameObject,
	PlayingID,
	Unavailable
}
