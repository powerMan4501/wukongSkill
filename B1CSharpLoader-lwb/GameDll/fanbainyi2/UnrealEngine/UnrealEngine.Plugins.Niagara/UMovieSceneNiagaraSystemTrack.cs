using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)820510880uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Niagara.MovieSceneNiagaraSystemTrack", "Niagara", UnrealModuleType.EnginePlugin)]
public class UMovieSceneNiagaraSystemTrack : UMovieSceneNiagaraTrack, IMovieSceneTrackTemplateProducer, IInterface
{
}
