using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UEnum]
[UMetaPath("/Script/BinkMediaPlayer.EBinkMoviePlayerBinkBufferModes", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public enum EBinkMoviePlayerBinkBufferModes
{
	MP_Bink_Stream,
	MP_Bink_PreloadAll,
	MP_Bink_StreamUntilResident
}
