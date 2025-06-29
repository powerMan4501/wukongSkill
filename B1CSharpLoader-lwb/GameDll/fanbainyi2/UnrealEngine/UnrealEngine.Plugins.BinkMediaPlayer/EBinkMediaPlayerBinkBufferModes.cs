using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UEnum]
[UMetaPath("/Script/BinkMediaPlayer.EBinkMediaPlayerBinkBufferModes", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public enum EBinkMediaPlayerBinkBufferModes
{
	BMASM_Bink_Stream,
	BMASM_Bink_PreloadAll,
	BMASM_Bink_StreamUntilResident
}
