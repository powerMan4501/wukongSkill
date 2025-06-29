using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkCommSystem", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkCommSystem
{
	Socket,
	HTCS
}
