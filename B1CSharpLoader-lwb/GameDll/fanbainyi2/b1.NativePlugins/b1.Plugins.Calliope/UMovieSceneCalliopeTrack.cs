using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.MovieSceneCalliopeTrack", "Calliope", UnrealModuleType.GamePlugin)]
public class UMovieSceneCalliopeTrack : UMovieSceneNameableTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
