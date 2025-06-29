using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EReflectionFilterBits", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EReflectionFilterBits
{
	Wall,
	Ceiling,
	Floor
}
