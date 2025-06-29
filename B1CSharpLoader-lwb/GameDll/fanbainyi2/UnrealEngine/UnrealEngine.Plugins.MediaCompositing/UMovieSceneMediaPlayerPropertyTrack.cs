using UnrealEngine.MovieScene;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositing;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertyTrack", "MediaCompositing", UnrealModuleType.EnginePlugin)]
public class UMovieSceneMediaPlayerPropertyTrack : UMovieScenePropertyTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
