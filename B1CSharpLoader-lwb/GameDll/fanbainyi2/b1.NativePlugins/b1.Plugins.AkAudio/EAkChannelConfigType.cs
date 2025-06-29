using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkChannelConfigType", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkChannelConfigType
{
	Anonymous,
	Standard,
	Ambisonic
}
