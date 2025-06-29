using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MediaCompositing;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaCompositing.MovieSceneMediaTrack", "MediaCompositing", UnrealModuleType.EnginePlugin)]
public class UMovieSceneMediaTrack : UMovieSceneNameableTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
