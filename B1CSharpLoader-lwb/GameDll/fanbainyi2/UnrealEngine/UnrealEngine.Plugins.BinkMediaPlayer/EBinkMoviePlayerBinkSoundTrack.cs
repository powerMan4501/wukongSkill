using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UEnum]
[UMetaPath("/Script/BinkMediaPlayer.EBinkMoviePlayerBinkSoundTrack", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public enum EBinkMoviePlayerBinkSoundTrack
{
	MP_Bink_Sound_None,
	MP_Bink_Sound_Simple,
	MP_Bink_Sound_LanguageOverride,
	MP_Bink_Sound_51,
	MP_Bink_Sound_51LanguageOverride,
	MP_Bink_Sound_71,
	MP_Bink_Sound_71LanguageOverride
}
