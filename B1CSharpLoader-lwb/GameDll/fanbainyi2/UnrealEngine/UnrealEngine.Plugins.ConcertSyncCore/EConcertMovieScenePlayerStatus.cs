using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertMovieScenePlayerStatus", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertMovieScenePlayerStatus
{
	Stopped,
	Playing,
	Scrubbing,
	Jumping,
	Stepping,
	Paused
}
