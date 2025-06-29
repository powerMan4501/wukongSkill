using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneEventTrack", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneEventTrack : UMovieSceneNameableTrack, IMovieSceneTrackTemplateProducer, IInterface, IMovieSceneDeterminismSource
{
}
