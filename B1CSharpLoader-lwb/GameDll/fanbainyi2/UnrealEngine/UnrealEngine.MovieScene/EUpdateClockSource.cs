using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EUpdateClockSource", "MovieScene", UnrealModuleType.Engine)]
public enum EUpdateClockSource : byte
{
	Tick,
	Platform,
	Audio,
	RelativeTimecode,
	Timecode,
	PlayEveryFrame,
	Custom
}
