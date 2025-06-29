using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkPanningRule", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkPanningRule
{
	Speakers,
	Headphones
}
