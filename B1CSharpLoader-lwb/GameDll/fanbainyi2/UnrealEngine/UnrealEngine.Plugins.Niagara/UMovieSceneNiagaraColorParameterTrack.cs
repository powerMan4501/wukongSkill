using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Niagara.MovieSceneNiagaraColorParameterTrack", "Niagara", UnrealModuleType.EnginePlugin)]
public class UMovieSceneNiagaraColorParameterTrack : UMovieSceneNiagaraParameterTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
